Imports AOS.BusinessObjects


Public Class viewInventory
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Dim oProductCollection As ViewChemicalProductLinkCollection = Nothing
    Dim oKitInfo As ViewKitInfoCollection

    Dim vProductListFilter As String = "ACTIVE"

    Private vWorkOrderStatus As String

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

#Region " RIBBON PROCESSING "

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

#Region " DATA PROCESSING "


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        vWorkOrderStatus = "OPEN"
        filterItemStatus.EditValue = InventoryItemStatus.AVAILABLE.ToString()
        getProducts()
        getItemStatusLookupList()
        getItemClassLookupList()
        getVendors()

        getCustomers()
        getWorkOrders(vWorkOrderStatus)
        getComponent()
        getKit()
        selectView("gcComponent", False)

    End Sub

    Private Sub getProducts()
        oProductCollection = New ViewChemicalProductLinkCollection
        If vProductListFilter = "ALL" Then
            oProductCollection.LoadAll()
            gcProducts.Text = "ALL Products"
        Else
            oProductCollection.Query.Where(oProductCollection.Query.Productstatus.Equal(vProductListFilter))
            oProductCollection.Query.Load()
            gcProducts.Text = vProductListFilter + " Products"
        End If
        oProductCollection.Filter = ""
        oProductCollection.Sort = "PRODUCTDESC ASC"
        bsProducts.DataSource = oProductCollection
        Me.grProducts.DataSource = bsProducts
        Me.grProducts.Refresh()
    End Sub

    Private Sub getItemStatusLookupList()
        Dim oItemStatus As New ListInvitemstatusCollection
        Try
            oItemStatus.LoadAll()
            oItemStatus.Sort = "LookUpDesc ASC"
            bsItemStatus.DataSource = oItemStatus
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getItemClassLookupList()
        Dim oInvClass As New ListInventoryclassCollection
        Try
            oInvClass.LoadAll()
            bsInventoryClass.DataSource = oInvClass
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getItems(ByVal vProductID As Integer)
        Dim oItems As New InvitemCollection
        oItems.Query.Where(oItems.Query.Productid.Equal(vProductID))
        oItems.Query.Load()
        Try
            bsItems.DataSource = oItems
            grItems.DataSource = Nothing
            grItems.DataSource = bsItems
            grItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getInventoryItems(ByVal vItemType As Integer, ByVal vItemStatus As String)

        vItemStatus = vItemStatus.Replace(", ", "', '")

        Dim id As Integer = InventoryList.GetRowCellValue(InventoryList.FocusedRowHandle, InventoryList.Columns(0))

        Dim oInventoryItems As New InvitemCollection
        oInventoryItems.Query.Where(oInventoryItems.Query.Inventoryclass.Equal(vItemType), oInventoryItems.Query.Itemstatus.In(vItemStatus))
        oInventoryItems.Query.Load()
        Try
            bsInventoryItems.DataSource = oInventoryItems
            grInventoryItems.DataSource = bsInventoryItems
            grInventoryItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        InventoryList.LocateByValue(0, InventoryList.Columns(0), id)
        InventoryList.MakeRowVisible(InventoryList.FocusedRowHandle, False)

    End Sub

    Private Sub getInventoryItemsByCategory(vItemCategory As String)
        Dim oInventoryItems As New InvitemCollection
        Select Case vItemCategory
            Case "FINISHED GOODS"
                oInventoryItems.Query.Where(oInventoryItems.Query.Inventoryclass.Equal(1), oInventoryItems.Query.Itemstatus.In("AVAILABLE", "ALLOCATED", "TESTING", "PENDING", "INPROD", "RCVDHOLD"))
                oInventoryItems.Query.Load()
            Case "RAW MATERIALS"
                oInventoryItems.Query.Where(oInventoryItems.Query.Inventoryclass.Equal(2), oInventoryItems.Query.Itemstatus.In("IN PROCESS", "PENDING", "TESTING", "INPROD", "RCVDHOLD"))
                oInventoryItems.Query.Load()
            Case "ALL"
                oInventoryItems.LoadAll()
        End Select
        bsInventoryItems.DataSource = oInventoryItems
        grInventoryItems.DataSource = bsInventoryItems
        grInventoryItems.Refresh()
    End Sub

    Private Sub getVendors()
        Dim oVendors As New VendorCollection
        oVendors.LoadAll()
        bsVendors.DataSource = oVendors
    End Sub

    Private Sub getCustomers()
        Dim oCustomers As New CustomerCollection
        oCustomers.LoadAll()
        bsCustomers.DataSource = oCustomers
    End Sub

    Private Sub getWorkOrders(ByVal vOrderStatus As String)
        Dim oWorkOrders As New WorkorderCollection
        oWorkOrders.Query.Where(oWorkOrders.Query.Orderstatus.Equal(vOrderStatus))
        oWorkOrders.Query.Load()
        oWorkOrders.Sort = "WORKORDERNUMBER"
        bsWorkOrders.DataSource = oWorkOrders
        Me.grWorkOrders.DataSource = bsWorkOrders
        Me.grWorkOrders.Refresh()
        GridView6.GroupPanelText = vOrderStatus & " Work Orders"
    End Sub

    Private Sub saveDataChanges()
        oProductCollection.Save()
    End Sub



