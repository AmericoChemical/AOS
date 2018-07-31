<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectAPIS

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
        Me.Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSelect = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemWeekOfMonth1 = New DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth()
        Me.RepositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ProductDetLabel2 = New System.Windows.Forms.Label()
        Me.WorkorderNoLabel = New System.Windows.Forms.Label()
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerLabel = New System.Windows.Forms.Label()
        Me.ProductDetLabel = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grAPIS = New DevExpress.XtraGrid.GridControl()
        Me.bsAPISCollection = New System.Windows.Forms.BindingSource(Me.components)
        Me.viewASPI = New CustomDevExGridView()
        Me.APISID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RepositoryItemRadioGroup2 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grAPIS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAPISCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewASPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(51, 35)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(78, 13)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Work Order #:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ComponentRibbonControl1
        '
        Me.ComponentRibbonControl1.ApplicationButtonText = Nothing
        Me.ComponentRibbonControl1.ExpandCollapseItem.Id = 0
        Me.ComponentRibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ComponentRibbonControl1.ExpandCollapseItem, Me.btnSelect, Me.btnAlterAdd, Me.btnAlterEdit, Me.btnAlterDelete})
        Me.ComponentRibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ComponentRibbonControl1.MaxItemId = 28
        Me.ComponentRibbonControl1.Name = "ComponentRibbonControl1"
        Me.ComponentRibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ComponentRibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemWeekOfMonth1, Me.RepositoryItemAppointmentLabel1})
        Me.ComponentRibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ComponentRibbonControl1.ShowToolbarCustomizeItem = False
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(581, 96)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSelect
        '
        Me.btnSelect.Caption = "Select"
        Me.btnSelect.Id = 4
        Me.btnSelect.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
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
        Me.btnAlterEdit.Id = 25
        Me.btnAlterEdit.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnAlterEdit.Name = "btnAlterEdit"
        Me.btnAlterEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAlterDelete
        '
        Me.btnAlterDelete.Caption = "Delete Comp alternate"
        Me.btnAlterDelete.Id = 26
        Me.btnAlterDelete.Name = "btnAlterDelete"
        Me.btnAlterDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSelect)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
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
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ProductDetLabel2)
        Me.GroupControl1.Controls.Add(Me.WorkorderNoLabel)
        Me.GroupControl1.Controls.Add(Me.Label)
        Me.GroupControl1.Controls.Add(Me.CustomerLabel)
        Me.GroupControl1.Controls.Add(Me.Label1)
        Me.GroupControl1.Controls.Add(Me.ProductDetLabel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 96)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(581, 132)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "APIS Information"
        '
        'ProductDetLabel2
        '
        Me.ProductDetLabel2.AutoSize = True
        Me.ProductDetLabel2.Location = New System.Drawing.Point(51, 108)
        Me.ProductDetLabel2.Name = "ProductDetLabel2"
        Me.ProductDetLabel2.Size = New System.Drawing.Size(351, 13)
        Me.ProductDetLabel2.TabIndex = 5
        Me.ProductDetLabel2.Text = "Please select which APIS you would like to use for the production order."
        '
        'WorkorderNoLabel
        '
        Me.WorkorderNoLabel.AutoSize = True
        Me.WorkorderNoLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProduct, "Workordernumberno", True))
        Me.WorkorderNoLabel.Location = New System.Drawing.Point(134, 35)
        Me.WorkorderNoLabel.Name = "WorkorderNoLabel"
        Me.WorkorderNoLabel.Size = New System.Drawing.Size(36, 13)
        Me.WorkorderNoLabel.TabIndex = 0
        Me.WorkorderNoLabel.Text = "WO #"
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.ViewWorkOrderProductAPIS)
        '
        'CustomerLabel
        '
        Me.CustomerLabel.AutoSize = True
        Me.CustomerLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProduct, "Cusname", True))
        Me.CustomerLabel.Location = New System.Drawing.Point(109, 63)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(53, 13)
        Me.CustomerLabel.TabIndex = 2
        Me.CustomerLabel.Text = "Customer"
        '
        'ProductDetLabel
        '
        Me.ProductDetLabel.AutoSize = True
        Me.ProductDetLabel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProduct, "Productdescription", True))
        Me.ProductDetLabel.Location = New System.Drawing.Point(51, 91)
        Me.ProductDetLabel.Name = "ProductDetLabel"
        Me.ProductDetLabel.Size = New System.Drawing.Size(79, 13)
        Me.ProductDetLabel.TabIndex = 4
        Me.ProductDetLabel.Text = "Product Details"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grAPIS)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 228)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(581, 200)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "APIS"
        '
        'grAPIS
        '
        Me.grAPIS.DataSource = Me.bsAPISCollection
        Me.grAPIS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAPIS.Location = New System.Drawing.Point(2, 21)
        Me.grAPIS.MainView = Me.viewASPI
        Me.grAPIS.Name = "grAPIS"
        Me.grAPIS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit16, Me.RepositoryItemLookUpEdit17, Me.RepositoryItemRadioGroup1, Me.RepositoryItemRadioGroup2})
        Me.grAPIS.Size = New System.Drawing.Size(577, 177)
        Me.grAPIS.TabIndex = 0
        Me.grAPIS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewASPI})
        '
        'bsAPISCollection
        '
        Me.bsAPISCollection.DataSource = GetType(AOS.BusinessObjects.ApisCollection)
        '
        'viewASPI
        '
        Me.viewASPI.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.APISID, Me.Description, Me.Status})
        Me.viewASPI.GridControl = Me.grAPIS
        Me.viewASPI.Name = "viewASPI"
        Me.viewASPI.OptionsBehavior.Editable = False
        Me.viewASPI.OptionsCustomization.AllowFilter = False
        Me.viewASPI.OptionsView.ShowGroupPanel = False
        '
        'APISID
        '
        Me.APISID.Caption = "APIS ID"
        Me.APISID.FieldName = "Apisnum"
        Me.APISID.MinWidth = 10
        Me.APISID.Name = "APISID"
        Me.APISID.Visible = True
        Me.APISID.VisibleIndex = 0
        Me.APISID.Width = 100
        '
        'Description
        '
        Me.Description.Caption = "Description"
        Me.Description.FieldName = "Apisdesc"
        Me.Description.MinWidth = 50
        Me.Description.Name = "Description"
        Me.Description.Visible = True
        Me.Description.VisibleIndex = 1
        Me.Description.Width = 300
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Apisstatus"
        Me.Status.MinWidth = 10
        Me.Status.Name = "Status"
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 2
        Me.Status.Width = 153
        '
        'RepositoryItemLookUpEdit16
        '
        Me.RepositoryItemLookUpEdit16.AutoHeight = False
        Me.RepositoryItemLookUpEdit16.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit16.Name = "RepositoryItemLookUpEdit16"
        Me.RepositoryItemLookUpEdit16.NullText = ""
        Me.RepositoryItemLookUpEdit16.ReadOnly = True
        Me.RepositoryItemLookUpEdit16.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit17
        '
        Me.RepositoryItemLookUpEdit17.AutoHeight = False
        Me.RepositoryItemLookUpEdit17.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit17.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit17.Name = "RepositoryItemLookUpEdit17"
        Me.RepositoryItemLookUpEdit17.NullText = ""
        Me.RepositoryItemLookUpEdit17.ValueMember = "Productid"
        '
        'RepositoryItemRadioGroup1
        '
        Me.RepositoryItemRadioGroup1.Name = "RepositoryItemRadioGroup1"
        '
        'RepositoryItemRadioGroup2
        '
        Me.RepositoryItemRadioGroup2.Name = "RepositoryItemRadioGroup2"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Tag = "8"
        '
        'frmSelectAPIS
        '
        Me.ClientSize = New System.Drawing.Size(581, 428)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSelectAPIS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select APIS"
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grAPIS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAPISCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewASPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ComponentRibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSelect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RepositoryItemWeekOfMonth1 As DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth
    Friend WithEvents RepositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAlterAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grAPIS As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewASPI As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsAPISCollection As System.Windows.Forms.BindingSource
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents WorkorderNoLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerLabel As System.Windows.Forms.Label
    Friend WithEvents ProductDetLabel As System.Windows.Forms.Label
    Friend WithEvents APISID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents RepositoryItemRadioGroup2 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents ProductDetLabel2 As System.Windows.Forms.Label
End Class
