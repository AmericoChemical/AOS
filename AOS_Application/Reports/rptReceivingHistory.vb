Imports AOS.BusinessObjects

Public Class rptReceivingHistory
    Public Sub New(ByVal sdate As Date, ByVal edate As Date)

        InitializeComponent()

        fillDataSet(sdate, edate)
        lblDateRange.Text = "For Period from " & sdate.ToShortDateString & " to " & edate.ToShortDateString

    End Sub

    Private Sub fillDataSet(ByVal sdate As Date, ByVal edate As Date)

        Using oItems As New ViewInvItemReceiverInfoCollection()
            oItems.Query.Where(oItems.Query.Receiveddate.Between(sdate, edate))
            oItems.Query.Load()
            DataSource = oItems
        End Using

    End Sub

End Class