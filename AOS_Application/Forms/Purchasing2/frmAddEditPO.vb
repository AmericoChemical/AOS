Imports AOS.BusinessObjects
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmAddEditPO
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vPurchaseNumber As Integer
    Public vEditType As String
    Public vCommaSeparatedPurchaseItemIds As String

    Dim oProducts As ProductCollection
    Dim oPurchase As Purchase
    Dim oCustomers As CustomerCollection
    Dim oNewPurchaseItems As List(Of Purchaseitem) = New List(Of Purchaseitem)

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getProducts()
        getVendors()
        getCustomers()
        getPurchaseOrderTypes()

        If vEditType = "ADD" Then
            If vCommaSeparatedPurchaseItemIds = "" Then
                luCustomer.Properties.ReadOnly = False
                eVendor.Properties.ReadOnly = False
                ePurchaseOrderType.Properties.ReadOnly = False
                eVendorNotes.Text = ""
            End If
            vPurchaseNumber = createPurchaseOrderandAssignPrchItems(vCommaSeparatedPurchaseItemIds)
            'Vendor Order # is editable in add mode
            PONumberTextEdit.Properties.ReadOnly = False
            ePurchaseOrderType.Enabled = True

        Else
            ePurchaseOrderType.Enabled = False
        End If

        editObject(vPurchaseNumber)

        If oPurchase.Purchasetype = PurchaseType.REGULAR.ToString() AndAlso
           (oPurchase.Customerpo Is Nothing OrElse
            String.IsNullOrEmpty(oPurchase.Customerpo)) Then
            PONumberTextEdit.Text = oPurchase.Purchasenumber
        End If

        If oPurchase.Purchasetype = "DIRECT" Then
            rpgProcessOrder.Visible = True
        Else
            rpgProcessOrder.Visible = False
        End If
    End Sub

    Private Sub getPurchaseOrderTypes()
        Dim oTypes As New ListPurchaseordertypeCollection
        oTypes.LoadAll()
        bsPurchaseOrderTypes.DataSource = oTypes
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oPurchase = New Purchase
        oPurchase.LoadByPrimaryKey(vID)
        bsPurchase.DataSource = oPurchase
        If bsPurchase.Current.Purchasestatus = PurchaseStatus.CANCELLED.ToString() OrElse
            bsPurchase.Current.Purchasestatus = PurchaseStatus.COMPLETED.ToString() Then
            disableControls()
        End If

        getPOItems(vID)
    End Sub

    Private Sub disableControls()
        PONumberTextEdit.Properties.ReadOnly = True
        CustorderdateDateEdit.Properties.ReadOnly = True
        eVendor.Properties.ReadOnly = True
        luCustomer.Properties.ReadOnly = True
        ePOStatus.Properties.ReadOnly = True
        OrdertermsTextEdit.Properties.ReadOnly = True
        eInstructions.Properties.ReadOnly = True
        PurchaseNumberTextEdit.Properties.ReadOnly = True
        ExpectedInDateDateEdit.Properties.ReadOnly = True
        eCompany.Properties.ReadOnly = True
        eAddress1.Properties.ReadOnly = True
        eAddress2.Properties.ReadOnly = True
        eCity.Properties.ReadOnly = True
        eState.Properties.ReadOnly = True
        eZip.Properties.ReadOnly = True
        eContact.Properties.ReadOnly = True
        ePhone.Properties.ReadOnly = True
        btExpectedIn.Enabled = False
        ePurchaseOrderType.Properties.ReadOnly = True
    End Sub

    Private Sub getPOItems(ByVal vPurchaseNumber As Integer)
        Try
            bsPurchaseItems.DataSource = getPurchaseItemListByPurchaseNumber(vPurchaseNumber)
            grPurchaseItems.DataSource = bsPurchaseItems
            grPurchaseItems.Refresh()

            eGrossWgt.EditValue = getAccumulatedGrossWeight(vPurchaseNumber)

            enableApproval()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error in Calculating Gross Weight")
        End Try
    End Sub

    Private Function getAccumulatedGrossWeight(vPONum As Integer) As Decimal

        Dim oItems As New PurchaseitemCollection
        oItems.Query.Where(oItems.Query.Purchasenumber.Equal(vPONum))
        If Not oItems.Query.Load() Then
            Return 0.0
        End If

        Dim vTotal As Decimal = 0.0

        For Each oItem As Purchaseitem In oItems
            If oItem.Itemtype = "PRODUCT" Then
                Dim oProd As New Product
                If oProd.LoadByPrimaryKey(oItem.Itemid) Then
                    If IsDBNull(oProd.Container) Or oProd.Container = Nothing Then
                        'add only the weight of the material
                        vTotal = vTotal + (oItem.Qty * (IIf(IsDBNull(oProd.Stdweight), 0, oProd.Stdweight)))
                    Else
                        Try
                            Dim oContainer As New Container
                            If oContainer.LoadByPrimaryKey(oProd.Container) Then
                                vTotal = vTotal + (oItem.Qty * (IIf(IsDBNull(oProd.Stdweight), 0, oProd.Stdweight) + IIf(IsDBNull(oContainer.TareWeight), 0, oContainer.TareWeight)))
                            End If
                        Catch ex As Exception
                            MsgBox("There is no container for the Product " + oProd.Productid.ToString, MsgBoxStyle.Critical, "Error calculating Gross Weight")
                        End Try
                    End If

                End If
            End If
        Next

        Return vTotal

    End Function

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.LoadAll()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub getVendors()
        Dim oVendors As New VendorCollection
        oVendors = getVendorCollection()
        bsVendors.DataSource = oVendors
    End Sub

    Private Sub getCustomers()
        oCustomers = New CustomerCollection
        oCustomers.LoadAll()
        oCustomers.Sort = "CUSTNAME"
        bsCustomers.DataSource = oCustomers
    End Sub

    Private Function saveChanges()

        ' Update the Purchase Items with the entered Expected In Date
        If IsDBNull(ExpectedInDateDateEdit.EditValue) Then
            MsgBox("There Is no EXPECTED IN date.", MsgBoxStyle.Critical, "ERROR - Missing Expected In Date")
            Return False
        End If

        If Not setExpectedInDate(ExpectedInDateDateEdit.EditValue, False) Then
            Return False
        End If

        oPurchase.EndEdit()
        bsPurchase.EndEdit()

        bsPurchaseItems.EndEdit()
        If oPurchase.Purchasetype = PurchaseType.DIRECT.ToString() AndAlso
            (oPurchase.Customerpo Is Nothing OrElse
             String.IsNullOrEmpty(oPurchase.Customerpo)) Then
            MsgBox("Vendor Ref # Is required.", MsgBoxStyle.Critical, "Save Purchase Order - Error")
            Return False
        End If

        Dim vIndex As Integer = 0
        For vIndex = 0 To bsPurchaseItems.Count - 1
            If (bsPurchaseItems.List.Item(vIndex).ExpectedInDate Is Nothing Or IsDBNull(bsPurchaseItems.List.Item(vIndex).ExpectedInDate)) Then
                MsgBox("Expected In date Is required.", MsgBoxStyle.Information, "Save Purchase Order Warning")
                Exit For
            End If
        Next

        If bsPurchaseItems.Count <= 0 AndAlso
            vEditType = "ADD" Then
            MsgBox("You must have at least one item to save the purchase order", MsgBoxStyle.Critical, "Error - No items")
            Return False
        End If

        oPurchase.Save()

        If oPurchase.Customerpo Is Nothing Then
            oPurchase.Customerpo = oPurchase.Purchasenumber
            oPurchase.Save()
        End If
        Return True
    End Function

    Private Sub cancelChanges()

        If MsgBox("Are you sure you want to CANCEL your changes?", MsgBoxStyle.YesNo, "Confirm - Cancelling Changes") = MsgBoxResult.No Then
            Exit Sub
        End If

        'bsPurchase.EndEdit()

        'If vEditType = "ADD" Then
        '    Dim oPurchaseItems As New PurchaseitemCollection
        '    oPurchaseItems = getPurchaseItemsByPurchaseNumber(vPurchaseNumber)
        '    removePurchaseItems(oPurchaseItems)

        '    If oNewPurchaseItems.Count > 0 Then
        '        For Each oPurchaseItem As Purchaseitem In oNewPurchaseItems
        '            oPurchaseItem.MarkAsDeleted()
        '            oPurchaseItem.Save()
        '        Next
        '    End If

        '    deletePurchaseOrder(vPurchaseNumber)
        'End If

        'If vEditType = "EDIT" AndAlso
        '    vCommaSeparatedPurchaseItemIds <> "" Then

        '    Dim oPurchaseItems As PurchaseitemCollection = getPurchaseItemsByPurchaseItemIDs(vCommaSeparatedPurchaseItemIds)
        '    removePurchaseItems(oPurchaseItems)

        '    oPurchaseItems = getPurchaseItemsByPurchaseNumber(oPurchase.Purchasenumber)
        '    If oPurchaseItems Is Nothing OrElse
        '        oPurchaseItems.Count <= 0 Then
        '        updatePurchaseOrderStatus(oPurchase.Purchasenumber, PurchaseStatus.CANCELLED.ToString())
        '    End If
        'End If

        oPurchase.CancelEdit()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub editPOItem()
        If bsPurchaseItems.Count <= 0 Then
            Exit Sub
        End If
        If IsDBNull(eVendor.EditValue) Then
            MsgBox("You must select a Vendor first", MsgBoxStyle.Critical, "Error - No Vendor Selected")
            Exit Sub
        End If
        If bsPurchaseItems.Current.UOM = "MISC" Then
            Dim frmMisc As New frmAddEditPO2MiscItem
            frmMisc.vID = Me.bsPurchaseItems.Current.PURCHASEITEMID
            frmMisc.vPONumber = Me.bsPurchase.Current.PURCHASENUMBER
            frmMisc.vEditType = "EDIT"
            frmMisc.ShowDialog()
        Else
            Using frm As New frmAddEditPurchaseItem() With
            {
                .vID = bsPurchaseItems.Current.PURCHASEITEMID,
                .vEditType = "EDIT"
            }
                frm.ShowDialog()
            End Using
        End If
        getPOItems(Me.bsPurchase.Current.PURCHASENUMBER)
    End Sub

    Private Sub cancelPOItem()
        If bsPurchaseItems.Count <= 0 Then
            Exit Sub
        End If

        If bsPurchaseItems.Current.Purchaseitemstatus = PurchaseItemsStatus.FULFILLED.ToString() Or bsPurchaseItems.Current.PurchaseItemstatus = PurchaseItemsStatus.RECEIVED.ToString() Then
            MsgBox("You cannot cancel this item. It has already been received.", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If



        'If (IsDBNull(bsPurchaseItems.Current.SourceType) Or bsPurchaseItems.Current.SourceType = String.IsNullOrEmpty) And bsPurchaseItems.Current.PurchaseItemType <> "MATERIAL" Then
        '    'Delete Purchase Request if it is not linked to another event (i.e. WORKORDER, RELABEL ORDER)
        '    Dim oPurchItem As New Purchaseitem
        '    If oPurchItem.LoadByPrimaryKey(bsPurchaseItems.Current.PurchaseItemID) Then
        '        'Delete all inventory items where purchase items on this PO are marked as source ( SourceDoc=PURCHASEITEMID AND SourceType= PRCH)
        '        deleteInventoryItems(oPurchItem.Purchaseitemid,
        '                         SourceType.PRCH.ToString())

        '        'Delete all Load items where purchase items on this PO are marked as source ( SourceDoc=PURCHASEITEMID AND SourceType= PRCH)
        '        deleteLoadItems(oPurchItem.Purchaseitemid,
        '                    SourceType.PRCH.ToString())
        '        'Delete purchase item
        '        oPurchItem.MarkAsDeleted()
        '        oPurchItem.Save()
        '    End If
        'Else
        '    Dim vConfirm As String = "Please note that the Purchase Items will be changed to the requested status. This action cannot be undone. Do you want to continue?"
        '    If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
        '        Exit Sub
        '    End If


        'End If

        getPOItems(bsPurchase.Current.PURCHASENUMBER)


        ''If the item is the last for the purchase order
        ''Cancel the purchase order and the item and also the load
        'If bsPurchaseItems.Count = 1 Then
        '    If MsgBox("Removing the last purchase item will cancel the Purchase Order. Do you want to continue?", MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        'End If

        'Try
        '    Dim oPurchaseItems As PurchaseitemCollection = getPurchaseItemsByPurchaseItemIDs(bsPurchaseItems.Current.PURCHASEITEMID)
        'removePurchaseItems(oPurchaseItems)

        '    If bsPurchaseItems.Count = 1 Then
        '        updatePurchaseOrderStatus(bsPurchaseItems.Current.Purchasenumber, PurchaseStatus.COMPLETED.ToString())
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    sqlcnn.Close()
        'End Try
        'Dim vSuccessMessage As String = "Record successfully cancelled"
        'MsgBox(vSuccessMessage, MsgBoxStyle.Information, "Success")





    End Sub

    Private Sub deletePOItem()
        If bsPurchaseItems.Count <= 0 Then
            Exit Sub
        End If
        If bsPurchaseItems.Current.Purchaseitemstatus = PurchaseItemsStatus.FULFILLED.ToString() Then
            MsgBox("You cannot cancel this item. Because it was received.", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If
        Dim oPurchaseItem As New Purchaseitem
        If oPurchaseItem.LoadByPrimaryKey(bsPurchaseItems.Current.PURCHASEITEMID) = False Then
            Exit Sub
        End If
        Dim vConfirm As String = "Please note that the Purchase Item will be deleted. This action cannot be undone. Do you want to continue?"
        If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If

        'If the item is the last for the purchase order
        'Cancel the purchase order and the item and also the load
        If bsPurchaseItems.Count = 1 AndAlso
            vEditType <> "ADD" Then
            If MsgBox("Removing the last purchase item will cancel the Purchase Order. Do you want to continue?", MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Try
            deleteInventoryItems(bsPurchaseItems.Current.PURCHASEITEMID, SourceType.PRCH.ToString())

            deleteLoadItems(bsPurchaseItems.Current.PURCHASEITEMID, SourceType.PRCH.ToString())

            For Each oNewPurchaeItem As Purchaseitem In oNewPurchaseItems
                If (oNewPurchaeItem.Purchaseitemid = oPurchaseItem.Purchaseitemid) Then
                    oNewPurchaseItems.Remove(oNewPurchaeItem)
                    Exit For
                End If
            Next

            oPurchaseItem.MarkAsDeleted()
            oPurchaseItem.Save()

            If bsPurchaseItems.Count = 1 AndAlso
                vEditType <> "ADD" Then
                updatePurchaseOrderStatus(bsPurchaseItems.Current.Purchasenumber, PurchaseStatus.CANCELLED.ToString())
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try
        Dim vSuccessMessage As String = "Record successfully deleted"
        MsgBox(vSuccessMessage, MsgBoxStyle.Information, "Success")
        getPOItems(Me.bsPurchase.Current.PURCHASENUMBER)
        If bsPurchaseItems.Count = 0 AndAlso
            vEditType <> "ADD" Then
            cancelChanges()
        End If
    End Sub

    Private Function isNewPurchaseItem(vPurchaseItemID As Integer) As Boolean
        For Each oItem As Purchaseitem In oNewPurchaseItems
            If oItem.Purchaseitemid = vPurchaseItemID Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub addMiscCharge()
        Dim frm As New frmAddEditPO2MiscItem
        frm.vPONumber = Me.bsPurchase.Current.PURCHASENUMBER
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getPOItems(Me.bsPurchase.Current.PURCHASENUMBER)
    End Sub

    Private Sub closePO()
        Dim str As String = "Are you sure you want to close this purchase order?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        oPurchase.Purchasestatus = PurchaseStatus.COMPLETED.ToString()
        ePOStatus.Text = PurchaseStatus.COMPLETED.ToString()
        oPurchase.EndEdit()
        oPurchase.Save()
    End Sub

    Private Sub reOpenPO()
        Dim str As String = "Are you sure you want to re-open this purchase order?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        oPurchase.Purchasestatus = PurchaseItemsStatus.ORDERED.ToString()
        ePOStatus.Text = PurchaseItemsStatus.ORDERED.ToString()
        oPurchase.EndEdit()
        oPurchase.Save()
    End Sub


    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If saveChanges() = True Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        cancelChanges()
    End Sub
    Private Sub btnEditPOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPOItem.ItemClick
        editPOItem()
    End Sub

    Private Sub btnCancelItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelItem.ItemClick
        If bsPurchaseItems.Count <= 0 Then
            Exit Sub
        End If

        removePOItem(bsPurchaseItems.Current.PurchaseItemID)
        getPOItems(vPurchaseNumber)

        'If isNewPurchaseItem(bsPurchaseItems.Current.PURCHASEITEMID) Then
        '    deletePOItem()
        'Else
        '    cancelPOItem()
        'End If
    End Sub

    Private Sub removePOItem(vItemID As Integer)

        Dim oItem As New Purchaseitem
        If Not oItem.LoadByPrimaryKey(vItemID) Then
            MsgBox("Could Not locate Purchase Item record. Action failed.", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If

        If oItem.Purchaseitemstatus = PurchaseItemsStatus.FULFILLED.ToString() Or oItem.Purchaseitemstatus = PurchaseItemsStatus.RECEIVED.ToString() Then
            MsgBox("You cannot cancel this Purchase Item. It has already been received/fulfilled.", MsgBoxStyle.Information, "Warning")
            Exit Sub
        End If

        'Delete all inventory items where purchase items on this PO are marked as source ( SourceDoc=PURCHASEITEMID AND SourceType= PRCH)
        deleteInventoryItems(oItem.Purchaseitemid, SourceType.PRCH.ToString(), "PENDING")

        'Delete all Load items where purchase items on this PO are marked as source ( SourceDoc=PURCHASEITEMID AND SourceType= PRCH)
        deleteLoadItems(oItem.Purchaseitemid, SourceType.PRCH.ToString())

        ' Update work order items where purchase items on selected Purchase Order are marked as source 
        Dim oWorkorderitems As New WorkorderitemCollection
        oWorkorderitems = getWorkOrderItemsByPurchaseItemID(oItem.Purchaseitemid)
        If Not oWorkorderitems Is Nothing Then
            For Each oWOItem As Workorderitem In oWorkorderitems
                updateWorkOrderItem(oWOItem.Workorderitemnumber, oItem.Purchaseitemid, SourceType.PRCH.ToString(), Nothing)
            Next
        End If
        Dim oRelabelOrderItems As New RelabelorderitemCollection
        oRelabelOrderItems = getRelabelOrderItemsBySource(oItem.Purchaseitemid, SourceType.PRCH.ToString())
        If Not oRelabelOrderItems Is Nothing Then
            For Each oRelableOrderItem As Relabelorderitem In oRelabelOrderItems
                updateRelabelOrderItem(oRelableOrderItem.Relabelorderitemnumber, oRelableOrderItem.Sourcetype, oRelableOrderItem.Sourcedoc, oRelableOrderItem.Itemid, Nothing)
            Next
        End If

        oItem.Purchasenumber = Nothing
        oItem.Purchaseitemstatus = getPurchaseItemRollbackStatus(oItem).ToString()

        'If Purchase Item is NOT linked to a Workorder or Relabel Order then delete it, otherwise it will return to a REQUESTED status
        If (IsDBNull(oItem.Sourcetype) Or oItem.Sourcetype = Nothing) And oItem.Purchaseitemtype <> "MATERIAL" Then
            oItem.MarkAsDeleted()
        End If

        oItem.Save()

    End Sub

    Private Sub btnMiscCharge_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMiscCharge.ItemClick
        addMiscCharge()
    End Sub
    Private Sub eVendor_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eVendor.EditValueChanged
        getVendorInfo(eVendor.EditValue)
    End Sub
    Private Sub getVendorInfo(ByVal vVendorID)
        If vVendorID Is Nothing Or vVendorID Is DBNull.Value Then
            Exit Sub
        End If

        Dim oVendor As New Vendor
        oVendor.LoadByPrimaryKey(vVendorID)
        If oVendor Is Nothing Then
            Exit Sub
        End If
        eVendorNotes.Text = oVendor.Vendornotes
        'Check whether vendor notes value is null,empty or Nothing
        'If Not ((oVendor.Vendornotes Is Nothing) OrElse (String.IsNullOrEmpty(oVendor.Vendornotes))) Then
        '    showVendorNotes(oVendor.Vendorid)
        'End If

    End Sub

    Private Sub showVendorNotes(ByVal vID)
        Using frm As New frmAddEditVendorNotes() With
            {
               .vVendorID = vID
            }
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btVendorNotes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btVendorNotes.Click
        If eVendor.EditValue Is Nothing OrElse
            IsDBNull(eVendor.EditValue) Then
            Exit Sub
        End If
        showVendorNotes(eVendor.EditValue)
        getVendorInfo(eVendor.EditValue)
    End Sub

    Private Sub btnPrintPurchaseOrder_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPurchaseOrder.ItemClick
        printPO()
    End Sub

    Private Sub printPO()
        If bsPurchase.Count <= 0 Then
            Exit Sub
        End If
        printPurchaseOrder(bsPurchase.Current.Purchasenumber)
    End Sub

    Private Sub btnPrintPurchaseitem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPurchaseitem.ItemClick
        If bsPurchaseItems.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptPOList3(bsPurchaseItems.Current.Purchasenumber)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub luCustomer_EditValueChanged(sender As Object, e As System.EventArgs) Handles luCustomer.EditValueChanged
        'lookup Customer information and reset Shipping Address details
        If IsDBNull(luCustomer.EditValue) Or luCustomer.EditValue Is Nothing Then
            Exit Sub
        End If
        Dim oCust As New Customer
        Try
            oCust.LoadByPrimaryKey(luCustomer.EditValue)
            eCompany.Text = oCust.Custname
            eAddress1.Text = oCust.Custshipaddress1
            eAddress2.Text = oCust.Custshipaddress2
            eCity.Text = oCust.Custshipcity
            eState.Text = oCust.Custshipstateprov
            eZip.Text = oCust.Custshippostalcode
            eContact.Text = oCust.Custshipcontact
            ePhone.Text = oCust.Custphone
            bsPurchase.EndEdit()
        Catch ex As Exception
            MsgBox("Could Not lookup selected Customer", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub lookupCustomerData(vCustomerKey As Integer)
        Dim oCust As New Customer
        Try
            oCust.LoadByPrimaryKey(vCustomerKey)
            oPurchase.Shipname = oCust.Custname
            oPurchase.Shipaddress1 = oCust.Custshipaddress1
            oPurchase.Shipaddress2 = oCust.Custshipaddress2
            oPurchase.Shipcity = oCust.Custshipcity
            oPurchase.Shipstate = oCust.Custshipstateprov
            oPurchase.Shipzip = oCust.Custshippostalcode
            oPurchase.Shipcontact = oCust.Custshipcontact
            oPurchase.Shipphone = oCust.Custphone
            oPurchase.Save()
        Catch ex As Exception
            MsgBox("Could Not lookup selected Customer", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub btExpectedIn_Click(sender As Object, e As EventArgs) Handles btExpectedIn.Click
        If ExpectedInDateDateEdit.EditValue Is Nothing Then
            MsgBox("You must first select Expected In date.", MsgBoxStyle.Critical, "Error")
            Return
        End If
        setExpectedInDate(ExpectedInDateDateEdit.EditValue, False)
    End Sub

    Private Function setExpectedInDate(vExpectedInDate As DateTime, vUpdateAll As Boolean) As Boolean

        If IsDBNull(vExpectedInDate) Then
            MsgBox("There Is no EXPECTED IN date.", MsgBoxStyle.Critical, "ERROR - Missing Expected In Date")
            Return False
        End If

        Dim vDate As Date = CType(vExpectedInDate, Date)

        'Hard update the Purchase Order with the entered ExpectedInDate
        Dim oPO As New Purchase
        Try
            oPO.LoadByPrimaryKey(vPurchaseNumber)
            oPO.Expectedindate = vDate
            oPO.Save()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Updating Expected In Date on Purchase Order")
            Return False
        End Try

        Select Case vUpdateAll
            Case True  'update ALL Purchase Items attached to this Purchase Order to the same ExpectedInDate
                Try
                    Dim oItems As New PurchaseitemCollection
                    oItems.Query.Where(oItems.Query.Purchasenumber.Equal(vPurchaseNumber))
                    If oItems.Query.Load Then
                        For Each oItem As Purchaseitem In oItems
                            oItem.Expectedindate = vDate
                        Next
                        oItems.Save()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Updating Expected In Dates for ALL Purchase Items")
                    Return False
                End Try

            Case False 'update only those Purchase Items attached to this Purchase Order that have NO ExpectedInDate value
                Try
                    Dim oItems As New PurchaseitemCollection
                    oItems.Query.Where(oItems.Query.Purchasenumber.Equal(vPurchaseNumber))
                    If oItems.Query.Load Then
                        For Each oItem As Purchaseitem In oItems
                            If IsDBNull(oItem.Expectedindate) Or oItem.Expectedindate Is Nothing Then
                                oItem.Expectedindate = vDate
                            End If
                        Next
                        oItems.Save()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Updating Expected In Dates for Purchase Items missing those dates.")
                    Return False
                End Try
        End Select


        ''Update ExpectedInDate on Purchase Order
        'Dim vIndex As Integer = 0
        'For vIndex = 0 To bsPurchaseItems.Count - 1
        '    If vUpdateAll Or
        '        (bsPurchaseItems.List.Item(vIndex).ExpectedInDate Is Nothing Or
        '         IsDBNull(bsPurchaseItems.List.Item(vIndex).ExpectedInDate)) Then
        '        Try
        '            bsPurchaseItems.List.Item(vIndex).ExpectedInDate = vDate
        '            bsPurchaseItems.EndEdit()
        '        Catch ex As Exception
        '            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        '        End Try
        '    End If
        'Next

        'If Not vUpdateAll Then
        '    'Checking Expected In date is greater than Date Needed
        '    For vIndex = 0 To bsPurchaseItems.Count - 1
        '        If Not IsDBNull(bsPurchaseItems.List.Item(vIndex).dateneeded) Then
        '            If (bsPurchaseItems.List.Item(vIndex).dateneeded < vDate) Then
        '                If MsgBox("Expected In Date Is greater than Date Needed for some purchase items. Do you want to change the Expected In date?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
        '                    Return False
        '                End If
        '                Exit For
        '            End If
        '        End If
        '    Next
        'End If

        'Update Purchase Order Totals
        Dim vTotal As Integer = 0
        Dim vIndex As Integer
        For vIndex = 0 To bsPurchaseItems.Count - 1
            vTotal += bsPurchaseItems(vIndex).ExtCost
            'updatePurchaseItemExpectedInDate(bsPurchaseItems(vIndex).PURCHASEITEMID, vDate)
        Next
        oPurchase.Total = vTotal
        bsPurchaseItems.EndEdit()

        getPOItems(vPurchaseNumber)

        Return True
    End Function

    Private Sub btnSplitItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSplitItem.ItemClick
        If IsNothing(bsPurchaseItems.Current) Then
            Exit Sub
        End If
        If bsPurchaseItems.Current.Qty > 1 Then
            Using frm As New frmSplitPurchaseItem() With
             {
                .vID = Me.bsPurchaseItems.Current.PURCHASEITEMID
             }
                frm.ShowDialog()
            End Using
            getPOItems(Me.bsPurchase.Current.PURCHASENUMBER)
        Else
            Dim vMsg As String = String.Format("Selected Purchase Item cannot be split because quantity Is {0}", Convert.ToInt32(bsPurchaseItems.Current.Qty))
            MsgBox(vMsg, MsgBoxStyle.Critical, "Split Item")
        End If
    End Sub

    Private Sub btnApproveOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnApproveOrder.ItemClick
        Dim vConfirmApproval As String
        If vEditType <> "ADD" Then
            vConfirmApproval = "Approving purchase order cannot be undone."
        End If
        vConfirmApproval = "Are you sure you want to approve the purchase order?"
        If MessageBox.Show(vConfirmApproval,
                           "Confirm Approval",
                           MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        'If PO is approved in "Add to Existing PO" mode, the changes will not be rolled back
        vCommaSeparatedPurchaseItemIds = ""

        If saveChanges() = True Then
            approvePurchaseOrder(oPurchase)
            editObject(vPurchaseNumber)
        End If
        'Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub grvPurchaseItems_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grvPurchaseItems.RowStyle
        If (e.RowHandle >= 0) Then

            Dim strDateNeeded As String = ""
            Dim vDateNeeded As Date
            Dim strExpectedIn As String = ""
            Dim vExpectedIn As Date

            If Not String.IsNullOrEmpty(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Expectedindate"))) Then
                strExpectedIn = grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Expectedindate"))
                vExpectedIn = Convert.ToDateTime(strExpectedIn)
                If Not String.IsNullOrEmpty(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Dateneeded"))) Then
                    strDateNeeded = grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Dateneeded"))
                    vDateNeeded = Convert.ToDateTime(strDateNeeded)
                    If vExpectedIn > vDateNeeded Then
                        e.Appearance.BackColor = Color.Pink
                        e.Appearance.BackColor2 = Color.Pink
                        e.Appearance.ForeColor = Color.Black
                        Exit Sub
                    End If
                End If
            End If

        End If
    End Sub

    Private Sub btnAddPOItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddPOItem.ItemClick
        If IsDBNull(eVendor.EditValue) Then
            MsgBox("You must select a Vendor first", MsgBoxStyle.Critical, "Error - No Vendor Selected")
            Exit Sub
        End If

        oPurchase.EndEdit()
        bsPurchase.EndEdit()
        oPurchase.Save()

        Using frm As New frmAddEditPurchaseItem() With
           {
            .vEditType = "ADD",
            .oPurchase = oPurchase
           }
            If frm.ShowDialog() = Windows.Forms.DialogResult.Yes AndAlso
                Not frm.oPurchaseitem Is Nothing Then
                oNewPurchaseItems.Add(frm.oPurchaseitem)
            End If
        End Using

        getPOItems(Me.bsPurchase.Current.PURCHASENUMBER)
    End Sub

    Private Sub enableApproval()
        btnApproveOrder.Enabled = IIf((Not bsPurchaseItems Is Nothing AndAlso
                bsPurchaseItems.Count > 0 AndAlso
                oPurchase.Purchasestatus = PurchaseStatus.PENDING.ToString()), True, False)
    End Sub

    Private Sub enableCustomerPO()
        If IsDBNull(ePurchaseOrderType.EditValue) = False AndAlso
            ePurchaseOrderType.EditValue = PurchaseType.DIRECT.ToString() Then
            colCustomerPONum.Visible = True
        Else
            colCustomerPONum.Visible = False
        End If
    End Sub

    Private Sub ePurchaseOrderType_EditValueChanged(sender As Object, e As EventArgs) Handles ePurchaseOrderType.EditValueChanged
        enableCustomerPO()
    End Sub

    Private Sub ePurchaseOrderType_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles ePurchaseOrderType.EditValueChanging
        If bsPurchaseItems.Count > 0 Then
            MsgBox(String.Format("Purchase Type cannot be changed, Purchase items have been created for {0}",
                                 e.OldValue),
                   MsgBoxStyle.OkOnly,
                   "Change purchase type - Error")
            e.Cancel = True
        End If
    End Sub

    Private Sub btnUpdateAll_Click(sender As Object, e As EventArgs) Handles btnUpdateAll.Click
        If ExpectedInDateDateEdit.EditValue Is Nothing Then
            MsgBox("You must first select Expected In date.", MsgBoxStyle.Critical, "Error")
            Return
        End If
        setExpectedInDate(ExpectedInDateDateEdit.EditValue, True)
    End Sub

    Private Sub rbtnMarkPOComplete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkPOComplete.ItemClick

        If MsgBox("Are you sure you want to mark this Purchase Order as COMPLETE?", MsgBoxStyle.YesNo, "CONFIRM - Status Change") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oPO As New Purchase
        oPO.LoadByPrimaryKey(oPurchase.Purchasenumber)
        oPO.Purchasestatus = "COMPLETED"
        oPO.Save()

        'mark all purchaseitems under this purchase order as RECEIVED
        Dim oItems As New PurchaseitemCollection
        oItems.Query.Where(oItems.Query.Purchasenumber.Equal(oPO.Purchasenumber))
        If oItems.Query.Load Then
            For Each oItem As Purchaseitem In oItems
                If oItem.Purchaseitemstatus = "ORDERED" Then
                    oItem.Purchaseitemstatus = "RECEIVED"
                End If
            Next
            oItems.Save()
        End If

        editObject(vPurchaseNumber)

    End Sub

    Private Sub bsPurchaseItems_CurrentChanged(sender As Object, e As EventArgs) Handles bsPurchaseItems.CurrentChanged
        If bsPurchaseItems.Count <= 0 Then
            Exit Sub
        End If

        If bsPurchaseItems.Current.SourceType = "WORKORDER" And bsPurchaseItems.Current.SourceDocument > 0 Then
            Dim oWO As New Workorder
            If oWO.LoadByPrimaryKey(bsPurchaseItems.Current.SourceDocument) Then
                eWorkOrderNotes.EditValue = oWO.Prodfulfillmentnotes
            End If
        Else
            eWorkOrderNotes.EditValue = Nothing
        End If



    End Sub

    Private Sub grvPurchaseItems_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grvPurchaseItems.RowCellClick
        If (e.Column.Name <> "SourceDoc") Then
            Exit Sub
        End If
        If ((Not String.IsNullOrEmpty(e.CellValue)) OrElse (e.CellValue > 0)) Then

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
        End If
    End Sub


End Class