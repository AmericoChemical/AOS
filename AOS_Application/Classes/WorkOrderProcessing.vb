Imports System.Text
Imports System.Web.UI.HtmlControls

Module WorkOrderProcessing

    Public Enum SourceType
        INV = 1
        RLBL = 2
        CONV = 3
        PORD = 4
        PRCH = 5
    End Enum

    Public Enum TransportType
        CUSTOMER_PICKUP
        DIRECT
        NONE
        OUTBOUND
        SALES_PICKUP
    End Enum

    Public Sub workOrderFulfillment(ByVal vWorkOrderNumber As Integer)
        Dim oUnallocatedItems As WorkorderitemCollection
        Dim oFulfillmentPlans As ProductfulfillmentplanCollection
        Dim oWorkOrder As Workorder

        ' Get Work Order Object
        oWorkOrder = getWorkOrder(vWorkOrderNumber)

        If oWorkOrder Is Nothing Then
            Exit Sub
        End If

        ' Filter WO Items where source type is NULL and sort on ItemID to group the similar items together
        oUnallocatedItems = getUnallocatedWorkOrderItems(oWorkOrder.Workordernumber)

        ' If source type is populated in all WO items then exit

        If oUnallocatedItems.Count <= 0 Then
            Exit Sub
        End If

        Using updateTransaction As New Transactions.TransactionScope
            Try
                ' Loop through unallocated items
                For iIndex As Integer = 0 To oUnallocatedItems.Count - 1

                    ' If current product id is same as previous one then skip that record assuming that record is already processed
                    If (iIndex = 0 OrElse oUnallocatedItems(iIndex - 1).Productid <> oUnallocatedItems(iIndex).Productid) Then

                        ' Get Product Fulfillment Plan
                        oFulfillmentPlans = getFulfillmentPlan(oUnallocatedItems(iIndex).Productid)

                        For Each fulfillmentPlan As Productfulfillmentplan In oFulfillmentPlans
                            Select Case fulfillmentPlan.Fulfillmenttypeid
                                Case 1
                                    ' Inventory Processing
                                    checkAndAssignInventory(AllocatedType.WORKORDER, _
                                                            oUnallocatedItems(iIndex).Workordernumber, _
                                                            oUnallocatedItems(iIndex).Productid)
                                Case 2
                                    ' Relabel
                                    processRelabelOrder(oWorkOrder.Workordernumber, _
                                                        oUnallocatedItems(iIndex).Productid)
                                Case 3
                                    ' Conversion - Coming Soon
                                Case 4
                                    ' Production Orders Processing
                                    processProductionOrder(oWorkOrder, _
                                                           oUnallocatedItems(iIndex).Productid)
                                Case 5
                                    ' Purchase Items Processing
                                    checkAndCreatePurchaseItemsAndFulfillWO(oWorkOrder.Workordernumber,
                                                                    oUnallocatedItems(iIndex).Productid, oUnallocatedItems(iIndex).Customerpo)
                            End Select
                        Next
                    End If
                Next
                updateTransaction.Complete()
            Catch ex As Exception
                updateTransaction.Dispose()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error - Allocate Inventory")
            End Try

        End Using
    End Sub

    Public Sub directWorkOrderFulfillment(ByVal vWorkOrderNumber As Integer)
        Dim oUnallocatedItems As WorkorderitemCollection

        ' Filter WO Items where source type is NULL and sort on ItemID to group the similar items together
        oUnallocatedItems = getUnallocatedWorkOrderItems(vWorkOrderNumber)

        ' If source type is populated in all WO items then exit
        If oUnallocatedItems.Count <= 0 Then
            Exit Sub
        End If

        ' Loop through unallocated items
        For iIndex As Integer = 0 To oUnallocatedItems.Count - 1

            ' If current product id is same as previous one then skip that record assuming that record is already processed
            If (iIndex = 0 OrElse _
                oUnallocatedItems(iIndex - 1).Productid <> oUnallocatedItems(iIndex).Productid OrElse _
                oUnallocatedItems(iIndex - 1).Customerpo <> oUnallocatedItems(iIndex).Customerpo) Then
                checkAndCreatePurchaseItemsAndFulfillWO(vWorkOrderNumber, oUnallocatedItems(iIndex).Productid, oUnallocatedItems(iIndex).Customerpo)
            End If
        Next
    End Sub

    Public Function getDateNeeded(oWorkOrder As Workorder)
        If oWorkOrder Is Nothing Then
            Return Nothing
        End If

        Select Case oWorkOrder.Transporttype
            Case TransportType.DIRECT.ToString()
                If (Not oWorkOrder.Deliverydate Is Nothing) Then
                    Return oWorkOrder.Deliverydate
                End If
                If (Not oWorkOrder.Plannedshipdate Is Nothing) Then
                    Return oWorkOrder.Plannedshipdate
                End If
            Case Else
                If (Not oWorkOrder.Plannedshipdate Is Nothing) Then
                    Return getPreviousWeekDay(Convert.ToDateTime(oWorkOrder.Plannedshipdate), 1)
                End If
                If (Not oWorkOrder.Deliverydate Is Nothing) Then
                    Return getPreviousWeekDay(Convert.ToDateTime(oWorkOrder.Deliverydate), 2)
                End If
        End Select

        Dim frm As New frmGetDataItem
        frm.vPrompt = "Select the date when these items are needed"
        frm.vInputType = "DATE"
        frm.ShowDialog()
        Return frm.vDate

    End Function

    Public Function getPreviousWeekDay(vDate As Date, vNoofDays As Integer) As Date
        Dim vActualDate As Date = vDate
        vDate = vDate.AddDays(-vNoofDays)
        While (vDate.DayOfWeek = DayOfWeek.Saturday Or vDate.DayOfWeek = DayOfWeek.Sunday Or (IIf((vNoofDays = 2 And vActualDate.DayOfWeek = DayOfWeek.Monday), vDate.DayOfWeek = DayOfWeek.Friday, Nothing)))
            vDate = vDate.AddDays(-1)
        End While

        Return vDate
    End Function

