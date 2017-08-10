Imports AOS.BusinessObjects
Imports AOS.PurchaseProcessing
Imports System.Text

Public Class viewPurchasing2
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oVendors As VendorCollection = Nothing
    Dim vItemStatus As String = PurchaseItemsStatus.REQUESTED.ToString()
    Dim vPurchaseStatus As String = PurchaseStatus.PENDING.ToString()
    Dim vSelectedVendorName As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadVendors()
        loadVendorList()
        refreshPurchaseOrders(vPurchaseStatus)
        refreshMonitorGrids()
    End Sub




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





    Private Sub RibbonControl1_SelectedPageChanged(sender As Object, e As EventArgs) Handles RibbonControl1.SelectedPageChanged
        Dim vNum As Integer
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

    Private Sub viewPurchasing2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()
        ' setRibbonOptions(vCurrentUserSecurityLevel)
        setRibbonOptionsSecurity(vCurrentUserID)
        ' Call Security Timer to start hiding/showing Groups and Functions based on the security settings 
        StartSecurityTimer()
        refreshTab(PurchaseItemsStatus.REQUESTED.ToString())
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

    Private Function getPurchaseItemsList(vPurchaseItemStatus As String) As ViewPurchaseItems2Collection

        Dim vOption As getPurchaseItemOptions
        Dim oSortBy As String = "Dateneeded, Itemid"
        Select Case vPurchaseItemStatus
            Case PurchaseItemsStatus.RCVDHOLD.ToString()
                vOption = getPurchaseItemOptions.AllItems
            Case ""
                vOption = getPurchaseItemOptions.AllItems
            Case PurchaseItemsStatus.ORDERED.ToString()
                Dim oStatus As New StringBuilder()
                oStatus.AppendFormat("{0}','{1}','{2}", _
                    PurchaseItemsStatus.ORDERED.ToString(), _
                    PurchaseItemsStatus.RECEIVED.ToString(), _
                    PurchaseItemsStatus.FULFILLED.ToString())
                vPurchaseItemStatus = oStatus.ToString()
                vOption = getPurchaseItemOptions.OnlyOrderedItems
                oSortBy = "Purchasenumber ASC"
            Case Else
                vOption = getPurchaseItemOptions.OnlyUnorderedItems
        End Select

        '"ON ORDER" is not Purchase item status. We need to pass empty.
        Return getPurchaseItems(vPurchaseItemStatus, oSortBy, vOption)
    End Function

    Private Sub setTabHeading(vPurchaseItemStatus As String)
        Dim vStatus As String = StrConv(vPurchaseItemStatus, _
                                        VbStrConv.ProperCase)

        RibbonPage1.Text = String.Format("{0} - Items {1}", bsPurchaseItems.Count, vStatus)
    End Sub

    Private Sub refreshTab(vPurchaseItemStatus As String)
        'Dim oPurchaseItemList As ViewPurchaseItems2Collection = getPurchaseItemsList(vPurchaseItemStatus)
        Dim oPurchaseItemList As ViewPurchaseItems2Collection = getPurchaseItemRecords(vPurchaseItemStatus)
        bsPurchaseItems.DataSource = oPurchaseItemList
        setTabHeading(vPurchaseItemStatus)
        setPurchaseItemOptions()
    End Sub

    Private Sub grvPurchaseItems_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grvPurchaseItems.RowCellClick
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
        refreshPurchaseOrders(vPurchaseStatus)
        refreshTab(vItemStatus)
    End Sub

    Private Sub grvPurchaseItems_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grvPurchaseItems.RowStyle
        If (e.RowHandle >= 0) Then

            Dim strDateNeeded As String = ""
            Dim strToday As String = Now.ToShortDateString
            Dim vDateNeeded As Date
            Dim vToday As Date = Convert.ToDateTime(strToday)

            If Not String.IsNullOrEmpty(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Dateneeded"))) Then
                strDateNeeded = grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Dateneeded"))
                vDateNeeded = Convert.ToDateTime(strDateNeeded)
                If vDateNeeded < vToday Then
                    e.Appearance.BackColor = Color.Pink
                    e.Appearance.BackColor2 = Color.Pink
                    e.Appearance.ForeColor = Color.Black
                    Exit Sub
                End If
            End If


            'If Not String.IsNullOrEmpty(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Dateneeded"))) Then
            '    If Convert.ToDateTime(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Dateneeded"))) < Now.Date Then
            '        e.Appearance.BackColor = Color.Pink
            '        e.Appearance.BackColor2 = Color.Pink
            '        e.Appearance.ForeColor = Color.Black
            '        Exit Sub
            '    End If
            'End If

            Dim strExpectedIn As String = ""
            Dim vExpectedIn As Date

            If Not String.IsNullOrEmpty(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Expectedindate"))) Then
                strExpectedIn = grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Expectedindate"))
                vExpectedIn = Convert.ToDateTime(strExpectedIn)
                If Not String.IsNullOrEmpty(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Dateneeded"))) Then
                    strDateNeeded = grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Dateneeded"))
                    vDateNeeded = Convert.ToDateTime(strDateNeeded)
                    If vExpectedIn > vDateNeeded Then
                        e.Appearance.BackColor = Color.Red
                        e.Appearance.BackColor2 = Color.Red
                        e.Appearance.ForeColor = Color.White
                        Exit Sub
                    End If
                End If
            End If


            'If Not String.IsNullOrEmpty(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Expectedindate"))) Then
            '    If Convert.ToDateTime(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Expectedindate"))) > _
            '    Convert.ToDateTime(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Dateneeded"))) Then
            '        e.Appearance.BackColor = Color.Red
            '        e.Appearance.BackColor2 = Color.Red
            '        e.Appearance.ForeColor = Color.White
            '        Exit Sub
            '    End If
            'End If

            If String.IsNullOrEmpty(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Vendorname"))) Or
                (String.IsNullOrEmpty(grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Unitcost"))) OrElse
                 grvPurchaseItems.GetRowCellDisplayText(e.RowHandle, grvPurchaseItems.Columns("Unitcost")) = 0) Then

                e.Appearance.BackColor = Color.Yellow
                e.Appearance.BackColor2 = Color.Yellow
                e.Appearance.ForeColor = Color.Black

                Exit Sub
            End If

        End If
    End Sub

    Private Sub btnAddPurchaseItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddPurchaseItem.ItemClick
        Using frm As New frmAddEditPurchaseItem() With
        {
            .vEditType = "ADD"
        }
            frm.ShowDialog()
        End Using
        refreshTab(vItemStatus)
    End Sub

    Private Sub btnEditPurchaseItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPurchaseItem.ItemClick
        If IsNothing(bsPurchaseItems.Current) Then
            Exit Sub
        End If
        Using frm As New frmAddEditPurchaseItem() With
        {
            .vID = bsPurchaseItems.Current.PURCHASEITEMID,
            .vEditType = "EDIT"
        }
            frm.ShowDialog()
        End Using

        refreshTab(vItemStatus)
    End Sub

    Private Sub btnSplitPurchaseItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSplitPurchaseItem.ItemClick
        If IsNothing(bsPurchaseItems.Current) Then
            Exit Sub
        End If
        If bsPurchaseItems.Current.Qty > 1 Then
            Using frm As New frmSplitPurchaseItem() With
             {
                 .vID = bsPurchaseItems.Current.PURCHASEITEMID
             }
                frm.ShowDialog()
            End Using
            refreshTab(vItemStatus)
        Else
            Dim vMsg As String = String.Format("Selected Purchase Item cannot be split because quantity is {0}", Convert.ToInt32(bsPurchaseItems.Current.Qty))
            MsgBox(vMsg, MsgBoxStyle.Critical, "Split Item")
        End If
    End Sub

    Private Sub btnRequested_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRequested.ItemClick
        vItemStatus = PurchaseItemsStatus.REQUESTED.ToString()
        refreshTab(vItemStatus)
    End Sub

    Private Sub btnAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAll.ItemClick
        vItemStatus = "ALL"
        refreshTab(vItemStatus)
    End Sub

    Private Sub btnCreatePurchaseOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreatePurchaseOrder.ItemClick
        Dim vCommaSeparatedPurchaseItemIds As String
        vCommaSeparatedPurchaseItemIds = getSelectedPurchaseItemIds()

        If String.IsNullOrEmpty(vCommaSeparatedPurchaseItemIds) Then
            Exit Sub
        End If

        Using frm As New frmAddEditPO() With
            {
                .vEditType = "ADD",
                .vCommaSeparatedPurchaseItemIds = vCommaSeparatedPurchaseItemIds
            }
            frm.ShowDialog()
        End Using
        refreshTab(vItemStatus)
        refreshPurchaseOrders(PurchaseStatus.PENDING.ToString())
    End Sub

    Private Function ValidateSelectedItem(vVendor As String, vUnitCost As Decimal, vPurchaseNumber As String) As Boolean
        'Check if Purchase Number is popualted
        If String.IsNullOrEmpty(vPurchaseNumber) = False Then
            MsgBox("One of the selected Purchase Item is already on order.", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        'Check that vendor and cost fields are filled
        If String.IsNullOrEmpty(vVendor) Or vUnitCost = 0 Then
            MsgBox("Vendor and cost should be filled in for the selected purchase items.", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        'Check that all rows have the same vendor
        If (Not String.IsNullOrEmpty(vSelectedVendorName)) And vVendor <> vSelectedVendorName Then
            MsgBox("Vendor should be same for the selected purchase items.", MsgBoxStyle.Critical, "Error")
            Return False
        Else
            vSelectedVendorName = vVendor
        End If

        Return True
    End Function

    Private Sub loadVendorList()
        Dim oVendorList As New VendorCollection
        oVendorList = getVendorCollection()
        bsVendorList.DataSource = oVendorList
    End Sub

    Private Sub refreshPurchaseOrders(ByVal vStatus As String)
        vPurchaseStatus = vStatus
        btnApprovePurchase.Enabled = IIf((vStatus = PurchaseStatus.PENDING.ToString()), True, False)

        Dim oPurchaseOrders As New ViewPurchaseOrdersCollection
        oPurchaseOrders = getViewPurchaseOrders(vStatus)
        bsPOs.DataSource = oPurchaseOrders
        btnCancelPurchase.Enabled = checkActivePurchaseOrder()
    End Sub

    Private Sub btnPendingOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPendingOrders.ItemClick
        refreshPurchaseOrders(PurchaseStatus.PENDING.ToString())
    End Sub

    Private Sub btnEditPurchase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPurchase.ItemClick
        If bsPOs.Count <= 0 Then
            Exit Sub
        End If
        Using frm As New frmAddEditPO() With
            {
                .vEditType = "EDIT",
                .vPurchaseNumber = bsPOs.Current.Purchasenumber
            }
            frm.ShowDialog()
        End Using
        refreshPurchaseOrders(vPurchaseStatus)
    End Sub

    Private Sub btnCancelPurchase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelPurchase.ItemClick
        If bsPOs.Count <= 0 Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to cancel the selected Purchase Order?",
                  MsgBoxStyle.YesNo,
                  "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        If bsPOs.Current.Purchasestatus = PurchaseStatus.PENDING.ToString() OrElse _
            bsPOs.Current.Purchasestatus = PurchaseStatus.ORDERED.ToString() Then

            'Dim oPrchItems As New PurchaseitemCollection
            'oPrchItems.Query.Where(oPrchItems.Query.Purchasenumber.Equal(bsPOs.Current.PurchaseNumber), oPrchItems.Query.Sourcetype.IsNotNull)
            'If oPrchItems.Query.Load() Then
            '    If oPrchItems.Count > 0 Then
            '        If MsgBox("Please Note: This Purchase Order contains purchase items linked to WorkOrder or Relabel Orders. These items will be returned to a REQUESTED status upon cancelling this Purchase Order. Are you sure you want to cancel the selected Purchase Order?",
            '      MsgBoxStyle.YesNo,
            '      "Confirm") = MsgBoxResult.No Then
            '            Exit Sub
            '        End If
            '    End If
            '    'return all linked Purchase Items to a REQUESTED status
            '    For Each oItemList As Purchaseitem In oPrchItems
            '        oItemList.Purchaseitemstatus = "REQUESTED"
            '        oItemList.Purchasenumber = Nothing
            '        oItemList.Expectedindate = Nothing
            '    Next
            '    oPrchItems.Save()
            'End If

            'oPrchItems = New PurchaseitemCollection
            'oPrchItems.Query.Where(oPrchItems.Query.Purchasenumber.Equal(bsPOs.Current.PurchaseNumber))
            'If oPrchItems.Query.Load() Then
            '    For Each oItemList As Purchaseitem In oPrchItems
            '        oItemList.Purchaseitemstatus = "CANCELLED"
            '    Next
            '    oPrchItems.Save()
            'End If

            'updatePurchaseOrderStatus(bsPOs.Current.Purchasenumber, PurchaseStatus.CANCELLED.ToString())


            Dim oPurchaseitems As New PurchaseitemCollection
            Dim oREQUESTEDPurchaseitems As New PurchaseitemCollection
            oPurchaseitems = getPurchaseItemsByPurchaseNumber(bsPOs.Current.Purchasenumber)
            oREQUESTEDPurchaseitems = getPurchaseItemsByPurchaseNumber(bsPOs.Current.Purchasenumber, PurchaseItemsStatus.REQUESTED.ToString())

            If oPurchaseitems Is Nothing = False AndAlso
                oREQUESTEDPurchaseitems Is Nothing = False Then
                If oPurchaseitems.Count = oREQUESTEDPurchaseitems.Count Then
                    If MsgBox("Please note that the any Purchase Items not received yet will be changed to the requested status. This action cannot be undone. Please confirm to proceed.",
                              MsgBoxStyle.OkCancel, "Purchase Orders") = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If
                End If
            End If

            oPurchaseitems = getNonReceivedPurchasedFulfilledPurchaseItems(bsPOs.Current.Purchasenumber)
            removePurchaseItems(oPurchaseitems)

            updatePurchaseOrderStatus(bsPOs.Current.Purchasenumber, PurchaseStatus.CANCELLED.ToString())

        End If
        refreshPurchaseOrders(vPurchaseStatus)
    End Sub

    Private Sub btnPrintPurchaseOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPurchaseOrder.ItemClick
        printPO()
    End Sub

    Private Sub printPO()
        If bsPOs.Count <= 0 Then
            Exit Sub
        End If
        printPurchaseOrder(bsPOs.Current.Purchasenumber)
    End Sub



#Region "Vendor"

    Private Sub loadVendors()
        oVendors = New VendorCollection
        oVendors.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oVendors.LoadAll()
        oVendors.Filter = ""
        oVendors.Sort = "VENDORNAME ASC"
        bsVendors.DataSource = oVendors
        Me.grVendors.DataSource = bsVendors
        Me.grVendors.Refresh()
        If oVendors.Count <= 0 Then
            btnEditVendor.Enabled = False
            btnDeleteVendor.Enabled = False
        Else
            btnEditVendor.Enabled = True
            btnDeleteVendor.Enabled = True
        End If
    End Sub

    Private Sub editVendor()
        If bsVendors.Count <= 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditVendor
        frm.vID = Me.bsVendors.Current.VendorID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadVendors()
    End Sub

    Private Sub addVendor()
        Dim frm As New frmAddEditVendor
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        vResult = frm.ShowDialog()
        loadVendors()
    End Sub

    Private Sub deleteVendor()
        If bsVendors.Count <= 0 Then
            Exit Sub
        End If
        Dim str As String
        str = "Are you sure you want to delete " & bsVendors.Current.VendorName & "?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Dim oVendor As Vendor
            oVendor = New Vendor
            oVendor.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            oVendor.LoadByPrimaryKey(bsVendors.Current.VendorID)
            oVendor.MarkAsDeleted()
            oVendor.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        loadVendors()
    End Sub

    Private Sub btnAddVendor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddVendor.ItemClick
        addVendor()
    End Sub

    Private Sub btnDeleteVendor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteVendor.ItemClick
        deleteVendor()
    End Sub

    Private Sub btnEditVendor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditVendor.ItemClick
        editVendor()
    End Sub

#End Region
    Private Sub btnReceivedHold_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReceivedHold.ItemClick
        vItemStatus = PurchaseItemsStatus.RECEIVED.ToString()
        refreshTab(vItemStatus)
    End Sub

    Private Sub grvPurchaseOrders_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grvPurchaseOrders.RowStyle
        If (e.RowHandle >= 0) Then
            If (vPurchaseStatus = PurchaseStatus.ORDERED.ToString() And _
            (Not String.IsNullOrEmpty(grvPurchaseOrders.GetRowCellDisplayText(e.RowHandle, grvPurchaseOrders.Columns("Expectedindate"))))) Then
                If Convert.ToDateTime(grvPurchaseOrders.GetRowCellDisplayText(e.RowHandle, grvPurchaseOrders.Columns("Expectedindate"))) < Now.Date Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.BackColor2 = Color.Red
                    e.Appearance.ForeColor = Color.White
                    Exit Sub
                End If
            End If
            Dim vLateItemCount As Integer = grvPurchaseOrders.GetRowCellDisplayText(e.RowHandle, grvPurchaseOrders.Columns("Itemsexpectedafterdateneeded"))
            If vLateItemCount > 0 Then
                If vPurchaseStatus = "ORDERED" Then
                    e.Appearance.BackColor = Color.Red
                    e.Appearance.BackColor2 = Color.Red
                    e.Appearance.ForeColor = Color.White
                End If
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnOrdered_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOrdered.ItemClick
        vItemStatus = PurchaseItemsStatus.ORDERED.ToString()
        refreshTab(vItemStatus)
    End Sub

    Private Sub btnApprovePurchase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnApprovePurchase.ItemClick
        If bsPOs.Count <= 0 Then
            Exit Sub
        End If
        'If MessageBox.Show("Approving purchase order cannot be undone. Are you sure you want to approve the purchase order?", "Confirm Approval", _
        '    MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
        '    Exit Sub
        'End If
        approvePurchaseOrder(bsPOs.Current.Purchasenumber)
        refreshPurchaseOrders(vPurchaseStatus)
    End Sub

    Private Sub btnMaterialNeeds_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMaterialNeeds.ItemClick
        Using frm As New frmMaterialNeeds()
            frm.ShowDialog()
        End Using
        refreshTab(vItemStatus)
    End Sub

    Private Sub btnByVendor_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnByVendor.ItemClick
        'Grouping based on Vendor
        grvPurchaseItems.Columns("Vendorname").GroupIndex = 0
        grvPurchaseItems.Columns("Dateneeded").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
    End Sub

    Private Sub btnByItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnByItem.ItemClick
        'Remove grouping
        grvPurchaseItems.Columns("Vendorname").GroupIndex = -1
        grvPurchaseItems.Columns("Dateneeded").SortOrder = 0
    End Sub

    Private Sub grvInProcess_EndGrouping(sender As Object, e As EventArgs) Handles grvPurchaseItems.EndGrouping
        grvPurchaseItems.ExpandAllGroups()
    End Sub

    Private Sub btnCancelledOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelledOrders.ItemClick
        refreshPurchaseOrders(PurchaseStatus.CANCELLED.ToString())
    End Sub

    Private Sub btnAllOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAllOrders.ItemClick
        refreshPurchaseOrders("")
    End Sub

    Private Sub btnCompletedOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCompletedOrders.ItemClick
        refreshPurchaseOrders(PurchaseStatus.COMPLETED.ToString())
    End Sub

    Private Sub btnOrderedOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOrderedOrders.ItemClick
        refreshPurchaseOrders(PurchaseStatus.ORDERED.ToString())
    End Sub

    Private Sub btnAddPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddPO.ItemClick
        Dim frm As New frmAddEditPO()

        frm.vEditType = "ADD"
        frm.ShowDialog()
        refreshPurchaseOrders(vPurchaseStatus)
    End Sub

    Private Sub btnPrintItemList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintItemList.ItemClick
        If bsPOs.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptPOList3(bsPOs.Current.Purchasenumber)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub btnAddToExistingPO_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddToExistingPO.ItemClick
        Dim vCommaSeparatedPurchaseItemIds As String
        vCommaSeparatedPurchaseItemIds = getSelectedPurchaseItemIds()

        If String.IsNullOrEmpty(vCommaSeparatedPurchaseItemIds) Then
            Exit Sub
        End If

        Using frm As New frmAddPrchItemsToPO() With
            {
                .vCommaSeparatedPurchaseItemIds = vCommaSeparatedPurchaseItemIds
            }
            frm.ShowDialog()
        End Using
        refreshTab(vItemStatus)
        refreshPurchaseOrders(PurchaseStatus.PENDING.ToString())
    End Sub

    Private Function getSelectedPurchaseItemIds() As String
        Dim vCommaSeparatedPurchaseItemId As New StringBuilder
        Dim vIndex As Integer = 0
        Dim vIndex1 As Integer = 0
        Dim vIsDirect As Boolean

        'Check that any purchase items are selected
        If grvPurchaseItems.SelectedRowsCount <= 0 Then
            Return ""
        End If

        'Check that the first selected purchase items' type is DIRECT for vIsDirect
        If grvPurchaseItems.GetRowCellValue(grvPurchaseItems.GetSelectedRows.GetValue(0), grvPurchaseItems.Columns("Purchaseitemtype")) = PurchaseItemType.DIRECT.ToString() Then
            vIsDirect = True
        End If
        vSelectedVendorName = String.Empty
        For vIndex = 0 To grvPurchaseItems.SelectedRowsCount - 1
            If Not ValidateSelectedItem(Convert.ToString((grvPurchaseItems.GetRowCellValue(grvPurchaseItems.GetSelectedRows.GetValue(vIndex), grvPurchaseItems.Columns("Vendorname")))),
                                         grvPurchaseItems.GetRowCellValue(grvPurchaseItems.GetSelectedRows.GetValue(vIndex), grvPurchaseItems.Columns("Unitcost")),
                                         grvPurchaseItems.GetRowCellValue(grvPurchaseItems.GetSelectedRows.GetValue(vIndex), grvPurchaseItems.Columns("Purchasenumber"))) Then
                Return ""
            End If

            'Check selected purchase items' type have different purchase types
            If (grvPurchaseItems.GetRowCellValue(grvPurchaseItems.GetSelectedRows.GetValue(vIndex), grvPurchaseItems.Columns("Purchaseitemtype")) = PurchaseItemType.DIRECT.ToString() _
                AndAlso vIsDirect = False) OrElse _
                (grvPurchaseItems.GetRowCellValue(grvPurchaseItems.GetSelectedRows.GetValue(vIndex), grvPurchaseItems.Columns("Purchaseitemtype")) <> PurchaseItemType.DIRECT.ToString() And _
                vIsDirect = True) Then
                MsgBox("Some of the selected items have different purchase types.", MsgBoxStyle.Critical, "Error")
                Return ""
            End If

            vCommaSeparatedPurchaseItemId.Append(grvPurchaseItems.GetRowCellValue(grvPurchaseItems.GetSelectedRows.GetValue(vIndex), grvPurchaseItems.Columns(1))).Append(IIf(vIndex = (grvPurchaseItems.SelectedRowsCount - 1), String.Empty, "','"))
        Next

        Return vCommaSeparatedPurchaseItemId.ToString()
    End Function

    Private Sub btnCancelPurchaseItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelPurchaseItem.ItemClick
        If bsPurchaseItems.Count <= 0 Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to cancel the selected Purchase Item?", _
                  MsgBoxStyle.YesNo, _
                  "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        If checkActivePurchaseItem() Then
            cancelPurchaseItem(bsPurchaseItems.Current.PURCHASEITEMID)
        End If
        refreshTab(vItemStatus)
    End Sub

    Private Sub grvPurchaseItems_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvPurchaseItems.FocusedRowChanged
        setPurchaseItemOptions()
    End Sub

    Private Function checkActivePurchaseItem() As Boolean
        If bsPurchaseItems.Count <= 0 Then
            Return False
        End If
        If bsPurchaseItems.Current.PURCHASEITEMSTATUS = PurchaseItemsStatus.PENDING.ToString() OrElse _
          bsPurchaseItems.Current.PURCHASEITEMSTATUS = PurchaseItemsStatus.REQUESTED.ToString() OrElse _
          bsPurchaseItems.Current.PURCHASEITEMSTATUS = PurchaseItemsStatus.ORDERED.ToString() Then
            Return True
        End If
        Return False
    End Function

    Private Sub setPurchaseItemOptions()
        btnCancelPurchaseItem.Enabled = checkActivePurchaseItem()
        btnSplitPurchaseItem.Enabled = btnCancelPurchaseItem.Enabled
        btnCreatePurchaseOrder.Enabled = btnCancelPurchaseItem.Enabled
        btnAddToExistingPO.Enabled = btnCancelPurchaseItem.Enabled
    End Sub

    Private Sub grvPurchaseOrders_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvPurchaseOrders.FocusedRowChanged
        btnCancelPurchase.Enabled = checkActivePurchaseOrder()
    End Sub

    Private Function checkActivePurchaseOrder() As Boolean
        If bsPOs.Count <= 0 Then
            Return False
        End If
        If bsPOs.Current.PURCHASESTATUS = PurchaseStatus.PENDING.ToString() OrElse _
            bsPOs.Current.PURCHASESTATUS = PurchaseStatus.ORDERED.ToString() Then
            Return True
        End If
        Return False
    End Function

    Private Sub rbtnPendingPurchaseItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) 
        vItemStatus = PurchaseItemsStatus.PENDING.ToString()
        refreshTab(vItemStatus)
    End Sub

    Private Sub rbtnCancelledPurchaseItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancelledPurchaseItems.ItemClick
        vItemStatus = PurchaseItemsStatus.CANCELLED.ToString()
        refreshTab(vItemStatus)
    End Sub

    Private Sub rbtnReceivedHold_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReceivedHold.ItemClick
        Dim frm As New frmReceiveHoldList
        frm.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        refreshMonitorGrids()
    End Sub

    Private Sub refreshMonitorGrids()
        Dim oPurchReqs As ViewPurchaseItems2Collection = getPurchaseItemRecords("REQUESTED")
        bsMonitorRequests.DataSource = oPurchReqs
        bsMaterialPlanning.DataSource = getunAvailableMaterial()
    End Sub


    Private Sub grvMonitorRequests_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grvMonitorRequests.RowStyle
        If (e.RowHandle >= 0) Then

            Dim strDateNeeded As String = ""
            Dim strToday As String = Now.ToShortDateString
            Dim vDateNeeded As Date
            Dim vToday As Date = Convert.ToDateTime(strToday)

            If Not String.IsNullOrEmpty(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Dateneeded"))) Then
                strDateNeeded = grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Dateneeded"))
                vDateNeeded = Convert.ToDateTime(strDateNeeded)
                If vDateNeeded < vToday Then
                    e.Appearance.BackColor = Color.Pink
                    e.Appearance.BackColor2 = Color.Pink
                    e.Appearance.ForeColor = Color.Black
                    Exit Sub
                End If
            End If


            'If Not String.IsNullOrEmpty(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Dateneeded"))) Then
            '    If Convert.ToDateTime(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Dateneeded"))) < Now.Date Then
            '        e.Appearance.BackColor = Color.Pink
            '        e.Appearance.BackColor2 = Color.Pink
            '        e.Appearance.ForeColor = Color.Black
            '        Exit Sub
            '    End If
            'End If

            Dim strExpectedIn As String = ""
            Dim vExpectedIn As Date

            If Not String.IsNullOrEmpty(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Expectedindate"))) Then
                strExpectedIn = grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Expectedindate"))
                vExpectedIn = Convert.ToDateTime(strExpectedIn)
                If Not String.IsNullOrEmpty(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Dateneeded"))) Then
                    strDateNeeded = grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Dateneeded"))
                    vDateNeeded = Convert.ToDateTime(strDateNeeded)
                    If vExpectedIn > vDateNeeded Then
                        e.Appearance.BackColor = Color.Red
                        e.Appearance.BackColor2 = Color.Red
                        e.Appearance.ForeColor = Color.White
                        Exit Sub
                    End If
                End If
            End If


            'If Not String.IsNullOrEmpty(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Expectedindate"))) Then
            '    If Convert.ToDateTime(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Expectedindate"))) > _
            '    Convert.ToDateTime(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Dateneeded"))) Then
            '        e.Appearance.BackColor = Color.Red
            '        e.Appearance.BackColor2 = Color.Red
            '        e.Appearance.ForeColor = Color.White
            '        Exit Sub
            '    End If
            'End If

            If String.IsNullOrEmpty(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Vendorname"))) Or
                (String.IsNullOrEmpty(grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Unitcost"))) OrElse
                 grvMonitorRequests.GetRowCellDisplayText(e.RowHandle, grvMonitorRequests.Columns("Unitcost")) = 0) Then

                e.Appearance.BackColor = Color.Yellow
                e.Appearance.BackColor2 = Color.Yellow
                e.Appearance.ForeColor = Color.Black

                Exit Sub
            End If

        End If
    End Sub

    Private Sub rbtnRefreshPurchaseRequests_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRefreshPurchaseRequests.ItemClick
        refreshMonitorGrids()
    End Sub

    Private Sub rbtnRefreshMaterialNeeds_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRefreshMaterialNeeds.ItemClick
        refreshMonitorGrids()
    End Sub
End Class

