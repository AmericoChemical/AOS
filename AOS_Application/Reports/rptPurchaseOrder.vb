Imports AOS.dsPurchaseOrderTableAdapters
Imports AOS.BusinessObjects

Public Class rptPurchaseOrder

    Public Sub New(ByVal vPONum As Integer)

        InitializeComponent()

        fillDataSet(vPONum)

    End Sub

    Private Sub fillDataSet(ByVal vPONum As Integer)

        Dim dt As New dsPurchaseOrder.PurchaseOrderDataTable
        Dim da As New dsPurchaseOrderTableAdapters.PurchaseOrderTableAdapter

        Try
            dt = da.GetData(vPONum)
        Catch ex As Exception

        End Try

        Me.DataSource = dt

    End Sub


End Class