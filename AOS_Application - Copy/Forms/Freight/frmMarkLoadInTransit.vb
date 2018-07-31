Imports AOS.BusinessObjects

Public Class frmMarkLoadInTransit
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vLoadID As Integer       'object primary key (passed in by calling form for edit mode)
    
    'here is where you dimension your object variables for the form
    Dim oLoad As Load
    Dim oCarrier As Carrier
    Dim oCust As Customer
    Dim oLoadInfo As ViewLoadInfo
 
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        If vLoadID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If

        oLoad = New Load
        oLoad.LoadByPrimaryKey(vLoadID)

        oLoadInfo = New ViewLoadInfo
        oLoadInfo.Query.Where(oLoadInfo.Query.LoadID.Equal(vLoadID))
        oLoadInfo.Query.Load()

        oCust = New Customer
        oCust.Query.Where(oCust.Query.Custid.Equal(oLoad.CustID))
        oCust.Query.Load()

        oCarrier = New Carrier
        Try
            oCarrier.LoadByPrimaryKey(oLoad.ScheduledCarrierID)
        Catch ex As Exception

        End Try
        
        bsLoad.DataSource = oLoad
        bsLoadInfo.DataSource = oLoadInfo
        bsCustomer.DataSource = oCust
        bsCarrier.DataSource = oCarrier

        eOrigin.Text = oLoad.OriginName + " - " + oLoad.OriginCity + ", " + oLoad.OriginState
        eDestination.Text = oLoad.DestName + " - " + oLoad.DestCity + ", " + oLoad.DestState

    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsLoad.EndEdit()
            oLoad.EndEdit()
            oLoad.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsLoad.CancelEdit()
            oLoad.CancelEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error cancelling changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If Not changesSaved() Then
            Exit Sub
        End If
        If Not validData() Then
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.Yes

    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Function validData() As Boolean
        If IsDBNull(oLoad.ActualShipmentDate) Or oLoad.ActualShipmentDate Is Nothing Then
            MsgBox("You must enter a Scheduled Ship Date before the load can be marked as IN TRANSIT", MsgBoxStyle.Critical, "Error - Actual Shipment Date")
            Return False
        End If

        If IsDBNull(oLoad.CarrierProNumber) Or oLoad.CarrierProNumber Is Nothing Then
            MsgBox("You must enter a CarrierProNumber before the load can be marked as IN TRANSIT", MsgBoxStyle.Critical, "Error - Carrier Pro Number")
            Return False
        End If

        'data has passed validation - confirm that user truly wants to schedule the load and move it to the active load board
        If MsgBox("Are you sure you want to mark this load as IN TRANSIT? Note: This will also mark all WorkOrder Items on this load to ""Ready for Invoice"".", MsgBoxStyle.YesNo, "Confirm - Mark IN TRANSIT") = MsgBoxResult.No Then
            Return False
        End If

        'call function from the loadProcessing module - to update WorkOrderItems from Load
        If updateWorkOrderFromLoadInfo(oLoad.LoadID, "IN TRANSIT") Then
            'if successful, all workorderitems on this load will now be marked WorkOrderItemStatus = INVOICE
            'also, the WorkOrder will be marked as Ready for Invoice (OrderStatus = INVOICE) if all WorkOrderItems have WorkOrderItemStatus = INVOICE
            oLoad.LoadStatus = "IN TRANSIT"
            oLoad.ModifiedBy = vCurrentUserLogin
            oLoad.ModifiedTime = Now
            oLoad.Save()
            Return True
        Else
            MsgBox("Failed to update WorkOrderItems on this Load. Cannot move the Load to IN TRANSIT. See administrator", MsgBoxStyle.Critical, "Error - Update failed")
            Return False
        End If

    End Function


End Class