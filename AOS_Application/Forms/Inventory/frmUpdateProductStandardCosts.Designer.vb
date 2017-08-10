<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdateProductStandardCosts


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
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim ProductdescLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim WeightuomLabel As System.Windows.Forms.Label
        Dim WeightunitsLabel As System.Windows.Forms.Label
        Dim VolumeuomLabel As System.Windows.Forms.Label
        Dim VolumeunitsLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateProductStandardCosts))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProductidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.eReason = New DevExpress.XtraEditors.TextEdit()
        Me.btnRecalcWeightCost = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRecalcVolumeCost = New DevExpress.XtraEditors.SimpleButton()
        Me.eWgtUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.eVolUnitCost = New DevExpress.XtraEditors.TextEdit()
        Me.eWgtUOM = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsUOMWeight = New System.Windows.Forms.BindingSource(Me.components)
        Me.eWgtUnits = New DevExpress.XtraEditors.TextEdit()
        Me.eVolUOM = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsUOMVolume = New System.Windows.Forms.BindingSource(Me.components)
        Me.eVolUnits = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        ProductidLabel = New System.Windows.Forms.Label()
        ProductdescLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        WeightuomLabel = New System.Windows.Forms.Label()
        WeightunitsLabel = New System.Windows.Forms.Label()
        VolumeuomLabel = New System.Windows.Forms.Label()
        VolumeunitsLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.ProductidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.eReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWgtUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVolUnitCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWgtUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWgtUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVolUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVolUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(12, 26)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(43, 13)
        ProductidLabel.TabIndex = 0
        ProductidLabel.Text = "Prod ID"
        '
        'ProductdescLabel
        '
        ProductdescLabel.AutoSize = True
        ProductdescLabel.Location = New System.Drawing.Point(68, 26)
        ProductdescLabel.Name = "ProductdescLabel"
        ProductdescLabel.Size = New System.Drawing.Size(100, 13)
        ProductdescLabel.TabIndex = 2
        ProductdescLabel.Text = "Product Description"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(285, 26)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(54, 13)
        Label6.TabIndex = 4
        Label6.Text = "Container"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(207, 108)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(51, 13)
        Label11.TabIndex = 23
        Label11.Text = "Unit Cost"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(12, 108)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(51, 13)
        Label10.TabIndex = 15
        Label10.Text = "Unit Cost"
        '
        'WeightuomLabel
        '
        WeightuomLabel.AutoSize = True
        WeightuomLabel.Location = New System.Drawing.Point(207, 82)
        WeightuomLabel.Name = "WeightuomLabel"
        WeightuomLabel.Size = New System.Drawing.Size(30, 13)
        WeightuomLabel.TabIndex = 21
        WeightuomLabel.Text = "UOM"
        '
        'WeightunitsLabel
        '
        WeightunitsLabel.AutoSize = True
        WeightunitsLabel.Location = New System.Drawing.Point(207, 56)
        WeightunitsLabel.Name = "WeightunitsLabel"
        WeightunitsLabel.Size = New System.Drawing.Size(31, 13)
        WeightunitsLabel.TabIndex = 19
        WeightunitsLabel.Text = "Units"
        '
        'VolumeuomLabel
        '
        VolumeuomLabel.AutoSize = True
        VolumeuomLabel.Location = New System.Drawing.Point(14, 82)
        VolumeuomLabel.Name = "VolumeuomLabel"
        VolumeuomLabel.Size = New System.Drawing.Size(30, 13)
        VolumeuomLabel.TabIndex = 13
        VolumeuomLabel.Text = "UOM"
        '
        'VolumeunitsLabel
        '
        VolumeunitsLabel.AutoSize = True
        VolumeunitsLabel.Location = New System.Drawing.Point(14, 56)
        VolumeunitsLabel.Name = "VolumeunitsLabel"
        VolumeunitsLabel.Size = New System.Drawing.Size(31, 13)
        VolumeunitsLabel.TabIndex = 11
        VolumeunitsLabel.Text = "Units"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(12, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(148, 13)
        Label1.TabIndex = 26
        Label1.Text = "VOLUME STANDARD COST"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label2.Location = New System.Drawing.Point(207, 33)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(148, 13)
        Label2.TabIndex = 27
        Label2.Text = "WEIGHT STANDARD COST"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(12, 175)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(217, 13)
        Label3.TabIndex = 29
        Label3.Text = "Reason for Product Standard Cost Changes"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ProductidTextEdit
        '
        Me.ProductidTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Productid", True))
        Me.ProductidTextEdit.Location = New System.Drawing.Point(15, 42)
        Me.ProductidTextEdit.Name = "ProductidTextEdit"
        Me.ProductidTextEdit.Properties.ReadOnly = True
        Me.ProductidTextEdit.Size = New System.Drawing.Size(49, 20)
        Me.ProductidTextEdit.TabIndex = 1
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'ProductdescTextEdit
        '
        Me.ProductdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Productdesc", True))
        Me.ProductdescTextEdit.Location = New System.Drawing.Point(71, 42)
        Me.ProductdescTextEdit.Name = "ProductdescTextEdit"
        Me.ProductdescTextEdit.Properties.ReadOnly = True
        Me.ProductdescTextEdit.Size = New System.Drawing.Size(211, 20)
        Me.ProductdescTextEdit.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Label3)
        Me.GroupControl2.Controls.Add(Me.eReason)
        Me.GroupControl2.Controls.Add(Label2)
        Me.GroupControl2.Controls.Add(Label1)
        Me.GroupControl2.Controls.Add(Me.btnRecalcWeightCost)
        Me.GroupControl2.Controls.Add(Me.btnRecalcVolumeCost)
        Me.GroupControl2.Controls.Add(Label11)
        Me.GroupControl2.Controls.Add(Label10)
        Me.GroupControl2.Controls.Add(Me.eWgtUnitCost)
        Me.GroupControl2.Controls.Add(Me.eVolUnitCost)
        Me.GroupControl2.Controls.Add(WeightuomLabel)
        Me.GroupControl2.Controls.Add(Me.eWgtUOM)
        Me.GroupControl2.Controls.Add(WeightunitsLabel)
        Me.GroupControl2.Controls.Add(Me.eWgtUnits)
        Me.GroupControl2.Controls.Add(VolumeuomLabel)
        Me.GroupControl2.Controls.Add(Me.eVolUOM)
        Me.GroupControl2.Controls.Add(VolumeunitsLabel)
        Me.GroupControl2.Controls.Add(Me.eVolUnits)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 171)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(388, 231)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Product Cost Information"
        '
        'eReason
        '
        Me.eReason.Location = New System.Drawing.Point(15, 191)
        Me.eReason.Name = "eReason"
        Me.eReason.Size = New System.Drawing.Size(355, 20)
        Me.eReason.TabIndex = 28
        '
        'btnRecalcWeightCost
        '
        Me.btnRecalcWeightCost.Location = New System.Drawing.Point(15, 132)
        Me.btnRecalcWeightCost.Name = "btnRecalcWeightCost"
        Me.btnRecalcWeightCost.Size = New System.Drawing.Size(155, 23)
        Me.btnRecalcWeightCost.TabIndex = 17
        Me.btnRecalcWeightCost.Text = "Recalc Weight Cost"
        '
        'btnRecalcVolumeCost
        '
        Me.btnRecalcVolumeCost.Location = New System.Drawing.Point(210, 132)
        Me.btnRecalcVolumeCost.Name = "btnRecalcVolumeCost"
        Me.btnRecalcVolumeCost.Size = New System.Drawing.Size(160, 23)
        Me.btnRecalcVolumeCost.TabIndex = 25
        Me.btnRecalcVolumeCost.Text = "Recalc Volume Cost"
        '
        'eWgtUnitCost
        '
        Me.eWgtUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Weightstandardcost", True))
        Me.eWgtUnitCost.EditValue = ""
        Me.eWgtUnitCost.Location = New System.Drawing.Point(295, 105)
        Me.eWgtUnitCost.Name = "eWgtUnitCost"
        Me.eWgtUnitCost.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eWgtUnitCost.Properties.MaxLength = 19
        Me.eWgtUnitCost.Size = New System.Drawing.Size(75, 20)
        Me.eWgtUnitCost.TabIndex = 24
        '
        'eVolUnitCost
        '
        Me.eVolUnitCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Volumestandardcost", True))
        Me.eVolUnitCost.EditValue = ""
        Me.eVolUnitCost.Location = New System.Drawing.Point(95, 105)
        Me.eVolUnitCost.Name = "eVolUnitCost"
        Me.eVolUnitCost.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eVolUnitCost.Properties.MaxLength = 19
        Me.eVolUnitCost.Size = New System.Drawing.Size(75, 20)
        Me.eVolUnitCost.TabIndex = 16
        '
        'eWgtUOM
        '
        Me.eWgtUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Weightuom", True))
        Me.eWgtUOM.Location = New System.Drawing.Point(295, 79)
        Me.eWgtUOM.Name = "eWgtUOM"
        Me.eWgtUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eWgtUOM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eWgtUOM.Properties.DataSource = Me.bsUOMWeight
        Me.eWgtUOM.Properties.DisplayMember = "Uom"
        Me.eWgtUOM.Properties.NullText = ""
        Me.eWgtUOM.Properties.PopupWidth = 51
        Me.eWgtUOM.Properties.ShowFooter = False
        Me.eWgtUOM.Properties.ShowHeader = False
        Me.eWgtUOM.Properties.ValueMember = "Uom"
        Me.eWgtUOM.Size = New System.Drawing.Size(75, 20)
        Me.eWgtUOM.TabIndex = 22
        '
        'bsUOMWeight
        '
        Me.bsUOMWeight.DataSource = GetType(AOS.BusinessObjects.ViewUOMByWeightCollection)
        '
        'eWgtUnits
        '
        Me.eWgtUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Weightunits", True))
        Me.eWgtUnits.EditValue = ""
        Me.eWgtUnits.Location = New System.Drawing.Point(295, 53)
        Me.eWgtUnits.Name = "eWgtUnits"
        Me.eWgtUnits.Size = New System.Drawing.Size(75, 20)
        Me.eWgtUnits.TabIndex = 20
        '
        'eVolUOM
        '
        Me.eVolUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Volumeuom", True))
        Me.eVolUOM.Location = New System.Drawing.Point(95, 79)
        Me.eVolUOM.Name = "eVolUOM"
        Me.eVolUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eVolUOM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eVolUOM.Properties.DataSource = Me.bsUOMVolume
        Me.eVolUOM.Properties.DisplayMember = "Uom"
        Me.eVolUOM.Properties.NullText = ""
        Me.eVolUOM.Properties.PopupWidth = 51
        Me.eVolUOM.Properties.ShowFooter = False
        Me.eVolUOM.Properties.ShowHeader = False
        Me.eVolUOM.Properties.ValueMember = "Uom"
        Me.eVolUOM.Size = New System.Drawing.Size(75, 20)
        Me.eVolUOM.TabIndex = 14
        '
        'bsUOMVolume
        '
        Me.bsUOMVolume.DataSource = GetType(AOS.BusinessObjects.ViewUOMByVolumeCollection)
        '
        'eVolUnits
        '
        Me.eVolUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Volumeunits", True))
        Me.eVolUnits.EditValue = ""
        Me.eVolUnits.Location = New System.Drawing.Point(95, 53)
        Me.eVolUnits.Name = "eVolUnits"
        Me.eVolUnits.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eVolUnits.Size = New System.Drawing.Size(75, 20)
        Me.eVolUnits.TabIndex = 12
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnSave, Me.rbtnCancel, Me.btnAlterAdd, Me.btnAlterEdit, Me.btnAlterDelete})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 28
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(388, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnSave
        '
        Me.rbtnSave.Caption = "Save"
        Me.rbtnSave.Id = 4
        Me.rbtnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.rbtnSave.Name = "rbtnSave"
        Me.rbtnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'rbtnCancel
        '
        Me.rbtnCancel.Caption = "Cancel"
        Me.rbtnCancel.Id = 5
        Me.rbtnCancel.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.rbtnCancel.Name = "rbtnCancel"
        Me.rbtnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAlterAdd
        '
        Me.btnAlterAdd.Caption = "Add New Comp Alternate"
        Me.btnAlterAdd.Id = 24
        Me.btnAlterAdd.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAlterAdd.Name = "btnAlterAdd"
        '
        'btnAlterEdit
        '
        Me.btnAlterEdit.Caption = "Edit Comp Alternate"
        Me.btnAlterEdit.Glyph = Global.AOS.My.Resources.Resources.document_edit__2_
        Me.btnAlterEdit.Id = 25
        Me.btnAlterEdit.Name = "btnAlterEdit"
        '
        'btnAlterDelete
        '
        Me.btnAlterDelete.Caption = "Delete Comp alternate"
        Me.btnAlterDelete.Glyph = CType(resources.GetObject("btnAlterDelete.Glyph"), System.Drawing.Image)
        Me.btnAlterDelete.Id = 26
        Me.btnAlterDelete.Name = "btnAlterDelete"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProduct, "Container", True))
        Me.TextEdit2.Location = New System.Drawing.Point(288, 42)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(82, 20)
        Me.TextEdit2.TabIndex = 5
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ProductdescTextEdit)
        Me.GroupControl1.Controls.Add(Me.ProductidTextEdit)
        Me.GroupControl1.Controls.Add(Label6)
        Me.GroupControl1.Controls.Add(ProductidLabel)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(ProductdescLabel)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(388, 76)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Product Information"
        '
        'frmUpdateProductStandardCosts
        '
        Me.ClientSize = New System.Drawing.Size(388, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmUpdateProductStandardCosts"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Standard Costs"
        CType(Me.ProductidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.eReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWgtUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVolUnitCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWgtUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWgtUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVolUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVolUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents ProductidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eWgtUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eVolUnitCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eWgtUOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eWgtUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eVolUOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsUOMVolume As System.Windows.Forms.BindingSource
    Friend WithEvents bsUOMWeight As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents rbtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnRecalcWeightCost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnRecalcVolumeCost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eVolUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eReason As DevExpress.XtraEditors.TextEdit
End Class
