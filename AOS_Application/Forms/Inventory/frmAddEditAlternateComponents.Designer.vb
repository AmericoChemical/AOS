<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditAlternateComponents

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
        Dim AmericoDescLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditAlternateComponents))
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.bsAltComponent = New System.Windows.Forms.BindingSource()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemWeekOfMonth1 = New DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth()
        Me.RepositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.btnAlterAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bsComponent = New System.Windows.Forms.BindingSource()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.AmericoDescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsComponents = New System.Windows.Forms.BindingSource()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.AltComponentLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        AmericoDescLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        CType(Me.bsAltComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.AmericoDescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.AltComponentLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmericoDescLabel
        '
        AmericoDescLabel.AutoSize = True
        AmericoDescLabel.Location = New System.Drawing.Point(25, 35)
        AmericoDescLabel.Name = "AmericoDescLabel"
        AmericoDescLabel.Size = New System.Drawing.Size(71, 13)
        AmericoDescLabel.TabIndex = 2
        AmericoDescLabel.Text = "Americo Desc"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(14, 37)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(82, 13)
        ContainerLabel.TabIndex = 6
        ContainerLabel.Text = "Comp Alternate"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsAltComponent
        '
        Me.bsAltComponent.DataSource = GetType(AOS.BusinessObjects.Altcomponent)
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Tag = "8"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Component Alternate"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alternate"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Alternate"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RepositoryItemWeekOfMonth1
        '
        Me.RepositoryItemWeekOfMonth1.AutoHeight = False
        Me.RepositoryItemWeekOfMonth1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemWeekOfMonth1.Name = "RepositoryItemWeekOfMonth1"
        '
        'RepositoryItemAppointmentLabel1
        '
        Me.RepositoryItemAppointmentLabel1.AutoHeight = False
        Me.RepositoryItemAppointmentLabel1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemAppointmentLabel1.Name = "RepositoryItemAppointmentLabel1"
        '
        'btnAlterAdd
        '
        Me.btnAlterAdd.Caption = "Add New Comp Alternate"
        Me.btnAlterAdd.Id = 24
        Me.btnAlterAdd.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAlterAdd.Name = "btnAlterAdd"
        '
        'btnAlterEdit
        '
        Me.btnAlterEdit.Caption = "Edit Comp Alternate"
        Me.btnAlterEdit.Glyph = Global.AOS.My.Resources.Resources.document_edit__2_
        Me.btnAlterEdit.Id = 25
        Me.btnAlterEdit.Name = "btnAlterEdit"
        '
        'btnAlterDelete
        '
        Me.btnAlterDelete.Caption = "Delete Comp alternate"
        Me.btnAlterDelete.Glyph = CType(resources.GetObject("btnAlterDelete.Glyph"), System.Drawing.Image)
        Me.btnAlterDelete.Id = 26
        Me.btnAlterDelete.Name = "btnAlterDelete"
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
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(439, 96)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bsComponent
        '
        Me.bsComponent.DataSource = GetType(AOS.BusinessObjects.Component)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(AmericoDescLabel)
        Me.GroupControl1.Controls.Add(Me.AmericoDescTextEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(3, 101)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(433, 69)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Component Information"
        '
        'AmericoDescTextEdit
        '
        Me.AmericoDescTextEdit.Location = New System.Drawing.Point(98, 32)
        Me.AmericoDescTextEdit.Name = "AmericoDescTextEdit"
        Me.AmericoDescTextEdit.Properties.MaxLength = 510
        Me.AmericoDescTextEdit.Size = New System.Drawing.Size(322, 20)
        Me.AmericoDescTextEdit.TabIndex = 3
        '
        'bsComponents
        '
        Me.bsComponents.DataSource = GetType(AOS.BusinessObjects.ComponentCollection)
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.AltComponentLookUpEdit)
        Me.GroupControl2.Controls.Add(ContainerLabel)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 176)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(433, 67)
        Me.GroupControl2.TabIndex = 10
        Me.GroupControl2.Text = "Component Alternate(s)"
        '
        'AltComponentLookUpEdit
        '
        Me.AltComponentLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsAltComponent, "Altcomponentid", True))
        Me.AltComponentLookUpEdit.Location = New System.Drawing.Point(98, 34)
        Me.AltComponentLookUpEdit.Name = "AltComponentLookUpEdit"
        Me.AltComponentLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AltComponentLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Componentid", "Comp ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Componentdesc", "Americo Desc", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.AltComponentLookUpEdit.Properties.DataSource = Me.bsComponents
        Me.AltComponentLookUpEdit.Properties.DisplayMember = "Componentdesc"
        Me.AltComponentLookUpEdit.Properties.DropDownRows = 10
        Me.AltComponentLookUpEdit.Properties.NullText = ""
        Me.AltComponentLookUpEdit.Properties.PopupFormMinSize = New System.Drawing.Size(100, 0)
        Me.AltComponentLookUpEdit.Properties.PopupWidth = 300
        Me.AltComponentLookUpEdit.Properties.ValueMember = "Componentid"
        Me.AltComponentLookUpEdit.Size = New System.Drawing.Size(322, 20)
        Me.AltComponentLookUpEdit.TabIndex = 2
        '
        'frmAddEditAlternateComponents
        '
        Me.ClientSize = New System.Drawing.Size(439, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditAlternateComponents"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Component Alternate Information"
        CType(Me.bsAltComponent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.AmericoDescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComponents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.AltComponentLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsAltComponent As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemWeekOfMonth1 As DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth
    Friend WithEvents RepositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel
    Friend WithEvents btnAlterAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ComponentRibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsComponents As System.Windows.Forms.BindingSource
    Friend WithEvents bsComponent As System.Windows.Forms.BindingSource
    Public WithEvents AltComponentLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents AmericoDescTextEdit As DevExpress.XtraEditors.TextEdit
End Class
