Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Data
Imports System.IO
Imports EntitySpaces.Interfaces
Imports DevExpress.XtraEditors

Friend Class Program
    Public Shared goodLogin As Boolean
    Public Shared allowUpdates As Boolean
    Public Shared updateDir As String
    Public Shared updVer As String
    Public Shared updDir As String
    Public Shared currVer As String
    Public Shared esProviderFactory As EntitySpaces.Interfaces.esProviderFactory

    Private Sub New()
    End Sub

    <STAThread()> _
    Shared Sub Main()

        InitializeDotNetApplication()
        If CheckForApplicationUpdates() Then
            'if update version and current application version don't match
            'then run the AppUpdater application to close this app and copy
            'the correct files to the user's application directory
            'The AppUpdater will then run this application again and close itself

            Dim UpdateAppName As String
            'UpdateAppName = Application.StartupPath & "\AppUpdater2005.exe"
            UpdateAppName = Application.StartupPath & "\AppUpdateMgr.exe"
            Dim ProcID As Integer
            ProcID = Shell(UpdateAppName, AppWinStyle.NormalFocus)
            Exit Sub
        End If
        RunApplication()
    End Sub

    Private Shared Sub InitializeDotNetApplication()

        'initialize the data providers from Entity Spaces
        InitializeEntitySpacesServices()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        'initialize skin libraries from DevExpress
        DevExpress.UserSkins.BonusSkins.Register()
        'DevExpress.UserSkins.OfficeSkins.Register()

        'Revert default behavior to DevExpress Version 16
        WindowsFormsSettings.DefaultSettingsCompatibilityMode = SettingsCompatibilityMode.v16
    End Sub

    Private Shared Sub InitializeEntitySpacesServices()
        esProviderFactory.Factory = New EntitySpaces.LoaderMT.esDataProviderFactory
    End Sub

    Private Shared Function CheckForApplicationUpdates() As Boolean
        'read appUpdateMgrSettings.txt file to determine current installed version and update folder location
        'read version.txt file in update folder location to determine latest software version available
        'if versions are different, return TRUE - run appUpdateMgr program
        'if versions are same, then return FALSE - do not run appUpdateMgr program


        'Dim oFile As System.IO.File = Nothing
        Dim oRead As System.IO.StreamReader
        Dim appDir As String
        Dim appName As String
        Dim appAssembly As String
        Dim currVersion As String
        Dim currLastUpdated As String
        Dim updFileLocationPath As String
        Dim updVersion As String

        Try
            appDir = Application.StartupPath
            oRead = File.OpenText(appDir & "\AppUpdateMgrSettings.txt")
            appName = oRead.ReadLine
            appAssembly = oRead.ReadLine
            currVersion = oRead.ReadLine
            currLastUpdated = oRead.ReadLine
            updFileLocationPath = oRead.ReadLine()
            oRead.Close()

            appName = appName.Substring(10, appName.Length - 10)
            appAssembly = appAssembly.Substring(10, appAssembly.Length - 10)
            currVersion = currVersion.Substring(10, currVersion.Length - 10)
            currLastUpdated = currLastUpdated.Substring(10, currLastUpdated.Length - 10)
            updFileLocationPath = updFileLocationPath.Substring(10, updFileLocationPath.Length - 10)

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Could not read the AppUpdateMgrSettings.txt file. Please see your Systems Administrator", MsgBoxStyle.Critical, "Error - Can not read Config file")
            Return False
        End Try

        If appAssembly Is Nothing Then
            MsgBox("Main application assembly name not found. Please correct the Application Update Manager settings.", MsgBoxStyle.Critical, "Error - Settings not valid")
            Return False
        End If

        If Not Directory.Exists(updFileLocationPath) Then
            MsgBox("Update directory not found. Please correct the Application Update Manager settings.", MsgBoxStyle.Critical, "Error - Settings not valid")
            Return False
        End If

        'attempt to open and read the update version number from the version.txt file in the update files location path folder
        'Dim aFile As System.IO.File = Nothing
        Dim aRead As System.IO.StreamReader
        Dim updPublishedDate As String
        Try
            aRead = File.OpenText(updFileLocationPath & "\version.txt")
            'the first two lines of the version.txt file in the updates folder will be the new version number and the published date
            updVersion = aRead.ReadLine()
            updPublishedDate = aRead.ReadLine()
            aRead.Close()
        Catch ex As Exception
            MsgBox("Path to update files was not found. Please correct the Application Update Manager settings.", MsgBoxStyle.Critical, "Error - Settings not valid")
            Return False
        End Try

        If updVersion Is Nothing Then
            MsgBox("Update version was not found. Updates cancelled", MsgBoxStyle.Critical, "Error - No update version")
            Return False
        End If

        My.Settings.ApplicationVersion = updVersion
        My.Settings.Save()

        'Compare update version to current application version
        If currVersion = updVersion Then
            'there is no new update available
            Return False
        Else
            'there is a new update available
            'update the current program settings for application version
            My.Settings.ApplicationVersion = updVersion
            My.Settings.Save()
            Return True
        End If


    End Function



    Private Shared Sub RunApplication()
        goodLogin = False
        Dim fs As New frmStart
        'show frmStartup, which gets all database connection information and validates user login
        'if the process is completed, return value will be DialogResult.OK, else close app
        fs.ShowDialog()
        If vValidLogin = True Then
            System.Windows.Forms.Application.Run(New frmMain)
        End If
    End Sub

End Class
