Module Costing
    Public Sub ProcessComponentCostChanges(vComponentID As Integer, vOldUnitcost As Decimal, vNewUnitcost As Decimal, vReasonForChange As String, vChangeType As String, vChangeId As Integer, vWhatChanged As String)

        AddChangeHistoryRecord("COMPONENT", vComponentID, "UNITCOST", vOldUnitcost, vNewUnitcost, "", 0, 0, vReasonForChange, vChangeType, vWhatChanged)

        Dim oKitComponentCollection As New KitcomponentCollection
        oKitComponentCollection.Query.Where(oKitComponentCollection.Query.Componentid.Equal(vComponentID))
        oKitComponentCollection.Query.OrderBy(oKitComponentCollection.Query.Kitid.Ascending)
        If oKitComponentCollection.Query.Load() Then
            For Each oKit As Kitcomponent In oKitComponentCollection
                ProcessKitCostChanges(oKit.Kitid, vReasonForChange, vChangeType, vChangeId, vWhatChanged & "-" & oKit.Kitid)
            Next
        End If

    End Sub

    Public Sub ProcessKitCostChanges(vKitID As Integer, vReasonForChange As String, vChangeType As String, vChangeId As Integer, vWhatChanged As String)
        Dim oKitInfo As New ViewKitInfo
        oKitInfo.Query.Where(oKitInfo.Query.Kitid = vKitID)
        If oKitInfo.Query.Load() Then

            AddChangeHistoryRecord("KIT", vKitID, "KITCOST", 0, IIf(IsDBNull(oKitInfo.KitCost), 0, oKitInfo.KitCost), "", 0, 0, vReasonForChange, vChangeType, vWhatChanged)

            Dim rp As New ProductfulfillmentplanQuery("rp")
            Dim p As New ProductQuery("p")
            rp.InnerJoin(p).On(rp.Productid = p.Productid)
            rp.Where(rp.Kitid = vKitID And p.Productstatus = "ACTIVE")
            rp.OrderBy(rp.Productid.Ascending)
            Dim oRelabelProds As New ProductfulfillmentplanCollection
            If (oRelabelProds.Load(rp)) Then
                For Each obj As Productfulfillmentplan In oRelabelProds
                    'loop through Relabeled Products with same Origin ProductID and update standard costs
                    If getProductStandardCostSource(obj.Productid) = "RELABEL" Then
                        ProcessRelabelProductStandardCostChanges(obj.Productid, vChangeType, "KIT CHNG - KIT " & oKitInfo.Kitid & " " & oKitInfo.Kitname, vWhatChanged)
                    End If

                Next
            End If

            Dim oAPISCollection As New ViewAPISDataCollection
            oAPISCollection.Query.Where(oAPISCollection.Query.Kitid.Equal(vKitID) And oAPISCollection.Query.Apisstatus.Equal("ACTIVE"))
            oAPISCollection.Query.OrderBy(oAPISCollection.Query.Productid.Ascending)
            If oAPISCollection.Query.Load() Then
                For Each oAPIS As ViewAPISData In oAPISCollection
                    If getProductStandardCostSource(oAPIS.Productid) = "APIS" Then
                        ProcessAPISProductStandardCostChanges(oAPIS.Productid, vChangeType, "KIT CHNG - KIT " & oKitInfo.Kitid & " " & oKitInfo.Kitname, vWhatChanged)
                    End If

                    'Dim oTotalCosts As New ViewCostingApisTotalCosts
                    'oTotalCosts.Query.Where(oTotalCosts.Query.Apisnum.Equal(oAPIS.Apisnum))
                    'If (oTotalCosts.Query.Load) Then
                    '    If getProductStandardCostSource(oAPIS.Productid).Equals("APIS") Then
                    '        Dim oKit As New Kit
                    '        If oKit.LoadByPrimaryKey(vKitID) Then
                    '            updateAPISStandardCosting(oAPIS.Productid, oTotalCosts.Volume, oTotalCosts.ApisVolUnitCost, oTotalCosts.Weight, oTotalCosts.ApisUnitCost, "KIT CHNG - KIT " & oKit.Kitid & " " & oKit.Kitname, vChangeType, vChangeId, vWhatChanged)
                    '        End If
                    '    End If
                    'End If

                Next
            End If
        End If

    End Sub


    Public Function CompareStandardCostToProductCostRecord(vProductID As Integer, vCostRecordID As Integer) As Integer

        'List of Return Values:
        '0 - Standard Cost and Product Cost record values do NOT match
        '1 - Standard Cost and Product Cost record values DO match
        '2 - Data is missing and can't complete the comparison

        If IsDBNull(vProductID) Then
            Return 2
        End If

        If IsDBNull(vCostRecordID) Then
            Return 2
        End If

        Dim oProduct As New Product
        Dim oCost As New Productcost

        If Not oProduct.LoadByPrimaryKey(vProductID) Then
            Return 2
        End If

        If Not oCost.LoadByPrimaryKey(vCostRecordID) Then
            Return 2
        End If

        'Check for missing values in the cost fields
        If IsDBNull(oProduct.Volumestandardcost) Then
            Return 2
        End If
        If IsDBNull(oProduct.Volumeunits) Then
            Return 2
        End If

        If IsDBNull(oProduct.Weightstandardcost) Then
            Return 2
        End If
        If IsDBNull(oProduct.Weightunits) Then
            Return 2
        End If

        If IsDBNull(oCost.Volumestandardcost) Then
            Return 2
        End If
        If IsDBNull(oCost.Volumeunits) Then
            Return 2
        End If

        If IsDBNull(oCost.Weightstandardcost) Then
            Return 2
        End If
        If IsDBNull(oCost.Weightunits) Then
            Return 2
        End If


        'At this point we have two records to compare to each other
        'We compare units in container and unit cost values for VOLUME and WEIGHT
        'If any of the values do NOT match, then we return a 0 value, otherwise a 1 value
        If oProduct.Volumestandardcost <> oCost.Volumestandardcost Then
            Return 0
        End If
        If oProduct.Volumeunits <> oCost.Volumeunits Then
            Return 0
        End If
        If oProduct.Weightstandardcost <> oCost.Weightstandardcost Then
            Return 0
        End If
        If oProduct.Weightunits <> oCost.Weightunits Then
            Return 0
        End If

        'If we make it this far, all costing data matches between the PRODUCT and PRODUCTCOST records
        Return 1

    End Function


    Public Sub ProcessProductStandardCostChanges(vProdID As Integer, vOldVolCost As Decimal, vOldWgtCost As Decimal, vNewVolCost As Decimal, vNewWgtCost As Decimal, vReasonForChange As String, vChangeType As String, vChangeID As Integer, vWhatChanged As String)

        Dim oProductRecord As New Product
        oProductRecord.LoadByPrimaryKey(vProdID)

        '1. Add Product Change History Record for Initial Product
        AddProductCostChangeHistoryRecord(vProdID, vOldVolCost, vOldWgtCost, vNewVolCost, vNewWgtCost, vReasonForChange, vChangeType, vWhatChanged)

        '2. Update Related Relabel Product Records with Prodduct Status = ACTIVE
        Dim rp As New ProductfulfillmentplanQuery("rp")
        Dim p As New ProductQuery("p")
        rp.InnerJoin(p).On(rp.Productid = p.Productid)
        rp.Where(rp.Associatedproductid = vProdID And p.Productstatus = "ACTIVE")
        rp.OrderBy(rp.Productid.Ascending)
        Dim oRelabelProds As New ProductfulfillmentplanCollection
        If (oRelabelProds.Load(rp)) Then
            For Each obj As Productfulfillmentplan In oRelabelProds
                'loop through Relabeled Products with same Origin ProductID and update standard costs
                If getProductStandardCostSource(obj.Productid) = "RELABEL" Then
                    ProcessRelabelProductStandardCostChanges(obj.Productid, vChangeType, "RELABEL CHNG - PROD " & oProductRecord.Productid & " " & oProductRecord.Productdesc, vWhatChanged)
                End If

            Next
        End If

        '3. Update Related APIS Product Records
        'find MaterialID the product may be linked to
        Dim vMatID As Integer
        Dim oMatProd As New MaterialproductCollection
        oMatProd.Query.Where(oMatProd.Query.Productid.Equal(vProdID) And oMatProd.Query.Priority.NotEqual(0))
        If oMatProd.Query.Load Then
            vMatID = oMatProd(0).Materialid
            'Proceed only if its the highest priority material item . Verify which is highest priority (Low no or high no)
            Dim oMatProdColl As New MaterialproductCollection
            oMatProdColl.Query.Where(oMatProdColl.Query.Materialid = vMatID And oMatProdColl.Query.Priority.NotEqual(0))
            oMatProdColl.Query.OrderBy(oMatProdColl.Query.Priority.Ascending)
            If (oMatProdColl.Query.Load()) Then
                If vMatID <> oMatProdColl(0).Materialid Then
                    Exit Sub
                End If
            End If
        Else
            Exit Sub
        End If

        'now find all APIS records linked to this MaterialID
        Dim oApisList As New ViewMaterialAPISListCollection
        'If vChangeType = "APIS" Then
        '    'exclude the APIS that just produced the change
        '    oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"), oApisList.Query.Apisnum.NotEqual(vChangeID), oApisList.Query.Productid.NotEqual(vProdID))
        'Else
        oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"), oApisList.Query.Productid.NotEqual(vProdID))
        '     End If
        oApisList.Query.OrderBy(oApisList.Query.Productid.Ascending)
        If oApisList.Query.Load Then
            For Each oApis As ViewMaterialAPISList In oApisList
                'Loop through all related APIS products, updating standard costs
                If getProductStandardCostSource(oApis.Productid) = "APIS" Then
                    ProcessAPISProductStandardCostChanges(oApis.Productid, vChangeType, "APIS CHNG - PROD " & oProductRecord.Productid & " " & oProductRecord.Productdesc, vWhatChanged)
                End If
            Next

            ''No need to iterate through since called recursively

            ''Extrapolate through one more time to find second level APIS records to update
            'For Each oAPIS1 As ViewMaterialAPISList In oApisList
            '    'find other APIS records that use the Product created by the current apis in oAPIS1 and process those costs as well
            '    Dim oDefaultMatProd As New ViewCostingMaterialDefaultProductCollection
            '    oDefaultMatProd.Query.Where(oDefaultMatProd.Query.Productid.Equal(oAPIS1.Productid))
            '    If oDefaultMatProd.Query.Load Then
            '        vMatID = oDefaultMatProd(0).Materialid
            '    Else
            '        'loop back, as no material id found for this product
            '        Continue For
            '    End If

            '    Dim oApisList2 As New ViewMaterialAPISListCollection
            '    oApisList2.Query.Where(oApisList2.Query.Materialid.Equal(vMatID), oApisList2.Query.Apisstatus.Equal("ACTIVE"), oApisList2.Query.Apisnum.NotEqual(oAPIS1.Apisnum), oApisList2.Query.Productid.NotEqual(vProdID))
            '    If oApisList2.Query.Load Then
            '        'loop through all related APIS products, updating standard costs
            '        For Each oApis2 As ViewMaterialAPISList In oApisList2
            '            'Loop through all related APIS products, updating standard costs
            '            Dim oApisCost2 As New ViewAPISProductsCostChanges
            '            oApisCost2.Query.Where(oApisCost2.Query.Productid.Equal(oApis2.Productid))
            '            If oApisCost2.Query.Load Then
            '                'update APIS Product Standard Costs
            '                Dim oProduct As New Product
            '                If oProduct.LoadByPrimaryKey(oApisCost2.Productid) Then
            '                    'set new values
            '                    oProduct.Volumestandardcost = oApisCost2.Newvolcost
            '                    oProduct.Weightstandardcost = oApisCost2.Newwgtcost
            '                    oProduct.Save()
            '                End If

            '                'add product change history record for the relabeled product
            '                AddProductCostChangeHistoryRecord(oApisCost2.Productid, IIf(IsDBNull(oApisCost2.Oldvolcost), 0, oApisCost2.Oldvolcost), IIf(IsDBNull(oApisCost2.Oldwgtcost), 0, oApisCost2.Oldwgtcost), IIf(IsDBNull(oApisCost2.Newvolcost), 0, oApisCost2.Newvolcost), IIf(IsDBNull(oApisCost2.Newwgtcost), 0, oApisCost2.Newwgtcost), "APIS CHNG - PROD " & vProdID & " " & oProductRecord.Productdesc, vChangeType)
            '            End If
            '        Next
            '    End If

            'Next
        End If

    End Sub

    Public Sub ProcessAPISProductStandardCostChanges(vProductId As Integer, vChangeType As String, vReasonForChange As String, vWhatChanged As String)
        Dim oApisCost As New ViewAPISProductsCostChanges
        oApisCost.Query.Where(oApisCost.Query.Productid.Equal(vProductId))
        If oApisCost.Query.Load Then
            'update APIS Product Standard Costs
            Dim oProduct As New Product
            If oProduct.LoadByPrimaryKey(oApisCost.Productid) Then
                'set old values
                Dim vOldVolCost As Decimal = IIf(IsDBNull(oApisCost.Oldvolcost), 0, oApisCost.Oldvolcost)
                Dim vOldWtCost As Decimal = IIf(IsDBNull(oApisCost.Oldwgtcost), 0, oApisCost.Oldwgtcost)


                'set new values
                If IsDBNull(oProduct.Volumeuom) Or oProduct.Volumeuom = Nothing Then
                    oProduct.Volumeuom = "GAL"
                End If
                If IsDBNull(oProduct.Weightuom) Or oProduct.Weightuom = Nothing Then
                    oProduct.Weightuom = "LB"
                End If

                oProduct.Volumeunits = oApisCost.Apisvolumeunits
                oProduct.Volumestandardcost = IIf(IsDBNull(oApisCost.Newvolcost), 0, oApisCost.Newvolcost)
                oProduct.Weightunits = oApisCost.Apisweightunits
                oProduct.Weightstandardcost = IIf(IsDBNull(oApisCost.Newwgtcost), 0, oApisCost.Newwgtcost)
                oProduct.Save()

                'Save and process cacading only if value was updated
                If vOldVolCost <> IIf(IsDBNull(oApisCost.Newvolcost), 0, oApisCost.Newvolcost) Or
                         vOldWtCost <> IIf(IsDBNull(oApisCost.Newwgtcost), 0, oApisCost.Newwgtcost) Then

                    'add product change history record for the relabeled product
                    ProcessProductStandardCostChanges(oApisCost.Productid, vOldVolCost, vOldWtCost, IIf(IsDBNull(oApisCost.Newvolcost), 0, oApisCost.Newvolcost), IIf(IsDBNull(oApisCost.Newwgtcost), 0, oApisCost.Newwgtcost), vReasonForChange, vChangeType, oApisCost.Apisnum, vWhatChanged)
                End If
            End If

        End If
    End Sub

    Public Sub ProcessRelabelProductStandardCostChanges(vProductID As Integer, vChangeType As String, vReasonForChange As String, vWhatchanged As String)
        'determine standard costs with new data from origin ProductID new standard costs

        Dim oRlbCosts As New ViewRelabelProductsCostChanges
        oRlbCosts.Query.Where(oRlbCosts.Query.Productid.Equal(vProductID))
        If oRlbCosts.Query.Load Then
            'update Relabeled Product Standard Costs
            Dim oProduct As New Product
            If oProduct.LoadByPrimaryKey(vProductID) Then
                'set old values 
                Dim vOldVolCost As Decimal = IIf(IsDBNull(oRlbCosts.Oldvolcost) OrElse oRlbCosts.Oldvolcost Is Nothing, 0, oRlbCosts.Oldvolcost)
                Dim vOldWtCost As Decimal = IIf(IsDBNull(oRlbCosts.Oldwgtcost) Or oRlbCosts.Oldwgtcost Is Nothing, 0, oRlbCosts.Oldwgtcost)


                'Save and process cacading only if value was updated
                'set new values
                oProduct.Volumeunits = oRlbCosts.Origvolunits
                oProduct.Volumeuom = oRlbCosts.Origvolumeuom
                oProduct.Volumestandardcost = oRlbCosts.Newvolcost
                oProduct.Weightunits = oRlbCosts.Origwgtunits
                oProduct.Weightuom = oRlbCosts.Origweightuom
                oProduct.Weightstandardcost = oRlbCosts.Newwgtcost

                oProduct.Save()
                If vOldVolCost <> oRlbCosts.Newvolcost Or
                        vOldWtCost <> oRlbCosts.Newwgtcost Then
                    'add product change history record for the relabeled product
                    'AddProductCostChangeHistoryRecord(vProductID, oRlbCosts.Oldvolcost, oRlbCosts.Oldwgtcost, oRlbCosts.Newvolcost, oRlbCosts.Newwgtcost, "RELABEL CHNG - PROD " & vProductID & " " & oProductRecord.Productdesc, vChangeType)

                    ProcessProductStandardCostChanges(vProductID, oRlbCosts.Oldvolcost, oRlbCosts.Oldwgtcost, oRlbCosts.Newvolcost, oRlbCosts.Newwgtcost, vReasonForChange, vChangeType, oProduct.Productid, vWhatchanged)
                End If
            End If

        End If
    End Sub

    Public Sub AddChangeHistoryRecord(vDataTableName As String, vDataRecordID As Integer, vPriorValueName1 As String, vPriorValue1 As Decimal, vNewValue1 As Decimal, vPriorValueName2 As String, vPriorValue2 As Decimal, vNewValue2 As Decimal, vReasonForChange As String, vChangeType As String, vWhatChanged As String)

        Dim vChg As New Changerecord
        vChg.Changetype = vChangeType
        vChg.Whatchanged = vWhatChanged '"PROD STD COSTING"
        vChg.Whochanged = vCurrentUserLogin
        vChg.Whenchanged = Now
        vChg.Whychanged = vReasonForChange
        vChg.Priorvalue1name = vPriorValueName1
        vChg.Priorvalue1 = vPriorValue1
        vChg.Priorvalue2name = vPriorValueName2
        vChg.Priorvalue2 = vPriorValue2
        vChg.Newvalue1 = vNewValue1
        vChg.Newvalue2 = vNewValue2
        vChg.Datatablename = vDataTableName
        vChg.Datarecordid = vDataRecordID
        vChg.Recordstatus = "REVIEW"
        vChg.Save()

    End Sub
    Public Sub AddProductCostChangeHistoryRecord(vProdID As Integer, vOldVolCost As Decimal, vOldWgtCost As Decimal, vNewVolCost As Decimal, vNewWgtCost As Decimal, vReasonForChange As String, vChangeType As String, vWhatChanged As String)

        AddChangeHistoryRecord("PRODUCT", vProdID, "VOL STD COST", vOldVolCost, vNewVolCost, "WGT STD COST", vOldWgtCost, vNewWgtCost, vReasonForChange, vChangeType, vWhatChanged)

    End Sub

    Public Sub updateProductStandardCosting(vProductID As Integer, vVolumeUnits As Decimal, vOldVolumeUnitCost As Decimal, vVolumeUnitCost As Decimal, vWeightUnits As Decimal, vOldWeightUnitCost As Decimal, vWeightUnitCost As Decimal, vReasonForChange As String, vChangeType As String, vChangeID As Integer, vWhatChanged As String)

        'change the standard cost data for the product
        Dim oProduct As New Product
        Dim vOldVolUnitCost As Decimal = vOldVolumeUnitCost
        Dim vOldWgtUnitCost As Decimal = vOldWeightUnitCost
        If oProduct.LoadByPrimaryKey(vProductID) Then
            'get old values
            'vOldVolUnitCost = oProduct.Volumestandardcost
            'vOldWgtUnitCost = oProduct.Weightstandardcost
            'set new values
            oProduct.Volumeunits = vVolumeUnits
            oProduct.Volumestandardcost = vVolumeUnitCost
            oProduct.Weightunits = vWeightUnits
            oProduct.Weightstandardcost = vWeightUnitCost
            oProduct.Save()
            If vOldVolUnitCost <> vVolumeUnitCost Or vOldWeightUnitCost <> vWeightUnitCost Then

                'Process Product Cost Changes Across all Related Products
                ProcessProductStandardCostChanges(vProductID, vOldVolumeUnitCost, vOldWeightUnitCost, vVolumeUnitCost, vWeightUnitCost, vReasonForChange, vChangeType, vChangeID, vWhatChanged)
            End If
        Else
            Exit Sub
        End If




        ''record this PRODUCT COST change even in the CHANGERECORD table
        'Dim vChg As Changerecord
        'vChg = New Changerecord
        'vChg.Changetype = "STD COST"
        'vChg.Whatchanged = "PRODUCT STD COSTING"
        'vChg.Whochanged = vCurrentUserLogin
        'vChg.Whenchanged = Now
        'vChg.Whychanged = vReasonForChange
        'vChg.Priorvalue1name = "VOL STD COST"
        'vChg.Priorvalue1 = vOldVolUnitCost
        'vChg.Priorvalue2name = "WGT STD COST"
        'vChg.Priorvalue2 = vOldWgtUnitCost
        'vChg.Newvalue1 = vVolumeUnitCost
        'vChg.Newvalue2 = vWeightUnitCost
        'vChg.Datatablename = vChangeType
        'vChg.Datarecordid = vChangeID
        'vChg.Recordstatus = "REVIEW"
        'vChg.Save()

        ''now find all cascading potential cost changes from this one product cost change

        ''find MaterialID the product may be linked to
        'Dim vMatID As Integer
        'Dim oMatProd As New MaterialproductCollection
        'oMatProd.Query.Where(oMatProd.Query.Productid.Equal(vProductID))
        'If oMatProd.Query.Load Then
        '    vMatID = oMatProd(0).Materialid
        'Else
        '    Exit Sub
        'End If

        ''now find all APIS records linked to this MaterialID
        'Dim oApisList As New ViewMaterialAPISListCollection
        'If vChangeType = "APIS" Then
        '    'exclude the APIS that just produced the change
        '    oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"), oApisList.Query.Apisnum.NotEqual(vChangeID))
        'Else
        '    oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"))
        'End If

        'If oApisList.Query.Load Then
        '    For Each oApis As ViewMaterialAPISList In oApisList
        '        'add record to CHANGEREVIEW table
        '        Dim vReview As New Changereview
        '        vReview.Changerecid = vChg.Changerecid
        '        vReview.Datatablename = "APIS"
        '        vReview.Datarecordid = oApis.Apisnum
        '        vReview.Referencetype = "PRODUCT"
        '        vReview.Referenceid = oApis.Productid
        '        vReview.Reviewreason = "PRODUCT COST CHG - " & vProductID.ToString
        '        vReview.Reviewstatus = "PENDING"
        '        vReview.Save()
        '    Next
        'End If

    End Sub


    Public Sub updateAPISStandardCosting(vProductID As Integer, vVolumeUnits As Decimal, vVolumeUnitCost As Decimal, vWeightUnits As Decimal, vWeightUnitCost As Decimal, vReasonForChange As String, vChangeType As String, vChangeID As Integer, vWhatChanged As String)

        'change the standard cost data for the product
        Dim oProduct As New Product
        Dim vOldVolUnitCost As Decimal = 0.00
        Dim vOldWgtUnitCost As Decimal = 0.00
        If oProduct.LoadByPrimaryKey(vProductID) Then
            'get old values
            vOldVolUnitCost = IIf(IsDBNull(oProduct.Volumestandardcost), 0, oProduct.Volumestandardcost)
            vOldWgtUnitCost = IIf(IsDBNull(oProduct.Weightstandardcost), 0, oProduct.Weightstandardcost)

            'set new values
            If IsDBNull(oProduct.Volumeuom) Or oProduct.Volumeuom = Nothing Then
                oProduct.Volumeuom = "GAL"
            End If
            If IsDBNull(oProduct.Weightuom) Or oProduct.Weightuom = Nothing Then
                oProduct.Weightuom = "LB"
            End If
            oProduct.Volumeunits = vVolumeUnits
            oProduct.Volumestandardcost = vVolumeUnitCost
            oProduct.Weightunits = vWeightUnits
            oProduct.Weightstandardcost = vWeightUnitCost
            oProduct.Save()
            If (vOldVolUnitCost <> vVolumeUnitCost Or vOldWgtUnitCost <> vWeightUnitCost) Then
                'Process Product Cost Changes Across all Related Products
                ProcessProductStandardCostChanges(vProductID, vOldVolUnitCost, vOldWgtUnitCost, vVolumeUnitCost, vWeightUnitCost, vReasonForChange, vChangeType, vChangeID, vWhatChanged)
            End If
        Else
            Exit Sub
        End If


        ''record this APIS COST change even in the CHANGERECORD table
        'Dim vChg As Changerecord
        'vChg = New Changerecord
        'vChg.Changetype = "APIS"
        'vChg.Whatchanged = "PRODUCT STD COSTING"
        'vChg.Whochanged = vCurrentUserLogin
        'vChg.Whenchanged = Now
        'vChg.Whychanged = vReasonForChange
        'vChg.Priorvalue1name = "VOL STD COST"
        'vChg.Priorvalue1 = vOldVolUnitCost
        'vChg.Priorvalue2name = "WGT STD COST"
        'vChg.Priorvalue2 = vOldWgtUnitCost
        'vChg.Newvalue1 = vVolumeUnitCost
        'vChg.Newvalue2 = vWeightUnitCost
        'vChg.Datatablename = vChangeType
        'vChg.Datarecordid = vChangeID
        'vChg.Recordstatus = "APPROVED"
        'vChg.Save()

        ''now find all cascading potential cost changes from this one product cost change

        ''find MaterialID the product may be linked to
        'Dim vMatID As Integer
        'Dim oMatProd As New MaterialproductCollection
        'oMatProd.Query.Where(oMatProd.Query.Productid.Equal(vProductID))
        'If oMatProd.Query.Load Then
        '    vMatID = oMatProd(0).Materialid
        'Else
        '    Exit Sub
        'End If

        ''now find all APIS records linked to this MaterialID
        'Dim oApisList As New ViewMaterialAPISListCollection
        'If vChangeType = "APIS" Then
        '    'exclude the APIS that just produced the change
        '    oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"), oApisList.Query.Apisnum.NotEqual(vChangeID))
        'Else
        '    oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"))
        'End If

        'If oApisList.Query.Load Then
        '    For Each oApis As ViewMaterialAPISList In oApisList
        '        'add record to CHANGEREVIEW table
        '        Dim vReview As New Changereview
        '        vReview.Changerecid = vChg.Changerecid
        '        vReview.Datatablename = "APIS"
        '        vReview.Datarecordid = oApis.Apisnum
        '        vReview.Referencetype = "PRODUCT"
        '        vReview.Referenceid = oApis.Productid
        '        vReview.Reviewreason = "PRODUCT COST CHG - " & vProductID.ToString
        '        vReview.Reviewstatus = "PENDING"
        '        vReview.Save()
        '    Next

        '    'because there is at least one cascading APIS change to be review from the original APIS change, 
        '    'mark the original APIS Change CHANGERECORD as REVIEW
        '    vChg.Changetype = "STD COST"
        '    vChg.Recordstatus = "REVIEW"
        '    vChg.Save()
        'End If

    End Sub

    Public Sub updateStandardCostingFromStandardLaborRateChange()


        '1. Update Related Relabel Product Records with Prodduct Status = ACTIVE RELABEL gets priority

        Dim rp As New ProductfulfillmentplanQuery("rp")
        Dim p As New ProductQuery("p")
        rp.InnerJoin(p).On(rp.Productid = p.Productid)
        rp.Where(rp.Stdlaborhrs.IsNotNull And p.Productstatus = "ACTIVE")
        rp.OrderBy(rp.Productid.Ascending)
        Dim oRelabelProds As New ProductfulfillmentplanCollection
        If (oRelabelProds.Load(rp)) Then
            For Each obj As Productfulfillmentplan In oRelabelProds
                'loop through Relabeled Products with same Origin ProductID and update standard costs
                If getProductStandardCostSource(obj.Productid) = "RELABEL" Then

                    ProcessRelabelProductStandardCostChanges(obj.Productid, "STD COST", "STD LABOR RATE CHANGE", "STD LABOR RATE CHANGE")

                End If

            Next
        End If


        'UPDATE ALL ACTIVE APIS RECORDS WITH NEW LABOR RATE

        'find all ACTIVE APIS records
        Dim oAPISList As New ApisCollection
        oAPISList.Query.Where(oAPISList.Query.Apisstatus.Equal("ACTIVE"))
        oAPISList.Query.OrderBy(oAPISList.Query.Productid.Ascending)
        If oAPISList.Query.Load Then

            'Loop through APIS records, pulling up APIS Cost View
            For Each oAPIS As Apis In oAPISList
                'get Total Costs for the current APIS in the list
                'update standard costs for product created from this APIS, as well as all related products
                If getProductStandardCostSource(oAPIS.Productid) = "APIS" Then
                    ProcessAPISProductStandardCostChanges(oAPIS.Productid, "STD COST", "STD LABOR RATE CHANGE", "STD LABOR RATE CHANGE")
                End If
                'updateAPISStandardCosting(oAPIS.Productid, oTotalCosts.Volume, IIf(IsDBNull(oTotalCosts.ApisVolUnitCost), 0, oTotalCosts.ApisVolUnitCost), oTotalCosts.Weight, IIf(IsDBNull(oTotalCosts.ApisUnitCost), 0, oTotalCosts.ApisUnitCost), "STD LABOR RATE CHANGE", "STD COST", oAPIS.Apisnum)
            Next
        End If
    End Sub


    Public Sub updateStandardCostingFromVendorCostChange(vProductID As Integer, vVolumeUnits As Decimal, vVolUOM As String, vVolumeUnitCost As Decimal, vWeightUnits As Decimal, vWeightUOM As String, vWeightUnitCost As Decimal, vReasonForChange As String, vChangeType As String, vChangeID As Integer, vWhatChanged As String)

        'change the standard cost data for the product
        Dim vProductStandardCostSource = getProductStandardCostSource(vProductID)
        If vProductStandardCostSource = "PURCHASE" Then
            Dim oProduct As New Product
            Dim vOldVolUnitCost As Decimal = 0.00
            Dim vOldWgtUnitCost As Decimal = 0.00
            If oProduct.LoadByPrimaryKey(vProductID) Then
                'get old values
                vOldVolUnitCost = IIf(IsDBNull(oProduct.Volumestandardcost), 0, oProduct.Volumestandardcost)
                vOldWgtUnitCost = IIf(IsDBNull(oProduct.Weightstandardcost), 0, oProduct.Weightstandardcost)

                'set new values
                oProduct.Volumeunits = vVolumeUnits
                oProduct.Volumeuom = vVolUOM
                oProduct.Volumestandardcost = vVolumeUnitCost
                oProduct.Weightunits = vWeightUnits
                oProduct.Weightuom = vWeightUOM
                oProduct.Weightstandardcost = vWeightUnitCost
                oProduct.Save()

                If (vOldVolUnitCost <> vVolumeUnitCost Or vOldWgtUnitCost <> vWeightUnitCost) Then
                    'Process Product Cost Changes Across all Related Products
                    ProcessProductStandardCostChanges(vProductID, vOldVolUnitCost, vOldWgtUnitCost, vVolumeUnitCost, vWeightUnitCost, vReasonForChange, "STD COST", vChangeID, vWhatChanged)
                End If
            Else
                Exit Sub
            End If
        End If



        ''record this APIS COST change even in the CHANGERECORD table
        'Dim vChg As Changerecord
        'vChg = New Changerecord
        'vChg.Changetype = "STD COST"
        'vChg.Whatchanged = "PRODUCT STD COSTING"
        'vChg.Whochanged = vCurrentUserLogin
        'vChg.Whenchanged = Now
        'vChg.Whychanged = vReasonForChange
        'vChg.Priorvalue1name = "VOL STD COST"
        'vChg.Priorvalue1 = vOldVolUnitCost
        'vChg.Priorvalue2name = "WGT STD COST"
        'vChg.Priorvalue2 = vOldWgtUnitCost
        'vChg.Newvalue1 = vVolumeUnitCost
        'vChg.Newvalue2 = vWeightUnitCost
        'vChg.Datatablename = "PRODUCT"
        'vChg.Datarecordid = vChangeID
        'vChg.Recordstatus = "REVIEW"
        'vChg.Save()

        ''now find all cascading potential cost changes from this one product cost change

        ''find MaterialID the product may be linked to
        'Dim vMatID As Integer
        'Dim oMatProd As New MaterialproductCollection
        'oMatProd.Query.Where(oMatProd.Query.Productid.Equal(vProductID))
        'If oMatProd.Query.Load Then
        '    vMatID = oMatProd(0).Materialid
        'Else
        '    Exit Sub
        'End If

        ''now find all APIS records linked to this MaterialID
        'Dim oApisList As New ViewMaterialAPISListCollection
        'If vChangeType = "APIS" Then
        '    'exclude the APIS that just produced the change
        '    oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"), oApisList.Query.Apisnum.NotEqual(vChangeID))
        'Else
        '    oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"))
        'End If

        'If oApisList.Query.Load Then
        '    For Each oApis As ViewMaterialAPISList In oApisList
        '        'add record to CHANGEREVIEW table
        '        Dim vReview As New Changereview
        '        vReview.Changerecid = vChg.Changerecid
        '        vReview.Datatablename = "APIS"
        '        vReview.Datarecordid = oApis.Apisnum
        '        vReview.Referencetype = "PRODUCT"
        '        vReview.Referenceid = oApis.Productid
        '        vReview.Reviewreason = "PRODUCT COST CHG - " & vProductID.ToString
        '        vReview.Reviewstatus = "PENDING"
        '        vReview.Save()
        '    Next
        'End If

    End Sub


    Public Function SetStandardCostToVendorCost(ByRef oProduct As Product) As Boolean

        'Set the standard cost data for the product
        Dim oProductCosts As New ProductcostCollection
        Dim oProductcost As Productcost
        oProductCosts.Query.Where(oProductCosts.Query.Productid = oProduct.Productid And oProductCosts.Query.Isactive = True And oProductCosts.Query.Isdefaultcostrecord = True)
        oProductCosts.Query.OrderBy(oProductCosts.Query.Costrecid.Descending)
        If (oProductCosts.Query.Load() AndAlso oProductCosts.Count > 0) Then
            oProductcost = oProductCosts(0)        ' check if default cost record found 
        Else
            oProductCosts = New ProductcostCollection
            oProductCosts.Query.Where(oProductCosts.Query.Productid = oProduct.Productid And oProductCosts.Query.Isdefaultcostrecord = True)
            oProductCosts.Query.OrderBy(oProductCosts.Query.Isactive.Descending, oProductCosts.Query.Costrecid.Descending)
            If (oProductCosts.Query.Load() AndAlso oProductCosts.Count > 0) Then
                oProductcost = oProductCosts(0)        ' check if active record found 
            Else
                oProductCosts = New ProductcostCollection
                oProductCosts.Query.Where(oProductCosts.Query.Productid = oProduct.Productid)
                oProductCosts.Query.OrderBy(oProductCosts.Query.Isdefaultcostrecord.Descending, oProductCosts.Query.Isactive.Descending, oProductCosts.Query.Costrecid.Descending)
                If (oProductCosts.Query.Load() AndAlso oProductCosts.Count > 0) Then
                    oProductcost = oProductCosts(0) ' checkif any cost record exists
                Else
                    Return False
                End If
            End If
        End If

        'set new values
        oProduct.Volumeunits = oProductcost.Volumeunits
        oProduct.Volumeuom = oProductcost.Volumeuom
        oProduct.Volumestandardcost = oProductcost.Volumestandardcost
        oProduct.Weightunits = oProductcost.Weightunits
        oProduct.Weightuom = oProductcost.Weightuom
        oProduct.Weightstandardcost = oProductcost.Weightstandardcost
        Return True
    End Function


    Public Sub updateStandardCostingFromVendorComponentCostChange(vComponentID As Integer, vUnitCost As Decimal, vReasonForChange As String, vChangeType As String, vChangeID As Integer, vWhatChanged As String)

        'change the standard cost data for the product
        Dim oComponent As New Component
        Dim vOldUnitCost As Decimal = 0.00
        If oComponent.LoadByPrimaryKey(vComponentID) Then
            If vOldUnitCost <> vUnitCost Then
                'get old values
                vOldUnitCost = IIf(IsDBNull(oComponent.Unitcost), 0, oComponent.Unitcost)

                'set new values
                oComponent.Unitcost = vUnitCost
                oComponent.Save()

                'Process Component Cost Changes Across all Related hierarchy
                ProcessComponentCostChanges(vComponentID, vOldUnitCost, vUnitCost, vReasonForChange, "STD COST", vChangeID, vWhatChanged)
            End If

        Else
            Exit Sub
        End If


    End Sub


    Public Function CompareStandardCostToComponentCostRecord(vComponentId As Integer, vCostRecordID As Integer) As Integer

        'List of Return Values:
        '0 - Standard Cost and Component Cost record values do NOT match
        '1 - Standard Cost and Component Cost record values DO match
        '2 - Data is missing and can't complete the comparison

        If IsDBNull(vComponentId) Then
            Return 2
        End If

        If IsDBNull(vCostRecordID) Then
            Return 2
        End If

        Dim oComponent As New Component
        Dim oCost As New Componentcost

        If Not oComponent.LoadByPrimaryKey(vComponentId) Then
            Return 2
        End If

        If Not oCost.LoadByPrimaryKey(vCostRecordID) Then
            Return 2
        End If

        'Check for missing values in the cost fields
        If IsDBNull(oComponent.Unitcost) Then
            Return 2
        End If

        If IsDBNull(oCost.UnitCost) Then
            Return 2
        End If


        'At this point we have two records to compare to each other
        'We compare units in container and unit cost values 
        'If any of the values do NOT match, then we return a 0 value, otherwise a 1 value
        If oComponent.Unitcost <> oCost.UnitCost Then
            Return 0
        End If
        'If we make it this far, all costing data matches between the Component and ComponentCOST records
        Return 1

    End Function


    Public Function MarkVendorProductCostAsDefault(vCostRecId As Integer)

        'Clear all default settings for the current Product ID
        Dim oDefCost As New Productcost
        If oDefCost.LoadByPrimaryKey(vCostRecId) Then
            If Not oDefCost.Isactive.HasValue OrElse Not oDefCost.Isactive.Value Then
                MsgBox("Inactive cost record can not be marked as default. Please edit cost record to set it active", vbOKOnly)
                Return False
            End If
            Dim oCosts As New ProductcostCollection
            oCosts.Query.Where(oCosts.Query.Productid.Equal(oDefCost.Productid))
            If oCosts.Query.Load Then
                For Each oCost As Productcost In oCosts
                    oCost.Isdefaultcostrecord = 0
                Next
                oCosts.Save()
            End If

            oDefCost.Isdefaultcostrecord = 1
            oDefCost.Save()
            SetProductStatndardCosts(oDefCost.Productid, "Default Vendor Cost changed. PROD ID-" & oDefCost.Productid)
            Return True
        End If
        Return False
    End Function
    Public Sub updateVendorProductCosting(vCostRecID As Integer, vCostMethod As String, vVolUnits As Decimal, vVolUOM As String, vVolUnitCost As Decimal, vWgtUnits As Decimal, vWgtUOM As String, vWgtUnitCost As Decimal, vReasonForChange As String, vProductID As Integer, vVendorID As Integer, vOrigVolCost As Decimal, vOrigWgtCost As Decimal)

        'change the standard cost data for the product
        Dim oCOst As New Productcost
        Dim vOldVolUnitCost As Decimal = vOrigVolCost
        Dim vOldWgtUnitCost As Decimal = vOrigWgtCost

        If oCOst.LoadByPrimaryKey(vCostRecID) Then
            'get old values

            'set new values
            oCOst.Volumeunits = vVolUnits
            oCOst.Volumestandardcost = vVolUnitCost
            oCOst.Weightunits = vWgtUnits
            oCOst.Weightstandardcost = vWgtUnitCost
            oCOst.Volumeuom = vVolUOM
            oCOst.Weightuom = vWgtUOM
            oCOst.Vendorid = vVendorID

            'update UNITS and UOM legacy data fields for current system use - this will be obsolete at a later date.
            Select Case vCostMethod
                Case PricingMethod.WEIGHT.ToString()
                    oCOst.Units = vWgtUnits
                    oCOst.Uom = vWgtUOM
                    oCOst.Unitcost = vWgtUnitCost
                Case PricingMethod.VOLUME.ToString()
                    oCOst.Units = vVolUnits
                    oCOst.Uom = vVolUOM
                    oCOst.Unitcost = vVolUnitCost
                Case Else
                    'no COSTMETHOD in the PRODUCTCOST record
                    If vVolUnitCost > 0 And vWgtUnitCost <= 0 Then
                        'There is a volume standcost entered only
                        oCOst.Units = vVolUnits
                        oCOst.Uom = vVolUOM
                        oCOst.Unitcost = vVolUnitCost
                    End If

                    If vVolUnitCost > 0 And vWgtUnitCost <= 0 Then
                        'There is a weight standcost entered only
                        oCOst.Units = vWgtUnits
                        oCOst.Uom = vWgtUOM
                        oCOst.Unitcost = vWgtUnitCost
                    End If

            End Select
            oCOst.Modifyby = vCurrentUserLogin
            oCOst.Modifytime = Now
            oCOst.Save()
            'record this VENDOR COST change even in the CHANGERECORD table
            AddChangeHistoryRecord("PRODUCTCOST", vCostRecID, "VOL COST", vOldVolUnitCost, vVolUnitCost, "WGT COST", vOldWgtUnitCost, vWgtUnitCost, vReasonForChange, "VENDOR COST", "VENDOR COSTING")
            If (oCOst.Isdefaultcostrecord AndAlso (vOldVolUnitCost <> vVolUnitCost Or vOldWgtUnitCost <> vWgtUnitCost)) Then
                updateStandardCostingFromVendorCostChange(oCOst.Productid, vVolUnits, vVolUOM, vVolUnitCost, vWgtUnits, vWgtUOM, vWgtUnitCost, "Vendor Cost Updated", "STANDARD COST", oCOst.Productid, "VNDR COST CHNG-" & vProductID)
            End If

        Else
            Exit Sub
        End If


        'Dim vChg As Changerecord
        'vChg = New Changerecord
        'vChg.Changetype = "VENDOR COST"
        'vChg.Whatchanged = "VENDOR COSTING"
        'vChg.Whochanged = vCurrentUserLogin
        'vChg.Whenchanged = Now
        'vChg.Whychanged = vReasonForChange
        'vChg.Priorvalue1name = "VOL COST"
        'vChg.Priorvalue1 = vOldVolUnitCost
        'vChg.Priorvalue2name = "WGT COST"
        'vChg.Priorvalue2 = vOldWgtUnitCost
        'vChg.Newvalue1 = vVolUnitCost
        'vChg.Newvalue2 = vWgtUnitCost
        'vChg.Datatablename = "PRODUCTCOST"
        'vChg.Datarecordid = vCostRecID
        'vChg.Recordstatus = "REVIEW"
        'vChg.Save()

    End Sub

    Public Sub updateVendorComponentCosting(vCostRecID As Integer, vUnitCost As Decimal, vReasonForChange As String, vComponentID As Integer, vVendorID As Integer, vOrigUnitCost As Decimal)

        'change the standard cost data for the component
        Dim oCOst As New Componentcost
        Dim vOrgVendorId As Integer
        If oCOst.LoadByPrimaryKey(vCostRecID) Then
            'get old values
            vOrgVendorId = oCOst.VendorId
            'set new values
            oCOst.UnitCost = vUnitCost
            oCOst.VendorId = vVendorID

            oCOst.ModifiedBy = vCurrentUserLogin
            oCOst.ModifiedDateTime = Now
            oCOst.Save()
        Else
            Exit Sub
        End If

        'record this VENDOR COST change even in the CHANGERECORD table
        Dim vChg As Changerecord
        vChg = New Changerecord
        vChg.Changetype = "VENDOR COST"
        vChg.Whatchanged = "VENDOR COSTING"
        vChg.Whochanged = vCurrentUserLogin
        vChg.Whenchanged = Now
        vChg.Whychanged = vReasonForChange
        vChg.Priorvalue1name = "UNIT COST"
        vChg.Priorvalue1 = vOrigUnitCost
        vChg.Priorvalue2name = "VENDOR ID"
        vChg.Priorvalue2 = vOrgVendorId
        vChg.Newvalue1 = vUnitCost
        vChg.Newvalue2 = vVendorID
        vChg.Datatablename = "COMPONENTCOST"
        vChg.Datarecordid = vCostRecID
        vChg.Recordstatus = "REVIEW"
        vChg.Save()

    End Sub

    Public Function getProductStandardCostSource(ByVal vProductId As Integer) As String
        Dim oAPISList As ApisCollection = getAPISByProductID(vProductId, "ACTIVE")
        Dim oFulfillment As ViewProductFulfillmentCollection = getProductFulfillment(vProductId)
        Dim StdCostSource As String = String.Empty

        If Not (IsDBNull(oFulfillment) Or oFulfillment Is Nothing) Then
            If oFulfillment.Count > 0 Then
                'There are ProductFulfillment records -  Get the first non "INV' record
                Dim vFulfillmenttype As String = String.Empty
                If oFulfillment(0).Fulfillmenttype <> "INV" Then
                    vFulfillmenttype = oFulfillment(0).Fulfillmenttype
                Else
                    If oFulfillment.Count > 1 Then
                        vFulfillmenttype = oFulfillment(1).Fulfillmenttype
                    End If
                    Select Case vFulfillmenttype
                        Case "RLBL"
                            StdCostSource = "RELABEL"
                        Case "PORD"
                            StdCostSource = "APIS"
                        Case "PRCH"
                            StdCostSource = "PURCHASE"
                    End Select
                End If
            End If
        End If


        If String.IsNullOrEmpty(StdCostSource) Then

            If oAPISList.Count > 0 Then 'there is a default ACTIVE Apis for this product
                StdCostSource = "APIS"
            Else
                StdCostSource = "PURCHASE"
            End If
        End If
        If StdCostSource.Equals("PURCHASE", StringComparison.CurrentCultureIgnoreCase) Then
            Dim oProduct As New Product
            If (oProduct.LoadByPrimaryKey(vProductId) AndAlso oProduct.Standardcostoverride) Then
                StdCostSource = "OVERRIDE"
            End If
        End If

        Return StdCostSource
    End Function

    Public Sub SetProductStatndardCosts(vProductId As Integer, vWhatChanged As String, Optional vReasonForChange As String = "")
        If vReasonForChange = String.Empty Then
            vReasonForChange = vWhatChanged
        End If
        Dim vProductStandardCostSource = getProductStandardCostSource(vProductId)
        Select Case vProductStandardCostSource
            Case "RELABEL"
                ProcessRelabelProductStandardCostChanges(vProductId, "STD COST", vReasonForChange, vWhatChanged)
            Case "APIS"
                ProcessAPISProductStandardCostChanges(vProductId, "STD COST", vReasonForChange, vWhatChanged)
            Case "OVERRIDE"
                'Do nothing keep costs as they are
            Case Else 'PURCHASE
                ProcessPurchaseProductStandardCostChanges(vProductId, "STD COST", vReasonForChange, vWhatChanged)
        End Select
    End Sub

    Public Sub ProcessPurchaseProductStandardCostChanges(vProductId As Integer, vChangeType As String, vReasonForChange As String, vWhatChanged As String)
        Dim oProduct As New Product
        If oProduct.LoadByPrimaryKey(vProductId) Then
            If SetStandardCostToVendorCost(oProduct) Then
                updateStandardCostingFromVendorCostChange(vProductId, oProduct.Volumeunits, oProduct.Volumeuom, oProduct.Volumestandardcost,
                            oProduct.Weightunits, oProduct.Weightuom, oProduct.Weightstandardcost, vReasonForChange, vChangeType, vProductId, vWhatChanged)
            End If
        End If
    End Sub

End Module
