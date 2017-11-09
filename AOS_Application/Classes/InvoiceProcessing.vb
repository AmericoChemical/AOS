Module InvoiceProcessing

    Public Sub CreateInvoiceFromWorkorder(vOrd As Integer)

        Dim oWO As New Workorder
        If Not oWO.LoadByPrimaryKey(vOrd) Then
            Exit Sub
        End If

        Dim vCurrentStatus As String = oWO.Orderstatus

        'set some variables
        Dim vLoad As Integer = getLoadIDByWorkOrderNumber(vOrd)

        'first, create invoice records
        'this will update workorder and workorderitem records as COMPLETE
        Dim vInvoiceNum As Integer = createInvoice(vOrd, vLoad)
        If vInvoiceNum <= 0 Then
            MsgBox("Error in creating invoice", MsgBoxStyle.Critical, "ERROR - Invoice not created")
            Exit Sub
        End If
        'at this point we have an new invoice created

        'second, display invoice for editing, capture the form dialog results (SAVE OR CANCEL) for next steps.
        Dim frm As New frmAddEditInvoice
        frm.vInvoiceNum = vInvoiceNum
        frm.vEditType = "EDIT"
        Dim vResult As DialogResult = frm.ShowDialog()
        Select Case vResult
            Case DialogResult.OK
                'if saved, workorder and workorderitem records are okay as COMPLETE; update load to DELIVERED
                Dim oLoad As New Load
                If oLoad.LoadByPrimaryKey(vLoad) Then
                    oLoad.LoadStatus = "DELIVERED"
                    oLoad.Save()
                End If
            Case DialogResult.Cancel
                'if cancelled, delete invoice record and reset workorder and workorderitems to previous status, leave load in IN TRANSIT
                updateWorkOrderStatus(vOrd, vCurrentStatus)
                'remove any invoice reference from WorkOrderItem records for this workorder
                removeInvoiceReferenceDataFromWorkOrder(vOrd)
                removeInvoiceReferenceDataFromLoadBilling(vLoad)
                If Not deleteInvoice(vInvoiceNum) Then
                    MsgBox("Error in deleting the Invoice from the database. See Data Administrator", MsgBoxStyle.Critical, "Error - Invoice Not Deleted")
                End If

        End Select
    End Sub

    Public Sub updateWorkOrderStatus(vOrd As Integer, vStatus As String)

        Try
            Dim oRec As New Workorder
            If oRec.LoadByPrimaryKey(vOrd) Then
                oRec.Orderstatus = vStatus
                oRec.Modifyby = vCurrentUserLogin
                oRec.Modifytime = Now
                oRec.Save()
            End If

            Dim oItems As New WorkorderitemCollection
            oItems.Query.Where(oItems.Query.Workordernumber.Equal(vOrd))
            If oItems.Query.Load Then
                For Each oItem As Workorderitem In oItems
                    oItem.Workorderitemstatus = vStatus
                Next
                oItems.Save()
            End If
        Catch ex As Exception
            MsgBox("Error in updating status of selected Work Order", MsgBoxStyle.Critical, "Error")
        End Try

        'Update any shipment data that is linked to this work order
        updateWorkOrderShipmentData(vOrd)
    End Sub

    Public Function getLoadIDByWorkOrderNumber(vWONum As Integer) As Integer
        If IsDBNull(vWONum) Then
            Return 0
        End If

        Dim vLoadWorkOrders As New ViewLoadWorkordersCollection
        vLoadWorkOrders.Query.Where(vLoadWorkOrders.Query.Workordernumber.Equal(vWONum))
        If vLoadWorkOrders.Query.Load Then
            Return vLoadWorkOrders(0).LoadID
        Else
            Return 0
        End If

    End Function

    Public Sub removeInvoiceReferenceDataFromLoadBilling(vID As Integer)
        Try
            Dim oBillings As LoadbillingCollection
            oBillings = New LoadbillingCollection
            oBillings.Query.Where(oBillings.Query.Loadid.Equal(vID))
            If oBillings.Query.Load Then
                For Each oBill As Loadbilling In oBillings
                    oBill.InvoiceNumber = 0
                    oBill.Status = "PENDING"
                Next
                oBillings.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub removeInvoiceReferenceDataFromWorkOrder(vID As Integer)
        Try
            Dim oItems As WorkorderitemCollection
            oItems = New WorkorderitemCollection
            oItems.Query.Where(oItems.Query.Workordernumber.Equal(vID))
            If oItems.Query.Load Then
                For Each oItem As Workorderitem In oItems
                    oItem.Invoiceitemnumber = 0
                Next
            End If
            oItems.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






    Public Function createInvoice(ByVal vWONum As Integer, Optional vLoadID As Integer = 0) As Integer

        Dim str As String = "Are you sure you want to create an Invoice for Work Order# " & vWONum.ToString & "?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Return 0
        End If

        Dim vInvoiceDate As Date = getUserDate("Enter Invoice Date")

        Dim oInvoice As Invoice
        Dim oCustomer As Customer
        Dim oWorkOrder As Workorder
        Dim oWOItemsNB As WorkorderitemCollection
        Dim oWOItems As WorkorderitemCollection
        Dim oLoad As Load
        Dim oCarrier As Carrier
        Dim oLogistics As Logistics

        'fetch Work Order record
        oWorkOrder = New Workorder
        If oWorkOrder.LoadByPrimaryKey(vWONum) = False Then
            MsgBox("No Work Order record retrieved. Invoice cannot be created.", MsgBoxStyle.Critical, "Error - No Work Order")
            Return 0
        End If

        'fetch Customer record
        oCustomer = New Customer
        If Not oCustomer.LoadByPrimaryKey(oWorkOrder.Custid) Then
            MsgBox("No matching customer record for the Work Order selected. Invoice cannot be created without a Customer assigned to the Work Order", MsgBoxStyle.Critical, "Error - No Customer")
            Return 0
        End If

        'now determine is there are billable workorderitem records
        'if there are, proceed. If none, then do not make an invoice

        'fetch Billable WorkOrderItem records
        oWOItems = New WorkorderitemCollection
        oWOItems.Query.Where(oWOItems.Query.Workordernumber.Equal(vWONum), oWOItems.Query.Billable.Equal(1))
        oWOItems.Query.Load()
        If oWOItems.Count <= 0 Then
            MsgBox("No Billable Work Order Items were found for the Work Order selected. Invoice cannot be created.", MsgBoxStyle.Critical, "Error - No Billable Work Order Items")
            Return 0
        End If

        'fetch any Non-Billable work order items
        oWOItemsNB = New WorkorderitemCollection
        oWOItemsNB.Query.Where(oWOItemsNB.Query.Workordernumber.Equal(vWONum), oWOItemsNB.Query.Billable.Equal(0))
        oWOItemsNB.Query.Load()
        If oWOItemsNB.Count > 0 Then
            MsgBox("There are " & oWOItemsNB.Count.ToString & " non-Billable Work Order Items on the selected Work Order. These items will NOT be added to any invoice created.", MsgBoxStyle.Information, "FYI")
        End If


        'fetch Load record - there may or may not be a LoadID passed to this function, depending on what kind of work order is being invoiced.
        oLoad = New Load
        If vLoadID <> 0 Then
            If Not oLoad.LoadByPrimaryKey(vLoadID) Then
                MsgBox("Could not retrieve the related Load record(s) for the Work Order selected. Invoice cannot be created.", MsgBoxStyle.Critical, "Error - No Load(s)")
                Return 0
            End If
        End If

        'Create new Invoice record
        oInvoice = New Invoice
        oInvoice.Invoicedate = vInvoiceDate
        oInvoice.Invoicestatus = "PENDING"
        oInvoice.Createdby = vCurrentUserLogin
        oInvoice.Createdtime = Now
        oInvoice.Modifyby = vCurrentUserLogin
        oInvoice.Modifytime = Now
        oInvoice.Custid = oWorkOrder.Custid
        oInvoice.Billaddress1 = oCustomer.Custbilladdress1
        oInvoice.Billaddress2 = oCustomer.Custbilladdress2
        oInvoice.Billcity = oCustomer.Custbillcity
        oInvoice.Billstateprov = oCustomer.Custbillstateprov
        oInvoice.Billpostalcode = oCustomer.Custbillpostalcode
        oInvoice.Billcountry = oCustomer.Custbillcountry
        oInvoice.Billcontact = oCustomer.Custbillcontact
        oInvoice.Shipaddress1 = oWorkOrder.Shipaddress1
        oInvoice.Shipaddress2 = oWorkOrder.Shipaddress2
        oInvoice.Shipcity = oWorkOrder.Shipcity
        oInvoice.Shipstateprov = oWorkOrder.Shipstateprov
        oInvoice.Shippostalcode = oWorkOrder.Shippostalcode
        oInvoice.Shipcountry = oWorkOrder.Shipcountry
        oInvoice.Customerpo = oWorkOrder.Customerpo
        oInvoice.Fob = oWorkOrder.Fob

        If vLoadID <> 0 Then
            'there is a Load ID passed to the function
            'try to find Schedule Carrier Name from Carrier Table
            oCarrier = New Carrier
            If IsDBNull(oLoad.ScheduledCarrierID) Or oLoad.ScheduledCarrierID Is Nothing Then
                oInvoice.Freightcarrier = oWorkOrder.Freightcarrier
            Else
                If oCarrier.LoadByPrimaryKey(oLoad.ScheduledCarrierID) Then
                    oInvoice.Freightcarrier = oCarrier.CarrierName
                Else
                    oInvoice.Freightcarrier = oWorkOrder.Freightcarrier
                End If
            End If

        Else
            oInvoice.Freightcarrier = oWorkOrder.Freightcarrier
        End If

        If vLoadID <> 0 Then
            'lookup Logistics Provider
            oLogistics = New Logistics
            If IsDBNull(oLoad.ScheduledLogisticsID) Or oLoad.ScheduledLogisticsID Is Nothing Then
                oInvoice.Logisticsid = oWorkOrder.Logisticsid
                If oLogistics.LoadByPrimaryKey(oWorkOrder.Logisticsid) Then
                    oInvoice.Freightcarrier = oInvoice.Freightcarrier & " / " & oLogistics.Logisticsname
                End If
            Else
                oInvoice.Logisticsid = oLoad.ScheduledLogisticsID
                If oLogistics.LoadByPrimaryKey(oLoad.ScheduledLogisticsID) Then
                    oInvoice.Freightcarrier = oInvoice.Freightcarrier & " / " & oLogistics.Logisticsname
                End If
            End If
        End If

        oInvoice.Save()

        Dim vNewInvNum As Integer = oInvoice.Invoicenumber

        'We now have a new Invoice record in the database

        'Create new invoice item records from Work Order items collection
        For Each woItem As Workorderitem In oWOItems
            If Not createInvoiceItemFromWorkOrderItem(woItem.Workorderitemnumber, vNewInvNum) Then
                MsgBox("Could not create an Invoice Item for Work Order Item Number " & woItem.Workorderitemnumber, MsgBoxStyle.Critical, "Error - Invoice Failed")
                deleteInvoice(vNewInvNum)
                Return 0
            End If
        Next

        'Create a Freight Invoice Item for any freight to be billed from the related LoadID
        Dim vFreightBilledAmt As Decimal = 0.0
        Dim oBillings As New LoadbillingCollection
        oBillings.Query.Where(oBillings.Query.Loadid.Equal(vLoadID))
        If oBillings.Query.Load Then
            For Each oBill As Loadbilling In oBillings
                vFreightBilledAmt = vFreightBilledAmt + oBill.BilledAmount
                oBill.InvoiceNumber = vNewInvNum
                oBill.Status = "INVOICED"
            Next
            oBillings.Save()
        End If
        'now we have the amount to bill the customer for freight
        If vFreightBilledAmt > 0 Then
            'create invoice item record for the freight billed to the related load
            Dim oInvItem As New Invoiceitem
            oInvItem.Invoicenumber = vNewInvNum
            oInvItem.Productdesc = "FREIGHT"
            oInvItem.Itemdescription = "FREIGHT"
            oInvItem.Itemtype = "FREIGHT"
            oInvItem.Quantity = 1
            oInvItem.Uom = "MISC"
            oInvItem.Itemprice = vFreightBilledAmt
            oInvItem.Unitcost = vFreightBilledAmt
            oInvItem.Extcost = vFreightBilledAmt
            oInvItem.Extprice = vFreightBilledAmt
            oInvItem.Grossprofit = 0.0
            oInvItem.Taxable = 0
            oInvItem.Save()
        End If

        'determine invoice subtotal
        oInvoice.Subtotal = getInvoiceItemsTotals(vNewInvNum)
        'determine invoice sales tax
        oInvoice.Salestax = oInvoice.Subtotal * getSalesTaxRate()
        'determine invoice totals
        oInvoice.Total = oInvoice.Subtotal + oInvoice.Salestax
        oInvoice.Save()

        'update the status of the shipment so it disappears from the "WorkOrders waiting to be invoiced" list
        oWorkOrder.Orderstatus = "COMPLETE"
        oWorkOrder.Save()

        Return vNewInvNum

    End Function

    Public Function deleteInvoice(vInvNum As Integer, ByVal Optional bDeleteReasonRequired As Boolean = False) As Boolean

        Dim str As String
        str = "Are you sure you want to delete Invoice# " & vInvNum.ToString & "?" & Chr(13) & Chr(13)
        str &= "THIS CHANGE CANNOT BE UNDONE!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Delete Request") = MsgBoxResult.No Then
            Exit Function
        End If

        Dim vInv As Integer = vInvNum

        'if payments have been received against this invoice, prevent deletion
        Dim oPmts As New InvoicepaymentCollection
        oPmts.Query.Where(oPmts.Query.Invoicenumber.Equal(vInv))
        If oPmts.Query.Load Then
            MsgBox("This invoice already has payments recorded against it and can not be deleted.", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        'first add history
        If bDeleteReasonRequired Then
            Dim oInvoiceHistoryHeader As New Invoicehistoryheader
            oInvoiceHistoryHeader = frmAddEditInvoice.SaveInvoiceHistoryAll(vInvNum)
            Dim frmChangeReason As New frmInvoiceChangeReason
            frmChangeReason.vInvoiceNum = vInv
            frmChangeReason.vEditType = "DELETE"
            frmChangeReason.vInvoiceHistoryHeader = oInvoiceHistoryHeader
            frmChangeReason.ShowDialog()
            If (String.IsNullOrEmpty(oInvoiceHistoryHeader.Changereason)) Then
                MsgBox("You must Enter Reason for Deleteing Invoice")
                Return False
            End If
        End If
        'first delete any commissions from this invoice
        Try
                    Dim oComms As New CommissionCollection
                    oComms.Query.Where(oComms.Query.Invoicenumber.Equal(vInv))
                    If oComms.Query.Load Then
                        oComms.MarkAllAsDeleted()
                        oComms.Save()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Function
                End Try

                'second, delete any invoice items for this invoice
                Try
                    Dim oInvItems As New InvoiceitemCollection
                    oInvItems.Query.Where(oInvItems.Query.Invoicenumber.Equal(vInv))
                    If oInvItems.Query.Load Then
                        oInvItems.MarkAllAsDeleted()
                        oInvItems.Save()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Function
                End Try

                'finally, delete invoice record itself
                Try
                    Dim oInvoice As Invoice
                    oInvoice = New Invoice
                    oInvoice.LoadByPrimaryKey(vInv)
                    oInvoice.MarkAsDeleted()
                    oInvoice.Save()
                Catch ex As Exception
                    MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
                End Try
                Return True

    End Function

    Private Function createInvoiceItemFromWorkOrderItem(vItemID As Integer, vInvNum As Integer) As Boolean

        'in creating invoice items from work order items, we make the following assumptions:
        '1) all item costs are carried forward from the work order, and not recalculated
        '2) all quantities for work order items are considered the correct quantity to be invoiced - no partial shipped work order items.

        Dim oWOItem As Workorderitem
        Dim oWO As Workorder
        Dim oProduct As Product
        Dim oPriceList As Pricelist
        Dim oItem As Invoiceitem

        Dim vPriceID As Integer = 0

        'fetch workorderitem record
        oWOItem = New Workorderitem
        If Not oWOItem.LoadByPrimaryKey(vItemID) Then
            MsgBox("Cannot retrieve Work Order Item record " & vItemID.ToString & ".", MsgBoxStyle.Critical, "Error - No Work Order Item Record")
            Return False
        End If

        'lookup WorkOrder record from WorkOrderItem record
        oWO = New Workorder
        If Not oWO.LoadByPrimaryKey(oWOItem.Workordernumber) Then
            MsgBox("Cannot retrieve Work Order record.", MsgBoxStyle.Critical, "Error - Work Order")
            Return False
        End If

        'lookup product record
        oProduct = New Product
        If Not oProduct.LoadByPrimaryKey(oWOItem.Productid) Then
            MsgBox("Error retrieving Product Information", MsgBoxStyle.Critical, "Error - No product found")
            Return False
        End If

        'We need to lookup the PRICELIST record for the PRODUCT/CUSTOMER combination to get the TAXABLE and UNITORCONTAINER billing preference - Some Customers always want to be billed by UNITS, never containers.
        Dim vTaxable As Boolean
        Dim vBillByUnitOrContainer As String

        'lookup product in pricelist table to determine if item is taxable
        oPriceList = New Pricelist
        oPriceList.Query.Where(oPriceList.Query.Productid.Equal(oWOItem.Productid), oPriceList.Query.Custid.Equal(oWO.Custid))
        If oPriceList.Query.Load Then
            'successfully locate price list record that matches workorder item record on PRODUCT, CUSTOMER, and PRICING UOM as selected on WORKORDER
            vTaxable = oPriceList.Taxable
            vBillByUnitOrContainer = oPriceList.Unitorcontainer
        Else
            'did not succeed in looking up pricelist record - default to non-taxable
            MsgBox("A PriceList record was not found for Product " & oWOItem.Productid & " for this customer. We will assume that the product is NOT taxable and that it should be billed by UNITS. You can edit these values later.", MsgBoxStyle.Critical, "ERROR - No PriceList record")
            vTaxable = False
            vBillByUnitOrContainer = "U"
        End If

        'create invoice item object
        oItem = New Invoiceitem
        oItem.Invoicenumber = vInvNum
        oItem.Productid = oWOItem.Productid
        oItem.Productdesc = oProduct.Productdesc
        oItem.Itemtype = oWOItem.Itemtype
        oItem.Itemid = oWOItem.Itemid
        oItem.Itemdescription = oWOItem.Itemdescription
        oItem.Container = oWOItem.Container
        oItem.Taxable = vTaxable
        oItem.Invitemnumber = oWOItem.Invitemnumber
        oItem.Workorderitemnumber = oWOItem.Workorderitemnumber
        oItem.Unitorcontainer = vBillByUnitOrContainer

        'Pull pricing and costing values from WORKORDERITEM record
        oItem.Priceunits = oWOItem.Priceunits
        oItem.Priceuom = oWOItem.Priceuom
        oItem.Unitprice = oWOItem.Unitprice
        oItem.Standardcostunits = oWOItem.Standardcostunits
        oItem.Standardcostuom = oWOItem.Standardcostuom
        oItem.Standardunitcost = oWOItem.Standardunitcost
        oItem.Actualcostunits = oWOItem.Actualcostunits
        oItem.Actualcostuom = oWOItem.Actualcostuom
        oItem.Actualunitcost = oWOItem.Actualunitcost

        'Calculate Quantity, Extended Sales Price, Standard Costs, and Actual Costs
        Select Case oWOItem.Unitorcontainer  'this is how the quantity value on the WORKORDER was determined - by containers or units - different than how it should be billed
            Case "C"
                'WORKORDERITEM-qty is in number of containers
                If vBillByUnitOrContainer = "C" Then
                    oItem.Quantity = oWOItem.Qty
                    oItem.Extsalesprice = oItem.Quantity * oItem.Priceunits * oItem.Unitprice
                    'set the display price for the invoice
                    oItem.Itemprice = oItem.Priceunits * oItem.Unitprice
                Else
                    oItem.Quantity = oWOItem.Qty * oWOItem.Priceunits
                    oItem.Extsalesprice = oItem.Quantity * oItem.Unitprice
                    oItem.Itemprice = oItem.Unitprice
                End If
                oItem.Extstandardcost = oWOItem.Qty * oWOItem.Standardcostunits * oWOItem.Standardunitcost
                oItem.Extactualcost = oWOItem.Qty * oWOItem.Actualcostunits * oWOItem.Actualunitcost
            Case Else
                'WORKORDERITEM-qty is int number of units
                If vBillByUnitOrContainer = "C" Then
                    oItem.Quantity = oWOItem.Qty / oWOItem.Priceunits
                    oItem.Extsalesprice = oItem.Quantity * oItem.Priceunits * oItem.Unitprice
                    'set the display price for the invoice
                    oItem.Itemprice = oItem.Priceunits * oItem.Unitprice
                Else
                    oItem.Quantity = oWOItem.Qty
                    oItem.Extsalesprice = oItem.Quantity * oItem.Unitprice
                    oItem.Itemprice = oItem.Unitprice
                End If
                oItem.Extstandardcost = oWOItem.Qty * oWOItem.Standardunitcost
                oItem.Extactualcost = oWOItem.Qty * oWOItem.Actualunitcost
        End Select

        'For Legacy processes
        oItem.Extprice = oItem.Extsalesprice
        oItem.Extcost = oItem.Extstandardcost
        oItem.Grossprofit = oItem.Extprice - oItem.Extcost
        oItem.Uom = oItem.Priceuom
        oItem.Custitemid = oWOItem.Custitemid

        oItem.EndEdit()
        oItem.Save()

        'now update the WorkOrderItem record status to "COMPLETE"
        oWOItem.Workorderitemstatus = "COMPLETE"
        oWOItem.Invoiceitemnumber = oItem.Invoiceitemnumber
        oWOItem.Save()

        Return True
    End Function

    Private Function getInvoiceItemsTotals(vInvNum As Integer) As Decimal
        Dim str As String = Nothing
        Dim cmd As SqlClient.SqlCommand = Nothing
        Dim vResult As Decimal = 0.0
        Try
            str = "SELECT SUM(EXTPRICE) FROM INVOICEITEM WHERE INVOICENUMBER = " & vInvNum.ToString
            cmd = New SqlClient.SqlCommand(str, sqlcnn)
            sqlcnn.Open()
            vResult = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox("Error in calculating Invoice Subtotals for Invoice # " & vInvNum.ToString, MsgBoxStyle.Critical, "Error - No Subtotal")
            Return 0
        Finally
            sqlcnn.Close()
        End Try
        sqlcnn.Close()
        Return vResult
    End Function

    Private Function getSalesTaxRate() As Decimal
        Dim oParms As New Sysparameters
        If oParms.LoadByPrimaryKey(1) Then
            Return oParms.Defaultsalestaxrate
        Else
            Return 0
        End If
    End Function
End Module
