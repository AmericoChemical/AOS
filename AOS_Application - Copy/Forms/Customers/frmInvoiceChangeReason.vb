Imports AOS.BusinessObjects

Public Class frmInvoiceChangeReason

    Public vInvoiceNum As Integer
    Public vEditType As String

    Public vInvoiceHistoryHeader As Invoicehistoryheader

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        editObject()
    End Sub

    Private Sub editObject()
        gcLeft.Text = "Reason For Change in Invoice#:" & vInvoiceNum
        bsInvoiceHistoryHeader.DataSource = vInvoiceHistoryHeader
    End Sub



    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If InvoiceChangeReasonTextEdit.EditValue = Nothing Then
            MsgBox("You must enter Invoice Change Reason", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        saveInvoiceHistoryHeader()
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub saveInvoiceHistoryHeader()
        bsInvoiceHistoryHeader.EndEdit()
        vInvoiceHistoryHeader.Changecommitted = True
        vInvoiceHistoryHeader.Save()
    End Sub


    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


End Class