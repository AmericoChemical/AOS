Imports AOS.BusinessObjects
Module InventoryItemsProcessing

    Enum ProductInventoryMethod
        VOLUME
        WEIGHT
    End Enum

    Public Enum PricingMethod
        VOLUME
        WEIGHT
    End Enum

    Public Enum InventoryClass
        FULLAVAILABLE = 1
        INPROCESS = 2
    End Enum

    Public Enum AllocatedType
        WORKORDER = 1
        RELABEL = 2
    End Enum

    Public Enum InventoryItemStatus
        AVAILABLE
        ALLOCATED
        PENDING
        TESTING
        INPROD
        RCVDHOLD
        FORRLBL
        RECEIVED
        QUARANTINED
        SHIPPED
        DEPLETED
    End Enum

    ''' <summary>
    ''' Allocates inventory to work order items if product is available in inventory
    ''' </summary>
    ''' <param name="vProductID"></param>
    ''' <remarks></remarks>
    Public Sub checkAndAssignInventory(vAllocatedType As AllocatedType, vWorkOrderNumber As Integer, vProductID As Integer, Optional oWOItems As WorkorderitemCollection = Nothing, Optional vRelabelOrderNumber As Integer = 0)
        Dim oWorkOrder As New Workorder
        If oWorkOrder.LoadByPrimaryKey(vWorkOrderNumber) = False Then
            Exit Sub
        End If
        If oWOItems Is Nothing Then
            oWOItems = getUnallocatedWorkOrderItems(vWorkOrderNumber,
                                                    vProductID)
        End If
        If (oWOItems.Count <= 0) Then
            Exit Sub
        End If

        Select Case vAllocatedType
            Case AllocatedType.WORKORDER
                For Each oWOItem As Workorderitem In oWOItems
                    allocateInventoryItems(oWOItem.Workorderitemnumber,
                                           AllocatedType.WORKORDER,
                                           oWOItem.Productid)
                Next
            Case AllocatedType.RELABEL
                Dim oProductFulfillments As ProductfulfillmentplanCollection = getFulfillmentPlan(vProductID,
                                                                                                  FulfillmentType.RLBL)
                If oProductFulfillments Is Nothing OrElse
                    oProductFulfillments.Count <= 0 Then
                    Exit Sub
                End If

                Dim oRelabelOrder As Relabelorder = Nothing
                If vRelabelOrderNumber > 0 Then
                    oRelabelOrder = New Relabelorder()
                    oRelabelOrder.LoadByPrimaryKey(vRelabelOrderNumber)
                End If
                For Each oProductFulfillment As Productfulfillmentplan In oProductFulfillments
                    'Reset relabel order to create new relabel order for next associated product if INV exists
                    If vRelabelOrderNumber <= 0 Then
                        oRelabelOrder = Nothing
                    End If

                    For Each oWOItem As Workorderitem In oWOItems
                        'Check if inventory available for the associated product
                        If inventoryAvailable(oProductFulfillment.Associatedproductid) = False Then
                            Exit For
                        End If

                        'If inventory available create relabel order only
                        If oRelabelOrder Is Nothing Then
                            oRelabelOrder = createRelabelOrder(oProductFulfillment.Productid,
                                                               1,
                                                               oWorkOrder.Workordernumber)
                        End If

                        'Create relabel order item for work order item
                        Dim oRelabelOrderItem As Relabelorderitem = createRelabelOrderItem(oWOItem.Workorderitemnumber, oRelabelOrder)
                        If oRelabelOrderItem Is Nothing Then
                            Continue For
                        End If

                        'Fulfill created relabel order item by INV
                        If allocateInventoryItems(oRelabelOrderItem.Relabelorderitemnumber,
                                                  AllocatedType.RELABEL,
                                                  oProductFulfillment.Associatedproductid) = False Then
                            Exit For
                        End If
                        updateWorkOrderItem(oWOItem.Workorderitemnumber, oRelabelOrderItem.Relabelorderitemnumber, SourceType.RLBL.ToString())
                    Next

                    oWOItems.Query.Load()

                    'Update the Qty of Relabel order if more than one relabel order items are created
                    'Cancel relabel order if no relabel order item created for this order
                    'No need to do this if single relabel order is created
                    If vRelabelOrderNumber = 0 AndAlso
                        Not oRelabelOrder Is Nothing Then
                        updateRelabelOrderQtyAndStatus(oRelabelOrder.Relabelordernumber)
                        checkAndUpdateRelabelOrderStatus(oRelabelOrder.Relabelordernumber)
                    End If
                Next
        End Select
    End Sub

    Public Function allocateInventoryItems(vAllocatedDocumentItemNumber As Integer, vAllocatedType As AllocatedType, vProductId As Integer) As Boolean
        ' Allocate INVITEMs in order AVAILABLE, TESTING, PENDING...
        If (allocateInventory(vAllocatedDocumentItemNumber,
                              vProductId,
                              vAllocatedType,
                              InventoryItemStatus.AVAILABLE.ToString()) = False) Then
            If (allocateInventory(vAllocatedDocumentItemNumber,
                                  vProductId,
                                  vAllocatedType,
                                  InventoryItemStatus.TESTING.ToString()) = False) Then
                Return allocateInventory(vAllocatedDocumentItemNumber,
                                         vProductId,
                                         vAllocatedType,
                                         String.Format("{0}','{1}",
                                                       InventoryItemStatus.INPROD.ToString(),
                                                       InventoryItemStatus.PENDING.ToString()),
                                         "AvailableDate ASC")
            End If
        End If
        Return True
    End Function

    Public Function allocateInventory(vAllocatedDocumentItemNumber As Integer, vProductId As Integer, vAllocatedType As AllocatedType, vProcessingStatus As String, Optional vSortBy As String = "") As Boolean
        If vProductId <= 0 Then
            Return False
        End If
        Dim oAvailableInventoryItems As ViewInvItemDetailsCollection
        oAvailableInventoryItems = getAvailableInventoryByStatus(vProductId,
                                                                 vProcessingStatus,
                                                                 vSortBy)
        Return allocateInventory(vAllocatedDocumentItemNumber,
                                 vAllocatedType,
                                 oAvailableInventoryItems)
    End Function


    ''' <summary>
    ''' Allocate the Available Inventory item to the Work Order Items.
    ''' </summary>
    ''' <param name="vPurchaseItemSourceType"></param>
    ''' <param name="vPurchaseItemId"></param>
    ''' <param name="vAvailableInventoryItems"></param>
    ''' <remarks></remarks>
    Public Sub allocateInventoryItems(vPurchaseItemSourceType As String, vPurchaseItemId As Integer, vAvailableInventoryItems As ViewInvItemDetailsCollection)
        If vPurchaseItemId <= 0 Then
            Exit Sub
        End If
        Select Case vPurchaseItemSourceType
            Case PurchaseItemSourceType.WORKORDER.ToString()
                Dim oWOItems As WorkorderitemCollection = getWorkOrderItemsByPurchaseItemID(vPurchaseItemId)
                If (oWOItems.Count <= 0) Then
                    Exit Sub
                End If
                For Each oWOItem As Workorderitem In oWOItems
                    allocateInventory(oWOItem.Workorderitemnumber,
                                      AllocatedType.WORKORDER,
                                      vAvailableInventoryItems)
                Next
            Case PurchaseItemSourceType.RELABEL.ToString()
                Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItemsBySource(vPurchaseItemId,
                                                                                                    SourceType.PRCH.ToString())
                If (oRelabelOrderItems.Count <= 0) Then
                    Exit Sub
                End If
                For Each oRelabelOrderItem As Relabelorderitem In oRelabelOrderItems
                    allocateInventory(oRelabelOrderItem.Relabelorderitemnumber,
                                      AllocatedType.RELABEL,
                                      vAvailableInventoryItems)
                Next
        End Select

    End Sub

    Public Function allocateInventory(vAllocatedDocumentItemNumber As Integer, vAllocatedType As AllocatedType, vAvailableInventoryItems As ViewInvItemDetailsCollection) As Boolean
        If vAllocatedDocumentItemNumber <= 0 Then
            Return False
        End If
        If vAvailableInventoryItems Is Nothing OrElse
            vAvailableInventoryItems.Count <= 0 Then
            Return False
        End If

        For Each oInvItemDetails As ViewInvItemDetails In vAvailableInventoryItems
            If allocateInventoryItem(vAllocatedDocumentItemNumber,
                                     vAllocatedType,
                                     oInvItemDetails.Invitemnumber) = False Then
                Return False
            End If

            ' Refresh the object to fetch any other new records
            vAvailableInventoryItems.Query.Load()

            Return True
            ' Exit available item loop to go to next WO item
            Exit For
        Next
        Return False

    End Function

    Public Function allocateInventoryItem(vAllocatedDocumentItemNumber As Integer, vAllocatedType As AllocatedType, vInvItemNumber As Integer) As Boolean
        Dim oInvItem As New Invitem
        If Not oInvItem.LoadByPrimaryKey(vInvItemNumber) Then
            Return False
        End If

        Dim oWorkOrderItem As New Workorderitem
        Dim oRelabelOrderItem As New Relabelorderitem

        Select Case vAllocatedType
            Case AllocatedType.WORKORDER
                If oWorkOrderItem.Workorderitemnumber Is Nothing OrElse
                    IsDBNull(oWorkOrderItem.Workorderitemnumber) Then
                    If oWorkOrderItem.LoadByPrimaryKey(vAllocatedDocumentItemNumber) = False Then
                        Return False
                    End If
                End If
                updateWorkOrderItem(oWorkOrderItem.Workorderitemnumber,
                                    Nothing,
                                    SourceType.INV.ToString(),
                                    oInvItem.Invitemnumber,
                                    oInvItem.Lotnumber,
                                    oInvItem.Warehouselocation,
                                    oInvItem.Unitcost)
            Case AllocatedType.RELABEL
                If oRelabelOrderItem.Relabelorderitemnumber Is Nothing OrElse
                    IsDBNull(oRelabelOrderItem.Relabelorderitemnumber) Then
                    If oRelabelOrderItem.LoadByPrimaryKey(vAllocatedDocumentItemNumber) = False Then
                        Return False
                    End If
                End If
                updateRelabelOrderItem(oRelabelOrderItem.Relabelorderitemnumber,
                                       SourceType.INV.ToString(),
                                       Nothing,
                                       oInvItem.Productid,
                                       oInvItem.Invitemnumber,
                                       IIf(oInvItem.Itemstatus = InventoryItemStatus.AVAILABLE.ToString(),
                                           RelabelOrderItemStatus.READY.ToString(),
                                           RelabelOrderItemStatus.PENDING.ToString()))
        End Select

        'Update Inventory Item record
        updateInventoryItem(oInvItem, Today,
                            IIf(vAllocatedType = AllocatedType.WORKORDER,
                                oWorkOrderItem.Workordernumber,
                                oRelabelOrderItem.Relabelordernumber),
                            vAllocatedType,
                            IIf(oInvItem.Itemstatus = InventoryItemStatus.AVAILABLE.ToString() AndAlso
                                vAllocatedType = AllocatedType.WORKORDER,
                                InventoryItemStatus.ALLOCATED.ToString(),
                                IIf(oInvItem.Itemstatus = InventoryItemStatus.AVAILABLE.ToString() AndAlso
                                    vAllocatedType = AllocatedType.RELABEL,
                                    InventoryItemStatus.FORRLBL.ToString(),
                                    oInvItem.Itemstatus)))
        Return True
    End Function

    Public Function getInventoryItems(vSourceDocument As Integer, vSourceType As String, Optional vItemStatus As String = "") As InvitemCollection
        If IsDBNull(vSourceDocument) Then
            Return Nothing
        End If
        If IsDBNull(vSourceType) Then
            Return Nothing
        End If
        If (vSourceDocument <= 0) Then
            Return Nothing
        End If

        Dim oInvitems As New InvitemCollection
        oInvitems.Query.Where(oInvitems.Query.Sourcedocument.Equal(vSourceDocument),
                              oInvitems.Query.Sourcetype.Equal(vSourceType))
        If vItemStatus <> "" Then
            oInvitems.Query.Where(oInvitems.Query.Itemstatus.Equal(vItemStatus))
        End If
        oInvitems.Query.Load()

        Return oInvitems
    End Function

    Public Function getUnallocatedInventoryItems(vSourceDocument As Integer, vSourceType As String) As InvitemCollection
        If (vSourceDocument <= 0) Then
            Return Nothing
        End If

        Dim oInvitems As New InvitemCollection
        oInvitems.Query.Where(oInvitems.Query.Sourcedocument.Equal(vSourceDocument),
                              oInvitems.Query.Sourcetype.Equal(vSourceType),
                              oInvitems.Query.Allocatedtype.IsNull(),
                              oInvitems.Query.Or(oInvitems.Query.Allocateddocument.IsNull(),
                                                 oInvitems.Query.Allocateddocument.Equal(0)))

        oInvitems.Query.Load()

        Return oInvitems
    End Function

    Public Function deleteInventoryItems(vSourceDocument As Integer, vSourceType As String, Optional vItemStatus As String = "") As Boolean

        Try
            Dim oInvitems As InvitemCollection = getInventoryItems(vSourceDocument, vSourceType, vItemStatus)
            If Not oInvitems Is Nothing Then
                For Each oInvitem As Invitem In oInvitems
                    oInvitem.MarkAsDeleted()
                Next
                oInvitems.Save()
            End If
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function

    Public Sub removeUnallocatedInventory(vSourcedocument As Integer, vSourceType As String)
        Dim oInvItems As InvitemCollection = getUnallocatedInventoryItems(vSourcedocument, vSourceType)

        If (oInvItems Is Nothing) Then
            Exit Sub
        End If

        For Each oItem As Invitem In oInvItems
            If (oItem.Itemstatus = InventoryItemStatus.PENDING.ToString() OrElse
                oItem.Itemstatus = InventoryItemStatus.INPROD.ToString()) Then
                oItem.MarkAsDeleted()
            End If
        Next
        oInvItems.Save()
    End Sub

    ''' <summary>
    ''' Unallocate Inventory Item
    ''' </summary>
    ''' <param name="vInvItemNumber"></param>
    ''' <remarks></remarks>
    Public Sub unAllocateInventoryItem(vInvItemNumber As Integer?)

        If vInvItemNumber Is Nothing Then
            Exit Sub
        End If

        Dim oInvItem As New Invitem
        oInvItem.LoadByPrimaryKey(vInvItemNumber)

        If (Not oInvItem Is Nothing) Then

            If oInvItem.Itemstatus = InventoryItemStatus.ALLOCATED.ToString() OrElse
               oInvItem.Itemstatus = InventoryItemStatus.FORRLBL.ToString() Then
                oInvItem.Itemstatus = InventoryItemStatus.AVAILABLE.ToString()
            End If
            oInvItem.Allocateddate = Nothing
            oInvItem.Allocatedtype = Nothing
            oInvItem.Allocateddocument = Nothing
        End If
        oInvItem.Save()
    End Sub

    Public Sub unAllocateInventoryItems(vSourceDocument As Integer, vSourceType As String)
        Dim oInvItems As New InvitemCollection
        oInvItems.Query.Where(oInvItems.Query.Sourcedocument.Equal(vSourceDocument),
                              oInvItems.Query.Sourcetype.Equal(vSourceType),
                              oInvItems.Query.Allocateddocument.IsNotNull(),
                              oInvItems.Query.Allocatedtype.IsNotNull())
        If oInvItems.Query.Load() Then
            For Each oInvItem As Invitem In oInvItems
                unAllocateInventoryItem(oInvItem.Invitemnumber)
            Next
        End If
    End Sub

    ''' <summary>
    ''' Get the list of Inventory Items that are in AVAILABLE, PENDING and TESTING statuses, have InventoryClass equals to 1
    ''' </summary>
    ''' <param name="vProductID"></param>
    ''' <returns>Returns the list of Inventory Items that are in AVAILABLE, PENDING and TESTING statuses, have InventoryClass equals to 1.</returns>
    ''' <remarks></remarks>
    Public Function getAvailableInventory(vProductID As Integer, Optional vSortBy As String = "invItemNumber") As ViewInvItemDetailsCollection
        Dim oAvailable As New ViewInvItemDetailsCollection
        oAvailable.Query.Where(oAvailable.Query.Productid.Equal(vProductID),
                               oAvailable.Query.Inventoryclass.Equal(InventoryClass.FULLAVAILABLE),
                               oAvailable.Query.Or(oAvailable.Query.Itemstatus.Equal(InventoryItemStatus.AVAILABLE.ToString()),
                                                   oAvailable.Query.Itemstatus.Equal(InventoryItemStatus.TESTING.ToString()),
                                                   oAvailable.Query.Itemstatus.Equal(InventoryItemStatus.PENDING.ToString()),
                                                   oAvailable.Query.Itemstatus.Equal(InventoryItemStatus.INPROD.ToString())),
                               oAvailable.Query.Allocateddocument.IsNull(),
                               oAvailable.Query.Allocateddate.IsNull())
        oAvailable.Query.Load()
        oAvailable.Sort = vSortBy

        Return oAvailable
    End Function

    ''' <summary>
    ''' Get the list of Inventory Items that are in the status sent by caller method, have InventoryClass equals to 1
    ''' </summary>
    ''' <param name="vProductID"></param>
    ''' <returns>Returns the list of Inventory Items that are in the status that user sent, have InventoryClass equals to 1.</returns>
    ''' <remarks></remarks>
    Public Function getAvailableInventoryByStatus(vProductID As Integer, vItemStatus As String, Optional vSortBy As String = "invItemNumber ASC") As ViewInvItemDetailsCollection
        Dim oAvailable As New ViewInvItemDetailsCollection
        oAvailable.Query.Where(oAvailable.Query.Productid.Equal(vProductID),
                               oAvailable.Query.Inventoryclass.Equal(InventoryClass.FULLAVAILABLE),
                               oAvailable.Query.Itemstatus.In(vItemStatus),
                               oAvailable.Query.Allocatedtype.IsNull(),
                               oAvailable.Query.Allocateddocument.IsNull(),
                               oAvailable.Query.Allocateddate.IsNull())
        oAvailable.Query.Load()
        oAvailable.Sort = IIf(String.IsNullOrEmpty(vSortBy), "invItemNumber", vSortBy)

        Return oAvailable
    End Function

    ''' <summary>
    ''' Get the list of Inventory Items that are in ALLOCATED, TESTING, or PENDING status and ALLOCATEDOCUMENT and ALLOCATEDDATE is NOT NULL
    ''' </summary>
    ''' <param name="vProductID"></param>
    ''' <returns>Returns the list of Inventory Items that are in ALLOCATED, TESTING, or PENDING status and ALLOCATEDOCUMENT and ALLOCATEDDATE is NOT NULL. Resultset is returned based on vSortBy order</returns>
    ''' <remarks></remarks>
    Public Function getAllocatedInventory(vProductID As Integer, vWorkOrderID As Integer, vSourceType As String, Optional vSortBy As String = "PLANNEDSHIPDATE DESC") As ViewInvItemDetailsCollection
        Dim oAllocated As New ViewInvItemDetailsCollection
        oAllocated.Query.Where(oAllocated.Query.Productid.Equal(vProductID),
                               oAllocated.Query.Or(oAllocated.Query.Itemstatus.Equal(InventoryItemStatus.ALLOCATED.ToString()),
                                                   oAllocated.Query.Itemstatus.Equal(InventoryItemStatus.TESTING.ToString()),
                                                   oAllocated.Query.Itemstatus.Equal(InventoryItemStatus.PENDING.ToString()),
                                                   oAllocated.Query.Itemstatus.Equal(InventoryItemStatus.INPROD.ToString())),
                               oAllocated.Query.Allocateddocument.IsNotNull(),
                               oAllocated.Query.Allocatedtype.IsNotNull(),
                               oAllocated.Query.Allocateddate.IsNotNull(),
                               oAllocated.Query.Allocatedtype.Equal(vSourceType),
                               oAllocated.Query.Allocateddocument.NotEqual(vWorkOrderID))
        oAllocated.Query.Load()
        oAllocated.Sort = vSortBy

        Return oAllocated
    End Function

    ''' <summary>
    ''' Re-Allocate the Allocated Inventory item to the Work Order Items.
    ''' </summary>
    ''' <param name="vPurchaseitemId"></param>
    ''' <param name="vAvailableInventory"></param>
    ''' <remarks></remarks>
    Public Sub reAllocateInventoryItems(vPurchaseitemId As Integer, ByVal vAvailableInventory As ViewInvItemDetailsCollection, vAllocatedType As String)

        ' Get the Work Order Items associated with this Purchase Item ID
        Dim oWOItems As WorkorderitemCollection = getWorkOrderItemsByPurchaseItemID(vPurchaseitemId, vAvailableInventory.Count)

        If (oWOItems.Count <= 0) Then
            Exit Sub
        End If

        ' If No Allocated Inventory Return
        If (vAvailableInventory.Count <= 0) Then
            Exit Sub
        End If

        ' If user selects more inventory than needed then show message and return
        If (vAvailableInventory.Count > oWOItems.Count) Then
            MsgBox("Changes cannot be made because number of inventory items selected is greater than the number of work order items " &
                   "associated with this purchase item", MsgBoxStyle.Exclamation, "ReAllocate Inventory")
            Exit Sub
        End If


        Dim oInvItem As Invitem
        Select Case vAllocatedType
            Case AllocatedType.WORKORDER.ToString()
                Dim vWorkOrderNumber As Integer
                For Each oWOItem As Workorderitem In oWOItems
                    For Each oInvItemDetails As ViewInvItemDetails In vAvailableInventory

                        'Allocate only if Item Status in "PENDING" or "TESTING" or "ALLOCATED" and Allocateddocument IS not NULL and Allocateddate is null
                        If (oInvItemDetails.Itemstatus = InventoryItemStatus.PENDING.ToString() OrElse
                            oInvItemDetails.Itemstatus = InventoryItemStatus.TESTING.ToString() OrElse
                            oInvItemDetails.Itemstatus = InventoryItemStatus.ALLOCATED.ToString() OrElse
                            oInvItemDetails.Itemstatus = InventoryItemStatus.INPROD.ToString()) AndAlso
                            (Not String.IsNullOrEmpty(oInvItemDetails.Allocateddocument)) Then

                            ' Get the Inventory Item to fulfill the WO Item
                            oInvItem = New Invitem
                            If Not oInvItem.LoadByPrimaryKey(oInvItemDetails.Invitemnumber) Then
                                Continue For
                            End If

                            ' allocating inventory to WO Item (WO Item that is associated with Purchase Item)
                            updateWorkOrderItem(oWOItem.Workorderitemnumber, Nothing, SourceType.INV.ToString(), oInvItem.Invitemnumber,
                                                oInvItem.Lotnumber, oInvItem.Warehouselocation, oInvItem.Unitcost)

                            'Update Inventory Item record to point to the WO Item that is associated with Purchase Item
                            vWorkOrderNumber = oInvItem.Allocateddocument
                            updateInventoryItem(oInvItem, Today, oWOItem.Workordernumber, AllocatedType.WORKORDER,
                                                IIf(oInvItem.Itemstatus = InventoryItemStatus.AVAILABLE.ToString(),
                                                    InventoryItemStatus.ALLOCATED.ToString(), oInvItem.Itemstatus))

                            ' Process the Work Order Where we took the Inventory Item from
                            Dim oWorkOrderItem As Workorderitem = getWorkOrderItemByWONumberAndInvItemNumber(vWorkOrderNumber, oInvItem.Invitemnumber)

                            Dim oPurchaseItem As New Purchaseitem
                            ' Update the Work Order Item and Purchase Item
                            If (Not oWorkOrderItem Is Nothing) Then
                                If (Not oWorkOrderItem.Workorderitemnumber Is Nothing) Then
                                    updateWorkOrderItem(oWorkOrderItem.Workorderitemnumber, Nothing, Nothing, Nothing)

                                    oPurchaseItem = getPurchaseItem(PurchaseItemSourceType.WORKORDER.ToString(),
                                                                    oWorkOrderItem.Workordernumber,
                                                                    oWorkOrderItem.Productid,
                                                                    ItemType.PRODUCT.ToString(),
                                                                    PurchaseItemsStatus.REQUESTED.ToString())

                                    If (oPurchaseItem Is Nothing) Then
                                        oPurchaseItem = New Purchaseitem
                                        oPurchaseItem = createPurchaseItem(PurchaseItemSourceType.WORKORDER.ToString(),
                                                                           oWorkOrderItem.Workordernumber, oWorkOrderItem.Itemid)
                                    Else
                                        updatePurchaseItem(oPurchaseItem.Purchaseitemid, oPurchaseItem.Qty + 1)
                                    End If
                                    ' Update the work order item(s) that had inventory reallocated
                                    updateWorkOrderItem(oWorkOrderItem.Workorderitemnumber, oPurchaseItem.Purchaseitemid, SourceType.PRCH.ToString())
                                End If
                            End If
                            oPurchaseItem = New Purchaseitem
                            oPurchaseItem.LoadByPrimaryKey(vPurchaseitemId)
                            updatePurchaseItem(oPurchaseItem.Purchaseitemid, oPurchaseItem.Qty - 1)

                            vAvailableInventory.Query.Load()

                            ' Exit available item loop to go to next WO item
                            Exit For
                        End If
                    Next
                    oWOItems.Save()
                Next
            Case AllocatedType.RELABEL
                'Future use
        End Select

    End Sub

    ''' <summary>
    ''' Sets AllocatedDate, AllocatedDocument and ItemStatus
    ''' </summary>
    ''' <param name="vInvItem"></param>
    ''' <param name="vAllocatedDate"></param>
    ''' <param name="vAllocatedDocument"></param>
    ''' <param name="vAllocatedType"></param>
    ''' <param name="vItemStatus"></param>
    ''' <remarks></remarks>
    Public Sub updateInventoryItem(vInvItem As Invitem, vAllocatedDate As Date, vAllocatedDocument As Integer, vAllocatedType As AllocatedType, vItemStatus As String)
        vInvItem.Allocateddate = vAllocatedDate
        vInvItem.Allocatedtype = vAllocatedType.ToString()
        vInvItem.Allocateddocument = vAllocatedDocument
        vInvItem.Itemstatus = vItemStatus
        vInvItem.Save()
    End Sub

    ''' <summary>
    ''' Creates inventory item based on purchase order. Also update work order items
    ''' </summary>
    ''' <param name="oPurchaseItems"></param>
    ''' <remarks></remarks>
    Public Sub createInventoryItemsAndUpdateWOItems(oPurchaseItems As PurchaseitemCollection)
        For Each oPurchaseItem As Purchaseitem In oPurchaseItems
            createInventoryItemsByPurchaseItem(oPurchaseItem)
        Next
    End Sub

    Public Sub createInventoryItemsByPurchaseItem(oPurchaseItem As Purchaseitem)
        Dim vIndex As Integer = 0
        Dim vAllocatedDoc As Integer? = Nothing
        Dim vAllocatedDocItemId As Integer
        Dim vInvitemNumber As Integer

        Dim oWorkOrderItems As WorkorderitemCollection = getWorkOrderItemsBySource(oPurchaseItem.Purchaseitemid, SourceType.PRCH.ToString())
        Dim oRelabelOrderItems As RelabelorderitemCollection = getRelabelOrderItemsBySource(oPurchaseItem.Purchaseitemid, SourceType.PRCH.ToString())


        'first check to see if Purchase Item Product ID is a BULK INVENTORY Item 
        'if so, only set up ONE inventory record for the purchase and set UNITSREMAINING equal to Purchase Qty
        Dim oProduct As New Product
        If Not oProduct.LoadByPrimaryKey(oPurchaseItem.Itemid) Then
            MsgBox("Could not retrieve PRODUCT record for PURCHASE ITEM", MsgBoxStyle.Critical, "Error - See Database Administrator")
            Exit Sub
        End If
        If oProduct.Bulkinventory = True Then
            vInvitemNumber = createInventoryItem("PENDING",
                               oPurchaseItem.Purchaseitemid,
                               SourceType.PRCH.ToString(),
                               IIf(vAllocatedDoc Is Nothing, Nothing, oPurchaseItem.Sourcetype),
                               IIf(vAllocatedDoc Is Nothing, Nothing, oPurchaseItem.Sourcedocument),
                               IIf(vAllocatedDoc Is Nothing, Nothing, Now),
                               oPurchaseItem.Itemid,
                               oPurchaseItem.Itemdescription,
                               oPurchaseItem.Container,
                               oPurchaseItem.Unitcost,
                               oPurchaseItem.Uom,
                               InventoryClass.INPROCESS)
            updateInventoryItemCost(vInvitemNumber, oPurchaseItem.Unitcost, oPurchaseItem.Uom, oPurchaseItem.Unitsincontainer)
            'update UNITSREMAINING in the newly created INVITEM record
            Dim oInv As New Invitem
            If Not oInv.LoadByPrimaryKey(vInvitemNumber) Then
                MsgBox("Error updating UNITSREMAINING in the newly created INVITEM record", MsgBoxStyle.Critical, "Error - Inv Item not found")
                Exit Sub
            End If
            oInv.Unitsremaining = oPurchaseItem.Qty
            oInv.Uom = oPurchaseItem.Uom
            oInv.Save()
            Exit Sub
        End If

        'at this point, you have determined that the item ordered is NOT BULK INVENTORY, so proceed as normal

        'For each purchase item, create a number of inventory items equal to the quantity
        For vIndex = 0 To oPurchaseItem.Qty - 1

            'This is to confirm if the purchase item is associated to the allocated document and get the item id
            Select Case oPurchaseItem.Sourcetype
                Case PurchaseItemSourceType.WORKORDER.ToString()
                    If Not oWorkOrderItems Is Nothing AndAlso
                                 oWorkOrderItems.Count > vIndex Then
                        vAllocatedDoc = oWorkOrderItems.Item(vIndex).Workordernumber
                        vAllocatedDocItemId = oWorkOrderItems.Item(vIndex).Workorderitemnumber
                    End If
                Case PurchaseItemSourceType.RELABEL.ToString()
                    If Not oRelabelOrderItems Is Nothing AndAlso
                                   oRelabelOrderItems.Count > vIndex Then
                        vAllocatedDoc = oRelabelOrderItems.Item(vIndex).Relabelordernumber
                        vAllocatedDocItemId = oRelabelOrderItems.Item(vIndex).Relabelorderitemnumber
                    End If
            End Select

            vInvitemNumber = createInventoryItem("PENDING",
                                oPurchaseItem.Purchaseitemid,
                                SourceType.PRCH.ToString(),
                                IIf(vAllocatedDoc Is Nothing, Nothing, oPurchaseItem.Sourcetype),
                                IIf(vAllocatedDoc Is Nothing, Nothing, oPurchaseItem.Sourcedocument),
                                IIf(vAllocatedDoc Is Nothing, Nothing, Now),
                                oPurchaseItem.Itemid,
                                oPurchaseItem.Itemdescription,
                                oPurchaseItem.Container,
                                oPurchaseItem.Unitcost,
                                oPurchaseItem.Uom,
                                oPurchaseItem.Inventoryclass)
            updateInventoryItemCost(vInvitemNumber, oPurchaseItem.Unitcost, oPurchaseItem.Uom, oPurchaseItem.Unitsincontainer)

            'Update the inventory details to the associated document
            Select Case oPurchaseItem.Sourcetype
                Case PurchaseItemSourceType.WORKORDER.ToString()
                    updateWorkOrderItem(vAllocatedDocItemId,
                                        oPurchaseItem.Purchaseitemid,
                                        SourceType.PRCH.ToString(),
                                        vInvitemNumber,
                                        oWorkOrderItems.Item(vIndex).Lotnumber,
                                        oWorkOrderItems.Item(vIndex).Warehouselocation)

                Case PurchaseItemSourceType.RELABEL.ToString()
                    updateRelabelOrderItem(vAllocatedDocItemId,
                                           SourceType.PRCH.ToString(),
                                           oPurchaseItem.Purchaseitemid,
                                           oPurchaseItem.Itemid,
                                           vInvitemNumber)
            End Select
        Next

    End Sub


    ''' <summary>
    ''' Creates new inventory item if product exists.
    ''' </summary>
    Private Function createInventoryItem(vItemstatus As String, vSourcedocument As Integer, vSourcetype As String, vAllocatedType As String, vAllocateddocument As String, vAllocateddate As Date?, vProductid As Integer,
                                    vProductdesc As String, vContainer As String, vUnitcost As Decimal, vUom As String, Optional vInventoryclass As Integer? = Nothing, Optional vLotNumber As String = "") As Integer
        Dim oInvitem As New Invitem
        Dim oProduct As Product = getProductByProductID(vProductid)

        ' If Product doesn't exist then there is no use of INVITEM rows
        If (oProduct Is Nothing) Then
            Return Nothing
        End If

        oInvitem.AddNew()
        oInvitem.Itemstatus = vItemstatus
        oInvitem.Sourcedocument = vSourcedocument
        oInvitem.Sourcetype = vSourcetype
        oInvitem.Allocatedtype = vAllocatedType
        oInvitem.Allocateddocument = vAllocateddocument
        oInvitem.Allocateddate = vAllocateddate
        oInvitem.Productid = vProductid
        oInvitem.Productdesc = vProductdesc
        oInvitem.Container = vContainer
        oInvitem.Unitcost = vUnitcost
        oInvitem.Uom = vUom
        oInvitem.Inventoryclass = vInventoryclass
        oInvitem.Lotnumber = IIf(String.IsNullOrEmpty(vLotNumber), oInvitem.Lotnumber, vLotNumber)
        oInvitem.Unitsremaining = Convert.ToSingle(IIf((oProduct.Inventorymethod = ProductInventoryMethod.WEIGHT.ToString()), oProduct.Weightunits, oProduct.Volumeunits))
        oInvitem.Save()

        Return oInvitem.Invitemnumber
    End Function

    Public Sub updateInventoryItemLotNumber(vProdOrder As Prodorder)
        If (vProdOrder Is Nothing) Then
            Exit Sub
        End If

        Dim oInvItems As InvitemCollection = getInventoryItems(vProdOrder.Prodordernum, SourceType.PORD.ToString())
        If (oInvItems Is Nothing) Then
            Exit Sub
        End If

        For Each oItem As Invitem In oInvItems
            oItem.Lotnumber = vProdOrder.Lotnumber
        Next
        oInvItems.Save()
    End Sub

    Public Sub createINVITEMsProcessWOItemsAndProdOrder(vWorkOrderNumber As Integer)
        Dim oWOItems As WorkorderitemCollection = getWorkOrderItemsByWorkOrderNumberAndSourcetype(vWorkOrderNumber, SourceType.PORD.ToString())
        If oWOItems Is Nothing Then
            Exit Sub
        End If

        ' Sort it on Source Document
        oWOItems.Sort = "Sourcedocument"

        For vIndex As Integer = 0 To oWOItems.Count - 1
            If (vIndex = 0 OrElse
                oWOItems(vIndex - 1).Sourcedocument <> oWOItems(vIndex).Sourcedocument) Then

                Dim oProdOrder As New Prodorder
                If (oProdOrder.LoadByPrimaryKey(oWOItems(vIndex).Sourcedocument)) Then
                    createINVITEMsProcessWOItems(oProdOrder, InventoryClass.FULLAVAILABLE)
                    oProdOrder.Orderstatus = ProdOrderStatus.INPROD.ToString()
                    oProdOrder.Save()
                End If
            End If
        Next
    End Sub

    Public Sub createINVITEMsProcessWOItems(oProdOrder As Prodorder, vInvClass As InventoryClass)

        If (oProdOrder Is Nothing) Then
            Exit Sub
        End If

        If (allInvItemsUnAllocated(oProdOrder.Prodordernum, SourceType.PORD.ToString()) = False) Then
            Exit Sub
        End If

        removeUnallocatedInventory(oProdOrder.Prodordernum, SourceType.PORD.ToString())

        Dim oProduct As New Product
        If (oProduct.LoadByPrimaryKey(oProdOrder.Productid) = False) Then
            Exit Sub
        End If

        Dim vWorkorderitemnumber As Integer = 0
        Dim vWorkordernumber As Integer = 0
        Dim oWorkOrderItems As WorkorderitemCollection
        oWorkOrderItems = getWorkOrderItemsBySource(oProdOrder.Prodordernum, SourceType.PORD.ToString())

        Dim vInvitemNumber As Integer
        For vIndex As Integer = 0 To oProdOrder.Productqty - 1

            ' Get the Work Order Item Number
            If Not oWorkOrderItems Is Nothing Then
                If oWorkOrderItems.Count > 0 Then
                    vWorkorderitemnumber = oWorkOrderItems.Item(vIndex).Workorderitemnumber
                    vWorkordernumber = oWorkOrderItems.Item(vIndex).Workordernumber
                End If
            End If

            'For each purchase item, create a number of inventory items equal to the quantity
            vInvitemNumber = createInventoryItem(ProdOrderStatus.INPROD.ToString(),
                                                 oProdOrder.Prodordernum,
                                                 SourceType.PORD.ToString(),
                                                 IIf((vWorkordernumber <= 0), Nothing, AllocatedType.WORKORDER.ToString()),
                                                 IIf((vWorkordernumber <= 0), Nothing, vWorkordernumber),
                                                 IIf((vWorkordernumber <= 0), Nothing, Now),
                                                 oProduct.Productid,
                                                 oProduct.Productdesc,
                                                 oProduct.Container,
                                                 IIf(oProduct.Inventorymethod = ProductInventoryMethod.VOLUME.ToString(), oProduct.Volumestandardcost, oProduct.Weightstandardcost),
                                                 IIf(oProduct.Inventorymethod = ProductInventoryMethod.VOLUME.ToString(), oProduct.Volumeuom, oProduct.Weightuom),
                                                 vInvClass,
                                                 oProdOrder.Lotnumber)

            'Update the work order item(s) where prod order is marked as source
            If vWorkorderitemnumber > 0 Then
                updateWorkOrderItem(vWorkorderitemnumber,
                                    oProdOrder.Prodordernum,
                                    SourceType.PORD.ToString(),
                                    vInvitemNumber,
                                    oWorkOrderItems.Item(vIndex).Lotnumber,
                                    oWorkOrderItems.Item(vIndex).Warehouselocation)
            End If
        Next
    End Sub

