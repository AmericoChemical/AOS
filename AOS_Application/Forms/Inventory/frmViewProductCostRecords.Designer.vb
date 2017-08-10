<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewProductCostRecords

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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgStdVol = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgStdWgt = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grProductCosts = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New CustomDevExGridView()
        Me.colVUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatecostchanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblproductInfo = New System.Windows.Forms.Label()
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grProductCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.ProductcostCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSelect, Me.btnClose, Me.bLblVolumeUnits, Me.bLblVolumeUOM, Me.bLblVolumeStandardCost, Me.bTxtVolumeUnits, Me.bTxtVolumeUOM, Me.bTxtlVolumeStandardCost, Me.bLblWeightUnits, Me.bLblWeightUOM, Me.bLblWeightStandardCost, Me.bTxtWeightUnits, Me.bTxtWeightUOM, Me.bTxtWeightStandardCost})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 19
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(764, 96)
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
        'btnSelect
        '
        Me.btnSelect.Caption = "Select Cost"
        Me.btnSelect.Id = 4
        Me.btnSelect.LargeGlyph = Global.AOS.My.Resources.Resources.Change1
        Me.btnSelect.Name = "btnSelect"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close Form"
        Me.btnClose.Id = 5
        Me.btnClose.LargeGlyph = Global.AOS.My.Resources.Resources.Close
        Me.btnClose.Name = "btnClose"
        '
        'bLblVolumeUnits
        '
        Me.bLblVolumeUnits.Caption = "Units"
        Me.bLblVolumeUnits.Id = 6
        Me.bLblVolumeUnits.Name = "bLblVolumeUnits"
        Me.bLblVolumeUnits.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblVolumeUOM
        '
        Me.bLblVolumeUOM.Caption = "UOM"
        Me.bLblVolumeUOM.Id = 7
        Me.bLblVolumeUOM.Name = "bLblVolumeUOM"
        Me.bLblVolumeUOM.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblVolumeStandardCost
        '
        Me.bLblVolumeStandardCost.Caption = "Std Cost"
        Me.bLblVolumeStandardCost.Id = 8
        Me.bLblVolumeStandardCost.Name = "bLblVolumeStandardCost"
        Me.bLblVolumeStandardCost.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtVolumeUnits
        '
        Me.bTxtVolumeUnits.Id = 9
        Me.bTxtVolumeUnits.Name = "bTxtVolumeUnits"
        Me.bTxtVolumeUnits.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtVolumeUOM
        '
        Me.bTxtVolumeUOM.Id = 10
        Me.bTxtVolumeUOM.Name = "bTxtVolumeUOM"
        Me.bTxtVolumeUOM.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtlVolumeStandardCost
        '
        Me.bTxtlVolumeStandardCost.Id = 11
        Me.bTxtlVolumeStandardCost.Name = "bTxtlVolumeStandardCost"
        Me.bTxtlVolumeStandardCost.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblWeightUnits
        '
        Me.bLblWeightUnits.Caption = "Units"
        Me.bLblWeightUnits.Id = 13
        Me.bLblWeightUnits.Name = "bLblWeightUnits"
        Me.bLblWeightUnits.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblWeightUOM
        '
        Me.bLblWeightUOM.Caption = "UOM"
        Me.bLblWeightUOM.Id = 14
        Me.bLblWeightUOM.Name = "bLblWeightUOM"
        Me.bLblWeightUOM.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblWeightStandardCost
        '
        Me.bLblWeightStandardCost.Caption = "Std Cost"
        Me.bLblWeightStandardCost.Id = 15
        Me.bLblWeightStandardCost.Name = "bLblWeightStandardCost"
        Me.bLblWeightStandardCost.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtWeightUnits
        '
        Me.bTxtWeightUnits.Id = 16
        Me.bTxtWeightUnits.Name = "bTxtWeightUnits"
        Me.bTxtWeightUnits.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtWeightUOM
        '
        Me.bTxtWeightUOM.Id = 17
        Me.bTxtWeightUOM.Name = "bTxtWeightUOM"
        Me.bTxtWeightUOM.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtWeightStandardCost
        '
        Me.bTxtWeightStandardCost.Id = 18
        Me.bTxtWeightStandardCost.Name = "bTxtWeightStandardCost"
        Me.bTxtWeightStandardCost.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1, Me.rpgStdVol, Me.rpgStdWgt})
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
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Product Cost Records"
        '
        'rpgStdVol
        '
        Me.rpgStdVol.AllowTextClipping = False
        Me.rpgStdVol.ItemLinks.Add(Me.bLblVolumeUnits)
        Me.rpgStdVol.ItemLinks.Add(Me.bLblVolumeUOM)
        Me.rpgStdVol.ItemLinks.Add(Me.bLblVolumeStandardCost)
        Me.rpgStdVol.ItemLinks.Add(Me.bTxtVolumeUnits)
        Me.rpgStdVol.ItemLinks.Add(Me.bTxtVolumeUOM)
        Me.rpgStdVol.ItemLinks.Add(Me.bTxtlVolumeStandardCost)
        Me.rpgStdVol.Name = "rpgStdVol"
        Me.rpgStdVol.ShowCaptionButton = False
        Me.rpgStdVol.Text = "Standard Voulme"
        '
        'rpgStdWgt
        '
        Me.rpgStdWgt.AllowTextClipping = False
        Me.rpgStdWgt.ItemLinks.Add(Me.bLblWeightUnits)
        Me.rpgStdWgt.ItemLinks.Add(Me.bLblWeightUOM)
        Me.rpgStdWgt.ItemLinks.Add(Me.bLblWeightStandardCost)
        Me.rpgStdWgt.ItemLinks.Add(Me.bTxtWeightUnits)
        Me.rpgStdWgt.ItemLinks.Add(Me.bTxtWeightUOM)
        Me.rpgStdWgt.ItemLinks.Add(Me.bTxtWeightStandardCost)
        Me.rpgStdWgt.Name = "rpgStdWgt"
        Me.rpgStdWgt.ShowCaptionButton = False
        Me.rpgStdWgt.Text = "Standard Weight"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.grProductCosts)
        Me.PanelControl2.Controls.Add(Me.PanelControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 96)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl2.Size = New System.Drawing.Size(764, 195)
        Me.PanelControl2.TabIndex = 41
        '
        'grProductCosts
        '
        Me.grProductCosts.DataSource = Me.bs
        Me.grProductCosts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grProductCosts.Location = New System.Drawing.Point(6, 29)
        Me.grProductCosts.LookAndFeel.SkinName = "Blue"
        Me.grProductCosts.MainView = Me.GridView1
        Me.grProductCosts.Name = "grProductCosts"
        Me.grProductCosts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.grProductCosts.Size = New System.Drawing.Size(752, 160)
        Me.grProductCosts.TabIndex = 41
        Me.grProductCosts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVUnits, Me.colVUom, Me.colVcost, Me.colWUnits, Me.colWUom, Me.colWcost, Me.GridColumn1, Me.GridColumn2, Me.colDatecostchanged})
        Me.GridView1.GridControl = Me.grProductCosts
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colVUnits, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colVUnits
        '
        Me.colVUnits.AppearanceCell.Options.UseTextOptions = True
        Me.colVUnits.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVUnits.Caption = "Vol. Units"
        Me.colVUnits.DisplayFormat.FormatString = "n4"
        Me.colVUnits.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVUnits.FieldName = "Volumeunits"
        Me.colVUnits.Name = "colVUnits"
        Me.colVUnits.OptionsColumn.AllowEdit = False
        Me.colVUnits.Visible = True
        Me.colVUnits.VisibleIndex = 0
        Me.colVUnits.Width = 70
        '
        'colVUom
        '
        Me.colVUom.Caption = "Vol. UOM"
        Me.colVUom.FieldName = "Volumeuom"
        Me.colVUom.Name = "colVUom"
        Me.colVUom.OptionsColumn.AllowEdit = False
        Me.colVUom.Visible = True
        Me.colVUom.VisibleIndex = 1
        Me.colVUom.Width = 53
        '
        'colVcost
        '
        Me.colVcost.AppearanceCell.Options.UseTextOptions = True
        Me.colVcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVcost.Caption = "Vol. Cost "
        Me.colVcost.DisplayFormat.FormatString = "c3"
        Me.colVcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVcost.FieldName = "Volumestandardcost"
        Me.colVcost.Name = "colVcost"
        Me.colVcost.OptionsColumn.AllowEdit = False
        Me.colVcost.Visible = True
        Me.colVcost.VisibleIndex = 2
        Me.colVcost.Width = 63
        '
        'colWUnits
        '
        Me.colWUnits.AppearanceCell.Options.UseTextOptions = True
        Me.colWUnits.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colWUnits.Caption = "Wgt. Units"
        Me.colWUnits.DisplayFormat.FormatString = "n4"
        Me.colWUnits.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colWUnits.FieldName = "Weightunits"
        Me.colWUnits.Name = "colWUnits"
        Me.colWUnits.OptionsColumn.AllowEdit = False
        Me.colWUnits.Visible = True
        Me.colWUnits.VisibleIndex = 3
        Me.colWUnits.Width = 66
        '
        'colWUom
        '
        Me.colWUom.Caption = "Wgt. UOM"
        Me.colWUom.FieldName = "Weightuom"
        Me.colWUom.Name = "colWUom"
        Me.colWUom.OptionsColumn.AllowEdit = False
        Me.colWUom.Visible = True
        Me.colWUom.VisibleIndex = 4
        Me.colWUom.Width = 62
        '
        'colWcost
        '
        Me.colWcost.AppearanceCell.Options.UseTextOptions = True
        Me.colWcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colWcost.Caption = "Wgt. Cost"
        Me.colWcost.DisplayFormat.FormatString = "c3"
        Me.colWcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colWcost.FieldName = "Weightstandardcost"
        Me.colWcost.Name = "colWcost"
        Me.colWcost.OptionsColumn.AllowEdit = False
        Me.colWcost.Visible = True
        Me.colWcost.VisibleIndex = 5
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Vendor"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn1.FieldName = "Vendorid"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 138
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
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Notes"
        Me.GridColumn2.FieldName = "Notes"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 7
        Me.GridColumn2.Width = 104
        '
        'colDatecostchanged
        '
        Me.colDatecostchanged.AppearanceCell.Options.UseTextOptions = True
        Me.colDatecostchanged.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDatecostchanged.Caption = "Eff Date"
        Me.colDatecostchanged.DisplayFormat.FormatString = "d"
        Me.colDatecostchanged.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDatecostchanged.FieldName = "Effectivedate"
        Me.colDatecostchanged.Name = "colDatecostchanged"
        Me.colDatecostchanged.OptionsColumn.AllowEdit = False
        Me.colDatecostchanged.Visible = True
        Me.colDatecostchanged.VisibleIndex = 8
        Me.colDatecostchanged.Width = 81
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.lblproductInfo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(6, 6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(752, 23)
        Me.PanelControl1.TabIndex = 42
        '
        'lblproductInfo
        '
        Me.lblproductInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblproductInfo.Location = New System.Drawing.Point(0, 0)
        Me.lblproductInfo.Name = "lblproductInfo"
        Me.lblproductInfo.Size = New System.Drawing.Size(752, 23)
        Me.lblproductInfo.TabIndex = 3
        Me.lblproductInfo.Text = "ID  - Product Desc - Container"
        Me.lblproductInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'frmViewProductCostRecords
        '
        Me.ClientSize = New System.Drawing.Size(764, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmViewProductCostRecords"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Cost Records"
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grProductCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grProductCosts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colVUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatecostchanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents btnSelect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblproductInfo As System.Windows.Forms.Label
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rpgStdVol As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bLblVolumeUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblVolumeUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblVolumeStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtVolumeUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtVolumeUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtlVolumeStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rpgStdWgt As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bLblWeightUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblWeightUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblWeightStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWeightUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWeightUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWeightStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents colWUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWcost As DevExpress.XtraGrid.Columns.GridColumn
End Class
