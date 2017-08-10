Imports AOS.BusinessObjects

Public Class frmAllocateItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vItemID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vProductID As Integer

    Private oItems As InvitemCollection
    Private oProducts As ProductCollection


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getProducts()
        loadData()
    End Sub

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProducts.LoadAll()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub loadData()
        oItems = New InvitemCollection
        oItems.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oItems.Query.Where(oItems.Query.Productid.Equal(vProductID) And oItems.Query.Itemstatus.Equal("AVAILABLE") And oItems.Query.Shippeddate.IsNull And oItems.Query.Inventoryclass.Equal(1))
        oItems.Query.Load()
        bsItems.DataSource = oItems
    End Sub

    Private Sub saveChanges()
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Function changesSaved() As Boolean

        Try
            'get Work Order Item Record
            Dim oWOItem As Workorderitem
            oWOItem = New Workorderitem
            oWOItem.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            oWOItem.LoadByPrimaryKey(vItemID)

            'reset Inventory Item if one is already allocated
            Dim vNum As Integer = 0
            If oWOItem.Invitemnumber.HasValue = True Then
                vNum = oWOItem.Invitemnumber.Value
                Dim oInvItem As Invitem
                oInvItem = New Invitem
                oInvItem.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
                oInvItem.LoadByPrimaryKey(vNum)
                oInvItem.Itemstatus = "AVAILABLE"
                oInvItem.Allocatedtype = Nothing
                oInvItem.Allocateddate = Nothing
                oInvItem.Allocateddocument = Nothing
                oInvItem.Save()
            End If

            'Now set the current work order item with values from the selected Item
            oWOItem.Invitemnumber = bsItems.Current.InvItemNumber
            oWOItem.Lotnumber = bsItems.Current.LotNumber
            oWOItem.Warehouselocation = bsItems.Current.WarehouseLocation
            'set unit cost to match inventory item, whose cost was set at point of receiving into inventory from purchase documents
            'otherwise, if no unit cost is in the inventory item record, system will set default product price from product table
            If Not IsDBNull(bsItems.Current.UnitCost) Then
                If bsItems.Current.UnitCost > 0 Then
                    oWOItem.Unitcost = bsItems.Current.unitcost
                    oWOItem.Itemprofit = oWOItem.Itemprice - oWOItem.Unitcost
                End If
            End If
            oWOItem.Save()

            bsItems.Current.Allocateddate = Today
            bsItems.Current.AllocatedDocument = oWOItem.Workordernumber
            bsItems.Current.ItemStatus = "ALLOCATED"
            bsItems.EndEdit()
            oItems.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        saveChanges()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub grItems_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grItems.DoubleClick
        saveChanges()
    End Sub
End Class