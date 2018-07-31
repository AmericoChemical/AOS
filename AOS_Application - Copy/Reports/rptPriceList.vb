Imports AOS.BusinessObjects

Public Class rptPriceList

    Public Sub New(ByVal vCustomerID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vCustomerID)
    End Sub

    Private Sub getdata(ByVal vCustomerID As Integer)

        Dim oPriceList As New ViewCustomerPriceListCollection
        oPriceList.Query.Where(oPriceList.Query.Custid.Equal(vCustomerID))
        If Not oPriceList.Query.Load Then
            MsgBox("Error retrieving Price List Data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.bsPriceList.DataSource = oPriceList

    End Sub

End Class