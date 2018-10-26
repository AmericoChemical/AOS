Imports AOS.BusinessObjects

Public Class frmAddEditMaterialItem
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
    Friend vObjectName As String = "Material Item"

    'here is where you dimension your object variables for the form
    Dim oItem As Material
    Dim oProducts As ViewMaterialProductInfoCollection


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
        loadProducts()
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub loadProducts()
        oProducts = New ViewMaterialProductInfoCollection
        oProducts.Query.Where(oProducts.Query.Materialid.Equal(bsItem.Current.materialID))
        oProducts.Query.Load()
        oProducts.Sort = "PRIORITY ASC"
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub addNewObject()
        oItem = New Material
        oItem.AddNew()
        'assign foreign key values here
        oItem.Materialstatus = "ACTIVE"
        oItem.Save()
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Material
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function ModifiedColumns() As List(Of String)

        Dim vModifiedColumns As New List(Of String)
        If oItem.es.IsDirty Then
            For Each obj As String In oItem.es.ModifiedColumns

                Select Case obj.ToString
                    Case "MATERIALSTATUS"
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
            Dim vmodifedColumns As List(Of String) = ModifiedColumns()
            oItem.Modifytime = Now
            oItem.Modifyby = vCurrentUserLogin
            oItem.Save()
            ProcessMaterialCostChanges(oItem.Materialid, "Material Change-" & String.Join(",", vmodifedColumns.ToArray()), "STD COST", "Material Change-ID" & oItem.Materialid)
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

    Private Sub rbtnAddNewProduct_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewProduct.ItemClick
        Dim frm As New frmAddEditMaterialProductLink
        frm.vMaterialID = bsItem.Current.MaterialID
        frm.vMaterialDesc = bsItem.Current.MaterialDesc
        frm.vEditType = "ADD"
        frm.ShowDialog()
        loadProducts()
    End Sub

    Private Sub rbtnEditProductLink_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditProductLink.ItemClick
        Dim frm As New frmAddEditMaterialProductLink
        frm.vMPID = bsProducts.Current.mpid
        frm.vMaterialID = bsItem.Current.MaterialID
        frm.vMaterialDesc = bsItem.Current.MaterialDesc
        frm.vProductID = bsProducts.Current.ProductID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadProducts()
    End Sub

    Private Sub rbtnDeleteProductLink_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteProductLink.ItemClick
        If bsProducts.Count <= 0 Then
            Exit Sub
        End If

        Dim str As String = "Are you sure you want to delete the selected Material-Product Link record?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim obj As New Materialproduct
        Dim materialId As Integer
        If obj.LoadByPrimaryKey(bsProducts.Current.MPID) Then
            materialId = obj.Materialid
            obj.MarkAsDeleted()
            obj.Save()
            ProcessMaterialCostChanges(materialId, "Material Change-Delete Link", "STD COST", "Material Change-ID" & materialId)
        End If

        loadProducts()

    End Sub

    Private Sub rbtnChangeMaterialStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangeMaterialStatus.ItemClick
        Select Case eStatus.EditValue
            Case "ACTIVE"
                If MsgBox("Are you sure you want to mark this Material as ARCHIVED?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.Yes Then
                    If materialOnActiveAPIS(bsItem.Current.MaterialID) Then
                        MsgBox("This Material is on another ACTIVE APIS and cannot be marked ARCHIVED", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    Else
                        eStatus.EditValue = "ARCHIVED"
                    End If
                End If
            Case "ARCHIVED"
                If MsgBox("Are you sure you want to mark this Material as ACTIVE?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.Yes Then
                    eStatus.EditValue = "ACTIVE"
                End If
            Case Else
                If MsgBox("Are you sure you want to mark this Material as ACTIVE?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.Yes Then
                    eStatus.EditValue = "ACTIVE"
                End If
        End Select
    End Sub

    Private Function materialOnActiveAPIS(vMatID As Integer) As Boolean
        Dim oAPISList As New ViewAPISMaterialStatusCollection
        oAPISList.Query.Where(oAPISList.Query.Materialid.Equal(vMatID), oAPISList.Query.Apisstatus.NotEqual("ARCHIVED"))
        If oAPISList.Query.Load Then
            Return True
        Else
            Return False
        End If
    End Function
End Class