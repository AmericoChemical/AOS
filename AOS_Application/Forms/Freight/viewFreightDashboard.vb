Imports AOS.BusinessObjects

Public Class viewFreightDashboard

    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call  

    End Sub

    Private oPendingLoads As ViewLoadSummaryCollection
    Private oScheduledLoads As ViewLoadSummaryCollection
    Private oInTransitLoads As ViewLoadSummaryCollection
    Private oDeliveredLoads As ViewLoadSummaryCollection
    Private oCancelledLoads As ViewLoadSummaryCollection
    Private oCustomers As CustomerCollection
    Private oCarriers As CarrierCollection
    Private oLogisticsProviders As LogisticsCollection
    Private oParm As Sysparameters

#Region " Form Load / Launch Processes "

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getFreightSettings()
        getLoads("TIMER")
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()

        ' NOTE: This view have never been implemented the security before.
        ' Added by S.Said   2/28/2014
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

    Private Sub rbtnFetchPendingLoads_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrievePendingLoads.ItemClick
        getLoads("PENDING")
    End Sub
    Private Sub rbtnRetrieveScheduledLoads_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveScheduledLoads.ItemClick
        getLoads("SCHEDULED")
    End Sub
    Private Sub rbtnRetrieveInTransitLoads_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveInTransitLoads.ItemClick
        getLoads("IN TRANSIT")
    End Sub
    Private Sub rbtnRetrieveDeliveredLoads_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveDeliveredLoads.ItemClick
        getLoads("DELIVERED")
    End Sub
    Private Sub rbtnRetrieveCancelledLoads_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveCancelledLoads.ItemClick
        getLoads("CANCELLED")
    End Sub

    Private Sub rbtnPendingMarkAsScheduled_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        markLoadStatus(bsPendingLoads.Current.LoadID, "SCHEDULED")
        getLoads("PENDING")
    End Sub

    Private Sub rbtnPendingMarkAsDelivered_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        markLoadStatus(bsPendingLoads.Current.LoadID, "DELIVERED")
        getLoads("PENDING")
    End Sub

    Private Sub rbtnPendingMarkAsCancelled_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPendingMarkAsCancelled.ItemClick
        markLoadStatus(bsPendingLoads.Current.LoadID, "CANCELLED")
        getLoads("PENDING")
    End Sub

    Private Sub rbtnScheduledMarkAsPending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnScheduledMarkAsPending.ItemClick
        markLoadStatus(bsScheduledLoads.Current.LoadID, "PENDING")
        getLoads("SCHEDULED")
    End Sub

    Private Sub rbtnScheduledMarkAsInTransit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnScheduledMarkAsInTransit.ItemClick
        'display form for user to enter additional data items for load as it move to an IN TRANSIT status
        'This form also updates the WorkOrderItems and WorkOrder related to the Load and moves the WorkOrder to a Ready to Invoice state if appropriate
        'This should also 
        Dim frm As New frmMarkLoadInTransit()
        frm.vLoadID = bsScheduledLoads.Current.LoadID
        frm.ShowDialog()
        getLoads("SCHEDULED")
    End Sub

    Private Sub rbtnScheduledMarkAsDelivered_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        markLoadStatus(bsScheduledLoads.Current.LoadID, "DELIVERED")
        getLoads("SCHEDULED")
    End Sub

    Private Sub rbtnScheduledMarkAsCancelled_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnScheduledMarkAsCancelled.ItemClick
        markLoadStatus(bsScheduledLoads.Current.LoadID, "CANCELLED")
        getLoads("SCHEDULED")
    End Sub

    Private Sub rbtnInTransitMarkAsDelivered_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        markLoadStatus(bsInTransitLoads.Current.LoadID, "DELIVERED")
        getLoads("IN TRANSIT")
    End Sub

    Private Sub rbtnInTransitMarkAsReturned_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnInTransitMarkAsReturned.ItemClick
        markLoadStatus(bsInTransitLoads.Current.LoadID, "CANCELLED")
        getLoads("IN TRANSIT")
    End Sub

    Private Sub rbtnDeliveredMarkAsInTransit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeliveredMarkAsInTransit.ItemClick
        markLoadStatus(bsDeliveredLoads.Current.LoadID, "IN TRANSIT")
        getLoads("DELIVERED")
        getLoads("IN TRANSIT")
    End Sub

    Private Sub rbtnRetrieveCustomers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveCustomers.ItemClick
        setReferenceDataRibbonItems("CUSTOMERS")
    End Sub

    Private Sub rbtnRetrieveCarriers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveCarriers.ItemClick
        setReferenceDataRibbonItems("CARRIERS")
    End Sub

    Private Sub rbtnRetrieveLogisiticsProviders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveLogisiticsProviders.ItemClick
        setReferenceDataRibbonItems("LOGISTICS PROVIDERS")
    End Sub

    Private Sub rbtnMergeLoads_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMergeLoads.ItemClick
        mergeSelectedLoads()
    End Sub

    Private Sub rbtnSplitLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        splitSelectedLoad()
    End Sub
