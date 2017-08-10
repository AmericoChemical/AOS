Imports AOS.BusinessObjects

Public Class frmConvertAvailableInventoryItemsToRawMaterials
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vMaterialID As Integer

    Dim oMaterial As Material
    Dim oItems As ViewMaterialProductAvailableInventoryItemsCollection
    
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadMaterialData(vMaterialID)
        loadInventoryItemData(vMaterialID)
    End Sub

    Private Sub loadMaterialData(vMatID As Integer)
        If IsDBNull(vMatID) Or vMatID <= 0 Then
            MsgBox("No valid Material ID selected", MsgBoxStyle.Critical, "Error - Closing Form")
            Me.Close()
        End If

        oMaterial = New Material
        If Not oMaterial.LoadByPrimaryKey(vMatID) Then
            MsgBox("Material Information was not correctly retrieved from database", MsgBoxStyle.Critical, "Error")
            Me.Close()
        End If
        bsMaterial.DataSource = oMaterial

    End Sub

    Private Sub loadInventoryItemData(vMatID As Integer)

        oItems = New ViewMaterialProductAvailableInventoryItemsCollection
        oItems.Query.Where(oItems.Query.Materialid.Equal(vMatID))
        If Not oItems.Query.Load Then
            MsgBox("No available inventory items for the selected Material ID were found", MsgBoxStyle.Information, "No records found")
        End If
        bsItems.DataSource = oItems

    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub rbtnConvert_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnConvert.ItemClick
        If MsgBox("Are you sure you want to convert the selected inventory item to In Process?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim rItem As New Invitem
        If Not rItem.LoadByPrimaryKey(bsItems.Current.InvItemNumber) Then
            MsgBox("Cannot open database record for Inventory Item", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If

        Dim rProd As New Product
        If Not rProd.LoadByPrimaryKey(rItem.Productid) Then
            MsgBox("Cannot open database record for Product data", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If
        Try
            rItem.Inventoryclass = InventoryClass.INPROCESS
            rItem.Unitsremaining = rProd.Units
            rItem.Itemstatus = "IN PROCESS"
            rItem.Save()
            MsgBox("Inventory Item successfully converted", MsgBoxStyle.Information, "Conversion completed")
        Catch ex As Exception
            MsgBox("Error in converting Inventory Item", MsgBoxStyle.Critical, "Error")
        End Try

        loadInventoryItemData(vMaterialID)
    End Sub

    Private Sub rbtnAddNewPurchaseRequest_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        addNewPurchaseRequest()
    End Sub

    Private Sub addNewPurchaseRequest()
        Dim frm As New frmAddEditPurchaseRequest
        frm.vEditType = "ADD"
        frm.vFrmSource = "MaterialNeed"
        frm.vMaterialID = bsMaterial.Current.MaterialID
        frm.ShowDialog()
    End Sub

End Class