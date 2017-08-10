'All the variables for the session referred to in the code in this
'form module are defined and instantiated in the AppSession module
'so they become available to the entire application

Imports AOS.BusinessObjects

Public Class frmStart

    Private Sub frmStart_Load(ByVal sender As Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getApplicationSettings()
        ConnectionStart()
    End Sub
    Private Function getApplicationSettings() As String

        Try
            'First, set session variables (all defined in ApplicationUtilities)
            vAppName = My.Settings.ApplicationName
            vVersionNumber = My.Settings.ApplicationVersion
            vCopyrightYear = My.Settings.CopyrightYear
            vClientName = My.Settings.ClientName

            vDatabaseType = My.Settings.DatabaseType
            vDatabaseName = My.Settings.DatabaseName

            vSQLServerUserName = My.Settings.SQLDatabaseUserName
            vSQLServerUserPassword = My.Settings.SQLDatabaseUserPassword
            vSQLServerDatabaseName = My.Settings.DatabaseName
            vSQLServerDatabaseServerName = My.Settings.SQLDatabaseServerName

            vUpdatesDirectory = My.Settings.UpdatesLocation

            vPerformLoginFunction = My.Settings.UseLoginSecurity
            vUserName = My.Settings.LastUserLogin

            vUserTableName = My.Settings.UserTableName
            vUserLoginFieldName = My.Settings.UserLoginFieldName
            vUserFullNameFieldName = My.Settings.UserFullNameFieldName
            vUserPasswordFieldName = My.Settings.UserPasswordFieldName
            vUserSecurityLevelFieldName = My.Settings.UserSecurityLevelFieldName
 
            lblCopyright.Text = "Copyright © " & vCopyrightYear & " " & vClientName


            Select Case vDatabaseName
                Case "AOSData"
                    Me.Text = vAppName & " " & vVersionNumber
                Case "AOSTest"
                    Me.Text = "AOS - TEST SYSTEM"
                Case "AOSDev"
                    Me.Text = "AOS - DEVELOPMENT SYSTEM"
            End Select


            Return "SUCCESS"

        Catch ex As Exception
            Dim mStr As String
            mStr = "The application configuration settings file is corrupt or does not exist."
            mStr = mStr & Chr(13) & Chr(13)
            mStr = mStr & "You must see your System Administrator for assistance."
            MsgBox(mStr, MsgBoxStyle.Critical, "Fatal Error")
            Return "FAILED"
        End Try

    End Function


    Private Sub ConnectionStart()
        connectToDatabase(vSQLServerDatabaseServerName)
    End Sub

    Public Sub connectToDatabase(ByVal sName As String)
        Dim strcnn As String
        Dim qstr As String
        Dim vContinue As String
        Dim vSave As Boolean
        vContinue = ""
        msgNet.Text = "Attempting to connect to database...Please wait"
        Application.DoEvents()
        qstr = "Database connection failed. Do you want to try again?"

        'create connection string to test
        strcnn = "User ID=" & vSQLServerUserName
        strcnn = strcnn & ";Password=" & vSQLServerUserPassword
        strcnn = strcnn & ";Initial Catalog=" & vSQLServerDatabaseName
        strcnn = strcnn & ";Data Source=" & sName
        sqlcnn.ConnectionString = strcnn
        Try
            sqlcnn.Open()
            'connection succeeds!
            boxG.Visible = True
            boxG.BringToFront()
            msgNet.Text = String.Concat("  Connected to SQL Server ", My.Settings.SQLDatabaseServerName, " - ", My.Settings.DatabaseName)

            If (My.Settings.DatabaseName = "AOSDev") Then
                msgNet.BackColor = Color.Beige
            ElseIf (My.Settings.DatabaseName = "AOSTest") Then
                msgNet.BackColor = Color.Bisque
            End If

            Application.DoEvents()
            AppDomain.CurrentDomain.SetData("DatabaseConnectionString", "Provider=SQLOLEDB.1;" & sqlcnn.ConnectionString & ";Password=" & vSQLServerUserPassword)
            AppDomain.CurrentDomain.SetData("Database", sName)
            vContinue = "Connected"
            If sName <> vSQLServerDatabaseServerName Then
                vSave = True
            End If
        Catch ex As Exception
            'connection fails
            If MsgBox(qstr, MsgBoxStyle.YesNo, "SQL Server Connection Failed") = MsgBoxResult.No Then
                'pnet.BackColor = Color.Red
                boxR.Visible = True
                boxR.BringToFront()
                msgNet.Text = "SQL Server connection failed."
                Application.DoEvents()
                vContinue = "Exit App"
            Else
                'pnet.BackColor = Color.Yellow
                BoxY.Visible = True
                BoxY.BringToFront()
                vContinue = "Get New SQL Server Connection"
            End If
        Finally
            sqlcnn.Close()
        End Try

        'process results
        Me.grpSQLServerDatabase.Visible = False
        Select Case vContinue
            Case "Connected"
                If vSave Then
                    saveNewSettings(sName)
                    vSave = False
                End If
                gcConnectionStatus.Text = "Connected to " & My.Settings.DatabaseName.ToUpper
                showLogin()
            Case "Exit App"
                MsgBox("Can't login with no database connection.", MsgBoxStyle.Critical, "Fatal Error")
                Me.Close()
            Case "Get New SQL Server Connection"
                'display panel to allow user to enter a new network server name
                Me.grpSQLServerDatabase.Visible = True
                editSQLServerName.Focus()
        End Select

    End Sub

    Private Sub saveNewSettings(ByVal vSetting As String)
        My.Settings.SQLDatabaseServerName = vSetting
        My.Settings.Save()
        vSQLServerDatabaseServerName = vSetting
        connectToDatabase(vSetting)
    End Sub

    Private Sub showLogin()
        If vPerformLoginFunction Then
            'display panel to allow user to login to application
            grpUserLogin.Visible = True
            Me.editUserName.Focus()
        Else
            vValidLogin = True
            Me.Close()
        End If
    End Sub

    Private Function validateLogin(ByVal userLogin As String, ByVal password As String) As Boolean

        Dim cmdA As New SqlClient.SqlCommand
        Dim strA As String
        Dim strB As String
        Dim vResult As String
        Dim vLevel As Integer

        vResult = ""
        vLevel = 0

        strA = "SELECT "
        strA &= vUserFullNameFieldName & " FROM "
        strA &= vUserTableName & " WHERE ("
        strA &= vUserLoginFieldName & " = '" & userLogin & "' AND "
        strA &= vUserPasswordFieldName & " = '" & password & "')"

        strB = "SELECT "
        strB &= vUserSecurityLevelFieldName & " FROM "
        strB &= vUserTableName & " WHERE ("
        strB &= vUserLoginFieldName & " = '" & userLogin & "' AND "
        strB &= vUserPasswordFieldName & " = '" & password & "')"

        'get user full name from user table - if succeeds, successful login
        Try
            sqlcnn.Open()
            cmdA = New SqlClient.SqlCommand(strA, sqlcnn)
            vResult = cmdA.ExecuteScalar()
            cmdA = New SqlClient.SqlCommand(strB, sqlcnn)
            vLevel = cmdA.ExecuteScalar()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            sqlcnn.Close()
        End Try

        If vResult <> "" Then       'user found
            return setUserInfo(userLogin) 
        Else
            Return False
        End If
    End Function

    Private Function setUserInfo(vLogin As String) As Boolean

        Dim oUser As New Appuser
        oUser.Query.Where(oUser.Query.Userlogin.Equal(vLogin))
        If Not oUser.Query.Load() Then
            MsgBox("Severe Error - User information cannot be retrieved from system", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        'check USERSTATUS value - IF INACTIVE, do not allow login
        If oUser.Userstatus = "INACTIVE" Then
            Return False
        End If

        'assign new seesionid and session date
        oUser.Sessionid = System.Guid.NewGuid.ToString
        oUser.Logindatetime = Now
        oUser.Save()

        vCurrentUserID = oUser.Appuserid
        vCurrentUserLogin = oUser.Userlogin
        vCurrentUserFullName = oUser.Userfullname
        vCurrentUserSecurityLevel = oUser.Usersecuritylevel
        vSessionID = oUser.Sessionid

        Return True

    End Function

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If validateLogin(Me.editUserName.Text, Me.editPassword.Text) Then
            'user is valid and authorized
            vValidLogin = True
            Me.Close()
        Else
            MsgBox("Login attempt failed. Please try again.", MsgBoxStyle.Critical, "ERROR")
            editUserName.Text = ""
            editPassword.Text = ""
            editUserName.Focus()
        End If
    End Sub

    Private Sub btnCancelLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelLogin.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub btnConnectSQLServer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnectSQLServer.Click
        connectToDatabase(editSQLServerName.Text)
    End Sub

    Private Sub frmStart_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = My.Settings.SkinName
    End Sub
End Class