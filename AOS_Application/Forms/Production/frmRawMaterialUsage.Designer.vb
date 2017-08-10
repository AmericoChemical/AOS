<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRawMaterialUsage

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
        Dim ProdordernumLabel As System.Windows.Forms.Label
        Dim ProdorderdateLabel As System.Windows.Forms.Label
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim ProductdescLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim ProductqtyLabel As System.Windows.Forms.Label
        Dim WorkordernumberLabel As System.Windows.Forms.Label
        Dim LotnumberLabel As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsTxs = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New CustomDevExGridView()
        Me.colMaterialid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colInvitemnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsused = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRmid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRMDesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRMContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRMLotNum = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProdorderdateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.ProdordernumSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProductidSpinEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProductdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ContainerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProductqtyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.WorkordernumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LotnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        ProdordernumLabel = New System.Windows.Forms.Label()
        ProdorderdateLabel = New System.Windows.Forms.Label()
        ProductidLabel = New System.Windows.Forms.Label()
        ProductdescLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        ProductqtyLabel = New System.Windows.Forms.Label()
        WorkordernumberLabel = New System.Windows.Forms.Label()
        LotnumberLabel = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTxs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdorderdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProdordernumSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductidSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductqtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnClose})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(747, 95)
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
        'btnClose
        '
        Me.btnClose.Caption = "Close"
        Me.btnClose.Id = 5
        Me.btnClose.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnClose.Name = "btnClose"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        '
        'bsTxs
        '
        Me.bsTxs.DataSource = GetType(AOS.BusinessObjects.ViewProductionOrderMaterialTransactionsCollection)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(LotnumberLabel)
        Me.GroupControl1.Controls.Add(Me.LotnumberTextEdit)
        Me.GroupControl1.Controls.Add(WorkordernumberLabel)
        Me.GroupControl1.Controls.Add(Me.WorkordernumberTextEdit)
        Me.GroupControl1.Controls.Add(ProductqtyLabel)
        Me.GroupControl1.Controls.Add(Me.ProductqtyTextEdit)
        Me.GroupControl1.Controls.Add(ContainerLabel)
        Me.GroupControl1.Controls.Add(Me.ContainerTextEdit)
        Me.GroupControl1.Controls.Add(ProductdescLabel)
        Me.GroupControl1.Controls.Add(Me.ProductdescTextEdit)
        Me.GroupControl1.Controls.Add(ProductidLabel)
        Me.GroupControl1.Controls.Add(ProdorderdateLabel)
        Me.GroupControl1.Controls.Add(Me.ProdorderdateDateEdit)
        Me.GroupControl1.Controls.Add(ProdordernumLabel)
        Me.GroupControl1.Controls.Add(Me.ProdordernumSpinEdit)
        Me.GroupControl1.Controls.Add(Me.ProductidSpinEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(747, 95)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Production Order"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 190)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(747, 254)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Raw Material Usage Transactions"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsTxs
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 21)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(743, 231)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMaterialid, Me.colInvitemnumber, Me.colUnitsused, Me.colRmid, Me.colRMDesc, Me.colRMContainer, Me.colRMLotNum})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        '
        'colMaterialid
        '
        Me.colMaterialid.Caption = "Matl ID"
        Me.colMaterialid.FieldName = "Materialid"
        Me.colMaterialid.Name = "colMaterialid"
        Me.colMaterialid.Visible = True
        Me.colMaterialid.VisibleIndex = 0
        Me.colMaterialid.Width = 63
        '
        'colInvitemnumber
        '
        Me.colInvitemnumber.Caption = "Item #"
        Me.colInvitemnumber.FieldName = "Invitemnumber"
        Me.colInvitemnumber.Name = "colInvitemnumber"
        Me.colInvitemnumber.Visible = True
        Me.colInvitemnumber.VisibleIndex = 1
        Me.colInvitemnumber.Width = 85
        '
        'colUnitsused
        '
        Me.colUnitsused.Caption = "Units Used"
        Me.colUnitsused.FieldName = "Unitsused"
        Me.colUnitsused.Name = "colUnitsused"
        Me.colUnitsused.Visible = True
        Me.colUnitsused.VisibleIndex = 2
        Me.colUnitsused.Width = 88
        '
        'colRmid
        '
        Me.colRmid.Caption = "Prod ID"
        Me.colRmid.FieldName = "Rmid"
        Me.colRmid.Name = "colRmid"
        Me.colRmid.Visible = True
        Me.colRmid.VisibleIndex = 3
        Me.colRmid.Width = 61
        '
        'colRMDesc
        '
        Me.colRMDesc.Caption = "Product Desc"
        Me.colRMDesc.FieldName = "RMDesc"
        Me.colRMDesc.Name = "colRMDesc"
        Me.colRMDesc.Visible = True
        Me.colRMDesc.VisibleIndex = 4
        Me.colRMDesc.Width = 261
        '
        'colRMContainer
        '
        Me.colRMContainer.Caption = "Container"
        Me.colRMContainer.FieldName = "RMContainer"
        Me.colRMContainer.Name = "colRMContainer"
        Me.colRMContainer.Visible = True
        Me.colRMContainer.VisibleIndex = 5
        Me.colRMContainer.Width = 158
        '
        'colRMLotNum
        '
        Me.colRMLotNum.Caption = "Lot Number"
        Me.colRMLotNum.FieldName = "RMLotNum"
        Me.colRMLotNum.Name = "colRMLotNum"
        Me.colRMLotNum.Visible = True
        Me.colRMLotNum.VisibleIndex = 6
        Me.colRMLotNum.Width = 195
        '
        'ProdordernumLabel
        '
        ProdordernumLabel.AutoSize = True
        ProdordernumLabel.Location = New System.Drawing.Point(8, 27)
        ProdordernumLabel.Name = "ProdordernumLabel"
        ProdordernumLabel.Size = New System.Drawing.Size(71, 13)
        ProdordernumLabel.TabIndex = 0
        ProdordernumLabel.Text = "Prod Order #"
        '
        'ProdorderdateLabel
        '
        ProdorderdateLabel.AutoSize = True
        ProdorderdateLabel.Location = New System.Drawing.Point(178, 27)
        ProdorderdateLabel.Name = "ProdorderdateLabel"
        ProdorderdateLabel.Size = New System.Drawing.Size(61, 13)
        ProdorderdateLabel.TabIndex = 2
        ProdorderdateLabel.Text = "Order Date"
        '
        'ProdorderdateDateEdit
        '
        Me.ProdorderdateDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsTxs, "Prodorderdate", True))
        Me.ProdorderdateDateEdit.EditValue = Nothing
        Me.ProdorderdateDateEdit.Location = New System.Drawing.Point(256, 24)
        Me.ProdorderdateDateEdit.MenuManager = Me.RibbonControl1
        Me.ProdorderdateDateEdit.Name = "ProdorderdateDateEdit"
        Me.ProdorderdateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProdorderdateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ProdorderdateDateEdit.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.ProdorderdateDateEdit.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.ProdorderdateDateEdit.Properties.ReadOnly = True
        Me.ProdorderdateDateEdit.Size = New System.Drawing.Size(72, 20)
        Me.ProdorderdateDateEdit.TabIndex = 3
        '
        'ProdordernumSpinEdit
        '
        Me.ProdordernumSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsTxs, "Prodordernum", True))
        Me.ProdordernumSpinEdit.EditValue = ""
        Me.ProdordernumSpinEdit.Location = New System.Drawing.Point(93, 24)
        Me.ProdordernumSpinEdit.MenuManager = Me.RibbonControl1
        Me.ProdordernumSpinEdit.Name = "ProdordernumSpinEdit"
        Me.ProdordernumSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ProdordernumSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.ProdordernumSpinEdit.Properties.ReadOnly = True
        Me.ProdordernumSpinEdit.Size = New System.Drawing.Size(76, 20)
        Me.ProdordernumSpinEdit.TabIndex = 1
        '
        'ProductidLabel
        '
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(178, 48)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(58, 13)
        ProductidLabel.TabIndex = 4
        ProductidLabel.Text = "Product ID"
        '
        'ProductidSpinEdit
        '
        Me.ProductidSpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsTxs, "Productid", True))
        Me.ProductidSpinEdit.EditValue = ""
        Me.ProductidSpinEdit.Location = New System.Drawing.Point(175, 64)
        Me.ProductidSpinEdit.MenuManager = Me.RibbonControl1
        Me.ProductidSpinEdit.Name = "ProductidSpinEdit"
        Me.ProductidSpinEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ProductidSpinEdit.Properties.ReadOnly = True
        Me.ProductidSpinEdit.Size = New System.Drawing.Size(75, 20)
        Me.ProductidSpinEdit.TabIndex = 5
        '
        'ProductdescLabel
        '
        ProductdescLabel.AutoSize = True
        ProductdescLabel.Location = New System.Drawing.Point(253, 48)
        ProductdescLabel.Name = "ProductdescLabel"
        ProductdescLabel.Size = New System.Drawing.Size(100, 13)
        ProductdescLabel.TabIndex = 6
        ProductdescLabel.Text = "Product Description"
        '
        'ProductdescTextEdit
        '
        Me.ProductdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsTxs, "Productdesc", True))
        Me.ProductdescTextEdit.Location = New System.Drawing.Point(256, 64)
        Me.ProductdescTextEdit.MenuManager = Me.RibbonControl1
        Me.ProductdescTextEdit.Name = "ProductdescTextEdit"
        Me.ProductdescTextEdit.Properties.ReadOnly = True
        Me.ProductdescTextEdit.Size = New System.Drawing.Size(203, 20)
        Me.ProductdescTextEdit.TabIndex = 7
        '
        'ContainerLabel
        '
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(462, 48)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(58, 13)
        ContainerLabel.TabIndex = 8
        ContainerLabel.Text = "Container:"
        '
        'ContainerTextEdit
        '
        Me.ContainerTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsTxs, "Container", True))
        Me.ContainerTextEdit.Location = New System.Drawing.Point(465, 64)
        Me.ContainerTextEdit.MenuManager = Me.RibbonControl1
        Me.ContainerTextEdit.Name = "ContainerTextEdit"
        Me.ContainerTextEdit.Properties.ReadOnly = True
        Me.ContainerTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.ContainerTextEdit.TabIndex = 9
        '
        'ProductqtyLabel
        '
        ProductqtyLabel.AutoSize = True
        ProductqtyLabel.Location = New System.Drawing.Point(90, 47)
        ProductqtyLabel.Name = "ProductqtyLabel"
        ProductqtyLabel.Size = New System.Drawing.Size(68, 13)
        ProductqtyLabel.TabIndex = 10
        ProductqtyLabel.Text = "Qty Ordered"
        '
        'ProductqtyTextEdit
        '
        Me.ProductqtyTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsTxs, "Productqty", True))
        Me.ProductqtyTextEdit.Location = New System.Drawing.Point(93, 64)
        Me.ProductqtyTextEdit.MenuManager = Me.RibbonControl1
        Me.ProductqtyTextEdit.Name = "ProductqtyTextEdit"
        Me.ProductqtyTextEdit.Properties.ReadOnly = True
        Me.ProductqtyTextEdit.Size = New System.Drawing.Size(76, 20)
        Me.ProductqtyTextEdit.TabIndex = 11
        '
        'WorkordernumberLabel
        '
        WorkordernumberLabel.AutoSize = True
        WorkordernumberLabel.Location = New System.Drawing.Point(566, 27)
        WorkordernumberLabel.Name = "WorkordernumberLabel"
        WorkordernumberLabel.Size = New System.Drawing.Size(74, 13)
        WorkordernumberLabel.TabIndex = 12
        WorkordernumberLabel.Text = "Work Order #"
        '
        'WorkordernumberTextEdit
        '
        Me.WorkordernumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsTxs, "Workordernumber", True))
        Me.WorkordernumberTextEdit.Location = New System.Drawing.Point(646, 24)
        Me.WorkordernumberTextEdit.MenuManager = Me.RibbonControl1
        Me.WorkordernumberTextEdit.Name = "WorkordernumberTextEdit"
        Me.WorkordernumberTextEdit.Properties.ReadOnly = True
        Me.WorkordernumberTextEdit.Size = New System.Drawing.Size(89, 20)
        Me.WorkordernumberTextEdit.TabIndex = 13
        '
        'LotnumberLabel
        '
        LotnumberLabel.AutoSize = True
        LotnumberLabel.Location = New System.Drawing.Point(568, 48)
        LotnumberLabel.Name = "LotnumberLabel"
        LotnumberLabel.Size = New System.Drawing.Size(62, 13)
        LotnumberLabel.TabIndex = 14
        LotnumberLabel.Text = "Lotnumber:"
        '
        'LotnumberTextEdit
        '
        Me.LotnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsTxs, "Lotnumber", True))
        Me.LotnumberTextEdit.Location = New System.Drawing.Point(571, 64)
        Me.LotnumberTextEdit.MenuManager = Me.RibbonControl1
        Me.LotnumberTextEdit.Name = "LotnumberTextEdit"
        Me.LotnumberTextEdit.Properties.ReadOnly = True
        Me.LotnumberTextEdit.Size = New System.Drawing.Size(164, 20)
        Me.LotnumberTextEdit.TabIndex = 15
        '
        'frmRawMaterialUsage
        '
        Me.ClientSize = New System.Drawing.Size(747, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRawMaterialUsage"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Raw Material Transactions"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTxs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdorderdateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdorderdateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProdordernumSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductidSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContainerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductqtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkordernumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsTxs As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LotnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents WorkordernumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductqtyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ContainerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProdorderdateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents ProdordernumSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ProductidSpinEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colMaterialid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colInvitemnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsused As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRmid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRMDesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRMContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRMLotNum As DevExpress.XtraGrid.Columns.GridColumn
End Class
