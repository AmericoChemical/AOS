Imports AOS.BusinessObjects

Public Class rptSubWOItemFulfillmentPlan

    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        Me.bsRptWorkOrderItem.DataSource = getWorkOrderItemFulfillmentPlanReportView(vID)
    End Sub

End Class