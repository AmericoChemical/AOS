<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditItemDetails

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
        Dim InvitemnumberLabel As System.Windows.Forms.Label
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim ProductdescLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim ClassdescLabel As System.Windows.Forms.Label
        Dim ItemstatusLabel As System.Windows.Forms.Label
        Dim UnitsremainingLabel As System.Windows.Forms.Label
        Dim PonumberLabel As System.Windows.Forms.Label
        Dim PodateLabel As System.Windows.Forms.Label
        Dim ChangeableponumberLabel As System.Windows.Forms.Label
        Dim AllocateddocumentLabel As System.Windows.Forms.Label
        Dim AllocateddateLabel As System.Windows.Forms.Label
        Dim WorkordernumberLabel As System.Windows.Forms.Label
        Dim WorkordercustomerLabel As System.Windows.Forms.Label
        Dim WarehouselocationLabel As System.Windows.Forms.Label
        Dim WarehousenumberLabel As System.Windows.Forms.Label
        Dim ShipmentnumberLabel As System.Windows.Forms.Label
        Dim ShippeddateLabel As System.Windows.Forms.Label
        Dim ShipmentdateLabel As System.Windows.Forms.Label
        Dim ShiptocustomerLabel As System.Windows.Forms.Label
        Dim VendornameLabel As System.Windows.Forms.Label
        Dim ReceivernumberLabel As System.Windows.Forms.Label
        Dim ReceiverdocumenttypeLabel As System.Windows.Forms.Label
        Dim ReceiverdocumentLabel As System.Windows.Forms.Label
        Dim ReceiveddateLabel As System.Windows.Forms.Label
        Dim LotnumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditItemDetails))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnReturn = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkShipped = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkAvailable = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkQuarantine = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkDepleted = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnConvertFGtoRM = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnConvertRMtoFG = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnUpdateLotNumber = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMarkInProcess = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnChangeItemStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnConvertItemClass = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LotnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WarehousenumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WarehouselocationTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitsremainingTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContainerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ItemstatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProductdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ClassdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProductidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.InvitemnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.VendornameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ChangeableponumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PodateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PonumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.WorkordercustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkordernumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AllocateddateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.AllocateddocumentTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.ReceiveddateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ReceiverdocumentTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ReceiverdocumenttypeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ReceivernumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.ShiptocustomerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipmentdateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShippeddateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ShipmentnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.bsInvTx = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxwho = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxtype = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProdordernum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsused = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.bsInvPhys = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colPHYSINVKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxtime1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxwho1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvitemnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsentered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsoriginal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxtype1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTxreason = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl()
        Me.CustomDevExGridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.bsRecvHold = New System.Windows.Forms.BindingSource(Me.components)
        Me.colPrioritemstatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReasoncode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReasontext = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResolutioncode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResolutiontext = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoldtime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHoldrelease = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colWhoreleased = New DevExpress.XtraGrid.Columns.GridColumn()
        InvitemnumberLabel = New System.Windows.Forms.Label()
        ProductidLabel = New System.Windows.Forms.Label()
        ProductdescLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        ClassdescLabel = New System.Windows.Forms.Label()
        ItemstatusLabel = New System.Windows.Forms.Label()
        UnitsremainingLabel = New System.Windows.Forms.Label()
        PonumberLabel = New System.Windows.Forms.Label()
        PodateLabel = New System.Windows.Forms.Label()
        ChangeableponumberLabel = New System.Windows.Forms.Label()
        AllocateddocumentLabel = New System.Windows.Forms.Label()
        AllocateddateLabel = New System.Windows.Forms.Label()
        WorkordernumberLabel = New System.Windows.Forms.Label()
        WorkordercustomerLabel = New System.Windows.Forms.Label()
        WarehouselocationLabel = New System.Windows.Forms.Label()
        WarehousenumberLabel = New System.Windows.Forms.Label()
        ShipmentnumberLabel = New System.Windows.Forms.Label()
        ShippeddateLabel = New System.Windows.Forms.Label()
        ShipmentdateLabel = New System.Windows.Forms.Label()
        ShiptocustomerLabel = New System.Windows.Forms.Label()
        VendornameLabel = New System.Windows.Forms.Label()
        ReceivernumberLabel = New System.Windows.Forms.Label()
        ReceiverdocumenttypeLabel = New System.Windows.Forms.Label()
        ReceiverdocumentLabel = New System.Windows.Forms.Label()
        ReceiveddateLabel = New System.Windows.Forms.Label()
        LotnumberLabel = New System.Windows.Forms.Label()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LotnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehousenumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarehouselocationTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitsremainingTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemstatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvitemnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.VendornameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangeableponumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PodateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PonumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.WorkordercustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllocateddateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllocateddocumentTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.ReceiveddateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverdocumentTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverdocumenttypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceivernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.ShiptocustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentdateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippeddateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShipmentnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvTx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvPhys, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRecvHold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InvitemnumberLabel
        '
        InvitemnumberLabel.AutoSize = True
        InvitemnumberLabel.Location = New System.Drawing.Point(9, 28)
        InvitemnumberLabel.Name = "InvitemnumberLabel"
        InvitemnumberLabel.Size = New System.Drawing.Size(69, 13)
        InvitemnumberLabel.TabIndex = 0
        InvitemnumberLabel.Text = "Item Number"
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(9, 54)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(58, 13)
        ProductidLabel.TabIndex = 2
        ProductidLabel.Text = "Product ID"
        '
        'ProductdescLabel
        '
        ProductdescLabel.AutoSize = True
        ProductdescLabel.Location = New System.Drawing.Point(9, 80)
        ProductdescLabel.Name = "ProductdescLabel"
        ProductdescLabel.Size = New System.Drawing.Size(70, 13)
        ProductdescLabel.TabIndex = 4
        ProductdescLabel.Text = "Product Desc"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(9, 106)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 6
        ContainerLabel.Text = "Container"
        '
        'ClassdescLabel
        '
        ClassdescLabel.AutoSize = True
        ClassdescLabel.Location = New System.Drawing.Point(392, 28)
        ClassdescLabel.Name = "ClassdescLabel"
        ClassdescLabel.Size = New System.Drawing.Size(32, 13)
        ClassdescLabel.TabIndex = 0
        ClassdescLabel.Text = "Class"
        '
        'ItemstatusLabel
        '
        ItemstatusLabel.AutoSize = True
        ItemstatusLabel.Location = New System.Drawing.Point(386, 54)
        ItemstatusLabel.Name = "ItemstatusLabel"
        ItemstatusLabel.Size = New System.Drawing.Size(38, 13)
        ItemstatusLabel.TabIndex = 2
        ItemstatusLabel.Text = "Status"
        '
        'UnitsremainingLabel
        '
        UnitsremainingLabel.AutoSize = True
        UnitsremainingLabel.Location = New System.Drawing.Point(341, 80)
        UnitsremainingLabel.Name = "UnitsremainingLabel"
        UnitsremainingLabel.Size = New System.Drawing.Size(83, 13)
        UnitsremainingLabel.TabIndex = 4
        UnitsremainingLabel.Text = "Units Remaining"
        '
        'PonumberLabel
        '
        PonumberLabel.AutoSize = True
        PonumberLabel.Location = New System.Drawing.Point(9, 28)
        PonumberLabel.Name = "PonumberLabel"
        PonumberLabel.Size = New System.Drawing.Size(61, 13)
        PonumberLabel.TabIndex = 0
        PonumberLabel.Text = "PO Number"
        '
        'PodateLabel
        '
        PodateLabel.AutoSize = True
        PodateLabel.Location = New System.Drawing.Point(9, 54)
        PodateLabel.Name = "PodateLabel"
        PodateLabel.Size = New System.Drawing.Size(47, 13)
        PodateLabel.TabIndex = 2
        PodateLabel.Text = "PO Date"
        '
        'ChangeableponumberLabel
        '
        ChangeableponumberLabel.AutoSize = True
        ChangeableponumberLabel.Location = New System.Drawing.Point(9, 80)
        ChangeableponumberLabel.Name = "ChangeableponumberLabel"
        ChangeableponumberLabel.Size = New System.Drawing.Size(61, 13)
        ChangeableponumberLabel.TabIndex = 4
        ChangeableponumberLabel.Text = "Alt PO Num"
        '
        'AllocateddocumentLabel
        '
        AllocateddocumentLabel.AutoSize = True
        AllocateddocumentLabel.Location = New System.Drawing.Point(9, 114)
        AllocateddocumentLabel.Name = "AllocateddocumentLabel"
        AllocateddocumentLabel.Size = New System.Drawing.Size(50, 13)
        AllocateddocumentLabel.TabIndex = 0
        AllocateddocumentLabel.Text = "Alloc Doc"
        '
        'AllocateddateLabel
        '
        AllocateddateLabel.AutoSize = True
        AllocateddateLabel.Location = New System.Drawing.Point(9, 61)
        AllocateddateLabel.Name = "AllocateddateLabel"
        AllocateddateLabel.Size = New System.Drawing.Size(55, 13)
        AllocateddateLabel.TabIndex = 2
        AllocateddateLabel.Text = "Alloc Date"
        '
        'WorkordernumberLabel
        '
        WorkordernumberLabel.AutoSize = True
        WorkordernumberLabel.Location = New System.Drawing.Point(9, 35)
        WorkordernumberLabel.Name = "WorkordernumberLabel"
        WorkordernumberLabel.Size = New System.Drawing.Size(65, 13)
        WorkordernumberLabel.TabIndex = 4
        WorkordernumberLabel.Text = "WO Number"
        '
        'WorkordercustomerLabel
        '
        WorkordercustomerLabel.AutoSize = True
        WorkordercustomerLabel.Location = New System.Drawing.Point(9, 88)
        WorkordercustomerLabel.Name = "WorkordercustomerLabel"
        WorkordercustomerLabel.Size = New System.Drawing.Size(53, 13)
        WorkordercustomerLabel.TabIndex = 6
        WorkordercustomerLabel.Text = "Customer"
        '
        'WarehouselocationLabel
        '
        WarehouselocationLabel.AutoSize = True
        WarehouselocationLabel.Location = New System.Drawing.Point(381, 132)
        WarehouselocationLabel.Name = "WarehouselocationLabel"
        WarehouselocationLabel.Size = New System.Drawing.Size(41, 13)
        WarehouselocationLabel.TabIndex = 14
        WarehouselocationLabel.Text = "WH Bin"
        '
        'WarehousenumberLabel
        '
        WarehousenumberLabel.AutoSize = True
        WarehousenumberLabel.Location = New System.Drawing.Point(358, 106)
        WarehousenumberLabel.Name = "WarehousenumberLabel"
        WarehousenumberLabel.Size = New System.Drawing.Size(64, 13)
        WarehousenumberLabel.TabIndex = 16
        WarehousenumberLabel.Text = "WH Number"
        '
        'ShipmentnumberLabel
        '
        ShipmentnumberLabel.AutoSize = True
        ShipmentnumberLabel.Location = New System.Drawing.Point(11, 35)
        ShipmentnumberLabel.Name = "ShipmentnumberLabel"
        ShipmentnumberLabel.Size = New System.Drawing.Size(67, 13)
        ShipmentnumberLabel.TabIndex = 0
        ShipmentnumberLabel.Text = "Ship Number"
        '
        'ShippeddateLabel
        '
        ShippeddateLabel.AutoSize = True
        ShippeddateLabel.Location = New System.Drawing.Point(25, 114)
        ShippeddateLabel.Name = "ShippeddateLabel"
        ShippeddateLabel.Size = New System.Drawing.Size(53, 13)
        ShippeddateLabel.TabIndex = 2
        ShippeddateLabel.Text = "Mark Ship"
        '
        'ShipmentdateLabel
        '
        ShipmentdateLabel.AutoSize = True
        ShipmentdateLabel.Location = New System.Drawing.Point(25, 61)
        ShipmentdateLabel.Name = "ShipmentdateLabel"
        ShipmentdateLabel.Size = New System.Drawing.Size(53, 13)
        ShipmentdateLabel.TabIndex = 4
        ShipmentdateLabel.Text = "Ship Date"
        '
        'ShiptocustomerLabel
        '
        ShiptocustomerLabel.AutoSize = True
        ShiptocustomerLabel.Location = New System.Drawing.Point(27, 88)
        ShiptocustomerLabel.Name = "ShiptocustomerLabel"
        ShiptocustomerLabel.Size = New System.Drawing.Size(53, 13)
        ShiptocustomerLabel.TabIndex = 6
        ShiptocustomerLabel.Text = "Customer"
        '
        'VendornameLabel
        '
        VendornameLabel.AutoSize = True
        VendornameLabel.Location = New System.Drawing.Point(9, 106)
        VendornameLabel.Name = "VendornameLabel"
        VendornameLabel.Size = New System.Drawing.Size(71, 13)
        VendornameLabel.TabIndex = 6
        VendornameLabel.Text = "Vendor Name"
        '
        'ReceivernumberLabel
        '
        ReceivernumberLabel.AutoSize = True
        ReceivernumberLabel.Location = New System.Drawing.Point(7, 35)
        ReceivernumberLabel.Name = "ReceivernumberLabel"
        ReceivernumberLabel.Size = New System.Drawing.Size(69, 13)
        ReceivernumberLabel.TabIndex = 0
        ReceivernumberLabel.Text = "Rcvr Number"
        '
        'ReceiverdocumenttypeLabel
        '
        ReceiverdocumenttypeLabel.AutoSize = True
        ReceiverdocumenttypeLabel.Location = New System.Drawing.Point(20, 61)
        ReceiverdocumenttypeLabel.Name = "ReceiverdocumenttypeLabel"
        ReceiverdocumenttypeLabel.Size = New System.Drawing.Size(56, 13)
        ReceiverdocumenttypeLabel.TabIndex = 2
        ReceiverdocumenttypeLabel.Text = "Rcvr Type"
        '
        'ReceiverdocumentLabel
        '
        ReceiverdocumentLabel.AutoSize = True
        ReceiverdocumentLabel.Location = New System.Drawing.Point(2, 88)
        ReceiverdocumentLabel.Name = "ReceiverdocumentLabel"
        ReceiverdocumentLabel.Size = New System.Drawing.Size(74, 13)
        ReceiverdocumentLabel.TabIndex = 4
        ReceiverdocumentLabel.Text = "Rcvr Doc Num"
        '
        'ReceiveddateLabel
        '
        ReceiveddateLabel.AutoSize = True
        ReceiveddateLabel.Location = New System.Drawing.Point(17, 114)
        ReceiveddateLabel.Name = "ReceiveddateLabel"
        ReceiveddateLabel.Size = New System.Drawing.Size(57, 13)
        ReceiveddateLabel.TabIndex = 6
        ReceiveddateLabel.Text = "Rcvd Date"
        '
        'LotnumberLabel
        '
        LotnumberLabel.AutoSize = True
        LotnumberLabel.Location = New System.Drawing.Point(9, 132)
        LotnumberLabel.Name = "LotnumberLabel"
        LotnumberLabel.Size = New System.Drawing.Size(62, 13)
        LotnumberLabel.TabIndex = 18
        LotnumberLabel.Text = "Lot Number"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.ViewInvItemDetails)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnReturn, Me.btnCancel, Me.rbtnMarkShipped, Me.rbtnMarkAvailable, Me.rbtnMarkQuarantine, Me.rbtnMarkDepleted, Me.rbtnConvertFGtoRM, Me.rbtnConvertRMtoFG, Me.rbtnUpdateLotNumber, Me.rbtnMarkInProcess, Me.rbtnChangeItemStatus, Me.rbtnConvertItemClass})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 16
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(931, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnReturn
        '
        Me.rbtnReturn.Caption = "Return"
        Me.rbtnReturn.Id = 4
        Me.rbtnReturn.LargeImageIndex = 10
        Me.rbtnReturn.Name = "rbtnReturn"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        '
        'rbtnMarkShipped
        '
        Me.rbtnMarkShipped.Caption = "Mark Shipped"
        Me.rbtnMarkShipped.Id = 6
        Me.rbtnMarkShipped.LargeGlyph = Global.AOS.My.Resources.Resources.document_go__2_
        Me.rbtnMarkShipped.Name = "rbtnMarkShipped"
        '
        'rbtnMarkAvailable
        '
        Me.rbtnMarkAvailable.Caption = "Mark Available"
        Me.rbtnMarkAvailable.Id = 7
        Me.rbtnMarkAvailable.LargeGlyph = Global.AOS.My.Resources.Resources.document_accept__2_
        Me.rbtnMarkAvailable.Name = "rbtnMarkAvailable"
        '
        'rbtnMarkQuarantine
        '
        Me.rbtnMarkQuarantine.Caption = "Mark Quarantined"
        Me.rbtnMarkQuarantine.Id = 8
        Me.rbtnMarkQuarantine.LargeGlyph = Global.AOS.My.Resources.Resources.document_error__2_
        Me.rbtnMarkQuarantine.Name = "rbtnMarkQuarantine"
        '
        'rbtnMarkDepleted
        '
        Me.rbtnMarkDepleted.Caption = "Mark Depleted"
        Me.rbtnMarkDepleted.Id = 9
        Me.rbtnMarkDepleted.LargeGlyph = Global.AOS.My.Resources.Resources.document_delete3__2_
        Me.rbtnMarkDepleted.Name = "rbtnMarkDepleted"
        '
        'rbtnConvertFGtoRM
        '
        Me.rbtnConvertFGtoRM.Caption = "Convert to In Process"
        Me.rbtnConvertFGtoRM.Id = 10
        Me.rbtnConvertFGtoRM.LargeImageIndex = 9
        Me.rbtnConvertFGtoRM.Name = "rbtnConvertFGtoRM"
        '
        'rbtnConvertRMtoFG
        '
        Me.rbtnConvertRMtoFG.Caption = "Convert to Full Available"
        Me.rbtnConvertRMtoFG.Id = 11
        Me.rbtnConvertRMtoFG.LargeImageIndex = 9
        Me.rbtnConvertRMtoFG.Name = "rbtnConvertRMtoFG"
        '
        'rbtnUpdateLotNumber
        '
        Me.rbtnUpdateLotNumber.Caption = "Change Lot Number"
        Me.rbtnUpdateLotNumber.Id = 12
        Me.rbtnUpdateLotNumber.LargeImageIndex = 8
        Me.rbtnUpdateLotNumber.Name = "rbtnUpdateLotNumber"
        '
        'rbtnMarkInProcess
        '
        Me.rbtnMarkInProcess.Caption = "Mark In Process"
        Me.rbtnMarkInProcess.Id = 13
        Me.rbtnMarkInProcess.LargeGlyph = Global.AOS.My.Resources.Resources.document__2_
        Me.rbtnMarkInProcess.Name = "rbtnMarkInProcess"
        '
        'rbtnChangeItemStatus
        '
        Me.rbtnChangeItemStatus.Caption = "Change Item Status"
        Me.rbtnChangeItemStatus.Id = 14
        Me.rbtnChangeItemStatus.LargeImageIndex = 3
        Me.rbtnChangeItemStatus.Name = "rbtnChangeItemStatus"
        '
        'rbtnConvertItemClass
        '
        Me.rbtnConvertItemClass.Caption = "Convert Item Class"
        Me.rbtnConvertItemClass.Id = 15
        Me.rbtnConvertItemClass.LargeImageIndex = 12
        Me.rbtnConvertItemClass.Name = "rbtnConvertItemClass"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnReturn)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnUpdateLotNumber, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnChangeItemStatus, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnConvertRMtoFG, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnConvertFGtoRM)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnConvertItemClass)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnMarkAvailable)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnMarkInProcess)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnMarkQuarantine)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnMarkDepleted)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnMarkShipped)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Update Item Status"
        Me.RibbonPageGroup1.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(LotnumberLabel)
        Me.GroupControl1.Controls.Add(Me.LotnumberTextEdit)
        Me.GroupControl1.Controls.Add(WarehousenumberLabel)
        Me.GroupControl1.Controls.Add(Me.WarehousenumberTextEdit)
        Me.GroupControl1.Controls.Add(WarehouselocationLabel)
        Me.GroupControl1.Controls.Add(Me.WarehouselocationTextEdit)
        Me.GroupControl1.Controls.Add(UnitsremainingLabel)
        Me.GroupControl1.Controls.Add(ContainerLabel)
        Me.GroupControl1.Controls.Add(Me.UnitsremainingTextEdit)
        Me.GroupControl1.Controls.Add(ItemstatusLabel)
        Me.GroupControl1.Controls.Add(Me.ContainerTextEdit)
        Me.GroupControl1.Controls.Add(Me.ItemstatusTextEdit)
        Me.GroupControl1.Controls.Add(ProductdescLabel)
        Me.GroupControl1.Controls.Add(ClassdescLabel)
        Me.GroupControl1.Controls.Add(Me.ProductdescTextEdit)
        Me.GroupControl1.Controls.Add(Me.ClassdescTextEdit)
        Me.GroupControl1.Controls.Add(ProductidLabel)
        Me.GroupControl1.Controls.Add(Me.ProductidTextEdit)
        Me.GroupControl1.Controls.Add(InvitemnumberLabel)
        Me.GroupControl1.Controls.Add(Me.InvitemnumberTextEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 100)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(618, 159)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Item Information"
        '
        'LotnumberTextEdit
        '
        Me.LotnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Lotnumber", True))
        Me.LotnumberTextEdit.Location = New System.Drawing.Point(84, 129)
        Me.LotnumberTextEdit.Name = "LotnumberTextEdit"
        Me.LotnumberTextEdit.Properties.ReadOnly = True
        Me.LotnumberTextEdit.Size = New System.Drawing.Size(125, 20)
        Me.LotnumberTextEdit.TabIndex = 19
        Me.LotnumberTextEdit.TabStop = False
        '
        'WarehousenumberTextEdit
        '
        Me.WarehousenumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Warehousenumber", True))
        Me.WarehousenumberTextEdit.Location = New System.Drawing.Point(432, 103)
        Me.WarehousenumberTextEdit.Name = "WarehousenumberTextEdit"
        Me.WarehousenumberTextEdit.Properties.ReadOnly = True
        Me.WarehousenumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.WarehousenumberTextEdit.TabIndex = 17
        Me.WarehousenumberTextEdit.TabStop = False
        '
        'WarehouselocationTextEdit
        '
        Me.WarehouselocationTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Warehouselocation", True))
        Me.WarehouselocationTextEdit.Location = New System.Drawing.Point(432, 129)
        Me.WarehouselocationTextEdit.Name = "WarehouselocationTextEdit"
        Me.WarehouselocationTextEdit.Properties.ReadOnly = True
        Me.WarehouselocationTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.WarehouselocationTextEdit.TabIndex = 15
        Me.WarehouselocationTextEdit.TabStop = False
        '
        'UnitsremainingTextEdit
        '
        Me.UnitsremainingTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Unitsremaining", True))
        Me.UnitsremainingTextEdit.Location = New System.Drawing.Point(432, 77)
        Me.UnitsremainingTextEdit.Name = "UnitsremainingTextEdit"
        Me.UnitsremainingTextEdit.Properties.DisplayFormat.FormatString = "n2"
        Me.UnitsremainingTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitsremainingTextEdit.Properties.ReadOnly = True
        Me.UnitsremainingTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.UnitsremainingTextEdit.TabIndex = 5
        Me.UnitsremainingTextEdit.TabStop = False
        '
        'ContainerTextEdit
        '
        Me.ContainerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Container", True))
        Me.ContainerTextEdit.Location = New System.Drawing.Point(84, 103)
        Me.ContainerTextEdit.Name = "ContainerTextEdit"
        Me.ContainerTextEdit.Properties.ReadOnly = True
        Me.ContainerTextEdit.Size = New System.Drawing.Size(125, 20)
        Me.ContainerTextEdit.TabIndex = 7
        Me.ContainerTextEdit.TabStop = False
        '
        'ItemstatusTextEdit
        '
        Me.ItemstatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Itemstatus", True))
        Me.ItemstatusTextEdit.Location = New System.Drawing.Point(432, 51)
        Me.ItemstatusTextEdit.Name = "ItemstatusTextEdit"
        Me.ItemstatusTextEdit.Properties.ReadOnly = True
        Me.ItemstatusTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ItemstatusTextEdit.TabIndex = 3
        Me.ItemstatusTextEdit.TabStop = False
        '
        'ProductdescTextEdit
        '
        Me.ProductdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productdesc", True))
        Me.ProductdescTextEdit.Location = New System.Drawing.Point(84, 77)
        Me.ProductdescTextEdit.Name = "ProductdescTextEdit"
        Me.ProductdescTextEdit.Properties.ReadOnly = True
        Me.ProductdescTextEdit.Size = New System.Drawing.Size(240, 20)
        Me.ProductdescTextEdit.TabIndex = 5
        Me.ProductdescTextEdit.TabStop = False
        '
        'ClassdescTextEdit
        '
        Me.ClassdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Classdesc", True))
        Me.ClassdescTextEdit.Location = New System.Drawing.Point(432, 25)
        Me.ClassdescTextEdit.Name = "ClassdescTextEdit"
        Me.ClassdescTextEdit.Properties.ReadOnly = True
        Me.ClassdescTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ClassdescTextEdit.TabIndex = 1
        Me.ClassdescTextEdit.TabStop = False
        '
        'ProductidTextEdit
        '
        Me.ProductidTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productid", True))
        Me.ProductidTextEdit.Location = New System.Drawing.Point(84, 51)
        Me.ProductidTextEdit.Name = "ProductidTextEdit"
        Me.ProductidTextEdit.Properties.ReadOnly = True
        Me.ProductidTextEdit.Size = New System.Drawing.Size(61, 20)
        Me.ProductidTextEdit.TabIndex = 3
        Me.ProductidTextEdit.TabStop = False
        '
        'InvitemnumberTextEdit
        '
        Me.InvitemnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Invitemnumber", True))
        Me.InvitemnumberTextEdit.Location = New System.Drawing.Point(84, 25)
        Me.InvitemnumberTextEdit.Name = "InvitemnumberTextEdit"
        Me.InvitemnumberTextEdit.Properties.ReadOnly = True
        Me.InvitemnumberTextEdit.Size = New System.Drawing.Size(61, 20)
        Me.InvitemnumberTextEdit.TabIndex = 1
        Me.InvitemnumberTextEdit.TabStop = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(VendornameLabel)
        Me.GroupControl3.Controls.Add(Me.VendornameTextEdit)
        Me.GroupControl3.Controls.Add(ChangeableponumberLabel)
        Me.GroupControl3.Controls.Add(Me.ChangeableponumberTextEdit)
        Me.GroupControl3.Controls.Add(PodateLabel)
        Me.GroupControl3.Controls.Add(Me.PodateTextEdit)
        Me.GroupControl3.Controls.Add(PonumberLabel)
        Me.GroupControl3.Controls.Add(Me.PonumberTextEdit)
        Me.GroupControl3.Location = New System.Drawing.Point(636, 100)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(283, 159)
        Me.GroupControl3.TabIndex = 3
        Me.GroupControl3.Text = "Purchasing Data"
        '
        'VendornameTextEdit
        '
        Me.VendornameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Vendorname", True))
        Me.VendornameTextEdit.Location = New System.Drawing.Point(84, 103)
        Me.VendornameTextEdit.Name = "VendornameTextEdit"
        Me.VendornameTextEdit.Properties.ReadOnly = True
        Me.VendornameTextEdit.Size = New System.Drawing.Size(187, 20)
        Me.VendornameTextEdit.TabIndex = 7
        Me.VendornameTextEdit.TabStop = False
        '
        'ChangeableponumberTextEdit
        '
        Me.ChangeableponumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Changeableponumber", True))
        Me.ChangeableponumberTextEdit.Location = New System.Drawing.Point(84, 77)
        Me.ChangeableponumberTextEdit.Name = "ChangeableponumberTextEdit"
        Me.ChangeableponumberTextEdit.Properties.ReadOnly = True
        Me.ChangeableponumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ChangeableponumberTextEdit.TabIndex = 5
        Me.ChangeableponumberTextEdit.TabStop = False
        '
        'PodateTextEdit
        '
        Me.PodateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Podate", True))
        Me.PodateTextEdit.Location = New System.Drawing.Point(84, 51)
        Me.PodateTextEdit.MenuManager = Me.RibbonControl1
        Me.PodateTextEdit.Name = "PodateTextEdit"
        Me.PodateTextEdit.Properties.DisplayFormat.FormatString = "d"
        Me.PodateTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.PodateTextEdit.Properties.ReadOnly = True
        Me.PodateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PodateTextEdit.TabIndex = 3
        Me.PodateTextEdit.TabStop = False
        '
        'PonumberTextEdit
        '
        Me.PonumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Ponumber", True))
        Me.PonumberTextEdit.Location = New System.Drawing.Point(84, 25)
        Me.PonumberTextEdit.Name = "PonumberTextEdit"
        Me.PonumberTextEdit.Properties.ReadOnly = True
        Me.PonumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.PonumberTextEdit.TabIndex = 1
        Me.PonumberTextEdit.TabStop = False
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(WorkordercustomerLabel)
        Me.GroupControl4.Controls.Add(Me.WorkordercustomerTextEdit)
        Me.GroupControl4.Controls.Add(WorkordernumberLabel)
        Me.GroupControl4.Controls.Add(Me.WorkordernumberTextEdit)
        Me.GroupControl4.Controls.Add(AllocateddateLabel)
        Me.GroupControl4.Controls.Add(Me.AllocateddateTextEdit)
        Me.GroupControl4.Controls.Add(AllocateddocumentLabel)
        Me.GroupControl4.Controls.Add(Me.AllocateddocumentTextEdit)
        Me.GroupControl4.Location = New System.Drawing.Point(356, 265)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(274, 143)
        Me.GroupControl4.TabIndex = 4
        Me.GroupControl4.Text = "Work Order Data"
        '
        'WorkordercustomerTextEdit
        '
        Me.WorkordercustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Workordercustomer", True))
        Me.WorkordercustomerTextEdit.Location = New System.Drawing.Point(84, 85)
        Me.WorkordercustomerTextEdit.Name = "WorkordercustomerTextEdit"
        Me.WorkordercustomerTextEdit.Properties.ReadOnly = True
        Me.WorkordercustomerTextEdit.Size = New System.Drawing.Size(175, 20)
        Me.WorkordercustomerTextEdit.TabIndex = 7
        Me.WorkordercustomerTextEdit.TabStop = False
        '
        'WorkordernumberTextEdit
        '
        Me.WorkordernumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Workordernumber", True))
        Me.WorkordernumberTextEdit.Location = New System.Drawing.Point(84, 32)
        Me.WorkordernumberTextEdit.Name = "WorkordernumberTextEdit"
        Me.WorkordernumberTextEdit.Properties.DisplayFormat.FormatString = "d"
        Me.WorkordernumberTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.WorkordernumberTextEdit.Properties.ReadOnly = True
        Me.WorkordernumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.WorkordernumberTextEdit.TabIndex = 5
        Me.WorkordernumberTextEdit.TabStop = False
        '
        'AllocateddateTextEdit
        '
        Me.AllocateddateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Allocateddate", True))
        Me.AllocateddateTextEdit.Location = New System.Drawing.Point(84, 59)
        Me.AllocateddateTextEdit.MenuManager = Me.RibbonControl1
        Me.AllocateddateTextEdit.Name = "AllocateddateTextEdit"
        Me.AllocateddateTextEdit.Properties.DisplayFormat.FormatString = "d"
        Me.AllocateddateTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.AllocateddateTextEdit.Properties.ReadOnly = True
        Me.AllocateddateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AllocateddateTextEdit.TabIndex = 3
        Me.AllocateddateTextEdit.TabStop = False
        '
        'AllocateddocumentTextEdit
        '
        Me.AllocateddocumentTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Allocateddocument", True))
        Me.AllocateddocumentTextEdit.Location = New System.Drawing.Point(84, 111)
        Me.AllocateddocumentTextEdit.Name = "AllocateddocumentTextEdit"
        Me.AllocateddocumentTextEdit.Properties.ReadOnly = True
        Me.AllocateddocumentTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.AllocateddocumentTextEdit.TabIndex = 1
        Me.AllocateddocumentTextEdit.TabStop = False
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(ReceiveddateLabel)
        Me.GroupControl5.Controls.Add(Me.ReceiveddateTextEdit)
        Me.GroupControl5.Controls.Add(ReceiverdocumentLabel)
        Me.GroupControl5.Controls.Add(Me.ReceiverdocumentTextEdit)
        Me.GroupControl5.Controls.Add(ReceiverdocumenttypeLabel)
        Me.GroupControl5.Controls.Add(Me.ReceiverdocumenttypeTextEdit)
        Me.GroupControl5.Controls.Add(ReceivernumberLabel)
        Me.GroupControl5.Controls.Add(Me.ReceivernumberTextEdit)
        Me.GroupControl5.Location = New System.Drawing.Point(12, 265)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(336, 143)
        Me.GroupControl5.TabIndex = 5
        Me.GroupControl5.Text = "Receiving Data"
        '
        'ReceiveddateTextEdit
        '
        Me.ReceiveddateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Receiveddate", True))
        Me.ReceiveddateTextEdit.Location = New System.Drawing.Point(84, 111)
        Me.ReceiveddateTextEdit.MenuManager = Me.RibbonControl1
        Me.ReceiveddateTextEdit.Name = "ReceiveddateTextEdit"
        Me.ReceiveddateTextEdit.Properties.DisplayFormat.FormatString = "d"
        Me.ReceiveddateTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ReceiveddateTextEdit.Properties.ReadOnly = True
        Me.ReceiveddateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ReceiveddateTextEdit.TabIndex = 7
        Me.ReceiveddateTextEdit.TabStop = False
        '
        'ReceiverdocumentTextEdit
        '
        Me.ReceiverdocumentTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Receiverdocument", True))
        Me.ReceiverdocumentTextEdit.Location = New System.Drawing.Point(84, 85)
        Me.ReceiverdocumentTextEdit.Name = "ReceiverdocumentTextEdit"
        Me.ReceiverdocumentTextEdit.Properties.ReadOnly = True
        Me.ReceiverdocumentTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ReceiverdocumentTextEdit.TabIndex = 5
        Me.ReceiverdocumentTextEdit.TabStop = False
        '
        'ReceiverdocumenttypeTextEdit
        '
        Me.ReceiverdocumenttypeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Receiverdocumenttype", True))
        Me.ReceiverdocumenttypeTextEdit.Location = New System.Drawing.Point(84, 58)
        Me.ReceiverdocumenttypeTextEdit.Name = "ReceiverdocumenttypeTextEdit"
        Me.ReceiverdocumenttypeTextEdit.Properties.ReadOnly = True
        Me.ReceiverdocumenttypeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ReceiverdocumenttypeTextEdit.TabIndex = 3
        Me.ReceiverdocumenttypeTextEdit.TabStop = False
        '
        'ReceivernumberTextEdit
        '
        Me.ReceivernumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Receivernumber", True))
        Me.ReceivernumberTextEdit.Location = New System.Drawing.Point(84, 32)
        Me.ReceivernumberTextEdit.Name = "ReceivernumberTextEdit"
        Me.ReceivernumberTextEdit.Properties.ReadOnly = True
        Me.ReceivernumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ReceivernumberTextEdit.TabIndex = 1
        Me.ReceivernumberTextEdit.TabStop = False
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(ShiptocustomerLabel)
        Me.GroupControl6.Controls.Add(Me.ShiptocustomerTextEdit)
        Me.GroupControl6.Controls.Add(ShipmentdateLabel)
        Me.GroupControl6.Controls.Add(Me.ShipmentdateTextEdit)
        Me.GroupControl6.Controls.Add(ShippeddateLabel)
        Me.GroupControl6.Controls.Add(Me.ShippeddateTextEdit)
        Me.GroupControl6.Controls.Add(ShipmentnumberLabel)
        Me.GroupControl6.Controls.Add(Me.ShipmentnumberTextEdit)
        Me.GroupControl6.Location = New System.Drawing.Point(636, 265)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(283, 143)
        Me.GroupControl6.TabIndex = 6
        Me.GroupControl6.Text = "Shipping Data"
        '
        'ShiptocustomerTextEdit
        '
        Me.ShiptocustomerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Shiptocustomer", True))
        Me.ShiptocustomerTextEdit.Location = New System.Drawing.Point(88, 85)
        Me.ShiptocustomerTextEdit.Name = "ShiptocustomerTextEdit"
        Me.ShiptocustomerTextEdit.Properties.ReadOnly = True
        Me.ShiptocustomerTextEdit.Size = New System.Drawing.Size(183, 20)
        Me.ShiptocustomerTextEdit.TabIndex = 7
        Me.ShiptocustomerTextEdit.TabStop = False
        '
        'ShipmentdateTextEdit
        '
        Me.ShipmentdateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Shipmentdate", True))
        Me.ShipmentdateTextEdit.EditValue = ""
        Me.ShipmentdateTextEdit.Location = New System.Drawing.Point(88, 58)
        Me.ShipmentdateTextEdit.MenuManager = Me.RibbonControl1
        Me.ShipmentdateTextEdit.Name = "ShipmentdateTextEdit"
        Me.ShipmentdateTextEdit.Properties.DisplayFormat.FormatString = "d"
        Me.ShipmentdateTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ShipmentdateTextEdit.Properties.ReadOnly = True
        Me.ShipmentdateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ShipmentdateTextEdit.TabIndex = 5
        Me.ShipmentdateTextEdit.TabStop = False
        '
        'ShippeddateTextEdit
        '
        Me.ShippeddateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Shippeddate", True))
        Me.ShippeddateTextEdit.Location = New System.Drawing.Point(88, 111)
        Me.ShippeddateTextEdit.MenuManager = Me.RibbonControl1
        Me.ShippeddateTextEdit.Name = "ShippeddateTextEdit"
        Me.ShippeddateTextEdit.Properties.DisplayFormat.FormatString = "d"
        Me.ShippeddateTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.ShippeddateTextEdit.Properties.ReadOnly = True
        Me.ShippeddateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ShippeddateTextEdit.TabIndex = 3
        Me.ShippeddateTextEdit.TabStop = False
        '
        'ShipmentnumberTextEdit
        '
        Me.ShipmentnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Shipmentnumber", True))
        Me.ShipmentnumberTextEdit.Location = New System.Drawing.Point(88, 32)
        Me.ShipmentnumberTextEdit.Name = "ShipmentnumberTextEdit"
        Me.ShipmentnumberTextEdit.Properties.ReadOnly = True
        Me.ShipmentnumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ShipmentnumberTextEdit.TabIndex = 1
        Me.ShipmentnumberTextEdit.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 513)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(907, 136)
        Me.GroupControl2.TabIndex = 8
        Me.GroupControl2.Text = "Inventory Usage Transactions"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsInvTx
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(903, 112)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsInvTx
        '
        Me.bsInvTx.DataSource = GetType(AOS.BusinessObjects.ViewInvItemTransactionsCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colInvitemnumber, Me.colTxtime, Me.colTxwho, Me.colTxtype, Me.colProdordernum, Me.colUnitsused})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        '
        'colTxtime
        '
        Me.colTxtime.Caption = "When"
        Me.colTxtime.DisplayFormat.FormatString = "g"
        Me.colTxtime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTxtime.FieldName = "Txtime"
        Me.colTxtime.Name = "colTxtime"
        Me.colTxtime.OptionsColumn.AllowEdit = False
        Me.colTxtime.Visible = True
        Me.colTxtime.VisibleIndex = 0
        Me.colTxtime.Width = 109
        '
        'colTxwho
        '
        Me.colTxwho.Caption = "Who"
        Me.colTxwho.FieldName = "Txwho"
        Me.colTxwho.Name = "colTxwho"
        Me.colTxwho.OptionsColumn.AllowEdit = False
        Me.colTxwho.Visible = True
        Me.colTxwho.VisibleIndex = 1
        Me.colTxwho.Width = 81
        '
        'colTxtype
        '
        Me.colTxtype.Caption = "Type"
        Me.colTxtype.FieldName = "Txtype"
        Me.colTxtype.Name = "colTxtype"
        Me.colTxtype.OptionsColumn.AllowEdit = False
        Me.colTxtype.Visible = True
        Me.colTxtype.VisibleIndex = 2
        Me.colTxtype.Width = 94
        '
        'colProdordernum
        '
        Me.colProdordernum.Caption = "Doc#"
        Me.colProdordernum.FieldName = "Prodordernum"
        Me.colProdordernum.Name = "colProdordernum"
        Me.colProdordernum.OptionsColumn.AllowEdit = False
        Me.colProdordernum.Visible = True
        Me.colProdordernum.VisibleIndex = 3
        Me.colProdordernum.Width = 61
        '
        'colUnitsused
        '
        Me.colUnitsused.Caption = "Units Used"
        Me.colUnitsused.DisplayFormat.FormatString = "n4"
        Me.colUnitsused.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colUnitsused.FieldName = "Unitsused"
        Me.colUnitsused.Name = "colUnitsused"
        Me.colUnitsused.OptionsColumn.AllowEdit = False
        Me.colUnitsused.Visible = True
        Me.colUnitsused.VisibleIndex = 4
        Me.colUnitsused.Width = 556
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.GridControl2)
        Me.GroupControl7.Location = New System.Drawing.Point(12, 655)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(905, 136)
        Me.GroupControl7.TabIndex = 9
        Me.GroupControl7.Text = "Inventory Physical Adjustments"
        '
        'GridControl2
        '
        Me.GridControl2.DataSource = Me.bsInvPhys
        Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl2.Location = New System.Drawing.Point(2, 22)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.RibbonControl1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(901, 112)
        Me.GridControl2.TabIndex = 1
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'bsInvPhys
        '
        Me.bsInvPhys.DataSource = GetType(AOS.BusinessObjects.InvphysCollection)
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPHYSINVKey, Me.colTxtime1, Me.colTxwho1, Me.colInvitemnumber1, Me.colUnitsentered, Me.colUnitsoriginal, Me.colTxtype1, Me.colTxreason, Me.GridColumn1})
        Me.GridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsBehavior.Editable = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView2.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.OptionsView.ShowIndicator = False
        '
        'colPHYSINVKey
        '
        Me.colPHYSINVKey.FieldName = "PHYSINVKey"
        Me.colPHYSINVKey.Name = "colPHYSINVKey"
        '
        'colTxtime1
        '
        Me.colTxtime1.Caption = "When"
        Me.colTxtime1.FieldName = "Txtime"
        Me.colTxtime1.Name = "colTxtime1"
        Me.colTxtime1.OptionsColumn.AllowEdit = False
        Me.colTxtime1.Visible = True
        Me.colTxtime1.VisibleIndex = 0
        Me.colTxtime1.Width = 101
        '
        'colTxwho1
        '
        Me.colTxwho1.Caption = "Who"
        Me.colTxwho1.FieldName = "Txwho"
        Me.colTxwho1.Name = "colTxwho1"
        Me.colTxwho1.OptionsColumn.AllowEdit = False
        Me.colTxwho1.Visible = True
        Me.colTxwho1.VisibleIndex = 1
        '
        'colInvitemnumber1
        '
        Me.colInvitemnumber1.FieldName = "Invitemnumber"
        Me.colInvitemnumber1.Name = "colInvitemnumber1"
        '
        'colUnitsentered
        '
        Me.colUnitsentered.Caption = "Units After"
        Me.colUnitsentered.FieldName = "Unitsentered"
        Me.colUnitsentered.Name = "colUnitsentered"
        Me.colUnitsentered.OptionsColumn.AllowEdit = False
        Me.colUnitsentered.Visible = True
        Me.colUnitsentered.VisibleIndex = 4
        Me.colUnitsentered.Width = 64
        '
        'colUnitsoriginal
        '
        Me.colUnitsoriginal.Caption = "Units Before"
        Me.colUnitsoriginal.FieldName = "Unitsoriginal"
        Me.colUnitsoriginal.Name = "colUnitsoriginal"
        Me.colUnitsoriginal.OptionsColumn.AllowEdit = False
        Me.colUnitsoriginal.Visible = True
        Me.colUnitsoriginal.VisibleIndex = 3
        Me.colUnitsoriginal.Width = 66
        '
        'colTxtype1
        '
        Me.colTxtype1.Caption = "Type"
        Me.colTxtype1.FieldName = "Txtype"
        Me.colTxtype1.Name = "colTxtype1"
        Me.colTxtype1.OptionsColumn.AllowEdit = False
        Me.colTxtype1.Visible = True
        Me.colTxtype1.VisibleIndex = 2
        Me.colTxtype1.Width = 83
        '
        'colTxreason
        '
        Me.colTxreason.Caption = "Reason for Adjustment"
        Me.colTxreason.FieldName = "Txreason"
        Me.colTxreason.Name = "colTxreason"
        Me.colTxreason.OptionsColumn.AllowEdit = False
        Me.colTxreason.Visible = True
        Me.colTxreason.VisibleIndex = 5
        Me.colTxreason.Width = 415
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "Itemstatus"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.AllowEdit = False
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 95
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.GridControl3)
        Me.GroupControl8.Location = New System.Drawing.Point(12, 414)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(907, 93)
        Me.GroupControl8.TabIndex = 11
        Me.GroupControl8.Text = "Received / Hold History"
        '
        'GridControl3
        '
        Me.GridControl3.DataSource = Me.bsRecvHold
        Me.GridControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl3.Location = New System.Drawing.Point(2, 22)
        Me.GridControl3.MainView = Me.CustomDevExGridView1
        Me.GridControl3.MenuManager = Me.RibbonControl1
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(903, 69)
        Me.GridControl3.TabIndex = 0
        Me.GridControl3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CustomDevExGridView1})
        '
        'CustomDevExGridView1
        '
        Me.CustomDevExGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrioritemstatus, Me.colReasoncode, Me.colReasontext, Me.colResolutioncode, Me.colResolutiontext, Me.colHoldtime, Me.colHoldrelease, Me.colWhoreleased})
        Me.CustomDevExGridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.CustomDevExGridView1.GridControl = Me.GridControl3
        Me.CustomDevExGridView1.Name = "CustomDevExGridView1"
        Me.CustomDevExGridView1.OptionsBehavior.Editable = False
        Me.CustomDevExGridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CustomDevExGridView1.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.CustomDevExGridView1.OptionsView.ShowGroupPanel = False
        Me.CustomDevExGridView1.OptionsView.ShowIndicator = False
        '
        'bsRecvHold
        '
        Me.bsRecvHold.DataSource = GetType(AOS.BusinessObjects.ViewReceivedHoldItemsCollection)
        '
        'colPrioritemstatus
        '
        Me.colPrioritemstatus.Caption = "Prior Status"
        Me.colPrioritemstatus.FieldName = "Prioritemstatus"
        Me.colPrioritemstatus.Name = "colPrioritemstatus"
        Me.colPrioritemstatus.Visible = True
        Me.colPrioritemstatus.VisibleIndex = 0
        Me.colPrioritemstatus.Width = 84
        '
        'colReasoncode
        '
        Me.colReasoncode.Caption = "Hold Code"
        Me.colReasoncode.FieldName = "Reasoncode"
        Me.colReasoncode.Name = "colReasoncode"
        Me.colReasoncode.Visible = True
        Me.colReasoncode.VisibleIndex = 2
        Me.colReasoncode.Width = 84
        '
        'colReasontext
        '
        Me.colReasontext.Caption = "Hold Reason"
        Me.colReasontext.FieldName = "Reasontext"
        Me.colReasontext.Name = "colReasontext"
        Me.colReasontext.Visible = True
        Me.colReasontext.VisibleIndex = 3
        Me.colReasontext.Width = 202
        '
        'colResolutioncode
        '
        Me.colResolutioncode.Caption = "Resolution"
        Me.colResolutioncode.FieldName = "Resolutioncode"
        Me.colResolutioncode.Name = "colResolutioncode"
        Me.colResolutioncode.Visible = True
        Me.colResolutioncode.VisibleIndex = 4
        Me.colResolutioncode.Width = 103
        '
        'colResolutiontext
        '
        Me.colResolutiontext.Caption = "Resolution Explanation"
        Me.colResolutiontext.FieldName = "Resolutiontext"
        Me.colResolutiontext.Name = "colResolutiontext"
        Me.colResolutiontext.Visible = True
        Me.colResolutiontext.VisibleIndex = 5
        Me.colResolutiontext.Width = 227
        '
        'colHoldtime
        '
        Me.colHoldtime.Caption = "Hold Time"
        Me.colHoldtime.FieldName = "Holdtime"
        Me.colHoldtime.Name = "colHoldtime"
        Me.colHoldtime.Visible = True
        Me.colHoldtime.VisibleIndex = 1
        Me.colHoldtime.Width = 59
        '
        'colHoldrelease
        '
        Me.colHoldrelease.Caption = "Released"
        Me.colHoldrelease.FieldName = "Holdrelease"
        Me.colHoldrelease.Name = "colHoldrelease"
        Me.colHoldrelease.Visible = True
        Me.colHoldrelease.VisibleIndex = 6
        Me.colHoldrelease.Width = 65
        '
        'colWhoreleased
        '
        Me.colWhoreleased.Caption = "Who"
        Me.colWhoreleased.FieldName = "Whoreleased"
        Me.colWhoreleased.Name = "colWhoreleased"
        Me.colWhoreleased.Visible = True
        Me.colWhoreleased.VisibleIndex = 7
        '
        'frmEditItemDetails
        '
        Me.ClientSize = New System.Drawing.Size(931, 801)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl8)
        Me.Controls.Add(Me.GroupControl7)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl6)
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEditItemDetails"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory Item Information"
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.LotnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehousenumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarehouselocationTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitsremainingTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemstatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvitemnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.VendornameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangeableponumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PodateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PonumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.WorkordercustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllocateddateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllocateddocumentTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.ReceiveddateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverdocumentTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverdocumenttypeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceivernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.ShiptocustomerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentdateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippeddateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShipmentnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvTx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvPhys, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRecvHold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rbtnReturn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnMarkShipped As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnMarkAvailable As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnMarkQuarantine As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnMarkDepleted As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnConvertFGtoRM As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnConvertRMtoFG As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LotnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WarehousenumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WarehouselocationTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitsremainingTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContainerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ItemstatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ClassdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InvitemnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents VendornameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChangeableponumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PodateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PonumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents WorkordercustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkordernumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AllocateddateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AllocateddocumentTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ReceiveddateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ReceiverdocumentTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ReceiverdocumenttypeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ReceivernumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ShiptocustomerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipmentdateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShippeddateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ShipmentnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnUpdateLotNumber As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnMarkInProcess As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsInvTx As System.Windows.Forms.BindingSource
    Friend WithEvents bsInvPhys As System.Windows.Forms.BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxtime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxwho As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxtype As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProdordernum As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsused As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents colPHYSINVKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxtime1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxwho1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvitemnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsentered As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsoriginal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxtype1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTxreason As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnChangeItemStatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnConvertItemClass As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents bsRecvHold As BindingSource
    Friend CustomDevExGridView1 As CustomDevExGridView
    Friend WithEvents colPrioritemstatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReasoncode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReasontext As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResolutioncode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResolutiontext As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoldtime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHoldrelease As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWhoreleased As DevExpress.XtraGrid.Columns.GridColumn
End Class
