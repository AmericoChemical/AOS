Imports AOS.BusinessObjects

Public Class frmAddEditMaterialProductLink
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vMPID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vMaterialID As Integer
    Public vMaterialDesc As String
    Public vProductID As Integer
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Material Product Link"

    'here is where you dimension your object variables for the form
    Dim oItem As Materialproduct

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadProducts()
        loadData()
    End Sub

    Private Sub loadProducts()
        Select Case vEditType
            Case "ADD"
                Dim oProducts As New ViewProductExcludeMaterialProductCollection
                oProducts.LoadAll()
                oProducts.Sort = "ProductID"
                eProduct.Properties.DataSource = bsProductList
                bsProductList.DataSource = oProducts
                eProduct.Properties.ReadOnly = False
            Case Else
                Dim oProduct As New Product
                oProduct.LoadByPrimaryKey(vProductID)
                eProduct.Properties.DataSource = bsProduct
                bsProduct.DataSource = oProduct
                eProduct.Properties.ReadOnly = True
        End Select
    End Sub
    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vMPID)
        End If
        eMaterialDesc.Text = vMaterialDesc
    End Sub

    Private Sub addNewObject()
        oItem = New Materialproduct
        oItem.AddNew()
        'assign foreign key values here
        oItem.Materialid = vMaterialID
        oItem.Priority = 0
        oItem.Save()
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Materialproduct
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function ModifiedColumns() As List(Of String)

        Dim vModifiedColumns As New List(Of String)
        If oItem.es.IsDirty Then
            For Each obj As String In oItem.es.ModifiedColumns

                Select Case obj.ToString
                    Case "PRODUCTID",
                        "PRIORITY"
                        vModifiedColumns.Add(obj.ToString)
                End Select
            Next
        End If

        Return vModifiedColumns

    End Function

    Private Function changesSaved() As Boolean
        Try
            bsItem.EndEdit()
            Dim vmodifedColumns As List(Of String) = ModifiedColumns()

            oItem.EndEdit()
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

End Class