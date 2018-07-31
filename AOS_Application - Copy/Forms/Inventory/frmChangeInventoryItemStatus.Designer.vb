<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeInventoryItemStatus
    Inherits System.Windows.Forms.Form

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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lblDate = New DevExpress.XtraEditors.LabelControl()
        Me.lblDoc = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.eReason = New DevExpress.XtraEditors.MemoEdit()
        Me.eDate = New DevExpress.XtraEditors.DateEdit()
        Me.eDoc = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblInvItemNumber = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
        Me.eStatus = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsStatusList = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eReason.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStatusList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lblDate)
        Me.GroupControl1.Controls.Add(Me.lblDoc)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.eReason)
        Me.GroupControl1.Controls.Add(Me.eDate)
        Me.GroupControl1.Controls.Add(Me.eDoc)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.lblInvItemNumber)
        Me.GroupControl1.Controls.Add(Me.PictureEdit1)
        Me.GroupControl1.Controls.Add(Me.PanelControl1)
        Me.GroupControl1.Controls.Add(Me.eStatus)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl1.Location = New System.Drawing.Point(0, 0)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(424, 287)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Change Inventory Item Status"
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(51, 214)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(27, 13)
        Me.lblDate.TabIndex = 15
        Me.lblDate.Text = "Date:"
        '
        'lblDoc
        '
        Me.lblDoc.Location = New System.Drawing.Point(51, 188)
        Me.lblDoc.Name = "lblDoc"
        Me.lblDoc.Size = New System.Drawing.Size(52, 13)
        Me.lblDoc.TabIndex = 14
        Me.lblDoc.Text = "Document:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(51, 138)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Reason for Change:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(51, 112)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "New Item Status:"
        '
        'eReason
        '
        Me.eReason.Location = New System.Drawing.Point(154, 135)
        Me.eReason.Name = "eReason"
        Me.eReason.Size = New System.Drawing.Size(241, 44)
        Me.eReason.TabIndex = 11
        '
        'eDate
        '
        Me.eDate.EditValue = Nothing
        Me.eDate.Location = New System.Drawing.Point(154, 211)
        Me.eDate.Name = "eDate"
        Me.eDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.eDate.Size = New System.Drawing.Size(100, 20)
        Me.eDate.TabIndex = 10
        '
        'eDoc
        '
        Me.eDoc.Location = New System.Drawing.Point(154, 185)
        Me.eDoc.Name = "eDoc"
        Me.eDoc.Size = New System.Drawing.Size(100, 20)
        Me.eDoc.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsItem, "Itemstatus", True))
        Me.LabelControl4.Location = New System.Drawing.Point(132, 76)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "AVAILABLE"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(51, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Current Status:"
        '
        'LabelControl2
        '
        Me.LabelControl2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProduct, "Productdesc", True))
        Me.LabelControl2.Location = New System.Drawing.Point(88, 58)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Product Description"
        '
        'LabelControl1
        '
        Me.LabelControl1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsItem, "Productid", True))
        Me.LabelControl1.Location = New System.Drawing.Point(51, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "5678"
        '
        'lblInvItemNumber
        '
        Me.lblInvItemNumber.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvItemNumber.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsItem, "Invitemnumber", True))
        Me.lblInvItemNumber.Location = New System.Drawing.Point(51, 30)
        Me.lblInvItemNumber.Name = "lblInvItemNumber"
        Me.lblInvItemNumber.Size = New System.Drawing.Size(60, 19)
        Me.lblInvItemNumber.TabIndex = 3
        Me.lblInvItemNumber.Text = "123456"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.AOS.My.Resources.Resources.InventoryItem_SingleImage
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 24)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Size = New System.Drawing.Size(32, 32)
        Me.PictureEdit1.TabIndex = 2
        '
        'PanelControl1
        '
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.btnCancel)
        Me.PanelControl1.Controls.Add(Me.btnSave)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(2, 245)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(420, 40)
        Me.PanelControl1.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Location = New System.Drawing.Point(224, 9)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSave.Location = New System.Drawing.Point(125, 9)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        '
        'eStatus
        '
        Me.eStatus.Location = New System.Drawing.Point(154, 109)
        Me.eStatus.Name = "eStatus"
        Me.eStatus.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eStatus.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LookupDesc", 150, "Status")})
        Me.eStatus.Properties.DataSource = Me.bsStatusList
        Me.eStatus.Properties.DisplayMember = "LookupDesc"
        Me.eStatus.Properties.DropDownRows = 10
        Me.eStatus.Properties.NullText = ""
        Me.eStatus.Properties.PopupWidth = 170
        Me.eStatus.Properties.ValueMember = "LookupDesc"
        Me.eStatus.Size = New System.Drawing.Size(241, 20)
        Me.eStatus.TabIndex = 0
        '
        'bsItem
        '
        Me.bsItem.DataSource = GetType(AOS.BusinessObjects.Invitem)
        '
        'bsProduct
        '
        Me.bsProduct.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'bsStatusList
        '
        Me.bsStatusList.DataSource = GetType(AOS.BusinessObjects.ListInvitemstatusCollection)
        '
        'frmChangeInventoryItemStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeInventoryItemStatus"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Inventory Item Status"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eReason.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStatusList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsItem As System.Windows.Forms.BindingSource
    Friend WithEvents bsStatusList As System.Windows.Forms.BindingSource
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eStatus As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lblDate As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblDoc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eReason As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents eDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents eDoc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblInvItemNumber As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bsProduct As System.Windows.Forms.BindingSource
End Class
