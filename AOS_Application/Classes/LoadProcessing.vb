Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces

Module LoadProcessing

    Public Enum LoadStatus
        PENDING
    End Enum

    Public Enum LoadSourceType
        WORKORDER
        PRCH
    End Enum

#Region "WORKORDER - SHIPMENT DATA"

    Public Function updateWorkOrderShipmentData(ByVal vWorkOrderNum As Integer) As Boolean

        'first, gather workorder and workorderitem data collections
        Dim oWO As New Workorder
        Try
            If Not oWO.LoadByPrimaryKey(vWorkOrderNum) Then
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error in retrieving the WorkOrder selected", MsgBoxStyle.Critical, "Error")
            Return False
        End Try


        Dim vReturnValue As Boolean
        'next, check the status of the workorder. Then decide what to do with it
        Select Case oWO.Orderstatus
            Case "IN PROCESS"
                vReturnValue = updateShipmentDataFromInProcessWorkorder(vWorkOrderNum)
            Case "CANCELLED"
                vReturnValue = updateShipmentDataFromCancelledWorkorder(vWorkOrderNum)
            Case Else
                'Do nothing
                vReturnValue = True
        End Select

        If vReturnValue = False Then
            Return vReturnValue
        End If


        'now gather any and all loads related/linked to this workorder and update freight settings from workorder
        'NOTE: ALL SETTINGS FOR TRANSPORTATION ARE CONTROLLED BY THE WORKORDER AND CANNOT BE CHANGED DIRECTLY ON THE LOAD ITSELF
        Dim oLoads As New ViewLoadWorkordersCollection
        oLoads.Query.Where(oLoads.Query.Workordernumber.Equal(vWorkOrderNum))
        If oLoads.Query.Load Then
            For Each oLoad As ViewLoadWorkorders In oLoads
                Dim rLoad As New Load
                If rLoad.LoadByPrimaryKey(oLoad.LoadID) Then
                    rLoad.Fob = oWO.Fob
                    rLoad.BillCustomer = oWO.Freightbillcustomer
                    rLoad.AddToInvoice = oWO.Freightoninvoice
                    If oWO.Transporttype <> "DIRECT" Then
                        'only update Planned Departure Date if the Work Order is NOT a DIRECT order
                        rLoad.PlannedDepartureDate = oWO.Plannedshipdate
                    End If
                    rLoad.PlannedDeliveryDate = oWO.Deliverydate
                    rLoad.CarrierID = oWO.Carrierid
                    rLoad.LogisticsID = oWO.Logisticsid
                    Select Case oWO.Transporttype
                        Case "OUTBOUND"
                            rLoad.LoadType = "OUTBOUND"
                        Case "DIRECT"
                            rLoad.LoadType = "DIRECT"
                        Case Else
                            rLoad.LoadType = "INTERNAL"
                    End Select
                    rLoad.LoadNotes = oWO.Transportationnotes
                    rLoad.Freezeprotectflag = oWO.Freezeprotectflag
                    rLoad.OrSoonerFlag = oWO.Orsoonerflag
                    rLoad.Save()

                    'finally, update the load summary data
                    UpdateLoadSummaryData(rLoad.LoadID)
                End If
            Next
        End If

        Return True

    End Function

    Private Function updateShipmentDataFromInProcessWorkorder(vWorkOrderNum As Integer) As Boolean

        'identify and retrieve work order record
        Dim oWO As New Workorder
        Try
            If Not oWO.LoadByPrimaryKey(vWorkOrderNum) Then
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error in retrieving the WorkOrder selected", MsgBoxStyle.Critical, "Error")
            Return False
        End Try

        'identify and retrieve workorderitem records linked to LoadItem records
        Dim oItems As New ViewWorkOrderLoadItemLinkCollection
        oItems.Query.Where(oItems.Query.Workordernumber.Equal(vWorkOrderNum))
        Try
            If Not oItems.Query.Load Then
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error in retrieving the WorkOrderItems selected", MsgBoxStyle.Critical, "Error")
            Return False
        End Try

        'scan item collection to determine maximum LoadID. We will assume that this is the more empty of Loads
        'and we can add any workorder items to this load if we need to
        'if there are NO loads yet assigned to workorderitems, then we need to create a load before we can 
        'continue to process the workorderitems.

        Dim vLoadID As Integer = 0
        For Each oItem As ViewWorkOrderLoadItemLink In oItems
            If oItem.LoadID IsNot Nothing Or Not IsDBNull(oItem.LoadID) Then
                If oItem.LoadID > vLoadID Then
                    vLoadID = oItem.LoadID
                End If
            End If
        Next
        'add a new load record to the database if there were no loads already linked to the workorder
        If vLoadID = 0 Then
            vLoadID = createNewLoad(vWorkOrderNum)
            If vLoadID <= 0 Then
                MsgBox("There is an error in identifying Load Number to update", MsgBoxStyle.Critical, "Error - No Load to Update")
                Return False
            End If
        End If

        'we now have a default LoadID to use to add/update workorderItems to

        'scan all items in collection and process related LoadItem records
        For Each oItem As ViewWorkOrderLoadItemLink In oItems
            If oItem.LoadItemID Is Nothing Or IsDBNull(oItem.LoadItemID) Then
                If Not addWorkOrderItemToLoad(oItem.Workorderitemnumber, vLoadID) Then
                    Return False
                End If
            Else
                If Not updateLoadItem(oItem.Workorderitemnumber, oItem.LoadItemID) Then
                    Return False
                End If
            End If
        Next

        'finally, update the load summary data
        UpdateLoadSummaryData(vLoadID)

        Return True

    End Function

    Private Function createNewLoad(vWorkOrderNum As Integer) As Integer

        'first, get the workorder record to retrieve necessary data items
        Dim oWO As New Workorder
        If Not oWO.LoadByPrimaryKey(vWorkOrderNum) Then
            Return 0
        End If

        'now, add a new Load record to the database
        Try
            Dim oLoad As New Load
            oLoad.CreatedBy = vCurrentUserLogin
            oLoad.CreatedTime = Now
            oLoad.ModifiedBy = vCurrentUserLogin
            oLoad.ModifiedTime = Now
            oLoad.LoadStatus = LoadStatus.PENDING.ToString()
            oLoad.PlannedDeliveryDate = oWO.Deliverydate
            If oWO.Transporttype = "DIRECT" Then
                oLoad.PlannedDepartureDate = Nothing
            Else
                oLoad.PlannedDepartureDate = oWO.Plannedshipdate
            End If
            oLoad.CarrierID = oWO.Carrierid
            oLoad.LogisticsID = oWO.Logisticsid
            oLoad.CustID = oWO.Custid
            oLoad.Fob = oWO.Fob
            oLoad.BillCustomer = oWO.Freightbillcustomer
            oLoad.AddToInvoice = oWO.Freightoninvoice
            oLoad.LoadType = oWO.Transporttype
            oLoad.Freezeprotectflag = oWO.Freezeprotectflag
            oLoad.OrSoonerFlag = oWO.Orsoonerflag

            Select Case oWO.Transporttype
                Case "DIRECT"
                    oLoad.OriginType = "VENDOR"
                    oLoad.OriginID = 0
                    oLoad.OriginName = ""
                    oLoad.OriginAddress1 = ""
                    oLoad.OriginAddress2 = ""
                    oLoad.OriginCity = ""
                    oLoad.OriginState = ""
                    oLoad.OriginZip = ""
                    oLoad.OriginCountry = ""
                    oLoad.OriginContact = ""
                    oLoad.OriginPhone = ""
                Case Else
                    Dim oWhse As New Warehouse
                    If oWhse.LoadByPrimaryKey(1) Then
                        oLoad.OriginType = "WAREHOUSE"
                        oLoad.OriginID = 1
                        oLoad.OriginName = oWhse.Warehousename
                        oLoad.OriginAddress1 = oWhse.Warehouseaddress
                        oLoad.OriginAddress2 = ""
                        oLoad.OriginCity = oWhse.Warehousecity
                        oLoad.OriginState = oWhse.Warehousestate
                        oLoad.OriginZip = oWhse.Warehousezipcode
                        oLoad.OriginCountry = "United States"
                        oLoad.OriginContact = "Shipping Clerk"
                        oLoad.OriginPhone = "630-588-0830"
                    End If
            End Select

            'Select Case oWO.Vendorid
            '    Case 99
            '        Dim oWhse As New Warehouse
            '        If oWhse.LoadByPrimaryKey(1) Then
            '            oLoad.OriginType = "WAREHOUSE"
            '            oLoad.OriginID = 1
            '            oLoad.OriginName = oWhse.Warehousename
            '            oLoad.OriginAddress1 = oWhse.Warehouseaddress
            '            oLoad.OriginAddress2 = ""
            '            oLoad.OriginCity = oWhse.Warehousecity
            '            oLoad.OriginState = oWhse.Warehousestate
            '            oLoad.OriginZip = oWhse.Warehousezipcode
            '            oLoad.OriginCountry = "United States"
            '            oLoad.OriginContact = "Shipping Clerk"
            '            oLoad.OriginPhone = "630-588-0830"
            '        End If
            '    Case Else
            '        Dim oVend As New Vendor
            '        If oVend.LoadByPrimaryKey(oWO.Vendorid) Then
            '            oLoad.OriginType = "VENDOR"
            '            oLoad.OriginID = oWO.Vendorid
            '            oLoad.OriginName = oVend.Vendorname
            '            oLoad.OriginAddress1 = oVend.Vendoraddress1
            '            oLoad.OriginAddress2 = oVend.Vendoraddress2
            '            oLoad.OriginCity = oVend.Vendorcity
            '            oLoad.OriginState = oVend.Vendorstate
            '            oLoad.OriginZip = oVend.Vendorzip
            '            oLoad.OriginCountry = "United States"
            '            oLoad.OriginContact = oVend.Vendorcontact
            '            oLoad.OriginPhone = oVend.Vendorphone
            '        End If
            'End Select

            Dim oCust As New Customer
            If oCust.LoadByPrimaryKey(oWO.Custid) Then
                oLoad.DestType = "CUSTOMER"
                oLoad.DestID = oCust.Custid
                oLoad.DestName = oCust.Custname
                oLoad.DestAddress1 = oCust.Custshipaddress1
                oLoad.DestAddress2 = oCust.Custshipaddress2
                oLoad.DestCity = oCust.Custshipcity
                oLoad.DestState = oCust.Custshipstateprov
                oLoad.DestZip = oCust.Custshippostalcode
                oLoad.DestCountry = oCust.Custshipcountry
                oLoad.DestPhone = oCust.Custphone
                oLoad.DestContact = oWO.Shipcontact
                oLoad.LoadNotes = oCust.Transportationnotes
            End If
            oLoad.Save()
            Return oLoad.LoadID
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error - Could not add New Load")
            Return 0
        End Try

        Return 0

    End Function

    Private Function addWorkOrderItemToLoad(vWorkOrderItemNumber As Integer, vLoadID As Integer) As Boolean

        Dim oItem As New Workorderitem
        Dim oProduct As New Product
        Dim oContainer As New Container

        'get all related database records
        If Not oItem.LoadByPrimaryKey(vWorkOrderItemNumber) Then
            MsgBox("Error in retrieving WorkOrder item data", MsgBoxStyle.Critical, "Error - " & vWorkOrderItemNumber.ToString)
            Return False
        End If
        If Not oProduct.LoadByPrimaryKey(oItem.Productid) Then
            MsgBox("Error in retrieving Product data", MsgBoxStyle.Critical, "Error - " & oItem.Productid.ToString)
            Return False
        End If
        If Not oContainer.LoadByPrimaryKey(oItem.Container) Then
            MsgBox("Error in retrieving Container data", MsgBoxStyle.Critical, "Error - " & oProduct.Container)
            Return False
        End If

        Dim oLoadItem As New Loaditem
        oLoadItem.LoadID = vLoadID
        oLoadItem.CreatedBy = vCurrentUserLogin
        oLoadItem.CreatedTime = Now
        oLoadItem.ModifiedBy = vCurrentUserLogin
        oLoadItem.ModifiedTime = Now
        oLoadItem.SourceType = LoadSourceType.WORKORDER.ToString()
        oLoadItem.SourceID = vWorkOrderItemNumber
        oLoadItem.ItemType = oItem.Itemtype
        oLoadItem.ItemID = oItem.Itemid
        oLoadItem.ItemDescription = oItem.Itemdescription
        oLoadItem.Container = oItem.Container
        oLoadItem.QtyContainers = oItem.Qty
        oLoadItem.DOTIDNumber = oItem.DOTIDNumber
        oLoadItem.HazmatID = oItem.Hazmatid
        oLoadItem.HazmatClass = oItem.Hazmatclass
        oLoadItem.HazmatPackageGroup = oItem.Hazmatpackagegroup
        oLoadItem.ClassRate = oItem.Classrate
        oLoadItem.DOTDesc = oItem.Dotdesc
        oLoadItem.HazMatDesc = oItem.Hazmatdesc
        oLoadItem.UNLine = oItem.Unline
        oLoadItem.Ld1 = oItem.Dotdesc & " " & oItem.Hazmatdesc
        oLoadItem.Ld2 = oItem.Unline
        Dim vStr As String
        'vStr = oItem.Container & "/" & oItem.Totalweight.ToString & " " & oItem.Weightuom & " / " & Trim(oItem.Itemdescription) & " - " & oItem.Totalvolume.ToString & " " & oItem.Volumeuom
        vStr = oItem.Container & "/" & oItem.Totalweight.ToString & " " & oItem.Weightuom & " / " & Trim(oItem.Itemdescription)
        If oItem.Customerpo <> "" Then
            vStr = vStr & "(PO# " & oItem.Customerpo & ")"
        End If
        oLoadItem.Ld3 = vStr

        If IsDBNull(oLoadItem.QtyContainers) Or oLoadItem.QtyContainers <= 0 Then
            oLoadItem.QtyContainers = 0
        End If
        oLoadItem.TotalWeight = (oLoadItem.QtyContainers * (oItem.Totalweight + oContainer.TareWeight))
        oLoadItem.WeightUOM = "LB"
        If oLoadItem.HazmatID <> 1 Then
            oLoadItem.IsHazardous = 1
        Else
            oLoadItem.IsHazardous = 0
        End If

        oLoadItem.Save()
        Return True

    End Function


    Private Function updateLoadItem(vWorkOrderItemNumber As Integer, vLoadItemID As Integer) As Boolean

        Dim oItem As New Workorderitem
        Dim oProduct As New Product
        Dim oContainer As New Container

        'get all related database records
        If Not oItem.LoadByPrimaryKey(vWorkOrderItemNumber) Then
            MsgBox("Error in retrieving WorkOrder item data", MsgBoxStyle.Critical, "Error - " & vWorkOrderItemNumber.ToString)
            Return False
        End If
        If Not oProduct.LoadByPrimaryKey(oItem.Productid) Then
            MsgBox("Error in retrieving Product data", MsgBoxStyle.Critical, "Error - " & oItem.Productid.ToString)
            Return False
        End If
        If Not oContainer.LoadByPrimaryKey(oProduct.Container) Then
            MsgBox("Error in retrieving Container data", MsgBoxStyle.Critical, "Error - " & oProduct.Container)
            Return False
        End If

        Dim oLoadItem As New Loaditem
        If Not oLoadItem.LoadByPrimaryKey(vLoadItemID) Then
            MsgBox("Error in retrieving Load Item data", MsgBoxStyle.Critical, "Error - " & vLoadItemID.ToString)
            Return False
        End If

        oLoadItem.ModifiedBy = vCurrentUserLogin
        oLoadItem.ModifiedTime = Now
        oLoadItem.SourceType = LoadSourceType.WORKORDER.ToString()
        oLoadItem.SourceID = vWorkOrderItemNumber
        oLoadItem.ItemType = oItem.Itemtype
        oLoadItem.ItemID = oItem.Itemid
        oLoadItem.ItemDescription = oItem.Itemdescription
        oLoadItem.Container = oItem.Container
        oLoadItem.QtyContainers = oItem.Qty
        oLoadItem.DOTIDNumber = oItem.DOTIDNumber
        oLoadItem.HazmatID = oItem.Hazmatid
        oLoadItem.HazmatClass = oItem.Hazmatclass
        oLoadItem.HazmatPackageGroup = oItem.Hazmatpackagegroup
        oLoadItem.ClassRate = oItem.Classrate
        oLoadItem.DOTDesc = oItem.Dotdesc
        oLoadItem.HazMatDesc = oItem.Hazmatdesc
        oLoadItem.UNLine = oItem.Unline
        oLoadItem.Ld1 = oItem.Dotdesc & " " & oItem.Hazmatdesc
        oLoadItem.Ld2 = oItem.Unline
        Dim vStr As String
        'vStr = oItem.Container & "/" & oItem.Totalweight.ToString & " " & oItem.Weightuom & " / " & Trim(oItem.Productdesc) & " - " & oItem.Totalvolume.ToString & " " & oItem.Volumeuom
        vStr = oItem.Container & "/" & oItem.Totalweight.ToString & " " & oItem.Weightuom & " / " & Trim(oItem.Productdesc)
        If oItem.Customerpo <> "" Then
            vStr = vStr & "(PO# " & oItem.Customerpo & ")"
        End If
        oLoadItem.Ld3 = vStr

        If IsDBNull(oLoadItem.QtyContainers) Or oLoadItem.QtyContainers <= 0 Then
            oLoadItem.QtyContainers = 0
        End If
        oLoadItem.TotalWeight = (oLoadItem.QtyContainers * (oItem.Totalweight + oContainer.TareWeight))
        oLoadItem.WeightUOM = "LB"
        If oLoadItem.HazmatID <> 1 Then
            oLoadItem.IsHazardous = 1
        Else
            oLoadItem.IsHazardous = 0
        End If

        oLoadItem.Save()
        Return True

    End Function

    Private Function updateShipmentDataFromCancelledWorkorder(vWorkOrderNum As Integer) As Boolean


    End Function

    Public Function updateWorkOrderFromLoadInfo(vLoadID As Integer, vReason As String) As Boolean
        'this function will update workorder and workorderitem records from changes to Load and LoadItem records as they occur
        Select Case vReason
            Case "IN TRANSIT"
                'Load was modified to an "In Transit" status
                'WorkOrder and WorkOrderItem records should be moved to an "INVOICE" status (if not already beyond Invoice status, i.e COMPLETE)
                'to indicate they are ready to be invoiced as the work order items have now shipped.
                'This update will move the work order to the Ready For Invoice tab on the Work Order Screen if all WorkOrderItems on WorkOrder have shipped
                'and been marked "INVOICE"

                '06/27/2014 - AMERICO
                'If a WORKORDER has an ORDERTYPE of CONSIGNMENT TRANSFER, then the WORKORDER should be moved to COMPLETE
                'and not to READY TO INVOICE status

                Dim oWOs As New ViewLoadWorkordersCollection
                oWOs.Query.Where(oWOs.Query.LoadID.Equal(vLoadID))
                If Not oWOs.Query.Load Then
                    'no workorder information found linked to the LoadID passed into the function
                    MsgBox("Error retrieving WORKORDER information for the selected load.", MsgBoxStyle.Critical, "ERROR - No WorkOrder found")
                    Return False
                End If

                'We now have a Workorder (or more than one) linked to the LoadID 
                'We need to check each workorder linked to the LoadID for ORDERTYPE value
                'If ORDERTYPE = CONSIGNMENT TRANSFER, then the WORKORDER should be marked COMPLETE
                'Otherwise, the WorkOrder should be marked READY TO INVOICE
                For Each oWO As ViewLoadWorkorders In oWOs
                    Dim oWorkOrder As New Workorder
                    oWorkOrder.LoadByPrimaryKey(oWO.Workordernumber)
                    Select Case oWorkOrder.Ordertype

                        Case "CONSIGNMENT TRANSFER"
                            'Mark WorkOrder COMPLETE
                            'get work order items that are on the load

                            If Not updateWorkOrderStatusForInvoicing(oWorkOrder.Workordernumber) Then
                                Return False
                            End If

                            Return True


                        Case Else
                            'Mark WorkOrder READY TO INVOICE

                            'Before we update the WORKORDER, we need to update all the 
                            'WORKORDERITEM records that are linked to the LOADID
                            'Not all WORKORDERITEM records are linked to the same LOADID
                            'it is possible that a WORKORDER (and the WORKORDERITEMS on it)
                            'is split across Loads. So we only want to identify and mark
                            'for invoicing those WORKORDERITEM records that are on the
                            'linked LOADID, and no others.

                            'get work order items that are on the load
                            Dim oItems As New ViewWorkOrderItemsOnLoadCollection
                            oItems.Query.Where(oItems.Query.LoadID.Equal(vLoadID))
                            If Not oItems.Query.Load Then
                                'there are no work order items on this load - nothing more to process
                                Return True
                            End If

                            'Work Order Items found - now process through the list, updating WorkOrderItemStatus to "INVOICE"
                            For Each oItem As ViewWorkOrderItemsOnLoad In oItems
                                Dim oWOItem As New Workorderitem
                                If oWOItem.LoadByPrimaryKey(oItem.Workorderitemnumber) Then
                                    If oWOItem.Workorderitemstatus <> "COMPLETE" Then  'if marked COMPLETE then it is already invoiced, most likely
                                        oWOItem.Workorderitemstatus = "INVOICE"
                                        oWOItem.Save()
                                    End If
                                End If
                            Next

                            'Now we check to see if all WorkOrderItems for the WorkOrder have been marked for INVOICE
                            'The concern here is that sometimes an WorkOrder is split across multiple loads for shipping purposes
                            'We do NOT want to invoice a WorkOrder until ALL items have shipped.
                            'Likewise, a load can have WorkOrderItems from more than one workorder, so we have to scan each
                            'item record from the load to find all the possible workorders to process through
                            'NOTE: This loop will most likely involve updating the same WORKORDER record multiple times as 
                            'it iterates through the viewWorkOrdersOnLoad dataset object. This is okay, just not efficient

                            Dim vWONum As Integer = 0
                            For Each oItem As ViewWorkOrderItemsOnLoad In oItems
                                vWONum = oItem.Workordernumber
                                If Not updateWorkOrderStatusForInvoicing(vWONum) Then
                                    Return False
                                End If
                            Next
                            Return True

                    End Select
                Next

            Case Else
                Return True
        End Select
    End Function

    Private Function updateWorkOrderStatusForInvoicing(vID As Integer) As Boolean
        'if the iterate workorder is marked as ordertype = CONSIGNMENT TRANSFER, then we do NOT
        'want to make an invoice for that workorder. Therefore, we want to mark the Workorder record and all
        'workorderitem records as "COMPLETE" instead of "INVOICE".

        Dim oWO As New Workorder
        Dim oWI As New WorkorderitemCollection

        If Not oWO.LoadByPrimaryKey(vID) Then
            Return False
        End If

        Try
            Select Case oWO.Ordertype
                Case "CONSIGNMENT TRANSFER"
                    'this workorder should be moved to COMPLETE - no invoicing
                    oWI.Query.Where(oWI.Query.Workordernumber.Equal(vID))
                    If oWI.Query.Load Then
                        For Each oItem As Workorderitem In oWI
                            oItem.Workorderitemstatus = "COMPLETE"
                        Next
                        oWI.Save()
                    End If
                    oWO.Orderstatus = "COMPLETE"
                    oWO.Save()
                Case Else
                    'all other WorkOrders should be moved to INVOICE, if all WorkOrderItems 
                    'have been marked as COMPLETE or INVOICE
                    Dim vMarkAsReadyToInvoice As Boolean = True
                    oWI.Query.Where(oWI.Query.Workordernumber.Equal(vID), oWI.Query.Workorderitemstatus.NotIn("COMPLETE", "INVOICE"))
                    If oWI.Query.Load Then
                        'Unshipped WorkOrderItems found
                        vMarkAsReadyToInvoice = False
                    Else
                        vMarkAsReadyToInvoice = True
                    End If
                    'now update WorkOrder OrderStatus is appropriate
                    If vMarkAsReadyToInvoice Then
                        oWO.Orderstatus = "INVOICE"
                        oWO.Save()
                    End If
            End Select
            Return True
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

