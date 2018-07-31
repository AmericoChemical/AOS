<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditPurchaseOrderItem

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
        Dim lblCost As System.Windows.Forms.Label
        Dim UnitorcontainerLabel As System.Windows.Forms.Label
        Dim UnitsLabel As System.Windows.Forms.Label
        Dim UomLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim PreparedbyLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim WeightuomLabel As System.Windows.Forms.Label
        Dim WeightunitsLabel As System.Windows.Forms.Label
        Dim VolumeuomLabel As System.Windows.Forms.Label
        Dim VolumeunitsLabel As System.Windows.Forms.Label
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditPurchaseOrderItem))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProduct = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPOItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.eCost = New DevExpress.XtraEditors.ButtonEdit()
        Me.eUC = New DevExpress.XtraEditors.TextEdit()
        Me.eUnits = New DevExpress.XtraEditors.TextEdit()
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
        Me.eVendorItemNumber = New DevExpress.XtraEditors.TextEdit()
        Me.PlannedshipdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.WeightTextStandardCost = New DevExpress.XtraEditors.TextEdit()
        Me.VolumeTextStandardCost = New DevExpress.XtraEditors.TextEdit()
        Me.WeightuomLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsUOMWeight = New System.Windows.Forms.BindingSource(Me.components)
        Me.WeightunitsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VolumeuomLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsUOMVolume = New System.Windows.Forms.BindingSource(Me.components)
        Me.VolumeunitsSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PoitemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        ProductidLabel = New System.Windows.Forms.Label()
        QtycontainersLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        lblCost = New System.Windows.Forms.Label()
        UnitorcontainerLabel = New System.Windows.Forms.Label()
        UnitsLabel = New System.Windows.Forms.Label()
        UomLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        PreparedbyLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        WeightuomLabel = New System.Windows.Forms.Label()
        WeightunitsLabel = New System.Windows.Forms.Label()
        VolumeuomLabel = New System.Windows.Forms.Label()
        VolumeunitsLabel = New System.Windows.Forms.Label()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPOItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendorItemNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlannedshipdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlannedshipdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightTextStandardCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeTextStandardCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightuomLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightunitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeuomLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeunitsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoitemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(95, 106)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(44, 13)
        ProductidLabel.TabIndex = 4
        ProductidLabel.Text = "Product"
        '
        'QtycontainersLabel
        '
        QtycontainersLabel.AutoSize = True
        QtycontainersLabel.Location = New System.Drawing.Point(11, 104)
        QtycontainersLabel.Name = "QtycontainersLabel"
        QtycontainersLabel.Size = New System.Drawing.Size(25, 13)
        QtycontainersLabel.TabIndex = 0
        QtycontainersLabel.Text = "Qty"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(142, 145)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 14
        ContainerLabel.Text = "Container"
        '
        'lblCost
        '
        lblCost.AutoSize = True
        lblCost.Location = New System.Drawing.Point(311, 145)
        lblCost.Name = "lblCost"
        lblCost.Size = New System.Drawing.Size(29, 13)
        lblCost.TabIndex = 16
        lblCost.Text = "Cost"
        '
        'UnitorcontainerLabel
        '
        UnitorcontainerLabel.AutoSize = True
        UnitorcontainerLabel.Location = New System.Drawing.Point(63, 106)
        UnitorcontainerLabel.Name = "UnitorcontainerLabel"
        UnitorcontainerLabel.Size = New System.Drawing.Size(25, 13)
        UnitorcontainerLabel.TabIndex = 2
        UnitorcontainerLabel.Text = "U/C"
        '
        'UnitsLabel
        '
        UnitsLabel.AutoSize = True
        UnitsLabel.Location = New System.Drawing.Point(91, 145)
        UnitsLabel.Name = "UnitsLabel"
        UnitsLabel.Size = New System.Drawing.Size(31, 13)
        UnitsLabel.TabIndex = 12
        UnitsLabel.Text = "Units"
        '
        'UomLabel
        '
        UomLabel.AutoSize = True
        UomLabel.Location = New System.Drawing.Point(11, 145)
        UomLabel.Name = "UomLabel"
        UomLabel.Size = New System.Drawing.Size(30, 13)
        UomLabel.TabIndex = 10
        UomLabel.Text = "UOM"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(260, 104)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(77, 13)
        Label1.TabIndex = 6
        Label1.Text = "Vendor Item #"
        '
        'PreparedbyLabel
        '
        PreparedbyLabel.AutoSize = True
        PreparedbyLabel.Location = New System.Drawing.Point(350, 106)
        PreparedbyLabel.Name = "PreparedbyLabel"
        PreparedbyLabel.Size = New System.Drawing.Size(65, 13)
        PreparedbyLabel.TabIndex = 8
        PreparedbyLabel.Text = "Expected In"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(252, 276)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(48, 13)
        Label11.TabIndex = 30
        Label11.Text = "Std Cost"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(87, 276)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(48, 13)
        Label10.TabIndex = 23
        Label10.Text = "Std Cost"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label9.Location = New System.Drawing.Point(285, 201)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(52, 13)
        Label9.TabIndex = 25
        Label9.Text = "WEIGHT"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label8.Location = New System.Drawing.Point(118, 201)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(52, 13)
        Label8.TabIndex = 18
        Label8.Text = "VOLUME"
        '
        'WeightuomLabel
        '
        WeightuomLabel.AutoSize = True
        WeightuomLabel.Location = New System.Drawing.Point(270, 250)
        WeightuomLabel.Name = "WeightuomLabel"
        WeightuomLabel.Size = New System.Drawing.Size(30, 13)
        WeightuomLabel.TabIndex = 28
        WeightuomLabel.Text = "UOM"
        '
        'WeightunitsLabel
        '
        WeightunitsLabel.AutoSize = True
        WeightunitsLabel.Location = New System.Drawing.Point(269, 224)
        WeightunitsLabel.Name = "WeightunitsLabel"
        WeightunitsLabel.Size = New System.Drawing.Size(31, 13)
        WeightunitsLabel.TabIndex = 26
        WeightunitsLabel.Text = "Units"
        '
        'VolumeuomLabel
        '
        VolumeuomLabel.AutoSize = True
        VolumeuomLabel.Location = New System.Drawing.Point(105, 250)
        VolumeuomLabel.Name = "VolumeuomLabel"
        VolumeuomLabel.Size = New System.Drawing.Size(30, 13)
        VolumeuomLabel.TabIndex = 21
        VolumeuomLabel.Text = "UOM"
        '
        'VolumeunitsLabel
        '
        VolumeunitsLabel.AutoSize = True
        VolumeunitsLabel.Location = New System.Drawing.Point(104, 224)
        VolumeunitsLabel.Name = "VolumeunitsLabel"
        VolumeunitsLabel.Size = New System.Drawing.Size(31, 13)
        VolumeunitsLabel.TabIndex = 19
        VolumeunitsLabel.Text = "Units"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProduct
        '
        Me.eProduct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Productid", True))
        Me.eProduct.Location = New System.Drawing.Point(95, 122)
        Me.eProduct.Name = "eProduct"
        Me.eProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Prod ID", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Weightunits", "Wgt Units", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Weightuom", "Wgt UOM", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Volumeunits", "Vol Units", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Volumeuom", "Vol UOM", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorname", "Vendor", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendoritemkey", "Vendor #", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Isactive", "Active", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProduct.Properties.DataSource = Me.bsProducts
        Me.eProduct.Properties.DisplayMember = "Productdesc"
        Me.eProduct.Properties.NullText = ""
        Me.eProduct.Properties.PopupWidth = 850
        Me.eProduct.Properties.ValueMember = "Productid"
        Me.eProduct.Size = New System.Drawing.Size(159, 20)
        Me.eProduct.TabIndex = 5
        '
        'bsPOItem
        '
        Me.bsPOItem.DataSource = GetType(AOS.BusinessObjects.Poitem)
        '
        'eQty
        '
        Me.eQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Qtyordered", True))
        Me.eQty.Location = New System.Drawing.Point(11, 122)
        Me.eQty.Name = "eQty"
        Me.eQty.Properties.Appearance.Options.UseTextOptions = True
        Me.eQty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eQty.Size = New System.Drawing.Size(45, 20)
        Me.eQty.TabIndex = 1
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(145, 161)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(109, 20)
        Me.eContainer.TabIndex = 15
        '
        'eCost
        '
        Me.eCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Unitcost", True))
        Me.eCost.Location = New System.Drawing.Point(311, 161)
        Me.eCost.Name = "eCost"
        Me.eCost.Properties.Appearance.Options.UseTextOptions = True
        Me.eCost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eCost.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Update", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, False)})
        Me.eCost.Properties.DisplayFormat.FormatString = "c3"
        Me.eCost.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eCost.Size = New System.Drawing.Size(142, 20)
        Me.eCost.TabIndex = 17
        '
        'eUC
        '
        Me.eUC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Unitorcontainer", True))
        Me.eUC.Location = New System.Drawing.Point(61, 122)
        Me.eUC.Name = "eUC"
        Me.eUC.Properties.Mask.EditMask = "U|C"
        Me.eUC.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.eUC.Properties.Mask.ShowPlaceHolders = False
        Me.eUC.Size = New System.Drawing.Size(27, 20)
        Me.eUC.TabIndex = 3
        '
        'eUnits
        '
        Me.eUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Units", True))
        Me.eUnits.Location = New System.Drawing.Point(94, 161)
        Me.eUnits.Name = "eUnits"
        Me.eUnits.Properties.ReadOnly = True
        Me.eUnits.Size = New System.Drawing.Size(45, 20)
        Me.eUnits.TabIndex = 13
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.rbtnGetAllProducts})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(468, 96)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 0
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 1
        Me.btnCancel.Name = "btnCancel"
        '
        'rbtnGetAllProducts
        '
        Me.rbtnGetAllProducts.Caption = "Show All Products"
        Me.rbtnGetAllProducts.Id = 6
        Me.rbtnGetAllProducts.LargeImageIndex = 2
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
        Me.eUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Uom", True))
        Me.eUOM.Location = New System.Drawing.Point(11, 161)
        Me.eUOM.Name = "eUOM"
        Me.eUOM.Properties.ReadOnly = True
        Me.eUOM.Size = New System.Drawing.Size(77, 20)
        Me.eUOM.TabIndex = 11
        '
        'eVendorItemNumber
        '
        Me.eVendorItemNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Vendoritemnumber", True))
        Me.eVendorItemNumber.Location = New System.Drawing.Point(260, 122)
        Me.eVendorItemNumber.Name = "eVendorItemNumber"
        Me.eVendorItemNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.eVendorItemNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eVendorItemNumber.Size = New System.Drawing.Size(86, 20)
        Me.eVendorItemNumber.TabIndex = 7
        '
        'PlannedshipdateDateEdit
        '
        Me.PlannedshipdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Expecteddelivery", True))
        Me.PlannedshipdateDateEdit.EditValue = Nothing
        Me.PlannedshipdateDateEdit.Location = New System.Drawing.Point(353, 122)
        Me.PlannedshipdateDateEdit.Name = "PlannedshipdateDateEdit"
        Me.PlannedshipdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PlannedshipdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.PlannedshipdateDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.PlannedshipdateDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.PlannedshipdateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.PlannedshipdateDateEdit.TabIndex = 9
        '
        'WeightTextStandardCost
        '
        Me.WeightTextStandardCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Weightstandardcost", True))
        Me.WeightTextStandardCost.EditValue = ""
        Me.WeightTextStandardCost.Enabled = False
        Me.WeightTextStandardCost.Location = New System.Drawing.Point(311, 273)
        Me.WeightTextStandardCost.MenuManager = Me.RibbonControl1
        Me.WeightTextStandardCost.Name = "WeightTextStandardCost"
        Me.WeightTextStandardCost.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.WeightTextStandardCost.Properties.Mask.EditMask = "f4"
        Me.WeightTextStandardCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.WeightTextStandardCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.WeightTextStandardCost.Size = New System.Drawing.Size(64, 20)
        Me.WeightTextStandardCost.TabIndex = 31
        '
        'VolumeTextStandardCost
        '
        Me.VolumeTextStandardCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Volumestandardcost", True))
        Me.VolumeTextStandardCost.EditValue = ""
        Me.VolumeTextStandardCost.Enabled = False
        Me.VolumeTextStandardCost.Location = New System.Drawing.Point(145, 273)
        Me.VolumeTextStandardCost.MenuManager = Me.RibbonControl1
        Me.VolumeTextStandardCost.Name = "VolumeTextStandardCost"
        Me.VolumeTextStandardCost.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.VolumeTextStandardCost.Properties.Mask.EditMask = "f4"
        Me.VolumeTextStandardCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.VolumeTextStandardCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.VolumeTextStandardCost.Size = New System.Drawing.Size(64, 20)
        Me.VolumeTextStandardCost.TabIndex = 24
        '
        'WeightuomLookUpEdit
        '
        Me.WeightuomLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Weightuom", True))
        Me.WeightuomLookUpEdit.Enabled = False
        Me.WeightuomLookUpEdit.Location = New System.Drawing.Point(311, 247)
        Me.WeightuomLookUpEdit.MenuManager = Me.RibbonControl1
        Me.WeightuomLookUpEdit.Name = "WeightuomLookUpEdit"
        Me.WeightuomLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WeightuomLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.WeightuomLookUpEdit.Properties.DataSource = Me.bsUOMWeight
        Me.WeightuomLookUpEdit.Properties.DisplayMember = "Uom"
        Me.WeightuomLookUpEdit.Properties.NullText = ""
        Me.WeightuomLookUpEdit.Properties.PopupWidth = 51
        Me.WeightuomLookUpEdit.Properties.ShowFooter = False
        Me.WeightuomLookUpEdit.Properties.ShowHeader = False
        Me.WeightuomLookUpEdit.Properties.ValueMember = "Uom"
        Me.WeightuomLookUpEdit.Size = New System.Drawing.Size(64, 20)
        Me.WeightuomLookUpEdit.TabIndex = 29
        '
        'WeightunitsTextEdit
        '
        Me.WeightunitsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Weightunits", True))
        Me.WeightunitsTextEdit.Enabled = False
        Me.WeightunitsTextEdit.Location = New System.Drawing.Point(311, 221)
        Me.WeightunitsTextEdit.MenuManager = Me.RibbonControl1
        Me.WeightunitsTextEdit.Name = "WeightunitsTextEdit"
        Me.WeightunitsTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.WeightunitsTextEdit.Size = New System.Drawing.Size(64, 20)
        Me.WeightunitsTextEdit.TabIndex = 27
        '
        'VolumeuomLookUpEdit
        '
        Me.VolumeuomLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Volumeuom", True))
        Me.VolumeuomLookUpEdit.Enabled = False
        Me.VolumeuomLookUpEdit.Location = New System.Drawing.Point(145, 247)
        Me.VolumeuomLookUpEdit.MenuManager = Me.RibbonControl1
        Me.VolumeuomLookUpEdit.Name = "VolumeuomLookUpEdit"
        Me.VolumeuomLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VolumeuomLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.VolumeuomLookUpEdit.Properties.DataSource = Me.bsUOMVolume
        Me.VolumeuomLookUpEdit.Properties.DisplayMember = "Uom"
        Me.VolumeuomLookUpEdit.Properties.NullText = ""
        Me.VolumeuomLookUpEdit.Properties.PopupWidth = 51
        Me.VolumeuomLookUpEdit.Properties.ShowFooter = False
        Me.VolumeuomLookUpEdit.Properties.ShowHeader = False
        Me.VolumeuomLookUpEdit.Properties.ValueMember = "Uom"
        Me.VolumeuomLookUpEdit.Size = New System.Drawing.Size(64, 20)
        Me.VolumeuomLookUpEdit.TabIndex = 22
        '
        'VolumeunitsSpinEdit
        '
        Me.VolumeunitsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPOItem, "Volumeunits", True))
        Me.VolumeunitsSpinEdit.EditValue = ""
        Me.VolumeunitsSpinEdit.Enabled = False
        Me.VolumeunitsSpinEdit.Location = New System.Drawing.Point(145, 221)
        Me.VolumeunitsSpinEdit.MenuManager = Me.RibbonControl1
        Me.VolumeunitsSpinEdit.Name = "VolumeunitsSpinEdit"
        Me.VolumeunitsSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.VolumeunitsSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.VolumeunitsSpinEdit.Size = New System.Drawing.Size(64, 20)
        Me.VolumeunitsSpinEdit.TabIndex = 20
        '
        'PoitemBindingSource
        '
        Me.PoitemBindingSource.DataSource = GetType(AOS.BusinessObjects.Poitem)
        '
        'frmAddEditPurchaseOrderItem
        '
        Me.ClientSize = New System.Drawing.Size(468, 308)
        Me.ControlBox = False
        Me.Controls.Add(Label11)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.WeightTextStandardCost)
        Me.Controls.Add(Me.VolumeTextStandardCost)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Label8)
        Me.Controls.Add(WeightuomLabel)
        Me.Controls.Add(Me.WeightuomLookUpEdit)
        Me.Controls.Add(WeightunitsLabel)
        Me.Controls.Add(Me.WeightunitsTextEdit)
        Me.Controls.Add(VolumeuomLabel)
        Me.Controls.Add(Me.VolumeuomLookUpEdit)
        Me.Controls.Add(VolumeunitsLabel)
        Me.Controls.Add(Me.VolumeunitsSpinEdit)
        Me.Controls.Add(PreparedbyLabel)
        Me.Controls.Add(Me.PlannedshipdateDateEdit)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.eVendorItemNumber)
        Me.Controls.Add(Me.eUOM)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(UomLabel)
        Me.Controls.Add(UnitsLabel)
        Me.Controls.Add(Me.eUnits)
        Me.Controls.Add(UnitorcontainerLabel)
        Me.Controls.Add(Me.eUC)
        Me.Controls.Add(lblCost)
        Me.Controls.Add(Me.eCost)
        Me.Controls.Add(ContainerLabel)
        Me.Controls.Add(Me.eContainer)
        Me.Controls.Add(QtycontainersLabel)
        Me.Controls.Add(Me.eQty)
        Me.Controls.Add(ProductidLabel)
        Me.Controls.Add(Me.eProduct)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditPurchaseOrderItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase Order Item Information"
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPOItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendorItemNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlannedshipdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlannedshipdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightTextStandardCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeTextStandardCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightuomLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightunitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeuomLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeunitsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoitemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsPOItem As System.Windows.Forms.BindingSource
    Friend WithEvents eProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eCost As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents eUC As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsProductCosts As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eVendorItemNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PlannedshipdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnGetAllProducts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents WeightTextStandardCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VolumeTextStandardCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WeightuomLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents WeightunitsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VolumeuomLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents VolumeunitsSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsUOMWeight As System.Windows.Forms.BindingSource
    Friend WithEvents bsUOMVolume As System.Windows.Forms.BindingSource
    Friend WithEvents PoitemBindingSource As System.Windows.Forms.BindingSource
End Class
