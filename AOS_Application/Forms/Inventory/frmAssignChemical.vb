Imports AOS.BusinessObjects

Public Class frmAssignChemical
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vChemicalID As Integer
    Public vEditType As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Assign Chemical"

    'here is where you dimension your object variables for the form
    Dim oChemicals As ChemicalCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
        If vChemicalID > 0 Then
            eChemical.EditValue = vChemicalID
        End If
    End Sub

    Private Sub loadData()
        oChemicals = New ChemicalCollection
        oChemicals.LoadAll()
        oChemicals.Sort = "ChemicalName"
        bsChemicals.DataSource = oChemicals
    End Sub


    Private Function changesSaved() As Boolean
        vChemicalID = eChemical.EditValue
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Return True
    End Function

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub


End Class