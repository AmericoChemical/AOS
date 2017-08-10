Imports AOS.BusinessObjects

Public Class frmAssignInventoryItems2
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer
    Public vWorkOrderID As Integer
    Dim UnallocatedMessage As String = "There are no unallocated or unsourced work order items remaining"
    Dim oWorkOrder As ViewWorkOrder
    Dim oWOItems As ViewWorkOrderItemCollection
    Dim oAvailable As ViewInvItemDetailsCollection
    Dim oProdOrders As ViewProdOrderDataCollection
    Dim oRelabelOrders As ViewRelabelOrderCollection


    Private Sub frmAssignInventoryItems_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        RibbonControl1.SelectedPage = RibbonPage1
    End Sub
    Private Sub RibbonControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonControl1.SelectedPageChanged
        Dim vNum As Integer
        If Me.RibbonControl1.SelectedPage.Name = "" Then
            vNum = 1
        Else
            vNum = CInt(Me.RibbonControl1.SelectedPage.Name.Substring(10, 1))
        End If
        Dim ctlPage As New DevExpress.XtraEditors.PanelControl
        ctlPage = Me.WorkPanelHolder.Controls("RibbonPanelControl" & vNum.ToString)
        If Not ctlPage Is Nothing Then
            ctlPage.BringToFront()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        getWorkOrder(vWorkOrderID)
        getWorkOrderItems(vWorkOrderID, vProductID)
        getAvailableInventoryItems(vProductID)
        refreshProdOrderTab(vWorkOrderID, vProductID)
        getPurchaseItems(vWorkOrderID, vProductID)
        setProductionOrderOptions(vProductID)
        setRelabelOrderOptions(vProductID)
    End Sub

    Private Sub getWorkOrder(vWorkOrderID As Integer)
        oWorkOrder = New ViewWorkOrder
        oWorkOrder.Query.Where(oWorkOrder.Query.Workordernumber.Equal(vWorkOrderID))
        oWorkOrder.Query.Load()
        bsWorkOrder.DataSource = oWorkOrder
        setRibbonTabs()
    End Sub

    Private Sub setRibbonTabs()
        If getWorkOrderType(vWorkOrderID) = TransportType.DIRECT.ToString() Then
            RibbonPage2.Visible = False
        Else
            RibbonPage2.Visible = True
        End If
    End Sub

    Private Function getWorkOrderType(vKey As Integer) As String
        Dim oWO As New Workorder
        If oWO.LoadByPrimaryKey(vKey) Then
            Return oWO.Workordertype
        Else
            Return ""
        End If
    End Function

    Private Sub getWorkOrderItems(vWorkOrderID As Integer, vProductID As Integer)
        oWOItems = New ViewWorkOrderItemCollection
        oWOItems.Query.Where(oWOItems.Query.Workordernumber.Equal(vWorkOrderID), oWOItems.Query.Productid.Equal(vProductID))
        oWOItems.Query.Load()
        bsWOItems.DataSource = oWOItems
    End Sub

    Private Sub getAvailableInventoryItems(vProductID As Integer)
        oAvailable = New ViewInvItemDetailsCollection
        oAvailable = getAvailableInventory(vProductID, "ItemStatus, AvailableDate")
        bsAvailableInventory.DataSource = oAvailable
    End Sub

    Private Sub getPurchaseItems(vWorkOrderID As Integer, vProductID As Integer)
        Dim oPurchaseItems As ViewPurchaseItemRequestCollection = _
            PurchaseProcessing.getPurchaseItems(PurchaseItemSourceType.WORKORDER.ToString(), vWorkOrderID, vProductID)
        bsPurchaseItems.DataSource = oPurchaseItems

        Dim oCancelledPurchaseItems As New ViewPurchaseItemRequestCollection
        oCancelledPurchaseItems = PurchaseProcessing.getCancelledPurchaseItems(PurchaseItemSourceType.WORKORDER.ToString(), vWorkOrderID, vProductID)
        bsCancelledPurchaseItems.DataSource = oCancelledPurchaseItems
    End Sub

    Private Sub setProductionOrderOptions(vID As Integer)
        Dim oAPIS As New ApisCollection
        oAPIS.Query.Where(oAPIS.Query.Productid.Equal(vID))
        If oAPIS.Query.Load Then
            rbtnAddNewProductionOrder.Enabled = True
        Else
            rbtnAddNewProductionOrder.Enabled = False
        End If
    End Sub

    Private Function changesSaved() As Boolean
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Return True
    End Function

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub rbtnSearchInventory_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSearchInventory.ItemClick
        getAvailableInventoryItems(vProductID)
    End Sub

    Private Sub rbtnGetProductionOrders_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetProductionOrders.ItemClick
        refreshProdOrderTab(vWorkOrderID, vProductID)
    End Sub

    Private Sub rbtnGetPurchaseItems_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetPurchaseItems.ItemClick
        getPurchaseItems(vWorkOrderID, vProductID)
    End Sub

    Private Sub rbtnAllocateItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAllocateItem.ItemClick

        'Allocate selected Available Inventory item to the selected Work Order Item
        If bsWOItems.Count <= 0 Then
            Exit Sub
        End If
        If bsAvailableInventory.Count <= 0 Then
            Exit Sub
        End If
        Dim vWOItemNum As Integer = bsWOItems.Current.WorkOrderItemNumber
        Dim vItemNum As Integer = bsAvailableInventory.Current.InvItemNumber

        'retrieve Work Order Item object
        Dim oWOItem As New Workorderitem
        If Not oWOItem.LoadByPrimaryKey(vWOItemNum) Then
            Exit Sub
        End If

        If Not oWOItem.Sourcetype Is Nothing AndAlso _
            Not oWOItem.Sourcedocument Is Nothing Then
            MsgBox(UnallocatedMessage, MsgBoxStyle.Critical, "Allocate Work Order Items - Error")
            Exit Sub
        End If

        If oWOItem.Sourcetype = SourceType.INV.ToString() AndAlso _
            (Not IsDBNull(oWOItem.Invitemnumber) AndAlso _
                oWOItem.Invitemnumber > 0) Then
            MsgBox("The selected work order item has already been allocated.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'retrieve Inv Item object
        Dim oInvItems As ViewInvItemDetailsCollection = getViewInvItemDetails(vItemNum)

        allocateInventory(oWOItem.Workorderitemnumber, AllocatedType.WORKORDER, oInvItems)

        'update Work Order Item List and Available Inventory List
        getWorkOrderItems(vWorkOrderID, vProductID)
        getAvailableInventoryItems(vProductID)

        enableUnallocateInv()
    End Sub

    Private Sub rbtnUnallocateWorkOrderItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUnallocateWorkOrderItem.ItemClick

        'Allocate selected Available Inventory item to the selected Work Order Item
        If bsWOItems.Count <= 0 Then
            Exit Sub
        End If

        Dim vWOItemNum As Integer = bsWOItems.Current.WorkOrderItemNumber
        Dim vItemNum As Integer = bsWOItems.Current.InvItemNumber

        'retrieve Work Order Item object
        Dim oWOItem As New Workorderitem
        If Not oWOItem.LoadByPrimaryKey(vWOItemNum) Then
            Exit Sub
        End If

        'retrieve Inv Item object
        Dim oInvItem As New Invitem
        If Not oInvItem.LoadByPrimaryKey(vItemNum) Then
            Exit Sub
        End If

        'Update Work Order Item record
        oWOItem.Invitemnumber = Nothing
        oWOItem.Lotnumber = Nothing
        oWOItem.Warehouselocation = Nothing
        If oWOItem.Sourcetype = SourceType.INV.ToString() Then
            oWOItem.Sourcetype = Nothing
            oWOItem.Sourcedocument = Nothing
        End If
        If Not IsDBNull(oInvItem.Unitcost) And oInvItem.Unitcost > 0 Then
            oWOItem.Unitcost = Nothing
            oWOItem.Itemprofit = Nothing
        End If
        oWOItem.Save()

        'Update Inventory Item record
        unAllocateInventoryItem(oInvItem.Invitemnumber)

        'update Work Order Item List and Available Inventory List
        getWorkOrderItems(vWorkOrderID, vProductID)
        getAvailableInventoryItems(vProductID)

        enableUnallocateInv()

    End Sub


    Private Sub rbtnAddNewPurchaseItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewPurchaseItem.ItemClick
        addNewPurchaseItem()
    End Sub

    Private Sub rbtnEditPurchaseItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditPurchaseItem.ItemClick
        If bsPurchaseItems.Count <= 0 Then
            Exit Sub
        End If
        editPurchaseItem(bsPurchaseItems.Current.Purchaseitemid)
        enableUnallocateInv()
    End Sub

    Private Sub rbtnDeletePurchaseItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeletePurchaseItem.ItemClick
        If bsPurchaseItems.Count <= 0 Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to cancel the selected Purchase Item?",
                  MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        If bsPurchaseItems.Current.Purchaseitemstatus = PurchaseItemsStatus.ORDERED.ToString() OrElse _
            bsPurchaseItems.Current.Purchaseitemstatus = PurchaseItemsStatus.RECEIVED.ToString() OrElse _
            bsPurchaseItems.Current.Purchaseitemstatus = PurchaseItemsStatus.FULFILLED.ToString() Then

            If MsgBox("Purchase Item cannot be cancelled as it is already on order, received or fulfilled. " &
                      "Are you sure you want to unlink this purchase item from all the work order items on this work order?",
                      MsgBoxStyle.YesNo, "Purchase Item Unlink Confirmation") = MsgBoxResult.No Then
                Exit Sub
            End If
            unassignWorkOrderItem(vWorkOrderID, bsPurchaseItems.Current.Purchaseitemid)
        Else
            unassignWorkOrderItem(vWorkOrderID, bsPurchaseItems.Current.Purchaseitemid)
            deletePurchaseItem(bsPurchaseItems.Current.Purchaseitemid)
        End If
        getPurchaseItems(vWorkOrderID, vProductID)
        getWorkOrderItems(vWorkOrderID, vProductID)

    End Sub

    Private Sub addNewPurchaseItem()
        Dim vQty As Integer = getUnallocatedWorkOrderItemCount()
        If vQty <= 0 Then
            MsgBox(UnallocatedMessage, MsgBoxStyle.Critical, "Create Purchase Item - Error")
            Exit Sub
        End If
        If bsWOItems.Count > 0 Then
            checkAndCreatePurchaseItemsAndFulfillWO(vWorkOrderID, bsWOItems.Current.Productid)
            getPurchaseItems(vWorkOrderID, bsWOItems.Current.Productid)
            getWorkOrderItems(vWorkOrderID, bsWOItems.Current.Productid)
        End If
    End Sub

    Private Sub editPurchaseItem(vReqKey As Integer)
        Dim frm As New frmAddEditPurchaseItem
        frm.vID = vReqKey
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getPurchaseItems(vWorkOrderID, vProductID)
        getWorkOrderItems(vWorkOrderID, vProductID)
    End Sub

    Private Sub rbtnAddNewProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewProductionOrder.ItemClick
        addNewProdOrder()
    End Sub

    Private Sub rbtnEditProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditProductionOrder.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If

        If bsProdOrders.Current.OrderStatus = ProdOrderStatus.CANCELLED.ToString() Then
            Exit Sub
        End If

        editProdOrder(bsProdOrders.Current.ProdOrderNum)
    End Sub

    Private Sub rbtnPrintProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintProductionOrder.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If

        If bsProdOrders.Current.OrderStatus = ProdOrderStatus.CANCELLED.ToString() Then
            Exit Sub
        End If

        printProdOrder(bsProdOrders.Current.ProdOrderNum)
    End Sub

    Private Sub addNewProdOrder()
        Dim vQty As Integer = getUnallocatedWorkOrderItemCount()
        If vQty <= 0 Then
            MsgBox(UnallocatedMessage, MsgBoxStyle.Critical, "Error - No Production Order needed")
            Exit Sub
        End If
        Dim frm As New frmAddEditProdOrder
        frm.vEditType = "ADD"
        frm.vQty = vQty
        frm.vProductID = vProductID
        frm.vWorkOrderID = vWorkOrderID
        frm.vFrmSource = "WorkOrder"
        If frm.ShowDialog() = Windows.Forms.DialogResult.Abort Then
            ' New production order was not created
            MsgBox("Production Order was not created", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If
        'This will be called from frmAddEditProdOrder as we need to do this before creating INVITEMS
        'assignProductionOrderToWorkOrderItems(frm.vID, vWorkOrderID, vProductID)
        getWorkOrderItems(vWorkOrderID, vProductID)
        refreshProdOrderTab(vWorkOrderID, vProductID)
        getPurchaseItems(vWorkOrderID, vProductID)
    End Sub

    Private Sub editProdOrder(vProdOrderNum As Integer)
        Dim frm As New frmAddEditProdOrder
        frm.vEditType = "EDIT"
        frm.vID = vProdOrderNum
        frm.vProductID = vProductID
        frm.vWorkOrderID = vWorkOrderID
        frm.vFrmSource = "WorkOrder"
        frm.ShowDialog()
        assignProductionOrderToWorkOrderItems(frm.vID, vWorkOrderID, vProductID)
        getWorkOrderItems(vWorkOrderID, vProductID)
        refreshProdOrderTab(vWorkOrderID, vProductID)
    End Sub


    Private Function getUnallocatedWorkOrderItemCount() As Integer
        'now, assign the purchase request to a number of open work order items.
        Dim oItems As WorkorderitemCollection
        oItems = New WorkorderitemCollection
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(vWorkOrderID), oItems.Query.Productid.Equal(vProductID), oItems.Query.Sourcetype.IsNull())
        If Not oItems.Query.Load Then
            Return 0
        Else
            Return oItems.Count
        End If
    End Function

    Private Sub rbtnCancelProductionOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancelProductionOrder.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If

        If bsProdOrders.Current.OrderStatus = ProdOrderStatus.CANCELLED.ToString() Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to cancel the selected Production Order?", _
                  MsgBoxStyle.YesNo, _
                  "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        unAllocateInventoryItems(bsProdOrders.Current.ProdOrderNum, SourceType.PORD.ToString())
        cancelProdOrder(bsProdOrders.Current.ProdOrderNum, True)
        getWorkOrderItems(vWorkOrderID, vProductID)
        refreshProdOrderTab(vWorkOrderID, vProductID)
    End Sub

    Private Sub refreshProdOrderTab(vWorkOrderID As Integer, vProductID As Integer)
        oProdOrders = getViewProductionOrderData(vWorkOrderID, vProductID)
        bsProdOrders.DataSource = oProdOrders

        Dim oCanceledProdOrders = getViewProductionOrderData(vWorkOrderID, vProductID, True)
        bsCancelledProdOrders.DataSource = oCanceledProdOrders

        rbtnCancelProductionOrder.Enabled = IIf((oProdOrders Is Nothing OrElse _
                                                      oProdOrders.Count <= 0), False, True)
        rbtnEditProductionOrder.Enabled = rbtnCancelProductionOrder.Enabled
    End Sub

    Private Sub grvWorkOrderItems_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvWorkOrderItems.FocusedRowChanged
        enableUnallocateInv()
        setRelabelOrderOptions(vProductID)
    End Sub

    Private Sub enableUnallocateInv()
        If bsWOItems.Count <= 0 Then
            Exit Sub
        End If

        rbtnUnallocateWorkOrderItem.Enabled = IIf(Not bsWOItems.Current.Sourcetype Is Nothing AndAlso _
                                                  bsWOItems.Current.Sourcetype = SourceType.INV.ToString(), _
                                                  True, False)
    End Sub

    Private Sub rbtnGetRelabelOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetRelabelOrders.ItemClick
        refreshRelabelOrderTab(vWorkOrderID, vProductID)
    End Sub

    Private Sub refreshRelabelOrderTab(vWorkOrderid As Integer, vProductID As Integer)
        oRelabelOrders = getRelabelOrders(vWorkOrderid, vProductID)
        bsRelabelOrders.DataSource = oRelabelOrders

        Dim oCanceledRelabelOrders = getRelabelOrders(vWorkOrderid, vProductID, True)
        bsCancelledRelabelOrders.DataSource = oCanceledRelabelOrders

        setRelabelOrderOptions(vProductID)
    End Sub

    Private Sub setRelabelOrderOptions(vProductID As Integer)
        Dim vIsRelabelOrderExist As Boolean
        rbtnAddNewRelabelOrder.Enabled = IIf(bsWOItems.Current.Sourcetype Is Nothing AndAlso _
                                            checkProductFulfillment(vProductID, FulfillmentType.RLBL) = True, True, False)
        If bsRelabelOrders.Count > 0 Then
            If Not oRelabelOrders Is Nothing OrElse _
                oRelabelOrders.Count > 0 Then
                vIsRelabelOrderExist = IIf((checkProductFulfillment(vProductID, FulfillmentType.RLBL) = True AndAlso _
                                              bsRelabelOrders.Current.RELABELORDERSTATUS <> RelabelOrderStatus.CANCELLED.ToString() AndAlso _
                                              bsRelabelOrders.Current.RELABELORDERSTATUS <> RelabelOrderStatus.COMPLETED.ToString()), True, False)
            End If
        End If

        rbtnCancelRelabelOrder.Enabled = vIsRelabelOrderExist
        rbtnPrintRelabelOrder.Enabled = vIsRelabelOrderExist
    End Sub

    Private Sub rbtnPrintRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintRelabelOrder.ItemClick
        printRelabelOrder(bsRelabelOrders.Current.Relabelordernumber)
    End Sub

    Private Sub rbtnCancelRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancelRelabelOrder.ItemClick
        If MsgBox("Are you sure you want to cancel the selected Relabel Order?", _
                  MsgBoxStyle.YesNo, _
                  "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        cancelRelabelOrderAndItems(bsRelabelOrders.Current.Relabelordernumber, True)
        getWorkOrderItems(vWorkOrderID, vProductID)
        refreshRelabelOrderTab(vWorkOrderID, vProductID)
    End Sub

    Private Sub rbtnAddNewRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewRelabelOrder.ItemClick
        processRelabelOrder(bsWorkOrder.Current.WORKORDERNUMBER, vProductID)
        getWorkOrderItems(vWorkOrderID, vProductID)
        refreshRelabelOrderTab(vWorkOrderID, vProductID)
    End Sub

    Private Sub grvRelabelOrders_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvRelabelOrders.FocusedRowChanged
        setRelabelOrderOptions(vProductID)
    End Sub

End Class