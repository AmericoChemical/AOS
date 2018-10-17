Imports AOS.BusinessObjects
Imports System.Text

Public Class frmUpdateProductStandardCosts
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer       'object primary key (passed in by calling form for edit mode)

    Dim vFlag As Boolean = False

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Product Standard Costs"
    Dim vCategory As String = "ProductCost"

    'here is where you dimension your object variables for the form
    Dim oProduct As New Product
    Dim oUOMV As New ViewUOMByVolumeCollection
    Dim oUOMW As New ViewUOMByWeightCollection

    Dim vAuditRuleID As Integer = AuditLogProcessing.cAUDITRULEIDPRICING

    Dim OrigVolCost As Decimal = 0.00
    Dim OrigWgtCost As Decimal = 0.00

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()
        OrigVolCost = IIf(IsDBNull(oProduct.Volumestandardcost), 0, oProduct.Volumestandardcost)
        OrigWgtCost = IIf(IsDBNull(oProduct.Weightstandardcost), 0, oProduct.Weightstandardcost)
    End Sub

    Private Sub loadLookupTables()
        oUOMV.LoadAll()
        bsUOMVolume.DataSource = oUOMV

        oUOMW.LoadAll()
        bsUOMWeight.DataSource = oUOMW

    End Sub

    Private Sub loadData()

        'get product record
        If vProductID = Nothing Then
            MsgBox("There is no Product ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oProduct.LoadByPrimaryKey(vProductID)
        Me.bsProduct.DataSource = oProduct

    End Sub

    Private Function changesSaved() As Boolean
        bsProduct.EndEdit()

        If Not ValidateCost() Then
            Return False
        End If

        'Costs, units and UOM has already updated as a part of .Save in ValidateCost No need to call save again Just need to cascade
        'updateProductStandardCosting(oProduct.Productid, eVolUnits.EditValue, OrigVolCost, eVolUnitCost.EditValue, eWgtUnits.EditValue, OrigWgtCost, eWgtUnitCost.EditValue, eReason.EditValue, "STD COST", oProduct.Productid, "PROD STD COST - " & oProduct.Productid)
        If OrigVolCost <> eVolUnitCost.EditValue Or OrigWgtCost <> eWgtUnitCost.EditValue Then
            'Process Product Cost Changes Across all Related Products
            ProcessProductStandardCostChanges(vProductID, OrigVolCost, OrigWgtCost, eVolUnitCost.EditValue, eWgtUnitCost.EditValue, eReason.EditValue, "STD COST", oProduct.Productid, "PROD STD COST - " & oProduct.Productid)
        End If

        If RaiseAuditEvent(vAuditRuleID, bsProduct, ProductInventoryMethod.VOLUME, vFlag) Then
            eVolUnitCost.Focus()
        ElseIf RaiseAuditEvent(vAuditRuleID, bsProduct, ProductInventoryMethod.WEIGHT, vFlag) Then
            eWgtUnitCost.Focus()
        End If

        oProduct.Save()
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Return True
    End Function

    Private Function ValidateCost() As Boolean

        'Check whether costing data has some value
        If String.IsNullOrEmpty(Me.eVolUnits.Text) Then
            eVolUnits.EditValue = 0
        End If
        If String.IsNullOrEmpty(Me.eVolUnitCost.Text) Then
                eVolUnitCost.EditValue = 0
            End If
        If IsDBNull(eVolUnits.EditValue) Or eVolUnits.EditValue < 0 Then
            eVolUnits.EditValue = 0
        End If
        If String.IsNullOrEmpty(Me.eVolUOM.Text) Then
            eVolUOM.EditValue = "GAL"
        End If
        If IsDBNull(eVolUnitCost.EditValue) Or eVolUnitCost.EditValue < 0 Then
            eVolUnitCost.EditValue = 0
        End If

        If bsProduct.Current.WEIGHTSTANDARDCOST > 0 Or
            bsProduct.Current.WEIGHTUNITS > 0 Or
            Not String.IsNullOrEmpty(Me.eWgtUOM.Text) Then
            If bsProduct.Current.WEIGHTSTANDARDCOST = 0 Or
               bsProduct.Current.WEIGHTUNITS = 0 Or
               String.IsNullOrEmpty(Me.eWgtUOM.Text) Then
                Return False
            End If
        Else
            Return False
        End If
        bsProduct.EndEdit()
        oProduct.Save()
        Return True
    End Function


    Private Function ValidateData()

        'check to see if product is a liquid - if so, require a volume units/uom/unitcost
        If oProduct.Isliquid = True Then
            If String.IsNullOrEmpty(Me.eVolUnits.Text) Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Return False
            End If
            If String.IsNullOrEmpty(Me.eVolUnitCost.Text) Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Return False
            End If
            If IsDBNull(eVolUnits.EditValue) Or eVolUnits.EditValue <= 0 Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Return False
            End If
            If String.IsNullOrEmpty(Me.eVolUOM.Text) Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Return False
            End If
            If IsDBNull(eVolUnitCost.EditValue) Or eVolUnitCost.EditValue <= 0 Then
                MsgBox("This product is a liquid. You MUST enter valid VOLUME cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
                Return False
            End If
        End If

        'always require a weight units/uom/unitcost
        If String.IsNullOrEmpty(Me.eWgtUnits.Text) Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Return False
        End If
        If String.IsNullOrEmpty(Me.eWgtUnitCost.Text) Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Return False
        End If
        If IsDBNull(eWgtUnits.EditValue) Or eWgtUnits.EditValue <= 0 Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Return False
        End If
        If String.IsNullOrEmpty(Me.eWgtUOM.Text) Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Return False
        End If
        If IsDBNull(eWgtUnitCost.EditValue) Or eWgtUnitCost.EditValue <= 0 Then
            MsgBox("You MUST enter valid WEIGHT cost information first.", MsgBoxStyle.Critical, "ERROR - Missing Information")
            Return False
        End If

        If eWgtUnits.EditValue <> oProduct.Stdweight Then
            'MsgBox("The WEIGHT units do not match the LABEL WEIGHT for the Product", MsgBoxStyle.Critical, "ERROR")
            'Return False
            If MsgBox("The Label Weight is not the same as the Standard Weight Units. Do want to save anyway?", MsgBoxStyle.YesNo, "Warning!") = MsgBoxResult.No Then
                Return False
            End If
        End If


        If IsDBNull(eReason.EditValue) Or eReason.EditValue = Nothing Then
            MsgBox("You must enter a reason for the costing changes.", MsgBoxStyle.Critical, "ERROR - Missing Reason for Change")
            Return False
        End If

        Return True
    End Function

    Private Sub rbtnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSave.ItemClick

        If ValidateData() = False Then
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

    Private Sub btnRecalcWeightCost_Click(sender As Object, e As EventArgs) Handles btnRecalcWeightCost.Click
        If IsDBNull(eWgtUnits.EditValue) Or eWgtUnits.EditValue = Nothing Or eWgtUnits.EditValue = 0 Then
            MsgBox("You must enter a value for Weight Units in Container first.", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        If IsDBNull(eVolUnits.EditValue) Or eVolUnits.EditValue = Nothing Or eVolUnits.EditValue = 0 Then
            MsgBox("You must enter a value for Volume Units in Container first.", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        If IsDBNull(eVolUnitCost.EditValue) Or eVolUnitCost.EditValue = Nothing Or eVolUnitCost.EditValue = 0 Then
            MsgBox("You must enter a value for Volume Unit Cost first.", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        Dim vWgtCost As Decimal = 0.0000
        Try
            vWgtCost = (eVolUnits.EditValue * eVolUnitCost.EditValue) / eWgtUnits.EditValue
            eWgtUnitCost.EditValue = vWgtCost
        Catch ex As Exception
            MsgBox("Error in calculating Weight Unit Cost value.", MsgBoxStyle.Critical, "Error - Calculation failed")
        End Try


    End Sub

    Private Sub btnRecalcVolumeCost_Click(sender As Object, e As EventArgs) Handles btnRecalcVolumeCost.Click

        If IsDBNull(eWgtUnits.EditValue) Or eWgtUnits.EditValue = Nothing Or eWgtUnits.EditValue = 0 Then
            MsgBox("You must enter a value for Weight Units in Container first.", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        If IsDBNull(eVolUnits.EditValue) Or eVolUnits.EditValue = Nothing Or eVolUnits.EditValue = 0 Then
            MsgBox("You must enter a value for Volume Units in Container first.", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        If IsDBNull(eWgtUnitCost.EditValue) Or eWgtUnitCost.EditValue = Nothing Or eWgtUnitCost.EditValue = 0 Then
            MsgBox("You must enter a value for Weight Unit Cost first.", MsgBoxStyle.Critical, "Error - Missing Data")
            Exit Sub
        End If

        Dim vVolCost As Decimal = 0.0000
        Try
            vVolCost = (eWgtUnits.EditValue * eWgtUnitCost.EditValue) / eVolUnits.EditValue
            eVolUnitCost.EditValue = vVolCost
        Catch ex As Exception
            MsgBox("Error in calculating Volume Unit Cost value.", MsgBoxStyle.Critical, "Error - Calculation failed")
        End Try


    End Sub
End Class