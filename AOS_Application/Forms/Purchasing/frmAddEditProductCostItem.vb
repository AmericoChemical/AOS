Imports AOS.BusinessObjects

Public Class frmAddEditProductCostItem

    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vFKID As Integer     'foreign key values (passed in by calling form for add mode)
    Public vFKID2 As Integer    'foreign key values (passed in by calling form for add mode)
    Public vFKID3 As Integer    'foreign key values (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Product Cost Item"

    'here is where you dimension your object variables for the form
    Friend oEntity As New Productcost
    Friend oProductList As New ProductCollection
    Friend oVendorlist As New VendorCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
        loadProductList()
        loadVendorList()
    End Sub

    Private Sub loadProductList()
        oProductList.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProductList.LoadAll()
        bsProductList.DataSource = oProductList
    End Sub

    Private Sub loadVendorList()
        oVendorlist.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oVendorlist.LoadAll()
        bsVendorList.DataSource = oVendorlist
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        If vFKID = Nothing Then
            MsgBox("There is no Vendor ID selected", MsgBoxStyle.Critical, "Add New Record Failed")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        oEntity.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oEntity.AddNew()
        oEntity.Vendorid = vFKID
        oEntity.EndEdit()
        oEntity.BeginEdit()
        Me.bs.DataSource = oEntity
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
        oEntity.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oEntity.LoadByPrimaryKey(vID)
        Me.bs.DataSource = oEntity
        eProductID.Properties.ReadOnly = True
        eProductID.Properties.Buttons(0).Visible = False
    End Sub

    Private Function changesSaved() As Boolean
        bs.EndEdit()
        oEntity.EndEdit()
        oEntity.Save()
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bs.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oEntity.MarkAsDeleted()
                oEntity.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub eProductID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eProductID.EditValueChanged
        getProductInfo(eProductID.EditValue)
        Me.UnitpriceTextEdit.Focus()
    End Sub

    Private Sub getProductInfo(ByVal vProductID As Integer)

        Dim str As String = "SELECT a.ProductID, a.Container, b.Units, b.UOM " _
            & "FROM Product a, Container b WHERE a.Container = b.Container and " _
            & "a.ProductID = " & vProductID.ToString
        Dim da As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Try
            da = New SqlClient.SqlDataAdapter(str, sqlcnn)
            da.Fill(ds, "ProductInfo")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        If ds.Tables(0).Rows.Count > 0 Then
            bs.Current.ProductID = vProductID
            bs.Current.Container = ds.Tables(0).Rows(0).Item("Container")
            bs.Current.Uom = ds.Tables(0).Rows(0).Item("UOM")
            bs.Current.Units = ds.Tables(0).Rows(0).Item("Units")
            Me.ContainerTextEdit.Text = bs.Current.container
            Me.UomTextEdit.Text = bs.Current.UOM
            Me.UnitsTextEdit.Text = bs.Current.units
        End If

    End Sub
End Class