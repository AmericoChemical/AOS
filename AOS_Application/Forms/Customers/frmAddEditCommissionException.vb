Imports AOS.BusinessObjects

Public Class frmAddEditCommissionException
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
    Friend vObjectName As String = "Commission Exception"

    'here is where you dimension your object variables for the form
    Dim oEx As Commissionexception
    Dim oProducts As ProductCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadProducts()
        loadData()
    End Sub

    Private Sub loadProducts()
        oProducts = New ProductCollection
        oProducts.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProducts.LoadAll()
        Me.bsProducts.DataSource = oProducts
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oEx = New Commissionexception
        oEx.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oEx.AddNew()
        oEx.CustAssignID = vFKID
        oEx.EndEdit()
        oEx.BeginEdit()
        Me.bs.DataSource = oEx
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oEx = New Commissionexception
        oEx.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oEx.LoadByPrimaryKey(vID)
        Me.bs.DataSource = oEx
    End Sub

    Private Function changesSaved() As Boolean
        bs.EndEdit()
        oEx.EndEdit()
        oEx.Save()
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bs.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oEx.MarkAsDeleted()
                oEx.Save()
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
End Class