#End Region


#Region "DIRECT PURCHASE ORDER - SHIPMENT DATA"

    Public Function updatePurchaseOrderShipmentData(vPurchaseOrderNum As Integer, oPurchaseItems As PurchaseitemCollection) As Integer

        Dim vLoadID As Integer = 0

        'add a new load record to the database if there were no loads already linked to the purchaseorder
        If vLoadID = 0 Then
            vLoadID = createNewLoadForPurchaseOrder(vPurchaseOrderNum)
            If vLoadID <= 0 Then
                MsgBox("There is an error in identifying Load Number to update", MsgBoxStyle.Critical, "Error - No Load to Update")
                Return False
            End If
        End If

        'we now have a default LoadID to use to add/update workorderItems to

        'scan all items in collection and process related LoadItem records
        For Each oItem As Purchaseitem In oPurchaseItems
            If Not addPurchaseOrderItemToLoad(oItem.Purchaseitemid, vLoadID) Then
                Return False
            End If
        Next

        'finally, update the load summary data
        UpdateLoadSummaryData(vLoadID)


    End Function

    Public Function createNewLoadForPurchaseOrder(vPurchaseOrderNum As Integer) As Integer

        'first, get the workorder record to retrieve necessary data items
        Dim oPO As New Purchase
        If Not oPO.LoadByPrimaryKey(vPurchaseOrderNum) Then
            Return 0
        End If

        'now, add a new Load record to the database
        Try
            Dim oLoad As New Load
            oLoad.CreatedBy = vCurrentUserLogin
            oLoad.CreatedTime = Now
            oLoad.ModifiedBy = vCurrentUserLogin
            oLoad.ModifiedTime = Now
            oLoad.LoadStatus = LoadStatus.PENDING.ToString()

            'oLoad.PlannedDeliveryDate = oPO.Deliverydate
            'oLoad.PlannedDepartureDate = oPO.Plannedshipdate
            'oLoad.CarrierID = oPO.Carrierid
            'oLoad.LogisticsID = oPO.Logisticsid

            oLoad.CustID = oPO.Custid

            'oLoad.Fob = oPO.Fob
            'oLoad.BillCustomer = oPO.Freightbillcustomer
            'oLoad.AddToInvoice = oPO.Freightoninvoice
            'oLoad.LoadType = oPO.Transporttype

            Dim oVend As New Vendor
            If oVend.LoadByPrimaryKey(oPO.Vendorid) Then
                oLoad.OriginType = "VENDOR"
                oLoad.OriginID = oPO.Vendorid
                oLoad.OriginName = oVend.Vendorname
                oLoad.OriginAddress1 = oVend.Vendoraddress1
                oLoad.OriginAddress2 = oVend.Vendoraddress2
                oLoad.OriginCity = oVend.Vendorcity
                oLoad.OriginState = oVend.Vendorstate
                oLoad.OriginZip = oVend.Vendorzip
                oLoad.OriginCountry = "United States"
                oLoad.OriginContact = oVend.Vendorcontact
                oLoad.OriginPhone = oVend.Vendorphone
            End If

            oLoad.DestType = "CUSTOMER"
            oLoad.DestID = oPO.Custid
            oLoad.DestName = oPO.Shipname
            oLoad.DestAddress1 = oPO.Shipaddress1
            oLoad.DestAddress2 = oPO.Shipaddress2
            oLoad.DestCity = oPO.Shipcity
            oLoad.DestState = oPO.Shipstate
            oLoad.DestZip = oPO.Shipzip

            'oLoad.DestCountry = oPO.Custshipcountry

            oLoad.DestPhone = oPO.Shipphone
            oLoad.DestContact = oPO.Shipcontact

            oLoad.Save()
            Return oLoad.LoadID
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error - Could not add New Load")
            Return 0
        End Try

        Return 0

    End Function

    Public Function addPurchaseOrderItemToLoad(vPurchaseOrderItemNumber As Integer, vLoadID As Integer) As Boolean

        '      	• Create loads (We need to look at how loads are created now and what fields need to be populated)
        '○ The code should call existing methods that are already used to create a load - look for the code on the button click of marking a Direct Work Order to In Process
        '○ For the Load, set
        '	§ Status  = PENDING
        '	§ Origin = Vendor Address
        '	§ Destination = ship fields from Purchase
        '	§ For each Load Item, set
        '		□ Source id = the purchase item id
        '		□ Source type = PURCHASEITEM


        Dim oItem As New Purchaseitem
        Dim oProduct As New Product
        Dim oContainer As New Container

        'get all related database records
        If Not oItem.LoadByPrimaryKey(vPurchaseOrderItemNumber) Then
            MsgBox("Error in retrieving PurchaseOrder item data", MsgBoxStyle.Critical, "Error - " & vPurchaseOrderItemNumber.ToString)
            Return False
        End If
        If Not oProduct.LoadByPrimaryKey(oItem.Itemid) Then
            MsgBox("Error in retrieving Product data", MsgBoxStyle.Critical, "Error - " & oItem.Itemid.ToString)
            Return False
        End If
        If Not oContainer.LoadByPrimaryKey(oItem.Container) Then
            MsgBox("Error in retrieving Container data", MsgBoxStyle.Critical, "Error - " & oProduct.Container)
            Return False
        End If

        Dim oLoadItem As New Loaditem
        oLoadItem.LoadID = vLoadID
        oLoadItem.CreatedBy = vCurrentUserLogin
        oLoadItem.CreatedTime = Now
        oLoadItem.ModifiedBy = vCurrentUserLogin
        oLoadItem.ModifiedTime = Now
        oLoadItem.SourceType = LoadSourceType.PRCH.ToString()
        oLoadItem.SourceID = oItem.Purchaseitemid
        oLoadItem.ItemType = oItem.Itemtype
        oLoadItem.ItemID = oItem.Itemid
        oLoadItem.ItemDescription = oItem.Itemdescription
        oLoadItem.Container = oItem.Container
        oLoadItem.QtyContainers = oItem.Qty

        'oLoadItem.DOTIDNumber = oItemList.DOTIDNumber
        'oLoadItem.HazmatID = oItemList.Hazmatid
        'oLoadItem.HazmatClass = oItemList.Hazmatclass
        'oLoadItem.HazmatPackageGroup = oItemList.Hazmatpackagegroup
        'oLoadItem.ClassRate = oItemList.Classrate
        'oLoadItem.DOTDesc = oItemList.Dotdesc
        'oLoadItem.HazMatDesc = oItemList.Hazmatdesc
        'oLoadItem.UNLine = oItemList.Unline
        'oLoadItem.Ld1 = oItemList.Dotdesc & " " & oItemList.Hazmatdesc
        'oLoadItem.Ld2 = oItemList.Unline
        'Dim vStr As String
        'vStr = oItemList.Container & "/" & oItemList.Totalweight.ToString & " " & oItemList.Weightuom & " / " & Trim(oItemList.Itemdescription) & " - " & oItemList.Totalvolume.ToString & " " & oItemList.Volumeuom
        'If oItemList.Customerpo <> "" Then
        '    vStr = vStr & "(PO# " & oItemList.Customerpo & ")"
        'End If

        'oLoadItem.Ld3 = vStr

        If IsDBNull(oLoadItem.QtyContainers) Or oLoadItem.QtyContainers <= 0 Then
            oLoadItem.QtyContainers = 0
        End If

        'oLoadItem.TotalWeight = (oLoadItem.QtyContainers * (oItemList.Totalweight + oContainer.TareWeight))

        oLoadItem.WeightUOM = "LB"
        If oLoadItem.HazmatID <> 1 Then
            oLoadItem.IsHazardous = 1
        Else
            oLoadItem.IsHazardous = 0
        End If

        oLoadItem.Save()
        Return True

    End Function

    ''' <summary>
    ''' While spliting the purchase item, we need to link the inventory items to the newly created purchase item.
    ''' </summary>
    ''' <param name="oOldPurchase"></param>
    ''' <param name="oNewPurchase"></param>
    ''' <remarks></remarks>
    Public Sub splitLoadItems(oOldPurchase As Purchaseitem, oNewPurchase As Purchaseitem)
        If oOldPurchase Is Nothing Then
            Exit Sub
        End If
        If oNewPurchase Is Nothing Then
            Exit Sub
        End If

        Dim oLoadItems As LoaditemCollection = getLoadItems(oOldPurchase.Purchaseitemid, SourceType.PRCH.ToString())
        If oLoadItems.Count <= 0 Then
            Exit Sub
        End If

        oLoadItems(0).QtyContainers = oOldPurchase.Qty
        oLoadItems.Save()

        addPurchaseOrderItemToLoad(oNewPurchase.Purchaseitemid, oLoadItems(0).LoadID)

        UpdateLoadSummaryData(oLoadItems(0).LoadID)

    End Sub

