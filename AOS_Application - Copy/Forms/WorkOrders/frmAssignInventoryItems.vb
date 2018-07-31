Imports AOS.BusinessObjects

Public Class frmAssignInventoryItems
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer
    Public vWorkOrderID As Integer

    Dim oWorkOrder As ViewWorkOrder
    Dim oWOItems As ViewWorkOrderItemCollection
    Dim oAvailable As ViewInvItemDetailsCollection
    Dim oProdOrders As ViewProdOrderDataCollection
    Dim oPurchaseReqs As ViewPurchaseRequestCollection

    Private Sub frmAssignInventoryItems_Load(sender As Object, e As System.EventArgs) Handles Me.Load
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
        getAvailableInventory(vProductID)
        getProductionOrders(vWorkOrderID, vProductID)
        getPurchaseReqs(vWorkOrderID, vProductID)
        setProductionOrderOptions(vProductID)
    End Sub

    Private Sub getWorkOrder(vWorkOrderID As Integer)
        oWorkOrder = New ViewWorkOrder
        oWorkOrder.Query.Where(oWorkOrder.Query.Workordernumber.Equal(vWorkOrderID))
        oWorkOrder.Query.Load()
        bsWorkOrder.DataSource = oWorkOrder
        setRibbonTabs()
    End Sub

    Private Sub setRibbonTabs()
        If getWorkOrderType(vWorkOrderID) = "DIRECT" Then
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

    Private Sub getAvailableInventory(vProductID As Integer)
        oAvailable = New ViewInvItemDetailsCollection
        oAvailable.Query.Where(oAvailable.Query.Productid.Equal(vProductID), oAvailable.Query.Inventoryclass.Equal(InventoryClass.FULLAVAILABLE), _
                oAvailable.Query.Itemstatus.Equal("AVAILABLE"))
        oAvailable.Query.Load()
        oAvailable.Sort = "Receiveddate"
        bsAvailableInventory.DataSource = oAvailable
    End Sub

    Private Sub getProductionOrders(vWorkOrderID As Integer, vProductID As Integer)
        oProdOrders = New ViewProdOrderDataCollection
        oProdOrders.Query.Where(oProdOrders.Query.Workordernumber.Equal(vWorkOrderID), oProdOrders.Query.Productid.Equal(vProductID))
        oProdOrders.Query.Load()
        bsProdOrders.DataSource = oProdOrders
    End Sub

    Private Sub getPurchaseReqs(vWorkOrderID As Integer, vProductID As Integer)
        oPurchaseReqs = New ViewPurchaseRequestCollection
        oPurchaseReqs.Query.Where(oPurchaseReqs.Query.WorkOrderNumber.Equal(vWorkOrderID), oPurchaseReqs.Query.ProductID.Equal(vProductID))
        oPurchaseReqs.Query.Load()
        bsPurchaseReqs.DataSource = oPurchaseReqs
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
        getAvailableInventory(vProductID)
    End Sub

    Private Sub rbtnGetProductionOrders_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetProductionOrders.ItemClick
        getProductionOrders(vWorkOrderID, vProductID)
    End Sub

    Private Sub rbtnGetPurchaseReqs_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetPurchaseReqs.ItemClick
        getPurchaseReqs(vWorkOrderID, vProductID)
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

        If oWOItem.Invitemnumber > 0 Then
            MsgBox("The selected work order item has already been allocated.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'If oWOItem.Sourcetype = "INV" And (Not IsDBNull(oWOItem.Invitemnumber) And oWOItem.Invitemnumber > 0) Then
        '    MsgBox("The selected work order item has already been allocated.", MsgBoxStyle.Critical, "Error")
        '    Exit Sub
        'End If


        'retrieve Inv Item object
        Dim oInvItem As New Invitem
        If Not oInvItem.LoadByPrimaryKey(vItemNum) Then
            Exit Sub
        End If

        'Update Work Order Item record
        oWOItem.Invitemnumber = oInvItem.Invitemnumber
        oWOItem.Lotnumber = oInvItem.Lotnumber
        oWOItem.Warehouselocation = oInvItem.Warehouselocation
        If IsDBNull(oWOItem.Sourcetype) Or oWOItem.Sourcetype Is Nothing Or oWOItem.Sourcetype = "" Then
            oWOItem.Sourcetype = "INV"
            oWOItem.Sourcedocument = Nothing
        End If
        If Not IsDBNull(oInvItem.Unitcost) And oInvItem.Unitcost > 0 Then
            oWOItem.Unitcost = oInvItem.Unitcost
            oWOItem.Itemprofit = oWOItem.Itemprice - oWOItem.Unitcost
        End If
        oWOItem.Save()

        'Update Inventory Item record
        unAllocateInventoryItem(oInvItem.Invitemnumber)

        'update Work Order Item List and Available Inventory List
        getWorkOrderItems(vWorkOrderID, vProductID)
        getAvailableInventory(vProductID)

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
        If oWOItem.Sourcetype = "INV" Then
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
        getAvailableInventory(vProductID)

    End Sub


    Private Sub rbtnAddNewPurchaseReq_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewPurchaseReq.ItemClick
        addNewPurchaseRequest()
    End Sub

    Private Sub rbtnEditPurchaseReq_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditPurchaseReq.ItemClick
        If bsPurchaseReqs.Count <= 0 Then
            Exit Sub
        End If
        editPurchaseRequest(bsPurchaseReqs.Current.PurchReqID)
    End Sub

    Private Sub rbtnDeletePurchaseReq_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeletePurchaseReq.ItemClick
        If bsPurchaseReqs.Count <= 0 Then
            Exit Sub
        End If
        deletePurchaseRequest(bsPurchaseReqs.Current.PurchReqID)
    End Sub

    Private Sub addNewPurchaseRequest()
        Dim vQty As Integer = getUnallocatedWorkOrderItemCount()
        If vQty <= 0 Then
            MsgBox("There are no unallocated or unsourced work order items remaining", MsgBoxStyle.Critical, "Error - No Purchase Request needed")
            Exit Sub
        End If
        Dim frm As New frmAddEditPurchaseRequest
        frm.vEditType = "ADD"
        frm.vFrmSource = "WorkOrder"
        frm.vWorkOrderNum = vWorkOrderID
        frm.vCustomerID = bsWorkOrder.Current.CustID
        frm.vProductID = vProductID
        frm.vQty = vQty
        frm.ShowDialog()
        assignPurchaseReqToWorkOrderItems(frm.vID)
        getPurchaseReqs(vWorkOrderID, vProductID)
        getWorkOrderItems(vWorkOrderID, vProductID)
    End Sub

    Private Sub editPurchaseRequest(vReqKey As Integer)
        Dim frm As New frmAddEditPurchaseRequest
        frm.vID = vReqKey
        frm.vProductID = vProductID
        frm.vFrmSource = "WorkOrder"
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        assignPurchaseReqToWorkOrderItems(frm.vID)
        getPurchaseReqs(vWorkOrderID, vProductID)
        getWorkOrderItems(vWorkOrderID, vProductID)
    End Sub

    Private Sub deletePurchaseRequest(vReqKey As Integer)
        Dim str As String = "Are you sure you want to delete the selected Purchase Request?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        'first, unassign the purchase request from any work order item record
        Dim oItems As New WorkorderitemCollection

        'first, pull all work order items that may already be assigned to the select purchase request and unassign them
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(vWorkOrderID), _
                           oItems.Query.Sourcetype.Equal(SourceType.PRCH.ToString()), _
                           oItems.Query.Sourcedocument.Equal(vReqKey))

        If oItems.Query.Load Then
            For Each oitem As Workorderitem In oItems
                oitem.Sourcedocument = Nothing
                oitem.Sourcetype = Nothing
            Next
            oItems.Save()
        End If

        Dim rReq As New PurchaseRequest
        Try
            rReq.LoadByPrimaryKey(vReqKey)
            rReq.MarkAsDeleted()
            rReq.Save()
            MsgBox("Purchase Request successfully deleted", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox("Error in deleteing purchase request", MsgBoxStyle.Critical, "Error")
        End Try
        getPurchaseReqs(vWorkOrderID, vProductID)
        getWorkOrderItems(vWorkOrderID, vProductID)
    End Sub

    Private Sub assignPurchaseReqToWorkOrderItems(vPurchReqID As Integer)
        Dim oReq As New PurchaseRequest
        If Not oReq.LoadByPrimaryKey(vPurchReqID) Then
            MsgBox("Error in retrieving Purchase Req to assign to open Work Order Items", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim oItems As New WorkorderitemCollection

        'first, pull all work order items that may already be assigned to the select purchase request and unassign them
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(vWorkOrderID), _
                           oItems.Query.Sourcetype.Equal(SourceType.PRCH.ToString()), _
                           oItems.Query.Sourcedocument.Equal(vPurchReqID))

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
        Dim vMaxCnt As Integer = oReq.QtyContainers

        If vMaxCnt > oItems.Count Then
            MsgBox("The Purchase Req is for a greater quantity of containers than are open on the work order", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        For Each oItem As Workorderitem In oItems
            If vCnt < vMaxCnt Then
                oItem.Sourcetype = SourceType.PRCH.ToString()
                oItem.Sourcedocument = vPurchReqID
                vCnt = vCnt + 1
            End If
        Next
        oItems.Save()
    End Sub

    Private Sub rbtnAddNewProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewProductionOrder.ItemClick
        addNewProdOrder()
    End Sub

    Private Sub rbtnEditProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditProductionOrder.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If
        editProdOrder(bsProdOrders.Current.ProdOrderNum)
    End Sub

    Private Sub rbtnDeleteProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteProductionOrder.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If
        deleteProdOrder(bsProdOrders.Current.ProdOrderNum)
    End Sub

    Private Sub rbtnPrintProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintProductionOrder.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If
        printProdOrder(bsProdOrders.Current.ProdOrderNum)
    End Sub

    Private Sub addNewProdOrder()
        Dim vQty As Integer = getUnallocatedWorkOrderItemCount()
        If vQty <= 0 Then
            MsgBox("There are no unallocated or unsourced work order items remaining", MsgBoxStyle.Critical, "Error - No Production Order needed")
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
        assignProductionOrderToWorkOrderItems(frm.vID)
        getWorkOrderItems(vWorkOrderID, vProductID)
        getProductionOrders(vWorkOrderID, vProductID)
        getPurchaseReqs(vWorkOrderID, vProductID)
    End Sub

    Private Sub editProdOrder(vProdOrderNum As Integer)
        Dim frm As New frmAddEditProdOrder
        frm.vEditType = "EDIT"
        frm.vID = vProdOrderNum
        frm.vProductID = vProductID
        frm.vWorkOrderID = vWorkOrderID
        frm.vFrmSource = "WorkOrder"
        frm.ShowDialog()
        assignProductionOrderToWorkOrderItems(frm.vID)
        getWorkOrderItems(vWorkOrderID, vProductID)
        getProductionOrders(vWorkOrderID, vProductID)
    End Sub

    Private Sub deleteProdOrder(vProdOrderID As Integer)
        Dim str As String = "Are you sure you want to delete the selected Production Order?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        'must determine if any MaterialTransactions have occurred against any PRODITEM for this PRODUCTION ORDER before allowing DELETE request
        Dim oTxs As New ViewProductionOrderMaterialTransactionsCollection
        oTxs.Query.Where(oTxs.Query.Prodordernum.Equal(vProdOrderID))
        If oTxs.Query.Load Then
            If oTxs.Count > 0 Then
                MsgBox("There are Raw Material Transactions recorded against this Production Order. It cannot be deleted.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        End If

        'first, unassign the production order from any work order item record
        Dim oItems As New WorkorderitemCollection
        'first, pull all work order items that may already be assigned to the selected Production Order and unassign them
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(bsWorkOrder.Current.workordernumber), _
                           oItems.Query.Sourcetype.Equal(SourceType.PORD.ToString()), _
                           oItems.Query.Sourcedocument.Equal(vProdOrderID))
        If oItems.Query.Load Then
            For Each oitem As Workorderitem In oItems
                oitem.Sourcedocument = Nothing
                oitem.Sourcetype = Nothing
            Next
            oItems.Save()
        End If

        Dim oProd As New Prodorder
        Dim oPItems As New ProditemCollection

        Try
            oPItems.Query.Where(oPItems.Query.Prodordernum.Equal(vProdOrderID))
            If oPItems.Query.Load Then
                oPItems.MarkAllAsDeleted()
                oPItems.Save()
            End If
            If oProd.LoadByPrimaryKey(vProdOrderID) Then
                oProd.MarkAsDeleted()
                oProd.Save()
            End If
            MsgBox("Production Order successfully deleted", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox("Error in deleting Production Order", MsgBoxStyle.Critical, "Error")
        End Try
        getWorkOrderItems(vWorkOrderID, vProductID)
        getProductionOrders(vWorkOrderID, vProductID)
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

    Private Sub assignProductionOrderToWorkOrderItems(vOrd As Integer)
        Dim oOrd As New Prodorder
        If Not oOrd.LoadByPrimaryKey(vOrd) Then
            MsgBox("Error in retrieving Production Order to assign to open Work Order Items", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim oItems As New WorkorderitemCollection
        'first, pull all work order items that may already be assigned to the select purchase request and unassign them
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(vWorkOrderID), _
                           oItems.Query.Sourcetype.Equal(SourceType.PORD.ToString()), _
                           oItems.Query.Sourcedocument.Equal(vOrd))
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
                oItem.Sourcedocument = vOrd
                vCnt = vCnt + 1
            End If
        Next
        oItems.Save()
    End Sub

    Private Sub printProdOrder(vProdOrderID As Integer)

        Dim oOrd As New Prodorder
        Try
            oOrd.LoadByPrimaryKey(vProdOrderID)
        Catch ex As Exception

        End Try

        Dim rpt As New rptProductionOrder(vProdOrderID)
        Dim rpt2 As New rptAPIS(oOrd.Apisnum)
        Dim rpt3 As New rptProductLabelFromProductionOrder(vProdOrderID)
        rpt.ShowPreviewDialog()
        rpt2.ShowPreviewDialog()
        rpt3.showpreviewdialog()
    End Sub

End Class