<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditAPISInput

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
        Dim MaterialidLabel As System.Windows.Forms.Label
        Dim MaterialnoteLabel As System.Windows.Forms.Label
        Dim UomLabel As System.Windows.Forms.Label
        Dim QtyunitsLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
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
        Me.MaterialidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsMaterials = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaterialnoteTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UomTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.QtyunitsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eVolumeQty = New DevExpress.XtraEditors.TextEdit()
        Me.eWeightQty = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.LookUpEdit2 = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsVolumeUOM = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsWeightUOM = New System.Windows.Forms.BindingSource(Me.components)
        MaterialidLabel = New System.Windows.Forms.Label()
        MaterialnoteLabel = New System.Windows.Forms.Label()
        UomLabel = New System.Windows.Forms.Label()
        QtyunitsLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMaterials, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaterialnoteTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UomTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QtyunitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVolumeQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWeightQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVolumeUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsWeightUOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialidLabel
        '
        MaterialidLabel.AutoSize = True
        MaterialidLabel.Location = New System.Drawing.Point(182, 109)
        MaterialidLabel.Name = "MaterialidLabel"
        MaterialidLabel.Size = New System.Drawing.Size(126, 13)
        MaterialidLabel.TabIndex = 5
        MaterialidLabel.Text = "Material Item Description"
        '
        'MaterialnoteLabel
        '
        MaterialnoteLabel.AutoSize = True
        MaterialnoteLabel.Location = New System.Drawing.Point(12, 240)
        MaterialnoteLabel.Name = "MaterialnoteLabel"
        MaterialnoteLabel.Size = New System.Drawing.Size(105, 13)
        MaterialnoteLabel.TabIndex = 6
        MaterialnoteLabel.Text = "Material Input Notes"
        '
        'UomLabel
        '
        UomLabel.AutoSize = True
        UomLabel.Location = New System.Drawing.Point(76, 109)
        UomLabel.Name = "UomLabel"
        UomLabel.Size = New System.Drawing.Size(83, 13)
        UomLabel.TabIndex = 8
        UomLabel.Text = "Unit of Measure"
        '
        'QtyunitsLabel
        '
        QtyunitsLabel.AutoSize = True
        QtyunitsLabel.Location = New System.Drawing.Point(12, 109)
        QtyunitsLabel.Name = "QtyunitsLabel"
        QtyunitsLabel.Size = New System.Drawing.Size(49, 13)
        QtyunitsLabel.TabIndex = 9
        QtyunitsLabel.Text = "Quantity"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 175)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(42, 13)
        Label1.TabIndex = 13
        Label1.Text = "Vol Qty"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(76, 175)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(83, 13)
        Label2.TabIndex = 12
        Label2.Text = "Unit of Measure"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(182, 175)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(48, 13)
        Label3.TabIndex = 17
        Label3.Text = "Wgt Qty"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(246, 175)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(83, 13)
        Label4.TabIndex = 16
        Label4.Text = "Unit of Measure"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Apisitem)
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
        Me.RibbonControl1.Size = New System.Drawing.Size(549, 95)
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
        'MaterialidLookUpEdit
        '
        Me.MaterialidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Materialid", True))
        Me.MaterialidLookUpEdit.Location = New System.Drawing.Point(185, 125)
        Me.MaterialidLookUpEdit.MenuManager = Me.RibbonControl1
        Me.MaterialidLookUpEdit.Name = "MaterialidLookUpEdit"
        Me.MaterialidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.MaterialidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialid", "Mat ID", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialdesc", "Description", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialuom", "UOM", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Materialstatus", "Status", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.MaterialidLookUpEdit.Properties.DataSource = Me.bsMaterials
        Me.MaterialidLookUpEdit.Properties.DisplayMember = "Materialdesc"
        Me.MaterialidLookUpEdit.Properties.DropDownRows = 10
        Me.MaterialidLookUpEdit.Properties.NullText = ""
        Me.MaterialidLookUpEdit.Properties.PopupWidth = 350
        Me.MaterialidLookUpEdit.Properties.ValueMember = "Materialid"
        Me.MaterialidLookUpEdit.Size = New System.Drawing.Size(350, 20)
        Me.MaterialidLookUpEdit.TabIndex = 2
        '
        'bsMaterials
        '
        Me.bsMaterials.DataSource = GetType(AOS.BusinessObjects.MaterialCollection)
        '
        'MaterialnoteTextEdit
        '
        Me.MaterialnoteTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Apisitemnote", True))
        Me.MaterialnoteTextEdit.Location = New System.Drawing.Point(15, 256)
        Me.MaterialnoteTextEdit.MenuManager = Me.RibbonControl1
        Me.MaterialnoteTextEdit.Name = "MaterialnoteTextEdit"
        Me.MaterialnoteTextEdit.Size = New System.Drawing.Size(520, 20)
        Me.MaterialnoteTextEdit.TabIndex = 7
        '
        'UomTextEdit
        '
        Me.UomTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Uom", True))
        Me.UomTextEdit.Location = New System.Drawing.Point(79, 125)
        Me.UomTextEdit.MenuManager = Me.RibbonControl1
        Me.UomTextEdit.Name = "UomTextEdit"
        Me.UomTextEdit.Size = New System.Drawing.Size(80, 20)
        Me.UomTextEdit.TabIndex = 1
        '
        'QtyunitsTextEdit
        '
        Me.QtyunitsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Qtyunits", True))
        Me.QtyunitsTextEdit.Location = New System.Drawing.Point(15, 125)
        Me.QtyunitsTextEdit.MenuManager = Me.RibbonControl1
        Me.QtyunitsTextEdit.Name = "QtyunitsTextEdit"
        Me.QtyunitsTextEdit.Size = New System.Drawing.Size(58, 20)
        Me.QtyunitsTextEdit.TabIndex = 0
        '
        'eVolumeQty
        '
        Me.eVolumeQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Volumeqty", True))
        Me.eVolumeQty.Location = New System.Drawing.Point(15, 191)
        Me.eVolumeQty.MenuManager = Me.RibbonControl1
        Me.eVolumeQty.Name = "eVolumeQty"
        Me.eVolumeQty.Size = New System.Drawing.Size(58, 20)
        Me.eVolumeQty.TabIndex = 3
        '
        'eWeightQty
        '
        Me.eWeightQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Weightqty", True))
        Me.eWeightQty.Location = New System.Drawing.Point(185, 191)
        Me.eWeightQty.MenuManager = Me.RibbonControl1
        Me.eWeightQty.Name = "eWeightQty"
        Me.eWeightQty.Size = New System.Drawing.Size(58, 20)
        Me.eWeightQty.TabIndex = 5
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Volumeuom", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(79, 191)
        Me.LookUpEdit1.MenuManager = Me.RibbonControl1
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "Uom", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit1.Properties.DataSource = Me.bsVolumeUOM
        Me.LookUpEdit1.Properties.DisplayMember = "Uom"
        Me.LookUpEdit1.Properties.DropDownRows = 10
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.PopupWidth = 350
        Me.LookUpEdit1.Properties.ValueMember = "Uom"
        Me.LookUpEdit1.Size = New System.Drawing.Size(80, 20)
        Me.LookUpEdit1.TabIndex = 4
        '
        'LookUpEdit2
        '
        Me.LookUpEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsItem, "Weightuom", True))
        Me.LookUpEdit2.Location = New System.Drawing.Point(249, 191)
        Me.LookUpEdit2.MenuManager = Me.RibbonControl1
        Me.LookUpEdit2.Name = "LookUpEdit2"
        Me.LookUpEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit2.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "Uom", 44, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit2.Properties.DataSource = Me.bsWeightUOM
        Me.LookUpEdit2.Properties.DisplayMember = "Uom"
        Me.LookUpEdit2.Properties.DropDownRows = 10
        Me.LookUpEdit2.Properties.NullText = ""
        Me.LookUpEdit2.Properties.PopupWidth = 350
        Me.LookUpEdit2.Properties.ValueMember = "Uom"
        Me.LookUpEdit2.Size = New System.Drawing.Size(80, 20)
        Me.LookUpEdit2.TabIndex = 6
        '
        'bsVolumeUOM
        '
        Me.bsVolumeUOM.DataSource = GetType(AOS.BusinessObjects.ViewUOMByVolumeCollection)
        '
        'bsWeightUOM
        '
        Me.bsWeightUOM.DataSource = GetType(AOS.BusinessObjects.ViewUOMByWeightCollection)
        '
        'frmAddEditAPISInput
        '
        Me.ClientSize = New System.Drawing.Size(549, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.LookUpEdit2)
        Me.Controls.Add(Me.LookUpEdit1)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.eWeightQty)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.eVolumeQty)
        Me.Controls.Add(Label2)
        Me.Controls.Add(QtyunitsLabel)
        Me.Controls.Add(Me.QtyunitsTextEdit)
        Me.Controls.Add(UomLabel)
        Me.Controls.Add(Me.UomTextEdit)
        Me.Controls.Add(MaterialnoteLabel)
        Me.Controls.Add(Me.MaterialnoteTextEdit)
        Me.Controls.Add(MaterialidLabel)
        Me.Controls.Add(Me.MaterialidLookUpEdit)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditAPISInput"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "APIS Material Input Information"
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMaterials, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaterialnoteTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UomTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QtyunitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVolumeQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWeightQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVolumeUOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsWeightUOM, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MaterialidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsMaterials As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialnoteTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UomTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents QtyunitsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eVolumeQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eWeightQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookUpEdit2 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsVolumeUOM As BindingSource
    Friend WithEvents bsWeightUOM As BindingSource
End Class
