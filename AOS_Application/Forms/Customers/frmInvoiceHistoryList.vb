Imports AOS.BusinessObjects

Public Class frmInvoiceHistoryList

    Public vInvoiceNum As Integer

    Dim oInvoiceHistoryHeaders As InvoicehistoryheaderCollection
    Dim oInvoiceHistoryId As Integer

    Private Sub frmInvoiceHistoryList_Load(sender As Object, e As EventArgs) Handles Me.Load
        GroupControl1.Text = "Select History Record for Invoice#: " & vInvoiceNum
        oInvoiceHistoryHeaders = New InvoicehistoryheaderCollection
        oInvoiceHistoryHeaders.Query.Where(oInvoiceHistoryHeaders.Query.Invoicenumber = vInvoiceNum And oInvoiceHistoryHeaders.Query.Changecommitted = True)
        If oInvoiceHistoryHeaders.Query.Load Then
            oInvoiceHistoryHeaders.Sort = "InvoiceHistoryId Desc"
            bsInvoiceHistoryHeader.DataSource = oInvoiceHistoryHeaders
        Else
            MessageBox.Show("No Invoice History Found.")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub rbtnSelectHistoricalInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSelectHistoricalInvoice.ItemClick
        If bsInvoiceHistoryHeader.Count > 0 Then
            Dim frmViewInvHistory As New frmViewInvoiceHistory

            frmViewInvHistory.vInvoiceHistoryId = bsInvoiceHistoryHeader.Current.InvoiceHistoryId

            frmViewInvHistory.ShowDialog()
        End If
    End Sub

    Private Sub rbtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rbtnPrintInvoiceHistorical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintInvoiceHistorical.ItemClick
        If (bsInvoiceHistoryHeader.Current IsNot Nothing) Then
            Dim rpt As New rptInvoiceHistorical(bsInvoiceHistoryHeader.Current.InvoiceHistoryId)
            rpt.ShowPreview()
        End If
    End Sub
End Class