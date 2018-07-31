<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcessRelabelItem

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
        Dim LotNoLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim InvItemNoLabel1 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcessRelabelItem))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.rbtnReturn = New DevExpress.XtraBars.BarButtonItem()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.StatusTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsInvItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvItemnoTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bsRelabelItem = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit6 = New DevExpress.XtraEditors.TextEdit()
        Me.bsRelabelOrder = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btnMarkAsCompleted = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit12 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit11 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit7 = New DevExpress.XtraEditors.TextEdit()
        LotNoLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        InvItemNoLabel1 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInvItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvItemnoTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRelabelItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRelabelOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LotNoLabel
        '
        LotNoLabel.AutoSize = True
        LotNoLabel.Location = New System.Drawing.Point(176, 30)
        LotNoLabel.Name = "LotNoLabel"
        LotNoLabel.Size = New System.Drawing.Size(62, 13)
        LotNoLabel.TabIndex = 4
        LotNoLabel.Text = "Lot Number"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(91, 30)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(63, 13)
        StatusLabel.TabIndex = 2
        StatusLabel.Text = "Item Status"
        '
        'InvItemNoLabel1
        '
        InvItemNoLabel1.AutoSize = True
        InvItemNoLabel1.Location = New System.Drawing.Point(12, 30)
        InvItemNoLabel1.Name = "InvItemNoLabel1"
        InvItemNoLabel1.Size = New System.Drawing.Size(40, 13)
        InvItemNoLabel1.TabIndex = 0
        InvItemNoLabel1.Text = "Item #"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(73, 13)
        Label1.TabIndex = 2
        Label1.Text = "Relabel Order"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(12, 65)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(43, 13)
        Label2.TabIndex = 4
        Label2.Text = "Item ID"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(91, 26)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(63, 13)
        Label3.TabIndex = 7
        Label3.Text = "Work Order"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(176, 26)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(53, 13)
        Label4.TabIndex = 9
        Label4.Text = "Customer"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(91, 65)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(85, 13)
        Label5.TabIndex = 12
        Label5.Text = "Item Description"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(416, 65)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(54, 13)
        Label6.TabIndex = 13
        Label6.Text = "Container"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(12, 69)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(43, 13)
        Label7.TabIndex = 12
        Label7.Text = "Item ID"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(94, 69)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(85, 13)
        Label8.TabIndex = 13
        Label8.Text = "Item Description"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(416, 69)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(54, 13)
        Label9.TabIndex = 16
        Label9.Text = "Container"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(12, 108)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(67, 13)
        Label10.TabIndex = 19
        Label10.Text = "Source Type"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(94, 108)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(91, 13)
        Label11.TabIndex = 20
        Label11.Text = "Source Document"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.rbtnReturn})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 7
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(505, 95)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'rbtnReturn
        '
        Me.rbtnReturn.Caption = "Close"
        Me.rbtnReturn.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnReturn.Id = 6
        Me.rbtnReturn.LargeImageIndex = 0
        Me.rbtnReturn.Name = "rbtnReturn"
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnReturn)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'StatusTextEdit
        '
        Me.StatusTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvItem, "Itemstatus", True))
        Me.StatusTextEdit.Location = New System.Drawing.Point(94, 46)
        Me.StatusTextEdit.Name = "StatusTextEdit"
        Me.StatusTextEdit.Properties.MaxLength = 50
        Me.StatusTextEdit.Properties.ReadOnly = True
        Me.StatusTextEdit.Size = New System.Drawing.Size(76, 20)
        Me.StatusTextEdit.TabIndex = 3
        '
        'bsInvItem
        '
        Me.bsInvItem.DataSource = GetType(AOS.BusinessObjects.Invitem)
        '
        'InvItemnoTextEdit
        '
        Me.InvItemnoTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelItem, "Invitemnum", True))
        Me.InvItemnoTextEdit.Location = New System.Drawing.Point(12, 46)
        Me.InvItemnoTextEdit.Name = "InvItemnoTextEdit"
        Me.InvItemnoTextEdit.Properties.MaxLength = 50
        Me.InvItemnoTextEdit.Properties.ReadOnly = True
        Me.InvItemnoTextEdit.Size = New System.Drawing.Size(76, 20)
        Me.InvItemnoTextEdit.TabIndex = 1
        '
        'bsRelabelItem
        '
        Me.bsRelabelItem.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrderItem)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label6)
        Me.GroupControl1.Controls.Add(Label5)
        Me.GroupControl1.Controls.Add(Me.TextEdit6)
        Me.GroupControl1.Controls.Add(Me.TextEdit5)
        Me.GroupControl1.Controls.Add(Label4)
        Me.GroupControl1.Controls.Add(Me.TextEdit4)
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.TextEdit2)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 95)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(505, 115)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Inventory Item to be Created by Relabel Process"
        '
        'TextEdit6
        '
        Me.TextEdit6.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Container", True))
        Me.TextEdit6.Location = New System.Drawing.Point(419, 81)
        Me.TextEdit6.Name = "TextEdit6"
        Me.TextEdit6.Properties.MaxLength = 50
        Me.TextEdit6.Properties.ReadOnly = True
        Me.TextEdit6.Size = New System.Drawing.Size(76, 20)
        Me.TextEdit6.TabIndex = 11
        '
        'bsRelabelOrder
        '
        Me.bsRelabelOrder.DataSource = GetType(AOS.BusinessObjects.ViewRelabelOrder)
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Itemdesc", True))
        Me.TextEdit5.Location = New System.Drawing.Point(94, 81)
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Properties.MaxLength = 50
        Me.TextEdit5.Properties.ReadOnly = True
        Me.TextEdit5.Size = New System.Drawing.Size(319, 20)
        Me.TextEdit5.TabIndex = 10
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Custname", True))
        Me.TextEdit4.Location = New System.Drawing.Point(176, 42)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.MaxLength = 50
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(319, 20)
        Me.TextEdit4.TabIndex = 8
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Workordernumber", True))
        Me.TextEdit3.Location = New System.Drawing.Point(94, 42)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.MaxLength = 50
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(76, 20)
        Me.TextEdit3.TabIndex = 6
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Itemid", True))
        Me.TextEdit2.Location = New System.Drawing.Point(12, 81)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.MaxLength = 50
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(76, 20)
        Me.TextEdit2.TabIndex = 5
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelOrder, "Relabelordernumber", True))
        Me.TextEdit1.Location = New System.Drawing.Point(12, 42)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.MaxLength = 50
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(76, 20)
        Me.TextEdit1.TabIndex = 3
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.btnMarkAsCompleted)
        Me.GroupControl2.Controls.Add(Label11)
        Me.GroupControl2.Controls.Add(Label10)
        Me.GroupControl2.Controls.Add(Me.TextEdit12)
        Me.GroupControl2.Controls.Add(Me.TextEdit11)
        Me.GroupControl2.Controls.Add(Label9)
        Me.GroupControl2.Controls.Add(Me.TextEdit10)
        Me.GroupControl2.Controls.Add(Me.TextEdit9)
        Me.GroupControl2.Controls.Add(Label8)
        Me.GroupControl2.Controls.Add(Label7)
        Me.GroupControl2.Controls.Add(Me.TextEdit8)
        Me.GroupControl2.Controls.Add(Me.TextEdit7)
        Me.GroupControl2.Controls.Add(Me.StatusTextEdit)
        Me.GroupControl2.Controls.Add(Me.InvItemnoTextEdit)
        Me.GroupControl2.Controls.Add(InvItemNoLabel1)
        Me.GroupControl2.Controls.Add(LotNoLabel)
        Me.GroupControl2.Controls.Add(StatusLabel)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(0, 210)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(505, 199)
        Me.GroupControl2.TabIndex = 2
        Me.GroupControl2.Text = "Inventory Item that will be Relabeled"
        '
        'btnMarkAsCompleted
        '
        Me.btnMarkAsCompleted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMarkAsCompleted.Location = New System.Drawing.Point(149, 164)
        Me.btnMarkAsCompleted.Name = "btnMarkAsCompleted"
        Me.btnMarkAsCompleted.Size = New System.Drawing.Size(207, 23)
        Me.btnMarkAsCompleted.TabIndex = 21
        Me.btnMarkAsCompleted.Text = "Process Relabel - Mark as Completed"
        '
        'TextEdit12
        '
        Me.TextEdit12.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelItem, "Sourcedoc", True))
        Me.TextEdit12.Location = New System.Drawing.Point(94, 124)
        Me.TextEdit12.Name = "TextEdit12"
        Me.TextEdit12.Properties.MaxLength = 50
        Me.TextEdit12.Properties.ReadOnly = True
        Me.TextEdit12.Size = New System.Drawing.Size(76, 20)
        Me.TextEdit12.TabIndex = 18
        '
        'TextEdit11
        '
        Me.TextEdit11.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelItem, "Sourcetype", True))
        Me.TextEdit11.Location = New System.Drawing.Point(12, 124)
        Me.TextEdit11.Name = "TextEdit11"
        Me.TextEdit11.Properties.MaxLength = 50
        Me.TextEdit11.Properties.ReadOnly = True
        Me.TextEdit11.Size = New System.Drawing.Size(76, 20)
        Me.TextEdit11.TabIndex = 17
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelItem, "Container", True))
        Me.TextEdit10.Location = New System.Drawing.Point(419, 85)
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Properties.MaxLength = 50
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.Size = New System.Drawing.Size(76, 20)
        Me.TextEdit10.TabIndex = 15
        '
        'TextEdit9
        '
        Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsInvItem, "Lotnumber", True))
        Me.TextEdit9.Location = New System.Drawing.Point(176, 46)
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.MaxLength = 50
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Size = New System.Drawing.Size(132, 20)
        Me.TextEdit9.TabIndex = 14
        '
        'TextEdit8
        '
        Me.TextEdit8.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelItem, "Itemdesc", True))
        Me.TextEdit8.Location = New System.Drawing.Point(94, 85)
        Me.TextEdit8.Name = "TextEdit8"
        Me.TextEdit8.Properties.MaxLength = 50
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.Size = New System.Drawing.Size(319, 20)
        Me.TextEdit8.TabIndex = 11
        '
        'TextEdit7
        '
        Me.TextEdit7.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsRelabelItem, "Itemid", True))
        Me.TextEdit7.Location = New System.Drawing.Point(12, 85)
        Me.TextEdit7.Name = "TextEdit7"
        Me.TextEdit7.Properties.MaxLength = 50
        Me.TextEdit7.Properties.ReadOnly = True
        Me.TextEdit7.Size = New System.Drawing.Size(76, 20)
        Me.TextEdit7.TabIndex = 6
        '
        'frmProcessRelabelItem
        '
        Me.ClientSize = New System.Drawing.Size(505, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmProcessRelabelItem"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Process Relabel Item"
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInvItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvItemnoTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRelabelItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit6.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRelabelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TextEdit12.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit11.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit7.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents StatusTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents InvItemnoTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsRelabelItem As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rbtnReturn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents bsInvItem As System.Windows.Forms.BindingSource
    Friend WithEvents TextEdit6 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsRelabelOrder As System.Windows.Forms.BindingSource
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnMarkAsCompleted As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit12 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit11 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit7 As DevExpress.XtraEditors.TextEdit
End Class
