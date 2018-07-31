Imports AOS.BusinessObjects

Public Class frmAddEditPurchaseRequest
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key 
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vWorkOrderNum As Integer
    Public vCustomerID As Integer
    Public vProductID As Integer
    Public vMaterialID As Integer
    Public vProdOrderNum As Integer
    Public vQty As Integer
    Public vFrmSource As String
    '  WorkOrder, then limit the ProductID control to only the ProductID value passed to the form by the calling form
    '  MaterialNeed, limit the ProductID control to only ProductID values for which there is a MaterialProduct record for linking MaterialID value passed to form

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Purchase Request"

    'here is where you dimension your object variables for the form
    Dim oItem As PurchaseRequest
    Dim oProducts As ProductCollection
    Dim oCustomers As CustomerCollection
    Dim oVendors As VendorCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
        If vFrmSource = "WorkOrder" Then
            eProductID.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getProducts()
        getCustomers()
        getVendors()
        loadData()
    End Sub

    Private Sub getCustomers()
        oCustomers = New CustomerCollection
        oCustomers.LoadAll()
        oCustomers.Sort = "CUSTNAME"
        bsCustomers.DataSource = oCustomers
    End Sub

    Private Sub getVendors()
        oVendors = New VendorCollection
        oVendors.LoadAll()
        oVendors.Sort = "VENDORNAME"
        bsVendors.DataSource = oVendors
    End Sub

    Private Sub getProducts()

        'create sub query for products in the MATERIALPRODUCT table for the selected MaterialID value
        Dim qMP As New MaterialproductQuery
        qMP.Select(qMP.Productid)
        qMP.Where(qMP.Materialid = vMaterialID)

        oProducts = New ProductCollection
        If vFrmSource = "MaterialNeed" And vMaterialID > 0 Then
            oProducts.Query.Where(oProducts.Query.Productid.In(qMP))
            oProducts.Query.Load()
        Else
            oProducts.LoadAll()
        End If
        oProducts.Sort = "ProductID"
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oItem = New PurchaseRequest
        oItem.AddNew()
        'assign foreign key values here
        oItem.PurchReqDate = Today
        oItem.IsOrdered = 0
        If Not IsDBNull(vWorkOrderNum) Or vWorkOrderNum > 0 Then
            oItem.WorkOrderNumber = vWorkOrderNum
        End If
        If Not IsDBNull(vCustomerID) Or vCustomerID > 0 Then
            oItem.CustID = vCustomerID
        End If
        If Not IsDBNull(vProductID) Or vProductID > 0 Then
            oItem.ProductID = vProductID
        End If
        If Not IsDBNull(vQty) Or vQty > 0 Then
            oItem.QtyContainers = vQty
        End If
        If Not IsDBNull(vProdOrderNum) Or vProdOrderNum > 0 Then
            oItem.ProdOrderNum = vProdOrderNum
        End If
        oItem.Save()
        vID = oItem.PurchReqID
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New PurchaseRequest
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function changesSaved() As Boolean
        Try
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

    Private Sub eProductID_EditValueChanged(sender As Object, e As System.EventArgs) Handles eProductID.EditValueChanged
        lookupProductInfo(eProductID.EditValue)
    End Sub

    Private Sub lookupProductInfo(vKey As Integer)
        Dim oProd As Product
        oProd = New Product
        oProd.LoadByPrimaryKey(vKey)
        eProductDesc.Text = oProd.Productdesc
        eContainer.Text = oProd.Container
        eUnits.Text = oProd.Units
        eUOM.Text = oProd.Uom
    End Sub
End Class