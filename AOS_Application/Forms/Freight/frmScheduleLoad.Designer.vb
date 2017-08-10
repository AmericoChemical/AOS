<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheduleLoad

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
        Dim BillCustomerLabel As System.Windows.Forms.Label
        Dim AddToInvoiceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheduleLoad))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsLoad = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.eOrigin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.eFreightCharges = New DevExpress.XtraEditors.TextEdit()
        Me.bsLoadInfo = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.eCustomer = New DevExpress.XtraEditors.TextEdit()
        Me.bsCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.eBillings = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.eDestination = New DevExpress.XtraEditors.TextEdit()
        Me.eCarrier = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsCarriers = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.eLogistics = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsLogistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.eSchedShipDate = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit()
        Me.bsLoadQuote = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.eQID = New DevExpress.XtraEditors.TextEdit()
        Me.btnEditCharges = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnEditBillings = New DevExpress.XtraEditors.SimpleButton()
        Me.BillCustomerCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.AddToInvoiceCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        BillCustomerLabel = New System.Windows.Forms.Label()
        AddToInvoiceLabel = New System.Windows.Forms.Label()
        CType(Me.bsLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eOrigin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFreightCharges.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eBillings.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDestination.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eCarrier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLogistics.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSchedShipDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eSchedShipDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLoadQuote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.eQID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.BillCustomerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AddToInvoiceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BillCustomerLabel
        '
        BillCustomerLabel.AutoSize = True
        BillCustomerLabel.Location = New System.Drawing.Point(38, 35)
        BillCustomerLabel.Name = "BillCustomerLabel"
        BillCustomerLabel.Size = New System.Drawing.Size(68, 13)
        BillCustomerLabel.TabIndex = 30
        BillCustomerLabel.Text = "Bill Customer"
        '
        'AddToInvoiceLabel
        '
        AddToInvoiceLabel.AutoSize = True
        AddToInvoiceLabel.Location = New System.Drawing.Point(145, 35)
        AddToInvoiceLabel.Name = "AddToInvoiceLabel"
        AddToInvoiceLabel.Size = New System.Drawing.Size(79, 13)
        AddToInvoiceLabel.TabIndex = 28
        AddToInvoiceLabel.Text = "Add To Invoice"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsLoad
        '
        Me.bsLoad.DataSource = GetType(AOS.BusinessObjects.Load)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.btnSave, Me.btnCancel})
        Me.RibbonControl1.LargeImages = Me.RibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(6, 6)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(438, 94)
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
        Me.btnSave.Caption = "Schedule Load"
        Me.btnSave.Id = 4
        Me.btnSave.LargeImageIndex = 15
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.LargeImageIndex = 7
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
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoad, "LoadID", True))
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
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(73, 61)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl2.TabIndex = 13
        Me.LabelControl2.Text = "Origin"
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
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(68, 91)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl3.TabIndex = 15
        Me.LabelControl3.Text = "Carrier"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(23, 113)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Sched Ship Date"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(24, 143)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Freight Charges"
        '
        'eFreightCharges
        '
        Me.eFreightCharges.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "TotalCharged", True))
        Me.eFreightCharges.Location = New System.Drawing.Point(107, 140)
        Me.eFreightCharges.MenuManager = Me.RibbonControl1
        Me.eFreightCharges.Name = "eFreightCharges"
        Me.eFreightCharges.Properties.ReadOnly = True
        Me.eFreightCharges.Size = New System.Drawing.Size(82, 20)
        Me.eFreightCharges.TabIndex = 18
        '
        'bsLoadInfo
        '
        Me.bsLoadInfo.DataSource = GetType(AOS.BusinessObjects.ViewLoadInfo)
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(55, 60)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 21
        Me.LabelControl6.Text = "Customer"
        '
        'eCustomer
        '
        Me.eCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomer, "Custname", True))
        Me.eCustomer.Location = New System.Drawing.Point(107, 57)
        Me.eCustomer.MenuManager = Me.RibbonControl1
        Me.eCustomer.Name = "eCustomer"
        Me.eCustomer.Properties.ReadOnly = True
        Me.eCustomer.Size = New System.Drawing.Size(300, 20)
        Me.eCustomer.TabIndex = 20
        '
        'bsCustomer
        '
        Me.bsCustomer.DataSource = GetType(AOS.BusinessObjects.Customer)
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(55, 86)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl7.TabIndex = 23
        Me.LabelControl7.Text = "Billed Amt"
        '
        'eBillings
        '
        Me.eBillings.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadInfo, "TotalBilled", True))
        Me.eBillings.Location = New System.Drawing.Point(107, 83)
        Me.eBillings.MenuManager = Me.RibbonControl1
        Me.eBillings.Name = "eBillings"
        Me.eBillings.Properties.ReadOnly = True
        Me.eBillings.Size = New System.Drawing.Size(82, 20)
        Me.eBillings.TabIndex = 22
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(47, 87)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "Destination"
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
        'eCarrier
        '
        Me.eCarrier.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoad, "ScheduledCarrierID", True))
        Me.eCarrier.Location = New System.Drawing.Point(107, 88)
        Me.eCarrier.MenuManager = Me.RibbonControl1
        Me.eCarrier.Name = "eCarrier"
        Me.eCarrier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eCarrier.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierCity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierState", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eCarrier.Properties.DataSource = Me.bsCarriers
        Me.eCarrier.Properties.DisplayMember = "CarrierName"
        Me.eCarrier.Properties.NullText = ""
        Me.eCarrier.Properties.PopupSizeable = False
        Me.eCarrier.Properties.PopupWidth = 300
        Me.eCarrier.Properties.ValueMember = "CarrierID"
        Me.eCarrier.Size = New System.Drawing.Size(300, 20)
        Me.eCarrier.TabIndex = 14
        '
        'bsCarriers
        '
        Me.bsCarriers.DataSource = GetType(AOS.BusinessObjects.CarrierCollection)
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(13, 117)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(88, 13)
        Me.LabelControl9.TabIndex = 28
        Me.LabelControl9.Text = "3rd Party Logistics"
        '
        'eLogistics
        '
        Me.eLogistics.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoad, "ScheduledLogisticsID", True))
        Me.eLogistics.Location = New System.Drawing.Point(107, 114)
        Me.eLogistics.MenuManager = Me.RibbonControl1
        Me.eLogistics.Name = "eLogistics"
        Me.eLogistics.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eLogistics.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsname", "Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticscity", "City", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Logisticsstate", "State", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eLogistics.Properties.DataSource = Me.bsLogistics
        Me.eLogistics.Properties.DisplayMember = "Logisticsname"
        Me.eLogistics.Properties.NullText = ""
        Me.eLogistics.Properties.PopupSizeable = False
        Me.eLogistics.Properties.PopupWidth = 300
        Me.eLogistics.Properties.ValueMember = "Logisticsid"
        Me.eLogistics.Size = New System.Drawing.Size(300, 20)
        Me.eLogistics.TabIndex = 27
        '
        'bsLogistics
        '
        Me.bsLogistics.DataSource = GetType(AOS.BusinessObjects.LogisticsCollection)
        '
        'eSchedShipDate
        '
        Me.eSchedShipDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoad, "ScheduledShipmentDate", True))
        Me.eSchedShipDate.EditValue = Nothing
        Me.eSchedShipDate.Location = New System.Drawing.Point(107, 110)
        Me.eSchedShipDate.MenuManager = Me.RibbonControl1
        Me.eSchedShipDate.Name = "eSchedShipDate"
        Me.eSchedShipDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eSchedShipDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eSchedShipDate.Properties.CalendarTimeProperties.CloseUpKey = New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4)
        Me.eSchedShipDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.[Default]
        Me.eSchedShipDate.Properties.Mask.EditMask = ""
        Me.eSchedShipDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.eSchedShipDate.Size = New System.Drawing.Size(82, 20)
        Me.eSchedShipDate.TabIndex = 16
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(24, 65)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl10.TabIndex = 31
        Me.LabelControl10.Text = "Carrier Quote #"
        '
        'TextEdit9
        '
        Me.TextEdit9.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoadQuote, "CarrierQuoteNumber", True))
        Me.TextEdit9.Location = New System.Drawing.Point(107, 62)
        Me.TextEdit9.MenuManager = Me.RibbonControl1
        Me.TextEdit9.Name = "TextEdit9"
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Size = New System.Drawing.Size(82, 20)
        Me.TextEdit9.TabIndex = 30
        '
        'bsLoadQuote
        '
        Me.bsLoadQuote.DataSource = GetType(AOS.BusinessObjects.Loadquote)
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(81, 39)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(20, 13)
        Me.LabelControl11.TabIndex = 33
        Me.LabelControl11.Text = "FOB"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoad, "Fob", True))
        Me.TextEdit2.Location = New System.Drawing.Point(107, 36)
        Me.TextEdit2.MenuManager = Me.RibbonControl1
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Size = New System.Drawing.Size(121, 20)
        Me.TextEdit2.TabIndex = 32
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.TextEdit3)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.eDestination)
        Me.GroupControl1.Controls.Add(Me.eSchedShipDate)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.eOrigin)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 106)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(432, 145)
        Me.GroupControl1.TabIndex = 34
        Me.GroupControl1.Text = "Load Information"
        '
        'TextEdit3
        '
        Me.TextEdit3.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoad, "LoadType", True))
        Me.TextEdit3.Location = New System.Drawing.Point(325, 32)
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
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.LabelControl13)
        Me.GroupControl2.Controls.Add(Me.eQID)
        Me.GroupControl2.Controls.Add(Me.btnEditCharges)
        Me.GroupControl2.Controls.Add(Me.eFreightCharges)
        Me.GroupControl2.Controls.Add(Me.eCarrier)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.TextEdit2)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.LabelControl10)
        Me.GroupControl2.Controls.Add(Me.eLogistics)
        Me.GroupControl2.Controls.Add(Me.TextEdit9)
        Me.GroupControl2.Controls.Add(Me.LabelControl9)
        Me.GroupControl2.Location = New System.Drawing.Point(9, 257)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(432, 177)
        Me.GroupControl2.TabIndex = 35
        Me.GroupControl2.Text = "Transportation Charges"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(279, 65)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl13.TabIndex = 36
        Me.LabelControl13.Text = "AOS Q#"
        '
        'eQID
        '
        Me.eQID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsLoad, "QuoteID", True))
        Me.eQID.Location = New System.Drawing.Point(325, 62)
        Me.eQID.MenuManager = Me.RibbonControl1
        Me.eQID.Name = "eQID"
        Me.eQID.Properties.ReadOnly = True
        Me.eQID.Size = New System.Drawing.Size(82, 20)
        Me.eQID.TabIndex = 35
        '
        'btnEditCharges
        '
        Me.btnEditCharges.Location = New System.Drawing.Point(195, 140)
        Me.btnEditCharges.Name = "btnEditCharges"
        Me.btnEditCharges.Size = New System.Drawing.Size(33, 20)
        Me.btnEditCharges.TabIndex = 34
        Me.btnEditCharges.Text = "Edit"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnEditBillings)
        Me.GroupControl3.Controls.Add(AddToInvoiceLabel)
        Me.GroupControl3.Controls.Add(BillCustomerLabel)
        Me.GroupControl3.Controls.Add(Me.BillCustomerCheckEdit)
        Me.GroupControl3.Controls.Add(Me.AddToInvoiceCheckEdit)
        Me.GroupControl3.Controls.Add(Me.eBillings)
        Me.GroupControl3.Controls.Add(Me.eCustomer)
        Me.GroupControl3.Controls.Add(Me.LabelControl6)
        Me.GroupControl3.Controls.Add(Me.LabelControl7)
        Me.GroupControl3.Location = New System.Drawing.Point(9, 440)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(432, 130)
        Me.GroupControl3.TabIndex = 36
        Me.GroupControl3.Text = "Customer Billing"
        '
        'btnEditBillings
        '
        Me.btnEditBillings.Location = New System.Drawing.Point(195, 83)
        Me.btnEditBillings.Name = "btnEditBillings"
        Me.btnEditBillings.Size = New System.Drawing.Size(33, 20)
        Me.btnEditBillings.TabIndex = 35
        Me.btnEditBillings.Text = "Edit"
        '
        'BillCustomerCheckEdit
        '
        Me.BillCustomerCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomer, "Freightbillcustomer", True))
        Me.BillCustomerCheckEdit.Location = New System.Drawing.Point(105, 32)
        Me.BillCustomerCheckEdit.MenuManager = Me.RibbonControl1
        Me.BillCustomerCheckEdit.Name = "BillCustomerCheckEdit"
        Me.BillCustomerCheckEdit.Properties.Caption = ""
        Me.BillCustomerCheckEdit.Properties.ReadOnly = True
        Me.BillCustomerCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.BillCustomerCheckEdit.TabIndex = 31
        Me.BillCustomerCheckEdit.TabStop = False
        '
        'AddToInvoiceCheckEdit
        '
        Me.AddToInvoiceCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsCustomer, "Freightoninvoice", True))
        Me.AddToInvoiceCheckEdit.Location = New System.Drawing.Point(224, 32)
        Me.AddToInvoiceCheckEdit.MenuManager = Me.RibbonControl1
        Me.AddToInvoiceCheckEdit.Name = "AddToInvoiceCheckEdit"
        Me.AddToInvoiceCheckEdit.Properties.Caption = ""
        Me.AddToInvoiceCheckEdit.Properties.ReadOnly = True
        Me.AddToInvoiceCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.AddToInvoiceCheckEdit.TabIndex = 29
        Me.AddToInvoiceCheckEdit.TabStop = False
        '
        'frmScheduleLoad
        '
        Me.ClientSize = New System.Drawing.Size(450, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmScheduleLoad"
        Me.Padding = New System.Windows.Forms.Padding(6)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Schedule Load"
        CType(Me.bsLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eOrigin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFreightCharges.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eBillings.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDestination.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eCarrier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCarriers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLogistics.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eSchedShipDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eSchedShipDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLoadQuote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.eQID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.BillCustomerCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AddToInvoiceCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsLoad As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eOrigin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eFreightCharges As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eBillings As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eDestination As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eCarrier As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eLogistics As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsCarriers As System.Windows.Forms.BindingSource
    Friend WithEvents bsLogistics As System.Windows.Forms.BindingSource
    Friend WithEvents eSchedShipDate As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BillCustomerCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents AddToInvoiceCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnEditCharges As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnEditBillings As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bsCustomer As System.Windows.Forms.BindingSource
    Friend WithEvents bsLoadInfo As System.Windows.Forms.BindingSource
    Friend WithEvents bsLoadQuote As System.Windows.Forms.BindingSource
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents eQID As DevExpress.XtraEditors.TextEdit
End Class
