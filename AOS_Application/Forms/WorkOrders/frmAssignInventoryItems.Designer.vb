<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignInventoryItems

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssignInventoryItems))
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
        Me.rbtnDeleteProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetPurchaseReqs = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewPurchaseReq = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditPurchaseReq = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeletePurchaseReq = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnUnallocateWorkOrderItem = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
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
        Me.GridView1 = New CustomDevExGridView()
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
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsAvailableInventory = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New CustomDevExGridView()
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
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.bsPurchaseReqs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New CustomDevExGridView()
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
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit10 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit13 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.bsProdOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New CustomDevExGridView()
        Me.colProdordernum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdorderdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisnum1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeededby = New DevExpress.XtraGrid.Columns.GridColumn()
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
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.WorkPanelHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelHolder.SuspendLayout()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAvailableInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseReqs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProdOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnSearchInventory, Me.rbtnAllocateItem, Me.rbtnLookupInventoryToConvert, Me.rbtnGetProductionOrders, Me.rbtnAddNewProductionOrder, Me.rbtnEditProductionOrder, Me.rbtnDeleteProductionOrder, Me.rbtnPrintProductionOrder, Me.rbtnGetPurchaseReqs, Me.rbtnAddNewPurchaseReq, Me.rbtnEditPurchaseReq, Me.rbtnDeletePurchaseReq, Me.rbtnUnallocateWorkOrderItem})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(2, 2)
        Me.RibbonControl1.MaxItemId = 15
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3})
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
        'rbtnUnallocateWorkOrderItem
        '
        Me.rbtnUnallocateWorkOrderItem.Caption = "Unallocate from Work Order Item"
        Me.rbtnUnallocateWorkOrderItem.Id = 14
        Me.rbtnUnallocateWorkOrderItem.LargeGlyph = Global.AOS.My.Resources.Resources.barcode_remove
        Me.rbtnUnallocateWorkOrderItem.Name = "rbtnUnallocateWorkOrderItem"
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
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnDeleteProductionOrder)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnPrintProductionOrder, True)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Production Orders"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Purchase Requests"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnGetPurchaseReqs)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnAddNewPurchaseReq, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnEditPurchaseReq)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnDeletePurchaseReq)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Purchase Reqs"
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
        Me.GroupControl2.Size = New System.Drawing.Size(1018, 299)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Work Order Items"
        '
        'grWorkOrderItems
        '
        Me.grWorkOrderItems.DataSource = Me.bsWOItems
        Me.grWorkOrderItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grWorkOrderItems.Location = New System.Drawing.Point(2, 21)
        Me.grWorkOrderItems.MainView = Me.GridView1
        Me.grWorkOrderItems.Name = "grWorkOrderItems"
        Me.grWorkOrderItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1})
        Me.grWorkOrderItems.Size = New System.Drawing.Size(1014, 276)
        Me.grWorkOrderItems.TabIndex = 5
        Me.grWorkOrderItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsWOItems
        '
        Me.bsWOItems.DataSource = GetType(AOS.BusinessObjects.ViewWorkOrderItemCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWorkorderitemnumber, Me.colWorkordernumber, Me.colProductid, Me.colProductdesc1, Me.colContainer1, Me.colQty, Me.colInvitemnumber, Me.colLotnumber, Me.colWarehouselocation, Me.colSourcetype, Me.colSourcedocument, Me.colUnitorcontainer, Me.colUnits, Me.colUom})
        Me.GridView1.GridControl = Me.grWorkOrderItems
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
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
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.AllowEdit = False
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 1
        Me.colProductid.Width = 73
        '
        'colProductdesc1
        '
        Me.colProductdesc1.Caption = "Product Description"
        Me.colProductdesc1.FieldName = "Productdesc"
        Me.colProductdesc1.Name = "colProductdesc1"
        Me.colProductdesc1.OptionsColumn.AllowEdit = False
        Me.colProductdesc1.Visible = True
        Me.colProductdesc1.VisibleIndex = 3
        Me.colProductdesc1.Width = 231
        '
        'colContainer1
        '
        Me.colContainer1.FieldName = "Container"
        Me.colContainer1.Name = "colContainer1"
        Me.colContainer1.OptionsColumn.AllowEdit = False
        Me.colContainer1.Visible = True
        Me.colContainer1.VisibleIndex = 4
        Me.colContainer1.Width = 94
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.AllowEdit = False
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 0
        Me.colQty.Width = 57
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Inv Item #"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.OptionsColumn.AllowEdit = False
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 5
        Me.colInvitemnumber.Width = 78
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot Number"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.OptionsColumn.AllowEdit = False
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 6
        Me.colLotnumber.Width = 127
        '
        'colWarehouselocation
        '
        Me.colWarehouselocation.FieldName = "Warehouselocation"
        Me.colWarehouselocation.Name = "colWarehouselocation"
        '
        'colSourcetype
        '
        Me.colSourcetype.Caption = "Source"
        Me.colSourcetype.FieldName = "Sourcetype"
        Me.colSourcetype.Name = "colSourcetype"
        Me.colSourcetype.OptionsColumn.AllowEdit = False
        Me.colSourcetype.Visible = True
        Me.colSourcetype.VisibleIndex = 7
        Me.colSourcetype.Width = 112
        '
        'colSourcedocument
        '
        Me.colSourcedocument.AppearanceCell.Options.UseTextOptions = True
        Me.colSourcedocument.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colSourcedocument.Caption = "Source Doc"
        Me.colSourcedocument.FieldName = "Sourcedocument"
        Me.colSourcedocument.Name = "colSourcedocument"
        Me.colSourcedocument.OptionsColumn.AllowEdit = False
        Me.colSourcedocument.Visible = True
        Me.colSourcedocument.VisibleIndex = 8
        Me.colSourcedocument.Width = 112
        '
        'colUnitorcontainer
        '
        Me.colUnitorcontainer.Caption = "U/C"
        Me.colUnitorcontainer.FieldName = "Unitorcontainer"
        Me.colUnitorcontainer.Name = "colUnitorcontainer"
        Me.colUnitorcontainer.OptionsColumn.AllowEdit = False
        Me.colUnitorcontainer.Visible = True
        Me.colUnitorcontainer.VisibleIndex = 2
        Me.colUnitorcontainer.Width = 43
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
        Me.PanelControl1.Location = New System.Drawing.Point(0, 360)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1018, 380)
        Me.PanelControl1.TabIndex = 3
        '
        'WorkPanelHolder
        '
        Me.WorkPanelHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelHolder.Location = New System.Drawing.Point(2, 119)
        Me.WorkPanelHolder.Name = "WorkPanelHolder"
        Me.WorkPanelHolder.Size = New System.Drawing.Size(1014, 259)
        Me.WorkPanelHolder.TabIndex = 1
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RibbonPanelControl1.Controls.Add(Me.GridControl1)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1014, 259)
        Me.RibbonPanelControl1.TabIndex = 0
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsAvailableInventory
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView2
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3, Me.RepositoryItemLookUpEdit5, Me.RepositoryItemCheckEdit2, Me.RepositoryItemLookUpEdit4})
        Me.GridControl1.Size = New System.Drawing.Size(1014, 259)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsAvailableInventory
        '
        Me.bsAvailableInventory.DataSource = GetType(AOS.BusinessObjects.ViewInvItemDetailsCollection)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber1, Me.colProductid3, Me.colProductdesc, Me.colContainer, Me.colShipmentnumber, Me.colShipmentdate, Me.colShippeddate, Me.colReceiveddate, Me.colLotnumber1, Me.colWarehouselocation1, Me.colWarehousenumber, Me.colAllocateddate, Me.colReceivernumber, Me.colItemstatus, Me.colInventoryclass, Me.colClassdesc, Me.colUnitsremaining, Me.colReceiverdocument, Me.colReceiverdocumenttype, Me.colPonumber, Me.colPurchasereleasenumber, Me.colVendorname, Me.colPodate, Me.colChangeableponumber, Me.colAllocateddocument, Me.colWorkordernumber1, Me.colWorkordercustomer, Me.colShiptocustomer})
        Me.GridView2.GridControl = Me.GridControl1
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colInvitemnumber1
        '
        Me.colInvitemnumber1.FieldName = "Invitemnumber"
        Me.colInvitemnumber1.Name = "colInvitemnumber1"
        '
        'colProductid3
        '
        Me.colProductid3.Caption = "Prod ID"
        Me.colProductid3.FieldName = "Productid"
        Me.colProductid3.Name = "colProductid3"
        Me.colProductid3.OptionsColumn.AllowEdit = False
        Me.colProductid3.Visible = True
        Me.colProductid3.VisibleIndex = 1
        Me.colProductid3.Width = 69
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.OptionsColumn.AllowEdit = False
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 2
        Me.colProductdesc.Width = 283
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.OptionsColumn.AllowEdit = False
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 145
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
        Me.colReceiveddate.Visible = True
        Me.colReceiveddate.VisibleIndex = 0
        Me.colReceiveddate.Width = 71
        '
        'colLotnumber1
        '
        Me.colLotnumber1.Caption = "Lot Number"
        Me.colLotnumber1.FieldName = "Lotnumber"
        Me.colLotnumber1.Name = "colLotnumber1"
        Me.colLotnumber1.OptionsColumn.AllowEdit = False
        Me.colLotnumber1.Visible = True
        Me.colLotnumber1.VisibleIndex = 4
        Me.colLotnumber1.Width = 187
        '
        'colWarehouselocation1
        '
        Me.colWarehouselocation1.Caption = "Bin"
        Me.colWarehouselocation1.FieldName = "Warehouselocation"
        Me.colWarehouselocation1.Name = "colWarehouselocation1"
        Me.colWarehouselocation1.OptionsColumn.AllowEdit = False
        Me.colWarehouselocation1.Visible = True
        Me.colWarehouselocation1.VisibleIndex = 5
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
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 6
        Me.colItemstatus.Width = 130
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
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RibbonPanelControl3.Controls.Add(Me.GridControl3)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1014, 259)
        Me.RibbonPanelControl3.TabIndex = 2
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.bsPurchaseReqs
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(0, 0)
        Me.GridControl3.MainView = Me.GridView4
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit10, Me.RepositoryItemLookUpEdit11, Me.RepositoryItemLookUpEdit12, Me.RepositoryItemCheckEdit4, Me.RepositoryItemLookUpEdit13})
        Me.GridControl3.Size = New System.Drawing.Size(1014, 259)
        Me.GridControl3.TabIndex = 7
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'bsPurchaseReqs
        '
        Me.bsPurchaseReqs.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseRequestCollection)
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn26, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25})
        Me.GridView4.GridControl = Me.GridControl3
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Req ID"
        Me.GridColumn1.FieldName = "PurchReqID"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 48
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Req Date"
        Me.GridColumn2.FieldName = "PurchReqDate"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 70
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "ProductID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 61
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Product Description"
        Me.GridColumn4.FieldName = "Productdesc"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 283
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "QtyContainers"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 97
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "Container"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "DateNeeded"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 226
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "PONumber"
        Me.GridColumn8.Name = "GridColumn8"
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "IsOrdered"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "Units"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "Uom"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Prod Ord#"
        Me.GridColumn26.FieldName = "ProdOrderNum"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 8
        Me.GridColumn26.Width = 79
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Work Ord#"
        Me.GridColumn12.FieldName = "WorkOrderNumber"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 7
        Me.GridColumn12.Width = 69
        '
        'GridColumn13
        '
        Me.GridColumn13.FieldName = "CustID"
        Me.GridColumn13.Name = "GridColumn13"
        '
        'GridColumn14
        '
        Me.GridColumn14.FieldName = "VendorID"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.FieldName = "Vendorname"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.FieldName = "Plannedshipdate"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.FieldName = "Deliverydate"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.FieldName = "Workorderdate"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.FieldName = "Custname"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.FieldName = "Custshipcity"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.FieldName = "Custshipstateprov"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn22
        '
        Me.GridColumn22.FieldName = "Custshippostalcode"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.FieldName = "WorkOrderItemNumber"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.FieldName = "DateReceived"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn25
        '
        Me.GridColumn25.FieldName = "ReceiverItemNumber"
        Me.GridColumn25.Name = "GridColumn25"
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
        Me.RibbonPanelControl2.Controls.Add(Me.GroupControl4)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1014, 259)
        Me.RibbonPanelControl2.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.GridControl4)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1014, 259)
        Me.GroupControl4.TabIndex = 2
        Me.GroupControl4.Text = "Production Orders Linked to Work Order / Product ID"
        '
        'GridControl4
        '
        Me.GridControl4.DataSource = Me.bsProdOrders
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(2, 21)
        Me.GridControl4.MainView = Me.GridView5
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit14, Me.RepositoryItemLookUpEdit15, Me.RepositoryItemLookUpEdit16, Me.RepositoryItemCheckEdit5, Me.RepositoryItemLookUpEdit17})
        Me.GridControl4.Size = New System.Drawing.Size(1010, 236)
        Me.GridControl4.TabIndex = 6
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'bsProdOrders
        '
        Me.bsProdOrders.DataSource = GetType(AOS.BusinessObjects.ViewProdOrderDataCollection)
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProdordernum, Me.colProdorderdate, Me.colCreatedby, Me.colProductid2, Me.colProductqty, Me.colApisnum1, Me.colCustid, Me.colLotnumber2, Me.colNeededby, Me.colIscomplete, Me.colProductdesc2, Me.colContainer3, Me.colUom2, Me.colCustname})
        Me.GridView5.GridControl = Me.GridControl4
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'colProdordernum
        '
        Me.colProdordernum.Caption = "Ord #"
        Me.colProdordernum.FieldName = "Prodordernum"
        Me.colProdordernum.Name = "colProdordernum"
        Me.colProdordernum.Visible = True
        Me.colProdordernum.VisibleIndex = 0
        Me.colProdordernum.Width = 50
        '
        'colProdorderdate
        '
        Me.colProdorderdate.Caption = "Ord Date"
        Me.colProdorderdate.DisplayFormat.FormatString = "d"
        Me.colProdorderdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colProdorderdate.FieldName = "Prodorderdate"
        Me.colProdorderdate.Name = "colProdorderdate"
        Me.colProdorderdate.Visible = True
        Me.colProdorderdate.VisibleIndex = 1
        Me.colProdorderdate.Width = 73
        '
        'colCreatedby
        '
        Me.colCreatedby.FieldName = "Createdby"
        Me.colCreatedby.Name = "colCreatedby"
        '
        'colProductid2
        '
        Me.colProductid2.Caption = "Prod ID"
        Me.colProductid2.FieldName = "Productid"
        Me.colProductid2.Name = "colProductid2"
        Me.colProductid2.Visible = True
        Me.colProductid2.VisibleIndex = 2
        Me.colProductid2.Width = 58
        '
        'colProductqty
        '
        Me.colProductqty.Caption = "Qty"
        Me.colProductqty.FieldName = "Productqty"
        Me.colProductqty.Name = "colProductqty"
        Me.colProductqty.Visible = True
        Me.colProductqty.VisibleIndex = 4
        Me.colProductqty.Width = 37
        '
        'colApisnum1
        '
        Me.colApisnum1.FieldName = "Apisnum"
        Me.colApisnum1.Name = "colApisnum1"
        Me.colApisnum1.Visible = True
        Me.colApisnum1.VisibleIndex = 6
        Me.colApisnum1.Width = 59
        '
        'colCustid
        '
        Me.colCustid.FieldName = "Custid"
        Me.colCustid.Name = "colCustid"
        '
        'colLotnumber2
        '
        Me.colLotnumber2.FieldName = "Lotnumber"
        Me.colLotnumber2.Name = "colLotnumber2"
        Me.colLotnumber2.Visible = True
        Me.colLotnumber2.VisibleIndex = 7
        Me.colLotnumber2.Width = 123
        '
        'colNeededby
        '
        Me.colNeededby.DisplayFormat.FormatString = "d"
        Me.colNeededby.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colNeededby.FieldName = "Neededby"
        Me.colNeededby.Name = "colNeededby"
        Me.colNeededby.Visible = True
        Me.colNeededby.VisibleIndex = 8
        Me.colNeededby.Width = 63
        '
        'colIscomplete
        '
        Me.colIscomplete.Caption = "Complete"
        Me.colIscomplete.FieldName = "Iscomplete"
        Me.colIscomplete.Name = "colIscomplete"
        Me.colIscomplete.Visible = True
        Me.colIscomplete.VisibleIndex = 11
        Me.colIscomplete.Width = 58
        '
        'colProductdesc2
        '
        Me.colProductdesc2.Caption = "Product Description"
        Me.colProductdesc2.FieldName = "Productdesc"
        Me.colProductdesc2.Name = "colProductdesc2"
        Me.colProductdesc2.Visible = True
        Me.colProductdesc2.VisibleIndex = 3
        Me.colProductdesc2.Width = 191
        '
        'colContainer3
        '
        Me.colContainer3.FieldName = "Container"
        Me.colContainer3.Name = "colContainer3"
        Me.colContainer3.Visible = True
        Me.colContainer3.VisibleIndex = 5
        Me.colContainer3.Width = 83
        '
        'colUom2
        '
        Me.colUom2.Caption = "UOM"
        Me.colUom2.FieldName = "Uom"
        Me.colUom2.Name = "colUom2"
        Me.colUom2.Visible = True
        Me.colUom2.VisibleIndex = 9
        Me.colUom2.Width = 50
        '
        'colCustname
        '
        Me.colCustname.Caption = "Customer"
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 10
        Me.colCustname.Width = 163
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
        'frmAssignInventoryItems
        '
        Me.ClientSize = New System.Drawing.Size(1018, 740)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAssignInventoryItems"
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
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.WorkPanelHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAvailableInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseReqs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProdOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents WorkPanelHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents bsWorkOrder As System.Windows.Forms.BindingSource
    Friend WithEvents bsWOItems As System.Windows.Forms.BindingSource
    Friend WithEvents bsAvailableInventory As System.Windows.Forms.BindingSource
    Friend WithEvents bsPurchaseReqs As System.Windows.Forms.BindingSource
    Friend WithEvents bsProdOrders As System.Windows.Forms.BindingSource
    Friend WithEvents grWorkOrderItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
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
    Friend WithEvents rbtnDeleteProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPrintProductionOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnGetPurchaseReqs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnAddNewPurchaseReq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditPurchaseReq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeletePurchaseReq As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
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
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As CustomDevExGridView
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
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
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
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As CustomDevExGridView
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
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit10 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit13 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
End Class
