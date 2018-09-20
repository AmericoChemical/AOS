<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditVendor

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
        Dim TermsLabel As System.Windows.Forms.Label
        Dim VendornameLabel As System.Windows.Forms.Label
        Dim VendoracctnumberLabel As System.Windows.Forms.Label
        Dim Vendoraddress1Label As System.Windows.Forms.Label
        Dim VendorurlLabel As System.Windows.Forms.Label
        Dim Vendoraddress2Label As System.Windows.Forms.Label
        Dim VendoremailLabel As System.Windows.Forms.Label
        Dim VendorcityLabel As System.Windows.Forms.Label
        Dim VendorcontactLabel As System.Windows.Forms.Label
        Dim VendorfaxLabel As System.Windows.Forms.Label
        Dim VendorphoneLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim IsactiveLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditVendor))
        Dim Label3 As System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TermsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendornameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Vendoraddress1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendoracctnumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Vendoraddress2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorurlTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorcityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendoremailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorstateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorcontactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorzipTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorphoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.VendorfaxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btnNewCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteCostRecord = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.IsactiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.lblModified = New DevExpress.XtraEditors.LabelControl()
        Me.lblCreated = New DevExpress.XtraEditors.LabelControl()
        Me.grVendorTestingMatrix = New DevExpress.XtraGrid.GridControl()
        Me.bsVendorTestingMatrix = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colChemicalcategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRetainpercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTestpercentage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPh = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colColor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAppearance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsactive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ComponentRibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.AddVendTestingMatrix = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterAdd = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterEdit = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAlterDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.EditVendTestingMatrix = New DevExpress.XtraBars.BarButtonItem()
        Me.DeleteVendTestingMatrix = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.AppgroupCollection1 = New AOS.BusinessObjects.AppgroupCollection()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsStatusOptions = New System.Windows.Forms.BindingSource(Me.components)
        TermsLabel = New System.Windows.Forms.Label()
        VendornameLabel = New System.Windows.Forms.Label()
        VendoracctnumberLabel = New System.Windows.Forms.Label()
        Vendoraddress1Label = New System.Windows.Forms.Label()
        VendorurlLabel = New System.Windows.Forms.Label()
        Vendoraddress2Label = New System.Windows.Forms.Label()
        VendoremailLabel = New System.Windows.Forms.Label()
        VendorcityLabel = New System.Windows.Forms.Label()
        VendorcontactLabel = New System.Windows.Forms.Label()
        VendorfaxLabel = New System.Windows.Forms.Label()
        VendorphoneLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        IsactiveLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.TermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendornameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vendoraddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendoracctnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vendoraddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorurlTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendoremailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorstateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorzipTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorfaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grVendorTestingMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsVendorTestingMatrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStatusOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TermsLabel
        '
        TermsLabel.AutoSize = True
        TermsLabel.Location = New System.Drawing.Point(430, 140)
        TermsLabel.Name = "TermsLabel"
        TermsLabel.Size = New System.Drawing.Size(36, 13)
        TermsLabel.TabIndex = 48
        TermsLabel.Text = "Terms"
        '
        'VendornameLabel
        '
        VendornameLabel.AutoSize = True
        VendornameLabel.Location = New System.Drawing.Point(25, 62)
        VendornameLabel.Name = "VendornameLabel"
        VendornameLabel.Size = New System.Drawing.Size(71, 13)
        VendornameLabel.TabIndex = 26
        VendornameLabel.Text = "Vendor Name"
        '
        'VendoracctnumberLabel
        '
        VendoracctnumberLabel.AutoSize = True
        VendoracctnumberLabel.Location = New System.Drawing.Point(430, 114)
        VendoracctnumberLabel.Name = "VendoracctnumberLabel"
        VendoracctnumberLabel.Size = New System.Drawing.Size(57, 13)
        VendoracctnumberLabel.TabIndex = 46
        VendoracctnumberLabel.Text = "Account #"
        '
        'Vendoraddress1Label
        '
        Vendoraddress1Label.AutoSize = True
        Vendoraddress1Label.Location = New System.Drawing.Point(25, 88)
        Vendoraddress1Label.Name = "Vendoraddress1Label"
        Vendoraddress1Label.Size = New System.Drawing.Size(55, 13)
        Vendoraddress1Label.TabIndex = 28
        Vendoraddress1Label.Text = "Address 1"
        '
        'VendorurlLabel
        '
        VendorurlLabel.AutoSize = True
        VendorurlLabel.Location = New System.Drawing.Point(430, 88)
        VendorurlLabel.Name = "VendorurlLabel"
        VendorurlLabel.Size = New System.Drawing.Size(78, 13)
        VendorurlLabel.TabIndex = 44
        VendorurlLabel.Text = "Web Page URL"
        '
        'Vendoraddress2Label
        '
        Vendoraddress2Label.AutoSize = True
        Vendoraddress2Label.Location = New System.Drawing.Point(25, 114)
        Vendoraddress2Label.Name = "Vendoraddress2Label"
        Vendoraddress2Label.Size = New System.Drawing.Size(55, 13)
        Vendoraddress2Label.TabIndex = 30
        Vendoraddress2Label.Text = "Address 2"
        '
        'VendoremailLabel
        '
        VendoremailLabel.AutoSize = True
        VendoremailLabel.Location = New System.Drawing.Point(430, 62)
        VendoremailLabel.Name = "VendoremailLabel"
        VendoremailLabel.Size = New System.Drawing.Size(31, 13)
        VendoremailLabel.TabIndex = 42
        VendoremailLabel.Text = "Email"
        '
        'VendorcityLabel
        '
        VendorcityLabel.AutoSize = True
        VendorcityLabel.Location = New System.Drawing.Point(25, 140)
        VendorcityLabel.Name = "VendorcityLabel"
        VendorcityLabel.Size = New System.Drawing.Size(72, 13)
        VendorcityLabel.TabIndex = 32
        VendorcityLabel.Text = "City State Zip"
        '
        'VendorcontactLabel
        '
        VendorcontactLabel.AutoSize = True
        VendorcontactLabel.Location = New System.Drawing.Point(25, 218)
        VendorcontactLabel.Name = "VendorcontactLabel"
        VendorcontactLabel.Size = New System.Drawing.Size(45, 13)
        VendorcontactLabel.TabIndex = 40
        VendorcontactLabel.Text = "Contact"
        '
        'VendorfaxLabel
        '
        VendorfaxLabel.AutoSize = True
        VendorfaxLabel.Location = New System.Drawing.Point(25, 192)
        VendorfaxLabel.Name = "VendorfaxLabel"
        VendorfaxLabel.Size = New System.Drawing.Size(66, 13)
        VendorfaxLabel.TabIndex = 38
        VendorfaxLabel.Text = "FAX Number"
        '
        'VendorphoneLabel
        '
        VendorphoneLabel.AutoSize = True
        VendorphoneLabel.Location = New System.Drawing.Point(25, 166)
        VendorphoneLabel.Name = "VendorphoneLabel"
        VendorphoneLabel.Size = New System.Drawing.Size(77, 13)
        VendorphoneLabel.TabIndex = 36
        VendorphoneLabel.Text = "Phone Number"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(25, 36)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(55, 13)
        Label1.TabIndex = 0
        Label1.Text = "Vendor ID"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(430, 166)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(35, 13)
        Label2.TabIndex = 52
        Label2.Text = "Notes"
        '
        'IsactiveLabel
        '
        IsactiveLabel.AutoSize = True
        IsactiveLabel.Location = New System.Drawing.Point(293, 33)
        IsactiveLabel.Name = "IsactiveLabel"
        IsactiveLabel.Size = New System.Drawing.Size(37, 13)
        IsactiveLabel.TabIndex = 56
        IsactiveLabel.Text = "Active"
        IsactiveLabel.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TermsTextEdit
        '
        Me.TermsTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Terms", True))
        Me.TermsTextEdit.Location = New System.Drawing.Point(514, 137)
        Me.TermsTextEdit.Name = "TermsTextEdit"
        Me.TermsTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.TermsTextEdit.TabIndex = 49
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.Vendor)
        '
        'VendornameTextEdit
        '
        Me.VendornameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorname", True))
        Me.VendornameTextEdit.Location = New System.Drawing.Point(109, 59)
        Me.VendornameTextEdit.Name = "VendornameTextEdit"
        Me.VendornameTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendornameTextEdit.TabIndex = 27
        '
        'Vendoraddress1TextEdit
        '
        Me.Vendoraddress1TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendoraddress1", True))
        Me.Vendoraddress1TextEdit.Location = New System.Drawing.Point(109, 85)
        Me.Vendoraddress1TextEdit.Name = "Vendoraddress1TextEdit"
        Me.Vendoraddress1TextEdit.Size = New System.Drawing.Size(251, 20)
        Me.Vendoraddress1TextEdit.TabIndex = 29
        '
        'VendoracctnumberTextEdit
        '
        Me.VendoracctnumberTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendoracctnumber", True))
        Me.VendoracctnumberTextEdit.Location = New System.Drawing.Point(514, 111)
        Me.VendoracctnumberTextEdit.Name = "VendoracctnumberTextEdit"
        Me.VendoracctnumberTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendoracctnumberTextEdit.TabIndex = 47
        '
        'Vendoraddress2TextEdit
        '
        Me.Vendoraddress2TextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendoraddress2", True))
        Me.Vendoraddress2TextEdit.Location = New System.Drawing.Point(109, 111)
        Me.Vendoraddress2TextEdit.Name = "Vendoraddress2TextEdit"
        Me.Vendoraddress2TextEdit.Size = New System.Drawing.Size(251, 20)
        Me.Vendoraddress2TextEdit.TabIndex = 31
        '
        'VendorurlTextEdit
        '
        Me.VendorurlTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorurl", True))
        Me.VendorurlTextEdit.Location = New System.Drawing.Point(514, 85)
        Me.VendorurlTextEdit.Name = "VendorurlTextEdit"
        Me.VendorurlTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendorurlTextEdit.TabIndex = 45
        '
        'VendorcityTextEdit
        '
        Me.VendorcityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorcity", True))
        Me.VendorcityTextEdit.Location = New System.Drawing.Point(109, 137)
        Me.VendorcityTextEdit.Name = "VendorcityTextEdit"
        Me.VendorcityTextEdit.Size = New System.Drawing.Size(150, 20)
        Me.VendorcityTextEdit.TabIndex = 33
        '
        'VendoremailTextEdit
        '
        Me.VendoremailTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendoremail", True))
        Me.VendoremailTextEdit.Location = New System.Drawing.Point(514, 59)
        Me.VendoremailTextEdit.Name = "VendoremailTextEdit"
        Me.VendoremailTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendoremailTextEdit.TabIndex = 43
        '
        'VendorstateTextEdit
        '
        Me.VendorstateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorstate", True))
        Me.VendorstateTextEdit.Location = New System.Drawing.Point(265, 137)
        Me.VendorstateTextEdit.Name = "VendorstateTextEdit"
        Me.VendorstateTextEdit.Size = New System.Drawing.Size(26, 20)
        Me.VendorstateTextEdit.TabIndex = 34
        '
        'VendorcontactTextEdit
        '
        Me.VendorcontactTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorcontact", True))
        Me.VendorcontactTextEdit.Location = New System.Drawing.Point(109, 215)
        Me.VendorcontactTextEdit.Name = "VendorcontactTextEdit"
        Me.VendorcontactTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendorcontactTextEdit.TabIndex = 41
        '
        'VendorzipTextEdit
        '
        Me.VendorzipTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorzip", True))
        Me.VendorzipTextEdit.Location = New System.Drawing.Point(297, 137)
        Me.VendorzipTextEdit.Name = "VendorzipTextEdit"
        Me.VendorzipTextEdit.Size = New System.Drawing.Size(63, 20)
        Me.VendorzipTextEdit.TabIndex = 35
        '
        'VendorphoneTextEdit
        '
        Me.VendorphoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorphone", True))
        Me.VendorphoneTextEdit.Location = New System.Drawing.Point(109, 163)
        Me.VendorphoneTextEdit.Name = "VendorphoneTextEdit"
        Me.VendorphoneTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendorphoneTextEdit.TabIndex = 37
        '
        'VendorfaxTextEdit
        '
        Me.VendorfaxTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorfax", True))
        Me.VendorfaxTextEdit.Location = New System.Drawing.Point(109, 189)
        Me.VendorfaxTextEdit.Name = "VendorfaxTextEdit"
        Me.VendorfaxTextEdit.Size = New System.Drawing.Size(251, 20)
        Me.VendorfaxTextEdit.TabIndex = 39
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorid", True))
        Me.TextEdit1.Location = New System.Drawing.Point(109, 33)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(61, 20)
        Me.TextEdit1.TabIndex = 1
        Me.TextEdit1.TabStop = False
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendornotes", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(514, 166)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(250, 69)
        Me.MemoEdit1.TabIndex = 53
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Images = Me.ImageCollection1
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnNewCostRecord, Me.btnEditCostRecord, Me.btnDeleteCostRecord, Me.rbtnSave, Me.rbtnCancel})
        Me.RibbonControl1.LargeImages = Me.ImageCollection1
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 6
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(817, 117)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'btnNewCostRecord
        '
        Me.btnNewCostRecord.Caption = "New Cost Record"
        Me.btnNewCostRecord.Id = 0
        Me.btnNewCostRecord.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnNewCostRecord.Name = "btnNewCostRecord"
        '
        'btnEditCostRecord
        '
        Me.btnEditCostRecord.Caption = "Edit Cost Record"
        Me.btnEditCostRecord.Id = 1
        Me.btnEditCostRecord.ImageOptions.Image = Global.AOS.My.Resources.Resources.Edit
        Me.btnEditCostRecord.Name = "btnEditCostRecord"
        '
        'btnDeleteCostRecord
        '
        Me.btnDeleteCostRecord.Caption = "Delete Cost Record"
        Me.btnDeleteCostRecord.Id = 2
        Me.btnDeleteCostRecord.ImageOptions.Image = Global.AOS.My.Resources.Resources.Delete
        Me.btnDeleteCostRecord.Name = "btnDeleteCostRecord"
        '
        'rbtnSave
        '
        Me.rbtnSave.Caption = "Save"
        Me.rbtnSave.Id = 4
        Me.rbtnSave.ImageOptions.LargeImageIndex = 0
        Me.rbtnSave.Name = "rbtnSave"
        '
        'rbtnCancel
        '
        Me.rbtnCancel.Caption = "Cancel"
        Me.rbtnCancel.Id = 5
        Me.rbtnCancel.ImageOptions.LargeImageIndex = 1
        Me.rbtnCancel.Name = "rbtnCancel"
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
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'IsactiveCheckEdit
        '
        Me.IsactiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Isactive", True))
        Me.IsactiveCheckEdit.Location = New System.Drawing.Point(336, 30)
        Me.IsactiveCheckEdit.MenuManager = Me.RibbonControl1
        Me.IsactiveCheckEdit.Name = "IsactiveCheckEdit"
        Me.IsactiveCheckEdit.Properties.Caption = ""
        Me.IsactiveCheckEdit.Size = New System.Drawing.Size(24, 19)
        Me.IsactiveCheckEdit.TabIndex = 57
        Me.IsactiveCheckEdit.Visible = False
        '
        'lblModified
        '
        Me.lblModified.Location = New System.Drawing.Point(18, 526)
        Me.lblModified.Name = "lblModified"
        Me.lblModified.Size = New System.Drawing.Size(0, 13)
        Me.lblModified.TabIndex = 59
        '
        'lblCreated
        '
        Me.lblCreated.Location = New System.Drawing.Point(18, 507)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(0, 13)
        Me.lblCreated.TabIndex = 58
        '
        'grVendorTestingMatrix
        '
        Me.grVendorTestingMatrix.DataSource = Me.bsVendorTestingMatrix
        Me.grVendorTestingMatrix.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grVendorTestingMatrix.Location = New System.Drawing.Point(2, 139)
        Me.grVendorTestingMatrix.MainView = Me.GridView1
        Me.grVendorTestingMatrix.MenuManager = Me.RibbonControl1
        Me.grVendorTestingMatrix.Name = "grVendorTestingMatrix"
        Me.grVendorTestingMatrix.Size = New System.Drawing.Size(813, 182)
        Me.grVendorTestingMatrix.TabIndex = 0
        Me.grVendorTestingMatrix.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'bsVendorTestingMatrix
        '
        Me.bsVendorTestingMatrix.DataSource = GetType(AOS.BusinessObjects.ViewVendorTestingMatrixCollection)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colChemicalcategory, Me.colProductid, Me.colProductdesc, Me.colRetainpercentage, Me.colTestpercentage, Me.colPh, Me.colSg, Me.colColor, Me.colAppearance, Me.colIsactive, Me.colVendorid})
        Me.GridView1.GridControl = Me.grVendorTestingMatrix
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colChemicalcategory
        '
        Me.colChemicalcategory.Caption = "Chemical Category"
        Me.colChemicalcategory.FieldName = "Chemicalcategory"
        Me.colChemicalcategory.Name = "colChemicalcategory"
        Me.colChemicalcategory.OptionsColumn.AllowEdit = False
        Me.colChemicalcategory.Visible = True
        Me.colChemicalcategory.VisibleIndex = 0
        Me.colChemicalcategory.Width = 100
        '
        'colProductid
        '
        Me.colProductid.Caption = "Product ID"
        Me.colProductid.FieldName = "Productid"
        Me.colProductid.Name = "colProductid"
        Me.colProductid.OptionsColumn.AllowEdit = False
        Me.colProductid.Visible = True
        Me.colProductid.VisibleIndex = 1
        Me.colProductid.Width = 92
        '
        'colProductdesc
        '
        Me.colProductdesc.Caption = "Product Descripition"
        Me.colProductdesc.FieldName = "Productdesc"
        Me.colProductdesc.Name = "colProductdesc"
        Me.colProductdesc.OptionsColumn.AllowEdit = False
        Me.colProductdesc.Visible = True
        Me.colProductdesc.VisibleIndex = 2
        Me.colProductdesc.Width = 207
        '
        'colRetainpercentage
        '
        Me.colRetainpercentage.Caption = "% Retain"
        Me.colRetainpercentage.FieldName = "Retainpercentage"
        Me.colRetainpercentage.Name = "colRetainpercentage"
        Me.colRetainpercentage.OptionsColumn.AllowEdit = False
        Me.colRetainpercentage.Visible = True
        Me.colRetainpercentage.VisibleIndex = 3
        Me.colRetainpercentage.Width = 62
        '
        'colTestpercentage
        '
        Me.colTestpercentage.Caption = "% Test"
        Me.colTestpercentage.FieldName = "Testpercentage"
        Me.colTestpercentage.Name = "colTestpercentage"
        Me.colTestpercentage.OptionsColumn.AllowEdit = False
        Me.colTestpercentage.Visible = True
        Me.colTestpercentage.VisibleIndex = 4
        Me.colTestpercentage.Width = 51
        '
        'colPh
        '
        Me.colPh.Caption = "PH"
        Me.colPh.FieldName = "Ph"
        Me.colPh.Name = "colPh"
        Me.colPh.OptionsColumn.AllowEdit = False
        Me.colPh.Visible = True
        Me.colPh.VisibleIndex = 5
        Me.colPh.Width = 31
        '
        'colSg
        '
        Me.colSg.Caption = "SG"
        Me.colSg.FieldName = "Sg"
        Me.colSg.Name = "colSg"
        Me.colSg.OptionsColumn.AllowEdit = False
        Me.colSg.Visible = True
        Me.colSg.VisibleIndex = 6
        Me.colSg.Width = 31
        '
        'colColor
        '
        Me.colColor.Caption = "Color"
        Me.colColor.FieldName = "Color"
        Me.colColor.Name = "colColor"
        Me.colColor.OptionsColumn.AllowEdit = False
        Me.colColor.Visible = True
        Me.colColor.VisibleIndex = 7
        Me.colColor.Width = 61
        '
        'colAppearance
        '
        Me.colAppearance.Caption = "Appearance"
        Me.colAppearance.FieldName = "Appearance"
        Me.colAppearance.Name = "colAppearance"
        Me.colAppearance.OptionsColumn.AllowEdit = False
        Me.colAppearance.Visible = True
        Me.colAppearance.VisibleIndex = 8
        Me.colAppearance.Width = 68
        '
        'colIsactive
        '
        Me.colIsactive.Caption = "Is Active"
        Me.colIsactive.FieldName = "Isactive"
        Me.colIsactive.Name = "colIsactive"
        Me.colIsactive.OptionsColumn.AllowEdit = False
        Me.colIsactive.Visible = True
        Me.colIsactive.VisibleIndex = 9
        Me.colIsactive.Width = 55
        '
        'colVendorid
        '
        Me.colVendorid.Caption = "Vendor ID"
        Me.colVendorid.FieldName = "Vendorid"
        Me.colVendorid.Name = "colVendorid"
        Me.colVendorid.OptionsColumn.AllowEdit = False
        '
        'ComponentRibbonControl1
        '
        Me.ComponentRibbonControl1.ApplicationButtonText = Nothing
        Me.ComponentRibbonControl1.ExpandCollapseItem.Id = 0
        Me.ComponentRibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ComponentRibbonControl1.ExpandCollapseItem, Me.AddVendTestingMatrix, Me.btnAlterAdd, Me.btnAlterEdit, Me.btnAlterDelete, Me.EditVendTestingMatrix, Me.DeleteVendTestingMatrix})
        Me.ComponentRibbonControl1.Location = New System.Drawing.Point(2, 22)
        Me.ComponentRibbonControl1.MaxItemId = 30
        Me.ComponentRibbonControl1.Name = "ComponentRibbonControl1"
        Me.ComponentRibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage2})
        Me.ComponentRibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ComponentRibbonControl1.ShowToolbarCustomizeItem = False
        Me.ComponentRibbonControl1.Size = New System.Drawing.Size(813, 117)
        Me.ComponentRibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.ComponentRibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'AddVendTestingMatrix
        '
        Me.AddVendTestingMatrix.Caption = "Add"
        Me.AddVendTestingMatrix.Id = 4
        Me.AddVendTestingMatrix.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.NewRecord
        Me.AddVendTestingMatrix.Name = "AddVendTestingMatrix"
        Me.AddVendTestingMatrix.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnAlterAdd
        '
        Me.btnAlterAdd.Caption = "Add New Comp Alternate"
        Me.btnAlterAdd.Id = 24
        Me.btnAlterAdd.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.NewRecord
        Me.btnAlterAdd.Name = "btnAlterAdd"
        '
        'btnAlterEdit
        '
        Me.btnAlterEdit.Caption = "Edit Comp Alternate"
        Me.btnAlterEdit.Id = 25
        Me.btnAlterEdit.ImageOptions.Image = Global.AOS.My.Resources.Resources.document_edit__2_
        Me.btnAlterEdit.Name = "btnAlterEdit"
        '
        'btnAlterDelete
        '
        Me.btnAlterDelete.Caption = "Delete Comp alternate"
        Me.btnAlterDelete.Id = 26
        Me.btnAlterDelete.ImageOptions.Image = CType(resources.GetObject("btnAlterDelete.ImageOptions.Image"), System.Drawing.Image)
        Me.btnAlterDelete.Name = "btnAlterDelete"
        '
        'EditVendTestingMatrix
        '
        Me.EditVendTestingMatrix.Caption = "Edit"
        Me.EditVendTestingMatrix.Id = 28
        Me.EditVendTestingMatrix.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.EditData
        Me.EditVendTestingMatrix.Name = "EditVendTestingMatrix"
        '
        'DeleteVendTestingMatrix
        '
        Me.DeleteVendTestingMatrix.Caption = "Delete"
        Me.DeleteVendTestingMatrix.Id = 29
        Me.DeleteVendTestingMatrix.ImageOptions.LargeImage = Global.AOS.My.Resources.Resources.Delete
        Me.DeleteVendTestingMatrix.Name = "DeleteVendTestingMatrix"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.AddVendTestingMatrix)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.EditVendTestingMatrix)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.DeleteVendTestingMatrix)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Actions"
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.grVendorTestingMatrix)
        Me.GroupControl8.Controls.Add(Me.ComponentRibbonControl1)
        Me.GroupControl8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl8.Location = New System.Drawing.Point(0, 371)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(817, 323)
        Me.GroupControl8.TabIndex = 1
        Me.GroupControl8.Text = "Vendor Testing Matrix"
        '
        'AppgroupCollection1
        '
        Me.AppgroupCollection1.AllowDelete = True
        Me.AppgroupCollection1.AllowEdit = True
        Me.AppgroupCollection1.AllowNew = True
        Me.AppgroupCollection1.EnableHierarchicalBinding = True
        Me.AppgroupCollection1.Filter = ""
        Me.AppgroupCollection1.RowStateFilter = System.Data.DataViewRowState.None
        Me.AppgroupCollection1.Sort = ""
        Me.AppgroupCollection1.SuspendListChangedEvents = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Label3)
        Me.GroupControl1.Controls.Add(Me.LookUpEdit1)
        Me.GroupControl1.Controls.Add(Me.TextEdit1)
        Me.GroupControl1.Controls.Add(VendorphoneLabel)
        Me.GroupControl1.Controls.Add(Me.VendorfaxTextEdit)
        Me.GroupControl1.Controls.Add(Me.VendorphoneTextEdit)
        Me.GroupControl1.Controls.Add(VendorfaxLabel)
        Me.GroupControl1.Controls.Add(IsactiveLabel)
        Me.GroupControl1.Controls.Add(Me.VendorzipTextEdit)
        Me.GroupControl1.Controls.Add(Me.IsactiveCheckEdit)
        Me.GroupControl1.Controls.Add(Me.VendorcontactTextEdit)
        Me.GroupControl1.Controls.Add(Me.VendorstateTextEdit)
        Me.GroupControl1.Controls.Add(Me.MemoEdit1)
        Me.GroupControl1.Controls.Add(VendorcontactLabel)
        Me.GroupControl1.Controls.Add(Label2)
        Me.GroupControl1.Controls.Add(VendorcityLabel)
        Me.GroupControl1.Controls.Add(Me.VendoremailTextEdit)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Controls.Add(Me.VendorcityTextEdit)
        Me.GroupControl1.Controls.Add(Me.TermsTextEdit)
        Me.GroupControl1.Controls.Add(VendoremailLabel)
        Me.GroupControl1.Controls.Add(TermsLabel)
        Me.GroupControl1.Controls.Add(Vendoraddress2Label)
        Me.GroupControl1.Controls.Add(Me.VendornameTextEdit)
        Me.GroupControl1.Controls.Add(Me.VendorurlTextEdit)
        Me.GroupControl1.Controls.Add(VendornameLabel)
        Me.GroupControl1.Controls.Add(Me.Vendoraddress2TextEdit)
        Me.GroupControl1.Controls.Add(VendoracctnumberLabel)
        Me.GroupControl1.Controls.Add(VendorurlLabel)
        Me.GroupControl1.Controls.Add(Me.Vendoraddress1TextEdit)
        Me.GroupControl1.Controls.Add(Vendoraddress1Label)
        Me.GroupControl1.Controls.Add(Me.VendoracctnumberTextEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 117)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(817, 254)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Vendor Information"
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Vendorstatus", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(665, 33)
        Me.LookUpEdit1.MenuManager = Me.RibbonControl1
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.DataSource = Me.bsStatusOptions
        Me.LookUpEdit1.Properties.DisplayMember = "Status"
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.ValueMember = "Status"
        Me.LookUpEdit1.Size = New System.Drawing.Size(100, 20)
        Me.LookUpEdit1.TabIndex = 58
        '
        'bsStatusOptions
        '
        Me.bsStatusOptions.DataSource = GetType(AOS.BusinessObjects.ListStatusoptionsCollection)
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(584, 36)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(75, 13)
        Label3.TabIndex = 59
        Label3.Text = "Vendor Status"
        '
        'frmAddEditVendor
        '
        Me.ClientSize = New System.Drawing.Size(817, 694)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl8)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.lblModified)
        Me.Controls.Add(Me.lblCreated)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditVendor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Edit Information"
        CType(Me.TermsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendornameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vendoraddress1TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendoracctnumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vendoraddress2TextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorurlTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorcityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendoremailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorstateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorcontactTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorzipTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorphoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorfaxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grVendorTestingMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsVendorTestingMatrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentRibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        Me.GroupControl8.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStatusOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents TermsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendornameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vendoraddress1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendoracctnumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Vendoraddress2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorurlTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorcityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendoremailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorstateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorcontactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorzipTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorphoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents VendorfaxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents btnNewCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteCostRecord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents IsactiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents lblModified As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCreated As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grVendorTestingMatrix As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents colChemicalcategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colRetainpercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTestpercentage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colColor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAppearance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsactive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ComponentRibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents AddVendTestingMatrix As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterAdd As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterEdit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAlterDelete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents EditVendTestingMatrix As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DeleteVendTestingMatrix As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents colVendorid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsVendorTestingMatrix As System.Windows.Forms.BindingSource
    Friend WithEvents AppgroupCollection1 As AOS.BusinessObjects.AppgroupCollection
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsStatusOptions As BindingSource
End Class
