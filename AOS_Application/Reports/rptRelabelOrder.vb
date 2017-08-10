Imports AOS.BusinessObjects

Public Class rptRelabelOrder

#Region "Report Instantiation and Data Acquisition"
    Public Sub New(ByVal vRelabelordernumber As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vRelabelordernumber)
    End Sub

    Private Sub getdata(ByVal vRelabelordernumber As Integer)
        Dim oViewRptRelabelOrders As ViewRptRelabelOrderCollection = getRptRelabelOrders(vRelabelordernumber)

        If oViewRptRelabelOrders.Count = 0 Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
            Exit Sub
        End If
        Me.bsRpt.DataSource = oViewRptRelabelOrders

        If oViewRptRelabelOrders(0).Productid Is Nothing OrElse
            oViewRptRelabelOrders(0).Relabelorderitemproductid Is Nothing Then
            Exit Sub
        End If
        Me.subTemplateRelabelInstructions.ReportSource = New AOS.rptSubRelabelTemplateInstructions()

        Dim oProductRelabelInstructions As ViewProductRelabelInstructionCollection = getProductRelabelInstructions(oViewRptRelabelOrders(0).Productid, oViewRptRelabelOrders(0).Relabelorderitemproductid)
        If oProductRelabelInstructions.Count > 0 Then
            Me.subInstructions.ReportSource = New AOS.rptSubRelabelInstructions(oViewRptRelabelOrders(0).Productid, oViewRptRelabelOrders(0).Relabelorderitemproductid)
        Else
            Me.subInstructions.ReportSource = Nothing
        End If

    End Sub
#End Region




End Class