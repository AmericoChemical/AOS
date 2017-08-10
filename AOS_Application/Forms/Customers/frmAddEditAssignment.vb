Imports AOS.BusinessObjects

Public Class frmAddEditAssignment
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
    Friend vObjectName As String = "Salesperson Customer Assignment"

    'here is where you dimension your object variables for the form
    Dim oAssignment As Customerassignment
    Dim oCustomers As CustomerCollection
    Dim oSales As SalespersonCollection
    Dim oCommTypes As ListCommissiontypeCollection
    Dim oProducts As ProductCollection
    Dim oExceptions As CommissionexceptionCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupData()
        loadData()
    End Sub

    Private Sub loadLookupData()

        oCustomers = New CustomerCollection
        oCustomers.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oCustomers.LoadAll()
        Me.bsCustomers.DataSource = oCustomers

        oSales = New SalespersonCollection
        oSales.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oSales.LoadAll()
        Me.bsSalespersons.DataSource = oSales

        oCommTypes = New ListCommissiontypeCollection
        oCommTypes.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oCommTypes.LoadAll()
        Me.bsCommTypes.DataSource = oCommTypes

        oProducts = New ProductCollection
        oProducts.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProducts.LoadAll()
        Me.bsProducts.DataSource = oProducts
    End Sub

    Private Sub loadExceptions(ByVal vCustAssignID As Integer)
        oExceptions = New CommissionexceptionCollection
        oExceptions.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oExceptions.Query.Where(oExceptions.Query.CustAssignID.Equal(vCustAssignID))
        oExceptions.Query.Load()
        bsExceptions.DataSource = oExceptions
        Me.grExceptions.DataSource = bsExceptions
        Me.grExceptions.Refresh()
        If oExceptions.Count <= 0 Then
            btnEditException.Enabled = False
            btnDeleteException.Enabled = False
        Else
            btnEditException.Enabled = True
            btnDeleteException.Enabled = True
        End If
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oAssignment = New Customerassignment
        oAssignment.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oAssignment.AddNew()
        oAssignment.SalespersonID = vFKID
        oAssignment.EndEdit()
        oAssignment.BeginEdit()
        Me.bs.DataSource = oAssignment
        loadExceptions(bs.Current.CustAssignID)
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oAssignment = New Customerassignment
        oAssignment.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oAssignment.LoadByPrimaryKey(vID)
        Me.bs.DataSource = oAssignment
        loadExceptions(bs.Current.CustAssignID)
    End Sub

    Private Function changesSaved() As Boolean
        bs.EndEdit()
        oAssignment.EndEdit()
        oAssignment.Save()
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bs.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oAssignment.MarkAsDeleted()
                oAssignment.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnCancelAssignment_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelAssignment.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnSaveAssignment_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveAssignment.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnAddException_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddException.ItemClick
        addException()
    End Sub

    Private Sub btnEditException_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditException.ItemClick
        editException()
    End Sub

    Private Sub btnDeleteException_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteException.ItemClick
        deleteException()
    End Sub

    Private Sub editException()
        Dim frm As New frmAddEditCommissionException
        frm.vID = Me.bsExceptions.Current.ExceptionID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadExceptions(bs.Current.CustAssignid)
    End Sub

    Private Sub addException()
        oAssignment.EndEdit()
        oAssignment.Save()
        Dim frm As New frmAddEditCommissionException
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        frm.vFKID = Me.bs.Current.CustAssignID
        vResult = frm.ShowDialog()
        loadExceptions(bs.Current.CustAssignid)
    End Sub

    Private Sub deleteException()
        Dim str As String
        str = "Are you sure you want to delete the selected Commission Exception record?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Dim oEx As Commissionexception
            oEx = New Commissionexception
            oEx.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            oEx.LoadByPrimaryKey(bsExceptions.Current.ExceptionID)
            oEx.MarkAsDeleted()
            oEx.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        loadExceptions(bs.Current.CustAssignid)
    End Sub

    
End Class