<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelabelInstruction

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelabelInstruction))
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsRelabelInstructions = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grRelabelInstruction = New DevExpress.XtraGrid.GridControl()
        Me.grvRelabelInstruction = New AOS.CustomClasses.CustomDevExGridView()
        Me.colSequence = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelabelinstruction = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRelabelinstructionnumber = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.bsRelabelInstructions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grRelabelInstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvRelabelInstruction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsRelabelInstructions
        '
        Me.bsRelabelInstructions.DataSource = GetType(AOS.BusinessObjects.RelabelinstructionCollection)
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
        Me.RibbonControl1.Size = New System.Drawing.Size(1049, 95)
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
        Me.RibbonPageGroup2.Text = "Template Relabel Instructions"
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
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.grRelabelInstruction)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(0, 95)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.PanelControl2.Size = New System.Drawing.Size(1049, 411)
        Me.PanelControl2.TabIndex = 41
        '
        'grRelabelInstruction
        '
        Me.grRelabelInstruction.DataSource = Me.bsRelabelInstructions
        Me.grRelabelInstruction.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.RelationName = "Level1"
        Me.grRelabelInstruction.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.grRelabelInstruction.Location = New System.Drawing.Point(6, 6)
        Me.grRelabelInstruction.MainView = Me.grvRelabelInstruction
        Me.grRelabelInstruction.Name = "grRelabelInstruction"
        Me.grRelabelInstruction.Size = New System.Drawing.Size(1037, 399)
        Me.grRelabelInstruction.TabIndex = 1
        Me.grRelabelInstruction.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvRelabelInstruction})
        '
        'grvRelabelInstruction
        '
        Me.grvRelabelInstruction.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSequence, Me.colRelabelinstruction, Me.colRelabelinstructionnumber})
        Me.grvRelabelInstruction.GridControl = Me.grRelabelInstruction
        Me.grvRelabelInstruction.Name = "grvRelabelInstruction"
        Me.grvRelabelInstruction.OptionsBehavior.Editable = False
        Me.grvRelabelInstruction.OptionsSelection.MultiSelect = True
        Me.grvRelabelInstruction.OptionsView.ShowGroupPanel = False
        Me.grvRelabelInstruction.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colSequence, DevExpress.Data.ColumnSortOrder.Ascending)})
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
        Me.colRelabelinstruction.Caption = "Relabel Instruction"
        Me.colRelabelinstruction.FieldName = "Relabelinstruction"
        Me.colRelabelinstruction.Name = "colRelabelinstruction"
        Me.colRelabelinstruction.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
        Me.colRelabelinstruction.Visible = True
        Me.colRelabelinstruction.VisibleIndex = 1
        Me.colRelabelinstruction.Width = 509
        '
        'colRelabelinstructionnumber
        '
        Me.colRelabelinstructionnumber.Caption = "colRelabelInstructionId"
        Me.colRelabelinstructionnumber.FieldName = "Relabelinstructionnumber"
        Me.colRelabelinstructionnumber.Name = "colRelabelinstructionnumber"
        '
        'frmRelabelInstruction
        '
        Me.ClientSize = New System.Drawing.Size(1049, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmRelabelInstruction"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Template Relabel Instructions"
        CType(Me.bsRelabelInstructions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grRelabelInstruction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvRelabelInstruction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsRelabelInstructions As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnInsertRelabelInstr As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditRelabelInstr As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteRelabelInstr As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents grRelabelInstruction As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvRelabelInstruction As CustomDevExGridView
    Friend WithEvents colSequence As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelabelinstruction As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRelabelinstructionnumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rbtnMoveUp As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnMoveDown As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
End Class
