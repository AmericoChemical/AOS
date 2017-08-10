<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesDataAnalysis

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
        Dim lblBeginDate As System.Windows.Forms.Label
        Dim CustIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSalesDataAnalysis))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetQtrlyData = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnSalespersonCustomerDetailedData = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnExportQtrlyData = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnExportCustomerData = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gcQrtlySalesSummary = New DevExpress.XtraEditors.GroupControl()
        Me.grQtrlySalesData = New DevExpress.XtraGrid.GridControl()
        Me.bsQtrlyData = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvQtrlyTotals = New CustomDevExGridView()
        Me.colSalesID11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSaleslevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesbycustomerreport = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYtd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSalespersonCustomerDetailedData = New DevExpress.XtraEditors.GroupControl()
        Me.grSalespersonCustomerSalesData = New DevExpress.XtraGrid.GridControl()
        Me.bsCustomerSalesData = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvCustomerSalesData = New CustomDevExGridView()
        Me.colSalesID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colServiceRep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFeb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMay = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJul = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAug = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSep = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOct = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNov = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDec = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYtd = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grpParameters = New DevExpress.XtraEditors.GroupControl()
        Me.eEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.eStartDate = New DevExpress.XtraEditors.DateEdit()
        lblBeginDate = New System.Windows.Forms.Label()
        CustIDLabel = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gcQrtlySalesSummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcQrtlySalesSummary.SuspendLayout()
        CType(Me.grQtrlySalesData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsQtrlyData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvQtrlyTotals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcSalespersonCustomerDetailedData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcSalespersonCustomerDetailedData.SuspendLayout()
        CType(Me.grSalespersonCustomerSalesData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomerSalesData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCustomerSalesData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpParameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParameters.SuspendLayout()
        CType(Me.eEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBeginDate
        '
        lblBeginDate.AutoSize = True
        lblBeginDate.Location = New System.Drawing.Point(7, 33)
        lblBeginDate.Name = "lblBeginDate"
        lblBeginDate.Size = New System.Drawing.Size(61, 13)
        lblBeginDate.TabIndex = 1
        lblBeginDate.Text = "Start Date:"
        '
        'CustIDLabel
        '
        CustIDLabel.AutoSize = True
        CustIDLabel.Location = New System.Drawing.Point(7, 59)
        CustIDLabel.Name = "CustIDLabel"
        CustIDLabel.Size = New System.Drawing.Size(55, 13)
        CustIDLabel.TabIndex = 3
        CustIDLabel.Text = "End Date:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnClose, Me.rbtnGetQtrlyData, Me.rbtnSalespersonCustomerDetailedData, Me.rbtnExportQtrlyData, Me.rbtnExportCustomerData})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 9
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1560, 93)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 0
        Me.btnClose.LargeImageIndex = 41
        Me.btnClose.Name = "btnClose"
        '
        'rbtnGetQtrlyData
        '
        Me.rbtnGetQtrlyData.Caption = "Get Sales Data"
        Me.rbtnGetQtrlyData.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnGetQtrlyData.Id = 5
        Me.rbtnGetQtrlyData.LargeImageIndex = 27
        Me.rbtnGetQtrlyData.LargeWidth = 75
        Me.rbtnGetQtrlyData.Name = "rbtnGetQtrlyData"
        '
        'rbtnSalespersonCustomerDetailedData
        '
        Me.rbtnSalespersonCustomerDetailedData.Caption = "Get Sales Data"
        Me.rbtnSalespersonCustomerDetailedData.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnSalespersonCustomerDetailedData.Id = 6
        Me.rbtnSalespersonCustomerDetailedData.LargeImageIndex = 27
        Me.rbtnSalespersonCustomerDetailedData.LargeWidth = 75
        Me.rbtnSalespersonCustomerDetailedData.Name = "rbtnSalespersonCustomerDetailedData"
        '
        'rbtnExportQtrlyData
        '
        Me.rbtnExportQtrlyData.Caption = "Export to Excel"
        Me.rbtnExportQtrlyData.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnExportQtrlyData.Id = 7
        Me.rbtnExportQtrlyData.LargeImageIndex = 43
        Me.rbtnExportQtrlyData.LargeWidth = 75
        Me.rbtnExportQtrlyData.Name = "rbtnExportQtrlyData"
        '
        'rbtnExportCustomerData
        '
        Me.rbtnExportCustomerData.Caption = "Export to Excel"
        Me.rbtnExportCustomerData.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnExportCustomerData.Id = 8
        Me.rbtnExportCustomerData.LargeImageIndex = 43
        Me.rbtnExportCustomerData.LargeWidth = 75
        Me.rbtnExportCustomerData.Name = "rbtnExportCustomerData"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Actions"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnGetQtrlyData)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnExportQtrlyData, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Quarterly Summary"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnSalespersonCustomerDetailedData)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnExportCustomerData, True)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Customer Monthly Summary"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.gcSalespersonCustomerDetailedData)
        Me.PanelControl1.Controls.Add(Me.gcQrtlySalesSummary)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.grpParameters)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 93)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl1.Size = New System.Drawing.Size(1560, 634)
        Me.PanelControl1.TabIndex = 10
        '
        'gcQrtlySalesSummary
        '
        Me.gcQrtlySalesSummary.Controls.Add(Me.grQtrlySalesData)
        Me.gcQrtlySalesSummary.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcQrtlySalesSummary.Location = New System.Drawing.Point(9, 102)
        Me.gcQrtlySalesSummary.Name = "gcQrtlySalesSummary"
        Me.gcQrtlySalesSummary.Size = New System.Drawing.Size(1542, 523)
        Me.gcQrtlySalesSummary.TabIndex = 13
        Me.gcQrtlySalesSummary.Text = "Quarterly Sales Summary"
        '
        'grQtrlySalesData
        '
        Me.grQtrlySalesData.DataSource = Me.bsQtrlyData
        Me.grQtrlySalesData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grQtrlySalesData.Location = New System.Drawing.Point(2, 21)
        Me.grQtrlySalesData.MainView = Me.grvQtrlyTotals
        Me.grQtrlySalesData.MenuManager = Me.RibbonControl1
        Me.grQtrlySalesData.Name = "grQtrlySalesData"
        Me.grQtrlySalesData.Size = New System.Drawing.Size(1538, 500)
        Me.grQtrlySalesData.TabIndex = 0
        Me.grQtrlySalesData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvQtrlyTotals})
        '
        'bsQtrlyData
        '
        Me.bsQtrlyData.DataSource = GetType(AOS.BusinessObjects.ViewSalesQtrlyTotalsInvoiceDateRestrictedCollection)
        '
        'grvQtrlyTotals
        '
        Me.grvQtrlyTotals.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSalesID11, Me.colSName1, Me.colSaleslevel, Me.colSalesbycustomerreport, Me.colYear1, Me.colQtr11, Me.colQtr21, Me.colQtr31, Me.colQtr41, Me.colYtd1})
        Me.grvQtrlyTotals.GridControl = Me.grQtrlySalesData
        Me.grvQtrlyTotals.Name = "grvQtrlyTotals"
        Me.grvQtrlyTotals.OptionsBehavior.Editable = False
        Me.grvQtrlyTotals.OptionsView.ShowAutoFilterRow = True
        Me.grvQtrlyTotals.OptionsView.ShowGroupPanel = False
        '
        'colSalesID11
        '
        Me.colSalesID11.Caption = "ID"
        Me.colSalesID11.FieldName = "SalesID1"
        Me.colSalesID11.Name = "colSalesID11"
        Me.colSalesID11.Visible = True
        Me.colSalesID11.VisibleIndex = 0
        '
        'colSName1
        '
        Me.colSName1.Caption = "Salesperson Name"
        Me.colSName1.FieldName = "SName1"
        Me.colSName1.Name = "colSName1"
        Me.colSName1.Visible = True
        Me.colSName1.VisibleIndex = 1
        '
        'colSaleslevel
        '
        Me.colSaleslevel.FieldName = "Saleslevel"
        Me.colSaleslevel.Name = "colSaleslevel"
        '
        'colSalesbycustomerreport
        '
        Me.colSalesbycustomerreport.FieldName = "Salesbycustomerreport"
        Me.colSalesbycustomerreport.Name = "colSalesbycustomerreport"
        '
        'colYear1
        '
        Me.colYear1.FieldName = "Year"
        Me.colYear1.Name = "colYear1"
        Me.colYear1.Visible = True
        Me.colYear1.VisibleIndex = 2
        '
        'colQtr11
        '
        Me.colQtr11.FieldName = "Qtr1"
        Me.colQtr11.Name = "colQtr11"
        Me.colQtr11.Visible = True
        Me.colQtr11.VisibleIndex = 3
        '
        'colQtr21
        '
        Me.colQtr21.FieldName = "Qtr2"
        Me.colQtr21.Name = "colQtr21"
        Me.colQtr21.Visible = True
        Me.colQtr21.VisibleIndex = 4
        '
        'colQtr31
        '
        Me.colQtr31.FieldName = "Qtr3"
        Me.colQtr31.Name = "colQtr31"
        Me.colQtr31.Visible = True
        Me.colQtr31.VisibleIndex = 5
        '
        'colQtr41
        '
        Me.colQtr41.FieldName = "Qtr4"
        Me.colQtr41.Name = "colQtr41"
        Me.colQtr41.Visible = True
        Me.colQtr41.VisibleIndex = 6
        '
        'colYtd1
        '
        Me.colYtd1.FieldName = "Ytd"
        Me.colYtd1.Name = "colYtd1"
        Me.colYtd1.Visible = True
        Me.colYtd1.VisibleIndex = 7
        '
        'gcSalespersonCustomerDetailedData
        '
        Me.gcSalespersonCustomerDetailedData.Controls.Add(Me.grSalespersonCustomerSalesData)
        Me.gcSalespersonCustomerDetailedData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSalespersonCustomerDetailedData.Location = New System.Drawing.Point(9, 102)
        Me.gcSalespersonCustomerDetailedData.Name = "gcSalespersonCustomerDetailedData"
        Me.gcSalespersonCustomerDetailedData.Size = New System.Drawing.Size(1542, 523)
        Me.gcSalespersonCustomerDetailedData.TabIndex = 12
        Me.gcSalespersonCustomerDetailedData.Text = "Salesperson / Customer Detailed Data"
        '
        'grSalespersonCustomerSalesData
        '
        Me.grSalespersonCustomerSalesData.DataSource = Me.bsCustomerSalesData
        Me.grSalespersonCustomerSalesData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grSalespersonCustomerSalesData.Location = New System.Drawing.Point(2, 21)
        Me.grSalespersonCustomerSalesData.MainView = Me.grvCustomerSalesData
        Me.grSalespersonCustomerSalesData.MenuManager = Me.RibbonControl1
        Me.grSalespersonCustomerSalesData.Name = "grSalespersonCustomerSalesData"
        Me.grSalespersonCustomerSalesData.Size = New System.Drawing.Size(1538, 500)
        Me.grSalespersonCustomerSalesData.TabIndex = 1
        Me.grSalespersonCustomerSalesData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCustomerSalesData})
        '
        'bsCustomerSalesData
        '
        Me.bsCustomerSalesData.DataSource = GetType(AOS.BusinessObjects.ViewSalespersonCustomerDetailedDataCollection)
        '
        'grvCustomerSalesData
        '
        Me.grvCustomerSalesData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSalesID1, Me.colSalesName, Me.colId, Me.colCustname, Me.colServiceRep, Me.colYear, Me.colJan, Me.colFeb, Me.colMar, Me.colQtr1, Me.colApr, Me.colMay, Me.colJun, Me.colQtr2, Me.colJul, Me.colAug, Me.colSep, Me.colQtr3, Me.colOct, Me.colNov, Me.colDec, Me.colQtr4, Me.colYtd})
        Me.grvCustomerSalesData.GridControl = Me.grSalespersonCustomerSalesData
        Me.grvCustomerSalesData.Name = "grvCustomerSalesData"
        Me.grvCustomerSalesData.OptionsBehavior.Editable = False
        Me.grvCustomerSalesData.OptionsView.ShowAutoFilterRow = True
        Me.grvCustomerSalesData.OptionsView.ShowGroupPanel = False
        '
        'colSalesID1
        '
        Me.colSalesID1.FieldName = "SalesID1"
        Me.colSalesID1.Name = "colSalesID1"
        '
        'colSalesName
        '
        Me.colSalesName.FieldName = "SalesName"
        Me.colSalesName.Name = "colSalesName"
        Me.colSalesName.Visible = True
        Me.colSalesName.VisibleIndex = 0
        Me.colSalesName.Width = 127
        '
        'colId
        '
        Me.colId.Caption = "ID"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 1
        Me.colId.Width = 45
        '
        'colCustname
        '
        Me.colCustname.Caption = "CustName"
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 2
        Me.colCustname.Width = 191
        '
        'colServiceRep
        '
        Me.colServiceRep.Caption = "SecondRep"
        Me.colServiceRep.FieldName = "ServiceRep"
        Me.colServiceRep.Name = "colServiceRep"
        Me.colServiceRep.Visible = True
        Me.colServiceRep.VisibleIndex = 3
        Me.colServiceRep.Width = 90
        '
        'colYear
        '
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.VisibleIndex = 4
        Me.colYear.Width = 42
        '
        'colJan
        '
        Me.colJan.FieldName = "Jan"
        Me.colJan.Name = "colJan"
        Me.colJan.Visible = True
        Me.colJan.VisibleIndex = 5
        Me.colJan.Width = 57
        '
        'colFeb
        '
        Me.colFeb.FieldName = "Feb"
        Me.colFeb.Name = "colFeb"
        Me.colFeb.Visible = True
        Me.colFeb.VisibleIndex = 6
        Me.colFeb.Width = 57
        '
        'colMar
        '
        Me.colMar.FieldName = "Mar"
        Me.colMar.Name = "colMar"
        Me.colMar.Visible = True
        Me.colMar.VisibleIndex = 7
        Me.colMar.Width = 57
        '
        'colQtr1
        '
        Me.colQtr1.FieldName = "Qtr1"
        Me.colQtr1.Name = "colQtr1"
        Me.colQtr1.Visible = True
        Me.colQtr1.VisibleIndex = 8
        Me.colQtr1.Width = 57
        '
        'colApr
        '
        Me.colApr.FieldName = "Apr"
        Me.colApr.Name = "colApr"
        Me.colApr.Visible = True
        Me.colApr.VisibleIndex = 9
        Me.colApr.Width = 57
        '
        'colMay
        '
        Me.colMay.FieldName = "May"
        Me.colMay.Name = "colMay"
        Me.colMay.Visible = True
        Me.colMay.VisibleIndex = 10
        Me.colMay.Width = 57
        '
        'colJun
        '
        Me.colJun.FieldName = "Jun"
        Me.colJun.Name = "colJun"
        Me.colJun.Visible = True
        Me.colJun.VisibleIndex = 11
        Me.colJun.Width = 57
        '
        'colQtr2
        '
        Me.colQtr2.FieldName = "Qtr2"
        Me.colQtr2.Name = "colQtr2"
        Me.colQtr2.Visible = True
        Me.colQtr2.VisibleIndex = 12
        Me.colQtr2.Width = 57
        '
        'colJul
        '
        Me.colJul.FieldName = "Jul"
        Me.colJul.Name = "colJul"
        Me.colJul.Visible = True
        Me.colJul.VisibleIndex = 13
        Me.colJul.Width = 57
        '
        'colAug
        '
        Me.colAug.FieldName = "Aug"
        Me.colAug.Name = "colAug"
        Me.colAug.Visible = True
        Me.colAug.VisibleIndex = 14
        Me.colAug.Width = 57
        '
        'colSep
        '
        Me.colSep.FieldName = "Sep"
        Me.colSep.Name = "colSep"
        Me.colSep.Visible = True
        Me.colSep.VisibleIndex = 15
        Me.colSep.Width = 57
        '
        'colQtr3
        '
        Me.colQtr3.FieldName = "Qtr3"
        Me.colQtr3.Name = "colQtr3"
        Me.colQtr3.Visible = True
        Me.colQtr3.VisibleIndex = 16
        Me.colQtr3.Width = 57
        '
        'colOct
        '
        Me.colOct.FieldName = "Oct"
        Me.colOct.Name = "colOct"
        Me.colOct.Visible = True
        Me.colOct.VisibleIndex = 17
        Me.colOct.Width = 57
        '
        'colNov
        '
        Me.colNov.FieldName = "Nov"
        Me.colNov.Name = "colNov"
        Me.colNov.Visible = True
        Me.colNov.VisibleIndex = 18
        Me.colNov.Width = 57
        '
        'colDec
        '
        Me.colDec.FieldName = "Dec"
        Me.colDec.Name = "colDec"
        Me.colDec.Visible = True
        Me.colDec.VisibleIndex = 19
        Me.colDec.Width = 57
        '
        'colQtr4
        '
        Me.colQtr4.FieldName = "Qtr4"
        Me.colQtr4.Name = "colQtr4"
        Me.colQtr4.Visible = True
        Me.colQtr4.VisibleIndex = 20
        Me.colQtr4.Width = 57
        '
        'colYtd
        '
        Me.colYtd.FieldName = "Ytd"
        Me.colYtd.Name = "colYtd"
        Me.colYtd.Visible = True
        Me.colYtd.VisibleIndex = 21
        Me.colYtd.Width = 114
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(9, 96)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1542, 6)
        Me.PanelControl2.TabIndex = 11
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.eEndDate)
        Me.grpParameters.Controls.Add(Me.eStartDate)
        Me.grpParameters.Controls.Add(lblBeginDate)
        Me.grpParameters.Controls.Add(CustIDLabel)
        Me.grpParameters.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpParameters.Location = New System.Drawing.Point(9, 9)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(1542, 87)
        Me.grpParameters.TabIndex = 10
        Me.grpParameters.Text = "Analysis Parameters"
        '
        'eEndDate
        '
        Me.eEndDate.EditValue = Nothing
        Me.eEndDate.Location = New System.Drawing.Point(88, 56)
        Me.eEndDate.MenuManager = Me.RibbonControl1
        Me.eEndDate.Name = "eEndDate"
        Me.eEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eEndDate.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.eEndDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.eEndDate.Size = New System.Drawing.Size(100, 20)
        Me.eEndDate.TabIndex = 5
        '
        'eStartDate
        '
        Me.eStartDate.EditValue = Nothing
        Me.eStartDate.Location = New System.Drawing.Point(88, 30)
        Me.eStartDate.MenuManager = Me.RibbonControl1
        Me.eStartDate.Name = "eStartDate"
        Me.eStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eStartDate.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.eStartDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.eStartDate.Size = New System.Drawing.Size(100, 20)
        Me.eStartDate.TabIndex = 4
        '
        'frmSalesDataAnalysis
        '
        Me.ClientSize = New System.Drawing.Size(1560, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmSalesDataAnalysis"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sales Data Analysis"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gcQrtlySalesSummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcQrtlySalesSummary.ResumeLayout(False)
        CType(Me.grQtrlySalesData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsQtrlyData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvQtrlyTotals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcSalespersonCustomerDetailedData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcSalespersonCustomerDetailedData.ResumeLayout(False)
        CType(Me.grSalespersonCustomerSalesData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomerSalesData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCustomerSalesData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpParameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParameters.ResumeLayout(False)
        Me.grpParameters.PerformLayout()
        CType(Me.eEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpParameters As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents rbtnGetQtrlyData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnSalespersonCustomerDetailedData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gcQrtlySalesSummary As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcSalespersonCustomerDetailedData As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents grSalespersonCustomerSalesData As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCustomerSalesData As CustomDevExGridView
    Friend WithEvents grQtrlySalesData As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvQtrlyTotals As CustomDevExGridView
    Friend WithEvents bsQtrlyData As System.Windows.Forms.BindingSource
    Friend WithEvents bsCustomerSalesData As System.Windows.Forms.BindingSource
    Friend WithEvents colSalesID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colServiceRep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFeb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJul As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAug As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOct As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDec As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYtd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesID11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSaleslevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesbycustomerreport As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYtd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnExportQtrlyData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnExportCustomerData As DevExpress.XtraBars.BarButtonItem
End Class
