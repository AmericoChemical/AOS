Imports AOS.BusinessObjects

Public Class rptSubProdOrdFulfillmentPlan

    Dim vViewRptPOFulfillmentPlanCollection As New ViewRptPOFulfillmentPlanCollection
    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        vViewRptPOFulfillmentPlanCollection = getPordOrdFulfillmentPlanReportView(vID)
        Me.bsRptPO.DataSource = getPordOrdFulfillmentPlanReportView(vID)
    End Sub

    Private Sub rptSubProdOrdFulfillmentPlan_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        If vViewRptPOFulfillmentPlanCollection Is Nothing OrElse vViewRptPOFulfillmentPlanCollection.Count <= 0 Then
            e.Cancel = True
        End If
    End Sub
End Class