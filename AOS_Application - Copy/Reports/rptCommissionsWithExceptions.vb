Imports AOS.BusinessObjects

Public Class rptCommissionsWithExceptions

    Public Sub New(ByVal vSalespersonID As Integer, ByVal vCommissionStatus As String, Optional vPaidDate As Date = Nothing)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vSalespersonID, vCommissionStatus, vPaidDate)
    End Sub

    Private Sub getdata(ByVal vSalesPersonID As Integer, ByVal vCommissionStatus As String, Optional vPaidDate As Date = Nothing)

        'Get commissions totals for report summary
        Dim vCommTotal As New ViewCommissionDetailCollection
        Dim vComm As New ViewCommissionDetailReportCollection

        If vPaidDate = Nothing Then
            vComm.Query.Where(vComm.Query.Salespersonid.Equal(vSalesPersonID), vComm.Query.Commissionstatus.Equal(vCommissionStatus))
            vCommTotal.Query.Where(vCommTotal.Query.Salespersonid.Equal(vSalesPersonID), vCommTotal.Query.Commissionstatus.Equal(vCommissionStatus))
            'Make standard Commission Status heading objects invisble
            rLStatusHeading.Visible = True
            xlCommissionStatus.Visible = True
            xlStatusLine.Visible = True
            rlPayableCommissionRptHeader.Visible = False
        Else
            'Make standard Commission Status heading objects invisble
            rLStatusHeading.Visible = False
            xlCommissionStatus.Visible = False
            xlStatusLine.Visible = False
            rlPayableCommissionRptHeader.Visible = True
            rlPayableCommissionRptHeader.Text = "PAYABLE ON: " + vPaidDate.ToShortDateString
            vComm.Query.Where(vComm.Query.Salespersonid.Equal(vSalesPersonID), vComm.Query.Commissionstatus.Equal(vCommissionStatus), vComm.Query.Datecommissionpaid.Equal(vPaidDate))
            vCommTotal.Query.Where(vCommTotal.Query.Salespersonid.Equal(vSalesPersonID), vCommTotal.Query.Commissionstatus.Equal(vCommissionStatus), vCommTotal.Query.Datecommissionpaid.Equal(vPaidDate))
        End If
        vComm.Query.Load()
        vCommTotal.Query.Load()

        'Add up commission totals
        Dim vTot As Decimal = 0.00
        For Each vCommission As ViewCommissionDetail In vCommTotal
            vTot = vTot + vCommission.Commissionamount
        Next
        xlTotalCommissions.Text = Format(vTot, "c2")

        Me.DataSource = vComm
        If vPaidDate = Nothing Then
        Else
            xlCommissionStatus.Text = "PAYABLE"
        End If


    End Sub

End Class