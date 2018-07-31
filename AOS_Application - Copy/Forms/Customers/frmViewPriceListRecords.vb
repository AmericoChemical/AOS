Imports AOS.BusinessObjects

Public Class frmViewPriceListRecords
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vCustomerID As Integer       'object foreign key passed in by calling form
    Dim oPrices As New PricelistCollection
    Dim oProduct As New Product
    Dim oCustomer As New Customer
    Public oPrice As Pricelist

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        getProductData()
        getCustomerData()
        getPriceListData()
    End Sub

    Private Sub getProductData()
        oProduct = New Product
        oProduct.LoadByPrimaryKey(vProductID)
        bsProduct.DataSource = oProduct
        lblproductInfo.Text = oProduct.Productid & " - " & oProduct.Productdesc & " - " & oProduct.Container
    End Sub

    Private Sub getCustomerData()
        oCustomer = New Customer
        oCustomer.LoadByPrimaryKey(vCustomerID)
        bsCustomer.DataSource = oCustomer
        Me.Text = "Price List Item for " & bsCustomer.Current.CustName
    End Sub

    Private Sub getPriceListData()
        oPrices = New PricelistCollection
        oPrices.Query.Where(oPrices.Query.Productid.Equal(vProductID), oPrices.Query.Custid.Equal(vCustomerID))
        oPrices.Query.Load()
        bs.DataSource = oPrices
    End Sub

    Private Sub AddNewPriceListRecord()
        Dim frm As New frmUpdatePriceListItem
        frm.vProductID = bsProduct.Current.ProductID
        frm.vCustomerID = bsCustomer.Current.CustID
        frm.vAddtype = "ADD"
        frm.ShowDialog()
        getPriceListData()
    End Sub

    Private Sub EditPriceListRecord()
        If bs.Count <= 0 Then
            Exit Sub
        End If
        Dim frm As New frmUpdatePriceListItem
        frm.vProductID = bsProduct.Current.ProductID
        frm.vCustomerID = bsCustomer.Current.CustID
        frm.vAddtype = "EDIT"
        frm.vPriceListID = bs.Current.PriceListID
        frm.ShowDialog()
        getPriceListData()
    End Sub

    Private Sub DeletePriceListRecord()
        If bs.Count <= 0 Then
            Exit Sub
        End If
        If bs.Count = 1 Then
            MsgBox("You cannot delete the only Price List record for a product. Edit the existing Price List record or add a new Price List record.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Try
            Dim oPrice As Pricelist
            oPrice = New Pricelist
            oPrice.LoadByPrimaryKey(bs.Current.PriceListID)
            oPrice.MarkAsDeleted()
            oPrice.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
            Exit Sub
        End Try
        MsgBox("Price List record successfully deleted.")
        getPriceListData()
    End Sub

    Private Sub btnNewPriceListRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewPriceRecord.ItemClick
        AddNewPriceListRecord()
    End Sub

    Private Sub btnEditPriceListRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPriceRecord.ItemClick
        EditPriceListRecord()
    End Sub

    Private Sub btnDeletePriceListRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeletePriceRecord.ItemClick
        DeletePriceListRecord()
    End Sub

    Private Sub btnSelect_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelect.ItemClick
        If oPrices.Count <= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            oPrice = New Pricelist
            oPrice.LoadByPrimaryKey(bs.Current.PriceListID)
            If oPrice Is Nothing Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class