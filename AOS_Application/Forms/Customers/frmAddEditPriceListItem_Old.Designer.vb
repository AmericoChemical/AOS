<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditPriceListItem_Old

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
        Dim PricelistidLabel As System.Windows.Forms.Label
        Dim EffectivedateLabel As System.Windows.Forms.Label
        Dim UnitsLabel As System.Windows.Forms.Label
        Dim UomLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim UnitpriceLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim TaxableLabel As System.Windows.Forms.Label
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProductID = New DevExpress.XtraEditors.LookUpEdit()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProductList = New System.Windows.Forms.BindingSource(Me.components)
        Me.eEffectiveDate = New DevExpress.XtraEditors.DateEdit()
        Me.UnitsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UomTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContainerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnitpriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CustidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCustomerList = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaxableCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        PricelistidLabel = New System.Windows.Forms.Label()
        EffectivedateLabel = New System.Windows.Forms.Label()
        UnitsLabel = New System.Windows.Forms.Label()
        UomLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        UnitpriceLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        TaxableLabel = New System.Windows.Forms.Label()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eEffectiveDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eEffectiveDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UomTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitpriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TaxableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PricelistidLabel
        '
        PricelistidLabel.AutoSize = True
        PricelistidLabel.Location = New System.Drawing.Point(12, 45)
        PricelistidLabel.Name = "PricelistidLabel"
        PricelistidLabel.Size = New System.Drawing.Size(44, 13)
        PricelistidLabel.TabIndex = 1
        PricelistidLabel.Text = "Product"
        '
        'EffectivedateLabel
        '
        EffectivedateLabel.AutoSize = True
        EffectivedateLabel.Location = New System.Drawing.Point(11, 175)
        EffectivedateLabel.Name = "EffectivedateLabel"
        EffectivedateLabel.Size = New System.Drawing.Size(76, 13)
        EffectivedateLabel.TabIndex = 5
        EffectivedateLabel.Text = "Effective Date"
        '
        'UnitsLabel
        '
        UnitsLabel.AutoSize = True
        UnitsLabel.Location = New System.Drawing.Point(11, 123)
        UnitsLabel.Name = "UnitsLabel"
        UnitsLabel.Size = New System.Drawing.Size(92, 13)
        UnitsLabel.TabIndex = 15
        UnitsLabel.Text = "Units in Container"
        '
        'UomLabel
        '
        UomLabel.AutoSize = True
        UomLabel.Location = New System.Drawing.Point(11, 97)
        UomLabel.Name = "UomLabel"
        UomLabel.Size = New System.Drawing.Size(83, 13)
        UomLabel.TabIndex = 16
        UomLabel.Text = "Unit of Measure"
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(11, 71)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 17
        ContainerLabel.Text = "Container"
        '
        'UnitpriceLabel
        '
        UnitpriceLabel.AutoSize = True
        UnitpriceLabel.Location = New System.Drawing.Point(11, 149)
        UnitpriceLabel.Name = "UnitpriceLabel"
        UnitpriceLabel.Size = New System.Drawing.Size(52, 13)
        UnitpriceLabel.TabIndex = 19
        UnitpriceLabel.Text = "Unit Price"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 19)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(53, 13)
        Label1.TabIndex = 21
        Label1.Text = "Customer"
        '
        'TaxableLabel
        '
        TaxableLabel.AutoSize = True
        TaxableLabel.Location = New System.Drawing.Point(11, 201)
        TaxableLabel.Name = "TaxableLabel"
        TaxableLabel.Size = New System.Drawing.Size(45, 13)
        TaxableLabel.TabIndex = 23
        TaxableLabel.Text = "Taxable"
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnSave)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 225)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(452, 39)
        Me.PanelControl1.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(258, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(352, 8)
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
        Me.LabelControl1.Size = New System.Drawing.Size(452, 2)
        Me.LabelControl1.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Productid", True))
        Me.eProductID.Location = New System.Drawing.Point(119, 42)
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProductID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProductID.Properties.DataSource = Me.bsProductList
        Me.eProductID.Properties.DisplayMember = "Productdesc"
        Me.eProductID.Properties.DropDownRows = 20
        Me.eProductID.Properties.NullText = ""
        Me.eProductID.Properties.PopupWidth = 275
        Me.eProductID.Properties.ShowFooter = False
        Me.eProductID.Properties.ValueMember = "Productid"
        Me.eProductID.Size = New System.Drawing.Size(305, 20)
        Me.eProductID.TabIndex = 0
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.Pricelist)
        '
        'bsProductList
        '
        Me.bsProductList.DataSource = GetType(AOS.BusinessObjects.ProductCollection)
        '
        'eEffectiveDate
        '
        Me.eEffectiveDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Effectivedate", True))
        Me.eEffectiveDate.EditValue = Nothing
        Me.eEffectiveDate.Location = New System.Drawing.Point(119, 172)
        Me.eEffectiveDate.Name = "eEffectiveDate"
        Me.eEffectiveDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eEffectiveDate.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.eEffectiveDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.eEffectiveDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eEffectiveDate.Size = New System.Drawing.Size(86, 20)
        Me.eEffectiveDate.TabIndex = 7
        '
        'UnitsTextEdit
        '
        Me.UnitsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Units", True))
        Me.UnitsTextEdit.Location = New System.Drawing.Point(119, 120)
        Me.UnitsTextEdit.Name = "UnitsTextEdit"
        Me.UnitsTextEdit.Properties.ReadOnly = True
        Me.UnitsTextEdit.Size = New System.Drawing.Size(46, 20)
        Me.UnitsTextEdit.TabIndex = 3
        '
        'UomTextEdit
        '
        Me.UomTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Uom", True))
        Me.UomTextEdit.Location = New System.Drawing.Point(119, 94)
        Me.UomTextEdit.Name = "UomTextEdit"
        Me.UomTextEdit.Properties.ReadOnly = True
        Me.UomTextEdit.Size = New System.Drawing.Size(46, 20)
        Me.UomTextEdit.TabIndex = 2
        '
        'ContainerTextEdit
        '
        Me.ContainerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Container", True))
        Me.ContainerTextEdit.Location = New System.Drawing.Point(119, 68)
        Me.ContainerTextEdit.Name = "ContainerTextEdit"
        Me.ContainerTextEdit.Properties.ReadOnly = True
        Me.ContainerTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ContainerTextEdit.TabIndex = 1
        '
        'UnitpriceTextEdit
        '
        Me.UnitpriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Unitprice", True))
        Me.UnitpriceTextEdit.Location = New System.Drawing.Point(119, 146)
        Me.UnitpriceTextEdit.Name = "UnitpriceTextEdit"
        Me.UnitpriceTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.UnitpriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.UnitpriceTextEdit.Properties.DisplayFormat.FormatString = "c2"
        Me.UnitpriceTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.UnitpriceTextEdit.Size = New System.Drawing.Size(86, 20)
        Me.UnitpriceTextEdit.TabIndex = 5
        '
        'CustidLookUpEdit
        '
        Me.CustidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Custid", True))
        Me.CustidLookUpEdit.Location = New System.Drawing.Point(119, 16)
        Me.CustidLookUpEdit.Name = "CustidLookUpEdit"
        Me.CustidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Custname", 54, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CustidLookUpEdit.Properties.DataSource = Me.bsCustomerList
        Me.CustidLookUpEdit.Properties.DisplayMember = "Custname"
        Me.CustidLookUpEdit.Properties.NullText = ""
        Me.CustidLookUpEdit.Properties.ReadOnly = True
        Me.CustidLookUpEdit.Properties.ShowFooter = False
        Me.CustidLookUpEdit.Properties.ShowHeader = False
        Me.CustidLookUpEdit.Properties.ShowLines = False
        Me.CustidLookUpEdit.Properties.ShowPopupShadow = False
        Me.CustidLookUpEdit.Properties.ValueMember = "Custid"
        Me.CustidLookUpEdit.Size = New System.Drawing.Size(305, 20)
        Me.CustidLookUpEdit.TabIndex = 22
        '
        'bsCustomerList
        '
        Me.bsCustomerList.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'TaxableCheckEdit
        '
        Me.TaxableCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Taxable", True))
        Me.TaxableCheckEdit.Location = New System.Drawing.Point(117, 198)
        Me.TaxableCheckEdit.Name = "TaxableCheckEdit"
        Me.TaxableCheckEdit.Properties.Caption = ""
        Me.TaxableCheckEdit.Properties.ValueGrayed = True
        Me.TaxableCheckEdit.Size = New System.Drawing.Size(29, 19)
        Me.TaxableCheckEdit.TabIndex = 24
        '
        'frmAddEditPriceListItem_Old
        '
        Me.ClientSize = New System.Drawing.Size(452, 264)
        Me.ControlBox = False
        Me.Controls.Add(TaxableLabel)
        Me.Controls.Add(Me.TaxableCheckEdit)
        Me.Controls.Add(Me.CustidLookUpEdit)
        Me.Controls.Add(Label1)
        Me.Controls.Add(UnitpriceLabel)
        Me.Controls.Add(Me.UnitpriceTextEdit)
        Me.Controls.Add(ContainerLabel)
        Me.Controls.Add(Me.ContainerTextEdit)
        Me.Controls.Add(UomLabel)
        Me.Controls.Add(Me.UomTextEdit)
        Me.Controls.Add(UnitsLabel)
        Me.Controls.Add(Me.UnitsTextEdit)
        Me.Controls.Add(EffectivedateLabel)
        Me.Controls.Add(Me.eEffectiveDate)
        Me.Controls.Add(PricelistidLabel)
        Me.Controls.Add(Me.eProductID)
        Me.Controls.Add(Me.PanelControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditPriceListItem_Old"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Edit Information"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eEffectiveDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eEffectiveDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UomTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitpriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TaxableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents eProductID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eEffectiveDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents UnitsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UomTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContainerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnitpriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsProductList As System.Windows.Forms.BindingSource
    Friend WithEvents CustidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsCustomerList As System.Windows.Forms.BindingSource
    Friend WithEvents TaxableCheckEdit As DevExpress.XtraEditors.CheckEdit
End Class
