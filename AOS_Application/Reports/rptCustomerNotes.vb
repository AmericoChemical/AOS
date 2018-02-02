Imports AOS.BusinessObjects

Public Class rptCustomerNotes

    Public Sub New(ByVal vCustID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vCustID)
    End Sub

    Private Sub getdata(ByVal vCustID As Integer)
        Dim oCust As New CustomerCollection
        oCust.Query.Where(oCust.Query.Custid.Equal(vCustID))
        oCust.Query.Load()
        Me.DataSource = oCust
    End Sub

End Class