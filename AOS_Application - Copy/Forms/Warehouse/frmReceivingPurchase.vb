
Imports AOS.BusinessObjects
Imports System.Text
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmReceivingPurchase
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vPurchaseNumber As Integer

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        editObject(vPurchaseNumber)
        LoadInventoryItems()
        LoadPurchaseItems()
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If

        Dim oPurchase As New Purchase
        oPurchase.LoadByPrimaryKey(vID)
        bsPurchase.DataSource = oPurchase

        If bsPurchase.Count > 0 Then
            Dim oVendor As New Vendor
            oVendor.LoadByPrimaryKey(bsPurchase.Current.Vendorid)
            bsVendor.DataSource = oVendor

            Dim oCustomer As New Customer
            oCustomer.LoadByPrimaryKey(bsPurchase.Current.Custid)
            bsCustomer.DataSource = oCustomer
        End If
    End Sub

    'Load Inventory Items based on Purchase Number
    Private Sub LoadInventoryItems()
        getInventoryItemsToBeReceived(vPurchaseNumber)
        getInventoryItemsAlreadyReceived(vPurchaseNumber)
        'bsInventoryItems.DataSource = getInvItemsByPurchaseNumber(vPurchaseNumber)
    End Sub

    Private Sub getInventoryItemsToBeReceived(vPONum As Integer)
        Dim oInvItems As New ViewInvItemListCollection
        oInvItems.Query.Where(oInvItems.Query.Purchasenumber.Equal(vPONum), oInvItems.Query.Itemstatus.In("PENDING"))
        oInvItems.Query.Load()
        oInvItems.Sort = "LOTNUMBER, INVITEMNUMBER ASC"
        bsInventoryItems.DataSource = oInvItems
    End Sub

    Private Sub getInventoryItemsAlreadyReceived(vPONum As Integer)
        Dim oInvItems As New ViewInvItemListCollection
        oInvItems.Query.Where(oInvItems.Query.Purchasenumber.Equal(vPONum), oInvItems.Query.Itemstatus.NotIn("PENDING"))
        oInvItems.Query.Load()
        oInvItems.Sort = "LOTNUMBER, INVITEMNUMBER ASC"
        bsReceivedItems.DataSource = oInvItems
    End Sub

    'Public Function getInvItemsByPurchaseNumber(ByVal vPurchaseNumber As Integer) As ViewInvItemListCollection
    '    Dim oInvItems As New ViewInvItemListCollection
    '    oInvItems.Query.Where(oInvItems.Query.Purchasenumber.Equal(vPurchaseNumber))
    '    oInvItems.Query.Load()
    '    oInvItems.Sort = "LOTNUMBER, INVITEMNUMBER ASC"
    '    Return oInvItems
    'End Function





    'Load Purchase Items based on Purchase Number
    Private Sub LoadPurchaseItems()
        bsPurchaseItems.DataSource = getPurchaseItemListByPurchaseNumber(vPurchaseNumber)
    End Sub

    Private Sub closeForm()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        closeForm()
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

    ''' <summary>
    ''' for entering the weight for received item
    ''' if single item go for update Inventory Item screen
    ''' else go to enter scale weight screen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnReceiveInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceiveInventory.ItemClick
        If bsInventoryItems.Count = 0 OrElse
            grvInventoryItems.SelectedRowsCount <= 0 Then
            Exit Sub
        End If
        Dim vIndex As Integer = 0
        Dim vCommaSeparatedInvitemnumber As New StringBuilder

        Dim vInvID As Integer = 0
        Dim vBulkItems As Boolean = False

        'loop through the selected item(s) in the grid
        For vIndex = 0 To grvInventoryItems.SelectedRowsCount - 1

            'determine if ANY of the items are to be received as BULK Inventory
            vInvID = grvInventoryItems.GetRowCellValue(grvInventoryItems.GetSelectedRows.GetValue(vIndex), grvInventoryItems.Columns(0))
            If Not IsDBNull(vInvID) Then
                Dim oInv As New Invitem
                If oInv.LoadByPrimaryKey(vInvID) Then
                    Dim oProd As New Product
                    If oProd.LoadByPrimaryKey(oInv.Productid) Then
                        If oProd.Bulkinventory = True Then
                            vBulkItems = True
                        End If
                    End If
                End If
            End If

            vCommaSeparatedInvitemnumber.Append(grvInventoryItems.GetRowCellValue(
                                                grvInventoryItems.GetSelectedRows.GetValue(vIndex),
                                                grvInventoryItems.Columns(0))).Append(IIf(vIndex = (grvInventoryItems.SelectedRowsCount - 1), String.Empty, "','"))
        Next

        If vBulkItems Then
            If grvInventoryItems.SelectedRowsCount > 1 Then
                MsgBox("You have selected one or more BULK INVENTORY items, which can only be received individually.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                'You have selected one BULK INVENTORY record to receive
                'This process works through one or more LOT NUMBERS that the user will now receive against
                Dim frm As New frmBulkReceivingStep1
                frm.vInvItemID = vInvID
                frm.ShowDialog()
                updateReceivedPurchaseItem(vInvID)
            End If
        Else
            'User did NOT select BULK INVENTORY Items to receive
            ' Below screen is used to handle one inventory item but this screen will also decide if it needs to show multiple inventory item update screen
            If grvInventoryItems.SelectedRowsCount > 1 Then
                Using frm As New frmEnterScaleWeight() With
                {
                      .vCommaSeparatedInvitemnumber = vCommaSeparatedInvitemnumber.ToString()
                }
                    frm.ShowDialog()
                End Using
            Else
                Using frm As New frmUpdateInventoryItem() With
                      {
                            .vInvitemnumber = vCommaSeparatedInvitemnumber.ToString(),
                            .vSource = "SINGLE"
                      }
                    frm.ShowDialog()
                End Using
            End If
        End If

        LoadInventoryItems()
    End Sub

    Private Sub btnQuantityDelivered_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnQuantityDelivered.ItemClick
        If bsPurchaseItems.Count = 0 Then
            MsgBox("Please select a Purchase Item to receive extra quantity", MsgBoxStyle.Critical, "Purchase Item")
            Exit Sub
        End If

        If MsgBox("This action will create separate Purchase Item record and Inventory Item records for extra items that vendor sent. Are you sure you want to continue?", MsgBoxStyle.YesNo, "Confirm Purchase Item") = vbYes Then
            Using frm As New frmAdditionalQuantity() With
             {
                 .vPurchaseItemID = bsPurchaseItems.Current.Purchaseitemid
             }
                frm.ShowDialog()
            End Using
        End If

        LoadInventoryItems()
        LoadPurchaseItems()

    End Sub

    Private Sub grvInventoryItems_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grvInventoryItems.RowCellClick

        If (e.Column.Name <> "colSourcedoc") AndAlso
          (e.Column.Name <> "colInvitemnumber") Then
            Exit Sub
        End If

        If ((String.IsNullOrEmpty(e.CellValue)) OrElse
           (e.CellValue <= 0)) Then
            Exit Sub
        End If

        Select Case e.Column.Name
            Case "colSourcedoc"
                'Using frm As New frmAddEditPurchaseItem() With
                '    {
                '        .vID = bsInventoryItems.Current.Sourcedocument,
                '        .vEditType = "EDIT"
                '    }
                '    frm.ShowDialog()
                'End Using
            Case "colInvitemnumber"
                Using frm As New frmInventoryItemDetails() With
                    {
                        .vID = e.CellValue
                    }
                    frm.ShowDialog()
                End Using
        End Select
        LoadInventoryItems()
    End Sub

    Private Sub grvPurchaseItems_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grvPurchaseItems.RowCellClick
        If (e.Column.Name <> "colPrchSourcedoc") AndAlso
           (e.Column.Name <> "colPurchaseitemid") Then
            Exit Sub
        End If

        If ((String.IsNullOrEmpty(e.CellValue)) OrElse
            (e.CellValue <= 0)) Then
            Exit Sub
        End If


        Select Case e.Column.Name
            Case "colPrchSourcedoc"
                Select Case bsPurchaseItems.Current.SourceType
                    Case PurchaseItemSourceType.WORKORDER.ToString()
                        Using frm As New frmAddEditWorkOrders() With
                            {
                                .vWorkorderNum = bsPurchaseItems.Current.Sourcedocument,
                                .vEditType = "EDIT"
                            }
                            frm.ShowDialog()
                        End Using
                    Case PurchaseItemSourceType.RELABEL.ToString()
                        Using frm As New frmAddEditRelabelOrder() With
                            {
                                .vRelabelOrderNumber = bsPurchaseItems.Current.Sourcedocument,
                                .vEditType = "EDIT"
                            }
                            frm.ShowDialog()
                        End Using
                End Select
            Case "colPurchaseitemid"
                'Using frm As New frmAddEditPurchaseItem() With
                '            {
                '                .vID = e.CellValue,
                '                .vEditType = "EDIT"
                '            }
                '    frm.ShowDialog()
                'End Using
        End Select
        LoadPurchaseItems()
    End Sub

    Private Sub btnRetrievePurchaseItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRetrievePurchaseItems.ItemClick
        LoadPurchaseItems()
    End Sub

    Private Sub rbtnForceRCVDHOLD_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnForceRCVDHOLD.ItemClick
        If bsInventoryItems.Count <= 0 Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to move the selected Inventory Item to a Received / Hold Status?", MsgBoxStyle.YesNo, "Confirm - Status Change") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim vReason As String = getUserString("Enter the reason you are moving this item to RECEIVED / HOLD status:")
        Dim vPriorStatus As String = Nothing

        Dim oItem As New Invitem
        If Not oItem.LoadByPrimaryKey(bsInventoryItems.Current.Invitemnumber) Then
            Exit Sub
        End If
        vPriorStatus = oItem.Itemstatus
        oItem.Itemstatus = "RCVDHOLD"
        oItem.Save()

        addRcvdHoldRecord(oItem.Invitemnumber, "DOCK-MANUAL", vReason, vPriorStatus, False)
        LoadInventoryItems()



    End Sub

    Private Sub grvItems_RowStyle(sender As Object, e As RowStyleEventArgs) Handles grvItems.RowStyle

        If (e.RowHandle >= 0) Then

            'Check to see if Item Status = "RCVDHOLD"
            Dim vStatus As String = grvItems.GetRowCellDisplayText(e.RowHandle, grvItems.Columns("Itemstatus"))
            If vStatus = "RCVDHOLD" Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.Red
                e.Appearance.ForeColor = Color.White
                Exit Sub
            End If

        End If



    End Sub

End Class