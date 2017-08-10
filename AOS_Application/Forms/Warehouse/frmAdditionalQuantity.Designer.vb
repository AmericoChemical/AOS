<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdditionalQuantity

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
        Dim NotesLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.QuantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UpdateInventoryItemPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.NotesTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.PalletPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.PalletGrossWeightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PalletTypeLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        NotesLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UpdateInventoryItemPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateInventoryItemPanelControl.SuspendLayout()
        CType(Me.NotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PalletPanelControl.SuspendLayout()
        CType(Me.PalletGrossWeightTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalletTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Location = New System.Drawing.Point(26, 50)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(39, 13)
        NotesLabel.TabIndex = 6
        NotesLabel.Text = "Notes:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(26, 21)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(53, 13)
        QuantityLabel.TabIndex = 4
        QuantityLabel.Text = "Quantity:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 58)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(71, 13)
        Label3.TabIndex = 1
        Label3.Text = "Scale weight:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(10, 25)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(58, 13)
        Label6.TabIndex = 0
        Label6.Text = "Pallet type"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(388, 96)
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
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
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
        'QuantityTextEdit
        '
        Me.QuantityTextEdit.Location = New System.Drawing.Point(85, 18)
        Me.QuantityTextEdit.Name = "QuantityTextEdit"
        Me.QuantityTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.QuantityTextEdit.Properties.MaxLength = 50
        Me.QuantityTextEdit.Size = New System.Drawing.Size(77, 20)
        Me.QuantityTextEdit.TabIndex = 5
        '
        'UpdateInventoryItemPanelControl
        '
        Me.UpdateInventoryItemPanelControl.Controls.Add(QuantityLabel)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.QuantityTextEdit)
        Me.UpdateInventoryItemPanelControl.Controls.Add(NotesLabel)
        Me.UpdateInventoryItemPanelControl.Controls.Add(Me.NotesTextEdit)
        Me.UpdateInventoryItemPanelControl.Location = New System.Drawing.Point(0, 94)
        Me.UpdateInventoryItemPanelControl.Name = "UpdateInventoryItemPanelControl"
        Me.UpdateInventoryItemPanelControl.Size = New System.Drawing.Size(388, 153)
        Me.UpdateInventoryItemPanelControl.TabIndex = 1
        '
        'NotesTextEdit
        '
        Me.NotesTextEdit.EditValue = ""
        Me.NotesTextEdit.Location = New System.Drawing.Point(85, 50)
        Me.NotesTextEdit.Name = "NotesTextEdit"
        Me.NotesTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.NotesTextEdit.Size = New System.Drawing.Size(261, 81)
        Me.NotesTextEdit.TabIndex = 7
        Me.NotesTextEdit.UseOptimizedRendering = True
        '
        'PalletPanelControl
        '
        Me.PalletPanelControl.Controls.Add(Me.PalletGrossWeightTextEdit)
        Me.PalletPanelControl.Controls.Add(Me.PalletTypeLookUpEdit)
        Me.PalletPanelControl.Controls.Add(Label3)
        Me.PalletPanelControl.Controls.Add(Label6)
        Me.PalletPanelControl.Location = New System.Drawing.Point(0, 94)
        Me.PalletPanelControl.Name = "PalletPanelControl"
        Me.PalletPanelControl.Size = New System.Drawing.Size(299, 177)
        Me.PalletPanelControl.TabIndex = 1
        '
        'PalletGrossWeightTextEdit
        '
        Me.PalletGrossWeightTextEdit.EditValue = ""
        Me.PalletGrossWeightTextEdit.Location = New System.Drawing.Point(85, 55)
        Me.PalletGrossWeightTextEdit.Name = "PalletGrossWeightTextEdit"
        Me.PalletGrossWeightTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.PalletGrossWeightTextEdit.Properties.Mask.EditMask = "d"
        Me.PalletGrossWeightTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.PalletGrossWeightTextEdit.Properties.MaxLength = 9
        Me.PalletGrossWeightTextEdit.Size = New System.Drawing.Size(192, 20)
        Me.PalletGrossWeightTextEdit.TabIndex = 2
        '
        'PalletTypeLookUpEdit
        '
        Me.PalletTypeLookUpEdit.Location = New System.Drawing.Point(85, 22)
        Me.PalletTypeLookUpEdit.MenuManager = Me.RibbonControl1
        Me.PalletTypeLookUpEdit.Name = "PalletTypeLookUpEdit"
        Me.PalletTypeLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PalletTypeLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Pallettype", "Pallettype", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Palletweight", "Palletweight", 68, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PalletTypeLookUpEdit.Properties.DisplayMember = "Pallettype"
        Me.PalletTypeLookUpEdit.Properties.NullText = ""
        Me.PalletTypeLookUpEdit.Properties.PopupWidth = 320
        Me.PalletTypeLookUpEdit.Properties.ValueMember = "Palletweight"
        Me.PalletTypeLookUpEdit.Size = New System.Drawing.Size(192, 20)
        Me.PalletTypeLookUpEdit.TabIndex = 0
        '
        'frmAdditionalQuantity
        '
        Me.ClientSize = New System.Drawing.Size(388, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.UpdateInventoryItemPanelControl)
        Me.Controls.Add(Me.PalletPanelControl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAdditionalQuantity"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Additional Quantity"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UpdateInventoryItemPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateInventoryItemPanelControl.ResumeLayout(False)
        Me.UpdateInventoryItemPanelControl.PerformLayout()
        CType(Me.NotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PalletPanelControl.ResumeLayout(False)
        Me.PalletPanelControl.PerformLayout()
        CType(Me.PalletGrossWeightTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalletTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents QuantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UpdateInventoryItemPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PalletPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PalletTypeLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PalletGrossWeightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NotesTextEdit As DevExpress.XtraEditors.MemoEdit
End Class
