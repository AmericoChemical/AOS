<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConvertInventory

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
        Dim Label6 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PalletPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.InventoryClassLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsInventoryClass = New System.Windows.Forms.BindingSource(Me.components)
        Label6 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PalletPanelControl.SuspendLayout()
        CType(Me.InventoryClassLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(10, 25)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(87, 13)
        Label6.TabIndex = 0
        Label6.Text = "Inventory Class:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(299, 96)
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
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.form_arrow_right
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
        'PalletPanelControl
        '
        Me.PalletPanelControl.Controls.Add(Me.InventoryClassLookUpEdit)
        Me.PalletPanelControl.Controls.Add(Label6)
        Me.PalletPanelControl.Location = New System.Drawing.Point(0, 94)
        Me.PalletPanelControl.Name = "PalletPanelControl"
        Me.PalletPanelControl.Size = New System.Drawing.Size(299, 79)
        Me.PalletPanelControl.TabIndex = 1
        '
        'InventoryClassLookUpEdit
        '
        Me.InventoryClassLookUpEdit.Location = New System.Drawing.Point(100, 22)
        Me.InventoryClassLookUpEdit.MenuManager = Me.RibbonControl1
        Me.InventoryClassLookUpEdit.Name = "InventoryClassLookUpEdit"
        Me.InventoryClassLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.InventoryClassLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LookupDesc", 5, "Inventory Class")})
        Me.InventoryClassLookUpEdit.Properties.DataSource = Me.bsInventoryClass
        Me.InventoryClassLookUpEdit.Properties.DisplayMember = "LookupDesc"
        Me.InventoryClassLookUpEdit.Properties.NullText = ""
        Me.InventoryClassLookUpEdit.Properties.ValueMember = "LookupValue"
        Me.InventoryClassLookUpEdit.Size = New System.Drawing.Size(192, 20)
        Me.InventoryClassLookUpEdit.TabIndex = 1
        '
        'bsInventoryClass
        '
        Me.bsInventoryClass.DataSource = GetType(AOS.BusinessObjects.ListInventoryclassCollection)
        '
        'frmConvertInventory
        '
        Me.ClientSize = New System.Drawing.Size(299, 173)
        Me.ControlBox = False
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.PalletPanelControl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmConvertInventory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Convert Inventory"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PalletPanelControl.ResumeLayout(False)
        Me.PalletPanelControl.PerformLayout()
        CType(Me.InventoryClassLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PalletPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents bsInventoryClass As System.Windows.Forms.BindingSource
    Friend WithEvents InventoryClassLookUpEdit As DevExpress.XtraEditors.LookUpEdit
End Class
