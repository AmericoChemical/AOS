Imports AOS.BusinessObjects

Public Class frmEnterGrossWeight
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vRecvrNum As Integer     'foreign key values (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vWhseID As Integer
    Public vVendorID As Integer
    Private vItemVendorID As Integer = 0

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Receiver Item"

    'here is where you dimension your object variables for the form
    Dim oItem As Receiveritem
    Dim oProducts As ProductCollection
    Dim oWhse As WarehouseCollection
    Dim oLocs As ListWarehouselocationCollection
    Dim oProduct As Product
    Dim oContainer As Container
    Dim oProductCosts As ProductcostCollection
    Dim oInvClass As ListInventoryclassCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getProducts()
        getLocations(vWhseID)
        getInventoryClassLU()
        loadData()
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.Query.Where(oProducts.Query.Isactive.Equal(1))
        oProducts.Query.Load()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub getInventoryClassLU()
        oInvClass = New ListInventoryclassCollection
        oInvClass.LoadAll()
        bsInventoryClass.DataSource = oInvClass
    End Sub

    Private Sub getLocations(ByVal vWhse As Integer)
        oLocs = New ListWarehouselocationCollection
        oLocs.Query.Where(oLocs.Query.Warehouseid.Equal(vWhse))
        oLocs.Query.Load()
        oLocs.Sort = "Warehouselocation"
        bsLocations.DataSource = oLocs
    End Sub

    Private Sub addNewObject()
        oItem = New Receiveritem
        'assign foreign key values here
        oItem.Receivernumber = vRecvrNum
        oItem.Warehousenumber = vWhseID
        oItem.Unitorcontainer = "C"
        oItem.Posted = "N"
        oItem.EndEdit()
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Receiveritem
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsItem.EndEdit()
            oItem.EndEdit()
            oItem.Save()
            If oItem.Qtyreceived <= 0 Or oItem.Qtyreceived Is Nothing Then
                MsgBox("You must enter a quantity received", MsgBoxStyle.Critical, "Error - No Quantity")
                Me.QtyreceivedTextEdit.Focus()
                Return False
            End If
            If oItem.Warehouselocation Is Nothing Then
                MsgBox("You must enter a bin (warehouse location)", MsgBoxStyle.Critical, "Error - No Bin")
                Me.WarehouselocationLookUpEdit.Focus()
                Return False
            End If
            If IsDBNull(oItem.Unitcost) Or oItem.Unitcost Is Nothing Then
                MsgBox("You must enter a Unit Cost for this item - Cost can be $0.00", MsgBoxStyle.Critical, "Error - No Cost")
                eUnitCost.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsItem.CancelEdit()
            oItem.CancelEdit()
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
        End Try

        Return True
    End Function

    Private Sub eProduct_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eProduct.EditValueChanged
        getProductCostInfo(sender.editvalue)
    End Sub

    Private Sub getProductCostInfo(ByVal vProdID As Integer)

        oProduct = New Product
        If Not oProduct.LoadByPrimaryKey(vProdID) Then
            MsgBox("Could not find product information")
            Exit Sub
        End If

        'we now have the product record 
        eProductDesc.EditValue = oProduct.Productdesc
        eContainer.EditValue = oProduct.Container
        eInventoryClass.EditValue = oProduct.Inventoryclass
        bsItem.EndEdit()

        oProductCosts = New ProductcostCollection
        oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdID))
        oProductCosts.Query.Load()
        Select Case oProductCosts.Count
            Case Is = 1
                eUnits.EditValue = oProductCosts(0).Units
                eUOM.EditValue = oProductCosts(0).Uom
                eUnitCost.EditValue = oProductCosts(0).Unitcost
                If IsDBNull(oProductCosts(0).Vendorid) Or oProductCosts(0).Vendorid Is Nothing Then
                    vItemVendorID = 0
                Else
                    vItemVendorID = oProductCosts(0).Vendorid
                End If
                bsItem.EndEdit()
            Case Else
                'open a form to select the product cost record desired for the current product
                Dim frm As New frmViewProductCostRecords
                frm.vProductID = vProdID
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    eUnits.EditValue = frm.oCost.Units
                    eUOM.EditValue = frm.oCost.Uom
                    eUnitCost.EditValue = frm.oCost.Unitcost
                    If IsDBNull(oProductCosts(0).Vendorid) Or oProductCosts(0).Vendorid Is Nothing Then
                        vItemVendorID = 0
                    Else
                        vItemVendorID = oProductCosts(0).Vendorid
                    End If
                    bsItem.EndEdit()
                End If
        End Select

    End Sub

    Private Sub UnitcostButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eUnitCost.ButtonClick

        If IsDBNull(eProduct.EditValue) Then
            Exit Sub
        End If
        If eProduct.EditValue Is Nothing Then
            Exit Sub
        End If

        Dim frm As New frmViewProductCostRecords
        frm.vProductID = eProduct.EditValue
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            eUnits.EditValue = frm.oCost.Units
            eUOM.EditValue = frm.oCost.Uom
            eUnitCost.EditValue = frm.oCost.Unitcost
            bsItem.EndEdit()
        End If

    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
End Class