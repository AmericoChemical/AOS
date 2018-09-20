<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewAdministration

    'UserControl overrides dispose to clean up the component list.
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
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim CompanyAddressLabel As System.Windows.Forms.Label
        Dim CompanyCityLabel As System.Windows.Forms.Label
        Dim CompanyPhoneLabel As System.Windows.Forms.Label
        Dim CompanyFAXLabel As System.Windows.Forms.Label
        Dim CompanyCountryLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim StdlaborhourcostLabel As System.Windows.Forms.Label
        Dim FreezeWarningLabel As System.Windows.Forms.Label
        Dim CompanyEmailDomainLabel As System.Windows.Forms.Label
        Dim CompanyEmailServerLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim WorkOrderEmailSenderLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim ProdOrdEstCompDateCheckLabel As System.Windows.Forms.Label
        Dim AdditionalDefaultSendToAddressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewAdministration))
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSaveParms = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelParms = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditParameters = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditAuditLog = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditRelabelTemplateInstructions = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPallets = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnContainers = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnStandardCostReview = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnVendorCostReview = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnStandardCostApprovals = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAPISApprovals = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnVendorCostApprovals = New DevExpress.XtraBars.BarButtonItem()
        Me.rStartDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.rEndDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.rbtnGetCostChangePriceListData = New DevExpress.XtraBars.BarButtonItem()
        Me.rBtnExportCostPriceEffectsToExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsCostPricingEffects = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvCostPricingEffects = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProductID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangetype1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangedate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhychanged1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOldcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCostdelta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVolOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVolNew = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWgtOld = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWgtNew = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPricingmethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.gcChangeRecords = New DevExpress.XtraGrid.GridControl()
        Me.bsChangeRecords = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomDevExGridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colChangerecid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangetype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhochanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhenChanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhychanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatatablename1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatarecordid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriorvalue1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriorvalue1name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriorvalue2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriorvalue2name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriorvalue3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriorvalue3name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewvalue1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewvalue2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewvalue3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRecordstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.tabParameters = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.AdditionalDefaultSendToAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsParms = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdOrdEstCompDateCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AllowableWeightVariancePercentageTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkOrderEmailReceiverTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkOrderEmailSenderTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyEmailServerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyEmailDomainTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.FreezeWarningCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.StdlaborhourcostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyCountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyFAXTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyPhoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyZipcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyStateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyCityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.bsReviewRecords = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAuditLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AuditLogView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CompanyNameLabel = New System.Windows.Forms.Label()
        CompanyAddressLabel = New System.Windows.Forms.Label()
        CompanyCityLabel = New System.Windows.Forms.Label()
        CompanyPhoneLabel = New System.Windows.Forms.Label()
        CompanyFAXLabel = New System.Windows.Forms.Label()
        CompanyCountryLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        StdlaborhourcostLabel = New System.Windows.Forms.Label()
        FreezeWarningLabel = New System.Windows.Forms.Label()
        CompanyEmailDomainLabel = New System.Windows.Forms.Label()
        CompanyEmailServerLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        WorkOrderEmailSenderLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        ProdOrdEstCompDateCheckLabel = New System.Windows.Forms.Label()
        AdditionalDefaultSendToAddressLabel = New System.Windows.Forms.Label()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCostPricingEffects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCostPricingEffects, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.gcChangeRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsChangeRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.tabParameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabParameters.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.AdditionalDefaultSendToAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsParms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdOrdEstCompDateCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllowableWeightVariancePercentageTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkOrderEmailReceiverTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkOrderEmailSenderTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyEmailServerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyEmailDomainTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FreezeWarningCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StdlaborhourcostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyCountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyFAXTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyPhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyZipcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyCityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsReviewRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAuditLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditLogView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(107, 21)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(86, 13)
        CompanyNameLabel.TabIndex = 0
        CompanyNameLabel.Text = "Company Name:"
        '
        'CompanyAddressLabel
        '
        CompanyAddressLabel.AutoSize = True
        CompanyAddressLabel.Location = New System.Drawing.Point(95, 47)
        CompanyAddressLabel.Name = "CompanyAddressLabel"
        CompanyAddressLabel.Size = New System.Drawing.Size(98, 13)
        CompanyAddressLabel.TabIndex = 2
        CompanyAddressLabel.Text = "Company Address:"
        '
        'CompanyCityLabel
        '
        CompanyCityLabel.AutoSize = True
        CompanyCityLabel.Location = New System.Drawing.Point(85, 73)
        CompanyCityLabel.Name = "CompanyCityLabel"
        CompanyCityLabel.Size = New System.Drawing.Size(108, 13)
        CompanyCityLabel.TabIndex = 4
        CompanyCityLabel.Text = "Company City St Zip:"
        '
        'CompanyPhoneLabel
        '
        CompanyPhoneLabel.AutoSize = True
        CompanyPhoneLabel.Location = New System.Drawing.Point(104, 125)
        CompanyPhoneLabel.Name = "CompanyPhoneLabel"
        CompanyPhoneLabel.Size = New System.Drawing.Size(89, 13)
        CompanyPhoneLabel.TabIndex = 10
        CompanyPhoneLabel.Text = "Company Phone:"
        '
        'CompanyFAXLabel
        '
        CompanyFAXLabel.AutoSize = True
        CompanyFAXLabel.Location = New System.Drawing.Point(115, 151)
        CompanyFAXLabel.Name = "CompanyFAXLabel"
        CompanyFAXLabel.Size = New System.Drawing.Size(78, 13)
        CompanyFAXLabel.TabIndex = 12
        CompanyFAXLabel.Text = "Company FAX:"
        '
        'CompanyCountryLabel
        '
        CompanyCountryLabel.AutoSize = True
        CompanyCountryLabel.Location = New System.Drawing.Point(95, 99)
        CompanyCountryLabel.Name = "CompanyCountryLabel"
        CompanyCountryLabel.Size = New System.Drawing.Size(98, 13)
        CompanyCountryLabel.TabIndex = 8
        CompanyCountryLabel.Text = "Company Country:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(110, 336)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 13)
        Label1.TabIndex = 26
        Label1.Text = "Sales Tax Rate:"
        '
        'StdlaborhourcostLabel
        '
        StdlaborhourcostLabel.AutoSize = True
        StdlaborhourcostLabel.Location = New System.Drawing.Point(85, 362)
        StdlaborhourcostLabel.Name = "StdlaborhourcostLabel"
        StdlaborhourcostLabel.Size = New System.Drawing.Size(108, 13)
        StdlaborhourcostLabel.TabIndex = 28
        StdlaborhourcostLabel.Text = "Std Labor Hour Cost:"
        '
        'FreezeWarningLabel
        '
        FreezeWarningLabel.AutoSize = True
        FreezeWarningLabel.Location = New System.Drawing.Point(106, 386)
        FreezeWarningLabel.Name = "FreezeWarningLabel"
        FreezeWarningLabel.Size = New System.Drawing.Size(87, 13)
        FreezeWarningLabel.TabIndex = 30
        FreezeWarningLabel.Text = "Freeze Warning:"
        '
        'CompanyEmailDomainLabel
        '
        CompanyEmailDomainLabel.AutoSize = True
        CompanyEmailDomainLabel.Location = New System.Drawing.Point(72, 177)
        CompanyEmailDomainLabel.Name = "CompanyEmailDomainLabel"
        CompanyEmailDomainLabel.Size = New System.Drawing.Size(121, 13)
        CompanyEmailDomainLabel.TabIndex = 14
        CompanyEmailDomainLabel.Text = "Company Email Domain:"
        '
        'CompanyEmailServerLabel
        '
        CompanyEmailServerLabel.AutoSize = True
        CompanyEmailServerLabel.Location = New System.Drawing.Point(75, 203)
        CompanyEmailServerLabel.Name = "CompanyEmailServerLabel"
        CompanyEmailServerLabel.Size = New System.Drawing.Size(118, 13)
        CompanyEmailServerLabel.TabIndex = 16
        CompanyEmailServerLabel.Text = "Company Email Server:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(54, 256)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(139, 13)
        Label2.TabIndex = 20
        Label2.Text = "Work Order Email Receiver:"
        '
        'WorkOrderEmailSenderLabel
        '
        WorkOrderEmailSenderLabel.AutoSize = True
        WorkOrderEmailSenderLabel.Location = New System.Drawing.Point(62, 230)
        WorkOrderEmailSenderLabel.Name = "WorkOrderEmailSenderLabel"
        WorkOrderEmailSenderLabel.Size = New System.Drawing.Size(131, 13)
        WorkOrderEmailSenderLabel.TabIndex = 18
        WorkOrderEmailSenderLabel.Text = "Work Order Email Sender:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(58, 301)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(136, 26)
        Label3.TabIndex = 24
        Label3.Text = "Allowable Weight Variance " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                       Percentage:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ProdOrdEstCompDateCheckLabel
        '
        ProdOrdEstCompDateCheckLabel.AutoSize = True
        ProdOrdEstCompDateCheckLabel.Location = New System.Drawing.Point(35, 410)
        ProdOrdEstCompDateCheckLabel.Name = "ProdOrdEstCompDateCheckLabel"
        ProdOrdEstCompDateCheckLabel.Size = New System.Drawing.Size(159, 13)
        ProdOrdEstCompDateCheckLabel.TabIndex = 32
        ProdOrdEstCompDateCheckLabel.Text = "Set Prod Ord. Est. Comp. Date:"
        '
        'AdditionalDefaultSendToAddressLabel
        '
        AdditionalDefaultSendToAddressLabel.AutoSize = True
        AdditionalDefaultSendToAddressLabel.Location = New System.Drawing.Point(13, 282)
        AdditionalDefaultSendToAddressLabel.Name = "AdditionalDefaultSendToAddressLabel"
        AdditionalDefaultSendToAddressLabel.Size = New System.Drawing.Size(180, 13)
        AdditionalDefaultSendToAddressLabel.TabIndex = 22
        AdditionalDefaultSendToAddressLabel.Text = "Additional Default Send To Address:"
        '
        'FormCaption
        '
        Me.FormCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormCaption.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCaption.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.FormCaption.EmbeddedNavigator.Appearance.Options.UseTextOptions = True
        Me.FormCaption.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.FormCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCaption.Location = New System.Drawing.Point(0, 0)
        Me.FormCaption.LookAndFeel.SkinName = "Money Twins"
        Me.FormCaption.MainView = Me.GridView1
        Me.FormCaption.Name = "FormCaption"
        Me.FormCaption.Size = New System.Drawing.Size(1336, 33)
        Me.FormCaption.TabIndex = 3
        Me.FormCaption.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridView1.GridControl = Me.FormCaption
        Me.GridView1.GroupPanelText = "System Administration"
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.SmartVertScrollBar = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.FormCaption
        Me.GridView2.Name = "GridView2"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ApplicationCaption = "dsadsdsa"
        Me.RibbonControl1.ApplicationDocumentCaption = "dsdsadsa"
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSaveParms, Me.btnCancelParms, Me.rbtnEditParameters, Me.btnEditAuditLog, Me.rbtnEditRelabelTemplateInstructions, Me.rbtnPallets, Me.rbtnContainers, Me.rbtnStandardCostReview, Me.rbtnVendorCostReview, Me.rbtnStandardCostApprovals, Me.rbtnAPISApprovals, Me.rbtnVendorCostApprovals, Me.rStartDate, Me.rEndDate, Me.rbtnGetCostChangePriceListData, Me.rBtnExportCostPriceEffectsToExcel, Me.BarButtonItem1})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 70
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1336, 116)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSaveParms
        '
        Me.btnSaveParms.Caption = "Save"
        Me.btnSaveParms.Id = 51
        Me.btnSaveParms.ImageOptions.Image = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSaveParms.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSaveParms.Name = "btnSaveParms"
        '
        'btnCancelParms
        '
        Me.btnCancelParms.Caption = "Cancel"
        Me.btnCancelParms.Id = 52
        Me.btnCancelParms.ImageOptions.Image = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancelParms.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancelParms.Name = "btnCancelParms"
        '
        'rbtnEditParameters
        '
        Me.rbtnEditParameters.Caption = "Edit System Parameters"
        Me.rbtnEditParameters.Id = 54
        Me.rbtnEditParameters.ImageOptions.LargeImageIndex = 0
        Me.rbtnEditParameters.Name = "rbtnEditParameters"
        Me.rbtnEditParameters.Tag = "277"
        '
        'btnEditAuditLog
        '
        Me.btnEditAuditLog.Id = 55
        Me.btnEditAuditLog.Name = "btnEditAuditLog"
        '
        'rbtnEditRelabelTemplateInstructions
        '
        Me.rbtnEditRelabelTemplateInstructions.Caption = "Edit Relabel Template Instructions"
        Me.rbtnEditRelabelTemplateInstructions.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnEditRelabelTemplateInstructions.Id = 56
        Me.rbtnEditRelabelTemplateInstructions.ImageOptions.LargeImageIndex = 0
        Me.rbtnEditRelabelTemplateInstructions.Name = "rbtnEditRelabelTemplateInstructions"
        '
        'rbtnPallets
        '
        Me.rbtnPallets.Caption = "Edit Pallet List"
        Me.rbtnPallets.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPallets.Id = 57
        Me.rbtnPallets.ImageOptions.LargeImageIndex = 0
        Me.rbtnPallets.Name = "rbtnPallets"
        '
        'rbtnContainers
        '
        Me.rbtnContainers.Caption = "Edit Container List"
        Me.rbtnContainers.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnContainers.Id = 58
        Me.rbtnContainers.ImageOptions.LargeImageIndex = 0
        Me.rbtnContainers.Name = "rbtnContainers"
        '
        'rbtnStandardCostReview
        '
        Me.rbtnStandardCostReview.Caption = "Standard Costs"
        Me.rbtnStandardCostReview.Id = 59
        Me.rbtnStandardCostReview.ImageOptions.LargeImageIndex = 0
        Me.rbtnStandardCostReview.Name = "rbtnStandardCostReview"
        '
        'rbtnVendorCostReview
        '
        Me.rbtnVendorCostReview.Caption = "Vendor Costs"
        Me.rbtnVendorCostReview.Id = 61
        Me.rbtnVendorCostReview.ImageOptions.LargeImageIndex = 0
        Me.rbtnVendorCostReview.Name = "rbtnVendorCostReview"
        '
        'rbtnStandardCostApprovals
        '
        Me.rbtnStandardCostApprovals.Caption = "Standard Costs"
        Me.rbtnStandardCostApprovals.Id = 62
        Me.rbtnStandardCostApprovals.ImageOptions.LargeImageIndex = 1
        Me.rbtnStandardCostApprovals.Name = "rbtnStandardCostApprovals"
        '
        'rbtnAPISApprovals
        '
        Me.rbtnAPISApprovals.Caption = "APIS  Changes"
        Me.rbtnAPISApprovals.Id = 63
        Me.rbtnAPISApprovals.ImageOptions.LargeImageIndex = 1
        Me.rbtnAPISApprovals.Name = "rbtnAPISApprovals"
        '
        'rbtnVendorCostApprovals
        '
        Me.rbtnVendorCostApprovals.Caption = "Vendor Costs"
        Me.rbtnVendorCostApprovals.Id = 64
        Me.rbtnVendorCostApprovals.ImageOptions.LargeImageIndex = 1
        Me.rbtnVendorCostApprovals.Name = "rbtnVendorCostApprovals"
        '
        'rStartDate
        '
        Me.rStartDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.rStartDate.Caption = "Start Date  "
        Me.rStartDate.Edit = Me.RepositoryItemDateEdit1
        Me.rStartDate.EditWidth = 80
        Me.rStartDate.Id = 65
        Me.rStartDate.Name = "rStartDate"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'rEndDate
        '
        Me.rEndDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.rEndDate.Caption = "End Date    "
        Me.rEndDate.Edit = Me.RepositoryItemDateEdit2
        Me.rEndDate.EditWidth = 80
        Me.rEndDate.Id = 66
        Me.rEndDate.Name = "rEndDate"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'rbtnGetCostChangePriceListData
        '
        Me.rbtnGetCostChangePriceListData.Caption = "Get Pricing Data"
        Me.rbtnGetCostChangePriceListData.Id = 67
        Me.rbtnGetCostChangePriceListData.ImageOptions.LargeImageIndex = 5
        Me.rbtnGetCostChangePriceListData.Name = "rbtnGetCostChangePriceListData"
        '
        'rBtnExportCostPriceEffectsToExcel
        '
        Me.rBtnExportCostPriceEffectsToExcel.Caption = "Export to Excel"
        Me.rBtnExportCostPriceEffectsToExcel.Id = 68
        Me.rBtnExportCostPriceEffectsToExcel.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.export_excel
        Me.rBtnExportCostPriceEffectsToExcel.Name = "rBtnExportCostPriceEffectsToExcel"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Prime List"
        Me.BarButtonItem1.Id = 69
        Me.BarButtonItem1.ImageOptions.LargeImageIndex = 10
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "119"
        Me.RibbonPage1.Text = "Application Settings"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnEditParameters)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem1)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Parameters"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Operations Settings"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnEditRelabelTemplateInstructions)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Relabel Orders"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnPallets)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Pallets"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnContainers)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Containers"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup6})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Audit"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowMinimize = False
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnStandardCostReview)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnVendorCostReview)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Needing Review"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowMinimize = False
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnStandardCostApprovals)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnAPISApprovals)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnVendorCostApprovals)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Approvals"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup7, Me.RibbonPageGroup8})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Price/Cost Reporting"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowMinimize = False
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rStartDate)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rEndDate)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnGetCostChangePriceListData, True)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Record Selection"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.AllowMinimize = False
        Me.RibbonPageGroup8.AllowTextClipping = False
        Me.RibbonPageGroup8.ItemLinks.Add(Me.rBtnExportCostPriceEffectsToExcel)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Export"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'WorkPanelsHolder
        '
        Me.WorkPanelsHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 149)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1336, 572)
        Me.WorkPanelsHolder.TabIndex = 7
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Controls.Add(Me.GroupControl3)
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1336, 572)
        Me.RibbonPanelControl4.TabIndex = 3
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1320, 556)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Records Changed"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsCostPricingEffects
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.grvCostPricingEffects
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1316, 532)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCostPricingEffects})
        '
        'bsCostPricingEffects
        '
        Me.bsCostPricingEffects.DataSource = GetType(AOS.BusinessObjects.ViewCostPriceEffects2Collection)
        '
        'grvCostPricingEffects
        '
        Me.grvCostPricingEffects.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductID2, Me.colProductdesc3, Me.colChangetype1, Me.colChangedate, Me.colWhychanged1, Me.colOldcost, Me.colNewcost, Me.colCostdelta, Me.colVolOld, Me.colVolNew, Me.colWgtOld, Me.colWgtNew, Me.colCustname, Me.colSalesprice, Me.colPricingmethod, Me.colPer, Me.colContainer2, Me.GridColumn1})
        Me.grvCostPricingEffects.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.grvCostPricingEffects.GridControl = Me.GridControl1
        Me.grvCostPricingEffects.Name = "grvCostPricingEffects"
        Me.grvCostPricingEffects.OptionsBehavior.Editable = False
        Me.grvCostPricingEffects.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvCostPricingEffects.OptionsView.ShowAutoFilterRow = True
        Me.grvCostPricingEffects.OptionsView.ShowGroupPanel = False
        Me.grvCostPricingEffects.OptionsView.ShowIndicator = False
        '
        'colProductID2
        '
        Me.colProductID2.FieldName = "ProductID"
        Me.colProductID2.Name = "colProductID2"
        Me.colProductID2.Visible = True
        Me.colProductID2.VisibleIndex = 0
        Me.colProductID2.Width = 65
        '
        'colProductdesc3
        '
        Me.colProductdesc3.FieldName = "Productdesc"
        Me.colProductdesc3.Name = "colProductdesc3"
        Me.colProductdesc3.Visible = True
        Me.colProductdesc3.VisibleIndex = 1
        Me.colProductdesc3.Width = 240
        '
        'colChangetype1
        '
        Me.colChangetype1.FieldName = "Changetype"
        Me.colChangetype1.Name = "colChangetype1"
        Me.colChangetype1.Visible = True
        Me.colChangetype1.VisibleIndex = 3
        Me.colChangetype1.Width = 100
        '
        'colChangedate
        '
        Me.colChangedate.FieldName = "Changedate"
        Me.colChangedate.Name = "colChangedate"
        Me.colChangedate.Visible = True
        Me.colChangedate.VisibleIndex = 4
        Me.colChangedate.Width = 71
        '
        'colWhychanged1
        '
        Me.colWhychanged1.FieldName = "Whychanged"
        Me.colWhychanged1.Name = "colWhychanged1"
        Me.colWhychanged1.Visible = True
        Me.colWhychanged1.VisibleIndex = 5
        Me.colWhychanged1.Width = 103
        '
        'colOldcost
        '
        Me.colOldcost.FieldName = "Oldcost"
        Me.colOldcost.Name = "colOldcost"
        Me.colOldcost.Visible = True
        Me.colOldcost.VisibleIndex = 8
        Me.colOldcost.Width = 73
        '
        'colNewcost
        '
        Me.colNewcost.FieldName = "Newcost"
        Me.colNewcost.Name = "colNewcost"
        Me.colNewcost.Visible = True
        Me.colNewcost.VisibleIndex = 9
        Me.colNewcost.Width = 73
        '
        'colCostdelta
        '
        Me.colCostdelta.FieldName = "Costdelta"
        Me.colCostdelta.Name = "colCostdelta"
        Me.colCostdelta.Visible = True
        Me.colCostdelta.VisibleIndex = 10
        Me.colCostdelta.Width = 72
        '
        'colVolOld
        '
        Me.colVolOld.FieldName = "VolOld"
        Me.colVolOld.Name = "colVolOld"
        '
        'colVolNew
        '
        Me.colVolNew.FieldName = "VolNew"
        Me.colVolNew.Name = "colVolNew"
        '
        'colWgtOld
        '
        Me.colWgtOld.FieldName = "WgtOld"
        Me.colWgtOld.Name = "colWgtOld"
        '
        'colWgtNew
        '
        Me.colWgtNew.FieldName = "WgtNew"
        Me.colWgtNew.Name = "colWgtNew"
        '
        'colCustname
        '
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 12
        Me.colCustname.Width = 292
        '
        'colSalesprice
        '
        Me.colSalesprice.FieldName = "Salesprice"
        Me.colSalesprice.Name = "colSalesprice"
        Me.colSalesprice.Visible = True
        Me.colSalesprice.VisibleIndex = 11
        Me.colSalesprice.Width = 94
        '
        'colPricingmethod
        '
        Me.colPricingmethod.FieldName = "Pricingmethod"
        Me.colPricingmethod.Name = "colPricingmethod"
        Me.colPricingmethod.Width = 187
        '
        'colPer
        '
        Me.colPer.FieldName = "Per"
        Me.colPer.Name = "colPer"
        Me.colPer.Visible = True
        Me.colPer.VisibleIndex = 6
        Me.colPer.Width = 26
        '
        'colContainer2
        '
        Me.colContainer2.FieldName = "Container"
        Me.colContainer2.Name = "colContainer2"
        Me.colContainer2.Visible = True
        Me.colContainer2.VisibleIndex = 2
        Me.colContainer2.Width = 66
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "UOM"
        Me.GridColumn1.FieldName = "Uom"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 39
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.GroupControl1)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1336, 572)
        Me.RibbonPanelControl3.TabIndex = 2
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.gcChangeRecords)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1320, 556)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Records Changed"
        '
        'gcChangeRecords
        '
        Me.gcChangeRecords.DataSource = Me.bsChangeRecords
        Me.gcChangeRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcChangeRecords.Location = New System.Drawing.Point(2, 22)
        Me.gcChangeRecords.MainView = Me.CustomDevExGridView1
        Me.gcChangeRecords.MenuManager = Me.RibbonControl1
        Me.gcChangeRecords.Name = "gcChangeRecords"
        Me.gcChangeRecords.Size = New System.Drawing.Size(1316, 532)
        Me.gcChangeRecords.TabIndex = 1
        Me.gcChangeRecords.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CustomDevExGridView1})
        '
        'bsChangeRecords
        '
        Me.bsChangeRecords.DataSource = GetType(AOS.BusinessObjects.ViewChangeRecordStandardCostsCollection)
        '
        'CustomDevExGridView1
        '
        Me.CustomDevExGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChangerecid1, Me.colChangetype, Me.colWhochanged, Me.colWhenChanged, Me.colWhychanged, Me.colDatatablename1, Me.colDatarecordid1, Me.colPriorvalue1, Me.colPriorvalue1name, Me.colPriorvalue2, Me.colPriorvalue2name, Me.colPriorvalue3, Me.colPriorvalue3name, Me.colNewvalue1, Me.colNewvalue2, Me.colNewvalue3, Me.colProductid1, Me.colProductdesc1, Me.colContainer1, Me.colVendorname, Me.colRecordstatus})
        Me.CustomDevExGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.CustomDevExGridView1.GridControl = Me.gcChangeRecords
        Me.CustomDevExGridView1.Name = "CustomDevExGridView1"
        Me.CustomDevExGridView1.OptionsBehavior.Editable = False
        Me.CustomDevExGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CustomDevExGridView1.OptionsView.ShowAutoFilterRow = True
        Me.CustomDevExGridView1.OptionsView.ShowGroupPanel = False
        Me.CustomDevExGridView1.OptionsView.ShowIndicator = False
        '
        'colChangerecid1
        '
        Me.colChangerecid1.FieldName = "Changerecid"
        Me.colChangerecid1.Name = "colChangerecid1"
        '
        'colChangetype
        '
        Me.colChangetype.Caption = "Type"
        Me.colChangetype.FieldName = "Changetype"
        Me.colChangetype.Name = "colChangetype"
        Me.colChangetype.Visible = True
        Me.colChangetype.VisibleIndex = 0
        Me.colChangetype.Width = 76
        '
        'colWhochanged
        '
        Me.colWhochanged.Caption = "Who"
        Me.colWhochanged.FieldName = "Whochanged"
        Me.colWhochanged.Name = "colWhochanged"
        Me.colWhochanged.Visible = True
        Me.colWhochanged.VisibleIndex = 1
        Me.colWhochanged.Width = 68
        '
        'colWhenChanged
        '
        Me.colWhenChanged.Caption = "When"
        Me.colWhenChanged.DisplayFormat.FormatString = "g"
        Me.colWhenChanged.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colWhenChanged.FieldName = "Whenchanged"
        Me.colWhenChanged.Name = "colWhenChanged"
        Me.colWhenChanged.Visible = True
        Me.colWhenChanged.VisibleIndex = 2
        '
        'colWhychanged
        '
        Me.colWhychanged.Caption = "Why"
        Me.colWhychanged.FieldName = "Whychanged"
        Me.colWhychanged.Name = "colWhychanged"
        Me.colWhychanged.Visible = True
        Me.colWhychanged.VisibleIndex = 3
        Me.colWhychanged.Width = 112
        '
        'colDatatablename1
        '
        Me.colDatatablename1.Caption = "DataTable"
        Me.colDatatablename1.FieldName = "Datatablename"
        Me.colDatatablename1.Name = "colDatatablename1"
        Me.colDatatablename1.Width = 78
        '
        'colDatarecordid1
        '
        Me.colDatarecordid1.Caption = "Rec ID"
        Me.colDatarecordid1.FieldName = "Datarecordid"
        Me.colDatarecordid1.Name = "colDatarecordid1"
        Me.colDatarecordid1.Width = 49
        '
        'colPriorvalue1
        '
        Me.colPriorvalue1.Caption = "Prior"
        Me.colPriorvalue1.FieldName = "Priorvalue1"
        Me.colPriorvalue1.Name = "colPriorvalue1"
        Me.colPriorvalue1.Visible = True
        Me.colPriorvalue1.VisibleIndex = 8
        Me.colPriorvalue1.Width = 62
        '
        'colPriorvalue1name
        '
        Me.colPriorvalue1name.Caption = "Attribute 1"
        Me.colPriorvalue1name.FieldName = "Priorvalue1name"
        Me.colPriorvalue1name.Name = "colPriorvalue1name"
        Me.colPriorvalue1name.Visible = True
        Me.colPriorvalue1name.VisibleIndex = 7
        '
        'colPriorvalue2
        '
        Me.colPriorvalue2.Caption = "Prior"
        Me.colPriorvalue2.FieldName = "Priorvalue2"
        Me.colPriorvalue2.Name = "colPriorvalue2"
        Me.colPriorvalue2.Visible = True
        Me.colPriorvalue2.VisibleIndex = 11
        Me.colPriorvalue2.Width = 59
        '
        'colPriorvalue2name
        '
        Me.colPriorvalue2name.Caption = "Attribute 2"
        Me.colPriorvalue2name.FieldName = "Priorvalue2name"
        Me.colPriorvalue2name.Name = "colPriorvalue2name"
        Me.colPriorvalue2name.Visible = True
        Me.colPriorvalue2name.VisibleIndex = 10
        Me.colPriorvalue2name.Width = 79
        '
        'colPriorvalue3
        '
        Me.colPriorvalue3.FieldName = "Priorvalue3"
        Me.colPriorvalue3.Name = "colPriorvalue3"
        '
        'colPriorvalue3name
        '
        Me.colPriorvalue3name.FieldName = "Priorvalue3name"
        Me.colPriorvalue3name.Name = "colPriorvalue3name"
        '
        'colNewvalue1
        '
        Me.colNewvalue1.Caption = "New"
        Me.colNewvalue1.FieldName = "Newvalue1"
        Me.colNewvalue1.Name = "colNewvalue1"
        Me.colNewvalue1.Visible = True
        Me.colNewvalue1.VisibleIndex = 9
        Me.colNewvalue1.Width = 57
        '
        'colNewvalue2
        '
        Me.colNewvalue2.Caption = "New"
        Me.colNewvalue2.FieldName = "Newvalue2"
        Me.colNewvalue2.Name = "colNewvalue2"
        Me.colNewvalue2.Visible = True
        Me.colNewvalue2.VisibleIndex = 12
        Me.colNewvalue2.Width = 64
        '
        'colNewvalue3
        '
        Me.colNewvalue3.FieldName = "Newvalue3"
        Me.colNewvalue3.Name = "colNewvalue3"
        '
        'colProductid1
        '
        Me.colProductid1.Caption = "Prod ID"
        Me.colProductid1.FieldName = "Productid"
        Me.colProductid1.Name = "colProductid1"
        Me.colProductid1.Visible = True
        Me.colProductid1.VisibleIndex = 4
        Me.colProductid1.Width = 52
        '
        'colProductdesc1
        '
        Me.colProductdesc1.FieldName = "Productdesc"
        Me.colProductdesc1.Name = "colProductdesc1"
        Me.colProductdesc1.Visible = True
        Me.colProductdesc1.VisibleIndex = 5
        Me.colProductdesc1.Width = 189
        '
        'colContainer1
        '
        Me.colContainer1.FieldName = "Container"
        Me.colContainer1.Name = "colContainer1"
        Me.colContainer1.Visible = True
        Me.colContainer1.VisibleIndex = 6
        Me.colContainer1.Width = 68
        '
        'colVendorname
        '
        Me.colVendorname.FieldName = "Vendorname"
        Me.colVendorname.Name = "colVendorname"
        Me.colVendorname.Visible = True
        Me.colVendorname.VisibleIndex = 13
        Me.colVendorname.Width = 189
        '
        'colRecordstatus
        '
        Me.colRecordstatus.Caption = "Status"
        Me.colRecordstatus.FieldName = "Recordstatus"
        Me.colRecordstatus.Name = "colRecordstatus"
        Me.colRecordstatus.Visible = True
        Me.colRecordstatus.VisibleIndex = 14
        Me.colRecordstatus.Width = 96
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Controls.Add(Me.tabParameters)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1336, 572)
        Me.RibbonPanelControl1.TabIndex = 0
        '
        'tabParameters
        '
        Me.tabParameters.Location = New System.Drawing.Point(9, 9)
        Me.tabParameters.Name = "tabParameters"
        Me.tabParameters.SelectedTabPage = Me.XtraTabPage1
        Me.tabParameters.Size = New System.Drawing.Size(489, 469)
        Me.tabParameters.TabIndex = 0
        Me.tabParameters.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.AdditionalDefaultSendToAddressTextEdit)
        Me.XtraTabPage1.Controls.Add(AdditionalDefaultSendToAddressLabel)
        Me.XtraTabPage1.Controls.Add(Me.ProdOrdEstCompDateCheckEdit)
        Me.XtraTabPage1.Controls.Add(ProdOrdEstCompDateCheckLabel)
        Me.XtraTabPage1.Controls.Add(Me.AllowableWeightVariancePercentageTextEdit)
        Me.XtraTabPage1.Controls.Add(Label3)
        Me.XtraTabPage1.Controls.Add(Me.WorkOrderEmailReceiverTextEdit)
        Me.XtraTabPage1.Controls.Add(Label2)
        Me.XtraTabPage1.Controls.Add(WorkOrderEmailSenderLabel)
        Me.XtraTabPage1.Controls.Add(Me.WorkOrderEmailSenderTextEdit)
        Me.XtraTabPage1.Controls.Add(Me.CompanyEmailServerTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyEmailServerLabel)
        Me.XtraTabPage1.Controls.Add(CompanyEmailDomainLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyEmailDomainTextEdit)
        Me.XtraTabPage1.Controls.Add(FreezeWarningLabel)
        Me.XtraTabPage1.Controls.Add(Me.FreezeWarningCheckEdit)
        Me.XtraTabPage1.Controls.Add(StdlaborhourcostLabel)
        Me.XtraTabPage1.Controls.Add(Me.StdlaborhourcostTextEdit)
        Me.XtraTabPage1.Controls.Add(Label1)
        Me.XtraTabPage1.Controls.Add(Me.TextEdit1)
        Me.XtraTabPage1.Controls.Add(CompanyCountryLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyCountryTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyFAXLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyFAXTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyPhoneLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyPhoneTextEdit)
        Me.XtraTabPage1.Controls.Add(Me.CompanyZipcodeTextEdit)
        Me.XtraTabPage1.Controls.Add(Me.CompanyStateTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyCityLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyCityTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyAddressLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyAddressTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyNameLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyNameTextEdit)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(485, 444)
        Me.XtraTabPage1.Text = "Company Info"
        '
        'AdditionalDefaultSendToAddressTextEdit
        '
        Me.AdditionalDefaultSendToAddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "AdditionalDefaultsendToAddress", True))
        Me.AdditionalDefaultSendToAddressTextEdit.Location = New System.Drawing.Point(200, 279)
        Me.AdditionalDefaultSendToAddressTextEdit.Name = "AdditionalDefaultSendToAddressTextEdit"
        Me.AdditionalDefaultSendToAddressTextEdit.Properties.ReadOnly = True
        Me.AdditionalDefaultSendToAddressTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.AdditionalDefaultSendToAddressTextEdit.TabIndex = 23
        '
        'bsParms
        '
        Me.bsParms.DataSource = GetType(AOS.BusinessObjects.Sysparameters)
        '
        'ProdOrdEstCompDateCheckEdit
        '
        Me.ProdOrdEstCompDateCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "Setprodordestcompdate", True))
        Me.ProdOrdEstCompDateCheckEdit.Location = New System.Drawing.Point(198, 407)
        Me.ProdOrdEstCompDateCheckEdit.MenuManager = Me.RibbonControl1
        Me.ProdOrdEstCompDateCheckEdit.Name = "ProdOrdEstCompDateCheckEdit"
        Me.ProdOrdEstCompDateCheckEdit.Properties.Caption = ""
        Me.ProdOrdEstCompDateCheckEdit.Properties.ReadOnly = True
        Me.ProdOrdEstCompDateCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.ProdOrdEstCompDateCheckEdit.TabIndex = 33
        '
        'AllowableWeightVariancePercentageTextEdit
        '
        Me.AllowableWeightVariancePercentageTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "Allowableweightvariancepercentage", True))
        Me.AllowableWeightVariancePercentageTextEdit.Location = New System.Drawing.Point(200, 305)
        Me.AllowableWeightVariancePercentageTextEdit.Name = "AllowableWeightVariancePercentageTextEdit"
        Me.AllowableWeightVariancePercentageTextEdit.Properties.ReadOnly = True
        Me.AllowableWeightVariancePercentageTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.AllowableWeightVariancePercentageTextEdit.TabIndex = 25
        '
        'WorkOrderEmailReceiverTextEdit
        '
        Me.WorkOrderEmailReceiverTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "WOEmailReceiver", True))
        Me.WorkOrderEmailReceiverTextEdit.Location = New System.Drawing.Point(200, 253)
        Me.WorkOrderEmailReceiverTextEdit.Name = "WorkOrderEmailReceiverTextEdit"
        Me.WorkOrderEmailReceiverTextEdit.Properties.ReadOnly = True
        Me.WorkOrderEmailReceiverTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.WorkOrderEmailReceiverTextEdit.TabIndex = 21
        '
        'WorkOrderEmailSenderTextEdit
        '
        Me.WorkOrderEmailSenderTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "WOEmailSender", True))
        Me.WorkOrderEmailSenderTextEdit.Location = New System.Drawing.Point(200, 227)
        Me.WorkOrderEmailSenderTextEdit.Name = "WorkOrderEmailSenderTextEdit"
        Me.WorkOrderEmailSenderTextEdit.Properties.ReadOnly = True
        Me.WorkOrderEmailSenderTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.WorkOrderEmailSenderTextEdit.TabIndex = 19
        '
        'CompanyEmailServerTextEdit
        '
        Me.CompanyEmailServerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyEmailServer", True))
        Me.CompanyEmailServerTextEdit.Location = New System.Drawing.Point(200, 200)
        Me.CompanyEmailServerTextEdit.Name = "CompanyEmailServerTextEdit"
        Me.CompanyEmailServerTextEdit.Properties.ReadOnly = True
        Me.CompanyEmailServerTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.CompanyEmailServerTextEdit.TabIndex = 17
        '
        'CompanyEmailDomainTextEdit
        '
        Me.CompanyEmailDomainTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyEmailDomain", True))
        Me.CompanyEmailDomainTextEdit.Location = New System.Drawing.Point(200, 174)
        Me.CompanyEmailDomainTextEdit.Name = "CompanyEmailDomainTextEdit"
        Me.CompanyEmailDomainTextEdit.Properties.ReadOnly = True
        Me.CompanyEmailDomainTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.CompanyEmailDomainTextEdit.TabIndex = 15
        '
        'FreezeWarningCheckEdit
        '
        Me.FreezeWarningCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "FreezeWarning", True))
        Me.FreezeWarningCheckEdit.Location = New System.Drawing.Point(198, 383)
        Me.FreezeWarningCheckEdit.MenuManager = Me.RibbonControl1
        Me.FreezeWarningCheckEdit.Name = "FreezeWarningCheckEdit"
        Me.FreezeWarningCheckEdit.Properties.Caption = ""
        Me.FreezeWarningCheckEdit.Properties.ReadOnly = True
        Me.FreezeWarningCheckEdit.Properties.ValueChecked = 1
        Me.FreezeWarningCheckEdit.Properties.ValueUnchecked = 0
        Me.FreezeWarningCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.FreezeWarningCheckEdit.TabIndex = 31
        '
        'StdlaborhourcostTextEdit
        '
        Me.StdlaborhourcostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "Stdlaborhourcost", True))
        Me.StdlaborhourcostTextEdit.Location = New System.Drawing.Point(200, 359)
        Me.StdlaborhourcostTextEdit.MenuManager = Me.RibbonControl1
        Me.StdlaborhourcostTextEdit.Name = "StdlaborhourcostTextEdit"
        Me.StdlaborhourcostTextEdit.Properties.DisplayFormat.FormatString = "c2"
        Me.StdlaborhourcostTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.StdlaborhourcostTextEdit.Properties.ReadOnly = True
        Me.StdlaborhourcostTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.StdlaborhourcostTextEdit.TabIndex = 29
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "DefaultSalesTaxRate", True))
        Me.TextEdit1.Location = New System.Drawing.Point(200, 333)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "P2"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit1.TabIndex = 27
        '
        'CompanyCountryTextEdit
        '
        Me.CompanyCountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyCountry", True))
        Me.CompanyCountryTextEdit.Location = New System.Drawing.Point(200, 96)
        Me.CompanyCountryTextEdit.Name = "CompanyCountryTextEdit"
        Me.CompanyCountryTextEdit.Properties.ReadOnly = True
        Me.CompanyCountryTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.CompanyCountryTextEdit.TabIndex = 9
        '
        'CompanyFAXTextEdit
        '
        Me.CompanyFAXTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyFAX", True))
        Me.CompanyFAXTextEdit.Location = New System.Drawing.Point(200, 148)
        Me.CompanyFAXTextEdit.Name = "CompanyFAXTextEdit"
        Me.CompanyFAXTextEdit.Properties.ReadOnly = True
        Me.CompanyFAXTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CompanyFAXTextEdit.TabIndex = 13
        '
        'CompanyPhoneTextEdit
        '
        Me.CompanyPhoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyPhone", True))
        Me.CompanyPhoneTextEdit.Location = New System.Drawing.Point(200, 122)
        Me.CompanyPhoneTextEdit.Name = "CompanyPhoneTextEdit"
        Me.CompanyPhoneTextEdit.Properties.ReadOnly = True
        Me.CompanyPhoneTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CompanyPhoneTextEdit.TabIndex = 11
        '
        'CompanyZipcodeTextEdit
        '
        Me.CompanyZipcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyZipcode", True))
        Me.CompanyZipcodeTextEdit.Location = New System.Drawing.Point(401, 70)
        Me.CompanyZipcodeTextEdit.Name = "CompanyZipcodeTextEdit"
        Me.CompanyZipcodeTextEdit.Properties.ReadOnly = True
        Me.CompanyZipcodeTextEdit.Size = New System.Drawing.Size(68, 20)
        Me.CompanyZipcodeTextEdit.TabIndex = 7
        '
        'CompanyStateTextEdit
        '
        Me.CompanyStateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyState", True))
        Me.CompanyStateTextEdit.Location = New System.Drawing.Point(368, 70)
        Me.CompanyStateTextEdit.Name = "CompanyStateTextEdit"
        Me.CompanyStateTextEdit.Properties.ReadOnly = True
        Me.CompanyStateTextEdit.Size = New System.Drawing.Size(27, 20)
        Me.CompanyStateTextEdit.TabIndex = 6
        '
        'CompanyCityTextEdit
        '
        Me.CompanyCityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyCity", True))
        Me.CompanyCityTextEdit.Location = New System.Drawing.Point(200, 70)
        Me.CompanyCityTextEdit.Name = "CompanyCityTextEdit"
        Me.CompanyCityTextEdit.Properties.ReadOnly = True
        Me.CompanyCityTextEdit.Size = New System.Drawing.Size(162, 20)
        Me.CompanyCityTextEdit.TabIndex = 5
        '
        'CompanyAddressTextEdit
        '
        Me.CompanyAddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyAddress", True))
        Me.CompanyAddressTextEdit.Location = New System.Drawing.Point(200, 44)
        Me.CompanyAddressTextEdit.Name = "CompanyAddressTextEdit"
        Me.CompanyAddressTextEdit.Properties.ReadOnly = True
        Me.CompanyAddressTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.CompanyAddressTextEdit.TabIndex = 3
        '
        'CompanyNameTextEdit
        '
        Me.CompanyNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyName", True))
        Me.CompanyNameTextEdit.Location = New System.Drawing.Point(200, 18)
        Me.CompanyNameTextEdit.Name = "CompanyNameTextEdit"
        Me.CompanyNameTextEdit.Properties.ReadOnly = True
        Me.CompanyNameTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.CompanyNameTextEdit.TabIndex = 1
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1336, 572)
        Me.RibbonPanelControl2.TabIndex = 1
        '
        'bsReviewRecords
        '
        Me.bsReviewRecords.DataSource = GetType(AOS.BusinessObjects.ViewChangeReviewRecordsCollection)
        '
        'colProductid
        '
        Me.colProductid.Name = "colProductid"
        '
        'colProductdesc
        '
        Me.colProductdesc.Name = "colProductdesc"
        '
        'colContainer
        '
        Me.colContainer.Name = "colContainer"
        '
        'GridColumn3
        '
        Me.GridColumn3.Name = "GridColumn3"
        '
        'AuditLogView1
        '
        Me.AuditLogView1.Name = "AuditLogView1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'viewAdministration
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.Name = "viewAdministration"
        Me.Size = New System.Drawing.Size(1336, 721)
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl4.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCostPricingEffects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCostPricingEffects, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.gcChangeRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsChangeRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.tabParameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabParameters.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.AdditionalDefaultSendToAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsParms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdOrdEstCompDateCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllowableWeightVariancePercentageTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkOrderEmailReceiverTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkOrderEmailSenderTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyEmailServerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyEmailDomainTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FreezeWarningCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StdlaborhourcostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyCountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyFAXTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyPhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyZipcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyCityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsReviewRecords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAuditLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditLogView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsParms As System.Windows.Forms.BindingSource
    Friend WithEvents btnSaveParms As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelParms As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnEditParameters As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnEditAuditLog As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents AuditLogView1 As CustomDevExGridView
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents tabParameters As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FreezeWarningCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents StdlaborhourcostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyCountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyFAXTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyPhoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyZipcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyStateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyCityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bsAuditLog As System.Windows.Forms.BindingSource
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CompanyEmailDomainTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyEmailServerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkOrderEmailReceiverTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkOrderEmailSenderTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AllowableWeightVariancePercentageTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProdOrdEstCompDateCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AdditionalDefaultSendToAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnEditRelabelTemplateInstructions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnPallets As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnContainers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnStandardCostReview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bsChangeRecords As BindingSource
    Friend WithEvents bsReviewRecords As BindingSource
    Friend WithEvents gcChangeRecords As DevExpress.XtraGrid.GridControl
    Friend CustomDevExGridView1 As CustomDevExGridView
    Friend WithEvents colChangerecid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhochanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhychanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatatablename1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatarecordid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriorvalue1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriorvalue1name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriorvalue2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriorvalue2name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriorvalue3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriorvalue3name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewvalue1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewvalue2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewvalue3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnVendorCostReview As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnStandardCostApprovals As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAPISApprovals As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnVendorCostApprovals As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colProductid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRecordstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangetype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rStartDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rEndDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rbtnGetCostChangePriceListData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend grvCostPricingEffects As CustomDevExGridView
    Friend WithEvents bsCostPricingEffects As BindingSource
    Friend WithEvents colProductID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangetype1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangedate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhychanged1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOldcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCostdelta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVolOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVolNew As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWgtOld As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWgtNew As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPricingmethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rBtnExportCostPriceEffectsToExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colPer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhenChanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
End Class
