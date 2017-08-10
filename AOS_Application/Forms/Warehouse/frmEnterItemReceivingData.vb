Imports AOS.BusinessObjects

Public Class frmEnterItemReceivingData
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vItemID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vResult As String
    Public vLotNumber As String
    Public vContainerWeight As Integer

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = ""

    'here is where you dimension your object variables for the form
    Dim oItem As Invitem
    Dim oProduct As Product


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        editObject(vItemID)
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Invitem
        oItem.LoadByPrimaryKey(vID)
        If oItem.Lotnumber = Nothing Then
            oItem.Lotnumber = vLotNumber
        End If
        Me.bs.DataSource = oItem
        getProductdata(oItem.Productid)
    End Sub

    Private Sub getProductData(vProdID As Integer)
        oProduct = New Product
        If Not oProduct.LoadByPrimaryKey(vProdID) Then
            MsgBox("Error retrieving Product information. See System Administrator", MsgBoxStyle.Critical, "ERROR - Missing Data")
            vResult = "RETRY"
            Me.DialogResult = DialogResult.Abort
        End If
        eProductDesc.EditValue = oProduct.Productdesc
        eContainer.EditValue = oProduct.Container
        eReceivingNotes.EditValue = oProduct.Receivingnotes
    End Sub

    Private Function validateData() As Integer
        If IsDBNull(eLotNumber.EditValue) OrElse eLotNumber.EditValue = Nothing Then
            MsgBox("You must enter a Lot Number to continue", MsgBoxStyle.Critical, "Error - Missing Lot Number")
            Return 0
        End If
        If IsDBNull(eLabelWeight.EditValue) OrElse eLabelWeight.EditValue = Nothing Then
            MsgBox("You must enter a Label Weight to continue", MsgBoxStyle.Critical, "Error - Missing Label Weight")
            Return 0
        End If
        If eLabelWeight.EditValue <= 0 Then
            MsgBox("You must enter a Label Weight that is greater than zero to continue", MsgBoxStyle.Critical, "Error - Incorrect Label Weight")
            Return 0
        End If

        'check to see if Label Weight entered matches the Product Std Weight value in the AOS system. If yes, the item passes, if not, it fails
        If eLabelWeight.EditValue = oProduct.Stdweight Then
            'Item Passes Test
            Return 1
        Else
            'Item Fails Test
            If MsgBox("The Label Weight entered does not match the Product Label Weight in the system. If you continue, this item will be marked for RECEIVED HOLD status. Do you want to continue with the entered Vendor Label Weight?", MsgBoxStyle.YesNo, "Validation Failed") = MsgBoxResult.Yes Then
                Return 2
            Else
                Return 0
            End If
        End If

    End Function

    Private Function changesSaved() As Boolean
        Try
            bs.EndEdit()
            oItem.EndEdit()
            oItem.Save()
            Select Case validateData()
                Case 0
                    Return False
                Case 1
                    'update inventory item as RECEIVED - move it into TESTING status
                    receivePurchaseItem(oItem.Invitemnumber, oItem.Lotnumber, oItem.Vendorweight)
                    Return True
                Case 2
                    'update inventory item as RECEIVED HOLD - Vendor Label Data incorrect
                    updateInvItemRcvdWeightAndStatus(oItem.Invitemnumber, vContainerWeight, oItem.Lotnumber, oItem.Vendorweight, InventoryItemStatus.RCVDHOLD.ToString(), "DOCK-LABEL WEIGHT", "Vendor Label Weight =" + eLabelWeight.EditValue.ToString)
                    Return True
                Case Else
                    Return False
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bs.CancelEdit()
            oItem.CancelEdit()
            vResult = "RETRY"
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