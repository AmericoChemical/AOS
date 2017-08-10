Imports AOS.BusinessObjects

Public Class frmAddEditContainer
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vContainer As String
    Public vEditType As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Container"

    'here is where you dimension your object variables for the form
    Dim oItem As Container

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vContainer)
        End If
    End Sub

    Private Sub addNewObject()
        oItem = New Container
        oItem.AddNew()
        oItem.EndEdit()
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vContainer As String)
        If vContainer = Nothing Then
            MsgBox("There is no Container Record selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Container
        oItem.LoadByPrimaryKey(vContainer)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsItem.EndEdit()
            oItem.EndEdit()
            oItem.Save()
            If oItem.Container Is Nothing Then
                MsgBox("You must enter a Container name", MsgBoxStyle.Critical, "Error - No Container Name")
                Me.eContainer.Focus()
                Return False
            End If
            If oItem.TareWeight Is Nothing Then
                MsgBox("You must enter a Tare Weight for this container", MsgBoxStyle.Critical, "Error - No Tare Weight")
                Me.eTareWeight.Focus()
                Return False
            End If
            If oItem.Units Is Nothing Then
                MsgBox("You must enter a Units value (number of units per container)", MsgBoxStyle.Critical, "Error - No Units")
                Me.eUnits.Focus()
                Return False
            End If
            If oItem.Uom Is Nothing Then
                MsgBox("You must enter a Unit of Measure value ", MsgBoxStyle.Critical, "Error - No UOM")
                Me.eUOM.Focus()
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsItem.CancelEdit()
            oItem.CancelEdit()
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
        End Try

        Return True
    End Function

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub


End Class