Imports AOS.BusinessObjects

Public Class frmAddEditInvoiceItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (InvoiceItemNumber) (passed in by calling form for edit mode)
    Public vFKID As Integer     'foreign key values (InvoiceNumber) (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vCustID As Integer   'Customer ID from Invoice to which you are adding/editing item
    Public vTaxExempt As Boolean  'Customer may be marked in database as tax exempt, if so, Taxable control should be invisible

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Invoice Item"

    'here is where you dimension your object variables for the form
    Dim oItem As Invoiceitem
    Dim oProducts As ProductCollection
    Dim oProductCosts As ProductcostCollection
    Dim oPricelist As Pricelist
    Dim oPrices As PricelistCollection
    Dim oProduct As Product = Nothing
    Dim oContainer As Container = Nothing


    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If vTaxExempt Then
            Me.LabelControl1.Visible = False
            Me.eTaxable.Visible = False
        End If
        getProducts()
        loadData()
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProducts.LoadAll()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub addNewObject()
        oItem = New Invoiceitem
        oItem.AddNew()
        'assign foreign key values here
        oItem.Invoicenumber = vFKID
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Invoiceitem
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function changesSaved() As Boolean
        Try
            oItem.Productdesc = eProduct.Text
            bsItem.EndEdit()
            setItemTotals()
            bsItem.EndEdit()
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
            bsItem.CancelEdit()
            oItem.CancelEdit()
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub eProduct_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eProduct.EditValueChanged
        If eProduct.EditValue Is Nothing Then
            Exit Sub
        End If
        getProductInfo(sender.editValue)
        getProductCostInfo(sender.editvalue)
        getPricingInfo(sender.editvalue, vCustID)
    End Sub

    Private Sub getProductInfo(ByVal vProdID As Integer)
        oProduct = New Product
        If oProduct.LoadByPrimaryKey(vProdID) Then
            eContainer.EditValue = oProduct.Container
            bsItem.EndEdit()
        End If
    End Sub

    Private Sub getProductCostInfo(ByVal vProdID As Integer)
        oProductCosts = New ProductcostCollection
        oProductCosts.Query.Where(oProductCosts.Query.Productid.Equal(vProdID))
        oProductCosts.Query.Load()
        Select Case oProductCosts.Count
            Case Is = 1
                eUnits.EditValue = oProductCosts(0).Units
                eUOM.EditValue = oProductCosts(0).Uom
                eUnitCost.EditValue = oProductCosts(0).Unitcost
                bsItem.EndEdit()
            Case Else
                Dim frm As New frmViewProductCostRecords
                frm.vProductID = vProdID
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    eUnits.EditValue = frm.oCost.Units
                    eUOM.EditValue = frm.oCost.Uom
                    eUnitCost.EditValue = frm.oCost.Unitcost
                    bsItem.EndEdit()
                End If
        End Select
    End Sub

    Private Sub getPricingInfo(ByVal vProdID As Integer, ByVal vCustID As Integer)

        Dim vPriceID As Integer

        oPrices = New PricelistCollection
        oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdID), oPrices.Query.Custid.Equal(vCustID))
        oPrices.Query.Load()
        Select Case oPrices.Count
            Case Is = 1
                vPriceID = oPrices(0).Pricelistid
            Case Else
                Dim frm As New frmViewPriceListRecords
                frm.vProductID = vProdID
                frm.vCustomerID = vCustID
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    vPriceID = frm.oPrice.Pricelistid
                End If
        End Select

        If vPriceID = 0 Then
            MsgBox("No pricing records found.", MsgBoxStyle.Information, "No Pricing Records")
            Exit Sub
        End If

        'fetch pricing object
        oPriceList = New Pricelist
        If Not oPricelist.LoadByPrimaryKey(vPriceID) Then
            MsgBox("No Pricing Records were retrieved", MsgBoxStyle.Critical, "Error - No Pricing Records")
            Exit Sub
        End If

        'we have now isolated the pricing record we want
        'now set all relate invoice item data fields
        eItemPrice.EditValue = oPricelist.Unitprice
        If Not vTaxExempt Then
            eTaxable.EditValue = oPricelist.Taxable
        End If

        eUC.EditValue = oPricelist.Unitorcontainer
        bsItem.EndEdit()
    End Sub

    Private Sub setItemTotals()
        oItem.EndEdit()     'save user's last edits
        oItem.BeginEdit()
        If oItem.Quantity Is Nothing Then
            oItem.Quantity = 0
        End If

        'if the product in the pricelist if priced by container, then you 
        'have to adjust the "itemprice" to reflect the unit price * units in container
        If eUC.EditValue = "C" Then
            oItem.Itemprice = oItem.Itemprice * oItem.Units
            oItem.Unitcost = oItem.Unitcost * oItem.Units
        End If
        bsItem.EndEdit()
        oItem.EndEdit()
        oItem.Extcost = CDbl(oItem.Quantity) * CDbl(oItem.Unitcost)
        oItem.Extprice = CDbl(oItem.Quantity) * CDbl(oItem.Itemprice)
        oItem.Grossprofit = CDbl(oItem.Extprice) - CDbl(oItem.Extcost)
        oItem.EndEdit()
        oItem.Save()
    End Sub

    Private Sub eItemPrice_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eItemPrice.ButtonClick
        If IsDBNull(oItem.Productid) Then
            MsgBox("You must select a product first", MsgBoxStyle.Critical, "Error - No product selected")
            Exit Sub
        End If

        Dim frm As New frmViewPriceListRecords
        frm.vProductID = oItem.Productid
        frm.vCustomerID = vCustID
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            eItemPrice.EditValue = frm.oPrice.Unitprice
            eTaxable.EditValue = frm.oPrice.Taxable
            eUC.EditValue = frm.oPrice.Unitorcontainer
            bsItem.EndEdit()
        Else
            MsgBox("No Price List record selected", MsgBoxStyle.Information, "Price List")
        End If

    End Sub

    Private Sub eUnitCost_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eUnitCost.ButtonClick
        If IsDBNull(oItem.Productid) Then
            MsgBox("You must select a product first", MsgBoxStyle.Critical, "Error - No product selected")
            Exit Sub
        End If
        Dim frm As New frmViewProductCostRecords
        frm.vProductID = oItem.Productid
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            eUnitCost.EditValue = frm.oCost.Unitcost
            eUnits.EditValue = frm.oCost.Units
            eUOM.EditValue = frm.oCost.Uom
            bsItem.EndEdit()
        Else
            MsgBox("no product cost record selected")
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

End Class