Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid

Module AppSession

    Public mMainForm As frmMain

    Public vAppName As String
    Public vUserName As String
    Public vCopyrightYear As String
    Public vClientName As String
    Public vDatabaseType As String
    Public vDatabaseName As String
    Public vVersionNumber As String
    Public vUpdatesDirectory As String
    Public vAccessDatabasePassword As String
    Public vSQLServerUserName As String
    Public vSQLServerUserPassword As String
    Public vSQLServerDatabaseName As String
    Public vSQLServerDatabaseServerName As String
    Public vPerformUpdatesFunction As Boolean
    Public vPerformLoginFunction As Boolean
    Public vValidLogin As Boolean = False
    Public vUserTableName As String
    Public vUserFullNameFieldName As String
    Public vUserLoginFieldName As String
    Public vUserPasswordFieldName As String
    Public vUserSecurityLevelFieldName As String

    'These session variables are assigned values throught the processes on the frmStart form
    Public vCurrentUserID As Integer
    Public vCurrentUserLogin As String
    Public vCurrentUserFullName As String
    Public vSessionID As String
    Public vCurrentUserSecurityLevel As Integer
    Public sqlcnn As New SqlClient.SqlConnection
    Public olecnn As New OleDb.OleDbConnection

End Module
