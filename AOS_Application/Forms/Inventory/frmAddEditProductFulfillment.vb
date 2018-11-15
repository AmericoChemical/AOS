Imports AOS.BusinessObjects
Imports System.Text

Public Class frmAddEditProductFulfillment
    Inherits DevExpress.XtraEditors.XtraForm
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)    
    Public vEditType As String  'operating mode (passed in by calling form)
    Public oProduct As Product

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Product Fulfillment"

    'here is where you dimension your object variables for the form
    Dim oProductfulfillmentplan As New Productfulfillmentplan
    Dim oAssociateProductList As ProductCollection
    Dim oFulfillmentTypeList As ListFulfillmenttypeCollection
    Dim oKits As KitCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getProducts()
        getKits()
        loadData()
    End Sub
    Private Sub getProducts()

        oAssociateProductList = New ProductCollection
        oAssociateProductList.Query.Where(oAssociateProductList.Query.Isactive.Equal(1), oAssociateProductList.Query.Productid.NotEqual(oProduct.Productid))
        oAssociateProductList.Query.Load()
        oAssociateProductList.Sort = "PRODUCTDESC, PRODUCTID"
        bsAssociateProducts.DataSource = oAssociateProductList

        oFulfillmentTypeList = New ListFulfillmenttypeCollection
        oFulfillmentTypeList.Query.Where(oFulfillmentTypeList.Query.Fulfillmenttypeid.NotEqual(0))
        oFulfillmentTypeList.Query.Load()
        oFulfillmentTypeList.Sort = "FULFILLMENTTYPEID"
        bsFulfillmentType.DataSource = oFulfillmentTypeList

    End Sub

    Private Sub getKits()
        oKits = New KitCollection
        oKits.LoadAll()
        bsKits.DataSource = oKits

    End Sub
    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
        bsProducts.DataSource = oProduct
    End Sub
    Private Sub addNewObject()
        oProductfulfillmentplan.AddNew()
        oProductfulfillmentplan.Productid = oProduct.Productid
        oProductfulfillmentplan.Fulfillmenttypeid = 0
        oProductfulfillmentplan.Priority = 0
        oProductfulfillmentplan.Createdby = vCurrentUserLogin
        oProductfulfillmentplan.Createdtime = Now
        oProductfulfillmentplan.Save()
        Me.bsProductFulfillmentPlan.DataSource = oProductfulfillmentplan
    End Sub

    Private Sub editObject(ByVal vPFID As Integer)
        If vPFID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oProductfulfillmentplan.LoadByPrimaryKey(vPFID)
        Me.bsProductFulfillmentPlan.DataSource = oProductfulfillmentplan
    End Sub

    Private Function ModifiedColumns() As List(Of String)

        Dim vModifiedColumns As New List(Of String)
        If oProductfulfillmentplan.es.IsDirty Then
            For Each obj As String In oProductfulfillmentplan.es.ModifiedColumns

                Select Case obj.ToString
                    Case "FULFILMENTTYPEID",
                            "PRIORITY",
                          "KITID",
                          "STDLABORHRS",
                         "ASSOCIATEDPRODUCTID"
                        vModifiedColumns.Add(obj.ToString)
                End Select
            Next
        End If

        Return vModifiedColumns

    End Function

    Private Function changesSaved() As Boolean
        If ValidateControls() Then
            bsProductFulfillmentPlan.EndEdit()
            'WE ARE NO LONGER COPYING TEMPLATE RELABEL INSTRUCTIONS TO THE PRODUCTRELABELINSTRUCTION Table. That table is only for ADDITIONAL instructions specific to a product.
            'If updateProductRelabelInstructions(oProductfulfillmentplan.Fulfillmentplanid, oProductfulfillmentplan.Fulfillmenttypeid) = False Then
            '    Return False
            'End If
            Dim vmodifedColumns As List(Of String) = ModifiedColumns()
            If vmodifedColumns.Count Then
                oProductfulfillmentplan.Modifytime = Now
                oProductfulfillmentplan.Modifyby = vCurrentUserLogin
            End If


            oProductfulfillmentplan.EndEdit()
            oProductfulfillmentplan.Save()

            SetProductFulfilmentPlanPriority(oProductfulfillmentplan.Fulfillmentplanid)

            'if Fulfillment Plan Type = 2 (Relabel) then we need to calculate the standard cost of the product,
            'based on the Associated Product and the Kit and Labor Hours required for relabeling, then process and resulting
            'effects on other products' standard costs (though this should not be likely)
            '            If oProductfulfillmentplan.Fulfillmenttypeid = 2 Then

            'Dim oProduct As New Product
            'If oProduct.LoadByPrimaryKey(oProductfulfillmentplan.Productid) Then
            SetProductStatndardCosts(oProductfulfillmentplan.Productid, "FulFillment Plan Change - ProdId " & oProductfulfillmentplan.Productid, "FulFillment Plan Change - ProdId " & oProductfulfillmentplan.Productid & String.Join(",", vmodifedColumns.ToArray()))

            'If getProductStandardCostSource(oProductfulfillmentplan.Productid) = "RELABEL" Then
            '    ProcessRelabelProductStandardCostChanges(oProductfulfillmentplan.Productid, "STD COST", , )
            'End If
            '    Dim oRlbCosts As New ViewRelabelProductsCostChanges
            'oRlbCosts.Query.Where(oRlbCosts.Query.Productid.Equal(oProductfulfillmentplan.Productid))
            'If oRlbCosts.Query.Load Then
            '    'update Relabeled Product Standard Costs
            '    'set new values
            '    oProduct.Volumestandardcost = oRlbCosts.Newvolcost
            '        oProduct.Weightstandardcost = oRlbCosts.Newwgtcost
            '        oProduct.Save()
            '    End If

            '    'add product change history record for the relabeled product
            '    AddProductCostChangeHistoryRecord(oProductfulfillmentplan.Productid, oRlbCosts.Oldvolcost, oRlbCosts.Oldwgtcost, oRlbCosts.Newvolcost, oRlbCosts.Newwgtcost, "RELABEL CHNG - PROD " & oProduct.Productid & " " & oProduct.Productdesc, "STD COST")

            ' End If
            '  End If
            Return True
        End If
        Return False
    End Function

    Public Shared Sub SetProductFulfilmentPlanOne(ByVal productId As Integer)
        Dim productfulfillmentplanOne As New Productfulfillmentplan
        If Not productfulfillmentplanOne.LoadByPriority(productId, 1) Then
            Dim oProductPlans As New ProductfulfillmentplanCollection
            oProductPlans.Query.Where(oProductPlans.Query.Productid = productId And oProductPlans.Query.Priority > 1)
            oProductPlans.Query.OrderBy(oProductPlans.Query.Priority.Ascending)
            If oProductPlans.Query.Load AndAlso oProductPlans.Count > 0 Then
                oProductPlans(0).Priority = 1
                oProductPlans.Save()
                Exit Sub
            Else
                Dim oproductFulfillmentplanAll As New ProductfulfillmentplanCollection
                oproductFulfillmentplanAll.Query.Where(oproductFulfillmentplanAll.Query.Productid = productId)
                oproductFulfillmentplanAll.Query.OrderBy(oproductFulfillmentplanAll.Query.Priority.Ascending)
                If oproductFulfillmentplanAll.Query.Load AndAlso oproductFulfillmentplanAll.Count > 0 Then
                    oproductFulfillmentplanAll(0).Priority = 1
                    oproductFulfillmentplanAll.Save()
                    Exit Sub
                End If
            End If
        End If
    End Sub
    Private Sub SetProductFulfilmentPlanPriority(ByVal fulfilmentPlanId As Integer)
        Dim oCurrentProductfulfillmentplan As New Productfulfillmentplan
        If oCurrentProductfulfillmentplan.LoadByPrimaryKey(fulfilmentPlanId) Then
            Dim productId As Integer = oCurrentProductfulfillmentplan.Productid
            Dim priority As Integer = oCurrentProductfulfillmentplan.Priority
            If priority = 0 Then
                Exit Sub
            End If
            If priority <> 1 Then
                SetProductFulfilmentPlanOne(productId)
            End If
            ' Check if duplicates
            Dim oDupProductFulfilmentPlans As New ProductfulfillmentplanCollection
            oDupProductFulfilmentPlans.Query.Where(oDupProductFulfilmentPlans.Query.Productid = productId And oDupProductFulfilmentPlans.Query.Priority >= priority And oDupProductFulfilmentPlans.Query.Fulfillmentplanid <> fulfilmentPlanId)
            oDupProductFulfilmentPlans.Query.OrderBy(oDupProductFulfilmentPlans.Query.Priority.Ascending)
            If oDupProductFulfilmentPlans.Query.Load AndAlso oDupProductFulfilmentPlans.Count > 0 Then
                If oDupProductFulfilmentPlans(0).Priority = priority Then
                    oDupProductFulfilmentPlans(0).Priority = oDupProductFulfilmentPlans(0).Priority + 1
                    oDupProductFulfilmentPlans.Save()
                    SetProductFulfilmentPlanPriority(oDupProductFulfilmentPlans(0).Fulfillmentplanid)
                End If

            End If
        End If
    End Sub
    Private Function changesCancelled() As Boolean
        bsProductFulfillmentPlan.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oProductfulfillmentplan.MarkAsDeleted()
                oProductfulfillmentplan.Save()
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

    Private Function ValidateControls() As Boolean
        Dim productId As Integer = oProduct.Productid
        If String.IsNullOrEmpty(Me.eFulfillmentType.Text) Then
            MsgBox("Fulfillment Type is required.", MsgBoxStyle.Critical, "Error")
            eFulfillmentType.Focus()
            Return False
        End If

        If Me.eFulfillmentType.Text = FulfillmentType.RLBL.ToString() AndAlso
                String.IsNullOrEmpty(Me.AssociateProductLookUpEdit.Text) Then
            MsgBox("Associate Product is required.", MsgBoxStyle.Critical, "Error")
            AssociateProductLookUpEdit.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.PriorityTextEdit.Text) Then
            MsgBox("Priority is required", MsgBoxStyle.Critical, "Error")
            PriorityTextEdit.Focus()
            Return False
        End If

        Dim priority As Integer = 0
        Integer.TryParse(PriorityTextEdit.Text, priority)
        'If priority = 0 Then
        '    MsgBox("Priority can not be 0", MsgBoxStyle.Critical, "Error")
        '    PriorityTextEdit.Focus()
        '    Return False
        'End If

        If priority <> 1 Then
            Dim productFulfilmentPlanOne As New Productfulfillmentplan
            If Not productFulfilmentPlanOne.LoadByPriority(productId, 1) OrElse productFulfilmentPlanOne.Fulfillmentplanid = oProductfulfillmentplan.Fulfillmentplanid Then
                If MsgBox("Must have a priority 1 record. Set  priority to 1?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
                    PriorityTextEdit.Focus()
                    Return False
                Else
                    PriorityTextEdit.Text = "1"
                    priority = 1
                End If
            End If
        End If

        If priority = "1" And eFulfillmentType.Text <> FulfillmentType.INV.ToString() Then
            MsgBox("Priority 1 must be INV", MsgBoxStyle.Critical, "Error")
            PriorityTextEdit.Focus()
            Return False
        End If

        If priority <> 0 Then
            Dim productPlan As New Productfulfillmentplan
            If productPlan.LoadByPriority(productId, priority) AndAlso productPlan.Fulfillmentplanid <> oProductfulfillmentplan.Fulfillmentplanid Then
                If MsgBox("Priority already exists. Auto adjust priorities?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
                    PriorityTextEdit.Focus()
                    Return False
                End If
            End If
        End If

        Return True
    End Function

    Private Sub FulfillmentTypeLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles eFulfillmentType.EditValueChanged
        If IsDBNull(eFulfillmentType.EditValue) OrElse
           eFulfillmentType.EditValue = SourceType.RLBL Then
            AssociateProductLookUpEdit.Enabled = True
            eKit.Enabled = True
            eLabor.Enabled = True
            Exit Sub
        End If
        AssociateProductLookUpEdit.Enabled = False
        AssociateProductLookUpEdit.EditValue = Nothing
        oProductfulfillmentplan.Associatedproductid = Nothing
        eKit.Enabled = False
        eKit.EditValue = Nothing
        oProductfulfillmentplan.Kitid = Nothing
        eLabor.Enabled = False
        eLabor.EditValue = Nothing
        oProductfulfillmentplan.Stdlaborhrs = Nothing

    End Sub

End Class