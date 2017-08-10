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


    Private Sub frmGetDataItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.grpTitle.Text = vPrompt
        Select Case vInputType
            Case "DATE"
                eDate.Visible = True
                eString.Visible = False
                eInteger.Visible = False
            Case "INTEGER"
                eDate.Visible = False
                eString.Visible = False
                eInteger.Visible = True
            Case Else
                eDate.Visible = False
                eString.Visible = True
                eInteger.Visible = False
        End Select
        eString.EditValue = vString
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If vInputType = "DATE" Then
            vDate = eDate.EditValue
        Else
            vString = eString.EditValue
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class