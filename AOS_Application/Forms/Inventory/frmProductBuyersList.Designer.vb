<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductBuyersList

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductBuyersList))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnExportToExcel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.grvItemList = New AOS.CustomClasses.CustomDevExGridView()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVolumeprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVolumeuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightprice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWeightuom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPriceliststatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastpurchased = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.bs.DataSource = GetType(AOS.BusinessObjects.ViewProductBuyersListCollection)
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
        Me.RibbonControl1.Size = New System.Drawing.Size(1109, 117)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Close"
        Me.btnCancel.Id = 5
        Me.btnCancel.ImageOptions.LargeImageIndex = 1
        Me.btnCancel.Name = "btnCancel"
        '
        'rbtnExportToExcel
        '
        Me.rbtnExportToExcel.Caption = "Export To Excel"
        Me.rbtnExportToExcel.Id = 6
        Me.rbtnExportToExcel.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.export_excel
        Me.rbtnExportToExcel.Name = "rbtnExportToExcel"
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
        Me.GroupControl1.Location = New System.Drawing.Point(0, 117)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1109, 438)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Customer Price Lists / Sales History"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bs
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.grvItemList
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1105, 414)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvItemList})
        '
        'grvItemList
        '
        Me.grvItemList.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colCustid, Me.colVolumeprice, Me.colVolumeuom, Me.colWeightprice, Me.colWeightuom, Me.colPriceliststatus, Me.colCustname, Me.colLastpurchased, Me.GridColumn1, Me.GridColumn2})
        Me.grvItemList.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.grvItemList.GridControl = Me.GridControl1
        Me.grvItemList.Name = "grvItemList"
        Me.grvItemList.OptionsBehavior.Editable = False
        Me.grvItemList.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvItemList.OptionsView.ShowAutoFilterRow = True
        Me.grvItemList.OptionsView.ShowGroupPanel = False
        Me.grvItemList.OptionsView.ShowIndicator = False
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 0
        Me.colProductid.Width = 51
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 1
        Me.colProductdesc.Width = 244
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 2
        Me.colContainer.Width = 71
        '
        'colCustid
        '
        Me.colCustid.Caption = "Cust ID"
        Me.colCustid.FieldName = "Custid"
        Me.colCustid.Name = "colCustid"
        Me.colCustid.Visible = True
        Me.colCustid.VisibleIndex = 3
        Me.colCustid.Width = 49
        '
        'colVolumeprice
        '
        Me.colVolumeprice.Caption = "VOL $"
        Me.colVolumeprice.FieldName = "Volumeprice"
        Me.colVolumeprice.Name = "colVolumeprice"
        Me.colVolumeprice.Visible = True
        Me.colVolumeprice.VisibleIndex = 7
        Me.colVolumeprice.Width = 48
        '
        'colVolumeuom
        '
        Me.colVolumeuom.Caption = "VOL UOM"
        Me.colVolumeuom.FieldName = "Volumeuom"
        Me.colVolumeuom.Name = "colVolumeuom"
        Me.colVolumeuom.Visible = True
        Me.colVolumeuom.VisibleIndex = 6
        Me.colVolumeuom.Width = 58
        '
        'colWeightprice
        '
        Me.colWeightprice.Caption = "WGT $"
        Me.colWeightprice.FieldName = "Weightprice"
        Me.colWeightprice.Name = "colWeightprice"
        Me.colWeightprice.Visible = True
        Me.colWeightprice.VisibleIndex = 10
        Me.colWeightprice.Width = 54
        '
        'colWeightuom
        '
        Me.colWeightuom.Caption = "WGT UOM"
        Me.colWeightuom.FieldName = "Weightuom"
        Me.colWeightuom.Name = "colWeightuom"
        Me.colWeightuom.Visible = True
        Me.colWeightuom.VisibleIndex = 9
        Me.colWeightuom.Width = 59
        '
        'colPriceliststatus
        '
        Me.colPriceliststatus.Caption = "Status"
        Me.colPriceliststatus.FieldName = "Priceliststatus"
        Me.colPriceliststatus.Name = "colPriceliststatus"
        Me.colPriceliststatus.Visible = True
        Me.colPriceliststatus.VisibleIndex = 11
        Me.colPriceliststatus.Width = 50
        '
        'colCustname
        '
        Me.colCustname.Caption = "Customer Name"
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 4
        Me.colCustname.Width = 204
        '
        'colLastpurchased
        '
        Me.colLastpurchased.Caption = "Last Purchased"
        Me.colLastpurchased.FieldName = "Lastpurchased"
        Me.colLastpurchased.Name = "colLastpurchased"
        Me.colLastpurchased.Visible = True
        Me.colLastpurchased.VisibleIndex = 12
        Me.colLastpurchased.Width = 91
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "VOL Units"
        Me.GridColumn1.FieldName = "Volumeunits"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 63
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "WGT Units"
        Me.GridColumn2.FieldName = "Weightunits"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 8
        Me.GridColumn2.Width = 61
        '
        'frmProductBuyersList
        '
        Me.ClientSize = New System.Drawing.Size(1109, 555)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProductBuyersList"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product  / Customer Sales"
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
    Friend WithEvents rbtnExportToExcel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVolumeprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVolumeuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightprice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeightuom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPriceliststatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastpurchased As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
End Class
