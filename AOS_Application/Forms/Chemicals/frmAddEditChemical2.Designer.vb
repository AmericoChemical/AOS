<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditChemical2

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
        Dim ChemicalidLabel As System.Windows.Forms.Label
        Dim ChemicalnameLabel As System.Windows.Forms.Label
        Dim AppearanceLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim OdorLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim PHLOWLabel As System.Windows.Forms.Label
        Dim SgLowLabel As System.Windows.Forms.Label
        Dim DensityLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim eSDSFilePath As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim UnlineLabel1 As System.Windows.Forms.Label
        Dim HealthLabel As System.Windows.Forms.Label
        Dim DotdescLabel As System.Windows.Forms.Label
        Dim HazmatdescLabel As System.Windows.Forms.Label
        Dim UnlineLabel As System.Windows.Forms.Label
        Dim FireLabel As System.Windows.Forms.Label
        Dim HazmatidLabel As System.Windows.Forms.Label
        Dim PersonalprotectionLabel As System.Windows.Forms.Label
        Dim ReactivityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditChemical2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bsChem = New System.Windows.Forms.BindingSource(Me.components)
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnProductList = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnChangeChemicalStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnViewPrintSDS = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnGHSLabelSpecs = New DevExpress.XtraBars.BarButtonItem()
        Me.Ribbon_LargeImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eSampleOnly = New DevExpress.XtraEditors.CheckEdit()
        Me.eChemStatus = New DevExpress.XtraEditors.TextEdit()
        Me.eChemicalName = New DevExpress.XtraEditors.TextEdit()
        Me.ChemicalidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.DensityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SgHighTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.SgLowTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PHHIGHTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PHLOWTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.StateLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsState = New System.Windows.Forms.BindingSource(Me.components)
        Me.OdorLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsOdor = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsColor = New System.Windows.Forms.BindingSource(Me.components)
        Me.AppearanceLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsClarity = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.bsLabelType = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.btnSDSFilePath = New DevExpress.XtraEditors.SimpleButton()
        Me.eSDSFileName = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.chkAutoLabel = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.LookUpEdit1 = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPkgGroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextEdit5 = New DevExpress.XtraEditors.TextEdit()
        Me.UnlineTextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.DotdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.HazmatdescTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.UnlineTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.HealthTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.HazmatidLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsHazmat = New System.Windows.Forms.BindingSource(Me.components)
        Me.FireTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.PersonalprotectionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ReactivityTextEdit = New DevExpress.XtraEditors.TextEdit()
        ChemicalidLabel = New System.Windows.Forms.Label()
        ChemicalnameLabel = New System.Windows.Forms.Label()
        AppearanceLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        OdorLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        PHLOWLabel = New System.Windows.Forms.Label()
        SgLowLabel = New System.Windows.Forms.Label()
        DensityLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        eSDSFilePath = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        UnlineLabel1 = New System.Windows.Forms.Label()
        HealthLabel = New System.Windows.Forms.Label()
        DotdescLabel = New System.Windows.Forms.Label()
        HazmatdescLabel = New System.Windows.Forms.Label()
        UnlineLabel = New System.Windows.Forms.Label()
        FireLabel = New System.Windows.Forms.Label()
        HazmatidLabel = New System.Windows.Forms.Label()
        PersonalprotectionLabel = New System.Windows.Forms.Label()
        ReactivityLabel = New System.Windows.Forms.Label()
        CType(Me.bsChem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eSampleOnly.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChemStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChemicalName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChemicalidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DensityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SgHighTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SgLowTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PHHIGHTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PHLOWTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsState, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OdorLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOdor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppearanceLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClarity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.bsLabelType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.eSDSFileName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.chkAutoLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPkgGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnlineTextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DotdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HazmatdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnlineTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HealthTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HazmatidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsHazmat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FireTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalprotectionTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReactivityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChemicalidLabel
        '
        ChemicalidLabel.AutoSize = True
        ChemicalidLabel.Location = New System.Drawing.Point(21, 37)
        ChemicalidLabel.Name = "ChemicalidLabel"
        ChemicalidLabel.Size = New System.Drawing.Size(63, 13)
        ChemicalidLabel.TabIndex = 0
        ChemicalidLabel.Text = "Chemical ID"
        '
        'ChemicalnameLabel
        '
        ChemicalnameLabel.AutoSize = True
        ChemicalnameLabel.Location = New System.Drawing.Point(7, 63)
        ChemicalnameLabel.Name = "ChemicalnameLabel"
        ChemicalnameLabel.Size = New System.Drawing.Size(79, 13)
        ChemicalnameLabel.TabIndex = 2
        ChemicalnameLabel.Text = "Chemical Name"
        '
        'AppearanceLabel
        '
        AppearanceLabel.AutoSize = True
        AppearanceLabel.Location = New System.Drawing.Point(44, 37)
        AppearanceLabel.Name = "AppearanceLabel"
        AppearanceLabel.Size = New System.Drawing.Size(38, 13)
        AppearanceLabel.TabIndex = 6
        AppearanceLabel.Text = "Clarity"
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(228, 37)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(32, 13)
        ColorLabel.TabIndex = 8
        ColorLabel.Text = "Color"
        '
        'OdorLabel
        '
        OdorLabel.AutoSize = True
        OdorLabel.Location = New System.Drawing.Point(386, 37)
        OdorLabel.Name = "OdorLabel"
        OdorLabel.Size = New System.Drawing.Size(31, 13)
        OdorLabel.TabIndex = 10
        OdorLabel.Text = "Odor"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(47, 126)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(33, 13)
        StateLabel.TabIndex = 12
        StateLabel.Text = "State"
        '
        'PHLOWLabel
        '
        PHLOWLabel.AutoSize = True
        PHLOWLabel.Location = New System.Drawing.Point(64, 91)
        PHLOWLabel.Name = "PHLOWLabel"
        PHLOWLabel.Size = New System.Drawing.Size(20, 13)
        PHLOWLabel.TabIndex = 14
        PHLOWLabel.Text = "pH"
        '
        'SgLowLabel
        '
        SgLowLabel.AutoSize = True
        SgLowLabel.Location = New System.Drawing.Point(208, 91)
        SgLowLabel.Name = "SgLowLabel"
        SgLowLabel.Size = New System.Drawing.Size(56, 13)
        SgLowLabel.TabIndex = 22
        SgLowLabel.Text = "Spec Grav"
        '
        'DensityLabel
        '
        DensityLabel.AutoSize = True
        DensityLabel.Location = New System.Drawing.Point(420, 72)
        DensityLabel.Name = "DensityLabel"
        DensityLabel.Size = New System.Drawing.Size(43, 13)
        DensityLabel.TabIndex = 32
        DensityLabel.Text = "Density"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(102, 72)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(26, 13)
        Label1.TabIndex = 4
        Label1.Text = "Low"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(160, 72)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(28, 13)
        Label2.TabIndex = 5
        Label2.Text = "High"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(102, 59)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 13)
        Label5.TabIndex = 38
        Label5.Text = "Accepted Range"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(284, 59)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(86, 13)
        Label3.TabIndex = 41
        Label3.Text = "Accepted Range"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(342, 72)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(28, 13)
        Label4.TabIndex = 40
        Label4.Text = "High"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(284, 72)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(26, 13)
        Label6.TabIndex = 39
        Label6.Text = "Low"
        '
        'eSDSFilePath
        '
        eSDSFilePath.AutoSize = True
        eSDSFilePath.Location = New System.Drawing.Point(14, 28)
        eSDSFilePath.Name = "eSDSFilePath"
        eSDSFilePath.Size = New System.Drawing.Size(70, 13)
        eSDSFilePath.TabIndex = 32
        eSDSFilePath.Text = "SDS File Path"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(414, 38)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(38, 13)
        Label13.TabIndex = 3
        Label13.Text = "Status"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(327, 158)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(79, 13)
        Label11.TabIndex = 46
        Label11.Text = "Package Group"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(170, 158)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(64, 13)
        Label12.TabIndex = 44
        Label12.Text = "Haz Class #"
        '
        'UnlineLabel1
        '
        UnlineLabel1.AutoSize = True
        UnlineLabel1.Location = New System.Drawing.Point(22, 158)
        UnlineLabel1.Name = "UnlineLabel1"
        UnlineLabel1.Size = New System.Drawing.Size(58, 13)
        UnlineLabel1.TabIndex = 42
        UnlineLabel1.Text = "ID Number"
        '
        'HealthLabel
        '
        HealthLabel.AutoSize = True
        HealthLabel.Location = New System.Drawing.Point(42, 28)
        HealthLabel.Name = "HealthLabel"
        HealthLabel.Size = New System.Drawing.Size(38, 13)
        HealthLabel.TabIndex = 24
        HealthLabel.Text = "Health"
        '
        'DotdescLabel
        '
        DotdescLabel.AutoSize = True
        DotdescLabel.Location = New System.Drawing.Point(26, 80)
        DotdescLabel.Name = "DotdescLabel"
        DotdescLabel.Size = New System.Drawing.Size(54, 13)
        DotdescLabel.TabIndex = 36
        DotdescLabel.Text = "DOT Desc"
        '
        'HazmatdescLabel
        '
        HazmatdescLabel.AutoSize = True
        HazmatdescLabel.Location = New System.Drawing.Point(13, 106)
        HazmatdescLabel.Name = "HazmatdescLabel"
        HazmatdescLabel.Size = New System.Drawing.Size(69, 13)
        HazmatdescLabel.TabIndex = 38
        HazmatdescLabel.Text = "Hazmat Desc"
        '
        'UnlineLabel
        '
        UnlineLabel.AutoSize = True
        UnlineLabel.Location = New System.Drawing.Point(37, 132)
        UnlineLabel.Name = "UnlineLabel"
        UnlineLabel.Size = New System.Drawing.Size(43, 13)
        UnlineLabel.TabIndex = 40
        UnlineLabel.Text = "UN Line"
        '
        'FireLabel
        '
        FireLabel.AutoSize = True
        FireLabel.Location = New System.Drawing.Point(130, 28)
        FireLabel.Name = "FireLabel"
        FireLabel.Size = New System.Drawing.Size(25, 13)
        FireLabel.TabIndex = 26
        FireLabel.Text = "Fire"
        '
        'HazmatidLabel
        '
        HazmatidLabel.AutoSize = True
        HazmatidLabel.Location = New System.Drawing.Point(3, 54)
        HazmatidLabel.Name = "HazmatidLabel"
        HazmatidLabel.Size = New System.Drawing.Size(81, 13)
        HazmatidLabel.TabIndex = 28
        HazmatidLabel.Text = "DOT Hazmat ID"
        '
        'PersonalprotectionLabel
        '
        PersonalprotectionLabel.AutoSize = True
        PersonalprotectionLabel.Location = New System.Drawing.Point(319, 28)
        PersonalprotectionLabel.Name = "PersonalprotectionLabel"
        PersonalprotectionLabel.Size = New System.Drawing.Size(100, 13)
        PersonalprotectionLabel.TabIndex = 32
        PersonalprotectionLabel.Text = "Personal Protection"
        '
        'ReactivityLabel
        '
        ReactivityLabel.AutoSize = True
        ReactivityLabel.Location = New System.Drawing.Point(207, 28)
        ReactivityLabel.Name = "ReactivityLabel"
        ReactivityLabel.Size = New System.Drawing.Size(55, 13)
        ReactivityLabel.TabIndex = 2
        ReactivityLabel.Text = "Reactivity"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'bsChem
        '
        Me.bsChem.DataSource = GetType(AOS.BusinessObjects.Chemical)
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.rbtnProductList, Me.rbtnChangeChemicalStatus, Me.rbtnViewPrintSDS, Me.rbtnGHSLabelSpecs})
        Me.RibbonControl1.LargeImages = Me.Ribbon_LargeImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 16
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(538, 116)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save"
        Me.btnSave.Id = 4
        Me.btnSave.ImageOptions.LargeImageIndex = 7
        Me.btnSave.Name = "btnSave"
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel"
        Me.btnCancel.Id = 5
        Me.btnCancel.ImageOptions.LargeImageIndex = 8
        Me.btnCancel.Name = "btnCancel"
        '
        'rbtnProductList
        '
        Me.rbtnProductList.Caption = "Current Linked Product List"
        Me.rbtnProductList.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnProductList.Id = 9
        Me.rbtnProductList.ImageOptions.LargeImageIndex = 38
        Me.rbtnProductList.Name = "rbtnProductList"
        '
        'rbtnChangeChemicalStatus
        '
        Me.rbtnChangeChemicalStatus.Caption = "Change Chemical Status"
        Me.rbtnChangeChemicalStatus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnChangeChemicalStatus.Id = 12
        Me.rbtnChangeChemicalStatus.ImageOptions.LargeImageIndex = 11
        Me.rbtnChangeChemicalStatus.Name = "rbtnChangeChemicalStatus"
        '
        'rbtnViewPrintSDS
        '
        Me.rbtnViewPrintSDS.Caption = "View / Print SDS Document"
        Me.rbtnViewPrintSDS.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnViewPrintSDS.Id = 13
        Me.rbtnViewPrintSDS.ImageOptions.LargeImageIndex = 6
        Me.rbtnViewPrintSDS.Name = "rbtnViewPrintSDS"
        '
        'rbtnGHSLabelSpecs
        '
        Me.rbtnGHSLabelSpecs.Caption = "Edit GHS Label Specs"
        Me.rbtnGHSLabelSpecs.Id = 15
        Me.rbtnGHSLabelSpecs.ImageOptions.LargeImageIndex = 9
        Me.rbtnGHSLabelSpecs.Name = "rbtnGHSLabelSpecs"
        '
        'Ribbon_LargeImages
        '
        Me.Ribbon_LargeImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.Ribbon_LargeImages.ImageStream = CType(resources.GetObject("Ribbon_LargeImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup1, Me.RibbonPageGroup3})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnGHSLabelSpecs, True)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.rbtnChangeChemicalStatus, True)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Actions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnProductList)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Text = "Products"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnViewPrintSDS)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Reports"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.eSampleOnly)
        Me.GroupControl1.Controls.Add(Label13)
        Me.GroupControl1.Controls.Add(Me.eChemStatus)
        Me.GroupControl1.Controls.Add(ChemicalnameLabel)
        Me.GroupControl1.Controls.Add(Me.eChemicalName)
        Me.GroupControl1.Controls.Add(ChemicalidLabel)
        Me.GroupControl1.Controls.Add(Me.ChemicalidTextEdit)
        Me.GroupControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl1.Location = New System.Drawing.Point(0, 116)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(538, 93)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Chemical Information"
        '
        'eSampleOnly
        '
        Me.eSampleOnly.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Sampleonly", True))
        Me.eSampleOnly.Location = New System.Drawing.Point(322, 35)
        Me.eSampleOnly.MenuManager = Me.RibbonControl1
        Me.eSampleOnly.Name = "eSampleOnly"
        Me.eSampleOnly.Properties.Caption = "Sample Only"
        Me.eSampleOnly.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.eSampleOnly.Size = New System.Drawing.Size(82, 19)
        Me.eSampleOnly.TabIndex = 9
        '
        'eChemStatus
        '
        Me.eChemStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Chemicalstatus", True))
        Me.eChemStatus.Location = New System.Drawing.Point(459, 35)
        Me.eChemStatus.MenuManager = Me.RibbonControl1
        Me.eChemStatus.Name = "eChemStatus"
        Me.eChemStatus.Properties.ReadOnly = True
        Me.eChemStatus.Size = New System.Drawing.Size(59, 20)
        Me.eChemStatus.TabIndex = 4
        Me.eChemStatus.TabStop = False
        '
        'eChemicalName
        '
        Me.eChemicalName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Chemicalname", True))
        Me.eChemicalName.Location = New System.Drawing.Point(88, 60)
        Me.eChemicalName.MenuManager = Me.RibbonControl1
        Me.eChemicalName.Name = "eChemicalName"
        Me.eChemicalName.Size = New System.Drawing.Size(430, 20)
        Me.eChemicalName.TabIndex = 0
        '
        'ChemicalidTextEdit
        '
        Me.ChemicalidTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Chemicalid", True))
        Me.ChemicalidTextEdit.Location = New System.Drawing.Point(88, 34)
        Me.ChemicalidTextEdit.MenuManager = Me.RibbonControl1
        Me.ChemicalidTextEdit.Name = "ChemicalidTextEdit"
        Me.ChemicalidTextEdit.Properties.ReadOnly = True
        Me.ChemicalidTextEdit.Size = New System.Drawing.Size(48, 20)
        Me.ChemicalidTextEdit.TabIndex = 0
        Me.ChemicalidTextEdit.TabStop = False
        '
        'DensityTextEdit
        '
        Me.DensityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Density", True))
        Me.DensityTextEdit.Location = New System.Drawing.Point(423, 88)
        Me.DensityTextEdit.MenuManager = Me.RibbonControl1
        Me.DensityTextEdit.Name = "DensityTextEdit"
        Me.DensityTextEdit.Properties.DisplayFormat.FormatString = "n3"
        Me.DensityTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.DensityTextEdit.Size = New System.Drawing.Size(54, 20)
        Me.DensityTextEdit.TabIndex = 7
        '
        'SgHighTextEdit
        '
        Me.SgHighTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "SgHigh", True))
        Me.SgHighTextEdit.Location = New System.Drawing.Point(330, 88)
        Me.SgHighTextEdit.MenuManager = Me.RibbonControl1
        Me.SgHighTextEdit.Name = "SgHighTextEdit"
        Me.SgHighTextEdit.Properties.DisplayFormat.FormatString = "n3"
        Me.SgHighTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SgHighTextEdit.Size = New System.Drawing.Size(54, 20)
        Me.SgHighTextEdit.TabIndex = 6
        '
        'SgLowTextEdit
        '
        Me.SgLowTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "SgLow", True))
        Me.SgLowTextEdit.Location = New System.Drawing.Point(270, 88)
        Me.SgLowTextEdit.MenuManager = Me.RibbonControl1
        Me.SgLowTextEdit.Name = "SgLowTextEdit"
        Me.SgLowTextEdit.Properties.DisplayFormat.FormatString = "n3"
        Me.SgLowTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SgLowTextEdit.Size = New System.Drawing.Size(54, 20)
        Me.SgLowTextEdit.TabIndex = 5
        '
        'PHHIGHTextEdit
        '
        Me.PHHIGHTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "PHHIGH", True))
        Me.PHHIGHTextEdit.Location = New System.Drawing.Point(148, 88)
        Me.PHHIGHTextEdit.MenuManager = Me.RibbonControl1
        Me.PHHIGHTextEdit.Name = "PHHIGHTextEdit"
        Me.PHHIGHTextEdit.Properties.DisplayFormat.FormatString = "n3"
        Me.PHHIGHTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PHHIGHTextEdit.Size = New System.Drawing.Size(54, 20)
        Me.PHHIGHTextEdit.TabIndex = 4
        '
        'PHLOWTextEdit
        '
        Me.PHLOWTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "PHLOW", True))
        Me.PHLOWTextEdit.Location = New System.Drawing.Point(88, 88)
        Me.PHLOWTextEdit.MenuManager = Me.RibbonControl1
        Me.PHLOWTextEdit.Name = "PHLOWTextEdit"
        Me.PHLOWTextEdit.Properties.DisplayFormat.FormatString = "n3"
        Me.PHLOWTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PHLOWTextEdit.Size = New System.Drawing.Size(54, 20)
        Me.PHLOWTextEdit.TabIndex = 3
        '
        'StateLookUpEdit
        '
        Me.StateLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Chemicalstate", True))
        Me.StateLookUpEdit.Location = New System.Drawing.Point(86, 123)
        Me.StateLookUpEdit.MenuManager = Me.RibbonControl1
        Me.StateLookUpEdit.Name = "StateLookUpEdit"
        Me.StateLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.StateLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Chemicalstate", "Chemical State", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.StateLookUpEdit.Properties.DataSource = Me.bsState
        Me.StateLookUpEdit.Properties.DisplayMember = "Chemicalstate"
        Me.StateLookUpEdit.Properties.NullText = ""
        Me.StateLookUpEdit.Properties.PopupWidth = 100
        Me.StateLookUpEdit.Properties.ShowFooter = False
        Me.StateLookUpEdit.Properties.ShowHeader = False
        Me.StateLookUpEdit.Properties.ShowLines = False
        Me.StateLookUpEdit.Properties.ValueMember = "Chemicalstate"
        Me.StateLookUpEdit.Size = New System.Drawing.Size(96, 20)
        Me.StateLookUpEdit.TabIndex = 8
        '
        'bsState
        '
        Me.bsState.DataSource = GetType(AOS.BusinessObjects.ListChemicalstateCollection)
        '
        'OdorLookUpEdit
        '
        Me.OdorLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Chemicalodor", True))
        Me.OdorLookUpEdit.Location = New System.Drawing.Point(423, 34)
        Me.OdorLookUpEdit.MenuManager = Me.RibbonControl1
        Me.OdorLookUpEdit.Name = "OdorLookUpEdit"
        Me.OdorLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.OdorLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Chemicalodor", "Odor", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.OdorLookUpEdit.Properties.DataSource = Me.bsOdor
        Me.OdorLookUpEdit.Properties.DisplayMember = "Chemicalodor"
        Me.OdorLookUpEdit.Properties.NullText = ""
        Me.OdorLookUpEdit.Properties.PopupWidth = 100
        Me.OdorLookUpEdit.Properties.ShowFooter = False
        Me.OdorLookUpEdit.Properties.ShowHeader = False
        Me.OdorLookUpEdit.Properties.ShowLines = False
        Me.OdorLookUpEdit.Properties.ValueMember = "Chemicalodor"
        Me.OdorLookUpEdit.Size = New System.Drawing.Size(95, 20)
        Me.OdorLookUpEdit.TabIndex = 2
        '
        'bsOdor
        '
        Me.bsOdor.DataSource = GetType(AOS.BusinessObjects.ListChemicalodorCollection)
        '
        'ColorLookUpEdit
        '
        Me.ColorLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Chemicalcolor", True))
        Me.ColorLookUpEdit.Location = New System.Drawing.Point(270, 34)
        Me.ColorLookUpEdit.MenuManager = Me.RibbonControl1
        Me.ColorLookUpEdit.Name = "ColorLookUpEdit"
        Me.ColorLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ColorLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Color", "Color", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ColorLookUpEdit.Properties.DataSource = Me.bsColor
        Me.ColorLookUpEdit.Properties.DisplayMember = "Color"
        Me.ColorLookUpEdit.Properties.NullText = ""
        Me.ColorLookUpEdit.Properties.PopupWidth = 100
        Me.ColorLookUpEdit.Properties.ShowFooter = False
        Me.ColorLookUpEdit.Properties.ShowHeader = False
        Me.ColorLookUpEdit.Properties.ShowLines = False
        Me.ColorLookUpEdit.Properties.ValueMember = "Color"
        Me.ColorLookUpEdit.Size = New System.Drawing.Size(114, 20)
        Me.ColorLookUpEdit.TabIndex = 1
        '
        'bsColor
        '
        Me.bsColor.DataSource = GetType(AOS.BusinessObjects.ListChemicalcolorCollection)
        '
        'AppearanceLookUpEdit
        '
        Me.AppearanceLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Chemicalclarity", True))
        Me.AppearanceLookUpEdit.Location = New System.Drawing.Point(88, 34)
        Me.AppearanceLookUpEdit.MenuManager = Me.RibbonControl1
        Me.AppearanceLookUpEdit.Name = "AppearanceLookUpEdit"
        Me.AppearanceLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.AppearanceLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Clarity", "Clarity", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.AppearanceLookUpEdit.Properties.DataSource = Me.bsClarity
        Me.AppearanceLookUpEdit.Properties.DisplayMember = "Clarity"
        Me.AppearanceLookUpEdit.Properties.NullText = ""
        Me.AppearanceLookUpEdit.Properties.PopupWidth = 100
        Me.AppearanceLookUpEdit.Properties.ShowFooter = False
        Me.AppearanceLookUpEdit.Properties.ShowHeader = False
        Me.AppearanceLookUpEdit.Properties.ShowLines = False
        Me.AppearanceLookUpEdit.Properties.ValueMember = "Clarity"
        Me.AppearanceLookUpEdit.Size = New System.Drawing.Size(114, 20)
        Me.AppearanceLookUpEdit.TabIndex = 0
        '
        'bsClarity
        '
        Me.bsClarity.DataSource = GetType(AOS.BusinessObjects.ListChemicalclarityCollection)
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Label3)
        Me.GroupControl2.Controls.Add(Label4)
        Me.GroupControl2.Controls.Add(Label6)
        Me.GroupControl2.Controls.Add(Me.DensityTextEdit)
        Me.GroupControl2.Controls.Add(Label5)
        Me.GroupControl2.Controls.Add(Me.AppearanceLookUpEdit)
        Me.GroupControl2.Controls.Add(AppearanceLabel)
        Me.GroupControl2.Controls.Add(Me.ColorLookUpEdit)
        Me.GroupControl2.Controls.Add(Label2)
        Me.GroupControl2.Controls.Add(ColorLabel)
        Me.GroupControl2.Controls.Add(Label1)
        Me.GroupControl2.Controls.Add(Me.OdorLookUpEdit)
        Me.GroupControl2.Controls.Add(DensityLabel)
        Me.GroupControl2.Controls.Add(OdorLabel)
        Me.GroupControl2.Controls.Add(Me.StateLookUpEdit)
        Me.GroupControl2.Controls.Add(StateLabel)
        Me.GroupControl2.Controls.Add(Me.PHLOWTextEdit)
        Me.GroupControl2.Controls.Add(PHLOWLabel)
        Me.GroupControl2.Controls.Add(Me.PHHIGHTextEdit)
        Me.GroupControl2.Controls.Add(Me.SgHighTextEdit)
        Me.GroupControl2.Controls.Add(Me.SgLowTextEdit)
        Me.GroupControl2.Controls.Add(SgLowLabel)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl2.Location = New System.Drawing.Point(0, 268)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(538, 160)
        Me.GroupControl2.TabIndex = 3
        Me.GroupControl2.Text = "Chemical Properties / Testing Standards"
        '
        'bsLabelType
        '
        Me.bsLabelType.DataSource = GetType(AOS.BusinessObjects.ListLabeltypeCollection)
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.btnSDSFilePath)
        Me.GroupControl3.Controls.Add(eSDSFilePath)
        Me.GroupControl3.Controls.Add(Me.eSDSFileName)
        Me.GroupControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupControl3.Location = New System.Drawing.Point(0, 209)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(538, 59)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Chemical Hazardous Materials Specifications"
        '
        'btnSDSFilePath
        '
        Me.btnSDSFilePath.Location = New System.Drawing.Point(457, 23)
        Me.btnSDSFilePath.Name = "btnSDSFilePath"
        Me.btnSDSFilePath.Size = New System.Drawing.Size(61, 22)
        Me.btnSDSFilePath.TabIndex = 33
        Me.btnSDSFilePath.Text = "Browse"
        '
        'eSDSFileName
        '
        Me.eSDSFileName.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Sdsfilepath", True))
        Me.eSDSFileName.Location = New System.Drawing.Point(88, 25)
        Me.eSDSFileName.MenuManager = Me.RibbonControl1
        Me.eSDSFileName.Name = "eSDSFileName"
        Me.eSDSFileName.Size = New System.Drawing.Size(364, 20)
        Me.eSDSFileName.TabIndex = 0
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.chkAutoLabel)
        Me.GroupControl4.Controls.Add(Me.CheckEdit2)
        Me.GroupControl4.Controls.Add(Me.CheckEdit1)
        Me.GroupControl4.Controls.Add(Me.LookUpEdit1)
        Me.GroupControl4.Controls.Add(Label11)
        Me.GroupControl4.Controls.Add(Label12)
        Me.GroupControl4.Controls.Add(Me.TextEdit5)
        Me.GroupControl4.Controls.Add(UnlineLabel1)
        Me.GroupControl4.Controls.Add(Me.UnlineTextEdit1)
        Me.GroupControl4.Controls.Add(HealthLabel)
        Me.GroupControl4.Controls.Add(Me.DotdescTextEdit)
        Me.GroupControl4.Controls.Add(DotdescLabel)
        Me.GroupControl4.Controls.Add(Me.HazmatdescTextEdit)
        Me.GroupControl4.Controls.Add(HazmatdescLabel)
        Me.GroupControl4.Controls.Add(Me.UnlineTextEdit)
        Me.GroupControl4.Controls.Add(Me.HealthTextEdit)
        Me.GroupControl4.Controls.Add(UnlineLabel)
        Me.GroupControl4.Controls.Add(FireLabel)
        Me.GroupControl4.Controls.Add(Me.HazmatidLookUpEdit)
        Me.GroupControl4.Controls.Add(Me.FireTextEdit)
        Me.GroupControl4.Controls.Add(HazmatidLabel)
        Me.GroupControl4.Controls.Add(PersonalprotectionLabel)
        Me.GroupControl4.Controls.Add(Me.PersonalprotectionTextEdit)
        Me.GroupControl4.Controls.Add(ReactivityLabel)
        Me.GroupControl4.Controls.Add(Me.ReactivityTextEdit)
        Me.GroupControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl4.Location = New System.Drawing.Point(0, 428)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(538, 200)
        Me.GroupControl4.TabIndex = 6
        Me.GroupControl4.Text = "Primary OSHA / DOT Shipping Information"
        '
        'chkAutoLabel
        '
        Me.chkAutoLabel.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Isautolabel", True))
        Me.chkAutoLabel.Location = New System.Drawing.Point(173, 181)
        Me.chkAutoLabel.MenuManager = Me.RibbonControl1
        Me.chkAutoLabel.Name = "chkAutoLabel"
        Me.chkAutoLabel.Properties.Caption = "Auto Label"
        Me.chkAutoLabel.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.chkAutoLabel.Size = New System.Drawing.Size(84, 19)
        Me.chkAutoLabel.TabIndex = 48
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Istoxic", True))
        Me.CheckEdit2.Location = New System.Drawing.Point(10, 181)
        Me.CheckEdit2.MenuManager = Me.RibbonControl1
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = "Chem is Toxic"
        Me.CheckEdit2.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit2.Size = New System.Drawing.Size(92, 19)
        Me.CheckEdit2.TabIndex = 47
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Usenonregdot", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(211, 51)
        Me.CheckEdit1.MenuManager = Me.RibbonControl1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = "Use non-regulated DOT below threshold volume"
        Me.CheckEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.CheckEdit1.Size = New System.Drawing.Size(254, 19)
        Me.CheckEdit1.TabIndex = 5
        '
        'LookUpEdit1
        '
        Me.LookUpEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Packagegroup", True))
        Me.LookUpEdit1.Location = New System.Drawing.Point(412, 155)
        Me.LookUpEdit1.Name = "LookUpEdit1"
        Me.LookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpEdit1.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PackageGroup", "Pkg Group", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.LookUpEdit1.Properties.DataSource = Me.bsPkgGroups
        Me.LookUpEdit1.Properties.DisplayMember = "PackageGroup"
        Me.LookUpEdit1.Properties.DropDownRows = 4
        Me.LookUpEdit1.Properties.NullText = ""
        Me.LookUpEdit1.Properties.PopupSizeable = False
        Me.LookUpEdit1.Properties.PopupWidth = 51
        Me.LookUpEdit1.Properties.ShowFooter = False
        Me.LookUpEdit1.Properties.ShowHeader = False
        Me.LookUpEdit1.Properties.ValueMember = "PackageGroup"
        Me.LookUpEdit1.Size = New System.Drawing.Size(51, 20)
        Me.LookUpEdit1.TabIndex = 11
        '
        'bsPkgGroups
        '
        Me.bsPkgGroups.DataSource = GetType(AOS.BusinessObjects.ListPackagegroupCollection)
        '
        'TextEdit5
        '
        Me.TextEdit5.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Hazclassnumber", True))
        Me.TextEdit5.Location = New System.Drawing.Point(240, 155)
        Me.TextEdit5.MenuManager = Me.RibbonControl1
        Me.TextEdit5.Name = "TextEdit5"
        Me.TextEdit5.Size = New System.Drawing.Size(51, 20)
        Me.TextEdit5.TabIndex = 10
        '
        'UnlineTextEdit1
        '
        Me.UnlineTextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Idnumber", True))
        Me.UnlineTextEdit1.Location = New System.Drawing.Point(86, 155)
        Me.UnlineTextEdit1.MenuManager = Me.RibbonControl1
        Me.UnlineTextEdit1.Name = "UnlineTextEdit1"
        Me.UnlineTextEdit1.Size = New System.Drawing.Size(51, 20)
        Me.UnlineTextEdit1.TabIndex = 9
        '
        'DotdescTextEdit
        '
        Me.DotdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Dotdesc", True))
        Me.DotdescTextEdit.Location = New System.Drawing.Point(86, 77)
        Me.DotdescTextEdit.Name = "DotdescTextEdit"
        Me.DotdescTextEdit.Size = New System.Drawing.Size(377, 20)
        Me.DotdescTextEdit.TabIndex = 6
        '
        'HazmatdescTextEdit
        '
        Me.HazmatdescTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Hazmatdesc", True))
        Me.HazmatdescTextEdit.Location = New System.Drawing.Point(86, 103)
        Me.HazmatdescTextEdit.Name = "HazmatdescTextEdit"
        Me.HazmatdescTextEdit.Size = New System.Drawing.Size(377, 20)
        Me.HazmatdescTextEdit.TabIndex = 7
        '
        'UnlineTextEdit
        '
        Me.UnlineTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Unline", True))
        Me.UnlineTextEdit.Location = New System.Drawing.Point(86, 129)
        Me.UnlineTextEdit.Name = "UnlineTextEdit"
        Me.UnlineTextEdit.Size = New System.Drawing.Size(377, 20)
        Me.UnlineTextEdit.TabIndex = 8
        '
        'HealthTextEdit
        '
        Me.HealthTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Health", True))
        Me.HealthTextEdit.Location = New System.Drawing.Point(86, 25)
        Me.HealthTextEdit.Name = "HealthTextEdit"
        Me.HealthTextEdit.Size = New System.Drawing.Size(40, 20)
        Me.HealthTextEdit.TabIndex = 0
        '
        'HazmatidLookUpEdit
        '
        Me.HazmatidLookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Hazmatid", True))
        Me.HazmatidLookUpEdit.Location = New System.Drawing.Point(86, 51)
        Me.HazmatidLookUpEdit.Name = "HazmatidLookUpEdit"
        Me.HazmatidLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.HazmatidLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HazMatID", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SymbolDesc", "Symbol Description", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.HazmatidLookUpEdit.Properties.DataSource = Me.bsHazmat
        Me.HazmatidLookUpEdit.Properties.DisplayMember = "SymbolDesc"
        Me.HazmatidLookUpEdit.Properties.NullText = ""
        Me.HazmatidLookUpEdit.Properties.ValueMember = "HazMatID"
        Me.HazmatidLookUpEdit.Size = New System.Drawing.Size(115, 20)
        Me.HazmatidLookUpEdit.TabIndex = 4
        '
        'bsHazmat
        '
        Me.bsHazmat.DataSource = GetType(AOS.BusinessObjects.HazmatsymbolCollection)
        '
        'FireTextEdit
        '
        Me.FireTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Fire", True))
        Me.FireTextEdit.Location = New System.Drawing.Point(161, 25)
        Me.FireTextEdit.Name = "FireTextEdit"
        Me.FireTextEdit.Size = New System.Drawing.Size(40, 20)
        Me.FireTextEdit.TabIndex = 1
        '
        'PersonalprotectionTextEdit
        '
        Me.PersonalprotectionTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Personalprotection", True))
        Me.PersonalprotectionTextEdit.Location = New System.Drawing.Point(423, 25)
        Me.PersonalprotectionTextEdit.Name = "PersonalprotectionTextEdit"
        Me.PersonalprotectionTextEdit.Size = New System.Drawing.Size(40, 20)
        Me.PersonalprotectionTextEdit.TabIndex = 3
        '
        'ReactivityTextEdit
        '
        Me.ReactivityTextEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bsChem, "Reactivity", True))
        Me.ReactivityTextEdit.Location = New System.Drawing.Point(268, 25)
        Me.ReactivityTextEdit.Name = "ReactivityTextEdit"
        Me.ReactivityTextEdit.Size = New System.Drawing.Size(40, 20)
        Me.ReactivityTextEdit.TabIndex = 2
        '
        'frmAddEditChemical2
        '
        Me.ClientSize = New System.Drawing.Size(538, 628)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditChemical2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Chemical Information"
        CType(Me.bsChem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ribbon_LargeImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eSampleOnly.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChemStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChemicalName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChemicalidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DensityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SgHighTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SgLowTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PHHIGHTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PHLOWTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsState, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OdorLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOdor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppearanceLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClarity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.bsLabelType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.eSDSFileName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.chkAutoLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPkgGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnlineTextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DotdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HazmatdescTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnlineTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HealthTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HazmatidLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsHazmat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FireTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalprotectionTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReactivityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bsChem As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents Ribbon_LargeImages As DevExpress.Utils.ImageCollection
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SgHighTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SgLowTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PHHIGHTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PHLOWTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents StateLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents OdorLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents ColorLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents AppearanceLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eChemicalName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ChemicalidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DensityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsState As System.Windows.Forms.BindingSource
    Friend WithEvents bsOdor As System.Windows.Forms.BindingSource
    Friend WithEvents bsColor As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bsClarity As System.Windows.Forms.BindingSource
    Friend WithEvents bsLabelType As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnSDSFilePath As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents eSDSFileName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eChemStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LookUpEdit1 As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents TextEdit5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnlineTextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DotdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HazmatdescTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents UnlineTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HealthTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents HazmatidLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents FireTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents PersonalprotectionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ReactivityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnProductList As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eSampleOnly As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rbtnChangeChemicalStatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents bsHazmat As System.Windows.Forms.BindingSource
    Friend WithEvents bsPkgGroups As System.Windows.Forms.BindingSource
    Friend WithEvents rbtnViewPrintSDS As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnGHSLabelSpecs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents chkAutoLabel As DevExpress.XtraEditors.CheckEdit
End Class
