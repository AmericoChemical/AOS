Imports AOS.BusinessObjects
Module MaterialProcessing

    Public Function getunAvailableMaterial() As ViewRMAvailableCollection
        Dim oMaterialPlanningList As New ViewRMAvailableCollection
        oMaterialPlanningList.Query.Where(oMaterialPlanningList.Query.RmAvailable.LessThan(0))
        oMaterialPlanningList.Query.Load()
        Return oMaterialPlanningList
    End Function

    Public Function getAvailableInventoryItemsByMaterialID(ByVal vMatID As Integer) As ViewMaterialProductAvailableInventoryItemsCollection
        Dim oLoadAvailableInventory As New ViewMaterialProductAvailableInventoryItemsCollection
        oLoadAvailableInventory.Query.Where(oLoadAvailableInventory.Query.Materialid.Equal(vMatID))
        oLoadAvailableInventory.Query.Load()
        Return oLoadAvailableInventory
    End Function

    Public Function getAvailableInventoryItemsByMaterialIDForMaterialNeeds(vMatID As Integer) As ViewMaterialProductsFullAvailableForMaterialNeedsCollection
        Dim oAvailableInventory As New ViewMaterialProductsFullAvailableForMaterialNeedsCollection
        oAvailableInventory.Query.Where(oAvailableInventory.Query.Materialid.Equal(vMatID))
        oAvailableInventory.Query.Load()
        Return oAvailableInventory
    End Function


    Public Function getProdcutionOrdersByMaterialID(ByVal vMatID As Integer) As ViewProdcutionOrder2Collection
        Dim oLoadProductionOrder As New ViewProdcutionOrder2Collection
        oLoadProductionOrder.Query.Where(oLoadProductionOrder.Query.Materialid.Equal(vMatID))
        oLoadProductionOrder.Sort = "NEEDEDBY DESC"
        oLoadProductionOrder.Query.Load()
        Return oLoadProductionOrder
    End Function

    Public Function getPurchaseProductsByMaterialID(ByVal vMatID As Integer) As ViewPurchaseProductsListCollection
        Dim oPurchaseProducts As New ViewPurchaseProductsListCollection
        oPurchaseProducts.Query.Where(oPurchaseProducts.Query.Materialid.Equal(vMatID), oPurchaseProducts.Query.Priority.NotEqual(0))
        oPurchaseProducts.Query.Load()
        Return oPurchaseProducts
    End Function

    Public Function getMaterialproduct(ByVal vMatID As Integer) As ViewMaterialProductInfoCollection
        Dim oMaterialProductInfo As New ViewMaterialProductInfoCollection
        oMaterialProductInfo.Query.Where(oMaterialProductInfo.Query.Materialid.Equal(vMatID), oMaterialProductInfo.Query.Priority.NotEqual(0))
        oMaterialProductInfo.LoadAll()
        oMaterialProductInfo.Sort = "PRODUCTID DESC"
        Return oMaterialProductInfo
    End Function

    ''' <summary>
    ''' Get Material Product By Product Id.
    ''' </summary>
    ''' <param name="vProductID"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getMaterialProductByProduct(ByVal vProductID As Integer) As Materialproduct
        Dim oMaterialProducts As New MaterialproductCollection
        oMaterialProducts.Query.Where(oMaterialProducts.Query.Productid.Equal(vProductID), _
                                      oMaterialProducts.Query.Priority.NotEqual(0))
        oMaterialProducts.Query.Load()

        If (oMaterialProducts.Query.Load()) Then
            Return oMaterialProducts(0)
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Returns the total available by Product.
    ''' </summary>
    ''' <param name="vProductId"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAvailableRawMaterial(vProductId As Integer) As Decimal
        Dim vAVailable As Decimal = 0

        Dim oMaterialProduct As Materialproduct = getMaterialProductByProduct(vProductId)

        If (Not oMaterialProduct Is Nothing) Then
            Dim oRawMaterial As New ViewRawMaterialAvailability
            oRawMaterial.Query.Where(oRawMaterial.Query.Materialid.Equal(oMaterialProduct.Materialid))
            oRawMaterial.Query.Load()

            vAVailable = oRawMaterial.Available
        End If

        Return vAVailable
    End Function

    ''' <summary>
    ''' Returns the total available by Material Product.
    ''' </summary>
    ''' <param name="vMaterialProduct"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getAvailableQty(vMaterialProduct As Materialproduct) As Decimal
        Dim vAVailable As Decimal = 0

        If (Not vMaterialProduct Is Nothing) Then
            Dim oRawMaterial As New ViewRawMaterialAvailability
            oRawMaterial.Query.Where(oRawMaterial.Query.Materialid.Equal(vMaterialProduct.Materialid))
            oRawMaterial.Query.Load()

            vAVailable = oRawMaterial.Available
        End If

        Return vAVailable
    End Function

    Public Sub markAPISStatus(vAPISNum As Integer, vStatus As String)
        Dim vProductID As Integer = 0

        Select Case vStatus

            Case "ACTIVE"

                'first, get ProductID linked to the current APIS record by instantiating a reference to current APIS record
                Dim oAPISNew As New Apis

                If Not oAPISNew.LoadByPrimaryKey(vAPISNum) Then
                    MsgBox("Serious Error retrieving APIS Record", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                vProductID = oAPISNew.Productid

                'now pull all APIS records linked to the same productID
                Dim oAPISList As New ApisCollection
                oAPISList = getAPISByProductID(oAPISNew.Productid)
                'change all other APIS records for same productID to inactive
                If Not oAPISList Is Nothing Then
                    For Each oAPISRec As Apis In oAPISList
                        Select Case oAPISRec.Apisnum
                            Case Is = vAPISNum
                                oAPISRec.Apisstatus = "ACTIVE"
                                oAPISRec.Isactive = 1
                                markMaterialStatusFromAPISStatus(vAPISNum, "ACTIVE")
                            Case Else
                                If oAPISRec.Apisstatus <> "SINGLE USE" Then
                                    oAPISRec.Apisstatus = "ARCHIVED"
                                    markMaterialStatusFromAPISStatus(oAPISRec.Apisnum, "ARCHIVED")
                                End If
                                oAPISRec.Isactive = 0
                        End Select
                    Next
                    oAPISList.Save()
                End If

            Case "SINGLE USE"
                Dim oAPISNew As New Apis
                If Not oAPISNew.LoadByPrimaryKey(vAPISNum) Then
                    MsgBox("Serious Error retrieving APIS Record", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                vProductID = oAPISNew.Productid

                oAPISNew.Apisstatus = "SINGLE USE"
                oAPISNew.Save()
                markMaterialStatusFromAPISStatus(vAPISNum, "ACTIVE")

            Case "ARCHIVED"
                Dim oAPISNew As New Apis
                If Not oAPISNew.LoadByPrimaryKey(vAPISNum) Then
                    MsgBox("Serious Error retrieving APIS Record", MsgBoxStyle.Critical, "Error")
                    Exit Sub
                End If
                vProductID = oAPISNew.Productid

                oAPISNew.Apisstatus = "ARCHIVED"
                oAPISNew.Save()
                markMaterialStatusFromAPISStatus(vAPISNum, "ARCHIVED")

        End Select
        If vProductID <> 0 Then
            SetProductStatndardCosts(vProductID, "APIS Change. PROD ID-" & vProductID, "APIS Change-Apisstatus. PROD ID" & vProductID)
        End If
    End Sub

    Public Sub markMaterialStatusFromAPISStatus(vAPISNum As Integer, vStatus As String)

        If IsDBNull(vAPISNum) Or vAPISNum <= 0 Then
            Exit Sub
        End If

        If IsDBNull(vStatus) Or vStatus = Nothing Then
            Exit Sub
        End If

        'get APIS record
        Dim vAPIS As New Apis
        If Not vAPIS.LoadByPrimaryKey(vAPISNum) Then
            Exit Sub
        End If

        'get APIS Material Records
        Dim vMatRecs As New ApisitemCollection
        vMatRecs.Query.Where(vMatRecs.Query.Apisnum.Equal(vAPISNum))
        If Not vMatRecs.Query.Load Then
            Exit Sub
        End If

        If vMatRecs.Count <= 0 Then
            Exit Sub
        End If

        'for each APIS Material Record, set status of Material
        For Each vMat As Apisitem In vMatRecs
            'get Material Record, set status
            Dim oMat As New Material
            If oMat.LoadByPrimaryKey(vMat.Materialid) Then
                Select Case vStatus   'this is the status of the APIS itself that is being updated.
                    Case "ACTIVE"
                        oMat.Materialstatus = "ACTIVE"
                        oMat.Save()
                    Case "ARCHIVED"
                        'first check to see if the Material is part of any other APIS. If it is, do not mark as ARCHIVED.
                        Dim oAPISList As New ViewAPISMaterialStatusCollection
                        oAPISList.Query.Where(oAPISList.Query.Materialid.Equal(vMat.Materialid), oAPISList.Query.Apisstatus.NotEqual("ARCHIVED"))
                        If oAPISList.Query.Load Then
                            'there are more than one APIS that uses this material - DO NOT UPDATE Material Status - leave ACTIVE
                            'Dim vstr As String = "There are ACTIVE APIS records for MatID " + oMat.Materialid.ToString + " - " + oMat.Materialdesc + ". This material will NOT be archived."
                            'MsgBox(vstr, MsgBoxStyle.Information, "FYI")
                        Else
                            'mark the material status as ARCHIVED
                            oMat.Materialstatus = "ARCHIVED"
                            oMat.Save()
                        End If
                    Case "SINGLE USE ONLY"
                        oMat.Materialstatus = "ACTIVE"
                        oMat.Save()
                    Case Else
                End Select
            End If
        Next

    End Sub
End Module
