Imports AOS.BusinessObjects

Public Class viewAdministration
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oParms As Sysparameters = Nothing
    Dim vChangeRecordsType As String = Nothing
    Dim vApprovalRecordsType As String = Nothing

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadParms()
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

    Private Sub loadParms()
        oParms = New Sysparameters
        'oParms.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oParms.LoadByPrimaryKey(1)
        bsParms.DataSource = oParms
    End Sub

#End Region

    Private Sub view_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()
        ' setRibbonOptions(vCurrentUserSecurityLevel)

        ' setRibbonOptions(vCurrentUserSecurityLevel)
        setRibbonOptionsSecurity(vCurrentUserID)

        ' Call Security Timer to start hiding/showing Groups and Functions based on the security settings 
        StartSecurityTimer()


    End Sub

    Private Sub rbtnEditParameters_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditParameters.ItemClick
        Dim frm As New frmEditParameters
        frm.vID = 1
        frm.ShowDialog()
        loadParms()
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

    Private Sub rbtnEditRelabelTemplateInstructions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditRelabelTemplateInstructions.ItemClick
        Dim frm As New frmRelabelInstruction
        frm.ShowDialog()
    End Sub

    Private Sub rbtnPallets_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPallets.ItemClick
        Dim frm As New frmPalletList
        frm.showdialog
    End Sub

    Private Sub rbtnContainers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnContainers.ItemClick
        Dim frm As New frmContainerTypeList
        frm.ShowDialog()
    End Sub

    Private Sub bsChangeRecords_CurrentChanged(sender As Object, e As EventArgs) Handles bsChangeRecords.CurrentChanged

        If bsChangeRecords.Count <= 0 Then
            bsReviewRecords.DataSource = Nothing
            Exit Sub
        End If

        'getReviewRecords(bsChangeRecords.Current.ChangeRecID)

    End Sub

    Private Sub getReviewRecords(vChangeRecID As Integer)
        Dim oRevs As New ViewChangeReviewRecordsCollection
        oRevs.Query.Where(oRevs.Query.Changerecid.Equal(vChangeRecID), oRevs.Query.Reviewstatus.Equal("PENDING"))
        oRevs.Query.Load()
        bsReviewRecords.DataSource = oRevs

    End Sub

    Private Sub gcReviews_DoubleClick(sender As Object, e As EventArgs)

        If bsReviewRecords.Count <= 0 Then
            Exit Sub
        End If

        If bsReviewRecords.Current.DataTableName = "APIS" Then
            Dim frm As New frmApisStandardCosts
            frm.vAPISID = bsReviewRecords.Current.DataRecordID
            frm.ShowDialog()
        End If

        If MsgBox("Do you want to mark this Review Item as APPROVED?", MsgBoxStyle.YesNo, "APPROVAL?") = MsgBoxResult.Yes Then

            Dim oRec As New Changereview
            If oRec.LoadByPrimaryKey(bsReviewRecords.Current.ReviewRecID) Then
                oRec.Reviewstatus = "APPROVED"
                oRec.Save()
                MsgBox("Review has been APPROVED")
            End If
        End If

        getReviewRecords(bsChangeRecords.Current.ChangeRecID)

    End Sub
    Private Sub rbtnStandardCostReview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnStandardCostReview.ItemClick
        vChangeRecordsType = "STANDARD COST"
        getStandardCostReviewRecords()
    End Sub

    Private Sub getStandardCostReviewRecords()
        Dim oChgs As New ViewChangeRecordStandardCostsCollection
        oChgs.Query.Where(oChgs.Query.Changetype.Equal("STD COST"), oChgs.Query.Recordstatus.Equal("REVIEW"))
        oChgs.Query.Load()
        bsChangeRecords.DataSource = oChgs
    End Sub

    Private Sub rbtnVendorCostReview_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnVendorCostReview.ItemClick
        vChangeRecordsType = "VENDOR COST"
        getVendorCostReviewRecords()
    End Sub

    Private Sub getVendorCostReviewRecords()
        Dim oChgs As New ViewChangeRecordVendorCostsCollection
        oChgs.Query.Where(oChgs.Query.Changetype.Equal("VENDOR COST"), oChgs.Query.Recordstatus.Equal("REVIEW"))
        oChgs.Query.Load()
        bsChangeRecords.DataSource = oChgs
    End Sub

    Private Sub rbtnStandardCostApprovals_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnStandardCostApprovals.ItemClick
        getStandardCostApprovals()
    End Sub

    Private Sub getStandardCostApprovals()
        Dim oChgs As New ViewChangeRecordStandardCostsCollection
        oChgs.Query.Where(oChgs.Query.Changetype.Equal("STD COST"), oChgs.Query.Recordstatus.NotEqual("REVIEW"))
        oChgs.Query.Load()
        bsChangeRecords.DataSource = oChgs
    End Sub

    Private Sub rbtnAPISApprovals_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAPISApprovals.ItemClick
        getAPISApprovals()
    End Sub

    Private Sub getAPISApprovals()
        Dim oChgs As New ViewChangeRecordAPISChangesCollection
        oChgs.Query.Where(oChgs.Query.Changetype.Equal("APIS"), oChgs.Query.Recordstatus.NotEqual("REVIEW"))
        oChgs.Query.Load()
        bsChangeRecords.DataSource = oChgs
    End Sub

    Private Sub rbtnVendorCostApprovals_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnVendorCostApprovals.ItemClick
        getVendorCostApprovals()
    End Sub

    Private Sub getVendorCostApprovals()
        Dim oChgs As New ViewChangeRecordVendorCostsCollection
        oChgs.Query.Where(oChgs.Query.Changetype.Equal("VENDOR COST"), oChgs.Query.Recordstatus.NotEqual("REVIEW"))
        oChgs.Query.Load()
        bsChangeRecords.DataSource = oChgs
    End Sub

    Private Sub gcChangeRecords_DoubleClick(sender As Object, e As EventArgs) Handles gcChangeRecords.DoubleClick

        If bsChangeRecords.Count <= 0 Then
            Exit Sub
        End If

        Dim frm As New frmAddEditProduct
        frm.vID = bsChangeRecords.Current.ProductID
        frm.ShowDialog()

        'Check to see if there are any open REVIEW records for this CHANGE record.
        'If NOT, then allow to mark APPROVED
        'Dim oRev As New ChangereviewCollection
        'oRev.Query.Where(oRev.Query.Changerecid.Equal(bsChangeRecords.Current.ChangeRecID), oRev.Query.Reviewstatus.NotEqual("APPROVED"))
        'If oRev.Query.Load() Then
        '    Exit Sub
        'End If

        If MsgBox("Do you want to mark this Item as APPROVED?", MsgBoxStyle.YesNo, "APPROVAL?") = MsgBoxResult.Yes Then

            Dim oRec As New Changerecord
            If oRec.LoadByPrimaryKey(bsChangeRecords.Current.ChangeRecID) Then
                oRec.Recordstatus = "APPROVED"
                oRec.Save()
                MsgBox("Item has been APPROVED")
                Select Case vChangeRecordsType
                    Case "STANDARD COST"
                        getStandardCostReviewRecords()
                    Case "VENDOR COST"
                        getVendorCostReviewRecords()
                End Select
            End If
        End If

    End Sub

    Private Sub rBtnExportCostPriceEffectsToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rBtnExportCostPriceEffectsToExcel.ItemClick
        Try
            Dim vFilename As String
            vFilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\CostChangePricingEffects.xlsx"
            'grvItemList.ExportToXls(vFilename)
            grvCostPricingEffects.ExportToXlsx(vFilename)
            System.Diagnostics.Process.Start(vFilename)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rbtnGetCostChangePriceListData_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetCostChangePriceListData.ItemClick
        If rStartDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If rEndDate.EditValue Is Nothing Then
            MsgBox("You must enter a starting and ending date range", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Dim sdate As DateTime = rStartDate.EditValue
        Dim edate As DateTime = rEndDate.EditValue

        Dim oCostPriceList As New ViewCostPriceEffects2Collection
        oCostPriceList.Query.Where(oCostPriceList.Query.Changedate.Between(sdate, edate))
        oCostPriceList.Query.Load()

        bsCostPricingEffects.DataSource = oCostPriceList

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim oRpt As New rptPrimeList
        oRpt.ShowPreviewDialog
    End Sub
End Class
