Imports System.Drawing.Printing
Imports AOS.BusinessObjects

Public Class rptBillOfLading4

    Private vFreezeWarning As Boolean = False
    Private vLiquidProductsOnBOL As Boolean = False
    Private vHazMatOnBoard As Boolean = False
    Private vToxic As Boolean = False

    Public Sub New(ByVal vID As Integer)

        InitializeComponent()
        fillDataSet(vID)

    End Sub

    Private Sub fillDataSet(ByVal vID As Integer)

        Dim oRpt As New ViewRptBillOfLading4Collection
        oRpt.Query.Where(oRpt.Query.Shipmentnumber.Equal(vID))
        If Not oRpt.Query.Load Then
            MsgBox("Could not retrieve report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If
        bsRpt.DataSource = oRpt

        'check to see if FreezeProtection is required for this shipment and set report variable if it is.
        If oRpt(0).Keepfromfreezing = 1 Then
            vFreezeWarning = True
        End If
        If oRpt(0).Keepfromfreezing = True Then
            vFreezeWarning = True
        End If


        'retrieve system parameters 
        Dim oParm As New Sysparameters
        If Not oParm.LoadByPrimaryKey(1) Then
            MsgBox("Error retrieving system parameters", MsgBoxStyle.Critical, "Error - System Parameters")
            Me.ClosePreview()
        End If
        Dim vMaxVolume As Decimal = oParm.MaxVolumeForNonRegDOT

        'determine if any of the products on the BOL report are flagged as Liquid products (and subject to freezing)
        For Each oRec As ViewRptBillOfLading4 In oRpt
            If oRec.Isliquid Then
                vLiquidProductsOnBOL = True
            End If
            If oRec.Hazmatid > 1 Then
                vHazMatOnBoard = True
            End If
            If oRec.Istoxic Then
                vToxic = True
            End If
        Next


        If vHazMatOnBoard Then
            TopLine.ForeColor = Color.Red
            eTopLabel.Visible = True
            BottomLine.ForeColor = Color.Red
            eBottomLabel.Visible = True
        Else
            TopLine.ForeColor = Color.Black
            eTopLabel.Visible = False
            BottomLine.ForeColor = Color.Black
            eBottomLabel.Visible = False
        End If

        If vToxic Then
            eTopLabel.Text = "CONTAINS HAZARDOUS MATERIALS - SOME MAY BE TOXIC - DO NOT SHIP WITH FOOD"
            eBottomLabel.Text = "CONTAINS HAZARDOUS MATERIALS - SOME MAY BE TOXIC - DO NOT SHIP WITH FOOD"
        End If

        getPlacardsList(vID)

    End Sub

    Private Sub getPlacardsList(vShipmentID As Integer)

        Dim oList As New ViewRptBillOfLading2PlacardsListCollection
        Dim oItem As ViewRptBillOfLading2PlacardsList

        ePlacardsList.Text = ""

        oList = New ViewRptBillOfLading2PlacardsListCollection
        oList.Query.Where(oList.Query.Shipmentnumber.Equal(vShipmentID))
        oList.Query.Load()

        For Each oItem In oList
            If oItem.Hazclassnumber <> "" Then
                If ePlacardsList.Text = "" Then
                    ePlacardsList.Text = oItem.Hazclassnumber
                Else
                    ePlacardsList.Text = ePlacardsList.Text + ", " + oItem.Hazclassnumber
                End If
            End If
        Next
    End Sub

    Private Sub txtKeepFromFreezing_BeforePrint(sender As Object, e As System.Drawing.Printing.PrintEventArgs) Handles txtKeepFromFreezing.BeforePrint
        If vFreezeWarning = True And vLiquidProductsOnBOL = True Then
            txtKeepFromFreezing.Visible = True
        End If
    End Sub

    Private Sub fldPlacardsSupplied_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldPlacardsSupplied.BeforePrint
        If fldPlacardsSupplied.Text = "YES" Then
            txtSuppliedYes.Text = "X"
        Else
            txtSuppliedNo.Text = "X"
        End If
    End Sub

    Private Sub fldFOB_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fldFOB.BeforePrint
        If fldFOB.Text = "COLLECT" Then
            txtFOB.Text = "X"
        Else
            txtFOB.Text = ""
        End If

        'all shipments for ChemTool (Caterpillar) have been requested by customer to be marked as Collect, even when billing third party
        If fldCustID.Text = "441" Then
            txtFOB.Text = "X"
        End If

    End Sub

    Private Sub lblBO1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lblBO1.BeforePrint
        If eQty.Text = "0" Then
            lblBO1.Visible = True
        Else
            lblBO1.Visible = False
        End If
    End Sub

    Private Sub HM_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles HM.BeforePrint

        'if Product is marked as RQ (Reportable Quantity) then instead of an "X" in the HM column, it should be and "RQ"
        'the exception is if the line item is for an empty container, for which there is no reportable quantity. Then is should be an "X"
        'The HM value for empty containers comes from the "Last Contained" product reference and resulting DOT information

        If lblRQ.Text = "True" Then
            If lblItemType.Text = "E" Then
                HM.Text = "X"
            Else
                HM.Text = "RQ"
            End If
        Else
            HM.Text = "X"
        End If

        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                HM.Visible = False
                HM.ForeColor = Color.Black
            Else
                HM.ForeColor = Color.Red
                HM.Visible = True
            End If
        Catch ex As Exception
            HM.Visible = False
        End Try
    End Sub

    Private Sub lblToxic_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblToxic.BeforePrint
        Try
            If eToxic.Text = "True" Then
                lblToxic.Visible = True
            Else
                lblToxic.Visible = False
            End If
        Catch ex As Exception
            lblToxic.Visible = False
        End Try
    End Sub

    Private Sub lblBillThirdPartyHeader_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lblBillThirdPartyHeader.BeforePrint
        If eLogisticsID.Text = "" Or eLogisticsID.Text = "0" Then
            lblBillThirdPartyHeader.Visible = False
        Else
            lblBillThirdPartyHeader.Visible = True
        End If
    End Sub

    Private Sub eUNNumber_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles eIDNumber.BeforePrint
        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                eIDNumber.ForeColor = Color.Black
            Else
                eIDNumber.ForeColor = Color.Red
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub eClassRate_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles eClassRate.BeforePrint
        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                eClassRate.ForeColor = Color.Black
            Else
                eClassRate.ForeColor = Color.Red
            End If
        Catch ex As Exception
            HM.Visible = False
        End Try
    End Sub

    Private Sub eContainer_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles eContainer.BeforePrint
        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                eContainer.ForeColor = Color.Black
            Else
                eContainer.ForeColor = Color.Red
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub eHazClass_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles eHazClass.BeforePrint
        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                eHazClass.ForeColor = Color.Black
            Else
                eHazClass.ForeColor = Color.Red
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub eLD1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles eLD1.BeforePrint
        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                eLD1.ForeColor = Color.Black
            Else
                eLD1.ForeColor = Color.Red
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub eLD3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles eLD3.BeforePrint
        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                eLD3.ForeColor = Color.Black
            Else
                eLD3.ForeColor = Color.Red
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ePkgGroup_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles ePkgGroup.BeforePrint
        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                ePkgGroup.ForeColor = Color.Black
            Else
                ePkgGroup.ForeColor = Color.Red
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub eQty_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles eQty.BeforePrint
        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                eQty.ForeColor = Color.Black
            Else
                eQty.ForeColor = Color.Red
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub eTotalWeight_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles eTotalWeight.BeforePrint
        Try
            If txtHazMatID.Text = "1" Or txtHazMatID.Text = "" Then
                eTotalWeight.ForeColor = Color.Black
            Else
                eTotalWeight.ForeColor = Color.Red
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class