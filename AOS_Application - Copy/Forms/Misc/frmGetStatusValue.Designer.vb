<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGetStatusValue

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
        Me.eProductStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTitle.SuspendLayout()
        CType(Me.eProductStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.eProductStatus)
        Me.grpTitle.Controls.Add(Me.SimpleButton1)
        Me.grpTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTitle.Location = New System.Drawing.Point(0, 0)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(192, 122)
        Me.grpTitle.TabIndex = 0
        Me.grpTitle.Text = "Select a Status Value"
        '
        'eProductStatus
        '
        Me.eProductStatus.Location = New System.Drawing.Point(21, 37)
        Me.eProductStatus.Name = "eProductStatus"
        Me.eProductStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eProductStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productstatus", 100, "Status")})
        Me.eProductStatus.Properties.DataSource = Me.bsProduct
        Me.eProductStatus.Properties.DisplayMember = "Productstatus"
        Me.eProductStatus.Properties.NullText = ""
        Me.eProductStatus.Properties.PopupSizeable = False
        Me.eProductStatus.Properties.PopupWidth = 150
        Me.eProductStatus.Properties.ShowFooter = False
        Me.eProductStatus.Properties.ShowHeader = False
        Me.eProductStatus.Properties.ValueMember = "Productstatus"
        Me.eProductStatus.Size = New System.Drawing.Size(150, 20)
        Me.eProductStatus.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(54, 74)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "OK"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.ListProductstatusCollection)
        '
        'frmGetStatusValue
        '
        Me.ClientSize = New System.Drawing.Size(192, 122)
        Me.Controls.Add(Me.grpTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGetStatusValue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGetDataItem"
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTitle.ResumeLayout(False)
        CType(Me.eProductStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTitle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eProductStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsProduct As BindingSource
    Friend WithEvents Timer1 As Timer
End Class
