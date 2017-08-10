Imports AOS.BusinessObjects

Public Class frmAssignAPISLinkToProductionOrder

    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer        'Input Variable
    Public vAPISNum As Integer = 0      'Output Variable

    Private oAPIS As ViewAPISDataCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        oAPIS = New ViewAPISDataCollection
        oAPIS.Query.Where(oAPIS.Query.Productid.Equal(vProductID), oAPIS.Query.Or(oAPIS.Query.Apisstatus.Equal("ACTIVE"), oAPIS.Query.Apisstatus.Equal("SINGLE USE")))
        oAPIS.Query.Load()
        oAPIS.Sort = "APISNum"
        bsAPIS.DataSource = oAPIS
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
         Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs)
        vAPISNum = 0
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub eAPISNum_EditValueChanged(sender As Object, e As System.EventArgs) Handles eAPISNum.EditValueChanged
        vAPISNum = eAPISNum.EditValue
    End Sub
End Class