Imports AOS.BusinessObjects
Imports AOS.PurchaseProcessing
Imports System.Text

Public Class viewDWOPurchasing
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim vDWOItemStatus As String = PurchaseItemsStatus.REQUESTED.ToString()
    Dim vDWOPurchaseStatus As String = "PENDING"
    Dim vDWOSelectedVendorName As String

    Private Sub DWOTimer1_Tick(sender As Object, e As EventArgs) Handles DWOTimer1.Tick
        DWOTimer1.Stop()
        loadVendorList()
        DWOgetPurchaseOrders(vDWOPurchaseStatus)
    End Sub

    Private Sub DWORibbonControl1_SelectedPageChanged(sender As Object, e As EventArgs) Handles DWORibbonControl1.SelectedPageChanged
        Dim vNum As Integer
        If Me.DWORibbonControl1.SelectedPage.Name = "" Then
            vNum = 1
        Else
            vNum = CInt(Me.DWORibbonControl1.SelectedPage.Name.Substring(10, 1))
        End If
        Dim ctlPage As New DevExpress.XtraEditors.PanelControl
        ctlPage = Me.DWOWorkPanelsHolder.Controls("RibbonPanelControl" & vNum.ToString)
        If Not ctlPage Is Nothing Then
            ctlPage.BringToFront()
        End If
    End Sub
    Private Sub loadVendorList()
        Dim oVendorList As New VendorCollection
        oVendorList = getVendorCollection()
        DWObsVendorList.DataSource = oVendorList
    End Sub


    Private Sub viewDOWPurchasing_Load(sender As Object, e As EventArgs) Handles Me.Load
        getDWOPurchaseItemsList(PurchaseItemsStatus.REQUESTED.ToString(), PurchaseItemsType.DIRECT.ToString())
    End Sub

    Private Sub getDWOPurchaseItemsList(PURCHASEITEMSTATUS As String, PURCHASETYPE As String)
        DWObsPurchaseItems.DataSource = getPurchaseItems(PURCHASEITEMSTATUS, PURCHASETYPE, "Dateneeded, Itemid")

        If PURCHASEITEMSTATUS = PurchaseItemsStatus.REQUESTED.ToString() And PURCHASETYPE = PurchaseItemsType.DIRECT.ToString() Then
            DWORibbonPage1.Text = String.Format("{0} - DWO Requested", DWObsPurchaseItems.Count)
        End If
    End Sub

    Private Sub DWOgrvPurchaseItems_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles DWOgrvPurchaseItems.RowCellClick
        If (e.Column.Name <> "WorkOrder") Then
            Exit Sub
        End If
        If ((Not String.IsNullOrEmpty(e.CellValue)) OrElse (e.CellValue > 0)) Then
            Using frm As New frmAddEditWorkOrders() With
            {
                .vWorkorderNum = e.CellValue,
                .vEditType = "EDIT"
            }
                frm.ShowDialog()
            End Using
        End If
    End Sub

    Private Sub DWOgrvPurchaseItems_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles DWOgrvPurchaseItems.RowStyle
        If (e.RowHandle >= 0) Then
            If Convert.ToDateTime(DWOgrvPurchaseItems.GetRowCellDisplayText(e.RowHandle, DWOgrvPurchaseItems.Columns("Dateneeded"))) < Now.Date Then
                e.Appearance.BackColor = Color.Pink
                e.Appearance.BackColor2 = Color.Pink
                e.Appearance.ForeColor = Color.Black
                Exit Sub
            End If

            If String.IsNullOrEmpty(DWOgrvPurchaseItems.GetRowCellDisplayText(e.RowHandle, DWOgrvPurchaseItems.Columns("Vendorname"))) Or
                (String.IsNullOrEmpty(DWOgrvPurchaseItems.GetRowCellDisplayText(e.RowHandle, DWOgrvPurchaseItems.Columns("Unitcost"))) OrElse
                 DWOgrvPurchaseItems.GetRowCellDisplayText(e.RowHandle, DWOgrvPurchaseItems.Columns("Unitcost")) = 0) Then

                e.Appearance.BackColor = Color.Yellow
                e.Appearance.BackColor2 = Color.Yellow
                e.Appearance.ForeColor = Color.Black

                Exit Sub
            End If
        End If
    End Sub

    Private Sub DWObtnRetrievePurchaseItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnRetrivePurchasaeItems.ItemClick
        vDWOItemStatus = PurchaseItemsStatus.REQUESTED.ToString()
        getDWOPurchaseItemsList(vDWOItemStatus, PurchaseItemsType.DIRECT.ToString())
    End Sub

    Private Sub DWObtnAddPurchaseItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnAddPurchaseItem.ItemClick
        Using frm As New frmAddEditPurchaseItem() With
        {
            .vPurchaseType = "DIRECT",
            .vEditType = "ADD"
        }
            frm.ShowDialog()
        End Using
        getDWOPurchaseItemsList(vDWOItemStatus, PurchaseItemsType.DIRECT.ToString())
    End Sub

    Private Sub DWObtnEditPurchaseItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnEditPurchaseItem.ItemClick
        If IsNothing(DWObsPurchaseItems.Current) Then
            Exit Sub
        End If
        Using frm As New frmAddEditPurchaseItem() With
        {
            .vID = DWObsPurchaseItems.Current.PURCHASEITEMID,
            .vEditType = "EDIT"
        }
            frm.ShowDialog()
        End Using

        getDWOPurchaseItemsList(vDWOItemStatus, PurchaseItemsType.DIRECT.ToString())
    End Sub
    Private Sub DWObtnSplitPurchaseItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnSplitPurchaseItem.ItemClick
        If IsNothing(DWObsPurchaseItems.Current) Then
            Exit Sub
        End If
        If DWObsPurchaseItems.Current.Qty > 1 Then
            Using frm As New frmSplitPurchaseItem() With
             {
                 .vID = DWObsPurchaseItems.Current.PURCHASEITEMID
             }
                frm.ShowDialog()
            End Using
            getDWOPurchaseItemsList(vDWOItemStatus, PurchaseItemsType.DIRECT.ToString())
        Else
            Dim vMsg As String = String.Format("Selected Purchase Item cannot be split because quantity is {0}", Convert.ToInt32(DWObsPurchaseItems.Current.Qty))
            MsgBox(vMsg, MsgBoxStyle.Critical, "Split Item")
        End If
    End Sub

    Private Sub DWObtnPending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnPending.ItemClick
        vDWOItemStatus = PurchaseItemsStatus.PENDING.ToString()
        getDWOPurchaseItemsList(vDWOItemStatus, PurchaseItemsType.DIRECT.ToString())
    End Sub

    Private Sub DWObtnRequested_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnRequested.ItemClick
        vDWOItemStatus = PurchaseItemsStatus.REQUESTED.ToString()
        getDWOPurchaseItemsList(vDWOItemStatus, PurchaseItemsType.DIRECT.ToString())
    End Sub

    Private Sub DWObtnCancelled_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnCancelled.ItemClick
        vDWOItemStatus = PurchaseItemsStatus.CANCELLED.ToString()
        getDWOPurchaseItemsList(vDWOItemStatus, PurchaseItemsType.DIRECT.ToString())
    End Sub

    Private Sub DWObtnCreatePurchaseOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnCreatePurchaseOrder.ItemClick
        Dim vIndex As Integer = 0
        Dim vCommaSeparatedPurchaseItemId As New StringBuilder
        Dim vPurchaseNumber As Integer = 0

        vDWOSelectedVendorName = String.Empty
        For vIndex = 0 To DWOgrvPurchaseItems.SelectedRowsCount - 1
            If Not DWOValidateSelectedItems(Convert.ToString((DWOgrvPurchaseItems.GetRowCellValue(DWOgrvPurchaseItems.GetSelectedRows.GetValue(vIndex), DWOgrvPurchaseItems.Columns("Vendorname")))),
                                         DWOgrvPurchaseItems.GetRowCellValue(DWOgrvPurchaseItems.GetSelectedRows.GetValue(vIndex), DWOgrvPurchaseItems.Columns("Unitcost"))) Then
                Return
            End If
            vCommaSeparatedPurchaseItemId.Append(DWOgrvPurchaseItems.GetRowCellValue(DWOgrvPurchaseItems.GetSelectedRows.GetValue(vIndex), DWOgrvPurchaseItems.Columns(0))).Append(IIf(vIndex = (DWOgrvPurchaseItems.SelectedRowsCount - 1), String.Empty, "','"))
        Next
        If Not String.IsNullOrEmpty(vCommaSeparatedPurchaseItemId.ToString()) Then
            Using frm As New frmAddEditDirectPO() With
            {
               .vEditType = "ADD",
                .vCommaSeparatedPurchaseItemId = vCommaSeparatedPurchaseItemId.ToString()
            }
                frm.ShowDialog()
            End Using
            getDWOPurchaseItemsList(vDWOItemStatus, PurchaseItemsType.DIRECT.ToString())
        End If
        DWOgetPurchaseOrders("PENDING")
    End Sub

    Private Function DWOValidateSelectedItems(vVendor As String, vUnitCost As Decimal) As Boolean
        'Check that vendor and cost fields are filled
        If String.IsNullOrEmpty(vVendor) Or vUnitCost = 0 Then
            MsgBox("Vendor and cost should be filled in for the selected purchase items.", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        'Check that all rows have the same vendor
        If (Not String.IsNullOrEmpty(vDWOSelectedVendorName)) And vVendor <> vDWOSelectedVendorName Then
            MsgBox("Vendor should be same for the selected purchase items.", MsgBoxStyle.Critical, "Error")
            Return False
        Else
            vDWOSelectedVendorName = vVendor
        End If

        Return True
    End Function

    

    Private Sub DWOgetPurchaseOrders(ByVal vStatus As String)
        vDWOPurchaseStatus = vStatus
        If (vStatus = "CLOSED") Then
            DWObtnCancelPurchase.Enabled = False
        Else
            DWObtnCancelPurchase.Enabled = True
        End If

        Dim oPurchaseList As New PurchaseCollection
        oPurchaseList = getPurchaseList(vStatus, PurchaseItemsType.DIRECT.ToString())
        DWObsPOs.DataSource = oPurchaseList
    End Sub

    Private Sub DWObtnPendingOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnPendingOrders.ItemClick
        DWOgetPurchaseOrders("PENDING")
    End Sub

    Private Sub DWObtnOpenOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnOpenOrders.ItemClick
        DWOgetPurchaseOrders("OPEN")
    End Sub

    Private Sub DWObtnClosedOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnClosedOrders.ItemClick
        DWOgetPurchaseOrders("CLOSED")
    End Sub

    Private Sub DWObtnEditPurchase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnEditPurchase.ItemClick
        If DWObsPOs.Count <= 0 Then
            Exit Sub
        End If
        Using frm As New frmAddEditDirectPO() With
            {
                .vEditType = "EDIT",
                .vPurchaseNumber = DWObsPOs.Current.Purchasenumber
            }
            frm.ShowDialog()
        End Using
        DWOgetPurchaseOrders(vDWOPurchaseStatus)
    End Sub

    Private Sub DWObtnCancelPurchase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnCancelPurchase.ItemClick
        If DWObsPOs.Count <= 0 Then
            Exit Sub
        End If
        If DWObsPOs.Current.Purchasestatus = "PENDING" Or DWObsPOs.Current.Purchasestatus = "OPEN" Then

            Dim oPurchaseItems As PurchaseitemCollection = getNonReceivedPurchasedFulfilledPurchaseItems(DWObsPOs.Current.Purchasenumber)
            CancelDWOPurchaseItem(oPurchaseItems)

            updatePurchaseOrderStatus(DWObsPOs.Current.Purchasenumber, "CLOSED")
        End If
        DWOgetPurchaseOrders("PENDING")
    End Sub

    Private Sub DWObtnPrintPurchaseOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles DWObtnPrintPurchaseOrder.ItemClick
        DWOprintPO()
    End Sub

    Private Sub DWOprintPO()
        If DWObsPOs.Count <= 0 Then
            Exit Sub
        End If
        Dim vNum As Integer
        vNum = DWObsPOs.Current.Purchasenumber
        Dim rpt As New rptPurchaseOrder2(vNum)
        rpt.ShowPreview()
    End Sub

    Private Sub DWOloadPurchaseProducts(vMatID As Integer)
        DWObsPurchaseProducts.DataSource = getPurchaseProductsByMaterialID(vMatID)
    End Sub

End Class

