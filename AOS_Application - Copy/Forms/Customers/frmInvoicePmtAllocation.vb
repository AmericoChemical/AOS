Imports AOS.BusinessObjects

Public Class frmInvoicePmtAllocation
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer           'object primary key (passed in by calling form for edit mode)
    Public vInvID As Integer        'the invoice number to be paid
    Public vAllocateAmt As Decimal  'the amount of customer payment to be allocated to this invoice
    Public vCustPmtID As Integer    'the master customer payment id for this transaction
    Public vEditType As String      'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.) you are adding/editing
    Friend vObjectName As String = "Invoice Payment Allocation"

    'here is where you dimension your object variables for the form
    Dim oItem As Invoicepayment
    Dim oInv As Invoice
    Dim oCust As Customer


    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = String.Format("Adding New {0}", vObjectName)
        Else
            Me.Text = String.Format("Editing {0} Information", vObjectName)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()

        'first, retrieve invoice record to be paid and related customer record
        Try
            oInv = New Invoice
            oInv.LoadByPrimaryKey(vInvID)
            bsInvoice.DataSource = oInv
        Catch ex As Exception
            MsgBox("Could not retrieve Invoice record", MsgBoxStyle.Critical, "Error")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try

        Try
            oCust = New Customer
            oCust.LoadByPrimaryKey(oInv.Custid)
            bsCustomer.DataSource = oCust
        Catch ex As Exception
            MsgBox("Could not retrieve Customer record referenced by invoice to be paid", MsgBoxStyle.Critical, "Error")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try

        'Assuming we have all the lookup info records, set the data items in
        'the ribbon bar
        eCustomerName.Caption = oCust.Custname
        eInvoiceNumber.Caption = oInv.Invoicenumber
        eInvoiceDate.Caption = oInv.Invoicedate

        'Now call up the invoice payment record under the requested action type
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        Try
            oItem = New Invoicepayment
            oItem.AddNew()
            'assign foreign key values here
            oItem.Invoicenumber = vInvID
            oItem.Invoicepmtamount = vAllocateAmt
            oItem.Customerpmtid = vCustPmtID
            If oInv.Total > vAllocateAmt Then
                'assign the difference to the invoicepayment discount field
                oItem.Invoicediscount = oInv.Total - vAllocateAmt
                'assign the default reason for the discount
                oItem.Discountreason = "Payment terms"
            Else
                oItem.Invoicediscount = 0
            End If
            oItem.Save()
            Me.bsItem.DataSource = oItem
        Catch ex As Exception
            MsgBox("There was an error in creating the invoice payment record", MsgBoxStyle.Critical, "Error")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If

        'retrieve the requested record from the database
        Try
            oItem = New Invoicepayment
            oItem.LoadByPrimaryKey(vID)
            Me.bsItem.DataSource = oItem
        Catch ex As Exception
            MsgBox("Could not retrieve requested record from database", MsgBoxStyle.Critical, "Edit Failed")
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End Try
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsItem.EndEdit()
            oItem.EndEdit()
            oItem.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsItem.CancelEdit()
            oItem.CancelEdit()
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error cancelling changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub


End Class