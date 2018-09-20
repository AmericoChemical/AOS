Imports AOS.BusinessObjects
Imports System.Text

Public Class frmUpdateComponentUnitCost
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vComponentId As Integer       'object primary key (passed in by calling form for edit mode)
    Public vVendorID As Integer
    Public vCostID As Integer
    Public vAddtype As String

    Dim vFlag As Boolean = False

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Component Unit Costing"
    Dim vCategory As String = "ComponentCost"

    'here is where you dimension your object variables for the form
    Dim oComponent As New Component
    Dim oVendors As New VendorCollection
    Dim oCustomer As New CustomerCollection
    Dim oCostType As New ListCosttypeCollection
    Dim oCost As New Componentcost
    Dim oUOMV As New ViewUOMByVolumeCollection
    Dim oUOMW As New ViewUOMByWeightCollection
    Dim vAuditRuleID As Integer = AuditLogProcessing.cAUDITRULEIDPRICING

    Dim OrigUnitCost As Decimal = 0.00


    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vAddtype = "NEW" Then
            Me.Text = "Adding New " & vObjectName & " Information"
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()

        OrigUnitCost = IIf(IsDBNull(oCost.UnitCost), 0, oCost.UnitCost)

        'eChangeDate.EditValue = Today      'move this to AddObject and EditObject method (only if changes saved)
    End Sub

    Private Sub loadLookupTables()
        oVendors.LoadAll()
        oVendors.Sort = "VendorName"
        bsVendors.DataSource = oVendors

    End Sub

    Private Sub loadData()

        'get component record
        If vComponentId = Nothing Then
            MsgBox("There is no Component ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oComponent.LoadByPrimaryKey(vComponentId)
        Me.bs.DataSource = oComponent

        If vAddtype = "NEW" Then
            addNewCost()
        Else
            editCost(vCostID)
        End If

    End Sub
    Private Sub addNewCost()
        oCost = New Componentcost
        oCost.ComponentId = vComponentId
        oCost.CreatedDateTime = Now
        oCost.Createdby = vCurrentUserLogin
        oCost.ModifiedDateTime = Now
        oCost.ModifiedBy = vCurrentUserLogin
        oCost.Isactive = True
        oCost.Save()
        Me.bsComponentCost.DataSource = oCost
    End Sub

    Private Sub editCost(ByVal vCostID As Integer)
        If vCostID = Nothing Then
            MsgBox("There is no Cost Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oCost.LoadByPrimaryKey(vCostID)
        Me.bsComponentCost.DataSource = oCost
    End Sub

    Private Function changesSaved() As Boolean
        bsComponentCost.EndEdit()
        oCost.Save()

        Dim vUnitCost As Decimal
        If IsDBNull(eUnitCost.EditValue) Then
            vUnitCost = 0
        Else
            vUnitCost = eUnitCost.EditValue
        End If

        updateVendorComponentCosting(bsComponentCost.Current.ComponentCostId, vUnitCost, eReason.EditValue, bsComponentCost.Current.ComponentID, eVendor.EditValue, OrigUnitCost)

        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bsComponentCost.CancelEdit()
        Try
            If vAddtype = "NEW" Then
                oCost.MarkAsDeleted()
                oCost.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Sub SetFocustoFirstNullFieldinPricingMethod()
        If String.IsNullOrEmpty(eUnitCost.Text) Or Val(eUnitCost.Text.ToString()) = 0 Then
            eUnitCost.Focus()
        End If
    End Sub

    Private Function ValidateData()

        If IsDBNull(eReason.EditValue) Or eReason.EditValue = Nothing Then
            MsgBox("You must enter a reason for the costing changes.", MsgBoxStyle.Critical, "ERROR - Missing Reason for Change")
            Return False
        End If

        Dim vPartialPriceValidateMessage As String = "Partial pricing data is entered. Do you want to continue?"
        'Check whether pricing data has some values
        If (Me.bsComponentCost.Current.UnitCost > 0 Or
            Not String.IsNullOrEmpty(Me.eUnitCost.Text)) Then

            'Check if partial pricing data is entered
            If (Me.bsComponentCost.Current.UnitCost = 0 Or
                String.IsNullOrEmpty(Me.eUnitCost.Text)) Then
                If MsgBox(vPartialPriceValidateMessage, vbYesNo + vbQuestion) = vbNo Then
                    SetFocustoFirstNullFieldinPricingMethod()
                    Return False
                End If
            End If
        Else
            If MsgBox(vPartialPriceValidateMessage, vbYesNo + vbQuestion) = vbNo Then
                SetFocustoFirstNullFieldinPricingMethod()
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub rbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSave.ItemClick

        If ValidateData() = False Then
            'SetFocustoFirstNullFieldinPricingMethod()
            Exit Sub
        End If


        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub rbtnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub




    Private Sub rbtnUpdateComponentStandardCosts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUpdateComponentStandardCosts.ItemClick

        If String.IsNullOrEmpty(Me.eUnitCost.Text) Then
            MsgBox("You MUST enter valid unit cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Exit Sub
        End If
        If MsgBox("Are you sure you want to UPDATE the existing STANDARD COSTS for this Component to the VENDOR Component COSTS?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        If MsgBox("If you make this change, it cannot be undone. ARE YOU SURE YOU WANT TO CONTINUE?", MsgBoxStyle.YesNo, "CONFIRM REQUEST") = MsgBoxResult.No Then
            Exit Sub
        End If

        bsComponentCost.EndEdit()
        oCost.Save()

        Dim vUnitCost As Decimal = 0

        vUnitCost = oCost.UnitCost

        updateStandardCostingFromVendorComponentCostChange(oCost.ComponentId, vUnitCost, "Vendor Cost Updated", "STANDARD COST", oCost.ComponentId, "COMP COST CHNG-" & oCost.ComponentId)

        eUnitCost.Focus()
        Exit Sub


    End Sub


End Class