<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProductionOrderMaterialUsage

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
        Dim Label5 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim ProductqtyLabel As System.Windows.Forms.Label
        Dim ProdordernumLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductionOrderMaterialUsage))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAddMaterialTransaction = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnReverseMaterialTransaction = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsInvTx = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eQtyNeeded = New DevExpress.XtraEditors.TextEdit()
        Me.eMaterialUOM = New DevExpress.XtraEditors.TextEdit()
        Me.bsProdMaterialInfo = New System.Windows.Forms.BindingSource(Me.components)
        Me.eProductQty = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.eStatus = New DevExpress.XtraEditors.TextEdit()
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.eProductDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eMaterialQty = New DevExpress.XtraEditors.TextEdit()
        Me.eProdOrderNum = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eMaterialDescription = New DevExpress.XtraEditors.TextEdit()
        Me.eMaterialID = New DevExpress.XtraEditors.TextEdit()
        Me.eProductID = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsInProcessItems = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvitemnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsremaining = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProditemnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdordernum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMaterialid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colApisnum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUom = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIscomplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.CustomDevExGridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colTxid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxwho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxdocid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsused = New DevExpress.XtraGrid.Columns.GridColumn()
        Label5 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        ProductqtyLabel = New System.Windows.Forms.Label()
        ProdordernumLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvTx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eQtyNeeded.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMaterialUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProdMaterialInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMaterialQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProdOrderNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMaterialDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMaterialID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInProcessItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(587, 26)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(38, 13)
        Label5.TabIndex = 36
        Label5.Text = "Status"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(203, 26)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(100, 13)
        Label4.TabIndex = 30
        Label4.Text = "Product Description"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(130, 26)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 13)
        Label3.TabIndex = 28
        Label3.Text = "Prod ID"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(482, 26)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 13)
        Label2.TabIndex = 32
        Label2.Text = "Container"
        '
        'ProductqtyLabel
        '
        ProductqtyLabel.AutoSize = True
        ProductqtyLabel.Location = New System.Drawing.Point(482, 75)
        ProductqtyLabel.Name = "ProductqtyLabel"
        ProductqtyLabel.Size = New System.Drawing.Size(68, 13)
        ProductqtyLabel.TabIndex = 26
        ProductqtyLabel.Text = "Qty Ordered"
        '
        'ProdordernumLabel
        '
        ProdordernumLabel.AutoSize = True
        ProdordernumLabel.Location = New System.Drawing.Point(8, 26)
        ProdordernumLabel.Name = "ProdordernumLabel"
        ProdordernumLabel.Size = New System.Drawing.Size(58, 13)
        ProdordernumLabel.TabIndex = 50
        ProdordernumLabel.Text = "Prod Ord#"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(85, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(25, 13)
        Label1.TabIndex = 53
        Label1.Text = "Qty"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(434, 75)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(30, 13)
        Label6.TabIndex = 55
        Label6.Text = "UOM"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(587, 75)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(65, 13)
        Label7.TabIndex = 57
        Label7.Text = "Qty Needed"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnClose, Me.rbtnAddMaterialTransaction, Me.rbtnReverseMaterialTransaction})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 8
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(702, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 5
        Me.btnClose.LargeImageIndex = 20
        Me.btnClose.Name = "btnClose"
        '
        'rbtnAddMaterialTransaction
        '
        Me.rbtnAddMaterialTransaction.Caption = "Add New Material Transaction"
        Me.rbtnAddMaterialTransaction.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnAddMaterialTransaction.Id = 6
        Me.rbtnAddMaterialTransaction.LargeImageIndex = 2
        Me.rbtnAddMaterialTransaction.Name = "rbtnAddMaterialTransaction"
        '
        'rbtnReverseMaterialTransaction
        '
        Me.rbtnReverseMaterialTransaction.Caption = "Reverse Material Transaction"
        Me.rbtnReverseMaterialTransaction.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnReverseMaterialTransaction.Id = 7
        Me.rbtnReverseMaterialTransaction.LargeImageIndex = 4
        Me.rbtnReverseMaterialTransaction.Name = "rbtnReverseMaterialTransaction"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
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
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnAddMaterialTransaction)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnReverseMaterialTransaction)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Transactions"
        '
        'bsInvTx
        '
        Me.bsInvTx.DataSource = GetType(AOS.BusinessObjects.InvtxCollection)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label7)
        Me.GroupControl1.Controls.Add(Me.eQtyNeeded)
        Me.GroupControl1.Controls.Add(Label6)
        Me.GroupControl1.Controls.Add(Me.eMaterialUOM)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.eProductQty)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Me.eStatus)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Me.eContainer)
        Me.GroupControl1.Controls.Add(Me.eProductDesc)
        Me.GroupControl1.Controls.Add(ProductqtyLabel)
        Me.GroupControl1.Controls.Add(Me.eMaterialQty)
        Me.GroupControl1.Controls.Add(ProdordernumLabel)
        Me.GroupControl1.Controls.Add(Me.eProdOrderNum)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.eMaterialDescription)
        Me.GroupControl1.Controls.Add(Me.eMaterialID)
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(702, 125)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Production Order && Material Information"
        '
        'eQtyNeeded
        '
        Me.eQtyNeeded.Location = New System.Drawing.Point(590, 91)
        Me.eQtyNeeded.MenuManager = Me.RibbonControl1
        Me.eQtyNeeded.Name = "eQtyNeeded"
        Me.eQtyNeeded.Properties.ReadOnly = True
        Me.eQtyNeeded.Size = New System.Drawing.Size(99, 20)
        Me.eQtyNeeded.TabIndex = 58
        '
        'eMaterialUOM
        '
        Me.eMaterialUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Uom", True))
        Me.eMaterialUOM.Location = New System.Drawing.Point(437, 91)
        Me.eMaterialUOM.MenuManager = Me.RibbonControl1
        Me.eMaterialUOM.Name = "eMaterialUOM"
        Me.eMaterialUOM.Properties.Mask.EditMask = "d"
        Me.eMaterialUOM.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eMaterialUOM.Properties.ReadOnly = True
        Me.eMaterialUOM.Size = New System.Drawing.Size(42, 20)
        Me.eMaterialUOM.TabIndex = 56
        '
        'bsProdMaterialInfo
        '
        Me.bsProdMaterialInfo.DataSource = GetType(AOS.BusinessObjects.ViewMaterialUsageProdOrderInfo)
        '
        'eProductQty
        '
        Me.eProductQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Productqty", True))
        Me.eProductQty.Location = New System.Drawing.Point(85, 42)
        Me.eProductQty.MenuManager = Me.RibbonControl1
        Me.eProductQty.Name = "eProductQty"
        Me.eProductQty.Properties.Mask.EditMask = "d"
        Me.eProductQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eProductQty.Properties.ReadOnly = True
        Me.eProductQty.Size = New System.Drawing.Size(42, 20)
        Me.eProductQty.TabIndex = 54
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(206, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl2.TabIndex = 52
        Me.LabelControl2.Text = "Material Description"
        '
        'eStatus
        '
        Me.eStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Orderstatus", True))
        Me.eStatus.Location = New System.Drawing.Point(590, 42)
        Me.eStatus.MenuManager = Me.RibbonControl1
        Me.eStatus.Name = "eStatus"
        Me.eStatus.Properties.ReadOnly = True
        Me.eStatus.Size = New System.Drawing.Size(99, 20)
        Me.eStatus.TabIndex = 37
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(485, 42)
        Me.eContainer.MenuManager = Me.RibbonControl1
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(99, 20)
        Me.eContainer.TabIndex = 33
        '
        'eProductDesc
        '
        Me.eProductDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Productdesc", True))
        Me.eProductDesc.Location = New System.Drawing.Point(206, 42)
        Me.eProductDesc.MenuManager = Me.RibbonControl1
        Me.eProductDesc.Name = "eProductDesc"
        Me.eProductDesc.Properties.ReadOnly = True
        Me.eProductDesc.Size = New System.Drawing.Size(273, 20)
        Me.eProductDesc.TabIndex = 31
        '
        'eMaterialQty
        '
        Me.eMaterialQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Qty", True))
        Me.eMaterialQty.Location = New System.Drawing.Point(485, 91)
        Me.eMaterialQty.MenuManager = Me.RibbonControl1
        Me.eMaterialQty.Name = "eMaterialQty"
        Me.eMaterialQty.Properties.Mask.EditMask = "d"
        Me.eMaterialQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eMaterialQty.Properties.ReadOnly = True
        Me.eMaterialQty.Size = New System.Drawing.Size(99, 20)
        Me.eMaterialQty.TabIndex = 27
        '
        'eProdOrderNum
        '
        Me.eProdOrderNum.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Prodordernum", True))
        Me.eProdOrderNum.Location = New System.Drawing.Point(8, 42)
        Me.eProdOrderNum.MenuManager = Me.RibbonControl1
        Me.eProdOrderNum.Name = "eProdOrderNum"
        Me.eProdOrderNum.Properties.ReadOnly = True
        Me.eProdOrderNum.Size = New System.Drawing.Size(71, 20)
        Me.eProdOrderNum.TabIndex = 51
        Me.eProdOrderNum.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(131, 75)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Material ID"
        '
        'eMaterialDescription
        '
        Me.eMaterialDescription.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Materialdesc", True))
        Me.eMaterialDescription.Location = New System.Drawing.Point(206, 91)
        Me.eMaterialDescription.MenuManager = Me.RibbonControl1
        Me.eMaterialDescription.Name = "eMaterialDescription"
        Me.eMaterialDescription.Properties.ReadOnly = True
        Me.eMaterialDescription.Size = New System.Drawing.Size(225, 20)
        Me.eMaterialDescription.TabIndex = 1
        '
        'eMaterialID
        '
        Me.eMaterialID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Materialid", True))
        Me.eMaterialID.Location = New System.Drawing.Point(133, 91)
        Me.eMaterialID.MenuManager = Me.RibbonControl1
        Me.eMaterialID.Name = "eMaterialID"
        Me.eMaterialID.Properties.ReadOnly = True
        Me.eMaterialID.Size = New System.Drawing.Size(67, 20)
        Me.eMaterialID.TabIndex = 0
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProdMaterialInfo, "Productid", True))
        Me.eProductID.Location = New System.Drawing.Point(133, 42)
        Me.eProductID.MenuManager = Me.RibbonControl1
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.ReadOnly = True
        Me.eProductID.Size = New System.Drawing.Size(67, 20)
        Me.eProductID.TabIndex = 29
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 220)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(702, 233)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Inventory Items In Process (Raw Material)"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsInProcessItems
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(698, 209)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsInProcessItems
        '
        Me.bsInProcessItems.DataSource = GetType(AOS.BusinessObjects.ViewMaterialUsageInventoryItemsCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber1, Me.colProductid, Me.colProductdesc, Me.colContainer, Me.colUnitsremaining, Me.colProditemnum, Me.colProdordernum, Me.colMaterialid, Me.colApisnum, Me.colUom, Me.colQty, Me.colIscomplete})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colInvitemnumber1
        '
        Me.colInvitemnumber1.Caption = "Item ID"
        Me.colInvitemnumber1.FieldName = "Invitemnumber"
        Me.colInvitemnumber1.Name = "colInvitemnumber1"
        Me.colInvitemnumber1.Visible = True
        Me.colInvitemnumber1.VisibleIndex = 0
        Me.colInvitemnumber1.Width = 83
        '
        'colProductid
        '
        Me.colProductid.Caption = "Prod ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 1
        Me.colProductid.Width = 76
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Description"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 2
        Me.colProductdesc.Width = 353
        '
        'colContainer
        '
        Me.colContainer.FieldName = "Container"
        Me.colContainer.Name = "colContainer"
        Me.colContainer.Visible = True
        Me.colContainer.VisibleIndex = 3
        Me.colContainer.Width = 96
        '
        'colUnitsremaining
        '
        Me.colUnitsremaining.Caption = "Remaining"
        Me.colUnitsremaining.FieldName = "Unitsremaining"
        Me.colUnitsremaining.Name = "colUnitsremaining"
        Me.colUnitsremaining.Visible = True
        Me.colUnitsremaining.VisibleIndex = 4
        Me.colUnitsremaining.Width = 90
        '
        'colProditemnum
        '
        Me.colProditemnum.FieldName = "Proditemnum"
        Me.colProditemnum.Name = "colProditemnum"
        '
        'colProdordernum
        '
        Me.colProdordernum.FieldName = "Prodordernum"
        Me.colProdordernum.Name = "colProdordernum"
        '
        'colMaterialid
        '
        Me.colMaterialid.FieldName = "Materialid"
        Me.colMaterialid.Name = "colMaterialid"
        '
        'colApisnum
        '
        Me.colApisnum.FieldName = "Apisnum"
        Me.colApisnum.Name = "colApisnum"
        '
        'colUom
        '
        Me.colUom.FieldName = "Uom"
        Me.colUom.Name = "colUom"
        '
        'colQty
        '
        Me.colQty.FieldName = "Qty"
        Me.colQty.Name = "colQty"
        '
        'colIscomplete
        '
        Me.colIscomplete.FieldName = "Iscomplete"
        Me.colIscomplete.Name = "colIscomplete"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl2)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl3.Location = New System.Drawing.Point(0, 453)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(702, 199)
        Me.GroupControl3.TabIndex = 4
        Me.GroupControl3.Text = "Material Usage Transactions"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsInvTx
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 22)
        Me.GridControl2.MainView = Me.CustomDevExGridView1
        Me.GridControl2.MenuManager = Me.RibbonControl1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(698, 175)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CustomDevExGridView1})
        '
        'CustomDevExGridView1
        '
        Me.CustomDevExGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTxid, Me.colTxtime, Me.colTxwho, Me.colTxtype, Me.colTxdocid, Me.colInvitemnumber, Me.colUnitsused})
        Me.CustomDevExGridView1.GridControl = Me.GridControl2
        Me.CustomDevExGridView1.Name = "CustomDevExGridView1"
        Me.CustomDevExGridView1.OptionsBehavior.Editable = False
        Me.CustomDevExGridView1.OptionsView.ShowAutoFilterRow = True
        Me.CustomDevExGridView1.OptionsView.ShowGroupPanel = False
        Me.CustomDevExGridView1.OptionsView.ShowIndicator = False
        '
        'colTxid
        '
        Me.colTxid.FieldName = "Txid"
        Me.colTxid.Name = "colTxid"
        '
        'colTxtime
        '
        Me.colTxtime.Caption = "TX Time"
        Me.colTxtime.DisplayFormat.FormatString = "g"
        Me.colTxtime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTxtime.FieldName = "Txtime"
        Me.colTxtime.Name = "colTxtime"
        Me.colTxtime.Visible = True
        Me.colTxtime.VisibleIndex = 0
        '
        'colTxwho
        '
        Me.colTxwho.Caption = "Who Did Work"
        Me.colTxwho.FieldName = "Txwho"
        Me.colTxwho.Name = "colTxwho"
        Me.colTxwho.Visible = True
        Me.colTxwho.VisibleIndex = 1
        '
        'colTxtype
        '
        Me.colTxtype.FieldName = "Txtype"
        Me.colTxtype.Name = "colTxtype"
        '
        'colTxdocid
        '
        Me.colTxdocid.FieldName = "Txdocid"
        Me.colTxdocid.Name = "colTxdocid"
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Inv Item ID"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 2
        '
        'colUnitsused
        '
        Me.colUnitsused.Caption = "Units Used"
        Me.colUnitsused.FieldName = "Unitsused"
        Me.colUnitsused.Name = "colUnitsused"
        Me.colUnitsused.Visible = True
        Me.colUnitsused.VisibleIndex = 3
        '
        'frmProductionOrderMaterialUsage
        '
        Me.ClientSize = New System.Drawing.Size(702, 652)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProductionOrderMaterialUsage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Production Order Material Usage"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvTx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eQtyNeeded.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMaterialUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProdMaterialInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMaterialQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProdOrderNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMaterialDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMaterialID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInProcessItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsInvTx As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eMaterialDescription As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsProdMaterialInfo As System.Windows.Forms.BindingSource
    Friend WithEvents eMaterialID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend CustomDevExGridView1 As CustomDevExGridView
    Friend WithEvents eStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eMaterialQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProdOrderNum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eMaterialUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eQtyNeeded As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colTxid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxtime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxwho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxdocid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsused As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnAddMaterialTransaction As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnReverseMaterialTransaction As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsInProcessItems As BindingSource
    Friend WithEvents colInvitemnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsremaining As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProditemnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdordernum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMaterialid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colApisnum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUom As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIscomplete As DevExpress.XtraGrid.Columns.GridColumn
End Class
