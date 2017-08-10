<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoadProcessing
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim PlannedDeliveryDateLabel As System.Windows.Forms.Label
        Dim PlannedDepartureDateLabel As System.Windows.Forms.Label
        Dim TotalBilledLabel As System.Windows.Forms.Label
        Dim TotalChargedLabel As System.Windows.Forms.Label
        Dim TotalContainersLabel As System.Windows.Forms.Label
        Dim TotalGrossWeightLabel As System.Windows.Forms.Label
        Dim AddToInvoiceLabel As System.Windows.Forms.Label
        Dim BillCustomerLabel As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoadProcessing))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnBack = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnSchedule = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditCharges = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditBillings = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintLoadInfo = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteLoadBillingRecs = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonLargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSelectVendor = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.bsLoadInfo = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LoadNotesMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BillCustomerCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AddToInvoiceCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.ModifiedTimeLabel1 = New System.Windows.Forms.Label()
        Me.ModifiedByLabel1 = New System.Windows.Forms.Label()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.OriginCityLabel1 = New System.Windows.Forms.Label()
        Me.PickupHoursLabel1 = New System.Windows.Forms.Label()
        Me.OriginAddress2Label1 = New System.Windows.Forms.Label()
        Me.OriginAddress1Label1 = New System.Windows.Forms.Label()
        Me.OriginPhoneLabel1 = New System.Windows.Forms.Label()
        Me.OriginNameLabel1 = New System.Windows.Forms.Label()
        Me.OriginStateLabel1 = New System.Windows.Forms.Label()
        Me.OriginContactLabel1 = New System.Windows.Forms.Label()
        Me.OriginZipLabel1 = New System.Windows.Forms.Label()
        Me.OriginCountryLabel1 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsLoadItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyContainers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourceType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourceID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnline = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDotdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassrate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazclassnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPackagegroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.bsLoadQuotes = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colLoadQuoteID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsProviderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierQuoteNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        PlannedDeliveryDateLabel = New System.Windows.Forms.Label()
        PlannedDepartureDateLabel = New System.Windows.Forms.Label()
        TotalBilledLabel = New System.Windows.Forms.Label()
        TotalChargedLabel = New System.Windows.Forms.Label()
        TotalContainersLabel = New System.Windows.Forms.Label()
        TotalGrossWeightLabel = New System.Windows.Forms.Label()
        AddToInvoiceLabel = New System.Windows.Forms.Label()
        BillCustomerLabel = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonLargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.LoadNotesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.BillCustomerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddToInvoiceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadQuotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlannedDeliveryDateLabel
        '
        PlannedDeliveryDateLabel.AutoSize = True
        PlannedDeliveryDateLabel.Location = New System.Drawing.Point(15, 42)
        PlannedDeliveryDateLabel.Name = "PlannedDeliveryDateLabel"
        PlannedDeliveryDateLabel.Size = New System.Drawing.Size(76, 13)
        PlannedDeliveryDateLabel.TabIndex = 12
        PlannedDeliveryDateLabel.Text = "Delivery Date:"
        '
        'PlannedDepartureDateLabel
        '
        PlannedDepartureDateLabel.AutoSize = True
        PlannedDepartureDateLabel.Location = New System.Drawing.Point(5, 26)
        PlannedDepartureDateLabel.Name = "PlannedDepartureDateLabel"
        PlannedDepartureDateLabel.Size = New System.Drawing.Size(86, 13)
        PlannedDepartureDateLabel.TabIndex = 14
        PlannedDepartureDateLabel.Text = "Departure Date:"
        '
        'TotalBilledLabel
        '
        TotalBilledLabel.AutoSize = True
        TotalBilledLabel.Location = New System.Drawing.Point(238, 42)
        TotalBilledLabel.Name = "TotalBilledLabel"
        TotalBilledLabel.Size = New System.Drawing.Size(84, 13)
        TotalBilledLabel.TabIndex = 16
        TotalBilledLabel.Text = "Customer Billed:"
        '
        'TotalChargedLabel
        '
        TotalChargedLabel.AutoSize = True
        TotalChargedLabel.Location = New System.Drawing.Point(235, 26)
        TotalChargedLabel.Name = "TotalChargedLabel"
        TotalChargedLabel.Size = New System.Drawing.Size(87, 13)
        TotalChargedLabel.TabIndex = 18
        TotalChargedLabel.Text = "Carrier Charges:"
        '
        'TotalContainersLabel
        '
        TotalContainersLabel.AutoSize = True
        TotalContainersLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalContainersLabel.Location = New System.Drawing.Point(546, 26)
        TotalContainersLabel.Name = "TotalContainersLabel"
        TotalContainersLabel.Size = New System.Drawing.Size(74, 16)
        TotalContainersLabel.TabIndex = 20
        TotalContainersLabel.Text = "Containers:"
        '
        'TotalGrossWeightLabel
        '
        TotalGrossWeightLabel.AutoSize = True
        TotalGrossWeightLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalGrossWeightLabel.Location = New System.Drawing.Point(790, 26)
        TotalGrossWeightLabel.Name = "TotalGrossWeightLabel"
        TotalGrossWeightLabel.Size = New System.Drawing.Size(72, 16)
        TotalGrossWeightLabel.TabIndex = 22
        TotalGrossWeightLabel.Text = "Gross Wgt:"
        '
        'AddToInvoiceLabel
        '
        AddToInvoiceLabel.AutoSize = True
        AddToInvoiceLabel.Location = New System.Drawing.Point(8, 121)
        AddToInvoiceLabel.Name = "AddToInvoiceLabel"
        AddToInvoiceLabel.Size = New System.Drawing.Size(83, 13)
        AddToInvoiceLabel.TabIndex = 24
        AddToInvoiceLabel.Text = "Add To Invoice:"
        '
        'BillCustomerLabel
        '
        BillCustomerLabel.AutoSize = True
        BillCustomerLabel.Location = New System.Drawing.Point(19, 105)
        BillCustomerLabel.Name = "BillCustomerLabel"
        BillCustomerLabel.Size = New System.Drawing.Size(72, 13)
        BillCustomerLabel.TabIndex = 26
        BillCustomerLabel.Text = "Bill Customer:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(25, 73)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(66, 13)
        Label12.TabIndex = 32
        Label12.Text = "Req Carrier:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(18, 89)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(73, 13)
        Label13.TabIndex = 33
        Label13.Text = "Req Logistics:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(60, 57)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(31, 13)
        Label14.TabIndex = 36
        Label14.Text = "FOB:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(5, 42)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(76, 13)
        Label15.TabIndex = 34
        Label15.Text = "Sched Carrier:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(5, 26)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(73, 13)
        Label17.TabIndex = 38
        Label17.Text = "Sched Pickup:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(5, 57)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(65, 13)
        Label16.TabIndex = 39
        Label16.Text = "Load Notes:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(267, 57)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(55, 13)
        Label11.TabIndex = 40
        Label11.Text = "Quote ID:"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnBack, Me.rbtnSchedule, Me.rbtnAddQuote, Me.rbtnEditQuote, Me.rbtnDeleteQuote, Me.rbtnEditCharges, Me.rbtnEditBillings, Me.rbtnPrintLoadInfo, Me.rbtnDeleteLoadBillingRecs})
        Me.RibbonControl1.LargeImages = Me.RibbonLargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 10
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowCategoryInCaption = False
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1200, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnBack
        '
        Me.rbtnBack.Caption = "Go Back"
        Me.rbtnBack.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnBack.Id = 1
        Me.rbtnBack.LargeImageIndex = 3
        Me.rbtnBack.Name = "rbtnBack"
        '
        'rbtnSchedule
        '
        Me.rbtnSchedule.Caption = "Schedule Load"
        Me.rbtnSchedule.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnSchedule.Id = 2
        Me.rbtnSchedule.LargeImageIndex = 4
        Me.rbtnSchedule.Name = "rbtnSchedule"
        '
        'rbtnAddQuote
        '
        Me.rbtnAddQuote.Caption = "Add Quote"
        Me.rbtnAddQuote.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnAddQuote.Id = 3
        Me.rbtnAddQuote.LargeImageIndex = 5
        Me.rbtnAddQuote.Name = "rbtnAddQuote"
        '
        'rbtnEditQuote
        '
        Me.rbtnEditQuote.Caption = "Edit Quote"
        Me.rbtnEditQuote.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnEditQuote.Id = 4
        Me.rbtnEditQuote.LargeImageIndex = 6
        Me.rbtnEditQuote.Name = "rbtnEditQuote"
        '
        'rbtnDeleteQuote
        '
        Me.rbtnDeleteQuote.Caption = "DeleteQuote"
        Me.rbtnDeleteQuote.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnDeleteQuote.Id = 5
        Me.rbtnDeleteQuote.LargeImageIndex = 7
        Me.rbtnDeleteQuote.Name = "rbtnDeleteQuote"
        '
        'rbtnEditCharges
        '
        Me.rbtnEditCharges.Caption = "Edit Freight Charges"
        Me.rbtnEditCharges.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnEditCharges.Id = 6
        Me.rbtnEditCharges.LargeImageIndex = 10
        Me.rbtnEditCharges.Name = "rbtnEditCharges"
        '
        'rbtnEditBillings
        '
        Me.rbtnEditBillings.Caption = "Edit Customer Billings"
        Me.rbtnEditBillings.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnEditBillings.Id = 7
        Me.rbtnEditBillings.LargeImageIndex = 13
        Me.rbtnEditBillings.Name = "rbtnEditBillings"
        '
        'rbtnPrintLoadInfo
        '
        Me.rbtnPrintLoadInfo.Caption = "Load Data Sheet"
        Me.rbtnPrintLoadInfo.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPrintLoadInfo.Id = 8
        Me.rbtnPrintLoadInfo.LargeImageIndex = 15
        Me.rbtnPrintLoadInfo.Name = "rbtnPrintLoadInfo"
        '
        'rbtnDeleteLoadBillingRecs
        '
        Me.rbtnDeleteLoadBillingRecs.Caption = "Delete All Billing Records"
        Me.rbtnDeleteLoadBillingRecs.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnDeleteLoadBillingRecs.Id = 9
        Me.rbtnDeleteLoadBillingRecs.LargeImageIndex = 11
        Me.rbtnDeleteLoadBillingRecs.Name = "rbtnDeleteLoadBillingRecs"
        '
        'RibbonLargeImages
        '
        Me.RibbonLargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.RibbonLargeImages.ImageStream = CType(resources.GetObject("RibbonLargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.RibbonPageGroup5})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnBack)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnPrintLoadInfo, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Load Mgmt"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnAddQuote)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnEditQuote)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnDeleteQuote)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Quote Mgmt"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnEditCharges)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Charges"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnEditBillings)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnDeleteLoadBillingRecs, True)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Billings"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowMinimize = False
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnSchedule)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Scheduling"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.btnSelectVendor)
        Me.GroupControl1.Controls.Add(Me.LabelControl14)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.GroupControl7)
        Me.GroupControl1.Controls.Add(Me.GroupControl6)
        Me.GroupControl1.Controls.Add(TotalContainersLabel)
        Me.GroupControl1.Controls.Add(Me.ModifiedTimeLabel1)
        Me.GroupControl1.Controls.Add(Me.ModifiedByLabel1)
        Me.GroupControl1.Controls.Add(Me.GroupControl5)
        Me.GroupControl1.Controls.Add(Me.GroupControl4)
        Me.GroupControl1.Controls.Add(TotalGrossWeightLabel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1200, 224)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Load Information"
        '
        'btnSelectVendor
        '
        Me.btnSelectVendor.Location = New System.Drawing.Point(212, 23)
        Me.btnSelectVendor.Name = "btnSelectVendor"
        Me.btnSelectVendor.Size = New System.Drawing.Size(60, 23)
        Me.btnSelectVendor.TabIndex = 36
        Me.btnSelectVendor.Text = "Vendor"
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl14.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "LoadStatus", True))
        Me.LabelControl14.Location = New System.Drawing.Point(1054, 26)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(129, 16)
        Me.LabelControl14.TabIndex = 35
        Me.LabelControl14.Text = "Load Status"
        '
        'bsLoadInfo
        '
        Me.bsLoadInfo.DataSource = GetType(AOS.BusinessObjects.ViewLoadInfo)
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "TotalGrossWeight", True))
        Me.LabelControl13.Location = New System.Drawing.Point(868, 26)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl13.TabIndex = 34
        Me.LabelControl13.Text = "Gross Wgt"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "TotalContainers", True))
        Me.LabelControl12.Location = New System.Drawing.Point(621, 26)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl12.TabIndex = 33
        Me.LabelControl12.Text = "Containers"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "LoadType", True))
        Me.LabelControl11.Location = New System.Drawing.Point(286, 26)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl11.TabIndex = 32
        Me.LabelControl11.Text = "Load Type"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "LoadID", True))
        Me.LabelControl10.Location = New System.Drawing.Point(12, 26)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl10.TabIndex = 31
        Me.LabelControl10.Text = "Load #"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.LabelControl15)
        Me.GroupControl7.Controls.Add(Label11)
        Me.GroupControl7.Controls.Add(Label16)
        Me.GroupControl7.Controls.Add(Label17)
        Me.GroupControl7.Controls.Add(Me.LabelControl9)
        Me.GroupControl7.Controls.Add(Me.LabelControl8)
        Me.GroupControl7.Controls.Add(Label15)
        Me.GroupControl7.Controls.Add(Me.LabelControl6)
        Me.GroupControl7.Controls.Add(Me.LabelControl5)
        Me.GroupControl7.Controls.Add(Me.LoadNotesMemoEdit)
        Me.GroupControl7.Controls.Add(TotalBilledLabel)
        Me.GroupControl7.Controls.Add(TotalChargedLabel)
        Me.GroupControl7.Location = New System.Drawing.Point(789, 48)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(399, 155)
        Me.GroupControl7.TabIndex = 29
        Me.GroupControl7.Text = "Scheduled Load Data"
        '
        'LabelControl15
        '
        Me.LabelControl15.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "QuoteID", True))
        Me.LabelControl15.Location = New System.Drawing.Point(328, 57)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl15.TabIndex = 41
        Me.LabelControl15.Text = "LabelControl15"
        '
        'LabelControl9
        '
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "ScheduledCarrierName", True))
        Me.LabelControl9.Location = New System.Drawing.Point(83, 42)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl9.TabIndex = 37
        Me.LabelControl9.Text = "LabelControl9"
        '
        'LabelControl8
        '
        Me.LabelControl8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "ScheduledShipmentDate", True))
        Me.LabelControl8.Location = New System.Drawing.Point(83, 26)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl8.TabIndex = 35
        Me.LabelControl8.Text = "LabelControl8"
        '
        'LabelControl6
        '
        Me.LabelControl6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "TotalCharged", True))
        Me.LabelControl6.Location = New System.Drawing.Point(328, 26)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl6.TabIndex = 33
        Me.LabelControl6.Text = "LabelControl6"
        '
        'LabelControl5
        '
        Me.LabelControl5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "TotalBilled", True))
        Me.LabelControl5.Location = New System.Drawing.Point(328, 42)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 32
        Me.LabelControl5.Text = "LabelControl5"
        '
        'LoadNotesMemoEdit
        '
        Me.LoadNotesMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "LoadNotes", True))
        Me.LoadNotesMemoEdit.Location = New System.Drawing.Point(5, 73)
        Me.LoadNotesMemoEdit.MenuManager = Me.RibbonControl1
        Me.LoadNotesMemoEdit.Name = "LoadNotesMemoEdit"
        Me.LoadNotesMemoEdit.Size = New System.Drawing.Size(389, 77)
        Me.LoadNotesMemoEdit.TabIndex = 5
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.LabelControl7)
        Me.GroupControl6.Controls.Add(Label14)
        Me.GroupControl6.Controls.Add(Me.LabelControl4)
        Me.GroupControl6.Controls.Add(Me.LabelControl3)
        Me.GroupControl6.Controls.Add(Label13)
        Me.GroupControl6.Controls.Add(Label12)
        Me.GroupControl6.Controls.Add(Me.LabelControl2)
        Me.GroupControl6.Controls.Add(Me.LabelControl1)
        Me.GroupControl6.Controls.Add(BillCustomerLabel)
        Me.GroupControl6.Controls.Add(Me.BillCustomerCheckEdit)
        Me.GroupControl6.Controls.Add(AddToInvoiceLabel)
        Me.GroupControl6.Controls.Add(PlannedDeliveryDateLabel)
        Me.GroupControl6.Controls.Add(Me.AddToInvoiceCheckEdit)
        Me.GroupControl6.Controls.Add(PlannedDepartureDateLabel)
        Me.GroupControl6.Location = New System.Drawing.Point(544, 48)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(239, 155)
        Me.GroupControl6.TabIndex = 28
        Me.GroupControl6.Text = "Information from Workorder(s)"
        '
        'LabelControl7
        '
        Me.LabelControl7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "Fob", True))
        Me.LabelControl7.Location = New System.Drawing.Point(97, 57)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl7.TabIndex = 37
        Me.LabelControl7.Text = "LabelControl7"
        '
        'LabelControl4
        '
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "Logisticsname", True))
        Me.LabelControl4.Location = New System.Drawing.Point(97, 89)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(137, 16)
        Me.LabelControl4.TabIndex = 35
        Me.LabelControl4.Text = "LabelControl4"
        '
        'LabelControl3
        '
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "CarrierName", True))
        Me.LabelControl3.Location = New System.Drawing.Point(97, 73)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(137, 16)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "LabelControl3"
        '
        'LabelControl2
        '
        Me.LabelControl2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "PlannedDeliveryDate", True))
        Me.LabelControl2.Location = New System.Drawing.Point(97, 42)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl2.TabIndex = 31
        Me.LabelControl2.Text = "LabelControl2"
        '
        'LabelControl1
        '
        Me.LabelControl1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "PlannedDepartureDate", True))
        Me.LabelControl1.Location = New System.Drawing.Point(97, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "LabelControl1"
        '
        'BillCustomerCheckEdit
        '
        Me.BillCustomerCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "BillCustomer", True))
        Me.BillCustomerCheckEdit.Location = New System.Drawing.Point(95, 102)
        Me.BillCustomerCheckEdit.MenuManager = Me.RibbonControl1
        Me.BillCustomerCheckEdit.Name = "BillCustomerCheckEdit"
        Me.BillCustomerCheckEdit.Properties.Caption = ""
        Me.BillCustomerCheckEdit.Properties.ReadOnly = True
        Me.BillCustomerCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.BillCustomerCheckEdit.TabIndex = 27
        Me.BillCustomerCheckEdit.TabStop = False
        '
        'AddToInvoiceCheckEdit
        '
        Me.AddToInvoiceCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "AddToInvoice", True))
        Me.AddToInvoiceCheckEdit.Location = New System.Drawing.Point(95, 118)
        Me.AddToInvoiceCheckEdit.MenuManager = Me.RibbonControl1
        Me.AddToInvoiceCheckEdit.Name = "AddToInvoiceCheckEdit"
        Me.AddToInvoiceCheckEdit.Properties.Caption = ""
        Me.AddToInvoiceCheckEdit.Properties.ReadOnly = True
        Me.AddToInvoiceCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.AddToInvoiceCheckEdit.TabIndex = 25
        Me.AddToInvoiceCheckEdit.TabStop = False
        '
        'ModifiedTimeLabel1
        '
        Me.ModifiedTimeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "ModifiedTime", True))
        Me.ModifiedTimeLabel1.Location = New System.Drawing.Point(9, 205)
        Me.ModifiedTimeLabel1.Name = "ModifiedTimeLabel1"
        Me.ModifiedTimeLabel1.Size = New System.Drawing.Size(244, 16)
        Me.ModifiedTimeLabel1.TabIndex = 11
        Me.ModifiedTimeLabel1.Text = "Label11"
        '
        'ModifiedByLabel1
        '
        Me.ModifiedByLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "ModifiedBy", True))
        Me.ModifiedByLabel1.Location = New System.Drawing.Point(275, 205)
        Me.ModifiedByLabel1.Name = "ModifiedByLabel1"
        Me.ModifiedByLabel1.Size = New System.Drawing.Size(58, 16)
        Me.ModifiedByLabel1.TabIndex = 9
        Me.ModifiedByLabel1.Text = "Label11"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.Label1)
        Me.GroupControl5.Controls.Add(Me.Label2)
        Me.GroupControl5.Controls.Add(Me.Label3)
        Me.GroupControl5.Controls.Add(Me.Label4)
        Me.GroupControl5.Controls.Add(Me.Label5)
        Me.GroupControl5.Controls.Add(Me.Label6)
        Me.GroupControl5.Controls.Add(Me.Label7)
        Me.GroupControl5.Controls.Add(Me.Label8)
        Me.GroupControl5.Controls.Add(Me.Label9)
        Me.GroupControl5.Controls.Add(Me.Label10)
        Me.GroupControl5.Location = New System.Drawing.Point(278, 48)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(260, 155)
        Me.GroupControl5.TabIndex = 1
        Me.GroupControl5.Text = "Destination / Consignee"
        '
        'Label1
        '
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DestCity", True))
        Me.Label1.Location = New System.Drawing.Point(5, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DeliveryHours", True))
        Me.Label2.Location = New System.Drawing.Point(5, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DestAddress2", True))
        Me.Label3.Location = New System.Drawing.Point(5, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Label1"
        '
        'Label4
        '
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DestAddress1", True))
        Me.Label4.Location = New System.Drawing.Point(5, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Label1"
        '
        'Label5
        '
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DestPhone", True))
        Me.Label5.Location = New System.Drawing.Point(5, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Label1"
        '
        'Label6
        '
        Me.Label6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DestName", True))
        Me.Label6.Location = New System.Drawing.Point(5, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 16)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Label1"
        '
        'Label7
        '
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DestState", True))
        Me.Label7.Location = New System.Drawing.Point(165, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Label1"
        '
        'Label8
        '
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DestContact", True))
        Me.Label8.Location = New System.Drawing.Point(5, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(250, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Label1"
        '
        'Label9
        '
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DestZip", True))
        Me.Label9.Location = New System.Drawing.Point(206, 73)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Label1"
        '
        'Label10
        '
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "DestCountry", True))
        Me.Label10.Location = New System.Drawing.Point(5, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(250, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Label1"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.OriginCityLabel1)
        Me.GroupControl4.Controls.Add(Me.PickupHoursLabel1)
        Me.GroupControl4.Controls.Add(Me.OriginAddress2Label1)
        Me.GroupControl4.Controls.Add(Me.OriginAddress1Label1)
        Me.GroupControl4.Controls.Add(Me.OriginPhoneLabel1)
        Me.GroupControl4.Controls.Add(Me.OriginNameLabel1)
        Me.GroupControl4.Controls.Add(Me.OriginStateLabel1)
        Me.GroupControl4.Controls.Add(Me.OriginContactLabel1)
        Me.GroupControl4.Controls.Add(Me.OriginZipLabel1)
        Me.GroupControl4.Controls.Add(Me.OriginCountryLabel1)
        Me.GroupControl4.Location = New System.Drawing.Point(12, 48)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(260, 155)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Origin / Shipper"
        '
        'OriginCityLabel1
        '
        Me.OriginCityLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "OriginCity", True))
        Me.OriginCityLabel1.Location = New System.Drawing.Point(5, 73)
        Me.OriginCityLabel1.Name = "OriginCityLabel1"
        Me.OriginCityLabel1.Size = New System.Drawing.Size(160, 16)
        Me.OriginCityLabel1.TabIndex = 3
        Me.OriginCityLabel1.Text = "Label1"
        '
        'PickupHoursLabel1
        '
        Me.PickupHoursLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "PickupHours", True))
        Me.PickupHoursLabel1.Location = New System.Drawing.Point(5, 137)
        Me.PickupHoursLabel1.Name = "PickupHoursLabel1"
        Me.PickupHoursLabel1.Size = New System.Drawing.Size(250, 16)
        Me.PickupHoursLabel1.TabIndex = 13
        Me.PickupHoursLabel1.Text = "Label1"
        '
        'OriginAddress2Label1
        '
        Me.OriginAddress2Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "OriginAddress2", True))
        Me.OriginAddress2Label1.Location = New System.Drawing.Point(5, 57)
        Me.OriginAddress2Label1.Name = "OriginAddress2Label1"
        Me.OriginAddress2Label1.Size = New System.Drawing.Size(250, 16)
        Me.OriginAddress2Label1.TabIndex = 3
        Me.OriginAddress2Label1.Text = "Label1"
        '
        'OriginAddress1Label1
        '
        Me.OriginAddress1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "OriginAddress1", True))
        Me.OriginAddress1Label1.Location = New System.Drawing.Point(5, 42)
        Me.OriginAddress1Label1.Name = "OriginAddress1Label1"
        Me.OriginAddress1Label1.Size = New System.Drawing.Size(250, 16)
        Me.OriginAddress1Label1.TabIndex = 3
        Me.OriginAddress1Label1.Text = "Label1"
        '
        'OriginPhoneLabel1
        '
        Me.OriginPhoneLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "OriginPhone", True))
        Me.OriginPhoneLabel1.Location = New System.Drawing.Point(5, 121)
        Me.OriginPhoneLabel1.Name = "OriginPhoneLabel1"
        Me.OriginPhoneLabel1.Size = New System.Drawing.Size(250, 16)
        Me.OriginPhoneLabel1.TabIndex = 11
        Me.OriginPhoneLabel1.Text = "Label1"
        '
        'OriginNameLabel1
        '
        Me.OriginNameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "OriginName", True))
        Me.OriginNameLabel1.Location = New System.Drawing.Point(5, 26)
        Me.OriginNameLabel1.Name = "OriginNameLabel1"
        Me.OriginNameLabel1.Size = New System.Drawing.Size(250, 16)
        Me.OriginNameLabel1.TabIndex = 1
        Me.OriginNameLabel1.Text = "Label1"
        '
        'OriginStateLabel1
        '
        Me.OriginStateLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "OriginState", True))
        Me.OriginStateLabel1.Location = New System.Drawing.Point(165, 73)
        Me.OriginStateLabel1.Name = "OriginStateLabel1"
        Me.OriginStateLabel1.Size = New System.Drawing.Size(25, 16)
        Me.OriginStateLabel1.TabIndex = 3
        Me.OriginStateLabel1.Text = "Label1"
        '
        'OriginContactLabel1
        '
        Me.OriginContactLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "OriginContact", True))
        Me.OriginContactLabel1.Location = New System.Drawing.Point(5, 105)
        Me.OriginContactLabel1.Name = "OriginContactLabel1"
        Me.OriginContactLabel1.Size = New System.Drawing.Size(250, 16)
        Me.OriginContactLabel1.TabIndex = 9
        Me.OriginContactLabel1.Text = "Label1"
        '
        'OriginZipLabel1
        '
        Me.OriginZipLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "OriginZip", True))
        Me.OriginZipLabel1.Location = New System.Drawing.Point(206, 73)
        Me.OriginZipLabel1.Name = "OriginZipLabel1"
        Me.OriginZipLabel1.Size = New System.Drawing.Size(50, 16)
        Me.OriginZipLabel1.TabIndex = 5
        Me.OriginZipLabel1.Text = "Label1"
        '
        'OriginCountryLabel1
        '
        Me.OriginCountryLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsLoadInfo, "OriginCountry", True))
        Me.OriginCountryLabel1.Location = New System.Drawing.Point(5, 89)
        Me.OriginCountryLabel1.Name = "OriginCountryLabel1"
        Me.OriginCountryLabel1.Size = New System.Drawing.Size(250, 16)
        Me.OriginCountryLabel1.TabIndex = 7
        Me.OriginCountryLabel1.Text = "Label1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 434)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1200, 308)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Load Item Details"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsLoadItems
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1196, 284)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsLoadItems
        '
        Me.bsLoadItems.DataSource = GetType(AOS.BusinessObjects.ViewLoadItemsDisplayCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.colLoadID, Me.colItemType, Me.colItemID, Me.colItemDescription, Me.colContainer, Me.colQtyContainers, Me.colTotalWeight, Me.colSourceType, Me.colSourceID, Me.colUnline, Me.colHazmatdesc, Me.colDotdesc, Me.colClassrate, Me.colWeightunits, Me.colWeightuom, Me.colUnnumber, Me.colHazclassnumber, Me.colPackagegroup, Me.colIdnumber})
        Me.GridView1.DetailHeight = 50
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupFormat = "{0}: {1} | {2}"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalWeight", Nothing, "Wgt = {0:#,#} LBS")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.OptionsView.ShowPreview = True
        Me.GridView1.PreviewFieldName = "HazMatInfoLine"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "HazMatInfoLine"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'colLoadID
        '
        Me.colLoadID.FieldName = "LoadID"
        Me.colLoadID.Name = "colLoadID"
        '
        'colItemType
        '
        Me.colItemType.Caption = "Type"
        Me.colItemType.FieldName = "ItemType"
        Me.colItemType.Name = "colItemType"
        Me.colItemType.Visible = True
        Me.colItemType.VisibleIndex = 0
        Me.colItemType.Width = 79
        '
        'colItemID
        '
        Me.colItemID.FieldName = "ItemID"
        Me.colItemID.Name = "colItemID"
        Me.colItemID.Visible = True
        Me.colItemID.VisibleIndex = 1
        Me.colItemID.Width = 61
        '
        'colItemDescription
        '
        Me.colItemDescription.FieldName = "ItemDescription"
        Me.colItemDescription.Name = "colItemDescription"
        Me.colItemDescription.Visible = True
        Me.colItemDescription.VisibleIndex = 2
        Me.colItemDescription.Width = 443
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 91
        '
        'colQtyContainers
        '
        Me.colQtyContainers.Caption = "Qty"
        Me.colQtyContainers.FieldName = "QtyContainers"
        Me.colQtyContainers.Name = "colQtyContainers"
        Me.colQtyContainers.Visible = True
        Me.colQtyContainers.VisibleIndex = 4
        Me.colQtyContainers.Width = 61
        '
        'colTotalWeight
        '
        Me.colTotalWeight.Caption = "Wgt"
        Me.colTotalWeight.FieldName = "TotalWeight"
        Me.colTotalWeight.Name = "colTotalWeight"
        Me.colTotalWeight.Visible = True
        Me.colTotalWeight.VisibleIndex = 5
        Me.colTotalWeight.Width = 79
        '
        'colSourceType
        '
        Me.colSourceType.FieldName = "SourceType"
        Me.colSourceType.Name = "colSourceType"
        '
        'colSourceID
        '
        Me.colSourceID.FieldName = "SourceID"
        Me.colSourceID.Name = "colSourceID"
        '
        'colUnline
        '
        Me.colUnline.FieldName = "Unline"
        Me.colUnline.Name = "colUnline"
        '
        'colHazmatdesc
        '
        Me.colHazmatdesc.FieldName = "Hazmatdesc"
        Me.colHazmatdesc.Name = "colHazmatdesc"
        Me.colHazmatdesc.Width = 496
        '
        'colDotdesc
        '
        Me.colDotdesc.FieldName = "Dotdesc"
        Me.colDotdesc.Name = "colDotdesc"
        Me.colDotdesc.Width = 497
        '
        'colClassrate
        '
        Me.colClassrate.Caption = "Class"
        Me.colClassrate.FieldName = "Classrate"
        Me.colClassrate.Name = "colClassrate"
        Me.colClassrate.Visible = True
        Me.colClassrate.VisibleIndex = 6
        Me.colClassrate.Width = 85
        '
        'colWeightunits
        '
        Me.colWeightunits.Caption = "Wgt"
        Me.colWeightunits.FieldName = "Weightunits"
        Me.colWeightunits.Name = "colWeightunits"
        '
        'colWeightuom
        '
        Me.colWeightuom.Caption = "UOM"
        Me.colWeightuom.FieldName = "Weightuom"
        Me.colWeightuom.Name = "colWeightuom"
        Me.colWeightuom.Visible = True
        Me.colWeightuom.VisibleIndex = 7
        Me.colWeightuom.Width = 68
        '
        'colUnnumber
        '
        Me.colUnnumber.FieldName = "Unnumber"
        Me.colUnnumber.Name = "colUnnumber"
        Me.colUnnumber.Width = 72
        '
        'colHazclassnumber
        '
        Me.colHazclassnumber.Caption = "HazClass"
        Me.colHazclassnumber.FieldName = "Hazclassnumber"
        Me.colHazclassnumber.Name = "colHazclassnumber"
        Me.colHazclassnumber.Visible = True
        Me.colHazclassnumber.VisibleIndex = 8
        Me.colHazclassnumber.Width = 62
        '
        'colPackagegroup
        '
        Me.colPackagegroup.Caption = "PkgGrp"
        Me.colPackagegroup.FieldName = "Packagegroup"
        Me.colPackagegroup.Name = "colPackagegroup"
        Me.colPackagegroup.Visible = True
        Me.colPackagegroup.VisibleIndex = 9
        Me.colPackagegroup.Width = 61
        '
        'colIdnumber
        '
        Me.colIdnumber.Caption = "ID #"
        Me.colIdnumber.FieldName = "Idnumber"
        Me.colIdnumber.Name = "colIdnumber"
        Me.colIdnumber.Visible = True
        Me.colIdnumber.VisibleIndex = 10
        Me.colIdnumber.Width = 106
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl2)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 319)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1200, 115)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "Carrier Freight Quotes"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsLoadQuotes
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 22)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.RibbonControl1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1196, 91)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsLoadQuotes
        '
        Me.bsLoadQuotes.DataSource = GetType(AOS.BusinessObjects.ViewLoadQuotesByLoadIDCollection)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLoadQuoteID, Me.colLoadID1, Me.colCarrierID, Me.colCarrierName, Me.colLogisticsProviderID, Me.colLogisticsname, Me.colQuoteAmount, Me.colQuoteDate, Me.colCarrierQuoteNumber})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colLoadQuoteID
        '
        Me.colLoadQuoteID.Caption = "Quote #"
        Me.colLoadQuoteID.FieldName = "LoadQuoteID"
        Me.colLoadQuoteID.Name = "colLoadQuoteID"
        Me.colLoadQuoteID.Visible = True
        Me.colLoadQuoteID.VisibleIndex = 0
        Me.colLoadQuoteID.Width = 59
        '
        'colLoadID1
        '
        Me.colLoadID1.Caption = "Load #"
        Me.colLoadID1.FieldName = "LoadID"
        Me.colLoadID1.Name = "colLoadID1"
        Me.colLoadID1.Visible = True
        Me.colLoadID1.VisibleIndex = 1
        Me.colLoadID1.Width = 57
        '
        'colCarrierID
        '
        Me.colCarrierID.FieldName = "CarrierID"
        Me.colCarrierID.Name = "colCarrierID"
        Me.colCarrierID.Visible = True
        Me.colCarrierID.VisibleIndex = 2
        Me.colCarrierID.Width = 77
        '
        'colCarrierName
        '
        Me.colCarrierName.FieldName = "CarrierName"
        Me.colCarrierName.Name = "colCarrierName"
        Me.colCarrierName.Visible = True
        Me.colCarrierName.VisibleIndex = 3
        Me.colCarrierName.Width = 260
        '
        'colLogisticsProviderID
        '
        Me.colLogisticsProviderID.Caption = "3rd Party ID"
        Me.colLogisticsProviderID.FieldName = "LogisticsProviderID"
        Me.colLogisticsProviderID.Name = "colLogisticsProviderID"
        Me.colLogisticsProviderID.Visible = True
        Me.colLogisticsProviderID.VisibleIndex = 4
        Me.colLogisticsProviderID.Width = 80
        '
        'colLogisticsname
        '
        Me.colLogisticsname.Caption = "3rd Party Name"
        Me.colLogisticsname.FieldName = "Logisticsname"
        Me.colLogisticsname.Name = "colLogisticsname"
        Me.colLogisticsname.Visible = True
        Me.colLogisticsname.VisibleIndex = 5
        Me.colLogisticsname.Width = 272
        '
        'colQuoteAmount
        '
        Me.colQuoteAmount.FieldName = "QuoteAmount"
        Me.colQuoteAmount.Name = "colQuoteAmount"
        Me.colQuoteAmount.Visible = True
        Me.colQuoteAmount.VisibleIndex = 6
        Me.colQuoteAmount.Width = 89
        '
        'colQuoteDate
        '
        Me.colQuoteDate.FieldName = "QuoteDate"
        Me.colQuoteDate.Name = "colQuoteDate"
        Me.colQuoteDate.Visible = True
        Me.colQuoteDate.VisibleIndex = 7
        Me.colQuoteDate.Width = 92
        '
        'colCarrierQuoteNumber
        '
        Me.colCarrierQuoteNumber.FieldName = "CarrierQuoteNumber"
        Me.colCarrierQuoteNumber.Name = "colCarrierQuoteNumber"
        Me.colCarrierQuoteNumber.Visible = True
        Me.colCarrierQuoteNumber.VisibleIndex = 8
        Me.colCarrierQuoteNumber.Width = 210
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmLoadProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 742)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmLoadProcessing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Load Processing"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonLargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.LoadNotesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.BillCustomerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddToInvoiceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadQuotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsLoadItems As System.Windows.Forms.BindingSource
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colLoadID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyContainers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourceType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourceID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnline As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDotdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassrate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazclassnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPackagegroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsLoadInfo As System.Windows.Forms.BindingSource
    Friend WithEvents bsLoadQuotes As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents colLoadQuoteID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsProviderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierQuoteNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnBack As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnSchedule As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditCharges As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditBillings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rbtnPrintLoadInfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonLargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents OriginCityLabel1 As System.Windows.Forms.Label
    Friend WithEvents PickupHoursLabel1 As System.Windows.Forms.Label
    Friend WithEvents OriginAddress2Label1 As System.Windows.Forms.Label
    Friend WithEvents OriginAddress1Label1 As System.Windows.Forms.Label
    Friend WithEvents OriginPhoneLabel1 As System.Windows.Forms.Label
    Friend WithEvents OriginNameLabel1 As System.Windows.Forms.Label
    Friend WithEvents OriginStateLabel1 As System.Windows.Forms.Label
    Friend WithEvents OriginContactLabel1 As System.Windows.Forms.Label
    Friend WithEvents OriginZipLabel1 As System.Windows.Forms.Label
    Friend WithEvents OriginCountryLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BillCustomerCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AddToInvoiceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ModifiedTimeLabel1 As System.Windows.Forms.Label
    Friend WithEvents ModifiedByLabel1 As System.Windows.Forms.Label
    Friend WithEvents LoadNotesMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rbtnDeleteLoadBillingRecs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSelectVendor As DevExpress.XtraEditors.SimpleButton
End Class
