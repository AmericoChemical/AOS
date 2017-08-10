Imports AOS.BusinessObjects

Public Class frmAddEditLoadBilling
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vCustID As Integer
    Public vLoadID As Integer
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Load Billing Record"

    'here is where you dimension your object variables for the form
    Dim oBill As Loadbilling
    Dim oCust As Customer
    Dim oLoadInfo As ViewLoadInfo

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
        oCust = New Customer
        oCust.LoadByPrimaryKey(oBill.CustomerID)
        bsCustomer.DataSource = oCust
        oLoadInfo = New ViewLoadInfo
        oLoadInfo.Query.Where(oLoadInfo.Query.LoadID.Equal(oBill.Loadid))
        oLoadInfo.Query.Load()
        bsLoadInfo.DataSource = oLoadInfo

        eOrigin.Text = oLoadInfo.OriginName + " - " + oLoadInfo.OriginCity + ", " + oLoadInfo.OriginState
        eDestination.Text = oLoadInfo.DestName + " - " + oLoadInfo.DestCity + ", " + oLoadInfo.DestState

    End Sub

    Private Sub addNewObject()
        oBill = New Loadbilling
        oBill.AddNew()
        'assign foreign key values here
        oBill.Loadid = vLoadID
        oBill.BillingDate = Now
        oBill.BilledAmount = 0.0
        oBill.CreatedBy = vCurrentUserLogin
        oBill.Status = "PENDING"
        oBill.CustomerID = vCustID
        oBill.Save()
        Me.bsLoadBilling.DataSource = oBill
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oBill = New Loadbilling
        oBill.LoadByPrimaryKey(vID)
        Me.bsLoadBilling.DataSource = oBill
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsLoadBilling.EndEdit()
            oBill.EndEdit()
            oBill.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsLoadBilling.CancelEdit()
            oBill.CancelEdit()
            If vEditType = "ADD" Then
                oBill.MarkAsDeleted()
                oBill.Save()
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