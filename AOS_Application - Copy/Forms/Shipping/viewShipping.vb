Imports AOS.BusinessObjects

Public Class viewShipping
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub


    'Establish the main type of business objectc you are using is this form
    Dim oShipments As ViewShipmentInfoCollection
    Dim oShipmentRecord As Shipment = Nothing
    Dim oCarrierCollection As CarrierCollection = Nothing
    Dim oLogisticsCollection As LogisticsCollection = Nothing
    Dim oPickedOrders As ViewPickedWorkOrdersCollection = Nothing


    'Establish all secondary business objects (i.e. used in lookups, linked combo boxes, etc.)
    Dim oWorkOrders As WorkorderCollection = Nothing
 
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



#End Region


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'loadCarrierList()
        'LoadLogisticsProviders()
        'getPickedWorkOrders()
    End Sub

    Private Sub getShipmentInfo()
        oShipments = New ViewShipmentInfoCollection
        oShipments.LoadAll()
        oShipments.Sort = "ShipmentNumber DESC"
        bsShipments.DataSource = oShipments
    End Sub

    Private Sub getPickedWorkOrders()
        bsPickedOrders.DataSource = Nothing
        oPickedOrders = New ViewPickedWorkOrdersCollection
        oPickedOrders.LoadAll()
        If oPickedOrders.Count <= 0 Then
            MsgBox("There are no work orders with all items PICKED and awaiting shipment", MsgBoxStyle.Critical, "No data found")
        End If
        bsPickedOrders.DataSource = oPickedOrders
        Me.grPickedOrders.DataSource = bsPickedOrders
        Me.grPickedOrders.Refresh()
    End Sub


    Private Sub loadMasterData(ByVal vCustID As Integer)
        oShipments = New ViewShipmentInfoCollection
        oShipments.Query.Load()
        oShipments.Sort = "SHIPMENTDATE DESC"
        Try
            bsShipments.DataSource = oShipments
        Catch ex As Exception
        End Try
    End Sub

    Private Sub loadCarrierList()

        oCarrierCollection = New CarrierCollection
        Try
            oCarrierCollection.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            oCarrierCollection.LoadAll()
            oCarrierCollection.Filter = ""
            oCarrierCollection.Sort = "CarrierName ASC"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Me.bsCarriers.DataSource = oCarrierCollection
        dgvCarrier.DataSource = bsCarriers
        dgvCarrier.Refresh()

    End Sub

    Private Sub LoadLogisticsProviders()
        oLogisticsCollection = New LogisticsCollection
        Try
            oLogisticsCollection.LoadAll()
            oLogisticsCollection.Filter = ""
            oLogisticsCollection.Sort = "LogisticsName ASC"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Me.bsLogistics.DataSource = oLogisticsCollection
        dgLogistics.DataSource = bsLogistics
        dgLogistics.Refresh()
    End Sub


    Private Sub editShipment()
        If bsShipments.Count <= 0 Then
            MsgBox("No shipment to edit", MsgBoxStyle.Critical, "Error - No Shipment Available")
            Exit Sub
        End If
        Dim frm As New frmAddEditShipment
        frm.vShipmentID = Me.bsShipments.Current.ShipmentNumber
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getShipmentInfo()
    End Sub

    Private Sub addShipment()
        'If Not validCustomer() Then
        '    Exit Sub
        'End If
        Dim frm As New frmAddEditShipment
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        frm.vShipmentID = 0
        vResult = frm.ShowDialog()
        getShipmentInfo()
    End Sub

    Private Sub deleteShipment()
        Dim str As String
        str = "Are you sure you want to delete the selected Shipment?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            'Delete Shipment Details for Shipment first
            Dim oShipmentDetailCollection As ShipmentdetailCollection
            oShipmentDetailCollection = New ShipmentdetailCollection
            oShipmentDetailCollection.Query.Where(oShipmentDetailCollection.Query.Shipmentnumber.Equal(bsShipments.Current.ShipmentNumber))
            oShipmentDetailCollection.Query.Load()
            oShipmentDetailCollection.MarkAllAsDeleted()
            oShipmentDetailCollection.Save()
            'Delete Shipment Items for Shipment first
            Dim oShipItems As ShipmentitemCollection
            oShipItems = New ShipmentitemCollection
            oShipItems.Query.Where(oShipItems.Query.Shipmentnumber.Equal(bsShipments.Current.ShipmentNumber))
            oShipItems.Query.Load()
            oShipItems.MarkAllAsDeleted()
            oShipItems.Save()

            'Delete Shipment
            Dim oShipment As Shipment
            oShipment = New Shipment
            oShipment.LoadByPrimaryKey(bsShipments.Current.ShipmentNumber)
            oShipment.MarkAsDeleted()
            oShipment.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        getShipmentInfo()
    End Sub

    Private Sub printBOL()
        Dim vID As Integer = 0
        Try
            vID = bsShipments.Current.ShipmentNumber
        Catch ex As Exception
        End Try
        If vID = 0 Then
            MsgBox("You must select a Shipment first", MsgBoxStyle.Critical, "Error - No Shipment")
            Exit Sub
        End If

        Dim rpt As New rptBillOfLading4(vID)
        rpt.ShowPreview()

    End Sub

    Private Sub editCarrier()
        Dim frm As New frmAddEditCarrier
        frm.vID = Me.bsCarriers.Current.CarrierID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadCarrierList()
    End Sub

    Private Sub addCarrier()
        Dim frm As New frmAddEditCarrier
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        vResult = frm.ShowDialog()
        loadCarrierList()
    End Sub

    Private Sub deleteCarrier()
        Dim str As String
        str = "Are you sure you want to delete the selected Carrier? " & bsCarriers.Current.CarrierName & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Dim oCarrier As Carrier
            oCarrier = New Carrier
            With oCarrier
                .es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
                .LoadByPrimaryKey(bsCarriers.Current.CarrierID)
                .MarkAsDeleted()
                .Save()
            End With
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        loadCarrierList()
    End Sub


    Private Sub viewShipping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()
        ' setRibbonOptions(vCurrentUserSecurityLevel)

        ' setRibbonOptions(vCurrentUserSecurityLevel)
        setRibbonOptionsSecurity(vCurrentUserID)

        ' Call Security Timer to start hiding/showing Groups and Functions based on the security settings 
        StartSecurityTimer()

    End Sub


    Private Sub btnAddCarrier_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddCarrier.ItemClick
        addCarrier()
    End Sub

    Private Sub btnDeleteCarrier_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteCarrier.ItemClick
        deleteCarrier()
    End Sub

    Private Sub btnEditCarrier_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditCarrier.ItemClick
        editCarrier()
    End Sub

    Private Sub btnAddShipment_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddShipment.ItemClick
        addShipment()
    End Sub

    Private Sub btnEditShipment_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditShipment.ItemClick
        editShipment()
    End Sub

    Private Sub btnDeleteShipment_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteShipment.ItemClick
        deleteShipment()
    End Sub

    Private Sub btnPrintBOL_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintBOL.ItemClick
        printBOL()
    End Sub

    Private Sub btnCreateShipmentFromWorkOrder_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateShipmentFromWorkOrder.ItemClick
        If bsPickedOrders.Count <= 0 Then
            Exit Sub
        End If
        createNewShipmentFromSelectedWorkOrders()
        getPickedWorkOrders()
    End Sub

    Private Sub createNewShipmentFromSelectedWorkOrders()

        If grvPickedOrders.SelectedRowsCount <= 0 Then
            Exit Sub
        End If

        'confirm user want to really add new shipments
        Dim str As String = "Are you sure you want to create a new shipment for the selected work order(s)?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim vWONum As Integer = 0
        Dim vShipmentNum As Integer = 0
        Dim vCustName As String = ""

        'process the first selected picked order record and confirm all selected picked work orders are for same customer
        vWONum = grvPickedOrders.GetRowCellDisplayText(grvPickedOrders.GetSelectedRows(0), colWorkordernumber)
        vCustName = grvPickedOrders.GetRowCellDisplayText(grvPickedOrders.GetSelectedRows(0), colCustname)
        If grvPickedOrders.SelectedRowsCount > 1 Then
            For I As Integer = 1 To (grvPickedOrders.SelectedRowsCount - 1)
                Try
                    If vCustName <> grvPickedOrders.GetRowCellDisplayText(grvPickedOrders.GetSelectedRows(I), colCustname) Then
                        MsgBox("The Customer Names for the selected work orders do not match. Cannot combine work orders from different customers onto one shipment", MsgBoxStyle.Critical, "ERROR")
                        Exit Sub
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If

        'then add a new shipment record to the database.
        'return the new shipment number created to use to add additional picked orders to the shipment.
        vShipmentNum = addNewShipmentFromWorkOrder(vWONum)

        'if no more picked orders, then we are done.
        If grvPickedOrders.SelectedRowsCount <= 1 Then
            Exit Sub
        End If

        'starting from the second selected picked order, continue adding work order items to the shipment created in the steps above
        Dim vRI As Integer
        For vRI = 1 To (grvPickedOrders.SelectedRowsCount - 1)
            Try
                vWONum = grvPickedOrders.GetRowCellDisplayText(grvPickedOrders.GetSelectedRows(vRI), colWorkordernumber)
                addSelectedWorkOrderToExistingShipment(vWONum, vShipmentNum)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

    End Sub

    Private Function addNewShipmentFromWorkOrder(vWONum As Integer) As Integer

        Dim oWO As New Workorder
        Dim oWOItems As New WorkorderitemCollection
        Dim oShipment As New Shipment
        Dim oParms As New Sysparameters
        Dim oCustomer As New Customer
        Dim oCarrier As New Carrier
        Dim oLogistics As New Logistics
        Dim oParm As New Sysparameters

        Dim vCarrierID As Integer = 0
        Dim vLogisticsID As Integer = 0
        Dim vShipmentNum As Integer = 0
        Dim vCustomerPO As String = Nothing
        Dim vQtyContainers As Integer = 0
        Dim vLotNumber As String = Nothing
        Dim vBillable As Integer = 1
        Dim vProductID As Integer = 0
        Dim vShipDate As Date = getUserDate("Enter Shipment Date")
        Dim vItemStatus As String = Nothing

        'get system parameters record
        oParm = New Sysparameters
        oParm.LoadByPrimaryKey(1)

        'get work order record
        Try
            If Not oWO.LoadByPrimaryKey(vWONum) Then
                MsgBox("Could not retrieve selected work order information", MsgBoxStyle.Critical, "Error")
                Return 0
            End If
        Catch ex As Exception
        End Try

        'get related database records
        Try
            oWOItems = New WorkorderitemCollection
            oWOItems.Query.Where(oWOItems.Query.Workordernumber.Equal(vWONum))
            If Not oWOItems.Query.Load Then
                MsgBox("Could not load work order item records for selected picked order", MsgBoxStyle.Critical, "Error")
                Return 0
            End If
        Catch ex As Exception
        End Try
        Try
            If Not oCustomer.LoadByPrimaryKey(oWO.Custid) Then
                MsgBox("Could not retrieve data for Customer on selected work order", MsgBoxStyle.Critical, "Error")
                Return 0
            End If
        Catch ex As Exception
        End Try
        Try
            oParms.LoadByPrimaryKey(1)
        Catch ex As Exception
        End Try
        Try
            If Not IsDBNull(oWO.Carrierid) And oWO.Carrierid > 0 Then
                oCarrier.LoadByPrimaryKey(oWO.Carrierid)
            Else
                oCarrier.Query.Where(oCarrier.Query.CarrierName.Equal(oWO.Freightcarrier))
                oCarrier.Query.Load()
            End If
        Catch ex As Exception
        End Try
        Try
            If oLogistics.LoadByPrimaryKey(oWO.Logisticsid) Then
                vLogisticsID = oLogistics.Logisticsid
            End If
        Catch ex As Exception
        End Try

        'Create Shipment Record from Work Order Record and Customer Record
        Try
            oShipment.AddNew()
            'oShipment.Keepfromfreezing = oParm.FreezeWarning
            oShipment.Keepfromfreezing = oWO.Freezeprotectflag
            oShipment.Custid = oWO.Custid
            oShipment.Customername = oCustomer.Custname
            oShipment.Customerpo = oWO.Customerpo
            oShipment.Fob = oWO.Fob
            oShipment.Carrierid = oWO.Carrierid
            oShipment.Freightcarrier = oCarrier.CarrierName
            oShipment.Logisticsid = vLogisticsID
            'assume shipments from work orders will be from Americo plant to customer location
            oShipment.Shipfromid = 160
            oShipment.Shipfromname = oParms.CompanyName
            oShipment.Shipfromaddress1 = oParms.CompanyAddress
            oShipment.Shipfromcity = oParms.CompanyCity
            oShipment.Shipfromstateprov = oParms.CompanyState
            oShipment.Shipfrompostalcode = oParms.CompanyZipcode
            oShipment.Shipfromcountry = oParms.CompanyCountry
            oShipment.Shipfromcontact = "Shipping Manager"
            oShipment.Shipmentdate = vShipDate
            oShipment.Shipmentstatus = "OPEN"
            oShipment.Shiptoid = oCustomer.Custid
            oShipment.Shiptoname = oCustomer.Custname
            oShipment.Shiptoaddress1 = IIf(IsDBNull(oWO.Shipaddress1) Or oWO.Shipaddress1 = "", oCustomer.Custshipaddress1, oWO.Shipaddress1)
            oShipment.Shiptoaddress2 = IIf(IsDBNull(oWO.Shipaddress2) Or oWO.Shipaddress2 = "", oCustomer.Custshipaddress2, oWO.Shipaddress2)
            oShipment.Shiptocity = IIf(IsDBNull(oWO.Shipcity) Or oWO.Shipcity = "", oCustomer.Custshipcity, oWO.Shipcity)
            oShipment.Shiptostateprov = IIf(IsDBNull(oWO.Shipstateprov) Or oWO.Shipstateprov = "", oCustomer.Custshipstateprov, oWO.Shipstateprov)
            oShipment.Shiptopostalcode = IIf(IsDBNull(oWO.Shippostalcode) Or oWO.Shippostalcode = "", oCustomer.Custshippostalcode, oWO.Shippostalcode)
            oShipment.Shiptocountry = IIf(IsDBNull(oWO.Shipcountry) Or oWO.Shipcountry = "", oCustomer.Custshipcountry, oWO.Shipcountry)
            oShipment.Workordernumber = vWONum
            oShipment.EndEdit()
            oShipment.Save()
            vShipmentNum = oShipment.Shipmentnumber
            vCustomerPO = oShipment.Customerpo
        Catch ex As Exception
            MsgBox(ex.Message)
            Return 0
        End Try

        'now that we have added the shipment record, we need to add work order items to the shipmentitem table
        For Each oItem As Workorderitem In oWOItems
            'get inventory item status to know if item should be included in shipment or back ordered or skipped as already shipped
            vItemStatus = getInventoryItemStatus(IIf(IsDBNull(oItem.Invitemnumber), 0, oItem.Invitemnumber))
            Select Case vItemStatus
                Case "UNKNOWN"
                    vQtyContainers = 0
                Case "PICKED"
                    vQtyContainers = IIf(IsDBNull(oItem.Qty), 0, oItem.Qty)
                Case "SHIPPED"
                    vQtyContainers = -1
                Case Else
                    vQtyContainers = 0
            End Select
            'now add the item as a new shipment item
            vCustomerPO = IIf(IsDBNull(oItem.Customerpo), vCustomerPO, oItem.Customerpo)
            vProductID = IIf(IsDBNull(oItem.Productid), 0, oItem.Productid)
            vLotNumber = IIf(IsDBNull(oItem.Lotnumber), "", oItem.Lotnumber)
            vBillable = IIf(IsDBNull(oItem.Billable), 1, oItem.Billable)
            If vQtyContainers <> -1 Then
                Try
                    createShipmentItem(vShipmentNum, vProductID, vQtyContainers, vLotNumber, vCustomerPO, vBillable, oItem.Workorderitemnumber)
                    If vQtyContainers > 0 And Not IsDBNull(oItem.Invitemnumber) Then
                        markItemAsShipped(oItem.Invitemnumber, vShipmentNum, vShipDate)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox("Error is creating shipment item for Work Order Item # " & oItem.Workorderitemnumber, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Next

        checkToCloseOrder(vWONum)

        Return vShipmentNum

    End Function
    Private Sub markItemAsShipped(vInvItemNumber As Integer, vShipmentNum As Integer, vShipDate As Date)
        Dim oInv As New Invitem
        If oInv.LoadByPrimaryKey(vInvItemNumber) Then
            oInv.Itemstatus = "SHIPPED"
            oInv.Shipmentnumber = vShipmentNum
            oInv.Shippeddate = vShipDate
            oInv.Save()
        End If
    End Sub
    Private Function getInventoryItemStatus(vInvItemNum As Integer) As String
        If IsDBNull(vInvItemNum) Then
            Return "UNKNOWN"
        End If
        Dim oInvItem As Invitem
        oInvItem = New Invitem
        If Not oInvItem.LoadByPrimaryKey(vInvItemNum) Then
            Return "UNKNOWN"
        Else
            Return oInvItem.Itemstatus
        End If
    End Function

    Private Sub addSelectedWorkOrderToExistingShipment(vWONum As Integer, vShipmentNum As Integer)

        Dim oWO As New Workorder
        Dim oWOItems As New WorkorderitemCollection
        Dim oShipment As New Shipment
        Dim oParms As New Sysparameters
        Dim oCustomer As New Customer
        Dim oCarrier As New Carrier
        Dim oLogistics As New Logistics

        Dim vCarrierID As Integer = 0
        Dim vLogisticsID As Integer = 0
        Dim vCustomerPO As String = Nothing
        Dim vQtyContainers As Integer = 0
        Dim vLotNumber As String = Nothing
        Dim vBillable As Integer = 1
        Dim vProductID As Integer = 0
        Dim vItemStatus As String = Nothing

        'get work order record
        Try
            If Not oWO.LoadByPrimaryKey(vWONum) Then
                MsgBox("Could not retrieve selected work order information", MsgBoxStyle.Critical, "Error - " & vWONum.ToString)
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        'get related database records
        Try
            oWOItems = New WorkorderitemCollection
            oWOItems.Query.Where(oWOItems.Query.Workordernumber.Equal(vWONum))
            If Not oWOItems.Query.Load Then
                MsgBox("Could not load work order item records for selected picked order", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Catch ex As Exception
        End Try
        Try
            If Not oCustomer.LoadByPrimaryKey(oWO.Custid) Then
                MsgBox("Could not retrieve data for Customer on selected work order", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Catch ex As Exception
        End Try
        Try
            oParms.LoadByPrimaryKey(1)
        Catch ex As Exception
        End Try
        Try
            oCarrier.Query.Where(oCarrier.Query.CarrierName.Equal(oWO.Freightcarrier))
            If oCarrier.Query.Load Then
                vCarrierID = oCarrier.CarrierID
            End If
        Catch ex As Exception
        End Try
        Try
            If oLogistics.LoadByPrimaryKey(oWO.Logisticsid) Then
                vLogisticsID = oLogistics.Logisticsid
            End If
        Catch ex As Exception
        End Try

        'retrieve existing shipment record to which you are adding this new work order
        Try
            If Not oShipment.LoadByPrimaryKey(vShipmentNum) Then
                MsgBox("Error in retrieving existing Shipment Number", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        'now that we have retrieved the shipment record, we need to add work order items to the shipmentitem table
        For Each oItem As Workorderitem In oWOItems
            'get inventory item status to know if item should be included in shipment or back ordered or skipped as already shipped
            vItemStatus = getInventoryItemStatus(IIf(IsDBNull(oItem.Invitemnumber), 0, oItem.Invitemnumber))
            Select Case vItemStatus
                Case "UNKNOWN"
                    vQtyContainers = 0
                Case "PICKED"
                    vQtyContainers = IIf(IsDBNull(oItem.Qty), 0, oItem.Qty)
                Case "SHIPPED"
                    vQtyContainers = -1
                Case Else
                    vQtyContainers = 0
            End Select
            'now add the item as a new shipment item
            vProductID = IIf(IsDBNull(oItem.Productid), 0, oItem.Productid)
            vLotNumber = IIf(IsDBNull(oItem.Lotnumber), "", oItem.Lotnumber)
            vBillable = IIf(IsDBNull(oItem.Billable), 1, oItem.Billable)
            If vQtyContainers <> -1 Then
                Try
                    createShipmentItem(vShipmentNum, vProductID, vQtyContainers, vLotNumber, oItem.Customerpo, vBillable, oItem.Workorderitemnumber)
                    If vQtyContainers > 0 And Not IsDBNull(oItem.Invitemnumber) Then
                        markItemAsShipped(oItem.Invitemnumber, vShipmentNum, oShipment.Shipmentdate)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    MsgBox("Error is creating shipment item for Work Order Item # " & oItem.Workorderitemnumber, MsgBoxStyle.Critical, "Error")
                End Try
            End If
        Next

        checkToCloseOrder(vWONum)

    End Sub

    'Private Sub createShipmentFromWorkOrder(ByVal vNum As Integer)

    '    Dim str As String = "Are you sure you want to create a new shipment for the selected work order(s)?"
    '    If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    '*********************************************************************
    '    '10/4/2010
    '    'perform a query to determine if there are anymore allocated (unpicked) items on the selected work order
    '    'if so then prevent the creation of shipment by exiting procedure
    '    Dim cmd As New SqlClient.SqlCommand
    '    Dim vCnt As Integer = 0
    '    str = "select count(*) from workorderitem where workordernumber = " & vNum.ToString & " and	invitemnumber is not null and invitemnumber in (select invitemnumber from invitem where itemstatus = 'ALLOCATED')"
    '    Try
    '        sqlcnn.Open()
    '        cmd = New SqlClient.SqlCommand(str, sqlcnn)
    '        vCnt = cmd.ExecuteScalar
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        If sqlcnn.State = ConnectionState.Open Then
    '            sqlcnn.Close()
    '        End If
    '    End Try

    '    If vCnt > 0 Then
    '        MsgBox("There are still allocated items on this workorder that have not been picked.", MsgBoxStyle.Critical, "Not all items picked")
    '        Exit Sub
    '    End If
    '    '*********************************************************************

    '    Dim vShipmentNum As Integer = 0
    '    Dim vCustomerPO As String = Nothing
    '    Dim vQtyContainers As Integer = 0
    '    Dim vLotNumber As String = Nothing
    '    Dim vBillable As Integer = 1
    '    Dim vProductID As Integer = 0
    '    Dim vShipDate As Date = getUserDate("Enter Shipment Date")

    '    Dim oWO As Workorder = New Workorder
    '    Dim oShipment As Shipment = New Shipment
    '    Dim oCustomer As Customer = New Customer
    '    Dim oParms As Sysparameters = New Sysparameters

    '    Dim dt As New dsPickedWorkOrders.PickedItemsDataTable
    '    Dim da As New dsPickedWorkOrdersTableAdapters.PickedItemsTableAdapter

    '    oWO.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
    '    oShipment.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
    '    oCustomer.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
    '    oParms.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword

    '    'get WorkOrder record
    '    oWO.LoadByPrimaryKey(vNum)

    '    'get Customer record
    '    oCustomer.LoadByPrimaryKey(oWO.Custid)

    '    'get Parameter record for Americo address info
    '    oParms.LoadByPrimaryKey(1)

    '    'Create Shipment Record from Work Order Record and Customer Record
    '    Try
    '        oShipment.AddNew()
    '        oShipment.Custid = oWO.Custid
    '        oShipment.Customername = oCustomer.Custname
    '        oShipment.Customerpo = oWO.Customerpo
    '        oShipment.Fob = oWO.Fob
    '        oShipment.Freightcarrier = oWO.Freightcarrier
    '        oShipment.Logisticsid = oWO.Logisticsid
    '        oShipment.Shipfromaddress1 = oParms.CompanyName
    '        oShipment.Shipfromaddress2 = oParms.CompanyAddress
    '        oShipment.Shipfromcity = oParms.CompanyCity
    '        oShipment.Shipfromstateprov = oParms.CompanyState
    '        oShipment.Shipfrompostalcode = oParms.CompanyZipcode
    '        oShipment.Shipfromcountry = oParms.CompanyCountry
    '        oShipment.Shipfromcontact = "Shipping Manager"
    '        oShipment.Shipmentdate = vShipDate
    '        oShipment.Shipmentstatus = "OPEN"
    '        oShipment.Shiptoaddress1 = oCustomer.Custname
    '        oShipment.Shiptoaddress2 = IIf(IsDBNull(oWO.Shipaddress1) Or oWO.Shipaddress1 = "", oCustomer.Custshipaddress1, oWO.Shipaddress1) & " " & IIf(IsDBNull(oWO.Shipaddress2) Or oWO.Shipaddress2 = "", oCustomer.Custshipaddress2, oWO.Shipaddress2)
    '        oShipment.Shiptocity = IIf(IsDBNull(oWO.Shipcity) Or oWO.Shipcity = "", oCustomer.Custshipcity, oWO.Shipcity)
    '        oShipment.Shiptostateprov = IIf(IsDBNull(oWO.Shipstateprov) Or oWO.Shipstateprov = "", oCustomer.Custshipstateprov, oWO.Shipstateprov)
    '        oShipment.Shiptopostalcode = IIf(IsDBNull(oWO.Shippostalcode) Or oWO.Shippostalcode = "", oCustomer.Custshippostalcode, oWO.Shippostalcode)
    '        oShipment.Shiptocountry = IIf(IsDBNull(oWO.Shipcountry) Or oWO.Shipcountry = "", oCustomer.Custshipcountry, oWO.Shipcountry)
    '        oShipment.Workordernumber = vNum
    '        oShipment.EndEdit()
    '        oShipment.Save()
    '        vShipmentNum = oShipment.Shipmentnumber
    '        vCustomerPO = oShipment.Customerpo
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Exit Sub
    '    End Try

    '    'get WorkOrderItem records - aggregated and sorted by type
    '    da.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
    '    da.Fill(dt, vNum)

    '    'set qty to zero for those items not yet picked for shipping of this work order
    '    dt.Columns("QtyContainers").ReadOnly = False
    '    For Each dr As DataRow In dt
    '        If IsDBNull(dr.Item("ItemStatus")) Then
    '            dr.Item("QtyContainers") = 0
    '        Else
    '            Select Case dr.Item("ITEMSTATUS")
    '                Case "PICKED"
    '                Case "SHIPPED"
    '                    dr.Item("QtyContainers") = -1
    '                Case Else
    '                    dr.Item("QtyContainers") = 0
    '            End Select
    '        End If
    '        'now add the item as a new shipment item

    '        vProductID = IIf(IsDBNull(dr.Item("ProductID")), 0, dr.Item("ProductID"))
    '        vQtyContainers = IIf(IsDBNull(dr.Item("QtyContainers")), 0, dr.Item("QtyContainers"))
    '        vLotNumber = IIf(IsDBNull(dr.Item("LotNumber")), "", dr.Item("LotNumber"))
    '        vBillable = IIf(IsDBNull(dr.Item("Billable")), 1, dr.Item("Billable"))
    '        If dr.Item("QtyContainers") <> -1 Then
    '            createShipmentItem(vShipmentNum, vProductID, vQtyContainers, vLotNumber, vCustomerPO, vBillable, dr.Item("WorkOrderItemNumber"))
    '        End If

    '    Next

    '    'at this point the shipping records are complete
    '    'we now need to update the inventory items to change status to shipped and add shipment number and date

    '    str = "update invItem set itemstatus = 'SHIPPED', Shippeddate = '" & vShipDate.ToShortDateString & "', shipmentnumber = " & vShipmentNum.ToString & " from Invitem, Workorderitem where InvItem.invitemnumber = workorderitem.invitemnumber and workorderitem.workordernumber = " & vNum.ToString & " and invItem.itemstatus = 'PICKED'"
    '    Try
    '        sqlcnn.Open()
    '        cmd = New SqlClient.SqlCommand(str, sqlcnn)
    '        cmd.ExecuteNonQuery()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        sqlcnn.Close()
    '    End Try

    '    MsgBox("Shipment records completed")

    '    Dim frm As New frmAddEditShipment
    '    'frm.vID = oShipment.Shipmentnumber
    '    frm.vEditType = "EDIT"
    '    frm.ShowDialog()

    '    checkToCloseOrder(vNum)

    '    getPickedWorkOrders()

    'End Sub

    Private Sub createShipmentItem(ByVal vShipmentNumber As Integer, ByVal vProductID As Integer, ByVal vQty As Integer, ByVal vLot As String, ByVal vCustomerPO As String, ByVal vBillable As Integer, ByVal vWorkOrderItemNumber As Integer)

        Dim vStr As String

        Dim oProduct As Product = New Product
        Dim oShipItem As Shipmentdetail = New Shipmentdetail
        Dim oContainer As Container = New Container
        Dim vTareWeight As Integer = 0
        Dim oWOItem As New Workorderitem
        Dim vCustItemID As String = ""

        'Get product record
        If oProduct.LoadByPrimaryKey(vProductID) = False Then
            Exit Sub
        End If

        'Get Workorderitem record
        If oWOItem.LoadByPrimaryKey(vWorkOrderItemNumber) = False Then
            Exit Sub
        End If

        'Look up container record to get tare weights to calculate total weight
        If oContainer.LoadByPrimaryKey(oProduct.Container) Then
            vTareWeight = oContainer.TareWeight
        Else
            vTareWeight = 0
        End If

        oShipItem.AddNew()
        oShipItem.Productid = vProductID
        oShipItem.Productdesc = oProduct.Productdesc
        oShipItem.Batchnumber = vLot
        oShipItem.Classrate = oProduct.Classrate
        oShipItem.Container = oProduct.Container
        oShipItem.Dotdesc = oProduct.Dotdesc
        oShipItem.Hazmatdesc = oProduct.Hazmatdesc
        oShipItem.Qtycontainers = vQty
        oShipItem.Shipmentnumber = vShipmentNumber
        oShipItem.Workorderitemnumber = vWorkOrderItemNumber
        oShipItem.Stdgallons = oProduct.Stdgallons
        oShipItem.Stdweight = oProduct.Stdweight
        oShipItem.Totalweight = ((oProduct.Stdweight.Value + vTareWeight) * vQty)
        oShipItem.Unline = oProduct.Unline
        oShipItem.Ld1 = oProduct.Dotdesc & " " & oProduct.Hazmatdesc
        oShipItem.Ld2 = oProduct.Unline
        'vStr = oProduct.Container & "/" & oProduct.Stdweight.ToString & " LB. " & Trim(oProduct.Productdesc) & " - " & oProduct.Stdgallons.ToString & " gal."
        'vStr = oProduct.Container & "/" & oProduct.Stdweight.ToString & " LB. " & Trim(oProduct.Productdesc) & " - " & oProduct.Units.ToString & " " & oProduct.Uom
        vStr = oProduct.Container & "/" & oProduct.Stdweight.ToString & " LB. " & Trim(oProduct.Productdesc)
        If vCustomerPO <> "" Then
            vStr = vStr & " (PO# " & vCustomerPO & ")"
        End If
        'add Customer Specific Item ID to BOL line
        vCustItemID = IIf(IsDBNull(oWOItem.Custitemid), "", oWOItem.Custitemid)
        If vCustItemID <> "" Then
            vStr = vStr & " [" & vCustItemID & "]"
        End If
        oShipItem.Ld3 = vStr
        oShipItem.Billable = vBillable
        oShipItem.Itemtype = "P"
        oShipItem.EndEdit()
        oShipItem.Save()

    End Sub

    Private Sub btnGetPickedOrders_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGetPickedOrders.ItemClick
        getPickedWorkOrders()
    End Sub

    Private Sub markWorkOrderStatus(vWONum As Integer, vStatus As String)
        Dim oWo As New Workorder
        Try
            If Not oWo.LoadByPrimaryKey(vWONum) Then
                Exit Sub
            End If
            oWo.Orderstatus = vStatus
            oWo.Save()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub checkToCloseOrder(ByVal vNum As Integer)

        Dim oOpenItems As New ViewOpenWorkOrderItemsCollection
        Try
            oOpenItems.Query.Where(oOpenItems.Query.Workordernumber.Equal(vNum))
            oOpenItems.Query.Load()
            If oOpenItems.Count > 0 Then
                'there are open items on the work order - leave status of work order as OPEN
                markWorkOrderStatus(vNum, "IN PROCESS")
            Else
                'there are no open items on the work order - mark it closed
                markWorkOrderStatus(vNum, "COMPLETE")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("There was an error determining if the work order should be marked COMPLETE", MsgBoxStyle.Critical, "Error")
        End Try


        ''vNum = WorkOrderNumber
        'Dim ds1 As New DataSet
        'Dim ds2 As New DataSet
        'Dim vStatus As String = "CLOSED"
        'Dim da1 As SqlClient.SqlDataAdapter = Nothing
        'Dim da2 As SqlClient.SqlDataAdapter = Nothing
        'Dim str1 As String = Nothing
        'Dim str2 As String = Nothing

        ''Step 1 - Get WorkOrderItems into dataset to scan
        'str1 = "SELECT * FROM WorkOrderItem WHERE WorkOrderNumber = " & vNum.ToString
        'Try
        '    da1 = New SqlClient.SqlDataAdapter(str1, sqlcnn)
        '    da1.Fill(ds1, "WORKORDERITEM")
        '    If ds1.Tables(0).Rows.Count <= 0 Then
        '        Exit Sub
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "1 - WorkOrderItems")
        '    Exit Sub
        'End Try

        ''Step 2 - Scan each item in workorder to determine its status
        ''Assume that the WorkOrder should be CLOSED. If an item cannot be determined to be shipped,
        ''then assume WorkOrder is OPEN and set status accordingly.
        'Dim dr As DataRow
        'Dim vItemNum As Integer = 0
        'Dim vProdID As Integer = 0
        'Dim vItemStatus As String = Nothing

        'For Each dr In ds1.Tables(0).Rows
        '    Try
        '        vItemNum = IIf(IsDBNull(dr.Item("InvItemNumber")), 0, dr.Item("InvItemNumber"))
        '        vProdID = IIf(IsDBNull(dr.Item("ProductID")), 0, dr.Item("ProductID"))
        '        Select Case vItemNum
        '            Case 0
        '                If getShippingStatus(vNum, vProdID) <> "SHIPPED" Then
        '                    'item has not been shipped, workorder should remain open
        '                    'set orderstatus to OPEN and exit loop - we're done here
        '                    vStatus = "OPEN"
        '                End If
        '            Case Else
        '                If getItemStatus(vItemNum) <> "SHIPPED" Then
        '                    'item has not been shipped, workorder should remain open
        '                    'set orderstatus to OPEN and exit loop - we're done here
        '                    vStatus = "OPEN"
        '                End If
        '        End Select
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        'Next

        ''Step 3 - Update WorkOrderStatus with vStatus value
        'str1 = "UPDATE WorkOrder SET OrderStatus = '" & vStatus & "' WHERE WorkOrderNumber = " & vNum.ToString
        'Dim cmd As SqlClient.SqlCommand
        'Try
        '    sqlcnn.Open()
        '    cmd = New SqlClient.SqlCommand(str1, sqlcnn)
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Updating Order Status")
        'Finally
        '    sqlcnn.Close()
        'End Try

        'If vStatus = "CLOSED" Then
        '    MsgBox("WorkOrder# " & vNum.ToString & " is now CLOSED", MsgBoxStyle.Information, "Order is Closed")
        'Else
        '    MsgBox("WorkOrder# " & vNum.ToString & " will remain OPEN, as there are items that have not shipped, or their shipping status cannot be determined", MsgBoxStyle.Information, "Order is OPEN")
        'End If

    End Sub

    'Private Function getShippingStatus(ByVal vNum As Integer, ByVal vProdID As Integer) As String

    '    Dim vOrdered As Integer = 0
    '    Dim vShipped As Integer = 0
    '    Dim vRemain As Integer = 0
    '    Dim str As String = Nothing
    '    Dim cmd As SqlClient.SqlCommand = Nothing

    '    sqlcnn.Close()
    '    Try
    '        str = "SELECT SUM(qtyContainers) as TotalOrdered FROM WORKORDERITEM WHERE WorkOrderNumber = " & vNum.ToString & " AND ProductID = " & vProdID.ToString
    '        sqlcnn.Open()
    '        cmd = New SqlClient.SqlCommand(str, sqlcnn)
    '        vOrdered = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "GetShippingStatus - Qty Ordered")
    '        Return "UNKNOWN"
    '    Finally
    '        sqlcnn.Close()
    '    End Try

    '    Try
    '        str = "select sum(b.QtyContainers) as totalshipped from Shipment a, ShipmentDetail b where a.ShipmentNumber = b.ShipmentNumber and a.WorkOrderNumber = " & vNum.ToString & " and b.ProductID = " & vProdID.ToString
    '        sqlcnn.Open()
    '        cmd = New SqlClient.SqlCommand(str, sqlcnn)
    '        vShipped = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "GetShippingStatus - Qty Shipped")
    '        Return "UNKNOWN"
    '    Finally
    '        sqlcnn.Close()
    '    End Try

    '    vRemain = vOrdered - vShipped
    '    If vRemain <= 0 Then
    '        Return "SHIPPED"
    '    Else
    '        Return "UNKNOWN"
    '    End If


    'End Function

    'Private Function getItemStatus(ByVal vItemNum As Integer) As String

    '    Dim vStatus As String = "UNKNOWN"
    '    Dim str As String = Nothing
    '    Dim cmd As SqlClient.SqlCommand = Nothing

    '    sqlcnn.Close()
    '    Try
    '        str = "SELECT itemStatus FROM INVITEM WHERE InvItemNumber = " & vItemNum.ToString
    '        sqlcnn.Open()
    '        cmd = New SqlClient.SqlCommand(str, sqlcnn)
    '        vStatus = IIf(IsDBNull(cmd.ExecuteScalar), "UNKNOWN", cmd.ExecuteScalar)
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "getItemStatus")
    '        Return "UNKNOWN"
    '    Finally
    '        sqlcnn.Close()
    '    End Try

    '    Return vStatus

    'End Function

    Private Sub btnReportProductsShipped_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReportProductsShipped.ItemClick

        Dim sdate As DateTime
        Dim edate As DateTime

        sdate = eReportStartDate.EditValue
        edate = eReportEndDate.EditValue

        Dim rpt As New rptProductsShipped(sdate, edate)
        rpt.RptTitle.Text = "PRODUCTS SHIPPED FROM " & sdate.ToShortDateString & " TO " & edate.ToShortDateString
        rpt.ShowPreview()

    End Sub

    Private Sub btnAddNewLogisticsProvider_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewLogisticsProvider.ItemClick
        addNewLogisticsProvider()
    End Sub

    Private Sub btnEditLogisticsProvider_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditLogisticsProvider.ItemClick
        editLogisticsProvider()
    End Sub

    Private Sub btnDeleteLogisticsProvider_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteLogisticsProvider.ItemClick
        deleteLogisticsProvider()
    End Sub

    Private Sub editLogisticsProvider()
        Dim frm As New frmAddEditLogisticsProvider
        frm.vID = Me.bsLogistics.Current.LogisticsID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        LoadLogisticsProviders()
    End Sub

    Private Sub addNewLogisticsProvider()
        Dim frm As New frmAddEditLogisticsProvider
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        vResult = frm.ShowDialog()
        LoadLogisticsProviders()
    End Sub

    Private Sub deleteLogisticsProvider()
        Dim str As String
        str = "Are you sure you want to delete the selected Logistics Provider: " & bsLogistics.Current.LogisticsName & "?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Dim oLog As Logistics
            oLog = New Logistics
            With oLog
                .LoadByPrimaryKey(bsLogistics.Current.LogisticsID)
                .MarkAsDeleted()
                .Save()
            End With
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        LoadLogisticsProviders()
    End Sub

    Private Sub rbtnGetShipments_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetShipments.ItemClick
        getShipmentInfo()
    End Sub

    Private Sub rbtnLoadCarrierData_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnLoadCarrierData.ItemClick
        loadCarrierList()
    End Sub

    Private Sub rbtnLoadLogisticsData_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnLoadLogisticsData.ItemClick
        LoadLogisticsProviders()
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

    Private Sub rbtnMergeShipments_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMergeShipments.ItemClick
        'open form for user to enter two shipment numbers to be merged together
        Dim frm As New frmMergeLoads
        frm.ShowDialog()

        getShipmentInfo()
    End Sub
End Class
