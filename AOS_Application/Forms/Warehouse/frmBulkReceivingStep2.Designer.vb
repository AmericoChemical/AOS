<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBulkReceivingStep2

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim txtScaleWeight As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBulkReceivingStep2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNext = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PalletPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.eUOM = New DevExpress.XtraEditors.TextEdit()
        Me.eQtyReceived = New DevExpress.XtraEditors.TextEdit()
        Me.ePalletType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPalletTypeCollection = New System.Windows.Forms.BindingSource(Me.components)
        Me.eLotNumber = New DevExpress.XtraEditors.TextEdit()
        Me.eScaleWeight = New DevExpress.XtraEditors.TextEdit()
        Me.eLocation = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsLocations = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eProductDescription = New DevExpress.XtraEditors.TextEdit()
        Me.eProductID = New DevExpress.XtraEditors.TextEdit()
        Me.eVendorName = New DevExpress.XtraEditors.TextEdit()
        Me.ePONumber = New DevExpress.XtraEditors.TextEdit()
        Me.bsContainerType = New System.Windows.Forms.BindingSource(Me.components)
        txtScaleWeight = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PalletPanelControl.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQtyReceived.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePalletType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPalletTypeCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLotNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eScaleWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLocations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eProductDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendorName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePONumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContainerType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtScaleWeight
        '
        txtScaleWeight.AutoSize = True
        txtScaleWeight.Location = New System.Drawing.Point(11, 86)
        txtScaleWeight.Name = "txtScaleWeight"
        txtScaleWeight.Size = New System.Drawing.Size(73, 13)
        txtScaleWeight.TabIndex = 2
        txtScaleWeight.Text = "Scale Weight:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(11, 60)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(64, 13)
        Label6.TabIndex = 0
        Label6.Text = "Pallet Type:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(11, 138)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 13)
        Label1.TabIndex = 5
        Label1.Text = "Location:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(11, 112)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(66, 13)
        Label2.TabIndex = 7
        Label2.Text = "Lot Number:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(89, 73)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(60, 13)
        Label4.TabIndex = 20
        Label4.Text = "Description"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(11, 73)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(44, 13)
        Label5.TabIndex = 18
        Label5.Text = "Product"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(89, 30)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(41, 13)
        Label7.TabIndex = 16
        Label7.Text = "Vendor"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(11, 30)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(29, 13)
        Label8.TabIndex = 14
        Label8.Text = "PO#"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(11, 34)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(76, 13)
        Label9.TabIndex = 8
        Label9.Text = "Qty Received:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(226, 34)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(148, 13)
        Label10.TabIndex = 10
        Label10.Text = "(from BOL for this Pallet only)"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnNext, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(415, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 0
        Me.btnNewCostRecord.LargeGlyph = CType(resources.GetObject("btnNewCostRecord.LargeGlyph"), System.Drawing.Image)
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Glyph = CType(resources.GetObject("btnEditCostRecord.Glyph"), System.Drawing.Image)
        Me.btnEditCostRecord.Id = 1
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Glyph = CType(resources.GetObject("btnDeleteCostRecord.Glyph"), System.Drawing.Image)
        Me.btnDeleteCostRecord.Id = 2
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
        '
        'btnNext
        '
        Me.btnNext.Caption = "Next"
        Me.btnNext.Id = 4
        Me.btnNext.LargeImageIndex = 0
        Me.btnNext.Name = "btnNext"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 2
        Me.btnCancel.Name = "btnCancel"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnNext)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'PalletPanelControl
        '
        Me.PalletPanelControl.Controls.Add(Me.GroupControl2)
        Me.PalletPanelControl.Controls.Add(Me.GroupControl1)
        Me.PalletPanelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PalletPanelControl.Location = New System.Drawing.Point(0, 95)
        Me.PalletPanelControl.Name = "PalletPanelControl"
        Me.PalletPanelControl.Size = New System.Drawing.Size(415, 306)
        Me.PalletPanelControl.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.eUOM)
        Me.GroupControl2.Controls.Add(Label10)
        Me.GroupControl2.Controls.Add(Label9)
        Me.GroupControl2.Controls.Add(Me.eQtyReceived)
        Me.GroupControl2.Controls.Add(Me.ePalletType)
        Me.GroupControl2.Controls.Add(Label6)
        Me.GroupControl2.Controls.Add(Me.eLotNumber)
        Me.GroupControl2.Controls.Add(txtScaleWeight)
        Me.GroupControl2.Controls.Add(Label2)
        Me.GroupControl2.Controls.Add(Me.eScaleWeight)
        Me.GroupControl2.Controls.Add(Label1)
        Me.GroupControl2.Controls.Add(Me.eLocation)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 130)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(411, 174)
        Me.GroupControl2.TabIndex = 9
        Me.GroupControl2.Text = "PALLET - Receiving Details"
        '
        'eUOM
        '
        Me.eUOM.EditValue = ""
        Me.eUOM.Location = New System.Drawing.Point(172, 31)
        Me.eUOM.Name = "eUOM"
        Me.eUOM.Properties.DisplayFormat.FormatString = "n0"
        Me.eUOM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eUOM.Properties.EditFormat.FormatString = "n0"
        Me.eUOM.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eUOM.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eUOM.Properties.ReadOnly = True
        Me.eUOM.Size = New System.Drawing.Size(48, 20)
        Me.eUOM.TabIndex = 18
        Me.eUOM.TabStop = False
        '
        'eQtyReceived
        '
        Me.eQtyReceived.EditValue = ""
        Me.eQtyReceived.Location = New System.Drawing.Point(92, 31)
        Me.eQtyReceived.Name = "eQtyReceived"
        Me.eQtyReceived.Properties.DisplayFormat.FormatString = "n0"
        Me.eQtyReceived.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eQtyReceived.Properties.EditFormat.FormatString = "n0"
        Me.eQtyReceived.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eQtyReceived.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eQtyReceived.Size = New System.Drawing.Size(74, 20)
        Me.eQtyReceived.TabIndex = 0
        '
        'ePalletType
        '
        Me.ePalletType.Location = New System.Drawing.Point(92, 57)
        Me.ePalletType.MenuManager = Me.RibbonControl1
        Me.ePalletType.Name = "ePalletType"
        Me.ePalletType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ePalletType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pallettype", "Pallet Type", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Palletweight", "Pallet Weight", 68, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ePalletType.Properties.DataSource = Me.bsPalletTypeCollection
        Me.ePalletType.Properties.DisplayMember = "Pallettype"
        Me.ePalletType.Properties.NullText = ""
        Me.ePalletType.Properties.PopupWidth = 320
        Me.ePalletType.Properties.ValueMember = "Pallettype"
        Me.ePalletType.Size = New System.Drawing.Size(128, 20)
        Me.ePalletType.TabIndex = 1
        '
        'bsPalletTypeCollection
        '
        Me.bsPalletTypeCollection.DataSource = GetType(AOS.BusinessObjects.ListPallettypeCollection)
        '
        'eLotNumber
        '
        Me.eLotNumber.EditValue = ""
        Me.eLotNumber.Location = New System.Drawing.Point(92, 109)
        Me.eLotNumber.Name = "eLotNumber"
        Me.eLotNumber.Properties.DisplayFormat.FormatString = "n0"
        Me.eLotNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eLotNumber.Properties.EditFormat.FormatString = "n0"
        Me.eLotNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eLotNumber.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eLotNumber.Size = New System.Drawing.Size(128, 20)
        Me.eLotNumber.TabIndex = 3
        '
        'eScaleWeight
        '
        Me.eScaleWeight.EditValue = ""
        Me.eScaleWeight.Location = New System.Drawing.Point(92, 83)
        Me.eScaleWeight.Name = "eScaleWeight"
        Me.eScaleWeight.Properties.DisplayFormat.FormatString = "n0"
        Me.eScaleWeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eScaleWeight.Properties.EditFormat.FormatString = "n0"
        Me.eScaleWeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eScaleWeight.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eScaleWeight.Size = New System.Drawing.Size(74, 20)
        Me.eScaleWeight.TabIndex = 2
        '
        'eLocation
        '
        Me.eLocation.Location = New System.Drawing.Point(92, 135)
        Me.eLocation.MenuManager = Me.RibbonControl1
        Me.eLocation.Name = "eLocation"
        Me.eLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eLocation.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Warehouselocation", "Location")})
        Me.eLocation.Properties.DataSource = Me.bsLocations
        Me.eLocation.Properties.DisplayMember = "Warehouselocation"
        Me.eLocation.Properties.NullText = ""
        Me.eLocation.Properties.PopupWidth = 100
        Me.eLocation.Properties.ShowFooter = False
        Me.eLocation.Properties.ShowHeader = False
        Me.eLocation.Properties.ValueMember = "Warehouselocation"
        Me.eLocation.Size = New System.Drawing.Size(74, 20)
        Me.eLocation.TabIndex = 4
        '
        'bsLocations
        '
        Me.bsLocations.DataSource = GetType(AOS.BusinessObjects.ListWarehouselocationCollection)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Me.eProductDescription)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Controls.Add(Label7)
        Me.GroupControl1.Controls.Add(Me.eVendorName)
        Me.GroupControl1.Controls.Add(Label8)
        Me.GroupControl1.Controls.Add(Me.ePONumber)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(411, 128)
        Me.GroupControl1.TabIndex = 8
        Me.GroupControl1.Text = "Purchasing Information"
        '
        'eProductDescription
        '
        Me.eProductDescription.EditValue = ""
        Me.eProductDescription.Location = New System.Drawing.Point(92, 89)
        Me.eProductDescription.Name = "eProductDescription"
        Me.eProductDescription.Properties.DisplayFormat.FormatString = "n0"
        Me.eProductDescription.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eProductDescription.Properties.EditFormat.FormatString = "n0"
        Me.eProductDescription.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eProductDescription.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eProductDescription.Properties.ReadOnly = True
        Me.eProductDescription.Size = New System.Drawing.Size(309, 20)
        Me.eProductDescription.TabIndex = 19
        Me.eProductDescription.TabStop = False
        '
        'eProductID
        '
        Me.eProductID.EditValue = ""
        Me.eProductID.Location = New System.Drawing.Point(14, 89)
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eProductID.Properties.ReadOnly = True
        Me.eProductID.Size = New System.Drawing.Size(66, 20)
        Me.eProductID.TabIndex = 17
        Me.eProductID.TabStop = False
        '
        'eVendorName
        '
        Me.eVendorName.EditValue = ""
        Me.eVendorName.Location = New System.Drawing.Point(92, 50)
        Me.eVendorName.Name = "eVendorName"
        Me.eVendorName.Properties.DisplayFormat.FormatString = "n0"
        Me.eVendorName.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eVendorName.Properties.EditFormat.FormatString = "n0"
        Me.eVendorName.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eVendorName.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eVendorName.Properties.ReadOnly = True
        Me.eVendorName.Size = New System.Drawing.Size(309, 20)
        Me.eVendorName.TabIndex = 15
        Me.eVendorName.TabStop = False
        '
        'ePONumber
        '
        Me.ePONumber.EditValue = ""
        Me.ePONumber.Location = New System.Drawing.Point(14, 50)
        Me.ePONumber.Name = "ePONumber"
        Me.ePONumber.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ePONumber.Properties.ReadOnly = True
        Me.ePONumber.Size = New System.Drawing.Size(66, 20)
        Me.ePONumber.TabIndex = 13
        Me.ePONumber.TabStop = False
        '
        'bsContainerType
        '
        Me.bsContainerType.DataSource = GetType(AOS.BusinessObjects.ListContainertypeCollection)
        '
        'frmBulkReceivingStep2
        '
        Me.ClientSize = New System.Drawing.Size(415, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.PalletPanelControl)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBulkReceivingStep2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bulk Receiving - Step 2"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PalletPanelControl.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQtyReceived.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePalletType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPalletTypeCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLotNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eScaleWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLocations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eProductDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendorName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePONumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContainerType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNext As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PalletPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bsPalletTypeCollection As System.Windows.Forms.BindingSource
    Friend WithEvents ePalletType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eScaleWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents eLocation As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsContainerType As BindingSource
    Friend WithEvents eLotNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsLocations As BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eProductDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eVendorName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePONumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eQtyReceived As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUOM As DevExpress.XtraEditors.TextEdit
End Class
