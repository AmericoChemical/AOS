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

    Private Function changesSaved() As Boolean
        If ValidateControls() Then
            bsProductFulfillmentPlan.EndEdit()
            'WE ARE NO LONGER COPYING TEMPLATE RELABEL INSTRUCTIONS TO THE PRODUCTRELABELINSTRUCTION Table. That table is only for ADDITIONAL instructions specific to a product.
            'If updateProductRelabelInstructions(oProductfulfillmentplan.Fulfillmentplanid, oProductfulfillmentplan.Fulfillmenttypeid) = False Then
            '    Return False
            'End If
            oProductfulfillmentplan.Modifytime = Now
            oProductfulfillmentplan.Modifyby = vCurrentUserLogin
            oProductfulfillmentplan.EndEdit()
            oProductfulfillmentplan.Save()

            'if Fulfillment Plan Type = 2 (Relabel) then we need to calculate the standard cost of the product,
            'based on the Associated Product and the Kit and Labor Hours required for relabeling, then process and resulting
            'effects on other products' standard costs (though this should not be likely)
            If oProductfulfillmentplan.Fulfillmenttypeid = 2 Then
                Dim oRlbCosts As New ViewRelabelProductsCostChanges
                oRlbCosts.Query.Where(oRlbCosts.Query.Productid.Equal(oProductfulfillmentplan.Productid))
                If oRlbCosts.Query.Load Then
                    'update Relabeled Product Standard Costs
                    Dim oProduct As New Product
                    If oProduct.LoadByPrimaryKey(oProductfulfillmentplan.Productid) Then
                        'set new values
                        oProduct.Volumestandardcost = oRlbCosts.Newvolcost
                        oProduct.Weightstandardcost = oRlbCosts.Newwgtcost
                        oProduct.Save()
                    End If

                    'add product change history record for the relabeled product
                    AddProductCostChangeHistoryRecord(oProductfulfillmentplan.Productid, oRlbCosts.Oldvolcost, oRlbCosts.Oldwgtcost, oRlbCosts.Newvolcost, oRlbCosts.Newwgtcost, "RELABEL CHNG - PROD " & oProduct.Productid & " " & oProduct.Productdesc, "STD COST")

                End If
            End If
            Return True
        End If
        Return False
    End Function

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