Imports AOS.dsPurchaseOrderTableAdapters
Imports AOS.BusinessObjects

Public Class rptPOItemList

    Public Sub New(ByVal vPONum As Integer)

        InitializeComponent()
        fillDataSet(vPONum)

    End Sub

    Private Sub fillDataSet(ByVal vPONum As Integer)

        Dim dt As New dsPurchaseOrder.PurchaseOrderDataTable
        Dim da As New dsPurchaseOrderTableAdapters.PurchaseOrderTableAdapter

        Dim oList As New ViewRptPOItemListCollection
        Try
            oList.Query.Where(oList.Query.Ponumber.Equal(vPONum))
            oList.Query.Load()
            Me.DataSource = oList
        Catch ex As Exception

        End Try

    End Sub


End Class