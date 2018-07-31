Imports AOS.BusinessObjects
Public Class frmAuditPermissions

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer
    Public vEditType As String

    Dim oAuditpermissions As New Auditpermissions


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()
    End Sub

    Private Sub loadLookupTables()
        Dim oAuditcategories As New AuditcategoryCollection
        Dim oAppUsers As New ViewAppuserCollection

        oAuditcategories.LoadAll()
        oAuditcategories.Sort = "AUDITCATEGORY"
        Me.bsAuditCategories.DataSource = oAuditcategories

        oAppUsers.LoadAll()
        Me.bsAppUsers.DataSource = oAppUsers
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oAuditpermissions.AddNew()
        oAuditpermissions.Save()
        Me.bsAuditPermission.DataSource = oAuditpermissions
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oAuditpermissions.LoadByPrimaryKey(vID)
        Me.bsAuditPermission.DataSource = oAuditpermissions
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If ValidateControls() Then
            If changesSaved() Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        End If
    End Sub

    Private Function changesSaved() As Boolean
        bsAuditPermission.EndEdit()
        oAuditpermissions.EndEdit()
        oAuditpermissions.Save()
        Return True
    End Function

    Private Function ValidateControls() As Boolean
        If String.IsNullOrEmpty(Me.CategoryLookupEdit.Text) Then
            MsgBox("Audit Category is required.", MsgBoxStyle.Critical, "Error")
            CategoryLookupEdit.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(Me.UserLookUpEdit.Text) Then
            MsgBox("User Login is required.", MsgBoxStyle.Critical, "Error")
            UserLookUpEdit.Focus()
            Return False
        End If

        Dim oAuditpermissions As New AuditpermissionsCollection
        If vEditType = "ADD" Then
            oAuditpermissions.Query.Where(oAuditpermissions.Query.Auditcategoryid.Equal(CategoryLookupEdit.EditValue), oAuditpermissions.Query.Userid.Equal(UserLookUpEdit.EditValue))
            oAuditpermissions.Query.Load()
        Else
            oAuditpermissions.Query.Where(oAuditpermissions.Query.Auditcategoryid.Equal(CategoryLookupEdit.EditValue), oAuditpermissions.Query.Userid.Equal(UserLookUpEdit.EditValue), oAuditpermissions.Query.Auditpermissionsid.NotEqual(vID))
            oAuditpermissions.Query.Load()
        End If

        If oAuditpermissions.Count > 0 Then
            Dim vMsg As String = String.Format("User {0} already has audit permission for the category {1}. Please select a different Audit Category or User Login to continue", UserLookUpEdit.Text, CategoryLookupEdit.Text)
            MsgBox(vMsg, MsgBoxStyle.Critical, "Error")
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Function changesCancelled() As Boolean
        bsAuditPermission.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oAuditpermissions.MarkAsDeleted()
                oAuditpermissions.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

End Class