Imports AOS.BusinessObjects

Public Class viewProduction
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub


#Region "Form Variables"

    Private oAPIS As ViewAPISDataCollection

    Dim oOrderListStatus As ProdOrderStatus = ProdOrderStatus.PENDING
    Dim vAPISFilter As String = "ACTIVE"
    Dim vRelabelOrderStatus As RelabelOrderStatus = RelabelOrderStatus.PENDING

    Dim vChemicalStatus As String = "ALL"

#End Region

#Region " Form Load / Launch Processes "

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()
        '  setRibbonOptions(vCurrentUserSecurityLevel)

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

    Private Sub refreshProdOrders()
        grvProductionOrders.GroupPanelText = oOrderListStatus.ToString() & " PRODUCTION ORDERS"
        getProdOrderData(oOrderListStatus)
    End Sub

    Private Sub rbtnOpenProductionOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnOpenProductionOrders.ItemClick
        oOrderListStatus = ProdOrderStatus.PENDING
        refreshProdOrders()
    End Sub

    Private Sub btnAddProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddProductionOrder.ItemClick
        addNewProdOrder()
    End Sub

    Private Sub btnEditProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditProductionOrder.ItemClick
        If bsProdOrders.Current Is Nothing Then
            Exit Sub
        End If

        editProdOrder(bsProdOrders.Current.ProdOrderNum)
    End Sub

    Private Sub btnCancelProductionOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelProductionOrder.ItemClick
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If

        If bsProdOrders.Current.OrderStatus = ProdOrderStatus.CANCELLED.ToString() Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to cancel the selected Production Order?",
          MsgBoxStyle.YesNo,
          "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        cancelProdOrder(bsProdOrders.Current.ProdOrderNum)
        getProdOrderData(oOrderListStatus)
    End Sub

    Private Sub rbtnPrintProductionOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintProductionOrder.ItemClick
        If bsProdOrders Is Nothing OrElse
           bsProdOrders.Count <= 0 Then
            Exit Sub
        End If

        If bsProdOrders.Current.OrderStatus = ProdOrderStatus.CANCELLED.ToString() Then
            Exit Sub
        End If

        printProdOrder(bsProdOrders.Current.ProdOrderNum)
    End Sub

    Private Sub rbtnUpdateAPIS_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUpdateAPIS.ItemClick
        getAPISData(vAPISFilter)
    End Sub

    Private Sub rbtnAddNewAPIS_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewAPIS.ItemClick
        addNewAPIS()
    End Sub

    Private Sub rbtnEditAPIS_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditAPIS.ItemClick
        editAPIS(bsAPIS.Current.APISNum)
    End Sub

    Private Sub rbtnDeleteAPIS_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteAPIS.ItemClick
        deleteAPIS()
    End Sub

    Private Sub rbtnPrintAPIS_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintAPIS.ItemClick
        printAPIS(bsAPIS.Current.APISNum)
    End Sub

    Private Sub rbtnUpdateMaterialsList_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetActiveMaterials.ItemClick
        getMaterialListData("ACTIVE")
    End Sub

    Private Sub rbtnAddNewMaterialItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewMaterialItem.ItemClick
        addNewMaterialItem()
    End Sub

    Private Sub rbtnEditMaterialItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditMaterialItem.ItemClick
        editMaterialItem(bsMaterials.Current.MaterialID)
    End Sub

    Private Sub rbtnDeleteMaterialItem_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteMaterialItem.ItemClick
        deleteMaterialItem(bsMaterials.Current.MaterialID)
    End Sub

#End Region

