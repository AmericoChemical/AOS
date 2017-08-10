Imports AOS.BusinessObjects

Public Class frmRawMaterialUsage

    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)

    Dim oTxs As ViewProductionOrderMaterialTransactionsCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()

        oTxs = New ViewProductionOrderMaterialTransactionsCollection
        oTxs.Query.Where(oTxs.Query.Prodordernum.Equal(vID))
        oTxs.Query.Load()

        bsTxs.DataSource = oTxs

    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class