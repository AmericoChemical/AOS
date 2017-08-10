Imports AOS.BusinessObjects

Public Class frmVendorList

    Dim oVendors As VendorCollection
    Public vID As Integer

    Private Sub frmVendorList_Load(sender As Object, e As EventArgs) Handles Me.Load
        oVendors = New VendorCollection
        oVendors.Query.Where(oVendors.Query.Isactive.Equal(1))
        If oVendors.Query.Load Then
            oVendors.Sort = "VENDORNAME, VENDORCITY"
            bsVendors.DataSource = oVendors
        End If
    End Sub

    Private Sub rbtnSelectVendor_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSelectVendor.ItemClick
        If bsVendors.Count > 0 Then
            vID = bsVendors.Current.VendorID
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub rbtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancel.ItemClick
        vID = 0
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub
End Class