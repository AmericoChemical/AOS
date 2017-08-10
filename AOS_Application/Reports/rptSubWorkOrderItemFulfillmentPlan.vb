Imports AOS.BusinessObjects

Public Class rptSubWorkOrderItemFulfillmentPlan

    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vID)
    End Sub

    Private Sub getdata(ByVal vID As Integer)

        Dim oRptWorkOrderItem As New ViewRptWorkOrderItemFulfillmentPlanCollection

        oRptWorkOrderItem.Query.Where(oRptWorkOrderItem.Query.Workordernumber.Equal(vID))
        oRptWorkOrderItem.Query.Load()
        Me.bsRptWorkOrderItem.DataSource = oRptWorkOrderItem


    End Sub


 
End Class