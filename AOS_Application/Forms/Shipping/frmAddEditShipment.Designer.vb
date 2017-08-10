<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditShipment

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
        Dim ShipmentnumberLabel As System.Windows.Forms.Label
        Dim ShipmentdateLabel As System.Windows.Forms.Label
        Dim ShipmentstatusLabel As System.Windows.Forms.Label
        Dim FreightcarrierLabel As System.Windows.Forms.Label
        Dim LogisticsidLabel As System.Windows.Forms.Label
        Dim FobLabel As System.Windows.Forms.Label
        Dim CustidLabel As System.Windows.Forms.Label
        Dim ShipfromidLabel As System.Windows.Forms.Label
        Dim Shipfromaddress1Label As System.Windows.Forms.Label
        Dim Shipfromaddress2Label As System.Windows.Forms.Label
        Dim ShipfromcityLabel As System.Windows.Forms.Label
        Dim ShipfromcontactLabel As System.Windows.Forms.Label
        Dim ShipfromphoneLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim CustomerpoLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim KeepfromfreezingLabel As System.Windows.Forms.Label
        Me.bsFOB = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddShipmentItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditShipmentItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteShipmentItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintBOL = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grShipmentItems = New DevExpress.XtraGrid.GridControl()
        Me.bsShipmentDetails = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New CustomDevExGridView()
        Me.colShipmentdetailid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtycontainers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBatchnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdgallons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDotdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnline = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassrate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLd3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkorderitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProductDesc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luContainer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luStdgallons = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CustomerpoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsShipment = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.FreightcarrierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LogisticsidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.FobLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CommentsTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.luShipToID = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsShippingTo = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.ShipfromphoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.luShipFromID = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsShippingFrom = New System.Windows.Forms.BindingSource(Me.components)
        Me.Shipfromaddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipfromcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipfrompostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Shipfromaddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipfromstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipfromcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.luCustomerID = New DevExpress.XtraEditors.LookUpEdit()
        Me.ShipmentstatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipmentdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ShipmentnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsShipmentItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.KeepfromfreezingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        ShipmentnumberLabel = New System.Windows.Forms.Label()
        ShipmentdateLabel = New System.Windows.Forms.Label()
        ShipmentstatusLabel = New System.Windows.Forms.Label()
        FreightcarrierLabel = New System.Windows.Forms.Label()
        LogisticsidLabel = New System.Windows.Forms.Label()
        FobLabel = New System.Windows.Forms.Label()
        CustidLabel = New System.Windows.Forms.Label()
        ShipfromidLabel = New System.Windows.Forms.Label()
        Shipfromaddress1Label = New System.Windows.Forms.Label()
        Shipfromaddress2Label = New System.Windows.Forms.Label()
        ShipfromcityLabel = New System.Windows.Forms.Label()
        ShipfromcontactLabel = New System.Windows.Forms.Label()
        ShipfromphoneLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CustomerpoLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        KeepfromfreezingLabel = New System.Windows.Forms.Label()
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grShipmentItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShipmentDetails, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FreightcarrierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticsidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luShipToID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShippingTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ShipfromphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luShipFromID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShippingFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipfromaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipfromcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipfrompostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipfromaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipfromstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipfromcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luCustomerID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentstatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShipmentItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KeepfromfreezingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ShipmentnumberLabel
        '
        ShipmentnumberLabel.AutoSize = True
        ShipmentnumberLabel.Location = New System.Drawing.Point(15, 36)
        ShipmentnumberLabel.Name = "ShipmentnumberLabel"
        ShipmentnumberLabel.Size = New System.Drawing.Size(62, 13)
        ShipmentnumberLabel.TabIndex = 0
        ShipmentnumberLabel.Text = "Shipment #"
        '
        'ShipmentdateLabel
        '
        ShipmentdateLabel.AutoSize = True
        ShipmentdateLabel.Location = New System.Drawing.Point(159, 36)
        ShipmentdateLabel.Name = "ShipmentdateLabel"
        ShipmentdateLabel.Size = New System.Drawing.Size(71, 13)
        ShipmentdateLabel.TabIndex = 2
        ShipmentdateLabel.Text = "Shipped Date"
        '
        'ShipmentstatusLabel
        '
        ShipmentstatusLabel.AutoSize = True
        ShipmentstatusLabel.Location = New System.Drawing.Point(890, 36)
        ShipmentstatusLabel.Name = "ShipmentstatusLabel"
        ShipmentstatusLabel.Size = New System.Drawing.Size(38, 13)
        ShipmentstatusLabel.TabIndex = 4
        ShipmentstatusLabel.Text = "Status"
        '
        'FreightcarrierLabel
        '
        FreightcarrierLabel.AutoSize = True
        FreightcarrierLabel.Location = New System.Drawing.Point(7, 31)
        FreightcarrierLabel.Name = "FreightcarrierLabel"
        FreightcarrierLabel.Size = New System.Drawing.Size(40, 13)
        FreightcarrierLabel.TabIndex = 6
        FreightcarrierLabel.Text = "Carrier"
        '
        'LogisticsidLabel
        '
        LogisticsidLabel.AutoSize = True
        LogisticsidLabel.Location = New System.Drawing.Point(7, 57)
        LogisticsidLabel.Name = "LogisticsidLabel"
        LogisticsidLabel.Size = New System.Drawing.Size(47, 13)
        LogisticsidLabel.TabIndex = 8
        LogisticsidLabel.Text = "Logistics"
        '
        'FobLabel
        '
        FobLabel.AutoSize = True
        FobLabel.Location = New System.Drawing.Point(7, 83)
        FobLabel.Name = "FobLabel"
        FobLabel.Size = New System.Drawing.Size(27, 13)
        FobLabel.TabIndex = 10
        FobLabel.Text = "FOB"
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(329, 36)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(53, 13)
        CustidLabel.TabIndex = 12
        CustidLabel.Text = "Customer"
        '
        'ShipfromidLabel
        '
        ShipfromidLabel.AutoSize = True
        ShipfromidLabel.Location = New System.Drawing.Point(10, 31)
        ShipfromidLabel.Name = "ShipfromidLabel"
        ShipfromidLabel.Size = New System.Drawing.Size(52, 13)
        ShipfromidLabel.TabIndex = 14
        ShipfromidLabel.Text = "Company"
        '
        'Shipfromaddress1Label
        '
        Shipfromaddress1Label.AutoSize = True
        Shipfromaddress1Label.Location = New System.Drawing.Point(10, 57)
        Shipfromaddress1Label.Name = "Shipfromaddress1Label"
        Shipfromaddress1Label.Size = New System.Drawing.Size(55, 13)
        Shipfromaddress1Label.TabIndex = 16
        Shipfromaddress1Label.Text = "Address 1"
        '
        'Shipfromaddress2Label
        '
        Shipfromaddress2Label.AutoSize = True
        Shipfromaddress2Label.Location = New System.Drawing.Point(10, 83)
        Shipfromaddress2Label.Name = "Shipfromaddress2Label"
        Shipfromaddress2Label.Size = New System.Drawing.Size(55, 13)
        Shipfromaddress2Label.TabIndex = 18
        Shipfromaddress2Label.Text = "Address 2"
        '
        'ShipfromcityLabel
        '
        ShipfromcityLabel.AutoSize = True
        ShipfromcityLabel.Location = New System.Drawing.Point(10, 109)
        ShipfromcityLabel.Name = "ShipfromcityLabel"
        ShipfromcityLabel.Size = New System.Drawing.Size(72, 13)
        ShipfromcityLabel.TabIndex = 20
        ShipfromcityLabel.Text = "City State Zip"
        '
        'ShipfromcontactLabel
        '
        ShipfromcontactLabel.AutoSize = True
        ShipfromcontactLabel.Location = New System.Drawing.Point(10, 135)
        ShipfromcontactLabel.Name = "ShipfromcontactLabel"
        ShipfromcontactLabel.Size = New System.Drawing.Size(75, 13)
        ShipfromcontactLabel.TabIndex = 24
        ShipfromcontactLabel.Text = "Contact Name"
        '
        'ShipfromphoneLabel
        '
        ShipfromphoneLabel.AutoSize = True
        ShipfromphoneLabel.Location = New System.Drawing.Point(10, 161)
        ShipfromphoneLabel.Name = "ShipfromphoneLabel"
        ShipfromphoneLabel.Size = New System.Drawing.Size(77, 13)
        ShipfromphoneLabel.TabIndex = 26
        ShipfromphoneLabel.Text = "Phone Number"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(10, 161)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(77, 13)
        Label1.TabIndex = 26
        Label1.Text = "Phone Number"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(10, 31)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 14
        Label2.Text = "Company"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 135)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(75, 13)
        Label3.TabIndex = 24
        Label3.Text = "Contact Name"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(10, 57)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(55, 13)
        Label4.TabIndex = 16
        Label4.Text = "Address 1"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(10, 83)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 13)
        Label5.TabIndex = 18
        Label5.Text = "Address 2"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(10, 109)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(72, 13)
        Label6.TabIndex = 20
        Label6.Text = "City State Zip"
        '
        'CustomerpoLabel
        '
        CustomerpoLabel.AutoSize = True
        CustomerpoLabel.Location = New System.Drawing.Point(596, 36)
        CustomerpoLabel.Name = "CustomerpoLabel"
        CustomerpoLabel.Size = New System.Drawing.Size(70, 13)
        CustomerpoLabel.TabIndex = 30
        CustomerpoLabel.Text = "Customer PO"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(7, 109)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(35, 13)
        CommentsLabel.TabIndex = 11
        CommentsLabel.Text = "Notes"
        '
        'bsFOB
        '
        Me.bsFOB.DataSource = GetType(AOS.BusinessObjects.ListFobCollection)
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
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnAddShipmentItem, Me.btnEditShipmentItem, Me.btnDeleteShipmentItem, Me.btnPrintBOL})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 10
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1022, 94)
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
        'btnAddShipmentItem
        '
        Me.btnAddShipmentItem.Caption = "Add New Item"
        Me.btnAddShipmentItem.Id = 2
        Me.btnAddShipmentItem.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddShipmentItem.Name = "btnAddShipmentItem"
        '
        'btnEditShipmentItem
        '
        Me.btnEditShipmentItem.Caption = "Edit Item"
        Me.btnEditShipmentItem.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditShipmentItem.Id = 3
        Me.btnEditShipmentItem.Name = "btnEditShipmentItem"
        '
        'btnDeleteShipmentItem
        '
        Me.btnDeleteShipmentItem.Caption = "Delete Item"
        Me.btnDeleteShipmentItem.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteShipmentItem.Id = 4
        Me.btnDeleteShipmentItem.Name = "btnDeleteShipmentItem"
        '
        'btnPrintBOL
        '
        Me.btnPrintBOL.Caption = "Print BOL"
        Me.btnPrintBOL.Glyph = Global.AOS.My.Resources.Resources.proforma_print
        Me.btnPrintBOL.Id = 9
        Me.btnPrintBOL.LargeGlyph = Global.AOS.My.Resources.Resources.proforma_print
        Me.btnPrintBOL.Name = "btnPrintBOL"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddShipmentItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditShipmentItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeleteShipmentItem)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Shipment Items"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnPrintBOL)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Reports"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 94)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1022, 680)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl4.Controls.Add(Me.grShipmentItems)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 286)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1022, 394)
        Me.GroupControl4.TabIndex = 6
        Me.GroupControl4.Text = "Work Order Items"
        '
        'grShipmentItems
        '
        Me.grShipmentItems.DataSource = Me.bsShipmentDetails
        Me.grShipmentItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grShipmentItems.Location = New System.Drawing.Point(0, 0)
        Me.grShipmentItems.MainView = Me.GridView1
        Me.grShipmentItems.Name = "grShipmentItems"
        Me.grShipmentItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1})
        Me.grShipmentItems.Size = New System.Drawing.Size(1022, 394)
        Me.grShipmentItems.TabIndex = 4
        Me.grShipmentItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsShipmentDetails
        '
        Me.bsShipmentDetails.DataSource = GetType(AOS.BusinessObjects.ShipmentdetailCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colShipmentdetailid, Me.colShipmentnumber, Me.colQtycontainers, Me.colContainer, Me.colProductid, Me.colProductdesc, Me.colTotalweight, Me.colBatchnumber, Me.colStdweight, Me.colStdgallons, Me.colDotdesc, Me.colHazmatdesc, Me.colUnline, Me.colClassrate, Me.colLd1, Me.colLd2, Me.colLd3, Me.colBillable, Me.colWorkorderitemnumber, Me.GridColumn1})
        Me.GridView1.GridControl = Me.grShipmentItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colShipmentdetailid
        '
        Me.colShipmentdetailid.FieldName = "Shipmentdetailid"
        Me.colShipmentdetailid.Name = "colShipmentdetailid"
        '
        'colShipmentnumber
        '
        Me.colShipmentnumber.FieldName = "Shipmentnumber"
        Me.colShipmentnumber.Name = "colShipmentnumber"
        '
        'colQtycontainers
        '
        Me.colQtycontainers.Caption = "Qty"
        Me.colQtycontainers.FieldName = "Qtycontainers"
        Me.colQtycontainers.Name = "colQtycontainers"
        Me.colQtycontainers.Visible = True
        Me.colQtycontainers.VisibleIndex = 1
        Me.colQtycontainers.Width = 55
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 2
        Me.colContainer.Width = 102
        '
        'colProductid
        '
        Me.colProductid.Caption = "Product ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 3
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 4
        Me.colProductdesc.Width = 398
        '
        'colTotalweight
        '
        Me.colTotalweight.Caption = "Weight"
        Me.colTotalweight.FieldName = "Totalweight"
        Me.colTotalweight.Name = "colTotalweight"
        Me.colTotalweight.Visible = True
        Me.colTotalweight.VisibleIndex = 5
        Me.colTotalweight.Width = 59
        '
        'colBatchnumber
        '
        Me.colBatchnumber.Caption = "Lot Number"
        Me.colBatchnumber.FieldName = "Batchnumber"
        Me.colBatchnumber.Name = "colBatchnumber"
        Me.colBatchnumber.Visible = True
        Me.colBatchnumber.VisibleIndex = 6
        Me.colBatchnumber.Width = 195
        '
        'colStdweight
        '
        Me.colStdweight.FieldName = "Stdweight"
        Me.colStdweight.Name = "colStdweight"
        '
        'colStdgallons
        '
        Me.colStdgallons.FieldName = "Stdgallons"
        Me.colStdgallons.Name = "colStdgallons"
        '
        'colDotdesc
        '
        Me.colDotdesc.FieldName = "Dotdesc"
        Me.colDotdesc.Name = "colDotdesc"
        '
        'colHazmatdesc
        '
        Me.colHazmatdesc.FieldName = "Hazmatdesc"
        Me.colHazmatdesc.Name = "colHazmatdesc"
        '
        'colUnline
        '
        Me.colUnline.FieldName = "Unline"
        Me.colUnline.Name = "colUnline"
        '
        'colClassrate
        '
        Me.colClassrate.FieldName = "Classrate"
        Me.colClassrate.Name = "colClassrate"
        '
        'colLd1
        '
        Me.colLd1.FieldName = "Ld1"
        Me.colLd1.Name = "colLd1"
        '
        'colLd2
        '
        Me.colLd2.FieldName = "Ld2"
        Me.colLd2.Name = "colLd2"
        '
        'colLd3
        '
        Me.colLd3.FieldName = "Ld3"
        Me.colLd3.Name = "colLd3"
        '
        'colBillable
        '
        Me.colBillable.FieldName = "Billable"
        Me.colBillable.Name = "colBillable"
        Me.colBillable.Visible = True
        Me.colBillable.VisibleIndex = 7
        Me.colBillable.Width = 90
        '
        'colWorkorderitemnumber
        '
        Me.colWorkorderitemnumber.FieldName = "Workorderitemnumber"
        Me.colWorkorderitemnumber.Name = "colWorkorderitemnumber"
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Type"
        Me.GridColumn1.FieldName = "Itemtype"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 32
        '
        'luProductDesc
        '
        Me.luProductDesc.AutoHeight = False
        Me.luProductDesc.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luProductDesc.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
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
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Desc2"
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
        Me.PanelControl2.Size = New System.Drawing.Size(1022, 286)
        Me.PanelControl2.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(KeepfromfreezingLabel)
        Me.GroupControl1.Controls.Add(Me.KeepfromfreezingCheckEdit)
        Me.GroupControl1.Controls.Add(CustomerpoLabel)
        Me.GroupControl1.Controls.Add(Me.CustomerpoTextEdit)
        Me.GroupControl1.Controls.Add(Me.GroupControl5)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Controls.Add(CustidLabel)
        Me.GroupControl1.Controls.Add(Me.luCustomerID)
        Me.GroupControl1.Controls.Add(ShipmentstatusLabel)
        Me.GroupControl1.Controls.Add(Me.ShipmentstatusTextEdit)
        Me.GroupControl1.Controls.Add(ShipmentdateLabel)
        Me.GroupControl1.Controls.Add(Me.ShipmentdateDateEdit)
        Me.GroupControl1.Controls.Add(ShipmentnumberLabel)
        Me.GroupControl1.Controls.Add(Me.ShipmentnumberTextEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1022, 286)
        Me.GroupControl1.TabIndex = 23
        Me.GroupControl1.Text = "Shipment Information"
        '
        'CustomerpoTextEdit
        '
        Me.CustomerpoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Customerpo", True))
        Me.CustomerpoTextEdit.Location = New System.Drawing.Point(672, 33)
        Me.CustomerpoTextEdit.MenuManager = Me.RibbonControl1
        Me.CustomerpoTextEdit.Name = "CustomerpoTextEdit"
        Me.CustomerpoTextEdit.Size = New System.Drawing.Size(96, 20)
        Me.CustomerpoTextEdit.TabIndex = 1
        '
        'bsShipment
        '
        Me.bsShipment.DataSource = GetType(AOS.BusinessObjects.Shipment)
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.CheckEdit2)
        Me.GroupControl5.Controls.Add(CommentsLabel)
        Me.GroupControl5.Controls.Add(Me.FreightcarrierLookUpEdit)
        Me.GroupControl5.Controls.Add(FreightcarrierLabel)
        Me.GroupControl5.Controls.Add(Me.LogisticsidLookUpEdit)
        Me.GroupControl5.Controls.Add(LogisticsidLabel)
        Me.GroupControl5.Controls.Add(Me.FobLookUpEdit)
        Me.GroupControl5.Controls.Add(FobLabel)
        Me.GroupControl5.Controls.Add(Me.CommentsTextEdit)
        Me.GroupControl5.Location = New System.Drawing.Point(726, 74)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(280, 191)
        Me.GroupControl5.TabIndex = 30
        Me.GroupControl5.Text = "Shipping Instructions"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Placardssupplied", True))
        Me.CheckEdit2.Location = New System.Drawing.Point(153, 81)
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.CheckEdit2.Properties.Appearance.Options.UseForeColor = True
        Me.CheckEdit2.Properties.Caption = "Placards Supplied"
        Me.CheckEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit2.Properties.LookAndFeel.SkinName = "Money Twins"
        Me.CheckEdit2.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit2.Properties.ValueChecked = "YES"
        Me.CheckEdit2.Properties.ValueGrayed = "NO"
        Me.CheckEdit2.Properties.ValueUnchecked = "NO"
        Me.CheckEdit2.Size = New System.Drawing.Size(113, 19)
        Me.CheckEdit2.TabIndex = 3
        '
        'FreightcarrierLookUpEdit
        '
        Me.FreightcarrierLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Carrierid", True))
        Me.FreightcarrierLookUpEdit.Location = New System.Drawing.Point(60, 28)
        Me.FreightcarrierLookUpEdit.MenuManager = Me.RibbonControl1
        Me.FreightcarrierLookUpEdit.Name = "FreightcarrierLookUpEdit"
        Me.FreightcarrierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.FreightcarrierLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.FreightcarrierLookUpEdit.Properties.DataSource = Me.bsCarriers
        Me.FreightcarrierLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.FreightcarrierLookUpEdit.Properties.NullText = ""
        Me.FreightcarrierLookUpEdit.Properties.ValueMember = "CarrierID"
        Me.FreightcarrierLookUpEdit.Size = New System.Drawing.Size(206, 20)
        Me.FreightcarrierLookUpEdit.TabIndex = 0
        '
        'LogisticsidLookUpEdit
        '
        Me.LogisticsidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Logisticsid", True))
        Me.LogisticsidLookUpEdit.Location = New System.Drawing.Point(60, 54)
        Me.LogisticsidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.LogisticsidLookUpEdit.Name = "LogisticsidLookUpEdit"
        Me.LogisticsidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.LogisticsidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsname", "Logistics Provider", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LogisticsidLookUpEdit.Properties.DataSource = Me.bsLogistics
        Me.LogisticsidLookUpEdit.Properties.DisplayMember = "Logisticsname"
        Me.LogisticsidLookUpEdit.Properties.NullText = ""
        Me.LogisticsidLookUpEdit.Properties.ValueMember = "Logisticsid"
        Me.LogisticsidLookUpEdit.Size = New System.Drawing.Size(206, 20)
        Me.LogisticsidLookUpEdit.TabIndex = 1
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'FobLookUpEdit
        '
        Me.FobLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Fob", True))
        Me.FobLookUpEdit.Location = New System.Drawing.Point(60, 80)
        Me.FobLookUpEdit.MenuManager = Me.RibbonControl1
        Me.FobLookUpEdit.Name = "FobLookUpEdit"
        Me.FobLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FobLookUpEdit.Properties.DataSource = Me.bsFOB
        Me.FobLookUpEdit.Properties.DisplayMember = "FOBOption"
        Me.FobLookUpEdit.Properties.NullText = ""
        Me.FobLookUpEdit.Properties.ValueMember = "FOBOption"
        Me.FobLookUpEdit.Size = New System.Drawing.Size(87, 20)
        Me.FobLookUpEdit.TabIndex = 2
        '
        'CommentsTextEdit
        '
        Me.CommentsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Comments", True))
        Me.CommentsTextEdit.Location = New System.Drawing.Point(60, 106)
        Me.CommentsTextEdit.MenuManager = Me.RibbonControl1
        Me.CommentsTextEdit.Name = "CommentsTextEdit"
        Me.CommentsTextEdit.Size = New System.Drawing.Size(206, 72)
        Me.CommentsTextEdit.TabIndex = 4
        Me.CommentsTextEdit.UseOptimizedRendering = True
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.TextEdit1)
        Me.GroupControl3.Controls.Add(Label1)
        Me.GroupControl3.Controls.Add(Me.luShipToID)
        Me.GroupControl3.Controls.Add(Label2)
        Me.GroupControl3.Controls.Add(Label3)
        Me.GroupControl3.Controls.Add(Me.TextEdit2)
        Me.GroupControl3.Controls.Add(Me.TextEdit3)
        Me.GroupControl3.Controls.Add(Label4)
        Me.GroupControl3.Controls.Add(Me.TextEdit4)
        Me.GroupControl3.Controls.Add(Me.TextEdit5)
        Me.GroupControl3.Controls.Add(Me.TextEdit6)
        Me.GroupControl3.Controls.Add(Label5)
        Me.GroupControl3.Controls.Add(Label6)
        Me.GroupControl3.Controls.Add(Me.TextEdit7)
        Me.GroupControl3.Location = New System.Drawing.Point(372, 74)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(348, 191)
        Me.GroupControl3.TabIndex = 29
        Me.GroupControl3.Text = "Shipping To"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shiptophone", True))
        Me.TextEdit1.Location = New System.Drawing.Point(94, 158)
        Me.TextEdit1.MenuManager = Me.RibbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(132, 20)
        Me.TextEdit1.TabIndex = 7
        '
        'luShipToID
        '
        Me.luShipToID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shiptoid", True))
        Me.luShipToID.Location = New System.Drawing.Point(94, 28)
        Me.luShipToID.MenuManager = Me.RibbonControl1
        Me.luShipToID.Name = "luShipToID"
        Me.luShipToID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.luShipToID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshippostalcode", "Zipcode", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luShipToID.Properties.DataSource = Me.bsShippingTo
        Me.luShipToID.Properties.DisplayMember = "Custname"
        Me.luShipToID.Properties.NullText = ""
        Me.luShipToID.Properties.PopupWidth = 425
        Me.luShipToID.Properties.ValueMember = "Custid"
        Me.luShipToID.Size = New System.Drawing.Size(240, 20)
        Me.luShipToID.TabIndex = 0
        '
        'bsShippingTo
        '
        Me.bsShippingTo.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shiptoaddress1", True))
        Me.TextEdit2.Location = New System.Drawing.Point(94, 54)
        Me.TextEdit2.MenuManager = Me.RibbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(240, 20)
        Me.TextEdit2.TabIndex = 1
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shiptocontact", True))
        Me.TextEdit3.Location = New System.Drawing.Point(94, 132)
        Me.TextEdit3.MenuManager = Me.RibbonControl1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(240, 20)
        Me.TextEdit3.TabIndex = 6
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shiptopostalcode", True))
        Me.TextEdit4.Location = New System.Drawing.Point(266, 106)
        Me.TextEdit4.MenuManager = Me.RibbonControl1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(68, 20)
        Me.TextEdit4.TabIndex = 5
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shiptoaddress2", True))
        Me.TextEdit5.Location = New System.Drawing.Point(94, 80)
        Me.TextEdit5.MenuManager = Me.RibbonControl1
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(240, 20)
        Me.TextEdit5.TabIndex = 2
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shiptostateprov", True))
        Me.TextEdit6.Location = New System.Drawing.Point(232, 106)
        Me.TextEdit6.MenuManager = Me.RibbonControl1
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(28, 20)
        Me.TextEdit6.TabIndex = 4
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shiptocity", True))
        Me.TextEdit7.Location = New System.Drawing.Point(94, 106)
        Me.TextEdit7.MenuManager = Me.RibbonControl1
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(132, 20)
        Me.TextEdit7.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.ShipfromphoneTextEdit)
        Me.GroupControl2.Controls.Add(ShipfromphoneLabel)
        Me.GroupControl2.Controls.Add(Me.luShipFromID)
        Me.GroupControl2.Controls.Add(ShipfromidLabel)
        Me.GroupControl2.Controls.Add(ShipfromcontactLabel)
        Me.GroupControl2.Controls.Add(Me.Shipfromaddress1TextEdit)
        Me.GroupControl2.Controls.Add(Me.ShipfromcontactTextEdit)
        Me.GroupControl2.Controls.Add(Shipfromaddress1Label)
        Me.GroupControl2.Controls.Add(Me.ShipfrompostalcodeTextEdit)
        Me.GroupControl2.Controls.Add(Me.Shipfromaddress2TextEdit)
        Me.GroupControl2.Controls.Add(Me.ShipfromstateprovTextEdit)
        Me.GroupControl2.Controls.Add(Shipfromaddress2Label)
        Me.GroupControl2.Controls.Add(ShipfromcityLabel)
        Me.GroupControl2.Controls.Add(Me.ShipfromcityTextEdit)
        Me.GroupControl2.Location = New System.Drawing.Point(18, 74)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(348, 191)
        Me.GroupControl2.TabIndex = 28
        Me.GroupControl2.Text = "Shipping From"
        '
        'ShipfromphoneTextEdit
        '
        Me.ShipfromphoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipfromphone", True))
        Me.ShipfromphoneTextEdit.Location = New System.Drawing.Point(94, 158)
        Me.ShipfromphoneTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipfromphoneTextEdit.Name = "ShipfromphoneTextEdit"
        Me.ShipfromphoneTextEdit.Size = New System.Drawing.Size(132, 20)
        Me.ShipfromphoneTextEdit.TabIndex = 7
        '
        'luShipFromID
        '
        Me.luShipFromID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipfromid", True))
        Me.luShipFromID.Location = New System.Drawing.Point(94, 28)
        Me.luShipFromID.MenuManager = Me.RibbonControl1
        Me.luShipFromID.Name = "luShipFromID"
        Me.luShipFromID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
        Me.luShipFromID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshippostalcode", "Zipcode", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luShipFromID.Properties.DataSource = Me.bsShippingFrom
        Me.luShipFromID.Properties.DisplayMember = "Custname"
        Me.luShipFromID.Properties.NullText = ""
        Me.luShipFromID.Properties.PopupWidth = 425
        Me.luShipFromID.Properties.ValueMember = "Custid"
        Me.luShipFromID.Size = New System.Drawing.Size(240, 20)
        Me.luShipFromID.TabIndex = 0
        '
        'bsShippingFrom
        '
        Me.bsShippingFrom.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'Shipfromaddress1TextEdit
        '
        Me.Shipfromaddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipfromaddress1", True))
        Me.Shipfromaddress1TextEdit.Location = New System.Drawing.Point(94, 54)
        Me.Shipfromaddress1TextEdit.MenuManager = Me.RibbonControl1
        Me.Shipfromaddress1TextEdit.Name = "Shipfromaddress1TextEdit"
        Me.Shipfromaddress1TextEdit.Size = New System.Drawing.Size(240, 20)
        Me.Shipfromaddress1TextEdit.TabIndex = 1
        '
        'ShipfromcontactTextEdit
        '
        Me.ShipfromcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipfromcontact", True))
        Me.ShipfromcontactTextEdit.Location = New System.Drawing.Point(94, 132)
        Me.ShipfromcontactTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipfromcontactTextEdit.Name = "ShipfromcontactTextEdit"
        Me.ShipfromcontactTextEdit.Size = New System.Drawing.Size(240, 20)
        Me.ShipfromcontactTextEdit.TabIndex = 6
        '
        'ShipfrompostalcodeTextEdit
        '
        Me.ShipfrompostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipfrompostalcode", True))
        Me.ShipfrompostalcodeTextEdit.Location = New System.Drawing.Point(266, 106)
        Me.ShipfrompostalcodeTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipfrompostalcodeTextEdit.Name = "ShipfrompostalcodeTextEdit"
        Me.ShipfrompostalcodeTextEdit.Size = New System.Drawing.Size(68, 20)
        Me.ShipfrompostalcodeTextEdit.TabIndex = 5
        '
        'Shipfromaddress2TextEdit
        '
        Me.Shipfromaddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipfromaddress2", True))
        Me.Shipfromaddress2TextEdit.Location = New System.Drawing.Point(94, 80)
        Me.Shipfromaddress2TextEdit.MenuManager = Me.RibbonControl1
        Me.Shipfromaddress2TextEdit.Name = "Shipfromaddress2TextEdit"
        Me.Shipfromaddress2TextEdit.Size = New System.Drawing.Size(240, 20)
        Me.Shipfromaddress2TextEdit.TabIndex = 2
        '
        'ShipfromstateprovTextEdit
        '
        Me.ShipfromstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipfromstateprov", True))
        Me.ShipfromstateprovTextEdit.Location = New System.Drawing.Point(232, 106)
        Me.ShipfromstateprovTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipfromstateprovTextEdit.Name = "ShipfromstateprovTextEdit"
        Me.ShipfromstateprovTextEdit.Size = New System.Drawing.Size(28, 20)
        Me.ShipfromstateprovTextEdit.TabIndex = 4
        '
        'ShipfromcityTextEdit
        '
        Me.ShipfromcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipfromcity", True))
        Me.ShipfromcityTextEdit.Location = New System.Drawing.Point(94, 106)
        Me.ShipfromcityTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipfromcityTextEdit.Name = "ShipfromcityTextEdit"
        Me.ShipfromcityTextEdit.Size = New System.Drawing.Size(132, 20)
        Me.ShipfromcityTextEdit.TabIndex = 3
        '
        'luCustomerID
        '
        Me.luCustomerID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Custid", True))
        Me.luCustomerID.Location = New System.Drawing.Point(388, 33)
        Me.luCustomerID.MenuManager = Me.RibbonControl1
        Me.luCustomerID.Name = "luCustomerID"
        Me.luCustomerID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luCustomerID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcountry", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luCustomerID.Properties.DataSource = Me.bsCustomers
        Me.luCustomerID.Properties.DisplayMember = "Custname"
        Me.luCustomerID.Properties.NullText = ""
        Me.luCustomerID.Properties.PopupWidth = 350
        Me.luCustomerID.Properties.ReadOnly = True
        Me.luCustomerID.Properties.ValueMember = "Custid"
        Me.luCustomerID.Size = New System.Drawing.Size(202, 20)
        Me.luCustomerID.TabIndex = 13
        Me.luCustomerID.TabStop = False
        '
        'ShipmentstatusTextEdit
        '
        Me.ShipmentstatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipmentstatus", True))
        Me.ShipmentstatusTextEdit.Location = New System.Drawing.Point(934, 33)
        Me.ShipmentstatusTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipmentstatusTextEdit.Name = "ShipmentstatusTextEdit"
        Me.ShipmentstatusTextEdit.Properties.ReadOnly = True
        Me.ShipmentstatusTextEdit.Size = New System.Drawing.Size(72, 20)
        Me.ShipmentstatusTextEdit.TabIndex = 5
        Me.ShipmentstatusTextEdit.TabStop = False
        '
        'ShipmentdateDateEdit
        '
        Me.ShipmentdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipmentdate", True))
        Me.ShipmentdateDateEdit.EditValue = Nothing
        Me.ShipmentdateDateEdit.Location = New System.Drawing.Point(236, 33)
        Me.ShipmentdateDateEdit.MenuManager = Me.RibbonControl1
        Me.ShipmentdateDateEdit.Name = "ShipmentdateDateEdit"
        Me.ShipmentdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipmentdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ShipmentdateDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.ShipmentdateDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.ShipmentdateDateEdit.Size = New System.Drawing.Size(87, 20)
        Me.ShipmentdateDateEdit.TabIndex = 0
        '
        'ShipmentnumberTextEdit
        '
        Me.ShipmentnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Shipmentnumber", True))
        Me.ShipmentnumberTextEdit.Location = New System.Drawing.Point(83, 33)
        Me.ShipmentnumberTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipmentnumberTextEdit.Name = "ShipmentnumberTextEdit"
        Me.ShipmentnumberTextEdit.Properties.ReadOnly = True
        Me.ShipmentnumberTextEdit.Size = New System.Drawing.Size(70, 20)
        Me.ShipmentnumberTextEdit.TabIndex = 1
        Me.ShipmentnumberTextEdit.TabStop = False
        '
        'bsShipmentItems
        '
        Me.bsShipmentItems.DataSource = GetType(AOS.BusinessObjects.ShipmentitemCollection)
        '
        'KeepfromfreezingLabel
        '
        KeepfromfreezingLabel.AutoSize = True
        KeepfromfreezingLabel.Location = New System.Drawing.Point(783, 36)
        KeepfromfreezingLabel.Name = "KeepfromfreezingLabel"
        KeepfromfreezingLabel.Size = New System.Drawing.Size(78, 13)
        KeepfromfreezingLabel.TabIndex = 30
        KeepfromfreezingLabel.Text = "Freeze Protect"
        '
        'KeepfromfreezingCheckEdit
        '
        Me.KeepfromfreezingCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsShipment, "Keepfromfreezing", True))
        Me.KeepfromfreezingCheckEdit.Location = New System.Drawing.Point(859, 33)
        Me.KeepfromfreezingCheckEdit.MenuManager = Me.RibbonControl1
        Me.KeepfromfreezingCheckEdit.Name = "KeepfromfreezingCheckEdit"
        Me.KeepfromfreezingCheckEdit.Properties.Caption = ""
        Me.KeepfromfreezingCheckEdit.Size = New System.Drawing.Size(25, 19)
        Me.KeepfromfreezingCheckEdit.TabIndex = 31
        '
        'frmAddEditShipment
        '
        Me.ClientSize = New System.Drawing.Size(1022, 774)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditShipment"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Shipment Information"
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grShipmentItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShipmentDetails, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.CustomerpoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FreightcarrierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticsidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luShipToID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShippingTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.ShipfromphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luShipFromID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShippingFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipfromaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipfromcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipfrompostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipfromaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipfromstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipfromcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luCustomerID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentstatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShipmentItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KeepfromfreezingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsFOB As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grShipmentItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents luProductDesc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luContainer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents luStdgallons As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddShipmentItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditShipmentItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteShipmentItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents bsShipment As System.Windows.Forms.BindingSource
    Friend WithEvents bsShipmentItems As System.Windows.Forms.BindingSource
    Friend WithEvents FobLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LogisticsidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FreightcarrierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ShipmentstatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipmentdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ShipmentnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ShipfromphoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luShipFromID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsShippingFrom As System.Windows.Forms.BindingSource
    Friend WithEvents Shipfromaddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipfromcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipfrompostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Shipfromaddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipfromstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipfromcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luCustomerID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsShippingTo As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents luShipToID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustomerpoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CommentsTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btnPrintBOL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsShipmentDetails As System.Windows.Forms.BindingSource
    Friend WithEvents colShipmentdetailid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtycontainers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBatchnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdgallons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDotdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnline As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassrate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLd3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkorderitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KeepfromfreezingCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
