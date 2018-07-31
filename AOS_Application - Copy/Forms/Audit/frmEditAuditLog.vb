Imports AOS.BusinessObjects

Public Class frmEditAuditLog


    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer
    Public vAuditlogIDs() As Integer
    Public vAddtype As String

    Dim oItem As New Auditlog

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadAuditLog()
        SetFormTitle()
    End Sub

    Private Sub SetFormTitle()
        Me.Text = String.Format("Audit Log Information - Editing {0} record(s)", vAuditlogIDs.Length)
    End Sub

    Private Sub loadAuditLog()
        If vID = Nothing Then
            MsgBox("There is no Audit Log selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If

        oItem.LoadByPrimaryKey(vID)
        Me.bsAuditLog.DataSource = oItem

        Dim oAuditCategory = New AuditcategoryCollection 
        oAuditCategory.LoadAll() 
        bsAuditcategory.DataSource = oAuditCategory

        btnResolveIssue.Enabled = (oItem.Status <> Status.CLOSED.ToString())
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
            If vAuditlogIDs.Length > 1 Then
                Dim oAuditlog As Auditlog
                For Each vAuditlogID As Integer In vAuditlogIDs
                    oAuditlog = New Auditlog
                    oAuditlog.LoadByPrimaryKey(vAuditlogID)
                    oAuditlog.Status = oItem.Status
                    oAuditlog.Resolution = oItem.Resolution
                    oAuditlog.Resolved = System.DateTime.Now
                    oAuditlog.Resolvedby = vCurrentUserLogin
                    oAuditlog.EndEdit()
                    oAuditlog.Save()
                Next
            Else
                oItem.Resolved = System.DateTime.Now
                oItem.Resolvedby = vCurrentUserLogin
                oItem.EndEdit()
                oItem.Save()
            End If
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

    Private Sub btnResolveIssue_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResolveIssue.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Using frm As New frmAuditPricing() With
            {.vAuditlogIDs = vAuditlogIDs}
            frm.ShowDialog()
        End Using
    End Sub
End Class