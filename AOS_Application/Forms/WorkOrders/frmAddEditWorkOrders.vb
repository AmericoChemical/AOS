Imports AOS.BusinessObjects
Imports DevExpress.XtraEditors.Controls
Imports System.Windows.Forms


Public Class frmAddEditWorkOrders
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oProduct As Product
    Dim oPriceList As Pricelist
    Dim oParms As Sysparameters

#Region "FORM"

    Public vWorkorderNum As Integer
    Public vEditType As String

    Dim oProducts As ProductCollection
    Dim oWorkOrder As Workorder
    Dim oWorkOrderItems As New ViewWorkOrderItemsScreenCollection
    Dim oCustomers As CustomerCollection
    Dim oEmployees As EmployeeCollection
    Dim oVendors As VendorCollection
    Dim oCarriers As CarrierCollection
    Dim oLogistics As LogisticsCollection
    Dim oFOB As ListFobCollection
    Dim oCustomer As Customer
    Dim oNotes As NoteCollection
    Dim oWorkOrderType As ListWorkordertypeCollection
    Dim oOrderTypes As New ListOrdertypeCollection
    Dim oBillingTypes As New ListBillingtypeCollection
    Dim oTransportTypes As New ListTransporttypeCollection
    Dim oSales As New SalespersonCollection
    Dim oItem As Workorderitem
    Dim FlagCONSIGNMENTCustomer As Boolean = False

    Dim vPreviousOrderType As String
    Dim vIsNotPageLoad As Boolean

    Enum OrderType
        CONSIGNMENTTRANSFER
        CONSIGNMENTUSAGE
        STANDARD
    End Enum

    Private Sub frmAddEditWorkOrders_Load(sender As Object, e As EventArgs) Handles Me.Load
        If vCurrentUserSecurityLevel < 9 Then
            'gcExtCost.Visible = False
            'gcUnitCost.Visible = False
            gcExtPrice.Visible = False
            gcUnitPrice.Visible = False
            'gcMargin.Visible = False
        Else
            'gcExtCost.Visible = True
            'gcUnitCost.Visible = True
            gcExtPrice.Visible = True
            gcUnitPrice.Visible = True
            'gcMargin.Visible = True
        End If
        'Variable initialization
        vPreviousOrderType = String.Empty
    End Sub

    Private Sub setScreenObjects()
        Select Case vEditType
            Case "ADD"
                eCustomer.Properties.ReadOnly = False
                btnSave.Caption = "Save Order"
                btnCancel.Caption = "Cancel Order"
                btnEditAll.Enabled = False
            Case Else
                eCustomer.Properties.ReadOnly = True
                btnSave.Caption = "Save Changes"
                btnCancel.Caption = "Cancel Changes"

                eOrderType.Enabled = False
                eCustomer.Enabled = False
                eTransportType.Enabled = False
                ePlannedShippedDate.Enabled = False
        End Select
    End Sub

#End Region

#Region "TIMERS"

    Private Sub Timer_Lookups_Tick(sender As Object, e As EventArgs) Handles Timer_Lookups.Tick
        refreshLookupDataSources()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        refreshLookupDataSources()
        setScreenObjects()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vWorkorderNum)
        End If
        vIsNotPageLoad = True
        enablePrint()
    End Sub

#End Region

#Region "REFERENCE DATA SOURCES"

    Private Sub refreshLookupDataSources()
        getParms()
        getCustomers()
        getCarriers()
        getLogistics()
        getFOB()
        getWorkOrderTypes()
        getOrderTypes()
        getTransportTypes()
        getSalespersons()

    End Sub

    Private Sub getParms()
        oParms = New Sysparameters
        If Not oParms.LoadByPrimaryKey(1) Then
            MsgBox("Could not load System Parameters", MsgBoxStyle.Critical, "System Error")
        End If
    End Sub
    Private Sub getFOB()
        oFOB = New ListFobCollection
        oFOB.LoadAll()
        bsFOB.DataSource = oFOB
    End Sub

    Private Sub getWorkOrderTypes()
        oWorkOrderType = New ListWorkordertypeCollection
        oWorkOrderType.LoadAll()
        oWorkOrderType.Sort = "LISTKEY"
        bsWorkOrderType.DataSource = oWorkOrderType
    End Sub

    Private Sub getSalespersons()
        oSales = New SalespersonCollection
        oSales.Query.Where(oSales.Query.Status.Equal("ACTIVE"))
        If Not oSales.Query.Load() Then
            MsgBox("No sales persons")
        End If
        oSales.Sort = "SALESPERSONLASTNAME"
        bsListSalespersons.DataSource = oSales
    End Sub

    Private Sub getOrderTypes()
        oOrderTypes = New ListOrdertypeCollection
        oOrderTypes.LoadAll()
        oOrderTypes.Sort = "SORTSEQUENCE"
        bsListOrderTypes.DataSource = oOrderTypes
    End Sub

    Private Sub getTransportTypes()
        oTransportTypes = New ListTransporttypeCollection
        oTransportTypes.LoadAll()
        oTransportTypes.Sort = "SORTSEQUENCE"
        bsListTransportTypes.DataSource = oTransportTypes
    End Sub

    Private Sub getCustomers()
        oCustomers = New CustomerCollection
        oCustomers.Query.Where(oCustomers.Query.Isactive.Equal(1))
        oCustomers.Query.Load()
        oCustomers.Sort = "CUSTNAME"
        bsCustomers.DataSource = oCustomers
    End Sub

    Private Sub getCarriers()
        oCarriers = New CarrierCollection
        oCarriers.Query.Where(oCarriers.Query.Isactive.Equal(1))
        oCarriers.Query.Load()
        oCarriers.Sort = "CARRIERNAME"
        bsCarriers.DataSource = oCarriers
    End Sub

    Private Sub getLogistics()
        oLogistics = New LogisticsCollection
        oLogistics.Query.Where(oLogistics.Query.Isactive.Equal(1))
        oLogistics.Query.Load()
        oLogistics.Sort = "LogisticsNAME"
        bsLogistics.DataSource = oLogistics
    End Sub

#End Region

#Region "RIBBON BUTTONS"

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If (saveWorkOrderChanges()) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        cancelChanges()
    End Sub

    Private Sub btnAddWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddWOItem.ItemClick
        addWorkOrderItem()
    End Sub

    Private Sub btnEditWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditMatchingItems.ItemClick
        editWorkOrderItem("MATCHING")
    End Sub

    Private Sub rbtnEditSingleItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditSingleItem.ItemClick
        editWorkOrderItem("SINGLE")
    End Sub

    Private Sub btnDeleteWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteWOItem.ItemClick

        If bsWorkOrderItems.Count <= 0 Then
            Exit Sub
        End If
        Dim vConfirm As String = "Are you sure you want to delete the selected Work Order Item?"
        If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If

        deleteWorkOrderItem(bsWorkOrderItems.Current.workOrderItemNumber, oWorkOrder.Orderstatus)
        getWorkorderItems(vWorkorderNum)
    End Sub

    Private Sub btnPrintWorkOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintWorkOrder.ItemClick
        saveDataChanges()
        printWorkOrder(vWorkorderNum)
    End Sub

    Private Sub rbtnChangeHoldStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangeHoldStatus.ItemClick
        changeOnHoldStatus()
    End Sub

#End Region