#End Region

#Region " Data Processing "

    Private Sub Timer_RefreshData_Tick(sender As Object, e As EventArgs) Handles Timer_RefreshData.Tick
        getFreightSettings()
        getLoads("TIMER")
    End Sub

    Private Sub getFreightSettings()
        oParm = New Sysparameters
        oParm.Query.Where(oParm.Query.RecordID.Equal(1))
        oParm.Query.Load()
        bsParms.DataSource = oParm

        If oParm.FreezeWarning = 0 Then
            eFreeze.Checked = False
            eFreeze.CheckState = CheckState.Unchecked
        ElseIf oParm.FreezeWarning = 1 Then
            eFreeze.Checked = True
            eFreeze.CheckState = CheckState.Checked
        End If

    End Sub

    Private Sub getLoads(vStatus As String)
        Select Case vStatus
            Case "DELIVERED"
                Try
                    oDeliveredLoads = New ViewLoadSummaryCollection
                    oDeliveredLoads.Query.Where(oDeliveredLoads.Query.LoadStatus.Equal("DELIVERED"))
                    oDeliveredLoads.Query.Load()
                    getWorkOrderInfo(oDeliveredLoads)
                    bsDeliveredLoads.DataSource = oDeliveredLoads
                Catch ex As Exception
                    MsgBox("Error is retrieving Delivered Load information", MsgBoxStyle.Critical, "Error - Data")
                    Exit Sub
                End Try
            Case "CANCELLED"
                oCancelledLoads = New ViewLoadSummaryCollection
                oCancelledLoads.Query.Where(oCancelledLoads.Query.LoadStatus.Equal("CANCELLED"))
                oCancelledLoads.Query.Load()
                getWorkOrderInfo(oCancelledLoads)
                bsCancelledLoads.DataSource = oCancelledLoads
            Case Else
                oPendingLoads = New ViewLoadSummaryCollection
                oPendingLoads.Query.Where(oPendingLoads.Query.LoadStatus.Equal("PENDING"))
                oPendingLoads.Query.Load()
                getWorkOrderInfo(oPendingLoads)
                bsPendingLoads.DataSource = oPendingLoads
                oScheduledLoads = New ViewLoadSummaryCollection
                oScheduledLoads.Query.Where(oScheduledLoads.Query.LoadStatus.Equal("SCHEDULED"))
                oScheduledLoads.Query.Load()
                getWorkOrderInfo(oScheduledLoads)
                bsScheduledLoads.DataSource = oScheduledLoads
                oInTransitLoads = New ViewLoadSummaryCollection
                oInTransitLoads.Query.Where(oInTransitLoads.Query.LoadStatus.Equal("IN TRANSIT"))
                oInTransitLoads.Query.Load()
                getWorkOrderInfo(oInTransitLoads)
                bsInTransitLoads.DataSource = oInTransitLoads
        End Select
    End Sub

    Private Sub getWorkOrderInfo(oLoads As ViewLoadSummaryCollection)

        For Each oLoad As ViewLoadSummary In oLoads
            'retrieve list of workorders that are linked to the load and update WorkOrderNumbers field in record
            Dim oLoadWOs As New ViewLoadWorkordersCollection
            oLoadWOs.Query.Where(oLoadWOs.Query.LoadID.Equal(oLoad.LoadID))
            If oLoadWOs.Query.Load() Then
                For Each obj As ViewLoadWorkorders In oLoadWOs
                    If oLoad.WorkOrderNumbers = "" Then
                        oLoad.WorkOrderNumbers = obj.Workordernumber.ToString
                    Else
                        oLoad.WorkOrderNumbers = oLoad.WorkOrderNumbers & ", " & obj.Workordernumber.ToString
                    End If
                Next
            End If
        Next
        'oLoads.Save()

    End Sub


    Private Sub markLoadStatus(vNum As Integer, vStatus As String)
        If MsgBox("Are you sure you want to change the status of the selected Load?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim oRec As New Load
            If oRec.LoadByPrimaryKey(vNum) Then
                oRec.LoadStatus = vStatus
                oRec.ModifiedBy = vCurrentUserLogin
                oRec.ModifiedTime = Now
                oRec.Save()
            End If
        Catch ex As Exception
            MsgBox("Error in updating status of selected Load", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub getCustomers()
        oCustomers = New CustomerCollection
        oCustomers.LoadAll()
        oCustomers.Filter = ""
        oCustomers.Sort = "CUSTNAME ASC"
        bsCustomers.DataSource = oCustomers
    End Sub

    Private Sub getCarriers()
        oCarriers = New CarrierCollection
        oCarriers.LoadAll()
        oCarriers.Filter = ""
        oCarriers.Sort = "CARRIERNAME ASC"
        bsCarriers.DataSource = oCarriers
        If oCarriers.Count <= 0 Then
            rbtnDeleteCarrier.Enabled = False
            rbtnEditCarrier.Enabled = False
        Else
            rbtnDeleteCarrier.Enabled = True
            rbtnEditCarrier.Enabled = True
        End If
    End Sub

    Private Sub getLogisticsProviders()
        oLogisticsProviders = New LogisticsCollection
        oLogisticsProviders.LoadAll()
        oLogisticsProviders.Filter = ""
        oLogisticsProviders.Sort = "LOGISTICSNAME ASC"
        bsLogistics.DataSource = oLogisticsProviders
        If oLogisticsProviders.Count <= 0 Then
            rbtnDeleteLogisticsProvider.Enabled = False
            rbtnEditLogisticsProvider.Enabled = False
        Else
            rbtnDeleteLogisticsProvider.Enabled = True
            rbtnEditLogisticsProvider.Enabled = True
        End If
    End Sub

    Private Sub setReferenceDataRibbonItems(vObject As String)
        'first set all buttons to invisible
        rbtnAddNewCarrier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        rbtnEditCarrier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        rbtnDeleteCarrier.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        rbtnAddNewLogisticsProvider.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        rbtnEditLogisticsProvider.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        rbtnDeleteLogisticsProvider.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

        'set all group controls to invisible 
        gcCustomers.Visible = False
        gcCarriers.Visible = False
        gcLogisticsProviders.Visible = False

        Select Case vObject
            Case "CUSTOMERS"
                getCustomers()
                gcCustomers.BringToFront()
                gcCustomers.Visible = True
            Case "CARRIERS"
                getCarriers()
                gcCarriers.BringToFront()
                gcCarriers.Visible = True
                rbtnAddNewCarrier.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnEditCarrier.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnDeleteCarrier.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Case "LOGISTICS PROVIDERS"
                getLogisticsProviders()
                gcLogisticsProviders.BringToFront()
                gcLogisticsProviders.Visible = True
                rbtnAddNewLogisticsProvider.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnEditLogisticsProvider.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnDeleteLogisticsProvider.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End Select

    End Sub

    Private Sub mergeSelectedLoads()
        If grvPendingLoads.SelectedRowsCount <> 2 Then
            MsgBox("You must select only 2 load records to merge together.", MsgBoxStyle.Critical, "Error - Incorrect Number of Loads")
            Exit Sub
        End If

        Dim vLoad1 As Integer
        Dim vLoad2 As Integer
        Dim vLoadID1 As Integer
        Dim vLoadID2 As Integer
        Try
            vLoad1 = grvPendingLoads.GetRowCellDisplayText(grvPendingLoads.GetSelectedRows()(0), grvPendingLoads.VisibleColumns(0))
            vLoad2 = grvPendingLoads.GetRowCellDisplayText(grvPendingLoads.GetSelectedRows()(1), grvPendingLoads.VisibleColumns(0))
            If vLoad1 > vLoad2 Then
                vLoadID1 = vLoad1
                vLoadID2 = vLoad2
            Else
                vLoadID1 = vLoad2
                vLoadID2 = vLoad1
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'we now have two (and only two) load ids and the they are in sequential order. 
        'this code will merge the second load (with the higher loadid value) into the first load

        'retrieve the load records and loaditem records for each load
        Dim oLoad1 As New Load
        If Not oLoad1.LoadByPrimaryKey(vLoadID1) Then
            MsgBox("Error in retrieving data for first load", MsgBoxStyle.Critical, "Error - No data")
            Exit Sub
        End If
        Dim oLoad2 As New Load
        If Not oLoad2.LoadByPrimaryKey(vLoadID2) Then
            MsgBox("Error in retrieving data for second load", MsgBoxStyle.Critical, "Error - No data")
            Exit Sub
        End If
        Dim oItems1 As New LoaditemCollection
        oItems1.Query.Where(oItems1.Query.LoadID.Equal(vLoadID1))
        If Not oItems1.Query.Load() Then
            MsgBox("Error in retrieving data for first load items", MsgBoxStyle.Critical, "Error - No data")
            Exit Sub
        End If
        Dim oItems2 As New LoaditemCollection
        oItems2.Query.Where(oItems2.Query.LoadID.Equal(vLoadID2))
        If Not oItems2.Query.Load() Then
            MsgBox("Error in retrieving data for first load items", MsgBoxStyle.Critical, "Error - No data")
            Exit Sub
        End If

        'We now have all the data records - now we need to do some data validation to confirm the selected loads can be merged
        '1) Load Origin information must match
        If oLoad1.OriginType <> oLoad2.OriginType Then
            MsgBox("The Origin Type of each load does not match", MsgBoxStyle.Critical, "Error - Merge Failed")
            Exit Sub
        End If
        If oLoad1.OriginID <> oLoad2.OriginID Then
            MsgBox("The Origin Location of each load does not match", MsgBoxStyle.Critical, "Error - Merge Failed")
            Exit Sub
        End If
        '2) Load Destination information must match
        If oLoad1.DestType <> oLoad2.DestType Then
            MsgBox("The Destination Type of each load does not match", MsgBoxStyle.Critical, "Error - Merge Failed")
            Exit Sub
        End If
        If oLoad1.DestID <> oLoad2.DestID Then
            MsgBox("The Destination Location of each load does not match", MsgBoxStyle.Critical, "Error - Merge Failed")
            Exit Sub
        End If

        'at this point we have two load that can be merged together - confirm with user
        If MsgBox("Are you sure you want to merge Load# " & vLoadID1.ToString & " with Load# " & vLoadID2.ToString & "? THIS CANNOT BE UNDONE!", MsgBoxStyle.YesNo, "Confirm - Merge Loads?") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Scan the LoadItem records for the Load2 and copy them into the first Load
        Try
            For Each oItem As Loaditem In oItems2
                Dim oItem1 As New Loaditem
                oItem1.LoadID = vLoadID1
                oItem1.SourceType = oItem.SourceType
                oItem1.SourceID = oItem.SourceID
                oItem1.ItemType = oItem.ItemType
                oItem1.ItemID = oItem.ItemID
                oItem1.ItemDescription = oItem.ItemDescription
                oItem1.Container = oItem.Container
                oItem1.QtyContainers = oItem.QtyContainers
                oItem1.TotalVolume = oItem.TotalVolume
                oItem1.VolumeUOM = oItem.VolumeUOM
                oItem1.TotalWeight = oItem.TotalWeight
                oItem1.WeightUOM = oItem.WeightUOM
                oItem1.DOTIDNumber = oItem.DOTIDNumber
                oItem1.HazmatID = oItem.HazmatID
                oItem1.HazmatClass = oItem.HazmatClass
                oItem1.HazmatPackageGroup = oItem.HazmatPackageGroup
                oItem1.ClassRate = oItem.ClassRate
                oItem1.DOTDesc = oItem.DOTDesc
                oItem1.HazMatDesc = oItem.HazMatDesc
                oItem1.UNLine = oItem.UNLine
                oItem1.IsHazardous = oItem.IsHazardous
                oItem1.PalletID = oItem.PalletID
                oItem1.LoadItemNote = oItem.LoadItemNote
                oItem1.Ld1 = oItem.Ld1
                oItem1.Ld2 = oItem.Ld2
                oItem1.Ld3 = oItem.Ld3
                oItem1.CreatedTime = oItem.CreatedTime
                oItem1.CreatedBy = oItem.CreatedBy
                oItem1.ModifiedTime = Now
                oItem1.ModifiedBy = vCurrentUserLogin
                oItem1.Save()
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'now mark the second load as MERGED
        oLoad2.LoadStatus = "MERGED"
        oLoad2.Save()

        'LOADQUOTE records

        'LOADCHARGE records

        'LOADBILLING records

    End Sub

    Private Sub splitSelectedLoad()

    End Sub

    Private Sub printBOL(vLoadID As Integer)
        'first, we need to determine if the customer for the selected load wants to receive a printed packing list
        'in addition to the printed Bill of Lading document
        'This is a flag called NEEDPACKINGLIST in the customer table
        Try
            Dim oLd As New Load
            If oLd.LoadByPrimaryKey(vLoadID) Then
                'look up customer by Load Destination ID
                Dim oCust As New Customer
                If oCust.LoadByPrimaryKey(oLd.DestID) Then
                    If oCust.Needpackinglist = True Then
                        printPackingList(vLoadID)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Could not determine if Customer for this Load is requesting a Packing List", MsgBoxStyle.Critical, "Error - Data Retrieval")
        End Try

        'now, print the Bill of Lading report for the selected Load
        Dim rpt As New rptBillOfLading3(vLoadID)
        rpt.ShowPreviewDialog()

    End Sub

    Private Sub printPackingList(vLoadID As Integer)
        Dim rpt As New rptBillOfLading3(vLoadID)
        rpt.ShowPreviewDialog()
    End Sub

#End Region


    Private Sub rbtnPendingAddLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPendingAddLoad.ItemClick

    End Sub

    Private Sub btnPendingEditLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPendingEditLoad.ItemClick
        Dim frm As New frmAddEditLoad
        frm.vEditType = "EDIT"
        frm.vLoadID = bsPendingLoads.Current.LoadID
        frm.ShowDialog()
        getLoads("PENDING")
    End Sub

    Private Sub rbtnPrintBOL_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintBOL.ItemClick
        'print BOL from Scheduled Loads screen
        printBOL(bsScheduledLoads.Current.LoadID)
    End Sub

    Private Sub rtbnScheduledLoadEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rtbnScheduledLoadEdit.ItemClick

    End Sub

    Private Sub rbtnInTransitLoadEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub rbtnReprintBOL_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReprintBOL.ItemClick
        'reprint BOL from the Delivered Screen
        printBOL(bsDeliveredLoads.Current.LoadID)
    End Sub

    Private Sub rbtnAddNewCarrier_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewCarrier.ItemClick

    End Sub

    Private Sub rbtnEditCarrier_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditCarrier.ItemClick

    End Sub

    Private Sub rbtnDeleteCarrier_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteCarrier.ItemClick

    End Sub

    Private Sub rbtnAddNewLogisticsProvider_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewLogisticsProvider.ItemClick

    End Sub

    Private Sub rbtnEditLogisticsProvider_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditLogisticsProvider.ItemClick

    End Sub

    Private Sub rbtnDeleteLogisticsProvider_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteLogisticsProvider.ItemClick

    End Sub

    Private Sub rbtnEditFreightSettings_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditFreightSettings.ItemClick
        Dim frm As New frmEditFreightSettings
        frm.ShowDialog()
        getFreightSettings()
    End Sub

    Private Sub rbtnProcessLoad_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnProcessLoad.ItemClick
        Dim frm As New frmLoadProcessing
        frm.vLoadID = bsPendingLoads.Current.loadid
        frm.ShowDialog()
        getLoads("PENDING")
    End Sub

    Private Sub rbtnPrintRptFutureShipments_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintRptFutureShipments.ItemClick
        Dim rpt As New rptFutureShipments
        rpt.ShowPreviewDialog()
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
End Class
