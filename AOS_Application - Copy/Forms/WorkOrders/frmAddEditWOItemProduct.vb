Imports AOS.BusinessObjects

Public Class frmAddEditWOItemProduct
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer               'object primary key (passed in by calling form for edit mode)
    Public vWONum As Integer            'foreign key values (passed in by calling form for add mode)
    Public vEditType As String          'operating mode (ADD or EDIT) (passed in by calling form)
    Public vEditCategory As String      'MATCHING or SINGLE (passed in by calling form)
    Public vCustID As Integer
    Public vWorkOrderStatus As String
    Public vCustPO As String
    Public vOrderType As String
    Public vTransType As String
    Public vBillable As String


    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Work Order Item - PRODUCT"
    Friend vItemType As String = "PRODUCT"

    'here is where you dimension your object variables for the form
    Dim oItem As Workorderitem
    Dim oProducts As ViewPriceListProductsCollection
    Dim oProduct As Product
    Dim oContainer As Container
    Dim oPriceList As Pricelist
    Dim oPrices As PricelistCollection
    Dim oInvItem As Invitem

    Dim oProductCosts As ProductcostCollection
    Dim oCost As Productcost

    Dim oProductList As ProductCollection
    Dim oCust As Customer
    'Dim oPricing As ViewWorkOrderItemPricing
    Dim oWorkOrderPricing As ViewWorkOrderItemPricing

    'Dim vShowFinancials As Boolean
    Dim vAllocate As Boolean

    Dim vPrevProduct As Integer = 0

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        setProcessFlags()
        getCustomer()
        getProducts("CUSTOMER")
        loadData()
        loadLookupTables()
        eQty.Focus()
    End Sub

    Private Sub loadLookupTables()

        If vEditType <> "ADD" Then
            Select Case vOrderType
                Case "CONSIGNMENT TRANSFER"
                    'eBillable.Enabled = False
            End Select
            'editPricing()
        Else  'ADD mode - set defaults from the WorkOrder OrderType value
            Select Case vOrderType
                Case "CONSIGNMENT USAGE"
                    'eBillable.Enabled = True
                    'eBillable.Checked = True
                Case "CONSIGNMENT TRANSFER"
                    'eBillable.Enabled = False
                    'eBillable.Checked = False
                Case "STANDARD"
                    'eBillable.Enabled = True
                    'eBillable.Checked = True
                Case Else
                    vAllocate = False
                    'eBillable.Enabled = True
            End Select
        End If

    End Sub


    'Private Sub editPricing()
    '    oPricing = New ViewWorkOrderItemPricing
    '    oPricing.Query.Where(oPricing.Query.Workorderitemnumber.Equal(vID))
    '    oPricing.Query.Load()
    '    bsPrice.DataSource = oPricing
    'End Sub

    Private Sub setProcessFlags()
        'settings for whether to break out a qty of more than 1
        'into multiple items on the order - this is required for most
        'orders as we process them as individual items
        'DIRECT shipments and CONSIGNMENT USAGE are the main exceptions
        Select Case vOrderType
            Case "CONSIGNMENT USAGE"
                vAllocate = False
                chkBillable.Properties.ReadOnly = False
            Case "CONSIGNMENT TRANSFER"
                Select Case vTransType
                    Case TransportType.DIRECT.ToString()
                        vAllocate = False
                    Case Else
                        vAllocate = True
                End Select
                chkBillable.Properties.ReadOnly = True
            Case "STANDARD"
                Select Case vTransType
                    Case TransportType.DIRECT.ToString()
                        vAllocate = False
                    Case Else
                        vAllocate = True
                End Select
                chkBillable.Properties.ReadOnly = False
            Case Else
                vAllocate = False
                chkBillable.Properties.ReadOnly = False
        End Select

        eUC.Enabled = IIf((vOrderType = "CONSIGNMENT USAGE" OrElse _
                          vTransType = TransportType.DIRECT.ToString() OrElse _
                          vEditType = "ADD"), True, False)
        eQty.Enabled = eUC.Enabled

    End Sub

    Private Sub getCustomer()
        oCust = New Customer
        If oCust.LoadByPrimaryKey(vCustID) Then
            eCustomerName.Text = oCust.Custname
        Else
            eCustomerName.Text = ""
        End If
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
            RibbonPageGroup3.Visible = False
        Else
            editObject(vID)
            RibbonPageGroup3.Visible = True
            eProduct.Enabled = False
        End If
    End Sub

    Private Sub getProducts(vMethod As String)
        Select Case vMethod
            Case "CUSTOMER"
                Select Case vOrderType
                    Case "CONSIGNMENT USAGE"
                        bsProducts.DataSource = getCustomerProductList(vCustID, True)
                    Case "CONSIGNMENT TRANSFER"
                        bsProducts.DataSource = getCustomerProductList(vCustID, True)
                    Case Else
                        bsProducts.DataSource = getCustomerProductList(vCustID, False)
                End Select
            Case "ALL"
                oProductList = New ProductCollection
                oProductList.Query.Where(oProductList.Query.Isactive.Equal(1))
                oProductList.Query.Load()
                oProductList.Sort = "PRODUCTDESC, PRODUCTID"
                bsProducts.DataSource = oProductList
        End Select
    End Sub

    Private Function getCustomerProductList(vCustID, vConsignment) As ViewPriceListProductsCollection

        Dim oProductList As New ViewPriceListProductsCollection
        Select Case vConsignment
            Case True
                'Order is marked for Consignment - only retrieve Price List Records for the Customer marked as Consignment Pricing
                oProductList.Query.Where(oProductList.Query.Custid.Equal(vCustID), oProductList.Query.Isconsignment.Equal(1))
            Case False
                'Order is NOT marked for Consignment - only retrieve Price List Records for the Customer NOT marked as Consignment Pricing
                oProductList.Query.Where(oProductList.Query.Custid.Equal(vCustID), oProductList.Query.Isconsignment.NotEqual(1))
        End Select
        If Not oProductList.Query.Load() Then
            MsgBox("There are no Products on a Price List for this Customer", MsgBoxStyle.Critical, "Error - No PriceList")
        End If
        oProductList.Sort = "PRODUCTDESC"
        Return oProductList

    End Function

    Private Sub addNewObject()
        oItem = New Workorderitem
        oItem.AddNew()
        'assign foreign key values here
        oItem.Workordernumber = vWONum
        oItem.Itemtype = vItemType
        Select Case vOrderType
            Case "CONSIGNMENT TRANSFER"
                oItem.Billable = False
            Case Else
                oItem.Billable = True
        End Select
        oItem.Workorderitemstatus = vWorkOrderStatus
        oItem.Customerpo = vCustPO
        oItem.Unitorcontainer = "C"
        oItem.EndEdit()
        oItem.Save()
        Me.bsItem.DataSource = oItem
        txtPriceCost.Text = 0
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Workorderitem
        oItem.LoadByPrimaryKey(vID)

        If oItem.Customerpo = "" Then
            oItem.Customerpo = vCustPO
        End If
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub addMultipleEntries(ByVal vQty As Integer)

        'REL 14.2 - AMERICO - MCGUIRE - 08/14/2014
        'This code method create a single record for each product item when the qty of containers being ordered
        'is greater than 1 and the order type (STANDARD and CONSIGNMENT TRANSFER) indicates that the items will 
        'be allocated (and tracked) from inventory individually.
        'Example: User enters 4 drums to be ordered on a STANDARD order type - the end result will be 4 records
        'in the WORKORDERITEM table

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
            oItemAdd.Itemid = oItem.Itemid
            oItemAdd.Itemdescription = oItem.Itemdescription
            oItemAdd.Itemcomments = oItem.Itemcomments
            oItemAdd.Customerpo = oItem.Customerpo
            oItemAdd.Container = oItem.Container
            oItemAdd.Qty = 1
            oItemAdd.Unitorcontainer = oItem.Unitorcontainer

            oItemAdd.Units = oItem.Units
            oItemAdd.Uom = oItem.Uom

            oItemAdd.Workorderitemstatus = oItem.Workorderitemstatus
            oItemAdd.Totalvolume = oItem.Totalvolume
            oItemAdd.Volumeuom = oItem.Volumeuom
            oItemAdd.Totalweight = oItem.Totalweight
            oItemAdd.Weightuom = oItem.Weightuom
            oItemAdd.DOTIDNumber = oItem.DOTIDNumber
            oItemAdd.Hazmatid = oItem.Hazmatid
            oItemAdd.Hazmatclass = oItem.Hazmatclass
            oItemAdd.Hazmatpackagegroup = oItem.Hazmatpackagegroup
            oItemAdd.Classrate = oItem.Classrate
            oItemAdd.Dotdesc = oItem.Dotdesc
            oItemAdd.Hazmatdesc = oItem.Hazmatdesc
            oItemAdd.Unline = oItem.Unline
            oItemAdd.Ishazardous = oItem.Ishazardous
            oItemAdd.Itemnotes = oItem.Itemnotes
            oItemAdd.Ld1 = oItem.Ld1
            oItemAdd.Ld2 = oItem.Ld2
            oItemAdd.Ld3 = oItem.Ld3
            oItemAdd.Custitemid = oItem.Custitemid

            Select Case oItem.Billable
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


            oItemAdd.Priceunits = oItem.Priceunits
            oItemAdd.Priceuom = oItem.Priceuom
            oItemAdd.Unitprice = oItem.Unitprice
            oItemAdd.Standardcostunits = oItem.Standardcostunits
            oItemAdd.Standardcostuom = oItem.Standardcostuom
            oItemAdd.Standardunitcost = oItem.Standardunitcost
            oItemAdd.Actualcostunits = oItem.Actualcostunits
            oItemAdd.Actualcostuom = oItem.Actualcostuom
            oItemAdd.Actualunitcost = oItem.Actualunitcost

            oItemAdd.Save()
        Next

        'now reset the Qty Ordered to 1 for this main record and save original record
        oItem.Qty = 1
        oItem.Save()

    End Sub

    Private Function updateMatchingItems() As Boolean
        'when this function is called, all changes should already be saved
        'now we need to update all matching items for this workorder to
        'reflect the same values as this newly saved item
        'matching items are identified by the following:
        '  WorkOrderNumber, ItemType, ItemID

        If vEditType <> "EDIT" Then
            Exit Function
        End If

        Dim oItems As New WorkorderitemCollection
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(oItem.Workordernumber), oItems.Query.Itemtype.Equal(oItem.Itemtype), oItems.Query.Itemid.Equal(oItem.Itemid))
        If oItems.Query.Load Then
            'we should now have all matching items in a collection
            'now loop through and update each item to match data values from the current item on screen
            'NOTE: this will also "update" the current item with itself
            For Each oRec As Workorderitem In oItems
                oRec.Productid = oItem.Productid
                oRec.Productdesc = oItem.Productdesc
                oRec.Itemdescription = oItem.Itemdescription
                oRec.Itemcomments = oItem.Itemcomments
                oRec.Customerpo = oItem.Customerpo
                oRec.Container = oItem.Container
                oRec.Qty = oItem.Qty
                oRec.Unitorcontainer = oItem.Unitorcontainer
                oRec.Units = oItem.Units
                oRec.Uom = oItem.Uom
                oRec.Itemprice = oItem.Itemprice
                oRec.Extprice = oItem.Extprice
                oRec.Unitcost = oItem.Unitcost
                oRec.Extcost = oItem.Extcost
                oRec.Extprofit = oItem.Extprofit
                oRec.Itemprofit = oItem.Itemprofit
                oRec.Totalvolume = oItem.Totalvolume
                oRec.Volumeuom = oItem.Volumeuom
                oRec.Totalweight = oItem.Totalweight
                oRec.Weightuom = oItem.Weightuom
                oRec.DOTIDNumber = oItem.DOTIDNumber
                oRec.Hazmatid = oItem.Hazmatid
                oRec.Hazmatclass = oItem.Hazmatclass
                oRec.Hazmatpackagegroup = oItem.Hazmatpackagegroup
                oRec.Classrate = oItem.Classrate
                oRec.Dotdesc = oItem.Dotdesc
                oRec.Hazmatdesc = oItem.Hazmatdesc
                oRec.Unline = oItem.Unline
                oRec.Ishazardous = oItem.Ishazardous
                oRec.Itemnotes = oItem.Itemnotes
                oRec.Ld1 = oItem.Ld1
                oRec.Ld2 = oItem.Ld2
                oRec.Ld3 = oItem.Ld3
                oRec.Custitemid = oItem.Custitemid
                oRec.Billable = oItem.Billable

                'these are additional fields to be updated from field changes in WORKORDER COSTING II project
                'REL 14.2 - Americo - McGuire - 08/14/2014
                oRec.Priceunits = oItem.Priceunits
                oRec.Priceuom = oItem.Priceuom
                oRec.Unitprice = oItem.Unitprice
                oRec.Standardcostunits = oItem.Standardcostunits
                oRec.Standardcostuom = oItem.Standardcostuom
                oRec.Standardunitcost = oItem.Standardunitcost
                oRec.Actualcostunits = oItem.Actualcostunits
                oRec.Actualcostuom = oItem.Actualcostuom
                oRec.Actualunitcost = oItem.Actualunitcost


            Next
            oItems.Save()
        End If

        Return True
    End Function

    Private Function changesSaved() As Boolean

        'Dim vItemUnitsQty As Decimal

        bsItem.EndEdit()
        oItem.EndEdit()
        oItem.Save()

        ' Step 1: Validate if Product is selected
        If IsDBNull(bsItem.Current.itemID) Or oItem.Productid Is Nothing Then
            MsgBox("You must select a valid Product to continue", MsgBoxStyle.Critical, "Error - No Item Selected")
            Return False
        End If


        If String.IsNullOrEmpty(Me.eQty.Text) OrElse Val(Me.eQty.Text) = 0 Then
            MsgBox("Quantity is required. Please enter Quantity.", MsgBoxStyle.Critical, "Validate Work Order Item Information - PRODUCT - Error")
            eQty.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.eUC.Text) Or Me.eUC.Text.Trim() = String.Empty Then
            MsgBox("U/C is required. Please enter U/C.", MsgBoxStyle.Critical, "Validate Work Order Item Information - PRODUCT - Error")
            eUC.Focus()
            Return False
        End If

        Dim oWorkOrder As New Workorder
        If oWorkOrder.LoadByPrimaryKey(vWONum) = False Then
            Return False
        End If
        If oWorkOrder.Transporttype = TransportType.DIRECT.ToString() AndAlso _
            (oItem.Customerpo Is Nothing OrElse _
             String.IsNullOrEmpty(oItem.Customerpo)) Then
            MsgBox("Customer PO number is required. Please enter Customer PO number.", MsgBoxStyle.Critical, "Validate Work Order Item Information - PRODUCT - Error")
            CustomerpoTextEdit.Focus()
            Return False
        End If

        ''set correct qty of units (not containers) 
        'If bsItem.Current.Unitorcontainer = "C" Then
        '    vItemUnitsQty = bsItem.Current.qty * bsItem.Current.units
        'Else
        '    vItemUnitsQty = bsItem.Current.qty
        'End If

        'If bsItem.Current.billable = False Then
        '    bsItem.Current.UnitCost = 0.0
        '    bsItem.Current.ItemPrice = 0.0
        '    bsItem.Current.ItemProfit = 0.0
        '    bsItem.Current.ExtPrice = 0.0
        '    bsItem.Current.ExtCost = 0.0
        '    bsItem.Current.ExtProfit = 0.0
        'End If

        'bsItem.EndEdit()

        ' Step 2: Check if product is being sold on loss

        If bsItem.Current.productId > 0 Then
            If (bsItem.Current.billable) Then

                Select Case bsItem.Current.unitorContainer
                    Case "C"

                        If oItem.Actualunitcost <> 0 And oItem.Actualcostunits <> 0 Then
                            If ((oItem.Actualunitcost * oItem.Actualcostunits * oItem.Qty) > (oItem.Unitprice * oItem.Priceunits * oItem.Qty)) Then
                                If MsgBox("Do you want to sell on loss?", vbYesNo + vbQuestion) = vbNo Then
                                    txtPriceCost.Focus()
                                    Return False
                                End If
                            End If
                        Else
                            If ((oItem.Standardunitcost * oItem.Standardcostunits * oItem.Qty) > (oItem.Unitprice * oItem.Priceunits * oItem.Qty)) Then
                                If MsgBox("Do you want to sell on loss?", vbYesNo + vbQuestion) = vbNo Then
                                    txtPriceCost.Focus()
                                    Return False
                                End If
                            End If
                        End If

                    Case Else
                        If oItem.Standardunitcost > oItem.Unitprice Then
                            If MsgBox("Do you want to sell on loss?", vbYesNo + vbQuestion) = vbNo Then
                                txtPriceCost.Focus()
                                Return False
                            End If
                        End If
                End Select
            Else
                bsItem.Current.unitCost = 0.0
                bsItem.Current.itemPrice = 0.0
                bsItem.Current.itemProfit = 0.0
                bsItem.Current.extPrice = 0.0
                bsItem.Current.extCost = 0.0
                bsItem.Current.extProfit = 0.0
            End If
        End If

        oItem.EndEdit()
        oItem.Save()

        If vEditType = "ADD" Then
            If vAllocate Then
                Dim vQty As Integer = bsItem.Current.qty
                If vQty > 1 Then
                    addMultipleEntries(vQty)
                End If
            End If
        End If

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
        If IsDBNull(eProduct.EditValue) Then
            Exit Sub
        End If
        If String.IsNullOrEmpty(eProduct.Text) Then
            Exit Sub
        End If
        'If (oItemList.Productid = eProduct.EditValue) Then
        '    Exit Sub
        'End If

        getProductData(eProduct.EditValue)

        'getProductInfo(eProduct.EditValue)
        'getProductCostInfo(eProduct.EditValue)
        'getPricingInfo(eProduct.EditValue, vCustID)
        'bsItem.EndEdit()
        'addPricing(eProduct.EditValue)
    End Sub

    Private Sub getProductData(vProdID As Integer)
        'REL 14.2 - AMERICO - MCGUIRE - 08/14/2014

        'Step 1 - Get all reference field data from PRODUCT table for Product ID, including Standard Costing

        oProduct = New Product
        If oProduct.LoadByPrimaryKey(vProdID) Then

            oItem.Container = oProduct.Container
            oItem.Itemid = oProduct.Productid
            oItem.Itemdescription = oProduct.Productdesc
            oItem.Productid = oProduct.Productid
            oItem.Productdesc = oProduct.Productdesc
            oItem.Units = oProduct.Units
            oItem.Uom = oProduct.Uom
            oItem.Totalvolume = oProduct.Volumeunits
            oItem.Totalweight = oProduct.Weightunits
            oItem.Volumeuom = oProduct.Volumeuom
            oItem.Weightuom = oProduct.Weightuom
            oItem.DOTIDNumber = oProduct.Idnumber
            oItem.Dotdesc = oProduct.Dotdesc
            oItem.Hazmatid = oProduct.Hazmatid
            oItem.Hazmatclass = oProduct.Hazclassnumber
            oItem.Hazmatdesc = oProduct.Hazmatdesc
            oItem.Hazmatpackagegroup = oProduct.Packagegroup
            oItem.Classrate = oProduct.Classrate
            oItem.Unline = oProduct.Unline
            If oProduct.Hazmatid <> 1 Then
                oItem.Ishazardous = 1
            Else
                oItem.Ishazardous = 0
            End If

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
            Case PricingMethod.VOLUME.ToString()
                vLookupPrice = oPriceRec.Volumeprice
            Case PricingMethod.WEIGHT.ToString()
                vLookupPrice = oPriceRec.Weightprice
            Case Else
                vLookupPrice = 0.0
        End Select
        If vLookupPrice > 0.0 And vCurrentPrice > 0.0 And vCurrentPrice <> vLookupPrice And vPrevProduct = vProdID Then
            If MsgBox("There has been a previous price adjustment to this item. Do you want to keep this price adjustment and NOT the default price?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "CONFIRM - Price Adjustment") = MsgBoxResult.Yes Then
                vKeepPrice = True
            End If
        End If


        If oItem.Billable Then
            Select Case oPriceRec.Pricingmethod
                Case PricingMethod.VOLUME.ToString()
                    oItem.Priceunits = oPriceRec.Volumeunits
                    oItem.Priceuom = oPriceRec.Volumeuom
                    If vKeepPrice Then
                        oItem.Unitprice = vCurrentPrice
                    Else
                        oItem.Unitprice = vLookupPrice
                    End If
                Case PricingMethod.WEIGHT.ToString()
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
                    If Not vKeepPrice Then
                        oItem.Priceunits = 0.0
                        oItem.Priceuom = ""
                        oItem.Unitprice = 0.0
                    End If
            End Select
        Else
            oItem.Priceunits = 0.0
            oItem.Priceuom = ""
            oItem.Unitprice = 0.0
        End If

        'Step 3 - Set STANDARD (CHEMICAL ONLY) COSTING for selected Product (we already have the PRODUCT record selected and available)

        If oItem.Billable Then
            Select Case oPriceRec.Pricingmethod
                Case PricingMethod.VOLUME.ToString()
                    oItem.Standardcostunits = oProduct.Volumeunits
                    oItem.Standardcostuom = oProduct.Volumeuom
                    oItem.Standardunitcost = oProduct.Volumestandardcost
                Case PricingMethod.WEIGHT.ToString()
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
                        Case ProductInventoryMethod.VOLUME.ToString()
                            oItem.Standardcostunits = oProduct.Volumeunits
                            oItem.Standardcostuom = oProduct.Volumeuom
                            oItem.Standardunitcost = oProduct.Volumestandardcost
                        Case ProductInventoryMethod.WEIGHT.ToString()
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
        Else
            'If item is NOT billable, we do not track STANDARD (CHEMICAL ONLY) COSTS
            oItem.Standardcostunits = 0.0
            oItem.Standardcostuom = ""
            oItem.Standardunitcost = 0.0
        End If

        'Step 4 - Set CUSTOMER PRODUCT CODE from PRICELIST for selected Item (Product)

        'change per Erin Linton 12/15/2015 - do not override Customer PO value with Customer Item ID from Price List
        oItem.Custitemid = oPriceRec.Customerproductcode
        If oItem.Customerpo = Nothing And oItem.Custitemid <> Nothing Then
            oItem.Customerpo = oItem.Custitemid
        End If

        oItem.EndEdit()
        oItem.Save()

        bsItem.DataSource = oItem
        bsItem.ResetBindings(False) ' Refresh the controls - False indicate that there is only data changes

        'set screen values to show new field values saved in WORKORDERITEM table
        eContainer.EditValue = oProduct.Container
        eCustItemId.EditValue = oItem.Custitemid

    End Sub

    'Private Sub getProductInfo(ByVal vProdID As Integer)
    '    oProduct = New Product
    '    If oProduct.LoadByPrimaryKey(vProdID) Then
    '        oItemList.Container = oProduct.Container
    '        oItemList.Itemdescription = oProduct.Productdesc
    '        oItemList.Productid = oProduct.Productid
    '        oItemList.Units = oProduct.Units
    '        oItemList.Uom = oProduct.Uom
    '        oItemList.Totalvolume = oProduct.Volumeunits
    '        oItemList.Totalweight = oProduct.Weightunits
    '        oItemList.Volumeuom = oProduct.Volumeuom
    '        oItemList.Weightuom = oProduct.Weightuom
    '        oItemList.DOTIDNumber = oProduct.Idnumber
    '        oItemList.Dotdesc = oProduct.Dotdesc
    '        oItemList.Hazmatid = oProduct.Hazmatid
    '        oItemList.Hazmatclass = oProduct.Hazclassnumber
    '        oItemList.Hazmatdesc = oProduct.Hazmatdesc
    '        oItemList.Hazmatpackagegroup = oProduct.Packagegroup
    '        oItemList.Classrate = oProduct.Classrate
    '        oItemList.Unline = oProduct.Unline
    '        If oProduct.Hazmatid <> 1 Then
    '            oItemList.Ishazardous = 1
    '        Else
    '            oItemList.Ishazardous = 0
    '        End If

    '        Dim oCostRec As New Productcost
    '        Dim oPriceRec As New Pricelist

    '        If oItemList.Billable = True Then
    '            oPriceRec = getPriceListRecord(vProdID, vCustID)
    '            oCostRec = getProductCostRecord(vProdID, oPriceRec.Uom)

    '            'All UNITS and UOM should be driven by the PRICELIST record for the PRODUCT / CUSTOMER combination
    '            'If there is no PRICELIST record then the ItemPrice will be set to 0.00 and the 
    '            'UNITS and UOM will remain the default (from the PRODUCT table, as set above with PRODUCT lookup)
    '            If oPriceRec.Pricelistid Is Nothing Then
    '                oItemList.Itemprice = 0.0
    '            Else
    '                oItemList.Itemprice = oPriceRec.Unitprice
    '                oItemList.Uom = oPriceRec.Uom
    '                oItemList.Units = oPriceRec.Units
    '            End If

    '            If oCostRec.Costrecid Is Nothing Then
    '                oItemList.Unitcost = 0.0
    '            Else
    '                oItemList.Unitcost = oCostRec.Unitcost
    '            End If

    '        Else
    '            oItemList.Unitcost = 0.0
    '            oItemList.Itemprice = 0.0
    '        End If

    '        oItemList.Custitemid = getProductCustomerItemID(vProdID, vCustID)
    '        oItemList.EndEdit()
    '        oItemList.Save()

    '        eContainer.EditValue = oProduct.Container
    '        eCustItemId.EditValue = oItemList.Custitemid

    '    End If
    'End Sub

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
        If Not IsDBNull(bsItem.Current.itemPrice) Then
            vCurrentPrice = bsItem.Current.itemPrice
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

    'Private Function getProductCostRecord(vProdid As Integer, vUOM As String) As Productcost
    '    Dim oCostRec As New Productcost
    '    oProductCosts = New ProductcostCollection
    '    oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdid))
    '    oProductCosts.Query.Load()
    '    Select Case oProductCosts.Count
    '        Case Is = 1
    '            'eUnits.EditValue = oProductCosts(0).Units
    '            'eUOM.EditValue = oProductCosts(0).Uom
    '            'eUnitCost.EditValue = oProductCosts(0).Unitcost
    '            'bsItem.EndEdit()
    '            'If oProductCosts(0).Uom <> vUOM Then
    '            '    MsgBox("The Cost Record for this product has a different Unit of Measure than the PriceList record for this product for the currect customer", MsgBoxStyle.Critical, "WARNING - Mismatched Unit of Measure")
    '            'End If
    '            Return oProductCosts(0)
    '        Case Else
    '            'Dim frm As New frmViewProductCostRecords
    '            'frm.vProductID = vProdid
    '            'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            '    If frm.oCost.Uom <> vUOM Then
    '            '        MsgBox("The selected Cost Record for this product has a different Unit of Measure than the PriceList record for this product for the currect customer", MsgBoxStyle.Critical, "WARNING - Mismatched Unit of Measure")
    '            '    End If
    '            '    Return frm.oCost
    '            'Else
    '            '    MsgBox("You did not select a valid UnitCost for the item you are attempting to add to the WorkOrder", MsgBoxStyle.Critical, "Error - Missing Data")
    '            '    Return oCostRec
    '            'End If

    '            Return oCostRec
    '    End Select
    'End Function

    'Private Function getProductCost(ByVal vProdID As Integer) As Decimal

    '    'if Item is not Billable - set to zero
    '    If oItemList.Billable = False Then
    '        'eUnits.EditValue = ""
    '        'eUOM.EditValue = ""
    '        'eUnitCost.EditValue = 0.0
    '        'bsItem.EndEdit()
    '        'Exit Function
    '        Return 0.0
    '    End If

    '    'Item is Billable, costs required
    '    oProductCosts = New ProductcostCollection
    '    oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdID))
    '    oProductCosts.Query.Load()
    '    Select Case oProductCosts.Count
    '        Case Is = 1
    '            'eUnits.EditValue = oProductCosts(0).Units
    '            'eUOM.EditValue = oProductCosts(0).Uom
    '            'eUnitCost.EditValue = oProductCosts(0).Unitcost
    '            'bsItem.EndEdit()
    '            If IsNothing(oProductCosts(0).Unitcost) Or IsDBNull(oProductCosts(0).Unitcost) Then
    '                Return 0
    '            Else
    '                Return oProductCosts(0).Unitcost
    '            End If


    '        Case Else
    '            'Dim frm As New frmViewProductCostRecords
    '            'frm.vProductID = vProdID
    '            'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            '    If IsDBNull(frm.oCost.Unitcost) Or frm.oCost.Unitcost <= 0 Then
    '            '        MsgBox("You did not select a valid UnitCost for the item you are attempting to add to the WorkOrder", MsgBoxStyle.Critical, "Error - Missing Data")
    '            '        Return 0.0
    '            '    End If
    '            '    Return frm.oCost.Unitcost
    '            '    '    eUnits.EditValue = frm.oCost.Units
    '            '    '    eUOM.EditValue = frm.oCost.Uom
    '            '    '    eUnitCost.EditValue = frm.oCost.Unitcost
    '            '    '    bsItem.EndEdit()
    '            'Else
    '            '    MsgBox("You did not select a valid UnitCost for the item you are attempting to add to the WorkOrder", MsgBoxStyle.Critical, "Error - Missing Data")
    '            '    Return 0.0
    '            'End If

    '            Return 0.0
    '    End Select
    'End Function

    'Private Function getProductPrice(ByVal vProdID As Integer, ByVal vCustID As Integer) As Decimal

    '    Dim vLookupPrice As Decimal = 0.0
    '    Dim vCurrentPrice As Decimal = 0.0

    '    'set the price that is currently assigned to this WorkOrderItem
    '    If Not IsDBNull(bsItem.Current.ItemPrice) Then
    '        vCurrentPrice = bsItem.Current.ItemPrice
    '    Else
    '        vCurrentPrice = 0.0
    '    End If

    '    'if financials are not required, set to zero (item is NOT billable)
    '    If oItemList.Billable = False Then
    '        'eItemPrice.EditValue = 0.0
    '        'bsItem.EndEdit()
    '        Return 0.0
    '    End If

    '    'Item is billable, proceed with looking up Product pricing from PriceList for current Customer
    '    oPrices = New PricelistCollection
    '    oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdID), oPrices.Query.Custid.Equal(vCustID), oPrices.Query.Effectivedate.LessThanOrEqual(Now.Date)).OrderBy(oPrices.Query.Effectivedate.Descending)
    '    oPrices.Query.Load()
    '    Select Case oPrices.Count
    '        Case Is > 0
    '            vLookupPrice = If(Not String.IsNullOrEmpty(oPrices(0).Unitprice.ToString()), oPrices(0).Unitprice, Format(0.0, "0.00"))
    '        Case Else
    '            MsgBox("The product you selected is not in the Customer's price list.", MsgBoxStyle.Critical, "Error - Price List")
    '            vLookupPrice = 0.0
    '    End Select

    '    'we now have the lookup price from the Customer Price List
    '    Select Case vEditType
    '        Case "ADD"
    '            'eItemPrice.EditValue = vLookupPrice
    '            'eCustItemId.EditValue = vCustItemID
    '            Return vLookupPrice
    '        Case "EDIT"
    '            If vLookupPrice <> vCurrentPrice And vCurrentPrice > 0.0 Then
    '                If MsgBox("The price on this Item is not the same as the Item Price in the Customer's Price List. Do you want to change the Item's price to match the price list?", MsgBoxStyle.YesNo, "Confirm - Change Price") = MsgBoxResult.Yes Then
    '                    Return vLookupPrice
    '                Else
    '                    Return vCurrentPrice
    '                End If
    '            Else
    '                Return vLookupPrice
    '            End If
    '    End Select

    'End Function

    'Private Function getProductCustomerItemID(vProdID As Integer, vCustID As Integer) As String

    '    oPrices = New PricelistCollection
    '    oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdID), oPrices.Query.Custid.Equal(vCustID), oPrices.Query.Effectivedate.LessThanOrEqual(Now.Date)).OrderBy(oPrices.Query.Effectivedate.Descending)
    '    oPrices.Query.Load()
    '    Select Case oPrices.Count
    '        Case Is > 0
    '            Return oPrices(0).Customerproductcode
    '        Case Else
    '            Return ""
    '    End Select

    'End Function


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
    '    'Dim frm As New frmViewProductCostRecords
    '    'frm.vProductID = oItemList.Productid
    '    'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '    '    If oItemList.Uom <> frm.oCost.Uom Then
    '    '        MsgBox("You selected a cost record that has a different Unit of Measure than the PRODUCT/PRICELIST record for this item!", MsgBoxStyle.Critical, "WARNING - Mismatched Unit of Measure")
    '    '    End If
    '    '    oItemList.Unitcost = frm.oCost.Unitcost
    '    '    oItemList.Save()

    '    '    bsItem.EndEdit()
    '    'Else
    '    '    MsgBox("No product cost record selected")
    '    'End If
    'End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            'if we are in EDIT mode, then we need to check to see if we are editing all MATCHING items or a SINGLE item
            'if we are in ADD mode, it won't matter, as all MATCHING items are automatically created identical to each other
            If vEditType = "EDIT" Then
                Select Case vEditCategory
                    Case "MATCHING"
                        If updateMatchingItems() Then
                            Me.DialogResult = Windows.Forms.DialogResult.Yes
                        Else
                            MsgBox("Error in Updating Matching Items", MsgBoxStyle.Critical, "Error - Update failed")
                        End If
                    Case Else
                        Me.DialogResult = Windows.Forms.DialogResult.Yes
                End Select
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
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

    Private Sub btnEditAll_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditAll.ItemClick
        eProduct.Enabled = True
    End Sub

    Private Sub btnRecalcPricingCosting_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnRecalcPricingCosting.ItemClick
        If eProduct.EditValue Is Nothing Then
            Exit Sub
        End If
        If IsDBNull(eProduct.EditValue) Then
            Exit Sub
        End If

        getProductData(eProduct.EditValue)

    End Sub

    Private Sub chkBillable_CheckStateChanged(sender As Object, e As EventArgs) Handles chkBillable.CheckStateChanged

        Select Case chkBillable.CheckState
            Case CheckState.Checked
                bsItem.Current.billable = True
                oItem.Billable = True
            Case CheckState.Unchecked
                bsItem.Current.billable = False
                oItem.Billable = False
        End Select

        bsItem.EndEdit()
        oItem.Save()

        'now check to see if a product has been selected, and if it has, update pricing/costing based on BILLABLE setting
        If eProduct.EditValue Is Nothing Then
            Exit Sub
        End If
        If IsDBNull(eProduct.EditValue) Then
            Exit Sub
        End If

        getProductData(eProduct.EditValue)


    End Sub

    Private Sub eProduct_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles eProduct.EditValueChanging
        vPrevProduct = IIf(IsDBNull(e.OldValue), 0, e.OldValue)
    End Sub
End Class