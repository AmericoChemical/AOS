Imports AOS.BusinessObjects
Imports DevExpress.XtraGrid.Views.Grid

Public Class viewSalesCustomers
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oCustomerCollection As CustomerCollection = Nothing
    Dim oSalespersons As SalespersonCollection = Nothing
    Dim oCustomerList As CustomerCollection = Nothing
    Dim oProductList As ProductCollection = Nothing
    Dim oPriceLists As ViewPriceListDataCollection = Nothing
    Dim oAssignments As CustomerassignmentCollection = Nothing
    Dim oCommissions As ViewCommissionAuditAnalysisCollection = Nothing
    Dim oInvoices As InvoiceCollection = Nothing
    Dim oShipments As ShipmentCollection = Nothing
    Dim oShippedItems As ShipmentdetailCollection = Nothing
    Dim oCustPmts As CustomerpaymentCollection = Nothing
    Dim oInvPmts As InvoicepaymentCollection = Nothing
    Dim oInvoice As Invoice = Nothing
    Dim oCarriers As CarrierCollection
    Dim oBulkCarriers As CarrierCollection
    Dim oLogistics As LogisticsCollection
    Dim oSalesList As SalespersonCollection
    Dim oSalesYears As ViewSalesYearsCollection
    Dim oCustomerLookupList As ViewCustomerLookupCollection

    Dim vInvoiceStatus As String = "PENDING"
    Dim vCommFilter As String = "PENDING"
    Dim vSalesFilter As String = "ACTIVE"

#Region " FORM STARTUP / LOAD "
    Private Sub viewSalesCustomers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()
        ' setRibbonOptions(vCurrentUserSecurityLevel)
        setRibbonOptionsSecurity(vCurrentUserID)
        ' Call Security Timer to start hiding/showing Groups and Functions based on the security settings 
        StartSecurityTimer()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupLists()
        loadCustomers()
        loadSalespersons(vSalesFilter)
        'loadCustomerList()
        loadProductList()
        loadPriceLists(luCustomerList.EditValue, "ACTIVE")
        'loadAssignments(bsSalesperson.Current.SalespersonID)
        loadCommissions(luActiveSalesPerson.EditValue, vCommFilter)
        loadInvoices(vInvoiceStatus)
        'loadCompleteShipments()
        loadCustomerPayments(eCustomerLookup.EditValue)
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

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        loadLookupLists()
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
            vNum = CInt(Me.RibbonControl1.SelectedPage.Name.Substring(10, Len(Me.RibbonControl1.SelectedPage.Name) - 10))
        End If
        Dim ctlPage As New DevExpress.XtraEditors.PanelControl
        ctlPage = Me.WorkPanelsHolder.Controls("RibbonPanelControl" & vNum.ToString)
        If Not ctlPage Is Nothing Then
            ctlPage.BringToFront()
        End If
    End Sub

    Private Sub btnAddCustomer_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddCustomer.ItemClick
        addCustomer()
    End Sub

    Private Sub btnDeleteCustomer_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteCustomer.ItemClick
        deleteCustomer()
    End Sub

    Private Sub btnEditCustomer_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditCustomer.ItemClick
        editCustomer()
    End Sub

    Private Sub btnAddSalesperson_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddSalesperson.ItemClick
        addSalesperson()
    End Sub

    Private Sub btnDeleteSalesperson_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteSalesperson.ItemClick
        deleteSalesperson()
    End Sub

    Private Sub btnEditSalesperson_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditSalesperson.ItemClick
        editSalesperson()
    End Sub

    Private Sub btnAddPriceListItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddPriceListItem.ItemClick
        addPriceListItem()
    End Sub

    Private Sub btnDeletePriceListItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeletePriceListItem.ItemClick
        deletePriceListItem()
    End Sub

    Private Sub btnEditPriceListItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPriceListItem.ItemClick
        editPriceListItem()
    End Sub

    Private Sub btnAddAssignment_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddAssignment.ItemClick
        addAssignment()
    End Sub

    Private Sub btnDeleteAssignment_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteAssignment.ItemClick
        deleteAssignment()
    End Sub

    Private Sub btnEditAssignment_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditAssignment.ItemClick
        editAssignment()
    End Sub

#End Region

#Region " REFERENCE DATA "
    Private Sub loadLookupLists()

        oCarriers = New CarrierCollection
        oCarriers.LoadAll()
        oCarriers.Sort = "CARRIERNAME"
        bsCarriers.DataSource = oCarriers

        oBulkCarriers = New CarrierCollection
        oBulkCarriers.LoadAll()
        oBulkCarriers.Sort = "CARRIERNAME"
        bsBulkCarriers.DataSource = oBulkCarriers

        oLogistics = New LogisticsCollection
        oLogistics.LoadAll()
        oLogistics.Sort = "LOGISTICSNAME"
        bsLogistics.DataSource = oLogistics

        oSalesList = New SalespersonCollection
        oSalesList.LoadAll()
        bsSalespersonList.DataSource = oSalesList
        bsSalesPersonList2.DataSource = oSalesList
        bsSalesPersonList3.DataSource = oSalesList

        oSalesYears = New ViewSalesYearsCollection
        oSalesYears.LoadAll()
        oSalesYears.Sort = "YEAR"
        bsSalesYears.DataSource = oSalesYears

        oCustomerLookupList = New ViewCustomerLookupCollection
        oCustomerLookupList.LoadAll()
        oCustomerLookupList.Sort = "CUSTNAME, CUSTID"
        bsCustomerLookupList.DataSource = oCustomerLookupList

        oCustomerList = New CustomerCollection
        oCustomerList.LoadAll()
        oCustomerList.Sort = "CUSTNAME ASC"
        bsCustomerList.DataSource = oCustomerList

    End Sub

    Private Sub loadCustomers()
        oCustomerCollection = New CustomerCollection
        oCustomerCollection.LoadAll()
        oCustomerCollection.Filter = ""
        oCustomerCollection.Sort = "CUSTNAME ASC"
        bsCustomers.DataSource = oCustomerCollection
        'add list to Customer Selector field on Sales History Page as well
        bsCustomerSelector.DataSource = oCustomerCollection
        Me.grCustomers.DataSource = bsCustomers
        Me.grCustomers.Refresh()
        If oCustomerCollection.Count <= 0 Then
            btnEditCustomer.Enabled = False
            btnDeleteCustomer.Enabled = False
        Else
            btnEditCustomer.Enabled = True
            btnDeleteCustomer.Enabled = True
        End If
    End Sub

    Private Sub loadSalespersons(vFilter As String)
        oSalespersons = New SalespersonCollection
        oSalespersons.Query.Where(oSalespersons.Query.Status.Equal(vFilter))
        oSalespersons.Query.Load()
        oSalespersons.Sort = "Salespersonlastname, Salespersonfirstname"
        bsSalesperson.DataSource = oSalespersons
        'Me.grSalesperson.DataSource = bsSalesperson
        'Me.grSalesperson.Refresh()
        'If oSalespersons.Count <= 0 Then
        '    btnEditSalesperson.Enabled = False
        '    btnDeleteSalesperson.Enabled = False
        'Else
        '    btnEditSalesperson.Enabled = True
        '    btnDeleteSalesperson.Enabled = True
        'End If
    End Sub

    Private Sub loadCustomerList()
        oCustomerList = New CustomerCollection
        oCustomerList.LoadAll()
        oCustomerList.Sort = "CUSTNAME ASC"
        bsCustomerList.DataSource = oCustomerList
    End Sub

    Private Sub loadProductList()
        oProductList = New ProductCollection
        oProductList.LoadAll()
        bsProducts.DataSource = oProductList
        bsProducts.ResetBindings(False)
    End Sub

#End Region

#Region " CUSTOMERS "

    Private Sub rbtnUpdateCustomers_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUpdateCustomers.ItemClick
        loadCustomers()
    End Sub

    Private Sub editCustomer()
        Dim frm As New frmAddEditCustomer
        frm.vID = Me.bsCustomers.Current.CustID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadCustomers()
    End Sub

    Private Sub addCustomer()
        Dim frm As New frmAddEditCustomer
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        vResult = frm.ShowDialog()
        loadCustomers()
    End Sub

    Private Sub deleteCustomer()
        Dim str As String
        str = "Are you sure you want to delete " & bsCustomers.Current.CustName & "?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim vCanDelete As Boolean = True

        Dim oWOs As New WorkorderCollection
        oWOs.Query.Where(oWOs.Query.Custid.Equal(bsCustomers.Current.CustID))
        If oWOs.Query.Load Then
            vCanDelete = False
        End If

        Dim oInvs As New InvoiceCollection
        oInvs.Query.Where(oInvs.Query.Custid.Equal(bsCustomers.Current.CustID))
        If oInvs.Query.Load Then
            vCanDelete = False
        End If

        If Not vCanDelete Then
            MsgBox("There is activity already recorded in the database for this customer. The Customer will be marked as INACTIVE and not deleted.", MsgBoxStyle.Information, "Warning - Cannot delete record")
            'Mark Customer Record as INACTIVE
            Dim oCust As New Customer
            oCust.LoadByPrimaryKey(bsCustomers.Current.custid)
            oCust.Isactive = 0
            oCust.Save()
        Else
            Try
                Dim oCustomer As Customer
                oCustomer = New Customer
                oCustomer.LoadByPrimaryKey(bsCustomers.Current.CUSTID)
                oCustomer.MarkAsDeleted()
                oCustomer.Save()
            Catch ex As Exception
                MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
            End Try
        End If

        loadCustomers()
    End Sub


#End Region

