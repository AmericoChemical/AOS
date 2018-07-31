<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditFreightSettings

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
        Dim MaxLoadWeightLabel As System.Windows.Forms.Label
        Dim FreezeWarningLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditFreightSettings))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsParms = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.Ribbon_LargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem()
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem()
        Me.rTxtShipmentNumber = New DevExpress.XtraBars.BarStaticItem()
        Me.rtxtPurchaseOrder = New DevExpress.XtraBars.BarStaticItem()
        Me.rTxtCustomerName = New DevExpress.XtraBars.BarStaticItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.eMaxWgt = New DevExpress.XtraEditors.TextEdit()
        Me.eFreeze = New DevExpress.XtraEditors.CheckEdit()
        MaxLoadWeightLabel = New System.Windows.Forms.Label()
        FreezeWarningLabel = New System.Windows.Forms.Label()
        CType(Me.bsParms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.eMaxWgt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFreeze.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaxLoadWeightLabel
        '
        MaxLoadWeightLabel.AutoSize = True
        MaxLoadWeightLabel.Location = New System.Drawing.Point(11, 64)
        MaxLoadWeightLabel.Name = "MaxLoadWeightLabel"
        MaxLoadWeightLabel.Size = New System.Drawing.Size(94, 13)
        MaxLoadWeightLabel.TabIndex = 2
        MaxLoadWeightLabel.Text = "Max Load Weight:"
        '
        'FreezeWarningLabel
        '
        FreezeWarningLabel.AutoSize = True
        FreezeWarningLabel.Location = New System.Drawing.Point(18, 39)
        FreezeWarningLabel.Name = "FreezeWarningLabel"
        FreezeWarningLabel.Size = New System.Drawing.Size(87, 13)
        FreezeWarningLabel.TabIndex = 0
        FreezeWarningLabel.Text = "Freeze Warning:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsParms
        '
        Me.bsParms.DataSource = GetType(AOS.BusinessObjects.Sysparameters)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Images = Me.Ribbon_LargeImages
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.BarStaticItem1, Me.BarStaticItem2, Me.BarStaticItem3, Me.rTxtShipmentNumber, Me.rtxtPurchaseOrder, Me.rTxtCustomerName})
        Me.RibbonControl1.LargeImages = Me.Ribbon_LargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(6, 6)
        Me.RibbonControl1.MaxItemId = 24
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(292, 94)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'Ribbon_LargeImages
        '
        Me.Ribbon_LargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.Ribbon_LargeImages.ImageStream = CType(resources.GetObject("Ribbon_LargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 6
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 16
        Me.btnCancel.LargeImageIndex = 7
        Me.btnCancel.Name = "btnCancel"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "Load Number"
        Me.BarStaticItem1.Id = 17
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Caption = "Source Doc"
        Me.BarStaticItem2.Id = 18
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Caption = "Customer Name"
        Me.BarStaticItem3.Id = 19
        Me.BarStaticItem3.Name = "BarStaticItem3"
        Me.BarStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rTxtShipmentNumber
        '
        Me.rTxtShipmentNumber.Caption = "999999 - 12/31/2099"
        Me.rTxtShipmentNumber.Id = 20
        Me.rTxtShipmentNumber.Name = "rTxtShipmentNumber"
        Me.rTxtShipmentNumber.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rtxtPurchaseOrder
        '
        Me.rtxtPurchaseOrder.Caption = "ABCDEFGHIJK"
        Me.rtxtPurchaseOrder.Id = 21
        Me.rtxtPurchaseOrder.Name = "rtxtPurchaseOrder"
        Me.rtxtPurchaseOrder.TextAlignment = System.Drawing.StringAlignment.Near
        '
        'rTxtCustomerName
        '
        Me.rTxtCustomerName.Caption = "Americo Chemical Products, Inc."
        Me.rTxtCustomerName.Id = 22
        Me.rTxtCustomerName.Name = "rTxtCustomerName"
        Me.rTxtCustomerName.TextAlignment = System.Drawing.StringAlignment.Near
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(MaxLoadWeightLabel)
        Me.GroupControl7.Controls.Add(Me.eMaxWgt)
        Me.GroupControl7.Controls.Add(FreezeWarningLabel)
        Me.GroupControl7.Controls.Add(Me.eFreeze)
        Me.GroupControl7.Location = New System.Drawing.Point(27, 124)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(245, 108)
        Me.GroupControl7.TabIndex = 1
        Me.GroupControl7.Text = "Current Freight Management Settings"
        '
        'eMaxWgt
        '
        Me.eMaxWgt.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "MaxLoadWeight", True))
        Me.eMaxWgt.Location = New System.Drawing.Point(111, 61)
        Me.eMaxWgt.MenuManager = Me.RibbonControl1
        Me.eMaxWgt.Name = "eMaxWgt"
        Me.eMaxWgt.Size = New System.Drawing.Size(73, 20)
        Me.eMaxWgt.TabIndex = 3
        '
        'eFreeze
        '
        Me.eFreeze.Location = New System.Drawing.Point(109, 36)
        Me.eFreeze.MenuManager = Me.RibbonControl1
        Me.eFreeze.Name = "eFreeze"
        Me.eFreeze.Properties.Caption = ""
        Me.eFreeze.Size = New System.Drawing.Size(75, 19)
        Me.eFreeze.TabIndex = 1
        '
        'frmEditFreightSettings
        '
        Me.ClientSize = New System.Drawing.Size(304, 260)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl7)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmEditFreightSettings"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Freight Settings"
        CType(Me.bsParms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.eMaxWgt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFreeze.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsParms As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rTxtShipmentNumber As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rtxtPurchaseOrder As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents rTxtCustomerName As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents Ribbon_LargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eMaxWgt As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eFreeze As DevExpress.XtraEditors.CheckEdit
End Class
