<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditRelabelOrder

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditRelabelOrder))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsRelabelOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnChangeInventoryClass = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsRelabelOrderItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eWorkOrderNumber = New DevExpress.XtraEditors.TextEdit()
        Me.eStatus = New DevExpress.XtraEditors.TextEdit()
        Me.eProductID = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.eProdDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eQty = New DevExpress.XtraEditors.TextEdit()
        Me.NeededbyDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.RelabelorderdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.CustidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.RelabelordernumTextEdit = New DevExpress.XtraEditors.TextEdit()
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
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.grInvCreatedForRelabel = New DevExpress.XtraGrid.GridControl()
        Me.bsInvItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.grvInvCreatedForRelabel = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SourceDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn68 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.rpgWorkOrder = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rbtnEditWorkOrder = New DevExpress.XtraBars.BarButtonItem()
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
        CType(Me.bsRelabelOrderItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eWorkOrderNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProdDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeededbyDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NeededbyDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelabelorderdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelabelorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelabelordernumTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.grInvCreatedForRelabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvInvCreatedForRelabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        RelabelorderdateLabel.Location = New System.Drawing.Point(768, 37)
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
        Label5.Location = New System.Drawing.Point(125, 76)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 10
        Label5.Text = "Status"
        '
        'ProductWorkOrderLabel
        '
        ProductWorkOrderLabel.AutoSize = True
        ProductWorkOrderLabel.Location = New System.Drawing.Point(17, 76)
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
        Me.bsRelabelOrder.DataSource = GetType(AOS.BusinessObjects.Relabelorder)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnChangeInventoryClass, Me.rbtnEditWorkOrder})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 13
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(891, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'btnChangeInventoryClass
        '
        Me.btnChangeInventoryClass.Caption = "Change Inventory Class"
        Me.btnChangeInventoryClass.Enabled = False
        Me.btnChangeInventoryClass.Id = 11
        Me.btnChangeInventoryClass.LargeGlyph = CType(resources.GetObject("btnChangeInventoryClass.LargeGlyph"), System.Drawing.Image)
        Me.btnChangeInventoryClass.Name = "btnChangeInventoryClass"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup4, Me.rpgWorkOrder})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnChangeInventoryClass)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Pending Inventory"
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
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Me.eContainer)
        Me.GroupControl1.Controls.Add(Me.eProdDesc)
        Me.GroupControl1.Controls.Add(ProductqtyLabel)
        Me.GroupControl1.Controls.Add(Me.eQty)
        Me.GroupControl1.Controls.Add(NeededbyLabel)
        Me.GroupControl1.Controls.Add(Me.NeededbyDateEdit)
        Me.GroupControl1.Controls.Add(RelabelorderdateLabel)
        Me.GroupControl1.Controls.Add(Me.RelabelorderdateDateEdit)
        Me.GroupControl1.Controls.Add(CustidLabel)
        Me.GroupControl1.Controls.Add(Me.CustidLookUpEdit)
        Me.GroupControl1.Controls.Add(RelabelordernumLabel)
        Me.GroupControl1.Controls.Add(Me.RelabelordernumTextEdit)
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
        Me.eWorkOrderNumber.Location = New System.Drawing.Point(17, 92)
        Me.eWorkOrderNumber.MenuManager = Me.RibbonControl1
        Me.eWorkOrderNumber.Name = "eWorkOrderNumber"
        Me.eWorkOrderNumber.Properties.ReadOnly = True
        Me.eWorkOrderNumber.Size = New System.Drawing.Size(80, 20)
        Me.eWorkOrderNumber.TabIndex = 15
        '
        'eStatus
        '
        Me.eStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Relabelorderstatus", True))
        Me.eStatus.Location = New System.Drawing.Point(125, 92)
        Me.eStatus.MenuManager = Me.RibbonControl1
        Me.eStatus.Name = "eStatus"
        Me.eStatus.Properties.ReadOnly = True
        Me.eStatus.Size = New System.Drawing.Size(98, 20)
        Me.eStatus.TabIndex = 11
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Itemid", True))
        Me.eProductID.Location = New System.Drawing.Point(251, 53)
        Me.eProductID.MenuManager = Me.RibbonControl1
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ProdID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Units", "Units", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "Uom", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProductID.Properties.DataSource = Me.bsProducts
        Me.eProductID.Properties.DisplayMember = "Productid"
        Me.eProductID.Properties.NullText = ""
        Me.eProductID.Properties.PopupWidth = 375
        Me.eProductID.Properties.ReadOnly = True
        Me.eProductID.Properties.ValueMember = "Productid"
        Me.eProductID.Size = New System.Drawing.Size(57, 20)
        Me.eProductID.TabIndex = 3
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrderProductCollection)
        '
        'eContainer
        '
        Me.eContainer.Location = New System.Drawing.Point(642, 53)
        Me.eContainer.MenuManager = Me.RibbonControl1
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(99, 20)
        Me.eContainer.TabIndex = 7
        '
        'eProdDesc
        '
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
        'NeededbyDateEdit
        '
        Me.NeededbyDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Neededby", True))
        Me.NeededbyDateEdit.EditValue = Nothing
        Me.NeededbyDateEdit.Enabled = False
        Me.NeededbyDateEdit.Location = New System.Drawing.Point(642, 92)
        Me.NeededbyDateEdit.MenuManager = Me.RibbonControl1
        Me.NeededbyDateEdit.Name = "NeededbyDateEdit"
        Me.NeededbyDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.NeededbyDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.NeededbyDateEdit.Size = New System.Drawing.Size(99, 20)
        Me.NeededbyDateEdit.TabIndex = 21
        '
        'RelabelorderdateDateEdit
        '
        Me.RelabelorderdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Relabelorderdate", True))
        Me.RelabelorderdateDateEdit.EditValue = Nothing
        Me.RelabelorderdateDateEdit.Enabled = False
        Me.RelabelorderdateDateEdit.Location = New System.Drawing.Point(768, 53)
        Me.RelabelorderdateDateEdit.MenuManager = Me.RibbonControl1
        Me.RelabelorderdateDateEdit.Name = "RelabelorderdateDateEdit"
        Me.RelabelorderdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RelabelorderdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RelabelorderdateDateEdit.Size = New System.Drawing.Size(99, 20)
        Me.RelabelorderdateDateEdit.TabIndex = 9
        '
        'CustidLookUpEdit
        '
        Me.CustidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Custid", True))
        Me.CustidLookUpEdit.Location = New System.Drawing.Point(251, 92)
        Me.CustidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.CustidLookUpEdit.Name = "CustidLookUpEdit"
        Me.CustidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CustidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustidLookUpEdit.Properties.DataSource = Me.bsCustomers
        Me.CustidLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustidLookUpEdit.Properties.NullText = ""
        Me.CustidLookUpEdit.Properties.PopupWidth = 320
        Me.CustidLookUpEdit.Properties.ReadOnly = True
        Me.CustidLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustidLookUpEdit.Size = New System.Drawing.Size(363, 20)
        Me.CustidLookUpEdit.TabIndex = 19
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
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.PanelControl3)
        Me.PanelControl2.Controls.Add(Me.PanelControl4)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 224)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl2.Size = New System.Drawing.Size(891, 427)
        Me.PanelControl2.TabIndex = 2
        '
        'PanelControl3
        '
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(8, 8)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(875, 211)
        Me.PanelControl3.TabIndex = 2
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.grRelabelOrderItems)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(871, 207)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Items to be Relabeled"
        '
        'grRelabelOrderItems
        '
        Me.grRelabelOrderItems.DataSource = Me.bsRelabelOrderItems
        Me.grRelabelOrderItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grRelabelOrderItems.Location = New System.Drawing.Point(2, 22)
        Me.grRelabelOrderItems.MainView = Me.grvRelabelOrderItems
        Me.grRelabelOrderItems.Name = "grRelabelOrderItems"
        Me.grRelabelOrderItems.Size = New System.Drawing.Size(867, 183)
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
        Me.PanelControl4.Controls.Add(Me.GroupControl3)
        Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl4.Location = New System.Drawing.Point(8, 219)
        Me.PanelControl4.Name = "PanelControl4"
        Me.PanelControl4.Size = New System.Drawing.Size(875, 200)
        Me.PanelControl4.TabIndex = 2
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.grInvCreatedForRelabel)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(871, 196)
        Me.GroupControl3.TabIndex = 1
        Me.GroupControl3.Text = "Inventory Purchased for Relabel Order"
        '
        'grInvCreatedForRelabel
        '
        Me.grInvCreatedForRelabel.DataSource = Me.bsInvItems
        Me.grInvCreatedForRelabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grInvCreatedForRelabel.Location = New System.Drawing.Point(2, 22)
        Me.grInvCreatedForRelabel.LookAndFeel.SkinName = "Money Twins"
        Me.grInvCreatedForRelabel.MainView = Me.grvInvCreatedForRelabel
        Me.grInvCreatedForRelabel.Name = "grInvCreatedForRelabel"
        Me.grInvCreatedForRelabel.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1})
        Me.grInvCreatedForRelabel.Size = New System.Drawing.Size(867, 172)
        Me.grInvCreatedForRelabel.TabIndex = 6
        Me.grInvCreatedForRelabel.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvInvCreatedForRelabel})
        '
        'bsInvItems
        '
        Me.bsInvItems.DataSource = GetType(AOS.BusinessObjects.ViewInvItemListCollection)
        '
        'grvInvCreatedForRelabel
        '
        Me.grvInvCreatedForRelabel.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn58, Me.SourceDoc, Me.GridColumn59, Me.GridColumn60, Me.GridColumn61, Me.GridColumn62, Me.GridColumn63, Me.GridColumn64, Me.GridColumn65, Me.GridColumn66, Me.GridColumn67, Me.GridColumn68})
        Me.grvInvCreatedForRelabel.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grvInvCreatedForRelabel.GridControl = Me.grInvCreatedForRelabel
        Me.grvInvCreatedForRelabel.Name = "grvInvCreatedForRelabel"
        Me.grvInvCreatedForRelabel.OptionsBehavior.Editable = False
        Me.grvInvCreatedForRelabel.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grvInvCreatedForRelabel.OptionsView.ShowGroupPanel = False
        Me.grvInvCreatedForRelabel.OptionsView.ShowIndicator = False
        '
        'GridColumn58
        '
        Me.GridColumn58.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn58.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn58.Caption = "Inv Item #"
        Me.GridColumn58.FieldName = "Invitemnumber"
        Me.GridColumn58.Name = "GridColumn58"
        Me.GridColumn58.OptionsColumn.FixedWidth = True
        Me.GridColumn58.Visible = True
        Me.GridColumn58.VisibleIndex = 0
        Me.GridColumn58.Width = 68
        '
        'SourceDoc
        '
        Me.SourceDoc.Caption = "Src Doc"
        Me.SourceDoc.FieldName = "Sourcedocument"
        Me.SourceDoc.Name = "SourceDoc"
        Me.SourceDoc.OptionsColumn.FixedWidth = True
        Me.SourceDoc.Visible = True
        Me.SourceDoc.VisibleIndex = 1
        Me.SourceDoc.Width = 50
        '
        'GridColumn59
        '
        Me.GridColumn59.Caption = "Item Type"
        Me.GridColumn59.FieldName = "Itemtype"
        Me.GridColumn59.Name = "GridColumn59"
        Me.GridColumn59.OptionsColumn.FixedWidth = True
        Me.GridColumn59.Visible = True
        Me.GridColumn59.VisibleIndex = 2
        Me.GridColumn59.Width = 60
        '
        'GridColumn60
        '
        Me.GridColumn60.Caption = "Item ID"
        Me.GridColumn60.FieldName = "Itemid"
        Me.GridColumn60.Name = "GridColumn60"
        Me.GridColumn60.OptionsColumn.FixedWidth = True
        Me.GridColumn60.Visible = True
        Me.GridColumn60.VisibleIndex = 3
        Me.GridColumn60.Width = 50
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "Item Description"
        Me.GridColumn61.FieldName = "Itemdescription"
        Me.GridColumn61.Name = "GridColumn61"
        Me.GridColumn61.Visible = True
        Me.GridColumn61.VisibleIndex = 4
        Me.GridColumn61.Width = 181
        '
        'GridColumn62
        '
        Me.GridColumn62.Caption = "Container"
        Me.GridColumn62.FieldName = "Container"
        Me.GridColumn62.Name = "GridColumn62"
        Me.GridColumn62.OptionsColumn.FixedWidth = True
        Me.GridColumn62.Visible = True
        Me.GridColumn62.VisibleIndex = 5
        Me.GridColumn62.Width = 70
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "Item Status"
        Me.GridColumn63.FieldName = "Itemstatus"
        Me.GridColumn63.Name = "GridColumn63"
        Me.GridColumn63.OptionsColumn.FixedWidth = True
        Me.GridColumn63.Visible = True
        Me.GridColumn63.VisibleIndex = 6
        Me.GridColumn63.Width = 68
        '
        'GridColumn64
        '
        Me.GridColumn64.Caption = "Src Status"
        Me.GridColumn64.FieldName = "Sourcestatus"
        Me.GridColumn64.Name = "GridColumn64"
        Me.GridColumn64.OptionsColumn.FixedWidth = True
        Me.GridColumn64.Visible = True
        Me.GridColumn64.VisibleIndex = 7
        Me.GridColumn64.Width = 60
        '
        'GridColumn65
        '
        Me.GridColumn65.Caption = "Lot #"
        Me.GridColumn65.FieldName = "Lotnumber"
        Me.GridColumn65.Name = "GridColumn65"
        Me.GridColumn65.OptionsColumn.FixedWidth = True
        Me.GridColumn65.Visible = True
        Me.GridColumn65.VisibleIndex = 8
        Me.GridColumn65.Width = 65
        '
        'GridColumn66
        '
        Me.GridColumn66.Caption = "Vendor Lbl Wgt"
        Me.GridColumn66.FieldName = "Vendorweight"
        Me.GridColumn66.Name = "GridColumn66"
        Me.GridColumn66.OptionsColumn.FixedWidth = True
        Me.GridColumn66.Visible = True
        Me.GridColumn66.VisibleIndex = 9
        Me.GridColumn66.Width = 50
        '
        'GridColumn67
        '
        Me.GridColumn67.Caption = "Rec Weight"
        Me.GridColumn67.FieldName = "Rcvdweight"
        Me.GridColumn67.Name = "GridColumn67"
        Me.GridColumn67.OptionsColumn.FixedWidth = True
        Me.GridColumn67.Visible = True
        Me.GridColumn67.VisibleIndex = 10
        Me.GridColumn67.Width = 60
        '
        'GridColumn68
        '
        Me.GridColumn68.Caption = "Inv Class"
        Me.GridColumn68.FieldName = "LookupDesc"
        Me.GridColumn68.Name = "GridColumn68"
        Me.GridColumn68.OptionsColumn.FixedWidth = True
        Me.GridColumn68.Visible = True
        Me.GridColumn68.VisibleIndex = 11
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'rpgWorkOrder
        '
        Me.rpgWorkOrder.AllowMinimize = False
        Me.rpgWorkOrder.AllowTextClipping = False
        Me.rpgWorkOrder.ItemLinks.Add(Me.rbtnEditWorkOrder)
        Me.rpgWorkOrder.Name = "rpgWorkOrder"
        Me.rpgWorkOrder.ShowCaptionButton = False
        Me.rpgWorkOrder.Text = "Work Order"
        '
        'rbtnEditWorkOrder
        '
        Me.rbtnEditWorkOrder.Caption = "Edit Work Order"
        Me.rbtnEditWorkOrder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnEditWorkOrder.Id = 12
        Me.rbtnEditWorkOrder.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.rbtnEditWorkOrder.Name = "rbtnEditWorkOrder"
        '
        'frmAddEditRelabelOrder
        '
        Me.ClientSize = New System.Drawing.Size(891, 651)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditRelabelOrder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relabel Order Information"
        CType(Me.bsRelabelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRelabelOrderItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eWorkOrderNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProdDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeededbyDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NeededbyDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelabelorderdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelabelorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelabelordernumTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.grInvCreatedForRelabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvInvCreatedForRelabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsRelabelOrder As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsRelabelOrderItems As System.Windows.Forms.BindingSource
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents NeededbyDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents RelabelorderdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents CustidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents RelabelordernumTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProdDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents grRelabelOrderItems As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvRelabelOrderItems As CustomDevExGridView
    Friend WithEvents colMaterialid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents eProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eWorkOrderNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnChangeInventoryClass As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsInvItems As System.Windows.Forms.BindingSource
    Friend WithEvents grInvCreatedForRelabel As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvInvCreatedForRelabel As CustomDevExGridView
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SourceDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn67 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn68 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnEditWorkOrder As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgWorkOrder As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
