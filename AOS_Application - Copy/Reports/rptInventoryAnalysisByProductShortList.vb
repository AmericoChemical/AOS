Imports AOS.BusinessObjects

Public Class rptInventoryAnalysisByProductShortList


    Public Sub New()
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata()
    End Sub

    Private Sub getdata()

        Dim oRpt As New ViewInventoryAnalysisByProductCollection
        oRpt.Query.Where(oRpt.Query.Inventorygrouping.Equal(9))
        If Not oRpt.Query.Load Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.bsRpt.DataSource = oRpt

    End Sub

End Class