#Region " COMPLETED SHIPMENTS "

    'Private Sub loadCompleteShipments()
    '    oShipments = New ShipmentCollection
    '    oShipments.Query.Where(oShipments.Query.Shipmentstatus.Equal("OPEN"))
    '    oShipments.Query.Load()
    '    bsShipments.DataSource = oShipments
    '    Me.grShipments.DataSource = bsShipments
    '    Me.grShipments.Refresh()

    'End Sub

    'Private Sub btnRefreshCompleteShipments_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefreshCompleteShipments.ItemClick
    '    loadCompleteShipments()
    'End Sub

    'Private Sub btnCreateInvoice_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreateInvoice.ItemClick
    '    If bsShipments.Count <= 0 Then
    '        Exit Sub
    '    End If
    '    createInvoice(bsShipments.Current.shipmentnumber)
    'End Sub

    'Private Sub createInvoice(ByVal vShip As Integer)

    '    Dim str As String = "Are you sure you want to create an Invoice for billable items on Shipment# " & vShip.ToString & "?"
    '    If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    Dim vShipmentNum As Integer = vShip
    '    Dim vInvoiceDate As Date = getUserDate("Enter Invoice Date")

    '    Dim oInvoice As Invoice = New Invoice
    '    Dim oShipment As Shipment = Nothing
    '    Dim ocustomer As Customer = Nothing

    '    'fetch shipment record
    '    oShipment = New Shipment
    '    If oShipment.LoadByPrimaryKey(vShipmentNum) = False Then
    '        MsgBox("No shipment record retrieved for invoice creation", MsgBoxStyle.Critical, "Error - No record")
    '        Exit Sub
    '    End If

    '    'fetch customer record
    '    ocustomer = New Customer
    '    ocustomer.LoadByPrimaryKey(oShipment.Custid)

    '    'fetch shippeditems records
    '    oShippedItems = New ShipmentdetailCollection
    '    oShippedItems.Query.Where(oShippedItems.Query.Shipmentnumber.Equal(vShipmentNum), oShippedItems.Query.Billable.Equal(1))
    '    oShippedItems.Query.Load()
    '    If oShippedItems.Count <= 0 Then
    '        If MsgBox("No billable items were found for this shipment. Would you like to close this shipment?", MsgBoxStyle.Critical, "No Billable Items") = MsgBoxResult.Yes Then
    '            oShipment.Shipmentstatus = "CLOSED"
    '            oShipment.Save()
    '        End If
    '        loadCompleteShipments()
    '        Exit Sub
    '    End If

    '    'Create new invoice record
    '    oInvoice.AddNew()
    '    oInvoice.Invoicedate = vInvoiceDate
    '    oInvoice.Invoicestatus = "PENDING"
    '    oInvoice.Custid = oShipment.Custid
    '    oInvoice.Billaddress1 = ocustomer.Custbilladdress1
    '    oInvoice.Billaddress2 = ocustomer.Custbilladdress2
    '    oInvoice.Billcity = ocustomer.Custbillcity
    '    oInvoice.Billstateprov = ocustomer.Custbillstateprov
    '    oInvoice.Billpostalcode = ocustomer.Custbillpostalcode
    '    oInvoice.Billcountry = ocustomer.Custbillcountry
    '    oInvoice.Billcontact = ocustomer.Custbillcontact
    '    oInvoice.Shipaddress1 = oShipment.Shiptoaddress1
    '    oInvoice.Shipaddress2 = oShipment.Shiptoaddress2
    '    oInvoice.Shipcity = oShipment.Shiptocity
    '    oInvoice.Shipstateprov = oShipment.Shiptostateprov
    '    oInvoice.Shippostalcode = oShipment.Shiptopostalcode
    '    oInvoice.Shipcountry = oShipment.Shiptocountry
    '    oInvoice.Shipcontact = oShipment.Shiptocontact
    '    oInvoice.Customerpo = oShipment.Customerpo
    '    oInvoice.Fob = oShipment.Fob
    '    oInvoice.Freightcarrier = oShipment.Freightcarrier
    '    oInvoice.EndEdit()
    '    oInvoice.Save()

    '    Dim vInvoiceNum As Integer = oInvoice.Invoicenumber

    '    'Create new invoice item records from shipped items collection
    '    For Each shippedItem As Shipmentdetail In oShippedItems
    '        If Not IsDBNull(shippedItem.Workorderitemnumber) Then
    '            If shippedItem.Workorderitemnumber > 0 Then
    '                If Not createInvoiceItemFromWorkOrderItem(shippedItem.Workorderitemnumber, oInvoice.Invoicenumber, shippedItem.Qtycontainers, oShipment.Custid, shippedItem.Productid) Then
    '                    MsgBox("Could not create an invoice item for Work Order Item Number " & shippedItem.Workorderitemnumber, MsgBoxStyle.Critical, "Error - Invoice Failed")
    '                    Exit Sub
    '                End If
    '            Else
    '                If Not createInvoiceItem(oInvoice.Invoicenumber, oShipment.Custid, shippedItem.Productid, shippedItem.Qtycontainers) Then
    '                    MsgBox("Could not create an invoice item for " & shippedItem.Productdesc, MsgBoxStyle.Critical, "Error - Invoice Failed")
    '                    Exit Sub
    '                End If
    '            End If
    '        Else
    '            If Not createInvoiceItem(oInvoice.Invoicenumber, oShipment.Custid, shippedItem.Productid, shippedItem.Qtycontainers) Then
    '                MsgBox("Could not create an invoice item for " & shippedItem.Productdesc, MsgBoxStyle.Critical, "Error - Invoice Failed")
    '                Exit Sub
    '            End If
    '        End If
    '    Next

    '    'determine invoice subtotal
    '    oInvoice.BeginEdit()
    '    oInvoice.Subtotal = getInvoiceItemsTotal(oInvoice.Invoicenumber)
    '    'determine invoice sales tax
    '    oInvoice.Salestax = oInvoice.Subtotal * getSalesTaxRate()
    '    'determine invoice totals
    '    oInvoice.Total = oInvoice.Subtotal + oInvoice.Salestax
    '    oInvoice.EndEdit()
    '    oInvoice.Save()

    '    'update the status of the shipment so it disappears from the complete shipment list
    '    oShipment.Shipmentstatus = "INVOICED"
    '    oShipment.EndEdit()
    '    oShipment.Save()

    '    'reload data grids
    '    vInvoiceStatus = "PENDING"
    '    loadInvoices(vInvoiceStatus)
    '    loadCompleteShipments()
    '    editInvoice(oInvoice.Invoicenumber)

    'End Sub

    'Private Sub createInvoiceFromWorkOrder(ByVal vWONum As Integer)

    '    Dim str As String = "Are you sure you want to create an Invoice for Work Order# " & vWONum.ToString & "?"
    '    If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    Dim vInvoiceDate As Date = getUserDate("Enter Invoice Date")

    '    Dim oInvoice As Invoice = New Invoice
    '    Dim ocustomer As Customer = Nothing
    '    Dim oWorkOrder As Workorder = Nothing
    '    Dim oWOItems As WorkorderitemCollection = Nothing


    '    'fetch Work Order record
    '    oWorkOrder = New Workorder
    '    If oWorkOrder.LoadByPrimaryKey(vWONum) = False Then
    '        MsgBox("No Work Order record retrieved for invoice creation", MsgBoxStyle.Critical, "Error - No record")
    '        Exit Sub
    '    End If

    '    'fetch customer record
    '    ocustomer = New Customer
    '    ocustomer.LoadByPrimaryKey(oWorkOrder.Custid)

    '    'fetch shippeditems records
    '    oWOItems = New WorkorderitemCollection
    '    oWOItems.Query.Where(oWOItems.Query.Workordernumber.Equal(vWONum))
    '    oWOItems.Query.Load()
    '    If oWOItems.Count <= 0 Then
    '        If MsgBox("No Work Order items were found for this Work Order. ", MsgBoxStyle.Critical, "No Work Order Items") = MsgBoxResult.Yes Then
    '            Exit Sub
    '        End If
    '    End If

    '    'Create new invoice record
    '    oInvoice.AddNew()
    '    oInvoice.Invoicedate = vInvoiceDate
    '    oInvoice.Invoicestatus = "PENDING"
    '    oInvoice.Custid = oWorkOrder.Custid
    '    oInvoice.Billaddress1 = ocustomer.Custbilladdress1
    '    oInvoice.Billaddress2 = ocustomer.Custbilladdress2
    '    oInvoice.Billcity = ocustomer.Custbillcity
    '    oInvoice.Billstateprov = ocustomer.Custbillstateprov
    '    oInvoice.Billpostalcode = ocustomer.Custbillpostalcode
    '    oInvoice.Billcountry = ocustomer.Custbillcountry
    '    oInvoice.Billcontact = ocustomer.Custbillcontact
    '    oInvoice.Shipaddress1 = oWorkOrder.Shipaddress1
    '    oInvoice.Shipaddress2 = oWorkOrder.Shipaddress2
    '    oInvoice.Shipcity = oWorkOrder.Shipcity
    '    oInvoice.Shipstateprov = oWorkOrder.Shipstateprov
    '    oInvoice.Shippostalcode = oWorkOrder.Shippostalcode
    '    oInvoice.Shipcountry = oWorkOrder.Shipcountry
    '    oInvoice.Customerpo = oWorkOrder.Customerpo
    '    oInvoice.Fob = oWorkOrder.Fob
    '    oInvoice.Freightcarrier = oWorkOrder.Freightcarrier
    '    oInvoice.EndEdit()
    '    oInvoice.Save()

    '    Dim vInvoiceNum As Integer = oInvoice.Invoicenumber

    '    'Create new invoice item records from Work Order items collection
    '    For Each woItem As Workorderitem In oWOItems
    '        If Not createInvoiceItemFromWorkOrderItemForConsignmentWorkOrders(woItem.Workorderitemnumber, oInvoice.Invoicenumber, woItem.Qty, oWorkOrder.Custid, woItem.Productid) Then
    '            MsgBox("Could not create an invoice item for Work Order Item Number " & woItem.Workorderitemnumber, MsgBoxStyle.Critical, "Error - Invoice Failed")
    '            Exit Sub
    '        End If
    '    Next

    '    'determine invoice subtotal
    '    oInvoice.BeginEdit()
    '    oInvoice.Subtotal = getInvoiceItemsTotal(oInvoice.Invoicenumber)
    '    'determine invoice sales tax
    '    oInvoice.Salestax = oInvoice.Subtotal * getSalesTaxRate()
    '    'determine invoice totals
    '    oInvoice.Total = oInvoice.Subtotal + oInvoice.Salestax
    '    oInvoice.EndEdit()
    '    oInvoice.Save()

    '    'update the status of the shipment so it disappears from the complete shipment list
    '    oWorkOrder.Orderstatus = "COMPLETE"
    '    oWorkOrder.EndEdit()
    '    oWorkOrder.Save()

    '    'reload data grids
    '    vInvoiceStatus = "PENDING"
    '    loadInvoices(vInvoiceStatus)
    '    loadCompleteShipments()
    '    editInvoice(oInvoice.Invoicenumber)

    'End Sub

    'Private Function getSalesTaxRate() As Double
    '    Dim oParms As New Sysparameters
    '    oParms.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
    '    If oParms.LoadByPrimaryKey(1) Then
    '        Return oParms.Defaultsalestaxrate
    '    Else
    '        Return 0
    '    End If
    'End Function
    'Private Function getInvoiceItemsTotal(ByVal vInvNum As Integer) As Double
    '    Dim str As String = Nothing
    '    Dim cmd As SqlClient.SqlCommand = Nothing
    '    Dim vResult As Double = 0.0
    '    Try
    '        str = "SELECT SUM(EXTPRICE) FROM INVOICEITEM WHERE INVOICENUMBER = " & vInvNum.ToString
    '        cmd = New SqlClient.SqlCommand(str, sqlcnn)
    '        sqlcnn.Open()
    '        vResult = cmd.ExecuteScalar
    '    Catch ex As Exception
    '        MsgBox("Error in calculating Invoice Subtotals for Invoice # " & vInvNum.ToString, MsgBoxStyle.Critical, "Error - No Subtotal")
    '        Return 0
    '    Finally
    '        sqlcnn.Close()
    '    End Try
    '    sqlcnn.Close()
    '    Return vResult
    'End Function

    'Private Function createInvoiceItemFromWorkOrderItem(ByVal vWOItemNum As Integer, ByVal vInvNum As Integer, ByVal vQty As Integer, ByVal vCustID As Integer, ByVal vProdID As Integer) As Boolean

    '    'in creating invoice items from work order items, we make the following assumptions:
    '    '1) all quantities passed through are containers, not units
    '    '2) all item costs are carried forward from the work order, and not recalculated

    '    Dim oWOItem As Workorderitem = Nothing
    '    Dim oProduct As Product = Nothing
    '    Dim oPriceList As Pricelist = Nothing
    '    Dim oItemList As Invoiceitem = Nothing
    '    Dim vPriceID As Integer = 0

    '    'fetch workorderitem record to get most of the data for the invoiceitem record
    '    oWOItem = New Workorderitem
    '    If oWOItem.LoadByPrimaryKey(vWOItemNum) = False Then
    '        MsgBox("Cannot retrieve Work Order Item record " & vWOItemNum.ToString & ".", MsgBoxStyle.Critical, "Error - No Work Order Item Record")
    '        Return False
    '    End If

    '    'lookup product record
    '    oProduct = New Product
    '    If Not oProduct.LoadByPrimaryKey(oWOItem.Productid) Then
    '        MsgBox("Error retrieving Product Information", MsgBoxStyle.Critical, "Error - No product found")
    '        Return False
    '    End If

    '    'lookup product in pricelist table to determine if item is taxable
    '    oPriceList = New Pricelist
    '    oPriceList.Query.Where(oPriceList.Query.Productid.Equal(vProdID), oPriceList.Query.Custid.Equal(vCustID), oPriceList.Query.Uom.Equal(oWOItem.Uom))
    '    If Not oPriceList.Query.Load() Then
    '        'could not find price list record based on product/customer/uom
    '        Dim frm As New frmViewPriceListRecords
    '        frm.vProductID = oProduct.Productid
    '        frm.vCustomerID = vCustID
    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            vPriceID = frm.oPrice.Pricelistid
    '        End If
    '    Else
    '        vPriceID = oPriceList.Pricelistid
    '    End If

    '    If vPriceID = 0 Then
    '        Return False
    '    End If

    '    oPriceList = New Pricelist
    '    oPriceList.LoadByPrimaryKey(vPriceID)

    '    'create invoice item object
    '    oItemList = New Invoiceitem
    '    oItemList.Invoicenumber = vInvNum
    '    oItemList.Productid = oWOItem.Productid
    '    oItemList.Productdesc = oProduct.Productdesc
    '    oItemList.Container = oWOItem.Container
    '    oItemList.Units = oWOItem.Units
    '    oItemList.Uom = oWOItem.Uom
    '    oItemList.Unitcost = oWOItem.Unitcost
    '    oItemList.Taxable = oPriceList.Taxable

    '    If oPriceList.Unitorcontainer = "C" Then
    '        oItemList.Quantity = vQty                                   'pull container qty from shipment item
    '        oItemList.Itemprice = oPriceList.Unitprice * oItemList.Units    'create a container price
    '        oItemList.Unitcost = oItemList.Unitcost * oItemList.Units           'create a container cost
    '        oItemList.Unitorcontainer = "C"
    '    Else 'oPriceList.Unitorcontainer is blank or U or some other value
    '        oItemList.Quantity = vQty * oItemList.Units                     'convert quantity to total units
    '        oItemList.Itemprice = oPriceList.Unitprice                  'pull item price for product for customer
    '        oItemList.Unitorcontainer = "U"                             'default to Unit pricing method
    '    End If

    '    oItemList.Extcost = oItemList.Quantity * oItemList.Unitcost
    '    oItemList.Extprice = oItemList.Quantity * oItemList.Itemprice
    '    oItemList.Grossprofit = oItemList.Extprice - oItemList.Extcost
    '    oItemList.EndEdit()
    '    oItemList.Save()

    '    Return True

    'End Function

    'Private Function createInvoiceItemFromWorkOrderItemForConsignmentWorkOrders(ByVal vWOItemNum As Integer, ByVal vInvNum As Integer, ByVal vQty As Integer, ByVal vCustID As Integer, ByVal vProdID As Integer) As Boolean

    '    'in creating invoice items from work order items, we make the following assumptions:
    '    '1) all item costs are carried forward from the work order, and not recalculated

    '    Dim oWOItem As Workorderitem = Nothing
    '    Dim oProduct As Product = Nothing
    '    Dim oPriceList As Pricelist = Nothing
    '    Dim oItemList As Invoiceitem = Nothing
    '    Dim vPriceID As Integer = 0

    '    'fetch workorderitem record to get most of the data for the invoiceitem record
    '    oWOItem = New Workorderitem
    '    If oWOItem.LoadByPrimaryKey(vWOItemNum) = False Then
    '        MsgBox("Cannot retrieve Work Order Item record " & vWOItemNum.ToString & ".", MsgBoxStyle.Critical, "Error - No Work Order Item Record")
    '        Return False
    '    End If

    '    'lookup product record
    '    oProduct = New Product
    '    If Not oProduct.LoadByPrimaryKey(oWOItem.Productid) Then
    '        MsgBox("Error retrieving Product Information", MsgBoxStyle.Critical, "Error - No product found")
    '        Return False
    '    End If

    '    'lookup product in pricelist table to determine if item is taxable
    '    oPriceList = New Pricelist
    '    oPriceList.Query.Where(oPriceList.Query.Productid.Equal(vProdID), oPriceList.Query.Custid.Equal(vCustID), oPriceList.Query.Uom.Equal(oWOItem.Uom))
    '    If Not oPriceList.Query.Load() Then
    '        'could not find price list record based on product/customer/uom
    '        Dim frm As New frmViewPriceListRecords
    '        frm.vProductID = oProduct.Productid
    '        frm.vCustomerID = vCustID
    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            vPriceID = frm.oPrice.Pricelistid
    '        End If
    '    Else
    '        vPriceID = oPriceList.Pricelistid
    '    End If

    '    If vPriceID = 0 Then
    '        Return False
    '    End If

    '    oPriceList = New Pricelist
    '    oPriceList.LoadByPrimaryKey(vPriceID)

    '    'create invoice item object
    '    oItemList = New Invoiceitem
    '    oItemList.Invoicenumber = vInvNum
    '    oItemList.Productid = oWOItem.Productid
    '    oItemList.Productdesc = oProduct.Productdesc
    '    oItemList.Container = oWOItem.Container
    '    oItemList.Units = oWOItem.Units
    '    oItemList.Uom = oWOItem.Uom
    '    oItemList.Unitcost = oWOItem.Unitcost
    '    oItemList.Taxable = oPriceList.Taxable
    '    oItemList.Unitorcontainer = oWOItem.Unitorcontainer
    '    oItemList.Quantity = vQty

    '    If oItemList.Unitorcontainer = "C" Then
    '        oItemList.Itemprice = oPriceList.Unitprice * oItemList.Units    'create a container price
    '        oItemList.Unitcost = oItemList.Unitcost * oItemList.Units           'create a container cost
    '    Else 'oItemList.Unitorcontainer is blank or U or some other value
    '        oItemList.Itemprice = oPriceList.Unitprice                  'pull item price for product for customer
    '    End If

    '    oItemList.Extcost = oItemList.Quantity * oItemList.Unitcost
    '    oItemList.Extprice = oItemList.Quantity * oItemList.Itemprice
    '    oItemList.Grossprofit = oItemList.Extprice - oItemList.Extcost
    '    oItemList.EndEdit()
    '    oItemList.Save()

    '    Return True

    'End Function

    'Private Function createInvoiceItem(ByVal vInvNum As Integer, ByVal vCustID As Integer, ByVal vProdID As Integer, ByVal vQty As Integer) As Boolean

    '    'assume that vQty is a container quantity

    '    Dim oProduct As Product = Nothing
    '    Dim oPriceList As Pricelist = Nothing
    '    Dim oPrices As PricelistCollection = Nothing
    '    Dim oProductCosts As ProductcostCollection = Nothing
    '    Dim oCost As Productcost = Nothing
    '    Dim oItemList As Invoiceitem = Nothing
    '    Dim vPriceID As Integer = 0
    '    Dim vCostID As Integer = 0

    '    'fetch product object for container, units, uom, and product cost information
    '    oProduct = New Product
    '    If oProduct.LoadByPrimaryKey(vProdID) = False Then
    '        MsgBox("The product id " & vProdID.ToString & " was not found", MsgBoxStyle.Critical, "Error - Invalid Product ID")
    '        Return False
    '    End If

    '    oProductCosts = New ProductcostCollection
    '    oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdID))
    '    oProductCosts.Query.Load()
    '    Select Case oProductCosts.Count
    '        Case Is = 1
    '            vCostID = oProductCosts(0).Costrecid
    '        Case Else
    '            Dim frm As New frmViewProductCostRecords
    '            frm.vProductID = vProdID
    '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                vCostID = frm.oCost.Costrecid
    '            End If
    '    End Select

    '    If vCostID = 0 Then
    '        MsgBox("No product costing records were found", MsgBoxStyle.Critical, "Error - No costing record")
    '        Return False
    '    End If
    '    oCost = New Productcost
    '    oCost.LoadByPrimaryKey(vCostID)

    '    'fetch pricing object
    '    oPrices = New PricelistCollection
    '    oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdID), oPrices.Query.Custid.Equal(vCustID))
    '    oPrices.Query.Load()
    '    Select Case oPrices.Count
    '        Case Is = 1
    '            vPriceID = oPrices(0).Pricelistid
    '        Case Else
    '            Dim frm As New frmViewPriceListRecords
    '            frm.vProductID = vProdID
    '            frm.vCustomerID = vCustID
    '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                vPriceID = frm.oPrice.Pricelistid
    '            End If
    '    End Select

    '    If vPriceID = 0 Then
    '        MsgBox("No pricing records found.", MsgBoxStyle.Information, "No Pricing Records")
    '        Exit Function
    '    End If

    '    'fetch pricing object
    '    oPriceList = New Pricelist
    '    If Not oPriceList.LoadByPrimaryKey(vPriceID) Then
    '        MsgBox("No Pricing Records were retrieved", MsgBoxStyle.Critical, "Error - No Pricing Records")
    '        Exit Function
    '    End If

    '    'create invoice item object
    '    oItemList = New Invoiceitem
    '    oItemList.Invoicenumber = vInvNum
    '    oItemList.Productid = vProdID
    '    oItemList.Productdesc = oProduct.Productdesc
    '    oItemList.Container = oProduct.Container
    '    oItemList.Units = oPriceList.Units
    '    oItemList.Uom = oPriceList.Uom
    '    oItemList.Unitcost = oCost.Unitcost
    '    oItemList.Taxable = oPriceList.Taxable

    '    If oPriceList.Unitorcontainer = "C" Then
    '        oItemList.Quantity = vQty                                   'pull container qty from shipment item
    '        oItemList.Itemprice = oPriceList.Unitprice * oItemList.Units    'create a container price
    '        oItemList.Unitcost = oItemList.Unitcost * oItemList.Units           'create a container cost
    '        oItemList.Unitorcontainer = "C"
    '    Else 'oPriceList.Unitorcontainer is blank or U or some other value
    '        oItemList.Quantity = vQty * oItemList.Units                     'convert quantity to total units
    '        oItemList.Itemprice = oPriceList.Unitprice                  'pull item price for product for customer
    '        oItemList.Unitorcontainer = "U"                             'default to Unit pricing method
    '    End If

    '    oItemList.Extcost = oItemList.Quantity * oItemList.Unitcost
    '    oItemList.Extprice = oItemList.Quantity * oItemList.Itemprice
    '    oItemList.Grossprofit = oItemList.Extprice - oItemList.Extcost
    '    oItemList.EndEdit()
    '    oItemList.Save()

    '    Return True

    'End Function


    'Private Sub btnCloseShipment_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCloseShipment.ItemClick
    '    closeShipment(bsShipments.Current.shipmentnumber)
    '    loadCompleteShipments()
    'End Sub

    'Private Sub closeShipment(ByVal vShipmentNum As Integer)
    '    Dim str As String = "Are you sure you want to close Shipment #" & vShipmentNum.ToString & "?  You will not be able to create an Invoice directly from this shipment."
    '    If MsgBox(str, MsgBoxStyle.YesNo, "Confirm - Closing Shipment") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If
    '    Dim oShipment As New Shipment
    '    'fetch shipment record
    '    oShipment = New Shipment
    '    If oShipment.LoadByPrimaryKey(vShipmentNum) = False Then
    '        MsgBox("No shipment record retrieved.", MsgBoxStyle.Critical, "Error - No record")
    '        Exit Sub
    '    End If
    '    oShipment.Shipmentstatus = "CLOSED"
    '    oShipment.Save()
    'End Sub

