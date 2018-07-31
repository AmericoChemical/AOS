Imports System.Drawing.Printing
Imports AOS.BusinessObjects

Public Class rptWorkOrder

    Dim oRpt As ViewRptWorkOrderCollection

#Region "Report Instantiation and Data Acquisition"
    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vID)
    End Sub

    Private Sub getdata(ByVal vID As Integer)

        oRpt = New ViewRptWorkOrderCollection
        oRpt.Query.Where(orpt.Query.Workordernumber.Equal(vID))
        If Not oRpt.Query.Load Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.bsRpt.DataSource = oRpt

    End Sub

    Private Sub lblOrSooner_BeforePrint(sender As Object, e As PrintEventArgs) Handles lblOrSooner.BeforePrint
        If bsRpt.Current.OrSoonerFlag = True Then
            lblOrSooner.Visible = True
        Else
            lblOrSooner.Visible = False
        End If
    End Sub
#End Region




End Class