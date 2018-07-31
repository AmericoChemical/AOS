<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditProductItem

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
        Dim UnitorcontainerLabel As System.Windows.Forms.Label
        Dim BillableLabel As System.Windows.Forms.Label
        Dim CustomerpoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim UomPriceLabel As System.Windows.Forms.Label
        Dim UnitStdCostLabel As System.Windows.Forms.Label
        Dim UomStdCostLabel As System.Windows.Forms.Label
        Dim StdCostLabel As System.Windows.Forms.Label
        Dim UnitActualCostLabel As System.Windows.Forms.Label
        Dim UomActualCostLabel As System.Windows.Forms.Label
        Dim ActualCostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditProductItem))
        Me.bsPrice = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProduct = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.eUC = New DevExpress.XtraEditors.TextEdit()
        Me.eBillable = New DevExpress.XtraEditors.CheckEdit()
        Me.bsProductCosts = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetAllProducts = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditAll = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRecalcPricingCosting = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.CustomerpoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eCustomerName = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.eCustItemId = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtPriceCost = New DevExpress.XtraEditors.TextEdit()
        ProductidLabel = New System.Windows.Forms.Label()
        QtycontainersLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        UnitorcontainerLabel = New System.Windows.Forms.Label()
        BillableLabel = New System.Windows.Forms.Label()
        CustomerpoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        UnitPriceLabel = New System.Windows.Forms.Label()
        UomPriceLabel = New System.Windows.Forms.Label()
        UnitStdCostLabel = New System.Windows.Forms.Label()
        UomStdCostLabel = New System.Windows.Forms.Label()
        StdCostLabel = New System.Windows.Forms.Label()
        UnitActualCostLabel = New System.Windows.Forms.Label()
        UomActualCostLabel = New System.Windows.Forms.Label()
        ActualCostLabel = New System.Windows.Forms.Label()
        CType(Me.bsPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eBillable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eCustomerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.eCustItemId.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtPriceCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(119, 26)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(44, 13)
        ProductidLabel.TabIndex = 2
        ProductidLabel.Text = "Product"
        '
        'QtycontainersLabel
        '
        QtycontainersLabel.AutoSize = True
        QtycontainersLabel.Location = New System.Drawing.Point(5, 25)
        QtycontainersLabel.Name = "QtycontainersLabel"
        QtycontainersLabel.Size = New System.Drawing.Size(49, 13)
        QtycontainersLabel.TabIndex = 0
        QtycontainersLabel.Text = "Quantity"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(119, 65)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 7
        ContainerLabel.Text = "Container"
        '
        'UnitorcontainerLabel
        '
        UnitorcontainerLabel.AutoSize = True
        UnitorcontainerLabel.Location = New System.Drawing.Point(84, 26)
        UnitorcontainerLabel.Name = "UnitorcontainerLabel"
        UnitorcontainerLabel.Size = New System.Drawing.Size(25, 13)
        UnitorcontainerLabel.TabIndex = 1
        UnitorcontainerLabel.Text = "U/C"
        '
        'BillableLabel
        '
        BillableLabel.AutoSize = True
        BillableLabel.Location = New System.Drawing.Point(5, 66)
        BillableLabel.Name = "BillableLabel"
        BillableLabel.Size = New System.Drawing.Size(39, 13)
        BillableLabel.TabIndex = 4
        BillableLabel.Text = "Billable"
        '
        'CustomerpoLabel
        '
        CustomerpoLabel.AutoSize = True
        CustomerpoLabel.Location = New System.Drawing.Point(84, 66)
        CustomerpoLabel.Name = "CustomerpoLabel"
        CustomerpoLabel.Size = New System.Drawing.Size(110, 13)
        CustomerpoLabel.TabIndex = 6
        CustomerpoLabel.Text = "Customer PO Number"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(84, 24)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(83, 13)
        Label2.TabIndex = 1
        Label2.Text = "Customer Name"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(5, 24)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(63, 13)
        Label3.TabIndex = 0
        Label3.Text = "Work Order"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(5, 64)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(89, 13)
        Label4.TabIndex = 6
        Label4.Text = "Customer Item #"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(5, 77)
        Label10.Name = "Label10"
        Label10.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Label10.Size = New System.Drawing.Size(48, 16)
        Label10.TabIndex = 11
        Label10.Text = "Act Cost"
        Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(5, 53)
        Label9.Name = "Label9"
        Label9.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Label9.Size = New System.Drawing.Size(48, 18)
        Label9.TabIndex = 7
        Label9.Text = "Std Cost"
        Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(5, 28)
        Label8.Name = "Label8"
        Label8.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Label8.Size = New System.Drawing.Size(30, 16)
        Label8.TabIndex = 3
        Label8.Text = "Price"
        '
        'Label7
        '
        Label7.Location = New System.Drawing.Point(279, 2)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(67, 13)
        Label7.TabIndex = 2
        Label7.Text = "$"
        Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Label6.Location = New System.Drawing.Point(207, 2)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(64, 13)
        Label6.TabIndex = 1
        Label6.Text = "UOM"
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Label5.Location = New System.Drawing.Point(117, 2)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(80, 13)
        Label5.TabIndex = 0
        Label5.Text = "UNITS"
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrice, "Priceunits", True))
        UnitPriceLabel.Location = New System.Drawing.Point(117, 28)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(80, 23)
        UnitPriceLabel.TabIndex = 4
        UnitPriceLabel.Text = "0"
        UnitPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'bsPrice
        '
        Me.bsPrice.DataSource = GetType(AOS.BusinessObjects.ViewWorkOrderItemPricing)
        '
        'UomPriceLabel
        '
        UomPriceLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrice, "Priceuom", True))
        UomPriceLabel.Location = New System.Drawing.Point(207, 28)
        UomPriceLabel.Name = "UomPriceLabel"
        UomPriceLabel.Size = New System.Drawing.Size(64, 23)
        UomPriceLabel.TabIndex = 5
        UomPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UnitStdCostLabel
        '
        UnitStdCostLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrice, "Standardcostunits", True))
        UnitStdCostLabel.Location = New System.Drawing.Point(117, 53)
        UnitStdCostLabel.Name = "UnitStdCostLabel"
        UnitStdCostLabel.Size = New System.Drawing.Size(80, 22)
        UnitStdCostLabel.TabIndex = 8
        UnitStdCostLabel.Text = "0"
        UnitStdCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UomStdCostLabel
        '
        UomStdCostLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrice, "Standardcostuom", True))
        UomStdCostLabel.Location = New System.Drawing.Point(207, 53)
        UomStdCostLabel.Name = "UomStdCostLabel"
        UomStdCostLabel.Size = New System.Drawing.Size(64, 22)
        UomStdCostLabel.TabIndex = 9
        UomStdCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StdCostLabel
        '
        StdCostLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrice, "Standardunitcost", True))
        StdCostLabel.Location = New System.Drawing.Point(279, 53)
        StdCostLabel.Name = "StdCostLabel"
        StdCostLabel.Size = New System.Drawing.Size(67, 22)
        StdCostLabel.TabIndex = 10
        StdCostLabel.Text = "0"
        StdCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UnitActualCostLabel
        '
        UnitActualCostLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrice, "Actualcostunits", True))
        UnitActualCostLabel.Location = New System.Drawing.Point(117, 77)
        UnitActualCostLabel.Name = "UnitActualCostLabel"
        UnitActualCostLabel.Size = New System.Drawing.Size(80, 21)
        UnitActualCostLabel.TabIndex = 12
        UnitActualCostLabel.Text = "0"
        UnitActualCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UomActualCostLabel
        '
        UomActualCostLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrice, "Actualcostuom", True))
        UomActualCostLabel.Location = New System.Drawing.Point(207, 77)
        UomActualCostLabel.Name = "UomActualCostLabel"
        UomActualCostLabel.Size = New System.Drawing.Size(64, 21)
        UomActualCostLabel.TabIndex = 13
        UomActualCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ActualCostLabel
        '
        ActualCostLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPrice, "Actualunitcost", True))
        ActualCostLabel.Location = New System.Drawing.Point(279, 77)
        ActualCostLabel.Name = "ActualCostLabel"
        ActualCostLabel.Size = New System.Drawing.Size(67, 21)
        ActualCostLabel.TabIndex = 14
        ActualCostLabel.Text = "0"
        ActualCostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProduct
        '
        Me.eProduct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Itemid", True))
        Me.eProduct.Location = New System.Drawing.Point(119, 42)
        Me.eProduct.Name = "eProduct"
        Me.eProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", 100, "Addn Desc"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProduct.Properties.DataSource = Me.bsProducts
        Me.eProduct.Properties.DisplayMember = "Productid"
        Me.eProduct.Properties.NullText = ""
        Me.eProduct.Properties.PopupWidth = 400
        Me.eProduct.Properties.ValueMember = "Productid"
        Me.eProduct.Size = New System.Drawing.Size(54, 20)
        Me.eProduct.TabIndex = 5
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Workorderitem)
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'eQty
        '
        Me.eQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Qty", True))
        Me.eQty.Location = New System.Drawing.Point(5, 41)
        Me.eQty.Name = "eQty"
        Me.eQty.Properties.Appearance.Options.UseTextOptions = True
        Me.eQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eQty.Size = New System.Drawing.Size(61, 20)
        Me.eQty.TabIndex = 3
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(119, 80)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(78, 20)
        Me.eContainer.TabIndex = 9
        Me.eContainer.TabStop = False
        '
        'eUC
        '
        Me.eUC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Unitorcontainer", True))
        Me.eUC.Location = New System.Drawing.Point(84, 42)
        Me.eUC.Name = "eUC"
        Me.eUC.Properties.Mask.EditMask = "U|C"
        Me.eUC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.eUC.Properties.Mask.ShowPlaceHolders = False
        Me.eUC.Size = New System.Drawing.Size(27, 20)
        Me.eUC.TabIndex = 4
        '
        'eBillable
        '
        Me.eBillable.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Billable", True))
        Me.eBillable.Location = New System.Drawing.Point(50, 63)
        Me.eBillable.Name = "eBillable"
        Me.eBillable.Properties.Caption = ""
        Me.eBillable.Size = New System.Drawing.Size(24, 19)
        Me.eBillable.TabIndex = 5
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.rbtnGetAllProducts, Me.btnEditAll, Me.btnRecalcPricingCosting})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 9
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(364, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save Changes"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 5
        Me.btnSave.LargeWidth = 60
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Changes"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 6
        Me.btnCancel.LargeWidth = 60
        Me.btnCancel.Name = "btnCancel"
        '
        'rbtnGetAllProducts
        '
        Me.rbtnGetAllProducts.Caption = "Show All Products"
        Me.rbtnGetAllProducts.Id = 6
        Me.rbtnGetAllProducts.LargeImageIndex = 7
        Me.rbtnGetAllProducts.Name = "rbtnGetAllProducts"
        '
        'btnEditAll
        '
        Me.btnEditAll.Caption = "Edit All"
        Me.btnEditAll.Id = 7
        Me.btnEditAll.LargeImageIndex = 3
        Me.btnEditAll.Name = "btnEditAll"
        '
        'btnRecalcPricingCosting
        '
        Me.btnRecalcPricingCosting.Caption = "Recalc Pricing && Costing"
        Me.btnRecalcPricingCosting.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.btnRecalcPricingCosting.Id = 8
        Me.btnRecalcPricingCosting.LargeImageIndex = 8
        Me.btnRecalcPricingCosting.Name = "btnRecalcPricingCosting"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1, Me.RibbonPageGroup3})
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
        Me.RibbonPageGroup2.Text = "Edit"
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
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnEditAll)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnRecalcPricingCosting, True)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Options"
        '
        'CustomerpoTextEdit
        '
        Me.CustomerpoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Customerpo", True))
        Me.CustomerpoTextEdit.Location = New System.Drawing.Point(199, 63)
        Me.CustomerpoTextEdit.MenuManager = Me.RibbonControl1
        Me.CustomerpoTextEdit.Name = "CustomerpoTextEdit"
        Me.CustomerpoTextEdit.Size = New System.Drawing.Size(160, 20)
        Me.CustomerpoTextEdit.TabIndex = 7
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Me.eCustomerName)
        Me.GroupControl1.Controls.Add(Me.eBillable)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(BillableLabel)
        Me.GroupControl1.Controls.Add(CustomerpoLabel)
        Me.GroupControl1.Controls.Add(Me.CustomerpoTextEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(0, 100)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(364, 95)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Work Order / Customer Info"
        '
        'eCustomerName
        '
        Me.eCustomerName.Location = New System.Drawing.Point(84, 40)
        Me.eCustomerName.Name = "eCustomerName"
        Me.eCustomerName.Properties.Appearance.Options.UseTextOptions = True
        Me.eCustomerName.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eCustomerName.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eCustomerName.Properties.ReadOnly = True
        Me.eCustomerName.Size = New System.Drawing.Size(275, 20)
        Me.eCustomerName.TabIndex = 3
        Me.eCustomerName.TabStop = False
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Workordernumber", True))
        Me.TextEdit1.Location = New System.Drawing.Point(5, 40)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(61, 20)
        Me.TextEdit1.TabIndex = 2
        Me.TextEdit1.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.eCustItemId)
        Me.GroupControl2.Controls.Add(Label4)
        Me.GroupControl2.Controls.Add(Me.eProduct)
        Me.GroupControl2.Controls.Add(ProductidLabel)
        Me.GroupControl2.Controls.Add(Me.eQty)
        Me.GroupControl2.Controls.Add(QtycontainersLabel)
        Me.GroupControl2.Controls.Add(Me.eContainer)
        Me.GroupControl2.Controls.Add(ContainerLabel)
        Me.GroupControl2.Controls.Add(Me.eUC)
        Me.GroupControl2.Controls.Add(UnitorcontainerLabel)
        Me.GroupControl2.Location = New System.Drawing.Point(0, 198)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(364, 112)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Product Details"
        '
        'eCustItemId
        '
        Me.eCustItemId.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custitemid", True))
        Me.eCustItemId.Location = New System.Drawing.Point(5, 80)
        Me.eCustItemId.Name = "eCustItemId"
        Me.eCustItemId.Properties.ReadOnly = True
        Me.eCustItemId.Size = New System.Drawing.Size(104, 20)
        Me.eCustItemId.TabIndex = 8
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.TextEdit2)
        Me.GroupControl3.Location = New System.Drawing.Point(0, 444)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(364, 105)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "Notes"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Itemnotes", True))
        Me.TextEdit2.Location = New System.Drawing.Point(5, 24)
        Me.TextEdit2.MenuManager = Me.RibbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(354, 76)
        Me.TextEdit2.TabIndex = 0
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupControl4.Location = New System.Drawing.Point(0, 314)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(364, 127)
        Me.GroupControl4.TabIndex = 2
        Me.GroupControl4.Text = "Pricing"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.44555!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.55445!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72.0!))
        Me.TableLayoutPanel1.Controls.Add(UnitPriceLabel, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Label5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Label6, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Label7, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Label8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Label9, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Label10, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(UomPriceLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(UnitStdCostLabel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(UomStdCostLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(StdCostLabel, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(UnitActualCostLabel, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(UomActualCostLabel, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(ActualCostLabel, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtPriceCost, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(8, 24)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(351, 100)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'txtPriceCost
        '
        Me.txtPriceCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Unitprice", True))
        Me.txtPriceCost.EditValue = ""
        Me.txtPriceCost.Location = New System.Drawing.Point(279, 31)
        Me.txtPriceCost.Name = "txtPriceCost"
        Me.txtPriceCost.Properties.Appearance.Options.UseTextOptions = True
        Me.txtPriceCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtPriceCost.Properties.DisplayFormat.FormatString = "c4"
        Me.txtPriceCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPriceCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtPriceCost.Properties.MaxLength = 18
        Me.txtPriceCost.Size = New System.Drawing.Size(66, 20)
        Me.txtPriceCost.TabIndex = 6
        '
        'frmAddEditProductItem
        '
        Me.ClientSize = New System.Drawing.Size(364, 551)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditProductItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Work Order Item Information - PRODUCT"
        CType(Me.bsPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eBillable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eCustomerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.eCustItemId.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txtPriceCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents eProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eBillable As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents bsProductCosts As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnGetAllProducts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CustomerpoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eCustomerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents eCustItemId As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtPriceCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsPrice As System.Windows.Forms.BindingSource
    Friend WithEvents btnEditAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRecalcPricingCosting As DevExpress.XtraBars.BarButtonItem
End Class
