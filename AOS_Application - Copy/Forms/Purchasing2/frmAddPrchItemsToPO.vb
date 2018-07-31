
Imports AOS.BusinessObjects
Imports AOS.PurchaseProcessing

Public Class frmAddPrchItemsToPO
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub
    Public vCommaSeparatedPurchaseItemIds As String

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadVendorList()
        getPurchaseOrders()
    End Sub

    Private Sub loadVendorList()
        Dim oVendorList As New VendorCollection
        oVendorList = getVendorCollection()
        bsVendorList.DataSource = oVendorList
    End Sub

    Private Sub getPurchaseOrders()
        If String.IsNullOrEmpty(vCommaSeparatedPurchaseItemIds) Then
            Exit Sub
        End If
        Dim oPurchaseItems As New PurchaseitemCollection
        oPurchaseItems = getPurchaseItemsByPurchaseItemIDs(vCommaSeparatedPurchaseItemIds)
        If (oPurchaseItems.Count <= 0) Then
            Exit Sub
        End If
        Dim oPurchaseList As New ViewPurchaseOrdersCollection
        oPurchaseList = getViewPurchaseOrders(String.Format(
                                                    "{0}','{1}", _
                                                    PurchaseItemsStatus.PENDING.ToString(),
                                                    PurchaseItemsStatus.ORDERED.ToString()
                                                ), _
                                                oPurchaseItems(0).Vendorid, _
                                                IIf(
                                                    oPurchaseItems(0).Purchaseitemtype = PurchaseItemType.DIRECT.ToString(), _
                                                    PurchaseType.DIRECT.ToString(), _
                                                    PurchaseType.REGULAR.ToString()
                                                ), _
                                                "Expectedindate DESC")
        bsPendingPOs.DataSource = oPurchaseList
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSelect_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelect.ItemClick

        If IsNothing(bsPendingPOs.Current) Then
            MsgBox("Select at least one Purchase Order to proceed.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim oPurchase As New Purchase
        If (oPurchase.LoadByPrimaryKey(bsPendingPOs.Current.Purchasenumber) = False) Then
            Exit Sub
        End If
        If (oPurchase.Purchasestatus = PurchaseStatus.ORDERED.ToString()) Then
            If MsgBox("Purchase Order that you selected is in ORDERED status, " & _
                      "are you sure you want to add selected Purchase Item(s) to this Purchase Order?", _
                      MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        setPurchaseNumberInPurchaseItems(oPurchase, vCommaSeparatedPurchaseItemIds)

        'If Item is added to and ordered purchase order, need to approve the adding purchase items
        If (oPurchase.Purchasestatus = PurchaseStatus.ORDERED.ToString()) Then
            approvePurchaseOrderItems(oPurchase, vCommaSeparatedPurchaseItemIds)
        End If

        Using frm As New frmAddEditPO() With
           {
              .vEditType = "EDIT",
              .vPurchaseNumber = bsPendingPOs.Current.Purchasenumber,
              .vCommaSeparatedPurchaseItemIds = vCommaSeparatedPurchaseItemIds
           }
            frm.ShowDialog()
        End Using

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class