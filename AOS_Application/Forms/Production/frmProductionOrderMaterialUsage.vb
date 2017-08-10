Imports AOS.BusinessObjects

Public Class frmProductionOrderMaterialUsage

    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'PRODITEMNUM
    Dim oProdOrderMaterial As ViewMaterialUsageProdOrderInfo
    Dim oInvTxs As InvtxCollection
    Dim oInvItems As ViewMaterialUsageInventoryItemsCollection


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()

        oProdOrderMaterial = New ViewMaterialUsageProdOrderInfo
        oProdOrderMaterial.Query.Where(oProdOrderMaterial.Query.Proditemnum.Equal(vID))
        oProdOrderMaterial.Query.Load()
        bsProdMaterialInfo.DataSource = oProdOrderMaterial

        oInvItems = New ViewMaterialUsageInventoryItemsCollection
        oInvItems.Query.Where(oInvItems.Query.Proditemnum.Equal(vID), oInvItems.Query.Unitsremaining.GreaterThan(0.001))
        oInvItems.Query.Load()
        bsInProcessItems.DataSource = oInvItems

        oInvTxs = New InvtxCollection
        oInvTxs.Query.Where(oInvTxs.Query.Txdocid.Equal(vID), oInvTxs.Query.Txtype.Equal("ProdOrder"))
        oInvTxs.Query.Load()
        bsInvTx.DataSource = oInvTxs

        eQtyNeeded.EditValue = getMaterialNeedsRemaining(vID)


    End Sub

    Private Function getMaterialNeedsRemaining(vID) As Decimal

        If oInvTxs.Count = 0 Then
            If oProdOrderMaterial.Qty < 0.0001 Then
                Return 0
            Else
                Return oProdOrderMaterial.Qty
            End If
        End If

        Dim vUsed As Decimal = 0.0

        For Each oTx As Invtx In oInvTxs
            vUsed = vUsed + oTx.Unitsused
        Next

        Return oProdOrderMaterial.Qty - vUsed
    End Function


    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rbtnAddMaterialTransaction_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddMaterialTransaction.ItemClick
        If bsInProcessItems.Count <= 0 Then
            Exit Sub
        End If

        'get user input for number of units to pull from the selected INPROCESS inventory item
        Dim vQtyToUse As Decimal = 0.00
        Dim frm As New frmGetMaterialUsageAmount
        frm.vMaxContainer = bsInProcessItems.Current.UnitsRemaining
        frm.vMaxNeeded = eQtyNeeded.EditValue
        frm.vQtyUsed = 0.00
        Dim vResult As DialogResult = frm.ShowDialog
        If vResult = DialogResult.Cancel Then
            Exit Sub
        End If
        vQtyToUse = frm.vQtyUsed
        If vQtyToUse = 0.00 Then
            Exit Sub
        End If

        'Dim vQtyToUse As Decimal = 0.00
        'vQtyToUse = CDec(getUserString("Enter Qty of Units to Pull from Inventory Item:", vQtyToUse))
        'If vQtyToUse > bsInProcessItems.Current.UnitsRemaining Then
        '    MsgBox("You can't use more material than is available in the selected Inventory Item", MsgBoxStyle.Critical, "Error")
        '    Exit Sub
        'End If
        'If vQtyToUse > eQtyNeeded.EditValue Then
        '    MsgBox("You can't use more material than is needed to complete the production order.", MsgBoxStyle.Critical, "Error")
        '    Exit Sub
        'End If

        'we now have a legitimate qty to work with
        Dim oInv As New Invitem
        If Not oInv.LoadByPrimaryKey(bsInProcessItems.Current.InvItemnumber) Then
            MsgBox("Error in retrieving Inventory Item", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        'adjust item's qty remaining
        oInv.Unitsremaining = oInv.Unitsremaining - vQtyToUse
        oInv.Save()
        If oInv.Unitsremaining < 0.0001 Then
            oInv.Unitsremaining = 0
            oInv.Itemstatus = "DEPLETED"
            oInv.Save()
        End If

        'now add InvTx record
        Dim oTx As New Invtx
        oTx.Txtime = Now
        oTx.Txwho = vCurrentUserLogin
        oTx.Txtype = "PRODORDER"
        oTx.Txdocid = vID
        oTx.Invitemnumber = bsInProcessItems.Current.InvItemnumber
        oTx.Unitsused = vQtyToUse
        oTx.Save()

        verifyProdItemData()


    End Sub

    Private Sub verifyProditemData()

        loadData()
        If eQtyNeeded.EditValue = 0 Then
            If Not oProdOrderMaterial.Iscomplete Then
                Dim oProdItem As New Proditem
                oProdItem.LoadByPrimaryKey(vID)
                oProdItem.Iscomplete = True
                oProdItem.Save()
            End If
        End If

        verifyProdOrderData(oProdOrderMaterial.Prodordernum)

        loadData()
    End Sub

    Private Sub verifyprodorderdata(vOrdnum)

        Dim oProdorder As New Prodorder
        oProdorder.LoadByPrimaryKey(vOrdnum)

        Dim oProdItems As New ProditemCollection
        oProdItems.Query.Where(oProdItems.Query.Prodordernum.Equal(vOrdnum), oProdItems.Query.Iscomplete.Equal(False))
        oProdItems.Query.Load()
        If oProdItems.Count <= 0 Then
            'all prod items have been completed and we can close out the production order
            oProdorder.Iscomplete = True
            oProdorder.Orderstatus = "COMPLETED"
            oProdorder.Save()
            'now we update status of all inventory items that have been created
            markProductionOrderInventoryItemsAsCompleted(vOrdnum)
        End If



    End Sub

    Private Sub markProductionOrderInventoryItemsAsCompleted(vOrdnum As Integer)
        'now that the Production Order has been marked as completed, we need to update the status of the inventory items
        'that are sourced to the production order to TESTING status
        Dim oItems As New InvitemCollection
        oItems.Query.Where(oItems.Query.Sourcetype.Equal("PORD"), oItems.Query.Sourcedocument.Equal(vOrdnum))
        If oItems.Query.Load() Then
            For Each oItem As Invitem In oItems
                oItem.Itemstatus = "TESTING"
                prepareMiniBarcodeLabelForInventoryItem(oItem.Invitemnumber)
            Next
            oItems.Save()
        Else
            MsgBox("No Inventory Items found sourced to this Production Order", MsgBoxStyle.Information, "Error")
        End If

    End Sub

    Private Sub rbtnReverseMaterialTransaction_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReverseMaterialTransaction.ItemClick
        MsgBox("This function has not been implemented at this time. See System Administrator for assistance.", MsgBoxStyle.Critical, "WARNING")
    End Sub
End Class