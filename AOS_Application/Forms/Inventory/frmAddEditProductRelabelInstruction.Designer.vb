<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditProductRelabelInstruction

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
        Dim SequenceLabel As System.Windows.Forms.Label
        Dim RelabelInstructionLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditProductRelabelInstruction))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsProductRelabelInstruction = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RelabelInstructionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.SequenceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.eRlblProductID = New DevExpress.XtraEditors.TextEdit()
        Me.eFinalProductID = New DevExpress.XtraEditors.TextEdit()
        Me.eRlblProductDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eFinalProductDesc = New DevExpress.XtraEditors.TextEdit()
        SequenceLabel = New System.Windows.Forms.Label()
        RelabelInstructionLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.bsProductRelabelInstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelabelInstructionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SequenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eRlblProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFinalProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eRlblProductDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFinalProductDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SequenceLabel
        '
        SequenceLabel.AutoSize = True
        SequenceLabel.Location = New System.Drawing.Point(38, 164)
        SequenceLabel.Name = "SequenceLabel"
        SequenceLabel.Size = New System.Drawing.Size(58, 13)
        SequenceLabel.TabIndex = 1
        SequenceLabel.Text = "Sequence:"
        '
        'RelabelInstructionLabel
        '
        RelabelInstructionLabel.AutoSize = True
        RelabelInstructionLabel.Location = New System.Drawing.Point(33, 189)
        RelabelInstructionLabel.Name = "RelabelInstructionLabel"
        RelabelInstructionLabel.Size = New System.Drawing.Size(63, 13)
        RelabelInstructionLabel.TabIndex = 3
        RelabelInstructionLabel.Text = "Instruction:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(10, 104)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(86, 13)
        Label1.TabIndex = 6
        Label1.Text = "Relabel Product:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(23, 130)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(73, 13)
        Label2.TabIndex = 7
        Label2.Text = "Final Product:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsProductRelabelInstruction
        '
        Me.bsProductRelabelInstruction.DataSource = GetType(AOS.BusinessObjects.Productrelabelinstruction)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(477, 95)
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
        Me.btnSave.LargeImageIndex = 21
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 22
        Me.btnCancel.Name = "btnCancel"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
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
        'RelabelInstructionMemoEdit
        '
        Me.RelabelInstructionMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProductRelabelInstruction, "Relabelinstruction", True))
        Me.RelabelInstructionMemoEdit.Location = New System.Drawing.Point(102, 187)
        Me.RelabelInstructionMemoEdit.MenuManager = Me.RibbonControl1
        Me.RelabelInstructionMemoEdit.Name = "RelabelInstructionMemoEdit"
        Me.RelabelInstructionMemoEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.RelabelInstructionMemoEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RelabelInstructionMemoEdit.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.RelabelInstructionMemoEdit.Size = New System.Drawing.Size(362, 96)
        Me.RelabelInstructionMemoEdit.TabIndex = 4
        '
        'SequenceTextEdit
        '
        Me.SequenceTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsProductRelabelInstruction, "Sequence", True))
        Me.SequenceTextEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SequenceTextEdit.Location = New System.Drawing.Point(102, 161)
        Me.SequenceTextEdit.MenuManager = Me.RibbonControl1
        Me.SequenceTextEdit.Name = "SequenceTextEdit"
        Me.SequenceTextEdit.Properties.Appearance.Options.UseTextOptions = True
        Me.SequenceTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.SequenceTextEdit.Properties.ReadOnly = True
        Me.SequenceTextEdit.Size = New System.Drawing.Size(43, 20)
        Me.SequenceTextEdit.TabIndex = 2
        Me.SequenceTextEdit.TabStop = False
        '
        'eRlblProductID
        '
        Me.eRlblProductID.EditValue = ""
        Me.eRlblProductID.Location = New System.Drawing.Point(102, 101)
        Me.eRlblProductID.MenuManager = Me.RibbonControl1
        Me.eRlblProductID.Name = "eRlblProductID"
        Me.eRlblProductID.Properties.Appearance.Options.UseTextOptions = True
        Me.eRlblProductID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eRlblProductID.Properties.ReadOnly = True
        Me.eRlblProductID.Size = New System.Drawing.Size(43, 20)
        Me.eRlblProductID.TabIndex = 8
        Me.eRlblProductID.TabStop = False
        '
        'eFinalProductID
        '
        Me.eFinalProductID.EditValue = ""
        Me.eFinalProductID.Location = New System.Drawing.Point(102, 127)
        Me.eFinalProductID.MenuManager = Me.RibbonControl1
        Me.eFinalProductID.Name = "eFinalProductID"
        Me.eFinalProductID.Properties.Appearance.Options.UseTextOptions = True
        Me.eFinalProductID.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eFinalProductID.Properties.ReadOnly = True
        Me.eFinalProductID.Size = New System.Drawing.Size(43, 20)
        Me.eFinalProductID.TabIndex = 9
        Me.eFinalProductID.TabStop = False
        '
        'eRlblProductDesc
        '
        Me.eRlblProductDesc.EditValue = ""
        Me.eRlblProductDesc.Location = New System.Drawing.Point(151, 101)
        Me.eRlblProductDesc.MenuManager = Me.RibbonControl1
        Me.eRlblProductDesc.Name = "eRlblProductDesc"
        Me.eRlblProductDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.eRlblProductDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eRlblProductDesc.Properties.ReadOnly = True
        Me.eRlblProductDesc.Size = New System.Drawing.Size(313, 20)
        Me.eRlblProductDesc.TabIndex = 10
        Me.eRlblProductDesc.TabStop = False
        '
        'eFinalProductDesc
        '
        Me.eFinalProductDesc.EditValue = ""
        Me.eFinalProductDesc.Location = New System.Drawing.Point(151, 127)
        Me.eFinalProductDesc.MenuManager = Me.RibbonControl1
        Me.eFinalProductDesc.Name = "eFinalProductDesc"
        Me.eFinalProductDesc.Properties.Appearance.Options.UseTextOptions = True
        Me.eFinalProductDesc.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.eFinalProductDesc.Properties.ReadOnly = True
        Me.eFinalProductDesc.Size = New System.Drawing.Size(313, 20)
        Me.eFinalProductDesc.TabIndex = 11
        Me.eFinalProductDesc.TabStop = False
        '
        'frmAddEditProductRelabelInstruction
        '
        Me.ClientSize = New System.Drawing.Size(477, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.eFinalProductDesc)
        Me.Controls.Add(Me.eRlblProductDesc)
        Me.Controls.Add(Me.eFinalProductID)
        Me.Controls.Add(Me.eRlblProductID)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(RelabelInstructionLabel)
        Me.Controls.Add(Me.RelabelInstructionMemoEdit)
        Me.Controls.Add(SequenceLabel)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.SequenceTextEdit)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditProductRelabelInstruction"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Relabel Instruction"
        CType(Me.bsProductRelabelInstruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelabelInstructionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SequenceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eRlblProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFinalProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eRlblProductDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFinalProductDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProductRelabelInstruction As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RelabelInstructionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents SequenceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eRlblProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eFinalProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eRlblProductDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eFinalProductDesc As DevExpress.XtraEditors.TextEdit
End Class
