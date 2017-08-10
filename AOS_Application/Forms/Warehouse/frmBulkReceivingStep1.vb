Imports AOS.BusinessObjects

Public Class frmBulkReceivingStep1
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vInvItemID As Integer

    Dim vComplete As Boolean = True
    Dim oInvItem As Invitem
    Dim oPrchItem As Purchaseitem
    Dim oProduct As Product
    Dim oPurchase As Purchase
    Dim oVendor As Vendor

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub
    Private Sub loadData()

        oInvItem = New Invitem
        oInvItem.LoadByPrimaryKey(vInvItemID)

        If oInvItem.Sourcetype = "PRCH" Then
            oPrchItem = New Purchaseitem
            oPrchItem.LoadByPrimaryKey(oInvItem.Sourcedocument)

            oPurchase = New Purchase
            oPurchase.LoadByPrimaryKey(oPrchItem.Purchasenumber)

            oVendor = New Vendor
            oVendor.LoadByPrimaryKey(oPurchase.Vendorid)

            ePONumber.EditValue = oPurchase.Purchasenumber
            eVendorName.EditValue = oVendor.Vendorname

        End If

        oProduct = New Product
        oProduct.LoadByPrimaryKey(oInvItem.Productid)

        Select Case oProduct.Inventorymethod
            Case "VOLUME"
                eUOM.EditValue = oProduct.Volumeuom
            Case "WEIGHT"
                eUOM.EditValue = oProduct.Weightuom
            Case Else
                eUOM.EditValue = "EA"
        End Select

        eProductID.EditValue = oProduct.Productid
        eProductDescription.EditValue = oProduct.Productdesc

    End Sub

    Private Sub btnNext_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick

        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Function changesSaved() As Boolean
        If ValidateControls() Then
            Dim vReturn As DialogResult
            Dim vContinue As Boolean = True
            Dim x As Integer = 1
            'iterate through a the Lot Number count
            For x = 1 To ePalletCount.EditValue
                If vContinue Then
                    Dim frm As New frmBulkReceivingStep2
                    frm.eLocation.EditValue = "E18"
                    frm.ePONumber.EditValue = ePONumber.EditValue
                    frm.eVendorName.EditValue = eVendorName.EditValue
                    frm.eProductID.EditValue = eProductID.EditValue
                    frm.eProductDescription.EditValue = eProductDescription.EditValue
                    frm.eUOM.EditValue = eUOM.EditValue
                    frm.vPalletCount = x
                    frm.vOriginalInvItemID = vInvItemID
                    vReturn = frm.ShowDialog()
                    If vReturn = DialogResult.Cancel Then
                        vContinue = False
                    End If
                End If
            Next
            If vContinue = False Then
                Return False
            End If
            Return True
        End If
    End Function
    Private Function ValidateControls() As Boolean
        If IsDBNull(ePalletCount.EditValue) Or ePalletCount.EditValue < 1 Then
            MsgBox("You must enter a Lot Number counter greater than zero", MsgBoxStyle.Critical, "Error - Missing Data")
            Return False
        End If

        If IsDBNull(eTotalQtyReceived.EditValue) Or eTotalQtyReceived.EditValue < 1 Then
            MsgBox("You must enter a Total Material Weight greater than zero", MsgBoxStyle.Critical, "Error - Missing Data")
            Return False
        End If

        Return True
    End Function

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        changesCancelled()
    End Sub
    Private Function changesCancelled() As Boolean
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Function
End Class