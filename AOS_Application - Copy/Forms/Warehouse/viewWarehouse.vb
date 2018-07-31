Imports AOS.BusinessObjects

Public Class viewWarehouse
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

#Region " Form Load / Launch Processes "

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadPurchaseOrderList()
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        RibbonPage1.Visible = False
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
                oAppUserGroup.Query.Where(oAppUserGroup.Query.Appgroupid.Equal(CInt(Me.RibbonControl1.Pages(vPageNum).Tag)), oAppUserGroup.Query.Appuserid.Equal(vCurrentUserID))
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
                        oAppUserGroup.Query.Where(oAppUserGroup.Query.Appgroupid.Equal(CInt(Me.RibbonControl1.Pages(vPageNum).Tag)), oAppUserGroup.Query.Appuserid.Equal(vCurrentUserID))
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
                oAppUserFunction.Query.Where(oAppUserFunction.Query.Appfunctionid.Equal(CInt(Me.RibbonControl1.Items(itemNum).Tag)), oAppUserFunction.Query.Appuserid.Equal(vCurrentUserID))
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
            vNum = 2
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


#End Region


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


    Private Sub loadPurchaseOrderList()
        bsPurchaseOrder.DataSource = getPurchaseOrderList(PurchaseItemType.REGULAR.ToString(), PurchaseItemsStatus.ORDERED.ToString())
    End Sub

    Private Sub loadPurchaseItemList()
        bsPurchaseItem.DataSource = getPurchaseItemsByPurchaseNumber(bsPurchaseOrder.Current.Purchasenumber, "", "PURCHASEITEMSTATUS DESC", PurchaseItemsStatus.CANCELLED.ToString())
    End Sub

    Private Sub grvPurchaseOrder_RowClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
        loadPurchaseItemList()
    End Sub

    Private Sub btnRetrievePurchOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRetrievePurchOrders.ItemClick
        loadPurchaseOrderList()
    End Sub

    Private Sub grvPurchaseOrder_DoubleClick(sender As Object, e As EventArgs) Handles grvPurchaseOrder.DoubleClick
        LoadReceivingInventory()
    End Sub

    Private Sub LoadReceivingInventory()
        If bsPurchaseOrder.Count > 0 Then
            Using frm As New frmReceivingPurchase() With
               {
                       .vPurchaseNumber = bsPurchaseOrder.Current.Purchasenumber
               }
                If frm.ShowDialog() Then
                    loadPurchaseOrderList()
                End If
            End Using
        End If
    End Sub

    Private Sub btnReceiveOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceiveOrder.ItemClick
        LoadReceivingInventory()
    End Sub

    Private Sub rbtnOpenRelabelOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnOpenRelabelOrders.ItemClick
        getRelabelOrders("OPEN")
    End Sub

    Private Sub getRelabelOrders(vCategory As String)
        Dim oRlblOrders As New ViewRelabelOrderCollection
        Select Case vCategory
            Case "OPEN"
                oRlblOrders.Query.Where(oRlblOrders.Query.Relabelorderstatus.Equal("INPROD"))
            Case "ALL"
                'the default settings for oRlbOrders should pull ALL orders, regardless of status
        End Select
        Try
            oRlblOrders.Query.Load()
            bsRelabelOrders.DataSource = oRlblOrders
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub rbtnProcessRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnProcessRelabelOrder.ItemClick
        If bsRelabelOrders.Count <= 0 Then
            Exit Sub
        End If
        If bsRelabelOrders.Current.RelabelOrderStatus <> "INPROD" Then
            MsgBox("The selected Relabel Order is no longer IN PRODUCTION. There is nothing to process.", MsgBoxStyle.Critical, "ERROR")
            Exit Sub
        End If
        Dim frm As New frmProcessRelabelOrder
        frm.vRelabelOrderNumber = bsRelabelOrders.Current.RelabelOrderNumber
        frm.ShowDialog()
        getRelabelOrders("OPEN")
    End Sub

    Private Sub rbtnAllRelabelOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAllRelabelOrders.ItemClick
        getRelabelOrders("ALL")
    End Sub

    Private Sub rbtnReceivedHold_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReceivedHold.ItemClick
        Dim frm As New frmReceiveHoldList
        frm.ShowDialog()
    End Sub

    Private Sub rbtnAddNewReceiverItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewReceiverItem.ItemClick
        Dim frm As New frmAddNewReceiverItem
        frm.ShowDialog()
    End Sub

    Private Sub rbtnReceivingHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReceivingHistory.ItemClick
        Dim frm As New frmReceivingHistory
        frm.ShowDialog()
    End Sub

    Private Sub rbtnPrintProductList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintProductList.ItemClick
        If bsPurchaseOrder.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptPOList3(bsPurchaseOrder.Current.Purchasenumber)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rbtnCloseOutPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCloseOutPO.ItemClick
        If bsPurchaseOrder.Count <= 0 Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to close the selected Purchase Order?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        'first make sure there are no PENDING inventory items
        Dim oItems As New ViewPendingInventoryItemsCollection
        oItems.Query.Where(oItems.Query.Purchasenumber.Equal(bsPurchaseOrder.Current.PurchaseNumber))
        If oItems.Query.Load() Then
            'Pending inventory Items found for the selected Purchase Order - cannot close out PO
            MsgBox("Error - There are still open/pending Inventory Items linked to the selected Purchase Order. You cannot close it out at this time.", MsgBoxStyle.Critical, "Open Items Remaining")
            Exit Sub
        End If

        'At this point, we can close the PO and mark all PurchaseItems as RECEIVED that are currently marked as ON ORDER
        Dim oPItems As New PurchaseitemCollection
        oPItems.Query.Where(oPItems.Query.Purchasenumber.Equal(bsPurchaseOrder.Current.Purchasenumber))
        oPItems.Query.Load()
        For Each obj As Purchaseitem In oPItems
            If obj.Purchaseitemstatus = "ORDERED" Then obj.Purchaseitemstatus = "RECEIVED"
        Next
        oPItems.Save()

        Dim oPrch As New Purchase
        If oPrch.LoadByPrimaryKey(bsPurchaseOrder.Current.PurchaseNumber) Then
            oPrch.Purchasestatus = "COMPLETED"
            oPrch.Save()
        End If

        loadPurchaseOrderList()

    End Sub
End Class
