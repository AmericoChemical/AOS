Imports AOS.BusinessObjects
Imports System.Text

Public Class frmUpdateProductUnitCost
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vVendorID As Integer
    Public vCostID As Integer
    Public vAddtype As String

    Dim vFlag As Boolean = False

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Product Unit Costing"
    Dim vCategory As String = "ProductCost"

    'here is where you dimension your object variables for the form
    Dim oProduct As New Product
    Dim oVendors As New VendorCollection
    Dim oCustomer As New CustomerCollection
    Dim oCostType As New ListCosttypeCollection
    Dim oCost As New Productcost
    Dim oUOMV As New ViewUOMByVolumeCollection
    Dim oUOMW As New ViewUOMByWeightCollection
    Dim vAuditRuleID As Integer = AuditLogProcessing.cAUDITRULEIDPRICING

    Dim OrigVolCost As Decimal = 0.00
    Dim OrigWgtCost As Decimal = 0.00


    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vAddtype = "NEW" Then
            Me.Text = "Adding New " & vObjectName & " Information"
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()

        OrigVolCost = IIf(IsDBNull(oCost.Volumestandardcost), 0, oCost.Volumestandardcost)
        OrigWgtCost = IIf(IsDBNull(oCost.Weightstandardcost), 0, oCost.Weightstandardcost)

        'eChangeDate.EditValue = Today      'move this to AddObject and EditObject method (only if changes saved)
    End Sub

    Private Sub loadLookupTables()
        oUOMV.LoadAll()
        bsUOMVolume.DataSource = oUOMV

        oUOMW.LoadAll()
        bsUOMWeight.DataSource = oUOMW

        oVendors.LoadAll()
        oVendors.Sort = "VendorName"
        bsVendors.DataSource = oVendors

        oCustomer.LoadAll()
        oCustomer.Sort = "CUSTNAME"
        bsCustomers.DataSource = oCustomer

        oCostType.LoadAll()
        oCostType.Sort = "RecID"
        bsCostType.DataSource = oCostType

        Dim oCostMethod As New ListCostmethodCollection
        oCostMethod.LoadAll()
        bsCostMethod.DataSource = oCostMethod




    End Sub

    Private Sub loadData()

        'get product record
        If vProductID = Nothing Then
            MsgBox("There is no Product ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oProduct.LoadByPrimaryKey(vProductID)
        Me.bs.DataSource = oProduct

        'Check to see if there are any active APIS records for this product, and then prevent updates to Standard Costing from Product Cost records.
        Dim oAPIS As New ApisCollection
        oAPIS.Query.Where(oAPIS.Query.Productid.Equal(vProductID), oAPIS.Query.Apisstatus.Equal("ACTIVE"))
        oAPIS.Query.Load()

        If oAPIS.Count > 0 Then
            'make the UPDATE STANDARD COST button disabled
            rbtnUpdateProductStandardCosts.Enabled = False
        End If

        If vAddtype = "NEW" Then
            addNewCost()
        Else
            editCost(vCostID)
        End If

    End Sub
    Private Sub addNewCost()
        oCost = New Productcost
        oCost.Productid = vProductID
        oCost.Volumeunits = 0
        oCost.Volumestandardcost = 0
        oCost.Weightunits = 0
        oCost.Weightstandardcost = 0
        oCost.Createdtime = Now
        oCost.Createdby = vCurrentUserLogin
        oCost.Modifytime = Now
        oCost.Modifyby = vCurrentUserLogin
        oCost.Isactive = True
        oCost.Isdefaultcostrecord = False
        oCost.Save()
        Me.bsProductCost.DataSource = oCost
    End Sub

    Private Sub editCost(ByVal vCostID As Integer)
        If vCostID = Nothing Then
            MsgBox("There is no Cost Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oCost.LoadByPrimaryKey(vCostID)
        Me.bsProductCost.DataSource = oCost
    End Sub

    Private Function changesSaved() As Boolean
        bsProductCost.EndEdit()


        If oCost.Isactive = False Then
            Dim productCosts As New ProductcostCollection
            productCosts.Query.Where(productCosts.Query.Productid = oCost.Productid And productCosts.Query.Isactive = True And productCosts.Query.Costrecid <> oCost.Costrecid)
            If Not (productCosts.Query.Load() AndAlso productCosts.Count > 0) Then
                MsgBox("Must have atleast one active record")
                Return False
            End If
        End If
        oCost.Save()

        'Dim productCosts As New ProductcostCollection
        'productCosts.Query.Where(productCosts.Query.Productid = oCost.Productid And productCosts.Query.Isactive = True And productCosts.Query.Isdefaultcostrecord = True)
        'If Not (productCosts.Query.Load() AndAlso productCosts.Count > 0) Then
        '    oCost.Isdefaultcostrecord = True
        'End If

        'Dim vVolUnits As Decimal = IIf(IsDBNull(eVolUnits.EditValue) Or eVolUnits.EditValue = Nothing, 0, eVolUnits.EditValue)
        'Dim vVolUOM As String = IIf(eVolUOM.EditValue = Nothing, "", eVolUOM.EditValue)
        'Dim vVolUnitCost As Decimal = IIf(IsDBNull(eVolUnitCost.EditValue) Or eVolUnitCost.EditValue = Nothing, 0, eVolUnitCost.EditValue)
        'Dim vWgtUnits As Decimal = IIf(IsDBNull(eWgtUnits.EditValue) Or eWgtUnits.EditValue = Nothing, 0, eWgtUnits.EditValue)

        Dim vVolUnits As Decimal
        If IsDBNull(eVolUnits.EditValue) Then
            vVolUnits = 0
        Else
            vVolUnits = eVolUnits.EditValue
        End If

        Dim vVolUOM As String
        If IsDBNull(eVolUOM.EditValue) Then
            vVolUOM = ""
        Else
            vVolUOM = eVolUOM.EditValue
        End If

        Dim vVolUnitCost As Decimal
        If IsDBNull(eVolUnitCost.EditValue) Then
            vVolUnitCost = 0
        Else
            vVolUnitCost = eVolUnitCost.EditValue
        End If

        Dim vWgtUnits As Decimal
        If IsDBNull(eWgtUnits.EditValue) Then
            vWgtUnits = 0
        Else
            vWgtUnits = eWgtUnits.EditValue
        End If

        Dim vWgtUOM As String
        If IsDBNull(eWgtUOM.EditValue) Then
            vWgtUOM = ""
        Else
            vWgtUOM = eWgtUOM.EditValue
        End If

        Dim vWgtUnitCost As Decimal
        If IsDBNull(eWgtUnitCost.EditValue) Then
            vWgtUnitCost = 0
        Else
            vWgtUnitCost = eWgtUnitCost.EditValue
        End If


        updateVendorProductCosting(bsProductCost.Current.Costrecid, eCostMethod.EditValue, vVolUnits, vVolUOM, vVolUnitCost, vWgtUnits, vWgtUOM, vWgtUnitCost, eReason.EditValue, bsProductCost.Current.ProductID, eVendor.EditValue, OrigVolCost, OrigWgtCost)

        Dim productCostsDefault As New ProductcostCollection
        productCostsDefault.Query.Where(productCostsDefault.Query.Productid = oCost.Productid And productCostsDefault.Query.Isactive = True And productCostsDefault.Query.Isdefaultcostrecord = True And productCostsDefault.Query.Costrecid <> oCost.Costrecid)
        If Not (productCostsDefault.Query.Load() AndAlso productCostsDefault.Count > 0) Then
            If oCost.Isdefaultcostrecord <> True Then
                MarkVendorProductCostAsDefault(oCost.Costrecid)
            End If
        End If

        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bsProductCost.CancelEdit()
        Try
            If vAddtype = "NEW" Then
                oCost.MarkAsDeleted()
                oCost.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Sub SetFocustoFirstNullFieldinPricingMethod()
        If String.IsNullOrEmpty(eVolUnits.Text) Or Val(eVolUnits.Text.ToString()) = 0 Then
            eVolUnits.Focus()
        ElseIf String.IsNullOrEmpty(eVolUOM.Text) Then
            eVolUOM.Focus()
        ElseIf String.IsNullOrEmpty(eVolUnitCost.Text) Or Val(eVolUnitCost.Text.ToString()) = 0 Then
            eVolUnitCost.Focus()
        ElseIf String.IsNullOrEmpty(eWgtUnits.Text) Or Val(eWgtUnits.Text.ToString()) = 0 Then
            eWgtUnits.Focus()
        ElseIf String.IsNullOrEmpty(eWgtUOM.Text) Then
            eWgtUOM.Focus()
        ElseIf String.IsNullOrEmpty(eWgtUnitCost.Text) Or Val(eWgtUnitCost.Text.ToString()) = 0 Then
            eWgtUnitCost.Focus()
        End If
    End Sub

    Private Function ValidateData()

        If String.IsNullOrEmpty(Me.eCostMethod.Text) Then
            MsgBox("Preferred Cost Method is required.", MsgBoxStyle.Critical, "Error")
            eCostMethod.Focus()
            Return False
        End If

        If IsDBNull(eReason.EditValue) Or eReason.EditValue = Nothing Then
            MsgBox("You must enter a reason for the costing changes.", MsgBoxStyle.Critical, "ERROR - Missing Reason for Change")
            Return False
        End If

        Dim vPartialPriceValidateMessage As String = "Partial pricing data is entered. Do you want to continue?"
        'Check whether pricing data has some values
        If (Me.bsProductCost.Current.VOLUMESTANDARDCOST > 0 Or
            Me.bsProductCost.Current.WEIGHTSTANDARDCOST > 0 Or
            Me.bsProductCost.Current.VOLUMEUNITS > 0 Or
            Me.bsProductCost.Current.WEIGHTUNITS > 0 Or
            Not String.IsNullOrEmpty(Me.eVolUOM.Text) Or
            Not String.IsNullOrEmpty(Me.eWgtUOM.Text)) Then

            'Check if partial pricing data is entered
            If (Me.bsProductCost.Current.VOLUMESTANDARDCOST = 0 Or
                Me.bsProductCost.Current.WEIGHTSTANDARDCOST = 0 Or
                Me.bsProductCost.Current.VOLUMEUNITS = 0 Or
                Me.bsProductCost.Current.WEIGHTUNITS = 0 Or
                String.IsNullOrEmpty(Me.eVolUOM.Text) Or
                String.IsNullOrEmpty(Me.eWgtUOM.Text)) Then
                If MsgBox(vPartialPriceValidateMessage, vbYesNo + vbQuestion) = vbNo Then
                    SetFocustoFirstNullFieldinPricingMethod()
                    Return False
                End If
            End If
        Else
            If MsgBox(vPartialPriceValidateMessage, vbYesNo + vbQuestion) = vbNo Then
                SetFocustoFirstNullFieldinPricingMethod()
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub rbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSave.ItemClick

        If ValidateData() = False Then
            'SetFocustoFirstNullFieldinPricingMethod()
            Exit Sub
        End If



        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub rbtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnRecalcVolumeCost_Click(sender As Object, e As EventArgs) Handles btnRecalcVolumeCost.Click
        If IsInitializing = False Then
            AuditCheckPriceForLowPrice(eWgtUnitCost, PricingMethod.WEIGHT, eVolUnits, eVolUnitCost, eWgtUnits, eWgtUnitCost, bsProductCost, vAuditRuleID, vFlag, CalledFrom.PRODUCTCOST)
        End If
    End Sub

    Private Sub btnRecalcWeightCost_Click(sender As Object, e As EventArgs) Handles btnRecalcWeightCost.Click
        If IsInitializing = False Then
            AuditCheckPriceForLowPrice(eVolUnitCost, PricingMethod.VOLUME, eVolUnits, eVolUnitCost, eWgtUnits, eWgtUnitCost, bsProductCost, vAuditRuleID, vFlag, CalledFrom.PRODUCTCOST)
        End If
    End Sub

    ' This should not execute buttin is invisible by setting group pane  RibbonPageGroup1 invisible
    Private Sub rbtnUpdateProductStandardCosts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUpdateProductStandardCosts.ItemClick
        ' Check for OverRide
        If Costing.getProductStandardCostSource(oProduct.Productid) = "OVERRIDE" Then
            MsgBox("Standard Cost is set to OVERRIDE. Can not update with Vendor Cost", MsgBoxStyle.Critical, "ERROR - Update Not Allowed")
            Exit Sub

        End If

        'check to see if product is a liquid - if so, require a volume units/uom/unitcost
        If oProduct.Isliquid = True Then
            If String.IsNullOrEmpty(Me.eVolUnits.Text) Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Exit Sub
            End If
            If String.IsNullOrEmpty(Me.eVolUnitCost.Text) Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Exit Sub
            End If

            If IsDBNull(eVolUnits.EditValue) Or eVolUnits.EditValue <= 0 Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Exit Sub
            End If
            If String.IsNullOrEmpty(Me.eVolUOM.Text) Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Exit Sub
            End If
            If IsDBNull(eVolUnitCost.EditValue) Or eVolUnitCost.EditValue <= 0 Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Exit Sub
            End If
        End If

        'always require a weight units/uom/unitcost
        If String.IsNullOrEmpty(Me.eWgtUnits.Text) Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Exit Sub
        End If
        If String.IsNullOrEmpty(Me.eWgtUnitCost.Text) Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Exit Sub
        End If
        If IsDBNull(eWgtUnits.EditValue) Or eWgtUnits.EditValue <= 0 Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Exit Sub
        End If
        If String.IsNullOrEmpty(Me.eWgtUOM.Text) Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Exit Sub
        End If
        If IsDBNull(eWgtUnitCost.EditValue) Or eWgtUnitCost.EditValue <= 0 Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Exit Sub
        End If

        If Not IsDBNull(oProduct.Stdweight) Then
            If eWgtUnits.EditValue <> oProduct.Stdweight Then
                If MsgBox("The Label Weight is not the same as the Standard Weight Units. Do want to save anyway?", MsgBoxStyle.YesNo, "Warning!") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If

        If MsgBox("Are you sure you want to UPDATE the existing STANDARD COSTS for this product to the VENDOR PRODUCT COSTS?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        If MsgBox("If you make this change, it cannot be undone. ARE YOU SURE YOU WANT TO CONTINUE?", MsgBoxStyle.YesNo, "CONFIRM REQUEST") = MsgBoxResult.No Then
            Exit Sub
        End If

        bsProductCost.EndEdit()
        oCost.Save()

        Dim vVolUnits As Decimal = 0
        Dim vVolUnitCost As Decimal = 0
        Dim vWgtUnits As Decimal = 0
        Dim vWgtUnitCost As Decimal = 0
        Dim vVolUOM As String
        Dim vWgtUOM As String


        If oCost.Volumeunits Is Nothing Then
            vVolUnits = 0
        Else
            vVolUnits = oCost.Volumeunits
        End If

        If oCost.Weightunits Is Nothing Then
            vWgtUnits = 0
        Else
            vWgtUnits = oCost.Weightunits
        End If

        vVolUnitCost = oCost.Volumestandardcost
        vWgtUnitCost = oCost.Weightstandardcost
        vVolUOM = oCost.Volumeuom
        vWgtUOM = oCost.Weightuom

        updateStandardCostingFromVendorCostChange(oCost.Productid, vVolUnits, vVolUOM, vVolUnitCost, vWgtUnits, vWgtUOM, vWgtUnitCost, "Vendor Cost Updated", "STANDARD COST", oCost.Productid, "VNDR COST CHNG-" & vProductID)

        If RaiseAuditEvent(vAuditRuleID, bsProductCost, PricingMethod.VOLUME, vFlag) Then
            eVolUnitCost.Focus()
            Exit Sub
        ElseIf RaiseAuditEvent(vAuditRuleID, bsProductCost, PricingMethod.WEIGHT, vFlag) Then
            eWgtUnitCost.Focus()
            Exit Sub
        End If


        'updateStandardCostingFromVendorCostChange(oCost.Productid, oCost.Volumeunits, oCost.Volumestandardcost, oCost.Weightunits, oCost.Weightstandardcost, "Vendor Cost Updated", "STANDARD COST", oCost.Productid)

        ''change the standard cost data for the product
        'Dim oProduct As New Product
        'If oProduct.LoadByPrimaryKey(oCost.Productid) Then
        '    'set new values
        '    oProduct.Volumeunits = oCost.Volumeunits
        '    oProduct.Volumestandardcost = oCost.Volumestandardcost
        '    oProduct.Volumeuom = oCost.Volumeuom
        '    oProduct.Weightunits = oCost.Weightunits
        '    oProduct.Weightstandardcost = oCost.Weightstandardcost
        '    oProduct.Weightuom = oCost.Weightuom
        '    oProduct.Save()
        '    MsgBox("Product Standard Costs were successfully updated.", MsgBoxStyle.Information, "Update succeeded")
        'Else
        '    MsgBox("Product Standard Costs update FAILED. Could not locate Product record.", MsgBoxStyle.Critical, "Update FAILED")
        'End If






    End Sub

    Private Sub CheckEditActive_Click(sender As Object, e As EventArgs) Handles CheckEditActive.Click
        If CheckEditActive.Checked Then
            ' when changed tounchecked
            If CheckEditDefault.CheckState Then
                MsgBox("Default vendor cost cannot be set inactive.", MsgBoxStyle.OkOnly)
                CheckEditActive.Checked = True
            End If
        End If
    End Sub



    'Private Sub RecalculateVolumeCost(sender As Object, e As EventArgs) Handles eWgtUnitCost.Leave, eWgtUnits.Leave
    '    If IsInitializing = False Then
    '        AuditCheckPriceForLowPrice(eWgtUnitCost, PricingMethod.WEIGHT, eVolUnits, eVolUnitCost, eWgtUnits, eWgtUnitCost, bsProductCost, vAuditRuleID, vFlag, CalledFrom.PRODUCTCOST)
    '        '            AuditCheckPriceForLowPrice(eVolUnitCost, PricingMethod.VOLUME, eVolUnits, eVolUnitCost, eWgtUnits, eWgtUnitCost, bsProductCost, vAuditRuleID, vFlag, CalledFrom.PRODUCTCOST)

    '    End If
    'End Sub

End Class