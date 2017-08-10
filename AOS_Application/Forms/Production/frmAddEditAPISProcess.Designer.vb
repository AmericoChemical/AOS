<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditAPISProcess

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
        Dim ProcessseqLabel As System.Windows.Forms.Label
        Dim ProcesstextLabel As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.ProcesstextMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ProcessseqTextEdit = New DevExpress.XtraEditors.SpinEdit()
        ProcessseqLabel = New System.Windows.Forms.Label()
        ProcesstextLabel = New System.Windows.Forms.Label()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcesstextMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcessseqTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProcessseqLabel
        '
        ProcessseqLabel.AutoSize = True
        ProcessseqLabel.Location = New System.Drawing.Point(11, 103)
        ProcessseqLabel.Name = "ProcessseqLabel"
        ProcessseqLabel.Size = New System.Drawing.Size(44, 13)
        ProcessseqLabel.TabIndex = 1
        ProcessseqLabel.Text = "Step #:"
        '
        'ProcesstextLabel
        '
        ProcesstextLabel.AutoSize = True
        ProcesstextLabel.Location = New System.Drawing.Point(7, 129)
        ProcesstextLabel.Name = "ProcesstextLabel"
        ProcesstextLabel.Size = New System.Drawing.Size(48, 13)
        ProcesstextLabel.TabIndex = 3
        ProcesstextLabel.Text = "Process:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.ApisprocedureCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        '
        '
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(447, 98)
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
        'ProcesstextMemoEdit
        '
        Me.ProcesstextMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Apisprocedure", True))
        Me.ProcesstextMemoEdit.Location = New System.Drawing.Point(61, 126)
        Me.ProcesstextMemoEdit.MenuManager = Me.RibbonControl1
        Me.ProcesstextMemoEdit.Name = "ProcesstextMemoEdit"
        Me.ProcesstextMemoEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.ProcesstextMemoEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.ProcesstextMemoEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.ProcesstextMemoEdit.Size = New System.Drawing.Size(374, 96)
        Me.ProcesstextMemoEdit.TabIndex = 4
        '
        'ProcessseqTextEdit
        '
        Me.ProcessseqTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Sequence", True))
        Me.ProcessseqTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ProcessseqTextEdit.Location = New System.Drawing.Point(61, 100)
        Me.ProcessseqTextEdit.MenuManager = Me.RibbonControl1
        Me.ProcessseqTextEdit.Name = "ProcessseqTextEdit"
        Me.ProcessseqTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProcessseqTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.ProcessseqTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.ProcessseqTextEdit.Size = New System.Drawing.Size(43, 20)
        Me.ProcessseqTextEdit.TabIndex = 2
        '
        'frmAddEditAPISProcess
        '
        Me.ClientSize = New System.Drawing.Size(447, 236)
        Me.ControlBox = False
        Me.Controls.Add(ProcesstextLabel)
        Me.Controls.Add(Me.ProcesstextMemoEdit)
        Me.Controls.Add(ProcessseqLabel)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.ProcessseqTextEdit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditAPISProcess"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Formula Process Information"
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcesstextMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcessseqTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ProcesstextMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ProcessseqTextEdit As DevExpress.XtraEditors.SpinEdit
End Class
