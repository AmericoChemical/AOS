Imports AOS.BusinessObjects

Public Class frmAuditReason

    Public vAuditReason As String
    Public vFlagSaved As Boolean
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Function changesSaved() As Boolean
        vAuditReason = Me.AuditReasonTextEdit.Text
        vFlagSaved = True
        Return True
    End Function

    Private Sub frmAuditReason_Load(sender As Object, e As EventArgs) Handles Me.Load
        vAuditReason = String.Empty
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Function changesCancelled() As Boolean
        Try
            vAuditReason = String.Empty
        Catch ex As Exception
        End Try
        Return True
    End Function

End Class