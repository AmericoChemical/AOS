<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEditHazmat
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container
        Dim PRODUCTIDLabel As System.Windows.Forms.Label
        Dim PRODUCTDESCLabel As System.Windows.Forms.Label
        Dim STDWEIGHTLabel As System.Windows.Forms.Label
        Dim STDGALLONSLabel As System.Windows.Forms.Label
        Dim CONTAINERLabel As System.Windows.Forms.Label
        Dim HEALTHLabel As System.Windows.Forms.Label
        Dim FIRELabel As System.Windows.Forms.Label
        Dim REACTIVITYLabel As System.Windows.Forms.Label
        Dim PERSONALPROTECTIONLabel As System.Windows.Forms.Label
        Dim DOTDESCLabel As System.Windows.Forms.Label
        Dim HAZMATDESCLabel As System.Windows.Forms.Label
        Dim UNLINELabel As System.Windows.Forms.Label
        Dim PLACARDREQUIREDLabel As System.Windows.Forms.Label
        Dim CLASSRATELabel As System.Windows.Forms.Label
        Dim HAZMATIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEditHazmat))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AlphaGradientPanel1 = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.cboHazmatLabel = New System.Windows.Forms.ComboBox
        Me.mProductBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboContainer = New System.Windows.Forms.ComboBox
        Me.bsContainers = New System.Windows.Forms.BindingSource(Me.components)
        Me.PRODUCTIDTextBox = New System.Windows.Forms.TextBox
        Me.PRODUCTDESCTextBox = New System.Windows.Forms.TextBox
        Me.STDWEIGHTTextBox = New System.Windows.Forms.TextBox
        Me.STDGALLONSTextBox = New System.Windows.Forms.TextBox
        Me.HEALTHTextBox = New System.Windows.Forms.TextBox
        Me.FIRETextBox = New System.Windows.Forms.TextBox
        Me.REACTIVITYTextBox = New System.Windows.Forms.TextBox
        Me.PERSONALPROTECTIONTextBox = New System.Windows.Forms.TextBox
        Me.DOTDESCTextBox = New System.Windows.Forms.TextBox
        Me.HAZMATDESCTextBox = New System.Windows.Forms.TextBox
        Me.UNLINETextBox = New System.Windows.Forms.TextBox
        Me.PLACARDREQUIREDTextBox = New System.Windows.Forms.TextBox
        Me.CLASSRATETextBox = New System.Windows.Forms.TextBox
        Me.btnCancelChanges = New System.Windows.Forms.Button
        Me.btnSaveChanges = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Header = New BlueActivity.Controls.AlphaGradientPanel
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.Label25 = New System.Windows.Forms.Label
        Me.Caption = New System.Windows.Forms.Label
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bsLabels = New System.Windows.Forms.BindingSource(Me.components)
        PRODUCTIDLabel = New System.Windows.Forms.Label
        PRODUCTDESCLabel = New System.Windows.Forms.Label
        STDWEIGHTLabel = New System.Windows.Forms.Label
        STDGALLONSLabel = New System.Windows.Forms.Label
        CONTAINERLabel = New System.Windows.Forms.Label
        HEALTHLabel = New System.Windows.Forms.Label
        FIRELabel = New System.Windows.Forms.Label
        REACTIVITYLabel = New System.Windows.Forms.Label
        PERSONALPROTECTIONLabel = New System.Windows.Forms.Label
        DOTDESCLabel = New System.Windows.Forms.Label
        HAZMATDESCLabel = New System.Windows.Forms.Label
        UNLINELabel = New System.Windows.Forms.Label
        PLACARDREQUIREDLabel = New System.Windows.Forms.Label
        CLASSRATELabel = New System.Windows.Forms.Label
        HAZMATIDLabel = New System.Windows.Forms.Label
        Me.AlphaGradientPanel1.SuspendLayout()
        CType(Me.mProductBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsContainers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header.SuspendLayout()
        CType(Me.bsLabels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PRODUCTIDLabel
        '
        PRODUCTIDLabel.AutoSize = True
        PRODUCTIDLabel.Location = New System.Drawing.Point(19, 44)
        PRODUCTIDLabel.Name = "PRODUCTIDLabel"
        PRODUCTIDLabel.Size = New System.Drawing.Size(68, 13)
        PRODUCTIDLabel.TabIndex = 89
        PRODUCTIDLabel.Text = "Product ID"
        '
        'PRODUCTDESCLabel
        '
        PRODUCTDESCLabel.AutoSize = True
        PRODUCTDESCLabel.Location = New System.Drawing.Point(19, 71)
        PRODUCTDESCLabel.Name = "PRODUCTDESCLabel"
        PRODUCTDESCLabel.Size = New System.Drawing.Size(118, 13)
        PRODUCTDESCLabel.TabIndex = 91
        PRODUCTDESCLabel.Text = "Product Description"
        '
        'STDWEIGHTLabel
        '
        STDWEIGHTLabel.AutoSize = True
        STDWEIGHTLabel.Location = New System.Drawing.Point(19, 152)
        STDWEIGHTLabel.Name = "STDWEIGHTLabel"
        STDWEIGHTLabel.Size = New System.Drawing.Size(102, 13)
        STDWEIGHTLabel.TabIndex = 93
        STDWEIGHTLabel.Text = "Standard Weight"
        '
        'STDGALLONSLabel
        '
        STDGALLONSLabel.AutoSize = True
        STDGALLONSLabel.Location = New System.Drawing.Point(19, 125)
        STDGALLONSLabel.Name = "STDGALLONSLabel"
        STDGALLONSLabel.Size = New System.Drawing.Size(105, 13)
        STDGALLONSLabel.TabIndex = 95
        STDGALLONSLabel.Text = "Standard Gallons"
        '
        'CONTAINERLabel
        '
        CONTAINERLabel.AutoSize = True
        CONTAINERLabel.Location = New System.Drawing.Point(19, 97)
        CONTAINERLabel.Name = "CONTAINERLabel"
        CONTAINERLabel.Size = New System.Drawing.Size(63, 13)
        CONTAINERLabel.TabIndex = 97
        CONTAINERLabel.Text = "Container"
        '
        'HEALTHLabel
        '
        HEALTHLabel.AutoSize = True
        HEALTHLabel.Location = New System.Drawing.Point(19, 313)
        HEALTHLabel.Name = "HEALTHLabel"
        HEALTHLabel.Size = New System.Drawing.Size(77, 13)
        HEALTHLabel.TabIndex = 99
        HEALTHLabel.Text = "Health Code"
        '
        'FIRELabel
        '
        FIRELabel.AutoSize = True
        FIRELabel.Location = New System.Drawing.Point(19, 340)
        FIRELabel.Name = "FIRELabel"
        FIRELabel.Size = New System.Drawing.Size(62, 13)
        FIRELabel.TabIndex = 101
        FIRELabel.Text = "Fire Code"
        '
        'REACTIVITYLabel
        '
        REACTIVITYLabel.AutoSize = True
        REACTIVITYLabel.Location = New System.Drawing.Point(19, 367)
        REACTIVITYLabel.Name = "REACTIVITYLabel"
        REACTIVITYLabel.Size = New System.Drawing.Size(97, 13)
        REACTIVITYLabel.TabIndex = 103
        REACTIVITYLabel.Text = "Reactivity Code"
        '
        'PERSONALPROTECTIONLabel
        '
        PERSONALPROTECTIONLabel.AutoSize = True
        PERSONALPROTECTIONLabel.Location = New System.Drawing.Point(19, 394)
        PERSONALPROTECTIONLabel.Name = "PERSONALPROTECTIONLabel"
        PERSONALPROTECTIONLabel.Size = New System.Drawing.Size(117, 13)
        PERSONALPROTECTIONLabel.TabIndex = 105
        PERSONALPROTECTIONLabel.Text = "Personal Protection"
        '
        'DOTDESCLabel
        '
        DOTDESCLabel.AutoSize = True
        DOTDESCLabel.Location = New System.Drawing.Point(18, 206)
        DOTDESCLabel.Name = "DOTDESCLabel"
        DOTDESCLabel.Size = New System.Drawing.Size(100, 13)
        DOTDESCLabel.TabIndex = 107
        DOTDESCLabel.Text = "DOT Description"
        '
        'HAZMATDESCLabel
        '
        HAZMATDESCLabel.AutoSize = True
        HAZMATDESCLabel.Location = New System.Drawing.Point(18, 233)
        HAZMATDESCLabel.Name = "HAZMATDESCLabel"
        HAZMATDESCLabel.Size = New System.Drawing.Size(123, 13)
        HAZMATDESCLabel.TabIndex = 109
        HAZMATDESCLabel.Text = "HAZMAT Description"
        '
        'UNLINELabel
        '
        UNLINELabel.AutoSize = True
        UNLINELabel.Location = New System.Drawing.Point(18, 260)
        UNLINELabel.Name = "UNLINELabel"
        UNLINELabel.Size = New System.Drawing.Size(46, 13)
        UNLINELabel.TabIndex = 111
        UNLINELabel.Text = "UNLine"
        '
        'PLACARDREQUIREDLabel
        '
        PLACARDREQUIREDLabel.AutoSize = True
        PLACARDREQUIREDLabel.Location = New System.Drawing.Point(18, 287)
        PLACARDREQUIREDLabel.Name = "PLACARDREQUIREDLabel"
        PLACARDREQUIREDLabel.Size = New System.Drawing.Size(107, 13)
        PLACARDREQUIREDLabel.TabIndex = 113
        PLACARDREQUIREDLabel.Text = "Placards required"
        '
        'CLASSRATELabel
        '
        CLASSRATELabel.AutoSize = True
        CLASSRATELabel.Location = New System.Drawing.Point(19, 179)
        CLASSRATELabel.Name = "CLASSRATELabel"
        CLASSRATELabel.Size = New System.Drawing.Size(68, 13)
        CLASSRATELabel.TabIndex = 115
        CLASSRATELabel.Text = "Class Rate"
        '
        'HAZMATIDLabel
        '
        HAZMATIDLabel.AutoSize = True
        HAZMATIDLabel.Location = New System.Drawing.Point(19, 421)
        HAZMATIDLabel.Name = "HAZMATIDLabel"
        HAZMATIDLabel.Size = New System.Drawing.Size(84, 13)
        HAZMATIDLabel.TabIndex = 117
        HAZMATIDLabel.Text = "Hazmat Label"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'AlphaGradientPanel1
        '
        Me.AlphaGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.AlphaGradientPanel1.Border = False
        Me.AlphaGradientPanel1.BorderColor = Global.AOS.My.MySettings.Default.ColorDark2
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha1)
        Me.AlphaGradientPanel1.Colors.Add(Me.ColorWithAlpha2)
        Me.AlphaGradientPanel1.ContentPadding = New System.Windows.Forms.Padding(-1)
        Me.AlphaGradientPanel1.Controls.Add(Me.cboHazmatLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.cboContainer)
        Me.AlphaGradientPanel1.Controls.Add(PRODUCTIDLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.PRODUCTIDTextBox)
        Me.AlphaGradientPanel1.Controls.Add(PRODUCTDESCLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.PRODUCTDESCTextBox)
        Me.AlphaGradientPanel1.Controls.Add(STDWEIGHTLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.STDWEIGHTTextBox)
        Me.AlphaGradientPanel1.Controls.Add(STDGALLONSLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.STDGALLONSTextBox)
        Me.AlphaGradientPanel1.Controls.Add(CONTAINERLabel)
        Me.AlphaGradientPanel1.Controls.Add(HEALTHLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.HEALTHTextBox)
        Me.AlphaGradientPanel1.Controls.Add(FIRELabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.FIRETextBox)
        Me.AlphaGradientPanel1.Controls.Add(REACTIVITYLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.REACTIVITYTextBox)
        Me.AlphaGradientPanel1.Controls.Add(PERSONALPROTECTIONLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.PERSONALPROTECTIONTextBox)
        Me.AlphaGradientPanel1.Controls.Add(DOTDESCLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.DOTDESCTextBox)
        Me.AlphaGradientPanel1.Controls.Add(HAZMATDESCLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.HAZMATDESCTextBox)
        Me.AlphaGradientPanel1.Controls.Add(UNLINELabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.UNLINETextBox)
        Me.AlphaGradientPanel1.Controls.Add(PLACARDREQUIREDLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.PLACARDREQUIREDTextBox)
        Me.AlphaGradientPanel1.Controls.Add(CLASSRATELabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.CLASSRATETextBox)
        Me.AlphaGradientPanel1.Controls.Add(HAZMATIDLabel)
        Me.AlphaGradientPanel1.Controls.Add(Me.btnCancelChanges)
        Me.AlphaGradientPanel1.Controls.Add(Me.btnSaveChanges)
        Me.AlphaGradientPanel1.Controls.Add(Me.Label1)
        Me.AlphaGradientPanel1.Controls.Add(Me.Header)
        Me.AlphaGradientPanel1.CornerRadius = 12
        Me.AlphaGradientPanel1.Corners = CType((((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight) _
                    Or BlueActivity.Controls.Corner.BottomLeft) _
                    Or BlueActivity.Controls.Corner.BottomRight), BlueActivity.Controls.Corner)
        Me.AlphaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AlphaGradientPanel1.Gradient = True
        Me.AlphaGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.AlphaGradientPanel1.GradientOffset = 1.0!
        Me.AlphaGradientPanel1.GradientSize = New System.Drawing.Size(0, 0)
        Me.AlphaGradientPanel1.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.AlphaGradientPanel1.Grayscale = False
        Me.AlphaGradientPanel1.Image = Nothing
        Me.AlphaGradientPanel1.ImageAlpha = 75
        Me.AlphaGradientPanel1.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.AlphaGradientPanel1.ImagePosition = BlueActivity.Controls.ImagePosition.BottomRight
        Me.AlphaGradientPanel1.ImageSize = New System.Drawing.Size(48, 48)
        Me.AlphaGradientPanel1.Location = New System.Drawing.Point(1, 1)
        Me.AlphaGradientPanel1.Name = "AlphaGradientPanel1"
        Me.AlphaGradientPanel1.Rounded = False
        Me.AlphaGradientPanel1.Size = New System.Drawing.Size(579, 505)
        Me.AlphaGradientPanel1.TabIndex = 0
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = Global.AOS.My.MySettings.Default.ColorMedium0
        Me.ColorWithAlpha1.Parent = Me.AlphaGradientPanel1
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 255
        Me.ColorWithAlpha2.Color = Global.AOS.My.MySettings.Default.ColorLight0
        Me.ColorWithAlpha2.Parent = Me.AlphaGradientPanel1
        '
        'cboHazmatLabel
        '
        Me.cboHazmatLabel.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.mProductBS, "Hazmatid", True))
        Me.cboHazmatLabel.DataSource = Me.bsLabels
        Me.cboHazmatLabel.DisplayMember = "SymbolDesc"
        Me.cboHazmatLabel.FormattingEnabled = True
        Me.cboHazmatLabel.Location = New System.Drawing.Point(174, 418)
        Me.cboHazmatLabel.Name = "cboHazmatLabel"
        Me.cboHazmatLabel.Size = New System.Drawing.Size(121, 21)
        Me.cboHazmatLabel.TabIndex = 120
        Me.cboHazmatLabel.ValueMember = "HazMatID"
        '
        'mProductBS
        '
        Me.mProductBS.DataSource = GetType(AOS.BusinessObjects.Product)
        '
        'cboContainer
        '
        Me.cboContainer.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.mProductBS, "Container", True))
        Me.cboContainer.DataSource = Me.bsContainers
        Me.cboContainer.DisplayMember = "Container"
        Me.cboContainer.FormattingEnabled = True
        Me.cboContainer.Location = New System.Drawing.Point(174, 95)
        Me.cboContainer.Name = "cboContainer"
        Me.cboContainer.Size = New System.Drawing.Size(100, 21)
        Me.cboContainer.TabIndex = 119
        Me.cboContainer.ValueMember = "Container"
        '
        'bsContainers
        '
        Me.bsContainers.DataSource = GetType(AOS.BusinessObjects.ContainerCollection)
        '
        'PRODUCTIDTextBox
        '
        Me.PRODUCTIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "PRODUCTID", True))
        Me.PRODUCTIDTextBox.Location = New System.Drawing.Point(174, 41)
        Me.PRODUCTIDTextBox.Name = "PRODUCTIDTextBox"
        Me.PRODUCTIDTextBox.ReadOnly = True
        Me.PRODUCTIDTextBox.Size = New System.Drawing.Size(100, 21)
        Me.PRODUCTIDTextBox.TabIndex = 90
        '
        'PRODUCTDESCTextBox
        '
        Me.PRODUCTDESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "PRODUCTDESC", True))
        Me.PRODUCTDESCTextBox.Location = New System.Drawing.Point(174, 68)
        Me.PRODUCTDESCTextBox.Name = "PRODUCTDESCTextBox"
        Me.PRODUCTDESCTextBox.Size = New System.Drawing.Size(384, 21)
        Me.PRODUCTDESCTextBox.TabIndex = 92
        '
        'STDWEIGHTTextBox
        '
        Me.STDWEIGHTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "STDWEIGHT", True))
        Me.STDWEIGHTTextBox.Location = New System.Drawing.Point(174, 149)
        Me.STDWEIGHTTextBox.Name = "STDWEIGHTTextBox"
        Me.STDWEIGHTTextBox.Size = New System.Drawing.Size(100, 21)
        Me.STDWEIGHTTextBox.TabIndex = 94
        '
        'STDGALLONSTextBox
        '
        Me.STDGALLONSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "STDGALLONS", True))
        Me.STDGALLONSTextBox.Location = New System.Drawing.Point(174, 122)
        Me.STDGALLONSTextBox.Name = "STDGALLONSTextBox"
        Me.STDGALLONSTextBox.Size = New System.Drawing.Size(100, 21)
        Me.STDGALLONSTextBox.TabIndex = 96
        '
        'HEALTHTextBox
        '
        Me.HEALTHTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "HEALTH", True))
        Me.HEALTHTextBox.Location = New System.Drawing.Point(174, 310)
        Me.HEALTHTextBox.Name = "HEALTHTextBox"
        Me.HEALTHTextBox.Size = New System.Drawing.Size(38, 21)
        Me.HEALTHTextBox.TabIndex = 100
        '
        'FIRETextBox
        '
        Me.FIRETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "FIRE", True))
        Me.FIRETextBox.Location = New System.Drawing.Point(174, 337)
        Me.FIRETextBox.Name = "FIRETextBox"
        Me.FIRETextBox.Size = New System.Drawing.Size(38, 21)
        Me.FIRETextBox.TabIndex = 102
        '
        'REACTIVITYTextBox
        '
        Me.REACTIVITYTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "REACTIVITY", True))
        Me.REACTIVITYTextBox.Location = New System.Drawing.Point(174, 364)
        Me.REACTIVITYTextBox.Name = "REACTIVITYTextBox"
        Me.REACTIVITYTextBox.Size = New System.Drawing.Size(38, 21)
        Me.REACTIVITYTextBox.TabIndex = 104
        '
        'PERSONALPROTECTIONTextBox
        '
        Me.PERSONALPROTECTIONTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "PERSONALPROTECTION", True))
        Me.PERSONALPROTECTIONTextBox.Location = New System.Drawing.Point(174, 391)
        Me.PERSONALPROTECTIONTextBox.Name = "PERSONALPROTECTIONTextBox"
        Me.PERSONALPROTECTIONTextBox.Size = New System.Drawing.Size(38, 21)
        Me.PERSONALPROTECTIONTextBox.TabIndex = 106
        '
        'DOTDESCTextBox
        '
        Me.DOTDESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "DOTDESC", True))
        Me.DOTDESCTextBox.Location = New System.Drawing.Point(174, 203)
        Me.DOTDESCTextBox.Name = "DOTDESCTextBox"
        Me.DOTDESCTextBox.Size = New System.Drawing.Size(384, 21)
        Me.DOTDESCTextBox.TabIndex = 108
        '
        'HAZMATDESCTextBox
        '
        Me.HAZMATDESCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "HAZMATDESC", True))
        Me.HAZMATDESCTextBox.Location = New System.Drawing.Point(174, 230)
        Me.HAZMATDESCTextBox.Name = "HAZMATDESCTextBox"
        Me.HAZMATDESCTextBox.Size = New System.Drawing.Size(384, 21)
        Me.HAZMATDESCTextBox.TabIndex = 110
        '
        'UNLINETextBox
        '
        Me.UNLINETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "UNLINE", True))
        Me.UNLINETextBox.Location = New System.Drawing.Point(174, 257)
        Me.UNLINETextBox.Name = "UNLINETextBox"
        Me.UNLINETextBox.Size = New System.Drawing.Size(384, 21)
        Me.UNLINETextBox.TabIndex = 112
        '
        'PLACARDREQUIREDTextBox
        '
        Me.PLACARDREQUIREDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "PLACARDREQUIRED", True))
        Me.PLACARDREQUIREDTextBox.Location = New System.Drawing.Point(174, 284)
        Me.PLACARDREQUIREDTextBox.Name = "PLACARDREQUIREDTextBox"
        Me.PLACARDREQUIREDTextBox.Size = New System.Drawing.Size(204, 21)
        Me.PLACARDREQUIREDTextBox.TabIndex = 114
        '
        'CLASSRATETextBox
        '
        Me.CLASSRATETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.mProductBS, "CLASSRATE", True))
        Me.CLASSRATETextBox.Location = New System.Drawing.Point(174, 176)
        Me.CLASSRATETextBox.Name = "CLASSRATETextBox"
        Me.CLASSRATETextBox.Size = New System.Drawing.Size(100, 21)
        Me.CLASSRATETextBox.TabIndex = 116
        '
        'btnCancelChanges
        '
        Me.btnCancelChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelChanges.Location = New System.Drawing.Point(297, 468)
        Me.btnCancelChanges.Name = "btnCancelChanges"
        Me.btnCancelChanges.Size = New System.Drawing.Size(128, 23)
        Me.btnCancelChanges.TabIndex = 21
        Me.btnCancelChanges.Text = "Cancel Changes"
        Me.btnCancelChanges.UseVisualStyleBackColor = True
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveChanges.Location = New System.Drawing.Point(437, 468)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(128, 23)
        Me.btnSaveChanges.TabIndex = 20
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = Global.AOS.My.MySettings.Default.ColorDark2
        Me.Label1.Location = New System.Drawing.Point(4, 451)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(571, 2)
        Me.Label1.TabIndex = 89
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.Color.Transparent
        Me.Header.Border = False
        Me.Header.BorderColor = System.Drawing.SystemColors.ActiveBorder
        Me.Header.Colors.Add(Me.ColorWithAlpha3)
        Me.Header.Colors.Add(Me.ColorWithAlpha4)
        Me.Header.ContentPadding = New System.Windows.Forms.Padding(-1)
        Me.Header.Controls.Add(Me.Label25)
        Me.Header.Controls.Add(Me.Caption)
        Me.Header.CornerRadius = 12
        Me.Header.Corners = CType((BlueActivity.Controls.Corner.TopLeft Or BlueActivity.Controls.Corner.TopRight), BlueActivity.Controls.Corner)
        Me.Header.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header.Gradient = True
        Me.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Header.GradientOffset = 1.0!
        Me.Header.GradientSize = New System.Drawing.Size(0, 0)
        Me.Header.GradientWrapMode = System.Drawing.Drawing2D.WrapMode.Tile
        Me.Header.Grayscale = False
        Me.Header.Image = CType(resources.GetObject("Header.Image"), System.Drawing.Image)
        Me.Header.ImageAlpha = 100
        Me.Header.ImagePadding = New System.Windows.Forms.Padding(5)
        Me.Header.ImagePosition = BlueActivity.Controls.ImagePosition.TopLeft
        Me.Header.ImageSize = New System.Drawing.Size(24, 24)
        Me.Header.Location = New System.Drawing.Point(0, 0)
        Me.Header.Name = "Header"
        Me.Header.Padding = New System.Windows.Forms.Padding(30, 0, 4, 0)
        Me.Header.Rounded = False
        Me.Header.Size = New System.Drawing.Size(579, 30)
        Me.Header.TabIndex = 0
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = Global.AOS.My.MySettings.Default.ColorMedium0
        Me.ColorWithAlpha3.Parent = Me.Header
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = Global.AOS.My.MySettings.Default.ColorMedium2
        Me.ColorWithAlpha4.Parent = Me.Header
        '
        'Label25
        '
        Me.Label25.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label25.ForeColor = Global.AOS.My.MySettings.Default.ColorLight1
        Me.Label25.Location = New System.Drawing.Point(485, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 30)
        Me.Label25.TabIndex = 1
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Caption
        '
        Me.Caption.Dock = System.Windows.Forms.DockStyle.Left
        Me.Caption.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caption.ForeColor = System.Drawing.Color.White
        Me.Caption.Location = New System.Drawing.Point(30, 0)
        Me.Caption.Name = "Caption"
        Me.Caption.Size = New System.Drawing.Size(360, 30)
        Me.Caption.TabIndex = 0
        Me.Caption.Text = "Caption"
        Me.Caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Add24.png")
        Me.ImageList1.Images.SetKeyName(1, "Edit24.png")
        '
        'bsLabels
        '
        Me.bsLabels.DataSource = GetType(AOS.BusinessObjects.HazmatsymbolCollection)
        '
        'frmAddEditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(581, 507)
        Me.Controls.Add(Me.AlphaGradientPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAddEditProduct"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.AlphaGradientPanel1.ResumeLayout(False)
        Me.AlphaGradientPanel1.PerformLayout()
        CType(Me.mProductBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsContainers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header.ResumeLayout(False)
        CType(Me.bsLabels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AlphaGradientPanel1 As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents Header As BlueActivity.Controls.AlphaGradientPanel
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelChanges As System.Windows.Forms.Button
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents Caption As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents mProductBS As System.Windows.Forms.BindingSource
    Friend WithEvents PRODUCTIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PRODUCTDESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STDWEIGHTTextBox As System.Windows.Forms.TextBox
    Friend WithEvents STDGALLONSTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HEALTHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FIRETextBox As System.Windows.Forms.TextBox
    Friend WithEvents REACTIVITYTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PERSONALPROTECTIONTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOTDESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HAZMATDESCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UNLINETextBox As System.Windows.Forms.TextBox
    Friend WithEvents PLACARDREQUIREDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CLASSRATETextBox As System.Windows.Forms.TextBox
    Friend WithEvents cboContainer As System.Windows.Forms.ComboBox
    Friend WithEvents bsContainers As System.Windows.Forms.BindingSource
    Friend WithEvents cboHazmatLabel As System.Windows.Forms.ComboBox
    Friend WithEvents bsLabels As System.Windows.Forms.BindingSource
End Class
