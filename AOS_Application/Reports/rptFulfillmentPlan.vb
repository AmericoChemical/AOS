Imports AOS.BusinessObjects

Public Class rptFulfillmentPlan

    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vID)
    End Sub

    Private Sub getdata(ByVal vID As Integer)
        If vID <= 0 Then
            Exit Sub
        End If

        Dim oRptWorkOrder As New ViewRptWorkOrderFulfillmentPlanCollection
       
        If Not oRptWorkOrder.LoadAll Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.bsRptWorkOrder.DataSource = getWorkOrderFulfillmentPlanReportView(vID)
        Me.subRLBL.ReportSource = New AOS.rptSubRelabelFulfillmentPlan(vID)
        Me.subWorkOrderItem.ReportSource = New AOS.rptSubWOItemFulfillmentPlan(vID)
        Me.subPO.ReportSource = New AOS.rptSubProdOrdFulfillmentPlan(vID)
        Me.subPurchaseItem.ReportSource = New AOS.rptSubPurchItemFulfillmentPlan(vID)
    End Sub


End Class