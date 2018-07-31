Imports AOS.BusinessObjects

Public Class frmSelectProduct

    Public vID As Integer
    Public vDesc As String
    Public vContainer As String
    Public vGallons As Integer
    Public vWeight As Integer


    'here is where you dimension your object variables for the form
    Dim oProducts As New ProductCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pictOperation.Image = Me.ImageList1.Images(0)
        Caption.Text = "Select a Product"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        oProducts = New ProductCollection
        oProducts.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProducts.LoadAll()
        Me.bsProducts.DataSource = oProducts
    End Sub

    Private Sub btnSaveChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChanges.Click
        vID = bsProducts.Current.ProductID
        vDesc = bsProducts.Current.ProductDesc
        vContainer = bsProducts.Current.Container
        vGallons = bsProducts.Current.StdGallons
        vWeight = bsProducts.Current.stdweight
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelChanges.Click
        vID = 0
        vDesc = ""
        vContainer = ""
        vGallons = 0
        vWeight = 0
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


End Class