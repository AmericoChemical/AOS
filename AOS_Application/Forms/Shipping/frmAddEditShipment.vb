
Imports AOS.BusinessObjects

Public Class frmAddEditShipment
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vShipmentID As Integer   'ShipmentNumber passed from calling form for edit and review of shipment
    Public vEditType As String      'ADD or EDIT option

    Dim oShipment As Shipment
    Dim oShipmentItems As ShipmentitemCollection
    Dim oShipmentDetails As ShipmentdetailCollection
    Dim oCustomers As CustomerCollection
    Dim oShipFromList As CustomerCollection
    Dim oShipToList As CustomerCollection
    Dim oCarriers As CarrierCollection
    Dim oLogistics As LogisticsCollection
    Dim oFOB As ListFobCollection
    Dim oParm As Sysparameters

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getCustomers()
        getShipFromList()
        getShipToList()
        getCarriers()
        getLogistics()
        getFOB()
        getParms()
        If vEditType = "ADD" Then
            luCustomerID.Properties.ReadOnly = False
            addNewObject()
        Else
            editObject(vShipmentID)
        End If
    End Sub

    Private Sub getParms()
        oParm = New Sysparameters
        oParm.LoadByPrimaryKey(1)
    End Sub

    Private Sub addNewObject()
        oShipment = New Shipment
        oShipment.AddNew()
        oShipment.Shipmentdate = Today
        oShipment.Shipmentstatus = "OPEN"
        oShipment.Keepfromfreezing = oParm.FreezeWarning
        oShipment.Save()
        vShipmentID = oShipment.Shipmentnumber.Value
        editObject(vShipmentID)
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oShipment = New Shipment
        If Not oShipment.LoadByPrimaryKey(vID) Then
            MsgBox("Could not retrieve selected Shipment data from the database", MsgBoxStyle.Critical, "Error")
            Me.Close()
        End If
        bsShipment.DataSource = oShipment
        getShipmentItems(vID)
    End Sub

    Private Sub getShipmentItems(ByVal vID As Integer)
        oShipmentItems = New ShipmentitemCollection
        oShipmentItems.Query.Where(oShipmentItems.Query.Shipmentnumber.Equal(vID))
        oShipmentItems.Query.Load()
        Try
            bsShipmentItems.DataSource = oShipmentItems
            'grShipmentItems.DataSource = bsShipmentItems
            'grShipmentItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        oShipmentDetails = New ShipmentdetailCollection
        oShipmentDetails.Query.Where(oShipmentDetails.Query.Shipmentnumber.Equal(vID))
        oShipmentDetails.Query.Load()
        Try
            bsShipmentDetails.DataSource = oShipmentDetails
            grShipmentItems.DataSource = bsShipmentDetails
            grShipmentItems.Refresh()
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
        bsShippingFrom.DataSource = oShipFromList
    End Sub

    Private Sub getShipToList()
        oShipToList = New CustomerCollection
        oShipToList.LoadAll()
        oShipToList.Sort = "CUSTNAME"
        bsShippingTo.DataSource = oShipToList
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
        bsShipment.EndEdit()
        bsShipmentItems.EndEdit()
        oShipment.EndEdit()
        oShipment.Save()
        oShipmentItems.Save()
    End Sub

    Private Sub saveChanges()
        bsShipment.EndEdit()
        bsShipmentDetails.EndEdit()
        If bsShipmentDetails.Count <= 0 Then
            MsgBox("You must enter at least one Item to save the Shipment", MsgBoxStyle.Critical, "Error - No items")
            Exit Sub
        End If
        oShipment.Save()
        oShipmentDetails.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cancelChanges()
        oShipment.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oShipment.MarkAsDeleted()
                oShipment.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub addShipmentItem()
        Dim frm As New frmAddNewShipmentItem
        frm.vEditType = "ADD"
        frm.vShipmentNum = bsShipment.Current.ShipmentNumber
        frm.vCustID = bsShipment.Current.CustID
        frm.vCustomerName = bsShipment.Current.CustomerName
        frm.vShipmentDate = bsShipment.Current.ShipmentDate
        frm.vCustomerPO = bsShipment.Current.CustomerPO
        frm.ShowDialog()
        getShipmentItems(vShipmentID)
    End Sub

    Private Sub editShipmentItem()
        Dim frm As New frmAddNewShipmentItem
        frm.vEditType = "EDIT"
        frm.vShipmentItemNumber = bsShipmentDetails.Current.ShipmentDetailID
        frm.vShipmentNum = bsShipment.Current.ShipmentNumber
        frm.vCustID = bsShipment.Current.CustID
        frm.vCustomerName = bsShipment.Current.CustomerName
        frm.vShipmentDate = bsShipment.Current.ShipmentDate
        frm.vCustomerPO = bsShipment.Current.CustomerPO
        frm.ShowDialog()
        getShipmentItems(vShipmentID)
    End Sub

    Private Sub deleteShipmentItem()
        If bsShipmentDetails.Count <= 0 Then
            Exit Sub
        End If
        Dim vConfirm As String = "Are you sure you want to delete the selected Shipment Item?"
        If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim oShipItem As New Shipmentdetail
        If oShipItem.LoadByPrimaryKey(bsShipmentDetails.Current.ShipmentDetailID) Then
            oShipItem.MarkAsDeleted()
            oShipItem.Save()
        End If
        getShipmentItems(vShipmentID)
    End Sub


    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        saveChanges()
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        cancelChanges()
    End Sub

    Private Sub btnAddWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddShipmentItem.ItemClick
        addShipmentItem()
    End Sub

    Private Sub btnEditWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditShipmentItem.ItemClick
        editShipmentItem()
    End Sub

    Private Sub btnDeleteWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteShipmentItem.ItemClick
        deleteShipmentItem()
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
        bsShipment.EndEdit()
        oShipment.EndEdit()
        oShipment.Save()
        Dim rpt As New rptBillOfLading4(vShipmentID)
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
        If Not oRec.LoadByPrimaryKey(vShipmentID) Then
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
        bsShipment.EndEdit()
        oShipment.EndEdit()
        oShipment.Save()
        editObject(vShipmentID)

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
        If Not oRec.LoadByPrimaryKey(vShipmentID) Then
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
        bsShipment.EndEdit()
        oShipment.EndEdit()
        oShipment.Save()
        editObject(vShipmentID)
    End Sub


End Class