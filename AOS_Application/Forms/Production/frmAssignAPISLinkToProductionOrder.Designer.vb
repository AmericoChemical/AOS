<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignAPISLinkToProductionOrder

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
        Dim ApisnumLabel As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.eAPISNum = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsAPIS = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        ApisnumLabel = New System.Windows.Forms.Label()
        CType(Me.eAPISNum.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAPIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ApisnumLabel
        '
        ApisnumLabel.AutoSize = True
        ApisnumLabel.Location = New System.Drawing.Point(67, 30)
        ApisnumLabel.Name = "ApisnumLabel"
        ApisnumLabel.Size = New System.Drawing.Size(42, 13)
        ApisnumLabel.TabIndex = 6
        ApisnumLabel.Text = "APIS#:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'eAPISNum
        '
        Me.eAPISNum.Location = New System.Drawing.Point(115, 27)
        Me.eAPISNum.Name = "eAPISNum"
        Me.eAPISNum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eAPISNum.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apisnum", "APIS#", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apisdesc", "APIS Desc", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productid", "Prod ID", 70, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Productdesc", "Product Desc", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apisstatus", 100, "Status")})
        Me.eAPISNum.Properties.DataSource = Me.bsAPIS
        Me.eAPISNum.Properties.DisplayMember = "Apisnum"
        Me.eAPISNum.Properties.DropDownRows = 15
        Me.eAPISNum.Properties.NullText = ""
        Me.eAPISNum.Properties.PopupWidth = 695
        Me.eAPISNum.Properties.ShowFooter = False
        Me.eAPISNum.Properties.ValueMember = "Apisnum"
        Me.eAPISNum.Size = New System.Drawing.Size(61, 20)
        Me.eAPISNum.TabIndex = 7
        '
        'bsAPIS
        '
        Me.bsAPIS.DataSource = GetType(AOS.BusinessObjects.ViewAPISDataCollection)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(32, 76)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(193, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Assign APIS to Production Order"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(32, 115)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(193, 23)
        Me.SimpleButton1.TabIndex = 12
        Me.SimpleButton1.Text = "Cancel"
        '
        'frmAssignAPISLinkToProductionOrder
        '
        Me.ClientSize = New System.Drawing.Size(260, 175)
        Me.ControlBox = False
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(ApisnumLabel)
        Me.Controls.Add(Me.eAPISNum)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAssignAPISLinkToProductionOrder"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select APIS"
        CType(Me.eAPISNum.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAPIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents bsAPIS As System.Windows.Forms.BindingSource
    Friend WithEvents eAPISNum As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
