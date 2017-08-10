
Imports AOS.AppSession
Imports AOS.AppUtilities

Public Class frmMain

#Region " Form Initilization "

    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = My.Settings.SkinName

        'add command to load the User Settings/Appearance menu popup with a list of all skins registered (registered in program module)
        DevExpress.XtraBars.Helpers.SkinHelper.InitSkinPopupMenu(SkinsList)

        'Add an event handler to handle when the default look and feel skin has been changed
        AddHandler DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged, AddressOf UserLookAndFeel_StyleChanged

        'set status bar item values
        StatusVersionNum.Caption = "Version: " + My.Settings.ApplicationVersion
        StatusSQLServerName.Caption = My.Settings.SQLDatabaseServerName
        StatusSQLServerDBName.Caption = My.Settings.DatabaseName
        StatusUserFullName.Caption = vCurrentUserFullName
        StatusSQLServerDBName.Caption = My.Settings.DatabaseName

        Select Case My.Settings.DatabaseName
            Case "AOSData"
                Me.Text = "AOS - Americo Operations System"
            Case "AOSTest"
                Me.Text = "AOS - TEST SYSTEM"
            Case "AOSDev"
                Me.Text = "AOS - DEVELOPMENT SYSTEM"
        End Select


        ' TODO: This is for testing purposes only
        'Process the Main Menu selection options for user security clearance
        ' SetupMenu(vCurrentUserSecurityLevel)
        SetupMenuOptions(vCurrentUserID)
        ' vCurrentUserID

        ' Call Security Timer to start hiding/showing Groups and Functions based on the security settings 
        StartSecurityTimer()

        mMainForm = Me
        Dim mView As New viewHome
        showViewer(mView, "viewHome")
    End Sub



    Private Sub UserLookAndFeel_StyleChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim skin As DevExpress.Skins.Skin = DevExpress.Skins.CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default)
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = skin.Name
        My.Settings.SkinName = skin.Name
        My.Settings.Save()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        StatusCurrentDateTime.Caption = FormatDateTime(Now, DateFormat.LongDate) + "  " + FormatDateTime(Now, DateFormat.LongTime)
    End Sub

#End Region

#Region " Menu Options "

    Private Sub SetupMenu(ByVal vLevel As Integer)

        For Each vMenuLink As DevExpress.XtraBars.BarItemLink In mainMenuBar.ItemLinks
            Try
                Dim vMenuOption As DevExpress.XtraBars.BarSubItem = vMenuLink.Item
                If CInt(vMenuOption.Tag) > vLevel Then
                    vMenuOption.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                Else
                    vMenuOption.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End If
            Catch ex As Exception
            End Try
        Next

    End Sub

    Private Sub SetupMenuOptions(ByVal vCurrentUserID As Integer)

        For Each vMenuLink As DevExpress.XtraBars.BarItemLink In mainMenuBar.ItemLinks
            Try
                Dim vMenuOption As DevExpress.XtraBars.BarSubItem = vMenuLink.Item
                If CInt(vMenuOption.Tag) > 0 Then
                    'look up this Tag value as the AppMenuID and the Current User ID to determine User Permissions for this menu option
                    Dim oAppUserMenu As New Appusermenu
                    oAppUserMenu.Query.Where(oAppUserMenu.Query.Appmenuid.Equal(vMenuOption.Tag), oAppUserMenu.Query.Appuserid.Equal(vCurrentUserID))
                    If oAppUserMenu.Query.Load() Then
                        If oAppUserMenu.Permitted = True Then
                            vMenuOption.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Else
                            vMenuOption.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                        End If
                    Else
                        vMenuOption.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                    End If
                Else
                    vMenuOption.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                End If

            Catch ex As Exception
            End Try
        Next

    End Sub

    Private Sub showViewer(ByVal mView As System.Windows.Forms.UserControl, ByVal vName As String)
        'first check to see if control is already loaded into main form
        Dim ctl As New Control
        For Each ctl In mMainForm.viewPanel.Controls
            If ctl.Name = vName Then
                ctl.BringToFront()
                Exit Sub
            End If
        Next


        'if control is not loaded, load it now
        mMainForm.SuspendLayout()
        mMainForm.viewPanel.SuspendLayout()
        mMainForm.viewPanel.Controls.Add(mView)
        mView.Width = Me.Width
        mView.Height = mMainForm.viewPanel.Height
        mView.Dock = DockStyle.Fill
        mView.BringToFront()
        Application.DoEvents()
        mMainForm.viewPanel.ResumeLayout()
        mMainForm.ResumeLayout()


    End Sub


