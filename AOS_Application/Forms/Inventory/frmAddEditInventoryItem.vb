Imports AOS.BusinessObjects

Public Class frmAddEditInventoryItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer
    Public vEditType As String
    Dim oItem As ViewInvItemDetails
    'Dim oProducts As ProductCollection
    'Dim oStatus As InventorystatusCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'getProducts()
        'getStatusInfo()
        loadData()
    End Sub

    'Private Sub getProducts()
    '    oProducts = New ProductCollection
    '    oProducts.LoadAll()
    '    bsProducts.DataSource = oProducts
    'End Sub

    'Private Sub getStatusInfo()
    '    oStatus = New InventorystatusCollection
    '    oStatus.LoadAll()
    '    bsStatus.DataSource = oStatus
    'End Sub

    Private Sub loadData()
        oItem = New ViewInvItemDetails
        oItem.Query.Where(oItem.Query.Invitemnumber.Equal(vID))
        If Not oItem.Query.Load Then
            MsgBox("Error in loading requested data", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        bsItem.DataSource = oItem
    End Sub

    Private Sub btnSaveChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveChanges.Click
        If validateData() Then
            bsItem.EndEdit()
            oItem.EndEdit()
            oItem.Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnCancelChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelChanges.Click
        oItem.CancelEdit()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function validateData() As Boolean
        'If IsDBNull(eStatus.EditValue) Then
        '    MsgBox("You must select a Status for this item to save it", MsgBoxStyle.Critical, "Error - No Status")
        '    Return False
        'End If
        'If Not IsDBNull(eShippeddate.EditValue) Then
        '    MsgBox("This item has a ship date - the status will be set to SHIPPED", MsgBoxStyle.Information, "")
        '    eStatus.EditValue = "SHIPPED"
        '    Return True
        'End If
        'If Not IsDBNull(eAllocateddate.EditValue) Then
        '    MsgBox("This item has an Allocated Date - the status will be set to ALLOCATED", MsgBoxStyle.Information, "")
        '    eStatus.EditValue = "ALLOCATED"
        'End If
        Return True
    End Function

End Class