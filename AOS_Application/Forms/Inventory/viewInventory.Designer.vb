<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewInventory

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewInventory))
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemDateEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.RepositoryItemCheckedComboBoxEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit()
        Me.bsItemStatus = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepositoryItemLookUpEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsInventoryClass = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsInventoryItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAddProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintProductLabel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintItemLabel = New DevExpress.XtraBars.BarButtonItem()
        Me.eQtyAvailable = New DevExpress.XtraBars.BarEditItem()
        Me.eQtyAllocated = New DevExpress.XtraBars.BarEditItem()
        Me.eQtyOnOrder = New DevExpress.XtraBars.BarEditItem()
        Me.btnPrintMiniLabel = New DevExpress.XtraBars.BarButtonItem()
        Me.stQtyOnHand = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnRecalculateInventoryQuantities = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.btnAddPO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeletePO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddReceiver = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditReceiver = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteReceiver = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPostReceiver = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintMiniLabel_Receiving = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintProductLabelBarcoded = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFetchFinishedGoods = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintMiniInventoryLabels = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnViewAvailableInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintAvailableInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintAvailableInventoryByBin = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMaintainProducts = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCloseWorkOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.btnInventoryFloorReport = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.eReportStartDate = New DevExpress.XtraBars.BarEditItem()
        Me.eReportEndDate = New DevExpress.XtraBars.BarEditItem()
        Me.btnPLReport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptInventoryDetail = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOnFloorValuationReport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptInventoryDetailAvailableOnly = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCopyProductToNew = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFetchRawMaterials = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.filterItemStatus = New DevExpress.XtraBars.BarEditItem()
        Me.filterItemType = New DevExpress.XtraBars.BarEditItem()
        Me.btnItemDetails = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFixItems = New DevExpress.XtraBars.BarButtonItem()
        Me.btnManageContainers = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProductFulfillment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintWOSales = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintMaxItemsbyStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintWOBarcodesReport = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintTotalInventoryByProduct = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnInventoryAnalysisShortList = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRptInventoryAnalysisAll = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCurrentPhysicalInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnInventoryAnalysisNonShortList = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCurrentQuarantined = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPLNReport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnVIEWCOMPONENTS = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddComponent = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditComponent = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteComponent = New DevExpress.XtraBars.BarButtonItem()
        Me.btnVIEWKITS = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddKit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditKit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteKit = New DevExpress.XtraBars.BarButtonItem()
        Me.rRptStartDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.rRptEndDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.rbtnPrintRelabelOrdersSummary = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterFinishedGoods = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterRawMaterial = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterProductsActive = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterProductsInActive = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterProductsAll = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintGHSLabel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintGHSLabelByProductOnly = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFilterProductsPending = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintSDSReport = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAllItems = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnProductSalesHistory = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnProductPurchaseHistory = New DevExpress.XtraBars.BarButtonItem()
        Me.Ribbon_LargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup15 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup21 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup22 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup17 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup20 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage6 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup16 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.bsItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grpInventoryItems = New DevExpress.XtraEditors.GroupControl()
        Me.grInventoryItems = New DevExpress.XtraGrid.GridControl()
        Me.InventoryList = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvitemnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehousenumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEditWarehouse = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsWarehouse = New System.Windows.Forms.BindingSource(Me.components)
        Me.colWarehouselocation2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colContainer2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveddate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippeddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.LayoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
        Me.GridView12 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.gcProducts = New DevExpress.XtraEditors.GroupControl()
        Me.grProducts = New DevExpress.XtraGrid.GridControl()
        Me.ProductsView = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChemicalid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChemicalname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView15 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grItems = New DevExpress.XtraGrid.GridControl()
        Me.InventoryItemsView = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colWarehouselocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView13 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.pnlKitHolder = New DevExpress.XtraEditors.PanelControl()
        Me.gcKit = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl5 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl13 = New DevExpress.XtraEditors.GroupControl()
        Me.grKit = New DevExpress.XtraGrid.GridControl()
        Me.bsKit = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView11 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colKitid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKitname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKitCost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView7 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GroupControl12 = New DevExpress.XtraEditors.GroupControl()
        Me.grKitItem = New DevExpress.XtraGrid.GridControl()
        Me.bsKitItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView10 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colComponentqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComponentid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vendordesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Unitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit18 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit19 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GridView5 = New AOS.CustomClasses.CustomDevExGridView()
        Me.pnlComponentHolder = New DevExpress.XtraEditors.PanelControl()
        Me.gcComponent = New DevExpress.XtraEditors.PanelControl()
        Me.SplitContainerControl4 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.grComponents = New DevExpress.XtraGrid.GridControl()
        Me.bsComponent = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView8 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colComponentID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComponentdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendordesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendoritemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.grAltComponents = New DevExpress.XtraGrid.GridControl()
        Me.bsAltComponent = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView9 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colAltComponentid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAltComponentdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAltVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAltVendordesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAltVendoritemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAltUnitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.grWorkOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsWorkOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colWorkordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.colCustorderdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerpo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedshipdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliverydate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bsReceiverItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsReceivers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsRawMaterialItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsWorkOrderItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPurchaseOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.GridView14 = New AOS.CustomClasses.CustomDevExGridView()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItemStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.grpInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInventoryItems.SuspendLayout()
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEditWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWarehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.gcProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcProducts.SuspendLayout()
        CType(Me.grProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryItemsView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.pnlKitHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKitHolder.SuspendLayout()
        CType(Me.gcKit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcKit.SuspendLayout()
        CType(Me.SplitContainerControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl5.SuspendLayout()
        CType(Me.GroupControl13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl13.SuspendLayout()
        CType(Me.grKit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl12.SuspendLayout()
        CType(Me.grKitItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsKitItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlComponentHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlComponentHolder.SuspendLayout()
        CType(Me.gcComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcComponent.SuspendLayout()
        CType(Me.SplitContainerControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl4.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.grComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.grAltComponents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAltComponent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl7.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.grWorkOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWorkOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsReceiverItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsReceivers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRawMaterialItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWorkOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.Appearance.Options.UseTextOptions = True
        Me.RepositoryItemTextEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.RepositoryItemTextEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.RepositoryItemTextEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        Me.RepositoryItemTextEdit1.ReadOnly = True
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        Me.RepositoryItemTextEdit4.ReadOnly = True
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'RepositoryItemDateEdit3
        '
        Me.RepositoryItemDateEdit3.AutoHeight = False
        Me.RepositoryItemDateEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit3.Name = "RepositoryItemDateEdit3"
        '
        'RepositoryItemCheckedComboBoxEdit1
        '
        Me.RepositoryItemCheckedComboBoxEdit1.AutoHeight = False
        Me.RepositoryItemCheckedComboBoxEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemCheckedComboBoxEdit1.DataSource = Me.bsItemStatus
        Me.RepositoryItemCheckedComboBoxEdit1.DisplayMember = "LookupDesc"
        Me.RepositoryItemCheckedComboBoxEdit1.DropDownRows = 10
        Me.RepositoryItemCheckedComboBoxEdit1.Name = "RepositoryItemCheckedComboBoxEdit1"
        Me.RepositoryItemCheckedComboBoxEdit1.PopupFormSize = New System.Drawing.Size(100, 200)
        Me.RepositoryItemCheckedComboBoxEdit1.PopupSizeable = False
        Me.RepositoryItemCheckedComboBoxEdit1.SelectAllItemVisible = False
        Me.RepositoryItemCheckedComboBoxEdit1.ShowPopupCloseButton = False
        Me.RepositoryItemCheckedComboBoxEdit1.ValueMember = "LookupDesc"
        '
        'RepositoryItemLookUpEdit15
        '
        Me.RepositoryItemLookUpEdit15.AutoHeight = False
        Me.RepositoryItemLookUpEdit15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit15.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LookUpValue", "Look Up Value", 77, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LookupDesc", "Lookup Desc", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit15.DataSource = Me.bsInventoryClass
        Me.RepositoryItemLookUpEdit15.DisplayMember = "LookupDesc"
        Me.RepositoryItemLookUpEdit15.DropDownRows = 4
        Me.RepositoryItemLookUpEdit15.Name = "RepositoryItemLookUpEdit15"
        Me.RepositoryItemLookUpEdit15.NullText = ""
        Me.RepositoryItemLookUpEdit15.NullValuePrompt = "Select an Item Class..."
        Me.RepositoryItemLookUpEdit15.PopupSizeable = False
        Me.RepositoryItemLookUpEdit15.PopupWidth = 100
        Me.RepositoryItemLookUpEdit15.ShowFooter = False
        Me.RepositoryItemLookUpEdit15.ShowHeader = False
        Me.RepositoryItemLookUpEdit15.ValueMember = "LookupValue"
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ViewChemicalProductLinkCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAddProduct, Me.btnEditProduct, Me.btnDeleteProduct, Me.btnPrintProductLabel, Me.btnPrintItemLabel, Me.eQtyAvailable, Me.eQtyAllocated, Me.eQtyOnOrder, Me.btnPrintMiniLabel, Me.stQtyOnHand, Me.BarStaticItem2, Me.BarStaticItem3, Me.btnRecalculateInventoryQuantities, Me.BarStaticItem1, Me.btnAddPO, Me.btnEditPO, Me.btnDeletePO, Me.btnAddReceiver, Me.btnEditReceiver, Me.btnDeleteReceiver, Me.btnPostReceiver, Me.btnPrintMiniLabel_Receiving, Me.btnPrintProductLabelBarcoded, Me.btnFetchFinishedGoods, Me.btnPrintMiniInventoryLabels, Me.BarButtonItem3, Me.btnViewAvailableInventory, Me.btnPrintAvailableInventory, Me.btnPrintAvailableInventoryByBin, Me.btnMaintainProducts, Me.btnCloseWorkOrders, Me.btnInventoryFloorReport, Me.BarButtonItem2, Me.eReportStartDate, Me.eReportEndDate, Me.btnPLReport, Me.btnRptInventoryDetail, Me.btnOnFloorValuationReport, Me.btnRptInventoryDetailAvailableOnly, Me.btnCopyProductToNew, Me.btnFetchRawMaterials, Me.BarButtonItem6, Me.filterItemStatus, Me.filterItemType, Me.btnItemDetails, Me.btnFixItems, Me.btnManageContainers, Me.btnProductFulfillment, Me.btnPrintWOSales, Me.btnPrintMaxItemsbyStatus, Me.btnPrintWOBarcodesReport, Me.rbtnPrintTotalInventoryByProduct, Me.rbtnInventoryAnalysisShortList, Me.btnRptInventoryAnalysisAll, Me.rbtnCurrentPhysicalInventory, Me.rbtnInventoryAnalysisNonShortList, Me.rbtnCurrentQuarantined, Me.btnPLNReport, Me.btnVIEWCOMPONENTS, Me.btnAddComponent, Me.btnEditComponent, Me.btnDeleteComponent, Me.btnVIEWKITS, Me.btnAddKit, Me.btnEditKit, Me.btnDeleteKit, Me.rRptStartDate, Me.rRptEndDate, Me.rbtnPrintRelabelOrdersSummary, Me.rbtnFilterFinishedGoods, Me.rbtnFilterRawMaterial, Me.rbtnFilterProductsActive, Me.rbtnFilterProductsInActive, Me.rbtnFilterProductsAll, Me.rbtnPrintGHSLabel, Me.rbtnPrintGHSLabelByProductOnly, Me.rbtnFilterProductsPending, Me.rbtnPrintSDSReport, Me.rbtnAllItems, Me.rbtnProductSalesHistory, Me.rbtnProductPurchaseHistory})
        Me.RibbonControl1.LargeImages = Me.Ribbon_LargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 161
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage6})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2, Me.RepositoryItemDateEdit3, Me.RepositoryItemCheckedComboBoxEdit1, Me.RepositoryItemLookUpEdit15})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1494, 116)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Caption = " Add  Product"
        Me.btnAddProduct.Id = 0
        Me.btnAddProduct.ImageOptions.Image = CType(resources.GetObject("btnAddProduct.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddProduct.ImageOptions.ImageIndex = 0
        Me.btnAddProduct.ImageOptions.LargeImageIndex = 2
        Me.btnAddProduct.LargeWidth = 50
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Tag = "136"
        '
        'btnEditProduct
        '
        Me.btnEditProduct.Caption = "Edit  Product"
        Me.btnEditProduct.Id = 1
        Me.btnEditProduct.ImageOptions.LargeImageIndex = 3
        Me.btnEditProduct.LargeWidth = 50
        Me.btnEditProduct.Name = "btnEditProduct"
        Me.btnEditProduct.Tag = "137"
        '
        'btnDeleteProduct
        '
        Me.btnDeleteProduct.Caption = "Delete Product"
        Me.btnDeleteProduct.Id = 2
        Me.btnDeleteProduct.ImageOptions.LargeImageIndex = 4
        Me.btnDeleteProduct.LargeWidth = 50
        Me.btnDeleteProduct.Name = "btnDeleteProduct"
        Me.btnDeleteProduct.Tag = "138"
        '
        'btnPrintProductLabel
        '
        Me.btnPrintProductLabel.Caption = "Full Size Product Label"
        Me.btnPrintProductLabel.Id = 3
        Me.btnPrintProductLabel.ImageOptions.LargeImageIndex = 7
        Me.btnPrintProductLabel.Name = "btnPrintProductLabel"
        Me.btnPrintProductLabel.Tag = "140"
        Me.btnPrintProductLabel.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnPrintItemLabel
        '
        Me.btnPrintItemLabel.Caption = "Full Size Barcode"
        Me.btnPrintItemLabel.Id = 4
        Me.btnPrintItemLabel.ImageOptions.Image = CType(resources.GetObject("btnPrintItemLabel.ImageOptions.Image"), System.Drawing.Image)
        Me.btnPrintItemLabel.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintItemLabel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintItemLabel.Name = "btnPrintItemLabel"
        '
        'eQtyAvailable
        '
        Me.eQtyAvailable.CanOpenEdit = False
        Me.eQtyAvailable.Edit = Me.RepositoryItemTextEdit1
        Me.eQtyAvailable.Id = 6
        Me.eQtyAvailable.Name = "eQtyAvailable"
        '
        'eQtyAllocated
        '
        Me.eQtyAllocated.Edit = Me.RepositoryItemTextEdit1
        Me.eQtyAllocated.Id = 10
        Me.eQtyAllocated.Name = "eQtyAllocated"
        '
        'eQtyOnOrder
        '
        Me.eQtyOnOrder.Edit = Me.RepositoryItemTextEdit4
        Me.eQtyOnOrder.Id = 11
        Me.eQtyOnOrder.Name = "eQtyOnOrder"
        '
        'btnPrintMiniLabel
        '
        Me.btnPrintMiniLabel.Caption = "Mini Size Barcode"
        Me.btnPrintMiniLabel.Id = 13
        Me.btnPrintMiniLabel.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintMiniLabel.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintMiniLabel.Name = "btnPrintMiniLabel"
        '
        'stQtyOnHand
        '
        Me.stQtyOnHand.Caption = "Available"
        Me.stQtyOnHand.Id = 32
        Me.stQtyOnHand.Name = "stQtyOnHand"
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Allocated"
        Me.BarStaticItem2.Id = 33
        Me.BarStaticItem2.Name = "BarStaticItem2"
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "On Order"
        Me.BarStaticItem3.Id = 34
        Me.BarStaticItem3.Name = "BarStaticItem3"
        '
        'btnRecalculateInventoryQuantities
        '
        Me.btnRecalculateInventoryQuantities.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btnRecalculateInventoryQuantities.Caption = "Refresh"
        Me.btnRecalculateInventoryQuantities.Id = 36
        Me.btnRecalculateInventoryQuantities.ImageOptions.Image = CType(resources.GetObject("btnRecalculateInventoryQuantities.ImageOptions.Image"), System.Drawing.Image)
        Me.btnRecalculateInventoryQuantities.ImageOptions.ImageIndex = 5
        Me.btnRecalculateInventoryQuantities.ImageOptions.LargeImage = CType(resources.GetObject("btnRecalculateInventoryQuantities.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRecalculateInventoryQuantities.Name = "btnRecalculateInventoryQuantities"
        Me.btnRecalculateInventoryQuantities.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Id = 37
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'btnAddPO
        '
        Me.btnAddPO.Caption = "Add Purchase Order"
        Me.btnAddPO.Id = 41
        Me.btnAddPO.ImageOptions.Image = CType(resources.GetObject("btnAddPO.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddPO.ImageOptions.LargeImage = CType(resources.GetObject("btnAddPO.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddPO.Name = "btnAddPO"
        '
        'btnEditPO
        '
        Me.btnEditPO.Caption = "Edit Purchase Order"
        Me.btnEditPO.Id = 42
        Me.btnEditPO.ImageOptions.Image = CType(resources.GetObject("btnEditPO.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditPO.Name = "btnEditPO"
        '
        'btnDeletePO
        '
        Me.btnDeletePO.Caption = "Delete Purchase Order"
        Me.btnDeletePO.Id = 43
        Me.btnDeletePO.ImageOptions.Image = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeletePO.Name = "btnDeletePO"
        '
        'btnAddReceiver
        '
        Me.btnAddReceiver.Caption = "Add New Receiver"
        Me.btnAddReceiver.Id = 44
        Me.btnAddReceiver.ImageOptions.LargeImage = CType(resources.GetObject("btnAddReceiver.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnAddReceiver.Name = "btnAddReceiver"
        Me.btnAddReceiver.Tag = "153"
        '
        'btnEditReceiver
        '
        Me.btnEditReceiver.Caption = "Edit Receiver"
        Me.btnEditReceiver.Id = 45
        Me.btnEditReceiver.ImageOptions.Image = CType(resources.GetObject("btnEditReceiver.ImageOptions.Image"), System.Drawing.Image)
        Me.btnEditReceiver.Name = "btnEditReceiver"
        Me.btnEditReceiver.Tag = "154"
        '
        'btnDeleteReceiver
        '
        Me.btnDeleteReceiver.Caption = "Delete Receiver"
        Me.btnDeleteReceiver.Id = 46
        Me.btnDeleteReceiver.ImageOptions.Image = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteReceiver.Name = "btnDeleteReceiver"
        Me.btnDeleteReceiver.Tag = "155"
        '
        'btnPostReceiver
        '
        Me.btnPostReceiver.Caption = "Post Items to Inventory"
        Me.btnPostReceiver.Id = 48
        Me.btnPostReceiver.ImageOptions.LargeImage = CType(resources.GetObject("btnPostReceiver.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPostReceiver.Name = "btnPostReceiver"
        Me.btnPostReceiver.Tag = "156"
        '
        'btnPrintMiniLabel_Receiving
        '
        Me.btnPrintMiniLabel_Receiving.Caption = "Mini Size Barcode"
        Me.btnPrintMiniLabel_Receiving.Id = 49
        Me.btnPrintMiniLabel_Receiving.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintMiniLabel_Receiving.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintMiniLabel_Receiving.Name = "btnPrintMiniLabel_Receiving"
        Me.btnPrintMiniLabel_Receiving.Tag = "157"
        '
        'btnPrintProductLabelBarcoded
        '
        Me.btnPrintProductLabelBarcoded.Caption = "Full Size Barcode"
        Me.btnPrintProductLabelBarcoded.Id = 50
        Me.btnPrintProductLabelBarcoded.ImageOptions.LargeImage = CType(resources.GetObject("btnPrintProductLabelBarcoded.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnPrintProductLabelBarcoded.Name = "btnPrintProductLabelBarcoded"
        Me.btnPrintProductLabelBarcoded.Tag = "158"
        '
        'btnFetchFinishedGoods
        '
        Me.btnFetchFinishedGoods.Caption = "Fetch Records"
        Me.btnFetchFinishedGoods.Id = 51
        Me.btnFetchFinishedGoods.ImageOptions.Image = Global.AOS.My.Resources.Resources.Search
        Me.btnFetchFinishedGoods.ImageOptions.LargeImageIndex = 28
        Me.btnFetchFinishedGoods.LargeWidth = 60
        Me.btnFetchFinishedGoods.Name = "btnFetchFinishedGoods"
        Me.btnFetchFinishedGoods.Tag = "143"
        '
        'btnPrintMiniInventoryLabels
        '
        Me.btnPrintMiniInventoryLabels.Caption = "Mini Labels"
        Me.btnPrintMiniInventoryLabels.Id = 52
        Me.btnPrintMiniInventoryLabels.ImageOptions.LargeImageIndex = 32
        Me.btnPrintMiniInventoryLabels.LargeWidth = 60
        Me.btnPrintMiniInventoryLabels.Name = "btnPrintMiniInventoryLabels"
        Me.btnPrintMiniInventoryLabels.Tag = "147"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 53
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'btnViewAvailableInventory
        '
        Me.btnViewAvailableInventory.Caption = "View Available Items"
        Me.btnViewAvailableInventory.Id = 54
        Me.btnViewAvailableInventory.ImageOptions.LargeImage = CType(resources.GetObject("btnViewAvailableInventory.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnViewAvailableInventory.Name = "btnViewAvailableInventory"
        Me.btnViewAvailableInventory.Tag = "5"
        '
        'btnPrintAvailableInventory
        '
        Me.btnPrintAvailableInventory.Caption = "Available Items List"
        Me.btnPrintAvailableInventory.Id = 55
        Me.btnPrintAvailableInventory.ImageOptions.LargeImageIndex = 33
        Me.btnPrintAvailableInventory.LargeWidth = 60
        Me.btnPrintAvailableInventory.Name = "btnPrintAvailableInventory"
        Me.btnPrintAvailableInventory.Tag = "160"
        '
        'btnPrintAvailableInventoryByBin
        '
        Me.btnPrintAvailableInventoryByBin.Caption = "Inventory by Bin"
        Me.btnPrintAvailableInventoryByBin.Id = 62
        Me.btnPrintAvailableInventoryByBin.ImageOptions.LargeImageIndex = 33
        Me.btnPrintAvailableInventoryByBin.LargeWidth = 60
        Me.btnPrintAvailableInventoryByBin.Name = "btnPrintAvailableInventoryByBin"
        Me.btnPrintAvailableInventoryByBin.Tag = "161"
        '
        'btnMaintainProducts
        '
        Me.btnMaintainProducts.Caption = "Merge Products"
        Me.btnMaintainProducts.Id = 66
        Me.btnMaintainProducts.ImageOptions.LargeImageIndex = 47
        Me.btnMaintainProducts.LargeWidth = 70
        Me.btnMaintainProducts.Name = "btnMaintainProducts"
        Me.btnMaintainProducts.Tag = "141"
        '
        'btnCloseWorkOrders
        '
        Me.btnCloseWorkOrders.Caption = "Close Work Orders"
        Me.btnCloseWorkOrders.Id = 67
        Me.btnCloseWorkOrders.ImageOptions.Image = Global.AOS.My.Resources.Resources.Change
        Me.btnCloseWorkOrders.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Change
        Me.btnCloseWorkOrders.Name = "btnCloseWorkOrders"
        Me.btnCloseWorkOrders.Tag = "8"
        '
        'btnInventoryFloorReport
        '
        Me.btnInventoryFloorReport.Caption = "Inventory on Floor"
        Me.btnInventoryFloorReport.Id = 68
        Me.btnInventoryFloorReport.ImageOptions.Image = Global.AOS.My.Resources.Resources.Report1
        Me.btnInventoryFloorReport.ImageOptions.LargeImageIndex = 33
        Me.btnInventoryFloorReport.LargeWidth = 60
        Me.btnInventoryFloorReport.Name = "btnInventoryFloorReport"
        Me.btnInventoryFloorReport.Tag = "162"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "BarButtonItem2"
        Me.BarButtonItem2.Id = 69
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'eReportStartDate
        '
        Me.eReportStartDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.eReportStartDate.Caption = "Start Date   "
        Me.eReportStartDate.Edit = Me.RepositoryItemDateEdit2
        Me.eReportStartDate.EditWidth = 80
        Me.eReportStartDate.Id = 70
        Me.eReportStartDate.Name = "eReportStartDate"
        '
        'eReportEndDate
        '
        Me.eReportEndDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.eReportEndDate.Caption = "End Date     "
        Me.eReportEndDate.Edit = Me.RepositoryItemDateEdit3
        Me.eReportEndDate.EditWidth = 80
        Me.eReportEndDate.Id = 71
        Me.eReportEndDate.Name = "eReportEndDate"
        '
        'btnPLReport
        '
        Me.btnPLReport.Caption = "Profit && Loss (Old)"
        Me.btnPLReport.Id = 72
        Me.btnPLReport.ImageOptions.LargeImageIndex = 33
        Me.btnPLReport.LargeWidth = 60
        Me.btnPLReport.Name = "btnPLReport"
        Me.btnPLReport.Tag = "172"
        '
        'btnRptInventoryDetail
        '
        Me.btnRptInventoryDetail.Caption = "Inventory Detail"
        Me.btnRptInventoryDetail.Id = 73
        Me.btnRptInventoryDetail.ImageOptions.LargeImageIndex = 33
        Me.btnRptInventoryDetail.LargeWidth = 60
        Me.btnRptInventoryDetail.Name = "btnRptInventoryDetail"
        Me.btnRptInventoryDetail.Tag = "163"
        '
        'btnOnFloorValuationReport
        '
        Me.btnOnFloorValuationReport.Caption = "On Floor Valuation"
        Me.btnOnFloorValuationReport.Id = 74
        Me.btnOnFloorValuationReport.ImageOptions.LargeImageIndex = 33
        Me.btnOnFloorValuationReport.LargeWidth = 60
        Me.btnOnFloorValuationReport.Name = "btnOnFloorValuationReport"
        Me.btnOnFloorValuationReport.Tag = "174"
        '
        'btnRptInventoryDetailAvailableOnly
        '
        Me.btnRptInventoryDetailAvailableOnly.Caption = "Inv Detail (Available)"
        Me.btnRptInventoryDetailAvailableOnly.Id = 75
        Me.btnRptInventoryDetailAvailableOnly.ImageOptions.LargeImageIndex = 33
        Me.btnRptInventoryDetailAvailableOnly.LargeWidth = 60
        Me.btnRptInventoryDetailAvailableOnly.Name = "btnRptInventoryDetailAvailableOnly"
        Me.btnRptInventoryDetailAvailableOnly.Tag = "164"
        '
        'btnCopyProductToNew
        '
        Me.btnCopyProductToNew.Caption = " Copy  to New"
        Me.btnCopyProductToNew.Id = 76
        Me.btnCopyProductToNew.ImageOptions.Image = Global.AOS.My.Resources.Resources.AddNew
        Me.btnCopyProductToNew.ImageOptions.LargeImageIndex = 46
        Me.btnCopyProductToNew.LargeWidth = 50
        Me.btnCopyProductToNew.Name = "btnCopyProductToNew"
        Me.btnCopyProductToNew.Tag = "139"
        '
        'btnFetchRawMaterials
        '
        Me.btnFetchRawMaterials.Caption = "Fetch Data"
        Me.btnFetchRawMaterials.Id = 77
        Me.btnFetchRawMaterials.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.FindRecord
        Me.btnFetchRawMaterials.Name = "btnFetchRawMaterials"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Fetch Data"
        Me.BarButtonItem6.Id = 86
        Me.BarButtonItem6.ImageOptions.Image = Global.AOS.My.Resources.Resources.Filter
        Me.BarButtonItem6.Name = "BarButtonItem6"
        Me.BarButtonItem6.SmallWithTextWidth = 100
        '
        'filterItemStatus
        '
        Me.filterItemStatus.Caption = "Item Status "
        Me.filterItemStatus.Edit = Me.RepositoryItemCheckedComboBoxEdit1
        Me.filterItemStatus.EditWidth = 150
        Me.filterItemStatus.Id = 89
        Me.filterItemStatus.Name = "filterItemStatus"
        '
        'filterItemType
        '
        Me.filterItemType.Caption = "Item Type   "
        Me.filterItemType.Edit = Me.RepositoryItemLookUpEdit15
        Me.filterItemType.EditWidth = 150
        Me.filterItemType.Id = 90
        Me.filterItemType.Name = "filterItemType"
        '
        'btnItemDetails
        '
        Me.btnItemDetails.Caption = "Item Details"
        Me.btnItemDetails.Id = 92
        Me.btnItemDetails.ImageOptions.LargeImageIndex = 30
        Me.btnItemDetails.Name = "btnItemDetails"
        Me.btnItemDetails.Tag = "145"
        '
        'btnFixItems
        '
        Me.btnFixItems.Caption = "Find Missing Items"
        Me.btnFixItems.Id = 105
        Me.btnFixItems.ImageOptions.LargeImageIndex = 28
        Me.btnFixItems.Name = "btnFixItems"
        Me.btnFixItems.Tag = "144"
        '
        'btnManageContainers
        '
        Me.btnManageContainers.Caption = "Manage Containers"
        Me.btnManageContainers.Id = 106
        Me.btnManageContainers.ImageOptions.LargeImageIndex = 23
        Me.btnManageContainers.LargeWidth = 70
        Me.btnManageContainers.Name = "btnManageContainers"
        Me.btnManageContainers.Tag = "142"
        '
        'btnProductFulfillment
        '
        Me.btnProductFulfillment.Id = 127
        Me.btnProductFulfillment.Name = "btnProductFulfillment"
        '
        'btnPrintWOSales
        '
        Me.btnPrintWOSales.Caption = "WO Sales"
        Me.btnPrintWOSales.Id = 107
        Me.btnPrintWOSales.ImageOptions.LargeImageIndex = 33
        Me.btnPrintWOSales.Name = "btnPrintWOSales"
        Me.btnPrintWOSales.Tag = "171"
        '
        'btnPrintMaxItemsbyStatus
        '
        Me.btnPrintMaxItemsbyStatus.Caption = "Scanner Test Page"
        Me.btnPrintMaxItemsbyStatus.Id = 108
        Me.btnPrintMaxItemsbyStatus.ImageOptions.LargeImageIndex = 33
        Me.btnPrintMaxItemsbyStatus.Name = "btnPrintMaxItemsbyStatus"
        Me.btnPrintMaxItemsbyStatus.Tag = "173"
        '
        'btnPrintWOBarcodesReport
        '
        Me.btnPrintWOBarcodesReport.Caption = "Barcode Work Order"
        Me.btnPrintWOBarcodesReport.Id = 109
        Me.btnPrintWOBarcodesReport.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Report1
        Me.btnPrintWOBarcodesReport.Name = "btnPrintWOBarcodesReport"
        '
        'rbtnPrintTotalInventoryByProduct
        '
        Me.rbtnPrintTotalInventoryByProduct.Caption = "Total Inventory By Product"
        Me.rbtnPrintTotalInventoryByProduct.Id = 110
        Me.rbtnPrintTotalInventoryByProduct.ImageOptions.LargeImageIndex = 33
        Me.rbtnPrintTotalInventoryByProduct.Name = "rbtnPrintTotalInventoryByProduct"
        Me.rbtnPrintTotalInventoryByProduct.Tag = "167"
        '
        'rbtnInventoryAnalysisShortList
        '
        Me.rbtnInventoryAnalysisShortList.Caption = "Inventory Analysis - Short List"
        Me.rbtnInventoryAnalysisShortList.Id = 112
        Me.rbtnInventoryAnalysisShortList.ImageOptions.LargeImageIndex = 33
        Me.rbtnInventoryAnalysisShortList.Name = "rbtnInventoryAnalysisShortList"
        Me.rbtnInventoryAnalysisShortList.Tag = "169"
        '
        'btnRptInventoryAnalysisAll
        '
        Me.btnRptInventoryAnalysisAll.Caption = "Inventory Analysis - All Products"
        Me.btnRptInventoryAnalysisAll.Id = 113
        Me.btnRptInventoryAnalysisAll.ImageOptions.LargeImageIndex = 33
        Me.btnRptInventoryAnalysisAll.Name = "btnRptInventoryAnalysisAll"
        Me.btnRptInventoryAnalysisAll.Tag = "168"
        '
        'rbtnCurrentPhysicalInventory
        '
        Me.rbtnCurrentPhysicalInventory.Caption = "Current Physical Inventory"
        Me.rbtnCurrentPhysicalInventory.Id = 114
        Me.rbtnCurrentPhysicalInventory.ImageOptions.LargeImageIndex = 33
        Me.rbtnCurrentPhysicalInventory.Name = "rbtnCurrentPhysicalInventory"
        Me.rbtnCurrentPhysicalInventory.Tag = "159"
        '
        'rbtnInventoryAnalysisNonShortList
        '
        Me.rbtnInventoryAnalysisNonShortList.Caption = "Inventory Analysis - Non-Short List"
        Me.rbtnInventoryAnalysisNonShortList.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnInventoryAnalysisNonShortList.Id = 115
        Me.rbtnInventoryAnalysisNonShortList.ImageOptions.LargeImageIndex = 33
        Me.rbtnInventoryAnalysisNonShortList.Name = "rbtnInventoryAnalysisNonShortList"
        Me.rbtnInventoryAnalysisNonShortList.Tag = "170"
        '
        'rbtnCurrentQuarantined
        '
        Me.rbtnCurrentQuarantined.Caption = "Current Quarantined"
        Me.rbtnCurrentQuarantined.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnCurrentQuarantined.Id = 116
        Me.rbtnCurrentQuarantined.ImageOptions.LargeImageIndex = 33
        Me.rbtnCurrentQuarantined.Name = "rbtnCurrentQuarantined"
        Me.rbtnCurrentQuarantined.Tag = "166"
        '
        'btnPLNReport
        '
        Me.btnPLNReport.Caption = "Profit && Loss (New)"
        Me.btnPLNReport.Id = 117
        Me.btnPLNReport.ImageOptions.LargeImageIndex = 33
        Me.btnPLNReport.Name = "btnPLNReport"
        Me.btnPLNReport.Tag = "322"
        '
        'btnVIEWCOMPONENTS
        '
        Me.btnVIEWCOMPONENTS.Caption = "View  Components"
        Me.btnVIEWCOMPONENTS.Id = 118
        Me.btnVIEWCOMPONENTS.ImageOptions.LargeImageIndex = 39
        Me.btnVIEWCOMPONENTS.LargeWidth = 70
        Me.btnVIEWCOMPONENTS.Name = "btnVIEWCOMPONENTS"
        '
        'btnAddComponent
        '
        Me.btnAddComponent.Caption = "Add   Component"
        Me.btnAddComponent.Id = 120
        Me.btnAddComponent.ImageOptions.Image = CType(resources.GetObject("btnAddComponent.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddComponent.ImageOptions.LargeImageIndex = 34
        Me.btnAddComponent.LargeWidth = 70
        Me.btnAddComponent.Name = "btnAddComponent"
        '
        'btnEditComponent
        '
        Me.btnEditComponent.Caption = "Edit  Component"
        Me.btnEditComponent.Id = 121
        Me.btnEditComponent.ImageOptions.Image = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditComponent.ImageOptions.LargeImageIndex = 35
        Me.btnEditComponent.LargeWidth = 70
        Me.btnEditComponent.Name = "btnEditComponent"
        '
        'btnDeleteComponent
        '
        Me.btnDeleteComponent.Caption = "Delete Component"
        Me.btnDeleteComponent.Id = 122
        Me.btnDeleteComponent.ImageOptions.Image = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteComponent.ImageOptions.LargeImageIndex = 36
        Me.btnDeleteComponent.LargeWidth = 70
        Me.btnDeleteComponent.Name = "btnDeleteComponent"
        '
        'btnVIEWKITS
        '
        Me.btnVIEWKITS.Caption = " View Kits"
        Me.btnVIEWKITS.Id = 123
        Me.btnVIEWKITS.ImageOptions.LargeImageIndex = 45
        Me.btnVIEWKITS.LargeWidth = 70
        Me.btnVIEWKITS.Name = "btnVIEWKITS"
        '
        'btnAddKit
        '
        Me.btnAddKit.Caption = " Add   Kit"
        Me.btnAddKit.Id = 124
        Me.btnAddKit.ImageOptions.Image = CType(resources.GetObject("btnAddKit.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAddKit.ImageOptions.LargeImageIndex = 40
        Me.btnAddKit.LargeWidth = 70
        Me.btnAddKit.Name = "btnAddKit"
        '
        'btnEditKit
        '
        Me.btnEditKit.Caption = " Edit  Kit"
        Me.btnEditKit.Id = 125
        Me.btnEditKit.ImageOptions.Image = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditKit.ImageOptions.LargeImageIndex = 41
        Me.btnEditKit.LargeWidth = 70
        Me.btnEditKit.Name = "btnEditKit"
        '
        'btnDeleteKit
        '
        Me.btnDeleteKit.Caption = "Delete Kit"
        Me.btnDeleteKit.Id = 126
        Me.btnDeleteKit.ImageOptions.Image = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteKit.ImageOptions.LargeImageIndex = 42
        Me.btnDeleteKit.LargeWidth = 70
        Me.btnDeleteKit.Name = "btnDeleteKit"
        '
        'rRptStartDate
        '
        Me.rRptStartDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.rRptStartDate.Caption = "Start Date "
        Me.rRptStartDate.Edit = Me.RepositoryItemDateEdit1
        Me.rRptStartDate.EditWidth = 80
        Me.rRptStartDate.Id = 145
        Me.rRptStartDate.Name = "rRptStartDate"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'rRptEndDate
        '
        Me.rRptEndDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.rRptEndDate.Caption = "End Date   "
        Me.rRptEndDate.Edit = Me.RepositoryItemDateEdit4
        Me.rRptEndDate.EditWidth = 80
        Me.rRptEndDate.Id = 146
        Me.rRptEndDate.Name = "rRptEndDate"
        '
        'RepositoryItemDateEdit4
        '
        Me.RepositoryItemDateEdit4.AutoHeight = False
        Me.RepositoryItemDateEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit4.Name = "RepositoryItemDateEdit4"
        '
        'rbtnPrintRelabelOrdersSummary
        '
        Me.rbtnPrintRelabelOrdersSummary.Caption = "Print Relabel Orders Summary"
        Me.rbtnPrintRelabelOrdersSummary.Id = 147
        Me.rbtnPrintRelabelOrdersSummary.ImageOptions.LargeImageIndex = 21
        Me.rbtnPrintRelabelOrdersSummary.Name = "rbtnPrintRelabelOrdersSummary"
        '
        'rbtnFilterFinishedGoods
        '
        Me.rbtnFilterFinishedGoods.Caption = "Finished Goods"
        Me.rbtnFilterFinishedGoods.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnFilterFinishedGoods.Id = 148
        Me.rbtnFilterFinishedGoods.ImageOptions.LargeImageIndex = 27
        Me.rbtnFilterFinishedGoods.Name = "rbtnFilterFinishedGoods"
        '
        'rbtnFilterRawMaterial
        '
        Me.rbtnFilterRawMaterial.Caption = "  Raw   Materials"
        Me.rbtnFilterRawMaterial.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnFilterRawMaterial.Id = 149
        Me.rbtnFilterRawMaterial.ImageOptions.LargeImageIndex = 27
        Me.rbtnFilterRawMaterial.Name = "rbtnFilterRawMaterial"
        '
        'rbtnFilterProductsActive
        '
        Me.rbtnFilterProductsActive.Caption = "Active"
        Me.rbtnFilterProductsActive.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnFilterProductsActive.Id = 151
        Me.rbtnFilterProductsActive.ImageOptions.LargeImageIndex = 1
        Me.rbtnFilterProductsActive.LargeWidth = 50
        Me.rbtnFilterProductsActive.Name = "rbtnFilterProductsActive"
        '
        'rbtnFilterProductsInActive
        '
        Me.rbtnFilterProductsInActive.Caption = "Inactive"
        Me.rbtnFilterProductsInActive.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnFilterProductsInActive.Id = 152
        Me.rbtnFilterProductsInActive.ImageOptions.LargeImageIndex = 1
        Me.rbtnFilterProductsInActive.LargeWidth = 50
        Me.rbtnFilterProductsInActive.Name = "rbtnFilterProductsInActive"
        '
        'rbtnFilterProductsAll
        '
        Me.rbtnFilterProductsAll.Caption = "All"
        Me.rbtnFilterProductsAll.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnFilterProductsAll.Id = 153
        Me.rbtnFilterProductsAll.ImageOptions.LargeImageIndex = 1
        Me.rbtnFilterProductsAll.LargeWidth = 50
        Me.rbtnFilterProductsAll.Name = "rbtnFilterProductsAll"
        '
        'rbtnPrintGHSLabel
        '
        Me.rbtnPrintGHSLabel.Caption = "GHS Label"
        Me.rbtnPrintGHSLabel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPrintGHSLabel.Id = 154
        Me.rbtnPrintGHSLabel.ImageOptions.LargeImageIndex = 31
        Me.rbtnPrintGHSLabel.Name = "rbtnPrintGHSLabel"
        '
        'rbtnPrintGHSLabelByProductOnly
        '
        Me.rbtnPrintGHSLabelByProductOnly.Caption = "GHS Product Label"
        Me.rbtnPrintGHSLabelByProductOnly.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPrintGHSLabelByProductOnly.Id = 155
        Me.rbtnPrintGHSLabelByProductOnly.ImageOptions.LargeImageIndex = 7
        Me.rbtnPrintGHSLabelByProductOnly.Name = "rbtnPrintGHSLabelByProductOnly"
        '
        'rbtnFilterProductsPending
        '
        Me.rbtnFilterProductsPending.Caption = "Pending"
        Me.rbtnFilterProductsPending.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnFilterProductsPending.Id = 156
        Me.rbtnFilterProductsPending.ImageOptions.LargeImageIndex = 1
        Me.rbtnFilterProductsPending.Name = "rbtnFilterProductsPending"
        '
        'rbtnPrintSDSReport
        '
        Me.rbtnPrintSDSReport.Caption = "View / Print SDS Document"
        Me.rbtnPrintSDSReport.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPrintSDSReport.Id = 157
        Me.rbtnPrintSDSReport.ImageOptions.LargeImageIndex = 7
        Me.rbtnPrintSDSReport.Name = "rbtnPrintSDSReport"
        '
        'rbtnAllItems
        '
        Me.rbtnAllItems.Caption = "Find All Items"
        Me.rbtnAllItems.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnAllItems.Id = 158
        Me.rbtnAllItems.ImageOptions.LargeImageIndex = 28
        Me.rbtnAllItems.Name = "rbtnAllItems"
        '
        'rbtnProductSalesHistory
        '
        Me.rbtnProductSalesHistory.Caption = "Product Sales History"
        Me.rbtnProductSalesHistory.Id = 159
        Me.rbtnProductSalesHistory.ImageOptions.LargeImageIndex = 8
        Me.rbtnProductSalesHistory.Name = "rbtnProductSalesHistory"
        '
        'rbtnProductPurchaseHistory
        '
        Me.rbtnProductPurchaseHistory.Caption = "Product Purchase History"
        Me.rbtnProductPurchaseHistory.Id = 160
        Me.rbtnProductPurchaseHistory.ImageOptions.LargeImageIndex = 8
        Me.rbtnProductPurchaseHistory.Name = "rbtnProductPurchaseHistory"
        '
        'Ribbon_LargeImages
        '
        Me.Ribbon_LargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.Ribbon_LargeImages.ImageStream = CType(resources.GetObject("Ribbon_LargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup11, Me.RibbonPageGroup4, Me.RibbonPageGroup2, Me.RibbonPageGroup15})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "22"
        Me.RibbonPage1.Text = "Products"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddProduct)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditProduct)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDeleteProduct)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCopyProductToNew, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnProductSalesHistory, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnProductPurchaseHistory)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Product Info"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.AllowMinimize = False
        Me.RibbonPageGroup11.AllowTextClipping = False
        Me.RibbonPageGroup11.ItemLinks.Add(Me.rbtnFilterProductsActive)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.rbtnFilterProductsInActive)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.rbtnFilterProductsPending)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.rbtnFilterProductsAll, True)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        Me.RibbonPageGroup11.ShowCaptionButton = False
        Me.RibbonPageGroup11.Text = "Filters"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnPrintSDSReport)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Reports"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ImageIndex = 0
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnPrintGHSLabelByProductOnly)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Labels"
        '
        'RibbonPageGroup15
        '
        Me.RibbonPageGroup15.ItemLinks.Add(Me.btnMaintainProducts)
        Me.RibbonPageGroup15.ItemLinks.Add(Me.btnManageContainers)
        Me.RibbonPageGroup15.Name = "RibbonPageGroup15"
        Me.RibbonPageGroup15.ShowCaptionButton = False
        Me.RibbonPageGroup15.Tag = "8"
        Me.RibbonPageGroup15.Text = "Maintenance"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup21, Me.RibbonPageGroup22})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Components"
        '
        'RibbonPageGroup21
        '
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnVIEWCOMPONENTS)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnAddComponent, True)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnEditComponent)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnDeleteComponent)
        Me.RibbonPageGroup21.Name = "RibbonPageGroup21"
        Me.RibbonPageGroup21.ShowCaptionButton = False
        Me.RibbonPageGroup21.Text = "Component Management"
        '
        'RibbonPageGroup22
        '
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnVIEWKITS)
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnAddKit, True)
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnEditKit)
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnDeleteKit)
        Me.RibbonPageGroup22.Name = "RibbonPageGroup22"
        Me.RibbonPageGroup22.ShowCaptionButton = False
        Me.RibbonPageGroup22.Text = "Kit Management"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup8, Me.RibbonPageGroup17, Me.RibbonPageGroup20, Me.RibbonPageGroup6})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Tag = 23
        Me.RibbonPage3.Text = "Inventory Control"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.AllowMinimize = False
        Me.RibbonPageGroup8.AllowTextClipping = False
        Me.RibbonPageGroup8.ItemLinks.Add(Me.rbtnFilterFinishedGoods)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.rbtnFilterRawMaterial)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Fast Filters"
        '
        'RibbonPageGroup17
        '
        Me.RibbonPageGroup17.AllowTextClipping = False
        Me.RibbonPageGroup17.ItemLinks.Add(Me.filterItemType)
        Me.RibbonPageGroup17.ItemLinks.Add(Me.filterItemStatus)
        Me.RibbonPageGroup17.ItemLinks.Add(Me.btnFetchFinishedGoods, True)
        Me.RibbonPageGroup17.ItemLinks.Add(Me.btnFixItems, True)
        Me.RibbonPageGroup17.ItemLinks.Add(Me.rbtnAllItems)
        Me.RibbonPageGroup17.Name = "RibbonPageGroup17"
        Me.RibbonPageGroup17.ShowCaptionButton = False
        Me.RibbonPageGroup17.Text = "Record Selection Criteria"
        '
        'RibbonPageGroup20
        '
        Me.RibbonPageGroup20.AllowTextClipping = False
        Me.RibbonPageGroup20.ItemLinks.Add(Me.btnItemDetails)
        Me.RibbonPageGroup20.Name = "RibbonPageGroup20"
        Me.RibbonPageGroup20.ShowCaptionButton = False
        Me.RibbonPageGroup20.Text = "Item Actions"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnPrintMiniInventoryLabels)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnPrintGHSLabel)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Tag = "5"
        Me.RibbonPageGroup6.Text = "Print"
        '
        'RibbonPage6
        '
        Me.RibbonPage6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup3, Me.RibbonPageGroup16})
        Me.RibbonPage6.Name = "RibbonPage6"
        Me.RibbonPage6.Tag = "24"
        Me.RibbonPage6.Text = "Inventory Reports"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.eReportStartDate)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.eReportEndDate)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Parameters"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnCurrentPhysicalInventory)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnRptInventoryDetail)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnRptInventoryDetailAvailableOnly)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnCurrentQuarantined)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnRptInventoryAnalysisAll)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnInventoryAnalysisShortList)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Inventory Reports"
        '
        'RibbonPageGroup16
        '
        Me.RibbonPageGroup16.AllowTextClipping = False
        Me.RibbonPageGroup16.ItemLinks.Add(Me.btnPrintWOSales)
        Me.RibbonPageGroup16.ItemLinks.Add(Me.btnPLReport)
        Me.RibbonPageGroup16.ItemLinks.Add(Me.btnOnFloorValuationReport)
        Me.RibbonPageGroup16.ItemLinks.Add(Me.btnPLNReport)
        Me.RibbonPageGroup16.Name = "RibbonPageGroup16"
        Me.RibbonPageGroup16.ShowCaptionButton = False
        Me.RibbonPageGroup16.Tag = "8"
        Me.RibbonPageGroup16.Text = "Performance"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
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
        Me.FormCaption.Size = New System.Drawing.Size(1494, 33)
        Me.FormCaption.TabIndex = 2
        Me.FormCaption.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridView1.GridControl = Me.FormCaption
        Me.GridView1.GroupPanelText = "Inventory Management"
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 200
        '
        'WorkPanelsHolder
        '
        Me.WorkPanelsHolder.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.WorkPanelsHolder.Appearance.Options.UseBackColor = True
        Me.WorkPanelsHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl6)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl7)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 149)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1494, 583)
        Me.WorkPanelsHolder.TabIndex = 5
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.grpInventoryItems)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1494, 583)
        Me.RibbonPanelControl3.TabIndex = 1
        '
        'grpInventoryItems
        '
        Me.grpInventoryItems.Controls.Add(Me.grInventoryItems)
        Me.grpInventoryItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpInventoryItems.Location = New System.Drawing.Point(2, 2)
        Me.grpInventoryItems.Name = "grpInventoryItems"
        Me.grpInventoryItems.Size = New System.Drawing.Size(1490, 579)
        Me.grpInventoryItems.TabIndex = 0
        Me.grpInventoryItems.Text = "Inventory Items"
        '
        'grInventoryItems
        '
        Me.grInventoryItems.DataSource = Me.bsInventoryItems
        Me.grInventoryItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInventoryItems.Location = New System.Drawing.Point(2, 20)
        Me.grInventoryItems.MainView = Me.InventoryList
        Me.grInventoryItems.Name = "grInventoryItems"
        Me.grInventoryItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit5, Me.RepositoryItemLookUpEdit9, Me.RepositoryItemLookUpEdit11, Me.RepositoryItemLookUpEdit12, Me.RepositoryItemLookUpEditWarehouse})
        Me.grInventoryItems.Size = New System.Drawing.Size(1486, 557)
        Me.grInventoryItems.TabIndex = 0
        Me.grInventoryItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.InventoryList, Me.LayoutView1, Me.GridView12})
        '
        'InventoryList
        '
        Me.InventoryList.Appearance.ViewCaption.BackColor = System.Drawing.Color.Transparent
        Me.InventoryList.Appearance.ViewCaption.BackColor2 = System.Drawing.Color.Transparent
        Me.InventoryList.Appearance.ViewCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.InventoryList.Appearance.ViewCaption.Options.UseBackColor = True
        Me.InventoryList.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.InventoryList.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.InventoryList.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.InventoryList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber1, Me.colWarehousenumber1, Me.colWarehouselocation2, Me.colProductid3, Me.colProductid4, Me.colContainer2, Me.colLotnumber2, Me.GridColumn6, Me.colReceiveddate1, Me.colAllocateddate, Me.colShippeddate, Me.colItemstatus, Me.GridColumn2, Me.GridColumn5})
        Me.InventoryList.GridControl = Me.grInventoryItems
        Me.InventoryList.Name = "InventoryList"
        Me.InventoryList.OptionsBehavior.Editable = False
        Me.InventoryList.OptionsSelection.MultiSelect = True
        Me.InventoryList.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.InventoryList.OptionsView.EnableAppearanceEvenRow = True
        Me.InventoryList.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.SmartTag
        Me.InventoryList.OptionsView.ShowAutoFilterRow = True
        Me.InventoryList.ViewCaption = "  Finished Goods Inventory"
        '
        'colInvitemnumber1
        '
        Me.colInvitemnumber1.Caption = "Item #"
        Me.colInvitemnumber1.FieldName = "Invitemnumber"
        Me.colInvitemnumber1.Name = "colInvitemnumber1"
        Me.colInvitemnumber1.OptionsColumn.AllowEdit = False
        Me.colInvitemnumber1.Visible = True
        Me.colInvitemnumber1.VisibleIndex = 0
        Me.colInvitemnumber1.Width = 55
        '
        'colWarehousenumber1
        '
        Me.colWarehousenumber1.Caption = "WH"
        Me.colWarehousenumber1.ColumnEdit = Me.RepositoryItemLookUpEditWarehouse
        Me.colWarehousenumber1.FieldName = "Warehousenumber"
        Me.colWarehousenumber1.Name = "colWarehousenumber1"
        Me.colWarehousenumber1.OptionsColumn.AllowEdit = False
        Me.colWarehousenumber1.Visible = True
        Me.colWarehousenumber1.VisibleIndex = 8
        Me.colWarehousenumber1.Width = 29
        '
        'RepositoryItemLookUpEditWarehouse
        '
        Me.RepositoryItemLookUpEditWarehouse.AutoHeight = False
        Me.RepositoryItemLookUpEditWarehouse.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEditWarehouse.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Warehouseid", "Warehouseid", 86, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Warehouseshortname", "Warehouseshortname", 116, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Warehousecity", "Warehousecity", 82, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEditWarehouse.DataSource = Me.bsWarehouse
        Me.RepositoryItemLookUpEditWarehouse.DisplayMember = "Warehouseshortname"
        Me.RepositoryItemLookUpEditWarehouse.Name = "RepositoryItemLookUpEditWarehouse"
        Me.RepositoryItemLookUpEditWarehouse.NullText = ""
        Me.RepositoryItemLookUpEditWarehouse.NullValuePromptShowForEmptyValue = True
        Me.RepositoryItemLookUpEditWarehouse.ValueMember = "Warehouseid"
        '
        'bsWarehouse
        '
        Me.bsWarehouse.DataSource = GetType(AOS.BusinessObjects.WarehouseCollection)
        '
        'colWarehouselocation2
        '
        Me.colWarehouselocation2.Caption = "Bin"
        Me.colWarehouselocation2.FieldName = "Warehouselocation"
        Me.colWarehouselocation2.Name = "colWarehouselocation2"
        Me.colWarehouselocation2.OptionsColumn.AllowEdit = False
        Me.colWarehouselocation2.Visible = True
        Me.colWarehouselocation2.VisibleIndex = 7
        Me.colWarehouselocation2.Width = 31
        '
        'colProductid3
        '
        Me.colProductid3.Caption = "Prod ID"
        Me.colProductid3.FieldName = "Productid"
        Me.colProductid3.Name = "colProductid3"
        Me.colProductid3.OptionsColumn.AllowEdit = False
        Me.colProductid3.Visible = True
        Me.colProductid3.VisibleIndex = 1
        Me.colProductid3.Width = 61
        '
        'colProductid4
        '
        Me.colProductid4.Caption = "Product Description"
        Me.colProductid4.ColumnEdit = Me.RepositoryItemLookUpEdit5
        Me.colProductid4.FieldName = "Productid"
        Me.colProductid4.Name = "colProductid4"
        Me.colProductid4.OptionsColumn.AllowEdit = False
        Me.colProductid4.Visible = True
        Me.colProductid4.VisibleIndex = 2
        Me.colProductid4.Width = 127
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit5.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit5.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.PopupWidth = 275
        Me.RepositoryItemLookUpEdit5.ReadOnly = True
        Me.RepositoryItemLookUpEdit5.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit5.ShowFooter = False
        Me.RepositoryItemLookUpEdit5.ShowLines = False
        Me.RepositoryItemLookUpEdit5.SortColumnIndex = 1
        Me.RepositoryItemLookUpEdit5.ValueMember = "Productid"
        '
        'colContainer2
        '
        Me.colContainer2.Caption = "Container"
        Me.colContainer2.FieldName = "Container"
        Me.colContainer2.Name = "colContainer2"
        Me.colContainer2.OptionsColumn.AllowEdit = False
        Me.colContainer2.Visible = True
        Me.colContainer2.VisibleIndex = 5
        Me.colContainer2.Width = 64
        '
        'colLotnumber2
        '
        Me.colLotnumber2.Caption = "Lot Number"
        Me.colLotnumber2.FieldName = "Lotnumber"
        Me.colLotnumber2.Name = "colLotnumber2"
        Me.colLotnumber2.OptionsColumn.AllowEdit = False
        Me.colLotnumber2.Visible = True
        Me.colLotnumber2.VisibleIndex = 6
        Me.colLotnumber2.Width = 78
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Remaining"
        Me.GridColumn6.DisplayFormat.FormatString = "n2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Unitsremaining"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 10
        Me.GridColumn6.Width = 67
        '
        'colReceiveddate1
        '
        Me.colReceiveddate1.Caption = "Received"
        Me.colReceiveddate1.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colReceiveddate1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colReceiveddate1.FieldName = "Receiveddate"
        Me.colReceiveddate1.Name = "colReceiveddate1"
        Me.colReceiveddate1.OptionsColumn.AllowEdit = False
        Me.colReceiveddate1.Visible = True
        Me.colReceiveddate1.VisibleIndex = 11
        Me.colReceiveddate1.Width = 58
        '
        'colAllocateddate
        '
        Me.colAllocateddate.Caption = "Allocated"
        Me.colAllocateddate.DisplayFormat.FormatString = "d"
        Me.colAllocateddate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colAllocateddate.FieldName = "Allocateddate"
        Me.colAllocateddate.Name = "colAllocateddate"
        Me.colAllocateddate.OptionsColumn.AllowEdit = False
        Me.colAllocateddate.Visible = True
        Me.colAllocateddate.VisibleIndex = 12
        Me.colAllocateddate.Width = 59
        '
        'colShippeddate
        '
        Me.colShippeddate.Caption = "Shipped"
        Me.colShippeddate.DisplayFormat.FormatString = "d"
        Me.colShippeddate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colShippeddate.FieldName = "Shippeddate"
        Me.colShippeddate.Name = "colShippeddate"
        Me.colShippeddate.OptionsColumn.AllowEdit = False
        Me.colShippeddate.Visible = True
        Me.colShippeddate.VisibleIndex = 13
        Me.colShippeddate.Width = 175
        '
        'colItemstatus
        '
        Me.colItemstatus.Caption = "Status"
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        Me.colItemstatus.OptionsColumn.AllowEdit = False
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 9
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Addn Desc"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemLookUpEdit9
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 95
        '
        'RepositoryItemLookUpEdit9
        '
        Me.RepositoryItemLookUpEdit9.AutoHeight = False
        Me.RepositoryItemLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit9.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit9.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit9.Name = "RepositoryItemLookUpEdit9"
        Me.RepositoryItemLookUpEdit9.NullText = ""
        Me.RepositoryItemLookUpEdit9.ValueMember = "Productid"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Class"
        Me.GridColumn5.ColumnEdit = Me.RepositoryItemLookUpEdit12
        Me.GridColumn5.FieldName = "Inventoryclass"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 41
        '
        'RepositoryItemLookUpEdit12
        '
        Me.RepositoryItemLookUpEdit12.AutoHeight = False
        Me.RepositoryItemLookUpEdit12.DataSource = Me.bsInventoryClass
        Me.RepositoryItemLookUpEdit12.DisplayMember = "LookupDesc"
        Me.RepositoryItemLookUpEdit12.Name = "RepositoryItemLookUpEdit12"
        Me.RepositoryItemLookUpEdit12.NullText = ""
        Me.RepositoryItemLookUpEdit12.ReadOnly = True
        Me.RepositoryItemLookUpEdit12.ValueMember = "LookUpValue"
        '
        'RepositoryItemLookUpEdit11
        '
        Me.RepositoryItemLookUpEdit11.AutoHeight = False
        Me.RepositoryItemLookUpEdit11.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit11.DisplayMember = "Inventoryclass"
        Me.RepositoryItemLookUpEdit11.Name = "RepositoryItemLookUpEdit11"
        Me.RepositoryItemLookUpEdit11.ValueMember = "Inventoryclass"
        '
        'LayoutView1
        '
        Me.LayoutView1.GridControl = Me.grInventoryItems
        Me.LayoutView1.Name = "LayoutView1"
        Me.LayoutView1.TemplateCard = Nothing
        '
        'GridView12
        '
        Me.GridView12.GridControl = Me.grInventoryItems
        Me.GridView12.Name = "GridView12"
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RibbonPanelControl1.Appearance.Options.UseBackColor = True
        Me.RibbonPanelControl1.Controls.Add(Me.SplitContainerControl1)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1494, 583)
        Me.RibbonPanelControl1.TabIndex = 0
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(8, 8)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.gcProducts)
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.GroupControl2)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(1478, 567)
        Me.SplitContainerControl1.SplitterPosition = 892
        Me.SplitContainerControl1.TabIndex = 0
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'gcProducts
        '
        Me.gcProducts.Controls.Add(Me.grProducts)
        Me.gcProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcProducts.Location = New System.Drawing.Point(0, 0)
        Me.gcProducts.Name = "gcProducts"
        Me.gcProducts.Size = New System.Drawing.Size(892, 567)
        Me.gcProducts.TabIndex = 0
        Me.gcProducts.Text = "Products"
        '
        'grProducts
        '
        Me.grProducts.DataSource = Me.bsProducts
        Me.grProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grProducts.Location = New System.Drawing.Point(2, 20)
        Me.grProducts.MainView = Me.ProductsView
        Me.grProducts.Name = "grProducts"
        Me.grProducts.Size = New System.Drawing.Size(888, 545)
        Me.grProducts.TabIndex = 0
        Me.grProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ProductsView, Me.GridView15})
        '
        'ProductsView
        '
        Me.ProductsView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProductdesc, Me.colContainer, Me.GridColumn3, Me.colChemicalid, Me.colChemicalname, Me.colProductstatus})
        Me.ProductsView.GridControl = Me.grProducts
        Me.ProductsView.Name = "ProductsView"
        Me.ProductsView.OptionsBehavior.Editable = False
        Me.ProductsView.OptionsSelection.MultiSelect = True
        Me.ProductsView.OptionsView.ShowAutoFilterRow = True
        Me.ProductsView.OptionsView.ShowGroupPanel = False
        Me.ProductsView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colProductdesc, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.AllowEdit = False
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 0
        Me.colProductid.Width = 81
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.OptionsColumn.AllowEdit = False
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 1
        Me.colProductdesc.Width = 228
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.OptionsColumn.AllowEdit = False
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 85
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Addn Desc"
        Me.GridColumn3.FieldName = "Desc2"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 142
        '
        'colChemicalid
        '
        Me.colChemicalid.Caption = "Chem ID"
        Me.colChemicalid.FieldName = "Chemicalid"
        Me.colChemicalid.Name = "colChemicalid"
        Me.colChemicalid.Visible = True
        Me.colChemicalid.VisibleIndex = 4
        Me.colChemicalid.Width = 59
        '
        'colChemicalname
        '
        Me.colChemicalname.Caption = "Chemical Name"
        Me.colChemicalname.FieldName = "Chemicalname"
        Me.colChemicalname.Name = "colChemicalname"
        Me.colChemicalname.Visible = True
        Me.colChemicalname.VisibleIndex = 5
        Me.colChemicalname.Width = 217
        '
        'colProductstatus
        '
        Me.colProductstatus.Caption = "Status"
        Me.colProductstatus.FieldName = "Productstatus"
        Me.colProductstatus.Name = "colProductstatus"
        Me.colProductstatus.Visible = True
        Me.colProductstatus.VisibleIndex = 6
        Me.colProductstatus.Width = 61
        '
        'GridView15
        '
        Me.GridView15.GridControl = Me.grProducts
        Me.GridView15.Name = "GridView15"
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl2.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl2.Controls.Add(Me.grItems)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(581, 567)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Inventory Items"
        '
        'grItems
        '
        Me.grItems.DataSource = Me.bsItems
        Me.grItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grItems.Location = New System.Drawing.Point(2, 20)
        Me.grItems.MainView = Me.InventoryItemsView
        Me.grItems.Name = "grItems"
        Me.grItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit8, Me.RepositoryItemLookUpEdit10})
        Me.grItems.Size = New System.Drawing.Size(577, 545)
        Me.grItems.TabIndex = 0
        Me.grItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.InventoryItemsView, Me.GridView13})
        '
        'InventoryItemsView
        '
        Me.InventoryItemsView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber, Me.colProductid1, Me.GridColumn1, Me.colWarehouselocation, Me.colLotnumber, Me.GridColumn4})
        Me.InventoryItemsView.GridControl = Me.grItems
        Me.InventoryItemsView.Name = "InventoryItemsView"
        Me.InventoryItemsView.OptionsSelection.MultiSelect = True
        Me.InventoryItemsView.OptionsView.ShowAutoFilterRow = True
        Me.InventoryItemsView.OptionsView.ShowGroupPanel = False
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Item #"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.OptionsColumn.AllowEdit = False
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 0
        Me.colInvitemnumber.Width = 56
        '
        'colProductid1
        '
        Me.colProductid1.Caption = "Prod ID"
        Me.colProductid1.FieldName = "Productid"
        Me.colProductid1.Name = "colProductid1"
        Me.colProductid1.OptionsColumn.AllowEdit = False
        Me.colProductid1.Visible = True
        Me.colProductid1.VisibleIndex = 1
        Me.colProductid1.Width = 58
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Product Description"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemLookUpEdit8
        Me.GridColumn1.FieldName = "Productid"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 156
        '
        'RepositoryItemLookUpEdit8
        '
        Me.RepositoryItemLookUpEdit8.AutoHeight = False
        Me.RepositoryItemLookUpEdit8.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit8.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit8.Name = "RepositoryItemLookUpEdit8"
        Me.RepositoryItemLookUpEdit8.NullText = ""
        Me.RepositoryItemLookUpEdit8.ReadOnly = True
        Me.RepositoryItemLookUpEdit8.ValueMember = "Productid"
        '
        'colWarehouselocation
        '
        Me.colWarehouselocation.Caption = "Warehouse"
        Me.colWarehouselocation.FieldName = "Warehouselocation"
        Me.colWarehouselocation.Name = "colWarehouselocation"
        Me.colWarehouselocation.OptionsColumn.AllowEdit = False
        Me.colWarehouselocation.Visible = True
        Me.colWarehouselocation.VisibleIndex = 4
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot #"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.OptionsColumn.AllowEdit = False
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 5
        Me.colLotnumber.Width = 76
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Addn Desc"
        Me.GridColumn4.ColumnEdit = Me.RepositoryItemLookUpEdit10
        Me.GridColumn4.FieldName = "Productid"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 78
        '
        'RepositoryItemLookUpEdit10
        '
        Me.RepositoryItemLookUpEdit10.AutoHeight = False
        Me.RepositoryItemLookUpEdit10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit10.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit10.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit10.Name = "RepositoryItemLookUpEdit10"
        Me.RepositoryItemLookUpEdit10.NullText = ""
        Me.RepositoryItemLookUpEdit10.ValueMember = "Productid"
        '
        'GridView13
        '
        Me.GridView13.GridControl = Me.grItems
        Me.GridView13.Name = "GridView13"
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Controls.Add(Me.pnlKitHolder)
        Me.RibbonPanelControl2.Controls.Add(Me.pnlComponentHolder)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1494, 583)
        Me.RibbonPanelControl2.TabIndex = 2
        '
        'pnlKitHolder
        '
        Me.pnlKitHolder.Controls.Add(Me.gcKit)
        Me.pnlKitHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKitHolder.Location = New System.Drawing.Point(2, 2)
        Me.pnlKitHolder.Name = "pnlKitHolder"
        Me.pnlKitHolder.Size = New System.Drawing.Size(1490, 579)
        Me.pnlKitHolder.TabIndex = 4
        '
        'gcKit
        '
        Me.gcKit.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gcKit.Appearance.Options.UseBackColor = True
        Me.gcKit.Controls.Add(Me.SplitContainerControl5)
        Me.gcKit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcKit.Location = New System.Drawing.Point(2, 2)
        Me.gcKit.Name = "gcKit"
        Me.gcKit.Padding = New System.Windows.Forms.Padding(6)
        Me.gcKit.Size = New System.Drawing.Size(1486, 575)
        Me.gcKit.TabIndex = 2
        '
        'SplitContainerControl5
        '
        Me.SplitContainerControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl5.Location = New System.Drawing.Point(8, 8)
        Me.SplitContainerControl5.Name = "SplitContainerControl5"
        Me.SplitContainerControl5.Panel1.Controls.Add(Me.GroupControl13)
        Me.SplitContainerControl5.Panel1.Text = "Panel1"
        Me.SplitContainerControl5.Panel2.Controls.Add(Me.GroupControl12)
        Me.SplitContainerControl5.Panel2.Text = "Panel2"
        Me.SplitContainerControl5.Size = New System.Drawing.Size(1470, 559)
        Me.SplitContainerControl5.SplitterPosition = 495
        Me.SplitContainerControl5.TabIndex = 0
        Me.SplitContainerControl5.Text = "SplitContainerControl5"
        '
        'GroupControl13
        '
        Me.GroupControl13.Controls.Add(Me.grKit)
        Me.GroupControl13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl13.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl13.Name = "GroupControl13"
        Me.GroupControl13.Size = New System.Drawing.Size(495, 559)
        Me.GroupControl13.TabIndex = 1
        Me.GroupControl13.Text = "Kits"
        '
        'grKit
        '
        Me.grKit.DataSource = Me.bsKit
        Me.grKit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grKit.Location = New System.Drawing.Point(2, 20)
        Me.grKit.MainView = Me.GridView11
        Me.grKit.Name = "grKit"
        Me.grKit.Size = New System.Drawing.Size(491, 537)
        Me.grKit.TabIndex = 0
        Me.grKit.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView11, Me.GridView7})
        '
        'bsKit
        '
        Me.bsKit.DataSource = GetType(AOS.BusinessObjects.ViewKitInfoCollection)
        '
        'GridView11
        '
        Me.GridView11.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colKitid, Me.colKitname, Me.colKitCost})
        Me.GridView11.CustomizationFormBounds = New System.Drawing.Rectangle(360, 473, 216, 185)
        Me.GridView11.GridControl = Me.grKit
        Me.GridView11.Name = "GridView11"
        Me.GridView11.OptionsBehavior.Editable = False
        Me.GridView11.OptionsSelection.MultiSelect = True
        Me.GridView11.OptionsView.ShowAutoFilterRow = True
        Me.GridView11.OptionsView.ShowGroupPanel = False
        '
        'colKitid
        '
        Me.colKitid.Caption = "Kit ID "
        Me.colKitid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKitid.FieldName = "Kitid"
        Me.colKitid.Name = "colKitid"
        Me.colKitid.OptionsColumn.AllowEdit = False
        Me.colKitid.OptionsColumn.FixedWidth = True
        Me.colKitid.Visible = True
        Me.colKitid.VisibleIndex = 0
        Me.colKitid.Width = 49
        '
        'colKitname
        '
        Me.colKitname.Caption = "Kit Name "
        Me.colKitname.FieldName = "Kitname"
        Me.colKitname.Name = "colKitname"
        Me.colKitname.OptionsColumn.AllowEdit = False
        Me.colKitname.Visible = True
        Me.colKitname.VisibleIndex = 1
        Me.colKitname.Width = 358
        '
        'colKitCost
        '
        Me.colKitCost.Caption = "Kit Cost"
        Me.colKitCost.DisplayFormat.FormatString = "c2"
        Me.colKitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colKitCost.FieldName = "KitCost"
        Me.colKitCost.Name = "colKitCost"
        Me.colKitCost.OptionsColumn.FixedWidth = True
        Me.colKitCost.Visible = True
        Me.colKitCost.VisibleIndex = 2
        Me.colKitCost.Width = 67
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.grKit
        Me.GridView7.Name = "GridView7"
        '
        'GroupControl12
        '
        Me.GroupControl12.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl12.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl12.Controls.Add(Me.grKitItem)
        Me.GroupControl12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl12.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl12.Name = "GroupControl12"
        Me.GroupControl12.Size = New System.Drawing.Size(970, 559)
        Me.GroupControl12.TabIndex = 2
        Me.GroupControl12.Text = "Kit Components"
        '
        'grKitItem
        '
        Me.grKitItem.DataSource = Me.bsKitItem
        Me.grKitItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grKitItem.Location = New System.Drawing.Point(2, 20)
        Me.grKitItem.MainView = Me.GridView10
        Me.grKitItem.Name = "grKitItem"
        Me.grKitItem.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit18, Me.RepositoryItemLookUpEdit19})
        Me.grKitItem.Size = New System.Drawing.Size(966, 537)
        Me.grKitItem.TabIndex = 0
        Me.grKitItem.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10, Me.GridView5})
        '
        'bsKitItem
        '
        Me.bsKitItem.DataSource = GetType(AOS.BusinessObjects.ViewKitComponentCollection)
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComponentqty, Me.colComponentid1, Me.GridColumn18, Me.Vendordesc, Me.GridColumn20, Me.GridColumn21, Me.Unitcost})
        Me.GridView10.GridControl = Me.grKitItem
        Me.GridView10.Name = "GridView10"
        Me.GridView10.OptionsSelection.MultiSelect = True
        Me.GridView10.OptionsView.ShowAutoFilterRow = True
        Me.GridView10.OptionsView.ShowGroupPanel = False
        Me.GridView10.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn21, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colComponentqty
        '
        Me.colComponentqty.Caption = "Qty in Kit"
        Me.colComponentqty.FieldName = "Componentqty"
        Me.colComponentqty.Name = "colComponentqty"
        Me.colComponentqty.OptionsColumn.FixedWidth = True
        Me.colComponentqty.Visible = True
        Me.colComponentqty.VisibleIndex = 0
        Me.colComponentqty.Width = 64
        '
        'colComponentid1
        '
        Me.colComponentid1.Caption = "Comp ID"
        Me.colComponentid1.FieldName = "Componentid"
        Me.colComponentid1.Name = "colComponentid1"
        Me.colComponentid1.OptionsColumn.FixedWidth = True
        Me.colComponentid1.Visible = True
        Me.colComponentid1.VisibleIndex = 1
        Me.colComponentid1.Width = 62
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Americo Desc"
        Me.GridColumn18.FieldName = "Componentdesc"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.AllowEdit = False
        Me.GridColumn18.OptionsColumn.ReadOnly = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 2
        Me.GridColumn18.Width = 235
        '
        'Vendordesc
        '
        Me.Vendordesc.Caption = "Vendor Desc"
        Me.Vendordesc.FieldName = "Vendordesc"
        Me.Vendordesc.Name = "Vendordesc"
        Me.Vendordesc.OptionsColumn.AllowEdit = False
        Me.Vendordesc.OptionsColumn.ReadOnly = True
        Me.Vendordesc.Visible = True
        Me.Vendordesc.VisibleIndex = 3
        Me.Vendordesc.Width = 246
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Vendor Name "
        Me.GridColumn20.FieldName = "Vendorname"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.AllowEdit = False
        Me.GridColumn20.OptionsColumn.ReadOnly = True
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 4
        Me.GridColumn20.Width = 172
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Vendor Item ID"
        Me.GridColumn21.FieldName = "Vendoritemid"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.AllowEdit = False
        Me.GridColumn21.OptionsColumn.FixedWidth = True
        Me.GridColumn21.OptionsColumn.ReadOnly = True
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 5
        Me.GridColumn21.Width = 99
        '
        'Unitcost
        '
        Me.Unitcost.AppearanceCell.Options.UseTextOptions = True
        Me.Unitcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Unitcost.AppearanceHeader.Options.UseTextOptions = True
        Me.Unitcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Unitcost.Caption = "Unit Cost"
        Me.Unitcost.DisplayFormat.FormatString = "c2"
        Me.Unitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Unitcost.FieldName = "Unitcost"
        Me.Unitcost.Name = "Unitcost"
        Me.Unitcost.OptionsColumn.AllowEdit = False
        Me.Unitcost.OptionsColumn.FixedWidth = True
        Me.Unitcost.OptionsColumn.ReadOnly = True
        Me.Unitcost.Visible = True
        Me.Unitcost.VisibleIndex = 6
        Me.Unitcost.Width = 70
        '
        'RepositoryItemLookUpEdit18
        '
        Me.RepositoryItemLookUpEdit18.AutoHeight = False
        Me.RepositoryItemLookUpEdit18.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit18.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit18.Name = "RepositoryItemLookUpEdit18"
        Me.RepositoryItemLookUpEdit18.NullText = ""
        Me.RepositoryItemLookUpEdit18.ReadOnly = True
        Me.RepositoryItemLookUpEdit18.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit19
        '
        Me.RepositoryItemLookUpEdit19.AutoHeight = False
        Me.RepositoryItemLookUpEdit19.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit19.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit19.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit19.Name = "RepositoryItemLookUpEdit19"
        Me.RepositoryItemLookUpEdit19.NullText = ""
        Me.RepositoryItemLookUpEdit19.ValueMember = "Productid"
        '
        'GridView5
        '
        Me.GridView5.GridControl = Me.grKitItem
        Me.GridView5.Name = "GridView5"
        '
        'pnlComponentHolder
        '
        Me.pnlComponentHolder.Controls.Add(Me.gcComponent)
        Me.pnlComponentHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlComponentHolder.Location = New System.Drawing.Point(2, 2)
        Me.pnlComponentHolder.Name = "pnlComponentHolder"
        Me.pnlComponentHolder.Size = New System.Drawing.Size(1490, 579)
        Me.pnlComponentHolder.TabIndex = 3
        '
        'gcComponent
        '
        Me.gcComponent.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.gcComponent.Appearance.Options.UseBackColor = True
        Me.gcComponent.Controls.Add(Me.SplitContainerControl4)
        Me.gcComponent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcComponent.Location = New System.Drawing.Point(2, 2)
        Me.gcComponent.Name = "gcComponent"
        Me.gcComponent.Padding = New System.Windows.Forms.Padding(6)
        Me.gcComponent.Size = New System.Drawing.Size(1486, 575)
        Me.gcComponent.TabIndex = 2
        '
        'SplitContainerControl4
        '
        Me.SplitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl4.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
        Me.SplitContainerControl4.Horizontal = False
        Me.SplitContainerControl4.Location = New System.Drawing.Point(8, 8)
        Me.SplitContainerControl4.Name = "SplitContainerControl4"
        Me.SplitContainerControl4.Panel1.Controls.Add(Me.GroupControl8)
        Me.SplitContainerControl4.Panel1.Text = "Panel1"
        Me.SplitContainerControl4.Panel2.Controls.Add(Me.GroupControl9)
        Me.SplitContainerControl4.Panel2.Text = "Panel2"
        Me.SplitContainerControl4.Size = New System.Drawing.Size(1470, 559)
        Me.SplitContainerControl4.SplitterPosition = 201
        Me.SplitContainerControl4.TabIndex = 0
        Me.SplitContainerControl4.Text = "SplitContainerControl4"
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.grComponents)
        Me.GroupControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl8.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(1470, 353)
        Me.GroupControl8.TabIndex = 1
        Me.GroupControl8.Text = "Components"
        '
        'grComponents
        '
        Me.grComponents.DataSource = Me.bsComponent
        Me.grComponents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grComponents.Location = New System.Drawing.Point(2, 20)
        Me.grComponents.MainView = Me.GridView8
        Me.grComponents.Name = "grComponents"
        Me.grComponents.Size = New System.Drawing.Size(1466, 331)
        Me.grComponents.TabIndex = 0
        Me.grComponents.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'bsComponent
        '
        Me.bsComponent.DataSource = GetType(AOS.BusinessObjects.ComponentCollection)
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colComponentID, Me.colComponentdesc, Me.colVendordesc, Me.colVendorname, Me.colVendoritemid, Me.colUnitcost})
        Me.GridView8.GridControl = Me.grComponents
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsBehavior.Editable = False
        Me.GridView8.OptionsSelection.MultiSelect = True
        Me.GridView8.OptionsView.ShowAutoFilterRow = True
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colVendordesc, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colComponentID
        '
        Me.colComponentID.Caption = "Comp ID "
        Me.colComponentID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colComponentID.FieldName = "Componentid"
        Me.colComponentID.Name = "colComponentID"
        Me.colComponentID.OptionsColumn.AllowEdit = False
        Me.colComponentID.OptionsColumn.FixedWidth = True
        Me.colComponentID.Visible = True
        Me.colComponentID.VisibleIndex = 0
        Me.colComponentID.Width = 55
        '
        'colComponentdesc
        '
        Me.colComponentdesc.Caption = "Americo Desc"
        Me.colComponentdesc.FieldName = "Componentdesc"
        Me.colComponentdesc.Name = "colComponentdesc"
        Me.colComponentdesc.OptionsColumn.AllowEdit = False
        Me.colComponentdesc.Visible = True
        Me.colComponentdesc.VisibleIndex = 1
        Me.colComponentdesc.Width = 411
        '
        'colVendordesc
        '
        Me.colVendordesc.Caption = "Vendor Desc"
        Me.colVendordesc.FieldName = "Vendordesc"
        Me.colVendordesc.Name = "colVendordesc"
        Me.colVendordesc.OptionsColumn.AllowEdit = False
        Me.colVendordesc.Visible = True
        Me.colVendordesc.VisibleIndex = 2
        Me.colVendordesc.Width = 344
        '
        'colVendorname
        '
        Me.colVendorname.Caption = "Vendor Name "
        Me.colVendorname.FieldName = "Vendorname"
        Me.colVendorname.Name = "colVendorname"
        Me.colVendorname.OptionsColumn.AllowEdit = False
        Me.colVendorname.Visible = True
        Me.colVendorname.VisibleIndex = 3
        Me.colVendorname.Width = 319
        '
        'colVendoritemid
        '
        Me.colVendoritemid.Caption = "Vendor Item ID"
        Me.colVendoritemid.FieldName = "Vendoritemid"
        Me.colVendoritemid.Name = "colVendoritemid"
        Me.colVendoritemid.OptionsColumn.AllowEdit = False
        Me.colVendoritemid.OptionsColumn.FixedWidth = True
        Me.colVendoritemid.Visible = True
        Me.colVendoritemid.VisibleIndex = 4
        Me.colVendoritemid.Width = 85
        '
        'colUnitcost
        '
        Me.colUnitcost.AppearanceCell.Options.UseTextOptions = True
        Me.colUnitcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUnitcost.AppearanceHeader.Options.UseTextOptions = True
        Me.colUnitcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colUnitcost.Caption = "Unit Cost"
        Me.colUnitcost.DisplayFormat.FormatString = "D4"
        Me.colUnitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitcost.FieldName = "Unitcost"
        Me.colUnitcost.Name = "colUnitcost"
        Me.colUnitcost.OptionsColumn.AllowEdit = False
        Me.colUnitcost.OptionsColumn.FixedWidth = True
        Me.colUnitcost.Visible = True
        Me.colUnitcost.VisibleIndex = 5
        Me.colUnitcost.Width = 60
        '
        'GroupControl9
        '
        Me.GroupControl9.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupControl9.AppearanceCaption.Options.UseBackColor = True
        Me.GroupControl9.Controls.Add(Me.grAltComponents)
        Me.GroupControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl9.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(1470, 201)
        Me.GroupControl9.TabIndex = 2
        Me.GroupControl9.Text = "Component Alternate(s)"
        '
        'grAltComponents
        '
        Me.grAltComponents.DataSource = Me.bsAltComponent
        Me.grAltComponents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAltComponents.Location = New System.Drawing.Point(2, 20)
        Me.grAltComponents.MainView = Me.GridView9
        Me.grAltComponents.Name = "grAltComponents"
        Me.grAltComponents.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit16, Me.RepositoryItemLookUpEdit17})
        Me.grAltComponents.Size = New System.Drawing.Size(1466, 179)
        Me.grAltComponents.TabIndex = 0
        Me.grAltComponents.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView9})
        '
        'bsAltComponent
        '
        Me.bsAltComponent.DataSource = GetType(AOS.BusinessObjects.ViewAltComponentCollection)
        '
        'GridView9
        '
        Me.GridView9.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAltComponentid, Me.colAltComponentdesc, Me.colAltVendorname, Me.colAltVendordesc, Me.colAltVendoritemid, Me.colAltUnitcost})
        Me.GridView9.GridControl = Me.grAltComponents
        Me.GridView9.Name = "GridView9"
        Me.GridView9.OptionsCustomization.AllowFilter = False
        Me.GridView9.OptionsFilter.AllowFilterEditor = False
        Me.GridView9.OptionsSelection.MultiSelect = True
        Me.GridView9.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GridView9.OptionsView.ShowGroupPanel = False
        Me.GridView9.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colAltComponentid, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colAltComponentid
        '
        Me.colAltComponentid.AppearanceCell.Options.UseTextOptions = True
        Me.colAltComponentid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAltComponentid.Caption = "Comp ID"
        Me.colAltComponentid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAltComponentid.FieldName = "Altcomponentid"
        Me.colAltComponentid.Name = "colAltComponentid"
        Me.colAltComponentid.OptionsColumn.AllowEdit = False
        Me.colAltComponentid.OptionsColumn.FixedWidth = True
        Me.colAltComponentid.OptionsColumn.ReadOnly = True
        Me.colAltComponentid.Visible = True
        Me.colAltComponentid.VisibleIndex = 0
        Me.colAltComponentid.Width = 55
        '
        'colAltComponentdesc
        '
        Me.colAltComponentdesc.Caption = "Americo Desc"
        Me.colAltComponentdesc.FieldName = "Componentdesc"
        Me.colAltComponentdesc.Name = "colAltComponentdesc"
        Me.colAltComponentdesc.OptionsColumn.AllowEdit = False
        Me.colAltComponentdesc.OptionsColumn.ReadOnly = True
        Me.colAltComponentdesc.Visible = True
        Me.colAltComponentdesc.VisibleIndex = 1
        Me.colAltComponentdesc.Width = 413
        '
        'colAltVendorname
        '
        Me.colAltVendorname.Caption = "Vendor Name "
        Me.colAltVendorname.FieldName = "Vendorname"
        Me.colAltVendorname.Name = "colAltVendorname"
        Me.colAltVendorname.OptionsColumn.AllowEdit = False
        Me.colAltVendorname.OptionsColumn.ReadOnly = True
        Me.colAltVendorname.Visible = True
        Me.colAltVendorname.VisibleIndex = 3
        Me.colAltVendorname.Width = 319
        '
        'colAltVendordesc
        '
        Me.colAltVendordesc.Caption = "Vendor Desc"
        Me.colAltVendordesc.FieldName = "Vendordesc"
        Me.colAltVendordesc.Name = "colAltVendordesc"
        Me.colAltVendordesc.OptionsColumn.AllowEdit = False
        Me.colAltVendordesc.OptionsColumn.ReadOnly = True
        Me.colAltVendordesc.Visible = True
        Me.colAltVendordesc.VisibleIndex = 2
        Me.colAltVendordesc.Width = 342
        '
        'colAltVendoritemid
        '
        Me.colAltVendoritemid.Caption = "Vendor Item ID"
        Me.colAltVendoritemid.FieldName = "Vendoritemid"
        Me.colAltVendoritemid.Name = "colAltVendoritemid"
        Me.colAltVendoritemid.OptionsColumn.AllowEdit = False
        Me.colAltVendoritemid.OptionsColumn.FixedWidth = True
        Me.colAltVendoritemid.OptionsColumn.ReadOnly = True
        Me.colAltVendoritemid.Visible = True
        Me.colAltVendoritemid.VisibleIndex = 4
        Me.colAltVendoritemid.Width = 85
        '
        'colAltUnitcost
        '
        Me.colAltUnitcost.AppearanceHeader.Options.UseTextOptions = True
        Me.colAltUnitcost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colAltUnitcost.Caption = "Unit Cost"
        Me.colAltUnitcost.DisplayFormat.FormatString = "c4"
        Me.colAltUnitcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colAltUnitcost.FieldName = "Unitcost"
        Me.colAltUnitcost.Name = "colAltUnitcost"
        Me.colAltUnitcost.OptionsColumn.AllowEdit = False
        Me.colAltUnitcost.OptionsColumn.FixedWidth = True
        Me.colAltUnitcost.OptionsColumn.ReadOnly = True
        Me.colAltUnitcost.Visible = True
        Me.colAltUnitcost.VisibleIndex = 5
        Me.colAltUnitcost.Width = 60
        '
        'RepositoryItemLookUpEdit16
        '
        Me.RepositoryItemLookUpEdit16.AutoHeight = False
        Me.RepositoryItemLookUpEdit16.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit16.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit16.Name = "RepositoryItemLookUpEdit16"
        Me.RepositoryItemLookUpEdit16.NullText = ""
        Me.RepositoryItemLookUpEdit16.ReadOnly = True
        Me.RepositoryItemLookUpEdit16.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit17
        '
        Me.RepositoryItemLookUpEdit17.AutoHeight = False
        Me.RepositoryItemLookUpEdit17.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit17.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit17.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit17.Name = "RepositoryItemLookUpEdit17"
        Me.RepositoryItemLookUpEdit17.NullText = ""
        Me.RepositoryItemLookUpEdit17.ValueMember = "Productid"
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(1494, 583)
        Me.RibbonPanelControl5.TabIndex = 1
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RibbonPanelControl4.Appearance.Options.UseBackColor = True
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1494, 583)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'RibbonPanelControl6
        '
        Me.RibbonPanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl6.Name = "RibbonPanelControl6"
        Me.RibbonPanelControl6.Size = New System.Drawing.Size(1494, 583)
        Me.RibbonPanelControl6.TabIndex = 1
        '
        'RibbonPanelControl7
        '
        Me.RibbonPanelControl7.Controls.Add(Me.GroupControl7)
        Me.RibbonPanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl7.Name = "RibbonPanelControl7"
        Me.RibbonPanelControl7.Size = New System.Drawing.Size(1494, 583)
        Me.RibbonPanelControl7.TabIndex = 1
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.grWorkOrders)
        Me.GroupControl7.Location = New System.Drawing.Point(1, 15)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(1329, 578)
        Me.GroupControl7.TabIndex = 0
        Me.GroupControl7.Text = "Work Order List"
        '
        'grWorkOrders
        '
        Me.grWorkOrders.DataSource = Me.bsWorkOrders
        Me.grWorkOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grWorkOrders.Location = New System.Drawing.Point(2, 20)
        Me.grWorkOrders.MainView = Me.GridView6
        Me.grWorkOrders.Name = "grWorkOrders"
        Me.grWorkOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit6})
        Me.grWorkOrders.Size = New System.Drawing.Size(1325, 556)
        Me.grWorkOrders.TabIndex = 0
        Me.grWorkOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWorkordernumber, Me.colCustordernumber, Me.colCustid, Me.colCustorderdate, Me.colCustomerpo, Me.colPlannedshipdate, Me.colDeliverydate, Me.colOrderstatus})
        Me.GridView6.GridControl = Me.grWorkOrders
        Me.GridView6.GroupPanelText = "OPEN WORK ORDERS"
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsView.ShowAutoFilterRow = True
        Me.GridView6.ViewCaption = "OPEN Work Orders"
        '
        'colWorkordernumber
        '
        Me.colWorkordernumber.Caption = "WO #"
        Me.colWorkordernumber.FieldName = "Workordernumber"
        Me.colWorkordernumber.Name = "colWorkordernumber"
        Me.colWorkordernumber.OptionsColumn.AllowEdit = False
        Me.colWorkordernumber.Visible = True
        Me.colWorkordernumber.VisibleIndex = 0
        Me.colWorkordernumber.Width = 68
        '
        'colCustordernumber
        '
        Me.colCustordernumber.Caption = "Order #"
        Me.colCustordernumber.FieldName = "Custordernumber"
        Me.colCustordernumber.Name = "colCustordernumber"
        Me.colCustordernumber.OptionsColumn.AllowEdit = False
        Me.colCustordernumber.Visible = True
        Me.colCustordernumber.VisibleIndex = 1
        Me.colCustordernumber.Width = 72
        '
        'colCustid
        '
        Me.colCustid.Caption = "Customer"
        Me.colCustid.ColumnEdit = Me.RepositoryItemLookUpEdit6
        Me.colCustid.FieldName = "Custid"
        Me.colCustid.Name = "colCustid"
        Me.colCustid.OptionsColumn.AllowEdit = False
        Me.colCustid.Visible = True
        Me.colCustid.VisibleIndex = 2
        Me.colCustid.Width = 177
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.DataSource = Me.bsCustomers
        Me.RepositoryItemLookUpEdit6.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        Me.RepositoryItemLookUpEdit6.ShowPopupShadow = False
        Me.RepositoryItemLookUpEdit6.ValueMember = "Custid"
        '
        'colCustorderdate
        '
        Me.colCustorderdate.Caption = "Ordered"
        Me.colCustorderdate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colCustorderdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colCustorderdate.FieldName = "Custorderdate"
        Me.colCustorderdate.Name = "colCustorderdate"
        Me.colCustorderdate.OptionsColumn.AllowEdit = False
        Me.colCustorderdate.Visible = True
        Me.colCustorderdate.VisibleIndex = 3
        Me.colCustorderdate.Width = 92
        '
        'colCustomerpo
        '
        Me.colCustomerpo.Caption = "Customer PO"
        Me.colCustomerpo.FieldName = "Customerpo"
        Me.colCustomerpo.Name = "colCustomerpo"
        Me.colCustomerpo.OptionsColumn.AllowEdit = False
        Me.colCustomerpo.Visible = True
        Me.colCustomerpo.VisibleIndex = 4
        Me.colCustomerpo.Width = 87
        '
        'colPlannedshipdate
        '
        Me.colPlannedshipdate.Caption = "Plan Shipment"
        Me.colPlannedshipdate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colPlannedshipdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colPlannedshipdate.FieldName = "Plannedshipdate"
        Me.colPlannedshipdate.Name = "colPlannedshipdate"
        Me.colPlannedshipdate.OptionsColumn.AllowEdit = False
        Me.colPlannedshipdate.Visible = True
        Me.colPlannedshipdate.VisibleIndex = 5
        Me.colPlannedshipdate.Width = 109
        '
        'colDeliverydate
        '
        Me.colDeliverydate.Caption = "Delivery Date"
        Me.colDeliverydate.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.colDeliverydate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.colDeliverydate.FieldName = "Deliverydate"
        Me.colDeliverydate.Name = "colDeliverydate"
        Me.colDeliverydate.OptionsColumn.AllowEdit = False
        Me.colDeliverydate.Visible = True
        Me.colDeliverydate.VisibleIndex = 6
        Me.colDeliverydate.Width = 95
        '
        'colOrderstatus
        '
        Me.colOrderstatus.Caption = "Status"
        Me.colOrderstatus.FieldName = "Orderstatus"
        Me.colOrderstatus.Name = "colOrderstatus"
        Me.colOrderstatus.OptionsColumn.AllowEdit = False
        Me.colOrderstatus.Visible = True
        Me.colOrderstatus.VisibleIndex = 7
        Me.colOrderstatus.Width = 169
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Pick Work Order"
        Me.BarButtonItem1.Id = 59
        Me.BarButtonItem1.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem1.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Pick Work Order"
        Me.BarButtonItem4.Id = 59
        Me.BarButtonItem4.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem4.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Pick Work Order"
        Me.BarButtonItem5.Id = 59
        Me.BarButtonItem5.ImageOptions.LargeImage = CType(resources.GetObject("BarButtonItem5.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'Timer2
        '
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "On Floor Valuation"
        Me.BarButtonItem7.Id = 74
        Me.BarButtonItem7.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Report1
        Me.BarButtonItem7.LargeWidth = 60
        Me.BarButtonItem7.Name = "BarButtonItem7"
        Me.BarButtonItem7.Tag = "174"
        '
        'GridView14
        '
        Me.GridView14.Name = "GridView14"
        '
        'viewInventory
        '
        Me.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.Appearance.Options.UseBackColor = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.DoubleBuffered = True
        Me.LookAndFeel.SkinName = "Money Twins"
        Me.Name = "viewInventory"
        Me.Size = New System.Drawing.Size(1494, 732)
        Me.Tag = "0"
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckedComboBoxEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItemStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.grpInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInventoryItems.ResumeLayout(False)
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEditWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWarehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.gcProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcProducts.ResumeLayout(False)
        CType(Me.grProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryItemsView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.pnlKitHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKitHolder.ResumeLayout(False)
        CType(Me.gcKit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcKit.ResumeLayout(False)
        CType(Me.SplitContainerControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl5.ResumeLayout(False)
        CType(Me.GroupControl13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl13.ResumeLayout(False)
        CType(Me.grKit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl12.ResumeLayout(False)
        CType(Me.grKitItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsKitItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlComponentHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlComponentHolder.ResumeLayout(False)
        CType(Me.gcComponent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcComponent.ResumeLayout(False)
        CType(Me.SplitContainerControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl4.ResumeLayout(False)
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.grComponents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsComponent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        CType(Me.grAltComponents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAltComponent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl7.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.grWorkOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWorkOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsReceiverItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsReceivers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRawMaterialItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWorkOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents btnAddProduct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditProduct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteProduct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsItems As System.Windows.Forms.BindingSource
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnPrintProductLabel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnPrintItemLabel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eQtyAvailable As DevExpress.XtraBars.BarEditItem
    Friend WithEvents eQtyAllocated As DevExpress.XtraBars.BarEditItem
    Friend WithEvents eQtyOnOrder As DevExpress.XtraBars.BarEditItem
    Friend WithEvents btnPrintMiniLabel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents stQtyOnHand As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnRecalculateInventoryQuantities As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents btnAddPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeletePO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsPurchaseOrders As System.Windows.Forms.BindingSource
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents btnAddReceiver As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditReceiver As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteReceiver As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPostReceiver As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintMiniLabel_Receiving As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintProductLabelBarcoded As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsReceivers As System.Windows.Forms.BindingSource
    Friend WithEvents bsReceiverItems As System.Windows.Forms.BindingSource
    Friend WithEvents bsInventoryItems As System.Windows.Forms.BindingSource
    Friend WithEvents btnFetchFinishedGoods As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintMiniInventoryLabels As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnViewAvailableInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintAvailableInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsWorkOrders As System.Windows.Forms.BindingSource
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsWorkOrderItems As System.Windows.Forms.BindingSource
    Friend WithEvents btnPrintAvailableInventoryByBin As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMaintainProducts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup15 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCloseWorkOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grWorkOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As CustomDevExGridView
    Friend WithEvents colWorkordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colCustorderdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerpo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedshipdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliverydate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnInventoryFloorReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup16 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eReportStartDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents eReportEndDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents btnPLReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptInventoryDetail As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOnFloorValuationReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptInventoryDetailAvailableOnly As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCopyProductToNew As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFetchRawMaterials As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsRawMaterialItems As System.Windows.Forms.BindingSource
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents filterItemStatus As DevExpress.XtraBars.BarEditItem
    Friend WithEvents filterItemType As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RibbonPageGroup17 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsInventoryClass As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnItemDetails As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup20 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup21 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup22 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnFixItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsItemStatus As System.Windows.Forms.BindingSource
    Friend WithEvents btnManageContainers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnProductFulfillment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintWOSales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintMaxItemsbyStatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintWOBarcodesReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintTotalInventoryByProduct As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnInventoryAnalysisShortList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRptInventoryAnalysisAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCurrentPhysicalInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnInventoryAnalysisNonShortList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCurrentQuarantined As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnPLNReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnVIEWCOMPONENTS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddComponent As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditComponent As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteComponent As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnVIEWKITS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddKit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditKit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteKit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsComponent As System.Windows.Forms.BindingSource
    Friend WithEvents bsAltComponent As System.Windows.Forms.BindingSource
    Friend WithEvents GridView14 As CustomDevExGridView
    Friend WithEvents bsKit As System.Windows.Forms.BindingSource
    Friend WithEvents bsKitItem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gcKit As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitContainerControl5 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl13 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpInventoryItems As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcProducts As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grProducts As DevExpress.XtraGrid.GridControl
    Friend WithEvents ProductsView As CustomDevExGridView
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents InventoryItemsView As CustomDevExGridView
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colWarehouselocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grInventoryItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents colInvitemnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehousenumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouselocation2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colContainer2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveddate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippeddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LayoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
    Friend WithEvents grKit As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView11 As CustomDevExGridView
    Friend WithEvents colKitid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colKitname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl12 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grKitItem As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView10 As CustomDevExGridView
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit18 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit19 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gcComponent As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitContainerControl4 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grComponents As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As CustomDevExGridView
    Friend WithEvents colComponentID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComponentdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendordesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendoritemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grAltComponents As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView9 As CustomDevExGridView
    Friend WithEvents colAltComponentid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAltComponentdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colAltVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAltVendoritemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView5 As CustomDevExGridView
    Friend WithEvents GridView7 As CustomDevExGridView
    Friend WithEvents GridView12 As CustomDevExGridView
    Friend WithEvents GridView13 As CustomDevExGridView
    Friend WithEvents GridView15 As CustomDevExGridView
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colAltVendordesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAltUnitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vendordesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Unitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlComponentHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlKitHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Ribbon_LargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemDateEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents RepositoryItemCheckedComboBoxEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckedComboBoxEdit
    Friend WithEvents RepositoryItemLookUpEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents rRptStartDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rRptEndDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents rbtnPrintRelabelOrdersSummary As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnFilterFinishedGoods As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnFilterRawMaterial As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnFilterProductsActive As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnFilterProductsInActive As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnFilterProductsAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colKitCost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComponentqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComponentid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnPrintGHSLabel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintGHSLabelByProductOnly As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colChemicalid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChemicalname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend InventoryList As CustomDevExGridView
    Friend WithEvents rbtnFilterProductsPending As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintSDSReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnAllItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnProductSalesHistory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnProductPurchaseHistory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsWarehouse As BindingSource
    Friend WithEvents RepositoryItemLookUpEditWarehouse As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
