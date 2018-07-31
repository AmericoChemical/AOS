Imports AOS.BusinessObjects

Public Class frmChemicalProductLinks

    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vChemID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String      'operating mode (passed in by calling form)

    Dim oChem As Chemical
    Dim oProducts As ViewChemicalProductLinkCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If vEditType = "VIEW" Then
            rbtnAddNewProduct.Enabled = False
            rbtnEditProduct.Enabled = False
            rbtnDeleteChemicalProductLink.Enabled = False
        End If
        loadData()
    End Sub

    Private Sub loadData()
        oChem = New Chemical
        oChem.LoadByPrimaryKey(vChemID)
        bsChem.DataSource = oChem

        oProducts = New ViewChemicalProductLinkCollection
        oProducts.Query.Where(oProducts.Query.Chemicalid.Equal(vChemID))
        oProducts.Query.Load()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub btnReturn_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnReturn.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub rbtnAddNewProduct_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewProduct.ItemClick
        Dim frm As New frmAddEditProduct
        Dim vResult As DialogResult
        frm.vEditType = "ADD"
        frm.vChemID = vChemID
        vResult = frm.ShowDialog()
        loadData()
    End Sub

    Private Sub rbtnEditProduct_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditProduct.ItemClick
        If bsProducts.Count <= 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditProduct
        frm.vID = Me.bsProducts.Current.productID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub rbtnDeleteChemicalProductLink_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteChemicalProductLink.ItemClick
        If bsProducts.Count <= 0 Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to delete the Chemical/Product Link to the selected Product?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim oProduct As New Product
        If oProduct.LoadByPrimaryKey(bsProducts.Current.ProductID) Then
            oProduct.Chemicalid = 0
            oProduct.Save()
        End If
        loadData()
    End Sub
End Class