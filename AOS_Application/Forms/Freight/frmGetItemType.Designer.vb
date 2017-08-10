<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetItemType

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
        Me.grpTitle = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.eItemTypes = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.bsItemTypes = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTitle.SuspendLayout()
        CType(Me.eItemTypes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItemTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.LabelControl1)
        Me.grpTitle.Controls.Add(Me.SimpleButton1)
        Me.grpTitle.Controls.Add(Me.eItemTypes)
        Me.grpTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTitle.Location = New System.Drawing.Point(0, 0)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(241, 127)
        Me.grpTitle.TabIndex = 0
        Me.grpTitle.Text = "Load Item Type"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(83, 83)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "OK"
        '
        'eItemTypes
        '
        Me.eItemTypes.Location = New System.Drawing.Point(44, 55)
        Me.eItemTypes.Name = "eItemTypes"
        Me.eItemTypes.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eItemTypes.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Itemtype", "Item Type", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eItemTypes.Properties.DataSource = Me.bsItemTypes
        Me.eItemTypes.Properties.DisplayMember = "Itemtype"
        Me.eItemTypes.Properties.NullText = ""
        Me.eItemTypes.Properties.PopupSizeable = False
        Me.eItemTypes.Properties.PopupWidth = 150
        Me.eItemTypes.Properties.ShowFooter = False
        Me.eItemTypes.Properties.ShowHeader = False
        Me.eItemTypes.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.eItemTypes.Properties.ValueMember = "Itemtype"
        Me.eItemTypes.Size = New System.Drawing.Size(150, 20)
        Me.eItemTypes.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(44, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Select the Item Type:"
        '
        'bsItemTypes
        '
        Me.bsItemTypes.DataSource = GetType(AOS.BusinessObjects.ListItemtypeCollection)
        '
        'frmGetItemType
        '
        Me.ClientSize = New System.Drawing.Size(241, 127)
        Me.Controls.Add(Me.grpTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGetItemType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGetDataItem"
        CType(Me.grpTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
        CType(Me.eItemTypes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItemTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpTitle As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eItemTypes As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bsItemTypes As System.Windows.Forms.BindingSource
End Class
