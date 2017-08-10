<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditPO

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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSplitItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAllocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnallocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMiscCharge = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintPurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCOAText = New DevExpress.XtraBars.BarButtonItem()
        Me.btnApproveOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintPurchaseitem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddPOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkPOComplete = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgProcessOrder = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grPurchaseItems = New DevExpress.XtraGrid.GridControl()
        Me.bsPurchaseItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPurchaseItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitorcontainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyordered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerPONum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendoritemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpectedIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateNeeded = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SourceDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colSourcetype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProductDesc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luContainer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luStdgallons = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.VendorLabel = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.YellowColorEdit = New DevExpress.XtraEditors.ColorEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eWorkOrderNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.eGrossWgt = New DevExpress.XtraEditors.TextEdit()
        Me.btnUpdateAll = New DevExpress.XtraEditors.SimpleButton()
        Me.eVendorNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.ePurchaseOrderType = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPurchase = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPurchaseOrderTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.btExpectedIn = New DevExpress.XtraEditors.SimpleButton()
        Me.ExpectedInDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.luCustomer = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.PONumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.btVendorNotes = New DevExpress.XtraEditors.SimpleButton()
        Me.eInstructions = New DevExpress.XtraEditors.MemoEdit()
        Me.eVendor = New DevExpress.XtraEditors.LookUpEdit()
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
        Me.PurchaseNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustorderdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
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
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.YellowColorEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eWorkOrderNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eGrossWgt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendorNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePurchaseOrderType.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseOrderTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedInDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedInDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PONumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInstructions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.PurchaseNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustorderdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustorderdateLabel
        '
        CustorderdateLabel.AutoSize = True
        CustorderdateLabel.Location = New System.Drawing.Point(201, 29)
        CustorderdateLabel.Name = "CustorderdateLabel"
        CustorderdateLabel.Size = New System.Drawing.Size(30, 13)
        CustorderdateLabel.TabIndex = 2
        CustorderdateLabel.Text = "Date"
        '
        'OrderstatusLabel
        '
        OrderstatusLabel.AutoSize = True
        OrderstatusLabel.Location = New System.Drawing.Point(551, 29)
        OrderstatusLabel.Name = "OrderstatusLabel"
        OrderstatusLabel.Size = New System.Drawing.Size(38, 13)
        OrderstatusLabel.TabIndex = 11
        OrderstatusLabel.Text = "Status"
        '
        'OrdertermsLabel
        '
        OrdertermsLabel.AutoSize = True
        OrdertermsLabel.Location = New System.Drawing.Point(397, 81)
        OrdertermsLabel.Name = "OrdertermsLabel"
        OrdertermsLabel.Size = New System.Drawing.Size(36, 13)
        OrdertermsLabel.TabIndex = 16
        OrdertermsLabel.Text = "Terms"
        '
        'ShipcityLabel
        '
        ShipcityLabel.AutoSize = True
        ShipcityLabel.Location = New System.Drawing.Point(7, 104)
        ShipcityLabel.Name = "ShipcityLabel"
        ShipcityLabel.Size = New System.Drawing.Size(56, 13)
        ShipcityLabel.TabIndex = 6
        ShipcityLabel.Text = "City St Zip"
        '
        'ShipcountryLabel
        '
        ShipcountryLabel.AutoSize = True
        ShipcountryLabel.Location = New System.Drawing.Point(7, 27)
        ShipcountryLabel.Name = "ShipcountryLabel"
        ShipcountryLabel.Size = New System.Drawing.Size(52, 13)
        ShipcountryLabel.TabIndex = 0
        ShipcountryLabel.Text = "Company"
        '
        'Shipaddress2Label
        '
        Shipaddress2Label.AutoSize = True
        Shipaddress2Label.Location = New System.Drawing.Point(7, 78)
        Shipaddress2Label.Name = "Shipaddress2Label"
        Shipaddress2Label.Size = New System.Drawing.Size(52, 13)
        Shipaddress2Label.TabIndex = 4
        Shipaddress2Label.Text = "Address2"
        '
        'ShipcontactLabel
        '
        ShipcontactLabel.AutoSize = True
        ShipcontactLabel.Location = New System.Drawing.Point(7, 130)
        ShipcontactLabel.Name = "ShipcontactLabel"
        ShipcontactLabel.Size = New System.Drawing.Size(45, 13)
        ShipcontactLabel.TabIndex = 10
        ShipcontactLabel.Text = "Contact"
        '
        'Shipaddress1Label
        '
        Shipaddress1Label.AutoSize = True
        Shipaddress1Label.Location = New System.Drawing.Point(7, 52)
        Shipaddress1Label.Name = "Shipaddress1Label"
        Shipaddress1Label.Size = New System.Drawing.Size(52, 13)
        Shipaddress1Label.TabIndex = 2
        Shipaddress1Label.Text = "Address1"
        '
        'SuppliercompanyLabel
        '
        SuppliercompanyLabel.AutoSize = True
        SuppliercompanyLabel.Location = New System.Drawing.Point(23, 55)
        SuppliercompanyLabel.Name = "SuppliercompanyLabel"
        SuppliercompanyLabel.Size = New System.Drawing.Size(41, 13)
        SuppliercompanyLabel.TabIndex = 4
        SuppliercompanyLabel.Text = "Vendor"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(385, 29)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 13)
        Label1.TabIndex = 9
        Label1.Text = "PO Type"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(199, 130)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(37, 13)
        Label2.TabIndex = 12
        Label2.Text = "Phone"
        '
        'OrdernotesLabel
        '
        OrdernotesLabel.Location = New System.Drawing.Point(964, 82)
        OrdernotesLabel.Name = "OrdernotesLabel"
        OrdernotesLabel.Size = New System.Drawing.Size(111, 19)
        OrdernotesLabel.TabIndex = 22
        OrdernotesLabel.Text = "Special Instructions"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(721, 29)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(61, 13)
        Label3.TabIndex = 20
        Label3.Text = "PO Number"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(23, 81)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 13)
        Label4.TabIndex = 6
        Label4.Text = "Customer"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(368, 55)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(65, 13)
        Label5.TabIndex = 13
        Label5.Text = "Expected In"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(23, 29)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(72, 13)
        Label6.TabIndex = 0
        Label6.Text = "Vendor Ref #"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(904, 29)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(57, 13)
        Label7.TabIndex = 25
        Label7.Text = "Gross Wgt"
        '
        'Label8
        '
        Label8.Location = New System.Drawing.Point(721, 81)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(115, 19)
        Label8.TabIndex = 27
        Label8.Text = "WorkOrder Notes"
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnSplitItem, Me.btnEditPOItem, Me.btnCancelItem, Me.btnAllocate, Me.btnUnallocate, Me.btnMiscCharge, Me.btnPrintPurchaseOrder, Me.btnCOAText, Me.btnApproveOrder, Me.btnPrintPurchaseitem, Me.btnAddPOItem, Me.rbtnMarkPOComplete, Me.BarButtonItem1})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 17
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1230, 95)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save  Changes"
        Me.btnSave.Id = 0
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Changes"
        Me.btnCancel.Id = 1
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'btnSplitItem
        '
        Me.btnSplitItem.Caption = "Split Item"
        Me.btnSplitItem.Id = 2
        Me.btnSplitItem.LargeGlyph = Global.AOS.My.Resources.Resources.List__2_
        Me.btnSplitItem.Name = "btnSplitItem"
        '
        'btnEditPOItem
        '
        Me.btnEditPOItem.Caption = "Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
        Me.btnEditPOItem.Id = 3
        Me.btnEditPOItem.LargeGlyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditPOItem.Name = "btnEditPOItem"
        '
        'btnCancelItem
        '
        Me.btnCancelItem.Caption = "Remove Item"
        Me.btnCancelItem.Id = 4
        Me.btnCancelItem.LargeGlyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnCancelItem.Name = "btnCancelItem"
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
        Me.btnMiscCharge.Caption = "Misc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
        Me.btnMiscCharge.Id = 8
        Me.btnMiscCharge.LargeGlyph = Global.AOS.My.Resources.Resources.NewDocumentHS
        Me.btnMiscCharge.Name = "btnMiscCharge"
        '
        'btnPrintPurchaseOrder
        '
        Me.btnPrintPurchaseOrder.Caption = "Print PO"
        Me.btnPrintPurchaseOrder.Id = 9
        Me.btnPrintPurchaseOrder.LargeGlyph = Global.AOS.My.Resources.Resources.Printer
        Me.btnPrintPurchaseOrder.Name = "btnPrintPurchaseOrder"
        '
        'btnCOAText
        '
        Me.btnCOAText.Caption = "COA Text"
        Me.btnCOAText.Id = 11
        Me.btnCOAText.LargeGlyph = Global.AOS.My.Resources.Resources.document_edit
        Me.btnCOAText.Name = "btnCOAText"
        '
        'btnApproveOrder
        '
        Me.btnApproveOrder.Caption = "Approve PO"
        Me.btnApproveOrder.Enabled = False
        Me.btnApproveOrder.Id = 12
        Me.btnApproveOrder.LargeGlyph = Global.AOS.My.Resources.Resources.Change
        Me.btnApproveOrder.Name = "btnApproveOrder"
        '
        'btnPrintPurchaseitem
        '
        Me.btnPrintPurchaseitem.Caption = "Print Item List"
        Me.btnPrintPurchaseitem.Id = 13
        Me.btnPrintPurchaseitem.LargeGlyph = Global.AOS.My.Resources.Resources.proforma_print
        Me.btnPrintPurchaseitem.Name = "btnPrintPurchaseitem"
        '
        'btnAddPOItem
        '
        Me.btnAddPOItem.Caption = " Add  Item"
        Me.btnAddPOItem.Id = 14
        Me.btnAddPOItem.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddPOItem.Name = "btnAddPOItem"
        '
        'rbtnMarkPOComplete
        '
        Me.rbtnMarkPOComplete.Caption = "Mark Purchase Complete"
        Me.rbtnMarkPOComplete.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnMarkPOComplete.Id = 15
        Me.rbtnMarkPOComplete.LargeGlyph = Global.AOS.My.Resources.Resources.document_accept__2_
        Me.rbtnMarkPOComplete.Name = "rbtnMarkPOComplete"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.rpgProcessOrder})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnApproveOrder, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnPrintPurchaseOrder, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnPrintPurchaseitem)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Purchase Order"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddPOItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditPOItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancelItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSplitItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnMiscCharge, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Purchase Items"
        '
        'rpgProcessOrder
        '
        Me.rpgProcessOrder.AllowMinimize = False
        Me.rpgProcessOrder.AllowTextClipping = False
        Me.rpgProcessOrder.ItemLinks.Add(Me.rbtnMarkPOComplete)
        Me.rpgProcessOrder.Name = "rpgProcessOrder"
        Me.rpgProcessOrder.ShowCaptionButton = False
        Me.rpgProcessOrder.Text = "Process Order"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1230, 614)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grPurchaseItems)
        Me.GroupControl4.Controls.Add(Me.PanelControl3)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 266)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1230, 348)
        Me.GroupControl4.TabIndex = 6
        Me.GroupControl4.Text = "Purchase Items"
        '
        'grPurchaseItems
        '
        Me.grPurchaseItems.DataSource = Me.bsPurchaseItems
        Me.grPurchaseItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPurchaseItems.Location = New System.Drawing.Point(2, 51)
        Me.grPurchaseItems.MainView = Me.grvPurchaseItems
        Me.grPurchaseItems.Name = "grPurchaseItems"
        Me.grPurchaseItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemHyperLinkEdit1})
        Me.grPurchaseItems.Size = New System.Drawing.Size(1226, 295)
        Me.grPurchaseItems.TabIndex = 0
        Me.grPurchaseItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPurchaseItems})
        '
        'bsPurchaseItems
        '
        Me.bsPurchaseItems.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseItemsListCollection)
        '
        'grvPurchaseItems
        '
        Me.grvPurchaseItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colUom, Me.colUnits, Me.colUnitorcontainer, Me.colQtyordered, Me.colCustomerPONum, Me.colVendoritemnumber, Me.colExpectedIn, Me.colDateNeeded, Me.colUnitcost, Me.colExtcost, Me.SourceDoc, Me.colSourcetype})
        Me.grvPurchaseItems.GridControl = Me.grPurchaseItems
        Me.grvPurchaseItems.Name = "grvPurchaseItems"
        Me.grvPurchaseItems.OptionsBehavior.Editable = False
        Me.grvPurchaseItems.OptionsView.ShowFooter = True
        Me.grvPurchaseItems.OptionsView.ShowGroupPanel = False
        Me.grvPurchaseItems.OptionsView.ShowIndicator = False
        '
        'colProductid
        '
        Me.colProductid.Caption = "Item ID"
        Me.colProductid.FieldName = "Itemid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.FixedWidth = True
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 2
        Me.colProductid.Width = 46
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Item Description"
        Me.colProductdesc.FieldName = "Itemdescription"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 3
        Me.colProductdesc.Width = 354
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.OptionsColumn.FixedWidth = True
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 4
        Me.colContainer.Width = 77
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.OptionsColumn.FixedWidth = True
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 5
        Me.colUom.Width = 35
        '
        'colUnits
        '
        Me.colUnits.Caption = "Units"
        Me.colUnits.DisplayFormat.FormatString = "n2"
        Me.colUnits.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnits.FieldName = "Unitsincontainer"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.OptionsColumn.FixedWidth = True
        Me.colUnits.Visible = True
        Me.colUnits.VisibleIndex = 6
        Me.colUnits.Width = 67
        '
        'colUnitorcontainer
        '
        Me.colUnitorcontainer.Caption = "U/C"
        Me.colUnitorcontainer.FieldName = "Unitorcontainer"
        Me.colUnitorcontainer.Name = "colUnitorcontainer"
        Me.colUnitorcontainer.OptionsColumn.FixedWidth = True
        Me.colUnitorcontainer.Visible = True
        Me.colUnitorcontainer.VisibleIndex = 1
        Me.colUnitorcontainer.Width = 30
        '
        'colQtyordered
        '
        Me.colQtyordered.Caption = "Qty"
        Me.colQtyordered.FieldName = "Qty"
        Me.colQtyordered.Name = "colQtyordered"
        Me.colQtyordered.OptionsColumn.FixedWidth = True
        Me.colQtyordered.Visible = True
        Me.colQtyordered.VisibleIndex = 0
        Me.colQtyordered.Width = 56
        '
        'colCustomerPONum
        '
        Me.colCustomerPONum.Caption = "Cust PO"
        Me.colCustomerPONum.FieldName = "Customerpo"
        Me.colCustomerPONum.Name = "colCustomerPONum"
        Me.colCustomerPONum.OptionsColumn.FixedWidth = True
        Me.colCustomerPONum.Visible = True
        Me.colCustomerPONum.VisibleIndex = 11
        '
        'colVendoritemnumber
        '
        Me.colVendoritemnumber.Caption = "Vend Item #"
        Me.colVendoritemnumber.FieldName = "Vendoritemnumber"
        Me.colVendoritemnumber.Name = "colVendoritemnumber"
        Me.colVendoritemnumber.OptionsColumn.FixedWidth = True
        Me.colVendoritemnumber.Visible = True
        Me.colVendoritemnumber.VisibleIndex = 12
        Me.colVendoritemnumber.Width = 80
        '
        'colExpectedIn
        '
        Me.colExpectedIn.Caption = "Expected In"
        Me.colExpectedIn.DisplayFormat.FormatString = "d"
        Me.colExpectedIn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colExpectedIn.FieldName = "Expectedindate"
        Me.colExpectedIn.Name = "colExpectedIn"
        Me.colExpectedIn.OptionsColumn.FixedWidth = True
        Me.colExpectedIn.Visible = True
        Me.colExpectedIn.VisibleIndex = 8
        Me.colExpectedIn.Width = 68
        '
        'colDateNeeded
        '
        Me.colDateNeeded.Caption = "Date Needed"
        Me.colDateNeeded.DisplayFormat.FormatString = "d"
        Me.colDateNeeded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDateNeeded.FieldName = "Dateneeded"
        Me.colDateNeeded.Name = "colDateNeeded"
        Me.colDateNeeded.OptionsColumn.FixedWidth = True
        Me.colDateNeeded.Visible = True
        Me.colDateNeeded.VisibleIndex = 7
        Me.colDateNeeded.Width = 73
        '
        'colUnitcost
        '
        Me.colUnitcost.Caption = "Unit Cost"
        Me.colUnitcost.DisplayFormat.FormatString = "c4"
        Me.colUnitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitcost.FieldName = "Unitcost"
        Me.colUnitcost.Name = "colUnitcost"
        Me.colUnitcost.OptionsColumn.FixedWidth = True
        Me.colUnitcost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom, "Unitcost", "Total:")})
        Me.colUnitcost.Visible = True
        Me.colUnitcost.VisibleIndex = 13
        Me.colUnitcost.Width = 70
        '
        'colExtcost
        '
        Me.colExtcost.Caption = "Ext Cost"
        Me.colExtcost.DisplayFormat.FormatString = "c2"
        Me.colExtcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExtcost.FieldName = "Extcost"
        Me.colExtcost.GroupFormat.FormatString = "c2"
        Me.colExtcost.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExtcost.Name = "colExtcost"
        Me.colExtcost.OptionsColumn.FixedWidth = True
        Me.colExtcost.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Extcost", "{0:c2}")})
        Me.colExtcost.Visible = True
        Me.colExtcost.VisibleIndex = 14
        Me.colExtcost.Width = 70
        '
        'SourceDoc
        '
        Me.SourceDoc.Caption = "Doc#"
        Me.SourceDoc.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.SourceDoc.FieldName = "Sourcedocument"
        Me.SourceDoc.Name = "SourceDoc"
        Me.SourceDoc.Visible = True
        Me.SourceDoc.VisibleIndex = 10
        Me.SourceDoc.Width = 51
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'colSourcetype
        '
        Me.colSourcetype.Caption = "Src Type"
        Me.colSourcetype.FieldName = "Sourcetype"
        Me.colSourcetype.Name = "colSourcetype"
        Me.colSourcetype.Visible = True
        Me.colSourcetype.VisibleIndex = 9
        Me.colSourcetype.Width = 69
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
        Me.RepositoryItemCheckEdit1.Caption = "Check"
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
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.VendorLabel)
        Me.PanelControl3.Controls.Add(Me.LabelControl1)
        Me.PanelControl3.Controls.Add(Me.YellowColorEdit)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl3.Location = New System.Drawing.Point(2, 22)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1226, 29)
        Me.PanelControl3.TabIndex = 0
        '
        'VendorLabel
        '
        Me.VendorLabel.Location = New System.Drawing.Point(139, 6)
        Me.VendorLabel.Name = "VendorLabel"
        Me.VendorLabel.Size = New System.Drawing.Size(161, 13)
        Me.VendorLabel.TabIndex = 2
        Me.VendorLabel.Text = "Expected In is after Date Needed"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(23, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Color Mapping:"
        '
        'YellowColorEdit
        '
        Me.YellowColorEdit.EditValue = System.Drawing.Color.Pink
        Me.YellowColorEdit.Location = New System.Drawing.Point(105, 4)
        Me.YellowColorEdit.MenuManager = Me.RibbonControl1
        Me.YellowColorEdit.Name = "YellowColorEdit"
        Me.YellowColorEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.YellowColorEdit.Properties.Appearance.Options.UseBackColor = True
        Me.YellowColorEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.YellowColorEdit.Properties.ReadOnly = True
        Me.YellowColorEdit.Size = New System.Drawing.Size(28, 18)
        Me.YellowColorEdit.TabIndex = 1
        Me.YellowColorEdit.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1230, 266)
        Me.PanelControl2.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.eWorkOrderNotes)
        Me.GroupControl1.Controls.Add(Label8)
        Me.GroupControl1.Controls.Add(Label7)
        Me.GroupControl1.Controls.Add(Me.eGrossWgt)
        Me.GroupControl1.Controls.Add(Me.btnUpdateAll)
        Me.GroupControl1.Controls.Add(Me.eVendorNotes)
        Me.GroupControl1.Controls.Add(Me.ePurchaseOrderType)
        Me.GroupControl1.Controls.Add(Label6)
        Me.GroupControl1.Controls.Add(Me.btExpectedIn)
        Me.GroupControl1.Controls.Add(Me.ExpectedInDateDateEdit)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Me.luCustomer)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Me.PONumberTextEdit)
        Me.GroupControl1.Controls.Add(Me.btVendorNotes)
        Me.GroupControl1.Controls.Add(Me.eInstructions)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(SuppliercompanyLabel)
        Me.GroupControl1.Controls.Add(Me.eVendor)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(OrdertermsLabel)
        Me.GroupControl1.Controls.Add(Me.OrdertermsTextEdit)
        Me.GroupControl1.Controls.Add(OrderstatusLabel)
        Me.GroupControl1.Controls.Add(Me.ePOStatus)
        Me.GroupControl1.Controls.Add(OrdernotesLabel)
        Me.GroupControl1.Controls.Add(CustorderdateLabel)
        Me.GroupControl1.Controls.Add(Me.PurchaseNumberTextEdit)
        Me.GroupControl1.Controls.Add(Me.CustorderdateDateEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1230, 266)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Purchase Order Information"
        '
        'eWorkOrderNotes
        '
        Me.eWorkOrderNotes.Location = New System.Drawing.Point(724, 103)
        Me.eWorkOrderNotes.Name = "eWorkOrderNotes"
        Me.eWorkOrderNotes.Properties.Appearance.Options.UseTextOptions = True
        Me.eWorkOrderNotes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eWorkOrderNotes.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.eWorkOrderNotes.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.eWorkOrderNotes.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.eWorkOrderNotes.Properties.ReadOnly = True
        Me.eWorkOrderNotes.Size = New System.Drawing.Size(226, 155)
        Me.eWorkOrderNotes.TabIndex = 28
        '
        'eGrossWgt
        '
        Me.eGrossWgt.Location = New System.Drawing.Point(967, 26)
        Me.eGrossWgt.Name = "eGrossWgt"
        Me.eGrossWgt.Properties.Appearance.Options.UseTextOptions = True
        Me.eGrossWgt.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eGrossWgt.Properties.DisplayFormat.FormatString = "n2"
        Me.eGrossWgt.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eGrossWgt.Properties.ReadOnly = True
        Me.eGrossWgt.Size = New System.Drawing.Size(82, 20)
        Me.eGrossWgt.TabIndex = 26
        '
        'btnUpdateAll
        '
        Me.btnUpdateAll.Location = New System.Drawing.Point(639, 51)
        Me.btnUpdateAll.Name = "btnUpdateAll"
        Me.btnUpdateAll.Size = New System.Drawing.Size(62, 23)
        Me.btnUpdateAll.TabIndex = 24
        Me.btnUpdateAll.Text = "Update All"
        '
        'eVendorNotes
        '
        Me.eVendorNotes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendornotes", True))
        Me.eVendorNotes.Location = New System.Drawing.Point(439, 104)
        Me.eVendorNotes.Name = "eVendorNotes"
        Me.eVendorNotes.Properties.Appearance.Options.UseTextOptions = True
        Me.eVendorNotes.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eVendorNotes.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.eVendorNotes.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.eVendorNotes.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.eVendorNotes.Properties.ReadOnly = True
        Me.eVendorNotes.Size = New System.Drawing.Size(262, 154)
        Me.eVendorNotes.TabIndex = 19
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'ePurchaseOrderType
        '
        Me.ePurchaseOrderType.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Purchasetype", True))
        Me.ePurchaseOrderType.Location = New System.Drawing.Point(439, 26)
        Me.ePurchaseOrderType.Name = "ePurchaseOrderType"
        Me.ePurchaseOrderType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ePurchaseOrderType.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Purchaseordertype", "Purchase Order Type", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ePurchaseOrderType.Properties.DataSource = Me.bsPurchaseOrderTypes
        Me.ePurchaseOrderType.Properties.DisplayMember = "Purchaseordertype"
        Me.ePurchaseOrderType.Properties.DropDownRows = 3
        Me.ePurchaseOrderType.Properties.NullText = ""
        Me.ePurchaseOrderType.Properties.PopupWidth = 200
        Me.ePurchaseOrderType.Properties.ReadOnly = True
        Me.ePurchaseOrderType.Properties.ValueMember = "Purchaseordertype"
        Me.ePurchaseOrderType.Size = New System.Drawing.Size(106, 20)
        Me.ePurchaseOrderType.TabIndex = 10
        '
        'bsPurchase
        '
        Me.bsPurchase.DataSource = GetType(AOS.BusinessObjects.Purchase)
        '
        'btExpectedIn
        '
        Me.btExpectedIn.Location = New System.Drawing.Point(551, 51)
        Me.btExpectedIn.Name = "btExpectedIn"
        Me.btExpectedIn.Size = New System.Drawing.Size(86, 23)
        Me.btExpectedIn.TabIndex = 15
        Me.btExpectedIn.Text = "Update Missing"
        '
        'ExpectedInDateDateEdit
        '
        Me.ExpectedInDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Expectedindate", True))
        Me.ExpectedInDateDateEdit.EditValue = Nothing
        Me.ExpectedInDateDateEdit.Location = New System.Drawing.Point(439, 52)
        Me.ExpectedInDateDateEdit.Name = "ExpectedInDateDateEdit"
        Me.ExpectedInDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExpectedInDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ExpectedInDateDateEdit.Size = New System.Drawing.Size(106, 20)
        Me.ExpectedInDateDateEdit.TabIndex = 14
        '
        'luCustomer
        '
        Me.luCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Custid", True))
        Me.luCustomer.Location = New System.Drawing.Point(95, 78)
        Me.luCustomer.Name = "luCustomer"
        Me.luCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luCustomer.Properties.DataSource = Me.bsCustomers
        Me.luCustomer.Properties.DisplayMember = "Custname"
        Me.luCustomer.Properties.DropDownRows = 20
        Me.luCustomer.Properties.NullText = ""
        Me.luCustomer.Properties.PopupWidth = 350
        Me.luCustomer.Properties.ReadOnly = True
        Me.luCustomer.Properties.ShowFooter = False
        Me.luCustomer.Properties.ValueMember = "Custid"
        Me.luCustomer.Size = New System.Drawing.Size(249, 20)
        Me.luCustomer.TabIndex = 7
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'PONumberTextEdit
        '
        Me.PONumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Customerpo", True))
        Me.PONumberTextEdit.Location = New System.Drawing.Point(95, 26)
        Me.PONumberTextEdit.Name = "PONumberTextEdit"
        Me.PONumberTextEdit.Size = New System.Drawing.Size(95, 20)
        Me.PONumberTextEdit.TabIndex = 1
        '
        'btVendorNotes
        '
        Me.btVendorNotes.Appearance.Options.UseTextOptions = True
        Me.btVendorNotes.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.btVendorNotes.Location = New System.Drawing.Point(367, 104)
        Me.btVendorNotes.Name = "btVendorNotes"
        Me.btVendorNotes.Size = New System.Drawing.Size(66, 44)
        Me.btVendorNotes.TabIndex = 18
        Me.btVendorNotes.Text = "Vendor Notes"
        '
        'eInstructions
        '
        Me.eInstructions.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Instructions", True))
        Me.eInstructions.Location = New System.Drawing.Point(967, 104)
        Me.eInstructions.Name = "eInstructions"
        Me.eInstructions.Properties.Appearance.Options.UseTextOptions = True
        Me.eInstructions.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eInstructions.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.eInstructions.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.eInstructions.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.eInstructions.Size = New System.Drawing.Size(251, 154)
        Me.eInstructions.TabIndex = 23
        '
        'eVendor
        '
        Me.eVendor.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Vendorid", True))
        Me.eVendor.Location = New System.Drawing.Point(95, 52)
        Me.eVendor.Name = "eVendor"
        Me.eVendor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eVendor.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorname", "Vendor Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eVendor.Properties.DataSource = Me.bsVendors
        Me.eVendor.Properties.DisplayMember = "Vendorname"
        Me.eVendor.Properties.DropDownRows = 20
        Me.eVendor.Properties.NullText = ""
        Me.eVendor.Properties.PopupWidth = 200
        Me.eVendor.Properties.ReadOnly = True
        Me.eVendor.Properties.ValueMember = "Vendorid"
        Me.eVendor.Size = New System.Drawing.Size(249, 20)
        Me.eVendor.TabIndex = 5
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
        Me.GroupControl3.Location = New System.Drawing.Point(23, 104)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(321, 154)
        Me.GroupControl3.TabIndex = 8
        Me.GroupControl3.Text = "Shipping Address"
        '
        'ePhone
        '
        Me.ePhone.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Shipphone", True))
        Me.ePhone.Location = New System.Drawing.Point(234, 127)
        Me.ePhone.Name = "ePhone"
        Me.ePhone.Size = New System.Drawing.Size(75, 20)
        Me.ePhone.TabIndex = 13
        '
        'eAddress1
        '
        Me.eAddress1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Shipaddress1", True))
        Me.eAddress1.Location = New System.Drawing.Point(80, 49)
        Me.eAddress1.Name = "eAddress1"
        Me.eAddress1.Size = New System.Drawing.Size(229, 20)
        Me.eAddress1.TabIndex = 3
        '
        'eAddress2
        '
        Me.eAddress2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Shipaddress2", True))
        Me.eAddress2.Location = New System.Drawing.Point(80, 75)
        Me.eAddress2.Name = "eAddress2"
        Me.eAddress2.Size = New System.Drawing.Size(229, 20)
        Me.eAddress2.TabIndex = 5
        '
        'eContact
        '
        Me.eContact.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Shipcontact", True))
        Me.eContact.Location = New System.Drawing.Point(80, 127)
        Me.eContact.Name = "eContact"
        Me.eContact.Size = New System.Drawing.Size(113, 20)
        Me.eContact.TabIndex = 11
        '
        'eCity
        '
        Me.eCity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Shipcity", True))
        Me.eCity.Location = New System.Drawing.Point(80, 101)
        Me.eCity.Name = "eCity"
        Me.eCity.Size = New System.Drawing.Size(113, 20)
        Me.eCity.TabIndex = 7
        '
        'eState
        '
        Me.eState.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Shipstate", True))
        Me.eState.Location = New System.Drawing.Point(204, 101)
        Me.eState.Name = "eState"
        Me.eState.Size = New System.Drawing.Size(24, 20)
        Me.eState.TabIndex = 8
        '
        'eCompany
        '
        Me.eCompany.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Shipname", True))
        Me.eCompany.Location = New System.Drawing.Point(80, 24)
        Me.eCompany.Name = "eCompany"
        Me.eCompany.Properties.ReadOnly = True
        Me.eCompany.Size = New System.Drawing.Size(229, 20)
        Me.eCompany.TabIndex = 1
        '
        'eZip
        '
        Me.eZip.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Shipzip", True))
        Me.eZip.Location = New System.Drawing.Point(234, 101)
        Me.eZip.Name = "eZip"
        Me.eZip.Size = New System.Drawing.Size(75, 20)
        Me.eZip.TabIndex = 9
        '
        'OrdertermsTextEdit
        '
        Me.OrdertermsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Terms", True))
        Me.OrdertermsTextEdit.Location = New System.Drawing.Point(439, 78)
        Me.OrdertermsTextEdit.Name = "OrdertermsTextEdit"
        Me.OrdertermsTextEdit.Properties.MaxLength = 50
        Me.OrdertermsTextEdit.Size = New System.Drawing.Size(106, 20)
        Me.OrdertermsTextEdit.TabIndex = 17
        '
        'ePOStatus
        '
        Me.ePOStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Purchasestatus", True))
        Me.ePOStatus.Location = New System.Drawing.Point(595, 26)
        Me.ePOStatus.Name = "ePOStatus"
        Me.ePOStatus.Properties.ReadOnly = True
        Me.ePOStatus.Size = New System.Drawing.Size(106, 20)
        Me.ePOStatus.TabIndex = 12
        '
        'PurchaseNumberTextEdit
        '
        Me.PurchaseNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Purchasenumber", True))
        Me.PurchaseNumberTextEdit.Location = New System.Drawing.Point(799, 26)
        Me.PurchaseNumberTextEdit.Name = "PurchaseNumberTextEdit"
        Me.PurchaseNumberTextEdit.Properties.ReadOnly = True
        Me.PurchaseNumberTextEdit.Size = New System.Drawing.Size(95, 20)
        Me.PurchaseNumberTextEdit.TabIndex = 21
        Me.PurchaseNumberTextEdit.TabStop = False
        '
        'CustorderdateDateEdit
        '
        Me.CustorderdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Purchasedate", True))
        Me.CustorderdateDateEdit.EditValue = Nothing
        Me.CustorderdateDateEdit.Location = New System.Drawing.Point(249, 26)
        Me.CustorderdateDateEdit.Name = "CustorderdateDateEdit"
        Me.CustorderdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustorderdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.CustorderdateDateEdit.Properties.ReadOnly = True
        Me.CustorderdateDateEdit.Size = New System.Drawing.Size(95, 20)
        Me.CustorderdateDateEdit.TabIndex = 3
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.Id = 16
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'frmAddEditPO
        '
        Me.ClientSize = New System.Drawing.Size(1230, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAddEditPO"
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
        CType(Me.grPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.YellowColorEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eWorkOrderNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eGrossWgt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendorNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePurchaseOrderType.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseOrderTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedInDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedInDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PONumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInstructions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PurchaseNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustorderdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grPurchaseItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPurchaseItems As CustomDevExGridView
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
    Friend WithEvents PurchaseNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustorderdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSplitItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAllocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnallocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ePhone As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsPurchase As System.Windows.Forms.BindingSource
    Friend WithEvents bsPurchaseItems As System.Windows.Forms.BindingSource
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
    Friend WithEvents eInstructions As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btVendorNotes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PONumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents colDateNeeded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCOAText As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnApproveOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintPurchaseitem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ExpectedInDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btExpectedIn As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colExpectedIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents VendorLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents YellowColorEdit As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents ePurchaseOrderType As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsPurchaseOrderTypes As System.Windows.Forms.BindingSource
    Friend WithEvents btnAddPOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eVendorNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents colCustomerPONum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnUpdateAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eGrossWgt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnMarkPOComplete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgProcessOrder As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SourceDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourcetype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eWorkOrderNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
