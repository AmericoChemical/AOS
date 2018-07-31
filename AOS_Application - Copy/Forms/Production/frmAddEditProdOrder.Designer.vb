<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditProdOrder

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
        Dim ProdordernumLabel As System.Windows.Forms.Label
        Dim ApisnumLabel As System.Windows.Forms.Label
        Dim CustidLabel As System.Windows.Forms.Label
        Dim ProdorderdateLabel As System.Windows.Forms.Label
        Dim NeededbyLabel As System.Windows.Forms.Label
        Dim ProductqtyLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim ProductWorkOrderLabel As System.Windows.Forms.Label
        Dim ProductEstCompDateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditProdOrder))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsProdOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAllocateRawMaterialInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.btnChangeInventoryClass = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditWorkOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMaterialUsageTransactions = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintProductLabel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgWorkOrder = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsProdItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eEstCompDate = New DevExpress.XtraEditors.DateEdit()
        Me.eWorkOrderNumber = New DevExpress.XtraEditors.TextEdit()
        Me.eStatus = New DevExpress.XtraEditors.TextEdit()
        Me.eAPIS = New DevExpress.XtraEditors.TextEdit()
        Me.eProductID = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.LotNoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.eProdDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.NeededbyDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ProdorderdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CustidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProdordernumTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsAPISList = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grAPISInputs = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProditemnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdordernum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIscomplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInprocess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProductDesc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luContainer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luStdgallons = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit11 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit12 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
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
        ProdordernumLabel = New System.Windows.Forms.Label()
        ApisnumLabel = New System.Windows.Forms.Label()
        CustidLabel = New System.Windows.Forms.Label()
        ProdorderdateLabel = New System.Windows.Forms.Label()
        NeededbyLabel = New System.Windows.Forms.Label()
        ProductqtyLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        ProductWorkOrderLabel = New System.Windows.Forms.Label()
        ProductEstCompDateLabel = New System.Windows.Forms.Label()
        CType(Me.bsProdOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProdItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eEstCompDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eEstCompDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWorkOrderNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eAPIS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProdDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeededbyDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeededbyDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdorderdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdordernumTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAPISList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grAPISInputs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProdordernumLabel
        '
        ProdordernumLabel.AutoSize = True
        ProdordernumLabel.Location = New System.Drawing.Point(17, 37)
        ProdordernumLabel.Name = "ProdordernumLabel"
        ProdordernumLabel.Size = New System.Drawing.Size(58, 13)
        ProdordernumLabel.TabIndex = 25
        ProdordernumLabel.Text = "Prod Ord#"
        '
        'ApisnumLabel
        '
        ApisnumLabel.AutoSize = True
        ApisnumLabel.Location = New System.Drawing.Point(17, 76)
        ApisnumLabel.Name = "ApisnumLabel"
        ApisnumLabel.Size = New System.Drawing.Size(38, 13)
        ApisnumLabel.TabIndex = 12
        ApisnumLabel.Text = "APIS#"
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(417, 76)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(53, 13)
        CustidLabel.TabIndex = 18
        CustidLabel.Text = "Customer"
        '
        'ProdorderdateLabel
        '
        ProdorderdateLabel.AutoSize = True
        ProdorderdateLabel.Location = New System.Drawing.Point(666, 37)
        ProdorderdateLabel.Name = "ProdorderdateLabel"
        ProdorderdateLabel.Size = New System.Drawing.Size(30, 13)
        ProdorderdateLabel.TabIndex = 8
        ProdorderdateLabel.Text = "Date"
        '
        'NeededbyLabel
        '
        NeededbyLabel.AutoSize = True
        NeededbyLabel.Location = New System.Drawing.Point(666, 76)
        NeededbyLabel.Name = "NeededbyLabel"
        NeededbyLabel.Size = New System.Drawing.Size(59, 13)
        NeededbyLabel.TabIndex = 20
        NeededbyLabel.Text = "Needed by"
        '
        'ProductqtyLabel
        '
        ProductqtyLabel.AutoSize = True
        ProductqtyLabel.Location = New System.Drawing.Point(100, 37)
        ProductqtyLabel.Name = "ProductqtyLabel"
        ProductqtyLabel.Size = New System.Drawing.Size(25, 13)
        ProductqtyLabel.TabIndex = 0
        ProductqtyLabel.Text = "Qty"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(180, 76)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(30, 13)
        Label1.TabIndex = 16
        Label1.Text = "Lot#"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(555, 37)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 13)
        Label2.TabIndex = 6
        Label2.Text = "Container"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(180, 37)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 13)
        Label3.TabIndex = 2
        Label3.Text = "Prod ID"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(249, 37)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 13)
        Label4.TabIndex = 4
        Label4.Text = "Product Description"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(763, 37)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 10
        Label5.Text = "Status"
        '
        'ProductWorkOrderLabel
        '
        ProductWorkOrderLabel.AutoSize = True
        ProductWorkOrderLabel.Location = New System.Drawing.Point(100, 76)
        ProductWorkOrderLabel.Name = "ProductWorkOrderLabel"
        ProductWorkOrderLabel.Size = New System.Drawing.Size(71, 13)
        ProductWorkOrderLabel.TabIndex = 14
        ProductWorkOrderLabel.Text = "Work Order#"
        '
        'ProductEstCompDateLabel
        '
        ProductEstCompDateLabel.AutoSize = True
        ProductEstCompDateLabel.Location = New System.Drawing.Point(763, 76)
        ProductEstCompDateLabel.Name = "ProductEstCompDateLabel"
        ProductEstCompDateLabel.Size = New System.Drawing.Size(56, 13)
        ProductEstCompDateLabel.TabIndex = 22
        ProductEstCompDateLabel.Text = "Est. Comp"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsProdOrder
        '
        Me.bsProdOrder.DataSource = GetType(AOS.BusinessObjects.Prodorder)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnAllocateRawMaterialInventory, Me.btnChangeInventoryClass, Me.rbtnEditWorkOrder, Me.rbtnMaterialUsageTransactions, Me.rbtnPrintProductLabel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 15
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(891, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 6
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 7
        Me.btnCancel.Name = "btnCancel"
        '
        'btnAllocateRawMaterialInventory
        '
        Me.btnAllocateRawMaterialInventory.Caption = "Allocate Raw Material Inventory"
        Me.btnAllocateRawMaterialInventory.Id = 10
        Me.btnAllocateRawMaterialInventory.LargeImageIndex = 28
        Me.btnAllocateRawMaterialInventory.Name = "btnAllocateRawMaterialInventory"
        '
        'btnChangeInventoryClass
        '
        Me.btnChangeInventoryClass.Caption = "Change Receiving Inventory Class"
        Me.btnChangeInventoryClass.Enabled = False
        Me.btnChangeInventoryClass.Id = 11
        Me.btnChangeInventoryClass.LargeImageIndex = 30
        Me.btnChangeInventoryClass.Name = "btnChangeInventoryClass"
        '
        'rbtnEditWorkOrder
        '
        Me.rbtnEditWorkOrder.Caption = "Edit Work Order"
        Me.rbtnEditWorkOrder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnEditWorkOrder.Id = 12
        Me.rbtnEditWorkOrder.LargeImageIndex = 25
        Me.rbtnEditWorkOrder.Name = "rbtnEditWorkOrder"
        '
        'rbtnMaterialUsageTransactions
        '
        Me.rbtnMaterialUsageTransactions.Caption = "Enter Material Usage Transactions"
        Me.rbtnMaterialUsageTransactions.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnMaterialUsageTransactions.Id = 13
        Me.rbtnMaterialUsageTransactions.LargeImageIndex = 23
        Me.rbtnMaterialUsageTransactions.Name = "rbtnMaterialUsageTransactions"
        '
        'rbtnPrintProductLabel
        '
        Me.rbtnPrintProductLabel.Caption = "Print GHS Product Label"
        Me.rbtnPrintProductLabel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPrintProductLabel.Id = 14
        Me.rbtnPrintProductLabel.LargeImageIndex = 32
        Me.rbtnPrintProductLabel.Name = "rbtnPrintProductLabel"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup3, Me.RibbonPageGroup4, Me.rpgWorkOrder, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnPrintProductLabel, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnAllocateRawMaterialInventory)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Inventory Mgmt"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnChangeInventoryClass)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Pending Inventory"
        '
        'rpgWorkOrder
        '
        Me.rpgWorkOrder.AllowMinimize = False
        Me.rpgWorkOrder.AllowTextClipping = False
        Me.rpgWorkOrder.ItemLinks.Add(Me.rbtnEditWorkOrder)
        Me.rpgWorkOrder.Name = "rpgWorkOrder"
        Me.rpgWorkOrder.ShowCaptionButton = False
        Me.rpgWorkOrder.Text = "Work Order"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnMaterialUsageTransactions)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Material Usage"
        '
        'bsProdItems
        '
        Me.bsProdItems.DataSource = GetType(AOS.BusinessObjects.ViewProdItemDataCollection)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(891, 129)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(ProductEstCompDateLabel)
        Me.GroupControl1.Controls.Add(Me.eEstCompDate)
        Me.GroupControl1.Controls.Add(ProductWorkOrderLabel)
        Me.GroupControl1.Controls.Add(Me.eWorkOrderNumber)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Me.eStatus)
        Me.GroupControl1.Controls.Add(Me.eAPIS)
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.LotNoTextEdit)
        Me.GroupControl1.Controls.Add(Me.eContainer)
        Me.GroupControl1.Controls.Add(Me.eProdDesc)
        Me.GroupControl1.Controls.Add(ProductqtyLabel)
        Me.GroupControl1.Controls.Add(Me.eQty)
        Me.GroupControl1.Controls.Add(NeededbyLabel)
        Me.GroupControl1.Controls.Add(Me.NeededbyDateEdit)
        Me.GroupControl1.Controls.Add(ProdorderdateLabel)
        Me.GroupControl1.Controls.Add(Me.ProdorderdateDateEdit)
        Me.GroupControl1.Controls.Add(CustidLabel)
        Me.GroupControl1.Controls.Add(Me.CustidLookUpEdit)
        Me.GroupControl1.Controls.Add(ApisnumLabel)
        Me.GroupControl1.Controls.Add(ProdordernumLabel)
        Me.GroupControl1.Controls.Add(Me.ProdordernumTextEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(887, 125)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Production Order Information"
        '
        'eEstCompDate
        '
        Me.eEstCompDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Estimatedcompletiondate", True))
        Me.eEstCompDate.EditValue = Nothing
        Me.eEstCompDate.Enabled = False
        Me.eEstCompDate.Location = New System.Drawing.Point(763, 92)
        Me.eEstCompDate.MenuManager = Me.RibbonControl1
        Me.eEstCompDate.Name = "eEstCompDate"
        Me.eEstCompDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eEstCompDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eEstCompDate.Size = New System.Drawing.Size(99, 20)
        Me.eEstCompDate.TabIndex = 23
        '
        'eWorkOrderNumber
        '
        Me.eWorkOrderNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Workordernumber", True))
        Me.eWorkOrderNumber.Location = New System.Drawing.Point(100, 92)
        Me.eWorkOrderNumber.MenuManager = Me.RibbonControl1
        Me.eWorkOrderNumber.Name = "eWorkOrderNumber"
        Me.eWorkOrderNumber.Properties.ReadOnly = True
        Me.eWorkOrderNumber.Size = New System.Drawing.Size(68, 20)
        Me.eWorkOrderNumber.TabIndex = 15
        '
        'eStatus
        '
        Me.eStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Orderstatus", True))
        Me.eStatus.Location = New System.Drawing.Point(763, 53)
        Me.eStatus.MenuManager = Me.RibbonControl1
        Me.eStatus.Name = "eStatus"
        Me.eStatus.Properties.ReadOnly = True
        Me.eStatus.Size = New System.Drawing.Size(99, 20)
        Me.eStatus.TabIndex = 11
        '
        'eAPIS
        '
        Me.eAPIS.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Apisnum", True))
        Me.eAPIS.Location = New System.Drawing.Point(17, 92)
        Me.eAPIS.MenuManager = Me.RibbonControl1
        Me.eAPIS.Name = "eAPIS"
        Me.eAPIS.Properties.ReadOnly = True
        Me.eAPIS.Size = New System.Drawing.Size(71, 20)
        Me.eAPIS.TabIndex = 13
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Productid", True))
        Me.eProductID.Location = New System.Drawing.Point(180, 53)
        Me.eProductID.MenuManager = Me.RibbonControl1
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ProdID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Units", "Units", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "Uom", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProductID.Properties.DataSource = Me.bsProducts
        Me.eProductID.Properties.DisplayMember = "Productid"
        Me.eProductID.Properties.NullText = ""
        Me.eProductID.Properties.PopupWidth = 375
        Me.eProductID.Properties.ValueMember = "Productid"
        Me.eProductID.Size = New System.Drawing.Size(57, 20)
        Me.eProductID.TabIndex = 3
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ViewProductsWithAPISCollection)
        '
        'LotNoTextEdit
        '
        Me.LotNoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Lotnumber", True))
        Me.LotNoTextEdit.Location = New System.Drawing.Point(180, 92)
        Me.LotNoTextEdit.MenuManager = Me.RibbonControl1
        Me.LotNoTextEdit.Name = "LotNoTextEdit"
        Me.LotNoTextEdit.Size = New System.Drawing.Size(223, 20)
        Me.LotNoTextEdit.TabIndex = 17
        '
        'eContainer
        '
        Me.eContainer.Location = New System.Drawing.Point(555, 53)
        Me.eContainer.MenuManager = Me.RibbonControl1
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(99, 20)
        Me.eContainer.TabIndex = 7
        '
        'eProdDesc
        '
        Me.eProdDesc.Location = New System.Drawing.Point(249, 53)
        Me.eProdDesc.MenuManager = Me.RibbonControl1
        Me.eProdDesc.Name = "eProdDesc"
        Me.eProdDesc.Properties.ReadOnly = True
        Me.eProdDesc.Size = New System.Drawing.Size(294, 20)
        Me.eProdDesc.TabIndex = 5
        '
        'eQty
        '
        Me.eQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Productqty", True))
        Me.eQty.Location = New System.Drawing.Point(100, 53)
        Me.eQty.MenuManager = Me.RibbonControl1
        Me.eQty.Name = "eQty"
        Me.eQty.Properties.Mask.EditMask = "d"
        Me.eQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eQty.Size = New System.Drawing.Size(68, 20)
        Me.eQty.TabIndex = 1
        '
        'NeededbyDateEdit
        '
        Me.NeededbyDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Neededby", True))
        Me.NeededbyDateEdit.EditValue = Nothing
        Me.NeededbyDateEdit.Location = New System.Drawing.Point(666, 92)
        Me.NeededbyDateEdit.MenuManager = Me.RibbonControl1
        Me.NeededbyDateEdit.Name = "NeededbyDateEdit"
        Me.NeededbyDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NeededbyDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.NeededbyDateEdit.Size = New System.Drawing.Size(85, 20)
        Me.NeededbyDateEdit.TabIndex = 21
        '
        'ProdorderdateDateEdit
        '
        Me.ProdorderdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Prodorderdate", True))
        Me.ProdorderdateDateEdit.EditValue = Nothing
        Me.ProdorderdateDateEdit.Location = New System.Drawing.Point(666, 53)
        Me.ProdorderdateDateEdit.MenuManager = Me.RibbonControl1
        Me.ProdorderdateDateEdit.Name = "ProdorderdateDateEdit"
        Me.ProdorderdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProdorderdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ProdorderdateDateEdit.Size = New System.Drawing.Size(85, 20)
        Me.ProdorderdateDateEdit.TabIndex = 9
        '
        'CustidLookUpEdit
        '
        Me.CustidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Custid", True))
        Me.CustidLookUpEdit.Location = New System.Drawing.Point(417, 92)
        Me.CustidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.CustidLookUpEdit.Name = "CustidLookUpEdit"
        Me.CustidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustidLookUpEdit.Properties.DataSource = Me.bsCustomers
        Me.CustidLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustidLookUpEdit.Properties.NullText = ""
        Me.CustidLookUpEdit.Properties.PopupWidth = 320
        Me.CustidLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustidLookUpEdit.Size = New System.Drawing.Size(237, 20)
        Me.CustidLookUpEdit.TabIndex = 19
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'ProdordernumTextEdit
        '
        Me.ProdordernumTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdOrder, "Prodordernum", True))
        Me.ProdordernumTextEdit.Location = New System.Drawing.Point(17, 53)
        Me.ProdordernumTextEdit.MenuManager = Me.RibbonControl1
        Me.ProdordernumTextEdit.Name = "ProdordernumTextEdit"
        Me.ProdordernumTextEdit.Properties.ReadOnly = True
        Me.ProdordernumTextEdit.Size = New System.Drawing.Size(71, 20)
        Me.ProdordernumTextEdit.TabIndex = 25
        Me.ProdordernumTextEdit.TabStop = False
        '
        'bsAPISList
        '
        Me.bsAPISList.DataSource = GetType(AOS.BusinessObjects.ViewAPISDataCollection)
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl3)
        Me.PanelControl2.Controls.Add(Me.PanelControl4)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 224)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl2.Size = New System.Drawing.Size(891, 427)
        Me.PanelControl2.TabIndex = 2
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(8, 8)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(875, 211)
        Me.PanelControl3.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grAPISInputs)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(871, 207)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Material Inputs"
        '
        'grAPISInputs
        '
        Me.grAPISInputs.DataSource = Me.bsProdItems
        Me.grAPISInputs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAPISInputs.Location = New System.Drawing.Point(2, 22)
        Me.grAPISInputs.MainView = Me.GridView1
        Me.grAPISInputs.Name = "grAPISInputs"
        Me.grAPISInputs.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit6, Me.RepositoryItemLookUpEdit11, Me.RepositoryItemLookUpEdit12})
        Me.grAPISInputs.Size = New System.Drawing.Size(867, 183)
        Me.grAPISInputs.TabIndex = 6
        Me.grAPISInputs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProditemnum, Me.colProdordernum, Me.colMaterialid, Me.colApisnum, Me.colUom, Me.colQty, Me.colIscomplete, Me.colMaterialdesc, Me.colInventory, Me.colInprocess, Me.colAvailable})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView1.GridControl = Me.grAPISInputs
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colProditemnum
        '
        Me.colProditemnum.FieldName = "Proditemnum"
        Me.colProditemnum.Name = "colProditemnum"
        Me.colProditemnum.OptionsColumn.FixedWidth = True
        '
        'colProdordernum
        '
        Me.colProdordernum.FieldName = "Prodordernum"
        Me.colProdordernum.Name = "colProdordernum"
        Me.colProdordernum.OptionsColumn.FixedWidth = True
        '
        'colMaterialid
        '
        Me.colMaterialid.Caption = "Mat ID"
        Me.colMaterialid.FieldName = "Materialid"
        Me.colMaterialid.Name = "colMaterialid"
        Me.colMaterialid.OptionsColumn.FixedWidth = True
        Me.colMaterialid.Visible = True
        Me.colMaterialid.VisibleIndex = 2
        Me.colMaterialid.Width = 45
        '
        'colApisnum
        '
        Me.colApisnum.FieldName = "Apisnum"
        Me.colApisnum.Name = "colApisnum"
        Me.colApisnum.OptionsColumn.FixedWidth = True
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.OptionsColumn.FixedWidth = True
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 1
        Me.colUom.Width = 35
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.OptionsColumn.FixedWidth = True
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 0
        Me.colQty.Width = 45
        '
        'colIscomplete
        '
        Me.colIscomplete.Caption = "Is Complete?"
        Me.colIscomplete.FieldName = "Iscomplete"
        Me.colIscomplete.Name = "colIscomplete"
        Me.colIscomplete.OptionsColumn.FixedWidth = True
        Me.colIscomplete.Visible = True
        Me.colIscomplete.VisibleIndex = 7
        '
        'colMaterialdesc
        '
        Me.colMaterialdesc.Caption = "Material Description"
        Me.colMaterialdesc.FieldName = "Materialdesc"
        Me.colMaterialdesc.Name = "colMaterialdesc"
        Me.colMaterialdesc.Visible = True
        Me.colMaterialdesc.VisibleIndex = 3
        Me.colMaterialdesc.Width = 492
        '
        'colInventory
        '
        Me.colInventory.Caption = "Inventory"
        Me.colInventory.FieldName = "Inventory"
        Me.colInventory.Name = "colInventory"
        Me.colInventory.OptionsColumn.FixedWidth = True
        Me.colInventory.Visible = True
        Me.colInventory.VisibleIndex = 4
        Me.colInventory.Width = 60
        '
        'colInprocess
        '
        Me.colInprocess.Caption = "In Process"
        Me.colInprocess.FieldName = "Inprocess"
        Me.colInprocess.Name = "colInprocess"
        Me.colInprocess.OptionsColumn.FixedWidth = True
        Me.colInprocess.Visible = True
        Me.colInprocess.VisibleIndex = 5
        Me.colInprocess.Width = 65
        '
        'colAvailable
        '
        Me.colAvailable.FieldName = "Available"
        Me.colAvailable.Name = "colAvailable"
        Me.colAvailable.OptionsColumn.FixedWidth = True
        Me.colAvailable.Visible = True
        Me.colAvailable.VisibleIndex = 6
        Me.colAvailable.Width = 55
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
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.DisplayMember = "Materialdesc"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.ReadOnly = True
        Me.RepositoryItemLookUpEdit6.ValueMember = "Materialid"
        '
        'RepositoryItemLookUpEdit11
        '
        Me.RepositoryItemLookUpEdit11.AutoHeight = False
        Me.RepositoryItemLookUpEdit11.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 68, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Description", 69, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 57, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", "Desc 2", 39, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit11.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit11.Name = "RepositoryItemLookUpEdit11"
        Me.RepositoryItemLookUpEdit11.NullText = ""
        Me.RepositoryItemLookUpEdit11.ShowFooter = False
        Me.RepositoryItemLookUpEdit11.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit12
        '
        Me.RepositoryItemLookUpEdit12.AutoHeight = False
        Me.RepositoryItemLookUpEdit12.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialid", "ID", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialdesc", "Material Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialuom", "UOM", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit12.DisplayMember = "Materialdesc"
        Me.RepositoryItemLookUpEdit12.Name = "RepositoryItemLookUpEdit12"
        Me.RepositoryItemLookUpEdit12.NullText = ""
        Me.RepositoryItemLookUpEdit12.ValueMember = "Materialid"
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.GroupControl3)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(8, 219)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(875, 200)
        Me.PanelControl4.TabIndex = 2
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grInventoryItems)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(871, 196)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Prod Order Inventory"
        '
        'grInventoryItems
        '
        Me.grInventoryItems.DataSource = Me.bsInventoryItems
        Me.grInventoryItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInventoryItems.Location = New System.Drawing.Point(2, 22)
        Me.grInventoryItems.LookAndFeel.SkinName = "Money Twins"
        Me.grInventoryItems.MainView = Me.grvInventoryItems
        Me.grInventoryItems.Name = "grInventoryItems"
        Me.grInventoryItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.grInventoryItems.Size = New System.Drawing.Size(867, 172)
        Me.grInventoryItems.TabIndex = 6
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
        Me.GridColumn58.OptionsColumn.FixedWidth = True
        Me.GridColumn58.Visible = True
        Me.GridColumn58.VisibleIndex = 0
        Me.GridColumn58.Width = 58
        '
        'SourceDoc
        '
        Me.SourceDoc.AppearanceHeader.Options.UseTextOptions = True
        Me.SourceDoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SourceDoc.Caption = "Src Doc"
        Me.SourceDoc.FieldName = "Sourcedocument"
        Me.SourceDoc.Name = "SourceDoc"
        Me.SourceDoc.OptionsColumn.FixedWidth = True
        Me.SourceDoc.Visible = True
        Me.SourceDoc.VisibleIndex = 1
        Me.SourceDoc.Width = 48
        '
        'GridColumn59
        '
        Me.GridColumn59.Caption = "Item Type"
        Me.GridColumn59.FieldName = "Itemtype"
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.OptionsColumn.FixedWidth = True
        Me.GridColumn59.Visible = True
        Me.GridColumn59.VisibleIndex = 2
        Me.GridColumn59.Width = 60
        '
        'GridColumn60
        '
        Me.GridColumn60.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn60.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn60.Caption = "Item ID"
        Me.GridColumn60.FieldName = "Itemid"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.OptionsColumn.FixedWidth = True
        Me.GridColumn60.Visible = True
        Me.GridColumn60.VisibleIndex = 3
        Me.GridColumn60.Width = 50
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "Item Description"
        Me.GridColumn61.FieldName = "Itemdescription"
        Me.GridColumn61.Name = "GridColumn61"
        Me.GridColumn61.Visible = True
        Me.GridColumn61.VisibleIndex = 4
        Me.GridColumn61.Width = 205
        '
        'GridColumn62
        '
        Me.GridColumn62.Caption = "Container"
        Me.GridColumn62.FieldName = "Container"
        Me.GridColumn62.Name = "GridColumn62"
        Me.GridColumn62.OptionsColumn.FixedWidth = True
        Me.GridColumn62.Visible = True
        Me.GridColumn62.VisibleIndex = 5
        Me.GridColumn62.Width = 60
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "Item Status"
        Me.GridColumn63.FieldName = "Itemstatus"
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.OptionsColumn.FixedWidth = True
        Me.GridColumn63.Visible = True
        Me.GridColumn63.VisibleIndex = 6
        Me.GridColumn63.Width = 63
        '
        'GridColumn64
        '
        Me.GridColumn64.Caption = "Src Status"
        Me.GridColumn64.FieldName = "Sourcestatus"
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.OptionsColumn.FixedWidth = True
        Me.GridColumn64.Visible = True
        Me.GridColumn64.VisibleIndex = 7
        Me.GridColumn64.Width = 60
        '
        'GridColumn65
        '
        Me.GridColumn65.Caption = "Lot #"
        Me.GridColumn65.FieldName = "Lotnumber"
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.OptionsColumn.FixedWidth = True
        Me.GridColumn65.Visible = True
        Me.GridColumn65.VisibleIndex = 8
        Me.GridColumn65.Width = 64
        '
        'GridColumn66
        '
        Me.GridColumn66.Caption = "Vnd Lbl Wgt"
        Me.GridColumn66.FieldName = "Vendorweight"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.OptionsColumn.FixedWidth = True
        Me.GridColumn66.Visible = True
        Me.GridColumn66.VisibleIndex = 9
        Me.GridColumn66.Width = 59
        '
        'GridColumn67
        '
        Me.GridColumn67.Caption = "Rec Weight"
        Me.GridColumn67.FieldName = "Rcvdweight"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.OptionsColumn.FixedWidth = True
        Me.GridColumn67.Visible = True
        Me.GridColumn67.VisibleIndex = 10
        Me.GridColumn67.Width = 53
        '
        'GridColumn68
        '
        Me.GridColumn68.Caption = "Inv Class"
        Me.GridColumn68.FieldName = "LookupDesc"
        Me.GridColumn68.Name = "GridColumn68"
        Me.GridColumn68.OptionsColumn.FixedWidth = True
        Me.GridColumn68.Visible = True
        Me.GridColumn68.VisibleIndex = 11
        Me.GridColumn68.Width = 87
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'frmAddEditProdOrder
        '
        Me.ClientSize = New System.Drawing.Size(891, 651)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditProdOrder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Production Order Information"
        CType(Me.bsProdOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProdItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eEstCompDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eEstCompDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWorkOrderNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eAPIS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotNoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProdDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeededbyDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeededbyDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdorderdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdordernumTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAPISList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grAPISInputs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProdOrder As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsProdItems As System.Windows.Forms.BindingSource
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NeededbyDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ProdorderdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CustidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ProdordernumTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProdDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents grAPISInputs As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit12 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit11 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luProductDesc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luContainer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luStdgallons As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LotNoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colProditemnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdordernum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIscomplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInprocess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents eProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsAPISList As System.Windows.Forms.BindingSource
    Friend WithEvents eAPIS As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAllocateRawMaterialInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eWorkOrderNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eEstCompDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnChangeInventoryClass As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsInventoryItems As System.Windows.Forms.BindingSource
    Friend WithEvents grInventoryItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvInventoryItems As CustomDevExGridView
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SourceDoc As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents rbtnEditWorkOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgWorkOrder As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnMaterialUsageTransactions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnPrintProductLabel As DevExpress.XtraBars.BarButtonItem
End Class
