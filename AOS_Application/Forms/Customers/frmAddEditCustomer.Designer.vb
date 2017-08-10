<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditCustomer

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
        Dim CustnameLabel As System.Windows.Forms.Label
        Dim Custshipaddress1Label As System.Windows.Forms.Label
        Dim Custshipaddress2Label As System.Windows.Forms.Label
        Dim CustshipcityLabel As System.Windows.Forms.Label
        Dim CustshipcontactLabel As System.Windows.Forms.Label
        Dim CustshipcountryLabel As System.Windows.Forms.Label
        Dim CustbillcontactLabel As System.Windows.Forms.Label
        Dim CustphoneLabel As System.Windows.Forms.Label
        Dim CustfaxLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim BulkcarrieridLabel As System.Windows.Forms.Label
        Dim CarrieridLabel As System.Windows.Forms.Label
        Dim FobLabel1 As System.Windows.Forms.Label
        Dim LogisticsidLabel As System.Windows.Forms.Label
        Dim SalespersonidLabel As System.Windows.Forms.Label
        Dim IsactiveLabel As System.Windows.Forms.Label
        Dim FreightbillcustomerLabel As System.Windows.Forms.Label
        Dim FreightoninvoiceLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim CustemailLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditCustomer))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustnameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Custshipaddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Custshipaddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshipcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshipstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshippostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshipcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshipcountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Custbilladdress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Custbilladdress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustbillcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustbillstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustbillpostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustbillcountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustbillcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustphoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustfaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustnotesMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.grpShipping = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsSalespersons = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalespersonidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.chkTaxExempt = New DevExpress.XtraEditors.CheckEdit()
        Me.IsactiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.FreightoninvoiceCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FreightbillcustomerCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FobLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsFOB = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarrieridLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogisticsidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.BulkcarrieridLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsBulkCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.MemoEdit4 = New DevExpress.XtraEditors.MemoEdit()
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit()
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblModified = New DevExpress.XtraEditors.LabelControl()
        Me.lblCreated = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.bsSalespersons2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.TrendanalysisreportCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.SalesbycustomerreportCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.chkIsConsignment = New DevExpress.XtraEditors.CheckEdit()
        CustidLabel = New System.Windows.Forms.Label()
        CustnameLabel = New System.Windows.Forms.Label()
        Custshipaddress1Label = New System.Windows.Forms.Label()
        Custshipaddress2Label = New System.Windows.Forms.Label()
        CustshipcityLabel = New System.Windows.Forms.Label()
        CustshipcontactLabel = New System.Windows.Forms.Label()
        CustshipcountryLabel = New System.Windows.Forms.Label()
        CustbillcontactLabel = New System.Windows.Forms.Label()
        CustphoneLabel = New System.Windows.Forms.Label()
        CustfaxLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        BulkcarrieridLabel = New System.Windows.Forms.Label()
        CarrieridLabel = New System.Windows.Forms.Label()
        FobLabel1 = New System.Windows.Forms.Label()
        LogisticsidLabel = New System.Windows.Forms.Label()
        SalespersonidLabel = New System.Windows.Forms.Label()
        IsactiveLabel = New System.Windows.Forms.Label()
        FreightbillcustomerLabel = New System.Windows.Forms.Label()
        FreightoninvoiceLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CustemailLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Custshipaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Custshipaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshipcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshipstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshippostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshipcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshipcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Custbilladdress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Custbilladdress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustbillcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustbillstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustbillpostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustbillcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustbillcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustfaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustnotesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpShipping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpShipping.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalespersons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalespersonidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkTaxExempt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.FreightoninvoiceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FreightbillcustomerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticsidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulkcarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBulkCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.MemoEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalespersons2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.TrendanalysisreportCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesbycustomerreportCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chkIsConsignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(8, 26)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(67, 13)
        CustidLabel.TabIndex = 1
        CustidLabel.Text = "Customer ID"
        '
        'CustnameLabel
        '
        CustnameLabel.AutoSize = True
        CustnameLabel.Location = New System.Drawing.Point(8, 53)
        CustnameLabel.Name = "CustnameLabel"
        CustnameLabel.Size = New System.Drawing.Size(34, 13)
        CustnameLabel.TabIndex = 3
        CustnameLabel.Text = "Name"
        '
        'Custshipaddress1Label
        '
        Custshipaddress1Label.AutoSize = True
        Custshipaddress1Label.Location = New System.Drawing.Point(8, 28)
        Custshipaddress1Label.Name = "Custshipaddress1Label"
        Custshipaddress1Label.Size = New System.Drawing.Size(55, 13)
        Custshipaddress1Label.TabIndex = 5
        Custshipaddress1Label.Text = "Address 1"
        '
        'Custshipaddress2Label
        '
        Custshipaddress2Label.AutoSize = True
        Custshipaddress2Label.Location = New System.Drawing.Point(8, 53)
        Custshipaddress2Label.Name = "Custshipaddress2Label"
        Custshipaddress2Label.Size = New System.Drawing.Size(55, 13)
        Custshipaddress2Label.TabIndex = 7
        Custshipaddress2Label.Text = "Address 2"
        '
        'CustshipcityLabel
        '
        CustshipcityLabel.AutoSize = True
        CustshipcityLabel.Location = New System.Drawing.Point(8, 79)
        CustshipcityLabel.Name = "CustshipcityLabel"
        CustshipcityLabel.Size = New System.Drawing.Size(72, 13)
        CustshipcityLabel.TabIndex = 9
        CustshipcityLabel.Text = "City State Zip"
        '
        'CustshipcontactLabel
        '
        CustshipcontactLabel.AutoSize = True
        CustshipcontactLabel.Location = New System.Drawing.Point(286, 105)
        CustshipcontactLabel.Name = "CustshipcontactLabel"
        CustshipcontactLabel.Size = New System.Drawing.Size(45, 13)
        CustshipcontactLabel.TabIndex = 15
        CustshipcontactLabel.Text = "Contact"
        '
        'CustshipcountryLabel
        '
        CustshipcountryLabel.AutoSize = True
        CustshipcountryLabel.Location = New System.Drawing.Point(8, 105)
        CustshipcountryLabel.Name = "CustshipcountryLabel"
        CustshipcountryLabel.Size = New System.Drawing.Size(46, 13)
        CustshipcountryLabel.TabIndex = 17
        CustshipcountryLabel.Text = "Country"
        '
        'CustbillcontactLabel
        '
        CustbillcontactLabel.AutoSize = True
        CustbillcontactLabel.Location = New System.Drawing.Point(286, 105)
        CustbillcontactLabel.Name = "CustbillcontactLabel"
        CustbillcontactLabel.Size = New System.Drawing.Size(45, 13)
        CustbillcontactLabel.TabIndex = 31
        CustbillcontactLabel.Text = "Contact"
        '
        'CustphoneLabel
        '
        CustphoneLabel.AutoSize = True
        CustphoneLabel.Location = New System.Drawing.Point(8, 28)
        CustphoneLabel.Name = "CustphoneLabel"
        CustphoneLabel.Size = New System.Drawing.Size(77, 13)
        CustphoneLabel.TabIndex = 33
        CustphoneLabel.Text = "Phone Number"
        '
        'CustfaxLabel
        '
        CustfaxLabel.AutoSize = True
        CustfaxLabel.Location = New System.Drawing.Point(305, 28)
        CustfaxLabel.Name = "CustfaxLabel"
        CustfaxLabel.Size = New System.Drawing.Size(26, 13)
        CustfaxLabel.TabIndex = 35
        CustfaxLabel.Text = "FAX"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(5, 104)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(46, 13)
        Label1.TabIndex = 48
        Label1.Text = "Country"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(5, 78)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(72, 13)
        Label2.TabIndex = 47
        Label2.Text = "City State Zip"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(5, 53)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 13)
        Label3.TabIndex = 46
        Label3.Text = "Address 2"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(5, 27)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(55, 13)
        Label4.TabIndex = 45
        Label4.Text = "Address 1"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(5, 30)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(75, 13)
        Label5.TabIndex = 45
        Label5.Text = "General Notes"
        '
        'BulkcarrieridLabel
        '
        BulkcarrieridLabel.AutoSize = True
        BulkcarrieridLabel.Location = New System.Drawing.Point(9, 131)
        BulkcarrieridLabel.Name = "BulkcarrieridLabel"
        BulkcarrieridLabel.Size = New System.Drawing.Size(62, 13)
        BulkcarrieridLabel.TabIndex = 56
        BulkcarrieridLabel.Text = "Bulk Carrier"
        '
        'CarrieridLabel
        '
        CarrieridLabel.AutoSize = True
        CarrieridLabel.Location = New System.Drawing.Point(8, 105)
        CarrieridLabel.Name = "CarrieridLabel"
        CarrieridLabel.Size = New System.Drawing.Size(69, 13)
        CarrieridLabel.TabIndex = 57
        CarrieridLabel.Text = "Truck Carrier"
        '
        'FobLabel1
        '
        FobLabel1.AutoSize = True
        FobLabel1.Location = New System.Drawing.Point(8, 30)
        FobLabel1.Name = "FobLabel1"
        FobLabel1.Size = New System.Drawing.Size(84, 13)
        FobLabel1.TabIndex = 58
        FobLabel1.Text = "Freight Charges"
        '
        'LogisticsidLabel
        '
        LogisticsidLabel.AutoSize = True
        LogisticsidLabel.Location = New System.Drawing.Point(8, 56)
        LogisticsidLabel.Name = "LogisticsidLabel"
        LogisticsidLabel.Size = New System.Drawing.Size(47, 13)
        LogisticsidLabel.TabIndex = 59
        LogisticsidLabel.Text = "Logistics"
        '
        'SalespersonidLabel
        '
        SalespersonidLabel.AutoSize = True
        SalespersonidLabel.Location = New System.Drawing.Point(732, 29)
        SalespersonidLabel.Name = "SalespersonidLabel"
        SalespersonidLabel.Size = New System.Drawing.Size(93, 13)
        SalespersonidLabel.TabIndex = 60
        SalespersonidLabel.Text = "Primary Sales Rep"
        '
        'IsactiveLabel
        '
        IsactiveLabel.AutoSize = True
        IsactiveLabel.Location = New System.Drawing.Point(914, 4)
        IsactiveLabel.Name = "IsactiveLabel"
        IsactiveLabel.Size = New System.Drawing.Size(37, 13)
        IsactiveLabel.TabIndex = 61
        IsactiveLabel.Text = "Active"
        '
        'FreightbillcustomerLabel
        '
        FreightbillcustomerLabel.AutoSize = True
        FreightbillcustomerLabel.Location = New System.Drawing.Point(8, 80)
        FreightbillcustomerLabel.Name = "FreightbillcustomerLabel"
        FreightbillcustomerLabel.Size = New System.Drawing.Size(80, 13)
        FreightbillcustomerLabel.TabIndex = 60
        FreightbillcustomerLabel.Text = "Customer Billed"
        '
        'FreightoninvoiceLabel
        '
        FreightoninvoiceLabel.AutoSize = True
        FreightoninvoiceLabel.Location = New System.Drawing.Point(118, 80)
        FreightoninvoiceLabel.Name = "FreightoninvoiceLabel"
        FreightoninvoiceLabel.Size = New System.Drawing.Size(198, 13)
        FreightoninvoiceLabel.TabIndex = 61
        FreightoninvoiceLabel.Text = "Add Freight Charges to Americo Invoice"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(5, 83)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(58, 13)
        Label6.TabIndex = 49
        Label6.Text = "Production"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(5, 143)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(78, 13)
        Label7.TabIndex = 50
        Label7.Text = "Transportation"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(5, 202)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(60, 13)
        Label8.TabIndex = 51
        Label8.Text = "Accounting"
        '
        'CustemailLabel
        '
        CustemailLabel.AutoSize = True
        CustemailLabel.Location = New System.Drawing.Point(8, 54)
        CustemailLabel.Name = "CustemailLabel"
        CustemailLabel.Size = New System.Drawing.Size(73, 13)
        CustemailLabel.TabIndex = 0
        CustemailLabel.Text = "Email Address"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(717, 52)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(108, 13)
        Label9.TabIndex = 63
        Label9.Text = "Secondary Sales Rep"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(5, 259)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(66, 13)
        Label10.TabIndex = 53
        Label10.Text = "Bill of Lading"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(994, 96)
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
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 0
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 1
        Me.btnCancel.Name = "btnCancel"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
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
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Customer)
        '
        'CustidTextEdit
        '
        Me.CustidTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custid", True))
        Me.CustidTextEdit.Location = New System.Drawing.Point(100, 23)
        Me.CustidTextEdit.Name = "CustidTextEdit"
        Me.CustidTextEdit.Properties.ReadOnly = True
        Me.CustidTextEdit.Size = New System.Drawing.Size(46, 20)
        Me.CustidTextEdit.TabIndex = 2
        Me.CustidTextEdit.TabStop = False
        '
        'CustnameTextEdit
        '
        Me.CustnameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custname", True))
        Me.CustnameTextEdit.Location = New System.Drawing.Point(100, 49)
        Me.CustnameTextEdit.Name = "CustnameTextEdit"
        Me.CustnameTextEdit.Size = New System.Drawing.Size(379, 20)
        Me.CustnameTextEdit.TabIndex = 0
        '
        'Custshipaddress1TextEdit
        '
        Me.Custshipaddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custshipaddress1", True))
        Me.Custshipaddress1TextEdit.Location = New System.Drawing.Point(100, 24)
        Me.Custshipaddress1TextEdit.Name = "Custshipaddress1TextEdit"
        Me.Custshipaddress1TextEdit.Size = New System.Drawing.Size(379, 20)
        Me.Custshipaddress1TextEdit.TabIndex = 0
        '
        'Custshipaddress2TextEdit
        '
        Me.Custshipaddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custshipaddress2", True))
        Me.Custshipaddress2TextEdit.Location = New System.Drawing.Point(100, 50)
        Me.Custshipaddress2TextEdit.Name = "Custshipaddress2TextEdit"
        Me.Custshipaddress2TextEdit.Size = New System.Drawing.Size(379, 20)
        Me.Custshipaddress2TextEdit.TabIndex = 1
        '
        'CustshipcityTextEdit
        '
        Me.CustshipcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custshipcity", True))
        Me.CustshipcityTextEdit.Location = New System.Drawing.Point(100, 76)
        Me.CustshipcityTextEdit.Name = "CustshipcityTextEdit"
        Me.CustshipcityTextEdit.Size = New System.Drawing.Size(231, 20)
        Me.CustshipcityTextEdit.TabIndex = 2
        '
        'CustshipstateprovTextEdit
        '
        Me.CustshipstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custshipstateprov", True))
        Me.CustshipstateprovTextEdit.Location = New System.Drawing.Point(337, 76)
        Me.CustshipstateprovTextEdit.Name = "CustshipstateprovTextEdit"
        Me.CustshipstateprovTextEdit.Size = New System.Drawing.Size(36, 20)
        Me.CustshipstateprovTextEdit.TabIndex = 3
        '
        'CustshippostalcodeTextEdit
        '
        Me.CustshippostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custshippostalcode", True))
        Me.CustshippostalcodeTextEdit.Location = New System.Drawing.Point(379, 76)
        Me.CustshippostalcodeTextEdit.Name = "CustshippostalcodeTextEdit"
        Me.CustshippostalcodeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CustshippostalcodeTextEdit.TabIndex = 4
        '
        'CustshipcontactTextEdit
        '
        Me.CustshipcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custshipcontact", True))
        Me.CustshipcontactTextEdit.Location = New System.Drawing.Point(337, 102)
        Me.CustshipcontactTextEdit.Name = "CustshipcontactTextEdit"
        Me.CustshipcontactTextEdit.Size = New System.Drawing.Size(142, 20)
        Me.CustshipcontactTextEdit.TabIndex = 6
        '
        'CustshipcountryTextEdit
        '
        Me.CustshipcountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custshipcountry", True))
        Me.CustshipcountryTextEdit.Location = New System.Drawing.Point(100, 102)
        Me.CustshipcountryTextEdit.Name = "CustshipcountryTextEdit"
        Me.CustshipcountryTextEdit.Size = New System.Drawing.Size(147, 20)
        Me.CustshipcountryTextEdit.TabIndex = 5
        '
        'Custbilladdress1TextEdit
        '
        Me.Custbilladdress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custbilladdress1", True))
        Me.Custbilladdress1TextEdit.Location = New System.Drawing.Point(100, 24)
        Me.Custbilladdress1TextEdit.Name = "Custbilladdress1TextEdit"
        Me.Custbilladdress1TextEdit.Size = New System.Drawing.Size(379, 20)
        Me.Custbilladdress1TextEdit.TabIndex = 0
        '
        'Custbilladdress2TextEdit
        '
        Me.Custbilladdress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custbilladdress2", True))
        Me.Custbilladdress2TextEdit.Location = New System.Drawing.Point(100, 50)
        Me.Custbilladdress2TextEdit.Name = "Custbilladdress2TextEdit"
        Me.Custbilladdress2TextEdit.Size = New System.Drawing.Size(379, 20)
        Me.Custbilladdress2TextEdit.TabIndex = 1
        '
        'CustbillcityTextEdit
        '
        Me.CustbillcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custbillcity", True))
        Me.CustbillcityTextEdit.Location = New System.Drawing.Point(100, 76)
        Me.CustbillcityTextEdit.Name = "CustbillcityTextEdit"
        Me.CustbillcityTextEdit.Size = New System.Drawing.Size(231, 20)
        Me.CustbillcityTextEdit.TabIndex = 2
        '
        'CustbillstateprovTextEdit
        '
        Me.CustbillstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custbillstateprov", True))
        Me.CustbillstateprovTextEdit.Location = New System.Drawing.Point(339, 76)
        Me.CustbillstateprovTextEdit.Name = "CustbillstateprovTextEdit"
        Me.CustbillstateprovTextEdit.Size = New System.Drawing.Size(36, 20)
        Me.CustbillstateprovTextEdit.TabIndex = 3
        '
        'CustbillpostalcodeTextEdit
        '
        Me.CustbillpostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custbillpostalcode", True))
        Me.CustbillpostalcodeTextEdit.Location = New System.Drawing.Point(381, 76)
        Me.CustbillpostalcodeTextEdit.Name = "CustbillpostalcodeTextEdit"
        Me.CustbillpostalcodeTextEdit.Size = New System.Drawing.Size(98, 20)
        Me.CustbillpostalcodeTextEdit.TabIndex = 4
        '
        'CustbillcountryTextEdit
        '
        Me.CustbillcountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custbillcountry", True))
        Me.CustbillcountryTextEdit.Location = New System.Drawing.Point(100, 102)
        Me.CustbillcountryTextEdit.Name = "CustbillcountryTextEdit"
        Me.CustbillcountryTextEdit.Size = New System.Drawing.Size(147, 20)
        Me.CustbillcountryTextEdit.TabIndex = 5
        '
        'CustbillcontactTextEdit
        '
        Me.CustbillcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custbillcontact", True))
        Me.CustbillcontactTextEdit.Location = New System.Drawing.Point(339, 102)
        Me.CustbillcontactTextEdit.Name = "CustbillcontactTextEdit"
        Me.CustbillcontactTextEdit.Size = New System.Drawing.Size(140, 20)
        Me.CustbillcontactTextEdit.TabIndex = 6
        '
        'CustphoneTextEdit
        '
        Me.CustphoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custphone", True))
        Me.CustphoneTextEdit.Location = New System.Drawing.Point(100, 25)
        Me.CustphoneTextEdit.Name = "CustphoneTextEdit"
        Me.CustphoneTextEdit.Size = New System.Drawing.Size(147, 20)
        Me.CustphoneTextEdit.TabIndex = 1
        '
        'CustfaxTextEdit
        '
        Me.CustfaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custfax", True))
        Me.CustfaxTextEdit.Location = New System.Drawing.Point(337, 25)
        Me.CustfaxTextEdit.Name = "CustfaxTextEdit"
        Me.CustfaxTextEdit.Size = New System.Drawing.Size(142, 20)
        Me.CustfaxTextEdit.TabIndex = 2
        '
        'CustnotesMemoEdit
        '
        Me.CustnotesMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custnotes", True))
        Me.CustnotesMemoEdit.Location = New System.Drawing.Point(100, 27)
        Me.CustnotesMemoEdit.Name = "CustnotesMemoEdit"
        Me.CustnotesMemoEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.CustnotesMemoEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.CustnotesMemoEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.CustnotesMemoEdit.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.CustnotesMemoEdit.Size = New System.Drawing.Size(379, 46)
        Me.CustnotesMemoEdit.TabIndex = 0
        Me.CustnotesMemoEdit.UseOptimizedRendering = True
        '
        'grpShipping
        '
        Me.grpShipping.Controls.Add(Me.Custshipaddress1TextEdit)
        Me.grpShipping.Controls.Add(Custshipaddress1Label)
        Me.grpShipping.Controls.Add(Me.Custshipaddress2TextEdit)
        Me.grpShipping.Controls.Add(Custshipaddress2Label)
        Me.grpShipping.Controls.Add(Me.CustshipcityTextEdit)
        Me.grpShipping.Controls.Add(CustshipcityLabel)
        Me.grpShipping.Controls.Add(Me.CustshipstateprovTextEdit)
        Me.grpShipping.Controls.Add(Me.CustshippostalcodeTextEdit)
        Me.grpShipping.Controls.Add(Me.CustshipcontactTextEdit)
        Me.grpShipping.Controls.Add(CustshipcontactLabel)
        Me.grpShipping.Controls.Add(Me.CustshipcountryTextEdit)
        Me.grpShipping.Controls.Add(CustshipcountryLabel)
        Me.grpShipping.Location = New System.Drawing.Point(3, 183)
        Me.grpShipping.Name = "grpShipping"
        Me.grpShipping.Size = New System.Drawing.Size(486, 131)
        Me.grpShipping.TabIndex = 49
        Me.grpShipping.Text = "Shipping Address"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.Custbilladdress1TextEdit)
        Me.GroupControl1.Controls.Add(Me.Custbilladdress2TextEdit)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.CustbillcityTextEdit)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Me.CustbillstateprovTextEdit)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Me.CustbillpostalcodeTextEdit)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Me.CustbillcountryTextEdit)
        Me.GroupControl1.Controls.Add(Me.CustbillcontactTextEdit)
        Me.GroupControl1.Controls.Add(CustbillcontactLabel)
        Me.GroupControl1.Location = New System.Drawing.Point(495, 184)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(486, 130)
        Me.GroupControl1.TabIndex = 50
        Me.GroupControl1.Text = "Billing Address"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.chkIsConsignment)
        Me.GroupControl2.Controls.Add(Me.LookUpEdit1)
        Me.GroupControl2.Controls.Add(Label9)
        Me.GroupControl2.Controls.Add(Me.SalespersonidLookUpEdit)
        Me.GroupControl2.Controls.Add(SalespersonidLabel)
        Me.GroupControl2.Controls.Add(IsactiveLabel)
        Me.GroupControl2.Controls.Add(Me.chkTaxExempt)
        Me.GroupControl2.Controls.Add(Me.IsactiveCheckEdit)
        Me.GroupControl2.Controls.Add(Me.CustidTextEdit)
        Me.GroupControl2.Controls.Add(CustidLabel)
        Me.GroupControl2.Controls.Add(Me.CustnameTextEdit)
        Me.GroupControl2.Controls.Add(CustnameLabel)
        Me.GroupControl2.Location = New System.Drawing.Point(3, 100)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(978, 77)
        Me.GroupControl2.TabIndex = 39
        Me.GroupControl2.Text = "Customer"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Secondarysalespersonid", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(831, 49)
        Me.LookUpEdit1.MenuManager = Me.RibbonControl1
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Salespersonfullname", "Salesperson Name", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit1.Properties.DataSource = Me.bsSalespersons
        Me.LookUpEdit1.Properties.DisplayMember = "Salespersonfullname"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.PopupSizeable = False
        Me.LookUpEdit1.Properties.PopupWidth = 140
        Me.LookUpEdit1.Properties.ValueMember = "Salespersonid"
        Me.LookUpEdit1.Size = New System.Drawing.Size(140, 20)
        Me.LookUpEdit1.TabIndex = 62
        '
        'bsSalespersons
        '
        Me.bsSalespersons.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'SalespersonidLookUpEdit
        '
        Me.SalespersonidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Salespersonid", True))
        Me.SalespersonidLookUpEdit.Location = New System.Drawing.Point(831, 26)
        Me.SalespersonidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.SalespersonidLookUpEdit.Name = "SalespersonidLookUpEdit"
        Me.SalespersonidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SalespersonidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Salespersonfullname", "Salesperson Name", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.SalespersonidLookUpEdit.Properties.DataSource = Me.bsSalespersons
        Me.SalespersonidLookUpEdit.Properties.DisplayMember = "Salespersonfullname"
        Me.SalespersonidLookUpEdit.Properties.NullText = ""
        Me.SalespersonidLookUpEdit.Properties.PopupSizeable = False
        Me.SalespersonidLookUpEdit.Properties.PopupWidth = 140
        Me.SalespersonidLookUpEdit.Properties.ValueMember = "Salespersonid"
        Me.SalespersonidLookUpEdit.Size = New System.Drawing.Size(140, 20)
        Me.SalespersonidLookUpEdit.TabIndex = 3
        '
        'chkTaxExempt
        '
        Me.chkTaxExempt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Taxexempt", True))
        Me.chkTaxExempt.Location = New System.Drawing.Point(395, 23)
        Me.chkTaxExempt.MenuManager = Me.RibbonControl1
        Me.chkTaxExempt.Name = "chkTaxExempt"
        Me.chkTaxExempt.Properties.Caption = "Tax Exempt"
        Me.chkTaxExempt.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkTaxExempt.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.chkTaxExempt.Properties.ValueChecked = "1"
        Me.chkTaxExempt.Properties.ValueUnchecked = "0"
        Me.chkTaxExempt.Size = New System.Drawing.Size(84, 19)
        Me.chkTaxExempt.TabIndex = 5
        '
        'IsactiveCheckEdit
        '
        Me.IsactiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Isactive", True))
        Me.IsactiveCheckEdit.Location = New System.Drawing.Point(953, 1)
        Me.IsactiveCheckEdit.MenuManager = Me.RibbonControl1
        Me.IsactiveCheckEdit.Name = "IsactiveCheckEdit"
        Me.IsactiveCheckEdit.Properties.Caption = ""
        Me.IsactiveCheckEdit.Size = New System.Drawing.Size(21, 19)
        Me.IsactiveCheckEdit.TabIndex = 4
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.FreightoninvoiceCheckEdit)
        Me.GroupControl3.Controls.Add(FreightbillcustomerLabel)
        Me.GroupControl3.Controls.Add(Me.FreightbillcustomerCheckEdit)
        Me.GroupControl3.Controls.Add(FobLabel1)
        Me.GroupControl3.Controls.Add(LogisticsidLabel)
        Me.GroupControl3.Controls.Add(Me.FobLookUpEdit)
        Me.GroupControl3.Controls.Add(Me.CarrieridLookUpEdit)
        Me.GroupControl3.Controls.Add(Me.LogisticsidLookUpEdit)
        Me.GroupControl3.Controls.Add(CarrieridLabel)
        Me.GroupControl3.Controls.Add(Me.BulkcarrieridLookUpEdit)
        Me.GroupControl3.Controls.Add(BulkcarrieridLabel)
        Me.GroupControl3.Controls.Add(FreightoninvoiceLabel)
        Me.GroupControl3.Location = New System.Drawing.Point(3, 320)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(486, 165)
        Me.GroupControl3.TabIndex = 52
        Me.GroupControl3.Text = "Transportation Information - Defaults"
        '
        'FreightoninvoiceCheckEdit
        '
        Me.FreightoninvoiceCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Freightoninvoice", True))
        Me.FreightoninvoiceCheckEdit.Location = New System.Drawing.Point(315, 77)
        Me.FreightoninvoiceCheckEdit.MenuManager = Me.RibbonControl1
        Me.FreightoninvoiceCheckEdit.Name = "FreightoninvoiceCheckEdit"
        Me.FreightoninvoiceCheckEdit.Properties.Caption = ""
        Me.FreightoninvoiceCheckEdit.Size = New System.Drawing.Size(20, 19)
        Me.FreightoninvoiceCheckEdit.TabIndex = 3
        '
        'FreightbillcustomerCheckEdit
        '
        Me.FreightbillcustomerCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Freightbillcustomer", True))
        Me.FreightbillcustomerCheckEdit.Location = New System.Drawing.Point(98, 77)
        Me.FreightbillcustomerCheckEdit.MenuManager = Me.RibbonControl1
        Me.FreightbillcustomerCheckEdit.Name = "FreightbillcustomerCheckEdit"
        Me.FreightbillcustomerCheckEdit.Properties.Caption = ""
        Me.FreightbillcustomerCheckEdit.Size = New System.Drawing.Size(21, 19)
        Me.FreightbillcustomerCheckEdit.TabIndex = 2
        '
        'FobLookUpEdit
        '
        Me.FobLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Fob", True))
        Me.FobLookUpEdit.Location = New System.Drawing.Point(100, 27)
        Me.FobLookUpEdit.MenuManager = Me.RibbonControl1
        Me.FobLookUpEdit.Name = "FobLookUpEdit"
        Me.FobLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.FobLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FOBOption", "FOB", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.FobLookUpEdit.Properties.DataSource = Me.bsFOB
        Me.FobLookUpEdit.Properties.DisplayMember = "FOBOption"
        Me.FobLookUpEdit.Properties.NullText = ""
        Me.FobLookUpEdit.Properties.PopupWidth = 100
        Me.FobLookUpEdit.Properties.ValueMember = "FOBOption"
        Me.FobLookUpEdit.Size = New System.Drawing.Size(147, 20)
        Me.FobLookUpEdit.TabIndex = 0
        '
        'bsFOB
        '
        Me.bsFOB.DataSource = GetType(AOS.BusinessObjects.ListFobCollection)
        '
        'CarrieridLookUpEdit
        '
        Me.CarrieridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Carrierid", True))
        Me.CarrieridLookUpEdit.Location = New System.Drawing.Point(100, 102)
        Me.CarrieridLookUpEdit.MenuManager = Me.RibbonControl1
        Me.CarrieridLookUpEdit.Name = "CarrieridLookUpEdit"
        Me.CarrieridLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.CarrieridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CarrieridLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierID", "ID", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 160, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierCity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierState", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CarrieridLookUpEdit.Properties.DataSource = Me.bsCarriers
        Me.CarrieridLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.CarrieridLookUpEdit.Properties.NullText = ""
        Me.CarrieridLookUpEdit.Properties.PopupWidth = 350
        Me.CarrieridLookUpEdit.Properties.ValueMember = "CarrierID"
        Me.CarrieridLookUpEdit.Size = New System.Drawing.Size(231, 20)
        Me.CarrieridLookUpEdit.TabIndex = 4
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'LogisticsidLookUpEdit
        '
        Me.LogisticsidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Logisticsid", True))
        Me.LogisticsidLookUpEdit.Location = New System.Drawing.Point(100, 53)
        Me.LogisticsidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.LogisticsidLookUpEdit.Name = "LogisticsidLookUpEdit"
        Me.LogisticsidLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.LogisticsidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LogisticsidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsid", "ID", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsname", "Logistics Provider", 160, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LogisticsidLookUpEdit.Properties.DataSource = Me.bsLogistics
        Me.LogisticsidLookUpEdit.Properties.DisplayMember = "Logisticsname"
        Me.LogisticsidLookUpEdit.Properties.NullText = ""
        Me.LogisticsidLookUpEdit.Properties.PopupWidth = 200
        Me.LogisticsidLookUpEdit.Properties.ValueMember = "Logisticsid"
        Me.LogisticsidLookUpEdit.Size = New System.Drawing.Size(231, 20)
        Me.LogisticsidLookUpEdit.TabIndex = 1
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'BulkcarrieridLookUpEdit
        '
        Me.BulkcarrieridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Bulkcarrierid", True))
        Me.BulkcarrieridLookUpEdit.Location = New System.Drawing.Point(100, 128)
        Me.BulkcarrieridLookUpEdit.MenuManager = Me.RibbonControl1
        Me.BulkcarrieridLookUpEdit.Name = "BulkcarrieridLookUpEdit"
        Me.BulkcarrieridLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.BulkcarrieridLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.BulkcarrieridLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierID", "ID", 40, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 160, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierCity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierState", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.BulkcarrieridLookUpEdit.Properties.DataSource = Me.bsBulkCarriers
        Me.BulkcarrieridLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.BulkcarrieridLookUpEdit.Properties.NullText = ""
        Me.BulkcarrieridLookUpEdit.Properties.PopupWidth = 350
        Me.BulkcarrieridLookUpEdit.Properties.ValueMember = "CarrierID"
        Me.BulkcarrieridLookUpEdit.Size = New System.Drawing.Size(231, 20)
        Me.BulkcarrieridLookUpEdit.TabIndex = 5
        '
        'bsBulkCarriers
        '
        Me.bsBulkCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Label10)
        Me.GroupControl4.Controls.Add(Me.MemoEdit4)
        Me.GroupControl4.Controls.Add(Label8)
        Me.GroupControl4.Controls.Add(Label7)
        Me.GroupControl4.Controls.Add(Label6)
        Me.GroupControl4.Controls.Add(Me.MemoEdit3)
        Me.GroupControl4.Controls.Add(Me.MemoEdit2)
        Me.GroupControl4.Controls.Add(Me.MemoEdit1)
        Me.GroupControl4.Controls.Add(Label5)
        Me.GroupControl4.Controls.Add(Me.CustnotesMemoEdit)
        Me.GroupControl4.Location = New System.Drawing.Point(495, 320)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(487, 306)
        Me.GroupControl4.TabIndex = 53
        Me.GroupControl4.Text = "Notes"
        '
        'MemoEdit4
        '
        Me.MemoEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Accountingnotes", True))
        Me.MemoEdit4.Location = New System.Drawing.Point(100, 199)
        Me.MemoEdit4.Name = "MemoEdit4"
        Me.MemoEdit4.Properties.Appearance.Options.UseTextOptions = True
        Me.MemoEdit4.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.MemoEdit4.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.MemoEdit4.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.MemoEdit4.Size = New System.Drawing.Size(379, 51)
        Me.MemoEdit4.TabIndex = 52
        Me.MemoEdit4.UseOptimizedRendering = True
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Billofladingnotes", True))
        Me.MemoEdit3.Location = New System.Drawing.Point(100, 256)
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Properties.Appearance.Options.UseTextOptions = True
        Me.MemoEdit3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.MemoEdit3.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.MemoEdit3.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.MemoEdit3.Size = New System.Drawing.Size(379, 42)
        Me.MemoEdit3.TabIndex = 48
        Me.MemoEdit3.UseOptimizedRendering = True
        '
        'MemoEdit2
        '
        Me.MemoEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Transportationnotes", True))
        Me.MemoEdit2.Location = New System.Drawing.Point(100, 140)
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Properties.Appearance.Options.UseTextOptions = True
        Me.MemoEdit2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.MemoEdit2.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.MemoEdit2.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.MemoEdit2.Size = New System.Drawing.Size(379, 53)
        Me.MemoEdit2.TabIndex = 47
        Me.MemoEdit2.UseOptimizedRendering = True
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Prodfulfillmentnotes", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(100, 80)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.Appearance.Options.UseTextOptions = True
        Me.MemoEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.MemoEdit1.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.MemoEdit1.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.MemoEdit1.Size = New System.Drawing.Size(379, 54)
        Me.MemoEdit1.TabIndex = 46
        Me.MemoEdit1.UseOptimizedRendering = True
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.lblModified)
        Me.PanelControl1.Controls.Add(Me.lblCreated)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 627)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(994, 28)
        Me.PanelControl1.TabIndex = 55
        '
        'lblModified
        '
        Me.lblModified.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblModified.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblModified.Location = New System.Drawing.Point(681, 6)
        Me.lblModified.Name = "lblModified"
        Me.lblModified.Size = New System.Drawing.Size(300, 13)
        Me.lblModified.TabIndex = 2
        Me.lblModified.Text = "Last Modified"
        '
        'lblCreated
        '
        Me.lblCreated.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCreated.Location = New System.Drawing.Point(3, 6)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(300, 13)
        Me.lblCreated.TabIndex = 1
        Me.lblCreated.Text = "Created"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.TextEdit1)
        Me.GroupControl5.Controls.Add(CustemailLabel)
        Me.GroupControl5.Controls.Add(Me.CustphoneTextEdit)
        Me.GroupControl5.Controls.Add(CustphoneLabel)
        Me.GroupControl5.Controls.Add(Me.CustfaxTextEdit)
        Me.GroupControl5.Controls.Add(CustfaxLabel)
        Me.GroupControl5.Location = New System.Drawing.Point(3, 491)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(486, 81)
        Me.GroupControl5.TabIndex = 57
        Me.GroupControl5.Text = "Communication Information"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Custemail", True))
        Me.TextEdit1.Location = New System.Drawing.Point(100, 51)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(379, 20)
        Me.TextEdit1.TabIndex = 1
        '
        'bsSalespersons2
        '
        Me.bsSalespersons2.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.TrendanalysisreportCheckEdit)
        Me.GroupControl6.Controls.Add(Me.SalesbycustomerreportCheckEdit)
        Me.GroupControl6.Location = New System.Drawing.Point(3, 578)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(486, 48)
        Me.GroupControl6.TabIndex = 59
        Me.GroupControl6.Text = "Reporting Settings"
        '
        'TrendanalysisreportCheckEdit
        '
        Me.TrendanalysisreportCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Trendanalysisreport", True))
        Me.TrendanalysisreportCheckEdit.Location = New System.Drawing.Point(172, 24)
        Me.TrendanalysisreportCheckEdit.MenuManager = Me.RibbonControl1
        Me.TrendanalysisreportCheckEdit.Name = "TrendanalysisreportCheckEdit"
        Me.TrendanalysisreportCheckEdit.Properties.Caption = "Trend Analysis Report"
        Me.TrendanalysisreportCheckEdit.Size = New System.Drawing.Size(144, 19)
        Me.TrendanalysisreportCheckEdit.TabIndex = 2
        '
        'SalesbycustomerreportCheckEdit
        '
        Me.SalesbycustomerreportCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Salesbycustomerreport", True))
        Me.SalesbycustomerreportCheckEdit.Location = New System.Drawing.Point(10, 24)
        Me.SalesbycustomerreportCheckEdit.MenuManager = Me.RibbonControl1
        Me.SalesbycustomerreportCheckEdit.Name = "SalesbycustomerreportCheckEdit"
        Me.SalesbycustomerreportCheckEdit.Properties.Caption = "Sales By Customer Report"
        Me.SalesbycustomerreportCheckEdit.Size = New System.Drawing.Size(177, 19)
        Me.SalesbycustomerreportCheckEdit.TabIndex = 1
        '
        'chkIsConsignment
        '
        Me.chkIsConsignment.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Isconsignment", True))
        Me.chkIsConsignment.Location = New System.Drawing.Point(275, 23)
        Me.chkIsConsignment.MenuManager = Me.RibbonControl1
        Me.chkIsConsignment.Name = "chkIsConsignment"
        Me.chkIsConsignment.Properties.Caption = "Consignment"
        Me.chkIsConsignment.Size = New System.Drawing.Size(98, 19)
        Me.chkIsConsignment.TabIndex = 64
        '
        'frmAddEditCustomer
        '
        Me.ClientSize = New System.Drawing.Size(994, 655)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl6)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.grpShipping)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditCustomer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Customer Information"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Custshipaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Custshipaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshipcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshipstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshippostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshipcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshipcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Custbilladdress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Custbilladdress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustbillcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustbillstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustbillpostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustbillcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustbillcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustfaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustnotesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpShipping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpShipping.ResumeLayout(False)
        Me.grpShipping.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalespersons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalespersonidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkTaxExempt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.FreightoninvoiceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FreightbillcustomerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FobLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFOB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticsidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulkcarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBulkCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.MemoEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalespersons2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.TrendanalysisreportCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesbycustomerreportCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chkIsConsignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents CustidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustnameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custshipaddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custshipaddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshippostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipcountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custbilladdress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custbilladdress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillpostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillcountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustphoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustfaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustnotesMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents grpShipping As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents chkTaxExempt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblCreated As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblModified As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SalespersonidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsSalespersons As System.Windows.Forms.BindingSource
    Friend WithEvents IsactiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FobLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsFOB As System.Windows.Forms.BindingSource
    Friend WithEvents CarrieridLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents LogisticsidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents BulkcarrieridLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsBulkCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents FreightoninvoiceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FreightbillcustomerCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents bsSalespersons2 As System.Windows.Forms.BindingSource
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SalesbycustomerreportCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TrendanalysisreportCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MemoEdit4 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents chkIsConsignment As DevExpress.XtraEditors.CheckEdit
End Class
