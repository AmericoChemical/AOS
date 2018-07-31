Imports DevExpress.XtraReports

Public Class rptLoadDataSheet

    Private vFreezeWarning As Boolean = False
    Private vLiquidProductsOnBOL As Boolean = False
    Private vHazMatOnBoard As Boolean = False
    Private vToxic As Boolean = False
    Private vLoadID As Integer

    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        XrSubreport2.ReportSource = New AOS.rptLoadDataWgtByDOTNumber
        XrSubreport3.ReportSource = New AOS.rptLoadDataWgtByClass
        vLoadID = vID
        getdata(vLoadID)
    End Sub

    Private Sub getdata(ByVal vLoadID As Integer)

        Dim oLoad As New ViewRptBillOfLading5Collection
        oLoad.Query.Where(oLoad.Query.LoadID.Equal(vLoadID))
        If Not oLoad.Query.Load Then
            MsgBox("Error retrieving Load Data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If
        bsLoadData.DataSource = oLoad

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
        For Each oRec As ViewRptBillOfLading5 In oLoad
            If oRec.Isliquid Then
                vLiquidProductsOnBOL = True
            End If
            If oRec.HazmatID > 1 Then
                vHazMatOnBoard = True
            End If
            If oRec.Istoxic Then
                vToxic = True
            End If
        Next

        If vHazMatOnBoard Then
            xrHazLabel.Visible = True
            xrEmergencyInfoLabel.Visible = True
        Else
            xrHazLabel.Visible = False
            xrEmergencyInfoLabel.Visible = False
        End If

        If vToxic Then
            xrHazLabel.Text = "CONTAINS HAZARDOUS MATERIALS - SOME MAY BE TOXIC - DO NOT SHIP WITH FOOD"
        Else
            xrHazLabel.Text = "CONTAINS HAZARDOUS MATERIALS"
        End If

        If vFreezeWarning = 1 Then
            If vLiquidProductsOnBOL Then
                xrFreezeLabel.Visible = True
            Else
                xrFreezeLabel.Visible = False
            End If
        Else
            xrFreezeLabel.Visible = False
        End If


    End Sub

    Private Sub xrProperShippingName_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles xrProperShippingName.BeforePrint
        xrProperShippingName.Text = xrDOT.Text + " " + xrHazMatDesc.Text
    End Sub

    Private Sub XrSubreport2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        CType((CType(sender, XRSubreport)).ReportSource, AOS.rptLoadDataWgtByDOTNumber).vLoadID.Value = vLoadID
    End Sub

    Private Sub XrSubreport3_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrSubreport3.BeforePrint
        CType((CType(sender, XRSubreport)).ReportSource, AOS.rptLoadDataWgtByClass).vLoadID.Value = vLoadID
    End Sub
End Class