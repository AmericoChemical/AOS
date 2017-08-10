Public Class rptSubRelabelInstructions
    Public Sub New(ByVal vProductId As Integer, vAssociatedProductId As Integer)
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata(vProductId, vAssociatedProductId)
    End Sub
    Private Sub getdata(ByVal vProductId As Integer, vAssociatedProductId as integer)

        Dim oProductRelabelInstructions As ViewProductRelabelInstructionCollection = getProductRelabelInstructions(vProductId, vAssociatedProductId)

        If oProductRelabelInstructions.Count = 0 Then
            Me.ClosePreview()
        End If
        Me.bsProductInstructions.DataSource = oProductRelabelInstructions
    End Sub

End Class