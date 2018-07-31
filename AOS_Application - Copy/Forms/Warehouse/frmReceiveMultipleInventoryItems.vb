Imports AOS.BusinessObjects

Public Class frmReceiveMultipleInventoryItems

    Inherits DevExpress.XtraEditors.XtraForm
    Public vCommaSeparatedInvitemnumber As String
    Public vContainerWeight As Integer
    Public vContainer As String
    Public vPallet As String

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        LoadInventoryItems()
    End Sub

    Private Sub LoadInventoryItems()
        bsInventoryItems.DataSource = getViewInvItemsByInvItemNumbers(vCommaSeparatedInvitemnumber)
    End Sub

    Private Sub btnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub grvInventoryItems_DoubleClick(sender As Object, e As EventArgs) Handles grvInventoryItems.DoubleClick
        If bsInventoryItems.Count <= 0 Then
            Exit Sub
        End If

        'Dim frm As New frmEnterItemReceivingData
        'frm.vItemID = bsInventoryItems.Current.InvItemNumber
        'frm.vContainerWeight = vContainerWeight
        'frm.ShowDialog()

        Dim frm As New frmUpdateInventoryItem
        frm.vSource = "MULTIPLE"
        frm.vInvitemnumber = bsInventoryItems.Current.InvItemNumber
        frm.vContainerWeight = vContainerWeight
        frm.vContainer = vContainer
        frm.vPallet = vPallet
        frm.ShowDialog()







        LoadInventoryItems()
    End Sub
End Class
