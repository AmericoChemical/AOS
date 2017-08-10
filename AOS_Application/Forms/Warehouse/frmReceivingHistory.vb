Imports AOS.BusinessObjects

Public Class frmReceivingHistory
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = ""

    'here is where you dimension your object variables for the form
    Dim oItems As ViewReceivingHistoryCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        oItems = New ViewReceivingHistoryCollection
        oItems.LoadAll()
        oItems.Sort = "RECEIVEDDATE DESC"
        Me.bs.DataSource = oItems
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBack.ItemClick

        Me.DialogResult = Windows.Forms.DialogResult.Cancel

    End Sub
End Class