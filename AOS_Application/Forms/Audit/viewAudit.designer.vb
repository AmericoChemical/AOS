<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewAudit

    'UserControl overrides dispose to clean up the component list.
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
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim CompanyAddressLabel As System.Windows.Forms.Label
        Dim CompanyCityLabel As System.Windows.Forms.Label
        Dim CompanyPhoneLabel As System.Windows.Forms.Label
        Dim CompanyFAXLabel As System.Windows.Forms.Label
        Dim CompanyCountryLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim StdlaborhourcostLabel As System.Windows.Forms.Label
        Dim FreezeWarningLabel As System.Windows.Forms.Label
        Me.FormCaption = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.GridView2 = New AOS.CustomClasses.CustomDevExGridView()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSaveParms = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancelParms = New DevExpress.XtraBars.BarButtonItem()
        Me.btnGetQBData = New DevExpress.XtraBars.BarButtonItem()
        Me.btnOpenIssues = New DevExpress.XtraBars.BarButtonItem()
        Me.btnClosedIssues = New DevExpress.XtraBars.BarButtonItem()
        Me.btnResolveLog = New DevExpress.XtraBars.BarButtonItem()
        Me.btnViewAuditForm = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddAuditForm = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditAuditForm = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteAuditForm = New DevExpress.XtraBars.BarButtonItem()
        Me.btnViewAuditPermissions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnAddAuditPermissions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditAuditPermissions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnDeleteAuditPermissions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnEditLog = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup21 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup22 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.WorkPanelsHolder = New DevExpress.XtraEditors.PanelControl()
        Me.RibbonPanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.pnlAuditCategoriesHolder = New DevExpress.XtraEditors.PanelControl()
        Me.gcAuditForm = New DevExpress.XtraEditors.GroupControl()
        Me.grAuditForm = New DevExpress.XtraGrid.GridControl()
        Me.bsAuditForm = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView3 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colAuditcategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuditformname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuditCatrgoryID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.pnlAuditPermissionHolder = New DevExpress.XtraEditors.PanelControl()
        Me.gcAuditPermission = New DevExpress.XtraEditors.GroupControl()
        Me.grAuditPermission = New DevExpress.XtraGrid.GridControl()
        Me.bsAuditPermission = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView4 = New AOS.CustomClasses.CustomDevExGridView()
        Me.colAuditPermissionAuditcategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUserlogin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAuditPermissionID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RibbonPanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.XtraTabControl2 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage9 = New DevExpress.XtraTab.XtraTabPage()
        Me.grAuditLog = New DevExpress.XtraGrid.GridControl()
        Me.bsAuditLog = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuditLogView = New AOS.CustomClasses.CustomDevExGridView()
        Me.colAuditlogid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMasterRecordID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResolution = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOccurrenceDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOccurrenceBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResolvedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResolvedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage4 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage5 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage6 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage7 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage8 = New DevExpress.XtraTab.XtraTabPage()
        Me.tabParameters = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.FreezeWarningCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.bsParms = New System.Windows.Forms.BindingSource(Me.components)
        Me.StdlaborhourcostTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyCountryTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyFAXTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyPhoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyZipcodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyStateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyCityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyAddressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.CompanyNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.colProductid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductdesc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContainer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AuditLogView1 = New AOS.CustomClasses.CustomDevExGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CompanyNameLabel = New System.Windows.Forms.Label()
        CompanyAddressLabel = New System.Windows.Forms.Label()
        CompanyCityLabel = New System.Windows.Forms.Label()
        CompanyPhoneLabel = New System.Windows.Forms.Label()
        CompanyFAXLabel = New System.Windows.Forms.Label()
        CompanyCountryLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        StdlaborhourcostLabel = New System.Windows.Forms.Label()
        FreezeWarningLabel = New System.Windows.Forms.Label()
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WorkPanelsHolder.SuspendLayout()
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl2.SuspendLayout()
        CType(Me.pnlAuditCategoriesHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAuditCategoriesHolder.SuspendLayout()
        CType(Me.gcAuditForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcAuditForm.SuspendLayout()
        CType(Me.grAuditForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAuditForm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlAuditPermissionHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAuditPermissionHolder.SuspendLayout()
        CType(Me.gcAuditPermission, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcAuditPermission.SuspendLayout()
        CType(Me.grAuditPermission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAuditPermission, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonPanelControl1.SuspendLayout()
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl2.SuspendLayout()
        Me.XtraTabPage9.SuspendLayout()
        CType(Me.grAuditLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAuditLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditLogView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        CType(Me.tabParameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabParameters.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.FreezeWarningCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsParms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StdlaborhourcostTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyCountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyFAXTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyPhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyZipcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyCityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuditLogView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(18, 20)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(86, 13)
        CompanyNameLabel.TabIndex = 0
        CompanyNameLabel.Text = "Company Name:"
        '
        'CompanyAddressLabel
        '
        CompanyAddressLabel.AutoSize = True
        CompanyAddressLabel.Location = New System.Drawing.Point(18, 46)
        CompanyAddressLabel.Name = "CompanyAddressLabel"
        CompanyAddressLabel.Size = New System.Drawing.Size(98, 13)
        CompanyAddressLabel.TabIndex = 2
        CompanyAddressLabel.Text = "Company Address:"
        '
        'CompanyCityLabel
        '
        CompanyCityLabel.AutoSize = True
        CompanyCityLabel.Location = New System.Drawing.Point(18, 72)
        CompanyCityLabel.Name = "CompanyCityLabel"
        CompanyCityLabel.Size = New System.Drawing.Size(108, 13)
        CompanyCityLabel.TabIndex = 4
        CompanyCityLabel.Text = "Company City St Zip:"
        '
        'CompanyPhoneLabel
        '
        CompanyPhoneLabel.AutoSize = True
        CompanyPhoneLabel.Location = New System.Drawing.Point(18, 124)
        CompanyPhoneLabel.Name = "CompanyPhoneLabel"
        CompanyPhoneLabel.Size = New System.Drawing.Size(89, 13)
        CompanyPhoneLabel.TabIndex = 10
        CompanyPhoneLabel.Text = "Company Phone:"
        '
        'CompanyFAXLabel
        '
        CompanyFAXLabel.AutoSize = True
        CompanyFAXLabel.Location = New System.Drawing.Point(18, 150)
        CompanyFAXLabel.Name = "CompanyFAXLabel"
        CompanyFAXLabel.Size = New System.Drawing.Size(78, 13)
        CompanyFAXLabel.TabIndex = 12
        CompanyFAXLabel.Text = "Company FAX:"
        '
        'CompanyCountryLabel
        '
        CompanyCountryLabel.AutoSize = True
        CompanyCountryLabel.Location = New System.Drawing.Point(18, 98)
        CompanyCountryLabel.Name = "CompanyCountryLabel"
        CompanyCountryLabel.Size = New System.Drawing.Size(98, 13)
        CompanyCountryLabel.TabIndex = 14
        CompanyCountryLabel.Text = "Company Country:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(18, 195)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 13)
        Label1.TabIndex = 16
        Label1.Text = "Sales Tax Rate:"
        '
        'StdlaborhourcostLabel
        '
        StdlaborhourcostLabel.AutoSize = True
        StdlaborhourcostLabel.Location = New System.Drawing.Point(18, 221)
        StdlaborhourcostLabel.Name = "StdlaborhourcostLabel"
        StdlaborhourcostLabel.Size = New System.Drawing.Size(108, 13)
        StdlaborhourcostLabel.TabIndex = 17
        StdlaborhourcostLabel.Text = "Std Labor Hour Cost:"
        '
        'FreezeWarningLabel
        '
        FreezeWarningLabel.AutoSize = True
        FreezeWarningLabel.Location = New System.Drawing.Point(18, 247)
        FreezeWarningLabel.Name = "FreezeWarningLabel"
        FreezeWarningLabel.Size = New System.Drawing.Size(87, 13)
        FreezeWarningLabel.TabIndex = 18
        FreezeWarningLabel.Text = "Freeze Warning:"
        '
        'FormCaption
        '
        Me.FormCaption.Dock = System.Windows.Forms.DockStyle.Top
        Me.FormCaption.EmbeddedNavigator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCaption.EmbeddedNavigator.Appearance.Options.UseFont = True
        Me.FormCaption.EmbeddedNavigator.Appearance.Options.UseTextOptions = True
        Me.FormCaption.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.FormCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormCaption.Location = New System.Drawing.Point(0, 0)
        Me.FormCaption.LookAndFeel.SkinName = "Money Twins"
        Me.FormCaption.MainView = Me.GridView1
        Me.FormCaption.Name = "FormCaption"
        Me.FormCaption.Size = New System.Drawing.Size(1156, 33)
        Me.FormCaption.TabIndex = 3
        Me.FormCaption.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1, Me.GridView2})
        '
        'GridView1
        '
        Me.GridView1.Appearance.GroupPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GridView1.GridControl = Me.FormCaption
        Me.GridView1.GroupPanelText = "Audit Management"
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.SmartVertScrollBar = False
        Me.GridView1.OptionsCustomization.AllowFilter = False
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsCustomization.AllowSort = False
        Me.GridView1.OptionsMenu.EnableColumnMenu = False
        Me.GridView1.OptionsView.ShowColumnHeaders = False
        Me.GridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.FormCaption
        Me.GridView2.Name = "GridView2"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ApplicationCaption = "dsadsdsa"
        Me.RibbonControl1.ApplicationDocumentCaption = "dsdsadsa"
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSaveParms, Me.btnCancelParms, Me.btnGetQBData, Me.btnOpenIssues, Me.btnClosedIssues, Me.btnResolveLog, Me.btnViewAuditForm, Me.btnAddAuditForm, Me.btnEditAuditForm, Me.btnDeleteAuditForm, Me.btnViewAuditPermissions, Me.btnAddAuditPermissions, Me.btnEditAuditPermissions, Me.btnDeleteAuditPermissions, Me.btnEditLog})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 33)
        Me.RibbonControl1.MaxItemId = 57
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show
        Me.RibbonControl1.Size = New System.Drawing.Size(1156, 115)
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSaveParms
        '
        Me.btnSaveParms.Caption = "Save"
        Me.btnSaveParms.Glyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSaveParms.Id = 51
        Me.btnSaveParms.LargeGlyph = Global.AOS.My.Resources.Resources.SaveChanges
        Me.btnSaveParms.Name = "btnSaveParms"
        '
        'btnCancelParms
        '
        Me.btnCancelParms.Caption = "Cancel"
        Me.btnCancelParms.Glyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancelParms.Id = 52
        Me.btnCancelParms.LargeGlyph = Global.AOS.My.Resources.Resources.CancelChanges
        Me.btnCancelParms.Name = "btnCancelParms"
        '
        'btnGetQBData
        '
        Me.btnGetQBData.Caption = "Get QB Data"
        Me.btnGetQBData.Id = 53
        Me.btnGetQBData.LargeGlyph = Global.AOS.My.Resources.Resources.Unquarantine
        Me.btnGetQBData.Name = "btnGetQBData"
        Me.btnGetQBData.Tag = "278"
        '
        'btnOpenIssues
        '
        Me.btnOpenIssues.Caption = "Opened Issues"
        Me.btnOpenIssues.Id = 54
        Me.btnOpenIssues.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnOpenIssues.Name = "btnOpenIssues"
        Me.btnOpenIssues.Tag = "277"
        '
        'btnClosedIssues
        '
        Me.btnClosedIssues.Caption = "Closed Issues"
        Me.btnClosedIssues.Id = 54
        Me.btnClosedIssues.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnClosedIssues.Name = "btnClosedIssues"
        Me.btnClosedIssues.Tag = "279"
        '
        'btnResolveLog
        '
        Me.btnResolveLog.Caption = "Resolve Issue"
        Me.btnResolveLog.Id = 55
        Me.btnResolveLog.LargeGlyph = Global.AOS.My.Resources.Resources.document_accept__2_
        Me.btnResolveLog.Name = "btnResolveLog"
        '
        'btnViewAuditForm
        '
        Me.btnViewAuditForm.Caption = "View Audit Categories"
        Me.btnViewAuditForm.Id = 118
        Me.btnViewAuditForm.LargeGlyph = Global.AOS.My.Resources.Resources.view_details
        Me.btnViewAuditForm.Name = "btnViewAuditForm"
        '
        'btnAddAuditForm
        '
        Me.btnAddAuditForm.Caption = "Add Audit Category"
        Me.btnAddAuditForm.Id = 120
        Me.btnAddAuditForm.LargeGlyph = Global.AOS.My.Resources.Resources.document_add__2_
        Me.btnAddAuditForm.Name = "btnAddAuditForm"
        '
        'btnEditAuditForm
        '
        Me.btnEditAuditForm.Caption = "Edit Audit Category"
        Me.btnEditAuditForm.Glyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditAuditForm.Id = 121
        Me.btnEditAuditForm.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditAuditForm.Name = "btnEditAuditForm"
        '
        'btnDeleteAuditForm
        '
        Me.btnDeleteAuditForm.Caption = "Delete Audit Category"
        Me.btnDeleteAuditForm.Glyph = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteAuditForm.Id = 122
        Me.btnDeleteAuditForm.LargeGlyph = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteAuditForm.Name = "btnDeleteAuditForm"
        '
        'btnViewAuditPermissions
        '
        Me.btnViewAuditPermissions.Caption = "View Audit Permissions"
        Me.btnViewAuditPermissions.Id = 123
        Me.btnViewAuditPermissions.LargeGlyph = Global.AOS.My.Resources.Resources.view_details
        Me.btnViewAuditPermissions.Name = "btnViewAuditPermissions"
        '
        'btnAddAuditPermissions
        '
        Me.btnAddAuditPermissions.Caption = "Add Audit Permission"
        Me.btnAddAuditPermissions.Id = 124
        Me.btnAddAuditPermissions.LargeGlyph = Global.AOS.My.Resources.Resources.document_add__2_
        Me.btnAddAuditPermissions.Name = "btnAddAuditPermissions"
        '
        'btnEditAuditPermissions
        '
        Me.btnEditAuditPermissions.Caption = "Edit Audit Permission"
        Me.btnEditAuditPermissions.Glyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditAuditPermissions.Id = 125
        Me.btnEditAuditPermissions.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditAuditPermissions.Name = "btnEditAuditPermissions"
        '
        'btnDeleteAuditPermissions
        '
        Me.btnDeleteAuditPermissions.Caption = "Delete Audit Permission"
        Me.btnDeleteAuditPermissions.Glyph = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteAuditPermissions.Id = 126
        Me.btnDeleteAuditPermissions.LargeGlyph = Global.AOS.My.Resources.Resources.DeleteHS
        Me.btnDeleteAuditPermissions.Name = "btnDeleteAuditPermissions"
        '
        'btnEditLog
        '
        Me.btnEditLog.Caption = "Edit  Issue"
        Me.btnEditLog.Id = 56
        Me.btnEditLog.LargeGlyph = Global.AOS.My.Resources.Resources.EditData
        Me.btnEditLog.Name = "btnEditLog"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1, Me.RibbonPageGroup2})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Tag = "119"
        Me.RibbonPage1.Text = "Audit Log"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnOpenIssues)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnClosedIssues)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "View Log"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnResolveLog)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnEditLog)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Action"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup21, Me.RibbonPageGroup22})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Audit Setup"
        '
        'RibbonPageGroup21
        '
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnViewAuditForm)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnAddAuditForm)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnEditAuditForm)
        Me.RibbonPageGroup21.ItemLinks.Add(Me.btnDeleteAuditForm)
        Me.RibbonPageGroup21.Name = "RibbonPageGroup21"
        Me.RibbonPageGroup21.ShowCaptionButton = False
        Me.RibbonPageGroup21.Text = "Audit Category Setup"
        '
        'RibbonPageGroup22
        '
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnViewAuditPermissions)
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnAddAuditPermissions)
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnEditAuditPermissions)
        Me.RibbonPageGroup22.ItemLinks.Add(Me.btnDeleteAuditPermissions)
        Me.RibbonPageGroup22.Name = "RibbonPageGroup22"
        Me.RibbonPageGroup22.ShowCaptionButton = False
        Me.RibbonPageGroup22.Text = "Audit Permission Setup"
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'WorkPanelsHolder
        '
        Me.WorkPanelsHolder.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl2)
        Me.WorkPanelsHolder.Controls.Add(Me.RibbonPanelControl1)
        Me.WorkPanelsHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkPanelsHolder.Location = New System.Drawing.Point(0, 148)
        Me.WorkPanelsHolder.Name = "WorkPanelsHolder"
        Me.WorkPanelsHolder.Size = New System.Drawing.Size(1156, 573)
        Me.WorkPanelsHolder.TabIndex = 7
        '
        'RibbonPanelControl2
        '
        Me.RibbonPanelControl2.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.RibbonPanelControl2.Appearance.Options.UseBackColor = True
        Me.RibbonPanelControl2.Controls.Add(Me.pnlAuditCategoriesHolder)
        Me.RibbonPanelControl2.Controls.Add(Me.pnlAuditPermissionHolder)
        Me.RibbonPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl2.Name = "RibbonPanelControl2"
        Me.RibbonPanelControl2.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl2.Size = New System.Drawing.Size(1156, 573)
        Me.RibbonPanelControl2.TabIndex = 0
        '
        'pnlAuditCategoriesHolder
        '
        Me.pnlAuditCategoriesHolder.Controls.Add(Me.gcAuditForm)
        Me.pnlAuditCategoriesHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAuditCategoriesHolder.Location = New System.Drawing.Point(8, 8)
        Me.pnlAuditCategoriesHolder.Name = "pnlAuditCategoriesHolder"
        Me.pnlAuditCategoriesHolder.Size = New System.Drawing.Size(1140, 557)
        Me.pnlAuditCategoriesHolder.TabIndex = 4
        '
        'gcAuditForm
        '
        Me.gcAuditForm.Controls.Add(Me.grAuditForm)
        Me.gcAuditForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAuditForm.Location = New System.Drawing.Point(2, 2)
        Me.gcAuditForm.Name = "gcAuditForm"
        Me.gcAuditForm.Size = New System.Drawing.Size(1136, 553)
        Me.gcAuditForm.TabIndex = 0
        Me.gcAuditForm.Text = "Audit Categories"
        '
        'grAuditForm
        '
        Me.grAuditForm.DataSource = Me.bsAuditForm
        Me.grAuditForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAuditForm.Location = New System.Drawing.Point(2, 32)
        Me.grAuditForm.MainView = Me.GridView3
        Me.grAuditForm.Name = "grAuditForm"
        Me.grAuditForm.Size = New System.Drawing.Size(1132, 519)
        Me.grAuditForm.TabIndex = 0
        Me.grAuditForm.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAuditcategory, Me.colAuditformname, Me.colAuditCatrgoryID})
        Me.GridView3.GridControl = Me.grAuditForm
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsView.ShowAutoFilterRow = True
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colAuditcategory
        '
        Me.colAuditcategory.Caption = "Audit Category"
        Me.colAuditcategory.FieldName = "Auditcategory"
        Me.colAuditcategory.Name = "colAuditcategory"
        Me.colAuditcategory.OptionsColumn.AllowEdit = False
        Me.colAuditcategory.Visible = True
        Me.colAuditcategory.VisibleIndex = 0
        Me.colAuditcategory.Width = 146
        '
        'colAuditformname
        '
        Me.colAuditformname.Caption = "Audit Form Name"
        Me.colAuditformname.FieldName = "Auditformname"
        Me.colAuditformname.Name = "colAuditformname"
        Me.colAuditformname.OptionsColumn.AllowEdit = False
        Me.colAuditformname.Visible = True
        Me.colAuditformname.VisibleIndex = 1
        Me.colAuditformname.Width = 177
        '
        'colAuditCatrgoryID
        '
        Me.colAuditCatrgoryID.Caption = "Audit Category ID"
        Me.colAuditCatrgoryID.FieldName = "Auditcategoryid"
        Me.colAuditCatrgoryID.Name = "colAuditCatrgoryID"
        Me.colAuditCatrgoryID.OptionsColumn.AllowEdit = False
        '
        'pnlAuditPermissionHolder
        '
        Me.pnlAuditPermissionHolder.Controls.Add(Me.gcAuditPermission)
        Me.pnlAuditPermissionHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAuditPermissionHolder.Location = New System.Drawing.Point(8, 8)
        Me.pnlAuditPermissionHolder.Name = "pnlAuditPermissionHolder"
        Me.pnlAuditPermissionHolder.Size = New System.Drawing.Size(1140, 557)
        Me.pnlAuditPermissionHolder.TabIndex = 3
        '
        'gcAuditPermission
        '
        Me.gcAuditPermission.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gcAuditPermission.AppearanceCaption.Options.UseBackColor = True
        Me.gcAuditPermission.Controls.Add(Me.grAuditPermission)
        Me.gcAuditPermission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcAuditPermission.Location = New System.Drawing.Point(2, 2)
        Me.gcAuditPermission.LookAndFeel.SkinName = "Money Twins"
        Me.gcAuditPermission.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat
        Me.gcAuditPermission.Name = "gcAuditPermission"
        Me.gcAuditPermission.Size = New System.Drawing.Size(1136, 553)
        Me.gcAuditPermission.TabIndex = 2
        Me.gcAuditPermission.Text = "Audit Permissions"
        '
        'grAuditPermission
        '
        Me.grAuditPermission.DataSource = Me.bsAuditPermission
        Me.grAuditPermission.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAuditPermission.Location = New System.Drawing.Point(2, 32)
        Me.grAuditPermission.MainView = Me.GridView4
        Me.grAuditPermission.Name = "grAuditPermission"
        Me.grAuditPermission.Size = New System.Drawing.Size(1132, 519)
        Me.grAuditPermission.TabIndex = 0
        Me.grAuditPermission.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'bsAuditPermission
        '
        Me.bsAuditPermission.DataSource = GetType(AOS.BusinessObjects.ViewAuditPermissionsCollection)
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAuditPermissionAuditcategory, Me.colUserlogin, Me.colAuditPermissionID})
        Me.GridView4.CustomizationFormBounds = New System.Drawing.Rectangle(265, 681, 210, 179)
        Me.GridView4.GridControl = Me.grAuditPermission
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsView.ShowAutoFilterRow = True
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'colAuditPermissionAuditcategory
        '
        Me.colAuditPermissionAuditcategory.Caption = "Audit Category"
        Me.colAuditPermissionAuditcategory.FieldName = "Auditcategory"
        Me.colAuditPermissionAuditcategory.Name = "colAuditPermissionAuditcategory"
        Me.colAuditPermissionAuditcategory.OptionsColumn.AllowEdit = False
        Me.colAuditPermissionAuditcategory.OptionsColumn.ReadOnly = True
        Me.colAuditPermissionAuditcategory.Visible = True
        Me.colAuditPermissionAuditcategory.VisibleIndex = 0
        '
        'colUserlogin
        '
        Me.colUserlogin.Caption = "User Login"
        Me.colUserlogin.FieldName = "Userlogin"
        Me.colUserlogin.Name = "colUserlogin"
        Me.colUserlogin.OptionsColumn.AllowEdit = False
        Me.colUserlogin.OptionsColumn.ReadOnly = True
        Me.colUserlogin.Visible = True
        Me.colUserlogin.VisibleIndex = 1
        '
        'colAuditPermissionID
        '
        Me.colAuditPermissionID.Caption = "Audit Permission ID"
        Me.colAuditPermissionID.FieldName = "Auditpermissionsid"
        Me.colAuditPermissionID.Name = "colAuditPermissionID"
        Me.colAuditPermissionID.OptionsColumn.AllowEdit = False
        '
        'RibbonPanelControl1
        '
        Me.RibbonPanelControl1.Controls.Add(Me.XtraTabControl2)
        Me.RibbonPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanelControl1.Name = "RibbonPanelControl1"
        Me.RibbonPanelControl1.Padding = New System.Windows.Forms.Padding(6)
        Me.RibbonPanelControl1.Size = New System.Drawing.Size(1156, 573)
        Me.RibbonPanelControl1.TabIndex = 1
        '
        'XtraTabControl2
        '
        Me.XtraTabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl2.Location = New System.Drawing.Point(8, 8)
        Me.XtraTabControl2.Name = "XtraTabControl2"
        Me.XtraTabControl2.SelectedTabPage = Me.XtraTabPage9
        Me.XtraTabControl2.Size = New System.Drawing.Size(1140, 557)
        Me.XtraTabControl2.TabIndex = 0
        Me.XtraTabControl2.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage9})
        '
        'XtraTabPage9
        '
        Me.XtraTabPage9.AutoScroll = True
        Me.XtraTabPage9.Controls.Add(Me.grAuditLog)
        Me.XtraTabPage9.Name = "XtraTabPage9"
        Me.XtraTabPage9.Size = New System.Drawing.Size(1134, 528)
        Me.XtraTabPage9.Text = "Audit Log"
        '
        'grAuditLog
        '
        Me.grAuditLog.DataSource = Me.bsAuditLog
        Me.grAuditLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grAuditLog.Location = New System.Drawing.Point(0, 0)
        Me.grAuditLog.MainView = Me.AuditLogView
        Me.grAuditLog.Name = "grAuditLog"
        Me.grAuditLog.Size = New System.Drawing.Size(1134, 528)
        Me.grAuditLog.TabIndex = 0
        Me.grAuditLog.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.AuditLogView})
        '
        'bsAuditLog
        '
        Me.bsAuditLog.DataSource = GetType(AOS.BusinessObjects.ViewAuditLogCollection)
        '
        'AuditLogView
        '
        Me.AuditLogView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAuditlogid, Me.colCategory, Me.colMasterRecordID, Me.colDescription, Me.GridColumn4, Me.colType, Me.colStatus, Me.colResolution, Me.colOccurrenceDate, Me.colOccurrenceBy, Me.colResolvedDate, Me.colResolvedBy})
        Me.AuditLogView.CustomizationFormBounds = New System.Drawing.Rectangle(979, 650, 210, 179)
        Me.AuditLogView.GridControl = Me.grAuditLog
        Me.AuditLogView.Name = "AuditLogView"
        Me.AuditLogView.OptionsBehavior.Editable = False
        Me.AuditLogView.OptionsSelection.MultiSelect = True
        Me.AuditLogView.OptionsView.ShowAutoFilterRow = True
        Me.AuditLogView.OptionsView.ShowGroupPanel = False
        '
        'colAuditlogid
        '
        Me.colAuditlogid.Caption = "Audit Log ID"
        Me.colAuditlogid.FieldName = "Auditlogid"
        Me.colAuditlogid.Name = "colAuditlogid"
        '
        'colCategory
        '
        Me.colCategory.Caption = "Category"
        Me.colCategory.FieldName = "Auditcategory"
        Me.colCategory.Name = "colCategory"
        Me.colCategory.OptionsColumn.AllowEdit = False
        Me.colCategory.Visible = True
        Me.colCategory.VisibleIndex = 0
        Me.colCategory.Width = 97
        '
        'colMasterRecordID
        '
        Me.colMasterRecordID.AppearanceHeader.Options.UseTextOptions = True
        Me.colMasterRecordID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.colMasterRecordID.Caption = "Master Record ID"
        Me.colMasterRecordID.FieldName = "Masterrecordid"
        Me.colMasterRecordID.Name = "colMasterRecordID"
        Me.colMasterRecordID.OptionsColumn.AllowEdit = False
        Me.colMasterRecordID.Visible = True
        Me.colMasterRecordID.VisibleIndex = 1
        Me.colMasterRecordID.Width = 51
        '
        'colDescription
        '
        Me.colDescription.Caption = "Description"
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.OptionsColumn.AllowEdit = False
        Me.colDescription.Visible = True
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 134
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Audit Reason"
        Me.GridColumn4.FieldName = "Auditreason"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 131
        '
        'colType
        '
        Me.colType.Caption = "Type"
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.OptionsColumn.AllowEdit = False
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 4
        Me.colType.Width = 52
        '
        'colStatus
        '
        Me.colStatus.Caption = "Status"
        Me.colStatus.FieldName = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.OptionsColumn.AllowEdit = False
        Me.colStatus.Visible = True
        Me.colStatus.VisibleIndex = 5
        Me.colStatus.Width = 64
        '
        'colResolution
        '
        Me.colResolution.Caption = "Resolution"
        Me.colResolution.FieldName = "Resolution"
        Me.colResolution.Name = "colResolution"
        Me.colResolution.OptionsColumn.AllowEdit = False
        Me.colResolution.Visible = True
        Me.colResolution.VisibleIndex = 6
        Me.colResolution.Width = 165
        '
        'colOccurrenceDate
        '
        Me.colOccurrenceDate.AppearanceCell.Options.UseTextOptions = True
        Me.colOccurrenceDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colOccurrenceDate.Caption = "Occurrence Date"
        Me.colOccurrenceDate.DisplayFormat.FormatString = "d"
        Me.colOccurrenceDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colOccurrenceDate.FieldName = "Occurrence"
        Me.colOccurrenceDate.Name = "colOccurrenceDate"
        Me.colOccurrenceDate.OptionsColumn.AllowEdit = False
        Me.colOccurrenceDate.Visible = True
        Me.colOccurrenceDate.VisibleIndex = 7
        Me.colOccurrenceDate.Width = 65
        '
        'colOccurrenceBy
        '
        Me.colOccurrenceBy.Caption = "Occurrence By"
        Me.colOccurrenceBy.FieldName = "Occurrenceby"
        Me.colOccurrenceBy.Name = "colOccurrenceBy"
        Me.colOccurrenceBy.OptionsColumn.AllowEdit = False
        Me.colOccurrenceBy.Visible = True
        Me.colOccurrenceBy.VisibleIndex = 8
        Me.colOccurrenceBy.Width = 112
        '
        'colResolvedDate
        '
        Me.colResolvedDate.AppearanceCell.Options.UseTextOptions = True
        Me.colResolvedDate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colResolvedDate.Caption = "Resolved Date"
        Me.colResolvedDate.DisplayFormat.FormatString = "d"
        Me.colResolvedDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colResolvedDate.FieldName = "Resolved"
        Me.colResolvedDate.Name = "colResolvedDate"
        Me.colResolvedDate.OptionsColumn.AllowEdit = False
        Me.colResolvedDate.Visible = True
        Me.colResolvedDate.VisibleIndex = 9
        Me.colResolvedDate.Width = 53
        '
        'colResolvedBy
        '
        Me.colResolvedBy.Caption = "Resolved By"
        Me.colResolvedBy.FieldName = "Resolvedby"
        Me.colResolvedBy.Name = "colResolvedBy"
        Me.colResolvedBy.OptionsColumn.AllowEdit = False
        Me.colResolvedBy.Visible = True
        Me.colResolvedBy.VisibleIndex = 10
        Me.colResolvedBy.Width = 192
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(200, 100)
        Me.SplitContainerControl1.TabIndex = 0
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(8, 8)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage2
        Me.XtraTabControl1.Size = New System.Drawing.Size(1140, 555)
        Me.XtraTabControl1.TabIndex = 0
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage2, Me.XtraTabPage3, Me.XtraTabPage4, Me.XtraTabPage5, Me.XtraTabPage6, Me.XtraTabPage7, Me.XtraTabPage8})
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1134, 527)
        Me.XtraTabPage2.Text = "Login Credentials"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1134, 527)
        Me.XtraTabPage3.Text = "Customers"
        '
        'XtraTabPage4
        '
        Me.XtraTabPage4.Name = "XtraTabPage4"
        Me.XtraTabPage4.Size = New System.Drawing.Size(1134, 527)
        Me.XtraTabPage4.Text = "Vendors"
        '
        'XtraTabPage5
        '
        Me.XtraTabPage5.Name = "XtraTabPage5"
        Me.XtraTabPage5.Size = New System.Drawing.Size(1134, 527)
        Me.XtraTabPage5.Text = "Invoices"
        '
        'XtraTabPage6
        '
        Me.XtraTabPage6.Name = "XtraTabPage6"
        Me.XtraTabPage6.Size = New System.Drawing.Size(1134, 527)
        Me.XtraTabPage6.Text = "Credit Memos"
        '
        'XtraTabPage7
        '
        Me.XtraTabPage7.Name = "XtraTabPage7"
        Me.XtraTabPage7.Size = New System.Drawing.Size(1134, 527)
        Me.XtraTabPage7.Text = "Customer Payments"
        '
        'XtraTabPage8
        '
        Me.XtraTabPage8.Name = "XtraTabPage8"
        Me.XtraTabPage8.Size = New System.Drawing.Size(1134, 527)
        Me.XtraTabPage8.Text = "Purchase Orders"
        '
        'tabParameters
        '
        Me.tabParameters.Location = New System.Drawing.Point(9, 9)
        Me.tabParameters.Name = "tabParameters"
        Me.tabParameters.SelectedTabPage = Me.XtraTabPage1
        Me.tabParameters.Size = New System.Drawing.Size(432, 315)
        Me.tabParameters.TabIndex = 0
        Me.tabParameters.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(FreezeWarningLabel)
        Me.XtraTabPage1.Controls.Add(Me.FreezeWarningCheckEdit)
        Me.XtraTabPage1.Controls.Add(StdlaborhourcostLabel)
        Me.XtraTabPage1.Controls.Add(Me.StdlaborhourcostTextEdit)
        Me.XtraTabPage1.Controls.Add(Label1)
        Me.XtraTabPage1.Controls.Add(Me.TextEdit1)
        Me.XtraTabPage1.Controls.Add(CompanyCountryLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyCountryTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyFAXLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyFAXTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyPhoneLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyPhoneTextEdit)
        Me.XtraTabPage1.Controls.Add(Me.CompanyZipcodeTextEdit)
        Me.XtraTabPage1.Controls.Add(Me.CompanyStateTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyCityLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyCityTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyAddressLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyAddressTextEdit)
        Me.XtraTabPage1.Controls.Add(CompanyNameLabel)
        Me.XtraTabPage1.Controls.Add(Me.CompanyNameTextEdit)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(426, 287)
        Me.XtraTabPage1.Text = "Company Info"
        '
        'FreezeWarningCheckEdit
        '
        Me.FreezeWarningCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "FreezeWarning", True))
        Me.FreezeWarningCheckEdit.Location = New System.Drawing.Point(141, 244)
        Me.FreezeWarningCheckEdit.MenuManager = Me.RibbonControl1
        Me.FreezeWarningCheckEdit.Name = "FreezeWarningCheckEdit"
        Me.FreezeWarningCheckEdit.Properties.Caption = ""
        Me.FreezeWarningCheckEdit.Properties.ReadOnly = True
        Me.FreezeWarningCheckEdit.Properties.ValueChecked = 1
        Me.FreezeWarningCheckEdit.Properties.ValueUnchecked = 0
        Me.FreezeWarningCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.FreezeWarningCheckEdit.TabIndex = 19
        '
        'bsParms
        '
        Me.bsParms.DataSource = GetType(AOS.BusinessObjects.Sysparameters)
        '
        'StdlaborhourcostTextEdit
        '
        Me.StdlaborhourcostTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "Stdlaborhourcost", True))
        Me.StdlaborhourcostTextEdit.Location = New System.Drawing.Point(143, 218)
        Me.StdlaborhourcostTextEdit.MenuManager = Me.RibbonControl1
        Me.StdlaborhourcostTextEdit.Name = "StdlaborhourcostTextEdit"
        Me.StdlaborhourcostTextEdit.Properties.DisplayFormat.FormatString = "c2"
        Me.StdlaborhourcostTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.StdlaborhourcostTextEdit.Properties.ReadOnly = True
        Me.StdlaborhourcostTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.StdlaborhourcostTextEdit.TabIndex = 18
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "DefaultSalesTaxRate", True))
        Me.TextEdit1.Location = New System.Drawing.Point(143, 192)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "P2"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Size = New System.Drawing.Size(46, 20)
        Me.TextEdit1.TabIndex = 17
        '
        'CompanyCountryTextEdit
        '
        Me.CompanyCountryTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyCountry", True))
        Me.CompanyCountryTextEdit.Location = New System.Drawing.Point(143, 95)
        Me.CompanyCountryTextEdit.Name = "CompanyCountryTextEdit"
        Me.CompanyCountryTextEdit.Properties.ReadOnly = True
        Me.CompanyCountryTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.CompanyCountryTextEdit.TabIndex = 15
        '
        'CompanyFAXTextEdit
        '
        Me.CompanyFAXTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyFAX", True))
        Me.CompanyFAXTextEdit.Location = New System.Drawing.Point(143, 147)
        Me.CompanyFAXTextEdit.Name = "CompanyFAXTextEdit"
        Me.CompanyFAXTextEdit.Properties.ReadOnly = True
        Me.CompanyFAXTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CompanyFAXTextEdit.TabIndex = 13
        '
        'CompanyPhoneTextEdit
        '
        Me.CompanyPhoneTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyPhone", True))
        Me.CompanyPhoneTextEdit.Location = New System.Drawing.Point(143, 121)
        Me.CompanyPhoneTextEdit.Name = "CompanyPhoneTextEdit"
        Me.CompanyPhoneTextEdit.Properties.ReadOnly = True
        Me.CompanyPhoneTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.CompanyPhoneTextEdit.TabIndex = 11
        '
        'CompanyZipcodeTextEdit
        '
        Me.CompanyZipcodeTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyZipcode", True))
        Me.CompanyZipcodeTextEdit.Location = New System.Drawing.Point(344, 69)
        Me.CompanyZipcodeTextEdit.Name = "CompanyZipcodeTextEdit"
        Me.CompanyZipcodeTextEdit.Properties.ReadOnly = True
        Me.CompanyZipcodeTextEdit.Size = New System.Drawing.Size(68, 20)
        Me.CompanyZipcodeTextEdit.TabIndex = 9
        '
        'CompanyStateTextEdit
        '
        Me.CompanyStateTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyState", True))
        Me.CompanyStateTextEdit.Location = New System.Drawing.Point(311, 69)
        Me.CompanyStateTextEdit.Name = "CompanyStateTextEdit"
        Me.CompanyStateTextEdit.Properties.ReadOnly = True
        Me.CompanyStateTextEdit.Size = New System.Drawing.Size(27, 20)
        Me.CompanyStateTextEdit.TabIndex = 7
        '
        'CompanyCityTextEdit
        '
        Me.CompanyCityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyCity", True))
        Me.CompanyCityTextEdit.Location = New System.Drawing.Point(143, 69)
        Me.CompanyCityTextEdit.Name = "CompanyCityTextEdit"
        Me.CompanyCityTextEdit.Properties.ReadOnly = True
        Me.CompanyCityTextEdit.Size = New System.Drawing.Size(162, 20)
        Me.CompanyCityTextEdit.TabIndex = 5
        '
        'CompanyAddressTextEdit
        '
        Me.CompanyAddressTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyAddress", True))
        Me.CompanyAddressTextEdit.Location = New System.Drawing.Point(143, 43)
        Me.CompanyAddressTextEdit.Name = "CompanyAddressTextEdit"
        Me.CompanyAddressTextEdit.Properties.ReadOnly = True
        Me.CompanyAddressTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.CompanyAddressTextEdit.TabIndex = 3
        '
        'CompanyNameTextEdit
        '
        Me.CompanyNameTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsParms, "CompanyName", True))
        Me.CompanyNameTextEdit.Location = New System.Drawing.Point(143, 17)
        Me.CompanyNameTextEdit.Name = "CompanyNameTextEdit"
        Me.CompanyNameTextEdit.Properties.ReadOnly = True
        Me.CompanyNameTextEdit.Size = New System.Drawing.Size(269, 20)
        Me.CompanyNameTextEdit.TabIndex = 1
        '
        'colProductid
        '
        Me.colProductid.Name = "colProductid"
        '
        'colProductdesc
        '
        Me.colProductdesc.Name = "colProductdesc"
        '
        'colContainer
        '
        Me.colContainer.Name = "colContainer"
        '
        'GridColumn3
        '
        Me.GridColumn3.Name = "GridColumn3"
        '
        'AuditLogView1
        '
        Me.AuditLogView1.Name = "AuditLogView1"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        '
        'viewAudit
        '
        Me.Controls.Add(Me.WorkPanelsHolder)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.FormCaption)
        Me.Name = "viewAudit"
        Me.Size = New System.Drawing.Size(1156, 721)
        Me.Tag = ""
        CType(Me.FormCaption, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkPanelsHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WorkPanelsHolder.ResumeLayout(False)
        CType(Me.RibbonPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl2.ResumeLayout(False)
        CType(Me.pnlAuditCategoriesHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAuditCategoriesHolder.ResumeLayout(False)
        CType(Me.gcAuditForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcAuditForm.ResumeLayout(False)
        CType(Me.grAuditForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAuditForm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlAuditPermissionHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAuditPermissionHolder.ResumeLayout(False)
        CType(Me.gcAuditPermission, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcAuditPermission.ResumeLayout(False)
        CType(Me.grAuditPermission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAuditPermission, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonPanelControl1.ResumeLayout(False)
        CType(Me.XtraTabControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl2.ResumeLayout(False)
        Me.XtraTabPage9.ResumeLayout(False)
        CType(Me.grAuditLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAuditLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditLogView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        CType(Me.tabParameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabParameters.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.FreezeWarningCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsParms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StdlaborhourcostTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyCountryTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyFAXTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyPhoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyZipcodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyStateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyCityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyAddressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuditLogView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FormCaption As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As CustomDevExGridView
    Friend WithEvents GridView2 As CustomDevExGridView
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents WorkPanelsHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsParms As System.Windows.Forms.BindingSource
    Friend WithEvents btnSaveParms As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancelParms As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnGetQBData As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnOpenIssues As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnClosedIssues As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnResolveLog As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents RibbonPanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents gcAuditForm As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grAuditForm As DevExpress.XtraGrid.GridControl
    Friend WithEvents XtraTabControl2 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage9 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents AuditLogView1 As CustomDevExGridView
    Friend WithEvents colCategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResolution As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOccurrenceDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOccurrenceBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResolvedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResolvedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tabParameters As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents FreezeWarningCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents StdlaborhourcostTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyCountryTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyFAXTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyPhoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyZipcodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyStateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyCityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyAddressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CompanyNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage5 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage6 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage7 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage8 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents bsAuditLog As System.Windows.Forms.BindingSource
    Friend WithEvents grAuditLog As DevExpress.XtraGrid.GridControl
    Friend WithEvents AuditLogView As CustomDevExGridView
    Friend WithEvents colProductid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductdesc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContainer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMasterRecordID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView3 As CustomDevExGridView
    Friend WithEvents colAuditcategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuditformname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup21 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup22 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnViewAuditForm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddAuditForm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditAuditForm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteAuditForm As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnViewAuditPermissions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnAddAuditPermissions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnEditAuditPermissions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDeleteAuditPermissions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcAuditPermission As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grAuditPermission As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As CustomDevExGridView
    Friend WithEvents colAuditPermissionAuditcategory As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUserlogin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnEditLog As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsAuditForm As System.Windows.Forms.BindingSource
    Friend WithEvents bsAuditPermission As System.Windows.Forms.BindingSource
    Friend WithEvents colAuditPermissionID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuditCatrgoryID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAuditlogid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnlAuditPermissionHolder As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlAuditCategoriesHolder As DevExpress.XtraEditors.PanelControl

End Class
