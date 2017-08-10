<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditRelabelInstruction

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
        Dim SequenceLabel As System.Windows.Forms.Label
        Dim RelabelInstructionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditRelabelInstruction))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsRelabelInstruction = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RelabelInstructionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.SequenceTextEdit = New DevExpress.XtraEditors.TextEdit()
        SequenceLabel = New System.Windows.Forms.Label()
        RelabelInstructionLabel = New System.Windows.Forms.Label()
        CType(Me.bsRelabelInstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelabelInstructionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SequenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SequenceLabel
        '
        SequenceLabel.AutoSize = True
        SequenceLabel.Location = New System.Drawing.Point(11, 103)
        SequenceLabel.Name = "SequenceLabel"
        SequenceLabel.Size = New System.Drawing.Size(58, 13)
        SequenceLabel.TabIndex = 1
        SequenceLabel.Text = "Sequence:"
        '
        'RelabelInstructionLabel
        '
        RelabelInstructionLabel.AutoSize = True
        RelabelInstructionLabel.Location = New System.Drawing.Point(6, 129)
        RelabelInstructionLabel.Name = "RelabelInstructionLabel"
        RelabelInstructionLabel.Size = New System.Drawing.Size(63, 13)
        RelabelInstructionLabel.TabIndex = 3
        RelabelInstructionLabel.Text = "Instruction:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsRelabelInstruction
        '
        Me.bsRelabelInstruction.DataSource = GetType(AOS.BusinessObjects.Relabelinstruction)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(447, 95)
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
        Me.btnSave.LargeImageIndex = 21
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 22
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
        'RelabelInstructionMemoEdit
        '
        Me.RelabelInstructionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelInstruction, "Relabelinstruction", True))
        Me.RelabelInstructionMemoEdit.Location = New System.Drawing.Point(73, 126)
        Me.RelabelInstructionMemoEdit.MenuManager = Me.RibbonControl1
        Me.RelabelInstructionMemoEdit.Name = "RelabelInstructionMemoEdit"
        Me.RelabelInstructionMemoEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.RelabelInstructionMemoEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RelabelInstructionMemoEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RelabelInstructionMemoEdit.Size = New System.Drawing.Size(362, 96)
        Me.RelabelInstructionMemoEdit.TabIndex = 0
        '
        'SequenceTextEdit
        '
        Me.SequenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelInstruction, "Sequence", True))
        Me.SequenceTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SequenceTextEdit.Location = New System.Drawing.Point(73, 100)
        Me.SequenceTextEdit.MenuManager = Me.RibbonControl1
        Me.SequenceTextEdit.Name = "SequenceTextEdit"
        Me.SequenceTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.SequenceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SequenceTextEdit.Properties.ReadOnly = True
        Me.SequenceTextEdit.Size = New System.Drawing.Size(33, 20)
        Me.SequenceTextEdit.TabIndex = 2
        Me.SequenceTextEdit.TabStop = False
        '
        'frmAddEditRelabelInstruction
        '
        Me.ClientSize = New System.Drawing.Size(447, 236)
        Me.ControlBox = False
        Me.Controls.Add(RelabelInstructionLabel)
        Me.Controls.Add(Me.RelabelInstructionMemoEdit)
        Me.Controls.Add(SequenceLabel)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.SequenceTextEdit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditRelabelInstruction"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Template Relabel Instruction"
        CType(Me.bsRelabelInstruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelabelInstructionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SequenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsRelabelInstruction As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RelabelInstructionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents SequenceTextEdit As DevExpress.XtraEditors.TextEdit
End Class
