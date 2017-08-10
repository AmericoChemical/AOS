Imports AOS.BusinessObjects
Imports Microsoft.ReportingServices
Imports Microsoft.Reporting
Imports AOS.dsHazMatLabelTableAdapters


Public Class frmRptProductLabel

    Public vProductId As Integer
    Public vLot As String
    Public vRes As String

    Private Sub frmRptProductLabel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'dsHazMatLabel.HazMatLabel' table. You can move, or remove it, as needed.
        'Me.HazMatLabelTableAdapter.FillHazMatLabel(Me.dsHazMatLabel.HazMatLabel)
        Dim tbl As New HazMatLabelTableAdapter
        Dim dt As New AOS.dsHazMatLabel.HazMatLabelDataTable
        Try
            tbl.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            tbl.FillHazMatLabel(dt, vLot, vRes, vProductId)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Me.HazMatLabelBindingSource.DataSource = dt
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class