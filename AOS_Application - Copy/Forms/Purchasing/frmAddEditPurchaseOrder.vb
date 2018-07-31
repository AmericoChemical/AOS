
Imports AOS.BusinessObjects

Public Class frmAddEditPurchaseOrder
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vPONum As Integer
    Public vEditType As String

    Dim oProducts As ProductCollection
    Dim oPO As Po
    Dim oPOItems As PoitemCollection
    Dim oVendors As VendorCollection
    Dim oParms As Sysparameters
    Dim oVendor As Vendor
    Dim oCustomers As CustomerCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getParms()
        getProducts()
        getVendors()
        getCustomers()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vPONum)
        End If
    End Sub

    Private Sub addNewObject()
        oPO = New Po
        oPO.AddNew()
        oPO.Podate = Today
        oPO.Postatus = "OPEN"
        oPO.Poterms = "NET 30"
        oPO.Potype = "REGULAR"
        oPO.Custid = 160    'Americo Chemical Products, Inc. by default'
        lookupCustomerData(160)
        oPO.Save()
        vPONum = oPO.Ponumber.Value
        oPO.Changeableponumber = oPO.Ponumber
        oPO.Save()
        bsPO.DataSource = oPO
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oPO = New Po
        oPO.LoadByPrimaryKey(vID)
        bsPO.DataSource = oPO
        getPOItems(vID)
    End Sub

    Private Sub getPOItems(ByVal vID As Integer)
        oPOItems = New PoitemCollection
        oPOItems.Query.Where(oPOItems.Query.Ponumber.Equal(vID))
        oPOItems.Query.Load()
        Try
            bsPOItems.DataSource = oPOItems
            grPOItems.DataSource = bsPOItems
            grPOItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        calcPOTotal(vID)
    End Sub

    Private Function calcPOTotal(ByVal vPONum As Integer) As Decimal

        Dim str As String = "SELECT SUM(EXTCOST) FROM POITEM WHERE PONUMBER = " & vPONum.ToString
        Dim cmd As SqlClient.SqlCommand
        Dim vSum As Decimal = 0.0
        Try
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            vSum = IIf(IsDBNull(cmd.ExecuteScalar), 0, cmd.ExecuteScalar)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If sqlcnn.State = ConnectionState.Open Then
                sqlcnn.Close()
            End If
        End Try

        Return vSum

        'str = "UPDATE PO SET POSUBTOTAL = " & vSum.ToString & ", POTOTAL = " & vSum.ToString & " WHERE PONumber = " & vPONum.ToString
        'Try
        '    sqlcnn.Open()
        '    cmd = New SqlClient.SqlCommand(str, sqlcnn)
        '    cmd.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    If sqlcnn.State = ConnectionState.Open Then
        '        sqlcnn.Close()
        '    End If
        'End Try

    End Function

    Private Sub getParms()
        oParms = New Sysparameters
        oParms.LoadByPrimaryKey(1)
    End Sub

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.LoadAll()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub getVendors()
        oVendors = New VendorCollection
        oVendors.LoadAll()
        oVendors.Sort = "VENDORNAME"
        bsVendors.DataSource = oVendors
    End Sub

    Private Sub getCustomers()
        oCustomers = New CustomerCollection
        oCustomers.LoadAll()
        oCustomers.Sort = "CUSTNAME"
        bsCustomers.DataSource = oCustomers
    End Sub

    Private Sub saveChanges()

        bsPOItems.EndEdit()
        If bsPOItems.Count <= 0 Then
            MsgBox("You must enter at least one Item to save the work order", MsgBoxStyle.Critical, "Error - No items")
            Exit Sub
        End If
        oPO.Posubtotal = calcPOTotal(bsPO.Current.PONumber)
        oPO.Pototal = calcPOTotal(bsPO.Current.PONumber)
        oPO.EndEdit()
        bsPO.EndEdit()
        oPO.Save()
        If oPO.Changeableponumber Is Nothing Then
            oPO.Changeableponumber = oPO.Ponumber
            oPO.Save()
        End If
        oPOItems.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub cancelChanges()
        oPO.CancelEdit()
        Try
            If vEditType = "ADD" Then
                Dim oPOItemsList As New PoitemCollection
                oPOItemsList.Query.Where(oPOItemsList.Query.Ponumber.Equal(oPO.Ponumber))
                For Each oPOItem As Poitem In oPOItemsList
                    oPOItem.MarkAsDeleted()
                    oPOItem.Save()
                Next
                oPO.MarkAsDeleted()
                oPO.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub addPOItem()
        If IsDBNull(eVendor.EditValue) Then
            MsgBox("You must select a Vendor first", MsgBoxStyle.Critical, "Error - No Vendor Selected")
            Exit Sub
        End If
        Dim frm As New frmAddEditPurchaseOrderItem
        frm.vPONum = Me.bsPO.Current.PONumber
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        frm.vVendorID = eVendor.EditValue
        vResult = frm.ShowDialog()
        getPOItems(Me.bsPO.Current.PONumber)
    End Sub

    Private Sub editPOItem()
        If bsPOItems.Count <= 0 Then
            Exit Sub
        End If
        If IsDBNull(eVendor.EditValue) Then
            MsgBox("You must select a Vendor first", MsgBoxStyle.Critical, "Error - No Vendor Selected")
            Exit Sub
        End If
        If bsPOItems.Current.UOM = "MISC" Then
            Dim frmMisc As New frmAddEditPOMiscItem
            frmMisc.vID = Me.bsPOItems.Current.POItemNumber
            frmMisc.vPONumber = Me.bsPO.Current.PONumber
            frmMisc.vEditType = "EDIT"
            frmMisc.ShowDialog()
        Else
            Dim frm As New frmAddEditPurchaseOrderItem
            frm.vID = Me.bsPOItems.Current.POItemNumber
            frm.vPONum = Me.bsPO.Current.PONumber
            frm.vEditType = "EDIT"
            frm.vVendorID = eVendor.EditValue
            frm.ShowDialog()
        End If
        getPOItems(Me.bsPO.Current.PONumber)
    End Sub

    Private Sub deletePOItem()
        If bsPOItems.Count <= 0 Then
            Exit Sub
        End If
        Dim vConfirm As String = "Are you sure you want to delete the selected Purchase Order Item?"
        If MsgBox(vConfirm, MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand
        Try
            str = "DELETE FROM POITEM WHERE POITEMNUMBER = " & bsPOItems.Current.POItemNumber.ToString
            sqlcnn.Open()
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlcnn.Close()
        End Try
        MsgBox("Record successfully deleted", MsgBoxStyle.Information, "Success")
        getPOItems(Me.bsPO.Current.PONumber)
    End Sub

    Private Sub addMiscCharge()
        Dim frm As New frmAddEditPOMiscItem
        frm.vPONumber = Me.bsPO.Current.PONumber
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getPOItems(Me.bsPO.Current.PONumber)
    End Sub

    Private Sub closePO()
        Dim str As String = "Are you sure you want to close this purchase order?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        oPO.Postatus = "CLOSED"
        ePOStatus.Text = "CLOSED"
        oPO.EndEdit()
        oPO.Save()
    End Sub

    Private Sub reOpenPO()
        Dim str As String = "Are you sure you want to re-open this purchase order?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        oPO.Postatus = "OPEN"
        ePOStatus.Text = "OPEN"
        oPO.EndEdit()
        oPO.Save()
    End Sub


    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        saveChanges()
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        cancelChanges()
    End Sub

    Private Sub btnAddPOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddPOItem.ItemClick
        addPOItem()
    End Sub

    Private Sub btnEditPOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditPOItem.ItemClick
        editPOItem()
    End Sub

    Private Sub btnDeletePOItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeletePOItem.ItemClick
        deletePOItem()
    End Sub

    Private Sub btnMarkClosed_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMarkClosed.ItemClick
        closePO()
    End Sub

    Private Sub btnMiscCharge_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMiscCharge.ItemClick
        addMiscCharge()
    End Sub

    Private Sub btnReOpenPO_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReOpenPO.ItemClick
        reOpenPO()
    End Sub

    Private Sub eVendor_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eVendor.EditValueChanged
        getVendorInfo(eVendor.EditValue)
    End Sub
    Private Sub getVendorInfo(ByVal vVendorID)
        If vVendorID Is Nothing Or vVendorID Is DBNull.Value Then
            Exit Sub
        End If

        oVendor = New Vendor
        oVendor.LoadByPrimaryKey(vVendorID)
        If oVendor Is Nothing Then
            Exit Sub
        End If

        If Not oVendor.Vendornotes Is Nothing Then
            showVendorNotes(oVendor.Vendorid)
        End If

    End Sub

    Private Sub showVendorNotes(ByVal vID)
        Dim frm As New frmAddEditVendorNotes
        frm.vVendorID = vID
        frm.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If eVendor.EditValue Is Nothing Then
            Exit Sub
        End If
        showVendorNotes(eVendor.EditValue)
    End Sub

    Private Sub btnPrintPurchaseOrder_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintPurchaseOrder.ItemClick
        bsPOItems.EndEdit()
        If bsPOItems.Count <= 0 Then
            MsgBox("You must enter at least one Item to save the work order", MsgBoxStyle.Critical, "Error - No items")
            Exit Sub
        End If
        oPO.Posubtotal = calcPOTotal(bsPO.Current.PONumber)
        oPO.Pototal = calcPOTotal(bsPO.Current.PONumber)
        oPO.EndEdit()
        bsPO.EndEdit()
        oPO.Save()
        If oPO.Changeableponumber Is Nothing Then
            oPO.Changeableponumber = oPO.Ponumber
            oPO.Save()
        End If
        oPOItems.Save()
        printPO()
    End Sub

    Private Sub printPO()
        If bsPO.Count <= 0 Then
            Exit Sub
        End If
        Dim vNum As Integer
        vNum = bsPO.Current.PONumber
        Dim rpt As New rptPurchaseOrder(vNum)
        rpt.ShowPreview()
    End Sub

    Private Sub luCustomer_EditValueChanged(sender As Object, e As System.EventArgs) Handles luCustomer.EditValueChanged
        'lookup Customer information and reset Shipping Address details
        If IsDBNull(luCustomer.EditValue) Or luCustomer.EditValue Is Nothing Then
            Exit Sub
        End If
        Dim oCust As New Customer
        Try
            oCust.LoadByPrimaryKey(luCustomer.EditValue)
            eCompany.Text = oCust.Custname
            eAddress1.Text = oCust.Custshipaddress1
            eAddress2.Text = oCust.Custshipaddress2
            eCity.Text = oCust.Custshipcity
            eState.Text = oCust.Custshipstateprov
            eZip.Text = oCust.Custshippostalcode
            eContact.Text = oCust.Custshipcontact
            ePhone.Text = oCust.Custphone
            bsPO.EndEdit()
        Catch ex As Exception
            MsgBox("Could not lookup selected Customer", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub

    Private Sub lookupCustomerData(vCustomerKey As Integer)
        Dim oCust As New Customer
        Try
            oCust.LoadByPrimaryKey(vCustomerKey)
            oPO.Shipname = oCust.Custname
            oPO.Shipaddress1 = oCust.Custshipaddress1
            oPO.Shipaddress2 = oCust.Custshipaddress2
            oPO.Shipcity = oCust.Custshipcity
            oPO.Shipstate = oCust.Custshipstateprov
            oPO.Shipzip = oCust.Custshippostalcode
            oPO.Shipcontact = oCust.Custshipcontact
            oPO.Shipphone = oCust.Custphone
            oPO.Save()
        Catch ex As Exception
            MsgBox("Could not lookup selected Customer", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

End Class