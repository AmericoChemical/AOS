Imports AOS.BusinessObjects

Public Class frmFreightCharges
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vLoadID As Integer

    Dim oLoad As ViewLoadDetails
    Dim oCharges As ViewLoadChargesByLoadIDCollection
    Dim oBillings As ViewLoadBillingByLoadIDCollection
    Dim oWgtClass As ViewLoadWeightByItemClassCollection
    Dim oWgtContainer As ViewLoadWeightByContainerCollection
    Dim oLoadQuotes As ViewLoadQuotesByLoadIDCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        oLoad = New ViewLoadDetails
        oLoad.Query.Where(oLoad.Query.LoadID.Equal(vLoadID))
        oLoad.Query.Load()
        rTxtLoadID.Caption = vLoadID
        rTxtDestZip.Caption = "Zip: " & oLoad.DestZip.ToString
        rTxtLoadGrossWeight.Caption = oLoad.GrossWt.ToString & " LBS"

        oCharges = New ViewLoadChargesByLoadIDCollection
        oCharges.Query.Where(oCharges.Query.LoadID.Equal(vLoadID))
        oCharges.Query.Load()
        bsLoadCharges.DataSource = oCharges

        oBillings = New ViewLoadBillingByLoadIDCollection
        oBillings.Query.Where(oBillings.Query.Loadid.Equal(vLoadID))
        oBillings.Query.Load()
        bsLoadBillings.DataSource = oBillings

        oWgtClass = New ViewLoadWeightByItemClassCollection
        oWgtClass.Query.Where(oWgtClass.Query.LoadID.Equal(vLoadID))
        oWgtClass.Query.Load()
        bsWeightByClass.DataSource = oWgtClass

        oWgtContainer = New ViewLoadWeightByContainerCollection
        oWgtContainer.Query.Where(oWgtContainer.Query.LoadID.Equal(vLoadID))
        oWgtContainer.Query.Load()
        bsWeightByContainer.DataSource = oWgtContainer

        oLoadQuotes = New ViewLoadQuotesByLoadIDCollection
        oLoadQuotes.Query.Where(oLoadQuotes.Query.LoadID.Equal(vLoadID))
        oLoadQuotes.Query.Load()
        bsLoadQuotes.DataSource = oLoadQuotes

    End Sub

   
    Private Sub rbtnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteQuote.ItemClick

    End Sub
    Private Sub rbtnEditQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditQuote.ItemClick
        If bsLoadQuotes.Count <= 0 Then
            Exit Sub
        End If

        Dim frm As New frmAddEditLoadQuote
        frm.vID = bsLoadQuotes.Current.LoadQuoteID
        frm.vLoadID = vLoadID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadData()
    End Sub
    Private Sub rbtnAddQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddQuote.ItemClick

        Dim frm As New frmAddEditLoadQuote
        frm.vLoadID = vLoadID
        frm.vEditType = "ADD"
        frm.ShowDialog()
        loadData()
    End Sub
End Class