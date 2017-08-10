Imports AOS.BusinessObjects
Module PurchaseProcessing

    Public Const cDEFAULTCUSTOMERID As Integer = 160    'Americo Chemical Products, Inc. by default'

    Public Enum PurchaseItemsStatus
        PENDING
        REQUESTED
        ORDERED
        RECEIVED
        FULFILLED
        CANCELLED
        RCVDHOLD
    End Enum

    Public Enum PurchaseStatus
        PENDING
        ORDERED
        COMPLETED
        CANCELLED
    End Enum

    Public Enum PurchaseItemType
        REGULAR
        DIRECT
        NON_CONFORMANCE
        MATERIAL
    End Enum

    Public Enum PurchaseType
        REGULAR
        DIRECT
    End Enum

    Public Enum getPurchaseItemOptions
        OnlyOrderedItems
        OnlyUnorderedItems
        AllItems
    End Enum

    Public Enum PurchaseItemSourceType
        WORKORDER
        RELABEL
    End Enum

    Public Enum ItemType
        PRODUCT
        MISC
    End Enum

    Public Function getPurchaseItemRecords(vStatus As String) As ViewPurchaseItems2Collection
        Dim oPurchaseItemsList As New ViewPurchaseItems2Collection
        If vStatus Is Nothing Then
            Return Nothing
        End If
        If vStatus = "ALL" Then
            oPurchaseItemsList.LoadAll()
        Else
            oPurchaseItemsList.Query.Where(oPurchaseItemsList.Query.Purchaseitemstatus.Equal(vStatus))
            oPurchaseItemsList.Query.Load()
        End If
        'oPurchaseItemsList.Sort = "Dateneeded, ItemID"
        Return oPurchaseItemsList
    End Function

    Public Function getPurchaseItems(vPurchaseItemStatus As String, vSortby As String, vOption As getPurchaseItemOptions) As ViewPurchaseItems2Collection
        Dim oPurchaseItemsList As New ViewPurchaseItems2Collection

        If Not String.IsNullOrEmpty(vPurchaseItemStatus) Then
            oPurchaseItemsList.Query.Where(oPurchaseItemsList.Query.Purchaseitemstatus.In(vPurchaseItemStatus))
        End If

        oPurchaseItemsList.Query.Load()
        oPurchaseItemsList.Sort = vSortby
        Return oPurchaseItemsList
    End Function

    ''' <summary>
    ''' Returns purchaseItem object if purchaseItem and purchaseItemStatus matches.
    ''' </summary>
    ''' <param name="vPurchaseItemId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getPurchaseItem(vPurchaseItemId As Integer) As Purchaseitem

        If (vPurchaseItemId <= 0) Then
            Return Nothing
        End If

        Dim oPurchaseitems As New PurchaseitemCollection
        oPurchaseitems = getPurchaseItemsByPurchaseItemIDs(vPurchaseItemId)

        If (oPurchaseitems.Count > 0) Then
            Return oPurchaseitems(0)
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Returns true if purchaseItem object is found for given purchase item id and status, otherwise returns false.
    ''' </summary>
    ''' <param name="vPurchaseItemId"></param>
    ''' <param name="vPurchaseItemStatus">Optional parameter</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function purchaseItemExists(vPurchaseItemId As Integer, Optional vPurchaseItemStatus As String = "") As Boolean

        If (vPurchaseItemId <= 0) Then
            Return False
        End If

        Dim oPurchaseitems As New PurchaseitemCollection
        oPurchaseitems = getPurchaseItemsByPurchaseItemIDs(vPurchaseItemId, vPurchaseItemStatus)

        If (oPurchaseitems.Count > 0) Then
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vPurchaseItemId"></param>
    ''' <param name="vCurrentPurchaseItemStatus"></param>
    ''' <param name="vNewPurchaseItemStatus"></param>
    ''' <remarks></remarks>
    Public Sub updatePurchaseItemStatus(vPurchaseItemId As Integer, vCurrentPurchaseItemStatus As String, vNewPurchaseItemStatus As String)
        Dim oPurchaseitem As New Purchaseitem

        If oPurchaseitem.LoadByPrimaryKey(vPurchaseItemId) Then
            oPurchaseitem.Purchaseitemstatus = IIf(oPurchaseitem.Purchaseitemstatus = vCurrentPurchaseItemStatus _
                                                   , vNewPurchaseItemStatus _
                                                   , oPurchaseitem.Purchaseitemstatus)
            oPurchaseitem.Save()
        End If

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vPurchaseItemId"></param>
    ''' <param name="vPurchaseItemStatus"></param>
    ''' <remarks></remarks>
    Public Sub updatePurchaseItemStatus(vPurchaseItemId As Integer, vPurchaseItemStatus As String)
        Dim oPurchaseitem As New Purchaseitem
        If oPurchaseitem.LoadByPrimaryKey(vPurchaseItemId) Then
            oPurchaseitem.Purchaseitemstatus = vPurchaseItemStatus
            oPurchaseitem.Save()
        End If
    End Sub

    Public Sub updatePurchaseItemStatusAndExpectedDate(vPurchaseItemid As Integer)
        Dim oPurchaseItem As New Purchaseitem
        If oPurchaseItem.LoadByPrimaryKey(vPurchaseItemid) Then
            oPurchaseItem.Purchaseitemstatus = IIf(oPurchaseItem.Purchaseitemstatus = PurchaseItemsStatus.ORDERED.ToString(), _
                                                   PurchaseItemsStatus.RECEIVED.ToString(), _
                                                   oPurchaseItem.Purchaseitemstatus)
            oPurchaseItem.Expectedindate = System.DateTime.Now
            oPurchaseItem.EndEdit()
            oPurchaseItem.Save()
        End If
    End Sub

    ''' <summary>
    ''' Update the status of all purchase items associated to a particular source document if the status if CurrentPurchaseItemStatus
    ''' </summary>
    ''' <param name="vSourceType"></param>
    ''' <param name="vSourceDocument"></param>
    ''' <param name="vCurrentPurchaseItemStatus"></param>
    ''' <param name="vNewPurchaseItemStatus"></param>
    ''' <remarks></remarks>
    Public Sub updatePurchaseItemsStatus(vSourceType As PurchaseItemSourceType, vSourceDocument As Integer, vCurrentPurchaseItemStatus As String, vNewPurchaseItemStatus As String)
        If vSourceDocument <= 0 Then
            Exit Sub
        End If

        Select Case vSourceType
            Case PurchaseItemSourceType.WORKORDER
                Dim oWorkOrderItems As WorkorderitemCollection = getWorkOrderItemsByWorkOrderNumberAndSourcetype(vSourceDocument, SourceType.PRCH.ToString())

                If (oWorkOrderItems Is Nothing) Then
                    Exit Sub
                End If

                For Each oItem As Workorderitem In oWorkOrderItems
                    updatePurchaseItemStatus(oItem.Sourcedocument, vCurrentPurchaseItemStatus, vNewPurchaseItemStatus)
                Next
            Case PurchaseItemSourceType.RELABEL
                Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItems(vSourceDocument, "", SourceType.PRCH.ToString())

                If (oRelabelOrderItems Is Nothing) Then
                    Exit Sub
                End If

                For Each oItem As Relabelorderitem In oRelabelOrderItems
                    updatePurchaseItemStatus(oItem.Sourcedoc, vCurrentPurchaseItemStatus, vNewPurchaseItemStatus)
                Next
        End Select
    End Sub

    Public Function getPurchaseItem(vSourceType As String, vSourceDocument As Integer, vItemId As Integer, vItemType As String, vPurchaseItemStatuses As String, Optional vCustomerPO As String = "") As Purchaseitem
        Dim oPurchaseItems As New PurchaseitemCollection
        oPurchaseItems.Query.Where(oPurchaseItems.Query.Sourcedocument.Equal(vSourceDocument) _
                                   , oPurchaseItems.Query.Sourcetype.Equal(vSourceType) _
                                   , oPurchaseItems.Query.Itemid.Equal(vItemId) _
                                   , oPurchaseItems.Query.Itemtype.Equal(vItemType) _
                                   , oPurchaseItems.Query.Purchaseitemstatus.In(vPurchaseItemStatuses))
        If String.IsNullOrEmpty(vCustomerPO) = False Then
            oPurchaseItems.Query.Where(oPurchaseItems.Query.Customerpo.Equal(vCustomerPO))
        End If
        If oPurchaseItems.Query.Load() Then
            Return oPurchaseItems(0)
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Creates Purchase Items and Updates WO Items
    ''' </summary>
    ''' <param name="vWorkOrderNumber"></param>
    ''' <param name="vProductID"></param>
    ''' <remarks></remarks>
    Public Sub checkAndCreatePurchaseItemsAndFulfillWO(vWorkOrderNumber As Integer?, vProductID As Integer, Optional vCustomerPO As String = "")
        If vWorkOrderNumber Is Nothing Then
            Exit Sub
        End If
        Dim oWorkOrder As New Workorder
        If oWorkOrder.LoadByPrimaryKey(vWorkOrderNumber) = False Then
            Exit Sub
        End If

        If vProductID <= 0 Then
            Exit Sub
        End If

        Dim oWOItems As WorkorderitemCollection = getUnallocatedWorkOrderItems(vWorkOrderNumber, _
                                                                               vProductID, _
                                                                               vCustomerPO)
        If (oWOItems.Count <= 0) Then
            Exit Sub
        End If

        'Purchase Item will be created with status = PENDING
        'Create a purchase item record for every work order item where source type is null 
        Dim oPurchaseItem As Purchaseitem = Nothing

        'If direct work order need to add the work order item to the existing purchase item.
        If oWorkOrder.Transporttype = TransportType.DIRECT.ToString() Then
            oPurchaseItem = getPurchaseItem(PurchaseItemSourceType.WORKORDER.ToString(), _
                                            vWorkOrderNumber, _
                                            vProductID, _
                                            ItemType.PRODUCT.ToString(), _
                                            String.Format("{0}','{1}", _
                                                          PurchaseItemsStatus.PENDING.ToString(), _
                                                          PurchaseItemsStatus.REQUESTED.ToString()), _
                                            vCustomerPO)
            If Not oPurchaseItem Is Nothing Then
                Dim vQty As Decimal = getUnallocatedWorkOrderItemsTotalQty(vWorkOrderNumber, _
                                                                           vProductID, _
                                                                           vCustomerPO)
                'Add total quantity to Purchase item if purchsae item exists
                updatePurchaseItem(oPurchaseItem.Purchaseitemid, _
                                   IIf((oPurchaseItem.Qty Is Nothing OrElse _
                                        String.IsNullOrEmpty(oPurchaseItem.Qty)), _
                                    vQty, _
                                    oPurchaseItem.Qty + vQty), _
                                   oPurchaseItem.Purchaseitemstatus)
            End If
        End If

        If oPurchaseItem Is Nothing Then
            oPurchaseItem = createPurchaseItem(PurchaseItemSourceType.WORKORDER.ToString(), _
                                              vWorkOrderNumber, _
                                              vProductID, _
                                              vCustomerPO)
        End If

        If Not oPurchaseItem Is Nothing Then
            assignPurchaseItemToWorkOrderItems(oPurchaseItem, _
                                               oWOItems, _
                                               SourceType.PRCH.ToString())
        End If
    End Sub

    Public Function createPurchaseItem(vCustid As Integer?, vItemID As Integer) As Purchaseitem

        Dim oProductCost As Productcost = getProductCost(vCustid, vItemID)
        Dim oProduct As New Product
        oProduct.LoadByPrimaryKey(vItemID)

        If (oProduct Is Nothing) Then
            Return Nothing
        End If

        Dim oPurchaseItem As New Purchaseitem

        oPurchaseItem.Createdby = vCurrentUserLogin
        oPurchaseItem.Createdtime = Today
        oPurchaseItem.Inventoryclass = InventoryClass.FULLAVAILABLE
        oPurchaseItem.Container = oProduct.Container
        oPurchaseItem.Itemtype = ItemType.PRODUCT.ToString()
        oPurchaseItem.Itemid = vItemID
        oPurchaseItem.Customerid = vCustid
        oPurchaseItem.Itemdescription = oProduct.Productdesc
        oPurchaseItem.Qty = 1
        oPurchaseItem.Purchaseitemstatus = PurchaseItemsStatus.PENDING.ToString()
        oPurchaseItem.Purchaseitemtype = PurchaseItemType.REGULAR.ToString()
        oPurchaseItem.Unitorcontainer = "C"

        If (oProductCost Is Nothing) Then
            oPurchaseItem.Unitcost = 0.0
            oPurchaseItem.Uom = ""
            oPurchaseItem.Unitsincontainer = 0.0
        Else
            oPurchaseItem.Vendoritemnumber = oProductCost.Vendoritemkey

            Select Case oProductCost.Costmethod
                Case PricingMethod.VOLUME.ToString()
                    oPurchaseItem.Unitcost = oProductCost.Volumestandardcost
                    oPurchaseItem.Unitsincontainer = oProductCost.Volumeunits
                    oPurchaseItem.Uom = oProductCost.Uom

                    ' Select Vendor along with Unit Cost, UOM and UnitsInContainer or let user select it manually
                    oPurchaseItem.Vendorid = oProductCost.Vendorid
                Case PricingMethod.WEIGHT.ToString()
                    oPurchaseItem.Unitcost = oProductCost.Weightstandardcost
                    oPurchaseItem.Unitsincontainer = oProductCost.Weightunits
                    oPurchaseItem.Uom = oProductCost.Uom

                    ' Select Vendor along with Unit Cost, UOM and UnitsInContainer or let user select it manually
                    oPurchaseItem.Vendorid = oProductCost.Vendorid
                Case Else
                    oPurchaseItem.Unitcost = 0.0
                    oPurchaseItem.Uom = ""
                    oPurchaseItem.Unitsincontainer = 0.0
            End Select
        End If

        oPurchaseItem.Save()

        Return oPurchaseItem
    End Function

    Public Function createPurchaseItem(vSourceType As String, vSourceDoc As Integer, vItemId As Integer, Optional vCustomerPO As String = "") As Purchaseitem

        If vItemId <= 0 Then
            Return Nothing
        End If

        Dim oWorkOrder As Workorder = Nothing
        Dim vDateNeeded As Date?
        Dim vCustid As Integer?
        Dim oRelabelOrder As Relabelorder = Nothing

        'Validate before creating purchase items
        'get customer id to arrive product cost for the product
        Select Case vSourceType
            Case PurchaseItemSourceType.WORKORDER.ToString()
                oWorkOrder = getWorkOrder(vSourceDoc)
                If oWorkOrder Is Nothing Then
                    Return Nothing
                End If
                ' If date needed is not determined then don't create purchase item
                vDateNeeded = getDateNeeded(oWorkOrder)
                If Not IsDate(vDateNeeded) Then
                    Return Nothing
                End If
                vCustid = oWorkOrder.Custid
            Case PurchaseItemSourceType.RELABEL.ToString()
                oRelabelOrder = New Relabelorder()
                If oRelabelOrder.LoadByPrimaryKey(vSourceDoc) = False Then
                    Return Nothing
                End If
                vDateNeeded = oRelabelOrder.Neededby
                vCustid = oRelabelOrder.Custid
        End Select

        Dim oPurchaseItem As Purchaseitem = createPurchaseItem(vCustid, vItemId)
        If oPurchaseItem Is Nothing Then
            Return Nothing
        End If

        Select Case vSourceType
            Case PurchaseItemSourceType.WORKORDER.ToString()
                ' If Transport Type is Direct, get the sum of Quantity otherwise get count of WO Items
                oPurchaseItem.Qty = IIf(oWorkOrder.Transporttype = TransportType.DIRECT.ToString(), _
                                    getUnallocatedWorkOrderItemsTotalQty(oWorkOrder.Workordernumber, vItemId, vCustomerPO), _
                                    Convert.ToDecimal(getUnallocatedWorkOrderItems(oWorkOrder.Workordernumber, vItemId).Count))
                oPurchaseItem.Purchaseitemstatus = IIf((oWorkOrder.Orderstatus = "PENDING"), _
                                    PurchaseItemsStatus.PENDING.ToString(), _
                                    PurchaseItemsStatus.REQUESTED.ToString())

                oPurchaseItem.Purchaseitemtype = IIf(oWorkOrder.Transporttype = TransportType.DIRECT.ToString(), _
                                    PurchaseItemType.DIRECT.ToString(), _
                                    PurchaseItemType.REGULAR.ToString())
                oPurchaseItem.Unitorcontainer = getFirstWorkOrderItem(oWorkOrder.Workordernumber, vItemId).Unitorcontainer
            Case PurchaseItemSourceType.RELABEL.ToString()
                oPurchaseItem.Qty = getUnallocatedRelabelOrderItems(vSourceDoc).Count
                oPurchaseItem.Purchaseitemstatus = IIf((oRelabelOrder.Relabelorderstatus = RelabelOrderStatus.PENDING.ToString()), _
                          PurchaseItemsStatus.PENDING.ToString(), _
                          PurchaseItemsStatus.REQUESTED.ToString())
        End Select
        oPurchaseItem.CustomerPO = vCustomerPO
        oPurchaseItem.Customerid = vCustid
        oPurchaseItem.Dateneeded = vDateNeeded
        oPurchaseItem.Sourcedocument = vSourceDoc
        oPurchaseItem.Sourcetype = vSourceType.ToString()
        oPurchaseItem.Save()
        Return oPurchaseItem

    End Function

    ''' <summary>
    ''' Update Purchase Item Quantity and Status
    ''' </summary>
    ''' <param name="vPurchaseItemId"></param>
    ''' <param name="vQty"></param>
    ''' <param name="vStatus"></param>
    ''' <remarks></remarks>
    Public Sub updatePurchaseItem(vPurchaseItemId As Integer, Optional vQty As Decimal = 0, Optional vStatus As String = "REQUESTED")
        Dim oPurchaseItem As New Purchaseitem

        If (oPurchaseItem.LoadByPrimaryKey(vPurchaseItemId)) Then
            oPurchaseItem.Qty = vQty
            oPurchaseItem.Purchaseitemstatus = IIf(oPurchaseItem.Qty = 0, PurchaseItemsStatus.FULFILLED.ToString(), vStatus)
            oPurchaseItem.Save()
        End If
    End Sub

    ''' <summary>
    ''' Close the purchase order if all the purchase items are marked as received
    ''' </summary>
    ''' <param name="vPurchaseItemID"></param>
    ''' <remarks></remarks>
    Public Sub closePurchaseOrderByPurchaseItemStatus(vPurchaseItemID As Integer)
        Dim oPurchaseItem As New Purchaseitem
        Dim oReceivedPurchaseItems As New PurchaseitemCollection
        If oPurchaseItem.LoadByPrimaryKey(vPurchaseItemID) Then
            oReceivedPurchaseItems.Query.Where(oReceivedPurchaseItems.Query.Purchasenumber.Equal(oPurchaseItem.Purchasenumber), oReceivedPurchaseItems.Query.Itemtype.Equal("PRODUCT"), oReceivedPurchaseItems.Query.Itemid.GreaterThan(0), oReceivedPurchaseItems.Query.Purchaseitemstatus.NotIn("RECEIVED"))
            oReceivedPurchaseItems.Query.Load()
            'getPurchaseItemsByPurchaseNumber(oPurchaseItem.Purchasenumber, , , PurchaseItemsStatus.RECEIVED.ToString())
            If oReceivedPurchaseItems.Count <= 0 Then
                updatePurchaseOrderStatus(oPurchaseItem.Purchasenumber, PurchaseStatus.COMPLETED.ToString())
            End If
        End If
    End Sub

    Public Sub updatePurchaseOrderStatus(vPurchaseNumber As Integer, vStatus As String)
        Dim oPurchase As New Purchase
        oPurchase.LoadByPrimaryKey(vPurchaseNumber)
        oPurchase.Purchasestatus = vStatus
        oPurchase.EndEdit()
        oPurchase.Save()
    End Sub

    ''' <summary>
    ''' Assign Purchase Item To Work Order Items
    ''' </summary>
    ''' <param name="vPurchaseItem"></param>
    ''' <param name="vWorkOrderItems"></param>
    ''' <remarks></remarks>
    Private Sub assignPurchaseItemToWorkOrderItems(vPurchaseItem As Purchaseitem, _
                                                   vWorkOrderItems As WorkorderitemCollection, _
                                                   vSourceType As String)
        If (vPurchaseItem Is Nothing) Then
            Exit Sub
        End If

        If (vWorkOrderItems Is Nothing) Then
            Exit Sub
        End If

        For Each oItem As Workorderitem In vWorkOrderItems
            updateWorkOrderItem(oItem.Workorderitemnumber, vPurchaseItem.Purchaseitemid, vSourceType)
        Next

        vWorkOrderItems.Save()
    End Sub


    Public Function getPurchaseItemFulfillmentPlanReportView(ByVal vID As Integer) As ViewRptPurchaseItemFulfillmentPlanCollection
        Dim oRptPurchaseItem As New ViewRptPurchaseItemFulfillmentPlanCollection

        oRptPurchaseItem.Query.Where(oRptPurchaseItem.Query.Workordernumber.Equal(vID))
        oRptPurchaseItem.Query.Load()
        Return oRptPurchaseItem
    End Function

    Public Function createPurchaseOrderandAssignPrchItems(vPurchaseItems As String, Optional vPurchaseItemsType As String = "") As Integer
        Dim oCust As New Customer
        Dim oPurchaseItems As New PurchaseitemCollection

        If String.IsNullOrEmpty(vPurchaseItems) = False Then
            oPurchaseItems = getPurchaseItemsByPurchaseItemIDs(vPurchaseItems)
            If oPurchaseItems.Count <= 0 Then
                Return 0
            End If
            If String.IsNullOrEmpty(vPurchaseItemsType) Then
                vPurchaseItemsType = oPurchaseItems(0).Purchaseitemtype
            End If
            If vPurchaseItemsType = PurchaseItemType.DIRECT.ToString() And _
                       oPurchaseItems(0).Customerid Is Nothing = False And _
                       IsDBNull(oPurchaseItems(0).Customerid) = False Then
                oCust.LoadByPrimaryKey(oPurchaseItems(0).Customerid)
            Else
                oCust.LoadByPrimaryKey(cDEFAULTCUSTOMERID)
            End If
        End If

        Dim oPurchase As New Purchase
        oPurchase.AddNew()
        oPurchase.Purchasedate = Today
        oPurchase.Purchasestatus = PurchaseStatus.PENDING.ToString()
        oPurchase.Purchasetype = IIf(vPurchaseItemsType = PurchaseItemType.DIRECT.ToString(), _
                                     PurchaseItemType.DIRECT.ToString(), _
                                     PurchaseItemType.REGULAR.ToString())
        If oPurchaseItems.Count > 0 Then
            oPurchase.Vendorid = oPurchaseItems(0).Vendorid
            oPurchase.Custid = IIf(vPurchaseItemsType = PurchaseItemType.DIRECT.ToString(), oPurchaseItems(0).Customerid, cDEFAULTCUSTOMERID)
            'Americo Chemical Products, Inc. by default'
        End If
        oPurchase.Subtotal = 0
        oPurchase.Salestax = 0
        oPurchase.Freightin = 0
        oPurchase.Total = 0
        oPurchase.Createdby = vCurrentUserLogin
        oPurchase.Createdtime = Now
        If oCust.Custid > 0 Then
            'Insert customer shipping address
            oPurchase.Shipname = oCust.Custname
            oPurchase.Shipaddress1 = oCust.Custshipaddress1
            oPurchase.Shipaddress2 = oCust.Custshipaddress2
            oPurchase.Shipcity = oCust.Custshipcity
            oPurchase.Shipstate = oCust.Custshipstateprov
            oPurchase.Shipzip = oCust.Custshippostalcode
            oPurchase.Shipcontact = oCust.Custshipcontact
            oPurchase.Shipphone = oCust.Custphone
        End If
        oPurchase.Save()
        'As per Ahmar's instruction we  comment out this below lines
        'oPurchase.Custompurchasenumber = oPurchase.Purchasenumber
        'oPurchase.Save()

        For Each oItem As Purchaseitem In oPurchaseItems
            oItem.Purchasenumber = oPurchase.Purchasenumber
        Next
        oPurchaseItems.Save()

        updatePurchaseOrderExpectedIn(oPurchase, oPurchaseItems)

        Return oPurchase.Purchasenumber
    End Function

    Public Sub deletePurchaseOrder(vPurchaseNumber As Integer)
        Dim oPurchase As New Purchase
        If oPurchase.LoadByPrimaryKey(vPurchaseNumber) = False Then
            Exit Sub
        End If
        oPurchase.MarkAsDeleted()
        oPurchase.Save()
    End Sub

    Public Function getPurchaseItemsByPurchaseItemIDs(vPurchaseItems As String, Optional vPurchaseItemStatus As String = "") As PurchaseitemCollection
        Dim oPurchaseItem As New PurchaseitemCollection

        If (String.IsNullOrEmpty(vPurchaseItemStatus)) Then
            oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchaseitemid.In(vPurchaseItems))
        Else
            oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchaseitemid.In(vPurchaseItems) _
                                      , oPurchaseItem.Query.Purchaseitemstatus.Equal(vPurchaseItemStatus))
        End If
        oPurchaseItem.Query.Load()
        Return oPurchaseItem
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vPurchaseNumber"></param>
    ''' <param name="vPurchaseItemStatus"></param>
    ''' <param name="vSortBy"></param>
    ''' <param name="vNotPurchaseStatus"></param>
    ''' collect Purchase Item which Purchase Item Status not equal vNotPurchaseStatus value.
    ''' <param name="vPurchaseStatus"></param>
    ''' collect Purchase Item which Purchase Item Status equal vNotPurchaseStatus value.
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getPurchaseItemsByPurchaseNumber(vPurchaseNumber As Integer _
                                                     , Optional vPurchaseItemStatus As String = "" _
                                                     , Optional vSortBy As String = "" _
                                                     , Optional vNotPurchaseStatus As String = "" _
                                                     , Optional vPurchaseStatus As String = "" _
                                                     ) As PurchaseitemCollection
        Dim oPurchaseItem As New PurchaseitemCollection
        If Not String.IsNullOrEmpty(vPurchaseItemStatus) Then
            oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchasenumber.Equal(vPurchaseNumber), oPurchaseItem.Query.Purchaseitemstatus.Equal(vPurchaseItemStatus))
        Else
            oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchasenumber.Equal(vPurchaseNumber))
            If Not String.IsNullOrEmpty(vNotPurchaseStatus) Then
                oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchaseitemstatus.NotEqual(vNotPurchaseStatus))
            End If
            If Not String.IsNullOrEmpty(vPurchaseStatus) Then
                oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchaseitemstatus.Equal(vPurchaseStatus))
            End If

            If Not String.IsNullOrEmpty(vSortBy) Then
                oPurchaseItem.Sort = vSortBy
            End If
        End If
        oPurchaseItem.Query.Load()
        Return oPurchaseItem
    End Function

    Public Function getNonReceivedPurchasedFulfilledPurchaseItems(vPurchaseNumber As Integer) As PurchaseitemCollection
        Dim oPurchaseItem As New PurchaseitemCollection
        oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchasenumber.Equal(vPurchaseNumber),
                                  oPurchaseItem.Query.Purchaseitemstatus.NotIn(PurchaseItemsStatus.ORDERED.ToString(), _
                                                                               PurchaseItemsStatus.RECEIVED.ToString(), _
                                                                               PurchaseItemsStatus.FULFILLED.ToString()))
        oPurchaseItem.Query.Load()
        Return oPurchaseItem
    End Function

    Public Function getPurchaseItemsByPurchaseNumber(vPurchaseNumber As Integer) As PurchaseitemCollection
        Dim oPurchaseItem As New PurchaseitemCollection
        oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchasenumber.Equal(vPurchaseNumber))
        oPurchaseItem.Query.Load()
        Return oPurchaseItem
    End Function

    Public Function getPurchaseItemListByPurchaseNumber(vPurchaseNumber As Integer) As ViewPurchaseItemsListCollection
        Dim oPurchaseItem As New ViewPurchaseItemsListCollection
        oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchasenumber.Equal(vPurchaseNumber))
        oPurchaseItem.Query.Load()
        oPurchaseItem.Sort = "PURCHASEITEMSTATUS, PURCHASEITEMID ASC"
        Return oPurchaseItem
    End Function

    Public Sub removePurchaseItems(oPurchaseItems As PurchaseitemCollection)
        If oPurchaseItems Is Nothing OrElse oPurchaseItems.Count = 0 Then
            Exit Sub
        End If

        For Each oItem As Purchaseitem In oPurchaseItems
            removePurchaseItem(oItem.Purchaseitemid)
        Next
    End Sub

    Public Sub removePurchaseItem(vPurchaseItemId As Integer)

        Dim oWorkorderitems As WorkorderitemCollection
        Dim oPurchaseItem As New Purchaseitem

        If oPurchaseItem.LoadByPrimaryKey(vPurchaseItemId) = False Then
            Exit Sub
        End If

        'Delete all inventory items where purchase items on this PO are marked as source ( SourceDoc=PURCHASEITEMID AND SourceType= PRCH)
        deleteInventoryItems(oPurchaseItem.Purchaseitemid, _
                             SourceType.PRCH.ToString())

        'Delete all Load items where purchase items on this PO are marked as source ( SourceDoc=PURCHASEITEMID AND SourceType= PRCH)
        deleteLoadItems(oPurchaseItem.Purchaseitemid, _
                        SourceType.PRCH.ToString())

        ' Update work order items where purchase items on selected Purchase Order are marked as source 
        oWorkorderitems = getWorkOrderItemsByPurchaseItemID(oPurchaseItem.Purchaseitemid)

        If Not oWorkorderitems Is Nothing Then
            For Each oWOItem As Workorderitem In oWorkorderitems
                updateWorkOrderItem(oWOItem.Workorderitemnumber, _
                                    oPurchaseItem.Purchaseitemid, _
                                    SourceType.PRCH.ToString(), Nothing)
            Next
        End If

        Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItemsBySource(oPurchaseItem.Purchaseitemid, _
                                                                                            SourceType.PRCH.ToString())
        If Not oRelabelOrderItems Is Nothing Then
            For Each oRelableOrderItem As Relabelorderitem In oRelabelOrderItems
                updateRelabelOrderItem(oRelableOrderItem.Relabelorderitemnumber, _
                                       oRelableOrderItem.Sourcetype, _
                                       oRelableOrderItem.Sourcedoc, _
                                       oRelableOrderItem.Itemid, _
                                       Nothing)
            Next
        End If

        oPurchaseItem.Purchasenumber = Nothing
        oPurchaseItem.Purchaseitemstatus = getPurchaseItemRollbackStatus(oPurchaseItem).ToString()

        oPurchaseItem.Save()

    End Sub

    Public Sub cancelPurchaseItem(vPurchaseItemNumber As Integer)
        Dim oPurchaseItem As New Purchaseitem
        If oPurchaseItem.LoadByPrimaryKey(vPurchaseItemNumber) = False Then
            Exit Sub
        End If
        'Unlink Purchase item from PO and remove INV and load if created
        removePurchaseItem(vPurchaseItemNumber)

        'If all purcahse items are cancelled cancel purchase order
        If Not oPurchaseItem.Purchasenumber Is Nothing Then
            Dim oPurchaseItems As PurchaseitemCollection = getPurchaseItemsByPurchaseNumber(oPurchaseItem.Purchasenumber)
            If oPurchaseItems Is Nothing OrElse _
                oPurchaseItems.Count <= 0 Then
                updatePurchaseOrderStatus(oPurchaseItem.Purchasenumber, _
                                          PurchaseStatus.CANCELLED.ToString())
            End If
        End If

        'Unallocate work order items
        'Cancel Relabel Order items
        Select Case oPurchaseItem.Sourcetype
            Case PurchaseItemSourceType.WORKORDER.ToString()
                unallocateWorkOrderItems(vPurchaseItemNumber, _
                                         SourceType.PRCH.ToString())
            Case PurchaseItemSourceType.RELABEL.ToString()
                rollbackRelabelOrderItemsBySource(oPurchaseItem.Purchaseitemid, _
                                                  SourceType.PRCH.ToString(), _
                                                  , _
                                                  False)
        End Select
        'Update purchase item status to CANCELED
        updatePurchaseItemStatus(oPurchaseItem.Purchaseitemid, _
                                 PurchaseItemsStatus.CANCELLED.ToString())
    End Sub

    ''' <summary>
    ''' Approve purchase order by Purchase number
    ''' </summary>
    ''' <param name="vPurchaseNumber"></param>
    ''' <remarks></remarks>
    Public Sub approvePurchaseOrder(vPurchaseNumber As String)
        Dim oPurchase = New Purchase
        If oPurchase.LoadByPrimaryKey(vPurchaseNumber) Then
            approvePurchaseOrder(oPurchase)
        End If
    End Sub

    ''' <summary>
    ''' calls Create inventory items function.
    ''' calls Copy all purchase Items for this Purchase order to PurchaeItemsHistoryTable function.
    ''' </summary>
    ''' <param name="vPurchaseOrder"></param>
    ''' <remarks></remarks>
    Public Sub approvePurchaseOrder(vPurchaseOrder As Purchase)

        If (vPurchaseOrder Is Nothing) Then
            Exit Sub
        End If

        Dim oPurchaseItems As PurchaseitemCollection = getPurchaseItemsByPurchaseNumber(vPurchaseOrder.Purchasenumber)

        If (oPurchaseItems Is Nothing OrElse _
            oPurchaseItems.Count <= 0) Then
            Exit Sub
        End If
        approvePurchaseOrderItems(vPurchaseOrder, oPurchaseItems)

        updatePurchaseOrderStatus(vPurchaseOrder.Purchasenumber, PurchaseStatus.ORDERED.ToString())
    End Sub

    Public Sub approvePurchaseOrderItems(oPurchase As Purchase, vCommaSeparatedPurchaseItemIds As String)
        If oPurchase Is Nothing Then
            Exit Sub
        End If
        Dim oPurchaseItems As PurchaseitemCollection = getPurchaseItemsByPurchaseItemIDs(vCommaSeparatedPurchaseItemIds)
        If (oPurchaseItems Is Nothing OrElse _
            oPurchaseItems.Count <= 0) Then
            Exit Sub
        End If
        approvePurchaseOrderItems(oPurchase, oPurchaseItems)
    End Sub

    Public Sub approvePurchaseOrderItems(oPurchase As Purchase, oPurchaseItems As PurchaseitemCollection)
        If oPurchase Is Nothing Then
            Exit Sub
        End If
        If (oPurchaseItems Is Nothing OrElse _
          oPurchaseItems.Count <= 0) Then
            Exit Sub
        End If

        If oPurchase.Purchasetype = PurchaseItemType.REGULAR.ToString() Then
            'Add new Inventory Items with ITEMSTATUS = PENDING and source equal to these purchaseitems
            'Update the work order item(s) where purchase items on the selected Purchase Order are marked as source
            createInventoryItemsAndUpdateWOItems(oPurchaseItems)
        Else
            'Create Load details only for DIRECT purchase
            'updatePurchaseOrderShipmentData(oPurchase.Purchasenumber, oPurchaseItems)
        End If

        'Set the status of Purchase Items to "ORDERED"
        For vIndex As Integer = 0 To oPurchaseItems.Count - 1
            updatePurchaseItemStatus(oPurchaseItems.Item(vIndex).Purchaseitemid, PurchaseItemsStatus.ORDERED.ToString())
        Next

        copyPurchaseItemToPurchasehistory(oPurchaseItems)
    End Sub

    ''' <summary>
    ''' Returns True if Purchase Order associated with Purchase Item is ORDERED otherwise false.
    ''' </summary>
    ''' <param name="vPurchaseItemId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function isPurchaseOrdered(vPurchaseItemId As Integer) As Boolean
        Dim oPI As New Purchaseitem
        If (oPI.LoadByPrimaryKey(vPurchaseItemId)) Then
            Dim oPrch As New Purchase
            If (oPrch.LoadByPrimaryKey(oPI.Purchasenumber)) Then
                Return IIf(oPrch.Purchasestatus = PurchaseStatus.ORDERED.ToString(), True, False)
            End If
        End If

        Return False
    End Function

    Public Function getPurchaseStatus(vPurchaseItemId As Integer) As String
        Dim oPI As New Purchaseitem
        If (oPI.LoadByPrimaryKey(vPurchaseItemId)) Then
            Dim oPrch As New Purchase
            If (oPrch.LoadByPrimaryKey(oPI.Purchasenumber)) Then
                Return oPrch.Purchasestatus
            End If
        End If

        Return String.Empty
    End Function

    ''' <summary>
    ''' Copy all purchase Items for this Purchase order to PurchaeItemsHistoryTable
    ''' </summary>
    ''' <param name="oPurchaseItemsCollection"></param>
    ''' <remarks></remarks>
    Private Sub copyPurchaseItemToPurchasehistory(oPurchaseItemsCollection As PurchaseitemCollection)

        Dim oPurchaseitemhistory As New Purchaseitemhistory

        For Each oPurchaseitem As Purchaseitem In oPurchaseItemsCollection

            oPurchaseitemhistory = New Purchaseitemhistory
            oPurchaseitemhistory.AddNew()

            oPurchaseitemhistory.Purchaseitemid = oPurchaseitem.Purchaseitemid
            oPurchaseitemhistory.Purchasestatus = oPurchaseitem.Purchaseitemstatus
            oPurchaseitemhistory.Purchasetype = oPurchaseitem.Purchaseitemtype
            oPurchaseitemhistory.Itemid = oPurchaseitem.Itemid
            oPurchaseitemhistory.Itemtype = oPurchaseitem.Itemtype
            oPurchaseitemhistory.Itemdescription = oPurchaseitem.Itemdescription
            oPurchaseitemhistory.Qty = oPurchaseitem.Qty
            oPurchaseitemhistory.Unitorcontainer = oPurchaseitem.Unitorcontainer
            oPurchaseitemhistory.Container = oPurchaseitem.Container
            oPurchaseitemhistory.Unitsincontainer = oPurchaseitem.Unitsincontainer
            oPurchaseitemhistory.Uom = oPurchaseitem.Uom
            oPurchaseitemhistory.Unitcost = oPurchaseitem.Unitcost
            oPurchaseitemhistory.Dateneeded = oPurchaseitem.Dateneeded
            oPurchaseitemhistory.Vendorid = oPurchaseitem.Vendorid
            oPurchaseitemhistory.Customerid = oPurchaseitem.Customerid
            oPurchaseitemhistory.Purchasenumber = oPurchaseitem.Purchasenumber
            oPurchaseitemhistory.Createdby = vCurrentUserLogin
            oPurchaseitemhistory.Createdtime = Now
            oPurchaseitemhistory.Save()
        Next
    End Sub

    Public Sub updatePurchaseItemExpectedInDate(vPurchaseItemId As Integer, vExpectedindate As Date)
        Dim oPurchaseItem As New Purchaseitem

        If (oPurchaseItem.LoadByPrimaryKey(vPurchaseItemId)) Then
            oPurchaseItem.Expectedindate = vExpectedindate
            oPurchaseItem.Save()
        End If
    End Sub

    Public Function getPurchaseOrderList(vPurchaseType As String, vPurchaseStatus As String) As ViewPurchaseOrderListCollection
        Dim oPurchaseOrderList As New ViewPurchaseOrderListCollection
        oPurchaseOrderList.Query.Where(oPurchaseOrderList.Query.Purchasetype.Equal(vPurchaseType) _
                                       , oPurchaseOrderList.Query.Purchasestatus.In(vPurchaseStatus))
        oPurchaseOrderList.Query.Load()
        oPurchaseOrderList.Sort = "EXPECTEDINDATE ASC"
        Return oPurchaseOrderList
    End Function

    Public Function getPurchaseOrder(vPurchaseNumber As Integer, vPurchaseStatus As String) As Purchase
        Dim oPurchaseOrder As New Purchase
        oPurchaseOrder.Query.Where(oPurchaseOrder.Query.Purchasenumber.Equal(vPurchaseNumber))

        If (String.IsNullOrEmpty(vPurchaseStatus) = False) Then
            oPurchaseOrder.Query.Where(oPurchaseOrder.Query.Purchasestatus.In(vPurchaseStatus))
        End If

        If (oPurchaseOrder.Query.Load()) Then
            Return oPurchaseOrder
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Duplicate purchase item record except qty.
    ''' </summary>
    ''' <param name="oPurchaseItem"></param>
    ''' <param name="vQty"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function duplicatePurchaseItem(oPurchaseItem As Purchaseitem, vQty As Integer, Optional vPurchaseType As String = "", Optional vPurchaseItemStatus As String = "", Optional vNotes As String = "", Optional vCopyWorkOrderNumber As Boolean = True) As Purchaseitem
        Dim oItem As New Purchaseitem
        oItem.AddNew()
        oItem.Purchaseitemtype = IIf(vPurchaseType <> "", vPurchaseType, oPurchaseItem.Purchaseitemtype)
        oItem.Itemid = oPurchaseItem.Itemid
        oItem.Itemtype = oPurchaseItem.Itemtype
        oItem.Itemdescription = oPurchaseItem.Itemdescription
        oItem.Qty = vQty
        oItem.Unitorcontainer = oPurchaseItem.Unitorcontainer
        oItem.Container = oPurchaseItem.Container
        oItem.Unitsincontainer = oPurchaseItem.Unitsincontainer
        oItem.Uom = oPurchaseItem.Uom
        oItem.Dateneeded = oPurchaseItem.Dateneeded
        oItem.Expectedindate = oPurchaseItem.Expectedindate
        oItem.Unitcost = oPurchaseItem.Unitcost
        oItem.Vendorid = oPurchaseItem.Vendorid
        oItem.Customerid = oPurchaseItem.Customerid
        oItem.Purchasenumber = oPurchaseItem.Purchasenumber
        oItem.Customerpo = oPurchaseItem.Customerpo
        oItem.Vendoritemnumber = oPurchaseItem.Vendoritemnumber
        oItem.Inventoryclass = oPurchaseItem.Inventoryclass
        oItem.Createdby = vCurrentUserLogin
        oItem.Createdtime = Now
        oItem.Purchaseitemstatus = IIf(vPurchaseItemStatus <> "", vPurchaseItemStatus, oPurchaseItem.Purchaseitemstatus)
        oItem.Notes = IIf(vNotes <> "", vNotes, Nothing)
        If vCopyWorkOrderNumber Then
            oItem.Sourcedocument = oPurchaseItem.Sourcedocument
            oItem.Sourcetype = oPurchaseItem.Sourcetype
        End If
        oItem.EndEdit()
        oItem.Save()
        Return oItem
    End Function

    Public Function getPurchaseItemListByPurchaseNumber(vPurchaseNumber As Integer, Optional vPurchaseItemStatus As String = "", Optional vNotPurchaseItemid As Integer = 0, Optional vProcess As String = "", Optional vSortby As String = "PURCHASEITEMID DESC") As PurchaseitemCollection
        Dim oPurchaseItem As New PurchaseitemCollection

        If Not String.IsNullOrEmpty(vPurchaseItemStatus) Then
            oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchasenumber.Equal(vPurchaseNumber), oPurchaseItem.Query.Purchaseitemstatus.Equal(vPurchaseItemStatus))
        Else
            oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchasenumber.Equal(vPurchaseNumber))
        End If

        If Not String.IsNullOrEmpty(vNotPurchaseItemid) Then
            oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchaseitemid.NotEqual(vNotPurchaseItemid))
        End If

        If vProcess = "PREV" Then
            oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchaseitemid.LessThan(vNotPurchaseItemid))
        Else
            oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchaseitemid.GreaterThan(vNotPurchaseItemid))
        End If

        oPurchaseItem.Query.Load()
        If vProcess = "PREV" Then
            oPurchaseItem.Sort = vSortby
        End If

        Return oPurchaseItem
    End Function

    Public Function getChemicalCategoryList() As ListChemicalcategoryCollection
        Dim oChemicalCategoryList As New ListChemicalcategoryCollection
        oChemicalCategoryList.Query.Load()
        Return oChemicalCategoryList
    End Function

    Public Function getPriceListProductsList() As ViewPriceListProductsCollection
        Dim oPriceListProductsList As New ViewPriceListProductsCollection
        oPriceListProductsList.Query.Load()
        Return oPriceListProductsList
    End Function

    Public Function getVendorTestingMatrixList(vVendorid As Integer) As ViewVendorTestingMatrixCollection
        Dim oVendorTestingMatrixList As New ViewVendorTestingMatrixCollection
        oVendorTestingMatrixList.Query.Where(oVendorTestingMatrixList.Query.Vendorid.Equal(vVendorid))
        oVendorTestingMatrixList.Query.Load()
        oVendorTestingMatrixList.Sort = "PRODUCTID"
        oVendorTestingMatrixList.Query.Load()
        Return oVendorTestingMatrixList
    End Function

    Public Function getCustomerList(vCustIds As List(Of Integer)) As CustomerCollection
        Dim oCustomers As New CustomerCollection

        If vCustIds.Count > 0 Then
            oCustomers.Query.Where(oCustomers.Query.Custid.In(vCustIds))
        End If

        oCustomers.Query.Load()
        oCustomers.Sort = "CUSTNAME"

        Return oCustomers
    End Function

    Public Function updatePurchaseItemDateNeeded(vPurchaseItemId As Integer, vDateNeeded As DateTime?) As Boolean
        If vDateNeeded Is Nothing OrElse _
            IsDBNull(vDateNeeded) = True Then
            Return False
        End If

        Dim oPurchaseitem As New Purchaseitem
        If oPurchaseitem.LoadByPrimaryKey(vPurchaseItemId) Then
            oPurchaseitem.Dateneeded = vDateNeeded
            oPurchaseitem.Save()
            Return True
        End If
        Return False
    End Function

    Public Function getPurchaseItemRollbackStatus(oPurchaseItem As Purchaseitem) As PurchaseItemsStatus
        Select Case oPurchaseItem.Sourcetype
            Case PurchaseItemSourceType.RELABEL.ToString()
                Dim oRelabelOrder As New Relabelorder
                If (oRelabelOrder.LoadByPrimaryKey(oPurchaseItem.Sourcedocument) = True) Then
                    Dim oWorkOrder As New Workorder
                    If (oWorkOrder.LoadByPrimaryKey(oRelabelOrder.Workordernumber) = False OrElse _
                        oWorkOrder.Orderstatus = "APPROVED") Then
                        Return PurchaseItemsStatus.REQUESTED
                    End If
                End If
            Case PurchaseItemSourceType.WORKORDER.ToString()
                Dim oWorkOrder As New Workorder
                If (oWorkOrder.LoadByPrimaryKey(oPurchaseItem.Sourcedocument) = False OrElse _
                    oWorkOrder.Orderstatus = "APPROVED") Then
                    Return PurchaseItemsStatus.REQUESTED
                End If
            Case Else
                Return PurchaseItemsStatus.REQUESTED
        End Select
        'Catchall result
        Return PurchaseItemsStatus.REQUESTED
    End Function

    Public Sub setPurchaseNumberInPurchaseItems(oPurchase As Purchase, vPurchaseItemIds As String)
        If oPurchase Is Nothing Then
            Exit Sub
        End If
        Dim oPurchaseItems As New PurchaseitemCollection
        oPurchaseItems = getPurchaseItemsByPurchaseItemIDs(vPurchaseItemIds)
        If oPurchaseItems Is Nothing OrElse _
            oPurchaseItems.Count <= 0 Then
            Exit Sub
        End If

        If validatePurchaseOrder(oPurchase.Purchasenumber, oPurchaseItems(0)) = False Then
            Exit Sub
        End If

        For Each oItem As Purchaseitem In oPurchaseItems
            oItem.Purchasenumber = oPurchase.Purchasenumber
        Next
        oPurchaseItems.Save()
    End Sub

    Public Function validatePurchaseOrder(vPurchaseNumber As Integer, oPurchaseItem As Purchaseitem) As Boolean
        If vPurchaseNumber > 0 Then
            Dim oPurchase As New Purchase
            If (oPurchase.LoadByPrimaryKey(vPurchaseNumber) = False) Then
                Return False
            End If
            If (oPurchaseItem.Purchaseitemtype <> PurchaseItemType.DIRECT.ToString() AndAlso _
                oPurchase.Purchasetype = PurchaseType.DIRECT.ToString()) OrElse _
                (oPurchaseItem.Purchaseitemtype = PurchaseItemType.DIRECT.ToString() AndAlso _
                oPurchase.Purchasetype <> PurchaseType.DIRECT.ToString()) Then
                MsgBox("Selected purchase order has different purchase type (DIRECT / REGULAR) than that of selected purchase items, please try again.", _
                       MsgBoxStyle.Critical, "Error")
                Return False
            End If
            If (oPurchaseItem.Vendorid <> oPurchase.Vendorid) Then
                MsgBox("Selected purchase order has different vendor than that of selected purchase items, please try again.", _
                       MsgBoxStyle.Critical, "Error")
                Return False
            End If
        End If
        Return True
    End Function

    Public Sub unallocatePurchaseItem(vPurchaseItemID As Integer, vAllocatedQty As Integer)
        Dim oPurchaseItem As New Purchaseitem
        If (oPurchaseItem.LoadByPrimaryKey(vPurchaseItemID) = False) Then
            Exit Sub
        End If
        Dim oPurchase As New Purchase
        If (Not oPurchaseItem.Purchasenumber Is Nothing AndAlso _
            String.IsNullOrEmpty(oPurchaseItem.Purchasenumber) = False) Then
            If (oPurchase.LoadByPrimaryKey(oPurchaseItem.Purchasenumber)) Then
                If oPurchase.Purchasestatus = PurchaseStatus.ORDERED.ToString() Then
                    Exit Sub
                End If
            End If
        End If
        If (oPurchaseItem.Qty - vAllocatedQty) <= 0 Then
            oPurchaseItem.MarkAsDeleted()
            oPurchaseItem.Save()
            If Not oPurchase Is Nothing AndAlso _
                oPurchase.Purchasenumber > 0 Then
                Dim oPurchaseItems As PurchaseitemCollection = getPurchaseItemsByPurchaseNumber(oPurchase.Purchasenumber)
                If (oPurchaseItems Is Nothing OrElse _
                    oPurchaseItems.Count <= 0) Then
                    oPurchase.MarkAsDeleted()
                    oPurchase.Save()
                End If
            End If
        Else
            oPurchaseItem.Qty = oPurchaseItem.Qty - vAllocatedQty
            oPurchaseItem.Save()
        End If
    End Sub

    ' Public Function getPurchaseOrderTypes() As ListPurchaseordertypeCollection
    'Dim oPurchaseOrderTypes As New ListPurchaseordertypeCollection
    '   oPurchaseOrderTypes.LoadAll()
    '  oPurchaseOrderTypes.Sort = "PURCHASEORDERTYPE"
    ' Return oPurchaseOrderTypes
    'End Function

    Public Function getViewPurchaseOrders(ByVal vStatus As String) As ViewPurchaseOrdersCollection
        Dim oPurchaseOrders As New ViewPurchaseOrdersCollection
        If vStatus <> "" Then
            oPurchaseOrders.Query.Where(oPurchaseOrders.Query.Purchasestatus.Equal(vStatus))
        End If
        oPurchaseOrders.Query.Load()
        Return oPurchaseOrders
    End Function

    Public Function getViewPurchaseOrders(ByVal vStatus As String, vVendorId As Integer, vPurchaseType As String, vSort As String) As ViewPurchaseOrdersCollection
        Dim oPurchaseOrders As New ViewPurchaseOrdersCollection
        oPurchaseOrders.Query.Where(oPurchaseOrders.Query.Purchasestatus.In(vStatus))
        If vVendorId > 0 Then
            oPurchaseOrders.Query.Where(oPurchaseOrders.Query.Vendorid.Equal(vVendorId))
        End If
        oPurchaseOrders.Query.Where(oPurchaseOrders.Query.Purchasetype.Equal(vPurchaseType))
        oPurchaseOrders.Query.Load()
        oPurchaseOrders.Sort = vSort
        Return oPurchaseOrders
    End Function

    Public Sub updatePurchaseOrderExpectedIn(oPurchase As Purchase, oPurchaseItems As PurchaseitemCollection)
        For Each oItem As Purchaseitem In oPurchaseItems
            'Get the maximum of expected in date from Purchase items and assign to purchase order
            If oItem.Expectedindate Is Nothing OrElse _
                IsDBNull(oItem.Expectedindate) = True Then
                Continue For
            End If
            If oPurchase.Expectedindate Is Nothing OrElse _
                    IsDBNull(oPurchase.Expectedindate) = True OrElse _
                    oItem.Expectedindate > oPurchase.Expectedindate Then
                oPurchase.Expectedindate = oItem.Expectedindate
            End If
        Next
        oPurchase.Save()
    End Sub

    Public Sub deletePurchaseItem(vPurchaseItemId As Integer)
        ' check if purchase item is ON ORDER
        Dim oPurchaseItem As New Purchaseitem
        If oPurchaseItem.LoadByPrimaryKey(vPurchaseItemId) = False Then
            Exit Sub
        End If

        Dim oPrchItem As Purchaseitem
        Try
            'remove the Purchase Item from the table if status in Purchase Item table is not ORDERED or RECEIVED or FULFILLED 
            oPrchItem = getNonReceivedPurchaseItem(vPurchaseItemId)
            If Not oPrchItem Is Nothing Then
                'oPrchItem.MarkAsDeleted()
                oPrchItem.Purchaseitemstatus = "CANCELLED"
                oPrchItem.Save()
                MsgBox("Purchase Item successfully cancelled", MsgBoxStyle.Information, "Success")
            End If
        Catch ex As Exception
            MsgBox("Error in cancelling purchase item", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Public Function getNonReceivedPurchaseItem(vPurchaseItemId As Integer) As Purchaseitem
        Dim oPurchaseItem As New Purchaseitem
        oPurchaseItem.Query.Where(oPurchaseItem.Query.Purchaseitemid.Equal(vPurchaseItemId),
                                  oPurchaseItem.Query.Purchaseitemstatus.NotIn(PurchaseItemsStatus.ORDERED.ToString(), _
                                                                               PurchaseItemsStatus.RECEIVED.ToString(), _
                                                                               PurchaseItemsStatus.FULFILLED.ToString()))
        oPurchaseItem.Query.Load()
        Return oPurchaseItem
    End Function

    Public Sub unassignWorkOrderItem(vWorkOrderID As Integer, vPurchaseItemId As Integer)
        If vWorkOrderID <= 0 Then
            Exit Sub
        End If
        If vPurchaseItemId <= 0 Then
            Exit Sub
        End If
        'first, unassign the purchase Item from any work order item record
        Dim oItems As New WorkorderitemCollection
        'first, pull all work order items that may already be assigned to the select purchase Item and unassign them
        oItems = getWorkOrderItemsByPurchaseWorkOrderNumber(vWorkOrderID, SourceType.PRCH.ToString(), vPurchaseItemId)
        If oItems Is Nothing OrElse _
            oItems.Count <= 0 Then
            Exit Sub
        End If

        For Each oitem As Workorderitem In oItems
            updateWorkOrderItem(oitem.Workorderitemnumber, Nothing, Nothing)
        Next

    End Sub

    Public Enum ControlType
        Numeric
        DatePicker
        Text
    End Enum

    Public Function validateControl(vControlName As String, oControl As DevExpress.XtraEditors.BaseEdit, oValidationType As ControlType) As Boolean
        If oControl Is Nothing Then
            Return False
        End If
        If String.IsNullOrEmpty(vControlName) Then
            Return False
        End If
        Select Case oValidationType
            Case ControlType.Text
                If String.IsNullOrEmpty(oControl.EditValue) Then
                    showInvalidControlMessage(vControlName, oControl)
                    Return False
                End If
            Case ControlType.Numeric
                If (IsDBNull(oControl.EditValue) = True OrElse _
                    oControl.EditValue <= 0) Then
                    showInvalidControlMessage(vControlName, oControl)
                    Return False
                End If
            Case ControlType.DatePicker
                If IsDBNull(oControl.EditValue) Then
                    showInvalidControlMessage(vControlName, oControl)
                    Return False
                End If
        End Select
        Return True
    End Function

    Public Sub showInvalidControlMessage(vControlName As String, oControl As DevExpress.XtraEditors.BaseEdit)
        MsgBox(vControlName & " is required", MsgBoxStyle.Critical, "Error")
        oControl.Focus()
    End Sub

    Public Function getPurchaseItems(vSourceType As String, vSourceDocument As Integer, vProductID As Integer) As ViewPurchaseItemRequestCollection
        Dim oPurchaseItems As New ViewPurchaseItemRequestCollection
        oPurchaseItems.Query.Where(oPurchaseItems.Query.Sourcedocument.Equal(vSourceDocument),
                    oPurchaseItems.Query.Sourcetype.Equal(vSourceType),
                    oPurchaseItems.Query.Itemid.Equal(vProductID),
                    oPurchaseItems.Query.Purchaseitemstatus.NotEqual("CANCELLED"))
        oPurchaseItems.Query.Load()
        Return oPurchaseItems
    End Function

    Public Function getCancelledPurchaseItems(vSourceType As String, vSourceDocument As Integer, vProductID As Integer) As ViewPurchaseItemRequestCollection
        Dim oPurchaseItems As New ViewPurchaseItemRequestCollection
        oPurchaseItems.Query.Where(oPurchaseItems.Query.Sourcedocument.Equal(vSourceDocument),
                    oPurchaseItems.Query.Sourcetype.Equal(vSourceType),
                    oPurchaseItems.Query.Itemid.Equal(vProductID),
                    oPurchaseItems.Query.Purchaseitemstatus.Equal("CANCELLED"))
        oPurchaseItems.Query.Load()
        Return oPurchaseItems
    End Function

    Public Function splitPurchaseItem(vPurchaseItemId As Integer, vSplitQty As Integer) As Boolean

        Dim oOrignalPurchaseItem = New Purchaseitem()
        If oOrignalPurchaseItem.LoadByPrimaryKey(vPurchaseItemId) = False Then
            Return False
        End If

        Dim oWorkOrderItems As New WorkorderitemCollection
        Select Case oOrignalPurchaseItem.Sourcetype
            Case PurchaseItemSourceType.WORKORDER.ToString()
                oWorkOrderItems = getWorkOrderItemsByPurchaseItemID(vPurchaseItemId)
                If (oOrignalPurchaseItem.Purchaseitemtype = PurchaseItemType.DIRECT.ToString()) Then
                    If oWorkOrderItems.Count > 0 Then
                        Dim vMsg As String = String.Format("There is {0} Work Order Item(s) associated to this Purchase Item. " & _
                                "Splitting the Purchase Item may also split the Work Order Item, do you want to continue?", _
                                oWorkOrderItems.Count)
                        If (MsgBox(vMsg, MsgBoxStyle.YesNo) = MsgBoxResult.No) Then
                            Return False
                        End If
                    End If
                End If
        End Select

        If oOrignalPurchaseItem.Qty <= vSplitQty OrElse _
            vSplitQty <= 0 Then
            MsgBox(String.Format("Quantity Containers should be less than or equal to {0}", Format((oOrignalPurchaseItem.Qty - 1), "0")), _
                   MsgBoxStyle.Information, "Split Purchase Item - Error")
            Return False
        End If

        Dim oPurchaseItem As Purchaseitem = duplicatePurchaseItem(oOrignalPurchaseItem, 0)

        'Set the quantity on the new purchase item = the quantity that the user input
        oPurchaseItem.Qty = vSplitQty
        oPurchaseItem.Save()

        'Update the original purchase item quantity = original quantity - new quantity
        oOrignalPurchaseItem.Qty = oOrignalPurchaseItem.Qty - vSplitQty
        oOrignalPurchaseItem.Save()

        'Update all work order items where the original purchase item was the source
        'Set the source id = the new purchase item id for the same quantity of rows as the new quantity
        Select Case oPurchaseItem.Sourcetype

            Case PurchaseItemSourceType.WORKORDER.ToString()
                Select Case oPurchaseItem.Purchaseitemtype
                    Case PurchaseItemType.DIRECT.ToString()
                        Dim vNewWOQty As Integer = 0
                        Dim vTotal As Integer = 0
                        Dim vItemId As Integer = oPurchaseItem.Purchaseitemid
                        For Each oWOItem As Workorderitem In oWorkOrderItems
                            'Check whether able to split WO item based on entered Qty
                            If (vTotal + oWOItem.Qty) > oPurchaseItem.Qty And vItemId = oPurchaseItem.Purchaseitemid Then
                                vNewWOQty = oPurchaseItem.Qty - vTotal
                                vItemId = oOrignalPurchaseItem.Purchaseitemid
                                'update the WO item to remaining Qty
                                oWOItem.Qty = oWOItem.Qty - vNewWOQty
                            Else
                                oWOItem.Sourcedocument = vItemId
                            End If
                            'Update the WO item Qty upto greater than enter Qty 
                            vTotal = vTotal + oWOItem.Qty
                        Next
                        oWorkOrderItems.Save()

                        If vNewWOQty > 0 Then
                            addWorkOrderItem(oWorkOrderItems(0), vNewWOQty, oPurchaseItem.Purchaseitemid)
                        End If
                        splitLoadItems(oOrignalPurchaseItem, oPurchaseItem)
                    Case PurchaseItemType.REGULAR.ToString(), PurchaseItemType.MATERIAL.ToString()
                        Dim vCount As Integer = vSplitQty
                        For Each oWOItem As Workorderitem In oWorkOrderItems
                            If vCount <= 0 Then
                                Exit For
                            End If
                            oWOItem.Sourcedocument = oPurchaseItem.Purchaseitemid
                            vCount -= 1
                        Next
                        oWorkOrderItems.Save()
                        splitInventoryItems(oOrignalPurchaseItem, oPurchaseItem)
                End Select

            Case PurchaseItemSourceType.RELABEL.ToString()
                Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItemsBySource(vPurchaseItemId, _
                                                                                                    SourceType.PRCH.ToString())
                If Not oRelabelOrderItems Is Nothing AndAlso
                    oRelabelOrderItems.Count > 0 Then
                    Dim vCount As Integer = vSplitQty
                    For Each oRelabelItem As Relabelorderitem In oRelabelOrderItems
                        If vCount <= 0 Then
                            Exit For
                        End If
                        oRelabelItem.Sourcedoc = oPurchaseItem.Purchaseitemid
                        vCount -= 1
                    Next
                    oRelabelOrderItems.Save()
                    splitInventoryItems(oOrignalPurchaseItem, oPurchaseItem)
                End If

            Case Else
                splitInventoryItems(oOrignalPurchaseItem, oPurchaseItem)
        End Select

        Return True
    End Function

    Public Sub receivePurchaseItem(vInvitemnumber As Integer, vLotNo As String, vVendorWeight As Integer)
        Dim oInvitem As New Invitem
        If oInvitem.LoadByPrimaryKey(vInvitemnumber) = False Then
            Exit Sub
        End If

        Dim oProduct As New Product
        If oProduct.LoadByPrimaryKey(oInvitem.Productid) = False Then
            Exit Sub
        End If

        updateInvItemRcvdWeightAndStatus(vInvitemnumber, _
                                         oProduct.Stdweight, _
                                         vLotNo, _
                                         vVendorWeight, _
                                         InventoryItemStatus.TESTING.ToString())
        updateWorkOrderLotNoAndWHLocation(vInvitemnumber, _
                                          vLotNo)

        'If all the inventory items are received for the purchase item then update purchase item status as received.
        Dim oInvItems As InvitemCollection = getInventoryItems(oInvitem.Sourcedocument, _
                                                               SourceType.PRCH.ToString(), _
                                                               InventoryItemStatus.PENDING.ToString())
        If oInvItems Is Nothing OrElse _
            oInvItems.Count = 0 Then
            updatePurchaseItemStatusAndExpectedDate(oInvitem.Sourcedocument)
            'If all the purchase items are received then update order ststus to COMPLETED
            closePurchaseOrderByPurchaseItemStatus(oInvitem.Sourcedocument)
        End If

    End Sub

    Public Sub receiveRCVDHOLDItemIntoTesting(vItemID As Integer)
        Dim oInvitem As New Invitem
        If oInvitem.LoadByPrimaryKey(vItemID) = False Then
            Exit Sub
        End If

        oInvitem.Itemstatus = "TESTING"
        oInvitem.Receiveddate = System.DateTime.Now
        oInvitem.Warehousenumber = 1
        oInvitem.Warehouselocation = "DOCK"
        oInvitem.Save()

        updateWorkOrderLotNoAndWHLocation(vItemID, oInvitem.Lotnumber)


        If oInvitem.Sourcetype = "PRCH" Then
            'If all the inventory items are received for the purchase item then update purchase item status as received.
            Dim oInvItems As InvitemCollection = getInventoryItems(oInvitem.Sourcedocument,
                                                                   SourceType.PRCH.ToString(),
                                                                   InventoryItemStatus.PENDING.ToString())
            If oInvItems Is Nothing OrElse
                oInvItems.Count = 0 Then
                updatePurchaseItemStatusAndExpectedDate(oInvitem.Sourcedocument)
                'If all the purchase items are received then update order ststus to COMPLETED
                closePurchaseOrderByPurchaseItemStatus(oInvitem.Sourcedocument)
            End If
        End If


    End Sub


    Public Sub printPurchaseOrder(vPurchaseNumber As Integer)
        Dim oPurchase As New Purchase
        If oPurchase.LoadByPrimaryKey(vPurchaseNumber) = False Then
            Exit Sub
        End If
        Select Case oPurchase.Purchasetype
            Case PurchaseType.REGULAR.ToString()
                Dim rpt As New rptPurchaseOrder2(vPurchaseNumber)
                rpt.ShowPreview()
            Case PurchaseType.DIRECT.ToString()
                Dim rpt As New rptDirectPurchaseOrder2(vPurchaseNumber)
                rpt.ShowPreview()
        End Select
    End Sub

End Module


