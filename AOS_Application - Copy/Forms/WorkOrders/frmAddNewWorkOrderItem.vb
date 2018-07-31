Imports AOS.BusinessObjects

Public Class frmAddNewWorkOrderItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vWONum As Integer     'foreign key values (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vWorkOrderType As String
    Public vCustID As Integer
    Public vWorkOrderStatus As String
    Public vCustPO As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Work Order Item"

    'here is where you dimension your object variables for the form
    Dim oItem As Workorderitem
    Dim oProducts As ViewPriceListProductsCollection
    Dim oProduct As Product
    Dim oContainer As Container
    Dim oPriceList As Pricelist
    Dim oPrices As PricelistCollection
    Dim oProductCosts As ProductcostCollection
    Dim oCost As Productcost
    Dim oProductList As ProductCollection
    Dim oCust As Customer

    Dim vShowFinancials As Boolean
    Dim vAllocate As Boolean

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        setProcessFlags()
        getCustomer()
        getProducts("CUSTOMER")
        loadData()
    End Sub

    Private Sub setProcessFlags()
        Select Case vWorkOrderType
            Case "NO BILL"
                vShowFinancials = False
                vAllocate = True
            Case "CONSIGNMENT TRANSFER"
                vShowFinancials = False
                vAllocate = True
            Case "STANDARD"
                vShowFinancials = True
                vAllocate = True
            Case "CONSIGNMENT USAGE"
                vShowFinancials = True
                vAllocate = False
            Case "DIRECT"
                vShowFinancials = True
                vAllocate = False
            Case Else
                vShowFinancials = True
                vAllocate = False
        End Select
    End Sub

    Private Sub getCustomer()
        oCust = New Customer
        If oCust.LoadByPrimaryKey(vCustID) Then
            lblCustomerName.Text = oCust.Custname
        Else
            lblCustomerName.Text = ""
        End If
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub getProducts(vMethod As String)
        Select Case vMethod
            Case "CUSTOMER"
                oProducts = New ViewPriceListProductsCollection
                oProducts.Query.Where(oProducts.Query.Custid.Equal(vCustID))
                oProducts.Query.Load()
                oProducts.Sort = "PRODUCTDESC"
                bsProducts.DataSource = oProducts
            Case "ALL"
                oProductList = New ProductCollection
                oProductList.Query.Where(oProductList.Query.Isactive.Equal(1))
                oProductList.Query.Load()
                oProductList.Sort = "PRODUCTDESC, PRODUCTID"
                bsProducts.DataSource = oProductList
        End Select
    End Sub

    Private Sub addNewObject()
        oItem = New Workorderitem
        oItem.AddNew()
        'assign foreign key values here
        oItem.Workordernumber = vWONum
        oItem.ItemType = "PRODUCT"
        If vShowFinancials Then
            oItem.Billable = True
            eUnitCost.Enabled = True
            eItemPrice.Enabled = True
        Else
            oItem.Billable = False
            eUnitCost.Enabled = False
            eItemPrice.Enabled = False
        End If
        If oItem.Customerpo = "" Then
            oItem.Customerpo = vCustPO
        End If
        oItem.EndEdit()
        oItem.Save()
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Workorderitem
        oItem.LoadByPrimaryKey(vID)
        If vShowFinancials Then
            oItem.Billable = True
            eUnitCost.Enabled = True
            eItemPrice.Enabled = True
        Else
            oItem.Billable = False
            eUnitCost.Enabled = False
            eItemPrice.Enabled = False
        End If
        If oItem.Customerpo = "" Then
            oItem.Customerpo = vCustPO
        End If
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function changesSaved() As Boolean

        bsItem.EndEdit()
        Dim vItemQty As Decimal
        If bsItem.Current.unitorContainer = "C" Then
            vItemQty = bsItem.Current.qty * bsItem.Current.units
        Else
            vItemQty = bsItem.Current.qty
        End If

        Select Case vShowFinancials
            Case True
                If bsItem.Current.billable = True Then
                    bsItem.Current.itemProfit = bsItem.Current.itemPrice - bsItem.Current.unitCost
                Else
                    bsItem.Current.itemProfit = 0
                End If
                bsItem.EndEdit()
                If bsItem.Current.itemProfit < 0 Then
                    If MsgBox("Are you sure you want to bill this item at a loss", MsgBoxStyle.YesNo, "Confirm - Loss On Sale") = MsgBoxResult.No Then
                        Return False
                    End If
                End If
                bsItem.Current.extPrice = vItemQty * bsItem.Current.itemPrice
                bsItem.Current.extCost = vItemQty * bsItem.Current.unitCost
                bsItem.Current.extProfit = bsItem.Current.extPrice - bsItem.Current.extCost
            Case False
                bsItem.Current.unitCost = 0.0
                bsItem.Current.itemPrice = 0.0
                bsItem.Current.itemProfit = 0.0
                bsItem.Current.extPrice = 0.0
                bsItem.Current.extCost = 0.0
                bsItem.Current.extProfit = 0.0
        End Select

        bsItem.EndEdit()
        oItem.EndEdit()
        oItem.Save()

        If vAllocate Then
            Dim vQty As Integer = bsItem.Current.qty
            If vQty > 1 Then
                addMultipleEntries(vQty)
            End If
        End If

        oItem.EndEdit()
        oItem.Save()

        Return True

    End Function

    Private Sub addMultipleEntries(ByVal vQty As Integer)
        vQty = vQty - 1     'to avoid adding one too many records, since we already have one
        Dim oItemAdd As Workorderitem
        Dim vItemQty As Integer = 0
        For x As Integer = 1 To vQty
            oItemAdd = New Workorderitem
            oItemAdd.AddNew()
            oItemAdd.Workordernumber = vWONum
            oItemAdd.Productid = oItem.Productid
            oItemAdd.Productdesc = oItem.Productdesc
            oItemAdd.Itemtype = oItem.Itemtype
            oItemAdd.Customerpo = oItem.Customerpo
            oItemAdd.Container = oItem.Container
            oItemAdd.Qty = 1
            oItemAdd.Unitorcontainer = oItem.Unitorcontainer
            oItemAdd.Units = oItem.Units
            oItemAdd.Uom = oItem.Uom
            Select Case vShowFinancials
                Case True
                    oItemAdd.Unitcost = oItem.Unitcost
                    oItemAdd.Itemprice = oItem.Itemprice
                    oItemAdd.Itemprofit = oItem.Itemprofit
                    oItemAdd.Billable = oItem.Billable
                    If oItemAdd.Unitorcontainer = "C" Then
                        vItemQty = oItemAdd.Units
                    Else
                        vItemQty = 1
                    End If
                    oItemAdd.Extprice = vItemQty * oItemAdd.Itemprice
                    oItemAdd.Extcost = vItemQty * oItemAdd.Unitcost
                    oItemAdd.Extprofit = oItemAdd.Extprice - oItemAdd.Extcost
                Case False
                    oItemAdd.Unitcost = 0.0
                    oItemAdd.Itemprice = 0.0
                    oItemAdd.Itemprofit = 0.0
                    oItemAdd.Extprice = 0.0
                    oItemAdd.Extcost = 0.0
                    oItemAdd.Extprofit = 0.0
                    oItemAdd.Billable = False
            End Select
            oItemAdd.Save()
        Next

        Select Case vShowFinancials
            Case True
                oItem.Qty = 1
                oItem.Extprice = vItemQty * oItem.Itemprice
                oItem.Extcost = vItemQty * oItem.Unitcost
                oItem.Extprofit = oItem.Extprice - oItem.Extcost
            Case False
                oItem.Qty = 1
                oItem.Extprice = 0.0
                oItem.Extcost = 0.0
                oItem.Extprofit = 0.0
        End Select

        oItem.Save()

    End Sub

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
        If eProduct.EditValue Is Nothing Then
            Exit Sub
        End If
        If IsDBNull(sender.EditValue) Then
            Exit Sub
        End If
        getProductInfo(sender.editValue)
        getProductCostInfo(sender.editvalue)
        getPricingInfo(sender.editvalue, vCustID)
    End Sub

    Private Sub getProductInfo(ByVal vProdID As Integer)
        oProduct = New Product
        If oProduct.LoadByPrimaryKey(vProdID) Then
            eContainer.EditValue = oProduct.Container
            bsItem.EndEdit()
        End If
    End Sub

    Private Sub getProductCostInfo(ByVal vProdID As Integer)

        'if no financial required, set to zero
        If vShowFinancials = False Then
            eUnits.EditValue = ""
            eUOM.EditValue = ""
            eUnitCost.EditValue = 0.0
            bsItem.EndEdit()
            Exit Sub
        End If

        oProductCosts = New ProductcostCollection
        oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdID))
        oProductCosts.Query.Load()
        Select Case oProductCosts.Count
            Case Is = 1
                eUnits.EditValue = oProductCosts(0).Units
                eUOM.EditValue = oProductCosts(0).Uom
                eUnitCost.EditValue = oProductCosts(0).Unitcost
                bsItem.EndEdit()
            Case Else
                Dim frm As New frmViewProductCostRecords
                frm.vProductID = vProdID
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    eUnits.EditValue = frm.oCost.Units
                    eUOM.EditValue = frm.oCost.Uom
                    eUnitCost.EditValue = frm.oCost.Unitcost
                    bsItem.EndEdit()
                End If
        End Select
    End Sub

    Private Sub getPricingInfo(ByVal vProdID As Integer, ByVal vCustID As Integer)

        'if financials are not required, set to zero
        If vShowFinancials = False Then
            eItemPrice.EditValue = 0.0
            bsItem.EndEdit()
            Exit Sub
        End If

        oPrices = New PricelistCollection
        oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdID), oPrices.Query.Custid.Equal(vCustID))
        oPrices.Query.Load()
        Select oPrices.Count
            Case Is = 1
                eItemPrice.EditValue = oPrices(0).Unitprice
                bsItem.EndEdit()
            Case Else
                Dim frm As New frmViewPriceListRecords
                frm.vProductID = vProdID
                frm.vCustomerID = vCustID
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    eItemPrice.EditValue = frm.oPrice.Unitprice
                    bsItem.EndEdit()
                End If
        End Select
    End Sub

    Private Sub eItemPrice_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eItemPrice.ButtonClick
        If IsDBNull(oItem.Productid) Then
            MsgBox("You must select a product first", MsgBoxStyle.Critical, "Error - No product selected")
            Exit Sub
        End If

        Dim frm As New frmViewPriceListRecords
        frm.vProductID = oItem.Productid
        frm.vCustomerID = vCustID
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            eItemPrice.EditValue = frm.oPrice.Unitprice
            bsItem.EndEdit()
        Else
            MsgBox("No Price List record selected", MsgBoxStyle.Information, "Price List")
        End If

    End Sub

    Private Sub eUnitCost_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eUnitCost.ButtonClick
        If IsDBNull(oItem.Productid) Then
            MsgBox("You must select a product first", MsgBoxStyle.Critical, "Error - No product selected")
            Exit Sub
        End If
        Dim frm As New frmViewProductCostRecords
        frm.vProductID = oItem.Productid
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            eUnitCost.EditValue = frm.oCost.Unitcost
            eUnits.EditValue = frm.oCost.Units
            eUOM.EditValue = frm.oCost.Uom
            bsItem.EndEdit()
        Else
            MsgBox("no product cost record selected")
        End If
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub rbtnGetAllProducts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGetAllProducts.ItemClick
        getProducts("ALL")
    End Sub
End Class