Imports AOS.BusinessObjects
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class viewBDF

    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'These objects are used within the View
    Dim oCarrierList As CarrierCollection
    Dim oVendorList As VendorCollection
    Dim oAPBatchList As LoadAPBatchCollection
    Dim oLoadcharge As Loadcharge
    Dim oLoadchargeList As LoadchargeCollection
    Dim oViewLoadChargesForBDFList As ViewLoadChargesForBDFCollection

    Dim oViewLoadChargesForBDFInvoicesList As ViewLoadChargesForBDFInvoicesCollection

    'These objects are for Charge Status
    Dim oLoadChargeStatusInProgress As String = "TEMPMATCH"
    Dim oLoadChargeStatusPending As String = "PENDING"
    Dim oLoadChargeStatusPosted As String = "POSTED"

    'These objects are for Charge Type
    Dim oLoadChargeTypeOutBound As String = "OUTBOUND"
    Dim oLoadChargeTypeInBound As String = "INBOUND"
    Dim oLoadChargeTypeDirect As String = "DIRECT"



#Region " Form Load / Launch Processes "

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadCarrierList()
        loadVendorList()
        loadPostedAPBatchList()
    End Sub

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setRibbonOptions(vCurrentUserSecurityLevel)
        Me.RibbonControl1.SelectedPage = Me.RibbonPage1
        Me.RibbonPanelControl1.BringToFront()

        Me.rbtnFinalizeCarrierInvoice.Enabled = False
        Me.rbtnEditCarrierLoadCharge.Enabled = False

        Me.rbtnFinalizeVendorInvoice.Enabled = False
        Me.rbtnEditVendorLoadCharge.Enabled = False

        Me.rbtnFinalizeAPBatch.Enabled = False
        Me.rbtnAPBatchRefreshMatchedLoadCharges.Enabled = False
        'Me.rbtnPrintAPBatchReport.Enabled = False

        setRibbonOptionsSecurity(vCurrentUserID)

        ' Call Security Timer to start hiding/showing Groups and Functions based on the security settings 
        StartSecurityTimer()

    End Sub

    Private Sub viewUserManagement_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim vFormSize As Integer = 0
        vFormSize = CInt(Me.Width)

        Dim vLeftWidth As Integer = CInt(0.45 * (vFormSize - 24))
        Dim vCenterWidth As Integer = CInt(0.1 * (vFormSize - 24))
        gcAvailableLoadChargeRecords.Width = vLeftWidth
        gcAddRemoveMatchedLoadCharge.Width = vCenterWidth

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

    'Private Sub RibbonControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RibbonControl1.SelectedPageChanged
    '    Dim vNum As Integer
    '    If RibbonControl1.SelectedPage Is Nothing Then
    '        Me.Visible = False
    '        Exit Sub
    '    Else
    '        Me.Visible = True
    '    End If

    '    If Me.RibbonControl1.SelectedPage.Name = "" Then
    '        vNum = 1
    '    Else
    '        vNum = CInt(Me.RibbonControl1.SelectedPage.Name.Substring(10, 1))
    '    End If
    '    Dim ctlPage As New DevExpress.XtraEditors.PanelControl
    '    ctlPage = Me.WorkPanelsHolder.Controls("RibbonPanelControl" & vNum.ToString)
    '    If Not ctlPage Is Nothing Then
    '        ctlPage.BringToFront()
    '    End If
    'End Sub

#End Region

#Region " Data Processing "

    Private Sub loadCarrierList()
        oCarrierList = New CarrierCollection
        oCarrierList.LoadAll()
        oCarrierList.Sort = "CarrierName"
        bsCarriers.DataSource = oCarrierList

    End Sub

    Private Sub loadVendorList()
        oVendorList = New VendorCollection
        oVendorList.LoadAll()
        oVendorList.Sort = "VENDORNAME"
        bsVendorList.DataSource = oVendorList
    End Sub

    Private Sub loadAPBatchList()
        oAPBatchList = New LoadAPBatchCollection
        oAPBatchList.LoadAll()
        oAPBatchList.Sort = "APBatchID"
        bsAPBatches.DataSource = oAPBatchList
    End Sub

    Private Sub loadPostedAPBatchList()
        oAPBatchList = New LoadAPBatchCollection
        oAPBatchList.Query.Where(oAPBatchList.Query.BatchStatus.Equal(oLoadChargeStatusPosted))
        If oAPBatchList.Query.Load() Then
            oAPBatchList.Sort = "APBatchID"
            bsAPBatches.DataSource = oAPBatchList
        Else
            bsAPBatches.DataSource = Nothing
        End If
    End Sub


#End Region

#Region "USER SECURITY"



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


#End Region