#Region "Raw Material Fulfillment Process"

    ''' <summary>
    ''' It go thorugh all Prod Items in Prod Order and check availability. 
    ''' If not enough material available, it converts Available / Pending Inventory to In Process
    ''' </summary>
    ''' <param name="vProdOrder"></param>
    ''' <remarks></remarks>
    Public Sub rawMaterialFulfillmentProcess(vProdOrder As Prodorder)
        Dim oProduct As New Product
        Dim vAVailable As Integer

        ' Getting all the ProdItems for Production Order Number
        Dim oProdItems As ProditemCollection = getProdItems(vProdOrder.Prodordernum)

        ' Going through each Material that is needed for ProdOrder to fulfill and checking if material is available 
        For Each oItem As Proditem In oProdItems
            Dim oRawMaterial As New ViewRawMaterialAvailability
            oRawMaterial.Query.Where(oRawMaterial.Query.Materialid.Equal(oItem.Materialid))
            oRawMaterial.Query.Load()

            vAVailable = oRawMaterial.Available

            ' If material is not available then converting available / pending inventory into in process
            If (vAVailable < 0) Then
                Dim oMaterialProducts As New MaterialproductCollection
                oMaterialProducts.Query.Where(oMaterialProducts.Query.Materialid.Equal(oItem.Materialid), _
                                              oMaterialProducts.Query.Priority.NotEqual(0)) _
                                        .OrderBy("PRIORITY", EntitySpaces.DynamicQuery.esOrderByDirection.Ascending)
                oMaterialProducts.Query.Load()

                For Each oMaterialItem As Materialproduct In oMaterialProducts

                    'get Product record for the MaterialProduct Entry
                    oProduct = New Product
                    If Not oProduct.LoadByPrimaryKey(oMaterialItem.Productid) Then
                        Exit For
                    End If

                    'get all possible inventory items that could be converted to Raw Material from current inventory
                    Dim oInvItems As New InvitemCollection
                    'oInvItems.Query.Where(oInvItems.Query.Productid.Equal(oMaterialItem.Productid),
                    '                      oInvItems.Query.Inventoryclass.Equal(InventoryClass.FULLAVAILABLE),
                    '                      oInvItems.Query.Itemstatus.Equal(InventoryItemStatus.AVAILABLE.ToString()))
                    oInvItems.Query.Where(oInvItems.Query.Productid.Equal(oMaterialItem.Productid),
                                          oInvItems.Query.Inventoryclass.Equal(InventoryClass.FULLAVAILABLE),
                                          oInvItems.Query.Itemstatus.In("AVAILABLE", "PENDING", "INPROD", "TESTING"),
                                          oInvItems.Query.Or(oInvItems.Query.Allocatedtype.IsNull, oInvItems.Query.Allocatedtype.Equal(String.Empty)),
                                          oInvItems.Query.Or(oInvItems.Query.Allocateddocument.IsNull, oInvItems.Query.Allocateddocument.Equal(String.Empty)))
                    oInvItems.Query.Load()
                    oInvItems.Sort = "itemstatus, invItemNumber"

                    'mark each inventory item as Raw Material until the amount of material needed has been met
                    For Each oInvItem As Invitem In oInvItems
                        If (vAVailable >= 0) Then
                            Exit For
                        End If

                        oInvItem.Inventoryclass = InventoryClass.INPROCESS
                        If (oInvItem.Itemstatus = "AVAILABLE" Or oInvItem.Itemstatus = "TESTING") Then
                            oInvItem.Itemstatus = "IN PROCESS"
                        End If

                        Select Case oProduct.Inventorymethod
                            Case ProductInventoryMethod.VOLUME.ToString()
                                oInvItem.Unitsremaining = oProduct.Volumeunits
                            Case ProductInventoryMethod.WEIGHT.ToString()
                                oInvItem.Unitsremaining = oProduct.Weightunits
                            Case Else
                                oInvItem.Unitsremaining = oProduct.Units
                        End Select

                        createInvPhys(oInvItem.Invitemnumber, _
                                      vProdOrder.Prodordernum, _
                                      oInvItem.Unitsremaining, _
                                      oInvItem.Unitsremaining, _
                                      "FACONV", _
                                      "SYSTEM CONVERSION", _
                                      "IN PROCESS", _
                                      "PRODORDER")

                        vAVailable = vAVailable + oInvItem.Unitsremaining
                    Next
                    oInvItems.Save()
                Next
            End If
        Next
    End Sub


#End Region

#Region "Helper Methods - Inventory"

#End Region

#Region "Helper Methods - Production Order"


    Public Function getWorkOrder(vWorkOrderNumber As Integer) As Workorder
        Dim oWorkOrders As New WorkorderCollection

        oWorkOrders.Query.Where(oWorkOrders.Query.Workordernumber.Equal(vWorkOrderNumber))
        oWorkOrders.Query.Load()

        Return oWorkOrders(0)
    End Function

#End Region


#Region "Misc. Methods"
    Private Function getFulfillmentPlan(vProductID As Integer) As ProductfulfillmentplanCollection
        Dim oProductFulfillmentPlans As New ProductfulfillmentplanCollection
        oProductFulfillmentPlans.Query.Where(oProductFulfillmentPlans.Query.Productid.Equal(vProductID))
        oProductFulfillmentPlans.Query.Load()

        If (oProductFulfillmentPlans.Count <= 0) Then
            oProductFulfillmentPlans = New ProductfulfillmentplanCollection
            oProductFulfillmentPlans.Query.Where(oProductFulfillmentPlans.Query.Productid.IsNull())
            oProductFulfillmentPlans.Query.Load()
        End If

        oProductFulfillmentPlans.Sort = "Priority Asc, Fulfillmentplanid Asc"

        Return oProductFulfillmentPlans
    End Function

    ''' <summary>
    ''' Returns work order items that need to be fulfilled. Resultset is sorted by Item ID ascending.
    ''' </summary>
    ''' <returns>vWorkOrderNumber</returns>
    ''' <remarks></remarks>
    Public Function getUnallocatedWorkOrderItems(vWorkOrderNumber As Integer) As WorkorderitemCollection
        Dim oWorkOrderItems As New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkOrderNumber),
                                    oWorkOrderItems.Query.Or(
                                        oWorkOrderItems.Query.Sourcetype.IsNull(),
                                        oWorkOrderItems.Query.Sourcetype.Equal(String.Empty)))
        oWorkOrderItems.Query.Load()
        oWorkOrderItems.Sort = "Itemid"

        Return oWorkOrderItems
    End Function

    ''' <summary>
    ''' Returns work order items that are already fulfilled. Resultset is sorted by Item ID ascending.
    ''' </summary>
    ''' <returns>vWorkOrderNumber</returns>
    ''' <remarks></remarks>
    Public Function getAllocatedWorkOrderItems(vWorkOrderNumber As Integer) As WorkorderitemCollection
        Dim oWorkOrderItems As New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkOrderNumber),
                                    oWorkOrderItems.Query.Sourcetype.IsNotNull)
        oWorkOrderItems.Query.Load()
        oWorkOrderItems.Sort = "Itemid"

        Return oWorkOrderItems
    End Function

    ''' <summary>
    ''' Returns work order items that need to be fulfilled. Resultset is sorted by Item ID ascending.
    ''' </summary>
    ''' <param name="vProductID"></param>
    ''' <returns>WorkorderitemCollection</returns>
    ''' <remarks></remarks>
    Public Function getUnallocatedWorkOrderItems(vWorkOrderNumber As Integer, vProductID As Integer) As WorkorderitemCollection
        Dim oWorkOrderItems As New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkOrderNumber), _
                                    oWorkOrderItems.Query.Sourcetype.IsNull(), _
                                    oWorkOrderItems.Query.Productid.Equal(vProductID))
        oWorkOrderItems.Query.Load()
        oWorkOrderItems.Sort = "Itemid"

        Return oWorkOrderItems
    End Function

    Public Function getUnallocatedWorkOrderItems(vWorkOrderNumber As Integer, vProductID As Integer, vCustomerPO As String) As WorkorderitemCollection
        Dim oWorkOrderItems As WorkorderitemCollection = getUnallocatedWorkOrderItems(vWorkOrderNumber, vProductID)
        If Not vCustomerPO Is Nothing AndAlso _
            String.IsNullOrEmpty(vCustomerPO) = False Then
            oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Customerpo.Equal(vCustomerPO))
            oWorkOrderItems.Query.Load()
        End If
        oWorkOrderItems.Sort = "Itemid"
        Return oWorkOrderItems
    End Function

    ''' <summary>
    ''' Returns sum of work order items qty that need to be fulfilled
    ''' </summary>
    ''' <param name="vWorkOrderNumber"></param>
    ''' <param name="vProductID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getUnallocatedWorkOrderItemsTotalQty(vWorkOrderNumber As Integer, vProductID As Integer, vCustomerPO As String) As Decimal
        Dim oWorkOrderItems As WorkorderitemCollection = getUnallocatedWorkOrderItems(vWorkOrderNumber, vProductID, vCustomerPO)
        Dim vTotalQty As Decimal = 0
        For Each oWOItems As Workorderitem In oWorkOrderItems
            vTotalQty += oWOItems.Qty
        Next
        Return vTotalQty

    End Function

    Public Function getFirstWorkOrderItem(vWorkOrderNumber As Integer, vProductID As Integer) As Workorderitem
        Dim oWorkOrderItems As WorkorderitemCollection = getUnallocatedWorkOrderItems(vWorkOrderNumber, vProductID)

        If (oWorkOrderItems.Count <= 0) Then
            Return New Workorderitem
        End If

        Return oWorkOrderItems(0)
    End Function

#End Region

#Region "Rollback / Unallocate Work Order Items"
    Public Sub unallocateWorkOrderItems(ByVal vWorkOrderNumber As Integer)

        ' Validate Work Order Items
        If (checkWOItemsUnallocateable(vWorkOrderNumber) = False) Then
            Exit Sub
        End If

        ' If no work order item then exit
        Dim oWOItems As WorkorderitemCollection = getWorkOrderItemsByWorkOrderNumber(vWorkOrderNumber)
        If (oWOItems Is Nothing OrElse _
            oWOItems.Count <= 0) Then
            Exit Sub
        End If

        ' Sort on Source Type Descending and Source Document Ascending to look at PRCH items first
        oWOItems.Sort = "Sourcetype DESC, Sourcedocument ASC"

        ' Loop through unallocated items
        For iIndex As Integer = 0 To oWOItems.Count - 1

            ' If current source doc is same as previous one then skip that record assuming that record is already processed
            If (iIndex = 0 OrElse (oWOItems(iIndex).Sourcedocument.HasValue _
                                   And oWOItems(iIndex - 1).Sourcedocument <> oWOItems(iIndex).Sourcedocument)) _
                           OrElse (oWOItems(iIndex).Invitemnumber.HasValue _
                                   And oWOItems(iIndex).Invitemnumber > 0) Then

                Select Case oWOItems(iIndex).Sourcetype
                    Case SourceType.PRCH.ToString()
                        ' update purchase item status to CANCELLED
                        If (Not oWOItems(iIndex).Sourcedocument Is Nothing) Then
                            updatePurchaseItemStatus(oWOItems(iIndex).Sourcedocument.Value, PurchaseItemsStatus.CANCELLED.ToString())
                        End If
                    Case SourceType.PORD.ToString()
                        ' update prod order and prod item status to COMPLETE
                        If (Not oWOItems(iIndex).Sourcedocument Is Nothing) Then
                            rollBackProductionOrder(oWOItems(iIndex).Sourcedocument)
                        End If
                    Case SourceType.INV.ToString()
                        unAllocateInventoryItem(oWOItems(iIndex).Invitemnumber)
                    Case SourceType.RLBL.ToString()
                        rollbackRelabelOrderItem(oWOItems(iIndex).Sourcedocument)
                End Select
            End If
        Next

        unallocateWorkOrderItems(oWOItems)
    End Sub

    Public Sub unallocateWorkOrder(vWorkorderNum As Integer)

        Dim vMsg As String = "Fulfillment Plan will be undone, and all inventory allocations / production orders / purchase items will be deleted/reversed"
        Dim oItems As WorkorderitemCollection = getAllocatedWorkOrderItems(vWorkorderNum)

        If (Not oItems Is Nothing And _
            oItems.Count > 0) Then
            MsgBox(vMsg, MsgBoxStyle.Information, "Warning")
            unallocateWorkOrderItems(vWorkorderNum)
        End If
    End Sub

    ''' <summary>
    ''' Unallocate 
    ''' </summary>
    ''' <param name="vWorkOrderItems"></param>
    ''' <remarks></remarks>
    Public Sub unallocateWorkOrderItems(vWorkOrderItems As WorkorderitemCollection)

        If (vWorkOrderItems Is Nothing OrElse _
            vWorkOrderItems.Count <= 0) Then
            Exit Sub
        End If

        ' Loop through unallocated items
        For Each oItem As Workorderitem In vWorkOrderItems
            updateWorkOrderItem(oItem.Workorderitemnumber, Nothing, Nothing)
        Next
        vWorkOrderItems.Save()
    End Sub

    ''' <summary>
    ''' Validate Work Order Items before starting the reversal process
    ''' </summary>
    ''' <param name="vWorkOrderNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function checkWOItemsUnallocateable(vWorkOrderNumber As Integer) As Boolean

        ' Get WO Items where source type is PORD, PRCH
        Dim oWorkOrderItems As WorkorderitemCollection = getUnallocateableWOItems(vWorkOrderNumber)

        ' If Work Orders are not associated to Purchase Orders, Purchase Requests then nothing to do
        ' Just exit out of this method.
        If oWorkOrderItems Is Nothing Or
            oWorkOrderItems.Count <= 0 Then
            Return True
        End If

        ' If Work Orders exist in PORD, PRCH status then validate them
        For Each oItem As Workorderitem In oWorkOrderItems
            If oItem Is Nothing Then
                Continue For
            End If

            Select Case oItem.Sourcetype
                Case SourceType.PRCH.ToString()
                    If (purchaseItemExists(oItem.Sourcedocument.Value, PurchaseItemsStatus.ORDERED.ToString())) Then
                        Dim vMsg As String = String.Format("Changes cannot be made to this work order because at least one purchase item (purchase item id: {0}) is on order", _
                                oItem.Sourcedocument.Value)
                        MsgBox(vMsg, MsgBoxStyle.Information)
                        Return False
                    End If
                Case SourceType.PORD.ToString()
                    If (validateProductionOrderToRollback(oItem.Sourcedocument.Value)) = False Then
                        Return False
                    End If
            End Select
        Next

        Return True
    End Function

    Private Function getUnallocateableWOItems(vWorkOrderNumber As Integer) As WorkorderitemCollection
        Dim oWorkOrderItems As New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkOrderNumber), _
                                    oWorkOrderItems.Query.Or(oWorkOrderItems.Query.Sourcetype.Equal(SourceType.PORD.ToString()), _
                                                             oWorkOrderItems.Query.Sourcetype.Equal(SourceType.PRCH.ToString())))
        oWorkOrderItems.Query.Load()

        Return oWorkOrderItems
    End Function

