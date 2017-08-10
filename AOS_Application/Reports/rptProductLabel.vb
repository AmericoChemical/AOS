Public Class rptProductLabel

    Private Sub HazMatImage_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles HazMatImage.BeforePrint
        Dim HazMatID As Integer
        HazMatID = CInt(fldHazMatID.Text)
        If HazMatID > 0 And HazMatID <= ImageCollection1.Images.Count Then
            CType(sender, DevExpress.XtraReports.UI.XRPictureBox).Image = ImageCollection1.Images(HazMatID - 1)
        End If
    End Sub

    Private Sub fldDOTHAZMATDesc_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldDOTHAZMATDesc.BeforePrint
        fldDOTHAZMATDesc.Text = fldDOTDESC.Text & " " & fldHAZMATDESC.Text
    End Sub

    Private Sub fldDescAll_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldDescAll.BeforePrint
        fldDescAll.Text = fldDOTDESC.Text & " " & fldHAZMATDESC.Text & " " & fldUNLine.Text
    End Sub

    Private Sub fldLotDesc_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldLotDesc.BeforePrint
        fldLotDesc.Text = "LOT#: " & fldLotNum.Text
    End Sub

    Private Sub fldWeightDesc_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldWeightDesc.BeforePrint
        fldWeightDesc.Text = "NET WEIGHT: " & fldStandardWeight.Text & " LBS"
    End Sub

    Private Sub fldLotDesc2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldLotDesc2.BeforePrint
        fldLotDesc2.Text = "LOT#: " & fldLotNum.Text
    End Sub

    Private Sub fldWeight_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldWeight.BeforePrint
        fldWeight.Text = fldStandardWeight.Text & " LBS"
    End Sub
End Class