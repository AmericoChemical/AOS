Imports AOS.BusinessObjects
Public Class frmBulkReceivingStep2
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vComplete As Boolean = True
    Public vOriginalInvItemID As Integer
    Public vTotalQty As Decimal
    Public vPalletCount As Integer
    Private Sub frmBulkReceivingStep2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Bulk Receiving - Step 2 - Pallet Number: " + vPalletCount.ToString
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Select Case eUOM.EditValue
            Case "LB"
                eScaleWeight.Visible = True
            Case "LBS"
                eScaleWeight.Visible = True
            Case Else
                eScaleWeight.Visible = False
        End Select
        loadData()
    End Sub
    Private Sub loadData()
        loadLookupTables()
    End Sub
    Private Sub loadLookupTables()
        Dim oPallettypeCollection As New ListPallettypeCollection
        oPallettypeCollection = getLoadoPalletType()
        Me.bsPalletTypeCollection.DataSource = oPallettypeCollection

        Dim oLocations As New ListWarehouselocationCollection
        oLocations.LoadAll()
        oLocations.Sort = "Warehouselocation"
        bsLocations.DataSource = oLocations
    End Sub
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Function changesSaved() As Boolean
        Dim oProduct As New Product
        Dim oInvitem As New Invitem
        Dim oSysparameters As New Sysparameters
        Dim vReason As String = ""

        If ValidateControls() Then

            'get Original Inventory Item created from Purchase Item being received
            Dim oOrigInvItem As New Invitem
            If Not oOrigInvItem.LoadByPrimaryKey(vOriginalInvItemID) Then
                Return False
            End If

            'if Lot Number Count is greater than 1, then add a new Inventory Item Record and copy original Inventory Item record to it.
            If vPalletCount = 1 Then
                oInvitem = oOrigInvItem
            Else
                oInvitem = New Invitem
                oInvitem.Productid = oOrigInvItem.Productid
                oInvitem.Productdesc = oOrigInvItem.Productdesc
                oInvitem.Container = oOrigInvItem.Container
                oInvitem.Unitcost = oOrigInvItem.Unitcost
                oInvitem.Itemstatus = "PENDING"
                oInvitem.Warehousenumber = 1
                oInvitem.Inventoryclass = oOrigInvItem.Inventoryclass
                oInvitem.Sourcedocument = oOrigInvItem.Sourcedocument
                oInvitem.Sourcetype = oOrigInvItem.Sourcetype
            End If
            oInvitem.Save()

            'everything from here on will work on the Inventory Item record identified by oInvItem

            If Not oSysparameters.LoadByPrimaryKey(1) Then
                Return False
            End If

            Dim vPalletWeight As Decimal = 0.00
            vPalletWeight = getPalletWeight(ePalletType.EditValue)

            'first, if the item being received is measures in LBS, then confirm scale weight minus pallet weight is within the system parameter variance threshhold
            If eUOM.EditValue = "LB" Or eUOM.EditValue = "LBS" Then
                Dim vWgtError As Boolean = False
                Dim vNetWeight As Decimal = eScaleWeight.EditValue - vPalletWeight
                If (vNetWeight - eQtyReceived.EditValue) < ((eQtyReceived.EditValue * (oSysparameters.AllowableWeightVariancePercentage / 100)) * -1) Then
                    'The pallet is under weight beyond the allowable weight percentage variance
                    'put the inventory item into received hold
                    vComplete = False
                    vReason = "Bulk Material is underweight from what is expected."
                    'update invitem ItemStatus to "RCVDHOLD"
                End If
            End If

            If oInvitem.Itemstatus = "PENDING" Then
                oInvitem.Uom = eUOM.EditValue
                oInvitem.Unitsremaining = CDec(eQtyReceived.EditValue)
                If vComplete Then
                    oInvitem.Itemstatus = "TESTING"
                Else
                    oInvitem.Itemstatus = "RCVDHOLD"
                End If
                oInvitem.Lotnumber = eLotNumber.EditValue
                oInvitem.Receiveddate = Now()
                oInvitem.Save()
            End If

            If vComplete = False Then
                If vReason = "" Then
                    vReason = "BULK MATERIAL Received does not match total amount ordered from Vendor"
                End If
                Dim vPriorStatus As String = "PENDING"
                oInvitem.Itemstatus = "RCVDHOLD"
                oInvitem.Save()
                addRcvdHoldRecord(oInvitem.Invitemnumber, "DOCK-MANUAL", vReason, vPriorStatus, False)
            End If

            Return True
        End If
    End Function
    Private Function ValidateControls() As Boolean
        If IsDBNull(eQtyReceived.EditValue) Or eQtyReceived.EditValue < 1 Then
            MsgBox("You must enter a Qty Received greater than zero", MsgBoxStyle.Critical, "Error - Missing Data")
            Return False
        End If

        If eUOM.EditValue = "LB" Or eUOM.EditValue = "LBS" Then
            If IsDBNull(eScaleWeight.EditValue) Or eScaleWeight.EditValue < 1 Then
                MsgBox("You must enter a Scale Weight greater than zero", MsgBoxStyle.Critical, "Error - Missing Data")
                Return False
            End If
        End If

        If IsDBNull(ePalletType.EditValue) Then
            MsgBox("You must enter a Pallet Type", MsgBoxStyle.Critical, "Error - Missing Data")
            Return False
        End If
        If IsDBNull(eLotNumber.EditValue) Then
            MsgBox("You must enter a Lot Number", MsgBoxStyle.Critical, "Error - Missing Data")
            Return False
        End If
        If IsDBNull(eLocation.EditValue) Then
            MsgBox("You must enter a Warehouse Location", MsgBoxStyle.Critical, "Error - Missing Data")
            Return False
        End If

        Return True
    End Function

    Private Function getPalletWeight(vPalletName As String) As Integer
        If IsDBNull(vPalletName) OrElse vPalletName = Nothing Then
            Return 0
        End If
        Dim oPallet As New ListPallettype
        oPallet.Query.Where(oPallet.Query.Pallettype.Equal(vPalletName))
        If oPallet.Query.Load() Then
            Return oPallet.Palletweight
        Else
            Return 0
        End If
    End Function

    ''' <summary>
    ''' Calculate received weight from the grossweight and tar weight
    ''' calculate variance percentage from standard weight
    ''' </summary>
    ''' <param name="vTareWeight"></param>
    ''' <param name="vStdweight"></param>
    ''' <param name="vWeightofcontent"></param>
    ''' <param name="vCalculatedVariancePercentage"></param>
    ''' <remarks></remarks>
    Private Sub calculateReceivedWeight(vTareWeight As Integer, vStdweight As Integer, ByRef vWeightofcontent As Integer, ByRef vCalculatedVariancePercentage As Integer)
        'Dim vWeightofcontainer As Integer
        'Dim vPalletWeight As Integer = 0
        'vPalletWeight = getPalletWeight(ePalletType.EditValue)
        'vWeightofcontainer = (eScaleWeight.EditValue - vPalletWeight) / oInvitemCollection.Count
        'vWeightofcontainer = IIf(vWeightofcontainer < 0, vWeightofcontainer * -1, vWeightofcontainer)
        'vWeightofcontent = vWeightofcontainer - vTareWeight
        'vWeightofcontent = IIf(vWeightofcontent < 0, vWeightofcontent * -1, vWeightofcontent)
        'vCalculatedVariancePercentage = ((vWeightofcontent - vStdweight) / IIf(vStdweight <= 0, 1, vStdweight)) * 100
        'vCalculatedVariancePercentage = IIf(vCalculatedVariancePercentage < 0, vCalculatedVariancePercentage * -1, vCalculatedVariancePercentage)
    End Sub
    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        changesCancelled()
    End Sub
    Private Function changesCancelled() As Boolean
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Function


End Class