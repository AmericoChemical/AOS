Imports AOS.BusinessObjects
Imports System.Text

Public Class frmAddEditKit
    Inherits DevExpress.XtraEditors.XtraForm
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)    
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Kit"

    'here is where you dimension your object variables for the form
    Dim oKit As New Kit

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
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
        oKit.AddNew()
        oKit.Save()
        Me.bsKit.DataSource = oKit
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oKit.LoadByPrimaryKey(vID)
        Me.bsKit.DataSource = oKit

        getKitComponents(oKit.Kitid)

    End Sub

    Private Function changesSaved() As Boolean
        If ValidateControls() Then
            bsKit.EndEdit()
            oKit.EndEdit()
            oKit.Save()
        Else
            Return False
        End If

        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bsKit.CancelEdit()
        Try
            If vEditType = "ADD" Then

                Dim oKitComponents As New KitcomponentCollection
                oKitComponents.Query.Where(oKitComponents.Query.Kitid.Equal(bsKit.Current.kitID))
                oKitComponents.LoadAll()

                For Each oKitComponent As Kitcomponent In oKitComponents
                    Dim oKitem As New Kitcomponent
                    oKitem.LoadByPrimaryKey(oKitComponent.Kitcomponentid)
                    oKitem.MarkAsDeleted()
                    oKitem.Save()
                Next

                oKit.MarkAsDeleted()
                oKit.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick

        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    ' TODO: Change the method name to "getKitComponents" and pass an argument vID and use that instead of oKit.KitID inside the method

    Private Sub getKitComponents(vID)
        Dim oKitCollection As ViewKitComponentCollection

        oKitCollection = New ViewKitComponentCollection
        oKitCollection.Query.Where(oKitCollection.Query.Kitid.Equal(vID))
        oKitCollection.Query.Load()
        bsKitComponents.DataSource = oKitCollection

    End Sub

    Private Sub btnKitCompAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnKitCompAdd.ItemClick
        bsKit.EndEdit()
        Using frm As New frmAddEditKitComponents() With
            {
                .vID = bsKit.Current.kitID,
                .oKit = oKit,
                .vEditType = "ADD"
            }
            frm.ShowDialog()
        End Using
        getKitComponents(oKit.Kitid)
    End Sub

    Private Sub btnKitCompEdit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnKitCompEdit.ItemClick
        bsKit.EndEdit()
        If bsKitComponents.Count <= 0 Then
            Exit Sub
        End If
        Using frm As New frmAddEditKitComponents() With
            {
                .vID = bsKit.Current.kitID,
                .oKit = oKit,
                .vKitComponentID = bsKitComponents.Current.KitComponentid,
                .vEditType = "EDIT"
            }
            frm.ShowDialog()
        End Using
        getKitComponents(oKit.Kitid)
    End Sub

    Private Sub btnKitCompDelete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnKitCompDelete.ItemClick

        If bsKitComponents.Count <= 0 Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete the selected kit component?", MsgBoxStyle.YesNo, "Delete Kit Component - Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            ' Delete the Kit Component based on the selected row in the Grid
            Dim oKitComponents As New Kitcomponent
            If oKitComponents.LoadByPrimaryKey(bsKitComponents.Current.kitComponentid) Then
                oKitComponents.MarkAsDeleted()
                oKitComponents.Save()
                MsgBox("Record successfully deleted", MsgBoxStyle.Information, "Delete Kit Component - Success")
            Else
                MsgBox("Could not delete selected kit item", MsgBoxStyle.Critical, "Delete Kit Component - Error")
            End If
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Delete Kit Component - Error")
        End Try
        getKitComponents(oKit.Kitid)

    End Sub

    Private Function ValidateControls() As Boolean
        If String.IsNullOrEmpty(Me.KitNameTextEdit.Text) Or Me.KitNameTextEdit.Text.Trim() = String.Empty Then
            MsgBox("Kit name is required. Please enter the kit name.", MsgBoxStyle.Critical, "Validate Kit - Error")
            KitNameTextEdit.Focus()
            Return False
        End If

        Return True
    End Function
End Class