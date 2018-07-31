Imports AOS.BusinessObjects

Public Class rptSubPOFulfillmentPlan

    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vID)
    End Sub

    Private Sub getdata(ByVal vID As Integer)

        Dim oRptPO As New ViewRptPOFulfillmentPlanCollection

        oRptPO.Query.Where(oRptPO.Query.Workordernumber.Equal(vID))
        oRptPO.Query.Load()
        Me.bsRptPO.DataSource = oRptPO


    End Sub


End Class