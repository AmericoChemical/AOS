Public Class frmGetMaterialUsageAmount

    Public vMaxNeeded As Decimal
    Public vMaxContainer As Decimal
    Public vQtyUsed As Decimal

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If validateData() Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Function validateData() As Boolean
        If CDec(eQtyUsed.EditValue) > vMaxContainer Then
            MsgBox("You can't use more material than is available in the selected Inventory Item", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If CDec(eQtyUsed.EditValue) > vMaxNeeded Then
            MsgBox("You can't use more material than is needed to complete the production order.", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        vQtyUsed = CDec(eQtyUsed.EditValue)
        Return True
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class