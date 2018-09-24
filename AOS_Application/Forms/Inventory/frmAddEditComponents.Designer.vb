<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditComponents

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
        Dim ComponentidLabel As System.Windows.Forms.Label
        Dim AmericoDescLabel As System.Windows.Forms.Label
        Dim VendorNameLabel As System.Windows.Forms.Label
        Dim VendorDescLabel As System.Windows.Forms.Label
        Dim UnitCostLabel As System.Windows.Forms.Label
        Dim VendorItemIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditComponents))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eComponentID = New DevExpress.XtraEditors.TextEdit()
        Me.bsComponent = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorItemLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsVendor = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnComponentCostRecords = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemWeekOfMonth1 = New DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth()
        Me.RepositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.VendorItemIDTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AmericoDescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorDescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grComponents = New DevExpress.XtraGrid.GridControl()
        Me.bsAltComponents = New System.Windows.Forms.BindingSource(Me.components)
        Me.viewComponent = New AOS.CustomClasses.CustomDevExGridView()
        Me.RECID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComponentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AmericoDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.VendorDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        ComponentidLabel = New System.Windows.Forms.Label()
        AmericoDescLabel = New System.Windows.Forms.Label()
        VendorNameLabel = New System.Windows.Forms.Label()
        VendorDescLabel = New System.Windows.Forms.Label()
        UnitCostLabel = New System.Windows.Forms.Label()
        VendorItemIDLabel = New System.Windows.Forms.Label()
        CType(Me.eComponentID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorItemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.VendorItemIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmericoDescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorDescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAltComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComponentidLabel
        '
        ComponentidLabel.AutoSize = True
        ComponentidLabel.Location = New System.Drawing.Point(51, 35)
        ComponentidLabel.Name = "ComponentidLabel"
        ComponentidLabel.Size = New System.Drawing.Size(48, 13)
        ComponentidLabel.TabIndex = 0
        ComponentidLabel.Text = "Comp ID"
        '
        'AmericoDescLabel
        '
        AmericoDescLabel.AutoSize = True
        AmericoDescLabel.Location = New System.Drawing.Point(28, 63)
        AmericoDescLabel.Name = "AmericoDescLabel"
        AmericoDescLabel.Size = New System.Drawing.Size(71, 13)
        AmericoDescLabel.TabIndex = 2
        AmericoDescLabel.Text = "Americo Desc"
        '
        'VendorNameLabel
        '
        VendorNameLabel.AutoSize = True
        VendorNameLabel.Location = New System.Drawing.Point(28, 91)
        VendorNameLabel.Name = "VendorNameLabel"
        VendorNameLabel.Size = New System.Drawing.Size(71, 13)
        VendorNameLabel.TabIndex = 4
        VendorNameLabel.Text = "Vendor Name"
        '
        'VendorDescLabel
        '
        VendorDescLabel.AutoSize = True
        VendorDescLabel.Location = New System.Drawing.Point(32, 119)
        VendorDescLabel.Name = "VendorDescLabel"
        VendorDescLabel.Size = New System.Drawing.Size(67, 13)
        VendorDescLabel.TabIndex = 6
        VendorDescLabel.Text = "Vendor Desc"
        '
        'UnitCostLabel
        '
        UnitCostLabel.AutoSize = True
        UnitCostLabel.Location = New System.Drawing.Point(48, 173)
        UnitCostLabel.Name = "UnitCostLabel"
        UnitCostLabel.Size = New System.Drawing.Size(51, 13)
        UnitCostLabel.TabIndex = 10
        UnitCostLabel.Text = "Unit Cost"
        '
        'VendorItemIDLabel
        '
        VendorItemIDLabel.AutoSize = True
        VendorItemIDLabel.Location = New System.Drawing.Point(16, 145)
        VendorItemIDLabel.Name = "VendorItemIDLabel"
        VendorItemIDLabel.Size = New System.Drawing.Size(83, 13)
        VendorItemIDLabel.TabIndex = 8
        VendorItemIDLabel.Text = "Vendor Item ID "
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eComponentID
        '
        Me.eComponentID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponent, "Componentid", True))
        Me.eComponentID.Location = New System.Drawing.Point(101, 32)
        Me.eComponentID.Name = "eComponentID"
        Me.eComponentID.Properties.ReadOnly = True
        Me.eComponentID.Size = New System.Drawing.Size(64, 20)
        Me.eComponentID.TabIndex = 1
        Me.eComponentID.TabStop = False
        '
        'bsComponent
        '
        Me.bsComponent.DataSource = GetType(AOS.BusinessObjects.Component)
        '
        'VendorItemLookUpEdit
        '
        Me.VendorItemLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponent, "Vendorid", True))
        Me.VendorItemLookUpEdit.Location = New System.Drawing.Point(101, 88)
        Me.VendorItemLookUpEdit.Name = "VendorItemLookUpEdit"
        Me.VendorItemLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VendorItemLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorid", 5, "VendorID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorname", "Vendor Name", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.VendorItemLookUpEdit.Properties.DataSource = Me.bsVendor
        Me.VendorItemLookUpEdit.Properties.DisplayMember = "Vendorname"
        Me.VendorItemLookUpEdit.Properties.DropDownRows = 10
        Me.VendorItemLookUpEdit.Properties.NullText = ""
        Me.VendorItemLookUpEdit.Properties.PopupWidth = 200
        Me.VendorItemLookUpEdit.Properties.ShowFooter = False
        Me.VendorItemLookUpEdit.Properties.ValueMember = "Vendorid"
        Me.VendorItemLookUpEdit.Size = New System.Drawing.Size(453, 20)
        Me.VendorItemLookUpEdit.TabIndex = 5
        '
        'bsVendor
        '
        Me.bsVendor.DataSource = GetType(AOS.BusinessObjects.Vendor)
        '
        'ComponentRibbonControl1
        '
        Me.ComponentRibbonControl1.ApplicationButtonText = Nothing
        Me.ComponentRibbonControl1.ExpandCollapseItem.Id = 0
        Me.ComponentRibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ComponentRibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnAlterAdd, Me.btnAlterEdit, Me.btnAlterDelete, Me.btnComponentCostRecords})
        Me.ComponentRibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.ComponentRibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ComponentRibbonControl1.MaxItemId = 29
        Me.ComponentRibbonControl1.Name = "ComponentRibbonControl1"
        Me.ComponentRibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ComponentRibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemWeekOfMonth1, Me.RepositoryItemAppointmentLabel1})
        Me.ComponentRibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ComponentRibbonControl1.ShowToolbarCustomizeItem = False
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(581, 116)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save  Comp"
        Me.btnSave.Id = 4
        Me.btnSave.ImageOptions.LargeImageIndex = 3
        Me.btnSave.LargeWidth = 50
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Comp"
        Me.btnCancel.Id = 5
        Me.btnCancel.ImageOptions.LargeImageIndex = 4
        Me.btnCancel.LargeWidth = 50
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAlterAdd
        '
        Me.btnAlterAdd.Caption = "Add New Alternate"
        Me.btnAlterAdd.Id = 24
        Me.btnAlterAdd.ImageOptions.LargeImageIndex = 0
        Me.btnAlterAdd.Name = "btnAlterAdd"
        '
        'btnAlterEdit
        '
        Me.btnAlterEdit.Caption = " Edit   Alternate"
        Me.btnAlterEdit.Id = 25
        Me.btnAlterEdit.ImageOptions.LargeImageIndex = 1
        Me.btnAlterEdit.Name = "btnAlterEdit"
        Me.btnAlterEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAlterDelete
        '
        Me.btnAlterDelete.Caption = "Delete Alternate"
        Me.btnAlterDelete.Id = 26
        Me.btnAlterDelete.ImageOptions.Image = CType(resources.GetObject("btnAlterDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAlterDelete.ImageOptions.LargeImageIndex = 2
        Me.btnAlterDelete.Name = "btnAlterDelete"
        Me.btnAlterDelete.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnComponentCostRecords
        '
        Me.btnComponentCostRecords.Caption = "Component Cost Records"
        Me.btnComponentCostRecords.Id = 28
        Me.btnComponentCostRecords.ImageOptions.LargeImageIndex = 11
        Me.btnComponentCostRecords.Name = "btnComponentCostRecords"
        Me.btnComponentCostRecords.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
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
        Me.RibbonPageGroup2.Text = "Component"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnAlterAdd)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnAlterEdit)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnAlterDelete)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Component Alternate"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnComponentCostRecords)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Costing"
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
        Me.GroupControl1.Controls.Add(Me.VendorItemIDTextEdit)
        Me.GroupControl1.Controls.Add(VendorItemIDLabel)
        Me.GroupControl1.Controls.Add(Me.UnitCostTextEdit)
        Me.GroupControl1.Controls.Add(UnitCostLabel)
        Me.GroupControl1.Controls.Add(Me.VendorItemLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.eComponentID)
        Me.GroupControl1.Controls.Add(ComponentidLabel)
        Me.GroupControl1.Controls.Add(AmericoDescLabel)
        Me.GroupControl1.Controls.Add(VendorNameLabel)
        Me.GroupControl1.Controls.Add(VendorDescLabel)
        Me.GroupControl1.Controls.Add(Me.AmericoDescTextEdit)
        Me.GroupControl1.Controls.Add(Me.VendorDescTextEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(4, 101)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(573, 244)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Component Information"
        '
        'VendorItemIDTextEdit
        '
        Me.VendorItemIDTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponent, "Vendoritemid", True))
        Me.VendorItemIDTextEdit.Location = New System.Drawing.Point(101, 142)
        Me.VendorItemIDTextEdit.Name = "VendorItemIDTextEdit"
        Me.VendorItemIDTextEdit.Properties.MaxLength = 255
        Me.VendorItemIDTextEdit.Size = New System.Drawing.Size(453, 20)
        Me.VendorItemIDTextEdit.TabIndex = 9
        '
        'UnitCostTextEdit
        '
        Me.UnitCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponent, "Unitcost", True))
        Me.UnitCostTextEdit.EditValue = ""
        Me.UnitCostTextEdit.Location = New System.Drawing.Point(101, 170)
        Me.UnitCostTextEdit.Name = "UnitCostTextEdit"
        Me.UnitCostTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.UnitCostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.UnitCostTextEdit.Size = New System.Drawing.Size(64, 20)
        Me.UnitCostTextEdit.TabIndex = 11
        '
        'AmericoDescTextEdit
        '
        Me.AmericoDescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponent, "Componentdesc", True))
        Me.AmericoDescTextEdit.Location = New System.Drawing.Point(101, 60)
        Me.AmericoDescTextEdit.Name = "AmericoDescTextEdit"
        Me.AmericoDescTextEdit.Properties.MaxLength = 255
        Me.AmericoDescTextEdit.Size = New System.Drawing.Size(453, 20)
        Me.AmericoDescTextEdit.TabIndex = 3
        '
        'VendorDescTextEdit
        '
        Me.VendorDescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsComponent, "Vendordesc", True))
        Me.VendorDescTextEdit.Location = New System.Drawing.Point(101, 116)
        Me.VendorDescTextEdit.Name = "VendorDescTextEdit"
        Me.VendorDescTextEdit.Properties.MaxLength = 255
        Me.VendorDescTextEdit.Size = New System.Drawing.Size(453, 20)
        Me.VendorDescTextEdit.TabIndex = 7
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grComponents)
        Me.GroupControl2.Location = New System.Drawing.Point(2, 351)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(575, 165)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Component Alternate(s)"
        '
        'grComponents
        '
        Me.grComponents.DataSource = Me.bsAltComponents
        Me.grComponents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grComponents.Location = New System.Drawing.Point(2, 20)
        Me.grComponents.MainView = Me.viewComponent
        Me.grComponents.Name = "grComponents"
        Me.grComponents.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit16, Me.RepositoryItemLookUpEdit17})
        Me.grComponents.Size = New System.Drawing.Size(571, 143)
        Me.grComponents.TabIndex = 0
        Me.grComponents.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewComponent})
        '
        'viewComponent
        '
        Me.viewComponent.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.RECID, Me.ComponentID, Me.AmericoDesc, Me.VendorDesc})
        Me.viewComponent.GridControl = Me.grComponents
        Me.viewComponent.Name = "viewComponent"
        Me.viewComponent.OptionsBehavior.Editable = False
        Me.viewComponent.OptionsCustomization.AllowFilter = False
        Me.viewComponent.OptionsSelection.MultiSelect = True
        Me.viewComponent.OptionsView.ShowGroupPanel = False
        '
        'RECID
        '
        Me.RECID.Caption = "RECID"
        Me.RECID.FieldName = "Recid"
        Me.RECID.Name = "RECID"
        '
        'ComponentID
        '
        Me.ComponentID.Caption = "Comp ID"
        Me.ComponentID.FieldName = "Altcomponentid"
        Me.ComponentID.Name = "ComponentID"
        Me.ComponentID.OptionsColumn.AllowEdit = False
        Me.ComponentID.Visible = True
        Me.ComponentID.VisibleIndex = 0
        Me.ComponentID.Width = 72
        '
        'AmericoDesc
        '
        Me.AmericoDesc.Caption = "Americo Desc"
        Me.AmericoDesc.FieldName = "Componentdesc"
        Me.AmericoDesc.Name = "AmericoDesc"
        Me.AmericoDesc.OptionsColumn.AllowEdit = False
        Me.AmericoDesc.Visible = True
        Me.AmericoDesc.VisibleIndex = 1
        Me.AmericoDesc.Width = 306
        '
        'VendorDesc
        '
        Me.VendorDesc.Caption = "Vendor Desc "
        Me.VendorDesc.FieldName = "Vendordesc"
        Me.VendorDesc.Name = "VendorDesc"
        Me.VendorDesc.OptionsColumn.AllowEdit = False
        Me.VendorDesc.Visible = True
        Me.VendorDesc.VisibleIndex = 2
        Me.VendorDesc.Width = 318
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
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Tag = "8"
        '
        'frmAddEditComponents
        '
        Me.ClientSize = New System.Drawing.Size(581, 519)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditComponents"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Component Information"
        CType(Me.eComponentID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorItemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.VendorItemIDTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmericoDescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorDescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grComponents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAltComponents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewComponent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents eComponentID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorItemLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ComponentRibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RepositoryItemWeekOfMonth1 As DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth
    Friend WithEvents RepositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAlterAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsVendor As System.Windows.Forms.BindingSource
    Friend WithEvents grComponents As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewComponent As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsComponent As System.Windows.Forms.BindingSource
    Friend WithEvents bsAltComponents As System.Windows.Forms.BindingSource
    Friend WithEvents ComponentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmericoDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents VendorDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RECID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AmericoDescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorDescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorItemIDTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnComponentCostRecords As DevExpress.XtraBars.BarButtonItem
End Class
