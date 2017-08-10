Imports AOS.BusinessObjects

Public Class rptAPIS
    Public Sub New(vAPISNum As Integer)

        InitializeComponent()
        fillDataSet(vAPISNum)

    End Sub

    Private Sub fillDataSet(vAPISNum As Integer)

        Dim oAPIS As ViewAPISData
        Dim oMaterial As ViewAPISITEMDataCollection
        Dim oProcs As ApisprocedureCollection
        Dim oNotes As ApisnoteCollection

        Try
            oAPIS = New ViewAPISData
            oAPIS.Query.Where(oAPIS.Query.Apisnum.Equal(vAPISNum))
            If Not oAPIS.Query.Load Then
                MsgBox("Could not load data for this report", MsgBoxStyle.Critical, "Error - Data Not Found")
                Me.ClosePreview()
            End If
            bsAPIS.DataSource = oAPIS

            oMaterial = New ViewAPISITEMDataCollection
            oMaterial.Query.Where(oMaterial.Query.Apisnum.Equal(vAPISNum))
            oMaterial.Query.Load()
            bsAPISMaterial.DataSource = oMaterial

            oProcs = New ApisprocedureCollection
            oProcs.Query.Where(oProcs.Query.Apisnum.Equal(vAPISNum))
            oProcs.Query.Load()
            bsAPISProcs.DataSource = oProcs

            oNotes = New ApisnoteCollection
            oNotes.Query.Where(oNotes.Query.Apisnum.Equal(vAPISNum))
            oNotes.Query.Load()
            bsAPISNotes.DataSource = oNotes

        Catch ex As Exception
            MsgBox("There was an error retrieving data", MsgBoxStyle.Critical, "Error - Data Not Retrieved")
            Me.ClosePreview()
        End Try

    End Sub

End Class