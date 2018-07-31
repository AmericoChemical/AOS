<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewLab

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewLab))
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.grHeader = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnAddTestingItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelTestingItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrieveTestingItems = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnInputNewTestResults = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnRetrieveArchivedTestScores = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReviewTestResults = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnEditArchivedTestResults = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.grTestingItems = New DevExpress.XtraGrid.GridControl()
        Me.bsItemsToBeTested = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvTestingItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.colLotnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvitemnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiverdocumenttype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit6 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grProducts = New DevExpress.XtraGrid.GridControl()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStdgallons = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHealth = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFire = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReactivity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPersonalprotection = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDotdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnline = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlacardrequired = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChemicalcolor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassrate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChemicalclarity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyonhand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyallocated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyonorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyforsale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQtyminonhand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReorderqty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPreferredvendorid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDatecostlastchanged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDesc2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryclass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsactive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsliquid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRawmaterialgroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventorygrouping = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVolumeuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVolumeunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventorymethod = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifyby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifytime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhrangelow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhrangehigh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSgrangelow = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSgrangehigh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeedstesting = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShelflife = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grTestSamples = New DevExpress.XtraGrid.GridControl()
        Me.bsArchivedTestResults = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTestsamplekey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpr1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpr2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTesttime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTestedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTemperature = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhresult = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhrangelow1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhrangehigh1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPhaccepted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSgresult = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSgrangelow1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSgrangehigh1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSgaccepted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAppearance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFreeflowing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPassedtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPassedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPassedtest = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClarity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOdor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RibbonPanelControl9 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl8 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl7 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl6 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
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
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.grTestingItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItemsToBeTested, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvTestingItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grTestSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArchivedTestResults, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.FormCaption.Size = New System.Drawing.Size(1424, 33)
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
        Me.grHeader.GroupPanelText = "CHEMISTRY LAB"
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
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnAddTestingItem, Me.btnCancelTestingItem, Me.rbtnRetrieveTestingItems, Me.rbtnInputNewTestResults, Me.rbtnRetrieveArchivedTestScores, Me.rbtnReviewTestResults, Me.rbtnEditArchivedTestResults})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 59
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1424, 117)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnAddTestingItem
        '
        Me.btnAddTestingItem.Caption = "Add New Testing Item"
        Me.btnAddTestingItem.Id = 41
        Me.btnAddTestingItem.LargeImageIndex = 2
        Me.btnAddTestingItem.Name = "btnAddTestingItem"
        Me.btnAddTestingItem.Tag = "280"
        Me.btnAddTestingItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnCancelTestingItem
        '
        Me.btnCancelTestingItem.Caption = "Cancel Testing for Item"
        Me.btnCancelTestingItem.Id = 43
        Me.btnCancelTestingItem.LargeImageIndex = 6
        Me.btnCancelTestingItem.Name = "btnCancelTestingItem"
        Me.btnCancelTestingItem.Tag = "281"
        '
        'rbtnRetrieveTestingItems
        '
        Me.rbtnRetrieveTestingItems.Caption = "Retrieve Testing Items"
        Me.rbtnRetrieveTestingItems.Id = 51
        Me.rbtnRetrieveTestingItems.LargeImageIndex = 1
        Me.rbtnRetrieveTestingItems.Name = "rbtnRetrieveTestingItems"
        Me.rbtnRetrieveTestingItems.Tag = "279"
        '
        'rbtnInputNewTestResults
        '
        Me.rbtnInputNewTestResults.Caption = "Create New Sample for Testing"
        Me.rbtnInputNewTestResults.Hint = "Enter test results for all selected items as a single sample"
        Me.rbtnInputNewTestResults.Id = 52
        Me.rbtnInputNewTestResults.LargeImageIndex = 9
        Me.rbtnInputNewTestResults.Name = "rbtnInputNewTestResults"
        Me.rbtnInputNewTestResults.Tag = "282"
        '
        'rbtnRetrieveArchivedTestScores
        '
        Me.rbtnRetrieveArchivedTestScores.Caption = "Retrieve Test Results"
        Me.rbtnRetrieveArchivedTestScores.Id = 53
        Me.rbtnRetrieveArchivedTestScores.LargeImageIndex = 11
        Me.rbtnRetrieveArchivedTestScores.Name = "rbtnRetrieveArchivedTestScores"
        Me.rbtnRetrieveArchivedTestScores.Tag = "283"
        '
        'rbtnReviewTestResults
        '
        Me.rbtnReviewTestResults.Caption = "Review Test Results"
        Me.rbtnReviewTestResults.Id = 54
        Me.rbtnReviewTestResults.LargeImageIndex = 18
        Me.rbtnReviewTestResults.LargeWidth = 75
        Me.rbtnReviewTestResults.Name = "rbtnReviewTestResults"
        Me.rbtnReviewTestResults.Tag = "284"
        '
        'rbtnEditArchivedTestResults
        '
        Me.rbtnEditArchivedTestResults.Caption = "Edit Test Results"
        Me.rbtnEditArchivedTestResults.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnEditArchivedTestResults.Id = 58
        Me.rbtnEditArchivedTestResults.LargeImageIndex = 13
        Me.rbtnEditArchivedTestResults.LargeWidth = 75
        Me.rbtnEditArchivedTestResults.Name = "rbtnEditArchivedTestResults"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "43"
        Me.RibbonPage1.Text = "Testing"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnRetrieveTestingItems)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnAddTestingItem, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnCancelTestingItem, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Data Management"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnInputNewTestResults)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Lab Work"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Tag = "44"
        Me.RibbonPage2.Text = "Archived Test Results"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnRetrieveArchivedTestScores)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnEditArchivedTestResults, True)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnReviewTestResults, True)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Data Management"
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
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl3)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl9)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl8)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl7)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl5)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl6)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 150)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1424, 584)
        Me.WorkPanelsHolder.TabIndex = 7
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Controls.Add(Me.GroupControl7)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1424, 584)
        Me.RibbonPanelControl1.TabIndex = 2
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.grTestingItems)
        Me.GroupControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl7.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(1420, 580)
        Me.GroupControl7.TabIndex = 2
        Me.GroupControl7.Text = "Inventory Items Waiting for Testing"
        '
        'grTestingItems
        '
        Me.grTestingItems.DataSource = Me.bsItemsToBeTested
        Me.grTestingItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grTestingItems.Location = New System.Drawing.Point(2, 22)
        Me.grTestingItems.MainView = Me.grvTestingItems
        Me.grTestingItems.Name = "grTestingItems"
        Me.grTestingItems.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit6})
        Me.grTestingItems.Size = New System.Drawing.Size(1416, 556)
        Me.grTestingItems.TabIndex = 0
        Me.grTestingItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvTestingItems})
        '
        'bsItemsToBeTested
        '
        Me.bsItemsToBeTested.DataSource = GetType(AOS.BusinessObjects.ViewTestingItemsCollection)
        '
        'grvTestingItems
        '
        Me.grvTestingItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLotnumber1, Me.colInvitemnumber1, Me.colProductid2, Me.colProductdesc2, Me.colContainer2, Me.colReceiveddate, Me.colReceiverdocument, Me.colReceiverdocumenttype})
        Me.grvTestingItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.grvTestingItems.GridControl = Me.grTestingItems
        Me.grvTestingItems.Name = "grvTestingItems"
        Me.grvTestingItems.OptionsBehavior.Editable = False
        Me.grvTestingItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvTestingItems.OptionsSelection.MultiSelect = True
        Me.grvTestingItems.OptionsView.ShowAutoFilterRow = True
        Me.grvTestingItems.OptionsView.ShowGroupPanel = False
        '
        'colLotnumber1
        '
        Me.colLotnumber1.Caption = "Lot #"
        Me.colLotnumber1.FieldName = "Lotnumber"
        Me.colLotnumber1.Name = "colLotnumber1"
        Me.colLotnumber1.Visible = True
        Me.colLotnumber1.VisibleIndex = 2
        Me.colLotnumber1.Width = 157
        '
        'colInvitemnumber1
        '
        Me.colInvitemnumber1.Caption = "Item #"
        Me.colInvitemnumber1.FieldName = "Invitemnumber"
        Me.colInvitemnumber1.Name = "colInvitemnumber1"
        Me.colInvitemnumber1.Visible = True
        Me.colInvitemnumber1.VisibleIndex = 3
        Me.colInvitemnumber1.Width = 112
        '
        'colProductid2
        '
        Me.colProductid2.Caption = "Product ID"
        Me.colProductid2.FieldName = "Productid"
        Me.colProductid2.Name = "colProductid2"
        Me.colProductid2.Visible = True
        Me.colProductid2.VisibleIndex = 4
        Me.colProductid2.Width = 81
        '
        'colProductdesc2
        '
        Me.colProductdesc2.FieldName = "Productdesc"
        Me.colProductdesc2.Name = "colProductdesc2"
        Me.colProductdesc2.Visible = True
        Me.colProductdesc2.VisibleIndex = 5
        Me.colProductdesc2.Width = 421
        '
        'colContainer2
        '
        Me.colContainer2.FieldName = "Container"
        Me.colContainer2.Name = "colContainer2"
        Me.colContainer2.Visible = True
        Me.colContainer2.VisibleIndex = 6
        Me.colContainer2.Width = 247
        '
        'colReceiveddate
        '
        Me.colReceiveddate.Caption = "Received"
        Me.colReceiveddate.FieldName = "Receiveddate"
        Me.colReceiveddate.Name = "colReceiveddate"
        Me.colReceiveddate.Visible = True
        Me.colReceiveddate.VisibleIndex = 1
        Me.colReceiveddate.Width = 81
        '
        'colReceiverdocument
        '
        Me.colReceiverdocument.Caption = "Prod Order#"
        Me.colReceiverdocument.FieldName = "Receiverdocument"
        Me.colReceiverdocument.Name = "colReceiverdocument"
        Me.colReceiverdocument.Visible = True
        Me.colReceiverdocument.VisibleIndex = 0
        Me.colReceiverdocument.Width = 82
        '
        'colReceiverdocumenttype
        '
        Me.colReceiverdocumenttype.FieldName = "Receiverdocumenttype"
        Me.colReceiverdocumenttype.Name = "colReceiverdocumenttype"
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
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.GroupControl2)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1424, 584)
        Me.RibbonPanelControl3.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grProducts)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1420, 580)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Product Chemistry Standards"
        '
        'grProducts
        '
        Me.grProducts.DataSource = Me.bsProducts
        Me.grProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grProducts.Location = New System.Drawing.Point(2, 22)
        Me.grProducts.MainView = Me.GridView2
        Me.grProducts.Name = "grProducts"
        Me.grProducts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit2})
        Me.grProducts.Size = New System.Drawing.Size(1416, 556)
        Me.grProducts.TabIndex = 0
        Me.grProducts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProductdesc, Me.colStdweight, Me.colStdgallons, Me.colContainer, Me.colHealth, Me.colFire, Me.colReactivity, Me.colPersonalprotection, Me.colDotdesc, Me.colHazmatdesc, Me.colUnline, Me.colPlacardrequired, Me.colChemicalcolor, Me.colClassrate, Me.colChemicalclarity, Me.colHazmatid, Me.colQtyonhand, Me.colQtyallocated, Me.colQtyonorder, Me.colQtyforsale, Me.colQtyminonhand, Me.colReorderqty, Me.colPreferredvendorid, Me.colUnitcost, Me.colDatecostlastchanged, Me.colUnits, Me.colUom, Me.colDesc2, Me.colInventoryclass, Me.colIsactive, Me.colCustid1, Me.colIsliquid, Me.colRawmaterialgroup, Me.colInventorygrouping, Me.colWeightuom, Me.colWeightunits, Me.colVolumeuom, Me.colVolumeunits, Me.colInventorymethod, Me.colUnnumber, Me.colCreatedby, Me.colCreatedtime, Me.colModifyby, Me.colModifytime, Me.colPhrangelow, Me.colPhrangehigh, Me.colSgrangelow, Me.colSgrangehigh, Me.colNeedstesting, Me.colShelflife})
        Me.GridView2.GridControl = Me.grProducts
        Me.GridView2.GroupPanelText = "OPEN WORK ORDERS"
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.ViewCaption = "OPEN Work Orders"
        '
        'colProductid
        '
        Me.colProductid.Caption = "Product ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 0
        Me.colProductid.Width = 85
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 1
        Me.colProductdesc.Width = 451
        '
        'colStdweight
        '
        Me.colStdweight.FieldName = "Stdweight"
        Me.colStdweight.Name = "colStdweight"
        '
        'colStdgallons
        '
        Me.colStdgallons.FieldName = "Stdgallons"
        Me.colStdgallons.Name = "colStdgallons"
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 2
        Me.colContainer.Width = 120
        '
        'colHealth
        '
        Me.colHealth.FieldName = "Health"
        Me.colHealth.Name = "colHealth"
        '
        'colFire
        '
        Me.colFire.FieldName = "Fire"
        Me.colFire.Name = "colFire"
        '
        'colReactivity
        '
        Me.colReactivity.FieldName = "Reactivity"
        Me.colReactivity.Name = "colReactivity"
        '
        'colPersonalprotection
        '
        Me.colPersonalprotection.FieldName = "Personalprotection"
        Me.colPersonalprotection.Name = "colPersonalprotection"
        '
        'colDotdesc
        '
        Me.colDotdesc.FieldName = "Dotdesc"
        Me.colDotdesc.Name = "colDotdesc"
        '
        'colHazmatdesc
        '
        Me.colHazmatdesc.FieldName = "Hazmatdesc"
        Me.colHazmatdesc.Name = "colHazmatdesc"
        '
        'colUnline
        '
        Me.colUnline.FieldName = "Unline"
        Me.colUnline.Name = "colUnline"
        '
        'colPlacardrequired
        '
        Me.colPlacardrequired.FieldName = "Placardrequired"
        Me.colPlacardrequired.Name = "colPlacardrequired"
        '
        'colChemicalcolor
        '
        Me.colChemicalcolor.Caption = "Color"
        Me.colChemicalcolor.FieldName = "Chemicalcolor"
        Me.colChemicalcolor.Name = "colChemicalcolor"
        Me.colChemicalcolor.Visible = True
        Me.colChemicalcolor.VisibleIndex = 3
        Me.colChemicalcolor.Width = 140
        '
        'colClassrate
        '
        Me.colClassrate.FieldName = "Classrate"
        Me.colClassrate.Name = "colClassrate"
        '
        'colChemicalclarity
        '
        Me.colChemicalclarity.Caption = "Clarity"
        Me.colChemicalclarity.FieldName = "Chemicalclarity"
        Me.colChemicalclarity.Name = "colChemicalclarity"
        Me.colChemicalclarity.Visible = True
        Me.colChemicalclarity.VisibleIndex = 4
        Me.colChemicalclarity.Width = 106
        '
        'colHazmatid
        '
        Me.colHazmatid.FieldName = "Hazmatid"
        Me.colHazmatid.Name = "colHazmatid"
        '
        'colQtyonhand
        '
        Me.colQtyonhand.FieldName = "Qtyonhand"
        Me.colQtyonhand.Name = "colQtyonhand"
        '
        'colQtyallocated
        '
        Me.colQtyallocated.FieldName = "Qtyallocated"
        Me.colQtyallocated.Name = "colQtyallocated"
        '
        'colQtyonorder
        '
        Me.colQtyonorder.FieldName = "Qtyonorder"
        Me.colQtyonorder.Name = "colQtyonorder"
        '
        'colQtyforsale
        '
        Me.colQtyforsale.FieldName = "Qtyforsale"
        Me.colQtyforsale.Name = "colQtyforsale"
        '
        'colQtyminonhand
        '
        Me.colQtyminonhand.FieldName = "Qtyminonhand"
        Me.colQtyminonhand.Name = "colQtyminonhand"
        '
        'colReorderqty
        '
        Me.colReorderqty.FieldName = "Reorderqty"
        Me.colReorderqty.Name = "colReorderqty"
        '
        'colPreferredvendorid
        '
        Me.colPreferredvendorid.FieldName = "Preferredvendorid"
        Me.colPreferredvendorid.Name = "colPreferredvendorid"
        '
        'colUnitcost
        '
        Me.colUnitcost.FieldName = "Unitcost"
        Me.colUnitcost.Name = "colUnitcost"
        '
        'colDatecostlastchanged
        '
        Me.colDatecostlastchanged.FieldName = "Datecostlastchanged"
        Me.colDatecostlastchanged.Name = "colDatecostlastchanged"
        '
        'colUnits
        '
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        '
        'colUom
        '
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        '
        'colDesc2
        '
        Me.colDesc2.FieldName = "Desc2"
        Me.colDesc2.Name = "colDesc2"
        '
        'colInventoryclass
        '
        Me.colInventoryclass.FieldName = "Inventoryclass"
        Me.colInventoryclass.Name = "colInventoryclass"
        '
        'colIsactive
        '
        Me.colIsactive.FieldName = "Isactive"
        Me.colIsactive.Name = "colIsactive"
        '
        'colCustid1
        '
        Me.colCustid1.FieldName = "Custid"
        Me.colCustid1.Name = "colCustid1"
        '
        'colIsliquid
        '
        Me.colIsliquid.FieldName = "Isliquid"
        Me.colIsliquid.Name = "colIsliquid"
        '
        'colRawmaterialgroup
        '
        Me.colRawmaterialgroup.FieldName = "Rawmaterialgroup"
        Me.colRawmaterialgroup.Name = "colRawmaterialgroup"
        '
        'colInventorygrouping
        '
        Me.colInventorygrouping.FieldName = "Inventorygrouping"
        Me.colInventorygrouping.Name = "colInventorygrouping"
        '
        'colWeightuom
        '
        Me.colWeightuom.FieldName = "Weightuom"
        Me.colWeightuom.Name = "colWeightuom"
        '
        'colWeightunits
        '
        Me.colWeightunits.FieldName = "Weightunits"
        Me.colWeightunits.Name = "colWeightunits"
        '
        'colVolumeuom
        '
        Me.colVolumeuom.FieldName = "Volumeuom"
        Me.colVolumeuom.Name = "colVolumeuom"
        '
        'colVolumeunits
        '
        Me.colVolumeunits.FieldName = "Volumeunits"
        Me.colVolumeunits.Name = "colVolumeunits"
        '
        'colInventorymethod
        '
        Me.colInventorymethod.FieldName = "Inventorymethod"
        Me.colInventorymethod.Name = "colInventorymethod"
        '
        'colUnnumber
        '
        Me.colUnnumber.FieldName = "Unnumber"
        Me.colUnnumber.Name = "colUnnumber"
        '
        'colCreatedby
        '
        Me.colCreatedby.FieldName = "Createdby"
        Me.colCreatedby.Name = "colCreatedby"
        '
        'colCreatedtime
        '
        Me.colCreatedtime.FieldName = "Createdtime"
        Me.colCreatedtime.Name = "colCreatedtime"
        '
        'colModifyby
        '
        Me.colModifyby.FieldName = "Modifyby"
        Me.colModifyby.Name = "colModifyby"
        '
        'colModifytime
        '
        Me.colModifytime.FieldName = "Modifytime"
        Me.colModifytime.Name = "colModifytime"
        '
        'colPhrangelow
        '
        Me.colPhrangelow.AppearanceHeader.Options.UseTextOptions = True
        Me.colPhrangelow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPhrangelow.Caption = "pH LOW"
        Me.colPhrangelow.FieldName = "Phrangelow"
        Me.colPhrangelow.Name = "colPhrangelow"
        Me.colPhrangelow.Visible = True
        Me.colPhrangelow.VisibleIndex = 5
        Me.colPhrangelow.Width = 94
        '
        'colPhrangehigh
        '
        Me.colPhrangehigh.AppearanceHeader.Options.UseTextOptions = True
        Me.colPhrangehigh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colPhrangehigh.Caption = "pH HIGH"
        Me.colPhrangehigh.FieldName = "Phrangehigh"
        Me.colPhrangehigh.Name = "colPhrangehigh"
        Me.colPhrangehigh.Visible = True
        Me.colPhrangehigh.VisibleIndex = 6
        Me.colPhrangehigh.Width = 94
        '
        'colSgrangelow
        '
        Me.colSgrangelow.AppearanceHeader.Options.UseTextOptions = True
        Me.colSgrangelow.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSgrangelow.Caption = "Spec Grav LOW"
        Me.colSgrangelow.FieldName = "Sgrangelow"
        Me.colSgrangelow.Name = "colSgrangelow"
        Me.colSgrangelow.Visible = True
        Me.colSgrangelow.VisibleIndex = 7
        Me.colSgrangelow.Width = 94
        '
        'colSgrangehigh
        '
        Me.colSgrangehigh.AppearanceHeader.Options.UseTextOptions = True
        Me.colSgrangehigh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colSgrangehigh.Caption = "Spec Grav HIGH"
        Me.colSgrangehigh.FieldName = "Sgrangehigh"
        Me.colSgrangehigh.Name = "colSgrangehigh"
        Me.colSgrangehigh.Visible = True
        Me.colSgrangehigh.VisibleIndex = 8
        Me.colSgrangehigh.Width = 94
        '
        'colNeedstesting
        '
        Me.colNeedstesting.AppearanceHeader.Options.UseTextOptions = True
        Me.colNeedstesting.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colNeedstesting.Caption = "Testing Req"
        Me.colNeedstesting.FieldName = "Needstesting"
        Me.colNeedstesting.Name = "colNeedstesting"
        Me.colNeedstesting.Visible = True
        Me.colNeedstesting.VisibleIndex = 9
        Me.colNeedstesting.Width = 121
        '
        'colShelflife
        '
        Me.colShelflife.FieldName = "Shelflife"
        Me.colShelflife.Name = "colShelflife"
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.NullText = ""
        Me.RepositoryItemLookUpEdit2.ShowPopupShadow = False
        Me.RepositoryItemLookUpEdit2.ValueMember = "Custid"
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Controls.Add(Me.GroupControl1)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1424, 584)
        Me.RibbonPanelControl2.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grTestSamples)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1420, 580)
        Me.GroupControl1.TabIndex = 2
        Me.GroupControl1.Text = "Archived Test Results"
        '
        'grTestSamples
        '
        Me.grTestSamples.DataSource = Me.bsArchivedTestResults
        Me.grTestSamples.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grTestSamples.Location = New System.Drawing.Point(2, 22)
        Me.grTestSamples.MainView = Me.GridView1
        Me.grTestSamples.Name = "grTestSamples"
        Me.grTestSamples.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1})
        Me.grTestSamples.Size = New System.Drawing.Size(1416, 556)
        Me.grTestSamples.TabIndex = 0
        Me.grTestSamples.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsArchivedTestResults
        '
        Me.bsArchivedTestResults.DataSource = GetType(AOS.BusinessObjects.ViewTestSamplesCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber, Me.colProductid1, Me.colProductdesc1, Me.colContainer1, Me.colLotnumber, Me.colItemstatus, Me.colTestsamplekey, Me.colExpr1, Me.colExpr2, Me.colTesttime, Me.colTestedby, Me.colTemperature, Me.colPhresult, Me.colPhrangelow1, Me.colPhrangehigh1, Me.colPhaccepted, Me.colSgresult, Me.colSgrangelow1, Me.colSgrangehigh1, Me.colSgaccepted, Me.colAppearance, Me.colFreeflowing, Me.colPassedtime, Me.colPassedby, Me.colPassedtest, Me.colClarity, Me.colColor, Me.colOdor})
        Me.GridView1.GridControl = Me.grTestSamples
        Me.GridView1.GroupPanelText = "OPEN WORK ORDERS"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.ViewCaption = "OPEN Work Orders"
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Inv Item#"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 1
        Me.colInvitemnumber.Width = 62
        '
        'colProductid1
        '
        Me.colProductid1.Caption = "Prod ID"
        Me.colProductid1.FieldName = "Productid"
        Me.colProductid1.Name = "colProductid1"
        Me.colProductid1.Visible = True
        Me.colProductid1.VisibleIndex = 2
        Me.colProductid1.Width = 59
        '
        'colProductdesc1
        '
        Me.colProductdesc1.Caption = "Product Description"
        Me.colProductdesc1.FieldName = "Productdesc"
        Me.colProductdesc1.Name = "colProductdesc1"
        Me.colProductdesc1.Visible = True
        Me.colProductdesc1.VisibleIndex = 3
        Me.colProductdesc1.Width = 293
        '
        'colContainer1
        '
        Me.colContainer1.FieldName = "Container"
        Me.colContainer1.Name = "colContainer1"
        Me.colContainer1.Visible = True
        Me.colContainer1.VisibleIndex = 4
        Me.colContainer1.Width = 80
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot #"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 5
        Me.colLotnumber.Width = 146
        '
        'colItemstatus
        '
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        '
        'colTestsamplekey
        '
        Me.colTestsamplekey.Caption = "Retain#"
        Me.colTestsamplekey.FieldName = "Testsamplekey"
        Me.colTestsamplekey.Name = "colTestsamplekey"
        Me.colTestsamplekey.Visible = True
        Me.colTestsamplekey.VisibleIndex = 0
        Me.colTestsamplekey.Width = 52
        '
        'colExpr1
        '
        Me.colExpr1.FieldName = "Expr1"
        Me.colExpr1.Name = "colExpr1"
        '
        'colExpr2
        '
        Me.colExpr2.FieldName = "Expr2"
        Me.colExpr2.Name = "colExpr2"
        '
        'colTesttime
        '
        Me.colTesttime.Caption = "Test Date"
        Me.colTesttime.FieldName = "Testtime"
        Me.colTesttime.Name = "colTesttime"
        Me.colTesttime.Visible = True
        Me.colTesttime.VisibleIndex = 6
        Me.colTesttime.Width = 74
        '
        'colTestedby
        '
        Me.colTestedby.Caption = "Tested By"
        Me.colTestedby.FieldName = "Testedby"
        Me.colTestedby.Name = "colTestedby"
        Me.colTestedby.Visible = True
        Me.colTestedby.VisibleIndex = 7
        Me.colTestedby.Width = 74
        '
        'colTemperature
        '
        Me.colTemperature.Caption = "Temp"
        Me.colTemperature.FieldName = "Temperature"
        Me.colTemperature.Name = "colTemperature"
        Me.colTemperature.Visible = True
        Me.colTemperature.VisibleIndex = 8
        Me.colTemperature.Width = 43
        '
        'colPhresult
        '
        Me.colPhresult.Caption = "pH"
        Me.colPhresult.FieldName = "Phresult"
        Me.colPhresult.Name = "colPhresult"
        Me.colPhresult.Visible = True
        Me.colPhresult.VisibleIndex = 9
        Me.colPhresult.Width = 42
        '
        'colPhrangelow1
        '
        Me.colPhrangelow1.Caption = "ph Low"
        Me.colPhrangelow1.FieldName = "Phrangelow"
        Me.colPhrangelow1.Name = "colPhrangelow1"
        Me.colPhrangelow1.Width = 42
        '
        'colPhrangehigh1
        '
        Me.colPhrangehigh1.Caption = "ph High"
        Me.colPhrangehigh1.FieldName = "Phrangehigh"
        Me.colPhrangehigh1.Name = "colPhrangehigh1"
        Me.colPhrangehigh1.Width = 45
        '
        'colPhaccepted
        '
        Me.colPhaccepted.FieldName = "Phaccepted"
        Me.colPhaccepted.Name = "colPhaccepted"
        '
        'colSgresult
        '
        Me.colSgresult.Caption = "SG"
        Me.colSgresult.FieldName = "Sgresult"
        Me.colSgresult.Name = "colSgresult"
        Me.colSgresult.Visible = True
        Me.colSgresult.VisibleIndex = 10
        Me.colSgresult.Width = 40
        '
        'colSgrangelow1
        '
        Me.colSgrangelow1.Caption = "SG Low"
        Me.colSgrangelow1.FieldName = "Sgrangelow"
        Me.colSgrangelow1.Name = "colSgrangelow1"
        Me.colSgrangelow1.Width = 53
        '
        'colSgrangehigh1
        '
        Me.colSgrangehigh1.Caption = "SG High"
        Me.colSgrangehigh1.FieldName = "Sgrangehigh"
        Me.colSgrangehigh1.Name = "colSgrangehigh1"
        Me.colSgrangehigh1.Width = 56
        '
        'colSgaccepted
        '
        Me.colSgaccepted.FieldName = "Sgaccepted"
        Me.colSgaccepted.Name = "colSgaccepted"
        '
        'colAppearance
        '
        Me.colAppearance.FieldName = "Appearance"
        Me.colAppearance.Name = "colAppearance"
        Me.colAppearance.Visible = True
        Me.colAppearance.VisibleIndex = 14
        Me.colAppearance.Width = 99
        '
        'colFreeflowing
        '
        Me.colFreeflowing.FieldName = "Freeflowing"
        Me.colFreeflowing.Name = "colFreeflowing"
        '
        'colPassedtime
        '
        Me.colPassedtime.FieldName = "Passedtime"
        Me.colPassedtime.Name = "colPassedtime"
        '
        'colPassedby
        '
        Me.colPassedby.FieldName = "Passedby"
        Me.colPassedby.Name = "colPassedby"
        '
        'colPassedtest
        '
        Me.colPassedtest.Caption = "Passed"
        Me.colPassedtest.FieldName = "Passedtest"
        Me.colPassedtest.Name = "colPassedtest"
        Me.colPassedtest.Visible = True
        Me.colPassedtest.VisibleIndex = 15
        Me.colPassedtest.Width = 89
        '
        'colClarity
        '
        Me.colClarity.FieldName = "Clarity"
        Me.colClarity.Name = "colClarity"
        Me.colClarity.Visible = True
        Me.colClarity.VisibleIndex = 12
        Me.colClarity.Width = 83
        '
        'colColor
        '
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 11
        Me.colColor.Width = 109
        '
        'colOdor
        '
        Me.colOdor.FieldName = "Odor"
        Me.colOdor.Name = "colOdor"
        Me.colOdor.Visible = True
        Me.colOdor.VisibleIndex = 13
        Me.colOdor.Width = 54
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Custname"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = ""
        Me.RepositoryItemLookUpEdit1.ShowPopupShadow = False
        Me.RepositoryItemLookUpEdit1.ValueMember = "Custid"
        '
        'RibbonPanelControl9
        '
        Me.RibbonPanelControl9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl9.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl9.Name = "RibbonPanelControl9"
        Me.RibbonPanelControl9.Size = New System.Drawing.Size(1424, 584)
        Me.RibbonPanelControl9.TabIndex = 6
        '
        'RibbonPanelControl8
        '
        Me.RibbonPanelControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl8.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl8.Name = "RibbonPanelControl8"
        Me.RibbonPanelControl8.Size = New System.Drawing.Size(1424, 584)
        Me.RibbonPanelControl8.TabIndex = 5
        '
        'RibbonPanelControl7
        '
        Me.RibbonPanelControl7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl7.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl7.Name = "RibbonPanelControl7"
        Me.RibbonPanelControl7.Size = New System.Drawing.Size(1424, 584)
        Me.RibbonPanelControl7.TabIndex = 4
        '
        'RibbonPanelControl5
        '
        Me.RibbonPanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl5.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl5.Name = "RibbonPanelControl5"
        Me.RibbonPanelControl5.Size = New System.Drawing.Size(1424, 584)
        Me.RibbonPanelControl5.TabIndex = 3
        '
        'RibbonPanelControl6
        '
        Me.RibbonPanelControl6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl6.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl6.Name = "RibbonPanelControl6"
        Me.RibbonPanelControl6.Size = New System.Drawing.Size(1424, 584)
        Me.RibbonPanelControl6.TabIndex = 1
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1424, 584)
        Me.RibbonPanelControl4.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'viewLab
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.Name = "viewLab"
        Me.Size = New System.Drawing.Size(1424, 734)
        Me.Tag = ""
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.grTestingItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItemsToBeTested, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvTestingItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grTestSamples, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArchivedTestResults, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents grHeader As CustomDevExGridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl6 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnAddTestingItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelTestingItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPanelControl9 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl8 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl7 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnRetrieveTestingItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnInputNewTestResults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grTestingItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvTestingItems As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit6 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grProducts As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grTestSamples As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents rbtnRetrieveArchivedTestScores As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnReviewTestResults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsItemsToBeTested As System.Windows.Forms.BindingSource
    Friend WithEvents bsArchivedTestResults As System.Windows.Forms.BindingSource
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStdgallons As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHealth As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFire As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReactivity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPersonalprotection As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDotdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnline As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlacardrequired As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassrate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyonhand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyallocated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyonorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyforsale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQtyminonhand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReorderqty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPreferredvendorid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDatecostlastchanged As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDesc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryclass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsactive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsliquid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRawmaterialgroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventorygrouping As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVolumeuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVolumeunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventorymethod As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedtime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifyby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifytime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhrangelow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhrangehigh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSgrangelow As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSgrangehigh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeedstesting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShelflife As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTestsamplekey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpr1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpr2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTesttime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTestedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTemperature As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhresult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhrangelow1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhrangehigh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPhaccepted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSgresult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSgrangelow1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSgrangehigh1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSgaccepted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAppearance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFreeflowing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPassedtime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPassedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPassedtest As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvitemnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiverdocumenttype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents colClarity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOdor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnEditArchivedTestResults As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colChemicalcolor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChemicalclarity As DevExpress.XtraGrid.Columns.GridColumn

End Class
