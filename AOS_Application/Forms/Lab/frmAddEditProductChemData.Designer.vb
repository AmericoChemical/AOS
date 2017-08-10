<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditProductChemData

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
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim ProductdescLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim FireLabel As System.Windows.Forms.Label
        Dim HealthLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim IsactiveLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer()
        Me.eProductID = New DevExpress.XtraEditors.TextEdit()
        Me.bs = New System.Windows.Forms.BindingSource()
        Me.ProductdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ePHHigh = New DevExpress.XtraEditors.TextEdit()
        Me.eSGHigh = New DevExpress.XtraEditors.TextEdit()
        Me.eSGLow = New DevExpress.XtraEditors.TextEdit()
        Me.ePHLow = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemWeekOfMonth1 = New DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth()
        Me.RepositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.IsactiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsShelfLife = New System.Windows.Forms.BindingSource()
        Me.TextEdit4 = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsClarity = New System.Windows.Forms.BindingSource()
        Me.bsColor = New System.Windows.Forms.BindingSource()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        ProductidLabel = New System.Windows.Forms.Label()
        ProductdescLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        FireLabel = New System.Windows.Forms.Label()
        HealthLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        IsactiveLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePHHigh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSGHigh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSGLow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePHLow.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsShelfLife, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClarity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(19, 33)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(58, 13)
        ProductidLabel.TabIndex = 1
        ProductidLabel.Text = "Product ID"
        '
        'ProductdescLabel
        '
        ProductdescLabel.AutoSize = True
        ProductdescLabel.Location = New System.Drawing.Point(19, 61)
        ProductdescLabel.Name = "ProductdescLabel"
        ProductdescLabel.Size = New System.Drawing.Size(60, 13)
        ProductdescLabel.TabIndex = 3
        ProductdescLabel.Text = "Description"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(19, 112)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 5
        ContainerLabel.Text = "Container"
        '
        'FireLabel
        '
        FireLabel.AutoSize = True
        FireLabel.Location = New System.Drawing.Point(19, 110)
        FireLabel.Name = "FireLabel"
        FireLabel.Size = New System.Drawing.Size(81, 13)
        FireLabel.TabIndex = 34
        FireLabel.Text = "Specific Gravity"
        '
        'HealthLabel
        '
        HealthLabel.AutoSize = True
        HealthLabel.Location = New System.Drawing.Point(19, 84)
        HealthLabel.Name = "HealthLabel"
        HealthLabel.Size = New System.Drawing.Size(54, 13)
        HealthLabel.TabIndex = 35
        HealthLabel.Text = "pH Range"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(19, 87)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 13)
        Label1.TabIndex = 37
        Label1.Text = "Additional Desc"
        '
        'IsactiveLabel
        '
        IsactiveLabel.AutoSize = True
        IsactiveLabel.Location = New System.Drawing.Point(415, 35)
        IsactiveLabel.Name = "IsactiveLabel"
        IsactiveLabel.Size = New System.Drawing.Size(37, 13)
        IsactiveLabel.TabIndex = 37
        IsactiveLabel.Text = "Active"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(19, 61)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(91, 13)
        Label2.TabIndex = 36
        Label2.Text = "Product Defaults:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(146, 61)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(26, 13)
        Label3.TabIndex = 1
        Label3.Text = "Low"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(213, 61)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(28, 13)
        Label4.TabIndex = 38
        Label4.Text = "High"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(19, 36)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(88, 13)
        Label5.TabIndex = 39
        Label5.Text = "Testing Required"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(19, 150)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(51, 13)
        Label6.TabIndex = 42
        Label6.Text = "Shelf Life"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Productid", True))
        Me.eProductID.Location = New System.Drawing.Point(133, 30)
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.ReadOnly = True
        Me.eProductID.Size = New System.Drawing.Size(51, 20)
        Me.eProductID.TabIndex = 0
        Me.eProductID.TabStop = False
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'ProductdescTextEdit
        '
        Me.ProductdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Productdesc", True))
        Me.ProductdescTextEdit.Location = New System.Drawing.Point(133, 58)
        Me.ProductdescTextEdit.Name = "ProductdescTextEdit"
        Me.ProductdescTextEdit.Properties.ReadOnly = True
        Me.ProductdescTextEdit.Size = New System.Drawing.Size(336, 20)
        Me.ProductdescTextEdit.TabIndex = 1
        Me.ProductdescTextEdit.TabStop = False
        '
        'ePHHigh
        '
        Me.ePHHigh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Phrangehigh", True))
        Me.ePHHigh.Location = New System.Drawing.Point(200, 81)
        Me.ePHHigh.Name = "ePHHigh"
        Me.ePHHigh.Size = New System.Drawing.Size(51, 20)
        Me.ePHHigh.TabIndex = 3
        '
        'eSGHigh
        '
        Me.eSGHigh.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Sgrangehigh", True))
        Me.eSGHigh.Location = New System.Drawing.Point(200, 107)
        Me.eSGHigh.Name = "eSGHigh"
        Me.eSGHigh.Properties.DisplayFormat.FormatString = "n3"
        Me.eSGHigh.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eSGHigh.Properties.EditFormat.FormatString = "n3"
        Me.eSGHigh.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eSGHigh.Size = New System.Drawing.Size(51, 20)
        Me.eSGHigh.TabIndex = 5
        '
        'eSGLow
        '
        Me.eSGLow.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Sgrangelow", True))
        Me.eSGLow.Location = New System.Drawing.Point(133, 107)
        Me.eSGLow.Name = "eSGLow"
        Me.eSGLow.Properties.DisplayFormat.FormatString = "n3"
        Me.eSGLow.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eSGLow.Properties.EditFormat.FormatString = "n3"
        Me.eSGLow.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eSGLow.Size = New System.Drawing.Size(51, 20)
        Me.eSGLow.TabIndex = 4
        '
        'ePHLow
        '
        Me.ePHLow.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Phrangelow", True))
        Me.ePHLow.Location = New System.Drawing.Point(133, 81)
        Me.ePHLow.Name = "ePHLow"
        Me.ePHLow.Properties.DisplayFormat.FormatString = "n2"
        Me.ePHLow.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ePHLow.Properties.EditFormat.FormatString = "n2"
        Me.ePHLow.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ePHLow.Size = New System.Drawing.Size(51, 20)
        Me.ePHLow.TabIndex = 2
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 24
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemWeekOfMonth1, Me.RepositoryItemAppointmentLabel1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(499, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save  Changes"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Changes"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        '
        'RepositoryItemWeekOfMonth1
        '
        Me.RepositoryItemWeekOfMonth1.AutoHeight = False
        Me.RepositoryItemWeekOfMonth1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemWeekOfMonth1.Name = "RepositoryItemWeekOfMonth1"
        '
        'RepositoryItemAppointmentLabel1
        '
        Me.RepositoryItemAppointmentLabel1.AutoHeight = False
        Me.RepositoryItemAppointmentLabel1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemAppointmentLabel1.Name = "RepositoryItemAppointmentLabel1"
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Desc2", True))
        Me.TextEdit1.Location = New System.Drawing.Point(133, 84)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(336, 20)
        Me.TextEdit1.TabIndex = 2
        Me.TextEdit1.TabStop = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(IsactiveLabel)
        Me.GroupControl1.Controls.Add(Me.IsactiveCheckEdit)
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Controls.Add(ProductidLabel)
        Me.GroupControl1.Controls.Add(Me.ProductdescTextEdit)
        Me.GroupControl1.Controls.Add(ProductdescLabel)
        Me.GroupControl1.Controls.Add(ContainerLabel)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 101)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(480, 141)
        Me.GroupControl1.TabIndex = 60
        Me.GroupControl1.Text = "Product Information"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Container", True))
        Me.TextEdit2.Location = New System.Drawing.Point(133, 109)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(118, 20)
        Me.TextEdit2.TabIndex = 39
        Me.TextEdit2.TabStop = False
        '
        'IsactiveCheckEdit
        '
        Me.IsactiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Isactive", True))
        Me.IsactiveCheckEdit.Location = New System.Drawing.Point(454, 32)
        Me.IsactiveCheckEdit.MenuManager = Me.RibbonControl1
        Me.IsactiveCheckEdit.Name = "IsactiveCheckEdit"
        Me.IsactiveCheckEdit.Properties.Caption = ""
        Me.IsactiveCheckEdit.Properties.ReadOnly = True
        Me.IsactiveCheckEdit.Size = New System.Drawing.Size(22, 19)
        Me.IsactiveCheckEdit.TabIndex = 38
        Me.IsactiveCheckEdit.TabStop = False
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Label8)
        Me.GroupControl3.Controls.Add(Label7)
        Me.GroupControl3.Controls.Add(Me.LookUpEdit1)
        Me.GroupControl3.Controls.Add(Label6)
        Me.GroupControl3.Controls.Add(Label5)
        Me.GroupControl3.Controls.Add(Me.CheckEdit1)
        Me.GroupControl3.Controls.Add(Label4)
        Me.GroupControl3.Controls.Add(Label3)
        Me.GroupControl3.Controls.Add(Label2)
        Me.GroupControl3.Controls.Add(HealthLabel)
        Me.GroupControl3.Controls.Add(Me.ePHLow)
        Me.GroupControl3.Controls.Add(FireLabel)
        Me.GroupControl3.Controls.Add(Me.eSGLow)
        Me.GroupControl3.Controls.Add(Me.eSGHigh)
        Me.GroupControl3.Controls.Add(Me.ePHHigh)
        Me.GroupControl3.Controls.Add(Me.TextEdit3)
        Me.GroupControl3.Controls.Add(Me.TextEdit4)
        Me.GroupControl3.Location = New System.Drawing.Point(9, 248)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(480, 188)
        Me.GroupControl3.TabIndex = 62
        Me.GroupControl3.Text = "Chemical Data"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Needstesting", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(131, 33)
        Me.CheckEdit1.MenuManager = Me.RibbonControl1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = ""
        Me.CheckEdit1.Size = New System.Drawing.Size(22, 19)
        Me.CheckEdit1.TabIndex = 0
        Me.CheckEdit1.TabStop = False
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Shelflife", True))
        Me.TextEdit3.Location = New System.Drawing.Point(133, 147)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextEdit3.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Shelflife", "Shelf Life", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.TextEdit3.Properties.DataSource = Me.bsShelfLife
        Me.TextEdit3.Properties.DisplayMember = "Shelflife"
        Me.TextEdit3.Properties.NullText = ""
        Me.TextEdit3.Properties.PopupSizeable = False
        Me.TextEdit3.Properties.PopupWidth = 118
        Me.TextEdit3.Properties.ShowFooter = False
        Me.TextEdit3.Properties.ShowHeader = False
        Me.TextEdit3.Properties.ValueMember = "Shelflife"
        Me.TextEdit3.Size = New System.Drawing.Size(118, 20)
        Me.TextEdit3.TabIndex = 6
        '
        'bsShelfLife
        '
        Me.bsShelfLife.DataSource = GetType(AOS.BusinessObjects.ListShelflifeCollection)
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Chemicalcolor", True))
        Me.TextEdit4.Location = New System.Drawing.Point(325, 81)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TextEdit4.Properties.DataSource = Me.bsColor
        Me.TextEdit4.Properties.DisplayMember = "Color"
        Me.TextEdit4.Properties.DropDownRows = 15
        Me.TextEdit4.Properties.NullText = ""
        Me.TextEdit4.Properties.ShowFooter = False
        Me.TextEdit4.Properties.ShowHeader = False
        Me.TextEdit4.Properties.ValueMember = "Color"
        Me.TextEdit4.Size = New System.Drawing.Size(113, 20)
        Me.TextEdit4.TabIndex = 43
        '
        'bsClarity
        '
        Me.bsClarity.DataSource = GetType(AOS.BusinessObjects.ListChemicalclarityCollection)
        '
        'bsColor
        '
        Me.bsColor.DataSource = GetType(AOS.BusinessObjects.ListChemicalcolorCollection)
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Chemicalclarity", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(325, 107)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DataSource = Me.bsClarity
        Me.LookUpEdit1.Properties.DisplayMember = "Clarity"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ShowFooter = False
        Me.LookUpEdit1.Properties.ShowHeader = False
        Me.LookUpEdit1.Properties.ValueMember = "Clarity"
        Me.LookUpEdit1.Size = New System.Drawing.Size(113, 20)
        Me.LookUpEdit1.TabIndex = 44
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(281, 84)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(32, 13)
        Label7.TabIndex = 45
        Label7.Text = "Color"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(281, 110)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(38, 13)
        Label8.TabIndex = 46
        Label8.Text = "Clarity"
        '
        'frmAddEditProductChemData
        '
        Me.ClientSize = New System.Drawing.Size(499, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditProductChemData"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Chemical Information"
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePHHigh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eSGHigh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eSGLow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePHLow.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsShelfLife, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClarity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents eProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePHHigh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eSGHigh As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eSGLow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePHLow As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents IsactiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RepositoryItemWeekOfMonth1 As DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth
    Friend WithEvents RepositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsShelfLife As System.Windows.Forms.BindingSource
    Friend WithEvents bsClarity As System.Windows.Forms.BindingSource
    Friend WithEvents bsColor As System.Windows.Forms.BindingSource
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
End Class
