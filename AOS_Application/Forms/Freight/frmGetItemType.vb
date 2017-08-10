Public Class frmGetItemType
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vItemType As String
    Private oTypes As ListItemtypeCollection

    Private Sub frmGetDataItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        oTypes = New ListItemtypeCollection
        oTypes.LoadAll()
        bsItemTypes.DataSource = oTypes
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        vItemType = eItemTypes.EditValue
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class