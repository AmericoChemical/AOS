<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditLoadCharge

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditLoadCharge))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsCharge = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.bsLoadInfo = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.eDestination = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.eOrigin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.eAmount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.eChrgDate = New DevExpress.XtraEditors.DateEdit()
        Me.TextEdit10 = New DevExpress.XtraEditors.MemoEdit()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.eCarrier = New DevExpress.XtraEditors.LookUpEdit()
        Me.eLogistics = New DevExpress.XtraEditors.LookUpEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.bsQuote = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.bsCharge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDestination.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eOrigin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.eAmount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChrgDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChrgDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCarrier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLogistics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsQuote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsCharge
        '
        Me.bsCharge.DataSource = GetType(AOS.BusinessObjects.Loadcharge)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.RibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(457, 94)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 0
        Me.btnNewCostRecord.LargeGlyph = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Glyph = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCostRecord.Id = 1
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Glyph = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCostRecord.Id = 2
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 0
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 1
        Me.btnCancel.Name = "btnCancel"
        '
        'RibbonImages
        '
        Me.RibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.RibbonImages.ImageStream = CType(resources.GetObject("RibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
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
        'bsLoadInfo
        '
        Me.bsLoadInfo.DataSource = GetType(AOS.BusinessObjects.ViewLoadInfo)
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.eDestination)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.eOrigin)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 100)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(432, 121)
        Me.GroupControl1.TabIndex = 36
        Me.GroupControl1.Text = "Load Information"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "LoadType", True))
        Me.TextEdit3.Location = New System.Drawing.Point(324, 32)
        Me.TextEdit3.MenuManager = Me.RibbonControl1
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Properties.ReadOnly = True
        Me.TextEdit3.Size = New System.Drawing.Size(82, 20)
        Me.TextEdit3.TabIndex = 26
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(295, 35)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl12.TabIndex = 27
        Me.LabelControl12.Text = "Type"
        '
        'eDestination
        '
        Me.eDestination.Location = New System.Drawing.Point(107, 84)
        Me.eDestination.MenuManager = Me.RibbonControl1
        Me.eDestination.Name = "eDestination"
        Me.eDestination.Properties.ReadOnly = True
        Me.eDestination.Size = New System.Drawing.Size(300, 20)
        Me.eDestination.TabIndex = 24
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCharge, "LoadID", True))
        Me.TextEdit1.Location = New System.Drawing.Point(107, 32)
        Me.TextEdit1.MenuManager = Me.RibbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(82, 20)
        Me.TextEdit1.TabIndex = 10
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(67, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 13)
        Me.LabelControl1.TabIndex = 11
        Me.LabelControl1.Text = "Load #"
        '
        'eOrigin
        '
        Me.eOrigin.Location = New System.Drawing.Point(107, 58)
        Me.eOrigin.MenuManager = Me.RibbonControl1
        Me.eOrigin.Name = "eOrigin"
        Me.eOrigin.Properties.ReadOnly = True
        Me.eOrigin.Size = New System.Drawing.Size(300, 20)
        Me.eOrigin.TabIndex = 12
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(73, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Origin"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(47, 87)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "Destination"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.LabelControl9)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Controls.Add(Me.LabelControl11)
        Me.GroupControl3.Controls.Add(Me.LabelControl10)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.eAmount)
        Me.GroupControl3.Controls.Add(Me.LabelControl5)
        Me.GroupControl3.Controls.Add(Me.eChrgDate)
        Me.GroupControl3.Controls.Add(Me.TextEdit10)
        Me.GroupControl3.Controls.Add(Me.TextEdit9)
        Me.GroupControl3.Controls.Add(Me.eCarrier)
        Me.GroupControl3.Controls.Add(Me.eLogistics)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 301)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(432, 245)
        Me.GroupControl3.TabIndex = 39
        Me.GroupControl3.Text = "Freight Charge Information"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(68, 35)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl9.TabIndex = 45
        Me.LabelControl9.Text = "Carrier"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(56, 61)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl7.TabIndex = 43
        Me.LabelControl7.Text = "3rd Party"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(40, 165)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl11.TabIndex = 41
        Me.LabelControl11.Text = "Charge Note"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(70, 139)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl10.TabIndex = 39
        Me.LabelControl10.Text = "Status"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(40, 113)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(61, 13)
        Me.LabelControl6.TabIndex = 33
        Me.LabelControl6.Text = "Charge Date"
        '
        'eAmount
        '
        Me.eAmount.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCharge, "CarrierCharges", True))
        Me.eAmount.Location = New System.Drawing.Point(107, 84)
        Me.eAmount.MenuManager = Me.RibbonControl1
        Me.eAmount.Name = "eAmount"
        Me.eAmount.Size = New System.Drawing.Size(113, 20)
        Me.eAmount.TabIndex = 0
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(26, 87)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl5.TabIndex = 31
        Me.LabelControl5.Text = "Charge Amount"
        '
        'eChrgDate
        '
        Me.eChrgDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCharge, "ChargeDate", True))
        Me.eChrgDate.EditValue = Nothing
        Me.eChrgDate.Location = New System.Drawing.Point(107, 110)
        Me.eChrgDate.MenuManager = Me.RibbonControl1
        Me.eChrgDate.Name = "eChrgDate"
        Me.eChrgDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eChrgDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eChrgDate.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.eChrgDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.eChrgDate.Properties.Mask.EditMask = ""
        Me.eChrgDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.eChrgDate.Size = New System.Drawing.Size(113, 20)
        Me.eChrgDate.TabIndex = 1
        '
        'TextEdit10
        '
        Me.TextEdit10.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCharge, "ChargeNote", True))
        Me.TextEdit10.Location = New System.Drawing.Point(107, 162)
        Me.TextEdit10.MenuManager = Me.RibbonControl1
        Me.TextEdit10.Name = "TextEdit10"
        Me.TextEdit10.Size = New System.Drawing.Size(299, 68)
        Me.TextEdit10.TabIndex = 3
        Me.TextEdit10.UseOptimizedRendering = True
        '
        'TextEdit9
        '
        Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCharge, "LoadChargeStatus", True))
        Me.TextEdit9.Location = New System.Drawing.Point(107, 136)
        Me.TextEdit9.MenuManager = Me.RibbonControl1
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Size = New System.Drawing.Size(113, 20)
        Me.TextEdit9.TabIndex = 2
        '
        'eCarrier
        '
        Me.eCarrier.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCharge, "CarrierID", True))
        Me.eCarrier.Location = New System.Drawing.Point(107, 32)
        Me.eCarrier.MenuManager = Me.RibbonControl1
        Me.eCarrier.Name = "eCarrier"
        Me.eCarrier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eCarrier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierCity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierState", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eCarrier.Properties.DataSource = Me.bsCarriers
        Me.eCarrier.Properties.DisplayMember = "CarrierName"
        Me.eCarrier.Properties.NullText = ""
        Me.eCarrier.Properties.PopupSizeable = False
        Me.eCarrier.Properties.PopupWidth = 300
        Me.eCarrier.Properties.ShowFooter = False
        Me.eCarrier.Properties.ValueMember = "CarrierID"
        Me.eCarrier.Size = New System.Drawing.Size(300, 20)
        Me.eCarrier.TabIndex = 44
        '
        'eLogistics
        '
        Me.eLogistics.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCharge, "LogisticsProviderID", True))
        Me.eLogistics.Location = New System.Drawing.Point(107, 58)
        Me.eLogistics.MenuManager = Me.RibbonControl1
        Me.eLogistics.Name = "eLogistics"
        Me.eLogistics.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eLogistics.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsname", "Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticscity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsstate", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eLogistics.Properties.DataSource = Me.bsLogistics
        Me.eLogistics.Properties.DisplayMember = "Logisticsname"
        Me.eLogistics.Properties.NullText = ""
        Me.eLogistics.Properties.PopupSizeable = False
        Me.eLogistics.Properties.PopupWidth = 300
        Me.eLogistics.Properties.ShowFooter = False
        Me.eLogistics.Properties.ValueMember = "Logisticsid"
        Me.eLogistics.Size = New System.Drawing.Size(299, 20)
        Me.eLogistics.TabIndex = 42
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.TextEdit4)
        Me.GroupControl2.Controls.Add(Me.LabelControl4)
        Me.GroupControl2.Controls.Add(Me.TextEdit2)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 227)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(432, 68)
        Me.GroupControl2.TabIndex = 40
        Me.GroupControl2.Text = "Freight Quote Information"
        '
        'TextEdit4
        '
        Me.TextEdit4.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsQuote, "CarrierQuoteNumber", True))
        Me.TextEdit4.Location = New System.Drawing.Point(324, 32)
        Me.TextEdit4.MenuManager = Me.RibbonControl1
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Properties.ReadOnly = True
        Me.TextEdit4.Size = New System.Drawing.Size(82, 20)
        Me.TextEdit4.TabIndex = 30
        '
        'bsQuote
        '
        Me.bsQuote.DataSource = GetType(AOS.BusinessObjects.Loadquote)
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(245, 35)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl4.TabIndex = 31
        Me.LabelControl4.Text = "Carrier Quote#"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "QuoteID", True))
        Me.TextEdit2.Location = New System.Drawing.Point(107, 32)
        Me.TextEdit2.MenuManager = Me.RibbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(82, 20)
        Me.TextEdit2.TabIndex = 28
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(61, 35)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl3.TabIndex = 29
        Me.LabelControl3.Text = "AOS Q#"
        '
        'frmAddEditLoadCharge
        '
        Me.ClientSize = New System.Drawing.Size(457, 557)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditLoadCharge"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Freight - Carrier Charge"
        CType(Me.bsCharge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDestination.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eOrigin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.eAmount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChrgDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChrgDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCarrier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLogistics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsQuote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsCharge As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents bsLoadInfo As System.Windows.Forms.BindingSource
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eDestination As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eOrigin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eAmount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eChrgDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsQuote As System.Windows.Forms.BindingSource
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eCarrier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eLogistics As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
