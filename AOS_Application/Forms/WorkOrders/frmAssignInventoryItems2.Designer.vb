<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignInventoryItems2

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssignInventoryItems2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.bsWorkOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnSearchInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAllocateItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnLookupInventoryToConvert = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetProductionOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancelProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetPurchaseItems = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewPurchaseItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditPurchaseItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeletePurchaseItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnUnallocateWorkOrderItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetRelabelOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewRelabelOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancelRelabelOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintRelabelOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grWorkOrderItems = New DevExpress.XtraGrid.GridControl()
        Me.bsWOItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvWorkOrderItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.colWorkorderitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouselocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourcetype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourcedocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitorcontainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProductDesc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luContainer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luStdgallons = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.WorkPanelHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsCancelledPurchaseItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomDevExGridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit26 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit27 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit28 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit29 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.gvPurchaseRequests = New DevExpress.XtraGrid.GridControl()
        Me.bsPurchaseItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPurchaseRequests = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.gpProductionOrders = New DevExpress.XtraEditors.GroupControl()
        Me.grProductionOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsProdOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvProductionOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProdordernum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdorderdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisnum1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeededby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIscomplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit14 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit15 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit16 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit17 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.gpCanceledProductionOrders = New DevExpress.XtraEditors.GroupControl()
        Me.grCanceledProductionOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsCancelledProdOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvCanceledProductionOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit8 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit9 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grAvailableInventory = New DevExpress.XtraGrid.GridControl()
        Me.bsAvailableInventory = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvAvailableInventory = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvitemnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippeddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouselocation1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehousenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryclass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsremaining = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocumenttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPonumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasereleasenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPodate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangeableponumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateddocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordercustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptocustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvSourceType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvSourcedocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvSourceStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.grRelabelOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsRelabelOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvRelabelOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit18 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit19 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit20 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit21 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grCanceledRelabelOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsCancelledRelabelOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvCanceledRelabelOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit22 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit23 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit24 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit25 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWorkOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grWorkOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWOItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvWorkOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.WorkPanelHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelHolder.SuspendLayout()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCancelledPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.gvPurchaseRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPurchaseRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.gpProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpProductionOrders.SuspendLayout()
        CType(Me.grProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProdOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpCanceledProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpCanceledProductionOrders.SuspendLayout()
        CType(Me.grCanceledProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCancelledProdOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCanceledProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.grAvailableInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAvailableInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvAvailableInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grRelabelOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRelabelOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvRelabelOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grCanceledRelabelOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCancelledRelabelOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCanceledRelabelOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit25, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.TextEdit6)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.TextEdit5)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.TextEdit4)
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1018, 61)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Work Order"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(855, 33)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl8.TabIndex = 12
        Me.LabelControl8.Text = "Delivery Date:"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Deliverydate", True))
        Me.TextEdit6.Location = New System.Drawing.Point(930, 30)
        Me.TextEdit6.MenuManager = Me.RibbonControl1
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.DisplayFormat.FormatString = "d"
        Me.TextEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Size = New System.Drawing.Size(74, 20)
        Me.TextEdit6.TabIndex = 11
        Me.TextEdit6.TabStop = False
        '
        'bsWorkOrder
        '
        Me.bsWorkOrder.DataSource = GetType(AOS.BusinessObjects.ViewWorkOrder)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.AllowMinimizeRibbon = False
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnSearchInventory, Me.rbtnAllocateItem, Me.rbtnLookupInventoryToConvert, Me.rbtnGetProductionOrders, Me.rbtnAddNewProductionOrder, Me.rbtnEditProductionOrder, Me.rbtnCancelProductionOrder, Me.rbtnPrintProductionOrder, Me.rbtnGetPurchaseItems, Me.rbtnAddNewPurchaseItem, Me.rbtnEditPurchaseItem, Me.rbtnDeletePurchaseItem, Me.rbtnUnallocateWorkOrderItem, Me.rbtnGetRelabelOrders, Me.rbtnAddNewRelabelOrder, Me.rbtnCancelRelabelOrder, Me.rbtnPrintRelabelOrder})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(2, 2)
        Me.RibbonControl1.MaxItemId = 20
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage4, Me.RibbonPage2, Me.RibbonPage3})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1014, 117)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnSearchInventory
        '
        Me.rbtnSearchInventory.Caption = "Get Available Inventory"
        Me.rbtnSearchInventory.Id = 1
        Me.rbtnSearchInventory.LargeGlyph = Global.AOS.My.Resources.Resources.View_table
        Me.rbtnSearchInventory.Name = "rbtnSearchInventory"
        '
        'rbtnAllocateItem
        '
        Me.rbtnAllocateItem.Caption = "Allocate to Work Order Item"
        Me.rbtnAllocateItem.Id = 2
        Me.rbtnAllocateItem.LargeGlyph = Global.AOS.My.Resources.Resources.barcode_properties
        Me.rbtnAllocateItem.Name = "rbtnAllocateItem"
        '
        'rbtnLookupInventoryToConvert
        '
        Me.rbtnLookupInventoryToConvert.Caption = "Convert Available Inventory to In Process"
        Me.rbtnLookupInventoryToConvert.Id = 4
        Me.rbtnLookupInventoryToConvert.LargeGlyph = Global.AOS.My.Resources.Resources.form_find
        Me.rbtnLookupInventoryToConvert.Name = "rbtnLookupInventoryToConvert"
        '
        'rbtnGetProductionOrders
        '
        Me.rbtnGetProductionOrders.Caption = "Retrieve Orders"
        Me.rbtnGetProductionOrders.Id = 5
        Me.rbtnGetProductionOrders.ImageIndex = 0
        Me.rbtnGetProductionOrders.LargeImageIndex = 1
        Me.rbtnGetProductionOrders.LargeWidth = 60
        Me.rbtnGetProductionOrders.Name = "rbtnGetProductionOrders"
        '
        'rbtnAddNewProductionOrder
        '
        Me.rbtnAddNewProductionOrder.Caption = "Add New Order"
        Me.rbtnAddNewProductionOrder.Id = 6
        Me.rbtnAddNewProductionOrder.LargeImageIndex = 2
        Me.rbtnAddNewProductionOrder.LargeWidth = 60
        Me.rbtnAddNewProductionOrder.Name = "rbtnAddNewProductionOrder"
        '
        'rbtnEditProductionOrder
        '
        Me.rbtnEditProductionOrder.Caption = "Edit   Order"
        Me.rbtnEditProductionOrder.Id = 7
        Me.rbtnEditProductionOrder.LargeImageIndex = 3
        Me.rbtnEditProductionOrder.LargeWidth = 60
        Me.rbtnEditProductionOrder.Name = "rbtnEditProductionOrder"
        '
        'rbtnCancelProductionOrder
        '
        Me.rbtnCancelProductionOrder.Caption = "Cancel  Order"
        Me.rbtnCancelProductionOrder.Id = 8
        Me.rbtnCancelProductionOrder.LargeImageIndex = 4
        Me.rbtnCancelProductionOrder.LargeWidth = 60
        Me.rbtnCancelProductionOrder.Name = "rbtnCancelProductionOrder"
        '
        'rbtnPrintProductionOrder
        '
        Me.rbtnPrintProductionOrder.Caption = "Print Order"
        Me.rbtnPrintProductionOrder.Id = 9
        Me.rbtnPrintProductionOrder.LargeImageIndex = 5
        Me.rbtnPrintProductionOrder.LargeWidth = 60
        Me.rbtnPrintProductionOrder.Name = "rbtnPrintProductionOrder"
        '
        'rbtnGetPurchaseItems
        '
        Me.rbtnGetPurchaseItems.Caption = "Refresh Purchase Items"
        Me.rbtnGetPurchaseItems.Id = 10
        Me.rbtnGetPurchaseItems.LargeGlyph = Global.AOS.My.Resources.Resources.document_text_search
        Me.rbtnGetPurchaseItems.Name = "rbtnGetPurchaseItems"
        '
        'rbtnAddNewPurchaseItem
        '
        Me.rbtnAddNewPurchaseItem.Caption = "Add New Purchase Item"
        Me.rbtnAddNewPurchaseItem.Id = 11
        Me.rbtnAddNewPurchaseItem.LargeGlyph = Global.AOS.My.Resources.Resources.document_text_add
        Me.rbtnAddNewPurchaseItem.Name = "rbtnAddNewPurchaseItem"
        '
        'rbtnEditPurchaseItem
        '
        Me.rbtnEditPurchaseItem.Caption = "  Edit  Purchase Item"
        Me.rbtnEditPurchaseItem.Glyph = Global.AOS.My.Resources.Resources.document_text_edit
        Me.rbtnEditPurchaseItem.Id = 12
        Me.rbtnEditPurchaseItem.LargeGlyph = Global.AOS.My.Resources.Resources.document_text_edit
        Me.rbtnEditPurchaseItem.Name = "rbtnEditPurchaseItem"
        '
        'rbtnDeletePurchaseItem
        '
        Me.rbtnDeletePurchaseItem.Caption = "Cancel Purchase Item"
        Me.rbtnDeletePurchaseItem.Glyph = Global.AOS.My.Resources.Resources.document_text_delete
        Me.rbtnDeletePurchaseItem.Id = 13
        Me.rbtnDeletePurchaseItem.LargeGlyph = Global.AOS.My.Resources.Resources.document_text_delete
        Me.rbtnDeletePurchaseItem.Name = "rbtnDeletePurchaseItem"
        '
        'rbtnUnallocateWorkOrderItem
        '
        Me.rbtnUnallocateWorkOrderItem.Caption = "Unallocate from Work Order Item"
        Me.rbtnUnallocateWorkOrderItem.Enabled = False
        Me.rbtnUnallocateWorkOrderItem.Id = 14
        Me.rbtnUnallocateWorkOrderItem.LargeGlyph = Global.AOS.My.Resources.Resources.barcode_remove
        Me.rbtnUnallocateWorkOrderItem.Name = "rbtnUnallocateWorkOrderItem"
        '
        'rbtnGetRelabelOrders
        '
        Me.rbtnGetRelabelOrders.Caption = "Retrieve Orders"
        Me.rbtnGetRelabelOrders.Id = 15
        Me.rbtnGetRelabelOrders.LargeImageIndex = 1
        Me.rbtnGetRelabelOrders.Name = "rbtnGetRelabelOrders"
        '
        'rbtnAddNewRelabelOrder
        '
        Me.rbtnAddNewRelabelOrder.Caption = "Add New Order"
        Me.rbtnAddNewRelabelOrder.Id = 16
        Me.rbtnAddNewRelabelOrder.LargeImageIndex = 2
        Me.rbtnAddNewRelabelOrder.Name = "rbtnAddNewRelabelOrder"
        '
        'rbtnCancelRelabelOrder
        '
        Me.rbtnCancelRelabelOrder.Caption = "Cancel  Order"
        Me.rbtnCancelRelabelOrder.Enabled = False
        Me.rbtnCancelRelabelOrder.Id = 18
        Me.rbtnCancelRelabelOrder.LargeImageIndex = 4
        Me.rbtnCancelRelabelOrder.Name = "rbtnCancelRelabelOrder"
        '
        'rbtnPrintRelabelOrder
        '
        Me.rbtnPrintRelabelOrder.Caption = "Print Order"
        Me.rbtnPrintRelabelOrder.Enabled = False
        Me.rbtnPrintRelabelOrder.Id = 19
        Me.rbtnPrintRelabelOrder.LargeImageIndex = 5
        Me.rbtnPrintRelabelOrder.Name = "rbtnPrintRelabelOrder"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Available Inventory"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnSearchInventory)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnAllocateItem, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnUnallocateWorkOrderItem)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Available Inventory"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Relabel Orders"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowMinimize = False
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnGetRelabelOrders)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnAddNewRelabelOrder, True)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnCancelRelabelOrder)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnPrintRelabelOrder, True)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Relabel Orders"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Production Orders"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnGetProductionOrders)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnAddNewProductionOrder, True)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnEditProductionOrder)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnCancelProductionOrder)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnPrintProductionOrder, True)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Production Orders"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Purchase Items"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnGetPurchaseItems)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnAddNewPurchaseItem, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnEditPurchaseItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnDeletePurchaseItem)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Purchase Items"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(678, 33)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl7.TabIndex = 10
        Me.LabelControl7.Text = "Planned Ship Date:"
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Plannedshipdate", True))
        Me.TextEdit5.Location = New System.Drawing.Point(775, 30)
        Me.TextEdit5.MenuManager = Me.RibbonControl1
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "d"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(74, 20)
        Me.TextEdit5.TabIndex = 9
        Me.TextEdit5.TabStop = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(524, 33)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "Cust PO:"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Customerpo", True))
        Me.TextEdit4.Location = New System.Drawing.Point(573, 30)
        Me.TextEdit4.MenuManager = Me.RibbonControl1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(94, 20)
        Me.TextEdit4.TabIndex = 7
        Me.TextEdit4.TabStop = False
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Workorderdate", True))
        Me.TextEdit3.Location = New System.Drawing.Point(192, 30)
        Me.TextEdit3.MenuManager = Me.RibbonControl1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(74, 20)
        Me.TextEdit3.TabIndex = 6
        Me.TextEdit3.TabStop = False
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Custname", True))
        Me.TextEdit2.Location = New System.Drawing.Point(336, 30)
        Me.TextEdit2.MenuManager = Me.RibbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(181, 20)
        Me.TextEdit2.TabIndex = 5
        Me.TextEdit2.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(280, 33)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Customer:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(128, 33)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Order Date:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 33)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "WO#:"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrder, "Workordernumber", True))
        Me.TextEdit1.Location = New System.Drawing.Point(48, 30)
        Me.TextEdit1.MenuManager = Me.RibbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(74, 20)
        Me.TextEdit1.TabIndex = 0
        Me.TextEdit1.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grWorkOrderItems)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 61)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1018, 250)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Work Order Items"
        '
        'grWorkOrderItems
        '
        Me.grWorkOrderItems.DataSource = Me.bsWOItems
        Me.grWorkOrderItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grWorkOrderItems.Location = New System.Drawing.Point(2, 22)
        Me.grWorkOrderItems.MainView = Me.grvWorkOrderItems
        Me.grWorkOrderItems.Name = "grWorkOrderItems"
        Me.grWorkOrderItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1})
        Me.grWorkOrderItems.Size = New System.Drawing.Size(1014, 226)
        Me.grWorkOrderItems.TabIndex = 5
        Me.grWorkOrderItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvWorkOrderItems})
        '
        'bsWOItems
        '
        Me.bsWOItems.DataSource = GetType(AOS.BusinessObjects.ViewWorkOrderItemCollection)
        '
        'grvWorkOrderItems
        '
        Me.grvWorkOrderItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWorkorderitemnumber, Me.colWorkordernumber, Me.colProductid, Me.colProductdesc1, Me.colContainer1, Me.colQty, Me.colInvitemnumber, Me.colLotnumber, Me.colWarehouselocation, Me.colSourcetype, Me.colSourcedocument, Me.colUnitorcontainer, Me.colUnits, Me.colUom})
        Me.grvWorkOrderItems.GridControl = Me.grWorkOrderItems
        Me.grvWorkOrderItems.Name = "grvWorkOrderItems"
        Me.grvWorkOrderItems.OptionsBehavior.Editable = False
        Me.grvWorkOrderItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvWorkOrderItems.OptionsView.ShowGroupPanel = False
        Me.grvWorkOrderItems.OptionsView.ShowIndicator = False
        '
        'colWorkorderitemnumber
        '
        Me.colWorkorderitemnumber.FieldName = "Workorderitemnumber"
        Me.colWorkorderitemnumber.Name = "colWorkorderitemnumber"
        '
        'colWorkordernumber
        '
        Me.colWorkordernumber.FieldName = "Workordernumber"
        Me.colWorkordernumber.Name = "colWorkordernumber"
        '
        'colProductid
        '
        Me.colProductid.Caption = "Item ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.AllowEdit = False
        Me.colProductid.OptionsColumn.FixedWidth = True
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 1
        Me.colProductid.Width = 50
        '
        'colProductdesc1
        '
        Me.colProductdesc1.Caption = "Item Description"
        Me.colProductdesc1.FieldName = "Productdesc"
        Me.colProductdesc1.Name = "colProductdesc1"
        Me.colProductdesc1.OptionsColumn.AllowEdit = False
        Me.colProductdesc1.Visible = True
        Me.colProductdesc1.VisibleIndex = 3
        Me.colProductdesc1.Width = 554
        '
        'colContainer1
        '
        Me.colContainer1.FieldName = "Container"
        Me.colContainer1.Name = "colContainer1"
        Me.colContainer1.OptionsColumn.AllowEdit = False
        Me.colContainer1.OptionsColumn.FixedWidth = True
        Me.colContainer1.Visible = True
        Me.colContainer1.VisibleIndex = 4
        Me.colContainer1.Width = 90
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowEdit = False
        Me.colQty.OptionsColumn.FixedWidth = True
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 0
        Me.colQty.Width = 45
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Inv Item #"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.OptionsColumn.AllowEdit = False
        Me.colInvitemnumber.OptionsColumn.FixedWidth = True
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 5
        Me.colInvitemnumber.Width = 65
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot #"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.OptionsColumn.AllowEdit = False
        Me.colLotnumber.OptionsColumn.FixedWidth = True
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 6
        Me.colLotnumber.Width = 80
        '
        'colWarehouselocation
        '
        Me.colWarehouselocation.FieldName = "Warehouselocation"
        Me.colWarehouselocation.Name = "colWarehouselocation"
        '
        'colSourcetype
        '
        Me.colSourcetype.Caption = "Src Type"
        Me.colSourcetype.FieldName = "Sourcetype"
        Me.colSourcetype.Name = "colSourcetype"
        Me.colSourcetype.OptionsColumn.AllowEdit = False
        Me.colSourcetype.OptionsColumn.FixedWidth = True
        Me.colSourcetype.Visible = True
        Me.colSourcetype.VisibleIndex = 7
        Me.colSourcetype.Width = 55
        '
        'colSourcedocument
        '
        Me.colSourcedocument.AppearanceCell.Options.UseTextOptions = True
        Me.colSourcedocument.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colSourcedocument.Caption = "Src Doc"
        Me.colSourcedocument.FieldName = "Sourcedocument"
        Me.colSourcedocument.Name = "colSourcedocument"
        Me.colSourcedocument.OptionsColumn.AllowEdit = False
        Me.colSourcedocument.OptionsColumn.FixedWidth = True
        Me.colSourcedocument.Visible = True
        Me.colSourcedocument.VisibleIndex = 8
        Me.colSourcedocument.Width = 50
        '
        'colUnitorcontainer
        '
        Me.colUnitorcontainer.Caption = "U/C"
        Me.colUnitorcontainer.FieldName = "Unitorcontainer"
        Me.colUnitorcontainer.Name = "colUnitorcontainer"
        Me.colUnitorcontainer.OptionsColumn.AllowEdit = False
        Me.colUnitorcontainer.OptionsColumn.FixedWidth = True
        Me.colUnitorcontainer.Visible = True
        Me.colUnitorcontainer.VisibleIndex = 2
        Me.colUnitorcontainer.Width = 30
        '
        'colUnits
        '
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.Width = 93
        '
        'colUom
        '
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.Width = 70
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.WorkPanelHolder)
        Me.PanelControl1.Controls.Add(Me.RibbonControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 311)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1018, 422)
        Me.PanelControl1.TabIndex = 3
        '
        'WorkPanelHolder
        '
        Me.WorkPanelHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelHolder.Location = New System.Drawing.Point(2, 119)
        Me.WorkPanelHolder.Name = "WorkPanelHolder"
        Me.WorkPanelHolder.Size = New System.Drawing.Size(1014, 301)
        Me.WorkPanelHolder.TabIndex = 1
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RibbonPanelControl3.Controls.Add(Me.GroupControl6)
        Me.RibbonPanelControl3.Controls.Add(Me.GroupControl5)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1014, 301)
        Me.RibbonPanelControl3.TabIndex = 2
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.GridControl1)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl6.Location = New System.Drawing.Point(0, 157)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(1014, 144)
        Me.GroupControl6.TabIndex = 9
        Me.GroupControl6.Text = "Cancelled Purchase Items"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsCancelledPurchaseItems
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.CustomDevExGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit26, Me.RepositoryItemLookUpEdit27, Me.RepositoryItemLookUpEdit28, Me.RepositoryItemCheckEdit8, Me.RepositoryItemLookUpEdit29})
        Me.GridControl1.Size = New System.Drawing.Size(1010, 120)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CustomDevExGridView1})
        '
        'bsCancelledPurchaseItems
        '
        Me.bsCancelledPurchaseItems.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseItemRequestCollection)
        '
        'CustomDevExGridView1
        '
        Me.CustomDevExGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn27, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn35, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn42})
        Me.CustomDevExGridView1.GridControl = Me.GridControl1
        Me.CustomDevExGridView1.Name = "CustomDevExGridView1"
        Me.CustomDevExGridView1.OptionsBehavior.Editable = False
        Me.CustomDevExGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CustomDevExGridView1.OptionsView.ShowGroupPanel = False
        Me.CustomDevExGridView1.OptionsView.ShowIndicator = False
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Prch. Item #"
        Me.GridColumn27.FieldName = "Purchaseitemid"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.FixedWidth = True
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 0
        Me.GridColumn27.Width = 73
        '
        'GridColumn30
        '
        Me.GridColumn30.Caption = "Prch. Item Date"
        Me.GridColumn30.DisplayFormat.FormatString = "d"
        Me.GridColumn30.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn30.FieldName = "Createdtime"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.OptionsColumn.FixedWidth = True
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 1
        Me.GridColumn30.Width = 90
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Item Type"
        Me.GridColumn31.FieldName = "Itemtype"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.OptionsColumn.FixedWidth = True
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 2
        Me.GridColumn31.Width = 60
        '
        'GridColumn32
        '
        Me.GridColumn32.Caption = "Item ID"
        Me.GridColumn32.FieldName = "Itemid"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.OptionsColumn.FixedWidth = True
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 3
        Me.GridColumn32.Width = 50
        '
        'GridColumn35
        '
        Me.GridColumn35.Caption = "Item Description"
        Me.GridColumn35.FieldName = "Productdesc"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 4
        Me.GridColumn35.Width = 399
        '
        'GridColumn37
        '
        Me.GridColumn37.Caption = "Qty"
        Me.GridColumn37.FieldName = "Qty"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.OptionsColumn.FixedWidth = True
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 5
        Me.GridColumn37.Width = 45
        '
        'GridColumn38
        '
        Me.GridColumn38.FieldName = "Container"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.OptionsColumn.FixedWidth = True
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 6
        Me.GridColumn38.Width = 80
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "Date Needed"
        Me.GridColumn39.FieldName = "Dateneeded"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.OptionsColumn.FixedWidth = True
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 7
        Me.GridColumn39.Width = 73
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "Status "
        Me.GridColumn42.FieldName = "Purchaseitemstatus"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.OptionsColumn.FixedWidth = True
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 8
        Me.GridColumn42.Width = 80
        '
        'RepositoryItemLookUpEdit26
        '
        Me.RepositoryItemLookUpEdit26.AutoHeight = False
        Me.RepositoryItemLookUpEdit26.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit26.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit26.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit26.Name = "RepositoryItemLookUpEdit26"
        Me.RepositoryItemLookUpEdit26.NullText = ""
        Me.RepositoryItemLookUpEdit26.ReadOnly = True
        Me.RepositoryItemLookUpEdit26.ShowFooter = False
        Me.RepositoryItemLookUpEdit26.ShowHeader = False
        Me.RepositoryItemLookUpEdit26.ShowLines = False
        Me.RepositoryItemLookUpEdit26.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit27
        '
        Me.RepositoryItemLookUpEdit27.AutoHeight = False
        Me.RepositoryItemLookUpEdit27.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit27.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit27.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit27.Name = "RepositoryItemLookUpEdit27"
        Me.RepositoryItemLookUpEdit27.NullText = ""
        Me.RepositoryItemLookUpEdit27.ReadOnly = True
        Me.RepositoryItemLookUpEdit27.ShowFooter = False
        Me.RepositoryItemLookUpEdit27.ShowHeader = False
        Me.RepositoryItemLookUpEdit27.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit28
        '
        Me.RepositoryItemLookUpEdit28.AutoHeight = False
        Me.RepositoryItemLookUpEdit28.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit28.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit28.Name = "RepositoryItemLookUpEdit28"
        Me.RepositoryItemLookUpEdit28.NullText = ""
        Me.RepositoryItemLookUpEdit28.ReadOnly = True
        Me.RepositoryItemLookUpEdit28.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit8
        '
        Me.RepositoryItemCheckEdit8.AutoHeight = False
        Me.RepositoryItemCheckEdit8.Caption = "Check"
        Me.RepositoryItemCheckEdit8.Name = "RepositoryItemCheckEdit8"
        '
        'RepositoryItemLookUpEdit29
        '
        Me.RepositoryItemLookUpEdit29.AutoHeight = False
        Me.RepositoryItemLookUpEdit29.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit29.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit29.Name = "RepositoryItemLookUpEdit29"
        Me.RepositoryItemLookUpEdit29.NullText = ""
        Me.RepositoryItemLookUpEdit29.ValueMember = "Productid"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.gvPurchaseRequests)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1014, 301)
        Me.GroupControl5.TabIndex = 8
        Me.GroupControl5.Text = "Purchase Items Linked to Workorder / Product ID"
        '
        'gvPurchaseRequests
        '
        Me.gvPurchaseRequests.DataSource = Me.bsPurchaseItems
        Me.gvPurchaseRequests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gvPurchaseRequests.Location = New System.Drawing.Point(2, 22)
        Me.gvPurchaseRequests.MainView = Me.grvPurchaseRequests
        Me.gvPurchaseRequests.Name = "gvPurchaseRequests"
        Me.gvPurchaseRequests.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit10, Me.RepositoryItemLookUpEdit11, Me.RepositoryItemLookUpEdit12, Me.RepositoryItemCheckEdit4, Me.RepositoryItemLookUpEdit13})
        Me.gvPurchaseRequests.Size = New System.Drawing.Size(1010, 277)
        Me.gvPurchaseRequests.TabIndex = 7
        Me.gvPurchaseRequests.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPurchaseRequests})
        '
        'bsPurchaseItems
        '
        Me.bsPurchaseItems.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseItemRequestCollection)
        '
        'grvPurchaseRequests
        '
        Me.grvPurchaseRequests.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn23, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn24})
        Me.grvPurchaseRequests.GridControl = Me.gvPurchaseRequests
        Me.grvPurchaseRequests.Name = "grvPurchaseRequests"
        Me.grvPurchaseRequests.OptionsBehavior.Editable = False
        Me.grvPurchaseRequests.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvPurchaseRequests.OptionsView.ShowGroupPanel = False
        Me.grvPurchaseRequests.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Prch. Item #"
        Me.GridColumn1.FieldName = "Purchaseitemid"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 73
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Prch. Item Date"
        Me.GridColumn2.DisplayFormat.FormatString = "d"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn2.FieldName = "Createdtime"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 90
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Item Type"
        Me.GridColumn23.FieldName = "Itemtype"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.OptionsColumn.FixedWidth = True
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 2
        Me.GridColumn23.Width = 60
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Item ID"
        Me.GridColumn3.FieldName = "Itemid"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 50
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Item Description"
        Me.GridColumn4.FieldName = "Productdesc"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 399
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Qty"
        Me.GridColumn5.FieldName = "Qty"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.FixedWidth = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 45
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "Container"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 80
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Date Needed"
        Me.GridColumn7.FieldName = "Dateneeded"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.FixedWidth = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 73
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Status "
        Me.GridColumn24.FieldName = "Purchaseitemstatus"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.FixedWidth = True
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 8
        Me.GridColumn24.Width = 80
        '
        'RepositoryItemLookUpEdit10
        '
        Me.RepositoryItemLookUpEdit10.AutoHeight = False
        Me.RepositoryItemLookUpEdit10.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit10.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit10.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit10.Name = "RepositoryItemLookUpEdit10"
        Me.RepositoryItemLookUpEdit10.NullText = ""
        Me.RepositoryItemLookUpEdit10.ReadOnly = True
        Me.RepositoryItemLookUpEdit10.ShowFooter = False
        Me.RepositoryItemLookUpEdit10.ShowHeader = False
        Me.RepositoryItemLookUpEdit10.ShowLines = False
        Me.RepositoryItemLookUpEdit10.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit11
        '
        Me.RepositoryItemLookUpEdit11.AutoHeight = False
        Me.RepositoryItemLookUpEdit11.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit11.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit11.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit11.Name = "RepositoryItemLookUpEdit11"
        Me.RepositoryItemLookUpEdit11.NullText = ""
        Me.RepositoryItemLookUpEdit11.ReadOnly = True
        Me.RepositoryItemLookUpEdit11.ShowFooter = False
        Me.RepositoryItemLookUpEdit11.ShowHeader = False
        Me.RepositoryItemLookUpEdit11.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit12
        '
        Me.RepositoryItemLookUpEdit12.AutoHeight = False
        Me.RepositoryItemLookUpEdit12.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit12.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit12.Name = "RepositoryItemLookUpEdit12"
        Me.RepositoryItemLookUpEdit12.NullText = ""
        Me.RepositoryItemLookUpEdit12.ReadOnly = True
        Me.RepositoryItemLookUpEdit12.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit4
        '
        Me.RepositoryItemCheckEdit4.AutoHeight = False
        Me.RepositoryItemCheckEdit4.Caption = "Check"
        Me.RepositoryItemCheckEdit4.Name = "RepositoryItemCheckEdit4"
        '
        'RepositoryItemLookUpEdit13
        '
        Me.RepositoryItemLookUpEdit13.AutoHeight = False
        Me.RepositoryItemLookUpEdit13.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit13.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit13.Name = "RepositoryItemLookUpEdit13"
        Me.RepositoryItemLookUpEdit13.NullText = ""
        Me.RepositoryItemLookUpEdit13.ValueMember = "Productid"
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RibbonPanelControl2.Controls.Add(Me.gpProductionOrders)
        Me.RibbonPanelControl2.Controls.Add(Me.gpCanceledProductionOrders)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1014, 301)
        Me.RibbonPanelControl2.TabIndex = 1
        '
        'gpProductionOrders
        '
        Me.gpProductionOrders.Controls.Add(Me.grProductionOrders)
        Me.gpProductionOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpProductionOrders.Location = New System.Drawing.Point(0, 0)
        Me.gpProductionOrders.Name = "gpProductionOrders"
        Me.gpProductionOrders.Size = New System.Drawing.Size(1014, 151)
        Me.gpProductionOrders.TabIndex = 2
        Me.gpProductionOrders.Text = "Production Orders Linked to Work Order / Product ID"
        '
        'grProductionOrders
        '
        Me.grProductionOrders.DataSource = Me.bsProdOrders
        Me.grProductionOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grProductionOrders.Location = New System.Drawing.Point(2, 22)
        Me.grProductionOrders.MainView = Me.grvProductionOrders
        Me.grProductionOrders.Name = "grProductionOrders"
        Me.grProductionOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit14, Me.RepositoryItemLookUpEdit15, Me.RepositoryItemLookUpEdit16, Me.RepositoryItemCheckEdit5, Me.RepositoryItemLookUpEdit17})
        Me.grProductionOrders.Size = New System.Drawing.Size(1010, 127)
        Me.grProductionOrders.TabIndex = 6
        Me.grProductionOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvProductionOrders})
        '
        'bsProdOrders
        '
        Me.bsProdOrders.DataSource = GetType(AOS.BusinessObjects.ViewProdOrderDataCollection)
        '
        'grvProductionOrders
        '
        Me.grvProductionOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProdordernum, Me.colProdorderdate, Me.colCreatedby, Me.colProductid2, Me.colProductqty, Me.colApisnum1, Me.colCustid, Me.colLotnumber2, Me.colNeededby, Me.colOrderStatus, Me.colIscomplete, Me.colProductdesc2, Me.colContainer3, Me.colUom2, Me.colCustname})
        Me.grvProductionOrders.GridControl = Me.grProductionOrders
        Me.grvProductionOrders.Name = "grvProductionOrders"
        Me.grvProductionOrders.OptionsBehavior.Editable = False
        Me.grvProductionOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvProductionOrders.OptionsView.ShowGroupPanel = False
        Me.grvProductionOrders.OptionsView.ShowIndicator = False
        '
        'colProdordernum
        '
        Me.colProdordernum.Caption = "Ord #"
        Me.colProdordernum.FieldName = "Prodordernum"
        Me.colProdordernum.Name = "colProdordernum"
        Me.colProdordernum.OptionsColumn.FixedWidth = True
        Me.colProdordernum.Visible = True
        Me.colProdordernum.VisibleIndex = 0
        Me.colProdordernum.Width = 45
        '
        'colProdorderdate
        '
        Me.colProdorderdate.Caption = "Ord Date"
        Me.colProdorderdate.DisplayFormat.FormatString = "d"
        Me.colProdorderdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colProdorderdate.FieldName = "Prodorderdate"
        Me.colProdorderdate.Name = "colProdorderdate"
        Me.colProdorderdate.OptionsColumn.FixedWidth = True
        Me.colProdorderdate.Visible = True
        Me.colProdorderdate.VisibleIndex = 1
        Me.colProdorderdate.Width = 65
        '
        'colCreatedby
        '
        Me.colCreatedby.FieldName = "Createdby"
        Me.colCreatedby.Name = "colCreatedby"
        Me.colCreatedby.OptionsColumn.FixedWidth = True
        '
        'colProductid2
        '
        Me.colProductid2.Caption = "Item ID"
        Me.colProductid2.FieldName = "Productid"
        Me.colProductid2.Name = "colProductid2"
        Me.colProductid2.OptionsColumn.FixedWidth = True
        Me.colProductid2.Visible = True
        Me.colProductid2.VisibleIndex = 2
        Me.colProductid2.Width = 50
        '
        'colProductqty
        '
        Me.colProductqty.Caption = "Qty"
        Me.colProductqty.FieldName = "Productqty"
        Me.colProductqty.Name = "colProductqty"
        Me.colProductqty.OptionsColumn.FixedWidth = True
        Me.colProductqty.Visible = True
        Me.colProductqty.VisibleIndex = 4
        Me.colProductqty.Width = 45
        '
        'colApisnum1
        '
        Me.colApisnum1.Caption = "APIS #"
        Me.colApisnum1.FieldName = "Apisnum"
        Me.colApisnum1.Name = "colApisnum1"
        Me.colApisnum1.OptionsColumn.FixedWidth = True
        Me.colApisnum1.Visible = True
        Me.colApisnum1.VisibleIndex = 6
        Me.colApisnum1.Width = 45
        '
        'colCustid
        '
        Me.colCustid.FieldName = "Custid"
        Me.colCustid.Name = "colCustid"
        Me.colCustid.OptionsColumn.FixedWidth = True
        '
        'colLotnumber2
        '
        Me.colLotnumber2.Caption = "Lot #"
        Me.colLotnumber2.FieldName = "Lotnumber"
        Me.colLotnumber2.Name = "colLotnumber2"
        Me.colLotnumber2.OptionsColumn.FixedWidth = True
        Me.colLotnumber2.Visible = True
        Me.colLotnumber2.VisibleIndex = 7
        Me.colLotnumber2.Width = 80
        '
        'colNeededby
        '
        Me.colNeededby.Caption = "Needed By"
        Me.colNeededby.DisplayFormat.FormatString = "d"
        Me.colNeededby.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNeededby.FieldName = "Neededby"
        Me.colNeededby.Name = "colNeededby"
        Me.colNeededby.OptionsColumn.FixedWidth = True
        Me.colNeededby.Visible = True
        Me.colNeededby.VisibleIndex = 8
        Me.colNeededby.Width = 65
        '
        'colOrderStatus
        '
        Me.colOrderStatus.Caption = "Status"
        Me.colOrderStatus.FieldName = "Orderstatus"
        Me.colOrderStatus.Name = "colOrderStatus"
        Me.colOrderStatus.OptionsColumn.FixedWidth = True
        Me.colOrderStatus.Visible = True
        Me.colOrderStatus.VisibleIndex = 11
        Me.colOrderStatus.Width = 60
        '
        'colIscomplete
        '
        Me.colIscomplete.Caption = "Complete"
        Me.colIscomplete.FieldName = "Iscomplete"
        Me.colIscomplete.Name = "colIscomplete"
        Me.colIscomplete.OptionsColumn.FixedWidth = True
        Me.colIscomplete.Visible = True
        Me.colIscomplete.VisibleIndex = 12
        Me.colIscomplete.Width = 55
        '
        'colProductdesc2
        '
        Me.colProductdesc2.Caption = "Item Description"
        Me.colProductdesc2.FieldName = "Productdesc"
        Me.colProductdesc2.Name = "colProductdesc2"
        Me.colProductdesc2.Visible = True
        Me.colProductdesc2.VisibleIndex = 3
        Me.colProductdesc2.Width = 252
        '
        'colContainer3
        '
        Me.colContainer3.FieldName = "Container"
        Me.colContainer3.Name = "colContainer3"
        Me.colContainer3.OptionsColumn.FixedWidth = True
        Me.colContainer3.Visible = True
        Me.colContainer3.VisibleIndex = 5
        Me.colContainer3.Width = 70
        '
        'colUom2
        '
        Me.colUom2.Caption = "UOM"
        Me.colUom2.FieldName = "Uom"
        Me.colUom2.Name = "colUom2"
        Me.colUom2.OptionsColumn.FixedWidth = True
        Me.colUom2.Visible = True
        Me.colUom2.VisibleIndex = 9
        Me.colUom2.Width = 35
        '
        'colCustname
        '
        Me.colCustname.Caption = "Customer"
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 10
        Me.colCustname.Width = 143
        '
        'RepositoryItemLookUpEdit14
        '
        Me.RepositoryItemLookUpEdit14.AutoHeight = False
        Me.RepositoryItemLookUpEdit14.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit14.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit14.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit14.Name = "RepositoryItemLookUpEdit14"
        Me.RepositoryItemLookUpEdit14.NullText = ""
        Me.RepositoryItemLookUpEdit14.ReadOnly = True
        Me.RepositoryItemLookUpEdit14.ShowFooter = False
        Me.RepositoryItemLookUpEdit14.ShowHeader = False
        Me.RepositoryItemLookUpEdit14.ShowLines = False
        Me.RepositoryItemLookUpEdit14.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit15
        '
        Me.RepositoryItemLookUpEdit15.AutoHeight = False
        Me.RepositoryItemLookUpEdit15.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit15.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit15.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit15.Name = "RepositoryItemLookUpEdit15"
        Me.RepositoryItemLookUpEdit15.NullText = ""
        Me.RepositoryItemLookUpEdit15.ReadOnly = True
        Me.RepositoryItemLookUpEdit15.ShowFooter = False
        Me.RepositoryItemLookUpEdit15.ShowHeader = False
        Me.RepositoryItemLookUpEdit15.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit16
        '
        Me.RepositoryItemLookUpEdit16.AutoHeight = False
        Me.RepositoryItemLookUpEdit16.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit16.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit16.Name = "RepositoryItemLookUpEdit16"
        Me.RepositoryItemLookUpEdit16.NullText = ""
        Me.RepositoryItemLookUpEdit16.ReadOnly = True
        Me.RepositoryItemLookUpEdit16.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit5
        '
        Me.RepositoryItemCheckEdit5.AutoHeight = False
        Me.RepositoryItemCheckEdit5.Caption = "Check"
        Me.RepositoryItemCheckEdit5.Name = "RepositoryItemCheckEdit5"
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
        'gpCanceledProductionOrders
        '
        Me.gpCanceledProductionOrders.Controls.Add(Me.grCanceledProductionOrders)
        Me.gpCanceledProductionOrders.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpCanceledProductionOrders.Location = New System.Drawing.Point(0, 151)
        Me.gpCanceledProductionOrders.Name = "gpCanceledProductionOrders"
        Me.gpCanceledProductionOrders.Size = New System.Drawing.Size(1014, 150)
        Me.gpCanceledProductionOrders.TabIndex = 3
        Me.gpCanceledProductionOrders.Text = "Cancelled Production Orders"
        '
        'grCanceledProductionOrders
        '
        Me.grCanceledProductionOrders.DataSource = Me.bsCancelledProdOrders
        Me.grCanceledProductionOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCanceledProductionOrders.Location = New System.Drawing.Point(2, 22)
        Me.grCanceledProductionOrders.MainView = Me.grvCanceledProductionOrders
        Me.grCanceledProductionOrders.Name = "grCanceledProductionOrders"
        Me.grCanceledProductionOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit6, Me.RepositoryItemLookUpEdit7, Me.RepositoryItemLookUpEdit8, Me.RepositoryItemCheckEdit3, Me.RepositoryItemLookUpEdit9})
        Me.grCanceledProductionOrders.Size = New System.Drawing.Size(1010, 126)
        Me.grCanceledProductionOrders.TabIndex = 6
        Me.grCanceledProductionOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCanceledProductionOrders})
        '
        'bsCancelledProdOrders
        '
        Me.bsCancelledProdOrders.DataSource = GetType(AOS.BusinessObjects.ViewProdOrderDataCollection)
        '
        'grvCanceledProductionOrders
        '
        Me.grvCanceledProductionOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22})
        Me.grvCanceledProductionOrders.GridControl = Me.grCanceledProductionOrders
        Me.grvCanceledProductionOrders.Name = "grvCanceledProductionOrders"
        Me.grvCanceledProductionOrders.OptionsBehavior.Editable = False
        Me.grvCanceledProductionOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvCanceledProductionOrders.OptionsView.ShowGroupPanel = False
        Me.grvCanceledProductionOrders.OptionsView.ShowIndicator = False
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Ord #"
        Me.GridColumn8.FieldName = "Prodordernum"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.FixedWidth = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 0
        Me.GridColumn8.Width = 45
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ord Date"
        Me.GridColumn9.DisplayFormat.FormatString = "d"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "Prodorderdate"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.FixedWidth = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 65
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "Createdby"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.FixedWidth = True
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Item ID"
        Me.GridColumn11.FieldName = "Productid"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.FixedWidth = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 2
        Me.GridColumn11.Width = 50
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Qty"
        Me.GridColumn12.FieldName = "Productqty"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.FixedWidth = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 4
        Me.GridColumn12.Width = 45
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "APIS #"
        Me.GridColumn13.FieldName = "Apisnum"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.OptionsColumn.FixedWidth = True
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 6
        Me.GridColumn13.Width = 45
        '
        'GridColumn14
        '
        Me.GridColumn14.FieldName = "Custid"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.FixedWidth = True
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Lot #"
        Me.GridColumn15.FieldName = "Lotnumber"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.FixedWidth = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 7
        Me.GridColumn15.Width = 80
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Needed By"
        Me.GridColumn16.DisplayFormat.FormatString = "d"
        Me.GridColumn16.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn16.FieldName = "Neededby"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.FixedWidth = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 8
        Me.GridColumn16.Width = 65
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Status"
        Me.GridColumn17.FieldName = "Orderstatus"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.FixedWidth = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 11
        Me.GridColumn17.Width = 60
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Complete"
        Me.GridColumn18.FieldName = "Iscomplete"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.FixedWidth = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 12
        Me.GridColumn18.Width = 55
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Item Description"
        Me.GridColumn19.FieldName = "Productdesc"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 3
        Me.GridColumn19.Width = 252
        '
        'GridColumn20
        '
        Me.GridColumn20.FieldName = "Container"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.OptionsColumn.FixedWidth = True
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 5
        Me.GridColumn20.Width = 70
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "UOM"
        Me.GridColumn21.FieldName = "Uom"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.OptionsColumn.FixedWidth = True
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 9
        Me.GridColumn21.Width = 35
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Customer"
        Me.GridColumn22.FieldName = "Custname"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 10
        Me.GridColumn22.Width = 143
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit6.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        Me.RepositoryItemLookUpEdit6.ReadOnly = True
        Me.RepositoryItemLookUpEdit6.ShowFooter = False
        Me.RepositoryItemLookUpEdit6.ShowHeader = False
        Me.RepositoryItemLookUpEdit6.ShowLines = False
        Me.RepositoryItemLookUpEdit6.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit7
        '
        Me.RepositoryItemLookUpEdit7.AutoHeight = False
        Me.RepositoryItemLookUpEdit7.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit7.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit7.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit7.Name = "RepositoryItemLookUpEdit7"
        Me.RepositoryItemLookUpEdit7.NullText = ""
        Me.RepositoryItemLookUpEdit7.ReadOnly = True
        Me.RepositoryItemLookUpEdit7.ShowFooter = False
        Me.RepositoryItemLookUpEdit7.ShowHeader = False
        Me.RepositoryItemLookUpEdit7.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit8
        '
        Me.RepositoryItemLookUpEdit8.AutoHeight = False
        Me.RepositoryItemLookUpEdit8.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit8.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit8.Name = "RepositoryItemLookUpEdit8"
        Me.RepositoryItemLookUpEdit8.NullText = ""
        Me.RepositoryItemLookUpEdit8.ReadOnly = True
        Me.RepositoryItemLookUpEdit8.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit3
        '
        Me.RepositoryItemCheckEdit3.AutoHeight = False
        Me.RepositoryItemCheckEdit3.Caption = "Check"
        Me.RepositoryItemCheckEdit3.Name = "RepositoryItemCheckEdit3"
        '
        'RepositoryItemLookUpEdit9
        '
        Me.RepositoryItemLookUpEdit9.AutoHeight = False
        Me.RepositoryItemLookUpEdit9.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit9.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit9.Name = "RepositoryItemLookUpEdit9"
        Me.RepositoryItemLookUpEdit9.NullText = ""
        Me.RepositoryItemLookUpEdit9.ValueMember = "Productid"
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RibbonPanelControl1.Controls.Add(Me.grAvailableInventory)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1014, 301)
        Me.RibbonPanelControl1.TabIndex = 0
        '
        'grAvailableInventory
        '
        Me.grAvailableInventory.DataSource = Me.bsAvailableInventory
        Me.grAvailableInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAvailableInventory.Location = New System.Drawing.Point(0, 0)
        Me.grAvailableInventory.MainView = Me.grvAvailableInventory
        Me.grAvailableInventory.Name = "grAvailableInventory"
        Me.grAvailableInventory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemCheckEdit2, Me.RepositoryItemLookUpEdit4})
        Me.grAvailableInventory.Size = New System.Drawing.Size(1014, 301)
        Me.grAvailableInventory.TabIndex = 6
        Me.grAvailableInventory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvAvailableInventory})
        '
        'bsAvailableInventory
        '
        Me.bsAvailableInventory.DataSource = GetType(AOS.BusinessObjects.ViewInvItemDetailsCollection)
        '
        'grvAvailableInventory
        '
        Me.grvAvailableInventory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber1, Me.colProductid3, Me.colProductdesc, Me.colContainer, Me.colShipmentnumber, Me.colShipmentdate, Me.colShippeddate, Me.colReceiveddate, Me.colLotnumber1, Me.colWarehouselocation1, Me.colWarehousenumber, Me.colAllocateddate, Me.colReceivernumber, Me.colItemstatus, Me.colInventoryclass, Me.colClassdesc, Me.colUnitsremaining, Me.colReceiverdocument, Me.colReceiverdocumenttype, Me.colPonumber, Me.colPurchasereleasenumber, Me.colVendorname, Me.colPodate, Me.colChangeableponumber, Me.colAllocateddocument, Me.colWorkordernumber1, Me.colWorkordercustomer, Me.colShiptocustomer, Me.colInvSourceType, Me.colInvSourcedocument, Me.colInvAvailable, Me.colInvSourceStatus})
        Me.grvAvailableInventory.GridControl = Me.grAvailableInventory
        Me.grvAvailableInventory.Name = "grvAvailableInventory"
        Me.grvAvailableInventory.OptionsBehavior.Editable = False
        Me.grvAvailableInventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvAvailableInventory.OptionsView.ShowGroupPanel = False
        Me.grvAvailableInventory.OptionsView.ShowIndicator = False
        '
        'colInvitemnumber1
        '
        Me.colInvitemnumber1.Caption = "Item #"
        Me.colInvitemnumber1.FieldName = "Invitemnumber"
        Me.colInvitemnumber1.Name = "colInvitemnumber1"
        Me.colInvitemnumber1.OptionsColumn.FixedWidth = True
        Me.colInvitemnumber1.Visible = True
        Me.colInvitemnumber1.VisibleIndex = 1
        Me.colInvitemnumber1.Width = 60
        '
        'colProductid3
        '
        Me.colProductid3.Caption = "Item ID"
        Me.colProductid3.FieldName = "Productid"
        Me.colProductid3.Name = "colProductid3"
        Me.colProductid3.OptionsColumn.AllowEdit = False
        Me.colProductid3.OptionsColumn.FixedWidth = True
        Me.colProductid3.Visible = True
        Me.colProductid3.VisibleIndex = 2
        Me.colProductid3.Width = 50
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Item Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.OptionsColumn.AllowEdit = False
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 3
        Me.colProductdesc.Width = 324
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.OptionsColumn.AllowEdit = False
        Me.colContainer.OptionsColumn.FixedWidth = True
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 4
        Me.colContainer.Width = 90
        '
        'colShipmentnumber
        '
        Me.colShipmentnumber.FieldName = "Shipmentnumber"
        Me.colShipmentnumber.Name = "colShipmentnumber"
        '
        'colShipmentdate
        '
        Me.colShipmentdate.FieldName = "Shipmentdate"
        Me.colShipmentdate.Name = "colShipmentdate"
        '
        'colShippeddate
        '
        Me.colShippeddate.FieldName = "Shippeddate"
        Me.colShippeddate.Name = "colShippeddate"
        '
        'colReceiveddate
        '
        Me.colReceiveddate.Caption = "Received"
        Me.colReceiveddate.FieldName = "Receiveddate"
        Me.colReceiveddate.Name = "colReceiveddate"
        Me.colReceiveddate.OptionsColumn.AllowEdit = False
        Me.colReceiveddate.OptionsColumn.FixedWidth = True
        Me.colReceiveddate.Visible = True
        Me.colReceiveddate.VisibleIndex = 0
        Me.colReceiveddate.Width = 65
        '
        'colLotnumber1
        '
        Me.colLotnumber1.Caption = "Lot #"
        Me.colLotnumber1.FieldName = "Lotnumber"
        Me.colLotnumber1.Name = "colLotnumber1"
        Me.colLotnumber1.OptionsColumn.AllowEdit = False
        Me.colLotnumber1.OptionsColumn.FixedWidth = True
        Me.colLotnumber1.Visible = True
        Me.colLotnumber1.VisibleIndex = 5
        Me.colLotnumber1.Width = 80
        '
        'colWarehouselocation1
        '
        Me.colWarehouselocation1.Caption = "Bin"
        Me.colWarehouselocation1.FieldName = "Warehouselocation"
        Me.colWarehouselocation1.Name = "colWarehouselocation1"
        Me.colWarehouselocation1.OptionsColumn.AllowEdit = False
        Me.colWarehouselocation1.Width = 123
        '
        'colWarehousenumber
        '
        Me.colWarehousenumber.FieldName = "Warehousenumber"
        Me.colWarehousenumber.Name = "colWarehousenumber"
        '
        'colAllocateddate
        '
        Me.colAllocateddate.FieldName = "Allocateddate"
        Me.colAllocateddate.Name = "colAllocateddate"
        '
        'colReceivernumber
        '
        Me.colReceivernumber.FieldName = "Receivernumber"
        Me.colReceivernumber.Name = "colReceivernumber"
        '
        'colItemstatus
        '
        Me.colItemstatus.Caption = "Status"
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        Me.colItemstatus.OptionsColumn.AllowEdit = False
        Me.colItemstatus.OptionsColumn.FixedWidth = True
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 9
        Me.colItemstatus.Width = 78
        '
        'colInventoryclass
        '
        Me.colInventoryclass.FieldName = "Inventoryclass"
        Me.colInventoryclass.Name = "colInventoryclass"
        '
        'colClassdesc
        '
        Me.colClassdesc.FieldName = "Classdesc"
        Me.colClassdesc.Name = "colClassdesc"
        '
        'colUnitsremaining
        '
        Me.colUnitsremaining.FieldName = "Unitsremaining"
        Me.colUnitsremaining.Name = "colUnitsremaining"
        '
        'colReceiverdocument
        '
        Me.colReceiverdocument.FieldName = "Receiverdocument"
        Me.colReceiverdocument.Name = "colReceiverdocument"
        '
        'colReceiverdocumenttype
        '
        Me.colReceiverdocumenttype.FieldName = "Receiverdocumenttype"
        Me.colReceiverdocumenttype.Name = "colReceiverdocumenttype"
        '
        'colPonumber
        '
        Me.colPonumber.FieldName = "Ponumber"
        Me.colPonumber.Name = "colPonumber"
        '
        'colPurchasereleasenumber
        '
        Me.colPurchasereleasenumber.FieldName = "Purchasereleasenumber"
        Me.colPurchasereleasenumber.Name = "colPurchasereleasenumber"
        '
        'colVendorname
        '
        Me.colVendorname.FieldName = "Vendorname"
        Me.colVendorname.Name = "colVendorname"
        '
        'colPodate
        '
        Me.colPodate.FieldName = "Podate"
        Me.colPodate.Name = "colPodate"
        '
        'colChangeableponumber
        '
        Me.colChangeableponumber.FieldName = "Changeableponumber"
        Me.colChangeableponumber.Name = "colChangeableponumber"
        '
        'colAllocateddocument
        '
        Me.colAllocateddocument.FieldName = "Allocateddocument"
        Me.colAllocateddocument.Name = "colAllocateddocument"
        '
        'colWorkordernumber1
        '
        Me.colWorkordernumber1.FieldName = "Workordernumber"
        Me.colWorkordernumber1.Name = "colWorkordernumber1"
        '
        'colWorkordercustomer
        '
        Me.colWorkordercustomer.FieldName = "Workordercustomer"
        Me.colWorkordercustomer.Name = "colWorkordercustomer"
        '
        'colShiptocustomer
        '
        Me.colShiptocustomer.FieldName = "Shiptocustomer"
        Me.colShiptocustomer.Name = "colShiptocustomer"
        '
        'colInvSourceType
        '
        Me.colInvSourceType.Caption = "Src Type"
        Me.colInvSourceType.FieldName = "Sourcetype"
        Me.colInvSourceType.Name = "colInvSourceType"
        Me.colInvSourceType.OptionsColumn.FixedWidth = True
        Me.colInvSourceType.Visible = True
        Me.colInvSourceType.VisibleIndex = 6
        Me.colInvSourceType.Width = 55
        '
        'colInvSourcedocument
        '
        Me.colInvSourcedocument.Caption = "Src Doc"
        Me.colInvSourcedocument.FieldName = "Sourcedocument"
        Me.colInvSourcedocument.Name = "colInvSourcedocument"
        Me.colInvSourcedocument.OptionsColumn.FixedWidth = True
        Me.colInvSourcedocument.Visible = True
        Me.colInvSourcedocument.VisibleIndex = 7
        Me.colInvSourcedocument.Width = 50
        '
        'colInvAvailable
        '
        Me.colInvAvailable.Caption = "Available Date"
        Me.colInvAvailable.FieldName = "AvailableDate"
        Me.colInvAvailable.Name = "colInvAvailable"
        Me.colInvAvailable.OptionsColumn.FixedWidth = True
        Me.colInvAvailable.Visible = True
        Me.colInvAvailable.VisibleIndex = 10
        Me.colInvAvailable.Width = 80
        '
        'colInvSourceStatus
        '
        Me.colInvSourceStatus.Caption = "Src Status"
        Me.colInvSourceStatus.FieldName = "Sourcestatus"
        Me.colInvSourceStatus.Name = "colInvSourceStatus"
        Me.colInvSourceStatus.OptionsColumn.FixedWidth = True
        Me.colInvSourceStatus.Visible = True
        Me.colInvSourceStatus.VisibleIndex = 8
        Me.colInvSourceStatus.Width = 80
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit2.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ReadOnly = True
        Me.RepositoryItemLookUpEdit2.ShowFooter = False
        Me.RepositoryItemLookUpEdit2.ShowHeader = False
        Me.RepositoryItemLookUpEdit2.ShowLines = False
        Me.RepositoryItemLookUpEdit2.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit3.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.ReadOnly = True
        Me.RepositoryItemLookUpEdit3.ShowFooter = False
        Me.RepositoryItemLookUpEdit3.ShowHeader = False
        Me.RepositoryItemLookUpEdit3.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit5
        '
        Me.RepositoryItemLookUpEdit5.AutoHeight = False
        Me.RepositoryItemLookUpEdit5.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit5.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit5.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemLookUpEdit5.Name = "RepositoryItemLookUpEdit5"
        Me.RepositoryItemLookUpEdit5.NullText = ""
        Me.RepositoryItemLookUpEdit5.ReadOnly = True
        Me.RepositoryItemLookUpEdit5.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Caption = "Check"
        Me.RepositoryItemCheckEdit2.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit4.LookAndFeel.SkinName = "Money Twins"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ValueMember = "Productid"
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RibbonPanelControl4.Controls.Add(Me.GroupControl3)
        Me.RibbonPanelControl4.Controls.Add(Me.GroupControl4)
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1014, 301)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grRelabelOrders)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1014, 151)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "Relabel Orders Linked to Work Order / Relabel ID"
        '
        'grRelabelOrders
        '
        Me.grRelabelOrders.DataSource = Me.bsRelabelOrders
        Me.grRelabelOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grRelabelOrders.Location = New System.Drawing.Point(2, 22)
        Me.grRelabelOrders.MainView = Me.grvRelabelOrders
        Me.grRelabelOrders.Name = "grRelabelOrders"
        Me.grRelabelOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit18, Me.RepositoryItemLookUpEdit19, Me.RepositoryItemLookUpEdit20, Me.RepositoryItemCheckEdit6, Me.RepositoryItemLookUpEdit21})
        Me.grRelabelOrders.Size = New System.Drawing.Size(1010, 127)
        Me.grRelabelOrders.TabIndex = 6
        Me.grRelabelOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvRelabelOrders})
        '
        'bsRelabelOrders
        '
        Me.bsRelabelOrders.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrderCollection)
        '
        'grvRelabelOrders
        '
        Me.grvRelabelOrders.ActiveFilterEnabled = False
        Me.grvRelabelOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn25, Me.GridColumn26, Me.GridColumn28, Me.GridColumn36, Me.GridColumn29, Me.GridColumn33, Me.GridColumn34})
        Me.grvRelabelOrders.GridControl = Me.grRelabelOrders
        Me.grvRelabelOrders.Name = "grvRelabelOrders"
        Me.grvRelabelOrders.OptionsBehavior.Editable = False
        Me.grvRelabelOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvRelabelOrders.OptionsView.ShowGroupPanel = False
        Me.grvRelabelOrders.OptionsView.ShowIndicator = False
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Ord #"
        Me.GridColumn25.FieldName = "Relabelordernumber"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.FixedWidth = True
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 0
        Me.GridColumn25.Width = 45
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Ord Date"
        Me.GridColumn26.DisplayFormat.FormatString = "d"
        Me.GridColumn26.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn26.FieldName = "Relabelorderdate"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 1
        Me.GridColumn26.Width = 65
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Item ID"
        Me.GridColumn28.FieldName = "Itemid"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 2
        Me.GridColumn28.Width = 50
        '
        'GridColumn36
        '
        Me.GridColumn36.Caption = "Item Description"
        Me.GridColumn36.FieldName = "Itemdesc"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 3
        Me.GridColumn36.Width = 666
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Qty"
        Me.GridColumn29.FieldName = "Qty"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.OptionsColumn.FixedWidth = True
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 4
        Me.GridColumn29.Width = 45
        '
        'GridColumn33
        '
        Me.GridColumn33.Caption = "Needed By"
        Me.GridColumn33.DisplayFormat.FormatString = "d"
        Me.GridColumn33.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn33.FieldName = "Neededby"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.OptionsColumn.FixedWidth = True
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 5
        Me.GridColumn33.Width = 70
        '
        'GridColumn34
        '
        Me.GridColumn34.Caption = "Status"
        Me.GridColumn34.FieldName = "Relabelorderstatus"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.OptionsColumn.FixedWidth = True
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 6
        '
        'RepositoryItemLookUpEdit18
        '
        Me.RepositoryItemLookUpEdit18.AutoHeight = False
        Me.RepositoryItemLookUpEdit18.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit18.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit18.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit18.Name = "RepositoryItemLookUpEdit18"
        Me.RepositoryItemLookUpEdit18.NullText = ""
        Me.RepositoryItemLookUpEdit18.ReadOnly = True
        Me.RepositoryItemLookUpEdit18.ShowFooter = False
        Me.RepositoryItemLookUpEdit18.ShowHeader = False
        Me.RepositoryItemLookUpEdit18.ShowLines = False
        Me.RepositoryItemLookUpEdit18.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit19
        '
        Me.RepositoryItemLookUpEdit19.AutoHeight = False
        Me.RepositoryItemLookUpEdit19.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit19.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit19.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit19.Name = "RepositoryItemLookUpEdit19"
        Me.RepositoryItemLookUpEdit19.NullText = ""
        Me.RepositoryItemLookUpEdit19.ReadOnly = True
        Me.RepositoryItemLookUpEdit19.ShowFooter = False
        Me.RepositoryItemLookUpEdit19.ShowHeader = False
        Me.RepositoryItemLookUpEdit19.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit20
        '
        Me.RepositoryItemLookUpEdit20.AutoHeight = False
        Me.RepositoryItemLookUpEdit20.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit20.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit20.Name = "RepositoryItemLookUpEdit20"
        Me.RepositoryItemLookUpEdit20.NullText = ""
        Me.RepositoryItemLookUpEdit20.ReadOnly = True
        Me.RepositoryItemLookUpEdit20.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit6
        '
        Me.RepositoryItemCheckEdit6.AutoHeight = False
        Me.RepositoryItemCheckEdit6.Caption = "Check"
        Me.RepositoryItemCheckEdit6.Name = "RepositoryItemCheckEdit6"
        '
        'RepositoryItemLookUpEdit21
        '
        Me.RepositoryItemLookUpEdit21.AutoHeight = False
        Me.RepositoryItemLookUpEdit21.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit21.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit21.Name = "RepositoryItemLookUpEdit21"
        Me.RepositoryItemLookUpEdit21.NullText = ""
        Me.RepositoryItemLookUpEdit21.ValueMember = "Productid"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.grCanceledRelabelOrders)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupControl4.Location = New System.Drawing.Point(0, 151)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1014, 150)
        Me.GroupControl4.TabIndex = 5
        Me.GroupControl4.Text = "Cancelled Relabel Orders"
        '
        'grCanceledRelabelOrders
        '
        Me.grCanceledRelabelOrders.DataSource = Me.bsCancelledRelabelOrders
        Me.grCanceledRelabelOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCanceledRelabelOrders.Location = New System.Drawing.Point(2, 22)
        Me.grCanceledRelabelOrders.MainView = Me.grvCanceledRelabelOrders
        Me.grCanceledRelabelOrders.Name = "grCanceledRelabelOrders"
        Me.grCanceledRelabelOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit22, Me.RepositoryItemLookUpEdit23, Me.RepositoryItemLookUpEdit24, Me.RepositoryItemCheckEdit7, Me.RepositoryItemLookUpEdit25})
        Me.grCanceledRelabelOrders.Size = New System.Drawing.Size(1010, 126)
        Me.grCanceledRelabelOrders.TabIndex = 6
        Me.grCanceledRelabelOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCanceledRelabelOrders})
        '
        'bsCancelledRelabelOrders
        '
        Me.bsCancelledRelabelOrders.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrderCollection)
        '
        'grvCanceledRelabelOrders
        '
        Me.grvCanceledRelabelOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn40, Me.GridColumn41, Me.GridColumn43, Me.GridColumn51, Me.GridColumn44, Me.GridColumn48, Me.GridColumn49})
        Me.grvCanceledRelabelOrders.GridControl = Me.grCanceledRelabelOrders
        Me.grvCanceledRelabelOrders.Name = "grvCanceledRelabelOrders"
        Me.grvCanceledRelabelOrders.OptionsBehavior.Editable = False
        Me.grvCanceledRelabelOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvCanceledRelabelOrders.OptionsView.ShowGroupPanel = False
        Me.grvCanceledRelabelOrders.OptionsView.ShowIndicator = False
        '
        'GridColumn40
        '
        Me.GridColumn40.Caption = "Ord #"
        Me.GridColumn40.FieldName = "Relabelordernumber"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.OptionsColumn.FixedWidth = True
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 0
        Me.GridColumn40.Width = 45
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Ord Date"
        Me.GridColumn41.DisplayFormat.FormatString = "d"
        Me.GridColumn41.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn41.FieldName = "Relabelorderdate"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.OptionsColumn.FixedWidth = True
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 1
        Me.GridColumn41.Width = 65
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "Item ID"
        Me.GridColumn43.FieldName = "Itemid"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.OptionsColumn.FixedWidth = True
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 2
        Me.GridColumn43.Width = 50
        '
        'GridColumn51
        '
        Me.GridColumn51.Caption = "Item Description"
        Me.GridColumn51.FieldName = "Itemdesc"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.OptionsColumn.FixedWidth = True
        Me.GridColumn51.Visible = True
        Me.GridColumn51.VisibleIndex = 3
        Me.GridColumn51.Width = 605
        '
        'GridColumn44
        '
        Me.GridColumn44.Caption = "Qty"
        Me.GridColumn44.FieldName = "Qty"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.OptionsColumn.FixedWidth = True
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 4
        Me.GridColumn44.Width = 45
        '
        'GridColumn48
        '
        Me.GridColumn48.Caption = "Needed By"
        Me.GridColumn48.DisplayFormat.FormatString = "d"
        Me.GridColumn48.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn48.FieldName = "Neededby"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.OptionsColumn.FixedWidth = True
        Me.GridColumn48.Visible = True
        Me.GridColumn48.VisibleIndex = 5
        Me.GridColumn48.Width = 60
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "Status"
        Me.GridColumn49.FieldName = "Relabelorderstatus"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.OptionsColumn.FixedWidth = True
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 6
        '
        'RepositoryItemLookUpEdit22
        '
        Me.RepositoryItemLookUpEdit22.AutoHeight = False
        Me.RepositoryItemLookUpEdit22.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit22.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit22.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit22.Name = "RepositoryItemLookUpEdit22"
        Me.RepositoryItemLookUpEdit22.NullText = ""
        Me.RepositoryItemLookUpEdit22.ReadOnly = True
        Me.RepositoryItemLookUpEdit22.ShowFooter = False
        Me.RepositoryItemLookUpEdit22.ShowHeader = False
        Me.RepositoryItemLookUpEdit22.ShowLines = False
        Me.RepositoryItemLookUpEdit22.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit23
        '
        Me.RepositoryItemLookUpEdit23.AutoHeight = False
        Me.RepositoryItemLookUpEdit23.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit23.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit23.DisplayMember = "Container"
        Me.RepositoryItemLookUpEdit23.Name = "RepositoryItemLookUpEdit23"
        Me.RepositoryItemLookUpEdit23.NullText = ""
        Me.RepositoryItemLookUpEdit23.ReadOnly = True
        Me.RepositoryItemLookUpEdit23.ShowFooter = False
        Me.RepositoryItemLookUpEdit23.ShowHeader = False
        Me.RepositoryItemLookUpEdit23.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit24
        '
        Me.RepositoryItemLookUpEdit24.AutoHeight = False
        Me.RepositoryItemLookUpEdit24.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit24.DisplayMember = "Stdgallons"
        Me.RepositoryItemLookUpEdit24.Name = "RepositoryItemLookUpEdit24"
        Me.RepositoryItemLookUpEdit24.NullText = ""
        Me.RepositoryItemLookUpEdit24.ReadOnly = True
        Me.RepositoryItemLookUpEdit24.ValueMember = "Productid"
        '
        'RepositoryItemCheckEdit7
        '
        Me.RepositoryItemCheckEdit7.AutoHeight = False
        Me.RepositoryItemCheckEdit7.Caption = "Check"
        Me.RepositoryItemCheckEdit7.Name = "RepositoryItemCheckEdit7"
        '
        'RepositoryItemLookUpEdit25
        '
        Me.RepositoryItemLookUpEdit25.AutoHeight = False
        Me.RepositoryItemLookUpEdit25.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit25.DisplayMember = "Desc2"
        Me.RepositoryItemLookUpEdit25.Name = "RepositoryItemLookUpEdit25"
        Me.RepositoryItemLookUpEdit25.NullText = ""
        Me.RepositoryItemLookUpEdit25.ValueMember = "Productid"
        '
        'frmAssignInventoryItems2
        '
        Me.ClientSize = New System.Drawing.Size(1018, 733)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAssignInventoryItems2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Assign Inventory Items to Work Order Items"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWorkOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grWorkOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWOItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvWorkOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.WorkPanelHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCancelledPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.gvPurchaseRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPurchaseRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.gpProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpProductionOrders.ResumeLayout(False)
        CType(Me.grProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProdOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpCanceledProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpCanceledProductionOrders.ResumeLayout(False)
        CType(Me.grCanceledProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCancelledProdOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCanceledProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.grAvailableInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAvailableInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvAvailableInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl4.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grRelabelOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRelabelOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvRelabelOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grCanceledRelabelOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCancelledRelabelOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCanceledRelabelOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit25, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents WorkPanelHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents bsWorkOrder As System.Windows.Forms.BindingSource
    Friend WithEvents bsWOItems As System.Windows.Forms.BindingSource
    Friend WithEvents bsAvailableInventory As System.Windows.Forms.BindingSource
    Friend WithEvents bsPurchaseItems As System.Windows.Forms.BindingSource
    Friend WithEvents bsProdOrders As System.Windows.Forms.BindingSource
    Friend WithEvents grWorkOrderItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvWorkOrderItems As CustomDevExGridView
    Friend WithEvents luProductDesc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luContainer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luStdgallons As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnSearchInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAllocateItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnLookupInventoryToConvert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnGetProductionOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddNewProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancelProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnGetPurchaseItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddNewPurchaseItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditPurchaseItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeletePurchaseItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnUnallocateWorkOrderItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colWorkorderitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouselocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourcetype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourcedocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitorcontainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpProductionOrders As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grProductionOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvProductionOrders As CustomDevExGridView
    Friend WithEvents colProdordernum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdorderdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisnum1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeededby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIscomplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit14 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit15 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit16 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit17 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grAvailableInventory As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvAvailableInventory As CustomDevExGridView
    Friend WithEvents colInvitemnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippeddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouselocation1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehousenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryclass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsremaining As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocumenttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPonumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasereleasenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPodate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangeableponumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateddocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordercustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptocustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents gvPurchaseRequests As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPurchaseRequests As CustomDevExGridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvSourceType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvSourcedocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvSourceStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gpCanceledProductionOrders As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grCanceledProductionOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCanceledProductionOrders As CustomDevExGridView
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
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit9 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsCancelledProdOrders As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grRelabelOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvRelabelOrders As CustomDevExGridView
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit18 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit19 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit20 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit21 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grCanceledRelabelOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCanceledRelabelOrders As CustomDevExGridView
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit22 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit23 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit24 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit25 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rbtnGetRelabelOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddNewRelabelOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancelRelabelOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintRelabelOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsRelabelOrders As System.Windows.Forms.BindingSource
    Friend WithEvents bsCancelledRelabelOrders As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend CustomDevExGridView1 As CustomDevExGridView
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit26 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit27 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit28 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit8 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit29 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsCancelledPurchaseItems As BindingSource
End Class
