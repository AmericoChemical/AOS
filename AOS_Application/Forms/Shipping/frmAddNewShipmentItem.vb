Imports AOS.BusinessObjects

Public Class frmAddNewShipmentItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)

    Public vShipmentNum As Integer
    Public vShipmentItemNumber As Integer
    Public vCustomerPO As String
    Public vCustomerName As String
    Public vCustID As Integer
    Public vShipmentDate As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Shipped Item"

    'here is where you dimension your object variables for the form
    Dim oItem As Shipmentdetail
    Dim oProducts As ProductCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadProducts()
        loadData()
    End Sub

    Private Sub loadProducts()
        oProducts = New ProductCollection
        oProducts.LoadAll()
        oProducts.Sort = "ProductID"
        bsProducts.DataSource = oProducts
    End Sub

    Private Function getCustomerInfo(vCustID As Integer) As String
        Dim oCust As New Customer
        If oCust.LoadByPrimaryKey(vCustID) Then
            Return oCust.Custname
        Else
            Return ""
        End If
    End Function

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vShipmentItemNumber)
        End If
        rTxtShipmentNumber.Caption = oItem.Shipmentnumber & " - " & vShipmentDate
        rtxtPurchaseOrder.Caption = vCustomerPO
        rTxtCustomerName.Caption = getCustomerInfo(vCustID)
        setItemType(IIf(IsDBNull(oItem.Itemtype), "P", oItem.Itemtype))
    End Sub

    Private Sub addNewObject()
        oItem = New Shipmentdetail
        oItem.AddNew()
        oItem.Shipmentnumber = vShipmentNum
        oItem.Itemtype = "P"
        oItem.Save()
        vShipmentItemNumber = oItem.Shipmentdetailid
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Me.Close()
            Exit Sub
        End If
        oItem = New Shipmentdetail
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
        If Not IsDBNull(oItem.Container) Then
            eTareWgt.Text = getTareWeight(oItem.Container)
        Else
            eTareWgt.Text = Nothing
        End If
    End Sub

    Private Sub setItemType(vType As String)
        Select Case vType
            Case "P"
                rbP.Checked = True
                Me.pProductScreen.Visible = True
                Me.pMiscScreen.Visible = False
                Me.pEmptyReturns.Visible = False
                Me.pSamples.Visible = False
            Case "E"
                rbE.Checked = True
                Me.pProductScreen.Visible = False
                Me.pMiscScreen.Visible = False
                Me.pEmptyReturns.Visible = True
                Me.pSamples.Visible = False
            Case "M"
                rbM.Checked = True
                Me.pProductScreen.Visible = False
                Me.pMiscScreen.Visible = True
                Me.pEmptyReturns.Visible = False
                Me.pSamples.Visible = False
            Case "S"
                rbS.Checked = True
                Me.pProductScreen.Visible = False
                Me.pMiscScreen.Visible = False
                Me.pEmptyReturns.Visible = False
                Me.pSamples.Visible = True
            Case Else
        End Select
        oItem.Itemtype = vType
        oItem.Save()
        updateShipmentItem(vType)
    End Sub

    Private Sub eProductID_EditValueChanged(sender As Object, e As System.EventArgs) Handles eProductID.EditValueChanged
        updateShipmentItem("P")
    End Sub

    Private Sub eEmptyProductID_EditValueChanged(sender As Object, e As System.EventArgs) Handles luEmptyProductID.EditValueChanged
        updateShipmentItem("E")
    End Sub

    Private Sub luSampleProductID_EditValueChanged(sender As Object, e As System.EventArgs) Handles luSampleProductID.EditValueChanged
        updateShipmentItem("S")
    End Sub

    Private Function getTareWeight(vContainer As String) As Integer
        If oItem.Itemtype = "S" Then
            Return 0
        End If
        If vContainer Is Nothing Or IsDBNull(vContainer) Or vContainer = "" Then
            Return 0
        End If
        Dim oContainer As New Container
        Try
            oContainer.LoadByPrimaryKey(vContainer)
            Return oContainer.TareWeight
        Catch ex As Exception
            MsgBox("Error retrieving container tare weight", MsgBoxStyle.Critical, "Error")
            Return 0
        End Try
    End Function

    Private Sub updateShipmentItem(vType As String)

        Dim vStr As String

        'save all changes to current Shipment Item
        bsItem.EndEdit()
        oItem.EndEdit()
        oItem.Save()

        'pull current shipment item record to memory for editing
        Dim oRec As New Shipmentdetail
        Try
            If Not oRec.LoadByPrimaryKey(vShipmentItemNumber) Then
                MsgBox("There was an error in updating the Shipment Item", MsgBoxStyle.Critical, "Error")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Select Case oItem.Itemtype
            Case "P"
                If Not IsDBNull(eProductID.EditValue) And Not eProductID.EditValue Is Nothing Then
                    'Get Product record to update shipment item information
                    Dim oProduct As New Product
                    Try
                        oProduct.LoadByPrimaryKey(eProductID.EditValue)
                    Catch ex As Exception
                        MsgBox("Could not locate selected Product data", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End Try
                    Try
                        oRec.Productid = oProduct.Productid
                        oRec.Productdesc = oProduct.Productdesc
                        oRec.Stdweight = oProduct.Stdweight
                        oRec.Stdgallons = oProduct.Stdgallons
                        oRec.Container = oProduct.Container
                        oRec.Dotdesc = oProduct.Dotdesc
                        oRec.Hazmatdesc = oProduct.Hazmatdesc
                        oRec.Unline = oProduct.Unline
                        oRec.Classrate = oProduct.Classrate
                        oRec.Ld1 = oProduct.Dotdesc & " " & oProduct.Hazmatdesc
                        oRec.Ld2 = oProduct.Unline
                        'oProduct.Container & "/" & oProduct.Stdweight.ToString & " LB. " & Trim(oProduct.Productdesc) & " - " & oProduct.Units.ToString & " " & oProduct.Uom
                        'vStr = oProduct.Container & "/" & oProduct.Stdweight.ToString & " LB. " & Trim(oProduct.Productdesc) & " - " & oProduct.Stdgallons.ToString & " gal."
                        vStr = oProduct.Container & "/" & oProduct.Stdweight.ToString & " LB. " & Trim(oProduct.Productdesc) & " - " & oProduct.Units.ToString & " " & oProduct.Uom
                        If vCustomerPO <> "" Then
                            vStr = vStr & " (PO# " & vCustomerPO & ")"
                        End If
                        oRec.Ld3 = vStr
                        If IsDBNull(oRec.Qtycontainers) Or oRec.Qtycontainers <= 0 Then
                            oRec.Qtycontainers = 0
                        End If
                        If IsDBNull(oRec.Stdweight) Or oRec.Stdweight <= 0 Then
                            oRec.Stdweight = 0
                        End If
                        If IsDBNull(oProduct.Container) Or oProduct.Container = Nothing Then
                            oRec.Totalweight = 0
                        Else
                            oRec.Totalweight = getTotalWeight(IIf(IsDBNull(oProduct.Container), "", oProduct.Container), CInt(oRec.Qtycontainers), IIf(IsDBNull(oProduct.Stdweight), 0, oProduct.Stdweight))
                        End If
                        oRec.Itemtype = "P"
                        oRec.Save()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox("Error updating Shipment Detail record", MsgBoxStyle.Critical, "Error")
                    End Try
                Else
                    oRec.Itemtype = "P"
                    oRec.Save()
                End If
            Case "E"
                If Not IsDBNull(luEmptyProductID.EditValue) And Not luEmptyProductID Is Nothing Then
                    'Get Product record to update shipment item information
                    Dim oProduct As New Product
                    Try
                        oProduct.LoadByPrimaryKey(luEmptyProductID.EditValue)
                    Catch ex As Exception
                        MsgBox("Could not locate selected Product data", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End Try
                    Try
                        oRec.Productid = oProduct.Productid
                        oRec.Productdesc = "LAST CONTAINED: " & oProduct.Productdesc
                        oRec.Stdweight = 0
                        oRec.Stdgallons = 0
                        oRec.Container = oProduct.Container
                        oRec.Dotdesc = oProduct.Dotdesc
                        oRec.Hazmatdesc = oProduct.Hazmatdesc
                        oRec.Unline = oProduct.Unline
                        oRec.Classrate = oProduct.Classrate
                        oRec.Ld1 = oProduct.Dotdesc & " " & oProduct.Hazmatdesc
                        oRec.Ld2 = oProduct.Unline
                        vStr = "EMPTY " & oProduct.Container & "/ " & IIf(IsDBNull(getTareWeight(oProduct.Container)), 0, getTareWeight(oProduct.Container)).ToString & " LB / LAST CONTAINED: " & Trim(oProduct.Productdesc) & " - " & oProduct.Stdgallons.ToString & " GAL"
                        If vCustomerPO <> "" Then
                            vStr = vStr & "(PO# " & vCustomerPO & ")"
                        End If
                        oRec.Ld3 = vStr
                        oRec.Ld3 = vStr
                        If IsDBNull(oRec.Qtycontainers) Or oRec.Qtycontainers <= 0 Then
                            oRec.Qtycontainers = 0
                        End If
                        If IsDBNull(oRec.Stdweight) Or oRec.Stdweight <= 0 Then
                            oRec.Stdweight = 0
                        End If
                        oRec.Totalweight = (CInt(eEmptyQty.EditValue) * IIf(IsDBNull(getTareWeight(oProduct.Container)), 0, getTareWeight(oProduct.Container)))
                        oRec.Itemtype = "E"
                        oRec.Save()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox("Error updating Shipment Detail record", MsgBoxStyle.Critical, "Error")
                    End Try
                Else
                    oRec.Itemtype = "E"
                    oRec.Save()
                End If
            Case "S"
                If Not IsDBNull(luSampleProductID.EditValue) And Not luSampleProductID Is Nothing Then
                    'Get Product record to update shipment item information
                    Dim oProduct As New Product
                    Try
                        oProduct.LoadByPrimaryKey(luEmptyProductID.EditValue)
                    Catch ex As Exception
                        MsgBox("Could not locate selected Product data", MsgBoxStyle.Critical, "Error")
                        Exit Sub
                    End Try
                    Try
                        oRec.Productid = oProduct.Productid
                        oRec.Productdesc = "SAMPLE: " & oProduct.Productdesc
                        oRec.Stdweight = 0
                        oRec.Stdgallons = 0
                        oRec.Dotdesc = oProduct.Dotdesc
                        oRec.Hazmatdesc = oProduct.Hazmatdesc
                        oRec.Unline = oProduct.Unline
                        oRec.Classrate = oProduct.Classrate
                        oRec.Ld1 = oProduct.Dotdesc & " " & oProduct.Hazmatdesc
                        oRec.Ld2 = oProduct.Unline
                        vStr = "SAMPLE / " & Trim(oProduct.Productdesc) & " / " & oRec.Container
                        If vCustomerPO <> "" Then
                            vStr = vStr & "(PO# " & vCustomerPO & ")"
                        End If
                        oRec.Ld3 = vStr
                        oRec.Totalweight = IIf(IsDBNull(sTotalWeight.EditValue), 0, sTotalWeight.EditValue)
                        oRec.Itemtype = "S"
                        oRec.Save()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        MsgBox("Error updating Shipment Detail record", MsgBoxStyle.Critical, "Error")
                    End Try
                Else
                    oRec.Itemtype = "S"
                    oRec.Save()
                End If
            Case "M"
                If vEditType = "ADD" Then
                    Try
                        oRec.Productid = 0
                        oRec.Productdesc = IIf(IsDBNull(mProductDesc.EditValue), "", mProductDesc.EditValue)
                        oRec.Stdweight = 0
                        oRec.Stdgallons = 0
                        oRec.Container = ""
                        oRec.Dotdesc = ""
                        oRec.Hazmatdesc = ""
                        oRec.Unline = ""
                        oRec.Classrate = ""
                        oRec.Ld1 = ""
                        oRec.Ld2 = ""
                        oRec.Ld3 = Trim(IIf(IsDBNull(mProductDesc.EditValue), "", mProductDesc.EditValue))
                        oRec.Qtycontainers = IIf(IsDBNull(mQty.EditValue), 0, mQty.EditValue)
                        oRec.Totalweight = IIf(IsDBNull(mTotalWeight.EditValue), 0, mTotalWeight.EditValue)
                        oRec.Itemtype = "M"
                        oRec.Save()
                    Catch ex As Exception
                        MsgBox("Error updating Shipment Detail record", MsgBoxStyle.Critical, "Error")
                    End Try
                End If

            Case Else
                Exit Sub
        End Select

        'reload shipment item record
        editObject(vShipmentItemNumber)


        'Select Case vType
        '    Case "P"
        '        If IsDBNull(eProductID.EditValue) Then
        '            Exit Sub
        '        End If

        '        'determine if ProductID has been selected
        '        If eProductID.EditValue <= 0 Then
        '            'ProductID not selected - clear out all fields related to product
        '            Dim oRec As New Shipmentdetail
        '            Try
        '                If Not oRec.LoadByPrimaryKey(vShipmentItemNumber) Then
        '                    Exit Sub
        '                End If
        '                oRec.Productid = Nothing
        '                oRec.Productdesc = ""
        '                oRec.Stdweight = 0
        '                oRec.Stdgallons = 0
        '                oRec.Container = ""
        '                oRec.Dotdesc = ""
        '                oRec.Hazmatdesc = ""
        '                oRec.Unline = ""
        '                oRec.Classrate = ""
        '                oRec.Ld1 = ""
        '                oRec.Ld2 = ""
        '                oRec.Ld3 = ""
        '                oRec.Qtycontainers = mQty.EditValue
        '                oRec.Totalweight = 0
        '                oRec.Itemtype = "P"
        '                oRec.Save()
        '            Catch ex As Exception
        '                MsgBox("Error updating Shipment Detail record", MsgBoxStyle.Critical, "Error")
        '            End Try
        '        Else
        '            'ProductID selected - get product record to update Shipment Item record
        '            Dim oProduct As New Product
        '            Try
        '                oProduct.LoadByPrimaryKey(eProductID.EditValue)
        '            Catch ex As Exception
        '                MsgBox("Could not locate selected Product data", MsgBoxStyle.Critical, "Error")
        '                Exit Sub
        '            End Try

        '            'get database record for current Shipment Item so we can update it directly and then reload it to the screen
        '            Dim oRec As New Shipmentdetail
        '            Try
        '                If Not oRec.LoadByPrimaryKey(vShipmentItemNumber) Then
        '                    Exit Sub
        '                End If
        '                oRec.Productid = oProduct.Productid
        '                oRec.Productdesc = oProduct.Productdesc
        '                oRec.Stdweight = oProduct.Stdweight
        '                oRec.Stdgallons = oProduct.Stdgallons
        '                oRec.Container = oProduct.Container
        '                oRec.Dotdesc = oProduct.Dotdesc
        '                oRec.Hazmatdesc = oProduct.Hazmatdesc
        '                oRec.Unline = oProduct.Unline
        '                oRec.Classrate = oProduct.Classrate
        '                oRec.Ld1 = oProduct.Dotdesc & " " & oProduct.Hazmatdesc
        '                oRec.Ld2 = oProduct.Unline
        '                vStr = oProduct.Container & "/" & oProduct.Stdweight.ToString & " LB. " & Trim(oProduct.Productdesc) & " - " & oProduct.Stdgallons.ToString & " gal."
        '                If vCustomerPO <> "" Then
        '                    vStr = vStr & "(PO# " & vCustomerPO & ")"
        '                End If
        '                oRec.Ld3 = vStr
        '                If IsDBNull(eQty.EditValue) Or eQty.EditValue <= 0 Then
        '                    eQty.EditValue = 0
        '                End If
        '                oRec.Qtycontainers = eQty.EditValue
        '                oRec.Totalweight = getTotalWeight(oProduct.Container, CInt(eQty.EditValue), oProduct.Stdweight)
        '                oRec.Itemtype = "P"
        '                oRec.Save()
        '            Catch ex As Exception
        '                MsgBox(ex.Message)
        '                MsgBox("Error updating Shipment Detail record", MsgBoxStyle.Critical, "Error")
        '            End Try
        '        End If

        '    Case "M"
        '        'get database record for current Shipment Item so we can update it directly and then reload it to the screen
        '        Dim oRec As New Shipmentdetail
        '        Try
        '            If Not oRec.LoadByPrimaryKey(vShipmentItemNumber) Then
        '                Exit Sub
        '            End If
        '            oRec.Productid = 0
        '            oRec.Productdesc = mProductDesc.EditValue
        '            oRec.Stdweight = 0
        '            oRec.Stdgallons = 0
        '            oRec.Container = ""
        '            oRec.Dotdesc = ""
        '            oRec.Hazmatdesc = ""
        '            oRec.Unline = ""
        '            oRec.Classrate = ""
        '            oRec.Ld1 = ""
        '            oRec.Ld2 = ""
        '            oRec.Ld3 = Trim(mProductDesc.EditValue)
        '            oRec.Qtycontainers = IIf(IsDBNull(mQty.EditValue), 0, mQty.EditValue)
        '            oRec.Totalweight = IIf(IsDBNull(mTotalWeight.EditValue), 0, mTotalWeight.EditValue)
        '            oRec.Itemtype = "M"
        '            oRec.Save()
        '        Catch ex As Exception
        '            MsgBox("Error updating Shipment Detail record", MsgBoxStyle.Critical, "Error")
        '        End Try

        '    Case "E"
        '        If IsDBNull(luEmptyProductID.EditValue) Then
        '            Exit Sub
        '        End If

        '        'determine if ProductID has been selected
        '        If luEmptyProductID.EditValue <= 0 Then
        '            'ProductID not selected - clear out all fields related to product
        '            Dim oRec As New Shipmentdetail
        '            Try
        '                If Not oRec.LoadByPrimaryKey(vShipmentItemNumber) Then
        '                    Exit Sub
        '                End If
        '                oRec.Productid = Nothing
        '                oRec.Productdesc = ""
        '                oRec.Stdweight = 0
        '                oRec.Stdgallons = 0
        '                oRec.Container = ""
        '                oRec.Dotdesc = ""
        '                oRec.Hazmatdesc = ""
        '                oRec.Unline = ""
        '                oRec.Classrate = ""
        '                oRec.Ld1 = ""
        '                oRec.Ld2 = ""
        '                oRec.Ld3 = ""
        '                oRec.Qtycontainers = mQty.EditValue
        '                oRec.Totalweight = 0
        '                oRec.Itemtype = "E"
        '                oRec.Save()
        '            Catch ex As Exception
        '                MsgBox("Error updating Shipment Detail record", MsgBoxStyle.Critical, "Error")
        '            End Try
        '        Else
        '            'ProductID selected - get product record to update Shipment Item record
        '            Dim oProduct As New Product
        '            Try
        '                oProduct.LoadByPrimaryKey(luEmptyProductID.EditValue)
        '            Catch ex As Exception
        '                MsgBox("Could not locate selected Product data", MsgBoxStyle.Critical, "Error")
        '                Exit Sub
        '            End Try

        '            'get database record for current Shipment Item so we can update it directly and then reload it to the screen
        '            Dim oRec As New Shipmentdetail
        '            Try
        '                If Not oRec.LoadByPrimaryKey(vShipmentItemNumber) Then
        '                    Exit Sub
        '                End If
        '                oRec.Productid = oProduct.Productid
        '                oRec.Productdesc = "LAST CONTAINED: " & oProduct.Productdesc
        '                oRec.Stdweight = 0
        '                oRec.Stdgallons = 0
        '                oRec.Container = oProduct.Container
        '                oRec.Dotdesc = oProduct.Dotdesc
        '                oRec.Hazmatdesc = oProduct.Hazmatdesc
        '                oRec.Unline = oProduct.Unline
        '                oRec.Classrate = oProduct.Classrate
        '                oRec.Ld1 = oProduct.Dotdesc & " " & oProduct.Hazmatdesc
        '                oRec.Ld2 = oProduct.Unline
        '                vStr = "EMPTY " & oProduct.Container & "/ " & IIf(IsDBNull(getTareWeight(oProduct.Container)), 0, getTareWeight(oProduct.Container)).ToString & " LB / LAST CONTAINED: " & Trim(oProduct.Productdesc) & " - " & oProduct.Stdgallons.ToString & " GAL"
        '                If vCustomerPO <> "" Then
        '                    vStr = vStr & "(PO# " & vCustomerPO & ")"
        '                End If
        '                oRec.Ld3 = vStr
        '                If IsDBNull(eEmptyQty.EditValue) Or eEmptyQty.EditValue <= 0 Then
        '                    eEmptyQty.EditValue = 0
        '                End If
        '                oRec.Qtycontainers = eEmptyQty.EditValue
        '                oRec.Totalweight = (CInt(eEmptyQty.EditValue) * IIf(IsDBNull(getTareWeight(oProduct.Container)), 0, getTareWeight(oProduct.Container)))
        '                oRec.Itemtype = "E"
        '                oRec.Save()
        '            Catch ex As Exception
        '                MsgBox(ex.Message)
        '                MsgBox("Error updating Shipment Detail record", MsgBoxStyle.Critical, "Error")
        '            End Try
        '        End If
        'End Select



    End Sub

    Private Function getTotalWeight(vContainer As String, vQty As Integer, vStdWeight As Integer) As Integer

        Dim vTotalWeight As Integer = 0
        Dim vTareWeight As Integer = 0

        If vQty <= 0 Or IsDBNull(vQty) Then
            'MsgBox("You must enter a qty to calculate total weight of shipment item(s)", MsgBoxStyle.Information, "Missing data")
            Return 0
        End If
        If IsDBNull(vContainer) Or vContainer = Nothing Then
            Return 0
        End If
        If IsDBNull(vStdWeight) Or vStdWeight = Nothing Then
            vStdWeight = 0
        End If

        'get tare weight for product container
        vTareWeight = getTareWeight(vContainer)
        If vTareWeight <= 0 Then
            MsgBox("Tare weight for this container is missing or not correct. Please see you data adminstrator", MsgBoxStyle.Critical, "Error")
            Return 0
        End If
        'do calculations
        vTotalWeight = vQty * (vStdWeight + vTareWeight)
        Return vTotalWeight
    End Function

    Private Sub btnCancel_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        oItem.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSave_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        bsItem.EndEdit()
        oItem.EndEdit()
        If rbP.Checked = True Then
            oItem.Itemtype = "P"
        ElseIf rbE.Checked = True Then
            oItem.Itemtype = "E"
        ElseIf rbM.Checked = True Then
            oItem.Itemtype = "M"
        ElseIf rbS.Checked = True Then
            oItem.Itemtype = "S"
        End If
        oItem.Save()
        updateShipmentItem("")
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub eQty_EditValueChanged(sender As Object, e As System.EventArgs) Handles eQty.EditValueChanged
        If Not eQty.IsModified Then
            Exit Sub
        End If
        If eQty.EditValue Is Nothing Or eQty.EditValue = "" Then
            Exit Sub
        End If

        If IsDBNull(eProductID.EditValue) Then
            Exit Sub
        End If
        If eProductID.EditValue <= 0 Then
            Exit Sub
        End If
        bsItem.Current.TotalWeight = getTotalWeight(bsItem.Current.container, eQty.EditValue, bsItem.Current.StdWeight)
    End Sub

    Private Sub eEmptyQty_EditValueChanged(sender As Object, e As System.EventArgs) Handles eEmptyQty.EditValueChanged
        If Not eEmptyQty.IsModified Then
            Exit Sub
        End If
        If eEmptyQty.EditValue Is Nothing Or eEmptyQty.EditValue = "" Then
            Exit Sub
        End If
        If IsDBNull(luEmptyProductID.EditValue) Then
            Exit Sub
        End If
        If luEmptyProductID.EditValue <= 0 Then
            Exit Sub
        End If
        bsItem.Current.TotalWeight = getTotalWeight(bsItem.Current.container, eEmptyQty.EditValue, bsItem.Current.StdWeight)
    End Sub

    Private Sub rbP_Click(sender As Object, e As System.EventArgs) Handles rbP.Click
        If rbP.Checked = False Then
            setItemType("P")
        End If
    End Sub

    Private Sub rbM_Click(sender As Object, e As System.EventArgs) Handles rbM.Click
        If rbM.Checked = False Then
            setItemType("M")
        End If
    End Sub

    Private Sub rbE_Click(sender As Object, e As System.EventArgs) Handles rbE.Click
        If rbE.Checked = False Then
            setItemType("E")
        End If
    End Sub

    Private Sub rbS_Click(sender As Object, e As System.EventArgs) Handles rbS.Click
        If rbS.Checked = False Then
            setItemType("S")
        End If
    End Sub
End Class