<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewPriceListRecords

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
        Me.btnNewPriceRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPriceRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeletePriceRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSelect = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grProductCosts = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New CustomDevExGridView()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainerprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEffectivedate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTaxable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblproductInfo = New System.Windows.Forms.Label()
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomer = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grProductCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.PricelistCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewPriceRecord, Me.btnEditPriceRecord, Me.btnDeletePriceRecord, Me.btnSelect, Me.btnClose})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(456, 96)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewPriceRecord
        '
        Me.btnNewPriceRecord.Caption = "New Price Record"
        Me.btnNewPriceRecord.Id = 0
        Me.btnNewPriceRecord.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnNewPriceRecord.Name = "btnNewPriceRecord"
        '
        'btnEditPriceRecord
        '
        Me.btnEditPriceRecord.Caption = "Edit Price Record"
        Me.btnEditPriceRecord.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditPriceRecord.Id = 1
        Me.btnEditPriceRecord.Name = "btnEditPriceRecord"
        '
        'btnDeletePriceRecord
        '
        Me.btnDeletePriceRecord.Caption = "Delete Price Record"
        Me.btnDeletePriceRecord.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeletePriceRecord.Id = 2
        Me.btnDeletePriceRecord.Name = "btnDeletePriceRecord"
        '
        'btnSelect
        '
        Me.btnSelect.Caption = "Select Price"
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNewPriceRecord)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditPriceRecord)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDeletePriceRecord)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Price List Records"
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
        Me.PanelControl2.Size = New System.Drawing.Size(456, 195)
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
        Me.grProductCosts.Size = New System.Drawing.Size(444, 160)
        Me.grProductCosts.TabIndex = 41
        Me.grProductCosts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUom, Me.colUnits, Me.colUnitprice, Me.colContainerprice, Me.colEffectivedate, Me.colTaxable})
        Me.GridView1.GridControl = Me.grProductCosts
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.OptionsColumn.AllowEdit = False
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 0
        Me.colUom.Width = 73
        '
        'colUnits
        '
        Me.colUnits.Caption = "Units"
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.OptionsColumn.AllowEdit = False
        Me.colUnits.Visible = True
        Me.colUnits.VisibleIndex = 1
        Me.colUnits.Width = 76
        '
        'colUnitprice
        '
        Me.colUnitprice.Caption = "Unit $"
        Me.colUnitprice.FieldName = "Unitprice"
        Me.colUnitprice.Name = "colUnitprice"
        Me.colUnitprice.OptionsColumn.AllowEdit = False
        Me.colUnitprice.Visible = True
        Me.colUnitprice.VisibleIndex = 2
        Me.colUnitprice.Width = 89
        '
        'colContainerprice
        '
        Me.colContainerprice.Caption = "Container $"
        Me.colContainerprice.FieldName = "Containerprice"
        Me.colContainerprice.Name = "colContainerprice"
        Me.colContainerprice.OptionsColumn.AllowEdit = False
        Me.colContainerprice.Visible = True
        Me.colContainerprice.VisibleIndex = 3
        Me.colContainerprice.Width = 106
        '
        'colEffectivedate
        '
        Me.colEffectivedate.Caption = "Eff Date"
        Me.colEffectivedate.FieldName = "Effectivedate"
        Me.colEffectivedate.Name = "colEffectivedate"
        Me.colEffectivedate.OptionsColumn.AllowEdit = False
        Me.colEffectivedate.Visible = True
        Me.colEffectivedate.VisibleIndex = 4
        Me.colEffectivedate.Width = 106
        '
        'colTaxable
        '
        Me.colTaxable.Caption = "Tax"
        Me.colTaxable.FieldName = "Taxable"
        Me.colTaxable.Name = "colTaxable"
        Me.colTaxable.OptionsColumn.AllowEdit = False
        Me.colTaxable.Visible = True
        Me.colTaxable.VisibleIndex = 5
        Me.colTaxable.Width = 109
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Vendorname"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ReadOnly = True
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit1.ValueMember = "Vendorid"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.lblproductInfo)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(6, 6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(444, 23)
        Me.PanelControl1.TabIndex = 42
        '
        'lblproductInfo
        '
        Me.lblproductInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblproductInfo.Location = New System.Drawing.Point(0, 0)
        Me.lblproductInfo.Name = "lblproductInfo"
        Me.lblproductInfo.Size = New System.Drawing.Size(444, 23)
        Me.lblproductInfo.TabIndex = 3
        Me.lblproductInfo.Text = "ID  - Product Desc - Container"
        Me.lblproductInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'bsCustomer
        '
        Me.bsCustomer.DataSource = GetType(AOS.BusinessObjects.Customer)
        '
        'frmViewPriceListRecords
        '
        Me.ClientSize = New System.Drawing.Size(456, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmViewPriceListRecords"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Price List Records"
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grProductCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewPriceRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPriceRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeletePriceRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grProductCosts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents btnSelect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblproductInfo As System.Windows.Forms.Label
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainerprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEffectivedate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTaxable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsCustomer As System.Windows.Forms.BindingSource
End Class
