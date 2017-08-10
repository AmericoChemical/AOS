Imports AOS.BusinessObjects

Public Class frmProcessRelabelOrder
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vRelabelOrderNumber As Integer
 
    Dim oRelabelorder As ViewRelabelOrder

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        editObject(vRelabelOrderNumber)
    End Sub

    Private Sub loadRelatedData()
        If Not bsRelabelOrder.Current.Relabelordernumber Is Nothing Then
            bsRelabelOrderItems.DataSource = getViewRelabelOrderItems(bsRelabelOrder.Current.Relabelordernumber)
        End If
        If Not bsRelabelOrder.Current.Relabelordernumber Is Nothing Then
            bsRelabeledItems.DataSource = getRelabeledItems(bsRelabelOrder.Current.Relabelordernumber)
        End If

        If bsRelabelOrder.Current.RelabelOrderStatus = "INPROD" Then
            If updateRelabelOrderStatus() Then
                editObject(bsRelabelOrder.Current.RelabelOrderNumber)
            End If
        End If

    End Sub

    Private Function updateRelabelOrderStatus() As Boolean

        'get all RelabelOrderItems from  the RelabelOrder
        'check all their statuses - if all are COMPLETED or CANCELLED then update status of RelabelOrder to COMPLETED

        Dim oItems As New RelabelorderitemCollection
        oItems.Query.Where(oItems.Query.Relabelordernumber.Equal(bsRelabelOrder.Current.RelabelOrdernumber), oItems.Query.Relabelorderitemstatus.NotIn("COMPLETED", "CANCELLED"))
        If oItems.Query.Load() Then
            'there are records not marked as COMPLETED or CANCELLED, so the RELABELORDER should remain in its current status
            Return False
        End If

        'update RelabelOrder status to Completed
        Dim oRlbl As New Relabelorder
        oRlbl.LoadByPrimaryKey(bsRelabelOrder.Current.RelabelOrderNumber)
        oRlbl.Relabelorderstatus = "COMPLETED"
        oRlbl.Save()
        Return True

    End Function

    Private Sub editObject(ByVal vRelabelOrderNumber As Integer)
        If vRelabelOrderNumber = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oRelabelorder = New ViewRelabelOrder
        oRelabelorder.Query.Where(oRelabelorder.Query.Relabelordernumber.Equal(vRelabelOrderNumber))
        If Not oRelabelorder.Query.Load Then
            MsgBox("No Relabel Order found", MsgBoxStyle.Critical, "Error - No Data")
            Exit Sub
        End If
        bsRelabelOrder.DataSource = oRelabelorder
        loadRelatedData()
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rbtnProcessRelabelItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnProcessRelabelItem.ItemClick
        If bsRelabelOrderItems.Count <= 0 Then
            Exit Sub
        End If
        Select Case bsRelabelOrderItems.Current.RelabelOrderItemStatus
            Case "COMPLETED"
                MsgBox("The selected Relabel Order Item has already been completed.", MsgBoxStyle.Critical, "ERROR - Completed")
                Exit Sub
            Case "CANCELLED"
                MsgBox("The selected Relabel Order Item was cancelled.", MsgBoxStyle.Critical, "ERROR - Cancelled")
                Exit Sub
            Case "PRCH"
                MsgBox("The selected Relabel Order Item has not been received into inventory.", MsgBoxStyle.Critical, "ERROR - On Order")
                Exit Sub
        End Select
        Dim frm As New frmProcessRelabelItem
        frm.vRelabelOrderItemNumber = bsRelabelOrderItems.Current.RelabelOrderItemNumber
        frm.ShowDialog()
        loadRelatedData()
    End Sub

    Private Sub rbtnPrintProductLabel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintProductLabel.ItemClick
        If bsRelabeledItems.Count <= 0 Then
            Exit Sub
        End If

        If IsDBNull(bsRelabeledItems.Current.InvitemNumber) OrElse bsRelabeledItems.Current.InvItemNumber = Nothing Then
            MsgBox("Cannot print a label for an Inventory Item with No Inventory Item Number assigned.", MsgBoxStyle.Critical, "Error - Missing Inv Item Number")
            Exit Sub
        End If

        'get Product Record for selected InventoryItem
        Dim oProduct As New Product
        oProduct.LoadByPrimaryKey(bsRelabeledItems.Current.ProductID)
        If IsDBNull(oProduct.Chemicalid) Or oProduct.Chemicalid Is Nothing Then
            Dim rpt1 As New rptProductLabelForInventoryItem(bsRelabeledItems.Current.InvItemNumber)
            rpt1.ShowPreviewDialog
        ElseIf oProduct.Chemicalid <= 0 Then
            Dim rpt1 As New rptProductLabelForInventoryItem(bsRelabeledItems.Current.InvItemNumber)
            rpt1.ShowPreviewDialog
        ElseIf oProduct.Chemicalid > 0 Then
            Dim rpt As New rptGHSProductLabelLarge(bsRelabeledItems.Current.InvItemNumber, bsRelabeledItems.Current.ProductID)
            rpt.ShowPreviewDialog()
        End If

        loadRelatedData()
    End Sub
End Class