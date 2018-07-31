Imports AOS.BusinessObjects

Public Class frmAddEditProdOrder
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer
    Public vEditType As String
    Public vAPISNum As Integer
    Public vProductID As Integer
    Public vQty As Integer
    Public vWorkOrderID As Integer
    Public vFrmSource As String     'WorkOrder or Production
    Public vFailed As Boolean = False
    Public vAvailableQty As Decimal 'for what is needed if coming from Material Needs

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Production Order"

    'here is where you dimension your object variables for the form
    Dim oProdOrder As Prodorder
    Dim oProdItems As ViewProdItemDataCollection
    Dim oProdProcs As ProdprocedureCollection
    Dim oProdNotes As ProdnoteCollection
    Dim oCustomerList As CustomerCollection
    Dim oProducts As ViewProductsWithAPISCollection

    Dim oAPISList As ViewAPISDataCollection

    Dim vStatus As String = ""
    Dim oWorkOrder As Workorder


    Private Sub setUserSecuritySettings(vLevel As Integer)

        If vLevel >= 8 Then
            rpgWorkOrder.Visible = True
        Else
            rpgWorkOrder.Visible = False
        End If


    End Sub



    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        setUserSecuritySettings(vCurrentUserSecurityLevel)

        Select Case vEditType
            Case "ADD"
                Me.Text = "Adding New " & vObjectName
                reviewProdOrderStatus()
            Case "EDIT"
                Me.Text = "Editing " & vObjectName & " Information"
                reviewProdOrderStatus()
            Case "READONLY"
                Me.Text = vObjectName & " Information"
                disableScreenObjects()
        End Select

    End Sub

    Private Sub disableScreenObjects()
        btnSave.Enabled = False
        btnChangeInventoryClass.Enabled = False
        btnAllocateRawMaterialInventory.Enabled = False
        rpgWorkOrder.Visible = False
        rbtnEditWorkOrder.Enabled = False

        eQty.Properties.ReadOnly = True
        eProductID.Properties.ReadOnly = True
        ProdorderdateDateEdit.Properties.ReadOnly = True
        LotNoTextEdit.Properties.ReadOnly = True
        CustidLookUpEdit.Properties.ReadOnly = True
        NeededbyDateEdit.Enabled = False
        eEstCompDate.Properties.ReadOnly = True
    End Sub

    Private Sub reviewProdOrderStatus()

        If vEditType = "ADD" Then
            changeOrderStatus(ProdOrderStatus.INPROD.ToString())
            Exit Sub
        End If

        'Retrieve Production Order record
        Dim oProdOrd As New Prodorder
        If Not oProdOrd.LoadByPrimaryKey(vID) Then
            MsgBox("Error retrieving Production Order data", MsgBoxStyle.Critical, "Error - Review Production Order Status")
            Exit Sub
        End If

        'check to see if PRODORDER is linked to a WORKORDER. If it is, prevent changes to ProductID and Qty
        If oProdOrd.Workordernumber > 0 Then
            changeOrderStatus("WORKORDER")
            Exit Sub
        End If

        'first, check to see if Production Order has been marked as completed
        If oProdOrd.Iscomplete = True Then
            changeOrderStatus("COMPLETE")
            Exit Sub
        End If

        'second, check to see if production work has been completed on any item in the order
        'if so we need to prevent changes to the  production order
        Dim oTxs As New ViewProductionOrderMaterialTransactionsCollection
        oTxs.Query.Where(oTxs.Query.Prodordernum.Equal(vID))
        If oTxs.Query.Load Then
            If oTxs.Count > 0 Then
                'there are Raw Material Transactions that have occurred related to at least one PRODITEM linked to this PRODORDER
                changeOrderStatus("IN PROCESS")
                Exit Sub
            End If
        End If

        'all other conditions
        changeOrderStatus("")

    End Sub

    Private Sub changeOrderStatus(vStatusText As String)
        vStatus = vStatusText
        eStatus.Text = vStatusText
        Select Case vStatusText
            Case ProdOrderStatus.INPROD.ToString()
                eProductID.Properties.ReadOnly = False
                eQty.Properties.ReadOnly = False
            Case "WORKORDER"
                eProductID.Properties.ReadOnly = True
                eQty.Properties.ReadOnly = True
            Case "COMPLETE"
                eProductID.Properties.ReadOnly = True
                eQty.Properties.ReadOnly = True
            Case "IN PROCESS"
                eProductID.Properties.ReadOnly = True
                eQty.Properties.ReadOnly = True
            Case Else
                eProductID.Properties.ReadOnly = True
                eQty.Properties.ReadOnly = False
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If Not loadLookupData() Then
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End If
        loadData()
        loadInventoryItems(vID)

        If allInvItemsUnAllocated(bsProdOrder.Current.ProdOrderNum, SourceType.PORD.ToString()) = True AndAlso _
            bsInventoryItems.Count > 0 AndAlso _
            oProdOrder.Iscomplete <> True AndAlso _
            oProdOrder.Orderstatus <> ProdOrderStatus.CANCELLED.ToString() Then
            btnChangeInventoryClass.Enabled = IIf(vEditType = "READONLY", False, True)
        End If
    End Sub


    Private Function loadLookupData() As Boolean

        Try
            'restrict product list to only products for which there are APIS records linked to those products
            oProducts = New ViewProductsWithAPISCollection
            If vFrmSource = "WorkOrder" And vProductID > 0 Then
                'get only the product record for the ProductID coming from the Work Order
                oProducts.Query.Where(oProducts.Query.Productid.Equal(vProductID))
            End If
            oProducts.Query.Load()
            If oProducts.Count <= 0 Then
                MsgBox("The selected product for this Production Order has no linked APIS records in the database. Select a different ProductID")
                Return False
            End If
            bsProducts.DataSource = oProducts
        Catch ex As Exception
            MsgBox("Error retrieving Product information", MsgBoxStyle.Critical, "Error")
            Return False
        End Try

        Try
            oCustomerList = New CustomerCollection
            oCustomerList.LoadAll()
            oCustomerList.Sort = "CustName"
            bsCustomers.DataSource = oCustomerList
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error retrieving Customer data", MsgBoxStyle.Critical, "Error")
        End Try

        Return True
    End Function

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If

    End Sub

    Private Sub reload(vOrd As Integer)
        loadrelateddata(vOrd)
    End Sub

    Private Sub loadrelateddata(vProdOrdNum As Integer)

        Me.Cursor = Cursors.WaitCursor

        reviewProdOrderStatus()

        '*** the reviewProdOrderStatus() code above supersedes this code block below - SHAUN MCGUIRE - 02/25/2015
        'This is OLD code - it did not allow for any transactions that might have occured BEFORE a particular PRODITEM was marked COMPLETE
        'If vStatus <> "COMPLETE" Then
        '    Try
        '        Dim oItems As New ProditemCollection
        '        oItems.Query.Where(oItems.Query.Prodordernum.Equal(vProdOrdNum), oItems.Query.Iscomplete.Equal(1))
        '        If oItems.Query.Load Then
        '            'there are items on the production order that are completed already - no more changes allowed
        '            changeOrderStatus("IN PROCESS")
        '        End If
        '    Catch ex As Exception

        '    End Try
        'End If

        'now get item records for display
        Try
            refreshProdItems(vProdOrdNum)
        Catch ex As Exception
            MsgBox("Error retrieving Production Order Material Inputs", MsgBoxStyle.Critical, "Error")
        End Try




        Me.Cursor = Cursors.Default
    End Sub

    Private Sub eProductID_EditValueChanged(sender As Object, e As System.EventArgs) Handles eProductID.EditValueChanged

        'ADD mode is the only time a user can change the ProductID to be made from the Production Order.
        'In EDIT mode, the user can change to the quantity of containers to be made, but not the ProductID

        If IsDBNull(eProductID.EditValue) Then
            Exit Sub
        End If

        eProductID.Refresh()

        Dim vID As Integer = eProductID.EditValue
        Dim vOrd As Integer = oProdOrder.Prodordernum
        Dim vApis As Integer = 0

        'save all changes
        bsProdOrder.EndEdit()
        oProdOrder.EndEdit()
        oProdOrder.Save()

        'Lookup APIS Num for currently selected product
        If vEditType = "ADD" Then
            vApis = getAPISNum(vID)
            oProdOrder.Apisnum = vApis
            eAPIS.Text = vApis
        Else
            'eAPIS.Text = oProdOrder.Apisnum
        End If

        'Update Product Related data fields (Product Description/Container) by lookup to Product Table
        Dim oProd As New Product
        oProd.LoadByPrimaryKey(vID)
        eProdDesc.Text = oProd.Productdesc
        eContainer.Text = oProd.Container

        bsProdOrder.EndEdit()
        oProdOrder.Save()

        'recalculate Prod Item Material Details
        If vEditType = "ADD" Then
            calculateMaterialNeeds(vOrd)
        End If

        reload(vOrd)
    End Sub

    Private Function getAPISNum(vProductID As Integer) As Integer
        If IsDBNull(vProductID) Or vProductID <= 0 Then
            Return 0
        End If

        Try
            oAPISList = New ViewAPISDataCollection
            oAPISList.Query.Where(oAPISList.Query.Productid.Equal(eProductID.EditValue), oAPISList.Query.Or(oAPISList.Query.Apisstatus.Equal("ACTIVE"), oAPISList.Query.Apisstatus.Equal("SINGLE USE")))
            oAPISList.Query.Load()
            Select Case oAPISList.Count
                Case 0
                    'this should never happen because there should only be products in the list that have APIS records linked to them.
                    MsgBox("There are no APIS records in the database linked to the selected ProductID. You will not be able to save this production order", MsgBoxStyle.Critical, "Error")
                    Return 0
                Case 1
                    Return oAPISList(0).Apisnum
                Case Else
                    'if more than 1 APIS record linked to the product, force use to select an APIS Record for the product on this production order
                    Dim frm As New frmAssignAPISLinkToProductionOrder
                    frm.vProductID = vProductID
                    frm.ShowDialog()
                    If frm.vAPISNum > 0 Then
                        Return frm.vAPISNum
                    Else
                        Return 0
                    End If
            End Select

        Catch ex As Exception
            MsgBox("Error retrieving APIS data", MsgBoxStyle.Critical, "Error")
        End Try
    End Function

    Private Sub addNewObject()
        oProdOrder = New Prodorder
        oProdOrder.Iscomplete = False
        oProdOrder.Createdby = vCurrentUserLogin
        oProdOrder.Prodorderdate = Today
        oProdOrder.Save()
        vID = oProdOrder.Prodordernum
        oProdOrder.Lotnumber = vID.ToString + "CS"
        oProdOrder.Orderstatus = ProdOrderStatus.INPROD.ToString()

        oWorkOrder = getWorkOrder(vWorkOrderID)
        If vFrmSource = "WorkOrder" AndAlso _
            Not oWorkOrder Is Nothing Then
            oProdOrder.Productid = vProductID
            oProdOrder.Productqty = vQty
            oProdOrder.Custid = oWorkOrder.Custid
            oProdOrder.Neededby = getDateNeeded(oWorkOrder)
            oProdOrder.Workordernumber = vWorkOrderID
            If oWorkOrder.Orderstatus = "PENDING" Then
                oProdOrder.Orderstatus = ProdOrderStatus.PENDING.ToString()
            End If
        End If

        If vFrmSource = "MaterialNeeds" Then
            If vProductID > 0 Then
                'get standard qty from PRODUCT record to determine QTY of containers to order to meet RM demand
                Dim oProduct As New Product
                If Not oProduct.LoadByPrimaryKey(vProductID) Then
                    MsgBox("Error in retrieving Product data", MsgBoxStyle.Critical, "ERROR - Missing Data")
                    Exit Sub
                End If
                'assume we now have the product record

                oProdOrder.Productid = vProductID

                Dim vProdOrderQty As Integer = 0
                Dim vMakeUpQty As Integer = 0
                Dim vUnits As Integer = 0

                vUnits = 0.0
                If Not (oProduct Is Nothing) Then
                    Select Case oProduct.Inventorymethod
                        Case "VOLUME"
                            vUnits = oProduct.Volumeunits
                        Case "WEIGHT"
                            vUnits = oProduct.Weightunits
                        Case Else
                            vUnits = oProduct.Units
                    End Select
                End If

                If vUnits > 0 Then
                    vMakeUpQty = Math.Ceiling(vAvailableQty / Val(vUnits))
                    If vMakeUpQty < 1 Then
                        vMakeUpQty = 1
                    End If
                    oProdOrder.Productqty = vMakeUpQty
                    oProdOrder.EndEdit()
                Else
                    MsgBox("Unable to automatically calculate the quantity to order", MsgBoxStyle.Critical, "Calculate Purchase Item Quantity - Error")
                End If

            End If

        End If


        oProdOrder.Save()
        Me.bsProdOrder.DataSource = oProdOrder
        editObject(bsProdOrder.Current.ProdOrderNum)
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oProdOrder = New Prodorder
        oProdOrder.LoadByPrimaryKey(vID)

        If oProdOrder.Iscomplete Then
            changeOrderStatus("COMPLETE")
        End If

        loadrelateddata(vID)
        loadInventoryItems(vID)

        Me.bsProdOrder.DataSource = oProdOrder

        If oProdOrder.Workordernumber > 0 Then
            rpgWorkOrder.Visible = True
        Else
            rpgWorkOrder.Visible = False
        End If

    End Sub

    Private Function changesSaved() As Boolean

        ' post an editor's value
        Dim ActiveCtrl As Control = ActiveControl
        While TypeOf ActiveCtrl Is ContainerControl
            ActiveCtrl = CType(ActiveCtrl, ContainerControl).ActiveControl
        End While
        If TypeOf ActiveCtrl Is DevExpress.XtraEditors.TextBoxMaskBox Then
            ActiveCtrl = ActiveCtrl.Parent
        End If
        If TypeOf ActiveCtrl Is DevExpress.XtraEditors.BaseEdit Then
            CType(ActiveCtrl, DevExpress.XtraEditors.BaseEdit).DoValidate()
        End If

        Try
            oProdOrder.Estimatedcompletiondate = getEstCompDate(oProdOrder.Estimatedcompletiondate, oProdOrder.Neededby)

            bsProdOrder.EndEdit()
            oProdOrder.EndEdit()
            oProdOrder.Save()
            If IsDBNull(oProdOrder.Apisnum) Or oProdOrder.Apisnum Is Nothing Then
                MsgBox("You must select an APIS number to save this Production Order", MsgBoxStyle.Critical, "Error - No APIS Number is assigned")
                Return False
            End If

            'update the APIS linked to the production order - if SINGLE USE, let user decide to archive APSI after this usage
            updateAPISUsage(oProdOrder.Apisnum)

            'create INVITEM rows for this PRODORDER if not already created
            If (vEditType = "ADD") Then
                If (vFrmSource = "WorkOrder") AndAlso
                    (Not oWorkOrder Is Nothing) Then
                    assignProductionOrderToWorkOrderItems(oProdOrder.Prodordernum, vWorkOrderID, vProductID)
                End If
                'INVITEM creation should be done only after allocating prod order to Work Order Item
                CreateINVITEM(vFrmSource)
            Else
                updateInventoryItemLotNumber(oProdOrder)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        If vEditType = "READONLY" Then
            Return True
        End If
        If MsgBox("Are you sure you want to cancel your changes to this production order?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Return False
        End If

        Try
            bsProdOrder.CancelEdit()
            oProdOrder.CancelEdit()
            If vEditType = "ADD" Then
                'delete Production Order Items that may have been added to the database for the current Production Order
                Dim oItems As New ProditemCollection
                oItems.Query.Where(oItems.Query.Prodordernum.Equal(oProdOrder.Prodordernum))
                If oItems.Query.Load Then
                    oItems.MarkAllAsDeleted()
                    oItems.Save()
                End If
                'delete Production Order record
                Dim oItem As New Prodorder
                oItem.LoadByPrimaryKey(oProdOrder.Prodordernum)
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error cancelling changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub updateAPISUsage(vID As Integer)
        'Some APISs are created for SINGLE USE. If the APIS linked to this Production order is so marked,
        'let the user decide if they want to marked the APIS as ARCHIVED after closing this production order
        Dim oAP As New Apis
        If oAP.LoadByPrimaryKey(vID) Then
            If oAP.Apisstatus = "SINGLE USE" Then
                If MsgBox("The APIS linked to this Production Order is marked for SINGLE USE only. Do you want to mark this APIS as ARCHIVED at this time?", MsgBoxStyle.YesNo, "Confirm - Archive APIS?") = MsgBoxResult.No Then
                    Exit Sub
                End If
                oAP.Apisstatus = "ARCHIVED"
                oAP.Save()
            End If
        End If
    End Sub

    Private Function calculateMaterialNeeds(vProdOrderNum As Integer) As Boolean

        'this function is called whenever the productID or the production Qty is changed.
        'before changes to Production Items can be made, we have to determine if inventory transactions
        'have occured already against the production order. If so, then the changes cannot be allowed.

        If vStatus = "COMPLETE" OrElse _
            vStatus = "IN PROCESS" Then
            'the production order is complete or in process - do NOT recalculate and Production Item records
            Return False
        End If

        If vProdOrderNum <= 0 OrElse _
            IsDBNull(vProdOrderNum) Then
            Return True
        End If

        Dim oP As Prodorder
        Dim oPItems As ProditemCollection
        Dim oPItem As Proditem
        Dim vMultiplier As Decimal = 1.0

        Dim oA As Apis
        Dim oAItems As ApisitemCollection

        Try
            oP = New Prodorder
            oP.LoadByPrimaryKey(vProdOrderNum)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        'initial data validation requirements before performing calculations and updates
        If oP.Productqty Is Nothing OrElse _
            oP.Productqty <= 0 Then
            'MsgBox("Cannot calculate material needs for this production order without a desired quantity to produce", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        If oP.Apisnum <= 0 OrElse _
            IsDBNull(oP.Apisnum) Then
            'MsgBox("Cannot calculate material needs for this production order without an APIS Number", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        'if we get this far, we can assume we have a valid production order number, APIS Number, and desired product qty


        'STEP 1: Delete existing detail data for production order
        Dim vContinue As Boolean = True

        Try
            oPItems = New ProditemCollection
            oPItems.Query.Where(oPItems.Query.Prodordernum.Equal(vProdOrderNum))
            If oPItems.Query.Load Then
                For Each oRec As Proditem In oPItems
                    If oRec.Iscomplete Then
                        vContinue = False
                    End If
                Next
                If vContinue = False Then
                    'production work has already begun. Do NOT make changes
                    Exit Function
                End If

                oPItems.MarkAllAsDeleted()
                oPItems.Save()
            End If
        Catch ex As Exception
            Return False
        End Try

        'STEP 2: Pull detailed data for assigned APIS
        oA = New Apis
        oAItems = New ApisitemCollection

        Try
            oA.LoadByPrimaryKey(oP.Apisnum)
            oAItems.Query.Where(oAItems.Query.Apisnum.Equal(oP.Apisnum))
            oAItems.Query.Load()
        Catch ex As Exception
            Return False
        End Try

        'STEP 3: Copy APIS detailed data to Production Order details, doing multiplication for items where necessary

        vMultiplier = oP.Productqty

        Try
            If oAItems.Count > 0 Then
                For Each oaitem As Apisitem In oAItems
                    oPItem = New Proditem
                    oPItem.Apisnum = oaitem.Apisnum
                    oPItem.Materialid = oaitem.Materialid
                    oPItem.Prodordernum = vProdOrderNum
                    oPItem.Qty = oaitem.Qtyunits * vMultiplier
                    oPItem.Uom = oaitem.Uom
                    oPItem.Iscomplete = False
                    oPItem.Save()
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True
    End Function


    Private Sub eQty_EditValueChanged(sender As Object, e As System.EventArgs) Handles eQty.EditValueChanged

        If IsDBNull(eQty.EditValue) Then
            Exit Sub
        End If

        'For Add mode the OldEditValue will be null, so if its null we can proceed with the process
        If (IsDBNull(eQty.OldEditValue) = False AndAlso _
            eQty.EditValue = eQty.OldEditValue) Then
            Exit Sub
        End If

        Dim vQty As Integer = eQty.EditValue
        oProdOrder.Productqty = vQty

        ' Don't allow user to change the quantity if any / all of the INVITEMs of Prod Order are allocated.
        ' INVITEMs will be created for ADD while saving. No need to create INVITEM on qty change.
        If (vEditType <> "ADD") Then
            If (allInvItemsUnAllocated(oProdOrder.Prodordernum, SourceType.PORD.ToString()) = False) Then
                MsgBox("Qty change is not allowed, some or all of the inventory items associated with this production order are allocated.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            Else
                CreateINVITEM(vFrmSource)
            End If
        End If

        eQty.DoValidate()

        Dim vOrd As Integer = oProdOrder.Prodordernum

        'save all changes
        bsProdOrder.EndEdit()
        oProdOrder.EndEdit()
        oProdOrder.Save()

        'recalculate Prod Item Material Details
        calculateMaterialNeeds(vOrd)

        'If vEditType = "ADD" Then
        '    calculateMaterialNeeds(vOrd)
        'End If

        reload(vOrd)
    End Sub

    Private Sub btnAllocateRawMaterialInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAllocateRawMaterialInventory.ItemClick
        rawMaterialFulfillmentProcess(oProdOrder)
        If (Not oProdOrder Is Nothing) Then
            refreshProdItems(oProdOrder.Prodordernum)
        End If
    End Sub

    Private Sub refreshProdItems(vProdOrdNum As Integer)
        oProdItems = getViewProdItemData(vProdOrdNum)
        bsProdItems.DataSource = oProdItems
    End Sub

    Private Sub loadInventoryItems(vOrdNum As Integer)
        If IsDBNull(vOrdNum) Then
            Exit Sub
        End If
        bsInventoryItems.DataSource = getInvItems(vOrdNum, SourceType.PORD.ToString())
    End Sub

    Private Sub btnChangeInventoryClass_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChangeInventoryClass.ItemClick
        If (bsInventoryItems Is Nothing) Then
            Exit Sub
        End If

        If bsInventoryItems.Current.Invitemnumber Is Nothing Then
            Exit Sub
        End If

        If bsInventoryItems.Current.Itemstatus = InventoryItemStatus.RECEIVED.ToString() Then
            MsgBox("You cannot change the inventory class of selected inventory items because one or more selected inventory items are already received.", _
                      vbCritical, _
                      "Error")
            Exit Sub
        End If

        Dim vIDs As New List(Of Integer)
        vIDs.Add(bsInventoryItems.Current.Invitemnumber)
        Using frm As New frmConvertInventory() With
             {
                   .vIDs = vIDs
             }
            frm.ShowDialog()
        End Using
        loadInventoryItems(vID)

    End Sub

    Private Sub CreateINVITEM(vSource As String)
        Select Case vSource
            Case "WORKORDER"
                If Not oWorkOrder Is Nothing Then
                    If oWorkOrder.Orderstatus = "APPROVED" Then
                        createINVITEMsProcessWOItems(oProdOrder, InventoryClass.FULLAVAILABLE)
                    End If
                End If
            Case "MaterialNeeds"
                createINVITEMsProcessWOItems(oProdOrder, InventoryClass.INPROCESS)
            Case Else
                createINVITEMsProcessWOItems(oProdOrder, InventoryClass.FULLAVAILABLE)
        End Select

    End Sub

    Private Sub rbtnEditWorkOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditWorkOrder.ItemClick
        If IsDBNull(oProdOrder.Workordernumber) Then
            Exit Sub
        End If
        If oProdOrder.Workordernumber > 0 Then
            Dim frm As New frmAddEditWorkOrders
            frm.vWorkorderNum = oProdOrder.Workordernumber
            frm.vEditType = "EDIT"
            frm.ShowDialog()
        End If
        loadData()
    End Sub

    Private Sub rbtnMaterialUsageTransactions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMaterialUsageTransactions.ItemClick
        Dim frm As New frmProductionOrderMaterialUsage
        frm.vID = bsProdItems.Current.ProdItemNum
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub rbtnPrintProductLabel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintProductLabel.ItemClick
        If changesSaved() Then
            Dim rpt As New rptGHSProductLabelLarge(0, eProductID.EditValue, LotNoTextEdit.EditValue)
            rpt.ShowPreviewDialog()
        End If
    End Sub
End Class