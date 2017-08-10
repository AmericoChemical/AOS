Imports AOS.BusinessObjects

Public Class rptProductsShipped

    Public Sub New(ByVal vStartDate As DateTime, vEndDate As DateTime)
        InitializeComponent()
        fillDataSet(vStartDate, vEndDate)
    End Sub

    Private Sub fillDataSet(ByVal vStartDate As DateTime, vEndDate As DateTime)
        Dim oRpt As New ViewRptShippingHistoryCollection
        oRpt.Query.Where(oRpt.Query.Shipmentdate.Between(vStartDate, vEndDate))
        oRpt.Query.Load()
        Me.bsShippingHistory.DataSource = oRpt
    End Sub

End Class