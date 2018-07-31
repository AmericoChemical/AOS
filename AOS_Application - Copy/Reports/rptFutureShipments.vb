Imports AOS.BusinessObjects

Public Class rptFutureShipments
    Public Sub New()

        InitializeComponent()
        fillDataSet()

    End Sub

    Private Sub fillDataSet()

        Dim oRpt As New ViewRptFutureShipmentsCollection

        Try
            If Not oRpt.Query.Load Then
                MsgBox("Could not load data for this report", MsgBoxStyle.Critical, "Error - Data Not Found")
                Me.ClosePreview()
            End If
            bsRpt.DataSource = oRpt

        Catch ex As Exception
            MsgBox("There was an error retrieving data", MsgBoxStyle.Critical, "Error - Data Not Retrieved")
            Me.ClosePreview()
        End Try

    End Sub

End Class