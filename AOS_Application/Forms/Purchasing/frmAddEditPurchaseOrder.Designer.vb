<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditPurchaseOrder

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
        Dim CustorderdateLabel As System.Windows.Forms.Label
        Dim OrderstatusLabel As System.Windows.Forms.Label
        Dim OrdertermsLabel As System.Windows.Forms.Label
        Dim ShipcityLabel As System.Windows.Forms.Label
        Dim ShipcountryLabel As System.Windows.Forms.Label
        Dim Shipaddress2Label As System.Windows.Forms.Label
        Dim ShipcontactLabel As System.Windows.Forms.Label
        Dim Shipaddress1Label As System.Windows.Forms.Label
        Dim SuppliercompanyLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim OrdernotesLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddPOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeletePOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarkClosed = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAllocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnallocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMiscCharge = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintPurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReOpenPO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCOAText = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grPOItems = New DevExpress.XtraGrid.GridControl()
        Me.bsPOItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitorcontainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyordered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendoritemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpecteddelivery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProductDesc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luContainer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luStdgallons = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.luCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPO = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.eInstructions = New DevExpress.XtraEditors.MemoEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.eVendor = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.ePhone = New DevExpress.XtraEditors.TextEdit()
        Me.eAddress1 = New DevExpress.XtraEditors.TextEdit()
        Me.eAddress2 = New DevExpress.XtraEditors.TextEdit()
        Me.eContact = New DevExpress.XtraEditors.TextEdit()
        Me.eCity = New DevExpress.XtraEditors.TextEdit()
        Me.eState = New DevExpress.XtraEditors.TextEdit()
        Me.eCompany = New DevExpress.XtraEditors.TextEdit()
        Me.eZip = New DevExpress.XtraEditors.TextEdit()
        Me.OrdertermsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ePOStatus = New DevExpress.XtraEditors.TextEdit()
        Me.WorkordernumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustorderdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        CustorderdateLabel = New System.Windows.Forms.Label()
        OrderstatusLabel = New System.Windows.Forms.Label()
        OrdertermsLabel = New System.Windows.Forms.Label()
        ShipcityLabel = New System.Windows.Forms.Label()
        ShipcountryLabel = New System.Windows.Forms.Label()
        Shipaddress2Label = New System.Windows.Forms.Label()
        ShipcontactLabel = New System.Windows.Forms.Label()
        Shipaddress1Label = New System.Windows.Forms.Label()
        SuppliercompanyLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        OrdernotesLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grPOItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPOItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.luCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInstructions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.ePhone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eAddress1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eAddress2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eState.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCompany.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eZip.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdertermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePOStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustorderdateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustorderdateLabel
        '
        CustorderdateLabel.AutoSize = True
        CustorderdateLabel.Location = New System.Drawing.Point(201, 29)
        CustorderdateLabel.Name = "CustorderdateLabel"
        CustorderdateLabel.Size = New System.Drawing.Size(30, 13)
        CustorderdateLabel.TabIndex = 20
        CustorderdateLabel.Text = "Date"
        '
        'OrderstatusLabel
        '
        OrderstatusLabel.AutoSize = True
        OrderstatusLabel.Location = New System.Drawing.Point(551, 29)
        OrderstatusLabel.Name = "OrderstatusLabel"
        OrderstatusLabel.Size = New System.Drawing.Size(38, 13)
        OrderstatusLabel.TabIndex = 26
        OrderstatusLabel.Text = "Status"
        '
        'OrdertermsLabel
        '
        OrdertermsLabel.AutoSize = True
        OrdertermsLabel.Location = New System.Drawing.Point(397, 59)
        OrdertermsLabel.Name = "OrdertermsLabel"
        OrdertermsLabel.Size = New System.Drawing.Size(36, 13)
        OrdertermsLabel.TabIndex = 27
        OrdertermsLabel.Text = "Terms"
        '
        'ShipcityLabel
        '
        ShipcityLabel.AutoSize = True
        ShipcityLabel.Location = New System.Drawing.Point(7, 104)
        ShipcityLabel.Name = "ShipcityLabel"
        ShipcityLabel.Size = New System.Drawing.Size(56, 13)
        ShipcityLabel.TabIndex = 42
        ShipcityLabel.Text = "City St Zip"
        '
        'ShipcountryLabel
        '
        ShipcountryLabel.AutoSize = True
        ShipcountryLabel.Location = New System.Drawing.Point(7, 27)
        ShipcountryLabel.Name = "ShipcountryLabel"
        ShipcountryLabel.Size = New System.Drawing.Size(52, 13)
        ShipcountryLabel.TabIndex = 48
        ShipcountryLabel.Text = "Company"
        '
        'Shipaddress2Label
        '
        Shipaddress2Label.AutoSize = True
        Shipaddress2Label.Location = New System.Drawing.Point(7, 78)
        Shipaddress2Label.Name = "Shipaddress2Label"
        Shipaddress2Label.Size = New System.Drawing.Size(52, 13)
        Shipaddress2Label.TabIndex = 40
        Shipaddress2Label.Text = "Address2"
        '
        'ShipcontactLabel
        '
        ShipcontactLabel.AutoSize = True
        ShipcontactLabel.Location = New System.Drawing.Point(7, 130)
        ShipcontactLabel.Name = "ShipcontactLabel"
        ShipcontactLabel.Size = New System.Drawing.Size(45, 13)
        ShipcontactLabel.TabIndex = 50
        ShipcontactLabel.Text = "Contact"
        '
        'Shipaddress1Label
        '
        Shipaddress1Label.AutoSize = True
        Shipaddress1Label.Location = New System.Drawing.Point(7, 52)
        Shipaddress1Label.Name = "Shipaddress1Label"
        Shipaddress1Label.Size = New System.Drawing.Size(52, 13)
        Shipaddress1Label.TabIndex = 38
        Shipaddress1Label.Text = "Address1"
        '
        'SuppliercompanyLabel
        '
        SuppliercompanyLabel.AutoSize = True
        SuppliercompanyLabel.Location = New System.Drawing.Point(22, 55)
        SuppliercompanyLabel.Name = "SuppliercompanyLabel"
        SuppliercompanyLabel.Size = New System.Drawing.Size(41, 13)
        SuppliercompanyLabel.TabIndex = 54
        SuppliercompanyLabel.Text = "Vendor"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(385, 28)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 13)
        Label1.TabIndex = 56
        Label1.Text = "PO Type"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(211, 130)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(37, 13)
        Label2.TabIndex = 53
        Label2.Text = "Phone"
        '
        'OrdernotesLabel
        '
        OrdernotesLabel.Location = New System.Drawing.Point(366, 80)
        OrdernotesLabel.Name = "OrdernotesLabel"
        OrdernotesLabel.Size = New System.Drawing.Size(67, 42)
        OrdernotesLabel.TabIndex = 25
        OrdernotesLabel.Text = "Special Instructions"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(22, 29)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(61, 13)
        Label3.TabIndex = 60
        Label3.Text = "PO Number"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(22, 80)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 13)
        Label4.TabIndex = 62
        Label4.Text = "Customer"
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
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnAddPOItem, Me.btnEditPOItem, Me.btnDeletePOItem, Me.btnMarkClosed, Me.btnAllocate, Me.btnUnallocate, Me.btnMiscCharge, Me.btnPrintPurchaseOrder, Me.btnReOpenPO, Me.btnCOAText})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 12
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1156, 95)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 0
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 1
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'btnAddPOItem
        '
        Me.btnAddPOItem.Caption = "Add New PO Item"
        Me.btnAddPOItem.Id = 2
        Me.btnAddPOItem.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddPOItem.Name = "btnAddPOItem"
        '
        'btnEditPOItem
        '
        Me.btnEditPOItem.Caption = "Edit PO Item"
        Me.btnEditPOItem.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditPOItem.Id = 3
        Me.btnEditPOItem.Name = "btnEditPOItem"
        '
        'btnDeletePOItem
        '
        Me.btnDeletePOItem.Caption = "Delete PO Item"
        Me.btnDeletePOItem.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeletePOItem.Id = 4
        Me.btnDeletePOItem.Name = "btnDeletePOItem"
        '
        'btnMarkClosed
        '
        Me.btnMarkClosed.Caption = "Mark As Closed"
        Me.btnMarkClosed.Id = 5
        Me.btnMarkClosed.LargeGlyph = Global.AOS.My.Resources.Resources.Close
        Me.btnMarkClosed.Name = "btnMarkClosed"
        '
        'btnAllocate
        '
        Me.btnAllocate.Caption = "Allocate"
        Me.btnAllocate.Id = 6
        Me.btnAllocate.LargeGlyph = Global.AOS.My.Resources.Resources.Quarantine
        Me.btnAllocate.Name = "btnAllocate"
        '
        'btnUnallocate
        '
        Me.btnUnallocate.Caption = "Unallocate"
        Me.btnUnallocate.Id = 7
        Me.btnUnallocate.LargeGlyph = Global.AOS.My.Resources.Resources.Unquarantine
        Me.btnUnallocate.Name = "btnUnallocate"
        '
        'btnMiscCharge
        '
        Me.btnMiscCharge.Caption = "Misc Charge"
        Me.btnMiscCharge.Glyph = Global.AOS.My.Resources.Resources.NewDocumentHS
        Me.btnMiscCharge.Id = 8
        Me.btnMiscCharge.Name = "btnMiscCharge"
        '
        'btnPrintPurchaseOrder
        '
        Me.btnPrintPurchaseOrder.Caption = "Print"
        Me.btnPrintPurchaseOrder.Id = 9
        Me.btnPrintPurchaseOrder.LargeGlyph = Global.AOS.My.Resources.Resources.Printer
        Me.btnPrintPurchaseOrder.Name = "btnPrintPurchaseOrder"
        '
        'btnReOpenPO
        '
        Me.btnReOpenPO.Caption = "Mark as Open"
        Me.btnReOpenPO.Id = 10
        Me.btnReOpenPO.LargeGlyph = Global.AOS.My.Resources.Resources.Change
        Me.btnReOpenPO.Name = "btnReOpenPO"
        '
        'btnCOAText
        '
        Me.btnCOAText.Caption = "COA Text"
        Me.btnCOAText.Id = 11
        Me.btnCOAText.LargeGlyph = Global.AOS.My.Resources.Resources.document_edit
        Me.btnCOAText.Name = "btnCOAText"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Action"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddPOItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditPOItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeletePOItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnMiscCharge)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Purchase Order Items"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnMarkClosed)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnReOpenPO)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Status"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnPrintPurchaseOrder)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Reports"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1156, 614)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl4.Controls.Add(Me.grPOItems)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 272)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1156, 342)
        Me.GroupControl4.TabIndex = 6
        Me.GroupControl4.Text = "Work Order Items"
        '
        'grPOItems
        '
        Me.grPOItems.DataSource = Me.bsPOItems
        Me.grPOItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPOItems.Location = New System.Drawing.Point(0, 0)
        Me.grPOItems.MainView = Me.GridView1
        Me.grPOItems.Name = "grPOItems"
        Me.grPOItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1})
        Me.grPOItems.Size = New System.Drawing.Size(1156, 342)
        Me.grPOItems.TabIndex = 4
        Me.grPOItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsPOItems
        '
        Me.bsPOItems.DataSource = GetType(AOS.BusinessObjects.PoitemCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colUom, Me.colUnits, Me.colUnitorcontainer, Me.colQtyordered, Me.colVendoritemnumber, Me.colExpecteddelivery, Me.colUnitcost, Me.colExtcost})
        Me.GridView1.GridControl = Me.grPOItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 2
        Me.colProductid.Width = 60
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 3
        Me.colProductdesc.Width = 222
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 4
        Me.colContainer.Width = 89
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 5
        Me.colUom.Width = 47
        '
        'colUnits
        '
        Me.colUnits.Caption = "Units"
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.Visible = True
        Me.colUnits.VisibleIndex = 6
        Me.colUnits.Width = 57
        '
        'colUnitorcontainer
        '
        Me.colUnitorcontainer.Caption = "U/C"
        Me.colUnitorcontainer.FieldName = "Unitorcontainer"
        Me.colUnitorcontainer.Name = "colUnitorcontainer"
        Me.colUnitorcontainer.Visible = True
        Me.colUnitorcontainer.VisibleIndex = 1
        Me.colUnitorcontainer.Width = 43
        '
        'colQtyordered
        '
        Me.colQtyordered.Caption = "Qty"
        Me.colQtyordered.FieldName = "Qtyordered"
        Me.colQtyordered.Name = "colQtyordered"
        Me.colQtyordered.Visible = True
        Me.colQtyordered.VisibleIndex = 0
        Me.colQtyordered.Width = 58
        '
        'colVendoritemnumber
        '
        Me.colVendoritemnumber.Caption = "Vendor Item #"
        Me.colVendoritemnumber.FieldName = "Vendoritemnumber"
        Me.colVendoritemnumber.Name = "colVendoritemnumber"
        Me.colVendoritemnumber.Visible = True
        Me.colVendoritemnumber.VisibleIndex = 8
        Me.colVendoritemnumber.Width = 92
        '
        'colExpecteddelivery
        '
        Me.colExpecteddelivery.Caption = "Expected In"
        Me.colExpecteddelivery.FieldName = "Expecteddelivery"
        Me.colExpecteddelivery.Name = "colExpecteddelivery"
        Me.colExpecteddelivery.Visible = True
        Me.colExpecteddelivery.VisibleIndex = 7
        '
        'colUnitcost
        '
        Me.colUnitcost.Caption = "Unit Cost"
        Me.colUnitcost.DisplayFormat.FormatString = "c4"
        Me.colUnitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitcost.FieldName = "Unitcost"
        Me.colUnitcost.Name = "colUnitcost"
        Me.colUnitcost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Unitcost", "Total:")})
        Me.colUnitcost.Visible = True
        Me.colUnitcost.VisibleIndex = 9
        Me.colUnitcost.Width = 80
        '
        'colExtcost
        '
        Me.colExtcost.Caption = "Extended Cost"
        Me.colExtcost.DisplayFormat.FormatString = "c2"
        Me.colExtcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExtcost.FieldName = "Extcost"
        Me.colExtcost.GroupFormat.FormatString = "c2"
        Me.colExtcost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExtcost.Name = "colExtcost"
        Me.colExtcost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Extcost", "{0:c2}")})
        Me.colExtcost.Visible = True
        Me.colExtcost.VisibleIndex = 10
        Me.colExtcost.Width = 107
        '
        'luProductDesc
        '
        Me.luProductDesc.AutoHeight = False
        Me.luProductDesc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luProductDesc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luProductDesc.DataSource = Me.bsProducts
        Me.luProductDesc.DisplayMember = "Productdesc"
        Me.luProductDesc.Name = "luProductDesc"
        Me.luProductDesc.NullText = ""
        Me.luProductDesc.ReadOnly = True
        Me.luProductDesc.ShowFooter = False
        Me.luProductDesc.ShowHeader = False
        Me.luProductDesc.ShowLines = False
        Me.luProductDesc.ValueMember = "Productid"
        '
        'luContainer
        '
        Me.luContainer.AutoHeight = False
        Me.luContainer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luContainer.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luContainer.DataSource = Me.bsProducts
        Me.luContainer.DisplayMember = "Container"
        Me.luContainer.Name = "luContainer"
        Me.luContainer.NullText = ""
        Me.luContainer.ReadOnly = True
        Me.luContainer.ShowFooter = False
        Me.luContainer.ShowHeader = False
        Me.luContainer.ValueMember = "Productid"
        '
        'luStdgallons
        '
        Me.luStdgallons.AutoHeight = False
        Me.luStdgallons.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luStdgallons.DataSource = Me.bsProducts
        Me.luStdgallons.DisplayMember = "Stdgallons"
        Me.luStdgallons.Name = "luStdgallons"
        Me.luStdgallons.NullText = ""
        Me.luStdgallons.ReadOnly = True
        Me.luStdgallons.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Productid"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1156, 272)
        Me.PanelControl2.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Me.luCustomer)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.eInstructions)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(SuppliercompanyLabel)
        Me.GroupControl1.Controls.Add(Me.eVendor)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(OrdertermsLabel)
        Me.GroupControl1.Controls.Add(Me.OrdertermsTextEdit)
        Me.GroupControl1.Controls.Add(OrderstatusLabel)
        Me.GroupControl1.Controls.Add(Me.ePOStatus)
        Me.GroupControl1.Controls.Add(OrdernotesLabel)
        Me.GroupControl1.Controls.Add(CustorderdateLabel)
        Me.GroupControl1.Controls.Add(Me.WorkordernumberTextEdit)
        Me.GroupControl1.Controls.Add(Me.CustorderdateDateEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1156, 272)
        Me.GroupControl1.TabIndex = 23
        Me.GroupControl1.Text = "Purchase Order Information"
        '
        'luCustomer
        '
        Me.luCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Custid", True))
        Me.luCustomer.Location = New System.Drawing.Point(95, 80)
        Me.luCustomer.Name = "luCustomer"
        Me.luCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luCustomer.Properties.DataSource = Me.bsCustomers
        Me.luCustomer.Properties.DisplayMember = "Custname"
        Me.luCustomer.Properties.DropDownRows = 20
        Me.luCustomer.Properties.NullText = ""
        Me.luCustomer.Properties.PopupWidth = 350
        Me.luCustomer.Properties.ShowFooter = False
        Me.luCustomer.Properties.ValueMember = "Custid"
        Me.luCustomer.Size = New System.Drawing.Size(188, 20)
        Me.luCustomer.TabIndex = 61
        '
        'bsPO
        '
        Me.bsPO.DataSource = GetType(AOS.BusinessObjects.Po)
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Changeableponumber", True))
        Me.TextEdit3.Location = New System.Drawing.Point(95, 26)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TextEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.TextEdit3.Size = New System.Drawing.Size(95, 20)
        Me.TextEdit3.TabIndex = 20
        Me.TextEdit3.TabStop = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(290, 52)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(54, 20)
        Me.SimpleButton1.TabIndex = 59
        Me.SimpleButton1.Text = "Notes"
        '
        'eInstructions
        '
        Me.eInstructions.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Instructions", True))
        Me.eInstructions.Location = New System.Drawing.Point(440, 80)
        Me.eInstructions.Name = "eInstructions"
        Me.eInstructions.Properties.Appearance.Options.UseTextOptions = True
        Me.eInstructions.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eInstructions.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.eInstructions.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.eInstructions.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.eInstructions.Size = New System.Drawing.Size(250, 186)
        Me.eInstructions.TabIndex = 58
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Potype", True))
        Me.TextEdit1.Location = New System.Drawing.Point(440, 26)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TextEdit1.TabIndex = 57
        '
        'eVendor
        '
        Me.eVendor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Vendorid", True))
        Me.eVendor.Location = New System.Drawing.Point(95, 52)
        Me.eVendor.Name = "eVendor"
        Me.eVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eVendor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorname", "Vendor Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eVendor.Properties.DataSource = Me.bsVendors
        Me.eVendor.Properties.DisplayMember = "Vendorname"
        Me.eVendor.Properties.DropDownRows = 20
        Me.eVendor.Properties.NullText = ""
        Me.eVendor.Properties.PopupWidth = 200
        Me.eVendor.Properties.ValueMember = "Vendorid"
        Me.eVendor.Size = New System.Drawing.Size(188, 20)
        Me.eVendor.TabIndex = 55
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.ePhone)
        Me.GroupControl3.Controls.Add(Me.eAddress1)
        Me.GroupControl3.Controls.Add(Shipaddress1Label)
        Me.GroupControl3.Controls.Add(ShipcontactLabel)
        Me.GroupControl3.Controls.Add(Me.eAddress2)
        Me.GroupControl3.Controls.Add(Me.eContact)
        Me.GroupControl3.Controls.Add(Shipaddress2Label)
        Me.GroupControl3.Controls.Add(ShipcountryLabel)
        Me.GroupControl3.Controls.Add(Me.eCity)
        Me.GroupControl3.Controls.Add(ShipcityLabel)
        Me.GroupControl3.Controls.Add(Me.eState)
        Me.GroupControl3.Controls.Add(Me.eCompany)
        Me.GroupControl3.Controls.Add(Me.eZip)
        Me.GroupControl3.Controls.Add(Label2)
        Me.GroupControl3.Location = New System.Drawing.Point(15, 112)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(329, 154)
        Me.GroupControl3.TabIndex = 53
        Me.GroupControl3.Text = "Shipping Address"
        '
        'ePhone
        '
        Me.ePhone.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Shipphone", True))
        Me.ePhone.Location = New System.Drawing.Point(246, 127)
        Me.ePhone.Name = "ePhone"
        Me.ePhone.Size = New System.Drawing.Size(75, 20)
        Me.ePhone.TabIndex = 52
        '
        'eAddress1
        '
        Me.eAddress1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Shipaddress1", True))
        Me.eAddress1.Location = New System.Drawing.Point(80, 49)
        Me.eAddress1.Name = "eAddress1"
        Me.eAddress1.Size = New System.Drawing.Size(241, 20)
        Me.eAddress1.TabIndex = 39
        '
        'eAddress2
        '
        Me.eAddress2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Shipaddress2", True))
        Me.eAddress2.Location = New System.Drawing.Point(80, 75)
        Me.eAddress2.Name = "eAddress2"
        Me.eAddress2.Size = New System.Drawing.Size(241, 20)
        Me.eAddress2.TabIndex = 41
        '
        'eContact
        '
        Me.eContact.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Shipcontact", True))
        Me.eContact.Location = New System.Drawing.Point(80, 127)
        Me.eContact.Name = "eContact"
        Me.eContact.Size = New System.Drawing.Size(130, 20)
        Me.eContact.TabIndex = 51
        '
        'eCity
        '
        Me.eCity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Shipcity", True))
        Me.eCity.Location = New System.Drawing.Point(80, 101)
        Me.eCity.Name = "eCity"
        Me.eCity.Size = New System.Drawing.Size(130, 20)
        Me.eCity.TabIndex = 43
        '
        'eState
        '
        Me.eState.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Shipstate", True))
        Me.eState.Location = New System.Drawing.Point(216, 101)
        Me.eState.Name = "eState"
        Me.eState.Size = New System.Drawing.Size(24, 20)
        Me.eState.TabIndex = 45
        '
        'eCompany
        '
        Me.eCompany.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Shipname", True))
        Me.eCompany.Location = New System.Drawing.Point(80, 24)
        Me.eCompany.Name = "eCompany"
        Me.eCompany.Size = New System.Drawing.Size(241, 20)
        Me.eCompany.TabIndex = 49
        '
        'eZip
        '
        Me.eZip.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Shipzip", True))
        Me.eZip.Location = New System.Drawing.Point(246, 101)
        Me.eZip.Name = "eZip"
        Me.eZip.Size = New System.Drawing.Size(75, 20)
        Me.eZip.TabIndex = 47
        '
        'OrdertermsTextEdit
        '
        Me.OrdertermsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Poterms", True))
        Me.OrdertermsTextEdit.Location = New System.Drawing.Point(440, 54)
        Me.OrdertermsTextEdit.Name = "OrdertermsTextEdit"
        Me.OrdertermsTextEdit.Size = New System.Drawing.Size(250, 20)
        Me.OrdertermsTextEdit.TabIndex = 28
        '
        'ePOStatus
        '
        Me.ePOStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Postatus", True))
        Me.ePOStatus.Location = New System.Drawing.Point(595, 26)
        Me.ePOStatus.Name = "ePOStatus"
        Me.ePOStatus.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.ePOStatus.Properties.Appearance.Options.UseBackColor = True
        Me.ePOStatus.Properties.ReadOnly = True
        Me.ePOStatus.Size = New System.Drawing.Size(95, 20)
        Me.ePOStatus.TabIndex = 27
        Me.ePOStatus.TabStop = False
        '
        'WorkordernumberTextEdit
        '
        Me.WorkordernumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Ponumber", True))
        Me.WorkordernumberTextEdit.Location = New System.Drawing.Point(799, 25)
        Me.WorkordernumberTextEdit.Name = "WorkordernumberTextEdit"
        Me.WorkordernumberTextEdit.Properties.ReadOnly = True
        Me.WorkordernumberTextEdit.Size = New System.Drawing.Size(64, 20)
        Me.WorkordernumberTextEdit.TabIndex = 19
        Me.WorkordernumberTextEdit.TabStop = False
        '
        'CustorderdateDateEdit
        '
        Me.CustorderdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPO, "Podate", True))
        Me.CustorderdateDateEdit.EditValue = Nothing
        Me.CustorderdateDateEdit.Location = New System.Drawing.Point(249, 26)
        Me.CustorderdateDateEdit.Name = "CustorderdateDateEdit"
        Me.CustorderdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustorderdateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CustorderdateDateEdit.Size = New System.Drawing.Size(95, 20)
        Me.CustorderdateDateEdit.TabIndex = 21
        '
        'frmAddEditPurchaseOrder
        '
        Me.ClientSize = New System.Drawing.Size(1156, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditPurchaseOrder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase Order Information"
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grPOItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPOItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.luCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInstructions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.ePhone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eAddress1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eAddress2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eState.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCompany.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eZip.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdertermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePOStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustorderdateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grPOItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents luProductDesc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luContainer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents luStdgallons As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eVendor As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eAddress1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eAddress2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eCity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eCompany As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eState As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eZip As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrdertermsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePOStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkordernumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustorderdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddPOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeletePOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMarkClosed As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAllocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnallocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsPO As System.Windows.Forms.BindingSource
    Friend WithEvents bsPOItems As System.Windows.Forms.BindingSource
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitorcontainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyordered As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendoritemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnMiscCharge As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintPurchaseOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnReOpenPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eInstructions As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents colExpecteddelivery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCOAText As DevExpress.XtraBars.BarButtonItem
End Class
