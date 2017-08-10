Imports AOS.BusinessObjects

Public Class rptTotalInventoryByProduct

    Public Sub New()
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata()
    End Sub

    Private Sub getdata()

        Dim oRpt As New ViewRptTotalInventoryByProductCollection
        If Not oRpt.LoadAll Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.bsRpt.DataSource = oRpt

    End Sub


End Class