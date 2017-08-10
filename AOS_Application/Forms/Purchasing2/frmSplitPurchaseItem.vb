Imports AOS.BusinessObjects
Imports System.Text

Public Class frmSplitPurchaseItem
    Inherits DevExpress.XtraEditors.XtraForm


    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.

        InitializeComponent()
        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer 'object primary key (passed in by calling form for edit mode)   

    Dim oOrignalPurchaseItem As Purchaseitem

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        addNewObject(vID)
    End Sub

    Private Sub addNewObject(vID)
        oOrignalPurchaseItem = New Purchaseitem

        oOrignalPurchaseItem.LoadByPrimaryKey(vID)
        qtyInfoLabel.Text = String.Format("You are splitting a purchase item with a quantity of {0}. " & _
                "How many items do you want to split into a separate purchase item? (Cannot be more than {1}).", _
                Format(oOrignalPurchaseItem.Qty, "0"), Format((oOrignalPurchaseItem.Qty - 1), "0"))

    End Sub

    Private Function changesSaved() As Boolean
        Return splitPurchaseItem(oOrignalPurchaseItem.Purchaseitemid, Convert.ToInt32(eQty.Text)) 
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick
        If ValidateControls() Then
            If changesSaved() Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function ValidateControls() As Boolean

        If Val(Me.eQty.Text) = 0 Then
            MsgBox("Qty Containers is required. ", MsgBoxStyle.Information, "Split Purchase Item - Error")
            Return False
        End If

        If oOrignalPurchaseItem.Qty <= Convert.ToInt32(eQty.Text) Or Convert.ToInt32(eQty.Text) <= 0 Then
            MsgBox(String.Format("Quantity Containers should be less than or equal to {0}", Format((oOrignalPurchaseItem.Qty - 1), "0")), MsgBoxStyle.Information, "Split Purchase Item - Error")
            Return False
        End If

        Return True
    End Function
End Class