Imports AOS.BusinessObjects

Public Class frmViewProductCostRecords
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer       'object primary key (passed in by calling form for edit mode)
    Dim oCosts As New ProductcostCollection
    Dim oProduct As New Product
    Public oCost As Productcost
    Public oVendors As VendorCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        getVendors()
        getProductCostData()
    End Sub

    Private Sub getVendors()
        oVendors = getVendorCollection()
        bsVendors.DataSource = oVendors
    End Sub
    Private Sub getProductData()
        oProduct = getProductByProductID(vProductID)
        bsProduct.DataSource = oProduct
        lblproductInfo.Text = oProduct.Productid & " - " & oProduct.Productdesc & " - " & oProduct.Container
        bTxtVolumeUnits.Caption = IIf(IsDBNull(oProduct.Volumeunits), DBNull.Value, oProduct.Volumeunits)
        bTxtVolumeUOM.Caption = IIf(IsDBNull(oProduct.Volumeuom), DBNull.Value, oProduct.Volumeuom)
        bTxtlVolumeStandardCost.Caption = IIf(IsDBNull(oProduct.Volumestandardcost), DBNull.Value, oProduct.Volumestandardcost)
        bTxtWeightUnits.Caption = IIf(IsDBNull(oProduct.Weightunits), DBNull.Value, oProduct.Weightunits)
        bTxtWeightUOM.Caption = IIf(IsDBNull(oProduct.Weightuom), DBNull.Value, oProduct.Weightuom)
        bTxtWeightStandardCost.Caption = IIf(IsDBNull(oProduct.Weightstandardcost), DBNull.Value, oProduct.Weightstandardcost)
    End Sub
    
    Private Sub getProductCostData()
        oCosts = getProductCostDataCollectionsByProductID(vProductID)
        bs.DataSource = oCosts
        getProductData()
    End Sub

    Private Sub btnNewCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewCostRecord.ItemClick
        AddNewCostRecord(bsProduct.Current.productID)
        getProductCostData()
    End Sub

    Private Sub btnEditCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditCostRecord.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If
        EditCostRecord(bs.Current.productID, bs.Current.costRecID)
        getProductCostData()
    End Sub

    Private Sub btnDeleteCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteCostRecord.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If
        'If bs.Count = 1 Then
        '    MsgBox("You cannot delete the only cost record for a product. Edit the existing cost record or add a new cost record.", MsgBoxStyle.Critical, "Error")
        '    Exit Sub
        'End If

        DeleteCostRecord(bs.Current.costRecID)
        getProductCostData()
    End Sub

    Private Sub btnSelect_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelect.ItemClick
        If oCosts.Count <= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            oCost = New Productcost
            oCost.LoadByPrimaryKey(bs.Current.costRecID)
            If oCost Is Nothing Then
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