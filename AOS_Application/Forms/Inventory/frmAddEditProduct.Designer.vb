<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditProduct

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
        Dim ProductidLabel As System.Windows.Forms.Label
        Dim ProductdescLabel As System.Windows.Forms.Label
        Dim ContainerLabel As System.Windows.Forms.Label
        Dim StdgallonsLabel As System.Windows.Forms.Label
        Dim StdweightLabel As System.Windows.Forms.Label
        Dim ClassrateLabel As System.Windows.Forms.Label
        Dim DotdescLabel As System.Windows.Forms.Label
        Dim HazmatdescLabel As System.Windows.Forms.Label
        Dim UnlineLabel As System.Windows.Forms.Label
        Dim HazmatidLabel As System.Windows.Forms.Label
        Dim ReactivityLabel As System.Windows.Forms.Label
        Dim PersonalprotectionLabel As System.Windows.Forms.Label
        Dim QtyminonhandLabel As System.Windows.Forms.Label
        Dim ReorderqtyLabel As System.Windows.Forms.Label
        Dim FireLabel As System.Windows.Forms.Label
        Dim HealthLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim UnlineLabel1 As System.Windows.Forms.Label
        Dim VolumeunitsLabel As System.Windows.Forms.Label
        Dim VolumeuomLabel As System.Windows.Forms.Label
        Dim WeightunitsLabel As System.Windows.Forms.Label
        Dim WeightuomLabel As System.Windows.Forms.Label
        Dim IsactiveLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim InventorymethodLabel As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim RqLabel As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditProduct))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.eProductID = New DevExpress.XtraEditors.TextEdit()
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.eProductDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eContainer = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsContainers = New System.Windows.Forms.BindingSource(Me.components)
        Me.eLblGallons = New DevExpress.XtraEditors.TextEdit()
        Me.eLblWeight = New DevExpress.XtraEditors.TextEdit()
        Me.eClassRate = New DevExpress.XtraEditors.TextEdit()
        Me.eDOTDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eHazmatDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eUNLine = New DevExpress.XtraEditors.TextEdit()
        Me.eHazmatID = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsHazmat = New System.Windows.Forms.BindingSource(Me.components)
        Me.eReactivity = New DevExpress.XtraEditors.TextEdit()
        Me.ePersonalProtection = New DevExpress.XtraEditors.TextEdit()
        Me.eMinimumOnHand = New DevExpress.XtraEditors.TextEdit()
        Me.eReorderQty = New DevExpress.XtraEditors.TextEdit()
        Me.eFire = New DevExpress.XtraEditors.TextEdit()
        Me.eHealth = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnSave = New DevExpress.XtraBars.BarButtonItem()
        Me.btnCancel = New DevExpress.XtraBars.BarButtonItem()
        Me.btnViewProductCost = New DevExpress.XtraBars.BarButtonItem()
        Me.btnProductFulfillment = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnChangeProductStatus = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnViewPrintSDSDocument = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnAssignChemical = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnChangeStandardCosts = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnProductSales = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnProductPurchases = New DevExpress.XtraBars.BarButtonItem()
        Me.rbtnProductApisCosts = New DevExpress.XtraBars.BarButtonItem()
        Me.LargeRibbonImages = New DevExpress.Utils.ImageCollection(Me.components)
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.rpgHistory = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RepositoryItemWeekOfMonth1 = New DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth()
        Me.RepositoryItemAppointmentLabel1 = New DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel()
        Me.eAddnDesc = New DevExpress.XtraEditors.TextEdit()
        Me.bsInventoryClass = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCustomers = New System.Windows.Forms.BindingSource(Me.components)
        Me.luCustomers = New DevExpress.XtraEditors.LookUpEdit()
        Me.eLblUOM = New DevExpress.XtraEditors.TextEdit()
        Me.eLblUnits = New DevExpress.XtraEditors.TextEdit()
        Me.eInvGroup = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.eChemName = New DevExpress.XtraEditors.TextEdit()
        Me.eChemID = New DevExpress.XtraEditors.TextEdit()
        Me.eMaterialDesc = New DevExpress.XtraEditors.TextEdit()
        Me.eRQ = New DevExpress.XtraEditors.CheckEdit()
        Me.eMatID = New DevExpress.XtraEditors.TextEdit()
        Me.eStatus = New DevExpress.XtraEditors.TextEdit()
        Me.IsactiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.DefaultToolTipController1 = New DevExpress.Utils.DefaultToolTipController(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lblModified = New DevExpress.XtraEditors.LabelControl()
        Me.lblCreated = New DevExpress.XtraEditors.LabelControl()
        Me.bsChemicalList = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProductStatusCodes = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEditOverride = New DevExpress.XtraEditors.CheckEdit()
        Me.eStdCostSource = New DevExpress.XtraEditors.TextEdit()
        Me.eWgtCost = New DevExpress.XtraEditors.TextEdit()
        Me.eVolCost = New DevExpress.XtraEditors.TextEdit()
        Me.eWgtUOM = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsUOMWeight = New System.Windows.Forms.BindingSource(Me.components)
        Me.eWgtUnits = New DevExpress.XtraEditors.TextEdit()
        Me.eVolUOM = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsUOMVolume = New System.Windows.Forms.BindingSource(Me.components)
        Me.eVolUnits = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.ePkgGroup = New DevExpress.XtraEditors.LookUpEdit()
        Me.bsPkgGroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.eHazMatClassNumber = New DevExpress.XtraEditors.TextEdit()
        Me.eIDNumber = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit2 = New DevExpress.XtraEditors.CheckEdit()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.eInvMethod = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit()
        Me.eReceivingNotes = New DevExpress.XtraEditors.MemoEdit()
        Me.eVendorNotes = New DevExpress.XtraEditors.MemoEdit()
        ProductidLabel = New System.Windows.Forms.Label()
        ProductdescLabel = New System.Windows.Forms.Label()
        ContainerLabel = New System.Windows.Forms.Label()
        StdgallonsLabel = New System.Windows.Forms.Label()
        StdweightLabel = New System.Windows.Forms.Label()
        ClassrateLabel = New System.Windows.Forms.Label()
        DotdescLabel = New System.Windows.Forms.Label()
        HazmatdescLabel = New System.Windows.Forms.Label()
        UnlineLabel = New System.Windows.Forms.Label()
        HazmatidLabel = New System.Windows.Forms.Label()
        ReactivityLabel = New System.Windows.Forms.Label()
        PersonalprotectionLabel = New System.Windows.Forms.Label()
        QtyminonhandLabel = New System.Windows.Forms.Label()
        ReorderqtyLabel = New System.Windows.Forms.Label()
        FireLabel = New System.Windows.Forms.Label()
        HealthLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        UnlineLabel1 = New System.Windows.Forms.Label()
        VolumeunitsLabel = New System.Windows.Forms.Label()
        VolumeuomLabel = New System.Windows.Forms.Label()
        WeightunitsLabel = New System.Windows.Forms.Label()
        WeightuomLabel = New System.Windows.Forms.Label()
        IsactiveLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        InventorymethodLabel = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        RqLabel = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContainers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLblGallons.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLblWeight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eClassRate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eDOTDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eHazmatDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eUNLine.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eHazmatID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsHazmat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eReactivity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ePersonalProtection.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMinimumOnHand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eReorderQty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eFire.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eHealth.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eAddnDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.luCustomers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLblUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eLblUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.eChemName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eChemID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMaterialDesc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eRQ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eMatID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.bsChemicalList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductStatusCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.CheckEditOverride.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eStdCostSource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWgtCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVolCost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWgtUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eWgtUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVolUOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVolUnits.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.ePkgGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPkgGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eHazMatClassNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eIDNumber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eInvMethod.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eReceivingNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.eVendorNotes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductidLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(ProductidLabel, DevExpress.Utils.DefaultBoolean.[Default])
        ProductidLabel.AutoSize = True
        ProductidLabel.Location = New System.Drawing.Point(45, 33)
        ProductidLabel.Name = "ProductidLabel"
        ProductidLabel.Size = New System.Drawing.Size(58, 13)
        ProductidLabel.TabIndex = 0
        ProductidLabel.Text = "Product ID"
        '
        'ProductdescLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(ProductdescLabel, DevExpress.Utils.DefaultBoolean.[Default])
        ProductdescLabel.AutoSize = True
        ProductdescLabel.Location = New System.Drawing.Point(45, 63)
        ProductdescLabel.Name = "ProductdescLabel"
        ProductdescLabel.Size = New System.Drawing.Size(60, 13)
        ProductdescLabel.TabIndex = 2
        ProductdescLabel.Text = "Description"
        '
        'ContainerLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(ContainerLabel, DevExpress.Utils.DefaultBoolean.[Default])
        ContainerLabel.AutoSize = True
        ContainerLabel.Location = New System.Drawing.Point(51, 112)
        ContainerLabel.Name = "ContainerLabel"
        ContainerLabel.Size = New System.Drawing.Size(54, 13)
        ContainerLabel.TabIndex = 6
        ContainerLabel.Text = "Container"
        '
        'StdgallonsLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(StdgallonsLabel, DevExpress.Utils.DefaultBoolean.[Default])
        StdgallonsLabel.AutoSize = True
        StdgallonsLabel.Location = New System.Drawing.Point(21, 33)
        StdgallonsLabel.Name = "StdgallonsLabel"
        StdgallonsLabel.Size = New System.Drawing.Size(69, 13)
        StdgallonsLabel.TabIndex = 0
        StdgallonsLabel.Text = "Label Gallons"
        StdgallonsLabel.Visible = False
        '
        'StdweightLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(StdweightLabel, DevExpress.Utils.DefaultBoolean.[Default])
        StdweightLabel.AutoSize = True
        StdweightLabel.Location = New System.Drawing.Point(22, 31)
        StdweightLabel.Name = "StdweightLabel"
        StdweightLabel.Size = New System.Drawing.Size(69, 13)
        StdweightLabel.TabIndex = 2
        StdweightLabel.Text = "Label Weight"
        '
        'ClassrateLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(ClassrateLabel, DevExpress.Utils.DefaultBoolean.[Default])
        ClassrateLabel.AutoSize = True
        ClassrateLabel.Location = New System.Drawing.Point(311, 112)
        ClassrateLabel.Name = "ClassrateLabel"
        ClassrateLabel.Size = New System.Drawing.Size(58, 13)
        ClassrateLabel.TabIndex = 10
        ClassrateLabel.Text = "Class Rate"
        '
        'DotdescLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(DotdescLabel, DevExpress.Utils.DefaultBoolean.[Default])
        DotdescLabel.AutoSize = True
        DotdescLabel.Location = New System.Drawing.Point(21, 112)
        DotdescLabel.Name = "DotdescLabel"
        DotdescLabel.Size = New System.Drawing.Size(84, 13)
        DotdescLabel.TabIndex = 12
        DotdescLabel.Text = "DOT Description"
        '
        'HazmatdescLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(HazmatdescLabel, DevExpress.Utils.DefaultBoolean.[Default])
        HazmatdescLabel.AutoSize = True
        HazmatdescLabel.Location = New System.Drawing.Point(6, 138)
        HazmatdescLabel.Name = "HazmatdescLabel"
        HazmatdescLabel.Size = New System.Drawing.Size(99, 13)
        HazmatdescLabel.TabIndex = 14
        HazmatdescLabel.Text = "Hazmat Description"
        '
        'UnlineLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(UnlineLabel, DevExpress.Utils.DefaultBoolean.[Default])
        UnlineLabel.AutoSize = True
        UnlineLabel.Location = New System.Drawing.Point(62, 164)
        UnlineLabel.Name = "UnlineLabel"
        UnlineLabel.Size = New System.Drawing.Size(43, 13)
        UnlineLabel.TabIndex = 16
        UnlineLabel.Text = "UN Line"
        '
        'HazmatidLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(HazmatidLabel, DevExpress.Utils.DefaultBoolean.[Default])
        HazmatidLabel.AutoSize = True
        HazmatidLabel.Location = New System.Drawing.Point(48, 86)
        HazmatidLabel.Name = "HazmatidLabel"
        HazmatidLabel.Size = New System.Drawing.Size(57, 13)
        HazmatidLabel.TabIndex = 4
        HazmatidLabel.Text = "Hazmat ID"
        '
        'ReactivityLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(ReactivityLabel, DevExpress.Utils.DefaultBoolean.[Default])
        ReactivityLabel.AutoSize = True
        ReactivityLabel.Location = New System.Drawing.Point(335, 34)
        ReactivityLabel.Name = "ReactivityLabel"
        ReactivityLabel.Size = New System.Drawing.Size(55, 13)
        ReactivityLabel.TabIndex = 6
        ReactivityLabel.Text = "Reactivity"
        '
        'PersonalprotectionLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(PersonalprotectionLabel, DevExpress.Utils.DefaultBoolean.[Default])
        PersonalprotectionLabel.AutoSize = True
        PersonalprotectionLabel.Location = New System.Drawing.Point(290, 60)
        PersonalprotectionLabel.Name = "PersonalprotectionLabel"
        PersonalprotectionLabel.Size = New System.Drawing.Size(100, 13)
        PersonalprotectionLabel.TabIndex = 8
        PersonalprotectionLabel.Text = "Personal Protection"
        '
        'QtyminonhandLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(QtyminonhandLabel, DevExpress.Utils.DefaultBoolean.[Default])
        QtyminonhandLabel.AutoSize = True
        QtyminonhandLabel.Location = New System.Drawing.Point(246, 60)
        QtyminonhandLabel.Name = "QtyminonhandLabel"
        QtyminonhandLabel.Size = New System.Drawing.Size(92, 13)
        QtyminonhandLabel.TabIndex = 6
        QtyminonhandLabel.Text = "Minimum On Hand"
        '
        'ReorderqtyLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(ReorderqtyLabel, DevExpress.Utils.DefaultBoolean.[Default])
        ReorderqtyLabel.AutoSize = True
        ReorderqtyLabel.Location = New System.Drawing.Point(271, 34)
        ReorderqtyLabel.Name = "ReorderqtyLabel"
        ReorderqtyLabel.Size = New System.Drawing.Size(67, 13)
        ReorderqtyLabel.TabIndex = 4
        ReorderqtyLabel.Text = "Reorder Qty"
        '
        'FireLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(FireLabel, DevExpress.Utils.DefaultBoolean.[Default])
        FireLabel.AutoSize = True
        FireLabel.Location = New System.Drawing.Point(80, 60)
        FireLabel.Name = "FireLabel"
        FireLabel.Size = New System.Drawing.Size(25, 13)
        FireLabel.TabIndex = 2
        FireLabel.Text = "Fire"
        '
        'HealthLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(HealthLabel, DevExpress.Utils.DefaultBoolean.[Default])
        HealthLabel.AutoSize = True
        HealthLabel.Location = New System.Drawing.Point(67, 34)
        HealthLabel.Name = "HealthLabel"
        HealthLabel.Size = New System.Drawing.Size(38, 13)
        HealthLabel.TabIndex = 0
        HealthLabel.Text = "Health"
        '
        'Label1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label1, DevExpress.Utils.DefaultBoolean.[Default])
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(25, 87)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(80, 13)
        Label1.TabIndex = 4
        Label1.Text = "Additional Desc"
        '
        'Label5
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label5, DevExpress.Utils.DefaultBoolean.[Default])
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(21, 112)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(102, 13)
        Label5.TabIndex = 9
        Label5.Text = "Limited to Customer"
        '
        'Label3
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label3, DevExpress.Utils.DefaultBoolean.[Default])
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(255, 59)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(45, 13)
        Label3.TabIndex = 6
        Label3.Text = "Fill UOM"
        '
        'Label4
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label4, DevExpress.Utils.DefaultBoolean.[Default])
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(255, 33)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(46, 13)
        Label4.TabIndex = 4
        Label4.Text = "Fill Units"
        '
        'Label6
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label6, DevExpress.Utils.DefaultBoolean.[Default])
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(21, 60)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(101, 13)
        Label6.TabIndex = 2
        Label6.Text = "Inventory Grouping"
        '
        'UnlineLabel1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(UnlineLabel1, DevExpress.Utils.DefaultBoolean.[Default])
        UnlineLabel1.AutoSize = True
        UnlineLabel1.Location = New System.Drawing.Point(47, 190)
        UnlineLabel1.Name = "UnlineLabel1"
        UnlineLabel1.Size = New System.Drawing.Size(58, 13)
        UnlineLabel1.TabIndex = 18
        UnlineLabel1.Text = "ID Number"
        '
        'VolumeunitsLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(VolumeunitsLabel, DevExpress.Utils.DefaultBoolean.[Default])
        VolumeunitsLabel.AutoSize = True
        VolumeunitsLabel.Location = New System.Drawing.Point(20, 141)
        VolumeunitsLabel.Name = "VolumeunitsLabel"
        VolumeunitsLabel.Size = New System.Drawing.Size(92, 13)
        VolumeunitsLabel.TabIndex = 9
        VolumeunitsLabel.Text = "Units in Container"
        '
        'VolumeuomLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(VolumeuomLabel, DevExpress.Utils.DefaultBoolean.[Default])
        VolumeuomLabel.AutoSize = True
        VolumeuomLabel.Location = New System.Drawing.Point(20, 166)
        VolumeuomLabel.Name = "VolumeuomLabel"
        VolumeuomLabel.Size = New System.Drawing.Size(30, 13)
        VolumeuomLabel.TabIndex = 11
        VolumeuomLabel.Text = "UOM"
        '
        'WeightunitsLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(WeightunitsLabel, DevExpress.Utils.DefaultBoolean.[Default])
        WeightunitsLabel.AutoSize = True
        WeightunitsLabel.Location = New System.Drawing.Point(254, 142)
        WeightunitsLabel.Name = "WeightunitsLabel"
        WeightunitsLabel.Size = New System.Drawing.Size(92, 13)
        WeightunitsLabel.TabIndex = 17
        WeightunitsLabel.Text = "Units in Container"
        '
        'WeightuomLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(WeightuomLabel, DevExpress.Utils.DefaultBoolean.[Default])
        WeightuomLabel.AutoSize = True
        WeightuomLabel.Location = New System.Drawing.Point(254, 167)
        WeightuomLabel.Name = "WeightuomLabel"
        WeightuomLabel.Size = New System.Drawing.Size(30, 13)
        WeightuomLabel.TabIndex = 19
        WeightuomLabel.Text = "UOM"
        '
        'IsactiveLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(IsactiveLabel, DevExpress.Utils.DefaultBoolean.[Default])
        IsactiveLabel.AutoSize = True
        IsactiveLabel.Location = New System.Drawing.Point(393, 33)
        IsactiveLabel.Name = "IsactiveLabel"
        IsactiveLabel.Size = New System.Drawing.Size(37, 13)
        IsactiveLabel.TabIndex = 8
        IsactiveLabel.Text = "Active"
        '
        'Label2
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label2, DevExpress.Utils.DefaultBoolean.[Default])
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(180, 190)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(64, 13)
        Label2.TabIndex = 20
        Label2.Text = "Haz Class #"
        '
        'Label7
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label7, DevExpress.Utils.DefaultBoolean.[Default])
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(311, 190)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(79, 13)
        Label7.TabIndex = 22
        Label7.Text = "Package Group"
        '
        'Label8
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label8, DevExpress.Utils.DefaultBoolean.[Default])
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label8.Location = New System.Drawing.Point(80, 118)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(69, 13)
        Label8.TabIndex = 8
        Label8.Text = "BY VOLUME"
        '
        'Label9
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label9, DevExpress.Utils.DefaultBoolean.[Default])
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Label9.Location = New System.Drawing.Point(304, 118)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(69, 13)
        Label9.TabIndex = 16
        Label9.Text = "BY WEIGHT"
        '
        'Label10
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label10, DevExpress.Utils.DefaultBoolean.[Default])
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(20, 193)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(48, 13)
        Label10.TabIndex = 13
        Label10.Text = "Std Cost"
        '
        'Label11
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label11, DevExpress.Utils.DefaultBoolean.[Default])
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(254, 193)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(48, 13)
        Label11.TabIndex = 21
        Label11.Text = "Std Cost"
        '
        'Label12
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label12, DevExpress.Utils.DefaultBoolean.[Default])
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(332, 33)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(38, 13)
        Label12.TabIndex = 25
        Label12.Text = "Status"
        '
        'Label13
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label13, DevExpress.Utils.DefaultBoolean.[Default])
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(33, 141)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(72, 13)
        Label13.TabIndex = 29
        Label13.Text = "Chemical Info"
        '
        'InventorymethodLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(InventorymethodLabel, DevExpress.Utils.DefaultBoolean.[Default])
        InventorymethodLabel.AutoSize = True
        InventorymethodLabel.Location = New System.Drawing.Point(21, 34)
        InventorymethodLabel.Name = "InventorymethodLabel"
        InventorymethodLabel.Size = New System.Drawing.Size(94, 13)
        InventorymethodLabel.TabIndex = 0
        InventorymethodLabel.Text = "Inventory Method"
        '
        'Label14
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label14, DevExpress.Utils.DefaultBoolean.[Default])
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(39, 167)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(66, 13)
        Label14.TabIndex = 31
        Label14.Text = "Material Link"
        '
        'Label15
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label15, DevExpress.Utils.DefaultBoolean.[Default])
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(6, 31)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(72, 13)
        Label15.TabIndex = 19
        Label15.Text = "Vendor Notes"
        '
        'Label16
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label16, DevExpress.Utils.DefaultBoolean.[Default])
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(325, 31)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(84, 13)
        Label16.TabIndex = 20
        Label16.Text = "Receiving Notes"
        AddHandler Label16.Click, AddressOf Me.Label16_Click
        '
        'RqLabel
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(RqLabel, DevExpress.Utils.DefaultBoolean.[Default])
        RqLabel.AutoSize = True
        RqLabel.Location = New System.Drawing.Point(250, 113)
        RqLabel.Name = "RqLabel"
        RqLabel.Size = New System.Drawing.Size(22, 13)
        RqLabel.TabIndex = 23
        RqLabel.Text = "RQ"
        '
        'Label17
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label17, DevExpress.Utils.DefaultBoolean.[Default])
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(76, 86)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(46, 13)
        Label17.TabIndex = 25
        Label17.Text = "Is Liquid"
        '
        'Label18
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label18, DevExpress.Utils.DefaultBoolean.[Default])
        Label18.AutoSize = True
        Label18.Location = New System.Drawing.Point(637, 31)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(107, 13)
        Label18.TabIndex = 22
        Label18.Text = "Standard Cost Notes"
        '
        'Label19
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label19, DevExpress.Utils.DefaultBoolean.[Default])
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(261, 86)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(77, 13)
        Label19.TabIndex = 27
        Label19.Text = "Bulk Inventory"
        '
        'Label20
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Label20, DevExpress.Utils.DefaultBoolean.[Default])
        Label20.AutoSize = True
        Label20.Location = New System.Drawing.Point(45, 63)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(49, 13)
        Label20.TabIndex = 27
        Label20.Text = "Override"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'eProductID
        '
        Me.eProductID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Productid", True))
        Me.eProductID.Location = New System.Drawing.Point(111, 30)
        Me.eProductID.Name = "eProductID"
        Me.eProductID.Properties.ReadOnly = True
        Me.eProductID.Size = New System.Drawing.Size(51, 20)
        Me.eProductID.TabIndex = 1
        Me.eProductID.TabStop = False
        '
        'bs
        '
        Me.bs.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'eProductDesc
        '
        Me.eProductDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Productdesc", True))
        Me.eProductDesc.Location = New System.Drawing.Point(111, 58)
        Me.eProductDesc.Name = "eProductDesc"
        Me.eProductDesc.Size = New System.Drawing.Size(336, 20)
        Me.eProductDesc.TabIndex = 3
        '
        'eContainer
        '
        Me.eContainer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Container", True))
        Me.eContainer.Location = New System.Drawing.Point(111, 109)
        Me.eContainer.Name = "eContainer"
        Me.eContainer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eContainer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Container", "Container", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "Unit of Measure", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Center), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Units", "Units", 30, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eContainer.Properties.DataSource = Me.bsContainers
        Me.eContainer.Properties.DisplayMember = "Container"
        Me.eContainer.Properties.NullText = ""
        Me.eContainer.Properties.PopupWidth = 200
        Me.eContainer.Properties.ShowFooter = False
        Me.eContainer.Properties.ValueMember = "Container"
        Me.eContainer.Size = New System.Drawing.Size(84, 20)
        Me.eContainer.TabIndex = 7
        '
        'bsContainers
        '
        Me.bsContainers.DataSource = GetType(AOS.BusinessObjects.ContainerCollection)
        '
        'eLblGallons
        '
        Me.eLblGallons.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Stdgallons", True))
        Me.eLblGallons.Location = New System.Drawing.Point(128, 30)
        Me.eLblGallons.Name = "eLblGallons"
        Me.eLblGallons.Properties.Mask.EditMask = "n"
        Me.eLblGallons.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eLblGallons.Size = New System.Drawing.Size(64, 20)
        Me.eLblGallons.TabIndex = 1
        Me.eLblGallons.Visible = False
        '
        'eLblWeight
        '
        Me.eLblWeight.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Stdweight", True))
        Me.eLblWeight.Location = New System.Drawing.Point(129, 30)
        Me.eLblWeight.Name = "eLblWeight"
        Me.eLblWeight.Properties.Mask.EditMask = "n"
        Me.eLblWeight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eLblWeight.Size = New System.Drawing.Size(64, 20)
        Me.eLblWeight.TabIndex = 3
        '
        'eClassRate
        '
        Me.eClassRate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Classrate", True))
        Me.eClassRate.Location = New System.Drawing.Point(376, 109)
        Me.eClassRate.Name = "eClassRate"
        Me.eClassRate.Size = New System.Drawing.Size(71, 20)
        Me.eClassRate.TabIndex = 11
        '
        'eDOTDesc
        '
        Me.eDOTDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Dotdesc", True))
        Me.eDOTDesc.Location = New System.Drawing.Point(111, 109)
        Me.eDOTDesc.Name = "eDOTDesc"
        Me.eDOTDesc.Size = New System.Drawing.Size(336, 20)
        Me.eDOTDesc.TabIndex = 13
        '
        'eHazmatDesc
        '
        Me.eHazmatDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Hazmatdesc", True))
        Me.eHazmatDesc.Location = New System.Drawing.Point(111, 135)
        Me.eHazmatDesc.Name = "eHazmatDesc"
        Me.eHazmatDesc.Size = New System.Drawing.Size(336, 20)
        Me.eHazmatDesc.TabIndex = 15
        '
        'eUNLine
        '
        Me.eUNLine.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Unline", True))
        Me.eUNLine.Location = New System.Drawing.Point(111, 161)
        Me.eUNLine.Name = "eUNLine"
        Me.eUNLine.Size = New System.Drawing.Size(336, 20)
        Me.eUNLine.TabIndex = 17
        '
        'eHazmatID
        '
        Me.eHazmatID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Hazmatid", True))
        Me.eHazmatID.Location = New System.Drawing.Point(111, 83)
        Me.eHazmatID.Name = "eHazmatID"
        Me.eHazmatID.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eHazmatID.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HazMatID", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("SymbolDesc", "Symbol Description", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eHazmatID.Properties.DataSource = Me.bsHazmat
        Me.eHazmatID.Properties.DisplayMember = "SymbolDesc"
        Me.eHazmatID.Properties.NullText = ""
        Me.eHazmatID.Properties.ValueMember = "HazMatID"
        Me.eHazmatID.Size = New System.Drawing.Size(145, 20)
        Me.eHazmatID.TabIndex = 5
        '
        'bsHazmat
        '
        Me.bsHazmat.DataSource = GetType(AOS.BusinessObjects.HazmatsymbolCollection)
        '
        'eReactivity
        '
        Me.eReactivity.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Reactivity", True))
        Me.eReactivity.Location = New System.Drawing.Point(396, 31)
        Me.eReactivity.Name = "eReactivity"
        Me.eReactivity.Size = New System.Drawing.Size(51, 20)
        Me.eReactivity.TabIndex = 7
        '
        'ePersonalProtection
        '
        Me.ePersonalProtection.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Personalprotection", True))
        Me.ePersonalProtection.Location = New System.Drawing.Point(396, 57)
        Me.ePersonalProtection.Name = "ePersonalProtection"
        Me.ePersonalProtection.Size = New System.Drawing.Size(51, 20)
        Me.ePersonalProtection.TabIndex = 9
        '
        'eMinimumOnHand
        '
        Me.eMinimumOnHand.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Qtyminonhand", True))
        Me.eMinimumOnHand.Location = New System.Drawing.Point(352, 57)
        Me.eMinimumOnHand.Name = "eMinimumOnHand"
        Me.eMinimumOnHand.Size = New System.Drawing.Size(64, 20)
        Me.eMinimumOnHand.TabIndex = 7
        '
        'eReorderQty
        '
        Me.eReorderQty.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Reorderqty", True))
        Me.eReorderQty.Location = New System.Drawing.Point(352, 31)
        Me.eReorderQty.Name = "eReorderQty"
        Me.eReorderQty.Size = New System.Drawing.Size(64, 20)
        Me.eReorderQty.TabIndex = 5
        '
        'eFire
        '
        Me.eFire.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Fire", True))
        Me.eFire.Location = New System.Drawing.Point(111, 57)
        Me.eFire.Name = "eFire"
        Me.eFire.Size = New System.Drawing.Size(51, 20)
        Me.eFire.TabIndex = 3
        '
        'eHealth
        '
        Me.eHealth.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Health", True))
        Me.eHealth.Location = New System.Drawing.Point(111, 31)
        Me.eHealth.Name = "eHealth"
        Me.eHealth.Size = New System.Drawing.Size(51, 20)
        Me.eHealth.TabIndex = 1
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ApplicationButtonText = Nothing
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnSave, Me.btnCancel, Me.btnViewProductCost, Me.btnProductFulfillment, Me.rbtnChangeProductStatus, Me.rbtnViewPrintSDSDocument, Me.rbtnAssignChemical, Me.rbtnChangeStandardCosts, Me.rbtnProductSales, Me.rbtnProductPurchases, Me.rbtnProductApisCosts})
        Me.RibbonControl1.LargeImages = Me.LargeRibbonImages
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 31
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemWeekOfMonth1, Me.RepositoryItemAppointmentLabel1})
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(922, 116)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnSave
        '
        Me.btnSave.Caption = "Save  Changes"
        Me.btnSave.Id = 4
        Me.btnSave.ImageOptions.LargeImageIndex = 5
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnCancel
        '
        Me.btnCancel.Caption = "Cancel Changes"
        Me.btnCancel.Id = 5
        Me.btnCancel.ImageOptions.LargeImageIndex = 6
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
        '
        'btnViewProductCost
        '
        Me.btnViewProductCost.Caption = "Product Cost Records"
        Me.btnViewProductCost.Id = 22
        Me.btnViewProductCost.ImageOptions.LargeImageIndex = 8
        Me.btnViewProductCost.Name = "btnViewProductCost"
        '
        'btnProductFulfillment
        '
        Me.btnProductFulfillment.Caption = "Product Fulfillment Plan"
        Me.btnProductFulfillment.Id = 25
        Me.btnProductFulfillment.ImageOptions.LargeImageIndex = 10
        Me.btnProductFulfillment.Name = "btnProductFulfillment"
        Me.btnProductFulfillment.Tag = "0"
        '
        'rbtnChangeProductStatus
        '
        Me.rbtnChangeProductStatus.Caption = "Change Product Status"
        Me.rbtnChangeProductStatus.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnChangeProductStatus.Id = 24
        Me.rbtnChangeProductStatus.ImageOptions.LargeImageIndex = 10
        Me.rbtnChangeProductStatus.Name = "rbtnChangeProductStatus"
        '
        'rbtnViewPrintSDSDocument
        '
        Me.rbtnViewPrintSDSDocument.Caption = "View / Print SDS Document"
        Me.rbtnViewPrintSDSDocument.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
        Me.rbtnViewPrintSDSDocument.Id = 25
        Me.rbtnViewPrintSDSDocument.ImageOptions.LargeImageIndex = 7
        Me.rbtnViewPrintSDSDocument.Name = "rbtnViewPrintSDSDocument"
        '
        'rbtnAssignChemical
        '
        Me.rbtnAssignChemical.Caption = "Assign Chemical Link"
        Me.rbtnAssignChemical.Id = 26
        Me.rbtnAssignChemical.ImageOptions.LargeImageIndex = 10
        Me.rbtnAssignChemical.Name = "rbtnAssignChemical"
        '
        'rbtnChangeStandardCosts
        '
        Me.rbtnChangeStandardCosts.Caption = "Edit Product Standard Costs"
        Me.rbtnChangeStandardCosts.Id = 27
        Me.rbtnChangeStandardCosts.ImageOptions.LargeImageIndex = 12
        Me.rbtnChangeStandardCosts.Name = "rbtnChangeStandardCosts"
        '
        'rbtnProductSales
        '
        Me.rbtnProductSales.Caption = "Product Sales"
        Me.rbtnProductSales.Id = 28
        Me.rbtnProductSales.ImageOptions.LargeImageIndex = 8
        Me.rbtnProductSales.Name = "rbtnProductSales"
        '
        'rbtnProductPurchases
        '
        Me.rbtnProductPurchases.Caption = "Product Purchases"
        Me.rbtnProductPurchases.Id = 29
        Me.rbtnProductPurchases.ImageOptions.LargeImageIndex = 8
        Me.rbtnProductPurchases.Name = "rbtnProductPurchases"
        '
        'rbtnProductApisCosts
        '
        Me.rbtnProductApisCosts.Caption = "APIS Standard Costs"
        Me.rbtnProductApisCosts.Enabled = False
        Me.rbtnProductApisCosts.Id = 30
        Me.rbtnProductApisCosts.ImageOptions.LargeImageIndex = 22
        Me.rbtnProductApisCosts.Name = "rbtnProductApisCosts"
        '
        'LargeRibbonImages
        '
        Me.LargeRibbonImages.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeRibbonImages.ImageStream = CType(resources.GetObject("LargeRibbonImages.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2, Me.RibbonPageGroup4, Me.RibbonPageGroup1, Me.RibbonPageGroup3, Me.rpgHistory})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.AllowMinimize = False
        Me.RibbonPageGroup2.AllowTextClipping = False
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnSave)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.btnCancel)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.ShowCaptionButton = False
        Me.RibbonPageGroup2.Text = "Product"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.AllowMinimize = False
        Me.RibbonPageGroup4.AllowTextClipping = False
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnAssignChemical)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.rbtnChangeProductStatus, True)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.btnProductFulfillment, True)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.ShowCaptionButton = False
        Me.RibbonPageGroup4.Text = "Settings"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.AllowMinimize = False
        Me.RibbonPageGroup1.AllowTextClipping = False
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnViewProductCost)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnProductApisCosts)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.rbtnChangeStandardCosts)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.ShowCaptionButton = False
        Me.RibbonPageGroup1.Tag = "8"
        Me.RibbonPageGroup1.Text = "Costing"
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.AllowMinimize = False
        Me.RibbonPageGroup3.AllowTextClipping = False
        Me.RibbonPageGroup3.ItemLinks.Add(Me.rbtnViewPrintSDSDocument)
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.ShowCaptionButton = False
        Me.RibbonPageGroup3.Text = "Reports"
        '
        'rpgHistory
        '
        Me.rpgHistory.ItemLinks.Add(Me.rbtnProductSales)
        Me.rpgHistory.ItemLinks.Add(Me.rbtnProductPurchases)
        Me.rpgHistory.Name = "rpgHistory"
        Me.rpgHistory.Text = "History"
        '
        'RepositoryItemWeekOfMonth1
        '
        Me.RepositoryItemWeekOfMonth1.AutoHeight = False
        Me.RepositoryItemWeekOfMonth1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemWeekOfMonth1.Name = "RepositoryItemWeekOfMonth1"
        '
        'RepositoryItemAppointmentLabel1
        '
        Me.RepositoryItemAppointmentLabel1.AutoHeight = False
        Me.RepositoryItemAppointmentLabel1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemAppointmentLabel1.Name = "RepositoryItemAppointmentLabel1"
        '
        'eAddnDesc
        '
        Me.eAddnDesc.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Desc2", True))
        Me.eAddnDesc.Location = New System.Drawing.Point(111, 84)
        Me.eAddnDesc.Name = "eAddnDesc"
        Me.eAddnDesc.Size = New System.Drawing.Size(336, 20)
        Me.eAddnDesc.TabIndex = 5
        '
        'bsInventoryClass
        '
        Me.bsInventoryClass.DataSource = GetType(AOS.BusinessObjects.ListInventoryclassCollection)
        '
        'bsCustomers
        '
        Me.bsCustomers.DataSource = GetType(AOS.BusinessObjects.CustomerCollection)
        '
        'luCustomers
        '
        Me.luCustomers.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Custid", True))
        Me.luCustomers.Location = New System.Drawing.Point(129, 109)
        Me.luCustomers.Name = "luCustomers"
        Me.luCustomers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.luCustomers.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custid", "ID", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custname", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custbillcity", "City", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Custbillstateprov", "St", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.luCustomers.Properties.DataSource = Me.bsCustomers
        Me.luCustomers.Properties.DisplayMember = "Custname"
        Me.luCustomers.Properties.DropDownRows = 10
        Me.luCustomers.Properties.NullText = ""
        Me.luCustomers.Properties.PopupFormMinSize = New System.Drawing.Size(100, 0)
        Me.luCustomers.Properties.PopupWidth = 336
        Me.luCustomers.Properties.ShowFooter = False
        Me.luCustomers.Properties.ShowLines = False
        Me.luCustomers.Properties.ValueMember = "Custid"
        Me.luCustomers.Size = New System.Drawing.Size(287, 20)
        Me.luCustomers.TabIndex = 10
        '
        'eLblUOM
        '
        Me.eLblUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Uom", True))
        Me.eLblUOM.Location = New System.Drawing.Point(352, 56)
        Me.eLblUOM.Name = "eLblUOM"
        Me.eLblUOM.Size = New System.Drawing.Size(64, 20)
        Me.eLblUOM.TabIndex = 7
        '
        'eLblUnits
        '
        Me.eLblUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Units", True))
        Me.eLblUnits.Location = New System.Drawing.Point(352, 28)
        Me.eLblUnits.Name = "eLblUnits"
        Me.eLblUnits.Properties.Mask.EditMask = "n"
        Me.eLblUnits.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eLblUnits.Size = New System.Drawing.Size(64, 20)
        Me.eLblUnits.TabIndex = 5
        '
        'eInvGroup
        '
        Me.eInvGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Inventorygrouping", True))
        Me.eInvGroup.Location = New System.Drawing.Point(129, 57)
        Me.eInvGroup.Name = "eInvGroup"
        Me.eInvGroup.Size = New System.Drawing.Size(64, 20)
        Me.eInvGroup.TabIndex = 3
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.eChemName)
        Me.GroupControl1.Controls.Add(Me.eChemID)
        Me.GroupControl1.Controls.Add(RqLabel)
        Me.GroupControl1.Controls.Add(Me.eMaterialDesc)
        Me.GroupControl1.Controls.Add(Me.eRQ)
        Me.GroupControl1.Controls.Add(Me.eMatID)
        Me.GroupControl1.Controls.Add(Label14)
        Me.GroupControl1.Controls.Add(Me.eStatus)
        Me.GroupControl1.Controls.Add(Label13)
        Me.GroupControl1.Controls.Add(Label12)
        Me.GroupControl1.Controls.Add(IsactiveLabel)
        Me.GroupControl1.Controls.Add(Me.IsactiveCheckEdit)
        Me.GroupControl1.Controls.Add(Me.eClassRate)
        Me.GroupControl1.Controls.Add(ClassrateLabel)
        Me.GroupControl1.Controls.Add(Me.eContainer)
        Me.GroupControl1.Controls.Add(Me.eProductID)
        Me.GroupControl1.Controls.Add(ProductidLabel)
        Me.GroupControl1.Controls.Add(Me.eProductDesc)
        Me.GroupControl1.Controls.Add(ProductdescLabel)
        Me.GroupControl1.Controls.Add(ContainerLabel)
        Me.GroupControl1.Controls.Add(Me.eAddnDesc)
        Me.GroupControl1.Controls.Add(Label1)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 101)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(463, 230)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Product Information"
        Me.GroupControl1.ToolTipController = Me.DefaultToolTipController1.DefaultController
        '
        'eChemName
        '
        Me.eChemName.Location = New System.Drawing.Point(200, 138)
        Me.eChemName.Name = "eChemName"
        Me.eChemName.Properties.ReadOnly = True
        Me.eChemName.Size = New System.Drawing.Size(247, 20)
        Me.eChemName.TabIndex = 35
        '
        'eChemID
        '
        Me.eChemID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Chemicalid", True))
        Me.eChemID.Location = New System.Drawing.Point(111, 138)
        Me.eChemID.Name = "eChemID"
        Me.eChemID.Properties.ReadOnly = True
        Me.eChemID.Size = New System.Drawing.Size(84, 20)
        Me.eChemID.TabIndex = 34
        Me.eChemID.TabStop = False
        '
        'eMaterialDesc
        '
        Me.eMaterialDesc.Location = New System.Drawing.Point(200, 164)
        Me.eMaterialDesc.Name = "eMaterialDesc"
        Me.eMaterialDesc.Properties.ReadOnly = True
        Me.eMaterialDesc.Size = New System.Drawing.Size(247, 20)
        Me.eMaterialDesc.TabIndex = 33
        '
        'eRQ
        '
        Me.eRQ.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Rq", True))
        Me.eRQ.Location = New System.Drawing.Point(278, 110)
        Me.eRQ.MenuManager = Me.RibbonControl1
        Me.eRQ.Name = "eRQ"
        Me.eRQ.Properties.Caption = ""
        Me.eRQ.Size = New System.Drawing.Size(22, 19)
        Me.eRQ.TabIndex = 24
        '
        'eMatID
        '
        Me.eMatID.Location = New System.Drawing.Point(111, 164)
        Me.eMatID.Name = "eMatID"
        Me.eMatID.Properties.ReadOnly = True
        Me.eMatID.Size = New System.Drawing.Size(84, 20)
        Me.eMatID.TabIndex = 32
        Me.eMatID.TabStop = False
        '
        'eStatus
        '
        Me.eStatus.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Productstatus", True))
        Me.eStatus.Location = New System.Drawing.Point(376, 30)
        Me.eStatus.Name = "eStatus"
        Me.eStatus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eStatus.Properties.ReadOnly = True
        Me.eStatus.Size = New System.Drawing.Size(71, 20)
        Me.eStatus.TabIndex = 30
        '
        'IsactiveCheckEdit
        '
        Me.IsactiveCheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Isactive", True))
        Me.IsactiveCheckEdit.Location = New System.Drawing.Point(432, 30)
        Me.IsactiveCheckEdit.MenuManager = Me.RibbonControl1
        Me.IsactiveCheckEdit.Name = "IsactiveCheckEdit"
        Me.IsactiveCheckEdit.Properties.Caption = ""
        Me.IsactiveCheckEdit.Size = New System.Drawing.Size(22, 19)
        Me.IsactiveCheckEdit.TabIndex = 9
        '
        'DefaultToolTipController1
        '
        '
        '
        '
        Me.DefaultToolTipController1.DefaultController.AutoPopDelay = 10000
        '
        'PanelControl1
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me.PanelControl1, DevExpress.Utils.DefaultBoolean.[Default])
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.lblModified)
        Me.PanelControl1.Controls.Add(Me.lblCreated)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 696)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(922, 29)
        Me.PanelControl1.TabIndex = 66
        '
        'lblModified
        '
        Me.lblModified.Appearance.Options.UseTextOptions = True
        Me.lblModified.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblModified.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblModified.Location = New System.Drawing.Point(616, 8)
        Me.lblModified.Name = "lblModified"
        Me.lblModified.Size = New System.Drawing.Size(300, 13)
        Me.lblModified.TabIndex = 1
        Me.lblModified.Text = "Last Modified 12/31/9999 11:59:00 PM by SYSTEM"
        '
        'lblCreated
        '
        Me.lblCreated.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCreated.Location = New System.Drawing.Point(12, 8)
        Me.lblCreated.Name = "lblCreated"
        Me.lblCreated.Size = New System.Drawing.Size(300, 13)
        Me.lblCreated.TabIndex = 0
        Me.lblCreated.Text = "Created 12/31/9999 11:59:00 PM by SYSTEM"
        '
        'bsChemicalList
        '
        Me.bsChemicalList.DataSource = GetType(AOS.BusinessObjects.ChemicalCollection)
        '
        'bsProductStatusCodes
        '
        Me.bsProductStatusCodes.DataSource = GetType(AOS.BusinessObjects.ListProductstatusCollection)
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Label20)
        Me.GroupControl2.Controls.Add(Me.CheckEditOverride)
        Me.GroupControl2.Controls.Add(Me.eStdCostSource)
        Me.GroupControl2.Controls.Add(Label11)
        Me.GroupControl2.Controls.Add(Label10)
        Me.GroupControl2.Controls.Add(Me.eWgtCost)
        Me.GroupControl2.Controls.Add(Me.eVolCost)
        Me.GroupControl2.Controls.Add(Label9)
        Me.GroupControl2.Controls.Add(Label8)
        Me.GroupControl2.Controls.Add(StdweightLabel)
        Me.GroupControl2.Controls.Add(WeightuomLabel)
        Me.GroupControl2.Controls.Add(Me.eLblGallons)
        Me.GroupControl2.Controls.Add(Me.eWgtUOM)
        Me.GroupControl2.Controls.Add(StdgallonsLabel)
        Me.GroupControl2.Controls.Add(WeightunitsLabel)
        Me.GroupControl2.Controls.Add(Label3)
        Me.GroupControl2.Controls.Add(Me.eWgtUnits)
        Me.GroupControl2.Controls.Add(Me.eLblWeight)
        Me.GroupControl2.Controls.Add(VolumeuomLabel)
        Me.GroupControl2.Controls.Add(Me.eLblUOM)
        Me.GroupControl2.Controls.Add(Me.eVolUOM)
        Me.GroupControl2.Controls.Add(Me.eLblUnits)
        Me.GroupControl2.Controls.Add(VolumeunitsLabel)
        Me.GroupControl2.Controls.Add(Label4)
        Me.GroupControl2.Controls.Add(Me.eVolUnits)
        Me.GroupControl2.Location = New System.Drawing.Point(481, 101)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(435, 230)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Physical Specifications / Standard Costing"
        Me.GroupControl2.ToolTipController = Me.DefaultToolTipController1.DefaultController
        '
        'CheckEditOverride
        '
        Me.CheckEditOverride.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Standardcostoverride", True))
        Me.CheckEditOverride.Location = New System.Drawing.Point(127, 60)
        Me.CheckEditOverride.MenuManager = Me.RibbonControl1
        Me.CheckEditOverride.Name = "CheckEditOverride"
        Me.CheckEditOverride.Properties.Caption = ""
        Me.CheckEditOverride.Size = New System.Drawing.Size(22, 19)
        Me.CheckEditOverride.TabIndex = 28
        '
        'eStdCostSource
        '
        Me.eStdCostSource.Location = New System.Drawing.Point(196, 115)
        Me.eStdCostSource.Name = "eStdCostSource"
        Me.eStdCostSource.Properties.Mask.EditMask = "n"
        Me.eStdCostSource.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eStdCostSource.Properties.ReadOnly = True
        Me.eStdCostSource.Size = New System.Drawing.Size(88, 20)
        Me.eStdCostSource.TabIndex = 24
        '
        'eWgtCost
        '
        Me.eWgtCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Weightstandardcost", True))
        Me.eWgtCost.EditValue = ""
        Me.eWgtCost.Location = New System.Drawing.Point(351, 190)
        Me.eWgtCost.MenuManager = Me.RibbonControl1
        Me.eWgtCost.Name = "eWgtCost"
        Me.eWgtCost.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eWgtCost.Properties.Mask.EditMask = "f4"
        Me.eWgtCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eWgtCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.eWgtCost.Properties.MaxLength = 19
        Me.eWgtCost.Properties.ReadOnly = True
        Me.eWgtCost.Size = New System.Drawing.Size(64, 20)
        Me.eWgtCost.TabIndex = 22
        '
        'eVolCost
        '
        Me.eVolCost.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Volumestandardcost", True))
        Me.eVolCost.EditValue = ""
        Me.eVolCost.Location = New System.Drawing.Point(128, 190)
        Me.eVolCost.MenuManager = Me.RibbonControl1
        Me.eVolCost.Name = "eVolCost"
        Me.eVolCost.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eVolCost.Properties.Mask.EditMask = "f4"
        Me.eVolCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eVolCost.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.eVolCost.Properties.MaxLength = 19
        Me.eVolCost.Properties.ReadOnly = True
        Me.eVolCost.Size = New System.Drawing.Size(64, 20)
        Me.eVolCost.TabIndex = 14
        '
        'eWgtUOM
        '
        Me.eWgtUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Weightuom", True))
        Me.eWgtUOM.Location = New System.Drawing.Point(351, 164)
        Me.eWgtUOM.MenuManager = Me.RibbonControl1
        Me.eWgtUOM.Name = "eWgtUOM"
        Me.eWgtUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eWgtUOM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eWgtUOM.Properties.DataSource = Me.bsUOMWeight
        Me.eWgtUOM.Properties.DisplayMember = "Uom"
        Me.eWgtUOM.Properties.NullText = ""
        Me.eWgtUOM.Properties.PopupWidth = 51
        Me.eWgtUOM.Properties.ReadOnly = True
        Me.eWgtUOM.Properties.ShowFooter = False
        Me.eWgtUOM.Properties.ShowHeader = False
        Me.eWgtUOM.Properties.ValueMember = "Uom"
        Me.eWgtUOM.Size = New System.Drawing.Size(64, 20)
        Me.eWgtUOM.TabIndex = 20
        '
        'bsUOMWeight
        '
        Me.bsUOMWeight.DataSource = GetType(AOS.BusinessObjects.ViewUOMByWeightCollection)
        '
        'eWgtUnits
        '
        Me.eWgtUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Weightunits", True))
        Me.eWgtUnits.Location = New System.Drawing.Point(351, 138)
        Me.eWgtUnits.MenuManager = Me.RibbonControl1
        Me.eWgtUnits.Name = "eWgtUnits"
        Me.eWgtUnits.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eWgtUnits.Properties.ReadOnly = True
        Me.eWgtUnits.Size = New System.Drawing.Size(64, 20)
        Me.eWgtUnits.TabIndex = 18
        '
        'eVolUOM
        '
        Me.eVolUOM.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Volumeuom", True))
        Me.eVolUOM.Location = New System.Drawing.Point(128, 164)
        Me.eVolUOM.MenuManager = Me.RibbonControl1
        Me.eVolUOM.Name = "eVolUOM"
        Me.eVolUOM.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eVolUOM.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Uom", "UOM", 51, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.eVolUOM.Properties.DataSource = Me.bsUOMVolume
        Me.eVolUOM.Properties.DisplayMember = "Uom"
        Me.eVolUOM.Properties.NullText = ""
        Me.eVolUOM.Properties.PopupWidth = 51
        Me.eVolUOM.Properties.ReadOnly = True
        Me.eVolUOM.Properties.ShowFooter = False
        Me.eVolUOM.Properties.ShowHeader = False
        Me.eVolUOM.Properties.ValueMember = "Uom"
        Me.eVolUOM.Size = New System.Drawing.Size(64, 20)
        Me.eVolUOM.TabIndex = 12
        '
        'bsUOMVolume
        '
        Me.bsUOMVolume.DataSource = GetType(AOS.BusinessObjects.ViewUOMByVolumeCollection)
        '
        'eVolUnits
        '
        Me.eVolUnits.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Volumeunits", True))
        Me.eVolUnits.EditValue = ""
        Me.eVolUnits.Location = New System.Drawing.Point(128, 138)
        Me.eVolUnits.MenuManager = Me.RibbonControl1
        Me.eVolUnits.Name = "eVolUnits"
        Me.eVolUnits.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
        Me.eVolUnits.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.eVolUnits.Properties.ReadOnly = True
        Me.eVolUnits.Size = New System.Drawing.Size(64, 20)
        Me.eVolUnits.TabIndex = 10
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.ePkgGroup)
        Me.GroupControl3.Controls.Add(Label7)
        Me.GroupControl3.Controls.Add(Label2)
        Me.GroupControl3.Controls.Add(Me.eHazMatClassNumber)
        Me.GroupControl3.Controls.Add(UnlineLabel1)
        Me.GroupControl3.Controls.Add(Me.eIDNumber)
        Me.GroupControl3.Controls.Add(HealthLabel)
        Me.GroupControl3.Controls.Add(Me.eDOTDesc)
        Me.GroupControl3.Controls.Add(DotdescLabel)
        Me.GroupControl3.Controls.Add(Me.eHazmatDesc)
        Me.GroupControl3.Controls.Add(HazmatdescLabel)
        Me.GroupControl3.Controls.Add(Me.eUNLine)
        Me.GroupControl3.Controls.Add(Me.eHealth)
        Me.GroupControl3.Controls.Add(UnlineLabel)
        Me.GroupControl3.Controls.Add(FireLabel)
        Me.GroupControl3.Controls.Add(Me.eHazmatID)
        Me.GroupControl3.Controls.Add(Me.eFire)
        Me.GroupControl3.Controls.Add(HazmatidLabel)
        Me.GroupControl3.Controls.Add(PersonalprotectionLabel)
        Me.GroupControl3.Controls.Add(Me.ePersonalProtection)
        Me.GroupControl3.Controls.Add(ReactivityLabel)
        Me.GroupControl3.Controls.Add(Me.eReactivity)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 337)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(463, 222)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "HazMat Specifications"
        Me.GroupControl3.ToolTipController = Me.DefaultToolTipController1.DefaultController
        '
        'ePkgGroup
        '
        Me.ePkgGroup.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Packagegroup", True))
        Me.ePkgGroup.Location = New System.Drawing.Point(396, 187)
        Me.ePkgGroup.Name = "ePkgGroup"
        Me.ePkgGroup.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ePkgGroup.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PackageGroup", "Pkg Group", 50, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.ePkgGroup.Properties.DataSource = Me.bsPkgGroups
        Me.ePkgGroup.Properties.DisplayMember = "PackageGroup"
        Me.ePkgGroup.Properties.DropDownRows = 4
        Me.ePkgGroup.Properties.NullText = ""
        Me.ePkgGroup.Properties.PopupSizeable = False
        Me.ePkgGroup.Properties.PopupWidth = 51
        Me.ePkgGroup.Properties.ShowFooter = False
        Me.ePkgGroup.Properties.ShowHeader = False
        Me.ePkgGroup.Properties.ValueMember = "PackageGroup"
        Me.ePkgGroup.Size = New System.Drawing.Size(51, 20)
        Me.ePkgGroup.TabIndex = 23
        '
        'bsPkgGroups
        '
        Me.bsPkgGroups.DataSource = GetType(AOS.BusinessObjects.ListPackagegroupCollection)
        '
        'eHazMatClassNumber
        '
        Me.eHazMatClassNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Hazclassnumber", True))
        Me.eHazMatClassNumber.Location = New System.Drawing.Point(250, 187)
        Me.eHazMatClassNumber.MenuManager = Me.RibbonControl1
        Me.eHazMatClassNumber.Name = "eHazMatClassNumber"
        Me.eHazMatClassNumber.Size = New System.Drawing.Size(51, 20)
        Me.eHazMatClassNumber.TabIndex = 21
        '
        'eIDNumber
        '
        Me.eIDNumber.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Idnumber", True))
        Me.eIDNumber.Location = New System.Drawing.Point(111, 187)
        Me.eIDNumber.MenuManager = Me.RibbonControl1
        Me.eIDNumber.Name = "eIDNumber"
        Me.eIDNumber.Size = New System.Drawing.Size(51, 20)
        Me.eIDNumber.TabIndex = 19
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Label19)
        Me.GroupControl4.Controls.Add(Me.CheckEdit2)
        Me.GroupControl4.Controls.Add(Label17)
        Me.GroupControl4.Controls.Add(Me.CheckEdit1)
        Me.GroupControl4.Controls.Add(InventorymethodLabel)
        Me.GroupControl4.Controls.Add(Me.eInvGroup)
        Me.GroupControl4.Controls.Add(Me.eReorderQty)
        Me.GroupControl4.Controls.Add(Label5)
        Me.GroupControl4.Controls.Add(ReorderqtyLabel)
        Me.GroupControl4.Controls.Add(Me.luCustomers)
        Me.GroupControl4.Controls.Add(QtyminonhandLabel)
        Me.GroupControl4.Controls.Add(Label6)
        Me.GroupControl4.Controls.Add(Me.eMinimumOnHand)
        Me.GroupControl4.Controls.Add(Me.eInvMethod)
        Me.GroupControl4.Location = New System.Drawing.Point(481, 337)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(435, 221)
        Me.GroupControl4.TabIndex = 3
        Me.GroupControl4.Text = "Inventory Management"
        Me.GroupControl4.ToolTipController = Me.DefaultToolTipController1.DefaultController
        '
        'CheckEdit2
        '
        Me.CheckEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Bulkinventory", True))
        Me.CheckEdit2.Location = New System.Drawing.Point(353, 83)
        Me.CheckEdit2.MenuManager = Me.RibbonControl1
        Me.CheckEdit2.Name = "CheckEdit2"
        Me.CheckEdit2.Properties.Caption = ""
        Me.CheckEdit2.Size = New System.Drawing.Size(22, 19)
        Me.CheckEdit2.TabIndex = 28
        '
        'CheckEdit1
        '
        Me.CheckEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Isliquid", True))
        Me.CheckEdit1.Location = New System.Drawing.Point(128, 83)
        Me.CheckEdit1.MenuManager = Me.RibbonControl1
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Caption = ""
        Me.CheckEdit1.Size = New System.Drawing.Size(22, 19)
        Me.CheckEdit1.TabIndex = 26
        '
        'eInvMethod
        '
        Me.eInvMethod.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Inventorymethod", True))
        Me.eInvMethod.Location = New System.Drawing.Point(129, 31)
        Me.eInvMethod.MenuManager = Me.RibbonControl1
        Me.eInvMethod.Name = "eInvMethod"
        Me.eInvMethod.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.eInvMethod.Properties.Items.AddRange(New Object() {"WEIGHT", "VOLUME"})
        Me.eInvMethod.Size = New System.Drawing.Size(64, 20)
        Me.eInvMethod.TabIndex = 1
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Label18)
        Me.GroupControl5.Controls.Add(Me.MemoEdit1)
        Me.GroupControl5.Controls.Add(Label16)
        Me.GroupControl5.Controls.Add(Label15)
        Me.GroupControl5.Controls.Add(Me.eReceivingNotes)
        Me.GroupControl5.Controls.Add(Me.eVendorNotes)
        Me.GroupControl5.Location = New System.Drawing.Point(12, 564)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(904, 130)
        Me.GroupControl5.TabIndex = 5
        Me.GroupControl5.Text = "Product Notes"
        Me.GroupControl5.ToolTipController = Me.DefaultToolTipController1.DefaultController
        '
        'MemoEdit1
        '
        Me.MemoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Standardcostnotes", True))
        Me.MemoEdit1.Location = New System.Drawing.Point(640, 51)
        Me.MemoEdit1.MenuManager = Me.RibbonControl1
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(259, 74)
        Me.MemoEdit1.TabIndex = 21
        '
        'eReceivingNotes
        '
        Me.eReceivingNotes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Receivingnotes", True))
        Me.eReceivingNotes.Location = New System.Drawing.Point(328, 51)
        Me.eReceivingNotes.MenuManager = Me.RibbonControl1
        Me.eReceivingNotes.Name = "eReceivingNotes"
        Me.eReceivingNotes.Size = New System.Drawing.Size(306, 74)
        Me.eReceivingNotes.TabIndex = 1
        '
        'eVendorNotes
        '
        Me.eVendorNotes.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.bs, "Purchasingnotes", True))
        Me.eVendorNotes.Location = New System.Drawing.Point(9, 51)
        Me.eVendorNotes.MenuManager = Me.RibbonControl1
        Me.eVendorNotes.Name = "eVendorNotes"
        Me.eVendorNotes.Size = New System.Drawing.Size(313, 74)
        Me.eVendorNotes.TabIndex = 0
        '
        'frmAddEditProduct
        '
        Me.DefaultToolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.[Default])
        Me.ClientSize = New System.Drawing.Size(922, 725)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupControl5)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmAddEditProduct"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Information"
        CType(Me.eProductID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eProductDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eContainer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContainers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLblGallons.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLblWeight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eClassRate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eDOTDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eHazmatDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eUNLine.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eHazmatID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsHazmat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eReactivity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ePersonalProtection.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMinimumOnHand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eReorderQty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eFire.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eHealth.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LargeRibbonImages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemWeekOfMonth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemAppointmentLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eAddnDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsInventoryClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCustomers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.luCustomers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLblUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eLblUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.eChemName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eChemID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMaterialDesc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eRQ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eMatID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IsactiveCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.bsChemicalList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductStatusCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.CheckEditOverride.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eStdCostSource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWgtCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVolCost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWgtUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eWgtUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVolUOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUOMVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVolUnits.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.ePkgGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPkgGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eHazMatClassNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eIDNumber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.CheckEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eInvMethod.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eReceivingNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.eVendorNotes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents eProductID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eProductDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eContainer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eLblGallons As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eLblWeight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eClassRate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eDOTDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eHazmatDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eUNLine As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eHazmatID As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eReactivity As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ePersonalProtection As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eMinimumOnHand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eReorderQty As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eFire As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eHealth As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsContainers As System.Windows.Forms.BindingSource
    Friend WithEvents bsHazmat As System.Windows.Forms.BindingSource
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents btnSave As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnCancel As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eAddnDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsCustomers As System.Windows.Forms.BindingSource
    Friend WithEvents luCustomers As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsInventoryClass As System.Windows.Forms.BindingSource
    Friend WithEvents eLblUOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eLblUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eInvGroup As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eIDNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eWgtUOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsUOMWeight As System.Windows.Forms.BindingSource
    Friend WithEvents eWgtUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eVolUOM As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents bsUOMVolume As System.Windows.Forms.BindingSource
    Friend WithEvents eVolUnits As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eInvMethod As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents IsactiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents RepositoryItemWeekOfMonth1 As DevExpress.XtraScheduler.UI.RepositoryItemWeekOfMonth
    Friend WithEvents RepositoryItemAppointmentLabel1 As DevExpress.XtraScheduler.UI.RepositoryItemAppointmentLabel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents lblModified As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCreated As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnViewProductCost As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents btnProductFulfillment As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents ePkgGroup As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents eHazMatClassNumber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsPkgGroups As System.Windows.Forms.BindingSource
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents eWgtCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eVolCost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents bsProductStatusCodes As System.Windows.Forms.BindingSource
    Friend WithEvents bsChemicalList As System.Windows.Forms.BindingSource
    Friend WithEvents DefaultToolTipController1 As DevExpress.Utils.DefaultToolTipController
    Friend WithEvents rbtnChangeProductStatus As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents LargeRibbonImages As DevExpress.Utils.ImageCollection
    Friend WithEvents eStatus As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eMaterialDesc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eMatID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rbtnViewPrintSDSDocument As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents eReceivingNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents eVendorNotes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents eRQ As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rbtnAssignChemical As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eChemName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents eChemID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rbtnChangeStandardCosts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents CheckEdit2 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents rbtnProductSales As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rbtnProductPurchases As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents rpgHistory As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents rbtnProductApisCosts As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents eStdCostSource As DevExpress.XtraEditors.TextEdit
    Friend WithEvents CheckEditOverride As DevExpress.XtraEditors.CheckEdit
End Class
