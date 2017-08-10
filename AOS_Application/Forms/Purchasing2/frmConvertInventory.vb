Imports AOS.BusinessObjects

Public Class frmConvertInventory
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vIDs As List(Of Integer)
    Dim oInvitems As List(Of Invitem)

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()
    End Sub

    Private Sub loadData()
        If bsInventoryClass Is Nothing OrElse _
            bsInventoryClass.Count <= 0 Then
            Exit Sub
        End If

        If vIDs Is Nothing OrElse _
            vIDs.Count <= 0 Then
            Exit Sub
        End If

        oInvitems = New List(Of Invitem)
        Dim oInvitem As Invitem
        For Each vID As Integer In vIDs
            oInvitem = New Invitem
            If (oInvitem.LoadByPrimaryKey(vID)) Then
                oInvitems.Add(oInvitem)
            Else
                MessageBox.Show("Some of the inventory item numbers do not exist, please select the inventory items on previous screen and try again")
                Me.DialogResult = Windows.Forms.DialogResult.No
            End If
        Next
    End Sub

    Private Sub loadLookupTables()
        Dim oInventoryclassCollection As New ListInventoryclassCollection
        oInventoryclassCollection.LoadAll()
        Me.bsInventoryClass.DataSource = oInventoryclassCollection
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Function changesSaved() As Boolean
        If ValidateControls() Then
            For Each oInvitem As Invitem In oInvitems
                'oInvitem.Inventoryclass = InventoryClassLookUpEdit.EditValue
                'oInvitem.Save()
                updateInventoryClassAndStatus(oInvitem.Invitemnumber, InventoryClassLookUpEdit.EditValue, "")
            Next
            Return True
        Else
            MsgBox("Due to insufficient available inventory this change is not allowed.", MsgBoxStyle.Critical, "Edit Failed")
            Exit Function
        End If
    End Function

    Private Function ValidateControls() As Boolean
        For Each oInvitem As Invitem In oInvitems
            If (checkInventoryAvailable(oInvitem.Productid, 0, oInvitem.Unitsremaining) = False) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        changesCancelled()
    End Sub

    Private Function changesCancelled() As Boolean
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Function

End Class