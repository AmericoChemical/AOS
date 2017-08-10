<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdatePriceListItem

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
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim ProductdescLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim TaxableLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim ProductidLabel1 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim VolumeunitsLabel As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim VolumeuomLabel As System.Windows.Forms.Label
        Dim WeightunitsLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim WeightuomLabel As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProductidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProductdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.eConsignment = New DevExpress.XtraEditors.CheckEdit()
        Me.eStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.btnRecalcWeightCost = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRecalcVolumeCost = New DevExpress.XtraEditors.SimpleButton()
        Me.VolumeunitsSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VolumeuomLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.WeightTextPrice = New DevExpress.XtraEditors.TextEdit()
        Me.WeightunitsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VolumeTextPrice = New DevExpress.XtraEditors.TextEdit()
        Me.WeightuomLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.PricingMethodLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TaxableCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.eContainerPrice = New DevExpress.XtraEditors.TextEdit()
        Me.eChangeDate = New DevExpress.XtraEditors.DateEdit()
        Me.eUnits = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.pnlProductSelection = New DevExpress.XtraEditors.PanelControl()
        Me.eProductLookup = New DevExpress.XtraEditors.LookUpEdit()
        Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPrice = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsStatusCodes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsUOMVolume = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsUOMWeight = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPricingMethod = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProductList = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomer = New System.Windows.Forms.BindingSource(Me.components)
        ProductidLabel = New System.Windows.Forms.Label()
        ProductdescLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        TaxableLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        ProductidLabel1 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        VolumeunitsLabel = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        VolumeuomLabel = New System.Windows.Forms.Label()
        WeightunitsLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        WeightuomLabel = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.ProductidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.eConsignment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeunitsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeuomLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightTextPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightunitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VolumeTextPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeightuomLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PricingMethodLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainerPrice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChangeDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChangeDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.pnlProductSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProductSelection.SuspendLayout()
        CType(Me.eProductLookup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl3.SuspendLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStatusCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPricingMethod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(9, 3)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(43, 13)
        ProductidLabel.TabIndex = 0
        ProductidLabel.Text = "Prod ID"
        '
        'ProductdescLabel
        '
        ProductdescLabel.AutoSize = True
        ProductdescLabel.Location = New System.Drawing.Point(64, 3)
        ProductdescLabel.Name = "ProductdescLabel"
        ProductdescLabel.Size = New System.Drawing.Size(100, 13)
        ProductdescLabel.TabIndex = 2
        ProductdescLabel.Text = "Product Description"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(1, 189)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(92, 13)
        Label1.TabIndex = 18
        Label1.Text = "Units in Container"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(190, 162)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(76, 13)
        Label4.TabIndex = 24
        Label4.Text = "Effective Date"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(271, 3)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(54, 13)
        Label6.TabIndex = 4
        Label6.Text = "Container"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(9, 14)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(53, 13)
        Label7.TabIndex = 0
        Label7.Text = "Customer"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(14, 212)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(80, 13)
        Label3.TabIndex = 20
        Label3.Text = "Container Price"
        '
        'TaxableLabel
        '
        TaxableLabel.AutoSize = True
        TaxableLabel.Location = New System.Drawing.Point(223, 189)
        TaxableLabel.Name = "TaxableLabel"
        TaxableLabel.Size = New System.Drawing.Size(45, 13)
        TaxableLabel.TabIndex = 26
        TaxableLabel.Text = "Taxable"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(172, 212)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(94, 13)
        Label8.TabIndex = 28
        Label8.Text = "Units or Container"
        '
        'ProductidLabel1
        '
        ProductidLabel1.AutoSize = True
        ProductidLabel1.Location = New System.Drawing.Point(9, 3)
        ProductidLabel1.Name = "ProductidLabel1"
        ProductidLabel1.Size = New System.Drawing.Size(63, 13)
        ProductidLabel1.TabIndex = 0
        ProductidLabel1.Text = "Product List"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(12, 235)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(82, 13)
        Label9.TabIndex = 22
        Label9.Text = "Cust Prod Code"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(15, 166)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(77, 13)
        Label12.TabIndex = 16
        Label12.Text = "Pricing Method"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label5.Location = New System.Drawing.Point(69, 35)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(52, 13)
        Label5.TabIndex = 0
        Label5.Text = "VOLUME"
        '
        'VolumeunitsLabel
        '
        VolumeunitsLabel.AutoSize = True
        VolumeunitsLabel.Location = New System.Drawing.Point(61, 58)
        VolumeunitsLabel.Name = "VolumeunitsLabel"
        VolumeunitsLabel.Size = New System.Drawing.Size(31, 13)
        VolumeunitsLabel.TabIndex = 1
        VolumeunitsLabel.Text = "Units"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(236, 104)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(30, 13)
        Label11.TabIndex = 13
        Label11.Text = "Price"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(62, 104)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(30, 13)
        Label10.TabIndex = 5
        Label10.Text = "Price"
        '
        'VolumeuomLabel
        '
        VolumeuomLabel.AutoSize = True
        VolumeuomLabel.Location = New System.Drawing.Point(62, 81)
        VolumeuomLabel.Name = "VolumeuomLabel"
        VolumeuomLabel.Size = New System.Drawing.Size(30, 13)
        VolumeuomLabel.TabIndex = 3
        VolumeuomLabel.Text = "UOM"
        '
        'WeightunitsLabel
        '
        WeightunitsLabel.AutoSize = True
        WeightunitsLabel.Location = New System.Drawing.Point(235, 58)
        WeightunitsLabel.Name = "WeightunitsLabel"
        WeightunitsLabel.Size = New System.Drawing.Size(31, 13)
        WeightunitsLabel.TabIndex = 9
        WeightunitsLabel.Text = "Units"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(243, 35)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 8
        Label2.Text = "WEIGHT"
        '
        'WeightuomLabel
        '
        WeightuomLabel.AutoSize = True
        WeightuomLabel.Location = New System.Drawing.Point(236, 81)
        WeightuomLabel.Name = "WeightuomLabel"
        WeightuomLabel.Size = New System.Drawing.Size(30, 13)
        WeightuomLabel.TabIndex = 11
        WeightuomLabel.Text = "UOM"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(228, 235)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(38, 13)
        Label13.TabIndex = 31
        Label13.Text = "Status"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnSave)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 445)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(370, 39)
        Me.PanelControl1.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(176, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(270, 8)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(370, 2)
        Me.LabelControl1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ProductidTextEdit
        '
        Me.ProductidTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Productid", True))
        Me.ProductidTextEdit.Location = New System.Drawing.Point(12, 19)
        Me.ProductidTextEdit.Name = "ProductidTextEdit"
        Me.ProductidTextEdit.Properties.ReadOnly = True
        Me.ProductidTextEdit.Size = New System.Drawing.Size(49, 20)
        Me.ProductidTextEdit.TabIndex = 1
        '
        'ProductdescTextEdit
        '
        Me.ProductdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Productdesc", True))
        Me.ProductdescTextEdit.Location = New System.Drawing.Point(67, 19)
        Me.ProductdescTextEdit.Name = "ProductdescTextEdit"
        Me.ProductdescTextEdit.Properties.ReadOnly = True
        Me.ProductdescTextEdit.Size = New System.Drawing.Size(201, 20)
        Me.ProductdescTextEdit.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.GroupControl2.Controls.Add(Me.CheckEdit1)
        Me.GroupControl2.Controls.Add(Me.eConsignment)
        Me.GroupControl2.Controls.Add(Label13)
        Me.GroupControl2.Controls.Add(Me.eStatus)
        Me.GroupControl2.Controls.Add(Me.btnRecalcWeightCost)
        Me.GroupControl2.Controls.Add(Me.btnRecalcVolumeCost)
        Me.GroupControl2.Controls.Add(Label5)
        Me.GroupControl2.Controls.Add(Me.VolumeunitsSpinEdit)
        Me.GroupControl2.Controls.Add(VolumeunitsLabel)
        Me.GroupControl2.Controls.Add(Label11)
        Me.GroupControl2.Controls.Add(Me.VolumeuomLookUpEdit)
        Me.GroupControl2.Controls.Add(Label10)
        Me.GroupControl2.Controls.Add(VolumeuomLabel)
        Me.GroupControl2.Controls.Add(Me.WeightTextPrice)
        Me.GroupControl2.Controls.Add(Me.WeightunitsTextEdit)
        Me.GroupControl2.Controls.Add(Me.VolumeTextPrice)
        Me.GroupControl2.Controls.Add(WeightunitsLabel)
        Me.GroupControl2.Controls.Add(Label2)
        Me.GroupControl2.Controls.Add(Me.WeightuomLookUpEdit)
        Me.GroupControl2.Controls.Add(WeightuomLabel)
        Me.GroupControl2.Controls.Add(Me.PricingMethodLookUpEdit)
        Me.GroupControl2.Controls.Add(Label12)
        Me.GroupControl2.Controls.Add(Label9)
        Me.GroupControl2.Controls.Add(Me.TextEdit5)
        Me.GroupControl2.Controls.Add(Label8)
        Me.GroupControl2.Controls.Add(Me.TextEdit4)
        Me.GroupControl2.Controls.Add(TaxableLabel)
        Me.GroupControl2.Controls.Add(Me.TaxableCheckEdit)
        Me.GroupControl2.Controls.Add(Label3)
        Me.GroupControl2.Controls.Add(Me.eContainerPrice)
        Me.GroupControl2.Controls.Add(Me.eChangeDate)
        Me.GroupControl2.Controls.Add(Me.eUnits)
        Me.GroupControl2.Controls.Add(Label4)
        Me.GroupControl2.Controls.Add(Label1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 43)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(350, 293)
        Me.GroupControl2.TabIndex = 6
        Me.GroupControl2.Text = "Price List Information"
        '
        'eConsignment
        '
        Me.eConsignment.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Isconsignment", True))
        Me.eConsignment.Location = New System.Drawing.Point(199, 258)
        Me.eConsignment.Name = "eConsignment"
        Me.eConsignment.Properties.Caption = "Consignment"
        Me.eConsignment.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eConsignment.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.eConsignment.Size = New System.Drawing.Size(85, 19)
        Me.eConsignment.TabIndex = 32
        '
        'eStatus
        '
        Me.eStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Priceliststatus", True))
        Me.eStatus.Location = New System.Drawing.Point(268, 232)
        Me.eStatus.Name = "eStatus"
        Me.eStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Priceliststatus", "Priceliststatus", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eStatus.Properties.DataSource = Me.bsStatusCodes
        Me.eStatus.Properties.DisplayMember = "Priceliststatus"
        Me.eStatus.Properties.NullText = ""
        Me.eStatus.Properties.PopupWidth = 51
        Me.eStatus.Properties.ShowFooter = False
        Me.eStatus.Properties.ShowHeader = False
        Me.eStatus.Properties.ValueMember = "Priceliststatus"
        Me.eStatus.Size = New System.Drawing.Size(75, 20)
        Me.eStatus.TabIndex = 30
        '
        'btnRecalcWeightCost
        '
        Me.btnRecalcWeightCost.Location = New System.Drawing.Point(61, 127)
        Me.btnRecalcWeightCost.Name = "btnRecalcWeightCost"
        Me.btnRecalcWeightCost.Size = New System.Drawing.Size(108, 23)
        Me.btnRecalcWeightCost.TabIndex = 7
        Me.btnRecalcWeightCost.Text = "Recalc Weight Price"
        '
        'btnRecalcVolumeCost
        '
        Me.btnRecalcVolumeCost.Location = New System.Drawing.Point(235, 127)
        Me.btnRecalcVolumeCost.Name = "btnRecalcVolumeCost"
        Me.btnRecalcVolumeCost.Size = New System.Drawing.Size(108, 23)
        Me.btnRecalcVolumeCost.TabIndex = 15
        Me.btnRecalcVolumeCost.Text = "Recalc Volume Price"
        '
        'VolumeunitsSpinEdit
        '
        Me.VolumeunitsSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Volumeunits", True))
        Me.VolumeunitsSpinEdit.EditValue = ""
        Me.VolumeunitsSpinEdit.Location = New System.Drawing.Point(94, 55)
        Me.VolumeunitsSpinEdit.Name = "VolumeunitsSpinEdit"
        Me.VolumeunitsSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.VolumeunitsSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.VolumeunitsSpinEdit.Size = New System.Drawing.Size(75, 20)
        Me.VolumeunitsSpinEdit.TabIndex = 2
        '
        'VolumeuomLookUpEdit
        '
        Me.VolumeuomLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Volumeuom", True))
        Me.VolumeuomLookUpEdit.Location = New System.Drawing.Point(94, 78)
        Me.VolumeuomLookUpEdit.Name = "VolumeuomLookUpEdit"
        Me.VolumeuomLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.VolumeuomLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.VolumeuomLookUpEdit.Properties.DataSource = Me.bsUOMVolume
        Me.VolumeuomLookUpEdit.Properties.DisplayMember = "Uom"
        Me.VolumeuomLookUpEdit.Properties.NullText = ""
        Me.VolumeuomLookUpEdit.Properties.PopupWidth = 51
        Me.VolumeuomLookUpEdit.Properties.ShowFooter = False
        Me.VolumeuomLookUpEdit.Properties.ShowHeader = False
        Me.VolumeuomLookUpEdit.Properties.ValueMember = "Uom"
        Me.VolumeuomLookUpEdit.Size = New System.Drawing.Size(75, 20)
        Me.VolumeuomLookUpEdit.TabIndex = 4
        '
        'WeightTextPrice
        '
        Me.WeightTextPrice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Weightprice", True))
        Me.WeightTextPrice.EditValue = ""
        Me.WeightTextPrice.Location = New System.Drawing.Point(268, 101)
        Me.WeightTextPrice.Name = "WeightTextPrice"
        Me.WeightTextPrice.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.WeightTextPrice.Properties.Mask.EditMask = "f4"
        Me.WeightTextPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.WeightTextPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.WeightTextPrice.Size = New System.Drawing.Size(75, 20)
        Me.WeightTextPrice.TabIndex = 14
        '
        'WeightunitsTextEdit
        '
        Me.WeightunitsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Weightunits", True))
        Me.WeightunitsTextEdit.EditValue = ""
        Me.WeightunitsTextEdit.Location = New System.Drawing.Point(268, 55)
        Me.WeightunitsTextEdit.Name = "WeightunitsTextEdit"
        Me.WeightunitsTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.WeightunitsTextEdit.Size = New System.Drawing.Size(75, 20)
        Me.WeightunitsTextEdit.TabIndex = 10
        '
        'VolumeTextPrice
        '
        Me.VolumeTextPrice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Volumeprice", True))
        Me.VolumeTextPrice.EditValue = ""
        Me.VolumeTextPrice.Location = New System.Drawing.Point(94, 101)
        Me.VolumeTextPrice.Name = "VolumeTextPrice"
        Me.VolumeTextPrice.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.VolumeTextPrice.Properties.Mask.EditMask = "f4"
        Me.VolumeTextPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.VolumeTextPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.VolumeTextPrice.Properties.MaxLength = 19
        Me.VolumeTextPrice.Size = New System.Drawing.Size(75, 20)
        Me.VolumeTextPrice.TabIndex = 6
        '
        'WeightuomLookUpEdit
        '
        Me.WeightuomLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Weightuom", True))
        Me.WeightuomLookUpEdit.Location = New System.Drawing.Point(268, 78)
        Me.WeightuomLookUpEdit.Name = "WeightuomLookUpEdit"
        Me.WeightuomLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.WeightuomLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.WeightuomLookUpEdit.Properties.DataSource = Me.bsUOMWeight
        Me.WeightuomLookUpEdit.Properties.DisplayMember = "Uom"
        Me.WeightuomLookUpEdit.Properties.NullText = ""
        Me.WeightuomLookUpEdit.Properties.PopupWidth = 51
        Me.WeightuomLookUpEdit.Properties.ShowFooter = False
        Me.WeightuomLookUpEdit.Properties.ShowHeader = False
        Me.WeightuomLookUpEdit.Properties.ValueMember = "Uom"
        Me.WeightuomLookUpEdit.Size = New System.Drawing.Size(75, 20)
        Me.WeightuomLookUpEdit.TabIndex = 12
        '
        'PricingMethodLookUpEdit
        '
        Me.PricingMethodLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Pricingmethod", True))
        Me.PricingMethodLookUpEdit.Location = New System.Drawing.Point(94, 163)
        Me.PricingMethodLookUpEdit.Name = "PricingMethodLookUpEdit"
        Me.PricingMethodLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.PricingMethodLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PricingMethod", "Pricing Method", 93, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.PricingMethodLookUpEdit.Properties.DataSource = Me.bsPricingMethod
        Me.PricingMethodLookUpEdit.Properties.DisplayMember = "PricingMethod"
        Me.PricingMethodLookUpEdit.Properties.NullText = ""
        Me.PricingMethodLookUpEdit.Properties.PopupWidth = 51
        Me.PricingMethodLookUpEdit.Properties.ShowHeader = False
        Me.PricingMethodLookUpEdit.Properties.ValueMember = "PricingMethod"
        Me.PricingMethodLookUpEdit.Size = New System.Drawing.Size(75, 20)
        Me.PricingMethodLookUpEdit.TabIndex = 17
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Customerproductcode", True))
        Me.TextEdit5.Location = New System.Drawing.Point(94, 232)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.DisplayFormat.FormatString = "c3"
        Me.TextEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit5.Size = New System.Drawing.Size(75, 20)
        Me.TextEdit5.TabIndex = 23
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Unitorcontainer", True))
        Me.TextEdit4.Location = New System.Drawing.Point(268, 209)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.DisplayFormat.FormatString = "c3"
        Me.TextEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit4.Size = New System.Drawing.Size(22, 20)
        Me.TextEdit4.TabIndex = 29
        '
        'TaxableCheckEdit
        '
        Me.TaxableCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Taxable", True))
        Me.TaxableCheckEdit.Location = New System.Drawing.Point(268, 186)
        Me.TaxableCheckEdit.Name = "TaxableCheckEdit"
        Me.TaxableCheckEdit.Properties.Caption = ""
        Me.TaxableCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.TaxableCheckEdit.TabIndex = 27
        '
        'eContainerPrice
        '
        Me.eContainerPrice.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Containerprice", True))
        Me.eContainerPrice.Enabled = False
        Me.eContainerPrice.Location = New System.Drawing.Point(94, 209)
        Me.eContainerPrice.Name = "eContainerPrice"
        Me.eContainerPrice.Properties.DisplayFormat.FormatString = "c3"
        Me.eContainerPrice.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eContainerPrice.Properties.Mask.EditMask = "f4"
        Me.eContainerPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eContainerPrice.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.eContainerPrice.Size = New System.Drawing.Size(75, 20)
        Me.eContainerPrice.TabIndex = 21
        '
        'eChangeDate
        '
        Me.eChangeDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Effectivedate", True))
        Me.eChangeDate.EditValue = Nothing
        Me.eChangeDate.Location = New System.Drawing.Point(268, 159)
        Me.eChangeDate.Name = "eChangeDate"
        Me.eChangeDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eChangeDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eChangeDate.Size = New System.Drawing.Size(75, 20)
        Me.eChangeDate.TabIndex = 25
        '
        'eUnits
        '
        Me.eUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Units", True))
        Me.eUnits.Enabled = False
        Me.eUnits.Location = New System.Drawing.Point(94, 186)
        Me.eUnits.Name = "eUnits"
        Me.eUnits.Properties.DisplayFormat.FormatString = "n0"
        Me.eUnits.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eUnits.Properties.EditFormat.FormatString = "n0"
        Me.eUnits.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eUnits.Size = New System.Drawing.Size(75, 20)
        Me.eUnits.TabIndex = 19
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Container", True))
        Me.TextEdit2.Location = New System.Drawing.Point(274, 19)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(88, 20)
        Me.TextEdit2.TabIndex = 5
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomer, "Custname", True))
        Me.TextEdit1.Location = New System.Drawing.Point(12, 30)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(350, 20)
        Me.TextEdit1.TabIndex = 1
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.TextEdit1)
        Me.PanelControl2.Controls.Add(Label7)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(370, 56)
        Me.PanelControl2.TabIndex = 0
        '
        'pnlProductSelection
        '
        Me.pnlProductSelection.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlProductSelection.Controls.Add(ProductidLabel1)
        Me.pnlProductSelection.Controls.Add(Me.eProductLookup)
        Me.pnlProductSelection.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlProductSelection.Location = New System.Drawing.Point(0, 56)
        Me.pnlProductSelection.Name = "pnlProductSelection"
        Me.pnlProductSelection.Size = New System.Drawing.Size(370, 47)
        Me.pnlProductSelection.TabIndex = 1
        '
        'eProductLookup
        '
        Me.eProductLookup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Productid", True))
        Me.eProductLookup.Location = New System.Drawing.Point(12, 19)
        Me.eProductLookup.Name = "eProductLookup"
        Me.eProductLookup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProductLookup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Description", 125, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProductLookup.Properties.DataSource = Me.bsProductList
        Me.eProductLookup.Properties.DisplayMember = "Productdesc"
        Me.eProductLookup.Properties.DropDownRows = 16
        Me.eProductLookup.Properties.NullText = "[Select a product...]"
        Me.eProductLookup.Properties.PopupWidth = 225
        Me.eProductLookup.Properties.ShowFooter = False
        Me.eProductLookup.Properties.ValueMember = "Productid"
        Me.eProductLookup.Size = New System.Drawing.Size(350, 20)
        Me.eProductLookup.TabIndex = 1
        '
        'PanelControl3
        '
        Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl3.Controls.Add(ProductidLabel)
        Me.PanelControl3.Controls.Add(Me.ProductidTextEdit)
        Me.PanelControl3.Controls.Add(Me.ProductdescTextEdit)
        Me.PanelControl3.Controls.Add(Label6)
        Me.PanelControl3.Controls.Add(ProductdescLabel)
        Me.PanelControl3.Controls.Add(Me.TextEdit2)
        Me.PanelControl3.Controls.Add(Me.GroupControl2)
        Me.PanelControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl3.Location = New System.Drawing.Point(0, 103)
        Me.PanelControl3.Name = "PanelControl3"
        Me.PanelControl3.Size = New System.Drawing.Size(370, 342)
        Me.PanelControl3.TabIndex = 2
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsPrice, "Isdirect", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(34, 258)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Direct Only"
        Me.CheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit1.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.CheckEdit1.Size = New System.Drawing.Size(76, 19)
        Me.CheckEdit1.TabIndex = 33
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'bsPrice
        '
        Me.bsPrice.DataSource = GetType(AOS.BusinessObjects.Pricelist)
        '
        'bsStatusCodes
        '
        Me.bsStatusCodes.DataSource = GetType(AOS.BusinessObjects.ListPriceliststatusCollection)
        '
        'bsUOMVolume
        '
        Me.bsUOMVolume.DataSource = GetType(AOS.BusinessObjects.ViewUOMByVolumeCollection)
        '
        'bsUOMWeight
        '
        Me.bsUOMWeight.DataSource = GetType(AOS.BusinessObjects.ViewUOMByWeightCollection)
        '
        'bsPricingMethod
        '
        Me.bsPricingMethod.DataSource = GetType(AOS.BusinessObjects.ViewPricingMethodCollection)
        '
        'bsProductList
        '
        Me.bsProductList.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'bsCustomer
        '
        Me.bsCustomer.DataSource = GetType(AOS.BusinessObjects.Customer)
        '
        'frmUpdatePriceListItem
        '
        Me.ClientSize = New System.Drawing.Size(370, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl3)
        Me.Controls.Add(Me.pnlProductSelection)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUpdatePriceListItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Edit Information"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.ProductidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.eConsignment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeunitsSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeuomLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightTextPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightunitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VolumeTextPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeightuomLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PricingMethodLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainerPrice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChangeDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChangeDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.pnlProductSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProductSelection.ResumeLayout(False)
        Me.pnlProductSelection.PerformLayout()
        CType(Me.eProductLookup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl3.ResumeLayout(False)
        Me.PanelControl3.PerformLayout()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPrice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStatusCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPricingMethod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents ProductidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsCustomer As System.Windows.Forms.BindingSource
    Friend WithEvents bsPrice As System.Windows.Forms.BindingSource
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eChangeDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainerPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TaxableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlProductSelection As DevExpress.XtraEditors.PanelControl
    Friend WithEvents eProductLookup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsProductList As System.Windows.Forms.BindingSource
    Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsUOMVolume As System.Windows.Forms.BindingSource
    Friend WithEvents bsUOMWeight As System.Windows.Forms.BindingSource
    Friend WithEvents PricingMethodLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsPricingMethod As System.Windows.Forms.BindingSource
    Friend WithEvents VolumeunitsSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VolumeuomLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents WeightTextPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WeightunitsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VolumeTextPrice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WeightuomLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnRecalcWeightCost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRecalcVolumeCost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsStatusCodes As System.Windows.Forms.BindingSource
    Friend WithEvents eConsignment As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
End Class
