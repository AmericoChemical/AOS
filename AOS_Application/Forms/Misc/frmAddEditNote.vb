Imports AOS.BusinessObjects

Public Class frmAddEditNote
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vLinkType As String
    Public vLinkKey As Integer

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = ""

    'here is where you dimension your object variables for the form
    Dim oNote As Note

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New Note for " & vLinkType & " " & vLinkKey.ToString
        Else
            Me.Text = "Editing Note for " & vLinkType & " " & vLinkKey.ToString
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
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
        oNote = New Note
        oNote.AddNew()
        'assign foreign key values here
        oNote.LinkType = vLinkType
        oNote.LinkKey = vLinkKey
        oNote.CreateBy = vCurrentUserLogin
        oNote.CreateTime = Now
        oNote.ModifyBy = vCurrentUserLogin
        oNote.ModifyTime = Now
        oNote.Save()
        Me.bsNote.DataSource = oNote
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oNote = New Note
        oNote.LoadByPrimaryKey(vID)
        Me.bsNote.DataSource = oNote
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsNote.EndEdit()
            oNote.EndEdit()
            oNote.ModifyTime = Now
            oNote.ModifyBy = vCurrentUserLogin
            oNote.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsNote.CancelEdit()
            oNote.CancelEdit()
            If vEditType = "ADD" Then
                oNote.MarkAsDeleted()
                oNote.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error cancelling changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
End Class