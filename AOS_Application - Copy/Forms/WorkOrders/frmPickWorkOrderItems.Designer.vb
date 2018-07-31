<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPickWorkOrderItems
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPickWorkOrderItems))
        Me.largeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPickItem = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsWOItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colWorkorderitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemdescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemcomments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWarehouselocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBillable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemprofit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitorcontainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourcetype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourcedocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSourcestatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkorderitemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerpo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoiceitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalvolume = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVolumeuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTotalweight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDOTIDNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatclass = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatpackagegroup = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colClassrate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDotdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHazmatdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnline = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIshazardous = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemnotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifiedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLd1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLd2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLd3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustitemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStandardunitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriceunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriceuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStandardcostunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStandardcostuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualcostunits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualcostuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colActualunitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExtprofit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAvailable = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpectedindate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDateneeded = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatedcompletiondate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNeededby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.bsPickedItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.rbtnUnPickItem = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.largeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWOItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPickedItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'largeRibbonImages
        '
        Me.largeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.largeRibbonImages.ImageStream = CType(resources.GetObject("largeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnClose, Me.rbtnPickItem, Me.rbtnUnPickItem})
        Me.RibbonControl1.LargeImages = Me.largeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 5
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowQatLocationSelector = False
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1178, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnClose
        '
        Me.rbtnClose.Caption = "Back"
        Me.rbtnClose.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnClose.Id = 1
        Me.rbtnClose.LargeImageIndex = 0
        Me.rbtnClose.Name = "rbtnClose"
        '
        'rbtnPickItem
        '
        Me.rbtnPickItem.Caption = "Pick Item"
        Me.rbtnPickItem.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPickItem.Id = 2
        Me.rbtnPickItem.LargeImageIndex = 3
        Me.rbtnPickItem.Name = "rbtnPickItem"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnPickItem)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnUnPickItem, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1178, 243)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Allocated / Unpicked Items"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsWOItems
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1174, 219)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsWOItems
        '
        Me.bsWOItems.DataSource = GetType(AOS.BusinessObjects.ViewWorkOrderItemsScreenCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colWorkorderitemnumber, Me.colWorkordernumber, Me.colItemtype, Me.colItemid, Me.colItemdescription, Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colQty, Me.colInvitemnumber, Me.colItemcomments, Me.colLotnumber, Me.colWarehouselocation, Me.colBillable, Me.colUnitcost, Me.colItemprice, Me.colItemprofit, Me.colUnitorcontainer, Me.colUnits, Me.colUom, Me.colSourcetype, Me.colSourcedocument, Me.colSourcestatus, Me.colWorkorderitemstatus, Me.colCustomerpo, Me.colShipmentitemnumber, Me.colInvoiceitemnumber, Me.colTotalvolume, Me.colVolumeuom, Me.colTotalweight, Me.colWeightuom, Me.colDOTIDNumber, Me.colHazmatid, Me.colHazmatclass, Me.colHazmatpackagegroup, Me.colClassrate, Me.colDotdesc, Me.colHazmatdesc, Me.colUnline, Me.colIshazardous, Me.colItemnotes, Me.colCreatedtime, Me.colCreatedby, Me.colModifiedtime, Me.colModifiedby, Me.colLd1, Me.colLd2, Me.colLd3, Me.colCustitemid, Me.colItemstatus, Me.colStandardunitcost, Me.colUnitprice, Me.colPriceunits, Me.colPriceuom, Me.colStandardcostunits, Me.colStandardcostuom, Me.colActualcostunits, Me.colActualcostuom, Me.colExtprice, Me.colExtcost, Me.colActualunitcost, Me.colExtprofit, Me.colAvailable, Me.colExpectedindate, Me.colDateneeded, Me.colEstimatedcompletiondate, Me.colNeededby})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
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
        'colItemtype
        '
        Me.colItemtype.Caption = "Item Type"
        Me.colItemtype.FieldName = "Itemtype"
        Me.colItemtype.Name = "colItemtype"
        Me.colItemtype.Visible = True
        Me.colItemtype.VisibleIndex = 0
        Me.colItemtype.Width = 72
        '
        'colItemid
        '
        Me.colItemid.Caption = "Item ID"
        Me.colItemid.FieldName = "Itemid"
        Me.colItemid.Name = "colItemid"
        Me.colItemid.Visible = True
        Me.colItemid.VisibleIndex = 1
        Me.colItemid.Width = 55
        '
        'colItemdescription
        '
        Me.colItemdescription.Caption = "Item Description"
        Me.colItemdescription.FieldName = "Itemdescription"
        Me.colItemdescription.Name = "colItemdescription"
        Me.colItemdescription.Visible = True
        Me.colItemdescription.VisibleIndex = 2
        Me.colItemdescription.Width = 345
        '
        'colProductid
        '
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        '
        'colProductdesc
        '
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 90
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Inv Item #"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 4
        Me.colInvitemnumber.Width = 85
        '
        'colItemcomments
        '
        Me.colItemcomments.FieldName = "Itemcomments"
        Me.colItemcomments.Name = "colItemcomments"
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot Number"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 6
        Me.colLotnumber.Width = 125
        '
        'colWarehouselocation
        '
        Me.colWarehouselocation.Caption = "Whs Loc"
        Me.colWarehouselocation.FieldName = "Warehouselocation"
        Me.colWarehouselocation.Name = "colWarehouselocation"
        Me.colWarehouselocation.Visible = True
        Me.colWarehouselocation.VisibleIndex = 7
        '
        'colBillable
        '
        Me.colBillable.FieldName = "Billable"
        Me.colBillable.Name = "colBillable"
        '
        'colUnitcost
        '
        Me.colUnitcost.FieldName = "Unitcost"
        Me.colUnitcost.Name = "colUnitcost"
        '
        'colItemprice
        '
        Me.colItemprice.FieldName = "Itemprice"
        Me.colItemprice.Name = "colItemprice"
        '
        'colItemprofit
        '
        Me.colItemprofit.FieldName = "Itemprofit"
        Me.colItemprofit.Name = "colItemprofit"
        '
        'colUnitorcontainer
        '
        Me.colUnitorcontainer.FieldName = "Unitorcontainer"
        Me.colUnitorcontainer.Name = "colUnitorcontainer"
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
        'colSourcetype
        '
        Me.colSourcetype.Caption = "Src Type"
        Me.colSourcetype.FieldName = "Sourcetype"
        Me.colSourcetype.Name = "colSourcetype"
        Me.colSourcetype.Visible = True
        Me.colSourcetype.VisibleIndex = 8
        '
        'colSourcedocument
        '
        Me.colSourcedocument.Caption = "Src Doc"
        Me.colSourcedocument.FieldName = "Sourcedocument"
        Me.colSourcedocument.Name = "colSourcedocument"
        Me.colSourcedocument.Visible = True
        Me.colSourcedocument.VisibleIndex = 9
        Me.colSourcedocument.Width = 85
        '
        'colSourcestatus
        '
        Me.colSourcestatus.Caption = "Src Status"
        Me.colSourcestatus.FieldName = "Sourcestatus"
        Me.colSourcestatus.Name = "colSourcestatus"
        Me.colSourcestatus.Visible = True
        Me.colSourcestatus.VisibleIndex = 10
        Me.colSourcestatus.Width = 93
        '
        'colWorkorderitemstatus
        '
        Me.colWorkorderitemstatus.FieldName = "Workorderitemstatus"
        Me.colWorkorderitemstatus.Name = "colWorkorderitemstatus"
        '
        'colCustomerpo
        '
        Me.colCustomerpo.FieldName = "Customerpo"
        Me.colCustomerpo.Name = "colCustomerpo"
        '
        'colShipmentitemnumber
        '
        Me.colShipmentitemnumber.FieldName = "Shipmentitemnumber"
        Me.colShipmentitemnumber.Name = "colShipmentitemnumber"
        '
        'colInvoiceitemnumber
        '
        Me.colInvoiceitemnumber.FieldName = "Invoiceitemnumber"
        Me.colInvoiceitemnumber.Name = "colInvoiceitemnumber"
        '
        'colTotalvolume
        '
        Me.colTotalvolume.FieldName = "Totalvolume"
        Me.colTotalvolume.Name = "colTotalvolume"
        '
        'colVolumeuom
        '
        Me.colVolumeuom.FieldName = "Volumeuom"
        Me.colVolumeuom.Name = "colVolumeuom"
        '
        'colTotalweight
        '
        Me.colTotalweight.FieldName = "Totalweight"
        Me.colTotalweight.Name = "colTotalweight"
        '
        'colWeightuom
        '
        Me.colWeightuom.FieldName = "Weightuom"
        Me.colWeightuom.Name = "colWeightuom"
        '
        'colDOTIDNumber
        '
        Me.colDOTIDNumber.FieldName = "DOTIDNumber"
        Me.colDOTIDNumber.Name = "colDOTIDNumber"
        '
        'colHazmatid
        '
        Me.colHazmatid.FieldName = "Hazmatid"
        Me.colHazmatid.Name = "colHazmatid"
        '
        'colHazmatclass
        '
        Me.colHazmatclass.FieldName = "Hazmatclass"
        Me.colHazmatclass.Name = "colHazmatclass"
        '
        'colHazmatpackagegroup
        '
        Me.colHazmatpackagegroup.FieldName = "Hazmatpackagegroup"
        Me.colHazmatpackagegroup.Name = "colHazmatpackagegroup"
        '
        'colClassrate
        '
        Me.colClassrate.FieldName = "Classrate"
        Me.colClassrate.Name = "colClassrate"
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
        'colIshazardous
        '
        Me.colIshazardous.FieldName = "Ishazardous"
        Me.colIshazardous.Name = "colIshazardous"
        '
        'colItemnotes
        '
        Me.colItemnotes.FieldName = "Itemnotes"
        Me.colItemnotes.Name = "colItemnotes"
        '
        'colCreatedtime
        '
        Me.colCreatedtime.FieldName = "Createdtime"
        Me.colCreatedtime.Name = "colCreatedtime"
        '
        'colCreatedby
        '
        Me.colCreatedby.FieldName = "Createdby"
        Me.colCreatedby.Name = "colCreatedby"
        '
        'colModifiedtime
        '
        Me.colModifiedtime.FieldName = "Modifiedtime"
        Me.colModifiedtime.Name = "colModifiedtime"
        '
        'colModifiedby
        '
        Me.colModifiedby.FieldName = "Modifiedby"
        Me.colModifiedby.Name = "colModifiedby"
        '
        'colLd1
        '
        Me.colLd1.FieldName = "Ld1"
        Me.colLd1.Name = "colLd1"
        '
        'colLd2
        '
        Me.colLd2.FieldName = "Ld2"
        Me.colLd2.Name = "colLd2"
        '
        'colLd3
        '
        Me.colLd3.FieldName = "Ld3"
        Me.colLd3.Name = "colLd3"
        '
        'colCustitemid
        '
        Me.colCustitemid.FieldName = "Custitemid"
        Me.colCustitemid.Name = "colCustitemid"
        '
        'colItemstatus
        '
        Me.colItemstatus.Caption = "Item Status"
        Me.colItemstatus.FieldName = "Itemstatus"
        Me.colItemstatus.Name = "colItemstatus"
        Me.colItemstatus.Visible = True
        Me.colItemstatus.VisibleIndex = 5
        Me.colItemstatus.Width = 74
        '
        'colStandardunitcost
        '
        Me.colStandardunitcost.FieldName = "Standardunitcost"
        Me.colStandardunitcost.Name = "colStandardunitcost"
        '
        'colUnitprice
        '
        Me.colUnitprice.FieldName = "Unitprice"
        Me.colUnitprice.Name = "colUnitprice"
        '
        'colPriceunits
        '
        Me.colPriceunits.FieldName = "Priceunits"
        Me.colPriceunits.Name = "colPriceunits"
        '
        'colPriceuom
        '
        Me.colPriceuom.FieldName = "Priceuom"
        Me.colPriceuom.Name = "colPriceuom"
        '
        'colStandardcostunits
        '
        Me.colStandardcostunits.FieldName = "Standardcostunits"
        Me.colStandardcostunits.Name = "colStandardcostunits"
        '
        'colStandardcostuom
        '
        Me.colStandardcostuom.FieldName = "Standardcostuom"
        Me.colStandardcostuom.Name = "colStandardcostuom"
        '
        'colActualcostunits
        '
        Me.colActualcostunits.FieldName = "Actualcostunits"
        Me.colActualcostunits.Name = "colActualcostunits"
        '
        'colActualcostuom
        '
        Me.colActualcostuom.FieldName = "Actualcostuom"
        Me.colActualcostuom.Name = "colActualcostuom"
        '
        'colExtprice
        '
        Me.colExtprice.FieldName = "Extprice"
        Me.colExtprice.Name = "colExtprice"
        '
        'colExtcost
        '
        Me.colExtcost.FieldName = "Extcost"
        Me.colExtcost.Name = "colExtcost"
        '
        'colActualunitcost
        '
        Me.colActualunitcost.FieldName = "Actualunitcost"
        Me.colActualunitcost.Name = "colActualunitcost"
        '
        'colExtprofit
        '
        Me.colExtprofit.FieldName = "Extprofit"
        Me.colExtprofit.Name = "colExtprofit"
        '
        'colAvailable
        '
        Me.colAvailable.FieldName = "Available"
        Me.colAvailable.Name = "colAvailable"
        '
        'colExpectedindate
        '
        Me.colExpectedindate.FieldName = "Expectedindate"
        Me.colExpectedindate.Name = "colExpectedindate"
        Me.colExpectedindate.Width = 65
        '
        'colDateneeded
        '
        Me.colDateneeded.FieldName = "Dateneeded"
        Me.colDateneeded.Name = "colDateneeded"
        Me.colDateneeded.Width = 65
        '
        'colEstimatedcompletiondate
        '
        Me.colEstimatedcompletiondate.FieldName = "Estimatedcompletiondate"
        Me.colEstimatedcompletiondate.Name = "colEstimatedcompletiondate"
        Me.colEstimatedcompletiondate.Width = 65
        '
        'colNeededby
        '
        Me.colNeededby.FieldName = "Neededby"
        Me.colNeededby.Name = "colNeededby"
        Me.colNeededby.Width = 96
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 338)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1178, 329)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Picked Items"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsPickedItems
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 22)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.RibbonControl1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(1174, 305)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsPickedItems
        '
        Me.bsPickedItems.DataSource = GetType(AOS.BusinessObjects.ViewWorkOrderItemsScreenCollection)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn40, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn44, Me.GridColumn45, Me.GridColumn46, Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn50, Me.GridColumn51, Me.GridColumn52, Me.GridColumn53, Me.GridColumn54, Me.GridColumn55, Me.GridColumn56, Me.GridColumn57, Me.GridColumn58, Me.GridColumn59, Me.GridColumn60, Me.GridColumn61, Me.GridColumn62, Me.GridColumn63, Me.GridColumn64, Me.GridColumn65, Me.GridColumn66, Me.GridColumn67})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsView.ShowAutoFilterRow = True
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Workorderitemnumber"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Workordernumber"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Item Type"
        Me.GridColumn3.FieldName = "Itemtype"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 71
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Item ID"
        Me.GridColumn4.FieldName = "Itemid"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 52
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Item Description"
        Me.GridColumn5.FieldName = "Itemdescription"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 2
        Me.GridColumn5.Width = 346
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "Productid"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "Productdesc"
        Me.GridColumn7.Name = "GridColumn7"
        '
        'GridColumn8
        '
        Me.GridColumn8.FieldName = "Container"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 3
        Me.GridColumn8.Width = 93
        '
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "Qty"
        Me.GridColumn9.Name = "GridColumn9"
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Inv Item #"
        Me.GridColumn10.FieldName = "Invitemnumber"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 4
        Me.GridColumn10.Width = 80
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "Itemcomments"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Lot Number"
        Me.GridColumn12.FieldName = "Lotnumber"
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 6
        Me.GridColumn12.Width = 209
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Whs Loc"
        Me.GridColumn13.FieldName = "Warehouselocation"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 7
        Me.GridColumn13.Width = 244
        '
        'GridColumn14
        '
        Me.GridColumn14.FieldName = "Billable"
        Me.GridColumn14.Name = "GridColumn14"
        '
        'GridColumn15
        '
        Me.GridColumn15.FieldName = "Unitcost"
        Me.GridColumn15.Name = "GridColumn15"
        '
        'GridColumn16
        '
        Me.GridColumn16.FieldName = "Itemprice"
        Me.GridColumn16.Name = "GridColumn16"
        '
        'GridColumn17
        '
        Me.GridColumn17.FieldName = "Itemprofit"
        Me.GridColumn17.Name = "GridColumn17"
        '
        'GridColumn18
        '
        Me.GridColumn18.FieldName = "Unitorcontainer"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.FieldName = "Units"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.FieldName = "Uom"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.FieldName = "Sourcetype"
        Me.GridColumn21.Name = "GridColumn21"
        Me.GridColumn21.Width = 67
        '
        'GridColumn22
        '
        Me.GridColumn22.FieldName = "Sourcedocument"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Width = 67
        '
        'GridColumn23
        '
        Me.GridColumn23.FieldName = "Sourcestatus"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Width = 67
        '
        'GridColumn24
        '
        Me.GridColumn24.FieldName = "Workorderitemstatus"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn25
        '
        Me.GridColumn25.FieldName = "Customerpo"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn26
        '
        Me.GridColumn26.FieldName = "Shipmentitemnumber"
        Me.GridColumn26.Name = "GridColumn26"
        '
        'GridColumn27
        '
        Me.GridColumn27.FieldName = "Invoiceitemnumber"
        Me.GridColumn27.Name = "GridColumn27"
        '
        'GridColumn28
        '
        Me.GridColumn28.FieldName = "Totalvolume"
        Me.GridColumn28.Name = "GridColumn28"
        '
        'GridColumn29
        '
        Me.GridColumn29.FieldName = "Volumeuom"
        Me.GridColumn29.Name = "GridColumn29"
        '
        'GridColumn30
        '
        Me.GridColumn30.FieldName = "Totalweight"
        Me.GridColumn30.Name = "GridColumn30"
        '
        'GridColumn31
        '
        Me.GridColumn31.FieldName = "Weightuom"
        Me.GridColumn31.Name = "GridColumn31"
        '
        'GridColumn32
        '
        Me.GridColumn32.FieldName = "DOTIDNumber"
        Me.GridColumn32.Name = "GridColumn32"
        '
        'GridColumn33
        '
        Me.GridColumn33.FieldName = "Hazmatid"
        Me.GridColumn33.Name = "GridColumn33"
        '
        'GridColumn34
        '
        Me.GridColumn34.FieldName = "Hazmatclass"
        Me.GridColumn34.Name = "GridColumn34"
        '
        'GridColumn35
        '
        Me.GridColumn35.FieldName = "Hazmatpackagegroup"
        Me.GridColumn35.Name = "GridColumn35"
        '
        'GridColumn36
        '
        Me.GridColumn36.FieldName = "Classrate"
        Me.GridColumn36.Name = "GridColumn36"
        '
        'GridColumn37
        '
        Me.GridColumn37.FieldName = "Dotdesc"
        Me.GridColumn37.Name = "GridColumn37"
        '
        'GridColumn38
        '
        Me.GridColumn38.FieldName = "Hazmatdesc"
        Me.GridColumn38.Name = "GridColumn38"
        '
        'GridColumn39
        '
        Me.GridColumn39.FieldName = "Unline"
        Me.GridColumn39.Name = "GridColumn39"
        '
        'GridColumn40
        '
        Me.GridColumn40.FieldName = "Ishazardous"
        Me.GridColumn40.Name = "GridColumn40"
        '
        'GridColumn41
        '
        Me.GridColumn41.FieldName = "Itemnotes"
        Me.GridColumn41.Name = "GridColumn41"
        '
        'GridColumn42
        '
        Me.GridColumn42.FieldName = "Createdtime"
        Me.GridColumn42.Name = "GridColumn42"
        '
        'GridColumn43
        '
        Me.GridColumn43.FieldName = "Createdby"
        Me.GridColumn43.Name = "GridColumn43"
        '
        'GridColumn44
        '
        Me.GridColumn44.FieldName = "Modifiedtime"
        Me.GridColumn44.Name = "GridColumn44"
        '
        'GridColumn45
        '
        Me.GridColumn45.FieldName = "Modifiedby"
        Me.GridColumn45.Name = "GridColumn45"
        '
        'GridColumn46
        '
        Me.GridColumn46.FieldName = "Ld1"
        Me.GridColumn46.Name = "GridColumn46"
        '
        'GridColumn47
        '
        Me.GridColumn47.FieldName = "Ld2"
        Me.GridColumn47.Name = "GridColumn47"
        '
        'GridColumn48
        '
        Me.GridColumn48.FieldName = "Ld3"
        Me.GridColumn48.Name = "GridColumn48"
        '
        'GridColumn49
        '
        Me.GridColumn49.FieldName = "Custitemid"
        Me.GridColumn49.Name = "GridColumn49"
        '
        'GridColumn50
        '
        Me.GridColumn50.Caption = "Item Status"
        Me.GridColumn50.FieldName = "Itemstatus"
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 5
        Me.GridColumn50.Width = 79
        '
        'GridColumn51
        '
        Me.GridColumn51.FieldName = "Standardunitcost"
        Me.GridColumn51.Name = "GridColumn51"
        '
        'GridColumn52
        '
        Me.GridColumn52.FieldName = "Unitprice"
        Me.GridColumn52.Name = "GridColumn52"
        '
        'GridColumn53
        '
        Me.GridColumn53.FieldName = "Priceunits"
        Me.GridColumn53.Name = "GridColumn53"
        '
        'GridColumn54
        '
        Me.GridColumn54.FieldName = "Priceuom"
        Me.GridColumn54.Name = "GridColumn54"
        '
        'GridColumn55
        '
        Me.GridColumn55.FieldName = "Standardcostunits"
        Me.GridColumn55.Name = "GridColumn55"
        '
        'GridColumn56
        '
        Me.GridColumn56.FieldName = "Standardcostuom"
        Me.GridColumn56.Name = "GridColumn56"
        '
        'GridColumn57
        '
        Me.GridColumn57.FieldName = "Actualcostunits"
        Me.GridColumn57.Name = "GridColumn57"
        '
        'GridColumn58
        '
        Me.GridColumn58.FieldName = "Actualcostuom"
        Me.GridColumn58.Name = "GridColumn58"
        '
        'GridColumn59
        '
        Me.GridColumn59.FieldName = "Extprice"
        Me.GridColumn59.Name = "GridColumn59"
        '
        'GridColumn60
        '
        Me.GridColumn60.FieldName = "Extcost"
        Me.GridColumn60.Name = "GridColumn60"
        '
        'GridColumn61
        '
        Me.GridColumn61.FieldName = "Actualunitcost"
        Me.GridColumn61.Name = "GridColumn61"
        '
        'GridColumn62
        '
        Me.GridColumn62.FieldName = "Extprofit"
        Me.GridColumn62.Name = "GridColumn62"
        '
        'GridColumn63
        '
        Me.GridColumn63.FieldName = "Available"
        Me.GridColumn63.Name = "GridColumn63"
        '
        'GridColumn64
        '
        Me.GridColumn64.FieldName = "Expectedindate"
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.Width = 67
        '
        'GridColumn65
        '
        Me.GridColumn65.FieldName = "Dateneeded"
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.Width = 67
        '
        'GridColumn66
        '
        Me.GridColumn66.FieldName = "Estimatedcompletiondate"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.Width = 67
        '
        'GridColumn67
        '
        Me.GridColumn67.FieldName = "Neededby"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.Width = 94
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'rbtnUnPickItem
        '
        Me.rbtnUnPickItem.Caption = "Return Item to Inventory"
        Me.rbtnUnPickItem.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnUnPickItem.Id = 4
        Me.rbtnUnPickItem.LargeImageIndex = 7
        Me.rbtnUnPickItem.Name = "rbtnUnPickItem"
        '
        'frmPickWorkOrderItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 667)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmPickWorkOrderItems"
        Me.Text = "Items for Workorder #"
        CType(Me.largeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWOItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPickedItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents largeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsWOItems As BindingSource
    Friend WithEvents rbtnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnPickItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colWorkorderitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemdescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemcomments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWarehouselocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBillable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemprofit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitorcontainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourcetype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourcedocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSourcestatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkorderitemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerpo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoiceitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalvolume As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVolumeuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotalweight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDOTIDNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatclass As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatpackagegroup As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colClassrate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDotdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHazmatdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnline As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIshazardous As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemnotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedtime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedtime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifiedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLd1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLd2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLd3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustitemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStandardunitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriceunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriceuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStandardcostunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStandardcostuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualcostunits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualcostuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colActualunitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExtprofit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAvailable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpectedindate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDateneeded As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEstimatedcompletiondate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNeededby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsPickedItems As BindingSource
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn67 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents rbtnUnPickItem As DevExpress.XtraBars.BarButtonItem
End Class
