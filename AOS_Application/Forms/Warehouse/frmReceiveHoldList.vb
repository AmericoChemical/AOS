Imports AOS.BusinessObjects

Public Class frmReceiveHoldList
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'here is where you dimension your object variables for the form
    Dim oItems As ViewReceivedHoldItemsCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        oItems = New ViewReceivedHoldItemsCollection
        oItems.Query.Where(oItems.Query.Itemstatus.Equal("RCVDHOLD"), oItems.Query.Holdrelease.IsNull)
        oItems.Query.Load()
        bs.DataSource = oItems
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

        Me.DialogResult = Windows.Forms.DialogResult.Yes

    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub

    Private Sub rbtnReturnToPriorStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReturnToPriorStatus.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If

        Select Case bs.Current.PriorItemStatus 'pulling Prior Item Status from RECEIVEDHOLD record
            Case "TESTING"
                moveItemToPriorStatus(bs.Current.InvitemNumber, bs.Current.PriorItemStatus)
            Case Else
                If bsEvents.Count > 0 Then
                    moveItemToPriorStatus(bs.Current.InvitemNumber, bsEvents.Current.ItemStatus)
                End If
        End Select

        loadData()
    End Sub

    Private Sub moveItemToPriorStatus(vItemID As Integer, vPriorStatus As String)

        If MsgBox("Are you sure you want to move Item# " + vItemID.ToString + " to a " + vPriorStatus + " status?", MsgBoxStyle.YesNo, "CONFIRM - Status Change") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oItem As New Invitem
        If Not oItem.LoadByPrimaryKey(vItemID) Then
            MsgBox("Could not locate Inventory Item. Cannot update the record at this time. See system administrator.", MsgBoxStyle.Critical, "Error - Missing Item Data")
            Exit Sub
        End If

        Select Case vPriorStatus
            Case "PENDING"
                'Return Item to PENDING Status - reopen Purchase Order for Receiving if necessary
                Dim oPrchItem As New Purchaseitem
                If oPrchItem.LoadByPrimaryKey(oItem.Sourcedocument) Then
                    oPrchItem.Purchaseitemstatus = "ORDERED"
                    oPrchItem.Save()
                    Dim oPrch As New Purchase
                    If oPrch.LoadByPrimaryKey(oPrchItem.Purchasenumber) Then
                        oPrch.Purchasestatus = "ORDERED"
                        oPrch.Save()
                    End If
                End If
                oItem.Itemstatus = "PENDING"
                oItem.Save()
                Dim oRecvHold As New Receivedhold
                If oRecvHold.LoadByPrimaryKey(bs.Current.recvholdid) Then
                    oRecvHold.Resolutioncode = "PRIOR STATUS"
                    oRecvHold.Resolutiontext = "Moving Item to Prior Status"
                    oRecvHold.Holdrelease = Now
                    oRecvHold.Whoreleased = vCurrentUserLogin
                    oRecvHold.Save()
                End If
            Case "TESTING"
                'Check to see if there are more than one item linked to the record being moved by the same TestSampleKey
                If oItem.Testsamplekey > 0 Then
                    Dim oItems As New InvitemCollection
                    oItems.Query.Where(oItems.Query.Testsamplekey.Equal(oItem.Testsamplekey))
                    If oItems.Query.Load Then
                        For Each oRec As Invitem In oItems
                            oRec.Itemstatus = "TESTING"
                            oRec.Testsamplekey = Nothing
                            Dim oRecvHold As New ViewReceivedHoldItems  'use this object so we get only one record from RECEIVEDHOLD for the invitemnumber
                            oRecvHold.Query.Where(oRecvHold.Query.Invitemnumber.Equal(oRec.Invitemnumber))
                            If oRecvHold.Query.Load Then
                                Dim oHold As New Receivedhold
                                If oHold.LoadByPrimaryKey(oRecvHold.Recvholdid) Then
                                    oHold.Resolutioncode = "RETEST"
                                    oHold.Resolutiontext = "Retest"
                                    oHold.Holdrelease = Now
                                    oHold.Whoreleased = vCurrentUserLogin
                                    oHold.Save()
                                End If
                            End If
                        Next
                        oItems.Save()
                    End If
                Else
                    oItem.Itemstatus = "TESTING"
                    oItem.Testsamplekey = Nothing
                    oItem.Save()
                    Dim oRecvHold As New Receivedhold
                    If oRecvHold.LoadByPrimaryKey(bs.Current.recvholdid) Then
                        oRecvHold.Resolutioncode = "RETEST"
                        oRecvHold.Resolutiontext = "Retest"
                        oRecvHold.Holdrelease = Now
                        oRecvHold.Whoreleased = vCurrentUserLogin
                        oRecvHold.Save()
                    End If
                End If

            Case Else
                MsgBox("Cannot move to a prior status.", MsgBoxStyle.Critical, "Error - No prior status")
        End Select

    End Sub

    Private Sub rbtnReceivedToInventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReceivedToInventory.ItemClick

        If bs.Count <= 0 Then
            Exit Sub
        End If

        receiveItem(bs.Current.InvitemNumber, bs.Current.PriorItemStatus)
        loadData()


    End Sub

    Private Sub receiveItem(vItemID As Integer, vPriorStatus As String)
        If MsgBox("Are you sure you want to Receive the selected Item?", MsgBoxStyle.YesNo, "CONFIRM - Status Change") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim vReason As String = getUserString("Enter Reason for Receiving this Item to Inventory")
        If IsDBNull(vReason) OrElse vReason = Nothing Then
            MsgBox("You must enter a reason for Receiving the item to inventory.", MsgBoxStyle.Critical, "Error - Missing Reason")
            Exit Sub
        End If

        Dim oItem As New Invitem
        If Not oItem.LoadByPrimaryKey(vItemID) Then
            MsgBox("Could not locate Inventory Item. Cannot update the record at this time. See system administrator.", MsgBoxStyle.Critical, "Error - Missing Item Data")
            Exit Sub
        End If

        Select Case vPriorStatus
            Case "PENDING"
                receiveRCVDHOLDItemIntoTesting(vItemID)
            Case "TESTING"
                'Move past TESTING phase - InventoryItemsProcessing Module - UpdateInventory
                updateInventory(vItemID)
            Case Else
                If MsgBox("Does this item require TESTING?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                    receiveRCVDHOLDItemIntoTesting(vItemID)
                Else
                    'Move past TESTING phase - InventoryItemsProcessing Module - UpdateInventory
                    updateInventory(vItemID)
                End If
        End Select

        Dim oRcv As New Receivedhold
        If oRcv.LoadByPrimaryKey(bs.Current.RecvHoldID) Then
            oRcv.Holdrelease = Now
            oRcv.Whoreleased = vCurrentUserLogin
            oRcv.Resolutioncode = "RECEIVED"
            oRcv.Resolutiontext = vReason
            oRcv.Save()
        End If


    End Sub

    Private Sub rbtnChangeItemStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangeItemStatus.ItemClick
        If MsgBox("Are you sure you want to manually change the selected Inventory Item's Current Status?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim frm As New frmChangeInventoryItemStatus
        frm.vItemNum = bs.Current.InvItemnumber
        frm.ShowDialog()

        'if Item status code has now changed, then we need to update the RCVDHOLD record
        Dim oItem As New Invitem
        oItem.LoadByPrimaryKey(bs.Current.InvItemNumber)
        If oItem.Itemstatus <> "RCVDHOLD" Then
            'user changed the status manually - clear the RCVDHOLD record
            Dim oRec As New Receivedhold
            oRec.LoadByPrimaryKey(bs.Current.RecvHoldID)
            oRec.Resolutioncode = "MANUAL STATUS CHANGE"
            oRec.Resolutiontext = getUserString("Enter reason for ending RECEIVED / HOLD status on this item:")
            oRec.Holdrelease = Now
            oRec.Whoreleased = vCurrentUserLogin
            oRec.Save()
        End If

        loadData()

    End Sub

    Private Sub bs_CurrentChanged(sender As Object, e As EventArgs) Handles bs.CurrentChanged
        If bs.Count <= 0 Then
            Exit Sub
        End If

        getEvents(bs.Current.Invitemnumber)

    End Sub

    Private Sub getEvents(vItemID As Integer)

        Dim oEvents As New ReceivingeventCollection
        oEvents.Query.Where(oEvents.Query.InvItemNumber.Equal(vItemID))
        oEvents.Query.Load()
        bsEvents.DataSource = oEvents

    End Sub

    Private Sub rbtnResolveItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnResolveItem.ItemClick
        If MsgBox("Are you sure you want to remove the selected Inventory Item from Received Hold status?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim frm As New frmChangeInventoryItemStatus
        frm.vItemNum = bs.Current.InvItemnumber
        frm.ShowDialog()

        'if Item status code has now changed, then we need to update the RCVDHOLD record
        Dim oItem As New Invitem
        oItem.LoadByPrimaryKey(bs.Current.InvItemNumber)
        If oItem.Itemstatus <> "RCVDHOLD" Then
            'user changed the status manually - clear the RCVDHOLD record
            Dim oRec As New Receivedhold
            oRec.LoadByPrimaryKey(bs.Current.RecvHoldID)
            oRec.Resolutioncode = "MANUAL STATUS CHANGE"
            oRec.Resolutiontext = getUserString("Enter reason for ending RECEIVED / HOLD status on this item:")
            oRec.Holdrelease = Now
            oRec.Whoreleased = vCurrentUserLogin
            oRec.Save()
        End If

        loadData()

    End Sub
End Class