Imports AOS.BusinessObjects

Public Class frmWorkOrdersToInvoice
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub


    Private Sub btnClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub



    Private Sub rbtnGetWorkOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetWorkOrders.ItemClick
        gcWorkOrdersToInvoice.BringToFront()

        If Not validateDates() Then
            Exit Sub

        End If


        Dim oWorkOrdersToInvoice As New ViewWorkOrdersToInvoiceLinkCollection

        oWorkOrdersToInvoice.Query.Where(oWorkOrdersToInvoice.Query.Workorderdate.Between(eStartDate.EditValue, eEndDate.EditValue), oWorkOrdersToInvoice.Query.Invoicenumber.IsNull)

        If Not oWorkOrdersToInvoice.Query.Load Then
            MsgBox("Error retrieving Work Orders To Invoice", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If oWorkOrdersToInvoice.Count <= 0 Then
            MsgBox("Error retrieving Work Orders To Invoice", MsgBoxStyle.Critical, "Error - No Records found")
            Exit Sub
        End If

        oWorkOrdersToInvoice.Sort = "Workorderdate"
        bsWorkOrdersToInvoiceLink.DataSource = oWorkOrdersToInvoice


    End Sub


    Private Function validateDates() As Boolean
        If IsDBNull(eStartDate.EditValue) OrElse eStartDate.EditValue = Nothing Then
            MsgBox("You must enter a Start Date", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If IsDBNull(eEndDate.EditValue) OrElse eEndDate.EditValue = Nothing Then
            MsgBox("You must enter an End Date", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If eStartDate.EditValue > eEndDate.EditValue Then
            MsgBox("End Date must be greater than Start Date", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        Return True
    End Function


    Private Sub rbtnExportWorkOrdersToInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnExportWorkOrdersToInvoice.ItemClick
        Try
            Dim vDocfolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim vFileName As String = vDocfolderPath + "\" + "WorkOrdersToInvoice.xls"
            grvWorkOrdersToInvoice.ExportToXls(vFileName)
            MsgBox("WorkOrders To Invoice successfully exported to " + vFileName, MsgBoxStyle.Information, "Export succeeded")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class