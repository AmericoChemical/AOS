<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditMaterialProductLink

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
        Dim MpnoteLabel As System.Windows.Forms.Label
        Dim MaterialidLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim PriorityLabel As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsProductList = New System.Windows.Forms.BindingSource(Me.components)
        Me.MpnoteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.MaterialidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eMaterialDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eProduct = New DevExpress.XtraEditors.LookUpEdit()
        Me.PriorityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        ProductidLabel = New System.Windows.Forms.Label()
        MpnoteLabel = New System.Windows.Forms.Label()
        MaterialidLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        PriorityLabel = New System.Windows.Forms.Label()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MpnoteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMaterialDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PriorityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(15, 164)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(44, 13)
        ProductidLabel.TabIndex = 4
        ProductidLabel.Text = "Product"
        '
        'MpnoteLabel
        '
        MpnoteLabel.AutoSize = True
        MpnoteLabel.Location = New System.Drawing.Point(15, 216)
        MpnoteLabel.Name = "MpnoteLabel"
        MpnoteLabel.Size = New System.Drawing.Size(35, 13)
        MpnoteLabel.TabIndex = 8
        MpnoteLabel.Text = "Notes"
        '
        'MaterialidLabel
        '
        MaterialidLabel.AutoSize = True
        MaterialidLabel.Location = New System.Drawing.Point(15, 112)
        MaterialidLabel.Name = "MaterialidLabel"
        MaterialidLabel.Size = New System.Drawing.Size(59, 13)
        MaterialidLabel.TabIndex = 0
        MaterialidLabel.Text = "Material ID"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(15, 138)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 13)
        Label1.TabIndex = 2
        Label1.Text = "Material Desc"
        '
        'PriorityLabel
        '
        PriorityLabel.AutoSize = True
        PriorityLabel.Location = New System.Drawing.Point(15, 190)
        PriorityLabel.Name = "PriorityLabel"
        PriorityLabel.Size = New System.Drawing.Size(41, 13)
        PriorityLabel.TabIndex = 6
        PriorityLabel.Text = "Priority"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Materialproduct)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(480, 116)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 0
        Me.btnNewCostRecord.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Id = 1
        Me.btnEditCostRecord.ImageOptions.Image = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Id = 2
        Me.btnDeleteCostRecord.ImageOptions.Image = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.CancelChanges
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
        'bsProductList
        '
        Me.bsProductList.DataSource = GetType(AOS.BusinessObjects.ViewProductExcludeMaterialProductCollection)
        '
        'MpnoteTextEdit
        '
        Me.MpnoteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Mpnote", True))
        Me.MpnoteTextEdit.Location = New System.Drawing.Point(92, 213)
        Me.MpnoteTextEdit.Name = "MpnoteTextEdit"
        Me.MpnoteTextEdit.Size = New System.Drawing.Size(280, 20)
        Me.MpnoteTextEdit.TabIndex = 9
        '
        'MaterialidTextEdit
        '
        Me.MaterialidTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Materialid", True))
        Me.MaterialidTextEdit.Location = New System.Drawing.Point(92, 109)
        Me.MaterialidTextEdit.Name = "MaterialidTextEdit"
        Me.MaterialidTextEdit.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.MaterialidTextEdit.Properties.Appearance.Options.UseBackColor = True
        Me.MaterialidTextEdit.Properties.ReadOnly = True
        Me.MaterialidTextEdit.Size = New System.Drawing.Size(57, 20)
        Me.MaterialidTextEdit.TabIndex = 1
        Me.MaterialidTextEdit.TabStop = False
        '
        'eMaterialDesc
        '
        Me.eMaterialDesc.Location = New System.Drawing.Point(92, 135)
        Me.eMaterialDesc.Name = "eMaterialDesc"
        Me.eMaterialDesc.Properties.ReadOnly = True
        Me.eMaterialDesc.Size = New System.Drawing.Size(280, 20)
        Me.eMaterialDesc.TabIndex = 3
        Me.eMaterialDesc.TabStop = False
        '
        'eProduct
        '
        Me.eProduct.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Productid", True))
        Me.eProduct.Location = New System.Drawing.Point(92, 161)
        Me.eProduct.MenuManager = Me.RibbonControl1
        Me.eProduct.Name = "eProduct"
        Me.eProduct.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProduct.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Prod ID", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Units", "Units", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc2", "Addl Desc", 140, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eProduct.Properties.DataSource = Me.bsProductList
        Me.eProduct.Properties.DisplayMember = "Productdesc"
        Me.eProduct.Properties.NullText = ""
        Me.eProduct.Properties.PopupWidth = 510
        Me.eProduct.Properties.ShowFooter = False
        Me.eProduct.Properties.ValueMember = "Productid"
        Me.eProduct.Size = New System.Drawing.Size(280, 20)
        Me.eProduct.TabIndex = 5
        '
        'PriorityTextEdit
        '
        Me.PriorityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Priority", True))
        Me.PriorityTextEdit.Location = New System.Drawing.Point(92, 187)
        Me.PriorityTextEdit.Name = "PriorityTextEdit"
        Me.PriorityTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriorityTextEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PriorityTextEdit.Properties.Mask.EditMask = "d"
        Me.PriorityTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.PriorityTextEdit.Properties.MaxLength = 9
        Me.PriorityTextEdit.Size = New System.Drawing.Size(64, 20)
        Me.PriorityTextEdit.TabIndex = 7
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(163, 177)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(209, 41)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Enter a Priority of ""0"" to prevent pulling Finished Goods into Raw Material Inven" &
    "tory"
        '
        'frmAddEditMaterialProductLink
        '
        Me.ClientSize = New System.Drawing.Size(480, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.eProduct)
        Me.Controls.Add(Me.MpnoteTextEdit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(PriorityLabel)
        Me.Controls.Add(Me.PriorityTextEdit)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.eMaterialDesc)
        Me.Controls.Add(MaterialidLabel)
        Me.Controls.Add(Me.MaterialidTextEdit)
        Me.Controls.Add(MpnoteLabel)
        Me.Controls.Add(ProductidLabel)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditMaterialProductLink"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Material Product Link Information"
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MpnoteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMaterialDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProduct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PriorityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsProductList As System.Windows.Forms.BindingSource
    Friend WithEvents MpnoteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MaterialidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eMaterialDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProduct As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents PriorityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
