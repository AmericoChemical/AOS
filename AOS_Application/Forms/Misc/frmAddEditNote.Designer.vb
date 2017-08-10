<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditNote

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
        Dim NoteTextLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditNote))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsNote = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.NoteTextMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.Notes32 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.lblModify = New DevExpress.XtraEditors.LabelControl()
        Me.lblCreate = New DevExpress.XtraEditors.LabelControl()
        NoteTextLabel = New System.Windows.Forms.Label()
        CType(Me.bsNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoteTextMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Notes32, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoteTextLabel
        '
        NoteTextLabel.AutoSize = True
        NoteTextLabel.Location = New System.Drawing.Point(12, 96)
        NoteTextLabel.Name = "NoteTextLabel"
        NoteTextLabel.Size = New System.Drawing.Size(30, 13)
        NoteTextLabel.TabIndex = 1
        NoteTextLabel.Text = "Note"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsNote
        '
        Me.bsNote.DataSource = GetType(AOS.BusinessObjects.Note)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.ExpandCollapseItem.Name = ""
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.Notes32
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(473, 94)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 6
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 7
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'NoteTextMemoEdit
        '
        Me.NoteTextMemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsNote, "NoteText", True))
        Me.NoteTextMemoEdit.Location = New System.Drawing.Point(12, 112)
        Me.NoteTextMemoEdit.MenuManager = Me.RibbonControl1
        Me.NoteTextMemoEdit.Name = "NoteTextMemoEdit"
        Me.NoteTextMemoEdit.Size = New System.Drawing.Size(449, 129)
        Me.NoteTextMemoEdit.TabIndex = 2
        '
        'Notes32
        '
        Me.Notes32.ImageSize = New System.Drawing.Size(32, 32)
        Me.Notes32.ImageStream = CType(resources.GetObject("Notes32.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'lblModify
        '
        Me.lblModify.Location = New System.Drawing.Point(15, 266)
        Me.lblModify.Name = "lblModify"
        Me.lblModify.Size = New System.Drawing.Size(224, 13)
        Me.lblModify.TabIndex = 8
        Me.lblModify.Text = "Last modified by Admin - 12/31/1999 11:59 PM"
        '
        'lblCreate
        '
        Me.lblCreate.Location = New System.Drawing.Point(15, 247)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(200, 13)
        Me.lblCreate.TabIndex = 9
        Me.lblCreate.Text = "Created by Admin - 12/31/1999 11:59 PM"
        '
        'frmAddEditNote
        '
        Me.ClientSize = New System.Drawing.Size(473, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblCreate)
        Me.Controls.Add(Me.lblModify)
        Me.Controls.Add(NoteTextLabel)
        Me.Controls.Add(Me.NoteTextMemoEdit)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddEditNote"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Note"
        CType(Me.bsNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoteTextMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Notes32, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsNote As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents NoteTextMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Notes32 As DevExpress.Utils.ImageCollection
    Friend WithEvents lblModify As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCreate As DevExpress.XtraEditors.LabelControl
End Class
