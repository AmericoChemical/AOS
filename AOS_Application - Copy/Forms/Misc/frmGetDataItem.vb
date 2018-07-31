Public Class frmGetDataItem 
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vInputType As String
    Public vPrompt As String
    Public vString As String
    Public vDate As Date?
    Public vDecimal As Decimal
    Public vInteger As Integer


    Private Sub frmGetDataItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.grpTitle.Text = vPrompt
        Select Case vInputType
            Case "DATE"
                eDate.Visible = True
                eString.Visible = False
                eInteger.Visible = False
                eDecimal.Visible = False
            Case "INTEGER"
                eDate.Visible = False
                eString.Visible = False
                eInteger.Visible = True
                eDecimal.Visible = False
            Case "DECIMAL"
                eDate.Visible = False
                eString.Visible = False
                eInteger.Visible = False
                eDecimal.Visible = True
            Case Else
                eDate.Visible = False
                eString.Visible = True
                eInteger.Visible = False
                eDecimal.Visible = False
        End Select
        eString.EditValue = vString
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Select Case vInputType
            Case "DATE"
                vDate = eDate.EditValue
            Case "INTEGER"
                vInteger = eInteger.EditValue
            Case "DECIMAL"
                vDecimal = IIf(IsDBNull(eDecimal.EditValue), Nothing, eDecimal.EditValue)
            Case Else
                vString = eString.EditValue
        End Select

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class