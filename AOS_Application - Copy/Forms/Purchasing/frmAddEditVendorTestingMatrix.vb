Imports AOS.BusinessObjects

Public Class frmAddEditVendorTestingMatrix

    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vVendorID As Integer
    Public vVendorTestingMatrixID As Integer 'object primary key (passed in by calling form for edit mode)   
    Public vVendorName As String
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Vendor Testing Matrix"

    'here is where you dimension your object variables for the form
    Dim oVendortestingmatrix As New Vendortestingmatrix

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()
    End Sub

    Private Sub loadLookupTables()
        Dim oChemicalCategoryCollection As ListChemicalcategoryCollection = getChemicalCategoryList()
        bsChemicalCategoryCollection.DataSource = oChemicalCategoryCollection

        Dim oPriceListProductsList As ViewPriceListProductsCollection = getPriceListProductsList()
        bsProductsCollection.DataSource = oPriceListProductsList
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vVendorID)
        End If
    End Sub

    Private Sub addNewObject()
        oVendortestingmatrix.AddNew()
        oVendortestingmatrix.Createdby = vCurrentUserLogin
        oVendortestingmatrix.Createdtime = Now
        oVendortestingmatrix.Vendorid = vVendorID
        oVendortestingmatrix.Save()
        Me.bsVendorTestingMatrix.DataSource = oVendortestingmatrix
        eVendorID.EditValue = oVendortestingmatrix.Vendortestingmatrixid
        setFormText(vObjectName, vVendorID, vVendorName)
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vVendorTestingMatrixID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oVendortestingmatrix.LoadByPrimaryKey(vVendorTestingMatrixID)
        Me.bsVendorTestingMatrix.DataSource = oVendortestingmatrix
        oVendortestingmatrix.Modifyby = vCurrentUserLogin
        oVendortestingmatrix.Modifytime = Now
        setFormText(vObjectName, vID, vVendorName)
    End Sub

    Private Function changesSaved() As Boolean
        If ValidateControls() Then
            bsVendorTestingMatrix.EndEdit()
            oVendortestingmatrix.EndEdit()
            oVendortestingmatrix.Save()
            Return True
        End If
    End Function

    Private Function changesCancelled() As Boolean
        bsVendorTestingMatrix.CancelEdit()
        If vEditType = "ADD" Then
            oVendortestingmatrix.MarkAsDeleted()
            oVendortestingmatrix.Save()
        End If
        Return True
    End Function

    Private Sub rbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub rbtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub setFormText(vObjectName As String, vID As Integer, vVendorName As String)
        Me.Text = String.Format("{0} - Vendor: {1} - {2}", vObjectName, vID, vVendorName)
    End Sub

    Private Sub eRetain_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles eRetain.Validating
        ValidateControls()
    End Sub

    Private Sub eTest_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles eTest.Validating
        ValidateControls()
    End Sub

    Private Function ValidateControls() As Boolean
        If Not IsDBNull(eRetain.EditValue) Then
            If eRetain.EditValue > 100 Then
                eRetain.EditValue = 0
                eRetain.Focus()
                MsgBox("% Retain should be less than or eqaul to 100.", MsgBoxStyle.Critical, "Error")
                Return False
            End If
        End If
        If Not IsDBNull(eTest.EditValue) Then
            If eTest.EditValue > 100 Then
                eTest.EditValue = 0
                eTest.Focus()
                MsgBox("% Test should be less than or eqaul to 100.", MsgBoxStyle.Critical, "Error")
                Return False
            End If
        End If
        Return True
    End Function

End Class