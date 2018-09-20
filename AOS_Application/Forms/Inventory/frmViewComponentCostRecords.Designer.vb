<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewComponentCostRecords

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewComponentCostRecords))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsComponentCost = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSelect = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bLblVolumeUnits = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblVolumeUOM = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblVolumeStandardCost = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtVolumeUnits = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtVolumeUOM = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtlVolumeStandardCost = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblWeightUnits = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblWeightUOM = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblWeightStandardCost = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtWeightUnits = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtWeightUOM = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtWeightStandardCost = New DevExpress.XtraBars.BarStaticItem()
        Me.rbtnMakeCostRecordDefault = New DevExpress.XtraBars.BarButtonItem()
        Me.lblStdCostType = New DevExpress.XtraBars.BarStaticItem()
        Me.rbtnUpdateStdCost = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grComponentCosts = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colVcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.colVendorItemId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorItemDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatecostchanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsactive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsdefaultcostrecord = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblComponentInfo = New System.Windows.Forms.Label()
        Me.bsComponent = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.bsComponentCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grComponentCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsComponentCost
        '
        Me.bsComponentCost.DataSource = GetType(AOS.BusinessObjects.ComponentcostCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSelect, Me.btnClose, Me.bLblVolumeUnits, Me.bLblVolumeUOM, Me.bLblVolumeStandardCost, Me.bTxtVolumeUnits, Me.bTxtVolumeUOM, Me.bTxtlVolumeStandardCost, Me.bLblWeightUnits, Me.bLblWeightUOM, Me.bLblWeightStandardCost, Me.bTxtWeightUnits, Me.bTxtWeightUOM, Me.bTxtWeightStandardCost, Me.rbtnMakeCostRecordDefault, Me.lblStdCostType, Me.rbtnUpdateStdCost})
        Me.RibbonControl1.LargeImages = Me.LargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 22
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(938, 116)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 0
        Me.btnNewCostRecord.ImageOptions.LargeImageIndex = 2
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Id = 1
        Me.btnEditCostRecord.ImageOptions.LargeImageIndex = 3
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Id = 2
        Me.btnDeleteCostRecord.ImageOptions.LargeImageIndex = 4
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
        '
        'btnSelect
        '
        Me.btnSelect.Caption = "Select Cost"
        Me.btnSelect.Id = 4
        Me.btnSelect.ImageOptions.LargeImageIndex = 9
        Me.btnSelect.Name = "btnSelect"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close Form"
        Me.btnClose.Id = 5
        Me.btnClose.ImageOptions.LargeImageIndex = 36
        Me.btnClose.Name = "btnClose"
        '
        'bLblVolumeUnits
        '
        Me.bLblVolumeUnits.Caption = "Units"
        Me.bLblVolumeUnits.Id = 6
        Me.bLblVolumeUnits.Name = "bLblVolumeUnits"
        '
        'bLblVolumeUOM
        '
        Me.bLblVolumeUOM.Caption = "UOM"
        Me.bLblVolumeUOM.Id = 7
        Me.bLblVolumeUOM.Name = "bLblVolumeUOM"
        '
        'bLblVolumeStandardCost
        '
        Me.bLblVolumeStandardCost.Caption = "Std Cost"
        Me.bLblVolumeStandardCost.Id = 8
        Me.bLblVolumeStandardCost.Name = "bLblVolumeStandardCost"
        '
        'bTxtVolumeUnits
        '
        Me.bTxtVolumeUnits.Id = 9
        Me.bTxtVolumeUnits.Name = "bTxtVolumeUnits"
        '
        'bTxtVolumeUOM
        '
        Me.bTxtVolumeUOM.Id = 10
        Me.bTxtVolumeUOM.Name = "bTxtVolumeUOM"
        '
        'bTxtlVolumeStandardCost
        '
        Me.bTxtlVolumeStandardCost.Id = 11
        Me.bTxtlVolumeStandardCost.Name = "bTxtlVolumeStandardCost"
        '
        'bLblWeightUnits
        '
        Me.bLblWeightUnits.Caption = "Units"
        Me.bLblWeightUnits.Id = 13
        Me.bLblWeightUnits.Name = "bLblWeightUnits"
        '
        'bLblWeightUOM
        '
        Me.bLblWeightUOM.Caption = "UOM"
        Me.bLblWeightUOM.Id = 14
        Me.bLblWeightUOM.Name = "bLblWeightUOM"
        '
        'bLblWeightStandardCost
        '
        Me.bLblWeightStandardCost.Caption = "Std Cost"
        Me.bLblWeightStandardCost.Id = 15
        Me.bLblWeightStandardCost.Name = "bLblWeightStandardCost"
        '
        'bTxtWeightUnits
        '
        Me.bTxtWeightUnits.Id = 16
        Me.bTxtWeightUnits.Name = "bTxtWeightUnits"
        '
        'bTxtWeightUOM
        '
        Me.bTxtWeightUOM.Id = 17
        Me.bTxtWeightUOM.Name = "bTxtWeightUOM"
        '
        'bTxtWeightStandardCost
        '
        Me.bTxtWeightStandardCost.Id = 18
        Me.bTxtWeightStandardCost.Name = "bTxtWeightStandardCost"
        '
        'rbtnMakeCostRecordDefault
        '
        Me.rbtnMakeCostRecordDefault.Caption = "Mark Cost Record as Default"
        Me.rbtnMakeCostRecordDefault.Id = 19
        Me.rbtnMakeCostRecordDefault.ImageOptions.LargeImageIndex = 10
        Me.rbtnMakeCostRecordDefault.Name = "rbtnMakeCostRecordDefault"
        '
        'lblStdCostType
        '
        Me.lblStdCostType.Id = 20
        Me.lblStdCostType.Name = "lblStdCostType"
        '
        'rbtnUpdateStdCost
        '
        Me.rbtnUpdateStdCost.Caption = "Update Std Cost with Selected Record"
        Me.rbtnUpdateStdCost.Enabled = False
        Me.rbtnUpdateStdCost.Id = 21
        Me.rbtnUpdateStdCost.ImageOptions.LargeImageIndex = 1
        Me.rbtnUpdateStdCost.Name = "rbtnUpdateStdCost"
        '
        'LargeImages
        '
        Me.LargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeImages.ImageStream = CType(resources.GetObject("LargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSelect)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "User Action"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNewCostRecord)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditCostRecord)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDeleteCostRecord)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnMakeCostRecordDefault, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnUpdateStdCost, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Component Cost Records"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.grComponentCosts)
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 116)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl2.Size = New System.Drawing.Size(938, 194)
        Me.PanelControl2.TabIndex = 41
        '
        'grComponentCosts
        '
        Me.grComponentCosts.DataSource = Me.bsComponentCost
        Me.grComponentCosts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grComponentCosts.Location = New System.Drawing.Point(6, 29)
        Me.grComponentCosts.LookAndFeel.SkinName = "Blue"
        Me.grComponentCosts.MainView = Me.GridView1
        Me.grComponentCosts.Name = "grComponentCosts"
        Me.grComponentCosts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.grComponentCosts.Size = New System.Drawing.Size(926, 159)
        Me.grComponentCosts.TabIndex = 41
        Me.grComponentCosts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colIsdefaultcostrecord, Me.colVcost, Me.GridColumn1, Me.colVendorItemId, Me.colVendorItemDesc, Me.GridColumn2, Me.colDatecostchanged, Me.colIsactive})
        Me.GridView1.GridControl = Me.grComponentCosts
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colVcost
        '
        Me.colVcost.AppearanceCell.Options.UseTextOptions = True
        Me.colVcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVcost.Caption = "Cost "
        Me.colVcost.DisplayFormat.FormatString = "c3"
        Me.colVcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVcost.FieldName = "UnitCost"
        Me.colVcost.Name = "colVcost"
        Me.colVcost.OptionsColumn.AllowEdit = False
        Me.colVcost.Visible = True
        Me.colVcost.VisibleIndex = 1
        Me.colVcost.Width = 80
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Vendor"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn1.FieldName = "VendorId"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 83
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsVendors
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Vendorname"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ReadOnly = True
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit1.ValueMember = "Vendorid"
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'colVendorItemId
        '
        Me.colVendorItemId.Caption = "Vendor Id"
        Me.colVendorItemId.FieldName = "VendorItemId"
        Me.colVendorItemId.Name = "colVendorItemId"
        Me.colVendorItemId.Visible = True
        Me.colVendorItemId.VisibleIndex = 2
        Me.colVendorItemId.Width = 150
        '
        'colVendorItemDesc
        '
        Me.colVendorItemDesc.Caption = "Vendor Desc"
        Me.colVendorItemDesc.FieldName = "VendorItemDesc"
        Me.colVendorItemDesc.Name = "colVendorItemDesc"
        Me.colVendorItemDesc.Visible = True
        Me.colVendorItemDesc.VisibleIndex = 3
        Me.colVendorItemDesc.Width = 200
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Notes"
        Me.GridColumn2.FieldName = "Notes"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 5
        Me.GridColumn2.Width = 200
        '
        'colDatecostchanged
        '
        Me.colDatecostchanged.AppearanceCell.Options.UseTextOptions = True
        Me.colDatecostchanged.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDatecostchanged.Caption = "Eff Date"
        Me.colDatecostchanged.DisplayFormat.FormatString = "d"
        Me.colDatecostchanged.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDatecostchanged.FieldName = "EffectiveDate"
        Me.colDatecostchanged.Name = "colDatecostchanged"
        Me.colDatecostchanged.OptionsColumn.AllowEdit = False
        Me.colDatecostchanged.Visible = True
        Me.colDatecostchanged.VisibleIndex = 6
        Me.colDatecostchanged.Width = 79
        '
        'colIsactive
        '
        Me.colIsactive.Caption = "Active"
        Me.colIsactive.FieldName = "IsActive"
        Me.colIsactive.Name = "colIsactive"
        Me.colIsactive.Visible = True
        Me.colIsactive.VisibleIndex = 7
        Me.colIsactive.Width = 98
        '
        'colIsdefaultcostrecord
        '
        Me.colIsdefaultcostrecord.Caption = "Default"
        Me.colIsdefaultcostrecord.FieldName = "IsDefault"
        Me.colIsdefaultcostrecord.Name = "colIsdefaultcostrecord"
        Me.colIsdefaultcostrecord.Visible = True
        Me.colIsdefaultcostrecord.VisibleIndex = 0
        Me.colIsdefaultcostrecord.Width = 34
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.lblComponentInfo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(6, 6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(926, 23)
        Me.PanelControl1.TabIndex = 42
        '
        'lblComponentInfo
        '
        Me.lblComponentInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblComponentInfo.Location = New System.Drawing.Point(0, 0)
        Me.lblComponentInfo.Name = "lblComponentInfo"
        Me.lblComponentInfo.Size = New System.Drawing.Size(926, 23)
        Me.lblComponentInfo.TabIndex = 3
        Me.lblComponentInfo.Text = "ID  - Component Desc - Container"
        Me.lblComponentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bsComponent
        '
        Me.bsComponent.DataSource = GetType(AOS.BusinessObjects.Component)
        '
        'frmViewComponentCostRecords
        '
        Me.ClientSize = New System.Drawing.Size(938, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmViewComponentCostRecords"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Component Cost Records"
        CType(Me.bsComponentCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grComponentCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsComponentCost As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grComponentCosts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colVcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatecostchanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsComponent As System.Windows.Forms.BindingSource
    Friend WithEvents btnSelect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblComponentInfo As System.Windows.Forms.Label
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bLblVolumeUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblVolumeUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblVolumeStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtVolumeUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtVolumeUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtlVolumeStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblWeightUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblWeightUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblWeightStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWeightUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWeightUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWeightStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents colIsactive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnMakeCostRecordDefault As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblStdCostType As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents LargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnUpdateStdCost As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colIsdefaultcostrecord As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorItemId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorItemDesc As DevExpress.XtraGrid.Columns.GridColumn
End Class