#Region "OUTBOUND LOAD CARRIER INVOICES"

    Private Sub getPendingCarrierChargeRecords()
        If (CarrierLookUpEdit.EditValue Is Nothing) Then
            Exit Sub
        End If
        getOutboundCarrierLoadCharges()
        getOutboundCarrierLoadChargesTempMatch()

    End Sub

    Private Sub getOutboundCarrierLoadCharges()


        If (CarrierLookUpEdit.EditValue Is Nothing) Then
            Exit Sub
        End If

        Dim vCarrierID As Integer = 0
        Dim vPRONumberInvoiceNumber As String = ""
        Dim vInvoiceAmount As String = ""

        Dim vCarrierIDString As String = DirectCast(CarrierLookUpEdit.EditValue, AOS.BusinessObjects.Carrier).CarrierID
        vCarrierID = CInt(vCarrierIDString)

        If IsDBNull(vCarrierID) Then
            Exit Sub
        End If

        oViewLoadChargesForBDFList = New ViewLoadChargesForBDFCollection
        ' oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatusPending),
        '                                       oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeOutBound))

        ' Logic of this Query: Select * from dbo.viewLoadChargesForBDF where CarrierID = Value and LoadChargeStatus = TEMPMATCH and (LoadType = OUTBOUND  OR LoadType = INBOUND)
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatusPending))
        oViewLoadChargesForBDFList.Query.Where(New EntitySpaces.DynamicQuery.esComparison(EntitySpaces.DynamicQuery.esParenthesis.Open))
        oViewLoadChargesForBDFList.Query.es.DefaultConjunction = EntitySpaces.DynamicQuery.esConjunction.Or
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeOutBound), oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeInBound))
        oViewLoadChargesForBDFList.Query.Where(New EntitySpaces.DynamicQuery.esComparison(EntitySpaces.DynamicQuery.esParenthesis.Close))

        If oViewLoadChargesForBDFList.Query.Load() Then
            bsCarrierLoadCharges.DataSource = oViewLoadChargesForBDFList
        Else
            bsCarrierLoadCharges.DataSource = Nothing
        End If

        If (bsCarrierLoadCharges.Count <= 0) Then
            rbtnEditCarrierLoadCharge.Enabled = False
        Else
            rbtnEditCarrierLoadCharge.Enabled = True
        End If


    End Sub

    Private Sub getOutboundCarrierLoadChargesTempMatch()

        If (CarrierLookUpEdit.EditValue Is Nothing) Then
            Exit Sub
        End If

        Dim vCarrierID As Integer = 0
        Dim vPRONumberInvoiceNumber As String = ""
        Dim vInvoiceAmount As String = ""

        Dim vCarrierIDString As String = DirectCast(CarrierLookUpEdit.EditValue, AOS.BusinessObjects.Carrier).CarrierID
        vCarrierID = CInt(vCarrierIDString)

        If IsDBNull(vCarrierID) Then
            Exit Sub
        End If

        oViewLoadChargesForBDFList = New ViewLoadChargesForBDFCollection
        ' oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatusInProgress),
        '                                       oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeOutBound))



        ' Logic of this Query: Select * from dbo.viewLoadChargesForBDF where CarrierID = Value and LoadChargeStatus = Pending and (LoadType = OUTBOUND  OR LoadType = INBOUND)
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatusInProgress))
        oViewLoadChargesForBDFList.Query.Where(New EntitySpaces.DynamicQuery.esComparison(EntitySpaces.DynamicQuery.esParenthesis.Open))
        oViewLoadChargesForBDFList.Query.es.DefaultConjunction = EntitySpaces.DynamicQuery.esConjunction.Or
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeOutBound), oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeInBound))
        oViewLoadChargesForBDFList.Query.Where(New EntitySpaces.DynamicQuery.esComparison(EntitySpaces.DynamicQuery.esParenthesis.Close))



        If oViewLoadChargesForBDFList.Query.Load() Then

            CalculateTotalChargesForOutboundTempMatch(oViewLoadChargesForBDFList)

            bsCarrierLoadChargesMatching.DataSource = oViewLoadChargesForBDFList
        Else
            TotalCarrierChargesTextEdit.EditValue = ""
            bsCarrierLoadChargesMatching.DataSource = Nothing
        End If

        If (bsCarrierLoadChargesMatching.Count <= 0) Then
            rbtnFinalizeCarrierInvoice.Enabled = False
        Else
            rbtnFinalizeCarrierInvoice.Enabled = True
        End If

    End Sub

    ' This method will calculate the total CarrierCharges and then update TotalCarrierChargesTextEdit on the Invoice Info section
    Private Sub CalculateTotalChargesForOutboundTempMatch(ByVal vViewLoadChargesForBDFCollection As ViewLoadChargesForBDFCollection)

        If vViewLoadChargesForBDFCollection Is Nothing Then
            Exit Sub
        End If

        Dim vCarrierID As Integer = 0
        Dim vPRONumberInvoiceNumber As String = ""
        Dim vInvoiceAmount As String = ""

        TotalCarrierChargesTextEdit.EditValue = ""
        Dim vTotalCarrierCharges As Decimal = 0


        For Each oAppUserFunction As ViewLoadChargesForBDF In vViewLoadChargesForBDFCollection
            Dim iCarrierCharges As Decimal = 0

            If Not oAppUserFunction.CarrierCharges Is Nothing Then
                If Not IsDBNull(oAppUserFunction.CarrierCharges) Then
                    iCarrierCharges = oAppUserFunction.CarrierCharges
                    vTotalCarrierCharges = vTotalCarrierCharges + iCarrierCharges
                End If
            End If


        Next
        TotalCarrierChargesTextEdit.EditValue = vTotalCarrierCharges

        If vTotalCarrierCharges > 0 Then
            rbtnFinalizeCarrierInvoice.Enabled = True
        Else
            rbtnFinalizeCarrierInvoice.Enabled = False
        End If

    End Sub


    Private Sub btnLookupLoadDetails_Click(sender As Object, e As EventArgs) Handles btnLookupCarrierLoadDetails.Click
        getPendingCarrierChargeRecords()
    End Sub

    Private Sub btnAddToMatchedLoadCharge_Click(sender As Object, e As EventArgs) Handles btnAddToMatchedLoadCharge.Click

        If Me.bsCarrierLoadCharges.Count = 0 Then
            Exit Sub
        End If

        If Not checkIfCarrierTotalBillingsForLoadIsValidForMatching() Then

            Dim strAlertMessage As String
            strAlertMessage = "Sorry, You cannot match this Load Charge Record." & vbNewLine & "Because it contains the Load Billing Total of less than one Dollar."
            MsgBox(strAlertMessage, MsgBoxStyle.Critical, "Error - Load Billing Total Is Less Than One Dollar")

            Exit Sub
        End If

        addToOutboundCarrierLoadChargesTempMatch()
        getPendingCarrierChargeRecords()

    End Sub

    ' This methods adds the selected Outbound Carrier Load Charge to getOutboundCarrierLoadCharges Temp Match
    ' The LoadChargeStatus will change from PENDING to TEMPMATCH
    Private Sub addToOutboundCarrierLoadChargesTempMatch()

        Dim vLoadChargeID As Integer
        Dim vLoadID As Integer
        Dim vEvaluatedShippedDate As String
        Dim vCarrierCharges As String

        vLoadChargeID = Me.bsCarrierLoadCharges.Current.LoadChargeID
        vLoadID = Me.bsCarrierLoadCharges.Current.LoadID
        vEvaluatedShippedDate = Me.bsCarrierLoadCharges.Current.ScheduledShipmentDate
        vCarrierCharges = Me.bsCarrierLoadCharges.Current.CarrierCharges

        ' Now change the status of dbo.LOADCHARGE.[LoadChargeStatus] to MATCHINGINPROGRESS
        Dim oLoadcharge As New Loadcharge
        If oLoadcharge.LoadByPrimaryKey(vLoadChargeID) Then
            oLoadcharge.LoadChargeStatus = oLoadChargeStatusInProgress
            oLoadcharge.Save()
        End If

    End Sub

    Private Function checkIfCarrierTotalBillingsForLoadIsValidForMatching() As Boolean

        Dim vTotalCarrierCharges As Decimal = 0

        If (Me.bsCarrierLoadCharges.Current.TotalBillings Is Nothing) Then
            Return False
        End If

        vTotalCarrierCharges = Me.bsCarrierLoadCharges.Current.TotalBillings

        If vTotalCarrierCharges < 1 Then
            Return False
        End If

        Return True

    End Function

    Private Sub btnRemoveFromMatchedLoadCharge_Click(sender As Object, e As EventArgs) Handles btnRemoveFromMatchedLoadCharge.Click
        If Me.bsCarrierLoadChargesMatching.Count = 0 Then
            Exit Sub
        End If

        removeFromOutboundCarrierLoadChargesTempMatch()
        getPendingCarrierChargeRecords()

    End Sub

    ' This methods removes the selected Outbound Carrier Load Charge Temp Match
    ' The LoadChargeStatus will change from TEMPMATCH to PENDING 
    Private Sub removeFromOutboundCarrierLoadChargesTempMatch()

        Dim vLoadChargeID As Integer
        Dim vLoadID As Integer
        Dim vEvaluatedShippedDate As String
        Dim vCarrierCharges As String

        vLoadChargeID = Me.bsCarrierLoadChargesMatching.Current.LoadChargeID
        vLoadID = Me.bsCarrierLoadChargesMatching.Current.LoadID
        vEvaluatedShippedDate = Me.bsCarrierLoadChargesMatching.Current.ScheduledShipmentDate
        vCarrierCharges = Me.bsCarrierLoadChargesMatching.Current.CarrierCharges

        ' Now change the status of dbo.LOADCHARGE.[LoadChargeStatus] to PENDING
        Dim oLoadcharge As New Loadcharge
        If oLoadcharge.LoadByPrimaryKey(vLoadChargeID) Then
            oLoadcharge.LoadChargeStatus = oLoadChargeStatusPending
            oLoadcharge.Save()
        End If
    End Sub

    Private Sub GridViewAvailableLoadCharges_DoubleClick(sender As Object, e As EventArgs) Handles GridViewAvailableLoadCharges.DoubleClick
        If Me.bsCarrierLoadCharges.Count = 0 Then
            Exit Sub
        End If

        If Not checkIfCarrierTotalBillingsForLoadIsValidForMatching() Then

            Dim strAlertMessage As String
            strAlertMessage = "Sorry, You cannot match this Load Charge Record." & vbNewLine & "Because it contains the Load Billing Total of less than one Dollar."
            MsgBox(strAlertMessage, MsgBoxStyle.Critical, "Error - Load Billing Total Is Less Than One Dollar")

            Exit Sub
        End If

        addToOutboundCarrierLoadChargesTempMatch()

        getPendingCarrierChargeRecords()
    End Sub

    Private Sub GridViewLoadChargesMatching_DoubleClick(sender As Object, e As EventArgs) Handles GridViewLoadChargesMatching.DoubleClick
        If Me.bsCarrierLoadChargesMatching.Count = 0 Then
            Exit Sub
        End If

        removeFromOutboundCarrierLoadChargesTempMatch()

        getPendingCarrierChargeRecords()
    End Sub

    Private Sub rbtnAddNewCarrierInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewCarrierInvoice.ItemClick
        addNewCarrierInvoice()
    End Sub

    ' This method will reset all objects on the form
    Private Sub addNewCarrierInvoice()

        Try
            CarrierLookUpEdit.EditValue = Nothing
            CarrierPRONumberInvoiceNumberTextEdit.EditValue = Nothing
            CarrierInvoiceAmountTextEdit.EditValue = Nothing
            CarrierInvoiceDateEdit.EditValue = Nothing
            TotalCarrierChargesTextEdit.EditValue = Nothing


            'bsVendors.DataSource = Nothing
            bsCarrierLoadCharges.DataSource = Nothing
            bsCarrierLoadChargesMatching.DataSource = Nothing

            rbtnEditCarrierLoadCharge.Enabled = False
            rbtnFinalizeCarrierInvoice.Enabled = False

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Private Sub rbtnFinalizeCarrierInvoice_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFinalizeCarrierInvoice.ItemClick
        FinalizeCarrierInvoice()
    End Sub


    ' This method will Finalize Carrier Invoice
    Private Sub FinalizeCarrierInvoice()

        Dim vCarrierID As Integer = 0
        Dim vPRONumberInvoiceNumber As String = ""
        Dim vInvoiceAmount As String = ""
        Dim vInvoiceDate As DateTime = DateTime.MinValue
        Dim vMatchedTotalCarrierCharges As String = ""

        ' Start Validation Process
        Dim strAlertMessage As String = ""
        Dim blnValidationFailed As Boolean = True


        If (CarrierLookUpEdit.EditValue Is Nothing) Then
            strAlertMessage = "Carrier cannot be empty"
            blnValidationFailed = False
        Else
            If CarrierLookUpEdit.EditValue.ToString().Trim().Length = 0 Then
                strAlertMessage = "Carrier cannot be empty"
                blnValidationFailed = False
            End If
        End If

        'If CarrierLookUpEdit.EditValue.ToString().Trim().Length = 0 Then
        '    strAlertMessage = "Carrier cannot be empty"
        '    blnValidationFailed = False
        'End If



        ' Check if there is a value of PRONumberInvoiceNumberTextEdit
        If (CarrierPRONumberInvoiceNumberTextEdit.EditValue Is Nothing) Then
            If (strAlertMessage.Length > 0) Then
                strAlertMessage += vbNewLine & "PRO Number/Invoice Number cannot be empty"
            Else
                strAlertMessage = "PRO Number/Invoice Number cannot be empty"
            End If
            blnValidationFailed = False
        Else
            If CarrierPRONumberInvoiceNumberTextEdit.EditValue.ToString().Trim().Length = 0 Then
                If (strAlertMessage.Length > 0) Then
                    strAlertMessage += vbNewLine & "PRO Number/Invoice Number cannot be empty"
                Else
                    strAlertMessage = "PRO Number/Invoice Number cannot be empty"
                End If
                blnValidationFailed = False
            End If
        End If

        If (CarrierInvoiceDateEdit.EditValue Is Nothing) Then
            If (strAlertMessage.Length > 0) Then
                strAlertMessage += vbNewLine & "Invoice Date cannot be empty"
            Else
                strAlertMessage = "Invoice Date cannot be empty"
            End If
            blnValidationFailed = False
        Else
            If CarrierInvoiceDateEdit.EditValue.ToString().Trim().Length = 0 Then
                If (strAlertMessage.Length > 0) Then
                    strAlertMessage += vbNewLine & "Invoice Date cannot be empty"
                Else
                    strAlertMessage = "Invoice Date cannot be empty"
                End If
                blnValidationFailed = False
            End If
        End If

        If Not blnValidationFailed Then

            strAlertMessage = "Please correct the following before Finalizing Carrier Invoice:" & vbNewLine & vbNewLine & strAlertMessage
            MsgBox(strAlertMessage, MsgBoxStyle.Critical, "Error - Missing Values")
            Exit Sub
        End If

        ' Check if there is a value of CarrierLookUpEdit.EditValue
        Dim vCarrierIDString As String = DirectCast(CarrierLookUpEdit.EditValue, AOS.BusinessObjects.Carrier).CarrierID
        vCarrierID = CInt(vCarrierIDString)

        ' Check if there is a value of PRONumberInvoiceNumberTextEdit
        If Not IsDBNull(CarrierPRONumberInvoiceNumberTextEdit.EditValue) Then
            If Not (CarrierPRONumberInvoiceNumberTextEdit.EditValue Is Nothing) Then
                If (CarrierPRONumberInvoiceNumberTextEdit.EditValue.ToString().Trim().Length > 0) Then
                    vPRONumberInvoiceNumber = CarrierPRONumberInvoiceNumberTextEdit.EditValue.ToString().Trim()
                End If
            End If
        End If

        'Check if there is a value of InvoiceAmountTextEdit
        If Not IsDBNull(CarrierInvoiceAmountTextEdit.EditValue) Then
            If Not (CarrierInvoiceAmountTextEdit.EditValue Is Nothing) Then
                If (CarrierInvoiceAmountTextEdit.EditValue.ToString().Trim().Length > 0) Then
                    vInvoiceAmount = CarrierInvoiceAmountTextEdit.EditValue.ToString().Trim()
                End If
            End If
        End If


        'Check if there is a value of InvoiceAmountTextEdit
        If Not IsDBNull(CarrierInvoiceDateEdit.EditValue) Then
            If Not (CarrierInvoiceDateEdit.EditValue Is Nothing) Then
                If (CarrierInvoiceDateEdit.EditValue.ToString().Trim().Length > 0) Then
                    vInvoiceDate = DateTime.Parse(CarrierInvoiceDateEdit.EditValue.ToString().Trim())
                End If
            End If
        End If


        'Check if there is a value of TotalCarrierChargesTextEdit
        If Not IsDBNull(TotalCarrierChargesTextEdit.EditValue) Then
            If Not (TotalCarrierChargesTextEdit.EditValue Is Nothing) Then
                If (TotalCarrierChargesTextEdit.EditValue.ToString().Trim().Length > 0) Then
                    vMatchedTotalCarrierCharges = TotalCarrierChargesTextEdit.EditValue.ToString().Trim()
                End If
            End If
        End If


        Dim vInvoiceAmountNumeric As Decimal = 0
        Dim vMatchedTotalCarrierChargesNumeric As Decimal = 0

        If (vInvoiceAmount = "") Then
            vInvoiceAmountNumeric = 0
        Else
            vInvoiceAmountNumeric = Decimal.Parse(vInvoiceAmount)
        End If

        If (vMatchedTotalCarrierCharges = "") Then
            vMatchedTotalCarrierChargesNumeric = 0
        Else
            vMatchedTotalCarrierChargesNumeric = Decimal.Parse(vMatchedTotalCarrierCharges)
        End If

        If Not (vInvoiceAmountNumeric = vMatchedTotalCarrierChargesNumeric) Then
            strAlertMessage = "Total of Carrier Charges and Freight Charges do not match." & vbNewLine
            MsgBox(strAlertMessage, MsgBoxStyle.Critical, "Error - Invoice Total Validation")
            CarrierInvoiceAmountTextEdit.Focus()
            Exit Sub
        End If


        If MsgBox("Are you sure you want to finalize the Carrier Invoice?", MsgBoxStyle.YesNo, "Confirm Finalize Carrier Invoice") = MsgBoxResult.No Then
            Exit Sub
        End If


        TotalCarrierChargesTextEdit.EditValue = ""
        Dim vTotalCarrierCharges As Decimal = 0
        oViewLoadChargesForBDFList = New ViewLoadChargesForBDFCollection

        '   oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatusInProgress),
        '                                         oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeOutBound))

        ' Logic of this Query: Select * from dbo.viewLoadChargesForBDF where CarrierID = Value and LoadChargeStatus = TEMPMATCH and (LoadType = OUTBOUND  OR LoadType = INBOUND)
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatusInProgress))
        oViewLoadChargesForBDFList.Query.Where(New EntitySpaces.DynamicQuery.esComparison(EntitySpaces.DynamicQuery.esParenthesis.Open))
        oViewLoadChargesForBDFList.Query.es.DefaultConjunction = EntitySpaces.DynamicQuery.esConjunction.Or
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeOutBound), oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeInBound))
        oViewLoadChargesForBDFList.Query.Where(New EntitySpaces.DynamicQuery.esComparison(EntitySpaces.DynamicQuery.esParenthesis.Close))

        If oViewLoadChargesForBDFList.Query.Load() Then
            For Each oViewLoadChargesForBDF As ViewLoadChargesForBDF In oViewLoadChargesForBDFList
                ' get the Loadcharge record 
                ' Update each LoadCHarge record with current status of TEMPMATCH to MATCHED, add FreightInvoiceNumber, FreightInvoiceDate and save
                Dim oLoadcharge As New Loadcharge
                If oLoadcharge.LoadByPrimaryKey(oViewLoadChargesForBDF.LoadChargeID) Then
                    oLoadcharge.LoadChargeStatus = "MATCHED"
                    oLoadcharge.FreightInvoiceNumber = vPRONumberInvoiceNumber
                    oLoadcharge.FreightInvoiceDate = vInvoiceDate
                    oLoadcharge.Save()
                End If
            Next
        End If

        ' Refresh the Grids
        getPendingCarrierChargeRecords()

    End Sub

    Private Sub rbtnEditLoadCharge_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditCarrierLoadCharge.ItemClick
        editCarrierLoadBilling()
    End Sub

    Private Sub editCarrierLoadBilling()

        Dim vLoadChargeID As Integer
        Dim vLoadBillingID As Integer = 0


        If (Me.bsCarrierLoadCharges.Count = 0) Then
            Exit Sub
        End If

        vLoadChargeID = Me.bsCarrierLoadCharges.Current.LoadChargeID

        If vLoadChargeID < 1 Then
            Exit Sub
        End If

        If vLoadChargeID < 1 Then
            Exit Sub
        End If

        Dim frm As New frmAddEditLoadCharge
        frm.vID = vLoadChargeID
        frm.vEditType = "EDIT"
        frm.ShowDialog()

        getPendingCarrierChargeRecords()

    End Sub

