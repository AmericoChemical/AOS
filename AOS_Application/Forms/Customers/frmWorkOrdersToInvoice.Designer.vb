<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorkOrdersToInvoice

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
        Dim lblBeginDate As System.Windows.Forms.Label
        Dim CustIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWorkOrdersToInvoice))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGetWorkOrders = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnSalespersonCustomerDetailedData = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnExportWorkOrdersToInvoice = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnExportCustomerData = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.gcWorkOrdersToInvoice = New DevExpress.XtraEditors.GroupControl()
        Me.grSalespersonCustomerSalesData = New DevExpress.XtraGrid.GridControl()
        Me.bsWorkOrdersToInvoiceLink = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvWorkOrdersToInvoice = New AOS.CustomClasses.CustomDevExGridView()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grpParameters = New DevExpress.XtraEditors.GroupControl()
        Me.eEndDate = New DevExpress.XtraEditors.DateEdit()
        Me.eStartDate = New DevExpress.XtraEditors.DateEdit()
        Me.colCustname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerpo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrderstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkorderdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrdertype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicenumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvoicedate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvcustpo = New DevExpress.XtraGrid.Columns.GridColumn()
        lblBeginDate = New System.Windows.Forms.Label()
        CustIDLabel = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.gcWorkOrdersToInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcWorkOrdersToInvoice.SuspendLayout()
        CType(Me.grSalespersonCustomerSalesData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWorkOrdersToInvoiceLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvWorkOrdersToInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpParameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpParameters.SuspendLayout()
        CType(Me.eEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBeginDate
        '
        lblBeginDate.AutoSize = True
        lblBeginDate.Location = New System.Drawing.Point(7, 33)
        lblBeginDate.Name = "lblBeginDate"
        lblBeginDate.Size = New System.Drawing.Size(61, 13)
        lblBeginDate.TabIndex = 1
        lblBeginDate.Text = "Start Date:"
        '
        'CustIDLabel
        '
        CustIDLabel.AutoSize = True
        CustIDLabel.Location = New System.Drawing.Point(7, 59)
        CustIDLabel.Name = "CustIDLabel"
        CustIDLabel.Size = New System.Drawing.Size(55, 13)
        CustIDLabel.TabIndex = 3
        CustIDLabel.Text = "End Date:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnClose, Me.rbtnGetWorkOrders, Me.rbtnSalespersonCustomerDetailedData, Me.rbtnExportWorkOrdersToInvoice, Me.rbtnExportCustomerData})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 9
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1560, 116)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 0
        Me.btnClose.ImageOptions.LargeImageIndex = 41
        Me.btnClose.Name = "btnClose"
        '
        'rbtnGetWorkOrders
        '
        Me.rbtnGetWorkOrders.Caption = "Get Work Orders"
        Me.rbtnGetWorkOrders.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnGetWorkOrders.Id = 5
        Me.rbtnGetWorkOrders.ImageOptions.LargeImageIndex = 27
        Me.rbtnGetWorkOrders.LargeWidth = 75
        Me.rbtnGetWorkOrders.Name = "rbtnGetWorkOrders"
        '
        'rbtnSalespersonCustomerDetailedData
        '
        Me.rbtnSalespersonCustomerDetailedData.Caption = "Get Sales Data"
        Me.rbtnSalespersonCustomerDetailedData.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnSalespersonCustomerDetailedData.Id = 6
        Me.rbtnSalespersonCustomerDetailedData.ImageOptions.LargeImageIndex = 27
        Me.rbtnSalespersonCustomerDetailedData.LargeWidth = 75
        Me.rbtnSalespersonCustomerDetailedData.Name = "rbtnSalespersonCustomerDetailedData"
        '
        'rbtnExportWorkOrdersToInvoice
        '
        Me.rbtnExportWorkOrdersToInvoice.Caption = "Export to Excel"
        Me.rbtnExportWorkOrdersToInvoice.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnExportWorkOrdersToInvoice.Id = 7
        Me.rbtnExportWorkOrdersToInvoice.ImageOptions.LargeImageIndex = 43
        Me.rbtnExportWorkOrdersToInvoice.LargeWidth = 75
        Me.rbtnExportWorkOrdersToInvoice.Name = "rbtnExportWorkOrdersToInvoice"
        '
        'rbtnExportCustomerData
        '
        Me.rbtnExportCustomerData.Caption = "Export to Excel"
        Me.rbtnExportCustomerData.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnExportCustomerData.Id = 8
        Me.rbtnExportCustomerData.ImageOptions.LargeImageIndex = 43
        Me.rbtnExportCustomerData.LargeWidth = 75
        Me.rbtnExportCustomerData.Name = "rbtnExportCustomerData"
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
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Actions"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnGetWorkOrders)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnExportWorkOrdersToInvoice, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Work Orders To Invoice"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.gcWorkOrdersToInvoice)
        Me.PanelControl1.Controls.Add(Me.PanelControl2)
        Me.PanelControl1.Controls.Add(Me.grpParameters)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 116)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl1.Size = New System.Drawing.Size(1560, 611)
        Me.PanelControl1.TabIndex = 10
        '
        'gcWorkOrdersToInvoice
        '
        Me.gcWorkOrdersToInvoice.Controls.Add(Me.grSalespersonCustomerSalesData)
        Me.gcWorkOrdersToInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcWorkOrdersToInvoice.Location = New System.Drawing.Point(8, 101)
        Me.gcWorkOrdersToInvoice.Name = "gcWorkOrdersToInvoice"
        Me.gcWorkOrdersToInvoice.Size = New System.Drawing.Size(1544, 502)
        Me.gcWorkOrdersToInvoice.TabIndex = 12
        Me.gcWorkOrdersToInvoice.Text = "Work Orders To Invoice"
        '
        'grSalespersonCustomerSalesData
        '
        Me.grSalespersonCustomerSalesData.DataSource = Me.bsWorkOrdersToInvoiceLink
        Me.grSalespersonCustomerSalesData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grSalespersonCustomerSalesData.Location = New System.Drawing.Point(2, 20)
        Me.grSalespersonCustomerSalesData.MainView = Me.grvWorkOrdersToInvoice
        Me.grSalespersonCustomerSalesData.MenuManager = Me.RibbonControl1
        Me.grSalespersonCustomerSalesData.Name = "grSalespersonCustomerSalesData"
        Me.grSalespersonCustomerSalesData.Size = New System.Drawing.Size(1540, 480)
        Me.grSalespersonCustomerSalesData.TabIndex = 1
        Me.grSalespersonCustomerSalesData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvWorkOrdersToInvoice})
        '
        'bsWorkOrdersToInvoiceLink
        '
        Me.bsWorkOrdersToInvoiceLink.DataSource = GetType(AOS.BusinessObjects.ViewWorkOrdersToInvoiceLinkCollection)
        '
        'grvWorkOrdersToInvoice
        '
        Me.grvWorkOrdersToInvoice.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCustname, Me.colCustomerpo, Me.colWorkordernumber, Me.colOrderstatus, Me.colWorkorderdate, Me.colOrdertype, Me.colInvoicenumber, Me.colInvoicedate, Me.colInvcustpo})
        Me.grvWorkOrdersToInvoice.GridControl = Me.grSalespersonCustomerSalesData
        Me.grvWorkOrdersToInvoice.Name = "grvWorkOrdersToInvoice"
        Me.grvWorkOrdersToInvoice.OptionsBehavior.Editable = False
        Me.grvWorkOrdersToInvoice.OptionsView.ShowAutoFilterRow = True
        Me.grvWorkOrdersToInvoice.OptionsView.ShowGroupPanel = False
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(8, 95)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1544, 6)
        Me.PanelControl2.TabIndex = 11
        '
        'grpParameters
        '
        Me.grpParameters.Controls.Add(Me.eEndDate)
        Me.grpParameters.Controls.Add(Me.eStartDate)
        Me.grpParameters.Controls.Add(lblBeginDate)
        Me.grpParameters.Controls.Add(CustIDLabel)
        Me.grpParameters.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpParameters.Location = New System.Drawing.Point(8, 8)
        Me.grpParameters.Name = "grpParameters"
        Me.grpParameters.Size = New System.Drawing.Size(1544, 87)
        Me.grpParameters.TabIndex = 10
        Me.grpParameters.Text = "Get Parameters"
        '
        'eEndDate
        '
        Me.eEndDate.EditValue = Nothing
        Me.eEndDate.Location = New System.Drawing.Point(88, 56)
        Me.eEndDate.MenuManager = Me.RibbonControl1
        Me.eEndDate.Name = "eEndDate"
        Me.eEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eEndDate.Size = New System.Drawing.Size(100, 20)
        Me.eEndDate.TabIndex = 5
        '
        'eStartDate
        '
        Me.eStartDate.EditValue = Nothing
        Me.eStartDate.Location = New System.Drawing.Point(88, 30)
        Me.eStartDate.MenuManager = Me.RibbonControl1
        Me.eStartDate.Name = "eStartDate"
        Me.eStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eStartDate.Size = New System.Drawing.Size(100, 20)
        Me.eStartDate.TabIndex = 4
        '
        'colCustname
        '
        Me.colCustname.Caption = "Customer Name"
        Me.colCustname.FieldName = "Custname"
        Me.colCustname.Name = "colCustname"
        Me.colCustname.Visible = True
        Me.colCustname.VisibleIndex = 0
        '
        'colCustomerpo
        '
        Me.colCustomerpo.Caption = "Customer PO"
        Me.colCustomerpo.FieldName = "Customerpo"
        Me.colCustomerpo.Name = "colCustomerpo"
        Me.colCustomerpo.Visible = True
        Me.colCustomerpo.VisibleIndex = 1
        '
        'colWorkordernumber
        '
        Me.colWorkordernumber.Caption = "WorkOrder Number"
        Me.colWorkordernumber.FieldName = "Workordernumber"
        Me.colWorkordernumber.Name = "colWorkordernumber"
        Me.colWorkordernumber.Visible = True
        Me.colWorkordernumber.VisibleIndex = 2
        '
        'colOrderstatus
        '
        Me.colOrderstatus.Caption = "Order Status"
        Me.colOrderstatus.FieldName = "Orderstatus"
        Me.colOrderstatus.Name = "colOrderstatus"
        Me.colOrderstatus.Visible = True
        Me.colOrderstatus.VisibleIndex = 3
        '
        'colWorkorderdate
        '
        Me.colWorkorderdate.Caption = "WorkOrder Date"
        Me.colWorkorderdate.FieldName = "Workorderdate"
        Me.colWorkorderdate.Name = "colWorkorderdate"
        Me.colWorkorderdate.Visible = True
        Me.colWorkorderdate.VisibleIndex = 4
        '
        'colOrdertype
        '
        Me.colOrdertype.Caption = "Order Type"
        Me.colOrdertype.FieldName = "Ordertype"
        Me.colOrdertype.Name = "colOrdertype"
        Me.colOrdertype.Visible = True
        Me.colOrdertype.VisibleIndex = 5
        '
        'colInvoicenumber
        '
        Me.colInvoicenumber.Caption = "Invoice Number"
        Me.colInvoicenumber.FieldName = "Invoicenumber"
        Me.colInvoicenumber.Name = "colInvoicenumber"
        Me.colInvoicenumber.Visible = True
        Me.colInvoicenumber.VisibleIndex = 6
        '
        'colInvoicedate
        '
        Me.colInvoicedate.Caption = "Invoice Date"
        Me.colInvoicedate.FieldName = "Invoicedate"
        Me.colInvoicedate.Name = "colInvoicedate"
        Me.colInvoicedate.Visible = True
        Me.colInvoicedate.VisibleIndex = 7
        '
        'colInvcustpo
        '
        Me.colInvcustpo.Caption = "Invoice Cust PO"
        Me.colInvcustpo.FieldName = "Invcustpo"
        Me.colInvcustpo.Name = "colInvcustpo"
        Me.colInvcustpo.Visible = True
        Me.colInvcustpo.VisibleIndex = 8
        '
        'frmWorkOrdersToInvoice
        '
        Me.ClientSize = New System.Drawing.Size(1560, 727)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmWorkOrdersToInvoice"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Work Orders To Invoice"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.gcWorkOrdersToInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcWorkOrdersToInvoice.ResumeLayout(False)
        CType(Me.grSalespersonCustomerSalesData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWorkOrdersToInvoiceLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvWorkOrdersToInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpParameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpParameters.ResumeLayout(False)
        Me.grpParameters.PerformLayout()
        CType(Me.eEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpParameters As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eEndDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eStartDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents rbtnGetWorkOrders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnSalespersonCustomerDetailedData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents gcWorkOrdersToInvoice As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents grSalespersonCustomerSalesData As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvWorkOrdersToInvoice As CustomDevExGridView
    Friend WithEvents bsWorkOrdersToInvoiceLink As System.Windows.Forms.BindingSource
    Friend WithEvents rbtnExportWorkOrdersToInvoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnExportCustomerData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colCustname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerpo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrderstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkorderdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrdertype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicenumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvoicedate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvcustpo As DevExpress.XtraGrid.Columns.GridColumn
End Class
