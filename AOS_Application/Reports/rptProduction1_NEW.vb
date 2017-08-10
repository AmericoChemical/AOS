Imports AOS.BusinessObjects

Public Class rptProduction1_NEW
    Public Sub New(ByVal sdate As Date, ByVal edate As Date)

        InitializeComponent()

        fillDataSet(sdate, edate)
        Me.lblDateRange.Text = "For Period from " & sdate.ToShortDateString & " to " & edate.ToShortDateString
        Me.lblTotals.Text = "Totals for Period from " & sdate.ToShortDateString & " to " & edate.ToShortDateString

    End Sub

    Private Sub fillDataSet(ByVal sdate As Date, ByVal edate As Date)

        Dim oRpt As New ViewRptInventoryProfitAndLossAnalysisCollection
        oRpt.Query.Where(oRpt.Query.Workorderdate.Between(sdate, edate))
        If Not oRpt.Query.Load Then
            MsgBox("Could not retrieve report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        bsrpt.datasource = oRpt
    End Sub

End Class