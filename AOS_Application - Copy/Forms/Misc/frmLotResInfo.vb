Public Class frmLotResInfo

    Public vLot As String
    Public vRes As String

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click

        vLot = eLot.Text
        vRes = eRes.Text
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub
End Class