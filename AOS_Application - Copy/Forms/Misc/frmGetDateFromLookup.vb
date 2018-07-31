Public Class frmGetDateFromLookup
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vType As String
    Public vRefID As Integer  'for Commissions, this is SalespersonID
    Public vDatePicked As Date


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Select Case vType
            Case "COMMISSIONPAYMENTDATES"
                If IsDBNull(eDate.EditValue) Or eDate.EditValue = Nothing Then
                    MsgBox("You must select a Commission Payment Date from the list", MsgBoxStyle.Critical, "Error - No Date Selected")
                    Exit Sub
                End If
                vDatePicked = eDate.EditValue
        End Select
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        getData()
    End Sub

    Private Sub getData()

        Select Case vType
            Case "COMMISSIONPAYMENTDATES"
                eDate.Visible = True
                Dim oCommDates As New ViewCommissionPaymentDatesCollection
                oCommDates.Query.Where(oCommDates.Query.Salespersonid.Equal(vRefID))
                If Not oCommDates.Query.Load() Then
                    MsgBox("No Commission Payment Dates found for the selected Salesperson.", MsgBoxStyle.Critical, "Error - No Data")
                    Me.Close()
                End If
                bsDateList.DataSource = oCommDates
        End Select

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class