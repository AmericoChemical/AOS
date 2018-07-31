<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFreightChargesHistory

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
        Dim lblShipmentnumber As System.Windows.Forms.Label
        Dim ShipmentdateLabel As System.Windows.Forms.Label
        Dim ShipfromidLabel As System.Windows.Forms.Label
        Dim Shipfromaddress1Label As System.Windows.Forms.Label
        Dim Shipfromaddress2Label As System.Windows.Forms.Label
        Dim ShipfromcityLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFreightChargesHistory))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddShipmentItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditShipmentItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteShipmentItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintBOL = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnSplitLoad = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnLoadFreightCharges = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtEmailFreightChargesHistory = New DevExpress.XtraBars.BarButtonItem()
        Me.LoadMgmt_Images = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.grFreightChargeHistory = New DevExpress.XtraGrid.GridControl()
        Me.bsLoadChargeHistory = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvFreightChargesHistory = New AOS.CustomClasses.CustomDevExGridView()
        Me.colLoadID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualShipmentDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDestName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFob = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFreezeProtectFlag = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalGrossWeight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalSkids = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalCharged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalBilled = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.luProductDesc = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luContainer = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.luStdgallons = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.chkFreezeProtect = New DevExpress.XtraEditors.CheckEdit()
        Me.txtVariance = New DevExpress.XtraEditors.TextEdit()
        Me.txtSkids = New DevExpress.XtraEditors.TextEdit()
        Me.txtTotalWeight = New DevExpress.XtraEditors.TextEdit()
        Me.ShipmentdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.bsLoadInfo = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Shipfromaddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipfrompostalcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Shipfromaddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipfromstateprovTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipfromcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.rbtnPrint = New DevExpress.XtraBars.BarButtonItem()
        lblShipmentnumber = New System.Windows.Forms.Label()
        ShipmentdateLabel = New System.Windows.Forms.Label()
        ShipfromidLabel = New System.Windows.Forms.Label()
        Shipfromaddress1Label = New System.Windows.Forms.Label()
        Shipfromaddress2Label = New System.Windows.Forms.Label()
        ShipfromcityLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadMgmt_Images, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.grFreightChargeHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadChargeHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvFreightChargesHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.chkFreezeProtect.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVariance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSkids.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoadNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipfromaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipfrompostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shipfromaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipfromstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipfromcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblShipmentnumber
        '
        lblShipmentnumber.AutoSize = True
        lblShipmentnumber.Location = New System.Drawing.Point(8, 31)
        lblShipmentnumber.Name = "lblShipmentnumber"
        lblShipmentnumber.Size = New System.Drawing.Size(30, 13)
        lblShipmentnumber.TabIndex = 0
        lblShipmentnumber.Text = "Load"
        '
        'ShipmentdateLabel
        '
        ShipmentdateLabel.AutoSize = True
        ShipmentdateLabel.Location = New System.Drawing.Point(8, 57)
        ShipmentdateLabel.Name = "ShipmentdateLabel"
        ShipmentdateLabel.Size = New System.Drawing.Size(53, 13)
        ShipmentdateLabel.TabIndex = 2
        ShipmentdateLabel.Text = "Ship Date"
        '
        'ShipfromidLabel
        '
        ShipfromidLabel.AutoSize = True
        ShipfromidLabel.Location = New System.Drawing.Point(10, 31)
        ShipfromidLabel.Name = "ShipfromidLabel"
        ShipfromidLabel.Size = New System.Drawing.Size(52, 13)
        ShipfromidLabel.TabIndex = 14
        ShipfromidLabel.Text = "Company"
        '
        'Shipfromaddress1Label
        '
        Shipfromaddress1Label.AutoSize = True
        Shipfromaddress1Label.Location = New System.Drawing.Point(10, 57)
        Shipfromaddress1Label.Name = "Shipfromaddress1Label"
        Shipfromaddress1Label.Size = New System.Drawing.Size(55, 13)
        Shipfromaddress1Label.TabIndex = 16
        Shipfromaddress1Label.Text = "Address 1"
        '
        'Shipfromaddress2Label
        '
        Shipfromaddress2Label.AutoSize = True
        Shipfromaddress2Label.Location = New System.Drawing.Point(10, 83)
        Shipfromaddress2Label.Name = "Shipfromaddress2Label"
        Shipfromaddress2Label.Size = New System.Drawing.Size(55, 13)
        Shipfromaddress2Label.TabIndex = 18
        Shipfromaddress2Label.Text = "Address 2"
        '
        'ShipfromcityLabel
        '
        ShipfromcityLabel.AutoSize = True
        ShipfromcityLabel.Location = New System.Drawing.Point(10, 109)
        ShipfromcityLabel.Name = "ShipfromcityLabel"
        ShipfromcityLabel.Size = New System.Drawing.Size(72, 13)
        ShipfromcityLabel.TabIndex = 20
        ShipfromcityLabel.Text = "City State Zip"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(10, 31)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 14
        Label2.Text = "Company"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(10, 57)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(55, 13)
        Label4.TabIndex = 16
        Label4.Text = "Address 1"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(10, 83)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(55, 13)
        Label5.TabIndex = 18
        Label5.Text = "Address 2"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(10, 109)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(72, 13)
        Label6.TabIndex = 20
        Label6.Text = "City State Zip"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(8, 109)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(31, 13)
        Label7.TabIndex = 31
        Label7.Text = "Skids"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(8, 83)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(41, 13)
        Label8.TabIndex = 33
        Label8.Text = "Weight"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(8, 129)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 13)
        Label1.TabIndex = 35
        Label1.Text = "Freeze Protect"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(180, 83)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(48, 13)
        Label3.TabIndex = 37
        Label3.Text = "Variance"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(262, 83)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(18, 13)
        Label9.TabIndex = 39
        Label9.Text = "%"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnClose, Me.btnAddShipmentItem, Me.btnEditShipmentItem, Me.btnDeleteShipmentItem, Me.btnPrintBOL, Me.rbtnSplitLoad, Me.rbtnLoadFreightCharges, Me.rbtEmailFreightChargesHistory, Me.rbtnPrint})
        Me.RibbonControl1.LargeImages = Me.LoadMgmt_Images
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 14
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1382, 116)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 0
        Me.btnSave.ImageOptions.LargeImageIndex = 6
        Me.btnSave.Name = "btnSave"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 1
        Me.btnClose.ImageOptions.LargeImageIndex = 7
        Me.btnClose.Name = "btnClose"
        '
        'btnAddShipmentItem
        '
        Me.btnAddShipmentItem.Caption = "Add New Item"
        Me.btnAddShipmentItem.Id = 2
        Me.btnAddShipmentItem.ImageOptions.LargeImageIndex = 18
        Me.btnAddShipmentItem.Name = "btnAddShipmentItem"
        '
        'btnEditShipmentItem
        '
        Me.btnEditShipmentItem.Caption = "Edit Item"
        Me.btnEditShipmentItem.Id = 3
        Me.btnEditShipmentItem.ImageOptions.Image = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditShipmentItem.ImageOptions.LargeImageIndex = 20
        Me.btnEditShipmentItem.Name = "btnEditShipmentItem"
        '
        'btnDeleteShipmentItem
        '
        Me.btnDeleteShipmentItem.Caption = "Delete Item"
        Me.btnDeleteShipmentItem.Id = 4
        Me.btnDeleteShipmentItem.ImageOptions.Image = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteShipmentItem.ImageOptions.LargeImageIndex = 19
        Me.btnDeleteShipmentItem.Name = "btnDeleteShipmentItem"
        '
        'btnPrintBOL
        '
        Me.btnPrintBOL.Caption = "Print BOL"
        Me.btnPrintBOL.Id = 9
        Me.btnPrintBOL.ImageOptions.Image = Global.AOS.My.Resources.Resources.proforma_print
        Me.btnPrintBOL.ImageOptions.LargeImageIndex = 5
        Me.btnPrintBOL.Name = "btnPrintBOL"
        '
        'rbtnSplitLoad
        '
        Me.rbtnSplitLoad.Caption = "Split Load"
        Me.rbtnSplitLoad.Id = 10
        Me.rbtnSplitLoad.ImageOptions.LargeImageIndex = 8
        Me.rbtnSplitLoad.Name = "rbtnSplitLoad"
        '
        'rbtnLoadFreightCharges
        '
        Me.rbtnLoadFreightCharges.Caption = "Load History"
        Me.rbtnLoadFreightCharges.Id = 11
        Me.rbtnLoadFreightCharges.ImageOptions.LargeImageIndex = 1
        Me.rbtnLoadFreightCharges.Name = "rbtnLoadFreightCharges"
        '
        'rbtEmailFreightChargesHistory
        '
        Me.rbtEmailFreightChargesHistory.Caption = "Email"
        Me.rbtEmailFreightChargesHistory.Id = 12
        Me.rbtEmailFreightChargesHistory.ImageOptions.LargeImageIndex = 3
        Me.rbtEmailFreightChargesHistory.Name = "rbtEmailFreightChargesHistory"
        '
        'LoadMgmt_Images
        '
        Me.LoadMgmt_Images.ImageSize = New System.Drawing.Size(32, 32)
        Me.LoadMgmt_Images.ImageStream = CType(resources.GetObject("LoadMgmt_Images.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup5})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Data Mgmt"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowMinimize = False
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnLoadFreightCharges)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnPrint, True)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtEmailFreightChargesHistory, True)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Freight Charges History"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.GroupControl4)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 116)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1382, 678)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl4
        '
        Me.GroupControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl4.Controls.Add(Me.grFreightChargeHistory)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 216)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1382, 462)
        Me.GroupControl4.TabIndex = 6
        Me.GroupControl4.Text = "Work Order Items"
        '
        'grFreightChargeHistory
        '
        Me.grFreightChargeHistory.DataSource = Me.bsLoadChargeHistory
        Me.grFreightChargeHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grFreightChargeHistory.Location = New System.Drawing.Point(0, 0)
        Me.grFreightChargeHistory.MainView = Me.grvFreightChargesHistory
        Me.grFreightChargeHistory.Name = "grFreightChargeHistory"
        Me.grFreightChargeHistory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.luProductDesc, Me.luContainer, Me.luStdgallons, Me.RepositoryItemCheckEdit1, Me.RepositoryItemLookUpEdit1})
        Me.grFreightChargeHistory.Size = New System.Drawing.Size(1382, 462)
        Me.grFreightChargeHistory.TabIndex = 4
        Me.grFreightChargeHistory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvFreightChargesHistory})
        '
        'bsLoadChargeHistory
        '
        Me.bsLoadChargeHistory.DataSource = GetType(AOS.BusinessObjects.ViewLoadInfoCollection)
        '
        'grvFreightChargesHistory
        '
        Me.grvFreightChargesHistory.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLoadID, Me.colActualShipmentDate, Me.colCarrierName, Me.colOriginName, Me.colDestName, Me.colFob, Me.colFreezeProtectFlag, Me.colTotalGrossWeight, Me.colTotalSkids, Me.colTotalCharged, Me.colTotalBilled})
        Me.grvFreightChargesHistory.GridControl = Me.grFreightChargeHistory
        Me.grvFreightChargesHistory.Name = "grvFreightChargesHistory"
        Me.grvFreightChargesHistory.OptionsBehavior.Editable = False
        Me.grvFreightChargesHistory.OptionsSelection.MultiSelect = True
        Me.grvFreightChargesHistory.OptionsView.ShowAutoFilterRow = True
        Me.grvFreightChargesHistory.OptionsView.ShowFooter = True
        Me.grvFreightChargesHistory.OptionsView.ShowGroupPanel = False
        '
        'colLoadID
        '
        Me.colLoadID.FieldName = "LoadID"
        Me.colLoadID.Name = "colLoadID"
        Me.colLoadID.Visible = True
        Me.colLoadID.VisibleIndex = 0
        '
        'colActualShipmentDate
        '
        Me.colActualShipmentDate.FieldName = "ActualShipmentDate"
        Me.colActualShipmentDate.Name = "colActualShipmentDate"
        Me.colActualShipmentDate.Visible = True
        Me.colActualShipmentDate.VisibleIndex = 1
        '
        'colCarrierName
        '
        Me.colCarrierName.FieldName = "CarrierName"
        Me.colCarrierName.Name = "colCarrierName"
        Me.colCarrierName.Visible = True
        Me.colCarrierName.VisibleIndex = 2
        '
        'colOriginName
        '
        Me.colOriginName.FieldName = "OriginName"
        Me.colOriginName.Name = "colOriginName"
        Me.colOriginName.Visible = True
        Me.colOriginName.VisibleIndex = 3
        '
        'colDestName
        '
        Me.colDestName.FieldName = "DestName"
        Me.colDestName.Name = "colDestName"
        Me.colDestName.Visible = True
        Me.colDestName.VisibleIndex = 4
        '
        'colFob
        '
        Me.colFob.FieldName = "Fob"
        Me.colFob.Name = "colFob"
        Me.colFob.Visible = True
        Me.colFob.VisibleIndex = 5
        '
        'colFreezeProtectFlag
        '
        Me.colFreezeProtectFlag.FieldName = "FreezeProtectFlag"
        Me.colFreezeProtectFlag.Name = "colFreezeProtectFlag"
        Me.colFreezeProtectFlag.Visible = True
        Me.colFreezeProtectFlag.VisibleIndex = 7
        '
        'colTotalGrossWeight
        '
        Me.colTotalGrossWeight.FieldName = "TotalGrossWeight"
        Me.colTotalGrossWeight.Name = "colTotalGrossWeight"
        Me.colTotalGrossWeight.Visible = True
        Me.colTotalGrossWeight.VisibleIndex = 6
        '
        'colTotalSkids
        '
        Me.colTotalSkids.FieldName = "TotalSkids"
        Me.colTotalSkids.Name = "colTotalSkids"
        Me.colTotalSkids.Visible = True
        Me.colTotalSkids.VisibleIndex = 8
        '
        'colTotalCharged
        '
        Me.colTotalCharged.FieldName = "TotalCharged"
        Me.colTotalCharged.Name = "colTotalCharged"
        Me.colTotalCharged.Visible = True
        Me.colTotalCharged.VisibleIndex = 9
        '
        'colTotalBilled
        '
        Me.colTotalBilled.FieldName = "TotalBilled"
        Me.colTotalBilled.Name = "colTotalBilled"
        Me.colTotalBilled.Visible = True
        Me.colTotalBilled.VisibleIndex = 10
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
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1382, 216)
        Me.PanelControl2.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GroupControl5)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Controls.Add(Me.GroupControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1382, 216)
        Me.GroupControl1.TabIndex = 23
        Me.GroupControl1.Text = "Freight Charges History Parameters"
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.chkFreezeProtect)
        Me.GroupControl5.Controls.Add(Me.txtVariance)
        Me.GroupControl5.Controls.Add(Me.txtSkids)
        Me.GroupControl5.Controls.Add(Me.txtTotalWeight)
        Me.GroupControl5.Controls.Add(Label9)
        Me.GroupControl5.Controls.Add(Label3)
        Me.GroupControl5.Controls.Add(Label1)
        Me.GroupControl5.Controls.Add(Label8)
        Me.GroupControl5.Controls.Add(Label7)
        Me.GroupControl5.Controls.Add(lblShipmentnumber)
        Me.GroupControl5.Controls.Add(ShipmentdateLabel)
        Me.GroupControl5.Controls.Add(Me.ShipmentdateDateEdit)
        Me.GroupControl5.Controls.Add(Me.LoadNumberTextEdit)
        Me.GroupControl5.Location = New System.Drawing.Point(12, 33)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(280, 155)
        Me.GroupControl5.TabIndex = 30
        Me.GroupControl5.Text = "Load Info"
        '
        'chkFreezeProtect
        '
        Me.chkFreezeProtect.Location = New System.Drawing.Point(93, 129)
        Me.chkFreezeProtect.MenuManager = Me.RibbonControl1
        Me.chkFreezeProtect.Name = "chkFreezeProtect"
        Me.chkFreezeProtect.Properties.Caption = ""
        Me.chkFreezeProtect.Size = New System.Drawing.Size(75, 19)
        Me.chkFreezeProtect.TabIndex = 43
        '
        'txtVariance
        '
        Me.txtVariance.Location = New System.Drawing.Point(234, 80)
        Me.txtVariance.MenuManager = Me.RibbonControl1
        Me.txtVariance.Name = "txtVariance"
        Me.txtVariance.Size = New System.Drawing.Size(31, 20)
        Me.txtVariance.TabIndex = 42
        '
        'txtSkids
        '
        Me.txtSkids.Location = New System.Drawing.Point(76, 102)
        Me.txtSkids.MenuManager = Me.RibbonControl1
        Me.txtSkids.Name = "txtSkids"
        Me.txtSkids.Size = New System.Drawing.Size(80, 20)
        Me.txtSkids.TabIndex = 41
        '
        'txtTotalWeight
        '
        Me.txtTotalWeight.Location = New System.Drawing.Point(76, 80)
        Me.txtTotalWeight.MenuManager = Me.RibbonControl1
        Me.txtTotalWeight.Name = "txtTotalWeight"
        Me.txtTotalWeight.Size = New System.Drawing.Size(80, 20)
        Me.txtTotalWeight.TabIndex = 40
        '
        'ShipmentdateDateEdit
        '
        Me.ShipmentdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "PlannedDepartureDate", True))
        Me.ShipmentdateDateEdit.EditValue = Nothing
        Me.ShipmentdateDateEdit.Enabled = False
        Me.ShipmentdateDateEdit.Location = New System.Drawing.Point(76, 54)
        Me.ShipmentdateDateEdit.MenuManager = Me.RibbonControl1
        Me.ShipmentdateDateEdit.Name = "ShipmentdateDateEdit"
        Me.ShipmentdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ShipmentdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ShipmentdateDateEdit.Size = New System.Drawing.Size(150, 20)
        Me.ShipmentdateDateEdit.TabIndex = 0
        '
        'bsLoadInfo
        '
        Me.bsLoadInfo.DataSource = GetType(AOS.BusinessObjects.ViewLoadInfo)
        '
        'LoadNumberTextEdit
        '
        Me.LoadNumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "LoadID", True))
        Me.LoadNumberTextEdit.Enabled = False
        Me.LoadNumberTextEdit.Location = New System.Drawing.Point(76, 28)
        Me.LoadNumberTextEdit.MenuManager = Me.RibbonControl1
        Me.LoadNumberTextEdit.Name = "LoadNumberTextEdit"
        Me.LoadNumberTextEdit.Properties.ReadOnly = True
        Me.LoadNumberTextEdit.Size = New System.Drawing.Size(150, 20)
        Me.LoadNumberTextEdit.TabIndex = 1
        Me.LoadNumberTextEdit.TabStop = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.TextEdit3)
        Me.GroupControl3.Controls.Add(Label2)
        Me.GroupControl3.Controls.Add(Me.TextEdit2)
        Me.GroupControl3.Controls.Add(Label4)
        Me.GroupControl3.Controls.Add(Me.TextEdit4)
        Me.GroupControl3.Controls.Add(Me.TextEdit5)
        Me.GroupControl3.Controls.Add(Me.TextEdit6)
        Me.GroupControl3.Controls.Add(Label5)
        Me.GroupControl3.Controls.Add(Label6)
        Me.GroupControl3.Controls.Add(Me.TextEdit7)
        Me.GroupControl3.Enabled = False
        Me.GroupControl3.Location = New System.Drawing.Point(674, 33)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(348, 155)
        Me.GroupControl3.TabIndex = 29
        Me.GroupControl3.Text = "Destination"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "DestName", True))
        Me.TextEdit3.Enabled = False
        Me.TextEdit3.Location = New System.Drawing.Point(94, 28)
        Me.TextEdit3.MenuManager = Me.RibbonControl1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(240, 20)
        Me.TextEdit3.TabIndex = 21
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "DestAddress1", True))
        Me.TextEdit2.Location = New System.Drawing.Point(94, 54)
        Me.TextEdit2.MenuManager = Me.RibbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(240, 20)
        Me.TextEdit2.TabIndex = 1
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "DestZip", True))
        Me.TextEdit4.Location = New System.Drawing.Point(266, 106)
        Me.TextEdit4.MenuManager = Me.RibbonControl1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(68, 20)
        Me.TextEdit4.TabIndex = 5
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "DestAddress2", True))
        Me.TextEdit5.Location = New System.Drawing.Point(94, 80)
        Me.TextEdit5.MenuManager = Me.RibbonControl1
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(240, 20)
        Me.TextEdit5.TabIndex = 2
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "DestState", True))
        Me.TextEdit6.Location = New System.Drawing.Point(232, 106)
        Me.TextEdit6.MenuManager = Me.RibbonControl1
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Size = New System.Drawing.Size(28, 20)
        Me.TextEdit6.TabIndex = 4
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "DestCity", True))
        Me.TextEdit7.Location = New System.Drawing.Point(94, 106)
        Me.TextEdit7.MenuManager = Me.RibbonControl1
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Size = New System.Drawing.Size(132, 20)
        Me.TextEdit7.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.TextEdit1)
        Me.GroupControl2.Controls.Add(ShipfromidLabel)
        Me.GroupControl2.Controls.Add(Me.Shipfromaddress1TextEdit)
        Me.GroupControl2.Controls.Add(Shipfromaddress1Label)
        Me.GroupControl2.Controls.Add(Me.ShipfrompostalcodeTextEdit)
        Me.GroupControl2.Controls.Add(Me.Shipfromaddress2TextEdit)
        Me.GroupControl2.Controls.Add(Me.ShipfromstateprovTextEdit)
        Me.GroupControl2.Controls.Add(Shipfromaddress2Label)
        Me.GroupControl2.Controls.Add(ShipfromcityLabel)
        Me.GroupControl2.Controls.Add(Me.ShipfromcityTextEdit)
        Me.GroupControl2.Location = New System.Drawing.Point(308, 33)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(348, 155)
        Me.GroupControl2.TabIndex = 28
        Me.GroupControl2.Text = "Origin"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "OriginName", True))
        Me.TextEdit1.Enabled = False
        Me.TextEdit1.Location = New System.Drawing.Point(94, 28)
        Me.TextEdit1.MenuManager = Me.RibbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(240, 20)
        Me.TextEdit1.TabIndex = 21
        '
        'Shipfromaddress1TextEdit
        '
        Me.Shipfromaddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "OriginAddress1", True))
        Me.Shipfromaddress1TextEdit.Enabled = False
        Me.Shipfromaddress1TextEdit.Location = New System.Drawing.Point(94, 54)
        Me.Shipfromaddress1TextEdit.MenuManager = Me.RibbonControl1
        Me.Shipfromaddress1TextEdit.Name = "Shipfromaddress1TextEdit"
        Me.Shipfromaddress1TextEdit.Size = New System.Drawing.Size(240, 20)
        Me.Shipfromaddress1TextEdit.TabIndex = 1
        '
        'ShipfrompostalcodeTextEdit
        '
        Me.ShipfrompostalcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "OriginZip", True))
        Me.ShipfrompostalcodeTextEdit.Enabled = False
        Me.ShipfrompostalcodeTextEdit.Location = New System.Drawing.Point(266, 106)
        Me.ShipfrompostalcodeTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipfrompostalcodeTextEdit.Name = "ShipfrompostalcodeTextEdit"
        Me.ShipfrompostalcodeTextEdit.Size = New System.Drawing.Size(68, 20)
        Me.ShipfrompostalcodeTextEdit.TabIndex = 5
        '
        'Shipfromaddress2TextEdit
        '
        Me.Shipfromaddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "OriginAddress2", True))
        Me.Shipfromaddress2TextEdit.Enabled = False
        Me.Shipfromaddress2TextEdit.Location = New System.Drawing.Point(94, 80)
        Me.Shipfromaddress2TextEdit.MenuManager = Me.RibbonControl1
        Me.Shipfromaddress2TextEdit.Name = "Shipfromaddress2TextEdit"
        Me.Shipfromaddress2TextEdit.Size = New System.Drawing.Size(240, 20)
        Me.Shipfromaddress2TextEdit.TabIndex = 2
        '
        'ShipfromstateprovTextEdit
        '
        Me.ShipfromstateprovTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "OriginState", True))
        Me.ShipfromstateprovTextEdit.Enabled = False
        Me.ShipfromstateprovTextEdit.Location = New System.Drawing.Point(232, 106)
        Me.ShipfromstateprovTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipfromstateprovTextEdit.Name = "ShipfromstateprovTextEdit"
        Me.ShipfromstateprovTextEdit.Size = New System.Drawing.Size(28, 20)
        Me.ShipfromstateprovTextEdit.TabIndex = 4
        '
        'ShipfromcityTextEdit
        '
        Me.ShipfromcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "OriginCity", True))
        Me.ShipfromcityTextEdit.Enabled = False
        Me.ShipfromcityTextEdit.Location = New System.Drawing.Point(94, 106)
        Me.ShipfromcityTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipfromcityTextEdit.Name = "ShipfromcityTextEdit"
        Me.ShipfromcityTextEdit.Size = New System.Drawing.Size(132, 20)
        Me.ShipfromcityTextEdit.TabIndex = 3
        '
        'rbtnPrint
        '
        Me.rbtnPrint.Caption = "Print"
        Me.rbtnPrint.Id = 13
        Me.rbtnPrint.ImageOptions.LargeImageIndex = 5
        Me.rbtnPrint.Name = "rbtnPrint"
        '
        'frmFreightChargesHistory
        '
        Me.ClientSize = New System.Drawing.Size(1382, 794)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmFreightChargesHistory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Freight Charges History"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadMgmt_Images, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.grFreightChargeHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadChargeHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvFreightChargesHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luProductDesc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luStdgallons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.chkFreezeProtect.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVariance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSkids.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoadNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipfromaddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipfrompostalcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shipfromaddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipfromstateprovTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipfromcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grFreightChargeHistory As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvFreightChargesHistory As CustomDevExGridView
    Friend WithEvents luProductDesc As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents luContainer As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents luStdgallons As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddShipmentItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditShipmentItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteShipmentItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsLoadInfo As System.Windows.Forms.BindingSource
    Friend WithEvents bsLoadChargeHistory As System.Windows.Forms.BindingSource
    Friend WithEvents ShipmentdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LoadNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Shipfromaddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipfrompostalcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Shipfromaddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipfromstateprovTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipfromcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnPrintBOL As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnSplitLoad As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LoadMgmt_Images As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnLoadFreightCharges As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colLoadID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtEmailFreightChargesHistory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colActualShipmentDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDestName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalGrossWeight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalSkids As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalCharged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalBilled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents chkFreezeProtect As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents txtVariance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSkids As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colFob As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFreezeProtectFlag As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnPrint As DevExpress.XtraBars.BarButtonItem
End Class
