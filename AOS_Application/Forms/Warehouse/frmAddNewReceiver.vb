
Imports AOS.BusinessObjects

Public Class frmAddNewReceiver
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vRecvID As Integer
    Public vEditType As String

    Dim oRecv As Receiver
    Dim oRecvItems As ReceiveritemCollection
    Dim oVendors As VendorCollection
    Dim oWarehouses As WarehouseCollection
    Dim oProducts As ProductCollection

    Private Sub frm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
        Else
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getVendors()
        getWarehouses()
        getProducts()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vRecvID)
        End If
    End Sub

    Private Sub addNewObject()
        oRecv = New Receiver
        oRecv.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oRecv.AddNew()
        oRecv.Save()
        vRecvID = oRecv.Receivernumber.Value
        bsRecv.DataSource = oRecv
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oRecv = New Receiver
        oRecv.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oRecv.LoadByPrimaryKey(vID)
        bsRecv.DataSource = oRecv
        getReceiverItems(vRecvID)
    End Sub

    Private Sub getReceiverItems(ByVal vRecvID As Integer)
        oRecvItems = New ReceiveritemCollection
        oRecvItems.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oRecvItems.Query.Where(oRecvItems.Query.Receivernumber.Equal(vRecvID))
        oRecvItems.Query.Load()
        Try
            bsRecvItems.DataSource = oRecvItems
            grItems.DataSource = bsRecvItems
            grItems.Refresh()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub getVendors()
        oVendors = New VendorCollection
        oVendors.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oVendors.LoadAll()
        bsVendors.DataSource = oVendors
    End Sub

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProducts.LoadAll()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub getWarehouses()
        oWarehouses = New WarehouseCollection
        oWarehouses.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oWarehouses.LoadAll()
        bsWarehouses.DataSource = oWarehouses
    End Sub

    Private Sub saveDataChanges()
        bsRecv.EndEdit()
        bsRecvItems.EndEdit()
        oRecv.EndEdit()
        oRecv.Save()
        oRecvItems.Save()
    End Sub

    Private Sub addNewItem()
        If IsDBNull(eWarehouse.EditValue) Then
            MsgBox("You must select a warehouse first")
            Exit Sub
        End If
        If IsDBNull(eVendorID.EditValue) Then
            MsgBox("You must select a vendor first")
            Exit Sub
        End If
        Dim frm As New frmAddNewReceiverItem
        frm.vWhseID = eWarehouse.EditValue
        frm.vVendorID = eVendorID.EditValue
        frm.vRecvrNum = bsRecv.Current.Receivernumber
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getReceiverItems(bsRecv.Current.Receivernumber)
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        bsRecv.EndEdit()
        bsRecvItems.EndEdit()
        oRecv.Save()
        oRecvItems.Save()
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        oRecv.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oRecv.MarkAsDeleted()
                oRecv.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnNewCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewCostRecord.ItemClick
        addNewItem()
    End Sub
End Class