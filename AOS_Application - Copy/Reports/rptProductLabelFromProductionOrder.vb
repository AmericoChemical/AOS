
Public Class rptProductLabelFromProductionOrder

    Public Sub New(ByVal vProdOrderNum As Integer)
        InitializeComponent()
        fillDataSet(vProdOrderNum)
    End Sub

    Private Sub fillDataSet(ByVal vProdOrderNum As Integer)
        Dim oRpt As New ViewRptProductLabelFromProductionOrderCollection
        oRpt.Query.Where(oRpt.Query.Prodordernum.Equal(vProdOrderNum))
        oRpt.Query.Load()
        Me.bsRpt.DataSource = oRpt
    End Sub

    Private Sub HazMatImage_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles HazMatImage.BeforePrint
        Dim HazMatID As Integer
        If fldHazMatID.Text = "" Then
            HazMatID = 1
        Else
            HazMatID = CInt(fldHazMatID.Text)
        End If

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
        If fldLotNum.Text = Nothing Then
            fldLotDesc.Text = ""
        Else
            fldLotDesc.Text = "LOT#: " & fldLotNum.Text
        End If
    End Sub

    Private Sub fldWeightDesc_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldWeightDesc.BeforePrint
        If fldStandardWeight.Text = Nothing Then
            fldWeightDesc.Text = ""
        Else
            fldWeightDesc.Text = "NET WEIGHT: " & fldStandardWeight.Text & " LBS"
        End If
    End Sub

    Private Sub fldLotDesc2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldLotDesc2.BeforePrint
        If fldLotNum.Text = Nothing Then
            fldLotDesc2.Text = ""
        Else
            fldLotDesc2.Text = "LOT#: " & fldLotNum.Text
        End If
    End Sub

    Private Sub fldWeight_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldWeight.BeforePrint
        If fldStandardWeight.Text = Nothing Then
            fldWeight.Text = ""
        Else
            fldWeight.Text = fldStandardWeight.Text & " LBS"
        End If
    End Sub

    Private Sub fldNetweightCaption_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles fldNetweightCaption.BeforePrint
        If fldStandardWeight.Text = Nothing Then
            fldNetweightCaption.Text = ""
        Else
            fldNetweightCaption.Text = "NET WEIGHT:"
        End If
    End Sub
End Class