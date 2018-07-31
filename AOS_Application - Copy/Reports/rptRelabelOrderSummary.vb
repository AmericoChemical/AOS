Imports AOS.BusinessObjects

Public Class rptRelabelOrderSummary
    Public Sub New(ByVal sdate As Date, ByVal edate As Date)

        InitializeComponent()

        fillDataSet(sdate, edate)
        lblDateRange.Text = "For Period from " & sdate.ToShortDateString & " to " & edate.ToShortDateString

    End Sub

    Private Sub fillDataSet(ByVal vSdate As Date, ByVal vEdate As Date)
        Dim oRelabelOrders As New ViewRelabelOrderCollection
        oRelabelOrders.Query.Where(oRelabelOrders.Query.Neededby.Between(vSdate, vEdate), oRelabelOrders.Query.Relabelorderstatus.Equal("COMPLETED"))
        oRelabelOrders.Query.Load()
        bs.DataSource = oRelabelOrders
    End Sub

End Class