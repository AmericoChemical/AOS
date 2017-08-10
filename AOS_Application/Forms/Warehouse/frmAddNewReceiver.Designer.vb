<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddNewReceiver

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
        Dim ReceiveddateLabel As System.Windows.Forms.Label
        Dim ReceiverdocumentLabel As System.Windows.Forms.Label
        Dim PonumberLabel As System.Windows.Forms.Label
        Dim PurchasereleasenumberLabel As System.Windows.Forms.Label
        Dim VendoridLabel As System.Windows.Forms.Label
        Dim InboundwarehouseLabel As System.Windows.Forms.Label
        Me.bsRecvItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PurchasereleasenumberLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsRecv = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPOReleases = New System.Windows.Forms.BindingSource(Me.components)
        Me.eWarehouse = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsWarehouses = New System.Windows.Forms.BindingSource(Me.components)
        Me.eVendorID = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePO = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPOs = New System.Windows.Forms.BindingSource(Me.components)
        Me.eDocument = New DevExpress.XtraEditors.TextEdit()
        Me.eRecvDate = New DevExpress.XtraEditors.DateEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New CustomDevExGridView()
        Me.colQtyreceived = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehousenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouselocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        ReceiveddateLabel = New System.Windows.Forms.Label()
        ReceiverdocumentLabel = New System.Windows.Forms.Label()
        PonumberLabel = New System.Windows.Forms.Label()
        PurchasereleasenumberLabel = New System.Windows.Forms.Label()
        VendoridLabel = New System.Windows.Forms.Label()
        InboundwarehouseLabel = New System.Windows.Forms.Label()
        CType(Me.bsRecvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PurchasereleasenumberLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRecv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPOReleases, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWarehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWarehouses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendorID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDocument.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eRecvDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eRecvDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReceiveddateLabel
        '
        ReceiveddateLabel.AutoSize = True
        ReceiveddateLabel.Location = New System.Drawing.Point(234, 10)
        ReceiveddateLabel.Name = "ReceiveddateLabel"
        ReceiveddateLabel.Size = New System.Drawing.Size(77, 13)
        ReceiveddateLabel.TabIndex = 2
        ReceiveddateLabel.Text = "Received Date"
        '
        'ReceiverdocumentLabel
        '
        ReceiverdocumentLabel.AutoSize = True
        ReceiverdocumentLabel.Location = New System.Drawing.Point(8, 60)
        ReceiverdocumentLabel.Name = "ReceiverdocumentLabel"
        ReceiverdocumentLabel.Size = New System.Drawing.Size(86, 13)
        ReceiverdocumentLabel.TabIndex = 4
        ReceiverdocumentLabel.Text = "Other Document"
        '
        'PonumberLabel
        '
        PonumberLabel.AutoSize = True
        PonumberLabel.Location = New System.Drawing.Point(8, 8)
        PonumberLabel.Name = "PonumberLabel"
        PonumberLabel.Size = New System.Drawing.Size(61, 13)
        PonumberLabel.TabIndex = 6
        PonumberLabel.Text = "PO Number"
        '
        'PurchasereleasenumberLabel
        '
        PurchasereleasenumberLabel.AutoSize = True
        PurchasereleasenumberLabel.Location = New System.Drawing.Point(8, 33)
        PurchasereleasenumberLabel.Name = "PurchasereleasenumberLabel"
        PurchasereleasenumberLabel.Size = New System.Drawing.Size(102, 13)
        PurchasereleasenumberLabel.TabIndex = 8
        PurchasereleasenumberLabel.Text = "PO Release Number"
        '
        'VendoridLabel
        '
        VendoridLabel.AutoSize = True
        VendoridLabel.Location = New System.Drawing.Point(234, 34)
        VendoridLabel.Name = "VendoridLabel"
        VendoridLabel.Size = New System.Drawing.Size(41, 13)
        VendoridLabel.TabIndex = 10
        VendoridLabel.Text = "Vendor"
        '
        'InboundwarehouseLabel
        '
        InboundwarehouseLabel.AutoSize = True
        InboundwarehouseLabel.Location = New System.Drawing.Point(234, 60)
        InboundwarehouseLabel.Name = "InboundwarehouseLabel"
        InboundwarehouseLabel.Size = New System.Drawing.Size(62, 13)
        InboundwarehouseLabel.TabIndex = 12
        InboundwarehouseLabel.Text = "Warehouse"
        '
        'bsRecvItems
        '
        Me.bsRecvItems.DataSource = GetType(AOS.BusinessObjects.ReceiveritemCollection)
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.PurchasereleasenumberLookUpEdit)
        Me.PanelControl2.Controls.Add(Me.eWarehouse)
        Me.PanelControl2.Controls.Add(Me.eVendorID)
        Me.PanelControl2.Controls.Add(Me.ePO)
        Me.PanelControl2.Controls.Add(InboundwarehouseLabel)
        Me.PanelControl2.Controls.Add(VendoridLabel)
        Me.PanelControl2.Controls.Add(PonumberLabel)
        Me.PanelControl2.Controls.Add(ReceiverdocumentLabel)
        Me.PanelControl2.Controls.Add(Me.eDocument)
        Me.PanelControl2.Controls.Add(ReceiveddateLabel)
        Me.PanelControl2.Controls.Add(Me.eRecvDate)
        Me.PanelControl2.Controls.Add(PurchasereleasenumberLabel)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(6, 6)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(972, 88)
        Me.PanelControl2.TabIndex = 1
        '
        'PurchasereleasenumberLookUpEdit
        '
        Me.PurchasereleasenumberLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRecv, "Purchasereleasenumber", True))
        Me.PurchasereleasenumberLookUpEdit.Location = New System.Drawing.Point(119, 34)
        Me.PurchasereleasenumberLookUpEdit.Name = "PurchasereleasenumberLookUpEdit"
        Me.PurchasereleasenumberLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PurchasereleasenumberLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Purchasereleasenumber", "Purchasereleasenumber", 134, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Changeableponumber", "Changeableponumber", 111, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PurchasereleasenumberLookUpEdit.Properties.DataSource = Me.bsPOReleases
        Me.PurchasereleasenumberLookUpEdit.Properties.DisplayMember = "Purchasereleasenumber"
        Me.PurchasereleasenumberLookUpEdit.Properties.NullText = ""
        Me.PurchasereleasenumberLookUpEdit.Properties.ValueMember = "Purchasereleasenumber"
        Me.PurchasereleasenumberLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.PurchasereleasenumberLookUpEdit.TabIndex = 17
        '
        'bsRecv
        '
        Me.bsRecv.DataSource = GetType(AOS.BusinessObjects.Receiver)
        '
        'eWarehouse
        '
        Me.eWarehouse.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRecv, "Inboundwarehouse", True))
        Me.eWarehouse.Location = New System.Drawing.Point(318, 60)
        Me.eWarehouse.Name = "eWarehouse"
        Me.eWarehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eWarehouse.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Warehouseid", "WH ID", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Warehousename", "Warehouse", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Consigneename", "Consignee", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eWarehouse.Properties.DataSource = Me.bsWarehouses
        Me.eWarehouse.Properties.DisplayMember = "Warehousename"
        Me.eWarehouse.Properties.NullText = ""
        Me.eWarehouse.Properties.ValueMember = "Warehouseid"
        Me.eWarehouse.Size = New System.Drawing.Size(192, 20)
        Me.eWarehouse.TabIndex = 16
        '
        'bsWarehouses
        '
        Me.bsWarehouses.DataSource = GetType(AOS.BusinessObjects.WarehouseCollection)
        '
        'eVendorID
        '
        Me.eVendorID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRecv, "Vendorid", True))
        Me.eVendorID.Location = New System.Drawing.Point(318, 34)
        Me.eVendorID.Name = "eVendorID"
        Me.eVendorID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eVendorID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorid", "ID", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorname", "Vendor Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eVendorID.Properties.DataSource = Me.bsVendors
        Me.eVendorID.Properties.DisplayMember = "Vendorname"
        Me.eVendorID.Properties.NullText = ""
        Me.eVendorID.Properties.ValueMember = "Vendorid"
        Me.eVendorID.Size = New System.Drawing.Size(192, 20)
        Me.eVendorID.TabIndex = 15
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'ePO
        '
        Me.ePO.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRecv, "Ponumber", True))
        Me.ePO.Location = New System.Drawing.Point(119, 8)
        Me.ePO.Name = "ePO"
        Me.ePO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ePO.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Changeableponumber", "PO #", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Podate", "PO Date", 60, DevExpress.Utils.FormatType.DateTime, "d", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorid", "Vendor", 48, DevExpress.Utils.FormatType.Numeric, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Expecteddelivery", "Exp Delv", 89, DevExpress.Utils.FormatType.DateTime, "d", True, DevExpress.Utils.HorzAlignment.Center)})
        Me.ePO.Properties.DataSource = Me.bsPOs
        Me.ePO.Properties.DisplayMember = "Changeableponumber"
        Me.ePO.Properties.NullText = ""
        Me.ePO.Properties.ValueMember = "Ponumber"
        Me.ePO.Size = New System.Drawing.Size(100, 20)
        Me.ePO.TabIndex = 14
        '
        'eDocument
        '
        Me.eDocument.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRecv, "Receiverdocument", True))
        Me.eDocument.Location = New System.Drawing.Point(119, 60)
        Me.eDocument.Name = "eDocument"
        Me.eDocument.Size = New System.Drawing.Size(100, 20)
        Me.eDocument.TabIndex = 5
        '
        'eRecvDate
        '
        Me.eRecvDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRecv, "Receiveddate", True))
        Me.eRecvDate.EditValue = Nothing
        Me.eRecvDate.Location = New System.Drawing.Point(318, 8)
        Me.eRecvDate.Name = "eRecvDate"
        Me.eRecvDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eRecvDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eRecvDate.Size = New System.Drawing.Size(83, 20)
        Me.eRecvDate.TabIndex = 3
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(984, 93)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Receiver Item"
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
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1})
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
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnNewCostRecord)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Items"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.grItems)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 93)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl1.Size = New System.Drawing.Size(984, 376)
        Me.PanelControl1.TabIndex = 6
        '
        'grItems
        '
        Me.grItems.DataSource = Me.bsRecvItems
        Me.grItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grItems.Location = New System.Drawing.Point(6, 94)
        Me.grItems.MainView = Me.GridView1
        Me.grItems.Name = "grItems"
        Me.grItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.grItems.Size = New System.Drawing.Size(972, 276)
        Me.grItems.TabIndex = 3
        Me.grItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQtyreceived, Me.colProductid, Me.GridColumn1, Me.colContainer, Me.colLotnumber, Me.colWarehousenumber, Me.colWarehouselocation, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.GridControl = Me.grItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsNavigation.AutoFocusNewRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colQtyreceived
        '
        Me.colQtyreceived.Caption = "Qty"
        Me.colQtyreceived.FieldName = "Qtyreceived"
        Me.colQtyreceived.Name = "colQtyreceived"
        Me.colQtyreceived.Visible = True
        Me.colQtyreceived.VisibleIndex = 0
        Me.colQtyreceived.Width = 53
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 1
        Me.colProductid.Width = 62
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Product Description"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn1.FieldName = "Productid"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 194
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ReadOnly = True
        Me.RepositoryItemLookUpEdit1.ValueMember = "Productid"
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 4
        Me.colContainer.Width = 73
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot Number"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 5
        Me.colLotnumber.Width = 96
        '
        'colWarehousenumber
        '
        Me.colWarehousenumber.Caption = "Whse"
        Me.colWarehousenumber.FieldName = "Warehousenumber"
        Me.colWarehousenumber.Name = "colWarehousenumber"
        Me.colWarehousenumber.Visible = True
        Me.colWarehousenumber.VisibleIndex = 6
        Me.colWarehousenumber.Width = 47
        '
        'colWarehouselocation
        '
        Me.colWarehouselocation.Caption = "Bin"
        Me.colWarehouselocation.FieldName = "Warehouselocation"
        Me.colWarehouselocation.Name = "colWarehouselocation"
        Me.colWarehouselocation.Visible = True
        Me.colWarehouselocation.VisibleIndex = 7
        Me.colWarehouselocation.Width = 55
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "UOM"
        Me.GridColumn2.FieldName = "Uom"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 8
        Me.GridColumn2.Width = 50
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Units"
        Me.GridColumn3.FieldName = "Units"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 9
        Me.GridColumn3.Width = 48
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Unit Cost"
        Me.GridColumn4.FieldName = "Unitcost"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 10
        Me.GridColumn4.Width = 71
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Posted"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn5.FieldName = "Posted"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 11
        Me.GridColumn5.Width = 76
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "Y"
        Me.RepositoryItemCheckEdit1.ValueGrayed = "N"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "N"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Addn Desc"
        Me.GridColumn6.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.GridColumn6.FieldName = "Productid"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 3
        Me.GridColumn6.Width = 126
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Productid"
        '
        'frmAddNewReceiver
        '
        Me.ClientSize = New System.Drawing.Size(984, 469)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.Name = "frmAddNewReceiver"
        Me.Text = "Receiver Information"
        CType(Me.bsRecvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.PurchasereleasenumberLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRecv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPOReleases, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWarehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWarehouses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendorID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDocument.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eRecvDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eRecvDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsRecvItems As System.Windows.Forms.BindingSource
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bsRecv As System.Windows.Forms.BindingSource
    Friend WithEvents eDocument As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eRecvDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eWarehouse As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eVendorID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ePO As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PurchasereleasenumberLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsPOs As System.Windows.Forms.BindingSource
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents bsPOReleases As System.Windows.Forms.BindingSource
    Friend WithEvents bsWarehouses As System.Windows.Forms.BindingSource
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents grItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colQtyreceived As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehousenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouselocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
