Imports AOS.BusinessObjects

Public Class frmSalesDataAnalysis
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private vSalesGroup As String = "ALL"

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub


    Private Sub btnClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Function getInvoiceRawData() As Boolean

        If Not validateDates() Then
            Return False
        End If

        'Delete all existing invoice records from the last data collection
        Dim oInvList As New RptSalesinvoicedataCollection
        oInvList.LoadAll()
        oInvList.MarkAllAsDeleted()
        oInvList.Save()

        'add new Invoice Collection to Report Data Tables for analysis
        Dim oNewInv As New ViewCustomerInvoiceListCollection
        oNewInv.Query.Where(oNewInv.Query.Invoicedate.Between(eStartDate.EditValue, eEndDate.EditValue))
        If Not oNewInv.Query.Load() Then
            MsgBox("No Invoice Data found.", MsgBoxStyle.Critical, "Data Error")
            Return False
        End If
        If oNewInv.Count <= 0 Then
            MsgBox("No Invoice Data found.", MsgBoxStyle.Critical, "Data Error")
            Return False
        End If

        'Add pulled Invoice Data to the report table
        For Each oInv As ViewCustomerInvoiceList In oNewInv
            Dim oInvNew As New RptSalesinvoicedata
            oInvNew.InvoiceNumber = oInv.Invoicenumber
            oInvNew.InvoiceDate = oInv.Invoicedate
            oInvNew.CustID = oInv.Custid
            oInvNew.Save()
        Next

        'Confirm invoices selected by date range were added to the raw invoice data table
        oInvList = New RptSalesinvoicedataCollection
        oInvList.LoadAll()
        If oInvList.Count <= 0 Then
            MsgBox("No invoice data found.", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        Return True

    End Function

    'Private Sub rbtnGetQtrlyData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetQtrlyData.ItemClick
    '    gcQrtlySalesSummary.BringToFront()

    '    If Not getInvoiceRawData() Then
    '        Exit Sub
    '    End If

    '    Dim oQtrlyData As New ViewSalesQtrlyTotalsInvoiceDateRestrictedCollection
    '    oQtrlyData.Query.Where(oQtrlyData.Query.Saleslevel.Equal(2), oQtrlyData.Query.Salesbycustomerreport.Equal(1))
    '    If Not oQtrlyData.Query.Load Then
    '        MsgBox("Error retrieving Qtrly Sales Totals", MsgBoxStyle.Critical, "Error")
    '        Exit Sub
    '    End If
    '    If oQtrlyData.Count <= 0 Then
    '        MsgBox("Error retrieving Qtrly Sales Totals", MsgBoxStyle.Critical, "Error - No Records found")
    '        Exit Sub
    '    End If

    '    oQtrlyData.Sort = "SalesID1"
    '    bsQtrlyData.DataSource = oQtrlyData


    'End Sub

    'Private Sub rbtnSalespersonCustomerDetailedData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSalespersonCustomerDetailedData.ItemClick

    '    gcSalespersonCustomerDetailedData.BringToFront()

    '    If Not getInvoiceRawData() Then
    '        Exit Sub
    '    End If

    '    Dim oData As New ViewSalespersonCustomerDetailedDataCollection
    '    oData.LoadAll()
    '    oData.Sort = "SalesID1, CustName"
    '    bsCustomerSalesData.DataSource = oData

    'End Sub

    Private Function validateDates() As Boolean
        If IsDBNull(eStartDate.EditValue) Then
            MsgBox("You must enter a Start Date", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If IsDBNull(eEndDate.EditValue) Then
            MsgBox("You must enter an End Date", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If eStartDate.EditValue = Nothing Then
            MsgBox("You must enter a Start Date", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If eEndDate.EditValue = Nothing Then
            MsgBox("You must enter an End Date", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If eStartDate.EditValue > eEndDate.EditValue Then
            MsgBox("End Date must be greater than Start Date", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        Return True
    End Function


    'Private Sub rbtnExportQtrlyData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnExportQtrlyData.ItemClick
    '    Try
    '        Dim vDocfolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    '        Dim vFileName As String = vDocfolderPath + "\" + "SalespersonQtrlySummary.xls"
    '        grvQtrlyTotals.ExportToXls(vFileName)
    '        MsgBox("Salesperson Quarterly Summary Data successfully exported to " + vFileName, MsgBoxStyle.Information, "Export succeeded")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub rbtnExportCustomerData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnExportCustomerData.ItemClick
    '    Try
    '        Dim vDocfolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    '        Dim vFileName As String = vDocfolderPath + "\" + "CustomerMonthlySalesData.xls"
    '        grvCustomerSalesData.ExportToXls(vFileName)
    '        MsgBox("Customer Monthly Sales Analysis Data successfully exported to " + vFileName, MsgBoxStyle.Information, "Export succeeded")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub rbtnYTDSalesAllCustomers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnYTDSalesAllCustomers.ItemClick

        vSalesGroup = "All"

        If Not getInvoiceRawData() Then
            Exit Sub
        End If

        Dim obj As New ViewGetYTDSalesAllCustomersCollection
        obj.LoadAll()
        obj.Sort = "CustName"
        bsYTDSalesData.DataSource = obj


    End Sub

    Private Sub rbtnExportYTDSalesToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnExportYTDSalesToExcel.ItemClick
        Try
            Dim vFilename As String = ""
            Dim vDocfolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Select Case vSalesGroup
                Case "ALL"
                    vFilename = vDocfolderPath + "\" + "CustomerMonthlySalesData.xls"
                Case "Jeff"
                    vFilename = vDocfolderPath + "\" + "CustomerMonthlySalesData_JeffStudnickaOnly.xls"
                Case Else
                    vFilename = vDocfolderPath + "\" + "CustomerMonthlySalesData.xls"
            End Select
            grvCustomerSalesData.ExportToXls(vFilename)
            MsgBox("Customer Monthly Sales Analysis Data successfully exported to " + vFileName, MsgBoxStyle.Information, "Export succeeded")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbtnYTDKeffsCustomers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnYTDKeffsCustomers.ItemClick

        vSalesGroup = "Jeff"

        If Not getInvoiceRawData() Then
            Exit Sub
        End If

        Dim obj As New ViewGetYTDSalesForJeffCustomersCollection

        obj.LoadAll()
        obj.Sort = "CustName"
        bsYTDSalesData.DataSource = obj
    End Sub
End Class