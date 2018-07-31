Imports AOS.BusinessObjects

Public Class frmAdditionalQuantity
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vPurchaseItemID As Integer
  

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub

    Private Function changesSaved() As Boolean
        If ValidateControls() Then
            Dim oPurchaseItem As New Purchaseitem
            If oPurchaseItem.LoadByPrimaryKey(vPurchaseItemID) Then
                Dim oNewPurchaseitem As New Purchaseitem
                'Create a new Purchase Item by copying selected purchase item record
                oNewPurchaseitem = duplicatePurchaseItem(oPurchaseItem, Convert.ToInt32(QuantityTextEdit.EditValue),
                        PurchaseItemType.REGULAR.ToString(), PurchaseItemsStatus.ORDERED.ToString(),
                        NotesTextEdit.EditValue, False)

                'Create inventory records for the additional items
                createInventoryItemsByPurchaseItem(oNewPurchaseitem)
            End If
            Return True
        Else
            Return False
        End If
    End Function

    Private Function changesCancelled() As Boolean
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Function
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        changesCancelled()
    End Sub

    Private Function ValidateControls() As Boolean

        If String.IsNullOrEmpty(Me.QuantityTextEdit.EditValue) Or QuantityTextEdit.EditValue = 0 Then
            MsgBox("Quantity is required.", MsgBoxStyle.Critical, "Error")
            QuantityTextEdit.Focus()
            Return False
        End If

        If Convert.ToInt32(QuantityTextEdit.EditValue) <= 0 Then
            MsgBox("Valid Quantity is required.", MsgBoxStyle.Critical, "Error")
            QuantityTextEdit.Focus()
            Return False
        End If

        Return True
    End Function
End Class