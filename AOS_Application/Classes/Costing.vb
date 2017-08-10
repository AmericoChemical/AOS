Module Costing

    Public Sub ProcessProductStandardCostChanges(vProdID As Integer, vOldVolCost As Decimal, vOldWgtCost As Decimal, vNewVolCost As Decimal, vNewWgtCost As Decimal, vReasonForChange As String, vChangeType As String, vChangeID As Integer)

        Dim oProductRecord As New Product
        oProductRecord.LoadByPrimaryKey(vProdID)

        '1. Add Product Change History Record for Initial Product
        AddProductCostChangeHistoryRecord(vProdID, vOldVolCost, vOldWgtCost, vNewVolCost, vNewWgtCost, vReasonForChange, vChangeType)

        '2. Update Related Relabel Product Records
        Dim oRelabelProds As New ProductfulfillmentplanCollection
        oRelabelProds.Query.Where(oRelabelProds.Query.Associatedproductid.Equal(vProdID))
        If oRelabelProds.Query.Load Then
            'loop through Relabeled Products with same Origin ProductID and update standard costs
            For Each obj As Productfulfillmentplan In oRelabelProds
                'determine standard costs with new data from origin ProductID new standard costs
                Dim oRlbCosts As New ViewRelabelProductsCostChanges
                oRlbCosts.Query.Where(oRlbCosts.Query.Productid.Equal(obj.Productid))
                If oRlbCosts.Query.Load Then
                    'update Relabeled Product Standard Costs
                    Dim oProduct As New Product
                    If oProduct.LoadByPrimaryKey(obj.Productid) Then
                        'set new values
                        oProduct.Volumestandardcost = oRlbCosts.Newvolcost
                        oProduct.Weightstandardcost = oRlbCosts.Newwgtcost
                        oProduct.Save()
                    End If

                    'add product change history record for the relabeled product
                    AddProductCostChangeHistoryRecord(obj.Productid, oRlbCosts.Oldvolcost, oRlbCosts.Oldwgtcost, oRlbCosts.Newvolcost, oRlbCosts.Newwgtcost, "RELABEL CHNG - PROD " & vProdID & " " & oProductRecord.Productdesc, vChangeType)
                End If
            Next
        End If

        '3. Update Related APIS Product Records
        'find MaterialID the product may be linked to
        Dim vMatID As Integer
        Dim oMatProd As New MaterialproductCollection
        oMatProd.Query.Where(oMatProd.Query.Productid.Equal(vProdID))
        If oMatProd.Query.Load Then
            vMatID = oMatProd(0).Materialid
        Else
            Exit Sub
        End If

        'now find all APIS records linked to this MaterialID
        Dim oApisList As New ViewMaterialAPISListCollection
        If vChangeType = "APIS" Then
            'exclude the APIS that just produced the change
            oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"), oApisList.Query.Apisnum.NotEqual(vChangeID))
        Else
            oApisList.Query.Where(oApisList.Query.Materialid.Equal(vMatID), oApisList.Query.Apisstatus.Equal("ACTIVE"))
        End If

        If oApisList.Query.Load Then
            For Each oApis As ViewMaterialAPISList In oApisList
                'Loop through all related APIS products, updating standard costs
                Dim oApisCost As New ViewAPISProductsCostChanges
                oApisCost.Query.Where(oApisCost.Query.Productid.Equal(oApis.Productid))
                If oApisCost.Query.Load Then
                    'update APIS Product Standard Costs
                    Dim oProduct As New Product
                    If oProduct.LoadByPrimaryKey(oApisCost.Productid) Then
                        'set new values
                        oProduct.Volumestandardcost = oApisCost.Newvolcost
                        oProduct.Weightstandardcost = oApisCost.Newwgtcost
                        oProduct.Save()
                    End If

                    'add product change history record for the relabeled product
                    AddProductCostChangeHistoryRecord(oApisCost.Productid, oApisCost.Oldvolcost, oApisCost.Oldwgtcost, oApisCost.Newvolcost, oApisCost.Newwgtcost, "APIS CHNG - PROD " & vProdID & " " & oProductRecord.Productdesc, vChangeType)
                End If
            Next

            'Extrapolate through one more time to find second level APIS records to update
            For Each oAPIS1 As ViewMaterialAPISList In oApisList
                'find other APIS records that use the Product created by the current apis in oAPIS1 and process those costs as well
                Dim oDefaultMatProd As New ViewCostingMaterialDefaultProductCollection
                oDefaultMatProd.Query.Where(oDefaultMatProd.Query.Productid.Equal(oAPIS1.Productid))
                If oDefaultMatProd.Query.Load Then
                    vMatID = oDefaultMatProd(0).Materialid
                Else
                    'loop back, as no material id found for this product
                    Continue For
                End If

                Dim oApisList2 As New ViewMaterialAPISListCollection
                oApisList2.Query.Where(oApisList2.Query.Materialid.Equal(vMatID), oApisList2.Query.Apisstatus.Equal("ACTIVE"), oApisList2.Query.Apisnum.NotEqual(oAPIS1.Apisnum))
                If oApisList2.Query.Load Then
                    'loop through all related APIS products, updating standard costs
                    For Each oApis2 As ViewMaterialAPISList In oApisList2
                        'Loop through all related APIS products, updating standard costs
                        Dim oApisCost2 As New ViewAPISProductsCostChanges
                        oApisCost2.Query.Where(oApisCost2.Query.Productid.Equal(oApis2.Productid))
                        If oApisCost2.Query.Load Then
                            'update APIS Product Standard Costs
                            Dim oProduct As New Product
                            If oProduct.LoadByPrimaryKey(oApisCost2.Productid) Then
                                'set new values
                                oProduct.Volumestandardcost = oApisCost2.Newvolcost
                                oProduct.Weightstandardcost = oApisCost2.Newwgtcost
                                oProduct.Save()
                            End If

                            'add product change history record for the relabeled product
                            AddProductCostChangeHistoryRecord(oApisCost2.Productid, oApisCost2.Oldvolcost, oApisCost2.Oldwgtcost, oApisCost2.Newvolcost, oApisCost2.Newwgtcost, "APIS CHNG - PROD " & vProdID & " " & oProductRecord.Productdesc, vChangeType)
                        End If
                    Next
                End If

            Next
        End If

    End Sub

    Public Sub AddProductCostChangeHistoryRecord(vProdID As Integer, vOldVolCost As Decimal, vOldWgtCost As Decimal, vNewVolCost As Decimal, vNewWgtCost As Decimal, vReasonForChange As String, vChangeType As String)

        Dim vChg As New Changerecord
        vChg.Changetype = vChangeType
        vChg.Whatchanged = "PRODUCT STD COSTING"
        vChg.Whochanged = vCurrentUserLogin
        vChg.Whenchanged = Now
        vChg.Whychanged = vReasonForChange
        vChg.Priorvalue1name = "VOL STD COST"
        vChg.Priorvalue1 = vOldVolCost
        vChg.Priorvalue2name = "WGT STD COST"
        vChg.Priorvalue2 = vOldWgtCost
        vChg.Newvalue1 = vNewVolCost
        vChg.Newvalue2 = vNewWgtCost
        vChg.Datatablename = "PRODUCT"
        vChg.Datarecordid = vProdID
        vChg.Recordstatus = "REVIEW"
        vChg.Save()

    End Sub

    Public Sub updateProductStandardCosting(vProductID As Integer, vVolumeUnits As Decimal, vOldVolumeUnitCost As Decimal, vVolumeUnitCost As Decimal, vWeightUnits As Decimal, vOldWeightUnitCost As Decimal, vWeightUnitCost As Decimal, vReasonForChange As String, vChangeType As String, vChangeID As Integer)

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
        Else
            Exit Sub
        End If

        'Process Product Cost Changes Across all Related Products
        ProcessProductStandardCostChanges(vProductID, vOldVolumeUnitCost, vOldWeightUnitCost, vVolumeUnitCost, vWeightUnitCost, vReasonForChange, vChangeType, vChangeID)



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

    Public Sub updateAPISStandardCosting(vProductID As Integer, vVolumeUnits As Decimal, vVolumeUnitCost As Decimal, vWeightUnits As Decimal, vWeightUnitCost As Decimal, vReasonForChange As String, vChangeType As String, vChangeID As Integer)

        'change the standard cost data for the product
        Dim oProduct As New Product
        Dim vOldVolUnitCost As Decimal = 0.00
        Dim vOldWgtUnitCost As Decimal = 0.00
        If oProduct.LoadByPrimaryKey(vProductID) Then
            'get old values
            vOldVolUnitCost = oProduct.Volumestandardcost
            vOldWgtUnitCost = oProduct.Weightstandardcost

            'set new values
            oProduct.Volumeunits = vVolumeUnits
            oProduct.Volumestandardcost = vVolumeUnitCost
            oProduct.Weightunits = vWeightUnits
            oProduct.Weightstandardcost = vWeightUnitCost
            oProduct.Save()
        Else
            Exit Sub
        End If

        'Process Product Cost Changes Across all Related Products
        ProcessProductStandardCostChanges(vProductID, vOldVolUnitCost, vOldWgtUnitCost, vVolumeUnitCost, vWeightUnitCost, vReasonForChange, vChangeType, vChangeID)



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

    Public Sub updateStandardCostingFromVendorCostChange(vProductID As Integer, vVolumeUnits As Decimal, vVolUOM As String, vVolumeUnitCost As Decimal, vWeightUnits As Decimal, vWeightUOM As String, vWeightUnitCost As Decimal, vReasonForChange As String, vChangeType As String, vChangeID As Integer)

        'change the standard cost data for the product
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
        Else
            Exit Sub
        End If

        'Process Product Cost Changes Across all Related Products
        ProcessProductStandardCostChanges(vProductID, vOldVolUnitCost, vOldWgtUnitCost, vVolumeUnitCost, vWeightUnitCost, vReasonForChange, "STD COST", vChangeID)



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

    Public Sub updateVendorProductCosting(vCostRecID As Integer, vCostMethod As String, vVolUnits As Decimal, vVolUOM As String, vVolUnitCost As Decimal, vWgtUnits As Decimal, vWgtUOM As String, vWgtUnitCost As Decimal, vReasonForChange As String, vProductID As Integer, vVendorID As Integer, vOrigVolCost As Decimal, vOrigWgtCost As Decimal)

        'change the standard cost data for the product
        Dim oCOst As New Productcost
        Dim vOldVolUnitCost As Decimal = vOrigVolCost
        Dim vOldWgtUnitCost As Decimal = vOrigWgtCost

        If oCost.LoadByPrimaryKey(vCostRecID) Then
            'get old values

            'set new values
            oCost.Volumeunits = vVolUnits
            oCost.Volumestandardcost = vVolUnitCost
            oCost.Weightunits = vWgtUnits
            oCost.Weightstandardcost = vWgtUnitCost
            oCost.Volumeuom = vVolUOM
            oCost.Weightuom = vWgtUOM
            oCost.Vendorid = vVendorID

            'update UNITS and UOM legacy data fields for current system use - this will be obsolete at a later date.
            Select Case vCostMethod
                Case PricingMethod.WEIGHT.ToString()
                    oCost.Units = vWgtUnits
                    oCost.Uom = vWgtUOM
                    oCost.Unitcost = vWgtUnitCost
                Case PricingMethod.VOLUME.ToString()
                    oCost.Units = vVolUnits
                    oCost.Uom = vVolUOM
                    oCost.Unitcost = vVolUnitCost
                Case Else
                    'no COSTMETHOD in the PRODUCTCOST record
                    If vVolUnitCost > 0 And vWgtUnitCost <= 0 Then
                        'There is a volume standcost entered only
                        oCost.Units = vVolUnits
                        oCost.Uom = vVolUOM
                        oCost.Unitcost = vVolUnitCost
                    End If

                    If vVolUnitCost > 0 And vWgtUnitCost <= 0 Then
                        'There is a weight standcost entered only
                        oCost.Units = vWgtUnits
                        oCost.Uom = vWgtUOM
                        oCost.Unitcost = vWgtUnitCost
                    End If

            End Select
            oCost.Modifyby = vCurrentUserLogin
            oCost.Modifytime = Now
            oCost.Save()
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
        vChg.Priorvalue1name = "VOL COST"
        vChg.Priorvalue1 = vOldVolUnitCost
        vChg.Priorvalue2name = "WGT COST"
        vChg.Priorvalue2 = vOldWgtUnitCost
        vChg.Newvalue1 = vVolUnitCost
        vChg.Newvalue2 = vWgtUnitCost
        vChg.Datatablename = "PRODUCTCOST"
        vChg.Datarecordid = vCostRecID
        vChg.Recordstatus = "REVIEW"
        vChg.Save()

    End Sub

End Module
