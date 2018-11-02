Imports AOS.BusinessObjects

Module ProductProcessing

    Public Enum FulfillmentType
        INV = 1
        RLBL = 2
        CONV = 3
        PORD = 4
        PRCH = 5
    End Enum

    Public Function getProductCost(vCustid As Integer?, vProductID As Integer) As Productcost
        If vCustid Is Nothing OrElse
            IsDBNull(vCustid) = True Then
            Return Nothing
        End If
        If vProductID <= 0 Then
            Return Nothing
        End If

        Dim oProductCosts As ProductcostCollection = getProductCosts(vCustid, vProductID)

        If (oProductCosts.Count = 1) Then
            Return oProductCosts(0)
        Else
            Return Nothing
        End If
    End Function

    Public Function getProductCosts(vCustid As Integer?, vProductID As Integer) As ProductcostCollection
        If vCustid Is Nothing OrElse
            IsDBNull(vCustid) = True Then
            Return Nothing
        End If
        If vProductID <= 0 Then
            Return Nothing
        End If

        Dim oProductCosts As New ProductcostCollection

        oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProductID), _
            oProductCosts.Query.Or(oProductCosts.Query.Restrictedtocustomerid.IsNull(), _
            oProductCosts.Query.Restrictedtocustomerid.Equal(vCustid)))
        oProductCosts.Query.Load()
        oProductCosts.Sort = "Restrictedtocustomerid Desc"

        Return oProductCosts
    End Function

    Public Function getProductFulfillment(vPID As Integer) As ViewProductFulfillmentCollection
        If (vPID <= 0) Then
            Return Nothing
        End If
        Dim oproductfulfillmentcollection As New ViewProductFulfillmentCollection
        oproductfulfillmentcollection.Query.Where(oproductfulfillmentcollection.Query.Productid.Equal(vPID))
        oproductfulfillmentcollection.Query.Load()
        oproductfulfillmentcollection.Sort = "PRIORITY ASC, FULFILLMENTPLANID ASC"
        Return oproductfulfillmentcollection
    End Function

    Public Function getProduct(vStatus As String) As ProductCollection
        Dim oProductList As New ProductCollection
        Select Case vStatus
            Case "ALL"
                oProductList.LoadAll()
            Case "ACTIVE"
                oProductList.Query.Where(oProductList.Query.Productstatus.Equal("ACTIVE"))
                oProductList.Query.Load()
            Case "INACTIVE"
                oProductList.Query.Where(oProductList.Query.Productstatus.Equal("INACTIVE"))
                oProductList.Query.Load()
            Case "PENDING"
                oProductList.Query.Where(oProductList.Query.Productstatus.Equal("PENDING"))
                oProductList.Query.Load()
        End Select
        oProductList.Sort = "PRODUCTDESC ASC"
        Return oProductList
    End Function

    Public Function getProductByVendor(vVendorID As Integer) As ViewProductListByProductCostCollection
        Dim oProductList As New ViewProductListByProductCostCollection
        oProductList.Query.Where(oProductList.Query.Vendorid.Equal(vVendorID))
        oProductList.Query.Load()
        oProductList.Sort = "PRODUCTDESC ASC"
        Return oProductList
    End Function

    Public Function getActiveProductCosts(vProductID As Integer, Optional vVendorID As Integer? = 0) As ProductcostCollection
        Dim oProductCosts As New ProductcostCollection

        oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProductID), oProductCosts.Query.Isactive.Equal(1))
        If vVendorID > 0 Then
            oProductCosts.Query.Where(oProductCosts.Query.Vendorid.Equal(vVendorID))
        End If
        oProductCosts.Query.Load()
        oProductCosts.Sort = "COSTRECID ASC"

        Return oProductCosts
    End Function

    Public Function getFulfillmentPlan(vProductID As Integer, vFulfillmentType As FulfillmentType) As ProductfulfillmentplanCollection
        Dim oProductFulfillmentPlans As New ProductfulfillmentplanCollection
        oProductFulfillmentPlans.Query.Where(oProductFulfillmentPlans.Query.Productid.Equal(vProductID), _
                                             oProductFulfillmentPlans.Query.Fulfillmenttypeid.Equal(vFulfillmentType))
        oProductFulfillmentPlans.Query.Load()
        oProductFulfillmentPlans.Sort = "Priority Asc, Fulfillmentplanid Asc"

        Return oProductFulfillmentPlans
    End Function

    Public Function getAssociatedProductid(vProductid As Integer) As Integer?
        Dim oProductFulfillmentPlans As New ProductfulfillmentplanCollection
        oProductFulfillmentPlans.Query.Where(oProductFulfillmentPlans.Query.Productid.Equal(vProductid), _
                                             oProductFulfillmentPlans.Query.Fulfillmenttypeid.Equal(FulfillmentType.RLBL))
        If oProductFulfillmentPlans.Query.Load Then
            oProductFulfillmentPlans.Sort = "Priority ASC"
            Return oProductFulfillmentPlans(0).Associatedproductid
        Else
            Return Nothing
        End If

    End Function

    Public Function checkProductFulfillment(vProductid As Integer, vFulfillmentTypeid As Integer) As Boolean
        Dim oProductFulfillmentPlans As New ProductfulfillmentplanCollection
        oProductFulfillmentPlans.Query.Where(oProductFulfillmentPlans.Query.Productid.Equal(vProductid), _
                                             oProductFulfillmentPlans.Query.Fulfillmenttypeid.Equal(vFulfillmentTypeid))
        If oProductFulfillmentPlans.Query.Load Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getProductRelabelInstructions(vFulfillmentPlanID As Integer) As ProductrelabelinstructionCollection
        If vFulfillmentPlanID <= 0 Then
            Return Nothing
        End If
        Dim oProductRelabelInstructions As New ProductrelabelinstructionCollection
        oProductRelabelInstructions.Query.Where(oProductRelabelInstructions.Query.Fulfillmentplanid.Equal(vFulfillmentPlanID))
        oProductRelabelInstructions.Query.Load()
        oProductRelabelInstructions.Sort = "SEQUENCE ASC, PRODUCTRELABELINSTRUCTIONNUMBER ASC"
        Return oProductRelabelInstructions
    End Function

    Public Function getRelabelInstructions() As RelabelinstructionCollection
        Dim oRelabelInstructions As New RelabelinstructionCollection
        oRelabelInstructions.LoadAll()
        oRelabelInstructions.Sort = "SEQUENCE ASC, RELABELINSTRUCTIONNUMBER ASC"
        Return oRelabelInstructions
    End Function

    Public Sub deleteProductRelabelInstructionAndResetSeq(vProductrelabelinstructionnumber As Integer)
        If vProductrelabelinstructionnumber <= 0 Then
            Exit Sub
        End If
        Dim oProductRelabelInstruction As New Productrelabelinstruction
        If oProductRelabelInstruction.LoadByPrimaryKey(vProductrelabelinstructionnumber) = False Then
            Exit Sub
        End If
        Dim vFulfillmentPlanId As Integer = oProductRelabelInstruction.Fulfillmentplanid
        oProductRelabelInstruction.MarkAsDeleted()
        oProductRelabelInstruction.Save()

        'Reset Sequence
        updateProductRelabelInstructionSequence(vFulfillmentPlanId)
    End Sub

    Public Sub deleteRelabelInstructionAndResetSeq(vRelabelinstructionnumber As Integer)
        If vRelabelinstructionnumber <= 0 Then
            Exit Sub
        End If
        Dim oRelabelInstruction As New Relabelinstruction
        If oRelabelInstruction.LoadByPrimaryKey(vRelabelinstructionnumber) = False Then
            Exit Sub
        End If
        oRelabelInstruction.MarkAsDeleted()
        oRelabelInstruction.Save()

        'Reset Sequence
        updateRelabelInstructionSequence()
    End Sub

    Public Sub deleteProductRelabelInstructionsByFulfillmentPlanID(vFulfillmentPlanID As Integer)
        Dim oProductRelabelInstructions As ProductrelabelinstructionCollection = getProductRelabelInstructions(vFulfillmentPlanID)
        If oProductRelabelInstructions Is Nothing OrElse _
              oProductRelabelInstructions.Count <= 0 Then
            Exit Sub
        End If
        For Each oProductrelableinstruction As Productrelabelinstruction In oProductRelabelInstructions
            oProductrelableinstruction.MarkAsDeleted()
        Next
        oProductRelabelInstructions.Save()
    End Sub

    Public Function getProductRelabelInstructionMaxSequence(ByVal vFulfillmentPlanID As Integer) As Integer
        If vFulfillmentPlanID <= 0 Then
            Return 0
        End If
        Dim oProductRelabelInstructions As New ProductrelabelinstructionCollection
        oProductRelabelInstructions.Query.Where(oProductRelabelInstructions.Query.Fulfillmentplanid.Equal(vFulfillmentPlanID))
        If oProductRelabelInstructions.Query.Load() Then
            oProductRelabelInstructions.Sort = "SEQUENCE DESC"
            Return oProductRelabelInstructions(0).Sequence
        End If
        Return 0
    End Function

    Public Function getRelabelInstructionMaxSequence() As Integer
        Dim oRelabelInstructions As New RelabelinstructionCollection
        If oRelabelInstructions.Query.Load() Then
            oRelabelInstructions.Sort = "SEQUENCE DESC"
            Return oRelabelInstructions(0).Sequence
        End If
        Return 0
    End Function

    Public Function updateProductRelabelInstructions(vFulfillmentPlanID As Integer, vNewSourceTypeID As Integer) As Boolean
        Dim oFulfillmentPlan As New Productfulfillmentplan
        If oFulfillmentPlan.LoadByPrimaryKey(vFulfillmentPlanID) = False Then
            Exit Function
        End If
        If (vNewSourceTypeID <> SourceType.RLBL) AndAlso _
            (oFulfillmentPlan.Fulfillmenttypeid = SourceType.RLBL) Then
            If MsgBox("Changing Fulfillment type will delete all the relabel instructions for this product. Do you want to continue?", _
                      MsgBoxStyle.YesNo, _
                      "Delete relabel instruction - Confirm") = MsgBoxResult.No Then
                Exit Function
            End If
            deleteProductRelabelInstructionsByFulfillmentPlanID(vFulfillmentPlanID)
        ElseIf (vNewSourceTypeID = SourceType.RLBL) AndAlso _
            (oFulfillmentPlan.Fulfillmenttypeid <> SourceType.RLBL) Then
            copyProductRelableInstruction(vFulfillmentPlanID)
        End If
        Return True
    End Function

    Public Sub copyProductRelableInstruction(vFulfillmentPlanID As Integer)
        If vFulfillmentPlanID <= 0 Then
            Exit Sub
        End If
        Dim oProductRelabelInstruction As Productrelabelinstruction
        Dim oRelabelinstructions As New RelabelinstructionCollection
        oRelabelinstructions.LoadAll()
        For Each oRelabelinstruction As Relabelinstruction In oRelabelinstructions
            oProductRelabelInstruction = New Productrelabelinstruction
            oProductRelabelInstruction.AddNew()
            oProductRelabelInstruction.Fulfillmentplanid = vFulfillmentPlanID
            oProductRelabelInstruction.Sequence = oRelabelinstruction.Sequence
            oProductRelabelInstruction.Relabelinstruction = oRelabelinstruction.Relabelinstruction
            oProductRelabelInstruction.Createdtime = Now
            oProductRelabelInstruction.Createdby = vCurrentUserLogin
            oProductRelabelInstruction.Save()
        Next
    End Sub

    Public Function getProductRelabelInstructions(vProductId As Integer, vAssociatedProductId As Integer) As ViewProductRelabelInstructionCollection
        Dim oProductRelabelInstructions As New ViewProductRelabelInstructionCollection
        oProductRelabelInstructions.Query.Where(oProductRelabelInstructions.Query.Productid.Equal(vProductId), _
                                                oProductRelabelInstructions.Query.Associatedproductid.Equal(vAssociatedProductId))
        oProductRelabelInstructions.Query.Load()
        oProductRelabelInstructions.Sort = "SEQUENCE ASC"
        Return oProductRelabelInstructions
    End Function

    Public Function checkProductRelabelInsSequenceExists(ByVal vFulfillmentPlanID As Integer, vSequence As Integer, vProductrelabelinstructionnumber As Integer) As Boolean
        Dim oProductRelabelInstructions As New ProductrelabelinstructionCollection
        oProductRelabelInstructions.Query.Where(oProductRelabelInstructions.Query.Fulfillmentplanid.Equal(vFulfillmentPlanID), _
                                                oProductRelabelInstructions.Query.Productrelabelinstructionnumber.NotEqual(vProductrelabelinstructionnumber), _
                                                oProductRelabelInstructions.Query.Sequence.Equal(vSequence))
        If oProductRelabelInstructions.Query.Load() Then
            Return True
        End If
        Return False
    End Function

    Public Function checkRelabelInstructionSequenceExists(vSequence As Integer, vRelabelinstructionnumber As Integer) As Boolean
        Dim oRelabelInstructions As New RelabelinstructionCollection
        oRelabelInstructions.Query.Where(oRelabelInstructions.Query.Relabelinstructionnumber.NotEqual(vRelabelinstructionnumber),
                                                oRelabelInstructions.Query.Sequence.Equal(vSequence))
        If oRelabelInstructions.Query.Load() Then
            Return True
        End If
        Return False
    End Function

    Public Function getRelabelInstructions(vSequence As Integer) As RelabelinstructionCollection
        Dim oRelabelInstructions As New RelabelinstructionCollection
        oRelabelInstructions.Query.Where(oRelabelInstructions.Query.Sequence.GreaterThanOrEqual(vSequence))
        oRelabelInstructions.Query.Load()
        oRelabelInstructions.Sort = "SEQUENCE ASC"
        Return oRelabelInstructions
    End Function

    Public Sub updateRelabelInstructionSequence(Optional vSequence As Integer = 0)
        Dim oRelabelInstructions As RelabelinstructionCollection = getRelabelInstructions(vSequence)
        For Each oRelabelInstruction As Relabelinstruction In oRelabelInstructions
            vSequence = vSequence + 1
            oRelabelInstruction.Sequence = vSequence
        Next
        oRelabelInstructions.Save()
    End Sub

    Public Sub updateRelabelInstruction(vRelabelInstructionNumber As Integer, vRelabelInstruction As String)
        Dim oRelabelInstruction As New Relabelinstruction
        If oRelabelInstruction.LoadByPrimaryKey(vRelabelInstructionNumber) = False Then
            Exit Sub
        End If
        oRelabelInstruction.Relabelinstruction = vRelabelInstruction
        oRelabelInstruction.Save()
    End Sub

    Public Function getProductRelabelInstructionsBySeq(vFulfillmentPlanID As Integer, vSequence As Integer) As ProductrelabelinstructionCollection
        Dim oProductRelabelInstructions As New ProductrelabelinstructionCollection
        oProductRelabelInstructions.Query.Where(oProductRelabelInstructions.Query.Fulfillmentplanid.Equal(vFulfillmentPlanID), _
                                                oProductRelabelInstructions.Query.Sequence.GreaterThanOrEqual(vSequence))
        oProductRelabelInstructions.Query.Load()
        oProductRelabelInstructions.Sort = "SEQUENCE ASC"
        Return oProductRelabelInstructions
    End Function

    Public Sub updateProductRelabelInstructionSequence(vFulfillmentPlanID As Integer, Optional vSequence As Integer = 0)
        Dim oProductRelabelInstructions As ProductrelabelinstructionCollection = getProductRelabelInstructionsBySeq(vFulfillmentPlanID, _
                                                                                                                    vSequence)
        For Each oRelabelInstruction As Productrelabelinstruction In oProductRelabelInstructions
            vSequence = vSequence + 1
            oRelabelInstruction.Sequence = vSequence
        Next
        oProductRelabelInstructions.Save()
    End Sub

    Public Function insertRelabelInstruction(vSequence As Integer) As Relabelinstruction
        If vSequence > 0 Then
            updateRelabelInstructionSequence(vSequence)
        End If

        Dim oRelabelInstruction As New Relabelinstruction
        oRelabelInstruction.AddNew()
        oRelabelInstruction.Sequence = IIf(vSequence > 0, vSequence, getRelabelInstructionMaxSequence() + 1)
        oRelabelInstruction.Save()

        Return oRelabelInstruction
    End Function

    Public Function insertProductRelabelInstruction(vFulfillmentPlanID As Integer, vSequence As Integer) As Productrelabelinstruction
        If vSequence > 0 Then
            updateProductRelabelInstructionSequence(vFulfillmentPlanID, vSequence)
        End If

        Dim oProductRelabelInstruction As New Productrelabelinstruction
        oProductRelabelInstruction.AddNew()
        oProductRelabelInstruction.Fulfillmentplanid = vFulfillmentPlanID
        oProductRelabelInstruction.Sequence = IIf(vSequence > 0, _
                                                  vSequence, _
                                                  getProductRelabelInstructionMaxSequence(vFulfillmentPlanID) + 1)
        oProductRelabelInstruction.Createdby = vCurrentUserLogin
        oProductRelabelInstruction.Createdtime = Now
        oProductRelabelInstruction.Save()

        Return oProductrelabelinstruction
    End Function

    Public Sub updateProductRelabelInstruction(vProductRelabelInstructionNumber As Integer, vProductRelabelInstruction As String)
        Dim oProductRelabelInstruction As New Productrelabelinstruction
        If oProductRelabelInstruction.LoadByPrimaryKey(vProductRelabelInstructionNumber) = False Then
            Exit Sub
        End If
        oProductRelabelInstruction.Relabelinstruction = vProductRelabelInstruction
        oProductRelabelInstruction.Save()
    End Sub

    Public Sub updateProductStatus(vProductID As Integer, vStatus As String)
        If IsDBNull(vProductID) Or vProductID = Nothing Then
            Exit Sub
        End If
        If IsDBNull(vStatus) Or vStatus = Nothing Then
            Exit Sub
        End If

        If MsgBox("Are you sure you want to mark Product " + vProductID.ToString + " as " + vStatus + "?", MsgBoxStyle.YesNo, "Confirm Product Status Change") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim oProduct As New Product
            oProduct.LoadByPrimaryKey(vProductID)
            Select Case vStatus
                Case "ACTIVE"
                    oProduct.Productstatus = "ACTIVE"
                    SetProductStatndardCosts(vProductID, "Product Change - ProdId " & vProductID, "Product Change - ProdId " & vProductID & "[" & vStatus & "]")
                    '                    updateActiveProductRelatedRecords(vProductID)
                    oProduct.Save()
                Case "INACTIVE"
                    oProduct.Productstatus = "INACTIVE"
                    oProduct.Save()
                    updateInactiveProductRelatedRecords(vProductID)
                Case "PENDING"
                    oProduct.Productstatus = "PENDING"
                    oProduct.Save()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Updating Product Status")
            Exit Sub
        End Try
    End Sub


    Public Sub updateInactiveProductRelatedRecords(vProductID As Integer)
        If IsDBNull(vProductID) Or vProductID = Nothing Then
            Exit Sub
        End If

        'APIS - search for any APIS records that are not already ARCHIVED 
        Dim oAPISList As New ApisCollection
        oAPISList.Query.Where(oAPISList.Query.Productid.Equal(vProductID), oAPISList.Query.Apisstatus.NotEqual("ARCHIVED"))
        If oAPISList.Query.Load Then
            'found one or more APIS records for the selected ProductID that need to be ARCHIVED
            For Each oApis As Apis In oAPISList
                markAPISStatus(oApis.Apisnum, "ARCHIVED")
            Next
        End If

        'PRICE LIST - search for any PRICE LIST records that are linked to the PRODUCTID and mark them as INACTIVE
        Dim oPriceLists As New PricelistCollection
        oPriceLists.Query.Where(oPriceLists.Query.Productid.Equal(vProductID), oPriceLists.Query.Priceliststatus.NotEqual("INACTIVE"))
        If oPriceLists.Query.Load Then
            Dim vCustList As String = Nothing
            For Each oPriceList As Pricelist In oPriceLists
                Dim oCust As New Customer
                oCust.LoadByPrimaryKey(oPriceList.Custid)
                If vCustList = Nothing Then
                    vCustList = vCustList + oCust.Custname
                Else
                    vCustList = vCustList + ", " + oCust.Custname
                End If
            Next
            MsgBox("Price List records for Product " + vProductID.ToString + " for the following customers will be marked as INACTIVE: " + vCustList, MsgBoxStyle.Information, "PRICE LIST CHANGES")
            For Each oPriceList As Pricelist In oPriceLists
                oPriceList.Priceliststatus = "INACTIVE"
            Next
            oPriceLists.Save()
        End If


    End Sub


End Module