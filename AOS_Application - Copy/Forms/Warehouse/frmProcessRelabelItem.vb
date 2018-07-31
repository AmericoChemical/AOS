Imports AOS.BusinessObjects

Public Class frmProcessRelabelItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vRelabelOrderItemNumber As Integer

    Dim oRlbOrder As ViewRelabelOrder
    Dim oRlbItem As ViewRelabelOrderItem
    Dim oInvItem As Invitem

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        If vRelabelOrderItemNumber <= 0 Then
            Me.Close()
            Exit Sub
        End If

        oRlbItem = New ViewRelabelOrderItem
        oRlbItem.Query.Where(oRlbItem.Query.Relabelorderitemnumber.Equal(vRelabelOrderItemNumber))
        If Not oRlbItem.Query.Load Then
            MsgBox("Error in retrieving Relabel Item data", MsgBoxStyle.Critical, "ERROR")
            Me.Close()
            Exit Sub
        End If

        oRlbOrder = New ViewRelabelOrder
        oRlbOrder.Query.Where(oRlbOrder.Query.Relabelordernumber.Equal(oRlbItem.Relabelordernumber))
        If Not oRlbOrder.Query.Load Then
            MsgBox("Error in retrieving Relabel Order data", MsgBoxStyle.Critical, "ERROR")
            Me.Close()
            Exit Sub
        End If

        If oRlbItem.Invitemnum Is Nothing Or IsDBNull(oRlbItem.Invitemnum) Or oRlbItem.Invitemnum < 0 Then
            MsgBox("This Relabel Item is not ready to be processed - no Inventory Item exists to be relabeled.", MsgBoxStyle.Critical, "ERROR - Missing data")
            Me.Close()
            Exit Sub
        End If

        oInvItem = New Invitem
        If Not oInvItem.LoadByPrimaryKey(oRlbItem.Invitemnum) Then
            MsgBox("Error retrieving Inventory Item data", MsgBoxStyle.Critical, "ERROR")
            Me.Close()
            Exit Sub
        End If

        bsRelabelItem.DataSource = oRlbItem
        bsRelabelOrder.DataSource = oRlbOrder
        bsInvItem.DataSource = oInvItem

    End Sub

    Private Sub rbtnReturn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReturn.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

    Private Sub btnMarkAsCompleted_Click(sender As Object, e As EventArgs) Handles btnMarkAsCompleted.Click
        If bsInvItem.Current.Itemstatus <> "FORRLBL" Then
            MsgBox("The Inventory Item does not have a status of FORRLBL and cannot be processed at this time.", MsgBoxStyle.Critical, "ERROR - Inventory Item Status")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to mark this inventory item as RELABELED? You cannot UNDO this action", MsgBoxStyle.YesNo, "CONFIRM - Mark as Relabeled") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not processRelabelItemMarkAsCompleted(vRelabelOrderItemNumber) Then
            MsgBox("Error Processing Relabel Item")
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If

    End Sub

    Private Function processRelabelItemMarkAsCompleted(vRlblItemNumber As Integer) As Boolean

        If vRelabelOrderItemNumber <= 0 Then
            Return False
        End If

        Dim oRItem As New Relabelorderitem
        oRItem.Query.Where(oRItem.Query.Relabelorderitemnumber.Equal(vRlblItemNumber))
        If Not oRItem.Query.Load Then
            Return False
        End If

        Dim oROrder As New Relabelorder
        If Not oROrder.LoadByPrimaryKey(oRItem.Relabelordernumber) Then
            Return False
        End If

        Dim oItemA As New Invitem
        If Not oItemA.LoadByPrimaryKey(oRItem.Invitemnum) Then
            Return False
        End If

        '1) Copy Original Inventory Item (ItemA) to New Inventory Item (ItemB)
        Dim oItemB As New Invitem
        oItemB.Inventoryclass = 1
        oItemB.Lotnumber = oItemA.Lotnumber
        oItemB.Productid = oRlbOrder.Itemid
        oItemB.Productdesc = oRlbOrder.Itemdesc
        oItemB.Container = oRlbOrder.Container
        oItemB.Itemstatus = "ALLOCATED"
        oItemB.Allocatedtype = "WORKORDER"
        oItemB.Allocateddocument = oRlbOrder.Workordernumber
        oItemB.Allocateddate = Now
        oItemB.Receiveddate = Now
        oItemB.Sourcetype = "RELABEL"
        oItemB.Sourcedocument = oItemA.Invitemnumber
        oItemB.Testsamplekey = oItemA.Testsamplekey
        oItemB.Warehouselocation = oItemA.Warehouselocation
        oItemB.Warehousenumber = oItemA.Warehousenumber
        oItemB.Ph = oItemA.Ph
        oItemB.Sg = oItemA.Sg
        oItemB.Color = oItemA.Color
        oItemB.Rcvdweight = oItemA.Rcvdweight
        oItemB.Unitcost = oItemA.Unitcost
        oItemB.Uom = oItemA.Uom
        oItemB.Actualcostunits = oItemA.Actualcostunits
        oItemB.Actualcostuom = oItemA.Actualcostuom
        oItemB.Actualunitcost = oItemB.Actualunitcost
        oItemB.Vendorweight = oItemA.Vendorweight
        oItemB.Unitsremainingvolume = oItemA.Unitsremainingvolume
        oItemB.Unitsremainingweight = oItemA.Unitsremainingweight
        oItemB.Unitsremaining = oItemA.Unitsremaining
        oItemB.Note = oItemA.Note

        oItemB.Save()

        Dim vNewItemNum As Integer = oItemB.Invitemnumber

        '2) Update Workorderitem Record
        Dim OWI As New Workorderitem
        OWI.LoadByPrimaryKey(oRItem.Workorderitemnumber)
        OWI.Invitemnumber = vNewItemNum
        OWI.Save()

        '3) Update Original Inventory Record (oItemA)
        oItemA.Itemstatus = "RELABELED"
        oItemA.Save()

        '4) Update RelabelOrderItem status
        oRItem.Relabelorderitemstatus = "COMPLETED"
        oRItem.Save()

        '5) Notify user of success
        MsgBox("The Relabel Order Item has been successfully processed and a new Inventory Item has been created, received, and allocated to the linked Work Order. An Inventory Tag label has been sent to the printer.")

        'get Product Record for selected InventoryItem
        Dim oItem As New Invitem
        oItem.LoadByPrimaryKey(vNewItemNum)

        'Print inventory tag / small label
        prepareMiniBarcodeLabelForInventoryItem(oItem.Invitemnumber)

        'Print Product Label
        Dim rpt2 As New rptGHSProductLabelLarge(oItem.Invitemnumber, oItem.Productid)
        rpt2.ShowPreviewDialog()

        'Dim oProduct As New Product
        'oProduct.LoadByPrimaryKey(oItemList.Productid)

        'If IsDBNull(oProduct.Chemicalid) Or oProduct.Chemicalid Is Nothing Then
        '    Dim rpt1 As New rptProductLabelForInventoryItem(vNewItemNum)
        '    rpt1.ShowPreviewDialog
        'ElseIf oProduct.Chemicalid <= 0 Then
        '    Dim rpt1 As New rptProductLabelForInventoryItem(vNewItemNum)
        '    rpt1.ShowPreviewDialog
        'ElseIf oProduct.Chemicalid > 0 Then
        '    Dim rpt2 As New rptGHSProductLabelLarge(vNewItemNum, oProduct.Productid)
        '    rpt2.ShowPreviewDialog()
        'End If

        Return True


    End Function
End Class