#Region " Data Processing "

    Private Sub getProdOrderData(oStatus As ProdOrderStatus)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim oProdOrders As ViewProdOrderDataCollection = getViewProdOrderData(oStatus)
            bsProdOrders.DataSource = oProdOrders
        Catch ex As Exception
            MsgBox("Error in retrieving Production Order records", MsgBoxStyle.Critical, "Data Error")
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub addNewProdOrder()
        Dim frm As New frmAddEditProdOrder
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getProdOrderData(oOrderListStatus)
    End Sub

    Private Sub editProdOrder(vProdOrderNum As Integer)
        Dim frm As New frmAddEditProdOrder
        frm.vEditType = "EDIT"
        frm.vID = vProdOrderNum
        frm.ShowDialog()
        getProdOrderData(oOrderListStatus)
    End Sub




    Private Sub printProdOrder(vProdOrderID As Integer)

        Dim oOrd As New Prodorder
        Try
            oOrd.LoadByPrimaryKey(vProdOrderID)
        Catch ex As Exception

        End Try

        Dim rpt As New rptProductionOrder(vProdOrderID)
        Dim rpt2 As New rptAPIS(oOrd.Apisnum)
        Dim rpt3 As New rptGHSProductLabelLarge(0, oOrd.Productid, oOrd.Lotnumber)
        rpt.ShowPreviewDialog()
        rpt2.ShowPreviewDialog()
        rpt3.ShowPreviewDialog()
    End Sub

    'Private Sub getAPISData()
    '    Me.Cursor = Cursors.WaitCursor
    '    oAPIS = New ViewAPISDataCollection
    '    Try
    '        oAPIS.LoadAll()
    '        bsAPIS.DataSource = oAPIS
    '    Catch ex As Exception
    '        MsgBox("Error is retrieving APIS data records", MsgBoxStyle.Critical, "Data Error")
    '    End Try
    '    Me.Cursor = Cursors.Default
    'End Sub

    Private Sub getAPISData(vFilter As String)
        Me.Cursor = Cursors.WaitCursor
        oAPIS = New ViewAPISDataCollection
        Try
            Select Case vFilter
                Case "ACTIVE"
                    oAPIS.Query.Where(oAPIS.Query.Apisstatus.Equal("ACTIVE"))
                Case "ARCHIVED"
                    oAPIS.Query.Where(oAPIS.Query.Apisstatus.Equal("ARCHIVED"))
                Case "SINGLE USE"
                    oAPIS.Query.Where(oAPIS.Query.Apisstatus.Equal("SINGLE USE"))
                Case Else
            End Select
            oAPIS.Query.Load()
            bsAPIS.DataSource = oAPIS
            gcAPISList.Text = "Production Instruction Sheet List - " & vFilter
        Catch ex As Exception
            MsgBox("Error is retrieving APIS data records", MsgBoxStyle.Critical, "Data Error")
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub addNewAPIS()
        'select product from database for new apis
        Dim vProdID As Integer
        Dim frm As New frmSelectProduct
        frm.ShowDialog()
        vProdID = frm.vProductID
        'check to see if product selected already has an apis in the system.
        'if YES, then stop and prompt user to create a revision of the current apis for the product
        'if NO, continue
        If IsDBNull(vProdID) Or vProdID = Nothing Then
            MsgBox("There is no selected product to review", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If checkForExistingApis(vProdID) Then
            MsgBox("An APIS already exists in the system for the selected Product. Please revise the current APIS", MsgBoxStyle.Critical, "APIS already exists")
            Exit Sub
        End If

        Dim vFrm As New frmAddEditAPIS
        vFrm.vEditType = "ADD"
        vFrm.vProductID = vProdID
        vFrm.ShowDialog()
        getAPISData(vAPISFilter)
    End Sub

    Private Function checkForExistingApis(vProdID As Integer) As Boolean
        Dim oAPIS As New ApisCollection
        oAPIS.Query.Where(oAPIS.Query.Productid.Equal(vProdID))
        If oAPIS.Query.Load Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub editAPIS(vAPISNum As Integer)
        Dim vFrm As New frmAddEditAPIS
        vFrm.vAPISNum = vAPISNum
        vFrm.vEditType = "EDIT"
        vFrm.ShowDialog()
        'validateAPISStatus(vAPISNum)
        getAPISData(vAPISFilter)
    End Sub

    Private Sub validateAPISStatus(vKey As Integer)
        'Dim oAPIS As New Apis
        'Try
        '    If oAPIS.LoadByPrimaryKey(vKey) Then
        '        If oAPIS.Isactive = True Then
        '            'keep this APIS record as active, make all others inactive
        '            markRelatedAPISStatus(vKey, True)
        '        Else
        '            'as this APIS record is now marked inactive, mark the most recent related APIS record as active
        '            markRelatedAPISStatus(vKey, False)
        '        End If
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub markAPISStatus(vApisNum As Integer, vStatus As Boolean)
        'Dim oAPIS As New Apis
        'Try
        '    If oAPIS.LoadByPrimaryKey(vApisNum) Then
        '        If vStatus Then
        '            oAPIS.Isactive = True
        '            markRelatedAPISStatus(vApisNum, True)   'mark all related APIS records as inactive, leaving this record active
        '        Else
        '            'make APIS inactive then check to see if there are any other APIS records to make active
        '            oAPIS.Isactive = False
        '            'now check for any other apis for the same productID
        '            markRelatedAPISStatus(vApisNum, vStatus) 'mark all related APIS records as inactive, mark the most recent APIS record (different from this one) as active
        '        End If
        '        oAPIS.Save()
        '        getAPISData()
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub markRelatedAPISStatus(vKey As Integer, vStatus As Boolean)
        'Dim oAPIS As New Apis
        'Try
        '    If oAPIS.LoadByPrimaryKey(vKey) Then
        '        'now check for any other apis for the same productID
        '        Dim oRecs As New ApisCollection
        '        oRecs.Query.Where(oRecs.Query.Productid.Equal(oAPIS.Productid), oRecs.Query.Apisnum.NotEqual(vKey))
        '        If oRecs.Query.Load Then
        '            oRecs.Sort = "APISNUM DESC"     'puts the list is reverse order, with most recent one on top
        '            'make sure all related APIS records are marked inactive 
        '            For Each oRec As Apis In oRecs
        '                oRec.Isactive = False
        '            Next
        '            'now all related APIS records are marked inactive
        '            If vStatus Then
        '                'mark all related APIS records as inactive, keeping the APIS record passed into this sub as the active record (not in oRecs)
        '                oRecs.Save()
        '            Else
        '                'mark the first APIS record in the collection as ACTIVE. this should be the most recently created APIS record that is not the same
        '                'as the APIS whose APISNum is passed into this sub
        '                oRecs(0).Isactive = True
        '                oRecs.Save()
        '            End If
        '        Else
        '            'no related APIS records found - this means that the APISNum passed into this sub is the only APIS record for the product ID.
        '            'Warn the user that there are no other APIS records for the select APIS/ProductID
        '            MsgBox("There are no other APIS records for ProductID " & oAPIS.Productid.ToString & ". There will be no APIS record marked as Active.", MsgBoxStyle.Exclamation, "Warning")
        '        End If
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub

    Private Sub archiveAPIS(vAPISNum As Integer)
        Dim oAPISNew As New Apis
        Try
            If Not oAPISNew.LoadByPrimaryKey(vAPISNum) Then
                MsgBox("Serious Error retrieving APIS Record", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
            oAPISNew.Apisstatus = "ARCHIVED"
            oAPISNew.Save()
            markMaterialStatusFromAPISStatus(vAPISNum, "ARCHIVED")
            MsgBox("APIS successfully archived.")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try



    End Sub

    Private Sub deleteAPIS()

        Dim vKey As Integer
        If bsAPIS.Current.Apisnum Is Nothing Or IsDBNull(bsAPIS.Current.apisnum) Then
            Exit Sub
        Else
            vKey = bsAPIS.Current.ApisNum
        End If

        Dim vStr As String = "Are you sure you want to delete the Americo Production Instruction Sheet #" & vKey.ToString & "?"
        If MsgBox(vStr, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oPOrds As New ProdorderCollection
        Try
            oPOrds.Query.Where(oPOrds.Query.Apisnum.Equal(vKey))
            If oPOrds.Query.Load Then
                'there are production orders that have used this apis, so it cannot be deleted
                If MsgBox("The selected APIS has been used in at least one Production Order and cannot be deleted. Would you like to mark this APIS as Inactive?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    Exit Sub
                Else
                    archiveAPIS(vKey)
                    getAPISData(vAPISFilter)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try

        'At this point, there are no production orders that have used the selected apis number, so we can proceed with deleteing the APIS record

        Dim rAPIS As New Apis
        Dim rItems As New ApisitemCollection
        Dim rProcs As New ApisprocedureCollection
        Dim rNotes As New ApisnoteCollection
        Try
            rNotes = New ApisnoteCollection
            rNotes.Query.Where(rNotes.Query.Apisnum.Equal(vKey))
            If rNotes.Query.Load() Then
                rNotes.MarkAllAsDeleted()
                rNotes.Save()
            End If
            rProcs = New ApisprocedureCollection
            rProcs.Query.Where(rProcs.Query.Apisnum.Equal(vKey))
            If rProcs.Query.Load() Then
                rProcs.MarkAllAsDeleted()
                rProcs.Save()
            End If
            rItems = New ApisitemCollection
            rItems.Query.Where(rItems.Query.Apisnum.Equal(vKey))
            If rItems.Query.Load() Then
                rItems.MarkAllAsDeleted()
                rItems.Save()
            End If

            'markRelatedAPISStatus(vKey, False)     'before finally deleting selected APIS record, reset the most recent remaining APIS record as active

            rAPIS.LoadByPrimaryKey(vKey)
            rAPIS.MarkAsDeleted()
            rAPIS.Save()
            MsgBox("Americo Production Instruction Sheet #" & vKey.ToString & " was successfully deleted.", MsgBoxStyle.Information, "Success")
        Catch ex As Exception
            MsgBox("Error in deleting selected APIS", MsgBoxStyle.Critical, "Error")
        End Try

        getAPISData(vAPISFilter)
    End Sub

    Private Sub printAPIS(vAPISNum As Integer)
        Dim rpt As New rptAPIS(vAPISNum)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub getMaterialListData(vMaterialStatus)
        Me.Cursor = Cursors.WaitCursor
        Dim oMaterial As New ViewRMAvailableCollection
        Try
            Select Case vMaterialStatus
                Case "ALL"
                    oMaterial.LoadAll()
                Case Else
                    oMaterial.Query.Where(oMaterial.Query.Materialstatus.Equal(vMaterialStatus))
                    oMaterial.Query.Load()
            End Select
            bsMaterials.DataSource = oMaterial
        Catch ex As Exception
            MsgBox("Error retrieving Material records", MsgBoxStyle.Critical, "Data Error")
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub addNewMaterialItem()
        Dim frm As New frmAddEditMaterialItem
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getMaterialListData("ACTIVE")
    End Sub

    Private Sub editMaterialItem(vMaterialID As Integer)
        Dim frm As New frmAddEditMaterialItem
        frm.vID = vMaterialID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getMaterialListData("ACTIVE")
    End Sub

    Private Sub deleteMaterialItem(vMaterialID As Integer)

        Dim str As String = "Are you sure you want to delete the selected Material Item?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        'next, check to see if material id is used in existing APIS Item 
        Dim oItems As ApisitemCollection
        Try
            oItems = New ApisitemCollection
            oItems.Query.Where(oItems.Query.Materialid.Equal(vMaterialID))
            If oItems.Query.Load Then
                'the material id has been used in an APIS and cannot be deleted at this time
                MsgBox("The selected MaterialID is used as in input in APIS# " & oItems(0).Apisnum.ToString & ". You must remove the input record from the APIS first before deleting the MaterialID from the database.", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim oMat As Material
        Dim oLinks As MaterialproductCollection
        Try
            oLinks = New MaterialproductCollection
            oLinks.Query.Where(oLinks.Query.Materialid.Equal(vMaterialID))
            If oLinks.Query.Load Then
                oLinks.MarkAllAsDeleted()
                oLinks.Save()
            End If
            oMat = New Material
            If oMat.LoadByPrimaryKey(vMaterialID) Then
                oMat.MarkAsDeleted()
                oMat.Save()
            End If
            MsgBox("Material ID was successfully deleted from the database", MsgBoxStyle.Critical, "Success")
        Catch ex As Exception
            MsgBox("There was an error in deleting the requested record", MsgBoxStyle.Critical, "Error")
        End Try
        getMaterialListData("ACTIVE")
    End Sub

    Private Sub printMaterialList()
        MsgBox("Not implemented yet")
    End Sub

    Private Sub getMaterialProductsList(vMaterialID As Integer)
        Me.Cursor = Cursors.WaitCursor
        Dim oMaterialProducts As New MaterialproductCollection
        Try
            oMaterialProducts.Query.Where(oMaterialProducts.Query.Materialid.Equal(vMaterialID))
            oMaterialProducts.Query.Load()
            bsMaterialProducts.DataSource = oMaterialProducts
        Catch ex As Exception
            MsgBox("Error retrieving Material Product records", MsgBoxStyle.Critical, "Error")
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub loadChemicals(vStatus As String)
        Dim oChemicals As New ChemicalCollection
        Select Case vStatus
            Case "ALL"
                oChemicals.LoadAll()
            Case Else
                oChemicals.Query.Where(oChemicals.Query.Chemicalstatus.Equal(vStatus))
                oChemicals.Query.Load()
        End Select
        bsChemicals.DataSource = oChemicals

        If bsChemicals.Count <= 0 Then
            rbtnEditChemical.Enabled = False
            rbtnDeleteChemical.Enabled = False
        Else
            rbtnEditChemical.Enabled = True
            rbtnDeleteChemical.Enabled = True
        End If
    End Sub

#End Region

    Private Sub bsMaterials_CurrentChanged(sender As Object, e As System.EventArgs) Handles bsMaterials.CurrentChanged
        getMaterialProductsList(bsMaterials.Current.MaterialID)
    End Sub

    Private Sub rbtnRawMaterialAvailableInventory_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRawMaterialAvailableInventory.ItemClick
        Dim rpt As New rptRawMaterialAvailableInventory(0)
        rpt.ShowPreviewDialog()
    End Sub

    'Private Sub rbtnMarkProdOrderComplete_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkProdOrderComplete.ItemClick
    '    If bsProdOrders.Count <= 0 Then
    '        Exit Sub
    '    End If

    '    Dim str As String = "Are you sure you want to mark the selected Production Order as completed?"
    '    If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    Dim oProd As New Prodorder
    '    Dim oItems As New ProditemCollection

    '    Try
    '        oItems.Query.Where(oItems.Query.Prodordernum.Equal(bsProdOrders.Current.ProdOrdernum))
    '        If oItems.Query.Load Then
    '            For Each oitem As Proditem In oItems
    '                oitem.Iscomplete = 1
    '            Next
    '            oItems.Save()
    '        End If
    '        If oProd.LoadByPrimaryKey(bsProdOrders.Current.ProdOrderNum) Then
    '            oProd.Iscomplete = 1
    '            oProd.Save()
    '        End If
    '        MsgBox("Production Order successfully updated", MsgBoxStyle.Information, "Update Complete")
    '    Catch ex As Exception
    '        MsgBox("Error updating selected Production Order", MsgBoxStyle.Critical, "Error")
    '    End Try

    'End Sub


    Private Sub rbtnCompletedProductionOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCompletedProductionOrders.ItemClick
        oOrderListStatus = ProdOrderStatus.COMPLETE
        refreshProdOrders()
    End Sub

    'Private Sub rbtnReopenProdOrder_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReopenProdOrder.ItemClick
    '    If bsProdOrders.Count <= 0 Then
    '        Exit Sub
    '    End If

    '    Dim str As String = "Are you sure you want to re-open the selected Production Order?"
    '    If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    Dim oProd As New Prodorder
    '    Dim oItems As New ProditemCollection

    '    Try
    '        oItems.Query.Where(oItems.Query.Prodordernum.Equal(bsProdOrders.Current.ProdOrdernum))
    '        If oItems.Query.Load Then
    '            For Each oitem As Proditem In oItems
    '                oitem.Iscomplete = 0
    '            Next
    '            oItems.Save()
    '        End If
    '        If oProd.LoadByPrimaryKey(bsProdOrders.Current.ProdOrderNum) Then
    '            oProd.Iscomplete = 0
    '            oProd.Save()
    '        End If
    '        MsgBox("Production Order successfully updated", MsgBoxStyle.Information, "Update Complete")
    '    Catch ex As Exception
    '        MsgBox("Error updating selected Production Order", MsgBoxStyle.Critical, "Error")
    '    End Try

    'End Sub

    Private Sub rbtnRevision_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRevision.ItemClick
        createAPISRevision(bsAPIS.Current.apisnum)
    End Sub

    Private Function getNextLetter(ByVal letter As String) As String
        If letter Is Nothing Or letter = "" Then
            letter = "A"
        End If
        Return New String(ChrW(AscW(letter.Chars(0)) + 1), 1)
    End Function

    Private Sub createAPISRevision(vAPIS As Integer)
        If MsgBox("Are you sure you want to create a new revision of the selected APIS? The current APIS will be made inactive and the new APIS will become the current record", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        'retrieve original APIS record
        Dim oA1 As Apis
        oA1 = New Apis
        If Not oA1.LoadByPrimaryKey(vAPIS) Then
            MsgBox("Could not retrieve original APIS information", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'added 02/13/2013
        'change all APIS records for same productID to inactive
        Dim oAPISList As New ApisCollection
        oAPISList.Query.Where(oAPISList.Query.Productid.Equal(oA1.Productid))
        If Not oAPISList.Query.Load Then
            MsgBox("Error is processing APIS updates.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            For Each oAPIS As Apis In oAPISList
                oAPIS.Isactive = 0
            Next
            oAPISList.Save()
        End If

        'at this point, all APIS records for this ProductID are now inactive
        'the new revision record will be marked active

        'copy APIS record to new APIS record, adding one letter in sequence to the Revision value
        Dim oA2 As Apis
        Try
            oA2 = New Apis
            oA2.Apisdesc = oA1.Apisdesc
            oA2.Apisnote = oA1.Apisnote
            oA2.Createdby = vCurrentUserLogin
            oA2.Createdtime = Now
            oA2.Custid = oA1.Custid
            oA2.Isactive = 1
            oA2.Productid = oA1.Productid
            oA2.Qtycontainers = oA1.Qtycontainers
            oA2.Revision = getNextLetter(oA1.Revision)
            oA2.Stdlaborhours = oA1.Stdlaborhours
            oA2.Unitcost = oA1.Unitcost
            oA2.Units = oA1.Units
            oA2.Uom = oA1.Uom
            oA2.Save()
        Catch ex As Exception
            MsgBox("Error in setting up the revision.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

        Dim vNewAPIS As Integer = oA2.Apisnum

        'copy all APISItem, APISProc and APISNote records to new versions for the new APIS record
        Dim oItemList As ApisitemCollection
        Dim oProcList As ApisprocedureCollection
        Dim oNoteList As ApisnoteCollection

        Dim oItem2 As Apisitem
        Dim oProc2 As Apisprocedure
        Dim oNote2 As Apisnote

        oItemList = New ApisitemCollection
        oItemList.Query.Where(oItemList.Query.Apisnum.Equal(vAPIS))
        If oItemList.Query.Load Then
            For Each oItem As Apisitem In oItemList
                oItem2 = New Apisitem
                oItem2.Apisnum = vNewAPIS
                oItem2.Apisitemnote = oItem.Apisitemnote
                oItem2.Materialid = oItem.Materialid
                oItem2.Qtyunits = oItem.Qtyunits
                oItem2.Sourceproductid = oItem.Sourceproductid
                oItem2.Uom = oItem.Uom
                oItem2.Save()
            Next
        End If

        oProcList = New ApisprocedureCollection
        oProcList.Query.Where(oProcList.Query.Apisnum.Equal(vAPIS))
        If oProcList.Query.Load Then
            For Each oProc As Apisprocedure In oProcList
                oProc2 = New Apisprocedure
                oProc2.Apisnum = vNewAPIS
                oProc2.Apisprocedure = oProc.Apisprocedure
                oProc2.Sequence = oProc.Sequence
                oProc2.Save()
            Next
        End If

        oNoteList = New ApisnoteCollection
        oNoteList.Query.Where(oNoteList.Query.Apisnum.Equal(vAPIS))
        If oNoteList.Query.Load Then
            For Each oNote As Apisnote In oNoteList
                oNote2 = New Apisnote
                oNote2.Apisnum = vNewAPIS
                oNote2.Apisnote = oNote.Apisnote
                oNote2.Sequence = oNote.Sequence
                oNote2.Save()
            Next
        End If

        'now, edit the new APIS record
        editAPIS(vNewAPIS)

    End Sub

    Private Sub rbtnRetrieveChemicalList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveChemicalList.ItemClick
        vChemicalStatus = "ALL"
        loadChemicals(vChemicalStatus)
    End Sub

    Private Sub rbtnEditChemical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditChemical.ItemClick
        If bsChemicals.Count <= 0 Then
            Exit Sub
        End If
        If bsChemicals.Current.ChemicalID <= 0 Then
            Exit Sub
        End If
        editChemical(bsChemicals.Current.ChemicalID)
    End Sub

    Private Sub editChemical(vChemicalID As Integer)
        Dim frm As New frmAddEditChemical2
        frm.vID = vChemicalID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadChemicals(vChemicalStatus)
    End Sub

    Private Sub rbtnAddNewChemical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewChemical.ItemClick
        addChemical()
    End Sub

    Private Sub addChemical()
        Dim frm As New frmAddEditChemical2
        frm.vEditType = "ADD"
        frm.ShowDialog()
        loadChemicals(vChemicalStatus)
    End Sub

    Private Sub rbtnDeleteChemical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteChemical.ItemClick
        If bsChemicals.Count <= 0 Then
            Exit Sub
        End If
        deleteChemical(bsChemicals.Current.ChemicalID)
        loadChemicals(vChemicalStatus)
    End Sub

    Private Sub deleteChemical(vChemicalID As Integer)
        If MsgBox("Are you sure you want to delete the selected Chemical?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        'check to see if chemical is linked to any  product. If not, allow to delete. If there is, ask to make the status INACTIVE
        Dim oProducts As New ProductCollection
        oProducts.Query.Where(oProducts.Query.Chemicalid.Equal(vChemicalID))
        If oProducts.Query.Load Then
            'there is atleast one product that has been linked to the current Chemical.
            If MsgBox("There is at least one Product that has been linked to the selected Chemical - the Chemical cannot be deleted. Would you like to mark the Chemical as INACTIVE?", MsgBoxStyle.YesNo, "Deletion Failed - Change Status Option") = MsgBoxResult.Yes Then
                Dim oChemical As New Chemical
                oChemical.LoadByPrimaryKey(vChemicalID)
                oChemical.Chemicalstatus = "INACTIVE"
                oChemical.Save()
                MsgBox("Chemical status has been changed to INACTIVE", MsgBoxStyle.Information, "Status Change")
            End If
        Else
            Dim oChem As New Chemical
            oChem.LoadByPrimaryKey(vChemicalID)
            oChem.MarkAsDeleted()
            oChem.Save()
            MsgBox("Chemical has been deleted from the database.", MsgBoxStyle.Information, "Deletion Successful")
        End If

    End Sub

    Private Sub rbtnAllAPIS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAllAPIS.ItemClick
        vAPISFilter = "ALL"
        getAPISData(vAPISFilter)
    End Sub

    Private Sub rbtnActiveAPIS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnActiveAPIS.ItemClick
        vAPISFilter = "ACTIVE"
        getAPISData(vAPISFilter)
    End Sub

    Private Sub rbtnArchivedAPIS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnArchivedAPIS.ItemClick
        vAPISFilter = "ARCHIVED"
        getAPISData(vAPISFilter)
    End Sub

    Private Sub rbtnSingleUseAPIS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSingleUseAPIS.ItemClick
        vAPISFilter = "SINGLE USE"
        getAPISData(vAPISFilter)
    End Sub

    Private Sub rbtnRetrieveProductionOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveProductionOrders.ItemClick
        refreshProdOrders()
    End Sub

    Private Sub rbtnPrintProductionOrdersSummary_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintProductionOrdersSummary.ItemClick
        If rRptStartDate.EditValue Is Nothing OrElse
            rRptEndDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim vEndDate As String = rRptEndDate.EditValue + " 23:59:59"

        Dim sdate As DateTime = rRptStartDate.EditValue
        Dim edate As DateTime = vEndDate

        Dim rpt As New rptProductionOrderSummary(sdate, edate)
        rpt.ShowPreview()
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

    Private Sub rbtnRMInventoryTxs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRMInventoryTxs.ItemClick
        Dim frm As New frmRawMaterialUsage
        frm.vID = bsProdOrders.Current.ProdOrderNum
        frm.ShowDialog()
    End Sub

    Private Sub rbtnGetLinkedAPISData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetLinkedAPISData.ItemClick
        Dim frm As New frmMaterialAPISList
        frm.vID = bsMaterials.Current.MaterialID
        frm.ShowDialog()
    End Sub

    Private Sub rbtnCancelledProductionOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCanceledProductionOrders.ItemClick
        oOrderListStatus = ProdOrderStatus.CANCELLED
        refreshProdOrders()
    End Sub

    Private Sub grvProductionOrders_RowStyle(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs) Handles grvProductionOrders.RowStyle
        If (e.RowHandle < 0) Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(grvProductionOrders.GetRowCellDisplayText(e.RowHandle, grvProductionOrders.Columns("Estimatedcompletiondate"))) = False AndAlso
               String.IsNullOrEmpty(grvProductionOrders.GetRowCellDisplayText(e.RowHandle, grvProductionOrders.Columns("Neededby"))) = False Then
            If Convert.ToDateTime(grvProductionOrders.GetRowCellDisplayText(e.RowHandle, grvProductionOrders.Columns("Estimatedcompletiondate"))) >
                Convert.ToDateTime(grvProductionOrders.GetRowCellDisplayText(e.RowHandle, grvProductionOrders.Columns("Neededby"))) Then
                e.Appearance.BackColor = Color.Red
                e.Appearance.BackColor2 = Color.Red
                e.Appearance.ForeColor = Color.White
                Exit Sub
            End If
        End If

    End Sub

    Private Sub grvProductionOrders_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvProductionOrders.FocusedRowChanged
        If bsProdOrders.Count <= 0 Then
            Exit Sub
        End If
        If grvProductionOrders.SelectedRowsCount <= 0 Then
            Exit Sub
        End If

        If String.IsNullOrEmpty(bsProdOrders.Current.Workordernumber) Then
            btnCancelProductionOrder.Enabled = True
        Else
            btnCancelProductionOrder.Enabled = False
        End If
    End Sub

    Private Sub rbtnRetrieveRelabelOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveRelabelOrders.ItemClick
        refreshRelabelOrders()
    End Sub


    Private Sub btnEditRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditRelabelOrder.ItemClick
        If bsRelabelOrders.Count <= 0 Then
            Exit Sub
        End If
        editRelabelOrder()
        refreshRelabelOrders()
    End Sub

    Private Sub btnCancelRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelRelabelOrder.ItemClick
        If bsRelabelOrders.Count <= 0 Then
            Exit Sub
        End If
        If bsRelabelOrders.Current.Relabelorderstatus = RelabelOrderStatus.CANCELLED.ToString() Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to cancel the selected Relabel Order?",
                  MsgBoxStyle.YesNo,
                  "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        cancelRelabelOrderAndItems(bsRelabelOrders.Current.Relabelordernumber)
        refreshRelabelOrders()
    End Sub

    Private Sub rbtnPrintRelabelOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintRelabelOrder.ItemClick
        If bsRelabelOrders.Current Is Nothing Then
            Exit Sub
        End If
        printRelabelOrder(bsRelabelOrders.Current.Relabelordernumber)
    End Sub

    Private Sub rbtnOpenRelabelOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnOpenRelabelOrders.ItemClick
        vRelabelOrderStatus = RelabelOrderStatus.PENDING
        refreshRelabelOrders()
    End Sub

    Private Sub rbtnCompletedRelabelOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCompletedRelabelOrders.ItemClick
        vRelabelOrderStatus = RelabelOrderStatus.COMPLETED
        refreshRelabelOrders()
    End Sub

    Private Sub rbtnCanceledRelabelOrders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCanceledRelabelOrders.ItemClick
        vRelabelOrderStatus = RelabelOrderStatus.CANCELLED
        refreshRelabelOrders()
    End Sub

    Private Sub rbtnPrintRelabelOrdersSummary_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintRelabelOrdersSummary.ItemClick
        If rRptRelabelStartDate.EditValue Is Nothing OrElse
            rRptRelabelEndDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range for this report", MsgBoxStyle.Critical, "Confirm")
            Exit Sub
        End If

        Dim vEndDate As String = rRptRelabelEndDate.EditValue + " 23:59:59"
        Dim vSdate As DateTime = rRptRelabelStartDate.EditValue
        Dim vEdate As DateTime = vEndDate

        Dim rpt As New rptRelabelOrderSummary(vSdate, vEdate)
        rpt.ShowPreview()
    End Sub

    Private Sub refreshRelabelOrders()
        getRelabelOrders()
        enableRelabelOrderCancel()
    End Sub

    Private Sub getRelabelOrders()
        Dim oRelabelOrders As ViewRelabelOrderCollection

        Me.Cursor = Cursors.WaitCursor
        Try
            oRelabelOrders = getViewRelabelOrder(vRelabelOrderStatus)
            bsRelabelOrders.DataSource = oRelabelOrders
        Catch ex As Exception
            MsgBox("Error in retrieving Relabel Order records", MsgBoxStyle.Critical, "Data Error")
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub editRelabelOrder()
        Using frm As New frmAddEditRelabelOrder() With
            {
                .vRelabelOrderNumber = Me.bsRelabelOrders.Current.Relabelordernumber,
                .vEditType = "EDIT"
            }
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub printRelabelOrder(vRelabelordernumber)
        Dim rptRelabelOrders As New rptRelabelOrder(vRelabelordernumber)
        rptRelabelOrders.ShowPreviewDialog()
    End Sub

    Private Sub enableRelabelOrderCancel()
        btnCancelRelabelOrder.Enabled = IIf((bsRelabelOrders.Count > 0 AndAlso
                                             bsRelabelOrders.Current.Workordernumber Is Nothing) _
                                             , True, False)
    End Sub

    Private Sub grvRelabelOrders_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvRelabelOrders.FocusedRowChanged
        enableRelabelOrderCancel()
    End Sub

    Private Sub rbtnActiveChemicals_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnActiveChemicals.ItemClick
        vChemicalStatus = "ACTIVE"
        loadChemicals(vChemicalStatus)
    End Sub

    Private Sub rbtnInactiveChemicals_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnInactiveChemicals.ItemClick
        vChemicalStatus = "INACTIVE"
        loadChemicals(vChemicalStatus)
    End Sub

    Private Sub rbtnChangeChemicalStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        If bsChemicals.Count <= 0 Then
            Exit Sub
        End If
        Select Case bsChemicals.Current.ChemicalStatus
            Case "ACTIVE"
                If MsgBox("Are you sure to want to make the status of the selected Chemical 'INACTIVE'?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.Yes Then
                    Dim oChem As New Chemical
                    oChem.LoadByPrimaryKey(bsChemicals.Current.ChemicalID)
                    oChem.Chemicalstatus = "INACTIVE"
                    oChem.Save()
                    MsgBox("Chemical status changed to 'INACTIVE'", MsgBoxStyle.Information, "Status Change Successful")
                    vChemicalStatus = "INACTIVE"
                End If
            Case "INACTIVE"
                If MsgBox("Are you sure to want to make the status of the selected Chemical 'ACTIVE'?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.Yes Then
                    Dim oChem As New Chemical
                    oChem.LoadByPrimaryKey(bsChemicals.Current.ChemicalID)
                    oChem.Chemicalstatus = "ACTIVE"
                    oChem.Save()
                    MsgBox("Chemical status changed to 'ACTIVE'", MsgBoxStyle.Information, "Status Change Successful")
                    vChemicalStatus = "ACTIVE"
                End If
        End Select
        loadChemicals(vChemicalStatus)
    End Sub

    Private Sub rbtnGetArchivedMaterials_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetArchivedMaterials.ItemClick
        getMaterialListData("ARCHIVED")
    End Sub

    Private Sub rbtnGetAllMaterials_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetAllMaterials.ItemClick
        getMaterialListData("ALL")
    End Sub

    Private Sub rbtnViewChemical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnViewChemical.ItemClick
        If bsChemicals.Count <= 0 Then
            Exit Sub
        End If

        Dim frm As New frmAddEditChemical2
        frm.vID = bsChemicals.Current.chemicalID
        frm.vEditType = "VIEW"
        frm.ShowDialog()
        loadChemicals(vChemicalStatus)
    End Sub

    Private Sub rbtnPrintSDSReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintSDSReport.ItemClick
        If bsChemicals.Count <= 0 Then
            Exit Sub
        End If
        viewPrintSDSDocumentByChemical(bsChemicals.Current.chemicalID)
    End Sub


End Class