#End Region

    Public Function getWorkOrderItemsByWorkOrderNumber(vWorkOrderNumber As Integer) As WorkorderitemCollection
        Dim oWorkOrderItems As New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkOrderNumber))
        oWorkOrderItems.Query.Load()

        Return oWorkOrderItems
    End Function

    Public Function getWorkOrderItemsByWorkOrderNumberAndSourcetype(vWorkOrderNumber As Integer, vSourceType As String) As WorkorderitemCollection
        Dim oWorkOrderItems As New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkOrderNumber), _
                                    oWorkOrderItems.Query.Sourcetype.Equal(vSourceType))
        oWorkOrderItems.Query.Load()

        Return oWorkOrderItems
    End Function


    Public Function getWorkOrderItemsByPurchaseWorkOrderNumber(vWorkOrderNumber As Integer, vSourcetype As String, vSourcedocument As Integer) As WorkorderitemCollection
        Dim oWorkOrderItems As New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkOrderNumber), _
                                    oWorkOrderItems.Query.Sourcetype.Equal(vSourcetype), _
                                    oWorkOrderItems.Query.Sourcedocument.Equal(vSourcedocument))
        oWorkOrderItems.Query.Load()

        Return oWorkOrderItems
    End Function

    ''' <summary>
    ''' Returns collection of work order items given the purchase item id
    ''' </summary>
    ''' <param name="vPurchaseItemNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getWorkOrderItemsByPurchaseItemID(vPurchaseItemNumber As Integer, _
                                                      Optional vTotalQty As Integer = 0, _
                                                      Optional vSortBy As String = "") As WorkorderitemCollection
        Dim oWorkOrderItems As New WorkorderitemCollection
        If vTotalQty > 0 Then
            oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Sourcedocument.Equal(vPurchaseItemNumber), _
                                        oWorkOrderItems.Query.Sourcetype.In(SourceType.PRCH.ToString())).es.Top = vTotalQty
        Else
            oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Sourcedocument.Equal(vPurchaseItemNumber), _
                                        oWorkOrderItems.Query.Sourcetype.In(SourceType.PRCH.ToString()))
        End If
        oWorkOrderItems.Query.Load()
        If vSortBy <> "" Then
            oWorkOrderItems.Sort = vSortBy
        End If
        Return oWorkOrderItems
    End Function

    Public Function getWorkOrderItemsBySource(vSourceDocument As Integer, vSourcetype As String) As WorkorderitemCollection
        Dim oWorkOrderItems As New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Sourcedocument.Equal(vSourceDocument), _
                                    oWorkOrderItems.Query.Sourcetype.Equal(vSourcetype))
        oWorkOrderItems.Query.Load()

        Return oWorkOrderItems
    End Function

    Public Function getWorkOrderItemByWONumberAndInvItemNumber(vWorkOrderNumber As Integer, vInvItemNumber As Integer) As Workorderitem
        Dim oWorkOrderItems As New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkOrderNumber), _
                                    oWorkOrderItems.Query.Invitemnumber.Equal(vInvItemNumber))
        oWorkOrderItems.Query.Load()

        If (oWorkOrderItems.Count > 0) Then
            Return oWorkOrderItems(0)
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Updates Work Order Item based on given values
    ''' </summary>
    ''' <param name="vWorkOrderItemNumber"></param>
    ''' <param name="vSourceDoc"></param>
    ''' <param name="vSourceType"></param>
    ''' <param name="vInvItemNumber"></param>
    ''' <param name="vLotNumber"></param>
    ''' <param name="vWareHouseLocation"></param>
    ''' <param name="vUnitCost"></param>
    ''' <remarks></remarks>
    Public Sub updateWorkOrderItem(vWorkOrderItemNumber As Integer, vSourceDoc As Integer?, vSourceType As String, Optional vInvItemNumber As Integer? = Nothing,
                                   Optional vLotNumber As String = Nothing, Optional vWareHouseLocation As String = Nothing, Optional vUnitCost As Decimal? = 0.0)
        Dim oWorkOrderItem As New Workorderitem
        oWorkOrderItem.LoadByPrimaryKey(vWorkOrderItemNumber)

        oWorkOrderItem.Sourcetype = vSourceType
        oWorkOrderItem.Sourcedocument = vSourceDoc
        oWorkOrderItem.Invitemnumber = vInvItemNumber
        oWorkOrderItem.Lotnumber = vLotNumber
        oWorkOrderItem.Warehouselocation = vWareHouseLocation

        If Not IsDBNull(vUnitCost) And vUnitCost > 0 Then
            oWorkOrderItem.Unitcost = vUnitCost
            oWorkOrderItem.Itemprofit = oWorkOrderItem.Itemprice - oWorkOrderItem.Unitcost
        End If

        oWorkOrderItem.Save()
    End Sub

    Public Sub updateWorkOrderLotNoAndWHLocation(vInvitemNumber As Integer, vLotNumber As String)

        Dim oWorkOrderItem As New Workorderitem
        oWorkOrderItem = getWorkOrderItemByInvitemNumber(vInvitemNumber)

        If oWorkOrderItem Is Nothing OrElse oWorkOrderItem.Workordernumber Is Nothing Then
            Exit Sub
        End If

        oWorkOrderItem.Lotnumber = vLotNumber
        oWorkOrderItem.Warehouselocation = "DOCK"
        oWorkOrderItem.EndEdit()
        oWorkOrderItem.Save()
    End Sub
    Public Function getWorkOrderItemByInvitemNumber(vInvitemNumber As Integer)
        Dim oWorkOrderItem As New Workorderitem
        oWorkOrderItem.Query.Where(oWorkOrderItem.Query.Invitemnumber.Equal(vInvitemNumber))
        oWorkOrderItem.Query.Load()
        Return oWorkOrderItem
    End Function
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="vOrderType"></param>
    ''' <param name="vTransportType"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function validateWorkOrder(vOrderType, vTransportType) As Boolean

        ' Don't allow fulfilment plan if order type is Consignment Usage, regardless of the transport type.
        ' Allow Fulfillment Plan only when Order Type is either Standard or Consignment Transfer and Transport type is not None
        Return (vOrderType.Equals("CONSIGNMENT USAGE") _
                    OrElse ((vOrderType.Equals("STANDARD") _
                                Or vOrderType.Equals("CONSIGNMENT TRANSFER") _
                            ) _
                            And (vTransportType.Equals(TransportType.DIRECT.ToString()) _
                                    Or vTransportType.Equals(TransportType.NONE.ToString())
                                ) _
                        ) _
                )
    End Function

    Public Function getCustomer() As CustomerCollection
        Dim oCustomerList As New CustomerCollection
        oCustomerList.LoadAll()
        oCustomerList.Sort = "CustName"
        Return oCustomerList
    End Function
    Public Function getVendor() As VendorCollection
        Dim oVendorList As New VendorCollection
        oVendorList.LoadAll()
        oVendorList.Sort = "VENDORNAME"
        Return oVendorList
    End Function

    Public Function getVendorByVendorID(vVendorID As Integer) As Vendor
        Dim oVendor As New Vendor
        oVendor.Query.Where(oVendor.Query.Vendorid.Equal(vVendorID))
        oVendor.Query.Load()
        Return oVendor
    End Function

    Public Function getItemtype() As ListItemtypeCollection
        Dim oItemTypes As New ListItemtypeCollection
        oItemTypes.LoadAll()
        oItemTypes.Sort = "RecID"
        Return oItemTypes
    End Function

    Public Function getViewWorkOrderItems(ByVal vID As Integer) As ViewWorkOrderItemsScreenCollection
        Dim oWorkOrderItems As New ViewWorkOrderItemsScreenCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vID))
        oWorkOrderItems.Query.Load()
        oWorkOrderItems.Sort = "WorkOrderItemNumber"
        Return oWorkOrderItems
    End Function

    Public Function getWorkOrderFulfillmentPlanReportView(ByVal vID As Integer) As ViewRptWorkOrderFulfillmentPlanCollection
        Dim oRptWorkOrder As New ViewRptWorkOrderFulfillmentPlanCollection
        oRptWorkOrder.Query.Where(oRptWorkOrder.Query.Workordernumber.Equal(vID))
        oRptWorkOrder.Query.Load()
        Return oRptWorkOrder
    End Function

    Public Function getWorkOrderItemFulfillmentPlanReportView(ByVal vID As Integer) As ViewRptWorkOrderItemFulfillmentPlanCollection
        Dim oRptWorkOrderItem As New ViewRptWorkOrderItemFulfillmentPlanCollection
        oRptWorkOrderItem.Query.Where(oRptWorkOrderItem.Query.Workordernumber.Equal(vID))
        oRptWorkOrderItem.Query.Load()
        Return oRptWorkOrderItem
    End Function

    Public Function getWorkOrderItemsByPurchaseItemNum(ByVal PurchaseItemNum As Integer) As WorkorderitemCollection
        Dim oWorkOrderItemsCollection As New WorkorderitemCollection
        oWorkOrderItemsCollection.Query.Where(oWorkOrderItemsCollection.Query.Sourcedocument.Equal(PurchaseItemNum))
        oWorkOrderItemsCollection.Query.Load()
        Return oWorkOrderItemsCollection
    End Function

    ''' <summary>
    ''' 'Collect All the rows of FulfillmentPlan,Production Order, Purchase Items.
    ''' </summary>
    ''' <param name="vWorkorderNum"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function workOrderPlanSummary(vWorkorderNum As Integer) As HtmlTable

        Dim oCustomer As New Customer
        Dim oWOEmailPlan As New ViewWOEmailPlanCollection
        Dim oWorkOrder As New Workorder

        If oWorkOrder.LoadByPrimaryKey(vWorkorderNum) = False Then
            Return Nothing
        End If

        If oCustomer.LoadByPrimaryKey(oWorkOrder.Custid) = False Then
            Return Nothing
        End If

        Dim vHeaderDetails As String
        Dim vWorkOrderPlanSummary As New HtmlTable
        Dim vItemID As Integer = 0
        Dim vItemDesc As String = ""


        Dim vTransType As String = ""
        If oWorkOrder.Transporttype = "DIRECT" Then
            vTransType = "- DIRECT"
        End If
        Dim vSooner As String = ""
        If oWorkOrder.Orsoonerflag = True Then
            vSooner = " or sooner "
        Else
            vSooner = ""
        End If

        Dim vFP As String = ""
        If oWorkOrder.Freezeprotectflag = True Then
            vFP = " - FreezeProtect"
        Else
            vFP = ""
        End If

        Dim vCarrier As String = ""
        Select Case oWorkOrder.Fob
            Case "COLLECT"
                vCarrier = "Theirs"
            Case "BILL 3RD PARTY"
                If oWorkOrder.Logisticsid = 1 Then
                    vCarrier = "Ours"
                Else
                    vCarrier = "Theirs"
                End If
            Case Else
                vCarrier = ""
        End Select

        vHeaderDetails = $"{oCustomer.Custname} - {oWorkOrder.Shipcity}, {oWorkOrder.Shipstateprov} <br/><br/>" &
            $" SHIP: {formatDate(oWorkOrder.Plannedshipdate)}<br/>" &
            $" DELV: {formatDate(oWorkOrder.Deliverydate) + vSooner + vFP} {vTransType}<br/>" &
            $" CARRIER: {vCarrier}"

        vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(vHeaderDetails, _
                                                          , _
                                                          CellStyle.ItemHeading))

        vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues("", _
                                                          , _
                                                          CellStyle.ItemHeading))


        oWOEmailPlan = getWOEmailPlan(vWorkorderNum)
        For Each oItem As ViewWOEmailPlan In oWOEmailPlan

            If vItemID <> oItem.Itemid Then
                vItemID = oItem.Itemid
                vItemDesc = oItem.Itemdescription

                Dim oProduct As New Product
                If oProduct.LoadByPrimaryKey(vItemID) Then
                    If oProduct.Desc2 <> "" Then
                        If oProduct.Desc2.Substring(0, 3) = "ask" Or oProduct.Desc2.Substring(0, 3) = "Ask" Then
                            vItemDesc = vItemDesc & " [" & oProduct.Desc2 & "]"
                        End If
                    End If
                End If

                vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0:F2} - {1} - {2}" _
                                                                                , oItem.Totalproductqty _
                                                                                , oItem.Container _
                                                                                , vItemDesc),
                                                                            "",
                                                                            CellStyle.Heading))
            End If


            If oItem.Sourcetype Is Nothing = False AndAlso String.IsNullOrEmpty(oItem.Sourcetype) = False Then
                Select Case oItem.Sourcetype
                    Case SourceType.INV.ToString()

                        'retrieve counts of inventory items and their current status
                        Dim oCS As New ViewInvItemsCurrentStatusCollection
                        oCS.Query.Where(oCS.Query.Productid.Equal(oItem.Itemid))
                        oCS.Query.Load()

                        Dim vInvStatusLine As String = "(" + oCS(0).QAvail.ToString + " A"

                        If Not (oCS(0).QPending = 0 And oCS(0).QInProd = 0 And oCS(0).QTesting = 0 And oCS(0).QHold = 0) Then
                            If oCS(0).QTesting > 0 Then
                                vInvStatusLine = vInvStatusLine + " | " + oCS(0).QTesting.ToString + " T"
                            End If
                            If oCS(0).QInProd > 0 Then
                                vInvStatusLine = vInvStatusLine + " | " + oCS(0).QInProd.ToString + " MU"
                            End If
                            If oCS(0).QPending > 0 Then
                                vInvStatusLine = vInvStatusLine + " | " + oCS(0).QPending.ToString + " ORD"
                            End If
                            If oCS(0).QHold > 0 Then
                                vInvStatusLine = vInvStatusLine + " | " + oCS(0).QHold.ToString + " HOLD"
                            End If


                        End If
                        vInvStatusLine = vInvStatusLine + ")"

                        vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0:F2} - {1} {2}",
                                                                                        oItem.Totalfulfillmentqty,
                                                                                        oItem.Sourcetype,
                                                                                        vInvStatusLine)))

                        'if there are any items on order, print line showing when items will arrive (expected in date)
                        Dim vPad2 As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                        If oCS(0).QPending > 0 Then
                            Dim oPI As New ViewInvItemsCurrentOnOrderCollection
                            oPI.Query.Where(oPI.Query.Productid.Equal(oItem.Itemid))
                            If oPI.Query.Load Then
                                For Each oRow As ViewInvItemsCurrentOnOrder In oPI
                                    vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0} {1} - {2:d}",
                                                                                       vPad2,
                                                                                       oRow.Qty.ToString,
                                                                                       oRow.Expectedindate)))
                                Next
                            End If
                        End If

                        'vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0:F2} - {1} ({2})",
                        '                                                                oItemList.Totalfulfillmentqty,
                        '                                                                oItemList.Sourcetype,
                        '                                                                getAvailableInventory(oItemList.Itemid).Count())))

                    'this section expanded to include additional information requested by Jon DeFlorio

                    Case SourceType.PORD.ToString()
                        'determine is this is a MAKEUP or a CONVERSION
                        Dim vType As String = ""
                        Dim oItems As New ProditemCollection
                        oItems.Query.Where(oItems.Query.Prodordernum.Equal(oItem.Sourcedocument))
                        If oItems.Query.Load Then
                            If oItems.Count > 1 Then
                                vType = "MAKE UP"
                            Else
                                vType = "CONV"
                            End If
                        End If

                        vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0:F2} - {1}",
                                                                                        oItem.Totalfulfillmentqty,
                                                                                        vType)))

                        'now add a line for each material needed in the production order
                        Dim vPad As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                        Dim oMaterial As New ViewProdItemDataWOEmailCollection
                        oMaterial.Query.Where(oMaterial.Query.Prodordernum.Equal(oItem.Sourcedocument), oMaterial.Query.Materialid.NotIn(127, 129, 200))
                        If oMaterial.Query.Load Then
                            For Each oRec As ViewProdItemDataWOEmail In oMaterial

                                'Display negative available values in red
                                Dim formattedAvailable = $"{oRec.Available:F2}"
                                vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(
                                    $"{vPad} {oRec.Qty.ToString.PadLeft(6, " "):F2} - {oRec.Uom} - {oRec.Materialdesc}  -  " &
                                    $"({If(oRec.Available < 0, Email.OutputHtmlColorText(formattedAvailable, "red"), formattedAvailable)})"))


                                'For each Raw Material that is IN PRODUCTION, add the DATENEEDED value from the Production Order
                                Dim oRMProd As New ViewRawMaterialInProductionCollection
                                oRMProd.Query.Where(oRMProd.Query.Materialid.Equal(oRec.Materialid))
                                If oRMProd.Query.Load Then
                                    'add line to show available date for the raw material included in the RawMaterial Available/Inventory Amount
                                    Dim vAvailDate As DateTime
                                    Dim vAvailDateString As String
                                    For Each oRMProdRec As ViewRawMaterialInProduction In oRMProd
                                        vAvailDate = oRMProdRec.AvailDate
                                        vAvailDateString = vAvailDate.ToShortDateString

                                        vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0} {1:F2} - {2} - {3}",
                                                                                                                vPad + vPad + "IN PROD",
                                                                                                                oRMProdRec.Qty,
                                                                                                                oRMProdRec.Productdesc,
                                                                                                                vAvailDateString)))
                                    Next
                                End If

                                'For each Raw Material that is ON ORDER (PENDING), add the EXPECTED IN DATE from the Purchase Order
                                Dim oMatPrch As New ViewAllMaterialOnOrderCollection
                                oMatPrch.Query.Where(oMatPrch.Query.Materialid.Equal(oRec.Materialid))
                                If oMatPrch.Query.Load Then
                                    'add line to show available date for the raw material included in the RawMaterial Available/Inventory Amount
                                    Dim vAvailDate As DateTime
                                    Dim vAvailDateString As String
                                    For Each oRMPrchRec As ViewAllMaterialOnOrder In oMatPrch
                                        vAvailDate = oRMPrchRec.AvailDate
                                        vAvailDateString = vAvailDate.ToShortDateString
                                        vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0} {1:F2} - {2} - {3}",
                                                                                                                vPad + vPad + "PENDING",
                                                                                                                oRMPrchRec.Qty,
                                                                                                                oRMPrchRec.Productdesc,
                                                                                                                vAvailDateString)))
                                    Next
                                End If


                                'now add line(s) for AVAILABLE 
                                Dim vAvailableProductsLine As String = ""
                                Dim vMatAvail As New ViewMaterialAvailableContainersCollection
                                vMatAvail.Query.Where(vMatAvail.Query.Materialid.Equal(oRec.Materialid))
                                If vMatAvail.Query.Load Then
                                    For Each oFG As ViewMaterialAvailableContainers In vMatAvail
                                        If Not (oFG.Qavail = 0 And oFG.Qprod = 0 And oFG.Qtest = 0 And oFG.Qhold = 0) Then
                                            vAvailableProductsLine = oFG.Productdesc + " (" + oFG.Container.Substring(0, 1) + ")"
                                            If oFG.Qavail > 0 Then
                                                vAvailableProductsLine = vAvailableProductsLine + " | " + oFG.Qavail.ToString + " AVAIL"
                                            End If
                                            'If oFG.Qpend > 0 Then
                                            '    vAvailableProductsLine = vAvailableProductsLine + " | " + oFG.Qpend.ToString + " PENDING"
                                            'End If
                                            If oFG.Qprod > 0 Then
                                                vAvailableProductsLine = vAvailableProductsLine + " | " + oFG.Qprod.ToString + " IN PROD"
                                            End If
                                            If oFG.Qtest > 0 Then
                                                vAvailableProductsLine = vAvailableProductsLine + " | " + oFG.Qtest.ToString + " TESTING"
                                            End If
                                            If oFG.Qhold > 0 Then
                                                vAvailableProductsLine = vAvailableProductsLine + " | " + oFG.Qhold.ToString + " HOLD"
                                            End If
                                            vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0} {1}",
                                                                                     vPad + vPad, vAvailableProductsLine)))
                                        End If




                                    Next
                                End If
                            Next
                        End If

                        'check to see if there is also a PRCH option for fulfillment for this product
                        Dim oFulfillmentPlan As New ProductfulfillmentplanCollection
                        oFulfillmentPlan.Query.Where(oFulfillmentPlan.Query.Productid.Equal(oItem.Itemid), oFulfillmentPlan.Query.Fulfillmenttypeid.Equal(5))
                        Try
                            If oFulfillmentPlan.Query.Load() Then
                                vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0}",
                                                                                        "OR PURCHASE")))
                            End If
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try




                    Case SourceType.PRCH.ToString()
                        Dim vPad3 As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                        vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0:F2} - {1}",
                                                                                        oItem.Totalfulfillmentqty,
                                                                                        oItem.Sourcetype)))

                        'Determine if there are any of these items currently in RECEIVED HOLD status
                        'retrieve counts of inventory items and their current status
                        Dim oCS As New ViewInvItemsCurrentStatusCollection
                        oCS.Query.Where(oCS.Query.Productid.Equal(oItem.Itemid))
                        oCS.Query.Load()
                        If oCS(0).QHold > 0 Then
                            Dim vInvStatusLine As String = "( " + oCS(0).QHold.ToString + " HOLD )"
                            vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0}",
                                                                                        vInvStatusLine)))
                        End If

                        'Get Vendor Names from ProductCost records for Product ID (oItemList.ItemID)
                        Dim oCostRecs As New ViewProductCostInfoCollection
                        oCostRecs.Query.Where(oCostRecs.Query.Productid.Equal(oItem.Itemid))
                        If oCostRecs.Query.Load Then
                            For Each oCR As ViewProductCostInfo In oCostRecs
                                vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0} {1}", vPad3 + vPad3, oCR.Vendorname)))
                            Next
                        End If


                    Case SourceType.RLBL.ToString()
                        Dim vPad4 As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                        vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0:F2} - {1} - {2} - {3:F2} - {4} - {5}",
                                                                             oItem.Rlblqty,
                                                                             oItem.Sourcetype,
                                                                             oItem.Rlblsourcertype,
                                                                             oItem.Rlblqty,
                                                                             oItem.Rlblcontainer,
                                                                             oItem.Rlblproductdesc)))
                        'get inventory stats for the item being relabeled to meet this need
                        Dim oFGRList As New ViewWOEmailRelabelInventoryCollection
                        oFGRList.Query.Where(oFGRList.Query.Workordernumber.Equal(oItem.Workordernumber), oFGRList.Query.Rlblproductid.Equal(oItem.Rlblproductid))
                        Try
                            If oFGRList.Query.Load() Then
                                Dim oFGR As New ViewWOEmailRelabelInventory
                                oFGR = oFGRList(0)

                                If Not (oFGR.Qavail = 0 And oFGR.Qpend = 0 And oFGR.Qtest = 0) Then
                                    Dim vPad As String = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"
                                    Dim vAvailableProductsLine As String = ""
                                    vAvailableProductsLine = oItem.Rlblproductdesc + " (" + oItem.Rlblcontainer.Substring(0, 1) + ")"
                                    If oFGR.Qavail > 0 Then
                                        vAvailableProductsLine = vAvailableProductsLine + " | " + oFGR.Qavail.ToString + " AVAIL"
                                    End If
                                    If oFGR.Qtest > 0 Then
                                        vAvailableProductsLine = vAvailableProductsLine + " | " + oFGR.Qtest.ToString + " TESTING"
                                    End If
                                    If oFGR.Qpend > 0 Then
                                        'get Pending Item expected in date
                                        Dim oRPS As New ViewWOEmailRelabelPendingItemsCollection
                                        Dim oRP As New ViewWOEmailRelabelPendingItems
                                        oRPS.Query.Where(oRPS.Query.Workordernumber.Equal(oFGR.Workordernumber), oRPS.Query.Rlblproductid.Equal(oFGR.Rlblproductid))
                                        If oRPS.Query.Load Then
                                            oRP = oRPS(0)
                                            vAvailableProductsLine = vAvailableProductsLine + " | " + oFGR.Qpend.ToString + " PENDING | " + oRP.Expectedindate.ToString
                                        Else
                                            vAvailableProductsLine = vAvailableProductsLine + " | " + oFGR.Qpend.ToString + " PENDING"
                                        End If
                                    End If

                                    vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0} {1}",
                                                                             vPad + vPad, vAvailableProductsLine)))




                                End If

                                '12/04/2017 Shaun McGuire
                                'added this code to show Vendor Names IF the item to be relabeled has to be purchased
                                If oItem.Rlblsourcertype = "PRCH" Then
                                    'Get Vendor Names from ProductCost records for Product ID (oFGR.Rlblproductid)
                                    Dim oCostRecs As New ViewProductCostInfoCollection
                                    oCostRecs.Query.Where(oCostRecs.Query.Productid.Equal(oFGR.Rlblproductid))
                                    If oCostRecs.Query.Load Then
                                        For Each oCR As ViewProductCostInfo In oCostRecs
                                            vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0} {1}", vPad4 + vPad4, oCR.Vendorname)))
                                        Next
                                    End If
                                End If


                                'removed this code and replace with code directly above
                                '12/04/2017 Shaun McGuire
                                'If oFGR.Qpend = 0 Then
                                '    'Get Vendor Names from ProductCost records for Product ID (oFGR.Rlblproductid)
                                '    Dim oCostRecs As New ViewProductCostInfoCollection
                                '    oCostRecs.Query.Where(oCostRecs.Query.Productid.Equal(oFGR.Rlblproductid))
                                '    If oCostRecs.Query.Load Then
                                '        For Each oCR As ViewProductCostInfo In oCostRecs
                                '            vWorkOrderPlanSummary.Rows.Add(setHtmlCellsValues(String.Format("{0} {1}", vPad4 + vPad4, oCR.Vendorname)))
                                '        Next
                                '    End If
                                'End If


                            End If

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try

                End Select
            End If
        Next

        Return vWorkOrderPlanSummary
    End Function

    ''' <summary>
    ''' get Work Order Email plan
    ''' </summary>
    ''' <param name="vWONumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getWOEmailPlan(ByVal vWONumber As Integer) As ViewWOEmailPlanCollection
        Dim oWOEmailPlan As New ViewWOEmailPlanCollection
        oWOEmailPlan.Query.Where(oWOEmailPlan.Query.Workordernumber.Equal(vWONumber))
        oWOEmailPlan.Query.Load()
        oWOEmailPlan.Sort = "ITEMID ASC, FULFILLMENTTYPEID ASC"
        Return oWOEmailPlan
    End Function

    Enum CellStyle
        Heading
        ItemHeading
        Item
        ItemNegative
    End Enum

    ''' <summary>
    ''' Set each html cells value.
    ''' </summary>
    ''' <param name="vTitle"></param>
    ''' <param name="vValue"></param>
    ''' <param name="vStyle"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function setHtmlCellsValues(vTitle As String, Optional vValue As String = "", Optional vStyle As CellStyle = CellStyle.Item)
        Dim vHtmlRows As New HtmlTableRow
        Dim vCaptionCell As New HtmlTableCell

        vCaptionCell.InnerHtml = vTitle
        vHtmlRows.Cells.Add(vCaptionCell)

        If vValue <> "" Then
            Dim vValueCell As New HtmlTableCell
            vValueCell.InnerHtml = vValue
            vHtmlRows.Cells.Add(vValueCell)
        End If

        Select Case (vStyle)
            Case CellStyle.Heading
                vCaptionCell.ColSpan = 2
                vCaptionCell.Attributes.Add("Style", "font-family: Arial, Helvetica, sans-serif; font-weight:bold; font-size:8pt")
            Case CellStyle.ItemHeading
                vCaptionCell.ColSpan = 2
                vCaptionCell.Attributes.Add("Style", "font-weight:bold; font-size:8pt")
            Case CellStyle.Item
                vCaptionCell.Attributes.Add("Style", "font-size:6pt; text-indent:40px")
            Case CellStyle.ItemNegative
                vCaptionCell.Attributes.Add("Style", "font-size:6pt; text-indent:40px")
        End Select

        'Styling the HTML table
        vHtmlRows.Style.Add("vertical-align", "top")

        Return vHtmlRows
    End Function

    Public Function addWorkOrderItem(oWorkOtemItem As Workorderitem, vQty As Integer, Optional vSourceDocument As Integer? = 0) As Workorderitem
        Dim oItem As New Workorderitem
        oItem.AddNew()
        oItem.Workorderitemnumber = oWorkOtemItem.Workorderitemnumber
        oItem.Workordernumber = oWorkOtemItem.Workordernumber
        oItem.Itemtype = oWorkOtemItem.Itemtype
        oItem.Itemid = oWorkOtemItem.Itemid
        oItem.Itemdescription = oWorkOtemItem.Itemdescription
        oItem.Productid = oWorkOtemItem.Productid
        oItem.Productdesc = oWorkOtemItem.Productdesc
        oItem.Container = oWorkOtemItem.Container
        oItem.Qty = vQty
        oItem.Invitemnumber = oWorkOtemItem.Invitemnumber
        oItem.Itemcomments = oWorkOtemItem.Itemcomments
        oItem.Lotnumber = oWorkOtemItem.Lotnumber
        oItem.Warehouselocation = oWorkOtemItem.Warehouselocation
        oItem.Billable = oWorkOtemItem.Billable
        oItem.Unitcost = oWorkOtemItem.Unitcost
        oItem.Itemprice = oWorkOtemItem.Itemprice
        oItem.Itemprofit = oWorkOtemItem.Itemprofit
        oItem.Unitorcontainer = oWorkOtemItem.Unitorcontainer
        oItem.Units = oWorkOtemItem.Units
        oItem.Uom = oWorkOtemItem.Uom
        oItem.Extprice = oWorkOtemItem.Extprice
        oItem.Extcost = oWorkOtemItem.Extcost
        oItem.Extprofit = oWorkOtemItem.Extprofit
        oItem.Sourcetype = oWorkOtemItem.Sourcetype
        oItem.Sourcedocument = vSourceDocument
        oItem.Workorderitemstatus = oWorkOtemItem.Workorderitemstatus
        oItem.Customerpo = oWorkOtemItem.Customerpo
        oItem.Shipmentitemnumber = oWorkOtemItem.Shipmentitemnumber
        oItem.Invoiceitemnumber = oWorkOtemItem.Invoiceitemnumber
        oItem.Totalvolume = oWorkOtemItem.Totalvolume
        oItem.Volumeuom = oWorkOtemItem.Volumeuom
        oItem.Totalweight = oWorkOtemItem.Totalweight
        oItem.Weightuom = oWorkOtemItem.Weightuom
        oItem.DOTIDNumber = oWorkOtemItem.DOTIDNumber
        oItem.Hazmatid = oWorkOtemItem.Hazmatid
        oItem.Hazmatclass = oWorkOtemItem.Hazmatclass
        oItem.Hazmatpackagegroup = oWorkOtemItem.Hazmatpackagegroup
        oItem.Classrate = oWorkOtemItem.Classrate
        oItem.Dotdesc = oWorkOtemItem.Dotdesc
        oItem.Hazmatdesc = oWorkOtemItem.Hazmatdesc
        oItem.Unline = oWorkOtemItem.Unline
        oItem.Ishazardous = oWorkOtemItem.Ishazardous
        oItem.Itemnotes = oWorkOtemItem.Itemnotes
        oItem.Createdby = vCurrentUserLogin
        oItem.Createdtime = Now
        oItem.Ld1 = oWorkOtemItem.Ld1
        oItem.Ld2 = oWorkOtemItem.Ld2
        oItem.Ld3 = oWorkOtemItem.Ld3
        oItem.Custitemid = oWorkOtemItem.Custitemid
        oItem.Priceunits = oWorkOtemItem.Priceunits
        oItem.Priceuom = oWorkOtemItem.Priceuom
        oItem.Unitprice = oWorkOtemItem.Unitprice
        oItem.Standardcostunits = oWorkOtemItem.Standardcostunits
        oItem.Standardcostuom = oWorkOtemItem.Standardcostuom
        oItem.Standardunitcost = oWorkOtemItem.Standardunitcost
        oItem.Actualcostunits = oWorkOtemItem.Actualcostunits
        oItem.Actualcostuom = oWorkOtemItem.Actualcostuom
        oItem.Actualunitcost = oWorkOtemItem.Actualunitcost

        oItem.EndEdit()
        oItem.Save()
        Return oItem
    End Function

    ''' <summary>
    ''' To get all the allocated item which are fulfilled by purchase or production
    ''' </summary>
    ''' <param name="vWorkOrderNumber"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getWorkOrderAllocatedItems(vWorkOrderNumber As Integer, Optional vSourceType As String = "") As ViewWorkOrderAllocatedItemCollection
        Dim oWorkOrderItems As New ViewWorkOrderAllocatedItemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkOrderNumber))
        If String.IsNullOrEmpty(vSourceType) = False Then
            oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Sourcetype.Equal(vSourceType))
        End If
        oWorkOrderItems.Query.Load()

        If (oWorkOrderItems.Count > 0) Then
            Return oWorkOrderItems
        End If
        Return Nothing
    End Function

    Public Function updateSourceDocDateNeeded(oViewWorkOrderAllocatedItems As ViewWorkOrderAllocatedItemCollection _
                                               , vDateNeeded As DateTime?) As Boolean
        If (vDateNeeded Is Nothing OrElse
            IsDBNull(vDateNeeded) = True) Then
            Return False
        End If
        If (oViewWorkOrderAllocatedItems Is Nothing OrElse
            oViewWorkOrderAllocatedItems.Count <= 0) Then
            Return False
        End If
        For Each oItem As ViewWorkOrderAllocatedItem In oViewWorkOrderAllocatedItems
            Select Case oItem.Sourcetype
                Case SourceType.RLBL.ToString()
                    If updateRelabelNeededBy(oItem.Sourcedocument, vDateNeeded) = False Then
                        Return False
                    End If
                Case SourceType.PORD.ToString()
                    If updateProductionOrderNeededBy(oItem.Sourcedocument, vDateNeeded) = False Then
                        Return False
                    End If
                Case SourceType.PRCH.ToString()
                    If updatePurchaseItemDateNeeded(oItem.Sourcedocument, vDateNeeded) = False Then
                        Return False
                    End If
            End Select
        Next
        Return True
    End Function

    Public Function updateSourceDocDateNeeded(vWorkOrderNumber As Integer, vDateNeeded As DateTime?) As Boolean
        If (vWorkOrderNumber <= 0) Then
            MessageBox.Show("Work order number is not valid")
            Return False
        End If
        If (vDateNeeded Is Nothing OrElse
            IsDBNull(vDateNeeded) = True) Then
            Return False
        End If
        Dim oWorkOrderItems As ViewWorkOrderAllocatedItemCollection = getWorkOrderAllocatedItems(vWorkOrderNumber)
        Return updateSourceDocDateNeeded(oWorkOrderItems, vDateNeeded)
    End Function

    Public Function validateShipDateChange(vPlannedShipDate As DateTime?, vDeliveryDate As DateTime?)
        If (vPlannedShipDate Is Nothing OrElse
            IsDBNull(vPlannedShipDate) = True) Then
            Return False
        End If

        Dim vShip As Date = (CDate(vPlannedShipDate)).Date
        Dim vNow As Date = Now.Date
        If (vShip < vNow) Then
            MessageBox.Show("Planned Ship Date cannot be set in the past")
            Return False
        End If
        'If delivery date is null we no need to compare with ship date
        If (vDeliveryDate Is Nothing OrElse
            IsDBNull(vDeliveryDate) = True) Then
            Return True
        End If
        If vDeliveryDate < vPlannedShipDate Then
            MessageBox.Show("Delivery Date cannot be prior to Planned Shipped Date")
            Return False
        End If
        Return True
    End Function

    Public Sub deleteWorkOrderItem(vWorkOrderItemId As Integer, vWorkOrderStatus As String)
        'Validate inputs
        If vWorkOrderItemId <= 0 Then
            Exit Sub
        End If

        'Retrieve WorkOrderItem Record
        Dim oWorkOrderItem As New Workorderitem
        If (oWorkOrderItem.LoadByPrimaryKey(vWorkOrderItemId) = False) Then
            Exit Sub
        End If

        'Unallocate InventoryItem if assigned to this WorkOrderItem
        If (Not oWorkOrderItem.Invitemnumber Is Nothing AndAlso
            IsDBNull(oWorkOrderItem.Invitemnumber) = False) Then
            unAllocateInventoryItem(oWorkOrderItem.Invitemnumber)
        End If

        'Remove WorkOrderItem from any Load associated with this workorder
        deleteLoadItemFromWorkOrderItem(vWorkOrderItemId)


        'By Source Type, clean up database, cancelling related ProductionOrders/RelabelOrders/PurchaseItems
        Select Case oWorkOrderItem.Sourcetype
            Case SourceType.PORD.ToString()
                Dim oProdOrder As New Prodorder
                If (oProdOrder.LoadByPrimaryKey(oWorkOrderItem.Sourcedocument) = True) AndAlso
                    (oProdOrder.Workordernumber = oWorkOrderItem.Workordernumber) Then

                    If (anyMaterialTransaction(oWorkOrderItem.Sourcedocument) = False) Then
                        'there are no material usage transactions against this production order
                        If (allInvItemsUnAllocated(oWorkOrderItem.Sourcedocument, SourceType.PORD.ToString()) = True) AndAlso vWorkOrderStatus <> "PENDING" Then
                            'there are no other inventoryitems allocated to this (or any other) workorder from this production order
                            'this workorder is not in PENDING status
                            'so we can CANCEL this production order
                            rollBackProductionOrder(oWorkOrderItem.Sourcedocument)
                        Else
                            'there are other inventory items allocated to this or other workorder(s) to be created from this production order
                            'so we CANNOT cancel this production order - so we update the production order quantity
                            removeUnallocatedINVandUpdateProdOrder(oProdOrder, vWorkOrderStatus, oWorkOrderItem.Qty)
                        End If
                    End If
                End If
            Case SourceType.PRCH.ToString()
                unallocatePurchaseItem(oWorkOrderItem.Sourcedocument, oWorkOrderItem.Qty)
            Case SourceType.RLBL.ToString()
                rollbackRelabelOrderItem(oWorkOrderItem.Sourcedocument)
        End Select

        'finally, delete WorkOrderItem record from WorkOrder
        oWorkOrderItem.MarkAsDeleted()
        oWorkOrderItem.Save()

    End Sub

    Public Sub removeUnallocatedINVandUpdateProdOrder(oProdOrder As Prodorder, oWorkOrderStatus As String, oWorkOrderItemQty As Integer)
        If oProdOrder Is Nothing Then
            Exit Sub
        End If
        removeUnallocatedInventory(oProdOrder.Prodordernum, SourceType.PORD.ToString())
        rollBackInventory(oProdOrder.Prodordernum, SourceType.PORD.ToString())

        If oWorkOrderStatus <> "PENDING" Then
            Dim oInvItems As InvitemCollection = getInventoryItems(oProdOrder.Prodordernum, SourceType.PORD.ToString())
            If Not oInvItems Is Nothing Then
                oProdOrder.Productqty = oInvItems.Count
            Else
                oProdOrder.Productqty = 0
            End If
        Else
            oProdOrder.Productqty = oProdOrder.Productqty - oWorkOrderItemQty
        End If

        updateQtyofProdItems(oProdOrder)

        If (oProdOrder.Productqty = 0) Then
            updateProdOrdertoCancel(oProdOrder)
        End If
        oProdOrder.Save()
    End Sub

    Public Sub unallocateWorkOrderItems(vSourceDocument As Integer, vSourceType As String)
        Dim oItems As WorkorderitemCollection = getWorkOrderItemsBySource(vSourceDocument, vSourceType)
        If (Not oItems Is Nothing And
            oItems.Count > 0) Then
            unallocateWorkOrderItems(oItems)
        End If
    End Sub

    Public Function getViewWorkOrder(vOrderStatus As String) As ViewWorkOrderCollection
        Dim oWorkOrders As New ViewWorkOrderCollection
        oWorkOrders.Query.Where(oWorkOrders.Query.Orderstatus.Equal(vOrderStatus))
        oWorkOrders.Query.Load()
        oWorkOrders.Sort = "WORKORDERDATE DESC"
        Return oWorkOrders
    End Function

    Public Sub updateSourceStatus(vWorkOrderNumber As Integer?)
        If vWorkOrderNumber Is Nothing Then
            Exit Sub
        End If

        updatePurchaseItemsStatus(PurchaseItemSourceType.WORKORDER, vWorkOrderNumber,
                          PurchaseItemsStatus.PENDING.ToString(),
                          PurchaseItemsStatus.REQUESTED.ToString())
        updateRelabelOrderStatus(vWorkOrderNumber, RelabelOrderStatus.PENDING, RelabelOrderStatus.INPROD)
        updateRelabelOrderItemSourceStatus(vWorkOrderNumber, RelabelOrderStatus.INPROD,
                                       PurchaseItemsStatus.PENDING, PurchaseItemsStatus.REQUESTED)
    End Sub

    Public Sub printWorkOrderAndSourceOrders(vWorkorderNum As Integer)
        If vWorkorderNum < 0 Then
            Exit Sub
        End If
        Dim oWOItems As ViewWorkOrderAllocatedItemCollection = getWorkOrderAllocatedItems(vWorkorderNum, _
                                                                                          SourceType.PORD.ToString())
        Dim oRelabelOrders As ViewRelabelOrderCollection = getRelabelOrders(vWorkorderNum)

        If Not oWOItems Is Nothing AndAlso _
            oWOItems.Count > 0 Then
            For Each oWOItem As ViewWorkOrderAllocatedItem In oWOItems
                printProdOrder(oWOItem.Sourcedocument)
            Next
        End If

        If Not oRelabelOrders Is Nothing AndAlso _
            oRelabelOrders.Count > 0 Then
            For Each oRelabelOrder As ViewRelabelOrder In oRelabelOrders
                printRelabelOrder(oRelabelOrder.Relabelordernumber)
            Next
        End If

        Dim oRptWorkOrder As New rptWorkOrder(vWorkorderNum)
        oRptWorkOrder.ShowPreview()
    End Sub

    Public Sub printWorkOrder(vOrderNum As Integer)
        Dim rpt As New rptWorkOrder(vOrderNum)
        rpt.ShowPreview()
    End Sub

End Module


