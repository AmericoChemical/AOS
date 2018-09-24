Imports AOS.BusinessObjects

Public Class frmViewComponentCostRecords
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vComponentID As Integer       'object primary key (passed in by calling form for edit mode)
    Dim oCosts As New ComponentcostCollection
    Dim oComponent As New Component
    Public oCost As Componentcost
    Public oVendors As VendorCollection
    '   Dim oFulfillment As ViewProductFulfillmentCollection
    '  Dim oAPISList As ApisCollection
    '  Dim vStdCostSource As String = Nothing

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        getComponentCostData()
        getVendors()
        getComponentData()
    End Sub

    Private Sub checkDefaultCostData()
        Dim oCost As New ComponentcostCollection
        oCost.Query.Where(oCost.Query.ComponentId.Equal(vComponentID), oCost.Query.IsDefault.Equal(1))
        If oCost.Query.Load Then
            If oCost.Count = 1 Then
                Select Case CompareStandardCostToComponentCostRecord(vComponentID, oCost(0).ComponentCostId)
                    Case 0 'Standard Costs do NOT match Default Costs
                        rbtnUpdateStdCost.Enabled = True
                    Case 1 'Standard Costs MATCH Default Costs
                        rbtnUpdateStdCost.Enabled = False
                    Case 2 'Missing data from Standard Costs and/or Default Costs
                        MsgBox("There is missing data in the Component STANDARD COST and/or Default Component COST records", MsgBoxStyle.Critical, "WARNING!")
                        rbtnUpdateStdCost.Enabled = True
                    Case Else 'Something went wrong
                        rbtnUpdateStdCost.Enabled = False
                End Select
            Else
                MsgBox("There is more than one Component COST record marked as the DEFAULT. Can't compare to STANDARD COSTS", MsgBoxStyle.Critical, "DATA ERROR")
            End If
        Else
            MsgBox("There is no Component COST record marked as the DEFAULT. Can't compare to STANDARD COSTS", MsgBoxStyle.Critical, "DATA ERROR")
        End If
    End Sub


    Private Sub getVendors()
        oVendors = getVendorCollection()
        bsVendors.DataSource = oVendors
    End Sub
    Private Sub getComponentData()
        oComponent = oComponent.getComponentByComponentID(vComponentID)
        bsComponent.DataSource = oComponent
        lblComponentInfo.Text = oComponent.Componentid & " - " & oComponent.Componentdesc '& " - " & oProduct.Container
        'bTxtVolumeUnits.Caption = IIf(IsDBNull(oProduct.Volumeunits), DBNull.Value, oProduct.Volumeunits)
        'bTxtVolumeUOM.Caption = IIf(IsDBNull(oProduct.Volumeuom), DBNull.Value, oProduct.Volumeuom)
        'bTxtlVolumeStandardCost.Caption = IIf(IsDBNull(oProduct.Volumestandardcost), DBNull.Value, oProduct.Volumestandardcost)
        'bTxtWeightUnits.Caption = IIf(IsDBNull(oProduct.Weightunits), DBNull.Value, oProduct.Weightunits)
        'bTxtWeightUOM.Caption = IIf(IsDBNull(oProduct.Weightuom), DBNull.Value, oProduct.Weightuom)
        'bTxtWeightStandardCost.Caption = IIf(IsDBNull(oProduct.Weightstandardcost), DBNull.Value, oProduct.Weightstandardcost)


    End Sub


    Private Sub getComponentCostData()
        oCosts = oCosts.GetComponentCostCollectionByComponentId(vComponentID)
        bsComponentCost.DataSource = oCosts

    End Sub

    Private Sub btnNewCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewCostRecord.ItemClick
        AddNewComponentCostRecord(bsComponent.Current.ComponentID)
        getComponentCostData()
    End Sub

    Public Sub AddNewComponentCostRecord(ByVal componentID As Integer)
        Using frm As New frmUpdateComponentUnitCost() With
            {
                .vComponentID = componentID,
                .vAddtype = "NEW"
            }
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnEditCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditCostRecord.ItemClick
        If bsComponentCost.Count <= 0 Then
            Exit Sub
        End If
        EditComponentCostRecord(bsComponentCost.Current.componentId, bsComponentCost.Current.ComponentCostId)
        getComponentCostData()
    End Sub

    Public Sub EditComponentCostRecord(ByVal ComponentID As Integer, ByVal ComponentCostID As Integer)
        Using frm As New frmUpdateComponentUnitCost() With
            {
                .vComponentId = ComponentID,
                .vAddtype = "EDIT",
                .vCostID = ComponentCostID
            }
            frm.ShowDialog()
        End Using
    End Sub
    Private Sub btnDeleteCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteCostRecord.ItemClick
        If bsComponentCost.Count <= 0 Then
            Exit Sub
        End If
        'If bs.Count = 1 Then
        '    MsgBox("You cannot delete the only cost record for a product. Edit the existing cost record or add a new cost record.", MsgBoxStyle.Critical, "Error")
        '    Exit Sub
        'End If

        DeleteComponentCostRecord(bsComponentCost.Current.ComponentCostId)
        getComponentCostData()
    End Sub

    Public Sub DeleteComponentCostRecord(ByVal ComponentCostId As Integer)
        Try
            Dim oCostRec As Componentcost = New Componentcost

            Using updateTransaction As New Transactions.TransactionScope
                updateTransaction.Complete()
            End Using

            oCostRec.LoadByPrimaryKey(ComponentCostId)
            oCostRec.MarkAsDeleted()
            oCostRec.Save()
        Catch ex As Exception
            MsgBox("Error in deleting selected record", MsgBoxStyle.Critical, "Error - Delete Failed")
            Exit Sub
        End Try
        MsgBox("Component Cost record successfully deleted.")
    End Sub

    Private Sub btnSelect_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelect.ItemClick
        If oCosts.Count <= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            oCost = New Componentcost
            oCost.LoadByPrimaryKey(bsComponentCost.Current.costRecID)
            If oCost Is Nothing Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub rbtnUpdateStdCost_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUpdateStdCost.ItemClick

        Dim oCost As New Componentcost
        If Not oCost.LoadByPrimaryKey(bsComponentCost.Current.CostRecID) Then
            MsgBox("Could not retrieve selected Cost Record", MsgBoxStyle.Critical, "Data Error")
            Exit Sub
        End If


        Dim vUnitCost As Decimal = 0

        vUnitCost = IIf(IsDBNull(oCost.UnitCost), 0, oCost.UnitCost)
        '        updateStandardCostingFromVendorCostChange(oCost.ComponentId, vVolUnits, vVolUOM, vVolUnitCost, vWgtUnits, vWgtUOM, vWgtUnitCost, "Vendor Cost Updated", "STANDARD COST", oCost.Productid)
        updateStandardCostingFromVendorComponentCostChange(oCost.ComponentId, vUnitCost, "Vendor Cost Updated", "STANDARD COST", oCost.ComponentId, "COMP COST CHNG-" & oCost.ComponentId)
        'getComponentStandardCostSource()

        'If RaiseAuditEvent(vAuditRuleID, bsProductCost, PricingMethod.VOLUME, vFlag) Then
        '    eVolUnitCost.Focus()
        '    Exit Sub
        'ElseIf RaiseAuditEvent(vAuditRuleID, bsProductCost, PricingMethod.WEIGHT, vFlag) Then
        '    eWgtUnitCost.Focus()
        '    Exit Sub
        'End If

    End Sub

    Private Sub rbtnMakeCostRecordDefault_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMakeCostRecordDefault.ItemClick
        If bsComponentCost.Count <= 0 Then
            Exit Sub
        End If

        'get selected Cost Record ID
        Dim vRecID As Integer = bsComponentCost.Current.CostRecID

        'Clear all default settings for the current Product ID
        Dim oCosts As New ComponentcostCollection
        oCosts.Query.Where(oCosts.Query.ComponentId.Equal(vComponentID))
        If oCosts.Query.Load Then
            For Each oCost As Componentcost In oCosts
                oCost.IsDefault = False
            Next
            oCosts.Save()
        End If

        Dim oDefCost As New Componentcost
        If oDefCost.LoadByPrimaryKey(vRecID) Then
            oDefCost.IsDefault = True
            oDefCost.Save()
        End If

        getComponentCostData()
        '     getComponentStandardCostSource()

    End Sub
End Class