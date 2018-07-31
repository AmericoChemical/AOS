<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditPurchaseRequest

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
        Dim UnitcostLabel As System.Windows.Forms.Label
        Dim PurchReqDateLabel As System.Windows.Forms.Label
        Dim DateNeededLabel As System.Windows.Forms.Label
        Dim QtyContainersLabel As System.Windows.Forms.Label
        Dim ProductIDLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProductDesc = New DevExpress.XtraEditors.TextEdit()
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.eContainer = New DevExpress.XtraEditors.TextEdit()
        Me.bsProducts = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.QtyContainersTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eUOM = New DevExpress.XtraEditors.TextEdit()
        Me.eUnits = New DevExpress.XtraEditors.TextEdit()
        Me.eProductID = New DevExpress.XtraEditors.LookUpEdit()
        Me.PurchReqDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.DateNeededDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsVendors = New System.Windows.Forms.BindingSource(Me.components)
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        UnitcostLabel = New System.Windows.Forms.Label()
        PurchReqDateLabel = New System.Windows.Forms.Label()
        DateNeededLabel = New System.Windows.Forms.Label()
        QtyContainersLabel = New System.Windows.Forms.Label()
        ProductIDLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyContainersTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchReqDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchReqDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateNeededDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateNeededDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UnitcostLabel
        '
        UnitcostLabel.AutoSize = True
        UnitcostLabel.Location = New System.Drawing.Point(344, 193)
        UnitcostLabel.Name = "UnitcostLabel"
        UnitcostLabel.Size = New System.Drawing.Size(31, 13)
        UnitcostLabel.TabIndex = 31
        UnitcostLabel.Text = "Units"
        '
        'PurchReqDateLabel
        '
        PurchReqDateLabel.AutoSize = True
        PurchReqDateLabel.Location = New System.Drawing.Point(14, 115)
        PurchReqDateLabel.Name = "PurchReqDateLabel"
        PurchReqDateLabel.Size = New System.Drawing.Size(86, 13)
        PurchReqDateLabel.TabIndex = 31
        PurchReqDateLabel.Text = "Purch Req Date:"
        '
        'DateNeededLabel
        '
        DateNeededLabel.AutoSize = True
        DateNeededLabel.Location = New System.Drawing.Point(250, 115)
        DateNeededLabel.Name = "DateNeededLabel"
        DateNeededLabel.Size = New System.Drawing.Size(74, 13)
        DateNeededLabel.TabIndex = 32
        DateNeededLabel.Text = "Date Needed:"
        '
        'QtyContainersLabel
        '
        QtyContainersLabel.AutoSize = True
        QtyContainersLabel.Location = New System.Drawing.Point(16, 141)
        QtyContainersLabel.Name = "QtyContainersLabel"
        QtyContainersLabel.Size = New System.Drawing.Size(84, 13)
        QtyContainersLabel.TabIndex = 33
        QtyContainersLabel.Text = "Qty Containers:"
        '
        'ProductIDLabel1
        '
        ProductIDLabel1.AutoSize = True
        ProductIDLabel1.Location = New System.Drawing.Point(52, 167)
        ProductIDLabel1.Name = "ProductIDLabel1"
        ProductIDLabel1.Size = New System.Drawing.Size(48, 13)
        ProductIDLabel1.TabIndex = 34
        ProductIDLabel1.Text = "Product:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(253, 193)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(30, 13)
        Label1.TabIndex = 38
        Label1.Text = "UOM"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(104, 193)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(54, 13)
        Label2.TabIndex = 39
        Label2.Text = "Container"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(43, 278)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(57, 13)
        Label3.TabIndex = 42
        Label3.Text = "Customer:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(33, 304)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(67, 13)
        Label4.TabIndex = 44
        Label4.Text = "Req Vendor:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(60, 227)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(40, 13)
        Label5.TabIndex = 46
        Label5.Text = "WO #:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(28, 252)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(72, 13)
        Label6.TabIndex = 49
        Label6.Text = "Prod Order#:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProductDesc
        '
        Me.eProductDesc.Location = New System.Drawing.Point(164, 164)
        Me.eProductDesc.Name = "eProductDesc"
        Me.eProductDesc.Properties.ReadOnly = True
        Me.eProductDesc.Size = New System.Drawing.Size(266, 20)
        Me.eProductDesc.TabIndex = 0
        Me.eProductDesc.TabStop = False
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.PurchaseRequest)
        '
        'eContainer
        '
        Me.eContainer.Location = New System.Drawing.Point(164, 190)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.Appearance.Options.UseTextOptions = True
        Me.eContainer.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eContainer.Properties.DisplayFormat.FormatString = "c2"
        Me.eContainer.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eContainer.Properties.ReadOnly = True
        Me.eContainer.Size = New System.Drawing.Size(83, 20)
        Me.eContainer.TabIndex = 1
        Me.eContainer.TabStop = False
        '
        'bsProducts
        '
        Me.bsProducts.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(450, 93)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 0
        Me.btnNewCostRecord.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCostRecord.Id = 1
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCostRecord.Id = 2
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
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
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
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
        'QtyContainersTextEdit
        '
        Me.QtyContainersTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "QtyContainers", True))
        Me.QtyContainersTextEdit.Location = New System.Drawing.Point(106, 138)
        Me.QtyContainersTextEdit.Name = "QtyContainersTextEdit"
        Me.QtyContainersTextEdit.Size = New System.Drawing.Size(52, 20)
        Me.QtyContainersTextEdit.TabIndex = 2
        '
        'eUOM
        '
        Me.eUOM.Location = New System.Drawing.Point(290, 190)
        Me.eUOM.Name = "eUOM"
        Me.eUOM.Properties.Appearance.Options.UseTextOptions = True
        Me.eUOM.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eUOM.Properties.DisplayFormat.FormatString = "c2"
        Me.eUOM.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eUOM.Properties.ReadOnly = True
        Me.eUOM.Size = New System.Drawing.Size(48, 20)
        Me.eUOM.TabIndex = 36
        Me.eUOM.TabStop = False
        '
        'eUnits
        '
        Me.eUnits.Location = New System.Drawing.Point(379, 190)
        Me.eUnits.Name = "eUnits"
        Me.eUnits.Properties.Appearance.Options.UseTextOptions = True
        Me.eUnits.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eUnits.Properties.DisplayFormat.FormatString = "c2"
        Me.eUnits.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eUnits.Properties.ReadOnly = True
        Me.eUnits.Size = New System.Drawing.Size(51, 20)
        Me.eUnits.TabIndex = 37
        Me.eUnits.TabStop = False
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "ProductID", True))
        Me.eProductID.Location = New System.Drawing.Point(106, 164)
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Units", "Units", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProductID.Properties.DataSource = Me.bsProducts
        Me.eProductID.Properties.DisplayMember = "Productid"
        Me.eProductID.Properties.DropDownRows = 15
        Me.eProductID.Properties.NullText = ""
        Me.eProductID.Properties.PopupWidth = 400
        Me.eProductID.Properties.ShowFooter = False
        Me.eProductID.Properties.ValueMember = "Productid"
        Me.eProductID.Size = New System.Drawing.Size(52, 20)
        Me.eProductID.TabIndex = 3
        '
        'PurchReqDateDateEdit
        '
        Me.PurchReqDateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "PurchReqDate", True))
        Me.PurchReqDateDateEdit.EditValue = Nothing
        Me.PurchReqDateDateEdit.Location = New System.Drawing.Point(106, 112)
        Me.PurchReqDateDateEdit.Name = "PurchReqDateDateEdit"
        Me.PurchReqDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PurchReqDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.PurchReqDateDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.PurchReqDateDateEdit.TabIndex = 0
        '
        'DateNeededDateEdit
        '
        Me.DateNeededDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "DateNeeded", True))
        Me.DateNeededDateEdit.EditValue = Nothing
        Me.DateNeededDateEdit.Location = New System.Drawing.Point(330, 112)
        Me.DateNeededDateEdit.Name = "DateNeededDateEdit"
        Me.DateNeededDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateNeededDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.DateNeededDateEdit.Size = New System.Drawing.Size(100, 20)
        Me.DateNeededDateEdit.TabIndex = 1
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'bsVendors
        '
        Me.bsVendors.DataSource = GetType(AOS.BusinessObjects.VendorCollection)
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "CustID", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(106, 275)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipcity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custshipstateprov", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit1.Properties.DataSource = Me.bsCustomers
        Me.LookUpEdit1.Properties.DisplayMember = "Custname"
        Me.LookUpEdit1.Properties.DropDownRows = 15
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.PopupWidth = 350
        Me.LookUpEdit1.Properties.ShowFooter = False
        Me.LookUpEdit1.Properties.ValueMember = "Custid"
        Me.LookUpEdit1.Size = New System.Drawing.Size(324, 20)
        Me.LookUpEdit1.TabIndex = 5
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "VendorID", True))
        Me.LookUpEdit2.Location = New System.Drawing.Point(106, 301)
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Vendorname", "Vendor Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit2.Properties.DataSource = Me.bsVendors
        Me.LookUpEdit2.Properties.DisplayMember = "Vendorname"
        Me.LookUpEdit2.Properties.DropDownRows = 15
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.PopupWidth = 200
        Me.LookUpEdit2.Properties.ShowFooter = False
        Me.LookUpEdit2.Properties.ValueMember = "Vendorid"
        Me.LookUpEdit2.Size = New System.Drawing.Size(324, 20)
        Me.LookUpEdit2.TabIndex = 6
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "WorkOrderNumber", True))
        Me.TextEdit1.Location = New System.Drawing.Point(106, 224)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(52, 20)
        Me.TextEdit1.TabIndex = 4
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "ProdOrderNum", True))
        Me.TextEdit2.Location = New System.Drawing.Point(106, 249)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(52, 20)
        Me.TextEdit2.TabIndex = 48
        '
        'frmAddEditPurchaseRequest
        '
        Me.ClientSize = New System.Drawing.Size(450, 340)
        Me.ControlBox = False
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.LookUpEdit2)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.eUnits)
        Me.Controls.Add(Me.eUOM)
        Me.Controls.Add(ProductIDLabel1)
        Me.Controls.Add(QtyContainersLabel)
        Me.Controls.Add(Me.QtyContainersTextEdit)
        Me.Controls.Add(DateNeededLabel)
        Me.Controls.Add(PurchReqDateLabel)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.eContainer)
        Me.Controls.Add(Me.eProductDesc)
        Me.Controls.Add(UnitcostLabel)
        Me.Controls.Add(Me.eProductID)
        Me.Controls.Add(Me.PurchReqDateDateEdit)
        Me.Controls.Add(Me.DateNeededDateEdit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditPurchaseRequest"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Purchase Request Information"
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyContainersTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchReqDateDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchReqDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateNeededDateEdit.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateNeededDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProducts As System.Windows.Forms.BindingSource
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents eProductDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents QtyContainersTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PurchReqDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents DateNeededDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents bsVendors As System.Windows.Forms.BindingSource
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
End Class
