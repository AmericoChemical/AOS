
Module AppUtilities

#Region "UTILITIES"

    Public Function DelimiterCheck(ByVal InString As String) As String
        Dim strNewString As String = ""
        Dim strThisCharacter As String = ""
        Dim intPosition As Integer
        For intPosition = 1 To Len(InString)
            strThisCharacter = Mid(InString, intPosition, 1)
            If strThisCharacter <> "'" Then
                strNewString = strNewString & strThisCharacter
            Else
                strNewString = strNewString & "''"
            End If
        Next
        Return strNewString
    End Function

    Public Sub playMediaFile(ByVal mediaFileName As String)
        My.Computer.Audio.Play(mediaFileName, AudioPlayMode.WaitToComplete)
    End Sub


    ' Use this method if you want to automaically open
    ' the created file in the default program.
    Public Sub StartProcess(ByVal path As String)
        Dim process As New Process()
        Try
            process.StartInfo.FileName = path
            process.Start()
            process.WaitForInputIdle()
        Catch
        End Try
    End Sub

    Public Function isActiveProduct(vProdID As Integer) As Boolean

        Dim oWorkOrderItems As New WorkorderitemCollection
        If oWorkOrderItems.Load(oWorkOrderItems.Query.Where(oWorkOrderItems.Query.Productid = vProdID)) Then
            Return True
        End If

        Dim oInvItems As New InvitemCollection
        If oInvItems.Load(oInvItems.Query.Where(oInvItems.Query.Productid = vProdID)) Then
            Return True
        End If

        Dim oInvoiceItems As New InvoiceitemCollection
        If oInvoiceItems.Load(oInvoiceItems.Query.Where(oInvItems.Query.Productid = vProdID)) Then
            Return True
        End If

        Dim oShipmentitem As New ShipmentitemCollection
        If oShipmentitem.Load(oShipmentitem.Query.Where(oShipmentitem.Query.Productid = vProdID)) Then
            Return True
        End If

        Dim oPOitem As New PoitemCollection
        If oPOitem.Load(oPOitem.Query.Where(oPOitem.Query.Productid = vProdID)) Then
            Return True
        End If


        Dim oReceiveritem As New ReceiveritemCollection
        If oReceiveritem.Load(oReceiveritem.Query.Where(oReceiveritem.Query.Productid = vProdID)) Then
            Return True
        End If


        Dim oLoadItems As New LoaditemCollection
        If oLoadItems.Load(oLoadItems.Query.Where(oLoadItems.Query.ItemID = vProdID)) Then
            Return True
        End If

        Dim oReLabelOrderItems As New RelabelorderitemCollection
        If oReLabelOrderItems.Load(oReLabelOrderItems.Query.Where(oReLabelOrderItems.Query.Itemid = vProdID)) Then
            Return True
        End If

        Dim oPurchaseItem As New PurchaseitemCollection
        If oPurchaseItem.Load(oPurchaseItem.Query.Where(oPurchaseItem.Query.Itemid = vProdID)) Then
            Return True
        End If


        Dim oApis As New ApisCollection
        If oApis.Load(oApis.Query.Where(oApis.Query.Productid = vProdID)) Then
            Return True
        End If



        'ProdId/itemId not found in 
        'Dim oProdItems As New ProditemCollection
        'If oProdItems.Load(oProdItems.Query.Where(oProdItems.Query.Productid = vProdID)) Then
        '    Return True
        'End If

        ' ProductID Found in 
        ' STDCOSTS
        ' LABOR
        ' MATARIAL - CostingProductId
        ' MATERIALPRODUCT
        'COMMISSIONREVIEW
        'PRICELIST
        'APISCosts
        ' ProdVendList
        ' ProdChemicalLink
        'INVOICEHISTORYITEM
        'PRODUCTFULFILLMENTPLAN - PRODUCTID/ASSOCIATEDPRODUCTID
        'PRODUCTCOST
        'PRODUCTRESV
        'RECEIVINGEVENT



        Return False
    End Function



#End Region

#Region "GET USER INPUT"

    Public Function getUserDate(ByVal vPrompt As String) As Date
        Dim frm As New frmGetDataItem
        frm.vPrompt = vPrompt
        frm.vInputType = "DATE"
        frm.ShowDialog()
        Return frm.vDate
    End Function

    Public Function getUserDateAllowNull(ByVal vPrompt As String) As Date?
        Dim frm As New frmGetDataItem
        frm.vPrompt = vPrompt
        frm.vInputType = "DATE"
        frm.ShowDialog()
        If frm.vDate Is Nothing Then
            Return CDate("01/01/1980")
        Else
            Return frm.vDate
        End If
    End Function

    Public Function getUserString(ByVal vPrompt As String, Optional vStringDefault As String = "") As String
        Dim frm As New frmGetDataItem
        frm.vPrompt = vPrompt
        frm.vInputType = "STRING"
        frm.vString = vStringDefault
        frm.ShowDialog()
        Return frm.vString
    End Function

    Public Function getUserInteger(vPrompt As String, Optional vNumberDefault As Integer = 0) As Integer
        Dim frm As New frmGetDataItem
        frm.vPrompt = vPrompt
        frm.vInputType = "INTEGER"
        frm.vString = vNumberDefault
        frm.ShowDialog()
        Return frm.vInteger
    End Function
    Public Function getUserDecimal(vPrompt As String, Optional vDecimalDefault As Decimal = 0.00) As Decimal
        Dim frm As New frmGetDataItem
        frm.vPrompt = vPrompt
        frm.vInputType = "DECIMAL"
        frm.vString = vDecimalDefault
        frm.ShowDialog()
        Return frm.vDecimal
    End Function

    Public Function getStatusValue(vType As String) As String
        Dim frm As New frmGetStatusValue
        frm.vType = vType
        frm.ShowDialog()
        Return frm.vStatusValue
    End Function

#End Region

#Region "Helper Methods"

    Public Sub showFormDynamically(vForm As String)
        Dim obj As Object = Activator.CreateInstance(Type.GetType("AOS." + vForm))
        obj.ShowDialog()
    End Sub

#End Region

    Public Function formatDate(vDate As DateTime?) As String
        If vDate Is Nothing Then
            Return ""
        End If
        Return Format(vDate, "MM/dd/yyyy")
    End Function

End Module
