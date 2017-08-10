Imports AOS.BusinessObjects
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class viewWorkOrders
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oPending As ViewWorkOrderCollection
    Dim oApproved As ViewWorkOrderCollection
    Dim oInProcess As ViewWorkOrdersInProcess2Collection
    Dim oComplete As ViewWorkOrderCollection
    Dim oCancelled As ViewWorkOrderCollection
    Dim oInvoicing As ViewOrdersReadyForInvoiceCollection

#Region " Form Load / Launch Processes "

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getWorkOrders("TIMER")
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' setRibbonOptions(vCurrentUserSecurityLevel)

        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()

        ' setRibbonOptions(vCurrentUserSecurityLevel)
        setRibbonOptionsSecurity(vCurrentUserID)

        ' Call Security Timer to start hiding/showing Groups and Functions based on the security settings 
        StartSecurityTimer()
    End Sub

#End Region

#Region " SECURITY - RIBBON FUNCTIONS "

    Private Sub setRibbonOptions(ByVal vLevel As Integer)
        'used to control visibility of options presented on Ribbon control based on user security level of session
        Dim vPageNum As Integer = 0
        'iterate through the riboon pages and adjust visibility of whole page
        For vPageNum = 0 To Me.RibbonControl1.Pages.Count - 1
            If CInt(Me.RibbonControl1.Pages(vPageNum).Tag) > vLevel Then
                Me.RibbonControl1.Pages(vPageNum).Visible = False
            Else
                Me.RibbonControl1.Pages(vPageNum).Visible = True
                'if page will be visible, then iterate through page groups and adjust visibility of whole group
                Dim grpNum As Integer = 0
                For grpNum = 0 To Me.RibbonControl1.Pages(vPageNum).Groups.Count - 1
                    If CInt(Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Tag) > vLevel Then
                        Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Visible = False
                    Else
                        Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Visible = True
                    End If
                Next
            End If
        Next
        'have to iterate through individual items separately for whole ribbon and adjust visibility
        Dim itemNum As Integer = 0
        For itemNum = 0 To Me.RibbonControl1.Items.Count - 1
            If CInt(Me.RibbonControl1.Items(itemNum).Tag) > vLevel Then
                Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
        Next
    End Sub

    Private Sub setRibbonOptionsSecurity(ByVal vCurrentUserID As Integer)
        'used to control visibility of options presented on Ribbon control based on user security level of session
        Dim vPageNum As Integer = 0

        'FIRST WE CYCLE THROUGH GROUPS/TABS for the user view
        'iterate through the riboon pages and adjust visibility of whole page
        For vPageNum = 0 To Me.RibbonControl1.Pages.Count - 1
            If CInt(Me.RibbonControl1.Pages(vPageNum).Tag) > 0 Then
                '  Me.RibbonControl1.Pages(vPageNum).Visible = False

                'look up this Tag value as the AppGroupID and the Current User ID to determine User Permissions for this Group/Tab option
                Dim oAppUserGroup As New Appusergroup
                oAppUserGroup.Query.Where(oAppUserGroup.Query.Appgroupid.Equal(CInt(Me.RibbonControl1.Pages(vPageNum).Tag)) _
                                          , oAppUserGroup.Query.Appuserid.Equal(vCurrentUserID))
                If oAppUserGroup.Query.Load() Then
                    If oAppUserGroup.Permitted = True Then
                        Me.RibbonControl1.Pages(vPageNum).Visible = True
                    Else
                        Me.RibbonControl1.Pages(vPageNum).Visible = False
                    End If
                Else
                    Me.RibbonControl1.Pages(vPageNum).Visible = False
                End If

            Else
                Me.RibbonControl1.Pages(vPageNum).Visible = True
                'if page will be visible, then iterate through page groups and adjust visibility of whole group
                Dim grpNum As Integer = 0
                For grpNum = 0 To Me.RibbonControl1.Pages(vPageNum).Groups.Count - 1
                    If CInt(Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Tag) > 0 Then

                        'look up this Tag value as the AppGroupID and the Current User ID to determine User Permissions for this Group/Tab option
                        Dim oAppUserGroup As New Appusergroup
                        oAppUserGroup.Query.Where(oAppUserGroup.Query.Appgroupid.Equal(CInt(Me.RibbonControl1.Pages(vPageNum).Tag)) _
                                                  , oAppUserGroup.Query.Appuserid.Equal(vCurrentUserID))
                        If oAppUserGroup.Query.Load() Then
                            If oAppUserGroup.Permitted = True Then
                                Me.RibbonControl1.Pages(vPageNum).Visible = True
                            Else
                                Me.RibbonControl1.Pages(vPageNum).Visible = False
                            End If
                        Else
                            Me.RibbonControl1.Pages(vPageNum).Visible = False
                        End If

                    Else
                        Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Visible = True
                    End If
                Next
            End If
        Next

        'NOW WE CYCLE THROUGH ALL THE FUNCTIONS for the ribbon objects
        'have to iterate through individual items separately for whole ribbon and adjust visibility
        Dim itemNum As Integer = 0
        For itemNum = 0 To Me.RibbonControl1.Items.Count - 1
            If CInt(Me.RibbonControl1.Items(itemNum).Tag) > 0 Then

                'look up this Tag value as the AppGroupID and the Current User ID to determine User Permissions for this Group/Tab option
                Dim oAppUserFunction As New Appuserfunction
                oAppUserFunction.Query.Where(oAppUserFunction.Query.Appfunctionid.Equal(CInt(Me.RibbonControl1.Items(itemNum).Tag)) _
                                             , oAppUserFunction.Query.Appuserid.Equal(vCurrentUserID))
                If oAppUserFunction.Query.Load() Then
                    If oAppUserFunction.Permitted = True Then
                        Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                    Else
                        Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                Else
                    Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                End If

            Else
                Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Always

            End If
        Next


        ' Added the Logic to Hide Ribbon Page Group if all buttons in the Ribbon Page Group are hidden
        Dim mCurrentItem As DevExpress.XtraBars.BarItem
        For Each currentPage As DevExpress.XtraBars.Ribbon.RibbonPage In Me.RibbonControl1.Pages
            For Each currentGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup In currentPage.Groups
                currentGroup.Visible = False
                For Each currenLink As DevExpress.XtraBars.BarItemLink In currentGroup.ItemLinks
                    mCurrentItem = currenLink.Item

                    ' Think about this: In order for the Ribbon Page Group to be visible, we just need to know if...
                    '  at least one item in the group is visible.
                    If (mCurrentItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Always) Then
                        currentGroup.Visible = True
                    End If

                Next currenLink
            Next currentGroup
        Next currentPage

    End Sub

