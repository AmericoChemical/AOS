<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceivingPurchase

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
        Dim CustorderdateLabel As System.Windows.Forms.Label
        Dim OrderstatusLabel As System.Windows.Forms.Label
        Dim OrdertermsLabel As System.Windows.Forms.Label
        Dim SuppliercompanyLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim OrdernotesLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceivingPurchase))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAllocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnallocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCOAText = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.WorkPanelsHolder2 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.gcReceivedItems = New DevExpress.XtraGrid.GridControl()
        Me.bsReceivedItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit5 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grInventoryItems = New DevExpress.XtraGrid.GridControl()
        Me.bsInventoryItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvInventoryItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colSourcedoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grPurchaseItems = New DevExpress.XtraGrid.GridControl()
        Me.bsPurchaseItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvPurchaseItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.colPurchaseitemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SourceType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrchSourcedoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnReceiveInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.btnQuantityDelivered = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRetrievePurchaseItems = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnForceRCVDHOLD = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PurchaseDateTextEdit = New DevExpress.XtraEditors.DateEdit()
        Me.bsPurchase = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpectedInDateTextEdit = New DevExpress.XtraEditors.DateEdit()
        Me.WorkordernumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendorTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsVendor = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomPurchaseNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eInstructions = New DevExpress.XtraEditors.MemoEdit()
        Me.PurchaseTypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.OrdertermsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ePOStatus = New DevExpress.XtraEditors.TextEdit()
        Me.colExpectedindate = New DevExpress.XtraGrid.Columns.GridColumn()
        CustorderdateLabel = New System.Windows.Forms.Label()
        OrderstatusLabel = New System.Windows.Forms.Label()
        OrdertermsLabel = New System.Windows.Forms.Label()
        SuppliercompanyLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        OrdernotesLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.WorkPanelsHolder2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder2.SuspendLayout()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.gcReceivedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsReceivedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvInventoryItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.grPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPurchaseItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PurchaseDateTextEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedInDateTextEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpectedInDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomPurchaseNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInstructions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdertermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePOStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustorderdateLabel
        '
        CustorderdateLabel.AutoSize = True
        CustorderdateLabel.Location = New System.Drawing.Point(206, 35)
        CustorderdateLabel.Name = "CustorderdateLabel"
        CustorderdateLabel.Size = New System.Drawing.Size(30, 13)
        CustorderdateLabel.TabIndex = 3
        CustorderdateLabel.Text = "Date"
        '
        'OrderstatusLabel
        '
        OrderstatusLabel.AutoSize = True
        OrderstatusLabel.Location = New System.Drawing.Point(568, 36)
        OrderstatusLabel.Name = "OrderstatusLabel"
        OrderstatusLabel.Size = New System.Drawing.Size(38, 13)
        OrderstatusLabel.TabIndex = 13
        OrderstatusLabel.Text = "Status"
        '
        'OrdertermsLabel
        '
        OrdertermsLabel.AutoSize = True
        OrdertermsLabel.Location = New System.Drawing.Point(405, 62)
        OrdertermsLabel.Name = "OrdertermsLabel"
        OrdertermsLabel.Size = New System.Drawing.Size(36, 13)
        OrdertermsLabel.TabIndex = 15
        OrdertermsLabel.Text = "Terms"
        '
        'SuppliercompanyLabel
        '
        SuppliercompanyLabel.AutoSize = True
        SuppliercompanyLabel.Location = New System.Drawing.Point(22, 62)
        SuppliercompanyLabel.Name = "SuppliercompanyLabel"
        SuppliercompanyLabel.Size = New System.Drawing.Size(41, 13)
        SuppliercompanyLabel.TabIndex = 5
        SuppliercompanyLabel.Text = "Vendor"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(393, 36)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(48, 13)
        Label1.TabIndex = 11
        Label1.Text = "PO Type"
        '
        'OrdernotesLabel
        '
        OrdernotesLabel.Location = New System.Drawing.Point(22, 112)
        OrdernotesLabel.Name = "OrdernotesLabel"
        OrdernotesLabel.Size = New System.Drawing.Size(67, 42)
        OrdernotesLabel.TabIndex = 17
        OrdernotesLabel.Text = "Special Instructions"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(22, 35)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(61, 13)
        Label3.TabIndex = 1
        Label3.Text = "PO Number"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(22, 88)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 13)
        Label4.TabIndex = 8
        Label4.Text = "Customer"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(747, 60)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(65, 13)
        Label5.TabIndex = 19
        Label5.Text = "Expected In"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(749, 36)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(63, 13)
        Label6.TabIndex = 28
        Label6.Text = "Vend Ord #"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnClose, Me.btnEditPOItem, Me.btnAllocate, Me.btnUnallocate, Me.btnCOAText})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 14
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1156, 95)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 1
        Me.btnClose.LargeImageIndex = 0
        Me.btnClose.Name = "btnClose"
        '
        'btnEditPOItem
        '
        Me.btnEditPOItem.Caption = "Edit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Item"
        Me.btnEditPOItem.Id = 3
        Me.btnEditPOItem.LargeGlyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditPOItem.Name = "btnEditPOItem"
        '
        'btnAllocate
        '
        Me.btnAllocate.Caption = "Allocate"
        Me.btnAllocate.Id = 6
        Me.btnAllocate.LargeGlyph = Global.AOS.My.Resources.Resources.Quarantine
        Me.btnAllocate.Name = "btnAllocate"
        '
        'btnUnallocate
        '
        Me.btnUnallocate.Caption = "Unallocate"
        Me.btnUnallocate.Id = 7
        Me.btnUnallocate.LargeGlyph = Global.AOS.My.Resources.Resources.Unquarantine
        Me.btnUnallocate.Name = "btnUnallocate"
        '
        'btnCOAText
        '
        Me.btnCOAText.Caption = "COA Text"
        Me.btnCOAText.Id = 11
        Me.btnCOAText.LargeGlyph = Global.AOS.My.Resources.Resources.document_edit
        Me.btnCOAText.Name = "btnCOAText"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Purchase Order"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1156, 614)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl4.Controls.Add(Me.WorkPanelsHolder2)
        Me.GroupControl4.Controls.Add(Me.RibbonControl2)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 192)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1156, 422)
        Me.GroupControl4.TabIndex = 6
        Me.GroupControl4.Text = "Work Order Items"
        '
        'WorkPanelsHolder2
        '
        Me.WorkPanelsHolder2.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder2.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder2.Location = New System.Drawing.Point(0, 117)
        Me.WorkPanelsHolder2.Name = "WorkPanelsHolder2"
        Me.WorkPanelsHolder2.Size = New System.Drawing.Size(1156, 305)
        Me.WorkPanelsHolder2.TabIndex = 1
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Controls.Add(Me.GroupControl3)
        Me.RibbonPanelControl2.Controls.Add(Me.GroupControl2)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1152, 301)
        Me.RibbonPanelControl2.TabIndex = 0
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.gcReceivedItems)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 149)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1148, 150)
        Me.GroupControl3.TabIndex = 6
        Me.GroupControl3.Text = "Items Already Received"
        '
        'gcReceivedItems
        '
        Me.gcReceivedItems.DataSource = Me.bsReceivedItems
        Me.gcReceivedItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcReceivedItems.Location = New System.Drawing.Point(2, 22)
        Me.gcReceivedItems.LookAndFeel.SkinName = "Money Twins"
        Me.gcReceivedItems.MainView = Me.grvItems
        Me.gcReceivedItems.Name = "gcReceivedItems"
        Me.gcReceivedItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit6, Me.RepositoryItemHyperLinkEdit5})
        Me.gcReceivedItems.Size = New System.Drawing.Size(1144, 126)
        Me.gcReceivedItems.TabIndex = 5
        Me.gcReceivedItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvItems})
        '
        'bsReceivedItems
        '
        Me.bsReceivedItems.DataSource = GetType(AOS.BusinessObjects.ViewInvItemListCollection)
        '
        'grvItems
        '
        Me.grvItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.colItemStatus, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28})
        Me.grvItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvItems.GridControl = Me.gcReceivedItems
        Me.grvItems.Name = "grvItems"
        Me.grvItems.OptionsBehavior.Editable = False
        Me.grvItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvItems.OptionsSelection.MultiSelect = True
        Me.grvItems.OptionsView.ShowGroupPanel = False
        Me.grvItems.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn1.Caption = "Inv. Item #"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemHyperLinkEdit5
        Me.GridColumn1.FieldName = "Invitemnumber"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 67
        '
        'RepositoryItemHyperLinkEdit5
        '
        Me.RepositoryItemHyperLinkEdit5.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit5.Name = "RepositoryItemHyperLinkEdit5"
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn2.Caption = "Src Doc"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemHyperLinkEdit6
        Me.GridColumn2.FieldName = "Sourcedocument"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 50
        '
        'RepositoryItemHyperLinkEdit6
        '
        Me.RepositoryItemHyperLinkEdit6.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit6.Name = "RepositoryItemHyperLinkEdit6"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Item Type"
        Me.GridColumn19.FieldName = "Itemtype"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.OptionsColumn.FixedWidth = True
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 2
        Me.GridColumn19.Width = 60
        '
        'GridColumn20
        '
        Me.GridColumn20.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn20.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn20.Caption = "Item ID"
        Me.GridColumn20.FieldName = "Itemid"
        Me.GridColumn20.Name = "GridColumn20"
        Me.GridColumn20.Visible = True
        Me.GridColumn20.VisibleIndex = 3
        Me.GridColumn20.Width = 47
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Item Description"
        Me.GridColumn21.FieldName = "Itemdescription"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Visible = True
        Me.GridColumn21.VisibleIndex = 4
        Me.GridColumn21.Width = 386
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Container"
        Me.GridColumn22.FieldName = "Container"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.OptionsColumn.FixedWidth = True
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 5
        Me.GridColumn22.Width = 90
        '
        'colItemStatus
        '
        Me.colItemStatus.Caption = "Item Status"
        Me.colItemStatus.FieldName = "Itemstatus"
        Me.colItemStatus.Name = "colItemStatus"
        Me.colItemStatus.OptionsColumn.FixedWidth = True
        Me.colItemStatus.Visible = True
        Me.colItemStatus.VisibleIndex = 6
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Src Status"
        Me.GridColumn24.FieldName = "Sourcestatus"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.OptionsColumn.FixedWidth = True
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 7
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Lot #"
        Me.GridColumn25.FieldName = "Lotnumber"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.OptionsColumn.FixedWidth = True
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 8
        Me.GridColumn25.Width = 64
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Vendor Lbl Wgt"
        Me.GridColumn26.FieldName = "Vendorweight"
        Me.GridColumn26.Name = "GridColumn26"
        Me.GridColumn26.OptionsColumn.FixedWidth = True
        Me.GridColumn26.Visible = True
        Me.GridColumn26.VisibleIndex = 9
        Me.GridColumn26.Width = 82
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Rec Weight"
        Me.GridColumn27.FieldName = "Rcvdweight"
        Me.GridColumn27.Name = "GridColumn27"
        Me.GridColumn27.OptionsColumn.FixedWidth = True
        Me.GridColumn27.Visible = True
        Me.GridColumn27.VisibleIndex = 10
        Me.GridColumn27.Width = 65
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Inventory Class"
        Me.GridColumn28.FieldName = "LookupDesc"
        Me.GridColumn28.Name = "GridColumn28"
        Me.GridColumn28.OptionsColumn.FixedWidth = True
        Me.GridColumn28.Visible = True
        Me.GridColumn28.VisibleIndex = 11
        Me.GridColumn28.Width = 85
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grInventoryItems)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1148, 147)
        Me.GroupControl2.TabIndex = 5
        Me.GroupControl2.Text = "Open Items to Be Received"
        '
        'grInventoryItems
        '
        Me.grInventoryItems.DataSource = Me.bsInventoryItems
        Me.grInventoryItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInventoryItems.Location = New System.Drawing.Point(2, 22)
        Me.grInventoryItems.LookAndFeel.SkinName = "Money Twins"
        Me.grInventoryItems.MainView = Me.grvInventoryItems
        Me.grInventoryItems.Name = "grInventoryItems"
        Me.grInventoryItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemHyperLinkEdit3})
        Me.grInventoryItems.Size = New System.Drawing.Size(1144, 123)
        Me.grInventoryItems.TabIndex = 4
        Me.grInventoryItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvInventoryItems})
        '
        'bsInventoryItems
        '
        Me.bsInventoryItems.DataSource = GetType(AOS.BusinessObjects.ViewInvItemListCollection)
        '
        'grvInventoryItems
        '
        Me.grvInventoryItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber, Me.colSourcedoc, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn17, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn18, Me.colExpectedindate})
        Me.grvInventoryItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvInventoryItems.GridControl = Me.grInventoryItems
        Me.grvInventoryItems.Name = "grvInventoryItems"
        Me.grvInventoryItems.OptionsBehavior.Editable = False
        Me.grvInventoryItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvInventoryItems.OptionsSelection.MultiSelect = True
        Me.grvInventoryItems.OptionsView.ShowGroupPanel = False
        Me.grvInventoryItems.OptionsView.ShowIndicator = False
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.AppearanceHeader.Options.UseTextOptions = True
        Me.colInvitemnumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colInvitemnumber.Caption = "Inv. Item #"
        Me.colInvitemnumber.ColumnEdit = Me.RepositoryItemHyperLinkEdit3
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.OptionsColumn.FixedWidth = True
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 0
        Me.colInvitemnumber.Width = 67
        '
        'RepositoryItemHyperLinkEdit3
        '
        Me.RepositoryItemHyperLinkEdit3.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit3.Name = "RepositoryItemHyperLinkEdit3"
        '
        'colSourcedoc
        '
        Me.colSourcedoc.AppearanceHeader.Options.UseTextOptions = True
        Me.colSourcedoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSourcedoc.Caption = "Src Doc"
        Me.colSourcedoc.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.colSourcedoc.FieldName = "Sourcedocument"
        Me.colSourcedoc.Name = "colSourcedoc"
        Me.colSourcedoc.OptionsColumn.FixedWidth = True
        Me.colSourcedoc.Visible = True
        Me.colSourcedoc.VisibleIndex = 1
        Me.colSourcedoc.Width = 50
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Item Type"
        Me.GridColumn3.FieldName = "Itemtype"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 60
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn4.Caption = "Item ID"
        Me.GridColumn4.FieldName = "Itemid"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 47
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Item Description"
        Me.GridColumn5.FieldName = "Itemdescription"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 386
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Container"
        Me.GridColumn6.FieldName = "Container"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 90
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Item Status"
        Me.GridColumn7.FieldName = "Itemstatus"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.FixedWidth = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Src Status"
        Me.GridColumn17.FieldName = "Sourcestatus"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.FixedWidth = True
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 7
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Lot #"
        Me.GridColumn8.FieldName = "Lotnumber"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.FixedWidth = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 8
        Me.GridColumn8.Width = 64
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Vendor Lbl Wgt"
        Me.GridColumn9.FieldName = "Vendorweight"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.FixedWidth = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 9
        Me.GridColumn9.Width = 82
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Rec Weight"
        Me.GridColumn10.FieldName = "Rcvdweight"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.FixedWidth = True
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 10
        Me.GridColumn10.Width = 65
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Inventory Class"
        Me.GridColumn18.FieldName = "LookupDesc"
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.OptionsColumn.FixedWidth = True
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 11
        Me.GridColumn18.Width = 85
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.grPurchaseItems)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1152, 301)
        Me.RibbonPanelControl3.TabIndex = 0
        '
        'grPurchaseItems
        '
        Me.grPurchaseItems.DataSource = Me.bsPurchaseItems
        Me.grPurchaseItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPurchaseItems.Location = New System.Drawing.Point(2, 2)
        Me.grPurchaseItems.LookAndFeel.SkinName = "Money Twins"
        Me.grPurchaseItems.MainView = Me.grvPurchaseItems
        Me.grPurchaseItems.Name = "grPurchaseItems"
        Me.grPurchaseItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit2, Me.RepositoryItemHyperLinkEdit4})
        Me.grPurchaseItems.Size = New System.Drawing.Size(1148, 297)
        Me.grPurchaseItems.TabIndex = 4
        Me.grPurchaseItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPurchaseItems})
        '
        'bsPurchaseItems
        '
        Me.bsPurchaseItems.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseItemsListCollection)
        '
        'grvPurchaseItems
        '
        Me.grvPurchaseItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPurchaseitemid, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.SourceType, Me.colPrchSourcedoc})
        Me.grvPurchaseItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvPurchaseItems.GridControl = Me.grPurchaseItems
        Me.grvPurchaseItems.Name = "grvPurchaseItems"
        Me.grvPurchaseItems.OptionsBehavior.Editable = False
        Me.grvPurchaseItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvPurchaseItems.OptionsView.ShowGroupPanel = False
        Me.grvPurchaseItems.OptionsView.ShowIndicator = False
        '
        'colPurchaseitemid
        '
        Me.colPurchaseitemid.AppearanceHeader.Options.UseTextOptions = True
        Me.colPurchaseitemid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPurchaseitemid.Caption = "Prch Item #"
        Me.colPurchaseitemid.ColumnEdit = Me.RepositoryItemHyperLinkEdit4
        Me.colPurchaseitemid.FieldName = "Purchaseitemid"
        Me.colPurchaseitemid.Name = "colPurchaseitemid"
        Me.colPurchaseitemid.OptionsColumn.FixedWidth = True
        Me.colPurchaseitemid.Visible = True
        Me.colPurchaseitemid.VisibleIndex = 0
        Me.colPurchaseitemid.Width = 70
        '
        'RepositoryItemHyperLinkEdit4
        '
        Me.RepositoryItemHyperLinkEdit4.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit4.Name = "RepositoryItemHyperLinkEdit4"
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Item Type"
        Me.GridColumn11.FieldName = "Itemtype"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.OptionsColumn.FixedWidth = True
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 60
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn12.Caption = "Item ID"
        Me.GridColumn12.FieldName = "Itemid"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.OptionsColumn.FixedWidth = True
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        Me.GridColumn12.Width = 50
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Item Description"
        Me.GridColumn13.FieldName = "Itemdescription"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 3
        Me.GridColumn13.Width = 445
        '
        'GridColumn14
        '
        Me.GridColumn14.Caption = "Container"
        Me.GridColumn14.FieldName = "Container"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.OptionsColumn.FixedWidth = True
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 4
        Me.GridColumn14.Width = 80
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Status"
        Me.GridColumn15.FieldName = "Purchaseitemstatus"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.OptionsColumn.FixedWidth = True
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 5
        Me.GridColumn15.Width = 80
        '
        'GridColumn16
        '
        Me.GridColumn16.Caption = "Vendor"
        Me.GridColumn16.FieldName = "Vendorname"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 6
        Me.GridColumn16.Width = 241
        '
        'SourceType
        '
        Me.SourceType.Caption = "Src Type"
        Me.SourceType.FieldName = "Sourcetype"
        Me.SourceType.Name = "SourceType"
        Me.SourceType.OptionsColumn.FixedWidth = True
        Me.SourceType.Visible = True
        Me.SourceType.VisibleIndex = 7
        '
        'colPrchSourcedoc
        '
        Me.colPrchSourcedoc.AppearanceHeader.Options.UseTextOptions = True
        Me.colPrchSourcedoc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPrchSourcedoc.Caption = "Src Doc"
        Me.colPrchSourcedoc.ColumnEdit = Me.RepositoryItemHyperLinkEdit2
        Me.colPrchSourcedoc.FieldName = "Sourcedocument"
        Me.colPrchSourcedoc.Name = "colPrchSourcedoc"
        Me.colPrchSourcedoc.OptionsColumn.FixedWidth = True
        Me.colPrchSourcedoc.Visible = True
        Me.colPrchSourcedoc.VisibleIndex = 8
        Me.colPrchSourcedoc.Width = 55
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.btnReceiveInventory, Me.btnQuantityDelivered, Me.btnRetrievePurchaseItems, Me.rbtnForceRCVDHOLD})
        Me.RibbonControl2.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 5
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2, Me.RibbonPage3})
        Me.RibbonControl2.ShowCategoryInCaption = False
        Me.RibbonControl2.ShowToolbarCustomizeItem = False
        Me.RibbonControl2.Size = New System.Drawing.Size(1156, 117)
        Me.RibbonControl2.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnReceiveInventory
        '
        Me.btnReceiveInventory.Caption = "Receive Inventory"
        Me.btnReceiveInventory.Id = 1
        Me.btnReceiveInventory.LargeImageIndex = 14
        Me.btnReceiveInventory.Name = "btnReceiveInventory"
        '
        'btnQuantityDelivered
        '
        Me.btnQuantityDelivered.Caption = "Quantity Delivered"
        Me.btnQuantityDelivered.Id = 2
        Me.btnQuantityDelivered.LargeImageIndex = 20
        Me.btnQuantityDelivered.Name = "btnQuantityDelivered"
        '
        'btnRetrievePurchaseItems
        '
        Me.btnRetrievePurchaseItems.Caption = "Retrieve Purchase Items "
        Me.btnRetrievePurchaseItems.Id = 3
        Me.btnRetrievePurchaseItems.LargeImageIndex = 18
        Me.btnRetrievePurchaseItems.Name = "btnRetrievePurchaseItems"
        '
        'rbtnForceRCVDHOLD
        '
        Me.rbtnForceRCVDHOLD.Caption = "Move to Received / Hold Status"
        Me.rbtnForceRCVDHOLD.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnForceRCVDHOLD.Id = 4
        Me.rbtnForceRCVDHOLD.LargeImageIndex = 32
        Me.rbtnForceRCVDHOLD.Name = "rbtnForceRCVDHOLD"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Inventory Items"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnReceiveInventory)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnForceRCVDHOLD, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Purchase Items"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnRetrievePurchaseItems)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Purchase Items"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnQuantityDelivered)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Vnd Non Conformance"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1156, 192)
        Me.PanelControl2.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label6)
        Me.GroupControl1.Controls.Add(Me.PurchaseDateTextEdit)
        Me.GroupControl1.Controls.Add(Me.ExpectedInDateTextEdit)
        Me.GroupControl1.Controls.Add(Me.WorkordernumberTextEdit)
        Me.GroupControl1.Controls.Add(Me.CustomerTextEdit)
        Me.GroupControl1.Controls.Add(Me.VendorTextEdit)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Me.CustomPurchaseNumberTextEdit)
        Me.GroupControl1.Controls.Add(Me.eInstructions)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.PurchaseTypeTextEdit)
        Me.GroupControl1.Controls.Add(SuppliercompanyLabel)
        Me.GroupControl1.Controls.Add(OrdertermsLabel)
        Me.GroupControl1.Controls.Add(Me.OrdertermsTextEdit)
        Me.GroupControl1.Controls.Add(OrderstatusLabel)
        Me.GroupControl1.Controls.Add(Me.ePOStatus)
        Me.GroupControl1.Controls.Add(OrdernotesLabel)
        Me.GroupControl1.Controls.Add(CustorderdateLabel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1156, 192)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Purchase Order Information"
        '
        'PurchaseDateTextEdit
        '
        Me.PurchaseDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Purchasedate", True))
        Me.PurchaseDateTextEdit.EditValue = Nothing
        Me.PurchaseDateTextEdit.Location = New System.Drawing.Point(250, 33)
        Me.PurchaseDateTextEdit.MenuManager = Me.RibbonControl1
        Me.PurchaseDateTextEdit.Name = "PurchaseDateTextEdit"
        Me.PurchaseDateTextEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[False]
        Me.PurchaseDateTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PurchaseDateTextEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.PurchaseDateTextEdit.Properties.ReadOnly = True
        Me.PurchaseDateTextEdit.Size = New System.Drawing.Size(95, 20)
        Me.PurchaseDateTextEdit.TabIndex = 27
        '
        'bsPurchase
        '
        Me.bsPurchase.DataSource = GetType(AOS.BusinessObjects.Purchase)
        '
        'ExpectedInDateTextEdit
        '
        Me.ExpectedInDateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Expectedindate", True))
        Me.ExpectedInDateTextEdit.EditValue = Nothing
        Me.ExpectedInDateTextEdit.Location = New System.Drawing.Point(828, 59)
        Me.ExpectedInDateTextEdit.MenuManager = Me.RibbonControl1
        Me.ExpectedInDateTextEdit.Name = "ExpectedInDateTextEdit"
        Me.ExpectedInDateTextEdit.Properties.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[False]
        Me.ExpectedInDateTextEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ExpectedInDateTextEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ExpectedInDateTextEdit.Properties.ReadOnly = True
        Me.ExpectedInDateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ExpectedInDateTextEdit.TabIndex = 26
        '
        'WorkordernumberTextEdit
        '
        Me.WorkordernumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Purchasenumber", True))
        Me.WorkordernumberTextEdit.Location = New System.Drawing.Point(95, 33)
        Me.WorkordernumberTextEdit.Name = "WorkordernumberTextEdit"
        Me.WorkordernumberTextEdit.Properties.ReadOnly = True
        Me.WorkordernumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.WorkordernumberTextEdit.TabIndex = 25
        Me.WorkordernumberTextEdit.TabStop = False
        '
        'CustomerTextEdit
        '
        Me.CustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomer, "Custname", True))
        Me.CustomerTextEdit.Location = New System.Drawing.Point(95, 85)
        Me.CustomerTextEdit.Name = "CustomerTextEdit"
        Me.CustomerTextEdit.Properties.ReadOnly = True
        Me.CustomerTextEdit.Size = New System.Drawing.Size(250, 20)
        Me.CustomerTextEdit.TabIndex = 24
        '
        'bsCustomer
        '
        Me.bsCustomer.DataSource = GetType(AOS.BusinessObjects.Customer)
        '
        'VendorTextEdit
        '
        Me.VendorTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendor, "Vendorname", True))
        Me.VendorTextEdit.Location = New System.Drawing.Point(95, 59)
        Me.VendorTextEdit.Name = "VendorTextEdit"
        Me.VendorTextEdit.Properties.ReadOnly = True
        Me.VendorTextEdit.Size = New System.Drawing.Size(250, 20)
        Me.VendorTextEdit.TabIndex = 23
        '
        'bsVendor
        '
        Me.bsVendor.DataSource = GetType(AOS.BusinessObjects.Vendor)
        '
        'CustomPurchaseNumberTextEdit
        '
        Me.CustomPurchaseNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Customerpo", True))
        Me.CustomPurchaseNumberTextEdit.Location = New System.Drawing.Point(828, 33)
        Me.CustomPurchaseNumberTextEdit.Name = "CustomPurchaseNumberTextEdit"
        Me.CustomPurchaseNumberTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.CustomPurchaseNumberTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.CustomPurchaseNumberTextEdit.Properties.ReadOnly = True
        Me.CustomPurchaseNumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CustomPurchaseNumberTextEdit.TabIndex = 2
        Me.CustomPurchaseNumberTextEdit.TabStop = False
        '
        'eInstructions
        '
        Me.eInstructions.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Instructions", True))
        Me.eInstructions.Location = New System.Drawing.Point(95, 111)
        Me.eInstructions.Name = "eInstructions"
        Me.eInstructions.Properties.Appearance.Options.UseTextOptions = True
        Me.eInstructions.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eInstructions.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.eInstructions.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.eInstructions.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.eInstructions.Properties.ReadOnly = True
        Me.eInstructions.Size = New System.Drawing.Size(612, 66)
        Me.eInstructions.TabIndex = 18
        '
        'PurchaseTypeTextEdit
        '
        Me.PurchaseTypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Purchasetype", True))
        Me.PurchaseTypeTextEdit.Location = New System.Drawing.Point(457, 32)
        Me.PurchaseTypeTextEdit.Name = "PurchaseTypeTextEdit"
        Me.PurchaseTypeTextEdit.Properties.ReadOnly = True
        Me.PurchaseTypeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PurchaseTypeTextEdit.TabIndex = 12
        '
        'OrdertermsTextEdit
        '
        Me.OrdertermsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Terms", True))
        Me.OrdertermsTextEdit.Location = New System.Drawing.Point(457, 58)
        Me.OrdertermsTextEdit.Name = "OrdertermsTextEdit"
        Me.OrdertermsTextEdit.Properties.ReadOnly = True
        Me.OrdertermsTextEdit.Size = New System.Drawing.Size(250, 20)
        Me.OrdertermsTextEdit.TabIndex = 16
        '
        'ePOStatus
        '
        Me.ePOStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPurchase, "Purchasestatus", True))
        Me.ePOStatus.Location = New System.Drawing.Point(612, 32)
        Me.ePOStatus.Name = "ePOStatus"
        Me.ePOStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ePOStatus.Properties.Appearance.Options.UseBackColor = True
        Me.ePOStatus.Properties.ReadOnly = True
        Me.ePOStatus.Size = New System.Drawing.Size(95, 20)
        Me.ePOStatus.TabIndex = 14
        Me.ePOStatus.TabStop = False
        '
        'colExpectedindate
        '
        Me.colExpectedindate.Caption = "Exp In"
        Me.colExpectedindate.FieldName = "Expectedindate"
        Me.colExpectedindate.Name = "colExpectedindate"
        Me.colExpectedindate.Visible = True
        Me.colExpectedindate.VisibleIndex = 12
        '
        'frmReceivingPurchase
        '
        Me.ClientSize = New System.Drawing.Size(1156, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReceivingPurchase"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Receiving Information"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.WorkPanelsHolder2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder2.ResumeLayout(False)
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.gcReceivedItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsReceivedItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvInventoryItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.grPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPurchaseItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PurchaseDateTextEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedInDateTextEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpectedInDateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomPurchaseNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInstructions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseTypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdertermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePOStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents OrdertermsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePOStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAllocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnallocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PurchaseTypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsPurchase As System.Windows.Forms.BindingSource
    Friend WithEvents bsVendor As System.Windows.Forms.BindingSource
    Friend WithEvents eInstructions As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CustomPurchaseNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsCustomer As System.Windows.Forms.BindingSource
    Friend WithEvents btnCOAText As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents WorkordernumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnReceiveInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents WorkPanelsHolder2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grInventoryItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvInventoryItems As CustomDevExGridView
    Friend WithEvents bsInventoryItems As System.Windows.Forms.BindingSource
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourcedoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents grPurchaseItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPurchaseItems As CustomDevExGridView
    Friend WithEvents btnQuantityDelivered As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsPurchaseItems As System.Windows.Forms.BindingSource
    Friend WithEvents colPurchaseitemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrchSourcedoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents ExpectedInDateTextEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents PurchaseDateTextEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRetrievePurchaseItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SourceType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnForceRCVDHOLD As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents gcReceivedItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvItems As CustomDevExGridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit5 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsReceivedItems As BindingSource
    Friend WithEvents colExpectedindate As DevExpress.XtraGrid.Columns.GridColumn
End Class
