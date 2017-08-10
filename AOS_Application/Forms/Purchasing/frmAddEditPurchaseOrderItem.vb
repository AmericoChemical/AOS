Imports AOS.BusinessObjects
Imports System.Text

Public Class frmAddEditPurchaseOrderItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer           'Purchase Order Item ID value - object primary key (passed in by calling form for edit mode)
    Public vPONum As Integer        'Purchase Order Number - foreign key values (passed in by calling form for add mode)
    Public vEditType As String      'operating mode (passed in by calling form)
    Public vVendorID As Integer     'Vendor ID value 
    Public vMethod As String

    Dim vFlag As Boolean = False
    Dim vFlagSave As Boolean = False
    Dim vLowPriceCustomerName As String = Nothing

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Purchase Order Item"
    Dim vCategory As String = "POItem"

    'here is where you dimension your object variables for the form
    Dim oItem As Poitem
    Dim oProducts As ViewVendorProductListCollection
    Dim oProduct As Product
    Dim oProductCosts As ProductcostCollection
    Dim oProductList As ProductCollection
    Dim oCost As Productcost
    Dim oVendorProductsList As ViewVendorProductListCollection
    Dim oCustomer As New ViewCustomerNameByPriceList
    Dim oUOMV As New ViewUOMByVolumeCollection
    Dim oUOMW As New ViewUOMByWeightCollection
    Dim vAuditLogAuditReason As String = String.Empty

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getProducts("VENDOR")
        loadData()
    End Sub

    Private Sub loadData()

        oUOMV.LoadAll()
        bsUOMVolume.DataSource = oUOMV

        oUOMW.LoadAll()
        bsUOMWeight.DataSource = oUOMW

        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub getProducts(vMethod As String)
        oProducts = New ViewVendorProductListCollection
        Select Case vMethod
            Case "VENDOR"
                oProducts.Query.Where(oProducts.Query.Vendorid.Equal(vVendorID))
            Case "ALL"
                'oProducts.Query.Where()
        End Select
        oProducts.Query.Load()
        oProducts.Sort = "PRODUCTDESC"
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub addNewObject()
        oItem = New Poitem
        oItem.AddNew()
        'assign foreign key values here
        oItem.Ponumber = vPONum
        oItem.Unitorcontainer = "C"
        oItem.Qtyreceived = 0
        oItem.Qtycanceled = 0
        oItem.Qtyreleased = 0
        oItem.Volumeunits = 0
        oItem.Weightunits = 0
        oItem.Volumestandardcost = 0
        oItem.Weightstandardcost = 0
        oItem.EndEdit()
        Me.bsPOItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Poitem
        oItem.LoadByPrimaryKey(vID)
        If oItem.Unitorcontainer Is Nothing Then
            oItem.Unitorcontainer = "C"
            oItem.Save()
        End If
        If oItem.Qtycanceled Is Nothing Then
            oItem.Qtycanceled = 0
        End If
        If oItem.Qtyreceived Is Nothing Then
            oItem.Qtyreceived = 0
        End If
        If oItem.Qtyreleased Is Nothing Then
            oItem.Qtyreleased = 0
        End If
        oItem.Save()
        Me.bsPOItem.DataSource = oItem
    End Sub

    Private Sub calcExtCost()
        bsPOItem.EndEdit()
        'calculate extended financials for item - Unit Cost should already reflect Container cost value if U/C is set to "C"
        bsPOItem.Current.ExtCost = bsPOItem.Current.QtyOrdered * bsPOItem.Current.UnitCost
        bsPOItem.EndEdit()
    End Sub

    Private Function changesSaved() As Boolean
        Try
            calcExtCost()
            oItem.EndEdit()
            oItem.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function


    Private Function changesCancelled() As Boolean
        Try
            bsPOItem.CancelEdit()
            oItem.CancelEdit()
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function


    Private Sub getProductInfo(ByVal vProdID As Integer)
        oProduct = New Product
        If oProduct.LoadByPrimaryKey(vProdID) Then
            eContainer.EditValue = oProduct.Container
            oItem.Productdesc = oProduct.Productdesc
            bsPOItem.EndEdit()
        End If
    End Sub

    Private Sub getProductCostInfo(ByVal vProdID As Integer, ByVal vVendorID As Integer)
        oProductCosts = New ProductcostCollection
        oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdID))
        oProductCosts.Query.Load()
        Select Case oProductCosts.Count
            Case Is = 1
                If oProductCosts(0).Vendorid <> vVendorID Then
                    'the preferred vendor of the product cost record does not match the chosen vendorid for this purchase order
                    'the user must reconcile this - either reject the product or change the preferred vendor id
                    Dim str As String = "The Vendor you have selected for this Purchase Order is not the same Vendor you have recorded as the Preferred Vendor for this product. Do you want to change the Preferred Vendor for this product?"
                    If MsgBox(str, MsgBoxStyle.YesNo, "Vendor Verification") = MsgBoxResult.No Then
                        eUnits.EditValue = oProductCosts(0).Units
                        eUOM.EditValue = oProductCosts(0).Uom
                        eVendorItemNumber.EditValue = oProductCosts(0).Vendoritemkey
                        If eUC.EditValue = "C" Then
                            'calculate Container Cost
                            eCost.EditValue = oProductCosts(0).Unitcost * oProductCosts(0).Units
                        Else
                            'capture Unit Cost
                            eCost.EditValue = oProductCosts(0).Unitcost
                        End If
                        bsPOItem.EndEdit()
                    Else
                        Dim frm As New frmViewProductCostRecords
                        frm.vProductID = vProdID
                        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                            eUnits.EditValue = frm.oCost.Units
                            eUOM.EditValue = frm.oCost.Uom
                            eVendorItemNumber.EditValue = frm.oCost.Vendoritemkey
                            If eUC.EditValue = "C" Then
                                'calculate Container Cost
                                eCost.EditValue = frm.oCost.Unitcost * frm.oCost.Units
                            Else
                                'capture Unit Cost
                                eCost.EditValue = frm.oCost.Unitcost
                            End If
                            bsPOItem.EndEdit()
                        End If
                    End If
                Else
                    eUnits.EditValue = oProductCosts(0).Units
                    eUOM.EditValue = oProductCosts(0).Uom
                    eVendorItemNumber.EditValue = oProductCosts(0).Vendoritemkey
                    If eUC.EditValue = "C" Then
                        'calculate Container Cost
                        eCost.EditValue = oProductCosts(0).Unitcost * oProductCosts(0).Units
                    Else
                        'capture Unit Cost
                        eCost.EditValue = oProductCosts(0).Unitcost
                    End If
                    bsPOItem.EndEdit()
                End If
            Case Else
                Dim frm As New frmViewProductCostRecords
                frm.vProductID = vProdID
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    eUnits.EditValue = frm.oCost.Units
                    eUOM.EditValue = frm.oCost.Uom
                    eVendorItemNumber.EditValue = frm.oCost.Vendoritemkey
                    If eUC.EditValue = "C" Then
                        'calculate Container Cost
                        eCost.EditValue = frm.oCost.Unitcost * frm.oCost.Units
                    Else
                        'capture Unit Cost
                        eCost.EditValue = frm.oCost.Unitcost
                    End If
                    bsPOItem.EndEdit()
                End If
        End Select
    End Sub

    Private Sub eUnitCost_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eCost.ButtonClick
        If IsDBNull(oItem.Productid) Then
            MsgBox("You must select a product first", MsgBoxStyle.Critical, "Error - No product selected")
            Exit Sub
        End If
        Dim frm As New frmViewProductCostRecords
        frm.vProductID = oItem.Productid
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If eUC.EditValue = "C" Then
                'calculate Container Cost
                eCost.EditValue = frm.oCost.Unitcost * frm.oCost.Units
            Else
                'capture Unit Cost
                eCost.EditValue = frm.oCost.Unitcost
            End If
            eUnits.EditValue = frm.oCost.Units
            eUOM.EditValue = frm.oCost.Uom
            eVendorItemNumber.EditValue = frm.oCost.Vendoritemkey
            bsPOItem.EndEdit()
        Else
            MsgBox("no product cost record selected")
        End If
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Dim sMsg As String = String.Format("Cost is more than Price in the price list for Customer {0}. Do you want to continue?", vLowPriceCustomerName)

        vFlagSave = False
        If Not Me.ActiveControl Is Nothing And Not Me.ActiveControl.Parent Is Nothing Then
            If Me.ActiveControl.Parent.Name.ToLower() = "volumeunitsspinedit" Then
                CostValidation(VolumeunitsSpinEdit, PricingMethod.VOLUME.ToString(), False)
            ElseIf Me.ActiveControl.Parent.Name.ToLower() = "volumetextstandardcost" Then
                CostValidation(VolumeTextStandardCost, PricingMethod.VOLUME.ToString(), True)
            ElseIf Me.ActiveControl.Parent.Name.ToLower() = "weightunitstextedit" Then
                CostValidation(WeightunitsTextEdit, PricingMethod.WEIGHT.ToString(), False)
            ElseIf Me.ActiveControl.Parent.Name.ToLower() = "weighttextstandardcost" Then
                CostValidation(WeightTextStandardCost, PricingMethod.WEIGHT.ToString(), True)
            End If
        End If

        If vFlagSave Then
            Exit Sub
        End If

        If ValidatePriceList() Then
            If Not ValidateAllPriceList() Then
                If MsgBox("Partial pricing data is entered. Are you sure you want to continue?", vbYesNo + vbQuestion) = vbNo Then
                    SetFocustoFirstNullFieldinPricingMethod()
                    Exit Sub
                End If
            End If
        End If

        If Not String.IsNullOrEmpty(vLowPriceCustomerName) And Not vFlag Then
            If MsgBox(sMsg, vbYesNo + vbQuestion) = vbNo Then
                SetFocus(VolumeTextStandardCost)
                Exit Sub
            Else
                Using frm As New frmAuditReason()
                    frm.ShowDialog()
                    vAuditLogAuditReason = frm.vAuditReason
                End Using
                vFlag = True
            End If
        End If

        If changesSaved() Then
            If Not String.IsNullOrEmpty(vAuditLogAuditReason) Then
                SaveAuditLogInformation(vCategory, sMsg, "Warning", vID, vAuditLogAuditReason, vLowPriceCustomerName)
            End If
            Me.DialogResult = Windows.Forms.DialogResult.Yes
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


    Private Sub VolumeunitsSpinEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VolumeunitsSpinEdit.Validating
        If IsInitializing = False Then
            Dim Type As String = PricingMethod.VOLUME.ToString()
            If String.IsNullOrEmpty(WeightTextStandardCost.Text) Or Convert.ToDecimal(WeightTextStandardCost.Text) = 0 Then
                VolumeStdCostCalculation()
            Else
                WeightStdCostCalculation()
            End If

            DisplayWarningMsg(VolumeTextStandardCost, Type)
        End If
    End Sub

    Private Sub WeightunitsTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WeightunitsTextEdit.Validating
        If IsInitializing = False Then
            Dim Type As String = PricingMethod.WEIGHT.ToString()
            If String.IsNullOrEmpty(VolumeTextStandardCost.Text) Or Convert.ToDecimal(VolumeTextStandardCost.Text) = 0 Then
                WeightStdCostCalculation()
            Else
                VolumeStdCostCalculation()
            End If
            DisplayWarningMsg(WeightTextStandardCost, Type)

        End If
    End Sub

    Private Sub VolumeuomLookUpEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VolumeuomLookUpEdit.Validating
        If IsInitializing = False Then
            WeightStdCostCalculation()
            Dim Type As String = PricingMethod.VOLUME.ToString()
            DisplayWarningMsg(VolumeTextStandardCost, Type)
        End If
    End Sub

    Private Sub WeightuomLookUpEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WeightuomLookUpEdit.Validating
        If IsInitializing = False Then
            WeightStdCostCalculation()
            Dim Type As String = PricingMethod.WEIGHT.ToString()
            DisplayWarningMsg(WeightTextStandardCost, Type)

        End If
    End Sub

    Private Sub VolumeTextStandardCost_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles VolumeTextStandardCost.Validating
        If IsInitializing = False Then
            VolumeStdCostCalculation()
            Dim Type As String = PricingMethod.VOLUME.ToString()
            If (String.IsNullOrEmpty(Me.VolumeTextStandardCost.Text)) Then
                Return
            End If
            If (Convert.ToDecimal(Me.VolumeTextStandardCost.Text) = 0) Then
                Return
            End If
            DisplayWarningMsg(VolumeTextStandardCost, Type)

        End If
    End Sub

    Private Sub WeightTextStandardCost_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles WeightTextStandardCost.Validating
        If IsInitializing = False Then
            WeightStdCostCalculation()
            Dim Type As String = PricingMethod.WEIGHT.ToString()
            If (String.IsNullOrEmpty(Me.WeightTextStandardCost.Text)) Then
                Return
            End If
            If (Convert.ToDecimal(Me.WeightTextStandardCost.Text) = 0) Then
                Return
            End If

            DisplayWarningMsg(WeightTextStandardCost, Type)

        End If
    End Sub

    Sub SetFocus(ByRef obj As DevExpress.XtraEditors.TextEdit)
        obj.Focus()
    End Sub

    Private Sub VolumeStdCostCalculation()

        If (String.IsNullOrEmpty(Me.VolumeTextStandardCost.Text)) Then
            Return
        End If

        If (String.IsNullOrEmpty(Me.VolumeunitsSpinEdit.Text)) Then
            Return
        End If

        If (String.IsNullOrEmpty(Me.WeightunitsTextEdit.Text)) Or Convert.ToDecimal(Me.WeightunitsTextEdit.Text) = 0 Then
            Return
        End If

        bsPOItem.Current.Weightstandardcost = Math.Round(Convert.ToDecimal(Me.VolumeTextStandardCost.Text) * (Convert.ToDecimal(Me.VolumeunitsSpinEdit.Text) / Convert.ToDecimal(Me.WeightunitsTextEdit.Text)), 4)
    End Sub

    Private Sub WeightStdCostCalculation()

        If (String.IsNullOrEmpty(Me.WeightTextStandardCost.Text)) Then
            Return
        End If

        If (String.IsNullOrEmpty(Me.WeightunitsTextEdit.Text)) Then
            Return
        End If

        If (String.IsNullOrEmpty(Me.VolumeunitsSpinEdit.Text)) Or Convert.ToDecimal(Me.VolumeunitsSpinEdit.Text) = 0 Then
            Return
        End If

        bsPOItem.Current.Volumestandardcost = Math.Round(Convert.ToDecimal(Me.WeightTextStandardCost.Text) * (Convert.ToDecimal(Me.WeightunitsTextEdit.Text) / Convert.ToDecimal(Me.VolumeunitsSpinEdit.Text)), 4)
    End Sub



    ''' <summary>
    ''' Check Price list and return Customer name
    ''' </summary>
    ''' <param name="Type"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckPriceListForLowPrice(Type) As String

        Dim dt As New DataTable()
        Dim CustomerName As String = String.Empty
        Dim sb As New StringBuilder()
        Dim rowCount As Integer = 0

        If ValidatePriceList() Then
            oCustomer = New ViewCustomerNameByPriceList
            If Type = PricingMethod.VOLUME.ToString() Then
                If IsDBNull(VolumeTextStandardCost.Text) Or Convert.ToString(VolumeTextStandardCost.Text) = String.Empty Then
                    Return sb.ToString()
                End If
                oCustomer.Query.Where(oCustomer.Query.Volumeprice.LessThan(Convert.ToDecimal(VolumeTextStandardCost.Text)), oCustomer.Query.Productid.Equal(Convert.ToInt32(eProduct.EditValue)), oCustomer.Query.Volumeuom.Equal(VolumeuomLookUpEdit.Text))
            ElseIf Type = PricingMethod.WEIGHT.ToString() Then
                If IsDBNull(WeightTextStandardCost.Text) Or Convert.ToString(WeightTextStandardCost.Text) = String.Empty Then
                    Return sb.ToString()
                End If
                oCustomer.Query.Where(oCustomer.Query.Weightprice.LessThan(Convert.ToDecimal(WeightTextStandardCost.Text)), oCustomer.Query.Productid.Equal(Convert.ToInt32(eProduct.EditValue)), oCustomer.Query.Weightuom.Equal(WeightuomLookUpEdit.Text))
            End If

            dt = oCustomer.Query.LoadDataTable()

            If dt.Rows.Count() > 0 Then
                For Each dr As DataRow In dt.Rows
                    rowCount += 1
                    sb.Append(Convert.ToString(dr("CUSTNAME"))).Append(IIf(rowCount = dt.Rows.Count, String.Empty, ", "))
                Next
            End If
        End If

        Return sb.ToString()

    End Function

    Private Function ValidatePriceList() As Boolean
        If String.IsNullOrEmpty(eProduct.EditValue.ToString()) Then
            Return False
        End If
        If Not String.IsNullOrEmpty(Me.VolumeTextStandardCost.Text.Trim) And _
          Val(Me.VolumeTextStandardCost.Text.Trim) > 0 Or _
          Not String.IsNullOrEmpty(Me.WeightTextStandardCost.Text.Trim) And _
          Val(Me.WeightTextStandardCost.Text.Trim) > 0 Or _
          Not String.IsNullOrEmpty(Me.VolumeunitsSpinEdit.Text.Trim) And _
          Val(Me.VolumeunitsSpinEdit.Text.Trim) > 0 Or _
          Not String.IsNullOrEmpty(Me.WeightunitsTextEdit.Text.Trim) And _
          Val(Me.WeightunitsTextEdit.Text.Trim) > 0 Or _
          Not String.IsNullOrEmpty(Me.VolumeuomLookUpEdit.Text.Trim) Or _
          Not String.IsNullOrEmpty(Me.WeightuomLookUpEdit.Text.Trim) Then

            If eProduct.EditValue > 0 Then
                Return True
            Else
                Return False
            End If

        Else
            Return False
        End If
    End Function

    Private Function ValidateAllPriceList() As Boolean
        If Not String.IsNullOrEmpty(Me.VolumeTextStandardCost.Text.Trim) And _
          Val(Me.VolumeTextStandardCost.Text.Trim) > 0 And _
          Not String.IsNullOrEmpty(Me.WeightTextStandardCost.Text.Trim) And _
          Val(Me.WeightTextStandardCost.Text.Trim) > 0 And _
          Not String.IsNullOrEmpty(Me.VolumeunitsSpinEdit.Text.Trim) And _
          Val(Me.VolumeunitsSpinEdit.Text.Trim) > 0 And _
          Not String.IsNullOrEmpty(Me.WeightunitsTextEdit.Text.Trim) And _
          Val(Me.WeightunitsTextEdit.Text.Trim) > 0 And _
          Not String.IsNullOrEmpty(Me.VolumeuomLookUpEdit.Text.Trim) And _
          Not String.IsNullOrEmpty(Me.WeightuomLookUpEdit.Text.Trim) Then
            Return True
        Else
            Return False
        End If
    End Function


    Sub SetFocustoFirstNullFieldinPricingMethod()
        If String.IsNullOrEmpty(VolumeunitsSpinEdit.Text) Or Val(VolumeunitsSpinEdit.Text.ToString()) = 0 Then
            SetFocus(VolumeunitsSpinEdit)
        ElseIf String.IsNullOrEmpty(VolumeuomLookUpEdit.Text) Then
            SetFocus(VolumeuomLookUpEdit)
        ElseIf String.IsNullOrEmpty(VolumeTextStandardCost.Text) Or Val(VolumeTextStandardCost.Text.ToString()) = 0 Then
            SetFocus(VolumeTextStandardCost)
        ElseIf String.IsNullOrEmpty(WeightunitsTextEdit.Text) Or Val(WeightunitsTextEdit.Text.ToString()) = 0 Then
            SetFocus(WeightunitsTextEdit)
        ElseIf String.IsNullOrEmpty(WeightuomLookUpEdit.Text) Then
            SetFocus(WeightuomLookUpEdit)
        ElseIf String.IsNullOrEmpty(WeightTextStandardCost.Text) Or Val(WeightTextStandardCost.Text.ToString()) = 0 Then
            SetFocus(WeightTextStandardCost)
        End If
    End Sub

    Private Sub eProduct_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles eProduct.Validating
        If eProduct.EditValue Is Nothing Then
            Exit Sub
        End If
        If IsDBNull(sender.EditValue) Then
            Exit Sub
        End If
        getProductInfo(sender.editValue)
        getProductCostInfo(sender.editvalue, vVendorID)
        CheckPriceListForLowPrice(PricingMethod.VOLUME.ToString())
        CheckPriceListForLowPrice(PricingMethod.WEIGHT.ToString())
    End Sub

    Private Sub CostValidation(ByRef txtBox As DevExpress.XtraEditors.TextEdit, vType As String, vCostValidation As Boolean)
        If IsInitializing = False Then

            If (vCostValidation) Then
                If (String.IsNullOrEmpty(txtBox.Text)) Then
                    Return
                End If
                If (Convert.ToDecimal(txtBox.Text) = 0) Then
                    Return
                End If
            End If

            Dim CustomerName As String = CheckPriceListForLowPrice(vType)
            Dim sMsg As String = String.Format("Cost is more than Price in the price list for Customer {0}. Do you want to continue?", CustomerName)
            If Not String.IsNullOrEmpty(CustomerName) And Not vFlag Then
                vLowPriceCustomerName = CustomerName

                If MsgBox(sMsg, vbYesNo + vbQuestion) = vbNo Then
                    vFlagSave = True
                    txtBox.Focus()
                Else
                    vFlag = True
                End If
            End If

        End If
    End Sub


    Private Sub DisplayWarningMsg(ByRef obj As DevExpress.XtraEditors.TextEdit, ByVal Type As String)
        Dim vCustomerName As String = CheckPriceListForLowPrice(Type)
        Dim vMsg As String = String.Format("Cost is more than Price in the price list for Customer {0}. Do you want to continue?", vCustomerName)
        If Not String.IsNullOrEmpty(vCustomerName) And Not vFlag Then
            vLowPriceCustomerName = vCustomerName

            If MsgBox(vMsg, vbYesNo + vbQuestion) = vbNo Then
                SetFocus(obj)
            Else
                Using frm As New frmAuditReason()
                    frm.ShowDialog()
                    vAuditLogAuditReason = frm.vAuditReason
                End Using
                If String.IsNullOrEmpty(vAuditLogAuditReason) Then
                    vFlag = False
                    SetFocus(obj)
                Else
                    vFlag = True
                End If
            End If
        End If
    End Sub

End Class