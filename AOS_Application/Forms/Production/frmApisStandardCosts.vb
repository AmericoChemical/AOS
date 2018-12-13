Imports AOS.BusinessObjects

Public Class frmApisStandardCosts
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vAPISID As Integer       'object primary key (passed in by calling form for edit mode)

    'here is where you dimension your object variables for the form
    Dim oAPIS As ViewAPISData
    Dim oMatlCosts As ViewCostingApisMaterialStdCostCollection
    Dim oTotalCosts As ViewCostingApisTotalCosts
    Dim oProduct As Product

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        editObject(vAPISID)
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Lookup Failed")
            Exit Sub
        End If

        getAPISData(vID)
        getAPISMaterialCosts(vID)
        getAPISTotalCosts(vID)
        getProduct(oAPIS.Productid)

    End Sub

    Private Sub getProduct(vProdID As Integer)
        oProduct = New Product
        If Not oProduct.LoadByPrimaryKey(vProdID) Then
            MsgBox("Could not open associated Product record for the APIS", MsgBoxStyle.Critical, "ERROR")
        End If
    End Sub

    Private Sub getAPISData(vID As Integer)
        oAPIS = New ViewAPISData
        oAPIS.Query.Where(oAPIS.Query.Apisnum.Equal(vID))
        oAPIS.Query.Load()
        bsAPISData.DataSource = oAPIS
    End Sub

    Private Sub getAPISMaterialCosts(vID As Integer)
        oMatlCosts = New ViewCostingApisMaterialStdCostCollection
        oMatlCosts.Query.Where(oMatlCosts.Query.Apisnum.Equal(vID))
        oMatlCosts.Query.Load()
        bsMaterialCosts.DataSource = oMatlCosts
    End Sub

    Private Sub getAPISTotalCosts(vID As Integer)
        oTotalCosts = New ViewCostingApisTotalCosts
        oTotalCosts.Query.Where(oTotalCosts.Query.Apisnum.Equal(vID))
        oTotalCosts.Query.Load()
        bsApisTotalCosts.DataSource = oTotalCosts
    End Sub

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    ' VS-- STD cost update should be automatic

    'Private Sub btnUpdateStandardCosts_Click(sender As Object, e As EventArgs) Handles btnUpdateStandardCosts.Click

    '    If Not IsDBNull(oProduct.Stdweight) Then
    '        If oTotalCosts.Weight <> oProduct.Stdweight Then
    '            If MsgBox("The Label Weight does not match the Standard Weight Units. Do you want to save anyway?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
    '                Exit Sub
    '            End If
    '        End If
    '    End If

    '    If MsgBox("Are you sure you want to UPDATE the existing STANDARD COSTS for this product to the CALCULATED APIS COSTS?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    If MsgBox("If you make this change, it cannot be undone. ARE YOU SURE YOU WANT TO CONTINUE?", MsgBoxStyle.YesNo, "CONFIRM REQUEST") = MsgBoxResult.No Then
    '        Exit Sub
    '    End If

    '    updateAPISStandardCosting(oAPIS.Productid, oTotalCosts.Volume, oTotalCosts.ApisVolUnitCost, oTotalCosts.Weight, oTotalCosts.ApisUnitCost, "APIS UPDATE - " & oAPIS.Apisnum.ToString, "STD COST", oAPIS.Apisnum, "APIS CHNG-" & oAPIS.Apisnum)

    '    editObject(vAPISID)

    'End Sub
End Class
