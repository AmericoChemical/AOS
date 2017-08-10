Imports AOS.BusinessObjects

Public Class rptProductionOrderSummary
    Public Sub New(ByVal sdate As Date, ByVal edate As Date)

        InitializeComponent()

        fillDataSet(sdate, edate)
        lblDateRange.Text = "For Period from " & sdate.ToShortDateString & " to " & edate.ToShortDateString

    End Sub

    Private Sub fillDataSet(ByVal sdate As Date, ByVal edate As Date)

        Dim oItems As New ViewRptProductionOrderSummaryCollection
        oItems.Query.Where(oItems.Query.Receiveddate.Between(sdate, edate))
        oItems.Query.Load()
        bs.DataSource = oItems

    End Sub

End Class