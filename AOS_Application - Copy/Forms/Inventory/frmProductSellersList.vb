Imports AOS.BusinessObjects

Public Class frmProductSellersList
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)

    'here is where you dimension your object variables for the form
    Dim oItemList As ViewProductSellersListCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        oItemList = New ViewProductSellersListCollection
        oItemList.Query.Where(oItemList.Query.Itemid.Equal(vID))
        oItemList.Query.Load()
        oItemList.Sort = "Purchasedate DESC"
        Me.bs.DataSource = oItemList
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rbtnExportToExcel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnExportToExcel.ItemClick
        Try
            Dim vFilename As String
            vFilename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\ProductPurchaseHistory.xlsx"
            'grvItemList.ExportToXls(vFilename)
            grvItemList.ExportToXlsx(vFilename)
            System.Diagnostics.Process.Start(vFilename)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class