#End Region

#Region "AP BATCH MANAGEMENT"


    Private Sub rbtnAddNewAPBatch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewAPBatch.ItemClick
        AddNewAPBatch()
    End Sub

    Sub AddNewAPBatch()

        If MsgBox("Are you sure you want to add a new AP batch?", MsgBoxStyle.YesNo, "Confirm Add New AP Batch") = MsgBoxResult.No Then
            Exit Sub
        End If

        clearBatchInformation()

        getAPBatchLoadCharges()

    End Sub

    Sub clearBatchInformation()
        APBatchBatchIDTextEdit.EditValue = Nothing
        APBatchBatchDateDateEdit.EditValue = Nothing
        APBatchOutboundLoadChargesTextEdit.EditValue = Nothing
        APBatchOutboundLoadBillingTextEdit.EditValue = Nothing
        APBatchInboundLoadChargesTextEdit.EditValue = Nothing
        APBatchInboundLoadBillingTextEdit.EditValue = Nothing
        APBatchDirectLoadChargesTextEdit.EditValue = Nothing
        APBatchDirectLoadBillingTextEdit.EditValue = Nothing
    End Sub

    Private Sub addNewAPBatchObject()
        Dim oAPBatchID As Integer = 0

        ' We first need to check if there is any existing Pending Batch, then we need to use the Value of APBatchID
        Dim oLoadAPBatchList As New LoadAPBatchCollection
        oLoadAPBatchList.Query.Where(oLoadAPBatchList.Query.BatchStatus.Equal("PENDING"))

        If oLoadAPBatchList.Query.Load() Then

            For Each oLoadAPBatch As LoadAPBatch In oLoadAPBatchList
                oAPBatchID = oLoadAPBatch.APBatchID.Value
            Next
        Else
            ' If there is no Pending Batch then we need to generate a new APBatchID
            Dim oLoadAPBatch As New LoadAPBatch
            oLoadAPBatch.AddNew()
            oLoadAPBatch.APBatchDate = Today
            oLoadAPBatch.BatchStatus = "PENDING"
            oLoadAPBatch.CreatedBy = vCurrentUserLogin
            oLoadAPBatch.Save()
            oAPBatchID = oLoadAPBatch.APBatchID.Value
        End If

        APBatchBatchIDTextEdit.EditValue = oAPBatchID
        APBatchBatchDateDateEdit.EditValue = Today

    End Sub

    Private Sub getAPBatchLoadCharges()

        oViewLoadChargesForBDFList = New ViewLoadChargesForBDFCollection
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal("MATCHED"))

        If oViewLoadChargesForBDFList.Query.Load() Then

            bsAPBatchLoadCharges.DataSource = oViewLoadChargesForBDFList

            CalculateAPBatchLoadChargesAndLoadBillings(oViewLoadChargesForBDFList)
            addNewAPBatchObject()
        Else
            bsAPBatchLoadCharges.DataSource = Nothing
        End If

        If (bsAPBatchLoadCharges.Count <= 0) Then
            rbtnFinalizeAPBatch.Enabled = False
            rbtnAPBatchRefreshMatchedLoadCharges.Enabled = False
            ' rbtnPrintAPBatchReport.Enabled = False

        Else
            rbtnFinalizeAPBatch.Enabled = True
            rbtnAPBatchRefreshMatchedLoadCharges.Enabled = True
            ' rbtnPrintAPBatchReport.Enabled = True
        End If


    End Sub

    Private Sub getAPBatchLoadCharges(ByVal vAPBatchID As Integer)

        oViewLoadChargesForBDFList = New ViewLoadChargesForBDFCollection
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.APBatchID.Equal(vAPBatchID))

        ' oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal("MATCHED"))

        ' oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal("POSTED"),
        '                                        oViewLoadChargesForBDFList.Query.APBatchID.Equal(vAPBatchID))

        If oViewLoadChargesForBDFList.Query.Load() Then

            bsAPBatchLoadCharges.DataSource = oViewLoadChargesForBDFList

            CalculateAPBatchLoadChargesAndLoadBillings(oViewLoadChargesForBDFList)
            addNewAPBatchObject()
        Else
            bsAPBatchLoadCharges.DataSource = Nothing
        End If

        If (bsAPBatchLoadCharges.Count <= 0) Then
            rbtnFinalizeAPBatch.Enabled = False
            rbtnAPBatchRefreshMatchedLoadCharges.Enabled = False
            ' rbtnPrintAPBatchReport.Enabled = False

        Else
            rbtnFinalizeAPBatch.Enabled = True
            rbtnAPBatchRefreshMatchedLoadCharges.Enabled = True
            ' rbtnPrintAPBatchReport.Enabled = True
        End If


    End Sub


    ' This method will calculate Outbound Load Charges, Outbound Load Billing, Direct Load Charges, Direct Load Billing
    Private Sub CalculateAPBatchLoadChargesAndLoadBillings(ByVal vViewLoadChargesForBDFCollection As ViewLoadChargesForBDFCollection)

        If vViewLoadChargesForBDFCollection Is Nothing Then
            Exit Sub
        End If

        Dim vTotalOutboundLoadCharges As Decimal = 0
        Dim vTotalOutboundLoadBilling As Decimal = 0

        Dim vTotalDirectLoadCharges As Decimal = 0
        Dim vTotalDirectLoadBilling As Decimal = 0

        Dim vTotalInboundLoadCharges As Decimal = 0
        Dim vTotalInboundLoadBilling As Decimal = 0

        For Each oViewLoadChargesForBDF As ViewLoadChargesForBDF In vViewLoadChargesForBDFCollection
            Dim iCarrierCharges As Decimal = 0

            Dim iOutboundLoadCharges As Decimal = 0
            Dim iOutboundLoadBilling As Decimal = 0

            Dim iDirectLoadCharges As Decimal = 0
            Dim iDirectLoadBilling As Decimal = 0

            Dim iInboundLoadCharges As Decimal = 0
            Dim iInboundLoadBilling As Decimal = 0

            If Not oViewLoadChargesForBDF.LoadType Is Nothing Then

                If oViewLoadChargesForBDF.LoadType = oLoadChargeTypeOutBound Then

                    ' Calculating Total Outbound Load Charges
                    If Not oViewLoadChargesForBDF.CarrierCharges Is Nothing Then
                        If Not IsDBNull(oViewLoadChargesForBDF.CarrierCharges) Then
                            iOutboundLoadCharges = oViewLoadChargesForBDF.CarrierCharges
                            vTotalOutboundLoadCharges = vTotalOutboundLoadCharges + iOutboundLoadCharges
                        End If
                    End If

                    ' Calculating Total Outbound Load Billing
                    If Not oViewLoadChargesForBDF.Totalbillings Is Nothing Then
                        If Not IsDBNull(oViewLoadChargesForBDF.Totalbillings) Then
                            iOutboundLoadBilling = oViewLoadChargesForBDF.Totalbillings
                            vTotalOutboundLoadBilling = vTotalOutboundLoadBilling + iOutboundLoadBilling
                        End If
                    End If
                End If


                If oViewLoadChargesForBDF.LoadType = oLoadChargeTypeDirect Then
                    ' Calculating Total Direct Load Charges
                    If Not oViewLoadChargesForBDF.CarrierCharges Is Nothing Then
                        If Not IsDBNull(oViewLoadChargesForBDF.CarrierCharges) Then
                            iDirectLoadCharges = oViewLoadChargesForBDF.CarrierCharges
                            vTotalDirectLoadCharges = vTotalDirectLoadCharges + iDirectLoadCharges
                        End If
                    End If

                    ' Calculating Total Direct Load Billing
                    If Not oViewLoadChargesForBDF.Totalbillings Is Nothing Then
                        If Not IsDBNull(oViewLoadChargesForBDF.Totalbillings) Then
                            iDirectLoadBilling = oViewLoadChargesForBDF.Totalbillings
                            vTotalDirectLoadBilling = vTotalDirectLoadBilling + iDirectLoadBilling
                        End If
                    End If

                End If

                If oViewLoadChargesForBDF.LoadType = oLoadChargeTypeInBound Then

                    ' Calculating Total Outbound Load Charges
                    If Not oViewLoadChargesForBDF.CarrierCharges Is Nothing Then
                        If Not IsDBNull(oViewLoadChargesForBDF.CarrierCharges) Then
                            iInboundLoadCharges = oViewLoadChargesForBDF.CarrierCharges
                            vTotalInboundLoadCharges = vTotalInboundLoadCharges + iInboundLoadCharges
                        End If
                    End If

                    ' Calculating Total Outbound Load Billing
                    If Not oViewLoadChargesForBDF.Totalbillings Is Nothing Then
                        If Not IsDBNull(oViewLoadChargesForBDF.Totalbillings) Then
                            iInboundLoadBilling = oViewLoadChargesForBDF.Totalbillings
                            vTotalInboundLoadBilling = vTotalInboundLoadBilling + iInboundLoadBilling
                        End If
                    End If
                End If


            End If

        Next

        APBatchOutboundLoadChargesTextEdit.EditValue = vTotalOutboundLoadCharges
        APBatchOutboundLoadBillingTextEdit.EditValue = vTotalOutboundLoadBilling

        APBatchDirectLoadChargesTextEdit.EditValue = vTotalDirectLoadCharges
        APBatchDirectLoadBillingTextEdit.EditValue = vTotalDirectLoadBilling

        APBatchInboundLoadChargesTextEdit.EditValue = vTotalInboundLoadCharges
        APBatchInboundLoadBillingTextEdit.EditValue = vTotalInboundLoadBilling

    End Sub

    Private Sub rbtnFinalizeAPBatch_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFinalizeAPBatch.ItemClick

        If MsgBox("Are you sure you want to finalize the AP Batch?", MsgBoxStyle.YesNo, "Confirm Finalize AP Batch") = MsgBoxResult.No Then
            Exit Sub
        End If

        FinalizeAPBatch()
        loadPostedAPBatchList()
    End Sub

    ' This method will Finalize APBatch 
    Private Sub FinalizeAPBatch()

        oViewLoadChargesForBDFList = New ViewLoadChargesForBDFCollection
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal("MATCHED"))

        If oViewLoadChargesForBDFList.Query.Load() Then
            For Each oViewLoadChargesForBDF As ViewLoadChargesForBDF In oViewLoadChargesForBDFList
                ' get the Loadcharge record 
                ' Update each LoadCHarge record with current status of MATCHED to POSTED , add APBatchID and save
                Dim oLoadcharge As New Loadcharge
                If oLoadcharge.LoadByPrimaryKey(oViewLoadChargesForBDF.LoadChargeID) Then
                    oLoadcharge.LoadChargeStatus = oLoadChargeStatusPosted
                    oLoadcharge.APBatchID = APBatchBatchIDTextEdit.EditValue
                    oLoadcharge.Save()
                End If
            Next

            ' We also need to update the Status of dbo.LoadAPBatch.BatchStatus to POSTED

            Dim oLoadAPBatch As New LoadAPBatch
            If oLoadAPBatch.LoadByPrimaryKey(APBatchBatchIDTextEdit.EditValue) Then
                oLoadAPBatch.BatchStatus = oLoadChargeStatusPosted
                oLoadAPBatch.CreatedBy = vCurrentUserLogin
                oLoadAPBatch.Save()
            End If
        End If

        ' Refresh the Grids
        ClearoutDetailsAPBatchAfterFinalize()

    End Sub


    Private Sub ClearoutDetailsAPBatchAfterFinalize()

        bsAPBatchLoadCharges.DataSource = Nothing

        'APBatchOutboundLoadChargesTextEdit.EditValue = ""
        'APBatchOutboundLoadBillingTextEdit.EditValue = ""

        'APBatchDirectLoadChargesTextEdit.EditValue = ""
        'APBatchDirectLoadBillingTextEdit.EditValue = ""

        'APBatchBatchIDTextEdit.EditValue = ""
        'APBatchBatchDateDateEdit.EditValue = ""

        clearBatchInformation()

        rbtnFinalizeAPBatch.Enabled = False
        rbtnAPBatchRefreshMatchedLoadCharges.Enabled = False
        '  rbtnPrintAPBatchReport.Enabled = False

    End Sub

    Private Sub rbtnPrintAPBatchReport_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintAPBatchReport.ItemClick
        If IsDBNull(rLUAPBatch.EditValue) Then
            Exit Sub
        End If
        printBDFBatchAnalysis(rLUAPBatch.EditValue)
    End Sub

    Private Sub rbtnAPBatchRefreshMatchedLoadCharges_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAPBatchRefreshMatchedLoadCharges.ItemClick

        clearBatchInformation()
        getAPBatchLoadCharges()
    End Sub

    Private Sub rbtnRetrieveBatchInfo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnRetrieveBatchInfo.ItemClick


        Dim blnValidationFailed As Boolean = True
        Dim strAlertMessage As String = ""
        Dim oAPBatchID As String


        If (rLUAPBatch.EditValue Is Nothing) Then
            strAlertMessage = "Please select AP Batch before retrieving the details"
            blnValidationFailed = False
        Else
            If rLUAPBatch.EditValue.ToString().Trim().Length = 0 Then
                strAlertMessage = "Please select AP Batch before retrieving the details"
                blnValidationFailed = False
            End If
        End If

        If Not blnValidationFailed Then
            MsgBox(strAlertMessage, MsgBoxStyle.Critical, "Error - Retrieve AP Batch")
            Exit Sub
        End If

        clearBatchInformation()

        oAPBatchID = rLUAPBatch.EditValue.ToString().Trim()
        getAPBatchLoadCharges(oAPBatchID)
    End Sub

    Private Sub printBDFBatchAnalysis(vBatchID As Integer)
        Dim rpt As New rptBDFBatchAnalysis(vBatchID)
        rpt.ShowPreviewDialog()
    End Sub

