Public Class frmPickWorkOrderItems

    Public vWorkorderNum As Integer
    Public vFormTitle As String
    Dim oWO As Workorder
    Dim oWOItems As ViewWorkOrderItemsScreenCollection
    Dim oPickedItems As ViewWorkOrderItemsScreenCollection

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.Text = vFormTitle
        getData()
    End Sub

    Private Sub getData()

        oWO = New Workorder
        oWO.LoadByPrimaryKey(vWorkorderNum)

        oWOItems = New ViewWorkOrderItemsScreenCollection
        oWOItems.Query.Where(oWOItems.Query.Workordernumber.Equal(vWorkorderNum), oWOItems.Query.Or(oWOItems.Query.Itemstatus.IsNull, oWOItems.Query.Itemstatus.NotIn("PICKED", "SHIPPED")))
        oWOItems.Query.Load()
        bsWOItems.DataSource = oWOItems

        oPickedItems = New ViewWorkOrderItemsScreenCollection
        oPickedItems.Query.Where(oPickedItems.Query.Workordernumber.Equal(vWorkorderNum), oPickedItems.Query.Itemstatus.In("PICKED"))
        oPickedItems.Query.Load()
        bsPickedItems.DataSource = oPickedItems

    End Sub

    Private Sub rbtnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rbtnPickItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPickItem.ItemClick
        If bsWOItems.Count <= 0 Then
            Exit Sub
        End If

        If IsDBNull(bsWOItems.Current.InvItemNumber) Or bsWOItems.Current.InvItemNumber < 0 Then
            Exit Sub
        End If
        If IsDBNull(bsWOItems.Current.ItemStatus) Or bsWOItems.Current.ItemStatus <> "ALLOCATED" Then
            MsgBox("Can't pick item unless current ITEM STATUS = ALLOCATED", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim oItem As New Invitem
        If oItem.LoadByPrimaryKey(bsWOItems.Current.InvItemNumber) Then
            oItem.Itemstatus = "PICKED"
            oItem.Save()
        End If

        getData()


    End Sub

    Private Sub rbtnUnPickItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUnPickItem.ItemClick
        If bsPickedItems.Count <= 0 Then
            Exit Sub
        End If

        Dim oItem As New Invitem
        If oItem.LoadByPrimaryKey(bsPickedItems.Current.InvItemNumber) Then
            oItem.Itemstatus = "ALLOCATED"
            oItem.Save()
        End If

        getData()

    End Sub
End Class