Imports AOS.BusinessObjects

Public Class frmAuditPricing

    Public vAuditlogIDs() As Integer

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Enum AuditLogStatus
        OPEN
        INPROGRESS
        CLOSED
    End Enum

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        SetFormTitle()
    End Sub


    Private Sub SetFormTitle()
        Me.Text = String.Format("Audit Price - Resolving {0} record(s)", vAuditlogIDs.Length)
    End Sub

    Private Sub btnResolveIssue_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResolveIssue.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub
    Private Function changesSaved() As Boolean
        Dim oAuditlog As Auditlog
        For Each vAuditlogID As Integer In vAuditlogIDs
            oAuditlog = New Auditlog
            oAuditlog.LoadByPrimaryKey(vAuditlogID)
            oAuditlog.Status = AuditLogStatus.Closed.ToString()
            oAuditlog.Resolved = System.DateTime.Now
            oAuditlog.Resolvedby = vCurrentUserLogin
            oAuditlog.EndEdit()
            oAuditlog.Save()
        Next
        Return True
    End Function

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

   
End Class