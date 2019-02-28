<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewFreightDashboard

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
        Dim CustemailLabel As System.Windows.Forms.Label
        Dim CustphoneLabel As System.Windows.Forms.Label
        Dim CustfaxLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim CustnotesLabel As System.Windows.Forms.Label
        Dim FreightoninvoiceLabel As System.Windows.Forms.Label
        Dim FreightbillcustomerLabel As System.Windows.Forms.Label
        Dim FobLabel As System.Windows.Forms.Label
        Dim CarrieridLabel As System.Windows.Forms.Label
        Dim LogisticsidLabel As System.Windows.Forms.Label
        Dim BulkcarrieridLabel As System.Windows.Forms.Label
        Dim Custbilladdress1Label As System.Windows.Forms.Label
        Dim CustbillpostalcodeLabel As System.Windows.Forms.Label
        Dim CustbillstateprovLabel As System.Windows.Forms.Label
        Dim Custbilladdress2Label As System.Windows.Forms.Label
        Dim CustbillcityLabel As System.Windows.Forms.Label
        Dim Custshipaddress1Label As System.Windows.Forms.Label
        Dim Custshipaddress2Label As System.Windows.Forms.Label
        Dim CustshipcityLabel As System.Windows.Forms.Label
        Dim CustshipstateprovLabel As System.Windows.Forms.Label
        Dim CustshippostalcodeLabel As System.Windows.Forms.Label
        Dim SalespersonidLabel As System.Windows.Forms.Label
        Dim IsactiveLabel As System.Windows.Forms.Label
        Dim CustidLabel As System.Windows.Forms.Label
        Dim CustnameLabel As System.Windows.Forms.Label
        Dim FreezeWarningLabel As System.Windows.Forms.Label
        Dim MaxLoadWeightLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewFreightDashboard))
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.grHeader = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.rbtnPendingAddLoad = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPendingEditLoad = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrievePendingLoads = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPendingMarkAsCancelled = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMergeLoads = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrieveScheduledLoads = New DevExpress.XtraBars.BarButtonItem()
        Me.rtbnScheduledLoadEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintBOL = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnScheduledMarkAsPending = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnScheduledMarkAsInTransit = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnScheduledMarkAsCancelled = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrieveInTransitLoads = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnInTransitMarkAsReturned = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrieveDeliveredLoads = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReprintBOL = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeliveredMarkAsInTransit = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrieveCancelledLoads = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrieveCustomers = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrieveCarriers = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewCarrier = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditCarrier = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteCarrier = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrieveLogisiticsProviders = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewLogisticsProvider = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditLogisticsProvider = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteLogisticsProvider = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditFreightSettings = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnInTransitMarkAsDelivered = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnProcessLoad = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintRptFutureShipments = New DevExpress.XtraBars.BarButtonItem()
        Me.eHistoryStart = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.eHistoryEnd = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.eCustomerSelector = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsCustomers2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.rBtnFetchShipmentHistory = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnExportHistory = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup14 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup16 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup15 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage8 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage6 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup26 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage7 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grPendingLoads = New DevExpress.XtraGrid.GridControl()
        Me.bsPendingLoads = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPendingLoads = New AOS.CustomClasses.CustomDevExGridView()
        Me.colLoadID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedDepartureDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPallets = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSkids = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrossWt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWONumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFreezeprotectflag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrSoonerFlag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New AOS.CustomClasses.CustomDevExGridView()
        Me.pnlColorMapping = New DevExpress.XtraEditors.PanelControl()
        Me.lblRedDesc = New DevExpress.XtraEditors.LabelControl()
        Me.lblRedColor = New DevExpress.XtraEditors.ColorEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ColorEdit4 = New DevExpress.XtraEditors.ColorEdit()
        Me.ColorEdit3 = New DevExpress.XtraEditors.ColorEdit()
        Me.ColorEdit2 = New DevExpress.XtraEditors.ColorEdit()
        Me.ColorEdit1 = New DevExpress.XtraEditors.ColorEdit()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.grCancelledLoads = New DevExpress.XtraGrid.GridControl()
        Me.bsCancelledLoads = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView9 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSkids4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn68 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn75 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView10 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grScheduledLoads = New DevExpress.XtraGrid.GridControl()
        Me.bsScheduledLoads = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSkids3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn72 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grInTransitLoads = New DevExpress.XtraGrid.GridControl()
        Me.bsInTransitLoads = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn73 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSkids2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView6 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonPanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsCustomerShipmentHistory = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvCustomerShipmentHistory = New AOS.CustomClasses.CustomDevExGridView()
        Me.colCustid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrdertype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualShipmentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedDeliveryDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadType1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.CustomDevExGridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.grDeliveredLoads = New DevExpress.XtraGrid.GridControl()
        Me.bsDeliveredLoads = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn76 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSkids1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn74 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView8 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonPanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.MaxLoadWeightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsParms = New System.Windows.Forms.BindingSource(Me.components)
        Me.eFreeze = New DevExpress.XtraEditors.CheckEdit()
        Me.RibbonPanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.gcCarriers = New DevExpress.XtraEditors.GroupControl()
        Me.dgvCarrier = New DevExpress.XtraGrid.GridControl()
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView12 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn69 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn70 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierContactName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTermsCarrier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView13 = New AOS.CustomClasses.CustomDevExGridView()
        Me.gcLogisticsProviders = New DevExpress.XtraEditors.GroupControl()
        Me.dgLogistics = New DevExpress.XtraGrid.GridControl()
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView14 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colLogisticsid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsaddr1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsaddr2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticscity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsstate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticszip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticscontact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView15 = New AOS.CustomClasses.CustomDevExGridView()
        Me.gcCustomers = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl15 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.FobTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.BulkcarrieridLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LogisticsidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
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
        Me.SalespersonidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.CustidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.IsactiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.CustnameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.grCustomers = New DevExpress.XtraGrid.GridControl()
        Me.GridView11 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colCustid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_RefreshData = New System.Windows.Forms.Timer(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CustemailLabel = New System.Windows.Forms.Label()
        CustphoneLabel = New System.Windows.Forms.Label()
        CustfaxLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CustnotesLabel = New System.Windows.Forms.Label()
        FreightoninvoiceLabel = New System.Windows.Forms.Label()
        FreightbillcustomerLabel = New System.Windows.Forms.Label()
        FobLabel = New System.Windows.Forms.Label()
        CarrieridLabel = New System.Windows.Forms.Label()
        LogisticsidLabel = New System.Windows.Forms.Label()
        BulkcarrieridLabel = New System.Windows.Forms.Label()
        Custbilladdress1Label = New System.Windows.Forms.Label()
        CustbillpostalcodeLabel = New System.Windows.Forms.Label()
        CustbillstateprovLabel = New System.Windows.Forms.Label()
        Custbilladdress2Label = New System.Windows.Forms.Label()
        CustbillcityLabel = New System.Windows.Forms.Label()
        Custshipaddress1Label = New System.Windows.Forms.Label()
        Custshipaddress2Label = New System.Windows.Forms.Label()
        CustshipcityLabel = New System.Windows.Forms.Label()
        CustshipstateprovLabel = New System.Windows.Forms.Label()
        CustshippostalcodeLabel = New System.Windows.Forms.Label()
        SalespersonidLabel = New System.Windows.Forms.Label()
        IsactiveLabel = New System.Windows.Forms.Label()
        CustidLabel = New System.Windows.Forms.Label()
        CustnameLabel = New System.Windows.Forms.Label()
        FreezeWarningLabel = New System.Windows.Forms.Label()
        MaxLoadWeightLabel = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grPendingLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPendingLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPendingLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlColorMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlColorMapping.SuspendLayout()
        CType(Me.lblRedColor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl5.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.grCancelledLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCancelledLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grScheduledLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsScheduledLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grInTransitLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInTransitLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl8.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomerShipmentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCustomerShipmentHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDevExGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl4.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.grDeliveredLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDeliveredLoads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl7.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.MaxLoadWeightTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsParms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFreeze.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl6.SuspendLayout()
        CType(Me.gcCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcCarriers.SuspendLayout()
        CType(Me.dgvCarrier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcLogisticsProviders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcLogisticsProviders.SuspendLayout()
        CType(Me.dgLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcCustomers.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.GroupControl15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl15.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.FobTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BulkcarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogisticsidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.SalespersonidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.grCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(10, 187)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(42, 13)
        Label3.TabIndex = 55
        Label3.Text = "Invoice"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(10, 135)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(51, 13)
        Label2.TabIndex = 54
        Label2.Text = "Shipment"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(9, 83)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(63, 13)
        Label1.TabIndex = 53
        Label1.Text = "Work Order"
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
        'FreightoninvoiceLabel
        '
        FreightoninvoiceLabel.AutoSize = True
        FreightoninvoiceLabel.Location = New System.Drawing.Point(229, 81)
        FreightoninvoiceLabel.Name = "FreightoninvoiceLabel"
        FreightoninvoiceLabel.Size = New System.Drawing.Size(94, 13)
        FreightoninvoiceLabel.TabIndex = 47
        FreightoninvoiceLabel.Text = "Freight on Invoice"
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
        'FobLabel
        '
        FobLabel.AutoSize = True
        FobLabel.Location = New System.Drawing.Point(9, 27)
        FobLabel.Name = "FobLabel"
        FobLabel.Size = New System.Drawing.Size(67, 13)
        FobLabel.TabIndex = 45
        FobLabel.Text = "Freight Chrg"
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
        'Custbilladdress1Label
        '
        Custbilladdress1Label.AutoSize = True
        Custbilladdress1Label.Location = New System.Drawing.Point(9, 27)
        Custbilladdress1Label.Name = "Custbilladdress1Label"
        Custbilladdress1Label.Size = New System.Drawing.Size(55, 13)
        Custbilladdress1Label.TabIndex = 18
        Custbilladdress1Label.Text = "Address 1"
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
        'CustbillstateprovLabel
        '
        CustbillstateprovLabel.AutoSize = True
        CustbillstateprovLabel.Location = New System.Drawing.Point(9, 105)
        CustbillstateprovLabel.Name = "CustbillstateprovLabel"
        CustbillstateprovLabel.Size = New System.Drawing.Size(46, 13)
        CustbillstateprovLabel.TabIndex = 24
        CustbillstateprovLabel.Text = "Country"
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
        'SalespersonidLabel
        '
        SalespersonidLabel.AutoSize = True
        SalespersonidLabel.Location = New System.Drawing.Point(555, 26)
        SalespersonidLabel.Name = "SalespersonidLabel"
        SalespersonidLabel.Size = New System.Drawing.Size(32, 13)
        SalespersonidLabel.TabIndex = 48
        SalespersonidLabel.Text = "Sales"
        '
        'IsactiveLabel
        '
        IsactiveLabel.AutoSize = True
        IsactiveLabel.Location = New System.Drawing.Point(673, 4)
        IsactiveLabel.Name = "IsactiveLabel"
        IsactiveLabel.Size = New System.Drawing.Size(37, 13)
        IsactiveLabel.TabIndex = 43
        IsactiveLabel.Text = "Active"
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
        'FreezeWarningLabel
        '
        FreezeWarningLabel.AutoSize = True
        FreezeWarningLabel.Location = New System.Drawing.Point(18, 39)
        FreezeWarningLabel.Name = "FreezeWarningLabel"
        FreezeWarningLabel.Size = New System.Drawing.Size(87, 13)
        FreezeWarningLabel.TabIndex = 0
        FreezeWarningLabel.Text = "Freeze Warning:"
        '
        'MaxLoadWeightLabel
        '
        MaxLoadWeightLabel.AutoSize = True
        MaxLoadWeightLabel.Location = New System.Drawing.Point(11, 64)
        MaxLoadWeightLabel.Name = "MaxLoadWeightLabel"
        MaxLoadWeightLabel.Size = New System.Drawing.Size(94, 13)
        MaxLoadWeightLabel.TabIndex = 2
        MaxLoadWeightLabel.Text = "Max Load Weight:"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
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
        Me.FormCaption.MainView = Me.grHeader
        Me.FormCaption.Name = "FormCaption"
        Me.FormCaption.Size = New System.Drawing.Size(1268, 33)
        Me.FormCaption.TabIndex = 3
        Me.FormCaption.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grHeader})
        '
        'grHeader
        '
        Me.grHeader.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.grHeader.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grHeader.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.grHeader.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grHeader.GridControl = Me.FormCaption
        Me.grHeader.GroupPanelText = "FREIGHT DASHBOARD"
        Me.grHeader.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.grHeader.Name = "grHeader"
        Me.grHeader.OptionsBehavior.SmartVertScrollBar = False
        Me.grHeader.OptionsCustomization.AllowFilter = False
        Me.grHeader.OptionsCustomization.AllowGroup = False
        Me.grHeader.OptionsCustomization.AllowSort = False
        Me.grHeader.OptionsMenu.EnableColumnMenu = False
        Me.grHeader.OptionsView.ShowColumnHeaders = False
        Me.grHeader.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.grHeader.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ApplicationCaption = "dsadsdsa"
        Me.RibbonControl1.ApplicationDocumentCaption = "dsdsadsa"
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Images = Me.ImageCollection1
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnPendingAddLoad, Me.btnPendingEditLoad, Me.rbtnRetrievePendingLoads, Me.rbtnPendingMarkAsCancelled, Me.rbtnMergeLoads, Me.rbtnRetrieveScheduledLoads, Me.rtbnScheduledLoadEdit, Me.rbtnPrintBOL, Me.rbtnScheduledMarkAsPending, Me.rbtnScheduledMarkAsInTransit, Me.rbtnScheduledMarkAsCancelled, Me.rbtnRetrieveInTransitLoads, Me.rbtnInTransitMarkAsReturned, Me.rbtnRetrieveDeliveredLoads, Me.rbtnReprintBOL, Me.rbtnDeliveredMarkAsInTransit, Me.rbtnRetrieveCancelledLoads, Me.rbtnRetrieveCustomers, Me.rbtnRetrieveCarriers, Me.rbtnAddNewCarrier, Me.rbtnEditCarrier, Me.rbtnDeleteCarrier, Me.rbtnRetrieveLogisiticsProviders, Me.rbtnAddNewLogisticsProvider, Me.rbtnEditLogisticsProvider, Me.rbtnDeleteLogisticsProvider, Me.rbtnEditFreightSettings, Me.rbtnInTransitMarkAsDelivered, Me.rbtnProcessLoad, Me.rbtnPrintRptFutureShipments, Me.eHistoryStart, Me.eHistoryEnd, Me.eCustomerSelector, Me.rBtnFetchShipmentHistory, Me.rbtnExportHistory})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 93
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4, Me.RibbonPage5, Me.RibbonPage8, Me.RibbonPage6, Me.RibbonPage7})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemLookUpEdit6})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1268, 116)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'rbtnPendingAddLoad
        '
        Me.rbtnPendingAddLoad.Caption = "Add New Load"
        Me.rbtnPendingAddLoad.Id = 41
        Me.rbtnPendingAddLoad.ImageOptions.Image = Global.AOS.My.Resources.Resources.NewRecord
        Me.rbtnPendingAddLoad.ImageOptions.LargeImageIndex = 2
        Me.rbtnPendingAddLoad.Name = "rbtnPendingAddLoad"
        Me.rbtnPendingAddLoad.Tag = "232"
        '
        'btnPendingEditLoad
        '
        Me.btnPendingEditLoad.Caption = "Edit Load"
        Me.btnPendingEditLoad.Id = 42
        Me.btnPendingEditLoad.ImageOptions.Image = Global.AOS.My.Resources.Resources.Edit
        Me.btnPendingEditLoad.ImageOptions.LargeImageIndex = 3
        Me.btnPendingEditLoad.Name = "btnPendingEditLoad"
        Me.btnPendingEditLoad.Tag = "233"
        '
        'rbtnRetrievePendingLoads
        '
        Me.rbtnRetrievePendingLoads.Caption = "Retrieve Pending Loads"
        Me.rbtnRetrievePendingLoads.Id = 51
        Me.rbtnRetrievePendingLoads.ImageOptions.LargeImageIndex = 1
        Me.rbtnRetrievePendingLoads.Name = "rbtnRetrievePendingLoads"
        Me.rbtnRetrievePendingLoads.Tag = "230"
        '
        'rbtnPendingMarkAsCancelled
        '
        Me.rbtnPendingMarkAsCancelled.Caption = "Mark As Cancelled"
        Me.rbtnPendingMarkAsCancelled.Id = 54
        Me.rbtnPendingMarkAsCancelled.ImageOptions.LargeImageIndex = 7
        Me.rbtnPendingMarkAsCancelled.Name = "rbtnPendingMarkAsCancelled"
        Me.rbtnPendingMarkAsCancelled.Tag = "235"
        '
        'rbtnMergeLoads
        '
        Me.rbtnMergeLoads.Caption = "Merge Loads"
        Me.rbtnMergeLoads.Id = 55
        Me.rbtnMergeLoads.ImageOptions.LargeImageIndex = 17
        Me.rbtnMergeLoads.Name = "rbtnMergeLoads"
        Me.rbtnMergeLoads.Tag = "234"
        '
        'rbtnRetrieveScheduledLoads
        '
        Me.rbtnRetrieveScheduledLoads.Caption = "Retrieve Scheduled Loads"
        Me.rbtnRetrieveScheduledLoads.Id = 57
        Me.rbtnRetrieveScheduledLoads.ImageOptions.LargeImageIndex = 1
        Me.rbtnRetrieveScheduledLoads.Name = "rbtnRetrieveScheduledLoads"
        Me.rbtnRetrieveScheduledLoads.Tag = "236"
        '
        'rtbnScheduledLoadEdit
        '
        Me.rtbnScheduledLoadEdit.Caption = "Edit Load"
        Me.rtbnScheduledLoadEdit.Id = 58
        Me.rtbnScheduledLoadEdit.ImageOptions.LargeImageIndex = 3
        Me.rtbnScheduledLoadEdit.Name = "rtbnScheduledLoadEdit"
        Me.rtbnScheduledLoadEdit.Tag = "237"
        '
        'rbtnPrintBOL
        '
        Me.rbtnPrintBOL.Caption = "Print Bill Of Lading"
        Me.rbtnPrintBOL.Id = 59
        Me.rbtnPrintBOL.ImageOptions.LargeImageIndex = 5
        Me.rbtnPrintBOL.Name = "rbtnPrintBOL"
        Me.rbtnPrintBOL.Tag = "238"
        '
        'rbtnScheduledMarkAsPending
        '
        Me.rbtnScheduledMarkAsPending.Caption = "Mark As Pending"
        Me.rbtnScheduledMarkAsPending.Id = 60
        Me.rbtnScheduledMarkAsPending.ImageOptions.LargeImageIndex = 14
        Me.rbtnScheduledMarkAsPending.Name = "rbtnScheduledMarkAsPending"
        Me.rbtnScheduledMarkAsPending.Tag = "239"
        '
        'rbtnScheduledMarkAsInTransit
        '
        Me.rbtnScheduledMarkAsInTransit.Caption = "Mark As  In Transit"
        Me.rbtnScheduledMarkAsInTransit.Id = 61
        Me.rbtnScheduledMarkAsInTransit.ImageOptions.LargeImageIndex = 18
        Me.rbtnScheduledMarkAsInTransit.Name = "rbtnScheduledMarkAsInTransit"
        Me.rbtnScheduledMarkAsInTransit.Tag = "241"
        '
        'rbtnScheduledMarkAsCancelled
        '
        Me.rbtnScheduledMarkAsCancelled.Caption = "Mark As Cancelled"
        Me.rbtnScheduledMarkAsCancelled.Id = 63
        Me.rbtnScheduledMarkAsCancelled.ImageOptions.LargeImageIndex = 7
        Me.rbtnScheduledMarkAsCancelled.Name = "rbtnScheduledMarkAsCancelled"
        Me.rbtnScheduledMarkAsCancelled.Tag = "242"
        '
        'rbtnRetrieveInTransitLoads
        '
        Me.rbtnRetrieveInTransitLoads.Caption = "Retrieve In Transit Loads"
        Me.rbtnRetrieveInTransitLoads.Id = 64
        Me.rbtnRetrieveInTransitLoads.ImageOptions.LargeImageIndex = 1
        Me.rbtnRetrieveInTransitLoads.Name = "rbtnRetrieveInTransitLoads"
        Me.rbtnRetrieveInTransitLoads.Tag = "243"
        '
        'rbtnInTransitMarkAsReturned
        '
        Me.rbtnInTransitMarkAsReturned.Caption = "Mark As Returned"
        Me.rbtnInTransitMarkAsReturned.Id = 67
        Me.rbtnInTransitMarkAsReturned.ImageOptions.LargeImageIndex = 19
        Me.rbtnInTransitMarkAsReturned.Name = "rbtnInTransitMarkAsReturned"
        Me.rbtnInTransitMarkAsReturned.Tag = "244"
        '
        'rbtnRetrieveDeliveredLoads
        '
        Me.rbtnRetrieveDeliveredLoads.Caption = "Retrieve Delivered Loads"
        Me.rbtnRetrieveDeliveredLoads.Id = 68
        Me.rbtnRetrieveDeliveredLoads.ImageOptions.LargeImageIndex = 1
        Me.rbtnRetrieveDeliveredLoads.Name = "rbtnRetrieveDeliveredLoads"
        Me.rbtnRetrieveDeliveredLoads.Tag = "246"
        '
        'rbtnReprintBOL
        '
        Me.rbtnReprintBOL.Caption = "Reprint Bill Of Lading"
        Me.rbtnReprintBOL.Id = 69
        Me.rbtnReprintBOL.ImageOptions.LargeImageIndex = 5
        Me.rbtnReprintBOL.Name = "rbtnReprintBOL"
        Me.rbtnReprintBOL.Tag = "247"
        '
        'rbtnDeliveredMarkAsInTransit
        '
        Me.rbtnDeliveredMarkAsInTransit.Caption = "Mark As In Transit"
        Me.rbtnDeliveredMarkAsInTransit.Id = 70
        Me.rbtnDeliveredMarkAsInTransit.ImageOptions.LargeImageIndex = 18
        Me.rbtnDeliveredMarkAsInTransit.Name = "rbtnDeliveredMarkAsInTransit"
        Me.rbtnDeliveredMarkAsInTransit.Tag = "248"
        '
        'rbtnRetrieveCancelledLoads
        '
        Me.rbtnRetrieveCancelledLoads.Caption = "Retrieve Returned/ Cancelled Loads"
        Me.rbtnRetrieveCancelledLoads.Id = 71
        Me.rbtnRetrieveCancelledLoads.ImageOptions.LargeImageIndex = 1
        Me.rbtnRetrieveCancelledLoads.Name = "rbtnRetrieveCancelledLoads"
        Me.rbtnRetrieveCancelledLoads.Tag = "249"
        '
        'rbtnRetrieveCustomers
        '
        Me.rbtnRetrieveCustomers.Caption = "Retrieve Customers"
        Me.rbtnRetrieveCustomers.Id = 72
        Me.rbtnRetrieveCustomers.ImageOptions.LargeImageIndex = 24
        Me.rbtnRetrieveCustomers.LargeWidth = 100
        Me.rbtnRetrieveCustomers.Name = "rbtnRetrieveCustomers"
        Me.rbtnRetrieveCustomers.Tag = "251"
        '
        'rbtnRetrieveCarriers
        '
        Me.rbtnRetrieveCarriers.Caption = "Retrieve Carriers"
        Me.rbtnRetrieveCarriers.Id = 73
        Me.rbtnRetrieveCarriers.ImageOptions.LargeImageIndex = 25
        Me.rbtnRetrieveCarriers.LargeWidth = 100
        Me.rbtnRetrieveCarriers.Name = "rbtnRetrieveCarriers"
        Me.rbtnRetrieveCarriers.Tag = "252"
        '
        'rbtnAddNewCarrier
        '
        Me.rbtnAddNewCarrier.Caption = "Add New Carrier"
        Me.rbtnAddNewCarrier.Id = 74
        Me.rbtnAddNewCarrier.ImageOptions.LargeImageIndex = 26
        Me.rbtnAddNewCarrier.Name = "rbtnAddNewCarrier"
        Me.rbtnAddNewCarrier.Tag = "253"
        Me.rbtnAddNewCarrier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rbtnEditCarrier
        '
        Me.rbtnEditCarrier.Caption = "Edit  Carrier"
        Me.rbtnEditCarrier.Id = 75
        Me.rbtnEditCarrier.ImageOptions.LargeImageIndex = 27
        Me.rbtnEditCarrier.Name = "rbtnEditCarrier"
        Me.rbtnEditCarrier.Tag = "254"
        Me.rbtnEditCarrier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rbtnDeleteCarrier
        '
        Me.rbtnDeleteCarrier.Caption = "Delete Carrier"
        Me.rbtnDeleteCarrier.Id = 76
        Me.rbtnDeleteCarrier.ImageOptions.LargeImageIndex = 28
        Me.rbtnDeleteCarrier.Name = "rbtnDeleteCarrier"
        Me.rbtnDeleteCarrier.Tag = "255"
        Me.rbtnDeleteCarrier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rbtnRetrieveLogisiticsProviders
        '
        Me.rbtnRetrieveLogisiticsProviders.Caption = "Retrieve Logistics Providers"
        Me.rbtnRetrieveLogisiticsProviders.Id = 78
        Me.rbtnRetrieveLogisiticsProviders.ImageOptions.LargeImageIndex = 29
        Me.rbtnRetrieveLogisiticsProviders.LargeWidth = 100
        Me.rbtnRetrieveLogisiticsProviders.Name = "rbtnRetrieveLogisiticsProviders"
        Me.rbtnRetrieveLogisiticsProviders.Tag = "256"
        '
        'rbtnAddNewLogisticsProvider
        '
        Me.rbtnAddNewLogisticsProvider.Caption = "Add New Provider"
        Me.rbtnAddNewLogisticsProvider.Id = 79
        Me.rbtnAddNewLogisticsProvider.ImageOptions.LargeImageIndex = 30
        Me.rbtnAddNewLogisticsProvider.Name = "rbtnAddNewLogisticsProvider"
        Me.rbtnAddNewLogisticsProvider.Tag = "257"
        Me.rbtnAddNewLogisticsProvider.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rbtnEditLogisticsProvider
        '
        Me.rbtnEditLogisticsProvider.Caption = "Edit  Provider"
        Me.rbtnEditLogisticsProvider.Id = 80
        Me.rbtnEditLogisticsProvider.ImageOptions.LargeImageIndex = 31
        Me.rbtnEditLogisticsProvider.Name = "rbtnEditLogisticsProvider"
        Me.rbtnEditLogisticsProvider.Tag = "258"
        Me.rbtnEditLogisticsProvider.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rbtnDeleteLogisticsProvider
        '
        Me.rbtnDeleteLogisticsProvider.Caption = "Delete Provider"
        Me.rbtnDeleteLogisticsProvider.Id = 81
        Me.rbtnDeleteLogisticsProvider.ImageOptions.LargeImageIndex = 32
        Me.rbtnDeleteLogisticsProvider.Name = "rbtnDeleteLogisticsProvider"
        Me.rbtnDeleteLogisticsProvider.Tag = "259"
        Me.rbtnDeleteLogisticsProvider.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'rbtnEditFreightSettings
        '
        Me.rbtnEditFreightSettings.Caption = "Edit Freight Settings"
        Me.rbtnEditFreightSettings.Id = 83
        Me.rbtnEditFreightSettings.ImageOptions.LargeImageIndex = 34
        Me.rbtnEditFreightSettings.Name = "rbtnEditFreightSettings"
        Me.rbtnEditFreightSettings.Tag = "260"
        '
        'rbtnInTransitMarkAsDelivered
        '
        Me.rbtnInTransitMarkAsDelivered.Caption = "Mark As Delivered"
        Me.rbtnInTransitMarkAsDelivered.Id = 85
        Me.rbtnInTransitMarkAsDelivered.ImageOptions.LargeImageIndex = 11
        Me.rbtnInTransitMarkAsDelivered.Name = "rbtnInTransitMarkAsDelivered"
        Me.rbtnInTransitMarkAsDelivered.Tag = "245"
        '
        'rbtnProcessLoad
        '
        Me.rbtnProcessLoad.Caption = "Process Load"
        Me.rbtnProcessLoad.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnProcessLoad.Id = 86
        Me.rbtnProcessLoad.ImageOptions.LargeImageIndex = 9
        Me.rbtnProcessLoad.Name = "rbtnProcessLoad"
        Me.rbtnProcessLoad.Tag = "231"
        '
        'rbtnPrintRptFutureShipments
        '
        Me.rbtnPrintRptFutureShipments.Caption = "Future Shipments"
        Me.rbtnPrintRptFutureShipments.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPrintRptFutureShipments.Id = 87
        Me.rbtnPrintRptFutureShipments.ImageOptions.LargeImageIndex = 5
        Me.rbtnPrintRptFutureShipments.Name = "rbtnPrintRptFutureShipments"
        Me.rbtnPrintRptFutureShipments.Tag = "250"
        '
        'eHistoryStart
        '
        Me.eHistoryStart.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.eHistoryStart.Caption = " Start Date  "
        Me.eHistoryStart.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eHistoryStart.Edit = Me.RepositoryItemDateEdit1
        Me.eHistoryStart.EditWidth = 80
        Me.eHistoryStart.Id = 88
        Me.eHistoryStart.Name = "eHistoryStart"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'eHistoryEnd
        '
        Me.eHistoryEnd.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.eHistoryEnd.Caption = " End Date    "
        Me.eHistoryEnd.CaptionAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eHistoryEnd.Edit = Me.RepositoryItemDateEdit2
        Me.eHistoryEnd.EditWidth = 80
        Me.eHistoryEnd.Id = 89
        Me.eHistoryEnd.Name = "eHistoryEnd"
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'eCustomerSelector
        '
        Me.eCustomerSelector.Edit = Me.RepositoryItemLookUpEdit6
        Me.eCustomerSelector.EditWidth = 200
        Me.eCustomerSelector.Id = 90
        Me.eCustomerSelector.Name = "eCustomerSelector"
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", 50, "ID"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", 200, "Customer Name"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", 100, "City"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", 30, "State")})
        Me.RepositoryItemLookUpEdit6.DataSource = Me.bsCustomers2
        Me.RepositoryItemLookUpEdit6.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit6.DropDownRows = 20
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = "[Select a Customer...]"
        Me.RepositoryItemLookUpEdit6.PopupWidth = 400
        Me.RepositoryItemLookUpEdit6.ValueMember = "Custid"
        '
        'bsCustomers2
        '
        Me.bsCustomers2.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'rBtnFetchShipmentHistory
        '
        Me.rBtnFetchShipmentHistory.Caption = "Get Shipment History"
        Me.rBtnFetchShipmentHistory.Id = 91
        Me.rBtnFetchShipmentHistory.ImageOptions.LargeImageIndex = 1
        Me.rBtnFetchShipmentHistory.Name = "rBtnFetchShipmentHistory"
        '
        'rbtnExportHistory
        '
        Me.rbtnExportHistory.Caption = "Export History to Excel"
        Me.rbtnExportHistory.Id = 92
        Me.rbtnExportHistory.ImageOptions.LargeImageIndex = 0
        Me.rbtnExportHistory.Name = "rbtnExportHistory"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "35"
        Me.RibbonPage1.Text = "Pending Loads"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnRetrievePendingLoads)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnProcessLoad, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnPendingAddLoad, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnPendingEditLoad)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnMergeLoads, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Data Management"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnPendingMarkAsCancelled, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Load Status"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4, Me.RibbonPageGroup8, Me.RibbonPageGroup9})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Tag = "36"
        Me.RibbonPage2.Text = "Scheduled"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnRetrieveScheduledLoads)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rtbnScheduledLoadEdit, True)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Data Management"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.AllowMinimize = False
        Me.RibbonPageGroup8.AllowTextClipping = False
        Me.RibbonPageGroup8.ItemLinks.Add(Me.rbtnPrintBOL)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Reports"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.AllowMinimize = False
        Me.RibbonPageGroup9.AllowTextClipping = False
        Me.RibbonPageGroup9.ItemLinks.Add(Me.rbtnScheduledMarkAsPending)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.rbtnScheduledMarkAsInTransit, True)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.rbtnScheduledMarkAsCancelled, True)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.ShowCaptionButton = False
        Me.RibbonPageGroup9.Text = "Load Status"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup14})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Tag = "37"
        Me.RibbonPage3.Text = "In Transit"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowMinimize = False
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnRetrieveInTransitLoads)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Data Management"
        '
        'RibbonPageGroup14
        '
        Me.RibbonPageGroup14.AllowMinimize = False
        Me.RibbonPageGroup14.AllowTextClipping = False
        Me.RibbonPageGroup14.ItemLinks.Add(Me.rbtnInTransitMarkAsReturned, True)
        Me.RibbonPageGroup14.ItemLinks.Add(Me.rbtnInTransitMarkAsDelivered, True)
        Me.RibbonPageGroup14.Name = "RibbonPageGroup14"
        Me.RibbonPageGroup14.ShowCaptionButton = False
        Me.RibbonPageGroup14.Text = "Load Status"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6, Me.RibbonPageGroup16, Me.RibbonPageGroup15})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Tag = "38"
        Me.RibbonPage4.Text = "Delivered"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowMinimize = False
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnRetrieveDeliveredLoads)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Data Management"
        '
        'RibbonPageGroup16
        '
        Me.RibbonPageGroup16.AllowMinimize = False
        Me.RibbonPageGroup16.AllowTextClipping = False
        Me.RibbonPageGroup16.ItemLinks.Add(Me.rbtnReprintBOL)
        Me.RibbonPageGroup16.Name = "RibbonPageGroup16"
        Me.RibbonPageGroup16.ShowCaptionButton = False
        Me.RibbonPageGroup16.Text = "Reports"
        '
        'RibbonPageGroup15
        '
        Me.RibbonPageGroup15.AllowMinimize = False
        Me.RibbonPageGroup15.AllowTextClipping = False
        Me.RibbonPageGroup15.ItemLinks.Add(Me.rbtnDeliveredMarkAsInTransit)
        Me.RibbonPageGroup15.Name = "RibbonPageGroup15"
        Me.RibbonPageGroup15.ShowCaptionButton = False
        Me.RibbonPageGroup15.Text = "Load Status"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup7})
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Tag = "39"
        Me.RibbonPage5.Text = "Returned / Cancelled"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowMinimize = False
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnRetrieveCancelledLoads)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Data Management"
        '
        'RibbonPage8
        '
        Me.RibbonPage8.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup13})
        Me.RibbonPage8.Name = "RibbonPage8"
        Me.RibbonPage8.Tag = "40"
        Me.RibbonPage8.Text = "Reports"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnPrintRptFutureShipments)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Future Shipments"
        '
        'RibbonPageGroup13
        '
        Me.RibbonPageGroup13.AllowMinimize = False
        Me.RibbonPageGroup13.AllowTextClipping = False
        Me.RibbonPageGroup13.ItemLinks.Add(Me.eCustomerSelector)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.eHistoryStart)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.eHistoryEnd)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.rBtnFetchShipmentHistory, True)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.rbtnExportHistory)
        Me.RibbonPageGroup13.Name = "RibbonPageGroup13"
        Me.RibbonPageGroup13.ShowCaptionButton = False
        Me.RibbonPageGroup13.Text = "Customer Shipment History"
        '
        'RibbonPage6
        '
        Me.RibbonPage6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup26, Me.RibbonPageGroup11, Me.RibbonPageGroup12})
        Me.RibbonPage6.Name = "RibbonPage6"
        Me.RibbonPage6.Tag = "41"
        Me.RibbonPage6.Text = "Reference Data"
        '
        'RibbonPageGroup26
        '
        Me.RibbonPageGroup26.AllowMinimize = False
        Me.RibbonPageGroup26.AllowTextClipping = False
        Me.RibbonPageGroup26.ItemLinks.Add(Me.rbtnRetrieveCustomers)
        Me.RibbonPageGroup26.Name = "RibbonPageGroup26"
        Me.RibbonPageGroup26.ShowCaptionButton = False
        Me.RibbonPageGroup26.Text = "Customers"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.AllowMinimize = False
        Me.RibbonPageGroup11.AllowTextClipping = False
        Me.RibbonPageGroup11.ItemLinks.Add(Me.rbtnRetrieveCarriers)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.rbtnAddNewCarrier, True)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.rbtnEditCarrier)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.rbtnDeleteCarrier)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        Me.RibbonPageGroup11.ShowCaptionButton = False
        Me.RibbonPageGroup11.Text = "Carriers"
        '
        'RibbonPageGroup12
        '
        Me.RibbonPageGroup12.AllowMinimize = False
        Me.RibbonPageGroup12.AllowTextClipping = False
        Me.RibbonPageGroup12.ItemLinks.Add(Me.rbtnRetrieveLogisiticsProviders)
        Me.RibbonPageGroup12.ItemLinks.Add(Me.rbtnAddNewLogisticsProvider, True)
        Me.RibbonPageGroup12.ItemLinks.Add(Me.rbtnEditLogisticsProvider)
        Me.RibbonPageGroup12.ItemLinks.Add(Me.rbtnDeleteLogisticsProvider)
        Me.RibbonPageGroup12.Name = "RibbonPageGroup12"
        Me.RibbonPageGroup12.ShowCaptionButton = False
        Me.RibbonPageGroup12.Text = "Logistics Providers"
        '
        'RibbonPage7
        '
        Me.RibbonPage7.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup10})
        Me.RibbonPage7.Name = "RibbonPage7"
        Me.RibbonPage7.Tag = "42"
        Me.RibbonPage7.Text = "Freight Settings"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.AllowMinimize = False
        Me.RibbonPageGroup10.AllowTextClipping = False
        Me.RibbonPageGroup10.ItemLinks.Add(Me.rbtnEditFreightSettings, True)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.ShowCaptionButton = False
        Me.RibbonPageGroup10.Text = "Data Management"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'WorkPanelsHolder
        '
        Me.WorkPanelsHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl8)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl7)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl6)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl9)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 149)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1268, 600)
        Me.WorkPanelsHolder.TabIndex = 7
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Controls.Add(Me.GroupControl2)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1268, 600)
        Me.RibbonPanelControl1.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.PanelControl1)
        Me.GroupControl2.Controls.Add(Me.pnlColorMapping)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1252, 584)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "PENDING LOADS"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.grPendingLoads)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(2, 49)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1248, 533)
        Me.PanelControl1.TabIndex = 0
        '
        'grPendingLoads
        '
        Me.grPendingLoads.DataSource = Me.bsPendingLoads
        Me.grPendingLoads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPendingLoads.Location = New System.Drawing.Point(0, 0)
        Me.grPendingLoads.MainView = Me.grvPendingLoads
        Me.grPendingLoads.Name = "grPendingLoads"
        Me.grPendingLoads.Size = New System.Drawing.Size(1248, 533)
        Me.grPendingLoads.TabIndex = 0
        Me.grPendingLoads.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPendingLoads, Me.GridView4})
        '
        'bsPendingLoads
        '
        Me.bsPendingLoads.DataSource = GetType(AOS.BusinessObjects.ViewLoadSummaryCollection)
        '
        'grvPendingLoads
        '
        Me.grvPendingLoads.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLoadID, Me.colLoadStatus, Me.colLoadType, Me.colPlannedDepartureDate, Me.colPlannedDeliveryDate, Me.colOriginType, Me.colOriginName, Me.colOriginCity, Me.colOriginState, Me.colDestType, Me.colDestName, Me.colDestCity, Me.colDestState, Me.colCarrierID, Me.colCarrierName, Me.colPallets, Me.colTotalSkids, Me.colGrossWt, Me.colWONumber, Me.colWorkOrderStatus, Me.colFreezeprotectflag, Me.colOrSoonerFlag})
        Me.grvPendingLoads.GridControl = Me.grPendingLoads
        Me.grvPendingLoads.GroupCount = 1
        Me.grvPendingLoads.GroupFormat = "{1}"
        Me.grvPendingLoads.Name = "grvPendingLoads"
        Me.grvPendingLoads.OptionsBehavior.Editable = False
        Me.grvPendingLoads.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.grvPendingLoads.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvPendingLoads.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.grvPendingLoads.OptionsView.ShowAutoFilterRow = True
        Me.grvPendingLoads.OptionsView.ShowGroupPanel = False
        Me.grvPendingLoads.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colPlannedDepartureDate, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colLoadID
        '
        Me.colLoadID.FieldName = "LoadID"
        Me.colLoadID.Name = "colLoadID"
        Me.colLoadID.Visible = True
        Me.colLoadID.VisibleIndex = 0
        Me.colLoadID.Width = 50
        '
        'colLoadStatus
        '
        Me.colLoadStatus.FieldName = "LoadStatus"
        Me.colLoadStatus.Name = "colLoadStatus"
        Me.colLoadStatus.Visible = True
        Me.colLoadStatus.VisibleIndex = 1
        Me.colLoadStatus.Width = 66
        '
        'colLoadType
        '
        Me.colLoadType.FieldName = "LoadType"
        Me.colLoadType.Name = "colLoadType"
        Me.colLoadType.Visible = True
        Me.colLoadType.VisibleIndex = 2
        Me.colLoadType.Width = 62
        '
        'colPlannedDepartureDate
        '
        Me.colPlannedDepartureDate.DisplayFormat.FormatString = "D"
        Me.colPlannedDepartureDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPlannedDepartureDate.FieldName = "PlannedDepartureDate"
        Me.colPlannedDepartureDate.GroupFormat.FormatString = "D"
        Me.colPlannedDepartureDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPlannedDepartureDate.Name = "colPlannedDepartureDate"
        Me.colPlannedDepartureDate.Visible = True
        Me.colPlannedDepartureDate.VisibleIndex = 4
        Me.colPlannedDepartureDate.Width = 85
        '
        'colPlannedDeliveryDate
        '
        Me.colPlannedDeliveryDate.FieldName = "PlannedDeliveryDate"
        Me.colPlannedDeliveryDate.Name = "colPlannedDeliveryDate"
        Me.colPlannedDeliveryDate.Visible = True
        Me.colPlannedDeliveryDate.VisibleIndex = 4
        Me.colPlannedDeliveryDate.Width = 85
        '
        'colOriginType
        '
        Me.colOriginType.FieldName = "OriginType"
        Me.colOriginType.Name = "colOriginType"
        Me.colOriginType.Visible = True
        Me.colOriginType.VisibleIndex = 5
        Me.colOriginType.Width = 85
        '
        'colOriginName
        '
        Me.colOriginName.FieldName = "OriginName"
        Me.colOriginName.Name = "colOriginName"
        Me.colOriginName.Visible = True
        Me.colOriginName.VisibleIndex = 6
        Me.colOriginName.Width = 85
        '
        'colOriginCity
        '
        Me.colOriginCity.FieldName = "OriginCity"
        Me.colOriginCity.Name = "colOriginCity"
        Me.colOriginCity.Visible = True
        Me.colOriginCity.VisibleIndex = 7
        Me.colOriginCity.Width = 85
        '
        'colOriginState
        '
        Me.colOriginState.FieldName = "OriginState"
        Me.colOriginState.Name = "colOriginState"
        Me.colOriginState.Visible = True
        Me.colOriginState.VisibleIndex = 8
        Me.colOriginState.Width = 85
        '
        'colDestType
        '
        Me.colDestType.FieldName = "DestType"
        Me.colDestType.Name = "colDestType"
        Me.colDestType.Visible = True
        Me.colDestType.VisibleIndex = 9
        Me.colDestType.Width = 85
        '
        'colDestName
        '
        Me.colDestName.FieldName = "DestName"
        Me.colDestName.Name = "colDestName"
        Me.colDestName.Visible = True
        Me.colDestName.VisibleIndex = 10
        Me.colDestName.Width = 85
        '
        'colDestCity
        '
        Me.colDestCity.FieldName = "DestCity"
        Me.colDestCity.Name = "colDestCity"
        Me.colDestCity.Visible = True
        Me.colDestCity.VisibleIndex = 11
        Me.colDestCity.Width = 85
        '
        'colDestState
        '
        Me.colDestState.FieldName = "DestState"
        Me.colDestState.Name = "colDestState"
        Me.colDestState.Visible = True
        Me.colDestState.VisibleIndex = 12
        Me.colDestState.Width = 85
        '
        'colCarrierID
        '
        Me.colCarrierID.FieldName = "CarrierID"
        Me.colCarrierID.Name = "colCarrierID"
        Me.colCarrierID.Visible = True
        Me.colCarrierID.VisibleIndex = 13
        '
        'colCarrierName
        '
        Me.colCarrierName.FieldName = "CarrierName"
        Me.colCarrierName.Name = "colCarrierName"
        Me.colCarrierName.Visible = True
        Me.colCarrierName.VisibleIndex = 14
        Me.colCarrierName.Width = 85
        '
        'colPallets
        '
        Me.colPallets.FieldName = "Pallets"
        Me.colPallets.Name = "colPallets"
        Me.colPallets.Visible = True
        Me.colPallets.VisibleIndex = 15
        Me.colPallets.Width = 85
        '
        'colTotalSkids
        '
        Me.colTotalSkids.Caption = "Skids"
        Me.colTotalSkids.FieldName = "TotalSkids"
        Me.colTotalSkids.Name = "colTotalSkids"
        Me.colTotalSkids.Visible = True
        Me.colTotalSkids.VisibleIndex = 16
        '
        'colGrossWt
        '
        Me.colGrossWt.FieldName = "GrossWt"
        Me.colGrossWt.Name = "colGrossWt"
        Me.colGrossWt.Visible = True
        Me.colGrossWt.VisibleIndex = 17
        Me.colGrossWt.Width = 106
        '
        'colWONumber
        '
        Me.colWONumber.Caption = "WO#"
        Me.colWONumber.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.colWONumber.FieldName = "WorkOrderNumbers"
        Me.colWONumber.Name = "colWONumber"
        Me.colWONumber.OptionsColumn.AllowEdit = False
        Me.colWONumber.OptionsColumn.FixedWidth = True
        Me.colWONumber.Visible = True
        Me.colWONumber.VisibleIndex = 3
        '
        'colWorkOrderStatus
        '
        Me.colWorkOrderStatus.FieldName = "WorkOrderStatus"
        Me.colWorkOrderStatus.Name = "colWorkOrderStatus"
        '
        'colFreezeprotectflag
        '
        Me.colFreezeprotectflag.FieldName = "Freezeprotectflag"
        Me.colFreezeprotectflag.Name = "colFreezeprotectflag"
        Me.colFreezeprotectflag.Visible = True
        Me.colFreezeprotectflag.VisibleIndex = 19
        '
        'colOrSoonerFlag
        '
        Me.colOrSoonerFlag.FieldName = "OrSoonerFlag"
        Me.colOrSoonerFlag.Name = "colOrSoonerFlag"
        Me.colOrSoonerFlag.Visible = True
        Me.colOrSoonerFlag.VisibleIndex = 18
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.grPendingLoads
        Me.GridView4.Name = "GridView4"
        '
        'pnlColorMapping
        '
        Me.pnlColorMapping.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlColorMapping.Controls.Add(Me.lblRedDesc)
        Me.pnlColorMapping.Controls.Add(Me.lblRedColor)
        Me.pnlColorMapping.Controls.Add(Me.LabelControl5)
        Me.pnlColorMapping.Controls.Add(Me.LabelControl4)
        Me.pnlColorMapping.Controls.Add(Me.LabelControl3)
        Me.pnlColorMapping.Controls.Add(Me.LabelControl2)
        Me.pnlColorMapping.Controls.Add(Me.LabelControl1)
        Me.pnlColorMapping.Controls.Add(Me.ColorEdit4)
        Me.pnlColorMapping.Controls.Add(Me.ColorEdit3)
        Me.pnlColorMapping.Controls.Add(Me.ColorEdit2)
        Me.pnlColorMapping.Controls.Add(Me.ColorEdit1)
        Me.pnlColorMapping.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlColorMapping.Location = New System.Drawing.Point(2, 20)
        Me.pnlColorMapping.Name = "pnlColorMapping"
        Me.pnlColorMapping.Size = New System.Drawing.Size(1248, 29)
        Me.pnlColorMapping.TabIndex = 2
        '
        'lblRedDesc
        '
        Me.lblRedDesc.Location = New System.Drawing.Point(236, 6)
        Me.lblRedDesc.Name = "lblRedDesc"
        Me.lblRedDesc.Size = New System.Drawing.Size(51, 13)
        Me.lblRedDesc.TabIndex = 10
        Me.lblRedDesc.Text = "Late Items"
        '
        'lblRedColor
        '
        Me.lblRedColor.EditValue = System.Drawing.Color.Red
        Me.lblRedColor.Location = New System.Drawing.Point(201, 4)
        Me.lblRedColor.MenuManager = Me.RibbonControl1
        Me.lblRedColor.Name = "lblRedColor"
        Me.lblRedColor.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblRedColor.Properties.Appearance.Options.UseBackColor = True
        Me.lblRedColor.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblRedColor.Properties.ReadOnly = True
        Me.lblRedColor.Size = New System.Drawing.Size(30, 18)
        Me.lblRedColor.TabIndex = 9
        Me.lblRedColor.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(689, 6)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(118, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Items Needing Allocation"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(471, 6)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(166, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Open Production Orders / Relabels"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(329, 6)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(103, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Open Purchase Items"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(123, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Order on Hold"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(9, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Color Mapping:"
        '
        'ColorEdit4
        '
        Me.ColorEdit4.EditValue = System.Drawing.Color.LightBlue
        Me.ColorEdit4.Location = New System.Drawing.Point(441, 4)
        Me.ColorEdit4.MenuManager = Me.RibbonControl1
        Me.ColorEdit4.Name = "ColorEdit4"
        Me.ColorEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ColorEdit4.Properties.Appearance.Options.UseBackColor = True
        Me.ColorEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ColorEdit4.Properties.ReadOnly = True
        Me.ColorEdit4.Size = New System.Drawing.Size(30, 18)
        Me.ColorEdit4.TabIndex = 3
        Me.ColorEdit4.TabStop = False
        '
        'ColorEdit3
        '
        Me.ColorEdit3.EditValue = System.Drawing.Color.LightGreen
        Me.ColorEdit3.Location = New System.Drawing.Point(657, 4)
        Me.ColorEdit3.MenuManager = Me.RibbonControl1
        Me.ColorEdit3.Name = "ColorEdit3"
        Me.ColorEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ColorEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.ColorEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ColorEdit3.Properties.ReadOnly = True
        Me.ColorEdit3.Size = New System.Drawing.Size(30, 18)
        Me.ColorEdit3.TabIndex = 2
        Me.ColorEdit3.TabStop = False
        '
        'ColorEdit2
        '
        Me.ColorEdit2.EditValue = System.Drawing.Color.Pink
        Me.ColorEdit2.Location = New System.Drawing.Point(298, 4)
        Me.ColorEdit2.MenuManager = Me.RibbonControl1
        Me.ColorEdit2.Name = "ColorEdit2"
        Me.ColorEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ColorEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.ColorEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ColorEdit2.Properties.ReadOnly = True
        Me.ColorEdit2.Size = New System.Drawing.Size(30, 18)
        Me.ColorEdit2.TabIndex = 1
        Me.ColorEdit2.TabStop = False
        '
        'ColorEdit1
        '
        Me.ColorEdit1.EditValue = System.Drawing.Color.Yellow
        Me.ColorEdit1.Location = New System.Drawing.Point(89, 4)
        Me.ColorEdit1.MenuManager = Me.RibbonControl1
        Me.ColorEdit1.Name = "ColorEdit1"
        Me.ColorEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ColorEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.ColorEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ColorEdit1.Properties.ReadOnly = True
        Me.ColorEdit1.Size = New System.Drawing.Size(28, 18)
        Me.ColorEdit1.TabIndex = 0
        Me.ColorEdit1.TabStop = False
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Controls.Add(Me.GroupControl5)
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(1268, 600)
        Me.RibbonPanelControl5.TabIndex = 3
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.PanelControl5)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1252, 584)
        Me.GroupControl5.TabIndex = 4
        Me.GroupControl5.Text = "RETURNED / CANCELLED LOADS"
        '
        'PanelControl5
        '
        Me.PanelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl5.Controls.Add(Me.grCancelledLoads)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(1248, 562)
        Me.PanelControl5.TabIndex = 0
        '
        'grCancelledLoads
        '
        Me.grCancelledLoads.DataSource = Me.bsCancelledLoads
        Me.grCancelledLoads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCancelledLoads.Location = New System.Drawing.Point(0, 0)
        Me.grCancelledLoads.MainView = Me.GridView9
        Me.grCancelledLoads.Name = "grCancelledLoads"
        Me.grCancelledLoads.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit5})
        Me.grCancelledLoads.Size = New System.Drawing.Size(1248, 562)
        Me.grCancelledLoads.TabIndex = 0
        Me.grCancelledLoads.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9, Me.GridView10})
        '
        'bsCancelledLoads
        '
        Me.bsCancelledLoads.DataSource = GetType(AOS.BusinessObjects.ViewLoadSummaryCollection)
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn52, Me.GridColumn53, Me.GridColumn54, Me.GridColumn55, Me.GridColumn56, Me.GridColumn57, Me.GridColumn58, Me.GridColumn59, Me.GridColumn60, Me.GridColumn61, Me.GridColumn62, Me.GridColumn63, Me.GridColumn64, Me.GridColumn65, Me.GridColumn66, Me.colTotalSkids4, Me.GridColumn67, Me.GridColumn68, Me.GridColumn75})
        Me.GridView9.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView9.GridControl = Me.grCancelledLoads
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView9.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView9.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GridView9.OptionsView.ShowAutoFilterRow = True
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.OptionsView.ShowIndicator = False
        '
        'GridColumn52
        '
        Me.GridColumn52.FieldName = "LoadID"
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.Visible = True
        Me.GridColumn52.VisibleIndex = 0
        Me.GridColumn52.Width = 45
        '
        'GridColumn53
        '
        Me.GridColumn53.FieldName = "LoadStatus"
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.Visible = True
        Me.GridColumn53.VisibleIndex = 1
        Me.GridColumn53.Width = 59
        '
        'GridColumn54
        '
        Me.GridColumn54.FieldName = "LoadType"
        Me.GridColumn54.Name = "GridColumn54"
        Me.GridColumn54.Visible = True
        Me.GridColumn54.VisibleIndex = 2
        Me.GridColumn54.Width = 56
        '
        'GridColumn55
        '
        Me.GridColumn55.FieldName = "PlannedDepartureDate"
        Me.GridColumn55.Name = "GridColumn55"
        Me.GridColumn55.Visible = True
        Me.GridColumn55.VisibleIndex = 4
        Me.GridColumn55.Width = 76
        '
        'GridColumn56
        '
        Me.GridColumn56.FieldName = "PlannedDeliveryDate"
        Me.GridColumn56.Name = "GridColumn56"
        Me.GridColumn56.Visible = True
        Me.GridColumn56.VisibleIndex = 5
        Me.GridColumn56.Width = 76
        '
        'GridColumn57
        '
        Me.GridColumn57.FieldName = "OriginType"
        Me.GridColumn57.Name = "GridColumn57"
        Me.GridColumn57.Visible = True
        Me.GridColumn57.VisibleIndex = 6
        Me.GridColumn57.Width = 76
        '
        'GridColumn58
        '
        Me.GridColumn58.FieldName = "OriginName"
        Me.GridColumn58.Name = "GridColumn58"
        Me.GridColumn58.Visible = True
        Me.GridColumn58.VisibleIndex = 7
        Me.GridColumn58.Width = 76
        '
        'GridColumn59
        '
        Me.GridColumn59.FieldName = "OriginCity"
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.Visible = True
        Me.GridColumn59.VisibleIndex = 8
        Me.GridColumn59.Width = 76
        '
        'GridColumn60
        '
        Me.GridColumn60.FieldName = "OriginState"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.Visible = True
        Me.GridColumn60.VisibleIndex = 9
        Me.GridColumn60.Width = 76
        '
        'GridColumn61
        '
        Me.GridColumn61.FieldName = "DestType"
        Me.GridColumn61.Name = "GridColumn61"
        Me.GridColumn61.Visible = True
        Me.GridColumn61.VisibleIndex = 10
        Me.GridColumn61.Width = 76
        '
        'GridColumn62
        '
        Me.GridColumn62.FieldName = "DestName"
        Me.GridColumn62.Name = "GridColumn62"
        Me.GridColumn62.Visible = True
        Me.GridColumn62.VisibleIndex = 11
        Me.GridColumn62.Width = 76
        '
        'GridColumn63
        '
        Me.GridColumn63.FieldName = "DestCity"
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.Visible = True
        Me.GridColumn63.VisibleIndex = 12
        Me.GridColumn63.Width = 76
        '
        'GridColumn64
        '
        Me.GridColumn64.FieldName = "DestState"
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.Visible = True
        Me.GridColumn64.VisibleIndex = 13
        Me.GridColumn64.Width = 76
        '
        'GridColumn65
        '
        Me.GridColumn65.FieldName = "CarrierID"
        Me.GridColumn65.Name = "GridColumn65"
        '
        'GridColumn66
        '
        Me.GridColumn66.Caption = "Sched Carrier"
        Me.GridColumn66.FieldName = "ScheduledCarrierName"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.Visible = True
        Me.GridColumn66.VisibleIndex = 14
        Me.GridColumn66.Width = 100
        '
        'colTotalSkids4
        '
        Me.colTotalSkids4.Caption = "Skids"
        Me.colTotalSkids4.FieldName = "TotalSkids"
        Me.colTotalSkids4.Name = "colTotalSkids4"
        Me.colTotalSkids4.Visible = True
        Me.colTotalSkids4.VisibleIndex = 15
        '
        'GridColumn67
        '
        Me.GridColumn67.FieldName = "Pallets"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.Visible = True
        Me.GridColumn67.VisibleIndex = 16
        Me.GridColumn67.Width = 64
        '
        'GridColumn68
        '
        Me.GridColumn68.FieldName = "GrossWt"
        Me.GridColumn68.Name = "GridColumn68"
        Me.GridColumn68.Visible = True
        Me.GridColumn68.VisibleIndex = 17
        Me.GridColumn68.Width = 95
        '
        'GridColumn75
        '
        Me.GridColumn75.Caption = "WO#"
        Me.GridColumn75.FieldName = "WorkOrderNumbers"
        Me.GridColumn75.Name = "GridColumn75"
        Me.GridColumn75.Visible = True
        Me.GridColumn75.VisibleIndex = 3
        Me.GridColumn75.Width = 67
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcountry", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.ValueMember = "Custname"
        '
        'GridView10
        '
        Me.GridView10.GridControl = Me.grCancelledLoads
        Me.GridView10.Name = "GridView10"
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Controls.Add(Me.GroupControl1)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1268, 600)
        Me.RibbonPanelControl2.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.PanelControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1252, 584)
        Me.GroupControl1.TabIndex = 4
        Me.GroupControl1.Text = "SCHEDULED LOADS"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.grScheduledLoads)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1248, 562)
        Me.PanelControl2.TabIndex = 0
        '
        'grScheduledLoads
        '
        Me.grScheduledLoads.DataSource = Me.bsScheduledLoads
        Me.grScheduledLoads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grScheduledLoads.Location = New System.Drawing.Point(0, 0)
        Me.grScheduledLoads.MainView = Me.GridView1
        Me.grScheduledLoads.Name = "grScheduledLoads"
        Me.grScheduledLoads.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.grScheduledLoads.Size = New System.Drawing.Size(1248, 562)
        Me.grScheduledLoads.TabIndex = 0
        Me.grScheduledLoads.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'bsScheduledLoads
        '
        Me.bsScheduledLoads.DataSource = GetType(AOS.BusinessObjects.ViewLoadSummaryCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.colTotalSkids3, Me.GridColumn16, Me.GridColumn17, Me.GridColumn72})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.grScheduledLoads
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "LoadID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 45
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "LoadStatus"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 59
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "LoadType"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 56
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "PlannedDepartureDate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 76
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "PlannedDeliveryDate"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 76
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "OriginType"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 76
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "OriginName"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 76
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "OriginCity"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 76
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "OriginState"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 76
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "DestType"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        Me.GridColumn10.Width = 76
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "DestName"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 11
        Me.GridColumn11.Width = 76
        '
        'GridColumn12
        '
        Me.GridColumn12.FieldName = "DestCity"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 12
        Me.GridColumn12.Width = 76
        '
        'GridColumn13
        '
        Me.GridColumn13.FieldName = "DestState"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 13
        Me.GridColumn13.Width = 76
        '
        'GridColumn14
        '
        Me.GridColumn14.FieldName = "CarrierID"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Sched Carrier"
        Me.GridColumn15.FieldName = "ScheduledCarrierName"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 14
        Me.GridColumn15.Width = 113
        '
        'colTotalSkids3
        '
        Me.colTotalSkids3.Caption = "Skids"
        Me.colTotalSkids3.FieldName = "TotalSkids"
        Me.colTotalSkids3.Name = "colTotalSkids3"
        Me.colTotalSkids3.Visible = True
        Me.colTotalSkids3.VisibleIndex = 15
        '
        'GridColumn16
        '
        Me.GridColumn16.FieldName = "Pallets"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 16
        Me.GridColumn16.Width = 60
        '
        'GridColumn17
        '
        Me.GridColumn17.FieldName = "GrossWt"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 17
        Me.GridColumn17.Width = 86
        '
        'GridColumn72
        '
        Me.GridColumn72.Caption = "WO#"
        Me.GridColumn72.FieldName = "WorkOrderNumbers"
        Me.GridColumn72.Name = "GridColumn72"
        Me.GridColumn72.Visible = True
        Me.GridColumn72.VisibleIndex = 3
        Me.GridColumn72.Width = 67
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcountry", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Custname"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grScheduledLoads
        Me.GridView2.Name = "GridView2"
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.GroupControl3)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1268, 600)
        Me.RibbonPanelControl3.TabIndex = 1
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.PanelControl3)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1252, 584)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "IN TRANSIT LOADS"
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.grInTransitLoads)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1248, 562)
        Me.PanelControl3.TabIndex = 0
        '
        'grInTransitLoads
        '
        Me.grInTransitLoads.DataSource = Me.bsInTransitLoads
        Me.grInTransitLoads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInTransitLoads.Location = New System.Drawing.Point(0, 0)
        Me.grInTransitLoads.MainView = Me.GridView5
        Me.grInTransitLoads.Name = "grInTransitLoads"
        Me.grInTransitLoads.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit3})
        Me.grInTransitLoads.Size = New System.Drawing.Size(1248, 562)
        Me.grInTransitLoads.TabIndex = 0
        Me.grInTransitLoads.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5, Me.GridView6})
        '
        'bsInTransitLoads
        '
        Me.bsInTransitLoads.DataSource = GetType(AOS.BusinessObjects.ViewLoadSummaryCollection)
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn73, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn22, Me.GridColumn21, Me.colTotalSkids2, Me.GridColumn33, Me.GridColumn34})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView5.GridControl = Me.grInTransitLoads
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GridView5.OptionsView.ShowAutoFilterRow = True
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'GridColumn18
        '
        Me.GridColumn18.FieldName = "LoadID"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 0
        Me.GridColumn18.Width = 45
        '
        'GridColumn19
        '
        Me.GridColumn19.FieldName = "LoadStatus"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 1
        Me.GridColumn19.Width = 60
        '
        'GridColumn20
        '
        Me.GridColumn20.FieldName = "LoadType"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 2
        Me.GridColumn20.Width = 56
        '
        'GridColumn73
        '
        Me.GridColumn73.Caption = "WO#"
        Me.GridColumn73.FieldName = "WorkOrderNumbers"
        Me.GridColumn73.Name = "GridColumn73"
        Me.GridColumn73.Visible = True
        Me.GridColumn73.VisibleIndex = 3
        Me.GridColumn73.Width = 68
        '
        'GridColumn23
        '
        Me.GridColumn23.FieldName = "OriginType"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 4
        Me.GridColumn23.Width = 77
        '
        'GridColumn24
        '
        Me.GridColumn24.FieldName = "OriginName"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 5
        Me.GridColumn24.Width = 77
        '
        'GridColumn25
        '
        Me.GridColumn25.FieldName = "OriginCity"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 6
        Me.GridColumn25.Width = 77
        '
        'GridColumn26
        '
        Me.GridColumn26.FieldName = "OriginState"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 7
        Me.GridColumn26.Width = 77
        '
        'GridColumn27
        '
        Me.GridColumn27.FieldName = "DestType"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 8
        Me.GridColumn27.Width = 77
        '
        'GridColumn28
        '
        Me.GridColumn28.FieldName = "DestName"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 9
        Me.GridColumn28.Width = 77
        '
        'GridColumn29
        '
        Me.GridColumn29.FieldName = "DestCity"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 10
        Me.GridColumn29.Width = 77
        '
        'GridColumn30
        '
        Me.GridColumn30.FieldName = "DestState"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 11
        Me.GridColumn30.Width = 77
        '
        'GridColumn31
        '
        Me.GridColumn31.FieldName = "CarrierID"
        Me.GridColumn31.Name = "GridColumn31"
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Sched Carrier"
        Me.GridColumn32.FieldName = "ScheduledCarrierName"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 12
        Me.GridColumn32.Width = 95
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Carrier Pro#"
        Me.GridColumn22.FieldName = "CarrierProNumber"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 13
        Me.GridColumn22.Width = 85
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Actual Ship"
        Me.GridColumn21.FieldName = "ActualShipmentDate"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 14
        Me.GridColumn21.Width = 80
        '
        'colTotalSkids2
        '
        Me.colTotalSkids2.Caption = "Skids"
        Me.colTotalSkids2.FieldName = "TotalSkids"
        Me.colTotalSkids2.Name = "colTotalSkids2"
        Me.colTotalSkids2.Visible = True
        Me.colTotalSkids2.VisibleIndex = 15
        '
        'GridColumn33
        '
        Me.GridColumn33.FieldName = "Pallets"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 16
        Me.GridColumn33.Width = 64
        '
        'GridColumn34
        '
        Me.GridColumn34.FieldName = "GrossWt"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 17
        Me.GridColumn34.Width = 77
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcountry", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "Custname"
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.grInTransitLoads
        Me.GridView6.Name = "GridView6"
        '
        'RibbonPanelControl8
        '
        Me.RibbonPanelControl8.Controls.Add(Me.GroupControl8)
        Me.RibbonPanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl8.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl8.Name = "RibbonPanelControl8"
        Me.RibbonPanelControl8.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl8.Size = New System.Drawing.Size(1268, 600)
        Me.RibbonPanelControl8.TabIndex = 5
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.PanelControl6)
        Me.GroupControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl8.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(1252, 584)
        Me.GroupControl8.TabIndex = 4
        Me.GroupControl8.Text = "CUSTOMER SHIPPING HISTORY"
        '
        'PanelControl6
        '
        Me.PanelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl6.Controls.Add(Me.GridControl1)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl6.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1248, 562)
        Me.PanelControl6.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsCustomerShipmentHistory
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.grvCustomerShipmentHistory
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit7})
        Me.GridControl1.Size = New System.Drawing.Size(1248, 562)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCustomerShipmentHistory, Me.CustomDevExGridView2})
        '
        'bsCustomerShipmentHistory
        '
        Me.bsCustomerShipmentHistory.DataSource = GetType(AOS.BusinessObjects.ViewCustomerShipmentTotalsCollection)
        '
        'grvCustomerShipmentHistory
        '
        Me.grvCustomerShipmentHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustid1, Me.colCustname1, Me.colWorkordernumber, Me.colOrdertype, Me.colActualShipmentDate, Me.colPlannedDeliveryDate1, Me.colLoadType1, Me.colQty, Me.colContainer, Me.colUnits, Me.colUom, Me.colProductid, Me.colProductdesc})
        Me.grvCustomerShipmentHistory.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grvCustomerShipmentHistory.GridControl = Me.GridControl1
        Me.grvCustomerShipmentHistory.Name = "grvCustomerShipmentHistory"
        Me.grvCustomerShipmentHistory.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.grvCustomerShipmentHistory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvCustomerShipmentHistory.OptionsSelection.MultiSelect = True
        Me.grvCustomerShipmentHistory.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.grvCustomerShipmentHistory.OptionsView.ShowAutoFilterRow = True
        Me.grvCustomerShipmentHistory.OptionsView.ShowGroupPanel = False
        Me.grvCustomerShipmentHistory.OptionsView.ShowIndicator = False
        '
        'colCustid1
        '
        Me.colCustid1.Caption = "Cust ID"
        Me.colCustid1.FieldName = "Custid"
        Me.colCustid1.Name = "colCustid1"
        Me.colCustid1.Visible = True
        Me.colCustid1.VisibleIndex = 0
        Me.colCustid1.Width = 47
        '
        'colCustname1
        '
        Me.colCustname1.Caption = "Customer Name"
        Me.colCustname1.FieldName = "Custname"
        Me.colCustname1.Name = "colCustname1"
        Me.colCustname1.Visible = True
        Me.colCustname1.VisibleIndex = 1
        Me.colCustname1.Width = 176
        '
        'colWorkordernumber
        '
        Me.colWorkordernumber.Caption = "WO #"
        Me.colWorkordernumber.FieldName = "Workordernumber"
        Me.colWorkordernumber.Name = "colWorkordernumber"
        Me.colWorkordernumber.Visible = True
        Me.colWorkordernumber.VisibleIndex = 2
        Me.colWorkordernumber.Width = 60
        '
        'colOrdertype
        '
        Me.colOrdertype.Caption = "WO Type"
        Me.colOrdertype.FieldName = "Ordertype"
        Me.colOrdertype.Name = "colOrdertype"
        Me.colOrdertype.Visible = True
        Me.colOrdertype.VisibleIndex = 3
        Me.colOrdertype.Width = 113
        '
        'colActualShipmentDate
        '
        Me.colActualShipmentDate.Caption = "Ship Date"
        Me.colActualShipmentDate.FieldName = "ActualShipmentDate"
        Me.colActualShipmentDate.Name = "colActualShipmentDate"
        Me.colActualShipmentDate.Visible = True
        Me.colActualShipmentDate.VisibleIndex = 4
        Me.colActualShipmentDate.Width = 76
        '
        'colPlannedDeliveryDate1
        '
        Me.colPlannedDeliveryDate1.Caption = "Delv Date"
        Me.colPlannedDeliveryDate1.FieldName = "PlannedDeliveryDate"
        Me.colPlannedDeliveryDate1.Name = "colPlannedDeliveryDate1"
        Me.colPlannedDeliveryDate1.Visible = True
        Me.colPlannedDeliveryDate1.VisibleIndex = 5
        Me.colPlannedDeliveryDate1.Width = 74
        '
        'colLoadType1
        '
        Me.colLoadType1.FieldName = "LoadType"
        Me.colLoadType1.Name = "colLoadType1"
        Me.colLoadType1.Visible = True
        Me.colLoadType1.VisibleIndex = 6
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 7
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 8
        '
        'colUnits
        '
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.Visible = True
        Me.colUnits.VisibleIndex = 9
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 10
        Me.colUom.Width = 45
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 11
        Me.colProductid.Width = 45
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 12
        Me.colProductdesc.Width = 343
        '
        'RepositoryItemLookUpEdit7
        '
        Me.RepositoryItemLookUpEdit7.AutoHeight = False
        Me.RepositoryItemLookUpEdit7.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcountry", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit7.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit7.Name = "RepositoryItemLookUpEdit7"
        Me.RepositoryItemLookUpEdit7.ValueMember = "Custname"
        '
        'CustomDevExGridView2
        '
        Me.CustomDevExGridView2.GridControl = Me.GridControl1
        Me.CustomDevExGridView2.Name = "CustomDevExGridView2"
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Controls.Add(Me.GroupControl4)
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1268, 600)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.PanelControl4)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1252, 584)
        Me.GroupControl4.TabIndex = 4
        Me.GroupControl4.Text = "DELIVERED LOADS"
        '
        'PanelControl4
        '
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.grDeliveredLoads)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(2, 20)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(1248, 562)
        Me.PanelControl4.TabIndex = 0
        '
        'grDeliveredLoads
        '
        Me.grDeliveredLoads.DataSource = Me.bsDeliveredLoads
        Me.grDeliveredLoads.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grDeliveredLoads.Location = New System.Drawing.Point(0, 0)
        Me.grDeliveredLoads.MainView = Me.GridView7
        Me.grDeliveredLoads.Name = "grDeliveredLoads"
        Me.grDeliveredLoads.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit4})
        Me.grDeliveredLoads.Size = New System.Drawing.Size(1248, 562)
        Me.grDeliveredLoads.TabIndex = 0
        Me.grDeliveredLoads.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7, Me.GridView8})
        '
        'bsDeliveredLoads
        '
        Me.bsDeliveredLoads.DataSource = GetType(AOS.BusinessObjects.ViewLoadSummaryCollection)
        '
        'GridView7
        '
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn40, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn44, Me.GridColumn45, Me.GridColumn46, Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn76, Me.GridColumn39, Me.GridColumn38, Me.colTotalSkids1, Me.GridColumn50, Me.GridColumn51, Me.GridColumn74})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView7.GridControl = Me.grDeliveredLoads
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GridView7.OptionsView.ShowAutoFilterRow = True
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.OptionsView.ShowIndicator = False
        '
        'GridColumn35
        '
        Me.GridColumn35.FieldName = "LoadID"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 0
        Me.GridColumn35.Width = 42
        '
        'GridColumn36
        '
        Me.GridColumn36.FieldName = "LoadStatus"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 1
        Me.GridColumn36.Width = 55
        '
        'GridColumn37
        '
        Me.GridColumn37.FieldName = "LoadType"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 2
        Me.GridColumn37.Width = 52
        '
        'GridColumn40
        '
        Me.GridColumn40.FieldName = "OriginType"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 4
        Me.GridColumn40.Width = 71
        '
        'GridColumn41
        '
        Me.GridColumn41.FieldName = "OriginName"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 5
        Me.GridColumn41.Width = 71
        '
        'GridColumn42
        '
        Me.GridColumn42.FieldName = "OriginCity"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 6
        Me.GridColumn42.Width = 71
        '
        'GridColumn43
        '
        Me.GridColumn43.FieldName = "OriginState"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 7
        Me.GridColumn43.Width = 71
        '
        'GridColumn44
        '
        Me.GridColumn44.FieldName = "DestType"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 8
        Me.GridColumn44.Width = 71
        '
        'GridColumn45
        '
        Me.GridColumn45.FieldName = "DestName"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 9
        Me.GridColumn45.Width = 71
        '
        'GridColumn46
        '
        Me.GridColumn46.FieldName = "DestCity"
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.Visible = True
        Me.GridColumn46.VisibleIndex = 10
        Me.GridColumn46.Width = 71
        '
        'GridColumn47
        '
        Me.GridColumn47.FieldName = "DestState"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 11
        Me.GridColumn47.Width = 60
        '
        'GridColumn48
        '
        Me.GridColumn48.FieldName = "CarrierID"
        Me.GridColumn48.Name = "GridColumn48"
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "Sched Carrier"
        Me.GridColumn49.FieldName = "ScheduledCarrierName"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 12
        Me.GridColumn49.Width = 128
        '
        'GridColumn76
        '
        Me.GridColumn76.Caption = "Carrier Pro#"
        Me.GridColumn76.FieldName = "CarrierProNumber"
        Me.GridColumn76.Name = "GridColumn76"
        Me.GridColumn76.Visible = True
        Me.GridColumn76.VisibleIndex = 13
        Me.GridColumn76.Width = 78
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "Shipped"
        Me.GridColumn39.FieldName = "ActualShipmentDate"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 14
        Me.GridColumn39.Width = 72
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "Delivered"
        Me.GridColumn38.FieldName = "ActualDeliveryDate"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 15
        Me.GridColumn38.Width = 65
        '
        'colTotalSkids1
        '
        Me.colTotalSkids1.Caption = "Skids"
        Me.colTotalSkids1.FieldName = "TotalSkids"
        Me.colTotalSkids1.Name = "colTotalSkids1"
        Me.colTotalSkids1.Visible = True
        Me.colTotalSkids1.VisibleIndex = 16
        '
        'GridColumn50
        '
        Me.GridColumn50.FieldName = "Pallets"
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 17
        Me.GridColumn50.Width = 55
        '
        'GridColumn51
        '
        Me.GridColumn51.FieldName = "GrossWt"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.Visible = True
        Me.GridColumn51.VisibleIndex = 18
        Me.GridColumn51.Width = 79
        '
        'GridColumn74
        '
        Me.GridColumn74.Caption = "WO#"
        Me.GridColumn74.FieldName = "WorkOrderNumbers"
        Me.GridColumn74.Name = "GridColumn74"
        Me.GridColumn74.Visible = True
        Me.GridColumn74.VisibleIndex = 3
        Me.GridColumn74.Width = 63
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcountry", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.ValueMember = "Custname"
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.grDeliveredLoads
        Me.GridView8.Name = "GridView8"
        '
        'RibbonPanelControl7
        '
        Me.RibbonPanelControl7.Controls.Add(Me.GroupControl7)
        Me.RibbonPanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl7.Name = "RibbonPanelControl7"
        Me.RibbonPanelControl7.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl7.Size = New System.Drawing.Size(1268, 600)
        Me.RibbonPanelControl7.TabIndex = 4
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(MaxLoadWeightLabel)
        Me.GroupControl7.Controls.Add(Me.MaxLoadWeightTextEdit)
        Me.GroupControl7.Controls.Add(FreezeWarningLabel)
        Me.GroupControl7.Controls.Add(Me.eFreeze)
        Me.GroupControl7.Location = New System.Drawing.Point(15, 17)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(245, 108)
        Me.GroupControl7.TabIndex = 0
        Me.GroupControl7.Text = "Current Freight Management Settings"
        '
        'MaxLoadWeightTextEdit
        '
        Me.MaxLoadWeightTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "MaxLoadWeight", True))
        Me.MaxLoadWeightTextEdit.Location = New System.Drawing.Point(111, 61)
        Me.MaxLoadWeightTextEdit.MenuManager = Me.RibbonControl1
        Me.MaxLoadWeightTextEdit.Name = "MaxLoadWeightTextEdit"
        Me.MaxLoadWeightTextEdit.Properties.ReadOnly = True
        Me.MaxLoadWeightTextEdit.Size = New System.Drawing.Size(73, 20)
        Me.MaxLoadWeightTextEdit.TabIndex = 3
        '
        'bsParms
        '
        Me.bsParms.DataSource = GetType(AOS.BusinessObjects.Sysparameters)
        '
        'eFreeze
        '
        Me.eFreeze.Location = New System.Drawing.Point(109, 36)
        Me.eFreeze.MenuManager = Me.RibbonControl1
        Me.eFreeze.Name = "eFreeze"
        Me.eFreeze.Properties.Caption = ""
        Me.eFreeze.Properties.ReadOnly = True
        Me.eFreeze.Size = New System.Drawing.Size(75, 19)
        Me.eFreeze.TabIndex = 1
        '
        'RibbonPanelControl6
        '
        Me.RibbonPanelControl6.Controls.Add(Me.gcCarriers)
        Me.RibbonPanelControl6.Controls.Add(Me.gcLogisticsProviders)
        Me.RibbonPanelControl6.Controls.Add(Me.gcCustomers)
        Me.RibbonPanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl6.Name = "RibbonPanelControl6"
        Me.RibbonPanelControl6.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl6.Size = New System.Drawing.Size(1268, 600)
        Me.RibbonPanelControl6.TabIndex = 1
        '
        'gcCarriers
        '
        Me.gcCarriers.Controls.Add(Me.dgvCarrier)
        Me.gcCarriers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCarriers.Location = New System.Drawing.Point(8, 8)
        Me.gcCarriers.Name = "gcCarriers"
        Me.gcCarriers.Size = New System.Drawing.Size(1252, 584)
        Me.gcCarriers.TabIndex = 1
        Me.gcCarriers.Text = "CARRIERS"
        Me.gcCarriers.Visible = False
        '
        'dgvCarrier
        '
        Me.dgvCarrier.DataSource = Me.bsCarriers
        Me.dgvCarrier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCarrier.Location = New System.Drawing.Point(2, 20)
        Me.dgvCarrier.MainView = Me.GridView12
        Me.dgvCarrier.Name = "dgvCarrier"
        Me.dgvCarrier.Size = New System.Drawing.Size(1248, 562)
        Me.dgvCarrier.TabIndex = 1
        Me.dgvCarrier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView12, Me.GridView13})
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'GridView12
        '
        Me.GridView12.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn69, Me.GridColumn70, Me.colCarrierCity, Me.colCarrierState, Me.colCarrierContactName, Me.colTermsCarrier})
        Me.GridView12.GridControl = Me.dgvCarrier
        Me.GridView12.Name = "GridView12"
        Me.GridView12.OptionsBehavior.Editable = False
        Me.GridView12.OptionsView.ShowGroupPanel = False
        Me.GridView12.OptionsView.ShowIndicator = False
        '
        'GridColumn69
        '
        Me.GridColumn69.Caption = "Carrier ID"
        Me.GridColumn69.FieldName = "CarrierID"
        Me.GridColumn69.Name = "GridColumn69"
        Me.GridColumn69.Visible = True
        Me.GridColumn69.VisibleIndex = 0
        Me.GridColumn69.Width = 57
        '
        'GridColumn70
        '
        Me.GridColumn70.Caption = "Carrier Name"
        Me.GridColumn70.FieldName = "CarrierName"
        Me.GridColumn70.Name = "GridColumn70"
        Me.GridColumn70.Visible = True
        Me.GridColumn70.VisibleIndex = 1
        Me.GridColumn70.Width = 268
        '
        'colCarrierCity
        '
        Me.colCarrierCity.Caption = "City"
        Me.colCarrierCity.FieldName = "CarrierCity"
        Me.colCarrierCity.Name = "colCarrierCity"
        Me.colCarrierCity.Visible = True
        Me.colCarrierCity.VisibleIndex = 2
        Me.colCarrierCity.Width = 202
        '
        'colCarrierState
        '
        Me.colCarrierState.Caption = "State"
        Me.colCarrierState.FieldName = "CarrierState"
        Me.colCarrierState.Name = "colCarrierState"
        Me.colCarrierState.Visible = True
        Me.colCarrierState.VisibleIndex = 3
        Me.colCarrierState.Width = 45
        '
        'colCarrierContactName
        '
        Me.colCarrierContactName.Caption = "Contact"
        Me.colCarrierContactName.FieldName = "CarrierContactName"
        Me.colCarrierContactName.Name = "colCarrierContactName"
        Me.colCarrierContactName.Visible = True
        Me.colCarrierContactName.VisibleIndex = 4
        Me.colCarrierContactName.Width = 293
        '
        'colTermsCarrier
        '
        Me.colTermsCarrier.Caption = "Terms"
        Me.colTermsCarrier.FieldName = "TermsCarrier"
        Me.colTermsCarrier.Name = "colTermsCarrier"
        Me.colTermsCarrier.Visible = True
        Me.colTermsCarrier.VisibleIndex = 5
        Me.colTermsCarrier.Width = 429
        '
        'GridView13
        '
        Me.GridView13.GridControl = Me.dgvCarrier
        Me.GridView13.Name = "GridView13"
        '
        'gcLogisticsProviders
        '
        Me.gcLogisticsProviders.Controls.Add(Me.dgLogistics)
        Me.gcLogisticsProviders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLogisticsProviders.Location = New System.Drawing.Point(8, 8)
        Me.gcLogisticsProviders.Name = "gcLogisticsProviders"
        Me.gcLogisticsProviders.Size = New System.Drawing.Size(1252, 584)
        Me.gcLogisticsProviders.TabIndex = 2
        Me.gcLogisticsProviders.Text = "LOGISTICS PROVIDERS"
        Me.gcLogisticsProviders.Visible = False
        '
        'dgLogistics
        '
        Me.dgLogistics.DataSource = Me.bsLogistics
        Me.dgLogistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLogistics.Location = New System.Drawing.Point(2, 20)
        Me.dgLogistics.MainView = Me.GridView14
        Me.dgLogistics.Name = "dgLogistics"
        Me.dgLogistics.Size = New System.Drawing.Size(1248, 562)
        Me.dgLogistics.TabIndex = 1
        Me.dgLogistics.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView14, Me.GridView15})
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'GridView14
        '
        Me.GridView14.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLogisticsid, Me.colLogisticsname, Me.colLogisticsaddr1, Me.colLogisticsaddr2, Me.colLogisticscity, Me.colLogisticsstate, Me.colLogisticszip, Me.colLogisticsphone, Me.colLogisticscontact})
        Me.GridView14.GridControl = Me.dgLogistics
        Me.GridView14.Name = "GridView14"
        Me.GridView14.OptionsBehavior.Editable = False
        Me.GridView14.OptionsView.ShowGroupPanel = False
        Me.GridView14.OptionsView.ShowIndicator = False
        '
        'colLogisticsid
        '
        Me.colLogisticsid.Caption = "ID"
        Me.colLogisticsid.FieldName = "Logisticsid"
        Me.colLogisticsid.Name = "colLogisticsid"
        Me.colLogisticsid.Visible = True
        Me.colLogisticsid.VisibleIndex = 0
        Me.colLogisticsid.Width = 45
        '
        'colLogisticsname
        '
        Me.colLogisticsname.Caption = "Provider Name"
        Me.colLogisticsname.FieldName = "Logisticsname"
        Me.colLogisticsname.Name = "colLogisticsname"
        Me.colLogisticsname.Visible = True
        Me.colLogisticsname.VisibleIndex = 1
        Me.colLogisticsname.Width = 219
        '
        'colLogisticsaddr1
        '
        Me.colLogisticsaddr1.Caption = "Address 1"
        Me.colLogisticsaddr1.FieldName = "Logisticsaddr1"
        Me.colLogisticsaddr1.Name = "colLogisticsaddr1"
        Me.colLogisticsaddr1.Visible = True
        Me.colLogisticsaddr1.VisibleIndex = 2
        Me.colLogisticsaddr1.Width = 214
        '
        'colLogisticsaddr2
        '
        Me.colLogisticsaddr2.Caption = "Address 2"
        Me.colLogisticsaddr2.FieldName = "Logisticsaddr2"
        Me.colLogisticsaddr2.Name = "colLogisticsaddr2"
        Me.colLogisticsaddr2.Visible = True
        Me.colLogisticsaddr2.VisibleIndex = 3
        Me.colLogisticsaddr2.Width = 200
        '
        'colLogisticscity
        '
        Me.colLogisticscity.Caption = "City"
        Me.colLogisticscity.FieldName = "Logisticscity"
        Me.colLogisticscity.Name = "colLogisticscity"
        Me.colLogisticscity.Visible = True
        Me.colLogisticscity.VisibleIndex = 4
        Me.colLogisticscity.Width = 178
        '
        'colLogisticsstate
        '
        Me.colLogisticsstate.Caption = "State"
        Me.colLogisticsstate.FieldName = "Logisticsstate"
        Me.colLogisticsstate.Name = "colLogisticsstate"
        Me.colLogisticsstate.Visible = True
        Me.colLogisticsstate.VisibleIndex = 5
        Me.colLogisticsstate.Width = 54
        '
        'colLogisticszip
        '
        Me.colLogisticszip.Caption = "Zipcode"
        Me.colLogisticszip.FieldName = "Logisticszip"
        Me.colLogisticszip.Name = "colLogisticszip"
        Me.colLogisticszip.Visible = True
        Me.colLogisticszip.VisibleIndex = 6
        Me.colLogisticszip.Width = 82
        '
        'colLogisticsphone
        '
        Me.colLogisticsphone.Caption = "Phone"
        Me.colLogisticsphone.FieldName = "Logisticsphone"
        Me.colLogisticsphone.Name = "colLogisticsphone"
        Me.colLogisticsphone.Visible = True
        Me.colLogisticsphone.VisibleIndex = 7
        Me.colLogisticsphone.Width = 106
        '
        'colLogisticscontact
        '
        Me.colLogisticscontact.Caption = "Contact Name"
        Me.colLogisticscontact.FieldName = "Logisticscontact"
        Me.colLogisticscontact.Name = "colLogisticscontact"
        Me.colLogisticscontact.Visible = True
        Me.colLogisticscontact.VisibleIndex = 8
        Me.colLogisticscontact.Width = 196
        '
        'GridView15
        '
        Me.GridView15.GridControl = Me.dgLogistics
        Me.GridView15.Name = "GridView15"
        '
        'gcCustomers
        '
        Me.gcCustomers.Controls.Add(Me.PanelControl9)
        Me.gcCustomers.Controls.Add(Me.GroupControl6)
        Me.gcCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCustomers.Location = New System.Drawing.Point(8, 8)
        Me.gcCustomers.Name = "gcCustomers"
        Me.gcCustomers.Size = New System.Drawing.Size(1252, 584)
        Me.gcCustomers.TabIndex = 0
        Me.gcCustomers.Text = "CUSTOMERS"
        Me.gcCustomers.Visible = False
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
        Me.PanelControl9.Location = New System.Drawing.Point(364, 20)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(886, 562)
        Me.PanelControl9.TabIndex = 4
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
        Me.GroupControl15.Size = New System.Drawing.Size(367, 80)
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
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
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
        Me.GroupControl14.Size = New System.Drawing.Size(368, 244)
        Me.GroupControl14.TabIndex = 48
        Me.GroupControl14.Text = "Miscellaneous Information"
        '
        'MemoEdit3
        '
        Me.MemoEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Invoicenote", True))
        Me.MemoEdit3.Location = New System.Drawing.Point(82, 184)
        Me.MemoEdit3.MenuManager = Me.RibbonControl1
        Me.MemoEdit3.Name = "MemoEdit3"
        Me.MemoEdit3.Properties.ReadOnly = True
        Me.MemoEdit3.Size = New System.Drawing.Size(280, 46)
        Me.MemoEdit3.TabIndex = 52
        Me.MemoEdit3.TabStop = False
        '
        'MemoEdit2
        '
        Me.MemoEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Shipmentnote", True))
        Me.MemoEdit2.Location = New System.Drawing.Point(82, 132)
        Me.MemoEdit2.MenuManager = Me.RibbonControl1
        Me.MemoEdit2.Name = "MemoEdit2"
        Me.MemoEdit2.Properties.ReadOnly = True
        Me.MemoEdit2.Size = New System.Drawing.Size(280, 46)
        Me.MemoEdit2.TabIndex = 51
        Me.MemoEdit2.TabStop = False
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Ordernote", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(82, 80)
        Me.MemoEdit1.MenuManager = Me.RibbonControl1
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.ReadOnly = True
        Me.MemoEdit1.Size = New System.Drawing.Size(280, 46)
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
        Me.CustnotesMemoEdit.Size = New System.Drawing.Size(280, 46)
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
        Me.CarrieridLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.CarrieridLookUpEdit.Properties.NullText = ""
        Me.CarrieridLookUpEdit.Properties.ReadOnly = True
        Me.CarrieridLookUpEdit.Properties.ValueMember = "CarrierID"
        Me.CarrieridLookUpEdit.Size = New System.Drawing.Size(280, 20)
        Me.CarrieridLookUpEdit.TabIndex = 43
        Me.CarrieridLookUpEdit.TabStop = False
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
        Me.BulkcarrieridLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.BulkcarrieridLookUpEdit.Properties.NullText = ""
        Me.BulkcarrieridLookUpEdit.Properties.ReadOnly = True
        Me.BulkcarrieridLookUpEdit.Properties.ValueMember = "CarrierID"
        Me.BulkcarrieridLookUpEdit.Size = New System.Drawing.Size(280, 20)
        Me.BulkcarrieridLookUpEdit.TabIndex = 45
        Me.BulkcarrieridLookUpEdit.TabStop = False
        '
        'LogisticsidLookUpEdit
        '
        Me.LogisticsidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Logisticsid", True))
        Me.LogisticsidLookUpEdit.Location = New System.Drawing.Point(82, 50)
        Me.LogisticsidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.LogisticsidLookUpEdit.Name = "LogisticsidLookUpEdit"
        Me.LogisticsidLookUpEdit.Properties.DisplayMember = "Logisticsname"
        Me.LogisticsidLookUpEdit.Properties.NullText = ""
        Me.LogisticsidLookUpEdit.Properties.ReadOnly = True
        Me.LogisticsidLookUpEdit.Properties.ValueMember = "Logisticsid"
        Me.LogisticsidLookUpEdit.Size = New System.Drawing.Size(280, 20)
        Me.LogisticsidLookUpEdit.TabIndex = 44
        Me.LogisticsidLookUpEdit.TabStop = False
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
        'SalespersonidLookUpEdit
        '
        Me.SalespersonidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomers, "Salespersonid", True))
        Me.SalespersonidLookUpEdit.Location = New System.Drawing.Point(593, 23)
        Me.SalespersonidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.SalespersonidLookUpEdit.Name = "SalespersonidLookUpEdit"
        Me.SalespersonidLookUpEdit.Properties.DisplayMember = "Salespersonfullname"
        Me.SalespersonidLookUpEdit.Properties.NullText = ""
        Me.SalespersonidLookUpEdit.Properties.ReadOnly = True
        Me.SalespersonidLookUpEdit.Properties.ValueMember = "Salespersonid"
        Me.SalespersonidLookUpEdit.Size = New System.Drawing.Size(142, 20)
        Me.SalespersonidLookUpEdit.TabIndex = 49
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
        Me.IsactiveCheckEdit.Properties.Caption = ""
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
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.grCustomers)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl6.Location = New System.Drawing.Point(2, 20)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(362, 562)
        Me.GroupControl6.TabIndex = 3
        Me.GroupControl6.Text = "Customer List"
        '
        'grCustomers
        '
        Me.grCustomers.DataSource = Me.bsCustomers
        Me.grCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCustomers.Location = New System.Drawing.Point(2, 20)
        Me.grCustomers.LookAndFeel.SkinName = "Money Twins"
        Me.grCustomers.MainView = Me.GridView11
        Me.grCustomers.Name = "grCustomers"
        Me.grCustomers.Size = New System.Drawing.Size(358, 540)
        Me.grCustomers.TabIndex = 0
        Me.grCustomers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView11})
        '
        'GridView11
        '
        Me.GridView11.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView11.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView11.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView11.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView11.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView11.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView11.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView11.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView11.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView11.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView11.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView11.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView11.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView11.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView11.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView11.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView11.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView11.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView11.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView11.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView11.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView11.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView11.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView11.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView11.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView11.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView11.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView11.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView11.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView11.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView11.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView11.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView11.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView11.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustid, Me.colCustname})
        Me.GridView11.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView11.GridControl = Me.grCustomers
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsBehavior.Editable = False
        Me.GridView11.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView11.OptionsView.ShowGroupPanel = False
        Me.GridView11.OptionsView.ShowIndicator = False
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
        'RibbonPanelControl9
        '
        Me.RibbonPanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl9.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl9.Name = "RibbonPanelControl9"
        Me.RibbonPanelControl9.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl9.Size = New System.Drawing.Size(1268, 600)
        Me.RibbonPanelControl9.TabIndex = 6
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer_RefreshData
        '
        Me.Timer_RefreshData.Interval = 30000
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Mark As Returned"
        Me.BarButtonItem1.Id = 67
        Me.BarButtonItem1.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.document__2_
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'ImageCollection2
        '
        Me.ImageCollection2.ImageStream = CType(resources.GetObject("ImageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'Timer2
        '
        '
        'viewFreightDashboard
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.Name = "viewFreightDashboard"
        Me.Size = New System.Drawing.Size(1268, 749)
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grPendingLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPendingLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPendingLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlColorMapping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlColorMapping.ResumeLayout(False)
        Me.pnlColorMapping.PerformLayout()
        CType(Me.lblRedColor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl5.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.grCancelledLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCancelledLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grScheduledLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsScheduledLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grInTransitLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInTransitLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl8.ResumeLayout(False)
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomerShipmentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCustomerShipmentHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDevExGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl4.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.grDeliveredLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDeliveredLoads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl7.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.MaxLoadWeightTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsParms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFreeze.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl6.ResumeLayout(False)
        CType(Me.gcCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcCarriers.ResumeLayout(False)
        CType(Me.dgvCarrier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcLogisticsProviders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcLogisticsProviders.ResumeLayout(False)
        CType(Me.dgLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcCustomers.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.GroupControl15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl15.ResumeLayout(False)
        Me.GroupControl15.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.FobTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BulkcarrieridLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogisticsidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.SalespersonidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustnameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.grCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents grHeader As CustomDevExGridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents rbtnPendingAddLoad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPendingEditLoad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RibbonPanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grPendingLoads As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsPendingLoads As System.Windows.Forms.BindingSource
    Friend WithEvents rbtnRetrievePendingLoads As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPendingMarkAsCancelled As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnMergeLoads As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup26 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnRetrieveScheduledLoads As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rtbnScheduledLoadEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintBOL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnScheduledMarkAsPending As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnScheduledMarkAsInTransit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnScheduledMarkAsCancelled As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnRetrieveInTransitLoads As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grScheduledLoads As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grCancelledLoads As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As CustomDevExGridView
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn67 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn68 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView10 As CustomDevExGridView
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grDeliveredLoads As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView7 As CustomDevExGridView
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView8 As CustomDevExGridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grInTransitLoads As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As CustomDevExGridView
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView6 As CustomDevExGridView
    Friend WithEvents bsDeliveredLoads As System.Windows.Forms.BindingSource
    Friend WithEvents bsCancelledLoads As System.Windows.Forms.BindingSource
    Friend WithEvents bsScheduledLoads As System.Windows.Forms.BindingSource
    Friend WithEvents bsInTransitLoads As System.Windows.Forms.BindingSource
    Friend WithEvents rbtnInTransitMarkAsReturned As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnRetrieveDeliveredLoads As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnReprintBOL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeliveredMarkAsInTransit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup14 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup16 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup15 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Timer_RefreshData As System.Windows.Forms.Timer
    Friend WithEvents rbtnRetrieveCancelledLoads As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnRetrieveCustomers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnRetrieveCarriers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddNewCarrier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditCarrier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteCarrier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnRetrieveLogisiticsProviders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddNewLogisticsProvider As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditLogisticsProvider As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteLogisticsProvider As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents gcCustomers As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcLogisticsProviders As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcCarriers As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl15 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustphoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustfaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl14 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents MemoEdit3 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit2 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CustnotesMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl13 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents FreightoninvoiceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents FreightbillcustomerCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CarrieridLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FobTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BulkcarrieridLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LogisticsidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents GroupControl12 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents CustbillcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custbilladdress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillpostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custbilladdress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillcountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustbillcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl11 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Custshipaddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Custshipaddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshippostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipcountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CustshipcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SalespersonidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents CustidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents IsactiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CustnameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grCustomers As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView11 As CustomDevExGridView
    Friend WithEvents colCustid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents dgvCarrier As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView12 As CustomDevExGridView
    Friend WithEvents GridColumn69 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn70 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierContactName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTermsCarrier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView13 As CustomDevExGridView
    Friend WithEvents dgLogistics As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView14 As CustomDevExGridView
    Friend WithEvents colLogisticsid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsaddr1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsaddr2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticscity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsstate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticszip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticscontact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView15 As CustomDevExGridView
    Friend WithEvents rbtnEditFreightSettings As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPage7 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnInTransitMarkAsDelivered As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnProcessLoad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsParms As System.Windows.Forms.BindingSource
    Friend WithEvents eFreeze As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents MaxLoadWeightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImageCollection2 As DevExpress.Utils.ImageCollection
    Friend WithEvents GridColumn75 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn74 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn73 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn72 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn76 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnPrintRptFutureShipments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage8 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents eHistoryStart As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents eHistoryEnd As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents eCustomerSelector As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RibbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsCustomerShipmentHistory As BindingSource
    Friend grvCustomerShipmentHistory As CustomDevExGridView
    Friend WithEvents colCustid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrdertype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualShipmentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedDeliveryDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadType1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend CustomDevExGridView2 As CustomDevExGridView
    Friend WithEvents rBtnFetchShipmentHistory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnExportHistory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsCustomers2 As BindingSource
    Friend WithEvents colTotalSkids3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSkids2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSkids1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSkids4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlColorMapping As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblRedDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblRedColor As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColorEdit4 As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents ColorEdit3 As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents ColorEdit2 As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents ColorEdit1 As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents grvPendingLoads As CustomDevExGridView 'DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colLoadID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedDepartureDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPallets As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSkids As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrossWt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWONumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents colWorkOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFreezeprotectflag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrSoonerFlag As DevExpress.XtraGrid.Columns.GridColumn
End Class
