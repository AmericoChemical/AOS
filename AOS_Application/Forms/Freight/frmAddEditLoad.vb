
Imports AOS.BusinessObjects
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls

Public Class frmAddEditLoad
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vLoadID As Integer   'ShipmentNumber passed from calling form for edit and review of shipment
    Public vEditType As String      'ADD or EDIT option

    Dim oLoad As Load
    Dim oLoadItems As ViewLoadItemsDisplayCollection
    Dim oCustomers As CustomerCollection
    Dim oShipFromList As CustomerCollection
    Dim oShipToList As CustomerCollection
    Dim oCarriers As CarrierCollection
    Dim oLogistics As LogisticsCollection
    Dim oFOB As ListFobCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getCustomers()
        getShipFromList()
        getShipToList()
        getCarriers()
        getLogistics()
        getFOB()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vLoadID)
        End If
    End Sub

    Private Sub addNewObject()
        oLoad = New Load
        oLoad.AddNew()
        oLoad.PlannedDepartureDate = Today
        oLoad.LoadStatus = "PENDING"
        oLoad.Save()
        vLoadID = oLoad.LoadID.Value
        editObject(vLoadID)
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oLoad = New Load
        If Not oLoad.LoadByPrimaryKey(vID) Then
            MsgBox("Could not retrieve selected Shipment data from the database", MsgBoxStyle.Critical, "Error")
            Me.Close()
        End If
        bsLoad.DataSource = oLoad
        txtTotalSkids.Text = IIf(oLoad.TotalSkids.HasValue, oLoad.TotalSkids, 0)
        getLoadItems(vID)
    End Sub

    Private Sub getLoadItems(ByVal vID As Integer)
        oLoadItems = New ViewLoadItemsDisplayCollection
        oLoadItems.Query.Where(oLoadItems.Query.LoadID.Equal(vID))
        oLoadItems.Query.Load()
        Try
            bsLoadItems.DataSource = oLoadItems
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getFOB()
        oFOB = New ListFobCollection
        oFOB.LoadAll()
        bsFOB.DataSource = oFOB
    End Sub

    Private Sub getCustomers()
        oCustomers = New CustomerCollection
        oCustomers.LoadAll()
        oCustomers.Sort = "CUSTNAME"
        bsCustomers.DataSource = oCustomers
    End Sub

    Private Sub getShipFromList()
        oShipFromList = New CustomerCollection
        oShipFromList.LoadAll()
        oShipFromList.Sort = "CUSTNAME"
        bsLoadOrigin.DataSource = oShipFromList
    End Sub

    Private Sub getShipToList()
        oShipToList = New CustomerCollection
        oShipToList.LoadAll()
        oShipToList.Sort = "CUSTNAME"
        bsLoadDestination.DataSource = oShipToList
    End Sub

    Private Sub getCarriers()
        oCarriers = New CarrierCollection
        oCarriers.LoadAll()
        oCarriers.Sort = "CARRIERNAME"
        bsCarriers.DataSource = oCarriers
    End Sub

    Private Sub getLogistics()
        oLogistics = New LogisticsCollection
        oLogistics.LoadAll()
        oLogistics.Sort = "LogisticsNAME"
        bsLogistics.DataSource = oLogistics
    End Sub

    Private Sub saveDataChanges()
        bsLoad.EndEdit()
        bsLoadItems.EndEdit()
        oLoad.EndEdit()
        oLoad.Save()
        oLoadItems.Save()
    End Sub

    Private Sub saveChanges()
        bsLoad.EndEdit()
        If bsLoadItems.Count <= 0 Then
            MsgBox("You must enter at least one Load Item to save the Load", MsgBoxStyle.Critical, "Error - No items")
            Exit Sub
        End If
        oLoad.TotalSkids = txtTotalSkids.Text
        oLoad.Save()
        oLoadItems.Save()
        updateWorkOrderFromLoadInfo(oLoad.LoadID, "LOAD UPDATE")

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cancelChanges()
        oLoad.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oLoad.MarkAsDeleted()
                oLoad.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub addLoadItem()
        'get the itemtype that you want to add to the load
        Dim vItemType As String = Nothing
        Dim frmType As New frmGetItemType
        frmType.ShowDialog()
        vItemType = frmType.vItemType

        Select Case vItemType
            Case "PRODUCT"
                Dim frm As New frmAddEditLoadItemProduct
                frm.vEditType = "ADD"
                frm.vLoadID = bsLoad.Current.LoadID
                frm.ShowDialog()
            Case "MISC"
                Dim frm As New frmAddEditLoadItemMisc
                frm.vEditType = "ADD"
                frm.vLoadID = bsLoad.Current.LoadID
                frm.ShowDialog()
            Case "SAMPLE"
                Dim frm As New frmAddEditLoadItemSample
                frm.vEditType = "ADD"
                frm.vLoadID = bsLoad.Current.LoadID
                frm.ShowDialog()
            Case "EMPTY"
                Dim frm As New frmAddEditLoadItemEmpty
                frm.vEditType = "ADD"
                frm.vLoadID = bsLoad.Current.LoadID
                frm.ShowDialog()
            Case "REAGENT"
                Dim frm As New frmAddEditLoadItemReagent
                frm.vEditType = "ADD"
                frm.vLoadID = bsLoad.Current.LoadID
                frm.ShowDialog()
                'Case "EQUIPMENT"
                '    'Dim frm As New frmAddEditLoadItemProduct
                '    'frm.vEditType = "ADD"
                '    'frm.vLoadID = bsLoad.Current.LoadID
                '    'frm.ShowDialog()
                'Case "PART"
                '    'Dim frm As New frmAddEditLoadItemProduct
                '    'frm.vEditType = "ADD"
                '    'frm.vLoadID = bsLoad.Current.LoadID
                '    'frm.ShowDialog()
            Case Else
                MsgBox("The item type for the selected Load Item cannot be added", MsgBoxStyle.Critical, "Error")
        End Select
        getLoadItems(vLoadID)
    End Sub

    Private Sub editLoadItem()
        If bsLoadItems.Count <= 0 Then
            Exit Sub
        End If
        'determine if user should only see a READONLY view of the data if linked to a source document
        'Load Items linked to Source Documents can only be edited from their source documents, not on the load itself
        Dim vUserView As String = Nothing
        If bsLoadItems.Current.SourceType Is Nothing Then
            vUserView = Nothing
        Else
            vUserView = "READONLY"
        End If

        Select Case bsLoadItems.Current.ItemType
            Case "PRODUCT"
                Dim frm As New frmAddEditLoadItemProduct
                frm.vEditType = "EDIT"
                frm.vLoadItemID = bsLoadItems.Current.LoadItemID
                frm.vLoadID = bsLoad.Current.LoadID
                frm.vUserView = vUserView
                frm.ShowDialog()
            Case "MISC"
                Dim frm As New frmAddEditLoadItemMisc
                frm.vEditType = "EDIT"
                frm.vLoadItemID = bsLoadItems.Current.LoadItemID
                frm.vLoadID = bsLoad.Current.LoadID
                frm.ShowDialog()
            Case "SAMPLE"
                Dim frm As New frmAddEditLoadItemSample
                frm.vEditType = "EDIT"
                frm.vLoadItemID = bsLoadItems.Current.LoadItemID
                frm.vLoadID = bsLoad.Current.LoadID
                frm.ShowDialog()
            Case "EMPTY"
                Dim frm As New frmAddEditLoadItemEmpty
                frm.vEditType = "EDIT"
                frm.vLoadItemID = bsLoadItems.Current.LoadItemID
                frm.vLoadID = bsLoad.Current.LoadID
                frm.ShowDialog()
                'Case "EQUIPMENT"
                '    'Dim frm As New frmAddEditLoadItemProduct
                '    'frm.vEditType = "EDIT"
                '    'frm.vLoadItemID = bsLoadItems.Current.LoadItemID
                '    'frm.vLoadID = bsLoad.Current.LoadID
                '    'frm.ShowDialog()
                'Case "PART"
                '    'Dim frm As New frmAddEditLoadItemProduct
                '    'frm.vEditType = "EDIT"
                '    'frm.vLoadItemID = bsLoadItems.Current.LoadItemID
                '    'frm.vLoadID = bsLoad.Current.LoadID
                '    'frm.ShowDialog()
            Case "REAGENT"
                Dim frm As New frmAddEditLoadItemReagent
                frm.vEditType = "EDIT"
                frm.vLoadItemID = bsLoadItems.Current.LoadItemID
                frm.vLoadID = bsLoad.Current.LoadID
                frm.ShowDialog()
            Case Else
                MsgBox("THe item type for the selected Load Item cannot be edited", MsgBoxStyle.Critical, "Error")
        End Select
        getLoadItems(vLoadID)
    End Sub

    Private Sub deleteLoadItem()
        If bsLoadItems.Count <= 0 Then
            Exit Sub
        End If
        Dim vConfirm As String = "Are you sure you want to delete the selected Load Item?"
        If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim oLoadItem As New Loaditem
        If oLoadItem.LoadByPrimaryKey(bsLoadItems.Current.LoadItemID) Then
            Select Case oLoadItem.SourceType
                Case "WORKORDER"
                    Dim oWOItem As New Workorderitem
                    Try
                        If oWOItem.LoadByPrimaryKey(oLoadItem.SourceID) Then
                            MsgBox("The selected Load Item cannot be deleted. It is controlled by Workorder #" & oWOItem.Workordernumber.ToString, MsgBoxStyle.Critical, "Error - Delete Request Failed")
                            Exit Sub
                        End If
                    Catch ex As Exception
                    End Try
                Case "PURCHASEORDER"
                    Dim oPOItem As New Poitem
                    Try
                        If oPOItem.LoadByPrimaryKey(oLoadItem.SourceID) Then
                            MsgBox("The selected Load Item cannot be deleted. It is controlled by Purchase Order #" & oPOItem.Ponumber.ToString, MsgBoxStyle.Critical, "Error - Delete Request Failed")
                            Exit Sub
                        End If
                    Catch ex As Exception
                    End Try
                Case "RETURN"
                    Dim oRMAItem As New Rmaitem
                    Try
                        If oRMAItem.LoadByPrimaryKey(oLoadItem.SourceID) Then
                            MsgBox("The selected Load Item cannot be deleted. It is controlled by RMA #" & oRMAItem.Rmaid.ToString, MsgBoxStyle.Critical, "Error - Delete Request Failed")
                            Exit Sub
                        End If
                    Catch ex As Exception
                    End Try
                Case Else
                    oLoadItem.MarkAsDeleted()
                    oLoadItem.Save()
            End Select
        End If
        getLoadItems(vLoadID)
    End Sub


    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        saveChanges()
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        cancelChanges()
    End Sub

    Private Sub btnAddWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddShipmentItem.ItemClick
        addLoadItem()
    End Sub

    Private Sub btnEditWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditShipmentItem.ItemClick
        editLoadItem()
    End Sub

    Private Sub btnDeleteWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteShipmentItem.ItemClick
        deleteLoadItem()
    End Sub

    Private Sub showCustomerNotes(ByVal vCustID)
        Dim frm As New frmAddEditCustomerNotes
        frm.vCustID = vCustID
        frm.ShowDialog()
    End Sub

    Private Sub FreightcarrierLookUpEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        'capture the click of the plus button on the drop down/lookup edit object for carriers
        If e.Button.Index = 1 Then
            addNewCarrier()
        End If
    End Sub

    Private Sub addNewCarrier()
        Dim frm As New frmAddEditCarrier
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getCarriers()
    End Sub

    Private Sub luLogistics_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        'capture the click of the plus button on the drop down/lookup edit object for logistics providers
        If e.Button.Index = 1 Then
            addNewLogisticsProvider()
        End If
    End Sub

    Private Sub addNewLogisticsProvider()
        Dim frm As New frmAddEditLogisticsProvider
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getLogistics()
    End Sub

    Private Sub btnPrintBOL_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintBOL.ItemClick
        printBOL()
    End Sub

    Private Sub printBOL()
        bsLoad.EndEdit()
        oLoad.EndEdit()
        oLoad.Save()
        Dim rpt As New rptBillOfLading2(vLoadID)
        rpt.ShowPreview()
    End Sub

    Private Sub luShipFromID_EditValueChanged(sender As Object, e As System.EventArgs) Handles luShipFromID.EditValueChanged

        If Not luShipFromID.IsModified Then
            Exit Sub
        End If

        'first, lookup customer record selected to get full data details
        Dim oCust As Customer
        oCust = New Customer
        Try
            If Not oCust.LoadByPrimaryKey(luShipFromID.EditValue) Then
                MsgBox("Error in looking up data for Location/Customer record selected", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error in looking up data for Location/Customer record selected", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

        'now get the record for the current shipment from the database
        Dim oRec As Shipment
        oRec = New Shipment
        If Not oRec.LoadByPrimaryKey(vLoadID) Then
            Exit Sub
        End If

        'now that we have the customer record located and loaded, update the appropriate data fields in the shipment record
        oRec.Shipfromid = oCust.Custid
        oRec.Shipfromaddress1 = oCust.Custshipaddress1
        oRec.Shipfromaddress2 = oCust.Custshipaddress2
        oRec.Shipfromcity = oCust.Custshipcity
        oRec.Shipfromstateprov = oCust.Custshipstateprov
        oRec.Shipfrompostalcode = oCust.Custshippostalcode
        oRec.Shipfromcontact = oCust.Custshipcontact
        oRec.Shipfromphone = oCust.Custphone
        oRec.Shipfromname = oCust.Custname
        oRec.Shipfromcountry = oCust.Custshipcountry
        oRec.Save()

        'fetch and reset screen data with new values for shipment from database
        bsLoad.EndEdit()
        oLoad.EndEdit()
        oLoad.Save()
        editObject(vLoadID)

    End Sub

    Private Sub luShipToID_EditValueChanged(sender As Object, e As System.EventArgs) Handles luShipToID.EditValueChanged
        If Not luShipToID.IsModified Then
            Exit Sub
        End If

        'first, lookup customer record selected to get full data details
        Dim oCust As Customer
        oCust = New Customer
        Try
            If Not oCust.LoadByPrimaryKey(luShipToID.EditValue) Then
                MsgBox("Error in looking up data for Location/Customer record selected", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox("Error in looking up data for Location/Customer record selected", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

        'now get the record for the current shipment To the database
        Dim oRec As Shipment
        oRec = New Shipment
        If Not oRec.LoadByPrimaryKey(vLoadID) Then
            Exit Sub
        End If

        'now that we have the customer record located and loaded, update the appropriate data fields in the shipment record
        oRec.Shiptoid = oCust.Custid
        oRec.Shiptoaddress1 = oCust.Custshipaddress1
        oRec.Shiptoaddress2 = oCust.Custshipaddress2
        oRec.Shiptocity = oCust.Custshipcity
        oRec.Shiptostateprov = oCust.Custshipstateprov
        oRec.Shiptopostalcode = oCust.Custshippostalcode
        oRec.Shiptocontact = oCust.Custshipcontact
        oRec.Shiptophone = oCust.Custphone
        oRec.Shiptoname = oCust.Custname
        oRec.Shiptocountry = oCust.Custshipcountry
        oRec.Save()

        'fetch and reset screen data with new values for shipment To database
        bsLoad.EndEdit()
        oLoad.EndEdit()
        oLoad.Save()
        editObject(vLoadID)
    End Sub

    Private Sub bsLoadItems_CurrentChanged(sender As Object, e As EventArgs) Handles bsLoadItems.CurrentChanged
        If bsLoadItems.Current.SourceType Is Nothing Then
            btnEditShipmentItem.Enabled = True
            btnDeleteShipmentItem.Enabled = True
        Else
            btnEditShipmentItem.Enabled = True
            btnDeleteShipmentItem.Enabled = False
        End If
    End Sub

    Private Sub rbtnLoadFreightCharges_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnLoadFreightCharges.ItemClick
        Dim frm As New frmFreightCharges
        frm.vLoadID = oLoad.LoadID
        frm.ShowDialog()
    End Sub



    Private Sub chkEditOverrideSkids_EditValueChanging(sender As Object, e As ChangingEventArgs) Handles chkEditOverrideSkids.EditValueChanging

        If e.NewValue <> e.OldValue Then
            If e.NewValue Then ' checked 
                ' txtTotalSkids.ReadOnly = False
            Else
                Dim chkOverride As CheckEdit = CType(sender, CheckEdit)
                txtTotalSkids.Text = GetCalculatedSkidsByLoad(vLoadID)

            End If
        End If
    End Sub

    Private Sub chkEditOverrideSkids_EditValueChanged(sender As Object, e As EventArgs) Handles chkEditOverrideSkids.EditValueChanged
        txtTotalSkids.ReadOnly = Not chkEditOverrideSkids.Checked
    End Sub
End Class