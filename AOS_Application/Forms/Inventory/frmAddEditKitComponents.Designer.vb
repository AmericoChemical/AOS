<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditKitComponents

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
        Dim AmericoDescLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditKitComponents))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsComponent = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsComponentCollection = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eKitID = New DevExpress.XtraEditors.TextEdit()
        Me.bsKit = New System.Windows.Forms.BindingSource(Me.components)
        Me.KitNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsKitComponent = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.AmericoDescLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        AmericoDescLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComponentCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eKitID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KitNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKitComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmericoDescLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmericoDescLabel
        '
        AmericoDescLabel.AutoSize = True
        AmericoDescLabel.Location = New System.Drawing.Point(43, 60)
        AmericoDescLabel.Name = "AmericoDescLabel"
        AmericoDescLabel.Size = New System.Drawing.Size(49, 13)
        AmericoDescLabel.TabIndex = 2
        AmericoDescLabel.Text = "Kit Name"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(21, 34)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(71, 13)
        ContainerLabel.TabIndex = 6
        ContainerLabel.Text = "Americo Desc"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(58, 34)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(33, 13)
        Label1.TabIndex = 2
        Label1.Text = "Kit ID"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(43, 60)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(49, 13)
        Label2.TabIndex = 5
        Label2.Text = "Quantity"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsComponent
        '
        Me.bsComponent.DataSource = GetType(AOS.BusinessObjects.Component)
        '
        'bsComponentCollection
        '
        Me.bsComponentCollection.DataSource = GetType(AOS.BusinessObjects.ViewAltComponentCollection)
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
        Me.RibbonPageGroup2.Text = "Kit Components"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save  Kit Comp"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 0
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Kit Comp"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 1
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
        Me.ComponentRibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.ComponentRibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ComponentRibbonControl1.MaxItemId = 28
        Me.ComponentRibbonControl1.Name = "ComponentRibbonControl1"
        Me.ComponentRibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ComponentRibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemWeekOfMonth1, Me.RepositoryItemAppointmentLabel1})
        Me.ComponentRibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ComponentRibbonControl1.ShowToolbarCustomizeItem = False
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(455, 95)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.eKitID)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(AmericoDescLabel)
        Me.GroupControl1.Controls.Add(Me.KitNameTextEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 101)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(433, 87)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Kit Information"
        '
        'eKitID
        '
        Me.eKitID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsKit, "Kitid", True))
        Me.eKitID.Location = New System.Drawing.Point(94, 31)
        Me.eKitID.Name = "eKitID"
        Me.eKitID.Properties.ReadOnly = True
        Me.eKitID.Size = New System.Drawing.Size(64, 20)
        Me.eKitID.TabIndex = 3
        Me.eKitID.TabStop = False
        '
        'bsKit
        '
        Me.bsKit.DataSource = GetType(AOS.BusinessObjects.Kit)
        '
        'KitNameTextEdit
        '
        Me.KitNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsKit, "Kitname", True))
        Me.KitNameTextEdit.Location = New System.Drawing.Point(94, 57)
        Me.KitNameTextEdit.Name = "KitNameTextEdit"
        Me.KitNameTextEdit.Properties.ReadOnly = True
        Me.KitNameTextEdit.Size = New System.Drawing.Size(321, 20)
        Me.KitNameTextEdit.TabIndex = 1
        '
        'bsKitComponent
        '
        Me.bsKitComponent.DataSource = GetType(AOS.BusinessObjects.Kitcomponent)
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.eQty)
        Me.GroupControl2.Controls.Add(Me.AmericoDescLookUpEdit)
        Me.GroupControl2.Controls.Add(Label2)
        Me.GroupControl2.Controls.Add(ContainerLabel)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 196)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(433, 83)
        Me.GroupControl2.TabIndex = 10
        Me.GroupControl2.Text = "Kit Component"
        '
        'eQty
        '
        Me.eQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsKitComponent, "Componentqty", True))
        Me.eQty.EditValue = ""
        Me.eQty.Location = New System.Drawing.Point(94, 57)
        Me.eQty.Name = "eQty"
        Me.eQty.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eQty.Size = New System.Drawing.Size(64, 20)
        Me.eQty.TabIndex = 12
        '
        'AmericoDescLookUpEdit
        '
        Me.AmericoDescLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsKitComponent, "Componentid", True))
        Me.AmericoDescLookUpEdit.Location = New System.Drawing.Point(94, 31)
        Me.AmericoDescLookUpEdit.Name = "AmericoDescLookUpEdit"
        Me.AmericoDescLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AmericoDescLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Componentid", "Comp ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Componentdesc", "Americo Desc", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendordesc", "Vendor Desc", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorname", "Vendor Name", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.AmericoDescLookUpEdit.Properties.DataSource = Me.bsComponentCollection
        Me.AmericoDescLookUpEdit.Properties.DisplayMember = "Componentdesc"
        Me.AmericoDescLookUpEdit.Properties.DropDownRows = 10
        Me.AmericoDescLookUpEdit.Properties.NullText = ""
        Me.AmericoDescLookUpEdit.Properties.PopupFormMinSize = New System.Drawing.Size(100, 0)
        Me.AmericoDescLookUpEdit.Properties.PopupWidth = 500
        Me.AmericoDescLookUpEdit.Properties.ShowLines = False
        Me.AmericoDescLookUpEdit.Properties.ValueMember = "Componentid"
        Me.AmericoDescLookUpEdit.Size = New System.Drawing.Size(322, 20)
        Me.AmericoDescLookUpEdit.TabIndex = 12
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'frmAddEditKitComponents
        '
        Me.ClientSize = New System.Drawing.Size(455, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditKitComponents"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kit Component Information"
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComponentCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eKitID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KitNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKitComponent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmericoDescLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsComponent As System.Windows.Forms.BindingSource
    Friend WithEvents bsComponentCollection As System.Windows.Forms.BindingSource
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
    Friend WithEvents KitNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eKitID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AmericoDescLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsKit As System.Windows.Forms.BindingSource
    Friend WithEvents bsKitComponent As System.Windows.Forms.BindingSource
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
End Class
