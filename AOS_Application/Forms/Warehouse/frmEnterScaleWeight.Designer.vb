<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnterScaleWeight

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
        Dim Label3 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnterScaleWeight))
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
        Me.eContainerType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsContainerType = New System.Windows.Forms.BindingSource(Me.components)
        Me.eScaleWeight = New DevExpress.XtraEditors.TextEdit()
        Me.ePalletType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPalletTypeCollection = New System.Windows.Forms.BindingSource(Me.components)
        Label3 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PalletPanelControl.SuspendLayout()
        CType(Me.eContainerType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContainerType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eScaleWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePalletType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPalletTypeCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 77)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(73, 13)
        Label3.TabIndex = 2
        Label3.Text = "Scale Weight:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(10, 25)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(64, 13)
        Label6.TabIndex = 0
        Label6.Text = "Pallet Type:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(10, 51)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(58, 13)
        Label1.TabIndex = 5
        Label1.Text = "Container:"
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
        Me.RibbonControl1.Size = New System.Drawing.Size(234, 95)
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
        Me.PalletPanelControl.Controls.Add(Label1)
        Me.PalletPanelControl.Controls.Add(Me.eContainerType)
        Me.PalletPanelControl.Controls.Add(Me.eScaleWeight)
        Me.PalletPanelControl.Controls.Add(Me.ePalletType)
        Me.PalletPanelControl.Controls.Add(Label3)
        Me.PalletPanelControl.Controls.Add(Label6)
        Me.PalletPanelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PalletPanelControl.Location = New System.Drawing.Point(0, 95)
        Me.PalletPanelControl.Name = "PalletPanelControl"
        Me.PalletPanelControl.Size = New System.Drawing.Size(234, 117)
        Me.PalletPanelControl.TabIndex = 1
        '
        'eContainerType
        '
        Me.eContainerType.Location = New System.Drawing.Point(85, 48)
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
        Me.eContainerType.Size = New System.Drawing.Size(128, 20)
        Me.eContainerType.TabIndex = 1
        '
        'bsContainerType
        '
        Me.bsContainerType.DataSource = GetType(AOS.BusinessObjects.ListContainertypeCollection)
        '
        'eScaleWeight
        '
        Me.eScaleWeight.EditValue = ""
        Me.eScaleWeight.Location = New System.Drawing.Point(85, 74)
        Me.eScaleWeight.Name = "eScaleWeight"
        Me.eScaleWeight.Properties.DisplayFormat.FormatString = "n0"
        Me.eScaleWeight.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eScaleWeight.Properties.EditFormat.FormatString = "n0"
        Me.eScaleWeight.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eScaleWeight.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eScaleWeight.Size = New System.Drawing.Size(74, 20)
        Me.eScaleWeight.TabIndex = 2
        '
        'ePalletType
        '
        Me.ePalletType.Location = New System.Drawing.Point(85, 22)
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
        Me.ePalletType.TabIndex = 0
        '
        'bsPalletTypeCollection
        '
        Me.bsPalletTypeCollection.DataSource = GetType(AOS.BusinessObjects.ListPallettypeCollection)
        '
        'frmEnterScaleWeight
        '
        Me.ClientSize = New System.Drawing.Size(234, 212)
        Me.ControlBox = False
        Me.Controls.Add(Me.PalletPanelControl)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEnterScaleWeight"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pallet Type and Scale Weight"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PalletPanelControl.ResumeLayout(False)
        Me.PalletPanelControl.PerformLayout()
        CType(Me.eContainerType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContainerType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eScaleWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePalletType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPalletTypeCollection, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents eContainerType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsContainerType As BindingSource
End Class
