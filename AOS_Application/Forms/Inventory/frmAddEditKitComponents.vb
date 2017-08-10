Imports AOS.BusinessObjects
Imports System.Text

Public Class frmAddEditKitComponents
    Inherits DevExpress.XtraEditors.XtraForm


    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)   
    Public vKitComponentID As Integer
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vKitComponent As Kitcomponent
    Public oKit As Kit

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Kit Component"

    'here is where you dimension your object variables for the form
    Dim oComponentCollection As New ComponentCollection
    Dim oKitComponent As New KitComponent
    Dim oComponent As New Component

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()
    End Sub

    Private Sub loadLookupTables()
        oComponentCollection = New ComponentCollection
        oComponentCollection.Query.Load()
        bsComponentCollection.DataSource = oComponentCollection
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject()
        End If

        bsKit.DataSource = oKit
    End Sub
    Private Sub addNewObject()

        oKitComponent.AddNew()
        oKitComponent.Componentqty = 0
        oKitComponent.Save()
        Me.bsKitComponent.DataSource = oKitComponent

    End Sub

    Private Sub editObject()
        If vID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oKitComponent.LoadByPrimaryKey(vKitComponentID)
        Me.bsKitComponent.DataSource = oKitComponent
    End Sub
    Private Function changesSaved() As Boolean
        bsKitComponent.EndEdit()
        oKitComponent.EndEdit()
        oKitComponent.Save()
        Return True
    End Function
    Private Function changesCancelled() As Boolean
        bsKitComponent.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oKitComponent.MarkAsDeleted()
                oKitComponent.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick

        If ValidateControls() Then
            bsKitComponent.Current.kitID = vID
            If changesSaved() Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Function ValidateControls() As Boolean
        If String.IsNullOrEmpty(Me.AmericoDescLookUpEdit.Text) Then
            MsgBox("Americo Description is required.", MsgBoxStyle.Critical, "Validate Kit Component - Error")
            AmericoDescLookUpEdit.Focus()
            Return False
        End If

        ' Check Kit component information already exists or not.
        ' If vEditType = "ADD" then check based on combination of Componentid, Kitid and Componentqty columns values in all in Kitcomponent table
        ' If vEditType = "EDIT" then check based on combination of Componentid, Kitid and Componentqty columns values in all except this current record in Kitcomponent table
        Dim oKitComponentList As New KitcomponentCollection
        If vEditType = "ADD" Then
            oKitComponentList.Query.Where(oKitComponentList.Query.Componentid.Equal(AmericoDescLookUpEdit.EditValue), oKitComponentList.Query.Kitid.Equal(vID), oKitComponentList.Query.Componentqty.Equal(eQty.Text.Trim()))
        Else
            oKitComponentList.Query.Where(oKitComponentList.Query.Componentid.Equal(AmericoDescLookUpEdit.EditValue), oKitComponentList.Query.Kitid.Equal(vID), oKitComponentList.Query.Componentqty.Equal(eQty.Text.Trim()), oKitComponentList.Query.Kitcomponentid.NotEqual(vKitComponentID))
        End If

        oKitComponentList.Query.Load()

        If oKitComponentList.Count > 0 Then
            MsgBox("Kit component information already exists.", MsgBoxStyle.Critical, "Validate Kit Component - Error")
            Return False
        End If

        Return True
    End Function
End Class