#End Region

    Public Function getLoadItems(vSourceID As Integer, Optional vSourceType As String = "") As LoaditemCollection
        If (vSourceID <= 0) Then
            Return Nothing
        End If

        Dim oLoaditems As New LoaditemCollection
        oLoaditems.Query.Where(oLoaditems.Query.SourceID.Equal(vSourceID))
        If vSourceType & "" <> "" Then
            oLoaditems.Query.Where(oLoaditems.Query.SourceType.Equal(vSourceType))
        End If
        oLoaditems.Query.Load()

        Return oLoaditems
    End Function

    Public Function deleteLoadItems(vSourceID As Integer, Optional vSourceType As String = "") As Boolean

        Try
            Dim vLoadID As Integer
            Dim oLoaditems As LoaditemCollection = getLoadItems(vSourceID, vSourceType)

            If oLoaditems.Count > 0 Then
                vLoadID = oLoaditems(0).LoadID
                For Each oLoaditem As Loaditem In oLoaditems
                    oLoaditem.MarkAsDeleted()
                Next
                oLoaditems.Save()

                changeLoadStatus(vLoadID)
            End If

        Catch ex As Exception
            Return False
        End Try


        Return True
    End Function

    Public Sub UpdateLoadSummaryData(vLoadID As Integer)
        Dim sLoad As New Load
        sLoad.LoadByPrimaryKey(vLoadID)
        ' get calculaterd skids for load
        Dim calculatedSkids As Integer
        Dim es As New esUtility
        Dim parameters As New esParameters
        parameters.Add(New esParameter("LoadId", vLoadID))
        calculatedSkids = es.ExecuteScalar(EntitySpaces.DynamicQuery.esQueryType.StoredProcedure, "GetCalculatedSkidsByLoad", parameters)
        sLoad.TotalSkids = calculatedSkids

        ' add code for any other sumay items here

        sLoad.Save()
    End Sub

    Public Sub changeLoadStatus(vLoadID As Integer)
        Dim oLoaditems As New LoaditemCollection
        Dim oLoad As New Load
        oLoaditems = getLoadItemsByLoadID(vLoadID)

        If oLoaditems.Count = 0 Then
            If oLoad.LoadByPrimaryKey(vLoadID) Then
                oLoad.MarkAsDeleted()
                oLoad.Save()
            End If
        Else
            UpdateLoadSummaryData(vLoadID)
        End If

    End Sub

    Public Function getLoadItemsByLoadID(vLoadID As Integer) As LoaditemCollection
        Dim oLoaditems As New LoaditemCollection
        oLoaditems.Query.Where(oLoaditems.Query.LoadID.Equal(vLoadID))
        oLoaditems.Query.Load()
        Return oLoaditems
    End Function
    ' get All Pallet type
    Public Function getLoadoPalletType() As ListPallettypeCollection
        Dim oPallettypeCollection As New ListPallettypeCollection
        oPallettypeCollection.LoadAll()
        Return oPallettypeCollection
    End Function

    Public Sub deleteLoadItemFromWorkOrderItem(vWorkOrderItemNum As Integer)
        Dim oLoadItems As New LoaditemCollection
        oLoadItems.Query.Where(oLoadItems.Query.SourceType.Equal(LoadSourceType.WORKORDER.ToString()), oLoadItems.Query.SourceID.Equal(vWorkOrderItemNum))
        If oLoadItems.Query.Load Then
            oLoadItems.MarkAllAsDeleted()
            oLoadItems.Save()
        End If
    End Sub

End Module