#Region "WORKORDER"

    Private Sub addNewObject()
        oWorkOrder = New Workorder
        oWorkOrder.AddNew()
        oWorkOrder.Orderstatus = "PENDING"
        oWorkOrder.Workorderdate = Today
        oWorkOrder.Workordertype = "STANDARD"
        oWorkOrder.Vendorid = 99
        oWorkOrder.Onhold = False
        oWorkOrder.Orsoonerflag = True
        oWorkOrder.Createdby = vCurrentUserLogin
        oWorkOrder.Createdtime = Now
        oWorkOrder.Modifyby = vCurrentUserLogin
        oWorkOrder.Modifytime = Now
        oWorkOrder.Freezeprotectflag = oParms.FreezeWarning
        oWorkOrder.Save()
        vWorkorderNum = oWorkOrder.Workordernumber.Value
        setWorkOrderHeading()
        bsWorkOrder.DataSource = oWorkOrder
        setupFulfillmentPlanButton()
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oWorkOrder = New Workorder
        oWorkOrder.LoadByPrimaryKey(vID)
        bsWorkOrder.DataSource = oWorkOrder
        setWorkOrderHeading()
        getWorkorderItems(vID)
        setupFulfillmentPlanButton()
        'getNotes("WORK ORDER", vID)

    End Sub

    Private Sub setupFulfillmentPlanButton()
        '
        Select Case oWorkOrder.Orderstatus
            Case "PENDING", "APPROVED", "IN PROCESS"
                If validateWorkOrder(eOrderType.EditValue, eTransportType.EditValue) Then
                    setFulfillmentPlanButtonState(False)
                Else
                    setFulfillmentPlanButtonState(True)
                End If
            Case Else
                setFulfillmentPlanButtonState(False)
        End Select

    End Sub

    ''' <summary>
    ''' Enable Disable plan related buttons
    ''' </summary>
    ''' <param name="vAppearance"></param>
    ''' <remarks></remarks>
    Private Sub setFulfillmentPlanButtonState(vAppearance As Boolean)
        Select Case oWorkOrder.Orderstatus
            Case "PENDING"
                rbtnAutoPlan.Enabled = vAppearance
            Case "APPROVED"
                rbtnAutoPlan.Enabled = vAppearance
            Case Else
                rbtnAutoPlan.Enabled = False
        End Select
        rbtnEditPlan.Enabled = vAppearance
    End Sub

    Private Sub unallocateAndRefreshWorkOrder()
        unallocateWorkOrder(vWorkorderNum)

        'first, check to see if all workorderitems have been unallocated or production orders and purchase requistions have been removed
        If (oWorkOrder.Orderstatus = "PENDING") AndAlso
            bsWorkOrderItems.Count > 0 Then
            Dim oItems As WorkorderitemCollection = getAllocatedWorkOrderItems(vWorkorderNum)
            If (oItems Is Nothing OrElse
                oItems.Count <= 0) Then
                If IsDBNull(eTransportType.EditValue) = False AndAlso
                    eTransportType.EditValue = TransportType.DIRECT.ToString() Then
                    If (saveWorkOrderChanges()) Then
                        directWorkOrderFulfillment(vWorkorderNum)
                    End If
                End If
            End If
        End If

        setupFulfillmentPlanButton()
        getWorkorderItems(vWorkorderNum)
    End Sub

    Private Sub setWorkOrderHeading()
        If oWorkOrder Is Nothing Then
            Exit Sub
        End If
        bTxtWorkOrderNum.Caption = oWorkOrder.Workordernumber
        bTxtWorkOrderDate.Caption = oWorkOrder.Workorderdate
        bTxtOrderStatus.Caption = oWorkOrder.Orderstatus
        Dim strC As String = Nothing
        Dim strM As String = Nothing
        If Not IsDBNull(oWorkOrder.Createdtime) And Not oWorkOrder.Createdtime Is Nothing And Not IsDBNull(oWorkOrder.Createdby) And Not oWorkOrder.Createdby Is Nothing Then
            strC = "Created: " & FormatDateTime(oWorkOrder.Createdtime, DateFormat.GeneralDate) & " by " & oWorkOrder.Createdby & " | "
        Else
            strC = ""
        End If
        If Not IsDBNull(oWorkOrder.Modifytime) And Not oWorkOrder.Modifytime Is Nothing And Not IsDBNull(oWorkOrder.Modifyby) And Not oWorkOrder.Modifyby Is Nothing Then
            strM = "Modified: " & FormatDateTime(oWorkOrder.Modifytime, DateFormat.GeneralDate) & " by " & oWorkOrder.Modifyby
        Else
            strM = ""
        End If
        lblEditInfo.Text = strC & "  " & strM
    End Sub

    Private Sub saveDataChanges()
        bsWorkOrder.EndEdit()
        bsWorkOrderItems.EndEdit()
        oWorkOrder.EndEdit()
        oWorkOrder.Save()
        oWorkOrderItems.Save()
    End Sub

    Private Function saveWorkOrderChanges() As Boolean
        bsWorkOrder.EndEdit()
        bsWorkOrderItems.EndEdit()

        If validateControls() = False Then
            Return False
        End If

        oWorkOrder.EndEdit()
        oWorkOrder.Transporttype = eTransportType.EditValue
        oWorkOrder.Modifyby = vCurrentUserLogin
        oWorkOrder.Modifytime = Now
        oWorkOrder.Save()
        'oWorkOrderItems.Save()

        If Not updateWorkOrderShipmentData(vWorkorderNum) Then
            MsgBox("Error in updating Shipment(s) data linked to this workorder", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        'Run Auto plan
        Select Case oWorkOrder.Orderstatus
            Case "PENDING", "APPROVED", "IN PROCESS"
                'If Transport type is DIRECT then fulfillment will be using purchase
                If (eTransportType.EditValue = TransportType.DIRECT.ToString()) Then
                    directWorkOrderFulfillment(bsWorkOrder.Current.workOrderNumber)
                End If
        End Select

        Return True
    End Function

    Private Sub cancelChanges()
        oWorkOrder.CancelEdit()
        Try
            If vEditType = "ADD" Then

                If MsgBox("Are you sure you want to Cancel this order? You will lose all data for it.", MsgBoxStyle.YesNo, "Confirm Cancellation") = MsgBoxResult.No Then
                    Exit Sub
                End If

                'unallocateAndRefreshWorkOrder()
                'We no need to refresh work order screen as we going to delete the work order and close the screen
                unallocateWorkOrder(vWorkorderNum)

                'delete all work order items, if any have been created
                Dim oItems As New WorkorderitemCollection
                oItems.Query.Where(oItems.Query.Workordernumber.Equal(oWorkOrder.Workordernumber))
                If oItems.Query.Load Then
                    oItems.MarkAllAsDeleted()
                    oItems.Save()
                End If
                'delete the workorder record
                oWorkOrder.MarkAsDeleted()
                oWorkOrder.Save()

            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rbtnChangeWorkOrderDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangeWorkOrderDate.ItemClick

        If MsgBox("Are you sure you want to change the work order date?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim vDate As Date? = getUserDateAllowNull("Enter New Work Order Date:")
        If Not vDate Is Nothing AndAlso
            IsDBNull(vDate) = False Then

            Dim oOrd As New Workorder
            Try
                oOrd.LoadByPrimaryKey(vWorkorderNum)
                oOrd.Workorderdate = vDate
                oOrd.Save()
                editObject(vWorkorderNum)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, ex.ToString)
            End Try
        End If
    End Sub

    Private Sub changeOnHoldStatus()
        If oWorkOrder.Onhold = False Then
            If MsgBox("Are you sure you want to place this Work Order on hold?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                Exit Sub
            End If
            Dim obj As New Workorder
            obj.LoadByPrimaryKey(vWorkorderNum)
            obj.Onhold = 1
            obj.Onholdreason = getUserString("Enter the reason for putting the Work Order on hold:")
            obj.Save()
        Else
            'Order already on hold
            If MsgBox("Are you sure you want to remove the hold from this Work Order?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                Exit Sub
            End If
            Dim obj As New Workorder
            obj.LoadByPrimaryKey(vWorkorderNum)
            obj.Onhold = 0
            obj.Onholdreason = ""
            obj.Save()
        End If

        saveDataChanges()
        editObject(vWorkorderNum)

    End Sub

#End Region

#Region "WORKORDER ITEMS"

    Private Sub getWorkorderItems(ByVal vID As Integer)
        Try
            bsWorkOrderItems.DataSource = getViewWorkOrderItems(vID)
            grWorkOrderItems.DataSource = bsWorkOrderItems
            grWorkOrderItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'get gross weight of items on workorder
        Dim oGrossWgt As New ViewWorkOrderGrossWeightCollection
        oGrossWgt.Query.Where(oGrossWgt.Query.Workordernumber.Equal(vID))
        If oGrossWgt.Query.Load Then
            eGrossWgt.EditValue = oGrossWgt(0).GrossWeight
        End If

    End Sub

    Private Sub addWorkOrderItem()
        If IsDBNull(eCustomer.EditValue) Then
            MsgBox("You must select a Customer first", MsgBoxStyle.Critical, "Error - No Customer Selected")
            Exit Sub
        End If
        If IsDBNull(eOrderType.EditValue) Then
            MsgBox("You must select an Order Type first", MsgBoxStyle.Critical, "Error - No Order Type Selected")
            Exit Sub
        End If
        If IsDBNull(eTransportType.EditValue) Then
            MsgBox("You must select a Tranport Type first", MsgBoxStyle.Critical, "Error - No Transport Type Selected")
            Exit Sub
        End If
        If eTransportType.EditValue = PurchaseItemType.DIRECT.ToString() AndAlso
            String.IsNullOrEmpty(Me.ePlannedShippedDate.Text) Then
            MsgBox("Ship Date is required.", MsgBoxStyle.Critical, "Error")
            ePlannedShippedDate.Focus()
            Exit Sub
        End If
        If eTransportType.EditValue = TransportType.DIRECT.ToString() AndAlso
            String.IsNullOrEmpty(eCustPO.Text) Then
            MsgBox("Customer PO is required.", MsgBoxStyle.Critical, "Error")
            eCustPO.Focus()
            Exit Sub
        End If

        bsWorkOrder.EndEdit()
        oWorkOrder.Save()

        'Dim frm As New frmAddEditProductItem
        Dim frm As New frmAddEditWOItemProduct
        frm.vWONum = Me.bsWorkOrder.Current.workOrderNumber
        frm.vEditType = "ADD"
        frm.vOrderType = bsWorkOrder.Current.orderType
        frm.vWorkOrderStatus = bsWorkOrder.Current.orderStatus
        frm.vBillable = bsWorkOrder.Current.billingType
        frm.vTransType = bsWorkOrder.Current.transportType
        frm.vCustID = eCustomer.EditValue
        frm.vCustPO = bsWorkOrder.Current.customerPO
        Dim vResult As DialogResult
        vResult = frm.ShowDialog()
        If vResult = Windows.Forms.DialogResult.Yes Then
            If Not eTransportType.EditValue Is Nothing AndAlso
                IsDBNull(eTransportType.EditValue) = False AndAlso
                eTransportType.EditValue = TransportType.DIRECT.ToString() AndAlso
                oWorkOrder.Orderstatus = "PENDING" Then
                directWorkOrderFulfillment(vWorkorderNum)
            End If
        End If
        getWorkorderItems(vWorkorderNum)
    End Sub

    Private Sub editWorkOrderItem(vEditCategory As String)
        If bsWorkOrderItems.Count <= 0 Then
            Exit Sub
        End If

        'commit WorkOrder changes first
        bsWorkOrder.EndEdit()
        oWorkOrder.EndEdit()
        oWorkOrder.Save()

        Select Case bsWorkOrderItems.Current.itemType

            Case "PRODUCT"
                'Dim frm As New frmAddEditProductItem
                Dim frm As New frmAddEditWOItemProduct
                frm.vID = Me.bsWorkOrderItems.Current.workOrderItemNumber
                frm.vWONum = Me.bsWorkOrder.Current.workOrderNumber
                frm.vEditType = "EDIT"
                frm.vEditCategory = vEditCategory
                frm.vOrderType = bsWorkOrder.Current.orderType
                frm.vBillable = bsWorkOrder.Current.billingType
                frm.vTransType = bsWorkOrder.Current.transportType
                frm.vCustID = eCustomer.EditValue
                frm.vCustPO = bsWorkOrder.Current.customerPO
                frm.ShowDialog()
        End Select

        getWorkorderItems(vWorkorderNum)
    End Sub

#End Region

#Region "NOTES"

    'Private Sub getNotes(vLinkType As String, vLinkKey As Integer)
    '    oNotes = New NoteCollection
    '    oNotes.Query.Where(oNotes.Query.LinkType.Equal(vLinkType), oNotes.Query.LinkKey.Equal(vLinkKey), oNotes.Query.IsDeleted.Equal(0))
    '    oNotes.Query.Load()
    '    bsNotes.DataSource = oNotes
    'End Sub


    'Private Sub btnViewAllNotes_Click(sender As Object, e As EventArgs) Handles btnViewAllNotes.Click
    '    viewAllNotes("WORK ORDER", bsWorkOrder.Current.WorkOrderNumber)
    'End Sub

    'Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
    '    addNote("WORK ORDER", bsWorkOrder.Current.WorkOrdernumber)
    'End Sub

    'Private Sub btnEditNote_Click(sender As Object, e As EventArgs) Handles btnEditNote.Click
    '    If bsNotes.Count <= 0 Then
    '        Exit Sub
    '    End If
    '    editNote(bsNotes.Current.NoteKey, bsNotes.Current.LinkType, bsNotes.Current.LinkKey)
    'End Sub

    'Private Sub btnDeleteNote_Click(sender As Object, e As EventArgs) Handles btnDeleteNote.Click
    '    If bsNotes.Count <= 0 Then
    '        Exit Sub
    '    End If
    '    deleteNote(bsNotes.Current.NoteKey, bsNotes.Current.LinkType, bsNotes.Current.LinkKey)
    'End Sub

    'Private Sub viewAllNotes(vLinkType As String, vLinkKey As Integer)
    '    'show popup form with all notes recorded against the current entity instance
    '    Dim frm As New frmNotes
    '    frm.vLinkType = vLinkType
    '    frm.vLinkKey = vLinkKey
    '    frm.ShowDialog()
    '    getNotes(vLinkType, vLinkKey)
    'End Sub

    'Private Sub addNote(vLinkType As String, vLinkKey As Integer)
    '    Dim frm As New frmAddEditNote
    '    frm.vEditType = "ADD"
    '    frm.vLinkType = vLinkType
    '    frm.vLinkKey = vLinkKey
    '    frm.ShowDialog()
    '    getNotes(vLinkType, vLinkKey)
    'End Sub

    'Private Sub editNote(vKey As Integer, vLinkType As String, vLinkKey As Integer)
    '    Dim frm As New frmAddEditNote
    '    frm.vEditType = "EDIT"
    '    frm.vID = vKey
    '    frm.vLinkType = vLinkType
    '    frm.vLinkKey = vLinkKey
    '    frm.ShowDialog()
    '    getNotes(vLinkType, vLinkKey)
    'End Sub

    'Private Sub deleteNote(vKey As Integer, vLinkType As String, vLinkKey As Integer)
    '    If MsgBox("Are you sure you want to delete the selected note record?", MsgBoxStyle.YesNo, "Confirm deletion request") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If
    '    Dim oNote As New Note
    '    If oNote.LoadByPrimaryKey(vKey) Then
    '        oNote.IsDeleted = 1
    '        oNote.Save()
    '    End If
    '    getNotes(vLinkType, vLinkKey)
    'End Sub

#End Region

#Region "CUSTOMER"

    Private Sub eCustomer_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles eCustomer.EditValueChanging
        If IsInitializing = False Then

            FlagCONSIGNMENTCustomer = True

            If IsDBNull(eCustomer.EditValue) Then
                e.Cancel = False
                Exit Sub
            End If

            If IsDBNull(e.NewValue) OrElse e.NewValue = 0 Then
                Exit Sub
            End If

            If MsgBox("Are you sure you want to change the Customer for this work order?", MsgBoxStyle.YesNo, "Confirm Customer Change") = MsgBoxResult.No Then
                e.Cancel = True
            End If

        End If

    End Sub

    Private Sub eCustomer_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eCustomer.EditValueChanged
        If FlagCONSIGNMENTCustomer Then
            If IsDBNull(eCustomer.EditValue) Then
                Exit Sub
            End If

            If (Not CheckForCONSIGNMENTCustomer()) Then
                'clear customer field value and lookup fields
                eCustomer.EditValue = Nothing
                setCustomerDetails(eCustomer.EditValue)
                Exit Sub
            End If

            If vEditType = "ADD" Then
                setCustomerDetails(eCustomer.EditValue)
            End If
        End If
    End Sub

    Private Sub eCustomer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eCustomer.ButtonClick
        Select Case e.Button.Index
            Case 1
                If IsDBNull(eCustomer.EditValue) Then
                    Exit Sub
                End If
                editCustomer(eCustomer.EditValue)
            Case 2
                addCustomer()
        End Select
    End Sub

    Private Sub editCustomer(vKey As Integer)
        If IsDBNull(vKey) Then
            Exit Sub
        End If
        If vKey <= 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditCustomer
        frm.vEditType = "EDIT"
        frm.vID = vKey
        frm.ShowDialog()
        getCustomers()
        setCustomerDetails(eCustomer.EditValue)
    End Sub

    Private Sub addCustomer()
        Dim frm As New frmAddEditCustomer
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getCustomers()
        setCustomerDetails(eCustomer.EditValue)
    End Sub

    Private Sub setCustomerDetails(vKey As Integer)
        If IsDBNull(vKey) Or vKey <= 0 Then
            'there is no value for the customer id - reset all lookup fields to nothing

            'set screen objects to values from customer record
            eShipAddr1.Text = Nothing
            eShipAddr2.Text = Nothing
            eShipCity.Text = Nothing
            eShipState.Text = Nothing
            eShipZip.Text = Nothing
            eShipCountry.Text = Nothing
            eShipPhone.Text = Nothing
            eShipContact.Text = Nothing

            'set freight objects
            eFOB.EditValue = Nothing
            eCarrier.EditValue = Nothing
            eLogistics.EditValue = Nothing
            eCustomerBilled.EditValue = Nothing
            eFreightOnInvoice.EditValue = Nothing

            'save changes to database
            bsWorkOrder.EndEdit()
            oWorkOrder.Save()

            'set Workorder Notes Fields
            If vEditType = "ADD" Then
                Dim obj As New Workorder
                If obj.LoadByPrimaryKey(oWorkOrder.Workordernumber) Then
                    obj.Custid = vKey
                    obj.Ordernotes = Nothing
                    obj.Prodfulfillmentnotes = Nothing
                    obj.Accountingnotes = Nothing
                    obj.Transportationnotes = Nothing
                    obj.Billofladingnotes = Nothing
                    obj.Save()
                End If
                editObject(vWorkorderNum)
            End If

            Exit Sub
        End If

        'get customer record from database
        Dim oCust As New Customer
        Try
            If Not oCust.LoadByPrimaryKey(vKey) Then
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try

        'set screen objects to values from customer record
        eShipAddr1.Text = oCust.Custshipaddress1
        eShipAddr2.Text = oCust.Custshipaddress2
        eShipCity.Text = oCust.Custshipcity
        eShipState.Text = oCust.Custshipstateprov
        eShipZip.Text = oCust.Custshippostalcode
        eShipCountry.Text = oCust.Custshipcountry
        eShipPhone.Text = oCust.Custphone
        eShipContact.Text = oCust.Custshipcontact

        'set freight objects
        eFOB.EditValue = oCust.Fob
        eCarrier.EditValue = oCust.Carrierid
        eLogistics.EditValue = oCust.Logisticsid
        eCustomerBilled.EditValue = oCust.Freightbillcustomer
        eFreightOnInvoice.EditValue = oCust.Freightoninvoice

        'save changes to database
        bsWorkOrder.EndEdit()
        oWorkOrder.Save()

        'set Workorder Notes Fields
        If vEditType = "ADD" Then
            Dim obj As New Workorder
            If obj.LoadByPrimaryKey(oWorkOrder.Workordernumber) Then
                obj.Custid = vKey
                obj.Ordernotes = oCust.Custnotes
                obj.Prodfulfillmentnotes = oCust.Prodfulfillmentnotes
                obj.Accountingnotes = oCust.Accountingnotes
                obj.Transportationnotes = oCust.Transportationnotes
                obj.Billofladingnotes = oCust.Billofladingnotes
                obj.Save()
            End If
            editObject(vWorkorderNum)
        End If

    End Sub

#End Region

#Region "CARRIER"

    Private Sub FreightcarrierLookUpEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eCarrier.ButtonClick
        Select Case e.Button.Index
            Case 1
                If IsDBNull(eCarrier.EditValue) Then
                    Exit Sub
                End If
                editCarrier(eCarrier.EditValue)
            Case 2
                addNewCarrier()
        End Select
    End Sub

    Private Sub editCarrier(vKey As Integer)
        If IsDBNull(vKey) Then
            Exit Sub
        End If
        If vKey <= 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditCarrier
        frm.vEditType = "EDIT"
        frm.vID = vKey
        frm.ShowDialog()
        getCarriers()
    End Sub

    Private Sub addNewCarrier()
        Dim frm As New frmAddEditCarrier
        frm.vEditType = "ADD"
        frm.ShowDialog()
        If frm.vID > 0 Then
            eCarrier.EditValue = frm.vID
        End If
        getCarriers()
    End Sub

#End Region

#Region "LOGISITCS PROVIDER"

    Private Sub luLogistics_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eLogistics.ButtonClick
        Select Case e.Button.Index
            Case 1
                If IsDBNull(eLogistics.EditValue) Then
                    Exit Sub
                End If
                editLogisticsProvider(eLogistics.EditValue)
            Case 2
                addNewLogisticsProvider()
        End Select
    End Sub

    Private Sub editLogisticsProvider(vKey As Integer)
        If IsDBNull(vKey) Then
            Exit Sub
        End If
        If vKey <= 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditLogisticsProvider
        frm.vEditType = "EDIT"
        frm.vID = vKey
        frm.ShowDialog()
        getLogistics()
    End Sub

    Private Sub addNewLogisticsProvider()
        Dim frm As New frmAddEditLogisticsProvider
        frm.vEditType = "ADD"
        frm.ShowDialog()
        If frm.vID > 0 Then
            eLogistics.EditValue = frm.vID
        End If
        getLogistics()
    End Sub

#End Region

#Region "INVENTORY"

    Private Sub unAllocateItem()
        If bsWorkOrderItems.Count <= 0 Then
            Exit Sub
        End If

        'reset Inventory Item if one is already allocated
        Dim vNum As Integer = 0
        If Not bsWorkOrderItems.Current.invitemnumber Is Nothing Then
            vNum = bsWorkOrderItems.Current.invitemnumber
            unAllocateInventoryItem(vNum)
        End If

        'now reset values for the current work order item
        'bsWorkOrderItems.Current.invitemnumber = Nothing
        'bsWorkOrderItems.Current.lotnumber = Nothing
        'bsWorkOrderItems.Current.warehouselocation = Nothing
        'bsWorkOrderItems.EndEdit()
        'oWorkOrderItems.Save()
        'getWorkorderItems(vWorkorderNum)
    End Sub

#End Region

#Region "ORDER/BILLING/TRANSPORT TYPE"

    Private Sub eOrderType_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles eOrderType.EditValueChanging

        If IsDBNull(e.NewValue) Then
            Exit Sub
        End If

        If e.NewValue = IIf(IsDBNull(e.OldValue), "", e.OldValue) Then
            Exit Sub
        End If


        'check to see if customer field has already been populated. Display warnings to user
        'Scenario 1: Customer is CONSIGNMENT - warn if selection STANDARD order type - allow to continue
        'Scenario 2: Customer is NOT CONSIGNMENT - prevent any CONSIGNMENT order type
        If IsDBNull(eCustomer.EditValue) Then
            Exit Sub
        End If
        If eCustomer.EditValue > 0 Then
            'customer has already been selected - now check to see if customer selected is a consignment customer
            Dim oCust As New Customer
            If oCust.LoadByPrimaryKey(eCustomer.EditValue) Then
                Select Case oCust.Isconsignment
                    Case True
                        If e.NewValue = "STANDARD" Then
                            'warn user that they are creating a STANDARD order type for a CONSIGNMENT customer - can be allowed
                            If MsgBox("You selected a standard order but the selected customer is a consignment customer. Are you sure you want to proceed?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                                e.Cancel = True
                                Exit Sub
                            End If
                        End If
                    Case Else
                        If e.NewValue = "CONSIGNMENT TRANSFER" Or e.NewValue = "CONSIGNMENT USAGE" Then
                            MsgBox("The customer selected is NOT a consignment customer. You cannot select a CONSIGNMENT order type.", MsgBoxStyle.Critical, "ERROR - Consignment Order Not Allowed")
                            e.Cancel = True
                            Exit Sub
                        End If
                End Select
            End If
        End If

        If oWorkOrderItems.Count > 0 Then
            Select Case e.NewValue
                Case "CONSIGNMENT TRANSFER"
                    If MsgBox("This change will result in all work order items being marked as NON-BILLABLE and all price adjustments will be lost. Do you want to continue?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
                        e.Cancel = False  'this confirms the edit and the new value is accepted
                        RecalculateWorkOrderItems(False)
                        oWorkOrder.Save()
                    Else
                        e.Cancel = True 'this cancels the edit and returns the lookupedit object value to the old value - the new value is rejected
                    End If
                Case Else
                    If e.NewValue <> IIf(IsDBNull(e.OldValue), "", e.OldValue) Then
                        If MsgBox("This change will result in all work order items being marked as BILLABLE with default pricing applied. Do you want to continue?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
                            e.Cancel = False  'this confirms the edit and the new value is accepted
                            RecalculateWorkOrderItems(True)
                            oWorkOrder.Save()
                        Else
                            e.Cancel = True  'this cancels the edit and returns the lookupedit object value to the old value - the new value is rejected
                        End If
                    End If
            End Select
        End If

        Select Case e.NewValue
            Case "CONSIGNMENT USAGE"
                eTransportType.EditValue = TransportType.NONE.ToString()
                oWorkOrder.Transporttype = TransportType.NONE.ToString()
                enableFreightObjects(TransportType.NONE.ToString())
            Case Else
                enableFreightObjects(IIf(IsDBNull(eTransportType.EditValue), "", eTransportType.EditValue))
        End Select

        bsWorkOrder.EndEdit()
        oWorkOrder.EndEdit()
        oWorkOrder.Save()

    End Sub

    Private Sub eOrderType_EditValueChanged(sender As Object, e As EventArgs) Handles eOrderType.EditValueChanged
        If vIsNotPageLoad Then
            unallocateAndRefreshWorkOrder()
        End If
        Exit Sub

        'Dim oWO As New Workorder

        'If Not IsDBNull(vPreviousOrderType) And Not String.IsNullOrEmpty(vPreviousOrderType) Then
        '    If eOrderType.EditValue.ToString() = "CONSIGNMENT TRANSFER" And vPreviousOrderType.ToString() <> "CONSIGNMENT TRANSFER" Then
        '        If MsgBox("This change will result in all work order items being marked as NON BILLABLE, do you want to continue?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then

        '            RecalculateWorkOrderItems(False)

        '            oWorkOrderItems = New ViewWorkOrderItemsScreenCollection
        '            oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkorderNum))
        '            oWorkOrderItems.Query.Load()

        '            bsWorkOrderItems.DataSource = oWorkOrderItems
        '            grWorkOrderItems.DataSource = bsWorkOrderItems
        '            grWorkOrderItems.Refresh()

        '        Else
        '            If oWO.LoadByPrimaryKey(oWorkOrder.Workordernumber) Then
        '                oWO.Ordertype = vPreviousOrderType
        '                oWO.Save()
        '            End If
        '            bsWorkOrder.DataSource = oWO
        '            bsWorkOrder.EndEdit()
        '        End If
        '    ElseIf eOrderType.EditValue.ToString() <> "CONSIGNMENT TRANSFER" And vPreviousOrderType.ToString() = "CONSIGNMENT TRANSFER" Then
        '        If MsgBox(String.Format("You are attempting to change the Work order type to {0}, do you want to mark all work order items BILLABLE?", eOrderType.EditValue), vbYesNo + vbQuestion) = MsgBoxResult.Yes Then

        '            RecalculateWorkOrderItems(True)

        '            oWorkOrderItems = New ViewWorkOrderItemsScreenCollection
        '            oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vWorkorderNum))
        '            oWorkOrderItems.Query.Load()

        '            bsWorkOrderItems.DataSource = oWorkOrderItems
        '            grWorkOrderItems.DataSource = bsWorkOrderItems
        '            grWorkOrderItems.Refresh()

        '        Else
        '            If oWO.LoadByPrimaryKey(oWorkOrder.Workordernumber) Then
        '                oWO.Ordertype = vPreviousOrderType
        '                oWO.Save()
        '            End If
        '            bsWorkOrder.DataSource = oWO
        '            bsWorkOrder.EndEdit()
        '        End If
        '    End If
        'End If

        'Select Case eOrderType.EditValue.ToString()
        '    Case "CONSIGNMENT USAGE"
        '        eTransportType.EditValue = "NONE"
        '        oWO.Transporttype = "NONE"
        'End Select
        'oWO.Save()


    End Sub

    Private Sub RecalculateWorkOrderItems(vBillable As Boolean)

        'this code should walk through all existing WORKORDERITEM records linked to the current WORKORDER
        'and pull all PRICING and COSTING information for each PRODUCT (if vBillable = TRUE) or mark each
        'PRODUCT as non-billable (with price = 0.00 and standardcost = 0.00) (if vBillable = FALSE)

        'NOTE: IF THIS PROCESS IS RUN AGAINST ANY ITEM THAT HAS HAD A PRICE ADJUSTMENT DIFFERENT THAN THE PRICELIST 
        'THAT ADJUSTMENT WILL BE LOST

        If IsDBNull(eCustomer.EditValue) Then
            MsgBox("Cannot update WorkOrder item pricing and costing data without first selecting a customer", MsgBoxStyle.Critical, "Error - Missing Customer")
            Exit Sub
        End If

        oWorkOrder.EndEdit()
        oWorkOrder.Save()

        Dim oWOItems As New WorkorderitemCollection
        oWOItems.Query.Where(oWOItems.Query.Workordernumber.Equal(oWorkOrder.Workordernumber))
        If Not oWOItems.Query.Load Then
            Exit Sub
        End If

        For Each oItem As Workorderitem In oWOItems

            'Step 0 - Set Billable value for the WorkOrderItem
            oItem.Billable = vBillable

            'Step 1 - Get all reference field data from PRODUCT table for Product ID, including Standard Costing

            oProduct = New Product
            If oProduct.LoadByPrimaryKey(oItem.Productid) Then
                oItem.Container = oProduct.Container
                oItem.Itemdescription = oProduct.Productdesc
                oItem.Productid = oProduct.Productid
                oItem.Units = oProduct.Units
                oItem.Uom = oProduct.Uom
                oItem.Totalvolume = oProduct.Volumeunits
                oItem.Totalweight = oProduct.Weightunits
                oItem.Volumeuom = oProduct.Volumeuom
                oItem.Weightuom = oProduct.Weightuom
                oItem.DOTIDNumber = oProduct.Idnumber
                oItem.Dotdesc = oProduct.Dotdesc
                oItem.Hazmatid = oProduct.Hazmatid
                oItem.Hazmatclass = oProduct.Hazclassnumber
                oItem.Hazmatdesc = oProduct.Hazmatdesc
                oItem.Hazmatpackagegroup = oProduct.Packagegroup
                oItem.Classrate = oProduct.Classrate
                oItem.Unline = oProduct.Unline
                If oProduct.Hazmatid <> 1 Then
                    oItem.Ishazardous = 1
                Else
                    oItem.Ishazardous = 0
                End If

            End If

            'Step 2 - Get Product Pricing from PRICELIST table for ProductID/CustomerID

            Dim oPriceRec As Pricelist
            oPriceRec = getPriceListRecord(oItem.Productid, oWorkOrder.Custid)
            If oItem.Billable Then
                Select Case oPriceRec.Pricingmethod
                    Case PricingMethod.VOLUME.ToString()
                        oItem.Priceunits = oPriceRec.Volumeunits
                        oItem.Priceuom = oPriceRec.Volumeuom
                        oItem.Unitprice = oPriceRec.Volumeprice
                    Case PricingMethod.WEIGHT.ToString()
                        oItem.Priceunits = oPriceRec.Weightunits
                        oItem.Priceuom = oPriceRec.Weightuom
                        oItem.Unitprice = oPriceRec.Weightprice
                    Case Else
                        'This situation would most likely occur if NO PRICELIST record was returned
                        'or the PRICELIST record was not correctly completed and there is no value
                        'for the PricingMethod field in the PRICELIST record
                        'Set the Pricing information to ZERO
                        oItem.Priceunits = 0.0
                        oItem.Priceuom = ""
                        oItem.Unitprice = 0.0
                End Select
            Else
                oItem.Priceunits = 0.0
                oItem.Priceuom = ""
                oItem.Unitprice = 0.0
            End If

            'Step 3 - Set STANDARD (CHEMICAL ONLY) COSTING for selected Product (we already have the PRODUCT record selected and available)

            If oItem.Billable Then
                Select Case oPriceRec.Pricingmethod
                    Case PricingMethod.VOLUME.ToString()
                        oItem.Standardcostunits = oProduct.Volumeunits
                        oItem.Standardcostuom = oProduct.Volumeuom
                        oItem.Standardunitcost = oProduct.Volumestandardcost
                    Case PricingMethod.WEIGHT.ToString()
                        oItem.Standardcostunits = oProduct.Weightunits
                        oItem.Standardcostuom = oProduct.Weightuom
                        oItem.Standardunitcost = oProduct.Weightstandardcost
                    Case Else
                        'This situation would most likely occur if NO PRICELIST record was returned
                        'or the PRICELIST record was not correctly completed and there is no value
                        'for the PricingMethod field in the PRICELIST record
                        'Set the STANDARD COSTING information according to the INVENTORY METHOD setting
                        'in the PRODUCT record
                        Select Case oProduct.Inventorymethod
                            Case ProductInventoryMethod.VOLUME.ToString()
                                oItem.Standardcostunits = oProduct.Volumeunits
                                oItem.Standardcostuom = oProduct.Volumeuom
                                oItem.Standardunitcost = oProduct.Volumestandardcost
                            Case ProductInventoryMethod.WEIGHT.ToString()
                                oItem.Standardcostunits = oProduct.Weightunits
                                oItem.Standardcostuom = oProduct.Weightuom
                                oItem.Standardunitcost = oProduct.Weightstandardcost
                            Case Else
                                MsgBox("No Inventory method is established for the selected product. Standard Cost cannot be determined", MsgBoxStyle.Critical, "Error Missing Data")
                                oItem.Standardcostunits = 0
                                oItem.Standardcostuom = ""
                                oItem.Standardunitcost = 0
                        End Select
                End Select
            Else
                'If item is NOT billable, we do not track STANDARD (CHEMICAL ONLY) COSTS
                oItem.Standardcostunits = 0.0
                oItem.Standardcostuom = ""
                oItem.Standardunitcost = 0.0
            End If

            'Step 4 - Set CUSTOMER PRODUCT CODE from PRICELIST for selected Item (Product)

            oItem.Custitemid = oPriceRec.Customerproductcode

        Next

        oWOItems.Save()
        getWorkorderItems(oWorkOrder.Workordernumber)


        'Dim Unitorcontainer As String = String.Empty
        'Dim QTY As String = 0
        'Dim Productid As Integer = 0
        'Dim Extprofit As Decimal = 0
        'Dim vWorkorderitemnumber As New StringBuilder()

        'For Each ord As ViewWorkOrderItemsScreen In oWorkOrderItems
        '    If Not ord.Workorderitemnumber Is Nothing Then
        '        oItemList = New Workorderitem
        '        If oItemList.LoadByPrimaryKey(ord.Workorderitemnumber) Then

        '            If Not ord.Unitorcontainer Is Nothing Then
        '                Unitorcontainer = ord.Unitorcontainer
        '            End If
        '            If Not ord.Qty Is Nothing Then
        '                QTY = ord.Qty
        '            End If
        '            If Not ord.Productid Is Nothing Then
        '                Productid = ord.Productid
        '            End If

        '            addPricing(oItemList, Productid, vBillable)

        '            oItemList.Billable = vBillable
        '            oItemList.EndEdit()
        '            oItemList.Save()
        '            Extprofit = If(Not String.IsNullOrEmpty(oItemList.Extprofit), Format(oItemList.Extprofit, "0.0000"), Format(0.0, "0.0000"))
        '            If Extprofit < 0 Then
        '                vWorkorderitemnumber.Append(ord.Workorderitemnumber).Append(",")
        '            End If
        '        End If
        '    End If
        'Next

        'If Not String.IsNullOrEmpty(vWorkorderitemnumber.ToString()) Then
        '    Dim sMsg As String = String.Format("Margins for some work order items ({0}) was less than 0, please review those", vWorkorderitemnumber.ToString().TrimEnd(","))
        '    MsgBox(sMsg)
        'End If

    End Sub

    ' ''' <summary>
    ' ''' Getting Data From priceList and Product tables based on Pricing Method
    ' ''' </summary>
    ' ''' <param name="oItemList"></param>
    ' ''' <param name="Productid"></param>
    ' ''' <param name="vBillable"></param>
    ' ''' <remarks></remarks>
    'Private Sub addPricing(oItemList As Workorderitem, Productid As Int32, vBillable As Boolean)
    '    Dim PriceMethod As String = Nothing

    '    ' Get PriceList Information
    '    oPriceList = getPriceListRecord(Productid, eCustomer.EditValue)

    '    ' Get Product Information
    '    oProduct = New Product
    '    oProduct.Query.Where(oProduct.Query.Productid.Equal(Productid))
    '    oProduct.Query.Load()

    '    ' Get the Pricing method either from PriceList or Product
    '    If oPriceList.Pricelistid > 0 And Not oPriceList.Pricingmethod Is Nothing Then
    '        PriceMethod = oPriceList.Pricingmethod
    '    Else
    '        If MsgBox("There is no record of this product for this customer in the Price List, do you want to continue?", vbYesNo + vbQuestion) = vbNo Then
    '            Me.Close()
    '        Else
    '            ' Assume Pricing Method is VOLUME if inventory method is NULL
    '            PriceMethod = If(Not String.IsNullOrEmpty(oProduct.Inventorymethod), oProduct.Inventorymethod, PricingMethod.VOLUME.ToString())
    '        End If
    '    End If

    '    ' Load Data based on Pricing Method from PriceList and Product
    '    Select Case PriceMethod
    '        Case "VOLUME"

    '            oItemList.Priceunits = If(Not String.IsNullOrEmpty(oPriceList.Volumeunits), Format(oPriceList.Volumeunits, "0.00"), Format(0.0, "0.00"))
    '            oItemList.Priceuom = If(Not String.IsNullOrEmpty(oPriceList.Volumeuom), oPriceList.Volumeuom, "")
    '            oItemList.Standardcostunits = If(Not String.IsNullOrEmpty(oProduct.Volumeunits), Format(oProduct.Volumeunits, "0.00"), Format(0.0, "0.00"))
    '            oItemList.Standardcostuom = If(Not String.IsNullOrEmpty(oProduct.Volumeuom), oProduct.Volumeuom, "")

    '            Select Case vBillable
    '                Case True
    '                    oItemList.Unitprice = If(Not String.IsNullOrEmpty(oPriceList.Volumeprice), Format(oPriceList.Volumeprice, "0.0000"), Format(0.0, "0.0000"))
    '                    oItemList.Standardunitcost = If(Not String.IsNullOrEmpty(oProduct.Volumestandardcost), Format(oProduct.Volumestandardcost, "0.0000"), Format(0.0, "0.0000"))
    '                Case False
    '                    Select Case eOrderType.Text
    '                        Case "CONSIGNMENT TRANSFER"
    '                            oItemList.Standardunitcost = Format(0.0, "0.0000")
    '                        Case Else
    '                            oItemList.Standardunitcost = If(Not String.IsNullOrEmpty(oProduct.Volumestandardcost), Format(oProduct.Volumestandardcost, "0.0000"), Format(0.0, "0.0000"))
    '                    End Select
    '                    oItemList.Unitprice = Format(0.0, "0.0000")
    '            End Select
    '        Case "WEIGHT"
    '            oItemList.Priceunits = If(Not String.IsNullOrEmpty(oPriceList.Weightunits), Format(oPriceList.Weightunits, "0.00"), Format(0.0, "0.00"))
    '            oItemList.Priceuom = If(Not String.IsNullOrEmpty(oPriceList.Weightuom), oPriceList.Weightuom, "")
    '            oItemList.Standardcostunits = If(Not String.IsNullOrEmpty(oProduct.Weightunits), Format(oProduct.Weightunits, "0.00"), Format(0.0, "0.00"))
    '            oItemList.Standardcostuom = If(Not String.IsNullOrEmpty(oProduct.Weightuom), oProduct.Weightuom, "")

    '            Select Case vBillable
    '                Case True
    '                    oItemList.Unitprice = If(Not String.IsNullOrEmpty(oPriceList.Weightprice), Format(oPriceList.Weightprice, "0.0000"), Format(0.0, "0.0000"))
    '                    oItemList.Standardunitcost = If(Not String.IsNullOrEmpty(oProduct.Weightstandardcost), Format(oProduct.Weightstandardcost, "0.0000"), Format(0.0, "0.0000"))
    '                Case False
    '                    Select Case eOrderType.Text
    '                        Case "CONSIGNMENT TRANSFER"
    '                            oItemList.Standardunitcost = Format(0.0, "0.0000")
    '                        Case Else
    '                            oItemList.Standardunitcost = If(Not String.IsNullOrEmpty(oProduct.Weightstandardcost), Format(oProduct.Weightstandardcost, "0.0000"), Format(0.0, "0.0000"))
    '                    End Select
    '                    oItemList.Unitprice = Format(0.0, "0.0000")
    '            End Select
    '        Case Else
    '            oItemList.Priceunits = Format(0.0, "0.00")
    '            oItemList.Priceuom = ""
    '            oItemList.Unitprice = Format(0.0, "0.0000")

    '            oItemList.Standardcostunits = Format(0.0, "0.00")
    '            oItemList.Standardcostuom = ""
    '            oItemList.Standardunitcost = Format(0.0, "0.00")
    '    End Select

    '    oItemList.Actualcostunits = Format(0.0, "0.00")
    '    oItemList.Actualcostuom = ""
    '    oItemList.Actualunitcost = Format(0.0, "0.0000")

    '    ' Calculate Extended Price, Extended Cost and Extended Profit
    '    Select Case oItemList.Unitorcontainer
    '        Case "C"
    '            oItemList.Extprice = oItemList.Unitprice * oItemList.Priceunits * oItemList.Qty
    '            oItemList.Extcost = oItemList.Standardcostunits * oItemList.Standardunitcost * oItemList.Qty
    '        Case Else
    '            oItemList.Extprice = oItemList.Unitprice * oItemList.Qty
    '            oItemList.Extcost = oItemList.Standardunitcost * oItemList.Qty
    '    End Select

    '    oItemList.Extprofit = oItemList.Extprice - oItemList.Extcost
    'End Sub

    Private Function CheckForCONSIGNMENTCustomer() As Boolean
        CheckForCONSIGNMENTCustomer = True

        If IsDBNull(eOrderType.EditValue) Then
            Exit Function
        End If

        If IsDBNull(eCustomer.EditValue) Then
            Exit Function
        End If

        Dim oCust As New Customer

        If (Not oCust.LoadByPrimaryKey(Convert.ToInt32(eCustomer.EditValue))) Then
            Exit Function
        End If

        If eOrderType.EditValue.ToString().Equals("CONSIGNMENT TRANSFER") Or eOrderType.EditValue.ToString().Equals("CONSIGNMENT USAGE") Then
            If (Not oCust.Isconsignment) Or IsDBNull(oCust.Isconsignment) Or oCust.Isconsignment Is Nothing Then
                MsgBox("You selected a consignment order but the selected customer is not a consignment customer. This is not allowed. Please edit the customer record first, before attempting to assign this customer to a consignment order type.", MsgBoxStyle.Critical, "ERROR - Customer not eligible for Consignment Orders")
                CheckForCONSIGNMENTCustomer = False
                Exit Function
            End If
        Else
            If (oCust.Isconsignment) Then
                If MsgBox("You selected a standard order but the selected customer is a consignment customer. Are you sure you want to proceed?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    CheckForCONSIGNMENTCustomer = False
                    Exit Function
                End If
            End If
        End If
    End Function

    Private Sub eTransportType_EditValueChanged(sender As Object, e As EventArgs) Handles eTransportType.EditValueChanged
        If IsDBNull(eTransportType.EditValue) Then
            enableFreightObjects("RESET")
            Exit Sub
        End If
        'now update Transportation Planning Information screen objects based on user selection of Transport Type
        enableFreightObjects(eTransportType.EditValue)
    End Sub

    Private Sub enableFreightObjects(vOption As String)
        'update Transportation Planning Information screen objects
        Select Case vOption
            Case TransportType.OUTBOUND.ToString()
                rbtnChangePlannedShipDate.Enabled = True
                lblShippedDate.Visible = True
                ePlannedShippedDate.Visible = True
                lblDeliveryDate.Visible = True
                ePlannedDeliveryDate.Visible = True
                eFOB.Visible = True
                lblCharges.Visible = True
                lblCustomerBilled.Visible = True
                eCustomerBilled.Visible = True
                lblAddToInvoice.Visible = True
                eFreightOnInvoice.Visible = True
                lblLogistics.Visible = True
                eLogistics.Visible = True
                lblCarrier.Visible = True
                eCarrier.Visible = True
                lblSalesperson.Visible = False
                eSalesperson.Visible = False
            Case TransportType.DIRECT.ToString()
                rbtnChangePlannedShipDate.Enabled = True
                lblShippedDate.Visible = True
                ePlannedShippedDate.Visible = True
                lblDeliveryDate.Visible = True
                ePlannedDeliveryDate.Visible = True
                eFOB.Visible = True
                lblCharges.Visible = True
                lblCustomerBilled.Visible = True
                eCustomerBilled.Visible = True
                lblAddToInvoice.Visible = True
                eFreightOnInvoice.Visible = True
                lblLogistics.Visible = True
                eLogistics.Visible = True
                lblCarrier.Visible = True
                eCarrier.Visible = True
                lblSalesperson.Visible = False
                eSalesperson.Visible = False
            Case TransportType.NONE.ToString()
                ePlannedShippedDate.EditValue = ""
                ePlannedDeliveryDate.EditValue = ""
                eFOB.EditValue = ""
                eCustomerBilled.Checked = False
                eFreightOnInvoice.Checked = False
                eLogistics.EditValue = ""
                eCarrier.EditValue = ""
                rbtnChangePlannedShipDate.Enabled = False

                lblShippedDate.Visible = False
                ePlannedShippedDate.Visible = False
                lblDeliveryDate.Visible = False
                ePlannedDeliveryDate.Visible = False
                eFOB.Visible = False
                lblCharges.Visible = False
                lblCustomerBilled.Visible = False
                eCustomerBilled.Visible = False
                lblAddToInvoice.Visible = False
                eFreightOnInvoice.Visible = False
                lblLogistics.Visible = False
                eLogistics.Visible = False
                lblCarrier.Visible = False
                eCarrier.Visible = False
                lblSalesperson.Visible = False
                eSalesperson.Visible = False
            Case "SALES PICKUP"
                rbtnChangePlannedShipDate.Enabled = True
                lblShippedDate.Visible = True
                ePlannedShippedDate.Visible = True
                lblDeliveryDate.Visible = True
                ePlannedDeliveryDate.Visible = True
                eFOB.Visible = False
                lblCharges.Visible = False
                lblCustomerBilled.Visible = False
                eCustomerBilled.Visible = False
                lblAddToInvoice.Visible = False
                eFreightOnInvoice.Visible = False
                lblLogistics.Visible = False
                eLogistics.Visible = False
                lblCarrier.Visible = False
                eCarrier.Visible = False
                lblSalesperson.Visible = True
                eSalesperson.Visible = True
            Case "CUSTOMER PICKUP"
                rbtnChangePlannedShipDate.Enabled = True
                lblShippedDate.Visible = True
                ePlannedShippedDate.Visible = True
                lblDeliveryDate.Visible = True
                ePlannedDeliveryDate.Visible = True
                eFOB.Visible = False
                lblCharges.Visible = False
                lblCustomerBilled.Visible = False
                eCustomerBilled.Visible = False
                lblAddToInvoice.Visible = False
                eFreightOnInvoice.Visible = False
                lblLogistics.Visible = False
                eLogistics.Visible = False
                lblCarrier.Visible = False
                eCarrier.Visible = False
                lblSalesperson.Visible = False
                eSalesperson.Visible = False
            Case "RESET"
                rbtnChangePlannedShipDate.Enabled = True
                lblShippedDate.Visible = True
                ePlannedShippedDate.Visible = True
                lblDeliveryDate.Visible = True
                ePlannedDeliveryDate.Visible = True
                eFOB.Visible = True
                lblCharges.Visible = True
                lblCustomerBilled.Visible = True
                eCustomerBilled.Visible = True
                lblAddToInvoice.Visible = True
                eFreightOnInvoice.Visible = True
                lblLogistics.Visible = True
                eLogistics.Visible = True
                lblCarrier.Visible = True
                eCarrier.Visible = True
                lblSalesperson.Visible = False
                eSalesperson.Visible = False
        End Select
    End Sub

#End Region

    Private Sub btnEditAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditAll.ItemClick
        eOrderType.Enabled = True
        eCustomer.Enabled = True
        eTransportType.Enabled = True
    End Sub

#Region "Price"

    Private Function getPriceListRecord(vProdid As Integer, vCustID As Integer) As Pricelist

        Dim oPriceRec As New Pricelist
        Dim vLookupPrice As Decimal = 0.0
        Dim vCurrentPrice As Decimal = 0.0

        'REL 14.2 - AMERICO - MCGUIRE - 08/14/2014
        'This method fetches the current PRICELIST record for a PRODUCT / CUSTOMER combination
        'There should always be no more than 1 record for a PRODUCT / CUSTOMER combination
        'There can be situations where there are NO records in the PRICELIST table for a PRODUCT / CUSTOMER combination
        'The user has the option to accept the LookUp Price (from the PRICELIST table) or override that value 
        'for this single WORKORDERITEM record only

        'Get PRICELIST Record and return it to the calling method
        Dim oPrices As New PricelistCollection
        oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdid), oPrices.Query.Custid.Equal(vCustID), oPrices.Query.Effectivedate.LessThanOrEqual(Now.Date)).OrderBy(oPrices.Query.Effectivedate.Descending)
        oPrices.Query.Load()
        Select Case oPrices.Count
            Case Is > 0
                Return oPrices(0)
            Case Else
                Return oPriceRec
        End Select
    End Function