#End Region



#Region "DIRECT LOAD VENDOR INVOICES"

    Private Sub btnLookupVendorLoadDetails_Click(sender As Object, e As EventArgs) Handles btnLookupVendorLoadDetails.Click
        getPendingVendorChargeRecords()
    End Sub

    Private Sub getPendingVendorChargeRecords()
        getDirectVendorLoadCharges()
    End Sub

    Private Sub getDirectVendorLoadCharges()

        oViewLoadChargesForBDFList = New ViewLoadChargesForBDFCollection
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatusPending), oViewLoadChargesForBDFList.Query.LoadType.Equal(oLoadChargeTypeDirect))

        If oViewLoadChargesForBDFList.Query.Load() Then
            bsVendorLoadCharges.DataSource = oViewLoadChargesForBDFList
        Else
            bsVendorLoadCharges.DataSource = Nothing
        End If

        If (bsVendorLoadCharges.Count <= 0) Then
            rbtnEditVendorLoadCharge.Enabled = False
            rbtnFinalizeVendorInvoice.Enabled = False
        Else
            rbtnEditVendorLoadCharge.Enabled = True
            rbtnFinalizeVendorInvoice.Enabled = True
        End If


    End Sub

    Private Sub rbtnEditVendorLoadCharge_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditVendorLoadCharge.ItemClick
        editVendorLoadBilling()
    End Sub

    Private Sub editVendorLoadBilling()

        Dim vLoadChargeID As Integer
        Dim vLoadBillingID As Integer = 0


        If (Me.bsVendorLoadCharges.Count = 0) Then
            Exit Sub
        End If

        vLoadChargeID = Me.bsVendorLoadCharges.Current.LoadChargeID

        If vLoadChargeID < 1 Then
            Exit Sub
        End If

        If vLoadChargeID < 1 Then
            Exit Sub
        End If


        Dim frm As New frmAddEditLoadCharge
        frm.vID = vLoadChargeID
        frm.vEditType = "EDIT"
        frm.ShowDialog()

        getDirectVendorLoadCharges()

    End Sub

    Private Sub rbtnFinalizeVendorInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnFinalizeVendorInvoice.ItemClick
        FinalizeVendorInvoice()
    End Sub

    ' This method will Finalize Carrier Invoice
    Private Sub FinalizeVendorInvoice()


        Dim strAlertMessage As String = ""


        If Not checkIfVendorTotalBillingsForLoadIsValidForMatching() Then
            strAlertMessage = "Sorry, You cannot Finalize this Load Charge Record." & vbNewLine & "Because it contains the Load Billing Total of less than one Dollar."
            MsgBox(strAlertMessage, MsgBoxStyle.Critical, "Error - Load Billing Total Is Less Than One Dollar")

            Exit Sub
        End If

        strAlertMessage = ""
        Dim vVendorID As Integer = 0
        Dim vPRONumberInvoiceNumber As String = ""
        Dim vInvoiceAmount As String = ""
        Dim vInvoiceDate As DateTime = DateTime.MinValue
        Dim vMatchedTotalVendorCharges As String = ""

        ' Start Validation Process

        Dim blnValidationFailed As Boolean = True


        If (VendorLookUpEdit.EditValue Is Nothing) Then
            strAlertMessage = "Vendor cannot be empty"
            blnValidationFailed = False
        Else
            If VendorLookUpEdit.EditValue.ToString().Trim().Length = 0 Then
                strAlertMessage = "Vendor cannot be empty"
                blnValidationFailed = False
            End If
        End If


        ' Check if there is a value of PRONumberInvoiceNumberTextEdit
        If (VendorInvoiceNumberTextEdit.EditValue Is Nothing) Then
            If (strAlertMessage.Length > 0) Then
                strAlertMessage += vbNewLine & "PRO Number/Invoice Number cannot be empty"
            Else
                strAlertMessage = "PRO Number/Invoice Number cannot be empty"
            End If
            blnValidationFailed = False
        Else
            If VendorInvoiceNumberTextEdit.EditValue.ToString().Trim().Length = 0 Then
                If (strAlertMessage.Length > 0) Then
                    strAlertMessage += vbNewLine & "PRO Number/Invoice Number cannot be empty"
                Else
                    strAlertMessage = "PRO Number/Invoice Number cannot be empty"
                End If
                blnValidationFailed = False
            End If
        End If


        If (VendorInvoiceDateDateEdit.EditValue Is Nothing) Then
            If (strAlertMessage.Length > 0) Then
                strAlertMessage += vbNewLine & "Invoice Date cannot be empty"
            Else
                strAlertMessage = "Invoice Date cannot be empty"
            End If
            blnValidationFailed = False
        Else
            If VendorInvoiceDateDateEdit.EditValue.ToString().Trim().Length = 0 Then
                If (strAlertMessage.Length > 0) Then
                    strAlertMessage += vbNewLine & "Invoice Date cannot be empty"
                Else
                    strAlertMessage = "Invoice Date cannot be empty"
                End If
                blnValidationFailed = False
            End If
        End If


        If Not blnValidationFailed Then

            strAlertMessage = "Please correct the following before Finalizing Vendor Invoice:" & vbNewLine & vbNewLine & strAlertMessage
            MsgBox(strAlertMessage, MsgBoxStyle.Critical, "Error - Missing Values")
            Exit Sub
        End If





        ' Check if there is a value of CarrierLookUpEdit.EditValue
        'Dim vVendorIDString As String = DirectCast(VendorLookUpEdit.EditValue, Integer)
        'vVendorID = CInt(vVendorIDString)

        vVendorID = DirectCast(VendorLookUpEdit.EditValue, Integer)

        ' Check if there is a value of PRONumberInvoiceNumberTextEdit
        If Not IsDBNull(VendorInvoiceNumberTextEdit.EditValue) Then
            If Not (VendorInvoiceNumberTextEdit.EditValue Is Nothing) Then
                If (VendorInvoiceNumberTextEdit.EditValue.ToString().Trim().Length > 0) Then
                    vPRONumberInvoiceNumber = VendorInvoiceNumberTextEdit.EditValue.ToString().Trim()
                End If
            End If
        End If

        'Check if there is a value of InvoiceAmountTextEdit
        If Not IsDBNull(VendorInvoiceTotalTextEdit.EditValue) Then
            If Not (VendorInvoiceTotalTextEdit.EditValue Is Nothing) Then
                If (VendorInvoiceTotalTextEdit.EditValue.ToString().Trim().Length > 0) Then
                    vInvoiceAmount = VendorInvoiceTotalTextEdit.EditValue.ToString().Trim()
                End If
            End If
        End If


        'Check if there is a value of InvoiceAmountTextEdit
        If Not IsDBNull(VendorInvoiceDateDateEdit.EditValue) Then
            If Not (VendorInvoiceDateDateEdit.EditValue Is Nothing) Then
                If (VendorInvoiceDateDateEdit.EditValue.ToString().Trim().Length > 0) Then
                    vInvoiceDate = DateTime.Parse(VendorInvoiceDateDateEdit.EditValue.ToString().Trim())
                End If
            End If
        End If


        ''Check if there is a value of TotalCarrierChargesTextEdit
        'If Not IsDBNull(TotalCarrierChargesTextEdit.EditValue) Then
        '    If Not (TotalCarrierChargesTextEdit.EditValue Is Nothing) Then
        '        If (TotalCarrierChargesTextEdit.EditValue.ToString().Trim().Length > 0) Then
        '            vMatchedTotalVendorCharges = TotalCarrierChargesTextEdit.EditValue.ToString().Trim()
        '        End If
        '    End If
        'End If

        If (bsVendorLoadCharges.Count > 0) Then
            If Not (bsVendorLoadCharges.Current.CarrierCharges Is Nothing) Then
                vMatchedTotalVendorCharges = bsVendorLoadCharges.Current.CarrierCharges
            End If
        End If

        '  bsVendorLoadCharges.Current.CarrierCharges


        Dim vInvoiceAmountNumeric As Decimal = 0
        Dim vMatchedTotalCarrierChargesNumeric As Decimal = 0

        If (vInvoiceAmount = "") Then
            vInvoiceAmountNumeric = 0
        Else
            vInvoiceAmountNumeric = Decimal.Parse(vInvoiceAmount)
        End If

        If (vMatchedTotalVendorCharges = "") Then
            vMatchedTotalCarrierChargesNumeric = 0
        Else
            vMatchedTotalCarrierChargesNumeric = Decimal.Parse(vMatchedTotalVendorCharges)
        End If

        If Not (vInvoiceAmountNumeric = vMatchedTotalCarrierChargesNumeric) Then
            strAlertMessage = "Total of Carrier Charges and Invoice Total do not match." & vbNewLine
            MsgBox(strAlertMessage, MsgBoxStyle.Critical, "Error - Invoice Total Validation")
            CarrierInvoiceAmountTextEdit.Focus()
            Exit Sub
        End If


        If MsgBox("Are you sure you want to finalize the Vendor Invoice?", MsgBoxStyle.YesNo, "Confirm Finalize Vendor Invoice") = MsgBoxResult.No Then
            Exit Sub
        End If



        Dim vLoadChargeID As Integer = bsVendorLoadCharges.Current.LoadChargeID

        Dim oLoadcharge As New Loadcharge
        If oLoadcharge.LoadByPrimaryKey(vLoadChargeID) Then
            oLoadcharge.LoadChargeStatus = "MATCHED"
            oLoadcharge.FreightInvoiceNumber = vPRONumberInvoiceNumber
            oLoadcharge.FreightInvoiceDate = vInvoiceDate
            oLoadcharge.FreightVendorID = vVendorID
            oLoadcharge.Save()
        End If


        getDirectVendorLoadCharges()




        'TotalCarrierChargesTextEdit.EditValue = ""
        'Dim vTotalCarrierCharges As Decimal = 0
        'oViewLoadChargesForBDFList = New ViewLoadChargesForBDFCollection

        '' oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatusInProgress))
        'oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vVendorID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatusInProgress),
        '                                       oViewLoadChargesForBDFList.Query.LoadType.Equal("OUTBOUND"))


        ''If (Len(vCarrierID) > 0 And Len(vPRONumberInvoiceNumber) > 0 And Len(vInvoiceAmount) > 0) Then
        ''    oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatus),
        ''                                           oViewLoadChargesForBDFList.Query.CarrierProNumber.Equal(vPRONumberInvoiceNumber), oViewLoadChargesForBDFList.Query.CarrierCharges.Equal(vInvoiceAmount))
        ''End If

        ''If (Len(vCarrierID) > 0 And Len(vPRONumberInvoiceNumber) > 0 And Len(vInvoiceAmount) = 0) Then
        ''    oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatus),
        ''                                           oViewLoadChargesForBDFList.Query.CarrierProNumber.Equal(vPRONumberInvoiceNumber))
        ''End If

        ''If (Len(vCarrierID) > 0 And Len(vPRONumberInvoiceNumber) = 0 And Len(vInvoiceAmount) > 0) Then
        ''    oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatus),
        ''                                           oViewLoadChargesForBDFList.Query.CarrierCharges.Equal(vInvoiceAmount))
        ''End If

        ''If (Len(vCarrierID) > 0 And Len(vPRONumberInvoiceNumber) = 0 And Len(vInvoiceAmount) = 0) Then
        ''    oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.CarrierID.Equal(vCarrierID), oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal(oLoadChargeStatus))
        ''End If


        'If oViewLoadChargesForBDFList.Query.Load() Then
        '    For Each oViewLoadChargesForBDF As ViewLoadChargesForBDF In oViewLoadChargesForBDFList
        '        ' get the Loadcharge record 
        '        ' Update each LoadCHarge record with current status of TEMPMATCH to MATCHED, add FreightInvoiceNumber, FreightInvoiceDate and save
        '        Dim oLoadcharge As New Loadcharge
        '        If oLoadcharge.LoadByPrimaryKey(oViewLoadChargesForBDF.LoadChargeID) Then
        '            oLoadcharge.LoadChargeStatus = "MATCHED"
        '            oLoadcharge.FreightInvoiceNumber = vPRONumberInvoiceNumber
        '            oLoadcharge.FreightInvoiceDate = vInvoiceDate
        '            oLoadcharge.Save()
        '        End If
        '    Next
        'End If

        ' Refresh the Grids
        ' getPendingCarrierChargeRecords()

    End Sub


    Private Function checkIfVendorTotalBillingsForLoadIsValidForMatching() As Boolean

        Dim vTotalCarrierCharges As Decimal = 0

        If (Me.bsVendorLoadCharges.Current.TotalBillings Is Nothing) Then
            Return False
        End If

        vTotalCarrierCharges = Me.bsVendorLoadCharges.Current.TotalBillings

        If vTotalCarrierCharges < 1 Then
            Return False
        End If

        Return True

    End Function

    Private Sub rbtnAddNewVendorInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewVendorInvoice.ItemClick
        addNewVendorInvoice()
    End Sub

    ' This method will reset all objects on the form
    Private Sub addNewVendorInvoice()

        Try
            VendorLookUpEdit.EditValue = Nothing
            VendorInvoiceNumberTextEdit.EditValue = Nothing
            VendorInvoiceDateDateEdit.EditValue = Nothing
            VendorInvoiceTotalTextEdit.EditValue = Nothing


            bsVendorLoadCharges.DataSource = Nothing

            rbtnFinalizeVendorInvoice.Enabled = False
            rbtnEditVendorLoadCharge.Enabled = False

        Catch ex As Exception
            Exit Sub
        End Try

    End Sub


