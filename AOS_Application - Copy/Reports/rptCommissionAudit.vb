Imports AOS.BusinessObjects

Public Class rptCommissionAudit
    Public Sub New(vInvoiceNumber As Integer, vSalespersonID As Integer)

        InitializeComponent()
        fillDataSet(vInvoiceNumber, vSalespersonID)

    End Sub

    Private Sub fillDataSet(vInvoiceNumber As Integer, vSalespersonID As Integer)

        Dim oAudit As ViewCommissionAuditDetailsCollection
        Dim oInv As ViewInvoice
        Dim oWO As ViewCommissionWorkOrderDetailsCollection


        Try
            oInv = New ViewInvoice
            oInv.Query.Where(oInv.Query.Invoicenumber.Equal(vInvoiceNumber))
            oInv.Query.Load()
            bsRpt.DataSource = oInv

            oAudit = New ViewCommissionAuditDetailsCollection
            oAudit.Query.Where(oAudit.Query.Invoicenumber.Equal(vInvoiceNumber), oAudit.Query.SalespersonID.Equal(vSalespersonID))
            oAudit.Query.Load()
            bsInvoiceDetails.DataSource = oAudit

            oWO = New ViewCommissionWorkOrderDetailsCollection
            oWO.Query.Where(oWO.Query.Invoicenumber.Equal(vInvoiceNumber), oWO.Query.SalespersonID.Equal(vSalespersonID))
            oWO.Query.Load()
            bsWorkOrderDetails.DataSource = oWO

        Catch ex As Exception
            MsgBox("There was an error retrieving data", MsgBoxStyle.Critical, "Error - Data Not Retrieved")
            Me.ClosePreview()
        End Try

    End Sub

End Class