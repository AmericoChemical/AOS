<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewWarehouse

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewWarehouse))
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.grHeader = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnRetrievePurchOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReceiveOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnOpenRelabelOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnProcessRelabelOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAllRelabelOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReceivedHold = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddNewReceiverItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReceivingHistory = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintProductList = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCloseOutPO = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grPOs = New DevExpress.XtraGrid.GridControl()
        Me.bsPurchaseOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPurchaseOrder = New AOS.CustomClasses.CustomDevExGridView()
        Me.colPonumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangeableponumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPodate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpecteddelivery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPotype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl10 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsRelabelOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colRelabelordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelabelorderdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeededby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelabelorderstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grInventory = New DevExpress.XtraGrid.GridControl()
        Me.bsPurchaseItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPurchaseItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitorcontainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemdescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductLookupEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnRetrivePurchaseItems = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMarkAsReceived = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPurchaseOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRelabelOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLookupEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.FormCaption.Size = New System.Drawing.Size(1124, 33)
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
        Me.grHeader.GroupPanelText = "WAREHOUSE"
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnRetrievePurchOrders, Me.btnReceiveOrder, Me.rbtnOpenRelabelOrders, Me.rbtnProcessRelabelOrder, Me.rbtnAllRelabelOrders, Me.rbtnReceivedHold, Me.rbtnAddNewReceiverItem, Me.rbtnReceivingHistory, Me.rbtnPrintProductList, Me.rbtnCloseOutPO})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 66
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage4})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1124, 117)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnRetrievePurchOrders
        '
        Me.btnRetrievePurchOrders.Caption = "Open Purchase Orders"
        Me.btnRetrievePurchOrders.Id = 55
        Me.btnRetrievePurchOrders.LargeImageIndex = 1
        Me.btnRetrievePurchOrders.Name = "btnRetrievePurchOrders"
        Me.btnRetrievePurchOrders.Tag = "320"
        '
        'btnReceiveOrder
        '
        Me.btnReceiveOrder.Caption = "Receive Order Items"
        Me.btnReceiveOrder.Id = 56
        Me.btnReceiveOrder.LargeImageIndex = 14
        Me.btnReceiveOrder.Name = "btnReceiveOrder"
        Me.btnReceiveOrder.Tag = "321"
        '
        'rbtnOpenRelabelOrders
        '
        Me.rbtnOpenRelabelOrders.Caption = " Open  Orders"
        Me.rbtnOpenRelabelOrders.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnOpenRelabelOrders.Id = 57
        Me.rbtnOpenRelabelOrders.LargeImageIndex = 35
        Me.rbtnOpenRelabelOrders.Name = "rbtnOpenRelabelOrders"
        Me.rbtnOpenRelabelOrders.Tag = "318"
        '
        'rbtnProcessRelabelOrder
        '
        Me.rbtnProcessRelabelOrder.Caption = "Process Order"
        Me.rbtnProcessRelabelOrder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnProcessRelabelOrder.Id = 58
        Me.rbtnProcessRelabelOrder.LargeImageIndex = 47
        Me.rbtnProcessRelabelOrder.Name = "rbtnProcessRelabelOrder"
        Me.rbtnProcessRelabelOrder.Tag = "319"
        '
        'rbtnAllRelabelOrders
        '
        Me.rbtnAllRelabelOrders.Caption = "  All   Orders"
        Me.rbtnAllRelabelOrders.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnAllRelabelOrders.Id = 59
        Me.rbtnAllRelabelOrders.LargeImageIndex = 42
        Me.rbtnAllRelabelOrders.Name = "rbtnAllRelabelOrders"
        '
        'rbtnReceivedHold
        '
        Me.rbtnReceivedHold.Caption = "Manage Received / Hold Items"
        Me.rbtnReceivedHold.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnReceivedHold.Id = 60
        Me.rbtnReceivedHold.LargeImageIndex = 7
        Me.rbtnReceivedHold.Name = "rbtnReceivedHold"
        Me.rbtnReceivedHold.Tag = "353"
        '
        'rbtnAddNewReceiverItem
        '
        Me.rbtnAddNewReceiverItem.Caption = "Receive Misc Item(s)"
        Me.rbtnAddNewReceiverItem.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnAddNewReceiverItem.Id = 62
        Me.rbtnAddNewReceiverItem.LargeImageIndex = 14
        Me.rbtnAddNewReceiverItem.Name = "rbtnAddNewReceiverItem"
        Me.rbtnAddNewReceiverItem.Tag = "352"
        '
        'rbtnReceivingHistory
        '
        Me.rbtnReceivingHistory.Caption = "Receiving History"
        Me.rbtnReceivingHistory.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnReceivingHistory.Id = 63
        Me.rbtnReceivingHistory.LargeImageIndex = 13
        Me.rbtnReceivingHistory.Name = "rbtnReceivingHistory"
        Me.rbtnReceivingHistory.Tag = "354"
        '
        'rbtnPrintProductList
        '
        Me.rbtnPrintProductList.Caption = "Print Product List"
        Me.rbtnPrintProductList.Id = 64
        Me.rbtnPrintProductList.LargeImageIndex = 8
        Me.rbtnPrintProductList.Name = "rbtnPrintProductList"
        Me.rbtnPrintProductList.Tag = "355"
        '
        'rbtnCloseOutPO
        '
        Me.rbtnCloseOutPO.Caption = "Close Out Purchase Order"
        Me.rbtnCloseOutPO.Id = 65
        Me.rbtnCloseOutPO.LargeImageIndex = 9
        Me.rbtnCloseOutPO.Name = "rbtnCloseOutPO"
        Me.rbtnCloseOutPO.Tag = "356"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4, Me.RibbonPageGroup2, Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup7, Me.RibbonPageGroup8})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "21"
        Me.RibbonPage1.Text = "Receiving"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnRetrievePurchOrders)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnReceiveOrder, True)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Purchase Orders"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnAddNewReceiverItem)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Misc Receipts"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnReceivedHold)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Received / Hold"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnReceivingHistory)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Database"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowMinimize = False
        Me.RibbonPageGroup7.AllowTextClipping = False
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnPrintProductList)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Reports"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.AllowMinimize = False
        Me.RibbonPageGroup8.AllowTextClipping = False
        Me.RibbonPageGroup8.ItemLinks.Add(Me.rbtnCloseOutPO)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Admin"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Tag = "126"
        Me.RibbonPage4.Text = "Relabel Orders"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowMinimize = False
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnOpenRelabelOrders)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnAllRelabelOrders, True)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnProcessRelabelOrder, True)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Relabel Orders"
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
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl10)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl9)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl8)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl7)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl6)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 150)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1124, 450)
        Me.WorkPanelsHolder.TabIndex = 7
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Controls.Add(Me.GroupControl1)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1124, 450)
        Me.RibbonPanelControl1.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grPOs)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1120, 446)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Open Purchase Orders"
        '
        'grPOs
        '
        Me.grPOs.DataSource = Me.bsPurchaseOrder
        Me.grPOs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPOs.Location = New System.Drawing.Point(2, 22)
        Me.grPOs.LookAndFeel.SkinName = "Money Twins"
        Me.grPOs.MainView = Me.grvPurchaseOrder
        Me.grPOs.Name = "grPOs"
        Me.grPOs.Size = New System.Drawing.Size(1116, 422)
        Me.grPOs.TabIndex = 2
        Me.grPOs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPurchaseOrder})
        '
        'bsPurchaseOrder
        '
        Me.bsPurchaseOrder.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseOrderListCollection)
        '
        'grvPurchaseOrder
        '
        Me.grvPurchaseOrder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPonumber, Me.colChangeableponumber, Me.GridColumn1, Me.colPodate, Me.colExpecteddelivery, Me.colPostatus, Me.colPotype, Me.GridColumn2})
        Me.grvPurchaseOrder.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvPurchaseOrder.GridControl = Me.grPOs
        Me.grvPurchaseOrder.Name = "grvPurchaseOrder"
        Me.grvPurchaseOrder.OptionsBehavior.Editable = False
        Me.grvPurchaseOrder.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvPurchaseOrder.OptionsView.ShowAutoFilterRow = True
        Me.grvPurchaseOrder.OptionsView.ShowGroupPanel = False
        Me.grvPurchaseOrder.OptionsView.ShowIndicator = False
        '
        'colPonumber
        '
        Me.colPonumber.Caption = "Prch Ord #"
        Me.colPonumber.FieldName = "Purchasenumber"
        Me.colPonumber.Name = "colPonumber"
        Me.colPonumber.OptionsColumn.FixedWidth = True
        Me.colPonumber.Visible = True
        Me.colPonumber.VisibleIndex = 0
        Me.colPonumber.Width = 65
        '
        'colChangeableponumber
        '
        Me.colChangeableponumber.Caption = "Vend Ord #"
        Me.colChangeableponumber.FieldName = "Custompurchasenumber"
        Me.colChangeableponumber.Name = "colChangeableponumber"
        Me.colChangeableponumber.OptionsColumn.FixedWidth = True
        Me.colChangeableponumber.Visible = True
        Me.colChangeableponumber.VisibleIndex = 1
        Me.colChangeableponumber.Width = 70
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Vendor"
        Me.GridColumn1.FieldName = "Vendorname"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 199
        '
        'colPodate
        '
        Me.colPodate.Caption = "PO Date"
        Me.colPodate.DisplayFormat.FormatString = "d"
        Me.colPodate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPodate.FieldName = "Purchasedate"
        Me.colPodate.Name = "colPodate"
        Me.colPodate.OptionsColumn.FixedWidth = True
        Me.colPodate.Visible = True
        Me.colPodate.VisibleIndex = 3
        Me.colPodate.Width = 65
        '
        'colExpecteddelivery
        '
        Me.colExpecteddelivery.Caption = "Expected In"
        Me.colExpecteddelivery.DisplayFormat.FormatString = "d"
        Me.colExpecteddelivery.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colExpecteddelivery.FieldName = "Expectedindate"
        Me.colExpecteddelivery.Name = "colExpecteddelivery"
        Me.colExpecteddelivery.OptionsColumn.FixedWidth = True
        Me.colExpecteddelivery.Visible = True
        Me.colExpecteddelivery.VisibleIndex = 4
        Me.colExpecteddelivery.Width = 70
        '
        'colPostatus
        '
        Me.colPostatus.Caption = "Status"
        Me.colPostatus.FieldName = "Purchasestatus"
        Me.colPostatus.Name = "colPostatus"
        Me.colPostatus.OptionsColumn.FixedWidth = True
        Me.colPostatus.Visible = True
        Me.colPostatus.VisibleIndex = 5
        Me.colPostatus.Width = 65
        '
        'colPotype
        '
        Me.colPotype.Caption = "Terms"
        Me.colPotype.FieldName = "Terms"
        Me.colPotype.Name = "colPotype"
        Me.colPotype.OptionsColumn.FixedWidth = True
        Me.colPotype.Visible = True
        Me.colPotype.VisibleIndex = 6
        Me.colPotype.Width = 170
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Special Instructions"
        Me.GridColumn2.FieldName = "Instructions"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 7
        Me.GridColumn2.Width = 170
        '
        'RibbonPanelControl10
        '
        Me.RibbonPanelControl10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl10.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl10.Name = "RibbonPanelControl10"
        Me.RibbonPanelControl10.Size = New System.Drawing.Size(1124, 450)
        Me.RibbonPanelControl10.TabIndex = 2
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Controls.Add(Me.GroupControl3)
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1124, 450)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1120, 446)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Relabel Orders"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsRelabelOrders
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.LookAndFeel.SkinName = "Money Twins"
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1116, 422)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsRelabelOrders
        '
        Me.bsRelabelOrders.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrderCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRelabelordernumber, Me.colRelabelorderdate, Me.colQty1, Me.colItemid1, Me.colItemdesc, Me.colUom1, Me.colNeededby, Me.colContainer, Me.colWorkordernumber, Me.colRelabelorderstatus, Me.colCustname})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colRelabelordernumber
        '
        Me.colRelabelordernumber.Caption = "Ord#"
        Me.colRelabelordernumber.FieldName = "Relabelordernumber"
        Me.colRelabelordernumber.Name = "colRelabelordernumber"
        Me.colRelabelordernumber.Visible = True
        Me.colRelabelordernumber.VisibleIndex = 0
        Me.colRelabelordernumber.Width = 52
        '
        'colRelabelorderdate
        '
        Me.colRelabelorderdate.Caption = "Order Date"
        Me.colRelabelorderdate.FieldName = "Relabelorderdate"
        Me.colRelabelorderdate.Name = "colRelabelorderdate"
        Me.colRelabelorderdate.Visible = True
        Me.colRelabelorderdate.VisibleIndex = 1
        Me.colRelabelorderdate.Width = 81
        '
        'colQty1
        '
        Me.colQty1.Caption = "Qty"
        Me.colQty1.FieldName = "Qty"
        Me.colQty1.Name = "colQty1"
        Me.colQty1.Visible = True
        Me.colQty1.VisibleIndex = 2
        Me.colQty1.Width = 48
        '
        'colItemid1
        '
        Me.colItemid1.Caption = "Item ID"
        Me.colItemid1.FieldName = "Itemid"
        Me.colItemid1.Name = "colItemid1"
        Me.colItemid1.Visible = True
        Me.colItemid1.VisibleIndex = 3
        Me.colItemid1.Width = 59
        '
        'colItemdesc
        '
        Me.colItemdesc.Caption = "Item Description"
        Me.colItemdesc.FieldName = "Itemdesc"
        Me.colItemdesc.Name = "colItemdesc"
        Me.colItemdesc.Visible = True
        Me.colItemdesc.VisibleIndex = 4
        Me.colItemdesc.Width = 274
        '
        'colUom1
        '
        Me.colUom1.Caption = "UOM"
        Me.colUom1.FieldName = "Uom"
        Me.colUom1.Name = "colUom1"
        Me.colUom1.Visible = True
        Me.colUom1.VisibleIndex = 5
        Me.colUom1.Width = 73
        '
        'colNeededby
        '
        Me.colNeededby.Caption = "Needed By"
        Me.colNeededby.FieldName = "Neededby"
        Me.colNeededby.Name = "colNeededby"
        Me.colNeededby.Visible = True
        Me.colNeededby.VisibleIndex = 6
        Me.colNeededby.Width = 76
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 7
        Me.colContainer.Width = 96
        '
        'colWorkordernumber
        '
        Me.colWorkordernumber.Caption = "WO#"
        Me.colWorkordernumber.FieldName = "Workordernumber"
        Me.colWorkordernumber.Name = "colWorkordernumber"
        Me.colWorkordernumber.Visible = True
        Me.colWorkordernumber.VisibleIndex = 8
        Me.colWorkordernumber.Width = 66
        '
        'colRelabelorderstatus
        '
        Me.colRelabelorderstatus.Caption = "Status"
        Me.colRelabelorderstatus.FieldName = "Relabelorderstatus"
        Me.colRelabelorderstatus.Name = "colRelabelorderstatus"
        Me.colRelabelorderstatus.Visible = True
        Me.colRelabelorderstatus.VisibleIndex = 9
        Me.colRelabelorderstatus.Width = 87
        '
        'colCustname
        '
        Me.colCustname.Caption = "Customer"
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 10
        Me.colCustname.Width = 204
        '
        'RibbonPanelControl9
        '
        Me.RibbonPanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl9.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl9.Name = "RibbonPanelControl9"
        Me.RibbonPanelControl9.Size = New System.Drawing.Size(1124, 450)
        Me.RibbonPanelControl9.TabIndex = 6
        '
        'RibbonPanelControl8
        '
        Me.RibbonPanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl8.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl8.Name = "RibbonPanelControl8"
        Me.RibbonPanelControl8.Size = New System.Drawing.Size(1124, 450)
        Me.RibbonPanelControl8.TabIndex = 5
        '
        'RibbonPanelControl7
        '
        Me.RibbonPanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl7.Name = "RibbonPanelControl7"
        Me.RibbonPanelControl7.Size = New System.Drawing.Size(1124, 450)
        Me.RibbonPanelControl7.TabIndex = 4
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(1124, 450)
        Me.RibbonPanelControl5.TabIndex = 3
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.PanelControl2)
        Me.RibbonPanelControl3.Controls.Add(Me.SplitterControl1)
        Me.RibbonPanelControl3.Controls.Add(Me.PanelControl1)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1124, 450)
        Me.RibbonPanelControl3.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.GroupControl2)
        Me.PanelControl2.Controls.Add(Me.RibbonControl2)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(8, 429)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1108, 13)
        Me.PanelControl2.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grInventory)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1108, 0)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Purchase Items"
        '
        'grInventory
        '
        Me.grInventory.DataSource = Me.bsPurchaseItem
        Me.grInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInventory.Location = New System.Drawing.Point(2, 22)
        Me.grInventory.LookAndFeel.SkinName = "Money Twins"
        Me.grInventory.MainView = Me.grvPurchaseItems
        Me.grInventory.Name = "grInventory"
        Me.grInventory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductLookupEdit})
        Me.grInventory.Size = New System.Drawing.Size(1104, 0)
        Me.grInventory.TabIndex = 2
        Me.grInventory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPurchaseItems})
        '
        'bsPurchaseItem
        '
        Me.bsPurchaseItem.DataSource = GetType(AOS.BusinessObjects.PurchaseitemCollection)
        '
        'grvPurchaseItems
        '
        Me.grvPurchaseItems.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvPurchaseItems.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvPurchaseItems.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.grvPurchaseItems.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvPurchaseItems.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvPurchaseItems.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvPurchaseItems.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.grvPurchaseItems.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvPurchaseItems.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.grvPurchaseItems.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.grvPurchaseItems.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvPurchaseItems.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvPurchaseItems.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvPurchaseItems.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grvPurchaseItems.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvPurchaseItems.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvPurchaseItems.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grvPurchaseItems.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvPurchaseItems.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvPurchaseItems.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvPurchaseItems.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvPurchaseItems.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grvPurchaseItems.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvPurchaseItems.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvPurchaseItems.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grvPurchaseItems.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvPurchaseItems.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvPurchaseItems.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvPurchaseItems.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvPurchaseItems.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvPurchaseItems.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvPurchaseItems.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvPurchaseItems.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grvPurchaseItems.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvPurchaseItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colQty, Me.colUnitorcontainer, Me.colItemtype, Me.colItemid, Me.colItemdescription, Me.coContainer, Me.GridColumn4, Me.colUom, Me.GridColumn3, Me.Status, Me.GridColumn5})
        Me.grvPurchaseItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvPurchaseItems.GridControl = Me.grInventory
        Me.grvPurchaseItems.Name = "grvPurchaseItems"
        Me.grvPurchaseItems.OptionsBehavior.Editable = False
        Me.grvPurchaseItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvPurchaseItems.OptionsView.ShowGroupPanel = False
        Me.grvPurchaseItems.OptionsView.ShowIndicator = False
        '
        'colQty
        '
        Me.colQty.Caption = "Qty"
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 0
        Me.colQty.Width = 44
        '
        'colUnitorcontainer
        '
        Me.colUnitorcontainer.Caption = "U/C"
        Me.colUnitorcontainer.FieldName = "Unitorcontainer"
        Me.colUnitorcontainer.Name = "colUnitorcontainer"
        Me.colUnitorcontainer.Visible = True
        Me.colUnitorcontainer.VisibleIndex = 1
        Me.colUnitorcontainer.Width = 27
        '
        'colItemtype
        '
        Me.colItemtype.Caption = "Item Type"
        Me.colItemtype.FieldName = "Itemtype"
        Me.colItemtype.Name = "colItemtype"
        Me.colItemtype.Visible = True
        Me.colItemtype.VisibleIndex = 2
        Me.colItemtype.Width = 59
        '
        'colItemid
        '
        Me.colItemid.Caption = "Item ID"
        Me.colItemid.FieldName = "Itemid"
        Me.colItemid.Name = "colItemid"
        Me.colItemid.Visible = True
        Me.colItemid.VisibleIndex = 3
        Me.colItemid.Width = 60
        '
        'colItemdescription
        '
        Me.colItemdescription.Caption = "Item Description"
        Me.colItemdescription.FieldName = "Itemdescription"
        Me.colItemdescription.Name = "colItemdescription"
        Me.colItemdescription.Visible = True
        Me.colItemdescription.VisibleIndex = 4
        Me.colItemdescription.Width = 190
        '
        'coContainer
        '
        Me.coContainer.Caption = "Container"
        Me.coContainer.FieldName = "Container"
        Me.coContainer.Name = "coContainer"
        Me.coContainer.Visible = True
        Me.coContainer.VisibleIndex = 5
        Me.coContainer.Width = 88
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Units"
        Me.GridColumn4.FieldName = "Unitsincontainer"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 6
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 7
        Me.colUom.Width = 65
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Expected In Date"
        Me.GridColumn3.DisplayFormat.FormatString = "d"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "Expectedindate"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 8
        Me.GridColumn3.Width = 78
        '
        'Status
        '
        Me.Status.Caption = "Status"
        Me.Status.FieldName = "Purchasestatus"
        Me.Status.Name = "Status"
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 9
        Me.Status.Width = 85
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Vendor Item #"
        Me.GridColumn5.FieldName = "Vendoritemnumber"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 10
        Me.GridColumn5.Width = 87
        '
        'ProductLookupEdit
        '
        Me.ProductLookupEdit.AutoHeight = False
        Me.ProductLookupEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductLookupEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ProductLookupEdit.DisplayMember = "Productdesc"
        Me.ProductLookupEdit.Name = "ProductLookupEdit"
        Me.ProductLookupEdit.NullText = ""
        Me.ProductLookupEdit.ReadOnly = True
        Me.ProductLookupEdit.ShowFooter = False
        Me.ProductLookupEdit.ShowHeader = False
        Me.ProductLookupEdit.ValueMember = "Productid"
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.btnRetrivePurchaseItems, Me.btnMarkAsReceived})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 3
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage3})
        Me.RibbonControl2.ShowCategoryInCaption = False
        Me.RibbonControl2.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl2.ShowToolbarCustomizeItem = False
        Me.RibbonControl2.Size = New System.Drawing.Size(1108, 95)
        Me.RibbonControl2.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnRetrivePurchaseItems
        '
        Me.btnRetrivePurchaseItems.Caption = "Retrive Purchase Items"
        Me.btnRetrivePurchaseItems.Id = 1
        Me.btnRetrivePurchaseItems.LargeGlyph = CType(resources.GetObject("btnRetrivePurchaseItems.LargeGlyph"), System.Drawing.Image)
        Me.btnRetrivePurchaseItems.Name = "btnRetrivePurchaseItems"
        '
        'btnMarkAsReceived
        '
        Me.btnMarkAsReceived.Caption = "Mark As Received"
        Me.btnMarkAsReceived.Id = 2
        Me.btnMarkAsReceived.LargeGlyph = CType(resources.GetObject("btnMarkAsReceived.LargeGlyph"), System.Drawing.Image)
        Me.btnMarkAsReceived.Name = "btnMarkAsReceived"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "RibbonPage3"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnRetrivePurchaseItems)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnMarkAsReceived)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Retrive Purch. Items"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(8, 423)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(1108, 6)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(8, 8)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1108, 415)
        Me.PanelControl1.TabIndex = 0
        '
        'RibbonPanelControl6
        '
        Me.RibbonPanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl6.Name = "RibbonPanelControl6"
        Me.RibbonPanelControl6.Size = New System.Drawing.Size(1124, 450)
        Me.RibbonPanelControl6.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'viewWarehouse
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.Name = "viewWarehouse"
        Me.Size = New System.Drawing.Size(1124, 600)
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grPOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPurchaseOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl4.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRelabelOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLookupEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents grHeader As CustomDevExGridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl10 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnRetrievePurchOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnRetrivePurchaseItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMarkAsReceived As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grPOs As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPurchaseOrder As CustomDevExGridView
    Friend WithEvents colPonumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangeableponumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPodate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpecteddelivery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPotype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grInventory As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPurchaseItems As CustomDevExGridView
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitorcontainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemdescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductLookupEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsPurchaseOrder As System.Windows.Forms.BindingSource
    Friend WithEvents bsPurchaseItem As System.Windows.Forms.BindingSource
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnReceiveOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnOpenRelabelOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnProcessRelabelOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsRelabelOrders As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colRelabelordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelabelorderdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeededby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelabelorderstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnAllRelabelOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnReceivedHold As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnAddNewReceiverItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnReceivingHistory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnPrintProductList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnCloseOutPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
