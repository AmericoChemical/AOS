Imports AOS.BusinessObjects
Module ProductionOrderProcessing

    Public Enum ProdOrderStatus
        PENDING
        INPROD
        COMPLETE
        CANCELLED
        PLANNED
    End Enum

    ''' <summary>
    ''' Creates Production Order and assign those to Work Order Items
    ''' </summary>
    ''' <param name="vWorkOrder"></param>
    ''' <param name="vWOItems">If NULL this function will get the unallocated WOItems from the DB</param>
    ''' <param name="vProductID"></param>
    ''' <remarks></remarks>
    Public Function createAndAssignProductionOrders(vWorkOrder As Workorder, vWOItems As WorkorderitemCollection, vProductID As Integer) As Prodorder

        If (vWorkOrder Is Nothing) Then
            Return Nothing
        End If

        ' If NULL then it will create production order for all unallocated WOItems
        If (vWOItems Is Nothing) Then
            vWOItems = getUnallocatedWorkOrderItems(vWorkOrder.Workordernumber, vProductID)
        End If

        If (vWOItems.Count <= 0) Then
            Return Nothing
        End If

        Dim oProdOrder = createProductionOrder(vWorkOrder, vWOItems, vProductID)
        If Not oProdOrder Is Nothing Then
            ' Creating ProdItems
            createProductionOrderItems(oProdOrder)

            ' Assigning ProdOrder to WorkOrder
            assignProductionOrderToWorkOrderItems(oProdOrder, vWOItems)

            'Create INVITEM if the work order is approved, when Purchase Item is fulfilled by Production Order.
            If vWorkOrder.Orderstatus = "APPROVED" Then
                createINVITEMsProcessWOItems(oProdOrder, InventoryClass.FULLAVAILABLE)
            End If

            Return oProdOrder
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' It checks following if Production Order Open (INVTX records created for this Production Order)
    ''' </summary>
    ''' <param name="vProdOrderNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function validateProductionOrderToRollback(vProdOrderNumber As Integer) As Boolean

        If (productionOrderOpen(vProdOrderNumber)) Then
            MsgBox("Changes cannot be made because there is an in-progress production order", MsgBoxStyle.Information)
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Returns true if production order is open otherwise returns false.
    ''' </summary>
    ''' <param name="vProdOrderNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function productionOrderOpen(vProdOrderNumber As Integer) As Boolean

        If (vProdOrderNumber <= 0) Then
            Return False
        End If

        ' If production order items exist then check if InvTx rows exist
        Dim oItems As ProditemCollection = getProdItems(vProdOrderNumber)

        Try
            If (Not oItems Is Nothing) Then
                For Each oItem As Proditem In oItems
                    If (invTxExist(oItem.Proditemnum)) Then
                        Return True
                    End If
                Next
            End If
        Finally
            If (Not oItems Is Nothing) Then
                oItems.Dispose()
            End If
        End Try

        Return False
    End Function

    ''' <summary>
    ''' Returns Production Order given ProdOrderNumber
    ''' </summary>
    ''' <param name="vProdOrderNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getProductionOrder(vProdOrderNumber As Integer) As Prodorder
        Dim oProdorder As New Prodorder
        If (vProdOrderNumber <= 0) Then
            Return Nothing
        End If

        Dim oItems As New ProdorderCollection
        oItems.Query.Where(oItems.Query.Prodordernum.Equal(vProdOrderNumber))
        oItems.Query.Load()

        If (oItems.Count > 0) Then
            oProdorder.LoadByPrimaryKey(oItems(0).Prodordernum)
            Return oProdorder
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Returns a colleciton of Production Order Items from ProdItem table for ProdOrderNumber
    ''' </summary>
    ''' <param name="vProdOrderNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getProdItems(vProdOrderNumber As Integer) As ProditemCollection

        If (vProdOrderNumber <= 0) Then
            Return Nothing
        End If

        Dim oItems As New ProditemCollection

        oItems.Query.Where(oItems.Query.Prodordernum.Equal(vProdOrderNumber))
        oItems.Query.Load()

        Return oItems
    End Function

    ''' <summary>
    ''' Returns a Production Order Item for given ProdOrderNumber and Material ID
    ''' </summary>
    ''' <param name="vProdOrderNumber"></param>
    ''' <param name="vMaterialId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getProdItems(vProdOrderNumber As Integer, vMaterialId As Integer) As Proditem

        If (vProdOrderNumber <= 0 OrElse _
            vMaterialId <= 0) Then
            Return Nothing
        End If

        Dim oItems As New ProditemCollection

        oItems.Query.Where(oItems.Query.Prodordernum.Equal(vProdOrderNumber), _
                           oItems.Query.Materialid.Equal(vMaterialId))

        If (oItems.Query.Load()) Then
            Return oItems(0)
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Returns True if row in INVTX for given production order item where txType is "ProdOrder"
    ''' </summary>
    ''' <param name="vProdItemNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function invTxExist(vProdItemNumber As Integer) As Boolean

        If (vProdItemNumber <= 0) Then
            Return False
        End If

        Dim oInvTxns As New InvtxCollection

        Try
            oInvTxns.Query.Where(oInvTxns.Query.Txtype.Equal("ProdOrder"), oInvTxns.Query.Txdocid.Equal(vProdItemNumber))
            If (oInvTxns.Query.Load()) Then
                Return True
            End If
        Finally
            If (Not oInvTxns Is Nothing) Then
                oInvTxns.Dispose()
            End If
        End Try

        Return False
    End Function

    ''' <summary>
    ''' Update prodOrder status and ProdItem status to complete
    ''' </summary>
    ''' <param name="vProdOrderNumber"></param>
    ''' <remarks></remarks>
    Public Sub rollBackProductionOrder(vProdOrderNumber As Integer)

        rollBackInventory(vProdOrderNumber, "PRODORDER")

        removeUnallocatedInventory(vProdOrderNumber, SourceType.PORD.ToString())

        ' Update prodItem status to Complete
        updateProdItemsToComplete(vProdOrderNumber)

        Dim oProdOrder As Prodorder = getProductionOrder(vProdOrderNumber)
        oProdOrder.Iscomplete = True
        oProdOrder.Modifyby = vCurrentUserLogin
        oProdOrder.Modifytime = DateTime.Now
        oProdOrder.Productqty = 0
        oProdOrder.Completiontime = Nothing
        oProdOrder.Orderstatus = ProdOrderStatus.CANCELLED.ToString()
        oProdOrder.Save()

        'Change ProdItem Qty to Zero (0)
        updateQtyofProdItems(oProdOrder)

        unallocateWorkOrderItems(vProdOrderNumber, SourceType.PORD.ToString())
    End Sub

    ''' <summary>
    ''' Sets the IsComplete flag of all ProdItems to true
    ''' </summary>
    ''' <param name="vProdOrderNumber"></param>
    ''' <remarks></remarks>
    Public Sub updateProdItemsToComplete(vProdOrderNumber As Integer)
        Dim oProdItems As ProditemCollection = getProdItems(vProdOrderNumber)

        For Each oItem As Proditem In oProdItems
            oItem.Iscomplete = True
        Next
        oProdItems.Save()
    End Sub

    ''' <summary>
    ''' It creates Production Order if an active APIS is available. If No Active / Single Use APIS is available, it will return NULL.
    ''' </summary>
    ''' <param name="vWorkOrder"></param>
    ''' <param name="vWOItems">It will be all unallocated work order items if called by Auto plan. 
    ''' It will be WO Items linked to purchase item if called from Add production order from purchase item screen. </param>
    ''' <param name="vProductID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function createProductionOrder(vWorkOrder As Workorder, vWOItems As WorkorderitemCollection, vProductID As Integer) As Prodorder

        If (vWOItems Is Nothing) Then
            Return Nothing
        End If

        Dim vAPISCollection As ApisCollection
        Dim vAPISNum As Integer

        vAPISCollection = getActiveAPIS(vProductID)

        ' Getting APISNumber
        Select Case vAPISCollection.Count
            Case 0
                Return Nothing
            Case 1
                vAPISNum = vAPISCollection(0).Apisnum
            Case Else
                Dim frmSelectAPIS As New frmSelectAPIS
                frmSelectAPIS.vPID = vProductID
                frmSelectAPIS.vWID = vWorkOrder.Workordernumber

                frmSelectAPIS.ShowDialog()

                vAPISNum = frmSelectAPIS.vSelectedAPISNumber
        End Select

        ' If APIS is available create Production Order
        Dim oProdOrder As New Prodorder
        oProdOrder.Createdby = vCurrentUserLogin
        oProdOrder.Createdtime = Today
        oProdOrder.Prodorderdate = Today
        oProdOrder.Apisnum = vAPISNum
        oProdOrder.Productid = vProductID
        oProdOrder.Productqty = vWOItems.Count
        oProdOrder.Custid = vWorkOrder.Custid
        oProdOrder.Iscomplete = False
        If vWorkOrder.Plannedshipdate.HasValue Then
            oProdOrder.Neededby = getDateNeeded(vWorkOrder)
        End If
        oProdOrder.Estimatedcompletiondate = getEstCompDate(oProdOrder.Estimatedcompletiondate, oProdOrder.Neededby)
        oProdOrder.Workordernumber = vWorkOrder.Workordernumber
        oProdOrder.Orderstatus = IIf(vWorkOrder.Orderstatus = "PENDING",
                                     ProdOrderStatus.PENDING.ToString(), ProdOrderStatus.INPROD.ToString())
        oProdOrder.Save()
        oProdOrder.Lotnumber = oProdOrder.Prodordernum.ToString + "CS"
        oProdOrder.Save()

        Return oProdOrder
    End Function

    Public Sub updateProdOrderStatusBasedOnWOStatus(vProdOrderNum As Integer, vWOStatus As String)
        Dim oProdOrder As New Prodorder
        If oProdOrder.LoadByPrimaryKey(vProdOrderNum) Then
            oProdOrder.Orderstatus = IIf(vWOStatus = "PENDING",
                                      ProdOrderStatus.PENDING.ToString(), ProdOrderStatus.INPROD.ToString())
            oProdOrder.Save()
        End If
    End Sub

    ''' <summary>
    ''' Return the APIS collection for the Product where status is not ARCHIVED
    ''' </summary>
    ''' <param name="vProductID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getActiveAPIS(vProductID As Integer) As ApisCollection
        Dim oAPIS As New ApisCollection

        oAPIS.Query.Where(oAPIS.Query.Productid.Equal(vProductID), oAPIS.Query.Or(oAPIS.Query.Apisstatus.NotEqual("ARCHIVED"), oAPIS.Query.Apisstatus.IsNull()))
        oAPIS.Query.Load()
        oAPIS.Sort = "APISSTATUS ASC"

        Return oAPIS
    End Function

    ''' <summary>
    ''' Returns a collection of APIS Items from APISITEM table for APIS Number
    ''' </summary>
    ''' <param name="vAPISNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function getAPISItems(vAPISNumber As Integer) As ApisitemCollection
        Dim oAPISItems As New ApisitemCollection
        oAPISItems.Query.Where(oAPISItems.Query.Apisnum.Equal(vAPISNumber))
        oAPISItems.Query.Load()

        Return oAPISItems
    End Function

    Public Function getAPISItem(vAPISNumber As Integer, vMaterialId As Integer) As Apisitem
        Dim oAPISItem As New Apisitem
        oAPISItem.Query.Where(oAPISItem.Query.Apisnum.Equal(vAPISNumber), _
                               oAPISItem.Query.Materialid.Equal(vMaterialId))

        If (oAPISItem.Query.Load()) Then
            Return oAPISItem
        End If

        Return Nothing
    End Function

    Private Sub createProductionOrderItems(vProdOrder As Prodorder)

        If (vProdOrder Is Nothing) Then
            Exit Sub
        End If

        Dim oAPISItems As ApisitemCollection = getAPISItems(vProdOrder.Apisnum)
        Dim oPItem As Proditem

        If oAPISItems.Count > 0 Then
            For Each oAPISItem As Apisitem In oAPISItems
                oPItem = New Proditem
                oPItem.Apisnum = oAPISItem.Apisnum
                oPItem.Materialid = oAPISItem.Materialid
                oPItem.Prodordernum = vProdOrder.Prodordernum
                oPItem.Qty = oAPISItem.Qtyunits * vProdOrder.Productqty
                oPItem.Uom = oAPISItem.Uom
                oPItem.Iscomplete = False
                oPItem.Save()
            Next
        End If



    End Sub

    Public Sub updateQtyofProdItems(vProdOrder As Prodorder)

        If (vProdOrder Is Nothing) Then
            Exit Sub
        End If

        Dim oPItems As ProditemCollection = getProdItems(vProdOrder.Prodordernum)
        If (oPItems Is Nothing OrElse _
            oPItems.Count <= 0) Then
            Exit Sub
        End If

        Dim oApisItem As Apisitem
        For Each oPItem As Proditem In oPItems
            oApisItem = getAPISItem(oPItem.Apisnum, oPItem.Materialid)

            If (oApisItem Is Nothing) Then
                Continue For
            End If

            oPItem.Qty = oApisItem.Qtyunits * vProdOrder.Productqty
        Next
        oPItems.Save()
    End Sub

    Private Sub assignProductionOrderToWorkOrderItems(vProdOrder As Prodorder, vWorkOrderItems As WorkorderitemCollection)

        If (vProdOrder Is Nothing) Then
            Exit Sub
        End If

        If (vWorkOrderItems Is Nothing) Then
            Exit Sub
        End If

        For Each oItem As Workorderitem In vWorkOrderItems
            updateWorkOrderItem(oItem.Workorderitemnumber, vProdOrder.Prodordernum, SourceType.PORD.ToString())
        Next
        vWorkOrderItems.Save()
    End Sub

    ''' <summary>
    ''' Creates Production Order and run raw material fulfillment process
    ''' </summary>
    ''' <param name="vWorkOrder"></param>
    ''' <param name="vProductID"></param>
    ''' <remarks></remarks>
    Public Sub processProductionOrder(vWorkOrder As Workorder, vProductID As Integer)

        ' Create Production Order for all unallocated WO Items if possible
        Dim prodOrder = createAndAssignProductionOrders(vWorkOrder, Nothing, vProductID)

        ' Checking if Material is available and converting to In Process if not available
        If (Not prodOrder Is Nothing) Then
            rawMaterialFulfillmentProcess(prodOrder)
        End If
    End Sub


    Public Function getWorkOrderProductAPIS(vProductID As Integer, vWorkOrderNumber As Integer) As ViewWorkOrderProductAPIS
        Dim oWOProductAPIS As New ViewWorkOrderProductAPIS

        oWOProductAPIS.Query.Where(oWOProductAPIS.Query.Productid.Equal(vProductID), oWOProductAPIS.Query.Workordernumber.Equal(vWorkOrderNumber))
        oWOProductAPIS.Query.Load()

        Return oWOProductAPIS
    End Function

    Public Function getApisProcedure(vApisNum As Integer) As ApisprocedureCollection
        Dim oProcesses As New ApisprocedureCollection

        oProcesses.Query.Where(oProcesses.Query.Apisnum.Equal(vApisNum))
        If oProcesses.Query.Load Then
            oProcesses.Sort = "SEQUENCE"
            Return oProcesses
        Else
            Return Nothing
        End If
    End Function

    Public Function getApisNote(vApisNum As Integer) As ApisnoteCollection
        Dim oNotes As New ApisnoteCollection

        oNotes.Query.Where(oNotes.Query.Apisnum.Equal(vApisNum))
        If oNotes.Query.Load Then
            oNotes.Sort = "SEQUENCE"
            Return oNotes
        Else
            Return Nothing
        End If
    End Function

    Public Function getApisItemCollection(vApisNum As Integer) As ApisitemCollection
        Dim oInputs As New ApisitemCollection

        oInputs.Query.Where(oInputs.Query.Apisnum.Equal(vApisNum))
        If oInputs.Query.Load Then
            Return oInputs
        Else
            Return Nothing
        End If
    End Function

    Public Function getActiveAPISByProductID(vProductID As Integer, vActiveAPISNum As Integer) As ApisCollection
        Dim oAPISList As New ApisCollection
        oAPISList.Query.Where(oAPISList.Query.Productid.Equal(vProductID), oAPISList.Query.Apisnum.NotEqual(vActiveAPISNum))
        oAPISList.Query.Load()
        Return oAPISList
    End Function

    Public Function getAPISByProductID(vProductID As Integer) As ApisCollection
        Dim oAPISList As New ApisCollection
        oAPISList.Query.Where(oAPISList.Query.Productid.Equal(vProductID))
        oAPISList.Query.Load()
        Return oAPISList
    End Function

    Public Function getViewProductionOrderData(vWorkOrderID As Integer, vProductID As Integer, Optional fetchCanceledProdOrders As Boolean = False) As ViewProdOrderDataCollection
        Dim oProdOrders As New ViewProdOrderDataCollection
        oProdOrders.Query.Where(oProdOrders.Query.Workordernumber.Equal(vWorkOrderID), oProdOrders.Query.Productid.Equal(vProductID))
        If fetchCanceledProdOrders = True Then
            oProdOrders.Query.Where(oProdOrders.Query.Orderstatus.Equal(ProdOrderStatus.CANCELLED.ToString()))
        Else
            oProdOrders.Query.Where(oProdOrders.Query.Orderstatus.NotEqual(ProdOrderStatus.CANCELLED.ToString()))
        End If
        oProdOrders.Query.Load()
        Return oProdOrders
    End Function

    Public Function getPordOrdFulfillmentPlanReportView(vWorkordernumber As Integer) As ViewRptPOFulfillmentPlanCollection
        Dim oRptPO As New ViewRptPOFulfillmentPlanCollection
        oRptPO.Query.Where(oRptPO.Query.Workordernumber.Equal(vWorkordernumber))
        oRptPO.Query.Load()
        oRptPO.Sort = "PRODORDERNUM ASC"
        Return oRptPO
    End Function

    Public Function updateProductionOrderNeededBy(vProdOrderNumber As Integer, vNeededBy As DateTime?) As Boolean
        If vNeededBy Is Nothing OrElse _
            IsDBNull(vNeededBy) = True Then
            Return False
        End If

        Dim oProdorder As New Prodorder
        If oProdorder.LoadByPrimaryKey(vProdOrderNumber) Then
            oProdorder.Neededby = vNeededBy
            oProdorder.Estimatedcompletiondate = getEstCompDate(oProdorder.Estimatedcompletiondate, oProdorder.Neededby)
            oProdorder.Save()
            Return True
        End If
        Return False
    End Function

    Public Function getEstCompDate(vEstCompDate As DateTime?, vNeededBy As DateTime?) As DateTime?
        If IsDBNull(vEstCompDate) OrElse _
            vEstCompDate Is Nothing Then
            Return vNeededBy
        End If

        Dim oMysettings As New My.MySettings
        Dim oSysparameters As Sysparameters = oMysettings.getSystemParameters()

        If Not oSysparameters Is Nothing AndAlso _
            oSysparameters.Setprodordestcompdate = True Then
            Return vNeededBy
        End If

        Return vEstCompDate
    End Function

    Public Function getViewProdOrderData(oOrderStatus As ProdOrderStatus) As ViewProdOrderDataCollection
        Dim oProdOrders As New ViewProdOrderDataCollection
        Select Case oOrderStatus
            Case ProdOrderStatus.PENDING
                oProdOrders.Query.Where(oProdOrders.Query.Iscomplete.Equal(0))
            Case ProdOrderStatus.COMPLETE
                oProdOrders.Query.Where(oProdOrders.Query.Iscomplete.Equal(1), _
                                        oProdOrders.Query.Or(oProdOrders.Query.Orderstatus.NotEqual(ProdOrderStatus.CANCELLED.ToString()), _
                                        oProdOrders.Query.Orderstatus.IsNull(), _
                                        oProdOrders.Query.Orderstatus.Equal("")))
            Case ProdOrderStatus.CANCELLED
                oProdOrders.Query.Where(oProdOrders.Query.Iscomplete.Equal(1), _
                                        oProdOrders.Query.Orderstatus.Equal(ProdOrderStatus.CANCELLED.ToString()))
        End Select
        oProdOrders.Query.Load()
        Return oProdOrders
    End Function

    Public Function getViewProdItemData(vProdOrdNum As String) As ViewProdItemDataCollection
        Dim oProdItems As New ViewProdItemDataCollection
        oProdItems.Query.Where(oProdItems.Query.Prodordernum.Equal(vProdOrdNum))
        oProdItems.Query.Load()
        Return oProdItems
    End Function

    Public Function anyMaterialTransaction(vProdOrderID As Integer) As Boolean
        Dim oProdOrdMaterialTrans As New ViewProductionOrderMaterialTransactionsCollection
        oProdOrdMaterialTrans.Query.Where(oProdOrdMaterialTrans.Query.Prodordernum.Equal(vProdOrderID))
        If oProdOrdMaterialTrans.Query.Load() Then
            If oProdOrdMaterialTrans.Count > 0 Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Sub cancelProdOrder(vProdOrderID As Integer, Optional vAllowWorkOrderProdOrders As Boolean = False)
        If vProdOrderID <= 0 Then
            Exit Sub
        End If

        Dim oProdOrd As New Prodorder
        If oProdOrd.LoadByPrimaryKey(vProdOrderID) Then
            If (Not oProdOrd.Workordernumber Is Nothing OrElse _
                oProdOrd.Workordernumber > 0) AndAlso _
                vAllowWorkOrderProdOrders = False Then

                MsgBox(String.Format("Production Order is linked to Work Order# {0}. You cannot cancel a Production Order " & _
                                    "that is linked to a Work Order from this screen. Cancelling Production Order is controlled " & _
                                    "by the Work Order Fulfillment Plan.", _
                                    oProdOrd.Workordernumber.ToString), _
                        MsgBoxStyle.Critical, _
                        "Error")
                Exit Sub
            End If
        Else
            Exit Sub
        End If

        If allInvItemsUnAllocated(vProdOrderID, SourceType.PORD.ToString()) = False AndAlso _
                vAllowWorkOrderProdOrders = False Then

            MsgBox(String.Format("You cannot cancel a Production Order that has Inventory Items allocated to a Work Order."), _
                   MsgBoxStyle.Critical, _
                   "Error")
            Exit Sub
        End If

        If anyMaterialTransaction(vProdOrderID) = True Then
            MsgBox(String.Format("There are Raw Material Inventory Transactions posted against this Production Order. It cannot be cancelled."), _
                   MsgBoxStyle.Critical, _
                   "Error")
            Exit Sub
        End If

        rollBackProductionOrder(vProdOrderID)
    End Sub

    Public Sub updateProdOrdertoCancel(oProdOrder As Prodorder)
        If (oProdOrder Is Nothing) Then
            Exit Sub
        End If
        oProdOrder.Orderstatus = ProdOrderStatus.CANCELLED.ToString()
        oProdOrder.Iscomplete = True
        oProdOrder.Modifyby = vCurrentUserLogin
        oProdOrder.Modifytime = DateTime.Now
        oProdOrder.Save()
    End Sub

    Public Sub assignProductionOrderToWorkOrderItems(vProdOrderID As Integer, vWorkOrderID As Integer, vProductID As Integer)
        Dim oOrd As New Prodorder
        If Not oOrd.LoadByPrimaryKey(vProdOrderID) Then
            MsgBox("Error in retrieving Production Order to assign to open Work Order Items", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim oItems As New WorkorderitemCollection
        'first, pull all work order items that may already be assigned to the select purchase request and unassign them
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(vWorkOrderID), _
                           oItems.Query.Sourcetype.Equal(SourceType.PORD.ToString()), _
                           oItems.Query.Sourcedocument.Equal(vProdOrderID))
        If oItems.Query.Load Then
            For Each oitem As Workorderitem In oItems
                oitem.Sourcedocument = Nothing
                oitem.Sourcetype = Nothing
            Next
            oItems.Save()
        End If
        'now, assign the purchase request to a number of open work order items.
        oItems = New WorkorderitemCollection
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(vWorkOrderID), _
                           oItems.Query.Productid.Equal(vProductID), _
                           oItems.Query.Sourcetype.IsNull())
        If Not oItems.Query.Load Then
            MsgBox("No Work Order Items found.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim vCnt As Integer = 0
        Dim vMaxCnt As Integer = oOrd.Productqty

        If vMaxCnt > oItems.Count Then
            MsgBox("The Production Order is for a greater quantity of containers than are open on the work order", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        For Each oItem As Workorderitem In oItems
            If vCnt < vMaxCnt Then
                oItem.Sourcetype = SourceType.PORD.ToString()
                oItem.Sourcedocument = vProdOrderID
                vCnt = vCnt + 1
            End If
        Next
        oItems.Save()
    End Sub

    Public Sub printProdOrder(vProdOrderID As Integer)
        If vProdOrderID <= 0 Then
            Exit Sub
        End If

        Dim oProdOrd As New Prodorder
        If oProdOrd.LoadByPrimaryKey(vProdOrderID) = False Then
            Exit Sub
        End If

        Dim rpt As New rptProductionOrder(vProdOrderID)
        Dim rpt2 As New rptAPIS(oProdOrd.Apisnum)
        'Dim rpt3 As New rptProductLabelFromProductionOrder(vProdOrderID)
        Dim rpt3 As New rptGHSProductLabelLarge(0, oProdOrd.Productid, oProdOrd.Lotnumber)
        rpt.ShowPreviewDialog()
        rpt2.ShowPreviewDialog()
        rpt3.showpreviewdialog()
    End Sub

End Module
