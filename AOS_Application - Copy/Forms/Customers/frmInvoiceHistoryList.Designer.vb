<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceHistoryList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceHistoryList))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnSelectHistoricalInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintInvoiceHistorical = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsInvoiceHistoryHeader = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvoicehistoryid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangeddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangetype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangereason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colChangedby = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvoiceHistoryHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnSelectHistoricalInvoice, Me.rbtnCancel, Me.rbtnPrintInvoiceHistorical})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 4
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(764, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnSelectHistoricalInvoice
        '
        Me.rbtnSelectHistoricalInvoice.Caption = "View Historical Invoice"
        Me.rbtnSelectHistoricalInvoice.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnSelectHistoricalInvoice.Id = 1
        Me.rbtnSelectHistoricalInvoice.ImageOptions.LargeImageIndex = 7
        Me.rbtnSelectHistoricalInvoice.Name = "rbtnSelectHistoricalInvoice"
        '
        'rbtnCancel
        '
        Me.rbtnCancel.Caption = "Close"
        Me.rbtnCancel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnCancel.Id = 2
        Me.rbtnCancel.ImageOptions.LargeImageIndex = 6
        Me.rbtnCancel.Name = "rbtnCancel"
        '
        'rbtnPrintInvoiceHistorical
        '
        Me.rbtnPrintInvoiceHistorical.Caption = "Print Historical Invoice"
        Me.rbtnPrintInvoiceHistorical.Id = 3
        Me.rbtnPrintInvoiceHistorical.ImageOptions.LargeImageIndex = 10
        Me.rbtnPrintInvoiceHistorical.Name = "rbtnPrintInvoiceHistorical"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnSelectHistoricalInvoice)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnCancel)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Action"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnPrintInvoiceHistorical)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Print"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(764, 313)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Select History Record for Invoice#: "
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsInvoiceHistoryHeader
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 20)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(760, 291)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsInvoiceHistoryHeader
        '
        Me.bsInvoiceHistoryHeader.DataSource = GetType(AOS.BusinessObjects.InvoicehistoryheaderCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvoicehistoryid, Me.colInvoicenumber, Me.colChangeddate, Me.colChangetype, Me.colChangereason, Me.colChangedby})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colInvoicehistoryid
        '
        Me.colInvoicehistoryid.Caption = "History Id"
        Me.colInvoicehistoryid.FieldName = "Invoicehistoryid"
        Me.colInvoicehistoryid.Name = "colInvoicehistoryid"
        Me.colInvoicehistoryid.Visible = True
        Me.colInvoicehistoryid.VisibleIndex = 0
        '
        'colInvoicenumber
        '
        Me.colInvoicenumber.Caption = "Invoice Number"
        Me.colInvoicenumber.FieldName = "Invoicenumber"
        Me.colInvoicenumber.Name = "colInvoicenumber"
        Me.colInvoicenumber.Visible = True
        Me.colInvoicenumber.VisibleIndex = 1
        '
        'colChangeddate
        '
        Me.colChangeddate.Caption = "Change Date"
        Me.colChangeddate.DisplayFormat.FormatString = "g"
        Me.colChangeddate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colChangeddate.FieldName = "Changeddate"
        Me.colChangeddate.Name = "colChangeddate"
        Me.colChangeddate.Visible = True
        Me.colChangeddate.VisibleIndex = 2
        '
        'colChangetype
        '
        Me.colChangetype.FieldName = "Changetype"
        Me.colChangetype.Name = "colChangetype"
        Me.colChangetype.Visible = True
        Me.colChangetype.VisibleIndex = 3
        '
        'colChangereason
        '
        Me.colChangereason.FieldName = "Changereason"
        Me.colChangereason.Name = "colChangereason"
        Me.colChangereason.Visible = True
        Me.colChangereason.VisibleIndex = 4
        '
        'colChangedby
        '
        Me.colChangedby.FieldName = "Changedby"
        Me.colChangedby.Name = "colChangedby"
        Me.colChangedby.Visible = True
        Me.colChangedby.VisibleIndex = 5
        '
        'frmInvoiceHistoryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 408)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmInvoiceHistoryList"
        Me.Text = "Invoice Change History"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvoiceHistoryHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnSelectHistoricalInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsInvoiceHistoryHeader As BindingSource
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents rbtnPrintInvoiceHistorical As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colInvoicenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangeddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangetype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangereason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colChangedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicehistoryid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
End Class
