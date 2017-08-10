Imports AOS.BusinessObjects

Public Class frmScheduleLoad
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vLoadID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vQuoteID As Integer

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Schedule Load"

    'here is where you dimension your object variables for the form
    Dim oLoad As Load
    Dim oCarriers As CarrierCollection
    Dim oLogistics As LogisticsCollection
    Dim oCust As Customer
    Dim oLoadInfo As ViewLoadInfo
    Dim oLoadQuote As Loadquote

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

    Private Sub loadData()
        If vLoadID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If

        oLoad = New Load
        oLoad.LoadByPrimaryKey(vLoadID)

        oLoadQuote = New Loadquote
        If oLoadQuote.LoadByPrimaryKey(vQuoteID) Then
            'user has elected to use a particular carrier quote to schedule load
            'update Load Info with Quote info
            oLoad.QuoteID = oLoadQuote.LoadQuoteID
            oLoad.ScheduledCarrierID = oLoadQuote.CarrierID
            oLoad.ScheduledLogisticsID = oLoadQuote.LogisticsProviderID
            oLoad.Save()

            'set data item readonly tags
            eCarrier.Properties.ReadOnly = True
            eLogistics.Properties.ReadOnly = True

            'remove any existing LoadCharge records for a different Carrier
            Dim oChrgs As New LoadchargeCollection
            oChrgs.Query.Where(oChrgs.Query.LoadID.Equal(vLoadID), oChrgs.Query.CarrierID.NotEqual(oLoadQuote.CarrierID))
            If oChrgs.Query.Load() Then
                For Each oCh As Loadcharge In oChrgs
                    oCh.MarkAsDeleted()
                Next
                oChrgs.Save()
            End If

            'create/update LoadCharge record
            Dim oChrg As New Loadcharge
            oChrg.Query.Where(oChrg.Query.LoadID.Equal(vLoadID), oChrg.Query.CarrierID.Equal(oLoadQuote.CarrierID))
            If oChrg.Query.Load() Then
                'there is already a LoadCharge record for this Load/Carrier combination in the database - update it
                oChrg.ChargeDate = Now
                oChrg.CarrierID = oLoadQuote.CarrierID
                oChrg.LogisticsProviderID = oLoadQuote.LogisticsProviderID
                oChrg.CarrierCharges = oLoadQuote.QuoteAmount
                oChrg.Save()
            Else
                'no loadCharge record exists - add one to the database
                oChrg = New Loadcharge
                oChrg.LoadID = vLoadID
                oChrg.CarrierID = oLoadQuote.CarrierID
                oChrg.LogisticsProviderID = oLoadQuote.LogisticsProviderID
                oChrg.CarrierCharges = oLoadQuote.QuoteAmount
                oChrg.ChargeDate = Now
                oChrg.CreatedBy = vCurrentUserLogin
                oChrg.Save()
            End If

            'hide edit button for Load Charges
            btnEditCharges.Visible = False

            'create LoadBilling record if necessary
            Dim oBill As New Loadbilling
            Select Case oLoad.LoadType
                Case "OUTBOUND"
                    'If oLoad.Fob = "BILL 3RD PARTY" And oLoad.BillCustomer = True Then
                    If oLoad.BillCustomer = True Then
                        'then customer is getting billed for freight from Americo or BDF Logistics
                        'first, determine if there is already a billing record for this load
                        oBill = New Loadbilling
                        oBill.Query.Where(oBill.Query.Loadid.Equal(vLoadID))
                        If oBill.Query.Load() Then
                            'there is already a billing record for this load
                            If oLoad.AddToInvoice = True Then
                                oBill.BillingEntity = "AMERICO"
                            Else
                                oBill.BillingEntity = "3RD PARTY"
                            End If
                            oBill.Save()
                        Else
                            'there is no billing record for this load - create one
                            oBill = New Loadbilling
                            oBill.Loadid = vLoadID
                            oBill.CustomerID = oLoad.CustID
                            oBill.BilledAmount = 0.0
                            oBill.BillingDate = Now
                            oBill.CreatedBy = vCurrentUserLogin
                            oBill.Status = "PENDING"
                            If oLoad.AddToInvoice = True Then
                                oBill.BillingEntity = "AMERICO"
                            Else
                                oBill.BillingEntity = "3RD PARTY"
                            End If
                            oBill.Save()
                        End If
                        'show edit button to alter billing amount
                        btnEditBillings.Visible = True
                    Else
                        'Customer is NOT getting billed for freight charges
                        'remove billing record if there is one    
                        oBill = New Loadbilling
                        oBill.Query.Where(oBill.Query.Loadid.Equal(vLoadID))
                        If oBill.Query.Load() Then
                            oBill.MarkAsDeleted()
                            oBill.Save()
                        End If
                        'hide data items on screen for Customer Billing
                        btnEditBillings.Visible = False
                    End If

                Case "INBOUND"

                Case "DIRECT"

            End Select

        Else
            'there is no linked quote record to this load
            'show edit buttons for LoadCharges and LoadBillings
            btnEditCharges.Visible = True
            btnEditBillings.Visible = True

            'If oLoad.BillCustomer = True Then
            '    btnEditBillings.Visible = True
            'Else
            '    btnEditBillings.Visible = False
            'End If

        End If


        oLoadInfo = New ViewLoadInfo
        oLoadInfo.Query.Where(oLoadInfo.Query.LoadID.Equal(vLoadID))
        oLoadInfo.Query.Load()

        oCust = New Customer
        oCust.Query.Where(oCust.Query.Custid.Equal(oLoad.CustID))
        oCust.Query.Load()

        bsLoadQuote.DataSource = oLoadQuote
        Me.bsLoad.DataSource = oLoad
        bsLoadInfo.DataSource = oLoadInfo
        bsCustomer.DataSource = oCust

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
        If IsDBNull(oLoad.ScheduledShipmentDate) Or oLoad.ScheduledShipmentDate Is Nothing Then
            MsgBox("You must enter a Scheduled Ship Date before the load can be marked as scheduled", MsgBoxStyle.Critical, "Error - Shipment Date")
            Return False
        End If

        If oLoad.ScheduledShipmentDate < Today Then
            MsgBox("Scheduled Ship Date must be greater than or equal to today's date", MsgBoxStyle.Critical, "Error - Shipment Date")
            Return False
        End If

        If IsDBNull(oLoad.ScheduledCarrierID) Then
            MsgBox("You must select a Carrier before the load can be marked as scheduled", MsgBoxStyle.Critical, "Error - Carrier Missing")
            Return False
        End If

        'data has passed validation - confirm that user truly wants to schedule the load and move it to the active load board
        If MsgBox("Are you sure you want to mark this load as SCHEDULED and move it to the Active Load Board?", MsgBoxStyle.YesNo, "Confirm - Schedule Load") = MsgBoxResult.No Then
            Return False
        End If

        oLoad.LoadStatus = "SCHEDULED"
        oLoad.Save()
        loadData()
        Return True
    End Function

    Private Sub btnEditCharges_Click(sender As Object, e As EventArgs) Handles btnEditCharges.Click
        Dim oChrgs As New LoadchargeCollection
        oChrgs.Query.Where(oChrgs.Query.LoadID.Equal(vLoadID))
        oChrgs.Query.Load()
        Select Case oChrgs.Count
            Case 0
                Dim frm As New frmAddEditLoadCharge
                frm.vEditType = "ADD"
                frm.vLoadID = vLoadID
                frm.ShowDialog()
            Case 1
                Dim frm As New frmAddEditLoadCharge
                frm.vEditType = "EDIT"
                frm.vID = oChrgs(0).LoadChargeID
                frm.ShowDialog()
            Case Is > 1
                'need to show more than one record for user to select from
            Case Else
                Exit Sub
        End Select
        loadData()
    End Sub

    Private Sub btnEditBillings_Click(sender As Object, e As EventArgs) Handles btnEditBillings.Click

        Dim oBills As New LoadbillingCollection
        oBills.Query.Where(oBills.Query.Loadid.Equal(vLoadID))
        oBills.Query.Load()
        Select Case oBills.Count
            Case 0
                Dim frm As New frmAddEditLoadBilling
                frm.vEditType = "ADD"
                frm.vLoadID = vLoadID
                frm.vCustID = oLoad.CustID
                frm.ShowDialog()
            Case 1
                Dim frm As New frmAddEditLoadBilling
                frm.vEditType = "EDIT"
                frm.vID = oBills(0).Loadbillingid
                frm.ShowDialog()
            Case Is > 1
                'need to show more than one record for user to select from
            Case Else
                Exit Sub
        End Select
        loadData()
    End Sub


End Class