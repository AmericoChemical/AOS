<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewInvoiceHistory

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
        Dim CustidLabel As System.Windows.Forms.Label
        Dim WorkordernumberLabel As System.Windows.Forms.Label
        Dim CustorderdateLabel As System.Windows.Forms.Label
        Dim CustomerpoLabel As System.Windows.Forms.Label
        Dim DeliverydateLabel As System.Windows.Forms.Label
        Dim FreightcarrierLabel As System.Windows.Forms.Label
        Dim OrdernotesLabel As System.Windows.Forms.Label
        Dim OrderstatusLabel As System.Windows.Forms.Label
        Dim OrdertermsLabel As System.Windows.Forms.Label
        Dim Billaddress1Label As System.Windows.Forms.Label
        Dim Billaddress2Label As System.Windows.Forms.Label
        Dim BillcityLabel As System.Windows.Forms.Label
        Dim BillcountryLabel As System.Windows.Forms.Label
        Dim Shipaddress1Label As System.Windows.Forms.Label
        Dim Shipaddress2Label As System.Windows.Forms.Label
        Dim ShipcityLabel As System.Windows.Forms.Label
        Dim ShipcountryLabel As System.Windows.Forms.Label
        Dim ShipcontactLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim FobLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewInvoiceHistory))
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grpInvoice = New DevExpress.XtraEditors.GroupControl()
        Me.FobLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsInvoiceHistory = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsFOB = New System.Windows.Forms.BindingSource(Me.components)
        Me.FreightcarrierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.Shipaddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Shipaddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipcountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShippostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.Billaddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Billaddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillpostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillcountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eInvoiceTerms = New DevExpress.XtraEditors.TextEdit()
        Me.eInvoiceStatus = New DevExpress.XtraEditors.TextEdit()
        Me.OrdernotesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DeliverydateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CustidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerpoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eInvoiceNumber = New DevExpress.XtraEditors.TextEdit()
        Me.eInvoiceDate = New DevExpress.XtraEditors.DateEdit()
        Me.bsSales = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsInvoiceHistoryItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grInvoiceHistoryItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemdescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPricemethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriceuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriceunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMiscCharge = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintInvoiceHistorical = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.eTotal = New DevExpress.XtraEditors.TextEdit()
        Me.eSalesTax = New DevExpress.XtraEditors.TextEdit()
        Me.eSubtotal = New DevExpress.XtraEditors.TextEdit()
        Me.rbtnPrintInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.rpgInvoiceItems = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        CustidLabel = New System.Windows.Forms.Label()
        WorkordernumberLabel = New System.Windows.Forms.Label()
        CustorderdateLabel = New System.Windows.Forms.Label()
        CustomerpoLabel = New System.Windows.Forms.Label()
        DeliverydateLabel = New System.Windows.Forms.Label()
        FreightcarrierLabel = New System.Windows.Forms.Label()
        OrdernotesLabel = New System.Windows.Forms.Label()
        OrderstatusLabel = New System.Windows.Forms.Label()
        OrdertermsLabel = New System.Windows.Forms.Label()
        Billaddress1Label = New System.Windows.Forms.Label()
        Billaddress2Label = New System.Windows.Forms.Label()
        BillcityLabel = New System.Windows.Forms.Label()
        BillcountryLabel = New System.Windows.Forms.Label()
        Shipaddress1Label = New System.Windows.Forms.Label()
        Shipaddress2Label = New System.Windows.Forms.Label()
        ShipcityLabel = New System.Windows.Forms.Label()
        ShipcountryLabel = New System.Windows.Forms.Label()
        ShipcontactLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        FobLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grpInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInvoice.SuspendLayout()
        CType(Me.FobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvoiceHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FreightcarrierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.Shipaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.Billaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Billaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillpostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoiceTerms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoiceStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdernotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverydateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverydateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvoiceHistoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grInvoiceHistoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.eTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSalesTax.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSubtotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(23, 55)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(59, 14)
        CustidLabel.TabIndex = 17
        CustidLabel.Text = "Customer"
        '
        'WorkordernumberLabel
        '
        WorkordernumberLabel.AutoSize = True
        WorkordernumberLabel.Location = New System.Drawing.Point(23, 29)
        WorkordernumberLabel.Name = "WorkordernumberLabel"
        WorkordernumberLabel.Size = New System.Drawing.Size(59, 14)
        WorkordernumberLabel.TabIndex = 18
        WorkordernumberLabel.Text = "Invoice #"
        '
        'CustorderdateLabel
        '
        CustorderdateLabel.AutoSize = True
        CustorderdateLabel.Location = New System.Drawing.Point(201, 29)
        CustorderdateLabel.Name = "CustorderdateLabel"
        CustorderdateLabel.Size = New System.Drawing.Size(33, 14)
        CustorderdateLabel.TabIndex = 20
        CustorderdateLabel.Text = "Date"
        '
        'CustomerpoLabel
        '
        CustomerpoLabel.AutoSize = True
        CustomerpoLabel.Location = New System.Drawing.Point(23, 82)
        CustomerpoLabel.Name = "CustomerpoLabel"
        CustomerpoLabel.Size = New System.Drawing.Size(51, 14)
        CustomerpoLabel.TabIndex = 21
        CustomerpoLabel.Text = "Cust PO"
        '
        'DeliverydateLabel
        '
        DeliverydateLabel.AutoSize = True
        DeliverydateLabel.Location = New System.Drawing.Point(366, 82)
        DeliverydateLabel.Name = "DeliverydateLabel"
        DeliverydateLabel.Size = New System.Drawing.Size(79, 14)
        DeliverydateLabel.TabIndex = 22
        DeliverydateLabel.Text = "Delivery Date"
        '
        'FreightcarrierLabel
        '
        FreightcarrierLabel.AutoSize = True
        FreightcarrierLabel.Location = New System.Drawing.Point(366, 55)
        FreightcarrierLabel.Name = "FreightcarrierLabel"
        FreightcarrierLabel.Size = New System.Drawing.Size(41, 14)
        FreightcarrierLabel.TabIndex = 24
        FreightcarrierLabel.Text = "Carrier"
        '
        'OrdernotesLabel
        '
        OrdernotesLabel.Location = New System.Drawing.Point(23, 265)
        OrdernotesLabel.Name = "OrdernotesLabel"
        OrdernotesLabel.Size = New System.Drawing.Size(67, 31)
        OrdernotesLabel.TabIndex = 25
        OrdernotesLabel.Text = "Special Instructions"
        '
        'OrderstatusLabel
        '
        OrderstatusLabel.AutoSize = True
        OrderstatusLabel.Location = New System.Drawing.Point(551, 29)
        OrderstatusLabel.Name = "OrderstatusLabel"
        OrderstatusLabel.Size = New System.Drawing.Size(42, 14)
        OrderstatusLabel.TabIndex = 26
        OrderstatusLabel.Text = "Status"
        '
        'OrdertermsLabel
        '
        OrdertermsLabel.AutoSize = True
        OrdertermsLabel.Location = New System.Drawing.Point(201, 82)
        OrdertermsLabel.Name = "OrdertermsLabel"
        OrdertermsLabel.Size = New System.Drawing.Size(41, 14)
        OrdertermsLabel.TabIndex = 27
        OrdertermsLabel.Text = "Terms"
        '
        'Billaddress1Label
        '
        Billaddress1Label.AutoSize = True
        Billaddress1Label.Location = New System.Drawing.Point(7, 26)
        Billaddress1Label.Name = "Billaddress1Label"
        Billaddress1Label.Size = New System.Drawing.Size(57, 14)
        Billaddress1Label.TabIndex = 29
        Billaddress1Label.Text = "Address1"
        '
        'Billaddress2Label
        '
        Billaddress2Label.AutoSize = True
        Billaddress2Label.Location = New System.Drawing.Point(7, 52)
        Billaddress2Label.Name = "Billaddress2Label"
        Billaddress2Label.Size = New System.Drawing.Size(57, 14)
        Billaddress2Label.TabIndex = 30
        Billaddress2Label.Text = "Address2"
        '
        'BillcityLabel
        '
        BillcityLabel.AutoSize = True
        BillcityLabel.Location = New System.Drawing.Point(7, 78)
        BillcityLabel.Name = "BillcityLabel"
        BillcityLabel.Size = New System.Drawing.Size(63, 14)
        BillcityLabel.TabIndex = 31
        BillcityLabel.Text = "City St Zip"
        '
        'BillcountryLabel
        '
        BillcountryLabel.AutoSize = True
        BillcountryLabel.Location = New System.Drawing.Point(7, 104)
        BillcountryLabel.Name = "BillcountryLabel"
        BillcountryLabel.Size = New System.Drawing.Size(50, 14)
        BillcountryLabel.TabIndex = 34
        BillcountryLabel.Text = "Country"
        '
        'Shipaddress1Label
        '
        Shipaddress1Label.AutoSize = True
        Shipaddress1Label.Location = New System.Drawing.Point(7, 26)
        Shipaddress1Label.Name = "Shipaddress1Label"
        Shipaddress1Label.Size = New System.Drawing.Size(57, 14)
        Shipaddress1Label.TabIndex = 38
        Shipaddress1Label.Text = "Address1"
        '
        'Shipaddress2Label
        '
        Shipaddress2Label.AutoSize = True
        Shipaddress2Label.Location = New System.Drawing.Point(7, 52)
        Shipaddress2Label.Name = "Shipaddress2Label"
        Shipaddress2Label.Size = New System.Drawing.Size(57, 14)
        Shipaddress2Label.TabIndex = 40
        Shipaddress2Label.Text = "Address2"
        '
        'ShipcityLabel
        '
        ShipcityLabel.AutoSize = True
        ShipcityLabel.Location = New System.Drawing.Point(7, 78)
        ShipcityLabel.Name = "ShipcityLabel"
        ShipcityLabel.Size = New System.Drawing.Size(63, 14)
        ShipcityLabel.TabIndex = 42
        ShipcityLabel.Text = "City St Zip"
        '
        'ShipcountryLabel
        '
        ShipcountryLabel.AutoSize = True
        ShipcountryLabel.Location = New System.Drawing.Point(7, 104)
        ShipcountryLabel.Name = "ShipcountryLabel"
        ShipcountryLabel.Size = New System.Drawing.Size(50, 14)
        ShipcountryLabel.TabIndex = 48
        ShipcountryLabel.Text = "Country"
        '
        'ShipcontactLabel
        '
        ShipcontactLabel.AutoSize = True
        ShipcontactLabel.Location = New System.Drawing.Point(7, 130)
        ShipcontactLabel.Name = "ShipcontactLabel"
        ShipcontactLabel.Size = New System.Drawing.Size(50, 14)
        ShipcontactLabel.TabIndex = 50
        ShipcontactLabel.Text = "Contact"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(7, 130)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(50, 14)
        Label3.TabIndex = 38
        Label3.Text = "Contact"
        '
        'FobLabel
        '
        FobLabel.AutoSize = True
        FobLabel.Location = New System.Drawing.Point(551, 82)
        FobLabel.Name = "FobLabel"
        FobLabel.Size = New System.Drawing.Size(29, 14)
        FobLabel.TabIndex = 56
        FobLabel.Text = "FOB"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(313, 13)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(56, 14)
        Label1.TabIndex = 28
        Label1.Text = "SubTotal"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(458, 13)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(58, 14)
        Label2.TabIndex = 30
        Label2.Text = "Sales Tax"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(603, 13)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(35, 14)
        Label4.TabIndex = 32
        Label4.Text = "Total"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.grpInvoice)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 142)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl2.Size = New System.Drawing.Size(726, 315)
        Me.PanelControl2.TabIndex = 1
        '
        'grpInvoice
        '
        Me.grpInvoice.Controls.Add(FobLabel)
        Me.grpInvoice.Controls.Add(Me.FobLookUpEdit)
        Me.grpInvoice.Controls.Add(Me.FreightcarrierLookUpEdit)
        Me.grpInvoice.Controls.Add(Me.GroupControl3)
        Me.grpInvoice.Controls.Add(Me.GroupControl2)
        Me.grpInvoice.Controls.Add(OrdertermsLabel)
        Me.grpInvoice.Controls.Add(Me.eInvoiceTerms)
        Me.grpInvoice.Controls.Add(OrderstatusLabel)
        Me.grpInvoice.Controls.Add(Me.eInvoiceStatus)
        Me.grpInvoice.Controls.Add(OrdernotesLabel)
        Me.grpInvoice.Controls.Add(Me.OrdernotesTextEdit)
        Me.grpInvoice.Controls.Add(FreightcarrierLabel)
        Me.grpInvoice.Controls.Add(DeliverydateLabel)
        Me.grpInvoice.Controls.Add(Me.DeliverydateDateEdit)
        Me.grpInvoice.Controls.Add(CustomerpoLabel)
        Me.grpInvoice.Controls.Add(Me.CustidLookUpEdit)
        Me.grpInvoice.Controls.Add(Me.CustomerpoTextEdit)
        Me.grpInvoice.Controls.Add(CustidLabel)
        Me.grpInvoice.Controls.Add(CustorderdateLabel)
        Me.grpInvoice.Controls.Add(Me.eInvoiceNumber)
        Me.grpInvoice.Controls.Add(Me.eInvoiceDate)
        Me.grpInvoice.Controls.Add(WorkordernumberLabel)
        Me.grpInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpInvoice.Location = New System.Drawing.Point(6, 6)
        Me.grpInvoice.Name = "grpInvoice"
        Me.grpInvoice.Size = New System.Drawing.Size(714, 303)
        Me.grpInvoice.TabIndex = 23
        Me.grpInvoice.Text = "Historical Invoice Information"
        '
        'FobLookUpEdit
        '
        Me.FobLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Fob", True))
        Me.FobLookUpEdit.Location = New System.Drawing.Point(595, 79)
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
        Me.FobLookUpEdit.Size = New System.Drawing.Size(95, 22)
        Me.FobLookUpEdit.TabIndex = 57
        '
        'bsInvoiceHistory
        '
        Me.bsInvoiceHistory.DataSource = GetType(AOS.BusinessObjects.Invoicehistory)
        '
        'bsFOB
        '
        Me.bsFOB.DataSource = GetType(AOS.BusinessObjects.ListFobCollection)
        '
        'FreightcarrierLookUpEdit
        '
        Me.FreightcarrierLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Freightcarrier", True))
        Me.FreightcarrierLookUpEdit.Location = New System.Drawing.Point(439, 52)
        Me.FreightcarrierLookUpEdit.Name = "FreightcarrierLookUpEdit"
        Me.FreightcarrierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FreightcarrierLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierID", "Carrier ID", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.FreightcarrierLookUpEdit.Properties.DataSource = Me.bsCarriers
        Me.FreightcarrierLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.FreightcarrierLookUpEdit.Properties.NullText = ""
        Me.FreightcarrierLookUpEdit.Properties.ValueMember = "CarrierName"
        Me.FreightcarrierLookUpEdit.Size = New System.Drawing.Size(251, 22)
        Me.FreightcarrierLookUpEdit.TabIndex = 54
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.Shipaddress1TextEdit)
        Me.GroupControl3.Controls.Add(Shipaddress1Label)
        Me.GroupControl3.Controls.Add(ShipcontactLabel)
        Me.GroupControl3.Controls.Add(Me.Shipaddress2TextEdit)
        Me.GroupControl3.Controls.Add(Me.ShipcontactTextEdit)
        Me.GroupControl3.Controls.Add(Shipaddress2Label)
        Me.GroupControl3.Controls.Add(ShipcountryLabel)
        Me.GroupControl3.Controls.Add(Me.ShipcityTextEdit)
        Me.GroupControl3.Controls.Add(Me.ShipcountryTextEdit)
        Me.GroupControl3.Controls.Add(ShipcityLabel)
        Me.GroupControl3.Controls.Add(Me.ShipstateprovTextEdit)
        Me.GroupControl3.Controls.Add(Me.ShippostalcodeTextEdit)
        Me.GroupControl3.Location = New System.Drawing.Point(15, 105)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(329, 154)
        Me.GroupControl3.TabIndex = 53
        Me.GroupControl3.Text = "Shipping Address"
        '
        'Shipaddress1TextEdit
        '
        Me.Shipaddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Shipaddress1", True))
        Me.Shipaddress1TextEdit.Location = New System.Drawing.Point(80, 23)
        Me.Shipaddress1TextEdit.Name = "Shipaddress1TextEdit"
        Me.Shipaddress1TextEdit.Size = New System.Drawing.Size(241, 22)
        Me.Shipaddress1TextEdit.TabIndex = 39
        '
        'Shipaddress2TextEdit
        '
        Me.Shipaddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Shipaddress2", True))
        Me.Shipaddress2TextEdit.Location = New System.Drawing.Point(80, 49)
        Me.Shipaddress2TextEdit.Name = "Shipaddress2TextEdit"
        Me.Shipaddress2TextEdit.Size = New System.Drawing.Size(241, 22)
        Me.Shipaddress2TextEdit.TabIndex = 41
        '
        'ShipcontactTextEdit
        '
        Me.ShipcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Shipcontact", True))
        Me.ShipcontactTextEdit.Location = New System.Drawing.Point(80, 127)
        Me.ShipcontactTextEdit.Name = "ShipcontactTextEdit"
        Me.ShipcontactTextEdit.Size = New System.Drawing.Size(241, 22)
        Me.ShipcontactTextEdit.TabIndex = 51
        '
        'ShipcityTextEdit
        '
        Me.ShipcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Shipcity", True))
        Me.ShipcityTextEdit.Location = New System.Drawing.Point(80, 75)
        Me.ShipcityTextEdit.Name = "ShipcityTextEdit"
        Me.ShipcityTextEdit.Size = New System.Drawing.Size(130, 22)
        Me.ShipcityTextEdit.TabIndex = 43
        '
        'ShipcountryTextEdit
        '
        Me.ShipcountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Shipcountry", True))
        Me.ShipcountryTextEdit.Location = New System.Drawing.Point(80, 101)
        Me.ShipcountryTextEdit.Name = "ShipcountryTextEdit"
        Me.ShipcountryTextEdit.Size = New System.Drawing.Size(241, 22)
        Me.ShipcountryTextEdit.TabIndex = 49
        '
        'ShipstateprovTextEdit
        '
        Me.ShipstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Shipstateprov", True))
        Me.ShipstateprovTextEdit.Location = New System.Drawing.Point(216, 75)
        Me.ShipstateprovTextEdit.Name = "ShipstateprovTextEdit"
        Me.ShipstateprovTextEdit.Size = New System.Drawing.Size(24, 22)
        Me.ShipstateprovTextEdit.TabIndex = 45
        '
        'ShippostalcodeTextEdit
        '
        Me.ShippostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Shippostalcode", True))
        Me.ShippostalcodeTextEdit.Location = New System.Drawing.Point(246, 75)
        Me.ShippostalcodeTextEdit.Name = "ShippostalcodeTextEdit"
        Me.ShippostalcodeTextEdit.Size = New System.Drawing.Size(75, 22)
        Me.ShippostalcodeTextEdit.TabIndex = 47
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Label3)
        Me.GroupControl2.Controls.Add(Me.Billaddress1TextEdit)
        Me.GroupControl2.Controls.Add(Billaddress1Label)
        Me.GroupControl2.Controls.Add(Me.Billaddress2TextEdit)
        Me.GroupControl2.Controls.Add(Billaddress2Label)
        Me.GroupControl2.Controls.Add(Me.BillcityTextEdit)
        Me.GroupControl2.Controls.Add(BillcityLabel)
        Me.GroupControl2.Controls.Add(Me.BillstateprovTextEdit)
        Me.GroupControl2.Controls.Add(Me.BillpostalcodeTextEdit)
        Me.GroupControl2.Controls.Add(Me.BillcountryTextEdit)
        Me.GroupControl2.Controls.Add(BillcountryLabel)
        Me.GroupControl2.Controls.Add(Me.BillcontactTextEdit)
        Me.GroupControl2.Location = New System.Drawing.Point(361, 105)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(329, 154)
        Me.GroupControl2.TabIndex = 52
        Me.GroupControl2.Text = "Billing Address"
        '
        'Billaddress1TextEdit
        '
        Me.Billaddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Billaddress1", True))
        Me.Billaddress1TextEdit.Location = New System.Drawing.Point(80, 23)
        Me.Billaddress1TextEdit.Name = "Billaddress1TextEdit"
        Me.Billaddress1TextEdit.Size = New System.Drawing.Size(242, 22)
        Me.Billaddress1TextEdit.TabIndex = 30
        '
        'Billaddress2TextEdit
        '
        Me.Billaddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Billaddress2", True))
        Me.Billaddress2TextEdit.Location = New System.Drawing.Point(80, 49)
        Me.Billaddress2TextEdit.Name = "Billaddress2TextEdit"
        Me.Billaddress2TextEdit.Size = New System.Drawing.Size(242, 22)
        Me.Billaddress2TextEdit.TabIndex = 31
        '
        'BillcityTextEdit
        '
        Me.BillcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Billcity", True))
        Me.BillcityTextEdit.Location = New System.Drawing.Point(80, 75)
        Me.BillcityTextEdit.Name = "BillcityTextEdit"
        Me.BillcityTextEdit.Size = New System.Drawing.Size(130, 22)
        Me.BillcityTextEdit.TabIndex = 32
        '
        'BillstateprovTextEdit
        '
        Me.BillstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Billstateprov", True))
        Me.BillstateprovTextEdit.Location = New System.Drawing.Point(217, 75)
        Me.BillstateprovTextEdit.Name = "BillstateprovTextEdit"
        Me.BillstateprovTextEdit.Size = New System.Drawing.Size(24, 22)
        Me.BillstateprovTextEdit.TabIndex = 33
        '
        'BillpostalcodeTextEdit
        '
        Me.BillpostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Billpostalcode", True))
        Me.BillpostalcodeTextEdit.Location = New System.Drawing.Point(247, 75)
        Me.BillpostalcodeTextEdit.Name = "BillpostalcodeTextEdit"
        Me.BillpostalcodeTextEdit.Size = New System.Drawing.Size(75, 22)
        Me.BillpostalcodeTextEdit.TabIndex = 34
        '
        'BillcountryTextEdit
        '
        Me.BillcountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Billcountry", True))
        Me.BillcountryTextEdit.Location = New System.Drawing.Point(80, 101)
        Me.BillcountryTextEdit.Name = "BillcountryTextEdit"
        Me.BillcountryTextEdit.Size = New System.Drawing.Size(242, 22)
        Me.BillcountryTextEdit.TabIndex = 35
        '
        'BillcontactTextEdit
        '
        Me.BillcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Billcontact", True))
        Me.BillcontactTextEdit.Location = New System.Drawing.Point(80, 127)
        Me.BillcontactTextEdit.Name = "BillcontactTextEdit"
        Me.BillcontactTextEdit.Size = New System.Drawing.Size(242, 22)
        Me.BillcontactTextEdit.TabIndex = 37
        '
        'eInvoiceTerms
        '
        Me.eInvoiceTerms.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Orderterms", True))
        Me.eInvoiceTerms.Location = New System.Drawing.Point(249, 79)
        Me.eInvoiceTerms.Name = "eInvoiceTerms"
        Me.eInvoiceTerms.Size = New System.Drawing.Size(95, 22)
        Me.eInvoiceTerms.TabIndex = 28
        '
        'eInvoiceStatus
        '
        Me.eInvoiceStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Invoicestatus", True))
        Me.eInvoiceStatus.Location = New System.Drawing.Point(595, 26)
        Me.eInvoiceStatus.Name = "eInvoiceStatus"
        Me.eInvoiceStatus.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.eInvoiceStatus.Properties.Appearance.Options.UseBackColor = True
        Me.eInvoiceStatus.Properties.ReadOnly = True
        Me.eInvoiceStatus.Size = New System.Drawing.Size(95, 22)
        Me.eInvoiceStatus.TabIndex = 27
        Me.eInvoiceStatus.TabStop = False
        '
        'OrdernotesTextEdit
        '
        Me.OrdernotesTextEdit.Location = New System.Drawing.Point(95, 265)
        Me.OrdernotesTextEdit.Name = "OrdernotesTextEdit"
        Me.OrdernotesTextEdit.Properties.AutoHeight = False
        Me.OrdernotesTextEdit.Size = New System.Drawing.Size(595, 31)
        Me.OrdernotesTextEdit.TabIndex = 26
        '
        'DeliverydateDateEdit
        '
        Me.DeliverydateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Deliverydate", True))
        Me.DeliverydateDateEdit.EditValue = Nothing
        Me.DeliverydateDateEdit.Location = New System.Drawing.Point(439, 79)
        Me.DeliverydateDateEdit.Name = "DeliverydateDateEdit"
        Me.DeliverydateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeliverydateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DeliverydateDateEdit.Size = New System.Drawing.Size(100, 22)
        Me.DeliverydateDateEdit.TabIndex = 23
        '
        'CustidLookUpEdit
        '
        Me.CustidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Custid", True))
        Me.CustidLookUpEdit.Location = New System.Drawing.Point(95, 52)
        Me.CustidLookUpEdit.Name = "CustidLookUpEdit"
        Me.CustidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "Cust ID", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 250, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustidLookUpEdit.Properties.DataSource = Me.bsCustomers
        Me.CustidLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustidLookUpEdit.Properties.NullText = ""
        Me.CustidLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustidLookUpEdit.Size = New System.Drawing.Size(249, 22)
        Me.CustidLookUpEdit.TabIndex = 18
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'CustomerpoTextEdit
        '
        Me.CustomerpoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Customerpo", True))
        Me.CustomerpoTextEdit.Location = New System.Drawing.Point(95, 79)
        Me.CustomerpoTextEdit.Name = "CustomerpoTextEdit"
        Me.CustomerpoTextEdit.Size = New System.Drawing.Size(100, 22)
        Me.CustomerpoTextEdit.TabIndex = 22
        '
        'eInvoiceNumber
        '
        Me.eInvoiceNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Invoicenumber", True))
        Me.eInvoiceNumber.Location = New System.Drawing.Point(95, 26)
        Me.eInvoiceNumber.Name = "eInvoiceNumber"
        Me.eInvoiceNumber.Properties.ReadOnly = True
        Me.eInvoiceNumber.Size = New System.Drawing.Size(100, 22)
        Me.eInvoiceNumber.TabIndex = 19
        '
        'eInvoiceDate
        '
        Me.eInvoiceDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Invoicedate", True))
        Me.eInvoiceDate.EditValue = Nothing
        Me.eInvoiceDate.Location = New System.Drawing.Point(249, 26)
        Me.eInvoiceDate.Name = "eInvoiceDate"
        Me.eInvoiceDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eInvoiceDate.Size = New System.Drawing.Size(95, 22)
        Me.eInvoiceDate.TabIndex = 21
        '
        'bsSales
        '
        Me.bsSales.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsInvoiceHistoryItems
        '
        Me.bsInvoiceHistoryItems.DataSource = GetType(AOS.BusinessObjects.InvoicehistoryitemCollection)
        '
        'GroupControl4
        '
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl4.Controls.Add(Me.GroupControl1)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 457)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupControl4.Size = New System.Drawing.Size(726, 188)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "Work Order Items"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grInvoiceHistoryItems)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(6, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(714, 176)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Historical Invoice Items"
        '
        'grInvoiceHistoryItems
        '
        Me.grInvoiceHistoryItems.DataSource = Me.bsInvoiceHistoryItems
        Me.grInvoiceHistoryItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInvoiceHistoryItems.Location = New System.Drawing.Point(2, 25)
        Me.grInvoiceHistoryItems.LookAndFeel.SkinName = "Money Twins"
        Me.grInvoiceHistoryItems.MainView = Me.GridView4
        Me.grInvoiceHistoryItems.Name = "grInvoiceHistoryItems"
        Me.grInvoiceHistoryItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.grInvoiceHistoryItems.Size = New System.Drawing.Size(710, 149)
        Me.grInvoiceHistoryItems.TabIndex = 1
        Me.grInvoiceHistoryItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView4.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView4.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView4.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView4.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView4.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView4.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView4.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView4.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView4.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView4.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView4.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView4.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView4.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView4.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView4.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView4.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView4.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView4.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQuantity, Me.colItemid, Me.colItemdescription, Me.colContainer, Me.colPricemethod, Me.colItemprice, Me.colExtprice, Me.colPriceuom, Me.colPriceunits})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView4.GridControl = Me.grInvoiceHistoryItems
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colQuantity
        '
        Me.colQuantity.AppearanceCell.Options.UseTextOptions = True
        Me.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colQuantity.Caption = "Qty"
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 0
        Me.colQuantity.Width = 62
        '
        'colItemid
        '
        Me.colItemid.Caption = "Item ID"
        Me.colItemid.FieldName = "Itemid"
        Me.colItemid.Name = "colItemid"
        Me.colItemid.Visible = True
        Me.colItemid.VisibleIndex = 3
        Me.colItemid.Width = 51
        '
        'colItemdescription
        '
        Me.colItemdescription.Caption = "Item Description"
        Me.colItemdescription.FieldName = "Itemdescription"
        Me.colItemdescription.Name = "colItemdescription"
        Me.colItemdescription.Visible = True
        Me.colItemdescription.VisibleIndex = 4
        Me.colItemdescription.Width = 219
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 5
        Me.colContainer.Width = 67
        '
        'colPricemethod
        '
        Me.colPricemethod.Caption = "PM"
        Me.colPricemethod.FieldName = "Unitorcontainer"
        Me.colPricemethod.Name = "colPricemethod"
        Me.colPricemethod.Visible = True
        Me.colPricemethod.VisibleIndex = 1
        Me.colPricemethod.Width = 34
        '
        'colItemprice
        '
        Me.colItemprice.AppearanceCell.Options.UseTextOptions = True
        Me.colItemprice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colItemprice.Caption = "Item Price"
        Me.colItemprice.DisplayFormat.FormatString = "c2"
        Me.colItemprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colItemprice.FieldName = "Itemprice"
        Me.colItemprice.Name = "colItemprice"
        Me.colItemprice.Visible = True
        Me.colItemprice.VisibleIndex = 7
        Me.colItemprice.Width = 86
        '
        'colExtprice
        '
        Me.colExtprice.AppearanceCell.Options.UseTextOptions = True
        Me.colExtprice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colExtprice.Caption = "Ext Price"
        Me.colExtprice.DisplayFormat.FormatString = "c2"
        Me.colExtprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExtprice.FieldName = "Extprice"
        Me.colExtprice.Name = "colExtprice"
        Me.colExtprice.Visible = True
        Me.colExtprice.VisibleIndex = 8
        Me.colExtprice.Width = 97
        '
        'colPriceuom
        '
        Me.colPriceuom.Caption = "UOM"
        Me.colPriceuom.FieldName = "Priceuom"
        Me.colPriceuom.Name = "colPriceuom"
        Me.colPriceuom.Visible = True
        Me.colPriceuom.VisibleIndex = 2
        Me.colPriceuom.Width = 52
        '
        'colPriceunits
        '
        Me.colPriceunits.Caption = "Units"
        Me.colPriceunits.FieldName = "Priceunits"
        Me.colPriceunits.Name = "colPriceunits"
        Me.colPriceunits.Visible = True
        Me.colPriceunits.VisibleIndex = 6
        Me.colPriceunits.Width = 42
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "Productid"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnCancel, Me.btnAddItem, Me.btnEditItem, Me.btnDeleteItem, Me.btnMiscCharge, Me.rbtnPrintInvoiceHistorical})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 8
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(726, 142)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Close"
        Me.btnCancel.Id = 1
        Me.btnCancel.ImageOptions.Image = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.ImageOptions.LargeImageIndex = 6
        Me.btnCancel.Name = "btnCancel"
        '
        'btnAddItem
        '
        Me.btnAddItem.Caption = " Add  Item"
        Me.btnAddItem.Id = 2
        Me.btnAddItem.ImageOptions.Image = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddItem.ImageOptions.LargeImageIndex = 14
        Me.btnAddItem.Name = "btnAddItem"
        '
        'btnEditItem
        '
        Me.btnEditItem.Caption = " Edit  Item"
        Me.btnEditItem.Id = 3
        Me.btnEditItem.ImageOptions.LargeImageIndex = 16
        Me.btnEditItem.Name = "btnEditItem"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Caption = "Delete Item"
        Me.btnDeleteItem.Id = 4
        Me.btnDeleteItem.ImageOptions.LargeImageIndex = 17
        Me.btnDeleteItem.Name = "btnDeleteItem"
        '
        'btnMiscCharge
        '
        Me.btnMiscCharge.Caption = " Misc  Charge"
        Me.btnMiscCharge.Id = 5
        Me.btnMiscCharge.ImageOptions.LargeImageIndex = 15
        Me.btnMiscCharge.Name = "btnMiscCharge"
        '
        'rbtnPrintInvoiceHistorical
        '
        Me.rbtnPrintInvoiceHistorical.Caption = "Print"
        Me.rbtnPrintInvoiceHistorical.Id = 7
        Me.rbtnPrintInvoiceHistorical.ImageOptions.LargeImageIndex = 10
        Me.rbtnPrintInvoiceHistorical.Name = "rbtnPrintInvoiceHistorical"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Historical Invoice "
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnPrintInvoiceHistorical)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Reports"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Label4)
        Me.PanelControl1.Controls.Add(Me.eTotal)
        Me.PanelControl1.Controls.Add(Label2)
        Me.PanelControl1.Controls.Add(Me.eSalesTax)
        Me.PanelControl1.Controls.Add(Label1)
        Me.PanelControl1.Controls.Add(Me.eSubtotal)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 645)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(726, 42)
        Me.PanelControl1.TabIndex = 5
        '
        'eTotal
        '
        Me.eTotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Total", True))
        Me.eTotal.Location = New System.Drawing.Point(640, 10)
        Me.eTotal.Name = "eTotal"
        Me.eTotal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.eTotal.Properties.Appearance.Options.UseBackColor = True
        Me.eTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.eTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eTotal.Properties.DisplayFormat.FormatString = "c2"
        Me.eTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eTotal.Properties.ReadOnly = True
        Me.eTotal.Size = New System.Drawing.Size(80, 22)
        Me.eTotal.TabIndex = 33
        Me.eTotal.TabStop = False
        '
        'eSalesTax
        '
        Me.eSalesTax.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Salestax", True))
        Me.eSalesTax.Location = New System.Drawing.Point(517, 10)
        Me.eSalesTax.Name = "eSalesTax"
        Me.eSalesTax.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.eSalesTax.Properties.Appearance.Options.UseBackColor = True
        Me.eSalesTax.Properties.Appearance.Options.UseTextOptions = True
        Me.eSalesTax.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eSalesTax.Properties.DisplayFormat.FormatString = "c2"
        Me.eSalesTax.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eSalesTax.Properties.ReadOnly = True
        Me.eSalesTax.Size = New System.Drawing.Size(80, 22)
        Me.eSalesTax.TabIndex = 31
        Me.eSalesTax.TabStop = False
        '
        'eSubtotal
        '
        Me.eSubtotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistory, "Subtotal", True))
        Me.eSubtotal.Location = New System.Drawing.Point(368, 10)
        Me.eSubtotal.Name = "eSubtotal"
        Me.eSubtotal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.eSubtotal.Properties.Appearance.Options.UseBackColor = True
        Me.eSubtotal.Properties.Appearance.Options.UseTextOptions = True
        Me.eSubtotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eSubtotal.Properties.DisplayFormat.FormatString = "c2"
        Me.eSubtotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eSubtotal.Properties.ReadOnly = True
        Me.eSubtotal.Size = New System.Drawing.Size(84, 22)
        Me.eSubtotal.TabIndex = 29
        Me.eSubtotal.TabStop = False
        '
        'rbtnPrintInvoice
        '
        Me.rbtnPrintInvoice.Caption = "Save && Print Invoice"
        Me.rbtnPrintInvoice.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPrintInvoice.Id = 6
        Me.rbtnPrintInvoice.ImageOptions.LargeImageIndex = 10
        Me.rbtnPrintInvoice.Name = "rbtnPrintInvoice"
        '
        'rpgInvoiceItems
        '
        Me.rpgInvoiceItems.AllowTextClipping = False
        Me.rpgInvoiceItems.ItemLinks.Add(Me.btnAddItem)
        Me.rpgInvoiceItems.ItemLinks.Add(Me.btnEditItem, True)
        Me.rpgInvoiceItems.ItemLinks.Add(Me.btnDeleteItem, True)
        Me.rpgInvoiceItems.ItemLinks.Add(Me.btnMiscCharge, True)
        Me.rpgInvoiceItems.Name = "rpgInvoiceItems"
        Me.rpgInvoiceItems.ShowCaptionButton = False
        Me.rpgInvoiceItems.Text = "Invoice Items"
        '
        'frmViewInvoiceHistory
        '
        Me.ClientSize = New System.Drawing.Size(726, 687)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmViewInvoiceHistory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Historical Invoice Information"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grpInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInvoice.ResumeLayout(False)
        Me.grpInvoice.PerformLayout()
        CType(Me.FobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvoiceHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FreightcarrierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.Shipaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.Billaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Billaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillpostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoiceTerms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoiceStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdernotesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverydateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverydateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvoiceHistoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grInvoiceHistoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.eTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eSalesTax.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eSubtotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsInvoiceHistory As System.Windows.Forms.BindingSource
    Friend WithEvents bsInvoiceHistoryItems As System.Windows.Forms.BindingSource
    Friend WithEvents grpInvoice As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CustidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CustomerpoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eInvoiceNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eInvoiceDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ShipcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipcountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShippostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Shipaddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Shipaddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BillcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BillcountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BillpostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BillstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BillcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Billaddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Billaddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eInvoiceTerms As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eInvoiceStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents OrdernotesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliverydateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents FreightcarrierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsSales As System.Windows.Forms.BindingSource
    Friend WithEvents FobLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsFOB As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grInvoiceHistoryItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPricemethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents eTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eSalesTax As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eSubtotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnMiscCharge As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colPriceuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriceunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemdescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnPrintInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgInvoiceItems As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnPrintInvoiceHistorical As DevExpress.XtraBars.BarButtonItem
End Class
