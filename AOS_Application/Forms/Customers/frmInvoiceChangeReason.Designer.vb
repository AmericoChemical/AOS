<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoiceChangeReason
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
        Me.components = New System.ComponentModel.Container()
        Dim AuditReasonLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoiceChangeReason))
        Me.gcLeft = New DevExpress.XtraEditors.GroupControl()
        Me.InvoiceChangeReasonTextEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.pnlProductSelection = New DevExpress.XtraEditors.PanelControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsInvoiceHistoryHeader = New System.Windows.Forms.BindingSource(Me.components)
        AuditReasonLabel = New System.Windows.Forms.Label()
        CType(Me.gcLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcLeft.SuspendLayout()
        CType(Me.InvoiceChangeReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlProductSelection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProductSelection.SuspendLayout()
        CType(Me.bsInvoiceHistoryHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AuditReasonLabel
        '
        AuditReasonLabel.AutoSize = True
        AuditReasonLabel.Location = New System.Drawing.Point(10, 37)
        AuditReasonLabel.Name = "AuditReasonLabel"
        AuditReasonLabel.Size = New System.Drawing.Size(43, 13)
        AuditReasonLabel.TabIndex = 13
        AuditReasonLabel.Text = "Reason"
        '
        'gcLeft
        '
        Me.gcLeft.Controls.Add(AuditReasonLabel)
        Me.gcLeft.Controls.Add(Me.InvoiceChangeReasonTextEdit)
        Me.gcLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcLeft.Location = New System.Drawing.Point(0, 0)
        Me.gcLeft.Name = "gcLeft"
        Me.gcLeft.Size = New System.Drawing.Size(395, 87)
        Me.gcLeft.TabIndex = 14
        Me.gcLeft.Text = "Reason For Invoice Change"
        '
        'InvoiceChangeReasonTextEdit
        '
        Me.InvoiceChangeReasonTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvoiceHistoryHeader, "ChangeReason", True))
        Me.InvoiceChangeReasonTextEdit.Location = New System.Drawing.Point(87, 34)
        Me.InvoiceChangeReasonTextEdit.Name = "InvoiceChangeReasonTextEdit"
        Me.InvoiceChangeReasonTextEdit.Properties.MaxLength = 2000
        Me.InvoiceChangeReasonTextEdit.Size = New System.Drawing.Size(296, 54)
        Me.InvoiceChangeReasonTextEdit.TabIndex = 14
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
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(395, 115)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAlterAdd
        '
        Me.btnAlterAdd.Caption = "Add New Comp Alternate"
        Me.btnAlterAdd.Id = 24
        Me.btnAlterAdd.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAlterAdd.Name = "btnAlterAdd"
        '
        'btnAlterEdit
        '
        Me.btnAlterEdit.Caption = "Edit Comp Alternate"
        Me.btnAlterEdit.Id = 25
        Me.btnAlterEdit.ImageOptions.Image = Global.AOS.My.Resources.Resources.document_edit__2_
        Me.btnAlterEdit.Name = "btnAlterEdit"
        '
        'btnAlterDelete
        '
        Me.btnAlterDelete.Caption = "Delete Comp alternate"
        Me.btnAlterDelete.Id = 26
        Me.btnAlterDelete.ImageOptions.Image = CType(resources.GetObject("btnAlterDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAlterDelete.Name = "btnAlterDelete"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 29
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
        Me.pnlProductSelection.Location = New System.Drawing.Point(0, 115)
        Me.pnlProductSelection.Name = "pnlProductSelection"
        Me.pnlProductSelection.Size = New System.Drawing.Size(395, 87)
        Me.pnlProductSelection.TabIndex = 19
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsInvoiceHistoryHeader
        '
        Me.bsInvoiceHistoryHeader.DataSource = GetType(AOS.BusinessObjects.Invoicehistoryheader)
        '
        'frmInvoiceChangeReason
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 202)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlProductSelection)
        Me.Controls.Add(Me.ComponentRibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmInvoiceChangeReason"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Invoice Change Reason"
        CType(Me.gcLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcLeft.ResumeLayout(False)
        Me.gcLeft.PerformLayout()
        CType(Me.InvoiceChangeReasonTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlProductSelection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProductSelection.ResumeLayout(False)
        CType(Me.bsInvoiceHistoryHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents InvoiceChangeReasonTextEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bsInvoiceHistoryHeader As BindingSource
End Class