#End Region

#Region " PRODUCTS "
    Private Sub btnAddProduct_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddProduct.ItemClick
        addProduct()
    End Sub

    Private Sub btnDeleteProduct_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteProduct.ItemClick
        If bsProducts.Count <= 0 Then
            Exit Sub
        End If
        deleteProduct()
    End Sub

    Private Sub btnEditProduct_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditProduct.ItemClick
        If bsProducts.Count <= 0 Then
            Exit Sub
        End If
        editProduct()
    End Sub

    Private Sub btnPrintItemLabel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintItemLabel.ItemClick
        printItemLabel()
    End Sub

    Private Sub btnPrintProductLabel_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintProductLabel.ItemClick
        If bsProducts.Count <= 0 Then
            Exit Sub
        End If
        printProductLabel()
    End Sub

    Private Sub editProduct()
        Dim frm As New frmAddEditProduct
        frm.vID = Me.bsProducts.Current.productID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getProducts()
    End Sub

    Private Sub addProduct()
        Dim frm As New frmAddEditProduct
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        vResult = frm.ShowDialog()
        getProducts()
    End Sub

    Private Sub deleteProduct()
        Dim str As String
        str = "Are you sure you want to delete the selected product?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If

        If isActiveProduct(bsProducts.Current.productID) Then
            MsgBox("The Product you selected cannot be deleted. It is in use in one or more processes in the database. You may want to change the status to INACTIVE.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Try
            Dim oProduct As Product
            oProduct = New Product
            oProduct.LoadByPrimaryKey(bsProducts.Current.productID)
            oProduct.MarkAsDeleted()
            oProduct.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try

        getProducts()

    End Sub

    Private Sub printItemLabel()

        Dim vLot As String = Nothing
        Dim vRes As String = Nothing
        Dim frmLot As New frmLotResInfo
        frmLot.ShowDialog()
        vLot = frmLot.vLot
        vRes = frmLot.vRes

        Dim vID As Integer = 0
        Try
            vID = bsItems.Current.invItemNumber
        Catch ex As Exception
        End Try
        If vID = 0 Then
            MsgBox("You must select an Inventory Item first", MsgBoxStyle.Critical, "Error - No Item")
            Exit Sub
        End If

        ''open form to view the BOL report, pass the shipment number parameter for data selection
        'Dim frm As New frmRptProductLabel
        'frm.vProductId = vID
        'frm.vLot = vLot
        'frm.vRes = vRes
        'frm.ShowDialog()

        Dim tbl As New dsHazMatLabelTableAdapters.HazMatLabelTableAdapter
        Dim dt As New AOS.dsHazMatLabel.HazMatLabelDataTable
        Try
            tbl.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            tbl.FillHazMatLabel(dt, vLot, vRes, vID)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Dim rpt As New rptProductLabel
        rpt.DataSource = dt
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub printProductLabel()


        Dim vLot As String = Nothing
        Dim vRes As String = Nothing
        Dim frmLot As New frmLotResInfo
        frmLot.ShowDialog()
        vLot = frmLot.vLot
        vRes = frmLot.vRes

        Dim vID As Integer = 0
        Try
            vID = bsProducts.Current.productID
        Catch ex As Exception
        End Try
        If vID = 0 Then
            MsgBox("You must select a Product first", MsgBoxStyle.Critical, "Error - No Item")
            Exit Sub
        End If

        ''open form to view the BOL report, pass the shipment number parameter for data selection
        'Dim frm As New frmRptProductLabel
        'frm.vProductId = vID
        'frm.vLot = vLot
        'frm.vRes = vRes
        'frm.ShowDialog()

        Dim tbl As New dsHazMatLabelTableAdapters.HazMatLabelTableAdapter
        Dim dt As New AOS.dsHazMatLabel.HazMatLabelDataTable
        Try
            tbl.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            tbl.FillByProductID(dt, vLot, vRes, vID)
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Dim rpt As New rptProductLabelNoBarCode
        rpt.DataSource = dt
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    'Private Function printMiniBarcodeLabel(ByVal InvItems As Array) As Boolean

    '    Dim DymoAddIn As Dymo.DymoAddIn
    '    Dim DymoLabels As Dymo.DymoLabels

    '    DymoAddIn = New Dymo.DymoAddIn
    '    DymoLabels = New Dymo.DymoLabels

    '    Dim vLabelName As String = Application.StartupPath & "\AmericoMiniBarcode.LWL"

    '    Try
    '        DymoAddIn.Open(vLabelName)
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try

    '    DymoAddIn.StartPrintJob()
    '    Dim x As Integer
    '    For x = 0 To InvItems.GetUpperBound(0)
    '        Try
    '            DymoLabels.SetField("ProductInfo", InvItems(x, 1))
    '            DymoLabels.SetField("ProductBarcode", InvItems(x, 0))
    '            DymoLabels.SetField("LotNumber", InvItems(x, 2))
    '            DymoLabels.SetField("WarehouseLocation", InvItems(x, 3))
    '            DymoLabels.SetField("Container", InvItems(x, 4))

    '            ' It's a good idea to always wrap StartPrintJob() and EndPrintJob() around a call to Print() or Print2() function.

    '            DymoAddIn.Print(1, True)
    '            ' ATTENTION: Every StartPrintJob() must have a matching EndPrintJob()

    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            Return False
    '        End Try
    '    Next
    '    DymoAddIn.EndPrintJob()

    '    Return True

    'End Function

    Private Sub bsProducts_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles bsProducts.CurrentChanged
        getItems(bsProducts.Current.productID)
        getInventoryStats()
    End Sub
#End Region


#Region " FORM OBJECT PROCESSING "
    'Private Sub searchTextbox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    bsProducts.Filter = "Customer Name Like '" & sender.Text & "%'"
    '    grProducts.DataSource = bsProducts
    '    grProducts.Refresh()
    'End Sub

    'Private Sub viewCustomers_finalSaves() Handles Me.finalSaves
    '    Me.dgvProducts.EndEdit()
    '    Me.bsProducts.EndEdit()
    '    If oProductCollection.IsDirty Then
    '        If MsgBox("Do you want to save your changes?", MsgBoxStyle.YesNo, "Save Changes?") = MsgBoxResult.Yes Then
    '            oProductCollection.Save()
    '        End If
    '    End If
    'End Sub



#End Region



    Private Sub getInventoryStats()
        'eQtyAvailable.EditValue = bsProducts.Current.QtyForSale
    End Sub

    Private Sub viewInventory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()
        ' setRibbonOptions(vCurrentUserSecurityLevel)
        ' setRibbonOptions(vCurrentUserSecurityLevel)
        setRibbonOptionsSecurity(vCurrentUserID)

        ' Call Security Timer to start hiding/showing Groups and Functions based on the security settings 
        StartSecurityTimer()

    End Sub


    Private Sub SplitContainerControl1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainerControl1.Resize
        SplitContainerControl1.SplitterPosition = (SplitContainerControl1.Width / 2)
    End Sub

    Private Sub btnFetchFinishedGoods_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFetchFinishedGoods.ItemClick
        getInventoryItems(filterItemType.EditValue, filterItemStatus.EditValue)
    End Sub

    Private Sub btnPrintMiniInventoryLabels_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintMiniInventoryLabels.ItemClick
        prepareMiniBarcodeLabelFromInventoryItems()
    End Sub
    Private Sub prepareMiniBarcodeLabelFromInventoryItems()

        If InventoryList.SelectedRowsCount <= 0 Then
            MsgBox("There are no inventory items selected for printing", MsgBoxStyle.Critical, "Error - no records selected")
            Exit Sub
        End If

        'Create an array and pull inventory item data to print on Mini labels from the current selected items in the data grid
        Dim InvItems(0, 4) As String
        ReDim InvItems(InventoryList.SelectedRowsCount - 1, 4)

        Dim I As Integer
        For I = 0 To InvItems.GetUpperBound(0)
            Try
                InvItems(I, 0) = InventoryList.GetRowCellDisplayText(InventoryList.GetSelectedRows(I), colInvitemnumber1)
                InvItems(I, 1) = InventoryList.GetRowCellDisplayText(InventoryList.GetSelectedRows(I), colProductid3) & " - " & InventoryList.GetRowCellDisplayText(InventoryList.GetSelectedRows(I), colProductid4)
                InvItems(I, 2) = "Lot - " & InventoryList.GetRowCellDisplayText(InventoryList.GetSelectedRows(I), colLotnumber2)
                InvItems(I, 3) = "Bin - " & InventoryList.GetRowCellDisplayText(InventoryList.GetSelectedRows(I), colWarehouselocation2)
                InvItems(I, 4) = InventoryList.GetRowCellDisplayText(InventoryList.GetSelectedRows(I), colContainer2)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        Dim vPrintResult As Boolean = False
        If Not printBarCodeLabel(InvItems) Then
            MsgBox("There were errors in printing the requested labels", MsgBoxStyle.Critical, "Error - Printing request failed")
        Else
            MsgBox("Printing complete", MsgBoxStyle.Exclamation, "Success")
        End If

    End Sub

    Private Sub grInventoryItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grInventoryItems.DoubleClick
        If vCurrentUserSecurityLevel < 8 Then
            Exit Sub
        End If
        editInventoryItem()
    End Sub

    Private Sub editInventoryItem()
        Dim frm As New frmEditItemDetails
        frm.vID = Me.bsInventoryItems.Current.invItemNumber
        'frm.vEditType = "EDIT"
        frm.ShowDialog()
        getInventoryItems(filterItemType.EditValue, filterItemStatus.EditValue)
    End Sub



    Private Sub btnPrintAvailableInventory_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintAvailableInventory.ItemClick
        'Dim tbl As New dsAvailableInventoryTableAdapters.INVITEMAdapter
        'Dim dt As New AOS.dsAvailableInventory.INVITEMDataTable
        'Try
        '    tbl.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        '    tbl.Fill(dt)
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Exit Sub
        'End Try
        Dim rpt As New rptAvailableInventory(0)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

   

    Private Sub btnPrintAvailableInventoryByBin_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintAvailableInventoryByBin.ItemClick
        Dim rpt As New rptAvailableInventoryByBin(0)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnMaintainProducts_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMaintainProducts.ItemClick
        Dim frm As New frmMergeProducts
        frm.ShowDialog()
        getProducts()
    End Sub

    Private Sub closeWorkOrders()

        Dim vStatus As String = Nothing
        Dim str As String = Nothing
        Dim ds As New DataSet
        Dim da As SqlClient.SqlDataAdapter

        str = "SELECT * FROM WORKORDER WHERE Orderstatus = 'OPEN'"
        Try
            da = New SqlClient.SqlDataAdapter(str, sqlcnn)
            da.Fill(ds, "WorkOrder")
            If ds.Tables(0).Rows.Count <= 0 Then
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error - getting open workorders")
            Exit Sub
        End Try

        Dim dr As DataRow
        Dim vNum As Integer = 0
        For Each dr In ds.Tables(0).Rows
            vNum = IIf(IsDBNull(dr.Item("WorkOrderNumber")), 0, dr.Item("WorkOrderNumber"))
            'GridView6.GroupPanelText = "Checking Work Order # " & vNum & " for possible closure..."
            'Application.DoEvents()
            vStatus = checkToCloseOrder(vNum)
            If vStatus = "CLOSED" Then
                str = "UPDATE WorkOrder SET OrderStatus = '" & vStatus & "' WHERE WorkOrderNumber = " & vNum.ToString
                Dim cmd As SqlClient.SqlCommand
                Try
                    sqlcnn.Open()
                    cmd = New SqlClient.SqlCommand(str, sqlcnn)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Updating Order Status")
                Finally
                    sqlcnn.Close()
                End Try
            End If
        Next

        getWorkOrders(vWorkOrderStatus)

    End Sub

    Private Function checkToCloseOrder(ByVal vNum As Integer) As String

        'vNum = WorkOrderNumber
        Dim ds1 As New DataSet
        Dim ds2 As New DataSet
        Dim vStatus As String = "CLOSED"
        Dim da1 As SqlClient.SqlDataAdapter = Nothing
        Dim da2 As SqlClient.SqlDataAdapter = Nothing
        Dim str1 As String = Nothing
        Dim str2 As String = Nothing

        'Step 1 - Get WorkOrderItems into dataset to scan
        str1 = "SELECT * FROM WorkOrderItem WHERE WorkOrderNumber = " & vNum.ToString
        Try
            da1 = New SqlClient.SqlDataAdapter(str1, sqlcnn)
            da1.Fill(ds1, "WORKORDERITEM")
            If ds1.Tables(0).Rows.Count <= 0 Then
                Return "UNKNOWN"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "1 - WorkOrderItems")
            Return "UNKNOWN"
        End Try

        'Step 2 - Scan each item in workorder to determine its status
        'Assume that the WorkOrder should be CLOSED. If an item cannot be determined to be shipped,
        'then assume WorkOrder is OPEN and set status accordingly.
        Dim dr As DataRow
        Dim vItemNum As Integer = 0
        Dim vProdID As Integer = 0
        Dim vItemStatus As String = Nothing

        For Each dr In ds1.Tables(0).Rows
            Try
                vItemNum = IIf(IsDBNull(dr.Item("InvItemNumber")), 0, dr.Item("InvItemNumber"))
                vProdID = IIf(IsDBNull(dr.Item("ProductID")), 0, dr.Item("ProductID"))
                Select Case vItemNum
                    Case 0
                        If getShippingStatus(vNum, vProdID) <> "SHIPPED" Then
                            'item has not been shipped, workorder should remain open
                            'set orderstatus to OPEN and exit loop - we're done here
                            vStatus = "OPEN"
                        End If
                    Case Else
                        If getItemStatus(vItemNum) <> "SHIPPED" Then
                            'item has not been shipped, workorder should remain open
                            'set orderstatus to OPEN and exit loop - we're done here
                            vStatus = "OPEN"
                        End If
                End Select
            Catch ex As Exception
                MsgBox(ex.Message)
                Return "UNKNOWN"
            End Try
        Next

        Return vStatus

    End Function

    Private Function getShippingStatus(ByVal vNum As Integer, ByVal vProdID As Integer) As String

        Dim vOrdered As Integer = 0
        Dim vShipped As Integer = 0
        Dim vRemain As Integer = 0
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand = Nothing

        sqlcnn.Close()
        Try
            str = "SELECT SUM(qtyContainers) as TotalOrdered FROM WORKORDERITEM WHERE WorkOrderNumber = " & vNum.ToString & " AND ProductID = " & vProdID.ToString
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            vOrdered = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GetShippingStatus - Qty Ordered")
            Return "UNKNOWN"
        Finally
            sqlcnn.Close()
        End Try

        Try
            str = "select sum(b.QtyContainers) as totalshipped from Shipment a, ShipmentDetail b where a.ShipmentNumber = b.ShipmentNumber and a.WorkOrderNumber = " & vNum.ToString & " and b.ProductID = " & vProdID.ToString
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            vShipped = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "GetShippingStatus - Qty Shipped")
            Return "UNKNOWN"
        Finally
            sqlcnn.Close()
        End Try

        vRemain = vOrdered - vShipped
        If vRemain <= 0 Then
            Return "SHIPPED"
        Else
            Return "UNKNOWN"
        End If


    End Function

    Private Function getItemStatus(ByVal vItemNum As Integer) As String

        Dim vStatus As String = "UNKNOWN"
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand = Nothing

        sqlcnn.Close()
        Try
            str = "SELECT itemStatus FROM INVITEM WHERE InvItemNumber = " & vItemNum.ToString
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            vStatus = IIf(IsDBNull(cmd.ExecuteScalar), "UNKNOWN", cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "getItemStatus")
            Return "UNKNOWN"
        Finally
            sqlcnn.Close()
        End Try

        Return vStatus

    End Function

    Private Sub btnInventoryFloorReport_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInventoryFloorReport.ItemClick
        Dim rpt As New rptInventoryFloor(0)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnPLReport_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPLReport.ItemClick
        If eReportStartDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If eReportEndDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim sdate As DateTime = eReportStartDate.EditValue
        Dim edate As DateTime = eReportEndDate.EditValue
        Dim rpt As New rptProduction1(sdate, edate)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnRptInventoryDetail_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptInventoryDetail.ItemClick
        Dim rpt As New rptInventoryDetail(0)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnOnFloorValuationReport_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOnFloorValuationReport.ItemClick
        Dim rpt As New rptInventoryOnFloorWithCosts
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnRptInventoryDetailAvailableOnly_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptInventoryDetailAvailableOnly.ItemClick
        Dim rpt As New rptInventoryDetailAvailableOnly(0)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnCopyProductToNew_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCopyProductToNew.ItemClick

        If bsProducts.Count <= 0 Then
            Exit Sub
        End If

        Dim prodCurr As New Product
        Dim prodNew As New Product

        If Not prodCurr.LoadByPrimaryKey(Me.bsProducts.Current.productID) Then
            MsgBox("Could not retrieve current product information to copy", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim str As String = "Are you sure you want to creat a new Product Record from " & prodCurr.Productid & " - " & prodCurr.Productdesc & "?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Copy Request") = MsgBoxResult.No Then
            Exit Sub
        End If

        'copy current product to a new product instance
        prodNew.AddNew()
        prodNew.Productdesc = prodCurr.Productdesc
        prodNew.Classrate = prodCurr.Classrate
        prodNew.Container = prodCurr.Container
        prodNew.Datecostlastchanged = prodCurr.Datecostlastchanged
        prodNew.Desc2 = prodCurr.Desc2
        prodNew.Dotdesc = prodCurr.Dotdesc
        prodNew.Fire = prodCurr.Fire
        prodNew.Hazmatdesc = prodCurr.Hazmatdesc
        prodNew.Hazmatid = prodCurr.Hazmatid
        prodNew.Health = prodCurr.Health
        prodNew.Personalprotection = prodCurr.Personalprotection
        prodNew.Placardrequired = prodCurr.Placardrequired
        prodNew.Qtyallocated = prodCurr.Qtyallocated
        prodNew.Qtyforsale = prodCurr.Qtyforsale
        prodNew.Qtyminonhand = prodCurr.Qtyminonhand
        prodNew.Qtyonhand = prodCurr.Qtyonhand
        prodNew.Qtyonorder = prodCurr.Qtyonorder
        prodNew.Reactivity = prodCurr.Reactivity
        prodNew.Reorderqty = prodCurr.Reorderqty
        prodNew.Stdgallons = prodCurr.Stdgallons
        prodNew.Stdweight = prodCurr.Stdweight
        prodNew.Unitcost = prodCurr.Unitcost
        prodNew.Units = prodCurr.Units
        prodNew.Unline = prodCurr.Unline
        prodNew.Uom = prodCurr.Uom
        prodNew.Createdby = vCurrentUserLogin
        prodNew.Createdtime = Now
        prodNew.Modifyby = vCurrentUserLogin
        prodNew.Modifytime = Now
        prodNew.Chemicalid = prodCurr.Chemicalid
        prodNew.Save()

        Dim frm As New frmAddEditProduct
        frm.vID = prodNew.Productid
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getProducts()

    End Sub

    Private Sub btnPrintReceivingHistory_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        If eReportStartDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If eReportEndDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim sdate As DateTime = eReportStartDate.EditValue
        Dim edate As DateTime = eReportEndDate.EditValue
        Dim rpt As New rptReceivingHistory(sdate, edate)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnFixItems_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnFixItems.ItemClick
        Dim str As String
        Dim cmd As SqlClient.SqlCommand

        Try
            sqlcnn.Open()
            str = "UPDATE INVITEM SET INVENTORYCLASS = 1 WHERE INVENTORYCLASS IS NULL"
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
            MsgBox("You have successfully updated all inventory items that were previously missing", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Update Failed")
        Finally
            sqlcnn.Close()
        End Try
    End Sub

   
    

    Private Sub btnManageContainers_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnManageContainers.ItemClick
        Dim frm As New frmManageContainers
        frm.ShowDialog()
    End Sub

    Private Sub btnPrintWOSales_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintWOSales.ItemClick
        If eReportStartDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If eReportEndDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim sdate As DateTime = eReportStartDate.EditValue
        Dim edate As DateTime = eReportEndDate.EditValue
        Dim rpt As New rptWOSales(sdate, edate)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnPrintMaxItemsbyStatus_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintMaxItemsbyStatus.ItemClick
        Dim rpt As New rptMaxInvItemsByStatus
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnPrintWOBarcodesReport_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintWOBarcodesReport.ItemClick
        If bsWorkOrders.Count <= 0 Then
            Exit Sub
        End If

        Dim rpt As New rptWOBarcodes(Me.bsWorkOrders.Current.workOrderNumber)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub rbtnPrintTotalInventoryByProduct_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintTotalInventoryByProduct.ItemClick
        Dim rpt As New rptTotalInventoryByProduct
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rbtnInventoryAnalysisByProduct_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim rpt As New rptInventoryAnalysisByProduct
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rbtnInventoryAnalysisShortList_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnInventoryAnalysisShortList.ItemClick
        Dim rpt As New rptInventoryAnalysisByProductShortList
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub btnRptInventoryAnalysisAll_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRptInventoryAnalysisAll.ItemClick
        Dim rpt As New rptInventoryAnalysisAllProducts
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rbtnCurrentPhysicalInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCurrentPhysicalInventory.ItemClick
        Dim rpt As New rptCurrentPhysicalInventoryByBin
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rbtnInventoryAnalysisNonShortList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnInventoryAnalysisNonShortList.ItemClick
        Dim rpt As New rptInventoryAnalysisByProductNonShortList
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rbtnCurrentQuarantined_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCurrentQuarantined.ItemClick
        Dim rpt As New rptCurrentQuarantined
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

    Private Sub btnPLNReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPLNReport.ItemClick
        If eReportStartDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If eReportEndDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim sdate As DateTime = eReportStartDate.EditValue
        Dim edate As DateTime = eReportEndDate.EditValue
        Dim rpt As New rptProduction1_NEW(sdate, edate)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        rpt.ShowPreview()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub bsComponent_CurrentChanged(sender As Object, e As EventArgs) Handles bsComponent.CurrentChanged
        getAltComponent(bsComponent.Current.componentID)
    End Sub

    Private Sub bsKit_CurrentChanged(sender As Object, e As EventArgs) Handles bsKit.CurrentChanged
        getKitItem(bsKit.Current.kitID)
    End Sub

    Private Sub getAltComponent(ByVal vComponentID As Integer)
        Dim oAltComponent As New ViewAltComponentCollection
        oAltComponent.Query.Where(oAltComponent.Query.Componentid.Equal(vComponentID))
        oAltComponent.Query.Load()
        Try
            bsAltComponent.DataSource = oAltComponent
            grAltComponents.DataSource = bsAltComponent
            grAltComponents.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getKitItem(ByVal vKitID As Integer)
        Dim oKitItem As New ViewKitComponentCollection
        oKitItem.Query.Where(oKitItem.Query.Kitid.Equal(vKitID))
        oKitItem.Query.Load()
        Try
            bsKitItem.DataSource = oKitItem
            grKitItem.DataSource = bsKitItem
            grKitItem.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub getComponent()
        Dim oComponent As New ComponentCollection
        oComponent.LoadAll()
        oComponent.Sort = "COMPONENTID ASC"
        bsComponent.DataSource = oComponent

        Me.grComponents.DataSource = bsComponent
        Me.grComponents.Refresh()

    End Sub
    Private Sub getKit()
        oKitInfo = New ViewKitInfoCollection
        oKitInfo.LoadAll()
        oKitInfo.Sort = "KitID ASC"
        bsKit.DataSource = oKitInfo
        Me.grKit.DataSource = bsKit
        Me.grKit.Refresh()
    End Sub

    Private Sub btnAddComponent_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddComponent.ItemClick
        Using frm As New frmAddEditComponents() With
            {.vEditType = "ADD"}
            frm.ShowDialog()
        End Using
        getComponent()
    End Sub

    Private Sub btnEditComponent_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditComponent.ItemClick

        If bsComponent.Count <= 0 Then
            Exit Sub
        End If
        Using frm As New frmAddEditComponents() With
            {
                .vID = Me.bsComponent.Current.componentID,
                .vEditType = "EDIT"
            }
            frm.ShowDialog()
        End Using
        getComponent()
    End Sub

    Private Sub btnDeleteComponent_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteComponent.ItemClick
        deleteComponent()
    End Sub

    Private Sub deleteComponent()

        If bsComponent.Count <= 0 Then
            Exit Sub
        End If

        Dim str As String
        str = "Are you sure you want to delete the selected Component?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try

            Dim oCompBeingUsed As New AltcomponentCollection
            ' See if the component is being used by other components, don't allow deletion if it is
            oCompBeingUsed.Query.Where(oCompBeingUsed.Query.Altcomponentid.Equal(bsComponent.Current.componentID))
            oCompBeingUsed.LoadAll()

            If (oCompBeingUsed.Count > 0) Then
                MsgBox("Component is used as an alternate for another component and cannot be deleted.", MsgBoxStyle.Critical, "Delete Component - Error")
                Exit Sub
            End If

            ' Check if component has childrens
            Dim oAltComponents As New AltcomponentCollection
            oAltComponents.Query.Where(oAltComponents.Query.Componentid.Equal(bsComponent.Current.componentID))
            oAltComponents.LoadAll()

            If (oAltComponents.Count > 0) Then
                MsgBox("Component has alternate components and cannot be deleted. Please delete alternate components before deleting the component.", MsgBoxStyle.Critical, "Delete Component - Error")
                Exit Sub
            End If

            Dim oKititems As New KitcomponentCollection
            oKititems.Query.Where(oKititems.Query.Componentid.Equal(bsComponent.Current.componentID))
            oKititems.LoadAll()

            If (oKititems.Count > 0) Then
                MsgBox("Unable to delete the component because it is used in one or more Kits. You must remove the component from the kit before deleting the component.")
                Exit Sub
            End If

            Dim oComponents As Component
            oComponents = New Component
            oComponents.LoadByPrimaryKey(bsComponent.Current.componentID)
            oComponents.MarkAsDeleted()
            oComponents.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected component record", MsgBoxStyle.Critical, "Delete Component - Error")
        End Try
        getComponent()
    End Sub


    Private Sub btnAddKit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddKit.ItemClick
        Using frm As New frmAddEditKit() With
            {.vEditType = "ADD"}
            frm.ShowDialog()
        End Using
        getKit()
    End Sub

    Private Sub btnEditKit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditKit.ItemClick

        If bsKit.Count <= 0 Then
            Exit Sub
        End If
        Using frm As New frmAddEditKit() With
            {
                .vID = Me.bsKit.Current.kitID,
                .vEditType = "EDIT"
            }
            frm.ShowDialog()
        End Using
        getKit()
    End Sub

    Private Sub btnDeleteKit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteKit.ItemClick
        deleteKit()
    End Sub

    Private Sub deleteKit()
        If bsKit.Count <= 0 Then
            Exit Sub
        End If

        Dim str As String
        str = "Are you sure you want to delete the selected Kit?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            ' If kit has childrens then, show a message
            Dim oKitComponents As New KitcomponentCollection
            oKitComponents.Query.Where(oKitComponents.Query.Kitid.Equal(bsKit.Current.kitID))
            oKitComponents.LoadAll()

            If (oKitComponents.Count > 0) Then
                MsgBox("Kit has items linked to it and cannot be deleted. Please delete the items before deleting the kit.", MsgBoxStyle.Critical, "Delete Kit - Error")
                Exit Sub
            End If

            Dim oKits As Kit
            oKits = New Kit
            oKits.LoadByPrimaryKey(bsKit.Current.kitID)
            oKits.MarkAsDeleted()
            oKits.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected kit record", MsgBoxStyle.Critical, "Delete Kit - Error")
        End Try
        getKit()
    End Sub

    Private Sub btnVIEWCOMPONENTS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVIEWCOMPONENTS.ItemClick
        selectView("pnlComponentHolder", False)
    End Sub

    Private Sub btnVIEWKITS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnVIEWKITS.ItemClick
        selectView("pnlKitHolder", True)
    End Sub

    Private Sub selectView(vGroupControl As String, vEnableKitButtons As Boolean)
        Dim ctlPage As New DevExpress.XtraEditors.PanelControl
        ctlPage = Me.RibbonPanelControl2.Controls(vGroupControl)

        If Not ctlPage Is Nothing Then
            ctlPage.BringToFront()
        End If

        setupToolbarButtons(vEnableKitButtons)
    End Sub

    Private Sub setupToolbarButtons(vEnableKitButtons As Boolean)
        btnAddKit.Enabled = vEnableKitButtons
        btnEditKit.Enabled = vEnableKitButtons
        btnDeleteKit.Enabled = vEnableKitButtons

        btnAddComponent.Enabled = (vEnableKitButtons = False)
        btnEditComponent.Enabled = (vEnableKitButtons = False)
        btnDeleteComponent.Enabled = (vEnableKitButtons = False)
    End Sub

    Private Sub rbtnFilterFinishedGoods_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterFinishedGoods.ItemClick
        getInventoryItemsByCategory("FINISHED GOODS")
    End Sub

    Private Sub rbtnFilterRawMaterial_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterRawMaterial.ItemClick
        getInventoryItemsByCategory("RAW MATERIALS")
    End Sub

    Private Sub btnRelabelInstruction_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Dim frm As New frmRelabelInstruction()
        frm.ShowDialog()
    End Sub

    Private Sub rbtnFilterProductsActive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterProductsActive.ItemClick
        vProductListFilter = "ACTIVE"
        gcProducts.Text = "ACTIVE Products"
        getProducts()
    End Sub

    Private Sub rbtnFilterProductsInActive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterProductsInActive.ItemClick
        vProductListFilter = "INACTIVE"
        gcProducts.Text = "INACTIVE Products"
        getProducts()
    End Sub

    Private Sub rbtnFilterProductsAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterProductsAll.ItemClick
        vProductListFilter = "ALL"
        gcProducts.Text = "ALL Products"
        getProducts()
    End Sub

    Private Sub btnItemDetails_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnItemDetails.ItemClick
        If vCurrentUserSecurityLevel < 8 Then
            Exit Sub
        End If
        editInventoryItem()
    End Sub

    Private Sub rbtnPrintGHSLabel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintGHSLabel.ItemClick
        If bsInventoryItems.Count <= 0 Then
            Exit Sub
        End If
        Dim rpt As New rptGHSProductLabelLarge(bsInventoryItems.Current.InvItemNumber, bsInventoryItems.Current.ProductID)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rbtnPrintGHSLabelByProductOnly_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintGHSLabelByProductOnly.ItemClick
        Dim vstr As String = getUserString("Enter Lot Number:", "")
        Dim rpt As New rptGHSProductLabelLarge(0, bsProducts.Current.ProductID, vstr)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rbtnFilterProductsPending_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFilterProductsPending.ItemClick
        vProductListFilter = "PENDING"
        gcProducts.Text = "PENDING Products"
        getProducts()
    End Sub

    Private Sub rbtnPrintSDSReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintSDSReport.ItemClick
        If bsProducts.Count <= 0 Then
            Exit Sub
        End If
        viewPrintSDSDocumentByProduct(bsProducts.Current.ProductID)
    End Sub

    Private Sub rbtnAllItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAllItems.ItemClick
        getInventoryItemsByCategory("ALL")
    End Sub

    Private Sub rbtnProductSalesHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnProductSalesHistory.ItemClick
        Dim frm As New frmProductBuyersList
        frm.vID = Me.bsProducts.Current.productID
        frm.ShowDialog()
    End Sub

    Private Sub rbtnProductPurchaseHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnProductPurchaseHistory.ItemClick
        Dim frm As New frmProductSellersList
        frm.vID = Me.bsProducts.Current.productID
        frm.ShowDialog()
    End Sub
End Class
