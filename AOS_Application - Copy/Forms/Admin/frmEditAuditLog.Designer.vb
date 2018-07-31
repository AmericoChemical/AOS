<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAuditLog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim OccurrenceDateLabel As System.Windows.Forms.Label
        Dim ResolutionLabel As System.Windows.Forms.Label
        Dim ResolvedDateLabel As System.Windows.Forms.Label
        Dim OccurrenceByLabel As System.Windows.Forms.Label
        Dim ResolvedByLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsAuditLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OccurrenceByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ResolvedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eResolvedDate = New DevExpress.XtraEditors.DateEdit()
        Me.eOccurrenceDate = New DevExpress.XtraEditors.DateEdit()
        Me.StatusTextEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.TypeTextEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ResolutionTextEdit = New DevExpress.XtraEditors.MemoEdit()
        DescriptionLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        OccurrenceDateLabel = New System.Windows.Forms.Label()
        ResolutionLabel = New System.Windows.Forms.Label()
        ResolvedDateLabel = New System.Windows.Forms.Label()
        OccurrenceByLabel = New System.Windows.Forms.Label()
        ResolvedByLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAuditLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OccurrenceByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResolvedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eResolvedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eResolvedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eOccurrenceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eOccurrenceDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResolutionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(60, 160)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 7
        DescriptionLabel.Text = "Description:"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(71, 114)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 6
        CategoryLabel.Text = "Category:"
        '
        'OccurrenceDateLabel
        '
        OccurrenceDateLabel.AutoSize = True
        OccurrenceDateLabel.Location = New System.Drawing.Point(31, 339)
        OccurrenceDateLabel.Name = "OccurrenceDateLabel"
        OccurrenceDateLabel.Size = New System.Drawing.Size(92, 13)
        OccurrenceDateLabel.TabIndex = 12
        OccurrenceDateLabel.Text = "Occurrence Date:"
        '
        'ResolutionLabel
        '
        ResolutionLabel.AutoSize = True
        ResolutionLabel.Location = New System.Drawing.Point(63, 286)
        ResolutionLabel.Name = "ResolutionLabel"
        ResolutionLabel.Size = New System.Drawing.Size(60, 13)
        ResolutionLabel.TabIndex = 11
        ResolutionLabel.Text = "Resolution:"
        '
        'ResolvedDateLabel
        '
        ResolvedDateLabel.AutoSize = True
        ResolvedDateLabel.Location = New System.Drawing.Point(42, 391)
        ResolvedDateLabel.Name = "ResolvedDateLabel"
        ResolvedDateLabel.Size = New System.Drawing.Size(81, 13)
        ResolvedDateLabel.TabIndex = 16
        ResolvedDateLabel.Text = "Resolved Date:"
        '
        'OccurrenceByLabel
        '
        OccurrenceByLabel.AutoSize = True
        OccurrenceByLabel.Location = New System.Drawing.Point(42, 365)
        OccurrenceByLabel.Name = "OccurrenceByLabel"
        OccurrenceByLabel.Size = New System.Drawing.Size(81, 13)
        OccurrenceByLabel.TabIndex = 15
        OccurrenceByLabel.Text = "Occurrence By:"
        '
        'ResolvedByLabel
        '
        ResolvedByLabel.AutoSize = True
        ResolvedByLabel.Location = New System.Drawing.Point(53, 417)
        ResolvedByLabel.Name = "ResolvedByLabel"
        ResolvedByLabel.Size = New System.Drawing.Size(70, 13)
        ResolvedByLabel.TabIndex = 26
        ResolvedByLabel.Text = "Resolved By:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(83, 239)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 27
        StatusLabel.Text = "Status:"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(89, 213)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(34, 13)
        TypeLabel.TabIndex = 29
        TypeLabel.Text = "Type:"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(425, 96)
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
        'bsAuditLog
        '
        Me.bsAuditLog.DataSource = GetType(AOS.BusinessObjects.Auditlog)
        '
        'CategoryTextEdit
        '
        Me.CategoryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Category", True))
        Me.CategoryTextEdit.Enabled = False
        Me.CategoryTextEdit.Location = New System.Drawing.Point(135, 111)
        Me.CategoryTextEdit.MenuManager = Me.RibbonControl1
        Me.CategoryTextEdit.Name = "CategoryTextEdit"
        Me.CategoryTextEdit.Size = New System.Drawing.Size(252, 20)
        Me.CategoryTextEdit.TabIndex = 4
        '
        'OccurrenceByTextEdit
        '
        Me.OccurrenceByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Occurrenceby", True))
        Me.OccurrenceByTextEdit.Enabled = False
        Me.OccurrenceByTextEdit.Location = New System.Drawing.Point(135, 362)
        Me.OccurrenceByTextEdit.MenuManager = Me.RibbonControl1
        Me.OccurrenceByTextEdit.Name = "OccurrenceByTextEdit"
        Me.OccurrenceByTextEdit.Size = New System.Drawing.Size(252, 20)
        Me.OccurrenceByTextEdit.TabIndex = 13
        '
        'ResolvedByTextEdit
        '
        Me.ResolvedByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Resolvedby", True))
        Me.ResolvedByTextEdit.Enabled = False
        Me.ResolvedByTextEdit.Location = New System.Drawing.Point(135, 414)
        Me.ResolvedByTextEdit.MenuManager = Me.RibbonControl1
        Me.ResolvedByTextEdit.Name = "ResolvedByTextEdit"
        Me.ResolvedByTextEdit.Size = New System.Drawing.Size(252, 20)
        Me.ResolvedByTextEdit.TabIndex = 25
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eResolvedDate
        '
        Me.eResolvedDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Resolved", True))
        Me.eResolvedDate.EditValue = Nothing
        Me.eResolvedDate.Enabled = False
        Me.eResolvedDate.Location = New System.Drawing.Point(135, 388)
        Me.eResolvedDate.Name = "eResolvedDate"
        Me.eResolvedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eResolvedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eResolvedDate.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.eResolvedDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.eResolvedDate.Size = New System.Drawing.Size(75, 20)
        Me.eResolvedDate.TabIndex = 24
        '
        'eOccurrenceDate
        '
        Me.eOccurrenceDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Occurrence", True))
        Me.eOccurrenceDate.EditValue = Nothing
        Me.eOccurrenceDate.Enabled = False
        Me.eOccurrenceDate.Location = New System.Drawing.Point(135, 336)
        Me.eOccurrenceDate.Name = "eOccurrenceDate"
        Me.eOccurrenceDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eOccurrenceDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eOccurrenceDate.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.eOccurrenceDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.eOccurrenceDate.Size = New System.Drawing.Size(75, 20)
        Me.eOccurrenceDate.TabIndex = 23
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Status", True))
        Me.StatusTextEdit.Location = New System.Drawing.Point(135, 236)
        Me.StatusTextEdit.MenuManager = Me.RibbonControl1
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StatusTextEdit.Properties.Items.AddRange(New Object() {"Open", "In Progress", "Closed"})
        Me.StatusTextEdit.Size = New System.Drawing.Size(75, 20)
        Me.StatusTextEdit.TabIndex = 32
        '
        'TypeTextEdit
        '
        Me.TypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Type", True))
        Me.TypeTextEdit.Enabled = False
        Me.TypeTextEdit.Location = New System.Drawing.Point(135, 210)
        Me.TypeTextEdit.MenuManager = Me.RibbonControl1
        Me.TypeTextEdit.Name = "TypeTextEdit"
        Me.TypeTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TypeTextEdit.Properties.Items.AddRange(New Object() {"Info", "Warning", "Error"})
        Me.TypeTextEdit.Size = New System.Drawing.Size(75, 20)
        Me.TypeTextEdit.TabIndex = 33
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Description", True))
        Me.DescriptionTextEdit.Enabled = False
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(135, 137)
        Me.DescriptionTextEdit.MenuManager = Me.RibbonControl1
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(252, 65)
        Me.DescriptionTextEdit.TabIndex = 5
        Me.DescriptionTextEdit.UseOptimizedRendering = True
        '
        'ResolutionTextEdit
        '
        Me.ResolutionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Resolution", True))
        Me.ResolutionTextEdit.Location = New System.Drawing.Point(135, 262)
        Me.ResolutionTextEdit.MenuManager = Me.RibbonControl1
        Me.ResolutionTextEdit.Name = "ResolutionTextEdit"
        Me.ResolutionTextEdit.Size = New System.Drawing.Size(252, 65)
        Me.ResolutionTextEdit.TabIndex = 9
        Me.ResolutionTextEdit.UseOptimizedRendering = True
        '
        'frmEditAuditLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 451)
        Me.Controls.Add(Me.TypeTextEdit)
        Me.Controls.Add(Me.StatusTextEdit)
        Me.Controls.Add(TypeLabel)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(ResolvedByLabel)
        Me.Controls.Add(Me.ResolvedByTextEdit)
        Me.Controls.Add(Me.eResolvedDate)
        Me.Controls.Add(Me.eOccurrenceDate)
        Me.Controls.Add(ResolvedDateLabel)
        Me.Controls.Add(OccurrenceByLabel)
        Me.Controls.Add(Me.OccurrenceByTextEdit)
        Me.Controls.Add(OccurrenceDateLabel)
        Me.Controls.Add(ResolutionLabel)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextEdit)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.DescriptionTextEdit)
        Me.Controls.Add(Me.ResolutionTextEdit)
        Me.Name = "frmEditAuditLog"
        Me.Text = "Audit Log Information"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAuditLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OccurrenceByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResolvedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eResolvedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eResolvedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eOccurrenceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eOccurrenceDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResolutionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CategoryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OccurrenceByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ResolvedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsAuditLog As System.Windows.Forms.BindingSource
    Friend WithEvents eResolvedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eOccurrenceDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents TypeTextEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ResolutionTextEdit As DevExpress.XtraEditors.MemoEdit
End Class
