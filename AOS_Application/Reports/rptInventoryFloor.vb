Imports AOS.BusinessObjects

Public Class rptInventoryFloor

    Public Sub New(ByVal vID As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vID)
    End Sub

    Private Sub getdata(ByVal vID As Integer)

        Dim oRpt As New ViewRptInventoryOnFloorAvailableAllocatedCollection
        If Not oRpt.LoadAll Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.bsRpt.DataSource = oRpt

    End Sub
End Class