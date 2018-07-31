<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewPurchasing2

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
        Dim TermsLabel As System.Windows.Forms.Label
        Dim VendornameLabel As System.Windows.Forms.Label
        Dim VendoracctnumberLabel As System.Windows.Forms.Label
        Dim Vendoraddress1Label As System.Windows.Forms.Label
        Dim VendorurlLabel As System.Windows.Forms.Label
        Dim Vendoraddress2Label As System.Windows.Forms.Label
        Dim VendoremailLabel As System.Windows.Forms.Label
        Dim VendorcityLabel As System.Windows.Forms.Label
        Dim VendorcontactLabel As System.Windows.Forms.Label
        Dim VendorfaxLabel As System.Windows.Forms.Label
        Dim VendorphoneLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewPurchasing2))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode3 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode4 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.DWObtnPendingOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.DWObtnOpenOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.DWObtnClosedOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.DWObtnEditPurchase = New DevExpress.XtraBars.BarButtonItem()
        Me.DWObtnCancelPurchase = New DevExpress.XtraBars.BarButtonItem()
        Me.DWObtnPrintPurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.DWObtnRetriveMaterials = New DevExpress.XtraBars.BarButtonItem()
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnEditPurchaseItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSplitPurchaseItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRequested = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAll = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCreatePurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPendingOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOrderedOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCompletedOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPurchase = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelPurchase = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintPurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRetriveMaterials = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReceivedHold = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOrdered = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnApprovePurchase = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.DWObtnApprovePO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMaterialNeeds = New DevExpress.XtraBars.BarButtonItem()
        Me.btnByVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnByItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelledOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAllOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddPO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintItemList = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddToExistingPO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddPurchaseItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelPurchaseItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancelledPurchaseItems = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReceivedHold = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRefreshPurchaseRequests = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRefreshMaterialNeeds = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFetchVendorsActive = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnFetchVendorsInActive = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonLargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grpVendorProduct_VendorMgmt = New DevExpress.XtraEditors.GroupControl()
        Me.grVendorProduct = New DevExpress.XtraGrid.GridControl()
        Me.bsVendorProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvVendorProducts = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductid_VendorMgmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc_VendorMgmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesc2_VendorMgmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer_VendorMgmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductstatus_VendorMgmt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.TermsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendornameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Vendoraddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendoracctnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Vendoraddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorurlTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendoremailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorstateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorzipTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorphoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorfaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grVendors = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colVendorid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grPurchaseItems = New DevExpress.XtraGrid.GridControl()
        Me.bsPurchaseItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPurchaseItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PItemNo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Dateneeded = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpectedIn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Vendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Unitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.QTY = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UC = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Purchasenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Units = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.UOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SourceType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SourceDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlLegend = New DevExpress.XtraEditors.PanelControl()
        Me.lblRedDesc = New DevExpress.XtraEditors.LabelControl()
        Me.ceRed = New DevExpress.XtraEditors.ColorEdit()
        Me.lblPinkDesc = New DevExpress.XtraEditors.LabelControl()
        Me.lblYellowDesc = New DevExpress.XtraEditors.LabelControl()
        Me.lblColorMapping = New DevExpress.XtraEditors.LabelControl()
        Me.cePink = New DevExpress.XtraEditors.ColorEdit()
        Me.ceYellow = New DevExpress.XtraEditors.ColorEdit()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsMonitorRequests = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvMonitorRequests = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ColorEdit1 = New DevExpress.XtraEditors.ColorEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ColorEdit2 = New DevExpress.XtraEditors.ColorEdit()
        Me.ColorEdit3 = New DevExpress.XtraEditors.ColorEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.grMaterialPlanning = New DevExpress.XtraGrid.GridControl()
        Me.bsMaterialPlanning = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvMaterialPlanning = New AOS.CustomClasses.CustomDevExGridView()
        Me.colMaterialid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmInventory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmInproduction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmOnorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmRequested = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmInprocess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grPOs = New DevExpress.XtraGrid.GridControl()
        Me.bsPOs = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPurchaseOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComponentQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsVendorList = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLateItems = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerpo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.pnlPOLegend = New DevExpress.XtraEditors.PanelControl()
        Me.lblPOPinkDesc = New DevExpress.XtraEditors.LabelControl()
        Me.cePOPink = New DevExpress.XtraEditors.ColorEdit()
        Me.lblPOColorMapping = New DevExpress.XtraEditors.LabelControl()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup17 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnMarkApproved = New DevExpress.XtraBars.BarButtonItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.AppgroupCollection1 = New AOS.BusinessObjects.AppgroupCollection()
        TermsLabel = New System.Windows.Forms.Label()
        VendornameLabel = New System.Windows.Forms.Label()
        VendoracctnumberLabel = New System.Windows.Forms.Label()
        Vendoraddress1Label = New System.Windows.Forms.Label()
        VendorurlLabel = New System.Windows.Forms.Label()
        Vendoraddress2Label = New System.Windows.Forms.Label()
        VendoremailLabel = New System.Windows.Forms.Label()
        VendorcityLabel = New System.Windows.Forms.Label()
        VendorcontactLabel = New System.Windows.Forms.Label()
        VendorfaxLabel = New System.Windows.Forms.Label()
        VendorphoneLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonLargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.grpVendorProduct_VendorMgmt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpVendorProduct_VendorMgmt.SuspendLayout()
        CType(Me.grVendorProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendorProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvVendorProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendornameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vendoraddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendoracctnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vendoraddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorurlTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendoremailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorstateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorzipTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorfaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLegend.SuspendLayout()
        CType(Me.ceRed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cePink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ceYellow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl5.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMonitorRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMonitorRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.ColorEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.grMaterialPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaterialPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMaterialPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlPOLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPOLegend.SuspendLayout()
        CType(Me.cePOPink.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TermsLabel
        '
        TermsLabel.AutoSize = True
        TermsLabel.Location = New System.Drawing.Point(360, 137)
        TermsLabel.Name = "TermsLabel"
        TermsLabel.Size = New System.Drawing.Size(36, 13)
        TermsLabel.TabIndex = 24
        TermsLabel.Text = "Terms"
        '
        'VendornameLabel
        '
        VendornameLabel.AutoSize = True
        VendornameLabel.Location = New System.Drawing.Point(13, 33)
        VendornameLabel.Name = "VendornameLabel"
        VendornameLabel.Size = New System.Drawing.Size(71, 13)
        VendornameLabel.TabIndex = 0
        VendornameLabel.Text = "Vendor Name"
        '
        'VendoracctnumberLabel
        '
        VendoracctnumberLabel.AutoSize = True
        VendoracctnumberLabel.Location = New System.Drawing.Point(360, 111)
        VendoracctnumberLabel.Name = "VendoracctnumberLabel"
        VendoracctnumberLabel.Size = New System.Drawing.Size(57, 13)
        VendoracctnumberLabel.TabIndex = 22
        VendoracctnumberLabel.Text = "Account #"
        '
        'Vendoraddress1Label
        '
        Vendoraddress1Label.AutoSize = True
        Vendoraddress1Label.Location = New System.Drawing.Point(13, 59)
        Vendoraddress1Label.Name = "Vendoraddress1Label"
        Vendoraddress1Label.Size = New System.Drawing.Size(55, 13)
        Vendoraddress1Label.TabIndex = 2
        Vendoraddress1Label.Text = "Address 1"
        '
        'VendorurlLabel
        '
        VendorurlLabel.AutoSize = True
        VendorurlLabel.Location = New System.Drawing.Point(360, 85)
        VendorurlLabel.Name = "VendorurlLabel"
        VendorurlLabel.Size = New System.Drawing.Size(78, 13)
        VendorurlLabel.TabIndex = 20
        VendorurlLabel.Text = "Web Page URL"
        '
        'Vendoraddress2Label
        '
        Vendoraddress2Label.AutoSize = True
        Vendoraddress2Label.Location = New System.Drawing.Point(13, 85)
        Vendoraddress2Label.Name = "Vendoraddress2Label"
        Vendoraddress2Label.Size = New System.Drawing.Size(55, 13)
        Vendoraddress2Label.TabIndex = 4
        Vendoraddress2Label.Text = "Address 2"
        '
        'VendoremailLabel
        '
        VendoremailLabel.AutoSize = True
        VendoremailLabel.Location = New System.Drawing.Point(360, 59)
        VendoremailLabel.Name = "VendoremailLabel"
        VendoremailLabel.Size = New System.Drawing.Size(31, 13)
        VendoremailLabel.TabIndex = 18
        VendoremailLabel.Text = "Email"
        '
        'VendorcityLabel
        '
        VendorcityLabel.AutoSize = True
        VendorcityLabel.Location = New System.Drawing.Point(13, 111)
        VendorcityLabel.Name = "VendorcityLabel"
        VendorcityLabel.Size = New System.Drawing.Size(72, 13)
        VendorcityLabel.TabIndex = 6
        VendorcityLabel.Text = "City State Zip"
        '
        'VendorcontactLabel
        '
        VendorcontactLabel.AutoSize = True
        VendorcontactLabel.Location = New System.Drawing.Point(360, 33)
        VendorcontactLabel.Name = "VendorcontactLabel"
        VendorcontactLabel.Size = New System.Drawing.Size(45, 13)
        VendorcontactLabel.TabIndex = 16
        VendorcontactLabel.Text = "Contact"
        '
        'VendorfaxLabel
        '
        VendorfaxLabel.AutoSize = True
        VendorfaxLabel.Location = New System.Drawing.Point(209, 137)
        VendorfaxLabel.Name = "VendorfaxLabel"
        VendorfaxLabel.Size = New System.Drawing.Size(26, 13)
        VendorfaxLabel.TabIndex = 14
        VendorfaxLabel.Text = "FAX"
        '
        'VendorphoneLabel
        '
        VendorphoneLabel.AutoSize = True
        VendorphoneLabel.Location = New System.Drawing.Point(13, 137)
        VendorphoneLabel.Name = "VendorphoneLabel"
        VendorphoneLabel.Size = New System.Drawing.Size(77, 13)
        VendorphoneLabel.TabIndex = 12
        VendorphoneLabel.Text = "Phone Number"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(705, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(35, 13)
        Label1.TabIndex = 27
        Label1.Text = "Notes"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Vendorname"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.PopupSizeable = False
        Me.RepositoryItemLookUpEdit3.ValueMember = "Vendorid"
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'DWObtnPendingOrders
        '
        Me.DWObtnPendingOrders.Caption = "Pending Orders"
        Me.DWObtnPendingOrders.Id = 88
        Me.DWObtnPendingOrders.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Filter
        Me.DWObtnPendingOrders.Name = "DWObtnPendingOrders"
        '
        'DWObtnOpenOrders
        '
        Me.DWObtnOpenOrders.Caption = "Open Orders"
        Me.DWObtnOpenOrders.Id = 89
        Me.DWObtnOpenOrders.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Filter
        Me.DWObtnOpenOrders.Name = "DWObtnOpenOrders"
        '
        'DWObtnClosedOrders
        '
        Me.DWObtnClosedOrders.Caption = "Closed Orders"
        Me.DWObtnClosedOrders.Id = 90
        Me.DWObtnClosedOrders.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Filter
        Me.DWObtnClosedOrders.Name = "DWObtnClosedOrders"
        '
        'DWObtnEditPurchase
        '
        Me.DWObtnEditPurchase.Caption = "Edit PO"
        Me.DWObtnEditPurchase.Id = 91
        Me.DWObtnEditPurchase.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.EditData
        Me.DWObtnEditPurchase.Name = "DWObtnEditPurchase"
        '
        'DWObtnCancelPurchase
        '
        Me.DWObtnCancelPurchase.Caption = "Cancel PO"
        Me.DWObtnCancelPurchase.Id = 92
        Me.DWObtnCancelPurchase.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.document_text_delete
        Me.DWObtnCancelPurchase.Name = "DWObtnCancelPurchase"
        '
        'DWObtnPrintPurchaseOrder
        '
        Me.DWObtnPrintPurchaseOrder.Caption = "Print PO"
        Me.DWObtnPrintPurchaseOrder.Id = 93
        Me.DWObtnPrintPurchaseOrder.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Report1
        Me.DWObtnPrintPurchaseOrder.Name = "DWObtnPrintPurchaseOrder"
        '
        'DWObtnRetriveMaterials
        '
        Me.DWObtnRetriveMaterials.Caption = "Retrive Materials"
        Me.DWObtnRetriveMaterials.Id = 94
        Me.DWObtnRetriveMaterials.ImageOptions.LargeImage = CType(resources.GetObject("DWObtnRetriveMaterials.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.DWObtnRetriveMaterials.Name = "DWObtnRetriveMaterials"
        '
        'FormCaption
        '
        Me.FormCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormCaption.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCaption.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.FormCaption.EmbeddedNavigator.Appearance.Options.UseTextOptions = True
        Me.FormCaption.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.FormCaption.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.FormCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCaption.Location = New System.Drawing.Point(0, 0)
        Me.FormCaption.LookAndFeel.SkinName = "Money Twins"
        Me.FormCaption.MainView = Me.GridView1
        Me.FormCaption.Name = "FormCaption"
        Me.FormCaption.Size = New System.Drawing.Size(1433, 33)
        Me.FormCaption.TabIndex = 3
        Me.FormCaption.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridView1.GridControl = Me.FormCaption
        Me.GridView1.GroupPanelText = "Purchasing"
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
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnEditPurchaseItem, Me.btnSplitPurchaseItem, Me.btnRequested, Me.btnAll, Me.btnCreatePurchaseOrder, Me.btnPendingOrders, Me.btnOrderedOrders, Me.btnCompletedOrders, Me.btnEditPurchase, Me.btnCancelPurchase, Me.btnPrintPurchaseOrder, Me.btnRetriveMaterials, Me.btnAddVendor, Me.btnEditVendor, Me.btnDeleteVendor, Me.btnReceivedHold, Me.DWObtnPendingOrders, Me.DWObtnOpenOrders, Me.DWObtnClosedOrders, Me.DWObtnEditPurchase, Me.DWObtnCancelPurchase, Me.DWObtnPrintPurchaseOrder, Me.DWObtnRetriveMaterials, Me.btnOrdered, Me.BarButtonItem6, Me.btnApprovePurchase, Me.BarButtonItem5, Me.BarButtonItem7, Me.DWObtnApprovePO, Me.btnMaterialNeeds, Me.btnByVendor, Me.btnByItem, Me.btnCancelledOrders, Me.btnAllOrders, Me.btnAddPO, Me.btnPrintItemList, Me.btnAddToExistingPO, Me.btnAddPurchaseItem, Me.btnCancelPurchaseItem, Me.rbtnCancelledPurchaseItems, Me.rbtnReceivedHold, Me.rbtnRefreshPurchaseRequests, Me.rbtnRefreshMaterialNeeds, Me.rbtnFetchVendorsActive, Me.rbtnFetchVendorsInActive})
        Me.RibbonControl1.LargeImages = Me.RibbonLargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 141
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4, Me.RibbonPage5})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1433, 117)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnEditPurchaseItem
        '
        Me.btnEditPurchaseItem.Caption = "  Edit  Purchase Item"
        Me.btnEditPurchaseItem.Id = 82
        Me.btnEditPurchaseItem.ImageOptions.LargeImageIndex = 20
        Me.btnEditPurchaseItem.Name = "btnEditPurchaseItem"
        Me.btnEditPurchaseItem.Tag = "331"
        '
        'btnSplitPurchaseItem
        '
        Me.btnSplitPurchaseItem.Caption = "Split Purchase Item"
        Me.btnSplitPurchaseItem.Id = 83
        Me.btnSplitPurchaseItem.ImageOptions.LargeImageIndex = 33
        Me.btnSplitPurchaseItem.Name = "btnSplitPurchaseItem"
        Me.btnSplitPurchaseItem.Tag = "333"
        '
        'btnRequested
        '
        Me.btnRequested.Caption = "Requested"
        Me.btnRequested.Id = 85
        Me.btnRequested.ImageOptions.LargeImageIndex = 18
        Me.btnRequested.Name = "btnRequested"
        Me.btnRequested.Tag = "323"
        '
        'btnAll
        '
        Me.btnAll.Caption = "All"
        Me.btnAll.Id = 86
        Me.btnAll.ImageOptions.Image = Global.AOS.My.Resources.Resources.Search
        Me.btnAll.ImageOptions.LargeImageIndex = 18
        Me.btnAll.Name = "btnAll"
        Me.btnAll.Tag = "327"
        '
        'btnCreatePurchaseOrder
        '
        Me.btnCreatePurchaseOrder.Caption = "Create New Purchase Order"
        Me.btnCreatePurchaseOrder.Id = 87
        Me.btnCreatePurchaseOrder.ImageOptions.LargeImageIndex = 2
        Me.btnCreatePurchaseOrder.Name = "btnCreatePurchaseOrder"
        Me.btnCreatePurchaseOrder.Tag = "334"
        '
        'btnPendingOrders
        '
        Me.btnPendingOrders.Caption = "Pending"
        Me.btnPendingOrders.Id = 88
        Me.btnPendingOrders.ImageOptions.LargeImageIndex = 1
        Me.btnPendingOrders.LargeWidth = 50
        Me.btnPendingOrders.Name = "btnPendingOrders"
        Me.btnPendingOrders.Tag = "337"
        '
        'btnOrderedOrders
        '
        Me.btnOrderedOrders.Caption = "Ordered"
        Me.btnOrderedOrders.Id = 89
        Me.btnOrderedOrders.ImageOptions.LargeImageIndex = 1
        Me.btnOrderedOrders.LargeWidth = 50
        Me.btnOrderedOrders.Name = "btnOrderedOrders"
        Me.btnOrderedOrders.Tag = "338"
        '
        'btnCompletedOrders
        '
        Me.btnCompletedOrders.Caption = "Completed"
        Me.btnCompletedOrders.Id = 90
        Me.btnCompletedOrders.ImageOptions.LargeImageIndex = 1
        Me.btnCompletedOrders.Name = "btnCompletedOrders"
        Me.btnCompletedOrders.Tag = "339"
        '
        'btnEditPurchase
        '
        Me.btnEditPurchase.Caption = "Edit PO"
        Me.btnEditPurchase.Id = 91
        Me.btnEditPurchase.ImageOptions.LargeImageIndex = 3
        Me.btnEditPurchase.Name = "btnEditPurchase"
        Me.btnEditPurchase.Tag = "344"
        '
        'btnCancelPurchase
        '
        Me.btnCancelPurchase.Caption = "Cancel PO"
        Me.btnCancelPurchase.Id = 92
        Me.btnCancelPurchase.ImageOptions.LargeImageIndex = 4
        Me.btnCancelPurchase.Name = "btnCancelPurchase"
        Me.btnCancelPurchase.Tag = "345"
        '
        'btnPrintPurchaseOrder
        '
        Me.btnPrintPurchaseOrder.Caption = "Print PO"
        Me.btnPrintPurchaseOrder.Id = 93
        Me.btnPrintPurchaseOrder.ImageOptions.LargeImageIndex = 8
        Me.btnPrintPurchaseOrder.Name = "btnPrintPurchaseOrder"
        Me.btnPrintPurchaseOrder.Tag = "346"
        '
        'btnRetriveMaterials
        '
        Me.btnRetriveMaterials.Caption = "Retrive Materials"
        Me.btnRetriveMaterials.Id = 94
        Me.btnRetriveMaterials.ImageOptions.LargeImage = CType(resources.GetObject("btnRetriveMaterials.ImageOptions.LargeImage"), System.Drawing.Image)
        Me.btnRetriveMaterials.Name = "btnRetriveMaterials"
        '
        'btnAddVendor
        '
        Me.btnAddVendor.Caption = "Add New Vendor"
        Me.btnAddVendor.Id = 95
        Me.btnAddVendor.ImageOptions.LargeImageIndex = 2
        Me.btnAddVendor.Name = "btnAddVendor"
        '
        'btnEditVendor
        '
        Me.btnEditVendor.Caption = "Edit Vendor"
        Me.btnEditVendor.Id = 96
        Me.btnEditVendor.ImageOptions.LargeImageIndex = 3
        Me.btnEditVendor.Name = "btnEditVendor"
        '
        'btnDeleteVendor
        '
        Me.btnDeleteVendor.Caption = "Delete Vendor"
        Me.btnDeleteVendor.Id = 97
        Me.btnDeleteVendor.ImageOptions.LargeImageIndex = 4
        Me.btnDeleteVendor.Name = "btnDeleteVendor"
        '
        'btnReceivedHold
        '
        Me.btnReceivedHold.Caption = "Received"
        Me.btnReceivedHold.Id = 98
        Me.btnReceivedHold.ImageOptions.LargeImageIndex = 18
        Me.btnReceivedHold.Name = "btnReceivedHold"
        Me.btnReceivedHold.Tag = "325"
        '
        'btnOrdered
        '
        Me.btnOrdered.Caption = "Ordered"
        Me.btnOrdered.Id = 99
        Me.btnOrdered.ImageOptions.LargeImageIndex = 18
        Me.btnOrdered.Name = "btnOrdered"
        Me.btnOrdered.Tag = "324"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "BarButtonItem6"
        Me.BarButtonItem6.Id = 104
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'btnApprovePurchase
        '
        Me.btnApprovePurchase.Caption = "Approve PO"
        Me.btnApprovePurchase.Id = 105
        Me.btnApprovePurchase.ImageOptions.LargeImageIndex = 9
        Me.btnApprovePurchase.Name = "btnApprovePurchase"
        Me.btnApprovePurchase.Tag = "342"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "BarButtonItem5"
        Me.BarButtonItem5.Id = 107
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "BarButtonItem7"
        Me.BarButtonItem7.Id = 108
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'DWObtnApprovePO
        '
        Me.DWObtnApprovePO.Caption = "Approve PO"
        Me.DWObtnApprovePO.Id = 109
        Me.DWObtnApprovePO.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.form_arrow_right
        Me.DWObtnApprovePO.Name = "DWObtnApprovePO"
        '
        'btnMaterialNeeds
        '
        Me.btnMaterialNeeds.Caption = "Material Needs"
        Me.btnMaterialNeeds.Id = 122
        Me.btnMaterialNeeds.ImageOptions.LargeImageIndex = 36
        Me.btnMaterialNeeds.Name = "btnMaterialNeeds"
        Me.btnMaterialNeeds.Tag = "336"
        '
        'btnByVendor
        '
        Me.btnByVendor.Caption = "By Vendor"
        Me.btnByVendor.Id = 123
        Me.btnByVendor.ImageOptions.LargeImageIndex = 35
        Me.btnByVendor.Name = "btnByVendor"
        Me.btnByVendor.Tag = "328"
        '
        'btnByItem
        '
        Me.btnByItem.Caption = "By Item"
        Me.btnByItem.Id = 124
        Me.btnByItem.ImageOptions.LargeImageIndex = 31
        Me.btnByItem.Name = "btnByItem"
        Me.btnByItem.Tag = "329"
        '
        'btnCancelledOrders
        '
        Me.btnCancelledOrders.Caption = "Cancelled"
        Me.btnCancelledOrders.Id = 125
        Me.btnCancelledOrders.ImageOptions.LargeImageIndex = 1
        Me.btnCancelledOrders.Name = "btnCancelledOrders"
        Me.btnCancelledOrders.Tag = "340"
        '
        'btnAllOrders
        '
        Me.btnAllOrders.Caption = "All"
        Me.btnAllOrders.Id = 127
        Me.btnAllOrders.ImageOptions.Image = Global.AOS.My.Resources.Resources.FindRecord
        Me.btnAllOrders.ImageOptions.LargeImageIndex = 1
        Me.btnAllOrders.Name = "btnAllOrders"
        Me.btnAllOrders.Tag = "341"
        '
        'btnAddPO
        '
        Me.btnAddPO.Caption = "Add PO"
        Me.btnAddPO.Id = 128
        Me.btnAddPO.ImageOptions.LargeImageIndex = 2
        Me.btnAddPO.Name = "btnAddPO"
        Me.btnAddPO.Tag = "343"
        '
        'btnPrintItemList
        '
        Me.btnPrintItemList.Caption = "Print Items List"
        Me.btnPrintItemList.Id = 129
        Me.btnPrintItemList.ImageOptions.LargeImageIndex = 7
        Me.btnPrintItemList.Name = "btnPrintItemList"
        Me.btnPrintItemList.Tag = "347"
        '
        'btnAddToExistingPO
        '
        Me.btnAddToExistingPO.Caption = "Add to Existing Purchase Order"
        Me.btnAddToExistingPO.Id = 130
        Me.btnAddToExistingPO.ImageOptions.LargeImageIndex = 3
        Me.btnAddToExistingPO.Name = "btnAddToExistingPO"
        Me.btnAddToExistingPO.Tag = "335"
        '
        'btnAddPurchaseItem
        '
        Me.btnAddPurchaseItem.Caption = "Add New Purchase Item"
        Me.btnAddPurchaseItem.Id = 131
        Me.btnAddPurchaseItem.ImageOptions.LargeImageIndex = 19
        Me.btnAddPurchaseItem.Name = "btnAddPurchaseItem"
        Me.btnAddPurchaseItem.Tag = "330"
        '
        'btnCancelPurchaseItem
        '
        Me.btnCancelPurchaseItem.Caption = "Cancel Purchase Item"
        Me.btnCancelPurchaseItem.Id = 132
        Me.btnCancelPurchaseItem.ImageOptions.LargeImageIndex = 21
        Me.btnCancelPurchaseItem.Name = "btnCancelPurchaseItem"
        Me.btnCancelPurchaseItem.Tag = "332"
        '
        'rbtnCancelledPurchaseItems
        '
        Me.rbtnCancelledPurchaseItems.Caption = "Cancelled"
        Me.rbtnCancelledPurchaseItems.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnCancelledPurchaseItems.Id = 134
        Me.rbtnCancelledPurchaseItems.ImageOptions.LargeImageIndex = 18
        Me.rbtnCancelledPurchaseItems.Name = "rbtnCancelledPurchaseItems"
        Me.rbtnCancelledPurchaseItems.Tag = "326"
        '
        'rbtnReceivedHold
        '
        Me.rbtnReceivedHold.Caption = "Manage Received / Hold Items"
        Me.rbtnReceivedHold.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnReceivedHold.Id = 135
        Me.rbtnReceivedHold.ImageOptions.LargeImageIndex = 7
        Me.rbtnReceivedHold.Name = "rbtnReceivedHold"
        '
        'rbtnRefreshPurchaseRequests
        '
        Me.rbtnRefreshPurchaseRequests.Caption = "Purchase Requests"
        Me.rbtnRefreshPurchaseRequests.Id = 137
        Me.rbtnRefreshPurchaseRequests.ImageOptions.LargeImageIndex = 18
        Me.rbtnRefreshPurchaseRequests.Name = "rbtnRefreshPurchaseRequests"
        '
        'rbtnRefreshMaterialNeeds
        '
        Me.rbtnRefreshMaterialNeeds.Caption = "Material Needs"
        Me.rbtnRefreshMaterialNeeds.Id = 138
        Me.rbtnRefreshMaterialNeeds.ImageOptions.LargeImageIndex = 36
        Me.rbtnRefreshMaterialNeeds.Name = "rbtnRefreshMaterialNeeds"
        '
        'rbtnFetchVendorsActive
        '
        Me.rbtnFetchVendorsActive.Caption = "Active Vendors"
        Me.rbtnFetchVendorsActive.Id = 139
        Me.rbtnFetchVendorsActive.ImageOptions.LargeImageIndex = 1
        Me.rbtnFetchVendorsActive.Name = "rbtnFetchVendorsActive"
        '
        'rbtnFetchVendorsInActive
        '
        Me.rbtnFetchVendorsInActive.Caption = "Inactive Vendors"
        Me.rbtnFetchVendorsInActive.Id = 140
        Me.rbtnFetchVendorsInActive.ImageOptions.LargeImageIndex = 1
        Me.rbtnFetchVendorsInActive.Name = "rbtnFetchVendorsInActive"
        '
        'RibbonLargeImages
        '
        Me.RibbonLargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.RibbonLargeImages.ImageStream = CType(resources.GetObject("RibbonLargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup13, Me.RibbonPageGroup1, Me.RibbonPageGroup4, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "129"
        Me.RibbonPage1.Text = "Purchase Items" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnRequested)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnOrdered)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnReceivedHold)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnCancelledPurchaseItems)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnAll, True)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Retrieve Purchase Items"
        '
        'RibbonPageGroup13
        '
        Me.RibbonPageGroup13.ItemLinks.Add(Me.btnByVendor)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.btnByItem)
        Me.RibbonPageGroup13.Name = "RibbonPageGroup13"
        Me.RibbonPageGroup13.ShowCaptionButton = False
        Me.RibbonPageGroup13.Text = "Grouping"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddPurchaseItem)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditPurchaseItem)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancelPurchaseItem)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnSplitPurchaseItem)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Purchase Item Information"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnCreatePurchaseOrder, True)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnAddToExistingPO)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Purchase Orders"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnMaterialNeeds)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Materials"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup6})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Tag = "130"
        Me.RibbonPage2.Text = "POs"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnPendingOrders)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnOrderedOrders)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnCompletedOrders)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnCancelledOrders)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnAllOrders, True)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Retrieve Purchase Orders"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnApprovePurchase)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnAddPO, True)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnEditPurchase)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnPrintPurchaseOrder, True)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnPrintItemList)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnCancelPurchase, True)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Purchase Order Actions"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup9, Me.RibbonPageGroup12})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Tag = "131"
        Me.RibbonPage3.Text = "Vendor Mgmt"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.AllowMinimize = False
        Me.RibbonPageGroup9.AllowTextClipping = False
        Me.RibbonPageGroup9.ItemLinks.Add(Me.rbtnFetchVendorsActive)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.rbtnFetchVendorsInActive)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.ShowCaptionButton = False
        Me.RibbonPageGroup9.Text = "Vendor Filter Options"
        '
        'RibbonPageGroup12
        '
        Me.RibbonPageGroup12.ItemLinks.Add(Me.btnAddVendor)
        Me.RibbonPageGroup12.ItemLinks.Add(Me.btnEditVendor)
        Me.RibbonPageGroup12.ItemLinks.Add(Me.btnDeleteVendor)
        Me.RibbonPageGroup12.Name = "RibbonPageGroup12"
        Me.RibbonPageGroup12.Text = "Vendor Information"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup7})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Tag = "132"
        Me.RibbonPage4.Text = "Receiving"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowMinimize = False
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnReceivedHold)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Received / Hold"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup8})
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Tag = "133"
        Me.RibbonPage5.Text = "Monitor"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.AllowMinimize = False
        Me.RibbonPageGroup8.AllowTextClipping = False
        Me.RibbonPageGroup8.ItemLinks.Add(Me.rbtnRefreshPurchaseRequests)
        Me.RibbonPageGroup8.ItemLinks.Add(Me.rbtnRefreshMaterialNeeds)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Actions"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "BarButtonItem4"
        Me.BarButtonItem4.Id = 79
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "BarButtonItem3"
        Me.BarButtonItem3.Id = 78
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'WorkPanelsHolder
        '
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 150)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1433, 474)
        Me.WorkPanelsHolder.TabIndex = 4
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.PanelControl4)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1429, 470)
        Me.RibbonPanelControl3.TabIndex = 4
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.PanelControl9)
        Me.PanelControl4.Controls.Add(Me.PanelControl8)
        Me.PanelControl4.Controls.Add(Me.GroupControl4)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl4.Size = New System.Drawing.Size(1425, 466)
        Me.PanelControl4.TabIndex = 6
        '
        'PanelControl9
        '
        Me.PanelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl9.Controls.Add(Me.PanelControl3)
        Me.PanelControl9.Controls.Add(Me.PanelControl1)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl9.Location = New System.Drawing.Point(399, 8)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(1018, 450)
        Me.PanelControl9.TabIndex = 2
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.grpVendorProduct_VendorMgmt)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 170)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(1018, 280)
        Me.PanelControl3.TabIndex = 31
        '
        'grpVendorProduct_VendorMgmt
        '
        Me.grpVendorProduct_VendorMgmt.Controls.Add(Me.grVendorProduct)
        Me.grpVendorProduct_VendorMgmt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpVendorProduct_VendorMgmt.Location = New System.Drawing.Point(2, 2)
        Me.grpVendorProduct_VendorMgmt.Name = "grpVendorProduct_VendorMgmt"
        Me.grpVendorProduct_VendorMgmt.Size = New System.Drawing.Size(1014, 276)
        Me.grpVendorProduct_VendorMgmt.TabIndex = 29
        Me.grpVendorProduct_VendorMgmt.Text = "Products for Vendor"
        '
        'grVendorProduct
        '
        Me.grVendorProduct.DataSource = Me.bsVendorProducts
        Me.grVendorProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grVendorProduct.Location = New System.Drawing.Point(2, 22)
        Me.grVendorProduct.LookAndFeel.SkinName = "Money Twins"
        Me.grVendorProduct.MainView = Me.grvVendorProducts
        Me.grVendorProduct.Name = "grVendorProduct"
        Me.grVendorProduct.Size = New System.Drawing.Size(1010, 252)
        Me.grVendorProduct.TabIndex = 29
        Me.grVendorProduct.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvVendorProducts})
        '
        'bsVendorProducts
        '
        Me.bsVendorProducts.DataSource = GetType(AOS.BusinessObjects.ViewVendorProductAllCollection)
        '
        'grvVendorProducts
        '
        Me.grvVendorProducts.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid_VendorMgmt, Me.colProductdesc_VendorMgmt, Me.colDesc2_VendorMgmt, Me.colContainer_VendorMgmt, Me.colProductstatus_VendorMgmt})
        Me.grvVendorProducts.GridControl = Me.grVendorProduct
        Me.grvVendorProducts.Name = "grvVendorProducts"
        Me.grvVendorProducts.OptionsBehavior.Editable = False
        Me.grvVendorProducts.OptionsView.ShowAutoFilterRow = True
        Me.grvVendorProducts.OptionsView.ShowGroupPanel = False
        '
        'colProductid_VendorMgmt
        '
        Me.colProductid_VendorMgmt.Caption = "Product Id"
        Me.colProductid_VendorMgmt.FieldName = "Productid"
        Me.colProductid_VendorMgmt.Name = "colProductid_VendorMgmt"
        Me.colProductid_VendorMgmt.Visible = True
        Me.colProductid_VendorMgmt.VisibleIndex = 0
        Me.colProductid_VendorMgmt.Width = 77
        '
        'colProductdesc_VendorMgmt
        '
        Me.colProductdesc_VendorMgmt.Caption = "Product Desc"
        Me.colProductdesc_VendorMgmt.FieldName = "Productdesc"
        Me.colProductdesc_VendorMgmt.Name = "colProductdesc_VendorMgmt"
        Me.colProductdesc_VendorMgmt.Visible = True
        Me.colProductdesc_VendorMgmt.VisibleIndex = 1
        Me.colProductdesc_VendorMgmt.Width = 338
        '
        'colDesc2_VendorMgmt
        '
        Me.colDesc2_VendorMgmt.Caption = "Addn Desc"
        Me.colDesc2_VendorMgmt.FieldName = "Desc2"
        Me.colDesc2_VendorMgmt.Name = "colDesc2_VendorMgmt"
        Me.colDesc2_VendorMgmt.Visible = True
        Me.colDesc2_VendorMgmt.VisibleIndex = 2
        Me.colDesc2_VendorMgmt.Width = 275
        '
        'colContainer_VendorMgmt
        '
        Me.colContainer_VendorMgmt.Caption = "Container"
        Me.colContainer_VendorMgmt.FieldName = "Container"
        Me.colContainer_VendorMgmt.Name = "colContainer_VendorMgmt"
        Me.colContainer_VendorMgmt.Visible = True
        Me.colContainer_VendorMgmt.VisibleIndex = 3
        Me.colContainer_VendorMgmt.Width = 137
        '
        'colProductstatus_VendorMgmt
        '
        Me.colProductstatus_VendorMgmt.Caption = "Product Status"
        Me.colProductstatus_VendorMgmt.FieldName = "Productstatus"
        Me.colProductstatus_VendorMgmt.Name = "colProductstatus_VendorMgmt"
        Me.colProductstatus_VendorMgmt.Visible = True
        Me.colProductstatus_VendorMgmt.VisibleIndex = 4
        Me.colProductstatus_VendorMgmt.Width = 166
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl3)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1018, 170)
        Me.PanelControl1.TabIndex = 30
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.MemoEdit1)
        Me.GroupControl3.Controls.Add(Label1)
        Me.GroupControl3.Controls.Add(Me.TermsTextEdit)
        Me.GroupControl3.Controls.Add(TermsLabel)
        Me.GroupControl3.Controls.Add(Me.VendornameTextEdit)
        Me.GroupControl3.Controls.Add(VendornameLabel)
        Me.GroupControl3.Controls.Add(VendoracctnumberLabel)
        Me.GroupControl3.Controls.Add(Me.Vendoraddress1TextEdit)
        Me.GroupControl3.Controls.Add(Me.VendoracctnumberTextEdit)
        Me.GroupControl3.Controls.Add(Vendoraddress1Label)
        Me.GroupControl3.Controls.Add(VendorurlLabel)
        Me.GroupControl3.Controls.Add(Me.Vendoraddress2TextEdit)
        Me.GroupControl3.Controls.Add(Me.VendorurlTextEdit)
        Me.GroupControl3.Controls.Add(Vendoraddress2Label)
        Me.GroupControl3.Controls.Add(VendoremailLabel)
        Me.GroupControl3.Controls.Add(Me.VendorcityTextEdit)
        Me.GroupControl3.Controls.Add(Me.VendoremailTextEdit)
        Me.GroupControl3.Controls.Add(VendorcityLabel)
        Me.GroupControl3.Controls.Add(VendorcontactLabel)
        Me.GroupControl3.Controls.Add(Me.VendorstateTextEdit)
        Me.GroupControl3.Controls.Add(Me.VendorcontactTextEdit)
        Me.GroupControl3.Controls.Add(Me.VendorzipTextEdit)
        Me.GroupControl3.Controls.Add(VendorfaxLabel)
        Me.GroupControl3.Controls.Add(Me.VendorphoneTextEdit)
        Me.GroupControl3.Controls.Add(Me.VendorfaxTextEdit)
        Me.GroupControl3.Controls.Add(VendorphoneLabel)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1014, 167)
        Me.GroupControl3.TabIndex = 27
        Me.GroupControl3.Text = "Vendor Information"
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendornotes", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(746, 31)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Properties.ReadOnly = True
        Me.MemoEdit1.Size = New System.Drawing.Size(250, 123)
        Me.MemoEdit1.TabIndex = 54
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'TermsTextEdit
        '
        Me.TermsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Terms", True))
        Me.TermsTextEdit.Location = New System.Drawing.Point(444, 134)
        Me.TermsTextEdit.Name = "TermsTextEdit"
        Me.TermsTextEdit.Properties.ReadOnly = True
        Me.TermsTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.TermsTextEdit.TabIndex = 25
        '
        'VendornameTextEdit
        '
        Me.VendornameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendorname", True))
        Me.VendornameTextEdit.Location = New System.Drawing.Point(97, 30)
        Me.VendornameTextEdit.Name = "VendornameTextEdit"
        Me.VendornameTextEdit.Properties.ReadOnly = True
        Me.VendornameTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendornameTextEdit.TabIndex = 1
        '
        'Vendoraddress1TextEdit
        '
        Me.Vendoraddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendoraddress1", True))
        Me.Vendoraddress1TextEdit.Location = New System.Drawing.Point(97, 56)
        Me.Vendoraddress1TextEdit.Name = "Vendoraddress1TextEdit"
        Me.Vendoraddress1TextEdit.Properties.ReadOnly = True
        Me.Vendoraddress1TextEdit.Size = New System.Drawing.Size(251, 20)
        Me.Vendoraddress1TextEdit.TabIndex = 3
        '
        'VendoracctnumberTextEdit
        '
        Me.VendoracctnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendoracctnumber", True))
        Me.VendoracctnumberTextEdit.Location = New System.Drawing.Point(444, 108)
        Me.VendoracctnumberTextEdit.Name = "VendoracctnumberTextEdit"
        Me.VendoracctnumberTextEdit.Properties.ReadOnly = True
        Me.VendoracctnumberTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendoracctnumberTextEdit.TabIndex = 23
        '
        'Vendoraddress2TextEdit
        '
        Me.Vendoraddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendoraddress2", True))
        Me.Vendoraddress2TextEdit.Location = New System.Drawing.Point(97, 82)
        Me.Vendoraddress2TextEdit.Name = "Vendoraddress2TextEdit"
        Me.Vendoraddress2TextEdit.Properties.ReadOnly = True
        Me.Vendoraddress2TextEdit.Size = New System.Drawing.Size(251, 20)
        Me.Vendoraddress2TextEdit.TabIndex = 5
        '
        'VendorurlTextEdit
        '
        Me.VendorurlTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendorurl", True))
        Me.VendorurlTextEdit.Location = New System.Drawing.Point(444, 82)
        Me.VendorurlTextEdit.Name = "VendorurlTextEdit"
        Me.VendorurlTextEdit.Properties.ReadOnly = True
        Me.VendorurlTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendorurlTextEdit.TabIndex = 21
        '
        'VendorcityTextEdit
        '
        Me.VendorcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendorcity", True))
        Me.VendorcityTextEdit.Location = New System.Drawing.Point(97, 108)
        Me.VendorcityTextEdit.Name = "VendorcityTextEdit"
        Me.VendorcityTextEdit.Properties.ReadOnly = True
        Me.VendorcityTextEdit.Size = New System.Drawing.Size(150, 20)
        Me.VendorcityTextEdit.TabIndex = 7
        '
        'VendoremailTextEdit
        '
        Me.VendoremailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendoremail", True))
        Me.VendoremailTextEdit.Location = New System.Drawing.Point(444, 56)
        Me.VendoremailTextEdit.Name = "VendoremailTextEdit"
        Me.VendoremailTextEdit.Properties.ReadOnly = True
        Me.VendoremailTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendoremailTextEdit.TabIndex = 19
        '
        'VendorstateTextEdit
        '
        Me.VendorstateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendorstate", True))
        Me.VendorstateTextEdit.Location = New System.Drawing.Point(253, 108)
        Me.VendorstateTextEdit.Name = "VendorstateTextEdit"
        Me.VendorstateTextEdit.Properties.ReadOnly = True
        Me.VendorstateTextEdit.Size = New System.Drawing.Size(26, 20)
        Me.VendorstateTextEdit.TabIndex = 9
        '
        'VendorcontactTextEdit
        '
        Me.VendorcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendorcontact", True))
        Me.VendorcontactTextEdit.Location = New System.Drawing.Point(444, 30)
        Me.VendorcontactTextEdit.Name = "VendorcontactTextEdit"
        Me.VendorcontactTextEdit.Properties.ReadOnly = True
        Me.VendorcontactTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendorcontactTextEdit.TabIndex = 17
        '
        'VendorzipTextEdit
        '
        Me.VendorzipTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendorzip", True))
        Me.VendorzipTextEdit.Location = New System.Drawing.Point(285, 108)
        Me.VendorzipTextEdit.Name = "VendorzipTextEdit"
        Me.VendorzipTextEdit.Properties.ReadOnly = True
        Me.VendorzipTextEdit.Size = New System.Drawing.Size(63, 20)
        Me.VendorzipTextEdit.TabIndex = 11
        '
        'VendorphoneTextEdit
        '
        Me.VendorphoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendorphone", True))
        Me.VendorphoneTextEdit.Location = New System.Drawing.Point(97, 134)
        Me.VendorphoneTextEdit.Name = "VendorphoneTextEdit"
        Me.VendorphoneTextEdit.Properties.ReadOnly = True
        Me.VendorphoneTextEdit.Size = New System.Drawing.Size(107, 20)
        Me.VendorphoneTextEdit.TabIndex = 13
        '
        'VendorfaxTextEdit
        '
        Me.VendorfaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendorfax", True))
        Me.VendorfaxTextEdit.Location = New System.Drawing.Point(241, 134)
        Me.VendorfaxTextEdit.Name = "VendorfaxTextEdit"
        Me.VendorfaxTextEdit.Properties.ReadOnly = True
        Me.VendorfaxTextEdit.Size = New System.Drawing.Size(107, 20)
        Me.VendorfaxTextEdit.TabIndex = 15
        '
        'PanelControl8
        '
        Me.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl8.Location = New System.Drawing.Point(389, 8)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(10, 450)
        Me.PanelControl8.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grVendors)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl4.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(381, 450)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Vendor List"
        '
        'grVendors
        '
        Me.grVendors.DataSource = Me.bsVendors
        Me.grVendors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grVendors.Location = New System.Drawing.Point(2, 22)
        Me.grVendors.LookAndFeel.SkinName = "Money Twins"
        Me.grVendors.MainView = Me.GridView4
        Me.grVendors.Name = "grVendors"
        Me.grVendors.Size = New System.Drawing.Size(377, 426)
        Me.grVendors.TabIndex = 0
        Me.grVendors.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
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
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVendorid, Me.colVendorname, Me.colVendorstatus})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView4.GridControl = Me.grVendors
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colVendorid
        '
        Me.colVendorid.Caption = "ID"
        Me.colVendorid.FieldName = "Vendorid"
        Me.colVendorid.Name = "colVendorid"
        Me.colVendorid.Visible = True
        Me.colVendorid.VisibleIndex = 0
        Me.colVendorid.Width = 45
        '
        'colVendorname
        '
        Me.colVendorname.Caption = "Vendor Name"
        Me.colVendorname.FieldName = "Vendorname"
        Me.colVendorname.Name = "colVendorname"
        Me.colVendorname.Visible = True
        Me.colVendorname.VisibleIndex = 1
        Me.colVendorname.Width = 242
        '
        'colVendorstatus
        '
        Me.colVendorstatus.Caption = "Status"
        Me.colVendorstatus.FieldName = "Vendorstatus"
        Me.colVendorstatus.Name = "colVendorstatus"
        Me.colVendorstatus.Visible = True
        Me.colVendorstatus.VisibleIndex = 2
        Me.colVendorstatus.Width = 88
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Controls.Add(Me.GroupControl1)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1429, 470)
        Me.RibbonPanelControl1.TabIndex = 4
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grPurchaseItems)
        Me.GroupControl1.Controls.Add(Me.pnlLegend)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1425, 466)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Purchase Items"
        '
        'grPurchaseItems
        '
        Me.grPurchaseItems.DataSource = Me.bsPurchaseItems
        Me.grPurchaseItems.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.RelationName = "Level2"
        Me.grPurchaseItems.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.grPurchaseItems.Location = New System.Drawing.Point(2, 51)
        Me.grPurchaseItems.MainView = Me.grvPurchaseItems
        Me.grPurchaseItems.Name = "grPurchaseItems"
        Me.grPurchaseItems.Size = New System.Drawing.Size(1421, 413)
        Me.grPurchaseItems.TabIndex = 0
        Me.grPurchaseItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPurchaseItems})
        '
        'bsPurchaseItems
        '
        Me.bsPurchaseItems.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseItems2Collection)
        '
        'grvPurchaseItems
        '
        Me.grvPurchaseItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colType, Me.PItemNo, Me.Dateneeded, Me.colExpectedIn, Me.Vendorname, Me.Unitcost, Me.QTY, Me.UC, Me.ItemID, Me.ItemDescription, Me.colContainer, Me.Purchasenumber, Me.Units, Me.UOM, Me.SourceType, Me.SourceDoc, Me.Customer, Me.Status})
        Me.grvPurchaseItems.GridControl = Me.grPurchaseItems
        Me.grvPurchaseItems.GroupFormat = "{1}"
        Me.grvPurchaseItems.Name = "grvPurchaseItems"
        Me.grvPurchaseItems.OptionsBehavior.Editable = False
        Me.grvPurchaseItems.OptionsSelection.MultiSelect = True
        Me.grvPurchaseItems.OptionsView.ShowAutoFilterRow = True
        Me.grvPurchaseItems.OptionsView.ShowGroupPanel = False
        Me.grvPurchaseItems.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.Vendorname, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.grvPurchaseItems.ViewCaption = "Purchase Items"
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Purchaseitemtype"
        Me.colType.Name = "colType"
        Me.colType.OptionsColumn.FixedWidth = True
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 0
        Me.colType.Width = 80
        '
        'PItemNo
        '
        Me.PItemNo.Caption = "Prch #"
        Me.PItemNo.FieldName = "Purchaseitemid"
        Me.PItemNo.Name = "PItemNo"
        Me.PItemNo.Visible = True
        Me.PItemNo.VisibleIndex = 1
        Me.PItemNo.Width = 57
        '
        'Dateneeded
        '
        Me.Dateneeded.Caption = "Dt Needed"
        Me.Dateneeded.DisplayFormat.FormatString = "d"
        Me.Dateneeded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.Dateneeded.FieldName = "Dateneeded"
        Me.Dateneeded.Name = "Dateneeded"
        Me.Dateneeded.OptionsColumn.FixedWidth = True
        Me.Dateneeded.Visible = True
        Me.Dateneeded.VisibleIndex = 2
        Me.Dateneeded.Width = 65
        '
        'colExpectedIn
        '
        Me.colExpectedIn.Caption = "Exp In"
        Me.colExpectedIn.FieldName = "Expectedindate"
        Me.colExpectedIn.Name = "colExpectedIn"
        Me.colExpectedIn.OptionsColumn.FixedWidth = True
        Me.colExpectedIn.Visible = True
        Me.colExpectedIn.VisibleIndex = 3
        Me.colExpectedIn.Width = 65
        '
        'Vendorname
        '
        Me.Vendorname.Caption = "Vendor"
        Me.Vendorname.FieldName = "Vendorname"
        Me.Vendorname.Name = "Vendorname"
        Me.Vendorname.Visible = True
        Me.Vendorname.VisibleIndex = 4
        Me.Vendorname.Width = 161
        '
        'Unitcost
        '
        Me.Unitcost.Caption = "Unit Cost"
        Me.Unitcost.FieldName = "Unitcost"
        Me.Unitcost.Name = "Unitcost"
        Me.Unitcost.Visible = True
        Me.Unitcost.VisibleIndex = 15
        Me.Unitcost.Width = 53
        '
        'QTY
        '
        Me.QTY.Caption = "Qty"
        Me.QTY.DisplayFormat.FormatString = "n2"
        Me.QTY.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.QTY.FieldName = "Qty"
        Me.QTY.Name = "QTY"
        Me.QTY.Visible = True
        Me.QTY.VisibleIndex = 7
        Me.QTY.Width = 41
        '
        'UC
        '
        Me.UC.Caption = "U/C"
        Me.UC.FieldName = "Unitorcontainer"
        Me.UC.Name = "UC"
        Me.UC.OptionsColumn.FixedWidth = True
        Me.UC.Visible = True
        Me.UC.VisibleIndex = 8
        Me.UC.Width = 30
        '
        'ItemID
        '
        Me.ItemID.Caption = "Item ID"
        Me.ItemID.FieldName = "Itemid"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.Visible = True
        Me.ItemID.VisibleIndex = 10
        Me.ItemID.Width = 44
        '
        'ItemDescription
        '
        Me.ItemDescription.Caption = "Item Description"
        Me.ItemDescription.FieldName = "Itemdescription"
        Me.ItemDescription.Name = "ItemDescription"
        Me.ItemDescription.Visible = True
        Me.ItemDescription.VisibleIndex = 11
        Me.ItemDescription.Width = 162
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 9
        Me.colContainer.Width = 59
        '
        'Purchasenumber
        '
        Me.Purchasenumber.AppearanceHeader.Options.UseTextOptions = True
        Me.Purchasenumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Purchasenumber.Caption = "PO #"
        Me.Purchasenumber.FieldName = "Purchasenumber"
        Me.Purchasenumber.Name = "Purchasenumber"
        Me.Purchasenumber.Visible = True
        Me.Purchasenumber.VisibleIndex = 12
        Me.Purchasenumber.Width = 34
        '
        'Units
        '
        Me.Units.Caption = "Units"
        Me.Units.FieldName = "Unitsincontainer"
        Me.Units.Name = "Units"
        Me.Units.Visible = True
        Me.Units.VisibleIndex = 13
        Me.Units.Width = 35
        '
        'UOM
        '
        Me.UOM.Caption = "UOM"
        Me.UOM.FieldName = "Uom"
        Me.UOM.Name = "UOM"
        Me.UOM.OptionsColumn.FixedWidth = True
        Me.UOM.Visible = True
        Me.UOM.VisibleIndex = 14
        Me.UOM.Width = 35
        '
        'SourceType
        '
        Me.SourceType.Caption = "Src Type"
        Me.SourceType.FieldName = "Sourcetype"
        Me.SourceType.Name = "SourceType"
        Me.SourceType.Visible = True
        Me.SourceType.VisibleIndex = 5
        Me.SourceType.Width = 74
        '
        'SourceDoc
        '
        Me.SourceDoc.Caption = "Src Doc"
        Me.SourceDoc.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.SourceDoc.FieldName = "Sourcedocument"
        Me.SourceDoc.Name = "SourceDoc"
        Me.SourceDoc.Visible = True
        Me.SourceDoc.VisibleIndex = 6
        Me.SourceDoc.Width = 54
        '
        'Customer
        '
        Me.Customer.Caption = "Customer"
        Me.Customer.FieldName = "Custname"
        Me.Customer.Name = "Customer"
        Me.Customer.Visible = True
        Me.Customer.VisibleIndex = 16
        Me.Customer.Width = 221
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Purchaseitemstatus"
        Me.Status.Name = "Status"
        Me.Status.OptionsColumn.FixedWidth = True
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 17
        Me.Status.Width = 80
        '
        'pnlLegend
        '
        Me.pnlLegend.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlLegend.Controls.Add(Me.lblRedDesc)
        Me.pnlLegend.Controls.Add(Me.ceRed)
        Me.pnlLegend.Controls.Add(Me.lblPinkDesc)
        Me.pnlLegend.Controls.Add(Me.lblYellowDesc)
        Me.pnlLegend.Controls.Add(Me.lblColorMapping)
        Me.pnlLegend.Controls.Add(Me.cePink)
        Me.pnlLegend.Controls.Add(Me.ceYellow)
        Me.pnlLegend.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlLegend.Location = New System.Drawing.Point(2, 22)
        Me.pnlLegend.Name = "pnlLegend"
        Me.pnlLegend.Size = New System.Drawing.Size(1421, 29)
        Me.pnlLegend.TabIndex = 1
        '
        'lblRedDesc
        '
        Me.lblRedDesc.Location = New System.Drawing.Point(529, 6)
        Me.lblRedDesc.Name = "lblRedDesc"
        Me.lblRedDesc.Size = New System.Drawing.Size(161, 13)
        Me.lblRedDesc.TabIndex = 8
        Me.lblRedDesc.Text = "Expected In is after Date Needed"
        '
        'ceRed
        '
        Me.ceRed.EditValue = System.Drawing.Color.Red
        Me.ceRed.Location = New System.Drawing.Point(493, 4)
        Me.ceRed.MenuManager = Me.RibbonControl1
        Me.ceRed.Name = "ceRed"
        Me.ceRed.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ceRed.Properties.Appearance.Options.UseBackColor = True
        Me.ceRed.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ceRed.Properties.ReadOnly = True
        Me.ceRed.Size = New System.Drawing.Size(28, 18)
        Me.ceRed.TabIndex = 7
        Me.ceRed.TabStop = False
        '
        'lblPinkDesc
        '
        Me.lblPinkDesc.Location = New System.Drawing.Point(311, 6)
        Me.lblPinkDesc.Name = "lblPinkDesc"
        Me.lblPinkDesc.Size = New System.Drawing.Size(174, 13)
        Me.lblPinkDesc.TabIndex = 6
        Me.lblPinkDesc.Text = "Date Needed is before current date "
        '
        'lblYellowDesc
        '
        Me.lblYellowDesc.Location = New System.Drawing.Point(125, 6)
        Me.lblYellowDesc.Name = "lblYellowDesc"
        Me.lblYellowDesc.Size = New System.Drawing.Size(142, 13)
        Me.lblYellowDesc.TabIndex = 5
        Me.lblYellowDesc.Text = "Vendor or Cost is not entered"
        '
        'lblColorMapping
        '
        Me.lblColorMapping.Location = New System.Drawing.Point(9, 6)
        Me.lblColorMapping.Name = "lblColorMapping"
        Me.lblColorMapping.Size = New System.Drawing.Size(72, 13)
        Me.lblColorMapping.TabIndex = 4
        Me.lblColorMapping.Text = "Color Mapping:"
        '
        'cePink
        '
        Me.cePink.EditValue = System.Drawing.Color.Pink
        Me.cePink.Location = New System.Drawing.Point(275, 4)
        Me.cePink.MenuManager = Me.RibbonControl1
        Me.cePink.Name = "cePink"
        Me.cePink.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cePink.Properties.Appearance.Options.UseBackColor = True
        Me.cePink.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cePink.Properties.ReadOnly = True
        Me.cePink.Size = New System.Drawing.Size(28, 18)
        Me.cePink.TabIndex = 1
        Me.cePink.TabStop = False
        '
        'ceYellow
        '
        Me.ceYellow.EditValue = System.Drawing.Color.Yellow
        Me.ceYellow.Location = New System.Drawing.Point(89, 4)
        Me.ceYellow.MenuManager = Me.RibbonControl1
        Me.ceYellow.Name = "ceYellow"
        Me.ceYellow.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ceYellow.Properties.Appearance.Options.UseBackColor = True
        Me.ceYellow.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ceYellow.Properties.ReadOnly = True
        Me.ceYellow.Size = New System.Drawing.Size(28, 18)
        Me.ceYellow.TabIndex = 0
        Me.ceYellow.TabStop = False
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Controls.Add(Me.GroupControl5)
        Me.RibbonPanelControl5.Controls.Add(Me.GroupControl6)
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(1429, 470)
        Me.RibbonPanelControl5.TabIndex = 6
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.GridControl1)
        Me.GroupControl5.Controls.Add(Me.PanelControl2)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1425, 278)
        Me.GroupControl5.TabIndex = 2
        Me.GroupControl5.Text = "Purchase Items"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsMonitorRequests
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode3.RelationName = "Level1"
        GridLevelNode4.RelationName = "Level2"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode3, GridLevelNode4})
        Me.GridControl1.Location = New System.Drawing.Point(2, 51)
        Me.GridControl1.MainView = Me.grvMonitorRequests
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1421, 225)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMonitorRequests})
        '
        'bsMonitorRequests
        '
        Me.bsMonitorRequests.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseItems2Collection)
        '
        'grvMonitorRequests
        '
        Me.grvMonitorRequests.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn14, Me.GridColumn15, Me.GridColumn17, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22})
        Me.grvMonitorRequests.GridControl = Me.GridControl1
        Me.grvMonitorRequests.GroupFormat = "{1}"
        Me.grvMonitorRequests.Name = "grvMonitorRequests"
        Me.grvMonitorRequests.OptionsBehavior.Editable = False
        Me.grvMonitorRequests.OptionsSelection.MultiSelect = True
        Me.grvMonitorRequests.OptionsView.ShowAutoFilterRow = True
        Me.grvMonitorRequests.OptionsView.ShowGroupPanel = False
        Me.grvMonitorRequests.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.GridColumn5, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.grvMonitorRequests.ViewCaption = "Purchase Items"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Type"
        Me.GridColumn1.FieldName = "Purchaseitemtype"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Prch #"
        Me.GridColumn2.FieldName = "Purchaseitemid"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 57
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Dt Needed"
        Me.GridColumn3.DisplayFormat.FormatString = "d"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "Dateneeded"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 65
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Exp In"
        Me.GridColumn4.FieldName = "Expectedindate"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 65
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Vendor"
        Me.GridColumn5.FieldName = "Vendorname"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 161
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Unit Cost"
        Me.GridColumn7.FieldName = "Unitcost"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 15
        Me.GridColumn7.Width = 53
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Qty"
        Me.GridColumn8.DisplayFormat.FormatString = "n2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Qty"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 41
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "U/C"
        Me.GridColumn9.FieldName = "Unitorcontainer"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.FixedWidth = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 30
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Item ID"
        Me.GridColumn10.FieldName = "Itemid"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        Me.GridColumn10.Width = 44
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Item Description"
        Me.GridColumn11.FieldName = "Itemdescription"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 11
        Me.GridColumn11.Width = 162
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Container"
        Me.GridColumn12.FieldName = "Container"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 9
        Me.GridColumn12.Width = 59
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn14.Caption = "PO #"
        Me.GridColumn14.FieldName = "Purchasenumber"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 12
        Me.GridColumn14.Width = 34
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Units"
        Me.GridColumn15.FieldName = "Unitsincontainer"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 13
        Me.GridColumn15.Width = 35
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "UOM"
        Me.GridColumn17.FieldName = "Uom"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.FixedWidth = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 14
        Me.GridColumn17.Width = 35
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Src Type"
        Me.GridColumn19.FieldName = "Sourcetype"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 5
        Me.GridColumn19.Width = 74
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Src Doc"
        Me.GridColumn20.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.GridColumn20.FieldName = "Sourcedocument"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 6
        Me.GridColumn20.Width = 54
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Customer"
        Me.GridColumn21.FieldName = "Custname"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 16
        Me.GridColumn21.Width = 221
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Status"
        Me.GridColumn22.FieldName = "Purchaseitemstatus"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.FixedWidth = True
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 17
        Me.GridColumn22.Width = 80
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.ColorEdit1)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Controls.Add(Me.ColorEdit2)
        Me.PanelControl2.Controls.Add(Me.ColorEdit3)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(2, 22)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1421, 29)
        Me.PanelControl2.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(529, 6)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(161, 13)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "Expected In is after Date Needed"
        '
        'ColorEdit1
        '
        Me.ColorEdit1.EditValue = System.Drawing.Color.Red
        Me.ColorEdit1.Location = New System.Drawing.Point(493, 4)
        Me.ColorEdit1.MenuManager = Me.RibbonControl1
        Me.ColorEdit1.Name = "ColorEdit1"
        Me.ColorEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ColorEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.ColorEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ColorEdit1.Properties.ReadOnly = True
        Me.ColorEdit1.Size = New System.Drawing.Size(28, 18)
        Me.ColorEdit1.TabIndex = 7
        Me.ColorEdit1.TabStop = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(311, 6)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(174, 13)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Date Needed is before current date "
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(125, 6)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(142, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Vendor or Cost is not entered"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(9, 6)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Color Mapping:"
        '
        'ColorEdit2
        '
        Me.ColorEdit2.EditValue = System.Drawing.Color.Pink
        Me.ColorEdit2.Location = New System.Drawing.Point(275, 4)
        Me.ColorEdit2.MenuManager = Me.RibbonControl1
        Me.ColorEdit2.Name = "ColorEdit2"
        Me.ColorEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ColorEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.ColorEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ColorEdit2.Properties.ReadOnly = True
        Me.ColorEdit2.Size = New System.Drawing.Size(28, 18)
        Me.ColorEdit2.TabIndex = 1
        Me.ColorEdit2.TabStop = False
        '
        'ColorEdit3
        '
        Me.ColorEdit3.EditValue = System.Drawing.Color.Yellow
        Me.ColorEdit3.Location = New System.Drawing.Point(89, 4)
        Me.ColorEdit3.MenuManager = Me.RibbonControl1
        Me.ColorEdit3.Name = "ColorEdit3"
        Me.ColorEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ColorEdit3.Properties.Appearance.Options.UseBackColor = True
        Me.ColorEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ColorEdit3.Properties.ReadOnly = True
        Me.ColorEdit3.Size = New System.Drawing.Size(28, 18)
        Me.ColorEdit3.TabIndex = 0
        Me.ColorEdit3.TabStop = False
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.grMaterialPlanning)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl6.Location = New System.Drawing.Point(2, 280)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(1425, 188)
        Me.GroupControl6.TabIndex = 3
        Me.GroupControl6.Text = "Material Needs"
        '
        'grMaterialPlanning
        '
        Me.grMaterialPlanning.DataSource = Me.bsMaterialPlanning
        Me.grMaterialPlanning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grMaterialPlanning.Location = New System.Drawing.Point(2, 22)
        Me.grMaterialPlanning.LookAndFeel.SkinName = "Money Twins"
        Me.grMaterialPlanning.MainView = Me.grvMaterialPlanning
        Me.grMaterialPlanning.Name = "grMaterialPlanning"
        Me.grMaterialPlanning.Size = New System.Drawing.Size(1421, 164)
        Me.grMaterialPlanning.TabIndex = 3
        Me.grMaterialPlanning.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMaterialPlanning})
        '
        'bsMaterialPlanning
        '
        Me.bsMaterialPlanning.DataSource = GetType(AOS.BusinessObjects.ViewRMAvailableCollection)
        '
        'grvMaterialPlanning
        '
        Me.grvMaterialPlanning.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.grvMaterialPlanning.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvMaterialPlanning.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvMaterialPlanning.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvMaterialPlanning.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.grvMaterialPlanning.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvMaterialPlanning.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.grvMaterialPlanning.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.grvMaterialPlanning.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvMaterialPlanning.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grvMaterialPlanning.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvMaterialPlanning.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvMaterialPlanning.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grvMaterialPlanning.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvMaterialPlanning.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvMaterialPlanning.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvMaterialPlanning.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvMaterialPlanning.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvMaterialPlanning.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grvMaterialPlanning.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvMaterialPlanning.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaterialid1, Me.colMaterialdesc, Me.colRmInventory, Me.colRmInproduction, Me.colRmOnorder, Me.colRmRequested, Me.colRmInprocess, Me.colRmAvailable})
        Me.grvMaterialPlanning.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvMaterialPlanning.GridControl = Me.grMaterialPlanning
        Me.grvMaterialPlanning.Name = "grvMaterialPlanning"
        Me.grvMaterialPlanning.OptionsBehavior.Editable = False
        Me.grvMaterialPlanning.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvMaterialPlanning.OptionsView.ShowGroupPanel = False
        Me.grvMaterialPlanning.OptionsView.ShowIndicator = False
        '
        'colMaterialid1
        '
        Me.colMaterialid1.Caption = "Mat ID"
        Me.colMaterialid1.FieldName = "Materialid"
        Me.colMaterialid1.Name = "colMaterialid1"
        Me.colMaterialid1.OptionsColumn.FixedWidth = True
        Me.colMaterialid1.Visible = True
        Me.colMaterialid1.VisibleIndex = 0
        Me.colMaterialid1.Width = 54
        '
        'colMaterialdesc
        '
        Me.colMaterialdesc.Caption = "Material Description"
        Me.colMaterialdesc.FieldName = "Materialdesc"
        Me.colMaterialdesc.Name = "colMaterialdesc"
        Me.colMaterialdesc.Visible = True
        Me.colMaterialdesc.VisibleIndex = 1
        Me.colMaterialdesc.Width = 648
        '
        'colRmInventory
        '
        Me.colRmInventory.Caption = "Inventory"
        Me.colRmInventory.DisplayFormat.FormatString = "n2"
        Me.colRmInventory.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmInventory.FieldName = "RmInventory"
        Me.colRmInventory.Name = "colRmInventory"
        Me.colRmInventory.OptionsColumn.FixedWidth = True
        Me.colRmInventory.Visible = True
        Me.colRmInventory.VisibleIndex = 2
        '
        'colRmInproduction
        '
        Me.colRmInproduction.Caption = "In Production"
        Me.colRmInproduction.DisplayFormat.FormatString = "n2"
        Me.colRmInproduction.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmInproduction.FieldName = "RmInproduction"
        Me.colRmInproduction.Name = "colRmInproduction"
        Me.colRmInproduction.OptionsColumn.FixedWidth = True
        Me.colRmInproduction.Visible = True
        Me.colRmInproduction.VisibleIndex = 3
        '
        'colRmOnorder
        '
        Me.colRmOnorder.Caption = "On Order"
        Me.colRmOnorder.DisplayFormat.FormatString = "n2"
        Me.colRmOnorder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmOnorder.FieldName = "RmOnorder"
        Me.colRmOnorder.Name = "colRmOnorder"
        Me.colRmOnorder.OptionsColumn.FixedWidth = True
        Me.colRmOnorder.Visible = True
        Me.colRmOnorder.VisibleIndex = 4
        '
        'colRmRequested
        '
        Me.colRmRequested.Caption = "Requested"
        Me.colRmRequested.DisplayFormat.FormatString = "n2"
        Me.colRmRequested.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmRequested.FieldName = "RmRequested"
        Me.colRmRequested.Name = "colRmRequested"
        Me.colRmRequested.OptionsColumn.FixedWidth = True
        Me.colRmRequested.Visible = True
        Me.colRmRequested.VisibleIndex = 5
        '
        'colRmInprocess
        '
        Me.colRmInprocess.Caption = "In Process"
        Me.colRmInprocess.DisplayFormat.FormatString = "n2"
        Me.colRmInprocess.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmInprocess.FieldName = "RmInprocess"
        Me.colRmInprocess.Name = "colRmInprocess"
        Me.colRmInprocess.OptionsColumn.FixedWidth = True
        Me.colRmInprocess.Visible = True
        Me.colRmInprocess.VisibleIndex = 6
        '
        'colRmAvailable
        '
        Me.colRmAvailable.Caption = "Available"
        Me.colRmAvailable.DisplayFormat.FormatString = "n2"
        Me.colRmAvailable.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmAvailable.FieldName = "RmAvailable"
        Me.colRmAvailable.Name = "colRmAvailable"
        Me.colRmAvailable.OptionsColumn.FixedWidth = True
        Me.colRmAvailable.Visible = True
        Me.colRmAvailable.VisibleIndex = 7
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Controls.Add(Me.GroupControl2)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1429, 470)
        Me.RibbonPanelControl2.TabIndex = 5
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grPOs)
        Me.GroupControl2.Controls.Add(Me.pnlPOLegend)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1425, 466)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Purchase Orders "
        '
        'grPOs
        '
        Me.grPOs.DataSource = Me.bsPOs
        Me.grPOs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPOs.Location = New System.Drawing.Point(2, 51)
        Me.grPOs.MainView = Me.grvPurchaseOrders
        Me.grPOs.Name = "grPOs"
        Me.grPOs.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit16, Me.RepositoryItemLookUpEdit17, Me.RepositoryItemLookUpEdit1})
        Me.grPOs.Size = New System.Drawing.Size(1421, 413)
        Me.grPOs.TabIndex = 2
        Me.grPOs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPurchaseOrders})
        '
        'bsPOs
        '
        Me.bsPOs.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseOrdersCollection)
        '
        'grvPurchaseOrders
        '
        Me.grvPurchaseOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.col1, Me.colComponentQty, Me.col3, Me.GridColumn6, Me.GridColumn16, Me.GridColumn18, Me.colLateItems, Me.colCustomerpo})
        Me.grvPurchaseOrders.GridControl = Me.grPOs
        Me.grvPurchaseOrders.Name = "grvPurchaseOrders"
        Me.grvPurchaseOrders.OptionsBehavior.Editable = False
        Me.grvPurchaseOrders.OptionsView.ShowAutoFilterRow = True
        Me.grvPurchaseOrders.OptionsView.ShowGroupPanel = False
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "PO Type"
        Me.GridColumn13.FieldName = "Purchasetype"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.FixedWidth = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        Me.GridColumn13.Width = 70
        '
        'col1
        '
        Me.col1.Caption = "PO #"
        Me.col1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col1.FieldName = "Purchasenumber"
        Me.col1.Name = "col1"
        Me.col1.OptionsColumn.AllowEdit = False
        Me.col1.Visible = True
        Me.col1.VisibleIndex = 1
        Me.col1.Width = 65
        '
        'colComponentQty
        '
        Me.colComponentQty.Caption = "PO Date"
        Me.colComponentQty.DisplayFormat.FormatString = "d"
        Me.colComponentQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colComponentQty.FieldName = "Purchasedate"
        Me.colComponentQty.Name = "colComponentQty"
        Me.colComponentQty.OptionsColumn.AllowEdit = False
        Me.colComponentQty.OptionsColumn.FixedWidth = True
        Me.colComponentQty.Visible = True
        Me.colComponentQty.VisibleIndex = 3
        '
        'col3
        '
        Me.col3.Caption = "Vendor Name"
        Me.col3.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.col3.FieldName = "Vendorid"
        Me.col3.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.col3.Name = "col3"
        Me.col3.OptionsColumn.AllowEdit = False
        Me.col3.Visible = True
        Me.col3.VisibleIndex = 4
        Me.col3.Width = 863
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsVendorList
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Vendorname"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ValueMember = "Vendorid"
        '
        'bsVendorList
        '
        Me.bsVendorList.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Expected In"
        Me.GridColumn6.DisplayFormat.FormatString = "d"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "Expectedindate"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 92
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "PO Status"
        Me.GridColumn16.FieldName = "Purchasestatus"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.FixedWidth = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 6
        Me.GridColumn16.Width = 81
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn18.Caption = "Total $"
        Me.GridColumn18.DisplayFormat.FormatString = "c2"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn18.FieldName = "Total"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 7
        Me.GridColumn18.Width = 105
        '
        'colLateItems
        '
        Me.colLateItems.Caption = "Is Late Item"
        Me.colLateItems.FieldName = "Itemsexpectedafterdateneeded"
        Me.colLateItems.Name = "colLateItems"
        '
        'colCustomerpo
        '
        Me.colCustomerpo.Caption = "Vend Ref #"
        Me.colCustomerpo.FieldName = "Customerpo"
        Me.colCustomerpo.Name = "colCustomerpo"
        Me.colCustomerpo.Visible = True
        Me.colCustomerpo.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit16
        '
        Me.RepositoryItemLookUpEdit16.AutoHeight = False
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
        Me.RepositoryItemLookUpEdit17.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit17.Name = "RepositoryItemLookUpEdit17"
        Me.RepositoryItemLookUpEdit17.NullText = ""
        Me.RepositoryItemLookUpEdit17.ValueMember = "Productid"
        '
        'pnlPOLegend
        '
        Me.pnlPOLegend.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlPOLegend.Controls.Add(Me.lblPOPinkDesc)
        Me.pnlPOLegend.Controls.Add(Me.cePOPink)
        Me.pnlPOLegend.Controls.Add(Me.lblPOColorMapping)
        Me.pnlPOLegend.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPOLegend.Location = New System.Drawing.Point(2, 22)
        Me.pnlPOLegend.Name = "pnlPOLegend"
        Me.pnlPOLegend.Size = New System.Drawing.Size(1421, 29)
        Me.pnlPOLegend.TabIndex = 3
        '
        'lblPOPinkDesc
        '
        Me.lblPOPinkDesc.Location = New System.Drawing.Point(126, 6)
        Me.lblPOPinkDesc.Name = "lblPOPinkDesc"
        Me.lblPOPinkDesc.Size = New System.Drawing.Size(51, 13)
        Me.lblPOPinkDesc.TabIndex = 8
        Me.lblPOPinkDesc.Text = "Late Items"
        '
        'cePOPink
        '
        Me.cePOPink.EditValue = System.Drawing.Color.Red
        Me.cePOPink.Location = New System.Drawing.Point(90, 4)
        Me.cePOPink.MenuManager = Me.RibbonControl1
        Me.cePOPink.Name = "cePOPink"
        Me.cePOPink.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.cePOPink.Properties.Appearance.Options.UseBackColor = True
        Me.cePOPink.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.cePOPink.Properties.ReadOnly = True
        Me.cePOPink.Size = New System.Drawing.Size(28, 18)
        Me.cePOPink.TabIndex = 7
        Me.cePOPink.TabStop = False
        '
        'lblPOColorMapping
        '
        Me.lblPOColorMapping.Location = New System.Drawing.Point(9, 6)
        Me.lblPOColorMapping.Name = "lblPOColorMapping"
        Me.lblPOColorMapping.Size = New System.Drawing.Size(72, 13)
        Me.lblPOColorMapping.TabIndex = 4
        Me.lblPOColorMapping.Text = "Color Mapping:"
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1429, 470)
        Me.RibbonPanelControl4.TabIndex = 5
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Delete Vendor"
        Me.BarButtonItem1.Id = 53
        Me.BarButtonItem1.ImageOptions.Image = Global.AOS.My.Resources.Resources.Delete
        Me.BarButtonItem1.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Delete
        Me.BarButtonItem1.Name = "BarButtonItem1"
        Me.BarButtonItem1.Tag = "111"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.AllowTextClipping = False
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.ShowCaptionButton = False
        Me.RibbonPageGroup10.Text = "Vendor Information"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.AllowTextClipping = False
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        Me.RibbonPageGroup11.ShowCaptionButton = False
        Me.RibbonPageGroup11.Text = "Vendor Information"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Delete Vendor"
        Me.BarButtonItem2.Id = 53
        Me.BarButtonItem2.ImageOptions.Image = Global.AOS.My.Resources.Resources.Delete
        Me.BarButtonItem2.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Delete
        Me.BarButtonItem2.Name = "BarButtonItem2"
        Me.BarButtonItem2.Tag = "111"
        '
        'RibbonPageGroup17
        '
        Me.RibbonPageGroup17.Name = "RibbonPageGroup17"
        Me.RibbonPageGroup17.Text = "RibbonPageGroup17"
        '
        'btnMarkApproved
        '
        Me.btnMarkApproved.Caption = "Mark As Approved"
        Me.btnMarkApproved.Id = 51
        Me.btnMarkApproved.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.form_arrow_right
        Me.btnMarkApproved.Name = "btnMarkApproved"
        Me.btnMarkApproved.Tag = "179"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 60000
        '
        'AppgroupCollection1
        '
        Me.AppgroupCollection1.AllowDelete = True
        Me.AppgroupCollection1.AllowEdit = True
        Me.AppgroupCollection1.AllowNew = True
        Me.AppgroupCollection1.EnableHierarchicalBinding = True
        Me.AppgroupCollection1.Filter = ""
        Me.AppgroupCollection1.RowStateFilter = System.Data.DataViewRowState.None
        Me.AppgroupCollection1.Sort = ""
        Me.AppgroupCollection1.SuspendListChangedEvents = False
        '
        'viewPurchasing2
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.Name = "viewPurchasing2"
        Me.Size = New System.Drawing.Size(1433, 624)
        Me.Tag = "viewPurchasing"
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonLargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.grpVendorProduct_VendorMgmt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpVendorProduct_VendorMgmt.ResumeLayout(False)
        CType(Me.grVendorProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendorProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvVendorProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendornameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vendoraddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendoracctnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vendoraddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorurlTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendoremailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorstateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorzipTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorfaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlLegend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLegend.ResumeLayout(False)
        Me.pnlLegend.PerformLayout()
        CType(Me.ceRed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cePink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ceYellow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl5.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMonitorRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMonitorRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.ColorEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.grMaterialPlanning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaterialPlanning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMaterialPlanning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grPOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlPOLegend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPOLegend.ResumeLayout(False)
        Me.pnlPOLegend.PerformLayout()
        CType(Me.cePOPink.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPurchaseItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSplitPurchaseItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRequested As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAll As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCreatePurchaseOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grPurchaseItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPurchaseItems As CustomDevExGridView
    Friend WithEvents pnlLegend As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblPinkDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblYellowDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblColorMapping As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cePink As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents ceYellow As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents bsInPurchaseItems As System.Windows.Forms.BindingSource
    Friend WithEvents PItemNo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Dateneeded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Unitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QTY As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UC As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Vendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Units As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SourceDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents bsPurchaseItems As System.Windows.Forms.BindingSource
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsPOs As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnPendingOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnOrderedOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCompletedOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPurchase As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelPurchase As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintPurchaseOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsVendorList As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnRetriveMaterials As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grPOs As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPurchaseOrders As CustomDevExGridView
    Friend WithEvents col1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComponentQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grVendors As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TermsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendornameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vendoraddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendoracctnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vendoraddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorurlTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendoremailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorstateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorzipTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorphoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorfaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnReceivedHold As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup17 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents DWObtnPendingOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DWObtnOpenOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DWObtnClosedOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DWObtnEditPurchase As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DWObtnCancelPurchase As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DWObtnPrintPurchaseOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DWObtnRetriveMaterials As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colExpectedIn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblRedDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ceRed As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents btnOrdered As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Purchasenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnMarkApproved As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnApprovePurchase As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents pnlPOLegend As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblPOColorMapping As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DWObtnApprovePO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents lblPOPinkDesc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cePOPink As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnMaterialNeeds As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnByVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnByItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelledOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAllOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintItemList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddToExistingPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddPurchaseItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colLateItems As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SourceType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCancelPurchaseItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonLargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnCancelledPurchaseItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCustomerpo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnReceivedHold As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnRefreshPurchaseRequests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnRefreshMaterialNeeds As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvMonitorRequests As CustomDevExGridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColorEdit1 As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ColorEdit2 As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents ColorEdit3 As DevExpress.XtraEditors.ColorEdit
    Friend WithEvents bsMonitorRequests As BindingSource
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grMaterialPlanning As DevExpress.XtraGrid.GridControl
    Friend grvMaterialPlanning As CustomDevExGridView
    Friend WithEvents colMaterialid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmInventory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmInproduction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmOnorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmRequested As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmInprocess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer2 As Timer
    Friend WithEvents bsMaterialPlanning As BindingSource
    Friend WithEvents bsVendorProducts As BindingSource
    Friend WithEvents AppgroupCollection1 As AppgroupCollection
    Friend WithEvents grpVendorProduct_VendorMgmt As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grVendorProduct As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvVendorProducts As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colProductid_VendorMgmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc_VendorMgmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesc2_VendorMgmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer_VendorMgmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductstatus_VendorMgmt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colVendorid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnFetchVendorsActive As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnFetchVendorsInActive As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
End Class
