<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditWorkOrders

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
        Dim WorkordernumberLabel As System.Windows.Forms.Label
        Dim CustorderdateLabel As System.Windows.Forms.Label
        Dim CustidLabel As System.Windows.Forms.Label
        Dim CustomerpoLabel As System.Windows.Forms.Label
        Dim DeliverydateLabel As System.Windows.Forms.Label
        Dim FreightcarrierLabel As System.Windows.Forms.Label
        Dim OrdernotesLabel As System.Windows.Forms.Label
        Dim OrderstatusLabel As System.Windows.Forms.Label
        Dim OrdertermsLabel As System.Windows.Forms.Label
        Dim PlannedshipdateLabel As System.Windows.Forms.Label
        Dim ShipcityLabel As System.Windows.Forms.Label
        Dim ShipcountryLabel As System.Windows.Forms.Label
        Dim Shipaddress2Label As System.Windows.Forms.Label
        Dim ShipcontactLabel As System.Windows.Forms.Label
        Dim Shipaddress1Label As System.Windows.Forms.Label
        Dim SuppliercompanyLabel As System.Windows.Forms.Label
        Dim PreparedbyLabel As System.Windows.Forms.Label
        Dim FobLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.bsWorkOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsFOB = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsEmployees = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsSuppliers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.bsWorkOrderItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddWOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditWOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteWOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarkClosed = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAllocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnallocate = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnManageInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grWorkOrderItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWorkorderitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkerordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtycontainers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProductDesc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colProductid2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luContainer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouselocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luStdgallons = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.Shipaddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.luLogistics = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.Shipaddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.btnCustomerNotes = New DevExpress.XtraEditors.SimpleButton()
        Me.ShipcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FobLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ShipcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PreparedbyLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ShipcountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SuppliercompanyLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ShipstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FreightcarrierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.ShippostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PlannedshipdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.OrdertermsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrderstatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliverydateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.eCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.CustomerpoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkordernumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustorderdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.OrdernotesTextEdit = New DevExpress.XtraEditors.MemoEdit()
        WorkordernumberLabel = New System.Windows.Forms.Label()
        CustorderdateLabel = New System.Windows.Forms.Label()
        CustidLabel = New System.Windows.Forms.Label()
        CustomerpoLabel = New System.Windows.Forms.Label()
        DeliverydateLabel = New System.Windows.Forms.Label()
        FreightcarrierLabel = New System.Windows.Forms.Label()
        OrdernotesLabel = New System.Windows.Forms.Label()
        OrderstatusLabel = New System.Windows.Forms.Label()
        OrdertermsLabel = New System.Windows.Forms.Label()
        PlannedshipdateLabel = New System.Windows.Forms.Label()
        ShipcityLabel = New System.Windows.Forms.Label()
        ShipcountryLabel = New System.Windows.Forms.Label()
        Shipaddress2Label = New System.Windows.Forms.Label()
        ShipcontactLabel = New System.Windows.Forms.Label()
        Shipaddress1Label = New System.Windows.Forms.Label()
        SuppliercompanyLabel = New System.Windows.Forms.Label()
        PreparedbyLabel = New System.Windows.Forms.Label()
        FobLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.bsWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSuppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWorkOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grWorkOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.Shipaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luLogistics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreparedbyLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliercompanyLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FreightcarrierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlannedshipdateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlannedshipdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdertermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderstatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverydateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverydateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustorderdateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdernotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WorkordernumberLabel
        '
        WorkordernumberLabel.AutoSize = True
        WorkordernumberLabel.Location = New System.Drawing.Point(23, 29)
        WorkordernumberLabel.Name = "WorkordernumberLabel"
        WorkordernumberLabel.Size = New System.Drawing.Size(36, 13)
        WorkordernumberLabel.TabIndex = 18
        WorkordernumberLabel.Text = "WO #"
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
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(23, 82)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(53, 13)
        CustidLabel.TabIndex = 17
        CustidLabel.Text = "Customer"
        '
        'CustomerpoLabel
        '
        CustomerpoLabel.AutoSize = True
        CustomerpoLabel.Location = New System.Drawing.Point(23, 108)
        CustomerpoLabel.Name = "CustomerpoLabel"
        CustomerpoLabel.Size = New System.Drawing.Size(46, 13)
        CustomerpoLabel.TabIndex = 21
        CustomerpoLabel.Text = "Cust PO"
        '
        'DeliverydateLabel
        '
        DeliverydateLabel.AutoSize = True
        DeliverydateLabel.Location = New System.Drawing.Point(365, 108)
        DeliverydateLabel.Name = "DeliverydateLabel"
        DeliverydateLabel.Size = New System.Drawing.Size(72, 13)
        DeliverydateLabel.TabIndex = 22
        DeliverydateLabel.Text = "Delivery Date"
        '
        'FreightcarrierLabel
        '
        FreightcarrierLabel.AutoSize = True
        FreightcarrierLabel.Location = New System.Drawing.Point(360, 151)
        FreightcarrierLabel.Name = "FreightcarrierLabel"
        FreightcarrierLabel.Size = New System.Drawing.Size(77, 13)
        FreightcarrierLabel.TabIndex = 24
        FreightcarrierLabel.Text = "Freight Carrier"
        '
        'OrdernotesLabel
        '
        OrdernotesLabel.Location = New System.Drawing.Point(706, 29)
        OrdernotesLabel.Name = "OrdernotesLabel"
        OrdernotesLabel.Size = New System.Drawing.Size(114, 17)
        OrdernotesLabel.TabIndex = 25
        OrdernotesLabel.Text = "Special Instructions"
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
        OrdertermsLabel.Location = New System.Drawing.Point(401, 56)
        OrdertermsLabel.Name = "OrdertermsLabel"
        OrdertermsLabel.Size = New System.Drawing.Size(36, 13)
        OrdertermsLabel.TabIndex = 27
        OrdertermsLabel.Text = "Terms"
        '
        'PlannedshipdateLabel
        '
        PlannedshipdateLabel.AutoSize = True
        PlannedshipdateLabel.Location = New System.Drawing.Point(369, 82)
        PlannedshipdateLabel.Name = "PlannedshipdateLabel"
        PlannedshipdateLabel.Size = New System.Drawing.Size(68, 13)
        PlannedshipdateLabel.TabIndex = 28
        PlannedshipdateLabel.Text = "Plan Shipped"
        '
        'ShipcityLabel
        '
        ShipcityLabel.AutoSize = True
        ShipcityLabel.Location = New System.Drawing.Point(22, 203)
        ShipcityLabel.Name = "ShipcityLabel"
        ShipcityLabel.Size = New System.Drawing.Size(56, 13)
        ShipcityLabel.TabIndex = 42
        ShipcityLabel.Text = "City St Zip"
        '
        'ShipcountryLabel
        '
        ShipcountryLabel.AutoSize = True
        ShipcountryLabel.Location = New System.Drawing.Point(22, 229)
        ShipcountryLabel.Name = "ShipcountryLabel"
        ShipcountryLabel.Size = New System.Drawing.Size(46, 13)
        ShipcountryLabel.TabIndex = 48
        ShipcountryLabel.Text = "Country"
        '
        'Shipaddress2Label
        '
        Shipaddress2Label.AutoSize = True
        Shipaddress2Label.Location = New System.Drawing.Point(22, 177)
        Shipaddress2Label.Name = "Shipaddress2Label"
        Shipaddress2Label.Size = New System.Drawing.Size(61, 13)
        Shipaddress2Label.TabIndex = 40
        Shipaddress2Label.Text = "Addr Line 2"
        '
        'ShipcontactLabel
        '
        ShipcontactLabel.AutoSize = True
        ShipcontactLabel.Location = New System.Drawing.Point(22, 255)
        ShipcontactLabel.Name = "ShipcontactLabel"
        ShipcontactLabel.Size = New System.Drawing.Size(45, 13)
        ShipcontactLabel.TabIndex = 50
        ShipcontactLabel.Text = "Contact"
        '
        'Shipaddress1Label
        '
        Shipaddress1Label.AutoSize = True
        Shipaddress1Label.Location = New System.Drawing.Point(22, 151)
        Shipaddress1Label.Name = "Shipaddress1Label"
        Shipaddress1Label.Size = New System.Drawing.Size(68, 13)
        Shipaddress1Label.TabIndex = 38
        Shipaddress1Label.Text = "Ship To Addr"
        '
        'SuppliercompanyLabel
        '
        SuppliercompanyLabel.AutoSize = True
        SuppliercompanyLabel.Location = New System.Drawing.Point(22, 55)
        SuppliercompanyLabel.Name = "SuppliercompanyLabel"
        SuppliercompanyLabel.Size = New System.Drawing.Size(45, 13)
        SuppliercompanyLabel.TabIndex = 54
        SuppliercompanyLabel.Text = "Supplier"
        '
        'PreparedbyLabel
        '
        PreparedbyLabel.AutoSize = True
        PreparedbyLabel.Location = New System.Drawing.Point(371, 29)
        PreparedbyLabel.Name = "PreparedbyLabel"
        PreparedbyLabel.Size = New System.Drawing.Size(66, 13)
        PreparedbyLabel.TabIndex = 55
        PreparedbyLabel.Text = "Prepared by"
        '
        'FobLabel
        '
        FobLabel.AutoSize = True
        FobLabel.Location = New System.Drawing.Point(410, 203)
        FobLabel.Name = "FobLabel"
        FobLabel.Size = New System.Drawing.Size(27, 13)
        FobLabel.TabIndex = 56
        FobLabel.Text = "FOB"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(347, 177)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(90, 13)
        Label1.TabIndex = 59
        Label1.Text = "Logistics Provider"
        '
        'bsWorkOrder
        '
        Me.bsWorkOrder.DataSource = GetType(AOS.BusinessObjects.Workorder)
        '
        'bsFOB
        '
        Me.bsFOB.DataSource = GetType(AOS.BusinessObjects.ListFobCollection)
        '
        'bsEmployees
        '
        Me.bsEmployees.DataSource = GetType(AOS.BusinessObjects.EmployeeCollection)
        '
        'bsSuppliers
        '
        Me.bsSuppliers.DataSource = GetType(AOS.BusinessObjects.SuppliercompanyCollection)
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
        '
        'bsWorkOrderItems
        '
        Me.bsWorkOrderItems.DataSource = GetType(AOS.BusinessObjects.WorkorderitemCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        '
        '
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnAddWOItem, Me.btnEditWOItem, Me.btnDeleteWOItem, Me.btnMarkClosed, Me.btnAllocate, Me.btnUnallocate, Me.rbtnManageInventory})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 9
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1018, 94)
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
        'btnAddWOItem
        '
        Me.btnAddWOItem.Caption = "Add New Item"
        Me.btnAddWOItem.Id = 2
        Me.btnAddWOItem.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddWOItem.Name = "btnAddWOItem"
        '
        'btnEditWOItem
        '
        Me.btnEditWOItem.Caption = "Edit Item"
        Me.btnEditWOItem.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditWOItem.Id = 3
        Me.btnEditWOItem.Name = "btnEditWOItem"
        '
        'btnDeleteWOItem
        '
        Me.btnDeleteWOItem.Caption = "Delete Item"
        Me.btnDeleteWOItem.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteWOItem.Id = 4
        Me.btnDeleteWOItem.Name = "btnDeleteWOItem"
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
        Me.btnAllocate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnUnallocate
        '
        Me.btnUnallocate.Caption = "Unallocate"
        Me.btnUnallocate.Id = 7
        Me.btnUnallocate.LargeGlyph = Global.AOS.My.Resources.Resources.Unquarantine
        Me.btnUnallocate.Name = "btnUnallocate"
        Me.btnUnallocate.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rbtnManageInventory
        '
        Me.rbtnManageInventory.Caption = "Assign Inventory Items"
        Me.rbtnManageInventory.Id = 8
        Me.rbtnManageInventory.LargeGlyph = Global.AOS.My.Resources.Resources.database_find
        Me.rbtnManageInventory.Name = "rbtnManageInventory"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup4, Me.RibbonPageGroup3})
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddWOItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditWOItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeleteWOItem)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Invoice Items"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnAllocate)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnUnallocate)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnManageInventory)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Inventory"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnMarkClosed)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Status"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 94)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1018, 646)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl4.Controls.Add(Me.grWorkOrderItems)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 286)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1018, 360)
        Me.GroupControl4.TabIndex = 6
        Me.GroupControl4.Text = "Work Order Items"
        '
        'grWorkOrderItems
        '
        Me.grWorkOrderItems.DataSource = Me.bsWorkOrderItems
        Me.grWorkOrderItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grWorkOrderItems.Location = New System.Drawing.Point(0, 0)
        Me.grWorkOrderItems.MainView = Me.GridView1
        Me.grWorkOrderItems.Name = "grWorkOrderItems"
        Me.grWorkOrderItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1})
        Me.grWorkOrderItems.Size = New System.Drawing.Size(1018, 360)
        Me.grWorkOrderItems.TabIndex = 4
        Me.grWorkOrderItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWorkorderitemnumber, Me.colWorkerordernumber, Me.colQtycontainers, Me.colProductid, Me.colProductid1, Me.colProductid2, Me.colInvitemnumber, Me.colLotnumber, Me.colWarehouselocation, Me.colBillable, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5})
        Me.GridView1.GridControl = Me.grWorkOrderItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colWorkorderitemnumber
        '
        Me.colWorkorderitemnumber.Caption = "Workorderitemnumber"
        Me.colWorkorderitemnumber.FieldName = "Workorderitemnumber"
        Me.colWorkorderitemnumber.Name = "colWorkorderitemnumber"
        Me.colWorkorderitemnumber.OptionsColumn.AllowEdit = False
        '
        'colWorkerordernumber
        '
        Me.colWorkerordernumber.Caption = "Workerordernumber"
        Me.colWorkerordernumber.FieldName = "Workerordernumber"
        Me.colWorkerordernumber.Name = "colWorkerordernumber"
        Me.colWorkerordernumber.OptionsColumn.AllowEdit = False
        '
        'colQtycontainers
        '
        Me.colQtycontainers.Caption = "Qty"
        Me.colQtycontainers.FieldName = "Qty"
        Me.colQtycontainers.Name = "colQtycontainers"
        Me.colQtycontainers.OptionsColumn.AllowEdit = False
        Me.colQtycontainers.Visible = True
        Me.colQtycontainers.VisibleIndex = 0
        Me.colQtycontainers.Width = 46
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.AllowEdit = False
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 2
        Me.colProductid.Width = 62
        '
        'colProductid1
        '
        Me.colProductid1.Caption = "Product Description"
        Me.colProductid1.ColumnEdit = Me.luProductDesc
        Me.colProductid1.FieldName = "Productid"
        Me.colProductid1.Name = "colProductid1"
        Me.colProductid1.OptionsColumn.AllowEdit = False
        Me.colProductid1.Visible = True
        Me.colProductid1.VisibleIndex = 3
        Me.colProductid1.Width = 134
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
        'colProductid2
        '
        Me.colProductid2.Caption = "Container"
        Me.colProductid2.ColumnEdit = Me.luContainer
        Me.colProductid2.FieldName = "Productid"
        Me.colProductid2.Name = "colProductid2"
        Me.colProductid2.OptionsColumn.AllowEdit = False
        Me.colProductid2.Visible = True
        Me.colProductid2.VisibleIndex = 5
        Me.colProductid2.Width = 72
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
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Inv Item#"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.OptionsColumn.AllowEdit = False
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 6
        Me.colInvitemnumber.Width = 76
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot #"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.OptionsColumn.AllowEdit = False
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 7
        Me.colLotnumber.Width = 103
        '
        'colWarehouselocation
        '
        Me.colWarehouselocation.Caption = "Bin"
        Me.colWarehouselocation.FieldName = "Warehouselocation"
        Me.colWarehouselocation.Name = "colWarehouselocation"
        Me.colWarehouselocation.OptionsColumn.AllowEdit = False
        Me.colWarehouselocation.Visible = True
        Me.colWarehouselocation.VisibleIndex = 8
        Me.colWarehouselocation.Width = 40
        '
        'colBillable
        '
        Me.colBillable.Caption = "Billable"
        Me.colBillable.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.colBillable.FieldName = "Billable"
        Me.colBillable.Name = "colBillable"
        Me.colBillable.OptionsColumn.AllowMove = False
        Me.colBillable.OptionsColumn.AllowSize = False
        Me.colBillable.OptionsColumn.FixedWidth = True
        Me.colBillable.Visible = True
        Me.colBillable.VisibleIndex = 12
        Me.colBillable.Width = 60
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.Caption = "Price"
        Me.GridColumn1.DisplayFormat.FormatString = "c2"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Extprice"
        Me.GridColumn1.GroupFormat.FormatString = "c2"
        Me.GridColumn1.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Extprice", "${0:n}")})
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 9
        Me.GridColumn1.Width = 84
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn2.Caption = "Cost"
        Me.GridColumn2.DisplayFormat.FormatString = "c2"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "Extcost"
        Me.GridColumn2.GroupFormat.FormatString = "c2"
        Me.GridColumn2.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Extcost", "${0:n}")})
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 10
        Me.GridColumn2.Width = 67
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.Caption = "Diff"
        Me.GridColumn3.DisplayFormat.FormatString = "c2"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Extprofit"
        Me.GridColumn3.GroupFormat.FormatString = "c2"
        Me.GridColumn3.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Extprofit", "${0:n}")})
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 11
        Me.GridColumn3.Width = 83
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "U/C"
        Me.GridColumn4.FieldName = "Unitorcontainer"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 44
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Addn Desc"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.GridColumn5.FieldName = "Productid"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 99
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Productid"
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
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1018, 286)
        Me.PanelControl2.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Shipaddress1TextEdit)
        Me.GroupControl1.Controls.Add(Shipaddress1Label)
        Me.GroupControl1.Controls.Add(Me.luLogistics)
        Me.GroupControl1.Controls.Add(ShipcontactLabel)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.Shipaddress2TextEdit)
        Me.GroupControl1.Controls.Add(Me.btnCustomerNotes)
        Me.GroupControl1.Controls.Add(Me.ShipcontactTextEdit)
        Me.GroupControl1.Controls.Add(FobLabel)
        Me.GroupControl1.Controls.Add(Shipaddress2Label)
        Me.GroupControl1.Controls.Add(Me.FobLookUpEdit)
        Me.GroupControl1.Controls.Add(ShipcountryLabel)
        Me.GroupControl1.Controls.Add(PreparedbyLabel)
        Me.GroupControl1.Controls.Add(Me.ShipcityTextEdit)
        Me.GroupControl1.Controls.Add(Me.PreparedbyLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.ShipcountryTextEdit)
        Me.GroupControl1.Controls.Add(SuppliercompanyLabel)
        Me.GroupControl1.Controls.Add(ShipcityLabel)
        Me.GroupControl1.Controls.Add(Me.SuppliercompanyLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.ShipstateprovTextEdit)
        Me.GroupControl1.Controls.Add(Me.FreightcarrierLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.ShippostalcodeTextEdit)
        Me.GroupControl1.Controls.Add(PlannedshipdateLabel)
        Me.GroupControl1.Controls.Add(Me.PlannedshipdateDateEdit)
        Me.GroupControl1.Controls.Add(OrdertermsLabel)
        Me.GroupControl1.Controls.Add(Me.OrdertermsTextEdit)
        Me.GroupControl1.Controls.Add(OrderstatusLabel)
        Me.GroupControl1.Controls.Add(Me.OrderstatusTextEdit)
        Me.GroupControl1.Controls.Add(OrdernotesLabel)
        Me.GroupControl1.Controls.Add(FreightcarrierLabel)
        Me.GroupControl1.Controls.Add(DeliverydateLabel)
        Me.GroupControl1.Controls.Add(Me.DeliverydateDateEdit)
        Me.GroupControl1.Controls.Add(CustomerpoLabel)
        Me.GroupControl1.Controls.Add(Me.eCustomer)
        Me.GroupControl1.Controls.Add(Me.CustomerpoTextEdit)
        Me.GroupControl1.Controls.Add(CustidLabel)
        Me.GroupControl1.Controls.Add(CustorderdateLabel)
        Me.GroupControl1.Controls.Add(Me.WorkordernumberTextEdit)
        Me.GroupControl1.Controls.Add(Me.CustorderdateDateEdit)
        Me.GroupControl1.Controls.Add(WorkordernumberLabel)
        Me.GroupControl1.Controls.Add(Me.OrdernotesTextEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1018, 286)
        Me.GroupControl1.TabIndex = 23
        Me.GroupControl1.Text = "Work Order Information"
        '
        'Shipaddress1TextEdit
        '
        Me.Shipaddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipaddress1", True))
        Me.Shipaddress1TextEdit.Location = New System.Drawing.Point(95, 148)
        Me.Shipaddress1TextEdit.Name = "Shipaddress1TextEdit"
        Me.Shipaddress1TextEdit.Size = New System.Drawing.Size(249, 20)
        Me.Shipaddress1TextEdit.TabIndex = 39
        '
        'luLogistics
        '
        Me.luLogistics.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Logisticsid", True))
        Me.luLogistics.Location = New System.Drawing.Point(439, 174)
        Me.luLogistics.Name = "luLogistics"
        Me.luLogistics.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.luLogistics.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsname", "Logisticsname", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luLogistics.Properties.DataSource = Me.bsLogistics
        Me.luLogistics.Properties.DisplayMember = "Logisticsname"
        Me.luLogistics.Properties.NullText = ""
        Me.luLogistics.Properties.ValueMember = "Logisticsid"
        Me.luLogistics.Size = New System.Drawing.Size(251, 20)
        Me.luLogistics.TabIndex = 60
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'Shipaddress2TextEdit
        '
        Me.Shipaddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipaddress2", True))
        Me.Shipaddress2TextEdit.Location = New System.Drawing.Point(95, 174)
        Me.Shipaddress2TextEdit.Name = "Shipaddress2TextEdit"
        Me.Shipaddress2TextEdit.Size = New System.Drawing.Size(249, 20)
        Me.Shipaddress2TextEdit.TabIndex = 41
        '
        'btnCustomerNotes
        '
        Me.btnCustomerNotes.Location = New System.Drawing.Point(296, 79)
        Me.btnCustomerNotes.Name = "btnCustomerNotes"
        Me.btnCustomerNotes.Size = New System.Drawing.Size(48, 20)
        Me.btnCustomerNotes.TabIndex = 58
        Me.btnCustomerNotes.Text = "Notes"
        '
        'ShipcontactTextEdit
        '
        Me.ShipcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipcontact", True))
        Me.ShipcontactTextEdit.Location = New System.Drawing.Point(95, 252)
        Me.ShipcontactTextEdit.Name = "ShipcontactTextEdit"
        Me.ShipcontactTextEdit.Size = New System.Drawing.Size(249, 20)
        Me.ShipcontactTextEdit.TabIndex = 51
        '
        'FobLookUpEdit
        '
        Me.FobLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Fob", True))
        Me.FobLookUpEdit.Location = New System.Drawing.Point(439, 200)
        Me.FobLookUpEdit.Name = "FobLookUpEdit"
        Me.FobLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FobLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FOBOption", "FOBOption", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.FobLookUpEdit.Properties.DataSource = Me.bsFOB
        Me.FobLookUpEdit.Properties.DisplayMember = "FOBOption"
        Me.FobLookUpEdit.Properties.NullText = ""
        Me.FobLookUpEdit.Properties.ShowFooter = False
        Me.FobLookUpEdit.Properties.ShowHeader = False
        Me.FobLookUpEdit.Properties.ShowLines = False
        Me.FobLookUpEdit.Properties.ValueMember = "FOBOption"
        Me.FobLookUpEdit.Size = New System.Drawing.Size(251, 20)
        Me.FobLookUpEdit.TabIndex = 57
        '
        'ShipcityTextEdit
        '
        Me.ShipcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipcity", True))
        Me.ShipcityTextEdit.Location = New System.Drawing.Point(95, 200)
        Me.ShipcityTextEdit.Name = "ShipcityTextEdit"
        Me.ShipcityTextEdit.Size = New System.Drawing.Size(130, 20)
        Me.ShipcityTextEdit.TabIndex = 43
        '
        'PreparedbyLookUpEdit
        '
        Me.PreparedbyLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Preparedby", True))
        Me.PreparedbyLookUpEdit.Location = New System.Drawing.Point(439, 26)
        Me.PreparedbyLookUpEdit.Name = "PreparedbyLookUpEdit"
        Me.PreparedbyLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PreparedbyLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Preparer", 79, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PreparedbyLookUpEdit.Properties.DataSource = Me.bsEmployees
        Me.PreparedbyLookUpEdit.Properties.DisplayMember = "EmployeeName"
        Me.PreparedbyLookUpEdit.Properties.NullText = ""
        Me.PreparedbyLookUpEdit.Properties.ValueMember = "EmployeeName"
        Me.PreparedbyLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.PreparedbyLookUpEdit.TabIndex = 56
        '
        'ShipcountryTextEdit
        '
        Me.ShipcountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipcountry", True))
        Me.ShipcountryTextEdit.Location = New System.Drawing.Point(95, 226)
        Me.ShipcountryTextEdit.Name = "ShipcountryTextEdit"
        Me.ShipcountryTextEdit.Size = New System.Drawing.Size(249, 20)
        Me.ShipcountryTextEdit.TabIndex = 49
        '
        'SuppliercompanyLookUpEdit
        '
        Me.SuppliercompanyLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Suppliercompany", True))
        Me.SuppliercompanyLookUpEdit.Location = New System.Drawing.Point(95, 52)
        Me.SuppliercompanyLookUpEdit.Name = "SuppliercompanyLookUpEdit"
        Me.SuppliercompanyLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SuppliercompanyLookUpEdit.Properties.DataSource = Me.bsSuppliers
        Me.SuppliercompanyLookUpEdit.Properties.DisplayMember = "Suppliercompany"
        Me.SuppliercompanyLookUpEdit.Properties.NullText = ""
        Me.SuppliercompanyLookUpEdit.Properties.ValueMember = "Suppliercompany"
        Me.SuppliercompanyLookUpEdit.Size = New System.Drawing.Size(249, 20)
        Me.SuppliercompanyLookUpEdit.TabIndex = 55
        '
        'ShipstateprovTextEdit
        '
        Me.ShipstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shipstateprov", True))
        Me.ShipstateprovTextEdit.Location = New System.Drawing.Point(231, 200)
        Me.ShipstateprovTextEdit.Name = "ShipstateprovTextEdit"
        Me.ShipstateprovTextEdit.Size = New System.Drawing.Size(24, 20)
        Me.ShipstateprovTextEdit.TabIndex = 45
        '
        'FreightcarrierLookUpEdit
        '
        Me.FreightcarrierLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Freightcarrier", True))
        Me.FreightcarrierLookUpEdit.Location = New System.Drawing.Point(439, 148)
        Me.FreightcarrierLookUpEdit.Name = "FreightcarrierLookUpEdit"
        Me.FreightcarrierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.FreightcarrierLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierID", "Carrier ID", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.FreightcarrierLookUpEdit.Properties.DataSource = Me.bsCarriers
        Me.FreightcarrierLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.FreightcarrierLookUpEdit.Properties.NullText = ""
        Me.FreightcarrierLookUpEdit.Properties.ValueMember = "CarrierName"
        Me.FreightcarrierLookUpEdit.Size = New System.Drawing.Size(251, 20)
        Me.FreightcarrierLookUpEdit.TabIndex = 54
        '
        'ShippostalcodeTextEdit
        '
        Me.ShippostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Shippostalcode", True))
        Me.ShippostalcodeTextEdit.Location = New System.Drawing.Point(261, 200)
        Me.ShippostalcodeTextEdit.Name = "ShippostalcodeTextEdit"
        Me.ShippostalcodeTextEdit.Size = New System.Drawing.Size(83, 20)
        Me.ShippostalcodeTextEdit.TabIndex = 47
        '
        'PlannedshipdateDateEdit
        '
        Me.PlannedshipdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Plannedshipdate", True))
        Me.PlannedshipdateDateEdit.EditValue = Nothing
        Me.PlannedshipdateDateEdit.Location = New System.Drawing.Point(439, 79)
        Me.PlannedshipdateDateEdit.Name = "PlannedshipdateDateEdit"
        Me.PlannedshipdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PlannedshipdateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.PlannedshipdateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.PlannedshipdateDateEdit.TabIndex = 29
        '
        'OrdertermsTextEdit
        '
        Me.OrdertermsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Orderterms", True))
        Me.OrdertermsTextEdit.Location = New System.Drawing.Point(439, 53)
        Me.OrdertermsTextEdit.Name = "OrdertermsTextEdit"
        Me.OrdertermsTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.OrdertermsTextEdit.TabIndex = 28
        '
        'OrderstatusTextEdit
        '
        Me.OrderstatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Orderstatus", True))
        Me.OrderstatusTextEdit.Location = New System.Drawing.Point(595, 26)
        Me.OrderstatusTextEdit.Name = "OrderstatusTextEdit"
        Me.OrderstatusTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.OrderstatusTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.OrderstatusTextEdit.Properties.ReadOnly = True
        Me.OrderstatusTextEdit.Size = New System.Drawing.Size(95, 20)
        Me.OrderstatusTextEdit.TabIndex = 27
        Me.OrderstatusTextEdit.TabStop = False
        '
        'DeliverydateDateEdit
        '
        Me.DeliverydateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Deliverydate", True))
        Me.DeliverydateDateEdit.EditValue = Nothing
        Me.DeliverydateDateEdit.Location = New System.Drawing.Point(439, 105)
        Me.DeliverydateDateEdit.Name = "DeliverydateDateEdit"
        Me.DeliverydateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeliverydateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DeliverydateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.DeliverydateDateEdit.TabIndex = 23
        '
        'eCustomer
        '
        Me.eCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Custid", True))
        Me.eCustomer.Location = New System.Drawing.Point(95, 79)
        Me.eCustomer.Name = "eCustomer"
        Me.eCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "Cust ID", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 250, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eCustomer.Properties.DataSource = Me.bsCustomers
        Me.eCustomer.Properties.DisplayMember = "Custname"
        Me.eCustomer.Properties.NullText = ""
        Me.eCustomer.Properties.ValueMember = "Custid"
        Me.eCustomer.Size = New System.Drawing.Size(194, 20)
        Me.eCustomer.TabIndex = 18
        '
        'CustomerpoTextEdit
        '
        Me.CustomerpoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Customerpo", True))
        Me.CustomerpoTextEdit.Location = New System.Drawing.Point(95, 105)
        Me.CustomerpoTextEdit.Name = "CustomerpoTextEdit"
        Me.CustomerpoTextEdit.Size = New System.Drawing.Size(249, 20)
        Me.CustomerpoTextEdit.TabIndex = 22
        '
        'WorkordernumberTextEdit
        '
        Me.WorkordernumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Workordernumber", True))
        Me.WorkordernumberTextEdit.Location = New System.Drawing.Point(95, 26)
        Me.WorkordernumberTextEdit.Name = "WorkordernumberTextEdit"
        Me.WorkordernumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.WorkordernumberTextEdit.TabIndex = 19
        '
        'CustorderdateDateEdit
        '
        Me.CustorderdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Workorderdate", True))
        Me.CustorderdateDateEdit.EditValue = Nothing
        Me.CustorderdateDateEdit.Location = New System.Drawing.Point(249, 26)
        Me.CustorderdateDateEdit.Name = "CustorderdateDateEdit"
        Me.CustorderdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustorderdateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CustorderdateDateEdit.Size = New System.Drawing.Size(95, 20)
        Me.CustorderdateDateEdit.TabIndex = 21
        '
        'OrdernotesTextEdit
        '
        Me.OrdernotesTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Ordernotes", True))
        Me.OrdernotesTextEdit.Location = New System.Drawing.Point(709, 53)
        Me.OrdernotesTextEdit.Name = "OrdernotesTextEdit"
        Me.OrdernotesTextEdit.Size = New System.Drawing.Size(297, 217)
        Me.OrdernotesTextEdit.TabIndex = 26
        '
        'frmAddEditWorkOrders
        '
        Me.ClientSize = New System.Drawing.Size(1018, 740)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditWorkOrders"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Work Order Information"
        CType(Me.bsWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSuppliers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWorkOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grWorkOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.Shipaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luLogistics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreparedbyLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliercompanyLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FreightcarrierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlannedshipdateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlannedshipdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdertermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderstatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverydateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverydateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustorderdateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdernotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents bsWorkOrder As System.Windows.Forms.BindingSource
    Friend WithEvents bsWorkOrderItems As System.Windows.Forms.BindingSource
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsSuppliers As System.Windows.Forms.BindingSource
    Friend WithEvents bsEmployees As System.Windows.Forms.BindingSource
    Friend WithEvents bsFOB As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grWorkOrderItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWorkorderitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkerordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtycontainers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luProductDesc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colProductid2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luContainer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouselocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents luStdgallons As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents FobLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PreparedbyLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SuppliercompanyLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FreightcarrierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Shipaddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Shipaddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipcountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShippostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PlannedshipdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents OrdertermsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrderstatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliverydateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CustomerpoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkordernumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustorderdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddWOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditWOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteWOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMarkClosed As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAllocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnallocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCustomerNotes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luLogistics As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents rbtnManageInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents OrdernotesTextEdit As DevExpress.XtraEditors.MemoEdit
End Class
