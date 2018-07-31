<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditBDFInvoice

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
        Dim CustidLabel As System.Windows.Forms.Label
        Dim WorkordernumberLabel As System.Windows.Forms.Label
        Dim CustorderdateLabel As System.Windows.Forms.Label
        Dim DeliverydateLabel As System.Windows.Forms.Label
        Dim FreightcarrierLabel As System.Windows.Forms.Label
        Dim OrdernotesLabel As System.Windows.Forms.Label
        Dim OrderstatusLabel As System.Windows.Forms.Label
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
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grpInvoice = New DevExpress.XtraEditors.GroupControl()
        Me.eRemarksMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.bsBDFInvoice = New System.Windows.Forms.BindingSource(Me.components)
        Me.eInvoicePRONumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.eInvoiceConsigneeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Shipaddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Shipaddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipcountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShippostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Billaddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Billaddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillpostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillcountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BillcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eInvoiceStatus = New DevExpress.XtraEditors.TextEdit()
        Me.DeliverydateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.eInvoiceNumber = New DevExpress.XtraEditors.TextEdit()
        Me.eInvoiceDate = New DevExpress.XtraEditors.DateEdit()
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsBDFInvoiceItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grItems = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New CustomDevExGridView()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSaveInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelChanges = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMiscCharge = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgInvoiceItems = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.eTotal = New DevExpress.XtraEditors.TextEdit()
        CustidLabel = New System.Windows.Forms.Label()
        WorkordernumberLabel = New System.Windows.Forms.Label()
        CustorderdateLabel = New System.Windows.Forms.Label()
        DeliverydateLabel = New System.Windows.Forms.Label()
        FreightcarrierLabel = New System.Windows.Forms.Label()
        OrdernotesLabel = New System.Windows.Forms.Label()
        OrderstatusLabel = New System.Windows.Forms.Label()
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
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grpInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInvoice.SuspendLayout()
        CType(Me.eRemarksMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBDFInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoicePRONumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.eInvoiceConsigneeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Billaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Billaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillpostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoiceStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverydateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliverydateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBDFInvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.eTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(8, 32)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(57, 13)
        CustidLabel.TabIndex = 17
        CustidLabel.Text = "Consignee"
        '
        'WorkordernumberLabel
        '
        WorkordernumberLabel.AutoSize = True
        WorkordernumberLabel.Location = New System.Drawing.Point(23, 29)
        WorkordernumberLabel.Name = "WorkordernumberLabel"
        WorkordernumberLabel.Size = New System.Drawing.Size(53, 13)
        WorkordernumberLabel.TabIndex = 18
        WorkordernumberLabel.Text = "Invoice #"
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
        'DeliverydateLabel
        '
        DeliverydateLabel.AutoSize = True
        DeliverydateLabel.Location = New System.Drawing.Point(380, 29)
        DeliverydateLabel.Name = "DeliverydateLabel"
        DeliverydateLabel.Size = New System.Drawing.Size(53, 13)
        DeliverydateLabel.TabIndex = 22
        DeliverydateLabel.Text = "Ship Date"
        '
        'FreightcarrierLabel
        '
        FreightcarrierLabel.AutoSize = True
        FreightcarrierLabel.Location = New System.Drawing.Point(10, 32)
        FreightcarrierLabel.Name = "FreightcarrierLabel"
        FreightcarrierLabel.Size = New System.Drawing.Size(43, 13)
        FreightcarrierLabel.TabIndex = 24
        FreightcarrierLabel.Text = "Shipper"
        '
        'OrdernotesLabel
        '
        OrdernotesLabel.Location = New System.Drawing.Point(13, 276)
        OrdernotesLabel.Name = "OrdernotesLabel"
        OrdernotesLabel.Size = New System.Drawing.Size(67, 18)
        OrdernotesLabel.TabIndex = 25
        OrdernotesLabel.Text = "Remarks"
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
        'Billaddress1Label
        '
        Billaddress1Label.AutoSize = True
        Billaddress1Label.Location = New System.Drawing.Point(7, 58)
        Billaddress1Label.Name = "Billaddress1Label"
        Billaddress1Label.Size = New System.Drawing.Size(52, 13)
        Billaddress1Label.TabIndex = 29
        Billaddress1Label.Text = "Address1"
        '
        'Billaddress2Label
        '
        Billaddress2Label.AutoSize = True
        Billaddress2Label.Location = New System.Drawing.Point(7, 84)
        Billaddress2Label.Name = "Billaddress2Label"
        Billaddress2Label.Size = New System.Drawing.Size(52, 13)
        Billaddress2Label.TabIndex = 30
        Billaddress2Label.Text = "Address2"
        '
        'BillcityLabel
        '
        BillcityLabel.AutoSize = True
        BillcityLabel.Location = New System.Drawing.Point(3, 110)
        BillcityLabel.Name = "BillcityLabel"
        BillcityLabel.Size = New System.Drawing.Size(56, 13)
        BillcityLabel.TabIndex = 31
        BillcityLabel.Text = "City St Zip"
        '
        'BillcountryLabel
        '
        BillcountryLabel.AutoSize = True
        BillcountryLabel.Location = New System.Drawing.Point(7, 136)
        BillcountryLabel.Name = "BillcountryLabel"
        BillcountryLabel.Size = New System.Drawing.Size(46, 13)
        BillcountryLabel.TabIndex = 34
        BillcountryLabel.Text = "Country"
        '
        'Shipaddress1Label
        '
        Shipaddress1Label.AutoSize = True
        Shipaddress1Label.Location = New System.Drawing.Point(7, 58)
        Shipaddress1Label.Name = "Shipaddress1Label"
        Shipaddress1Label.Size = New System.Drawing.Size(52, 13)
        Shipaddress1Label.TabIndex = 38
        Shipaddress1Label.Text = "Address1"
        '
        'Shipaddress2Label
        '
        Shipaddress2Label.AutoSize = True
        Shipaddress2Label.Location = New System.Drawing.Point(7, 84)
        Shipaddress2Label.Name = "Shipaddress2Label"
        Shipaddress2Label.Size = New System.Drawing.Size(52, 13)
        Shipaddress2Label.TabIndex = 40
        Shipaddress2Label.Text = "Address2"
        '
        'ShipcityLabel
        '
        ShipcityLabel.AutoSize = True
        ShipcityLabel.Location = New System.Drawing.Point(7, 110)
        ShipcityLabel.Name = "ShipcityLabel"
        ShipcityLabel.Size = New System.Drawing.Size(56, 13)
        ShipcityLabel.TabIndex = 42
        ShipcityLabel.Text = "City St Zip"
        '
        'ShipcountryLabel
        '
        ShipcountryLabel.AutoSize = True
        ShipcountryLabel.Location = New System.Drawing.Point(7, 136)
        ShipcountryLabel.Name = "ShipcountryLabel"
        ShipcountryLabel.Size = New System.Drawing.Size(46, 13)
        ShipcountryLabel.TabIndex = 48
        ShipcountryLabel.Text = "Country"
        '
        'ShipcontactLabel
        '
        ShipcontactLabel.AutoSize = True
        ShipcontactLabel.Location = New System.Drawing.Point(7, 162)
        ShipcontactLabel.Name = "ShipcontactLabel"
        ShipcontactLabel.Size = New System.Drawing.Size(45, 13)
        ShipcontactLabel.TabIndex = 50
        ShipcontactLabel.Text = "Contact"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(7, 162)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(45, 13)
        Label3.TabIndex = 38
        Label3.Text = "Contact"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(603, 13)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(31, 13)
        Label4.TabIndex = 32
        Label4.Text = "Total"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(23, 55)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(53, 13)
        Label5.TabIndex = 56
        Label5.Text = "Load Info"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.grpInvoice)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 96)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl2.Size = New System.Drawing.Size(726, 315)
        Me.PanelControl2.TabIndex = 1
        '
        'grpInvoice
        '
        Me.grpInvoice.Controls.Add(Me.eRemarksMemoEdit)
        Me.grpInvoice.Controls.Add(Label5)
        Me.grpInvoice.Controls.Add(Me.eInvoicePRONumberTextEdit)
        Me.grpInvoice.Controls.Add(Me.GroupControl3)
        Me.grpInvoice.Controls.Add(Me.GroupControl2)
        Me.grpInvoice.Controls.Add(OrderstatusLabel)
        Me.grpInvoice.Controls.Add(Me.eInvoiceStatus)
        Me.grpInvoice.Controls.Add(OrdernotesLabel)
        Me.grpInvoice.Controls.Add(DeliverydateLabel)
        Me.grpInvoice.Controls.Add(Me.DeliverydateDateEdit)
        Me.grpInvoice.Controls.Add(CustorderdateLabel)
        Me.grpInvoice.Controls.Add(Me.eInvoiceNumber)
        Me.grpInvoice.Controls.Add(Me.eInvoiceDate)
        Me.grpInvoice.Controls.Add(WorkordernumberLabel)
        Me.grpInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpInvoice.Location = New System.Drawing.Point(6, 6)
        Me.grpInvoice.Name = "grpInvoice"
        Me.grpInvoice.Size = New System.Drawing.Size(714, 303)
        Me.grpInvoice.TabIndex = 23
        Me.grpInvoice.Text = "BDF Invoice Information"
        '
        'eRemarksMemoEdit
        '
        Me.eRemarksMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Remarks", True))
        Me.eRemarksMemoEdit.Location = New System.Drawing.Point(95, 265)
        Me.eRemarksMemoEdit.Name = "eRemarksMemoEdit"
        Me.eRemarksMemoEdit.Size = New System.Drawing.Size(588, 35)
        Me.eRemarksMemoEdit.TabIndex = 8
        Me.eRemarksMemoEdit.UseOptimizedRendering = True
        '
        'bsBDFInvoice
        '
        Me.bsBDFInvoice.DataSource = GetType(AOS.BusinessObjects.BDFInvoice)
        '
        'eInvoicePRONumberTextEdit
        '
        Me.eInvoicePRONumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Loadinfo", True))
        Me.eInvoicePRONumberTextEdit.Location = New System.Drawing.Point(95, 52)
        Me.eInvoicePRONumberTextEdit.Name = "eInvoicePRONumberTextEdit"
        Me.eInvoicePRONumberTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.eInvoicePRONumberTextEdit.TabIndex = 55
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.eInvoiceConsigneeTextEdit)
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
        Me.GroupControl3.Controls.Add(CustidLabel)
        Me.GroupControl3.Location = New System.Drawing.Point(15, 78)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(329, 184)
        Me.GroupControl3.TabIndex = 53
        Me.GroupControl3.Text = "Consignee Address"
        '
        'eInvoiceConsigneeTextEdit
        '
        Me.eInvoiceConsigneeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Consigneename", True))
        Me.eInvoiceConsigneeTextEdit.Location = New System.Drawing.Point(80, 29)
        Me.eInvoiceConsigneeTextEdit.Name = "eInvoiceConsigneeTextEdit"
        Me.eInvoiceConsigneeTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.eInvoiceConsigneeTextEdit.TabIndex = 59
        '
        'Shipaddress1TextEdit
        '
        Me.Shipaddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Consigneeaddress1", True))
        Me.Shipaddress1TextEdit.Location = New System.Drawing.Point(80, 55)
        Me.Shipaddress1TextEdit.Name = "Shipaddress1TextEdit"
        Me.Shipaddress1TextEdit.Size = New System.Drawing.Size(241, 20)
        Me.Shipaddress1TextEdit.TabIndex = 39
        '
        'Shipaddress2TextEdit
        '
        Me.Shipaddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Consigneeaddress2", True))
        Me.Shipaddress2TextEdit.Location = New System.Drawing.Point(80, 81)
        Me.Shipaddress2TextEdit.Name = "Shipaddress2TextEdit"
        Me.Shipaddress2TextEdit.Size = New System.Drawing.Size(241, 20)
        Me.Shipaddress2TextEdit.TabIndex = 41
        '
        'ShipcontactTextEdit
        '
        Me.ShipcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Consigneecontact", True))
        Me.ShipcontactTextEdit.Location = New System.Drawing.Point(80, 159)
        Me.ShipcontactTextEdit.Name = "ShipcontactTextEdit"
        Me.ShipcontactTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.ShipcontactTextEdit.TabIndex = 51
        '
        'ShipcityTextEdit
        '
        Me.ShipcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Consigneecity", True))
        Me.ShipcityTextEdit.Location = New System.Drawing.Point(80, 107)
        Me.ShipcityTextEdit.Name = "ShipcityTextEdit"
        Me.ShipcityTextEdit.Size = New System.Drawing.Size(130, 20)
        Me.ShipcityTextEdit.TabIndex = 43
        '
        'ShipcountryTextEdit
        '
        Me.ShipcountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Consigneecountry", True))
        Me.ShipcountryTextEdit.Location = New System.Drawing.Point(80, 133)
        Me.ShipcountryTextEdit.Name = "ShipcountryTextEdit"
        Me.ShipcountryTextEdit.Size = New System.Drawing.Size(241, 20)
        Me.ShipcountryTextEdit.TabIndex = 49
        '
        'ShipstateprovTextEdit
        '
        Me.ShipstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Consigneestateprov", True))
        Me.ShipstateprovTextEdit.Location = New System.Drawing.Point(216, 107)
        Me.ShipstateprovTextEdit.Name = "ShipstateprovTextEdit"
        Me.ShipstateprovTextEdit.Size = New System.Drawing.Size(24, 20)
        Me.ShipstateprovTextEdit.TabIndex = 45
        '
        'ShippostalcodeTextEdit
        '
        Me.ShippostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Consigneepostalcode", True))
        Me.ShippostalcodeTextEdit.Location = New System.Drawing.Point(246, 107)
        Me.ShippostalcodeTextEdit.Name = "ShippostalcodeTextEdit"
        Me.ShippostalcodeTextEdit.Size = New System.Drawing.Size(75, 20)
        Me.ShippostalcodeTextEdit.TabIndex = 47
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.TextEdit1)
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
        Me.GroupControl2.Controls.Add(FreightcarrierLabel)
        Me.GroupControl2.Controls.Add(Me.BillcontactTextEdit)
        Me.GroupControl2.Location = New System.Drawing.Point(361, 78)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(329, 184)
        Me.GroupControl2.TabIndex = 52
        Me.GroupControl2.Text = "Shipper Address"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Shippername", True))
        Me.TextEdit1.Location = New System.Drawing.Point(80, 29)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(242, 20)
        Me.TextEdit1.TabIndex = 39
        '
        'Billaddress1TextEdit
        '
        Me.Billaddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Shipperaddress1", True))
        Me.Billaddress1TextEdit.Location = New System.Drawing.Point(80, 55)
        Me.Billaddress1TextEdit.Name = "Billaddress1TextEdit"
        Me.Billaddress1TextEdit.Size = New System.Drawing.Size(242, 20)
        Me.Billaddress1TextEdit.TabIndex = 30
        '
        'Billaddress2TextEdit
        '
        Me.Billaddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Shipperaddress2", True))
        Me.Billaddress2TextEdit.Location = New System.Drawing.Point(80, 81)
        Me.Billaddress2TextEdit.Name = "Billaddress2TextEdit"
        Me.Billaddress2TextEdit.Size = New System.Drawing.Size(242, 20)
        Me.Billaddress2TextEdit.TabIndex = 31
        '
        'BillcityTextEdit
        '
        Me.BillcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Shippercity", True))
        Me.BillcityTextEdit.Location = New System.Drawing.Point(80, 107)
        Me.BillcityTextEdit.Name = "BillcityTextEdit"
        Me.BillcityTextEdit.Size = New System.Drawing.Size(130, 20)
        Me.BillcityTextEdit.TabIndex = 32
        '
        'BillstateprovTextEdit
        '
        Me.BillstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Shipperstateprov", True))
        Me.BillstateprovTextEdit.Location = New System.Drawing.Point(217, 107)
        Me.BillstateprovTextEdit.Name = "BillstateprovTextEdit"
        Me.BillstateprovTextEdit.Size = New System.Drawing.Size(24, 20)
        Me.BillstateprovTextEdit.TabIndex = 33
        '
        'BillpostalcodeTextEdit
        '
        Me.BillpostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Shipperpostalcode", True))
        Me.BillpostalcodeTextEdit.Location = New System.Drawing.Point(247, 107)
        Me.BillpostalcodeTextEdit.Name = "BillpostalcodeTextEdit"
        Me.BillpostalcodeTextEdit.Size = New System.Drawing.Size(75, 20)
        Me.BillpostalcodeTextEdit.TabIndex = 34
        '
        'BillcountryTextEdit
        '
        Me.BillcountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Shippercountry", True))
        Me.BillcountryTextEdit.Location = New System.Drawing.Point(80, 133)
        Me.BillcountryTextEdit.Name = "BillcountryTextEdit"
        Me.BillcountryTextEdit.Size = New System.Drawing.Size(242, 20)
        Me.BillcountryTextEdit.TabIndex = 35
        '
        'BillcontactTextEdit
        '
        Me.BillcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Shippercontact", True))
        Me.BillcontactTextEdit.Location = New System.Drawing.Point(80, 159)
        Me.BillcontactTextEdit.Name = "BillcontactTextEdit"
        Me.BillcontactTextEdit.Size = New System.Drawing.Size(242, 20)
        Me.BillcontactTextEdit.TabIndex = 37
        '
        'eInvoiceStatus
        '
        Me.eInvoiceStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Invoicestatus", True))
        Me.eInvoiceStatus.Location = New System.Drawing.Point(595, 26)
        Me.eInvoiceStatus.Name = "eInvoiceStatus"
        Me.eInvoiceStatus.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.eInvoiceStatus.Properties.Appearance.Options.UseBackColor = True
        Me.eInvoiceStatus.Properties.ReadOnly = True
        Me.eInvoiceStatus.Size = New System.Drawing.Size(95, 20)
        Me.eInvoiceStatus.TabIndex = 27
        Me.eInvoiceStatus.TabStop = False
        '
        'DeliverydateDateEdit
        '
        Me.DeliverydateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Shipmentdate", True))
        Me.DeliverydateDateEdit.EditValue = Nothing
        Me.DeliverydateDateEdit.Location = New System.Drawing.Point(439, 26)
        Me.DeliverydateDateEdit.Name = "DeliverydateDateEdit"
        Me.DeliverydateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DeliverydateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DeliverydateDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.DeliverydateDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.DeliverydateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.DeliverydateDateEdit.TabIndex = 23
        '
        'eInvoiceNumber
        '
        Me.eInvoiceNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "BDFInvoiceNumber", True))
        Me.eInvoiceNumber.Location = New System.Drawing.Point(95, 26)
        Me.eInvoiceNumber.Name = "eInvoiceNumber"
        Me.eInvoiceNumber.Properties.ReadOnly = True
        Me.eInvoiceNumber.Size = New System.Drawing.Size(100, 20)
        Me.eInvoiceNumber.TabIndex = 19
        '
        'eInvoiceDate
        '
        Me.eInvoiceDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Invoicedate", True))
        Me.eInvoiceDate.EditValue = Nothing
        Me.eInvoiceDate.Location = New System.Drawing.Point(249, 26)
        Me.eInvoiceDate.Name = "eInvoiceDate"
        Me.eInvoiceDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eInvoiceDate.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.eInvoiceDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.eInvoiceDate.Properties.ReadOnly = True
        Me.eInvoiceDate.Size = New System.Drawing.Size(95, 20)
        Me.eInvoiceDate.TabIndex = 21
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsBDFInvoiceItems
        '
        Me.bsBDFInvoiceItems.DataSource = GetType(AOS.BusinessObjects.BDFInvoiceItemCollection)
        '
        'GroupControl4
        '
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl4.Controls.Add(Me.GroupControl1)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 411)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupControl4.Size = New System.Drawing.Size(726, 234)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "Work Order Items"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grItems)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(6, 6)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(714, 222)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "BDF Invoice Items"
        '
        'grItems
        '
        Me.grItems.DataSource = Me.bsBDFInvoiceItems
        Me.grItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grItems.Location = New System.Drawing.Point(2, 21)
        Me.grItems.LookAndFeel.SkinName = "Money Twins"
        Me.grItems.MainView = Me.GridView4
        Me.grItems.Name = "grItems"
        Me.grItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.grItems.Size = New System.Drawing.Size(710, 199)
        Me.grItems.TabIndex = 1
        Me.grItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
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
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQuantity, Me.colProductdesc, Me.GridColumn1, Me.GridColumn2, Me.colExtprice})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView4.GridControl = Me.grItems
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colQuantity
        '
        Me.colQuantity.AppearanceCell.Options.UseTextOptions = True
        Me.colQuantity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuantity.AppearanceHeader.Options.UseTextOptions = True
        Me.colQuantity.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQuantity.Caption = "Qty"
        Me.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.OptionsColumn.AllowEdit = False
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 0
        Me.colQuantity.Width = 42
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Service Description"
        Me.colProductdesc.FieldName = "ServiceDesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.OptionsColumn.AllowEdit = False
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 1
        Me.colProductdesc.Width = 206
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Weight"
        Me.GridColumn1.FieldName = "Weight"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Rate"
        Me.GridColumn2.FieldName = "Rate"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        '
        'colExtprice
        '
        Me.colExtprice.AppearanceCell.Options.UseTextOptions = True
        Me.colExtprice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colExtprice.AppearanceHeader.Options.UseTextOptions = True
        Me.colExtprice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colExtprice.Caption = "Ext Price"
        Me.colExtprice.DisplayFormat.FormatString = "c2"
        Me.colExtprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExtprice.FieldName = "ExtPrice"
        Me.colExtprice.Name = "colExtprice"
        Me.colExtprice.OptionsColumn.AllowEdit = False
        Me.colExtprice.Visible = True
        Me.colExtprice.VisibleIndex = 4
        Me.colExtprice.Width = 87
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "Productid"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSaveInvoice, Me.btnCancelChanges, Me.btnAddItem, Me.btnEditItem, Me.btnDeleteItem, Me.btnMiscCharge, Me.rbtnPrintInvoice})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(726, 96)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSaveInvoice
        '
        Me.btnSaveInvoice.Caption = "Save Invoice and Close"
        Me.btnSaveInvoice.Glyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSaveInvoice.Id = 0
        Me.btnSaveInvoice.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSaveInvoice.Name = "btnSaveInvoice"
        '
        'btnCancelChanges
        '
        Me.btnCancelChanges.Caption = "Cancel Changes"
        Me.btnCancelChanges.Glyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancelChanges.Id = 1
        Me.btnCancelChanges.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancelChanges.Name = "btnCancelChanges"
        '
        'btnAddItem
        '
        Me.btnAddItem.Caption = "Add New Item"
        Me.btnAddItem.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddItem.Id = 2
        Me.btnAddItem.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddItem.Name = "btnAddItem"
        '
        'btnEditItem
        '
        Me.btnEditItem.Caption = "Edit Item"
        Me.btnEditItem.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditItem.Id = 3
        Me.btnEditItem.Name = "btnEditItem"
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Caption = "Delete Item"
        Me.btnDeleteItem.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteItem.Id = 4
        Me.btnDeleteItem.Name = "btnDeleteItem"
        '
        'btnMiscCharge
        '
        Me.btnMiscCharge.Caption = "Misc Charge"
        Me.btnMiscCharge.Glyph = Global.AOS.My.Resources.Resources.NewDocumentHS
        Me.btnMiscCharge.Id = 5
        Me.btnMiscCharge.Name = "btnMiscCharge"
        '
        'rbtnPrintInvoice
        '
        Me.rbtnPrintInvoice.Caption = "Save && Print Invoice"
        Me.rbtnPrintInvoice.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPrintInvoice.Id = 6
        Me.rbtnPrintInvoice.LargeGlyph = Global.AOS.My.Resources.Resources.Report1
        Me.rbtnPrintInvoice.Name = "rbtnPrintInvoice"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.rpgInvoiceItems, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSaveInvoice)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancelChanges)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "BDF Invoice Options"
        '
        'rpgInvoiceItems
        '
        Me.rpgInvoiceItems.AllowTextClipping = False
        Me.rpgInvoiceItems.ItemLinks.Add(Me.btnAddItem)
        Me.rpgInvoiceItems.ItemLinks.Add(Me.btnEditItem)
        Me.rpgInvoiceItems.ItemLinks.Add(Me.btnDeleteItem)
        Me.rpgInvoiceItems.Name = "rpgInvoiceItems"
        Me.rpgInvoiceItems.ShowCaptionButton = False
        Me.rpgInvoiceItems.Text = "BDF Invoice Items"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnPrintInvoice)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Reports"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Label4)
        Me.PanelControl1.Controls.Add(Me.eTotal)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 645)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(726, 42)
        Me.PanelControl1.TabIndex = 5
        '
        'eTotal
        '
        Me.eTotal.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFInvoice, "Total", True))
        Me.eTotal.Location = New System.Drawing.Point(640, 10)
        Me.eTotal.Name = "eTotal"
        Me.eTotal.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.eTotal.Properties.Appearance.Options.UseBackColor = True
        Me.eTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.eTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eTotal.Properties.DisplayFormat.FormatString = "c2"
        Me.eTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eTotal.Properties.ReadOnly = True
        Me.eTotal.Size = New System.Drawing.Size(80, 20)
        Me.eTotal.TabIndex = 33
        Me.eTotal.TabStop = False
        '
        'frmAddEditBDFInvoice
        '
        Me.ClientSize = New System.Drawing.Size(726, 687)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditBDFInvoice"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BDF Invoice Information"
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grpInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInvoice.ResumeLayout(False)
        Me.grpInvoice.PerformLayout()
        CType(Me.eRemarksMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBDFInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoicePRONumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.eInvoiceConsigneeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Billaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Billaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillpostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoiceStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverydateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliverydateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoiceNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoiceDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvoiceDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBDFInvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.eTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsBDFInvoice As System.Windows.Forms.BindingSource
    Friend WithEvents bsBDFInvoiceItems As System.Windows.Forms.BindingSource
    Friend WithEvents grpInvoice As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents eInvoiceStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DeliverydateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnSaveInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelChanges As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgInvoiceItems As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents eTotal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnMiscCharge As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rbtnPrintInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eInvoicePRONumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eInvoiceConsigneeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eRemarksMemoEdit As DevExpress.XtraEditors.MemoEdit
End Class
