Module ReceivingProcessing

    Public Function verifyReceivingData(vEntryType As String, vInvitemnumber As Integer, vContainer As String, vPallet As String, vLabelWeight As Decimal, vScaleWeight As Decimal, vLotNumber As String, vSource As String) As Integer
        'Get Inventory Item record
        Dim oItem As New Invitem
        If Not oItem.LoadByPrimaryKey(vInvitemnumber) Then
            MsgBox("Could not locate Inventory Item record", MsgBoxStyle.Critical, "Error")
            Return 2
        End If

        'create Receiving Event Record to record Receiving data
        Dim oEvent As New Receivingevent
        oEvent.EventTime = Now
        oEvent.EventWho = vCurrentUserLogin
        oEvent.EventType = vEntryType
        oEvent.InvItemNumber = oItem.Invitemnumber
        oEvent.ItemStatus = oItem.Itemstatus
        oEvent.LabelWeight = vLabelWeight
        oEvent.ScaleWeight = vScaleWeight
        oEvent.LotNumber = vLotNumber
        oEvent.Container = vContainer
        oEvent.Pallet = vPallet
        oEvent.Isautoflag = False
        oEvent.Save()


        Dim oProduct As New Product
        Dim oSysparameters As New Sysparameters
        If oProduct.LoadByPrimaryKey(oItem.Productid) = False Then
            MsgBox("Could not locate Product record", MsgBoxStyle.Critical, "Error")
            Return 2
        End If
        If oSysparameters.LoadByPrimaryKey(1) = False Then
            MsgBox("Could not locate System Parameters record", MsgBoxStyle.Critical, "Error")
            Return 2
        End If

        'check to see if Inventory Item Vendor Label Weight matches the Product Label (Standard) Weight value
        If vLabelWeight <> oProduct.Stdweight Then
            oEvent.FailedLabelWeight = 1
        Else
            oEvent.FailedLabelWeight = 0
        End If

        If Not oProduct.Chemicalid Is Nothing Then
            Dim oChemical As New Chemical
            If oChemical.LoadByPrimaryKey(oProduct.Chemicalid) Then
                oEvent.Isautoflag = oChemical.Isautoflag
            End If
        End If

        'Gather weights of Container and Pallet user choices
        Dim oContainer As New ListContainertype
        oContainer.Query.Where(oContainer.Query.Containertype.Equal(vContainer))
        If Not oContainer.Query.Load Then
            MsgBox("Could not locate Container Type record", MsgBoxStyle.Critical, "Error")
            Return 2
        End If
        Dim oPallet As New ListPallettype
        oPallet.Query.Where(oPallet.Query.Pallettype.Equal(vPallet))
        If Not oPallet.Query.Load Then
            MsgBox("Could not locate Pallet Type record", MsgBoxStyle.Critical, "Error")
            Return 2
        End If

        'Determine Weight Min and Max for product
        Dim vMaxWeight As Decimal = oProduct.Stdweight + (oProduct.Stdweight * (oSysparameters.AllowableWeightVariancePercentage / 100))
        Dim vMinWeight As Decimal = oProduct.Stdweight - (oProduct.Stdweight * (oSysparameters.AllowableWeightVariancePercentage / 100))

        'Determine Material Weight of Product received
        Dim vMaterialWeight As Decimal
        Select Case vSource
            Case "SINGLE"
                vMaterialWeight = vScaleWeight - oPallet.Palletweight - oContainer.Tareweight
            Case "MULTIPLE"
                'We only remove the container tare weight - the pallet weight was removed after multiple Items were weighed on the scale
                vMaterialWeight = vScaleWeight - oContainer.Tareweight
            Case "MISC"
                'We only remove the container tare weight - the pallet weight was removed after multiple Items were weighed on the scale
                vMaterialWeight = vScaleWeight - oContainer.Tareweight
        End Select

        'Check to see if Material Weight is within the acceptable variance parameters.
        If vMaterialWeight < vMinWeight Or vMaterialWeight > vMaxWeight Then
            oEvent.FailedMaterialWeight = 1
        Else
            oEvent.FailedMaterialWeight = 0
        End If

        oEvent.Save()

        If vSource = "MISC" Then
            updateInventoryItemData(oItem.Invitemnumber, "RCVDHOLD", vMaterialWeight, vLotNumber)
            addNewReceivedHoldRecord(oItem.Invitemnumber, "MISC RECV", "Miscellaneous Items - see Event details", oEvent.EventID, False)
            'Print Inventory Item tag/small barcode label
            prepareMiniBarcodeLabelForInventoryItem(oItem.Invitemnumber)
            Return 0
        Else
            If oEvent.FailedLabelWeight = True Or oEvent.FailedMaterialWeight = True Or oEvent.Isautoflag Then
                'put item in RECEIVED/HOLD status and create RECEIVED/HOLD record
                updateInventoryItemData(oItem.Invitemnumber, "RCVDHOLD", vMaterialWeight, vLotNumber)
                If (oEvent.Isautoflag) Then
                    If (oEvent.FailedLabelWeight = True Or oEvent.FailedMaterialWeight = True) Then
                        addNewReceivedHoldRecord(oItem.Invitemnumber, "AUTO FLAG/WEIGHT ERROR", "Auto flag & Item Weights not within Product specifications", oEvent.EventID, False)
                    Else
                        addNewReceivedHoldRecord(oItem.Invitemnumber, "AUTO FLAG", "Auto Flag Item", oEvent.EventID, False)
                    End If
                Else
                    addNewReceivedHoldRecord(oItem.Invitemnumber, "WEIGHT ERROR", "Item Weights not within Product specifications", oEvent.EventID, False)
                End If
                'Print Inventory Item tag/small barcode label
                prepareMiniBarcodeLabelForInventoryItem(oItem.Invitemnumber)
                Return 0
            Else
                'approve the receipt of the item into inventory
                updateInventoryItemData(oItem.Invitemnumber, "TESTING", vMaterialWeight, vLotNumber)
                'Print Inventory Item tag/small barcode label
                prepareMiniBarcodeLabelForInventoryItem(oItem.Invitemnumber)
                Return 1
            End If
        End If


    End Function


    Private Function updateInventoryItemData(vInvItemNumber As Integer, vNewStatus As String, vMaterialWeight As Decimal, vLotNumber As String) As Boolean

        Dim oItem As New Invitem
        If Not oItem.LoadByPrimaryKey(vInvItemNumber) Then
            Return False
        End If

        oItem.Rcvdweight = vMaterialWeight
        oItem.Lotnumber = vLotNumber
        oItem.Itemstatus = vNewStatus
        oItem.Receiveddate = Now
        oItem.Warehouselocation = "DOCK"
        oItem.Warehousenumber = 1
        oItem.Save()

        Return True

    End Function

    Private Function addNewReceivedHoldRecord(vInvItemNum As Integer, vReasonCode As String, vReasonText As String, vEventID As String, vAskForReason As Boolean) As Boolean

        Dim vNewReasonText As String = ""
        If vAskForReason Then
            vNewReasonText = getUserString("Enter a reason for the item being placed ON HOLD:", vReasonText)
        Else
            vNewReasonText = vReasonText
        End If

        Dim oRcvdHold As New Receivedhold
        oRcvdHold.Invitemnumber = vInvItemNum
        oRcvdHold.Reasoncode = vReasonCode
        oRcvdHold.Reasontext = vNewReasonText
        oRcvdHold.Eventid = vEventID
        oRcvdHold.Holdtime = Now
        oRcvdHold.Save()

        Return True

    End Function

    Public Function updateReceivedPurchaseItem(vInvItemNumber As Integer) As Boolean

        Dim oInvitem As New Invitem
        If oInvitem.LoadByPrimaryKey(vInvItemNumber) = False Then
            Return False
        End If

        'If all the inventory items are received for the purchase item then update purchase item status as received.
        Dim oInvItems As InvitemCollection = getInventoryItems(oInvitem.Sourcedocument, SourceType.PRCH.ToString(), InventoryItemStatus.PENDING.ToString())
        If oInvItems Is Nothing OrElse
            oInvItems.Count = 0 Then
            updatePurchaseItemStatusAndExpectedDate(oInvitem.Sourcedocument)
            'If all the purchase items are received then update order ststus to COMPLETED
            closePurchaseOrderByPurchaseItemStatus(oInvitem.Sourcedocument)
        End If
        Return True
    End Function

End Module
