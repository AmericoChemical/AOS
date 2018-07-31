Imports AOS.BusinessObjects

Public Class frmUpdatePriceListItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vCustomerID As Integer
    Public vPriceListID As Integer
    Public vAddtype As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Price List Item"

    'here is where you dimension your object variables for the form
    Dim oProduct As New Product
    Dim oProducts As New ProductCollection
    Dim oCustomer As New Customer
    Dim oPrice As Pricelist
    Dim oUOMV As New ViewUOMByVolumeCollection
    Dim oUOMW As New ViewUOMByWeightCollection
    Dim oPricingMethod As New ViewPricingMethodCollection
    Dim oStatusCodes As New ListPriceliststatusCollection
    Dim vAuditRuleID As Integer = AuditLogProcessing.cAUDITRULEIDPRODUCTCOSTING
    Dim vFlag As Boolean = False

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vAddtype = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()
        If eChangeDate.EditValue Is Nothing Then
            eChangeDate.EditValue = Today
        End If
    End Sub

    Private Sub loadLookupTables()

        oUOMV.LoadAll()
        bsUOMVolume.DataSource = oUOMV

        oUOMW.LoadAll()
        bsUOMWeight.DataSource = oUOMW

        oPricingMethod.LoadAll()
        bsPricingMethod.DataSource = oPricingMethod

        oStatusCodes.LoadAll()
        bsStatusCodes.DataSource = oStatusCodes

    End Sub

    Private Sub loadData()
        'get customer record
        If vCustomerID = Nothing Then
            MsgBox("There is no Customer ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oCustomer.LoadByPrimaryKey(vCustomerID)
        Me.bsCustomer.DataSource = oCustomer

        If oCustomer.Taxexempt = "1" Then
            TaxableCheckEdit.ReadOnly = True
        End If

        If oCustomer.Isconsignment = False Then
            eConsignment.Properties.ReadOnly = True
        End If

        'get product record
        If vProductID = Nothing Then
            pnlProductSelection.Visible = True
            getProductList()
        Else
            pnlProductSelection.Visible = False
            Me.Size = New Drawing.Size(Me.Size.Width, Me.Size.Height - pnlProductSelection.Size.Height)
            oProduct.LoadByPrimaryKey(vProductID)
        End If
        Me.bsProduct.DataSource = oProduct

        If vAddtype = "ADD" Then
            addNewPrice()
        Else
            editPrice(vPriceListID)
        End If
    End Sub

    Private Sub getProductData(ByVal vProductID As Integer)
        oProduct = New Product
        oProduct.LoadByPrimaryKey(vProductID)
        bsProduct.DataSource = oProduct
    End Sub

    Private Sub getProductList()
        oProducts = New ProductCollection
        oProducts.Query.Where(oProducts.Query.Productstatus.Equal("ACTIVE"))
        oProducts.Query.Load()
        oProducts.Sort = "ProductDesc"
        bsProductList.DataSource = oProducts
    End Sub
    Private Sub addNewPrice()
        oPrice = New Pricelist
        oPrice.Productid = oProduct.Productid
        oPrice.Container = oProduct.Container
        oPrice.Custid = oCustomer.Custid
        oPrice.Effectivedate = Today
        If oCustomer.Taxexempt = "1" Then
            oPrice.Taxable = 0
        Else
            oPrice.Taxable = 1
        End If
        oPrice.Unitorcontainer = "U"
        oPrice.Volumeunits = 0
        oPrice.Volumeprice = 0
        oPrice.Weightunits = 0
        oPrice.Weightprice = 0
        oPrice.Priceliststatus = "ACTIVE"
        oPrice.Save()
        Me.bsPrice.DataSource = oPrice
    End Sub

    Private Sub editPrice(ByVal vPriceListID As Integer)
        If vPriceListID = Nothing Then
            MsgBox("There is no Price List ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oPrice = New Pricelist
        oPrice.LoadByPrimaryKey(vPriceListID)
        Me.bsPrice.DataSource = oPrice
    End Sub

    Private Function changesSaved() As Boolean
        CalculateContainerValue()
        'oPrice.Containerprice = oPrice.Units * oPrice.Unitprice
        oPrice.Save()
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bsPrice.CancelEdit()
        Try
            If vAddtype = "ADD" Then
                oPrice.MarkAsDeleted()
                oPrice.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click



        bsPrice.EndEdit()
        oPrice.EndEdit()

        If validateSave() = False Then
            Exit Sub
        End If

        If RaiseAuditEvent(vAuditRuleID, bsPrice, Nothing, vFlag, oProduct) Then
            Exit Sub
        End If

        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub
    Private Function CheckforDuplicate() As Boolean
        Dim returnValue As Boolean = False
        Dim oPriceList As New PricelistCollection
        oPriceList.Query.Where(oPriceList.Query.Custid.Equal(vCustomerID), oPriceList.Query.Productid.Equal(oPrice.Productid))
        oPriceList.Query.Load()
        If oPriceList.Count > 1 Then
            returnValue = True
        End If
        Return returnValue
    End Function

    Sub SetFocustoFirstNullFieldinPricingMethod()
        If String.IsNullOrEmpty(VolumeunitsSpinEdit.Text) Or Val(VolumeunitsSpinEdit.Text.ToString()) = 0 Then
            VolumeunitsSpinEdit.Focus()
        ElseIf String.IsNullOrEmpty(VolumeuomLookUpEdit.Text) Then
            VolumeuomLookUpEdit.Focus()
        ElseIf String.IsNullOrEmpty(VolumeTextPrice.Text) Or Val(VolumeTextPrice.Text.ToString()) = 0 Then
            VolumeTextPrice.Focus()
        ElseIf String.IsNullOrEmpty(WeightunitsTextEdit.Text) Or Val(WeightunitsTextEdit.Text.ToString()) = 0 Then
            WeightunitsTextEdit.Focus()
        ElseIf String.IsNullOrEmpty(WeightuomLookUpEdit.Text) Then
            WeightuomLookUpEdit.Focus()
        ElseIf String.IsNullOrEmpty(WeightTextPrice.Text) Or Val(WeightTextPrice.Text.ToString()) = 0 Then
            WeightTextPrice.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub eProductLookup_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eProductLookup.EditValueChanged
        If IsDBNull(eProductLookup.EditValue) Then
            Exit Sub
        End If
        getProductData(eProductLookup.EditValue)
        If Not oPrice Is Nothing Then
            oPrice.Productid = oProduct.Productid
            oPrice.Container = oProduct.Container
        End If
    End Sub

    Private Function ValidateCost() As Boolean
        'Check whether pricing data has some values
        If (Me.bsPrice.Current.VOLUMEPRICE > 0 Or _
            Me.bsPrice.Current.WEIGHTPRICE > 0 Or _
            Me.bsPrice.Current.VOLUMEUNITS > 0 Or _
            Me.bsPrice.Current.WEIGHTUNITS > 0 Or _
            Not String.IsNullOrEmpty(Me.VolumeuomLookUpEdit.Text) Or _
            Not String.IsNullOrEmpty(Me.WeightuomLookUpEdit.Text)) Then

            If (Me.bsPrice.Current.VOLUMEPRICE = 0 Or _
                Me.bsPrice.Current.WEIGHTPRICE = 0 Or _
                Me.bsPrice.Current.VOLUMEUNITS = 0 Or _
                Me.bsPrice.Current.WEIGHTUNITS = 0 Or _
                String.IsNullOrEmpty(Me.VolumeuomLookUpEdit.Text) Or _
                String.IsNullOrEmpty(Me.WeightuomLookUpEdit.Text)) Then
                Return False
            End If
        Else
            Return False
        End If
        Return True
    End Function

    Private Sub PricingMethodLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles PricingMethodLookUpEdit.EditValueChanged
        
    End Sub

    Private Sub CalculateContainerValue()

        oPrice.Units = Nothing
        oPrice.Containerprice = Nothing
        Select Case PricingMethodLookUpEdit.Text
            Case PricingMethod.VOLUME.ToString()
                oPrice.Containerprice = oPrice.Volumeunits * oPrice.Volumeprice
                oPrice.Units = oPrice.Volumeunits
            Case PricingMethod.WEIGHT.ToString()
                oPrice.Containerprice = oPrice.Weightunits * oPrice.Weightprice
                oPrice.Units = oPrice.Weightunits
            Case Else
                oPrice.Containerprice = 0
                oPrice.Units = 0
        End Select
        If Not IsDBNull(PricingMethodLookUpEdit.EditValue) Then
            oPrice.Pricingmethod = PricingMethodLookUpEdit.EditValue
        End If
        oPrice.EndEdit()
        oPrice.Save()
        Me.bsPrice.DataSource = oPrice
        bsPrice.ResetBindings(False)
    End Sub

    Private Sub btnRecalcVolumeCost_Click(sender As Object, e As EventArgs) Handles btnRecalcVolumeCost.Click
        If IsInitializing = False Then
            AuditCheckPriceForLowPrice(WeightTextPrice, PricingMethod.WEIGHT, VolumeunitsSpinEdit, VolumeTextPrice, WeightunitsTextEdit, WeightTextPrice, bsPrice, vAuditRuleID, vFlag, CalledFrom.PRICELIST, oProduct)
            CalculateContainerValue()
        End If
    End Sub

    Private Sub btnRecalcWeightCost_Click(sender As Object, e As EventArgs) Handles btnRecalcWeightCost.Click
        If IsInitializing = False Then
            AuditCheckPriceForLowPrice(VolumeTextPrice, PricingMethod.VOLUME, VolumeunitsSpinEdit, VolumeTextPrice, WeightunitsTextEdit, WeightTextPrice, bsPrice, vAuditRuleID, vFlag, CalledFrom.PRICELIST, oProduct)
            CalculateContainerValue()
        End If
    End Sub

    Private Sub PricingMethodLookUpEdit_Properties_EditValueChanged(sender As Object, e As EventArgs) Handles PricingMethodLookUpEdit.Properties.EditValueChanged
        If IsInitializing = False Then
            If Not String.IsNullOrEmpty(PricingMethodLookUpEdit.Text) Then
                CalculateContainerValue()
            End If
        End If
    End Sub

    Public Function validateSave() As Boolean
        If oPrice.Productid Is Nothing Then
            MsgBox("You must first select a product before saving the price list record.", MsgBoxStyle.Critical, "Error - No Product Selected")
            Return False
        End If

        If oPrice.Pricingmethod Is Nothing Then
            MsgBox("Pricing method is required.", MsgBoxStyle.Critical, "Error - No Pricing Method Selected")
            PricingMethodLookUpEdit.Focus()
            Return False
        End If

        If oPrice.Priceliststatus Is Nothing Then
            MsgBox("Status is required.", MsgBoxStyle.Critical, "Error - No Status Selected")
            eStatus.Focus()
            Return False
        End If

        If vAddtype = "ADD" Then
            If CheckforDuplicate() Then
                Dim msg As String = "Price already exists for product {0}, customer {1}. You must change the Product ID."
                'If Not String.IsNullOrEmpty(eChangeDate.Text) Then
                '    MsgBox(String.Format(msg, eProductLookup.Text, TextEdit1.Text, eChangeDate.Text), MsgBoxStyle.Critical)
                'Else
                '    MsgBox(String.Format(msg, eProductLookup.Text, TextEdit1.Text, "NULL"), MsgBoxStyle.Critical)
                'End If
                MsgBox(String.Format(msg, eProductLookup.Text, TextEdit1.Text), MsgBoxStyle.Critical)
                Return False
            End If
        End If

        'Check UNITS for Pricing and Product Standard Costing
        If oPrice.Volumeunits <> oProduct.Volumeunits Then
            If MsgBox("The VOLUME Units for the Price List are different than the VOLUME Units for the Product Standard Cost. Do you want to continue?", MsgBoxStyle.YesNo, "Confirm SAVE Action") = MsgBoxResult.No Then
                Return False
            End If
        End If

        If oPrice.Weightunits <> oProduct.Weightunits Then
            If MsgBox("The WEIGHT Units for the Price List are different than the WEIGHT Units for the Product Standard Cost. Do you want to continue?", MsgBoxStyle.YesNo, "Confirm SAVE Action") = MsgBoxResult.No Then
                Return False
            End If
        End If



        If ValidateCost() = False Then
            If MsgBox("Partial pricing data is entered. Do you want to continue?", vbYesNo + vbQuestion) = vbNo Then
                SetFocustoFirstNullFieldinPricingMethod()
                Return False
            End If
        End If
        Return True
    End Function

End Class