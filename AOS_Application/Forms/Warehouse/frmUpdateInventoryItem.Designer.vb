<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateInventoryItem

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
        Dim VendorWeightLabel As System.Windows.Forms.Label
        Dim LotNoLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim GrossWeightLabel As System.Windows.Forms.Label
        Dim InvItemNoLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateInventoryItem))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.eLotNumber = New DevExpress.XtraEditors.TextEdit()
        Me.bsInventoryItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.UpdateInventoryItemPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.ePalletType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPalletType = New System.Windows.Forms.BindingSource(Me.components)
        Me.eReceivingNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.eContainerType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsContainerType = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.InvItemnoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eScaleWeight = New DevExpress.XtraEditors.TextEdit()
        Me.eVendorLabelWeight = New DevExpress.XtraEditors.TextEdit()
        VendorWeightLabel = New System.Windows.Forms.Label()
        LotNoLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        GrossWeightLabel = New System.Windows.Forms.Label()
        InvItemNoLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLotNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateInventoryItemPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateInventoryItemPanelControl.SuspendLayout()
        CType(Me.ePalletType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPalletType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eReceivingNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainerType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContainerType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvItemnoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eScaleWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendorLabelWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VendorWeightLabel
        '
        VendorWeightLabel.AutoSize = True
        VendorWeightLabel.Location = New System.Drawing.Point(25, 96)
        VendorWeightLabel.Name = "VendorWeightLabel"
        VendorWeightLabel.Size = New System.Drawing.Size(110, 13)
        VendorWeightLabel.TabIndex = 6
        VendorWeightLabel.Text = "Vendor Label Weight:"
        '
        'LotNoLabel
        '
        LotNoLabel.AutoSize = True
        LotNoLabel.Location = New System.Drawing.Point(26, 70)
        LotNoLabel.Name = "LotNoLabel"
        LotNoLabel.Size = New System.Drawing.Size(37, 13)
        LotNoLabel.TabIndex = 4
        LotNoLabel.Text = "Lot #:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(26, 44)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(42, 13)
        StatusLabel.TabIndex = 2
        StatusLabel.Text = "Status:"
        '
        'GrossWeightLabel
        '
        GrossWeightLabel.AutoSize = True
        GrossWeightLabel.Location = New System.Drawing.Point(26, 176)
        GrossWeightLabel.Name = "GrossWeightLabel"
        GrossWeightLabel.Size = New System.Drawing.Size(73, 13)
        GrossWeightLabel.TabIndex = 8
        GrossWeightLabel.Text = "Scale Weight:"
        '
        'InvItemNoLabel1
        '
        InvItemNoLabel1.AutoSize = True
        InvItemNoLabel1.Location = New System.Drawing.Point(26, 20)
        InvItemNoLabel1.Name = "InvItemNoLabel1"
        InvItemNoLabel1.Size = New System.Drawing.Size(63, 13)
        InvItemNoLabel1.TabIndex = 0
        InvItemNoLabel1.Text = "Inv Item #:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(26, 122)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 10
        Label1.Text = "Container:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(26, 203)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(128, 13)
        Label2.TabIndex = 12
        Label2.Text = "Product Receiving Notes:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(26, 148)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(37, 13)
        Label3.TabIndex = 14
        Label3.Text = "Pallet:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(299, 95)
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
        'btnSave
        '
        Me.btnSave.Caption = "Update Item"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'eLotNumber
        '
        Me.eLotNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInventoryItem, "Lotnumber", True))
        Me.eLotNumber.Location = New System.Drawing.Point(142, 67)
        Me.eLotNumber.Name = "eLotNumber"
        Me.eLotNumber.Properties.MaxLength = 50
        Me.eLotNumber.Size = New System.Drawing.Size(135, 20)
        Me.eLotNumber.TabIndex = 0
        '
        'bsInventoryItem
        '
        Me.bsInventoryItem.DataSource = GetType(AOS.BusinessObjects.Invitem)
        '
        'UpdateInventoryItemPanelControl
        '
        Me.UpdateInventoryItemPanelControl.Controls.Add(Label3)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.ePalletType)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Label2)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.eReceivingNotes)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Label1)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.eContainerType)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.StatusTextEdit)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.InvItemnoTextEdit)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.eScaleWeight)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.eVendorLabelWeight)
        Me.UpdateInventoryItemPanelControl.Controls.Add(InvItemNoLabel1)
        Me.UpdateInventoryItemPanelControl.Controls.Add(GrossWeightLabel)
        Me.UpdateInventoryItemPanelControl.Controls.Add(StatusLabel)
        Me.UpdateInventoryItemPanelControl.Controls.Add(LotNoLabel)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.eLotNumber)
        Me.UpdateInventoryItemPanelControl.Controls.Add(VendorWeightLabel)
        Me.UpdateInventoryItemPanelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdateInventoryItemPanelControl.Location = New System.Drawing.Point(0, 95)
        Me.UpdateInventoryItemPanelControl.Name = "UpdateInventoryItemPanelControl"
        Me.UpdateInventoryItemPanelControl.Size = New System.Drawing.Size(299, 337)
        Me.UpdateInventoryItemPanelControl.TabIndex = 0
        '
        'ePalletType
        '
        Me.ePalletType.Location = New System.Drawing.Point(142, 145)
        Me.ePalletType.MenuManager = Me.RibbonControl1
        Me.ePalletType.Name = "ePalletType"
        Me.ePalletType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ePalletType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pallettype", "Pallet Type", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Palletweight", "Wgt", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ePalletType.Properties.DataSource = Me.bsPalletType
        Me.ePalletType.Properties.DisplayMember = "Pallettype"
        Me.ePalletType.Properties.NullText = ""
        Me.ePalletType.Properties.PopupWidth = 100
        Me.ePalletType.Properties.ShowFooter = False
        Me.ePalletType.Properties.ShowHeader = False
        Me.ePalletType.Properties.ValueMember = "Pallettype"
        Me.ePalletType.Size = New System.Drawing.Size(135, 20)
        Me.ePalletType.TabIndex = 3
        '
        'bsPalletType
        '
        Me.bsPalletType.DataSource = GetType(AOS.BusinessObjects.ListPallettypeCollection)
        '
        'eReceivingNotes
        '
        Me.eReceivingNotes.Location = New System.Drawing.Point(28, 219)
        Me.eReceivingNotes.MenuManager = Me.RibbonControl1
        Me.eReceivingNotes.Name = "eReceivingNotes"
        Me.eReceivingNotes.Properties.ReadOnly = True
        Me.eReceivingNotes.Size = New System.Drawing.Size(249, 96)
        Me.eReceivingNotes.TabIndex = 11
        Me.eReceivingNotes.TabStop = False
        '
        'eContainerType
        '
        Me.eContainerType.Location = New System.Drawing.Point(142, 119)
        Me.eContainerType.MenuManager = Me.RibbonControl1
        Me.eContainerType.Name = "eContainerType"
        Me.eContainerType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eContainerType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Containertype", "Containertype", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eContainerType.Properties.DataSource = Me.bsContainerType
        Me.eContainerType.Properties.DisplayMember = "Containertype"
        Me.eContainerType.Properties.NullText = ""
        Me.eContainerType.Properties.PopupWidth = 100
        Me.eContainerType.Properties.ShowFooter = False
        Me.eContainerType.Properties.ShowHeader = False
        Me.eContainerType.Properties.ValueMember = "Containertype"
        Me.eContainerType.Size = New System.Drawing.Size(135, 20)
        Me.eContainerType.TabIndex = 2
        '
        'bsContainerType
        '
        Me.bsContainerType.DataSource = GetType(AOS.BusinessObjects.ListContainertypeCollection)
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInventoryItem, "Itemstatus", True))
        Me.StatusTextEdit.Location = New System.Drawing.Point(142, 41)
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Properties.MaxLength = 50
        Me.StatusTextEdit.Properties.ReadOnly = True
        Me.StatusTextEdit.Size = New System.Drawing.Size(135, 20)
        Me.StatusTextEdit.TabIndex = 3
        '
        'InvItemnoTextEdit
        '
        Me.InvItemnoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInventoryItem, "Invitemnumber", True))
        Me.InvItemnoTextEdit.Location = New System.Drawing.Point(142, 15)
        Me.InvItemnoTextEdit.Name = "InvItemnoTextEdit"
        Me.InvItemnoTextEdit.Properties.MaxLength = 50
        Me.InvItemnoTextEdit.Properties.ReadOnly = True
        Me.InvItemnoTextEdit.Size = New System.Drawing.Size(135, 20)
        Me.InvItemnoTextEdit.TabIndex = 1
        '
        'eScaleWeight
        '
        Me.eScaleWeight.EditValue = ""
        Me.eScaleWeight.Location = New System.Drawing.Point(142, 173)
        Me.eScaleWeight.Name = "eScaleWeight"
        Me.eScaleWeight.Properties.DisplayFormat.FormatString = "n0"
        Me.eScaleWeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eScaleWeight.Properties.EditFormat.FormatString = "n0"
        Me.eScaleWeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eScaleWeight.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eScaleWeight.Size = New System.Drawing.Size(73, 20)
        Me.eScaleWeight.TabIndex = 4
        '
        'eVendorLabelWeight
        '
        Me.eVendorLabelWeight.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInventoryItem, "Vendorweight", True))
        Me.eVendorLabelWeight.EditValue = ""
        Me.eVendorLabelWeight.Location = New System.Drawing.Point(142, 93)
        Me.eVendorLabelWeight.Name = "eVendorLabelWeight"
        Me.eVendorLabelWeight.Properties.DisplayFormat.FormatString = "n0"
        Me.eVendorLabelWeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eVendorLabelWeight.Properties.EditFormat.FormatString = "n0"
        Me.eVendorLabelWeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eVendorLabelWeight.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eVendorLabelWeight.Size = New System.Drawing.Size(73, 20)
        Me.eVendorLabelWeight.TabIndex = 1
        '
        'frmUpdateInventoryItem
        '
        Me.ClientSize = New System.Drawing.Size(299, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.UpdateInventoryItemPanelControl)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUpdateInventoryItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update Inventory Item"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLotNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateInventoryItemPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateInventoryItemPanelControl.ResumeLayout(False)
        Me.UpdateInventoryItemPanelControl.PerformLayout()
        CType(Me.ePalletType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPalletType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eReceivingNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainerType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContainerType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvItemnoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eScaleWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendorLabelWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eLotNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UpdateInventoryItemPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bsPalletType As System.Windows.Forms.BindingSource
    Friend WithEvents eScaleWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eVendorLabelWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InvItemnoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsInventoryItem As System.Windows.Forms.BindingSource
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents eContainerType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsContainerType As BindingSource
    Friend WithEvents eReceivingNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ePalletType As DevExpress.XtraEditors.LookUpEdit
End Class
