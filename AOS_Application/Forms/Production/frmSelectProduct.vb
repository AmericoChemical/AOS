Public Class frmSelectProduct
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oProducts As ProductCollection
    Public vProductID As Integer

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        vProductID = bsProducts.Current.ProductID
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getData()
    End Sub

    Private Sub getData()
        oProducts = New ProductCollection
        oProducts.Query.Where(oProducts.Query.Productstatus.NotEqual("INACTIVE"))
        oProducts.Query.Load()
        oProducts.Sort = "ProductDesc, Container"
        bsProducts.DataSource = oProducts
    End Sub
End Class