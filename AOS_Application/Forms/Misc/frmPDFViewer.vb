Public Class frmPDFViewer

    Public vSDSDocPath As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        SDSPdfViewer.DocumentFilePath = vSDSDocPath
    End Sub


End Class