Imports AOS.BusinessObjects

Public Class rptInvoiceHistory
    Public Sub New(ByVal sdate As Date, ByVal edate As Date)

        InitializeComponent()

        fillDataSet(sdate, edate)
        lblDateRange.Text = "For Period from " & sdate.ToShortDateString & " to " & edate.ToShortDateString

    End Sub

    Private Sub fillDataSet(ByVal sdate As Date, ByVal edate As Date)

        Dim vStart As Date = sdate
        Dim vEnd As Date = CDate(edate.ToShortDateString & " 23:59:59")

        Dim oItems As New ViewRptInvoiceHistoryCollection
        oItems.Query.Where(oItems.Query.Invoicedate.Between(vStart, vEnd))
        oItems.Query.Load()
        bs.DataSource = oItems

    End Sub

End Class