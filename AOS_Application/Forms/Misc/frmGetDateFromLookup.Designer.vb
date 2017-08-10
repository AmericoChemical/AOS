<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGetDateFromLookup

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpTitle = New DevExpress.XtraEditors.GroupControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.eDate = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsDateList = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTitle.SuspendLayout()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDateList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.btnCancel)
        Me.grpTitle.Controls.Add(Me.eDate)
        Me.grpTitle.Controls.Add(Me.btnOK)
        Me.grpTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTitle.Location = New System.Drawing.Point(0, 0)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(221, 127)
        Me.grpTitle.TabIndex = 0
        Me.grpTitle.Text = "Pick Date from List"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(113, 79)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        '
        'eDate
        '
        Me.eDate.Location = New System.Drawing.Point(52, 42)
        Me.eDate.Name = "eDate"
        Me.eDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDate.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Datecommissionpaid", 100, "Pmt Date")})
        Me.eDate.Properties.DataSource = Me.bsDateList
        Me.eDate.Properties.DisplayMember = "Datecommissionpaid"
        Me.eDate.Properties.NullText = ""
        Me.eDate.Properties.PopupSizeable = False
        Me.eDate.Properties.PopupWidth = 150
        Me.eDate.Properties.ShowFooter = False
        Me.eDate.Properties.ShowHeader = False
        Me.eDate.Properties.ValueMember = "Datecommissionpaid"
        Me.eDate.Size = New System.Drawing.Size(117, 20)
        Me.eDate.TabIndex = 3
        '
        'bsDateList
        '
        Me.bsDateList.DataSource = GetType(AOS.BusinessObjects.ViewCommissionPaymentDatesCollection)
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(32, 79)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmGetDateFromLookup
        '
        Me.ClientSize = New System.Drawing.Size(221, 127)
        Me.Controls.Add(Me.grpTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGetDateFromLookup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGetDataItem"
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTitle.ResumeLayout(False)
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDateList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTitle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eDate As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsDateList As BindingSource
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
End Class
