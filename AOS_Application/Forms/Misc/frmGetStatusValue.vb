Public Class frmGetStatusValue
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vStatusValue As String
    Public vType As String

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Select Case vType
            Case "PRODUCT"
                vStatusValue = eProductStatus.EditValue
        End Select

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        getData()
    End Sub

    Private Sub getData()

        Select Case vType
            Case "PRODUCT"
                eProductStatus.Visible = True
                Dim oProdStatus As New ListProductstatusCollection
                oProdStatus.LoadAll()
                bsProduct.DataSource = oProdStatus
        End Select

    End Sub
End Class