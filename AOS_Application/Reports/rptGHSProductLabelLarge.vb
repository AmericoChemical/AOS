Imports System.Drawing.Printing
Imports AOS.BusinessObjects

Public Class rptGHSProductLabelLarge
    Public Sub New(ByVal vItemID As Integer, ByVal vProductID As Integer, Optional vLotNumber As String = "")

        InitializeComponent()
        fillDataSet(vItemID, vProductID, vLotNumber)

    End Sub

    Dim oRpt As ViewProductChemicalGHS
    Dim vType As String
    Dim vLotNum As String

    Private Sub fillDataSet(ByVal vItemID As Integer, ByVal vProductID As Integer, vLotNumber As String)

        oRpt = New ViewProductChemicalGHS
        Select Case vItemID
            Case Is > 0     'Specific Inventory Item was chosen to print label for
                vType = "ITEM"
                oRpt.Query.Where(oRpt.Query.Invitemnumber.Equal(vItemID))
                oRpt.Query.Load()
                bsRpt.DataSource = oRpt
            Case Else       'Only printing for the Product, not a specific inventory item
                vType = "PRODUCT"
                vLotNum = vLotNumber
                Dim oRpts As New ViewProductChemicalGHSCollection
                oRpts.Query.Where(oRpts.Query.Productid.Equal(vProductID))
                oRpts.Query.Load()
                If oRpts.Count > 0 Then
                    oRpt = oRpts(0)
                End If
                bsRpt.DataSource = oRpt
        End Select
    End Sub

    Private Sub HazMatImage_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles HazMatImage.BeforePrint
        Dim HazMatID As Integer
        If fldHazMatID.Text = "" Then
            HazMatID = 1
        Else
            HazMatID = CInt(fldHazMatID.Text)
        End If

        If HazMatID > 0 And HazMatID <= DOTImages.Images.Count Then
            CType(sender, DevExpress.XtraReports.UI.XRPictureBox).Image = DOTImages.Images(HazMatID - 1)
        End If
    End Sub

    Private Sub fldDOTHAZMATDesc_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldDOTHAZMATDesc.BeforePrint
        Dim vStr As String = ""
        If oRpt.Rq Then
            vStr = vStr + "RQ, "
        End If
        If oRpt.Idnumber <> "" Then
            vStr = vStr + oRpt.Idnumber + ", "
        End If
        vStr = vStr + fldDOTDESC.Text & " " & fldHAZMATDESC.Text
        fldDOTHAZMATDesc.Text = vStr
        'fldDOTHAZMATDesc.Text = fldDOTDESC.Text & " " & fldHAZMATDESC.Text
    End Sub

    Private Sub fldDescAll_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldDescAll.BeforePrint
        Dim vStr As String = ""
        If oRpt.Rq Then
            vStr = vStr + "RQ, "
        End If
        If oRpt.Idnumber <> "" Then
            vStr = vStr + oRpt.Idnumber + ", "
        End If
        vStr = vStr + fldDOTDESC.Text & " " & fldHAZMATDESC.Text
        fldDescAll.Text = vStr
        'fldDescAll.Text = fldDOTDESC.Text & " " & fldHAZMATDESC.Text & " " & fldUNLine.Text
    End Sub

    Private Sub fldLotDesc_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldLotDesc.BeforePrint
        If vType = "ITEM" Then
            If fldLotNum.Text = Nothing Then
                fldLotDesc.Text = ""
            Else
                fldLotDesc.Text = "LOT#: " & fldLotNum.Text
            End If
        Else
            fldLotDesc.Text = "LOT#: " & vLotNum
        End If
    End Sub

    Private Sub fldWeightDesc_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldWeightDesc.BeforePrint
        If fldStandardWeight.Text = Nothing Then
            fldWeightDesc.Text = ""
        Else
            fldWeightDesc.Text = fldStandardWeight.Text & " LBS"
        End If
    End Sub

    Private Sub fldLotDesc2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldLotDesc2.BeforePrint
        If vType = "ITEM" Then
            If fldLotNum.Text = Nothing Then
                fldLotDesc2.Text = ""
            Else
                fldLotDesc2.Text = "LOT#: " & fldLotNum.Text
            End If
        Else
            fldLotDesc2.Text = "LOT#: " & vLotNum
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

    Private Sub GHSSymbol1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles GHSSymbol1.BeforePrint
        Dim vSymID As Integer
        If IsDBNull(oRpt.Pictogram1) Or oRpt.Pictogram1 Is Nothing Then
            vSymID = 0
        Else
            vSymID = oRpt.Pictogram1
        End If
        If vSymID > 0 And vSymID <= GHSImages.Images.Count Then
            CType(sender, DevExpress.XtraReports.UI.XRPictureBox).Image = GHSImages.Images(vSymID - 1)
        End If
    End Sub

    Private Sub GHSSymbol2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles GHSSymbol2.BeforePrint
        Dim vSymID As Integer
        If IsDBNull(oRpt.Pictogram2) Or oRpt.Pictogram2 Is Nothing Then
            vSymID = 0
        Else
            vSymID = oRpt.Pictogram2
        End If
        If vSymID > 0 And vSymID <= GHSImages.Images.Count Then
            CType(sender, DevExpress.XtraReports.UI.XRPictureBox).Image = GHSImages.Images(vSymID - 1)
        End If
    End Sub

    Private Sub GHSSymbol3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles GHSSymbol3.BeforePrint
        Dim vSymID As Integer
        If IsDBNull(oRpt.Pictogram3) Or oRpt.Pictogram3 Is Nothing Then
            vSymID = 0
        Else
            vSymID = oRpt.Pictogram3
        End If
        If vSymID > 0 And vSymID <= GHSImages.Images.Count Then
            CType(sender, DevExpress.XtraReports.UI.XRPictureBox).Image = GHSImages.Images(vSymID - 1)
        End If
    End Sub

    Private Sub GHSSymbol4_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles GHSSymbol4.BeforePrint
        Dim vSymID As Integer
        If IsDBNull(oRpt.Pictogram4) Or oRpt.Pictogram4 Is Nothing Then
            vSymID = 0
        Else
            vSymID = oRpt.Pictogram4
        End If
        If vSymID > 0 And vSymID <= GHSImages.Images.Count Then
            CType(sender, DevExpress.XtraReports.UI.XRPictureBox).Image = GHSImages.Images(vSymID - 1)
        End If
    End Sub

    Private Sub GHSSymbol5_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles GHSSymbol5.BeforePrint
        Dim vSymID As Integer
        If IsDBNull(oRpt.Pictogram5) Or oRpt.Pictogram5 Is Nothing Then
            vSymID = 0
        Else
            vSymID = oRpt.Pictogram5
        End If
        If vSymID > 0 And vSymID <= GHSImages.Images.Count Then
            CType(sender, DevExpress.XtraReports.UI.XRPictureBox).Image = GHSImages.Images(vSymID - 1)
        End If
    End Sub

    Private Sub lblGHSInfo_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblGHSInfo.BeforePrint

        Dim vStr As String = ""

        If oRpt.Ghsclassification <> "" Then
            vStr = vStr + "GHS CLASSIFICATION:" + ChrW(13) + oRpt.Ghsclassification + ChrW(13)
        End If
        If oRpt.Hazardstatements <> "" Then
            vStr = vStr + "HAZARD STATEMENTS:" + ChrW(13) + oRpt.Hazardstatements + ChrW(13)
        End If
        vStr = vStr + "PRECAUTIONARY STATEMENTS" + ChrW(13)
        If oRpt.Safetyprecautions <> "" Then
            vStr = vStr + "SAFETY PRECAUTIONS: " + oRpt.Safetyprecautions + ChrW(13)
        End If
        If oRpt.Firstaidmeasures <> "" Then
            vStr = vStr + "FIRST AID MEASURES: " + oRpt.Firstaidmeasures + ChrW(13)
        End If
        If oRpt.Storage <> "" Then
            vStr = vStr + "STORAGE: " + oRpt.Storage + ChrW(13)
        End If
        If oRpt.Disposal <> "" Then
            vStr = vStr + "DISPOSAL: " + oRpt.Disposal + ChrW(13)
        End If

        'Add an Acute Toxicity Header Line if there are any values
        If oRpt.Acutetoxicityoral <> "" Or oRpt.Acutetoxicitydermal <> "" Or oRpt.Acutetoxicityinhalationdustmist <> "" Or oRpt.Acutetoxicityinhalationgas <> "" Or oRpt.Acutetoxicityinhalationvapor <> "" Then
            vStr = vStr + "PERCENT UNKNOWN ACUTE TOXICITY" + ChrW(13)
        End If

        If oRpt.Acutetoxicityoral <> "" Then
            vStr = vStr + "ORAL: " + oRpt.Acutetoxicityoral + " %  "
        End If
        If oRpt.Acutetoxicitydermal <> "" Then
            vStr = vStr + "DERMAL: " + oRpt.Acutetoxicitydermal + " %  "
        End If
        If oRpt.Acutetoxicityinhalationdustmist <> "" Then
            vStr = vStr + "INHALATION DUST/MIST: " + oRpt.Acutetoxicityinhalationdustmist + " %  "
        End If
        If oRpt.Acutetoxicityinhalationgas <> "" Then
            vStr = vStr + "INHALATION GAS: " + oRpt.Acutetoxicityinhalationgas + " %  "
        End If
        If oRpt.Acutetoxicityinhalationvapor <> "" Then
            vStr = vStr + "INHALATION VAPOR: " + oRpt.Acutetoxicityinhalationvapor + " %  "
        End If
        'Add a line break if you've created the Acute Toxicity line item
        If oRpt.Acutetoxicityoral <> "" Or oRpt.Acutetoxicitydermal <> "" Or oRpt.Acutetoxicityinhalationdustmist <> "" Or oRpt.Acutetoxicityinhalationgas <> "" Or oRpt.Acutetoxicityinhalationvapor <> "" Then
            vStr = vStr + ChrW(13)
        End If

        vStr = vStr + "READ AND UNDERSTAND LABEL AND SAFETY DATA SHEET BEFORE PRODUCT USE." + ChrW(13)

        If oRpt.Firesupplemental <> "" Or oRpt.Accidentsupplemental <> "" Then
            vStr = vStr + "SUPPLEMENTAL INFORMATION" + ChrW(13)
        End If

        If oRpt.Accidentsupplemental <> "" Then
            vStr = vStr + "IN CASE OF SPILL: " + oRpt.Accidentsupplemental + ChrW(13)
        End If

        If oRpt.Firesupplemental <> "" Then
            vStr = vStr + "IN CASE OF FIRE: " + oRpt.Firesupplemental + ChrW(13)
        End If


        lblGHSInfo.Text = vStr
    End Sub

    Private Sub lblProdIDChemID_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblProdIDChemID.BeforePrint
        lblProdIDChemID.Text = oRpt.Productid.ToString + "/" + oRpt.Chemicalid.ToString
    End Sub

    Private Sub lblDangerWord_BeforePrint(sender As Object, e As PrintEventArgs) Handles lblDangerWord.BeforePrint
        If lblDangerWord.Text = "(NONE)" Then
            lblDangerWord.Visible = False
        End If
    End Sub

    Private Sub lblHazardousContainerWarning_BeforePrint(sender As Object, e As PrintEventArgs) Handles lblHazardousContainerWarning.BeforePrint
        Dim HazMatID As Integer
        If fldHazMatID.Text = "" Then
            HazMatID = 1
        Else
            HazMatID = CInt(fldHazMatID.Text)
        End If

        If HazMatID = 1 Then
            lblHazardousContainerWarning.Visible = False
        Else
            lblHazardousContainerWarning.Visible = True
        End If
    End Sub

    Private Sub ItemName_BeforePrint(sender As Object, e As PrintEventArgs) Handles ItemName.BeforePrint
        If IsDBNull(oRpt.Chemicalid) Or oRpt.Chemicalid = 0 Then
            ItemName.Text = oRpt.Productdesc
        Else
            ItemName.Text = oRpt.Chemicalname
        End If

    End Sub

    Private Sub ItemName2_BeforePrint(sender As Object, e As PrintEventArgs) Handles ItemName2.BeforePrint
        If IsDBNull(oRpt.Chemicalid) Or oRpt.Chemicalid = 0 Then
            ItemName2.Text = oRpt.Productdesc
        Else
            ItemName2.Text = oRpt.Chemicalname
        End If

    End Sub
End Class