Imports AOS.BusinessObjects

Public Class viewPurchasing
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oVendors As VendorCollection = Nothing
    Dim oVendorList As VendorCollection = Nothing
    Dim oProductList As ProductCollection = Nothing
    Dim oInventory As InventoryCollection = Nothing
    Dim oPOs As PoCollection = Nothing
    Dim oReq As ViewPurchaseRequestCollection = Nothing

    Private vCurrentPOStatus As String = "OPEN"
    Private vRequestsStatus As Integer = 0
  
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadVendors()
        loadVendorList()
        loadProductList()
        getPurchaseOrders(vCurrentPOStatus)
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

    Private Sub btnAddVendor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddVendor.ItemClick
        addVendor()
    End Sub

    Private Sub btnDeleteVendor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteVendor.ItemClick
        deleteVendor()
    End Sub

    Private Sub btnEditVendor_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditVendor.ItemClick
        editVendor()
    End Sub
   
    Private Sub btnRefreshInventory_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRefreshInventory.ItemClick
        getInventory()
    End Sub

    Private Sub btnEditProductInfo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditProductInfo.ItemClick
        editProductInfo()
    End Sub

    Private Sub btnCreatePO_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCreatePO.ItemClick
        createDefaultPO()
    End Sub

    Private Sub btnAddNewPO_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewPO.ItemClick
        addNewPO()
    End Sub

    Private Sub btnEditPO_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPO.ItemClick
        editPO()
    End Sub

    Private Sub btnDeletePO_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeletePO.ItemClick
        deletePO()
    End Sub

    Private Sub btnFilterOpenPOs_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterOpenPOs.ItemClick
        filterPO("OPEN")
    End Sub

    Private Sub btnFilterClosedPOs_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFilterClosedPOs.ItemClick
        filterPO("CLOSED")
    End Sub

    Private Sub btnPrintPO_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPO.ItemClick
        printPO()
    End Sub
#End Region

