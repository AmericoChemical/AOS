<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProcessRelabelOrder

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
        Dim RelabelordernumLabel As System.Windows.Forms.Label
        Dim CustidLabel As System.Windows.Forms.Label
        Dim RelabelorderdateLabel As System.Windows.Forms.Label
        Dim NeededbyLabel As System.Windows.Forms.Label
        Dim ProductqtyLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim ProductWorkOrderLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessRelabelOrder))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsRelabelOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnProcessRelabelItem = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnPrintProductLabel = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsRelabelOrderItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eWorkOrderNumber = New DevExpress.XtraEditors.TextEdit()
        Me.eStatus = New DevExpress.XtraEditors.TextEdit()
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.eProdDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.RelabelordernumTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustidLookUpEdit = New DevExpress.XtraEditors.TextEdit()
        Me.NeededbyDateEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RelabelorderdateDateEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eProductID = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.grRelabelOrderItems = New DevExpress.XtraGrid.GridControl()
        Me.grvRelabelOrderItems = New AOS.CustomClasses.CustomDevExGridView()
        Me.colMaterialid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsRelabeledItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLotnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceiveddate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWorkordernum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOrigitemnum = New DevExpress.XtraGrid.Columns.GridColumn()
        RelabelordernumLabel = New System.Windows.Forms.Label()
        CustidLabel = New System.Windows.Forms.Label()
        RelabelorderdateLabel = New System.Windows.Forms.Label()
        NeededbyLabel = New System.Windows.Forms.Label()
        ProductqtyLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        ProductWorkOrderLabel = New System.Windows.Forms.Label()
        CType(Me.bsRelabelOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRelabelOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eWorkOrderNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProdDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelabelordernumTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeededbyDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelabelorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.grRelabelOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvRelabelOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl4.SuspendLayout()
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl5.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRelabeledItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RelabelordernumLabel
        '
        RelabelordernumLabel.AutoSize = True
        RelabelordernumLabel.Location = New System.Drawing.Point(17, 37)
        RelabelordernumLabel.Name = "RelabelordernumLabel"
        RelabelordernumLabel.Size = New System.Drawing.Size(71, 13)
        RelabelordernumLabel.TabIndex = 25
        RelabelordernumLabel.Text = "Relabel Ord#"
        '
        'CustidLabel
        '
        CustidLabel.AutoSize = True
        CustidLabel.Location = New System.Drawing.Point(251, 76)
        CustidLabel.Name = "CustidLabel"
        CustidLabel.Size = New System.Drawing.Size(53, 13)
        CustidLabel.TabIndex = 18
        CustidLabel.Text = "Customer"
        '
        'RelabelorderdateLabel
        '
        RelabelorderdateLabel.AutoSize = True
        RelabelorderdateLabel.Location = New System.Drawing.Point(17, 76)
        RelabelorderdateLabel.Name = "RelabelorderdateLabel"
        RelabelorderdateLabel.Size = New System.Drawing.Size(61, 13)
        RelabelorderdateLabel.TabIndex = 8
        RelabelorderdateLabel.Text = "Order Date"
        '
        'NeededbyLabel
        '
        NeededbyLabel.AutoSize = True
        NeededbyLabel.Location = New System.Drawing.Point(642, 76)
        NeededbyLabel.Name = "NeededbyLabel"
        NeededbyLabel.Size = New System.Drawing.Size(59, 13)
        NeededbyLabel.TabIndex = 20
        NeededbyLabel.Text = "Needed by"
        '
        'ProductqtyLabel
        '
        ProductqtyLabel.AutoSize = True
        ProductqtyLabel.Location = New System.Drawing.Point(128, 37)
        ProductqtyLabel.Name = "ProductqtyLabel"
        ProductqtyLabel.Size = New System.Drawing.Size(25, 13)
        ProductqtyLabel.TabIndex = 0
        ProductqtyLabel.Text = "Qty"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(642, 37)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 13)
        Label2.TabIndex = 6
        Label2.Text = "Container"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(251, 37)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(46, 13)
        Label3.TabIndex = 2
        Label3.Text = "Item ID "
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(336, 37)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(85, 13)
        Label4.TabIndex = 4
        Label4.Text = "Item Description"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(769, 37)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 10
        Label5.Text = "Status"
        '
        'ProductWorkOrderLabel
        '
        ProductWorkOrderLabel.AutoSize = True
        ProductWorkOrderLabel.Location = New System.Drawing.Point(128, 76)
        ProductWorkOrderLabel.Name = "ProductWorkOrderLabel"
        ProductWorkOrderLabel.Size = New System.Drawing.Size(71, 13)
        ProductWorkOrderLabel.TabIndex = 14
        ProductWorkOrderLabel.Text = "Work Order#"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsRelabelOrder
        '
        Me.bsRelabelOrder.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrder)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnClose, Me.rbtnProcessRelabelItem, Me.rbtnPrintProductLabel})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 14
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(891, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 5
        Me.btnClose.LargeImageIndex = 15
        Me.btnClose.Name = "btnClose"
        '
        'rbtnProcessRelabelItem
        '
        Me.rbtnProcessRelabelItem.Caption = "Process Item"
        Me.rbtnProcessRelabelItem.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnProcessRelabelItem.Id = 12
        Me.rbtnProcessRelabelItem.LargeImageIndex = 23
        Me.rbtnProcessRelabelItem.LargeWidth = 60
        Me.rbtnProcessRelabelItem.Name = "rbtnProcessRelabelItem"
        '
        'rbtnPrintProductLabel
        '
        Me.rbtnPrintProductLabel.Caption = "Print Product Label"
        Me.rbtnPrintProductLabel.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnPrintProductLabel.Id = 13
        Me.rbtnPrintProductLabel.LargeImageIndex = 8
        Me.rbtnPrintProductLabel.Name = "rbtnPrintProductLabel"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Relabel Order"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnProcessRelabelItem, True)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnPrintProductLabel, True)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Relabel Items"
        '
        'bsRelabelOrderItems
        '
        Me.bsRelabelOrderItems.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrderItemCollection)
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(891, 129)
        Me.PanelControl1.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(ProductWorkOrderLabel)
        Me.GroupControl1.Controls.Add(Me.eWorkOrderNumber)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Me.eStatus)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Me.eContainer)
        Me.GroupControl1.Controls.Add(Me.eProdDesc)
        Me.GroupControl1.Controls.Add(ProductqtyLabel)
        Me.GroupControl1.Controls.Add(Me.eQty)
        Me.GroupControl1.Controls.Add(NeededbyLabel)
        Me.GroupControl1.Controls.Add(RelabelorderdateLabel)
        Me.GroupControl1.Controls.Add(CustidLabel)
        Me.GroupControl1.Controls.Add(RelabelordernumLabel)
        Me.GroupControl1.Controls.Add(Me.RelabelordernumTextEdit)
        Me.GroupControl1.Controls.Add(Me.CustidLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.NeededbyDateEdit)
        Me.GroupControl1.Controls.Add(Me.RelabelorderdateDateEdit)
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(887, 125)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Relabel Order Information"
        '
        'eWorkOrderNumber
        '
        Me.eWorkOrderNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Workordernumber", True))
        Me.eWorkOrderNumber.Location = New System.Drawing.Point(125, 92)
        Me.eWorkOrderNumber.MenuManager = Me.RibbonControl1
        Me.eWorkOrderNumber.Name = "eWorkOrderNumber"
        Me.eWorkOrderNumber.Properties.ReadOnly = True
        Me.eWorkOrderNumber.Size = New System.Drawing.Size(80, 20)
        Me.eWorkOrderNumber.TabIndex = 15
        '
        'eStatus
        '
        Me.eStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Relabelorderstatus", True))
        Me.eStatus.Location = New System.Drawing.Point(769, 53)
        Me.eStatus.MenuManager = Me.RibbonControl1
        Me.eStatus.Name = "eStatus"
        Me.eStatus.Properties.ReadOnly = True
        Me.eStatus.Size = New System.Drawing.Size(98, 20)
        Me.eStatus.TabIndex = 11
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(642, 53)
        Me.eContainer.MenuManager = Me.RibbonControl1
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(99, 20)
        Me.eContainer.TabIndex = 7
        '
        'eProdDesc
        '
        Me.eProdDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Itemdesc", True))
        Me.eProdDesc.Location = New System.Drawing.Point(336, 53)
        Me.eProdDesc.MenuManager = Me.RibbonControl1
        Me.eProdDesc.Name = "eProdDesc"
        Me.eProdDesc.Properties.ReadOnly = True
        Me.eProdDesc.Size = New System.Drawing.Size(277, 20)
        Me.eProdDesc.TabIndex = 5
        '
        'eQty
        '
        Me.eQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Qty", True))
        Me.eQty.Location = New System.Drawing.Point(125, 53)
        Me.eQty.MenuManager = Me.RibbonControl1
        Me.eQty.Name = "eQty"
        Me.eQty.Properties.Mask.EditMask = "d"
        Me.eQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eQty.Properties.ReadOnly = True
        Me.eQty.Size = New System.Drawing.Size(98, 20)
        Me.eQty.TabIndex = 1
        '
        'RelabelordernumTextEdit
        '
        Me.RelabelordernumTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Relabelordernumber", True))
        Me.RelabelordernumTextEdit.Location = New System.Drawing.Point(17, 53)
        Me.RelabelordernumTextEdit.MenuManager = Me.RibbonControl1
        Me.RelabelordernumTextEdit.Name = "RelabelordernumTextEdit"
        Me.RelabelordernumTextEdit.Properties.ReadOnly = True
        Me.RelabelordernumTextEdit.Size = New System.Drawing.Size(80, 20)
        Me.RelabelordernumTextEdit.TabIndex = 25
        Me.RelabelordernumTextEdit.TabStop = False
        '
        'CustidLookUpEdit
        '
        Me.CustidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Custname", True))
        Me.CustidLookUpEdit.Location = New System.Drawing.Point(251, 92)
        Me.CustidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.CustidLookUpEdit.Name = "CustidLookUpEdit"
        Me.CustidLookUpEdit.Properties.ReadOnly = True
        Me.CustidLookUpEdit.Size = New System.Drawing.Size(363, 20)
        Me.CustidLookUpEdit.TabIndex = 19
        '
        'NeededbyDateEdit
        '
        Me.NeededbyDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Neededby", True))
        Me.NeededbyDateEdit.Location = New System.Drawing.Point(642, 92)
        Me.NeededbyDateEdit.MenuManager = Me.RibbonControl1
        Me.NeededbyDateEdit.Name = "NeededbyDateEdit"
        Me.NeededbyDateEdit.Properties.DisplayFormat.FormatString = "d"
        Me.NeededbyDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.NeededbyDateEdit.Properties.Mask.EditMask = "d"
        Me.NeededbyDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.NeededbyDateEdit.Properties.ReadOnly = True
        Me.NeededbyDateEdit.Size = New System.Drawing.Size(99, 20)
        Me.NeededbyDateEdit.TabIndex = 21
        '
        'RelabelorderdateDateEdit
        '
        Me.RelabelorderdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Relabelorderdate", True))
        Me.RelabelorderdateDateEdit.Location = New System.Drawing.Point(17, 92)
        Me.RelabelorderdateDateEdit.MenuManager = Me.RibbonControl1
        Me.RelabelorderdateDateEdit.Name = "RelabelorderdateDateEdit"
        Me.RelabelorderdateDateEdit.Properties.DisplayFormat.FormatString = "d"
        Me.RelabelorderdateDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RelabelorderdateDateEdit.Properties.Mask.EditMask = "d"
        Me.RelabelorderdateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
        Me.RelabelorderdateDateEdit.Properties.ReadOnly = True
        Me.RelabelorderdateDateEdit.Size = New System.Drawing.Size(80, 20)
        Me.RelabelorderdateDateEdit.TabIndex = 9
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Itemid", True))
        Me.eProductID.Location = New System.Drawing.Point(251, 53)
        Me.eProductID.MenuManager = Me.RibbonControl1
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.ReadOnly = True
        Me.eProductID.Size = New System.Drawing.Size(57, 20)
        Me.eProductID.TabIndex = 3
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl3)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 224)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl2.Size = New System.Drawing.Size(891, 161)
        Me.PanelControl2.TabIndex = 2
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(8, 8)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(875, 145)
        Me.PanelControl3.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grRelabelOrderItems)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(871, 141)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Relabel Order Items "
        '
        'grRelabelOrderItems
        '
        Me.grRelabelOrderItems.DataSource = Me.bsRelabelOrderItems
        Me.grRelabelOrderItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grRelabelOrderItems.Location = New System.Drawing.Point(2, 22)
        Me.grRelabelOrderItems.MainView = Me.grvRelabelOrderItems
        Me.grRelabelOrderItems.Name = "grRelabelOrderItems"
        Me.grRelabelOrderItems.Size = New System.Drawing.Size(867, 117)
        Me.grRelabelOrderItems.TabIndex = 6
        Me.grRelabelOrderItems.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvRelabelOrderItems})
        '
        'grvRelabelOrderItems
        '
        Me.grvRelabelOrderItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaterialid, Me.colMaterialdesc, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8})
        Me.grvRelabelOrderItems.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvRelabelOrderItems.GridControl = Me.grRelabelOrderItems
        Me.grvRelabelOrderItems.Name = "grvRelabelOrderItems"
        Me.grvRelabelOrderItems.OptionsBehavior.Editable = False
        Me.grvRelabelOrderItems.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvRelabelOrderItems.OptionsView.ShowGroupPanel = False
        Me.grvRelabelOrderItems.OptionsView.ShowIndicator = False
        '
        'colMaterialid
        '
        Me.colMaterialid.Caption = "Item ID"
        Me.colMaterialid.FieldName = "Itemid"
        Me.colMaterialid.Name = "colMaterialid"
        Me.colMaterialid.OptionsColumn.FixedWidth = True
        Me.colMaterialid.Visible = True
        Me.colMaterialid.VisibleIndex = 0
        Me.colMaterialid.Width = 50
        '
        'colMaterialdesc
        '
        Me.colMaterialdesc.Caption = "Item Description"
        Me.colMaterialdesc.FieldName = "Itemdesc"
        Me.colMaterialdesc.Name = "colMaterialdesc"
        Me.colMaterialdesc.Visible = True
        Me.colMaterialdesc.VisibleIndex = 1
        Me.colMaterialdesc.Width = 424
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Container"
        Me.GridColumn3.FieldName = "Container"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 80
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Inv Item #"
        Me.GridColumn4.FieldName = "Invitemnum"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 68
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "WO Item #"
        Me.GridColumn5.FieldName = "Workorderitemnumber"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.FixedWidth = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 65
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Src Type"
        Me.GridColumn6.FieldName = "Sourcetype"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 5
        Me.GridColumn6.Width = 55
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Src Doc"
        Me.GridColumn7.FieldName = "Sourcedoc"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.FixedWidth = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 50
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Status"
        Me.GridColumn8.FieldName = "Relabelorderitemstatus"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.FixedWidth = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 7
        Me.GridColumn8.Width = 80
        '
        'PanelControl4
        '
        Me.PanelControl4.Controls.Add(Me.PanelControl5)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl4.Location = New System.Drawing.Point(0, 385)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl4.Size = New System.Drawing.Size(891, 193)
        Me.PanelControl4.TabIndex = 4
        '
        'PanelControl5
        '
        Me.PanelControl5.Controls.Add(Me.GroupControl3)
        Me.PanelControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl5.Location = New System.Drawing.Point(8, 8)
        Me.PanelControl5.Name = "PanelControl5"
        Me.PanelControl5.Size = New System.Drawing.Size(875, 177)
        Me.PanelControl5.TabIndex = 2
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(871, 173)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Inventory Items Created from Relabeled Items"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsRelabeledItems
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(867, 149)
        Me.GridControl1.TabIndex = 6
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsRelabeledItems
        '
        Me.bsRelabeledItems.DataSource = GetType(AOS.BusinessObjects.ViewInvItemsFromRelabeledItemsCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber, Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colLotnumber, Me.colReceiveddate, Me.colWorkordernum, Me.colOrigitemnum})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Item#"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 0
        Me.colInvitemnumber.Width = 49
        '
        'colProductid
        '
        Me.colProductid.Caption = "Item ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 1
        Me.colProductid.Width = 54
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Item Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 2
        Me.colProductdesc.Width = 365
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 81
        '
        'colLotnumber
        '
        Me.colLotnumber.Caption = "Lot Number"
        Me.colLotnumber.FieldName = "Lotnumber"
        Me.colLotnumber.Name = "colLotnumber"
        Me.colLotnumber.Visible = True
        Me.colLotnumber.VisibleIndex = 4
        Me.colLotnumber.Width = 119
        '
        'colReceiveddate
        '
        Me.colReceiveddate.Caption = "Received"
        Me.colReceiveddate.FieldName = "Receiveddate"
        Me.colReceiveddate.Name = "colReceiveddate"
        Me.colReceiveddate.Visible = True
        Me.colReceiveddate.VisibleIndex = 5
        Me.colReceiveddate.Width = 69
        '
        'colWorkordernum
        '
        Me.colWorkordernum.Caption = "WO #"
        Me.colWorkordernum.FieldName = "Workordernum"
        Me.colWorkordernum.Name = "colWorkordernum"
        Me.colWorkordernum.Visible = True
        Me.colWorkordernum.VisibleIndex = 6
        Me.colWorkordernum.Width = 52
        '
        'colOrigitemnum
        '
        Me.colOrigitemnum.Caption = "Original #"
        Me.colOrigitemnum.FieldName = "Origitemnum"
        Me.colOrigitemnum.Name = "colOrigitemnum"
        Me.colOrigitemnum.Visible = True
        Me.colOrigitemnum.VisibleIndex = 7
        Me.colOrigitemnum.Width = 78
        '
        'frmProcessRelabelOrder
        '
        Me.ClientSize = New System.Drawing.Size(891, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl4)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProcessRelabelOrder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Process Relabel Order"
        CType(Me.bsRelabelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRelabelOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eWorkOrderNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProdDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelabelordernumTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeededbyDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelabelorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.grRelabelOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvRelabelOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl4.ResumeLayout(False)
        CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl5.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRelabeledItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsRelabelOrder As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsRelabelOrderItems As System.Windows.Forms.BindingSource
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RelabelordernumTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProdDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grRelabelOrderItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvRelabelOrderItems As CustomDevExGridView
    Friend WithEvents colMaterialid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents eStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eWorkOrderNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnProcessRelabelItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents CustidLookUpEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NeededbyDateEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RelabelorderdateDateEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents bsRelabeledItems As System.Windows.Forms.BindingSource
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLotnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceiveddate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWorkordernum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOrigitemnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnPrintProductLabel As DevExpress.XtraBars.BarButtonItem
End Class
