<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotes

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotes))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsNotes = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnReturn = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddNewNote = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditNote = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteNote = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New CustomDevExGridView()
        Me.colNoteKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLinkType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLinkKey = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNoteText = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.colCreateTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreateBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifyTime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colModifyBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsDeleted = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Notes32 = New DevExpress.Utils.ImageCollection(Me.components)
        CType(Me.bsNotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes32, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsNotes
        '
        Me.bsNotes.DataSource = GetType(AOS.BusinessObjects.NoteCollection)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnReturn, Me.btnAddNewNote, Me.btnEditNote, Me.btnDeleteNote})
        Me.RibbonControl1.LargeImages = Me.Notes32
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 10
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(670, 94)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnReturn
        '
        Me.btnReturn.Caption = "Return"
        Me.btnReturn.Id = 6
        Me.btnReturn.LargeImageIndex = 8
        Me.btnReturn.Name = "btnReturn"
        '
        'btnAddNewNote
        '
        Me.btnAddNewNote.Caption = "New"
        Me.btnAddNewNote.Id = 7
        Me.btnAddNewNote.LargeImageIndex = 1
        Me.btnAddNewNote.Name = "btnAddNewNote"
        '
        'btnEditNote
        '
        Me.btnEditNote.Caption = "Edit"
        Me.btnEditNote.Id = 8
        Me.btnEditNote.LargeImageIndex = 2
        Me.btnEditNote.Name = "btnEditNote"
        '
        'btnDeleteNote
        '
        Me.btnDeleteNote.Caption = "Delete"
        Me.btnDeleteNote.Id = 9
        Me.btnDeleteNote.LargeImageIndex = 3
        Me.btnDeleteNote.Name = "btnDeleteNote"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnReturn)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnAddNewNote)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditNote, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnDeleteNote, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 94)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(670, 247)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Notes"
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.bsNotes
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 21)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(666, 224)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNoteKey, Me.colLinkType, Me.colLinkKey, Me.colNoteText, Me.colCreateTime, Me.colCreateBy, Me.colModifyTime, Me.colModifyBy, Me.colIsDeleted})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowIndicator = False
        Me.GridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colModifyTime, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'colNoteKey
        '
        Me.colNoteKey.FieldName = "NoteKey"
        Me.colNoteKey.Name = "colNoteKey"
        '
        'colLinkType
        '
        Me.colLinkType.FieldName = "LinkType"
        Me.colLinkType.Name = "colLinkType"
        '
        'colLinkKey
        '
        Me.colLinkKey.FieldName = "LinkKey"
        Me.colLinkKey.Name = "colLinkKey"
        '
        'colNoteText
        '
        Me.colNoteText.AppearanceCell.Options.UseTextOptions = True
        Me.colNoteText.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colNoteText.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.colNoteText.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.colNoteText.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colNoteText.FieldName = "NoteText"
        Me.colNoteText.Name = "colNoteText"
        Me.colNoteText.Visible = True
        Me.colNoteText.VisibleIndex = 1
        Me.colNoteText.Width = 548
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'colCreateTime
        '
        Me.colCreateTime.FieldName = "CreateTime"
        Me.colCreateTime.Name = "colCreateTime"
        '
        'colCreateBy
        '
        Me.colCreateBy.FieldName = "CreateBy"
        Me.colCreateBy.Name = "colCreateBy"
        '
        'colModifyTime
        '
        Me.colModifyTime.DisplayFormat.FormatString = "g"
        Me.colModifyTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colModifyTime.FieldName = "ModifyTime"
        Me.colModifyTime.Name = "colModifyTime"
        Me.colModifyTime.Visible = True
        Me.colModifyTime.VisibleIndex = 0
        Me.colModifyTime.Width = 118
        '
        'colModifyBy
        '
        Me.colModifyBy.FieldName = "ModifyBy"
        Me.colModifyBy.Name = "colModifyBy"
        '
        'colIsDeleted
        '
        Me.colIsDeleted.FieldName = "IsDeleted"
        Me.colIsDeleted.Name = "colIsDeleted"
        '
        'Notes32
        '
        Me.Notes32.ImageSize = New System.Drawing.Size(32, 32)
        Me.Notes32.ImageStream = CType(resources.GetObject("Notes32.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'frmNotes
        '
        Me.ClientSize = New System.Drawing.Size(670, 341)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmNotes"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Notes"
        CType(Me.bsNotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes32, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsNotes As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnReturn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddNewNote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditNote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteNote As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colNoteKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLinkType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLinkKey As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNoteText As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreateBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifyTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colModifyBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsDeleted As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Notes32 As DevExpress.Utils.ImageCollection
End Class
