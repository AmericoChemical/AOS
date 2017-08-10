Imports AOS.BusinessObjects

Public Class frmPalletList
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'here is where you dimension your object variables for the form
    Dim oItems As ListPallettypeCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        oItems = New ListPallettypeCollection
        oItems.LoadAll()
        bs.DataSource = oItems
    End Sub

    Private Sub btnDone_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDone.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnNewItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewItem.ItemClick
        Dim frm As New frmAddEditPallet
        frm.vEditType = "ADD"
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub btnEditItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditItem.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If

        Dim frm As New frmAddEditPallet
        frm.vID = bs.Current.RecID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub btnDeleteItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteItem.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete the selected item from the list?", MsgBoxStyle.YesNo, "Confirm Item Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oItem As New ListPallettype
        If oItem.LoadByPrimaryKey(bs.Current.RecID) Then
            oItem.MarkAsDeleted()
            oItem.Save()
        End If

        loadData()
    End Sub
End Class