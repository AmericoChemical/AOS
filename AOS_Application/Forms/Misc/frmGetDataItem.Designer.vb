<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetDataItem

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
        Me.grpTitle = New DevExpress.XtraEditors.GroupControl()
        Me.eInteger = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.eDate = New DevExpress.XtraEditors.DateEdit()
        Me.eString = New DevExpress.XtraEditors.TextEdit()
        Me.eDecimal = New DevExpress.XtraEditors.TextEdit()
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTitle.SuspendLayout()
        CType(Me.eInteger.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDecimal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.eDecimal)
        Me.grpTitle.Controls.Add(Me.eInteger)
        Me.grpTitle.Controls.Add(Me.SimpleButton1)
        Me.grpTitle.Controls.Add(Me.eDate)
        Me.grpTitle.Controls.Add(Me.eString)
        Me.grpTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTitle.Location = New System.Drawing.Point(0, 0)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(439, 96)
        Me.grpTitle.TabIndex = 0
        Me.grpTitle.Text = "Input Value"
        '
        'eInteger
        '
        Me.eInteger.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eInteger.Location = New System.Drawing.Point(199, 33)
        Me.eInteger.Name = "eInteger"
        Me.eInteger.Properties.DisplayFormat.FormatString = "n"
        Me.eInteger.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eInteger.Size = New System.Drawing.Size(40, 20)
        Me.eInteger.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(182, 61)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "OK"
        '
        'eDate
        '
        Me.eDate.EditValue = Nothing
        Me.eDate.Location = New System.Drawing.Point(169, 33)
        Me.eDate.Name = "eDate"
        Me.eDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eDate.Size = New System.Drawing.Size(101, 20)
        Me.eDate.TabIndex = 1
        '
        'eString
        '
        Me.eString.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eString.Location = New System.Drawing.Point(15, 33)
        Me.eString.Name = "eString"
        Me.eString.Size = New System.Drawing.Size(408, 20)
        Me.eString.TabIndex = 0
        '
        'eDecimal
        '
        Me.eDecimal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.eDecimal.Location = New System.Drawing.Point(182, 33)
        Me.eDecimal.Name = "eDecimal"
        Me.eDecimal.Properties.DisplayFormat.FormatString = "c2"
        Me.eDecimal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.eDecimal.Size = New System.Drawing.Size(75, 20)
        Me.eDecimal.TabIndex = 4
        '
        'frmGetDataItem
        '
        Me.ClientSize = New System.Drawing.Size(439, 96)
        Me.Controls.Add(Me.grpTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGetDataItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGetDataItem"
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTitle.ResumeLayout(False)
        CType(Me.eInteger.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDecimal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTitle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eString As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eInteger As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eDecimal As DevExpress.XtraEditors.TextEdit
End Class