#Region "View Product Cost Records"

    Public Sub AddNewCostRecord(ByVal productID As Integer)
        Using frm As New frmUpdateProductUnitCost() With
            {
                .vProductID = productID,
                .vAddtype = "NEW"
            }
            frm.ShowDialog()
        End Using
    End Sub

    Public Sub EditCostRecord(ByVal productID As Integer, ByVal costRecID As Integer)
        Using frm As New frmUpdateProductUnitCost() With
            {
                .vProductID = productID,
                .vAddtype = "EDIT",
                .vCostID = costRecID
            }
            frm.ShowDialog()
        End Using
    End Sub

    Public Sub DeleteCostRecord(ByVal costRecID As Integer)
        Try
            Dim oCostRec As Productcost = New Productcost

            Using updateTransaction As New Transactions.TransactionScope
                updateTransaction.Complete()
            End Using

            oCostRec.LoadByPrimaryKey(costRecID)
            If (oCostRec.Isdefaultcostrecord = True) Then
                MsgBox("You cannot delete the DEFAULT cost record for a product. Edit the existing cost record or Mark another as default", MsgBoxStyle.Critical, "Error - Delete Failed")
                Exit Sub
            End If
            oCostRec.MarkAsDeleted()
            oCostRec.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
            Exit Sub
        End Try
        MsgBox("Product Cost record successfully deleted.")
    End Sub


    Public Function getProductCostDataCollectionsByProductID(ByVal vProductID As Integer) As ProductcostCollection
        Dim oCosts As New ProductcostCollection
        oCosts.Query.Where(oCosts.Query.Productid.Equal(vProductID))
        oCosts.Query.Load()
        oCosts.Sort = "IsActive DESC, EFFECTIVEDATE DESC"
        Return oCosts
    End Function

    Public Function getVendorCollection() As VendorCollection
        Dim oVendors As New VendorCollection
        oVendors.LoadAll()
        oVendors.Sort = "VENDORNAME"
        Return oVendors
    End Function

    Public Function getVendorCollection(vStatus As String) As VendorCollection
        Dim oVendors As New VendorCollection
        If vStatus = "" Then
            oVendors.LoadAll()
        Else
            oVendors.Query.Where(oVendors.Query.Vendorstatus.Equal(vStatus))
            oVendors.Query.Load()
        End If
        oVendors.Sort = "VENDORNAME"
        Return oVendors
    End Function

    Public Function getProductByProductID(ByVal vProductID As Integer) As Product
        Dim oProduct As New Product
        oProduct.LoadByPrimaryKey(vProductID)
        Return oProduct
    End Function

    Public Function getInvItemsByInvItemNumbers(ByVal vCommaSeparatedInvitemnumber As String) As InvitemCollection
        Dim oInvItems As New InvitemCollection
        oInvItems.Query.Where(oInvItems.Query.Invitemnumber.In(vCommaSeparatedInvitemnumber))
        oInvItems.Query.Load()
        Return oInvItems
    End Function

    Public Function getViewInvItemsByInvItemNumbers(ByVal vCommaSeparatedInvitemnumber As String) As ViewInvItemListCollection
        Dim oInvItems As New ViewInvItemListCollection
        oInvItems.Query.Where(oInvItems.Query.Invitemnumber.In(vCommaSeparatedInvitemnumber))
        oInvItems.Query.Load()
        Return oInvItems
    End Function

    Public Function getInvItemsByPurchaseNumber(ByVal vPurchaseNumber As Integer) As ViewInvItemListCollection
        Dim oInvItems As New ViewInvItemListCollection
        oInvItems.Query.Where(oInvItems.Query.Purchasenumber.Equal(vPurchaseNumber))
        oInvItems.Query.Load()
        oInvItems.Sort = "LOTNUMBER, INVITEMNUMBER ASC"
        Return oInvItems
    End Function

    Public Function getInvItems(vSourceDocument As Integer, vSourceType As String, Optional vInvItemStatus As String = "") As ViewInvItemListCollection
        Dim oInvItems As New ViewInvItemListCollection
        oInvItems.Query.Where(oInvItems.Query.Sourcedocument.Equal(vSourceDocument),
                              oInvItems.Query.Sourcetype.Equal(vSourceType))
        If String.IsNullOrEmpty(vInvItemStatus) = False Then
            oInvItems.Query.Where(oInvItems.Query.Itemstatus.Equal(vInvItemStatus))
        End If
        oInvItems.Query.Load()
        Return oInvItems
    End Function

    Public Function getInvItemsByAllocatedDoc(vAllocateddocument As Integer, vAllocatedtype As String) As ViewInvItemListCollection
        Dim oInvItems As New ViewInvItemListCollection
        oInvItems.Query.Where(oInvItems.Query.Allocateddocument.Equal(vAllocateddocument),
                              oInvItems.Query.Allocatedtype.Equal(vAllocatedtype))
        oInvItems.Query.Load()
        Return oInvItems
    End Function

    Public Function getNotReceivedInvItemsByPurchaseItemIDs(ByVal vCommaSeparatedPurchaseItemID As Integer) As ViewInvItemListCollection
        Dim oInvItems As New ViewInvItemListCollection
        oInvItems.Query.Where(oInvItems.Query.Sourcedocument.In(vCommaSeparatedPurchaseItemID),
                              oInvItems.Query.Lotnumber.IsNotNull,
                              oInvItems.Query.Vendorweight.IsNotNull,
                              oInvItems.Query.Sourcetype.Equal(SourceType.PRCH.ToString()),
                              oInvItems.Query.Rcvdweight.IsNotNull)
        oInvItems.Query.Load()
        Return oInvItems
    End Function

