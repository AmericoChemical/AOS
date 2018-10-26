
Imports AOS.BusinessObjects

Public Class frmAddEditAPIS
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vAPISNum As Integer
    Public vEditType As String
    Public vRevision As Boolean
    Public vProductID As Integer

    Dim oAPIS As Apis
    Dim oInputs As ApisitemCollection
    Dim oProcesses As ApisprocedureCollection
    Dim oNotes As ApisnoteCollection
    Dim oProductList As ProductCollection
    Dim oCustomerList As CustomerCollection
    Dim oMaterials As MaterialCollection
    Dim oAPISList As ApisCollection
    Dim oKits As KitCollection
    Dim oMatTotals As ViewApisItemTotalsCollection

    Private Sub frmAddEditAPIS_Load(sender As Object, e As EventArgs) Handles Me.Load
        If vCurrentUserSecurityLevel >= 9 Then
            RibbonPageGroup7.Visible = True
        Else
            RibbonPageGroup7.Visible = False
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        'gather lookup data sets for drop down objects
        Me.Cursor = Cursors.WaitCursor
        getProductList()
        getCustomerList()
        getMaterials()
        getKits()
        Me.Cursor = Cursors.Default

        'now lookup selected data objects
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vAPISNum)
        End If
    End Sub
    Private Sub updateDataHistory()
        If IsDBNull(oAPIS.Createdby) Or oAPIS.Createdby = Nothing Then
            lblCreated.Text = ""
        Else
            lblCreated.Text = "Created on " & IIf(IsDBNull(oAPIS.Createdtime), "", FormatDateTime(oAPIS.Createdtime, DateFormat.GeneralDate)) & IIf(IsDBNull(oAPIS.Createdby), "", " by " & oAPIS.Createdby)
        End If
        If IsDBNull(oAPIS.Modifyby) Or oAPIS.Modifyby = Nothing Then
            lblModified.Text = ""
        Else
            lblModified.Text = "Last Modified on " & IIf(IsDBNull(oAPIS.Modifytime), "", FormatDateTime(oAPIS.Modifytime, DateFormat.GeneralDate)) & IIf(IsDBNull(oAPIS.Modifyby), "", " by " & oAPIS.Modifyby)
        End If
    End Sub

    Private Sub addNewObject()
        oAPIS = New Apis
        oAPIS.AddNew()
        oAPIS.Revision = "A"
        oAPIS.Productid = vProductID
        oAPIS.Isactive = 1
        oAPIS.Apisstatus = "ACTIVE"
        oAPIS.Createdtime = Now
        oAPIS.Createdby = vCurrentUserLogin
        oAPIS.Modifytime = Now
        oAPIS.Modifyby = vCurrentUserLogin
        oAPIS.Qtycontainers = 1 'This is the default, and we will NOT be changing this or allowing changes to this moving forward - 7/2/2018
        oAPIS.Save()
        bsAPIS.DataSource = oAPIS
        updateDataHistory()
    End Sub

    Private Sub inactivateExistingAPISRecords(vActiveAPISNum As Integer)

        'this program marks the APIS record identified by the vActiveAPISNum parameter as Active
        'all other related APIS records are marked INACTIVE

        Dim oAPISNew As New Apis
        If Not oAPISNew.LoadByPrimaryKey(vActiveAPISNum) Then
            MsgBox("Serious Error adding new APIS Record", MsgBoxStyle.Critical, "Error")
            Exit Sub
        Else
            'make sure the APIS record you want active is now marked ACTIVE
            oAPISNew.Isactive = 1
            oAPISNew.Save()
        End If

        'change all other APIS records for same productID to inactive
        oAPISList = New ApisCollection
        oAPISList = getActiveAPISByProductID(oAPISNew.Productid, vActiveAPISNum)
        If Not oAPISList Is Nothing Then
            For Each oAPISRec As Apis In oAPISList
                oAPISRec.Isactive = 0
            Next
            oAPISList.Save()
        End If

    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        oAPIS = New Apis
        oAPIS.LoadByPrimaryKey(vID)
        bsAPIS.DataSource = oAPIS
        updateDataHistory()
        getAPISDetails(vID)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub getAPISDetails(ByVal vID As Integer)
        oInputs = New ApisitemCollection
        oInputs = getApisItemCollection(vID)
        bsInputs.DataSource = oInputs

        bsProcesses.DataSource = Nothing
        oProcesses = New ApisprocedureCollection
        oProcesses = getApisProcedure(vID)
        bsProcesses.DataSource = oProcesses
        
        bsNotes.DataSource = Nothing
        oNotes = New ApisnoteCollection
        oNotes = getApisNote(vID)
        bsNotes.DataSource = oNotes

        oMatTotals = New ViewApisItemTotalsCollection
        oMatTotals.Query.Where(oMatTotals.Query.Apisnum.Equal(vID))
        If oMatTotals.Query.Load() Then
            eTotalVolume.EditValue = oMatTotals(0).Volume
            eTotalWeight.EditValue = oMatTotals(0).Weight
        Else
            eTotalVolume.EditValue = 0
            eTotalWeight.EditValue = 0
        End If

    End Sub

    Private Sub getKits()
        oKits = New KitCollection
        oKits.LoadAll()
        bsKitList.DataSource = oKits
    End Sub

    Private Sub saveDataChanges()
        bsAPIS.EndEdit()
        oAPIS.EndEdit()
        oAPIS.Save()
    End Sub

    Private Sub saveChanges()
        bsAPIS.EndEdit()
        oAPIS.Modifyby = vCurrentUserLogin
        oAPIS.Modifytime = Now
        Dim vModifiedCostColumns As List(Of String) = ModifiedCostColumns()

        oAPIS.Save()
        If oAPIS.Productid.HasValue Then
            SetProductStatndardCosts(oAPIS.Productid.Value, "APIS Change. PROD ID-" & oAPIS.Productid, "APIS Change-" & oAPIS.Apisnum & " [" + String.Join(",", vModifiedCostColumns.ToArray()) + "]")
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Function ModifiedCostColumns() As List(Of String)

        Dim vModifiedCostColumns As New List(Of String)
        If oAPIS.es.IsDirty Then
            For Each obj As String In oAPIS.es.ModifiedColumns

                Select Case obj.ToString
                    Case "STDLABORHOURS",
                            "KITID"
                        vModifiedCostColumns.Add(obj.ToString)
                End Select
            Next
        End If

        Return vModifiedCostColumns

    End Function

    Private Sub cancelChanges()
        oAPIS.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oAPIS.MarkAsDeleted()
                oAPIS.Save()
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub


    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        saveChanges()
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        cancelChanges()
    End Sub

    Private Sub getProductList()
        oProductList = New ProductCollection
        oProductList.LoadAll()
        oProductList.Sort = "ProductDesc, Container"
        bsProductList.DataSource = oProductList
    End Sub

    Private Sub getCustomerList()
        oCustomerList = New CustomerCollection
        oCustomerList.LoadAll()
        oCustomerList.Sort = "CustName, CustShipCity"
        bsCustomerList.DataSource = oCustomerList
    End Sub

    Private Sub getMaterials()
        oMaterials = New MaterialCollection
        oMaterials.LoadAll()
        bsMaterials.DataSource = oMaterials
    End Sub

    Private Sub eProductID_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles eProductID.EditValueChanged
        If IsDBNull(eProductID.EditValue) Then
            Exit Sub
        End If
        getCurrentProductData(eProductID.EditValue)
    End Sub

    Private Sub getCurrentProductData(ByVal vProductID As Integer)
        Dim oProd As New Product
        Try
            If oProd.LoadByPrimaryKey(vProductID) Then
                eProductDesc.Text = oProd.Productdesc
                eContainer.Text = oProd.Container
                eUOM.Text = oProd.Uom
                eUnits.Text = oProd.Units
                bsAPIS.Current.Container = oProd.Container
            Else
                eProductDesc.Text = Nothing
                eContainer.Text = Nothing
                eUOM.Text = Nothing
                eUnits.Text = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rbtnAddNewProcessStep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddNewProcessStep.ItemClick
        addNewAPISProcess(bsAPIS.Current.APISNum)
    End Sub

    Private Sub rbtnEditProcessStep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditProcessStep.ItemClick
        editAPISProcess(bsProcesses.Current.APISProcNum)
    End Sub

    Private Sub rbtnDeleteProcessStep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteProcessStep.ItemClick
        deleteAPISProcess(bsProcesses.Current.APISProcNum)
    End Sub

    Private Sub addNewAPISProcess(ByVal vAPISNum As Integer)
        Dim frm As New frmAddEditAPISProcess
        frm.vAPISNum = vAPISNum
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getAPISDetails(vAPISNum)
    End Sub

    Private Sub editAPISProcess(ByVal vProcID As Integer)
        Dim frm As New frmAddEditAPISProcess
        frm.vID = vProcID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getAPISDetails(bsAPIS.Current.APISNum)
    End Sub

    Private Sub deleteAPISProcess(ByVal vProcID As Integer)
        Dim str As String = "Are you sure you want to delete the selected APIS process entry? Your changes cannot be undone!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oProcess As New Apisprocedure
        If oProcess.LoadByPrimaryKey(vProcID) Then
            oProcess.MarkAsDeleted()
            oProcess.Save()
        End If

        getAPISDetails(bsAPIS.Current.APISNum)

    End Sub

    Private Sub btnAddNewInput_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnAddNewInput.ItemClick
        addNewMaterialInput(bsAPIS.Current.APISNum)
    End Sub

    Private Sub btnEditInput_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditInput.ItemClick
        editMaterialInput(bsInputs.Current.APISItemnum)
    End Sub

    Private Sub btnDeleteInput_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteInput.ItemClick
        deleteMaterialInput(bsInputs.Current.APISItemnum)
    End Sub

    Private Sub addNewMaterialInput(ByVal vAPISNum As Integer)
        Dim frm As New frmAddEditAPISInput
        frm.vAPISNum = vAPISNum
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getAPISDetails(vAPISNum)
    End Sub

    Private Sub editMaterialInput(ByVal vInputID As Integer)
        Dim frm As New frmAddEditAPISInput
        frm.vID = vInputID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getAPISDetails(bsAPIS.Current.APISNum)
    End Sub

    Private Sub deleteMaterialInput(ByVal vInputID As Integer)
        Dim str As String = "Are you sure you want to delete the selected APIS material input entry? Your changes cannot be undone!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim oInput As New Apisitem
        If oInput.LoadByPrimaryKey(vInputID) Then
            oInput.MarkAsDeleted()
            oInput.Save()
        End If
        Dim APIS As New Apis
        If APIS.LoadByPrimaryKey(bsAPIS.Current.APISNum) AndAlso APIS.Productid.HasValue Then
            SetProductStatndardCosts(APIS.Productid, "APIS Change.PROD ID-" & APIS.Productid, "APIS Change-Input Deleted.APID ID-" & APIS.Apisnum)
        End If
        getAPISDetails(bsAPIS.Current.APISNum)
    End Sub

    Private Sub pnlAPISProcessesNotes_ClientSizeChanged(sender As Object, e As System.EventArgs) Handles pnlAPISProcessesNotes.ClientSizeChanged
        gcAPISProcesses.Width = pnlAPISProcessesNotes.Width / 2
    End Sub

    Private Sub rbtnAddAPISNote_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddAPISNote.ItemClick
        addNewAPISNote(bsAPIS.Current.APISNum)
    End Sub

    Private Sub rbtnEditAPISNote_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditAPISNote.ItemClick
        editAPISNote(bsNotes.Current.APISNoteID)
    End Sub

    Private Sub rbtnDeleteAPISNote_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteAPISNote.ItemClick
        deleteAPISNote(bsNotes.Current.APISNoteID)
    End Sub

    Private Sub addNewAPISNote(vAPISNum As Integer)
        Dim frm As New frmAddEditAPISNote
        frm.vAPISNum = vAPISNum
        frm.vEditType = "ADD"
        frm.ShowDialog()
        getAPISDetails(vAPISNum)
    End Sub

    Private Sub editAPISNote(vNoteID As Integer)
        Dim frm As New frmAddEditAPISNote
        frm.vID = vNoteID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        getAPISDetails(bsAPIS.Current.APISNum)
    End Sub

    Private Sub deleteAPISNote(vNoteID As Integer)
        Dim str As String = "Are you sure you want to delete the selected APIS Note? Your changes cannot be undone!"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oNote As New Apisnote
        If oNote.LoadByPrimaryKey(vNoteID) Then
            oNote.MarkAsDeleted()
            oNote.Save()
        End If
        getAPISDetails(bsAPIS.Current.APISNum)
    End Sub

    Private Sub rbtnPrintFormulaSheet_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintFormulaSheet.ItemClick
        Dim rpt As New rptAPIS(bsAPIS.Current.APISNum)
        rpt.ShowPreviewDialog()
    End Sub

    Private Sub rbtnMarkAPISAsActive_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkAPISAsActive.ItemClick
        If MsgBox("Are you sure you want to mark this APIS as ACTIVE?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.No Then
            Exit Sub
        End If
        markAPISStatus(oAPIS.Apisnum, "ACTIVE")
        editObject(oAPIS.Apisnum)
    End Sub

    Private Sub rbtnMarkAsSingleUse_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkAsSingleUse.ItemClick
        If MsgBox("Are you sure you want to mark this APIS as SINGLE USE?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.No Then
            Exit Sub
        End If
        markAPISStatus(oAPIS.Apisnum, "SINGLE USE")
        editObject(oAPIS.Apisnum)
    End Sub

    Private Sub rbtnMarkAsArchived_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMarkAsArchived.ItemClick
        If MsgBox("Are you sure you want to mark this APIS as ARCHIVED?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.No Then
            Exit Sub
        End If
        markAPISStatus(oAPIS.Apisnum, "ARCHIVED")
        editObject(oAPIS.Apisnum)
    End Sub

    Private Sub eKitID_EditValueChanged(sender As Object, e As EventArgs) Handles eKitID.EditValueChanged
        If IsDBNull(eKitID.EditValue) Then
            Exit Sub
        End If
        getKitData(eKitID.EditValue)
    End Sub

    Private Sub getKitData(vID As Integer)
        Dim oKit As New Kit
        Try
            If oKit.LoadByPrimaryKey(vID) Then
                eKitDescription.Text = oKit.Kitname
            Else
                eKitDescription.Text = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub rbtnReviewCosts_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnReviewCosts.ItemClick
        Dim frm As New frmApisStandardCosts
        frm.vAPISID = oAPIS.Apisnum
        frm.ShowDialog()
    End Sub


End Class