<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditAuditLog
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim Label1 As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim ClosedByLabel As System.Windows.Forms.Label
        Dim ClosedDateLabel As System.Windows.Forms.Label
        Dim OccurrenceByLabel As System.Windows.Forms.Label
        Dim OccurrenceDateLabel As System.Windows.Forms.Label
        Dim ClosingCommentLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnResolveIssue = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsAuditLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gcAuditLogInformation = New DevExpress.XtraEditors.GroupControl()
        Me.CategoryLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.AuditReasonMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.TypeTextEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.StatusTextEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.ResolvedByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eResolvedDate = New DevExpress.XtraEditors.DateEdit()
        Me.eOccurrenceDate = New DevExpress.XtraEditors.DateEdit()
        Me.OccurrenceByTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DescriptionTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ResolutionTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.bsAuditcategory = New System.Windows.Forms.BindingSource(Me.components)
        Label1 = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        ClosedByLabel = New System.Windows.Forms.Label()
        ClosedDateLabel = New System.Windows.Forms.Label()
        OccurrenceByLabel = New System.Windows.Forms.Label()
        OccurrenceDateLabel = New System.Windows.Forms.Label()
        ClosingCommentLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAuditLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcAuditLogInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcAuditLogInformation.SuspendLayout()
        CType(Me.CategoryLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditReasonMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResolvedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eResolvedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eResolvedDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eOccurrenceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eOccurrenceDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OccurrenceByTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResolutionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAuditcategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(44, 117)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 13)
        Label1.TabIndex = 5
        Label1.Text = "Audit Reason"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(84, 176)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(31, 13)
        TypeLabel.TabIndex = 7
        TypeLabel.Text = "Type"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(77, 202)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(38, 13)
        StatusLabel.TabIndex = 9
        StatusLabel.Text = "Status"
        '
        'ClosedByLabel
        '
        ClosedByLabel.AutoSize = True
        ClosedByLabel.Location = New System.Drawing.Point(61, 366)
        ClosedByLabel.Name = "ClosedByLabel"
        ClosedByLabel.Size = New System.Drawing.Size(54, 13)
        ClosedByLabel.TabIndex = 19
        ClosedByLabel.Text = "Closed By"
        '
        'ClosedDateLabel
        '
        ClosedDateLabel.AutoSize = True
        ClosedDateLabel.Location = New System.Drawing.Point(50, 340)
        ClosedDateLabel.Name = "ClosedDateLabel"
        ClosedDateLabel.Size = New System.Drawing.Size(65, 13)
        ClosedDateLabel.TabIndex = 17
        ClosedDateLabel.Text = "Closed Date"
        '
        'OccurrenceByLabel
        '
        OccurrenceByLabel.AutoSize = True
        OccurrenceByLabel.Location = New System.Drawing.Point(49, 314)
        OccurrenceByLabel.Name = "OccurrenceByLabel"
        OccurrenceByLabel.Size = New System.Drawing.Size(66, 13)
        OccurrenceByLabel.TabIndex = 15
        OccurrenceByLabel.Text = "Occurred By"
        '
        'OccurrenceDateLabel
        '
        OccurrenceDateLabel.AutoSize = True
        OccurrenceDateLabel.Location = New System.Drawing.Point(27, 288)
        OccurrenceDateLabel.Name = "OccurrenceDateLabel"
        OccurrenceDateLabel.Size = New System.Drawing.Size(88, 13)
        OccurrenceDateLabel.TabIndex = 13
        OccurrenceDateLabel.Text = "Occurrence Date"
        '
        'ClosingCommentLabel
        '
        ClosingCommentLabel.AutoSize = True
        ClosingCommentLabel.Location = New System.Drawing.Point(21, 228)
        ClosingCommentLabel.Name = "ClosingCommentLabel"
        ClosingCommentLabel.Size = New System.Drawing.Size(94, 13)
        ClosingCommentLabel.TabIndex = 11
        ClosingCommentLabel.Text = "Closing Comments"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(55, 58)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(60, 13)
        DescriptionLabel.TabIndex = 3
        DescriptionLabel.Text = "Description"
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Location = New System.Drawing.Point(63, 32)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(52, 13)
        CategoryLabel.TabIndex = 1
        CategoryLabel.Text = "Category"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel, Me.btnResolveIssue})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
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
        Me.btnSave.Caption = " Save  Log"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Log"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'btnResolveIssue
        '
        Me.btnResolveIssue.Caption = "Resolve Issue"
        Me.btnResolveIssue.Id = 6
        Me.btnResolveIssue.LargeGlyph = Global.AOS.My.Resources.Resources.document_accept__2_
        Me.btnResolveIssue.Name = "btnResolveIssue"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnResolveIssue)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'bsAuditLog
        '
        Me.bsAuditLog.DataSource = GetType(AOS.BusinessObjects.Auditlog)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'gcAuditLogInformation
        '
        Me.gcAuditLogInformation.Controls.Add(Me.CategoryLookupEdit)
        Me.gcAuditLogInformation.Controls.Add(Label1)
        Me.gcAuditLogInformation.Controls.Add(Me.AuditReasonMemoEdit)
        Me.gcAuditLogInformation.Controls.Add(Me.TypeTextEdit)
        Me.gcAuditLogInformation.Controls.Add(Me.StatusTextEdit)
        Me.gcAuditLogInformation.Controls.Add(TypeLabel)
        Me.gcAuditLogInformation.Controls.Add(StatusLabel)
        Me.gcAuditLogInformation.Controls.Add(ClosedByLabel)
        Me.gcAuditLogInformation.Controls.Add(Me.ResolvedByTextEdit)
        Me.gcAuditLogInformation.Controls.Add(Me.eResolvedDate)
        Me.gcAuditLogInformation.Controls.Add(Me.eOccurrenceDate)
        Me.gcAuditLogInformation.Controls.Add(ClosedDateLabel)
        Me.gcAuditLogInformation.Controls.Add(OccurrenceByLabel)
        Me.gcAuditLogInformation.Controls.Add(Me.OccurrenceByTextEdit)
        Me.gcAuditLogInformation.Controls.Add(OccurrenceDateLabel)
        Me.gcAuditLogInformation.Controls.Add(ClosingCommentLabel)
        Me.gcAuditLogInformation.Controls.Add(DescriptionLabel)
        Me.gcAuditLogInformation.Controls.Add(CategoryLabel)
        Me.gcAuditLogInformation.Controls.Add(Me.DescriptionTextEdit)
        Me.gcAuditLogInformation.Controls.Add(Me.ResolutionTextEdit)
        Me.gcAuditLogInformation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAuditLogInformation.Location = New System.Drawing.Point(0, 96)
        Me.gcAuditLogInformation.Name = "gcAuditLogInformation"
        Me.gcAuditLogInformation.Size = New System.Drawing.Size(425, 398)
        Me.gcAuditLogInformation.TabIndex = 0
        Me.gcAuditLogInformation.Text = "Audit Log Information"
        '
        'CategoryLookupEdit
        '
        Me.CategoryLookupEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Auditcategoryid", True))
        Me.CategoryLookupEdit.Location = New System.Drawing.Point(117, 29)
        Me.CategoryLookupEdit.Name = "CategoryLookupEdit"
        Me.CategoryLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CategoryLookupEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Auditcategory", "Audit Category", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Auditformname", "Audit Form Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CategoryLookupEdit.Properties.DataSource = Me.bsAuditcategory
        Me.CategoryLookupEdit.Properties.DisplayMember = "Auditcategory"
        Me.CategoryLookupEdit.Properties.DropDownRows = 10
        Me.CategoryLookupEdit.Properties.NullText = ""
        Me.CategoryLookupEdit.Properties.PopupFormMinSize = New System.Drawing.Size(100, 0)
        Me.CategoryLookupEdit.Properties.PopupWidth = 300
        Me.CategoryLookupEdit.Properties.ReadOnly = True
        Me.CategoryLookupEdit.Properties.ValueMember = "Auditcategoryid"
        Me.CategoryLookupEdit.Size = New System.Drawing.Size(296, 20)
        Me.CategoryLookupEdit.TabIndex = 2
        '
        'AuditReasonMemoEdit
        '
        Me.AuditReasonMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Auditreason", True))
        Me.AuditReasonMemoEdit.Location = New System.Drawing.Point(117, 114)
        Me.AuditReasonMemoEdit.MenuManager = Me.RibbonControl1
        Me.AuditReasonMemoEdit.Name = "AuditReasonMemoEdit"
        Me.AuditReasonMemoEdit.Properties.ReadOnly = True
        Me.AuditReasonMemoEdit.Size = New System.Drawing.Size(296, 53)
        Me.AuditReasonMemoEdit.TabIndex = 6
        Me.AuditReasonMemoEdit.UseOptimizedRendering = True
        '
        'TypeTextEdit
        '
        Me.TypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Type", True))
        Me.TypeTextEdit.Location = New System.Drawing.Point(117, 173)
        Me.TypeTextEdit.MenuManager = Me.RibbonControl1
        Me.TypeTextEdit.Name = "TypeTextEdit"
        Me.TypeTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TypeTextEdit.Properties.Items.AddRange(New Object() {"Info", "Warning", "Error"})
        Me.TypeTextEdit.Properties.ReadOnly = True
        Me.TypeTextEdit.Size = New System.Drawing.Size(90, 20)
        Me.TypeTextEdit.TabIndex = 8
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Status", True))
        Me.StatusTextEdit.EditValue = "IN PROGRESS"
        Me.StatusTextEdit.Location = New System.Drawing.Point(117, 199)
        Me.StatusTextEdit.MenuManager = Me.RibbonControl1
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StatusTextEdit.Properties.Items.AddRange(New Object() {"OPEN", "IN PROGRESS", "CLOSED"})
        Me.StatusTextEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.StatusTextEdit.Size = New System.Drawing.Size(90, 20)
        Me.StatusTextEdit.TabIndex = 10
        '
        'ResolvedByTextEdit
        '
        Me.ResolvedByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Resolvedby", True))
        Me.ResolvedByTextEdit.Location = New System.Drawing.Point(117, 363)
        Me.ResolvedByTextEdit.MenuManager = Me.RibbonControl1
        Me.ResolvedByTextEdit.Name = "ResolvedByTextEdit"
        Me.ResolvedByTextEdit.Properties.ReadOnly = True
        Me.ResolvedByTextEdit.Size = New System.Drawing.Size(296, 20)
        Me.ResolvedByTextEdit.TabIndex = 20
        '
        'eResolvedDate
        '
        Me.eResolvedDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Resolved", True))
        Me.eResolvedDate.EditValue = Nothing
        Me.eResolvedDate.Location = New System.Drawing.Point(117, 337)
        Me.eResolvedDate.Name = "eResolvedDate"
        Me.eResolvedDate.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[False]
        Me.eResolvedDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eResolvedDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eResolvedDate.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.eResolvedDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.eResolvedDate.Properties.ReadOnly = True
        Me.eResolvedDate.Size = New System.Drawing.Size(90, 20)
        Me.eResolvedDate.TabIndex = 18
        '
        'eOccurrenceDate
        '
        Me.eOccurrenceDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Occurrence", True))
        Me.eOccurrenceDate.EditValue = Nothing
        Me.eOccurrenceDate.Location = New System.Drawing.Point(117, 285)
        Me.eOccurrenceDate.Name = "eOccurrenceDate"
        Me.eOccurrenceDate.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[False]
        Me.eOccurrenceDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eOccurrenceDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eOccurrenceDate.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.eOccurrenceDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.eOccurrenceDate.Properties.ReadOnly = True
        Me.eOccurrenceDate.Size = New System.Drawing.Size(90, 20)
        Me.eOccurrenceDate.TabIndex = 14
        '
        'OccurrenceByTextEdit
        '
        Me.OccurrenceByTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Occurrenceby", True))
        Me.OccurrenceByTextEdit.Location = New System.Drawing.Point(117, 311)
        Me.OccurrenceByTextEdit.MenuManager = Me.RibbonControl1
        Me.OccurrenceByTextEdit.Name = "OccurrenceByTextEdit"
        Me.OccurrenceByTextEdit.Properties.ReadOnly = True
        Me.OccurrenceByTextEdit.Size = New System.Drawing.Size(296, 20)
        Me.OccurrenceByTextEdit.TabIndex = 16
        '
        'DescriptionTextEdit
        '
        Me.DescriptionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Description", True))
        Me.DescriptionTextEdit.Location = New System.Drawing.Point(117, 55)
        Me.DescriptionTextEdit.MenuManager = Me.RibbonControl1
        Me.DescriptionTextEdit.Name = "DescriptionTextEdit"
        Me.DescriptionTextEdit.Properties.ReadOnly = True
        Me.DescriptionTextEdit.Size = New System.Drawing.Size(296, 53)
        Me.DescriptionTextEdit.TabIndex = 4
        Me.DescriptionTextEdit.UseOptimizedRendering = True
        '
        'ResolutionTextEdit
        '
        Me.ResolutionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditLog, "Resolution", True))
        Me.ResolutionTextEdit.Location = New System.Drawing.Point(117, 225)
        Me.ResolutionTextEdit.MenuManager = Me.RibbonControl1
        Me.ResolutionTextEdit.Name = "ResolutionTextEdit"
        Me.ResolutionTextEdit.Size = New System.Drawing.Size(296, 54)
        Me.ResolutionTextEdit.TabIndex = 12
        Me.ResolutionTextEdit.UseOptimizedRendering = True
        '
        'bsAuditcategory
        '
        Me.bsAuditcategory.DataSource = GetType(AOS.BusinessObjects.Auditcategory)
        '
        'frmEditAuditLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.gcAuditLogInformation)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEditAuditLog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audit Log Information"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAuditLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcAuditLogInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcAuditLogInformation.ResumeLayout(False)
        Me.gcAuditLogInformation.PerformLayout()
        CType(Me.CategoryLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditReasonMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResolvedByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eResolvedDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eResolvedDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eOccurrenceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eOccurrenceDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OccurrenceByTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResolutionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAuditcategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsAuditLog As System.Windows.Forms.BindingSource
    Friend WithEvents gcAuditLogInformation As DevExpress.XtraEditors.GroupControl
    Friend WithEvents AuditReasonMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents TypeTextEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents ResolvedByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eResolvedDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eOccurrenceDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents OccurrenceByTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DescriptionTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents ResolutionTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnResolveIssue As DevExpress.XtraBars.BarButtonItem
    Public WithEvents CategoryLookupEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsAuditcategory As System.Windows.Forms.BindingSource
End Class
