Imports AOS.BusinessObjects

Public Class rptInventoryOnFloorWithCosts

#Region " Designer generated code "

    Public Sub New()
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        FillDataSet()
    End Sub

#End Region

    Public Sub FillDataSet()


        Dim oRpt As New ViewRptInventoryValuationCollection
        If Not oRpt.LoadAll Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.bsRpt.DataSource = oRpt

    End Sub


End Class