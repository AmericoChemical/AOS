Imports AOS.BusinessObjects

Public Class rptInvoiceHistorical

    Public Sub New(ByVal vInvNum As Integer)

        InitializeComponent()

        fillDataSet(vInvNum)

    End Sub

    Private Sub fillDataSet(ByVal vInvHistoryId As Integer)

        Dim oRpt As New ViewRptInvoiceHistoricalCollection
        oRpt.Query.Where(oRpt.Query.Invoicehistoryid.Equal(vInvHistoryId))
        If Not oRpt.Query.Load Then
            MsgBox("Could not retrieve report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If
        oRpt.Sort = "Taxable DESC"
        bsRpt.DataSource = oRpt
    End Sub


End Class