Imports AOS.dsPurchaseOrderTableAdapters
Imports AOS.BusinessObjects

Public Class rptDirectPurchaseOrder2

    Public Sub New(ByVal vPONum As Integer)

        InitializeComponent()

        fillDataSet(vPONum)

    End Sub

    Private Sub fillDataSet(ByVal vPONum As Integer)

        Dim oRptPO As New ViewRptDirectPurchaseOrders2Collection

        oRptPO.Query.Where(oRptPO.Query.Ponumber.Equal(vPONum))
        oRptPO.Query.Load()
        bsPurchaseOrder.DataSource = oRptPO

    End Sub


End Class