#End Region

    Public Sub updateInvItemRcvdWeightAndStatus(vInvitemnumber As Integer, vStdweight As Integer,
                                                Optional vLotNo As String = "", Optional vVendorWeight As Integer = 0,
                                                Optional vItemStatus As String = "", Optional vReasonCode As String = "", Optional vReasonText As String = "")

        Dim vPriorStatus As String = ""

        Dim oInvitem As New Invitem
        oInvitem.LoadByPrimaryKey(vInvitemnumber)
        vPriorStatus = oInvitem.Itemstatus

        oInvitem.Rcvdweight = vStdweight

        If vItemStatus <> "" Then
            oInvitem.Lotnumber = vLotNo
            oInvitem.Vendorweight = vVendorWeight
            If vItemStatus = InventoryItemStatus.TESTING.ToString() Then
                oInvitem.Itemstatus = IIf(oInvitem.Itemstatus = InventoryItemStatus.PENDING.ToString(), vItemStatus, oInvitem.Itemstatus)
                oInvitem.Receiveddate = System.DateTime.Now
                oInvitem.Warehousenumber = 1
                oInvitem.Warehouselocation = "DOCK"
            ElseIf vItemStatus = InventoryItemStatus.RCVDHOLD.ToString() Then
                oInvitem.Itemstatus = vItemStatus
                addRcvdHoldRecord(oInvitem.Invitemnumber, vReasonCode, vReasonText, vPriorStatus, True)
            End If
        End If
        oInvitem.EndEdit()
        oInvitem.Save()
    End Sub

    Public Sub addRcvdHoldRecord(vInvItemNum As Integer, vReasonCode As String, vReasonText As String, vPriorStatus As String, vAskForReason As Boolean)

        Dim vNewReasonText As String = ""
        If vAskForReason Then
            vNewReasonText = getUserString("Enter a reason for the item being placed ON HOLD:", vReasonText)
        Else
            vNewReasonText = vReasonText
        End If
        Dim oRcvdHold As New Receivedhold
        oRcvdHold.Invitemnumber = vInvItemNum
        oRcvdHold.Reasoncode = vReasonCode
        oRcvdHold.Reasontext = vNewReasonText
        oRcvdHold.Prioritemstatus = vPriorStatus
        oRcvdHold.Holdtime = Now
        oRcvdHold.Save()

    End Sub

    ''' <summary>
    ''' Sets ActualUnitCost, ActualCostUOM and ActualCostUnits
    ''' </summary>
    ''' <param name="vInvitemNumber"></param>
    ''' <param name="vActualunitcost"></param>
    ''' <param name="vActualcostuom"></param>
    ''' <param name="vActualcostunits"></param>
    ''' <remarks></remarks>
    Public Sub updateInventoryItemCost(vInvitemNumber As Integer, vActualunitcost As Decimal?, vActualcostuom As String, vActualcostunits As Decimal?)
        Dim oInvItem As New Invitem
        oInvItem.LoadByPrimaryKey(vInvitemNumber)
        oInvItem.Actualunitcost = vActualunitcost
        oInvItem.Actualcostuom = vActualcostuom
        oInvItem.Actualcostunits = vActualcostunits
        oInvItem.EndEdit()
        oInvItem.Save()
    End Sub

    Public Sub updateInventoryClassAndStatus(vInvitemnumber As Integer, vInventoryClass As Integer, vItemStatus As String)
        If vInvitemnumber = 0 Then
            Exit Sub
        End If

        Dim oInvItem As New Invitem
        If oInvItem.LoadByPrimaryKey(vInvitemnumber) Then
            oInvItem.Inventoryclass = vInventoryClass
            oInvItem.Itemstatus = IIf(String.IsNullOrEmpty(vItemStatus), oInvItem.Itemstatus, vItemStatus)
            oInvItem.Save()
        End If
    End Sub

    Public Sub createInvPhys(vInvitemnumber As Integer, vSourceDocument As Integer, vUnitsEntered As Double, vUnitsOriginal As Double, vTxtype As String, vTxreason As String, vItemStatus As String, vSourcetype As String)
        Dim oInvphys As New Invphys
        oInvphys.AddNew()
        oInvphys.Txtime = Now
        oInvphys.Txwho = vCurrentUserLogin
        oInvphys.Invitemnumber = vInvitemnumber
        oInvphys.Unitsentered = vUnitsEntered
        oInvphys.Unitsoriginal = vUnitsOriginal
        oInvphys.Txtype = vTxtype
        oInvphys.Txreason = vTxreason
        oInvphys.Itemstatus = vItemStatus
        oInvphys.Sourcedocument = vSourceDocument
        oInvphys.Sourcetype = vSourcetype
        oInvphys.EndEdit()
        oInvphys.Save()
    End Sub

    Public Sub rollBackInventory(vSourcedocument As Integer, vSourceType As String)
        Dim oInvPhyses As InvphysCollection = getInvPhys(vSourcedocument,
                                                         vSourceType,
                                                         "FACONV")
        If Not oInvPhyses Is Nothing Then
            For Each oInvPhys As Invphys In oInvPhyses
                Dim oInvItem As New Invitem
                If oInvItem.LoadByPrimaryKey(oInvPhys.Invitemnumber) Then
                    If checkRMProductAgainstInventory(oInvItem.Productid,
                                                      oInvItem.Unitsremaining) Then
                        If checkInventoryAvailable(oInvItem.Productid,
                                                   vSourcedocument,
                                                   oInvItem.Unitsremaining) Then
                            createInvPhys(oInvPhys.Invitemnumber,
                                            oInvPhys.Sourcedocument,
                                            oInvPhys.Unitsentered,
                                            oInvPhys.Unitsoriginal,
                                            "IPCONV",
                                            oInvPhys.Txreason,
                                            "FULL AVAILABLE",
                                            oInvPhys.Sourcetype)

                            updateInventoryClassAndStatus(oInvPhys.Invitemnumber,
                                                          InventoryClass.FULLAVAILABLE,
                                                          InventoryItemStatus.AVAILABLE.ToString())
                        End If
                    End If
                End If
            Next
        End If
    End Sub

    Public Function allInvItemsUnAllocated(vSourcedocument As Integer, vSourceType As String) As Boolean
        Dim oInvItems As InvitemCollection = getInventoryItems(vSourcedocument, vSourceType)

        If (oInvItems Is Nothing) Then
            Return True
        End If

        For Each oItem As Invitem In oInvItems
            ' If system finds even one record, should return false
            If String.IsNullOrEmpty(oItem.Allocateddocument) = False AndAlso
               IsDBNull(oItem.Allocateddocument) = False AndAlso
               Not oItem.Allocateddocument Is Nothing Then
                Return False
            End If
        Next

        Return True
    End Function

    Public Function getInvPhys(vSourcedocument As Integer, vSourceType As String, vTxtype As String) As InvphysCollection
        Dim oInvPhys As New InvphysCollection
        oInvPhys.Query.Where(oInvPhys.Query.Sourcedocument.Equal(vSourcedocument),
                             oInvPhys.Query.Sourcetype.Equal(vSourceType),
                             oInvPhys.Query.Txtype.Equal(vTxtype))
        oInvPhys.Query.Load()

        Return oInvPhys
    End Function

    Public Function checkInventoryAvailable(vRMProductID As Integer, vProdOrderNumber As Integer, vUnitsRemaining As Decimal) As Boolean

        ' get the MaterialProduct for the Raw Material Product that is needed by an APIS
        Dim oMaterialProduct As Materialproduct = getMaterialProductByProduct(vRMProductID)

        If (oMaterialProduct Is Nothing) Then
            Return True
        End If

        ' get the available quantity for raw material
        Dim vAvailable As Decimal = getAvailableQty(oMaterialProduct)

        ' Now get the Quantity used by the Production Order by the Material associated with the product
        Dim oProdItem As Proditem = getProdItems(vProdOrderNumber, oMaterialProduct.Materialid)
        Dim oProdItemQty As Double = 0
        If (Not oProdItem Is Nothing) Then
            oProdItemQty = oProdItem.Qty
        End If

        Return IIf((vAvailable + oProdItemQty) > vUnitsRemaining, True, False)
    End Function

    Public Function checkRMProductAgainstInventory(vProductID As Integer, vUnitsRemaining As Double) As Boolean
        Return IIf(getProductUnits(vProductID) <= vUnitsRemaining, True, False)
    End Function

    Public Function getProductUnits(vProductID As Integer) As Decimal
        Dim vUnit As Decimal
        Dim oProduct As New Product

        If (oProduct.LoadByPrimaryKey(vProductID)) Then
            If oProduct.Inventorymethod = ProductInventoryMethod.VOLUME.ToString() Then
                vUnit = IIf((oProduct.Volumeunits Is Nothing OrElse IsDBNull(oProduct.Volumeunits)), 0, oProduct.Volumeunits)
            Else
                vUnit = IIf((oProduct.Weightunits Is Nothing OrElse IsDBNull(oProduct.Weightunits)), 0, oProduct.Weightunits)
            End If
        End If

        Return vUnit
    End Function

    Public Function getRMAvailableByProduct(vProductID As Integer) As Double
        Dim oRMAvailableByProduct As New ViewRMAvailableByProduct

        oRMAvailableByProduct.Query.Where(oRMAvailableByProduct.Query.Productid.Equal(vProductID))
        If oRMAvailableByProduct.Query.Load() Then
            Return oRMAvailableByProduct.Totalavailable
        End If
        Return 0
    End Function

    ''' <summary>
    ''' Get the list of Inventory Items for given InvItem number
    ''' </summary>
    ''' <param name="vINVITEMNum"></param>
    ''' <returns>Get the list of Inventory Items for given InvItem number.</returns>
    ''' <remarks></remarks>
    Public Function getViewInvItemDetails(vINVITEMNum As Integer) As ViewInvItemDetailsCollection
        Dim oInvItems As New ViewInvItemDetailsCollection
        oInvItems.Query.Where(oInvItems.Query.Invitemnumber.Equal(vINVITEMNum))
        oInvItems.Query.Load()
        Return oInvItems
    End Function

    Public Sub splitInventoryItems(oOldPurchase As Purchaseitem, oNewPurchase As Purchaseitem)
        If oOldPurchase Is Nothing Then
            Exit Sub
        End If
        If oNewPurchase Is Nothing Then
            Exit Sub
        End If

        Dim oInvItems As InvitemCollection = getInventoryItems(oOldPurchase.Purchaseitemid, SourceType.PRCH.ToString())
        If oInvItems.Count <= 0 Then
            Exit Sub
        End If

        oInvItems.Sort = "INVITEMNUMBER DESC"
        For vIndex As Integer = 0 To oNewPurchase.Qty - 1
            oInvItems(vIndex).Sourcedocument = oNewPurchase.Purchaseitemid
        Next
        oInvItems.Save()
    End Sub

    Public Function inventoryAvailable(vProductId As Integer) As Boolean
        If vProductId <= 0 Then
            Return False
        End If
        Return IIf(getAvailableInventory(vProductId).Count > 0, True, False)
    End Function

    Public Sub markInventoryItemsStatus(vSampleKey As Integer)
        Dim oItems As New InvitemCollection
        Try
            oItems.Query.Where(oItems.Query.Testsamplekey.Equal(vSampleKey))
            If Not oItems.Query.Load() Then
                Exit Sub
            End If

            For Each oItem As Invitem In oItems
                updateInventory(oItem.Invitemnumber)
            Next
        Catch ex As Exception
            MsgBox("There was an error updating the status of the inventory items from this sample",
                   MsgBoxStyle.Critical,
                   "Error - Inventory Item Status")
        End Try
    End Sub

    Public Sub updateInventory(vInvItemNumber As Integer)
        Dim oItem As New Invitem
        If (Not oItem.LoadByPrimaryKey(vInvItemNumber)) Then
            Exit Sub
        End If

        Select Case oItem.Allocatedtype
            Case InventoryItemsProcessing.AllocatedType.RELABEL.ToString()
                oItem.Itemstatus = InventoryItemStatus.FORRLBL.ToString()
                updateRelabelOrderAndItemStatus(oItem.Invitemnumber,
                                                String.Format("{0}','{1}",
                                                              RelabelOrderItemStatus.PENDING.ToString(),
                                                              RelabelOrderItemStatus.PRCH.ToString()),
                                                RelabelOrderItemStatus.READY.ToString())
            Case InventoryItemsProcessing.AllocatedType.WORKORDER.ToString()
                oItem.Itemstatus = InventoryItemStatus.ALLOCATED.ToString()
            Case Else
                If oItem.Inventoryclass = 1 Then
                    oItem.Itemstatus = InventoryItemStatus.AVAILABLE.ToString()
                Else
                    oItem.Itemstatus = "IN PROCESS"
                End If

        End Select

        oItem.Save()
    End Sub


    Public Sub prepareMiniBarcodeLabelForInventoryItem(vInvItemNumber As Integer)

        Dim oItem As New Invitem
        If Not oItem.LoadByPrimaryKey(vInvItemNumber) Then
            Exit Sub
        End If

        'Create an array and pull inventory item data to print on Mini labels
        Dim InvItems(0, 4) As String


        Dim I As Integer
        For I = 0 To InvItems.GetUpperBound(0)
            Try
                InvItems(I, 0) = oItem.Invitemnumber
                InvItems(I, 1) = oItem.Productid
                InvItems(I, 2) = "Lot - " & IIf(IsDBNull(oItem.Lotnumber), "", oItem.Lotnumber)
                InvItems(I, 3) = "Bin - " & IIf(IsDBNull(oItem.Warehouselocation), "DOCK", oItem.Warehouselocation)
                InvItems(I, 4) = IIf(IsDBNull(oItem.Container), "", oItem.Container)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        Dim vPrintResult As Boolean = False
        If Not printBarCodeLabel(InvItems) Then
            MsgBox("There were errors in printing the requested labels", MsgBoxStyle.Critical, "Error - Printing request failed")
        Else
            MsgBox("Printing complete", MsgBoxStyle.Exclamation, "Success")
        End If

    End Sub

    Public Function printBarCodeLabel(ByVal InvItems As Array) As Boolean

        Dim wsProductionItems As New ProductionOrder.ProductionOrder()
        Dim response As New ProductionOrder.ResponseBE

        Dim x As Integer
        For x = 0 To InvItems.GetUpperBound(0)
            Try
                'print bar code label for inventory Item
                response = wsProductionItems.PrintLabelL1FromAOS(InvItems(x, 0))
                If response.StatusCode <> 1 Then
                    MsgBox(response.ErrorMsg, MsgBoxStyle.Critical, response.StatusCode.ToString)
                    Return False
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Return False
            End Try
        Next

        Return True

    End Function

End Module