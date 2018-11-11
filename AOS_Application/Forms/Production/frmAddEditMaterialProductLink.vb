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
            SetMaterialProductPriority(oItem.Mpid)
            ProcessMaterialCostChanges(oItem.Materialid, "Material Change - MatId " & oItem.Materialid & "[" & String.Join(",", vmodifedColumns.ToArray()) & "]", "STD COST", "Material Change-ID" & oItem.Materialid)

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
        If ValidateData() = False Then
            'SetFocustoFirstNullFieldinPricingMethod()
            Exit Sub
        End If

        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub
    Public Shared Sub SetMaterialProductPriorityOne(ByVal materialId As Integer)
        Dim materialProductOne As New Materialproduct
        If Not materialProductOne.LoadByPriority(materialId, 1) Then
            Dim oMatProducts As New MaterialproductCollection
            oMatProducts.Query.Where(oMatProducts.Query.Materialid = materialId And oMatProducts.Query.Priority > 1)
            oMatProducts.Query.OrderBy(oMatProducts.Query.Priority.Ascending)
            If oMatProducts.Query.Load AndAlso oMatProducts.Count > 0 Then
                oMatProducts(0).Priority = 1
                oMatProducts.Save()
                Exit Sub
            Else
                Dim oMatProductAll As New MaterialproductCollection
                oMatProductAll.Query.Where(oMatProductAll.Query.Materialid = materialId)
                oMatProductAll.Query.OrderBy(oMatProductAll.Query.Priority.Ascending)
                If oMatProductAll.Query.Load AndAlso oMatProductAll.Count > 0 Then
                    oMatProductAll(0).Priority = 1
                    oMatProductAll.Save()
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub SetMaterialProductPriority(ByVal materialProductId As Integer)
        Dim oCurrentMaterialProduct As New Materialproduct
        If oCurrentMaterialProduct.LoadByPrimaryKey(materialProductId) Then
            Dim materialId As Integer = oCurrentMaterialProduct.Materialid
            Dim priority As Integer = oCurrentMaterialProduct.Priority
            If priority = 0 Then
                Exit Sub
            End If
            If priority <> 1 Then
                SetMaterialProductPriorityOne(materialId)
            End If
            ' Check if duplicates
            Dim oMaterialDupProducts As New MaterialproductCollection
            oMaterialDupProducts.Query.Where(oMaterialDupProducts.Query.Materialid = materialId And oMaterialDupProducts.Query.Priority >= priority And oMaterialDupProducts.Query.Mpid <> materialProductId)
            oMaterialDupProducts.Query.OrderBy(oMaterialDupProducts.Query.Priority.Ascending)
            If oMaterialDupProducts.Query.Load AndAlso oMaterialDupProducts.Count > 0 Then
                If oMaterialDupProducts(0).Priority = priority Then
                    oMaterialDupProducts(0).Priority = oMaterialDupProducts(0).Priority + 1
                    oMaterialDupProducts.Save()
                    SetMaterialProductPriority(oMaterialDupProducts(0).Mpid)
                End If

            End If
        End If
    End Sub


    Private Function ValidateData()
        If String.IsNullOrEmpty(Me.PriorityTextEdit.Text) Then
            MsgBox("Must specifiy priority", MsgBoxStyle.Critical, "Error")
            PriorityTextEdit.Focus()
            Return False
        End If
        Dim priority As Integer
        Integer.TryParse(Me.PriorityTextEdit.Text, priority)
        If priority <> 1 Then
            Dim materialProductOne As New Materialproduct
            If Not materialProductOne.LoadByPriority(vMaterialID, 1) OrElse materialProductOne.Mpid = oItem.Mpid Then
                If MsgBox("Must have a priority 1 record. Set  priority to 1?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
                    PriorityTextEdit.Focus()
                    Return False
                Else
                    PriorityTextEdit.Text = "1"
                End If
            End If
        End If

        If priority <> 0 Then
            Dim materialProduct As New Materialproduct
            If materialProduct.LoadByPriority(vMaterialID, priority) Then
                If MsgBox("Priority already exists. Auto adjust priorities?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
                    PriorityTextEdit.Focus()
                    Return False
                End If
            End If
        End If
        Return True
    End Function
    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

End Class