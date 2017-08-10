Imports AOS.BusinessObjects

Public Class frmAddEditLoadCharge
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vLoadID As Integer

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Freight - Carrier Charge"

    'here is where you dimension your object variables for the form
    Dim oChrg As Loadcharge
    Dim oCarriers As CarrierCollection
    Dim oLogistics As LogisticsCollection
    Dim oLoadInfo As ViewLoadInfo
    Dim oQuote As Loadquote

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getReferenceData()
        loadData()
    End Sub

    Private Sub getReferenceData()

        oCarriers = New CarrierCollection
        oCarriers.Query.Where(oCarriers.Query.Isactive.Equal(1))
        oCarriers.Query.Load()
        oCarriers.Sort = "CarrierName"
        bsCarriers.DataSource = oCarriers

        oLogistics = New LogisticsCollection
        oLogistics.Query.Where(oLogistics.Query.Isactive.Equal(1))
        oLogistics.Query.Load()
        oLogistics.Sort = "LogisticsName"
        bsLogistics.DataSource = oLogistics

    End Sub

    Private Sub getLoadData(vLoadID As Integer)
        oLoadInfo = New ViewLoadInfo
        oLoadInfo.Query.Where(oLoadInfo.Query.LoadID.Equal(vLoadID))
        oLoadInfo.Query.Load()
        bsLoadInfo.DataSource = oLoadInfo

        eOrigin.Text = oLoadInfo.OriginName + " - " + oLoadInfo.OriginCity + ", " + oLoadInfo.OriginState
        eDestination.Text = oLoadInfo.DestName + " - " + oLoadInfo.DestCity + ", " + oLoadInfo.DestState

        If Not IsDBNull(oLoadInfo.QuoteID) And oLoadInfo.QuoteID > 0 Then
            oQuote = New Loadquote
            oQuote.LoadByPrimaryKey(oLoadInfo.QuoteID)
            bsQuote.DataSource = oQuote
            disableChargeDataControls()
        End If
    End Sub

    Private Sub disableChargeDataControls()
        eCarrier.Properties.ReadOnly = True
        eLogistics.Properties.ReadOnly = True
        eChrgDate.Properties.ReadOnly = True
        eAmount.Properties.ReadOnly = True
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
        getLoadData(oChrg.LoadID)
    End Sub

    Private Sub addNewObject()
        oChrg = New Loadcharge
        oChrg.AddNew()
        'assign foreign key values here
        oChrg.LoadID = vLoadID
        oChrg.ChargeDate = Now
        oChrg.CreatedBy = vCurrentUserLogin
        oChrg.LoadChargeStatus = "PENDING"
        oChrg.Save()
        Me.bsCharge.DataSource = oChrg
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oChrg = New Loadcharge
        oChrg.LoadByPrimaryKey(vID)
        Me.bsCharge.DataSource = oChrg
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsCharge.EndEdit()
            oChrg.EndEdit()
            oChrg.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsCharge.CancelEdit()
            oChrg.CancelEdit()
            If vEditType = "ADD" Then
                oChrg.MarkAsDeleted()
                oChrg.Save()
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