#End Region

#Region " Ribbon Item Processing "

    Private Sub RibbonControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonControl1.SelectedPageChanged
        Dim vNum As Integer

        If RibbonControl1.SelectedPage Is Nothing Then
            Me.Visible = False
            Exit Sub
        Else
            Me.Visible = True
        End If

        If Me.RibbonControl1.SelectedPage.Name = "" Then
            vNum = 1
        Else
            vNum = CInt(Me.RibbonControl1.SelectedPage.Name.Substring(10, 1))
        End If
        Dim ctlPage As New DevExpress.XtraEditors.PanelControl
        ctlPage = Me.WorkPanelsHolder.Controls("RibbonPanelControl" & vNum.ToString)
        If Not ctlPage Is Nothing Then
            ctlPage.BringToFront()
        End If
    End Sub

#End Region

#Region " Data Processing "

    Private Sub getWorkOrders(vStatus As String)
        Select Case vStatus
            Case "COMPLETE"
                oComplete = getViewWorkOrder(vStatus)
                bsCompleteOrders.DataSource = oComplete
            Case "CANCELLED"
                oCancelled = getViewWorkOrder(vStatus)
                bsCanceledOrders.DataSource = oCancelled
            Case Else
                oPending = getViewWorkOrder("PENDING")
                bsPendingOrders.DataSource = oPending
                oApproved = getViewWorkOrder("APPROVED")
                bsApprovedOrders.DataSource = oApproved
                oInProcess = New ViewWorkOrdersInProcess2Collection
                oInProcess.LoadAll()
                bsInProcessOrders.DataSource = oInProcess
                oInvoicing = New ViewOrdersReadyForInvoiceCollection
                oInvoicing.LoadAll()
                bsOrdersReadyForInvoice.DataSource = oInvoicing
        End Select
        'update tabs on ribbon to reflect Work Order totals for each category
        RibbonPage1.Text = bsPendingOrders.Count.ToString & " - Pending"
        RibbonPage2.Text = bsApprovedOrders.Count.ToString & " - Approved"
        RibbonPage3.Text = bsInProcessOrders.Count.ToString & " - Work In Process"
        RibbonPage6.Text = bsOrdersReadyForInvoice.Count.ToString & " - Ready to Invoice"

    End Sub

    Private Sub addWorkOrder()
        Dim frm As New frmAddEditWorkOrders
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getWorkOrders("PENDING")
    End Sub

    Private Sub editWorkOrder(vOrderNum As Integer, vStatus As String)
        Dim frm As New frmAddEditWorkOrders
        frm.vWorkorderNum = vOrderNum
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getWorkOrders(vStatus)
    End Sub

    Private Sub cancelWorkOrder(vWorkOrderNum As Integer, vStatus As String)
        If MsgBox("Are you sure you want to cancel Work Order # " & vWorkOrderNum.ToString & "?", MsgBoxStyle.YesNo, "Confirm Order Cancellation") = MsgBoxResult.No Then
            Exit Sub
        End If

        unallocateWorkOrder(vWorkOrderNum)

        'first, check to see if all workorderitems have been unallocated or production orders and purchase requistions have been removed
        Try
            Dim oItems As WorkorderitemCollection = getAllocatedWorkOrderItems(vWorkOrderNum)
            If (Not oItems Is Nothing And _
              oItems.Count > 0) Then
                'there are items on the workorder that have inventory allocated or production orders created or purchase requistions pending
                MsgBox("You must unallocate all Work Order Items and remove all links to Production Orders and/or Purchase Requisitions before cancelling this Work Order.", MsgBoxStyle.Critical, "ERROR - Can not Cancel Order")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        Try
            'get WorkOrderItems linked to the WorkOrder being cancelled
            Dim oWOItems As WorkorderitemCollection = getWorkOrderItemsByWorkOrderNumber(vWorkOrderNum)
            If (Not oWOItems Is Nothing And _
                oWOItems.Count > 0) Then
                For Each oItem As Workorderitem In oWOItems
                    'find LoadItems linked to this WorkOrderItem rec and delete
                    deleteLoadItems(oItem.Workorderitemnumber, LoadSourceType.WORKORDER.ToString())
                    oItem.Workorderitemstatus = "CANCELLED"
                Next
                oWOItems.Save()
            End If

            'get loads that have items linked to the workorder being cancelled
            'need to get this data collection before the next process deletes the Load Items
            'which link to the workorder

            'Dim oLoads As ViewLoadWorkordersCollection = getLoadWorkordersByWorkOrderNumber(vWorkOrderNum)

            'If (Not oLoads Is Nothing And _
            '  oLoads.Count > 0) Then
            '    'now delete the Load(s) linked to the WorkOrder if there are no more LoadItems in the database
            '    For Each oLoad As ViewLoadWorkorders In oLoads
            '        Dim rLoad As New Load
            '        rLoad.LoadByPrimaryKey(oLoad.LoadID)
            '        Dim rLoadItems As LoaditemCollection = getLoadItemsByLoadID(rLoad.LoadID)
            '        If rLoadItems Is Nothing Then
            '            'there are no LoadItems remaining for this load, so delete the load
            '            rLoad.MarkAsDeleted()
            '            rLoad.Save()
            '        End If
            '    Next
            'End If

        Catch ex As Exception
        End Try

        'finally, mark the workorder record as "CANCELLED"
        Try
            Dim oRec As New Workorder
            If oRec.LoadByPrimaryKey(vWorkOrderNum) Then
                oRec.Orderstatus = "CANCELLED"
                oRec.Modifytime = Now
                oRec.Modifyby = vCurrentUserLogin
                oRec.Save()
            End If
        Catch ex As Exception
        End Try

        getWorkOrders(vStatus)

    End Sub

