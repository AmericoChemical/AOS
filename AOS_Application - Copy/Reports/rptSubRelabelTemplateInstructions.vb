Public Class rptSubRelabelTemplateInstructions
    Public Sub New()
        MyBase.New()
        'This call is required by the Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        getdata()
    End Sub
    Private Sub getdata()

        Dim oInstructions As New RelabelinstructionCollection
        oInstructions.LoadAll()
        oInstructions.Sort = "SEQUENCE"
        Me.bsInstructions.DataSource = oInstructions

    End Sub


End Class