Public Class rptLoadDataWgtByDOTNumber

    Public Sub New()
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata()
    End Sub

    Public Sub getdata()

        Dim oRpt As New ViewRptBillOfLadingWgtByIDNumberCollection
        oRpt.LoadAll()
        oRpt.Sort = "DOTIDNumber"
        bsRpt.DataSource = oRpt

    End Sub
End Class