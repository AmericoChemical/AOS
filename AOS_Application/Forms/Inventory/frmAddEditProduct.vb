Imports AOS.BusinessObjects
Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.ViewInfo

Public Class frmAddEditProduct
    Inherits DevExpress.XtraEditors.XtraForm


    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vFKID As Integer     'foreign key values (passed in by calling form for add mode)
    Public vFKID2 As Integer    'foreign key values (passed in by calling form for add mode)
    Public vFKID3 As Integer    'foreign key values (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vChemID As Integer
    Dim vFlag As Boolean
    Dim vAPISID As Integer

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Product"

    'here is where you dimension your object variables for the form
    Dim oEntity As New Product
    Dim oHazmat As New HazmatsymbolCollection
    Dim oContainers As New ContainerCollection
    'Dim oInvClass As New LookupCollection
    Dim oCustomers As New CustomerCollection
    Dim oUOMV As New ViewUOMByVolumeCollection
    Dim oUOMW As New ViewUOMByWeightCollection
    Dim oChemicals As New ChemicalCollection
    Dim oPkgGroups As New ListPackagegroupCollection
    Dim oProductStatusCodes As New ListProductstatusCollection
    Dim vAuditRuleID As Integer = AuditLogProcessing.cAUDITRULEIDPRICING
    Dim oFulFillment As ViewProductFulfillmentCollection
    Dim vWhatChanged As String
#Region " SECURITY - RIBBON FUNCTIONS "

    Private Sub setRibbonOptions(ByVal vLevel As Integer)
        'used to control visibility of options presented on Ribbon control based on user security level of session
        Dim vPageNum As Integer = 0
        'iterate through the riboon pages and adjust visibility of whole page
        For vPageNum = 0 To Me.RibbonControl1.Pages.Count - 1
            If CInt(Me.RibbonControl1.Pages(vPageNum).Tag) > vLevel Then
                Me.RibbonControl1.Pages(vPageNum).Visible = False
            Else
                Me.RibbonControl1.Pages(vPageNum).Visible = True
                'if page will be visible, then iterate through page groups and adjust visibility of whole group
                Dim grpNum As Integer = 0
                For grpNum = 0 To Me.RibbonControl1.Pages(vPageNum).Groups.Count - 1
                    If CInt(Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Tag) > vLevel Then
                        Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Visible = False
                    Else
                        Me.RibbonControl1.Pages(vPageNum).Groups(grpNum).Visible = True
                    End If
                Next
            End If
        Next
        'have to iterate through individual items separately for whole ribbon and adjust visibility
        Dim itemNum As Integer = 0
        For itemNum = 0 To Me.RibbonControl1.Items.Count - 1
            If CInt(Me.RibbonControl1.Items(itemNum).Tag) > vLevel Then
                Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            Else
                Me.RibbonControl1.Items(itemNum).Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            End If
        Next
    End Sub

