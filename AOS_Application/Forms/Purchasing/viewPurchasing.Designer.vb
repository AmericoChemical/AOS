<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewPurchasing

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
        Dim VendornameLabel As System.Windows.Forms.Label
        Dim Vendoraddress1Label As System.Windows.Forms.Label
        Dim Vendoraddress2Label As System.Windows.Forms.Label
        Dim VendorcityLabel As System.Windows.Forms.Label
        Dim VendorphoneLabel As System.Windows.Forms.Label
        Dim VendorfaxLabel As System.Windows.Forms.Label
        Dim VendorcontactLabel As System.Windows.Forms.Label
        Dim VendoremailLabel As System.Windows.Forms.Label
        Dim VendorurlLabel As System.Windows.Forms.Label
        Dim VendoracctnumberLabel As System.Windows.Forms.Label
        Dim TermsLabel As System.Windows.Forms.Label
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New CustomDevExGridView()
        Me.GridView2 = New CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAddVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteVendor = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddCostMatrixItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostMatrixItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostMatrixItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddNewPO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditPO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeletePO = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFilterOpenPOs = New DevExpress.XtraBars.BarButtonItem()
        Me.btnFilterClosedPOs = New DevExpress.XtraBars.BarButtonItem()
        Me.btnPrintPO = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReceivePurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReopenPurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancelPurchaseOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddPurchaseRequest = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditPurchaseRequest = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeletePurchaseRequest = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCreatePurchaseOrderFromRequest = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnOpenRequests = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnClosedRequests = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetPurchaseRequests = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCOAText = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintPOItemList = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup10 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.pnlInventory = New DevExpress.XtraEditors.PanelControl()
        Me.grInventory = New DevExpress.XtraGrid.GridControl()
        Me.bsInventory = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyavailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyonorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyminimum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyreorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProductLookupEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnRefreshInventory = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditProductInfo = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCreatePO = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SplitterControl1 = New DevExpress.XtraEditors.SplitterControl()
        Me.pnlPOs = New DevExpress.XtraEditors.PanelControl()
        Me.grPOs = New DevExpress.XtraGrid.GridControl()
        Me.bsPOs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView6 = New CustomDevExGridView()
        Me.colPonumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangeableponumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.bsVendorList = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPodate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpecteddelivery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPotype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPostatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPototal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.TermsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grVendors = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New CustomDevExGridView()
        Me.colVendorid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grSalesperson = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New CustomDevExGridView()
        Me.colSalespersonfirstname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSalespersonlastname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grPurchaseRequests = New DevExpress.XtraGrid.GridControl()
        Me.bsPurchaseRequests = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView7 = New CustomDevExGridView()
        Me.colPurchReqID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchReqDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyContainers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateNeeded = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsOrdered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPONumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        VendornameLabel = New System.Windows.Forms.Label()
        Vendoraddress1Label = New System.Windows.Forms.Label()
        Vendoraddress2Label = New System.Windows.Forms.Label()
        VendorcityLabel = New System.Windows.Forms.Label()
        VendorphoneLabel = New System.Windows.Forms.Label()
        VendorfaxLabel = New System.Windows.Forms.Label()
        VendorcontactLabel = New System.Windows.Forms.Label()
        VendoremailLabel = New System.Windows.Forms.Label()
        VendorurlLabel = New System.Windows.Forms.Label()
        VendoracctnumberLabel = New System.Windows.Forms.Label()
        TermsLabel = New System.Windows.Forms.Label()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl4.SuspendLayout()
        CType(Me.pnlInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlInventory.SuspendLayout()
        CType(Me.grInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductLookupEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlPOs.SuspendLayout()
        CType(Me.grPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPOs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.TermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl5.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grSalesperson, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.grPurchaseRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Vendoraddress1Label
        '
        Vendoraddress1Label.AutoSize = True
        Vendoraddress1Label.Location = New System.Drawing.Point(13, 59)
        Vendoraddress1Label.Name = "Vendoraddress1Label"
        Vendoraddress1Label.Size = New System.Drawing.Size(55, 13)
        Vendoraddress1Label.TabIndex = 2
        Vendoraddress1Label.Text = "Address 1"
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
        'VendorcityLabel
        '
        VendorcityLabel.AutoSize = True
        VendorcityLabel.Location = New System.Drawing.Point(13, 111)
        VendorcityLabel.Name = "VendorcityLabel"
        VendorcityLabel.Size = New System.Drawing.Size(72, 13)
        VendorcityLabel.TabIndex = 6
        VendorcityLabel.Text = "City State Zip"
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
        'VendorfaxLabel
        '
        VendorfaxLabel.AutoSize = True
        VendorfaxLabel.Location = New System.Drawing.Point(13, 163)
        VendorfaxLabel.Name = "VendorfaxLabel"
        VendorfaxLabel.Size = New System.Drawing.Size(66, 13)
        VendorfaxLabel.TabIndex = 14
        VendorfaxLabel.Text = "FAX Number"
        '
        'VendorcontactLabel
        '
        VendorcontactLabel.AutoSize = True
        VendorcontactLabel.Location = New System.Drawing.Point(13, 189)
        VendorcontactLabel.Name = "VendorcontactLabel"
        VendorcontactLabel.Size = New System.Drawing.Size(45, 13)
        VendorcontactLabel.TabIndex = 16
        VendorcontactLabel.Text = "Contact"
        '
        'VendoremailLabel
        '
        VendoremailLabel.AutoSize = True
        VendoremailLabel.Location = New System.Drawing.Point(13, 215)
        VendoremailLabel.Name = "VendoremailLabel"
        VendoremailLabel.Size = New System.Drawing.Size(31, 13)
        VendoremailLabel.TabIndex = 18
        VendoremailLabel.Text = "Email"
        '
        'VendorurlLabel
        '
        VendorurlLabel.AutoSize = True
        VendorurlLabel.Location = New System.Drawing.Point(13, 241)
        VendorurlLabel.Name = "VendorurlLabel"
        VendorurlLabel.Size = New System.Drawing.Size(78, 13)
        VendorurlLabel.TabIndex = 20
        VendorurlLabel.Text = "Web Page URL"
        '
        'VendoracctnumberLabel
        '
        VendoracctnumberLabel.AutoSize = True
        VendoracctnumberLabel.Location = New System.Drawing.Point(13, 267)
        VendoracctnumberLabel.Name = "VendoracctnumberLabel"
        VendoracctnumberLabel.Size = New System.Drawing.Size(57, 13)
        VendoracctnumberLabel.TabIndex = 22
        VendoracctnumberLabel.Text = "Account #"
        '
        'TermsLabel
        '
        TermsLabel.AutoSize = True
        TermsLabel.Location = New System.Drawing.Point(13, 293)
        TermsLabel.Name = "TermsLabel"
        TermsLabel.Size = New System.Drawing.Size(36, 13)
        TermsLabel.TabIndex = 24
        TermsLabel.Text = "Terms"
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
        Me.FormCaption.Size = New System.Drawing.Size(1066, 33)
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
        Me.GridView1.GroupPanelText = "Purchasing Management"
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAddVendor, Me.btnEditVendor, Me.btnDeleteVendor, Me.btnAddCostMatrixItem, Me.btnEditCostMatrixItem, Me.btnDeleteCostMatrixItem, Me.btnAddNewPO, Me.btnEditPO, Me.btnDeletePO, Me.btnFilterOpenPOs, Me.btnFilterClosedPOs, Me.btnPrintPO, Me.rbtnReceivePurchaseOrder, Me.rbtnReopenPurchaseOrder, Me.rbtnCancelPurchaseOrder, Me.rbtnAddPurchaseRequest, Me.rbtnEditPurchaseRequest, Me.rbtnDeletePurchaseRequest, Me.rbtnCreatePurchaseOrderFromRequest, Me.rbtnOpenRequests, Me.rbtnClosedRequests, Me.rbtnGetPurchaseRequests, Me.btnCOAText, Me.rbtnPrintPOItemList})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 76
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage4, Me.RibbonPage3})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1066, 115)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnAddVendor
        '
        Me.btnAddVendor.Caption = "Add New Vendor"
        Me.btnAddVendor.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddVendor.Id = 51
        Me.btnAddVendor.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddVendor.Name = "btnAddVendor"
        Me.btnAddVendor.Tag = "109"
        '
        'btnEditVendor
        '
        Me.btnEditVendor.Caption = "Edit Vendor"
        Me.btnEditVendor.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditVendor.Id = 52
        Me.btnEditVendor.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditVendor.Name = "btnEditVendor"
        Me.btnEditVendor.Tag = "110"
        '
        'btnDeleteVendor
        '
        Me.btnDeleteVendor.Caption = "Delete Vendor"
        Me.btnDeleteVendor.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteVendor.Id = 53
        Me.btnDeleteVendor.LargeGlyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteVendor.Name = "btnDeleteVendor"
        Me.btnDeleteVendor.Tag = "111"
        '
        'btnAddCostMatrixItem
        '
        Me.btnAddCostMatrixItem.Caption = "Add Cost Matrix Item"
        Me.btnAddCostMatrixItem.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddCostMatrixItem.Id = 54
        Me.btnAddCostMatrixItem.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddCostMatrixItem.Name = "btnAddCostMatrixItem"
        '
        'btnEditCostMatrixItem
        '
        Me.btnEditCostMatrixItem.Caption = "Edit Cost Matrix Item"
        Me.btnEditCostMatrixItem.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCostMatrixItem.Id = 55
        Me.btnEditCostMatrixItem.Name = "btnEditCostMatrixItem"
        '
        'btnDeleteCostMatrixItem
        '
        Me.btnDeleteCostMatrixItem.Caption = "Delete Cost Matrix Item"
        Me.btnDeleteCostMatrixItem.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCostMatrixItem.Id = 56
        Me.btnDeleteCostMatrixItem.Name = "btnDeleteCostMatrixItem"
        '
        'btnAddNewPO
        '
        Me.btnAddNewPO.Caption = "Add New Purchase Order"
        Me.btnAddNewPO.Glyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddNewPO.Id = 57
        Me.btnAddNewPO.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAddNewPO.Name = "btnAddNewPO"
        Me.btnAddNewPO.Tag = "112"
        '
        'btnEditPO
        '
        Me.btnEditPO.Caption = "Edit Purchase Order"
        Me.btnEditPO.Glyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditPO.Id = 58
        Me.btnEditPO.Name = "btnEditPO"
        Me.btnEditPO.Tag = "113"
        '
        'btnDeletePO
        '
        Me.btnDeletePO.Caption = "Delete Purchase Order"
        Me.btnDeletePO.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeletePO.Id = 59
        Me.btnDeletePO.Name = "btnDeletePO"
        Me.btnDeletePO.Tag = "114"
        '
        'btnFilterOpenPOs
        '
        Me.btnFilterOpenPOs.Caption = "Open"
        Me.btnFilterOpenPOs.Id = 60
        Me.btnFilterOpenPOs.LargeGlyph = Global.AOS.My.Resources.Resources.Filter
        Me.btnFilterOpenPOs.Name = "btnFilterOpenPOs"
        Me.btnFilterOpenPOs.Tag = "115"
        '
        'btnFilterClosedPOs
        '
        Me.btnFilterClosedPOs.Caption = "Closed"
        Me.btnFilterClosedPOs.Id = 61
        Me.btnFilterClosedPOs.LargeGlyph = Global.AOS.My.Resources.Resources.Filter
        Me.btnFilterClosedPOs.Name = "btnFilterClosedPOs"
        Me.btnFilterClosedPOs.Tag = "116"
        '
        'btnPrintPO
        '
        Me.btnPrintPO.Caption = "Print Purchase Order"
        Me.btnPrintPO.Id = 62
        Me.btnPrintPO.LargeGlyph = Global.AOS.My.Resources.Resources.Report1
        Me.btnPrintPO.Name = "btnPrintPO"
        Me.btnPrintPO.Tag = "120"
        '
        'rbtnReceivePurchaseOrder
        '
        Me.rbtnReceivePurchaseOrder.Caption = "Mark PO Received"
        Me.rbtnReceivePurchaseOrder.Id = 63
        Me.rbtnReceivePurchaseOrder.LargeGlyph = Global.AOS.My.Resources.Resources.document_accept__2_
        Me.rbtnReceivePurchaseOrder.Name = "rbtnReceivePurchaseOrder"
        Me.rbtnReceivePurchaseOrder.Tag = "117"
        '
        'rbtnReopenPurchaseOrder
        '
        Me.rbtnReopenPurchaseOrder.Caption = "Reopen PO"
        Me.rbtnReopenPurchaseOrder.Id = 64
        Me.rbtnReopenPurchaseOrder.LargeGlyph = Global.AOS.My.Resources.Resources.document_edit__2_
        Me.rbtnReopenPurchaseOrder.Name = "rbtnReopenPurchaseOrder"
        Me.rbtnReopenPurchaseOrder.Tag = "119"
        '
        'rbtnCancelPurchaseOrder
        '
        Me.rbtnCancelPurchaseOrder.Caption = "Mark PO Cancelled"
        Me.rbtnCancelPurchaseOrder.Id = 65
        Me.rbtnCancelPurchaseOrder.LargeGlyph = Global.AOS.My.Resources.Resources.document_delete3__2_
        Me.rbtnCancelPurchaseOrder.Name = "rbtnCancelPurchaseOrder"
        Me.rbtnCancelPurchaseOrder.Tag = "118"
        '
        'rbtnAddPurchaseRequest
        '
        Me.rbtnAddPurchaseRequest.Caption = "Add New Request"
        Me.rbtnAddPurchaseRequest.Id = 66
        Me.rbtnAddPurchaseRequest.LargeGlyph = Global.AOS.My.Resources.Resources.document_add__2_
        Me.rbtnAddPurchaseRequest.Name = "rbtnAddPurchaseRequest"
        Me.rbtnAddPurchaseRequest.Tag = "124"
        '
        'rbtnEditPurchaseRequest
        '
        Me.rbtnEditPurchaseRequest.Caption = "Edit Request"
        Me.rbtnEditPurchaseRequest.Glyph = Global.AOS.My.Resources.Resources.document_edit__2_
        Me.rbtnEditPurchaseRequest.Id = 67
        Me.rbtnEditPurchaseRequest.Name = "rbtnEditPurchaseRequest"
        Me.rbtnEditPurchaseRequest.Tag = "125"
        '
        'rbtnDeletePurchaseRequest
        '
        Me.rbtnDeletePurchaseRequest.Caption = "Delete Request"
        Me.rbtnDeletePurchaseRequest.Glyph = Global.AOS.My.Resources.Resources.document_delete__2_
        Me.rbtnDeletePurchaseRequest.Id = 68
        Me.rbtnDeletePurchaseRequest.Name = "rbtnDeletePurchaseRequest"
        Me.rbtnDeletePurchaseRequest.Tag = "126"
        '
        'rbtnCreatePurchaseOrderFromRequest
        '
        Me.rbtnCreatePurchaseOrderFromRequest.Caption = "Create Purchase Order"
        Me.rbtnCreatePurchaseOrderFromRequest.Id = 69
        Me.rbtnCreatePurchaseOrderFromRequest.LargeGlyph = Global.AOS.My.Resources.Resources.edit_add
        Me.rbtnCreatePurchaseOrderFromRequest.Name = "rbtnCreatePurchaseOrderFromRequest"
        Me.rbtnCreatePurchaseOrderFromRequest.Tag = "129"
        '
        'rbtnOpenRequests
        '
        Me.rbtnOpenRequests.Caption = "Open"
        Me.rbtnOpenRequests.Id = 70
        Me.rbtnOpenRequests.LargeGlyph = Global.AOS.My.Resources.Resources.Filter
        Me.rbtnOpenRequests.Name = "rbtnOpenRequests"
        Me.rbtnOpenRequests.Tag = "127"
        '
        'rbtnClosedRequests
        '
        Me.rbtnClosedRequests.Caption = "Closed"
        Me.rbtnClosedRequests.Id = 71
        Me.rbtnClosedRequests.LargeGlyph = Global.AOS.My.Resources.Resources.Filter
        Me.rbtnClosedRequests.Name = "rbtnClosedRequests"
        Me.rbtnClosedRequests.Tag = "128"
        '
        'rbtnGetPurchaseRequests
        '
        Me.rbtnGetPurchaseRequests.Caption = "Get Open Requests"
        Me.rbtnGetPurchaseRequests.Id = 72
        Me.rbtnGetPurchaseRequests.LargeGlyph = Global.AOS.My.Resources.Resources.FindRecord
        Me.rbtnGetPurchaseRequests.Name = "rbtnGetPurchaseRequests"
        Me.rbtnGetPurchaseRequests.Tag = "123"
        '
        'btnCOAText
        '
        Me.btnCOAText.Caption = "COA Text"
        Me.btnCOAText.Glyph = Global.AOS.My.Resources.Resources.document_edit
        Me.btnCOAText.Id = 73
        Me.btnCOAText.LargeGlyph = Global.AOS.My.Resources.Resources.document_edit
        Me.btnCOAText.Name = "btnCOAText"
        Me.btnCOAText.Tag = "122"
        '
        'rbtnPrintPOItemList
        '
        Me.rbtnPrintPOItemList.Caption = "PO Item List"
        Me.rbtnPrintPOItemList.Id = 75
        Me.rbtnPrintPOItemList.LargeGlyph = Global.AOS.My.Resources.Resources.list__4_
        Me.rbtnPrintPOItemList.Name = "rbtnPrintPOItemList"
        Me.rbtnPrintPOItemList.Tag = "121"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "18"
        Me.RibbonPage1.Text = "Vendors"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddVendor)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnEditVendor)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDeleteVendor)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Vendor Information"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup4, Me.RibbonPageGroup6, Me.RibbonPageGroup5, Me.RibbonPageGroup10})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Tag = "19"
        Me.RibbonPage4.Text = "Purchase Orders"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddNewPO)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditPO)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeletePO)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Purchase Order Information"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnFilterOpenPOs)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnFilterClosedPOs)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Status Filter"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowMinimize = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnReceivePurchaseOrder)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnCancelPurchaseOrder)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnReopenPurchaseOrder)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Status Actions"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.btnPrintPO)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnPrintPOItemList)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Reports"
        '
        'RibbonPageGroup10
        '
        Me.RibbonPageGroup10.ItemLinks.Add(Me.btnCOAText)
        Me.RibbonPageGroup10.Name = "RibbonPageGroup10"
        Me.RibbonPageGroup10.ShowCaptionButton = False
        Me.RibbonPageGroup10.Text = "Miscellaneous"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup7, Me.RibbonPageGroup9, Me.RibbonPageGroup8})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Tag = "20"
        Me.RibbonPage3.Text = "Purchase Requests"
        '
        'RibbonPageGroup7
        '
        Me.RibbonPageGroup7.AllowMinimize = False
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnGetPurchaseRequests)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnAddPurchaseRequest, True)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnEditPurchaseRequest)
        Me.RibbonPageGroup7.ItemLinks.Add(Me.rbtnDeletePurchaseRequest)
        Me.RibbonPageGroup7.Name = "RibbonPageGroup7"
        Me.RibbonPageGroup7.ShowCaptionButton = False
        Me.RibbonPageGroup7.Text = "Purchase Request Information"
        '
        'RibbonPageGroup9
        '
        Me.RibbonPageGroup9.AllowMinimize = False
        Me.RibbonPageGroup9.ItemLinks.Add(Me.rbtnOpenRequests)
        Me.RibbonPageGroup9.ItemLinks.Add(Me.rbtnClosedRequests)
        Me.RibbonPageGroup9.Name = "RibbonPageGroup9"
        Me.RibbonPageGroup9.ShowCaptionButton = False
        Me.RibbonPageGroup9.Text = "Requests Filter"
        '
        'RibbonPageGroup8
        '
        Me.RibbonPageGroup8.AllowMinimize = False
        Me.RibbonPageGroup8.ItemLinks.Add(Me.rbtnCreatePurchaseOrderFromRequest)
        Me.RibbonPageGroup8.Name = "RibbonPageGroup8"
        Me.RibbonPageGroup8.ShowCaptionButton = False
        Me.RibbonPageGroup8.Text = "Purchase Order"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'WorkPanelsHolder
        '
        Me.WorkPanelsHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl6)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 148)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1066, 476)
        Me.WorkPanelsHolder.TabIndex = 7
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Controls.Add(Me.pnlInventory)
        Me.RibbonPanelControl4.Controls.Add(Me.SplitterControl1)
        Me.RibbonPanelControl4.Controls.Add(Me.pnlPOs)
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1066, 476)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'pnlInventory
        '
        Me.pnlInventory.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlInventory.Controls.Add(Me.grInventory)
        Me.pnlInventory.Controls.Add(Me.PanelControl1)
        Me.pnlInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlInventory.Location = New System.Drawing.Point(8, 225)
        Me.pnlInventory.Name = "pnlInventory"
        Me.pnlInventory.Size = New System.Drawing.Size(1050, 243)
        Me.pnlInventory.TabIndex = 2
        '
        'grInventory
        '
        Me.grInventory.DataSource = Me.bsInventory
        Me.grInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInventory.Location = New System.Drawing.Point(0, 94)
        Me.grInventory.LookAndFeel.SkinName = "Money Twins"
        Me.grInventory.MainView = Me.GridView5
        Me.grInventory.Name = "grInventory"
        Me.grInventory.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ProductLookupEdit})
        Me.grInventory.Size = New System.Drawing.Size(1050, 149)
        Me.grInventory.TabIndex = 1
        Me.grInventory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'bsInventory
        '
        Me.bsInventory.DataSource = GetType(AOS.BusinessObjects.InventoryCollection)
        '
        'GridView5
        '
        Me.GridView5.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView5.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView5.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView5.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView5.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView5.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView5.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView5.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView5.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView5.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView5.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView5.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView5.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView5.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView5.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView5.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView5.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView5.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView5.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView5.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView5.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView5.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView5.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView5.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colQtyavailable, Me.colQtyonorder, Me.colQtyminimum, Me.colBalance, Me.colQtyreorder})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView5.GridControl = Me.grInventory
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 0
        Me.colProductid.Width = 56
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 1
        Me.colProductdesc.Width = 150
        '
        'colContainer
        '
        Me.colContainer.Caption = "Container"
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 2
        Me.colContainer.Width = 59
        '
        'colQtyavailable
        '
        Me.colQtyavailable.Caption = "Available"
        Me.colQtyavailable.FieldName = "Qtyavailable"
        Me.colQtyavailable.Name = "colQtyavailable"
        Me.colQtyavailable.Visible = True
        Me.colQtyavailable.VisibleIndex = 3
        '
        'colQtyonorder
        '
        Me.colQtyonorder.Caption = "On Order"
        Me.colQtyonorder.FieldName = "Qtyonorder"
        Me.colQtyonorder.Name = "colQtyonorder"
        Me.colQtyonorder.Visible = True
        Me.colQtyonorder.VisibleIndex = 4
        '
        'colQtyminimum
        '
        Me.colQtyminimum.Caption = "Minimum"
        Me.colQtyminimum.FieldName = "Qtyminimum"
        Me.colQtyminimum.Name = "colQtyminimum"
        Me.colQtyminimum.Visible = True
        Me.colQtyminimum.VisibleIndex = 5
        '
        'colBalance
        '
        Me.colBalance.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.colBalance.AppearanceCell.Options.UseBackColor = True
        Me.colBalance.Caption = "Balance"
        Me.colBalance.FieldName = "Balance"
        Me.colBalance.Name = "colBalance"
        Me.colBalance.Visible = True
        Me.colBalance.VisibleIndex = 6
        '
        'colQtyreorder
        '
        Me.colQtyreorder.Caption = "Reorder"
        Me.colQtyreorder.FieldName = "Qtyreorder"
        Me.colQtyreorder.Name = "colQtyreorder"
        Me.colQtyreorder.Visible = True
        Me.colQtyreorder.VisibleIndex = 7
        Me.colQtyreorder.Width = 70
        '
        'ProductLookupEdit
        '
        Me.ProductLookupEdit.AutoHeight = False
        Me.ProductLookupEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProductLookupEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ProductLookupEdit.DataSource = Me.bsProducts
        Me.ProductLookupEdit.DisplayMember = "Productdesc"
        Me.ProductLookupEdit.Name = "ProductLookupEdit"
        Me.ProductLookupEdit.NullText = ""
        Me.ProductLookupEdit.ReadOnly = True
        Me.ProductLookupEdit.ShowFooter = False
        Me.ProductLookupEdit.ShowHeader = False
        Me.ProductLookupEdit.ValueMember = "Productid"
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.RibbonControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1050, 94)
        Me.PanelControl1.TabIndex = 2
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ApplicationButtonText = Nothing
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.btnRefreshInventory, Me.btnEditProductInfo, Me.btnCreatePO})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 3
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2})
        Me.RibbonControl2.ShowCategoryInCaption = False
        Me.RibbonControl2.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl2.ShowToolbarCustomizeItem = False
        Me.RibbonControl2.Size = New System.Drawing.Size(1050, 93)
        Me.RibbonControl2.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnRefreshInventory
        '
        Me.btnRefreshInventory.Caption = "Update Inventory"
        Me.btnRefreshInventory.Id = 0
        Me.btnRefreshInventory.LargeGlyph = Global.AOS.My.Resources.Resources.Refresh
        Me.btnRefreshInventory.Name = "btnRefreshInventory"
        '
        'btnEditProductInfo
        '
        Me.btnEditProductInfo.Caption = "Edit Product Information"
        Me.btnEditProductInfo.Id = 1
        Me.btnEditProductInfo.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditProductInfo.Name = "btnEditProductInfo"
        '
        'btnCreatePO
        '
        Me.btnCreatePO.Caption = "Create Re-Order"
        Me.btnCreatePO.Id = 2
        Me.btnCreatePO.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnCreatePO.Name = "btnCreatePO"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnRefreshInventory)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnEditProductInfo, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.btnCreatePO, True)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Current Inventory"
        '
        'SplitterControl1
        '
        Me.SplitterControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitterControl1.Location = New System.Drawing.Point(8, 220)
        Me.SplitterControl1.Name = "SplitterControl1"
        Me.SplitterControl1.Size = New System.Drawing.Size(1050, 5)
        Me.SplitterControl1.TabIndex = 1
        Me.SplitterControl1.TabStop = False
        '
        'pnlPOs
        '
        Me.pnlPOs.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlPOs.Controls.Add(Me.grPOs)
        Me.pnlPOs.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPOs.Location = New System.Drawing.Point(8, 8)
        Me.pnlPOs.Name = "pnlPOs"
        Me.pnlPOs.Size = New System.Drawing.Size(1050, 212)
        Me.pnlPOs.TabIndex = 0
        '
        'grPOs
        '
        Me.grPOs.DataSource = Me.bsPOs
        Me.grPOs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPOs.Location = New System.Drawing.Point(0, 0)
        Me.grPOs.LookAndFeel.SkinName = "Money Twins"
        Me.grPOs.MainView = Me.GridView6
        Me.grPOs.Name = "grPOs"
        Me.grPOs.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2})
        Me.grPOs.Size = New System.Drawing.Size(1050, 212)
        Me.grPOs.TabIndex = 1
        Me.grPOs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView6})
        '
        'bsPOs
        '
        Me.bsPOs.DataSource = GetType(AOS.BusinessObjects.PoCollection)
        '
        'GridView6
        '
        Me.GridView6.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView6.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView6.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView6.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView6.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView6.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView6.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView6.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView6.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView6.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView6.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView6.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView6.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView6.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView6.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView6.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView6.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView6.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView6.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView6.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView6.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView6.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView6.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView6.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView6.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPonumber, Me.colChangeableponumber, Me.colVendorid1, Me.colPodate, Me.colExpecteddelivery, Me.colPotype, Me.colPostatus, Me.colPototal})
        Me.GridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView6.GridControl = Me.grPOs
        Me.GridView6.Name = "GridView6"
        Me.GridView6.OptionsBehavior.Editable = False
        Me.GridView6.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView6.OptionsView.ShowGroupPanel = False
        Me.GridView6.OptionsView.ShowIndicator = False
        '
        'colPonumber
        '
        Me.colPonumber.Caption = "PO #"
        Me.colPonumber.FieldName = "Ponumber"
        Me.colPonumber.Name = "colPonumber"
        Me.colPonumber.Visible = True
        Me.colPonumber.VisibleIndex = 0
        Me.colPonumber.Width = 50
        '
        'colChangeableponumber
        '
        Me.colChangeableponumber.Caption = "CustomPO"
        Me.colChangeableponumber.FieldName = "Changeableponumber"
        Me.colChangeableponumber.Name = "colChangeableponumber"
        Me.colChangeableponumber.Visible = True
        Me.colChangeableponumber.VisibleIndex = 1
        '
        'colVendorid1
        '
        Me.colVendorid1.Caption = "Vendor"
        Me.colVendorid1.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.colVendorid1.FieldName = "Vendorid"
        Me.colVendorid1.Name = "colVendorid1"
        Me.colVendorid1.Visible = True
        Me.colVendorid1.VisibleIndex = 2
        Me.colVendorid1.Width = 159
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.bsVendorList
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Vendorname"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.PopupSizeable = False
        Me.RepositoryItemLookUpEdit2.ValueMember = "Vendorid"
        '
        'bsVendorList
        '
        Me.bsVendorList.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'colPodate
        '
        Me.colPodate.Caption = "PO Date"
        Me.colPodate.DisplayFormat.FormatString = "d"
        Me.colPodate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPodate.FieldName = "Podate"
        Me.colPodate.Name = "colPodate"
        Me.colPodate.Visible = True
        Me.colPodate.VisibleIndex = 3
        Me.colPodate.Width = 78
        '
        'colExpecteddelivery
        '
        Me.colExpecteddelivery.Caption = "Expected"
        Me.colExpecteddelivery.DisplayFormat.FormatString = "d"
        Me.colExpecteddelivery.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colExpecteddelivery.FieldName = "Expecteddelivery"
        Me.colExpecteddelivery.Name = "colExpecteddelivery"
        Me.colExpecteddelivery.Visible = True
        Me.colExpecteddelivery.VisibleIndex = 4
        Me.colExpecteddelivery.Width = 82
        '
        'colPotype
        '
        Me.colPotype.Caption = "Type"
        Me.colPotype.FieldName = "Potype"
        Me.colPotype.Name = "colPotype"
        Me.colPotype.Visible = True
        Me.colPotype.VisibleIndex = 5
        Me.colPotype.Width = 104
        '
        'colPostatus
        '
        Me.colPostatus.Caption = "Status"
        Me.colPostatus.FieldName = "Postatus"
        Me.colPostatus.Name = "colPostatus"
        Me.colPostatus.Visible = True
        Me.colPostatus.VisibleIndex = 6
        Me.colPostatus.Width = 79
        '
        'colPototal
        '
        Me.colPototal.Caption = "Total $"
        Me.colPototal.DisplayFormat.FormatString = "c2"
        Me.colPototal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPototal.FieldName = "Pototal"
        Me.colPototal.Name = "colPototal"
        Me.colPototal.Visible = True
        Me.colPototal.VisibleIndex = 7
        Me.colPototal.Width = 94
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ReadOnly = True
        Me.RepositoryItemLookUpEdit1.ShowFooter = False
        Me.RepositoryItemLookUpEdit1.ShowHeader = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "Productid"
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Controls.Add(Me.PanelControl9)
        Me.RibbonPanelControl1.Controls.Add(Me.PanelControl8)
        Me.RibbonPanelControl1.Controls.Add(Me.GroupControl1)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1066, 476)
        Me.RibbonPanelControl1.TabIndex = 0
        '
        'PanelControl9
        '
        Me.PanelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl9.Controls.Add(Me.GroupControl3)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl9.Location = New System.Drawing.Point(325, 8)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(733, 460)
        Me.PanelControl9.TabIndex = 2
        '
        'GroupControl3
        '
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
        Me.GroupControl3.Location = New System.Drawing.Point(6, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(368, 329)
        Me.GroupControl3.TabIndex = 26
        Me.GroupControl3.Text = "Vendor Information"
        '
        'TermsTextEdit
        '
        Me.TermsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Terms", True))
        Me.TermsTextEdit.Location = New System.Drawing.Point(97, 290)
        Me.TermsTextEdit.Name = "TermsTextEdit"
        Me.TermsTextEdit.Properties.ReadOnly = True
        Me.TermsTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.TermsTextEdit.TabIndex = 25
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
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
        Me.VendoracctnumberTextEdit.Location = New System.Drawing.Point(97, 264)
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
        Me.VendorurlTextEdit.Location = New System.Drawing.Point(97, 238)
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
        Me.VendoremailTextEdit.Location = New System.Drawing.Point(97, 212)
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
        Me.VendorcontactTextEdit.Location = New System.Drawing.Point(97, 186)
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
        Me.VendorphoneTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendorphoneTextEdit.TabIndex = 13
        '
        'VendorfaxTextEdit
        '
        Me.VendorfaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsVendors, "Vendorfax", True))
        Me.VendorfaxTextEdit.Location = New System.Drawing.Point(97, 160)
        Me.VendorfaxTextEdit.Name = "VendorfaxTextEdit"
        Me.VendorfaxTextEdit.Properties.ReadOnly = True
        Me.VendorfaxTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendorfaxTextEdit.TabIndex = 15
        '
        'PanelControl8
        '
        Me.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl8.Location = New System.Drawing.Point(319, 8)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Size = New System.Drawing.Size(6, 460)
        Me.PanelControl8.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grVendors)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(311, 460)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Vendor List"
        '
        'grVendors
        '
        Me.grVendors.DataSource = Me.bsVendors
        Me.grVendors.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grVendors.Location = New System.Drawing.Point(2, 27)
        Me.grVendors.LookAndFeel.SkinName = "Money Twins"
        Me.grVendors.MainView = Me.GridView3
        Me.grVendors.Name = "grVendors"
        Me.grVendors.Size = New System.Drawing.Size(307, 431)
        Me.grVendors.TabIndex = 0
        Me.grVendors.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView3.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView3.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView3.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView3.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView3.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView3.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView3.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView3.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView3.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView3.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colVendorid, Me.colVendorname})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView3.GridControl = Me.grVendors
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colVendorid
        '
        Me.colVendorid.Caption = "ID"
        Me.colVendorid.FieldName = "Vendorid"
        Me.colVendorid.Name = "colVendorid"
        Me.colVendorid.Visible = True
        Me.colVendorid.VisibleIndex = 0
        Me.colVendorid.Width = 53
        '
        'colVendorname
        '
        Me.colVendorname.Caption = "Vendor Name"
        Me.colVendorname.FieldName = "Vendorname"
        Me.colVendorname.Name = "colVendorname"
        Me.colVendorname.Visible = True
        Me.colVendorname.VisibleIndex = 1
        Me.colVendorname.Width = 301
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Controls.Add(Me.GroupControl2)
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(1066, 476)
        Me.RibbonPanelControl5.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grSalesperson)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupControl2.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(362, 460)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Salesperson List"
        '
        'grSalesperson
        '
        Me.grSalesperson.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grSalesperson.Location = New System.Drawing.Point(2, 27)
        Me.grSalesperson.LookAndFeel.SkinName = "Money Twins"
        Me.grSalesperson.MainView = Me.GridView4
        Me.grSalesperson.Name = "grSalesperson"
        Me.grSalesperson.Size = New System.Drawing.Size(358, 431)
        Me.grSalesperson.TabIndex = 0
        Me.grSalesperson.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
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
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSalespersonfirstname, Me.colSalespersonlastname})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView4.GridControl = Me.grSalesperson
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colSalespersonfirstname
        '
        Me.colSalespersonfirstname.Caption = "First Name"
        Me.colSalespersonfirstname.FieldName = "Salespersonfirstname"
        Me.colSalespersonfirstname.Name = "colSalespersonfirstname"
        Me.colSalespersonfirstname.Visible = True
        Me.colSalespersonfirstname.VisibleIndex = 0
        '
        'colSalespersonlastname
        '
        Me.colSalespersonlastname.Caption = "Last Name"
        Me.colSalespersonlastname.FieldName = "Salespersonlastname"
        Me.colSalespersonlastname.Name = "colSalespersonlastname"
        Me.colSalespersonlastname.Visible = True
        Me.colSalespersonlastname.VisibleIndex = 1
        '
        'RibbonPanelControl6
        '
        Me.RibbonPanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl6.Name = "RibbonPanelControl6"
        Me.RibbonPanelControl6.Size = New System.Drawing.Size(1066, 476)
        Me.RibbonPanelControl6.TabIndex = 1
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1066, 476)
        Me.RibbonPanelControl2.TabIndex = 1
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.grPurchaseRequests)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1066, 476)
        Me.RibbonPanelControl3.TabIndex = 1
        '
        'grPurchaseRequests
        '
        Me.grPurchaseRequests.DataSource = Me.bsPurchaseRequests
        Me.grPurchaseRequests.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grPurchaseRequests.Location = New System.Drawing.Point(8, 8)
        Me.grPurchaseRequests.LookAndFeel.SkinName = "Money Twins"
        Me.grPurchaseRequests.MainView = Me.GridView7
        Me.grPurchaseRequests.Name = "grPurchaseRequests"
        Me.grPurchaseRequests.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit4, Me.RepositoryItemLookUpEdit3})
        Me.grPurchaseRequests.Size = New System.Drawing.Size(1050, 460)
        Me.grPurchaseRequests.TabIndex = 2
        Me.grPurchaseRequests.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView7})
        '
        'bsPurchaseRequests
        '
        Me.bsPurchaseRequests.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseRequestCollection)
        '
        'GridView7
        '
        Me.GridView7.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView7.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView7.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView7.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView7.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView7.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView7.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView7.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView7.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView7.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView7.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView7.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView7.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView7.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView7.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView7.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView7.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView7.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView7.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView7.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView7.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView7.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView7.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView7.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView7.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView7.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView7.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView7.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView7.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPurchReqID, Me.colPurchReqDate, Me.colProductID1, Me.colQtyContainers, Me.colDateNeeded, Me.colIsOrdered, Me.colPONumber1, Me.colProductdesc1, Me.colUnits, Me.colUom, Me.colContainer1, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.GridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView7.GridControl = Me.grPurchaseRequests
        Me.GridView7.Name = "GridView7"
        Me.GridView7.OptionsBehavior.Editable = False
        Me.GridView7.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView7.OptionsView.ShowGroupPanel = False
        Me.GridView7.OptionsView.ShowIndicator = False
        '
        'colPurchReqID
        '
        Me.colPurchReqID.FieldName = "PurchReqID"
        Me.colPurchReqID.Name = "colPurchReqID"
        '
        'colPurchReqDate
        '
        Me.colPurchReqDate.DisplayFormat.FormatString = "d"
        Me.colPurchReqDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colPurchReqDate.FieldName = "PurchReqDate"
        Me.colPurchReqDate.Name = "colPurchReqDate"
        Me.colPurchReqDate.Visible = True
        Me.colPurchReqDate.VisibleIndex = 0
        Me.colPurchReqDate.Width = 80
        '
        'colProductID1
        '
        Me.colProductID1.FieldName = "ProductID"
        Me.colProductID1.Name = "colProductID1"
        Me.colProductID1.Visible = True
        Me.colProductID1.VisibleIndex = 2
        Me.colProductID1.Width = 65
        '
        'colQtyContainers
        '
        Me.colQtyContainers.Caption = "Qty"
        Me.colQtyContainers.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQtyContainers.FieldName = "QtyContainers"
        Me.colQtyContainers.Name = "colQtyContainers"
        Me.colQtyContainers.Visible = True
        Me.colQtyContainers.VisibleIndex = 1
        Me.colQtyContainers.Width = 36
        '
        'colDateNeeded
        '
        Me.colDateNeeded.DisplayFormat.FormatString = "d"
        Me.colDateNeeded.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colDateNeeded.FieldName = "DateNeeded"
        Me.colDateNeeded.Name = "colDateNeeded"
        Me.colDateNeeded.Visible = True
        Me.colDateNeeded.VisibleIndex = 7
        Me.colDateNeeded.Width = 80
        '
        'colIsOrdered
        '
        Me.colIsOrdered.FieldName = "IsOrdered"
        Me.colIsOrdered.Name = "colIsOrdered"
        '
        'colPONumber1
        '
        Me.colPONumber1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPONumber1.FieldName = "PONumber"
        Me.colPONumber1.Name = "colPONumber1"
        Me.colPONumber1.Visible = True
        Me.colPONumber1.VisibleIndex = 8
        Me.colPONumber1.Width = 69
        '
        'colProductdesc1
        '
        Me.colProductdesc1.Caption = "Product Description"
        Me.colProductdesc1.FieldName = "Productdesc"
        Me.colProductdesc1.Name = "colProductdesc1"
        Me.colProductdesc1.Visible = True
        Me.colProductdesc1.VisibleIndex = 3
        Me.colProductdesc1.Width = 180
        '
        'colUnits
        '
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.Visible = True
        Me.colUnits.VisibleIndex = 5
        Me.colUnits.Width = 40
        '
        'colUom
        '
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 6
        Me.colUom.Width = 44
        '
        'colContainer1
        '
        Me.colContainer1.FieldName = "Container"
        Me.colContainer1.Name = "colContainer1"
        Me.colContainer1.Visible = True
        Me.colContainer1.VisibleIndex = 4
        Me.colContainer1.Width = 66
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "WO #"
        Me.GridColumn1.FieldName = "WorkOrderNumber"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 9
        Me.GridColumn1.Width = 47
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Customer"
        Me.GridColumn2.FieldName = "Custname"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 10
        Me.GridColumn2.Width = 152
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Req Vendor"
        Me.GridColumn3.FieldName = "Vendorname"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 11
        Me.GridColumn3.Width = 191
        '
        'RepositoryItemLookUpEdit4
        '
        Me.RepositoryItemLookUpEdit4.AutoHeight = False
        Me.RepositoryItemLookUpEdit4.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit4.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Productid", 64, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Productdesc", 65, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.RepositoryItemLookUpEdit4.DataSource = Me.bsProducts
        Me.RepositoryItemLookUpEdit4.DisplayMember = "Productdesc"
        Me.RepositoryItemLookUpEdit4.Name = "RepositoryItemLookUpEdit4"
        Me.RepositoryItemLookUpEdit4.NullText = ""
        Me.RepositoryItemLookUpEdit4.ReadOnly = True
        Me.RepositoryItemLookUpEdit4.ShowFooter = False
        Me.RepositoryItemLookUpEdit4.ShowHeader = False
        Me.RepositoryItemLookUpEdit4.ValueMember = "Productid"
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.bsVendorList
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Vendorname"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.NullText = ""
        Me.RepositoryItemLookUpEdit3.PopupSizeable = False
        Me.RepositoryItemLookUpEdit3.ValueMember = "Vendorid"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'viewPurchasing
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.Name = "viewPurchasing"
        Me.Size = New System.Drawing.Size(1066, 624)
        Me.Tag = "viewPurchasing"
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl4.ResumeLayout(False)
        CType(Me.pnlInventory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlInventory.ResumeLayout(False)
        CType(Me.grInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductLookupEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlPOs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlPOs.ResumeLayout(False)
        CType(Me.grPOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPOs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.TermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl5.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grSalesperson, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.grPurchaseRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grVendors As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As CustomDevExGridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grSalesperson As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents colSalespersonfirstname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSalespersonlastname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents colVendorid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TermsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendoracctnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorurlTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendoremailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorfaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorphoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorzipTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorstateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vendoraddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vendoraddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendornameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnAddVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteVendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsVendorList As System.Windows.Forms.BindingSource
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents btnAddCostMatrixItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostMatrixItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostMatrixItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddNewPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsInventory As System.Windows.Forms.BindingSource
    Friend WithEvents pnlInventory As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitterControl1 As DevExpress.XtraEditors.SplitterControl
    Friend WithEvents pnlPOs As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grInventory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As CustomDevExGridView
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyavailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyonorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyminimum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyreorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProductLookupEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents grPOs As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView6 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bsPOs As System.Windows.Forms.BindingSource
    Friend WithEvents colPonumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPodate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpecteddelivery As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPotype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPostatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPototal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnRefreshInventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditProductInfo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCreatePO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeletePO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFilterOpenPOs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnFilterClosedPOs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnPrintPO As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rbtnReceivePurchaseOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnReopenPurchaseOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancelPurchaseOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnAddPurchaseRequest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditPurchaseRequest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeletePurchaseRequest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents grPurchaseRequests As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsPurchaseRequests As System.Windows.Forms.BindingSource
    Friend WithEvents GridView7 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rbtnCreatePurchaseOrderFromRequest As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnOpenRequests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnClosedRequests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colPurchReqID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchReqDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyContainers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateNeeded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsOrdered As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPONumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnGetPurchaseRequests As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangeableponumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnCOAText As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup10 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnPrintPOItemList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
