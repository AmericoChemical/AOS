<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditBDFInvoiceItem

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
        Dim QtycontainersLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsBDFItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.eQuantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.eWeightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eRateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eExtPriceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eServiceDescMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        QtycontainersLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.bsBDFItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eQuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWeightTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eExtPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eServiceDescMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QtycontainersLabel
        '
        QtycontainersLabel.AutoSize = True
        QtycontainersLabel.Location = New System.Drawing.Point(44, 117)
        QtycontainersLabel.Name = "QtycontainersLabel"
        QtycontainersLabel.Size = New System.Drawing.Size(49, 13)
        QtycontainersLabel.TabIndex = 28
        QtycontainersLabel.Text = "Quantity"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(25, 168)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(68, 13)
        Label1.TabIndex = 42
        Label1.Text = "Service Desc"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(52, 231)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(41, 13)
        Label2.TabIndex = 44
        Label2.Text = "Weight"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(63, 257)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(30, 13)
        Label3.TabIndex = 46
        Label3.Text = "Rate"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(44, 283)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(49, 13)
        Label4.TabIndex = 48
        Label4.Text = "Ext Price"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsBDFItem
        '
        Me.bsBDFItem.DataSource = GetType(AOS.BusinessObjects.BDFInvoiceItem)
        '
        'eQuantityTextEdit
        '
        Me.eQuantityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFItem, "Quantity", True))
        Me.eQuantityTextEdit.Location = New System.Drawing.Point(99, 114)
        Me.eQuantityTextEdit.Name = "eQuantityTextEdit"
        Me.eQuantityTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.eQuantityTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eQuantityTextEdit.Properties.DisplayFormat.FormatString = "d"
        Me.eQuantityTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eQuantityTextEdit.Properties.ReadOnly = True
        Me.eQuantityTextEdit.Size = New System.Drawing.Size(72, 20)
        Me.eQuantityTextEdit.TabIndex = 26
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
        Me.RibbonControl1.Size = New System.Drawing.Size(429, 96)
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
        'eWeightTextEdit
        '
        Me.eWeightTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFItem, "Weight", True))
        Me.eWeightTextEdit.Location = New System.Drawing.Point(99, 228)
        Me.eWeightTextEdit.Name = "eWeightTextEdit"
        Me.eWeightTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.eWeightTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eWeightTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eWeightTextEdit.Size = New System.Drawing.Size(72, 20)
        Me.eWeightTextEdit.TabIndex = 43
        '
        'eRateTextEdit
        '
        Me.eRateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFItem, "Rate", True))
        Me.eRateTextEdit.Location = New System.Drawing.Point(99, 254)
        Me.eRateTextEdit.Name = "eRateTextEdit"
        Me.eRateTextEdit.Properties.ReadOnly = True
        Me.eRateTextEdit.Size = New System.Drawing.Size(167, 20)
        Me.eRateTextEdit.TabIndex = 45
        '
        'eExtPriceTextEdit
        '
        Me.eExtPriceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFItem, "ExtPrice", True))
        Me.eExtPriceTextEdit.Location = New System.Drawing.Point(99, 280)
        Me.eExtPriceTextEdit.Name = "eExtPriceTextEdit"
        Me.eExtPriceTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.eExtPriceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eExtPriceTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.eExtPriceTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eExtPriceTextEdit.Properties.ReadOnly = True
        Me.eExtPriceTextEdit.Size = New System.Drawing.Size(72, 20)
        Me.eExtPriceTextEdit.TabIndex = 47
        '
        'eServiceDescMemoEdit
        '
        Me.eServiceDescMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsBDFItem, "ServiceDesc", True))
        Me.eServiceDescMemoEdit.Location = New System.Drawing.Point(99, 141)
        Me.eServiceDescMemoEdit.Name = "eServiceDescMemoEdit"
        Me.eServiceDescMemoEdit.Size = New System.Drawing.Size(311, 81)
        Me.eServiceDescMemoEdit.TabIndex = 50
        Me.eServiceDescMemoEdit.UseOptimizedRendering = True
        '
        'frmAddEditBDFInvoiceItem
        '
        Me.ClientSize = New System.Drawing.Size(429, 346)
        Me.ControlBox = False
        Me.Controls.Add(Me.eServiceDescMemoEdit)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.eExtPriceTextEdit)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.eRateTextEdit)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.eWeightTextEdit)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(QtycontainersLabel)
        Me.Controls.Add(Me.eQuantityTextEdit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditBDFInvoiceItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BDF Invoice Item Information"
        CType(Me.bsBDFItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eQuantityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWeightTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eRateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eExtPriceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eServiceDescMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsBDFItem As System.Windows.Forms.BindingSource
    Friend WithEvents eQuantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eWeightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eRateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eExtPriceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eServiceDescMemoEdit As DevExpress.XtraEditors.MemoEdit
End Class