#End Region

    Private Sub BarSubItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem1.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewHome
        showViewer(mView, "viewHome")
        Cursor = Cursors.Default
    End Sub

    Private Sub BarSubItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem2.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewSalesCustomers
        showViewer(mView, "viewSalesCustomers")
        Cursor = Cursors.Default
    End Sub

    Private Sub BarSubItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem4.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewInventory
        showViewer(mView, "viewInventory")
        Cursor = Cursors.Default
    End Sub

    Private Sub BarSubItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem5.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewShipping
        showViewer(mView, "viewShipping")
        Cursor = Cursors.Default
    End Sub

    Private Sub BarSubItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem6.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewAdministration
        showViewer(mView, "viewAdministration")
        Cursor = Cursors.Default
    End Sub

    Private Sub mnuProduction_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuProduction.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewProduction
        showViewer(mView, "viewProduction")
        Cursor = Cursors.Default
    End Sub

    Private Sub mnuReceiving_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuWarehouse.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewWarehouse
        showViewer(mView, "viewWarehouse")
        Cursor = Cursors.Default
    End Sub

    Private Sub BarSubItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem9.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewWorkOrders
        showViewer(mView, "viewWorkOrders")
        Cursor = Cursors.Default
    End Sub

    Private Sub BarSubItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem12.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewFreightDashboard
        showViewer(mView, "viewFreightDashboard")
        Cursor = Cursors.Default
    End Sub

    Private Sub BarSubItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem10.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewLab
        showViewer(mView, "viewLab")
        Cursor = Cursors.Default
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

        SetupMenuOptions(vCurrentUserID)
    End Sub

    Private Sub mnuBDF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuBDF.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewBDF
        showViewer(mView, "viewBDF")
        Cursor = Cursors.Default
    End Sub

    'This functionality is targeted on the BDF Only
    ' Goal: On Closing the Form, clear all grids. Search data for any LOADCHARGE records with TEMPMATCH status and return to PENDING status
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing

        Dim oViewLoadChargesForBDFList As New ViewLoadChargesForBDFCollection
        oViewLoadChargesForBDFList.Query.Where(oViewLoadChargesForBDFList.Query.LoadChargeStatus.Equal("TEMPMATCH"))

        If oViewLoadChargesForBDFList.Query.Load() Then
            For Each oViewLoadChargesForBDF As ViewLoadChargesForBDF In oViewLoadChargesForBDFList
                ' get the Loadcharge record 
                ' Update each LoadCHarge record with current status of TEMPMATCH to MATCHED, add FreightInvoiceNumber, FreightInvoiceDate and save
                Dim oLoadcharge As New Loadcharge
                If oLoadcharge.LoadByPrimaryKey(oViewLoadChargesForBDF.LoadChargeID) Then
                    oLoadcharge.LoadChargeStatus = "PENDING"
                    oLoadcharge.Save()
                End If
            Next

        End If
    End Sub

    Private Sub mnuDataAnalysis_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuDataAnalysis.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewDataAnalysis
        showViewer(mView, "viewDataAnalysis")
        Cursor = Cursors.Default
    End Sub

    Private Sub BarSubItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarSubItem14.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewAudit
        showViewer(mView, "viewAudit")
        Cursor = Cursors.Default
    End Sub

    Private Sub BarSubItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles mnuPurchasing.ItemClick
        Cursor = Cursors.WaitCursor
        Dim mView As New viewPurchasing2
        showViewer(mView, "viewPurchasing2")
        Cursor = Cursors.Default
    End Sub

End Class