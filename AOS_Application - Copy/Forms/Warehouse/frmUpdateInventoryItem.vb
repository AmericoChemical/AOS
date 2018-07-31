Imports AOS.BusinessObjects

Public Class frmUpdateInventoryItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vInvitemnumber As Integer
    Public oInvitem As Invitem
    Public vContainerWeight As Decimal
    Public vPallet As String
    Public vContainer As String
    Public vSource As String

    Dim oContainer As New Container


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupData()
        loadData()
    End Sub

    Private Sub loadLookupData()
        Dim oContainerTypes As New ListContainertypeCollection
        oContainerTypes.LoadAll()
        oContainerTypes.Sort = "CONTAINERTYPE"
        bsContainerType.DataSource = oContainerTypes

        Dim oPalletTypes As New ListPallettypeCollection
        oPalletTypes.LoadAll()
        oPalletTypes.Sort = "PALLETWEIGHT DESC"
        bsPalletType.DataSource = oPalletTypes


    End Sub

    Private Sub loadData()
        If vInvitemnumber <= 0 Then
            Exit Sub
        End If
        oInvitem = New Invitem
        oInvitem.LoadByPrimaryKey(vInvitemnumber)
        bsInventoryItem.DataSource = oInvitem

        Dim oProduct As New Product
        If oProduct.LoadByPrimaryKey(oInvitem.Productid) Then
            eReceivingNotes.EditValue = oProduct.Receivingnotes
        End If

        Select Case vSource
            Case "INDIVIDUAL"
                eContainerType.Properties.ReadOnly = False
                ePalletType.Properties.ReadOnly = False
                eScaleWeight.Properties.ReadOnly = False
            Case "MULTIPLE"
                eContainerType.EditValue = vContainer
                ePalletType.EditValue = vPallet
                eScaleWeight.EditValue = vContainerWeight
                eContainerType.Properties.ReadOnly = True
                ePalletType.Properties.ReadOnly = True
                eScaleWeight.Properties.ReadOnly = True
        End Select


        If bsInventoryItem.Current.Itemstatus = InventoryItemStatus.RCVDHOLD.ToString() Then
            eLotNumber.Properties.ReadOnly = True
            eVendorLabelWeight.Properties.ReadOnly = True
            eScaleWeight.Properties.ReadOnly = True
            btnSave.Enabled = False
        End If

        eLotNumber.Focus()

    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Function changesSaved() As Boolean

        'Dim vWeightofcontent As Integer
        'Dim vStdweight As Integer

        Select Case verifyReceivingEntries()
            Case 0
                'Item failed one or more validity checks - Item was added to RECEIVED/HOLD 
                Return True
            Case 1
                'Item passed all validity checks - receive Item into Inventory and update Purchasing Records to reflect the event.
                updateReceivedPurchaseItem(bsInventoryItem.Current.Invitemnumber)
                Return True
            Case 2
                'Missing data - try again
                Return False
            Case Else

        End Select

        Return True



        'Select Case validateControls(vWeightofcontent, vStdweight)
        '    Case 0
        '        'put inventory item into a RECEIVED HOLD - gross scale weight exceeds allowable difference from product standards
        '        updateInvItemRcvdWeightAndStatus(bsInventoryItem.Current.Invitemnumber, vWeightofcontent, bsInventoryItem.Current.LOTNUMBER, bsInventoryItem.Current.VendorWeight, InventoryItemStatus.RCVDHOLD.ToString(), "DOCK-SCALE WEIGHT", "Scale Weight = " + eScaleWeight.EditValue.ToString)
        '    Case 1
        '        'put inventory item into a RECEIVED HOLD - Vendor Label Weight mismatch
        '        updateInvItemRcvdWeightAndStatus(bsInventoryItem.Current.Invitemnumber, vWeightofcontent, bsInventoryItem.Current.LOTNUMBER, bsInventoryItem.Current.VendorWeight, InventoryItemStatus.RCVDHOLD.ToString(), "DOCK-LABEL WEIGHT", "Vendor Label Weight = " + eVendorLabelWeight.EditValue.ToString)
        '    Case 2
        '        Return False

        '    Case Else
        'receivePurchaseItem(bsInventoryItem.Current.Invitemnumber,
        '                            bsInventoryItem.Current.LOTNUMBER,
        '                            bsInventoryItem.Current.VendorWeight)
        'End Select

        'Return True
    End Function

    Private Function verifyReceivingEntries() As Integer

        If IsDBNull(eContainerType.EditValue) OrElse eContainerType.EditValue = Nothing Then
            MsgBox("You must Select a Container Type.", MsgBoxStyle.Critical, "Error - Missing Container Type")
            eContainerType.Focus()
            Return 2
        End If

        If IsDBNull(ePalletType.EditValue) OrElse ePalletType.EditValue = Nothing Then
            MsgBox("You must Select a Pallet Type.", MsgBoxStyle.Critical, "Error - Missing Pallet Type")
            ePalletType.Focus()
            Return 2
        End If

        If IsDBNull(eLotNumber.EditValue) OrElse eLotNumber.EditValue = Nothing Then
            MsgBox("You must enter a Lot Number update this inventory item, ", MsgBoxStyle.Critical, "Error - Missing Lot Number")
            eLotNumber.Focus()
            Return 2
        End If


        If IsDBNull(eVendorLabelWeight.EditValue) OrElse eVendorLabelWeight.EditValue = Nothing Then
            MsgBox("You must enter a Vendor Label Weight To update this inventory item, ", MsgBoxStyle.Critical, "Error - Missing Vendor Label Weight")
            eVendorLabelWeight.Focus()
            Return 2
        End If

        If eVendorLabelWeight.EditValue <= 0 Then
            MsgBox("You must enter a Vendor Label Weight greater than zero", MsgBoxStyle.Critical, "Error - Invalid Vendor Label Weight")
            eVendorLabelWeight.Focus()
            Return 2
        End If

        If IsDBNull(eScaleWeight.EditValue) OrElse eScaleWeight.EditValue Is Nothing OrElse eScaleWeight.EditValue <= 0 Then
            MsgBox("Scale Weight Is required.", MsgBoxStyle.Critical, "Error")
            eScaleWeight.Focus()
            Return 2
        End If

        Return verifyReceivingData("PURCHASE", oInvitem.Invitemnumber, eContainerType.EditValue, ePalletType.EditValue, eVendorLabelWeight.EditValue, eScaleWeight.EditValue, eLotNumber.EditValue, vSource)

    End Function


    ''' <summary>
    ''' Validating the variance percentage and scale weight.
    ''' Compare the weight of one container contents to the STDWEIGHT for the container.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function validateControls(Optional ByRef Weightofcontent As Integer = 0, Optional ByRef Stdweight As Integer = 0) As Integer
        Dim oProduct As New Product
        Dim oSysparameters As New Sysparameters
        Dim vWeightofcontent As Integer
        Dim vWeightDiff As Integer
        bsInventoryItem.EndEdit()

        If IsDBNull(eContainerType.EditValue) OrElse eContainerType.EditValue = Nothing Then
            MsgBox("You must Select a Container Type.", MsgBoxStyle.Critical, "Error - Missing Container Type")
            eContainerType.Focus()
            Return 2
        End If

        If IsDBNull(eVendorLabelWeight.EditValue) OrElse eVendorLabelWeight.EditValue = Nothing Then
            MsgBox("You must enter a Vendor Label Weight To update this inventory item, ", MsgBoxStyle.Critical, "Error - Missing Vendor Label Weight")
            eVendorLabelWeight.Focus()
            Return 2
        End If
        If eVendorLabelWeight.EditValue <= 0 Then
            MsgBox("You must enter a Vendor Label Weight greater than zero", MsgBoxStyle.Critical, "Error - Invalid Vendor Label Weight")
            eVendorLabelWeight.Focus()
            Return 2
        End If

        If IsDBNull(eScaleWeight.EditValue) OrElse eScaleWeight.EditValue Is Nothing OrElse eScaleWeight.EditValue <= 0 Then
            MsgBox("Scale Weight Is required.", MsgBoxStyle.Critical, "Error")
            eScaleWeight.Focus()
            Return 2
        End If

        If oProduct.LoadByPrimaryKey(oInvitem.Productid) = False Then
            Return 2
        End If

        'check to see if Inventory Item Vendor Label Weight matches the Product Std Weight value
        If eVendorLabelWeight.EditValue <> oProduct.Stdweight Then
            If MsgBox("The Vendor Label Weight entered does Not match the Product Label Weight In the AOS System. If you Continue, this Inventory Item will be marked with a RECEIVED HOLD status. Do you want to continue?", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.Yes Then
                'add inventory item to RECEIVED HOLD status
                Return 1
            Else
                eVendorLabelWeight.Focus()
                Return 2
            End If
        End If

        If Not oSysparameters.LoadByPrimaryKey(1) Then
            Return 2
        End If

        Dim oContainerType As New ListContainertype
        oContainerType.Query.Where(oContainerType.Query.Containertype.Equal(eContainerType.EditValue))
        If Not oContainerType.Query.Load Then
            Return 2
        End If


        'We now have the Product Record, the SysParms record, the ContainerType and the Scale Weight Entered
        'We now calculate the variance, if any, between the Scale Weight and the Standard weight for the material

        vWeightofcontent = eScaleWeight.EditValue - oContainerType.Tareweight
        vWeightofcontent = IIf(vWeightofcontent < 0, vWeightofcontent * -1, vWeightofcontent)
        vWeightDiff = getWeightVariance(oProduct.Stdweight, oContainerType.Tareweight, eScaleWeight.EditValue)
        If vWeightDiff = -100 Then
            Return 2
        End If

        If vWeightDiff > oSysparameters.AllowableWeightVariancePercentage Then
            If (MsgBox("The Scale weight you entered exceeds the standard weight variance by more than the allowable amount. " &
                   "This inventory item will be placed in a RECEIVED HOLD status. Do you want to continue?", MsgBoxStyle.YesNo, "Error") = MsgBoxResult.Yes) Then
                Return 0
            Else
                eScaleWeight.Focus()
                Return 2
            End If
        Else
            Return 3
        End If

        Return 3
    End Function

    Private Function getWeightVariance(vStdWgt As Decimal, vContainerWeight As Decimal, vScaleWeight As Decimal) As Decimal
        Dim vContentWgt As Decimal
        Dim vWeightDiff As Decimal

        Try
            vContentWgt = vScaleWeight - vContainerWeight
            vContentWgt = IIf(vContentWgt < 0, vContentWgt * -1, vContentWgt)
            vWeightDiff = ((vContentWgt - vStdWgt) / IIf(vStdWgt <= 0, 1, vStdWgt)) * 100
            vWeightDiff = IIf(vWeightDiff < 0, vWeightDiff * -1, vWeightDiff)
            Return vWeightDiff
        Catch ex As Exception
            MsgBox("Error Is determining Weight Variance", MsgBoxStyle.Critical, "Error")
            Return -100
        End Try

    End Function

    ''' <summary>
    ''' Calculate weight of the content from scale weight and tar weight
    ''' calculate percentage of variance with the standard weight
    ''' </summary>
    ''' <param name="vTareWeight"></param>
    ''' <param name="vStdweight"></param>
    ''' <param name="vWeightofcontent"></param>
    ''' <param name="vWeightDiff"></param>
    ''' <remarks></remarks>
    Private Sub calculateReceivedWeight(vTareWeight As Integer, vStdweight As Integer, ByRef vWeightofcontent As Integer, ByRef vWeightDiff As Integer)
        vWeightofcontent = bsInventoryItem.Current.Rcvdweight - vTareWeight
        vWeightofcontent = IIf(vWeightofcontent < 0, vWeightofcontent * -1, vWeightofcontent)
        vWeightDiff = ((vWeightofcontent - vStdweight) / IIf(vStdweight <= 0, 1, vStdweight)) * 100
        vWeightDiff = IIf(vWeightDiff < 0, vWeightDiff * -1, vWeightDiff)
    End Sub

    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub

End Class
