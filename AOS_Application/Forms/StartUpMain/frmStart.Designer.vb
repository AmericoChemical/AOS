<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gcConnectionStatus = New DevExpress.XtraEditors.GroupControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.boxR = New System.Windows.Forms.PictureBox()
        Me.BoxY = New System.Windows.Forms.PictureBox()
        Me.boxG = New System.Windows.Forms.PictureBox()
        Me.msgNet = New DevExpress.XtraEditors.LabelControl()
        Me.grpUserLogin = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btnLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCancelLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.editUserName = New DevExpress.XtraEditors.TextEdit()
        Me.editPassword = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.grpSQLServerDatabase = New DevExpress.XtraEditors.GroupControl()
        Me.btnSkipSQLServer = New DevExpress.XtraEditors.SimpleButton()
        Me.btnConnectSQLServer = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.editSQLServerName = New DevExpress.XtraEditors.TextEdit()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblCopyright = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        CType(Me.gcConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gcConnectionStatus.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.boxR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BoxY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boxG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpUserLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpUserLogin.SuspendLayout()
        CType(Me.editUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpSQLServerDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSQLServerDatabase.SuspendLayout()
        CType(Me.editSQLServerName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'gcConnectionStatus
        '
        Me.gcConnectionStatus.Controls.Add(Me.Panel1)
        Me.gcConnectionStatus.Controls.Add(Me.msgNet)
        Me.gcConnectionStatus.Location = New System.Drawing.Point(12, 12)
        Me.gcConnectionStatus.Name = "gcConnectionStatus"
        Me.gcConnectionStatus.Size = New System.Drawing.Size(464, 58)
        Me.gcConnectionStatus.TabIndex = 0
        Me.gcConnectionStatus.Text = "Connection Status"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.boxR)
        Me.Panel1.Controls.Add(Me.BoxY)
        Me.Panel1.Controls.Add(Me.boxG)
        Me.Panel1.Location = New System.Drawing.Point(5, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(30, 31)
        Me.Panel1.TabIndex = 52
        '
        'boxR
        '
        Me.boxR.Image = CType(resources.GetObject("boxR.Image"), System.Drawing.Image)
        Me.boxR.Location = New System.Drawing.Point(3, 3)
        Me.boxR.Name = "boxR"
        Me.boxR.Size = New System.Drawing.Size(24, 24)
        Me.boxR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.boxR.TabIndex = 50
        Me.boxR.TabStop = False
        Me.boxR.Visible = False
        '
        'BoxY
        '
        Me.BoxY.Image = CType(resources.GetObject("BoxY.Image"), System.Drawing.Image)
        Me.BoxY.Location = New System.Drawing.Point(3, 3)
        Me.BoxY.Name = "BoxY"
        Me.BoxY.Size = New System.Drawing.Size(24, 24)
        Me.BoxY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BoxY.TabIndex = 48
        Me.BoxY.TabStop = False
        '
        'boxG
        '
        Me.boxG.Image = CType(resources.GetObject("boxG.Image"), System.Drawing.Image)
        Me.boxG.Location = New System.Drawing.Point(3, 3)
        Me.boxG.Name = "boxG"
        Me.boxG.Size = New System.Drawing.Size(24, 24)
        Me.boxG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.boxG.TabIndex = 49
        Me.boxG.TabStop = False
        Me.boxG.Visible = False
        '
        'msgNet
        '
        Me.msgNet.Appearance.Options.UseTextOptions = True
        Me.msgNet.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.msgNet.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.msgNet.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.msgNet.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.msgNet.Location = New System.Drawing.Point(41, 25)
        Me.msgNet.Name = "msgNet"
        Me.msgNet.Size = New System.Drawing.Size(410, 24)
        Me.msgNet.TabIndex = 51
        '
        'grpUserLogin
        '
        Me.grpUserLogin.Controls.Add(Me.LabelControl3)
        Me.grpUserLogin.Controls.Add(Me.LabelControl2)
        Me.grpUserLogin.Controls.Add(Me.LabelControl1)
        Me.grpUserLogin.Controls.Add(Me.btnLogin)
        Me.grpUserLogin.Controls.Add(Me.btnCancelLogin)
        Me.grpUserLogin.Controls.Add(Me.editUserName)
        Me.grpUserLogin.Controls.Add(Me.editPassword)
        Me.grpUserLogin.Controls.Add(Me.PictureBox2)
        Me.grpUserLogin.Location = New System.Drawing.Point(12, 76)
        Me.grpUserLogin.Name = "grpUserLogin"
        Me.grpUserLogin.Size = New System.Drawing.Size(464, 186)
        Me.grpUserLogin.TabIndex = 1
        Me.grpUserLogin.Text = "User Login"
        Me.grpUserLogin.Visible = False
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(142, 112)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 38
        Me.LabelControl3.Text = "Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(142, 86)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 37
        Me.LabelControl2.Text = "User Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(74, 38)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(349, 34)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "Enter your user name and password and press the Login button"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(235, 139)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Login"
        '
        'btnCancelLogin
        '
        Me.btnCancelLogin.Location = New System.Drawing.Point(154, 139)
        Me.btnCancelLogin.Name = "btnCancelLogin"
        Me.btnCancelLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelLogin.TabIndex = 3
        Me.btnCancelLogin.Text = "Cancel"
        '
        'editUserName
        '
        Me.editUserName.Location = New System.Drawing.Point(218, 82)
        Me.editUserName.Name = "editUserName"
        Me.editUserName.Size = New System.Drawing.Size(105, 20)
        Me.editUserName.TabIndex = 0
        '
        'editPassword
        '
        Me.editPassword.Location = New System.Drawing.Point(218, 108)
        Me.editPassword.Name = "editPassword"
        Me.editPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.editPassword.Size = New System.Drawing.Size(105, 20)
        Me.editPassword.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(20, 39)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'grpSQLServerDatabase
        '
        Me.grpSQLServerDatabase.Controls.Add(Me.btnSkipSQLServer)
        Me.grpSQLServerDatabase.Controls.Add(Me.btnConnectSQLServer)
        Me.grpSQLServerDatabase.Controls.Add(Me.LabelControl4)
        Me.grpSQLServerDatabase.Controls.Add(Me.editSQLServerName)
        Me.grpSQLServerDatabase.Controls.Add(Me.PictureBox3)
        Me.grpSQLServerDatabase.Location = New System.Drawing.Point(12, 78)
        Me.grpSQLServerDatabase.Name = "grpSQLServerDatabase"
        Me.grpSQLServerDatabase.Size = New System.Drawing.Size(464, 163)
        Me.grpSQLServerDatabase.TabIndex = 2
        Me.grpSQLServerDatabase.Text = "SQL Server Database Connection"
        Me.grpSQLServerDatabase.Visible = False
        '
        'btnSkipSQLServer
        '
        Me.btnSkipSQLServer.Location = New System.Drawing.Point(235, 108)
        Me.btnSkipSQLServer.Name = "btnSkipSQLServer"
        Me.btnSkipSQLServer.Size = New System.Drawing.Size(75, 23)
        Me.btnSkipSQLServer.TabIndex = 39
        Me.btnSkipSQLServer.Text = "Skip"
        '
        'btnConnectSQLServer
        '
        Me.btnConnectSQLServer.Location = New System.Drawing.Point(154, 108)
        Me.btnConnectSQLServer.Name = "btnConnectSQLServer"
        Me.btnConnectSQLServer.Size = New System.Drawing.Size(75, 23)
        Me.btnConnectSQLServer.TabIndex = 38
        Me.btnConnectSQLServer.Text = "Connect"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Location = New System.Drawing.Point(74, 37)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(349, 34)
        Me.LabelControl4.TabIndex = 37
        Me.LabelControl4.Text = "Enter IP Address or name of SQL Server Machine, and SQL Server Instance name, if " &
    "applicable (i.e. ServerName\InstanceName)"
        '
        'editSQLServerName
        '
        Me.editSQLServerName.Location = New System.Drawing.Point(74, 77)
        Me.editSQLServerName.Name = "editSQLServerName"
        Me.editSQLServerName.Size = New System.Drawing.Size(323, 20)
        Me.editSQLServerName.TabIndex = 34
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(20, 38)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 31
        Me.PictureBox3.TabStop = False
        '
        'lblCopyright
        '
        Me.lblCopyright.Appearance.Options.UseTextOptions = True
        Me.lblCopyright.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.lblCopyright.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lblCopyright.Location = New System.Drawing.Point(12, 268)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(464, 20)
        Me.lblCopyright.TabIndex = 38
        Me.lblCopyright.Text = "Copyright © 2006-2010 Client Name"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(12, 294)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl5.TabIndex = 39
        Me.LabelControl5.Text = "All rights reserved."
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(12, 313)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(464, 50)
        Me.LabelControl6.TabIndex = 40
        Me.LabelControl6.Text = resources.GetString("LabelControl6.Text")
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Seven"
        '
        'frmStart
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 367)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.grpUserLogin)
        Me.Controls.Add(Me.gcConnectionStatus)
        Me.Controls.Add(Me.grpSQLServerDatabase)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.LookAndFeel.SkinName = "Dark Side"
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStart"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Americo Chemical Products, Inc."
        CType(Me.gcConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gcConnectionStatus.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.boxR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BoxY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boxG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpUserLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpUserLogin.ResumeLayout(False)
        Me.grpUserLogin.PerformLayout()
        CType(Me.editUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpSQLServerDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSQLServerDatabase.ResumeLayout(False)
        Me.grpSQLServerDatabase.PerformLayout()
        CType(Me.editSQLServerName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents gcConnectionStatus As DevExpress.XtraEditors.GroupControl
    Friend WithEvents msgNet As DevExpress.XtraEditors.LabelControl
    Friend WithEvents boxR As System.Windows.Forms.PictureBox
    Friend WithEvents boxG As System.Windows.Forms.PictureBox
    Friend WithEvents BoxY As System.Windows.Forms.PictureBox
    Friend WithEvents grpUserLogin As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents editPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents editUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnCancelLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grpSQLServerDatabase As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents editSQLServerName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnSkipSQLServer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnConnectSQLServer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblCopyright As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
End Class