#End Region

    Private Sub btnGetPendingWorkOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGetPendingWorkOrders.ItemClick
        getWorkOrders("ALL")
    End Sub

    Private Sub btnGetApprovedOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGetApprovedOrders.ItemClick
        getWorkOrders("ALL")
    End Sub

    Private Sub btnGetInProcessWorkOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGetInProcessWorkOrders.ItemClick
        getWorkOrders("ALL")
    End Sub

    Private Sub btnGetCompleteOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGetCompleteOrders.ItemClick
        getWorkOrders("COMPLETE")
    End Sub

    Private Sub btnGetCancelledOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGetCancelledOrders.ItemClick
        getWorkOrders("CANCELLED")
    End Sub

    Private Sub grvInProcess_EndGrouping(sender As Object, e As EventArgs) Handles grvInProcess.EndGrouping
        grvInProcess.ExpandAllGroups()
    End Sub

    Private Sub grvInProcess_GroupRowCollapsing(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowAllowEventArgs) Handles grvInProcess.GroupRowCollapsing
        e.Allow = False
    End Sub

    Private Sub grvInProcess_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grvInProcess.RowStyle
        If (e.RowHandle >= 0) Then

            'Check to see if order is marked as On Hold
            Dim vWO As Integer = grvInProcess.GetRowCellDisplayText(e.RowHandle, grvInProcess.Columns("Workordernumber"))
            Dim vHold As String = grvInProcess.GetRowCellDisplayText(e.RowHandle, grvInProcess.Columns("OnHold"))
            If vHold = "X" Then
                e.Appearance.BackColor = Color.Yellow
                e.Appearance.BackColor2 = Color.Yellow
                e.Appearance.ForeColor = Color.Black
                Exit Sub
            End If

            'Check to see Items expected in after date needed is greater than zero
            Dim vItemsExp As Integer = grvInProcess _
                                    .GetRowCellDisplayText(e.RowHandle, grvInProcess.Columns("Itemsexpectedafterdateneeded"))
            If vItemsExp > 0 Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.Red
                e.Appearance.ForeColor = Color.Black
                Exit Sub
            End If

            'check to see if there are any items on open Purchase Requisitions - EXCLUDE DIRECT WORKORDERS
            Dim vTransportType As String = grvInProcess.GetRowCellDisplayText(e.RowHandle, grvInProcess.Columns("Transporttype"))
            If vTransportType <> "DIRECT" Then
                Dim vPur As Integer = grvInProcess.GetRowCellDisplayText(e.RowHandle, grvInProcess.Columns("OpenReqQty"))
                If vPur > 0 Then
                    e.Appearance.BackColor = Color.Pink
                    e.Appearance.BackColor2 = Color.Pink
                    e.Appearance.ForeColor = Color.Black
                    Exit Sub
                End If

                Dim vPurPending As Integer = grvInProcess.GetRowCellDisplayText(e.RowHandle, grvInProcess.Columns("OpenPurchPendingQty"))
                If vPurPending > 0 Then
                    e.Appearance.BackColor = Color.Pink
                    e.Appearance.BackColor2 = Color.Pink
                    e.Appearance.ForeColor = Color.Black
                    Exit Sub
                End If
            End If

            'check to see if there are any items on open Production Orders
            Dim vProd As Integer = grvInProcess.GetRowCellDisplayText(e.RowHandle, grvInProcess.Columns("OpenProdOrderQty"))
            If vProd > 0 Then
                e.Appearance.BackColor = Color.LightBlue
                e.Appearance.BackColor2 = Color.LightBlue
                e.Appearance.ForeColor = Color.Black
                Exit Sub
            End If

            'check to see if there are any unallocated items on the work order (not on Production orders or Purchase Reqs)
            Dim vAlloc As Integer = grvInProcess.GetRowCellDisplayText(e.RowHandle, grvInProcess.Columns("UnAllocatedQty"))
            If vAlloc > 0 And grvInProcess.GetRowCellDisplayText(e.RowHandle, grvInProcess.Columns("Transporttype")) <> "DIRECT" Then
                e.Appearance.BackColor = Color.LightGreen
                e.Appearance.BackColor2 = Color.LightGreen
                e.Appearance.ForeColor = Color.Black
                Exit Sub
            End If

        End If

    End Sub

    Private Sub btnAddPending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddPending.ItemClick
        addWorkOrder()
    End Sub

    Private Sub btnEditPending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPending.ItemClick
        If bsPendingOrders.Count <= 0 Then
            Exit Sub
        End If
        editWorkOrder(bsPendingOrders.Current.workOrderNumber, "PENDING")
    End Sub

    Private Sub btnCancelPending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelPending.ItemClick
        If bsPendingOrders.Count <= 0 Then
            Exit Sub
        End If
        cancelWorkOrder(bsPendingOrders.Current.workOrderNumber, "PENDING")
    End Sub

    Private Sub btnEditApprovedOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditApprovedOrder.ItemClick
        If bsApprovedOrders.Count <= 0 Then
            Exit Sub
        End If
        editWorkOrder(bsApprovedOrders.Current.workOrderNumber, "APPROVED")
    End Sub

    Private Sub btnCancelApprovedOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelApprovedOrder.ItemClick
        If bsApprovedOrders.Count <= 0 Then
            Exit Sub
        End If
        cancelWorkOrder(bsApprovedOrders.Current.workOrderNumber, "APPROVED")
    End Sub

    Private Sub btnPrintApprovedWorkOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintApprovedWorkOrder.ItemClick
        If bsApprovedOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrder(bsApprovedOrders.Current.workOrderNumber)
    End Sub

    Private Sub btnEditInProcessOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditInProcessOrder.ItemClick
        If bsInProcessOrders.Count <= 0 Then
            Exit Sub
        End If
        editWorkOrder(bsInProcessOrders.Current.workOrderNumber, "IN PROCESS")
    End Sub

    Private Sub btnCancelInProcessOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelInProcessOrder.ItemClick
        If bsInProcessOrders.Count <= 0 Then
            Exit Sub
        End If
        cancelWorkOrder(bsInProcessOrders.Current.workOrderNumber, "IN PROCESS")
    End Sub

    Private Sub btnPrintInProcessOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintInProcessOrder.ItemClick
        If bsInProcessOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrder(bsInProcessOrders.Current.workOrderNumber)
    End Sub

    Private Sub btnMarkApproved_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkApproved.ItemClick
        If bsPendingOrders.Count <= 0 Then
            Exit Sub
        End If

        If (validateWorkOrder(bsPendingOrders.Current.OrderType, bsPendingOrders.Current.TransportType) = False) Then
            Dim oItems As WorkorderitemCollection = getUnallocatedWorkOrderItems(bsPendingOrders.Current.workOrderNumber)

            If (oItems.Count > 0) Then
                MsgBox("The fulfillment plan must be set first before moving the WORKORDER to an approved status.", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
        End If

        If MsgBox("Are you sure you want to mark this WorkOrder as APPROVED?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.Yes Then
            markOrderStatus(bsPendingOrders.Current.workOrderNumber, "APPROVED", False)
            updateSourceStatus(bsPendingOrders.Current.workOrderNumber)
            createINVITEMsProcessWOItemsAndProdOrder(bsPendingOrders.Current.workOrderNumber)
        End If

        getWorkOrders("PENDING")
    End Sub

    Private Sub markOrderStatus(vNum As Integer, vStatus As String, Optional vConfirm As Boolean = True)
        If vConfirm Then
            If MsgBox("Are you sure you want to change the status of the selected Work Order?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Dim oRec As New Workorder
        Try
            If oRec.LoadByPrimaryKey(vNum) Then
                oRec.Orderstatus = vStatus
                oRec.Modifyby = vCurrentUserLogin
                oRec.Modifytime = Now
                oRec.Save()
            End If

            Dim oItems As New WorkorderitemCollection
            oItems.Query.Where(oItems.Query.Workordernumber.Equal(vNum))
            If oItems.Query.Load Then
                For Each oItem As Workorderitem In oItems
                    oItem.Workorderitemstatus = vStatus
                Next
                oItems.Save()
            End If
        Catch ex As Exception
            MsgBox("Error in updating status of selected Work Order", MsgBoxStyle.Critical, "Error")
        End Try


        'Update any shipment data that is linked to this work order
        updateWorkOrderShipmentData(vNum)



        'If oRec.Transporttype <> TransportType.DIRECT.ToString() Then
        '    updateWorkOrderShipmentData(vNum)
        'End If

    End Sub

    Private Sub btnMarkApprovedAsInProcess_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkApprovedAsInProcess.ItemClick
        If bsApprovedOrders.Count <= 0 Then
            Exit Sub
        End If
        If bsApprovedOrders.Current.orderType = "CONSIGNMENT USAGE" Then
            MsgBox("You cannot put an order of this type into IN PROCESS. You can only mark it as Ready to Invoice" _
                   , MsgBoxStyle.Critical _
                   , "Error - Invalid Status Change")
            Exit Sub
        End If
        markOrderStatus(bsApprovedOrders.Current.workOrderNumber, "IN PROCESS")
        updatePurchaseItemsStatus(PurchaseItemSourceType.WORKORDER, bsApprovedOrders.Current.workOrderNumber, _
                                  PurchaseItemsStatus.PENDING.ToString(), _
                                  PurchaseItemsStatus.REQUESTED.ToString())
        getWorkOrders("APPROVED")
    End Sub

    Private Sub btnMarkApprovedAsComplete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        If bsApprovedOrders.Count <= 0 Then
            Exit Sub
        End If
        If bsApprovedOrders.Current.orderType <> "CONSIGNMENT USAGE" Then
            MsgBox("You cannot mark an order of this type as COMPLETE. You can only mark it as IN PROCESS" _
                   , MsgBoxStyle.Critical _
                   , "Error - Invalid Status Change")
            Exit Sub
        End If
        markOrderStatus(bsApprovedOrders.Current.workOrderNumber, "COMPLETE")
        getWorkOrders("APPROVED")
    End Sub

    Private Sub btnMarkInProcessAsApproved_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkInProcessAsApproved.ItemClick
        If bsInProcessOrders.Count <= 0 Then
            Exit Sub
        End If
        markOrderStatus(bsInProcessOrders.Current.workOrderNumber, "APPROVED")
        getWorkOrders("IN PROCESS")
    End Sub

    Private Sub btnMarkInProcessOrderAsComplete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkInProcessOrderAsComplete.ItemClick
        If bsInProcessOrders.Count <= 0 Then
            Exit Sub
        End If
        markOrderStatus(bsInProcessOrders.Current.workOrderNumber, "COMPLETE")
        getWorkOrders("IN PROCESS")
    End Sub


    Private Sub rbtnEditCompleteOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditCompleteOrder.ItemClick
        If bsCompleteOrders.Count <= 0 Then
            Exit Sub
        End If
        editWorkOrder(bsCompleteOrders.Current.workOrderNumber, "COMPLETE")
    End Sub

    Private Sub rbtnRetrieveOrdersForInvoicing_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveOrdersForInvoicing.ItemClick
        getWorkOrders("ALL")
    End Sub

    'Private Function getLoadIDByWorkOrderNumber(vWONum As Integer) As Integer
    '    If IsDBNull(vWONum) Then
    '        Return 0
    '    End If

    '    Dim vLoadWorkOrders As New ViewLoadWorkordersCollection
    '    vLoadWorkOrders.Query.Where(vLoadWorkOrders.Query.Workordernumber.Equal(vWONum))
    '    If vLoadWorkOrders.Query.Load Then
    '        Return vLoadWorkOrders(0).LoadID
    '    Else
    '        Return 0
    '    End If

    'End Function

    Private Sub rbtnCreateInvoiceFromWorkOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCreateInvoiceFromWorkOrder.ItemClick
        If bsOrdersReadyForInvoice.Count <= 0 Then
            Exit Sub
        End If

        CreateInvoiceFromWorkorder(bsOrdersReadyForInvoice.Current.workOrderNumber)         'see INVOICEPROCESSING class module for code

        ''set some variables
        'Dim vOrd As Integer = bsOrdersReadyForInvoice.Current.WorkOrderNumber
        'Dim vLoad As Integer = getLoadIDByWorkOrderNumber(vOrd)

        ''first, create invoice records
        ''this will update workorder and workorderitem records as COMPLETE
        'Dim vInvoiceNum As Integer = createInvoice(vOrd, vLoad)
        'If vInvoiceNum <= 0 Then
        '    MsgBox("Error in creating invoice", MsgBoxStyle.Critical, "ERROR - Invoice not created")
        '    Exit Sub
        'End If
        ''at this point we have an new invoice created

        ''second, display invoice for editing, capture the form dialog results (SAVE OR CANCEL) for next steps.
        'Dim frm As New frmAddEditInvoice
        'frm.vInvoiceNum = vInvoiceNum
        'frm.vEditType = "EDIT"
        'Dim vResult As DialogResult = frm.ShowDialog()
        'Select Case vResult
        '    Case DialogResult.OK
        '        'if saved, workorder and workorderitem records are okay as COMPLETE; update load to DELIVERED
        '        Dim oLoad As New Load
        '        If oLoad.LoadByPrimaryKey(vLoad) Then
        '            oLoad.LoadStatus = "DELIVERED"
        '            oLoad.Save()
        '        End If
        '    Case DialogResult.Cancel
        '        'if cancelled, delete invoice record and reset workorder and workorderitems to INVOICE, leave load in IN TRANSIT
        '        markOrderStatus(vOrd, "INVOICE", False)
        '        'remove any invoice reference from WorkOrderItem records for this workorder
        '        removeInvoiceReferenceDataFromWorkOrder(vOrd)
        '        removeInvoiceReferenceDataFromLoadBilling(vLoad)
        '        If Not deleteInvoice(vInvoiceNum) Then
        '            MsgBox("Error in deleting the Invoice from the database. See Data Administrator", MsgBoxStyle.Critical, "Error - Invoice Not Deleted")
        '        End If

        'End Select

    End Sub

    'Private Sub removeInvoiceReferenceDataFromLoadBilling(vID As Integer)
    '    Try
    '        Dim oBillings As LoadbillingCollection
    '        oBillings = New LoadbillingCollection
    '        oBillings.Query.Where(oBillings.Query.Loadid.Equal(vID))
    '        If oBillings.Query.Load Then
    '            For Each oBill As Loadbilling In oBillings
    '                oBill.InvoiceNumber = 0
    '                oBill.Status = "PENDING"
    '            Next
    '            oBillings.Save()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    'Private Sub removeInvoiceReferenceDataFromWorkOrder(vID As Integer)
    '    Try
    '        Dim oItems As WorkorderitemCollection
    '        oItems = New WorkorderitemCollection
    '        oItems.Query.Where(oItems.Query.Workordernumber.Equal(vID))
    '        If oItems.Query.Load Then
    '            For Each oItemList As Workorderitem In oItems
    '                oItemList.Invoiceitemnumber = 0
    '            Next
    '        End If
    '        oItems.Save()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Private Sub rbtnCompleteWorkorder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCompleteWorkorder.ItemClick
        If bsOrdersReadyForInvoice.Count <= 0 Then
            Exit Sub
        End If
        markOrderStatus(bsOrdersReadyForInvoice.Current.workOrderNumber, "COMPLETE")
        getWorkOrders("INVOICE")
    End Sub

    Private Sub StartSecurityTimer()
        Dim oSecurityTimer As Integer = 0
        Dim oAppUser As New Appuser
        If oAppUser.LoadByPrimaryKey(vCurrentUserID) Then
            oSecurityTimer = oAppUser.Securitytimer
            Timer2.Enabled = True
            Timer2.Interval = oSecurityTimer
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        ' Adding this code here so that the Timer will also check the Security Timer from the Database
        Dim oSecurityTimer As Integer = 0
        Dim oAppUser As New Appuser
        If oAppUser.LoadByPrimaryKey(vCurrentUserID) Then
            oSecurityTimer = oAppUser.Securitytimer
            Timer2.Interval = oSecurityTimer
        End If

        setRibbonOptionsSecurity(vCurrentUserID)
    End Sub

    Private Sub btnApprovedMarkReadyToInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnApprovedMarkReadyToInvoice.ItemClick
        If bsApprovedOrders.Count <= 0 Then
            Exit Sub
        End If
        If bsApprovedOrders.Current.orderType <> "CONSIGNMENT USAGE" Then
            MsgBox("You cannot mark an order of this type as READY TO INVOICE. You can only mark it as In Process or Cancelled" _
                   , MsgBoxStyle.Critical _
                   , "Error - Invalid Status Change")
            Exit Sub
        End If
        markOrderStatus(bsApprovedOrders.Current.workOrderNumber, "INVOICE")
        getWorkOrders("APPROVED")
    End Sub

    Private Sub btnPrintPendingWorkOrderReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPendingWorkOrderReport.ItemClick
        If bsPendingOrders.Count <= 0 Then
            Exit Sub
        End If
        printFulfillmentPlan(bsPendingOrders.Current.workOrderNumber)
    End Sub

    Private Sub btnPrintApprovedWorkOrderReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintApprovedWorkOrderReport.ItemClick
        If bsApprovedOrders.Count <= 0 Then
            Exit Sub
        End If
        printFulfillmentPlan(bsApprovedOrders.Current.workOrderNumber)
    End Sub

    Private Sub btnPrintInProcessWorkOrderReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintInProcessWorkOrderReport.ItemClick
        If bsInProcessOrders.Count <= 0 Then
            Exit Sub
        End If
        printFulfillmentPlan(bsInProcessOrders.Current.workOrderNumber)
    End Sub

    Private Sub printFulfillmentPlan(vWorkOrderNumber As Integer)
        Dim rpt As New rptFulfillmentPlan(vWorkOrderNumber)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnPrintApprovedWorkOrderDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintApprovedWorkOrderDocs.ItemClick
        If bsApprovedOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrderAndSourceOrders(bsApprovedOrders.Current.workOrderNumber)
    End Sub

    Private Sub btnPrintInProcessOrderDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintInProcessOrderDocs.ItemClick
        If bsInProcessOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrderAndSourceOrders(bsInProcessOrders.Current.workOrderNumber)
    End Sub

    Private Sub rbtnPrintReadytoInvoiceWorkorderDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintReadytoInvoiceWorkorderDocs.ItemClick
        If bsOrdersReadyForInvoice.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrderAndSourceOrders(bsOrdersReadyForInvoice.Current.workOrderNumber)
    End Sub

    Private Sub btnPrintPendingWorkOrderDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPendingWorkOrderDocs.ItemClick
        If bsPendingOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrderAndSourceOrders(bsPendingOrders.Current.workOrderNumber)
    End Sub

    Private Sub btnPrintPendingWorkOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPendingWorkOrder.ItemClick
        If bsPendingOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrder(bsPendingOrders.Current.workOrderNumber)
    End Sub

    Private Sub rbtnPrintReadytoInvoiceWorkorder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintReadytoInvoiceWorkorder.ItemClick
        If bsOrdersReadyForInvoice.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrder(bsOrdersReadyForInvoice.Current.workOrderNumber)
    End Sub

    Private Sub rbtnPrintCompleteWorkorder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintCompleteWorkorder.ItemClick
        If bsCompleteOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrder(bsCompleteOrders.Current.workOrderNumber)
    End Sub

    Private Sub rbtnPrintCompleteWorkorderDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintCompleteWorkorderDocs.ItemClick
        If bsCompleteOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrderAndSourceOrders(bsCompleteOrders.Current.workOrderNumber)
    End Sub

    Private Sub rbtnPrintCanceledWorkorder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintCanceledWorkorder.ItemClick
        If bsCanceledOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrder(bsCanceledOrders.Current.workOrderNumber)
    End Sub

    Private Sub rbtnPrintCanceledWorkorderDocs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintCanceledWorkorderDocs.ItemClick
        If bsCanceledOrders.Count <= 0 Then
            Exit Sub
        End If
        printWorkOrderAndSourceOrders(bsCanceledOrders.Current.workOrderNumber)
    End Sub


End Class
