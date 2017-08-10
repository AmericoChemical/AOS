Public Class rptLoadDataWgtByClass

    Public Sub New()
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata()
    End Sub

    Public Sub getdata()

        Dim oRpt As New ViewRptBillOfLadingWgtByClassCollection
        oRpt.LoadAll()
        oRpt.Sort = "ClassRate"
        bsRpt.DataSource = oRpt

    End Sub
End Class