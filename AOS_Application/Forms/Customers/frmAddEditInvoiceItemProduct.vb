Imports AOS.BusinessObjects

Public Class frmAddEditInvoiceItemProduct
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (InvoiceItemNumber) (passed in by calling form for edit mode)
    Public vFKID As Integer     'foreign key values (InvoiceNumber) (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vCustID As Integer   'Customer ID from Invoice to which you are adding/editing item
    Public vTaxExempt As Boolean  'Customer may be marked in database as tax exempt, if so, Taxable control should be invisible

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Invoice Item"

    'here is where you dimension your object variables for the form
    Dim oItem As Invoiceitem
    Dim oProducts As ProductCollection
    Dim oProductCosts As ProductcostCollection
    Dim oPricelist As Pricelist
    Dim oPrices As PricelistCollection
    Dim oProduct As Product = Nothing
    Dim oContainer As Container = Nothing


    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If vTaxExempt Then
            Me.lblTaxable.Visible = False
            Me.eTaxable.Visible = False
        End If
        getProducts()
        getCustomer(vCustID)
        loadData()
    End Sub

    Private Sub getCustomer(vCustID As Integer)
        Dim oCustomer As New Customer
        oCustomer.LoadByPrimaryKey(vCustID)
        eCustomerName.Text = oCustomer.Custname
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
        oProducts.LoadAll()
        oProducts.Sort = "ProductDesc"
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub addNewObject()
        oItem = New Invoiceitem
        oItem.AddNew()
        'assign foreign key values here
        oItem.Invoicenumber = vFKID
        oItem.Itemtype = "PRODUCT"
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Invoiceitem
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function changesSaved() As Boolean
        Try
            oItem.Productdesc = eProduct.Text
            oItem.Itemid = oItem.Productid
            oItem.Itemdescription = oItem.Productdesc
            oItem.Uom = oItem.Priceuom
            oItem.Units = oItem.Priceunits
            bsItem.EndEdit()
            oItem.EndEdit()
            oItem.Save()

            Select Case oItem.Unitorcontainer  'this is how the quantity value on the WORKORDER was determined - by containers or units - different than how it should be billed
                Case "C"
                    oItem.Extsalesprice = oItem.Quantity * oItem.Priceunits * oItem.Unitprice
                    oItem.Itemprice = oItem.Priceunits * oItem.Unitprice
                Case Else
                    oItem.Extsalesprice = oItem.Quantity * oItem.Unitprice
                    oItem.Itemprice = oItem.Unitprice
            End Select

            'For Legacy processes
            oItem.Extprice = oItem.Extsalesprice
            oItem.Grossprofit = oItem.Extprice - oItem.Extcost
            oItem.Uom = oItem.Priceuom

            oItem.EndEdit()
            oItem.Save()

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
        If eProduct.EditValue Is Nothing Then
            Exit Sub
        End If

        getProductData(eProduct.EditValue)

        'getProductInfo(sender.editValue)
        'getProductCostInfo(sender.editvalue)
        'getPricingInfo(sender.editvalue, vCustID)
    End Sub

    Private Sub getProductData(vProdID As Integer)
        'REL 14.2 - AMERICO - MCGUIRE - 08/14/2014

        'Step 1 - Get all reference field data from PRODUCT table for Product ID, including Standard Costing

        oProduct = New Product
        If oProduct.LoadByPrimaryKey(vProdID) Then
            oItem.Container = oProduct.Container
            oItem.Productid = oProduct.Productid
            oItem.Productdesc = oProduct.Productdesc
            oItem.Units = oProduct.Units
            oItem.Uom = oProduct.Uom
        End If

        'Step 2 - Get Product Pricing from PRICELIST table for ProductID/CustomerID

        'preserve existing sales price in workorderitem in case the user has previously adjusted the 
        'sales price of the item for this workorder only
        Dim vKeepPrice As Boolean = False
        Dim vCurrentPrice As Decimal = 0.0
        Dim vLookupPrice As Decimal = 0.0

        vCurrentPrice = IIf(IsDBNull(oItem.Unitprice), 0.0, oItem.Unitprice)

        Dim oPriceRec As Pricelist
        oPriceRec = getPriceListRecord(vProdID, vCustID)

        'check to see if there has been a price adjustment - if so, ask user if they want to keep price change
        Select Case oPriceRec.Pricingmethod
            Case "VOLUME"
                vLookupPrice = oPriceRec.Volumeprice
            Case "WEIGHT"
                vLookupPrice = oPriceRec.Weightprice
            Case Else
                vLookupPrice = 0.0
        End Select
        If vLookupPrice > 0.0 And vCurrentPrice > 0.0 And vCurrentPrice <> vLookupPrice Then
            If MsgBox("There has been a previous price adjustment to this item. Do you want to keep this price adjustment and NOT the default price?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "CONFIRM - Price Adjustment") = MsgBoxResult.Yes Then
                vKeepPrice = True
            End If
        End If

        Select Case oPriceRec.Pricingmethod
            Case "VOLUME"
                oItem.Priceunits = oPriceRec.Volumeunits
                oItem.Priceuom = oPriceRec.Volumeuom
                If vKeepPrice Then
                    oItem.Unitprice = vCurrentPrice
                Else
                    oItem.Unitprice = vLookupPrice
                End If
            Case "WEIGHT"
                oItem.Priceunits = oPriceRec.Weightunits
                oItem.Priceuom = oPriceRec.Weightuom
                If vKeepPrice Then
                    oItem.Unitprice = vCurrentPrice
                Else
                    oItem.Unitprice = vLookupPrice
                End If
            Case Else
                'This situation would most likely occur if NO PRICELIST record was returned
                'or the PRICELIST record was not correctly completed and there is no value
                'for the PricingMethod field in the PRICELIST record
                'Set the Pricing information to ZERO
                oItem.Priceunits = 0.0
                oItem.Priceuom = ""
                oItem.Unitprice = 0.0
        End Select
        
        'Step 3 - Set STANDARD (CHEMICAL ONLY) COSTING for selected Product (we already have the PRODUCT record selected and available)

            Select Case oPriceRec.Pricingmethod
                Case "VOLUME"
                    oItem.Standardcostunits = oProduct.Volumeunits
                    oItem.Standardcostuom = oProduct.Volumeuom
                    oItem.Standardunitcost = oProduct.Volumestandardcost
                Case "WEIGHT"
                    oItem.Standardcostunits = oProduct.Weightunits
                    oItem.Standardcostuom = oProduct.Weightuom
                    oItem.Standardunitcost = oProduct.Weightstandardcost
                Case Else
                    'This situation would most likely occur if NO PRICELIST record was returned
                    'or the PRICELIST record was not correctly completed and there is no value
                    'for the PricingMethod field in the PRICELIST record
                    'Set the STANDARD COSTING information according to the INVENTORY METHOD setting
                    'in the PRODUCT record
                    Select Case oProduct.Inventorymethod
                        Case "VOLUME"
                            oItem.Standardcostunits = oProduct.Volumeunits
                            oItem.Standardcostuom = oProduct.Volumeuom
                            oItem.Standardunitcost = oProduct.Volumestandardcost
                        Case "WEIGHT"
                            oItem.Standardcostunits = oProduct.Weightunits
                            oItem.Standardcostuom = oProduct.Weightuom
                            oItem.Standardunitcost = oProduct.Weightstandardcost
                        Case Else
                            MsgBox("No Inventory method is established for the selected product. Standard Cost cannot be determined", MsgBoxStyle.Critical, "Error Missing Data")
                            oItem.Standardcostunits = 0
                            oItem.Standardcostuom = ""
                            oItem.Standardunitcost = 0
                    End Select
            End Select
        
        'Step 4 - Set CUSTOMER PRODUCT CODE from PRICELIST for selected Item (Product)

        oItem.Custitemid = oPriceRec.Customerproductcode


        'Setp 5 - Calculate Quantity, Extended Sales Price, Standard Costs, and Actual Costs
        Select Case oItem.Unitorcontainer  'this is how the quantity value on the WORKORDER was determined - by containers or units - different than how it should be billed
            Case "C"
                oItem.Extsalesprice = oItem.Quantity * oItem.Priceunits * oItem.Unitprice
                oItem.Extstandardcost = oItem.Quantity * oItem.Standardcostunits * oItem.Standardunitcost
                oItem.Extactualcost = oItem.Quantity * oItem.Actualcostunits * oItem.Actualunitcost
                oItem.Itemprice = oItem.Priceunits * oItem.Unitprice
            Case Else
                oItem.Extsalesprice = oItem.Quantity * oItem.Unitprice
                oItem.Extstandardcost = oItem.Quantity * oItem.Standardunitcost
                oItem.Extactualcost = oItem.Quantity * oItem.Actualunitcost
                oItem.Itemprice = oItem.Unitprice
        End Select

        'For Legacy processes
        oItem.Extprice = oItem.Extsalesprice
        oItem.Extcost = oItem.Extstandardcost
        oItem.Grossprofit = oItem.Extprice - oItem.Extcost
        oItem.Uom = oItem.Priceuom

        oItem.EndEdit()
        oItem.Save()

        bsItem.DataSource = oItem
        bsItem.ResetBindings(False) ' Refresh the controls - False indicate that there is only data changes

    End Sub

    Private Function getPriceListRecord(vProdid As Integer, vCustID As Integer) As Pricelist

        Dim oPriceRec As New Pricelist
        Dim vLookupPrice As Decimal = 0.0
        Dim vCurrentPrice As Decimal = 0.0

        'REL 14.2 - AMERICO - MCGUIRE - 08/14/2014
        'This method fetches the current PRICELIST record for a PRODUCT / CUSTOMER combination
        'There should always be no more than 1 record for a PRODUCT / CUSTOMER combination
        'There can be situations where there are NO records in the PRICELIST table for a PRODUCT / CUSTOMER combination
        'The user has the option to accept the LookUp Price (from the PRICELIST table) or override that value 
        'for this single WORKORDERITEM record only

        'set the price that is currently assigned to this WorkOrderItem
        If Not IsDBNull(bsItem.Current.ItemPrice) Then
            vCurrentPrice = bsItem.Current.ItemPrice
        Else
            vCurrentPrice = 0.0
        End If

        'Get PRICELIST Record and return it to the calling method
        oPrices = New PricelistCollection
        oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdid), oPrices.Query.Custid.Equal(vCustID), oPrices.Query.Effectivedate.LessThanOrEqual(Now.Date)).OrderBy(oPrices.Query.Effectivedate.Descending)
        oPrices.Query.Load()
        Select Case oPrices.Count
            Case Is > 0
                Return oPrices(0)
            Case Else
                MsgBox("The product you selected is not in the Customer's price list.", MsgBoxStyle.Critical, "Error - Price List")
                Return oPriceRec
        End Select
    End Function

    'Private Sub getProductInfo(ByVal vProdID As Integer)
    '    oProduct = New Product
    '    If oProduct.LoadByPrimaryKey(vProdID) Then
    '        eContainer.EditValue = oProduct.Container
    '        bsItem.EndEdit()
    '    End If
    'End Sub

    'Private Sub getProductCostInfo(ByVal vProdID As Integer)
    '    oProductCosts = New ProductcostCollection
    '    oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdID))
    '    oProductCosts.Query.Load()
    '    Select Case oProductCosts.Count
    '        Case Is = 1
    '            eUnits.EditValue = oProductCosts(0).Units
    '            eUOM.EditValue = oProductCosts(0).Uom
    '            eUnitCost.EditValue = oProductCosts(0).Unitcost
    '            bsItem.EndEdit()
    '        Case Else
    '            Dim frm As New frmViewProductCostRecords
    '            frm.vProductID = vProdID
    '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                eUnits.EditValue = frm.oCost.Units
    '                eUOM.EditValue = frm.oCost.Uom
    '                eUnitCost.EditValue = frm.oCost.Unitcost
    '                bsItem.EndEdit()
    '            End If
    '    End Select
    'End Sub

    'Private Sub getPricingInfo(ByVal vProdID As Integer, ByVal vCustID As Integer)

    '    Dim vPriceID As Integer

    '    oPrices = New PricelistCollection
    '    oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdID), oPrices.Query.Custid.Equal(vCustID))
    '    oPrices.Query.Load()
    '    Select Case oPrices.Count
    '        Case Is = 1
    '            vPriceID = oPrices(0).Pricelistid
    '        Case Else
    '            Dim frm As New frmViewPriceListRecords
    '            frm.vProductID = vProdID
    '            frm.vCustomerID = vCustID
    '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '                vPriceID = frm.oPrice.Pricelistid
    '            End If
    '    End Select

    '    If vPriceID = 0 Then
    '        MsgBox("No pricing records found.", MsgBoxStyle.Information, "No Pricing Records")
    '        Exit Sub
    '    End If

    '    'fetch pricing object
    '    oPriceList = New Pricelist
    '    If Not oPricelist.LoadByPrimaryKey(vPriceID) Then
    '        MsgBox("No Pricing Records were retrieved", MsgBoxStyle.Critical, "Error - No Pricing Records")
    '        Exit Sub
    '    End If

    '    'we have now isolated the pricing record we want
    '    'now set all relate invoice item data fields
    '    eItemPrice.EditValue = oPricelist.Unitprice
    '    If Not vTaxExempt Then
    '        eTaxable.EditValue = oPricelist.Taxable
    '    End If

    '    eUC.EditValue = oPricelist.Unitorcontainer
    '    bsItem.EndEdit()
    'End Sub

    'Private Sub setItemTotals()
    '    oItemList.EndEdit()     'save user's last edits
    '    oItemList.BeginEdit()
    '    If oItemList.Quantity Is Nothing Then
    '        oItemList.Quantity = 0
    '    End If

    '    'if the product in the pricelist if priced by container, then you 
    '    'have to adjust the "itemprice" to reflect the unit price * units in container
    '    If eUC.EditValue = "C" Then
    '        oItemList.Itemprice = oItemList.Itemprice * oItemList.Units
    '        oItemList.Unitcost = oItemList.Unitcost * oItemList.Units
    '    End If
    '    bsItem.EndEdit()
    '    oItemList.EndEdit()
    '    oItemList.Extcost = CDbl(oItemList.Quantity) * CDbl(oItemList.Unitcost)
    '    oItemList.Extprice = CDbl(oItemList.Quantity) * CDbl(oItemList.Itemprice)
    '    oItemList.Grossprofit = CDbl(oItemList.Extprice) - CDbl(oItemList.Extcost)
    '    oItemList.EndEdit()
    '    oItemList.Save()
    'End Sub

    'Private Sub eItemPrice_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
    '    If IsDBNull(oItemList.Productid) Then
    '        MsgBox("You must select a product first", MsgBoxStyle.Critical, "Error - No product selected")
    '        Exit Sub
    '    End If

    '    Dim frm As New frmViewPriceListRecords
    '    frm.vProductID = oItemList.Productid
    '    frm.vCustomerID = vCustID
    '    If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        eItemPrice.EditValue = frm.oPrice.Unitprice
    '        eTaxable.EditValue = frm.oPrice.Taxable
    '        eUC.EditValue = frm.oPrice.Unitorcontainer
    '        bsItem.EndEdit()
    '    Else
    '        MsgBox("No Price List record selected", MsgBoxStyle.Information, "Price List")
    '    End If

    'End Sub

    'Private Sub eUnitCost_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
    '    If IsDBNull(oItemList.Productid) Then
    '        MsgBox("You must select a product first", MsgBoxStyle.Critical, "Error - No product selected")
    '        Exit Sub
    '    End If
    '    Dim frm As New frmViewProductCostRecords
    '    frm.vProductID = oItemList.Productid
    '    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        eUnitCost.EditValue = frm.oCost.Unitcost
    '        eUnits.EditValue = frm.oCost.Units
    '        eUOM.EditValue = frm.oCost.Uom
    '        bsItem.EndEdit()
    '    Else
    '        MsgBox("no product cost record selected")
    '    End If
    'End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged

    End Sub
End Class