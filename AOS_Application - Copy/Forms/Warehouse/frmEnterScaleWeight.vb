Imports AOS.BusinessObjects

Public Class frmEnterScaleWeight
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vCommaSeparatedInvitemnumber As String
    Public oInvitemCollection As InvitemCollection
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub
    Private Sub loadData()
        oInvitemCollection = New InvitemCollection
        oInvitemCollection = getInvItemsByInvItemNumbers(vCommaSeparatedInvitemnumber)
        loadLookupTables()
    End Sub
    Private Sub loadLookupTables()
        Dim oPallettypeCollection As New ListPallettypeCollection
        oPallettypeCollection = getLoadoPalletType()
        Me.bsPalletTypeCollection.DataSource = oPallettypeCollection

        Dim oContainers As New ListContainertypeCollection
        oContainers.LoadAll()
        oContainers.Sort = "CONTAINERTYPE"
        bsContainerType.DataSource = oContainers

    End Sub
    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNext.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Function changesSaved() As Boolean
        Dim oProduct As New Product
        Dim oInvitem As New Invitem
        Dim oContainer As New ListContainertype
        Dim oSysparameters As New Sysparameters
        Dim vWeightofcontent As Integer
        Dim vCalculatedVariancePercentage As Integer

        If ValidateControls() Then

            If oInvitem.LoadByPrimaryKey(oInvitemCollection(0).Invitemnumber) = False Then
                Return False
            End If
            If oProduct.LoadByPrimaryKey(oInvitem.Productid) = False Then
                Return False
            End If
            oContainer.Query.Where(oContainer.Query.Containertype.Equal(eContainerType.EditValue))
            If oContainer.Query.Load = False Then
                Return False
            End If

            If Not oSysparameters.LoadByPrimaryKey(1) Then
                Return False
            End If

            calculateReceivedWeight(oContainer.TareWeight, oProduct.Stdweight, vWeightofcontent, vCalculatedVariancePercentage)

            If oInvitemCollection.Count > 1 Then
                If vCalculatedVariancePercentage > oSysparameters.Allowableweightvariancepercentage Then
                    MsgBox("The variance for the calculated weight for an individual container exceeds the standard weight by more than the allowable variance. Please break down this pallet and weigh each item to identify which one is out of spec.", MsgBoxStyle.Information, "Information")
                    Return True
                Else
                    'For Each oInventoryitem As Invitem In oInvitemCollection
                    '    updateInvItemRcvdWeightAndStatus(oInventoryitem.Invitemnumber, oProduct.Stdweight)
                    'Next
                    Dim frm As New frmReceiveMultipleInventoryItems
                    frm.vCommaSeparatedInvitemnumber = vCommaSeparatedInvitemnumber
                    frm.vContainerWeight = vWeightofcontent + oContainer.Tareweight
                    frm.vContainer = oContainer.Containertype
                    frm.vPallet = ePalletType.EditValue
                    frm.ShowDialog()
                End If
            End If
            Return True
        End If
    End Function
    Private Function ValidateControls() As Boolean
        If oInvitemCollection.Count > 1 Then
            If IsDBNull(ePalletType.EditValue) OrElse ePalletType.EditValue Is Nothing Then
                MsgBox("Pallet Type is required.", MsgBoxStyle.Critical, "Error")
                ePalletType.Focus()
                Return False
            End If

            If eScaleWeight.EditValue Is Nothing OrElse Val(eScaleWeight.EditValue) <= 0 Then
                MsgBox("Scale Weight is required.", MsgBoxStyle.Critical, "Error")
                eScaleWeight.Focus()
                Return False
            End If
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
        Dim vWeightofcontainer As Integer
        Dim vPalletWeight As Integer = 0
        vPalletWeight = getPalletWeight(ePalletType.EditValue)
        vWeightofcontainer = (eScaleWeight.EditValue - vPalletWeight) / oInvitemCollection.Count
        vWeightofcontainer = IIf(vWeightofcontainer < 0, vWeightofcontainer * -1, vWeightofcontainer)
        vWeightofcontent = vWeightofcontainer - vTareWeight
        vWeightofcontent = IIf(vWeightofcontent < 0, vWeightofcontent * -1, vWeightofcontent)
        vCalculatedVariancePercentage = ((vWeightofcontent - vStdweight) / IIf(vStdweight <= 0, 1, vStdweight)) * 100
        vCalculatedVariancePercentage = IIf(vCalculatedVariancePercentage < 0, vCalculatedVariancePercentage * -1, vCalculatedVariancePercentage)
    End Sub
    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        changesCancelled()
    End Sub
    Private Function changesCancelled() As Boolean
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Function
End Class