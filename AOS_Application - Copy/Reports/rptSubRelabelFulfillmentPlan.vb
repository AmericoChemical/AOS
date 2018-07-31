Imports AOS.BusinessObjects

Public Class rptSubRelabelFulfillmentPlan

    Dim oViewRptRelabelFulfillmentPlanCollection As New ViewRptRelabelFulfillmentPlanCollection

    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        oViewRptRelabelFulfillmentPlanCollection = getRelabelFulfillmentPlanReportView(vID)
        Me.bsRptRLBL.DataSource = oViewRptRelabelFulfillmentPlanCollection
    End Sub

    Private Sub rptSubRelabelFulfillmentPlan_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        If oViewRptRelabelFulfillmentPlanCollection Is Nothing OrElse _
            oViewRptRelabelFulfillmentPlanCollection.Count <= 0 Then
            e.Cancel = True
        End If
    End Sub
End Class