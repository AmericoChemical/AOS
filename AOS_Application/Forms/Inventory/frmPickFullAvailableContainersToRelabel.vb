Imports AOS.BusinessObjects

Public Class frmPickFullAvailableContainersToRelabel
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer

    Dim oItems As ViewInvItemDetailsCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadInventoryItemData(vProductID)
    End Sub

    Private Sub loadInventoryItemData(vProductID As Integer)

        oItems = New ViewInvItemDetailsCollection
        oItems.Query.Where(oItems.Query.Productid.Equal(vProductID))
        If Not oItems.Query.Load Then
            MsgBox("No available inventory items for the selected Product ID were found", MsgBoxStyle.Information, "No records found")
        End If
        bsItems.DataSource = oItems

    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

   
End Class