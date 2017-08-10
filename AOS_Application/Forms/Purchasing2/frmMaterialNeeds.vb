
Imports AOS.BusinessObjects
Imports System.Text

Public Class frmMaterialNeeds
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadMaterialPlanningList()
    End Sub

    Private Sub RibbonControl2_SelectedPageChanged(sender As Object, e As EventArgs) Handles RibbonControl2.SelectedPageChanged
        Dim vNum As Integer
        If Me.RibbonControl2.SelectedPage.Name = "" Then
            vNum = 2
        Else
            vNum = CInt(Me.RibbonControl2.SelectedPage.Name.Substring(10, 1))
        End If
        Dim ctlPage As New DevExpress.XtraEditors.PanelControl
        ctlPage = Me.WorkPanelsHolder2.Controls("RibbonPanelControl" & vNum.ToString)
        If Not ctlPage Is Nothing Then
            ctlPage.BringToFront()
        End If
    End Sub

    Private Sub grMaterialPlanning_Click(sender As Object, e As EventArgs) Handles grMaterialPlanning.Click
        populateMaterialTabs()
    End Sub

    Private Sub btnRetrieveMaterialNeeds_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRetrieveMaterialNeeds.ItemClick
        loadMaterialPlanningList()
    End Sub

    Private Sub btnCreatePurchaseItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreatePurchaseItems.ItemClick
        Dim oMaterialProduct As New ViewMaterialProductInfoCollection

        'check if count is equal to 0
        If bsMaterialPlanning.Count = 0 Then
            Exit Sub
        End If

        oMaterialProduct = getMaterialproduct(bsMaterialPlanning.Current.MATERIALID)

        Dim vProductID As Integer = 0
        If bsPurchaseProducts.Count > 0 Then
            vProductID = bsPurchaseProducts.Current.Productid
        Else
            Exit Sub 'there are no Products to actual select to order from a vendor here
        End If

        Using frm As New frmAddEditPurchaseItem() With
            {
                .vCalledFrom = "MATERIALPLANNING",
                .vMaterialID = bsMaterialPlanning.Current.MATERIALID,
                .vDefaultProductID = vProductID,
                .vEditType = "ADD",
                .vAvailableQty = -bsMaterialPlanning.Current.RMAvailable,
                .vPurchaseItemType = PurchaseItemType.MATERIAL.ToString(),
                .vMaterialProduct = oMaterialProduct
            }
            frm.ShowDialog()
        End Using
        loadMaterialPlanningList()
    End Sub

    Private Sub btnConvert_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConvert.ItemClick
        If bsFullAvailableInventory.Count > 0 Then
            If MsgBox("Are you sure you want to convert the selected Inventory Item to In Process?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim rItem As New Invitem
            If Not rItem.LoadByPrimaryKey(bsFullAvailableInventory.Current.InvItemNumber) Then
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

            loadFullAvailableInventory()
        End If

        loadMaterialPlanningList()
    End Sub

    Private Sub loadMaterialPlanningList()
        bsMaterialPlanning.DataSource = getunAvailableMaterial()
        populateMaterialTabs()
    End Sub

    ''' <summary>
    ''' Populate Material Tabs for corresponding PurchaseProducts, ProdcutionOrder and FullAvailableInventory
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub populateMaterialTabs()
        loadPurchaseProducts()
        loadProductionOrder()
        loadFullAvailableInventory()
    End Sub

    Private Sub loadPurchaseProducts()
        If bsMaterialPlanning.Current Is Nothing Then
            bsPurchaseProducts.DataSource = Nothing
            Exit Sub
        End If
        Dim oPurchaseProducts As New ViewPurchaseProductsListCollection
        oPurchaseProducts.Query.Where(oPurchaseProducts.Query.Materialid.Equal(bsMaterialPlanning.Current.MATERIALID))
        oPurchaseProducts.Query.Load()
        bsPurchaseProducts.DataSource = oPurchaseProducts
        'enableCreatePurchaseItem()
    End Sub

    Private Sub loadProductionOrder()
        If bsMaterialPlanning.Current Is Nothing Then
            bsProductionOrder.DataSource = Nothing
            RibbonPage3.Text = "Production Orders"
            Exit Sub
        End If
        bsProductionOrder.DataSource = getProdcutionOrdersByMaterialID(bsMaterialPlanning.Current.MATERIALID)
        RibbonPage3.Text = String.Format("{0} - Production Orders", bsProductionOrder.Count)
    End Sub

    Private Sub loadFullAvailableInventory()
        If bsMaterialPlanning.Current Is Nothing Then
            bsFullAvailableInventory.DataSource = Nothing
            RibbonPage4.Text = "Full Available Inventory"
            Exit Sub
        End If
        bsFullAvailableInventory.DataSource = getAvailableInventoryItemsByMaterialIDForMaterialNeeds(bsMaterialPlanning.Current.MATERIALID)
        RibbonPage4.Text = String.Format("{0} - Full Available Inventory", bsFullAvailableInventory.Count)
    End Sub

    Private Sub btnClose_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        closeForm()
    End Sub

    Private Sub closeForm()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub grvMaterialPlanning_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles grvMaterialPlanning.RowClick
        populateMaterialTabs()
    End Sub

    Private Sub enableCreatePurchaseItem()
        btnCreatePurchaseItems.Enabled = (bsPurchaseProducts.Count > 0)
    End Sub

    Private Sub grViewProductionOrders_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grviewProductionOrders.RowCellClick

        If (e.Column.Name <> "colProductionOrderNum") Then
            Exit Sub
        End If

        If ((String.IsNullOrEmpty(e.CellValue)) OrElse
            (e.CellValue <= 0)) Then
            Exit Sub
        End If

        Select Case e.Column.Name
            Case "colProductionOrderNum"
                Using frm As New frmAddEditProdOrder() With
                          {
                              .vID = e.CellValue,
                              .vEditType = "EDIT"
                          }
                    frm.ShowDialog()
                End Using
                loadProductionOrder()

                'Case "colSourcedocument"

                '    Select Case grviewProductionOrders.GetRowCellDisplayText(e.RowHandle, grviewProductionOrders.Columns("Sourcetype"))
                '        Case SourceType.PRCH.ToString()
                '            Using frm As New frmAddEditPurchaseItem() With
                '              {
                '                  .vID = e.CellValue,
                '                  .vEditType = "READONLY"
                '              }
                '                frm.ShowDialog()
                '            End Using
                '        Case SourceType.PORD.ToString()
                '            Using frm As New frmAddEditProdOrder() With
                '              {
                '                  .vID = e.CellValue,
                '                  .vEditType = "READONLY"
                '              }
                '                frm.ShowDialog()
                '            End Using
                '        Case SourceType.RLBL.ToString()
                '            Dim oRelabelorderitem As New Relabelorderitem()
                '            If oRelabelorderitem.LoadByPrimaryKey(e.CellValue) = False Then
                '                Exit Sub
                '            End If
                '            Using frm As New frmAddEditRelabelOrder() With
                '                {
                '                    .vRelabelOrderNumber = oRelabelorderitem.Relabelordernumber,
                '                    .vEditType = "READONLY"
                '                }
                '                frm.ShowDialog()
                '            End Using
                '    End Select

        End Select

    End Sub

    Private Sub bsMaterialPlanning_CurrentChanged(sender As Object, e As EventArgs) Handles bsMaterialPlanning.CurrentChanged
        populateMaterialTabs()
        setOptionButtons()
    End Sub

    Private Sub rbtnCreateProductionOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCreateProductionOrder.ItemClick

        Dim frm As New frmAddEditProdOrder
        frm.vEditType = "ADD"
        frm.vAvailableQty = bsMaterialPlanning.Current.RMAvailable
        frm.vProductID = bsPurchaseProducts.Current.ProductID
        frm.vFrmSource = "MaterialNeeds"
        If frm.ShowDialog() = Windows.Forms.DialogResult.Abort Then
            ' New production order was not created
            MsgBox("Production Order was not created", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If
        loadMaterialPlanningList()

    End Sub

    Private Sub bsPurchaseProducts_CurrentChanged(sender As Object, e As EventArgs) Handles bsPurchaseProducts.CurrentChanged
        If bsPurchaseProducts.Count <= 0 Then
            Exit Sub
        End If
        setOptionButtons()
    End Sub

    Private Sub setOptionButtons()

        'set Purchase Item button status
        Dim oCosts As New ProductcostCollection
        oCosts.Query.Where(oCosts.Query.Productid.Equal(bsPurchaseProducts.Current.ProductID))
        If oCosts.Query.Load Then
            btnCreatePurchaseItems.Enabled = True
        Else
            btnCreatePurchaseItems.Enabled = False
        End If

        'Set Production Order Button status
        Dim oApis As New ApisCollection
        oApis.Query.Where(oApis.Query.Productid.Equal(bsPurchaseProducts.Current.ProductID), oApis.Query.Apisstatus.Equal("ACTIVE"))
        If oApis.Query.Load Then
            rbtnCreateProductionOrder.Enabled = True
        Else
            rbtnCreateProductionOrder.Enabled = False
        End If


    End Sub


End Class