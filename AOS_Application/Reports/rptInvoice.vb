Imports AOS.BusinessObjects

Public Class rptInvoice

    Public Sub New(ByVal vInvNum As Integer)

        InitializeComponent()

        fillDataSet(vInvNum)

    End Sub

    Private Sub fillDataSet(ByVal vInvNum As Integer)

        Dim oRpt As New ViewRptInvoice2Collection
        oRpt.Query.Where(oRpt.Query.Invoicenumber.Equal(vInvNum))
        If Not oRpt.Query.Load Then
            MsgBox("Could not retrieve report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If
        oRpt.Sort = "Taxable DESC"
        bsRpt.DataSource = oRpt
    End Sub


End Class