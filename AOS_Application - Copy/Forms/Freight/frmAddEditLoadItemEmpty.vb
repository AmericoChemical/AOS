Imports AOS.BusinessObjects

Public Class frmAddEditLoadItemEmpty
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vLoadItemID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vLoadID As Integer
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Load Item"

    'here is where you dimension your object variables for the form
    Dim oLoadItem As Loaditem
    Dim oLoad As Load

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadReferenceData()
        loadData()
    End Sub

    Private Sub loadReferenceData()

    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vLoadItemID)
        End If
    End Sub

    Private Sub addNewObject()
        oLoadItem = New Loaditem
        oLoadItem.AddNew()
        oLoadItem.LoadID = vLoadID
        oLoadItem.ItemType = "PRODUCT"
        oLoadItem.CreatedBy = vCurrentUserLogin
        oLoadItem.CreatedTime = Now
        oLoadItem.ModifiedBy = vCurrentUserLogin
        oLoadItem.ModifiedTime = Now
        oLoadItem.Save()
        vLoadItemID = oLoadItem.LoadItemID
        Me.bsLoadItem.DataSource = oLoadItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Me.Close()
            Exit Sub
        End If
        oLoadItem = New Loaditem
        oLoadItem.LoadByPrimaryKey(vID)
        Me.bsLoadItem.DataSource = oLoadItem
    End Sub

    Private Sub btnCancel_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        oLoadItem.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oLoadItem.MarkAsDeleted()
                oLoadItem.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If saveChanges() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function saveChanges() As Boolean
        Try
            bsLoadItem.EndEdit()
            oLoadItem.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

   
End Class