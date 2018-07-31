Imports AOS.BusinessObjects

Public Class rptCustomerPmtByDate

    Public Sub New(Optional ByVal vDate As Date = #10/1/2009#)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vDate)
    End Sub

    Private Sub getdata(ByVal vDate As Date)
        Dim vPmt As New ViewCustomerPaymentInfoCollection
        vPmt.Query.Where(vPmt.Query.Paymentdate.Equal(vDate))
        vPmt.Query.Load()
        Me.DataSource = vPmt
    End Sub

End Class