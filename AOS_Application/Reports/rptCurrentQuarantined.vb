Imports AOS.BusinessObjects

Public Class rptCurrentQuarantined

    Public Sub New()
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata()
    End Sub

    Private Sub getdata()

        Dim oRpt As New ViewCurrentPhysicalInventoryCollection
        oRpt.Query.Where(oRpt.Query.Itemstatus.Equal("QUARANTINED"))
        If Not oRpt.Query.Load Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.bsRpt.DataSource = oRpt

    End Sub

End Class