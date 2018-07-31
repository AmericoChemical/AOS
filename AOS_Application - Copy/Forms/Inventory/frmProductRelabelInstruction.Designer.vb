<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductRelabelInstruction

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductRelabelInstruction))
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsProductRelabelInstruction = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnInsertRelabelInstr = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditRelabelInstr = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteRelabelInstr = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClose = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMoveUp = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnMoveDown = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.grProductRelabelInstruction = New DevExpress.XtraGrid.GridControl()
        Me.grvProductRelabelInstruction = New AOS.CustomClasses.CustomDevExGridView()
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelabelinstruction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelabelinstructionnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bsRelabelTemplateInstructions = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CustomDevExGridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colRelabelinstructionnumber1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSequence1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelabelinstruction1 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.bsProductRelabelInstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grProductRelabelInstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvProductRelabelInstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRelabelTemplateInstructions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsProductRelabelInstruction
        '
        Me.bsProductRelabelInstruction.DataSource = GetType(AOS.BusinessObjects.ProductrelabelinstructionCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnInsertRelabelInstr, Me.btnEditRelabelInstr, Me.btnDeleteRelabelInstr, Me.btnClose, Me.rbtnMoveUp, Me.rbtnMoveDown})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 21
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(589, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnInsertRelabelInstr
        '
        Me.btnInsertRelabelInstr.Caption = "Add New"
        Me.btnInsertRelabelInstr.Id = 0
        Me.btnInsertRelabelInstr.LargeImageIndex = 18
        Me.btnInsertRelabelInstr.Name = "btnInsertRelabelInstr"
        '
        'btnEditRelabelInstr
        '
        Me.btnEditRelabelInstr.Caption = "Edit"
        Me.btnEditRelabelInstr.Id = 1
        Me.btnEditRelabelInstr.LargeImageIndex = 19
        Me.btnEditRelabelInstr.Name = "btnEditRelabelInstr"
        '
        'btnDeleteRelabelInstr
        '
        Me.btnDeleteRelabelInstr.Caption = "Delete"
        Me.btnDeleteRelabelInstr.Id = 2
        Me.btnDeleteRelabelInstr.LargeImageIndex = 20
        Me.btnDeleteRelabelInstr.Name = "btnDeleteRelabelInstr"
        '
        'btnClose
        '
        Me.btnClose.Caption = "Close Form"
        Me.btnClose.Id = 5
        Me.btnClose.LargeImageIndex = 28
        Me.btnClose.Name = "btnClose"
        '
        'rbtnMoveUp
        '
        Me.rbtnMoveUp.Caption = "Move Up"
        Me.rbtnMoveUp.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnMoveUp.Id = 19
        Me.rbtnMoveUp.LargeImageIndex = 27
        Me.rbtnMoveUp.Name = "rbtnMoveUp"
        '
        'rbtnMoveDown
        '
        Me.rbtnMoveDown.Caption = "Move Down"
        Me.rbtnMoveDown.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnMoveDown.Id = 20
        Me.rbtnMoveDown.LargeImageIndex = 26
        Me.rbtnMoveDown.Name = "rbtnMoveDown"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClose)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnInsertRelabelInstr)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditRelabelInstr)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeleteRelabelInstr)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Product Relabel Instructions"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnMoveUp)
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnMoveDown)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Sequence"
        '
        'grProductRelabelInstruction
        '
        Me.grProductRelabelInstruction.DataSource = Me.bsProductRelabelInstruction
        Me.grProductRelabelInstruction.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.RelationName = "Level1"
        Me.grProductRelabelInstruction.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.grProductRelabelInstruction.Location = New System.Drawing.Point(6, 26)
        Me.grProductRelabelInstruction.MainView = Me.grvProductRelabelInstruction
        Me.grProductRelabelInstruction.Name = "grProductRelabelInstruction"
        Me.grProductRelabelInstruction.Size = New System.Drawing.Size(577, 159)
        Me.grProductRelabelInstruction.TabIndex = 1
        Me.grProductRelabelInstruction.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvProductRelabelInstruction})
        '
        'grvProductRelabelInstruction
        '
        Me.grvProductRelabelInstruction.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSequence, Me.colRelabelinstruction, Me.colRelabelinstructionnumber})
        Me.grvProductRelabelInstruction.GridControl = Me.grProductRelabelInstruction
        Me.grvProductRelabelInstruction.Name = "grvProductRelabelInstruction"
        Me.grvProductRelabelInstruction.OptionsBehavior.Editable = False
        Me.grvProductRelabelInstruction.OptionsSelection.MultiSelect = True
        Me.grvProductRelabelInstruction.OptionsView.ShowGroupPanel = False
        Me.grvProductRelabelInstruction.OptionsView.ShowIndicator = False
        Me.grvProductRelabelInstruction.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSequence, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colSequence
        '
        Me.colSequence.Caption = "Seq"
        Me.colSequence.FieldName = "Sequence"
        Me.colSequence.Name = "colSequence"
        Me.colSequence.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colSequence.OptionsColumn.FixedWidth = True
        Me.colSequence.Visible = True
        Me.colSequence.VisibleIndex = 0
        Me.colSequence.Width = 50
        '
        'colRelabelinstruction
        '
        Me.colRelabelinstruction.Caption = "Product Relabel Instruction"
        Me.colRelabelinstruction.FieldName = "Relabelinstruction"
        Me.colRelabelinstruction.Name = "colRelabelinstruction"
        Me.colRelabelinstruction.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colRelabelinstruction.Visible = True
        Me.colRelabelinstruction.VisibleIndex = 1
        Me.colRelabelinstruction.Width = 509
        '
        'colRelabelinstructionnumber
        '
        Me.colRelabelinstructionnumber.Caption = "GridColumn1"
        Me.colRelabelinstructionnumber.FieldName = "Productrelabelinstructionnumber"
        Me.colRelabelinstructionnumber.Name = "colRelabelinstructionnumber"
        '
        'bsRelabelTemplateInstructions
        '
        Me.bsRelabelTemplateInstructions.DataSource = GetType(AOS.BusinessObjects.RelabelinstructionCollection)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.grProductRelabelInstruction)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupControl1.Size = New System.Drawing.Size(589, 191)
        Me.GroupControl1.TabIndex = 43
        Me.GroupControl1.Text = "Specific Product Relabel Instructions"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 286)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupControl2.Size = New System.Drawing.Size(589, 346)
        Me.GroupControl2.TabIndex = 44
        Me.GroupControl2.Text = "Standard Relabel Instructions (for all products)"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsRelabelTemplateInstructions
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridControl1.Location = New System.Drawing.Point(6, 26)
        Me.GridControl1.MainView = Me.CustomDevExGridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(577, 314)
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.CustomDevExGridView1})
        '
        'CustomDevExGridView1
        '
        Me.CustomDevExGridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colRelabelinstructionnumber1, Me.colSequence1, Me.colRelabelinstruction1})
        Me.CustomDevExGridView1.GridControl = Me.GridControl1
        Me.CustomDevExGridView1.Name = "CustomDevExGridView1"
        Me.CustomDevExGridView1.OptionsBehavior.Editable = False
        Me.CustomDevExGridView1.OptionsSelection.MultiSelect = True
        Me.CustomDevExGridView1.OptionsView.ShowGroupPanel = False
        Me.CustomDevExGridView1.OptionsView.ShowIndicator = False
        '
        'colRelabelinstructionnumber1
        '
        Me.colRelabelinstructionnumber1.FieldName = "Relabelinstructionnumber"
        Me.colRelabelinstructionnumber1.Name = "colRelabelinstructionnumber1"
        '
        'colSequence1
        '
        Me.colSequence1.Caption = "Seq"
        Me.colSequence1.FieldName = "Sequence"
        Me.colSequence1.Name = "colSequence1"
        Me.colSequence1.Visible = True
        Me.colSequence1.VisibleIndex = 0
        Me.colSequence1.Width = 46
        '
        'colRelabelinstruction1
        '
        Me.colRelabelinstruction1.Caption = "Relabel Instruction"
        Me.colRelabelinstruction1.FieldName = "Relabelinstruction"
        Me.colRelabelinstruction1.Name = "colRelabelinstruction1"
        Me.colRelabelinstruction1.Visible = True
        Me.colRelabelinstruction1.VisibleIndex = 1
        Me.colRelabelinstruction1.Width = 531
        '
        'frmProductRelabelInstruction
        '
        Me.ClientSize = New System.Drawing.Size(589, 632)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProductRelabelInstruction"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Additional Product Relabel Instructions"
        CType(Me.bsProductRelabelInstruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grProductRelabelInstruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvProductRelabelInstruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRelabelTemplateInstructions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomDevExGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsProductRelabelInstruction As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnInsertRelabelInstr As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditRelabelInstr As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteRelabelInstr As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents grProductRelabelInstruction As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvProductRelabelInstruction As CustomDevExGridView
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelabelinstruction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelabelinstructionnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents rbtnMoveUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnMoveDown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsRelabelTemplateInstructions As BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend CustomDevExGridView1 As CustomDevExGridView
    Friend WithEvents colRelabelinstructionnumber1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSequence1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelabelinstruction1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
