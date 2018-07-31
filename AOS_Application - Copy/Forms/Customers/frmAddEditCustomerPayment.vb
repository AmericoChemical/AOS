Imports AOS.BusinessObjects

Public Class frmAddEditCustomerPayment
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vCustID As Integer

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Customer Payment"

    'here is where you dimension your object variables for the form
    Dim oCustPmt As Customerpayment
    Dim oCustomer As Customer
    Dim oUnpaidInv As InvoiceCollection
    Dim oPaidInv As InvoicepaymentCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadCustomer(vCustID)
        loadUnpaidInvoices(vCustID)
        loadPaidInvoices(vID)
        loadData()
    End Sub

    Private Sub loadCustomer(ByVal vCustID As Integer)
        oCustomer = New Customer
        oCustomer.LoadByPrimaryKey(vCustID)
        bsCustomer.DataSource = oCustomer
    End Sub

    Private Sub loadUnPaidInvoices(ByVal vCustID As Integer)
        oUnpaidInv = New InvoiceCollection
        oUnpaidInv.Query.Where(oUnpaidInv.Query.Custid.Equal(vCustID), oUnpaidInv.Query.Invoicestatus.Equal("RECEIVABLE"))
        oUnpaidInv.Query.Load()
        bsUnpaidInvoices.DataSource = oUnpaidInv
    End Sub

    Private Sub loadPaidInvoices(ByVal vPmtID As Integer)
        oPaidInv = New InvoicepaymentCollection
        oPaidInv.Query.Where(oPaidInv.Query.Customerpmtid.Equal(vPmtID))
        oPaidInv.Query.Load()
        bsInvoicePayments.DataSource = oPaidInv
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oCustPmt = New Customerpayment
        oCustPmt.AddNew()
        'assign foreign key values here
        oCustPmt.Custid = vCustID
        oCustPmt.Paymentdate = Today
        oCustPmt.Save()
        Me.bsCustomerPayment.DataSource = oCustPmt
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oCustPmt = New Customerpayment
        oCustPmt.LoadByPrimaryKey(vID)
        Me.bsCustomerPayment.DataSource = oCustPmt
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsCustomerPayment.EndEdit()
            oCustPmt.Balance = oCustPmt.Paymentamount - getSumOfInvoicePmts(oCustPmt.Customerpmtid)
            oCustPmt.EndEdit()
            oCustPmt.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsCustomerPayment.CancelEdit()
            oCustPmt.CancelEdit()
            If vEditType = "ADD" Then
                Dim str As String = "Are you sure you want to cancel (reverse) this customer payment? This will UNDO all Invoice Payments as well."
                If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Cancel Request") = MsgBoxResult.No Then
                    Return False
                End If
                If Not reverseCustomerPayment(bsCustomerPayment.Current.CustomerPmtID) Then
                    Return False
                End If
            End If
        Catch ex As Exception
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

    Private Function getSumOfInvoicePmts(ByVal vCustPmtID As Integer) As Decimal

        Dim str As String = "SELECT SUM(InvoicePmtAmount) FROM InvoicePayment WHERE CustomerPmtID = " & vCustPmtID.ToString & " GROUP BY CustomerPmtID"
        Dim rtv As Decimal = 0
        Dim cmd As SqlClient.SqlCommand

        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            rtv = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox("Error retrieving sum of invoice payments for this customer payment", MsgBoxStyle.Critical, "Error - Invoice Payments")
            Return 0
        Finally
            sqlcnn.Close()
        End Try

        Return rtv

    End Function


    Private Function getSumOfInvoicePmtsByInvoiceNumber(ByVal vInvNum As Integer) As Decimal

        Dim str As String = "SELECT (SUM(InvoicePmtAmount)+ SUM(InvoiceDiscount)) as InvoiceCredit FROM InvoicePayment WHERE InvoiceNumber = " & vInvNum.ToString & " GROUP BY InvoiceNumber"
        Dim rtv As Decimal = 0
        Dim cmd As SqlClient.SqlCommand

        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            rtv = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox("Error retrieving sum of invoice payments and discounts for the selected invoice", MsgBoxStyle.Critical, "Error - Invoice Payments")
            Return 0
        Finally
            sqlcnn.Close()
        End Try

        Return rtv

    End Function

    Private Sub btnAllocatePaymentToInvoice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAllocatePaymentToInvoice.Click

        If bsUnpaidInvoices.Count <= 0 Then
            Exit Sub
        End If

        'get balance left on customer payment to determine amount available to allocate to selected invoice
        Dim vCustPmtID As Integer = oCustPmt.Customerpmtid
        If vCustPmtID <= 0 Then
            MsgBox("Error in Customer Payment ID")
            Exit Sub
        End If
        Dim vInvNum As Integer = bsUnpaidInvoices.Current.InvoiceNumber
        If vInvNum <= 0 Then
            MsgBox("Error in invoice number")
            Exit Sub
        End If

        Dim vAllocate As Decimal = 0
        Dim vInvTotal As Decimal = Math.Round(bsUnpaidInvoices.Current.Total, 2)
        vAllocate = bsCustomerPayment.Current.PaymentAmount - getSumOfInvoicePmts(vCustPmtID)
        Select Case vAllocate
            Case Is <= 0 'no money left to allocate
                MsgBox("The customer payment has been fully allocated.", MsgBoxStyle.Critical, "Error - Payment Allocated in Full")
                Exit Sub
            Case Is > vInvTotal 'more than enough money left to allocate fully to selected invoice
                vAllocate = vInvTotal  'to prevent over allocation to an invoice
            Case Is = vInvTotal  'exactly enough to fully allocate to the selected invoice
            Case Is < vInvTotal 'not enough money to fully allocate to the invoice selected
                'If MsgBox("Partial Allocation Only" & Chr(13) & Chr(13) & "Do you want to allocate $" & vAllocate.ToString & " to the selected invoice?", MsgBoxStyle.YesNo, "Confirm Partial Allocation") = MsgBoxResult.No Then
                '    Exit Sub
                'End If
        End Select

        'at this point, we have an amount to allocate to the select invoice
        'display a form to show a recap of what we are about to do:
        'if vAllocate is exactly equal to invoicetotal then show invoice payment and no discount
        'if vAllocate is less that invoicetotal then show vAllocate value for invoice payment
        'and the difference as a potential credit to the invoice (usually for paying within terms)
        'but can be used for other adjustments as well (enter a note for details if necessary)
        Dim vFrmInvPmtAllocation As New frmInvoicePmtAllocation
        vFrmInvPmtAllocation.vAllocateAmt = vAllocate
        vFrmInvPmtAllocation.vInvID = vInvNum
        vFrmInvPmtAllocation.vCustPmtID = vCustPmtID
        vFrmInvPmtAllocation.vEditType = "ADD"
        vFrmInvPmtAllocation.ShowDialog()

        'create an invoice payment record
        'Dim vPmt As Invoicepayment = New Invoicepayment
        'vPmt.Invoicenumber = vInvNum
        'vPmt.Customerpmtid = vCustPmtID
        'vPmt.Invoicepmtamount = vAllocate
        'vPmt.Save()

        'determine if invoice has been fully paid, and if so, close it out and mark any commissions associated with the invoice as payable
        If vInvTotal <= getSumOfInvoicePmtsByInvoiceNumber(vInvNum) Then
            Dim oInv As Invoice
            oInv = New Invoice
            If oInv.LoadByPrimaryKey(vInvNum) Then
                oInv.Invoicestatus = "PAID"
                oInv.Save()
            End If

            Dim oComms As CommissionCollection
            oComms = New CommissionCollection
            oComms.Query.Where(oComms.Query.Invoicenumber.Equal(vInvNum))
            If oComms.Query.Load Then
                'there are commission records for the select invoice
                For Each oComm As Commission In oComms
                    If oComm.Commissionstatus <> "PAID" Then
                        oComm.Commissionstatus = "PAYABLE"
                    End If
                Next
                oComms.Save()
            End If
        End If

        oCustPmt.Balance = oCustPmt.Paymentamount - getSumOfInvoicePmts(oCustPmt.Customerpmtid)
        bsCustomerPayment.DataSource = oCustPmt
        loadUnPaidInvoices(vCustID)
        loadPaidInvoices(vCustPmtID)

    End Sub

    Private Function reverseCustomerPayment(vPmtID As Integer) As Boolean

        Dim oCustPmt As New Customerpayment
        Dim oInvPmts As New InvoicepaymentCollection

        'get Customer Payment record
        oCustPmt = New Customerpayment
        If Not oCustPmt.LoadByPrimaryKey(vPmtID) Then
            Return False
        End If

        'get collection of Invoice Payment records
        oInvPmts = New InvoicepaymentCollection
        oInvPmts.Query.Where(oInvPmts.Query.Customerpmtid.Equal(vPmtID))
        If oInvPmts.Query.Load Then
            If oInvPmts.Count > 0 Then
                'Invoice Payments were recorded to the database for the Customer Payment we are trying to reverse
                For Each oInvPmt As Invoicepayment In oInvPmts

                    'We will assume that be deleting an invoice payment as part of the customer payment
                    'we are also reversing the status of the INVOICE and COMMISSION records related to
                    'the INVOICEPAYMENT record being deleted
                    updateInvoiceStatus(oInvPmt.Invoicenumber, "RECEIVABLE")
                    updateCommissionStatus(oInvPmt.Invoicenumber, "PENDING")
                    oInvPmt.MarkAsDeleted()
                Next
                oInvPmts.Save()
            End If
        End If

        'now delete the Customer Payment record itself
        oCustPmt.MarkAsDeleted()
        oCustPmt.Save()

        Return True

    End Function

    Private Sub updateInvoiceStatus(vInvoiceNum As Integer, vStatus As String)
        Dim oInv As New Invoice
        If oInv.LoadByPrimaryKey(vInvoiceNum) Then
            oInv.Invoicestatus = vStatus
            oInv.Save()
        End If
    End Sub

    Private Sub updateCommissionStatus(vInvoiceNum As Integer, vStatus As String)
        Dim oComms As New CommissionCollection
        oComms.Query.Where(oComms.Query.Invoicenumber.Equal(vInvoiceNum))
        If oComms.Query.Load Then
            If oComms.Count > 0 Then
                For Each oComm As Commission In oComms
                    oComm.Commissionstatus = vStatus
                Next
                oComms.Save()
            End If
        End If
    End Sub

End Class