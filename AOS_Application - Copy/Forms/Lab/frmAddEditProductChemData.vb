Imports AOS.BusinessObjects

Public Class frmAddEditProductChemData
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
   
    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Product"

    'here is where you dimension your object variables for the form
    Dim oProduct As New Product
    Dim oShelfLife As New ListShelflifeCollection
    Dim oClarityList As New ListChemicalclarityCollection
    Dim oColorList As New ListChemicalcolorCollection


#Region " SECURITY - RIBBON FUNCTIONS "

    Private Sub setRibbonOptions(ByVal vLevel As Integer)
        'used to control visibility of options presented on Ribbon control based on user security level of session
        Dim vPageNum As Integer = 0
        'iterate through the riboon pages and adjust visibility of whole page
        For vPageNum = 0 To Me.RibbonControl1.Pages.Count - 1
            If CInt(Me.RibbonControl1.Pages(vPageNum).Tag) > vLevel Then
                Me.RibbonControl1.Pages(vPageNum).Visible = False
            Else
                Me.RibbonControl1.Pages(vPageNum).Visible = True
                'if page will be visible, then iterate through page groups and adjust visibility of whole group
                Dim grpNum As Integer = 0
                For grpNum = 0 To Me.RibbonControl1.Pages(vPageNum).Groups.Count - 1
                    If CInt(Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Tag) > vLevel Then
                        Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Visible = False
                    Else
                        Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Visible = True
                    End If
                Next
            End If
        Next
        'have to iterate through individual items separately for whole ribbon and adjust visibility
        Dim itemNum As Integer = 0
        For itemNum = 0 To Me.RibbonControl1.Items.Count - 1
            If CInt(Me.RibbonControl1.Items(itemNum).Tag) > vLevel Then
                Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
        Next
    End Sub

#End Region


    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setRibbonOptions(vCurrentUserSecurityLevel)
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadReferenceData()
        loadData()
    End Sub

    Private Sub loadReferenceData()
        oShelfLife = New ListShelflifeCollection
        oShelfLife.LoadAll()
        bsShelfLife.DataSource = oShelfLife

        oClarityList = New ListChemicalclarityCollection
        oClarityList.LoadAll()
        bsClarity.DataSource = oClarityList

        oColorList = New ListChemicalcolorCollection
        oColorList.LoadAll()
        bsColor.DataSource = oColorList
    End Sub

    Private Sub loadData()
            editObject(vID)
    End Sub
   
    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oProduct.LoadByPrimaryKey(vID)
        Me.bs.DataSource = oProduct
    End Sub

    Private Function changesSaved() As Boolean
        bs.EndEdit()
        oProduct.EndEdit()
        oProduct.Modifyby = vCurrentUserLogin
        oProduct.Modifytime = Now
        oProduct.Save()
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bs.CancelEdit()
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

End Class