#End Region


#Region "INVOICES"

    Private Sub btnAddBDFInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddBDFInvoice.ItemClick
        addBDFInvoice()
    End Sub


    Private Sub addBDFInvoice()

        Dim vLoadChargeID As Integer
        Dim vLoadBillingID As Integer = 0

        Dim vBDFInvoiceNumber As Integer = 0
        Dim vBDFInvoiceItemNumber As Integer = 0

        If (Me.bsPendingRecordsForInvoices.Count = 0) Then
            Exit Sub
        End If

        ' vLoadChargeID = Me.bsPendingRecordsForInvoices.Current.LoadChargeID
        vLoadChargeID = Me.bsPendingRecordsForInvoices.Current.LoadChargeID

        If vLoadChargeID < 1 Then
            Exit Sub
        End If

        If vLoadChargeID < 1 Then
            Exit Sub
        End If


        Dim strAlertMessage As String = ""
        If Not checkIfTotalBillingsIsValidBeforeCreatingInvoice() Then
            strAlertMessage = "Sorry, You cannot create the invoice." & vbNewLine & "Because the selected record contains the Load Billing Total of less than one Dollar."
            MsgBox(strAlertMessage, MsgBoxStyle.Critical, "Error - Load Billing Total Is Less Than One Dollar")

            Exit Sub
        End If


        If MsgBox("Are you sure you want to create Invoice based on the selected record?", MsgBoxStyle.YesNo, "Confirm Create Invoice") = MsgBoxResult.No Then
            Exit Sub
        End If

        vBDFInvoiceNumber = addBDFInvoiceRecord()
        vBDFInvoiceItemNumber = addBDFInvoiceItemRecord(vBDFInvoiceNumber)

        Dim frm As New frmAddEditBDFInvoice
        ' frm.vID = vLoadChargeID
        frm.vInvoiceNum = vBDFInvoiceNumber

        ' frm.vEditType = "ADD"
        frm.vEditType = "EDIT"
        'frm.ShowDialog()
        frm.Show()

        editBDFInvoiceItem(vBDFInvoiceNumber, vBDFInvoiceItemNumber)
    End Sub


    Private Sub editBDFInvoiceItem(ByVal vBDFInvoiceNumber As Integer, ByVal vBDFInvoiceItemNumber As Integer)

        If vBDFInvoiceNumber <= 0 Then
            Exit Sub
        End If

        If vBDFInvoiceItemNumber <= 0 Then
            Exit Sub
        End If

        Dim frm As New frmAddEditBDFInvoiceItem
        frm.vID = vBDFInvoiceItemNumber
        frm.vFKID = vBDFInvoiceNumber

        'frm.vID = Me.bsBDFInvoiceItems.Current.BDFInvoiceItemNumber
        'frm.vFKID = Me.bsBDFInvoice.Current.BDFInvoiceNumber

        frm.vEditType = "EDIT"
        frm.ShowDialog()

        '  getInvoiceItems(vInvoiceNum)
    End Sub

    Private Function addBDFInvoiceRecord() As Integer
        Dim vBDFInvoiceNumber As Integer = 0

        Dim vLoadInfo As String = ""

        Dim oInvoice As New BDFInvoice

        oInvoice.InvoiceDate = Today
        oInvoice.CreatedTimeStamp = Now
        oInvoice.InvoiceStatus = "PENDING"

        oInvoice.Consigneename = Me.bsPendingRecordsForInvoices.Current.DestName
        oInvoice.Consigneeaddress1 = Me.bsPendingRecordsForInvoices.Current.DestAddress1
        oInvoice.Consigneeaddress2 = Me.bsPendingRecordsForInvoices.Current.DestAddress2
        oInvoice.Consigneecity = Me.bsPendingRecordsForInvoices.Current.DestCity
        oInvoice.Consigneestateprov = Me.bsPendingRecordsForInvoices.Current.DestState
        oInvoice.Consigneepostalcode = Me.bsPendingRecordsForInvoices.Current.DestZip
        oInvoice.Consigneecountry = Me.bsPendingRecordsForInvoices.Current.DestCountry
        oInvoice.Consigneephone = Me.bsPendingRecordsForInvoices.Current.DestPhone
        'oInvoice.CONSIGNEEFAX =   ""
        oInvoice.Consigneecontact = Me.bsPendingRecordsForInvoices.Current.DestContact
        oInvoice.Shippername = Me.bsPendingRecordsForInvoices.Current.OriginName
        oInvoice.Shipperaddress1 = Me.bsPendingRecordsForInvoices.Current.OriginAddress1
        oInvoice.Shipperaddress2 = Me.bsPendingRecordsForInvoices.Current.OriginAddress2
        oInvoice.Shippercity = Me.bsPendingRecordsForInvoices.Current.OriginCity
        oInvoice.Shipperstateprov = Me.bsPendingRecordsForInvoices.Current.OriginState
        oInvoice.Shipperpostalcode = Me.bsPendingRecordsForInvoices.Current.OriginZip
        oInvoice.Shippercountry = Me.bsPendingRecordsForInvoices.Current.OriginCountry
        oInvoice.Shipperphone = Me.bsPendingRecordsForInvoices.Current.OriginPhone
        'oInvoice.SHIPPERFAX =   Me.bsPendingRecordsForInvoices.Current.
        oInvoice.Shippercontact = Me.bsPendingRecordsForInvoices.Current.OriginContact
        oInvoice.Shipmentdate = Me.bsPendingRecordsForInvoices.Current.ScheduledShipmentDate
        'oInvoice.FREIGHTCARRIER =   Me.bsPendingRecordsForInvoices.Current.

        If Not (Me.bsPendingRecordsForInvoices.Current.CarrierProNumber Is Nothing) Then
            vLoadInfo = "" & Me.bsPendingRecordsForInvoices.Current.LoadID & "/" & Me.bsPendingRecordsForInvoices.Current.CarrierProNumber
        Else
            vLoadInfo = "" & Me.bsPendingRecordsForInvoices.Current.LoadID
        End If

        oInvoice.Loadinfo = vLoadInfo

        oInvoice.Remarks = "Please reference invoice [INVOICENUMBER]" & " when remitting payment. If you have any questions regarding this invoice or your account, please call BDF Accounts Payable at 1-847-494-4902"

        oInvoice.CreatedBy = vCurrentUserLogin
        oInvoice.ModifiedBy = vCurrentUserLogin
        oInvoice.ModifiedTimeStamp = Now

        'assign foreign key values here
        oInvoice.Save()
        vBDFInvoiceNumber = oInvoice.BDFInvoiceNumber

        oInvoice.BeginEdit()
        oInvoice.Remarks = "Please reference invoice " & vBDFInvoiceNumber & " when remitting payment. If you have any questions regarding this invoice or your account, please call BDF Accounts Payable at 1-847-494-4902"
        oInvoice.EndEdit()
        oInvoice.Save()


        Return vBDFInvoiceNumber
    End Function


    Private Function addBDFInvoiceItemRecord(ByVal vBDFInvoiceNumber As Integer) As Integer
        Dim vBDFInvoiceItemNumber As Integer = 0

        Dim ExtPrice As Decimal = 0

        Dim oInvoiceItem As New BDFInvoiceItem
        oInvoiceItem.BDFInvoiceNumber = vBDFInvoiceNumber
        oInvoiceItem.Quantity = 1
        oInvoiceItem.ServiceDesc = "Please Edit the service Description"
        oInvoiceItem.Weight = 10
        oInvoiceItem.Rate = "Flat Rate"

        oInvoiceItem.LoadID = Me.bsPendingRecordsForInvoices.Current.LoadID
        oInvoiceItem.APBatchID = Me.bsPendingRecordsForInvoices.Current.APBatchID

        If Not (Me.bsPendingRecordsForInvoices.Current.TotalBillings Is Nothing) Then

            ExtPrice = Me.bsPendingRecordsForInvoices.Current.TotalBillings
            oInvoiceItem.ExtPrice = ExtPrice
        End If

        'assign foreign key values here
        oInvoiceItem.Save()
        vBDFInvoiceItemNumber = oInvoiceItem.BDFInvoiceItemNumber

        Return vBDFInvoiceItemNumber

    End Function

    Private Function checkIfTotalBillingsIsValidBeforeCreatingInvoice() As Boolean

        Dim vTotalBillings As Decimal = 0

        If (Me.bsPendingRecordsForInvoices.Current.TotalBillings Is Nothing) Then
            Return False
        End If

        vTotalBillings = Me.bsPendingRecordsForInvoices.Current.TotalBillings

        If vTotalBillings < 1 Then
            Return False
        End If

        Return True

    End Function



    Private Sub btnGetPendingRecordsForCreatingInvoice_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGetPendingRecordsForCreatingInvoice.ItemClick
        getPendingRecordsForCreatingInvoice()
    End Sub

    Private Sub getPendingRecordsForCreatingInvoice()

        oViewLoadChargesForBDFInvoicesList = New ViewLoadChargesForBDFInvoicesCollection
        oViewLoadChargesForBDFInvoicesList.Query.Where(oViewLoadChargesForBDFInvoicesList.Query.LoadChargeStatus.Equal(oLoadChargeStatusPending),
                                                       oViewLoadChargesForBDFInvoicesList.Query.BillCustomer.Equal(True),
                                                       oViewLoadChargesForBDFInvoicesList.Query.AddToInvoice.Equal(False))

        If oViewLoadChargesForBDFInvoicesList.Query.Load() Then
            bsPendingRecordsForInvoices.DataSource = oViewLoadChargesForBDFInvoicesList
        Else
            bsPendingRecordsForInvoices.DataSource = Nothing
        End If

        If (bsPendingRecordsForInvoices.Count <= 0) Then
            btnAddBDFInvoice.Enabled = False
        Else
            btnAddBDFInvoice.Enabled = True
            GroupControlLoadChargesBillings.BringToFront()
        End If
    End Sub

#End Region


 
End Class
