<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditLoadItemProduct

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
        Dim QtyContainersLabel As System.Windows.Forms.Label
        Dim ItemIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditLoadItemProduct))
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim DotdescLabel As System.Windows.Forms.Label
        Dim HazclassnumberLabel As System.Windows.Forms.Label
        Dim PackagegroupLabel As System.Windows.Forms.Label
        Dim IdnumberLabel As System.Windows.Forms.Label
        Dim HazmatdescLabel As System.Windows.Forms.Label
        Dim VolumeunitsLabel As System.Windows.Forms.Label
        Dim WeightunitsLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsLoadItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.Ribbon_LargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rtLoadNumber = New DevExpress.XtraBars.BarStaticItem()
        Me.rtItemType = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.rTxtShipmentNumber = New DevExpress.XtraBars.BarStaticItem()
        Me.rtxtPurchaseOrder = New DevExpress.XtraBars.BarStaticItem()
        Me.rTxtCustomerName = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsWOItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.eProductID = New DevExpress.XtraEditors.LookUpEdit()
        Me.ProductdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContainerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DotdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.HazclassnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PackagegroupTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IdnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.HazmatdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VolumeunitsSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VolumeuomTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WeightunitsSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WeightuomTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsContainer = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        QtyContainersLabel = New System.Windows.Forms.Label()
        ItemIDLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        DotdescLabel = New System.Windows.Forms.Label()
        HazclassnumberLabel = New System.Windows.Forms.Label()
        PackagegroupLabel = New System.Windows.Forms.Label()
        IdnumberLabel = New System.Windows.Forms.Label()
        HazmatdescLabel = New System.Windows.Forms.Label()
        VolumeunitsLabel = New System.Windows.Forms.Label()
        WeightunitsLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.bsLoadItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWOItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DotdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HazclassnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PackagegroupTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HazmatdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeunitsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeuomTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightunitsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightuomTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QtyContainersLabel
        '
        QtyContainersLabel.AutoSize = True
        QtyContainersLabel.Location = New System.Drawing.Point(9, 116)
        QtyContainersLabel.Name = "QtyContainersLabel"
        QtyContainersLabel.Size = New System.Drawing.Size(80, 13)
        QtyContainersLabel.TabIndex = 1
        QtyContainersLabel.Text = "Qty Containers"
        '
        'ItemIDLabel
        '
        ItemIDLabel.AutoSize = True
        ItemIDLabel.Location = New System.Drawing.Point(154, 116)
        ItemIDLabel.Name = "ItemIDLabel"
        ItemIDLabel.Size = New System.Drawing.Size(58, 13)
        ItemIDLabel.TabIndex = 3
        ItemIDLabel.Text = "Product ID"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsLoadItem
        '
        Me.bsLoadItem.DataSource = GetType(AOS.BusinessObjects.Loaditem)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Images = Me.Ribbon_LargeImages
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.rtLoadNumber, Me.rtItemType, Me.BarStaticItem3, Me.rTxtShipmentNumber, Me.rtxtPurchaseOrder, Me.rTxtCustomerName})
        Me.RibbonControl1.LargeImages = Me.Ribbon_LargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(6, 6)
        Me.RibbonControl1.MaxItemId = 24
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(632, 94)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'Ribbon_LargeImages
        '
        Me.Ribbon_LargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.Ribbon_LargeImages.ImageStream = CType(resources.GetObject("Ribbon_LargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 6
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 16
        Me.btnCancel.LargeImageIndex = 7
        Me.btnCancel.Name = "btnCancel"
        '
        'rtLoadNumber
        '
        Me.rtLoadNumber.Caption = "999999"
        Me.rtLoadNumber.Id = 17
        Me.rtLoadNumber.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtLoadNumber.ItemAppearance.Normal.Options.UseFont = True
        Me.rtLoadNumber.Name = "rtLoadNumber"
        Me.rtLoadNumber.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rtItemType
        '
        Me.rtItemType.Caption = "PRODUCT"
        Me.rtItemType.Id = 18
        Me.rtItemType.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtItemType.ItemAppearance.Normal.Options.UseFont = True
        Me.rtItemType.Name = "rtItemType"
        Me.rtItemType.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Customer Name"
        Me.BarStaticItem3.Id = 19
        Me.BarStaticItem3.Name = "BarStaticItem3"
        Me.BarStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rTxtShipmentNumber
        '
        Me.rTxtShipmentNumber.Caption = "999999 - 12/31/2099"
        Me.rTxtShipmentNumber.Id = 20
        Me.rTxtShipmentNumber.Name = "rTxtShipmentNumber"
        Me.rTxtShipmentNumber.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rtxtPurchaseOrder
        '
        Me.rtxtPurchaseOrder.Caption = "ABCDEFGHIJK"
        Me.rtxtPurchaseOrder.Id = 21
        Me.rtxtPurchaseOrder.Name = "rtxtPurchaseOrder"
        Me.rtxtPurchaseOrder.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rTxtCustomerName
        '
        Me.rTxtCustomerName.Caption = "Americo Chemical Products, Inc."
        Me.rTxtCustomerName.Id = 22
        Me.rTxtCustomerName.Name = "rTxtCustomerName"
        Me.rTxtCustomerName.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rtLoadNumber)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rtItemType)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Load Item"
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
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'bsWOItem
        '
        Me.bsWOItem.DataSource = GetType(AOS.BusinessObjects.Workorderitem)
        '
        'eQty
        '
        Me.eQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadItem, "QtyContainers", True))
        Me.eQty.Location = New System.Drawing.Point(95, 113)
        Me.eQty.MenuManager = Me.RibbonControl1
        Me.eQty.Name = "eQty"
        Me.eQty.Size = New System.Drawing.Size(54, 20)
        Me.eQty.TabIndex = 2
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadItem, "ItemID", True))
        Me.eProductID.Location = New System.Drawing.Point(218, 113)
        Me.eProductID.MenuManager = Me.RibbonControl1
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Prod ID", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 175, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProductID.Properties.DataSource = Me.bsProducts
        Me.eProductID.Properties.DisplayMember = "Productid"
        Me.eProductID.Properties.NullText = ""
        Me.eProductID.Properties.ShowFooter = False
        Me.eProductID.Properties.ValueMember = "Productid"
        Me.eProductID.Size = New System.Drawing.Size(61, 20)
        Me.eProductID.TabIndex = 4
        '
        'ProductdescTextEdit
        '
        Me.ProductdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Productdesc", True))
        Me.ProductdescTextEdit.Location = New System.Drawing.Point(285, 113)
        Me.ProductdescTextEdit.MenuManager = Me.RibbonControl1
        Me.ProductdescTextEdit.Name = "ProductdescTextEdit"
        Me.ProductdescTextEdit.Properties.ReadOnly = True
        Me.ProductdescTextEdit.Size = New System.Drawing.Size(341, 20)
        Me.ProductdescTextEdit.TabIndex = 6
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(158, 206)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 6
        ContainerLabel.Text = "Container"
        '
        'ContainerTextEdit
        '
        Me.ContainerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Container", True))
        Me.ContainerTextEdit.Location = New System.Drawing.Point(218, 203)
        Me.ContainerTextEdit.MenuManager = Me.RibbonControl1
        Me.ContainerTextEdit.Name = "ContainerTextEdit"
        Me.ContainerTextEdit.Properties.ReadOnly = True
        Me.ContainerTextEdit.Size = New System.Drawing.Size(116, 20)
        Me.ContainerTextEdit.TabIndex = 7
        '
        'DotdescLabel
        '
        DotdescLabel.AutoSize = True
        DotdescLabel.Location = New System.Drawing.Point(158, 154)
        DotdescLabel.Name = "DotdescLabel"
        DotdescLabel.Size = New System.Drawing.Size(54, 13)
        DotdescLabel.TabIndex = 8
        DotdescLabel.Text = "DOT Desc"
        '
        'DotdescTextEdit
        '
        Me.DotdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Dotdesc", True))
        Me.DotdescTextEdit.Location = New System.Drawing.Point(218, 151)
        Me.DotdescTextEdit.MenuManager = Me.RibbonControl1
        Me.DotdescTextEdit.Name = "DotdescTextEdit"
        Me.DotdescTextEdit.Properties.ReadOnly = True
        Me.DotdescTextEdit.Size = New System.Drawing.Size(408, 20)
        Me.DotdescTextEdit.TabIndex = 9
        '
        'HazclassnumberLabel
        '
        HazclassnumberLabel.AutoSize = True
        HazclassnumberLabel.Location = New System.Drawing.Point(36, 154)
        HazclassnumberLabel.Name = "HazclassnumberLabel"
        HazclassnumberLabel.Size = New System.Drawing.Size(53, 13)
        HazclassnumberLabel.TabIndex = 10
        HazclassnumberLabel.Text = "Haz Class"
        '
        'HazclassnumberTextEdit
        '
        Me.HazclassnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Hazclassnumber", True))
        Me.HazclassnumberTextEdit.Location = New System.Drawing.Point(95, 151)
        Me.HazclassnumberTextEdit.MenuManager = Me.RibbonControl1
        Me.HazclassnumberTextEdit.Name = "HazclassnumberTextEdit"
        Me.HazclassnumberTextEdit.Properties.ReadOnly = True
        Me.HazclassnumberTextEdit.Size = New System.Drawing.Size(54, 20)
        Me.HazclassnumberTextEdit.TabIndex = 11
        '
        'PackagegroupLabel
        '
        PackagegroupLabel.AutoSize = True
        PackagegroupLabel.Location = New System.Drawing.Point(33, 180)
        PackagegroupLabel.Name = "PackagegroupLabel"
        PackagegroupLabel.Size = New System.Drawing.Size(56, 13)
        PackagegroupLabel.TabIndex = 12
        PackagegroupLabel.Text = "Pkg Group"
        '
        'PackagegroupTextEdit
        '
        Me.PackagegroupTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Packagegroup", True))
        Me.PackagegroupTextEdit.Location = New System.Drawing.Point(95, 177)
        Me.PackagegroupTextEdit.MenuManager = Me.RibbonControl1
        Me.PackagegroupTextEdit.Name = "PackagegroupTextEdit"
        Me.PackagegroupTextEdit.Properties.ReadOnly = True
        Me.PackagegroupTextEdit.Size = New System.Drawing.Size(54, 20)
        Me.PackagegroupTextEdit.TabIndex = 13
        '
        'IdnumberLabel
        '
        IdnumberLabel.AutoSize = True
        IdnumberLabel.Location = New System.Drawing.Point(31, 206)
        IdnumberLabel.Name = "IdnumberLabel"
        IdnumberLabel.Size = New System.Drawing.Size(58, 13)
        IdnumberLabel.TabIndex = 14
        IdnumberLabel.Text = "ID Number"
        '
        'IdnumberTextEdit
        '
        Me.IdnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Idnumber", True))
        Me.IdnumberTextEdit.Location = New System.Drawing.Point(95, 203)
        Me.IdnumberTextEdit.MenuManager = Me.RibbonControl1
        Me.IdnumberTextEdit.Name = "IdnumberTextEdit"
        Me.IdnumberTextEdit.Properties.ReadOnly = True
        Me.IdnumberTextEdit.Size = New System.Drawing.Size(54, 20)
        Me.IdnumberTextEdit.TabIndex = 15
        '
        'HazmatdescLabel
        '
        HazmatdescLabel.AutoSize = True
        HazmatdescLabel.Location = New System.Drawing.Point(169, 180)
        HazmatdescLabel.Name = "HazmatdescLabel"
        HazmatdescLabel.Size = New System.Drawing.Size(43, 13)
        HazmatdescLabel.TabIndex = 16
        HazmatdescLabel.Text = "Hazmat"
        '
        'HazmatdescTextEdit
        '
        Me.HazmatdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Hazmatdesc", True))
        Me.HazmatdescTextEdit.Location = New System.Drawing.Point(218, 177)
        Me.HazmatdescTextEdit.MenuManager = Me.RibbonControl1
        Me.HazmatdescTextEdit.Name = "HazmatdescTextEdit"
        Me.HazmatdescTextEdit.Properties.ReadOnly = True
        Me.HazmatdescTextEdit.Size = New System.Drawing.Size(408, 20)
        Me.HazmatdescTextEdit.TabIndex = 17
        '
        'VolumeunitsLabel
        '
        VolumeunitsLabel.AutoSize = True
        VolumeunitsLabel.Location = New System.Drawing.Point(171, 232)
        VolumeunitsLabel.Name = "VolumeunitsLabel"
        VolumeunitsLabel.Size = New System.Drawing.Size(41, 13)
        VolumeunitsLabel.TabIndex = 18
        VolumeunitsLabel.Text = "Volume"
        '
        'VolumeunitsSpinEdit
        '
        Me.VolumeunitsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Volumeunits", True))
        Me.VolumeunitsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.VolumeunitsSpinEdit.Location = New System.Drawing.Point(218, 229)
        Me.VolumeunitsSpinEdit.MenuManager = Me.RibbonControl1
        Me.VolumeunitsSpinEdit.Name = "VolumeunitsSpinEdit"
        Me.VolumeunitsSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.VolumeunitsSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.VolumeunitsSpinEdit.Properties.ReadOnly = True
        Me.VolumeunitsSpinEdit.Size = New System.Drawing.Size(52, 20)
        Me.VolumeunitsSpinEdit.TabIndex = 19
        '
        'VolumeuomTextEdit
        '
        Me.VolumeuomTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Volumeuom", True))
        Me.VolumeuomTextEdit.Location = New System.Drawing.Point(276, 229)
        Me.VolumeuomTextEdit.MenuManager = Me.RibbonControl1
        Me.VolumeuomTextEdit.Name = "VolumeuomTextEdit"
        Me.VolumeuomTextEdit.Properties.ReadOnly = True
        Me.VolumeuomTextEdit.Size = New System.Drawing.Size(58, 20)
        Me.VolumeuomTextEdit.TabIndex = 21
        '
        'WeightunitsLabel
        '
        WeightunitsLabel.AutoSize = True
        WeightunitsLabel.Location = New System.Drawing.Point(341, 232)
        WeightunitsLabel.Name = "WeightunitsLabel"
        WeightunitsLabel.Size = New System.Drawing.Size(41, 13)
        WeightunitsLabel.TabIndex = 21
        WeightunitsLabel.Text = "Weight"
        '
        'WeightunitsSpinEdit
        '
        Me.WeightunitsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Weightunits", True))
        Me.WeightunitsSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.WeightunitsSpinEdit.Location = New System.Drawing.Point(388, 229)
        Me.WeightunitsSpinEdit.MenuManager = Me.RibbonControl1
        Me.WeightunitsSpinEdit.Name = "WeightunitsSpinEdit"
        Me.WeightunitsSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.WeightunitsSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.WeightunitsSpinEdit.Properties.ReadOnly = True
        Me.WeightunitsSpinEdit.Size = New System.Drawing.Size(52, 20)
        Me.WeightunitsSpinEdit.TabIndex = 22
        '
        'WeightuomTextEdit
        '
        Me.WeightuomTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Weightuom", True))
        Me.WeightuomTextEdit.Location = New System.Drawing.Point(446, 229)
        Me.WeightuomTextEdit.MenuManager = Me.RibbonControl1
        Me.WeightuomTextEdit.Name = "WeightuomTextEdit"
        Me.WeightuomTextEdit.Properties.ReadOnly = True
        Me.WeightuomTextEdit.Size = New System.Drawing.Size(58, 20)
        Me.WeightuomTextEdit.TabIndex = 24
        '
        'bsContainer
        '
        Me.bsContainer.DataSource = GetType(AOS.BusinessObjects.Container)
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsContainer, "TareWeight", True))
        Me.TextEdit1.Location = New System.Drawing.Point(388, 203)
        Me.TextEdit1.MenuManager = Me.RibbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(52, 20)
        Me.TextEdit1.TabIndex = 25
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(353, 206)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(29, 13)
        Label1.TabIndex = 26
        Label1.Text = "Tare"
        '
        'frmAddEditLoadItemProduct
        '
        Me.ClientSize = New System.Drawing.Size(644, 435)
        Me.ControlBox = False
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.WeightuomTextEdit)
        Me.Controls.Add(WeightunitsLabel)
        Me.Controls.Add(Me.VolumeuomTextEdit)
        Me.Controls.Add(VolumeunitsLabel)
        Me.Controls.Add(HazmatdescLabel)
        Me.Controls.Add(Me.HazmatdescTextEdit)
        Me.Controls.Add(IdnumberLabel)
        Me.Controls.Add(Me.IdnumberTextEdit)
        Me.Controls.Add(PackagegroupLabel)
        Me.Controls.Add(Me.PackagegroupTextEdit)
        Me.Controls.Add(HazclassnumberLabel)
        Me.Controls.Add(Me.HazclassnumberTextEdit)
        Me.Controls.Add(DotdescLabel)
        Me.Controls.Add(Me.DotdescTextEdit)
        Me.Controls.Add(ContainerLabel)
        Me.Controls.Add(Me.ContainerTextEdit)
        Me.Controls.Add(Me.ProductdescTextEdit)
        Me.Controls.Add(ItemIDLabel)
        Me.Controls.Add(Me.eProductID)
        Me.Controls.Add(QtyContainersLabel)
        Me.Controls.Add(Me.eQty)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.VolumeunitsSpinEdit)
        Me.Controls.Add(Me.WeightunitsSpinEdit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditLoadItemProduct"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Load Item - PRODUCT"
        CType(Me.bsLoadItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWOItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DotdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HazclassnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PackagegroupTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HazmatdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeunitsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeuomTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightunitsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightuomTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsLoadItem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rtLoadNumber As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rtItemType As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rTxtShipmentNumber As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rtxtPurchaseOrder As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rTxtCustomerName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Ribbon_LargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents bsWOItem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ProductdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContainerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DotdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HazclassnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PackagegroupTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IdnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HazmatdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VolumeunitsSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VolumeuomTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WeightunitsSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WeightuomTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsContainer As System.Windows.Forms.BindingSource
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
End Class
