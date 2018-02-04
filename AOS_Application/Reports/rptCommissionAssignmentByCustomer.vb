Imports AOS.BusinessObjects

Public Class rptCommissionAssignmentByCustomer


    Public Sub New(ByVal vCustomerID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vCustomerID)
    End Sub

    Private Sub getdata(ByVal vCustomerID As Integer)
        If IsDBNull(vCustomerID) Or vCustomerID = Nothing Then
            Exit Sub
        End If

        Dim vComm As New ViewCustomerCommissionAssignmentsCollection
        vComm.Query.Where(vComm.Query.Custid.Equal(vCustomerID))
        vComm.Query.Load()
        Me.DataSource = vComm
    End Sub

End Class