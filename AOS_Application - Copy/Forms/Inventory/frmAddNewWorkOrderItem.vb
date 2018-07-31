Imports AOS.BusinessObjects

Public Class frmAddNewWorkOrderItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vWONum As Integer     'foreign key values (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vWorkOrderType As String
    Public vCustID As Integer


    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Work Order Item"

    'here is where you dimension your object variables for the form
    Dim oItem As Workorderitem
    Dim oProducts As ProductCollection
    Dim oProduct As Product
    Dim oContainer As Container
    Dim oPriceList As Pricelist
    Dim oPrices As PricelistCollection
    Dim oProductCosts As ProductcostCollection
    Dim oCost As Productcost

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
        getProducts()
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
        oItem = New Workorderitem
        oItem.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oItem.AddNew()
        'assign foreign key values here
        oItem.Workordernumber = vWONum
        oItem.Billable = True
        oItem.EndEdit()
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Workorderitem
        oItem.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function changesSaved() As Boolean

        Dim vItemQty As Decimal

        Try
            bsItem.EndEdit()

            If bsItem.Current.Unitorcontainer = "C" Then
                vItemQty = bsItem.Current.qty * bsItem.Current.units
            Else
                vItemQty = bsItem.Current.qty
            End If
            Try
                If bsItem.Current.billable = True Then
                    bsItem.Current.ItemProfit = bsItem.Current.ItemPrice - bsItem.Current.UnitCost
                Else
                    bsItem.Current.itemprofit = 0
                End If
                bsItem.EndEdit()
                If bsItem.Current.itemprofit < 0 Then
                    If MsgBox("Are you sure you want to bill this item at a loss", MsgBoxStyle.YesNo, "Confirm - Loss On Sale") = MsgBoxResult.No Then
                        Return False
                    End If
                End If
            Catch ex As Exception
            End Try

            'calculate extended financials for item

            bsItem.Current.ExtPrice = vItemQty * bsItem.Current.ItemPrice
            bsItem.Current.ExtCost = vItemQty * bsItem.Current.UnitCost
            bsItem.Current.ExtProfit = bsItem.Current.extprice - bsItem.Current.extcost

            If vWorkOrderType = "ALLOCATED" Then
                Dim vQty As Integer = bsItem.Current.Qty
                If vQty > 1 Then
                    addMultipleEntries(vQty)
                End If
            End If

            oItem.EndEdit()
            oItem.Save()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Sub addMultipleEntries(ByVal vQty As Integer)
        vQty = vQty - 1     'to avoid adding one too many records, since we already have one
        Dim oItemAdd As Workorderitem
        Dim vItemQty As Integer = 0
        For x As Integer = 1 To vQty
            oItemAdd = New Workorderitem
            oItemAdd.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            oItemAdd.AddNew()
            oItemAdd.Workordernumber = vWONum
            oItemAdd.Productid = oItem.Productid
            oItemAdd.Productdesc = oItem.Productdesc
            oItemAdd.Qty = 1
            oItemAdd.Unitcost = oItem.Unitcost
            oItemAdd.Itemprice = oItem.Itemprice
            oItemAdd.Itemprofit = oItem.Itemprofit
            oItemAdd.Billable = oItem.Billable
            oItemAdd.Unitorcontainer = oItem.Unitorcontainer
            oItemAdd.Units = oItem.Units
            oItemAdd.Uom = oItem.Uom
            If oItemAdd.Unitorcontainer = "C" Then
                vItemQty = oItemAdd.Units
            Else
                vItemQty = 1
            End If
            oItemAdd.Extprice = vItemQty * oItemAdd.Itemprice
            oItemAdd.Extcost = vItemQty * oItemAdd.Unitcost
            oItemAdd.Extprofit = oItemAdd.Extprice - oItemAdd.Extcost

            oItemAdd.Save()
        Next
        oItem.Qty = 1
        oItem.Extprice = vItemQty * oItem.Itemprice
        oItem.Extcost = vItemQty * oItem.Unitcost
        oItem.Extprofit = oItem.Extprice - oItem.Extcost
        oItem.Save()

    End Sub

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
        If IsDBNull(sender.EditValue) Then
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
        oPrices = New PricelistCollection
        oPrices.Query.Where(oPrices.Query.Productid.Equal(vProdID), oPrices.Query.Custid.Equal(vCustID))
        oPrices.Query.Load()
        Select oPrices.Count
            Case Is = 1
                eItemPrice.EditValue = oPrices(0).Unitprice
                bsItem.EndEdit()
            Case Else
                Dim frm As New frmViewPriceListRecords
                frm.vProductID = vProdID
                frm.vCustomerID = vCustID
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    eItemPrice.EditValue = frm.oPrice.Unitprice
                    bsItem.EndEdit()
                End If
        End Select
    End Sub

    Private Sub eItemPrice_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles eItemPrice.ButtonClick
        If IsDBNull(oItem.Productid) Then
            MsgBox("You must select a product first", MsgBoxStyle.Critical, "Error - No product selected")
            Exit Sub
        End If

        'Dim vOpt As String

        'If Not oPriceList Is Nothing Then
        '    If oPriceList.Pricelistid Is Nothing Then
        '        vOpt = "ADD"
        '    Else
        '        vOpt = "EDIT"
        '    End If
        'Else
        '    vOpt = "ADD"
        'End If

        'Dim frm As New frmAddEditPriceListItem_Old
        'frm.vEditType = vOpt
        'If vOpt = "EDIT" Then
        '    frm.vID = oPriceList.Pricelistid
        'Else
        '    frm.vFKID = vCustID
        '    frm.vFKID2 = oItem.Productid
        'End If
        'frm.ShowDialog()

        Dim frm As New frmViewPriceListRecords
        frm.vProductID = oItem.Productid
        frm.vCustomerID = vCustID
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            eItemPrice.EditValue = frm.oPrice.Unitprice
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

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
End Class