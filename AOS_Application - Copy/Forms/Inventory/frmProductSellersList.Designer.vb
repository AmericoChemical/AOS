<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductSellersList

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductSellersList))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.grvItemList = New AOS.CustomClasses.CustomDevExGridView()
        Me.colItemid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemdescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitcost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasedate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPurchasetype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rbtnExportToExcel = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.ViewProductSellersListCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnCancel, Me.rbtnExportToExcel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1109, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Close"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 1
        Me.btnCancel.Name = "btnCancel"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnExportToExcel, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1109, 460)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Vendor Purchase History"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bs
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.grvItemList
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1105, 436)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvItemList})
        '
        'grvItemList
        '
        Me.grvItemList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemid, Me.colItemdescription, Me.colContainer, Me.colQty, Me.colUnitcost, Me.colUom, Me.colPurchasenumber, Me.colVendorname, Me.colPurchasedate, Me.colPurchasetype, Me.colShipname})
        Me.grvItemList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.grvItemList.GridControl = Me.GridControl1
        Me.grvItemList.Name = "grvItemList"
        Me.grvItemList.OptionsBehavior.Editable = False
        Me.grvItemList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvItemList.OptionsView.ShowAutoFilterRow = True
        Me.grvItemList.OptionsView.ShowGroupPanel = False
        Me.grvItemList.OptionsView.ShowIndicator = False
        '
        'colItemid
        '
        Me.colItemid.Caption = "Item ID"
        Me.colItemid.FieldName = "Itemid"
        Me.colItemid.Name = "colItemid"
        Me.colItemid.Visible = True
        Me.colItemid.VisibleIndex = 0
        Me.colItemid.Width = 47
        '
        'colItemdescription
        '
        Me.colItemdescription.Caption = "Item Description"
        Me.colItemdescription.FieldName = "Itemdescription"
        Me.colItemdescription.Name = "colItemdescription"
        Me.colItemdescription.Visible = True
        Me.colItemdescription.VisibleIndex = 1
        Me.colItemdescription.Width = 211
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 2
        Me.colContainer.Width = 61
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        Me.colQty.Visible = True
        Me.colQty.VisibleIndex = 3
        Me.colQty.Width = 47
        '
        'colUnitcost
        '
        Me.colUnitcost.Caption = "Unit Cost"
        Me.colUnitcost.FieldName = "Unitcost"
        Me.colUnitcost.Name = "colUnitcost"
        Me.colUnitcost.Visible = True
        Me.colUnitcost.VisibleIndex = 4
        Me.colUnitcost.Width = 57
        '
        'colUom
        '
        Me.colUom.Caption = "UOM"
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        Me.colUom.Visible = True
        Me.colUom.VisibleIndex = 5
        Me.colUom.Width = 37
        '
        'colPurchasenumber
        '
        Me.colPurchasenumber.Caption = "PO #"
        Me.colPurchasenumber.FieldName = "Purchasenumber"
        Me.colPurchasenumber.Name = "colPurchasenumber"
        Me.colPurchasenumber.Visible = True
        Me.colPurchasenumber.VisibleIndex = 6
        Me.colPurchasenumber.Width = 66
        '
        'colVendorname
        '
        Me.colVendorname.Caption = "Vendor Name"
        Me.colVendorname.FieldName = "Vendorname"
        Me.colVendorname.Name = "colVendorname"
        Me.colVendorname.Visible = True
        Me.colVendorname.VisibleIndex = 9
        Me.colVendorname.Width = 217
        '
        'colPurchasedate
        '
        Me.colPurchasedate.Caption = "Purchase Date"
        Me.colPurchasedate.FieldName = "Purchasedate"
        Me.colPurchasedate.Name = "colPurchasedate"
        Me.colPurchasedate.Visible = True
        Me.colPurchasedate.VisibleIndex = 10
        Me.colPurchasedate.Width = 101
        '
        'colPurchasetype
        '
        Me.colPurchasetype.Caption = "Type"
        Me.colPurchasetype.FieldName = "Purchasetype"
        Me.colPurchasetype.Name = "colPurchasetype"
        Me.colPurchasetype.Visible = True
        Me.colPurchasetype.VisibleIndex = 7
        Me.colPurchasetype.Width = 71
        '
        'colShipname
        '
        Me.colShipname.Caption = "Shipped To"
        Me.colShipname.FieldName = "Shipname"
        Me.colShipname.Name = "colShipname"
        Me.colShipname.Visible = True
        Me.colShipname.VisibleIndex = 8
        Me.colShipname.Width = 190
        '
        'rbtnExportToExcel
        '
        Me.rbtnExportToExcel.Caption = "Export To Excel"
        Me.rbtnExportToExcel.Id = 6
        Me.rbtnExportToExcel.LargeGlyph = Global.AOS.My.Resources.Resources.export_excel
        Me.rbtnExportToExcel.Name = "rbtnExportToExcel"
        '
        'frmProductSellersList
        '
        Me.ClientSize = New System.Drawing.Size(1109, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProductSellersList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product  / Vendor Purchases"
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvItemList As CustomDevExGridView
    Friend WithEvents colItemid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemdescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitcost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasedate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPurchasetype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnExportToExcel As DevExpress.XtraBars.BarButtonItem
End Class
