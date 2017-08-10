Imports AOS.BusinessObjects

Public Class frmRptCriteria1

    Public vSalesID As Integer
    Public vCustomerID As Integer
    Public vBeginDate As Date
    Public vEndDate As Date

    Private oCustomers As CustomerCollection

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        vCustomerID = luCustomer.EditValue
        vBeginDate = deBegin.EditValue
        vEndDate = deEnd.EditValue
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        getCustomerData()
    End Sub

    Private Sub getCustomerData()
        oCustomers = New CustomerCollection
        oCustomers.LoadAll()
        oCustomers.Sort = "CustName"
        bsCustomers.DataSource = oCustomers
    End Sub
End Class