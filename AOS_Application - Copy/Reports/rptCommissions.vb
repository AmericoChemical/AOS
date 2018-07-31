Imports AOS.BusinessObjects

Public Class rptCommissions


    Public Sub New(ByVal vSalespersonID As Integer, ByVal vCommissionStatus As String, Optional vPaidDate As Date = Nothing)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vSalespersonID, vCommissionStatus, vPaidDate)
    End Sub

    Private Sub getdata(ByVal vSalesPersonID As Integer, ByVal vCommissionStatus As String, Optional vPaidDate As Date = Nothing)
        Dim vComm As New ViewCommissionsCollection
        If vPaidDate = Nothing Then
            vComm.Query.Where(vComm.Query.Salespersonid.Equal(vSalesPersonID), vComm.Query.Commissionstatus.Equal(vCommissionStatus))
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
        End If
        vComm.Query.Load()
        Me.DataSource = vComm
        If vPaidDate = Nothing Then
        Else
            xlCommissionStatus.Text = "PAYABLE"
        End If
    End Sub

End Class