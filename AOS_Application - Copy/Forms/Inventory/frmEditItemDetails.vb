Imports AOS.BusinessObjects

Public Class frmEditItemDetails
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Inventory Item"

    'here is where you dimension your object variables for the form
    Dim oItem As ViewInvItemDetails
    Dim oTx As ViewInvItemTransactionsCollection
    Dim oPhys As InvphysCollection
    Dim oRcv As ViewReceivedHoldItemsCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = vObjectName & " Information"
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        editObject(vID)
        getItemDetails()
        setRibbonButtons(oItem.Inventoryclass, oItem.Itemstatus)
    End Sub

    Private Sub getItemDetails()
        oTx = New ViewInvItemTransactionsCollection
        oTx.Query.Where(oTx.Query.Invitemnumber.Equal(oItem.Invitemnumber))
        oTx.Query.Load()
        bsInvTx.DataSource = oTx

        oPhys = New InvphysCollection
        oPhys.Query.Where(oPhys.Query.Invitemnumber.Equal(oItem.Invitemnumber))
        oPhys.Query.Load()
        bsInvPhys.DataSource = oPhys

        oRcv = New ViewReceivedHoldItemsCollection
        oRcv.Query.Where(oRcv.Query.Invitemnumber.Equal(oItem.Invitemnumber))
        oRcv.Query.Load()
        bsRecvHold.DataSource = oRcv

    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Me.Close()
        End If
        oItem = New ViewInvItemDetails
        oItem.Query.Where(oItem.Query.Invitemnumber.Equal(vID))
        If Not oItem.Query.Load Then
            MsgBox("Error in loading requested data", MsgBoxStyle.Critical, "Error")
            Me.Close()
        End If
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub setRibbonButtons(vClass, vStatus)

        Select Case vClass
            Case 1
                rbtnConvertFGtoRM.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnConvertRMtoFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                rbtnMarkAvailable.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkDepleted.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                rbtnMarkQuarantine.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkShipped.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkInProcess.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Case 2
                rbtnConvertFGtoRM.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                rbtnConvertRMtoFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkAvailable.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkDepleted.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkQuarantine.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkShipped.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                rbtnMarkInProcess.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            Case Else
                rbtnConvertFGtoRM.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnConvertRMtoFG.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkAvailable.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkDepleted.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkQuarantine.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkShipped.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                rbtnMarkInProcess.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        End Select

        Select Case vStatus
            Case "AVAILABLE"
                rbtnMarkAvailable.Enabled = False
                rbtnMarkInProcess.Enabled = False
                rbtnMarkDepleted.Enabled = True
                rbtnMarkQuarantine.Enabled = True
                rbtnMarkShipped.Enabled = True
                rbtnConvertFGtoRM.Enabled = True
                rbtnConvertRMtoFG.Enabled = True
            Case "QUARANTINED"
                rbtnMarkAvailable.Enabled = True
                rbtnMarkInProcess.Enabled = False
                rbtnMarkDepleted.Enabled = True
                rbtnMarkQuarantine.Enabled = False
                rbtnMarkShipped.Enabled = True
                rbtnConvertFGtoRM.Enabled = False
                rbtnConvertRMtoFG.Enabled = False
            Case "SHIPPED"
                rbtnMarkAvailable.Enabled = True
                rbtnMarkInProcess.Enabled = False
                rbtnMarkDepleted.Enabled = False
                rbtnMarkQuarantine.Enabled = True
                rbtnMarkShipped.Enabled = False
                rbtnConvertFGtoRM.Enabled = False
                rbtnConvertRMtoFG.Enabled = False
            Case "DEPLETED"
                rbtnMarkAvailable.Enabled = False
                rbtnMarkInProcess.Enabled = True
                rbtnMarkDepleted.Enabled = False
                rbtnMarkQuarantine.Enabled = False
                rbtnMarkShipped.Enabled = False
                rbtnConvertFGtoRM.Enabled = False
                rbtnConvertRMtoFG.Enabled = False
            Case Else
        End Select

    End Sub

    Private Sub rbtnReturn_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReturn.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub


    Private Sub changeStatus(vStatus As String)

        Dim str As String = "Are you sure you want to update the Inventory Item status to " & vStatus & "?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim rItem As New Invitem
        If Not rItem.LoadByPrimaryKey(vID) Then
            MsgBox("Cannot open database record for Inventory Item", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If
        Dim rProd As New Product
        If Not rProd.LoadByPrimaryKey(rItem.Productid) Then
            MsgBox("Cannot open database record for Product data", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If

        Try
            Select Case vStatus
                Case "IN PROCESS"
                    'only for raw materials - inventory class 2
                    If rItem.Inventoryclass = InventoryClass.FULLAVAILABLE Then
                        MsgBox("Only Raw Materials containers can be marked as IN PROCESS", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    rItem.Itemstatus = "IN PROCESS"
                    rItem.Unitsremaining = rProd.Units
                    rItem.Save()
                Case "AVAILABLE"
                    'only for finished goods - inventory class 1
                    'confirm this inventory item has not been allocated or shipped
                    If rItem.Inventoryclass = InventoryClass.INPROCESS Then
                        MsgBox("Only Finished Goods containers can be marked as AVAILABLE", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    Dim vX As Integer = 0
                    If rItem.Shipmentnumber > 0 Then
                        vX = 1
                    End If
                    If rItem.Workordernumber > 0 Then
                        vX = 1
                    End If
                    If vX = 1 Then
                        MsgBox("This item has been allocated to a work order or already shipped", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    rItem.Itemstatus = "AVAILABLE"
                    rItem.Unitsremaining = rProd.Units
                    rItem.Save()
                Case "QUARANTINED"
                    rItem.Itemstatus = "QUARANTINED"
                    rItem.Save()
                Case "DEPLETED"
                    If rItem.Inventoryclass <> InventoryClass.INPROCESS Then
                        MsgBox("Item is not in Raw Material. It cannot be marked as DEPLETED", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    rItem.Itemstatus = "DEPLETED"
                    rItem.Unitsremaining = 0
                    rItem.Save()
                Case "SHIPPED"
                    'ask for shipping information to update inventory item
                    Dim vShipNum As Integer = 0
                    Dim oShip As New Shipment
                    Try
                        vShipNum = CInt(getUserString("Enter Shipment Number item was shipped on:"))
                        If Not oShip.LoadByPrimaryKey(vShipNum) Then
                            MsgBox("Unable to locate Shipment Record", MsgBoxStyle.Critical, "Error")
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MsgBox("Unable to locate Shipment record", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End Try
                    Try
                        rItem.Shipmentnumber = oShip.Shipmentnumber
                        rItem.Shippeddate = oShip.Shipmentdate
                        rItem.Itemstatus = "SHIPPED"
                        rItem.Save()
                    Catch ex As Exception
                        MsgBox("Error in updating status of Inventory Item", MsgBoxStyle.Critical, "Error")
                    End Try
            End Select
            MsgBox("Inventory Item status was changed successfully", MsgBoxStyle.Information, "Update complete")
            loadData()
        Catch ex As Exception
            MsgBox("There was an error in updating the inventory item record", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub changeClass(vClass As String)

        Dim str As String = "Are you sure you want to convert the Inventory Item status to " & vClass & "?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim rItem As New Invitem
        If Not rItem.LoadByPrimaryKey(vID) Then
            MsgBox("Cannot open database record for Inventory Item", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If
        Dim rProd As New Product
        If Not rProd.LoadByPrimaryKey(rItem.Productid) Then
            MsgBox("Cannot open database record for Product data", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If

        Try
            Select Case vClass
                Case "Finished Goods"   'change from Raw Material to Finished Good
                    rItem.Inventoryclass = InventoryClass.FULLAVAILABLE
                    rItem.Unitsremaining = rProd.Units
                    rItem.Itemstatus = "AVAILABLE"
                    rItem.Save()
                Case "Raw Material"   'change from Finished Good to Raw Material
                    rItem.Inventoryclass = InventoryClass.INPROCESS
                    rItem.Unitsremaining = rProd.Units
                    rItem.Itemstatus = "IN PROCESS"
                    rItem.Save()
            End Select
            MsgBox("Inventory Item successfully converted", MsgBoxStyle.Information, "Conversion completed")
            loadData()
        Catch ex As Exception
            MsgBox("Error in converting Inventory Item", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub rbtnMarkAvailable_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkAvailable.ItemClick
        changeStatus("AVAILABLE")
    End Sub

    Private Sub rbtnMarkQuarantine_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkQuarantine.ItemClick
        changeStatus("QUARANTINED")
    End Sub

    Private Sub rbtnMarkDepleted_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkDepleted.ItemClick
        changeStatus("DEPLETED")
    End Sub

    Private Sub rbtnMarkShipped_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkShipped.ItemClick
        changeStatus("SHIPPED")
    End Sub

    Private Sub rbtnConvertFGtoRM_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnConvertFGtoRM.ItemClick
        changeClass("Raw Material")
    End Sub

    Private Sub rbtnConvertRMtoFG_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnConvertRMtoFG.ItemClick
        changeClass("Finished Goods")
    End Sub

    Private Sub rbtnUpdateLotNumber_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUpdateLotNumber.ItemClick
        Dim vLot As String = bsItem.Current.lotNumber
        vLot = getUserString("Enter new Lot Number:")
        If vLot Is Nothing Then
            Exit Sub
        End If
        Dim vRec As New Invitem
        Try
            If vRec.LoadByPrimaryKey(bsItem.Current.InvItemNumber) Then
                vRec.Lotnumber = vLot
                vRec.Save()
                MsgBox("Lot Number successfully updated.", MsgBoxStyle.Information, "Update succeeded")
                loadData()
            End If
        Catch ex As Exception
            MsgBox("There was an error in updating the Lot Number", MsgBoxStyle.Critical, "Error - Data Issue")
        End Try

    End Sub

    Private Sub rbtnChangeItemStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangeItemStatus.ItemClick
        changeItemStatus(bsItem.Current.InvItemNumber)
    End Sub

    Private Sub rbtnConvertItemClass_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnConvertItemClass.ItemClick
        changeItemClass(bsItem.Current.InvItemNumber)
    End Sub

    Private Sub changeItemStatus(itemnum As Integer)
        If MsgBox("Are you sure you want to change the selected Inventory Item's Current Status?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim frm As New frmChangeInventoryItemStatus
        frm.vItemNum = bsItem.Current.InvItemnumber
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub changeItemClass(itemnum As Integer)
        If MsgBox("Are you sure you want to cconvert the selected Inventory Item to a different Inventory Classification (i.e Full Available, In Process, etc.)?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

End Class