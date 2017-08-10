
Imports AOS.BusinessObjects

Public Class frmAddEditInvoice
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vInvoiceNum As Integer
    Public vEditType As String
    Dim oCust As Customer

    Dim oInvoice As Invoice
    Dim oItems As InvoiceitemCollection
    Dim oProducts As ProductCollection
    Dim oCustomers As CustomerCollection
    Dim oSales As SalespersonCollection
    Dim oCarriers As CarrierCollection
    Dim oFOB As ListFobCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getProducts()
        getCustomers()
        getSales()
        getCarriers()
        getFOB()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vInvoiceNum)
            'If oInvoice.Invoicestatus <> "PENDING" Then
            '    rpgInvoiceItems.Visible = False
            'End If
        End If
    End Sub

    Private Sub addNewObject()
        oInvoice = New Invoice
        oInvoice.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oInvoice.AddNew()
        oInvoice.Invoicedate = Today
        oInvoice.Invoicestatus = "PENDING"
        oInvoice.Save()
        vInvoiceNum = oInvoice.Invoicenumber.Value
        oInvoice.Invnumview = oInvoice.Invoicenumber
        eInvoiceNumber.EditValue = vInvoiceNum
        oInvoice.EndEdit()
        bsInvoice.DataSource = oInvoice
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oInvoice = New Invoice
        oInvoice.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oInvoice.LoadByPrimaryKey(vID)
        bsInvoice.DataSource = oInvoice
        getInvoiceItems(vID)
    End Sub


    Private Sub getInvoiceItems(ByVal vID As Integer)
        oItems = New InvoiceitemCollection
        oItems.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oItems.Query.Where(oItems.Query.Invoicenumber.Equal(vID))
        oItems.Query.Load()
        Try
            bsInvoiceItems.DataSource = oItems
            grItems.DataSource = bsInvoiceItems
            grItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        getInvoiceTotals()
    End Sub

    Private Sub getFOB()
        oFOB = New ListFobCollection
        oFOB.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oFOB.LoadAll()
        bsFOB.DataSource = oFOB
    End Sub

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProducts.LoadAll()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub getCustomers()
        oCustomers = New CustomerCollection
        oCustomers.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oCustomers.LoadAll()
        oCustomers.Sort = "CUSTNAME"
        bsCustomers.DataSource = oCustomers
    End Sub

    Private Sub getCarriers()
        oCarriers = New CarrierCollection
        oCarriers.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oCarriers.LoadAll()
        oCarriers.Sort = "CARRIERNAME"
        bsCarriers.DataSource = oCarriers
    End Sub

    Private Sub getSales()
        oSales = New SalespersonCollection
        oSales.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oSales.LoadAll()
        bsSales.DataSource = oSales
    End Sub

    Private Sub getInvoiceTotals()
        'determine invoice subtotal
        oInvoice.BeginEdit()
        oInvoice.Subtotal = getInvoiceItemsTotal(oInvoice.Invoicenumber)
        'determine invoice sales tax
        oInvoice.Salestax = getInvoiceSalesTax(oInvoice.Invoicenumber)
        'determine invoice totals
        oInvoice.Total = oInvoice.Subtotal + oInvoice.Salestax
        oInvoice.EndEdit()
        oInvoice.Save()
        eSubtotal.EditValue = oInvoice.Subtotal
        eSalesTax.EditValue = oInvoice.Salestax
        eTotal.EditValue = oInvoice.Total
    End Sub

    Private Function getSalesTaxRate() As Decimal
        Dim oParms As New Sysparameters
        If oParms.LoadByPrimaryKey(1) Then
            Return oParms.DefaultSalesTaxRate
        Else
            Return 0
        End If
    End Function

    Private Function getInvoiceItemsTotal(ByVal vInvNum As Integer) As Decimal
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand = Nothing
        Dim vResult As Decimal = 0.0
        Dim vSubTotal As Decimal = 0.0
        Try
            str = "SELECT SUM(EXTPRICE) FROM INVOICEITEM WHERE INVOICENUMBER = " & vInvNum.ToString
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            sqlcnn.Open()
            vResult = cmd.ExecuteScalar
            vSubTotal = Math.Round(vResult, 2, MidpointRounding.AwayFromZero)
        Catch ex As Exception
            MsgBox("Error in calculating Invoice Subtotals for Invoice # " & vInvNum.ToString, MsgBoxStyle.Critical, "Error - No Subtotal")
            Return 0
        Finally
            sqlcnn.Close()
        End Try
        sqlcnn.Close()
        Return vSubTotal
    End Function
    Private Function getInvoiceSalesTax(ByVal vInvNum As Integer) As Decimal
        'Lookup customer assigned to invoice to determine if customer is tax exempt
        If getTaxStatus(oInvoice.Custid) Then 'customer is tax exempt
            Return 0.0
        End If

        'assume customer is NOT tax exempt
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand = Nothing
        Dim vResult As Decimal = 0.0
        Dim vTax As Decimal = 0.0
        Try
            'get the subtotal for items that are taxable
            str = "SELECT SUM(EXTPRICE) FROM INVOICEITEM WHERE INVOICENUMBER = " & vInvNum.ToString & " AND TAXABLE = 1"
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            sqlcnn.Open()
            vResult = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
            vTax = Math.Round((vResult * getSalesTaxRate()), 2, MidpointRounding.AwayFromZero)
        Catch ex As Exception
            MsgBox("Error in calculating Invoice Sales Tax for Invoice # " & vInvNum.ToString, MsgBoxStyle.Critical, "Error - No Sales Tax")
            Return 0
        Finally
            sqlcnn.Close()
        End Try
        sqlcnn.Close()
        Return vTax
    End Function

    Private Sub addItem()
        Dim frm As New frmAddEditInvoiceItemProduct
        frm.vFKID = Me.bsInvoice.Current.InvoiceNumber
        frm.vCustID = Me.bsInvoice.Current.CustID
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        frm.vTaxExempt = getTaxStatus(Me.bsInvoice.Current.CustID)
        vResult = frm.ShowDialog()
        getInvoiceItems(vInvoiceNum)
    End Sub
    Private Sub addMiscCharge()
        Dim frm As New frmAddEditInvoiceMiscItem
        frm.vFKID = Me.bsInvoice.Current.InvoiceNumber
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        vResult = frm.ShowDialog()
        getInvoiceItems(vInvoiceNum)
    End Sub

    Private Sub editItem()
        If bsInvoiceItems.Count <= 0 Then
            Exit Sub
        End If
        If bsInvoiceItems.Current.UOM = "MISC" Then
            Dim frmMisc As New frmAddEditInvoiceMiscItem
            frmMisc.vID = Me.bsInvoiceItems.Current.InvoiceItemNumber
            frmMisc.vFKID = Me.bsInvoice.Current.InvoiceNumber
            frmMisc.vEditType = "EDIT"
            frmMisc.ShowDialog()
        Else
            Dim frm As New frmAddEditInvoiceItemProduct
            frm.vID = Me.bsInvoiceItems.Current.InvoiceItemNumber
            frm.vFKID = Me.bsInvoice.Current.InvoiceNumber
            frm.vCustID = Me.bsInvoice.Current.CustID
            frm.vTaxExempt = getTaxStatus(Me.bsInvoice.Current.CustID)
            frm.vEditType = "EDIT"
            frm.ShowDialog()
        End If
        getInvoiceItems(vInvoiceNum)
    End Sub

    Private Sub deleteItem()
        If bsInvoiceItems.Count <= 0 Then
            Exit Sub
        End If
        Dim vConfirm As String = "Are you sure you want to delete the selected Invoice Item?"
        If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand
        Try
            str = "DELETE FROM INVOICEITEM WHERE INVOICEITEMNUMBER = " & bsInvoiceItems.Current.InvoiceItemNumber.ToString
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try
        MsgBox("Record successfully deleted", MsgBoxStyle.Information, "Success")
        getInvoiceItems(vInvoiceNum)
    End Sub

    Private Function getTaxStatus(ByVal vCustID As Integer) As Boolean
        Dim oCustomer As New Customer
        Try
            oCustomer.LoadByPrimaryKey(vCustID)
            If oCustomer.Taxexempt = "1" Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return False

    End Function

    Private Sub btnAddItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddItem.ItemClick
        addItem()
    End Sub

    Private Sub btnEditItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditItem.ItemClick
        editItem()
    End Sub

    Private Sub btnDeleteItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteItem.ItemClick
        deleteItem()
    End Sub

    Private Sub btnSaveInvoice_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaveInvoice.ItemClick
        saveInvoice()
    End Sub

    Private Sub saveInvoice()
        bsInvoice.EndEdit()
        bsInvoiceItems.EndEdit()
        If bsInvoiceItems.Count <= 0 Then
            MsgBox("You must enter at least one Item to save the work order", MsgBoxStyle.Critical, "Error - No items")
            Exit Sub
        End If
        oInvoice.Save()
        oItems.Save()
        If oInvoice.Invoicestatus = "PENDING" Then
            createCommissions()
            If MsgBox("Do you want to mark this Invoice as RECEIVABLE?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                oInvoice.Invoicestatus = "RECEIVABLE"
                oInvoice.Save()
            End If
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelChanges_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelChanges.ItemClick
        oInvoice.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oInvoice.MarkAsDeleted()
                oInvoice.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnMiscCharge_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMiscCharge.ItemClick
        addMiscCharge()
    End Sub

    Private Sub createCommissions()
        'set customer id from invoice
        Dim vCustID As Integer = bsInvoice.Current.custid
        'get all salesperson/customer assignments for this customer
        Dim oCA As New CustomerassignmentCollection
        oCA.Query.Where(oCA.Query.CustID.Equal(vCustID))
        oCA.Query.Load()
        'if no assignments, quit
        If oCA.Count <= 0 Then
            Exit Sub
        End If
        'there can be more than one salesperson/customer assignment for this customer
        'iterate through the collection
        Dim oSales As Customerassignment
        For Each oSales In oCA
            createSalesCommission(oSales)
        Next
    End Sub

    Private Sub createSalesCommission(ByVal oSCA As Customerassignment)

        Dim vCommission As Decimal = 0
        Dim vTotalCommission As Decimal = 0
        Dim vInv As Integer = bsInvoice.Current.InvoiceNumber
        Dim vCustID As Integer = oSCA.CustID
        Dim vCA As Integer = oSCA.CustAssignID
        Dim vSalesID As Integer = oSCA.SalespersonID
        Dim vCommType As String = oSCA.CommissionType
        Dim vRate As Double = oSCA.CommissionRate
        Dim oItem As Invoiceitem = Nothing
        Dim oItems As InvoiceitemCollection = Nothing
        Dim oExc As Commissionexception = Nothing

        'iterate through each invoice item to determine commission payable if any
        oItems = New InvoiceitemCollection
        oItems.Query.Where(oItems.Query.Invoicenumber.Equal(vInv))
        oItems.Query.Load()
        If oItems.Count <= 0 Then
            Exit Sub
        End If
        For Each oItem In oItems
            vRate = oSCA.CommissionRate
            vCommission = 0
            If Not oItem.Productid Is Nothing Then
                'first determine if there is a commission exception for this product for this invoice item and reset rate
                oExc = New Commissionexception
                oExc.Query.Where(oExc.Query.CustAssignID.Equal(vCA), oExc.Query.ProductID.Equal(oItem.Productid))
                If oExc.Query.Load Then
                    vRate = oExc.CommissionRate
                End If
                'next, calculate this items contribution to the overall commission 
                If oSCA.CommissionType = "PROFIT" Then
                    'use the totalprofitamount from the invoice item
                    If oItem.Grossprofit Is Nothing Then
                        vCommission = 0
                    Else
                        vCommission = oItem.Grossprofit * vRate
                    End If
                Else
                    vCommission = oItem.Extprice * vRate
                End If
            End If
            vTotalCommission = vTotalCommission + vCommission
        Next

        'we now have enough info to make a commission record
        'but first, we should delete any commissions related to this invoice
        Dim oComm As Commission
        Dim oComms As New CommissionCollection
        oComms.Query.Where(oComms.Query.Invoicenumber.Equal(vInv), oComms.Query.Salespersonid.Equal(oSCA.SalespersonID))
        oComms.Query.Load()
        If oComms.Count > 0 Then
            For Each oComm In oComms
                oComm.MarkAsDeleted()
            Next
            oComms.Save()
        End If

        'now make the new commission record for the invoice
        oComm = New Commission
        oComm.Commissionamount = vTotalCommission
        oComm.Commissioncategory = "REGULAR"
        oComm.Commissiondate = bsInvoice.Current.invoiceDate
        oComm.Commissiondesc = "INV " & vInv & " - " & oCust.Custname
        oComm.Commissionstatus = "PENDING"
        oComm.Custid = vCustID
        oComm.Invoicenumber = vInv
        oComm.Salespersonid = oSCA.SalespersonID
        oComm.Save()

    End Sub

    Private Sub CustidLookUpEdit_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustidLookUpEdit.EditValueChanged
        If IsDBNull(CustidLookUpEdit.EditValue) Or CustidLookUpEdit.EditValue Is Nothing Then
            Exit Sub
        End If
        oCust = New Customer
        If Not oCust.LoadByPrimaryKey(sender.editvalue) Then
            Exit Sub
        End If
        Me.Billaddress1TextEdit.EditValue = oCust.Custbilladdress1
        Me.Billaddress2TextEdit.EditValue = oCust.Custbilladdress2
        Me.BillcityTextEdit.EditValue = oCust.Custbillcity
        Me.BillstateprovTextEdit.EditValue = oCust.Custbillstateprov
        Me.BillpostalcodeTextEdit.EditValue = oCust.Custbillpostalcode
        Me.BillcountryTextEdit.EditValue = oCust.Custbillcountry
        Me.Shipaddress1TextEdit.EditValue = oCust.Custshipaddress1
        Me.Shipaddress2TextEdit.EditValue = oCust.Custshipaddress2
        Me.ShipcityTextEdit.EditValue = oCust.Custshipcity
        Me.ShipstateprovTextEdit.EditValue = oCust.Custshipstateprov
        Me.ShippostalcodeTextEdit.EditValue = oCust.Custshippostalcode
        Me.ShipcountryTextEdit.EditValue = oCust.Custshipcountry

        oInvoice.Billaddress1 = oCust.Custbilladdress1
        oInvoice.Billaddress2 = oCust.Custbilladdress2
        oInvoice.Billcity = oCust.Custbillcity
        oInvoice.Billstateprov = oCust.Custbillstateprov
        oInvoice.Billpostalcode = oCust.Custbillpostalcode
        oInvoice.Billcountry = oCust.Custbillcountry
        oInvoice.Shipaddress1 = oCust.Custshipaddress1
        oInvoice.Shipaddress2 = oCust.Custshipaddress2
        oInvoice.Shipcity = oCust.Custshipcity
        oInvoice.Shipstateprov = oCust.Custshipstateprov
        oInvoice.Shippostalcode = oCust.Custshippostalcode
        oInvoice.Shipcountry = oCust.Custshipcountry
        oInvoice.EndEdit()

    End Sub

    Private Sub rbtnPrintInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintInvoice.ItemClick
        saveInvoice()
        printInvoice()
    End Sub

    Private Sub printInvoice()
        Dim rpt As New rptInvoice(oInvoice.Invoicenumber)
        rpt.ShowPreview()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class