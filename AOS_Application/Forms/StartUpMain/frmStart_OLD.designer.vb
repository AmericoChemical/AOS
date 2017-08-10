<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart_OLD
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
        Me.components = New System.ComponentModel.Container()
        Dim GroupBox1 As System.Windows.Forms.GroupBox
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart_OLD))
        Me.msgNet = New System.Windows.Forms.Label()
        Me.boxR = New System.Windows.Forms.PictureBox()
        Me.boxG = New System.Windows.Forms.PictureBox()
        Me.BoxY = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.btnCancelLogin = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.editPassword = New System.Windows.Forms.TextBox()
        Me.editUserName = New System.Windows.Forms.TextBox()
        Me.btnSkipSQLServer = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConnectSQLServer = New System.Windows.Forms.Button()
        Me.editSQLServerName = New System.Windows.Forms.TextBox()
        Me.btnGetAccessDatabaseName = New System.Windows.Forms.Button()
        Me.btnSkipAccessDatabase = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnConnectAccessDatabase = New System.Windows.Forms.Button()
        Me.editAccessDatabaseName = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.grpUserLogin = New System.Windows.Forms.GroupBox()
        Me.grpAccessDatabase = New System.Windows.Forms.GroupBox()
        Me.grpSQLServerDatabase = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        GroupBox1 = New System.Windows.Forms.GroupBox()
        GroupBox1.SuspendLayout()
        CType(Me.boxR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUserLogin.SuspendLayout()
        Me.grpAccessDatabase.SuspendLayout()
        Me.grpSQLServerDatabase.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        GroupBox1.BackColor = System.Drawing.Color.Transparent
        GroupBox1.Controls.Add(Me.msgNet)
        GroupBox1.Controls.Add(Me.boxR)
        GroupBox1.Controls.Add(Me.boxG)
        GroupBox1.Controls.Add(Me.BoxY)
        GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        GroupBox1.Location = New System.Drawing.Point(11, 41)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New System.Drawing.Size(408, 59)
        GroupBox1.TabIndex = 43
        GroupBox1.TabStop = False
        GroupBox1.Text = "Connection Status"
        '
        'msgNet
        '
        Me.msgNet.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msgNet.Location = New System.Drawing.Point(38, 24)
        Me.msgNet.Name = "msgNet"
        Me.msgNet.Size = New System.Drawing.Size(364, 20)
        Me.msgNet.TabIndex = 47
        Me.msgNet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'boxR
        '
        Me.boxR.Image = CType(resources.GetObject("boxR.Image"), System.Drawing.Image)
        Me.boxR.Location = New System.Drawing.Point(9, 22)
        Me.boxR.Name = "boxR"
        Me.boxR.Size = New System.Drawing.Size(24, 24)
        Me.boxR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.boxR.TabIndex = 46
        Me.boxR.TabStop = False
        Me.boxR.Visible = False
        '
        'boxG
        '
        Me.boxG.Image = CType(resources.GetObject("boxG.Image"), System.Drawing.Image)
        Me.boxG.Location = New System.Drawing.Point(9, 22)
        Me.boxG.Name = "boxG"
        Me.boxG.Size = New System.Drawing.Size(24, 24)
        Me.boxG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.boxG.TabIndex = 45
        Me.boxG.TabStop = False
        Me.boxG.Visible = False
        '
        'BoxY
        '
        Me.BoxY.Image = CType(resources.GetObject("BoxY.Image"), System.Drawing.Image)
        Me.BoxY.Location = New System.Drawing.Point(9, 22)
        Me.BoxY.Name = "BoxY"
        Me.BoxY.Size = New System.Drawing.Size(24, 24)
        Me.BoxY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BoxY.TabIndex = 44
        Me.BoxY.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(408, 64)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'lblCopyright
        '
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.lblCopyright.Location = New System.Drawing.Point(11, 289)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(408, 24)
        Me.lblCopyright.TabIndex = 58
        Me.lblCopyright.Text = "Copyright © 2006-2010 Client Name"
        '
        'btnCancelLogin
        '
        Me.btnCancelLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnCancelLogin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancelLogin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelLogin.ForeColor = System.Drawing.Color.White
        Me.btnCancelLogin.Location = New System.Drawing.Point(127, 126)
        Me.btnCancelLogin.Name = "btnCancelLogin"
        Me.btnCancelLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelLogin.TabIndex = 31
        Me.btnCancelLogin.Text = "Cancel"
        Me.btnCancelLogin.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(21, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(99, 94)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 14)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Password"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(99, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 14)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "User Name"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(86, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(270, 32)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Enter your user name and password and press the Login button to start your sessio" & _
    "n."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnLogin.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(206, 126)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 26
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'editPassword
        '
        Me.editPassword.BackColor = System.Drawing.Color.White
        Me.editPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.editPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editPassword.Location = New System.Drawing.Point(187, 94)
        Me.editPassword.Name = "editPassword"
        Me.editPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.editPassword.Size = New System.Drawing.Size(100, 21)
        Me.editPassword.TabIndex = 25
        '
        'editUserName
        '
        Me.editUserName.BackColor = System.Drawing.Color.White
        Me.editUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.editUserName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editUserName.Location = New System.Drawing.Point(187, 70)
        Me.editUserName.Name = "editUserName"
        Me.editUserName.Size = New System.Drawing.Size(100, 21)
        Me.editUserName.TabIndex = 24
        '
        'btnSkipSQLServer
        '
        Me.btnSkipSQLServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnSkipSQLServer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSkipSQLServer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkipSQLServer.ForeColor = System.Drawing.Color.White
        Me.btnSkipSQLServer.Location = New System.Drawing.Point(208, 90)
        Me.btnSkipSQLServer.Name = "btnSkipSQLServer"
        Me.btnSkipSQLServer.Size = New System.Drawing.Size(75, 23)
        Me.btnSkipSQLServer.TabIndex = 26
        Me.btnSkipSQLServer.Text = "Skip"
        Me.btnSkipSQLServer.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(21, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(79, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(250, 18)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Enter IP Address of SQL Server machine"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConnectSQLServer
        '
        Me.btnConnectSQLServer.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.btnConnectSQLServer.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnConnectSQLServer.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectSQLServer.ForeColor = System.Drawing.Color.White
        Me.btnConnectSQLServer.Location = New System.Drawing.Point(125, 90)
        Me.btnConnectSQLServer.Name = "btnConnectSQLServer"
        Me.btnConnectSQLServer.Size = New System.Drawing.Size(75, 23)
        Me.btnConnectSQLServer.TabIndex = 25
        Me.btnConnectSQLServer.Text = "Connect"
        Me.btnConnectSQLServer.UseVisualStyleBackColor = False
        '
        'editSQLServerName
        '
        Me.editSQLServerName.BackColor = System.Drawing.Color.White
        Me.editSQLServerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.editSQLServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.editSQLServerName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editSQLServerName.Location = New System.Drawing.Point(79, 57)
        Me.editSQLServerName.Name = "editSQLServerName"
        Me.editSQLServerName.Size = New System.Drawing.Size(245, 21)
        Me.editSQLServerName.TabIndex = 24
        '
        'btnGetAccessDatabaseName
        '
        Me.btnGetAccessDatabaseName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetAccessDatabaseName.Location = New System.Drawing.Point(321, 54)
        Me.btnGetAccessDatabaseName.Name = "btnGetAccessDatabaseName"
        Me.btnGetAccessDatabaseName.Size = New System.Drawing.Size(24, 21)
        Me.btnGetAccessDatabaseName.TabIndex = 34
        Me.btnGetAccessDatabaseName.Text = "..."
        '
        'btnSkipAccessDatabase
        '
        Me.btnSkipAccessDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnSkipAccessDatabase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSkipAccessDatabase.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSkipAccessDatabase.ForeColor = System.Drawing.Color.White
        Me.btnSkipAccessDatabase.Location = New System.Drawing.Point(208, 87)
        Me.btnSkipAccessDatabase.Name = "btnSkipAccessDatabase"
        Me.btnSkipAccessDatabase.Size = New System.Drawing.Size(75, 23)
        Me.btnSkipAccessDatabase.TabIndex = 26
        Me.btnSkipAccessDatabase.Text = "Skip"
        Me.btnSkipAccessDatabase.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(269, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Enter the path and name of Access Database"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConnectAccessDatabase
        '
        Me.btnConnectAccessDatabase.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnConnectAccessDatabase.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnConnectAccessDatabase.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectAccessDatabase.ForeColor = System.Drawing.Color.White
        Me.btnConnectAccessDatabase.Location = New System.Drawing.Point(125, 87)
        Me.btnConnectAccessDatabase.Name = "btnConnectAccessDatabase"
        Me.btnConnectAccessDatabase.Size = New System.Drawing.Size(75, 23)
        Me.btnConnectAccessDatabase.TabIndex = 25
        Me.btnConnectAccessDatabase.Text = "Connect"
        Me.btnConnectAccessDatabase.UseVisualStyleBackColor = False
        '
        'editAccessDatabaseName
        '
        Me.editAccessDatabaseName.BackColor = System.Drawing.Color.White
        Me.editAccessDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.editAccessDatabaseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.editAccessDatabaseName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editAccessDatabaseName.Location = New System.Drawing.Point(80, 54)
        Me.editAccessDatabaseName.Name = "editAccessDatabaseName"
        Me.editAccessDatabaseName.Size = New System.Drawing.Size(242, 21)
        Me.editAccessDatabaseName.TabIndex = 24
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'grpUserLogin
        '
        Me.grpUserLogin.BackColor = System.Drawing.Color.Transparent
        Me.grpUserLogin.Controls.Add(Me.btnCancelLogin)
        Me.grpUserLogin.Controls.Add(Me.PictureBox2)
        Me.grpUserLogin.Controls.Add(Me.Label14)
        Me.grpUserLogin.Controls.Add(Me.btnLogin)
        Me.grpUserLogin.Controls.Add(Me.Label13)
        Me.grpUserLogin.Controls.Add(Me.editUserName)
        Me.grpUserLogin.Controls.Add(Me.Label12)
        Me.grpUserLogin.Controls.Add(Me.editPassword)
        Me.grpUserLogin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpUserLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.grpUserLogin.Location = New System.Drawing.Point(11, 110)
        Me.grpUserLogin.Name = "grpUserLogin"
        Me.grpUserLogin.Size = New System.Drawing.Size(408, 162)
        Me.grpUserLogin.TabIndex = 61
        Me.grpUserLogin.TabStop = False
        Me.grpUserLogin.Text = "User Login"
        Me.grpUserLogin.Visible = False
        '
        'grpAccessDatabase
        '
        Me.grpAccessDatabase.Controls.Add(Me.btnGetAccessDatabaseName)
        Me.grpAccessDatabase.Controls.Add(Me.PictureBox1)
        Me.grpAccessDatabase.Controls.Add(Me.btnSkipAccessDatabase)
        Me.grpAccessDatabase.Controls.Add(Me.editAccessDatabaseName)
        Me.grpAccessDatabase.Controls.Add(Me.btnConnectAccessDatabase)
        Me.grpAccessDatabase.Controls.Add(Me.Label6)
        Me.grpAccessDatabase.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAccessDatabase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.grpAccessDatabase.Location = New System.Drawing.Point(11, 110)
        Me.grpAccessDatabase.Name = "grpAccessDatabase"
        Me.grpAccessDatabase.Size = New System.Drawing.Size(408, 126)
        Me.grpAccessDatabase.TabIndex = 62
        Me.grpAccessDatabase.TabStop = False
        Me.grpAccessDatabase.Text = "Access Database Connection"
        Me.grpAccessDatabase.Visible = False
        '
        'grpSQLServerDatabase
        '
        Me.grpSQLServerDatabase.Controls.Add(Me.btnSkipSQLServer)
        Me.grpSQLServerDatabase.Controls.Add(Me.PictureBox3)
        Me.grpSQLServerDatabase.Controls.Add(Me.editSQLServerName)
        Me.grpSQLServerDatabase.Controls.Add(Me.Label9)
        Me.grpSQLServerDatabase.Controls.Add(Me.btnConnectSQLServer)
        Me.grpSQLServerDatabase.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSQLServerDatabase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.grpSQLServerDatabase.Location = New System.Drawing.Point(11, 110)
        Me.grpSQLServerDatabase.Name = "grpSQLServerDatabase"
        Me.grpSQLServerDatabase.Size = New System.Drawing.Size(408, 132)
        Me.grpSQLServerDatabase.TabIndex = 63
        Me.grpSQLServerDatabase.TabStop = False
        Me.grpSQLServerDatabase.Text = "SQL Server Database Connection"
        Me.grpSQLServerDatabase.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.grpUserLogin)
        Me.Panel2.Controls.Add(Me.grpSQLServerDatabase)
        Me.Panel2.Controls.Add(Me.lblAppName)
        Me.Panel2.Controls.Add(GroupBox1)
        Me.Panel2.Controls.Add(Me.lblCopyright)
        Me.Panel2.Controls.Add(Me.grpAccessDatabase)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 403)
        Me.Panel2.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(408, 24)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "All rights reserved."
        '
        'lblAppName
        '
        Me.lblAppName.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.lblAppName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAppName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.ForeColor = System.Drawing.Color.White
        Me.lblAppName.Location = New System.Drawing.Point(0, 0)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(430, 24)
        Me.lblAppName.TabIndex = 64
        Me.lblAppName.Text = "App Name"
        Me.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(2)
        Me.Panel1.Size = New System.Drawing.Size(434, 407)
        Me.Panel1.TabIndex = 65
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(434, 407)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmStart"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmStart"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(Me.boxR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUserLogin.ResumeLayout(False)
        Me.grpUserLogin.PerformLayout()
        Me.grpAccessDatabase.ResumeLayout(False)
        Me.grpAccessDatabase.PerformLayout()
        Me.grpSQLServerDatabase.ResumeLayout(False)
        Me.grpSQLServerDatabase.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents msgNet As System.Windows.Forms.Label
    Friend WithEvents boxR As System.Windows.Forms.PictureBox
    Friend WithEvents boxG As System.Windows.Forms.PictureBox
    Friend WithEvents BoxY As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelLogin As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents editPassword As System.Windows.Forms.TextBox
    Friend WithEvents editUserName As System.Windows.Forms.TextBox
    Friend WithEvents btnSkipSQLServer As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnConnectSQLServer As System.Windows.Forms.Button
    Friend WithEvents editSQLServerName As System.Windows.Forms.TextBox
    Friend WithEvents btnGetAccessDatabaseName As System.Windows.Forms.Button
    Friend WithEvents btnSkipAccessDatabase As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnConnectAccessDatabase As System.Windows.Forms.Button
    Friend WithEvents editAccessDatabaseName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents grpUserLogin As System.Windows.Forms.GroupBox
    Friend WithEvents grpAccessDatabase As System.Windows.Forms.GroupBox
    Friend WithEvents grpSQLServerDatabase As System.Windows.Forms.GroupBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblAppName As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
