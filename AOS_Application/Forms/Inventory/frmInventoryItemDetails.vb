Imports AOS.BusinessObjects

Public Class frmInventoryItemDetails
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
        Dim oInvItemTrans As New ViewInvItemTransactionsCollection
        oInvItemTrans.Query.Where(oInvItemTrans.Query.Invitemnumber.Equal(oItem.Invitemnumber))
        oInvItemTrans.Query.Load()
        bsInvTx.DataSource = oInvItemTrans

        Dim oPhys As New InvphysCollection
        oPhys.Query.Where(oPhys.Query.Invitemnumber.Equal(oItem.Invitemnumber))
        oPhys.Query.Load()
        bsInvPhys.DataSource = oPhys
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
        If vClass Is Nothing OrElse _
            vStatus Is Nothing Then
            Exit Sub
        End If

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
            Case InventoryItemStatus.AVAILABLE.ToString()
                rbtnMarkAvailable.Enabled = False
                rbtnMarkInProcess.Enabled = False
                rbtnMarkDepleted.Enabled = True
                rbtnMarkQuarantine.Enabled = True
                rbtnMarkShipped.Enabled = True
                rbtnConvertFGtoRM.Enabled = True
                rbtnConvertRMtoFG.Enabled = True
            Case InventoryItemStatus.QUARANTINED.ToString()
                rbtnMarkAvailable.Enabled = True
                rbtnMarkInProcess.Enabled = False
                rbtnMarkDepleted.Enabled = True
                rbtnMarkQuarantine.Enabled = False
                rbtnMarkShipped.Enabled = True
                rbtnConvertFGtoRM.Enabled = False
                rbtnConvertRMtoFG.Enabled = False
            Case InventoryItemStatus.SHIPPED.ToString()
                rbtnMarkAvailable.Enabled = True
                rbtnMarkInProcess.Enabled = False
                rbtnMarkDepleted.Enabled = False
                rbtnMarkQuarantine.Enabled = True
                rbtnMarkShipped.Enabled = False
                rbtnConvertFGtoRM.Enabled = False
                rbtnConvertRMtoFG.Enabled = False
            Case InventoryItemStatus.DEPLETED.ToString()
                rbtnMarkAvailable.Enabled = False
                rbtnMarkInProcess.Enabled = True
                rbtnMarkDepleted.Enabled = False
                rbtnMarkQuarantine.Enabled = False
                rbtnMarkShipped.Enabled = False
                rbtnConvertFGtoRM.Enabled = False
                rbtnConvertRMtoFG.Enabled = False
        End Select

    End Sub

    Private Sub rbtnReturn_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReturn.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub


    Private Sub changeStatus(vStatus As String)
        If vStatus Is Nothing Then
            Exit Sub
        End If

        Dim vMsg As String = String.Format("Are you sure you want to update the Inventory Item Status to {0}?", vStatus)
        If MsgBox(vMsg, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oItem As New Invitem
        If Not oItem.LoadByPrimaryKey(vID) Then
            MsgBox("Cannot open database record for Inventory Item", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If
        Dim oProd As New Product
        If Not oProd.LoadByPrimaryKey(oItem.Productid) Then
            MsgBox("Cannot open database record for Product data", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If

        Try
            Select Case vStatus
                Case "IN PROCESS"
                    'only for raw materials - inventory class 2
                    If oItem.Inventoryclass = InventoryClass.FULLAVAILABLE Then
                        MsgBox("Only Raw Materials containers can be marked as IN PROCESS", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    oItem.Itemstatus = "IN PROCESS"
                    oItem.Unitsremaining = oProd.Units
                    oItem.Save()
                Case InventoryItemStatus.AVAILABLE.ToString()
                    'only for finished goods - inventory class 1
                    'confirm this inventory item has not been allocated or shipped
                    If oItem.Inventoryclass = InventoryClass.INPROCESS Then
                        MsgBox("Only Finished Goods containers can be marked as AVAILABLE", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If

                    If oItem.Shipmentnumber > 0 OrElse _
                        oItem.Workordernumber > 0 Then
                        MsgBox("This item has been allocated to a work order or already shipped", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    
                    oItem.Itemstatus = InventoryItemStatus.AVAILABLE.ToString()
                    oItem.Unitsremaining = oProd.Units
                    oItem.Save()
                Case InventoryItemStatus.QUARANTINED.ToString()
                    oItem.Itemstatus = InventoryItemStatus.QUARANTINED.ToString()
                    oItem.Save()
                Case InventoryItemStatus.DEPLETED.ToString()
                    If oItem.Inventoryclass <> InventoryClass.INPROCESS Then
                        MsgBox("Item is not in Raw Material. It cannot be marked as DEPLETED", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End If
                    oItem.Itemstatus = InventoryItemStatus.DEPLETED.ToString()
                    oItem.Unitsremaining = 0
                    oItem.Save()
                Case InventoryItemStatus.SHIPPED.ToString()
                    'ask for shipping information to update inventory item
                    Dim vShipNum As Integer = 0
                    Dim oShip As New Shipment
                    Try
                        vShipNum = CInt(getUserString("Enter Shipment Number Item was shipped on:"))
                        If Not oShip.LoadByPrimaryKey(vShipNum) Then
                            MsgBox("Unable to locate Shipment Record", MsgBoxStyle.Critical, "Error")
                            Exit Sub
                        End If
                    Catch ex As Exception
                        MsgBox("Unable to locate Shipment record", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End Try
                    Try
                        oItem.Shipmentnumber = oShip.Shipmentnumber
                        oItem.Shippeddate = oShip.Shipmentdate
                        oItem.Itemstatus = InventoryItemStatus.SHIPPED.ToString()
                        oItem.Save()
                    Catch ex As Exception
                        MsgBox("Error in updating status of Inventory Item", MsgBoxStyle.Critical, "Error")
                    End Try
            End Select
            MsgBox("Inventory Item status was changed successfully", MsgBoxStyle.Information, "Update complete")
            loadData()
        Catch ex As Exception
            MsgBox("There was an error in updating the Inventory Item", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub changeClass(vClass As String)
        If vClass Is Nothing Then
            Exit Sub
        End If

        Dim vMsg As String = String.Format("Are you sure you want to convert the Inventory Item Status to {0}?", vClass)
        If MsgBox(vMsg, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oItem As New Invitem
        If Not oItem.LoadByPrimaryKey(vID) Then
            MsgBox("Cannot open database record for Inventory Item", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If

        Dim oProd As New Product
        If Not oProd.LoadByPrimaryKey(oItem.Productid) Then
            MsgBox("Cannot open database record for Product data", MsgBoxStyle.Critical, "Error - Update Failed")
            Exit Sub
        End If

        Try
            Select Case vClass
                Case "Finished Goods"   'change from Raw Material to Finished Good
                    oItem.Inventoryclass = InventoryClass.FULLAVAILABLE
                    oItem.Unitsremaining = oProd.Units
                    oItem.Itemstatus = InventoryItemStatus.AVAILABLE.ToString()
                    oItem.Save()
                Case "Raw Material"   'change from Finished Good to Raw Material
                    oItem.Inventoryclass = InventoryClass.INPROCESS
                    oItem.Unitsremaining = oProd.Units
                    oItem.Itemstatus = "IN PROCESS"
                    oItem.Save()
            End Select
            MsgBox("Inventory Item successfully converted", MsgBoxStyle.Information, "Conversion completed")
            loadData()
        Catch ex As Exception
            MsgBox("Error in converting Inventory Item", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub


    Private Sub rbtnMarkAvailable_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkAvailable.ItemClick
        changeStatus(InventoryItemStatus.AVAILABLE.ToString())
    End Sub

    Private Sub rbtnMarkQuarantine_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkQuarantine.ItemClick
        changeStatus(InventoryItemStatus.QUARANTINED.ToString())
    End Sub

    Private Sub rbtnMarkDepleted_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkDepleted.ItemClick
        changeStatus(InventoryItemStatus.DEPLETED.ToString())
    End Sub

    Private Sub rbtnMarkShipped_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkShipped.ItemClick
        changeStatus(InventoryItemStatus.SHIPPED.ToString())
    End Sub

    Private Sub rbtnConvertFGtoRM_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnConvertFGtoRM.ItemClick
        changeClass("Raw Material")
    End Sub

    Private Sub rbtnConvertRMtoFG_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnConvertRMtoFG.ItemClick
        changeClass("Finished Goods")
    End Sub

    Private Sub rbtnUpdateLotNumber_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUpdateLotNumber.ItemClick
        If bsItem Is Nothing Then
            Exit Sub
        End If

        Dim vLotNumber As String = bsItem.Current.lotNumber
        vLotNumber = getUserString("Enter new Lot Number:")
        If vLotNumber Is Nothing Then
            Exit Sub
        End If

        Dim oInvitem As New Invitem
        Try
            If Not oInvitem.LoadByPrimaryKey(bsItem.Current.InvItemNumber) Then
                Exit Sub
            End If

            oInvitem.Lotnumber = vLotNumber
            oInvitem.Save()
            MsgBox("Lot Number successfully updated.", MsgBoxStyle.Information, "Update succeeded")
            loadData()
        Catch ex As Exception
            MsgBox("There was an error in updating the Lot Number", MsgBoxStyle.Critical, "Error - Data Issue")
        End Try

    End Sub

    Private Sub rbtnChangeItemStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangeItemStatus.ItemClick
        If bsItem Is Nothing Then
            Exit Sub
        End If

        changeItemStatus(bsItem.Current.InvItemNumber)
    End Sub

    Private Sub rbtnConvertItemClass_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnConvertItemClass.ItemClick
        If bsItem Is Nothing Then
            Exit Sub
        End If

        changeItemClass(bsItem.Current.InvItemNumber)
    End Sub

    Private Sub changeItemStatus(vItemNum As Integer)
        If bsItem Is Nothing Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to change the selected Inventory Item's Current Status?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim frm As New frmChangeInventoryItemStatus
        frm.vItemNum = bsItem.Current.InvItemnumber
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub changeItemClass(vItemNum As Integer)
        If MsgBox("Are you sure you want to convert the selected Inventory Item to a different Inventory Classification (i.e Full Available, In Process, etc.)?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

End Class