Imports AOS.BusinessObjects

Public Class frmAddEditCommission
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vCommID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vSalesID As Integer     'foreign key values (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Sales Commission"

    'here is where you dimension your object variables for the form
    Dim oComm As Commission
    Dim oCustomers As CustomerCollection
    Dim oSales As SalespersonCollection
    Dim oCommTypes As ListCommissioncategoryCollection
    Dim oInvoices As InvoiceCollection


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
        oCustomers.LoadAll()
        Me.bsCustomers.DataSource = oCustomers

        oSales = New SalespersonCollection
        oSales.LoadAll()
        Me.bsSalespersons.DataSource = oSales

        oCommTypes = New ListCommissioncategoryCollection
        oCommTypes.LoadAll()
        Me.bsCommCategories.DataSource = oCommTypes

        oInvoices = New InvoiceCollection
        oInvoices.LoadAll()
        bsInvoices.DataSource = oInvoices

    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vCommID)
        End If
    End Sub

    Private Sub addNewObject()
        oComm = New Commission
        oComm.AddNew()
        oComm.Salespersonid = vSalesID
        oComm.Commissionstatus = "PENDING"
        oComm.Commissiondate = Today
        oComm.EndEdit()
        oComm.BeginEdit()
        oComm.Save()
        Me.bs.DataSource = oComm
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oComm = New Commission
        oComm.LoadByPrimaryKey(vID)
        Me.bs.DataSource = oComm
    End Sub

    Private Function changesSaved() As Boolean
        bs.EndEdit()
        oComm.EndEdit()
        oComm.Save()

        If oComm.Commissiondesc Is Nothing Then
            MsgBox("You must enter a Description", MsgBoxStyle.Critical, "Error - No Description")
            Return False
        End If
        If oComm.Commissioncategory Is Nothing Then
            MsgBox("You must enter a Category", MsgBoxStyle.Critical, "Error - No Category")
            Return False
        End If
        If oComm.Commissionamount = 0 Then
            MsgBox("You must enter a Commission Amount", MsgBoxStyle.Critical, "Error - No Commission Amount")
            Return False
        End If

        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bs.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oComm.MarkAsDeleted()
                oComm.Save()
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

   
End Class