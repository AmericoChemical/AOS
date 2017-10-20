<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewSalesCustomers

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
        Dim CustidLabel As System.Windows.Forms.Label
        Dim CustnameLabel As System.Windows.Forms.Label
        Dim Custshipaddress1Label As System.Windows.Forms.Label
        Dim Custshipaddress2Label As System.Windows.Forms.Label
        Dim CustshipcityLabel As System.Windows.Forms.Label
        Dim CustshipstateprovLabel As System.Windows.Forms.Label
        Dim CustshippostalcodeLabel As System.Windows.Forms.Label
        Dim Custbilladdress1Label As System.Windows.Forms.Label
        Dim Custbilladdress2Label As System.Windows.Forms.Label
        Dim CustbillcityLabel As System.Windows.Forms.Label
        Dim CustbillstateprovLabel As System.Windows.Forms.Label
        Dim CustbillpostalcodeLabel As System.Windows.Forms.Label
        Dim CustphoneLabel As System.Windows.Forms.Label
        Dim CustfaxLabel As System.Windows.Forms.Label
        Dim IsactiveLabel As System.Windows.Forms.Label
        Dim CarrieridLabel As System.Windows.Forms.Label
        Dim LogisticsidLabel As System.Windows.Forms.Label
        Dim BulkcarrieridLabel As System.Windows.Forms.Label
        Dim FobLabel As System.Windows.Forms.Label
        Dim CustnotesLabel As System.Windows.Forms.Label
        Dim SalespersonidLabel As System.Windows.Forms.Label
        Dim FreightbillcustomerLabel As System.Windows.Forms.Label
        Dim FreightoninvoiceLabel As System.Windows.Forms.Label
        Dim CustemailLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewSalesCustomers))
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAddCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddSalesperson = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditSalesperson = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteSalesperson = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddPriceListItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPriceListItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeletePriceListItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddAssignment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditAssignment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteAssignment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRefreshCompleteShipments = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCreateInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFilterPending = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFilterReceivable = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFilterPaid = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFilterVoid = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFilterAll = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintPriceList = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCloseShipment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConvertWorkOrderToInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTransferInvoicesToQuickbooks = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintCustomerPaymentHistory = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddCustomerPayment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCustomerPayment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCustomerPayment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintCustomerPmtByDate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnManageCustomerAssignments = New DevExpress.XtraBars.BarButtonItem()
        Me.btnManageSalespersonData = New DevExpress.XtraBars.BarButtonItem()
        Me.luActiveSalesPerson = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsSalesperson = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnAddCommissionRec = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCommissionRec = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCommissionRec = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFetchForecastedCommissions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFetchPayableCommissions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintForecastedCommissions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintPayableCommissions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnManageCommissionPayments = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarkCommissionForecasted = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarkCommissionPayable = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarkCommissionPaid = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintCommissionsByCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.eHistoryStart = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.eHistoryEnd = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.eCustomerSelector = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsCustomerSelector = New System.Windows.Forms.BindingSource(Me.components)
        Me.eFetchSalesHistoryData = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnExportSalesHistoryData = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnUpdateCustomers = New DevExpress.XtraBars.BarButtonItem()
        Me.eProductLookup = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.eProductStart = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.eProductEnd = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.rbtnGetProductSales = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintCustomerProductList = New DevExpress.XtraBars.BarButtonItem()
        Me.printInvoiceHistoryReport = New DevExpress.XtraBars.BarButtonItem()
        Me.rluSalesperson = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsSalesPersonList3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.rbtnGetSalesAnalysisData = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnExportSalesDataToExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.rluSalesYear = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsSalesYears = New System.Windows.Forms.BindingSource(Me.components)
        Me.rluCustomer = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit18 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsCustomerLookupList = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCompileTrendData = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.rbtnMonthlySalesAnalysis = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterPriceListActive = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterPriceListInActive = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnViewPrintSDSDocument = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterSalesACTIVE = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterSalesINACTIVE = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetSalesAnalysisByCustomerData = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnExportSalesByCustomerAnalysisToExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetSalesPersonAnalysis = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnExportSalesPersonAnalysisToExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetAllCustomersSales = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnWorkOrdersToInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonLargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup29 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup17 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage6 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup18 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup14 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage7 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup19 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup30 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup24 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup21 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup22 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup23 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup20 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage10 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup25 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup27 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup26 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup28 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage9 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup15 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup16 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.grpCommissions = New DevExpress.XtraEditors.GroupControl()
        Me.grCommissions = New DevExpress.XtraGrid.GridControl()
        Me.bsCommissions = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvCommissions = New AOS.CustomClasses.CustomDevExGridView()
        Me.colCommissiondate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.colInvoicenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommissionamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommissionstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommissiondesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommissiontype1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatecustomerpaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatecommissionpaid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommissionnote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommissionid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVariance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuditflag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CustomerLookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsCustomerList = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAddCommission = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCommission = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCommission = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddCommissionPmt = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCommissionFilterPending = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCommissionFilterPayable = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCommissionFilterPaid = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintCommForecast = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintCommPayable = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintPaidCommissionsRpt = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCommissionTypes = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCommissionBalancesDue = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarkPayable = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarkPaid = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarkPending = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintCommPmtRegister = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintCommByCustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCommissonAuditReport = New DevExpress.XtraBars.BarButtonItem()
        Me.eInvPaidThruDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.rbtnFilterPayableCommByDate = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterPayableCommAll = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem4 = New DevExpress.XtraBars.BarStaticItem()
        Me.rbtnMiscMarkPayableAsPaid = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkCommissionAsAudited = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptCommWithExceptions = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRptPayableWithExceptions = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintCommPmtRegisterWithExceptions = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage20 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgFilter = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup33 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage8 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup31 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup32 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.pnlSalesTop = New DevExpress.XtraEditors.PanelControl()
        Me.grpCustomerAssignments = New DevExpress.XtraEditors.GroupControl()
        Me.grAssignments = New DevExpress.XtraGrid.GridControl()
        Me.bsAssignments = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colCustID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCommissionType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommissionRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grSalesperson = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colSalespersonfirstname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalespersonlastname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grpCommissionData = New DevExpress.XtraEditors.GroupControl()
        Me.grCommissionData = New DevExpress.XtraGrid.GridControl()
        Me.grvCommissionData = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCommissionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.grSalesHistory = New DevExpress.XtraGrid.GridControl()
        Me.bsSalesHistory = New System.Windows.Forms.BindingSource(Me.components)
        Me.gridViewSalesHistory = New AOS.CustomClasses.CustomDevExGridView()
        Me.colCustid6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicenumber3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicedate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.gcPriceLists = New DevExpress.XtraEditors.GroupControl()
        Me.grPriceLists = New DevExpress.XtraGrid.GridControl()
        Me.bsPriceLists = New System.Windows.Forms.BindingSource(Me.components)
        Me.viewPriceList = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPricemethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainerprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEffectivedate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriceliststatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductLookupEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnExportToXLS = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.luCustomerList = New DevExpress.XtraEditors.LookUpEdit()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl15 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.CustphoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustfaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl14 = New DevExpress.XtraEditors.GroupControl()
        Me.MemoEdit3 = New DevExpress.XtraEditors.MemoEdit()
        Me.MemoEdit2 = New DevExpress.XtraEditors.MemoEdit()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.CustnotesMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl13 = New DevExpress.XtraEditors.GroupControl()
        Me.FreightoninvoiceCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.FreightbillcustomerCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.CarrieridLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.FobTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BulkcarrieridLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsBulkCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.LogisticsidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl12 = New DevExpress.XtraEditors.GroupControl()
        Me.CustbillcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Custbilladdress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustbillpostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Custbilladdress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustbillcountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustbillstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustbillcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl11 = New DevExpress.XtraEditors.GroupControl()
        Me.Custshipaddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Custshipaddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshipcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshipstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshippostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshipcountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustshipcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl10 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.SalespersonIDLookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsSalesPersonList2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalespersonidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsSalespersonList = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsactiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.CustnameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grCustomers = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colCustid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grInvoices = New DevExpress.XtraGrid.GridControl()
        Me.bsInvoices = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvInvoiceList = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvoicenumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicedate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colSubtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalestax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicestatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.gcSalesByCustomerAnalysis = New DevExpress.XtraEditors.GroupControl()
        Me.grcSalesByCustomerAnalysis = New DevExpress.XtraGrid.GridControl()
        Me.bsSalesByCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvSalesByCustomerAnalysis = New AOS.CustomClasses.CustomDevExGridView()
        Me.colSalesName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustId_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustName_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalesRepName_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYear_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJAN_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFEB_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAR_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr1_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAPR_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMAY_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJUN_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr2_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colJUL_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAUG_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSEP_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr3_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOCT_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOV_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDEC_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtr4_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colYTD_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevYear_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevJAN_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevFEB_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevMAR_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevQtr1_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevAPR_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevMAY_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevJUN_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevQtr2_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevJUL_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevAUG_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevSEP_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevQtr3_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevOCT_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevNOV_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevDEC_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevQtr4_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrevTotal_SalesByCustomerAnalysis = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcSalesAnalysis = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.bsSalesData = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvSalesAnalysis = New AOS.CustomClasses.CustomDevExGridView()
        Me.colCustid7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSName2 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.gcCustomerAnalysis = New DevExpress.XtraEditors.GroupControl()
        Me.gcCompanyAnalysis = New DevExpress.XtraEditors.GroupControl()
        Me.RibbonPanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.bsInvoicePayments = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView10 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvoicenumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicepmtamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsCustomerPayments = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView8 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colPaymentdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPaymentamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemittanceadvice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.eCustomerLookup = New DevExpress.XtraEditors.LookUpEdit()
        Me.RibbonPanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.grShipments = New DevExpress.XtraGrid.GridControl()
        Me.bsShipments = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView9 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colShipmentnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colCustomerpo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.bsTrendsMonthly = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsTrendsQuarterly = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsTrendsAnnually = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CustidLabel = New System.Windows.Forms.Label()
        CustnameLabel = New System.Windows.Forms.Label()
        Custshipaddress1Label = New System.Windows.Forms.Label()
        Custshipaddress2Label = New System.Windows.Forms.Label()
        CustshipcityLabel = New System.Windows.Forms.Label()
        CustshipstateprovLabel = New System.Windows.Forms.Label()
        CustshippostalcodeLabel = New System.Windows.Forms.Label()
        Custbilladdress1Label = New System.Windows.Forms.Label()
        Custbilladdress2Label = New System.Windows.Forms.Label()
        CustbillcityLabel = New System.Windows.Forms.Label()
        CustbillstateprovLabel = New System.Windows.Forms.Label()
        CustbillpostalcodeLabel = New System.Windows.Forms.Label()
        CustphoneLabel = New System.Windows.Forms.Label()
        CustfaxLabel = New System.Windows.Forms.Label()
        IsactiveLabel = New System.Windows.Forms.Label()
        CarrieridLabel = New System.Windows.Forms.Label()
        LogisticsidLabel = New System.Windows.Forms.Label()
        BulkcarrieridLabel = New System.Windows.Forms.Label()
        FobLabel = New System.Windows.Forms.Label()
        CustnotesLabel = New System.Windows.Forms.Label()
        SalespersonidLabel = New System.Windows.Forms.Label()
        FreightbillcustomerLabel = New System.Windows.Forms.Label()
        FreightoninvoiceLabel = New System.Windows.Forms.Label()
        CustemailLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalesperson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomerSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalesPersonList3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalesYears, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomerLookupList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonLargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl5.SuspendLayout()
        CType(Me.grpCommissions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCommissions.SuspendLayout()
        CType(Me.grCommissions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCommissions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCommissions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit5.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlSalesTop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSalesTop.SuspendLayout()
        CType(Me.grpCustomerAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCustomerAssignments.SuspendLayout()
        CType(Me.grAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grSalesperson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.grpCommissionData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCommissionData.SuspendLayout()
        CType(Me.grCommissionData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCommissionData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl10.SuspendLayout()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.grSalesHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalesHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridViewSalesHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.gcPriceLists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcPriceLists.SuspendLayout()
        CType(Me.grPriceLists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPriceLists, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewPriceList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLookupEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.luCustomerList.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.GroupControl15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl15.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustfaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl14.SuspendLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustnotesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl13.SuspendLayout()
        CType(Me.FreightoninvoiceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FreightbillcustomerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FobTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulkcarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBulkCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticsidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl12.SuspendLayout()
        CType(Me.CustbillcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Custbilladdress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustbillpostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Custbilladdress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustbillcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustbillstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustbillcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl11.SuspendLayout()
        CType(Me.Custshipaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Custshipaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshipcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshipstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshippostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshipcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustshipcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl10.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalespersonIDLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalesPersonList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalespersonidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalespersonList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl4.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvoices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvInvoiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl9.SuspendLayout()
        CType(Me.gcSalesByCustomerAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcSalesByCustomerAnalysis.SuspendLayout()
        CType(Me.grcSalesByCustomerAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalesByCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvSalesByCustomerAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcSalesAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcSalesAnalysis.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSalesData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvSalesAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCustomerAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCompanyAnalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl7.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvoicePayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomerPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.eCustomerLookup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl6.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.grShipments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShipments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTrendsMonthly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTrendsQuarterly, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTrendsAnnually, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(9, 26)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(43, 13)
        CustidLabel.TabIndex = 0
        CustidLabel.Text = "Cust ID"
        '
        'CustnameLabel
        '
        CustnameLabel.AutoSize = True
        CustnameLabel.Location = New System.Drawing.Point(9, 52)
        CustnameLabel.Name = "CustnameLabel"
        CustnameLabel.Size = New System.Drawing.Size(52, 13)
        CustnameLabel.TabIndex = 2
        CustnameLabel.Text = "Company"
        '
        'Custshipaddress1Label
        '
        Custshipaddress1Label.AutoSize = True
        Custshipaddress1Label.Location = New System.Drawing.Point(9, 27)
        Custshipaddress1Label.Name = "Custshipaddress1Label"
        Custshipaddress1Label.Size = New System.Drawing.Size(55, 13)
        Custshipaddress1Label.TabIndex = 4
        Custshipaddress1Label.Text = "Address 1"
        '
        'Custshipaddress2Label
        '
        Custshipaddress2Label.AutoSize = True
        Custshipaddress2Label.Location = New System.Drawing.Point(9, 53)
        Custshipaddress2Label.Name = "Custshipaddress2Label"
        Custshipaddress2Label.Size = New System.Drawing.Size(55, 13)
        Custshipaddress2Label.TabIndex = 6
        Custshipaddress2Label.Text = "Address 2"
        '
        'CustshipcityLabel
        '
        CustshipcityLabel.AutoSize = True
        CustshipcityLabel.Location = New System.Drawing.Point(9, 79)
        CustshipcityLabel.Name = "CustshipcityLabel"
        CustshipcityLabel.Size = New System.Drawing.Size(58, 13)
        CustshipcityLabel.TabIndex = 8
        CustshipcityLabel.Text = "City ST Zip"
        '
        'CustshipstateprovLabel
        '
        CustshipstateprovLabel.AutoSize = True
        CustshipstateprovLabel.Location = New System.Drawing.Point(9, 105)
        CustshipstateprovLabel.Name = "CustshipstateprovLabel"
        CustshipstateprovLabel.Size = New System.Drawing.Size(46, 13)
        CustshipstateprovLabel.TabIndex = 10
        CustshipstateprovLabel.Text = "Country"
        '
        'CustshippostalcodeLabel
        '
        CustshippostalcodeLabel.AutoSize = True
        CustshippostalcodeLabel.Location = New System.Drawing.Point(9, 132)
        CustshippostalcodeLabel.Name = "CustshippostalcodeLabel"
        CustshippostalcodeLabel.Size = New System.Drawing.Size(45, 13)
        CustshippostalcodeLabel.TabIndex = 12
        CustshippostalcodeLabel.Text = "Contact"
        '
        'Custbilladdress1Label
        '
        Custbilladdress1Label.AutoSize = True
        Custbilladdress1Label.Location = New System.Drawing.Point(9, 27)
        Custbilladdress1Label.Name = "Custbilladdress1Label"
        Custbilladdress1Label.Size = New System.Drawing.Size(55, 13)
        Custbilladdress1Label.TabIndex = 18
        Custbilladdress1Label.Text = "Address 1"
        '
        'Custbilladdress2Label
        '
        Custbilladdress2Label.AutoSize = True
        Custbilladdress2Label.Location = New System.Drawing.Point(10, 53)
        Custbilladdress2Label.Name = "Custbilladdress2Label"
        Custbilladdress2Label.Size = New System.Drawing.Size(55, 13)
        Custbilladdress2Label.TabIndex = 20
        Custbilladdress2Label.Text = "Address 2"
        '
        'CustbillcityLabel
        '
        CustbillcityLabel.AutoSize = True
        CustbillcityLabel.Location = New System.Drawing.Point(10, 79)
        CustbillcityLabel.Name = "CustbillcityLabel"
        CustbillcityLabel.Size = New System.Drawing.Size(58, 13)
        CustbillcityLabel.TabIndex = 22
        CustbillcityLabel.Text = "City ST Zip"
        '
        'CustbillstateprovLabel
        '
        CustbillstateprovLabel.AutoSize = True
        CustbillstateprovLabel.Location = New System.Drawing.Point(9, 105)
        CustbillstateprovLabel.Name = "CustbillstateprovLabel"
        CustbillstateprovLabel.Size = New System.Drawing.Size(46, 13)
        CustbillstateprovLabel.TabIndex = 24
        CustbillstateprovLabel.Text = "Country"
        '
        'CustbillpostalcodeLabel
        '
        CustbillpostalcodeLabel.AutoSize = True
        CustbillpostalcodeLabel.Location = New System.Drawing.Point(10, 132)
        CustbillpostalcodeLabel.Name = "CustbillpostalcodeLabel"
        CustbillpostalcodeLabel.Size = New System.Drawing.Size(45, 13)
        CustbillpostalcodeLabel.TabIndex = 26
        CustbillpostalcodeLabel.Text = "Contact"
        '
        'CustphoneLabel
        '
        CustphoneLabel.AutoSize = True
        CustphoneLabel.Location = New System.Drawing.Point(9, 27)
        CustphoneLabel.Name = "CustphoneLabel"
        CustphoneLabel.Size = New System.Drawing.Size(53, 13)
        CustphoneLabel.TabIndex = 32
        CustphoneLabel.Text = "Phone No"
        '
        'CustfaxLabel
        '
        CustfaxLabel.AutoSize = True
        CustfaxLabel.Location = New System.Drawing.Point(222, 27)
        CustfaxLabel.Name = "CustfaxLabel"
        CustfaxLabel.Size = New System.Drawing.Size(26, 13)
        CustfaxLabel.TabIndex = 34
        CustfaxLabel.Text = "FAX"
        '
        'IsactiveLabel
        '
        IsactiveLabel.AutoSize = True
        IsactiveLabel.Location = New System.Drawing.Point(678, 3)
        IsactiveLabel.Name = "IsactiveLabel"
        IsactiveLabel.Size = New System.Drawing.Size(37, 13)
        IsactiveLabel.TabIndex = 43
        IsactiveLabel.Text = "Active"
        '
        'CarrieridLabel
        '
        CarrieridLabel.AutoSize = True
        CarrieridLabel.Location = New System.Drawing.Point(7, 107)
        CarrieridLabel.Name = "CarrieridLabel"
        CarrieridLabel.Size = New System.Drawing.Size(69, 13)
        CarrieridLabel.TabIndex = 42
        CarrieridLabel.Text = "Truck Carrier"
        '
        'LogisticsidLabel
        '
        LogisticsidLabel.AutoSize = True
        LogisticsidLabel.Location = New System.Drawing.Point(9, 53)
        LogisticsidLabel.Name = "LogisticsidLabel"
        LogisticsidLabel.Size = New System.Drawing.Size(47, 13)
        LogisticsidLabel.TabIndex = 43
        LogisticsidLabel.Text = "Logistics"
        '
        'BulkcarrieridLabel
        '
        BulkcarrieridLabel.AutoSize = True
        BulkcarrieridLabel.Location = New System.Drawing.Point(9, 133)
        BulkcarrieridLabel.Name = "BulkcarrieridLabel"
        BulkcarrieridLabel.Size = New System.Drawing.Size(62, 13)
        BulkcarrieridLabel.TabIndex = 44
        BulkcarrieridLabel.Text = "Bulk Carrier"
        '
        'FobLabel
        '
        FobLabel.AutoSize = True
        FobLabel.Location = New System.Drawing.Point(9, 27)
        FobLabel.Name = "FobLabel"
        FobLabel.Size = New System.Drawing.Size(67, 13)
        FobLabel.TabIndex = 45
        FobLabel.Text = "Freight Chrg"
        '
        'CustnotesLabel
        '
        CustnotesLabel.AutoSize = True
        CustnotesLabel.Location = New System.Drawing.Point(9, 27)
        CustnotesLabel.Name = "CustnotesLabel"
        CustnotesLabel.Size = New System.Drawing.Size(44, 13)
        CustnotesLabel.TabIndex = 0
        CustnotesLabel.Text = "General"
        '
        'SalespersonidLabel
        '
        SalespersonidLabel.AutoSize = True
        SalespersonidLabel.Location = New System.Drawing.Point(516, 26)
        SalespersonidLabel.Name = "SalespersonidLabel"
        SalespersonidLabel.Size = New System.Drawing.Size(71, 13)
        SalespersonidLabel.TabIndex = 48
        SalespersonidLabel.Text = "Primary Sales"
        '
        'FreightbillcustomerLabel
        '
        FreightbillcustomerLabel.AutoSize = True
        FreightbillcustomerLabel.Location = New System.Drawing.Point(84, 81)
        FreightbillcustomerLabel.Name = "FreightbillcustomerLabel"
        FreightbillcustomerLabel.Size = New System.Drawing.Size(80, 13)
        FreightbillcustomerLabel.TabIndex = 46
        FreightbillcustomerLabel.Text = "Customer Billed"
        '
        'FreightoninvoiceLabel
        '
        FreightoninvoiceLabel.AutoSize = True
        FreightoninvoiceLabel.Location = New System.Drawing.Point(229, 81)
        FreightoninvoiceLabel.Name = "FreightoninvoiceLabel"
        FreightoninvoiceLabel.Size = New System.Drawing.Size(94, 13)
        FreightoninvoiceLabel.TabIndex = 47
        FreightoninvoiceLabel.Text = "Freight on Invoice"
        '
        'CustemailLabel
        '
        CustemailLabel.AutoSize = True
        CustemailLabel.Location = New System.Drawing.Point(9, 53)
        CustemailLabel.Name = "CustemailLabel"
        CustemailLabel.Size = New System.Drawing.Size(57, 13)
        CustemailLabel.TabIndex = 35
        CustemailLabel.Text = "Email Addr"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 107)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(63, 13)
        Label1.TabIndex = 53
        Label1.Text = "Work Order"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(10, 194)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 13)
        Label2.TabIndex = 54
        Label2.Text = "Shipment"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 246)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(42, 13)
        Label3.TabIndex = 55
        Label3.Text = "Invoice"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(501, 48)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(86, 13)
        Label4.TabIndex = 50
        Label4.Text = "Secondary Sales"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(576, 3)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(64, 13)
        Label5.TabIndex = 52
        Label5.Text = "Tax Exempt"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(462, 3)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(69, 13)
        Label6.TabIndex = 54
        Label6.Text = "Consignment"
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
        Me.FormCaption.Size = New System.Drawing.Size(1482, 33)
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
        Me.GridView1.GroupPanelText = "Sales & Customer Management"
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAddCustomer, Me.btnEditCustomer, Me.btnDeleteCustomer, Me.btnAddSalesperson, Me.btnEditSalesperson, Me.btnDeleteSalesperson, Me.btnAddPriceListItem, Me.btnEditPriceListItem, Me.btnDeletePriceListItem, Me.btnAddAssignment, Me.btnEditAssignment, Me.btnDeleteAssignment, Me.btnAddInvoice, Me.btnEditInvoice, Me.btnDeleteInvoice, Me.btnRefreshCompleteShipments, Me.btnCreateInvoice, Me.btnFilterPending, Me.btnFilterReceivable, Me.btnFilterPaid, Me.btnFilterVoid, Me.btnFilterAll, Me.btnPrintInvoice, Me.btnPrintPriceList, Me.btnCloseShipment, Me.btnConvertWorkOrderToInvoice, Me.btnTransferInvoicesToQuickbooks, Me.btnPrintCustomerPaymentHistory, Me.btnAddCustomerPayment, Me.btnEditCustomerPayment, Me.btnDeleteCustomerPayment, Me.btnPrintCustomerPmtByDate, Me.btnManageCustomerAssignments, Me.btnManageSalespersonData, Me.luActiveSalesPerson, Me.BarStaticItem1, Me.BarStaticItem2, Me.btnAddCommissionRec, Me.btnEditCommissionRec, Me.btnDeleteCommissionRec, Me.btnFetchForecastedCommissions, Me.btnFetchPayableCommissions, Me.btnPrintForecastedCommissions, Me.btnPrintPayableCommissions, Me.btnManageCommissionPayments, Me.btnMarkCommissionForecasted, Me.btnMarkCommissionPayable, Me.btnMarkCommissionPaid, Me.btnPrintCommissionsByCustomer, Me.eHistoryStart, Me.eHistoryEnd, Me.eCustomerSelector, Me.eFetchSalesHistoryData, Me.BarButtonItem2, Me.btnExportSalesHistoryData, Me.rbtnUpdateCustomers, Me.eProductLookup, Me.eProductStart, Me.eProductEnd, Me.rbtnGetProductSales, Me.rbtnPrintCustomerProductList, Me.printInvoiceHistoryReport, Me.rluSalesperson, Me.rbtnGetSalesAnalysisData, Me.rbtnExportSalesDataToExcel, Me.rluSalesYear, Me.rluCustomer, Me.BarButtonItem1, Me.rbtnCompileTrendData, Me.BarStaticItem3, Me.rbtnMonthlySalesAnalysis, Me.rbtnFilterPriceListActive, Me.rbtnFilterPriceListInActive, Me.rbtnViewPrintSDSDocument, Me.rbtnFilterSalesACTIVE, Me.rbtnFilterSalesINACTIVE, Me.rbtnGetSalesAnalysisByCustomerData, Me.rbtnExportSalesByCustomerAnalysisToExcel, Me.rbtnGetSalesPersonAnalysis, Me.rbtnExportSalesPersonAnalysisToExcel, Me.rbtnGetAllCustomersSales, Me.rbtnWorkOrdersToInvoice})
        Me.RibbonControl1.LargeImages = Me.RibbonLargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 132
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage3, Me.RibbonPage6, Me.RibbonPage4, Me.RibbonPage7, Me.RibbonPage5, Me.RibbonPage2, Me.RibbonPage10, Me.RibbonPage9})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit9, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemLookUpEdit14, Me.RepositoryItemLookUpEdit15, Me.RepositoryItemDateEdit3, Me.RepositoryItemDateEdit4, Me.RepositoryItemLookUpEdit16, Me.RepositoryItemLookUpEdit17, Me.RepositoryItemLookUpEdit18})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1482, 116)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Caption = "Add New Customer"
        Me.btnAddCustomer.Id = 41
        Me.btnAddCustomer.ImageOptions.Image = CType(resources.GetObject("btnAddCustomer.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddCustomer.ImageOptions.LargeImageIndex = 4
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Tag = "3"
        '
        'btnEditCustomer
        '
        Me.btnEditCustomer.Caption = " Edit  Customer"
        Me.btnEditCustomer.Id = 42
        Me.btnEditCustomer.ImageOptions.Image = CType(resources.GetObject("btnEditCustomer.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditCustomer.ImageOptions.LargeImageIndex = 5
        Me.btnEditCustomer.Name = "btnEditCustomer"
        Me.btnEditCustomer.Tag = "4"
        '
        'btnDeleteCustomer
        '
        Me.btnDeleteCustomer.Caption = "Delete Customer"
        Me.btnDeleteCustomer.Id = 43
        Me.btnDeleteCustomer.ImageOptions.Image = CType(resources.GetObject("btnDeleteCustomer.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteCustomer.ImageOptions.LargeImageIndex = 6
        Me.btnDeleteCustomer.Name = "btnDeleteCustomer"
        Me.btnDeleteCustomer.Tag = "5"
        '
        'btnAddSalesperson
        '
        Me.btnAddSalesperson.Caption = "Add New Salesperson"
        Me.btnAddSalesperson.Id = 45
        Me.btnAddSalesperson.ImageOptions.Image = CType(resources.GetObject("btnAddSalesperson.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddSalesperson.ImageOptions.LargeImage = CType(resources.GetObject("btnAddSalesperson.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddSalesperson.Name = "btnAddSalesperson"
        Me.btnAddSalesperson.Tag = "85"
        '
        'btnEditSalesperson
        '
        Me.btnEditSalesperson.Caption = "Edit Salesperson"
        Me.btnEditSalesperson.Id = 46
        Me.btnEditSalesperson.ImageOptions.Image = CType(resources.GetObject("btnEditSalesperson.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditSalesperson.Name = "btnEditSalesperson"
        Me.btnEditSalesperson.Tag = "86"
        '
        'btnDeleteSalesperson
        '
        Me.btnDeleteSalesperson.Caption = "Delete Salesperson"
        Me.btnDeleteSalesperson.Id = 47
        Me.btnDeleteSalesperson.ImageOptions.Image = CType(resources.GetObject("btnDeleteSalesperson.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteSalesperson.Name = "btnDeleteSalesperson"
        Me.btnDeleteSalesperson.Tag = "87"
        '
        'btnAddPriceListItem
        '
        Me.btnAddPriceListItem.Caption = "Add Price List Item"
        Me.btnAddPriceListItem.Id = 48
        Me.btnAddPriceListItem.ImageOptions.Image = CType(resources.GetObject("btnAddPriceListItem.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddPriceListItem.ImageOptions.LargeImageIndex = 18
        Me.btnAddPriceListItem.Name = "btnAddPriceListItem"
        Me.btnAddPriceListItem.Tag = "8"
        '
        'btnEditPriceListItem
        '
        Me.btnEditPriceListItem.Caption = "Edit Price List Item"
        Me.btnEditPriceListItem.Id = 49
        Me.btnEditPriceListItem.ImageOptions.Image = CType(resources.GetObject("btnEditPriceListItem.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditPriceListItem.ImageOptions.LargeImageIndex = 19
        Me.btnEditPriceListItem.Name = "btnEditPriceListItem"
        Me.btnEditPriceListItem.Tag = "9"
        '
        'btnDeletePriceListItem
        '
        Me.btnDeletePriceListItem.Caption = "Delete Price List Item"
        Me.btnDeletePriceListItem.Id = 50
        Me.btnDeletePriceListItem.ImageOptions.Image = CType(resources.GetObject("btnDeletePriceListItem.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeletePriceListItem.ImageOptions.LargeImageIndex = 20
        Me.btnDeletePriceListItem.Name = "btnDeletePriceListItem"
        Me.btnDeletePriceListItem.Tag = "10"
        '
        'btnAddAssignment
        '
        Me.btnAddAssignment.Caption = "Add Customer Assignment"
        Me.btnAddAssignment.Id = 51
        Me.btnAddAssignment.ImageOptions.Image = CType(resources.GetObject("btnAddAssignment.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddAssignment.ImageOptions.LargeImage = CType(resources.GetObject("btnAddAssignment.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddAssignment.Name = "btnAddAssignment"
        Me.btnAddAssignment.Tag = "88"
        '
        'btnEditAssignment
        '
        Me.btnEditAssignment.Caption = "Edit Customer Assignment"
        Me.btnEditAssignment.Id = 52
        Me.btnEditAssignment.ImageOptions.Image = CType(resources.GetObject("btnEditAssignment.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditAssignment.Name = "btnEditAssignment"
        Me.btnEditAssignment.Tag = "89"
        '
        'btnDeleteAssignment
        '
        Me.btnDeleteAssignment.Caption = "Delete Customer Assigment"
        Me.btnDeleteAssignment.Id = 53
        Me.btnDeleteAssignment.ImageOptions.Image = CType(resources.GetObject("btnDeleteAssignment.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteAssignment.Name = "btnDeleteAssignment"
        Me.btnDeleteAssignment.Tag = "90"
        '
        'btnAddInvoice
        '
        Me.btnAddInvoice.Caption = "Add New Invoice"
        Me.btnAddInvoice.Id = 54
        Me.btnAddInvoice.ImageOptions.Image = CType(resources.GetObject("btnAddInvoice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddInvoice.ImageOptions.LargeImageIndex = 11
        Me.btnAddInvoice.Name = "btnAddInvoice"
        Me.btnAddInvoice.Tag = "69"
        '
        'btnEditInvoice
        '
        Me.btnEditInvoice.Caption = " Edit  Invoice"
        Me.btnEditInvoice.Id = 55
        Me.btnEditInvoice.ImageOptions.Image = CType(resources.GetObject("btnEditInvoice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditInvoice.ImageOptions.LargeImageIndex = 12
        Me.btnEditInvoice.Name = "btnEditInvoice"
        Me.btnEditInvoice.Tag = "70"
        '
        'btnDeleteInvoice
        '
        Me.btnDeleteInvoice.Caption = "Delete Invoice"
        Me.btnDeleteInvoice.Id = 56
        Me.btnDeleteInvoice.ImageOptions.Image = CType(resources.GetObject("btnDeleteInvoice.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteInvoice.ImageOptions.LargeImageIndex = 13
        Me.btnDeleteInvoice.Name = "btnDeleteInvoice"
        Me.btnDeleteInvoice.Tag = "71"
        '
        'btnRefreshCompleteShipments
        '
        Me.btnRefreshCompleteShipments.Caption = "Refresh Complete Shipments"
        Me.btnRefreshCompleteShipments.Id = 57
        Me.btnRefreshCompleteShipments.ImageOptions.LargeImage = CType(resources.GetObject("btnRefreshCompleteShipments.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRefreshCompleteShipments.Name = "btnRefreshCompleteShipments"
        Me.btnRefreshCompleteShipments.Tag = "66"
        '
        'btnCreateInvoice
        '
        Me.btnCreateInvoice.Caption = "Create Invoice from Shipment"
        Me.btnCreateInvoice.Id = 58
        Me.btnCreateInvoice.ImageOptions.LargeImage = CType(resources.GetObject("btnCreateInvoice.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCreateInvoice.Name = "btnCreateInvoice"
        Me.btnCreateInvoice.Tag = "67"
        '
        'btnFilterPending
        '
        Me.btnFilterPending.Caption = "Pending"
        Me.btnFilterPending.Id = 59
        Me.btnFilterPending.ImageOptions.LargeImageIndex = 42
        Me.btnFilterPending.Name = "btnFilterPending"
        Me.btnFilterPending.Tag = "74"
        '
        'btnFilterReceivable
        '
        Me.btnFilterReceivable.Caption = "Receivable"
        Me.btnFilterReceivable.Id = 60
        Me.btnFilterReceivable.ImageOptions.LargeImageIndex = 42
        Me.btnFilterReceivable.Name = "btnFilterReceivable"
        Me.btnFilterReceivable.Tag = "75"
        '
        'btnFilterPaid
        '
        Me.btnFilterPaid.Caption = "Paid"
        Me.btnFilterPaid.Id = 61
        Me.btnFilterPaid.ImageOptions.LargeImageIndex = 42
        Me.btnFilterPaid.Name = "btnFilterPaid"
        Me.btnFilterPaid.Tag = "76"
        '
        'btnFilterVoid
        '
        Me.btnFilterVoid.Caption = "Void"
        Me.btnFilterVoid.Id = 62
        Me.btnFilterVoid.ImageOptions.LargeImageIndex = 42
        Me.btnFilterVoid.Name = "btnFilterVoid"
        Me.btnFilterVoid.Tag = "77"
        '
        'btnFilterAll
        '
        Me.btnFilterAll.Caption = "All"
        Me.btnFilterAll.Id = 63
        Me.btnFilterAll.ImageOptions.Image = CType(resources.GetObject("btnFilterAll.ImageOptions.Image"), System.Drawing.Image)
        Me.btnFilterAll.ImageOptions.LargeImageIndex = 42
        Me.btnFilterAll.Name = "btnFilterAll"
        Me.btnFilterAll.Tag = "78"
        '
        'btnPrintInvoice
        '
        Me.btnPrintInvoice.Caption = "Print Invoice"
        Me.btnPrintInvoice.Id = 64
        Me.btnPrintInvoice.ImageOptions.LargeImageIndex = 14
        Me.btnPrintInvoice.Name = "btnPrintInvoice"
        Me.btnPrintInvoice.Tag = "79"
        '
        'btnPrintPriceList
        '
        Me.btnPrintPriceList.Caption = "Price List"
        Me.btnPrintPriceList.Id = 65
        Me.btnPrintPriceList.ImageOptions.LargeImageIndex = 28
        Me.btnPrintPriceList.Name = "btnPrintPriceList"
        Me.btnPrintPriceList.Tag = "11"
        '
        'btnCloseShipment
        '
        Me.btnCloseShipment.Caption = "Close Shipment (No Invoice)"
        Me.btnCloseShipment.Id = 66
        Me.btnCloseShipment.ImageOptions.LargeImage = CType(resources.GetObject("btnCloseShipment.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCloseShipment.Name = "btnCloseShipment"
        Me.btnCloseShipment.Tag = "68"
        '
        'btnConvertWorkOrderToInvoice
        '
        Me.btnConvertWorkOrderToInvoice.Caption = "Direct Work Order Invoice"
        Me.btnConvertWorkOrderToInvoice.Id = 67
        Me.btnConvertWorkOrderToInvoice.ImageOptions.LargeImageIndex = 16
        Me.btnConvertWorkOrderToInvoice.Name = "btnConvertWorkOrderToInvoice"
        Me.btnConvertWorkOrderToInvoice.Tag = "72"
        '
        'btnTransferInvoicesToQuickbooks
        '
        Me.btnTransferInvoicesToQuickbooks.Caption = "Transfer to Quickbooks"
        Me.btnTransferInvoicesToQuickbooks.Id = 69
        Me.btnTransferInvoicesToQuickbooks.ImageOptions.LargeImage = CType(resources.GetObject("btnTransferInvoicesToQuickbooks.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnTransferInvoicesToQuickbooks.Name = "btnTransferInvoicesToQuickbooks"
        Me.btnTransferInvoicesToQuickbooks.Tag = "73"
        Me.btnTransferInvoicesToQuickbooks.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnPrintCustomerPaymentHistory
        '
        Me.btnPrintCustomerPaymentHistory.Caption = "Payment History"
        Me.btnPrintCustomerPaymentHistory.Id = 70
        Me.btnPrintCustomerPaymentHistory.ImageOptions.LargeImageIndex = 15
        Me.btnPrintCustomerPaymentHistory.Name = "btnPrintCustomerPaymentHistory"
        Me.btnPrintCustomerPaymentHistory.Tag = "80"
        '
        'btnAddCustomerPayment
        '
        Me.btnAddCustomerPayment.Caption = " New  Payment"
        Me.btnAddCustomerPayment.Id = 71
        Me.btnAddCustomerPayment.ImageOptions.LargeImageIndex = 31
        Me.btnAddCustomerPayment.Name = "btnAddCustomerPayment"
        Me.btnAddCustomerPayment.Tag = "81"
        '
        'btnEditCustomerPayment
        '
        Me.btnEditCustomerPayment.Caption = " Edit  Payment"
        Me.btnEditCustomerPayment.Id = 72
        Me.btnEditCustomerPayment.ImageOptions.Image = CType(resources.GetObject("btnEditCustomerPayment.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditCustomerPayment.ImageOptions.LargeImageIndex = 32
        Me.btnEditCustomerPayment.Name = "btnEditCustomerPayment"
        Me.btnEditCustomerPayment.Tag = "82"
        '
        'btnDeleteCustomerPayment
        '
        Me.btnDeleteCustomerPayment.Caption = "Delete Payment"
        Me.btnDeleteCustomerPayment.Id = 73
        Me.btnDeleteCustomerPayment.ImageOptions.Image = CType(resources.GetObject("btnDeleteCustomerPayment.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteCustomerPayment.ImageOptions.LargeImageIndex = 33
        Me.btnDeleteCustomerPayment.Name = "btnDeleteCustomerPayment"
        Me.btnDeleteCustomerPayment.Tag = "83"
        '
        'btnPrintCustomerPmtByDate
        '
        Me.btnPrintCustomerPmtByDate.Caption = "Payments Info By Date"
        Me.btnPrintCustomerPmtByDate.Id = 74
        Me.btnPrintCustomerPmtByDate.ImageOptions.LargeImageIndex = 29
        Me.btnPrintCustomerPmtByDate.Name = "btnPrintCustomerPmtByDate"
        Me.btnPrintCustomerPmtByDate.Tag = "84"
        '
        'btnManageCustomerAssignments
        '
        Me.btnManageCustomerAssignments.Caption = "Commission Rates"
        Me.btnManageCustomerAssignments.Id = 78
        Me.btnManageCustomerAssignments.ImageOptions.LargeImage = CType(resources.GetObject("btnManageCustomerAssignments.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnManageCustomerAssignments.Name = "btnManageCustomerAssignments"
        Me.btnManageCustomerAssignments.Tag = "102"
        '
        'btnManageSalespersonData
        '
        Me.btnManageSalespersonData.Caption = "Staff Management"
        Me.btnManageSalespersonData.Id = 79
        Me.btnManageSalespersonData.ImageOptions.Image = CType(resources.GetObject("btnManageSalespersonData.ImageOptions.Image"), System.Drawing.Image)
        Me.btnManageSalespersonData.Name = "btnManageSalespersonData"
        Me.btnManageSalespersonData.Tag = "108"
        '
        'luActiveSalesPerson
        '
        Me.luActiveSalesPerson.Edit = Me.RepositoryItemLookUpEdit9
        Me.luActiveSalesPerson.EditWidth = 150
        Me.luActiveSalesPerson.Id = 81
        Me.luActiveSalesPerson.Name = "luActiveSalesPerson"
        '
        'RepositoryItemLookUpEdit9
        '
        Me.RepositoryItemLookUpEdit9.AutoHeight = False
        Me.RepositoryItemLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit9.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Salespersonfullname", "Name", 108, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit9.DataSource = Me.bsSalesperson
        Me.RepositoryItemLookUpEdit9.DisplayMember = "Salespersonfullname"
        Me.RepositoryItemLookUpEdit9.Name = "RepositoryItemLookUpEdit9"
        Me.RepositoryItemLookUpEdit9.NullText = ""
        Me.RepositoryItemLookUpEdit9.ValueMember = "Salespersonid"
        '
        'bsSalesperson
        '
        Me.bsSalesperson.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Select a Salesperson:"
        Me.BarStaticItem1.Id = 82
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = " "
        Me.BarStaticItem2.Id = 83
        Me.BarStaticItem2.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.BarStaticItem2.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'btnAddCommissionRec
        '
        Me.btnAddCommissionRec.Caption = "Add Commission"
        Me.btnAddCommissionRec.Id = 84
        Me.btnAddCommissionRec.ImageOptions.Image = CType(resources.GetObject("btnAddCommissionRec.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddCommissionRec.Name = "btnAddCommissionRec"
        Me.btnAddCommissionRec.Tag = "93"
        '
        'btnEditCommissionRec
        '
        Me.btnEditCommissionRec.Caption = "Edit Commission"
        Me.btnEditCommissionRec.Id = 85
        Me.btnEditCommissionRec.ImageOptions.Image = CType(resources.GetObject("btnEditCommissionRec.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditCommissionRec.Name = "btnEditCommissionRec"
        Me.btnEditCommissionRec.Tag = "94"
        '
        'btnDeleteCommissionRec
        '
        Me.btnDeleteCommissionRec.Caption = "Delete Commission"
        Me.btnDeleteCommissionRec.Id = 86
        Me.btnDeleteCommissionRec.ImageOptions.Image = CType(resources.GetObject("btnDeleteCommissionRec.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteCommissionRec.Name = "btnDeleteCommissionRec"
        Me.btnDeleteCommissionRec.Tag = "95"
        '
        'btnFetchForecastedCommissions
        '
        Me.btnFetchForecastedCommissions.Caption = "Pending"
        Me.btnFetchForecastedCommissions.Id = 87
        Me.btnFetchForecastedCommissions.ImageOptions.LargeImage = CType(resources.GetObject("btnFetchForecastedCommissions.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFetchForecastedCommissions.Name = "btnFetchForecastedCommissions"
        Me.btnFetchForecastedCommissions.Tag = "91"
        '
        'btnFetchPayableCommissions
        '
        Me.btnFetchPayableCommissions.Caption = "Payable"
        Me.btnFetchPayableCommissions.Id = 88
        Me.btnFetchPayableCommissions.ImageOptions.LargeImage = CType(resources.GetObject("btnFetchPayableCommissions.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnFetchPayableCommissions.Name = "btnFetchPayableCommissions"
        Me.btnFetchPayableCommissions.Tag = "92"
        '
        'btnPrintForecastedCommissions
        '
        Me.btnPrintForecastedCommissions.Caption = "Pending Commissions"
        Me.btnPrintForecastedCommissions.Id = 89
        Me.btnPrintForecastedCommissions.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintForecastedCommissions.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintForecastedCommissions.Name = "btnPrintForecastedCommissions"
        Me.btnPrintForecastedCommissions.Tag = "99"
        '
        'btnPrintPayableCommissions
        '
        Me.btnPrintPayableCommissions.Caption = "Payable Commissions"
        Me.btnPrintPayableCommissions.Id = 90
        Me.btnPrintPayableCommissions.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintPayableCommissions.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintPayableCommissions.Name = "btnPrintPayableCommissions"
        Me.btnPrintPayableCommissions.Tag = "100"
        '
        'btnManageCommissionPayments
        '
        Me.btnManageCommissionPayments.Caption = "Commission Payments"
        Me.btnManageCommissionPayments.Id = 91
        Me.btnManageCommissionPayments.ImageOptions.LargeImage = CType(resources.GetObject("btnManageCommissionPayments.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnManageCommissionPayments.Name = "btnManageCommissionPayments"
        Me.btnManageCommissionPayments.Tag = "103"
        '
        'btnMarkCommissionForecasted
        '
        Me.btnMarkCommissionForecasted.Caption = "Mark Pending"
        Me.btnMarkCommissionForecasted.Id = 92
        Me.btnMarkCommissionForecasted.ImageOptions.Image = CType(resources.GetObject("btnMarkCommissionForecasted.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMarkCommissionForecasted.Name = "btnMarkCommissionForecasted"
        Me.btnMarkCommissionForecasted.Tag = "96"
        '
        'btnMarkCommissionPayable
        '
        Me.btnMarkCommissionPayable.Caption = "Mark Payable"
        Me.btnMarkCommissionPayable.Id = 93
        Me.btnMarkCommissionPayable.ImageOptions.Image = CType(resources.GetObject("btnMarkCommissionPayable.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMarkCommissionPayable.Name = "btnMarkCommissionPayable"
        Me.btnMarkCommissionPayable.Tag = "97"
        '
        'btnMarkCommissionPaid
        '
        Me.btnMarkCommissionPaid.Caption = "Mark Paid"
        Me.btnMarkCommissionPaid.Id = 94
        Me.btnMarkCommissionPaid.ImageOptions.Image = CType(resources.GetObject("btnMarkCommissionPaid.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMarkCommissionPaid.Name = "btnMarkCommissionPaid"
        Me.btnMarkCommissionPaid.Tag = "98"
        '
        'btnPrintCommissionsByCustomer
        '
        Me.btnPrintCommissionsByCustomer.Caption = "Commissions by Customer"
        Me.btnPrintCommissionsByCustomer.Id = 95
        Me.btnPrintCommissionsByCustomer.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintCommissionsByCustomer.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintCommissionsByCustomer.Name = "btnPrintCommissionsByCustomer"
        Me.btnPrintCommissionsByCustomer.Tag = "101"
        '
        'eHistoryStart
        '
        Me.eHistoryStart.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.eHistoryStart.Caption = "Date Start"
        Me.eHistoryStart.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eHistoryStart.Edit = Me.RepositoryItemDateEdit1
        Me.eHistoryStart.EditWidth = 100
        Me.eHistoryStart.Id = 96
        Me.eHistoryStart.Name = "eHistoryStart"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'eHistoryEnd
        '
        Me.eHistoryEnd.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.eHistoryEnd.Caption = "Date End"
        Me.eHistoryEnd.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eHistoryEnd.Edit = Me.RepositoryItemDateEdit2
        Me.eHistoryEnd.EditWidth = 100
        Me.eHistoryEnd.Id = 97
        Me.eHistoryEnd.Name = "eHistoryEnd"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'eCustomerSelector
        '
        Me.eCustomerSelector.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.eCustomerSelector.Edit = Me.RepositoryItemLookUpEdit14
        Me.eCustomerSelector.EditWidth = 200
        Me.eCustomerSelector.Id = 98
        Me.eCustomerSelector.Name = "eCustomerSelector"
        '
        'RepositoryItemLookUpEdit14
        '
        Me.RepositoryItemLookUpEdit14.AutoHeight = False
        Me.RepositoryItemLookUpEdit14.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit14.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit14.DataSource = Me.bsCustomerSelector
        Me.RepositoryItemLookUpEdit14.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit14.DropDownRows = 10
        Me.RepositoryItemLookUpEdit14.Name = "RepositoryItemLookUpEdit14"
        Me.RepositoryItemLookUpEdit14.NullText = "[Select a customer...]"
        Me.RepositoryItemLookUpEdit14.PopupWidth = 350
        Me.RepositoryItemLookUpEdit14.ShowFooter = False
        Me.RepositoryItemLookUpEdit14.ValueMember = "Custid"
        '
        'bsCustomerSelector
        '
        Me.bsCustomerSelector.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'eFetchSalesHistoryData
        '
        Me.eFetchSalesHistoryData.Caption = "Get Selected Customer Sales"
        Me.eFetchSalesHistoryData.Id = 99
        Me.eFetchSalesHistoryData.ImageOptions.LargeImage = CType(resources.GetObject("eFetchSalesHistoryData.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.eFetchSalesHistoryData.Name = "eFetchSalesHistoryData"
        Me.eFetchSalesHistoryData.Tag = "104"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 100
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'btnExportSalesHistoryData
        '
        Me.btnExportSalesHistoryData.Caption = "Export to Excel"
        Me.btnExportSalesHistoryData.Id = 101
        Me.btnExportSalesHistoryData.ImageOptions.LargeImage = CType(resources.GetObject("btnExportSalesHistoryData.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnExportSalesHistoryData.Name = "btnExportSalesHistoryData"
        Me.btnExportSalesHistoryData.Tag = "107"
        '
        'rbtnUpdateCustomers
        '
        Me.rbtnUpdateCustomers.Caption = "Update Customers"
        Me.rbtnUpdateCustomers.Id = 102
        Me.rbtnUpdateCustomers.ImageOptions.LargeImageIndex = 3
        Me.rbtnUpdateCustomers.Name = "rbtnUpdateCustomers"
        Me.rbtnUpdateCustomers.Tag = "1"
        '
        'eProductLookup
        '
        Me.eProductLookup.Edit = Me.RepositoryItemLookUpEdit15
        Me.eProductLookup.EditWidth = 200
        Me.eProductLookup.Id = 103
        Me.eProductLookup.Name = "eProductLookup"
        '
        'RepositoryItemLookUpEdit15
        '
        Me.RepositoryItemLookUpEdit15.AutoHeight = False
        Me.RepositoryItemLookUpEdit15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit15.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", "Desc2", 125, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit15.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit15.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit15.DropDownRows = 10
        Me.RepositoryItemLookUpEdit15.Name = "RepositoryItemLookUpEdit15"
        Me.RepositoryItemLookUpEdit15.NullText = "[Select a product...]"
        Me.RepositoryItemLookUpEdit15.PopupWidth = 400
        Me.RepositoryItemLookUpEdit15.ShowFooter = False
        Me.RepositoryItemLookUpEdit15.ValueMember = "Productid"
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'eProductStart
        '
        Me.eProductStart.Caption = "Date Start"
        Me.eProductStart.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eProductStart.Edit = Me.RepositoryItemDateEdit3
        Me.eProductStart.EditWidth = 100
        Me.eProductStart.Id = 104
        Me.eProductStart.Name = "eProductStart"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'eProductEnd
        '
        Me.eProductEnd.Caption = "Date End"
        Me.eProductEnd.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eProductEnd.Edit = Me.RepositoryItemDateEdit4
        Me.eProductEnd.EditWidth = 100
        Me.eProductEnd.Id = 105
        Me.eProductEnd.Name = "eProductEnd"
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'rbtnGetProductSales
        '
        Me.rbtnGetProductSales.Caption = "Get Product Sales"
        Me.rbtnGetProductSales.Id = 106
        Me.rbtnGetProductSales.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Search1
        Me.rbtnGetProductSales.Name = "rbtnGetProductSales"
        Me.rbtnGetProductSales.Tag = "106"
        '
        'rbtnPrintCustomerProductList
        '
        Me.rbtnPrintCustomerProductList.Caption = "Product List"
        Me.rbtnPrintCustomerProductList.Id = 107
        Me.rbtnPrintCustomerProductList.ImageOptions.LargeImageIndex = 28
        Me.rbtnPrintCustomerProductList.Name = "rbtnPrintCustomerProductList"
        Me.rbtnPrintCustomerProductList.Tag = "12"
        '
        'printInvoiceHistoryReport
        '
        Me.printInvoiceHistoryReport.Caption = "Print Invoice History"
        Me.printInvoiceHistoryReport.Id = 108
        Me.printInvoiceHistoryReport.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Report1
        Me.printInvoiceHistoryReport.Name = "printInvoiceHistoryReport"
        Me.printInvoiceHistoryReport.Tag = "105"
        '
        'rluSalesperson
        '
        Me.rluSalesperson.Caption = "  Sales Person"
        Me.rluSalesperson.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.rluSalesperson.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rluSalesperson.Edit = Me.RepositoryItemLookUpEdit16
        Me.rluSalesperson.EditWidth = 100
        Me.rluSalesperson.Id = 110
        Me.rluSalesperson.Name = "rluSalesperson"
        '
        'RepositoryItemLookUpEdit16
        '
        Me.RepositoryItemLookUpEdit16.AutoHeight = False
        Me.RepositoryItemLookUpEdit16.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit16.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Salespersonfullname", 150, "Name")})
        Me.RepositoryItemLookUpEdit16.DataSource = Me.bsSalesPersonList3
        Me.RepositoryItemLookUpEdit16.DisplayMember = "Salespersonfullname"
        Me.RepositoryItemLookUpEdit16.DropDownRows = 10
        Me.RepositoryItemLookUpEdit16.Name = "RepositoryItemLookUpEdit16"
        Me.RepositoryItemLookUpEdit16.NullText = ""
        Me.RepositoryItemLookUpEdit16.PopupSizeable = False
        Me.RepositoryItemLookUpEdit16.PopupWidth = 100
        Me.RepositoryItemLookUpEdit16.ShowFooter = False
        Me.RepositoryItemLookUpEdit16.ShowHeader = False
        Me.RepositoryItemLookUpEdit16.ValueMember = "Salespersonid"
        '
        'bsSalesPersonList3
        '
        Me.bsSalesPersonList3.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'rbtnGetSalesAnalysisData
        '
        Me.rbtnGetSalesAnalysisData.Caption = "Compile Sales Data"
        Me.rbtnGetSalesAnalysisData.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnGetSalesAnalysisData.Id = 111
        Me.rbtnGetSalesAnalysisData.ImageOptions.LargeImageIndex = 42
        Me.rbtnGetSalesAnalysisData.Name = "rbtnGetSalesAnalysisData"
        Me.rbtnGetSalesAnalysisData.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rbtnExportSalesDataToExcel
        '
        Me.rbtnExportSalesDataToExcel.Caption = "Export to Excel"
        Me.rbtnExportSalesDataToExcel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnExportSalesDataToExcel.Id = 112
        Me.rbtnExportSalesDataToExcel.ImageOptions.LargeImageIndex = 43
        Me.rbtnExportSalesDataToExcel.Name = "rbtnExportSalesDataToExcel"
        Me.rbtnExportSalesDataToExcel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rluSalesYear
        '
        Me.rluSalesYear.Caption = "  Sales Year"
        Me.rluSalesYear.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.rluSalesYear.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rluSalesYear.Edit = Me.RepositoryItemLookUpEdit17
        Me.rluSalesYear.EditWidth = 100
        Me.rluSalesYear.Id = 113
        Me.rluSalesYear.Name = "rluSalesYear"
        '
        'RepositoryItemLookUpEdit17
        '
        Me.RepositoryItemLookUpEdit17.AutoHeight = False
        Me.RepositoryItemLookUpEdit17.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit17.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Year", "Year", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit17.DataSource = Me.bsSalesYears
        Me.RepositoryItemLookUpEdit17.DisplayMember = "Year"
        Me.RepositoryItemLookUpEdit17.DropDownRows = 10
        Me.RepositoryItemLookUpEdit17.Name = "RepositoryItemLookUpEdit17"
        Me.RepositoryItemLookUpEdit17.NullText = ""
        Me.RepositoryItemLookUpEdit17.PopupSizeable = False
        Me.RepositoryItemLookUpEdit17.PopupWidth = 100
        Me.RepositoryItemLookUpEdit17.ShowFooter = False
        Me.RepositoryItemLookUpEdit17.ShowHeader = False
        Me.RepositoryItemLookUpEdit17.ValueMember = "Year"
        '
        'bsSalesYears
        '
        Me.bsSalesYears.DataSource = GetType(AOS.BusinessObjects.ViewSalesYearsCollection)
        '
        'rluCustomer
        '
        Me.rluCustomer.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.rluCustomer.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rluCustomer.Edit = Me.RepositoryItemLookUpEdit18
        Me.rluCustomer.EditWidth = 200
        Me.rluCustomer.Id = 114
        Me.rluCustomer.Name = "rluCustomer"
        '
        'RepositoryItemLookUpEdit18
        '
        Me.RepositoryItemLookUpEdit18.AutoHeight = False
        Me.RepositoryItemLookUpEdit18.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit18.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit18.DataSource = Me.bsCustomerLookupList
        Me.RepositoryItemLookUpEdit18.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit18.DropDownRows = 20
        Me.RepositoryItemLookUpEdit18.Name = "RepositoryItemLookUpEdit18"
        Me.RepositoryItemLookUpEdit18.NullText = ""
        Me.RepositoryItemLookUpEdit18.PopupWidth = 400
        Me.RepositoryItemLookUpEdit18.ShowFooter = False
        Me.RepositoryItemLookUpEdit18.ValueMember = "Custid"
        '
        'bsCustomerLookupList
        '
        Me.bsCustomerLookupList.DataSource = GetType(AOS.BusinessObjects.ViewCustomerLookupCollection)
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem1.Id = 115
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'rbtnCompileTrendData
        '
        Me.rbtnCompileTrendData.Caption = "Compile Trend Data"
        Me.rbtnCompileTrendData.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnCompileTrendData.Id = 116
        Me.rbtnCompileTrendData.ImageOptions.LargeImageIndex = 45
        Me.rbtnCompileTrendData.Name = "rbtnCompileTrendData"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Select Customer Name:"
        Me.BarStaticItem3.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarStaticItem3.Id = 117
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'rbtnMonthlySalesAnalysis
        '
        Me.rbtnMonthlySalesAnalysis.Caption = "Sales Analysis Data"
        Me.rbtnMonthlySalesAnalysis.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnMonthlySalesAnalysis.Id = 118
        Me.rbtnMonthlySalesAnalysis.ImageOptions.LargeImageIndex = 27
        Me.rbtnMonthlySalesAnalysis.Name = "rbtnMonthlySalesAnalysis"
        Me.rbtnMonthlySalesAnalysis.Tag = "0"
        '
        'rbtnFilterPriceListActive
        '
        Me.rbtnFilterPriceListActive.Caption = "Active"
        Me.rbtnFilterPriceListActive.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnFilterPriceListActive.Id = 119
        Me.rbtnFilterPriceListActive.ImageOptions.LargeImageIndex = 27
        Me.rbtnFilterPriceListActive.Name = "rbtnFilterPriceListActive"
        '
        'rbtnFilterPriceListInActive
        '
        Me.rbtnFilterPriceListInActive.Caption = "Inactive"
        Me.rbtnFilterPriceListInActive.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnFilterPriceListInActive.Id = 120
        Me.rbtnFilterPriceListInActive.ImageOptions.LargeImageIndex = 27
        Me.rbtnFilterPriceListInActive.Name = "rbtnFilterPriceListInActive"
        '
        'rbtnViewPrintSDSDocument
        '
        Me.rbtnViewPrintSDSDocument.Caption = "View / Print SDS Document"
        Me.rbtnViewPrintSDSDocument.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnViewPrintSDSDocument.Id = 121
        Me.rbtnViewPrintSDSDocument.ImageOptions.LargeImageIndex = 15
        Me.rbtnViewPrintSDSDocument.Name = "rbtnViewPrintSDSDocument"
        '
        'rbtnFilterSalesACTIVE
        '
        Me.rbtnFilterSalesACTIVE.Caption = "Active"
        Me.rbtnFilterSalesACTIVE.Id = 122
        Me.rbtnFilterSalesACTIVE.ImageOptions.LargeImageIndex = 45
        Me.rbtnFilterSalesACTIVE.Name = "rbtnFilterSalesACTIVE"
        '
        'rbtnFilterSalesINACTIVE
        '
        Me.rbtnFilterSalesINACTIVE.Caption = "Inactive"
        Me.rbtnFilterSalesINACTIVE.Id = 123
        Me.rbtnFilterSalesINACTIVE.ImageOptions.LargeImageIndex = 45
        Me.rbtnFilterSalesINACTIVE.Name = "rbtnFilterSalesINACTIVE"
        '
        'rbtnGetSalesAnalysisByCustomerData
        '
        Me.rbtnGetSalesAnalysisByCustomerData.Caption = "Compile Customer Sales"
        Me.rbtnGetSalesAnalysisByCustomerData.Id = 124
        Me.rbtnGetSalesAnalysisByCustomerData.ImageOptions.LargeImageIndex = 2
        Me.rbtnGetSalesAnalysisByCustomerData.Name = "rbtnGetSalesAnalysisByCustomerData"
        '
        'rbtnExportSalesByCustomerAnalysisToExcel
        '
        Me.rbtnExportSalesByCustomerAnalysisToExcel.Caption = "Export Customer Sales"
        Me.rbtnExportSalesByCustomerAnalysisToExcel.Id = 126
        Me.rbtnExportSalesByCustomerAnalysisToExcel.ImageOptions.LargeImageIndex = 16
        Me.rbtnExportSalesByCustomerAnalysisToExcel.Name = "rbtnExportSalesByCustomerAnalysisToExcel"
        '
        'rbtnGetSalesPersonAnalysis
        '
        Me.rbtnGetSalesPersonAnalysis.Caption = "Compile Sales Analysis"
        Me.rbtnGetSalesPersonAnalysis.Id = 127
        Me.rbtnGetSalesPersonAnalysis.ImageOptions.LargeImageIndex = 3
        Me.rbtnGetSalesPersonAnalysis.Name = "rbtnGetSalesPersonAnalysis"
        '
        'rbtnExportSalesPersonAnalysisToExcel
        '
        Me.rbtnExportSalesPersonAnalysisToExcel.Caption = "Export Sales Analysis"
        Me.rbtnExportSalesPersonAnalysisToExcel.Id = 128
        Me.rbtnExportSalesPersonAnalysisToExcel.ImageOptions.LargeImageIndex = 22
        Me.rbtnExportSalesPersonAnalysisToExcel.Name = "rbtnExportSalesPersonAnalysisToExcel"
        '
        'rbtnGetAllCustomersSales
        '
        Me.rbtnGetAllCustomersSales.Caption = "Get All Customers Sales"
        Me.rbtnGetAllCustomersSales.Id = 130
        Me.rbtnGetAllCustomersSales.ImageOptions.LargeImageIndex = 45
        Me.rbtnGetAllCustomersSales.Name = "rbtnGetAllCustomersSales"
        '
        'rbtnWorkOrdersToInvoice
        '
        Me.rbtnWorkOrdersToInvoice.Caption = "WorkOrders To Invoice"
        Me.rbtnWorkOrdersToInvoice.Id = 131
        Me.rbtnWorkOrdersToInvoice.ImageOptions.LargeImageIndex = 17
        Me.rbtnWorkOrdersToInvoice.Name = "rbtnWorkOrdersToInvoice"
        '
        'RibbonLargeImages
        '
        Me.RibbonLargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.RibbonLargeImages.ImageStream = CType(resources.GetObject("RibbonLargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "11"
        Me.RibbonPage1.Text = "Customers"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnUpdateCustomers)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddCustomer, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditCustomer, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDeleteCustomer)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Customer Info"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup29, Me.RibbonPageGroup17})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Tag = "12"
        Me.RibbonPage3.Text = "Price Lists"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnAddPriceListItem)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnEditPriceListItem)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnDeletePriceListItem)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Price Lists"
        '
        'RibbonPageGroup29
        '
        Me.RibbonPageGroup29.AllowMinimize = False
        Me.RibbonPageGroup29.AllowTextClipping = False
        Me.RibbonPageGroup29.ItemLinks.Add(Me.rbtnFilterPriceListActive)
        Me.RibbonPageGroup29.ItemLinks.Add(Me.rbtnFilterPriceListInActive)
        Me.RibbonPageGroup29.Name = "RibbonPageGroup29"
        Me.RibbonPageGroup29.ShowCaptionButton = False
        Me.RibbonPageGroup29.Text = "Filter"
        '
        'RibbonPageGroup17
        '
        Me.RibbonPageGroup17.AllowTextClipping = False
        Me.RibbonPageGroup17.ItemLinks.Add(Me.btnPrintPriceList)
        Me.RibbonPageGroup17.ItemLinks.Add(Me.rbtnPrintCustomerProductList)
        Me.RibbonPageGroup17.ItemLinks.Add(Me.rbtnViewPrintSDSDocument, True)
        Me.RibbonPageGroup17.Name = "RibbonPageGroup17"
        Me.RibbonPageGroup17.ShowCaptionButton = False
        Me.RibbonPageGroup17.Tag = "999"
        Me.RibbonPageGroup17.Text = "Reports"
        '
        'RibbonPage6
        '
        Me.RibbonPage6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup7, Me.RibbonPageGroup9})
        Me.RibbonPage6.Name = "RibbonPage6"
        Me.RibbonPage6.Tag = "108"
        Me.RibbonPage6.Text = "Completed Shipments"
        Me.RibbonPage6.Visible = False
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.ItemLinks.Add(Me.btnRefreshCompleteShipments)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Data"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.AllowTextClipping = False
        Me.RibbonPageGroup9.ItemLinks.Add(Me.btnCreateInvoice)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.btnCloseShipment)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.ShowCaptionButton = False
        Me.RibbonPageGroup9.Text = "Processing"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4, Me.RibbonPageGroup18, Me.RibbonPageGroup5, Me.RibbonPageGroup14})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Tag = "13"
        Me.RibbonPage4.Text = "Invoices"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnAddInvoice)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnEditInvoice, True)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnDeleteInvoice, True)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnConvertWorkOrderToInvoice, True)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnWorkOrdersToInvoice)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Invoice Management"
        '
        'RibbonPageGroup18
        '
        Me.RibbonPageGroup18.AllowTextClipping = False
        Me.RibbonPageGroup18.ItemLinks.Add(Me.btnTransferInvoicesToQuickbooks)
        Me.RibbonPageGroup18.Name = "RibbonPageGroup18"
        Me.RibbonPageGroup18.ShowCaptionButton = False
        Me.RibbonPageGroup18.Text = "Process Invoices"
        Me.RibbonPageGroup18.Visible = False
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnFilterPending)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnFilterReceivable)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnFilterPaid)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnFilterVoid)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnFilterAll)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Filter Invoice List"
        '
        'RibbonPageGroup14
        '
        Me.RibbonPageGroup14.AllowTextClipping = False
        Me.RibbonPageGroup14.ItemLinks.Add(Me.btnPrintInvoice)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.btnPrintCustomerPaymentHistory)
        Me.RibbonPageGroup14.Name = "RibbonPageGroup14"
        Me.RibbonPageGroup14.ShowCaptionButton = False
        Me.RibbonPageGroup14.Text = "Reports"
        '
        'RibbonPage7
        '
        Me.RibbonPage7.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup10, Me.RibbonPageGroup19})
        Me.RibbonPage7.Name = "RibbonPage7"
        Me.RibbonPage7.Tag = "14"
        Me.RibbonPage7.Text = "Payments"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.AllowTextClipping = False
        Me.RibbonPageGroup10.ItemLinks.Add(Me.btnAddCustomerPayment)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.btnEditCustomerPayment, True)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.btnDeleteCustomerPayment)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.ShowCaptionButton = False
        Me.RibbonPageGroup10.Text = "Customer Payments"
        '
        'RibbonPageGroup19
        '
        Me.RibbonPageGroup19.AllowTextClipping = False
        Me.RibbonPageGroup19.ItemLinks.Add(Me.btnPrintCustomerPmtByDate)
        Me.RibbonPageGroup19.Name = "RibbonPageGroup19"
        Me.RibbonPageGroup19.ShowCaptionButton = False
        Me.RibbonPageGroup19.Text = "Reports"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup30, Me.RibbonPageGroup8, Me.RibbonPageGroup2})
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Tag = "15"
        Me.RibbonPage5.Text = "Sales & Commissions"
        '
        'RibbonPageGroup30
        '
        Me.RibbonPageGroup30.AllowMinimize = False
        Me.RibbonPageGroup30.AllowTextClipping = False
        Me.RibbonPageGroup30.ItemLinks.Add(Me.rbtnFilterSalesACTIVE)
        Me.RibbonPageGroup30.ItemLinks.Add(Me.rbtnFilterSalesINACTIVE)
        Me.RibbonPageGroup30.Name = "RibbonPageGroup30"
        Me.RibbonPageGroup30.ShowCaptionButton = False
        Me.RibbonPageGroup30.Text = "Filter"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.AllowTextClipping = False
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnAddSalesperson)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnEditSalesperson)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnDeleteSalesperson)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Salesperson Info"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddAssignment)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditAssignment)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeleteAssignment)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Customer Assignments"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup24, Me.RibbonPageGroup21, Me.RibbonPageGroup22, Me.RibbonPageGroup23, Me.RibbonPageGroup20})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Tag = "16000"
        Me.RibbonPage2.Text = "Commissions"
        Me.RibbonPage2.Visible = False
        '
        'RibbonPageGroup24
        '
        Me.RibbonPageGroup24.AllowMinimize = False
        Me.RibbonPageGroup24.AllowTextClipping = False
        Me.RibbonPageGroup24.ItemLinks.Add(Me.BarStaticItem1)
        Me.RibbonPageGroup24.ItemLinks.Add(Me.luActiveSalesPerson)
        Me.RibbonPageGroup24.ItemLinks.Add(Me.btnManageSalespersonData)
        Me.RibbonPageGroup24.Name = "RibbonPageGroup24"
        Me.RibbonPageGroup24.ShowCaptionButton = False
        Me.RibbonPageGroup24.Text = "Active Selection"
        '
        'RibbonPageGroup21
        '
        Me.RibbonPageGroup21.AllowMinimize = False
        Me.RibbonPageGroup21.AllowTextClipping = False
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnFetchForecastedCommissions)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnFetchPayableCommissions)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnAddCommissionRec, True)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnEditCommissionRec)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnDeleteCommissionRec)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnMarkCommissionForecasted, True)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnMarkCommissionPayable)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnMarkCommissionPaid)
        Me.RibbonPageGroup21.Name = "RibbonPageGroup21"
        Me.RibbonPageGroup21.ShowCaptionButton = False
        Me.RibbonPageGroup21.Text = "Commissions Data"
        '
        'RibbonPageGroup22
        '
        Me.RibbonPageGroup22.AllowMinimize = False
        Me.RibbonPageGroup22.AllowTextClipping = False
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnPrintForecastedCommissions)
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnPrintPayableCommissions)
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnPrintCommissionsByCustomer)
        Me.RibbonPageGroup22.Name = "RibbonPageGroup22"
        Me.RibbonPageGroup22.ShowCaptionButton = False
        Me.RibbonPageGroup22.Text = "Commission Reports"
        '
        'RibbonPageGroup23
        '
        Me.RibbonPageGroup23.AllowMinimize = False
        Me.RibbonPageGroup23.AllowTextClipping = False
        Me.RibbonPageGroup23.ItemLinks.Add(Me.btnManageCustomerAssignments)
        Me.RibbonPageGroup23.Name = "RibbonPageGroup23"
        Me.RibbonPageGroup23.ShowCaptionButton = False
        Me.RibbonPageGroup23.Text = "Assignments"
        '
        'RibbonPageGroup20
        '
        Me.RibbonPageGroup20.AllowMinimize = False
        Me.RibbonPageGroup20.AllowTextClipping = False
        Me.RibbonPageGroup20.ItemLinks.Add(Me.btnManageCommissionPayments)
        Me.RibbonPageGroup20.Name = "RibbonPageGroup20"
        Me.RibbonPageGroup20.ShowCaptionButton = False
        Me.RibbonPageGroup20.Text = "Payments"
        '
        'RibbonPage10
        '
        Me.RibbonPage10.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup25, Me.RibbonPageGroup27, Me.RibbonPageGroup26, Me.RibbonPageGroup28})
        Me.RibbonPage10.Name = "RibbonPage10"
        Me.RibbonPage10.Tag = "17"
        Me.RibbonPage10.Text = "Sales History"
        '
        'RibbonPageGroup25
        '
        Me.RibbonPageGroup25.AllowTextClipping = False
        Me.RibbonPageGroup25.ItemLinks.Add(Me.eCustomerSelector)
        Me.RibbonPageGroup25.ItemLinks.Add(Me.eHistoryStart)
        Me.RibbonPageGroup25.ItemLinks.Add(Me.eHistoryEnd)
        Me.RibbonPageGroup25.ItemLinks.Add(Me.eFetchSalesHistoryData, True)
        Me.RibbonPageGroup25.ItemLinks.Add(Me.rbtnGetAllCustomersSales)
        Me.RibbonPageGroup25.ItemLinks.Add(Me.printInvoiceHistoryReport, True)
        Me.RibbonPageGroup25.Name = "RibbonPageGroup25"
        Me.RibbonPageGroup25.ShowCaptionButton = False
        Me.RibbonPageGroup25.Text = "Customer Sales History"
        '
        'RibbonPageGroup27
        '
        Me.RibbonPageGroup27.AllowTextClipping = False
        Me.RibbonPageGroup27.ItemLinks.Add(Me.eProductLookup)
        Me.RibbonPageGroup27.ItemLinks.Add(Me.eProductStart)
        Me.RibbonPageGroup27.ItemLinks.Add(Me.eProductEnd)
        Me.RibbonPageGroup27.ItemLinks.Add(Me.rbtnGetProductSales, True)
        Me.RibbonPageGroup27.Name = "RibbonPageGroup27"
        Me.RibbonPageGroup27.ShowCaptionButton = False
        Me.RibbonPageGroup27.Text = "Product Sales History"
        '
        'RibbonPageGroup26
        '
        Me.RibbonPageGroup26.AllowTextClipping = False
        Me.RibbonPageGroup26.ItemLinks.Add(Me.btnExportSalesHistoryData)
        Me.RibbonPageGroup26.Name = "RibbonPageGroup26"
        Me.RibbonPageGroup26.ShowCaptionButton = False
        Me.RibbonPageGroup26.Text = "Data Management"
        '
        'RibbonPageGroup28
        '
        Me.RibbonPageGroup28.AllowMinimize = False
        Me.RibbonPageGroup28.AllowTextClipping = False
        Me.RibbonPageGroup28.ItemLinks.Add(Me.rbtnMonthlySalesAnalysis)
        Me.RibbonPageGroup28.Name = "RibbonPageGroup28"
        Me.RibbonPageGroup28.ShowCaptionButton = False
        Me.RibbonPageGroup28.Text = "Monthly Sales Analysis"
        '
        'RibbonPage9
        '
        Me.RibbonPage9.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup15, Me.RibbonPageGroup16})
        Me.RibbonPage9.Name = "RibbonPage9"
        Me.RibbonPage9.Tag = "128"
        Me.RibbonPage9.Text = "Sales Analysis"
        '
        'RibbonPageGroup15
        '
        Me.RibbonPageGroup15.AllowMinimize = False
        Me.RibbonPageGroup15.AllowTextClipping = False
        Me.RibbonPageGroup15.ItemLinks.Add(Me.rluSalesperson)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.rluSalesYear)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.rbtnGetSalesAnalysisData, True)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.rbtnExportSalesDataToExcel)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.rbtnGetSalesAnalysisByCustomerData, True)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.rbtnExportSalesByCustomerAnalysisToExcel)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.rbtnGetSalesPersonAnalysis, True)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.rbtnExportSalesPersonAnalysisToExcel)
        Me.RibbonPageGroup15.Name = "RibbonPageGroup15"
        Me.RibbonPageGroup15.ShowCaptionButton = False
        Me.RibbonPageGroup15.Text = "Customer Sales Analysis"
        '
        'RibbonPageGroup16
        '
        Me.RibbonPageGroup16.AllowMinimize = False
        Me.RibbonPageGroup16.AllowTextClipping = False
        Me.RibbonPageGroup16.ItemLinks.Add(Me.BarStaticItem3)
        Me.RibbonPageGroup16.ItemLinks.Add(Me.rluCustomer)
        Me.RibbonPageGroup16.ItemLinks.Add(Me.rbtnCompileTrendData, True)
        Me.RibbonPageGroup16.Name = "RibbonPageGroup16"
        Me.RibbonPageGroup16.ShowCaptionButton = False
        Me.RibbonPageGroup16.Text = "Customer Trends Analysis"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'WorkPanelsHolder
        '
        Me.WorkPanelsHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl10)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl9)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl7)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl6)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 149)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1482, 566)
        Me.WorkPanelsHolder.TabIndex = 7
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Controls.Add(Me.grpCommissions)
        Me.RibbonPanelControl5.Controls.Add(Me.RibbonControl2)
        Me.RibbonPanelControl5.Controls.Add(Me.SplitterControl1)
        Me.RibbonPanelControl5.Controls.Add(Me.pnlSalesTop)
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(1482, 566)
        Me.RibbonPanelControl5.TabIndex = 1
        '
        'grpCommissions
        '
        Me.grpCommissions.Controls.Add(Me.grCommissions)
        Me.grpCommissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCommissions.Location = New System.Drawing.Point(2, 370)
        Me.grpCommissions.Name = "grpCommissions"
        Me.grpCommissions.Size = New System.Drawing.Size(1478, 194)
        Me.grpCommissions.TabIndex = 8
        Me.grpCommissions.Text = "Commissions for ..."
        '
        'grCommissions
        '
        Me.grCommissions.DataSource = Me.bsCommissions
        Me.grCommissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCommissions.Location = New System.Drawing.Point(2, 20)
        Me.grCommissions.LookAndFeel.SkinName = "Money Twins"
        Me.grCommissions.MainView = Me.grvCommissions
        Me.grCommissions.Name = "grCommissions"
        Me.grCommissions.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CustomerLookup, Me.RepositoryItemLookUpEdit6})
        Me.grCommissions.Size = New System.Drawing.Size(1474, 172)
        Me.grCommissions.TabIndex = 0
        Me.grCommissions.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCommissions})
        '
        'bsCommissions
        '
        Me.bsCommissions.DataSource = GetType(AOS.BusinessObjects.ViewCommissionAuditAnalysisCollection)
        '
        'grvCommissions
        '
        Me.grvCommissions.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvCommissions.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvCommissions.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.grvCommissions.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvCommissions.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvCommissions.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvCommissions.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.grvCommissions.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvCommissions.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.grvCommissions.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.grvCommissions.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvCommissions.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvCommissions.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvCommissions.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grvCommissions.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvCommissions.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvCommissions.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grvCommissions.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvCommissions.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvCommissions.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvCommissions.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvCommissions.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grvCommissions.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvCommissions.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvCommissions.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grvCommissions.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvCommissions.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvCommissions.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvCommissions.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvCommissions.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvCommissions.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvCommissions.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvCommissions.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grvCommissions.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvCommissions.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCommissiondate, Me.colCustid3, Me.colInvoicenumber, Me.colCommissionamount, Me.colCommissionstatus, Me.colCommissiondesc, Me.colCommissiontype1, Me.colDatecustomerpaid, Me.colDatecommissionpaid, Me.colCommissionnote, Me.colCommissionid1, Me.colVariance, Me.colAuditflag})
        Me.grvCommissions.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvCommissions.GridControl = Me.grCommissions
        Me.grvCommissions.Name = "grvCommissions"
        Me.grvCommissions.OptionsBehavior.Editable = False
        Me.grvCommissions.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvCommissions.OptionsSelection.MultiSelect = True
        Me.grvCommissions.OptionsView.ShowAutoFilterRow = True
        Me.grvCommissions.OptionsView.ShowGroupPanel = False
        Me.grvCommissions.OptionsView.ShowIndicator = False
        '
        'colCommissiondate
        '
        Me.colCommissiondate.Caption = "Date"
        Me.colCommissiondate.DisplayFormat.FormatString = "d"
        Me.colCommissiondate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCommissiondate.FieldName = "Commissiondate"
        Me.colCommissiondate.Name = "colCommissiondate"
        Me.colCommissiondate.Visible = True
        Me.colCommissiondate.VisibleIndex = 0
        Me.colCommissiondate.Width = 58
        '
        'colCustid3
        '
        Me.colCustid3.Caption = "Customer"
        Me.colCustid3.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.colCustid3.FieldName = "Custid"
        Me.colCustid3.Name = "colCustid3"
        Me.colCustid3.Visible = True
        Me.colCustid3.VisibleIndex = 2
        Me.colCustid3.Width = 112
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.DataSource = Me.bsCustomers
        Me.RepositoryItemLookUpEdit6.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        Me.RepositoryItemLookUpEdit6.ReadOnly = True
        Me.RepositoryItemLookUpEdit6.ValueMember = "Custid"
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'colInvoicenumber
        '
        Me.colInvoicenumber.Caption = "Inv #"
        Me.colInvoicenumber.FieldName = "Invoicenumber"
        Me.colInvoicenumber.Name = "colInvoicenumber"
        Me.colInvoicenumber.Visible = True
        Me.colInvoicenumber.VisibleIndex = 1
        Me.colInvoicenumber.Width = 60
        '
        'colCommissionamount
        '
        Me.colCommissionamount.Caption = "Comm Amt"
        Me.colCommissionamount.DisplayFormat.FormatString = "c2"
        Me.colCommissionamount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCommissionamount.FieldName = "Commissionamount"
        Me.colCommissionamount.Name = "colCommissionamount"
        Me.colCommissionamount.Visible = True
        Me.colCommissionamount.VisibleIndex = 4
        Me.colCommissionamount.Width = 85
        '
        'colCommissionstatus
        '
        Me.colCommissionstatus.Caption = "Status"
        Me.colCommissionstatus.FieldName = "Commissionstatus"
        Me.colCommissionstatus.Name = "colCommissionstatus"
        Me.colCommissionstatus.Visible = True
        Me.colCommissionstatus.VisibleIndex = 5
        '
        'colCommissiondesc
        '
        Me.colCommissiondesc.Caption = "Description"
        Me.colCommissiondesc.FieldName = "Commissiondesc"
        Me.colCommissiondesc.Name = "colCommissiondesc"
        Me.colCommissiondesc.Visible = True
        Me.colCommissiondesc.VisibleIndex = 3
        Me.colCommissiondesc.Width = 163
        '
        'colCommissiontype1
        '
        Me.colCommissiontype1.Caption = "Category"
        Me.colCommissiontype1.FieldName = "Commissioncategory"
        Me.colCommissiontype1.Name = "colCommissiontype1"
        Me.colCommissiontype1.Visible = True
        Me.colCommissiontype1.VisibleIndex = 6
        Me.colCommissiontype1.Width = 70
        '
        'colDatecustomerpaid
        '
        Me.colDatecustomerpaid.Caption = "Inv Paid"
        Me.colDatecustomerpaid.DisplayFormat.FormatString = "d"
        Me.colDatecustomerpaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDatecustomerpaid.FieldName = "Datecustomerpaid"
        Me.colDatecustomerpaid.Name = "colDatecustomerpaid"
        Me.colDatecustomerpaid.Visible = True
        Me.colDatecustomerpaid.VisibleIndex = 7
        Me.colDatecustomerpaid.Width = 74
        '
        'colDatecommissionpaid
        '
        Me.colDatecommissionpaid.Caption = "Comm Paid"
        Me.colDatecommissionpaid.DisplayFormat.FormatString = "d"
        Me.colDatecommissionpaid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDatecommissionpaid.FieldName = "Datecommissionpaid"
        Me.colDatecommissionpaid.Name = "colDatecommissionpaid"
        Me.colDatecommissionpaid.Visible = True
        Me.colDatecommissionpaid.VisibleIndex = 8
        Me.colDatecommissionpaid.Width = 83
        '
        'colCommissionnote
        '
        Me.colCommissionnote.Caption = "Note"
        Me.colCommissionnote.FieldName = "Commissionnote"
        Me.colCommissionnote.Name = "colCommissionnote"
        Me.colCommissionnote.Visible = True
        Me.colCommissionnote.VisibleIndex = 9
        Me.colCommissionnote.Width = 119
        '
        'colCommissionid1
        '
        Me.colCommissionid1.FieldName = "Commissionid"
        Me.colCommissionid1.Name = "colCommissionid1"
        '
        'colVariance
        '
        Me.colVariance.FieldName = "Variance"
        Me.colVariance.Name = "colVariance"
        '
        'colAuditflag
        '
        Me.colAuditflag.FieldName = "Auditflag"
        Me.colAuditflag.Name = "colAuditflag"
        '
        'CustomerLookup
        '
        Me.CustomerLookup.AutoHeight = False
        Me.CustomerLookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerLookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustomerLookup.DataSource = Me.bsCustomerList
        Me.CustomerLookup.DisplayMember = "Custname"
        Me.CustomerLookup.Name = "CustomerLookup"
        Me.CustomerLookup.NullText = ""
        Me.CustomerLookup.ReadOnly = True
        Me.CustomerLookup.ValueMember = "Custid"
        '
        'bsCustomerList
        '
        Me.bsCustomerList.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ApplicationButtonText = Nothing
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.btnAddCommission, Me.btnEditCommission, Me.btnDeleteCommission, Me.btnAddCommissionPmt, Me.btnCommissionFilterPending, Me.btnCommissionFilterPayable, Me.btnCommissionFilterPaid, Me.btnPrintCommForecast, Me.btnPrintCommPayable, Me.btnPrintPaidCommissionsRpt, Me.btnCommissionTypes, Me.btnCommissionBalancesDue, Me.btnMarkPayable, Me.btnMarkPaid, Me.btnMarkPending, Me.btnPrintCommPmtRegister, Me.rbtnPrintCommByCustomer, Me.rbtnCommissonAuditReport, Me.eInvPaidThruDate, Me.rbtnFilterPayableCommByDate, Me.rbtnFilterPayableCommAll, Me.BarStaticItem4, Me.rbtnMiscMarkPayableAsPaid, Me.rbtnMarkCommissionAsAudited, Me.btnRptCommWithExceptions, Me.rbtnRptPayableWithExceptions, Me.rbtnPrintCommPmtRegisterWithExceptions})
        Me.RibbonControl2.Location = New System.Drawing.Point(2, 254)
        Me.RibbonControl2.MaxItemId = 30
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage20, Me.RibbonPage8})
        Me.RibbonControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit5})
        Me.RibbonControl2.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl2.ShowToolbarCustomizeItem = False
        Me.RibbonControl2.Size = New System.Drawing.Size(1478, 116)
        Me.RibbonControl2.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnAddCommission
        '
        Me.btnAddCommission.Caption = "Add Commission"
        Me.btnAddCommission.Id = 0
        Me.btnAddCommission.ImageOptions.Image = CType(resources.GetObject("btnAddCommission.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddCommission.Name = "btnAddCommission"
        '
        'btnEditCommission
        '
        Me.btnEditCommission.Caption = "Edit Commission"
        Me.btnEditCommission.Id = 1
        Me.btnEditCommission.ImageOptions.Image = CType(resources.GetObject("btnEditCommission.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditCommission.Name = "btnEditCommission"
        '
        'btnDeleteCommission
        '
        Me.btnDeleteCommission.Caption = "Delete Commission"
        Me.btnDeleteCommission.Id = 2
        Me.btnDeleteCommission.ImageOptions.Image = CType(resources.GetObject("btnDeleteCommission.ImageOptions.Image"), System.Drawing.Image)
        Me.btnDeleteCommission.Name = "btnDeleteCommission"
        '
        'btnAddCommissionPmt
        '
        Me.btnAddCommissionPmt.Caption = "Create Commission Payment"
        Me.btnAddCommissionPmt.Id = 3
        Me.btnAddCommissionPmt.ImageOptions.LargeImage = CType(resources.GetObject("btnAddCommissionPmt.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddCommissionPmt.Name = "btnAddCommissionPmt"
        '
        'btnCommissionFilterPending
        '
        Me.btnCommissionFilterPending.Caption = "Pending"
        Me.btnCommissionFilterPending.Id = 6
        Me.btnCommissionFilterPending.ImageOptions.LargeImage = CType(resources.GetObject("btnCommissionFilterPending.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCommissionFilterPending.Name = "btnCommissionFilterPending"
        '
        'btnCommissionFilterPayable
        '
        Me.btnCommissionFilterPayable.Caption = "Payable"
        Me.btnCommissionFilterPayable.Id = 7
        Me.btnCommissionFilterPayable.ImageOptions.LargeImage = CType(resources.GetObject("btnCommissionFilterPayable.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCommissionFilterPayable.Name = "btnCommissionFilterPayable"
        '
        'btnCommissionFilterPaid
        '
        Me.btnCommissionFilterPaid.Caption = "Paid"
        Me.btnCommissionFilterPaid.Id = 8
        Me.btnCommissionFilterPaid.ImageOptions.LargeImage = CType(resources.GetObject("btnCommissionFilterPaid.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnCommissionFilterPaid.Name = "btnCommissionFilterPaid"
        '
        'btnPrintCommForecast
        '
        Me.btnPrintCommForecast.Caption = "Pending"
        Me.btnPrintCommForecast.Id = 9
        Me.btnPrintCommForecast.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintCommForecast.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintCommForecast.Name = "btnPrintCommForecast"
        Me.btnPrintCommForecast.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnPrintCommPayable
        '
        Me.btnPrintCommPayable.Caption = "Payable"
        Me.btnPrintCommPayable.Id = 10
        Me.btnPrintCommPayable.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintCommPayable.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintCommPayable.Name = "btnPrintCommPayable"
        '
        'btnPrintPaidCommissionsRpt
        '
        Me.btnPrintPaidCommissionsRpt.Caption = "Paid"
        Me.btnPrintPaidCommissionsRpt.Id = 11
        Me.btnPrintPaidCommissionsRpt.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintPaidCommissionsRpt.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintPaidCommissionsRpt.Name = "btnPrintPaidCommissionsRpt"
        '
        'btnCommissionTypes
        '
        Me.btnCommissionTypes.Caption = "Commission Types"
        Me.btnCommissionTypes.Id = 13
        Me.btnCommissionTypes.Name = "btnCommissionTypes"
        '
        'btnCommissionBalancesDue
        '
        Me.btnCommissionBalancesDue.Caption = "Commission Balances Due"
        Me.btnCommissionBalancesDue.Id = 14
        Me.btnCommissionBalancesDue.Name = "btnCommissionBalancesDue"
        '
        'btnMarkPayable
        '
        Me.btnMarkPayable.Caption = "Mark Payable"
        Me.btnMarkPayable.Id = 15
        Me.btnMarkPayable.ImageOptions.Image = CType(resources.GetObject("btnMarkPayable.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMarkPayable.Name = "btnMarkPayable"
        '
        'btnMarkPaid
        '
        Me.btnMarkPaid.Caption = "Mark Paid"
        Me.btnMarkPaid.Id = 16
        Me.btnMarkPaid.ImageOptions.Image = CType(resources.GetObject("btnMarkPaid.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMarkPaid.Name = "btnMarkPaid"
        '
        'btnMarkPending
        '
        Me.btnMarkPending.Caption = "Mark Pending"
        Me.btnMarkPending.Id = 17
        Me.btnMarkPending.ImageOptions.Image = CType(resources.GetObject("btnMarkPending.ImageOptions.Image"), System.Drawing.Image)
        Me.btnMarkPending.Name = "btnMarkPending"
        '
        'btnPrintCommPmtRegister
        '
        Me.btnPrintCommPmtRegister.Caption = "Payment Register"
        Me.btnPrintCommPmtRegister.Id = 18
        Me.btnPrintCommPmtRegister.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintCommPmtRegister.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintCommPmtRegister.Name = "btnPrintCommPmtRegister"
        '
        'rbtnPrintCommByCustomer
        '
        Me.rbtnPrintCommByCustomer.Caption = "Commission By Customer"
        Me.rbtnPrintCommByCustomer.Id = 19
        Me.rbtnPrintCommByCustomer.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Report1
        Me.rbtnPrintCommByCustomer.Name = "rbtnPrintCommByCustomer"
        '
        'rbtnCommissonAuditReport
        '
        Me.rbtnCommissonAuditReport.Caption = "Commission Audit Report"
        Me.rbtnCommissonAuditReport.Id = 20
        Me.rbtnCommissonAuditReport.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Report1
        Me.rbtnCommissonAuditReport.Name = "rbtnCommissonAuditReport"
        '
        'eInvPaidThruDate
        '
        Me.eInvPaidThruDate.Edit = Me.RepositoryItemDateEdit5
        Me.eInvPaidThruDate.EditWidth = 100
        Me.eInvPaidThruDate.Id = 21
        Me.eInvPaidThruDate.Name = "eInvPaidThruDate"
        '
        'RepositoryItemDateEdit5
        '
        Me.RepositoryItemDateEdit5.AutoHeight = False
        Me.RepositoryItemDateEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit5.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit5.Name = "RepositoryItemDateEdit5"
        '
        'rbtnFilterPayableCommByDate
        '
        Me.rbtnFilterPayableCommByDate.Caption = "Payable By Date"
        Me.rbtnFilterPayableCommByDate.Id = 22
        Me.rbtnFilterPayableCommByDate.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Filter
        Me.rbtnFilterPayableCommByDate.Name = "rbtnFilterPayableCommByDate"
        '
        'rbtnFilterPayableCommAll
        '
        Me.rbtnFilterPayableCommAll.Caption = "All Payable"
        Me.rbtnFilterPayableCommAll.Id = 23
        Me.rbtnFilterPayableCommAll.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Filter
        Me.rbtnFilterPayableCommAll.Name = "rbtnFilterPayableCommAll"
        '
        'BarStaticItem4
        '
        Me.BarStaticItem4.Caption = "Invoices Paid Thru"
        Me.BarStaticItem4.Id = 24
        Me.BarStaticItem4.Name = "BarStaticItem4"
        '
        'rbtnMiscMarkPayableAsPaid
        '
        Me.rbtnMiscMarkPayableAsPaid.Caption = "Mark Commisison PAID"
        Me.rbtnMiscMarkPayableAsPaid.Id = 25
        Me.rbtnMiscMarkPayableAsPaid.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.EditData
        Me.rbtnMiscMarkPayableAsPaid.Name = "rbtnMiscMarkPayableAsPaid"
        '
        'rbtnMarkCommissionAsAudited
        '
        Me.rbtnMarkCommissionAsAudited.Caption = "Mark Commission as Audited"
        Me.rbtnMarkCommissionAsAudited.Id = 26
        Me.rbtnMarkCommissionAsAudited.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.document_text_edit
        Me.rbtnMarkCommissionAsAudited.Name = "rbtnMarkCommissionAsAudited"
        '
        'btnRptCommWithExceptions
        '
        Me.btnRptCommWithExceptions.Caption = "Pending With Exceptions"
        Me.btnRptCommWithExceptions.Id = 27
        Me.btnRptCommWithExceptions.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Report1
        Me.btnRptCommWithExceptions.Name = "btnRptCommWithExceptions"
        '
        'rbtnRptPayableWithExceptions
        '
        Me.rbtnRptPayableWithExceptions.Caption = "Payable With Exceptions"
        Me.rbtnRptPayableWithExceptions.Id = 28
        Me.rbtnRptPayableWithExceptions.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Report1
        Me.rbtnRptPayableWithExceptions.Name = "rbtnRptPayableWithExceptions"
        '
        'rbtnPrintCommPmtRegisterWithExceptions
        '
        Me.rbtnPrintCommPmtRegisterWithExceptions.Caption = "Payment Register with Exceptions"
        Me.rbtnPrintCommPmtRegisterWithExceptions.Id = 29
        Me.rbtnPrintCommPmtRegisterWithExceptions.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Report1
        Me.rbtnPrintCommPmtRegisterWithExceptions.Name = "rbtnPrintCommPmtRegisterWithExceptions"
        '
        'RibbonPage20
        '
        Me.RibbonPage20.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.rpgFilter, Me.RibbonPageGroup13, Me.RibbonPageGroup33})
        Me.RibbonPage20.Name = "RibbonPage20"
        Me.RibbonPage20.Text = "Commission Data"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnAddCommission)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnEditCommission)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnDeleteCommission)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnMarkPending, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnMarkPayable)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnMarkPaid)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Commission Entries"
        '
        'rpgFilter
        '
        Me.rpgFilter.AllowTextClipping = False
        Me.rpgFilter.ItemLinks.Add(Me.btnCommissionFilterPending)
        Me.rpgFilter.ItemLinks.Add(Me.btnCommissionFilterPayable)
        Me.rpgFilter.ItemLinks.Add(Me.btnCommissionFilterPaid)
        Me.rpgFilter.Name = "rpgFilter"
        Me.rpgFilter.ShowCaptionButton = False
        Me.rpgFilter.Text = "Filter: Forecasted"
        '
        'RibbonPageGroup13
        '
        Me.RibbonPageGroup13.AllowTextClipping = False
        Me.RibbonPageGroup13.ItemLinks.Add(Me.btnPrintCommForecast)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.btnPrintCommPayable)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.btnPrintPaidCommissionsRpt)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.rbtnPrintCommByCustomer, True)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.btnRptCommWithExceptions, True)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.rbtnRptPayableWithExceptions)
        Me.RibbonPageGroup13.Name = "RibbonPageGroup13"
        Me.RibbonPageGroup13.ShowCaptionButton = False
        Me.RibbonPageGroup13.Text = "Reports"
        '
        'RibbonPageGroup33
        '
        Me.RibbonPageGroup33.AllowMinimize = False
        Me.RibbonPageGroup33.AllowTextClipping = False
        Me.RibbonPageGroup33.ItemLinks.Add(Me.rbtnMarkCommissionAsAudited)
        Me.RibbonPageGroup33.ItemLinks.Add(Me.rbtnCommissonAuditReport, True)
        Me.RibbonPageGroup33.Name = "RibbonPageGroup33"
        Me.RibbonPageGroup33.ShowCaptionButton = False
        Me.RibbonPageGroup33.Text = "Commission Audits"
        '
        'RibbonPage8
        '
        Me.RibbonPage8.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup31, Me.RibbonPageGroup11, Me.RibbonPageGroup12, Me.RibbonPageGroup32})
        Me.RibbonPage8.Name = "RibbonPage8"
        Me.RibbonPage8.Text = "Commission Payments"
        '
        'RibbonPageGroup31
        '
        Me.RibbonPageGroup31.AllowMinimize = False
        Me.RibbonPageGroup31.AllowTextClipping = False
        Me.RibbonPageGroup31.ItemLinks.Add(Me.BarStaticItem4)
        Me.RibbonPageGroup31.ItemLinks.Add(Me.eInvPaidThruDate)
        Me.RibbonPageGroup31.ItemLinks.Add(Me.rbtnFilterPayableCommByDate)
        Me.RibbonPageGroup31.ItemLinks.Add(Me.rbtnFilterPayableCommAll)
        Me.RibbonPageGroup31.Name = "RibbonPageGroup31"
        Me.RibbonPageGroup31.ShowCaptionButton = False
        Me.RibbonPageGroup31.Text = "Filter Commissions"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.AllowTextClipping = False
        Me.RibbonPageGroup11.ItemLinks.Add(Me.btnAddCommissionPmt, True)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.rbtnMiscMarkPayableAsPaid, True)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        Me.RibbonPageGroup11.ShowCaptionButton = False
        Me.RibbonPageGroup11.Text = "Commission Payments"
        '
        'RibbonPageGroup12
        '
        Me.RibbonPageGroup12.AllowTextClipping = False
        Me.RibbonPageGroup12.ItemLinks.Add(Me.btnPrintCommPmtRegister)
        Me.RibbonPageGroup12.ItemLinks.Add(Me.rbtnPrintCommPmtRegisterWithExceptions)
        Me.RibbonPageGroup12.Name = "RibbonPageGroup12"
        Me.RibbonPageGroup12.ShowCaptionButton = False
        Me.RibbonPageGroup12.Text = "Reports"
        '
        'RibbonPageGroup32
        '
        Me.RibbonPageGroup32.ItemLinks.Add(Me.rbtnMarkCommissionAsAudited)
        Me.RibbonPageGroup32.ItemLinks.Add(Me.rbtnCommissonAuditReport, True)
        Me.RibbonPageGroup32.Name = "RibbonPageGroup32"
        Me.RibbonPageGroup32.Text = "Audit Commissions"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(2, 249)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(1478, 5)
        Me.SplitterControl1.TabIndex = 10
        Me.SplitterControl1.TabStop = False
        '
        'pnlSalesTop
        '
        Me.pnlSalesTop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlSalesTop.Controls.Add(Me.grpCustomerAssignments)
        Me.pnlSalesTop.Controls.Add(Me.PanelControl3)
        Me.pnlSalesTop.Controls.Add(Me.GroupControl2)
        Me.pnlSalesTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSalesTop.Location = New System.Drawing.Point(2, 2)
        Me.pnlSalesTop.Name = "pnlSalesTop"
        Me.pnlSalesTop.Size = New System.Drawing.Size(1478, 247)
        Me.pnlSalesTop.TabIndex = 9
        '
        'grpCustomerAssignments
        '
        Me.grpCustomerAssignments.Controls.Add(Me.grAssignments)
        Me.grpCustomerAssignments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCustomerAssignments.Location = New System.Drawing.Point(266, 0)
        Me.grpCustomerAssignments.Name = "grpCustomerAssignments"
        Me.grpCustomerAssignments.Size = New System.Drawing.Size(1212, 247)
        Me.grpCustomerAssignments.TabIndex = 3
        Me.grpCustomerAssignments.Text = "Customer Assignments for ..."
        '
        'grAssignments
        '
        Me.grAssignments.DataSource = Me.bsAssignments
        Me.grAssignments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAssignments.Location = New System.Drawing.Point(2, 20)
        Me.grAssignments.LookAndFeel.SkinName = "Money Twins"
        Me.grAssignments.MainView = Me.GridView6
        Me.grAssignments.Name = "grAssignments"
        Me.grAssignments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.grAssignments.Size = New System.Drawing.Size(1208, 225)
        Me.grAssignments.TabIndex = 0
        Me.grAssignments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'bsAssignments
        '
        Me.bsAssignments.DataSource = GetType(AOS.BusinessObjects.CustomerassignmentCollection)
        '
        'GridView6
        '
        Me.GridView6.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView6.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView6.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView6.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView6.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView6.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView6.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView6.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView6.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView6.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView6.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView6.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView6.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView6.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView6.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView6.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView6.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView6.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustID1, Me.colCustID2, Me.colCommissionType, Me.colCommissionRate})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView6.GridControl = Me.grAssignments
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'colCustID1
        '
        Me.colCustID1.Caption = "ID"
        Me.colCustID1.FieldName = "CustID"
        Me.colCustID1.Name = "colCustID1"
        Me.colCustID1.Visible = True
        Me.colCustID1.VisibleIndex = 0
        Me.colCustID1.Width = 41
        '
        'colCustID2
        '
        Me.colCustID2.Caption = "Customer Name"
        Me.colCustID2.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colCustID2.FieldName = "CustID"
        Me.colCustID2.Name = "colCustID2"
        Me.colCustID2.Visible = True
        Me.colCustID2.VisibleIndex = 1
        Me.colCustID2.Width = 309
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsCustomerList
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ReadOnly = True
        Me.RepositoryItemLookUpEdit1.ValueMember = "Custid"
        '
        'colCommissionType
        '
        Me.colCommissionType.Caption = "Comm Type"
        Me.colCommissionType.FieldName = "CommissionType"
        Me.colCommissionType.Name = "colCommissionType"
        Me.colCommissionType.Visible = True
        Me.colCommissionType.VisibleIndex = 2
        Me.colCommissionType.Width = 166
        '
        'colCommissionRate
        '
        Me.colCommissionRate.Caption = "Comm Rate"
        Me.colCommissionRate.DisplayFormat.FormatString = "P"
        Me.colCommissionRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCommissionRate.FieldName = "CommissionRate"
        Me.colCommissionRate.Name = "colCommissionRate"
        Me.colCommissionRate.Visible = True
        Me.colCommissionRate.VisibleIndex = 3
        Me.colCommissionRate.Width = 170
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl3.Location = New System.Drawing.Point(262, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(4, 247)
        Me.PanelControl3.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grSalesperson)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(262, 247)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Salesperson List"
        '
        'grSalesperson
        '
        Me.grSalesperson.DataSource = Me.bsSalesperson
        Me.grSalesperson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grSalesperson.Location = New System.Drawing.Point(2, 20)
        Me.grSalesperson.LookAndFeel.SkinName = "Money Twins"
        Me.grSalesperson.MainView = Me.GridView4
        Me.grSalesperson.Name = "grSalesperson"
        Me.grSalesperson.Size = New System.Drawing.Size(258, 225)
        Me.grSalesperson.TabIndex = 0
        Me.grSalesperson.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
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
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSalespersonfirstname, Me.colSalespersonlastname, Me.colStatus})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView4.GridControl = Me.grSalesperson
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colSalespersonfirstname
        '
        Me.colSalespersonfirstname.Caption = "First Name"
        Me.colSalespersonfirstname.FieldName = "Salespersonfirstname"
        Me.colSalespersonfirstname.Name = "colSalespersonfirstname"
        Me.colSalespersonfirstname.Visible = True
        Me.colSalespersonfirstname.VisibleIndex = 0
        '
        'colSalespersonlastname
        '
        Me.colSalespersonlastname.Caption = "Last Name"
        Me.colSalespersonlastname.FieldName = "Salespersonlastname"
        Me.colSalespersonlastname.Name = "colSalespersonlastname"
        Me.colSalespersonlastname.Visible = True
        Me.colSalespersonlastname.VisibleIndex = 1
        '
        'colStatus
        '
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 2
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Controls.Add(Me.grpCommissionData)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1482, 566)
        Me.RibbonPanelControl2.TabIndex = 2
        '
        'grpCommissionData
        '
        Me.grpCommissionData.Controls.Add(Me.grCommissionData)
        Me.grpCommissionData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCommissionData.Location = New System.Drawing.Point(2, 2)
        Me.grpCommissionData.Name = "grpCommissionData"
        Me.grpCommissionData.Size = New System.Drawing.Size(1478, 562)
        Me.grpCommissionData.TabIndex = 9
        Me.grpCommissionData.Text = "Commissions for ..."
        '
        'grCommissionData
        '
        Me.grCommissionData.DataSource = Me.bsCommissions
        Me.grCommissionData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCommissionData.Location = New System.Drawing.Point(2, 20)
        Me.grCommissionData.LookAndFeel.SkinName = "Money Twins"
        Me.grCommissionData.MainView = Me.grvCommissionData
        Me.grCommissionData.Name = "grCommissionData"
        Me.grCommissionData.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit11, Me.RepositoryItemLookUpEdit10})
        Me.grCommissionData.Size = New System.Drawing.Size(1474, 540)
        Me.grCommissionData.TabIndex = 0
        Me.grCommissionData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCommissionData})
        '
        'grvCommissionData
        '
        Me.grvCommissionData.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvCommissionData.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvCommissionData.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.grvCommissionData.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvCommissionData.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvCommissionData.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvCommissionData.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.grvCommissionData.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvCommissionData.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.grvCommissionData.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.grvCommissionData.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvCommissionData.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvCommissionData.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvCommissionData.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grvCommissionData.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvCommissionData.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvCommissionData.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grvCommissionData.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvCommissionData.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvCommissionData.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvCommissionData.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvCommissionData.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grvCommissionData.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvCommissionData.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvCommissionData.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grvCommissionData.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvCommissionData.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvCommissionData.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvCommissionData.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvCommissionData.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvCommissionData.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvCommissionData.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvCommissionData.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grvCommissionData.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvCommissionData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.colCommissionID})
        Me.grvCommissionData.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvCommissionData.GridControl = Me.grCommissionData
        Me.grvCommissionData.Name = "grvCommissionData"
        Me.grvCommissionData.OptionsBehavior.Editable = False
        Me.grvCommissionData.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvCommissionData.OptionsSelection.MultiSelect = True
        Me.grvCommissionData.OptionsView.ShowGroupPanel = False
        Me.grvCommissionData.OptionsView.ShowIndicator = False
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Date"
        Me.GridColumn2.DisplayFormat.FormatString = "d"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Commissiondate"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 58
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Customer"
        Me.GridColumn3.ColumnEdit = Me.RepositoryItemLookUpEdit10
        Me.GridColumn3.FieldName = "Custid"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 112
        '
        'RepositoryItemLookUpEdit10
        '
        Me.RepositoryItemLookUpEdit10.AutoHeight = False
        Me.RepositoryItemLookUpEdit10.DataSource = Me.bsCustomers
        Me.RepositoryItemLookUpEdit10.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit10.Name = "RepositoryItemLookUpEdit10"
        Me.RepositoryItemLookUpEdit10.NullText = ""
        Me.RepositoryItemLookUpEdit10.ReadOnly = True
        Me.RepositoryItemLookUpEdit10.ValueMember = "Custid"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Inv #"
        Me.GridColumn4.FieldName = "Invoicenumber"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 60
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Comm Amt"
        Me.GridColumn5.DisplayFormat.FormatString = "c2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Commissionamount"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 85
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Status"
        Me.GridColumn6.FieldName = "Commissionstatus"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Description"
        Me.GridColumn7.FieldName = "Commissiondesc"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 163
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Category"
        Me.GridColumn8.FieldName = "Commissioncategory"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 70
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Inv Paid"
        Me.GridColumn9.DisplayFormat.FormatString = "d"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "Datecustomerpaid"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 74
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Comm Paid"
        Me.GridColumn10.DisplayFormat.FormatString = "d"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn10.FieldName = "Datecommissionpaid"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 83
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Note"
        Me.GridColumn11.FieldName = "Commissionnote"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 9
        Me.GridColumn11.Width = 119
        '
        'colCommissionID
        '
        Me.colCommissionID.Caption = "CommissionID"
        Me.colCommissionID.FieldName = "Commissionid"
        Me.colCommissionID.Name = "colCommissionID"
        '
        'RepositoryItemLookUpEdit11
        '
        Me.RepositoryItemLookUpEdit11.AutoHeight = False
        Me.RepositoryItemLookUpEdit11.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit11.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit11.DataSource = Me.bsCustomerList
        Me.RepositoryItemLookUpEdit11.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit11.Name = "RepositoryItemLookUpEdit11"
        Me.RepositoryItemLookUpEdit11.NullText = ""
        Me.RepositoryItemLookUpEdit11.ReadOnly = True
        Me.RepositoryItemLookUpEdit11.ValueMember = "Custid"
        '
        'RibbonPanelControl10
        '
        Me.RibbonPanelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RibbonPanelControl10.Controls.Add(Me.GroupControl9)
        Me.RibbonPanelControl10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl10.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl10.Name = "RibbonPanelControl10"
        Me.RibbonPanelControl10.Size = New System.Drawing.Size(1482, 566)
        Me.RibbonPanelControl10.TabIndex = 3
        '
        'GroupControl9
        '
        Me.GroupControl9.Controls.Add(Me.grSalesHistory)
        Me.GroupControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl9.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(1482, 566)
        Me.GroupControl9.TabIndex = 9
        Me.GroupControl9.Text = "Sales History Details"
        '
        'grSalesHistory
        '
        Me.grSalesHistory.DataSource = Me.bsSalesHistory
        Me.grSalesHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grSalesHistory.Location = New System.Drawing.Point(2, 20)
        Me.grSalesHistory.LookAndFeel.SkinName = "Money Twins"
        Me.grSalesHistory.MainView = Me.gridViewSalesHistory
        Me.grSalesHistory.Name = "grSalesHistory"
        Me.grSalesHistory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit13, Me.RepositoryItemLookUpEdit12})
        Me.grSalesHistory.Size = New System.Drawing.Size(1478, 544)
        Me.grSalesHistory.TabIndex = 0
        Me.grSalesHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridViewSalesHistory})
        '
        'bsSalesHistory
        '
        Me.bsSalesHistory.DataSource = GetType(AOS.BusinessObjects.ViewCustomerInvoicedItemsCollection)
        '
        'gridViewSalesHistory
        '
        Me.gridViewSalesHistory.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridViewSalesHistory.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gridViewSalesHistory.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.gridViewSalesHistory.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gridViewSalesHistory.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gridViewSalesHistory.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gridViewSalesHistory.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.gridViewSalesHistory.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gridViewSalesHistory.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.gridViewSalesHistory.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gridViewSalesHistory.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridViewSalesHistory.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gridViewSalesHistory.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.gridViewSalesHistory.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.gridViewSalesHistory.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gridViewSalesHistory.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gridViewSalesHistory.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.gridViewSalesHistory.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gridViewSalesHistory.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridViewSalesHistory.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gridViewSalesHistory.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.gridViewSalesHistory.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.gridViewSalesHistory.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gridViewSalesHistory.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gridViewSalesHistory.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.gridViewSalesHistory.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gridViewSalesHistory.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridViewSalesHistory.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gridViewSalesHistory.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.gridViewSalesHistory.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.gridViewSalesHistory.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gridViewSalesHistory.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gridViewSalesHistory.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.gridViewSalesHistory.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gridViewSalesHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustid6, Me.colCustname1, Me.colInvoicenumber3, Me.colInvoicedate1, Me.colProductid2, Me.colProductdesc, Me.colQuantity, Me.colContainer1, Me.colUom1, Me.colUnits1, Me.colItemprice, Me.colExtprice})
        Me.gridViewSalesHistory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.gridViewSalesHistory.GridControl = Me.grSalesHistory
        Me.gridViewSalesHistory.Name = "gridViewSalesHistory"
        Me.gridViewSalesHistory.OptionsBehavior.Editable = False
        Me.gridViewSalesHistory.OptionsFilter.AllowMRUFilterList = False
        Me.gridViewSalesHistory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gridViewSalesHistory.OptionsView.ShowAutoFilterRow = True
        Me.gridViewSalesHistory.OptionsView.ShowGroupPanel = False
        Me.gridViewSalesHistory.OptionsView.ShowIndicator = False
        '
        'colCustid6
        '
        Me.colCustid6.Caption = "Cust ID"
        Me.colCustid6.FieldName = "Custid"
        Me.colCustid6.Name = "colCustid6"
        Me.colCustid6.Visible = True
        Me.colCustid6.VisibleIndex = 0
        Me.colCustid6.Width = 53
        '
        'colCustname1
        '
        Me.colCustname1.Caption = "Customer Name"
        Me.colCustname1.FieldName = "Custname"
        Me.colCustname1.Name = "colCustname1"
        Me.colCustname1.Visible = True
        Me.colCustname1.VisibleIndex = 1
        Me.colCustname1.Width = 135
        '
        'colInvoicenumber3
        '
        Me.colInvoicenumber3.Caption = "Inv #"
        Me.colInvoicenumber3.FieldName = "Invoicenumber"
        Me.colInvoicenumber3.Name = "colInvoicenumber3"
        Me.colInvoicenumber3.Visible = True
        Me.colInvoicenumber3.VisibleIndex = 2
        Me.colInvoicenumber3.Width = 63
        '
        'colInvoicedate1
        '
        Me.colInvoicedate1.Caption = "Inv Date"
        Me.colInvoicedate1.FieldName = "Invoicedate"
        Me.colInvoicedate1.Name = "colInvoicedate1"
        Me.colInvoicedate1.Visible = True
        Me.colInvoicedate1.VisibleIndex = 3
        Me.colInvoicedate1.Width = 63
        '
        'colProductid2
        '
        Me.colProductid2.Caption = "Prod ID"
        Me.colProductid2.FieldName = "Productid"
        Me.colProductid2.Name = "colProductid2"
        Me.colProductid2.Visible = True
        Me.colProductid2.VisibleIndex = 4
        Me.colProductid2.Width = 59
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 5
        Me.colProductdesc.Width = 100
        '
        'colQuantity
        '
        Me.colQuantity.Caption = "Qty"
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 6
        Me.colQuantity.Width = 36
        '
        'colContainer1
        '
        Me.colContainer1.Caption = "Container"
        Me.colContainer1.FieldName = "Container"
        Me.colContainer1.Name = "colContainer1"
        Me.colContainer1.Visible = True
        Me.colContainer1.VisibleIndex = 7
        Me.colContainer1.Width = 55
        '
        'colUom1
        '
        Me.colUom1.Caption = "UOM"
        Me.colUom1.FieldName = "Uom"
        Me.colUom1.Name = "colUom1"
        Me.colUom1.Visible = True
        Me.colUom1.VisibleIndex = 9
        Me.colUom1.Width = 55
        '
        'colUnits1
        '
        Me.colUnits1.Caption = "Units"
        Me.colUnits1.FieldName = "Units"
        Me.colUnits1.Name = "colUnits1"
        Me.colUnits1.Visible = True
        Me.colUnits1.VisibleIndex = 8
        Me.colUnits1.Width = 55
        '
        'colItemprice
        '
        Me.colItemprice.Caption = "Price"
        Me.colItemprice.DisplayFormat.FormatString = "c2"
        Me.colItemprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colItemprice.FieldName = "Itemprice"
        Me.colItemprice.Name = "colItemprice"
        Me.colItemprice.Visible = True
        Me.colItemprice.VisibleIndex = 10
        Me.colItemprice.Width = 55
        '
        'colExtprice
        '
        Me.colExtprice.Caption = "Ext Price"
        Me.colExtprice.DisplayFormat.FormatString = "c2"
        Me.colExtprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colExtprice.FieldName = "Extprice"
        Me.colExtprice.Name = "colExtprice"
        Me.colExtprice.Visible = True
        Me.colExtprice.VisibleIndex = 11
        Me.colExtprice.Width = 55
        '
        'RepositoryItemLookUpEdit13
        '
        Me.RepositoryItemLookUpEdit13.AutoHeight = False
        Me.RepositoryItemLookUpEdit13.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit13.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit13.DataSource = Me.bsCustomerList
        Me.RepositoryItemLookUpEdit13.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit13.Name = "RepositoryItemLookUpEdit13"
        Me.RepositoryItemLookUpEdit13.NullText = ""
        Me.RepositoryItemLookUpEdit13.ReadOnly = True
        Me.RepositoryItemLookUpEdit13.ValueMember = "Custid"
        '
        'RepositoryItemLookUpEdit12
        '
        Me.RepositoryItemLookUpEdit12.AutoHeight = False
        Me.RepositoryItemLookUpEdit12.DataSource = Me.bsCustomers
        Me.RepositoryItemLookUpEdit12.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit12.Name = "RepositoryItemLookUpEdit12"
        Me.RepositoryItemLookUpEdit12.NullText = ""
        Me.RepositoryItemLookUpEdit12.ReadOnly = True
        Me.RepositoryItemLookUpEdit12.ValueMember = "Custid"
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RibbonPanelControl3.Appearance.Options.UseBackColor = True
        Me.RibbonPanelControl3.Controls.Add(Me.gcPriceLists)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1482, 566)
        Me.RibbonPanelControl3.TabIndex = 1
        '
        'gcPriceLists
        '
        Me.gcPriceLists.Controls.Add(Me.grPriceLists)
        Me.gcPriceLists.Controls.Add(Me.PanelControl1)
        Me.gcPriceLists.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcPriceLists.Location = New System.Drawing.Point(2, 2)
        Me.gcPriceLists.Name = "gcPriceLists"
        Me.gcPriceLists.Size = New System.Drawing.Size(1478, 562)
        Me.gcPriceLists.TabIndex = 1
        Me.gcPriceLists.Text = "Customer Price Lists"
        '
        'grPriceLists
        '
        Me.grPriceLists.DataSource = Me.bsPriceLists
        Me.grPriceLists.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPriceLists.Location = New System.Drawing.Point(2, 57)
        Me.grPriceLists.LookAndFeel.SkinName = "Money Twins"
        Me.grPriceLists.MainView = Me.viewPriceList
        Me.grPriceLists.Name = "grPriceLists"
        Me.grPriceLists.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductLookupEdit})
        Me.grPriceLists.Size = New System.Drawing.Size(1474, 503)
        Me.grPriceLists.TabIndex = 0
        Me.grPriceLists.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewPriceList})
        '
        'bsPriceLists
        '
        Me.bsPriceLists.DataSource = GetType(AOS.BusinessObjects.ViewPriceListDataCollection)
        '
        'viewPriceList
        '
        Me.viewPriceList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.viewPriceList.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.viewPriceList.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.viewPriceList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.viewPriceList.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.viewPriceList.Appearance.FocusedCell.Options.UseBackColor = True
        Me.viewPriceList.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.viewPriceList.Appearance.FocusedCell.Options.UseForeColor = True
        Me.viewPriceList.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.viewPriceList.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.viewPriceList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.viewPriceList.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.viewPriceList.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.viewPriceList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.viewPriceList.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.viewPriceList.Appearance.FocusedRow.Options.UseBackColor = True
        Me.viewPriceList.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.viewPriceList.Appearance.FocusedRow.Options.UseForeColor = True
        Me.viewPriceList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.viewPriceList.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.viewPriceList.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.viewPriceList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.viewPriceList.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.viewPriceList.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.viewPriceList.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.viewPriceList.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.viewPriceList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.viewPriceList.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.viewPriceList.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.viewPriceList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.viewPriceList.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.viewPriceList.Appearance.SelectedRow.Options.UseBackColor = True
        Me.viewPriceList.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.viewPriceList.Appearance.SelectedRow.Options.UseForeColor = True
        Me.viewPriceList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn12, Me.colProductid, Me.colProductid1, Me.colContainer, Me.colUom, Me.colUnits, Me.colPricemethod, Me.colUnitprice, Me.colContainerprice, Me.colEffectivedate, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.colPriceliststatus})
        Me.viewPriceList.CustomizationFormBounds = New System.Drawing.Rectangle(1168, 667, 216, 190)
        Me.viewPriceList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.viewPriceList.GridControl = Me.grPriceLists
        Me.viewPriceList.Name = "viewPriceList"
        Me.viewPriceList.OptionsBehavior.Editable = False
        Me.viewPriceList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.viewPriceList.OptionsView.ShowGroupPanel = False
        Me.viewPriceList.OptionsView.ShowIndicator = False
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Cust Prod Code"
        Me.GridColumn12.FieldName = "Customerproductcode"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 8
        Me.GridColumn12.Width = 95
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 0
        Me.colProductid.Width = 70
        '
        'colProductid1
        '
        Me.colProductid1.Caption = "Product Description"
        Me.colProductid1.FieldName = "Productdesc"
        Me.colProductid1.Name = "colProductid1"
        Me.colProductid1.Visible = True
        Me.colProductid1.VisibleIndex = 1
        Me.colProductid1.Width = 334
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 60
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.Width = 40
        '
        'colUnits
        '
        Me.colUnits.Caption = "Units"
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.Visible = True
        Me.colUnits.VisibleIndex = 4
        Me.colUnits.Width = 37
        '
        'colPricemethod
        '
        Me.colPricemethod.Caption = "Price Method"
        Me.colPricemethod.FieldName = "Unitorcontainer"
        Me.colPricemethod.Name = "colPricemethod"
        Me.colPricemethod.Visible = True
        Me.colPricemethod.VisibleIndex = 5
        Me.colPricemethod.Width = 79
        '
        'colUnitprice
        '
        Me.colUnitprice.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitprice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUnitprice.Caption = "Unit Price"
        Me.colUnitprice.DisplayFormat.FormatString = "c2"
        Me.colUnitprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitprice.FieldName = "Unitprice"
        Me.colUnitprice.Name = "colUnitprice"
        Me.colUnitprice.Width = 67
        '
        'colContainerprice
        '
        Me.colContainerprice.AppearanceCell.Options.UseTextOptions = True
        Me.colContainerprice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colContainerprice.Caption = "Container Price"
        Me.colContainerprice.DisplayFormat.FormatString = "c2"
        Me.colContainerprice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colContainerprice.FieldName = "Containerprice"
        Me.colContainerprice.Name = "colContainerprice"
        Me.colContainerprice.Visible = True
        Me.colContainerprice.VisibleIndex = 6
        Me.colContainerprice.Width = 90
        '
        'colEffectivedate
        '
        Me.colEffectivedate.Caption = "Effective Date"
        Me.colEffectivedate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colEffectivedate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colEffectivedate.FieldName = "Effectivedate"
        Me.colEffectivedate.Name = "colEffectivedate"
        Me.colEffectivedate.Visible = True
        Me.colEffectivedate.VisibleIndex = 7
        Me.colEffectivedate.Width = 84
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Volume Units"
        Me.GridColumn13.FieldName = "Volumeunits"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 9
        Me.GridColumn13.Width = 78
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Volume UOM"
        Me.GridColumn14.FieldName = "Volumeuom"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 10
        Me.GridColumn14.Width = 77
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Volume Price"
        Me.GridColumn15.FieldName = "Volumeprice"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 11
        Me.GridColumn15.Width = 82
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Weight Units"
        Me.GridColumn16.FieldName = "Weightunits"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 12
        Me.GridColumn16.Width = 77
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Weight UOM"
        Me.GridColumn17.FieldName = "Weightuom"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 13
        Me.GridColumn17.Width = 76
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Weight Price"
        Me.GridColumn18.FieldName = "Weightprice"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 14
        Me.GridColumn18.Width = 79
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Pricing Method"
        Me.GridColumn19.FieldName = "Pricingmethod"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 15
        Me.GridColumn19.Width = 92
        '
        'colPriceliststatus
        '
        Me.colPriceliststatus.Caption = "Status"
        Me.colPriceliststatus.FieldName = "Priceliststatus"
        Me.colPriceliststatus.Name = "colPriceliststatus"
        Me.colPriceliststatus.Visible = True
        Me.colPriceliststatus.VisibleIndex = 2
        Me.colPriceliststatus.Width = 64
        '
        'ProductLookupEdit
        '
        Me.ProductLookupEdit.AutoHeight = False
        Me.ProductLookupEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductLookupEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ProductLookupEdit.DataSource = Me.bsProducts
        Me.ProductLookupEdit.DisplayMember = "Productdesc"
        Me.ProductLookupEdit.Name = "ProductLookupEdit"
        Me.ProductLookupEdit.NullText = ""
        Me.ProductLookupEdit.ReadOnly = True
        Me.ProductLookupEdit.ShowFooter = False
        Me.ProductLookupEdit.ShowHeader = False
        Me.ProductLookupEdit.ValueMember = "Productid"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btnExportToXLS)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.luCustomerList)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1474, 37)
        Me.PanelControl1.TabIndex = 1
        '
        'btnExportToXLS
        '
        Me.btnExportToXLS.Location = New System.Drawing.Point(367, 7)
        Me.btnExportToXLS.Name = "btnExportToXLS"
        Me.btnExportToXLS.Size = New System.Drawing.Size(127, 23)
        Me.btnExportToXLS.TabIndex = 2
        Me.btnExportToXLS.Text = "Export Data to Excel"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(6, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Select a Customer:"
        '
        'luCustomerList
        '
        Me.luCustomerList.Location = New System.Drawing.Point(103, 6)
        Me.luCustomerList.Name = "luCustomerList"
        Me.luCustomerList.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luCustomerList.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luCustomerList.Properties.DataSource = Me.bsCustomerList
        Me.luCustomerList.Properties.DisplayMember = "Custname"
        Me.luCustomerList.Properties.DropDownRows = 15
        Me.luCustomerList.Properties.NullText = ""
        Me.luCustomerList.Properties.PopupWidth = 450
        Me.luCustomerList.Properties.ValueMember = "Custid"
        Me.luCustomerList.Size = New System.Drawing.Size(213, 20)
        Me.luCustomerList.TabIndex = 0
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Controls.Add(Me.PanelControl9)
        Me.RibbonPanelControl1.Controls.Add(Me.PanelControl8)
        Me.RibbonPanelControl1.Controls.Add(Me.GroupControl1)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1482, 566)
        Me.RibbonPanelControl1.TabIndex = 0
        '
        'PanelControl9
        '
        Me.PanelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl9.Controls.Add(Me.GroupControl15)
        Me.PanelControl9.Controls.Add(Me.GroupControl14)
        Me.PanelControl9.Controls.Add(Me.GroupControl13)
        Me.PanelControl9.Controls.Add(Me.GroupControl12)
        Me.PanelControl9.Controls.Add(Me.GroupControl11)
        Me.PanelControl9.Controls.Add(Me.GroupControl10)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl9.Location = New System.Drawing.Point(370, 2)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(1110, 562)
        Me.PanelControl9.TabIndex = 2
        '
        'GroupControl15
        '
        Me.GroupControl15.Controls.Add(Me.TextEdit1)
        Me.GroupControl15.Controls.Add(CustemailLabel)
        Me.GroupControl15.Controls.Add(Me.CustphoneTextEdit)
        Me.GroupControl15.Controls.Add(CustphoneLabel)
        Me.GroupControl15.Controls.Add(Me.CustfaxTextEdit)
        Me.GroupControl15.Controls.Add(CustfaxLabel)
        Me.GroupControl15.Location = New System.Drawing.Point(6, 428)
        Me.GroupControl15.Name = "GroupControl15"
        Me.GroupControl15.Size = New System.Drawing.Size(367, 128)
        Me.GroupControl15.TabIndex = 49
        Me.GroupControl15.Text = "Contact Information"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custemail", True))
        Me.TextEdit1.Location = New System.Drawing.Point(82, 50)
        Me.TextEdit1.MenuManager = Me.RibbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(280, 20)
        Me.TextEdit1.TabIndex = 36
        Me.TextEdit1.TabStop = False
        '
        'CustphoneTextEdit
        '
        Me.CustphoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custphone", True))
        Me.CustphoneTextEdit.Location = New System.Drawing.Point(82, 24)
        Me.CustphoneTextEdit.MenuManager = Me.RibbonControl1
        Me.CustphoneTextEdit.Name = "CustphoneTextEdit"
        Me.CustphoneTextEdit.Properties.ReadOnly = True
        Me.CustphoneTextEdit.Size = New System.Drawing.Size(134, 20)
        Me.CustphoneTextEdit.TabIndex = 33
        Me.CustphoneTextEdit.TabStop = False
        '
        'CustfaxTextEdit
        '
        Me.CustfaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custfax", True))
        Me.CustfaxTextEdit.Location = New System.Drawing.Point(254, 24)
        Me.CustfaxTextEdit.MenuManager = Me.RibbonControl1
        Me.CustfaxTextEdit.Name = "CustfaxTextEdit"
        Me.CustfaxTextEdit.Properties.ReadOnly = True
        Me.CustfaxTextEdit.Size = New System.Drawing.Size(108, 20)
        Me.CustfaxTextEdit.TabIndex = 35
        Me.CustfaxTextEdit.TabStop = False
        '
        'GroupControl14
        '
        Me.GroupControl14.Controls.Add(Label3)
        Me.GroupControl14.Controls.Add(Label2)
        Me.GroupControl14.Controls.Add(Label1)
        Me.GroupControl14.Controls.Add(Me.MemoEdit3)
        Me.GroupControl14.Controls.Add(Me.MemoEdit2)
        Me.GroupControl14.Controls.Add(Me.MemoEdit1)
        Me.GroupControl14.Controls.Add(Me.CustnotesMemoEdit)
        Me.GroupControl14.Controls.Add(CustnotesLabel)
        Me.GroupControl14.Location = New System.Drawing.Point(379, 264)
        Me.GroupControl14.Name = "GroupControl14"
        Me.GroupControl14.Size = New System.Drawing.Size(368, 294)
        Me.GroupControl14.TabIndex = 48
        Me.GroupControl14.Text = "Miscellaneous Information"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Accountingnotes", True))
        Me.MemoEdit3.Location = New System.Drawing.Point(82, 243)
        Me.MemoEdit3.MenuManager = Me.RibbonControl1
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Properties.ReadOnly = True
        Me.MemoEdit3.Size = New System.Drawing.Size(280, 46)
        Me.MemoEdit3.TabIndex = 52
        Me.MemoEdit3.TabStop = False
        '
        'MemoEdit2
        '
        Me.MemoEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Transportationnotes", True))
        Me.MemoEdit2.Location = New System.Drawing.Point(82, 191)
        Me.MemoEdit2.MenuManager = Me.RibbonControl1
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Properties.ReadOnly = True
        Me.MemoEdit2.Size = New System.Drawing.Size(280, 46)
        Me.MemoEdit2.TabIndex = 51
        Me.MemoEdit2.TabStop = False
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Prodfulfillmentnotes", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(82, 104)
        Me.MemoEdit1.MenuManager = Me.RibbonControl1
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.ReadOnly = True
        Me.MemoEdit1.Size = New System.Drawing.Size(280, 81)
        Me.MemoEdit1.TabIndex = 50
        Me.MemoEdit1.TabStop = False
        '
        'CustnotesMemoEdit
        '
        Me.CustnotesMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custnotes", True))
        Me.CustnotesMemoEdit.Location = New System.Drawing.Point(82, 24)
        Me.CustnotesMemoEdit.MenuManager = Me.RibbonControl1
        Me.CustnotesMemoEdit.Name = "CustnotesMemoEdit"
        Me.CustnotesMemoEdit.Properties.ReadOnly = True
        Me.CustnotesMemoEdit.Size = New System.Drawing.Size(280, 74)
        Me.CustnotesMemoEdit.TabIndex = 49
        Me.CustnotesMemoEdit.TabStop = False
        '
        'GroupControl13
        '
        Me.GroupControl13.Controls.Add(FreightoninvoiceLabel)
        Me.GroupControl13.Controls.Add(Me.FreightoninvoiceCheckEdit)
        Me.GroupControl13.Controls.Add(FreightbillcustomerLabel)
        Me.GroupControl13.Controls.Add(Me.FreightbillcustomerCheckEdit)
        Me.GroupControl13.Controls.Add(Me.CarrieridLookUpEdit)
        Me.GroupControl13.Controls.Add(FobLabel)
        Me.GroupControl13.Controls.Add(CarrieridLabel)
        Me.GroupControl13.Controls.Add(Me.FobTextEdit)
        Me.GroupControl13.Controls.Add(Me.BulkcarrieridLookUpEdit)
        Me.GroupControl13.Controls.Add(LogisticsidLabel)
        Me.GroupControl13.Controls.Add(BulkcarrieridLabel)
        Me.GroupControl13.Controls.Add(Me.LogisticsidLookUpEdit)
        Me.GroupControl13.Location = New System.Drawing.Point(6, 264)
        Me.GroupControl13.Name = "GroupControl13"
        Me.GroupControl13.Size = New System.Drawing.Size(367, 158)
        Me.GroupControl13.TabIndex = 47
        Me.GroupControl13.Text = "Transportation Information"
        '
        'FreightoninvoiceCheckEdit
        '
        Me.FreightoninvoiceCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Freightoninvoice", True))
        Me.FreightoninvoiceCheckEdit.Location = New System.Drawing.Point(327, 79)
        Me.FreightoninvoiceCheckEdit.MenuManager = Me.RibbonControl1
        Me.FreightoninvoiceCheckEdit.Name = "FreightoninvoiceCheckEdit"
        Me.FreightoninvoiceCheckEdit.Properties.Caption = ""
        Me.FreightoninvoiceCheckEdit.Properties.ReadOnly = True
        Me.FreightoninvoiceCheckEdit.Size = New System.Drawing.Size(22, 19)
        Me.FreightoninvoiceCheckEdit.TabIndex = 48
        Me.FreightoninvoiceCheckEdit.TabStop = False
        '
        'FreightbillcustomerCheckEdit
        '
        Me.FreightbillcustomerCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Freightbillcustomer", True))
        Me.FreightbillcustomerCheckEdit.Location = New System.Drawing.Point(163, 78)
        Me.FreightbillcustomerCheckEdit.MenuManager = Me.RibbonControl1
        Me.FreightbillcustomerCheckEdit.Name = "FreightbillcustomerCheckEdit"
        Me.FreightbillcustomerCheckEdit.Properties.Caption = ""
        Me.FreightbillcustomerCheckEdit.Properties.ReadOnly = True
        Me.FreightbillcustomerCheckEdit.Size = New System.Drawing.Size(27, 19)
        Me.FreightbillcustomerCheckEdit.TabIndex = 47
        Me.FreightbillcustomerCheckEdit.TabStop = False
        '
        'CarrieridLookUpEdit
        '
        Me.CarrieridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Carrierid", True))
        Me.CarrieridLookUpEdit.Location = New System.Drawing.Point(82, 104)
        Me.CarrieridLookUpEdit.MenuManager = Me.RibbonControl1
        Me.CarrieridLookUpEdit.Name = "CarrieridLookUpEdit"
        Me.CarrieridLookUpEdit.Properties.DataSource = Me.bsCarriers
        Me.CarrieridLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.CarrieridLookUpEdit.Properties.NullText = ""
        Me.CarrieridLookUpEdit.Properties.ReadOnly = True
        Me.CarrieridLookUpEdit.Properties.ValueMember = "CarrierID"
        Me.CarrieridLookUpEdit.Size = New System.Drawing.Size(280, 20)
        Me.CarrieridLookUpEdit.TabIndex = 43
        Me.CarrieridLookUpEdit.TabStop = False
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'FobTextEdit
        '
        Me.FobTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Fob", True))
        Me.FobTextEdit.Location = New System.Drawing.Point(82, 24)
        Me.FobTextEdit.MenuManager = Me.RibbonControl1
        Me.FobTextEdit.Name = "FobTextEdit"
        Me.FobTextEdit.Properties.ReadOnly = True
        Me.FobTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.FobTextEdit.TabIndex = 46
        Me.FobTextEdit.TabStop = False
        '
        'BulkcarrieridLookUpEdit
        '
        Me.BulkcarrieridLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Bulkcarrierid", True))
        Me.BulkcarrieridLookUpEdit.Location = New System.Drawing.Point(82, 130)
        Me.BulkcarrieridLookUpEdit.MenuManager = Me.RibbonControl1
        Me.BulkcarrieridLookUpEdit.Name = "BulkcarrieridLookUpEdit"
        Me.BulkcarrieridLookUpEdit.Properties.DataSource = Me.bsBulkCarriers
        Me.BulkcarrieridLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.BulkcarrieridLookUpEdit.Properties.NullText = ""
        Me.BulkcarrieridLookUpEdit.Properties.ReadOnly = True
        Me.BulkcarrieridLookUpEdit.Properties.ValueMember = "CarrierID"
        Me.BulkcarrieridLookUpEdit.Size = New System.Drawing.Size(280, 20)
        Me.BulkcarrieridLookUpEdit.TabIndex = 45
        Me.BulkcarrieridLookUpEdit.TabStop = False
        '
        'bsBulkCarriers
        '
        Me.bsBulkCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'LogisticsidLookUpEdit
        '
        Me.LogisticsidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Logisticsid", True))
        Me.LogisticsidLookUpEdit.Location = New System.Drawing.Point(82, 50)
        Me.LogisticsidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.LogisticsidLookUpEdit.Name = "LogisticsidLookUpEdit"
        Me.LogisticsidLookUpEdit.Properties.DataSource = Me.bsLogistics
        Me.LogisticsidLookUpEdit.Properties.DisplayMember = "Logisticsname"
        Me.LogisticsidLookUpEdit.Properties.NullText = ""
        Me.LogisticsidLookUpEdit.Properties.ReadOnly = True
        Me.LogisticsidLookUpEdit.Properties.ValueMember = "Logisticsid"
        Me.LogisticsidLookUpEdit.Size = New System.Drawing.Size(280, 20)
        Me.LogisticsidLookUpEdit.TabIndex = 44
        Me.LogisticsidLookUpEdit.TabStop = False
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'GroupControl12
        '
        Me.GroupControl12.Controls.Add(Me.CustbillcontactTextEdit)
        Me.GroupControl12.Controls.Add(Me.Custbilladdress1TextEdit)
        Me.GroupControl12.Controls.Add(Me.CustbillpostalcodeTextEdit)
        Me.GroupControl12.Controls.Add(Custbilladdress1Label)
        Me.GroupControl12.Controls.Add(CustbillpostalcodeLabel)
        Me.GroupControl12.Controls.Add(Me.Custbilladdress2TextEdit)
        Me.GroupControl12.Controls.Add(CustbillstateprovLabel)
        Me.GroupControl12.Controls.Add(Custbilladdress2Label)
        Me.GroupControl12.Controls.Add(Me.CustbillcountryTextEdit)
        Me.GroupControl12.Controls.Add(Me.CustbillstateprovTextEdit)
        Me.GroupControl12.Controls.Add(Me.CustbillcityTextEdit)
        Me.GroupControl12.Controls.Add(CustbillcityLabel)
        Me.GroupControl12.Location = New System.Drawing.Point(379, 102)
        Me.GroupControl12.Name = "GroupControl12"
        Me.GroupControl12.Size = New System.Drawing.Size(368, 156)
        Me.GroupControl12.TabIndex = 38
        Me.GroupControl12.Text = "Billing Information"
        '
        'CustbillcontactTextEdit
        '
        Me.CustbillcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custbillcontact", True))
        Me.CustbillcontactTextEdit.Location = New System.Drawing.Point(82, 129)
        Me.CustbillcontactTextEdit.MenuManager = Me.RibbonControl1
        Me.CustbillcontactTextEdit.Name = "CustbillcontactTextEdit"
        Me.CustbillcontactTextEdit.Properties.ReadOnly = True
        Me.CustbillcontactTextEdit.Size = New System.Drawing.Size(280, 20)
        Me.CustbillcontactTextEdit.TabIndex = 31
        Me.CustbillcontactTextEdit.TabStop = False
        '
        'Custbilladdress1TextEdit
        '
        Me.Custbilladdress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custbilladdress1", True))
        Me.Custbilladdress1TextEdit.Location = New System.Drawing.Point(82, 24)
        Me.Custbilladdress1TextEdit.MenuManager = Me.RibbonControl1
        Me.Custbilladdress1TextEdit.Name = "Custbilladdress1TextEdit"
        Me.Custbilladdress1TextEdit.Properties.ReadOnly = True
        Me.Custbilladdress1TextEdit.Size = New System.Drawing.Size(280, 20)
        Me.Custbilladdress1TextEdit.TabIndex = 19
        Me.Custbilladdress1TextEdit.TabStop = False
        '
        'CustbillpostalcodeTextEdit
        '
        Me.CustbillpostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custbillpostalcode", True))
        Me.CustbillpostalcodeTextEdit.Location = New System.Drawing.Point(298, 76)
        Me.CustbillpostalcodeTextEdit.MenuManager = Me.RibbonControl1
        Me.CustbillpostalcodeTextEdit.Name = "CustbillpostalcodeTextEdit"
        Me.CustbillpostalcodeTextEdit.Properties.ReadOnly = True
        Me.CustbillpostalcodeTextEdit.Size = New System.Drawing.Size(64, 20)
        Me.CustbillpostalcodeTextEdit.TabIndex = 27
        Me.CustbillpostalcodeTextEdit.TabStop = False
        '
        'Custbilladdress2TextEdit
        '
        Me.Custbilladdress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custbilladdress2", True))
        Me.Custbilladdress2TextEdit.Location = New System.Drawing.Point(82, 50)
        Me.Custbilladdress2TextEdit.MenuManager = Me.RibbonControl1
        Me.Custbilladdress2TextEdit.Name = "Custbilladdress2TextEdit"
        Me.Custbilladdress2TextEdit.Properties.ReadOnly = True
        Me.Custbilladdress2TextEdit.Size = New System.Drawing.Size(280, 20)
        Me.Custbilladdress2TextEdit.TabIndex = 21
        Me.Custbilladdress2TextEdit.TabStop = False
        '
        'CustbillcountryTextEdit
        '
        Me.CustbillcountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custbillcountry", True))
        Me.CustbillcountryTextEdit.Location = New System.Drawing.Point(82, 102)
        Me.CustbillcountryTextEdit.MenuManager = Me.RibbonControl1
        Me.CustbillcountryTextEdit.Name = "CustbillcountryTextEdit"
        Me.CustbillcountryTextEdit.Properties.ReadOnly = True
        Me.CustbillcountryTextEdit.Size = New System.Drawing.Size(280, 20)
        Me.CustbillcountryTextEdit.TabIndex = 29
        Me.CustbillcountryTextEdit.TabStop = False
        '
        'CustbillstateprovTextEdit
        '
        Me.CustbillstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custbillstateprov", True))
        Me.CustbillstateprovTextEdit.Location = New System.Drawing.Point(254, 76)
        Me.CustbillstateprovTextEdit.MenuManager = Me.RibbonControl1
        Me.CustbillstateprovTextEdit.Name = "CustbillstateprovTextEdit"
        Me.CustbillstateprovTextEdit.Properties.ReadOnly = True
        Me.CustbillstateprovTextEdit.Size = New System.Drawing.Size(38, 20)
        Me.CustbillstateprovTextEdit.TabIndex = 25
        Me.CustbillstateprovTextEdit.TabStop = False
        '
        'CustbillcityTextEdit
        '
        Me.CustbillcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custbillcity", True))
        Me.CustbillcityTextEdit.Location = New System.Drawing.Point(82, 76)
        Me.CustbillcityTextEdit.MenuManager = Me.RibbonControl1
        Me.CustbillcityTextEdit.Name = "CustbillcityTextEdit"
        Me.CustbillcityTextEdit.Properties.ReadOnly = True
        Me.CustbillcityTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.CustbillcityTextEdit.TabIndex = 23
        Me.CustbillcityTextEdit.TabStop = False
        '
        'GroupControl11
        '
        Me.GroupControl11.Controls.Add(Me.Custshipaddress1TextEdit)
        Me.GroupControl11.Controls.Add(Custshipaddress1Label)
        Me.GroupControl11.Controls.Add(Me.Custshipaddress2TextEdit)
        Me.GroupControl11.Controls.Add(Custshipaddress2Label)
        Me.GroupControl11.Controls.Add(Me.CustshipcityTextEdit)
        Me.GroupControl11.Controls.Add(CustshipcityLabel)
        Me.GroupControl11.Controls.Add(Me.CustshipstateprovTextEdit)
        Me.GroupControl11.Controls.Add(CustshipstateprovLabel)
        Me.GroupControl11.Controls.Add(Me.CustshippostalcodeTextEdit)
        Me.GroupControl11.Controls.Add(CustshippostalcodeLabel)
        Me.GroupControl11.Controls.Add(Me.CustshipcountryTextEdit)
        Me.GroupControl11.Controls.Add(Me.CustshipcontactTextEdit)
        Me.GroupControl11.Location = New System.Drawing.Point(6, 102)
        Me.GroupControl11.Name = "GroupControl11"
        Me.GroupControl11.Size = New System.Drawing.Size(367, 156)
        Me.GroupControl11.TabIndex = 37
        Me.GroupControl11.Text = "Shipping Information"
        '
        'Custshipaddress1TextEdit
        '
        Me.Custshipaddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custshipaddress1", True))
        Me.Custshipaddress1TextEdit.Location = New System.Drawing.Point(82, 24)
        Me.Custshipaddress1TextEdit.MenuManager = Me.RibbonControl1
        Me.Custshipaddress1TextEdit.Name = "Custshipaddress1TextEdit"
        Me.Custshipaddress1TextEdit.Properties.ReadOnly = True
        Me.Custshipaddress1TextEdit.Size = New System.Drawing.Size(280, 20)
        Me.Custshipaddress1TextEdit.TabIndex = 5
        Me.Custshipaddress1TextEdit.TabStop = False
        '
        'Custshipaddress2TextEdit
        '
        Me.Custshipaddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custshipaddress2", True))
        Me.Custshipaddress2TextEdit.Location = New System.Drawing.Point(82, 50)
        Me.Custshipaddress2TextEdit.MenuManager = Me.RibbonControl1
        Me.Custshipaddress2TextEdit.Name = "Custshipaddress2TextEdit"
        Me.Custshipaddress2TextEdit.Properties.ReadOnly = True
        Me.Custshipaddress2TextEdit.Size = New System.Drawing.Size(280, 20)
        Me.Custshipaddress2TextEdit.TabIndex = 7
        Me.Custshipaddress2TextEdit.TabStop = False
        '
        'CustshipcityTextEdit
        '
        Me.CustshipcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custshipcity", True))
        Me.CustshipcityTextEdit.Location = New System.Drawing.Point(82, 76)
        Me.CustshipcityTextEdit.MenuManager = Me.RibbonControl1
        Me.CustshipcityTextEdit.Name = "CustshipcityTextEdit"
        Me.CustshipcityTextEdit.Properties.ReadOnly = True
        Me.CustshipcityTextEdit.Size = New System.Drawing.Size(166, 20)
        Me.CustshipcityTextEdit.TabIndex = 9
        Me.CustshipcityTextEdit.TabStop = False
        '
        'CustshipstateprovTextEdit
        '
        Me.CustshipstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custshipstateprov", True))
        Me.CustshipstateprovTextEdit.Location = New System.Drawing.Point(254, 76)
        Me.CustshipstateprovTextEdit.MenuManager = Me.RibbonControl1
        Me.CustshipstateprovTextEdit.Name = "CustshipstateprovTextEdit"
        Me.CustshipstateprovTextEdit.Properties.ReadOnly = True
        Me.CustshipstateprovTextEdit.Size = New System.Drawing.Size(38, 20)
        Me.CustshipstateprovTextEdit.TabIndex = 11
        Me.CustshipstateprovTextEdit.TabStop = False
        '
        'CustshippostalcodeTextEdit
        '
        Me.CustshippostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custshippostalcode", True))
        Me.CustshippostalcodeTextEdit.Location = New System.Drawing.Point(298, 76)
        Me.CustshippostalcodeTextEdit.MenuManager = Me.RibbonControl1
        Me.CustshippostalcodeTextEdit.Name = "CustshippostalcodeTextEdit"
        Me.CustshippostalcodeTextEdit.Properties.ReadOnly = True
        Me.CustshippostalcodeTextEdit.Size = New System.Drawing.Size(64, 20)
        Me.CustshippostalcodeTextEdit.TabIndex = 13
        Me.CustshippostalcodeTextEdit.TabStop = False
        '
        'CustshipcountryTextEdit
        '
        Me.CustshipcountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custshipcountry", True))
        Me.CustshipcountryTextEdit.Location = New System.Drawing.Point(82, 102)
        Me.CustshipcountryTextEdit.MenuManager = Me.RibbonControl1
        Me.CustshipcountryTextEdit.Name = "CustshipcountryTextEdit"
        Me.CustshipcountryTextEdit.Properties.ReadOnly = True
        Me.CustshipcountryTextEdit.Size = New System.Drawing.Size(280, 20)
        Me.CustshipcountryTextEdit.TabIndex = 15
        Me.CustshipcountryTextEdit.TabStop = False
        '
        'CustshipcontactTextEdit
        '
        Me.CustshipcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custshipcontact", True))
        Me.CustshipcontactTextEdit.Location = New System.Drawing.Point(82, 129)
        Me.CustshipcontactTextEdit.MenuManager = Me.RibbonControl1
        Me.CustshipcontactTextEdit.Name = "CustshipcontactTextEdit"
        Me.CustshipcontactTextEdit.Properties.ReadOnly = True
        Me.CustshipcontactTextEdit.Size = New System.Drawing.Size(280, 20)
        Me.CustshipcontactTextEdit.TabIndex = 17
        Me.CustshipcontactTextEdit.TabStop = False
        '
        'GroupControl10
        '
        Me.GroupControl10.Controls.Add(Label6)
        Me.GroupControl10.Controls.Add(Me.CheckEdit2)
        Me.GroupControl10.Controls.Add(Label5)
        Me.GroupControl10.Controls.Add(Me.CheckEdit1)
        Me.GroupControl10.Controls.Add(Label4)
        Me.GroupControl10.Controls.Add(Me.SalespersonIDLookUpEdit2)
        Me.GroupControl10.Controls.Add(SalespersonidLabel)
        Me.GroupControl10.Controls.Add(IsactiveLabel)
        Me.GroupControl10.Controls.Add(Me.SalespersonidLookUpEdit)
        Me.GroupControl10.Controls.Add(Me.CustidTextEdit)
        Me.GroupControl10.Controls.Add(Me.IsactiveCheckEdit)
        Me.GroupControl10.Controls.Add(CustidLabel)
        Me.GroupControl10.Controls.Add(Me.CustnameTextEdit)
        Me.GroupControl10.Controls.Add(CustnameLabel)
        Me.GroupControl10.Location = New System.Drawing.Point(6, 19)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.Size = New System.Drawing.Size(741, 77)
        Me.GroupControl10.TabIndex = 36
        Me.GroupControl10.Text = "Customer Information"
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Isconsignment", True))
        Me.CheckEdit2.Location = New System.Drawing.Point(533, 0)
        Me.CheckEdit2.MenuManager = Me.RibbonControl1
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Consignment"
        Me.CheckEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit2.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit2.Properties.ReadOnly = True
        Me.CheckEdit2.Size = New System.Drawing.Size(19, 19)
        Me.CheckEdit2.TabIndex = 55
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Taxexempt", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(640, 0)
        Me.CheckEdit1.MenuManager = Me.RibbonControl1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Tax Exempt"
        Me.CheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit1.Properties.ReadOnly = True
        Me.CheckEdit1.Properties.ValueChecked = "1"
        Me.CheckEdit1.Properties.ValueUnchecked = "0"
        Me.CheckEdit1.Size = New System.Drawing.Size(19, 19)
        Me.CheckEdit1.TabIndex = 53
        '
        'SalespersonIDLookUpEdit2
        '
        Me.SalespersonIDLookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Secondarysalespersonid", True))
        Me.SalespersonIDLookUpEdit2.Location = New System.Drawing.Point(593, 45)
        Me.SalespersonIDLookUpEdit2.MenuManager = Me.RibbonControl1
        Me.SalespersonIDLookUpEdit2.Name = "SalespersonIDLookUpEdit2"
        Me.SalespersonIDLookUpEdit2.Properties.DataSource = Me.bsSalesPersonList2
        Me.SalespersonIDLookUpEdit2.Properties.DisplayMember = "Salespersonfullname"
        Me.SalespersonIDLookUpEdit2.Properties.NullText = ""
        Me.SalespersonIDLookUpEdit2.Properties.ReadOnly = True
        Me.SalespersonIDLookUpEdit2.Properties.ValueMember = "Salespersonid"
        Me.SalespersonIDLookUpEdit2.Size = New System.Drawing.Size(142, 20)
        Me.SalespersonIDLookUpEdit2.TabIndex = 51
        '
        'bsSalesPersonList2
        '
        Me.bsSalesPersonList2.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'SalespersonidLookUpEdit
        '
        Me.SalespersonidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Salespersonid", True))
        Me.SalespersonidLookUpEdit.Location = New System.Drawing.Point(593, 23)
        Me.SalespersonidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.SalespersonidLookUpEdit.Name = "SalespersonidLookUpEdit"
        Me.SalespersonidLookUpEdit.Properties.DataSource = Me.bsSalespersonList
        Me.SalespersonidLookUpEdit.Properties.DisplayMember = "Salespersonfullname"
        Me.SalespersonidLookUpEdit.Properties.NullText = ""
        Me.SalespersonidLookUpEdit.Properties.ReadOnly = True
        Me.SalespersonidLookUpEdit.Properties.ValueMember = "Salespersonid"
        Me.SalespersonidLookUpEdit.Size = New System.Drawing.Size(142, 20)
        Me.SalespersonidLookUpEdit.TabIndex = 49
        '
        'bsSalespersonList
        '
        Me.bsSalespersonList.DataSource = GetType(AOS.BusinessObjects.SalespersonCollection)
        '
        'CustidTextEdit
        '
        Me.CustidTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custid", True))
        Me.CustidTextEdit.Location = New System.Drawing.Point(82, 23)
        Me.CustidTextEdit.MenuManager = Me.RibbonControl1
        Me.CustidTextEdit.Name = "CustidTextEdit"
        Me.CustidTextEdit.Properties.ReadOnly = True
        Me.CustidTextEdit.Size = New System.Drawing.Size(54, 20)
        Me.CustidTextEdit.TabIndex = 1
        Me.CustidTextEdit.TabStop = False
        '
        'IsactiveCheckEdit
        '
        Me.IsactiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Isactive", True))
        Me.IsactiveCheckEdit.Location = New System.Drawing.Point(716, 0)
        Me.IsactiveCheckEdit.MenuManager = Me.RibbonControl1
        Me.IsactiveCheckEdit.Name = "IsactiveCheckEdit"
        Me.IsactiveCheckEdit.Properties.Caption = "Active"
        Me.IsactiveCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.IsactiveCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.IsactiveCheckEdit.Properties.ReadOnly = True
        Me.IsactiveCheckEdit.Size = New System.Drawing.Size(19, 19)
        Me.IsactiveCheckEdit.TabIndex = 44
        '
        'CustnameTextEdit
        '
        Me.CustnameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Custname", True))
        Me.CustnameTextEdit.Location = New System.Drawing.Point(82, 49)
        Me.CustnameTextEdit.MenuManager = Me.RibbonControl1
        Me.CustnameTextEdit.Name = "CustnameTextEdit"
        Me.CustnameTextEdit.Properties.ReadOnly = True
        Me.CustnameTextEdit.Size = New System.Drawing.Size(280, 20)
        Me.CustnameTextEdit.TabIndex = 3
        Me.CustnameTextEdit.TabStop = False
        '
        'PanelControl8
        '
        Me.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl8.Location = New System.Drawing.Point(364, 2)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(6, 562)
        Me.PanelControl8.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grCustomers)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(362, 562)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Customer List"
        '
        'grCustomers
        '
        Me.grCustomers.DataSource = Me.bsCustomers
        Me.grCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCustomers.Location = New System.Drawing.Point(2, 20)
        Me.grCustomers.LookAndFeel.SkinName = "Money Twins"
        Me.grCustomers.MainView = Me.GridView3
        Me.grCustomers.Name = "grCustomers"
        Me.grCustomers.Size = New System.Drawing.Size(358, 540)
        Me.grCustomers.TabIndex = 0
        Me.grCustomers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView3.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView3.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustid, Me.colCustname})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView3.GridControl = Me.grCustomers
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colCustid
        '
        Me.colCustid.Caption = "Cust ID"
        Me.colCustid.FieldName = "Custid"
        Me.colCustid.Name = "colCustid"
        Me.colCustid.Visible = True
        Me.colCustid.VisibleIndex = 0
        Me.colCustid.Width = 61
        '
        'colCustname
        '
        Me.colCustname.Caption = "Customer Name"
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 1
        Me.colCustname.Width = 233
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Controls.Add(Me.GroupControl4)
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1482, 566)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grInvoices)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1478, 562)
        Me.GroupControl4.TabIndex = 9
        Me.GroupControl4.Text = "Invoices"
        '
        'grInvoices
        '
        Me.grInvoices.DataSource = Me.bsInvoices
        Me.grInvoices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInvoices.Location = New System.Drawing.Point(2, 20)
        Me.grInvoices.LookAndFeel.SkinName = "Money Twins"
        Me.grInvoices.MainView = Me.grvInvoiceList
        Me.grInvoices.Name = "grInvoices"
        Me.grInvoices.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit4})
        Me.grInvoices.Size = New System.Drawing.Size(1474, 540)
        Me.grInvoices.TabIndex = 0
        Me.grInvoices.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvInvoiceList})
        '
        'bsInvoices
        '
        Me.bsInvoices.DataSource = GetType(AOS.BusinessObjects.InvoiceCollection)
        '
        'grvInvoiceList
        '
        Me.grvInvoiceList.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvInvoiceList.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvInvoiceList.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.grvInvoiceList.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvInvoiceList.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvInvoiceList.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvInvoiceList.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.grvInvoiceList.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvInvoiceList.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.grvInvoiceList.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.grvInvoiceList.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvInvoiceList.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvInvoiceList.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvInvoiceList.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grvInvoiceList.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvInvoiceList.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvInvoiceList.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grvInvoiceList.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvInvoiceList.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvInvoiceList.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvInvoiceList.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvInvoiceList.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grvInvoiceList.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvInvoiceList.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvInvoiceList.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grvInvoiceList.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvInvoiceList.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvInvoiceList.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvInvoiceList.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvInvoiceList.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvInvoiceList.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvInvoiceList.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvInvoiceList.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grvInvoiceList.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvInvoiceList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoicenumber1, Me.colInvoicedate, Me.colCustid4, Me.colSubtotal, Me.colSalestax, Me.colTotal, Me.colInvoicestatus, Me.GridColumn1})
        Me.grvInvoiceList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvInvoiceList.GridControl = Me.grInvoices
        Me.grvInvoiceList.Name = "grvInvoiceList"
        Me.grvInvoiceList.OptionsBehavior.Editable = False
        Me.grvInvoiceList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvInvoiceList.OptionsSelection.MultiSelect = True
        Me.grvInvoiceList.OptionsView.ShowAutoFilterRow = True
        Me.grvInvoiceList.OptionsView.ShowGroupPanel = False
        Me.grvInvoiceList.OptionsView.ShowIndicator = False
        '
        'colInvoicenumber1
        '
        Me.colInvoicenumber1.Caption = "Invoice #"
        Me.colInvoicenumber1.FieldName = "Invoicenumber"
        Me.colInvoicenumber1.Name = "colInvoicenumber1"
        Me.colInvoicenumber1.Visible = True
        Me.colInvoicenumber1.VisibleIndex = 0
        Me.colInvoicenumber1.Width = 69
        '
        'colInvoicedate
        '
        Me.colInvoicedate.Caption = "Inv Date"
        Me.colInvoicedate.DisplayFormat.FormatString = "d"
        Me.colInvoicedate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colInvoicedate.FieldName = "Invoicedate"
        Me.colInvoicedate.Name = "colInvoicedate"
        Me.colInvoicedate.Visible = True
        Me.colInvoicedate.VisibleIndex = 1
        Me.colInvoicedate.Width = 70
        '
        'colCustid4
        '
        Me.colCustid4.Caption = "Customer"
        Me.colCustid4.ColumnEdit = Me.RepositoryItemLookUpEdit4
        Me.colCustid4.FieldName = "Custid"
        Me.colCustid4.Name = "colCustid4"
        Me.colCustid4.Visible = True
        Me.colCustid4.VisibleIndex = 2
        Me.colCustid4.Width = 242
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.bsCustomerList
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ValueMember = "Custid"
        '
        'colSubtotal
        '
        Me.colSubtotal.AppearanceCell.Options.UseTextOptions = True
        Me.colSubtotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSubtotal.Caption = "Subtotal"
        Me.colSubtotal.DisplayFormat.FormatString = "c2"
        Me.colSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSubtotal.FieldName = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.Visible = True
        Me.colSubtotal.VisibleIndex = 3
        Me.colSubtotal.Width = 79
        '
        'colSalestax
        '
        Me.colSalestax.AppearanceCell.Options.UseTextOptions = True
        Me.colSalestax.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSalestax.Caption = "Sales Tax"
        Me.colSalestax.DisplayFormat.FormatString = "c2"
        Me.colSalestax.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSalestax.FieldName = "Salestax"
        Me.colSalestax.Name = "colSalestax"
        Me.colSalestax.Visible = True
        Me.colSalestax.VisibleIndex = 4
        Me.colSalestax.Width = 72
        '
        'colTotal
        '
        Me.colTotal.AppearanceCell.Options.UseTextOptions = True
        Me.colTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colTotal.Caption = "Total"
        Me.colTotal.DisplayFormat.FormatString = "c2"
        Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTotal.FieldName = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Visible = True
        Me.colTotal.VisibleIndex = 5
        Me.colTotal.Width = 94
        '
        'colInvoicestatus
        '
        Me.colInvoicestatus.Caption = "Status"
        Me.colInvoicestatus.FieldName = "Invoicestatus"
        Me.colInvoicestatus.Name = "colInvoicestatus"
        Me.colInvoicestatus.Visible = True
        Me.colInvoicestatus.VisibleIndex = 6
        Me.colInvoicestatus.Width = 197
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "QB Invoice"
        Me.GridColumn1.FieldName = "Invnumview"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 76
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.bsCustomerList
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ReadOnly = True
        Me.RepositoryItemLookUpEdit2.ValueMember = "Custid"
        '
        'RibbonPanelControl9
        '
        Me.RibbonPanelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RibbonPanelControl9.Controls.Add(Me.gcSalesByCustomerAnalysis)
        Me.RibbonPanelControl9.Controls.Add(Me.gcSalesAnalysis)
        Me.RibbonPanelControl9.Controls.Add(Me.gcCustomerAnalysis)
        Me.RibbonPanelControl9.Controls.Add(Me.gcCompanyAnalysis)
        Me.RibbonPanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl9.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl9.Name = "RibbonPanelControl9"
        Me.RibbonPanelControl9.Size = New System.Drawing.Size(1482, 566)
        Me.RibbonPanelControl9.TabIndex = 4
        '
        'gcSalesByCustomerAnalysis
        '
        Me.gcSalesByCustomerAnalysis.Controls.Add(Me.grcSalesByCustomerAnalysis)
        Me.gcSalesByCustomerAnalysis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSalesByCustomerAnalysis.Location = New System.Drawing.Point(0, 0)
        Me.gcSalesByCustomerAnalysis.Name = "gcSalesByCustomerAnalysis"
        Me.gcSalesByCustomerAnalysis.Size = New System.Drawing.Size(1482, 566)
        Me.gcSalesByCustomerAnalysis.TabIndex = 3
        Me.gcSalesByCustomerAnalysis.Text = "Sales By Customer Analysis"
        '
        'grcSalesByCustomerAnalysis
        '
        Me.grcSalesByCustomerAnalysis.DataSource = Me.bsSalesByCustomer
        Me.grcSalesByCustomerAnalysis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grcSalesByCustomerAnalysis.Location = New System.Drawing.Point(2, 20)
        Me.grcSalesByCustomerAnalysis.MainView = Me.grvSalesByCustomerAnalysis
        Me.grcSalesByCustomerAnalysis.MenuManager = Me.RibbonControl1
        Me.grcSalesByCustomerAnalysis.Name = "grcSalesByCustomerAnalysis"
        Me.grcSalesByCustomerAnalysis.Size = New System.Drawing.Size(1478, 544)
        Me.grcSalesByCustomerAnalysis.TabIndex = 0
        Me.grcSalesByCustomerAnalysis.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvSalesByCustomerAnalysis})
        '
        'bsSalesByCustomer
        '
        Me.bsSalesByCustomer.DataSource = GetType(AOS.BusinessObjects.ViewSalesByCustomerAnalysisCollection)
        '
        'grvSalesByCustomerAnalysis
        '
        Me.grvSalesByCustomerAnalysis.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSalesName, Me.colCustId_SalesByCustomerAnalysis, Me.colCustName_SalesByCustomerAnalysis, Me.colSalesRepName_SalesByCustomerAnalysis, Me.colYear_SalesByCustomerAnalysis, Me.colJAN_SalesByCustomerAnalysis, Me.colFEB_SalesByCustomerAnalysis, Me.colMAR_SalesByCustomerAnalysis, Me.colQtr1_SalesByCustomerAnalysis, Me.colAPR_SalesByCustomerAnalysis, Me.colMAY_SalesByCustomerAnalysis, Me.colJUN_SalesByCustomerAnalysis, Me.colQtr2_SalesByCustomerAnalysis, Me.colJUL_SalesByCustomerAnalysis, Me.colAUG_SalesByCustomerAnalysis, Me.colSEP_SalesByCustomerAnalysis, Me.colQtr3_SalesByCustomerAnalysis, Me.colOCT_SalesByCustomerAnalysis, Me.colNOV_SalesByCustomerAnalysis, Me.colDEC_SalesByCustomerAnalysis, Me.colQtr4_SalesByCustomerAnalysis, Me.colYTD_SalesByCustomerAnalysis, Me.colPrevYear_SalesByCustomerAnalysis, Me.colPrevJAN_SalesByCustomerAnalysis, Me.colPrevFEB_SalesByCustomerAnalysis, Me.colPrevMAR_SalesByCustomerAnalysis, Me.colPrevQtr1_SalesByCustomerAnalysis, Me.colPrevAPR_SalesByCustomerAnalysis, Me.colPrevMAY_SalesByCustomerAnalysis, Me.colPrevJUN_SalesByCustomerAnalysis, Me.colPrevQtr2_SalesByCustomerAnalysis, Me.colPrevJUL_SalesByCustomerAnalysis, Me.colPrevAUG_SalesByCustomerAnalysis, Me.colPrevSEP_SalesByCustomerAnalysis, Me.colPrevQtr3_SalesByCustomerAnalysis, Me.colPrevOCT_SalesByCustomerAnalysis, Me.colPrevNOV_SalesByCustomerAnalysis, Me.colPrevDEC_SalesByCustomerAnalysis, Me.colPrevQtr4_SalesByCustomerAnalysis, Me.colPrevTotal_SalesByCustomerAnalysis})
        Me.grvSalesByCustomerAnalysis.GridControl = Me.grcSalesByCustomerAnalysis
        Me.grvSalesByCustomerAnalysis.Name = "grvSalesByCustomerAnalysis"
        Me.grvSalesByCustomerAnalysis.OptionsBehavior.Editable = False
        Me.grvSalesByCustomerAnalysis.OptionsView.ShowAutoFilterRow = True
        Me.grvSalesByCustomerAnalysis.OptionsView.ShowFooter = True
        Me.grvSalesByCustomerAnalysis.OptionsView.ShowGroupPanel = False
        Me.grvSalesByCustomerAnalysis.OptionsView.ShowIndicator = False
        '
        'colSalesName
        '
        Me.colSalesName.Caption = "Sales Name"
        Me.colSalesName.FieldName = "SalesName"
        Me.colSalesName.Name = "colSalesName"
        Me.colSalesName.Visible = True
        Me.colSalesName.VisibleIndex = 0
        '
        'colCustId_SalesByCustomerAnalysis
        '
        Me.colCustId_SalesByCustomerAnalysis.AppearanceCell.Options.UseTextOptions = True
        Me.colCustId_SalesByCustomerAnalysis.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCustId_SalesByCustomerAnalysis.Caption = "Cust ID"
        Me.colCustId_SalesByCustomerAnalysis.FieldName = "Custid"
        Me.colCustId_SalesByCustomerAnalysis.Name = "colCustId_SalesByCustomerAnalysis"
        Me.colCustId_SalesByCustomerAnalysis.Visible = True
        Me.colCustId_SalesByCustomerAnalysis.VisibleIndex = 1
        Me.colCustId_SalesByCustomerAnalysis.Width = 37
        '
        'colCustName_SalesByCustomerAnalysis
        '
        Me.colCustName_SalesByCustomerAnalysis.Caption = "Customer Name"
        Me.colCustName_SalesByCustomerAnalysis.FieldName = "Custname"
        Me.colCustName_SalesByCustomerAnalysis.Name = "colCustName_SalesByCustomerAnalysis"
        Me.colCustName_SalesByCustomerAnalysis.Visible = True
        Me.colCustName_SalesByCustomerAnalysis.VisibleIndex = 2
        Me.colCustName_SalesByCustomerAnalysis.Width = 150
        '
        'colSalesRepName_SalesByCustomerAnalysis
        '
        Me.colSalesRepName_SalesByCustomerAnalysis.Caption = "2nd Sales Name"
        Me.colSalesRepName_SalesByCustomerAnalysis.FieldName = "ServiceRep"
        Me.colSalesRepName_SalesByCustomerAnalysis.Name = "colSalesRepName_SalesByCustomerAnalysis"
        Me.colSalesRepName_SalesByCustomerAnalysis.Visible = True
        Me.colSalesRepName_SalesByCustomerAnalysis.VisibleIndex = 3
        Me.colSalesRepName_SalesByCustomerAnalysis.Width = 85
        '
        'colYear_SalesByCustomerAnalysis
        '
        Me.colYear_SalesByCustomerAnalysis.AppearanceCell.Options.UseTextOptions = True
        Me.colYear_SalesByCustomerAnalysis.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYear_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colYear_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYear_SalesByCustomerAnalysis.Caption = "Year"
        Me.colYear_SalesByCustomerAnalysis.FieldName = "Year"
        Me.colYear_SalesByCustomerAnalysis.Name = "colYear_SalesByCustomerAnalysis"
        Me.colYear_SalesByCustomerAnalysis.Visible = True
        Me.colYear_SalesByCustomerAnalysis.VisibleIndex = 5
        Me.colYear_SalesByCustomerAnalysis.Width = 63
        '
        'colJAN_SalesByCustomerAnalysis
        '
        Me.colJAN_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colJAN_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJAN_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colJAN_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colJAN_SalesByCustomerAnalysis.FieldName = "Jan"
        Me.colJAN_SalesByCustomerAnalysis.Name = "colJAN_SalesByCustomerAnalysis"
        Me.colJAN_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jan", "{0:$#,###.##}")})
        Me.colJAN_SalesByCustomerAnalysis.Visible = True
        Me.colJAN_SalesByCustomerAnalysis.VisibleIndex = 7
        Me.colJAN_SalesByCustomerAnalysis.Width = 64
        '
        'colFEB_SalesByCustomerAnalysis
        '
        Me.colFEB_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colFEB_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFEB_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colFEB_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFEB_SalesByCustomerAnalysis.FieldName = "Feb"
        Me.colFEB_SalesByCustomerAnalysis.Name = "colFEB_SalesByCustomerAnalysis"
        Me.colFEB_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Feb", "{0:$#,###.##}")})
        Me.colFEB_SalesByCustomerAnalysis.Visible = True
        Me.colFEB_SalesByCustomerAnalysis.VisibleIndex = 9
        Me.colFEB_SalesByCustomerAnalysis.Width = 64
        '
        'colMAR_SalesByCustomerAnalysis
        '
        Me.colMAR_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colMAR_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMAR_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colMAR_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMAR_SalesByCustomerAnalysis.FieldName = "Mar"
        Me.colMAR_SalesByCustomerAnalysis.Name = "colMAR_SalesByCustomerAnalysis"
        Me.colMAR_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mar", "{0:$#,###.##}")})
        Me.colMAR_SalesByCustomerAnalysis.Visible = True
        Me.colMAR_SalesByCustomerAnalysis.VisibleIndex = 11
        Me.colMAR_SalesByCustomerAnalysis.Width = 64
        '
        'colQtr1_SalesByCustomerAnalysis
        '
        Me.colQtr1_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colQtr1_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colQtr1_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtr1_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtr1_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colQtr1_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtr1_SalesByCustomerAnalysis.FieldName = "Qtr1"
        Me.colQtr1_SalesByCustomerAnalysis.Name = "colQtr1_SalesByCustomerAnalysis"
        Me.colQtr1_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtr1", "{0:$#,###.##}")})
        Me.colQtr1_SalesByCustomerAnalysis.Visible = True
        Me.colQtr1_SalesByCustomerAnalysis.VisibleIndex = 13
        Me.colQtr1_SalesByCustomerAnalysis.Width = 70
        '
        'colAPR_SalesByCustomerAnalysis
        '
        Me.colAPR_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colAPR_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAPR_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colAPR_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAPR_SalesByCustomerAnalysis.FieldName = "Apr"
        Me.colAPR_SalesByCustomerAnalysis.Name = "colAPR_SalesByCustomerAnalysis"
        Me.colAPR_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Apr", "{0:$#,###.##}")})
        Me.colAPR_SalesByCustomerAnalysis.Visible = True
        Me.colAPR_SalesByCustomerAnalysis.VisibleIndex = 15
        Me.colAPR_SalesByCustomerAnalysis.Width = 70
        '
        'colMAY_SalesByCustomerAnalysis
        '
        Me.colMAY_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colMAY_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMAY_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colMAY_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMAY_SalesByCustomerAnalysis.FieldName = "May"
        Me.colMAY_SalesByCustomerAnalysis.Name = "colMAY_SalesByCustomerAnalysis"
        Me.colMAY_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "May", "{0:$#,###.##}")})
        Me.colMAY_SalesByCustomerAnalysis.Visible = True
        Me.colMAY_SalesByCustomerAnalysis.VisibleIndex = 17
        Me.colMAY_SalesByCustomerAnalysis.Width = 64
        '
        'colJUN_SalesByCustomerAnalysis
        '
        Me.colJUN_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colJUN_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJUN_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colJUN_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colJUN_SalesByCustomerAnalysis.FieldName = "Jun"
        Me.colJUN_SalesByCustomerAnalysis.Name = "colJUN_SalesByCustomerAnalysis"
        Me.colJUN_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jun", "{0:$#,###.##}")})
        Me.colJUN_SalesByCustomerAnalysis.Visible = True
        Me.colJUN_SalesByCustomerAnalysis.VisibleIndex = 19
        Me.colJUN_SalesByCustomerAnalysis.Width = 64
        '
        'colQtr2_SalesByCustomerAnalysis
        '
        Me.colQtr2_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colQtr2_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colQtr2_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtr2_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtr2_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colQtr2_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtr2_SalesByCustomerAnalysis.FieldName = "Qtr2"
        Me.colQtr2_SalesByCustomerAnalysis.Name = "colQtr2_SalesByCustomerAnalysis"
        Me.colQtr2_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtr2", "{0:$#,###.##}")})
        Me.colQtr2_SalesByCustomerAnalysis.Visible = True
        Me.colQtr2_SalesByCustomerAnalysis.VisibleIndex = 21
        Me.colQtr2_SalesByCustomerAnalysis.Width = 70
        '
        'colJUL_SalesByCustomerAnalysis
        '
        Me.colJUL_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colJUL_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJUL_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colJUL_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colJUL_SalesByCustomerAnalysis.FieldName = "Jul"
        Me.colJUL_SalesByCustomerAnalysis.Name = "colJUL_SalesByCustomerAnalysis"
        Me.colJUL_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jul", "{0:$#,###.##}")})
        Me.colJUL_SalesByCustomerAnalysis.Visible = True
        Me.colJUL_SalesByCustomerAnalysis.VisibleIndex = 23
        Me.colJUL_SalesByCustomerAnalysis.Width = 64
        '
        'colAUG_SalesByCustomerAnalysis
        '
        Me.colAUG_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colAUG_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAUG_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colAUG_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAUG_SalesByCustomerAnalysis.FieldName = "Aug"
        Me.colAUG_SalesByCustomerAnalysis.Name = "colAUG_SalesByCustomerAnalysis"
        Me.colAUG_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Aug", "{0:$#,###.##}")})
        Me.colAUG_SalesByCustomerAnalysis.Visible = True
        Me.colAUG_SalesByCustomerAnalysis.VisibleIndex = 25
        Me.colAUG_SalesByCustomerAnalysis.Width = 64
        '
        'colSEP_SalesByCustomerAnalysis
        '
        Me.colSEP_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colSEP_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSEP_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colSEP_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSEP_SalesByCustomerAnalysis.FieldName = "Sep"
        Me.colSEP_SalesByCustomerAnalysis.Name = "colSEP_SalesByCustomerAnalysis"
        Me.colSEP_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sep", "{0:$#,###.##}")})
        Me.colSEP_SalesByCustomerAnalysis.Visible = True
        Me.colSEP_SalesByCustomerAnalysis.VisibleIndex = 27
        Me.colSEP_SalesByCustomerAnalysis.Width = 64
        '
        'colQtr3_SalesByCustomerAnalysis
        '
        Me.colQtr3_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colQtr3_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colQtr3_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtr3_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtr3_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colQtr3_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtr3_SalesByCustomerAnalysis.FieldName = "Qtr3"
        Me.colQtr3_SalesByCustomerAnalysis.Name = "colQtr3_SalesByCustomerAnalysis"
        Me.colQtr3_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtr3", "{0:$#,###.##}")})
        Me.colQtr3_SalesByCustomerAnalysis.Visible = True
        Me.colQtr3_SalesByCustomerAnalysis.VisibleIndex = 29
        Me.colQtr3_SalesByCustomerAnalysis.Width = 70
        '
        'colOCT_SalesByCustomerAnalysis
        '
        Me.colOCT_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colOCT_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOCT_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colOCT_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOCT_SalesByCustomerAnalysis.FieldName = "Oct"
        Me.colOCT_SalesByCustomerAnalysis.Name = "colOCT_SalesByCustomerAnalysis"
        Me.colOCT_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oct", "{0:$#,###.##}")})
        Me.colOCT_SalesByCustomerAnalysis.Visible = True
        Me.colOCT_SalesByCustomerAnalysis.VisibleIndex = 31
        Me.colOCT_SalesByCustomerAnalysis.Width = 64
        '
        'colNOV_SalesByCustomerAnalysis
        '
        Me.colNOV_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colNOV_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNOV_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colNOV_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNOV_SalesByCustomerAnalysis.FieldName = "Nov"
        Me.colNOV_SalesByCustomerAnalysis.Name = "colNOV_SalesByCustomerAnalysis"
        Me.colNOV_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nov", "{0:$#,###.##}")})
        Me.colNOV_SalesByCustomerAnalysis.Visible = True
        Me.colNOV_SalesByCustomerAnalysis.VisibleIndex = 33
        Me.colNOV_SalesByCustomerAnalysis.Width = 64
        '
        'colDEC_SalesByCustomerAnalysis
        '
        Me.colDEC_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colDEC_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDEC_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colDEC_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDEC_SalesByCustomerAnalysis.FieldName = "Dec"
        Me.colDEC_SalesByCustomerAnalysis.Name = "colDEC_SalesByCustomerAnalysis"
        Me.colDEC_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dec", "{0:$#,###.##}")})
        Me.colDEC_SalesByCustomerAnalysis.Visible = True
        Me.colDEC_SalesByCustomerAnalysis.VisibleIndex = 35
        Me.colDEC_SalesByCustomerAnalysis.Width = 64
        '
        'colQtr4_SalesByCustomerAnalysis
        '
        Me.colQtr4_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colQtr4_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colQtr4_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtr4_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtr4_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colQtr4_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtr4_SalesByCustomerAnalysis.FieldName = "Qtr4"
        Me.colQtr4_SalesByCustomerAnalysis.Name = "colQtr4_SalesByCustomerAnalysis"
        Me.colQtr4_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtr4", "{0:$#,###.##}")})
        Me.colQtr4_SalesByCustomerAnalysis.Visible = True
        Me.colQtr4_SalesByCustomerAnalysis.VisibleIndex = 37
        Me.colQtr4_SalesByCustomerAnalysis.Width = 70
        '
        'colYTD_SalesByCustomerAnalysis
        '
        Me.colYTD_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colYTD_SalesByCustomerAnalysis.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colYTD_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colYTD_SalesByCustomerAnalysis.AppearanceCell.Options.UseFont = True
        Me.colYTD_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colYTD_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYTD_SalesByCustomerAnalysis.Caption = "YTD"
        Me.colYTD_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colYTD_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYTD_SalesByCustomerAnalysis.FieldName = "Ytd"
        Me.colYTD_SalesByCustomerAnalysis.Name = "colYTD_SalesByCustomerAnalysis"
        Me.colYTD_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ytd", "{0:$#,###.##}")})
        Me.colYTD_SalesByCustomerAnalysis.Visible = True
        Me.colYTD_SalesByCustomerAnalysis.VisibleIndex = 39
        Me.colYTD_SalesByCustomerAnalysis.Width = 95
        '
        'colPrevYear_SalesByCustomerAnalysis
        '
        Me.colPrevYear_SalesByCustomerAnalysis.AppearanceCell.Options.UseTextOptions = True
        Me.colPrevYear_SalesByCustomerAnalysis.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevYear_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevYear_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevYear_SalesByCustomerAnalysis.Caption = "Prev Year"
        Me.colPrevYear_SalesByCustomerAnalysis.FieldName = "PrevYear"
        Me.colPrevYear_SalesByCustomerAnalysis.Name = "colPrevYear_SalesByCustomerAnalysis"
        Me.colPrevYear_SalesByCustomerAnalysis.Visible = True
        Me.colPrevYear_SalesByCustomerAnalysis.VisibleIndex = 4
        Me.colPrevYear_SalesByCustomerAnalysis.Width = 63
        '
        'colPrevJAN_SalesByCustomerAnalysis
        '
        Me.colPrevJAN_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevJAN_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevJAN_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevJAN_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevJAN_SalesByCustomerAnalysis.FieldName = "PrevJan"
        Me.colPrevJAN_SalesByCustomerAnalysis.Name = "colPrevJAN_SalesByCustomerAnalysis"
        Me.colPrevJAN_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevJan", "{0:$#,###.##}")})
        Me.colPrevJAN_SalesByCustomerAnalysis.Visible = True
        Me.colPrevJAN_SalesByCustomerAnalysis.VisibleIndex = 6
        Me.colPrevJAN_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevFEB_SalesByCustomerAnalysis
        '
        Me.colPrevFEB_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevFEB_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevFEB_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevFEB_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevFEB_SalesByCustomerAnalysis.FieldName = "PrevFeb"
        Me.colPrevFEB_SalesByCustomerAnalysis.Name = "colPrevFEB_SalesByCustomerAnalysis"
        Me.colPrevFEB_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevFeb", "{0:$#,###.##}")})
        Me.colPrevFEB_SalesByCustomerAnalysis.Visible = True
        Me.colPrevFEB_SalesByCustomerAnalysis.VisibleIndex = 8
        Me.colPrevFEB_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevMAR_SalesByCustomerAnalysis
        '
        Me.colPrevMAR_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevMAR_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevMAR_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevMAR_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevMAR_SalesByCustomerAnalysis.FieldName = "PrevMar"
        Me.colPrevMAR_SalesByCustomerAnalysis.Name = "colPrevMAR_SalesByCustomerAnalysis"
        Me.colPrevMAR_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevMar", "{0:$#,###.##}")})
        Me.colPrevMAR_SalesByCustomerAnalysis.Visible = True
        Me.colPrevMAR_SalesByCustomerAnalysis.VisibleIndex = 10
        Me.colPrevMAR_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevQtr1_SalesByCustomerAnalysis
        '
        Me.colPrevQtr1_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colPrevQtr1_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colPrevQtr1_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevQtr1_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevQtr1_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevQtr1_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevQtr1_SalesByCustomerAnalysis.FieldName = "PrevQtr1"
        Me.colPrevQtr1_SalesByCustomerAnalysis.Name = "colPrevQtr1_SalesByCustomerAnalysis"
        Me.colPrevQtr1_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevQtr1", "{0:$#,###.##}")})
        Me.colPrevQtr1_SalesByCustomerAnalysis.Visible = True
        Me.colPrevQtr1_SalesByCustomerAnalysis.VisibleIndex = 12
        Me.colPrevQtr1_SalesByCustomerAnalysis.Width = 70
        '
        'colPrevAPR_SalesByCustomerAnalysis
        '
        Me.colPrevAPR_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevAPR_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevAPR_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevAPR_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevAPR_SalesByCustomerAnalysis.FieldName = "PrevApr"
        Me.colPrevAPR_SalesByCustomerAnalysis.Name = "colPrevAPR_SalesByCustomerAnalysis"
        Me.colPrevAPR_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevApr", "{0:$#,###.##}")})
        Me.colPrevAPR_SalesByCustomerAnalysis.Visible = True
        Me.colPrevAPR_SalesByCustomerAnalysis.VisibleIndex = 14
        Me.colPrevAPR_SalesByCustomerAnalysis.Width = 70
        '
        'colPrevMAY_SalesByCustomerAnalysis
        '
        Me.colPrevMAY_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevMAY_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevMAY_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevMAY_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevMAY_SalesByCustomerAnalysis.FieldName = "PrevMay"
        Me.colPrevMAY_SalesByCustomerAnalysis.Name = "colPrevMAY_SalesByCustomerAnalysis"
        Me.colPrevMAY_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevMay", "{0:$#,###.##}")})
        Me.colPrevMAY_SalesByCustomerAnalysis.Visible = True
        Me.colPrevMAY_SalesByCustomerAnalysis.VisibleIndex = 16
        Me.colPrevMAY_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevJUN_SalesByCustomerAnalysis
        '
        Me.colPrevJUN_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevJUN_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevJUN_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevJUN_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevJUN_SalesByCustomerAnalysis.FieldName = "PrevJun"
        Me.colPrevJUN_SalesByCustomerAnalysis.Name = "colPrevJUN_SalesByCustomerAnalysis"
        Me.colPrevJUN_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevJun", "{0:$#,###.##}")})
        Me.colPrevJUN_SalesByCustomerAnalysis.Visible = True
        Me.colPrevJUN_SalesByCustomerAnalysis.VisibleIndex = 18
        Me.colPrevJUN_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevQtr2_SalesByCustomerAnalysis
        '
        Me.colPrevQtr2_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colPrevQtr2_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colPrevQtr2_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevQtr2_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevQtr2_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevQtr2_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevQtr2_SalesByCustomerAnalysis.FieldName = "PrevQtr2"
        Me.colPrevQtr2_SalesByCustomerAnalysis.Name = "colPrevQtr2_SalesByCustomerAnalysis"
        Me.colPrevQtr2_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevQtr2", "{0:$#,###.##}")})
        Me.colPrevQtr2_SalesByCustomerAnalysis.Visible = True
        Me.colPrevQtr2_SalesByCustomerAnalysis.VisibleIndex = 20
        Me.colPrevQtr2_SalesByCustomerAnalysis.Width = 70
        '
        'colPrevJUL_SalesByCustomerAnalysis
        '
        Me.colPrevJUL_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevJUL_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevJUL_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevJUL_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevJUL_SalesByCustomerAnalysis.FieldName = "PrevJul"
        Me.colPrevJUL_SalesByCustomerAnalysis.Name = "colPrevJUL_SalesByCustomerAnalysis"
        Me.colPrevJUL_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevJul", "{0:$#,###.##}")})
        Me.colPrevJUL_SalesByCustomerAnalysis.Visible = True
        Me.colPrevJUL_SalesByCustomerAnalysis.VisibleIndex = 22
        Me.colPrevJUL_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevAUG_SalesByCustomerAnalysis
        '
        Me.colPrevAUG_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevAUG_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevAUG_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevAUG_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevAUG_SalesByCustomerAnalysis.FieldName = "PrevAug"
        Me.colPrevAUG_SalesByCustomerAnalysis.Name = "colPrevAUG_SalesByCustomerAnalysis"
        Me.colPrevAUG_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevAug", "{0:$#,###.##}")})
        Me.colPrevAUG_SalesByCustomerAnalysis.Visible = True
        Me.colPrevAUG_SalesByCustomerAnalysis.VisibleIndex = 24
        Me.colPrevAUG_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevSEP_SalesByCustomerAnalysis
        '
        Me.colPrevSEP_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevSEP_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevSEP_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevSEP_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevSEP_SalesByCustomerAnalysis.FieldName = "PrevSep"
        Me.colPrevSEP_SalesByCustomerAnalysis.Name = "colPrevSEP_SalesByCustomerAnalysis"
        Me.colPrevSEP_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevSep", "{0:$#,###.##}")})
        Me.colPrevSEP_SalesByCustomerAnalysis.Visible = True
        Me.colPrevSEP_SalesByCustomerAnalysis.VisibleIndex = 26
        Me.colPrevSEP_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevQtr3_SalesByCustomerAnalysis
        '
        Me.colPrevQtr3_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colPrevQtr3_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colPrevQtr3_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevQtr3_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevQtr3_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevQtr3_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevQtr3_SalesByCustomerAnalysis.FieldName = "PrevQtr3"
        Me.colPrevQtr3_SalesByCustomerAnalysis.Name = "colPrevQtr3_SalesByCustomerAnalysis"
        Me.colPrevQtr3_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevQtr3", "{0:$#,###.##}")})
        Me.colPrevQtr3_SalesByCustomerAnalysis.Visible = True
        Me.colPrevQtr3_SalesByCustomerAnalysis.VisibleIndex = 28
        Me.colPrevQtr3_SalesByCustomerAnalysis.Width = 70
        '
        'colPrevOCT_SalesByCustomerAnalysis
        '
        Me.colPrevOCT_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevOCT_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevOCT_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevOCT_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevOCT_SalesByCustomerAnalysis.FieldName = "PrevOct"
        Me.colPrevOCT_SalesByCustomerAnalysis.Name = "colPrevOCT_SalesByCustomerAnalysis"
        Me.colPrevOCT_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevOct", "{0:$#,###.##}")})
        Me.colPrevOCT_SalesByCustomerAnalysis.Visible = True
        Me.colPrevOCT_SalesByCustomerAnalysis.VisibleIndex = 30
        Me.colPrevOCT_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevNOV_SalesByCustomerAnalysis
        '
        Me.colPrevNOV_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevNOV_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevNOV_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevNOV_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevNOV_SalesByCustomerAnalysis.FieldName = "PrevNov"
        Me.colPrevNOV_SalesByCustomerAnalysis.Name = "colPrevNOV_SalesByCustomerAnalysis"
        Me.colPrevNOV_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevNov", "{0:$#,###.##}")})
        Me.colPrevNOV_SalesByCustomerAnalysis.Visible = True
        Me.colPrevNOV_SalesByCustomerAnalysis.VisibleIndex = 32
        Me.colPrevNOV_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevDEC_SalesByCustomerAnalysis
        '
        Me.colPrevDEC_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevDEC_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevDEC_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevDEC_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevDEC_SalesByCustomerAnalysis.FieldName = "PrevDec"
        Me.colPrevDEC_SalesByCustomerAnalysis.Name = "colPrevDEC_SalesByCustomerAnalysis"
        Me.colPrevDEC_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevDec", "{0:$#,###.##}")})
        Me.colPrevDEC_SalesByCustomerAnalysis.Visible = True
        Me.colPrevDEC_SalesByCustomerAnalysis.VisibleIndex = 34
        Me.colPrevDEC_SalesByCustomerAnalysis.Width = 64
        '
        'colPrevQtr4_SalesByCustomerAnalysis
        '
        Me.colPrevQtr4_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colPrevQtr4_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colPrevQtr4_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevQtr4_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevQtr4_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevQtr4_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevQtr4_SalesByCustomerAnalysis.FieldName = "PrevQtr4"
        Me.colPrevQtr4_SalesByCustomerAnalysis.Name = "colPrevQtr4_SalesByCustomerAnalysis"
        Me.colPrevQtr4_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevQtr4", "{0:$#,###.##}")})
        Me.colPrevQtr4_SalesByCustomerAnalysis.Visible = True
        Me.colPrevQtr4_SalesByCustomerAnalysis.VisibleIndex = 36
        Me.colPrevQtr4_SalesByCustomerAnalysis.Width = 70
        '
        'colPrevTotal_SalesByCustomerAnalysis
        '
        Me.colPrevTotal_SalesByCustomerAnalysis.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colPrevTotal_SalesByCustomerAnalysis.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPrevTotal_SalesByCustomerAnalysis.AppearanceCell.Options.UseBackColor = True
        Me.colPrevTotal_SalesByCustomerAnalysis.AppearanceCell.Options.UseFont = True
        Me.colPrevTotal_SalesByCustomerAnalysis.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrevTotal_SalesByCustomerAnalysis.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colPrevTotal_SalesByCustomerAnalysis.Caption = "Prev Total"
        Me.colPrevTotal_SalesByCustomerAnalysis.DisplayFormat.FormatString = "c2"
        Me.colPrevTotal_SalesByCustomerAnalysis.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPrevTotal_SalesByCustomerAnalysis.FieldName = "PrevTotal"
        Me.colPrevTotal_SalesByCustomerAnalysis.Name = "colPrevTotal_SalesByCustomerAnalysis"
        Me.colPrevTotal_SalesByCustomerAnalysis.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PrevTotal", "{0:$#,###.##}")})
        Me.colPrevTotal_SalesByCustomerAnalysis.Visible = True
        Me.colPrevTotal_SalesByCustomerAnalysis.VisibleIndex = 38
        Me.colPrevTotal_SalesByCustomerAnalysis.Width = 95
        '
        'gcSalesAnalysis
        '
        Me.gcSalesAnalysis.Controls.Add(Me.GridControl3)
        Me.gcSalesAnalysis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcSalesAnalysis.Location = New System.Drawing.Point(0, 0)
        Me.gcSalesAnalysis.Name = "gcSalesAnalysis"
        Me.gcSalesAnalysis.Size = New System.Drawing.Size(1482, 566)
        Me.gcSalesAnalysis.TabIndex = 0
        Me.gcSalesAnalysis.Text = "Sales Analysis"
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.bsSalesData
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 20)
        Me.GridControl3.MainView = Me.grvSalesAnalysis
        Me.GridControl3.MenuManager = Me.RibbonControl1
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(1478, 544)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvSalesAnalysis})
        '
        'bsSalesData
        '
        Me.bsSalesData.DataSource = GetType(AOS.BusinessObjects.ViewCustomerSalesDataCollection)
        '
        'grvSalesAnalysis
        '
        Me.grvSalesAnalysis.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustid7, Me.colCustname2, Me.colSName2, Me.colYear, Me.colJan, Me.colFeb, Me.colMar, Me.colQtr1, Me.colApr, Me.colMay, Me.colJun, Me.colQtr2, Me.colJul, Me.colAug, Me.colSep, Me.colQtr3, Me.colOct, Me.colNov, Me.colDec, Me.colQtr4, Me.colYtd})
        Me.grvSalesAnalysis.GridControl = Me.GridControl3
        Me.grvSalesAnalysis.Name = "grvSalesAnalysis"
        Me.grvSalesAnalysis.OptionsBehavior.Editable = False
        Me.grvSalesAnalysis.OptionsView.ShowAutoFilterRow = True
        Me.grvSalesAnalysis.OptionsView.ShowFooter = True
        Me.grvSalesAnalysis.OptionsView.ShowGroupPanel = False
        Me.grvSalesAnalysis.OptionsView.ShowIndicator = False
        '
        'colCustid7
        '
        Me.colCustid7.AppearanceCell.Options.UseTextOptions = True
        Me.colCustid7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colCustid7.Caption = "ID"
        Me.colCustid7.FieldName = "Custid"
        Me.colCustid7.Name = "colCustid7"
        Me.colCustid7.Visible = True
        Me.colCustid7.VisibleIndex = 0
        Me.colCustid7.Width = 37
        '
        'colCustname2
        '
        Me.colCustname2.Caption = "Customer Name"
        Me.colCustname2.FieldName = "Custname"
        Me.colCustname2.Name = "colCustname2"
        Me.colCustname2.Visible = True
        Me.colCustname2.VisibleIndex = 1
        Me.colCustname2.Width = 150
        '
        'colSName2
        '
        Me.colSName2.Caption = "2nd Sales Name"
        Me.colSName2.FieldName = "SName2"
        Me.colSName2.Name = "colSName2"
        Me.colSName2.Visible = True
        Me.colSName2.VisibleIndex = 2
        Me.colSName2.Width = 85
        '
        'colYear
        '
        Me.colYear.AppearanceCell.Options.UseTextOptions = True
        Me.colYear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYear.AppearanceHeader.Options.UseTextOptions = True
        Me.colYear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYear.Caption = "Year"
        Me.colYear.FieldName = "Year"
        Me.colYear.Name = "colYear"
        Me.colYear.Visible = True
        Me.colYear.VisibleIndex = 3
        Me.colYear.Width = 63
        '
        'colJan
        '
        Me.colJan.AppearanceHeader.Options.UseTextOptions = True
        Me.colJan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJan.DisplayFormat.FormatString = "c2"
        Me.colJan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colJan.FieldName = "Jan"
        Me.colJan.Name = "colJan"
        Me.colJan.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jan", "{0:$#,###.##}")})
        Me.colJan.Visible = True
        Me.colJan.VisibleIndex = 4
        Me.colJan.Width = 64
        '
        'colFeb
        '
        Me.colFeb.AppearanceHeader.Options.UseTextOptions = True
        Me.colFeb.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colFeb.DisplayFormat.FormatString = "c2"
        Me.colFeb.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colFeb.FieldName = "Feb"
        Me.colFeb.Name = "colFeb"
        Me.colFeb.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Feb", "{0:$#,###.##}")})
        Me.colFeb.Visible = True
        Me.colFeb.VisibleIndex = 5
        Me.colFeb.Width = 64
        '
        'colMar
        '
        Me.colMar.AppearanceHeader.Options.UseTextOptions = True
        Me.colMar.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMar.DisplayFormat.FormatString = "c2"
        Me.colMar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMar.FieldName = "Mar"
        Me.colMar.Name = "colMar"
        Me.colMar.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Mar", "{0:$#,###.##}")})
        Me.colMar.Visible = True
        Me.colMar.VisibleIndex = 6
        Me.colMar.Width = 64
        '
        'colQtr1
        '
        Me.colQtr1.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colQtr1.AppearanceCell.Options.UseBackColor = True
        Me.colQtr1.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtr1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtr1.DisplayFormat.FormatString = "c2"
        Me.colQtr1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtr1.FieldName = "Qtr1"
        Me.colQtr1.Name = "colQtr1"
        Me.colQtr1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtr1", "{0:$#,###.##}")})
        Me.colQtr1.Visible = True
        Me.colQtr1.VisibleIndex = 7
        Me.colQtr1.Width = 70
        '
        'colApr
        '
        Me.colApr.AppearanceHeader.Options.UseTextOptions = True
        Me.colApr.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colApr.DisplayFormat.FormatString = "c2"
        Me.colApr.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colApr.FieldName = "Apr"
        Me.colApr.Name = "colApr"
        Me.colApr.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Apr", "{0:$#,###.##}")})
        Me.colApr.Visible = True
        Me.colApr.VisibleIndex = 8
        Me.colApr.Width = 64
        '
        'colMay
        '
        Me.colMay.AppearanceHeader.Options.UseTextOptions = True
        Me.colMay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colMay.DisplayFormat.FormatString = "c2"
        Me.colMay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMay.FieldName = "May"
        Me.colMay.Name = "colMay"
        Me.colMay.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "May", "{0:$#,###.##}")})
        Me.colMay.Visible = True
        Me.colMay.VisibleIndex = 9
        Me.colMay.Width = 64
        '
        'colJun
        '
        Me.colJun.AppearanceHeader.Options.UseTextOptions = True
        Me.colJun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJun.DisplayFormat.FormatString = "c2"
        Me.colJun.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colJun.FieldName = "Jun"
        Me.colJun.Name = "colJun"
        Me.colJun.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jun", "{0:$#,###.##}")})
        Me.colJun.Visible = True
        Me.colJun.VisibleIndex = 10
        Me.colJun.Width = 64
        '
        'colQtr2
        '
        Me.colQtr2.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colQtr2.AppearanceCell.Options.UseBackColor = True
        Me.colQtr2.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtr2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtr2.DisplayFormat.FormatString = "c2"
        Me.colQtr2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtr2.FieldName = "Qtr2"
        Me.colQtr2.Name = "colQtr2"
        Me.colQtr2.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtr2", "{0:$#,###.##}")})
        Me.colQtr2.Visible = True
        Me.colQtr2.VisibleIndex = 11
        Me.colQtr2.Width = 70
        '
        'colJul
        '
        Me.colJul.AppearanceHeader.Options.UseTextOptions = True
        Me.colJul.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colJul.DisplayFormat.FormatString = "c2"
        Me.colJul.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colJul.FieldName = "Jul"
        Me.colJul.Name = "colJul"
        Me.colJul.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Jul", "{0:$#,###.##}")})
        Me.colJul.Visible = True
        Me.colJul.VisibleIndex = 12
        Me.colJul.Width = 64
        '
        'colAug
        '
        Me.colAug.AppearanceHeader.Options.UseTextOptions = True
        Me.colAug.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colAug.DisplayFormat.FormatString = "c2"
        Me.colAug.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAug.FieldName = "Aug"
        Me.colAug.Name = "colAug"
        Me.colAug.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Aug", "{0:$#,###.##}")})
        Me.colAug.Visible = True
        Me.colAug.VisibleIndex = 13
        Me.colAug.Width = 64
        '
        'colSep
        '
        Me.colSep.AppearanceHeader.Options.UseTextOptions = True
        Me.colSep.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colSep.DisplayFormat.FormatString = "c2"
        Me.colSep.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colSep.FieldName = "Sep"
        Me.colSep.Name = "colSep"
        Me.colSep.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Sep", "{0:$#,###.##}")})
        Me.colSep.Visible = True
        Me.colSep.VisibleIndex = 14
        Me.colSep.Width = 64
        '
        'colQtr3
        '
        Me.colQtr3.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colQtr3.AppearanceCell.Options.UseBackColor = True
        Me.colQtr3.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtr3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtr3.DisplayFormat.FormatString = "c2"
        Me.colQtr3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtr3.FieldName = "Qtr3"
        Me.colQtr3.Name = "colQtr3"
        Me.colQtr3.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtr3", "{0:$#,###.##}")})
        Me.colQtr3.Visible = True
        Me.colQtr3.VisibleIndex = 15
        Me.colQtr3.Width = 70
        '
        'colOct
        '
        Me.colOct.AppearanceHeader.Options.UseTextOptions = True
        Me.colOct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOct.DisplayFormat.FormatString = "c2"
        Me.colOct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colOct.FieldName = "Oct"
        Me.colOct.Name = "colOct"
        Me.colOct.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Oct", "{0:$#,###.##}")})
        Me.colOct.Visible = True
        Me.colOct.VisibleIndex = 16
        Me.colOct.Width = 64
        '
        'colNov
        '
        Me.colNov.AppearanceHeader.Options.UseTextOptions = True
        Me.colNov.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNov.DisplayFormat.FormatString = "c2"
        Me.colNov.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNov.FieldName = "Nov"
        Me.colNov.Name = "colNov"
        Me.colNov.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Nov", "{0:$#,###.##}")})
        Me.colNov.Visible = True
        Me.colNov.VisibleIndex = 17
        Me.colNov.Width = 64
        '
        'colDec
        '
        Me.colDec.AppearanceHeader.Options.UseTextOptions = True
        Me.colDec.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDec.DisplayFormat.FormatString = "c2"
        Me.colDec.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colDec.FieldName = "Dec"
        Me.colDec.Name = "colDec"
        Me.colDec.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Dec", "{0:$#,###.##}")})
        Me.colDec.Visible = True
        Me.colDec.VisibleIndex = 18
        Me.colDec.Width = 64
        '
        'colQtr4
        '
        Me.colQtr4.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colQtr4.AppearanceCell.Options.UseBackColor = True
        Me.colQtr4.AppearanceHeader.Options.UseTextOptions = True
        Me.colQtr4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colQtr4.DisplayFormat.FormatString = "c2"
        Me.colQtr4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtr4.FieldName = "Qtr4"
        Me.colQtr4.Name = "colQtr4"
        Me.colQtr4.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qtr4", "{0:$#,###.##}")})
        Me.colQtr4.Visible = True
        Me.colQtr4.VisibleIndex = 19
        Me.colQtr4.Width = 70
        '
        'colYtd
        '
        Me.colYtd.AppearanceCell.BackColor = System.Drawing.SystemColors.ControlLight
        Me.colYtd.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colYtd.AppearanceCell.Options.UseBackColor = True
        Me.colYtd.AppearanceCell.Options.UseFont = True
        Me.colYtd.AppearanceHeader.Options.UseTextOptions = True
        Me.colYtd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colYtd.Caption = "YTD"
        Me.colYtd.DisplayFormat.FormatString = "c2"
        Me.colYtd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colYtd.FieldName = "Ytd"
        Me.colYtd.Name = "colYtd"
        Me.colYtd.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Ytd", "{0:$#,###.##}")})
        Me.colYtd.Visible = True
        Me.colYtd.VisibleIndex = 20
        Me.colYtd.Width = 95
        '
        'gcCustomerAnalysis
        '
        Me.gcCustomerAnalysis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCustomerAnalysis.Location = New System.Drawing.Point(0, 0)
        Me.gcCustomerAnalysis.Name = "gcCustomerAnalysis"
        Me.gcCustomerAnalysis.Size = New System.Drawing.Size(1482, 566)
        Me.gcCustomerAnalysis.TabIndex = 1
        Me.gcCustomerAnalysis.Text = "Customer Analysis"
        '
        'gcCompanyAnalysis
        '
        Me.gcCompanyAnalysis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCompanyAnalysis.Location = New System.Drawing.Point(0, 0)
        Me.gcCompanyAnalysis.Name = "gcCompanyAnalysis"
        Me.gcCompanyAnalysis.Size = New System.Drawing.Size(1482, 566)
        Me.gcCompanyAnalysis.TabIndex = 2
        Me.gcCompanyAnalysis.Text = "Company Analysis"
        '
        'RibbonPanelControl7
        '
        Me.RibbonPanelControl7.Controls.Add(Me.GroupControl6)
        Me.RibbonPanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl7.Name = "RibbonPanelControl7"
        Me.RibbonPanelControl7.Size = New System.Drawing.Size(1482, 566)
        Me.RibbonPanelControl7.TabIndex = 1
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.GroupControl8)
        Me.GroupControl6.Controls.Add(Me.GroupControl7)
        Me.GroupControl6.Controls.Add(Me.PanelControl4)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl6.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(1478, 562)
        Me.GroupControl6.TabIndex = 2
        Me.GroupControl6.Text = "Customer Payments"
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.GridControl2)
        Me.GroupControl8.Location = New System.Drawing.Point(465, 51)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(240, 138)
        Me.GroupControl8.TabIndex = 3
        Me.GroupControl8.Text = "Invoices Paid with Selected Payment"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsInvoicePayments
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 20)
        Me.GridControl2.LookAndFeel.SkinName = "Money Twins"
        Me.GridControl2.MainView = Me.GridView10
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit8})
        Me.GridControl2.Size = New System.Drawing.Size(236, 116)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10})
        '
        'bsInvoicePayments
        '
        Me.bsInvoicePayments.DataSource = GetType(AOS.BusinessObjects.InvoicepaymentCollection)
        Me.bsInvoicePayments.Sort = ""
        '
        'GridView10
        '
        Me.GridView10.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView10.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView10.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView10.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView10.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView10.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView10.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView10.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView10.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView10.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView10.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView10.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView10.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView10.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView10.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView10.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView10.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView10.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView10.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView10.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView10.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView10.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView10.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView10.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView10.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView10.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView10.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView10.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView10.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView10.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView10.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoicenumber2, Me.colInvoicepmtamount})
        Me.GridView10.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView10.GridControl = Me.GridControl2
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsBehavior.Editable = False
        Me.GridView10.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView10.OptionsView.ShowGroupPanel = False
        Me.GridView10.OptionsView.ShowIndicator = False
        '
        'colInvoicenumber2
        '
        Me.colInvoicenumber2.Caption = "Invoice #"
        Me.colInvoicenumber2.FieldName = "Invoicenumber"
        Me.colInvoicenumber2.Name = "colInvoicenumber2"
        Me.colInvoicenumber2.Visible = True
        Me.colInvoicenumber2.VisibleIndex = 0
        '
        'colInvoicepmtamount
        '
        Me.colInvoicepmtamount.Caption = "Inv Pmt Amount"
        Me.colInvoicepmtamount.DisplayFormat.FormatString = "c2"
        Me.colInvoicepmtamount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colInvoicepmtamount.FieldName = "Invoicepmtamount"
        Me.colInvoicepmtamount.Name = "colInvoicepmtamount"
        Me.colInvoicepmtamount.Visible = True
        Me.colInvoicepmtamount.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit8
        '
        Me.RepositoryItemLookUpEdit8.AutoHeight = False
        Me.RepositoryItemLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit8.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit8.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit8.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit8.Name = "RepositoryItemLookUpEdit8"
        Me.RepositoryItemLookUpEdit8.NullText = ""
        Me.RepositoryItemLookUpEdit8.ReadOnly = True
        Me.RepositoryItemLookUpEdit8.ShowFooter = False
        Me.RepositoryItemLookUpEdit8.ShowHeader = False
        Me.RepositoryItemLookUpEdit8.ValueMember = "Productid"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.GridControl1)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl7.Location = New System.Drawing.Point(2, 51)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(457, 509)
        Me.GroupControl7.TabIndex = 2
        Me.GroupControl7.Text = "Customer Payment List"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsCustomerPayments
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.LookAndFeel.SkinName = "Money Twins"
        Me.GridControl1.MainView = Me.GridView8
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit7})
        Me.GridControl1.Size = New System.Drawing.Size(453, 487)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'bsCustomerPayments
        '
        Me.bsCustomerPayments.DataSource = GetType(AOS.BusinessObjects.CustomerpaymentCollection)
        Me.bsCustomerPayments.Sort = ""
        '
        'GridView8
        '
        Me.GridView8.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView8.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView8.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView8.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView8.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView8.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView8.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView8.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView8.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView8.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView8.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView8.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView8.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView8.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView8.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView8.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView8.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView8.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView8.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView8.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView8.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView8.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView8.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView8.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView8.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView8.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView8.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView8.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPaymentdate, Me.colPaymentamount, Me.colRemittanceadvice})
        Me.GridView8.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView8.GridControl = Me.GridControl1
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsBehavior.Editable = False
        Me.GridView8.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'colPaymentdate
        '
        Me.colPaymentdate.Caption = "Pmt Date"
        Me.colPaymentdate.DisplayFormat.FormatString = "d"
        Me.colPaymentdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPaymentdate.FieldName = "Paymentdate"
        Me.colPaymentdate.Name = "colPaymentdate"
        Me.colPaymentdate.Visible = True
        Me.colPaymentdate.VisibleIndex = 0
        Me.colPaymentdate.Width = 81
        '
        'colPaymentamount
        '
        Me.colPaymentamount.Caption = "Pmt Amount"
        Me.colPaymentamount.DisplayFormat.FormatString = "c2"
        Me.colPaymentamount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPaymentamount.FieldName = "Paymentamount"
        Me.colPaymentamount.Name = "colPaymentamount"
        Me.colPaymentamount.Visible = True
        Me.colPaymentamount.VisibleIndex = 1
        Me.colPaymentamount.Width = 95
        '
        'colRemittanceadvice
        '
        Me.colRemittanceadvice.Caption = "Remittance"
        Me.colRemittanceadvice.FieldName = "Remittanceadvice"
        Me.colRemittanceadvice.Name = "colRemittanceadvice"
        Me.colRemittanceadvice.Visible = True
        Me.colRemittanceadvice.VisibleIndex = 2
        Me.colRemittanceadvice.Width = 277
        '
        'RepositoryItemLookUpEdit7
        '
        Me.RepositoryItemLookUpEdit7.AutoHeight = False
        Me.RepositoryItemLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit7.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit7.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit7.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit7.Name = "RepositoryItemLookUpEdit7"
        Me.RepositoryItemLookUpEdit7.NullText = ""
        Me.RepositoryItemLookUpEdit7.ReadOnly = True
        Me.RepositoryItemLookUpEdit7.ShowFooter = False
        Me.RepositoryItemLookUpEdit7.ShowHeader = False
        Me.RepositoryItemLookUpEdit7.ValueMember = "Productid"
        '
        'PanelControl4
        '
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.LabelControl2)
        Me.PanelControl4.Controls.Add(Me.eCustomerLookup)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl4.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1474, 31)
        Me.PanelControl4.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(6, 9)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Select a Customer:"
        '
        'eCustomerLookup
        '
        Me.eCustomerLookup.Location = New System.Drawing.Point(107, 6)
        Me.eCustomerLookup.Name = "eCustomerLookup"
        Me.eCustomerLookup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eCustomerLookup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 200, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eCustomerLookup.Properties.DataSource = Me.bsCustomerList
        Me.eCustomerLookup.Properties.DisplayMember = "Custname"
        Me.eCustomerLookup.Properties.DropDownRows = 15
        Me.eCustomerLookup.Properties.NullText = ""
        Me.eCustomerLookup.Properties.PopupWidth = 450
        Me.eCustomerLookup.Properties.ValueMember = "Custid"
        Me.eCustomerLookup.Size = New System.Drawing.Size(350, 20)
        Me.eCustomerLookup.TabIndex = 0
        '
        'RibbonPanelControl6
        '
        Me.RibbonPanelControl6.Controls.Add(Me.GroupControl5)
        Me.RibbonPanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl6.Name = "RibbonPanelControl6"
        Me.RibbonPanelControl6.Size = New System.Drawing.Size(1482, 566)
        Me.RibbonPanelControl6.TabIndex = 1
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.grShipments)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1478, 562)
        Me.GroupControl5.TabIndex = 10
        Me.GroupControl5.Text = "Shipments"
        '
        'grShipments
        '
        Me.grShipments.DataSource = Me.bsShipments
        Me.grShipments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grShipments.Location = New System.Drawing.Point(2, 20)
        Me.grShipments.LookAndFeel.SkinName = "Money Twins"
        Me.grShipments.MainView = Me.GridView9
        Me.grShipments.Name = "grShipments"
        Me.grShipments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit5})
        Me.grShipments.Size = New System.Drawing.Size(1474, 540)
        Me.grShipments.TabIndex = 0
        Me.grShipments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'bsShipments
        '
        Me.bsShipments.DataSource = GetType(AOS.BusinessObjects.ShipmentCollection)
        '
        'GridView9
        '
        Me.GridView9.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView9.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView9.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView9.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView9.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView9.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView9.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView9.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView9.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView9.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView9.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView9.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView9.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView9.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView9.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView9.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView9.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView9.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView9.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView9.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView9.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView9.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView9.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView9.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView9.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView9.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView9.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView9.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView9.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView9.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView9.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colShipmentnumber, Me.colShipmentdate, Me.colCustid5, Me.colCustomerpo, Me.colShipmentstatus})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView9.GridControl = Me.grShipments
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsBehavior.Editable = False
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.OptionsView.ShowIndicator = False
        '
        'colShipmentnumber
        '
        Me.colShipmentnumber.Caption = "Shipment#"
        Me.colShipmentnumber.FieldName = "Shipmentnumber"
        Me.colShipmentnumber.Name = "colShipmentnumber"
        Me.colShipmentnumber.Visible = True
        Me.colShipmentnumber.VisibleIndex = 0
        Me.colShipmentnumber.Width = 91
        '
        'colShipmentdate
        '
        Me.colShipmentdate.Caption = "Ship Date"
        Me.colShipmentdate.DisplayFormat.FormatString = "d"
        Me.colShipmentdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colShipmentdate.FieldName = "Shipmentdate"
        Me.colShipmentdate.Name = "colShipmentdate"
        Me.colShipmentdate.Visible = True
        Me.colShipmentdate.VisibleIndex = 1
        Me.colShipmentdate.Width = 113
        '
        'colCustid5
        '
        Me.colCustid5.Caption = "Customer"
        Me.colCustid5.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.colCustid5.FieldName = "Custid"
        Me.colCustid5.Name = "colCustid5"
        Me.colCustid5.Visible = True
        Me.colCustid5.VisibleIndex = 2
        Me.colCustid5.Width = 274
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DataSource = Me.bsCustomerList
        Me.RepositoryItemLookUpEdit5.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ReadOnly = True
        Me.RepositoryItemLookUpEdit5.ValueMember = "Custid"
        '
        'colCustomerpo
        '
        Me.colCustomerpo.Caption = "Customer PO"
        Me.colCustomerpo.FieldName = "Customerpo"
        Me.colCustomerpo.Name = "colCustomerpo"
        Me.colCustomerpo.Visible = True
        Me.colCustomerpo.VisibleIndex = 3
        Me.colCustomerpo.Width = 205
        '
        'colShipmentstatus
        '
        Me.colShipmentstatus.Caption = "Status"
        Me.colShipmentstatus.FieldName = "Shipmentstatus"
        Me.colShipmentstatus.Name = "colShipmentstatus"
        Me.colShipmentstatus.Visible = True
        Me.colShipmentstatus.VisibleIndex = 4
        Me.colShipmentstatus.Width = 216
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.bsCustomerList
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ReadOnly = True
        Me.RepositoryItemLookUpEdit3.ValueMember = "Custid"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'bsTrendsMonthly
        '
        Me.bsTrendsMonthly.DataSource = GetType(AOS.BusinessObjects.ViewCustomerTrendAnalysisMonthlyCollection)
        '
        'bsTrendsQuarterly
        '
        Me.bsTrendsQuarterly.DataSource = GetType(AOS.BusinessObjects.ViewCustomerTrendAnalysisQuarterlyCollection)
        '
        'bsTrendsAnnually
        '
        Me.bsTrendsAnnually.DataSource = GetType(AOS.BusinessObjects.ViewCustomerTrendAnalysisAnnuallyCollection)
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 15000
        '
        'viewSalesCustomers
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.Name = "viewSalesCustomers"
        Me.Size = New System.Drawing.Size(1482, 715)
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalesperson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomerSelector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalesPersonList3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalesYears, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomerLookupList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonLargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl5.ResumeLayout(False)
        Me.RibbonPanelControl5.PerformLayout()
        CType(Me.grpCommissions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCommissions.ResumeLayout(False)
        CType(Me.grCommissions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCommissions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCommissions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerLookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit5.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlSalesTop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSalesTop.ResumeLayout(False)
        CType(Me.grpCustomerAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCustomerAssignments.ResumeLayout(False)
        CType(Me.grAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grSalesperson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.grpCommissionData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCommissionData.ResumeLayout(False)
        CType(Me.grCommissionData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCommissionData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl10.ResumeLayout(False)
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        CType(Me.grSalesHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalesHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridViewSalesHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.gcPriceLists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcPriceLists.ResumeLayout(False)
        CType(Me.grPriceLists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPriceLists, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewPriceList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLookupEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.luCustomerList.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.GroupControl15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl15.ResumeLayout(False)
        Me.GroupControl15.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustfaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl14.ResumeLayout(False)
        Me.GroupControl14.PerformLayout()
        CType(Me.MemoEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustnotesMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl13.ResumeLayout(False)
        Me.GroupControl13.PerformLayout()
        CType(Me.FreightoninvoiceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FreightbillcustomerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FobTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulkcarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBulkCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticsidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl12.ResumeLayout(False)
        Me.GroupControl12.PerformLayout()
        CType(Me.CustbillcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Custbilladdress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustbillpostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Custbilladdress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustbillcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustbillstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustbillcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl11.ResumeLayout(False)
        Me.GroupControl11.PerformLayout()
        CType(Me.Custshipaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Custshipaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshipcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshipstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshippostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshipcountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustshipcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl10.ResumeLayout(False)
        Me.GroupControl10.PerformLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalespersonIDLookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalesPersonList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalespersonidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalespersonList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl4.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvoices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvInvoiceList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl9.ResumeLayout(False)
        CType(Me.gcSalesByCustomerAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcSalesByCustomerAnalysis.ResumeLayout(False)
        CType(Me.grcSalesByCustomerAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalesByCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvSalesByCustomerAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcSalesAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcSalesAnalysis.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSalesData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvSalesAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCustomerAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCompanyAnalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl7.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvoicePayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomerPayments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        Me.PanelControl4.PerformLayout()
        CType(Me.eCustomerLookup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl6.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.grShipments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShipments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTrendsMonthly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTrendsQuarterly, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTrendsAnnually, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grCustomers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As CustomDevExGridView
    Friend WithEvents colCustid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAddSalesperson As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditSalesperson As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteSalesperson As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grSalesperson As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsSalesperson As System.Windows.Forms.BindingSource
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents colSalespersonfirstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalespersonlastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsCustomerList As System.Windows.Forms.BindingSource
    Friend WithEvents bsPriceLists As System.Windows.Forms.BindingSource
    Friend WithEvents gcPriceLists As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grPriceLists As DevExpress.XtraGrid.GridControl
    Friend WithEvents viewPriceList As CustomDevExGridView
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPricemethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainerprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEffectivedate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ProductLookupEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents btnAddPriceListItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPriceListItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeletePriceListItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents luCustomerList As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpCustomerAssignments As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grAssignments As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As CustomDevExGridView
    Friend WithEvents bsCommissions As System.Windows.Forms.BindingSource
    Friend WithEvents bsAssignments As System.Windows.Forms.BindingSource
    Friend WithEvents colCustID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommissionType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommissionRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnAddAssignment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditAssignment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteAssignment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents grpCommissions As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grCommissions As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCommissions As CustomDevExGridView
    Friend WithEvents CustomerLookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents pnlSalesTop As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage20 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAddCommission As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCommission As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCommission As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grInvoices As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvInvoiceList As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsInvoices As System.Windows.Forms.BindingSource
    Friend WithEvents btnAddInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage7 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnRefreshCompleteShipments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCreateInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grShipments As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsShipments As System.Windows.Forms.BindingSource
    Friend WithEvents colShipmentnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustid5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerpo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicenumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicedate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustid4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalestax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicestatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnFilterPending As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFilterReceivable As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFilterPaid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFilterVoid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFilterAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddCommissionPmt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCommissionFilterPending As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCommissionFilterPayable As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCommissionFilterPaid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintCommForecast As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintCommPayable As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintPaidCommissionsRpt As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCommissionTypes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCommissionBalancesDue As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rpgFilter As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage8 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents colCommissiondate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustid3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommissionamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommissionstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommissiondesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommissiontype1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatecustomerpaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatecommissionpaid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCommissionnote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrintInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup14 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnPrintPriceList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup17 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCloseShipment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnConvertWorkOrderToInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RibbonPageGroup18 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnTransferInvoicesToQuickbooks As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintCustomerPaymentHistory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eCustomerLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsCustomerPayments As System.Windows.Forms.BindingSource
    Friend WithEvents colPaymentdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPaymentamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRemittanceadvice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnAddCustomerPayment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCustomerPayment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCustomerPayment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsInvoicePayments As System.Windows.Forms.BindingSource
    Friend WithEvents GridView10 As CustomDevExGridView
    Friend WithEvents colInvoicenumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicepmtamount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnExportToXLS As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnMarkPayable As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMarkPaid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMarkPending As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintCommPmtRegister As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnPrintCustomerPmtByDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup19 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPageGroup21 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup22 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup23 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnManageCustomerAssignments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnManageSalespersonData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents luActiveSalesPerson As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RibbonPageGroup24 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnAddCommissionRec As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCommissionRec As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCommissionRec As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFetchForecastedCommissions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFetchPayableCommissions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintForecastedCommissions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintPayableCommissions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup20 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnManageCommissionPayments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMarkCommissionForecasted As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMarkCommissionPayable As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMarkCommissionPaid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grpCommissionData As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grCommissionData As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCommissionData As CustomDevExGridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnPrintCommissionsByCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage10 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup25 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grSalesHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridViewSalesHistory As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsSalesHistory As System.Windows.Forms.BindingSource
    Friend WithEvents colCustid6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicenumber3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicedate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eHistoryStart As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents eHistoryEnd As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents eCustomerSelector As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents eFetchSalesHistoryData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsCustomerSelector As System.Windows.Forms.BindingSource
    Friend WithEvents btnExportSalesHistoryData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup26 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colCommissionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnUpdateCustomers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eProductLookup As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents eProductStart As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents eProductEnd As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rbtnGetProductSales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup27 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnPrintCustomerProductList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CustshippostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custshipaddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custshipaddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustnameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custbilladdress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custbilladdress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipcountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl12 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CustbillcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillpostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillcountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl11 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents IsactiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CustphoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustfaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LogisticsidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CarrieridLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BulkcarrieridLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FobTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsBulkCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl13 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl14 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CustnotesMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents bsSalespersonList As System.Windows.Forms.BindingSource
    Friend WithEvents SalespersonidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FreightoninvoiceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FreightbillcustomerCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents GroupControl15 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents printInvoiceHistoryReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents SalespersonIDLookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsSalesPersonList2 As System.Windows.Forms.BindingSource
    Friend WithEvents rluSalesperson As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rbtnGetSalesAnalysisData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnExportSalesDataToExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonLargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPage9 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup15 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup16 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcCustomerAnalysis As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcSalesAnalysis As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsSalesPersonList3 As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsSalesData As System.Windows.Forms.BindingSource
    Friend WithEvents grvSalesAnalysis As CustomDevExGridView
    Friend WithEvents colCustid7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSName2 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents gcCompanyAnalysis As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rluSalesYear As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsSalesYears As System.Windows.Forms.BindingSource
    Friend WithEvents bsCustomerLookupList As System.Windows.Forms.BindingSource
    Friend WithEvents bsTrendsMonthly As System.Windows.Forms.BindingSource
    Friend WithEvents bsTrendsQuarterly As System.Windows.Forms.BindingSource
    Friend WithEvents bsTrendsAnnually As System.Windows.Forms.BindingSource
    Friend WithEvents rluCustomer As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit18 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCompileTrendData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnMonthlySalesAnalysis As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup28 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colPriceliststatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnFilterPriceListActive As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnFilterPriceListInActive As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup29 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnViewPrintSDSDocument As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rbtnFilterSalesACTIVE As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnFilterSalesINACTIVE As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup30 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnPrintCommByCustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCommissionid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnCommissonAuditReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eInvPaidThruDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rbtnFilterPayableCommByDate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnFilterPayableCommAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem4 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rbtnMiscMarkPayableAsPaid As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colVariance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnMarkCommissionAsAudited As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup31 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup32 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colAuditflag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPageGroup33 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnRptCommWithExceptions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnRptPayableWithExceptions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintCommPmtRegisterWithExceptions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcSalesByCustomerAnalysis As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grcSalesByCustomerAnalysis As DevExpress.XtraGrid.GridControl
    Friend grvSalesByCustomerAnalysis As CustomDevExGridView
    Friend WithEvents colCustId_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustName_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalesRepName_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYear_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJAN_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFEB_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAR_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr1_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAPR_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMAY_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJUN_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr2_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colJUL_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAUG_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSEP_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr3_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOCT_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOV_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDEC_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtr4_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colYTD_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevYear_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevJAN_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevFEB_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevMAR_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevQtr1_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevAPR_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevMAY_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevJUN_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevQtr2_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevJUL_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevAUG_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevSEP_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevQtr3_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevOCT_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevNOV_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevDEC_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevQtr4_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrevTotal_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsSalesByCustomer As BindingSource
    Friend WithEvents colSalesName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnGetSalesAnalysisByCustomerData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnExportSalesByCustomerAnalysisToExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnGetSalesPersonAnalysis As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnExportSalesPersonAnalysisToExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnGetAllCustomersSales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnWorkOrdersToInvoice As DevExpress.XtraBars.BarButtonItem
End Class
