<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFreightCharges

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFreightCharges))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsWeightByClass = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnSelectQuote = New DevExpress.XtraBars.BarButtonItem()
        Me.rTxtLoadID = New DevExpress.XtraBars.BarStaticItem()
        Me.rTxtLoadGrossWeight = New DevExpress.XtraBars.BarStaticItem()
        Me.rTxtDestZip = New DevExpress.XtraBars.BarStaticItem()
        Me.Ribbon_LargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.bsWeightByContainer = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New CustomDevExGridView()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrossWgt1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumContainers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadID4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New CustomDevExGridView()
        Me.colClassRate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGrossWgt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadID3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsLoadQuotes = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New CustomDevExGridView()
        Me.colLoadQuoteID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadID2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierName1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsProviderID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsname1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuoteDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierQuoteNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl5 = New DevExpress.XtraGrid.GridControl()
        Me.bsLoadBillings = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView5 = New CustomDevExGridView()
        Me.colLoadbillingid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBilledAmount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl4 = New DevExpress.XtraGrid.GridControl()
        Me.bsLoadCharges = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New CustomDevExGridView()
        Me.colLoadChargeID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadID1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsProviderID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogisticsname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCarrierCharges = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChargeType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChargeDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedBy1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLoadChargeStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnAddFreightCharge = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditFreightCharge = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteCharge = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddBillingRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditBillingRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnDeleteBillingRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsLoadDetails = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.bsWeightByClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWeightByContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadQuotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl6.SuspendLayout()
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl7.SuspendLayout()
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl9.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadBillings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl8.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadCharges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsWeightByClass
        '
        Me.bsWeightByClass.DataSource = GetType(AOS.BusinessObjects.ViewLoadWeightByItemClassCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.rbtnAddQuote, Me.rbtnEditQuote, Me.rbtnDeleteQuote, Me.rbtnSelectQuote, Me.rTxtLoadID, Me.rTxtLoadGrossWeight, Me.rTxtDestZip})
        Me.RibbonControl1.LargeImages = Me.Ribbon_LargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 16
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1017, 94)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 1
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 2
        Me.btnCancel.Name = "btnCancel"
        '
        'rbtnAddQuote
        '
        Me.rbtnAddQuote.Caption = "Add New Quote"
        Me.rbtnAddQuote.Id = 6
        Me.rbtnAddQuote.LargeImageIndex = 3
        Me.rbtnAddQuote.Name = "rbtnAddQuote"
        '
        'rbtnEditQuote
        '
        Me.rbtnEditQuote.Caption = "Edit  Quote"
        Me.rbtnEditQuote.Id = 7
        Me.rbtnEditQuote.LargeImageIndex = 4
        Me.rbtnEditQuote.Name = "rbtnEditQuote"
        '
        'rbtnDeleteQuote
        '
        Me.rbtnDeleteQuote.Caption = "Delete Quote"
        Me.rbtnDeleteQuote.Id = 8
        Me.rbtnDeleteQuote.LargeImageIndex = 5
        Me.rbtnDeleteQuote.Name = "rbtnDeleteQuote"
        '
        'rbtnSelectQuote
        '
        Me.rbtnSelectQuote.Caption = "Select Active Quote"
        Me.rbtnSelectQuote.Id = 9
        Me.rbtnSelectQuote.LargeImageIndex = 6
        Me.rbtnSelectQuote.Name = "rbtnSelectQuote"
        '
        'rTxtLoadID
        '
        Me.rTxtLoadID.Caption = "99999"
        Me.rTxtLoadID.Id = 13
        Me.rTxtLoadID.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTxtLoadID.ItemAppearance.Hovered.Options.UseFont = True
        Me.rTxtLoadID.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTxtLoadID.ItemAppearance.Normal.Options.UseFont = True
        Me.rTxtLoadID.Name = "rTxtLoadID"
        Me.rTxtLoadID.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rTxtLoadGrossWeight
        '
        Me.rTxtLoadGrossWeight.Caption = "44,999 LBS"
        Me.rTxtLoadGrossWeight.Id = 14
        Me.rTxtLoadGrossWeight.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTxtLoadGrossWeight.ItemAppearance.Hovered.Options.UseFont = True
        Me.rTxtLoadGrossWeight.ItemAppearance.Hovered.Options.UseTextOptions = True
        Me.rTxtLoadGrossWeight.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.rTxtLoadGrossWeight.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTxtLoadGrossWeight.ItemAppearance.Normal.Options.UseFont = True
        Me.rTxtLoadGrossWeight.ItemAppearance.Normal.Options.UseTextOptions = True
        Me.rTxtLoadGrossWeight.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.rTxtLoadGrossWeight.Name = "rTxtLoadGrossWeight"
        Me.rTxtLoadGrossWeight.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'rTxtDestZip
        '
        Me.rTxtDestZip.Caption = "Zip: 60188"
        Me.rTxtDestZip.Id = 15
        Me.rTxtDestZip.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTxtDestZip.ItemAppearance.Hovered.Options.UseFont = True
        Me.rTxtDestZip.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rTxtDestZip.ItemAppearance.Normal.Options.UseFont = True
        Me.rTxtDestZip.Name = "rTxtDestZip"
        Me.rTxtDestZip.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Ribbon_LargeImages
        '
        Me.Ribbon_LargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.Ribbon_LargeImages.ImageStream = CType(resources.GetObject("Ribbon_LargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.RibbonPageGroup4})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rTxtLoadID)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rTxtLoadGrossWeight)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rTxtDestZip)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Load Info"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnAddQuote)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnEditQuote, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnDeleteQuote, True)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Freight Quotes"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnSelectQuote)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Freight Charges"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.PanelControl3)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.PanelControl4)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(6, 6)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.PanelControl1.Size = New System.Drawing.Size(1005, 151)
        Me.PanelControl1.TabIndex = 1
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(805, 0)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(200, 145)
        Me.PanelControl3.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl3)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(200, 145)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Est Gross Wgt By Container"
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.bsWeightByContainer
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 21)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.MenuManager = Me.RibbonControl1
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(196, 122)
        Me.GridControl3.TabIndex = 1
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'bsWeightByContainer
        '
        Me.bsWeightByContainer.DataSource = GetType(AOS.BusinessObjects.ViewLoadWeightByContainerCollection)
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colContainer, Me.colGrossWgt1, Me.colNumContainers, Me.colLoadID4})
        Me.GridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView3.GridControl = Me.GridControl3
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 0
        Me.colContainer.Width = 78
        '
        'colGrossWgt1
        '
        Me.colGrossWgt1.DisplayFormat.FormatString = "0"
        Me.colGrossWgt1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrossWgt1.FieldName = "GrossWgt"
        Me.colGrossWgt1.Name = "colGrossWgt1"
        Me.colGrossWgt1.Visible = True
        Me.colGrossWgt1.VisibleIndex = 2
        Me.colGrossWgt1.Width = 68
        '
        'colNumContainers
        '
        Me.colNumContainers.Caption = "# Ctrs"
        Me.colNumContainers.DisplayFormat.FormatString = "0"
        Me.colNumContainers.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colNumContainers.FieldName = "NumContainers"
        Me.colNumContainers.Name = "colNumContainers"
        Me.colNumContainers.Visible = True
        Me.colNumContainers.VisibleIndex = 1
        Me.colNumContainers.Width = 47
        '
        'colLoadID4
        '
        Me.colLoadID4.FieldName = "LoadID"
        Me.colLoadID4.Name = "colLoadID4"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.GroupControl1)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl2.Location = New System.Drawing.Point(663, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.PanelControl2.Size = New System.Drawing.Size(142, 145)
        Me.PanelControl2.TabIndex = 0
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl2)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(136, 145)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Est Gross Wgt by Class"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsWeightByClass
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 21)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.RibbonControl1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(132, 122)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colClassRate, Me.colGrossWgt, Me.colLoadID3})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colClassRate
        '
        Me.colClassRate.FieldName = "ClassRate"
        Me.colClassRate.Name = "colClassRate"
        Me.colClassRate.Visible = True
        Me.colClassRate.VisibleIndex = 0
        Me.colClassRate.Width = 67
        '
        'colGrossWgt
        '
        Me.colGrossWgt.DisplayFormat.FormatString = "0"
        Me.colGrossWgt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colGrossWgt.FieldName = "GrossWgt"
        Me.colGrossWgt.Name = "colGrossWgt"
        Me.colGrossWgt.Visible = True
        Me.colGrossWgt.VisibleIndex = 1
        Me.colGrossWgt.Width = 65
        '
        'colLoadID3
        '
        Me.colLoadID3.FieldName = "LoadID"
        Me.colLoadID3.Name = "colLoadID3"
        '
        'PanelControl4
        '
        Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl4.Controls.Add(Me.GroupControl3)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.PanelControl4.Size = New System.Drawing.Size(663, 145)
        Me.PanelControl4.TabIndex = 2
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(657, 145)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Freight Quotes"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsLoadQuotes
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 21)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(653, 122)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsLoadQuotes
        '
        Me.bsLoadQuotes.DataSource = GetType(AOS.BusinessObjects.ViewLoadQuotesByLoadIDCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLoadQuoteID, Me.colLoadID2, Me.colCarrierID1, Me.colCarrierName1, Me.colLogisticsProviderID1, Me.colLogisticsname1, Me.colQuoteAmount, Me.colQuoteDate, Me.colCarrierQuoteNumber})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colLoadQuoteID
        '
        Me.colLoadQuoteID.Caption = "Q#"
        Me.colLoadQuoteID.FieldName = "LoadQuoteID"
        Me.colLoadQuoteID.Name = "colLoadQuoteID"
        Me.colLoadQuoteID.Visible = True
        Me.colLoadQuoteID.VisibleIndex = 0
        Me.colLoadQuoteID.Width = 41
        '
        'colLoadID2
        '
        Me.colLoadID2.FieldName = "LoadID"
        Me.colLoadID2.Name = "colLoadID2"
        '
        'colCarrierID1
        '
        Me.colCarrierID1.FieldName = "CarrierID"
        Me.colCarrierID1.Name = "colCarrierID1"
        '
        'colCarrierName1
        '
        Me.colCarrierName1.Caption = "Carrier Name"
        Me.colCarrierName1.FieldName = "CarrierName"
        Me.colCarrierName1.Name = "colCarrierName1"
        Me.colCarrierName1.Visible = True
        Me.colCarrierName1.VisibleIndex = 1
        Me.colCarrierName1.Width = 186
        '
        'colLogisticsProviderID1
        '
        Me.colLogisticsProviderID1.FieldName = "LogisticsProviderID"
        Me.colLogisticsProviderID1.Name = "colLogisticsProviderID1"
        '
        'colLogisticsname1
        '
        Me.colLogisticsname1.Caption = "Logistics Provider"
        Me.colLogisticsname1.FieldName = "Logisticsname"
        Me.colLogisticsname1.Name = "colLogisticsname1"
        Me.colLogisticsname1.Visible = True
        Me.colLogisticsname1.VisibleIndex = 2
        Me.colLogisticsname1.Width = 186
        '
        'colQuoteAmount
        '
        Me.colQuoteAmount.Caption = "Amount"
        Me.colQuoteAmount.DisplayFormat.FormatString = "c2"
        Me.colQuoteAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuoteAmount.FieldName = "QuoteAmount"
        Me.colQuoteAmount.Name = "colQuoteAmount"
        Me.colQuoteAmount.Visible = True
        Me.colQuoteAmount.VisibleIndex = 3
        Me.colQuoteAmount.Width = 76
        '
        'colQuoteDate
        '
        Me.colQuoteDate.Caption = "Date"
        Me.colQuoteDate.DisplayFormat.FormatString = "d"
        Me.colQuoteDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colQuoteDate.FieldName = "QuoteDate"
        Me.colQuoteDate.Name = "colQuoteDate"
        Me.colQuoteDate.Visible = True
        Me.colQuoteDate.VisibleIndex = 4
        Me.colQuoteDate.Width = 73
        '
        'colCarrierQuoteNumber
        '
        Me.colCarrierQuoteNumber.Caption = "Carrier Q#"
        Me.colCarrierQuoteNumber.FieldName = "CarrierQuoteNumber"
        Me.colCarrierQuoteNumber.Name = "colCarrierQuoteNumber"
        Me.colCarrierQuoteNumber.Visible = True
        Me.colCarrierQuoteNumber.VisibleIndex = 5
        Me.colCarrierQuoteNumber.Width = 91
        '
        'PanelControl5
        '
        Me.PanelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl5.Controls.Add(Me.PanelControl6)
        Me.PanelControl5.Controls.Add(Me.PanelControl1)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(0, 94)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl5.Size = New System.Drawing.Size(1017, 571)
        Me.PanelControl5.TabIndex = 2
        '
        'PanelControl6
        '
        Me.PanelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl6.Controls.Add(Me.PanelControl7)
        Me.PanelControl6.Controls.Add(Me.RibbonControl2)
        Me.PanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl6.Location = New System.Drawing.Point(6, 157)
        Me.PanelControl6.Name = "PanelControl6"
        Me.PanelControl6.Size = New System.Drawing.Size(1005, 408)
        Me.PanelControl6.TabIndex = 2
        '
        'PanelControl7
        '
        Me.PanelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl7.Controls.Add(Me.PanelControl9)
        Me.PanelControl7.Controls.Add(Me.PanelControl8)
        Me.PanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl7.Location = New System.Drawing.Point(0, 94)
        Me.PanelControl7.Name = "PanelControl7"
        Me.PanelControl7.Padding = New System.Windows.Forms.Padding(0, 6, 0, 0)
        Me.PanelControl7.Size = New System.Drawing.Size(1005, 314)
        Me.PanelControl7.TabIndex = 2
        '
        'PanelControl9
        '
        Me.PanelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl9.Controls.Add(Me.GroupControl5)
        Me.PanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl9.Location = New System.Drawing.Point(0, 147)
        Me.PanelControl9.Name = "PanelControl9"
        Me.PanelControl9.Size = New System.Drawing.Size(1005, 167)
        Me.PanelControl9.TabIndex = 1
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.GridControl5)
        Me.GroupControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl5.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(1005, 167)
        Me.GroupControl5.TabIndex = 2
        Me.GroupControl5.Text = "Load Freight Billing Records"
        '
        'GridControl5
        '
        Me.GridControl5.DataSource = Me.bsLoadBillings
        Me.GridControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl5.Location = New System.Drawing.Point(2, 21)
        Me.GridControl5.MainView = Me.GridView5
        Me.GridControl5.MenuManager = Me.RibbonControl1
        Me.GridControl5.Name = "GridControl5"
        Me.GridControl5.Size = New System.Drawing.Size(1001, 144)
        Me.GridControl5.TabIndex = 1
        Me.GridControl5.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView5})
        '
        'bsLoadBillings
        '
        Me.bsLoadBillings.DataSource = GetType(AOS.BusinessObjects.ViewLoadBillingByLoadIDCollection)
        '
        'GridView5
        '
        Me.GridView5.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLoadbillingid, Me.colLoadid, Me.colCustomerID, Me.colCustname, Me.colCustomerPO, Me.colBilledAmount, Me.colBillingDate, Me.colCreatedBy, Me.colInvoiceNumber})
        Me.GridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView5.GridControl = Me.GridControl5
        Me.GridView5.Name = "GridView5"
        Me.GridView5.OptionsBehavior.Editable = False
        Me.GridView5.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView5.OptionsView.ShowGroupPanel = False
        Me.GridView5.OptionsView.ShowIndicator = False
        '
        'colLoadbillingid
        '
        Me.colLoadbillingid.FieldName = "Loadbillingid"
        Me.colLoadbillingid.Name = "colLoadbillingid"
        '
        'colLoadid
        '
        Me.colLoadid.FieldName = "Loadid"
        Me.colLoadid.Name = "colLoadid"
        '
        'colCustomerID
        '
        Me.colCustomerID.Caption = "Cust ID"
        Me.colCustomerID.FieldName = "CustomerID"
        Me.colCustomerID.Name = "colCustomerID"
        Me.colCustomerID.Visible = True
        Me.colCustomerID.VisibleIndex = 0
        Me.colCustomerID.Width = 71
        '
        'colCustname
        '
        Me.colCustname.Caption = "Customer Name"
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 1
        Me.colCustname.Width = 342
        '
        'colCustomerPO
        '
        Me.colCustomerPO.FieldName = "CustomerPO"
        Me.colCustomerPO.Name = "colCustomerPO"
        Me.colCustomerPO.Visible = True
        Me.colCustomerPO.VisibleIndex = 2
        Me.colCustomerPO.Width = 183
        '
        'colBilledAmount
        '
        Me.colBilledAmount.DisplayFormat.FormatString = "c2"
        Me.colBilledAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colBilledAmount.FieldName = "BilledAmount"
        Me.colBilledAmount.Name = "colBilledAmount"
        Me.colBilledAmount.Visible = True
        Me.colBilledAmount.VisibleIndex = 4
        Me.colBilledAmount.Width = 152
        '
        'colBillingDate
        '
        Me.colBillingDate.DisplayFormat.FormatString = "d"
        Me.colBillingDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colBillingDate.FieldName = "BillingDate"
        Me.colBillingDate.Name = "colBillingDate"
        Me.colBillingDate.Visible = True
        Me.colBillingDate.VisibleIndex = 3
        '
        'colCreatedBy
        '
        Me.colCreatedBy.FieldName = "CreatedBy"
        Me.colCreatedBy.Name = "colCreatedBy"
        '
        'colInvoiceNumber
        '
        Me.colInvoiceNumber.FieldName = "InvoiceNumber"
        Me.colInvoiceNumber.Name = "colInvoiceNumber"
        Me.colInvoiceNumber.Visible = True
        Me.colInvoiceNumber.VisibleIndex = 5
        Me.colInvoiceNumber.Width = 164
        '
        'PanelControl8
        '
        Me.PanelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl8.Controls.Add(Me.GroupControl4)
        Me.PanelControl8.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl8.Location = New System.Drawing.Point(0, 6)
        Me.PanelControl8.Name = "PanelControl8"
        Me.PanelControl8.Padding = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.PanelControl8.Size = New System.Drawing.Size(1005, 141)
        Me.PanelControl8.TabIndex = 0
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.GridControl4)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(1005, 135)
        Me.GroupControl4.TabIndex = 2
        Me.GroupControl4.Text = "Load Freight Charge Records"
        '
        'GridControl4
        '
        Me.GridControl4.DataSource = Me.bsLoadCharges
        Me.GridControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl4.Location = New System.Drawing.Point(2, 21)
        Me.GridControl4.MainView = Me.GridView4
        Me.GridControl4.MenuManager = Me.RibbonControl1
        Me.GridControl4.Name = "GridControl4"
        Me.GridControl4.Size = New System.Drawing.Size(1001, 112)
        Me.GridControl4.TabIndex = 1
        Me.GridControl4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'bsLoadCharges
        '
        Me.bsLoadCharges.DataSource = GetType(AOS.BusinessObjects.ViewLoadChargesByLoadIDCollection)
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLoadChargeID, Me.colLoadID1, Me.colCarrierID, Me.colCarrierName, Me.colLogisticsProviderID, Me.colLogisticsname, Me.colCarrierCharges, Me.colChargeType, Me.colChargeDate, Me.colCreatedBy1, Me.colLoadChargeStatus})
        Me.GridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView4.GridControl = Me.GridControl4
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsBehavior.Editable = False
        Me.GridView4.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.OptionsView.ShowIndicator = False
        '
        'colLoadChargeID
        '
        Me.colLoadChargeID.FieldName = "LoadChargeID"
        Me.colLoadChargeID.Name = "colLoadChargeID"
        '
        'colLoadID1
        '
        Me.colLoadID1.FieldName = "LoadID"
        Me.colLoadID1.Name = "colLoadID1"
        '
        'colCarrierID
        '
        Me.colCarrierID.FieldName = "CarrierID"
        Me.colCarrierID.Name = "colCarrierID"
        '
        'colCarrierName
        '
        Me.colCarrierName.FieldName = "CarrierName"
        Me.colCarrierName.Name = "colCarrierName"
        Me.colCarrierName.Visible = True
        Me.colCarrierName.VisibleIndex = 0
        '
        'colLogisticsProviderID
        '
        Me.colLogisticsProviderID.FieldName = "LogisticsProviderID"
        Me.colLogisticsProviderID.Name = "colLogisticsProviderID"
        '
        'colLogisticsname
        '
        Me.colLogisticsname.Caption = "Logistics Provider"
        Me.colLogisticsname.FieldName = "Logisticsname"
        Me.colLogisticsname.Name = "colLogisticsname"
        Me.colLogisticsname.Visible = True
        Me.colLogisticsname.VisibleIndex = 1
        '
        'colCarrierCharges
        '
        Me.colCarrierCharges.DisplayFormat.FormatString = "c2"
        Me.colCarrierCharges.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCarrierCharges.FieldName = "CarrierCharges"
        Me.colCarrierCharges.Name = "colCarrierCharges"
        Me.colCarrierCharges.Visible = True
        Me.colCarrierCharges.VisibleIndex = 2
        '
        'colChargeType
        '
        Me.colChargeType.FieldName = "ChargeType"
        Me.colChargeType.Name = "colChargeType"
        Me.colChargeType.Visible = True
        Me.colChargeType.VisibleIndex = 3
        '
        'colChargeDate
        '
        Me.colChargeDate.DisplayFormat.FormatString = "d"
        Me.colChargeDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colChargeDate.FieldName = "ChargeDate"
        Me.colChargeDate.Name = "colChargeDate"
        Me.colChargeDate.Visible = True
        Me.colChargeDate.VisibleIndex = 4
        '
        'colCreatedBy1
        '
        Me.colCreatedBy1.FieldName = "CreatedBy"
        Me.colCreatedBy1.Name = "colCreatedBy1"
        '
        'colLoadChargeStatus
        '
        Me.colLoadChargeStatus.FieldName = "LoadChargeStatus"
        Me.colLoadChargeStatus.Name = "colLoadChargeStatus"
        Me.colLoadChargeStatus.Visible = True
        Me.colLoadChargeStatus.VisibleIndex = 5
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.rbtnAddFreightCharge, Me.rbtnEditFreightCharge, Me.rbtnDeleteCharge, Me.rbtnAddBillingRecord, Me.rbtnEditBillingRecord, Me.rbtnDeleteBillingRecord})
        Me.RibbonControl2.LargeImages = Me.ImageCollection1
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 19
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2})
        Me.RibbonControl2.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl2.ShowToolbarCustomizeItem = False
        Me.RibbonControl2.Size = New System.Drawing.Size(1005, 94)
        Me.RibbonControl2.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnAddFreightCharge
        '
        Me.rbtnAddFreightCharge.Caption = "Add New Charge"
        Me.rbtnAddFreightCharge.Id = 6
        Me.rbtnAddFreightCharge.LargeImageIndex = 0
        Me.rbtnAddFreightCharge.Name = "rbtnAddFreightCharge"
        '
        'rbtnEditFreightCharge
        '
        Me.rbtnEditFreightCharge.Caption = "Edit  Charge"
        Me.rbtnEditFreightCharge.Id = 7
        Me.rbtnEditFreightCharge.LargeImageIndex = 1
        Me.rbtnEditFreightCharge.Name = "rbtnEditFreightCharge"
        '
        'rbtnDeleteCharge
        '
        Me.rbtnDeleteCharge.Caption = "Delete Charge"
        Me.rbtnDeleteCharge.Id = 8
        Me.rbtnDeleteCharge.LargeImageIndex = 2
        Me.rbtnDeleteCharge.Name = "rbtnDeleteCharge"
        '
        'rbtnAddBillingRecord
        '
        Me.rbtnAddBillingRecord.Caption = "Add Billing Record"
        Me.rbtnAddBillingRecord.Id = 16
        Me.rbtnAddBillingRecord.LargeImageIndex = 3
        Me.rbtnAddBillingRecord.Name = "rbtnAddBillingRecord"
        '
        'rbtnEditBillingRecord
        '
        Me.rbtnEditBillingRecord.Caption = "Edit Billing Record"
        Me.rbtnEditBillingRecord.Id = 17
        Me.rbtnEditBillingRecord.LargeImageIndex = 4
        Me.rbtnEditBillingRecord.Name = "rbtnEditBillingRecord"
        '
        'rbtnDeleteBillingRecord
        '
        Me.rbtnDeleteBillingRecord.Caption = "Delete Billing Record"
        Me.rbtnDeleteBillingRecord.Id = 18
        Me.rbtnDeleteBillingRecord.LargeImageIndex = 5
        Me.rbtnDeleteBillingRecord.Name = "rbtnDeleteBillingRecord"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5, Me.RibbonPageGroup6})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage1"
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.AllowMinimize = False
        Me.RibbonPageGroup5.AllowTextClipping = False
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnAddFreightCharge)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnEditFreightCharge, True)
        Me.RibbonPageGroup5.ItemLinks.Add(Me.rbtnDeleteCharge, True)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.ShowCaptionButton = False
        Me.RibbonPageGroup5.Text = "Freight Charges"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.AllowMinimize = False
        Me.RibbonPageGroup6.AllowTextClipping = False
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnAddBillingRecord)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnEditBillingRecord, True)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.rbtnDeleteBillingRecord, True)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.ShowCaptionButton = False
        Me.RibbonPageGroup6.Text = "Freight Billing Records"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnAddFreightCharge)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnEditFreightCharge, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnDeleteCharge, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Freight Quotes"
        '
        'bsLoadDetails
        '
        Me.bsLoadDetails.DataSource = GetType(AOS.BusinessObjects.ViewLoadDetailsCollection)
        '
        'frmFreightCharges
        '
        Me.ClientSize = New System.Drawing.Size(1017, 665)
        Me.Controls.Add(Me.PanelControl5)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFreightCharges"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Load Freight Charges / Quotes"
        CType(Me.bsWeightByClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWeightByContainer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadQuotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.PanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl6.ResumeLayout(False)
        CType(Me.PanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl7.ResumeLayout(False)
        CType(Me.PanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl9.ResumeLayout(False)
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        CType(Me.GridControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadBillings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl8.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        CType(Me.GridControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadCharges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsWeightByClass As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents rbtnAddQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnSelectQuote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rTxtLoadID As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rTxtLoadGrossWeight As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rTxtDestZip As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Ribbon_LargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rbtnAddFreightCharge As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditFreightCharge As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteCharge As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As CustomDevExGridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents GridControl5 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView5 As CustomDevExGridView
    Friend WithEvents GridControl4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents rbtnAddBillingRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnEditBillingRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnDeleteBillingRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsWeightByContainer As System.Windows.Forms.BindingSource
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrossWgt1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumContainers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadID4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassRate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGrossWgt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadID3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsLoadQuotes As System.Windows.Forms.BindingSource
    Friend WithEvents colLoadQuoteID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadID2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierName1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsProviderID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsname1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuoteDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierQuoteNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsLoadBillings As System.Windows.Forms.BindingSource
    Friend WithEvents colLoadbillingid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBilledAmount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsLoadCharges As System.Windows.Forms.BindingSource
    Friend WithEvents colLoadChargeID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadID1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsProviderID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogisticsname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCarrierCharges As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChargeType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChargeDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedBy1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLoadChargeStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsLoadDetails As System.Windows.Forms.BindingSource
End Class