#End Region

#Region " INVOICES "

    Private Sub loadInvoices(ByVal vInvoiceStatus As String)
        oInvoices = New InvoiceCollection
        If vInvoiceStatus = "ALL" Then
            oInvoices.LoadAll()
        Else
            oInvoices.Query.Where(oInvoices.Query.Invoicestatus.Equal(vInvoiceStatus))
            oInvoices.Query.Load()
        End If
        oInvoices.Sort = "INVOICENUMBER DESC"
        bsInvoices.DataSource = oInvoices
        Me.grInvoices.DataSource = bsInvoices
        Me.grInvoices.Refresh()
        If oInvoices.Count <= 0 Then
            btnEditInvoice.Enabled = False
            btnDeleteInvoice.Enabled = False
        Else
            btnEditInvoice.Enabled = True
            btnDeleteInvoice.Enabled = True
        End If
    End Sub

    Private Sub editInvoice()
        Dim frm As New frmAddEditInvoice
        frm.vInvoiceNum = Me.bsInvoices.Current.InvoiceNumber
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadInvoices(vInvoiceStatus)
    End Sub

    Private Sub editInvoice(ByVal vInvNum As Integer)
        Dim frm As New frmAddEditInvoice
        frm.vInvoiceNum = vInvNum
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadInvoices(vInvoiceStatus)
    End Sub

    Private Sub addInvoice()
        Dim frm As New frmAddEditInvoice
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        vResult = frm.ShowDialog()
        loadInvoices(vInvoiceStatus)
    End Sub

    Private Sub printInvoiceHistoryReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles printInvoiceHistoryReport.ItemClick

        Dim vStart As Date
        Dim vEnd As Date

        If IsDBNull(eHistoryStart.EditValue) Then
            MsgBox("You must first select a Start Date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vStart = eHistoryStart.EditValue
        End If

        If IsDBNull(eHistoryEnd.EditValue) Then
            MsgBox("You must first select an End Date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vEnd = eHistoryEnd.EditValue
        End If

        Dim rpt As New rptInvoiceHistory(vStart, vEnd)
        rpt.ShowPreviewDialog()


    End Sub


    'Private Sub deleteInvoice()

    '    If bsInvoices.Count <= 0 Then
    '        Exit Sub
    '    End If

    '    Dim str As String
    '    str = "Are you sure you want to delete Invoice# " & bsInvoices.Current.InvoiceNumber & "?" & Chr(13) & Chr(13)
    '    str &= "THIS CHANGE CANNOT BE UNDONE!"
    '    If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    Dim vInv As Integer = bsInvoices.Current.invoicenumber

    '    'if payments have been received against this invoice, prevent deletion
    '    Dim oPmts As New InvoicepaymentCollection
    '    oPmts.Query.Where(oPmts.Query.Invoicenumber.Equal(vInv))
    '    If oPmts.Query.Load Then
    '        MsgBox("This invoice already has payments recorded against it and can not be deleted.", MsgBoxStyle.Critical, "Error")
    '        Exit Sub
    '    End If

    '    'first delete any commissions from this invoice
    '    Try
    '        Dim oComms As New CommissionCollection
    '        oComms.Query.Where(oComms.Query.Invoicenumber.Equal(vInv))
    '        If oComms.Query.Load Then
    '            oComms.MarkAllAsDeleted()
    '            oComms.Save()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Exit Sub
    '    End Try


    '    'second, delete any invoice items for this invoice
    '    Try
    '        Dim oInvItems As New InvoiceitemCollection
    '        oInvItems.Query.Where(oInvItems.Query.Invoicenumber.Equal(vInv))
    '        If oInvItems.Query.Load Then
    '            oInvItems.MarkAllAsDeleted()
    '            oInvItems.Save()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Exit Sub
    '    End Try


    '    'finally, delete invoice record itself
    '    Try
    '        Dim oInvoice As Invoice
    '        oInvoice = New Invoice
    '        oInvoice.LoadByPrimaryKey(vInv)
    '        oInvoice.MarkAsDeleted()
    '        oInvoice.Save()
    '    Catch ex As Exception
    '        MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
    '    End Try

    '    loadInvoices(vInvoiceStatus)

    'End Sub


    Private Sub btnAddInvoice_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddInvoice.ItemClick
        addInvoice()
        updateSalesPersonData()
    End Sub

    Private Sub btnDeleteInvoice_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteInvoice.ItemClick
        If bsInvoices.Count <= 0 Then
            Exit Sub
        End If
        deleteInvoice(bsInvoices.Current.InvoiceNumber)     'code in InvoiceProcessing module
        updateSalesPersonData()
    End Sub

    Private Sub btnEditInvoice_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditInvoice.ItemClick
        editInvoice()
        updateSalesPersonData()
    End Sub

    Private Sub btnFilterAll_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterAll.ItemClick
        vInvoiceStatus = "ALL"
        loadInvoices(vInvoiceStatus)
    End Sub

    Private Sub btnFilterPaid_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterPaid.ItemClick
        vInvoiceStatus = "PAID"
        loadInvoices(vInvoiceStatus)
    End Sub

    Private Sub btnFilterPending_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterPending.ItemClick
        vInvoiceStatus = "PENDING"
        loadInvoices(vInvoiceStatus)
    End Sub

    Private Sub btnFilterReceivable_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterReceivable.ItemClick
        vInvoiceStatus = "RECEIVABLE"
        loadInvoices(vInvoiceStatus)
    End Sub

    Private Sub btnFilterVoid_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterVoid.ItemClick
        vInvoiceStatus = "VOID"
        loadInvoices(vInvoiceStatus)
    End Sub

    Private Sub btnPrintInvoice_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintInvoice.ItemClick
        If bsInvoices.Count <= 0 Then
            Exit Sub
        End If
        Dim vNum As Integer
        vNum = bsInvoices.Current.InvoiceNumber
        printInvoice(vNum)
    End Sub

    Private Sub printInvoice(ByVal vInvNum As Integer)
        Dim rpt As New rptInvoice(vInvNum)
        rpt.ShowPreview()
    End Sub

    Private Sub btnConvertWorkOrderToInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConvertWorkOrderToInvoice.ItemClick
        'get work order number from user to convert to invoice
        Dim vWONum As Integer = getUserString("Enter Work Order Number to Invoice")

        Dim oWO As New Workorder
        If Not oWO.LoadByPrimaryKey(vWONum) Then
            MsgBox("The selected WorkOrder number was not found in the database", MsgBoxStyle.Critical, "ERROR - Missing Data")
            Exit Sub
        End If

        Dim str As String = "Are you sure you want to create an Invoice for Work Order# " & vWONum.ToString & "?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        CreateInvoiceFromWorkorder(oWO.Workordernumber)


    End Sub


    'Private Sub btnConvertWorkOrderToInvoice_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnConvertWorkOrderToInvoice.ItemClick

    '    'get work order number from user to convert to invoice
    '    Dim vWONum As Integer = getUserString("Enter Work Order Number to Invoice")


    '    Dim str As String = "Are you sure you want to create an Invoice for Work Order# " & vWONum.ToString & "?"
    '    If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    'take chosen work order and create an invoice from the details of the work order and mark work order closed
    '    createInvoiceFromWorkOrder(vWONum)

    'End Sub

    'Private Sub btnTransferInvoicesToQuickbooks_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnTransferInvoicesToQuickbooks.ItemClick

    '    '' Create an empty list.
    'Dim Rows As New ArrayList()
    '' Add the selected rows to the list.
    'Dim I As Integer
    'For I = 0 To GridView1.SelectedRowsCount() - 1
    '    If (GridView1.GetSelectedRows()(I) >= 0) Then
    '        Rows.Add(GridView1.GetDataRow(GridView1.GetSelectedRows()(I)))
    '    End If
    'Next
    'Try
    '    GridView1.BeginUpdate()
    '    For I = 0 To Rows.Count - 1
    '        Dim Row As DataRow = CType(Rows(I), DataRow)
    '        ' Change the field value.
    '        Row("Discontinued") = True
    '    Next
    'Finally
    '    GridView1.EndUpdate()
    'End Try

    'If View.SelectedRowsCount = 0 Then Return ""

    'Const CellDelimiter As String = vbTab
    'Const LineDelimiter As String = vbCrLf
    'Dim Result As String = ""

    '' iterate cells and compose a tab delimited string of cell values
    'Dim I, J As Integer
    'Dim Row As Integer

    'For I = View.SelectedRowsCount - 1 To 0 Step -1
    '    Row = View.GetSelectedRows()(I)
    '    For J = 0 To View.VisibleColumns.Count - 1
    '        Result += View.GetRowCellDisplayText(Row, View.VisibleColumns(J))
    '        If J <> View.VisibleColumns.Count - 1 Then
    '            Result += CellDelimiter
    '        End If
    '    Next
    '    If I <> 0 Then
    '        Result += LineDelimiter
    '    End If
    'Next
    'Return Result


    '    If grvInvoiceList.SelectedRowsCount = 0 Then
    '        MsgBox("You must select at least one invoice record to mark", MsgBoxStyle.Critical, "Selection Empty")
    '        Exit Sub
    '    End If

    '    'capture list of select invoice numbers values from selected rows in gridview
    '    'Const CellDelimiter As String = vbTab
    '    Const LineDelimiter As String = vbCrLf
    '    Dim Result As String = ""
    '    ' iterate cells and compose a tab delimited string of cell values
    '    Dim I As Integer
    '    Dim Row As Integer
    '    For I = grvInvoiceList.SelectedRowsCount - 1 To 0 Step -1
    '        Row = grvInvoiceList.GetSelectedRows()(I)
    '        Result += grvInvoiceList.GetRowCellDisplayText(Row, grvInvoiceList.VisibleColumns(0))
    '        If I <> 0 Then
    '            Result += LineDelimiter
    '        End If
    '    Next

    '    Dim str As String = "Are you sure you want to transfer data for these selected invoices to QuickBooks?" & Chr(13) & Chr(13)
    '    str = str & Result
    '    If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Data Transfer Request") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    'change invoice status value for select invoice records to "RECEIVABLE" to mark as transferred
    '    For I = grvInvoiceList.SelectedRowsCount - 1 To 0 Step -1
    '        Row = grvInvoiceList.GetSelectedRows()(I)
    '        Dim vInvNum As Integer
    '        Dim oInv As New Invoice
    '        vInvNum = CInt(grvInvoiceList.GetRowCellDisplayText(Row, grvInvoiceList.VisibleColumns(0)))
    '        If oInv.LoadByPrimaryKey(vInvNum) Then
    '            oInv.Invoicestatus = "RECEIVABLE"
    '            oInv.Save()
    '        End If
    '    Next

    '    loadInvoices("PENDING")
    'End Sub


#End Region

#Region " CUSTOMER PAYMENTS "
    Private Sub loadCustomerPayments(ByVal vCustID As Integer)
        oCustPmts = New CustomerpaymentCollection
        oCustPmts.Query.Where(oCustPmts.Query.Custid.Equal(vCustID))
        oCustPmts.Query.Load()
        bsCustomerPayments.DataSource = oCustPmts
        If oCustPmts.Count <= 0 Then
            btnEditCustomerPayment.Enabled = False
            btnDeleteCustomerPayment.Enabled = False
        Else
            btnEditCustomerPayment.Enabled = True
            btnDeleteCustomerPayment.Enabled = True
        End If
    End Sub

    Private Sub eCustomerLookup_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eCustomerLookup.EditValueChanged
        loadCustomerPayments(eCustomerLookup.EditValue)
    End Sub

    Private Sub bsCustomerPayments_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsCustomerPayments.CurrentChanged
        If bsCustomerPayments.Count <= 0 Then
            loadInvoicePayments(0)
            Exit Sub
        End If
        loadInvoicePayments(bsCustomerPayments.Current.CustomerPmtID)
    End Sub
    Private Sub loadInvoicePayments(ByVal vCustPmtID As Integer)
        oInvPmts = New InvoicepaymentCollection
        oInvPmts.Query.Where(oInvPmts.Query.Customerpmtid.Equal(vCustPmtID))
        oInvPmts.Query.Load()
        bsInvoicePayments.DataSource = oInvPmts
    End Sub

    Private Sub btnAddCustomerPayment_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddCustomerPayment.ItemClick
        addNewCustomerPayment()
    End Sub

    Private Sub btnEditCustomerPayment_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditCustomerPayment.ItemClick
        editCustomerPayment()
    End Sub

    Private Sub btnDeleteCustomerPayment_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteCustomerPayment.ItemClick
        deleteCustomerPayment()
    End Sub

    Private Sub addNewCustomerPayment()
        If IsDBNull(eCustomerLookup.EditValue) Then
            MsgBox("You must select a customer first", MsgBoxStyle.Critical, "Error - No customer selected")
            Exit Sub
        End If
        Dim frm As New frmAddEditCustomerPayment
        frm.vEditType = "ADD"
        frm.vCustID = eCustomerLookup.EditValue
        frm.ShowDialog()
        loadCustomerPayments(eCustomerLookup.EditValue)
    End Sub

    Private Sub editCustomerPayment()
        If IsDBNull(eCustomerLookup.EditValue) Then
            MsgBox("You must select a customer first", MsgBoxStyle.Critical, "Error - No customer selected")
            Exit Sub
        End If
        Dim frm As New frmAddEditCustomerPayment
        frm.vEditType = "EDIT"
        frm.vID = bsCustomerPayments.Current.CustomerPmtID
        frm.vCustID = bsCustomerPayments.Current.CustID
        frm.ShowDialog()
        loadCustomerPayments(eCustomerLookup.EditValue)
    End Sub

    Private Sub deleteCustomerPayment()
        If bsCustomerPayments.Count <= 0 Then
            Exit Sub
        End If

        Dim str As String = "Are you sure you want to delete the selected payment?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Payment Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If

        'First locate the Customer Payment record to be deleted
        Dim oPmt As New Customerpayment
        If oPmt.LoadByPrimaryKey(bsCustomerPayments.Current.CustomerPmtID) Then
            'Get any Invoice Payments linked to Customer Payment and delete
            Dim oInvs As New InvoicepaymentCollection
            oInvs.Query.Where(oInvs.Query.Customerpmtid.Equal(oPmt.Customerpmtid))
            If oInvs.Query.Load Then
                For Each oInv As Invoicepayment In oInvs
                    'Mark any commissions linked to the Invoice
                    Dim oCommissions As New CommissionCollection
                    oCommissions.Query.Where(oCommissions.Query.Invoicenumber.Equal(oInv.Invoicenumber))
                    If oCommissions.Query.Load Then
                        For Each oComm As Commission In oCommissions
                            oComm.Commissionstatus = "PENDING"
                        Next
                        oCommissions.Save()
                    End If
                    'Mark the Invoice itself as RECEIVABLE again
                    Dim oInvoice As New Invoice
                    If oInvoice.LoadByPrimaryKey(oInv.Invoicenumber) Then
                        oInvoice.Invoicestatus = "RECEIVABLE"
                        oInvoice.Save()
                    End If
                    'Delete Invoice Payment record
                    oInv.MarkAsDeleted()
                Next
                oInvs.Save()
            End If
            'now delete the customer payment record
            oPmt.MarkAsDeleted()
            oPmt.Save()
        End If

        loadCustomerPayments(eCustomerLookup.EditValue)

    End Sub


    Private Sub btnPrintCustomerPmtByDate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintCustomerPmtByDate.ItemClick

        'first, ask for a payment date from user
        Dim vDate As Date = getUserDate("Enter date of payment:")

        'call report
        Dim rpt As New rptCustomerPmtByDate(vDate)
        rpt.ShowPreview()

    End Sub


#End Region

#Region " PRICE LISTS "

    Private Sub loadPriceLists(ByVal vCustID As Integer, vStatus As String)
        If IsDBNull(vCustID) Or vCustID <= 0 Then
            Exit Sub
        End If
        oPriceLists = New ViewPriceListDataCollection
        oPriceLists.Query.Where(oPriceLists.Query.Custid.Equal(vCustID), oPriceLists.Query.Priceliststatus.Equal(vStatus))
        oPriceLists.Query.Load()
        bsPriceLists.DataSource = oPriceLists
        Me.grPriceLists.DataSource = bsPriceLists
        Me.grPriceLists.Refresh()
        If oPriceLists.Count <= 0 Then
            btnEditPriceListItem.Enabled = False
            btnDeletePriceListItem.Enabled = False
        Else
            btnEditPriceListItem.Enabled = True
            btnDeletePriceListItem.Enabled = True
        End If
    End Sub
    Private Sub btnPrintPriceList_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPriceList.ItemClick

        If luCustomerList.EditValue Is Nothing Then
            Exit Sub
        End If
        'Dim str As String = "SELECT  CUSTOMER.CUSTID, CUSTOMER.CUSTNAME, CUSTOMER.CUSTSHIPCITY, CUSTOMER.CUSTSHIPSTATEPROV, PRICELIST.PRODUCTID, PRODUCT.PRODUCTDESC, PRODUCT.CONTAINER, PRICELIST.UNITS, PRICELIST.UNITPRICE, PRICELIST.UOM, PRICELIST.UNITORCONTAINER, PRICELIST.EFFECTIVEDATE, PRICELIST.TAXABLE, PRICELIST.CONTAINERPRICE FROM PRICELIST INNER JOIN CUSTOMER ON PRICELIST.CUSTID = CUSTOMER.CUSTID LEFT OUTER JOIN PRODUCT ON PRICELIST.PRODUCTID = PRODUCT.PRODUCTID WHERE (CUSTOMER.CUSTID = " & luCustomerList.EditValue & ") ORDER BY PRODUCT.PRODUCTDESC"
        'Dim ds As New DataSet
        'Dim da As New SqlClient.SqlDataAdapter(str, sqlcnn)
        'Dim dt As New DataTable
        'Try
        '    da.Fill(ds, "PriceList")
        '    dt = ds.Tables(0)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try
        Dim rpt As New rptPriceList(luCustomerList.EditValue)
        rpt.ShowPreview()
    End Sub

    Private Sub luCustomerList_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luCustomerList.EditValueChanged
        loadPriceLists(luCustomerList.EditValue, "ACTIVE")
    End Sub
    Private Sub editPriceListItem()
        Dim frm As New frmUpdatePriceListItem
        frm.vPriceListID = Me.bsPriceLists.Current.PriceListID
        frm.vProductID = bsPriceLists.Current.ProductID
        frm.vCustomerID = luCustomerList.EditValue
        frm.vAddtype = "EDIT"
        frm.ShowDialog()
        loadPriceLists(luCustomerList.EditValue, "ACTIVE")
    End Sub

    Private Sub addPriceListItem()
        Dim frm As New frmUpdatePriceListItem
        Dim vResult As DialogResult
        frm.vAddtype = "ADD"
        frm.vCustomerID = luCustomerList.EditValue
        vResult = frm.ShowDialog()
        loadProductList()
        loadPriceLists(luCustomerList.EditValue, "ACTIVE")
    End Sub

    Private Sub deletePriceListItem()
        Dim str As String
        str = "Are you sure you want to delete the selected Price List Item record?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Dim oPL As Pricelist
            oPL = New Pricelist
            oPL.LoadByPrimaryKey(bsPriceLists.Current.PriceListID)
            oPL.MarkAsDeleted()
            oPL.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        loadPriceLists(luCustomerList.EditValue, "ACTIVE")
    End Sub


    Private Sub btnExportToXLS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportToXLS.Click
        Try
            Dim vFilename As String
            vFilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\ExportedPriceList.xls"
            viewPriceList.ExportToXls(vFilename)
            MsgBox("Price List successfully exported to My Documents\exportedPriceList.xls", MsgBoxStyle.Information, "Export succeeded")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub rbtnPrintCustomerProductList_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintCustomerProductList.ItemClick
        If luCustomerList.EditValue Is Nothing Then
            Exit Sub
        End If
        Dim rpt As New rptProductListing(luCustomerList.EditValue)
        rpt.ShowPreview()
    End Sub

    Private Sub rbtnFilterPriceListActive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterPriceListActive.ItemClick
        loadPriceLists(luCustomerList.EditValue, "ACTIVE")
        gcPriceLists.Text = "ACTIVE - Customer Pricelist"
    End Sub

    Private Sub rbtnFilterPriceListInActive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterPriceListInActive.ItemClick
        loadPriceLists(luCustomerList.EditValue, "INACTIVE")
        gcPriceLists.Text = "INACTIVE - Customer Pricelist"
    End Sub
#End Region

#Region " COMMISSIONS "
    Private Sub loadAssignments(ByVal vSalesID As Integer)
        oAssignments = New CustomerassignmentCollection
        oAssignments.Query.Where(oAssignments.Query.SalespersonID.Equal(vSalesID))
        oAssignments.Query.Load()
        bsAssignments.DataSource = oAssignments
        Me.grAssignments.DataSource = bsAssignments
        Me.grAssignments.Refresh()
        If oAssignments.Count <= 0 Then
            btnEditAssignment.Enabled = False
            btnDeleteAssignment.Enabled = False
        Else
            btnEditAssignment.Enabled = True
            btnDeleteAssignment.Enabled = True
        End If
    End Sub

    Private Sub loadCommissions(ByVal vSalesID As Integer, vCommStatus As String, Optional vLastPaidDate As Date = Nothing)

        Me.Cursor = Cursors.WaitCursor
        'read SalesID and Commission filter setting to fetch commission records
        Try
            oCommissions = New ViewCommissionAuditAnalysisCollection
            If vLastPaidDate = Nothing Then
                oCommissions.Query.Where(oCommissions.Query.Salespersonid.Equal(vSalesID), oCommissions.Query.Commissionstatus.Equal(vCommStatus))
            Else
                oCommissions.Query.Where(oCommissions.Query.Salespersonid.Equal(vSalesID), oCommissions.Query.Commissionstatus.Equal(vCommStatus), oCommissions.Query.Datecustomerpaid.LessThanOrEqual(vLastPaidDate))
            End If
            oCommissions.Query.Load()
            oCommissions.Sort = "CommissionDate DESC"
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'set active commission filter setting
        vCommFilter = vCommStatus
        rpgFilter.Text = "Filter: " & vCommFilter
        bsCommissions.DataSource = oCommissions
        Me.grCommissions.DataSource = bsCommissions
        Me.grCommissions.Refresh()
        If oCommissions.Count <= 0 Then
            btnEditCommissionRec.Enabled = False
            btnDeleteCommissionRec.Enabled = False
        Else
            btnEditCommissionRec.Enabled = True
            btnDeleteCommissionRec.Enabled = True
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnEditCommission_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditCommission.ItemClick
        If bsCommissions.Count < 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditCommission
        frm.vCommID = bsCommissions.Current.CommissionID
        frm.vSalesID = bsSalesperson.Current.SalespersonID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadCommissions(bsSalesperson.Current.salespersonid, vCommFilter)
    End Sub

    Private Sub btnAddCommission_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddCommission.ItemClick
        Dim frm As New frmAddEditCommission
        frm.vSalesID = bsSalesperson.Current.SalespersonID
        frm.vEditType = "ADD"
        frm.ShowDialog()
        loadCommissions(bsSalesperson.Current.salespersonid, vCommFilter)
    End Sub

    Private Sub btnDeleteCommission_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteCommission.ItemClick
        If bsCommissions.Count < 0 Then
            Exit Sub
        End If

        Dim str As String = "Are you sure you want to delete the selected commission record?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Commission Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oComm As Commission
        oComm = New Commission
        If oComm.LoadByPrimaryKey(bsCommissions.Current.CommissionID) Then
            oComm.MarkAsDeleted()
            oComm.Save()
        End If
        loadCommissions(bsSalesperson.Current.salespersonid, vCommFilter)
    End Sub

    Private Sub btnCommissionFilterPending_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCommissionFilterPending.ItemClick
        loadCommissions(bsSalesperson.Current.salespersonid, "PENDING")
    End Sub

    Private Sub btnCommissionFilterPayable_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCommissionFilterPayable.ItemClick
        loadCommissions(bsSalesperson.Current.salespersonid, "PAYABLE")
    End Sub

    Private Sub btnCommissionFilterPaid_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCommissionFilterPaid.ItemClick
        loadCommissions(bsSalesperson.Current.salespersonid, "PAID")
    End Sub

    'Private Sub btnPrintCommForecast_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintCommForecast.ItemClick
    '    If bsSalesperson.Count <= 0 Then
    '        Exit Sub
    '    End If
    '    Dim rpt As New rptCommissions(bsSalesperson.Current.SalesPersonID, "PENDING")
    '    rpt.ShowPreview()
    'End Sub

    Private Sub btnPrintCommPayable_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintCommPayable.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptCommissions(bsSalesperson.Current.SalesPersonID, "PAYABLE")
        rpt.ShowPreview()
    End Sub
    Private Sub btnPrintPaidCommissionsRpt_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPaidCommissionsRpt.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptCommissions(bsSalesperson.Current.SalesPersonID, "PAID")
        rpt.ShowPreview()
    End Sub

    Private Sub btnMarkPayable_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkPayable.ItemClick
        If bsCommissions.Count < 0 Then
            Exit Sub
        End If

        If grvCommissions.SelectedRowsCount <= 0 Then
            MsgBox("There are no Commission records selected to update", MsgBoxStyle.Critical, "Error - no records selected")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to mark the selected Commissions as PAYABLE?", MsgBoxStyle.YesNo, "Confirm - Mark PAYABLE") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Create an array and pull selected records
        Dim SelectedRows(0, 0) As Integer
        ReDim SelectedRows(grvCommissions.SelectedRowsCount - 1, 0)
        Dim I As Integer
        For I = 0 To SelectedRows.GetUpperBound(0)
            Try
                grvCommissions.GetRowCellDisplayText(grvCommissions.GetSelectedRows(I), colCommissionid1)
                updateCommissionStatus(grvCommissions.GetRowCellDisplayText(grvCommissions.GetSelectedRows(I), colCommissionid1), "PAYABLE")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        loadCommissions(bsSalesperson.Current.salespersonid, "PAYABLE")
    End Sub

    Private Sub btnMarkPaid_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkPaid.ItemClick
        If bsCommissions.Count < 0 Then
            Exit Sub
        End If

        If grvCommissions.SelectedRowsCount <= 0 Then
            MsgBox("There are no Commission records selected to update", MsgBoxStyle.Critical, "Error - no records selected")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to mark the selected Commissions as PAID?", MsgBoxStyle.YesNo, "Confirm - Mark PAID") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim vDate As Date = getUserDate("Enter Commission Payment Date:")
        If IsDBNull(vDate) Then
            MsgBox("You did not enter a valid date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'Create an array and pull selected records
        Dim SelectedRows(0, 0) As Integer
        ReDim SelectedRows(grvCommissions.SelectedRowsCount - 1, 0)
        Dim I As Integer
        For I = 0 To SelectedRows.GetUpperBound(0)
            Try
                grvCommissions.GetRowCellDisplayText(grvCommissions.GetSelectedRows(I), colCommissionid1)
                updateCommissionStatus(grvCommissions.GetRowCellDisplayText(grvCommissions.GetSelectedRows(I), colCommissionid1), "PAID", vDate)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        loadCommissions(bsSalesperson.Current.salespersonid, "PAID")

    End Sub

    Private Sub btnMarkPending_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkPending.ItemClick
        If bsCommissions.Count < 0 Then
            Exit Sub
        End If

        If grvCommissions.SelectedRowsCount <= 0 Then
            MsgBox("There are no Commission records selected to update", MsgBoxStyle.Critical, "Error - no records selected")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to mark the selected Commissions as PENDING?", MsgBoxStyle.YesNo, "Confirm - Mark PENDING") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Create an array and pull selected records
        Dim SelectedRows(0, 0) As Integer
        ReDim SelectedRows(grvCommissions.SelectedRowsCount - 1, 0)
        Dim I As Integer
        For I = 0 To SelectedRows.GetUpperBound(0)
            Try
                grvCommissions.GetRowCellDisplayText(grvCommissions.GetSelectedRows(I), colCommissionid1)
                updateCommissionStatus(grvCommissions.GetRowCellDisplayText(grvCommissions.GetSelectedRows(I), colCommissionid1), "PENDING")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        loadCommissions(bsSalesperson.Current.salespersonid, "PENDING")

    End Sub

    Private Sub luActiveSalesPerson_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luActiveSalesPerson.EditValueChanged
        loadCommissions(luActiveSalesPerson.EditValue, vCommFilter)
        Dim oSalesperson As New Salesperson
        If oSalesperson.LoadByPrimaryKey(luActiveSalesPerson.EditValue) Then
            grpCommissionData.Text = "Commissions for " & oSalesperson.Salespersonfullname
        End If
    End Sub

    Private Sub btnFetchForecastedCommissions_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFetchForecastedCommissions.ItemClick
        vCommFilter = "PENDING"
        loadCommissions(luActiveSalesPerson.EditValue, "PENDING")
    End Sub

    Private Sub btnFetchPayableCommissions_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFetchPayableCommissions.ItemClick
        vCommFilter = "PAYABLE"
        loadCommissions(luActiveSalesPerson.EditValue, "PAYABLE")
    End Sub

    Private Sub addCommission(ByVal vSalespersonID As Integer)
        Dim frm As New frmAddEditCommission
        frm.vSalesID = vSalespersonID
        frm.vEditType = "ADD"
        frm.ShowDialog()
    End Sub

    Private Sub editCommission(ByVal vCommissionID As Integer, ByVal vSalespersonID As Integer)
        If bsCommissions.Count < 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditCommission
        frm.vCommID = vCommissionID
        frm.vSalesID = vSalespersonID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
    End Sub

    Private Sub deleteCommission(ByVal vCommissionID As Integer)
        If bsCommissions.Count < 0 Then
            Exit Sub
        End If

        Dim str As String = "Are you sure you want to delete the selected commission record?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Commission Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oComm As Commission
        oComm = New Commission
        If oComm.LoadByPrimaryKey(bsCommissions.Current.CommissionID) Then
            Try
                oComm.MarkAsDeleted()
                oComm.Save()
                MsgBox("Commission record successfully deleted.", MsgBoxStyle.Exclamation, "Operation Complete")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnAddCommissionRec_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddCommissionRec.ItemClick
        addCommission(luActiveSalesPerson.EditValue)
        loadCommissions(luActiveSalesPerson.EditValue, vCommFilter)
    End Sub

    Private Sub btnEditCommissionRec_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditCommissionRec.ItemClick
        editCommission(bsCommissions.Current.CommissionID, luActiveSalesPerson.EditValue)
        loadCommissions(luActiveSalesPerson.EditValue, vCommFilter)
    End Sub

    Private Sub btnDeleteCommissionRec_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteCommissionRec.ItemClick
        deleteCommission(bsCommissions.Current.CommissionID)
        loadCommissions(luActiveSalesPerson.EditValue, vCommFilter)
    End Sub

    Private Sub updateCommissionStatus(ByVal CommID As Integer, ByVal vStatus As String, Optional vPaidDate As Date = Nothing)
        Dim oComm As Commission
        oComm = New Commission
        If oComm.LoadByPrimaryKey(CommID) Then
            oComm.Commissionstatus = vStatus
            If vStatus = "PAID" Then
                If vPaidDate = Nothing Then
                    oComm.Datecommissionpaid = CDate(Now())
                Else
                    oComm.Datecommissionpaid = vPaidDate
                End If
            End If
            oComm.Save()
        End If
    End Sub

    Private Sub btnMarkCommissionForecasted_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkCommissionForecasted.ItemClick
        If bsCommissions.Count <= 0 Then
            Exit Sub
        End If

        If grvCommissionData.SelectedRowsCount <= 0 Then
            MsgBox("There are no Commission records selected to update", MsgBoxStyle.Critical, "Error - no records selected")
            Exit Sub
        End If
        'Create an array and pull selected records
        Dim SelectedRows(0, 0) As Integer
        ReDim SelectedRows(grvCommissionData.SelectedRowsCount - 1, 0)
        Dim I As Integer
        For I = 0 To SelectedRows.GetUpperBound(0)
            Try
                grvCommissionData.GetRowCellDisplayText(grvCommissionData.GetSelectedRows(I), colCommissionID)
                updateCommissionStatus(grvCommissionData.GetRowCellDisplayText(grvCommissionData.GetSelectedRows(I), colCommissionID), "PENDING")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        'updateCommissionStatus(bsCommissions.Current.CommissionID, "PENDING")

        loadCommissions(luActiveSalesPerson.EditValue, "PENDING")
    End Sub

    Private Sub btnMarkCommissionPayable_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkCommissionPayable.ItemClick
        If bsCommissions.Count <= 0 Then
            Exit Sub
        End If

        If grvCommissionData.SelectedRowsCount <= 0 Then
            MsgBox("There are no Commission records selected to update", MsgBoxStyle.Critical, "Error - no records selected")
            Exit Sub
        End If
        'Create an array and pull selected records
        Dim SelectedRows(0, 0) As Integer
        ReDim SelectedRows(grvCommissionData.SelectedRowsCount - 1, 0)
        Dim I As Integer
        For I = 0 To SelectedRows.GetUpperBound(0)
            Try
                grvCommissionData.GetRowCellDisplayText(grvCommissionData.GetSelectedRows(I), colCommissionID)
                updateCommissionStatus(grvCommissionData.GetRowCellDisplayText(grvCommissionData.GetSelectedRows(I), colCommissionID), "PAYABLE")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        'updateCommissionStatus(bsCommissions.Current.CommissionID, "PAYABLE")

        loadCommissions(luActiveSalesPerson.EditValue, "PAYABLE")
    End Sub

    Private Sub btnMarkCommissionPaid_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkCommissionPaid.ItemClick
        If bsCommissions.Count <= 0 Then
            Exit Sub
        End If

        If grvCommissionData.SelectedRowsCount <= 0 Then
            MsgBox("There are no Commission records selected to update", MsgBoxStyle.Critical, "Error - no records selected")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to mark the selected Commissions as PAID?", MsgBoxStyle.YesNo, "Confirm - Mark PAID") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Create an array and pull selected records
        Dim SelectedRows(0, 0) As Integer
        ReDim SelectedRows(grvCommissionData.SelectedRowsCount - 1, 0)
        Dim I As Integer
        For I = 0 To SelectedRows.GetUpperBound(0)
            Try
                grvCommissionData.GetRowCellDisplayText(grvCommissionData.GetSelectedRows(I), colCommissionID)
                updateCommissionStatus(grvCommissionData.GetRowCellDisplayText(grvCommissionData.GetSelectedRows(I), colCommissionID), "PAID")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        loadCommissions(luActiveSalesPerson.EditValue, "PAID")
    End Sub


    Private Sub btnPrintForecastedCommissions_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintForecastedCommissions.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptCommissions(luActiveSalesPerson.EditValue, "PENDING")
        rpt.ShowPreview()
    End Sub

    Private Sub btnPrintPayableCommissions_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPayableCommissions.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptCommissions(luActiveSalesPerson.EditValue, "PAYABLE")
        rpt.ShowPreview()
    End Sub

    Private Sub btnPrintCommissionsByCustomer_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintCommissionsByCustomer.ItemClick
        Dim vCustID As Integer
        Dim vBeginDate As Date
        Dim vEndDate As Date

        Try
            Dim frm As frmRptCriteria1
            frm = New frmRptCriteria1
            frm.vSalesID = luActiveSalesPerson.EditValue
            Dim vResult As Windows.Forms.DialogResult
            vResult = frm.ShowDialog
            If vResult = DialogResult.Yes Then
                vCustID = frm.vCustomerID
                vBeginDate = frm.vBeginDate
                vEndDate = frm.vEndDate
                Dim rpt As New rptCommissionsByCustomer(luActiveSalesPerson.EditValue, vCustID, vBeginDate, vEndDate)
                rpt.ShowPreview()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub editSalesperson()
        Dim frm As New frmAddEditSalesperson
        frm.vID = Me.bsSalesperson.Current.SalespersonID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadSalespersons(vSalesFilter)
    End Sub

    Private Sub addSalesperson()
        Dim frm As New frmAddEditSalesperson
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        vResult = frm.ShowDialog()
        loadSalespersons(vSalesFilter)
    End Sub

    Private Sub deleteSalesperson()
        Dim str As String
        str = "Are you sure you want to delete " & bsSalesperson.Current.SalespersonFirstName & " " & bsSalesperson.Current.SalespersonLastName & "?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Dim oSalesperson As Salesperson
            oSalesperson = New Salesperson
            oSalesperson.LoadByPrimaryKey(bsSalesperson.Current.SalespersonID)
            oSalesperson.MarkAsDeleted()
            oSalesperson.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        loadSalespersons(vSalesFilter)
    End Sub

    Private Sub bsSalesperson_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsSalesperson.CurrentChanged
        updateSalesPersonData()
    End Sub
    Private Sub updateSalesPersonData()
        grpCustomerAssignments.Text = "Customer Assignments for " & bsSalesperson.Current.SalespersonFirstName & " " & bsSalesperson.Current.SalespersonLastName
        loadAssignments(bsSalesperson.Current.salespersonid)
        grpCommissions.Text = "Commissions for " & bsSalesperson.Current.SalespersonFirstName & " " & bsSalesperson.Current.SalespersonLastName
        loadCommissions(bsSalesperson.Current.salespersonid, vCommFilter)
    End Sub
    Private Sub editAssignment()
        Dim frm As New frmAddEditAssignment
        frm.vID = Me.bsAssignments.Current.CustAssignID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadAssignments(bsSalesperson.Current.Salespersonid)
    End Sub

    Private Sub addAssignment()
        Dim frm As New frmAddEditAssignment
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        frm.vFKID = bsSalesperson.Current.Salespersonid
        vResult = frm.ShowDialog()
        loadAssignments(bsSalesperson.Current.Salespersonid)
    End Sub

    Private Sub deleteAssignment()
        Dim str As String
        str = "Are you sure you want to delete the selected Customer Assignment record?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Dim oAssign As Customerassignment
            oAssign = New Customerassignment
            oAssign.LoadByPrimaryKey(bsAssignments.Current.CUSTASSIGNID)
            oAssign.MarkAsDeleted()
            oAssign.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        loadAssignments(bsSalesperson.Current.Salespersonid)
    End Sub

#End Region

#Region " SALES HISTORY "
    Private Sub eFetchSalesHistoryData_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles eFetchSalesHistoryData.ItemClick

        Dim vCustID As Integer
        Dim vStart As Date
        Dim vEnd As Date

        If IsDBNull(eCustomerSelector.EditValue) Or eCustomerSelector.EditValue <= 0 Then
            'MsgBox("You must first select a Customer", MsgBoxStyle.Critical, "Error")
            'Exit Sub
            vCustID = 0
        Else
            vCustID = eCustomerSelector.EditValue
        End If

        If IsDBNull(eHistoryStart.EditValue) Or eHistoryStart.EditValue = Nothing Then
            MsgBox("You must first select a Start Date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vStart = eHistoryStart.EditValue
        End If

        If IsDBNull(eHistoryEnd.EditValue) Or eHistoryEnd.EditValue = Nothing Then
            MsgBox("You must first select an End Date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vEnd = eHistoryEnd.EditValue
        End If

        Dim oSalesHistory As New ViewCustomerInvoicedItemsCollection
        Select Case vCustID
            Case 0
                oSalesHistory.Query.Where(oSalesHistory.Query.Invoicedate.Between(vStart, vEnd))
            Case Else
                oSalesHistory.Query.Where(oSalesHistory.Query.Custid.Equal(vCustID), oSalesHistory.Query.Invoicedate.Between(vStart, vEnd))
        End Select

        oSalesHistory.Query.Load()
        bsSalesHistory.DataSource = oSalesHistory
        grSalesHistory.DataSource = bsSalesHistory

    End Sub

    Private Sub btnExportSalesHistoryData_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnExportSalesHistoryData.ItemClick
        Try
            Dim vFilename As String
            vFilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\exportedSalesHistory.xls"
            gridViewSalesHistory.ExportToXls(vFilename)
            MsgBox("Price List successfully exported to My Documents\exportedSalesHistory.xls", MsgBoxStyle.Information, "Export succeeded")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub rbtnGetProductSales_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetProductSales.ItemClick

        Dim vProdID As Integer
        Dim vStart As Date
        Dim vEnd As Date

        If IsDBNull(eProductLookup.EditValue) Or eProductLookup.EditValue <= 0 Then
            MsgBox("You must first select a product", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vProdID = eProductLookup.EditValue
        End If

        If IsDBNull(eProductStart.EditValue) Then
            MsgBox("You must first select a Start Date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vStart = eProductStart.EditValue
        End If

        If IsDBNull(eProductEnd.EditValue) Then
            MsgBox("You must first select an End Date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vEnd = eProductEnd.EditValue
        End If

        Dim oSalesHistory As New ViewCustomerInvoicedItemsCollection
        oSalesHistory.Query.Where(oSalesHistory.Query.Productid.Equal(vProdID), oSalesHistory.Query.Invoicedate.Between(vStart, vEnd))
        oSalesHistory.Query.Load()
        bsSalesHistory.DataSource = oSalesHistory
        grSalesHistory.DataSource = bsSalesHistory
    End Sub

    Private Sub rbtnMonthlySalesAnalysis_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMonthlySalesAnalysis.ItemClick
        Dim frm As New frmSalesDataAnalysis
        frm.ShowDialog()
    End Sub

#End Region

#Region " SALES ANALYSIS "
    Private Sub rbtnGetSalesAnalysisData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetSalesAnalysisData.ItemClick

        gcSalesAnalysis.BringToFront()

        If IsDBNull(rluSalesperson.EditValue) Or rluSalesperson.EditValue = Nothing Then
            MsgBox("You must select a Salesperson first", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If
        If IsDBNull(rluSalesYear.EditValue) Or rluSalesYear.EditValue = Nothing Then
            MsgBox("You must select a Sales Year first", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        Dim oSalesData As New ViewCustomerSalesDataCollection
        oSalesData.Query.Where(oSalesData.Query.SalesID1.Equal(rluSalesperson.EditValue), oSalesData.Query.Year.Equal(rluSalesYear.EditValue))
        oSalesData.Query.Load()
        oSalesData.Sort = "CustName, Year"
        bsSalesData.DataSource = oSalesData

    End Sub

    Private Sub rbtnExportSalesDataToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnExportSalesDataToExcel.ItemClick

        If IsDBNull(rluSalesperson.EditValue) Or rluSalesperson.EditValue = Nothing Then
            MsgBox("You must select a Salesperson first", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If
        If IsDBNull(rluSalesYear.EditValue) Or rluSalesYear.EditValue = Nothing Then
            MsgBox("You must select a Sales Year first", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        If bsSalesData.Count <= 0 Then
            MsgBox("There is no data to export", MsgBoxStyle.Critical, "Error - No Data")
            Exit Sub
        End If

        'get SalespersonFullName from Salesperson table
        Dim oSalesperson As New Salesperson
        If Not oSalesperson.LoadByPrimaryKey(rluSalesperson.EditValue) Then
            MsgBox("Could not retrieve Sales Person Name from database", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        Dim vSalesName As String = oSalesperson.Salespersonfirstname & oSalesperson.Salespersonlastname
        Dim vSalesYear As String = rluSalesYear.EditValue
        Dim vFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & "CustomerSalesAnalysis_" & vSalesName & "_" & vSalesYear & ".xlsx"

        Try
            grvSalesAnalysis.ExportToXlsx(vFilePath)
            MsgBox("You can find your Excel file at the following location: " & vFilePath, MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Show the result.
        StartProcess(vFilePath)

    End Sub


    Private Sub rbtnGetSalesAnalysisByCustomerData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetSalesAnalysisByCustomerData.ItemClick

        gcSalesByCustomerAnalysis.BringToFront()

        'If IsDBNull(rluSalesperson.EditValue) Or rluSalesperson.EditValue = Nothing Then
        '    MsgBox("You must select a Salesperson first", MsgBoxStyle.Critical, "Error - Missing Data")
        '    Exit Sub
        'End If
        If IsDBNull(rluSalesYear.EditValue) Or rluSalesYear.EditValue = Nothing Then
            MsgBox("You must select a Sales Year first", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If
        Dim colSalesRepName_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn = grvSalesByCustomerAnalysis.Columns.ColumnByName("colSalesRepName_SalesByCustomerAnalysis")
        colSalesRepName_SalesByCustomerAnalysis.Visible = True

        Dim colCustName_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn = grvSalesByCustomerAnalysis.Columns.ColumnByName("colCustName_SalesByCustomerAnalysis")
        colCustName_SalesByCustomerAnalysis.Visible = True

        Dim colCustId_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn = grvSalesByCustomerAnalysis.Columns.ColumnByName("colCustId_SalesByCustomerAnalysis")
        colCustId_SalesByCustomerAnalysis.Visible = True

        colSalesRepName_SalesByCustomerAnalysis.VisibleIndex = 3
        colCustName_SalesByCustomerAnalysis.VisibleIndex = 2
        colCustId_SalesByCustomerAnalysis.VisibleIndex = 1



        Dim oSalesData As New ViewSalesByCustomerAnalysisCollection
        oSalesData.Query.Where(oSalesData.Query.Year.Equal(rluSalesYear.EditValue))

        If Not IsDBNull(rluSalesperson.EditValue) And rluSalesperson.EditValue <> Nothing Then
            oSalesData.Query.Where(oSalesData.Query.SalesID1.Equal(rluSalesperson.EditValue))
        End If

        oSalesData.Query.Load()
        oSalesData.Sort = "SalesName, CustName, Year"
        bsSalesByCustomer.DataSource = oSalesData

    End Sub

    Private Sub rbtnExportSalesByCustomerAnalysisToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnExportSalesByCustomerAnalysisToExcel.ItemClick


        If bsSalesByCustomer.Count <= 0 Then
            MsgBox("There is no data to export", MsgBoxStyle.Critical, "Error - No Data")
            Exit Sub
        End If
        Dim vFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & "SalesAnalysisByCustomer_"
        'get SalespersonFullName from Salesperson table
        If IsDBNull(rluSalesYear.EditValue) Or rluSalesYear.EditValue = Nothing Then
            Dim oSalesperson As New Salesperson
            If Not oSalesperson.LoadByPrimaryKey(rluSalesperson.EditValue) Then
                MsgBox("Could not retrieve Sales Person Name from database", MsgBoxStyle.Critical, "Error - Missing Data")
                Exit Sub
            End If
            Dim vSalesName As String = oSalesperson.Salespersonfirstname & oSalesperson.Salespersonlastname
            vFilePath = vFilePath & vSalesName & "_"
        End If


        Dim vSalesYear As String = rluSalesYear.EditValue
        vFilePath = vFilePath & vSalesYear & ".xlsx"

        Try
            grvSalesByCustomerAnalysis.ExportToXlsx(vFilePath)
            MsgBox("You can find your Excel file at the following location: " & vFilePath, MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Show the result.
        StartProcess(vFilePath)


    End Sub

    Private Sub rbtnGetSalesPersonAnalysis_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetSalesPersonAnalysis.ItemClick

        gcSalesByCustomerAnalysis.BringToFront()

        'If IsDBNull(rluSalesperson.EditValue) Or rluSalesperson.EditValue = Nothing Then
        '    MsgBox("You must select a Salesperson first", MsgBoxStyle.Critical, "Error - Missing Data")
        '    Exit Sub
        'End If
        If IsDBNull(rluSalesYear.EditValue) Or rluSalesYear.EditValue = Nothing Then
            MsgBox("You must select a Sales Year first", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        Dim colCustId_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn = grvSalesByCustomerAnalysis.Columns.ColumnByName("colCustId_SalesByCustomerAnalysis")
        colCustId_SalesByCustomerAnalysis.Visible = False

        Dim colCustName_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn = grvSalesByCustomerAnalysis.Columns.ColumnByName("colCustName_SalesByCustomerAnalysis")
        colCustName_SalesByCustomerAnalysis.Visible = False

        Dim colSalesRepName_SalesByCustomerAnalysis As DevExpress.XtraGrid.Columns.GridColumn = grvSalesByCustomerAnalysis.Columns.ColumnByName("colSalesRepName_SalesByCustomerAnalysis")
        colSalesRepName_SalesByCustomerAnalysis.Visible = False


        Dim oSalesData As New ViewSalesPersonAnalysisCollection
        oSalesData.Query.Where(oSalesData.Query.Year.Equal(rluSalesYear.EditValue))

        oSalesData.Query.Load()
        oSalesData.Sort = "SalesName,  Year"
        bsSalesByCustomer.DataSource = oSalesData

    End Sub

    Private Sub rbtnExportSalesPersonAnalysisToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnExportSalesPersonAnalysisToExcel.ItemClick
        If bsSalesByCustomer.Count <= 0 Then
            MsgBox("There is no data to export", MsgBoxStyle.Critical, "Error - No Data")
            Exit Sub
        End If
        Dim vFilePath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\" & "SalesPersonAnalysis"


        Dim vSalesYear As String = rluSalesYear.EditValue
        vFilePath = vFilePath & vSalesYear & ".xlsx"

        Try
            grvSalesByCustomerAnalysis.ExportToXlsx(vFilePath)
            MsgBox("You can find your Excel file at the following location: " & vFilePath, MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Show the result.
        StartProcess(vFilePath)

    End Sub


    Private Sub rbtnCompileTrendData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCompileTrendData.ItemClick

        gcCustomerAnalysis.BringToFront()

        If IsDBNull(rluCustomer.EditValue) Or rluCustomer.EditValue = Nothing Then
            MsgBox("You must select a Customer first", MsgBoxStyle.Critical, "Error - Missing data")
            Exit Sub
        End If

        Dim oCDataM As New ViewCustomerTrendAnalysisMonthlyCollection
        Dim oCDataQ As New ViewCustomerTrendAnalysisQuarterlyCollection
        Dim oCDataY As New ViewCustomerTrendAnalysisAnnuallyCollection

        Try
            oCDataM.Query.Where(oCDataM.Query.CustID.Equal(rluCustomer.EditValue))
            oCDataQ.Query.Where(oCDataQ.Query.CustID.Equal(rluCustomer.EditValue))
            oCDataY.Query.Where(oCDataY.Query.CustID.Equal(rluCustomer.EditValue))
            oCDataM.Query.Load()
            oCDataQ.Query.Load()
            oCDataY.Query.Load()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rbtnViewPrintSDSDocument_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnViewPrintSDSDocument.ItemClick
        If bsPriceLists.Count <= 0 Then
            Exit Sub
        End If
        viewPrintSDSDocumentByProduct(bsPriceLists.Current.ProductID)
    End Sub

    Private Sub rbtnFilterSalesACTIVE_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterSalesACTIVE.ItemClick
        vSalesFilter = "ACTIVE"
        loadSalespersons(vSalesFilter)
    End Sub

    Private Sub rbtnFilterSalesINACTIVE_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterSalesINACTIVE.ItemClick
        vSalesFilter = "INACTIVE"
        loadSalespersons(vSalesFilter)
    End Sub

    Private Sub rbtnPrintCommByCustomer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintCommByCustomer.ItemClick
        Dim vCustID As Integer
        Dim vBeginDate As Date
        Dim vEndDate As Date

        Try
            Dim frm As frmRptCriteria1
            frm = New frmRptCriteria1
            frm.vSalesID = luActiveSalesPerson.EditValue
            Dim vResult As Windows.Forms.DialogResult
            vResult = frm.ShowDialog
            If vResult = DialogResult.Yes Then
                vCustID = frm.vCustomerID
                vBeginDate = frm.vBeginDate
                vEndDate = frm.vEndDate
                Dim rpt As New rptCommissionsByCustomer(luActiveSalesPerson.EditValue, vCustID, vBeginDate, vEndDate)
                rpt.ShowPreview()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbtnCommissonAuditReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCommissonAuditReport.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If

        If bsCommissions.Count <= 0 Then
            Exit Sub
        End If

        Dim rpt As New rptCommissionAudit(bsCommissions.Current.invoicenumber, bsCommissions.Current.SalespersonID)
        rpt.ShowPreviewDialog
    End Sub

    Private Sub RibbonControl2_SelectedPageChanged(sender As Object, e As EventArgs) Handles RibbonControl2.SelectedPageChanged
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If

        If Me.RibbonControl2.SelectedPage.Name = "RibbonPage8" Then
            loadCommissions(bsSalesperson.Current.salespersonid, "PAYABLE")
        End If

    End Sub

    Private Sub rbtnFilterPayableCommAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterPayableCommAll.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If
        loadCommissions(bsSalesperson.Current.salespersonid, "PAYABLE")
    End Sub

    Private Sub rbtnFilterPayableCommByDate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterPayableCommByDate.ItemClick

        Dim vPaidDate As Date

        If IsDBNull(eInvPaidThruDate.EditValue) Then
            MsgBox("You must first select a Invoice Paid Thru Date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vPaidDate = eInvPaidThruDate.EditValue
        End If
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If

        loadCommissions(bsSalesperson.Current.salespersonid, "PAYABLE", vPaidDate)

    End Sub

    Private Sub btnAddCommissionPmt_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddCommissionPmt.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If

        If bsCommissions.Count < 0 Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to mark all Commissions in the grid as PAID?", MsgBoxStyle.YesNo, "CONFIRM - Mark Commissions Paid") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim vDate As Date = getUserDate("Enter Commission Payment Date:")
        If IsDBNull(vDate) Then
            MsgBox("You did not enter a valid date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'The oCommissions object should now have only those records to be marked paid in it
        For Each oComm As ViewCommissionAuditAnalysis In oCommissions
            updateCommissionStatus(oComm.Commissionid, "PAID", vDate)
        Next

        'now show commission payment register
        'Dim rpt As New rptCommissions(bsSalesperson.Current.SalesPersonID, "PAID", vDate)
        Dim rpt As New rptCommissionsWithExceptions(bsSalesperson.Current.SalesPersonID, "PAID", vDate)
        rpt.ShowPreview()

        loadCommissions(bsSalesperson.Current.salespersonid, "PAYABLE")

    End Sub

    Private Sub btnPrintCommPmtRegister_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintCommPmtRegister.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If

        'show form to select date commissions were paid to get the right commission payment register
        Dim frm As New frmGetDateFromLookup()
        frm.vType = "COMMISSIONPAYMENTDATES"
        frm.vRefID = bsSalesperson.Current.SalespersonID
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.Cancel Then
            Exit Sub
        Else
            Dim rpt As New rptCommissions(bsSalesperson.Current.SalesPersonID, "PAID", frm.vDatePicked)
            rpt.ShowPreview()
        End If

    End Sub

    Private Sub rbtnMiscMarkPayableAsPaid_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMiscMarkPayableAsPaid.ItemClick
        If bsCommissions.Count < 0 Then
            Exit Sub
        End If

        If grvCommissions.SelectedRowsCount <= 0 Then
            MsgBox("There are no Commission records selected to update", MsgBoxStyle.Critical, "Error - no records selected")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to mark the selected Commissions as PAID?", MsgBoxStyle.YesNo, "Confirm - Mark PAID") = MsgBoxResult.No Then
            Exit Sub
        End If


        Dim vDate As Date = getUserDate("Enter Commission Payment Date:")
        If IsDBNull(vDate) Then
            MsgBox("You did not enter a valid date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'Create an array and pull selected records
        Dim SelectedRows(0, 0) As Integer
        ReDim SelectedRows(grvCommissions.SelectedRowsCount - 1, 0)
        Dim I As Integer
        For I = 0 To SelectedRows.GetUpperBound(0)
            Try
                grvCommissions.GetRowCellDisplayText(grvCommissions.GetSelectedRows(I), colCommissionid1)
                updateCommissionStatus(grvCommissions.GetRowCellDisplayText(grvCommissions.GetSelectedRows(I), colCommissionid1), "PAID", vDate)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        loadCommissions(bsSalesperson.Current.salespersonid, "PAYABLE")


    End Sub

    Private Sub grvCommissions_RowStyle(sender As Object, e As RowStyleEventArgs) Handles grvCommissions.RowStyle

        If (e.RowHandle >= 0) Then

            'Check to see if Commission has a variance 
            Dim vVariance As Decimal = grvCommissions.GetRowCellDisplayText(e.RowHandle, grvCommissions.Columns("Variance"))
            Dim vAudited As String = grvCommissions.GetRowCellDisplayText(e.RowHandle, grvCommissions.Columns("Auditflag"))
            If vVariance <> 0 And vAudited = "N" Then
                e.Appearance.BackColor = Color.Pink
                e.Appearance.BackColor2 = Color.Pink
                e.Appearance.ForeColor = Color.Black
                Exit Sub
            End If

        End If

    End Sub

    Private Sub rbtnMarkCommissionAsAudited_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkCommissionAsAudited.ItemClick
        If bsCommissions.Count <= 0 Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to mark the selected commission record as PERMANENTLY AUDITED?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oComm As New Commission
        If Not oComm.LoadByPrimaryKey(bsCommissions.Current.CommissionID) Then
            MsgBox("Could not retrieve selected Commission record from the database", MsgBoxStyle.Critical, "Error - No data retrieved")
            Exit Sub
        End If

        Dim vAuditReason As String = Nothing
        vAuditReason = getUserString("Enter a reason for Audit Approval:")
        oComm.Commissionnote = vAuditReason
        oComm.Audited = True
        oComm.Save()

        loadCommissions(bsSalesperson.Current.salespersonid, vCommFilter)
    End Sub

    Private Sub btnRptCommWithExceptions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptCommWithExceptions.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptCommissionsWithExceptions(bsSalesperson.Current.SalesPersonID, "PENDING")
        rpt.ShowPreview()
    End Sub

    Private Sub rbtnRptPayableWithExceptions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRptPayableWithExceptions.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptCommissionsWithExceptions(bsSalesperson.Current.SalesPersonID, "PAYABLE")
        rpt.ShowPreview()
    End Sub

    Private Sub rbtnPrintCommPmtRegisterWithExceptions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintCommPmtRegisterWithExceptions.ItemClick
        If bsSalesperson.Count <= 0 Then
            Exit Sub
        End If

        'show form to select date commissions were paid to get the right commission payment register
        Dim frm As New frmGetDateFromLookup()
        frm.vType = "COMMISSIONPAYMENTDATES"
        frm.vRefID = bsSalesperson.Current.SalespersonID
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.Cancel Then
            Exit Sub
        Else
            Dim rpt As New rptCommissionsWithExceptions(bsSalesperson.Current.SalesPersonID, "PAID", frm.vDatePicked)
            rpt.ShowPreview()
        End If
    End Sub

    Private Sub rbtnGetAllCustomersSales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetAllCustomersSales.ItemClick
        Dim vStart As Date
        Dim vEnd As Date

        If IsDBNull(eHistoryStart.EditValue) Or eHistoryStart.EditValue = Nothing Then
            MsgBox("You must first select a Start Date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vStart = eHistoryStart.EditValue
        End If

        If IsDBNull(eHistoryEnd.EditValue) Or eHistoryEnd.EditValue = Nothing Then
            MsgBox("You must first select an End Date", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            vEnd = eHistoryEnd.EditValue
        End If

        Dim oSalesHistory As New ViewCustomerInvoicedItemsCollection

        oSalesHistory.Query.Where(oSalesHistory.Query.Invoicedate.Between(vStart, vEnd))
        oSalesHistory.Query.Load()
        bsSalesHistory.DataSource = oSalesHistory
        grSalesHistory.DataSource = bsSalesHistory
    End Sub








#End Region



End Class
