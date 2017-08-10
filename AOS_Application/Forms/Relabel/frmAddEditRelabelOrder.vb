Imports AOS.BusinessObjects

Public Class frmAddEditRelabelOrder
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vRelabelOrderNumber As Integer
    Public vEditType As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Relabel Order"

    Dim oRelabelorder As Relabelorder

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Select Case vEditType
            Case "EDIT"
                Me.Text = "Editing " & vObjectName & " Information"
                NeededbyDateEdit.Enabled = True
            Case "READONLY"
                Me.Text = vObjectName & " Information"
                setScreenObjects()
        End Select
    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If Not loadLookupData() Then
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End If
        loadData()
        refershForm()

        If bsInvItems.Count > 0 AndAlso _
            oRelabelorder.Relabelorderstatus <> RelabelOrderStatus.COMPLETED.ToString() AndAlso _
            oRelabelorder.Relabelorderstatus <> RelabelOrderStatus.CANCELLED.ToString() Then
            btnChangeInventoryClass.Enabled = IIf(vEditType = "READONLY", False, True)
        End If
    End Sub

    Private Sub setScreenObjects()
        Select Case vEditType
            Case "READONLY"
                btnSave.Enabled = False
                btnChangeInventoryClass.Enabled = False
        End Select
    End Sub

    Private Sub loadData()
        editObject(vRelabelOrderNumber)
    End Sub

    Private Sub editObject(ByVal vRelabelOrderNumber As Integer)
        If vRelabelOrderNumber = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oRelabelorder = New Relabelorder()
        oRelabelorder.LoadByPrimaryKey(vRelabelOrderNumber)
        bsRelabelOrder.DataSource = oRelabelorder
        loadProduct()
    End Sub

    Private Sub loadProduct()
        If IsDBNull(eProductID.EditValue) Then
            Exit Sub
        End If
        eProductID.Refresh()

        Dim vProductID As Integer = eProductID.EditValue
        Dim oProd As New Product
        oProd.LoadByPrimaryKey(vProductID)
        eProdDesc.EditValue = oProd.Productdesc
        eContainer.EditValue = oProd.Container
    End Sub

    Private Function loadLookupData() As Boolean
        Try
            Dim oRelabelOrderProducts As New ViewRelabelOrderProductCollection
            oRelabelOrderProducts = getRelabelOrderProducts()
            'restrict product list to only products for which there are fulfillment plan for RLBL         
            If oRelabelOrderProducts Is Nothing OrElse _
                oRelabelOrderProducts.Count <= 0 Then
                MsgBox("Products are not available.")
                Return False
            End If
            bsProducts.DataSource = oRelabelOrderProducts
        Catch ex As Exception
            MsgBox("Error retrieving Product information", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Dim oCustomerList As New CustomerCollection
        Try
            oCustomerList.LoadAll()
            oCustomerList.Sort = "CustName"
            bsCustomers.DataSource = oCustomerList
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error retrieving Customer data", MsgBoxStyle.Critical, "Error")
        End Try
        Return True
    End Function

    Private Function changesSaved() As Boolean
        Try
            bsRelabelOrder.EndEdit()
            oRelabelorder.EndEdit()
            oRelabelorder.Save()

            updateRelabelSourceDocDateNeeded(oRelabelorder.Relabelordernumber, oRelabelorder.Neededby)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsRelabelOrder.CancelEdit()
            oRelabelorder.CancelEdit()
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


    Private Sub btnChangeInventoryClass_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnChangeInventoryClass.ItemClick
        If (bsInvItems Is Nothing) Then
            Exit Sub
        End If

        If bsInvItems.Current.Invitemnumber Is Nothing Then
            Exit Sub
        End If

        If bsInvItems.Current.Itemstatus = InventoryItemStatus.RECEIVED.ToString() Then
            MsgBox("You cannot change the inventory class of selected inventory items because one or more selected inventory items are already received.", _
                      vbCritical, _
                      "Error")
            Exit Sub
        End If

        Dim vIDs As New List(Of Integer)
        vIDs.Add(bsInvItems.Current.Invitemnumber)
        Using frm As New frmConvertInventory() With
             {
                   .vIDs = vIDs
             }
            frm.ShowDialog()
        End Using
        loadInventoryItems()
    End Sub

    Private Sub loadRelabelOrderItems()
        If Not bsRelabelOrder.Current.Relabelordernumber Is Nothing Then
            bsRelabelOrderItems.DataSource = getViewRelabelOrderItems(bsRelabelOrder.Current.Relabelordernumber)
        End If
    End Sub

    Private Sub loadInventoryItems()
        If Not bsRelabelOrder.Current.Relabelordernumber Is Nothing Then
            bsInvItems.DataSource = getInvItemsByAllocatedDoc(bsRelabelOrder.Current.Relabelordernumber, AllocatedType.RELABEL.ToString())
        End If
    End Sub

    Private Sub refershForm()
        loadRelabelOrderItems()
        loadInventoryItems()
    End Sub

    Private Sub rbtnEditWorkOrder_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditWorkOrder.ItemClick
        If IsDBNull(oRelabelorder.Workordernumber) Then
            Exit Sub
        End If

        If oRelabelorder.Workordernumber > 0 Then
            Dim frm As New frmAddEditWorkOrders
            frm.vWorkorderNum = oRelabelorder.Workordernumber
            frm.vEditType = "EDIT"
            frm.ShowDialog()
        End If
        loadData()
    End Sub
End Class