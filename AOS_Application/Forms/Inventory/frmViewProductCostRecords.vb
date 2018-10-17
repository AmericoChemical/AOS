Imports AOS.BusinessObjects
Imports DevExpress.Data

Public Class frmViewProductCostRecords
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductID As Integer       'object primary key (passed in by calling form for edit mode)
    Dim oCosts As New ProductcostCollection
    Dim oProduct As New Product
    Public oCost As Productcost
    Public oVendors As VendorCollection
    Dim vStdCostSource As String = Nothing

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        getProductCostData()
        getVendors()
        getProductData()
    End Sub

    Private Sub checkDefaultCostData(ByVal vStdCostSource As String)

        Dim oProduct As New Product

        Select Case vStdCostSource
            Case "OVERRIDE"
                rbtnUpdateStdCost.Enabled = False
                rbtnUpdateStdCost.Hint = "The Product STANDARD COST is marked Override. It cannot be overwritten by Vednor Cost"
            Case Else
                Dim oCost As New ProductcostCollection
                oCost.Query.Where(oCost.Query.Productid.Equal(vProductID), oCost.Query.Isdefaultcostrecord.Equal(1))
                If oCost.Query.Load Then
                    If oCost.Count = 1 Then
                        Select Case CompareStandardCostToProductCostRecord(vProductID, oCost(0).Costrecid)
                            Case 0 'Standard Costs do NOT match Default Costs
                                rbtnUpdateStdCost.Enabled = True
                                rbtnUpdateStdCost.Hint = "The Product STANDARD COSTs Do Not Match Default costs. Click to Update."
                            Case 1 'Standard Costs MATCH Default Costs
                                rbtnUpdateStdCost.Enabled = False
                                rbtnUpdateStdCost.Hint = "The Product STANDARD COSTs Match Default costs. Nothing to Update."
                            Case 2 'Missing data from Standard Costs and/or Default Costs
                                MsgBox("There is missing data in the Product STANDARD COST and/or Default PRODUCT COST records", MsgBoxStyle.Critical, "WARNING!")
                                rbtnUpdateStdCost.Enabled = True
                            Case Else 'Something went wrong
                                rbtnUpdateStdCost.Enabled = False
                                rbtnUpdateStdCost.Hint = "Something went wrong"
                        End Select
                    Else
                        MsgBox("There is more than one PRODUCT COST record marked as the DEFAULT. Can't compare to STANDARD COSTS", MsgBoxStyle.Critical, "DATA ERROR")
                    End If
                Else
                    MsgBox("There is no PRODUCT COST record marked as the DEFAULT. Can't compare to STANDARD COSTS", MsgBoxStyle.Critical, "DATA ERROR")
                End If
        End Select

    End Sub


    Private Sub getVendors()
        oVendors = getVendorCollection()
        bsVendors.DataSource = oVendors
    End Sub
    Private Sub getProductData()
        oProduct = getProductByProductID(vProductID)
        bsProduct.DataSource = oProduct
        lblproductInfo.Text = oProduct.Productid & " - " & oProduct.Productdesc & " - " & oProduct.Container
        bTxtVolumeUnits.Caption = IIf(IsDBNull(oProduct.Volumeunits), DBNull.Value, oProduct.Volumeunits)
        bTxtVolumeUOM.Caption = IIf(IsDBNull(oProduct.Volumeuom), DBNull.Value, oProduct.Volumeuom)
        bTxtlVolumeStandardCost.Caption = IIf(IsDBNull(oProduct.Volumestandardcost), DBNull.Value, oProduct.Volumestandardcost)
        bTxtWeightUnits.Caption = IIf(IsDBNull(oProduct.Weightunits), DBNull.Value, oProduct.Weightunits)
        bTxtWeightUOM.Caption = IIf(IsDBNull(oProduct.Weightuom), DBNull.Value, oProduct.Weightuom)
        bTxtWeightStandardCost.Caption = IIf(IsDBNull(oProduct.Weightstandardcost), DBNull.Value, oProduct.Weightstandardcost)

        getProductStandardCostSource()

    End Sub

    Private Sub getProductStandardCostSource()

        vStdCostSource = Costing.getProductStandardCostSource(vProductID)
        checkDefaultCostData(vStdCostSource)
        lblStdCostType.Caption = vStdCostSource

    End Sub


    Private Sub getProductCostData()
        oCosts = getProductCostDataCollectionsByProductID(vProductID)
        bs.DataSource = oCosts

    End Sub

    Private Sub btnNewCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNewCostRecord.ItemClick
        AddNewCostRecord(bsProduct.Current.productID)
        getProductCostData()
    End Sub

    Private Sub btnEditCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditCostRecord.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If
        EditCostRecord(bs.Current.productID, bs.Current.costRecID)
        getProductCostData()
    End Sub

    Private Sub btnDeleteCostRecord_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteCostRecord.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If
        If bs.Count = 1 Then
            MsgBox("You cannot delete the only cost record for a product. Edit the existing cost record or add a new cost record.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        DeleteCostRecord(bs.Current.costRecID)
        getProductCostData()
    End Sub

    Private Sub btnSelect_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSelect.ItemClick
        If oCosts.Count <= 0 Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Else
            oCost = New Productcost
            oCost.LoadByPrimaryKey(bs.Current.costRecID)
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

    ' This should never be called, button should be disabled 
    Private Sub rbtnUpdateStdCost_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnUpdateStdCost.ItemClick

        Dim oCost As New Productcost
        If Not oCost.LoadByPrimaryKey(bs.Current.CostRecID) Then
            MsgBox("Could not retrieve selected Cost Record", MsgBoxStyle.Critical, "Data Error")
            Exit Sub
        End If


        Dim vVolUnits As Decimal = 0
        Dim vVolUnitCost As Decimal = 0
        Dim vWgtUnits As Decimal = 0
        Dim vWgtUnitCost As Decimal = 0
        Dim vVolUOM As String = ""
        Dim vWgtUOM As String = ""


        If IsDBNull(oCost.Volumeunits) Or oCost.Volumeunits Is Nothing Then
            vVolUnits = 0
        Else
            vVolUnits = oCost.Volumeunits
        End If

        If IsDBNull(oCost.Weightunits) Or oCost.Weightunits Is Nothing Then
            vWgtUnits = 0
        Else
            vWgtUnits = oCost.Weightunits
        End If


        vVolUnitCost = IIf(IsDBNull(oCost.Volumestandardcost), 0, oCost.Volumestandardcost)
        vWgtUnitCost = IIf(IsDBNull(oCost.Weightstandardcost), 0, oCost.Weightstandardcost)
        vVolUOM = IIf(IsDBNull(oCost.Volumeuom), "", oCost.Volumeuom)
        vWgtUOM = IIf(IsDBNull(oCost.Weightuom), "", oCost.Weightuom)

        updateStandardCostingFromVendorCostChange(oCost.Productid, vVolUnits, vVolUOM, vVolUnitCost, vWgtUnits, vWgtUOM, vWgtUnitCost, "Vendor Cost Updated", "STANDARD COST", oCost.Productid, "VNDR COST CHNG-" & vProductID)

        getProductStandardCostSource()

        'If RaiseAuditEvent(vAuditRuleID, bsProductCost, PricingMethod.VOLUME, vFlag) Then
        '    eVolUnitCost.Focus()
        '    Exit Sub
        'ElseIf RaiseAuditEvent(vAuditRuleID, bsProductCost, PricingMethod.WEIGHT, vFlag) Then
        '    eWgtUnitCost.Focus()
        '    Exit Sub
        'End If

    End Sub

    Private Sub rbtnMakeCostRecordDefault_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMakeCostRecordDefault.ItemClick
        If bs.Count <= 0 Then
            Exit Sub
        End If

        'get selected Cost Record ID
        Dim vRecID As Integer = bs.Current.CostRecID

        ''Clear all default settings for the current Product ID
        'Dim oCosts As New ProductcostCollection
        'oCosts.Query.Where(oCosts.Query.Productid.Equal(vProductID))
        'If oCosts.Query.Load Then
        '    For Each oCost As Productcost In oCosts
        '        oCost.Isdefaultcostrecord = 0
        '    Next
        '    oCosts.Save()
        'End If

        'Dim oDefCost As New Productcost
        'If oDefCost.LoadByPrimaryKey(vRecID) Then
        '    oDefCost.Isdefaultcostrecord = 1
        '    oDefCost.Save()
        'End If
        'SetProductStatndardCosts(vProductID, "Default Vendor Cost changed. PROD ID-" & vProductID)

        If MarkVendorProductCostAsDefault(vRecID) Then

            getProductCostData()
            getProductStandardCostSource()
        End If

    End Sub

    Private Sub bs_CurrentChanged(sender As Object, e As EventArgs) Handles bs.CurrentChanged
        If Not bs.Current Is Nothing Then
            Dim oProductCost As Productcost = bs.Current
            rbtnMakeCostRecordDefault.Enabled = Not oProductCost.Isdefaultcostrecord
        End If

    End Sub
End Class