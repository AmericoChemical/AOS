Imports AOS.BusinessObjects
Imports System.Text

Public Class frmAddEditPurchaseItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer
    Public vEditType As String
    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Purchase Item"
    Public vAvailableQty As Integer
    Public vCalledFrom As String
    Public vMaterialID As Integer = 0
    Public vDefaultProductID As Integer = 0
    Public vMaterialUOM As String
    Public vMaterialProduct As ViewMaterialProductInfoCollection
    Public oPurchase As Purchase


    ''' <summary>
    ''' Need to pass "DIRECT" for Direct PO or "MATERIAL" if from Material Needs
    ''' </summary>
    ''' <remarks></remarks>
    Public vPurchaseItemType As String = PurchaseItemType.REGULAR.ToString()

    'here is where you dimension your object variables for the form
    Public oPurchaseitem As Purchaseitem
    Dim oRelabelOrders As ViewRelabelOrderCollection
    Dim oCosts As New ProductcostCollection
    Public oCost As Productcost
    Dim vIsNotPageLoad As Boolean

    'To get the selected inventory items
    Dim vInventoryItemNumbers As List(Of Integer)

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case vEditType
            Case "ADD"
                Me.Text = "Adding New " & vObjectName
            Case "EDIT"
                Me.Text = "Editing " & vObjectName & " Information"
            Case "READONLY"
                Me.Text = vObjectName & " Information"
        End Select

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Cursor = Cursors.WaitCursor
        loadLookupData()
        loadData()
        Me.Cursor = Cursors.Default

        If oPurchaseitem.Purchaseitemtype = PurchaseItemType.DIRECT.ToString() Then
            ExpectedInLabel.Text = "Exp Delivery"
            CustomerPONumTextEdit.Visible = True
            lblCustomerPO.Visible = True
            CustomerPONumTextEdit.Properties.ReadOnly = (Not oPurchaseitem.Sourcetype Is Nothing)
        Else
            ExpectedInLabel.Text = "Expected In"
        End If

    End Sub

    Private Sub RibbonControl2_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonControl2.SelectedPageChanged
        Dim vNum As Integer
        If Me.RibbonControl2.SelectedPage.Name = "" Then
            vNum = 6
        Else
            vNum = CInt(Me.RibbonControl2.SelectedPage.Name.Substring(10, 1))
        End If
        Dim ctlPage As New DevExpress.XtraEditors.PanelControl
        ctlPage = Me.WorkPanelHolder.Controls("RibbonPanelControl" & vNum.ToString)
        If Not ctlPage Is Nothing Then
            ctlPage.BringToFront()
        End If
    End Sub

    Private Sub loadLookupData()
        bsCustomers.DataSource = getCustomer()
        bsVendor.DataSource = getVendor()
        bsItemTypes.DataSource = getItemtype()
        If vCalledFrom = "MATERIALPLANNING" Then
            bsProduct.DataSource = vMaterialProduct
        ElseIf Not oPurchase Is Nothing AndAlso _
            oPurchase.Purchasenumber > 0 Then
            bsProduct.DataSource = getProductByVendor(oPurchase.Vendorid)
        Else
            bsProduct.DataSource = getProduct("ACTIVE")
        End If
    End Sub


    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
            setupForm()
            If vDefaultProductID > 0 Then
                'get standard qty from PRODUCT record to determine QTY of containers to order to meet RM demand
                Dim oProduct As New Product
                If Not oProduct.LoadByPrimaryKey(vDefaultProductID) Then
                    MsgBox("Error in retrieving Product data", MsgBoxStyle.Critical, "ERROR - Missing Data")
                    Exit Sub
                End If
                'assume we now have the product record
                oPurchaseitem.Itemdescription = oProduct.Productdesc
                oPurchaseitem.Container = oProduct.Container

                Dim vPurchaseQty As Integer = 0
                Dim vUnits As Integer = 0

                vUnits = 0.0
                If Not (oProduct Is Nothing) Then
                    Select Case oProduct.Inventorymethod
                        Case "VOLUME"
                            vUnits = oProduct.Volumeunits
                        Case "WEIGHT"
                            vUnits = oProduct.Weightunits
                        Case Else
                            vUnits = oProduct.Units
                    End Select
                End If

                If vAvailableQty > 0 And vUnits > 0 Then
                    vPurchaseQty = Math.Ceiling(vAvailableQty / Val(vUnits))
                    oPurchaseitem.Qty = vPurchaseQty
                    oPurchaseitem.EndEdit()
                Else
                    MsgBox("Unable to automatically calculate the quantity to order", MsgBoxStyle.Critical, "Calculate Purchase Item Quantity - Error")
                End If

            End If

            'Dim oProductCosts As ProductcostCollection = getProductCosts(0, vDefaultProductID)
            'Dim oProductCost As Productcost = Nothing
            'Dim vErrorMsg As String = ""
            'If oProductCosts.Count <= 0 Then
            '    vErrorMsg = "Unable to calculate the quantity as there is no Product Cost record"
            'ElseIf oProductCosts.Count > 1 Then
            '    vErrorMsg = "Unable to calculate the quantity as there are more than one Product Cost record"
            'Else
            '    oProductCost = oProductCosts(0)
            'End If

            'vUnits = 0.0
            'If Not (oProductCost Is Nothing) Then
            '    Select Case oProductCost.Costmethod
            '        Case PricingMethod.VOLUME.ToString()
            '            vUnits = oProductCost.Volumeunits
            '        Case PricingMethod.WEIGHT.ToString()
            '            vUnits = oProductCost.Weightunits
            '    End Select
            'End If



            'If vAvailableQty > 0 And vUnits > 0 Then
            '    vPurchaseQty = Math.Ceiling(vAvailableQty / Val(vUnits))
            '    oPurchaseitem.Qty = vPurchaseQty
            '    oPurchaseitem.EndEdit()
            'Else
            '    If vErrorMsg = "" Then
            '        vErrorMsg = "Unable to calculate the quantity due to incomplete Product Cost record"
            '    End If
            '    MsgBox(vErrorMsg, MsgBoxStyle.Critical, "Calculate Purchase Item Quantity - Error")
            'End If

            fillItemDetails(vDefaultProductID, True)
        Else
            If vID > 0 Then
                editObject(vID)
                setProductionOrderOptions(bsPurchaseItem.Current.ITEMID)
                setRelabelOrderOptions(bsPurchaseItem.Current.ITEMID)
            End If
            getAvailableInventoryItems()
            getAllocatedInventoryItems()
        End If
        loadPendingInventoryItems()
    End Sub

    Private Sub addProductAndQtyToPurchaseItem(vProductID As Integer, vDemand As Decimal)

        'get standard qty from PRODUCT record to determine QTY of containers to order to meet RM demand
        Dim oProduct As New Product
        If Not oProduct.LoadByPrimaryKey(vDefaultProductID) Then
            MsgBox("Error in retrieving Product data", MsgBoxStyle.Critical, "ERROR - Missing Data")
            Exit Sub
        End If
        'assume we now have the product record
        oPurchaseitem.Itemdescription = oProduct.Productdesc
        oPurchaseitem.Container = oProduct.Container



    End Sub




    Private Sub setProductionOrderOptions(vProductID As Integer)
        Dim oAPIS As New ApisCollection
        oAPIS = getActiveAPIS(vProductID)
        If oAPIS.Query.Load Then
            rbtnAddNewProductionOrder2.Enabled = IIf(vEditType = "READONLY", False, True)
        Else
            rbtnAddNewProductionOrder2.Enabled = False
        End If
    End Sub

    Private Sub addNewObject()
        oPurchaseitem = New Purchaseitem
        oPurchaseitem.AddNew()
        Dim vInventoryClass As Integer = IIf(vCalledFrom = "MATERIALPLANNING", InventoryClass.INPROCESS, InventoryClass.FULLAVAILABLE)
        oPurchaseitem.Inventoryclass = vInventoryClass
        oPurchaseitem.Purchaseitemstatus = PurchaseItemsStatus.REQUESTED.ToString()
        If Not oPurchase Is Nothing AndAlso _
            oPurchase.Purchasenumber > 0 Then
            oPurchaseitem.Purchaseitemtype = oPurchase.Purchasetype
            oPurchaseitem.Purchasenumber = oPurchase.Purchasenumber
            oPurchaseitem.Vendorid = oPurchase.Vendorid
            oPurchaseitem.Customerid = oPurchase.Custid
            oPurchaseitem.Expectedindate = oPurchase.Expectedindate
        Else
            oPurchaseitem.Purchaseitemtype = vPurchaseItemType
        End If

        oPurchaseitem.Itemid = vDefaultProductID
        oPurchaseitem.Itemtype = ItemType.PRODUCT.ToString()
        oPurchaseitem.Qty = 0
        oPurchaseitem.Unitorcontainer = "C"

        'Needed by is a required field and should not auto populate with current date
        'oPurchaseitem.Dateneeded = Now
        oPurchaseitem.Createdby = vCurrentUserLogin
        oPurchaseitem.Createdtime = Now
        oPurchaseitem.EndEdit()
        oPurchaseitem.Save()
        Me.bsPurchaseItem.DataSource = oPurchaseitem

        vIsNotPageLoad = True
        QtyTextEdit.Focus()

    End Sub

    Private Sub editObject(ByVal vID As Integer)

        oPurchaseitem = New Purchaseitem

        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oPurchaseitem.LoadByPrimaryKey(vID)
        Me.bsPurchaseItem.DataSource = oPurchaseitem
        Dim vVendorID As Integer = 0
        vIsNotPageLoad = True

        'When this form is shown from view purchasing or other places we haven't sent the oPurchasing public variable
        'So below is better way to implement the same
        'After loading the purchase we need to refresh the product list
        If Not oPurchaseitem.Purchasenumber Is Nothing AndAlso _
            oPurchase Is Nothing Then
            oPurchase = New Purchase()
            oPurchase.LoadByPrimaryKey(oPurchaseitem.Purchasenumber)
            loadLookupData()
        End If

        If Not oPurchaseitem.Vendorid Is Nothing Then
            vVendorID = oPurchaseitem.Vendorid
        End If

        Me.bsVendorItem.DataSource = getVendorByVendorID(vVendorID)

        setupForm()

        If oPurchaseitem.Vendorid Is Nothing Then
            fillItemDetails(ItemIDLookUpEdit.EditValue)
        End If

    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsPurchaseItem.EndEdit()
            oPurchaseitem.EndEdit()

            'Dim vMsg As String = String.Format("{0} date is after than the Date Needed. Are you sure you want to use this date?",
            '                                IIf(oPurchaseitem.Purchaseitemtype = PurchaseItemType.DIRECT.ToString(),
            '                                "Exp Delivery", "Expected In"))

            'If (oPurchaseitem.Dateneeded < oPurchaseitem.Expectedindate) Then
            '    If MsgBox(vMsg, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            '        Return False
            '    End If
            'End If

            oPurchaseitem.Save()

            If Not oPurchase Is Nothing AndAlso _
                oPurchase.Purchasestatus = PurchaseStatus.ORDERED.ToString() Then
                Select Case oPurchaseitem.Purchaseitemstatus
                    Case PurchaseItemsStatus.PENDING.ToString(), PurchaseItemsStatus.REQUESTED.ToString()
                        approvePurchaseOrderItems(oPurchase, oPurchaseitem.Purchaseitemid)
                End Select
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bsPurchaseItem.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oPurchaseitem.MarkAsDeleted()
                oPurchaseitem.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If ValidateControls() Then
            If changesSaved() Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
    Private Sub setProductCost(vCOSTRECID As Integer)
        Dim oProductCost As New Productcost
        Dim vVendorID As Integer = 0
        oProductCost.LoadByPrimaryKey(vCOSTRECID)

        bsPurchaseItem.Current.UNITCOST = oProductCost.Unitcost
        bsPurchaseItem.Current.UOM = oProductCost.Uom
        bsPurchaseItem.Current.UNITSINCONTAINER = oProductCost.Units
        bsPurchaseItem.Current.VENDORID = oProductCost.Vendorid
        bsPurchaseItem.Current.Vendoritemnumber = oProductCost.Vendoritemkey

        bsPurchaseItem.EndEdit()
        bsPurchaseItem.ResetBindings(True)

        If Not oProductCost.Vendorid Is Nothing Then
            vVendorID = oProductCost.Vendorid
        End If
        bsVendorItem.DataSource = getVendorByVendorID(vVendorID)

    End Sub

    Private Sub setupForm()

        RibbonPage7.Visible = False
        Select Case oPurchaseitem.Sourcetype
            Case PurchaseItemSourceType.WORKORDER.ToString()
                disableControls()
                If (oPurchaseitem.Purchaseitemstatus <> PurchaseItemsStatus.PENDING.ToString() AndAlso
                oPurchaseitem.Purchaseitemstatus <> PurchaseItemsStatus.REQUESTED.ToString()) OrElse
                oPurchaseitem.Purchaseitemtype = PurchaseItemType.DIRECT.ToString() Then
                    hideRibbonPage()
                End If
            Case PurchaseItemSourceType.RELABEL.ToString()
                disableControls()
                If (oPurchaseitem.Purchaseitemstatus <> PurchaseItemsStatus.PENDING.ToString() AndAlso
                oPurchaseitem.Purchaseitemstatus <> PurchaseItemsStatus.REQUESTED.ToString()) OrElse
                oPurchaseitem.Purchaseitemtype = PurchaseItemType.DIRECT.ToString() Then
                    hideRibbonPage(IIf((oPurchaseitem.Purchaseitemstatus = PurchaseItemsStatus.PENDING.ToString() OrElse
                                    oPurchaseitem.Purchaseitemstatus = PurchaseItemsStatus.REQUESTED.ToString()) AndAlso
                                oPurchaseitem.Purchaseitemtype <> PurchaseItemType.DIRECT.ToString(), True, False))
                End If
            Case Else
                hideRibbonPage()
                'If (oPurchaseitem.Purchaseitemstatus <> PurchaseItemsStatus.PENDING.ToString() AndAlso
                'oPurchaseitem.Purchaseitemstatus <> PurchaseItemsStatus.REQUESTED.ToString()) Then
                '    disableControls()
                'End If
                If (oPurchaseitem.Purchaseitemstatus = "CANCELLED") Then
                    disableControls()
                End If
        End Select

        If bsPurchaseItem.Count > 0 Then
            If Not bsPurchaseItem.Current.PURCHASENUMBER Is Nothing Then
                RibbonPage7.Visible = True
            End If
        End If

        If vEditType = "READONLY" Then
            diableScreenObjects()
        End If

        If vEditType = "EDIT" Then
            ItemIDLookUpEdit.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub diableScreenObjects()
        disableControls()
        disableButtons()

        NeededbyDateEdit.Enabled = False
        ExpectedInDateEdit.Enabled = False

    End Sub

    Private Sub disableControls()
        QtyTextEdit.Properties.ReadOnly = True
        UCTextEdit.Properties.ReadOnly = True
        ItemTypeLookUpEdit.Properties.ReadOnly = True
        ItemIDLookUpEdit.Properties.ReadOnly = True
        CustomerLookUpEdit.Properties.ReadOnly = True
        UnitTextEdit.Properties.ReadOnly = True
        UOMTextEdit.Properties.ReadOnly = True
        UnitCostTextEdit.Properties.ReadOnly = True
        eVendorItemNumber.Properties.ReadOnly = True
    End Sub

    Private Sub disableButtons()
        btnSave.Enabled = False
        btnSelect.Enabled = False
        btnNewCostRecord.Enabled = False
        btnEditCostRecord.Enabled = False
        btnDeleteCostRecord.Enabled = False
        rbtnAllocateItem.Enabled = False
        rbtnAddNewRelabelOrder.Enabled = False
        rbtnCancelRelabelOrder.Enabled = False
        rbtnReAllocateItem.Enabled = False
        rbtnAddNewProductionOrder2.Enabled = False
        rbtnEditProductionOrder2.Enabled = False
        rbtnCancelProductionOrder2.Enabled = False
        btnChangeInventoryClass.Enabled = False
    End Sub

    Private Sub hideRibbonPage(Optional vShowAvailableInventory As Boolean = False)
        RibbonPage2.Visible = vShowAvailableInventory
        RibbonPage3.Visible = False
        RibbonPage4.Visible = False
        RibbonPage5.Visible = False
        RibbonPage8.Visible = False
    End Sub

    Private Sub rbtnSearchInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSearchInventory.ItemClick
        getAvailableInventoryItems()
    End Sub

    Private Sub getAvailableInventoryItems()
        Dim oAvailableInventory As ViewInvItemDetailsCollection
        If (vEditType = "ADD") Then
            Exit Sub
        End If
        If IsNothing(bsPurchaseItem.Current) Then
            Exit Sub
        End If

        oAvailableInventory = getAvailableInventory(bsPurchaseItem.Current.Itemid)
        bsAvailableInventory.DataSource = oAvailableInventory
    End Sub

    Private Function getSeletedItems(gvGridView As CustomDevExGridView) As ViewInvItemDetailsCollection
        Dim oSelectedItems As New ViewInvItemDetailsCollection
        Dim vIndex As Integer = 0
        Dim vInvitemnumber As New StringBuilder

        For vIndex = 0 To gvGridView.SelectedRowsCount - 1
            vInvitemnumber.Append(gvGridView.GetRowCellValue(gvGridView.GetSelectedRows.GetValue(vIndex),
                                    gvGridView.Columns(0))).Append(IIf(vIndex = (gvGridView.SelectedRowsCount - 1), String.Empty, "','"))
        Next

        oSelectedItems.Query.Where(oSelectedItems.Query.Invitemnumber.In(vInvitemnumber.ToString()),
                                   oSelectedItems.Query.Or(oSelectedItems.Query.Allocatedtype.IsNull,
                                                    oSelectedItems.Query.Allocatedtype.Equal(AllocatedType.WORKORDER.ToString())),
                                   oSelectedItems.Query.Or(oSelectedItems.Query.Allocateddocument.IsNull,
                                                    oSelectedItems.Query.Allocateddocument.NotEqual(oPurchaseitem.Sourcedocument)))
        oSelectedItems.Query.Load()

        Return oSelectedItems
    End Function

    Private Sub rbtnAllocateItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAllocateItem.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Dim oSelectedAvailableInventory As New ViewInvItemDetailsCollection
        Dim vQty As Integer
        If bsPurchaseItem.Current.Qty = 0 Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        'get list of selected items from the grid
        oSelectedAvailableInventory = getSeletedItems(AvailableInventory)

        If oSelectedAvailableInventory.Count = 0 Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        vQty = bsPurchaseItem.Current.Qty - oSelectedAvailableInventory.Count

        allocateInventoryItems(oPurchaseitem.Sourcetype, _
                               oPurchaseitem.Purchaseitemid, _
                               oSelectedAvailableInventory)

        updatePurchaseItem(bsPurchaseItem.Current.Purchaseitemid, _
                           vQty)

        getAvailableInventoryItems()

        'Refresh the form to display the pending qty
        refreshPurchaseItemDetails()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub getAllocatedInventoryItems()
        Dim oAllocateInventory As ViewInvItemDetailsCollection
        If Not oPurchaseitem.Sourcetype Is Nothing AndAlso _
            oPurchaseitem.Sourcetype = PurchaseItemSourceType.WORKORDER.ToString() Then
            oAllocateInventory = getAllocatedInventory(bsPurchaseItem.Current.Itemid, oPurchaseitem.Sourcedocument, oPurchaseitem.Sourcetype)
            bsAllocatedInventory.DataSource = oAllocateInventory
        End If
    End Sub

    Private Sub rbtnAllocatedSearchInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAllocatedSearchInventory.ItemClick
        getAllocatedInventoryItems()
    End Sub

    Private Sub rbtnGetProductionOrders2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetProductionOrders2.ItemClick
        If Not oPurchaseitem.Sourcetype Is Nothing AndAlso _
            oPurchaseitem.Sourcetype = PurchaseItemSourceType.WORKORDER.ToString() AndAlso _
            bsPurchaseItem.Current.ItemID > 0 Then
            refreshProdOrderTab(oPurchaseitem.Sourcedocument, bsPurchaseItem.Current.ItemID)
        End If
    End Sub

    Private Sub rbtnAddNewProductionOrder2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewProductionOrder2.ItemClick
        addNewProdOrder()
    End Sub

    Private Sub rbtnEditProductionOrder2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditProductionOrder2.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If
        editProdOrder(bsProdOrders.Current.ProdOrderNum)
    End Sub


    Private Sub rbtnPrintProductionOrder2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintProductionOrder2.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If
        printProdOrder(bsProdOrders.Current.ProdOrderNum)
    End Sub

    Private Sub addNewProdOrder()
        Dim vWorkOrder As Workorder
        Dim vWOItems As WorkorderitemCollection
        Dim oProdOrder As Prodorder

        vWOItems = getWorkOrderItemsByPurchaseItemID(bsPurchaseItem.Current.PURCHASEITEMID)
        If vWOItems.Count > 0 Then
            vWorkOrder = getWorkOrder(vWOItems(0).Workordernumber)
            oProdOrder = createAndAssignProductionOrders(vWorkOrder, vWOItems, bsPurchaseItem.Current.ItemID)

            If (Not oProdOrder Is Nothing) Then
                updatePurchaseItem(bsPurchaseItem.Current.PURCHASEITEMID, 0, PurchaseItemsStatus.FULFILLED.ToString())
                refreshProdOrderTab(vWOItems(0).Workordernumber, bsPurchaseItem.Current.ItemID)
                Dim frm As New frmAddEditProdOrder
                frm.vID = oProdOrder.Prodordernum
                frm.vEditType = "EDIT"
                frm.vProductID = vWOItems(0).Productid
                frm.vWorkOrderID = vWOItems(0).Workordernumber
                frm.vFrmSource = "PURCHASEITEM"
                frm.ShowDialog()
            End If

        End If

        refreshPurchaseItemDetails()
    End Sub

    Private Sub editProdOrder(vProdOrderNum As Integer)
        Dim frm As New frmAddEditProdOrder
        frm.vEditType = "EDIT"
        frm.vID = vProdOrderNum
        frm.vProductID = bsPurchaseItem.Current.ItemID
        frm.vWorkOrderID = oPurchaseitem.Sourcedocument
        frm.vFrmSource = "WorkOrder"
        frm.ShowDialog()
        refreshProdOrderTab(oPurchaseitem.Sourcedocument, bsPurchaseItem.Current.ItemID)
    End Sub

    Private Function ValidateControls() As Boolean
        If oPurchaseitem.Sourcetype Is Nothing OrElse _
            IsDBNull(oPurchaseitem.Sourcetype) OrElse _
            String.IsNullOrEmpty(oPurchaseitem.Sourcetype) Then
            If Convert.ToString(ItemTypeLookUpEdit.EditValue).ToUpper() = "PRODUCT" Then
                If validateControl("Qty", QtyTextEdit, ControlType.Numeric) = False Then
                    Return False
                End If

                If validateControl("U/C", UCTextEdit, ControlType.Text) = False Then
                    Return False
                End If

                If validateControl("Item ID", ItemIDLookUpEdit, ControlType.Numeric) = False Then
                    Return False
                End If

                If validateControl("Item description", ItemDescTextEdit, ControlType.Text) = False Then
                    Return False
                End If

                If Not oPurchase Is Nothing AndAlso _
                    oPurchase.Purchasenumber > 0 Then
                    'Check that vendor and cost fields are filled
                    If validateControl("Cost", UnitCostTextEdit, ControlType.Numeric) = False Then
                        Return False
                    End If
                End If

                'If validateControl("Needed by Date", NeededbyDateEdit, ControlType.DatePicker) = False Then
                '    Return False
                'End If

                'If validateControl("Expected In Date", ExpectedInDateEdit, ControlType.DatePicker) = False Then
                '    Return False
                'End If
            End If
        End If
        Return True
    End Function

    Private Sub LoadProductCostRecords()
        setControlSource()
        getProductCostData()
    End Sub

    Private Sub setControlSource()
        Dim oProduct As New Product
        oProduct.LoadByPrimaryKey(ItemIDLookUpEdit.EditValue)

        If oProduct Is Nothing Then
            Exit Sub
        End If

        bsProduct1.DataSource = oProduct
        'lblproductInfo.Text = oProduct.Productid & " - " & oProduct.Productdesc & " - " & oProduct.Container
        bTxtVolumeUnits.Caption = IIf(IsDBNull(oProduct.Volumeunits), DBNull.Value, oProduct.Volumeunits)
        bTxtVolumeUOM.Caption = IIf(IsDBNull(oProduct.Volumeuom), DBNull.Value, oProduct.Volumeuom)
        bTxtlVolumeStandardCost.Caption = IIf(IsDBNull(oProduct.Volumestandardcost), DBNull.Value, oProduct.Volumestandardcost)
        bTxtWeightUnits.Caption = IIf(IsDBNull(oProduct.Weightunits), DBNull.Value, oProduct.Weightunits)
        bTxtWeightUOM.Caption = IIf(IsDBNull(oProduct.Weightuom), DBNull.Value, oProduct.Weightuom)
        bTxtWeightStandardCost.Caption = IIf(IsDBNull(oProduct.Weightstandardcost), DBNull.Value, oProduct.Weightstandardcost)
    End Sub

    Private Sub getProductCostData()
        oCosts = getProductCostDataCollectionsByProductID(ItemIDLookUpEdit.EditValue)
        bs.DataSource = oCosts
        grProductCosts.DataSource = bs
        grProductCosts.Refresh()
    End Sub

    Private Sub btnNewCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewCostRecord.ItemClick
        If ItemIDLookUpEdit.EditValue Is Nothing OrElse _
            IsDBNull(ItemIDLookUpEdit.EditValue) OrElse _
            ItemIDLookUpEdit.EditValue <= 0 Then
            MsgBox("There is no Item ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        AddNewCostRecord(ItemIDLookUpEdit.EditValue)
        getProductCostData()
    End Sub

    Private Sub btnEditCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditCostRecord.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If
        EditCostRecord(bs.Current.productID, bs.Current.costRecID)
        getProductCostData()

    End Sub

    Private Sub btnDeleteCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteCostRecord.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If
        If bs.Count = 1 Then
            MsgBox("You cannot delete the only cost record for a product. Edit the existing cost record or add a new cost record.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        DeleteCostRecord(bs.Current.costRecID)
        getProductCostData()
    End Sub

    Private Sub btnSelect_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelect.ItemClick
        If oCosts.Count <= 0 Then
            Exit Sub
        End If
        oCost = New Productcost
        oCost.LoadByPrimaryKey(bs.Current.costRecID)
        If oCost Is Nothing Then
            Exit Sub
        End If
        If (oPurchaseitem.Purchaseitemstatus = PurchaseItemsStatus.CANCELLED.ToString()) Then
            Exit Sub
        End If
        If (Not oPurchase Is Nothing AndAlso _
            oPurchase.Vendorid > 0 AndAlso _
            oCost.Vendorid <> oPurchase.Vendorid) Then
            MsgBox("Selected product cost is for a different vendor. Please select valid product cost.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        setProductCost(bs.Current.costRecID)
    End Sub

    Private Sub rbtnReAllocateItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReAllocateItem.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Dim oSelectedAllocatedInventory As New ViewInvItemDetailsCollection

        If bsPurchaseItem.Current.Qty = 0 Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        'get list of selected items from the grid
        oSelectedAllocatedInventory = getSeletedItems(gvAllocatedInventory)

        reAllocateInventoryItems(bsPurchaseItem.Current.PURCHASEITEMID, _
                                 oSelectedAllocatedInventory, _
                                 oPurchaseitem.Sourcetype)

        getAllocatedInventoryItems()

        'Refresh the form to display the pending qty
        refreshPurchaseItemDetails()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ItemIDLookUpEdit_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles ItemIDLookUpEdit.Properties.EditValueChanged
        If IsDBNull(ItemIDLookUpEdit.EditValue) Then
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        fillItemDetails(ItemIDLookUpEdit.EditValue, True)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub fillItemDetails(vProductID As Integer, Optional vSelectCost As Boolean = False)

        Dim oProductCost As New ProductcostCollection
        Dim oProduct = New Product

        If vIsNotPageLoad Then
            oProduct.LoadByPrimaryKey(ItemIDLookUpEdit.EditValue)
            bsPurchaseItem.Current.Itemid = ItemIDLookUpEdit.EditValue
            bsPurchaseItem.Current.itemDescription = oProduct.Productdesc
            bsPurchaseItem.Current.container = oProduct.Container
            setProductCost(0)

            If vEditType <> "ADD" OrElse vSelectCost Then
                If Not oPurchase Is Nothing AndAlso _
                    oPurchase.Purchasenumber > 0 Then
                    bsPurchaseItem.Current.VENDORID = oPurchase.Vendorid
                    bsVendorItem.DataSource = getVendorByVendorID(oPurchase.Vendorid)
                    oProductCost = getActiveProductCosts(ItemIDLookUpEdit.EditValue, oPurchase.Vendorid)
                Else
                    oProductCost = getActiveProductCosts(ItemIDLookUpEdit.EditValue)
                End If

                If oProductCost.Count = 1 Then
                    setProductCost(oProductCost(0).Costrecid)
                End If
            End If

            bsPurchaseItem.EndEdit()
            bsPurchaseItem.ResetBindings(True)
        End If

        getAllocatedInventoryItems()
        getAvailableInventoryItems()

        If Not oPurchaseitem.Sourcetype Is Nothing AndAlso _
            oPurchaseitem.Sourcetype = PurchaseItemSourceType.WORKORDER.ToString() Then
            refreshProdOrderTab(oPurchaseitem.Sourcedocument, bsPurchaseItem.Current.ItemID)
        End If

        LoadProductCostRecords()
        setProductionOrderOptions(ItemIDLookUpEdit.EditValue)
    End Sub

    Private Sub ItemTypeLookUpEdit_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles ItemTypeLookUpEdit.Properties.EditValueChanged
        If IsDBNull(ItemTypeLookUpEdit.EditValue) Then
            Exit Sub
        End If

        If ItemTypeLookUpEdit.EditValue <> "PRODUCT" Then
            MsgBox("This item type is not yet available", MsgBoxStyle.Information, "Warning")
            ItemTypeLookUpEdit.EditValue = "PRODUCT"
            Exit Sub
        End If

    End Sub

    Private Sub loadPendingInventoryItems()
        If Not bsPurchaseItem.Current.PURCHASENUMBER Is Nothing Then
            bsInventoryItems.DataSource = getInvItems(bsPurchaseItem.Current.PURCHASEITEMID, SourceType.PRCH.ToString(), _
                                                      PurchaseItemsStatus.PENDING.ToString())
        End If
    End Sub

    Private Sub btnChangeInventoryClass_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChangeInventoryClass.ItemClick

        If (inventoryConversionAllowed()) Then
            If (vInventoryItemNumbers.Count <= 0) Then
                Exit Sub
            End If

            Using frm As New frmConvertInventory() With
              {
                    .vIDs = vInventoryItemNumbers
              }
                frm.ShowDialog()
            End Using
            loadPendingInventoryItems()
        End If
    End Sub

    Private Function inventoryConversionAllowed() As Boolean

        If (bsInventoryItems Is Nothing) Then
            Return False
        End If

        If bsInventoryItems.Count = 0 Then
            Return False
        End If

        vInventoryItemNumbers = New List(Of Integer)
        Dim vIndex As Integer = 0
        For vIndex = 0 To grvInventoryItems.SelectedRowsCount - 1
            If (grvInventoryItems.GetRowCellValue( _
                    grvInventoryItems.GetSelectedRows.GetValue(vIndex), _
                    grvInventoryItems.Columns("Itemstatus") _
                ) = PurchaseItemsStatus.RECEIVED.ToString()) Then
                MsgBox("You cannot change the inventory class of selected inventory items because one or more selected inventory items are already received.", _
                       vbCritical, _
                       "Error")
                Return False
            End If
            vInventoryItemNumbers.Add(grvInventoryItems.GetRowCellValue( _
                    grvInventoryItems.GetSelectedRows.GetValue(vIndex), _
                    grvInventoryItems.Columns("Invitemnumber")
                ))
        Next
        Return True
    End Function

    Private Sub rbtnCancelProductionOrder2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancelProductionOrder2.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If

        Dim str As String = "Are you sure you want to cancel the selected Production Order?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        cancelProdOrder(bsProdOrders.Current.ProdOrderNum)
        refreshProdOrderTab(oPurchaseitem.Sourcedocument, bsPurchaseItem.Current.ItemID)
    End Sub

    Private Sub refreshProdOrderTab(vWorkOrderID As Integer, vProductID As Integer)
        Dim oProdOrders As ViewProdOrderDataCollection
        oProdOrders = getViewProductionOrderData(vWorkOrderID, vProductID)
        bsProdOrders.DataSource = oProdOrders

        Dim oCanceledProdOrders = getViewProductionOrderData(vWorkOrderID, vProductID, True)
        bsCanceledProdOrders.DataSource = oCanceledProdOrders

        rbtnCancelProductionOrder2.Enabled = IIf((Not oProdOrders Is Nothing AndAlso _
                                                      oProdOrders.Count > 0 AndAlso _
                                                      vEditType <> "READONLY"), True, False)
        rbtnEditProductionOrder2.Enabled = rbtnCancelProductionOrder2.Enabled
    End Sub

    Private Sub rbtnAddNewRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewRelabelOrder.ItemClick
        addNewRelabelOrder()
    End Sub

    Private Sub addNewRelabelOrder()
        If createRelabelOrder(bsPurchaseItem.Current.PURCHASEITEMID) = True Then
            refreshRelabelOrderTab(oPurchaseitem.Sourcedocument, _
                                   bsPurchaseItem.Current.ItemID)
            refreshPurchaseItemDetails()
        End If
    End Sub

    Private Sub refreshRelabelOrderTab(vWorkOrderid As Integer, vProductID As Integer)
        oRelabelOrders = getRelabelOrders(vWorkOrderid, vProductID)
        bsRelabelOrders.DataSource = oRelabelOrders

        Dim oCanceledRelabelOrders = getRelabelOrders(vWorkOrderid, vProductID, True)
        bsCanceledRelabelOrders.DataSource = oCanceledRelabelOrders

        setRelabelOrderOptions(vProductID)
    End Sub

    Private Sub rbtnGetRelabelOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetRelabelOrders.ItemClick
        If Not oPurchaseitem.Sourcetype Is Nothing AndAlso _
            oPurchaseitem.Sourcetype = PurchaseItemSourceType.WORKORDER.ToString() AndAlso _
            bsPurchaseItem.Current.ItemID > 0 Then
            refreshRelabelOrderTab(oPurchaseitem.Sourcedocument, bsPurchaseItem.Current.ItemID)
        End If
    End Sub

    Private Sub rbtnPrintRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintRelabelOrder.ItemClick
        If bsRelabelOrders.Count <= 0 Then
            Exit Sub
        End If

        printRelabelOrder(bsRelabelOrders.Current.Relabelordernumber)
    End Sub

    Private Sub rbtnCancelRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancelRelabelOrder.ItemClick
        If bsRelabelOrders.Count <= 0 Then
            Exit Sub
        End If

        Dim str As String = "Are you sure you want to cancel the selected Relabel Order?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        cancelRelabelOrderAndItems(bsRelabelOrders.Current.Relabelordernumber)
        refreshRelabelOrderTab(oPurchaseitem.Sourcedocument, bsPurchaseItem.Current.ItemID)
    End Sub

    Private Sub refreshPurchaseItemDetails()
        bsPurchaseItem.DataSource = getPurchaseItem(vID)
        bsPurchaseItem.EndEdit()
        bsPurchaseItem.ResetBindings(True)
    End Sub

    Private Sub setRelabelOrderOptions(vProductID As Integer)
        Dim vIsRelabelOrderExist As Boolean
        rbtnAddNewRelabelOrder.Enabled = IIf(checkProductFulfillment(vProductID, FulfillmentType.RLBL) = True AndAlso _
                                            bsPurchaseItem.Current.Qty > 0 AndAlso _
                                            vEditType <> "READONLY", True, False)

        If bsRelabelOrders.Count > 0 Then
            If Not oRelabelOrders Is Nothing OrElse _
                oRelabelOrders.Count > 0 Then
                vIsRelabelOrderExist = IIf((checkProductFulfillment(vProductID, FulfillmentType.RLBL) = True AndAlso _
                                              bsRelabelOrders.Current.RELABELORDERSTATUS <> RelabelOrderStatus.CANCELLED.ToString() AndAlso _
                                              bsRelabelOrders.Current.RELABELORDERSTATUS <> RelabelOrderStatus.COMPLETED.ToString()), True, False)
            End If
        End If

        rbtnCancelRelabelOrder.Enabled = IIf(vEditType = "READONLY", False, vIsRelabelOrderExist)
        rbtnPrintRelabelOrder.Enabled = vIsRelabelOrderExist
    End Sub

    Private Sub grvRelabelOrders_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvRelabelOrders.FocusedRowChanged
        setRelabelOrderOptions(bsPurchaseItem.Current.ItemID)
    End Sub

End Class