#End Region


    Private Sub rbtnEditPlan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditPlan.ItemClick
        'first, save all changes thus far in the work order/items
        bsWorkOrder.EndEdit()
        bsWorkOrderItems.EndEdit()
        If bsWorkOrderItems.Count <= 0 Then
            MsgBox("You must enter at least one work order item.", MsgBoxStyle.Critical, "Error - No items")
            Exit Sub
        End If
        oWorkOrder.Save()
        oWorkOrderItems.Save()

        Dim frm As New frmAssignInventoryItems2
        frm.vProductID = bsWorkOrderItems.Current.productID
        frm.vWorkOrderID = bsWorkOrder.Current.workOrderNumber
        frm.ShowDialog()
        getWorkorderItems(bsWorkOrder.Current.workOrderNumber)
    End Sub

    Private Sub rbtnAutoPlan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAutoPlan.ItemClick
        Me.Cursor = Cursors.WaitCursor
        If saveWorkOrderChanges() Then
            workOrderFulfillment(bsWorkOrder.Current.workOrderNumber)
            getWorkorderItems(bsWorkOrder.Current.workOrderNumber)
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub rbtnPrintPlan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintPlan.ItemClick
        Dim rpt As New rptFulfillmentPlan(vWorkorderNum)
        Me.Cursor = Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = Cursors.Default
    End Sub

    ''' <summary>
    ''' Send the Fulfilment plant report as email
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbtnEmailPlan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEmailPlan.ItemClick

        'save WorkOrder data thus far
        bsWorkOrder.EndEdit()
        oWorkOrder.EndEdit()
        oWorkOrder.Save()

        Me.Cursor = Cursors.WaitCursor
        Dim oMySettings As New My.MySettings
        Dim oSysparameters As Sysparameters = oMySettings.getSystemParameters()
        If oSysparameters Is Nothing = False Then
            Using frm As New frmEmailPlan() With
               {
                   .vSenderId = oSysparameters.WOEmailSender,
                   .vReceiverId = oSysparameters.WOEmailReceiver,
                   .vWorkOrderNumber = vWorkorderNum,
                   .oSysparameters = oSysparameters,
                   .vCustomerName = eCustomer.Text
                }
                frm.ShowDialog()
            End Using
        Else
            MsgBox("System parameters are not set", MsgBoxStyle.OkOnly, "Error")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub eTransportType_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles eTransportType.Properties.EditValueChanged
        If vIsNotPageLoad Then
            oWorkOrder.EndEdit()

            If checkWOItemsCustomerPO() = False Then
                eTransportType.EditValue = oWorkOrder.Transporttype
                eCustPO.Focus()
                Exit Sub
            End If
            oWorkOrder.Transporttype = eTransportType.EditValue
            unallocateAndRefreshWorkOrder()
        End If
    End Sub

    Private Sub ePlannedShippedDate_EditValueChanged(sender As Object, e As EventArgs) Handles ePlannedShippedDate.EditValueChanged

        If (vEditType <> "ADD") Then
            Exit Sub
        End If

        If ePlannedShippedDate.EditValue Is Nothing OrElse
           IsDBNull(ePlannedShippedDate.EditValue) Then
            Exit Sub
        End If

        If bsWorkOrderItems Is Nothing OrElse
            bsWorkOrderItems.Count <= 0 Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        'Binding source will be updating new value only after this event
        'So we need to set the new selected value to oWorkOrder for saving the new shipped date
        oWorkOrder.Plannedshipdate = IIf(String.IsNullOrEmpty(ePlannedShippedDate.EditValue), Nothing, ePlannedShippedDate.EditValue)

        If saveWorkOrderChanges() Then
            getWorkorderItems(bsWorkOrder.Current.workOrderNumber)
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grvWorkOrderItems_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grvWorkOrderItems.RowStyle
        If (e.RowHandle >= 0) Then
            setRowColor(grvWorkOrderItems.GetRowCellDisplayText(e.RowHandle, grvWorkOrderItems.Columns("Expectedindate")),
                grvWorkOrderItems.GetRowCellDisplayText(e.RowHandle, grvWorkOrderItems.Columns("Dateneeded")), e)
            setRowColor(grvWorkOrderItems.GetRowCellDisplayText(e.RowHandle, grvWorkOrderItems.Columns("Estimatedcompletiondate")),
                grvWorkOrderItems.GetRowCellDisplayText(e.RowHandle, grvWorkOrderItems.Columns("Neededby")), e)
        End If
    End Sub

    ''' <summary>
    ''' Set row color to pink if Field1 > Field2
    ''' </summary>
    ''' <param name="vField1"></param>
    ''' <param name="vField2"></param>
    ''' <param name="e"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function setRowColor(vField1 As String, vField2 As String, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) As Boolean
        If Not String.IsNullOrEmpty(vField1) AndAlso
            Not String.IsNullOrEmpty(vField2) Then
            If Convert.ToDateTime(vField1) > Convert.ToDateTime(vField2) Then
                e.Appearance.BackColor = Color.Pink
                e.Appearance.BackColor2 = Color.Pink
                e.Appearance.ForeColor = Color.Black
            End If
        End If
    End Function

    Private Sub rbtnChangePlannedShipDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangePlannedShipDate.ItemClick
        If MsgBox("Changing the planned ship date will alter the fulfillment timeline, are you sure you want to continue?" _
                  , MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim vDate As Date? = getUserDateAllowNull("Enter New Planned Ship Date:")

        If (validateShipDateChange(vDate, IIf(IsDBNull(ePlannedDeliveryDate.EditValue) OrElse
                                              String.IsNullOrEmpty(ePlannedDeliveryDate.EditValue),
                                              Nothing,
                                              ePlannedDeliveryDate.EditValue))) Then
            Try
                ePlannedShippedDate.EditValue = vDate
                oWorkOrder.Plannedshipdate = vDate
                Dim vDateNeeded As Date = getDateNeeded(oWorkOrder)
                If saveWorkOrderChanges() Then
                    updateSourceDocDateNeeded(vWorkorderNum, vDateNeeded)
                    getWorkorderItems(vWorkorderNum)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, ex.ToString)
            End Try
        End If
    End Sub

    Private Sub grvWorkOrderItems_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grvWorkOrderItems.RowCellClick

        If (e.Column.Name <> "colInvitemnumber") AndAlso
            (e.Column.Name <> "colSourcedocument") Then
            Exit Sub
        End If

        If ((String.IsNullOrEmpty(e.CellValue)) OrElse
            (e.CellValue <= 0)) Then
            Exit Sub
        End If

        Select Case e.Column.Name
            Case "colInvitemnumber"
                Using frm As New frmInventoryItemDetails() With
               {
                   .vID = e.CellValue
               }
                    frm.ShowDialog()
                End Using
            Case "colSourcedocument"

                Select Case grvWorkOrderItems.GetRowCellDisplayText(e.RowHandle, grvWorkOrderItems.Columns("Sourcetype"))
                    Case SourceType.PRCH.ToString()
                        Using frm As New frmAddEditPurchaseItem() With
                          {
                              .vID = e.CellValue,
                              .vEditType = "READONLY"
                          }
                            frm.ShowDialog()
                        End Using
                    Case SourceType.PORD.ToString()
                        Using frm As New frmAddEditProdOrder() With
                          {
                              .vID = e.CellValue,
                              .vEditType = "READONLY"
                          }
                            frm.ShowDialog()
                        End Using
                    Case SourceType.RLBL.ToString()
                        Dim oRelabelorderitem As New Relabelorderitem()
                        If oRelabelorderitem.LoadByPrimaryKey(e.CellValue) = False Then
                            Exit Sub
                        End If
                        Using frm As New frmAddEditRelabelOrder() With
                            {
                                .vRelabelOrderNumber = oRelabelorderitem.Relabelordernumber,
                                .vEditType = "READONLY"
                            }
                            frm.ShowDialog()
                        End Using
                End Select

        End Select
        getWorkorderItems(vWorkorderNum)

    End Sub

    Private Function validateControls() As Boolean
        If IsDBNull(eTransportType.EditValue) = False AndAlso
            eTransportType.EditValue <> TransportType.NONE.ToString() AndAlso
            String.IsNullOrEmpty(Me.ePlannedShippedDate.Text) Then
            MsgBox("Ship Date is required.", MsgBoxStyle.Critical, "Error")
            ePlannedShippedDate.Focus()
            Return False
        End If
        If checkWOItemsCustomerPO() = False Then
            eCustPO.Focus()
            Return False
        End If
        If bsWorkOrderItems.Count <= 0 Then
            MsgBox("You must enter at least one Item to save the work order", MsgBoxStyle.Critical, "Error - No items")
            Return False
        End If
        Return True
    End Function

    Private Function checkWOItemsCustomerPO() As Boolean
        bsWorkOrderItems.EndEdit()
        If eTransportType.EditValue <> TransportType.DIRECT.ToString() Then
            Return True
        End If
        If bsWorkOrderItems Is Nothing OrElse
            bsWorkOrderItems.Count <= 0 Then
            Return True
        End If
        If eTransportType.EditValue = TransportType.DIRECT.ToString() AndAlso
            String.IsNullOrEmpty(eCustPO.Text) Then
            MsgBox("Customer PO is required.", MsgBoxStyle.Critical, "Error")
            Return False
        End If
        For Each oWOItem As ViewWorkOrderItemsScreen In bsWorkOrderItems
            If oWOItem.Customerpo Is Nothing OrElse
                IsDBNull(oWOItem.Customerpo) OrElse
                String.IsNullOrEmpty(oWOItem.Customerpo) Then
                MsgBox("One or more Work Order Items have missing Customer PO #, please fix the work order item(s)", MsgBoxStyle.Critical, "Word Order Items - Error")
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub printWorkOrderDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintWorkOrderDocs.ItemClick
        saveDataChanges()
        printWorkOrderAndSourceOrders(vWorkorderNum)
    End Sub

    Private Sub enablePrint()
        If oWorkOrder.Orderstatus <> "PENDING" Then
            btnPrintWorkOrder.Enabled = True
            btnPrintWorkOrderDocs.Enabled = True
        End If
    End Sub

    Private Sub rbtnPickItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPickItems.ItemClick

        Dim oCust As New Customer
        oCust.LoadByPrimaryKey(eCustomer.EditValue)

        Dim frm As New frmPickWorkOrderItems
        frm.vWorkorderNum = vWorkorderNum
        frm.vFormTitle = "Items for Workorder #" & vWorkorderNum.ToString & " | " & oCust.Custname
        frm.ShowDialog()
        getWorkorderItems(vWorkorderNum)

    End Sub

    Private Sub btnUpdateCustomerPOAllItem_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomerPOAllItems.Click

        If IsDBNull(eCustPO.EditValue) Or eCustPO.EditValue = Nothing Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to update ALL workorder items with the same Customer PO Number?", MsgBoxStyle.YesNo, "Confirm - Update Customer PO Number") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oItems As New WorkorderitemCollection
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(vWorkorderNum))
        If oItems.Query.Load Then
            For Each oItem As Workorderitem In oItems
                oItem.Customerpo = eCustPO.EditValue
            Next
            oItems.Save()
            getWorkorderItems(vWorkorderNum)
        Else
            Exit Sub
        End If

    End Sub



    Private Sub CheckEdit1_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles CheckEdit1.EditValueChanging
        If e.OldValue <> e.NewValue Then
            Dim loadWorkorders As New ViewLoadWorkordersCollection
            loadWorkorders.Query.Where(loadWorkorders.Query.Workordernumber = vWorkorderNum)
            If (loadWorkorders.Query.Load() AndAlso loadWorkorders.Count > 0) Then
                MsgBox("Load has already been created. Please edit from Load page. Load#" & loadWorkorders(0).LoadID)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub eOrSoonerFlag_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles eOrSoonerFlag.EditValueChanging
        If e.OldValue <> e.NewValue Then
            Dim loadWorkorders As New ViewLoadWorkordersCollection
            loadWorkorders.Query.Where(loadWorkorders.Query.Workordernumber = vWorkorderNum)
            If (loadWorkorders.Query.Load() AndAlso loadWorkorders.Count > 0) Then
                MsgBox("Load has already been created. Please edit from Load page. Load#" & loadWorkorders(0).LoadID)
                e.Cancel = True
            End If
        End If
    End Sub
End Class