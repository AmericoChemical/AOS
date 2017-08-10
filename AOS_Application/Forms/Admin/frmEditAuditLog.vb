Imports AOS.BusinessObjects

Public Class frmEditAuditLog


    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vAuditlogid As Integer
    Public vAddtype As String

    Dim oItem As New Auditlog

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadAuditLog()
    End Sub

    Private Sub loadAuditLog()
        If vAuditlogid = Nothing Then
            MsgBox("There is no Audit Log selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If

        oItem.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oItem.LoadByPrimaryKey(vAuditlogid)
        Me.bsAuditLog.DataSource = oItem
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsAuditLog.EndEdit()
            oItem.Resolved = System.DateTime.Now
            oItem.Resolvedby = vCurrentUserLogin
            oItem.EndEdit()
            oItem.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsAuditLog.CancelEdit()
            oItem.CancelEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error cancelling changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

End Class