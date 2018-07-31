Module RelabelOrderProcessing

    Public Enum RelabelOrderStatus
        PENDING
        INPROD
        COMPLETED
        CANCELLED
    End Enum

    Public Enum RelabelOrderItemStatus
        PENDING
        PRCH
        READY
        COMPLETED
        CANCELLED
    End Enum

    Public Function getViewRelabelOrder(vRelabelOrderStatus As RelabelOrderStatus) As ViewRelabelOrderCollection
        Dim oRelabelOrders As New ViewRelabelOrderCollection
        Select Case vRelabelOrderStatus
            Case RelabelOrderStatus.PENDING
                oRelabelOrders.Query.Where(oRelabelOrders.Query.Relabelorderstatus.In(RelabelOrderStatus.PENDING.ToString(), _
                                                                                      RelabelOrderStatus.INPROD.ToString()))
            Case RelabelOrderStatus.COMPLETED
                oRelabelOrders.Query.Where(oRelabelOrders.Query.Relabelorderstatus.Equal(RelabelOrderStatus.COMPLETED.ToString()))
            Case RelabelOrderStatus.CANCELLED
                oRelabelOrders.Query.Where(oRelabelOrders.Query.Relabelorderstatus.Equal(RelabelOrderStatus.CANCELLED.ToString()))
        End Select
        oRelabelOrders.Query.Load()
        Return oRelabelOrders
    End Function

    Public Function getViewRptRelabelOrder(ByVal vSdate As Date, ByVal vEdate As Date) As ViewRelabelOrderCollection
        Dim oRelabelOrders As New ViewRelabelOrderCollection
        oRelabelOrders.Query.Where(oRelabelOrders.Query.Neededby.Between(vSdate, vEdate))
        oRelabelOrders.Query.Load()
        Return oRelabelOrders
    End Function

    Public Sub cancelRelabelOrderAndItems(vRelabelordernumber As Integer, Optional vAllowWorkOrderProdOrders As Boolean = False)
        Dim oRelabelOrder As New Relabelorder
        If oRelabelOrder.LoadByPrimaryKey(vRelabelordernumber) = False Then
            Exit Sub
        End If

        If (Not oRelabelOrder.Workordernumber Is Nothing OrElse _
            oRelabelOrder.Workordernumber > 0) AndAlso _
            vAllowWorkOrderProdOrders = False Then

            MsgBox(String.Format("Relabel Order is linked to Work Order# {0}. You cannot cancel a Relabel Order " & _
                                "that is linked to a Work Order from this screen. Cancelling Relabel Order is controlled " & _
                                "by the Work Order Fulfillment Plan.", _
                                oRelabelOrder.Workordernumber.ToString), _
                    MsgBoxStyle.Critical, _
                    "Error")
            Exit Sub
        End If

        If allRelabelOrderItemsOpen(vRelabelordernumber) = False Then
            MsgBox("Some of the items in relabel order are COMPLETED or CANCELLED. We cannot proceed with cancelling the order.", _
                   MsgBoxStyle.OkOnly, "Cancel Relabel Order - Error")
        End If

        rollbackRelabelOrderItems(vRelabelordernumber)
    End Sub

    Public Sub processRelabelOrder(vWorkordernumber As Integer, vProductId As Integer, Optional oWOItems As WorkorderitemCollection = Nothing, Optional createSingleRelabelOrder As Boolean = True)
        If vWorkordernumber <= 0 Then
            Exit Sub
        End If

        Dim vRelabelOrderNumber As Integer
        If createSingleRelabelOrder Then
            If oWOItems Is Nothing Then
                oWOItems = getUnallocatedWorkOrderItems(vWorkordernumber, vProductId)
            End If

            If oWOItems Is Nothing OrElse _
                oWOItems.Count <= 0 Then
                Exit Sub
            End If

            Dim oRelabelOrder As Relabelorder = createRelabelOrder(vProductId, _
                                                                   1, _
                                                                   vWorkordernumber)
            vRelabelOrderNumber = oRelabelOrder.Relabelordernumber
        End If

        checkAndAssignInventory(AllocatedType.RELABEL, _
                                vWorkordernumber, _
                                vProductId, _
                                oWOItems, _
                                vRelabelOrderNumber)
        createRelabelOrderandFulfillByPRCH(vWorkordernumber, _
                                           vProductId, _
                                           oWOItems, _
                                           vRelabelOrderNumber)
        If vRelabelOrderNumber > 0 Then
            updateRelabelOrderQtyAndStatus(vRelabelOrderNumber)
        End If
    End Sub

    Public Sub assignRelabelOrderItemstoWorkOrderItems(oRelabelOrder As Relabelorder, oWOItems As WorkorderitemCollection)
        If oRelabelOrder Is Nothing Then
            Exit Sub
        End If

        If oWOItems Is Nothing AndAlso _
            Not oRelabelOrder.Workordernumber Is Nothing Then
            oWOItems = getUnallocatedWorkOrderItems(oRelabelOrder.Workordernumber, oRelabelOrder.Itemid)
        End If

        If oWOItems Is Nothing OrElse _
            oWOItems.Count <= 0 Then
            Exit Sub
        End If

        Dim oRelabelOrderItems As RelabelorderitemCollection
        oRelabelOrderItems = getRelabelOrderItems(oRelabelOrder.Relabelordernumber, _
                                                  , _
                                                  SourceType.PRCH.ToString())
        If oRelabelOrderItems Is Nothing Then
            Exit Sub
        End If

        If oRelabelOrderItems.Count <> oWOItems.Count Then
            Exit Sub
        End If

        Dim vIndex As Integer = 0
        For vIndex = 0 To oRelabelOrderItems.Count - 1
            'Update Work Order Item record
            updateWorkOrderItem(oWOItems(vIndex).Workorderitemnumber, oRelabelOrderItems(vIndex).Relabelorderitemnumber, SourceType.RLBL.ToString())
        Next
    End Sub

    Public Function createRelabelOrder(vProductId As Integer, vQty As Integer, Optional vWorkOrderNumber As Integer = 0) As Relabelorder
        Dim oRelabelOrder As New Relabelorder
        oRelabelOrder.Createdby = vCurrentUserLogin
        oRelabelOrder.Createdtime = Now
        oRelabelOrder.Relabelorderdate = Today
        oRelabelOrder.Itemid = vProductId
        oRelabelOrder.Qty = vQty

        Dim oWorkOrder As New Workorder
        If oWorkOrder.LoadByPrimaryKey(vWorkOrderNumber) = False Then
            oWorkOrder = Nothing
        End If

        oRelabelOrder.Relabelorderstatus = IIf(oWorkOrder Is Nothing OrElse _
                                oWorkOrder.Orderstatus = "PENDING", _
                                RelabelOrderStatus.PENDING.ToString(), _
                                RelabelOrderStatus.INPROD.ToString())

        If Not oWorkOrder Is Nothing Then
            oRelabelOrder.Custid = oWorkOrder.Custid
            oRelabelOrder.Workordernumber = oWorkOrder.Workordernumber
            oRelabelOrder.Neededby = getDateNeeded(oWorkOrder)
        End If

        oRelabelOrder.Save()
        Return oRelabelOrder
    End Function

    Public Sub createRelabelOrderItems(oWOItems As WorkorderitemCollection, oRelabelOrder As Relabelorder)
        If oRelabelOrder Is Nothing Then
            Exit Sub
        End If

        For vIndex As Integer = 0 To oWOItems.Count - 1
            createRelabelOrderItem(oWOItems(vIndex).Workorderitemnumber, oRelabelOrder)
        Next
    End Sub

    Public Function createRelabelOrderItem(vWorkorderitemnumber As Integer?, oRelabelOrder As Relabelorder) As Relabelorderitem
        If oRelabelOrder Is Nothing Then
            Return Nothing
        End If

        Dim oRelabelOrderItem As New Relabelorderitem
        oRelabelOrderItem.Createdtime = Now
        oRelabelOrderItem.Createdby = vCurrentUserLogin
        oRelabelOrderItem.Relabelordernumber = oRelabelOrder.Relabelordernumber
        oRelabelOrderItem.Relabelorderitemstatus = RelabelOrderItemStatus.PENDING.ToString()
        oRelabelOrderItem.Workorderitemnumber = vWorkorderitemnumber
        oRelabelOrderItem.Save()
        Return oRelabelOrderItem
    End Function

    Public Sub createRelabelOrderandFulfillByPRCH(vWorkordernumber As Integer, vProductId As Integer, Optional oWOItems As WorkorderitemCollection = Nothing, Optional vRelabelOrderNumber As Integer = 0)
        If vWorkordernumber <= 0 Then
            Exit Sub
        End If
        If vProductId <= 0 Then
            Exit Sub
        End If

        If oWOItems Is Nothing Then
            oWOItems = getUnallocatedWorkOrderItems(vWorkordernumber, vProductId)
        End If

        If oWOItems.Count <= 0 Then
            Exit Sub
        End If

        Dim oRelabelOrder As Relabelorder
        If vRelabelOrderNumber > 0 Then
            oRelabelOrder = New Relabelorder()
            If oRelabelOrder.LoadByPrimaryKey(vRelabelOrderNumber) = False Then
                Exit Sub
            End If
        Else
            oRelabelOrder = createRelabelOrder(vProductId, oWOItems.Count, vWorkordernumber)
        End If
        createRelabelOrderItems(oWOItems, oRelabelOrder)
        createPurchaseItemsAndFulfillRelabelOrder(oRelabelOrder)
        assignRelabelOrderItemstoWorkOrderItems(oRelabelOrder, oWOItems)
    End Sub

    Public Sub createPurchaseItemsAndFulfillRelabelOrder(oRelabelOrder As Relabelorder)
        If oRelabelOrder Is Nothing Then
            Exit Sub
        End If
        Dim oRelabelOrderItems As RelabelorderitemCollection = getUnallocatedRelabelOrderItems(oRelabelOrder.Relabelordernumber)
        If (oRelabelOrderItems.Count <= 0) Then
            Exit Sub
        End If
        Dim oProductFulfillments As ProductfulfillmentplanCollection = getFulfillmentPlan(oRelabelOrder.Itemid, FulfillmentType.RLBL)
        If oProductFulfillments Is Nothing Then
            Exit Sub
        End If
        If oProductFulfillments(0).Associatedproductid Is Nothing OrElse _
            oProductFulfillments(0).Associatedproductid <= 0 Then
            Exit Sub
        End If
        Dim oPurchaseItem As Purchaseitem = createPurchaseItem(PurchaseItemSourceType.RELABEL.ToString(), _
                                                               oRelabelOrder.Relabelordernumber, oProductFulfillments(0).Associatedproductid)
        If oPurchaseItem Is Nothing = False Then
            assignPurchaseItemtoRelabelOrderItems(oPurchaseItem, oRelabelOrderItems)
        End If
    End Sub

    Public Sub assignPurchaseItemtoRelabelOrderItems(vPurchaseItem As Purchaseitem, _
                                                       oRelabelOrderItems As RelabelorderitemCollection)
        If (vPurchaseItem Is Nothing) Then
            Exit Sub
        End If

        If (oRelabelOrderItems Is Nothing) Then
            Exit Sub
        End If

        For Each oItem As Relabelorderitem In oRelabelOrderItems
            updateRelabelOrderItem(oItem.Relabelorderitemnumber, SourceType.PRCH.ToString(), vPurchaseItem.Purchaseitemid, _
                                   vPurchaseItem.Itemid, Nothing, RelabelOrderItemStatus.PRCH.ToString())
        Next
    End Sub

    Public Sub updateRelabelOrderItem(vRelabelOrderItemNumber As Integer, vSourceType As String, vSouceDocument As Integer?, Optional vItemId As Integer? = Nothing, Optional vInvItemNumber As Integer? = Nothing, Optional vOrderItemStatus As String = "")
        If vRelabelOrderItemNumber <= 0 Then
            Exit Sub
        End If
        Dim oRelabelorderitem As New Relabelorderitem
        If oRelabelorderitem.LoadByPrimaryKey(vRelabelOrderItemNumber) = False Then
            Exit Sub
        End If

        oRelabelorderitem.Sourcetype = vSourceType
        oRelabelorderitem.Sourcedoc = vSouceDocument
        oRelabelorderitem.Invitemnum = vInvItemNumber
        If Not vItemId Is Nothing Then
            oRelabelorderitem.Itemid = vItemId
        End If
        oRelabelorderitem.Save()

        If vOrderItemStatus <> "" Then
            updateRelabelOrderAndItemStatus(vRelabelOrderItemNumber, vOrderItemStatus)
        End If

    End Sub

    Public Function getRelabelOrderItems(vRelabelordernumber As Integer, Optional vNotInRelabelOrderItemStatuses As String = "", Optional vSourceType As String = "") As RelabelorderitemCollection
        If vRelabelordernumber <= 0 Then
            Return Nothing
        End If

        Dim oRelabelOrderItemCollection As New RelabelorderitemCollection
        oRelabelOrderItemCollection.Query.Where(oRelabelOrderItemCollection.Query.Relabelordernumber.Equal(vRelabelordernumber))
        If vNotInRelabelOrderItemStatuses <> "" Then
            oRelabelOrderItemCollection.Query.Where(oRelabelOrderItemCollection.Query.Relabelorderitemstatus.NotIn(vNotInRelabelOrderItemStatuses))
        End If
        If vSourceType <> "" Then
            oRelabelOrderItemCollection.Query.Where(oRelabelOrderItemCollection.Query.Sourcetype.Equal(vSourceType))
        End If
        oRelabelOrderItemCollection.Query.Load()
        Return oRelabelOrderItemCollection
    End Function

    Public Function getViewRelabelOrderItems(vRelabelordernumber As Integer) As ViewRelabelOrderItemCollection
        If vRelabelordernumber <= 0 Then
            Return Nothing
        End If

        Dim oRelabelOrderItemCollection As New ViewRelabelOrderItemCollection
        oRelabelOrderItemCollection.Query.Where(oRelabelOrderItemCollection.Query.Relabelordernumber.Equal(vRelabelordernumber))
        oRelabelOrderItemCollection.Query.Load()
        Return oRelabelOrderItemCollection
    End Function

    Public Function getRelabeledItems(vRelabelOrderNumber As Integer) As esViewInvItemsFromRelabeledItemsCollection
        If vRelabelOrderNumber <= 0 Then
            Return Nothing
        End If
        Dim oItems As New ViewInvItemsFromRelabeledItemsCollection
        oItems.Query.Where(oItems.Query.Allocateddocument.Equal(vRelabelOrderNumber))
        oItems.Query.Load()
        Return oItems
    End Function

    Public Function getUnallocatedRelabelOrderItems(vRelabelordernumber As Integer) As RelabelorderitemCollection
        If vRelabelordernumber <= 0 Then
            Return Nothing
        End If

        Dim oRelabelOrderItemCollection As New RelabelorderitemCollection
        oRelabelOrderItemCollection.Query.Where(oRelabelOrderItemCollection.Query.Relabelordernumber.Equal(vRelabelordernumber), _
                                                oRelabelOrderItemCollection.Query.Sourcetype.IsNull)
        oRelabelOrderItemCollection.Query.Load()
        Return oRelabelOrderItemCollection
    End Function

    Public Function getRelabelOrderProducts() As ViewRelabelOrderProductCollection
        Dim oRelabelOrderProducts As New ViewRelabelOrderProductCollection
        oRelabelOrderProducts.Query.Load()
        Return oRelabelOrderProducts
    End Function

    Public Function getRptRelabelOrders(vRelabelordernumber As Integer) As ViewRptRelabelOrderCollection
        Dim oRelabelOrders As New ViewRptRelabelOrderCollection
        oRelabelOrders.Query.Where(oRelabelOrders.Query.Relabelordernumber.Equal(vRelabelordernumber))
        oRelabelOrders.Query.Load()
        Return oRelabelOrders
    End Function

    Public Function getRelabelOrders(vWorkOrderNumber As Integer, Optional vProductid As Integer = 0, Optional fetchCanceledRelabelOrders As Boolean = False)
        Dim oRelabelOrderCollection As New ViewRelabelOrderCollection

        oRelabelOrderCollection.Query.Where(oRelabelOrderCollection.Query.Workordernumber.Equal(vWorkOrderNumber))
        If vProductid > 0 Then
            oRelabelOrderCollection.Query.Where(oRelabelOrderCollection.Query.Itemid.Equal(vProductid))
        End If

        If fetchCanceledRelabelOrders = True Then
            oRelabelOrderCollection.Query.Where(oRelabelOrderCollection.Query.Relabelorderstatus.Equal(RelabelOrderStatus.CANCELLED.ToString()))
        Else
            oRelabelOrderCollection.Query.Where(oRelabelOrderCollection.Query.Relabelorderstatus.NotEqual(RelabelOrderStatus.CANCELLED.ToString()))
        End If
        oRelabelOrderCollection.Query.Load()
        oRelabelOrderCollection.Sort = "NeededBy Asc"

        If oRelabelOrderCollection.Count > 0 Then
            Return oRelabelOrderCollection
        Else
            Return Nothing
        End If
    End Function

    Public Function getRelabelOrdersForWO(vWorkOrderNumber As Integer, vRelabelOrderStatus As RelabelOrderStatus) As RelabelorderCollection
        If vWorkOrderNumber <= 0 Then
            Return Nothing
        End If
        Dim oRelabelOrderCollection As New RelabelorderCollection
        oRelabelOrderCollection.Query.Where(oRelabelOrderCollection.Query.Workordernumber.Equal(vWorkOrderNumber), _
                            oRelabelOrderCollection.Query.Relabelorderstatus.Equal(vRelabelOrderStatus.ToString()))
        oRelabelOrderCollection.Query.Load()
        Return oRelabelOrderCollection
    End Function

    Public Sub printRelabelOrder(vRelabelordernumber As Integer)
        Dim oRelabelOrder As New Relabelorder
        If oRelabelOrder.LoadByPrimaryKey(vRelabelordernumber) = False Then
            Exit Sub
        End If

        Dim rpt As New rptRelabelOrder(vRelabelordernumber)
        rpt.ShowPreviewDialog()
    End Sub

    Public Function getRelabelFulfillmentPlanReportView(vWorkordernumber As Integer) As ViewRptRelabelFulfillmentPlanCollection
        If vWorkordernumber <= 0 Then
            Return Nothing
        End If

        Dim oRptRLBL As New ViewRptRelabelFulfillmentPlanCollection
        oRptRLBL.Query.Where(oRptRLBL.Query.Workordernumber.Equal(vWorkordernumber))
        oRptRLBL.Query.Load()
        oRptRLBL.Sort = "RLBLORDDETAILS ASC"
        Return oRptRLBL
    End Function

    Public Function getRelabelOrderItemsBySource(vSourceDocument As Integer, vSourcetype As String) As RelabelorderitemCollection
        If vSourceDocument <= 0 Then
            Return Nothing
        End If

        If vSourcetype Is Nothing Then
            Return Nothing
        End If

        Dim oRelabelOrderItems As New RelabelorderitemCollection
        oRelabelOrderItems.Query.Where(oRelabelOrderItems.Query.Sourcedoc.Equal(vSourceDocument), _
                                    oRelabelOrderItems.Query.Sourcetype.Equal(vSourcetype))
        oRelabelOrderItems.Query.Load()
        Return oRelabelOrderItems
    End Function

    Public Function allRelabelOrderItemsOpen(vRelabelordernumber As Integer) As Boolean
        Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItems(vRelabelordernumber)

        If (oRelabelOrderItems Is Nothing) Then
            Return True
        End If

        For Each oItem As Relabelorderitem In oRelabelOrderItems
            ' If system finds even one record, should return false
            If String.IsNullOrEmpty(oItem.Relabelorderitemstatus) = False AndAlso _
               IsDBNull(oItem.Relabelorderitemstatus) = False AndAlso _
               (oItem.Relabelorderitemstatus = RelabelOrderItemStatus.COMPLETED.ToString() OrElse _
                oItem.Relabelorderitemstatus = RelabelOrderItemStatus.CANCELLED.ToString()) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Sub updateRelabelOrder(vRelabelordernumber As Integer, vStatus As RelabelOrderStatus)
        Dim oRelabelOrder As New Relabelorder
        If oRelabelOrder.LoadByPrimaryKey(vRelabelordernumber) = False Then
            Exit Sub
        End If
        oRelabelOrder.Relabelorderstatus = vStatus.ToString()
        oRelabelOrder.Save()
    End Sub

    Public Sub updateRelabelOrderQtyAndStatus(vRelabelordernumber As Integer)
        Dim oRelabelOrder As New Relabelorder
        If oRelabelOrder.LoadByPrimaryKey(vRelabelordernumber) = False Then
            Exit Sub
        End If
        Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItems(vRelabelordernumber)
        If oRelabelOrderItems Is Nothing OrElse _
            oRelabelOrderItems.Count <= 0 Then
            oRelabelOrder.Relabelorderstatus = RelabelOrderStatus.CANCELLED.ToString()
        Else
            oRelabelOrder.Qty = oRelabelOrderItems.Count
        End If
        oRelabelOrder.Save()
    End Sub

    Public Sub updateRelabelOrderItems(vRelabelordernumber As Integer, vStatus As RelabelOrderItemStatus)
        Dim oRelabelOrder As New Relabelorder
        If oRelabelOrder.LoadByPrimaryKey(vRelabelordernumber) = False Then
            Exit Sub
        End If
        Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItems(vRelabelordernumber)
        For Each oRelabelOrderItem As Relabelorderitem In oRelabelOrderItems
            updateRelabelOrderAndItemStatus(oRelabelOrderItem.Relabelorderitemnumber, vStatus.ToString())
        Next
    End Sub

    Public Sub updateRelabelOrderAndItemStatus(vRelabelOrderItemNumber As Integer, vStatus As String)
        Dim oRelabelOrderItem As New Relabelorderitem
        If oRelabelOrderItem.LoadByPrimaryKey(vRelabelOrderItemNumber) = False Then
            Exit Sub
        End If
        oRelabelOrderItem.Relabelorderitemstatus = vStatus
        oRelabelOrderItem.Save()

        checkAndUpdateRelabelOrderStatus(oRelabelOrderItem.Relabelordernumber)
    End Sub

    Public Sub rollbackRelabelOrderItemsBySource(vSourceDocument As Integer, vSourceType As String, Optional IsDeleteItems As Boolean = False, Optional IsUnallocatePurchaseItem As Boolean = True)
        Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItemsBySource(vSourceDocument, _
                                                                                            vSourceType)
        If oRelabelOrderItems Is Nothing OrElse _
            oRelabelOrderItems.Count <= 0 Then
            Exit Sub
        End If

        For Each oRelabelOrderItem As Relabelorderitem In oRelabelOrderItems
            rollbackRelabelOrderItem(oRelabelOrderItem.Relabelorderitemnumber, _
                                     IsDeleteItems, _
                                     IsUnallocatePurchaseItem)
        Next
    End Sub

    Public Sub rollbackRelabelOrderItems(vRelabelOrderNumber As Integer, Optional IsDeleteItems As Boolean = False, Optional IsUnallocatePurchaseItem As Boolean = True)
        Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItems(vRelabelOrderNumber)
        If oRelabelOrderItems Is Nothing OrElse _
            oRelabelOrderItems.Count <= 0 Then
            Exit Sub
        End If

        For Each oRelabelOrderItem As Relabelorderitem In oRelabelOrderItems
            rollbackRelabelOrderItem(oRelabelOrderItem.Relabelorderitemnumber, _
                                     IsDeleteItems, _
                                     IsUnallocatePurchaseItem)
        Next
    End Sub

    Public Sub rollbackRelabelOrderItem(vRelabelOrderItemNumber As Integer, Optional IsDeleteItems As Boolean = False, Optional IsUnallocatePurchaseItem As Boolean = True)
        Dim oRelabelOrderItem As New Relabelorderitem
        If oRelabelOrderItem.LoadByPrimaryKey(vRelabelOrderItemNumber) = False Then
            Exit Sub
        End If

        If Not oRelabelOrderItem.Invitemnum Is Nothing AndAlso _
            IsDBNull(oRelabelOrderItem.Invitemnum) = False Then
            unAllocateInventoryItem(oRelabelOrderItem.Invitemnum)
        Else
            If Not oRelabelOrderItem.Sourcedoc Is Nothing AndAlso _
                IsDBNull(oRelabelOrderItem.Sourcedoc) = False AndAlso _
                IsUnallocatePurchaseItem = True Then
                unallocatePurchaseItem(oRelabelOrderItem.Sourcedoc, 1)
            End If
        End If
        unallocateWorkOrderItems(oRelabelOrderItem.Relabelorderitemnumber, SourceType.RLBL.ToString())


        If oRelabelOrderItem.Relabelorderitemstatus <> RelabelOrderItemStatus.COMPLETED.ToString() Then
            updateRelabelOrderAndItemStatus(vRelabelOrderItemNumber, _
                                            RelabelOrderItemStatus.CANCELLED.ToString())
        End If

        If IsDeleteItems = True Then
            oRelabelOrderItem.MarkAsDeleted()
            oRelabelOrderItem.Save()
        End If
    End Sub

    Public Sub updateRelabelOrderStatus(vWorkOrderNumber As Integer?, vCurrentRelabelOrderStatus As RelabelOrderStatus, vNewRelabelOrderStatus As RelabelOrderStatus)
        If vWorkOrderNumber Is Nothing OrElse _
            vWorkOrderNumber <= 0 Then
            Exit Sub
        End If
        Dim oRelabelOrders As RelabelorderCollection = getRelabelOrdersForWO(vWorkOrderNumber, vCurrentRelabelOrderStatus)
        For Each oRelabelOrder As Relabelorder In oRelabelOrders
            oRelabelOrder.Relabelorderstatus = vNewRelabelOrderStatus.ToString()
        Next
        oRelabelOrders.Save()
    End Sub

    Public Sub updateRelabelOrderItemSourceStatus(vWorkOrderNumber As Integer?, vRelabelOrderStatus As RelabelOrderStatus, vCurrentSourceStatus As PurchaseItemsStatus, vNewSourceStatus As PurchaseItemsStatus)
        If vWorkOrderNumber Is Nothing OrElse _
            vWorkOrderNumber <= 0 Then
            Exit Sub
        End If
        Dim oRelabelOrders As RelabelorderCollection = getRelabelOrdersForWO(vWorkOrderNumber, vRelabelOrderStatus)
        For Each oRelabelOrder As Relabelorder In oRelabelOrders
            updatePurchaseItemsStatus(PurchaseItemSourceType.RELABEL, oRelabelOrder.Relabelordernumber, _
                                  vCurrentSourceStatus.ToString(), _
                                  vNewSourceStatus.ToString())
        Next
    End Sub

    Public Function updateRelabelNeededBy(vRelabelOrderItemNumber As Integer, vNeededBy As DateTime?) As Boolean
        If vNeededBy Is Nothing OrElse _
            IsDBNull(vNeededBy) = True Then
            Return False
        End If
        Dim oRelabelOrderItem As New Relabelorderitem
        If oRelabelOrderItem.LoadByPrimaryKey(vRelabelOrderItemNumber) = False Then
            Return False
        End If
        If updateRelabelOrderNeededBy(oRelabelOrderItem.Relabelordernumber, vNeededBy) = False Then
            Return False
        End If
        updateRelabelSourceDocDateNeeded(oRelabelOrderItem.Relabelordernumber, vNeededBy)
        Return True
    End Function

    Public Function updateRelabelOrderNeededBy(vRelabelOrderNumber As Integer, vNeededBy As DateTime?) As Boolean
        If vNeededBy Is Nothing OrElse _
            IsDBNull(vNeededBy) = True Then
            Return False
        End If

        Dim oRelabelorder As New Relabelorder
        If oRelabelorder.LoadByPrimaryKey(vRelabelOrderNumber) = False Then
            Return False
        End If

        oRelabelorder.Neededby = vNeededBy
        oRelabelorder.Save()
        Return True
    End Function

    Public Sub updateRelabelSourceDocDateNeeded(vRelabelOrderNumber As Integer, vNeededBy As DateTime?)
        If vRelabelOrderNumber <= 0 Then
            Exit Sub
        End If
        If (vNeededBy Is Nothing OrElse _
            IsDBNull(vNeededBy) = True) Then
            Exit Sub
        End If

        Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItems(vRelabelOrderNumber, , SourceType.PRCH.ToString())
        For Each oRelabelOrderItem As Relabelorderitem In oRelabelOrderItems
            updatePurchaseItemDateNeeded(oRelabelOrderItem.Sourcedoc, vNeededBy)
        Next
    End Sub

    Public Function getRelabelOrderItem(vInvItemNumber As Integer, vStatuses As String) As Relabelorderitem
        Dim oRelabelOrderItem As New Relabelorderitem
        oRelabelOrderItem.Query.Where(oRelabelOrderItem.Query.Invitemnum.Equal(vInvItemNumber), _
                oRelabelOrderItem.Query.Relabelorderitemstatus.In(vStatuses))
        If oRelabelOrderItem.Query.Load() = False Then
            Return Nothing
        End If
        Return oRelabelOrderItem
    End Function

    Public Sub updateRelabelOrderAndItemStatus(vInvItemNumber As Integer?, vCurrentStatuses As String, vNewStatus As String)
        If vInvItemNumber Is Nothing OrElse _
             vInvItemNumber <= 0 Then
            Exit Sub
        End If
        Dim oRelabelOrderItem As Relabelorderitem = getRelabelOrderItem(vInvItemNumber, _
                                                                        vCurrentStatuses)
        If oRelabelOrderItem Is Nothing Then
            Exit Sub
        End If

        updateRelabelOrderAndItemStatus(oRelabelOrderItem.Relabelorderitemnumber, _
                               vNewStatus)
    End Sub

    Public Sub checkAndUpdateRelabelOrderStatus(vRelabelordernumber As Integer)
        Dim oRelabelOrder As New Relabelorder
        If oRelabelOrder.LoadByPrimaryKey(vRelabelordernumber) = False Then
            Exit Sub
        End If

        'If all the relabel items are CANCELLED, then order status is CANCELED
        If checkAndUpdateRelabelOrderStatus(vRelabelordernumber, RelabelOrderStatus.CANCELLED) Then
            Exit Sub
        End If

        'If all the relabel items are COMPLETED or some are CANCELLED and some are COMPLETED, the order status is COMPLETED
        If checkAndUpdateRelabelOrderStatus(vRelabelordernumber, RelabelOrderStatus.COMPLETED) Then
            Exit Sub
        End If

        'If relabel order items are not in COMPLETED and CANCELLED, and work order number populated and work order is APPROVED then status is INPROD
        Dim oWorkOrder As New Workorder
        If oWorkOrder.LoadByPrimaryKey(oRelabelOrder.Workordernumber) AndAlso _
            oWorkOrder.Orderstatus <> "PENDING" Then
            updateRelabelOrder(vRelabelordernumber, RelabelOrderStatus.INPROD)
            Exit Sub
        End If

        updateRelabelOrder(vRelabelordernumber, RelabelOrderStatus.PENDING)
    End Sub

    Public Function checkAndUpdateRelabelOrderStatus(vRelabelordernumber As Integer, vStatus As RelabelOrderItemStatus) As Boolean
        Dim vNotInStatus As String = ""
        Select Case vStatus
            Case RelabelOrderStatus.CANCELLED
                vNotInStatus = RelabelOrderItemStatus.CANCELLED.ToString()
            Case RelabelOrderStatus.COMPLETED
                vNotInStatus = String.Format("{0}','{1}", _
                                             RelabelOrderItemStatus.CANCELLED.ToString(), _
                                             RelabelOrderItemStatus.COMPLETED.ToString())
        End Select
        Dim oRelavelOrderItems As RelabelorderitemCollection = getRelabelOrderItems(vRelabelordernumber, _
                                                                                    vNotInStatus)
        If oRelavelOrderItems Is Nothing OrElse _
          oRelavelOrderItems.Count > 0 Then
            Return False
        End If
        updateRelabelOrder(vRelabelordernumber, vStatus)
        Return True
    End Function

    Public Function createRelabelOrder(vPurchaseItemId As Integer) As Boolean
        Dim oPurchaseItem As New Purchaseitem
        If oPurchaseItem.LoadByPrimaryKey(vPurchaseItemId) = False Then
            Return False
        End If

        Dim oWOItems As WorkorderitemCollection
        oWOItems = getWorkOrderItemsByPurchaseItemID(vPurchaseItemId)
        If oWOItems.Count <= 0 Then
            Return False
        End If

        processRelabelOrder(oWOItems(0).Workordernumber, _
                            oPurchaseItem.Itemid, _
                            oWOItems)
        updatePurchaseItem(vPurchaseItemId, _
                           , _
                           PurchaseItemsStatus.FULFILLED.ToString())

        Return True
    End Function

End Module
