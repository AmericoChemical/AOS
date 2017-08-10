<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAuditReason
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim AuditReasonLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAuditReason))
        Me.gcLeft = New DevExpress.XtraEditors.GroupControl()
        Me.AuditReasonTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.pnlProductSelection = New DevExpress.XtraEditors.PanelControl()
        AuditReasonLabel = New System.Windows.Forms.Label()
        CType(Me.gcLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcLeft.SuspendLayout()
        CType(Me.AuditReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlProductSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProductSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuditReasonLabel
        '
        AuditReasonLabel.AutoSize = True
        AuditReasonLabel.Location = New System.Drawing.Point(10, 37)
        AuditReasonLabel.Name = "AuditReasonLabel"
        AuditReasonLabel.Size = New System.Drawing.Size(71, 13)
        AuditReasonLabel.TabIndex = 13
        AuditReasonLabel.Text = "Audit Reason"
        '
        'gcLeft
        '
        Me.gcLeft.Controls.Add(AuditReasonLabel)
        Me.gcLeft.Controls.Add(Me.AuditReasonTextEdit)
        Me.gcLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLeft.Location = New System.Drawing.Point(0, 0)
        Me.gcLeft.Name = "gcLeft"
        Me.gcLeft.Size = New System.Drawing.Size(395, 109)
        Me.gcLeft.TabIndex = 14
        Me.gcLeft.Text = "Audit Reason"
        '
        'AuditReasonTextEdit
        '
        Me.AuditReasonTextEdit.Location = New System.Drawing.Point(87, 34)
        Me.AuditReasonTextEdit.Name = "AuditReasonTextEdit"
        Me.AuditReasonTextEdit.Properties.MaxLength = 2000
        Me.AuditReasonTextEdit.Size = New System.Drawing.Size(296, 54)
        Me.AuditReasonTextEdit.TabIndex = 14
        Me.AuditReasonTextEdit.UseOptimizedRendering = True
        '
        'ComponentRibbonControl1
        '
        Me.ComponentRibbonControl1.ApplicationButtonText = Nothing
        Me.ComponentRibbonControl1.ExpandCollapseItem.Id = 0
        Me.ComponentRibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ComponentRibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnAlterAdd, Me.btnAlterEdit, Me.btnAlterDelete, Me.btnCancel})
        Me.ComponentRibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ComponentRibbonControl1.MaxItemId = 30
        Me.ComponentRibbonControl1.Name = "ComponentRibbonControl1"
        Me.ComponentRibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.ComponentRibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ComponentRibbonControl1.ShowToolbarCustomizeItem = False
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(395, 93)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAlterAdd
        '
        Me.btnAlterAdd.Caption = "Add New Comp Alternate"
        Me.btnAlterAdd.Id = 24
        Me.btnAlterAdd.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAlterAdd.Name = "btnAlterAdd"
        '
        'btnAlterEdit
        '
        Me.btnAlterEdit.Caption = "Edit Comp Alternate"
        Me.btnAlterEdit.Glyph = Global.AOS.My.Resources.Resources.document_edit__2_
        Me.btnAlterEdit.Id = 25
        Me.btnAlterEdit.Name = "btnAlterEdit"
        '
        'btnAlterDelete
        '
        Me.btnAlterDelete.Caption = "Delete Comp alternate"
        Me.btnAlterDelete.Glyph = CType(resources.GetObject("btnAlterDelete.Glyph"), System.Drawing.Image)
        Me.btnAlterDelete.Id = 26
        Me.btnAlterDelete.Name = "btnAlterDelete"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 29
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
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Audit Reason"
        '
        'pnlProductSelection
        '
        Me.pnlProductSelection.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pnlProductSelection.Controls.Add(Me.gcLeft)
        Me.pnlProductSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProductSelection.Location = New System.Drawing.Point(0, 93)
        Me.pnlProductSelection.Name = "pnlProductSelection"
        Me.pnlProductSelection.Size = New System.Drawing.Size(395, 109)
        Me.pnlProductSelection.TabIndex = 19
        '
        'frmAuditReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlProductSelection)
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAuditReason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Audit Reason"
        CType(Me.gcLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcLeft.ResumeLayout(False)
        Me.gcLeft.PerformLayout()
        CType(Me.AuditReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlProductSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProductSelection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gcLeft As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ComponentRibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents pnlProductSelection As DevExpress.XtraEditors.PanelControl
    Friend WithEvents AuditReasonTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
End Class
