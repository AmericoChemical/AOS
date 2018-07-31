
Imports AOS.BusinessObjects

Public Class frmAddEditWorkOrders
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vWorkorderNum As Integer
    Public vEditType As String

    Dim oProducts As ProductCollection
    Dim oWorkOrder As Workorder
    Dim oWorkOrderItems As WorkorderitemCollection
    Dim oCustomers As CustomerCollection
    Dim oEmployees As EmployeeCollection
    Dim oSuppliers As SuppliercompanyCollection
    Dim oCarriers As CarrierCollection
    Dim oLogistics As LogisticsCollection
    Dim oFOB As ListFobCollection
    Dim oCustomer As Customer

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getProducts()
        getCustomers()
        getSuppliers()
        getEmployees()
        getCarriers()
        getLogistics()
        getFOB()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vWorkorderNum)
        End If
    End Sub

    Private Sub addNewObject()
        oWorkOrder = New Workorder
        oWorkOrder.AddNew()
        oWorkOrder.Orderstatus = "OPEN"
        oWorkOrder.Workorderdate = Today
        oWorkOrder.Suppliercompany = "AMERICO CHEMICAL"
        oWorkOrder.Save()
        vWorkorderNum = oWorkOrder.Workordernumber.Value
        bsWorkOrder.DataSource = oWorkOrder
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oWorkOrder = New Workorder
        oWorkOrder.LoadByPrimaryKey(vID)
        bsWorkOrder.DataSource = oWorkOrder
        getWorkorderItems(vID)
    End Sub


    Private Sub getWorkorderItems(ByVal vID As Integer)
        oWorkOrderItems = New WorkorderitemCollection
        oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Workordernumber.Equal(vID))
        oWorkOrderItems.Query.Load()
        Try
            bsWorkOrderItems.DataSource = oWorkOrderItems
            grWorkOrderItems.DataSource = bsWorkOrderItems
            grWorkOrderItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getFOB()
        oFOB = New ListFobCollection
        oFOB.LoadAll()
        bsFOB.DataSource = oFOB
    End Sub

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.LoadAll()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub getCustomers()
        oCustomers = New CustomerCollection
        oCustomers.LoadAll()
        oCustomers.Sort = "CUSTNAME"
        bsCustomers.DataSource = oCustomers
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

    Private Sub getSuppliers()
        oSuppliers = New SuppliercompanyCollection
        oSuppliers.LoadAll()
        oSuppliers.Sort = "SUPPLIERCOMPANY"
        bsSuppliers.DataSource = oSuppliers
    End Sub

    Private Sub getEmployees()
        oEmployees = New EmployeeCollection
        oEmployees.LoadAll()
        oEmployees.Sort = "EmployeeName"
        bsEmployees.DataSource = oEmployees
    End Sub

    Private Sub saveDataChanges()
        bsWorkOrder.EndEdit()
        bsWorkOrderItems.EndEdit()
        oWorkOrder.EndEdit()
        oWorkOrder.Save()
        oWorkOrderItems.Save()
    End Sub

    Private Sub saveChanges()
        bsWorkOrder.EndEdit()
        bsWorkOrderItems.EndEdit()
        If bsWorkOrderItems.Count <= 0 Then
            MsgBox("You must enter at least one Item to save the work order", MsgBoxStyle.Critical, "Error - No items")
            Exit Sub
        End If
        oWorkOrder.Save()
        oWorkOrderItems.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cancelChanges()
        oWorkOrder.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oWorkOrder.MarkAsDeleted()
                oWorkOrder.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub addWorkOrderItem()
        If IsDBNull(eCustomer.EditValue) Then
            MsgBox("You must select a customer first", MsgBoxStyle.Critical, "Error - No Customer Selected")
            Exit Sub
        End If
        Dim frm As New frmAddNewWorkOrderItem
        frm.vWONum = Me.bsWorkOrder.Current.WorkOrderNumber
        If bsWorkOrder.Current.suppliercompany = "AMERICO CHEMICAL" Then
            frm.vWorkOrderType = "ALLOCATED"
        Else
            frm.vWorkOrderType = ""
        End If
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        frm.vCustID = eCustomer.EditValue
        vResult = frm.ShowDialog()
        getWorkorderItems(vWorkorderNum)
    End Sub

    Private Sub editWorkOrderItem()
        If bsWorkOrderItems.Count <= 0 Then
            Exit Sub
        End If
        If IsDBNull(eCustomer.EditValue) Then
            MsgBox("You must select a customer first", MsgBoxStyle.Critical, "Error - No Customer Selected")
            Exit Sub
        End If
        Dim frm As New frmAddNewWorkOrderItem
        frm.vID = Me.bsWorkOrderItems.Current.WorkOrderItemNumber
        frm.vWONum = Me.bsWorkOrder.Current.WorkOrderNumber
        frm.vEditType = "EDIT"
        If bsWorkOrder.Current.suppliercompany = "AMERICO CHEMICAL" Then
            frm.vWorkOrderType = "ALLOCATED"
        Else
            frm.vWorkOrderType = ""
        End If
        frm.vCustID = eCustomer.EditValue
        frm.ShowDialog()
        getWorkorderItems(vWorkorderNum)
    End Sub

    Private Sub deleteWorkOrderItem()
        If bsWorkOrderItems.Count <= 0 Then
            Exit Sub
        End If
        Dim vConfirm As String = "Are you sure you want to delete the selected Work Order Item?"
        If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        'first unallocate item if necessary to put the inventory item back into circulation
        unAllocateItem()
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand
        Try
            str = "DELETE FROM WORKORDERITEM WHERE WORKORDERITEMNUMBER = " & bsWorkOrderItems.Current.WorkOrderItemNumber.ToString
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try
        MsgBox("Record successfully deleted", MsgBoxStyle.Information, "Success")
        getWorkorderItems(vWorkorderNum)
    End Sub

    Private Sub allocateItem()
        If bsWorkOrderItems.Count <= 0 Then
            Exit Sub
        End If

        Dim frm As New frmAllocateItem
        frm.vItemID = bsWorkOrderItems.Current.WorkOrderItemNumber
        frm.vProductID = bsWorkOrderItems.Current.ProductID
        frm.ShowDialog()
        getWorkorderItems(vWorkorderNum)

    End Sub

    Private Sub unAllocateItem()
        If bsWorkOrderItems.Count <= 0 Then
            Exit Sub
        End If

        'reset Inventory Item if one is already allocated
        Dim vNum As Integer = 0
        If Not bsWorkOrderItems.Current.Invitemnumber Is Nothing Then
            vNum = bsWorkOrderItems.Current.Invitemnumber
            Dim oInvItem As Invitem
            oInvItem = New Invitem
            oInvItem.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            oInvItem.LoadByPrimaryKey(vNum)
            oInvItem.Itemstatus = "AVAILABLE"
            oInvItem.Allocateddate = Nothing
            oInvItem.Allocateddocument = Nothing
            oInvItem.Save()
        End If

        'now reset values for the current work order item
        bsWorkOrderItems.Current.invitemnumber = Nothing
        bsWorkOrderItems.Current.lotnumber = Nothing
        bsWorkOrderItems.Current.warehouselocation = Nothing
        bsWorkOrderItems.EndEdit()
        oWorkOrderItems.Save()
        getWorkorderItems(vWorkorderNum)

    End Sub

    Private Sub grWorkOrderItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        allocateItem()
    End Sub

    Private Sub closeWorkorder()
        Dim str As String = "Are you sure you want to close this work order?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        oWorkOrder.Orderstatus = "CLOSED"
        OrderstatusTextEdit.Text = "CLOSED"
        oWorkOrder.EndEdit()
        oWorkOrder.Save()
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        saveChanges()
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        cancelChanges()
    End Sub

    Private Sub btnAddWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddWOItem.ItemClick
        addWorkOrderItem()
    End Sub

    Private Sub btnEditWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditWOItem.ItemClick
        editWorkOrderItem()
    End Sub

    Private Sub btnDeleteWOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteWOItem.ItemClick
        deleteWorkOrderItem()
    End Sub

    Private Sub btnAllocate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAllocate.ItemClick
        allocateItem()
    End Sub

    Private Sub btnUnallocate_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnUnallocate.ItemClick
        unAllocateItem()
    End Sub

    Private Sub btnMarkClosed_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkClosed.ItemClick
        closeWorkorder()
    End Sub

    Private Sub eCustomer_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eCustomer.EditValueChanged
        getCustomerInfo(eCustomer.EditValue)
    End Sub

    Private Sub getCustomerInfo(ByVal vCustID)

        If vCustID Is Nothing Then
            Exit Sub
        End If

        oCustomer = New Customer
        oCustomer.LoadByPrimaryKey(vCustID)
        If oCustomer Is Nothing Then
            Exit Sub
        End If


        'assume we have a new customer record selected and reset all screen values
        Me.Shipaddress1TextEdit.EditValue = oCustomer.Custshipaddress1
        Me.Shipaddress2TextEdit.EditValue = oCustomer.Custshipaddress2
        Me.ShipcityTextEdit.EditValue = oCustomer.Custshipcity
        Me.ShipstateprovTextEdit.EditValue = oCustomer.Custshipstateprov
        Me.ShippostalcodeTextEdit.EditValue = oCustomer.Custshippostalcode
        Me.ShipcountryTextEdit.EditValue = oCustomer.Custshipcountry
        Me.ShipcontactTextEdit.EditValue = oCustomer.Custshipcontact

        bsWorkOrder.Current.ShipAddress1 = oCustomer.Custshipaddress1
        bsWorkOrder.Current.Shipaddress2 = oCustomer.Custshipaddress2
        bsWorkOrder.Current.Shipcity = oCustomer.Custshipcity
        bsWorkOrder.Current.Shipstateprov = oCustomer.Custshipstateprov
        bsWorkOrder.Current.Shippostalcode = oCustomer.Custshippostalcode
        bsWorkOrder.Current.Shipcountry = oCustomer.Custshipcountry
        bsWorkOrder.Current.Shipcontact = oCustomer.Custshipcontact
        bsWorkOrder.EndEdit()
        oWorkOrder.EndEdit()


        If Not oCustomer.Custnotes Is Nothing Then
            showCustomerNotes(oCustomer.Custid)
        End If

    End Sub

    Private Sub showCustomerNotes(ByVal vCustID)
        Dim frm As New frmAddEditCustomerNotes
        frm.vCustID = vCustID
        frm.ShowDialog()
    End Sub


    Private Sub btnCustomerNotes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCustomerNotes.Click
        If eCustomer.EditValue Is Nothing Then
            Exit Sub
        End If
        showCustomerNotes(eCustomer.EditValue)

    End Sub

    
    Private Sub FreightcarrierLookUpEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles FreightcarrierLookUpEdit.ButtonClick
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

    Private Sub luLogistics_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles luLogistics.ButtonClick
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

    Private Sub rbtnManageInventory_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnManageInventory.ItemClick
        'first, save all changes thus far in the work order/items
        bsWorkOrder.EndEdit()
        bsWorkOrderItems.EndEdit()
        If bsWorkOrderItems.Count <= 0 Then
            MsgBox("You must enter at least one work order item.", MsgBoxStyle.Critical, "Error - No items")
            Exit Sub
        End If
        oWorkOrder.Save()
        oWorkOrderItems.Save()

        Dim frm As New frmAssignInventoryItems
        frm.vProductID = bsWorkOrderItems.Current.ProductID
        frm.vWorkOrderID = bsWorkOrder.Current.WorkOrderNumber
        frm.ShowDialog()
        getWorkorderItems(bsWorkOrder.Current.WorkOrderNumber)
    End Sub
End Class