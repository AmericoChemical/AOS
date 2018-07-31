
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmailPlan

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
        Dim lblTo As System.Windows.Forms.Label
        Dim lblFrom As System.Windows.Forms.Label
        Dim lblSubject As System.Windows.Forms.Label
        Dim lblBody As System.Windows.Forms.Label
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSend = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.PalletPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.BodyStatementRichEditControl = New DevExpress.XtraRichEdit.RichEditControl()
        Me.bsWorkOrderEmailPlan = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SenderTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ReceiverTextEdit = New DevExpress.XtraEditors.TextEdit()
        lblTo = New System.Windows.Forms.Label()
        lblFrom = New System.Windows.Forms.Label()
        lblSubject = New System.Windows.Forms.Label()
        lblBody = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PalletPanelControl.SuspendLayout()
        CType(Me.bsWorkOrderEmailPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenderTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTo
        '
        lblTo.AutoSize = True
        lblTo.Location = New System.Drawing.Point(16, 58)
        lblTo.Name = "lblTo"
        lblTo.Size = New System.Drawing.Size(19, 13)
        lblTo.TabIndex = 2
        lblTo.Text = "To"
        '
        'lblFrom
        '
        lblFrom.AutoSize = True
        lblFrom.Location = New System.Drawing.Point(16, 25)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New System.Drawing.Size(31, 13)
        lblFrom.TabIndex = 0
        lblFrom.Text = "From"
        '
        'lblSubject
        '
        lblSubject.AutoSize = True
        lblSubject.Location = New System.Drawing.Point(16, 90)
        lblSubject.Name = "lblSubject"
        lblSubject.Size = New System.Drawing.Size(43, 13)
        lblSubject.TabIndex = 4
        lblSubject.Text = "Subject"
        '
        'lblBody
        '
        lblBody.AutoSize = True
        lblBody.Location = New System.Drawing.Point(16, 120)
        lblBody.Name = "lblBody"
        lblBody.Size = New System.Drawing.Size(31, 13)
        lblBody.TabIndex = 7
        lblBody.Text = "Body"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSend, Me.btnCancel})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(951, 117)
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
        'btnSend
        '
        Me.btnSend.Caption = "Send"
        Me.btnSend.Id = 4
        Me.btnSend.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Change
        Me.btnSend.Name = "btnSend"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSend)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'PalletPanelControl
        '
        Me.PalletPanelControl.Controls.Add(Me.BodyStatementRichEditControl)
        Me.PalletPanelControl.Controls.Add(lblBody)
        Me.PalletPanelControl.Controls.Add(Me.SubjectTextEdit)
        Me.PalletPanelControl.Controls.Add(lblSubject)
        Me.PalletPanelControl.Controls.Add(Me.SenderTextEdit)
        Me.PalletPanelControl.Controls.Add(Me.ReceiverTextEdit)
        Me.PalletPanelControl.Controls.Add(lblTo)
        Me.PalletPanelControl.Controls.Add(lblFrom)
        Me.PalletPanelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PalletPanelControl.Location = New System.Drawing.Point(0, 117)
        Me.PalletPanelControl.Name = "PalletPanelControl"
        Me.PalletPanelControl.Size = New System.Drawing.Size(951, 609)
        Me.PalletPanelControl.TabIndex = 1
        '
        'BodyStatementRichEditControl
        '
        Me.BodyStatementRichEditControl.Appearance.Text.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BodyStatementRichEditControl.Appearance.Text.Options.UseFont = True
        Me.BodyStatementRichEditControl.DataBindings.Add(New System.Windows.Forms.Binding("HtmlText", Me.bsWorkOrderEmailPlan, "Bodytext", True))
        Me.BodyStatementRichEditControl.Location = New System.Drawing.Point(70, 120)
        Me.BodyStatementRichEditControl.MenuManager = Me.RibbonControl1
        Me.BodyStatementRichEditControl.Name = "BodyStatementRichEditControl"
        Me.BodyStatementRichEditControl.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
        Me.BodyStatementRichEditControl.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
        Me.BodyStatementRichEditControl.Size = New System.Drawing.Size(862, 500)
        Me.BodyStatementRichEditControl.TabIndex = 8
        '
        'bsWorkOrderEmailPlan
        '
        Me.bsWorkOrderEmailPlan.DataSource = GetType(AOS.BusinessObjects.Workorderemailplan)
        '
        'SubjectTextEdit
        '
        Me.SubjectTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrderEmailPlan, "Subjecttext", True))
        Me.SubjectTextEdit.EditValue = ""
        Me.SubjectTextEdit.Location = New System.Drawing.Point(70, 87)
        Me.SubjectTextEdit.Name = "SubjectTextEdit"
        Me.SubjectTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.SubjectTextEdit.Properties.MaxLength = 250
        Me.SubjectTextEdit.Size = New System.Drawing.Size(412, 20)
        Me.SubjectTextEdit.TabIndex = 5
        '
        'SenderTextEdit
        '
        Me.SenderTextEdit.EditValue = ""
        Me.SenderTextEdit.Location = New System.Drawing.Point(70, 22)
        Me.SenderTextEdit.Name = "SenderTextEdit"
        Me.SenderTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.SenderTextEdit.Properties.MaxLength = 9
        Me.SenderTextEdit.Properties.ReadOnly = True
        Me.SenderTextEdit.Size = New System.Drawing.Size(217, 20)
        Me.SenderTextEdit.TabIndex = 1
        Me.SenderTextEdit.TabStop = False
        '
        'ReceiverTextEdit
        '
        Me.ReceiverTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsWorkOrderEmailPlan, "Toemailid", True))
        Me.ReceiverTextEdit.EditValue = ""
        Me.ReceiverTextEdit.Location = New System.Drawing.Point(70, 55)
        Me.ReceiverTextEdit.Name = "ReceiverTextEdit"
        Me.ReceiverTextEdit.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.ReceiverTextEdit.Properties.MaxLength = 250
        Me.ReceiverTextEdit.Size = New System.Drawing.Size(412, 20)
        Me.ReceiverTextEdit.TabIndex = 3
        '
        'frmEmailPlan
        '
        Me.ClientSize = New System.Drawing.Size(951, 726)
        Me.ControlBox = False
        Me.Controls.Add(Me.PalletPanelControl)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEmailPlan"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Email Plan"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PalletPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PalletPanelControl.ResumeLayout(False)
        Me.PalletPanelControl.PerformLayout()
        CType(Me.bsWorkOrderEmailPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenderTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSend As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PalletPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents ReceiverTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SenderTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SubjectTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsWorkOrderEmailPlan As System.Windows.Forms.BindingSource
    Friend WithEvents BodyStatementRichEditControl As DevExpress.XtraRichEdit.RichEditControl
End Class
