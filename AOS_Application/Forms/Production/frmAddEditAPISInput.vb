Imports AOS.BusinessObjects

Public Class frmAddEditAPISInput
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vAPISNUm As Integer 'Foreign key value for master table = FORMULA
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Formula Material Input"

    'here is where you dimension your object variables for the form
    Dim oItem As Apisitem
    Private oMaterials As MaterialCollection
    Private oVolUOM As ViewUOMByVolumeCollection
    Private oWgtUOM As ViewUOMByWeightCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getMaterials()
        getReferenceData()
        loadData()
    End Sub

    Private Sub getReferenceData()
        oVolUOM = New ViewUOMByVolumeCollection
        oVolUOM.LoadAll()
        bsVolumeUOM.DataSource = oVolUOM
        oWgtUOM = New ViewUOMByWeightCollection
        oWgtUOM.LoadAll()
        bsWeightUOM.DataSource = oWgtUOM
    End Sub

    Private Sub getMaterials()
        oMaterials = New MaterialCollection
        oMaterials.Query.Where(oMaterials.Query.Materialstatus.Equal("ACTIVE"))
        oMaterials.Query.Load()
        oMaterials.Sort = "MaterialDesc"
        bsMaterials.DataSource = oMaterials
    End Sub
    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oItem = New Apisitem
        oItem.AddNew()
        'assign foreign key values here
        oItem.Apisnum = vAPISNUm
        oItem.Save()
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Apisitem
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function ModifiedColumns() As List(Of String)

        Dim vModifiedColumns As New List(Of String)
        If oItem.es.IsDirty Then
            For Each obj As String In oItem.es.ModifiedColumns

                Select Case obj.ToString
                    Case "MATERIALID",
                            "QTYUNITS",
                          "VOLUMEQTY",
                          "WEIGHTQTY"
                        vModifiedColumns.Add(obj.ToString)
                End Select
            Next
        End If

        Return vModifiedColumns

    End Function

    Private Function changesSaved() As Boolean
        Try
            bsItem.EndEdit()
            oItem.EndEdit()
            Dim vModifiedColumns As List(Of String) = ModifiedColumns()
            oItem.Save()
            Dim APIS As New Apis
            If APIS.LoadByPrimaryKey(oItem.Apisnum) AndAlso APIS.Productid.HasValue Then
                SetProductStatndardCosts(APIS.Productid, "APIS Change - ProdId-" & APIS.Productid, "APIS Change - ApidId " & APIS.Apisnum & "[Input " & oItem.Apisitemnum & ":" + String.Join(",", vModifiedColumns.ToArray()) + "]")
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