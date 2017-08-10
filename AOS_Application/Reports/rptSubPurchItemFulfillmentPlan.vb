Imports AOS.BusinessObjects

Public Class rptSubPurchItemFulfillmentPlan

    Dim vViewRptPurchaseItemFulfillmentPlanCollection As ViewRptPurchaseItemFulfillmentPlanCollection

    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        vViewRptPurchaseItemFulfillmentPlanCollection = getPurchaseItemFulfillmentPlanReportView(vID)
        Me.bsRptPurchaseItem.DataSource = vViewRptPurchaseItemFulfillmentPlanCollection
    End Sub

    Private Sub rptSubPurchItemFulfillmentPlan_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        If vViewRptPurchaseItemFulfillmentPlanCollection Is Nothing OrElse vViewRptPurchaseItemFulfillmentPlanCollection.Count <= 0 Then
            e.Cancel = True
        End If
    End Sub

End Class