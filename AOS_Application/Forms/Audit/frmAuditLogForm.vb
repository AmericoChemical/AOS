Imports AOS.BusinessObjects
Public Class frmAuditLogForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer
    Public vEditType As String

    Dim oAuditcategory As New Auditcategory

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oAuditcategory.AddNew()
        oAuditcategory.Save()
        Me.bsAuditLogForm.DataSource = oAuditcategory
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oAuditcategory.LoadByPrimaryKey(vID)
        Me.bsAuditLogForm.DataSource = oAuditcategory
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If ValidateControls() Then
            If changesSaved() Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        End If
    End Sub

    Private Function changesSaved() As Boolean
        bsAuditLogForm.EndEdit()
        oAuditcategory.EndEdit()
        oAuditcategory.Save()
        Return True
    End Function

    Private Function ValidateControls() As Boolean

        If String.IsNullOrEmpty(Me.AuditcategoryTextEdit.Text) Then
            MsgBox("Audit Category is required.", MsgBoxStyle.Critical, "Error")
            AuditcategoryTextEdit.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(Me.AuditFormNameTextEdit.Text) Then
            MsgBox("Audit Form Name is required.", MsgBoxStyle.Critical, "Error")
            AuditFormNameTextEdit.Focus()
            Return False
        End If

        Dim oAuditcategoryCollection As New AuditcategoryCollection
        If vEditType = "ADD" Then
            oAuditcategoryCollection.Query.Where(oAuditcategoryCollection.Query.Auditcategory.Equal(AuditcategoryTextEdit.Text), oAuditcategoryCollection.Query.Auditformname.Equal(AuditFormNameTextEdit.Text))
            oAuditcategoryCollection.Query.Load()
        Else
            oAuditcategoryCollection.Query.Where(oAuditcategoryCollection.Query.Auditcategory.Equal(AuditcategoryTextEdit.Text), oAuditcategoryCollection.Query.Auditformname.Equal(AuditFormNameTextEdit.Text), oAuditcategoryCollection.Query.Auditcategoryid.NotEqual(vID))
            oAuditcategoryCollection.Query.Load()
        End If

        If oAuditcategoryCollection.Count > 0 Then
            MsgBox("Audit category and audit form name already exists.", MsgBoxStyle.Critical, "Error")
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
        bsAuditLogForm.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oAuditcategory.MarkAsDeleted()
                oAuditcategory.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

End Class