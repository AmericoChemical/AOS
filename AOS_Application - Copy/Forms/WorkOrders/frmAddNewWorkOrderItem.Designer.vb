<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewWorkOrderItem

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim QtycontainersLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim UnitcostLabel As System.Windows.Forms.Label
        Dim ItempriceLabel As System.Windows.Forms.Label
        Dim UnitorcontainerLabel As System.Windows.Forms.Label
        Dim UnitsLabel As System.Windows.Forms.Label
        Dim UomLabel As System.Windows.Forms.Label
        Dim BillableLabel As System.Windows.Forms.Label
        Dim CustomerpoLabel As System.Windows.Forms.Label
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddNewWorkOrderItem))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProduct = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.eUnitCost = New DevExpress.XtraEditors.ButtonEdit()
        Me.eItemPrice = New DevExpress.XtraEditors.ButtonEdit()
        Me.eUC = New DevExpress.XtraEditors.TextEdit()
        Me.eUnits = New DevExpress.XtraEditors.TextEdit()
        Me.BillableCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.bsProductCosts = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetAllProducts = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.eUOM = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerpoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lblCustomerName = New DevExpress.XtraEditors.LabelControl()
        ProductidLabel = New System.Windows.Forms.Label()
        QtycontainersLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        UnitcostLabel = New System.Windows.Forms.Label()
        ItempriceLabel = New System.Windows.Forms.Label()
        UnitorcontainerLabel = New System.Windows.Forms.Label()
        UnitsLabel = New System.Windows.Forms.Label()
        UomLabel = New System.Windows.Forms.Label()
        BillableLabel = New System.Windows.Forms.Label()
        CustomerpoLabel = New System.Windows.Forms.Label()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eItemPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(123, 139)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(44, 13)
        ProductidLabel.TabIndex = 1
        ProductidLabel.Text = "Product"
        '
        'QtycontainersLabel
        '
        QtycontainersLabel.AutoSize = True
        QtycontainersLabel.Location = New System.Drawing.Point(10, 139)
        QtycontainersLabel.Name = "QtycontainersLabel"
        QtycontainersLabel.Size = New System.Drawing.Size(49, 13)
        QtycontainersLabel.TabIndex = 5
        QtycontainersLabel.Text = "Quantity"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(257, 181)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 6
        ContainerLabel.Text = "Container"
        '
        'UnitcostLabel
        '
        UnitcostLabel.AutoSize = True
        UnitcostLabel.Location = New System.Drawing.Point(10, 181)
        UnitcostLabel.Name = "UnitcostLabel"
        UnitcostLabel.Size = New System.Drawing.Size(51, 13)
        UnitcostLabel.TabIndex = 7
        UnitcostLabel.Text = "Unit Cost"
        '
        'ItempriceLabel
        '
        ItempriceLabel.AutoSize = True
        ItempriceLabel.Location = New System.Drawing.Point(10, 227)
        ItempriceLabel.Name = "ItempriceLabel"
        ItempriceLabel.Size = New System.Drawing.Size(52, 13)
        ItempriceLabel.TabIndex = 9
        ItempriceLabel.Text = "Unit Price"
        '
        'UnitorcontainerLabel
        '
        UnitorcontainerLabel.AutoSize = True
        UnitorcontainerLabel.Location = New System.Drawing.Point(84, 139)
        UnitorcontainerLabel.Name = "UnitorcontainerLabel"
        UnitorcontainerLabel.Size = New System.Drawing.Size(25, 13)
        UnitorcontainerLabel.TabIndex = 11
        UnitorcontainerLabel.Text = "U/C"
        '
        'UnitsLabel
        '
        UnitsLabel.AutoSize = True
        UnitsLabel.Location = New System.Drawing.Point(206, 181)
        UnitsLabel.Name = "UnitsLabel"
        UnitsLabel.Size = New System.Drawing.Size(31, 13)
        UnitsLabel.TabIndex = 13
        UnitsLabel.Text = "Units"
        '
        'UomLabel
        '
        UomLabel.AutoSize = True
        UomLabel.Location = New System.Drawing.Point(126, 181)
        UomLabel.Name = "UomLabel"
        UomLabel.Size = New System.Drawing.Size(30, 13)
        UomLabel.TabIndex = 15
        UomLabel.Text = "UOM"
        '
        'BillableLabel
        '
        BillableLabel.AutoSize = True
        BillableLabel.Location = New System.Drawing.Point(123, 227)
        BillableLabel.Name = "BillableLabel"
        BillableLabel.Size = New System.Drawing.Size(39, 13)
        BillableLabel.TabIndex = 20
        BillableLabel.Text = "Billable"
        '
        'CustomerpoLabel
        '
        CustomerpoLabel.AutoSize = True
        CustomerpoLabel.Location = New System.Drawing.Point(168, 227)
        CustomerpoLabel.Name = "CustomerpoLabel"
        CustomerpoLabel.Size = New System.Drawing.Size(110, 13)
        CustomerpoLabel.TabIndex = 24
        CustomerpoLabel.Text = "Customer PO Number"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProduct
        '
        Me.eProduct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productid", True))
        Me.eProduct.Location = New System.Drawing.Point(126, 155)
        Me.eProduct.Name = "eProduct"
        Me.eProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", 100, "Addn Desc"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProduct.Properties.DataSource = Me.bsProducts
        Me.eProduct.Properties.DisplayMember = "Productdesc"
        Me.eProduct.Properties.NullText = ""
        Me.eProduct.Properties.PopupWidth = 400
        Me.eProduct.Properties.ValueMember = "Productid"
        Me.eProduct.Size = New System.Drawing.Size(212, 20)
        Me.eProduct.TabIndex = 2
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Workorderitem)
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ViewPriceListProductsCollection)
        '
        'eQty
        '
        Me.eQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Qty", True))
        Me.eQty.Location = New System.Drawing.Point(12, 155)
        Me.eQty.Name = "eQty"
        Me.eQty.Properties.Appearance.Options.UseTextOptions = True
        Me.eQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eQty.Size = New System.Drawing.Size(58, 20)
        Me.eQty.TabIndex = 0
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(260, 197)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(78, 20)
        Me.eContainer.TabIndex = 7
        '
        'eUnitCost
        '
        Me.eUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Unitcost", True))
        Me.eUnitCost.Location = New System.Drawing.Point(13, 197)
        Me.eUnitCost.Name = "eUnitCost"
        Me.eUnitCost.Properties.Appearance.Options.UseTextOptions = True
        Me.eUnitCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eUnitCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Update", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.eUnitCost.Properties.DisplayFormat.FormatString = "c3"
        Me.eUnitCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eUnitCost.Size = New System.Drawing.Size(96, 20)
        Me.eUnitCost.TabIndex = 4
        '
        'eItemPrice
        '
        Me.eItemPrice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Itemprice", True))
        Me.eItemPrice.Location = New System.Drawing.Point(13, 243)
        Me.eItemPrice.Name = "eItemPrice"
        Me.eItemPrice.Properties.Appearance.Options.UseTextOptions = True
        Me.eItemPrice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eItemPrice.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Update", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, False)})
        Me.eItemPrice.Properties.DisplayFormat.FormatString = "c3"
        Me.eItemPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eItemPrice.Size = New System.Drawing.Size(96, 20)
        Me.eItemPrice.TabIndex = 5
        '
        'eUC
        '
        Me.eUC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Unitorcontainer", True))
        Me.eUC.Location = New System.Drawing.Point(82, 155)
        Me.eUC.Name = "eUC"
        Me.eUC.Properties.Mask.EditMask = "U|C"
        Me.eUC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.eUC.Properties.Mask.ShowPlaceHolders = False
        Me.eUC.Size = New System.Drawing.Size(27, 20)
        Me.eUC.TabIndex = 1
        '
        'eUnits
        '
        Me.eUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Units", True))
        Me.eUnits.Location = New System.Drawing.Point(209, 197)
        Me.eUnits.Name = "eUnits"
        Me.eUnits.Properties.ReadOnly = True
        Me.eUnits.Size = New System.Drawing.Size(45, 20)
        Me.eUnits.TabIndex = 14
        '
        'BillableCheckEdit
        '
        Me.BillableCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Billable", True))
        Me.BillableCheckEdit.EditValue = 0
        Me.BillableCheckEdit.Location = New System.Drawing.Point(132, 244)
        Me.BillableCheckEdit.Name = "BillableCheckEdit"
        Me.BillableCheckEdit.Properties.Caption = ""
        Me.BillableCheckEdit.Size = New System.Drawing.Size(24, 19)
        Me.BillableCheckEdit.TabIndex = 6
        '
        'bsProductCosts
        '
        Me.bsProductCosts.DataSource = GetType(AOS.BusinessObjects.ProductcostCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.rbtnGetAllProducts})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(356, 94)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save  Item"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 5
        Me.btnSave.LargeWidth = 50
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Item"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 6
        Me.btnCancel.LargeWidth = 50
        Me.btnCancel.Name = "btnCancel"
        '
        'rbtnGetAllProducts
        '
        Me.rbtnGetAllProducts.Caption = "Show All Products"
        Me.rbtnGetAllProducts.Id = 6
        Me.rbtnGetAllProducts.LargeImageIndex = 7
        Me.rbtnGetAllProducts.Name = "rbtnGetAllProducts"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnGetAllProducts)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Reference Data"
        '
        'eUOM
        '
        Me.eUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Uom", True))
        Me.eUOM.Location = New System.Drawing.Point(126, 197)
        Me.eUOM.Name = "eUOM"
        Me.eUOM.Properties.ReadOnly = True
        Me.eUOM.Size = New System.Drawing.Size(77, 20)
        Me.eUOM.TabIndex = 23
        '
        'CustomerpoTextEdit
        '
        Me.CustomerpoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Customerpo", True))
        Me.CustomerpoTextEdit.Location = New System.Drawing.Point(171, 243)
        Me.CustomerpoTextEdit.MenuManager = Me.RibbonControl1
        Me.CustomerpoTextEdit.Name = "CustomerpoTextEdit"
        Me.CustomerpoTextEdit.Size = New System.Drawing.Size(167, 20)
        Me.CustomerpoTextEdit.TabIndex = 25
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Location = New System.Drawing.Point(13, 100)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(52, 13)
        Me.lblCustomerName.TabIndex = 26
        Me.lblCustomerName.Text = "Cust Name"
        '
        'frmAddNewWorkOrderItem
        '
        Me.ClientSize = New System.Drawing.Size(356, 280)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(CustomerpoLabel)
        Me.Controls.Add(Me.CustomerpoTextEdit)
        Me.Controls.Add(Me.eUOM)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(BillableLabel)
        Me.Controls.Add(Me.BillableCheckEdit)
        Me.Controls.Add(UomLabel)
        Me.Controls.Add(UnitsLabel)
        Me.Controls.Add(Me.eUnits)
        Me.Controls.Add(UnitorcontainerLabel)
        Me.Controls.Add(Me.eUC)
        Me.Controls.Add(ItempriceLabel)
        Me.Controls.Add(Me.eItemPrice)
        Me.Controls.Add(UnitcostLabel)
        Me.Controls.Add(Me.eUnitCost)
        Me.Controls.Add(ContainerLabel)
        Me.Controls.Add(Me.eContainer)
        Me.Controls.Add(QtycontainersLabel)
        Me.Controls.Add(Me.eQty)
        Me.Controls.Add(ProductidLabel)
        Me.Controls.Add(Me.eProduct)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddNewWorkOrderItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Work Order Item Information - PRODUCT"
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eItemPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents eProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnitCost As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents eItemPrice As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents eUC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BillableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents bsProductCosts As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnGetAllProducts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CustomerpoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCustomerName As DevExpress.XtraEditors.LabelControl
End Class
