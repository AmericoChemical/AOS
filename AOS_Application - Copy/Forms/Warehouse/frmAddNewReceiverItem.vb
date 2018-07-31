Imports AOS.BusinessObjects

Public Class frmAddNewReceiverItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vRecvrNum As Integer     'foreign key values (passed in by calling form for add mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vWhseID As Integer
    Public vVendorID As Integer
    Private vItemVendorID As Integer = 0

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Receiver Item"

    'here is where you dimension your object variables for the form
    Dim oItem As Receiveritem
    Dim oProducts As ProductCollection
    Dim oWhse As WarehouseCollection
    Dim oLocs As ListWarehouselocationCollection
    Dim oProduct As Product
    Dim oContainer As Container
    Dim oProductCosts As ProductcostCollection
    Dim oInvClass As ListInventoryclassCollection

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getProducts()
        getInventoryClassLU()
        getDocTypes()
        getContainerTypes()
        getPalletTypes()
    End Sub

    Private Sub getDocTypes()
        Dim oDocs As New ListDocumenttypeCollection
        oDocs.Query.Where(oDocs.Query.Documenttype.NotEqual("PRCH"))
        oDocs.Query.Load()
        bsDocTypes.DataSource = oDocs
    End Sub

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.Query.Where(oProducts.Query.Productstatus.Equal("ACTIVE"))
        oProducts.Query.Load()
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub getInventoryClassLU()
        oInvClass = New ListInventoryclassCollection
        oInvClass.LoadAll()
        bsInventoryClass.DataSource = oInvClass
    End Sub

    Private Sub getContainerTypes()
        Dim oContainers As New ListContainertypeCollection
        oContainers.LoadAll()
        bsContainers.DataSource = oContainers
    End Sub

    Private Sub getPallettypes()
        Dim oPallets As New ListPallettypeCollection
        oPallets.LoadAll()
        oPallets.Sort = "PalletWeight DESC"
        bsPallets.DataSource = oPallets
    End Sub

    Private Sub eProduct_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eProduct.EditValueChanged

        If IsDBNull(eProduct.EditValue) OrElse eProduct.EditValue = Nothing Then
            Exit Sub
        End If

        oProduct = New Product
        If Not oProduct.LoadByPrimaryKey(eProduct.EditValue) Then
            MsgBox("Could not find product information")
            Exit Sub
        End If

        'we now have the product record 
        eProductDesc.EditValue = oProduct.Productdesc
        eContainer.EditValue = oProduct.Container
        eInventoryClass.EditValue = oProduct.Inventoryclass

    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If Not validateData() Then
            Exit Sub
        End If
        If receiveItemsToInventory() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Function validateData() As Boolean

        If IsDBNull(eDocType.EditValue) OrElse eDocType.EditValue = Nothing Then
            MsgBox("You must enter a Document Type.", MsgBoxStyle.Critical, "Error - Missing Document Type")
            eDocNum.Focus()
            Return False
        End If
        'If IsDBNull(eDocNum.EditValue) OrElse eDocNum.EditValue = Nothing Then
        '    MsgBox("You must enter a Document #.", MsgBoxStyle.Critical, "Error - Missing Document Number")
        '    eDocNum.Focus()
        '    Return False
        'End If
        If IsDBNull(eProduct.EditValue) OrElse eProduct.EditValue = Nothing Then
            MsgBox("You must enter a Product ID.", MsgBoxStyle.Critical, "Error - Missing Product ID")
            eProduct.Focus()
            Return False
        End If
        If IsDBNull(eQty.EditValue) OrElse eQty.EditValue = Nothing Then
            MsgBox("You must enter a Quantity to Receive.", MsgBoxStyle.Critical, "Error - Missing Qty")
            eQty.Focus()
            Return False
        End If
        If IsDBNull(eLotNumber.EditValue) OrElse eLotNumber.EditValue = Nothing Then
            MsgBox("You must enter a Lot #.", MsgBoxStyle.Critical, "Error - Missing Lot Number")
            eLotNumber.Focus()
            Return False
        End If
        If IsDBNull(eInventoryClass.EditValue) OrElse eInventoryClass.EditValue = Nothing Then
            MsgBox("You must enter an Inventory Class.", MsgBoxStyle.Critical, "Error - Missing Inventory Class")
            eInventoryClass.Focus()
            Return False
        End If
        If IsDBNull(eLabelWeight.EditValue) OrElse eLabelWeight.EditValue = Nothing Then
            MsgBox("You must enter a Label Weight.", MsgBoxStyle.Critical, "Error - Missing Label Weight")
            eLabelWeight.Focus()
            Return False
        End If
        If IsDBNull(eScaleWeight.EditValue) OrElse eScaleWeight.EditValue = Nothing Then
            MsgBox("You must enter a Scale Weight.", MsgBoxStyle.Critical, "Error - Missing Scale Weight")
            eScaleWeight.Focus()
            Return False
        End If
        If IsDBNull(eContainerType.EditValue) OrElse eContainerType.EditValue = Nothing Then
            MsgBox("You must enter a Container type.", MsgBoxStyle.Critical, "Error - Missing Container Type")
            eContainerType.Focus()
            Return False
        End If
        If IsDBNull(ePalletType.EditValue) OrElse ePalletType.EditValue = Nothing Then
            MsgBox("You must enter a Pallet Type.", MsgBoxStyle.Critical, "Error - Missing Pallet Type")
            ePalletType.Focus()
            Return False
        End If

        If CInt(eQty.EditValue) <= 0 Then
            MsgBox("You must enter a Quantity to Receive.", MsgBoxStyle.Critical, "Error - Missing Qty")
            eQty.Focus()
            Return False
        End If

        Return True
    End Function

    Private Function receiveItemsToInventory() As Boolean

        'create new Receiver Record
        Dim oRcvr As New Receiver
        Try
            oRcvr.Receiveddate = Now
            oRcvr.Receiverdocument = eDocNum.EditValue
            oRcvr.Receiverdocumenttype = eDocType.EditValue
            oRcvr.Createdby = vCurrentUserLogin
            oRcvr.Createdtime = Now
            oRcvr.Modifyby = vCurrentUserLogin
            oRcvr.Modifytime = Now
            oRcvr.Save()
        Catch ex As Exception
            MsgBox("Error in creating Receiver Record. Entry Failed. See system administrator.", MsgBoxStyle.Critical, "Error")
            Return False
        End Try

        'create new ReceiverItem Record
        Dim oItem As New Receiveritem
        Try
            oItem.Receivernumber = oRcvr.Receivernumber
            oItem.Productid = oProduct.Productid
            oItem.Productdesc = oProduct.Productdesc
            oItem.Qtyreceived = CInt(eQty.EditValue)
            oItem.Container = oProduct.Container
            oItem.Lotnumber = eLotNumber.EditValue
            oItem.Posted = 1
            oItem.Unitcost = getUnitCostForProduct(oProduct.Productid)
            oItem.Unitorcontainer = "C"
            oItem.Inventoryclass = eInventoryClass.EditValue
            oItem.Save()
        Catch ex As Exception
            MsgBox("Error in creating Receiver Item Record. Entry Failed. See system administrator.", MsgBoxStyle.Critical, "Error")
            Return False
        End Try

        'add Items to Inventory with RCVDHOLD status
        Dim vIndex As Integer
        Dim vQty As Integer = eQty.EditValue

        'create one INVITEM and one RECEIVEDHOLD record for each ITEM received
        For vIndex = 0 To vQty - 1

            Dim oInv As New Invitem
            Try
                oInv.Productid = oProduct.Productid
                oInv.Productdesc = oProduct.Productdesc
                oInv.Container = oProduct.Container
                oInv.Unitcost = getUnitCostForProduct(oProduct.Productid)
                oInv.Lotnumber = eLotNumber.EditValue
                oInv.Itemstatus = "RCVDHOLD"
                oInv.Receiveddate = Now
                oInv.Receivernumber = oRcvr.Receivernumber
                If Not IsDBNull(eDocNum.EditValue) And eDocNum.EditValue IsNot Nothing Then
                    Try
                        Dim vDoc As Integer = CInt(eDocNum.EditValue)
                        oInv.Sourcedocument = vDoc
                    Catch ex As Exception
                    End Try
                End If
                oInv.Sourcedocument = eDocNum.EditValue.ToString
                oInv.Sourcetype = eDocType.EditValue
                oInv.Inventoryclass = eInventoryClass.EditValue
                oInv.Save()

                'print Product Label for Item
                'Dim rpt As New rptGHSProductLabelLarge(oInv.Invitemnumber, oInv.Productid)
                'rpt.ShowPreviewDialog()

            Catch ex As Exception
                MsgBox("Error in creating Inventory Item Record. Entry Failed. See system administrator.", MsgBoxStyle.Critical, "Error")
                Return False
            End Try

            Dim oContainer As New ListContainertype
            oContainer.Query.Where(oContainer.Query.Containertype.Equal(eContainerType.EditValue))
            If Not oContainer.Query.Load() Then
                MsgBox("Error in retrieving Container Record", MsgBoxStyle.Critical, "Error")
                Return False
            End If
            Dim oPallet As New ListPallettype
            oPallet.Query.Where(oPallet.Query.Pallettype.Equal(ePalletType.EditValue))
            If Not oPallet.Query.Load() Then
                MsgBox("Error in retrieving Pallet Record", MsgBoxStyle.Critical, "Error")
                Return False
            End If

            Dim vIndividualScaleWeight As Decimal = ((eScaleWeight.EditValue - oPallet.Palletweight) / eQty.EditValue)


            verifyReceivingData("MISC", oInv.Invitemnumber, eContainerType.EditValue, ePalletType.EditValue, eLabelWeight.EditValue, vIndividualScaleWeight, eLotNumber.EditValue, "MISC")

        Next

        Return True
    End Function

    Private Function getUnitCostForProduct(vProdID As Integer) As Decimal

        Dim oRec As New Product
        If oRec.LoadByPrimaryKey(vProdID) Then
            Select Case oRec.Inventorymethod
                Case "VOLUME"
                    Return IIf(IsDBNull(oRec.Volumestandardcost), 0, oRec.Volumestandardcost)
                Case "WEIGHT"
                    Return IIf(IsDBNull(oRec.Weightstandardcost), 0, oRec.Weightstandardcost)
                Case Else
                    Return 0
            End Select
        End If

    End Function



    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
    Private Function changesCancelled() As Boolean
        Return True
    End Function
End Class