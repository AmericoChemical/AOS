<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewShipping

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
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New CustomDevExGridView()
        Me.GridView2 = New CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAddShipment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditShipment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteShipment = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintBOL = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddCarrier = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCarrier = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCarrier = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCreateShipmentFromWorkOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGetPickedOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.eReportStartDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.eReportEndDate = New DevExpress.XtraBars.BarEditItem()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btnReportProductsShipped = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddNewLogisticsProvider = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditLogisticsProvider = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteLogisticsProvider = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetShipments = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnLoadCarrierData = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnLoadLogisticsData = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMergeShipments = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dgvShipments = New DevExpress.XtraGrid.GridControl()
        Me.bsShipments = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New CustomDevExGridView()
        Me.colShipmentnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomername1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipperName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colConsigneeName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFreightcarrier1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFob1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colKeepfromfreezing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New CustomDevExGridView()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.dgLogistics = New DevExpress.XtraGrid.GridControl()
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView10 = New CustomDevExGridView()
        Me.colLogisticsid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsaddr1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsaddr2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticscity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsstate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticszip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticscontact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView11 = New CustomDevExGridView()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.dgvCarrier = New DevExpress.XtraGrid.GridControl()
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New CustomDevExGridView()
        Me.colCarrierID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierState = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierContactName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTermsCarrier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView7 = New CustomDevExGridView()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.grPickedOrders = New DevExpress.XtraGrid.GridControl()
        Me.bsPickedOrders = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPickedOrders = New CustomDevExGridView()
        Me.colWorkordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlannedshipdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDeliverydate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFob2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalContainers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrdernotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerpo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.bsShipmentItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.colWorkordernumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomername = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromaddress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromaddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromcity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromstateprov = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfrompostalcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromcountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromphone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromfax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipfromcontact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptoid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptoname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptoaddress1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptoaddress2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptocity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptostateprov = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptopostalcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptocountry = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptocontact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiptophone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFreightcarrier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerpo1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlacardsrequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlacardssupplied = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PersistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.dgvShipments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShipments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl5.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.dgLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.dgvCarrier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.grPickedOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPickedOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPickedOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShipmentItems, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FormCaption.MainView = Me.GridView1
        Me.FormCaption.Name = "FormCaption"
        Me.FormCaption.Size = New System.Drawing.Size(1054, 33)
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
        Me.GridView1.GroupPanelText = "Shipments"
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAddShipment, Me.btnEditShipment, Me.btnDeleteShipment, Me.btnPrintBOL, Me.btnAddCarrier, Me.btnEditCarrier, Me.btnDeleteCarrier, Me.btnCreateShipmentFromWorkOrder, Me.btnGetPickedOrders, Me.eReportStartDate, Me.eReportEndDate, Me.btnReportProductsShipped, Me.btnAddNewLogisticsProvider, Me.btnEditLogisticsProvider, Me.btnDeleteLogisticsProvider, Me.rbtnGetShipments, Me.rbtnLoadCarrierData, Me.rbtnLoadLogisticsData, Me.BarButtonItem1, Me.rbtnMergeShipments})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 67
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage5, Me.RibbonPage4})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2, Me.RepositoryItemDateEdit1, Me.RepositoryItemDateEdit2})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1054, 115)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnAddShipment
        '
        Me.btnAddShipment.Caption = "Add New Shipment"
        Me.btnAddShipment.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddShipment.Id = 41
        Me.btnAddShipment.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddShipment.Name = "btnAddShipment"
        Me.btnAddShipment.Tag = "262"
        '
        'btnEditShipment
        '
        Me.btnEditShipment.Caption = "Edit Shipment"
        Me.btnEditShipment.Glyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditShipment.Id = 42
        Me.btnEditShipment.Name = "btnEditShipment"
        Me.btnEditShipment.Tag = "263"
        '
        'btnDeleteShipment
        '
        Me.btnDeleteShipment.Caption = "Delete Shipment"
        Me.btnDeleteShipment.Glyph = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteShipment.Id = 43
        Me.btnDeleteShipment.Name = "btnDeleteShipment"
        Me.btnDeleteShipment.Tag = "264"
        '
        'btnPrintBOL
        '
        Me.btnPrintBOL.Caption = "Print BOL"
        Me.btnPrintBOL.Glyph = Global.AOS.My.Resources.Resources.Printer
        Me.btnPrintBOL.Id = 48
        Me.btnPrintBOL.LargeGlyph = Global.AOS.My.Resources.Resources.Printer
        Me.btnPrintBOL.Name = "btnPrintBOL"
        Me.btnPrintBOL.Tag = "265"
        '
        'btnAddCarrier
        '
        Me.btnAddCarrier.Caption = "Add Carrier"
        Me.btnAddCarrier.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddCarrier.Id = 49
        Me.btnAddCarrier.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddCarrier.Name = "btnAddCarrier"
        Me.btnAddCarrier.Tag = "269"
        '
        'btnEditCarrier
        '
        Me.btnEditCarrier.Caption = "Edit Carrier"
        Me.btnEditCarrier.Glyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditCarrier.Id = 50
        Me.btnEditCarrier.Name = "btnEditCarrier"
        Me.btnEditCarrier.Tag = "270"
        '
        'btnDeleteCarrier
        '
        Me.btnDeleteCarrier.Caption = "Delete Carrier"
        Me.btnDeleteCarrier.Glyph = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteCarrier.Id = 51
        Me.btnDeleteCarrier.Name = "btnDeleteCarrier"
        Me.btnDeleteCarrier.Tag = "271"
        '
        'btnCreateShipmentFromWorkOrder
        '
        Me.btnCreateShipmentFromWorkOrder.Caption = "Create Shipment From Selected Work Orders"
        Me.btnCreateShipmentFromWorkOrder.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnCreateShipmentFromWorkOrder.Id = 52
        Me.btnCreateShipmentFromWorkOrder.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnCreateShipmentFromWorkOrder.Name = "btnCreateShipmentFromWorkOrder"
        Me.btnCreateShipmentFromWorkOrder.Tag = "267"
        '
        'btnGetPickedOrders
        '
        Me.btnGetPickedOrders.Caption = "Get Picked Items"
        Me.btnGetPickedOrders.Id = 53
        Me.btnGetPickedOrders.LargeGlyph = Global.AOS.My.Resources.Resources.FindRecord
        Me.btnGetPickedOrders.Name = "btnGetPickedOrders"
        Me.btnGetPickedOrders.Tag = "266"
        '
        'eReportStartDate
        '
        Me.eReportStartDate.Caption = "Start Date    "
        Me.eReportStartDate.Edit = Me.RepositoryItemDateEdit1
        Me.eReportStartDate.Id = 56
        Me.eReportStartDate.Name = "eReportStartDate"
        Me.eReportStartDate.Width = 80
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'eReportEndDate
        '
        Me.eReportEndDate.Caption = "End Date      "
        Me.eReportEndDate.Edit = Me.RepositoryItemDateEdit2
        Me.eReportEndDate.Id = 57
        Me.eReportEndDate.Name = "eReportEndDate"
        Me.eReportEndDate.Width = 80
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'btnReportProductsShipped
        '
        Me.btnReportProductsShipped.Caption = "Products Shipped"
        Me.btnReportProductsShipped.Glyph = Global.AOS.My.Resources.Resources.Report1
        Me.btnReportProductsShipped.Id = 58
        Me.btnReportProductsShipped.LargeGlyph = Global.AOS.My.Resources.Resources.Report1
        Me.btnReportProductsShipped.Name = "btnReportProductsShipped"
        Me.btnReportProductsShipped.Tag = "276"
        '
        'btnAddNewLogisticsProvider
        '
        Me.btnAddNewLogisticsProvider.Caption = "Add Logistics Provider"
        Me.btnAddNewLogisticsProvider.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddNewLogisticsProvider.Id = 59
        Me.btnAddNewLogisticsProvider.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddNewLogisticsProvider.Name = "btnAddNewLogisticsProvider"
        Me.btnAddNewLogisticsProvider.Tag = "273"
        '
        'btnEditLogisticsProvider
        '
        Me.btnEditLogisticsProvider.Caption = "Edit Logistics Provider"
        Me.btnEditLogisticsProvider.Glyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditLogisticsProvider.Id = 60
        Me.btnEditLogisticsProvider.Name = "btnEditLogisticsProvider"
        Me.btnEditLogisticsProvider.Tag = "274"
        '
        'btnDeleteLogisticsProvider
        '
        Me.btnDeleteLogisticsProvider.Caption = "Delete Logistics Provider"
        Me.btnDeleteLogisticsProvider.Glyph = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteLogisticsProvider.Id = 61
        Me.btnDeleteLogisticsProvider.Name = "btnDeleteLogisticsProvider"
        Me.btnDeleteLogisticsProvider.Tag = "275"
        '
        'rbtnGetShipments
        '
        Me.rbtnGetShipments.Caption = "Load Shipment Data"
        Me.rbtnGetShipments.Id = 62
        Me.rbtnGetShipments.LargeGlyph = Global.AOS.My.Resources.Resources.filter_find
        Me.rbtnGetShipments.Name = "rbtnGetShipments"
        Me.rbtnGetShipments.Tag = "261"
        '
        'rbtnLoadCarrierData
        '
        Me.rbtnLoadCarrierData.Caption = "Load Carrier Data"
        Me.rbtnLoadCarrierData.Id = 63
        Me.rbtnLoadCarrierData.LargeGlyph = Global.AOS.My.Resources.Resources.filter_find
        Me.rbtnLoadCarrierData.Name = "rbtnLoadCarrierData"
        Me.rbtnLoadCarrierData.Tag = "268"
        '
        'rbtnLoadLogisticsData
        '
        Me.rbtnLoadLogisticsData.Caption = "Load Logistics Providers"
        Me.rbtnLoadLogisticsData.Id = 64
        Me.rbtnLoadLogisticsData.LargeGlyph = Global.AOS.My.Resources.Resources.filter_find
        Me.rbtnLoadLogisticsData.Name = "rbtnLoadLogisticsData"
        Me.rbtnLoadLogisticsData.Tag = "272"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "BarButtonItem1"
        Me.BarButtonItem1.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.BarButtonItem1.Id = 65
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'rbtnMergeShipments
        '
        Me.rbtnMergeShipments.Caption = "Merge Two Shipments"
        Me.rbtnMergeShipments.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnMergeShipments.Id = 66
        Me.rbtnMergeShipments.LargeGlyph = Global.AOS.My.Resources.Resources.Quarantine
        Me.rbtnMergeShipments.Name = "rbtnMergeShipments"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "114"
        Me.RibbonPage1.Text = "Shipments"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnGetShipments)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddShipment, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditShipment)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDeleteShipment)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnMergeShipments, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Manage Shipments"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnPrintBOL)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Report"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4, Me.RibbonPageGroup5})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Tag = "115"
        Me.RibbonPage2.Text = "Picked Items"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnGetPickedOrders)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Data"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnCreateShipmentFromWorkOrder)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Process"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Tag = "116"
        Me.RibbonPage3.Text = "Freight Carriers"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnLoadCarrierData)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnAddCarrier, True)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnEditCarrier)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.btnDeleteCarrier)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Manage"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup9})
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Tag = "117"
        Me.RibbonPage5.Text = "Logistics Providers"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.AllowTextClipping = False
        Me.RibbonPageGroup9.ItemLinks.Add(Me.rbtnLoadLogisticsData)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.btnAddNewLogisticsProvider, True)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.btnEditLogisticsProvider)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.btnDeleteLogisticsProvider)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.ShowCaptionButton = False
        Me.RibbonPageGroup9.Text = "Manage"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup7, Me.RibbonPageGroup8})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Tag = "118"
        Me.RibbonPage4.Text = "Reports"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.ItemLinks.Add(Me.eReportStartDate)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.eReportEndDate)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Parameters"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.AllowTextClipping = False
        Me.RibbonPageGroup8.ItemLinks.Add(Me.btnReportProductsShipped)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Reports"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'WorkPanelsHolder
        '
        Me.WorkPanelsHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl6)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 148)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1054, 510)
        Me.WorkPanelsHolder.TabIndex = 7
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Controls.Add(Me.GroupControl2)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.LookAndFeel.SkinName = "DevExpress Dark Style"
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1054, 510)
        Me.RibbonPanelControl1.TabIndex = 0
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.PanelControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1038, 494)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Shipment Information"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.dgvShipments)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(2, 21)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1034, 471)
        Me.PanelControl1.TabIndex = 0
        '
        'dgvShipments
        '
        Me.dgvShipments.DataSource = Me.bsShipments
        Me.dgvShipments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvShipments.Location = New System.Drawing.Point(0, 0)
        Me.dgvShipments.MainView = Me.GridView3
        Me.dgvShipments.Name = "dgvShipments"
        Me.dgvShipments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.dgvShipments.Size = New System.Drawing.Size(1034, 471)
        Me.dgvShipments.TabIndex = 0
        Me.dgvShipments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3, Me.GridView4})
        '
        'bsShipments
        '
        Me.bsShipments.DataSource = GetType(AOS.BusinessObjects.ViewShipmentInfoCollection)
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colShipmentnumber, Me.colShipmentdate, Me.colCustomername1, Me.colShipperName, Me.colConsigneeName, Me.colFreightcarrier1, Me.colFob1, Me.colContainers, Me.colWeight, Me.colKeepfromfreezing})
        Me.GridView3.GridControl = Me.dgvShipments
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView3.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colShipmentnumber
        '
        Me.colShipmentnumber.Caption = "Shipment#"
        Me.colShipmentnumber.FieldName = "Shipmentnumber"
        Me.colShipmentnumber.Name = "colShipmentnumber"
        Me.colShipmentnumber.Visible = True
        Me.colShipmentnumber.VisibleIndex = 0
        Me.colShipmentnumber.Width = 69
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
        Me.colShipmentdate.Width = 72
        '
        'colCustomername1
        '
        Me.colCustomername1.Caption = "Customer"
        Me.colCustomername1.FieldName = "Customername"
        Me.colCustomername1.Name = "colCustomername1"
        Me.colCustomername1.Visible = True
        Me.colCustomername1.VisibleIndex = 2
        Me.colCustomername1.Width = 135
        '
        'colShipperName
        '
        Me.colShipperName.FieldName = "ShipperName"
        Me.colShipperName.Name = "colShipperName"
        Me.colShipperName.Visible = True
        Me.colShipperName.VisibleIndex = 3
        Me.colShipperName.Width = 138
        '
        'colConsigneeName
        '
        Me.colConsigneeName.FieldName = "ConsigneeName"
        Me.colConsigneeName.Name = "colConsigneeName"
        Me.colConsigneeName.Visible = True
        Me.colConsigneeName.VisibleIndex = 4
        Me.colConsigneeName.Width = 133
        '
        'colFreightcarrier1
        '
        Me.colFreightcarrier1.Caption = "Carrier"
        Me.colFreightcarrier1.FieldName = "Freightcarrier"
        Me.colFreightcarrier1.Name = "colFreightcarrier1"
        Me.colFreightcarrier1.Visible = True
        Me.colFreightcarrier1.VisibleIndex = 7
        Me.colFreightcarrier1.Width = 125
        '
        'colFob1
        '
        Me.colFob1.Caption = "FOB"
        Me.colFob1.FieldName = "Fob"
        Me.colFob1.Name = "colFob1"
        Me.colFob1.Visible = True
        Me.colFob1.VisibleIndex = 8
        Me.colFob1.Width = 74
        '
        'colContainers
        '
        Me.colContainers.Caption = "Qty Containers"
        Me.colContainers.FieldName = "Containers"
        Me.colContainers.Name = "colContainers"
        Me.colContainers.Visible = True
        Me.colContainers.VisibleIndex = 5
        Me.colContainers.Width = 80
        '
        'colWeight
        '
        Me.colWeight.Caption = "Total Weight"
        Me.colWeight.DisplayFormat.FormatString = "n"
        Me.colWeight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colWeight.FieldName = "Weight"
        Me.colWeight.Name = "colWeight"
        Me.colWeight.Visible = True
        Me.colWeight.VisibleIndex = 6
        Me.colWeight.Width = 71
        '
        'colKeepfromfreezing
        '
        Me.colKeepfromfreezing.Caption = "Freeze Protect"
        Me.colKeepfromfreezing.FieldName = "Keepfromfreezing"
        Me.colKeepfromfreezing.Name = "colKeepfromfreezing"
        Me.colKeepfromfreezing.Visible = True
        Me.colKeepfromfreezing.VisibleIndex = 9
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcountry", "Country", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsCustomers
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "Custname"
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.dgvShipments
        Me.GridView4.Name = "GridView4"
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Controls.Add(Me.GroupControl6)
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(1054, 510)
        Me.RibbonPanelControl5.TabIndex = 1
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.dgLogistics)
        Me.GroupControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl6.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(1050, 506)
        Me.GroupControl6.TabIndex = 1
        Me.GroupControl6.Text = "Logistics Providers"
        '
        'dgLogistics
        '
        Me.dgLogistics.DataSource = Me.bsLogistics
        Me.dgLogistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLogistics.Location = New System.Drawing.Point(2, 21)
        Me.dgLogistics.MainView = Me.GridView10
        Me.dgLogistics.Name = "dgLogistics"
        Me.dgLogistics.Size = New System.Drawing.Size(1046, 483)
        Me.dgLogistics.TabIndex = 0
        Me.dgLogistics.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView10, Me.GridView11})
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'GridView10
        '
        Me.GridView10.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLogisticsid, Me.colLogisticsname, Me.colLogisticsaddr1, Me.colLogisticsaddr2, Me.colLogisticscity, Me.colLogisticsstate, Me.colLogisticszip, Me.colLogisticsphone, Me.colLogisticscontact})
        Me.GridView10.GridControl = Me.dgLogistics
        Me.GridView10.Name = "GridView10"
        '
        'colLogisticsid
        '
        Me.colLogisticsid.FieldName = "Logisticsid"
        Me.colLogisticsid.Name = "colLogisticsid"
        Me.colLogisticsid.Visible = True
        Me.colLogisticsid.VisibleIndex = 0
        '
        'colLogisticsname
        '
        Me.colLogisticsname.FieldName = "Logisticsname"
        Me.colLogisticsname.Name = "colLogisticsname"
        Me.colLogisticsname.Visible = True
        Me.colLogisticsname.VisibleIndex = 1
        '
        'colLogisticsaddr1
        '
        Me.colLogisticsaddr1.FieldName = "Logisticsaddr1"
        Me.colLogisticsaddr1.Name = "colLogisticsaddr1"
        Me.colLogisticsaddr1.Visible = True
        Me.colLogisticsaddr1.VisibleIndex = 2
        '
        'colLogisticsaddr2
        '
        Me.colLogisticsaddr2.FieldName = "Logisticsaddr2"
        Me.colLogisticsaddr2.Name = "colLogisticsaddr2"
        Me.colLogisticsaddr2.Visible = True
        Me.colLogisticsaddr2.VisibleIndex = 3
        '
        'colLogisticscity
        '
        Me.colLogisticscity.FieldName = "Logisticscity"
        Me.colLogisticscity.Name = "colLogisticscity"
        Me.colLogisticscity.Visible = True
        Me.colLogisticscity.VisibleIndex = 4
        '
        'colLogisticsstate
        '
        Me.colLogisticsstate.FieldName = "Logisticsstate"
        Me.colLogisticsstate.Name = "colLogisticsstate"
        Me.colLogisticsstate.Visible = True
        Me.colLogisticsstate.VisibleIndex = 5
        '
        'colLogisticszip
        '
        Me.colLogisticszip.FieldName = "Logisticszip"
        Me.colLogisticszip.Name = "colLogisticszip"
        Me.colLogisticszip.Visible = True
        Me.colLogisticszip.VisibleIndex = 6
        '
        'colLogisticsphone
        '
        Me.colLogisticsphone.FieldName = "Logisticsphone"
        Me.colLogisticsphone.Name = "colLogisticsphone"
        Me.colLogisticsphone.Visible = True
        Me.colLogisticsphone.VisibleIndex = 7
        '
        'colLogisticscontact
        '
        Me.colLogisticscontact.FieldName = "Logisticscontact"
        Me.colLogisticscontact.Name = "colLogisticscontact"
        Me.colLogisticscontact.Visible = True
        Me.colLogisticscontact.VisibleIndex = 8
        '
        'GridView11
        '
        Me.GridView11.GridControl = Me.dgLogistics
        Me.GridView11.Name = "GridView11"
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1054, 510)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.GroupControl4)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1054, 510)
        Me.RibbonPanelControl3.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.dgvCarrier)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1050, 506)
        Me.GroupControl4.TabIndex = 0
        Me.GroupControl4.Text = "GroupControl4"
        '
        'dgvCarrier
        '
        Me.dgvCarrier.DataSource = Me.bsCarriers
        Me.dgvCarrier.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCarrier.Location = New System.Drawing.Point(2, 21)
        Me.dgvCarrier.MainView = Me.GridView6
        Me.dgvCarrier.Name = "dgvCarrier"
        Me.dgvCarrier.Size = New System.Drawing.Size(1046, 483)
        Me.dgvCarrier.TabIndex = 0
        Me.dgvCarrier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6, Me.GridView7})
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'GridView6
        '
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCarrierID, Me.colCarrierName, Me.colCarrierCity, Me.colCarrierState, Me.colCarrierContactName, Me.colTermsCarrier})
        Me.GridView6.GridControl = Me.dgvCarrier
        Me.GridView6.Name = "GridView6"
        '
        'colCarrierID
        '
        Me.colCarrierID.Caption = "Carrier ID"
        Me.colCarrierID.FieldName = "CarrierID"
        Me.colCarrierID.Name = "colCarrierID"
        Me.colCarrierID.Visible = True
        Me.colCarrierID.VisibleIndex = 0
        '
        'colCarrierName
        '
        Me.colCarrierName.Caption = "Carrier Name"
        Me.colCarrierName.FieldName = "CarrierName"
        Me.colCarrierName.Name = "colCarrierName"
        Me.colCarrierName.Visible = True
        Me.colCarrierName.VisibleIndex = 1
        '
        'colCarrierCity
        '
        Me.colCarrierCity.Caption = "City"
        Me.colCarrierCity.FieldName = "CarrierCity"
        Me.colCarrierCity.Name = "colCarrierCity"
        Me.colCarrierCity.Visible = True
        Me.colCarrierCity.VisibleIndex = 2
        '
        'colCarrierState
        '
        Me.colCarrierState.Caption = "State"
        Me.colCarrierState.FieldName = "CarrierState"
        Me.colCarrierState.Name = "colCarrierState"
        Me.colCarrierState.Visible = True
        Me.colCarrierState.VisibleIndex = 3
        '
        'colCarrierContactName
        '
        Me.colCarrierContactName.Caption = "Contact"
        Me.colCarrierContactName.FieldName = "CarrierContactName"
        Me.colCarrierContactName.Name = "colCarrierContactName"
        Me.colCarrierContactName.Visible = True
        Me.colCarrierContactName.VisibleIndex = 4
        Me.colCarrierContactName.Width = 151
        '
        'colTermsCarrier
        '
        Me.colTermsCarrier.Caption = "Terms"
        Me.colTermsCarrier.FieldName = "TermsCarrier"
        Me.colTermsCarrier.Name = "colTermsCarrier"
        Me.colTermsCarrier.Visible = True
        Me.colTermsCarrier.VisibleIndex = 5
        Me.colTermsCarrier.Width = 213
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.dgvCarrier
        Me.GridView7.Name = "GridView7"
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Controls.Add(Me.GroupControl5)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1054, 510)
        Me.RibbonPanelControl2.TabIndex = 1
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.grPickedOrders)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1050, 506)
        Me.GroupControl5.TabIndex = 0
        Me.GroupControl5.Text = "Picked Work Orders"
        '
        'grPickedOrders
        '
        Me.grPickedOrders.DataSource = Me.bsPickedOrders
        Me.grPickedOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPickedOrders.Location = New System.Drawing.Point(2, 21)
        Me.grPickedOrders.MainView = Me.grvPickedOrders
        Me.grPickedOrders.Name = "grPickedOrders"
        Me.grPickedOrders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit6})
        Me.grPickedOrders.Size = New System.Drawing.Size(1046, 483)
        Me.grPickedOrders.TabIndex = 1
        Me.grPickedOrders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPickedOrders})
        '
        'bsPickedOrders
        '
        Me.bsPickedOrders.DataSource = GetType(AOS.BusinessObjects.ViewPickedWorkOrdersCollection)
        '
        'grvPickedOrders
        '
        Me.grvPickedOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWorkordernumber, Me.colCustname, Me.colPlannedshipdate, Me.colDeliverydate, Me.colFob2, Me.colTotalContainers, Me.colOrdernotes, Me.colCustomerpo})
        Me.grvPickedOrders.GridControl = Me.grPickedOrders
        Me.grvPickedOrders.Name = "grvPickedOrders"
        Me.grvPickedOrders.OptionsBehavior.Editable = False
        Me.grvPickedOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvPickedOrders.OptionsSelection.MultiSelect = True
        Me.grvPickedOrders.OptionsView.ShowGroupPanel = False
        Me.grvPickedOrders.ViewCaption = "OPEN Work Orders"
        '
        'colWorkordernumber
        '
        Me.colWorkordernumber.Caption = "WO#"
        Me.colWorkordernumber.FieldName = "Workordernumber"
        Me.colWorkordernumber.Name = "colWorkordernumber"
        Me.colWorkordernumber.Visible = True
        Me.colWorkordernumber.VisibleIndex = 0
        Me.colWorkordernumber.Width = 54
        '
        'colCustname
        '
        Me.colCustname.Caption = "Customer Name"
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 1
        Me.colCustname.Width = 193
        '
        'colPlannedshipdate
        '
        Me.colPlannedshipdate.Caption = "Planned Ship"
        Me.colPlannedshipdate.FieldName = "Plannedshipdate"
        Me.colPlannedshipdate.Name = "colPlannedshipdate"
        Me.colPlannedshipdate.Visible = True
        Me.colPlannedshipdate.VisibleIndex = 3
        Me.colPlannedshipdate.Width = 80
        '
        'colDeliverydate
        '
        Me.colDeliverydate.Caption = "Delivery"
        Me.colDeliverydate.FieldName = "Deliverydate"
        Me.colDeliverydate.Name = "colDeliverydate"
        Me.colDeliverydate.Visible = True
        Me.colDeliverydate.VisibleIndex = 4
        Me.colDeliverydate.Width = 70
        '
        'colFob2
        '
        Me.colFob2.Caption = "FOB"
        Me.colFob2.FieldName = "Fob"
        Me.colFob2.Name = "colFob2"
        Me.colFob2.Visible = True
        Me.colFob2.VisibleIndex = 5
        Me.colFob2.Width = 108
        '
        'colTotalContainers
        '
        Me.colTotalContainers.Caption = "Containers"
        Me.colTotalContainers.FieldName = "TotalContainers"
        Me.colTotalContainers.Name = "colTotalContainers"
        Me.colTotalContainers.Visible = True
        Me.colTotalContainers.VisibleIndex = 6
        Me.colTotalContainers.Width = 67
        '
        'colOrdernotes
        '
        Me.colOrdernotes.Caption = "Order Notes"
        Me.colOrdernotes.FieldName = "Ordernotes"
        Me.colOrdernotes.Name = "colOrdernotes"
        Me.colOrdernotes.Visible = True
        Me.colOrdernotes.VisibleIndex = 7
        Me.colOrdernotes.Width = 217
        '
        'colCustomerpo
        '
        Me.colCustomerpo.Caption = "Customer PO"
        Me.colCustomerpo.FieldName = "Customerpo"
        Me.colCustomerpo.Name = "colCustomerpo"
        Me.colCustomerpo.Visible = True
        Me.colCustomerpo.VisibleIndex = 2
        Me.colCustomerpo.Width = 106
        '
        'RepositoryItemLookUpEdit6
        '
        Me.RepositoryItemLookUpEdit6.AutoHeight = False
        Me.RepositoryItemLookUpEdit6.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit6.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit6.Name = "RepositoryItemLookUpEdit6"
        Me.RepositoryItemLookUpEdit6.NullText = ""
        Me.RepositoryItemLookUpEdit6.ShowPopupShadow = False
        Me.RepositoryItemLookUpEdit6.ValueMember = "Custid"
        '
        'RibbonPanelControl6
        '
        Me.RibbonPanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl6.Name = "RibbonPanelControl6"
        Me.RibbonPanelControl6.Size = New System.Drawing.Size(1054, 510)
        Me.RibbonPanelControl6.TabIndex = 1
        '
        'bsShipmentItems
        '
        Me.bsShipmentItems.DataSource = GetType(AOS.BusinessObjects.ShipmentdetailCollection)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'colWorkordernumber1
        '
        Me.colWorkordernumber1.FieldName = "Workordernumber"
        Me.colWorkordernumber1.Name = "colWorkordernumber1"
        '
        'colCustid1
        '
        Me.colCustid1.FieldName = "Custid"
        Me.colCustid1.Name = "colCustid1"
        '
        'colCustomername
        '
        Me.colCustomername.FieldName = "Customername"
        Me.colCustomername.Name = "colCustomername"
        '
        'colShipfromid
        '
        Me.colShipfromid.FieldName = "Shipfromid"
        Me.colShipfromid.Name = "colShipfromid"
        '
        'colShipfromname
        '
        Me.colShipfromname.FieldName = "Shipfromname"
        Me.colShipfromname.Name = "colShipfromname"
        '
        'colShipfromaddress1
        '
        Me.colShipfromaddress1.FieldName = "Shipfromaddress1"
        Me.colShipfromaddress1.Name = "colShipfromaddress1"
        '
        'colShipfromaddress2
        '
        Me.colShipfromaddress2.FieldName = "Shipfromaddress2"
        Me.colShipfromaddress2.Name = "colShipfromaddress2"
        '
        'colShipfromcity
        '
        Me.colShipfromcity.FieldName = "Shipfromcity"
        Me.colShipfromcity.Name = "colShipfromcity"
        '
        'colShipfromstateprov
        '
        Me.colShipfromstateprov.FieldName = "Shipfromstateprov"
        Me.colShipfromstateprov.Name = "colShipfromstateprov"
        '
        'colShipfrompostalcode
        '
        Me.colShipfrompostalcode.FieldName = "Shipfrompostalcode"
        Me.colShipfrompostalcode.Name = "colShipfrompostalcode"
        '
        'colShipfromcountry
        '
        Me.colShipfromcountry.FieldName = "Shipfromcountry"
        Me.colShipfromcountry.Name = "colShipfromcountry"
        '
        'colShipfromphone
        '
        Me.colShipfromphone.FieldName = "Shipfromphone"
        Me.colShipfromphone.Name = "colShipfromphone"
        '
        'colShipfromfax
        '
        Me.colShipfromfax.FieldName = "Shipfromfax"
        Me.colShipfromfax.Name = "colShipfromfax"
        '
        'colShipfromcontact
        '
        Me.colShipfromcontact.FieldName = "Shipfromcontact"
        Me.colShipfromcontact.Name = "colShipfromcontact"
        '
        'colShiptoid
        '
        Me.colShiptoid.FieldName = "Shiptoid"
        Me.colShiptoid.Name = "colShiptoid"
        '
        'colShiptoname
        '
        Me.colShiptoname.FieldName = "Shiptoname"
        Me.colShiptoname.Name = "colShiptoname"
        '
        'colShiptoaddress1
        '
        Me.colShiptoaddress1.FieldName = "Shiptoaddress1"
        Me.colShiptoaddress1.Name = "colShiptoaddress1"
        '
        'colShiptoaddress2
        '
        Me.colShiptoaddress2.FieldName = "Shiptoaddress2"
        Me.colShiptoaddress2.Name = "colShiptoaddress2"
        '
        'colShiptocity
        '
        Me.colShiptocity.FieldName = "Shiptocity"
        Me.colShiptocity.Name = "colShiptocity"
        '
        'colShiptostateprov
        '
        Me.colShiptostateprov.FieldName = "Shiptostateprov"
        Me.colShiptostateprov.Name = "colShiptostateprov"
        '
        'colShiptopostalcode
        '
        Me.colShiptopostalcode.FieldName = "Shiptopostalcode"
        Me.colShiptopostalcode.Name = "colShiptopostalcode"
        '
        'colShiptocountry
        '
        Me.colShiptocountry.FieldName = "Shiptocountry"
        Me.colShiptocountry.Name = "colShiptocountry"
        '
        'colShiptocontact
        '
        Me.colShiptocontact.FieldName = "Shiptocontact"
        Me.colShiptocontact.Name = "colShiptocontact"
        '
        'colShiptophone
        '
        Me.colShiptophone.FieldName = "Shiptophone"
        Me.colShiptophone.Name = "colShiptophone"
        '
        'colCarrierid1
        '
        Me.colCarrierid1.FieldName = "Carrierid"
        Me.colCarrierid1.Name = "colCarrierid1"
        '
        'colFreightcarrier
        '
        Me.colFreightcarrier.FieldName = "Freightcarrier"
        Me.colFreightcarrier.Name = "colFreightcarrier"
        '
        'colFob
        '
        Me.colFob.FieldName = "Fob"
        Me.colFob.Name = "colFob"
        '
        'colCustomerpo1
        '
        Me.colCustomerpo1.FieldName = "Customerpo"
        Me.colCustomerpo1.Name = "colCustomerpo1"
        '
        'colPlacardsrequired
        '
        Me.colPlacardsrequired.FieldName = "Placardsrequired"
        Me.colPlacardsrequired.Name = "colPlacardsrequired"
        '
        'colPlacardssupplied
        '
        Me.colPlacardssupplied.FieldName = "Placardssupplied"
        Me.colPlacardssupplied.Name = "colPlacardssupplied"
        '
        'colShipmentstatus
        '
        Me.colShipmentstatus.FieldName = "Shipmentstatus"
        Me.colShipmentstatus.Name = "colShipmentstatus"
        '
        'colLogisticsid1
        '
        Me.colLogisticsid1.FieldName = "Logisticsid"
        Me.colLogisticsid1.Name = "colLogisticsid1"
        '
        'colComments
        '
        Me.colComments.FieldName = "Comments"
        Me.colComments.Name = "colComments"
        '
        'Timer2
        '
        '
        'viewShipping
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.DoubleBuffered = True
        Me.Name = "viewShipping"
        Me.Size = New System.Drawing.Size(1054, 658)
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.dgvShipments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShipments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl5.ResumeLayout(False)
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        CType(Me.dgLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.dgvCarrier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.grPickedOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPickedOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPickedOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShipmentItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAddShipment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditShipment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteShipment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsShipments As System.Windows.Forms.BindingSource
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsShipmentItems As System.Windows.Forms.BindingSource
    Friend WithEvents bsPickedOrders As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgvCarrier As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As CustomDevExGridView
    Friend WithEvents GridView7 As CustomDevExGridView
    Friend WithEvents colCarrierID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierCity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierState As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierContactName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnPrintBOL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddCarrier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCarrier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCarrier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCreateShipmentFromWorkOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colTermsCarrier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grPickedOrders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPickedOrders As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents btnGetPickedOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eReportStartDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents eReportEndDate As DevExpress.XtraBars.BarEditItem
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents btnReportProductsShipped As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnAddNewLogisticsProvider As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditLogisticsProvider As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteLogisticsProvider As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents dgLogistics As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents GridView10 As CustomDevExGridView
    Friend WithEvents colLogisticsid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsaddr1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsaddr2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticscity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsstate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticszip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticscontact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView11 As CustomDevExGridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents dgvShipments As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As CustomDevExGridView
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents colWorkordernumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomername As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromaddress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromaddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromcity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromstateprov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfrompostalcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromcountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromphone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromfax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipfromcontact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptoid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptoname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptoaddress1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptoaddress2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptocity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptostateprov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptopostalcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptocountry As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptocontact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiptophone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFreightcarrier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerpo1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlacardsrequired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlacardssupplied As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomername1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipperName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colConsigneeName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFreightcarrier1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFob1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnGetShipments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents rbtnLoadCarrierData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnLoadLogisticsData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colWorkordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlannedshipdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeliverydate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFob2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalContainers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrdernotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerpo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnMergeShipments As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PersistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository
    Friend WithEvents colKeepfromfreezing As DevExpress.XtraGrid.Columns.GridColumn

End Class
