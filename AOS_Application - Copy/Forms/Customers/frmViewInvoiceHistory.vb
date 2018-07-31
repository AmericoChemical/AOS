
Imports AOS.BusinessObjects

Public Class frmViewInvoiceHistory
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vInvoiceHistoryId As Integer

    Dim oCust As Customer

    Dim oInvoiceHistory As Invoicehistory
    Dim oInvoiceHistoryItems As InvoicehistoryitemCollection
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

        editObject(vInvoiceHistoryId)
    End Sub



    Private Sub editObject(ByVal invoiceHistoryId As Integer)
        If invoiceHistoryId = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oInvoiceHistory = New Invoicehistory
        oInvoiceHistory.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oInvoiceHistory.LoadByPrimaryKey(invoiceHistoryId)
        bsInvoiceHistory.DataSource = oInvoiceHistory
        getInvoiceItems(invoiceHistoryId)
    End Sub


    Private Sub getInvoiceItems(ByVal invoiceHistoryId As Integer)
        oInvoiceHistoryItems = New InvoicehistoryitemCollection
        oInvoiceHistoryItems.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oInvoiceHistoryItems.Query.Where(oInvoiceHistoryItems.Query.Invoicehistoryid.Equal(invoiceHistoryId))
        oInvoiceHistoryItems.Query.Load()
        Try
            bsInvoiceHistoryItems.DataSource = oInvoiceHistoryItems
            grInvoiceHistoryItems.DataSource = bsInvoiceHistoryItems
            grInvoiceHistoryItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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


    Private Sub rbtnPrintInvoiceHistorical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintInvoiceHistorical.ItemClick
        '        saveInvoice()
        printInvoiceHistory()
    End Sub

    Private Sub printInvoiceHistory()
        Dim rpt As New rptInvoiceHistorical(oInvoiceHistory.Invoicehistoryid)
        rpt.ShowPreview()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class