#Region " Data Processing "

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

    Private Sub loadVendorList()
        oVendorList = New VendorCollection
        oVendorList.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oVendorList.LoadAll()
        oVendorList.Sort = "VENDORNAME ASC"
        bsVendorList.DataSource = oVendorList
    End Sub

    Private Sub loadProductList()
        oProductList = New ProductCollection
        oProductList.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProductList.LoadAll()
        bsProducts.DataSource = oProductList
    End Sub

    Private Sub getInventory()
        oInventory = New InventoryCollection
        oInventory.LoadAll()
        oInventory.Sort = "Balance"
        bsInventory.DataSource = oInventory
    End Sub

    Private Sub getPurchaseOrders(ByVal vStatus As String)
        oPOs = New PoCollection
        If vStatus = "OPEN" Then
            oPOs.Query.Where(oPOs.Query.Postatus.Equal("OPEN"))
        Else
            oPOs.Query.Where(oPOs.Query.Postatus.NotEqual("OPEN"))
        End If
        oPOs.Query.Load()
        bsPOs.DataSource = oPOs
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

    Private Sub editProductInfo()
        If bsInventory.Count <= 0 Then
            Exit Sub
        End If
        Dim vFrm As New frmAddEditProduct
        vFrm.vEditType = "EDIT"
        vFrm.vID = bsInventory.Current.ProductID
        vFrm.ShowDialog()
        getInventory()
    End Sub

    Private Sub createDefaultPO()

        If bsInventory.Count <= 0 Then
            Exit Sub
        End If

        Dim oProduct As Product
        Dim oPO As Po
        Dim oPOItem As Poitem
        Dim oParms As Sysparameters
        
        Dim vPONum As Integer
        Dim vVendorID As Integer
        Dim vProductID As Integer
        Dim vCost As Decimal
        Dim vExtCost As Decimal
        Dim vUnits As Integer
        Dim vUOM As String
        Dim vProductdesc As String
        Dim vQty As Integer
        Dim vContainer As String

        vProductID = bsInventory.Current.ProductID
        vContainer = bsInventory.Current.Container

        'get parms
        oParms = New Sysparameters
        oParms.LoadByPrimaryKey(1)

        'get product cost info
        Dim verifiedCostRecord As Boolean = True
        Dim frm As New frmViewProductCostRecords
        frm.vProductID = vProductID
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            'user selected a product cost record for use in creating the default purchase order
            'now validate the select cost record to be sure all necessary data is in the record
            While True
                If IsDBNull(frm.oCost.Unitcost) Then
                    MsgBox("No Unit Cost data found in the selected product cost record", MsgBoxStyle.Critical, "Error")
                    verifiedCostRecord = False
                    Exit While
                End If
                If IsDBNull(frm.oCost.Units) Then
                    MsgBox("No Units data found in the selected product cost record", MsgBoxStyle.Critical, "Error")
                    verifiedCostRecord = False
                    Exit While
                End If
                If IsDBNull(frm.oCost.Vendorid) Then
                    MsgBox("No Vendor data found in the selected product cost record", MsgBoxStyle.Critical, "Error")
                    verifiedCostRecord = False
                    Exit While
                End If
                If frm.oCost.Unitcost <= 0 Then
                    MsgBox("Unit Cost value must be greater than 0 in the selected product cost record", MsgBoxStyle.Critical, "Error")
                    verifiedCostRecord = False
                    Exit While
                End If
                If frm.oCost.Units <= 0 Then
                    MsgBox("Number of Units must be greater than 0 in the selected product cost record", MsgBoxStyle.Critical, "Error")
                    verifiedCostRecord = False
                    Exit While
                End If
                Exit While
            End While
        Else
            'no product cost record selected - have to end process here.
            MsgBox("No product cost record selected.", MsgBoxStyle.Critical, "Error - No product cost data")
            verifiedCostRecord = False
        End If

        If verifiedCostRecord = False Then
            MsgBox("You must select a complete product cost record in order to create a purchase order for the select product", MsgBoxStyle.Critical, "Error - Purchase Order creation failed")
            Exit Sub
        End If

        vVendorID = frm.oCost.Vendorid
        vUnits = frm.oCost.Units
        vCost = frm.oCost.Unitcost * frm.oCost.Units
        vUOM = frm.oCost.Uom

        'get product information
        oProduct = New Product
        If Not oProduct.LoadByPrimaryKey(vProductID) Then
            MsgBox("Error is looking up select product information", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If IsDBNull(oProduct.Reorderqty) Or oProduct.Reorderqty <= 0 Then
            Dim frmInfo As New frmGetDataItem
            frmInfo.vInputType = "STRING"
            frmInfo.vPrompt = "Enter Reorder quantity:"
            frmInfo.ShowDialog()
            Try
                Dim vRQ As Double
                vRQ = CDbl(frmInfo.vString)
                oProduct.Reorderqty = vRQ
                oProduct.Save()
            Catch ex As Exception
                MsgBox("Error in setting the default reorder quantity.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End Try
        End If
        vQty = oProduct.Reorderqty
        vContainer = oProduct.Container
        vProductdesc = oProduct.Productdesc
        vExtCost = vCost * vQty

        'at this point we should have all the data we need to create the Purchase Order

        'add new PO record
        oPO = New Po
        oPO.AddNew()
        oPO.Podate = Today
        oPO.Vendorid = vVendorID
        oPO.Postatus = "OPEN"
        oPO.Poterms = "NET 30"
        oPO.Potype = "REGULAR"
        oPO.Shipname = oParms.CompanyName
        oPO.Shipaddress1 = oParms.CompanyAddress
        oPO.Shipcity = oParms.CompanyCity
        oPO.Shipstate = oParms.CompanyState
        oPO.Shipzip = oParms.CompanyZipcode
        oPO.Shipphone = oParms.CompanyPhone
        oPO.Save()
        vPONum = oPO.Ponumber.Value

        'add new PO Item record
        oPOItem = New Poitem
        oPOItem.AddNew()
        oPOItem.Ponumber = vPONum
        oPOItem.Productid = vProductID
        oPOItem.Productdesc = vProductdesc
        oPOItem.Qtyordered = vQty
        oPOItem.Qtycanceled = 0
        oPOItem.Qtyreceived = 0
        oPOItem.Qtyreleased = 0
        oPOItem.Unitcost = vCost
        oPOItem.Unitorcontainer = "C"
        oPOItem.Extcost = vExtCost
        oPOItem.Units = vUnits
        oPOItem.Uom = vUOM
        oPOItem.Save()

        Dim frmPO As New frmAddEditPurchaseOrder
        frmPO.vEditType = "EDIT"
        frmPO.vPONum = vPONum
        frmPO.ShowDialog()
        getPurchaseOrders(vCurrentPOStatus)
        getInventory()


    End Sub

    Private Sub addNewPO()
        Dim frm As New frmAddEditPurchaseOrder
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getPurchaseOrders("OPEN")
    End Sub

    Private Sub editPO()
        If bsPOs.Count <= 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditPurchaseOrder
        frm.vEditType = "EDIT"
        frm.vPONum = bsPOs.Current.PONumber
        frm.ShowDialog()
        getPurchaseOrders(vCurrentPOStatus)
    End Sub

    Private Sub deletePO()
        If bsPOs.Count <= 0 Then
            Exit Sub
        End If
        Dim vConfirm As String = "Are you sure you want to delete the selected Purchase Order?"
        If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand
        Try
            str = "DELETE FROM POITEM WHERE PONUMBER = " & bsPOs.Current.PONumber.ToString
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("There was an error in attempting to delete the Items from the selected Purchase Order", MsgBoxStyle.Critical, "Error - Deletion Failed")
            Exit Sub
        Finally
            sqlcnn.Close()
        End Try
        Try
            str = "DELETE FROM PO WHERE PONUMBER = " & bsPOs.Current.PONumber.ToString
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("There was an error in attempting to delete the selected Purchase Order", MsgBoxStyle.Critical, "Error - Deletion Failed")
            Exit Sub
        Finally
            sqlcnn.Close()
        End Try
        MsgBox("Purchase Order successfully deleted", MsgBoxStyle.Information, "Success")
        getPurchaseOrders(vCurrentPOStatus)
    End Sub

    Private Sub filterPO(ByVal vPOStatus As String)
        vCurrentPOStatus = vPOStatus
        getPurchaseOrders(vCurrentPOStatus)
    End Sub

    Private Sub printPO()
        If bsPOs.Count <= 0 Then
            Exit Sub
        End If
        Dim vNum As Integer
        vNum = bsPOs.Current.PONumber
        Dim rpt As New rptPurchaseOrder(vNum)
        rpt.ShowPreview()
    End Sub


#End Region

    Private Sub viewSalesCustomers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()
        ' setRibbonOptions(vCurrentUserSecurityLevel)
        setRibbonOptionsSecurity(vCurrentUserID)

        ' Call Security Timer to start hiding/showing Groups and Functions based on the security settings 
        StartSecurityTimer()

    End Sub



    Private Sub rbtnReceivePurchaseOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReceivePurchaseOrder.ItemClick

        If bsPOs.Count <= 0 Then
            Exit Sub
        End If

        Dim str As String = "This action will mark all items on the selected purchase order as RECEIVED. Is this what you want to do?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim rItems As PoitemCollection
        Dim rPO As Po
        Try
            rItems = New PoitemCollection
            rItems.Query.Where(rItems.Query.Ponumber.Equal(bsPOs.Current.PONumber))
            If rItems.Query.Load Then
                For Each rItem As Poitem In rItems
                    rItem.Qtyreceived = rItem.Qtyordered - rItem.Qtycanceled
                Next
                rItems.Save()
            End If
            rPO = New Po
            rPO.Postatus = "CLOSED"
            rPO.Save()
            MsgBox("Purchase Order successfully updated", MsgBoxStyle.Information, "Success")
            getPurchaseOrders(vCurrentPOStatus)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error in updating purchase order", MsgBoxStyle.Critical, "Error - Update failed")
        End Try
    End Sub

    Private Sub rbtnCancelPurchaseOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancelPurchaseOrder.ItemClick

        If bsPOs.Count <= 0 Then
            Exit Sub
        End If

        Dim str As String = "This action will mark all items on the selected purchase order as CANCELLED. Is this what you want to do?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim rItems As PoitemCollection
        Dim rPO As Po
        Try
            rItems = New PoitemCollection
            rItems.Query.Where(rItems.Query.Ponumber.Equal(bsPOs.Current.PONumber))
            If rItems.Query.Load Then
                For Each rItem As Poitem In rItems
                    rItem.Qtycanceled = rItem.Qtyordered
                Next
                rItems.Save()
            End If
            rPO = New Po
            rPO.Postatus = "CLOSED"
            rPO.Save()
            MsgBox("Purchase Order successfully cancelled", MsgBoxStyle.Information, "Success")
            getPurchaseOrders(vCurrentPOStatus)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error in updating purchase order", MsgBoxStyle.Critical, "Error - Update failed")
        End Try
    End Sub

    Private Sub rbtnReopenPurchaseOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReopenPurchaseOrder.ItemClick

        If bsPOs.Count <= 0 Then
            Exit Sub
        End If

        Dim str As String = "This action will REOPEN the selected purchase order. Items received or cancelled on the purchase order will NOT be changed by this action. Is this what you want to do?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim rPO As Po
        Try
            rPO = New Po
            rPO.Postatus = "OPEN"
            rPO.Save()
            MsgBox("Purchase Order successfully reopened", MsgBoxStyle.Information, "Success")
            getPurchaseOrders(vCurrentPOStatus)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error in updating purchase order", MsgBoxStyle.Critical, "Error - Update failed")
        End Try

    End Sub

    Private Sub rbtnGetPurchaseRequests_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetPurchaseRequests.ItemClick
        getPurchaseRequests(0)
    End Sub

    Private Sub getPurchaseRequests(vFilter As Integer)
        oReq = New ViewPurchaseRequestCollection
        Try
            oReq.Query.Where(oReq.Query.IsOrdered.Equal(vFilter))
            oReq.Query.Load()
            bsPurchaseRequests.DataSource = oReq
        Catch ex As Exception
            MsgBox("Error retrieving Purchase Requests from database", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub rbtnOpenRequests_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnOpenRequests.ItemClick
        vRequestsStatus = 0
        getPurchaseRequests(vRequestsStatus)
    End Sub

    Private Sub rbtnClosedRequests_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnClosedRequests.ItemClick
        vRequestsStatus = 1
        getPurchaseRequests(vRequestsStatus)
    End Sub

    Private Sub rbtnCreatePurchaseOrderFromRequest_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCreatePurchaseOrderFromRequest.ItemClick
        MsgBox("Not implemented yet")
    End Sub

    Private Sub rbtnAddPurchaseRequest_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddPurchaseRequest.ItemClick
        addNewPurchaseRequest()
    End Sub

    Private Sub rbtnEditPurchaseRequest_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditPurchaseRequest.ItemClick
        If bsPurchaseRequests.Count <= 0 Then
            Exit Sub
        End If
        editPurchaseRequest(bsPurchaseRequests.Current.PurchReqID)
    End Sub

    Private Sub rbtnDeletePurchaseRequest_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeletePurchaseRequest.ItemClick
        If bsPurchaseRequests.Count <= 0 Then
            Exit Sub
        End If
        deletePurchaseRequest(bsPurchaseRequests.Current.PurchReqID)
    End Sub

    Private Sub addNewPurchaseRequest()
        Dim frm As New frmAddEditPurchaseRequest
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getPurchaseRequests(vRequestsStatus)
    End Sub

    Private Sub editPurchaseRequest(vReqKey As Integer)
        Dim frm As New frmAddEditPurchaseRequest
        frm.vID = vReqKey
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getPurchaseRequests(vRequestsStatus)
    End Sub

    Private Sub deletePurchaseRequest(vReqKey As Integer)
        Dim str As String = "Are you sure you want to delete the selected Purchase Request?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim rReq As New PurchaseRequest
        Try
            rReq.LoadByPrimaryKey(vReqKey)
            rReq.MarkAsDeleted()
            rReq.Save()
            MsgBox("Purchase Request successfully deleted", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox("Error in deleteing purchase request", MsgBoxStyle.Critical, "Error")
        End Try

        getPurchaseRequests(vRequestsStatus)

    End Sub

    Private Sub btnCOAText_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCOAText.ItemClick
        Dim frm As New frmCOAText()
        frm.ShowDialog()
    End Sub

    Private Sub rbtnPrintPOItemList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintPOItemList.ItemClick
        Dim rpt As New rptPOItemList(bsPOs.Current.PONUmber)
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
