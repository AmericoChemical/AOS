
'All the variables for the session referred to in the code in this
'form module are defined and instantiated in the AppSession module
'so they become available to the entire application

Public Class frmStart_OLD


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If getApplicationSettings() = "FAILED" Then
            MsgBox("Application Settings Not Available", MsgBoxStyle.Critical, "Critical Failure")
            Me.Close()
        End If

        lblAppName.Text = vAppName & " " & vVersionNumber
        lblCopyright.Text = "Copyright © " & vCopyrightYear & " " & vClientName
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

            vAccessDatabasePassword = My.Settings.MSAccessDatabasePassword

            vSQLServerUserName = My.Settings.SQLDatabaseUserName
            vSQLServerUserPassword = My.Settings.SQLDatabaseUserPassword
            vSQLServerDatabaseName = My.Settings.DatabaseName
            vSQLServerDatabaseServerName = My.Settings.SQLDatabaseServerName

            vPerformUpdatesFunction = My.Settings.UseUpdates
            vUpdatesDirectory = My.Settings.UpdatesLocation

            vPerformLoginFunction = My.Settings.UseLoginSecurity
            vUserName = My.Settings.LastUserLogin

            vUserTableName = My.Settings.UserTableName
            vUserLoginFieldName = My.Settings.UserLoginFieldName
            vUserFullNameFieldName = My.Settings.UserFullNameFieldName
            vUserPasswordFieldName = My.Settings.UserPasswordFieldName
            vUserSecurityLevelFieldName = My.Settings.UserSecurityLevelFieldName

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
            msgNet.Text = "Connected to SQL Server Database."
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

    Private Sub saveNewSettings(ByVal vSetting As String)
        My.Settings.SQLDatabaseServerName = vSetting
        My.Settings.Save()
        vSQLServerDatabaseServerName = vSetting
        connectToDatabase(vSetting)
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
            vCurrentUserFullName = vResult   'set session variables
            vCurrentUserLogin = userLogin
            vCurrentUserSecurityLevel = vLevel
            Return True
        Else
            Return False
        End If
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

    Private Sub frmStart_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = My.Settings.SkinName
    End Sub
End Class