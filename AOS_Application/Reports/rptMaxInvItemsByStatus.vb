Public Class rptMaxInvItemsByStatus

    Public Sub New()
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata()
    End Sub

    Private Sub getdata()

        Dim oRpt As New ViewMaxInvItemsByStatusCollection
        If Not oRpt.LoadAll Then
            MsgBox("Error retrieving report data", MsgBoxStyle.Critical, "Error")
            Me.ClosePreview()
        End If

        Me.BindingSource1.DataSource = oRpt

    End Sub

End Class