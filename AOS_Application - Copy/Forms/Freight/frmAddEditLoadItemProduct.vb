Imports AOS.BusinessObjects

Public Class frmAddEditLoadItemProduct
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    'here is where you define your Public variables for the form (to pass in values and pull out values)
    Public vLoadItemID As Integer
    Public vLoadID As Integer
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vUserView As String  'If READONLY then all controls are made read only (VIEW)

    'here is where you dimension your object variables for the form
    Dim vItemType As String = "PRODUCT"
    Dim oLoadItem As Loaditem
    Dim oLoad As Load

    Dim oProducts As ProductCollection
    Dim oWOItem As Workorderitem
    Dim oProduct As Product
    Dim oContainer As Container

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        setUserView()
        loadReferenceData()
        loadData()
    End Sub

    Private Sub setUserView()
        rtLoadNumber.Caption = vLoadID.ToString
        rtItemType.Caption = vItemType
        Me.Text = "Load Item - " + vItemType
        If vUserView = "READONLY" Then
            Me.Text = "Load Item - " + vItemType + " (View Only)"
            'make all edit controls READONLY
            eQty.Properties.ReadOnly = True
            eProductID.Properties.ReadOnly = True
        End If
    End Sub

    Private Sub loadReferenceData()
        oProducts = New ProductCollection
        oProducts.Query.Where(oProducts.Query.Isactive.Equal(1))
        oProducts.Query.Load()
        oProducts.Sort = "PRODUCTDESC, CONTAINER"
        bsProducts.Datasource = oProducts
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vLoadItemID)
        End If
    End Sub

    Private Sub addNewObject()
        oLoadItem = New Loaditem
        oLoadItem.AddNew()
        oLoadItem.LoadID = vLoadID
        oLoadItem.ItemType = "PRODUCT"
        oLoadItem.CreatedBy = vCurrentUserLogin
        oLoadItem.CreatedTime = Now
        oLoadItem.ModifiedBy = vCurrentUserLogin
        oLoadItem.ModifiedTime = Now
        oLoadItem.Save()
        vLoadItemID = oLoadItem.LoadItemID
        Me.bsLoadItem.DataSource = oLoadItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Me.Close()
            Exit Sub
        End If
        oLoadItem = New Loaditem
        oLoadItem.LoadByPrimaryKey(vID)
        Me.bsLoadItem.DataSource = oLoadItem
        'Look up WorkOrder item details from WORKORDER to display on screen
        If oLoadItem.SourceType = "WORKORDER" And oLoadItem.SourceID > 0 Then
            getWorkOrderInfo(bsLoadItem.Current.SourceId)
        End If
    End Sub

    Private Sub getWorkOrderInfo(vID As Integer)
        If IsDBNull(vID) Then
            Exit Sub
        End If
        oWOItem = New Workorderitem
        oWOItem.LoadByPrimaryKey(vID)
        bsWOItem.Datasource = oWOItem
    End Sub


    Private Sub btnCancel_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        oLoadItem.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oLoadItem.MarkAsDeleted()
                oLoadItem.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If saveChanges() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function saveChanges() As Boolean
        Try
            bsLoadItem.EndEdit()
            oLoadItem.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Private Sub eProductID_EditValueChanged(sender As Object, e As EventArgs) Handles eProductID.EditValueChanged
        If IsDBNull(eProductID.EditValue) Or eProductID.EditValue Is Nothing Then
            Exit Sub
        End If
        oProduct = New Product
        oProduct.LoadByPrimaryKey(eProductID.EditValue)
        bsProduct.DataSource = oProduct

        oContainer = New Container
        oContainer.Query.Where(oContainer.Query.Container.Equal(oProduct.Container))
        oContainer.Query.Load()
        bsContainer.DataSource = oContainer
    End Sub
End Class