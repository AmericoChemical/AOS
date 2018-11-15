Imports AOS.BusinessObjects
Imports System.Text

Public Class frmviewProductFulfillment
    Inherits DevExpress.XtraEditors.XtraForm
    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vPID As Integer       'object primary key (passed in by calling form for edit mode)    
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you dimension your object variables for the form

    Dim oProduct As New Product
    Dim oProductFulfillment As New ProductfulfillmentplanCollection

    Private Sub timer1_tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loaddata()
    End Sub
    Private Sub loaddata()
        editobject(vPID)
    End Sub

    Private Sub editobject(ByVal pid As Integer)
        If pid = Nothing Then
            MsgBox("There is no record id selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oProduct.LoadByPrimaryKey(pid)
        Me.bsProduct.DataSource = oProduct
        refreshProductFulfillment()
    End Sub

    Private Sub refreshProductFulfillment()
        bsProductFulfillment.DataSource = getProductFulfillment(vPID)
        enableRelabelInstruction()
    End Sub


    Private Sub btnClose_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnProductFulfillmentEdit_itemclick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProductFulfillmentEdit.ItemClick
        bsProductFulfillment.EndEdit()
        If bsProductFulfillment.Count <= 0 Then
            Exit Sub
        End If
        Using frm As New frmAddEditProductFulfillment() With
            {
                .vID = bsProductFulfillment.Current.FULFILLMENTPLANID,
                .vEditType = "EDIT",
                .oProduct = oProduct
            }
            frm.ShowDialog()
        End Using

        refreshProductFulfillment()
    End Sub

    Private Sub btnProductFulfillmentdelete_itemclick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProductFulfillmentDelete.ItemClick
        If bsProductFulfillment.Count <= 0 Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete the selected Product Fulfillment?", MsgBoxStyle.YesNo, "Delete Product Fulfillment - Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If


        Try
            deleteProductRelabelInstructionsByFulfillmentPlanID(bsProductFulfillment.Current.FULFILLMENTPLANID)

            ' Delete the product fulfilment plan based on the selected row in the Grid
            Dim oProductfulfillmentplan As New Productfulfillmentplan
            If oProductfulfillmentplan.LoadByPrimaryKey(bsProductFulfillment.Current.FULFILLMENTPLANID) Then
                Dim productId As Integer = oProductfulfillmentplan.Productid
                'do not allow to delete priority 1 until its the last fulfilmentplan record
                If oProductfulfillmentplan.Priority = 1 Then
                    Dim productPlans As New ProductfulfillmentplanCollection
                    productPlans.Query.Where(productPlans.Query.Productid = productId And productPlans.Query.Fulfillmentplanid <> oProductfulfillmentplan.Fulfillmentplanid)
                    If productPlans.Query.Load() AndAlso productPlans.Count > 0 Then
                        MsgBox("Product fulfillment plan with priority 1 - INV must exist.", MsgBoxStyle.Critical, "Delete Product Fulfillment - Error")
                        Exit Sub
                    End If
                End If
                oProductfulfillmentplan.MarkAsDeleted()
                oProductfulfillmentplan.Save()
                MsgBox("Record successfully deleted", MsgBoxStyle.Information, "Delete Product Fulfillment - Success")

                'frmAddEditProductFulfillment.SetProductFulfilmentPlanOne(productId)
                SetProductStatndardCosts(productId, "FulFillment Plan Change - ProdId " & productId & "[Delete]")

            Else
                MsgBox("Could not delete selected product fulfilment plan", MsgBoxStyle.Critical, "Delete Product Fulfillment - Error")
            End If
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Delete Product Fulfillment - Error")
        End Try


        refreshProductFulfillment()

    End Sub

    Private Sub btnProductFulfillmentAdd_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProductFulfillmentAdd.ItemClick
        bsProductFulfillment.EndEdit()
        Using frm As New frmAddEditProductFulfillment() With
            {
                .vEditType = "ADD",
                .oProduct = oProduct
            }
            frm.ShowDialog()
        End Using
        refreshProductFulfillment()
    End Sub

    Private Sub btnRelabelInstructions_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRelabelInstructions.ItemClick
        If bsProductFulfillment.Count <= 0 Then
            Exit Sub
        End If
        Using frm As New frmProductRelabelInstruction() With
           {
               .vFulfillmentPlanID = bsProductFulfillment.Current.Fulfillmentplanid
           }
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub viewProductFulfillment_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles viewProductFulfillment.FocusedRowChanged
        enableRelabelInstruction()
    End Sub

    Private Sub enableRelabelInstruction()
        btnRelabelInstructions.Enabled = IIf((bsProductFulfillment.Count > 0 AndAlso
                                             bsProductFulfillment.Current.Fulfillmenttype = FulfillmentType.RLBL.ToString()) _
                                             , True, False)
    End Sub


End Class