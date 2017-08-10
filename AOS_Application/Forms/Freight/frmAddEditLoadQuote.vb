Imports AOS.BusinessObjects

Public Class frmAddEditLoadQuote
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vLoadID As Integer
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Load Quote"

    'here is where you dimension your object variables for the form
    Dim oQuote As Loadquote
    Dim oCarriers As CarrierCollection
    Dim oLogistics As LogisticsCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadReferenceData()
        loadData()
    End Sub

    Private Sub loadReferenceData()

        oCarriers = New CarrierCollection
        oCarriers.LoadAll()
        oCarriers.Sort = "CarrierName"
        bsCarriers.DataSource = oCarriers

        oLogistics = New LogisticsCollection
        oLogistics.LoadAll()
        oLogistics.Sort = "LOGISTICSNAME"
        bsLogistics.DataSource = oLogistics

    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oQuote = New Loadquote
        oQuote.AddNew()
        'assign foreign key values here
        oQuote.LoadID = vLoadID
        oQuote.Save()
        Me.bsQuote.DataSource = oQuote
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oQuote = New Loadquote
        oQuote.LoadByPrimaryKey(vID)
        Me.bsQuote.DataSource = oQuote
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsQuote.EndEdit()
            oQuote.EndEdit()
            oQuote.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsQuote.CancelEdit()
            oQuote.CancelEdit()
            If vEditType = "ADD" Then
                oQuote.MarkAsDeleted()
                oQuote.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error cancelling changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
End Class