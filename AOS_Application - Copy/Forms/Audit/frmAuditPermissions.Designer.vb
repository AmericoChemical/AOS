<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditPermissions
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
        Dim UserLoginLabel As System.Windows.Forms.Label
        Dim AuditCategoryLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuditPermissions))
        Me.CategoryLookupEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsAuditPermission = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAuditCategories = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.RepositoryItemWeekOfMonth1 = New DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.btnAlterDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.UserLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsAppUsers = New System.Windows.Forms.BindingSource(Me.components)
        UserLoginLabel = New System.Windows.Forms.Label()
        AuditCategoryLabel = New System.Windows.Forms.Label()
        CType(Me.CategoryLookupEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAuditPermission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAuditCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.UserLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAppUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserLoginLabel
        '
        UserLoginLabel.AutoSize = True
        UserLoginLabel.Location = New System.Drawing.Point(44, 61)
        UserLoginLabel.Name = "UserLoginLabel"
        UserLoginLabel.Size = New System.Drawing.Size(57, 13)
        UserLoginLabel.TabIndex = 4
        UserLoginLabel.Text = "User Login"
        '
        'AuditCategoryLabel
        '
        AuditCategoryLabel.AutoSize = True
        AuditCategoryLabel.Location = New System.Drawing.Point(21, 35)
        AuditCategoryLabel.Name = "AuditCategoryLabel"
        AuditCategoryLabel.Size = New System.Drawing.Size(80, 13)
        AuditCategoryLabel.TabIndex = 2
        AuditCategoryLabel.Text = "Audit Category"
        '
        'CategoryLookupEdit
        '
        Me.CategoryLookupEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditPermission, "Auditcategoryid", True))
        Me.CategoryLookupEdit.Location = New System.Drawing.Point(105, 32)
        Me.CategoryLookupEdit.Name = "CategoryLookupEdit"
        Me.CategoryLookupEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CategoryLookupEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Auditcategory", "Audit Category", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Auditformname", "Audit Form Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CategoryLookupEdit.Properties.DataSource = Me.bsAuditCategories
        Me.CategoryLookupEdit.Properties.DisplayMember = "Auditcategory"
        Me.CategoryLookupEdit.Properties.DropDownRows = 10
        Me.CategoryLookupEdit.Properties.NullText = ""
        Me.CategoryLookupEdit.Properties.PopupFormMinSize = New System.Drawing.Size(100, 0)
        Me.CategoryLookupEdit.Properties.PopupWidth = 300
        Me.CategoryLookupEdit.Properties.ValueMember = "Auditcategoryid"
        Me.CategoryLookupEdit.Size = New System.Drawing.Size(222, 20)
        Me.CategoryLookupEdit.TabIndex = 3
        '
        'bsAuditPermission
        '
        Me.bsAuditPermission.DataSource = GetType(AOS.BusinessObjects.Auditpermissions)
        '
        'bsAuditCategories
        '
        Me.bsAuditCategories.DataSource = GetType(AOS.BusinessObjects.AuditcategoryCollection)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Tag = "8"
        '
        'RepositoryItemAppointmentLabel1
        '
        Me.RepositoryItemAppointmentLabel1.AutoHeight = False
        Me.RepositoryItemAppointmentLabel1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemAppointmentLabel1.Name = "RepositoryItemAppointmentLabel1"
        '
        'RepositoryItemWeekOfMonth1
        '
        Me.RepositoryItemWeekOfMonth1.AutoHeight = False
        Me.RepositoryItemWeekOfMonth1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemWeekOfMonth1.Name = "RepositoryItemWeekOfMonth1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Audit Permission"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Permission"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Permission"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'btnAlterDelete
        '
        Me.btnAlterDelete.Caption = "Delete Comp alternate"
        Me.btnAlterDelete.Glyph = CType(resources.GetObject("btnAlterDelete.Glyph"), System.Drawing.Image)
        Me.btnAlterDelete.Id = 26
        Me.btnAlterDelete.Name = "btnAlterDelete"
        '
        'btnAlterEdit
        '
        Me.btnAlterEdit.Caption = "Edit Comp Alternate"
        Me.btnAlterEdit.Glyph = Global.AOS.My.Resources.Resources.document_edit__2_
        Me.btnAlterEdit.Id = 25
        Me.btnAlterEdit.Name = "btnAlterEdit"
        '
        'btnAlterAdd
        '
        Me.btnAlterAdd.Caption = "Add New Comp Alternate"
        Me.btnAlterAdd.Id = 24
        Me.btnAlterAdd.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAlterAdd.Name = "btnAlterAdd"
        '
        'ComponentRibbonControl1
        '
        Me.ComponentRibbonControl1.ApplicationButtonText = Nothing
        Me.ComponentRibbonControl1.ExpandCollapseItem.Id = 0
        Me.ComponentRibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ComponentRibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnAlterAdd, Me.btnAlterEdit, Me.btnAlterDelete})
        Me.ComponentRibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ComponentRibbonControl1.MaxItemId = 28
        Me.ComponentRibbonControl1.Name = "ComponentRibbonControl1"
        Me.ComponentRibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ComponentRibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemWeekOfMonth1, Me.RepositoryItemAppointmentLabel1})
        Me.ComponentRibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ComponentRibbonControl1.ShowToolbarCustomizeItem = False
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(356, 96)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.UserLookUpEdit)
        Me.GroupControl1.Controls.Add(UserLoginLabel)
        Me.GroupControl1.Controls.Add(Me.CategoryLookupEdit)
        Me.GroupControl1.Controls.Add(AuditCategoryLabel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl1.Location = New System.Drawing.Point(0, 93)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(356, 102)
        Me.GroupControl1.TabIndex = 13
        Me.GroupControl1.Text = "Audit Permission Information"
        '
        'UserLookUpEdit
        '
        Me.UserLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAuditPermission, "Userid", True))
        Me.UserLookUpEdit.Location = New System.Drawing.Point(105, 58)
        Me.UserLookUpEdit.Name = "UserLookUpEdit"
        Me.UserLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.UserLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Userlogin", "User Login", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.UserLookUpEdit.Properties.DataSource = Me.bsAppUsers
        Me.UserLookUpEdit.Properties.DisplayMember = "Userlogin"
        Me.UserLookUpEdit.Properties.DropDownRows = 10
        Me.UserLookUpEdit.Properties.NullText = ""
        Me.UserLookUpEdit.Properties.PopupFormMinSize = New System.Drawing.Size(100, 0)
        Me.UserLookUpEdit.Properties.PopupWidth = 300
        Me.UserLookUpEdit.Properties.ShowFooter = False
        Me.UserLookUpEdit.Properties.ShowHeader = False
        Me.UserLookUpEdit.Properties.ValueMember = "Appuserid"
        Me.UserLookUpEdit.Size = New System.Drawing.Size(222, 20)
        Me.UserLookUpEdit.TabIndex = 8
        '
        'bsAppUsers
        '
        Me.bsAppUsers.DataSource = GetType(AOS.BusinessObjects.ViewAppuserCollection)
        '
        'frmAuditPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 195)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAuditPermissions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audit Permission Information"
        CType(Me.CategoryLookupEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAuditPermission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAuditCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.UserLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAppUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents CategoryLookupEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsAuditPermission As System.Windows.Forms.BindingSource
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel
    Friend WithEvents RepositoryItemWeekOfMonth1 As DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnAlterDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ComponentRibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Public WithEvents UserLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsAppUsers As System.Windows.Forms.BindingSource
    Friend WithEvents bsAuditCategories As System.Windows.Forms.BindingSource
End Class
