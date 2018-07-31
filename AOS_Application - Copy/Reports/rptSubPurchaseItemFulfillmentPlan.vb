Imports AOS.BusinessObjects

Public Class rptSubPurchaseItemFulfillmentPlan

    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vID)
    End Sub

    Private Sub getdata(ByVal vID As Integer)

        Dim oRptPurchaseItem As New ViewRptPurchaseItemFulfillmentPlanCollection

        oRptPurchaseItem.Query.Where(oRptPurchaseItem.Query.Workordernumber.Equal(vID))
        oRptPurchaseItem.Query.Load()
        Me.bsRptPurchaseItem.DataSource = oRptPurchaseItem


    End Sub


End Class