Imports AOS.BusinessObjects

Public Class viewAudit
    Inherits DevExpress.XtraEditors.XtraUserControl

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Dim oParms As Sysparameters = Nothing


    Dim oAuditPermissions As ViewAuditPermissionsCollection

    Enum AuditLogStatus
        OPEN
        INPROGRESS
        CLOSED
    End Enum

    Enum AuditAction
        RESOLVEISSUE
        EDITISSUE
    End Enum

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
        oParms.LoadByPrimaryKey(AuditLogProcessing.cSYSPARAMETERSRECORDID)
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
        viewAuditForm()

    End Sub

    Private Sub rbtnResolveLog_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnResolveLog.ItemClick
        editAndResolveAuditLog(AuditAction.RESOLVEISSUE)
    End Sub

    Private Sub editAndResolveAuditLog(vMode As AuditAction)
        If bsAuditLog.Count <= 0 Then
            Exit Sub
        End If
        Dim vStatus As String = bsAuditLog.Current.status

        Dim vSelectedRow As Integer = AuditLogView.GetSelectedRows().Length
        Dim vAuditlogIDs(vSelectedRow - 1) As Integer
        Dim vRowIndex As Integer
        Dim vIndex As Integer = 0
        Dim vFirstRecordAuditlogID As Integer

        If vSelectedRow = 0 Then

            Select Case vMode
                Case AuditAction.EDITISSUE
                    MsgBox("No issues selected to edit.", MsgBoxStyle.OkOnly)
                    Exit Sub
                Case AuditAction.RESOLVEISSUE
                    MsgBox("No issues selected to resolve.", MsgBoxStyle.OkOnly)
            End Select

        Else
            vFirstRecordAuditlogID = AuditLogView.GetRowCellValue(AuditLogView.GetSelectedRows.GetValue(vIndex), AuditLogView.Columns.ColumnByName("colAuditlogid"))
            For vIndex = 0 To vSelectedRow - 1
                vRowIndex = AuditLogView.GetSelectedRows.GetValue(vIndex)
                If AuditLogView.GetRowCellValue(vRowIndex, AuditLogView.Columns.ColumnByName("colCategory")) <> bsAuditLog.Current.auditCategory Or AuditLogView.GetRowCellValue(vRowIndex, AuditLogView.Columns.ColumnByName("colMasterRecordID")) <> bsAuditLog.Current.masterRecordID Then
                    MsgBox("Audit Category and/or Master Record ID are not same for the selected rows. Please select audit logs that have same category and master record id.", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                Else
                    vAuditlogIDs(vIndex) = CType(AuditLogView.GetRowCellValue(vRowIndex, AuditLogView.Columns.ColumnByName("colAuditlogid")), Integer)
                End If
            Next

            Select Case vMode
                Case AuditAction.EDITISSUE
                    Using frm As New frmEditAuditLog() With
                        {
                            .vID = vFirstRecordAuditlogID,
                            .vAuditlogIDs = vAuditlogIDs,
                            .vAddtype = "EDIT"
                        }
                        frm.ShowDialog()
                    End Using
                Case AuditAction.RESOLVEISSUE
                    Using frm As New frmAuditPricing() With
                        {.vAuditlogIDs = vAuditlogIDs}
                        frm.ShowDialog()
                    End Using
            End Select

            loadAuditLog(vStatus)
        End If
    End Sub

    Private Sub btnEditLog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditLog.ItemClick
        editAndResolveAuditLog(AuditAction.EDITISSUE)
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

    Private Sub loadAuditLog(vStatus As String)
        Dim oAuditLogCollection As New ViewAuditLogCollection
        If vStatus = AuditLogStatus.Closed.ToString() Then
            oAuditLogCollection.Query.Where(oAuditLogCollection.Query.Userid.Equal(vCurrentUserID), oAuditLogCollection.Query.Status.Equal(AuditLogStatus.Closed.ToString()))
        Else
            oAuditLogCollection.Query.Where(oAuditLogCollection.Query.Userid.Equal(vCurrentUserID), oAuditLogCollection.Query.Status.NotEqual(AuditLogStatus.Closed.ToString()))
        End If

        oAuditLogCollection.Query.Load()
        oAuditLogCollection.Filter = ""
        oAuditLogCollection.Sort = "STATUS DESC"

        Try
            bsAuditLog.DataSource = oAuditLogCollection
            grAuditLog.DataSource = Nothing
            Me.grAuditLog.DataSource = bsAuditLog
            Me.grAuditLog.Refresh()
            Me.grAuditLog.RefreshDataSource()
            Me.grAuditLog.MainView.RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub viewAuditForm()
        selectView("pnlAuditCategoriesHolder", False) 
        getAuditForm()
    End Sub

    Private Sub SetupToolbarButtons(enableKitButtons As Boolean)
        btnAddAuditPermissions.Enabled = enableKitButtons
        btnEditAuditPermissions.Enabled = enableKitButtons
        btnDeleteAuditPermissions.Enabled = enableKitButtons

        btnAddAuditForm.Enabled = (enableKitButtons = False)
        btnEditAuditForm.Enabled = (enableKitButtons = False)
        btnDeleteAuditForm.Enabled = (enableKitButtons = False)
    End Sub

    Private Sub rbtnOpenIssues_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnOpenIssues.ItemClick
        loadAuditLog(AuditLogStatus.Open.ToString())
        btnResolveLog.Enabled = True
    End Sub

    Private Sub rbtnClosedIssues_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClosedIssues.ItemClick
        loadAuditLog(AuditLogStatus.Closed.ToString())
        btnResolveLog.Enabled = False
    End Sub

    Private Sub btnViewAuditForm_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnViewAuditForm.ItemClick
        viewAuditForm()
    End Sub

    Private Sub btnViewAuditPermissions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnViewAuditPermissions.ItemClick
        selectView("pnlAuditPermissionHolder", True)
        getAuditPermissions()
    End Sub

    Private Sub selectView(vPanelControl As String, vEnableButtons As Boolean)
        Dim ctlPage As New DevExpress.XtraEditors.PanelControl
        ctlPage = Me.RibbonPanelControl2.Controls(vPanelControl)

        If Not ctlPage Is Nothing Then
            ctlPage.BringToFront()
        End If

        SetupToolbarButtons(vEnableButtons)
    End Sub

    Private Sub btnAddAuditForm_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddAuditForm.ItemClick
        Using frm As New frmAuditLogForm() With
            {.vEditType = "ADD"}
            frm.ShowDialog()
        End Using
        getAuditForm()
    End Sub

    Private Sub btnEditAuditForm_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditAuditForm.ItemClick
        If bsAuditForm.Count <= 0 Then
            Exit Sub
        End If
        Using frm As New frmAuditLogForm() With
            {
                .vID = Me.bsAuditForm.Current.auditCategoryID,
                .vEditType = "EDIT"
            }
            frm.ShowDialog()
        End Using
        getAuditForm()
    End Sub

    Private Sub btnDeleteAuditForm_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteAuditForm.ItemClick
        deleteAuditForm()
    End Sub

    Private Sub getAuditForm()
        Dim oAuditForm As New ViewAuditCategoryCollection
        oAuditForm.LoadAll()
        oAuditForm.Sort = "AUDITCATEGORYID ASC"
        bsAuditForm.DataSource = oAuditForm

        Me.grAuditForm.DataSource = bsAuditForm
        Me.grAuditForm.Refresh()
    End Sub

    Private Sub deleteAuditForm()

        If bsAuditForm.Count <= 0 Then
            Exit Sub
        End If

        Dim vStr As String
        vStr = "Are you sure you want to delete the selected Audit Category?" & Chr(13) & Chr(13)
        vStr &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(vStr, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Dim oAuditlog As New AuditlogCollection
            ' See if the CATEGORY is being used in Audit Form, don't allow deletion if it is
            oAuditlog.Query.Where(oAuditlog.Query.Auditcategoryid.Equal(bsAuditForm.Current.auditCategoryID))
            oAuditlog.LoadAll()

            Dim oAuditRule As New AuditruleCollection
            ' See if the CATEGORY is being used in Audit Rule, don't allow deletion if it is
            oAuditRule.Query.Where(oAuditRule.Query.Auditcategoryid.Equal(bsAuditForm.Current.auditCategoryID))
            oAuditRule.LoadAll()

            If (oAuditlog.Count > 0) Then
                MsgBox("Unable to delete the Audit Category is being used by Audit Log.")
                Exit Sub
            End If
            If (oAuditRule.Count > 0) Then
                MsgBox("Unable to delete the Audit Category is being used by Audit Rule.")
                Exit Sub
            End If

            Dim oAuditpermission As New AuditpermissionsCollection
            ' See if the CATEGORY is being used in Audit Permission, don't allow deletion if it is
            oAuditpermission.Query.Where(oAuditpermission.Query.Auditcategoryid.Equal(bsAuditForm.Current.auditCategoryID))
            oAuditpermission.LoadAll()

            If (oAuditpermission.Count > 0) Then
                MsgBox("Delete is not allowed because audit permissions exist for this Audit Category.")
                Exit Sub
            End If

            Dim oAuditcategory As New Auditcategory
            oAuditcategory.LoadByPrimaryKey(bsAuditForm.Current.auditCategoryID)
            oAuditcategory.MarkAsDeleted()
            oAuditcategory.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        getAuditForm()
    End Sub

    Private Sub btnAddAuditPermissions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddAuditPermissions.ItemClick
        Using frm As New frmAuditPermissions() With
            {.vEditType = "ADD"}
            frm.ShowDialog()
        End Using
        getAuditPermissions()
    End Sub

    Private Sub btnEditAuditPermissions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditAuditPermissions.ItemClick
        If bsAuditPermission.Count <= 0 Then
            Exit Sub
        End If
        Using frm As New frmAuditPermissions() With
            {
                .vID = Me.bsAuditPermission.Current.auditPermissionsID,
                .vEditType = "EDIT"
            }
            frm.ShowDialog()
        End Using
        getAuditPermissions()
    End Sub

    Private Sub btnDeleteAuditPermissions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteAuditPermissions.ItemClick
        deleteAuditPermissions()
    End Sub

    Private Sub getAuditPermissions()
        oAuditPermissions = New ViewAuditPermissionsCollection
        oAuditPermissions.LoadAll()
        oAuditPermissions.Sort = "AUDITPERMISSIONSID ASC"
        bsAuditPermission.DataSource = oAuditPermissions

        Me.grAuditPermission.DataSource = bsAuditPermission
        Me.grAuditPermission.Refresh()
    End Sub

    Private Sub deleteAuditPermissions()

        If bsAuditPermission.Count <= 0 Then
            Exit Sub
        End If

        Dim vStr As String
        vStr = "Are you sure you want to delete the selected Audit Permission?" & Chr(13) & Chr(13)
        vStr &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(vStr, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Sub
        End If
        Try
            Dim oAuditpermissions As New Auditpermissions
            oAuditpermissions.LoadByPrimaryKey(bsAuditPermission.Current.auditPermissionsID)
            oAuditpermissions.MarkAsDeleted()
            oAuditpermissions.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
        End Try
        getAuditPermissions()
    End Sub
     
End Class
