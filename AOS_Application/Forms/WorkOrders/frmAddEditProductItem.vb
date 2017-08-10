Imports AOS.BusinessObjects

Public Class frmAddEditProductItem
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
    Dim oPricing As ViewWorkOrderItemPricing
    Dim oWorkOrderPricing As ViewWorkOrderItemPricing

    Dim vShowFinancials As Boolean
    Dim vAllocate As Boolean

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        setProcessFlags()
        getCustomer()
        getProducts("CUSTOMER")
        loadData()
        loadLookupTables()
    End Sub

    Private Sub loadLookupTables()

        

        If vEditType <> "ADD" Then
            Select Case vOrderType
                Case "CONSIGNMENT TRANSFER"
                    eBillable.Enabled = False
            End Select
            editPricing()
        Else
            Select Case vOrderType
                Case "CONSIGNMENT USAGE"
                    eBillable.Enabled = True
                    eBillable.Checked = True
                Case "CONSIGNMENT TRANSFER"
                    eBillable.Enabled = False
                    eBillable.Checked = False
                Case "STANDARD"
                    eBillable.Enabled = True
                    eBillable.Checked = True
                Case Else
                    vAllocate = False
                    eBillable.Enabled = True
            End Select
        End If

    End Sub

    Private Sub addPricing(Productid As Int32)
        Dim PriceMethod As String = Nothing

        Dim dt As New DataTable
        dt.Columns.Add("Priceunits", GetType(Decimal))
        dt.Columns.Add("Priceuom", GetType(String))
        dt.Columns.Add("Unitprice", GetType(Decimal))
        dt.Columns.Add("Standardcostunits", GetType(Decimal))
        dt.Columns.Add("Standardcostuom", GetType(String))
        dt.Columns.Add("Standardunitcost", GetType(Decimal))
        dt.Columns.Add("Actualcostunits", GetType(Decimal))
        dt.Columns.Add("Actualcostuom", GetType(String))
        dt.Columns.Add("Actualunitcost", GetType(Decimal))

        Dim dtPriceList As DataTable
        Dim dtProduct As DataTable

        oPriceList = New Pricelist
        oPriceList.Query.Where(oPriceList.Query.Productid.Equal(Productid), oPriceList.Query.Custid.Equal(vCustID), oPriceList.Query.Effectivedate.LessThanOrEqual(Now.Date)).OrderBy(oPriceList.Query.Effectivedate.Descending)
        dtPriceList = oPriceList.Query.LoadDataTable()

        oProduct = New Product
        oProduct.Query.Where(oProduct.Query.Productid.Equal(Productid))
        dtProduct = oProduct.Query.LoadDataTable()

        dt.Rows.Add()
        Dim dr As DataRow = dt.Rows(0)
        Dim drPriceList As DataRow = Nothing
        Dim drProduct As DataRow = dtProduct.Rows(0)

        If dtPriceList.Rows.Count > 0 Then
            drPriceList = dtPriceList.Rows(0)
            PriceMethod = If(Not String.IsNullOrEmpty(drPriceList("PRICINGMETHOD").ToString()), drPriceList("PRICINGMETHOD").ToString().ToUpper(), "")
        Else
            If MsgBox("There is no record of this product for this customer in the Price List, do you want to continue?", vbYesNo + vbQuestion) = vbNo Then
                Me.Close()
            Else
                PriceMethod = If(Not String.IsNullOrEmpty(drProduct("INVENTORYMETHOD").ToString()), drProduct("INVENTORYMETHOD").ToString().ToUpper(), PricingMethod.VOLUME.ToString())
            End If
        End If

        If PriceMethod.ToString().ToUpper() = PricingMethod.VOLUME.ToString() Then

            If dtPriceList.Rows.Count > 0 Then
                dr("Priceunits") = If(Not String.IsNullOrEmpty(drPriceList("VOLUMEUNITS").ToString()), Format(drPriceList("VOLUMEUNITS"), "0.00"), Format(0.0, "0.00"))
                dr("Priceuom") = If(Not String.IsNullOrEmpty(drPriceList("VOLUMEUOM").ToString()), drPriceList("VOLUMEUOM"), "")
            Else
                dr("Priceunits") = Format(0.0, "0.0000")
                dr("Priceuom") = ""
            End If

            dr("Standardcostunits") = If(Not String.IsNullOrEmpty(drProduct("VOLUMEUNITS").ToString()), Format(drProduct("VOLUMEUNITS"), "0.00"), Format(0.0, "0.00"))
            dr("Standardcostuom") = If(Not String.IsNullOrEmpty(drProduct("VOLUMEUOM").ToString()), drProduct("VOLUMEUOM"), "")

            If eBillable.Checked = True Then
                If dtPriceList.Rows.Count > 0 Then
                    dr("Unitprice") = If(Not String.IsNullOrEmpty(drPriceList("VOLUMESTANDARDCOST").ToString()), Format(drPriceList("VOLUMESTANDARDCOST"), "0.0000"), Format(0.0, "0.0000"))
                Else
                    dr("Unitprice") = Format(0.0, "0.0000")
                End If

                dr("Standardunitcost") = If(Not String.IsNullOrEmpty(drProduct("VOLUMESTANDARDCOST").ToString()), Format(drProduct("VOLUMESTANDARDCOST"), "0.0000"), Format(0.0, "0.0000"))
            Else
                Select Case vOrderType
                    Case "CONSIGNMENT USAGE"
                        dr("Standardunitcost") = If(Not String.IsNullOrEmpty(drProduct("VOLUMESTANDARDCOST").ToString()), Format(drProduct("VOLUMESTANDARDCOST"), "0.0000"), Format(0.0, "0.0000"))
                    Case "CONSIGNMENT TRANSFER"
                        dr("Standardunitcost") = Format(0.0, "0.0000")
                    Case "STANDARD"
                        dr("Standardunitcost") = If(Not String.IsNullOrEmpty(drProduct("VOLUMESTANDARDCOST").ToString()), Format(drProduct("VOLUMESTANDARDCOST"), "0.0000"), Format(0.0, "0.0000"))
                End Select
                dr("Unitprice") = Format(0.0, "0.0000")
            End If

        ElseIf PriceMethod.ToString().ToUpper() = PricingMethod.WEIGHT.ToString() Then

            If dtPriceList.Rows.Count > 0 Then
                dr("Priceunits") = If(Not String.IsNullOrEmpty(drPriceList("WEIGHTUNITS").ToString()), Format(drPriceList("WEIGHTUNITS"), "0.00"), Format(0.0, "0.00"))
                dr("Priceuom") = If(Not String.IsNullOrEmpty(drPriceList("WEIGHTUOM").ToString()), drPriceList("WEIGHTUOM"), "")
            Else
                dr("Priceunits") = Format(0.0, "0.00")
                dr("Priceuom") = ""
            End If

            dr("Standardcostunits") = If(Not String.IsNullOrEmpty(drProduct("WEIGHTUNITS").ToString()), Format(drProduct("WEIGHTUNITS"), "0.00"), Format(0.0, "0.00"))
            dr("Standardcostuom") = If(Not String.IsNullOrEmpty(drProduct("WEIGHTUOM").ToString()), drProduct("WEIGHTUOM"), "")

            If eBillable.Checked = True Then
                If dtPriceList.Rows.Count > 0 Then
                    dr("Unitprice") = If(Not String.IsNullOrEmpty(drPriceList("WEIGHTSTANDARDCOST").ToString()), Format(drPriceList("WEIGHTSTANDARDCOST"), "0.0000"), Format(0.0, "0.0000"))
                Else
                    dr("Unitprice") = Format(0.0, "0.0000")
                End If
                dr("Standardunitcost") = If(Not String.IsNullOrEmpty(drProduct("WEIGHTSTANDARDCOST").ToString()), Format(drProduct("WEIGHTSTANDARDCOST"), "0.0000"), Format(0.0, "0.0000"))
            Else
                Select Case vOrderType
                    Case "CONSIGNMENT USAGE"
                        dr("Standardunitcost") = If(Not String.IsNullOrEmpty(drProduct("WEIGHTSTANDARDCOST").ToString()), Format(drProduct("WEIGHTSTANDARDCOST"), "0.0000"), Format(0.0, "0.0000"))
                    Case "CONSIGNMENT TRANSFER"
                        dr("Standardunitcost") = Format(0.0, "0.0000")
                    Case "STANDARD"
                        dr("Standardunitcost") = If(Not String.IsNullOrEmpty(drProduct("WEIGHTSTANDARDCOST").ToString()), Format(drProduct("WEIGHTSTANDARDCOST"), "0.0000"), Format(0.0, "0.0000"))
                End Select
                dr("Unitprice") = Format(0.0, "0.0000")
            End If
        Else

            dr("Priceunits") = Format(0.0, "0.00")
            dr("Priceuom") = ""
            dr("Unitprice") = Format(0.0, "0.0000")

            dr("Standardcostunits") = Format(0.0, "0.00")
            dr("Standardcostuom") = ""
            dr("Standardunitcost") = Format(0.0, "0.0000")

        End If

        dr("Actualcostunits") = Format(0.0, "0.00")
        dr("Actualcostuom") = ""
        dr("Actualunitcost") = Format(0.0, "0.0000")

        bsPrice.DataSource = dt

    End Sub

    Private Sub editPricing()
        oPricing = New ViewWorkOrderItemPricing
        oPricing.Query.Where(oPricing.Query.Workorderitemnumber.Equal(vID))
        oPricing.Query.Load()
        bsPrice.DataSource = oPricing
    End Sub


    Private Sub setProcessFlags()
        'settings for whether to break out a qty of more than 1
        'into multiple items on the order - this is required for most
        'orders as we process them as individual items
        'DIRECT shipments and CONSIGNMENT USAGE are the main exceptions
        Select Case vOrderType
            Case "CONSIGNMENT USAGE"
                vAllocate = False
                eBillable.Enabled = True
                eBillable.Checked = True
            Case "CONSIGNMENT TRANSFER"
                Select Case vTransType
                    Case "DIRECT"
                        vAllocate = False
                    Case Else
                        vAllocate = True
                End Select
                eBillable.Enabled = False
                eBillable.Checked = False
            Case "STANDARD"
                Select Case vTransType
                    Case "DIRECT"
                        vAllocate = False
                    Case Else
                        vAllocate = True
                End Select
                eBillable.Enabled = True
                eBillable.CheckState = CheckState.Checked
                eBillable.Checked = True
            Case Else
                vAllocate = False
                eBillable.Enabled = True
        End Select

        'settings for whether or not the ITEM is billable or not -
        'if the WORKORDER is NON-BILLABLE, then the items are not billable
        'However, if the WORKORDER is BILLABLE, some of the items could be
        'marked as NON-BILLABLE manually here.
        Select Case vBillable
            Case "BILLABLE"
                vShowFinancials = True
            Case "NON-BILLABLE'"
                vShowFinancials = False
            Case Else
                vShowFinancials = True
        End Select

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
                oProducts = New ViewPriceListProductsCollection
                oProducts.Query.Where(oProducts.Query.Custid.Equal(vCustID))
                If Not oProducts.Query.Load() Then
                    MsgBox("There are no Products on a Price List for this Customer", MsgBoxStyle.Critical, "Error - No PriceList")
                End If
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
        oItem.Itemtype = vItemType
        If vBillable = "BILLABLE" Then
            oItem.Billable = True
        Else
            oItem.Billable = False
        End If
        oItem.Customerpo = vCustPO
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

    'Private Function changesSaved() As Boolean

    '    Dim vItemQty As Decimal

    '    bsItem.EndEdit()

    '    If bsItem.Current.Unitorcontainer = "C" Then
    '        vItemQty = bsItem.Current.qty * bsItem.Current.units
    '    Else
    '        vItemQty = bsItem.Current.qty
    '    End If

    '    Select Case vShowFinancials
    '        Case True
    '            If bsItem.Current.billable = True Then
    '                bsItem.Current.ItemProfit = bsItem.Current.ItemPrice - bsItem.Current.UnitCost
    '            Else
    '                bsItem.Current.itemprofit = 0
    '            End If
    '            bsItem.EndEdit()
    '            If bsItem.Current.itemprofit < 0 Then
    '                If MsgBox("Are you sure you want to bill this item at a loss", MsgBoxStyle.YesNo, "Confirm - Loss On Sale") = MsgBoxResult.No Then
    '                    Return False
    '                End If
    '            End If
    '            bsItem.Current.ExtPrice = vItemQty * bsItem.Current.ItemPrice
    '            bsItem.Current.ExtCost = vItemQty * bsItem.Current.UnitCost
    '            bsItem.Current.ExtProfit = bsItem.Current.extprice - bsItem.Current.extcost
    '        Case False
    '            bsItem.Current.UnitCost = 0.0
    '            bsItem.Current.ItemPrice = 0.0
    '            bsItem.Current.ItemProfit = 0.0
    '            bsItem.Current.ExtPrice = 0.0
    '            bsItem.Current.ExtCost = 0.0
    '            bsItem.Current.ExtProfit = 0.0
    '    End Select

    '    bsItem.EndEdit()
    '    oItemList.EndEdit()
    '    oItemList.Save()

    '    If vAllocate Then
    '        Dim vQty As Integer = bsItem.Current.Qty
    '        If vQty > 1 Then
    '            addMultipleEntries(vQty)
    '        End If
    '    End If

    '    oItemList.EndEdit()
    '    oItemList.Save()

    '    Return True

    'End Function

    Private Function changesSaved() As Boolean

        Dim vItemUnitsQty As Decimal

        bsItem.EndEdit()

        If IsDBNull(bsItem.Current.ItemID) Then
            MsgBox("You must select a valid Item to continue", MsgBoxStyle.Critical, "Error - No Item Selected")
            Return False
        End If



        If String.IsNullOrEmpty(Me.eQty.Text) Or Me.eQty.Text.Trim() = String.Empty Then
            MsgBox("Quantity is required. Please enter Quantity.", MsgBoxStyle.Critical, "Validate Work Order Item Information - PRODUCT - Error")
            eQty.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Me.eUC.Text) Or Me.eUC.Text.Trim() = String.Empty Then
            MsgBox("U/C is required. Please enter U/C.", MsgBoxStyle.Critical, "Validate Work Order Item Information - PRODUCT - Error")
            eUC.Focus()
            Return False
        End If

        'set correct qty of units (not containers) 
        If bsItem.Current.Unitorcontainer = "C" Then
            vItemUnitsQty = bsItem.Current.qty * bsItem.Current.units
        Else
            vItemUnitsQty = bsItem.Current.qty
        End If


        If bsItem.Current.billable = False Then
            bsItem.Current.UnitCost = 0.0
            bsItem.Current.ItemPrice = 0.0
            bsItem.Current.ItemProfit = 0.0
            bsItem.Current.ExtPrice = 0.0
            bsItem.Current.ExtCost = 0.0
            bsItem.Current.ExtProfit = 0.0
        End If

        bsItem.EndEdit()

        If Not String.IsNullOrEmpty(eProduct.Text) Then
            Dim dt As DataTable

            If Not String.IsNullOrEmpty(bsPrice.DataSource.ToString()) Then
                oWorkOrderPricing = New ViewWorkOrderItemPricing
                oWorkOrderPricing = bsPrice.DataSource
                dt = oWorkOrderPricing.Query.LoadDataTable()
            Else
                dt = bsPrice.DataSource
            End If

            If dt.Rows.Count > 0 Then

                Dim dr As DataRow = dt.Rows(0)

                If eBillable.Checked Then
                    If bsItem.Current.Unitorcontainer = "C" Then

                        Dim Priceunits As Decimal = If(Not String.IsNullOrEmpty(dr("Priceunits").ToString()), Format(dr("Priceunits"), "0.00"), Format(0.0, "0.00"))
                        Dim Unitprice As Decimal = If(Not String.IsNullOrEmpty(txtPriceCost.Text.Trim.Replace("$", "")), txtPriceCost.Text.Trim.Replace("$", ""), Format(0.0, "0.0000"))
                        Dim Standardcostunits As Decimal = If(Not String.IsNullOrEmpty(dr("Standardcostunits").ToString()), Format(dr("Standardcostunits"), "0.00"), Format(0.0, "0.00"))
                        Dim Standardunitcost As Decimal = If(Not String.IsNullOrEmpty(dr("Standardunitcost").ToString()), Format(dr("Standardunitcost"), "0.0000"), Format(0.0, "0.0000"))
                        Dim Actualcostunits As Decimal = If(Not String.IsNullOrEmpty(dr("Actualcostunits").ToString()), Format(dr("Actualcostunits"), "0.00"), Format(0.0, "0.00"))
                        Dim Actualunitcost As Decimal = If(Not String.IsNullOrEmpty(dr("Actualunitcost").ToString()), Format(dr("Actualunitcost"), "0.0000"), Format(0.0, "0.0000"))
                        Dim Qty As Decimal = If(Not String.IsNullOrEmpty(eQty.Text.Trim), eQty.Text.Trim, Format(0, "0"))

                        If Actualcostunits <> 0 And Actualcostunits <> 0 Then
                            If CType((Actualunitcost * Actualcostunits * Qty), Decimal) > CType((Unitprice * Priceunits * Qty), Decimal) Then
                                If MsgBox("Do you want to sell on loss", vbYesNo + vbQuestion) = vbNo Then
                                    txtPriceCost.Focus()
                                    Return False
                                End If
                            End If
                        Else
                            If CType((Standardunitcost * Standardcostunits * Qty), Decimal) > CType((Unitprice * Priceunits * Qty), Decimal) Then
                                If MsgBox("Do you want to sell on loss", vbYesNo + vbQuestion) = vbNo Then
                                    txtPriceCost.Focus()
                                    Return False
                                End If
                            End If
                        End If
                    Else
                        If Not String.IsNullOrEmpty(dr("Standardunitcost").ToString()) And Not String.IsNullOrEmpty(txtPriceCost.Text.Trim.Replace("$", "")) Then
                            If CType(dr("Standardunitcost"), Decimal) > CType(txtPriceCost.Text.Trim.Replace("$", ""), Decimal) Then
                                If MsgBox("Do you want to sell on loss", vbYesNo + vbQuestion) = vbNo Then
                                    txtPriceCost.Focus()
                                    Return False
                                End If
                            End If
                        End If
                    End If

                End If

                If Not String.IsNullOrEmpty(dr("Priceunits").ToString()) Then
                    oItem.Priceunits = dr("Priceunits")
                End If
                If Not String.IsNullOrEmpty(dr("Priceuom").ToString()) Then
                    oItem.Priceuom = dr("Priceuom")
                End If
                If Not String.IsNullOrEmpty(txtPriceCost.Text.Trim.ToString()) Then
                    oItem.Unitprice = Convert.ToDecimal(txtPriceCost.Text.Trim.Replace("$", ""))
                End If
                If Not String.IsNullOrEmpty(dr("Standardcostunits").ToString()) Then
                    oItem.Standardcostunits = dr("Standardcostunits")
                End If
                If Not String.IsNullOrEmpty(dr("Standardcostuom").ToString()) Then
                    oItem.Standardcostuom = dr("Standardcostuom")
                End If
                If Not String.IsNullOrEmpty(dr("Standardunitcost").ToString()) Then
                    oItem.Standardunitcost = dr("Standardunitcost")
                End If
                If Not String.IsNullOrEmpty(dr("Actualcostunits").ToString()) Then
                    oItem.Actualcostunits = dr("Actualcostunits")
                End If
                If Not String.IsNullOrEmpty(dr("Actualcostuom").ToString()) Then
                    oItem.Actualcostuom = dr("Actualcostuom")
                End If
                If Not String.IsNullOrEmpty(dr("Actualunitcost").ToString()) Then
                    oItem.Actualunitcost = dr("Actualunitcost")
                End If

            End If
        End If

        oItem.EndEdit()
        oItem.Save()

        If vAllocate Then
            Dim vQty As Integer = bsItem.Current.Qty
            If vQty > 1 Then
                addMultipleEntries(vQty)
            End If
        End If

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

        'now reset the Qty Ordered to 1 for this main record
        Select Case oItem.Billable
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

        ' Add Volume and Weights
        

        oItem.Save()

    End Sub

    Private Function updateMatchingItems() As Boolean
        'when this function is called, all changes should already be saved
        'now we need to update all matching items for this workorder to
        'reflect the same values as this newly saved item
        'matching items are identified by the following:
        '  WorkOrderNumber, ItemType, ItemID

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
            Next
            oItems.Save()
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

        getProductInfo(eProduct.EditValue)
        'getProductCostInfo(eProduct.EditValue)
        'getPricingInfo(eProduct.EditValue, vCustID)
        bsItem.EndEdit()

        addPricing(eProduct.EditValue)

    End Sub

    Private Sub getProductInfo(ByVal vProdID As Integer)
        oProduct = New Product
        If oProduct.LoadByPrimaryKey(vProdID) Then
            oItem.Container = oProduct.Container
            oItem.Itemdescription = oProduct.Productdesc
            oItem.Productid = oProduct.Productid
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

            Dim oCostRec As New Productcost
            Dim oPriceRec As New Pricelist

            If oItem.Billable = True Then
                oPriceRec = getPriceListRecord(vProdID, vCustID)
                oCostRec = getProductCostRecord(vProdID, oPriceRec.Uom)

                'All UNITS and UOM should be driven by the PRICELIST record for the PRODUCT / CUSTOMER combination
                'If there is no PRICELIST record then the ItemPrice will be set to 0.00 and the 
                'UNITS and UOM will remain the default (from the PRODUCT table, as set above with PRODUCT lookup)
                If oPriceRec.Pricelistid Is Nothing Then
                    oItem.Itemprice = 0.0
                Else
                    oItem.Itemprice = oPriceRec.Unitprice
                    oItem.Uom = oPriceRec.Uom
                    oItem.Units = oPriceRec.Units
                End If

                If oCostRec.Costrecid Is Nothing Then
                    oItem.Unitcost = 0.0
                Else
                    oItem.Unitcost = oCostRec.Unitcost
                End If

            Else
                oItem.Unitcost = 0.0
                oItem.Itemprice = 0.0
            End If

            oItem.Custitemid = getProductCustomerItemID(vProdID, vCustID)
            oItem.EndEdit()
            oItem.Save()

            eContainer.EditValue = oProduct.Container
            eCustItemId.EditValue = oItem.Custitemid

        End If
    End Sub

    Private Function getPriceListRecord(vProdid As Integer, vCustID As Integer) As Pricelist
        Dim oPriceRec As New Pricelist
        Dim vLookupPrice As Decimal = 0.0
        Dim vCurrentPrice As Decimal = 0.0

        'set the price that is currently assigned to this WorkOrderItem
        If Not IsDBNull(bsItem.Current.ItemPrice) Then
            vCurrentPrice = bsItem.Current.ItemPrice
        Else
            vCurrentPrice = 0.0
        End If

        'Item is billable, proceed with looking up Product pricing from PriceList for current Customer
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

    Private Function getProductCostRecord(vProdid As Integer, vUOM As String) As Productcost
        Dim oCostRec As New Productcost
        oProductCosts = New ProductcostCollection
        oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdid))
        oProductCosts.Query.Load()
        Select Case oProductCosts.Count
            Case Is = 1
                'eUnits.EditValue = oProductCosts(0).Units
                'eUOM.EditValue = oProductCosts(0).Uom
                'eUnitCost.EditValue = oProductCosts(0).Unitcost
                'bsItem.EndEdit()
                'If oProductCosts(0).Uom <> vUOM Then
                '    MsgBox("The Cost Record for this product has a different Unit of Measure than the PriceList record for this product for the currect customer", MsgBoxStyle.Critical, "WARNING - Mismatched Unit of Measure")
                'End If
                Return oProductCosts(0)
            Case Else
                'Dim frm As New frmViewProductCostRecords
                'frm.vProductID = vProdid
                'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                '    If frm.oCost.Uom <> vUOM Then
                '        MsgBox("The selected Cost Record for this product has a different Unit of Measure than the PriceList record for this product for the currect customer", MsgBoxStyle.Critical, "WARNING - Mismatched Unit of Measure")
                '    End If
                '    Return frm.oCost
                'Else
                '    MsgBox("You did not select a valid UnitCost for the item you are attempting to add to the WorkOrder", MsgBoxStyle.Critical, "Error - Missing Data")
                '    Return oCostRec
                'End If

                Return oCostRec
        End Select
    End Function

    Private Function getProductCost(ByVal vProdID As Integer) As Decimal

        'if Item is not Billable - set to zero
        If oItem.Billable = False Then
            'eUnits.EditValue = ""
            'eUOM.EditValue = ""
            'eUnitCost.EditValue = 0.0
            'bsItem.EndEdit()
            'Exit Function
            Return 0.0
        End If

        'Item is Billable, costs required
        oProductCosts = New ProductcostCollection
        oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdID))
        oProductCosts.Query.Load()
        Select Case oProductCosts.Count
            Case Is = 1
                'eUnits.EditValue = oProductCosts(0).Units
                'eUOM.EditValue = oProductCosts(0).Uom
                'eUnitCost.EditValue = oProductCosts(0).Unitcost
                'bsItem.EndEdit()
                If IsNothing(oProductCosts(0).Unitcost) Or IsDBNull(oProductCosts(0).Unitcost) Then
                    Return 0
                Else
                    Return oProductCosts(0).Unitcost
                End If


            Case Else
                'Dim frm As New frmViewProductCostRecords
                'frm.vProductID = vProdID
                'If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                '    If IsDBNull(frm.oCost.Unitcost) Or frm.oCost.Unitcost <= 0 Then
                '        MsgBox("You did not select a valid UnitCost for the item you are attempting to add to the WorkOrder", MsgBoxStyle.Critical, "Error - Missing Data")
                '        Return 0.0
                '    End If
                '    Return frm.oCost.Unitcost
                '    '    eUnits.EditValue = frm.oCost.Units
                '    '    eUOM.EditValue = frm.oCost.Uom
                '    '    eUnitCost.EditValue = frm.oCost.Unitcost
                '    '    bsItem.EndEdit()
                'Else
                '    MsgBox("You did not select a valid UnitCost for the item you are attempting to add to the WorkOrder", MsgBoxStyle.Critical, "Error - Missing Data")
                '    Return 0.0
                'End If

                Return 0.0
        End Select
    End Function

    Private Function getProductPrice(ByVal vProdID As Integer, ByVal vCustID As Integer) As Decimal

        Dim vLookupPrice As Decimal = 0.0
        Dim vCurrentPrice As Decimal = 0.0

        'set the price that is currently assigned to this WorkOrderItem
        If Not IsDBNull(bsItem.Current.ItemPrice) Then
            vCurrentPrice = bsItem.Current.ItemPrice
        Else
            vCurrentPrice = 0.0
        End If

        'if financials are not required, set to zero (item is NOT billable)
        If oItem.Billable = False Then
            'eItemPrice.EditValue = 0.0
            'bsItem.EndEdit()
            Return 0.0
        End If

        'Item is billable, proceed with looking up Product pricing from PriceList for current Customer
        oPrices = New PricelistCollection
        oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdID), oPrices.Query.Custid.Equal(vCustID), oPrices.Query.Effectivedate.LessThanOrEqual(Now.Date)).OrderBy(oPrices.Query.Effectivedate.Descending)
        oPrices.Query.Load()
        Select Case oPrices.Count
            Case Is > 0
                vLookupPrice = If(Not String.IsNullOrEmpty(oPrices(0).Unitprice.ToString()), oPrices(0).Unitprice, Format(0.0, "0.00"))
            Case Else
                MsgBox("The product you selected is not in the Customer's price list.", MsgBoxStyle.Critical, "Error - Price List")
                vLookupPrice = 0.0
        End Select

        'we now have the lookup price from the Customer Price List
        Select Case vEditType
            Case "ADD"
                'eItemPrice.EditValue = vLookupPrice
                'eCustItemId.EditValue = vCustItemID
                Return vLookupPrice
            Case "EDIT"
                If vLookupPrice <> vCurrentPrice And vCurrentPrice > 0.0 Then
                    If MsgBox("The price on this Item is not the same as the Item Price in the Customer's Price List. Do you want to change the Item's price to match the price list?", MsgBoxStyle.YesNo, "Confirm - Change Price") = MsgBoxResult.Yes Then
                        Return vLookupPrice
                    Else
                        Return vCurrentPrice
                    End If
                Else
                    Return vLookupPrice
                End If
        End Select

    End Function

    Private Function getProductCustomerItemID(vProdID As Integer, vCustID As Integer) As String

        oPrices = New PricelistCollection
        oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdID), oPrices.Query.Custid.Equal(vCustID), oPrices.Query.Effectivedate.LessThanOrEqual(Now.Date)).OrderBy(oPrices.Query.Effectivedate.Descending)
        oPrices.Query.Load()
        Select Case oPrices.Count
            Case Is > 0
                Return oPrices(0).Customerproductcode
            Case Else
                Return ""
        End Select

    End Function


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

    Private Sub eUnitCost_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        If IsDBNull(oItem.Productid) Then
            MsgBox("You must select a product first", MsgBoxStyle.Critical, "Error - No product selected")
            Exit Sub
        End If
        'Dim frm As New frmViewProductCostRecords
        'frm.vProductID = oItemList.Productid
        'If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    If oItemList.Uom <> frm.oCost.Uom Then
        '        MsgBox("You selected a cost record that has a different Unit of Measure than the PRODUCT/PRICELIST record for this item!", MsgBoxStyle.Critical, "WARNING - Mismatched Unit of Measure")
        '    End If
        '    oItemList.Unitcost = frm.oCost.Unitcost
        '    oItemList.Save()

        '    bsItem.EndEdit()
        'Else
        '    MsgBox("No product cost record selected")
        'End If
    End Sub

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

    Private Sub eBillable_CheckedChanged(sender As Object, e As EventArgs) Handles eBillable.CheckedChanged
        If eProduct.EditValue Is Nothing Then
            Exit Sub
        End If
        If IsDBNull(eProduct.EditValue) Then
            Exit Sub
        End If

        If eBillable.CheckState = CheckState.Checked Then
            'Item has now been marked as BILLABLE
            If IsDBNull(oItem.Unitcost) Or oItem.Unitcost <= 0 Then
                oItem.Unitcost = getProductCost(eProduct.EditValue)
            End If
            oItem.Itemprice = getProductPrice(eProduct.EditValue, vCustID)
        Else
            'Item has now been marked as NON-BILLABLE
            oItem.Unitcost = 0.0
            oItem.Itemprice = 0.0
        End If

        oItem.Save()

        addPricing(eProduct.EditValue)

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

        getProductInfo(eProduct.EditValue)
        bsItem.EndEdit()
        addPricing(eProduct.EditValue)
    End Sub
End Class