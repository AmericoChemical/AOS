
Imports AOS.BusinessObjects

Public Class frmAddEditBDFInvoice
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vInvoiceNum As Integer
    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vLoadID As Integer       'object Load ID (passed in by calling form for edit mode)
    Public vEditType As String
    Dim oCust As Customer

    Dim oInvoice As BDFInvoice
    Dim oItems As BDFInvoiceItemCollection
    Dim oProducts As ProductCollection
    Dim oCustomers As CustomerCollection
    Dim oSales As SalespersonCollection
    Dim oCarriers As CarrierCollection
    Dim oFOB As ListFobCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vInvoiceNum)
        End If
    End Sub

    Private Sub addNewObject()
        oInvoice = New BDFInvoice
        oInvoice.CreatedTimeStamp = Now
        oInvoice.InvoiceStatus = "PENDING"
        ' oItemList.Updatedby = vCurrentUserLogin
        oInvoice.ModifiedTimeStamp = Now
        'assign foreign key values here
        oInvoice.Save()

        eInvoiceNumber.EditValue = oInvoice.BDFInvoiceNumber
        eInvoiceDate.EditValue = Today
        eInvoiceStatus.EditValue = "PENDING"

    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oInvoice = New BDFInvoice
        ' oInvoice.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oInvoice.LoadByPrimaryKey(vID)
        bsBDFInvoice.DataSource = oInvoice
        getInvoiceItems(vID)
    End Sub


    Private Sub getInvoiceItems(ByVal vID As Integer)
        oItems = New BDFInvoiceItemCollection
        oItems.Query.Where(oItems.Query.BDFInvoiceNumber.Equal(vID))
        oItems.Query.Load()
        Try
            bsBDFInvoiceItems.DataSource = oItems
            grItems.DataSource = bsBDFInvoiceItems
            grItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        getInvoiceTotals()
    End Sub

    Private Sub getInvoiceTotals()
        'determine invoice subtotal
        oInvoice.BeginEdit()
        'oInvoice.SubTotal = getInvoiceItemsTotal(oInvoice.BDFInvoiceNumber)
        'determine invoice sales tax
        '  oInvoice.SalesTax = getInvoiceSalesTax(oInvoice.BDFInvoiceNumber)
        'determine invoice totals
        'oInvoice.Total = oInvoice.SubTotal + oInvoice.SalesTax
        ' oInvoice.Total = oInvoice.SubTotal

        ' We only need to show the Total
        oInvoice.Total = getInvoiceItemsTotal(oInvoice.BDFInvoiceNumber)
        oInvoice.EndEdit()
        oInvoice.Save()
        eTotal.EditValue = oInvoice.Total
    End Sub

    Private Function getSalesTaxRate() As Decimal
        Dim oParms As New Sysparameters
        If oParms.LoadByPrimaryKey(1) Then
            Return oParms.Defaultsalestaxrate
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
            ' str = "SELECT SUM(EXTPRICE) FROM BDFInvoiceItem WHERE BDFInvoiceItemNumber = " & vInvNum.ToString
            str = "SELECT SUM(EXTPRICE) FROM BDFInvoiceItem WHERE BDFInvoiceNumber = " & vInvNum.ToString
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            sqlcnn.Open()
            vResult = cmd.ExecuteScalar
            vSubTotal = Math.Round(vResult, 2, MidpointRounding.AwayFromZero)
        Catch ex As Exception
            ' MsgBox("Error in calculating Invoice Subtotals for Invoice # " & vInvNum.ToString, MsgBoxStyle.Critical, "Error - No Subtotal")
            MsgBox("Error in calculating Invoice total for Invoice # " & vInvNum.ToString, MsgBoxStyle.Critical, "Error - No Invoice Total")
            Return 0
        Finally
            sqlcnn.Close()
        End Try
        sqlcnn.Close()
        Return vSubTotal
    End Function
    Private Function getInvoiceSalesTax(ByVal vInvNum As Integer) As Decimal
        'assume customer is NOT tax exempt
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand = Nothing
        Dim vResult As Decimal = 0.0
        Dim vTax As Decimal = 0.0
        Try
            'get the subtotal for items that are taxable
            str = "SELECT SUM(EXTPRICE) FROM dbo.BDFInvoiceItem WHERE BDFInvoiceNumber = " & vInvNum.ToString & " AND TAXABLE = 1"
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
        Dim frm As New frmAddEditBDFInvoiceItem
        frm.vFKID = Me.bsBDFInvoice.Current.BDFInvoiceNumber
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        'frm.vTaxExempt = getTaxStatus(Me.bsBDFInvoice.Current.CustID)
        vResult = frm.ShowDialog()
        getInvoiceItems(vInvoiceNum)
    End Sub
    

    Private Sub editItem()
        If bsBDFInvoiceItems.Count <= 0 Then
            Exit Sub
        End If

        Dim frm As New frmAddEditBDFInvoiceItem
        frm.vID = Me.bsBDFInvoiceItems.Current.BDFInvoiceItemNumber
        frm.vFKID = Me.bsBDFInvoice.Current.BDFInvoiceNumber

        frm.vEditType = "EDIT"
        frm.ShowDialog()

        getInvoiceItems(vInvoiceNum)
    End Sub

    Private Sub deleteItem()
        If bsBDFInvoiceItems.Count <= 0 Then
            Exit Sub
        End If
        Dim vConfirm As String = "Are you sure you want to delete the selected Invoice Item?"
        If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand
        Try
            str = "DELETE FROM dbo.BDFInvoiceItem WHERE BDFInvoiceItemNumber = " & bsBDFInvoiceItems.Current.BDFInvoiceItemNumber.ToString
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
        bsBDFInvoice.EndEdit()
        bsBDFInvoiceItems.EndEdit()
        If bsBDFInvoiceItems.Count <= 0 Then
            MsgBox("You must enter at least one Item to save the work order", MsgBoxStyle.Critical, "Error - No items")
            Exit Sub
        End If
        oInvoice.Save()
        oItems.Save()
        If oInvoice.Invoicestatus = "PENDING" Then
            ' createCommissions()
            If MsgBox("Do you want to mark this Invoice as RECEIVABLE?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                oInvoice.Invoicestatus = "RECEIVABLE"
                oInvoice.Save()
            End If
        End If

        'Me.DialogResult = Windows.Forms.DialogResult.OK

        Me.Close()
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

        ' Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub rbtnPrintInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintInvoice.ItemClick
        saveInvoice()
        printInvoice()
    End Sub

    Private Sub printInvoice()
        Dim rpt As New rptInvoice(oInvoice.BDFInvoiceNumber)
        rpt.ShowPreview()
        ' Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()

    End Sub
End Class