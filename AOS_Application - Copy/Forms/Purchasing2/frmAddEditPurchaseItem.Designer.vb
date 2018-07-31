<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddEditPurchaseItem

    'Form overrides dispose to clean up the component list.
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
        Dim PurchaseItemNumLabel As System.Windows.Forms.Label
        Dim ProdorderdateLabel As System.Windows.Forms.Label
        Dim NeededbyLabel As System.Windows.Forms.Label
        Dim ProductqtyLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim UnitorcontainerLabel As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim TypeLabel As System.Windows.Forms.Label
        Dim SourceDocLabel As System.Windows.Forms.Label
        Dim SourceTypeLabel As System.Windows.Forms.Label
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditPurchaseItem))
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsVendor = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsPurchaseItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnConvertFullAvailabletoInProcess = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnNewPurchaseReq = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CustomerPONumTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SourceTypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ExpectedInLabel = New System.Windows.Forms.Label()
        Me.ExpectedInDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.VendorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsVendorItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.eVendorItemNumber = New DevExpress.XtraEditors.TextEdit()
        Me.ItemTypeLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsItemTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.UCTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitCostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UOMTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.StatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SourceDocTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemIDLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContainerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemDescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QtyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NeededbyDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PurchitemdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.PurchItemnumTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.WorkPanelHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.grProductCosts = New DevExpress.XtraGrid.GridControl()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView8 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colVUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn69 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Costtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatecostchanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsActive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grAvailableInventory = New DevExpress.XtraGrid.GridControl()
        Me.bsAvailableInventory = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvailableInventory = New AOS.CustomClasses.CustomDevExGridView()
        Me.InvItemNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdcutID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedShip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippeddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouselocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehousenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryclass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassdesc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsremaining1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocument1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocumenttype1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPonumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasereleasenumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPodate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangeableponumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateddocument1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordercustomer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptocustomer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grAllocatedInventory = New DevExpress.XtraGrid.GridControl()
        Me.bsAllocatedInventory = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvAllocatedInventory = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn112 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn111 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView6 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView7 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.gpProductionOrders = New DevExpress.XtraEditors.GroupControl()
        Me.grProductionOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsProdOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvProductionOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdNeededby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView5 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.gpCanceledProductionOrders = New DevExpress.XtraEditors.GroupControl()
        Me.grCanceledProductionOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsCanceledProdOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvCanceledProductionOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn70 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn71 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn72 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn73 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn74 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn75 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn76 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn77 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn78 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn79 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn80 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn81 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView3 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn82 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn83 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn84 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn85 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn86 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn87 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn88 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn89 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn90 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn91 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn92 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn93 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn94 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn95 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn96 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn97 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn98 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn99 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn100 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn101 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn102 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn103 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn104 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn105 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn106 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn107 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn108 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn109 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.grInventoryItems = New DevExpress.XtraGrid.GridControl()
        Me.bsInventoryItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvInventoryItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SourceDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn68 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RibbonPanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grRelabelOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsRelabelOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvRelabelOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.colOrderNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeededBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit18 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit19 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit20 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit21 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grCanceledRelabelOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsCanceledRelabelOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvCanceledRelabelOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.colCanceledOrderNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanceledOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanceledItemID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanceledItemDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanceledQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanceledNeededBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCanceledOrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit22 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit23 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit24 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit7 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit25 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnSearchInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAllocateItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnLookupInventoryToConvert = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetProductionOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetPurchaseReqs = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewPurchaseReq = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditPurchaseReq = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeletePurchaseReq = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAllocatedSearchInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReAllocateItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetProductionOrders2 = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewProductionOrder2 = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditProductionOrder2 = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancelProductionOrder2 = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintProductionOrder2 = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSelect = New DevExpress.XtraBars.BarButtonItem()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.bLblVolumeUnits = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblVolumeUOM = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblVolumeStandardCost = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblWeightUnits = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblWeightUOM = New DevExpress.XtraBars.BarStaticItem()
        Me.bLblWeightStandardCost = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtVolumeUnits = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtVolumeUOM = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtlVolumeStandardCost = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtWeightUnits = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtWeightUOM = New DevExpress.XtraBars.BarStaticItem()
        Me.bTxtWeightStandardCost = New DevExpress.XtraBars.BarStaticItem()
        Me.btnChangeInventoryClass = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetRelabelOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewRelabelOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancelRelabelOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintRelabelOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage6 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup11 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage8 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup13 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage7 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup12 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.colShiptocustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordercustomer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllocateddocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangeableponumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPodate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasereleasenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPonumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocumenttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsremaining = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsProduct1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridColumn110 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lblCustomerPO = New DevExpress.XtraEditors.LabelControl()
        PurchaseItemNumLabel = New System.Windows.Forms.Label()
        ProdorderdateLabel = New System.Windows.Forms.Label()
        NeededbyLabel = New System.Windows.Forms.Label()
        ProductqtyLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        UnitorcontainerLabel = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        TypeLabel = New System.Windows.Forms.Label()
        SourceDocLabel = New System.Windows.Forms.Label()
        SourceTypeLabel = New System.Windows.Forms.Label()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CustomerPONumTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedInDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedInDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendorItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendorItemNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItemTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UCTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UOMTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceDocTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemDescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeededbyDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeededbyDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchitemdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchitemdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchItemnumTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.WorkPanelHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelHolder.SuspendLayout()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl6.SuspendLayout()
        CType(Me.grProductCosts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.grAvailableInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAvailableInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvailableInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.grAllocatedInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAllocatedInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvAllocatedInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl4.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl5.SuspendLayout()
        CType(Me.gpProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpProductionOrders.SuspendLayout()
        CType(Me.grProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProdOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gpCanceledProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpCanceledProductionOrders.SuspendLayout()
        CType(Me.grCanceledProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCanceledProdOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCanceledProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl7.SuspendLayout()
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl8.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
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
        CType(Me.bsCanceledRelabelOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvCanceledRelabelOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurchaseItemNumLabel
        '
        PurchaseItemNumLabel.AutoSize = True
        PurchaseItemNumLabel.Location = New System.Drawing.Point(17, 34)
        PurchaseItemNumLabel.Name = "PurchaseItemNumLabel"
        PurchaseItemNumLabel.Size = New System.Drawing.Size(70, 13)
        PurchaseItemNumLabel.TabIndex = 0
        PurchaseItemNumLabel.Text = "Purch Item #"
        '
        'ProdorderdateLabel
        '
        ProdorderdateLabel.AutoSize = True
        ProdorderdateLabel.Location = New System.Drawing.Point(98, 34)
        ProdorderdateLabel.Name = "ProdorderdateLabel"
        ProdorderdateLabel.Size = New System.Drawing.Size(30, 13)
        ProdorderdateLabel.TabIndex = 2
        ProdorderdateLabel.Text = "Date"
        '
        'NeededbyLabel
        '
        NeededbyLabel.AutoSize = True
        NeededbyLabel.Location = New System.Drawing.Point(325, 170)
        NeededbyLabel.Name = "NeededbyLabel"
        NeededbyLabel.Size = New System.Drawing.Size(59, 13)
        NeededbyLabel.TabIndex = 38
        NeededbyLabel.Text = "Needed by"
        '
        'ProductqtyLabel
        '
        ProductqtyLabel.AutoSize = True
        ProductqtyLabel.Location = New System.Drawing.Point(17, 79)
        ProductqtyLabel.Name = "ProductqtyLabel"
        ProductqtyLabel.Size = New System.Drawing.Size(25, 13)
        ProductqtyLabel.TabIndex = 10
        ProductqtyLabel.Text = "Qty"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(193, 125)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 13)
        Label1.TabIndex = 26
        Label1.Text = "Customer"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(739, 79)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 13)
        Label2.TabIndex = 20
        Label2.Text = "Container"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(325, 79)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 13)
        Label3.TabIndex = 16
        Label3.Text = "Item ID"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(429, 79)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(85, 13)
        Label4.TabIndex = 18
        Label4.Text = "Item Description"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(193, 34)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 4
        Label5.Text = "Status"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(17, 170)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(41, 13)
        Label6.TabIndex = 36
        Label6.Text = "Vendor"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(429, 125)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(31, 13)
        Label7.TabIndex = 28
        Label7.Text = "Units"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(526, 125)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(30, 13)
        Label8.TabIndex = 30
        Label8.Text = "UOM"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(626, 125)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(51, 13)
        Label9.TabIndex = 32
        Label9.Text = "Unit Cost"
        '
        'UnitorcontainerLabel
        '
        UnitorcontainerLabel.AutoSize = True
        UnitorcontainerLabel.Location = New System.Drawing.Point(98, 79)
        UnitorcontainerLabel.Name = "UnitorcontainerLabel"
        UnitorcontainerLabel.Size = New System.Drawing.Size(25, 13)
        UnitorcontainerLabel.TabIndex = 12
        UnitorcontainerLabel.Text = "U/C"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(193, 79)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(56, 13)
        Label10.TabIndex = 14
        Label10.Text = "Item Type"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(739, 125)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(77, 13)
        Label11.TabIndex = 34
        Label11.Text = "Vendor Item #"
        '
        'TypeLabel
        '
        TypeLabel.AutoSize = True
        TypeLabel.Location = New System.Drawing.Point(325, 34)
        TypeLabel.Name = "TypeLabel"
        TypeLabel.Size = New System.Drawing.Size(31, 13)
        TypeLabel.TabIndex = 6
        TypeLabel.Text = "Type"
        '
        'SourceDocLabel
        '
        SourceDocLabel.AutoSize = True
        SourceDocLabel.Location = New System.Drawing.Point(17, 125)
        SourceDocLabel.Name = "SourceDocLabel"
        SourceDocLabel.Size = New System.Drawing.Size(61, 13)
        SourceDocLabel.TabIndex = 22
        SourceDocLabel.Text = "Source Doc"
        '
        'SourceTypeLabel
        '
        SourceTypeLabel.AutoSize = True
        SourceTypeLabel.Location = New System.Drawing.Point(98, 125)
        SourceTypeLabel.Name = "SourceTypeLabel"
        SourceTypeLabel.Size = New System.Drawing.Size(67, 13)
        SourceTypeLabel.TabIndex = 24
        SourceTypeLabel.Text = "Source Type"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsVendor
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Vendorname"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ReadOnly = True
        Me.RepositoryItemLookUpEdit1.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never
        Me.RepositoryItemLookUpEdit1.ValueMember = "Vendorid"
        '
        'bsVendor
        '
        Me.bsVendor.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsPurchaseItem
        '
        Me.bsPurchaseItem.DataSource = GetType(AOS.BusinessObjects.Purchaseitem)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.rbtnConvertFullAvailabletoInProcess, Me.rbtnNewPurchaseReq})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 10
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(930, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'rbtnConvertFullAvailabletoInProcess
        '
        Me.rbtnConvertFullAvailabletoInProcess.Caption = "Convert Available Inventory to In Process"
        Me.rbtnConvertFullAvailabletoInProcess.Id = 8
        Me.rbtnConvertFullAvailabletoInProcess.LargeGlyph = Global.AOS.My.Resources.Resources.Quarantine
        Me.rbtnConvertFullAvailabletoInProcess.Name = "rbtnConvertFullAvailabletoInProcess"
        '
        'rbtnNewPurchaseReq
        '
        Me.rbtnNewPurchaseReq.Caption = "Create New Purchase Req"
        Me.rbtnNewPurchaseReq.Id = 9
        Me.rbtnNewPurchaseReq.LargeGlyph = Global.AOS.My.Resources.Resources.list_add
        Me.rbtnNewPurchaseReq.Name = "rbtnNewPurchaseReq"
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
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(930, 221)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblCustomerPO)
        Me.GroupControl1.Controls.Add(Me.CustomerPONumTextEdit)
        Me.GroupControl1.Controls.Add(Me.SourceTypeTextEdit)
        Me.GroupControl1.Controls.Add(SourceTypeLabel)
        Me.GroupControl1.Controls.Add(Me.TypeTextEdit)
        Me.GroupControl1.Controls.Add(TypeLabel)
        Me.GroupControl1.Controls.Add(Me.ExpectedInLabel)
        Me.GroupControl1.Controls.Add(Me.ExpectedInDateEdit)
        Me.GroupControl1.Controls.Add(Me.VendorTextEdit)
        Me.GroupControl1.Controls.Add(Label11)
        Me.GroupControl1.Controls.Add(Me.eVendorItemNumber)
        Me.GroupControl1.Controls.Add(Label10)
        Me.GroupControl1.Controls.Add(Me.ItemTypeLookUpEdit)
        Me.GroupControl1.Controls.Add(UnitorcontainerLabel)
        Me.GroupControl1.Controls.Add(Me.UCTextEdit)
        Me.GroupControl1.Controls.Add(Me.CustomerLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.UnitCostTextEdit)
        Me.GroupControl1.Controls.Add(Me.UOMTextEdit)
        Me.GroupControl1.Controls.Add(Me.UnitTextEdit)
        Me.GroupControl1.Controls.Add(Label9)
        Me.GroupControl1.Controls.Add(Label8)
        Me.GroupControl1.Controls.Add(Label7)
        Me.GroupControl1.Controls.Add(Label6)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Me.StatusTextEdit)
        Me.GroupControl1.Controls.Add(Me.SourceDocTextEdit)
        Me.GroupControl1.Controls.Add(Me.ItemIDLookUpEdit)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.ContainerTextEdit)
        Me.GroupControl1.Controls.Add(Me.ItemDescTextEdit)
        Me.GroupControl1.Controls.Add(ProductqtyLabel)
        Me.GroupControl1.Controls.Add(Me.QtyTextEdit)
        Me.GroupControl1.Controls.Add(NeededbyLabel)
        Me.GroupControl1.Controls.Add(Me.NeededbyDateEdit)
        Me.GroupControl1.Controls.Add(ProdorderdateLabel)
        Me.GroupControl1.Controls.Add(Me.PurchitemdateDateEdit)
        Me.GroupControl1.Controls.Add(SourceDocLabel)
        Me.GroupControl1.Controls.Add(PurchaseItemNumLabel)
        Me.GroupControl1.Controls.Add(Me.PurchItemnumTextEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(926, 217)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Purchase Items Information"
        '
        'CustomerPONumTextEdit
        '
        Me.CustomerPONumTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Customerpo", True))
        Me.CustomerPONumTextEdit.Location = New System.Drawing.Point(429, 50)
        Me.CustomerPONumTextEdit.MenuManager = Me.RibbonControl1
        Me.CustomerPONumTextEdit.Name = "CustomerPONumTextEdit"
        Me.CustomerPONumTextEdit.Properties.MaxLength = 50
        Me.CustomerPONumTextEdit.Size = New System.Drawing.Size(87, 20)
        Me.CustomerPONumTextEdit.TabIndex = 9
        Me.CustomerPONumTextEdit.Visible = False
        '
        'SourceTypeTextEdit
        '
        Me.SourceTypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Sourcetype", True))
        Me.SourceTypeTextEdit.Location = New System.Drawing.Point(98, 140)
        Me.SourceTypeTextEdit.MenuManager = Me.RibbonControl1
        Me.SourceTypeTextEdit.Name = "SourceTypeTextEdit"
        Me.SourceTypeTextEdit.Properties.ReadOnly = True
        Me.SourceTypeTextEdit.Size = New System.Drawing.Size(83, 20)
        Me.SourceTypeTextEdit.TabIndex = 25
        '
        'TypeTextEdit
        '
        Me.TypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Purchaseitemtype", True))
        Me.TypeTextEdit.Location = New System.Drawing.Point(325, 50)
        Me.TypeTextEdit.MenuManager = Me.RibbonControl1
        Me.TypeTextEdit.Name = "TypeTextEdit"
        Me.TypeTextEdit.Properties.ReadOnly = True
        Me.TypeTextEdit.Size = New System.Drawing.Size(94, 20)
        Me.TypeTextEdit.TabIndex = 7
        '
        'ExpectedInLabel
        '
        Me.ExpectedInLabel.AutoSize = True
        Me.ExpectedInLabel.Location = New System.Drawing.Point(429, 170)
        Me.ExpectedInLabel.Name = "ExpectedInLabel"
        Me.ExpectedInLabel.Size = New System.Drawing.Size(65, 13)
        Me.ExpectedInLabel.TabIndex = 40
        Me.ExpectedInLabel.Text = "Expected In"
        '
        'ExpectedInDateEdit
        '
        Me.ExpectedInDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Expectedindate", True))
        Me.ExpectedInDateEdit.EditValue = Nothing
        Me.ExpectedInDateEdit.Location = New System.Drawing.Point(429, 185)
        Me.ExpectedInDateEdit.MenuManager = Me.RibbonControl1
        Me.ExpectedInDateEdit.Name = "ExpectedInDateEdit"
        Me.ExpectedInDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExpectedInDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ExpectedInDateEdit.Size = New System.Drawing.Size(87, 20)
        Me.ExpectedInDateEdit.TabIndex = 41
        '
        'VendorTextEdit
        '
        Me.VendorTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendorItem, "Vendorname", True))
        Me.VendorTextEdit.Location = New System.Drawing.Point(17, 185)
        Me.VendorTextEdit.MenuManager = Me.RibbonControl1
        Me.VendorTextEdit.Name = "VendorTextEdit"
        Me.VendorTextEdit.Properties.ReadOnly = True
        Me.VendorTextEdit.Size = New System.Drawing.Size(298, 20)
        Me.VendorTextEdit.TabIndex = 37
        '
        'bsVendorItem
        '
        Me.bsVendorItem.DataSource = GetType(AOS.BusinessObjects.Vendor)
        '
        'eVendorItemNumber
        '
        Me.eVendorItemNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Vendoritemnumber", True))
        Me.eVendorItemNumber.Location = New System.Drawing.Point(739, 140)
        Me.eVendorItemNumber.Name = "eVendorItemNumber"
        Me.eVendorItemNumber.Properties.Appearance.Options.UseTextOptions = True
        Me.eVendorItemNumber.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eVendorItemNumber.Size = New System.Drawing.Size(99, 20)
        Me.eVendorItemNumber.TabIndex = 35
        '
        'ItemTypeLookUpEdit
        '
        Me.ItemTypeLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Itemtype", True))
        Me.ItemTypeLookUpEdit.Location = New System.Drawing.Point(193, 95)
        Me.ItemTypeLookUpEdit.Name = "ItemTypeLookUpEdit"
        Me.ItemTypeLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemTypeLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Itemtype", "Item type", 54, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ItemTypeLookUpEdit.Properties.DataSource = Me.bsItemTypes
        Me.ItemTypeLookUpEdit.Properties.DisplayMember = "Itemtype"
        Me.ItemTypeLookUpEdit.Properties.DropDownRows = 10
        Me.ItemTypeLookUpEdit.Properties.NullText = ""
        Me.ItemTypeLookUpEdit.Properties.PopupSizeable = False
        Me.ItemTypeLookUpEdit.Properties.PopupWidth = 107
        Me.ItemTypeLookUpEdit.Properties.ShowFooter = False
        Me.ItemTypeLookUpEdit.Properties.ShowHeader = False
        Me.ItemTypeLookUpEdit.Properties.ValueMember = "Itemtype"
        Me.ItemTypeLookUpEdit.Size = New System.Drawing.Size(122, 20)
        Me.ItemTypeLookUpEdit.TabIndex = 15
        '
        'bsItemTypes
        '
        Me.bsItemTypes.DataSource = GetType(AOS.BusinessObjects.ListItemtypeCollection)
        '
        'UCTextEdit
        '
        Me.UCTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Unitorcontainer", True))
        Me.UCTextEdit.Location = New System.Drawing.Point(98, 95)
        Me.UCTextEdit.Name = "UCTextEdit"
        Me.UCTextEdit.Properties.Mask.EditMask = "U|C"
        Me.UCTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
        Me.UCTextEdit.Properties.Mask.ShowPlaceHolders = False
        Me.UCTextEdit.Size = New System.Drawing.Size(83, 20)
        Me.UCTextEdit.TabIndex = 13
        '
        'CustomerLookUpEdit
        '
        Me.CustomerLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Customerid", True))
        Me.CustomerLookUpEdit.Location = New System.Drawing.Point(193, 140)
        Me.CustomerLookUpEdit.MenuManager = Me.RibbonControl1
        Me.CustomerLookUpEdit.Name = "CustomerLookUpEdit"
        Me.CustomerLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustomerLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustomerLookUpEdit.Properties.DataSource = Me.bsCustomers
        Me.CustomerLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustomerLookUpEdit.Properties.NullText = ""
        Me.CustomerLookUpEdit.Properties.PopupWidth = 320
        Me.CustomerLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustomerLookUpEdit.Size = New System.Drawing.Size(226, 20)
        Me.CustomerLookUpEdit.TabIndex = 27
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'UnitCostTextEdit
        '
        Me.UnitCostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Unitcost", True))
        Me.UnitCostTextEdit.Location = New System.Drawing.Point(626, 140)
        Me.UnitCostTextEdit.MenuManager = Me.RibbonControl1
        Me.UnitCostTextEdit.Name = "UnitCostTextEdit"
        Me.UnitCostTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.UnitCostTextEdit.Size = New System.Drawing.Size(103, 20)
        Me.UnitCostTextEdit.TabIndex = 33
        '
        'UOMTextEdit
        '
        Me.UOMTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Uom", True))
        Me.UOMTextEdit.Location = New System.Drawing.Point(526, 140)
        Me.UOMTextEdit.MenuManager = Me.RibbonControl1
        Me.UOMTextEdit.Name = "UOMTextEdit"
        Me.UOMTextEdit.Size = New System.Drawing.Size(90, 20)
        Me.UOMTextEdit.TabIndex = 31
        '
        'UnitTextEdit
        '
        Me.UnitTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Unitsincontainer", True))
        Me.UnitTextEdit.Location = New System.Drawing.Point(429, 140)
        Me.UnitTextEdit.MenuManager = Me.RibbonControl1
        Me.UnitTextEdit.Name = "UnitTextEdit"
        Me.UnitTextEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.UnitTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitTextEdit.Properties.MaxLength = 9
        Me.UnitTextEdit.Size = New System.Drawing.Size(87, 20)
        Me.UnitTextEdit.TabIndex = 29
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Purchaseitemstatus", True))
        Me.StatusTextEdit.Location = New System.Drawing.Point(193, 50)
        Me.StatusTextEdit.MenuManager = Me.RibbonControl1
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Properties.ReadOnly = True
        Me.StatusTextEdit.Size = New System.Drawing.Size(122, 20)
        Me.StatusTextEdit.TabIndex = 5
        '
        'SourceDocTextEdit
        '
        Me.SourceDocTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Sourcedocument", True))
        Me.SourceDocTextEdit.Location = New System.Drawing.Point(17, 140)
        Me.SourceDocTextEdit.MenuManager = Me.RibbonControl1
        Me.SourceDocTextEdit.Name = "SourceDocTextEdit"
        Me.SourceDocTextEdit.Properties.ReadOnly = True
        Me.SourceDocTextEdit.Size = New System.Drawing.Size(71, 20)
        Me.SourceDocTextEdit.TabIndex = 23
        '
        'ItemIDLookUpEdit
        '
        Me.ItemIDLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Itemid", True))
        Me.ItemIDLookUpEdit.Location = New System.Drawing.Point(325, 95)
        Me.ItemIDLookUpEdit.MenuManager = Me.RibbonControl1
        Me.ItemIDLookUpEdit.Name = "ItemIDLookUpEdit"
        Me.ItemIDLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ItemIDLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ProdID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Units", "Units", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "Uom", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ItemIDLookUpEdit.Properties.DataSource = Me.bsProduct
        Me.ItemIDLookUpEdit.Properties.DisplayMember = "Productid"
        Me.ItemIDLookUpEdit.Properties.NullText = ""
        Me.ItemIDLookUpEdit.Properties.PopupWidth = 375
        Me.ItemIDLookUpEdit.Properties.ValueMember = "Productid"
        Me.ItemIDLookUpEdit.Size = New System.Drawing.Size(94, 20)
        Me.ItemIDLookUpEdit.TabIndex = 17
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'ContainerTextEdit
        '
        Me.ContainerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Container", True))
        Me.ContainerTextEdit.Location = New System.Drawing.Point(739, 95)
        Me.ContainerTextEdit.MenuManager = Me.RibbonControl1
        Me.ContainerTextEdit.Name = "ContainerTextEdit"
        Me.ContainerTextEdit.Properties.ReadOnly = True
        Me.ContainerTextEdit.Size = New System.Drawing.Size(99, 20)
        Me.ContainerTextEdit.TabIndex = 21
        '
        'ItemDescTextEdit
        '
        Me.ItemDescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Itemdescription", True))
        Me.ItemDescTextEdit.Location = New System.Drawing.Point(429, 95)
        Me.ItemDescTextEdit.MenuManager = Me.RibbonControl1
        Me.ItemDescTextEdit.Name = "ItemDescTextEdit"
        Me.ItemDescTextEdit.Properties.ReadOnly = True
        Me.ItemDescTextEdit.Size = New System.Drawing.Size(300, 20)
        Me.ItemDescTextEdit.TabIndex = 19
        '
        'QtyTextEdit
        '
        Me.QtyTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Qty", True))
        Me.QtyTextEdit.Location = New System.Drawing.Point(17, 95)
        Me.QtyTextEdit.MenuManager = Me.RibbonControl1
        Me.QtyTextEdit.Name = "QtyTextEdit"
        Me.QtyTextEdit.Properties.Mask.EditMask = "f2"
        Me.QtyTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.QtyTextEdit.Size = New System.Drawing.Size(71, 20)
        Me.QtyTextEdit.TabIndex = 11
        '
        'NeededbyDateEdit
        '
        Me.NeededbyDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Dateneeded", True))
        Me.NeededbyDateEdit.EditValue = Nothing
        Me.NeededbyDateEdit.Location = New System.Drawing.Point(325, 185)
        Me.NeededbyDateEdit.MenuManager = Me.RibbonControl1
        Me.NeededbyDateEdit.Name = "NeededbyDateEdit"
        Me.NeededbyDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NeededbyDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.NeededbyDateEdit.Size = New System.Drawing.Size(94, 20)
        Me.NeededbyDateEdit.TabIndex = 39
        '
        'PurchitemdateDateEdit
        '
        Me.PurchitemdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Createdtime", True))
        Me.PurchitemdateDateEdit.EditValue = Nothing
        Me.PurchitemdateDateEdit.Location = New System.Drawing.Point(98, 50)
        Me.PurchitemdateDateEdit.MenuManager = Me.RibbonControl1
        Me.PurchitemdateDateEdit.Name = "PurchitemdateDateEdit"
        Me.PurchitemdateDateEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[False]
        Me.PurchitemdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PurchitemdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.PurchitemdateDateEdit.Properties.ReadOnly = True
        Me.PurchitemdateDateEdit.Size = New System.Drawing.Size(85, 20)
        Me.PurchitemdateDateEdit.TabIndex = 3
        '
        'PurchItemnumTextEdit
        '
        Me.PurchItemnumTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchaseItem, "Purchaseitemid", True))
        Me.PurchItemnumTextEdit.Location = New System.Drawing.Point(17, 50)
        Me.PurchItemnumTextEdit.MenuManager = Me.RibbonControl1
        Me.PurchItemnumTextEdit.Name = "PurchItemnumTextEdit"
        Me.PurchItemnumTextEdit.Properties.ReadOnly = True
        Me.PurchItemnumTextEdit.Size = New System.Drawing.Size(71, 20)
        Me.PurchItemnumTextEdit.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.WorkPanelHolder)
        Me.PanelControl2.Controls.Add(Me.RibbonControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 316)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(930, 404)
        Me.PanelControl2.TabIndex = 0
        '
        'WorkPanelHolder
        '
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl6)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl7)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl8)
        Me.WorkPanelHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelHolder.Location = New System.Drawing.Point(2, 119)
        Me.WorkPanelHolder.Name = "WorkPanelHolder"
        Me.WorkPanelHolder.Size = New System.Drawing.Size(926, 283)
        Me.WorkPanelHolder.TabIndex = 9
        '
        'RibbonPanelControl6
        '
        Me.RibbonPanelControl6.Controls.Add(Me.grProductCosts)
        Me.RibbonPanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl6.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl6.Name = "RibbonPanelControl6"
        Me.RibbonPanelControl6.Size = New System.Drawing.Size(922, 279)
        Me.RibbonPanelControl6.TabIndex = 1
        '
        'grProductCosts
        '
        Me.grProductCosts.DataSource = Me.bs
        Me.grProductCosts.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.grProductCosts.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grProductCosts.Location = New System.Drawing.Point(2, 2)
        Me.grProductCosts.MainView = Me.GridView8
        Me.grProductCosts.Name = "grProductCosts"
        Me.grProductCosts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.grProductCosts.Size = New System.Drawing.Size(918, 275)
        Me.grProductCosts.TabIndex = 0
        Me.grProductCosts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView8})
        '
        'GridView8
        '
        Me.GridView8.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVUnits, Me.colVUom, Me.colVcost, Me.colWUnits, Me.colWUom, Me.colWcost, Me.GridColumn69, Me.Costtype, Me.GridColumn57, Me.colDatecostchanged, Me.colIsActive})
        Me.GridView8.GridControl = Me.grProductCosts
        Me.GridView8.Name = "GridView8"
        Me.GridView8.OptionsBehavior.Editable = False
        Me.GridView8.OptionsView.ShowGroupPanel = False
        Me.GridView8.OptionsView.ShowIndicator = False
        '
        'colVUnits
        '
        Me.colVUnits.AppearanceCell.Options.UseTextOptions = True
        Me.colVUnits.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVUnits.Caption = "Vol. Units"
        Me.colVUnits.DisplayFormat.FormatString = "n4"
        Me.colVUnits.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVUnits.FieldName = "Volumeunits"
        Me.colVUnits.Name = "colVUnits"
        Me.colVUnits.OptionsColumn.AllowEdit = False
        Me.colVUnits.OptionsColumn.FixedWidth = True
        Me.colVUnits.Visible = True
        Me.colVUnits.VisibleIndex = 0
        Me.colVUnits.Width = 65
        '
        'colVUom
        '
        Me.colVUom.Caption = "Vol. UOM"
        Me.colVUom.FieldName = "Volumeuom"
        Me.colVUom.Name = "colVUom"
        Me.colVUom.OptionsColumn.AllowEdit = False
        Me.colVUom.Visible = True
        Me.colVUom.VisibleIndex = 1
        Me.colVUom.Width = 56
        '
        'colVcost
        '
        Me.colVcost.AppearanceCell.Options.UseTextOptions = True
        Me.colVcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colVcost.Caption = "Vol. Cost "
        Me.colVcost.DisplayFormat.FormatString = "c3"
        Me.colVcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colVcost.FieldName = "Volumestandardcost"
        Me.colVcost.Name = "colVcost"
        Me.colVcost.OptionsColumn.AllowEdit = False
        Me.colVcost.OptionsColumn.FixedWidth = True
        Me.colVcost.Visible = True
        Me.colVcost.VisibleIndex = 2
        Me.colVcost.Width = 65
        '
        'colWUnits
        '
        Me.colWUnits.AppearanceCell.Options.UseTextOptions = True
        Me.colWUnits.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colWUnits.Caption = "Wgt. Units"
        Me.colWUnits.DisplayFormat.FormatString = "n4"
        Me.colWUnits.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colWUnits.FieldName = "Weightunits"
        Me.colWUnits.Name = "colWUnits"
        Me.colWUnits.OptionsColumn.AllowEdit = False
        Me.colWUnits.OptionsColumn.FixedWidth = True
        Me.colWUnits.Visible = True
        Me.colWUnits.VisibleIndex = 3
        Me.colWUnits.Width = 64
        '
        'colWUom
        '
        Me.colWUom.Caption = "Wgt. UOM"
        Me.colWUom.FieldName = "Weightuom"
        Me.colWUom.Name = "colWUom"
        Me.colWUom.OptionsColumn.AllowEdit = False
        Me.colWUom.Visible = True
        Me.colWUom.VisibleIndex = 4
        Me.colWUom.Width = 60
        '
        'colWcost
        '
        Me.colWcost.AppearanceCell.Options.UseTextOptions = True
        Me.colWcost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colWcost.Caption = "Wgt. Cost"
        Me.colWcost.DisplayFormat.FormatString = "c3"
        Me.colWcost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colWcost.FieldName = "Weightstandardcost"
        Me.colWcost.Name = "colWcost"
        Me.colWcost.OptionsColumn.AllowEdit = False
        Me.colWcost.OptionsColumn.FixedWidth = True
        Me.colWcost.Visible = True
        Me.colWcost.VisibleIndex = 5
        Me.colWcost.Width = 64
        '
        'GridColumn69
        '
        Me.GridColumn69.Caption = "Vendor"
        Me.GridColumn69.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.GridColumn69.FieldName = "Vendorid"
        Me.GridColumn69.Name = "GridColumn69"
        Me.GridColumn69.Visible = True
        Me.GridColumn69.VisibleIndex = 6
        Me.GridColumn69.Width = 187
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.bsVendor
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Vendorname"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "Vendorid"
        '
        'Costtype
        '
        Me.Costtype.Caption = "Cost Type"
        Me.Costtype.FieldName = "Costtype"
        Me.Costtype.Name = "Costtype"
        Me.Costtype.OptionsColumn.FixedWidth = True
        Me.Costtype.Visible = True
        Me.Costtype.VisibleIndex = 7
        Me.Costtype.Width = 82
        '
        'GridColumn57
        '
        Me.GridColumn57.Caption = "Notes"
        Me.GridColumn57.FieldName = "Notes"
        Me.GridColumn57.Name = "GridColumn57"
        Me.GridColumn57.OptionsColumn.AllowEdit = False
        Me.GridColumn57.Visible = True
        Me.GridColumn57.VisibleIndex = 8
        Me.GridColumn57.Width = 168
        '
        'colDatecostchanged
        '
        Me.colDatecostchanged.AppearanceCell.Options.UseTextOptions = True
        Me.colDatecostchanged.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colDatecostchanged.Caption = "Eff Date"
        Me.colDatecostchanged.DisplayFormat.FormatString = "d"
        Me.colDatecostchanged.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDatecostchanged.FieldName = "Effectivedate"
        Me.colDatecostchanged.Name = "colDatecostchanged"
        Me.colDatecostchanged.OptionsColumn.AllowEdit = False
        Me.colDatecostchanged.OptionsColumn.FixedWidth = True
        Me.colDatecostchanged.Visible = True
        Me.colDatecostchanged.VisibleIndex = 9
        Me.colDatecostchanged.Width = 65
        '
        'colIsActive
        '
        Me.colIsActive.Caption = "Active"
        Me.colIsActive.FieldName = "Isactive"
        Me.colIsActive.Name = "colIsActive"
        Me.colIsActive.OptionsColumn.FixedWidth = True
        Me.colIsActive.Visible = True
        Me.colIsActive.VisibleIndex = 10
        Me.colIsActive.Width = 40
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Controls.Add(Me.grAvailableInventory)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(922, 279)
        Me.RibbonPanelControl2.TabIndex = 0
        '
        'grAvailableInventory
        '
        Me.grAvailableInventory.DataSource = Me.bsAvailableInventory
        Me.grAvailableInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAvailableInventory.Location = New System.Drawing.Point(2, 2)
        Me.grAvailableInventory.MainView = Me.AvailableInventory
        Me.grAvailableInventory.Name = "grAvailableInventory"
        Me.grAvailableInventory.Size = New System.Drawing.Size(918, 275)
        Me.grAvailableInventory.TabIndex = 8
        Me.grAvailableInventory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AvailableInventory, Me.GridView1})
        '
        'bsAvailableInventory
        '
        Me.bsAvailableInventory.DataSource = GetType(AOS.BusinessObjects.ViewInvItemDetailsCollection)
        '
        'AvailableInventory
        '
        Me.AvailableInventory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.InvItemNum, Me.colProdcutID, Me.colProDesc, Me.colContainer, Me.colStatus, Me.colCustomer, Me.colPlannedShip})
        Me.AvailableInventory.GridControl = Me.grAvailableInventory
        Me.AvailableInventory.Name = "AvailableInventory"
        Me.AvailableInventory.OptionsBehavior.Editable = False
        Me.AvailableInventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.AvailableInventory.OptionsSelection.MultiSelect = True
        Me.AvailableInventory.OptionsView.ShowGroupPanel = False
        Me.AvailableInventory.OptionsView.ShowIndicator = False
        '
        'InvItemNum
        '
        Me.InvItemNum.Caption = "Inv Item #"
        Me.InvItemNum.FieldName = "Invitemnumber"
        Me.InvItemNum.Name = "InvItemNum"
        Me.InvItemNum.Visible = True
        Me.InvItemNum.VisibleIndex = 0
        Me.InvItemNum.Width = 60
        '
        'colProdcutID
        '
        Me.colProdcutID.Caption = "Item ID"
        Me.colProdcutID.FieldName = "Productid"
        Me.colProdcutID.Name = "colProdcutID"
        Me.colProdcutID.OptionsColumn.FixedWidth = True
        Me.colProdcutID.Visible = True
        Me.colProdcutID.VisibleIndex = 1
        Me.colProdcutID.Width = 50
        '
        'colProDesc
        '
        Me.colProDesc.Caption = "Item Description"
        Me.colProDesc.FieldName = "Productdesc"
        Me.colProDesc.Name = "colProDesc"
        Me.colProDesc.Visible = True
        Me.colProDesc.VisibleIndex = 2
        Me.colProDesc.Width = 256
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 82
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Itemstatus"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.FixedWidth = True
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 5
        Me.colStatus.Width = 70
        '
        'colCustomer
        '
        Me.colCustomer.Caption = "Customer"
        Me.colCustomer.FieldName = "Workordercustomer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 4
        Me.colCustomer.Width = 198
        '
        'colPlannedShip
        '
        Me.colPlannedShip.Caption = "Ship Date"
        Me.colPlannedShip.FieldName = "Plannedshipdate"
        Me.colPlannedShip.Name = "colPlannedShip"
        Me.colPlannedShip.OptionsColumn.FixedWidth = True
        Me.colPlannedShip.Visible = True
        Me.colPlannedShip.VisibleIndex = 6
        Me.colPlannedShip.Width = 80
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber, Me.colProductid, Me.colProductdesc, Me.colContainer1, Me.colShipmentnumber, Me.colShipmentdate, Me.colShippeddate, Me.colReceiveddate, Me.colLotnumber, Me.colWarehouselocation, Me.colWarehousenumber, Me.colAllocateddate, Me.colReceivernumber, Me.colItemstatus, Me.colInventoryclass, Me.colClassdesc1, Me.colUnitsremaining1, Me.colReceiverdocument1, Me.colReceiverdocumenttype1, Me.colPonumber1, Me.colPurchasereleasenumber1, Me.colVendorname1, Me.colPodate1, Me.colChangeableponumber1, Me.colAllocateddocument1, Me.colWorkordernumber, Me.colWorkordercustomer1, Me.colShiptocustomer1})
        Me.GridView1.GridControl = Me.grAvailableInventory
        Me.GridView1.Name = "GridView1"
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 0
        '
        'colProductid
        '
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 1
        '
        'colProductdesc
        '
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 2
        '
        'colContainer1
        '
        Me.colContainer1.FieldName = "Container"
        Me.colContainer1.Name = "colContainer1"
        Me.colContainer1.Visible = True
        Me.colContainer1.VisibleIndex = 3
        '
        'colShipmentnumber
        '
        Me.colShipmentnumber.FieldName = "Shipmentnumber"
        Me.colShipmentnumber.Name = "colShipmentnumber"
        Me.colShipmentnumber.Visible = True
        Me.colShipmentnumber.VisibleIndex = 4
        '
        'colShipmentdate
        '
        Me.colShipmentdate.FieldName = "Shipmentdate"
        Me.colShipmentdate.Name = "colShipmentdate"
        Me.colShipmentdate.Visible = True
        Me.colShipmentdate.VisibleIndex = 5
        '
        'colShippeddate
        '
        Me.colShippeddate.FieldName = "Shippeddate"
        Me.colShippeddate.Name = "colShippeddate"
        Me.colShippeddate.Visible = True
        Me.colShippeddate.VisibleIndex = 6
        '
        'colReceiveddate
        '
        Me.colReceiveddate.FieldName = "Receiveddate"
        Me.colReceiveddate.Name = "colReceiveddate"
        Me.colReceiveddate.Visible = True
        Me.colReceiveddate.VisibleIndex = 7
        '
        'colLotnumber
        '
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 8
        '
        'colWarehouselocation
        '
        Me.colWarehouselocation.FieldName = "Warehouselocation"
        Me.colWarehouselocation.Name = "colWarehouselocation"
        Me.colWarehouselocation.Visible = True
        Me.colWarehouselocation.VisibleIndex = 9
        '
        'colWarehousenumber
        '
        Me.colWarehousenumber.FieldName = "Warehousenumber"
        Me.colWarehousenumber.Name = "colWarehousenumber"
        Me.colWarehousenumber.Visible = True
        Me.colWarehousenumber.VisibleIndex = 10
        '
        'colAllocateddate
        '
        Me.colAllocateddate.FieldName = "Allocateddate"
        Me.colAllocateddate.Name = "colAllocateddate"
        Me.colAllocateddate.Visible = True
        Me.colAllocateddate.VisibleIndex = 11
        '
        'colReceivernumber
        '
        Me.colReceivernumber.FieldName = "Receivernumber"
        Me.colReceivernumber.Name = "colReceivernumber"
        Me.colReceivernumber.Visible = True
        Me.colReceivernumber.VisibleIndex = 12
        '
        'colItemstatus
        '
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 13
        '
        'colInventoryclass
        '
        Me.colInventoryclass.FieldName = "Inventoryclass"
        Me.colInventoryclass.Name = "colInventoryclass"
        Me.colInventoryclass.Visible = True
        Me.colInventoryclass.VisibleIndex = 14
        '
        'colClassdesc1
        '
        Me.colClassdesc1.FieldName = "Classdesc"
        Me.colClassdesc1.Name = "colClassdesc1"
        Me.colClassdesc1.Visible = True
        Me.colClassdesc1.VisibleIndex = 15
        '
        'colUnitsremaining1
        '
        Me.colUnitsremaining1.FieldName = "Unitsremaining"
        Me.colUnitsremaining1.Name = "colUnitsremaining1"
        Me.colUnitsremaining1.Visible = True
        Me.colUnitsremaining1.VisibleIndex = 16
        '
        'colReceiverdocument1
        '
        Me.colReceiverdocument1.FieldName = "Receiverdocument"
        Me.colReceiverdocument1.Name = "colReceiverdocument1"
        Me.colReceiverdocument1.Visible = True
        Me.colReceiverdocument1.VisibleIndex = 17
        '
        'colReceiverdocumenttype1
        '
        Me.colReceiverdocumenttype1.FieldName = "Receiverdocumenttype"
        Me.colReceiverdocumenttype1.Name = "colReceiverdocumenttype1"
        Me.colReceiverdocumenttype1.Visible = True
        Me.colReceiverdocumenttype1.VisibleIndex = 18
        '
        'colPonumber1
        '
        Me.colPonumber1.FieldName = "Ponumber"
        Me.colPonumber1.Name = "colPonumber1"
        Me.colPonumber1.Visible = True
        Me.colPonumber1.VisibleIndex = 19
        '
        'colPurchasereleasenumber1
        '
        Me.colPurchasereleasenumber1.FieldName = "Purchasereleasenumber"
        Me.colPurchasereleasenumber1.Name = "colPurchasereleasenumber1"
        Me.colPurchasereleasenumber1.Visible = True
        Me.colPurchasereleasenumber1.VisibleIndex = 20
        '
        'colVendorname1
        '
        Me.colVendorname1.FieldName = "Vendorname"
        Me.colVendorname1.Name = "colVendorname1"
        Me.colVendorname1.Visible = True
        Me.colVendorname1.VisibleIndex = 21
        '
        'colPodate1
        '
        Me.colPodate1.FieldName = "Podate"
        Me.colPodate1.Name = "colPodate1"
        Me.colPodate1.Visible = True
        Me.colPodate1.VisibleIndex = 22
        '
        'colChangeableponumber1
        '
        Me.colChangeableponumber1.FieldName = "Changeableponumber"
        Me.colChangeableponumber1.Name = "colChangeableponumber1"
        Me.colChangeableponumber1.Visible = True
        Me.colChangeableponumber1.VisibleIndex = 23
        '
        'colAllocateddocument1
        '
        Me.colAllocateddocument1.FieldName = "Allocateddocument"
        Me.colAllocateddocument1.Name = "colAllocateddocument1"
        Me.colAllocateddocument1.Visible = True
        Me.colAllocateddocument1.VisibleIndex = 24
        '
        'colWorkordernumber
        '
        Me.colWorkordernumber.FieldName = "Workordernumber"
        Me.colWorkordernumber.Name = "colWorkordernumber"
        Me.colWorkordernumber.Visible = True
        Me.colWorkordernumber.VisibleIndex = 25
        '
        'colWorkordercustomer1
        '
        Me.colWorkordercustomer1.FieldName = "Workordercustomer"
        Me.colWorkordercustomer1.Name = "colWorkordercustomer1"
        Me.colWorkordercustomer1.Visible = True
        Me.colWorkordercustomer1.VisibleIndex = 26
        '
        'colShiptocustomer1
        '
        Me.colShiptocustomer1.FieldName = "Shiptocustomer"
        Me.colShiptocustomer1.Name = "colShiptocustomer1"
        Me.colShiptocustomer1.Visible = True
        Me.colShiptocustomer1.VisibleIndex = 27
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.grAllocatedInventory)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(922, 279)
        Me.RibbonPanelControl3.TabIndex = 1
        '
        'grAllocatedInventory
        '
        Me.grAllocatedInventory.DataSource = Me.bsAllocatedInventory
        Me.grAllocatedInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAllocatedInventory.Location = New System.Drawing.Point(2, 2)
        Me.grAllocatedInventory.MainView = Me.gvAllocatedInventory
        Me.grAllocatedInventory.Name = "grAllocatedInventory"
        Me.grAllocatedInventory.Size = New System.Drawing.Size(918, 275)
        Me.grAllocatedInventory.TabIndex = 8
        Me.grAllocatedInventory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvAllocatedInventory, Me.GridView4})
        '
        'gvAllocatedInventory
        '
        Me.gvAllocatedInventory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn112, Me.GridColumn111, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.gvAllocatedInventory.GridControl = Me.grAllocatedInventory
        Me.gvAllocatedInventory.Name = "gvAllocatedInventory"
        Me.gvAllocatedInventory.OptionsBehavior.Editable = False
        Me.gvAllocatedInventory.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.gvAllocatedInventory.OptionsSelection.MultiSelect = True
        Me.gvAllocatedInventory.OptionsView.ShowGroupPanel = False
        Me.gvAllocatedInventory.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Inv Item #"
        Me.GridColumn1.FieldName = "Invitemnumber"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 67
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Item ID"
        Me.GridColumn2.FieldName = "Productid"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 50
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Item Description"
        Me.GridColumn3.FieldName = "Productdesc"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 180
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Container"
        Me.GridColumn4.FieldName = "Container"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 80
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Status"
        Me.GridColumn5.FieldName = "Itemstatus"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.FixedWidth = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 8
        Me.GridColumn5.Width = 70
        '
        'GridColumn112
        '
        Me.GridColumn112.Caption = "Alloc Doc #"
        Me.GridColumn112.FieldName = "Allocateddocument"
        Me.GridColumn112.Name = "GridColumn112"
        Me.GridColumn112.Visible = True
        Me.GridColumn112.VisibleIndex = 5
        Me.GridColumn112.Width = 66
        '
        'GridColumn111
        '
        Me.GridColumn111.Caption = "Alloc Type"
        Me.GridColumn111.FieldName = "Allocatedtype"
        Me.GridColumn111.Name = "GridColumn111"
        Me.GridColumn111.Visible = True
        Me.GridColumn111.VisibleIndex = 6
        Me.GridColumn111.Width = 80
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Work Ord #"
        Me.GridColumn6.FieldName = "Workordernumber"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Customer"
        Me.GridColumn7.FieldName = "Workordercustomer"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 168
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Ship Date"
        Me.GridColumn8.FieldName = "Shippeddate"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.FixedWidth = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 9
        Me.GridColumn8.Width = 80
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.grAllocatedInventory
        Me.GridView4.Name = "GridView4"
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Controls.Add(Me.GridControl2)
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(922, 279)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsAllocatedInventory
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 2)
        Me.GridControl2.MainView = Me.GridView6
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(918, 275)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6, Me.GridView7})
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn45, Me.GridColumn46, Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn50, Me.GridColumn51, Me.GridColumn52})
        Me.GridView6.GridControl = Me.GridControl2
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'GridColumn45
        '
        Me.GridColumn45.Caption = "Inv Item #"
        Me.GridColumn45.FieldName = "Invitemnumber"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 0
        Me.GridColumn45.Width = 70
        '
        'GridColumn46
        '
        Me.GridColumn46.Caption = "Item ID"
        Me.GridColumn46.FieldName = "Productid"
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.Visible = True
        Me.GridColumn46.VisibleIndex = 1
        Me.GridColumn46.Width = 65
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "Item Description"
        Me.GridColumn47.FieldName = "Productdesc"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 2
        Me.GridColumn47.Width = 280
        '
        'GridColumn48
        '
        Me.GridColumn48.Caption = "Container"
        Me.GridColumn48.FieldName = "Container"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.Visible = True
        Me.GridColumn48.VisibleIndex = 3
        Me.GridColumn48.Width = 80
        '
        'GridColumn49
        '
        Me.GridColumn49.Caption = "Status"
        Me.GridColumn49.FieldName = "Itemstatus"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.OptionsColumn.FixedWidth = True
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 6
        Me.GridColumn49.Width = 70
        '
        'GridColumn50
        '
        Me.GridColumn50.Caption = "Work Ord #"
        Me.GridColumn50.FieldName = "Workordernumber"
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 4
        '
        'GridColumn51
        '
        Me.GridColumn51.Caption = "Customer"
        Me.GridColumn51.FieldName = "Workordercustomer"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.Visible = True
        Me.GridColumn51.VisibleIndex = 5
        Me.GridColumn51.Width = 172
        '
        'GridColumn52
        '
        Me.GridColumn52.Caption = "Ship Date"
        Me.GridColumn52.FieldName = "Plannedshipdate"
        Me.GridColumn52.Name = "GridColumn52"
        Me.GridColumn52.OptionsColumn.FixedWidth = True
        Me.GridColumn52.Visible = True
        Me.GridColumn52.VisibleIndex = 7
        Me.GridColumn52.Width = 80
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.GridControl2
        Me.GridView7.Name = "GridView7"
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Controls.Add(Me.gpProductionOrders)
        Me.RibbonPanelControl5.Controls.Add(Me.gpCanceledProductionOrders)
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(922, 279)
        Me.RibbonPanelControl5.TabIndex = 10
        '
        'gpProductionOrders
        '
        Me.gpProductionOrders.Controls.Add(Me.grProductionOrders)
        Me.gpProductionOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpProductionOrders.Location = New System.Drawing.Point(2, 2)
        Me.gpProductionOrders.Name = "gpProductionOrders"
        Me.gpProductionOrders.Size = New System.Drawing.Size(918, 160)
        Me.gpProductionOrders.TabIndex = 0
        Me.gpProductionOrders.Text = "Production Orders"
        '
        'grProductionOrders
        '
        Me.grProductionOrders.DataSource = Me.bsProdOrders
        Me.grProductionOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grProductionOrders.Location = New System.Drawing.Point(2, 22)
        Me.grProductionOrders.MainView = Me.grvProductionOrders
        Me.grProductionOrders.Name = "grProductionOrders"
        Me.grProductionOrders.Size = New System.Drawing.Size(914, 136)
        Me.grProductionOrders.TabIndex = 0
        Me.grProductionOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvProductionOrders, Me.GridView5, Me.GridView2})
        '
        'bsProdOrders
        '
        Me.bsProdOrders.DataSource = GetType(AOS.BusinessObjects.ViewProdOrderDataCollection)
        '
        'grvProductionOrders
        '
        Me.grvProductionOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn53, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn54, Me.GridColumn13, Me.GridColumn14, Me.GridColumn55, Me.GridColumn15, Me.GridColumn16, Me.colProdNeededby, Me.colProdOrderStatus})
        Me.grvProductionOrders.GridControl = Me.grProductionOrders
        Me.grvProductionOrders.Name = "grvProductionOrders"
        Me.grvProductionOrders.OptionsBehavior.Editable = False
        Me.grvProductionOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvProductionOrders.OptionsSelection.MultiSelect = True
        Me.grvProductionOrders.OptionsView.ShowGroupPanel = False
        Me.grvProductionOrders.OptionsView.ShowIndicator = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Ord #"
        Me.GridColumn9.FieldName = "Prodordernum"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 45
        '
        'GridColumn53
        '
        Me.GridColumn53.Caption = "Ord Date"
        Me.GridColumn53.FieldName = "Prodorderdate"
        Me.GridColumn53.Name = "GridColumn53"
        Me.GridColumn53.OptionsColumn.FixedWidth = True
        Me.GridColumn53.Visible = True
        Me.GridColumn53.VisibleIndex = 1
        Me.GridColumn53.Width = 70
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Item ID"
        Me.GridColumn10.FieldName = "Productid"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 48
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Item Description"
        Me.GridColumn11.FieldName = "Productdesc"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 3
        Me.GridColumn11.Width = 183
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Container"
        Me.GridColumn12.FieldName = "Container"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 5
        Me.GridColumn12.Width = 57
        '
        'GridColumn54
        '
        Me.GridColumn54.Caption = "APIS #"
        Me.GridColumn54.FieldName = "Apisnum"
        Me.GridColumn54.Name = "GridColumn54"
        Me.GridColumn54.Visible = True
        Me.GridColumn54.VisibleIndex = 6
        Me.GridColumn54.Width = 52
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Lot #"
        Me.GridColumn13.FieldName = "Lotnumber"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 7
        Me.GridColumn13.Width = 52
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Qty"
        Me.GridColumn14.FieldName = "Productqty"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 4
        Me.GridColumn14.Width = 37
        '
        'GridColumn55
        '
        Me.GridColumn55.Caption = "UOM"
        Me.GridColumn55.FieldName = "Uom"
        Me.GridColumn55.Name = "GridColumn55"
        Me.GridColumn55.OptionsColumn.FixedWidth = True
        Me.GridColumn55.Visible = True
        Me.GridColumn55.VisibleIndex = 9
        Me.GridColumn55.Width = 35
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Customer"
        Me.GridColumn15.FieldName = "Workordercustomer"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 10
        Me.GridColumn15.Width = 143
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Complete"
        Me.GridColumn16.FieldName = "Iscomplete"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.OptionsColumn.FixedWidth = True
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 12
        Me.GridColumn16.Width = 60
        '
        'colProdNeededby
        '
        Me.colProdNeededby.Caption = "Needed By"
        Me.colProdNeededby.FieldName = "Neededby"
        Me.colProdNeededby.Name = "colProdNeededby"
        Me.colProdNeededby.OptionsColumn.FixedWidth = True
        Me.colProdNeededby.Visible = True
        Me.colProdNeededby.VisibleIndex = 8
        Me.colProdNeededby.Width = 70
        '
        'colProdOrderStatus
        '
        Me.colProdOrderStatus.Caption = "Status"
        Me.colProdOrderStatus.FieldName = "Orderstatus"
        Me.colProdOrderStatus.Name = "colProdOrderStatus"
        Me.colProdOrderStatus.OptionsColumn.FixedWidth = True
        Me.colProdOrderStatus.Visible = True
        Me.colProdOrderStatus.VisibleIndex = 11
        Me.colProdOrderStatus.Width = 60
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn40, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn44})
        Me.GridView5.GridControl = Me.grProductionOrders
        Me.GridView5.Name = "GridView5"
        '
        'GridColumn17
        '
        Me.GridColumn17.FieldName = "Invitemnumber"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 0
        '
        'GridColumn18
        '
        Me.GridColumn18.FieldName = "Productid"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 1
        '
        'GridColumn19
        '
        Me.GridColumn19.FieldName = "Productdesc"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        '
        'GridColumn20
        '
        Me.GridColumn20.FieldName = "Container"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 3
        '
        'GridColumn21
        '
        Me.GridColumn21.FieldName = "Shipmentnumber"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 4
        '
        'GridColumn22
        '
        Me.GridColumn22.FieldName = "Shipmentdate"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 5
        '
        'GridColumn23
        '
        Me.GridColumn23.FieldName = "Shippeddate"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 6
        '
        'GridColumn24
        '
        Me.GridColumn24.FieldName = "Receiveddate"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 7
        '
        'GridColumn25
        '
        Me.GridColumn25.FieldName = "Lotnumber"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 8
        '
        'GridColumn26
        '
        Me.GridColumn26.FieldName = "Warehouselocation"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 9
        '
        'GridColumn27
        '
        Me.GridColumn27.FieldName = "Warehousenumber"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 10
        '
        'GridColumn28
        '
        Me.GridColumn28.FieldName = "Allocateddate"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 11
        '
        'GridColumn29
        '
        Me.GridColumn29.FieldName = "Receivernumber"
        Me.GridColumn29.Name = "GridColumn29"
        Me.GridColumn29.Visible = True
        Me.GridColumn29.VisibleIndex = 12
        '
        'GridColumn30
        '
        Me.GridColumn30.FieldName = "Itemstatus"
        Me.GridColumn30.Name = "GridColumn30"
        Me.GridColumn30.Visible = True
        Me.GridColumn30.VisibleIndex = 13
        '
        'GridColumn31
        '
        Me.GridColumn31.FieldName = "Inventoryclass"
        Me.GridColumn31.Name = "GridColumn31"
        Me.GridColumn31.Visible = True
        Me.GridColumn31.VisibleIndex = 14
        '
        'GridColumn32
        '
        Me.GridColumn32.FieldName = "Classdesc"
        Me.GridColumn32.Name = "GridColumn32"
        Me.GridColumn32.Visible = True
        Me.GridColumn32.VisibleIndex = 15
        '
        'GridColumn33
        '
        Me.GridColumn33.FieldName = "Unitsremaining"
        Me.GridColumn33.Name = "GridColumn33"
        Me.GridColumn33.Visible = True
        Me.GridColumn33.VisibleIndex = 16
        '
        'GridColumn34
        '
        Me.GridColumn34.FieldName = "Receiverdocument"
        Me.GridColumn34.Name = "GridColumn34"
        Me.GridColumn34.Visible = True
        Me.GridColumn34.VisibleIndex = 17
        '
        'GridColumn35
        '
        Me.GridColumn35.FieldName = "Receiverdocumenttype"
        Me.GridColumn35.Name = "GridColumn35"
        Me.GridColumn35.Visible = True
        Me.GridColumn35.VisibleIndex = 18
        '
        'GridColumn36
        '
        Me.GridColumn36.FieldName = "Ponumber"
        Me.GridColumn36.Name = "GridColumn36"
        Me.GridColumn36.Visible = True
        Me.GridColumn36.VisibleIndex = 19
        '
        'GridColumn37
        '
        Me.GridColumn37.FieldName = "Purchasereleasenumber"
        Me.GridColumn37.Name = "GridColumn37"
        Me.GridColumn37.Visible = True
        Me.GridColumn37.VisibleIndex = 20
        '
        'GridColumn38
        '
        Me.GridColumn38.FieldName = "Vendorname"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 21
        '
        'GridColumn39
        '
        Me.GridColumn39.FieldName = "Podate"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 22
        '
        'GridColumn40
        '
        Me.GridColumn40.FieldName = "Changeableponumber"
        Me.GridColumn40.Name = "GridColumn40"
        Me.GridColumn40.Visible = True
        Me.GridColumn40.VisibleIndex = 23
        '
        'GridColumn41
        '
        Me.GridColumn41.FieldName = "Allocateddocument"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 24
        '
        'GridColumn42
        '
        Me.GridColumn42.FieldName = "Workordernumber"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 25
        '
        'GridColumn43
        '
        Me.GridColumn43.FieldName = "Workordercustomer"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 26
        '
        'GridColumn44
        '
        Me.GridColumn44.FieldName = "Shiptocustomer"
        Me.GridColumn44.Name = "GridColumn44"
        Me.GridColumn44.Visible = True
        Me.GridColumn44.VisibleIndex = 27
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grProductionOrders
        Me.GridView2.Name = "GridView2"
        '
        'gpCanceledProductionOrders
        '
        Me.gpCanceledProductionOrders.Controls.Add(Me.grCanceledProductionOrders)
        Me.gpCanceledProductionOrders.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpCanceledProductionOrders.Location = New System.Drawing.Point(2, 162)
        Me.gpCanceledProductionOrders.Name = "gpCanceledProductionOrders"
        Me.gpCanceledProductionOrders.Size = New System.Drawing.Size(918, 115)
        Me.gpCanceledProductionOrders.TabIndex = 1
        Me.gpCanceledProductionOrders.Text = "Cancelled Production Orders"
        '
        'grCanceledProductionOrders
        '
        Me.grCanceledProductionOrders.DataSource = Me.bsCanceledProdOrders
        Me.grCanceledProductionOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCanceledProductionOrders.Location = New System.Drawing.Point(2, 22)
        Me.grCanceledProductionOrders.MainView = Me.grvCanceledProductionOrders
        Me.grCanceledProductionOrders.Name = "grCanceledProductionOrders"
        Me.grCanceledProductionOrders.Size = New System.Drawing.Size(914, 91)
        Me.grCanceledProductionOrders.TabIndex = 0
        Me.grCanceledProductionOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCanceledProductionOrders, Me.GridView3})
        '
        'bsCanceledProdOrders
        '
        Me.bsCanceledProdOrders.DataSource = GetType(AOS.BusinessObjects.ViewProdOrderDataCollection)
        '
        'grvCanceledProductionOrders
        '
        Me.grvCanceledProductionOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn56, Me.GridColumn70, Me.GridColumn71, Me.GridColumn72, Me.GridColumn73, Me.GridColumn74, Me.GridColumn75, Me.GridColumn76, Me.GridColumn77, Me.GridColumn78, Me.GridColumn79, Me.GridColumn80, Me.GridColumn81})
        Me.grvCanceledProductionOrders.GridControl = Me.grCanceledProductionOrders
        Me.grvCanceledProductionOrders.Name = "grvCanceledProductionOrders"
        Me.grvCanceledProductionOrders.OptionsBehavior.Editable = False
        Me.grvCanceledProductionOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvCanceledProductionOrders.OptionsSelection.MultiSelect = True
        Me.grvCanceledProductionOrders.OptionsView.ShowGroupPanel = False
        Me.grvCanceledProductionOrders.OptionsView.ShowIndicator = False
        '
        'GridColumn56
        '
        Me.GridColumn56.Caption = "Ord #"
        Me.GridColumn56.FieldName = "Prodordernum"
        Me.GridColumn56.Name = "GridColumn56"
        Me.GridColumn56.Visible = True
        Me.GridColumn56.VisibleIndex = 0
        Me.GridColumn56.Width = 45
        '
        'GridColumn70
        '
        Me.GridColumn70.Caption = "Ord Date"
        Me.GridColumn70.FieldName = "Prodorderdate"
        Me.GridColumn70.Name = "GridColumn70"
        Me.GridColumn70.OptionsColumn.FixedWidth = True
        Me.GridColumn70.Visible = True
        Me.GridColumn70.VisibleIndex = 1
        Me.GridColumn70.Width = 70
        '
        'GridColumn71
        '
        Me.GridColumn71.Caption = "Item ID"
        Me.GridColumn71.FieldName = "Productid"
        Me.GridColumn71.Name = "GridColumn71"
        Me.GridColumn71.Visible = True
        Me.GridColumn71.VisibleIndex = 2
        Me.GridColumn71.Width = 51
        '
        'GridColumn72
        '
        Me.GridColumn72.Caption = "Item Description"
        Me.GridColumn72.FieldName = "Productdesc"
        Me.GridColumn72.Name = "GridColumn72"
        Me.GridColumn72.Visible = True
        Me.GridColumn72.VisibleIndex = 3
        Me.GridColumn72.Width = 189
        '
        'GridColumn73
        '
        Me.GridColumn73.Caption = "Container"
        Me.GridColumn73.FieldName = "Container"
        Me.GridColumn73.Name = "GridColumn73"
        Me.GridColumn73.Visible = True
        Me.GridColumn73.VisibleIndex = 5
        Me.GridColumn73.Width = 60
        '
        'GridColumn74
        '
        Me.GridColumn74.Caption = "APIS #"
        Me.GridColumn74.FieldName = "Apisnum"
        Me.GridColumn74.Name = "GridColumn74"
        Me.GridColumn74.Visible = True
        Me.GridColumn74.VisibleIndex = 6
        Me.GridColumn74.Width = 55
        '
        'GridColumn75
        '
        Me.GridColumn75.Caption = "Lot #"
        Me.GridColumn75.FieldName = "Lotnumber"
        Me.GridColumn75.Name = "GridColumn75"
        Me.GridColumn75.Visible = True
        Me.GridColumn75.VisibleIndex = 7
        Me.GridColumn75.Width = 55
        '
        'GridColumn76
        '
        Me.GridColumn76.Caption = "Qty"
        Me.GridColumn76.FieldName = "Productqty"
        Me.GridColumn76.Name = "GridColumn76"
        Me.GridColumn76.Visible = True
        Me.GridColumn76.VisibleIndex = 4
        Me.GridColumn76.Width = 40
        '
        'GridColumn77
        '
        Me.GridColumn77.Caption = "UOM"
        Me.GridColumn77.FieldName = "Uom"
        Me.GridColumn77.Name = "GridColumn77"
        Me.GridColumn77.OptionsColumn.FixedWidth = True
        Me.GridColumn77.Visible = True
        Me.GridColumn77.VisibleIndex = 9
        Me.GridColumn77.Width = 35
        '
        'GridColumn78
        '
        Me.GridColumn78.Caption = "Customer"
        Me.GridColumn78.FieldName = "Workordercustomer"
        Me.GridColumn78.Name = "GridColumn78"
        Me.GridColumn78.Visible = True
        Me.GridColumn78.VisibleIndex = 10
        Me.GridColumn78.Width = 147
        '
        'GridColumn79
        '
        Me.GridColumn79.Caption = "Complete"
        Me.GridColumn79.FieldName = "Iscomplete"
        Me.GridColumn79.Name = "GridColumn79"
        Me.GridColumn79.OptionsColumn.FixedWidth = True
        Me.GridColumn79.Visible = True
        Me.GridColumn79.VisibleIndex = 12
        Me.GridColumn79.Width = 60
        '
        'GridColumn80
        '
        Me.GridColumn80.Caption = "Needed By"
        Me.GridColumn80.FieldName = "Neededby"
        Me.GridColumn80.Name = "GridColumn80"
        Me.GridColumn80.OptionsColumn.FixedWidth = True
        Me.GridColumn80.Visible = True
        Me.GridColumn80.VisibleIndex = 8
        Me.GridColumn80.Width = 70
        '
        'GridColumn81
        '
        Me.GridColumn81.Caption = "Status"
        Me.GridColumn81.FieldName = "Orderstatus"
        Me.GridColumn81.Name = "GridColumn81"
        Me.GridColumn81.OptionsColumn.FixedWidth = True
        Me.GridColumn81.Visible = True
        Me.GridColumn81.VisibleIndex = 11
        Me.GridColumn81.Width = 60
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn82, Me.GridColumn83, Me.GridColumn84, Me.GridColumn85, Me.GridColumn86, Me.GridColumn87, Me.GridColumn88, Me.GridColumn89, Me.GridColumn90, Me.GridColumn91, Me.GridColumn92, Me.GridColumn93, Me.GridColumn94, Me.GridColumn95, Me.GridColumn96, Me.GridColumn97, Me.GridColumn98, Me.GridColumn99, Me.GridColumn100, Me.GridColumn101, Me.GridColumn102, Me.GridColumn103, Me.GridColumn104, Me.GridColumn105, Me.GridColumn106, Me.GridColumn107, Me.GridColumn108, Me.GridColumn109})
        Me.GridView3.GridControl = Me.grCanceledProductionOrders
        Me.GridView3.Name = "GridView3"
        '
        'GridColumn82
        '
        Me.GridColumn82.FieldName = "Invitemnumber"
        Me.GridColumn82.Name = "GridColumn82"
        Me.GridColumn82.Visible = True
        Me.GridColumn82.VisibleIndex = 0
        '
        'GridColumn83
        '
        Me.GridColumn83.FieldName = "Productid"
        Me.GridColumn83.Name = "GridColumn83"
        Me.GridColumn83.Visible = True
        Me.GridColumn83.VisibleIndex = 1
        '
        'GridColumn84
        '
        Me.GridColumn84.FieldName = "Productdesc"
        Me.GridColumn84.Name = "GridColumn84"
        Me.GridColumn84.Visible = True
        Me.GridColumn84.VisibleIndex = 2
        '
        'GridColumn85
        '
        Me.GridColumn85.FieldName = "Container"
        Me.GridColumn85.Name = "GridColumn85"
        Me.GridColumn85.Visible = True
        Me.GridColumn85.VisibleIndex = 3
        '
        'GridColumn86
        '
        Me.GridColumn86.FieldName = "Shipmentnumber"
        Me.GridColumn86.Name = "GridColumn86"
        Me.GridColumn86.Visible = True
        Me.GridColumn86.VisibleIndex = 4
        '
        'GridColumn87
        '
        Me.GridColumn87.FieldName = "Shipmentdate"
        Me.GridColumn87.Name = "GridColumn87"
        Me.GridColumn87.Visible = True
        Me.GridColumn87.VisibleIndex = 5
        '
        'GridColumn88
        '
        Me.GridColumn88.FieldName = "Shippeddate"
        Me.GridColumn88.Name = "GridColumn88"
        Me.GridColumn88.Visible = True
        Me.GridColumn88.VisibleIndex = 6
        '
        'GridColumn89
        '
        Me.GridColumn89.FieldName = "Receiveddate"
        Me.GridColumn89.Name = "GridColumn89"
        Me.GridColumn89.Visible = True
        Me.GridColumn89.VisibleIndex = 7
        '
        'GridColumn90
        '
        Me.GridColumn90.FieldName = "Lotnumber"
        Me.GridColumn90.Name = "GridColumn90"
        Me.GridColumn90.Visible = True
        Me.GridColumn90.VisibleIndex = 8
        '
        'GridColumn91
        '
        Me.GridColumn91.FieldName = "Warehouselocation"
        Me.GridColumn91.Name = "GridColumn91"
        Me.GridColumn91.Visible = True
        Me.GridColumn91.VisibleIndex = 9
        '
        'GridColumn92
        '
        Me.GridColumn92.FieldName = "Warehousenumber"
        Me.GridColumn92.Name = "GridColumn92"
        Me.GridColumn92.Visible = True
        Me.GridColumn92.VisibleIndex = 10
        '
        'GridColumn93
        '
        Me.GridColumn93.FieldName = "Allocateddate"
        Me.GridColumn93.Name = "GridColumn93"
        Me.GridColumn93.Visible = True
        Me.GridColumn93.VisibleIndex = 11
        '
        'GridColumn94
        '
        Me.GridColumn94.FieldName = "Receivernumber"
        Me.GridColumn94.Name = "GridColumn94"
        Me.GridColumn94.Visible = True
        Me.GridColumn94.VisibleIndex = 12
        '
        'GridColumn95
        '
        Me.GridColumn95.FieldName = "Itemstatus"
        Me.GridColumn95.Name = "GridColumn95"
        Me.GridColumn95.Visible = True
        Me.GridColumn95.VisibleIndex = 13
        '
        'GridColumn96
        '
        Me.GridColumn96.FieldName = "Inventoryclass"
        Me.GridColumn96.Name = "GridColumn96"
        Me.GridColumn96.Visible = True
        Me.GridColumn96.VisibleIndex = 14
        '
        'GridColumn97
        '
        Me.GridColumn97.FieldName = "Classdesc"
        Me.GridColumn97.Name = "GridColumn97"
        Me.GridColumn97.Visible = True
        Me.GridColumn97.VisibleIndex = 15
        '
        'GridColumn98
        '
        Me.GridColumn98.FieldName = "Unitsremaining"
        Me.GridColumn98.Name = "GridColumn98"
        Me.GridColumn98.Visible = True
        Me.GridColumn98.VisibleIndex = 16
        '
        'GridColumn99
        '
        Me.GridColumn99.FieldName = "Receiverdocument"
        Me.GridColumn99.Name = "GridColumn99"
        Me.GridColumn99.Visible = True
        Me.GridColumn99.VisibleIndex = 17
        '
        'GridColumn100
        '
        Me.GridColumn100.FieldName = "Receiverdocumenttype"
        Me.GridColumn100.Name = "GridColumn100"
        Me.GridColumn100.Visible = True
        Me.GridColumn100.VisibleIndex = 18
        '
        'GridColumn101
        '
        Me.GridColumn101.FieldName = "Ponumber"
        Me.GridColumn101.Name = "GridColumn101"
        Me.GridColumn101.Visible = True
        Me.GridColumn101.VisibleIndex = 19
        '
        'GridColumn102
        '
        Me.GridColumn102.FieldName = "Purchasereleasenumber"
        Me.GridColumn102.Name = "GridColumn102"
        Me.GridColumn102.Visible = True
        Me.GridColumn102.VisibleIndex = 20
        '
        'GridColumn103
        '
        Me.GridColumn103.FieldName = "Vendorname"
        Me.GridColumn103.Name = "GridColumn103"
        Me.GridColumn103.Visible = True
        Me.GridColumn103.VisibleIndex = 21
        '
        'GridColumn104
        '
        Me.GridColumn104.FieldName = "Podate"
        Me.GridColumn104.Name = "GridColumn104"
        Me.GridColumn104.Visible = True
        Me.GridColumn104.VisibleIndex = 22
        '
        'GridColumn105
        '
        Me.GridColumn105.FieldName = "Changeableponumber"
        Me.GridColumn105.Name = "GridColumn105"
        Me.GridColumn105.Visible = True
        Me.GridColumn105.VisibleIndex = 23
        '
        'GridColumn106
        '
        Me.GridColumn106.FieldName = "Allocateddocument"
        Me.GridColumn106.Name = "GridColumn106"
        Me.GridColumn106.Visible = True
        Me.GridColumn106.VisibleIndex = 24
        '
        'GridColumn107
        '
        Me.GridColumn107.FieldName = "Workordernumber"
        Me.GridColumn107.Name = "GridColumn107"
        Me.GridColumn107.Visible = True
        Me.GridColumn107.VisibleIndex = 25
        '
        'GridColumn108
        '
        Me.GridColumn108.FieldName = "Workordercustomer"
        Me.GridColumn108.Name = "GridColumn108"
        Me.GridColumn108.Visible = True
        Me.GridColumn108.VisibleIndex = 26
        '
        'GridColumn109
        '
        Me.GridColumn109.FieldName = "Shiptocustomer"
        Me.GridColumn109.Name = "GridColumn109"
        Me.GridColumn109.Visible = True
        Me.GridColumn109.VisibleIndex = 27
        '
        'RibbonPanelControl7
        '
        Me.RibbonPanelControl7.Controls.Add(Me.grInventoryItems)
        Me.RibbonPanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl7.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl7.Name = "RibbonPanelControl7"
        Me.RibbonPanelControl7.Size = New System.Drawing.Size(922, 279)
        Me.RibbonPanelControl7.TabIndex = 1
        '
        'grInventoryItems
        '
        Me.grInventoryItems.DataSource = Me.bsInventoryItems
        Me.grInventoryItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInventoryItems.Location = New System.Drawing.Point(2, 2)
        Me.grInventoryItems.LookAndFeel.SkinName = "Money Twins"
        Me.grInventoryItems.MainView = Me.grvInventoryItems
        Me.grInventoryItems.Name = "grInventoryItems"
        Me.grInventoryItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.grInventoryItems.Size = New System.Drawing.Size(918, 275)
        Me.grInventoryItems.TabIndex = 5
        Me.grInventoryItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvInventoryItems})
        '
        'bsInventoryItems
        '
        Me.bsInventoryItems.DataSource = GetType(AOS.BusinessObjects.ViewInvItemListCollection)
        '
        'grvInventoryItems
        '
        Me.grvInventoryItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn58, Me.SourceDoc, Me.GridColumn59, Me.GridColumn60, Me.GridColumn61, Me.GridColumn62, Me.GridColumn63, Me.GridColumn64, Me.GridColumn65, Me.GridColumn66, Me.GridColumn67, Me.GridColumn68})
        Me.grvInventoryItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvInventoryItems.GridControl = Me.grInventoryItems
        Me.grvInventoryItems.Name = "grvInventoryItems"
        Me.grvInventoryItems.OptionsBehavior.Editable = False
        Me.grvInventoryItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvInventoryItems.OptionsSelection.MultiSelect = True
        Me.grvInventoryItems.OptionsView.ShowGroupPanel = False
        Me.grvInventoryItems.OptionsView.ShowIndicator = False
        '
        'GridColumn58
        '
        Me.GridColumn58.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn58.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn58.Caption = "Inv. Item #"
        Me.GridColumn58.FieldName = "Invitemnumber"
        Me.GridColumn58.Name = "GridColumn58"
        Me.GridColumn58.Visible = True
        Me.GridColumn58.VisibleIndex = 0
        Me.GridColumn58.Width = 53
        '
        'SourceDoc
        '
        Me.SourceDoc.AppearanceHeader.Options.UseTextOptions = True
        Me.SourceDoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SourceDoc.Caption = "Src Doc"
        Me.SourceDoc.FieldName = "Sourcedocument"
        Me.SourceDoc.Name = "SourceDoc"
        Me.SourceDoc.Visible = True
        Me.SourceDoc.VisibleIndex = 1
        Me.SourceDoc.Width = 50
        '
        'GridColumn59
        '
        Me.GridColumn59.Caption = "Item Type"
        Me.GridColumn59.FieldName = "Itemtype"
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.Visible = True
        Me.GridColumn59.VisibleIndex = 2
        Me.GridColumn59.Width = 56
        '
        'GridColumn60
        '
        Me.GridColumn60.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn60.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn60.Caption = "Item ID"
        Me.GridColumn60.FieldName = "Itemid"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.Visible = True
        Me.GridColumn60.VisibleIndex = 3
        Me.GridColumn60.Width = 56
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "Item Description"
        Me.GridColumn61.FieldName = "Itemdescription"
        Me.GridColumn61.Name = "GridColumn61"
        Me.GridColumn61.Visible = True
        Me.GridColumn61.VisibleIndex = 4
        Me.GridColumn61.Width = 250
        '
        'GridColumn62
        '
        Me.GridColumn62.Caption = "Container"
        Me.GridColumn62.FieldName = "Container"
        Me.GridColumn62.Name = "GridColumn62"
        Me.GridColumn62.Visible = True
        Me.GridColumn62.VisibleIndex = 5
        Me.GridColumn62.Width = 70
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "Item Status"
        Me.GridColumn63.FieldName = "Itemstatus"
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.Visible = True
        Me.GridColumn63.VisibleIndex = 6
        Me.GridColumn63.Width = 65
        '
        'GridColumn64
        '
        Me.GridColumn64.Caption = "Src Status"
        Me.GridColumn64.FieldName = "Sourcestatus"
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.Visible = True
        Me.GridColumn64.VisibleIndex = 7
        Me.GridColumn64.Width = 57
        '
        'GridColumn65
        '
        Me.GridColumn65.Caption = "Lot #"
        Me.GridColumn65.FieldName = "Lotnumber"
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.Visible = True
        Me.GridColumn65.VisibleIndex = 8
        Me.GridColumn65.Width = 47
        '
        'GridColumn66
        '
        Me.GridColumn66.Caption = "Vendor Lbl Wgt"
        Me.GridColumn66.FieldName = "Vendorweight"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.Visible = True
        Me.GridColumn66.VisibleIndex = 9
        Me.GridColumn66.Width = 62
        '
        'GridColumn67
        '
        Me.GridColumn67.Caption = "Rec Weight"
        Me.GridColumn67.FieldName = "Rcvdweight"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.Visible = True
        Me.GridColumn67.VisibleIndex = 10
        Me.GridColumn67.Width = 65
        '
        'GridColumn68
        '
        Me.GridColumn68.Caption = "Inv Class"
        Me.GridColumn68.FieldName = "LookupDesc"
        Me.GridColumn68.Name = "GridColumn68"
        Me.GridColumn68.Visible = True
        Me.GridColumn68.VisibleIndex = 11
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RibbonPanelControl8
        '
        Me.RibbonPanelControl8.Controls.Add(Me.GroupControl2)
        Me.RibbonPanelControl8.Controls.Add(Me.GroupControl4)
        Me.RibbonPanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl8.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl8.Name = "RibbonPanelControl8"
        Me.RibbonPanelControl8.Size = New System.Drawing.Size(922, 279)
        Me.RibbonPanelControl8.TabIndex = 10
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grRelabelOrders)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(918, 125)
        Me.GroupControl2.TabIndex = 9
        Me.GroupControl2.Text = "Relabel Orders"
        '
        'grRelabelOrders
        '
        Me.grRelabelOrders.DataSource = Me.bsRelabelOrders
        Me.grRelabelOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grRelabelOrders.Location = New System.Drawing.Point(2, 22)
        Me.grRelabelOrders.MainView = Me.grvRelabelOrders
        Me.grRelabelOrders.Name = "grRelabelOrders"
        Me.grRelabelOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit18, Me.RepositoryItemLookUpEdit19, Me.RepositoryItemLookUpEdit20, Me.RepositoryItemCheckEdit6, Me.RepositoryItemLookUpEdit21})
        Me.grRelabelOrders.Size = New System.Drawing.Size(914, 101)
        Me.grRelabelOrders.TabIndex = 8
        Me.grRelabelOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvRelabelOrders})
        '
        'bsRelabelOrders
        '
        Me.bsRelabelOrders.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrderCollection)
        '
        'grvRelabelOrders
        '
        Me.grvRelabelOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderNum, Me.colOrderDate, Me.colItemID, Me.colItemDesc, Me.colQty, Me.colNeededBy, Me.colOrderStatus})
        Me.grvRelabelOrders.GridControl = Me.grRelabelOrders
        Me.grvRelabelOrders.Name = "grvRelabelOrders"
        Me.grvRelabelOrders.OptionsBehavior.Editable = False
        Me.grvRelabelOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvRelabelOrders.OptionsView.ShowGroupPanel = False
        Me.grvRelabelOrders.OptionsView.ShowIndicator = False
        '
        'colOrderNum
        '
        Me.colOrderNum.Caption = "Ord #"
        Me.colOrderNum.FieldName = "Relabelordernumber"
        Me.colOrderNum.Name = "colOrderNum"
        Me.colOrderNum.Visible = True
        Me.colOrderNum.VisibleIndex = 0
        Me.colOrderNum.Width = 63
        '
        'colOrderDate
        '
        Me.colOrderDate.Caption = "Ord Date"
        Me.colOrderDate.DisplayFormat.FormatString = "d"
        Me.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colOrderDate.FieldName = "Relabelorderdate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.OptionsColumn.FixedWidth = True
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 1
        Me.colOrderDate.Width = 70
        '
        'colItemID
        '
        Me.colItemID.Caption = "Item ID"
        Me.colItemID.FieldName = "Itemid"
        Me.colItemID.Name = "colItemID"
        Me.colItemID.Visible = True
        Me.colItemID.VisibleIndex = 2
        Me.colItemID.Width = 60
        '
        'colItemDesc
        '
        Me.colItemDesc.Caption = "Item Description"
        Me.colItemDesc.FieldName = "Itemdesc"
        Me.colItemDesc.Name = "colItemDesc"
        Me.colItemDesc.Visible = True
        Me.colItemDesc.VisibleIndex = 3
        Me.colItemDesc.Width = 531
        '
        'colQty
        '
        Me.colQty.Caption = "Qty"
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 4
        Me.colQty.Width = 55
        '
        'colNeededBy
        '
        Me.colNeededBy.Caption = "Needed By"
        Me.colNeededBy.DisplayFormat.FormatString = "d"
        Me.colNeededBy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNeededBy.FieldName = "Neededby"
        Me.colNeededBy.Name = "colNeededBy"
        Me.colNeededBy.OptionsColumn.FixedWidth = True
        Me.colNeededBy.Visible = True
        Me.colNeededBy.VisibleIndex = 5
        Me.colNeededBy.Width = 70
        '
        'colOrderStatus
        '
        Me.colOrderStatus.Caption = "Status"
        Me.colOrderStatus.FieldName = "Relabelorderstatus"
        Me.colOrderStatus.Name = "colOrderStatus"
        Me.colOrderStatus.OptionsColumn.FixedWidth = True
        Me.colOrderStatus.Visible = True
        Me.colOrderStatus.VisibleIndex = 6
        Me.colOrderStatus.Width = 60
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
        Me.GroupControl4.Location = New System.Drawing.Point(2, 127)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(918, 150)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "Cancelled Relabel Orders"
        '
        'grCanceledRelabelOrders
        '
        Me.grCanceledRelabelOrders.DataSource = Me.bsCanceledRelabelOrders
        Me.grCanceledRelabelOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grCanceledRelabelOrders.Location = New System.Drawing.Point(2, 22)
        Me.grCanceledRelabelOrders.MainView = Me.grvCanceledRelabelOrders
        Me.grCanceledRelabelOrders.Name = "grCanceledRelabelOrders"
        Me.grCanceledRelabelOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit22, Me.RepositoryItemLookUpEdit23, Me.RepositoryItemLookUpEdit24, Me.RepositoryItemCheckEdit7, Me.RepositoryItemLookUpEdit25})
        Me.grCanceledRelabelOrders.Size = New System.Drawing.Size(914, 126)
        Me.grCanceledRelabelOrders.TabIndex = 0
        Me.grCanceledRelabelOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvCanceledRelabelOrders})
        '
        'bsCanceledRelabelOrders
        '
        Me.bsCanceledRelabelOrders.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrderCollection)
        '
        'grvCanceledRelabelOrders
        '
        Me.grvCanceledRelabelOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCanceledOrderNum, Me.colCanceledOrderDate, Me.colCanceledItemID, Me.colCanceledItemDesc, Me.colCanceledQty, Me.colCanceledNeededBy, Me.colCanceledOrderStatus})
        Me.grvCanceledRelabelOrders.GridControl = Me.grCanceledRelabelOrders
        Me.grvCanceledRelabelOrders.Name = "grvCanceledRelabelOrders"
        Me.grvCanceledRelabelOrders.OptionsBehavior.Editable = False
        Me.grvCanceledRelabelOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvCanceledRelabelOrders.OptionsView.ShowGroupPanel = False
        Me.grvCanceledRelabelOrders.OptionsView.ShowIndicator = False
        '
        'colCanceledOrderNum
        '
        Me.colCanceledOrderNum.Caption = "Ord #"
        Me.colCanceledOrderNum.FieldName = "Relabelordernumber"
        Me.colCanceledOrderNum.Name = "colCanceledOrderNum"
        Me.colCanceledOrderNum.Visible = True
        Me.colCanceledOrderNum.VisibleIndex = 0
        Me.colCanceledOrderNum.Width = 63
        '
        'colCanceledOrderDate
        '
        Me.colCanceledOrderDate.Caption = "Ord Date"
        Me.colCanceledOrderDate.DisplayFormat.FormatString = "d"
        Me.colCanceledOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCanceledOrderDate.FieldName = "Relabelorderdate"
        Me.colCanceledOrderDate.Name = "colCanceledOrderDate"
        Me.colCanceledOrderDate.OptionsColumn.FixedWidth = True
        Me.colCanceledOrderDate.Visible = True
        Me.colCanceledOrderDate.VisibleIndex = 1
        Me.colCanceledOrderDate.Width = 70
        '
        'colCanceledItemID
        '
        Me.colCanceledItemID.Caption = "Item ID"
        Me.colCanceledItemID.FieldName = "Itemid"
        Me.colCanceledItemID.Name = "colCanceledItemID"
        Me.colCanceledItemID.Visible = True
        Me.colCanceledItemID.VisibleIndex = 2
        Me.colCanceledItemID.Width = 60
        '
        'colCanceledItemDesc
        '
        Me.colCanceledItemDesc.Caption = "Item Description"
        Me.colCanceledItemDesc.FieldName = "Itemdesc"
        Me.colCanceledItemDesc.Name = "colCanceledItemDesc"
        Me.colCanceledItemDesc.Visible = True
        Me.colCanceledItemDesc.VisibleIndex = 3
        Me.colCanceledItemDesc.Width = 531
        '
        'colCanceledQty
        '
        Me.colCanceledQty.Caption = "Qty"
        Me.colCanceledQty.FieldName = "Qty"
        Me.colCanceledQty.Name = "colCanceledQty"
        Me.colCanceledQty.Visible = True
        Me.colCanceledQty.VisibleIndex = 4
        Me.colCanceledQty.Width = 55
        '
        'colCanceledNeededBy
        '
        Me.colCanceledNeededBy.Caption = "Needed By"
        Me.colCanceledNeededBy.DisplayFormat.FormatString = "d"
        Me.colCanceledNeededBy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colCanceledNeededBy.FieldName = "Neededby"
        Me.colCanceledNeededBy.Name = "colCanceledNeededBy"
        Me.colCanceledNeededBy.OptionsColumn.FixedWidth = True
        Me.colCanceledNeededBy.Visible = True
        Me.colCanceledNeededBy.VisibleIndex = 5
        Me.colCanceledNeededBy.Width = 70
        '
        'colCanceledOrderStatus
        '
        Me.colCanceledOrderStatus.Caption = "Status"
        Me.colCanceledOrderStatus.FieldName = "Relabelorderstatus"
        Me.colCanceledOrderStatus.Name = "colCanceledOrderStatus"
        Me.colCanceledOrderStatus.OptionsColumn.FixedWidth = True
        Me.colCanceledOrderStatus.Visible = True
        Me.colCanceledOrderStatus.VisibleIndex = 6
        Me.colCanceledOrderStatus.Width = 60
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
        'RibbonControl2
        '
        Me.RibbonControl2.AllowMinimizeRibbon = False
        Me.RibbonControl2.ApplicationButtonText = Nothing
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.rbtnSearchInventory, Me.rbtnAllocateItem, Me.rbtnLookupInventoryToConvert, Me.rbtnGetProductionOrders, Me.rbtnAddNewProductionOrder, Me.rbtnEditProductionOrder, Me.rbtnDeleteProductionOrder, Me.rbtnPrintProductionOrder, Me.rbtnGetPurchaseReqs, Me.rbtnAddNewPurchaseReq, Me.rbtnEditPurchaseReq, Me.rbtnDeletePurchaseReq, Me.rbtnAllocatedSearchInventory, Me.rbtnReAllocateItem, Me.rbtnGetProductionOrders2, Me.rbtnAddNewProductionOrder2, Me.rbtnEditProductionOrder2, Me.rbtnCancelProductionOrder2, Me.rbtnPrintProductionOrder2, Me.btnSelect, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.bLblVolumeUnits, Me.bLblVolumeUOM, Me.bLblVolumeStandardCost, Me.bLblWeightUnits, Me.bLblWeightUOM, Me.bLblWeightStandardCost, Me.bTxtVolumeUnits, Me.bTxtVolumeUOM, Me.bTxtlVolumeStandardCost, Me.bTxtWeightUnits, Me.bTxtWeightUOM, Me.bTxtWeightStandardCost, Me.btnChangeInventoryClass, Me.rbtnGetRelabelOrders, Me.rbtnAddNewRelabelOrder, Me.rbtnCancelRelabelOrder, Me.rbtnPrintRelabelOrder})
        Me.RibbonControl2.LargeImages = Me.ImageCollection1
        Me.RibbonControl2.Location = New System.Drawing.Point(2, 2)
        Me.RibbonControl2.MaxItemId = 45
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage6, Me.RibbonPage2, Me.RibbonPage8, Me.RibbonPage3, Me.RibbonPage4, Me.RibbonPage5, Me.RibbonPage7})
        Me.RibbonControl2.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl2.ShowToolbarCustomizeItem = False
        Me.RibbonControl2.Size = New System.Drawing.Size(926, 117)
        Me.RibbonControl2.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
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
        Me.rbtnAllocateItem.Caption = "Allocate Inventory"
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
        'rbtnDeleteProductionOrder
        '
        Me.rbtnDeleteProductionOrder.Caption = "Delete  Order"
        Me.rbtnDeleteProductionOrder.Id = 8
        Me.rbtnDeleteProductionOrder.LargeImageIndex = 4
        Me.rbtnDeleteProductionOrder.LargeWidth = 60
        Me.rbtnDeleteProductionOrder.Name = "rbtnDeleteProductionOrder"
        '
        'rbtnPrintProductionOrder
        '
        Me.rbtnPrintProductionOrder.Caption = "Print Order"
        Me.rbtnPrintProductionOrder.Id = 9
        Me.rbtnPrintProductionOrder.LargeImageIndex = 5
        Me.rbtnPrintProductionOrder.LargeWidth = 60
        Me.rbtnPrintProductionOrder.Name = "rbtnPrintProductionOrder"
        '
        'rbtnGetPurchaseReqs
        '
        Me.rbtnGetPurchaseReqs.Caption = "Refresh Purchase Reqs"
        Me.rbtnGetPurchaseReqs.Id = 10
        Me.rbtnGetPurchaseReqs.LargeGlyph = Global.AOS.My.Resources.Resources.document_text_search
        Me.rbtnGetPurchaseReqs.Name = "rbtnGetPurchaseReqs"
        '
        'rbtnAddNewPurchaseReq
        '
        Me.rbtnAddNewPurchaseReq.Caption = "Add New Purchase Req"
        Me.rbtnAddNewPurchaseReq.Id = 11
        Me.rbtnAddNewPurchaseReq.LargeGlyph = Global.AOS.My.Resources.Resources.document_text_add
        Me.rbtnAddNewPurchaseReq.Name = "rbtnAddNewPurchaseReq"
        '
        'rbtnEditPurchaseReq
        '
        Me.rbtnEditPurchaseReq.Caption = "Edit Purchase Req"
        Me.rbtnEditPurchaseReq.Glyph = Global.AOS.My.Resources.Resources.document_text_edit
        Me.rbtnEditPurchaseReq.Id = 12
        Me.rbtnEditPurchaseReq.Name = "rbtnEditPurchaseReq"
        '
        'rbtnDeletePurchaseReq
        '
        Me.rbtnDeletePurchaseReq.Caption = "Delete Purchase Req"
        Me.rbtnDeletePurchaseReq.Glyph = Global.AOS.My.Resources.Resources.document_text_delete
        Me.rbtnDeletePurchaseReq.Id = 13
        Me.rbtnDeletePurchaseReq.Name = "rbtnDeletePurchaseReq"
        '
        'rbtnAllocatedSearchInventory
        '
        Me.rbtnAllocatedSearchInventory.Caption = "Get Allocated Inventory"
        Me.rbtnAllocatedSearchInventory.Id = 15
        Me.rbtnAllocatedSearchInventory.LargeGlyph = Global.AOS.My.Resources.Resources.View_table
        Me.rbtnAllocatedSearchInventory.Name = "rbtnAllocatedSearchInventory"
        '
        'rbtnReAllocateItem
        '
        Me.rbtnReAllocateItem.Caption = "Re-Allocate to Work Order Item"
        Me.rbtnReAllocateItem.Id = 16
        Me.rbtnReAllocateItem.LargeGlyph = Global.AOS.My.Resources.Resources.barcode_properties
        Me.rbtnReAllocateItem.Name = "rbtnReAllocateItem"
        '
        'rbtnGetProductionOrders2
        '
        Me.rbtnGetProductionOrders2.Caption = "Retrieve Orders"
        Me.rbtnGetProductionOrders2.Id = 17
        Me.rbtnGetProductionOrders2.LargeImageIndex = 1
        Me.rbtnGetProductionOrders2.Name = "rbtnGetProductionOrders2"
        '
        'rbtnAddNewProductionOrder2
        '
        Me.rbtnAddNewProductionOrder2.Caption = "Add New Order"
        Me.rbtnAddNewProductionOrder2.Id = 18
        Me.rbtnAddNewProductionOrder2.LargeImageIndex = 2
        Me.rbtnAddNewProductionOrder2.Name = "rbtnAddNewProductionOrder2"
        '
        'rbtnEditProductionOrder2
        '
        Me.rbtnEditProductionOrder2.Caption = "Edit Order"
        Me.rbtnEditProductionOrder2.Enabled = False
        Me.rbtnEditProductionOrder2.Id = 19
        Me.rbtnEditProductionOrder2.LargeImageIndex = 3
        Me.rbtnEditProductionOrder2.Name = "rbtnEditProductionOrder2"
        '
        'rbtnCancelProductionOrder2
        '
        Me.rbtnCancelProductionOrder2.Caption = "Cancel Order"
        Me.rbtnCancelProductionOrder2.Enabled = False
        Me.rbtnCancelProductionOrder2.Id = 20
        Me.rbtnCancelProductionOrder2.LargeImageIndex = 4
        Me.rbtnCancelProductionOrder2.Name = "rbtnCancelProductionOrder2"
        '
        'rbtnPrintProductionOrder2
        '
        Me.rbtnPrintProductionOrder2.Caption = "Print Order"
        Me.rbtnPrintProductionOrder2.Id = 21
        Me.rbtnPrintProductionOrder2.LargeImageIndex = 5
        Me.rbtnPrintProductionOrder2.Name = "rbtnPrintProductionOrder2"
        '
        'btnSelect
        '
        Me.btnSelect.Caption = "Select Cost"
        Me.btnSelect.Id = 22
        Me.btnSelect.LargeGlyph = Global.AOS.My.Resources.Resources.Change1
        Me.btnSelect.Name = "btnSelect"
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 24
        Me.btnNewCostRecord.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCostRecord.Id = 25
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCostRecord.Id = 26
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
        '
        'bLblVolumeUnits
        '
        Me.bLblVolumeUnits.Caption = "Units"
        Me.bLblVolumeUnits.Id = 27
        Me.bLblVolumeUnits.Name = "bLblVolumeUnits"
        Me.bLblVolumeUnits.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblVolumeUOM
        '
        Me.bLblVolumeUOM.Caption = "UOM"
        Me.bLblVolumeUOM.Id = 28
        Me.bLblVolumeUOM.Name = "bLblVolumeUOM"
        Me.bLblVolumeUOM.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblVolumeStandardCost
        '
        Me.bLblVolumeStandardCost.Caption = "Std Cost"
        Me.bLblVolumeStandardCost.Id = 29
        Me.bLblVolumeStandardCost.Name = "bLblVolumeStandardCost"
        Me.bLblVolumeStandardCost.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblWeightUnits
        '
        Me.bLblWeightUnits.Caption = "Units"
        Me.bLblWeightUnits.Id = 30
        Me.bLblWeightUnits.Name = "bLblWeightUnits"
        Me.bLblWeightUnits.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblWeightUOM
        '
        Me.bLblWeightUOM.Caption = "UOM"
        Me.bLblWeightUOM.Id = 31
        Me.bLblWeightUOM.Name = "bLblWeightUOM"
        Me.bLblWeightUOM.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bLblWeightStandardCost
        '
        Me.bLblWeightStandardCost.Caption = "Std Cost"
        Me.bLblWeightStandardCost.Id = 32
        Me.bLblWeightStandardCost.Name = "bLblWeightStandardCost"
        Me.bLblWeightStandardCost.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtVolumeUnits
        '
        Me.bTxtVolumeUnits.Id = 33
        Me.bTxtVolumeUnits.Name = "bTxtVolumeUnits"
        Me.bTxtVolumeUnits.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtVolumeUOM
        '
        Me.bTxtVolumeUOM.Id = 34
        Me.bTxtVolumeUOM.Name = "bTxtVolumeUOM"
        Me.bTxtVolumeUOM.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtlVolumeStandardCost
        '
        Me.bTxtlVolumeStandardCost.Id = 35
        Me.bTxtlVolumeStandardCost.Name = "bTxtlVolumeStandardCost"
        Me.bTxtlVolumeStandardCost.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtWeightUnits
        '
        Me.bTxtWeightUnits.Id = 36
        Me.bTxtWeightUnits.Name = "bTxtWeightUnits"
        Me.bTxtWeightUnits.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtWeightUOM
        '
        Me.bTxtWeightUOM.Id = 37
        Me.bTxtWeightUOM.Name = "bTxtWeightUOM"
        Me.bTxtWeightUOM.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'bTxtWeightStandardCost
        '
        Me.bTxtWeightStandardCost.Id = 38
        Me.bTxtWeightStandardCost.Name = "bTxtWeightStandardCost"
        Me.bTxtWeightStandardCost.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'btnChangeInventoryClass
        '
        Me.btnChangeInventoryClass.Caption = "Change Inventory Class"
        Me.btnChangeInventoryClass.Id = 39
        Me.btnChangeInventoryClass.LargeGlyph = CType(resources.GetObject("btnChangeInventoryClass.LargeGlyph"), System.Drawing.Image)
        Me.btnChangeInventoryClass.Name = "btnChangeInventoryClass"
        '
        'rbtnGetRelabelOrders
        '
        Me.rbtnGetRelabelOrders.Caption = "Retrieve Orders"
        Me.rbtnGetRelabelOrders.Id = 40
        Me.rbtnGetRelabelOrders.LargeImageIndex = 1
        Me.rbtnGetRelabelOrders.Name = "rbtnGetRelabelOrders"
        '
        'rbtnAddNewRelabelOrder
        '
        Me.rbtnAddNewRelabelOrder.Caption = "Add New Order"
        Me.rbtnAddNewRelabelOrder.Id = 41
        Me.rbtnAddNewRelabelOrder.LargeImageIndex = 2
        Me.rbtnAddNewRelabelOrder.Name = "rbtnAddNewRelabelOrder"
        '
        'rbtnCancelRelabelOrder
        '
        Me.rbtnCancelRelabelOrder.Caption = "Cancel  Order"
        Me.rbtnCancelRelabelOrder.Enabled = False
        Me.rbtnCancelRelabelOrder.Id = 43
        Me.rbtnCancelRelabelOrder.LargeImageIndex = 4
        Me.rbtnCancelRelabelOrder.Name = "rbtnCancelRelabelOrder"
        '
        'rbtnPrintRelabelOrder
        '
        Me.rbtnPrintRelabelOrder.Caption = "Print Order"
        Me.rbtnPrintRelabelOrder.Enabled = False
        Me.rbtnPrintRelabelOrder.Id = 44
        Me.rbtnPrintRelabelOrder.LargeImageIndex = 5
        Me.rbtnPrintRelabelOrder.Name = "rbtnPrintRelabelOrder"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage6
        '
        Me.RibbonPage6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup8, Me.RibbonPageGroup9, Me.RibbonPageGroup10, Me.RibbonPageGroup11})
        Me.RibbonPage6.Name = "RibbonPage6"
        Me.RibbonPage6.Text = "Product Pricing"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnSelect)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "User Action"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.ItemLinks.Add(Me.btnNewCostRecord)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.btnEditCostRecord)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.btnDeleteCostRecord)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.ShowCaptionButton = False
        Me.RibbonPageGroup9.Text = "Product Cost Records"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.ItemLinks.Add(Me.bLblVolumeUnits)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.bLblVolumeUOM)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.bLblVolumeStandardCost)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.bTxtVolumeUnits)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.bTxtVolumeUOM)
        Me.RibbonPageGroup10.ItemLinks.Add(Me.bTxtlVolumeStandardCost)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.ShowCaptionButton = False
        Me.RibbonPageGroup10.Text = "Standard Voulme"
        '
        'RibbonPageGroup11
        '
        Me.RibbonPageGroup11.ItemLinks.Add(Me.bLblWeightUnits)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.bLblWeightUOM)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.bLblWeightStandardCost)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.bTxtWeightUnits)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.bTxtWeightUOM)
        Me.RibbonPageGroup11.ItemLinks.Add(Me.bTxtWeightStandardCost)
        Me.RibbonPageGroup11.Name = "RibbonPageGroup11"
        Me.RibbonPageGroup11.ShowCaptionButton = False
        Me.RibbonPageGroup11.Text = "Standard Weight"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Available Inventory"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnSearchInventory)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnAllocateItem, True)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Available Inventory"
        '
        'RibbonPage8
        '
        Me.RibbonPage8.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup13})
        Me.RibbonPage8.Name = "RibbonPage8"
        Me.RibbonPage8.Text = "Relabel Orders"
        '
        'RibbonPageGroup13
        '
        Me.RibbonPageGroup13.ItemLinks.Add(Me.rbtnGetRelabelOrders)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.rbtnAddNewRelabelOrder, True)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.rbtnCancelRelabelOrder)
        Me.RibbonPageGroup13.ItemLinks.Add(Me.rbtnPrintRelabelOrder, True)
        Me.RibbonPageGroup13.Name = "RibbonPageGroup13"
        Me.RibbonPageGroup13.ShowCaptionButton = False
        Me.RibbonPageGroup13.Text = "Relabel Orders"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Allocated Inventory"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnAllocatedSearchInventory)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnReAllocateItem)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Allocated Inventory"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Convert Raw Material"
        Me.RibbonPage4.Visible = False
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Text = "Production Orders"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnGetProductionOrders2)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnAddNewProductionOrder2)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnEditProductionOrder2)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnCancelProductionOrder2)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnPrintProductionOrder2)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Production Orders"
        '
        'RibbonPage7
        '
        Me.RibbonPage7.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup12})
        Me.RibbonPage7.Name = "RibbonPage7"
        Me.RibbonPage7.Text = "Pending Inventory"
        '
        'RibbonPageGroup12
        '
        Me.RibbonPageGroup12.ItemLinks.Add(Me.btnChangeInventoryClass)
        Me.RibbonPageGroup12.Name = "RibbonPageGroup12"
        Me.RibbonPageGroup12.ShowCaptionButton = False
        Me.RibbonPageGroup12.Text = "Pending Inventory"
        '
        'colShiptocustomer
        '
        Me.colShiptocustomer.FieldName = "Shiptocustomer"
        Me.colShiptocustomer.Name = "colShiptocustomer"
        '
        'colWorkordercustomer
        '
        Me.colWorkordercustomer.FieldName = "Workordercustomer"
        Me.colWorkordercustomer.Name = "colWorkordercustomer"
        '
        'colWorkordernumber1
        '
        Me.colWorkordernumber1.FieldName = "Workordernumber"
        Me.colWorkordernumber1.Name = "colWorkordernumber1"
        '
        'colAllocateddocument
        '
        Me.colAllocateddocument.FieldName = "Allocateddocument"
        Me.colAllocateddocument.Name = "colAllocateddocument"
        '
        'colChangeableponumber
        '
        Me.colChangeableponumber.FieldName = "Changeableponumber"
        Me.colChangeableponumber.Name = "colChangeableponumber"
        '
        'colPodate
        '
        Me.colPodate.FieldName = "Podate"
        Me.colPodate.Name = "colPodate"
        '
        'colVendorname
        '
        Me.colVendorname.FieldName = "Vendorname"
        Me.colVendorname.Name = "colVendorname"
        '
        'colPurchasereleasenumber
        '
        Me.colPurchasereleasenumber.FieldName = "Purchasereleasenumber"
        Me.colPurchasereleasenumber.Name = "colPurchasereleasenumber"
        '
        'colPonumber
        '
        Me.colPonumber.FieldName = "Ponumber"
        Me.colPonumber.Name = "colPonumber"
        '
        'colReceiverdocumenttype
        '
        Me.colReceiverdocumenttype.FieldName = "Receiverdocumenttype"
        Me.colReceiverdocumenttype.Name = "colReceiverdocumenttype"
        '
        'colReceiverdocument
        '
        Me.colReceiverdocument.FieldName = "Receiverdocument"
        Me.colReceiverdocument.Name = "colReceiverdocument"
        '
        'colUnitsremaining
        '
        Me.colUnitsremaining.FieldName = "Unitsremaining"
        Me.colUnitsremaining.Name = "colUnitsremaining"
        '
        'colClassdesc
        '
        Me.colClassdesc.FieldName = "Classdesc"
        Me.colClassdesc.Name = "colClassdesc"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnGetProductionOrders)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnAddNewProductionOrder, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnEditProductionOrder)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnDeleteProductionOrder)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnPrintProductionOrder, True)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Production Orders"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowMinimize = False
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnGetProductionOrders)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnAddNewProductionOrder, True)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnEditProductionOrder)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnDeleteProductionOrder)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnPrintProductionOrder, True)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Production Orders"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Retrieve Orders"
        Me.BarButtonItem2.Id = 5
        Me.BarButtonItem2.ImageIndex = 0
        Me.BarButtonItem2.LargeImageIndex = 1
        Me.BarButtonItem2.LargeWidth = 60
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowMinimize = False
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnGetProductionOrders)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnAddNewProductionOrder, True)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnEditProductionOrder)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnDeleteProductionOrder)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnPrintProductionOrder, True)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Production Orders"
        '
        'bsProduct1
        '
        Me.bsProduct1.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'GridColumn110
        '
        Me.GridColumn110.Caption = "Item Description"
        Me.GridColumn110.FieldName = "Productdesc"
        Me.GridColumn110.Name = "GridColumn110"
        Me.GridColumn110.OptionsColumn.AllowEdit = False
        Me.GridColumn110.Visible = True
        Me.GridColumn110.VisibleIndex = 3
        Me.GridColumn110.Width = 229
        '
        'lblCustomerPO
        '
        Me.lblCustomerPO.Location = New System.Drawing.Point(429, 34)
        Me.lblCustomerPO.Name = "lblCustomerPO"
        Me.lblCustomerPO.Size = New System.Drawing.Size(74, 13)
        Me.lblCustomerPO.TabIndex = 42
        Me.lblCustomerPO.Text = "Customer PO #"
        '
        'frmAddEditPurchaseItem
        '
        Me.ClientSize = New System.Drawing.Size(930, 720)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditPurchaseItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase Items Information"
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.CustomerPONumTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedInDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedInDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendorItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendorItemNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemTypeLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItemTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UCTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitCostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UOMTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceDocTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemIDLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemDescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeededbyDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeededbyDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchitemdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchitemdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchItemnumTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.WorkPanelHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl6.ResumeLayout(False)
        CType(Me.grProductCosts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.grAvailableInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAvailableInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvailableInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.grAllocatedInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAllocatedInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvAllocatedInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl4.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl5.ResumeLayout(False)
        CType(Me.gpProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpProductionOrders.ResumeLayout(False)
        CType(Me.grProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProdOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gpCanceledProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpCanceledProductionOrders.ResumeLayout(False)
        CType(Me.grCanceledProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCanceledProdOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCanceledProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl7.ResumeLayout(False)
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl8.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
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
        CType(Me.bsCanceledRelabelOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvCanceledRelabelOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsPurchaseItem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents QtyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NeededbyDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PurchitemdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PurchItemnumTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContainerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemDescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemIDLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents rbtnConvertFullAvailabletoInProcess As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnNewPurchaseReq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitCostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UOMTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rbtnSearchInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAllocateItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnLookupInventoryToConvert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnGetProductionOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddNewProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnGetPurchaseReqs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddNewPurchaseReq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditPurchaseReq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeletePurchaseReq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents grAvailableInventory As DevExpress.XtraGrid.GridControl
    Friend WithEvents AvailableInventory As CustomDevExGridView
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents rbtnAllocatedSearchInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents CustomerLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsVendor As System.Windows.Forms.BindingSource
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents bsAvailableInventory As System.Windows.Forms.BindingSource
    Friend WithEvents rbtnReAllocateItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colShiptocustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordercustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateddocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangeableponumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPodate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasereleasenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPonumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocumenttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsremaining As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents InvItemNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdcutID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedShip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents WorkPanelHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grAllocatedInventory As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvAllocatedInventory As CustomDevExGridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippeddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouselocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehousenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryclass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colClassdesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsremaining1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocument1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocumenttype1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPonumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasereleasenumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPodate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangeableponumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllocateddocument1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordercustomer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptocustomer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsAllocatedInventory As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup13 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup11 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup12 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnGetProductionOrders2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnAddNewProductionOrder2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditProductionOrder2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancelProductionOrder2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintProductionOrder2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsProdOrders As System.Windows.Forms.BindingSource
    Friend WithEvents UCTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemTypeLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsItemTypes As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonPage6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As CustomDevExGridView
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView7 As CustomDevExGridView
    Friend WithEvents btnSelect As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bLblVolumeUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblVolumeUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblVolumeStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblWeightUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblWeightUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bLblWeightStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtVolumeUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtVolumeUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtlVolumeStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWeightUnits As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWeightUOM As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bTxtWeightStandardCost As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents bsProduct1 As System.Windows.Forms.BindingSource
    Friend WithEvents grProductCosts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView8 As CustomDevExGridView
    Friend WithEvents colVUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatecostchanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Costtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eVendorItemNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsVendorItem As System.Windows.Forms.BindingSource
    Friend WithEvents ExpectedInDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents colIsActive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPage7 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grInventoryItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvInventoryItems As CustomDevExGridView
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SourceDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
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
    Friend WithEvents btnChangeInventoryClass As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsInventoryItems As System.Windows.Forms.BindingSource
    Friend WithEvents ExpectedInLabel As System.Windows.Forms.Label
    Friend WithEvents GridColumn69 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents TypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grCanceledProductionOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCanceledProductionOrders As CustomDevExGridView
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn70 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn71 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn72 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn73 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn74 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn75 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn76 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn77 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn78 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn79 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn80 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn81 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As CustomDevExGridView
    Friend WithEvents GridColumn82 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn83 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn84 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn85 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn86 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn87 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn88 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn89 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn90 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn91 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn92 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn93 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn94 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn95 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn96 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn97 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn98 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn99 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn100 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn101 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn102 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn103 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn104 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn105 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn106 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn107 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn108 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn109 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsCanceledProdOrders As System.Windows.Forms.BindingSource
    Friend WithEvents grProductionOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvProductionOrders As CustomDevExGridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdNeededby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView5 As CustomDevExGridView
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents gpProductionOrders As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gpCanceledProductionOrders As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonPage8 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rbtnGetRelabelOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddNewRelabelOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancelRelabelOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintRelabelOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grRelabelOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvRelabelOrders As CustomDevExGridView
    Friend WithEvents colOrderNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeededBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit18 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit19 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit20 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit21 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grCanceledRelabelOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvCanceledRelabelOrders As CustomDevExGridView
    Friend WithEvents colCanceledOrderNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanceledOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanceledItemID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanceledQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanceledNeededBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanceledOrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCanceledItemDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit22 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit23 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit24 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit7 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit25 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn110 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsRelabelOrders As System.Windows.Forms.BindingSource
    Friend WithEvents bsCanceledRelabelOrders As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SourceTypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SourceDocTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn112 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn111 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CustomerPONumTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lblCustomerPO As DevExpress.XtraEditors.LabelControl
End Class
