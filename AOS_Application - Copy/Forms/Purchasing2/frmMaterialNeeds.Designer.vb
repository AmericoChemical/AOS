<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialNeeds

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialNeeds))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnEditPOItem = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAllocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnUnallocate = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCOAText = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRetrieveMaterialNeeds = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.WorkPanelsHolder2 = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.grvProductionOrder = New DevExpress.XtraGrid.GridControl()
        Me.bsProductionOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.grviewProductionOrders = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionOrderNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grvPurchaseProduct = New DevExpress.XtraGrid.GridControl()
        Me.bsPurchaseProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.grvFullAvailableInventory = New DevExpress.XtraGrid.GridControl()
        Me.bsFullAvailableInventory = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colMaterialid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouselocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInventoryclass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonControl2 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCreatePurchaseItems = New DevExpress.XtraBars.BarButtonItem()
        Me.btnConvert = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCreateProductionOrder = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.grMaterialPlanning = New DevExpress.XtraGrid.GridControl()
        Me.bsMaterialPlanning = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvMaterialPlanning = New AOS.CustomClasses.CustomDevExGridView()
        Me.colMaterialid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmInventory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmInproduction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmOnorder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmRequested = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmInprocess = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.btnQuantityDelivered = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.WorkPanelsHolder2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder2.SuspendLayout()
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl3.SuspendLayout()
        CType(Me.grvProductionOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductionOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grviewProductionOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.grvPurchaseProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPurchaseProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl4.SuspendLayout()
        CType(Me.grvFullAvailableInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFullAvailableInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.grMaterialPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaterialPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvMaterialPlanning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnEditPOItem, Me.btnAllocate, Me.btnUnallocate, Me.btnCOAText, Me.btnRetrieveMaterialNeeds, Me.btnClose})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 16
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.Size = New System.Drawing.Size(1156, 95)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
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
        'btnRetrieveMaterialNeeds
        '
        Me.btnRetrieveMaterialNeeds.Caption = "Retriving Material Needs"
        Me.btnRetrieveMaterialNeeds.Id = 14
        Me.btnRetrieveMaterialNeeds.LargeGlyph = CType(resources.GetObject("btnRetrieveMaterialNeeds.LargeGlyph"), System.Drawing.Image)
        Me.btnRetrieveMaterialNeeds.Name = "btnRetrieveMaterialNeeds"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 15
        Me.btnClose.LargeGlyph = CType(resources.GetObject("btnClose.LargeGlyph"), System.Drawing.Image)
        Me.btnClose.Name = "btnClose"
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRetrieveMaterialNeeds)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Actions"
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
        Me.WorkPanelsHolder2.Controls.Add(Me.RibbonPanelControl4)
        Me.WorkPanelsHolder2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder2.Location = New System.Drawing.Point(0, 117)
        Me.WorkPanelsHolder2.Name = "WorkPanelsHolder2"
        Me.WorkPanelsHolder2.Size = New System.Drawing.Size(1156, 305)
        Me.WorkPanelsHolder2.TabIndex = 1
        '
        'RibbonPanelControl3
        '
        Me.RibbonPanelControl3.Controls.Add(Me.grvProductionOrder)
        Me.RibbonPanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl3.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl3.Name = "RibbonPanelControl3"
        Me.RibbonPanelControl3.Size = New System.Drawing.Size(1152, 301)
        Me.RibbonPanelControl3.TabIndex = 0
        '
        'grvProductionOrder
        '
        Me.grvProductionOrder.DataSource = Me.bsProductionOrder
        Me.grvProductionOrder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grvProductionOrder.Location = New System.Drawing.Point(2, 2)
        Me.grvProductionOrder.LookAndFeel.SkinName = "Money Twins"
        Me.grvProductionOrder.MainView = Me.grviewProductionOrders
        Me.grvProductionOrder.Name = "grvProductionOrder"
        Me.grvProductionOrder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.grvProductionOrder.Size = New System.Drawing.Size(1148, 297)
        Me.grvProductionOrder.TabIndex = 11
        Me.grvProductionOrder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grviewProductionOrders})
        '
        'bsProductionOrder
        '
        Me.bsProductionOrder.DataSource = GetType(AOS.BusinessObjects.ViewProdcutionOrder2Collection)
        '
        'grviewProductionOrders
        '
        Me.grviewProductionOrders.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grviewProductionOrders.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grviewProductionOrders.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.grviewProductionOrders.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grviewProductionOrders.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grviewProductionOrders.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grviewProductionOrders.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.grviewProductionOrders.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grviewProductionOrders.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.grviewProductionOrders.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.grviewProductionOrders.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grviewProductionOrders.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grviewProductionOrders.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grviewProductionOrders.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grviewProductionOrders.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grviewProductionOrders.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grviewProductionOrders.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grviewProductionOrders.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grviewProductionOrders.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grviewProductionOrders.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grviewProductionOrders.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.grviewProductionOrders.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grviewProductionOrders.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grviewProductionOrders.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grviewProductionOrders.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grviewProductionOrders.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grviewProductionOrders.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grviewProductionOrders.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grviewProductionOrders.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grviewProductionOrders.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grviewProductionOrders.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grviewProductionOrders.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grviewProductionOrders.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grviewProductionOrders.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grviewProductionOrders.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn38, Me.GridColumn39, Me.colProductionOrderNum, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43})
        Me.grviewProductionOrders.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grviewProductionOrders.GridControl = Me.grvProductionOrder
        Me.grviewProductionOrders.Name = "grviewProductionOrders"
        Me.grviewProductionOrders.OptionsBehavior.Editable = False
        Me.grviewProductionOrders.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grviewProductionOrders.OptionsView.ShowGroupPanel = False
        Me.grviewProductionOrders.OptionsView.ShowIndicator = False
        '
        'GridColumn38
        '
        Me.GridColumn38.Caption = "QTY"
        Me.GridColumn38.FieldName = "Qty"
        Me.GridColumn38.Name = "GridColumn38"
        Me.GridColumn38.Visible = True
        Me.GridColumn38.VisibleIndex = 0
        Me.GridColumn38.Width = 61
        '
        'GridColumn39
        '
        Me.GridColumn39.Caption = "UOM"
        Me.GridColumn39.FieldName = "Uom"
        Me.GridColumn39.Name = "GridColumn39"
        Me.GridColumn39.OptionsColumn.FixedWidth = True
        Me.GridColumn39.Visible = True
        Me.GridColumn39.VisibleIndex = 1
        Me.GridColumn39.Width = 35
        '
        'colProductionOrderNum
        '
        Me.colProductionOrderNum.Caption = "Prod Order #"
        Me.colProductionOrderNum.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.colProductionOrderNum.FieldName = "Prodordernum"
        Me.colProductionOrderNum.Name = "colProductionOrderNum"
        Me.colProductionOrderNum.Visible = True
        Me.colProductionOrderNum.VisibleIndex = 2
        Me.colProductionOrderNum.Width = 82
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'GridColumn41
        '
        Me.GridColumn41.Caption = "Work Order #"
        Me.GridColumn41.FieldName = "Workordernumber"
        Me.GridColumn41.Name = "GridColumn41"
        Me.GridColumn41.Visible = True
        Me.GridColumn41.VisibleIndex = 3
        Me.GridColumn41.Width = 82
        '
        'GridColumn42
        '
        Me.GridColumn42.Caption = "Customer"
        Me.GridColumn42.FieldName = "Custname"
        Me.GridColumn42.Name = "GridColumn42"
        Me.GridColumn42.Visible = True
        Me.GridColumn42.VisibleIndex = 4
        Me.GridColumn42.Width = 816
        '
        'GridColumn43
        '
        Me.GridColumn43.Caption = "Date Needed"
        Me.GridColumn43.FieldName = "Neededby"
        Me.GridColumn43.Name = "GridColumn43"
        Me.GridColumn43.OptionsColumn.FixedWidth = True
        Me.GridColumn43.Visible = True
        Me.GridColumn43.VisibleIndex = 5
        Me.GridColumn43.Width = 80
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Controls.Add(Me.grvPurchaseProduct)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1152, 301)
        Me.RibbonPanelControl2.TabIndex = 0
        '
        'grvPurchaseProduct
        '
        Me.grvPurchaseProduct.DataSource = Me.bsPurchaseProducts
        Me.grvPurchaseProduct.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grvPurchaseProduct.Location = New System.Drawing.Point(2, 2)
        Me.grvPurchaseProduct.LookAndFeel.SkinName = "Money Twins"
        Me.grvPurchaseProduct.MainView = Me.GridView2
        Me.grvPurchaseProduct.Name = "grvPurchaseProduct"
        Me.grvPurchaseProduct.Size = New System.Drawing.Size(1148, 297)
        Me.grvPurchaseProduct.TabIndex = 4
        Me.grvPurchaseProduct.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsPurchaseProducts
        '
        Me.bsPurchaseProducts.DataSource = GetType(AOS.BusinessObjects.ViewPurchaseProductsListCollection)
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView2.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.GridView2.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView2.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView2.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.GridView2.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView2.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.GridView2.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn10, Me.GridColumn1, Me.GridColumn3, Me.GridColumn4})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView2.GridControl = Me.grvPurchaseProduct
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Item ID"
        Me.GridColumn9.FieldName = "Productid"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 50
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Item Description"
        Me.GridColumn10.FieldName = "Productdesc"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 1
        Me.GridColumn10.Width = 765
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "UOM"
        Me.GridColumn1.FieldName = "Uom"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.FixedWidth = True
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 35
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Units"
        Me.GridColumn3.FieldName = "Units"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 80
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Container"
        Me.GridColumn4.FieldName = "Container"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 100
        '
        'RibbonPanelControl4
        '
        Me.RibbonPanelControl4.Controls.Add(Me.grvFullAvailableInventory)
        Me.RibbonPanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl4.Location = New System.Drawing.Point(2, 2)
        Me.RibbonPanelControl4.Name = "RibbonPanelControl4"
        Me.RibbonPanelControl4.Size = New System.Drawing.Size(1152, 301)
        Me.RibbonPanelControl4.TabIndex = 0
        '
        'grvFullAvailableInventory
        '
        Me.grvFullAvailableInventory.DataSource = Me.bsFullAvailableInventory
        Me.grvFullAvailableInventory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grvFullAvailableInventory.Location = New System.Drawing.Point(2, 2)
        Me.grvFullAvailableInventory.MainView = Me.GridView3
        Me.grvFullAvailableInventory.Name = "grvFullAvailableInventory"
        Me.grvFullAvailableInventory.Size = New System.Drawing.Size(1148, 297)
        Me.grvFullAvailableInventory.TabIndex = 9
        Me.grvFullAvailableInventory.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'bsFullAvailableInventory
        '
        Me.bsFullAvailableInventory.DataSource = GetType(AOS.BusinessObjects.ViewMaterialProductsFullAvailableForMaterialNeedsCollection)
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaterialid, Me.colProductid, Me.colProductdesc, Me.GridColumn8, Me.colReceiveddate, Me.colLotnumber, Me.colWarehouselocation, Me.colItemstatus, Me.colInventoryclass, Me.colUnits, Me.colUom, Me.GridColumn17})
        Me.GridView3.GridControl = Me.grvFullAvailableInventory
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsBehavior.Editable = False
        Me.GridView3.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.OptionsView.ShowIndicator = False
        '
        'colMaterialid
        '
        Me.colMaterialid.FieldName = "Materialid"
        Me.colMaterialid.Name = "colMaterialid"
        '
        'colProductid
        '
        Me.colProductid.Caption = "Item ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.AllowEdit = False
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 2
        Me.colProductid.Width = 45
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Item Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.OptionsColumn.AllowEdit = False
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 3
        Me.colProductdesc.Width = 402
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "Container"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 80
        '
        'colReceiveddate
        '
        Me.colReceiveddate.Caption = "Received"
        Me.colReceiveddate.DisplayFormat.FormatString = "d"
        Me.colReceiveddate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colReceiveddate.FieldName = "Receiveddate"
        Me.colReceiveddate.Name = "colReceiveddate"
        Me.colReceiveddate.OptionsColumn.AllowEdit = False
        Me.colReceiveddate.OptionsColumn.FixedWidth = True
        Me.colReceiveddate.Visible = True
        Me.colReceiveddate.VisibleIndex = 0
        Me.colReceiveddate.Width = 65
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot Number"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.OptionsColumn.AllowEdit = False
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 7
        Me.colLotnumber.Width = 94
        '
        'colWarehouselocation
        '
        Me.colWarehouselocation.Caption = "Bin"
        Me.colWarehouselocation.FieldName = "Warehouselocation"
        Me.colWarehouselocation.Name = "colWarehouselocation"
        Me.colWarehouselocation.OptionsColumn.AllowEdit = False
        Me.colWarehouselocation.Visible = True
        Me.colWarehouselocation.VisibleIndex = 8
        Me.colWarehouselocation.Width = 180
        '
        'colItemstatus
        '
        Me.colItemstatus.Caption = "Status"
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        Me.colItemstatus.OptionsColumn.AllowEdit = False
        Me.colItemstatus.OptionsColumn.FixedWidth = True
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 9
        Me.colItemstatus.Width = 80
        '
        'colInventoryclass
        '
        Me.colInventoryclass.FieldName = "Inventoryclass"
        Me.colInventoryclass.Name = "colInventoryclass"
        '
        'colUnits
        '
        Me.colUnits.Caption = "Units"
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.OptionsColumn.AllowEdit = False
        Me.colUnits.Visible = True
        Me.colUnits.VisibleIndex = 5
        Me.colUnits.Width = 50
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.OptionsColumn.AllowEdit = False
        Me.colUom.OptionsColumn.FixedWidth = True
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 6
        Me.colUom.Width = 35
        '
        'GridColumn17
        '
        Me.GridColumn17.Caption = "Item #"
        Me.GridColumn17.FieldName = "Invitemnumber"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.OptionsColumn.AllowEdit = False
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 1
        Me.GridColumn17.Width = 60
        '
        'RibbonControl2
        '
        Me.RibbonControl2.ExpandCollapseItem.Id = 0
        Me.RibbonControl2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl2.ExpandCollapseItem, Me.btnCreatePurchaseItems, Me.btnConvert, Me.rbtnCreateProductionOrder})
        Me.RibbonControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl2.MaxItemId = 7
        Me.RibbonControl2.Name = "RibbonControl2"
        Me.RibbonControl2.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage4})
        Me.RibbonControl2.ShowCategoryInCaption = False
        Me.RibbonControl2.ShowToolbarCustomizeItem = False
        Me.RibbonControl2.Size = New System.Drawing.Size(1156, 117)
        Me.RibbonControl2.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnCreatePurchaseItems
        '
        Me.btnCreatePurchaseItems.Caption = "Create Purchase Item"
        Me.btnCreatePurchaseItems.Id = 4
        Me.btnCreatePurchaseItems.LargeGlyph = CType(resources.GetObject("btnCreatePurchaseItems.LargeGlyph"), System.Drawing.Image)
        Me.btnCreatePurchaseItems.Name = "btnCreatePurchaseItems"
        '
        'btnConvert
        '
        Me.btnConvert.Caption = "Convert Item to In Process"
        Me.btnConvert.Id = 5
        Me.btnConvert.LargeGlyph = CType(resources.GetObject("btnConvert.LargeGlyph"), System.Drawing.Image)
        Me.btnConvert.Name = "btnConvert"
        '
        'rbtnCreateProductionOrder
        '
        Me.rbtnCreateProductionOrder.Caption = "Create Production Order"
        Me.rbtnCreateProductionOrder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnCreateProductionOrder.Id = 6
        Me.rbtnCreateProductionOrder.LargeGlyph = Global.AOS.My.Resources.Resources.document_add__2_
        Me.rbtnCreateProductionOrder.Name = "rbtnCreateProductionOrder"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Purchase / Make Up Product"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCreatePurchaseItems)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnCreateProductionOrder)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Existing Production Orders"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Full Available Inventory"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnConvert)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Actions"
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
        Me.GroupControl1.Controls.Add(Me.grMaterialPlanning)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1156, 192)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Material Needs"
        '
        'grMaterialPlanning
        '
        Me.grMaterialPlanning.DataSource = Me.bsMaterialPlanning
        Me.grMaterialPlanning.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grMaterialPlanning.Location = New System.Drawing.Point(2, 22)
        Me.grMaterialPlanning.LookAndFeel.SkinName = "Money Twins"
        Me.grMaterialPlanning.MainView = Me.grvMaterialPlanning
        Me.grMaterialPlanning.Name = "grMaterialPlanning"
        Me.grMaterialPlanning.Size = New System.Drawing.Size(1152, 168)
        Me.grMaterialPlanning.TabIndex = 3
        Me.grMaterialPlanning.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvMaterialPlanning})
        '
        'bsMaterialPlanning
        '
        Me.bsMaterialPlanning.DataSource = GetType(AOS.BusinessObjects.ViewRMAvailableCollection)
        '
        'grvMaterialPlanning
        '
        Me.grvMaterialPlanning.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.FocusedCell.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Transparent
        Me.grvMaterialPlanning.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.grvMaterialPlanning.Appearance.FocusedCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvMaterialPlanning.Appearance.FocusedCell.Options.UseBackColor = True
        Me.grvMaterialPlanning.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.grvMaterialPlanning.Appearance.FocusedCell.Options.UseForeColor = True
        Me.grvMaterialPlanning.Appearance.FocusedCell.Options.UseTextOptions = True
        Me.grvMaterialPlanning.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.grvMaterialPlanning.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvMaterialPlanning.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.grvMaterialPlanning.Appearance.FocusedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvMaterialPlanning.Appearance.FocusedRow.Options.UseBackColor = True
        Me.grvMaterialPlanning.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.grvMaterialPlanning.Appearance.FocusedRow.Options.UseForeColor = True
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.grvMaterialPlanning.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.grvMaterialPlanning.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.SelectedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.grvMaterialPlanning.Appearance.SelectedRow.BorderColor = System.Drawing.Color.Transparent
        Me.grvMaterialPlanning.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.grvMaterialPlanning.Appearance.SelectedRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.grvMaterialPlanning.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grvMaterialPlanning.Appearance.SelectedRow.Options.UseBorderColor = True
        Me.grvMaterialPlanning.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grvMaterialPlanning.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaterialid1, Me.colMaterialdesc, Me.colRmInventory, Me.colRmInproduction, Me.colRmOnorder, Me.colRmRequested, Me.colRmInprocess, Me.colRmAvailable})
        Me.grvMaterialPlanning.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvMaterialPlanning.GridControl = Me.grMaterialPlanning
        Me.grvMaterialPlanning.Name = "grvMaterialPlanning"
        Me.grvMaterialPlanning.OptionsBehavior.Editable = False
        Me.grvMaterialPlanning.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvMaterialPlanning.OptionsView.ShowGroupPanel = False
        Me.grvMaterialPlanning.OptionsView.ShowIndicator = False
        '
        'colMaterialid1
        '
        Me.colMaterialid1.Caption = "Mat ID"
        Me.colMaterialid1.FieldName = "Materialid"
        Me.colMaterialid1.Name = "colMaterialid1"
        Me.colMaterialid1.OptionsColumn.FixedWidth = True
        Me.colMaterialid1.Visible = True
        Me.colMaterialid1.VisibleIndex = 0
        Me.colMaterialid1.Width = 54
        '
        'colMaterialdesc
        '
        Me.colMaterialdesc.Caption = "Material Description"
        Me.colMaterialdesc.FieldName = "Materialdesc"
        Me.colMaterialdesc.Name = "colMaterialdesc"
        Me.colMaterialdesc.Visible = True
        Me.colMaterialdesc.VisibleIndex = 1
        Me.colMaterialdesc.Width = 648
        '
        'colRmInventory
        '
        Me.colRmInventory.Caption = "Inventory"
        Me.colRmInventory.DisplayFormat.FormatString = "n2"
        Me.colRmInventory.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmInventory.FieldName = "RmInventory"
        Me.colRmInventory.Name = "colRmInventory"
        Me.colRmInventory.OptionsColumn.FixedWidth = True
        Me.colRmInventory.Visible = True
        Me.colRmInventory.VisibleIndex = 2
        '
        'colRmInproduction
        '
        Me.colRmInproduction.Caption = "In Production"
        Me.colRmInproduction.DisplayFormat.FormatString = "n2"
        Me.colRmInproduction.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmInproduction.FieldName = "RmInproduction"
        Me.colRmInproduction.Name = "colRmInproduction"
        Me.colRmInproduction.OptionsColumn.FixedWidth = True
        Me.colRmInproduction.Visible = True
        Me.colRmInproduction.VisibleIndex = 3
        '
        'colRmOnorder
        '
        Me.colRmOnorder.Caption = "On Order"
        Me.colRmOnorder.DisplayFormat.FormatString = "n2"
        Me.colRmOnorder.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmOnorder.FieldName = "RmOnorder"
        Me.colRmOnorder.Name = "colRmOnorder"
        Me.colRmOnorder.OptionsColumn.FixedWidth = True
        Me.colRmOnorder.Visible = True
        Me.colRmOnorder.VisibleIndex = 4
        '
        'colRmRequested
        '
        Me.colRmRequested.Caption = "Requested"
        Me.colRmRequested.DisplayFormat.FormatString = "n2"
        Me.colRmRequested.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmRequested.FieldName = "RmRequested"
        Me.colRmRequested.Name = "colRmRequested"
        Me.colRmRequested.OptionsColumn.FixedWidth = True
        Me.colRmRequested.Visible = True
        Me.colRmRequested.VisibleIndex = 5
        '
        'colRmInprocess
        '
        Me.colRmInprocess.Caption = "In Process"
        Me.colRmInprocess.DisplayFormat.FormatString = "n2"
        Me.colRmInprocess.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmInprocess.FieldName = "RmInprocess"
        Me.colRmInprocess.Name = "colRmInprocess"
        Me.colRmInprocess.OptionsColumn.FixedWidth = True
        Me.colRmInprocess.Visible = True
        Me.colRmInprocess.VisibleIndex = 6
        '
        'colRmAvailable
        '
        Me.colRmAvailable.Caption = "Available"
        Me.colRmAvailable.DisplayFormat.FormatString = "n2"
        Me.colRmAvailable.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colRmAvailable.FieldName = "RmAvailable"
        Me.colRmAvailable.Name = "colRmAvailable"
        Me.colRmAvailable.OptionsColumn.FixedWidth = True
        Me.colRmAvailable.Visible = True
        Me.colRmAvailable.VisibleIndex = 7
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Vendor Non Conformance"
        '
        'btnQuantityDelivered
        '
        Me.btnQuantityDelivered.Caption = "Quantity Delivered"
        Me.btnQuantityDelivered.Id = 2
        Me.btnQuantityDelivered.LargeGlyph = CType(resources.GetObject("btnQuantityDelivered.LargeGlyph"), System.Drawing.Image)
        Me.btnQuantityDelivered.Name = "btnQuantityDelivered"
        '
        'frmMaterialNeeds
        '
        Me.ClientSize = New System.Drawing.Size(1156, 709)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmMaterialNeeds"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Current Material Needs Information"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.WorkPanelsHolder2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder2.ResumeLayout(False)
        CType(Me.RibbonPanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl3.ResumeLayout(False)
        CType(Me.grvProductionOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductionOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grviewProductionOrders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.grvPurchaseProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPurchaseProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl4.ResumeLayout(False)
        CType(Me.grvFullAvailableInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFullAvailableInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.grMaterialPlanning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaterialPlanning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvMaterialPlanning, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnEditPOItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAllocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnUnallocate As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCOAText As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonControl2 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents WorkPanelsHolder2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grMaterialPlanning As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvMaterialPlanning As CustomDevExGridView
    Friend WithEvents grvPurchaseProduct As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnCreatePurchaseItems As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnQuantityDelivered As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grvProductionOrder As DevExpress.XtraGrid.GridControl
    Friend WithEvents grviewProductionOrders As CustomDevExGridView
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionOrderNum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grvFullAvailableInventory As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As CustomDevExGridView
    Friend WithEvents colMaterialid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouselocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInventoryclass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsFullAvailableInventory As System.Windows.Forms.BindingSource
    Friend WithEvents bsProductionOrder As System.Windows.Forms.BindingSource
    Friend WithEvents bsPurchaseProducts As System.Windows.Forms.BindingSource
    Friend WithEvents btnConvert As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRetrieveMaterialNeeds As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsMaterialPlanning As System.Windows.Forms.BindingSource
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colMaterialid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmInventory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmInproduction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmOnorder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmRequested As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmInprocess As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents rbtnCreateProductionOrder As DevExpress.XtraBars.BarButtonItem
End Class
