Imports AOS.BusinessObjects

Public Class rptCommissionsByCustomer


    Public Sub New(ByVal vSalespersonID As Integer, ByVal vCustomerID As Integer, ByVal vBeginDate As Date, ByVal vEndDate As Date)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vSalespersonID, vCustomerID, vBeginDate, vEndDate)
    End Sub

    Private Sub getdata(ByVal vSalesPersonID As Integer, ByVal vCustomerID As Integer, ByVal vBeginDate As Date, ByVal vEndDate As Date)
        Dim vComm As New ViewCommissionsCollection
        vComm.Query.Where(vComm.Query.Custid.Equal(vCustomerID), vComm.Query.Commissiondate.Between(vBeginDate, vEndDate), vComm.Query.Commissionamount.NotEqual(0))
        vComm.Query.Load()
        Me.DataSource = vComm
    End Sub

End Class