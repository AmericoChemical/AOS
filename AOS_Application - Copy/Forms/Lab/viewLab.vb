Imports AOS.BusinessObjects

Public Class viewLab

    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oTestingItems As ViewTestingItemsCollection
    Dim oTestSamples As ViewTestSamplesCollection


#Region " Form Load / Launch Processes "

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
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


#End Region

    Private Sub getTestingItems()
        oTestingItems = New ViewTestingItemsCollection
        oTestingItems.LoadAll()
        bsItemsToBeTested.DataSource = oTestingItems
    End Sub

    Private Sub getSamplesData()
        oTestSamples = New ViewTestSamplesCollection
        oTestSamples.LoadAll()
        bsArchivedTestResults.DataSource = oTestSamples
    End Sub

    Private Sub getAllProducts()
        Dim oStds As New ProductCollection
        oStds.LoadAll()
        bsProducts.DataSource = oStds
    End Sub

    Private Sub getMissingProductStandards()
        Dim oStds As New ViewMissingProductStandardsCollection
        oStds.LoadAll()
        bsProducts.DataSource = oStds
    End Sub

    Private Sub rbtnRetrieveProductListAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        getAllProducts()
    End Sub

    Private Sub rbtnProductsNoStandards_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        getMissingProductStandards()
    End Sub

    Private Sub rbtnRetrieveArchivedTestScores_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveArchivedTestScores.ItemClick
        getSamplesData()
    End Sub

    Private Sub rbtnRetrieveTestingItems_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveTestingItems.ItemClick
        getTestingItems()
    End Sub

    Private Sub rbtnInputNewTestResults_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnInputNewTestResults.ItemClick
        createNewTestSample()
    End Sub

    Private Sub createNewTestSample()

        'confirm there are selected row(s)
        If grvTestingItems.SelectedRowsCount < 1 Then
            MsgBox("You must select at least one record to create a sample", MsgBoxStyle.Critical, "Error - No items selected")
            Exit Sub
        End If

        'create an array to hold selected row data - inventory items
        Dim InvItems(0, 4) As String
        ReDim InvItems(grvTestingItems.SelectedRowsCount - 1, 4)
        Dim I As Integer
        For I = 0 To InvItems.GetUpperBound(0)
            Try
                InvItems(I, 0) = grvTestingItems.GetRowCellDisplayText(grvTestingItems.GetSelectedRows(I), colInvitemnumber1)
                InvItems(I, 1) = grvTestingItems.GetRowCellDisplayText(grvTestingItems.GetSelectedRows(I), colProductid2)
                InvItems(I, 2) = grvTestingItems.GetRowCellDisplayText(grvTestingItems.GetSelectedRows(I), colLotnumber1)
                InvItems(I, 3) = grvTestingItems.GetRowCellDisplayText(grvTestingItems.GetSelectedRows(I), colReceiveddate)
                InvItems(I, 4) = grvTestingItems.GetRowCellDisplayText(grvTestingItems.GetSelectedRows(I), colReceiverdocument)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        If InvItems.GetUpperBound(0) < 0 Then
            MsgBox("No selected items were processed", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'determine if any of the selected items has already been assigned a test sample key value
        Dim y As Integer
        For y = 0 To InvItems.GetUpperBound(0)
            Try
                Dim oInv As New Invitem
                oInv.LoadByPrimaryKey(InvItems(y, 0))
                If oInv.Testsamplekey > 0 Then
                    MsgBox("One or more of the selected items has already been assigned to a sample test. Please see your supervisor for further instructions.", MsgBoxStyle.Critical, "Error - Testing Already in Progress")
                    Exit Sub
                End If
            Catch ex As Exception
                MsgBox("Error in determining testing status for selected inventory item(s)", MsgBoxStyle.Critical, "Error - " & InvItems(y, 0))
                Exit Sub
            End Try
        Next

        'if user selected more than one record, then confirm that all selected items are the same product, lot number and received date
        If InvItems.GetUpperBound(0) > 0 Then
            If Not validateSelectedTestingItems(InvItems) Then
                MsgBox("The selected items do not have the same productid, lot number, or production order number", MsgBoxStyle.Critical, "Sample Creation failed")
                Exit Sub
            End If
        End If

        'confirm the select product requires testing and has the required chemical testing standards recorded in the database
        Select Case confirmProductTestingPreReqs(InvItems(0, 1))
            Case "READY"
            Case "NO CHEMICAL LINK"
                MsgBox("The Product you selected is not currently linked to a CHEMICAL. Please ask your supervisor to link this Product to a Chemical before proceeding with this sample.", MsgBoxStyle.Critical, "Error - No Chemical Link")
                Exit Sub
            Case "MISSING STANDARDS"
                MsgBox("The product you selected is missing testing standards. Please ask your supervisor to enter these required standards before proceeding with this sample.", MsgBoxStyle.Critical, "Error - Missing Standards")
                Exit Sub
            Case "NOT REQUIRED"
                If MsgBox("Testing is not required for the selected product. Do you want to CANCEL testing the selected item(s)?", MsgBoxStyle.YesNo, "Testing not required") = MsgBoxResult.Yes Then
                    cancelTestingForSelectedItems()
                End If
                Exit Sub
            Case Else
                MsgBox("There was an error in creating the test sample. See supervisor for assistance.", MsgBoxStyle.Critical, "ERROR - Unknown Problem")
                Exit Sub
        End Select

        'create a new test sample record
        Dim oSample As New Testsample
        oSample.Lotnumber = InvItems(0, 2)
        oSample.Productid = InvItems(0, 1)
        oSample.Phaccepted = 0
        oSample.Sgaccepted = 0
        oSample.Passedtest = 0
        oSample.Save()

        'add test sample record key to selected inventory items
        Dim x As Integer
        For x = 0 To InvItems.GetUpperBound(0)
            Try
                Dim oInv As New Invitem
                oInv.LoadByPrimaryKey(InvItems(x, 0))
                oInv.Testsamplekey = oSample.Testsamplekey
                oInv.Save()
            Catch ex As Exception
                MsgBox("Error in assigning sample key to selected inventory item(s)", MsgBoxStyle.Critical, "Error - " & InvItems(x, 0))
                Exit Sub
            End Try
        Next

        'open form to record test data for newly created test sample
        editTestSampleData(oSample.Testsamplekey)

        'refresh Testing Items screen
        getTestingItems()

    End Sub

    Private Function confirmProductTestingPreReqs(vProductID As Integer) As String

        Dim oProduct As New Product
        If Not oProduct.LoadByPrimaryKey(vProductID) Then
            Return "ERROR"
        End If

        If IsDBNull(oProduct.Chemicalid) Or oProduct.Chemicalid <= 0 Then
            Return "NO CHEMICAL LINK"
        End If

        'at this point we assume the product has a chemical link so we can continue to confirm if chemical testing standards are available
        Dim oChem As New Chemical
        If Not oChem.LoadByPrimaryKey(oProduct.Chemicalid) Then
            Return "NO CHEMICAL LINK"
        End If

        If oChem.PHLOW Is Nothing Or oChem.PHHIGH Is Nothing Or oChem.SgLow Is Nothing Or oChem.SgHigh Is Nothing Or oChem.Chemicalclarity Is Nothing Or oChem.Chemicalcolor Is Nothing Then
            Return "MISSING STANDARDS"
        End If

        Return "READY"

    End Function

    Private Function validateSelectedTestingItems(ByVal InvItems As Array) As Boolean
        'we assume we have more than one record in the array

        Dim vProductID As Integer
        Dim vProdOrder As String
        'Dim vRecvDate As Date

        'set initial values for variables to validate against from first entry in item array
        vProductID = InvItems(0, 1)
        vProdOrder = InvItems(0, 4)
        'vRecvDate = InvItems(0, 3)

        'scan rest of array entries to make sure all elements match the above corresponding variables. If not, return false
        Dim x As Integer
        For x = 1 To InvItems.GetUpperBound(0)
            If InvItems(x, 1) <> vProductID Then
                Return False
            End If
            If InvItems(x, 4) <> vProdOrder Then
                Return False
            End If

            'If InvItems(x, 3) <> vRecvDate Then
            '    Return False
            'End If
        Next

        Return True

    End Function

    Private Sub editTestSampleData(vSampleKey As Integer)

        Dim frm As New frmEditTestSampleData
        frm.vID = vSampleKey
        frm.vEditType = "EDIT"
        frm.ShowDialog()

        If frm.vPassed Then
            markInventoryItemsStatus(vSampleKey)
            MsgBox("The test sample PASSED. All inventory items' status has been updated.", MsgBoxStyle.Information, "Success")
        Else
            MsgBox("The test sample data did not meet product standards. You will need to retest or review the standards.", MsgBoxStyle.Critical, "TEST FAILED")
        End If

    End Sub

    Private Sub btnCancelTestingItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancelTestingItem.ItemClick
        cancelTestingForSelectedItems()
    End Sub

    Private Sub cancelTestingForSelectedItems()

        If MsgBox("Are you sure you want to CANCEL testing for the selected items? You cannot undo this choice.", _
                  MsgBoxStyle.YesNo, _
                  "CONFIRM") = MsgBoxResult.No Then
            Exit Sub
        End If

        'create an array to hold selected row data - inventory items
        'then change itemstatus to AVAILABLE or ALLOCATED in INVITEM table
        Dim vIndex As Integer
        Dim vItemNum As Integer = 0
        For vIndex = 0 To grvTestingItems.SelectedRowsCount - 1
            Try
                vItemNum = grvTestingItems.GetRowCellDisplayText(grvTestingItems.GetSelectedRows(vIndex), colInvitemnumber1)
                updateInventory(vItemNum)
            Catch ex As Exception
                MsgBox(ex.Message, _
                       MsgBoxStyle.Critical, _
                       "Error - " & vItemNum.ToString)
            End Try
        Next

        'refresh Testing Items table
        getTestingItems()
    End Sub

    Private Sub rbtnReviewTestResults_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReviewTestResults.ItemClick
        Dim frm As New frmEditTestSampleData
        frm.vID = bsArchivedTestResults.Current.TestSampleKey
        frm.vEditType = "REVIEW"
        frm.ShowDialog()

        getTestingItems()
        getSamplesData()
    End Sub

    Private Sub btnAddTestingItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddTestingItem.ItemClick

        addSingleItemToTesting(getUserString("Enter the Inventory Item Number:"))

        'refresh Testing Items table
        getTestingItems()

    End Sub

    Private Function addSingleItemToTesting(vItemID As Integer) As Boolean

        If IsDBNull(vItemID) Then
            Return False
        End If

        'retrieve Inventory Item record by InvItemNumber
        Dim oItem As New Invitem
        If Not oItem.LoadByPrimaryKey(vItemID) Then
            MsgBox("Error in retrieving the Inventory Item record", MsgBoxStyle.Critical, "Error - Data Retrieval")
            Return False
        End If

        If oItem.Itemstatus = "SHIPPED" Then
            MsgBox("Item requested has already shipped. Cannot be put into TESTING mode.", MsgBoxStyle.Critical, "Error - Invalid Status")
            Return False
        End If

        If oItem.Testsamplekey > 0 Then
            MsgBox("Item has already been tested. To change this item, edit the test results under Archived Test Results", MsgBoxStyle.Critical, "Error - Previously Tested")
            Return False
        End If

        'create a new test sample record
        Dim oSample As New Testsample
        Try
            oSample.Lotnumber = oItem.Lotnumber
            oSample.Productid = oItem.Productid
            oSample.Phaccepted = 0
            oSample.Sgaccepted = 0
            oSample.Passedtest = 0
            oSample.Save()
        Catch ex As Exception
            MsgBox("Error in creating Testing record in database", MsgBoxStyle.Critical, "Error - No Record Created")
            Return False
        End Try

        'finally, update inventory item with testsamplekey to link the two and put item into a TESTING status
        Try
            'oItemList.Testsamplekey = oSample.Testsamplekey
            oItem.Itemstatus = "TESTING"
            oItem.Save()
        Catch ex As Exception
            MsgBox("Could not successfully update and link the Inventory Item to the testing record created. See the data administrator", MsgBoxStyle.Critical, "Error - Critical Data")
            Return False
        End Try

        Return True

    End Function

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

    Private Sub rbtnEditArchivedTestResults_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditArchivedTestResults.ItemClick
        Dim frm As New frmEditTestSampleData
        frm.vID = bsArchivedTestResults.Current.TestSampleKey
        frm.vEditType = "EDIT"
        frm.ShowDialog()

        If frm.vPassed Then
            markInventoryItemsStatus(bsArchivedTestResults.Current.TestSampleKey)
            MsgBox("The test sample PASSED. All inventory items' status has been updated.", MsgBoxStyle.Information, "Success")
        Else
            MsgBox("The test sample data did not meet product standards. You will need to retest or review the standards.", MsgBoxStyle.Critical, "TEST FAILED")
        End If

        getTestingItems()
        getSamplesData()

    End Sub



End Class
