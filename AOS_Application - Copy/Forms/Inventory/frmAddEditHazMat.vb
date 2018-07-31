Imports AOS.BusinessObjects

Public Class frmAddEditHazmat

    Public vID As Integer
    Public vEditType As String
    Dim oProduct As Product
    Dim oContainers As ContainerCollection
    Dim oLabels As HazmatsymbolCollection

    Private Sub frmAddEditProduct_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Header.Image = Me.ImageList1.Images(0)
            Caption.Text = "Adding New Product"
        Else
            Header.Image = Me.ImageList1.Images(1)
            Caption.Text = "Editing Product Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'loadData()
    End Sub

    Private Sub loadData()
        oContainers = New ContainerCollection
        oContainers.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oContainers.LoadAll()
        bsContainers.DataSource = oContainers

        oLabels = New HazmatsymbolCollection
        oLabels.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oLabels.LoadAll()
        bsLabels.DataSource = oLabels

        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oProduct = New Product
        oProduct.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProduct.AddNew()
        oProduct.Save()
        vID = oProduct.Productid.Value
        Me.mProductBS.DataSource = oProduct

    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oProduct = New Product
        oProduct.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProduct.LoadByPrimaryKey(vID)
        Me.mProductBS.DataSource = oProduct
    End Sub

    Private Sub btnSaveChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChanges.Click
        mProductBS.EndEdit()
        oProduct.EndEdit()
        oProduct.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelChanges.Click
        oProduct.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oProduct.MarkAsDeleted()
                oProduct.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub



End Class