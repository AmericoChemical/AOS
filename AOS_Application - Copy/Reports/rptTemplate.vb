Imports AOS.BusinessObjects

Public Class rptTemplate
    Public Sub New(vAPISNum As Integer)

        InitializeComponent()
        fillDataSet(vAPISNum)

    End Sub

    Private Sub fillDataSet(vAPISNum As Integer)

        Dim oAPIS As ViewAPISData

        Try
            oAPIS = New ViewAPISData
            oAPIS.Query.Where(oAPIS.Query.Apisnum.Equal(vAPISNum))
            If Not oAPIS.Query.Load Then
                MsgBox("Could not load data for this report", MsgBoxStyle.Critical, "Error - Data Not Found")
                Me.ClosePreview()
            End If
            bsRpt.DataSource = oAPIS

        Catch ex As Exception
            MsgBox("There was an error retrieving data", MsgBoxStyle.Critical, "Error - Data Not Retrieved")
            Me.ClosePreview()
        End Try

    End Sub

End Class