#End Region
    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        setRibbonOptions(vCurrentUserSecurityLevel)
        If vCurrentUserSecurityLevel >= 9 Then
            vAPISID = GetAPISID(vID)
            '       rbtnProductApisCosts.Visibility = IIf(vAPISID <> 0, DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)

        Else
            '      rbtnProductApisCosts.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If

        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupTables()
        loadData()
    End Sub

    Private Sub loadLookupTables()

        oHazmat.LoadAll()
        Me.bsHazmat.DataSource = oHazmat

        oContainers.LoadAll()
        Me.bsContainers.DataSource = oContainers

        oCustomers.LoadAll()
        bsCustomers.DataSource = oCustomers

        oUOMV.LoadAll()
        bsUOMVolume.DataSource = oUOMV

        oUOMW.LoadAll()
        bsUOMWeight.DataSource = oUOMW

        oPkgGroups.LoadAll()
        bsPkgGroups.DataSource = oPkgGroups

        oProductStatusCodes.LoadAll()
        bsProductStatusCodes.DataSource = oProductStatusCodes

        oChemicals.LoadAll()
        oChemicals.Sort = "CHEMICALNAME"
        bsChemicalList.DataSource = oChemicals
        eStdCostSource.EditValue = Costing.getProductStandardCostSource(vID)
        If eStdCostSource.EditValue.ToString.Equals("APIS") AndAlso vCurrentUserSecurityLevel >= 9 Then
            rbtnProductApisCosts.Enabled = True
        Else
            rbtnProductApisCosts.Enabled = False
        End If
        If eStdCostSource.EditValue.ToString.Equals("OVERRIDE") Or eStdCostSource.EditValue.ToString.Equals("PURCHASE") Then
            CheckEditOverride.Enabled = True
        Else
            CheckEditOverride.Enabled = False
        End If
        'oFulFillment = getProductFulfillment(vID)
        'If IsDBNull(oFulFillment) Or oFulFillment Is Nothing Then
        '    'vID was null, so no ProductFulfillmentRecords exists yet
        'Else
        '    'There is a Product ID
        '    Select Case oFulFillment.Count
        '        Case 0 'no product fulfillment records
        '            Dim oAPIS As New ApisCollection
        '            'check for ACTIVE ApisC record
        '            oAPIS.Query.Where(oAPIS.Query.Apisstatus.Equal("ACTIVE"), oAPIS.Query.Productid.Equal(vID))
        '            If oAPIS.Query.Load Then
        '                eStdCostSource.EditValue = "APIS"
        '                rbtnProductApisCosts.Enabled = True
        '            Else
        '                rbtnProductApisCosts.Enabled = False
        '                eStdCostSource.EditValue = "PURCHASE"
        '            End If
        '        Case 1 'only one product fulfillment record (most likely "INV")
        '            Select Case oFulFillment(0).Fulfillmenttype
        '                Case "RLBL"
        '                    eStdCostSource.EditValue = "RELABEL"
        '                Case "PORD"
        '                    eStdCostSource.EditValue = "APIS"
        '                    rbtnProductApisCosts.Enabled = True
        '                Case "PRCH"
        '                    eStdCostSource.EditValue = "PURCHASE"
        '                Case Else
        '                    eStdCostSource.EditValue = "PURCHASE"
        '            End Select
        '        Case Else 'More than one product fulfillment record - assume the first record is always INV, so we skip that one and move to the second record
        '            Select Case oFulFillment(1).Fulfillmenttype
        '                Case "RLBL"
        '                    eStdCostSource.EditValue = "RELABEL"
        '                Case "PORD"
        '                    eStdCostSource.EditValue = "APIS"
        '                    rbtnProductApisCosts.Enabled = True
        '                Case "PRCH"
        '                    eStdCostSource.EditValue = "PURCHASE"
        '                Case Else
        '                    eStdCostSource.EditValue = "PURCHASE"
        '            End Select
        '    End Select

        '  End If


    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub
    Private Sub addNewObject()
        oEntity.AddNew()
        oEntity.Createdby = vCurrentUserLogin
        oEntity.Createdtime = Now
        oEntity.Modifyby = vCurrentUserLogin
        oEntity.Modifytime = Now
        oEntity.Inventoryclass = InventoryClass.FULLAVAILABLE
        oEntity.Inventorygrouping = 0
        oEntity.Volumeunits = 0
        oEntity.Volumestandardcost = 0
        oEntity.Weightunits = 0
        oEntity.Weightstandardcost = 0
        oEntity.Productstatus = "PENDING"
        If Not IsDBNull(vChemID) Then
            If vChemID > 0 Then
                Dim oChem As New Chemical
                If oChem.LoadByPrimaryKey(vChemID) Then
                    oEntity.Chemicalid = oChem.Chemicalid
                    oEntity.Productdesc = oChem.Chemicalname
                End If
            End If
        End If
        oEntity.Save()
        vID = oEntity.Productid
        editObject(oEntity.Productid)
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oEntity = New Product
        oEntity.LoadByPrimaryKey(vID)

        Me.bs.DataSource = oEntity

        updateDataHistory()
        getLinkedData(vID)
        setAllFields(oEntity.Productstatus)
    End Sub

    Private Sub getLinkedData(vID As Integer)
        'get Material / Product Link data (if there is any)
        Dim oMatProd As New Materialproduct
        oMatProd.Query.Where(oMatProd.Query.Productid.Equal(vID))
        If oMatProd.Query.Load Then
            Dim oMat As New Material
            oMat.LoadByPrimaryKey(oMatProd.Materialid)
            eMatID.EditValue = oMat.Materialid
            eMaterialDesc.EditValue = oMat.Materialdesc
        End If
    End Sub

    Private Sub updateDataHistory()
        lblCreated.Text = "Created on " & FormatDateTime(oEntity.Createdtime, DateFormat.GeneralDate) & " by " & oEntity.Createdby
        lblModified.Text = "Last Modified on " & FormatDateTime(oEntity.Modifytime, DateFormat.GeneralDate) & " by " & oEntity.Modifyby
    End Sub

    Private Function changesSaved() As Boolean
        bs.EndEdit()

        'determine if changes were made by user to the Product fields of data
        If userMadeChanges() Then
            oEntity.Modifyby = vCurrentUserLogin
            oEntity.Modifytime = Now
        End If
        oEntity.EndEdit()
        Dim oProduct As New Product
        Dim bCostChanged As Boolean = False
        If (oProduct.LoadByPrimaryKey(oEntity.Productid)) Then
            If oProduct.Volumestandardcost <> oEntity.Volumestandardcost Or oProduct.Weightstandardcost <> oEntity.Weightstandardcost Then
                bCostChanged = True
            End If
        End If

        oEntity.Save()
        If bCostChanged Then
            ProcessProductStandardCostChanges(oEntity.Productid, oProduct.Volumestandardcost, oProduct.Weightstandardcost, oEntity.Volumestandardcost, oEntity.Weightstandardcost, vWhatChanged & "-" & oEntity.Productid, "STD COST", oEntity.Productid, "STD COST CHNG-" & oEntity.Productid)

        End If
        Return True
    End Function

    Private Function userMadeChanges() As Boolean

        Dim vFlag As Boolean = False

        If oEntity.es.IsDirty Then
            For Each obj As String In oEntity.es.ModifiedColumns
                If vFlag = False Then
                    Select Case obj.ToString
                        Case "PACKAGEGROUP"
                        Case "HAZCLASSNUMBER"
                        Case "IDNUMBER"
                        Case "HAZMATDESC"
                        Case "UNLINE"
                        Case "VOLUMESTANDARDCOST"
                        Case "WEIGHTSTANDARDCOST"
                        Case Else
                            vFlag = True
                    End Select
                End If
            Next
        End If

        Return vFlag

    End Function


    Private Function changesCancelled() As Boolean
        bs.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oEntity.MarkAsDeleted()
                oEntity.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick


        bs.EndEdit()
        oEntity.EndEdit()

        If bs.Current.Inventorymethod Is Nothing OrElse
           String.IsNullOrEmpty(bs.Current.Inventorymethod) Then
            MsgBox("Inventory Method is required", MsgBoxStyle.Critical, "Save Product - Error")
            eInvMethod.Focus()
            Exit Sub
        End If

        If Not IsDBNull(eLblWeight.EditValue) And Not IsDBNull(eWgtUnits.EditValue) Then
            If eLblWeight.EditValue <> eWgtUnits.EditValue Then
                If MsgBox("The Label Weight does not match the Standard Weight Units. Do you want to save anyway?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
        End If


        'If ValidateCost() = False Then
        '    If MsgBox("Partial pricing data is entered. Are you sure you want to continue?", vbYesNo + vbQuestion) = vbNo Then
        '        SetFocustoFirstNullFieldinPricingMethod()
        '        Exit Sub
        '    End If
        'End If

        'If RaiseAuditEvent(vAuditRuleID, bs, ProductInventoryMethod.VOLUME, vFlag) Then
        '    eVolCost.Focus()
        '    Exit Sub
        'ElseIf RaiseAuditEvent(vAuditRuleID, bs, ProductInventoryMethod.WEIGHT, vFlag) Then
        '    eWgtCost.Focus()
        '    Exit Sub
        'End If

        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Sub SetFocustoFirstNullFieldinPricingMethod()
        If String.IsNullOrEmpty(eVolUnits.Text) Or Val(eVolUnits.Text.ToString()) = 0 Then
            eVolUnits.Focus()
        ElseIf String.IsNullOrEmpty(eVolUOM.Text) Then
            eVolUOM.Focus()
        ElseIf String.IsNullOrEmpty(eVolCost.Text) Or Val(eVolCost.Text.ToString()) = 0 Then
            eVolCost.Focus()
        ElseIf String.IsNullOrEmpty(eWgtUnits.Text) Or Val(eWgtUnits.Text.ToString()) = 0 Then
            eWgtUnits.Focus()
        ElseIf String.IsNullOrEmpty(eWgtUOM.Text) Then
            eWgtUOM.Focus()
        ElseIf String.IsNullOrEmpty(eWgtCost.Text) Or Val(eWgtCost.Text.ToString()) = 0 Then
            eWgtCost.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnViewProductCost_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnViewProductCost.ItemClick
        changesSaved()
        Dim frm As New frmViewProductCostRecords
        frm.vProductID = oEntity.Productid
        frm.ShowDialog()
        editObject(oEntity.Productid)
    End Sub

    Private Function ValidateCost() As Boolean
        'Check whether pricing data has some value
        If (Me.bs.Current.VOLUMESTANDARDCOST > 0 Or
            Me.bs.Current.WEIGHTSTANDARDCOST > 0 Or
            Me.bs.Current.VOLUMEUNITS > 0 Or
            Me.bs.Current.WEIGHTUNITS > 0 Or
            Not String.IsNullOrEmpty(Me.eVolUOM.Text) Or
            Not String.IsNullOrEmpty(Me.eWgtUOM.Text)) Then

            If (Me.bs.Current.VOLUMESTANDARDCOST = 0 Or
                Me.bs.Current.WEIGHTSTANDARDCOST = 0 Or
                Me.bs.Current.VOLUMEUNITS = 0 Or
                Me.bs.Current.WEIGHTUNITS = 0 Or
                String.IsNullOrEmpty(Me.eVolUOM.Text) Or
                String.IsNullOrEmpty(Me.eWgtUOM.Text)) Then
                Return False
            End If

        Else
            Return False
        End If
        Return True
    End Function

    Private Sub btnRecalcVolumeCost_Click(sender As Object, e As EventArgs)
        If IsInitializing = False Then
            AuditCheckPriceForLowPrice(eWgtCost, ProductInventoryMethod.WEIGHT, eVolUnits, eVolCost, eWgtUnits, eWgtCost, bs, vAuditRuleID, vFlag, CalledFrom.PRODUCT)
        End If
    End Sub

    Private Sub btnRecalcWeightCost_Click(sender As Object, e As EventArgs)
        If IsInitializing = False Then
            AuditCheckPriceForLowPrice(eVolCost, ProductInventoryMethod.VOLUME, eVolUnits, eVolCost, eWgtUnits, eWgtCost, bs, vAuditRuleID, vFlag, CalledFrom.PRODUCT)
        End If
    End Sub

    Private Sub btnProductFulfillment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnProductFulfillment.ItemClick

        'Need to save changes before moving to fulfillment priority
        changesSaved()
        Dim frm As New frmviewProductFulfillment
        frm.vPID = Me.bs.Current.productID
        frm.ShowDialog()
    End Sub

    Private Sub eChemID_EditValueChanged(sender As Object, e As EventArgs) Handles eChemID.EditValueChanged
        If IsDBNull(eChemID.EditValue) Then
            setChemicalFields(0)
            Exit Sub
        End If
        If eChemID.EditValue > 0 Then
            setChemicalFields(eChemID.EditValue)
        Else
            setChemicalFields(0)
        End If
    End Sub

    Private Sub setChemicalFields(vChemid As Integer)

        If vChemid = 0 Then

            eChemName.Text = ""
            If oEntity.Productstatus <> "INACTIVE" Then
                setDOTFields("EDIT")
            End If
            Exit Sub
        End If

        Dim vVolume As Decimal = 0
        Dim oChem As New Chemical
        If oChem.LoadByPrimaryKey(vChemid) Then
            Select Case oChem.Usenonregdot
                Case True
                    Dim oParm As New Sysparameters
                    oParm.LoadByPrimaryKey(1)
                    vVolume = IIf(IsDBNull(eVolUnits.EditValue), 0, eVolUnits.EditValue)
                    If vVolume <= oParm.MaxVolumeForNonRegDOT Then
                        eDOTDesc.EditValue = "NOT REGULATED AS DANGEROUS GOODS"
                        eHazmatDesc.EditValue = Nothing
                        eHazmatID.EditValue = 1
                        eUNLine.EditValue = Nothing
                        eIDNumber.EditValue = Nothing
                        eHazMatClassNumber.EditValue = Nothing
                        ePkgGroup.EditValue = Nothing
                    Else
                        eDOTDesc.EditValue = oChem.Dotdesc
                        eHazmatDesc.EditValue = oChem.Hazmatdesc
                        eHazmatID.EditValue = oChem.Hazmatid
                        eUNLine.EditValue = oChem.Unline
                        eIDNumber.EditValue = oChem.Idnumber
                        eHazMatClassNumber.EditValue = oChem.Hazclassnumber
                        ePkgGroup.EditValue = oChem.Packagegroup
                    End If
                    eChemName.Text = oChem.Chemicalname
                    eProductDesc.EditValue = oChem.Chemicalname
                    eHealth.EditValue = oChem.Health
                    eFire.EditValue = oChem.Fire
                    eReactivity.EditValue = oChem.Reactivity
                    ePersonalProtection.EditValue = oChem.Personalprotection
                    eProductDesc.EditValue = oChem.Chemicalname
                    bs.EndEdit()
                    setDOTFields("READONLY")
                Case False
                    eChemName.Text = oChem.Chemicalname
                    eProductDesc.EditValue = oChem.Chemicalname
                    eHealth.EditValue = oChem.Health
                    eFire.EditValue = oChem.Fire
                    eReactivity.EditValue = oChem.Reactivity
                    ePersonalProtection.EditValue = oChem.Personalprotection
                    eDOTDesc.EditValue = oChem.Dotdesc
                    eHazmatDesc.EditValue = oChem.Hazmatdesc
                    eHazmatID.EditValue = oChem.Hazmatid
                    eUNLine.EditValue = oChem.Unline
                    eIDNumber.EditValue = oChem.Idnumber
                    eHazMatClassNumber.EditValue = oChem.Hazclassnumber
                    ePkgGroup.EditValue = oChem.Packagegroup
                    eProductDesc.EditValue = oChem.Chemicalname
                    bs.EndEdit()
                    setDOTFields("READONLY")
            End Select

        End If

    End Sub

    Private Sub setDOTFields(vChemStatus As String)
        Select Case vChemStatus
            Case "EDIT"
                eHealth.Properties.ReadOnly = False
                eFire.Properties.ReadOnly = False
                eReactivity.Properties.ReadOnly = False
                ePersonalProtection.Properties.ReadOnly = False
                eDOTDesc.Properties.ReadOnly = False
                eHazmatDesc.Properties.ReadOnly = False
                eHazmatID.Properties.ReadOnly = False
                eUNLine.Properties.ReadOnly = False
                eIDNumber.Properties.ReadOnly = False
                eHazMatClassNumber.Properties.ReadOnly = False
                ePkgGroup.Properties.ReadOnly = False
                eProductDesc.Properties.ReadOnly = False
            Case "READONLY"
                eHealth.Properties.ReadOnly = True
                eFire.Properties.ReadOnly = True
                eReactivity.Properties.ReadOnly = True
                ePersonalProtection.Properties.ReadOnly = True
                eDOTDesc.Properties.ReadOnly = True
                eHazmatDesc.Properties.ReadOnly = True
                eHazmatID.Properties.ReadOnly = True
                eUNLine.Properties.ReadOnly = True
                eIDNumber.Properties.ReadOnly = True
                eHazMatClassNumber.Properties.ReadOnly = True
                ePkgGroup.Properties.ReadOnly = True
                eProductDesc.Properties.ReadOnly = True
        End Select
    End Sub

    Private Sub setAllFields(vStatus As String)
        Select Case vStatus
            Case "INACTIVE"
                'disable key ribbon buttons
                rbtnAssignChemical.Enabled = False
                btnProductFulfillment.Enabled = False

                'make all data entry fields READONLY
                eAddnDesc.Properties.ReadOnly = True
                eContainer.Properties.ReadOnly = True
                eRQ.Properties.ReadOnly = True
                eClassRate.Properties.ReadOnly = True
                eVendorNotes.Properties.ReadOnly = True
                eReceivingNotes.Properties.ReadOnly = True
                eLblWeight.Properties.ReadOnly = True
                eLblUOM.Properties.ReadOnly = True
                eLblUnits.Properties.ReadOnly = True
                eLblGallons.Properties.ReadOnly = True
                eInvMethod.Properties.ReadOnly = True
                eInvGroup.Properties.ReadOnly = True
                eReorderQty.Properties.ReadOnly = True
                eMinimumOnHand.Properties.ReadOnly = True
                luCustomers.Properties.ReadOnly = True
                'eVolUnits.Properties.ReadOnly = True
                'eVolUOM.Properties.ReadOnly = True
                'eVolCost.Properties.ReadOnly = True
                'eWgtUnits.Properties.ReadOnly = True
                'eWgtUOM.Properties.ReadOnly = True
                'eWgtCost.Properties.ReadOnly = True
                setDOTFields("READONLY")
            Case Else
                rbtnAssignChemical.Enabled = True
                btnProductFulfillment.Enabled = True
                'make all data entry fields EDITABLE (with the exception of DOT fields, which are controlled by another sub)
                eAddnDesc.Properties.ReadOnly = False
                eContainer.Properties.ReadOnly = False
                eRQ.Properties.ReadOnly = False
                eClassRate.Properties.ReadOnly = False
                eVendorNotes.Properties.ReadOnly = False
                eReceivingNotes.Properties.ReadOnly = False
                eLblWeight.Properties.ReadOnly = False
                eLblUOM.Properties.ReadOnly = False
                eLblUnits.Properties.ReadOnly = False
                eLblGallons.Properties.ReadOnly = False
                eInvMethod.Properties.ReadOnly = False
                eInvGroup.Properties.ReadOnly = False
                eReorderQty.Properties.ReadOnly = False
                eMinimumOnHand.Properties.ReadOnly = False
                luCustomers.Properties.ReadOnly = False
                'eVolUnits.Properties.ReadOnly = False
                'eVolUOM.Properties.ReadOnly = False
                'eVolCost.Properties.ReadOnly = False
                'eWgtUnits.Properties.ReadOnly = False
                'eWgtUOM.Properties.ReadOnly = False
                'eWgtCost.Properties.ReadOnly = False
        End Select
    End Sub

    Private Sub rbtnChangeProductStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangeProductStatus.ItemClick

        changesSaved()

        Dim vNewStatus As String = getStatusValue("PRODUCT")

        If vNewStatus = Nothing Then
            Exit Sub
        End If

        If vNewStatus = bs.Current.ProductStatus Then
            MsgBox("The Product is already marked with the same status you selected.", MsgBoxStyle.Information, "No Change")
            Exit Sub
        End If

        bs.EndEdit()
        oEntity.Save()

        Select Case vNewStatus
            Case "ACTIVE"
                updateProductStatus(oEntity.Productid, "ACTIVE")
                editObject(oEntity.Productid)
            Case "INACTIVE"
                updateProductStatus(oEntity.Productid, "INACTIVE")
                editObject(oEntity.Productid)
            Case "PENDING"
                updateProductStatus(oEntity.Productid, "PENDING")
                editObject(oEntity.Productid)
        End Select
        editObject(oEntity.Productid)


    End Sub

    Private Sub rbtnViewPrintSDSDocument_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnViewPrintSDSDocument.ItemClick
        viewPrintSDSDocumentByProduct(vID)
    End Sub

    Private Sub rbtnAssignChemical_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAssignChemical.ItemClick

        bs.EndEdit()
        oEntity.Save()

        Dim frm As New frmAssignChemical
        If IsDBNull(eChemID.EditValue) Then
            frm.vChemicalID = 0
        Else
            frm.vChemicalID = eChemID.EditValue
        End If
        frm.ShowDialog()
        eChemID.EditValue = frm.vChemicalID

    End Sub

    Private Sub rbtnChangeStandardCosts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangeStandardCosts.ItemClick
        changesSaved()

        Dim frm As New frmUpdateProductStandardCosts
        frm.vProductID = bs.Current.ProductID
        frm.ShowDialog()
        editObject(bs.Current.ProductID)
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub rbtnProductSales_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnProductSales.ItemClick
        Dim frm As New frmProductBuyersList
        frm.vID = vID
        frm.ShowDialog()
    End Sub

    Private Sub rbtnProductPurchases_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnProductPurchases.ItemClick
        Dim frm As New frmProductSellersList
        frm.vID = vID
        frm.ShowDialog()
    End Sub

    Private Sub rbtnProductApisCosts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnProductApisCosts.ItemClick
        If vAPISID <> 0 Then
            Dim frm As New frmApisStandardCosts
            frm.vAPISID = vAPISID
            frm.ShowDialog()
            editObject(bs.Current.ProductID)
            Exit Sub

        End If

    End Sub

    Private Function GetAPISID(prodctId As Integer) As Integer
        Dim oAPIS As New ApisCollection
        'check for ACTIVE ApisC record
        oAPIS.Query.Where(oAPIS.Query.Apisstatus.Equal("ACTIVE"), oAPIS.Query.Productid.Equal(prodctId))
        If oAPIS.Query.Load Then
            GetAPISID = oAPIS(0).Apisnum
            Exit Function
        End If

        'check for SINGLE USE Apis record
        oAPIS.Query.Where(oAPIS.Query.Apisstatus.Equal("SINGLE USE"), oAPIS.Query.Productid.Equal(prodctId))
        If oAPIS.Query.Load Then
            GetAPISID = oAPIS(0).Apisnum
            Exit Function
        End If
        GetAPISID = 0
    End Function

    'Private Sub CheckEdit3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit3.CheckedChanged
    '    rbtnChangeStandardCosts.Enabled = CheckEdit3.Checked
    'End Sub

    'Private Sub CheckEdit3_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckEdit3.CheckStateChanged
    '    rbtnChangeStandardCosts.Enabled = CheckEdit3.Checked

    'End Sub

    Private Sub CheckEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles CheckEditOverride.EditValueChanged
        rbtnChangeStandardCosts.Enabled = CheckEditOverride.Checked
        If CheckEditOverride.Checked Then
            eStdCostSource.Text = "OVERRIDE"
        Else
            eStdCostSource.Text = "PURCHASE"
        End If

    End Sub

    Private Sub CheckEditOverride_Click(sender As Object, e As EventArgs) Handles CheckEditOverride.Click
        ' Check against the original below before click
        ''TODO: How to get the new value after click
        Dim chkEdit As CheckEdit = sender
        If chkEdit.Checked Then
            If MsgBox("Std Costs will be overwritten with Vendor Costs, Continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '        'Dim vOldVolCost As Decimal = IIf(IsDBNull(oApisCost.Oldvolcost), 0, oApisCost.Oldvolcost)
                '        'Dim vOldWtCost As Decimal = IIf(IsDBNull(oApisCost.Oldwgtcost), 0, oApisCost.Oldwgtcost)

                If (SetStandardCostToVendorCost(oEntity)) Then
                    eVolUnits.Text = oEntity.Volumeunits
                    eVolUOM.Text = oEntity.Volumeuom
                    eVolCost.Text = oEntity.Volumestandardcost
                    eWgtUnits.Text = oEntity.Weightunits
                    eWgtUOM.Text = oEntity.Weightuom
                    eWgtCost.Text = oEntity.Weightstandardcost
                    vWhatChanged = "Override Unchecked"
                    CheckEditOverride.Checked = False
                Else
                    MsgBox("Std Cost could not be set to Vendor Costs, Continue?", MsgBoxStyle.OkOnly)
                    CheckEditOverride.Checked = True
                End If
            Else
                CheckEditOverride.Checked = True
            End If
        End If
        '  Me.bs.DataSource = oEntity
    End Sub
End Class