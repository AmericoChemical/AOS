Imports AOS.BusinessObjects

Public Class rptBDFBatchAnalysis

#Region "Report Instantiation and Data Acquisition"
    Public Sub New(ByVal vBatchID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vBatchID)
    End Sub

    Friend vTotalReceivable As Decimal = 0.0

    Private Sub getdata(ByVal vBatchID As Integer)
        Dim obj As New ViewLoadChargesForBDFCollection
        obj.Query.Where(obj.Query.APBatchID.Equal(vBatchID))
        If Not obj.Query.Load Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If
        Me.bsRpt.DataSource = obj

        Dim oBatch As New LoadAPBatch
        If Not oBatch.LoadByPrimaryKey(vBatchID) Then
            MsgBox("Error retrieving Batch data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If
        Me.bsAPBatch.DataSource = oBatch


        Dim vTotalBillings As Decimal = 0.0
        Dim vDirectCharges As Decimal = 0.0

        For Each oChrg As esViewLoadChargesForBDF In obj
            vTotalBillings = vTotalBillings + oChrg.Totalbillings
            If oChrg.LoadType = "DIRECT" Then
                vDirectCharges = vDirectCharges + oChrg.CarrierCharges
            End If
        Next

        vTotalReceivable = vTotalBillings - vDirectCharges

    End Sub
#End Region

    Private Sub lblTotalReceivable_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblTotalReceivable.BeforePrint
        lblTotalReceivable.Text = vTotalReceivable
    End Sub
End Class