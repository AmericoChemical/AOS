<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewReceiverItem

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
        Dim LotnumberLabel As System.Windows.Forms.Label
        Dim QtyreceivedLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddNewReceiverItem))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProduct = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.eLotNumber = New DevExpress.XtraEditors.TextEdit()
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.eInventoryClass = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsInventoryClass = New System.Windows.Forms.BindingSource(Me.components)
        Me.eProductDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eDocNum = New DevExpress.XtraEditors.TextEdit()
        Me.eRecvDate = New DevExpress.XtraEditors.TextEdit()
        Me.eNote = New DevExpress.XtraEditors.TextEdit()
        Me.bsDocTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.eDocType = New DevExpress.XtraEditors.LookUpEdit()
        Me.eLabelWeight = New DevExpress.XtraEditors.TextEdit()
        Me.eScaleWeight = New DevExpress.XtraEditors.TextEdit()
        Me.eContainerType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsContainers = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePalletType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPallets = New System.Windows.Forms.BindingSource(Me.components)
        ProductidLabel = New System.Windows.Forms.Label()
        LotnumberLabel = New System.Windows.Forms.Label()
        QtyreceivedLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLotNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInventoryClass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDocNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eRecvDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eNote.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDocTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDocType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLabelWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eScaleWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainerType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContainers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePalletType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPallets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(16, 181)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(44, 13)
        ProductidLabel.TabIndex = 1
        ProductidLabel.Text = "Product"
        '
        'LotnumberLabel
        '
        LotnumberLabel.AutoSize = True
        LotnumberLabel.Location = New System.Drawing.Point(16, 233)
        LotnumberLabel.Name = "LotnumberLabel"
        LotnumberLabel.Size = New System.Drawing.Size(62, 13)
        LotnumberLabel.TabIndex = 24
        LotnumberLabel.Text = "Lot Number"
        '
        'QtyreceivedLabel
        '
        QtyreceivedLabel.AutoSize = True
        QtyreceivedLabel.Location = New System.Drawing.Point(16, 207)
        QtyreceivedLabel.Name = "QtyreceivedLabel"
        QtyreceivedLabel.Size = New System.Drawing.Size(52, 13)
        QtyreceivedLabel.TabIndex = 31
        QtyreceivedLabel.Text = "Qty Recv"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 260)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 34
        Label1.Text = "Inv Class"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(16, 130)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 13)
        Label2.TabIndex = 40
        Label2.Text = "Document #"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(16, 156)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(67, 13)
        Label3.TabIndex = 43
        Label3.Text = "Note/Source"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(16, 104)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(52, 13)
        Label4.TabIndex = 46
        Label4.Text = "Doc Type"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(16, 286)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(69, 13)
        Label6.TabIndex = 51
        Label6.Text = "Label Weight"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(16, 364)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(69, 13)
        Label7.TabIndex = 53
        Label7.Text = "Scale Weight"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(16, 312)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(54, 13)
        Label8.TabIndex = 55
        Label8.Text = "Container"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(16, 338)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(33, 13)
        Label9.TabIndex = 57
        Label9.Text = "Pallet"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProduct
        '
        Me.eProduct.Location = New System.Drawing.Point(91, 178)
        Me.eProduct.Name = "eProduct"
        Me.eProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Prod ID", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", 100, "Addn Desc"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 85, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProduct.Properties.DataSource = Me.bsProducts
        Me.eProduct.Properties.DisplayMember = "Productid"
        Me.eProduct.Properties.DropDownRows = 15
        Me.eProduct.Properties.NullText = ""
        Me.eProduct.Properties.PopupWidth = 400
        Me.eProduct.Properties.ValueMember = "Productid"
        Me.eProduct.Size = New System.Drawing.Size(69, 20)
        Me.eProduct.TabIndex = 3
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'eLotNumber
        '
        Me.eLotNumber.Location = New System.Drawing.Point(91, 230)
        Me.eLotNumber.Name = "eLotNumber"
        Me.eLotNumber.Size = New System.Drawing.Size(155, 20)
        Me.eLotNumber.TabIndex = 5
        '
        'eContainer
        '
        Me.eContainer.Location = New System.Drawing.Point(166, 204)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(80, 20)
        Me.eContainer.TabIndex = 26
        Me.eContainer.TabStop = False
        '
        'eQty
        '
        Me.eQty.Location = New System.Drawing.Point(91, 204)
        Me.eQty.Name = "eQty"
        Me.eQty.Properties.DisplayFormat.FormatString = "n0"
        Me.eQty.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eQty.Properties.EditFormat.FormatString = "n0"
        Me.eQty.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eQty.Size = New System.Drawing.Size(69, 20)
        Me.eQty.TabIndex = 4
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.BarButtonItem1, Me.BarButtonItem2})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(400, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 0
        Me.btnNewCostRecord.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCostRecord.Id = 1
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCostRecord.Id = 2
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Receive Item(s)"
        Me.BarButtonItem1.Id = 4
        Me.BarButtonItem1.LargeImageIndex = 14
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Cancel"
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.LargeImageIndex = 6
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'eInventoryClass
        '
        Me.eInventoryClass.Location = New System.Drawing.Point(91, 257)
        Me.eInventoryClass.MenuManager = Me.RibbonControl1
        Me.eInventoryClass.Name = "eInventoryClass"
        Me.eInventoryClass.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eInventoryClass.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LookupDesc", "Lookup Desc", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eInventoryClass.Properties.DataSource = Me.bsInventoryClass
        Me.eInventoryClass.Properties.DisplayMember = "LookupDesc"
        Me.eInventoryClass.Properties.NullText = ""
        Me.eInventoryClass.Properties.ValueMember = "LookupValue"
        Me.eInventoryClass.Size = New System.Drawing.Size(155, 20)
        Me.eInventoryClass.TabIndex = 6
        '
        'bsInventoryClass
        '
        Me.bsInventoryClass.DataSource = GetType(AOS.BusinessObjects.ListInventoryclassCollection)
        '
        'eProductDesc
        '
        Me.eProductDesc.Location = New System.Drawing.Point(166, 178)
        Me.eProductDesc.Name = "eProductDesc"
        Me.eProductDesc.Properties.ReadOnly = True
        Me.eProductDesc.Size = New System.Drawing.Size(220, 20)
        Me.eProductDesc.TabIndex = 36
        Me.eProductDesc.TabStop = False
        '
        'eDocNum
        '
        Me.eDocNum.Location = New System.Drawing.Point(91, 127)
        Me.eDocNum.Name = "eDocNum"
        Me.eDocNum.Size = New System.Drawing.Size(155, 20)
        Me.eDocNum.TabIndex = 1
        '
        'eRecvDate
        '
        Me.eRecvDate.Location = New System.Drawing.Point(166, 101)
        Me.eRecvDate.Name = "eRecvDate"
        Me.eRecvDate.Properties.ReadOnly = True
        Me.eRecvDate.Size = New System.Drawing.Size(80, 20)
        Me.eRecvDate.TabIndex = 41
        Me.eRecvDate.TabStop = False
        '
        'eNote
        '
        Me.eNote.Location = New System.Drawing.Point(91, 153)
        Me.eNote.Name = "eNote"
        Me.eNote.Size = New System.Drawing.Size(295, 20)
        Me.eNote.TabIndex = 2
        '
        'bsDocTypes
        '
        Me.bsDocTypes.DataSource = GetType(AOS.BusinessObjects.ListDocumenttypeCollection)
        '
        'eDocType
        '
        Me.eDocType.Location = New System.Drawing.Point(91, 101)
        Me.eDocType.Name = "eDocType"
        Me.eDocType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDocType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Documenttype", "Documenttype", 93, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eDocType.Properties.DataSource = Me.bsDocTypes
        Me.eDocType.Properties.DisplayMember = "Documenttype"
        Me.eDocType.Properties.DropDownRows = 5
        Me.eDocType.Properties.NullText = ""
        Me.eDocType.Properties.ShowFooter = False
        Me.eDocType.Properties.ShowHeader = False
        Me.eDocType.Properties.ValueMember = "Documenttype"
        Me.eDocType.Size = New System.Drawing.Size(69, 20)
        Me.eDocType.TabIndex = 0
        '
        'eLabelWeight
        '
        Me.eLabelWeight.Location = New System.Drawing.Point(91, 283)
        Me.eLabelWeight.Name = "eLabelWeight"
        Me.eLabelWeight.Size = New System.Drawing.Size(69, 20)
        Me.eLabelWeight.TabIndex = 50
        '
        'eScaleWeight
        '
        Me.eScaleWeight.Location = New System.Drawing.Point(91, 361)
        Me.eScaleWeight.Name = "eScaleWeight"
        Me.eScaleWeight.Size = New System.Drawing.Size(69, 20)
        Me.eScaleWeight.TabIndex = 52
        '
        'eContainerType
        '
        Me.eContainerType.Location = New System.Drawing.Point(91, 309)
        Me.eContainerType.MenuManager = Me.RibbonControl1
        Me.eContainerType.Name = "eContainerType"
        Me.eContainerType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eContainerType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Containertype", "Container", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eContainerType.Properties.DataSource = Me.bsContainers
        Me.eContainerType.Properties.DisplayMember = "Containertype"
        Me.eContainerType.Properties.NullText = ""
        Me.eContainerType.Properties.ValueMember = "Containertype"
        Me.eContainerType.Size = New System.Drawing.Size(155, 20)
        Me.eContainerType.TabIndex = 54
        '
        'bsContainers
        '
        Me.bsContainers.DataSource = GetType(AOS.BusinessObjects.ListContainertypeCollection)
        '
        'ePalletType
        '
        Me.ePalletType.Location = New System.Drawing.Point(91, 335)
        Me.ePalletType.MenuManager = Me.RibbonControl1
        Me.ePalletType.Name = "ePalletType"
        Me.ePalletType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ePalletType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pallettype", "Pallet", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Palletweight", "Wgt", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ePalletType.Properties.DataSource = Me.bsPallets
        Me.ePalletType.Properties.DisplayMember = "Pallettype"
        Me.ePalletType.Properties.NullText = ""
        Me.ePalletType.Properties.ValueMember = "Pallettype"
        Me.ePalletType.Size = New System.Drawing.Size(155, 20)
        Me.ePalletType.TabIndex = 56
        '
        'bsPallets
        '
        Me.bsPallets.DataSource = GetType(AOS.BusinessObjects.ListPallettypeCollection)
        '
        'frmAddNewReceiverItem
        '
        Me.ClientSize = New System.Drawing.Size(400, 398)
        Me.ControlBox = False
        Me.Controls.Add(Label9)
        Me.Controls.Add(Me.ePalletType)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.eContainerType)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.eScaleWeight)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.eLabelWeight)
        Me.Controls.Add(Me.eDocType)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.eNote)
        Me.Controls.Add(Me.eRecvDate)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.eDocNum)
        Me.Controls.Add(Me.eProductDesc)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.eInventoryClass)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(QtyreceivedLabel)
        Me.Controls.Add(Me.eQty)
        Me.Controls.Add(Me.eContainer)
        Me.Controls.Add(LotnumberLabel)
        Me.Controls.Add(Me.eLotNumber)
        Me.Controls.Add(ProductidLabel)
        Me.Controls.Add(Me.eProduct)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddNewReceiverItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receiving Item(s) to Inventory"
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLotNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInventoryClass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDocNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eRecvDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eNote.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDocTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDocType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLabelWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eScaleWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainerType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContainers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePalletType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPallets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents eProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eLotNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eInventoryClass As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsInventoryClass As System.Windows.Forms.BindingSource
    Friend WithEvents eProductDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eDocNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eRecvDate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eNote As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents bsDocTypes As BindingSource
    Friend WithEvents eDocType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eLabelWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eScaleWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainerType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsContainers As BindingSource
    Friend WithEvents ePalletType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsPallets As BindingSource
End Class
