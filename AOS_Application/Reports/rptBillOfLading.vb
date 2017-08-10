Imports AOS.BusinessObjects

Public Class rptBillOfLading

    Private vFreezeWarning As Boolean = False
    Private vLiquidProductsOnBOL As Boolean = False

    Public Sub New(ByVal vID As Integer)

        InitializeComponent()
        fillDataSet(vID)

    End Sub

    Private Sub fillDataSet(ByVal vID As Integer)

        Dim oRpt As New ViewRptBillOfLadingCollection
        oRpt.Query.Where(oRpt.Query.Shipmentnumber.Equal(vID))
        If Not oRpt.Query.Load Then
            MsgBox("Could not retrieve report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If
        bsRpt.DataSource = oRpt

        'retrieve system parameters to determine if the overall Freeze Warning parameter is in effect at the time report is run
        Dim oParm As New Sysparameters
        If Not oParm.LoadByPrimaryKey(1) Then
            MsgBox("Error retrieving system parameters", MsgBoxStyle.Critical, "Error - System Parameters")
            Me.ClosePreview()
        Else
            If oParm.FreezeWarning = 1 Then
                vFreezeWarning = True
            End If
        End If

        'determine if any of the products on the BOL report are flagged as Liquid products (and subject to freezing)
        For Each oRec As ViewRptBillOfLading In oRpt
            If oRec.Isliquid Then
                vLiquidProductsOnBOL = True
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
        End If
    End Sub

    Private Sub lblBO1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lblBO1.BeforePrint
        If eQty.Text = "0" Then
            lblBO1.Visible = True
        Else
            lblBO1.Visible = False
        End If
    End Sub

    'Private Sub lblBO2_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
    '    If eQty.Text = "0" Then
    '        lblBO2.Visible = True
    '    Else
    '        lblBO2.Visible = False
    '    End If
    'End Sub

    Private Sub HM_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles HM.BeforePrint

        Try
            If txtHazMatID.Text = "1" Then
                HM.Visible = False
            Else
                HM.Visible = True
            End If
        Catch ex As Exception
            HM.Visible = False
        End Try

    End Sub

    Private Sub lblBillThirdPartyHeader_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles lblBillThirdPartyHeader.BeforePrint
        If eLogisticsID.Text Is Nothing Then
            lblBillThirdPartyHeader.Visible = False
        Else
            lblBillThirdPartyHeader.Visible = True
        End If
    End Sub

    Private Sub fldLD1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles fldLD1.BeforePrint
        If fldUNNumber.Text Is Nothing Then
            fldLD1.Text = fldLD1.Text
        Else
            fldLD1.Text = "UN" + fldUNNumber.Text + "  " + fldLD1.Text
        End If
    End Sub
End Class