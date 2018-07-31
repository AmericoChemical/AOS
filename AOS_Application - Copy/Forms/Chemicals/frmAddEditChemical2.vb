Imports AOS.BusinessObjects
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class frmAddEditChemical2

    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Chemical"

    'here is where you dimension your object variables for the form
    Dim oChem As Chemical
    Dim oOdor As ListChemicalodorCollection
    Dim oColor As ListChemicalcolorCollection
    Dim oState As ListChemicalstateCollection
    Dim oClarity As ListChemicalclarityCollection
    Dim oLabelType As ListLabeltypeCollection
    Dim oPkgGroups As New ListPackagegroupCollection
    Dim oHazmat As New HazmatsymbolCollection


    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Select Case vEditType
            Case "ADD"
                Me.Text = "Adding New " & vObjectName
            Case "EDIT"
                Me.Text = "Editing " & vObjectName & " Information"
            Case "VIEW"
                Me.Text = vObjectName & " Information"
        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadReferenceData()
        loadData()
    End Sub

    Private Sub loadReferenceData()
        oOdor = New ListChemicalodorCollection
        oOdor.LoadAll()
        bsOdor.DataSource = oOdor

        oColor = New ListChemicalcolorCollection
        oColor.LoadAll()
        bsColor.DataSource = oColor

        oState = New ListChemicalstateCollection
        oState.LoadAll()
        bsState.DataSource = oState

        oClarity = New ListChemicalclarityCollection
        oClarity.LoadAll()
        bsClarity.DataSource = oClarity

        oLabelType = New ListLabeltypeCollection
        oLabelType.LoadAll()
        bsLabelType.DataSource = oLabelType

        oHazmat.LoadAll()
        Me.bsHazmat.DataSource = oHazmat

        oPkgGroups.LoadAll()
        bsPkgGroups.DataSource = oPkgGroups

    End Sub

    Private Sub loadData()
        Select Case vEditType
            Case "ADD"
                addNewObject()
            Case "EDIT"
                editObject(vID)
            Case "VIEW"
                forceDataFieldsToReadOnly()
                editObject(vID)
        End Select

    End Sub

    Private Sub addNewObject()
        oChem = New Chemical
        oChem.AddNew()
        'assign foreign key values here
        oChem.Chemicalstatus = "ACTIVE"
        oChem.Createdby = vCurrentUserLogin
        oChem.Createdtime = Now
        oChem.Modifiedby = vCurrentUserLogin
        oChem.Modifiedtime = Now
        oChem.Save()
        Me.bsChem.DataSource = oChem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Me.Close()
        End If
        If vID <= 0 Then
            MsgBox("There is not Chemical Record to retrieve", MsgBoxStyle.Critical, "Edit Failed")
            Me.Close()
        End If
        oChem = New Chemical
        oChem.LoadByPrimaryKey(vID)
        Me.bsChem.DataSource = oChem

    End Sub

    Private Sub forceDataFieldsToReadOnly()
        rbtnChangeChemicalStatus.Enabled = False
        'btnGHSManualSpecs.Enabled = False
        btnSDSFilePath.Enabled = False
        rbtnViewPrintSDS.Enabled = False
        For Each ctrl As Control In Me.Controls
            If ctrl.GetType Is GetType(DevExpress.XtraEditors.GroupControl) Then
                For Each childCtrl As Control In ctrl.Controls
                    If childCtrl.GetType Is GetType(DevExpress.XtraEditors.TextEdit) Then CType(childCtrl, DevExpress.XtraEditors.TextEdit).Properties.ReadOnly = True
                    If childCtrl.GetType Is GetType(DevExpress.XtraEditors.LookUpEdit) Then CType(childCtrl, DevExpress.XtraEditors.LookUpEdit).Properties.ReadOnly = True
                    If childCtrl.GetType Is GetType(DevExpress.XtraEditors.DateEdit) Then CType(childCtrl, DevExpress.XtraEditors.DateEdit).Properties.ReadOnly = True
                    If childCtrl.GetType Is GetType(DevExpress.XtraEditors.CheckEdit) Then CType(childCtrl, DevExpress.XtraEditors.CheckEdit).Properties.ReadOnly = True
                Next
            End If
        Next
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsChem.EndEdit()
            If vEditType = "ADD" Then
                If duplicateChemicalName(eChemicalName.EditValue) Then
                    Return False
                End If
            End If
            oChem.EndEdit()
            oChem.Modifiedby = vCurrentUserLogin
            oChem.Modifiedtime = Now
            oChem.Save()
            updateLinkedProducts(oChem.Chemicalid)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function duplicateChemicalName(vChemicalName As String) As Boolean
        Dim oChems As New ChemicalCollection
        oChems.Query.Where(oChems.Query.Chemicalname.Equal(vChemicalName))
        If oChems.Query.Load() Then
            Select Case oChems.Count
                Case 0
                    Return False
                Case 1
                    If oChems(0).Chemicalid = oChem.Chemicalid Then
                        Return False
                    Else
                        'There are more than one record with the same chemical name
                        MsgBox("This Chemical Name already exists in the database. You must change the name to something unique to save your changes.", MsgBoxStyle.Critical, "ERROR - Duplicate Chemical Name")
                        Return True
                    End If
                Case > 1
                    'There are more than one record with the same chemical name
                    MsgBox("This Chemical Name already exists in the database. You must change the name to something unique to save your changes.", MsgBoxStyle.Critical, "ERROR - Duplicate Chemical Name")
                    Return True
            End Select
        End If
        Return False
    End Function

    Private Sub updateLinkedProducts(vChemID As Integer)
        If IsDBNull(vChemID) Then
            Exit Sub
        End If
        If vChemID = 0 Then
            Exit Sub
        End If
        Dim oChm As New Chemical
        If Not oChm.LoadByPrimaryKey(vChemID) Then
            Exit Sub
        End If

        'we need a couple of values from the system parameters table
        Dim oParm As New Sysparameters
        oParm.LoadByPrimaryKey(1)

        Dim vVolume As Decimal = 0

        Dim oProducts As New ProductCollection
        oProducts.Query.Where(oProducts.Query.Chemicalid.Equal(vChemID))
        If oProducts.Query.Load Then
            For Each oProduct As Product In oProducts
                vVolume = IIf(IsDBNull(oProduct.Volumeunits), 0, oProduct.Volumeunits)
                'check to see if chemical is flagged for non-regulated DOT defaults based on container volume of product
                If oChm.Usenonregdot = True And oChm.Istoxic = False And vVolume <= oParm.MaxVolumeForNonRegDOT Then
                    oProduct.Dotdesc = oParm.NonRegulatedDOTDesc
                    oProduct.Hazmatdesc = Nothing
                    oProduct.Unline = Nothing
                    oProduct.Hazmatid = 1
                    oProduct.Unnumber = Nothing
                    oProduct.Hazclassnumber = Nothing
                    oProduct.Packagegroup = Nothing
                    oProduct.Idnumber = Nothing
                Else
                    oProduct.Dotdesc = oChm.Dotdesc
                    oProduct.Hazmatdesc = oChm.Hazmatdesc
                    oProduct.Unline = oChm.Unline
                    oProduct.Hazmatid = oChm.Hazmatid
                    oProduct.Unnumber = oChm.Unnumber
                    oProduct.Hazclassnumber = oChm.Hazclassnumber
                    oProduct.Packagegroup = oChm.Packagegroup
                    oProduct.Idnumber = oChm.Idnumber
                End If
                oProduct.Productdesc = oChm.Chemicalname
                oProduct.Health = oChm.Health
                oProduct.Fire = oChm.Fire
                oProduct.Reactivity = oChm.Reactivity
                oProduct.Personalprotection = oChm.Personalprotection
                oProduct.Istoxic = oChm.Istoxic
            Next
            oProducts.Save()
        End If
    End Sub

    Private Function changesCancelled() As Boolean
        Try
            bsChem.CancelEdit()
            oChem.CancelEdit()
            If vEditType = "ADD" Then
                oChem.MarkAsDeleted()
                oChem.Save()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error cancelling changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub btnSDSFilePath_Click(sender As Object, e As EventArgs) Handles btnSDSFilePath.Click

        Dim filedialog As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = eSDSFileName.Text
        filedialog.Title = "SDS Document Filename"
        If filedialog.ShowDialog() = DialogResult.OK Then
            strFileName = filedialog.FileName
        End If
        eSDSFileName.EditValue = strFileName

        'hard save the file path
        bsChem.EndEdit()
        oChem.EndEdit()
        oChem.Save()

    End Sub

    Private Sub btnGHSManualSpecs_Click(sender As Object, e As EventArgs)
        'If IsDBNull(luLabelType.EditValue) Then
        '    Exit Sub
        'End If
        'If luLabelType.EditValue <> "GHS - MANUAL" Then
        '    Exit Sub
        'End If

        ''At this point the current Chemical Label Type is "GHS - MANUAL" and the specs can be added/edited
        'Dim vEditType As String = Nothing

        'Dim oSpec As New Ghsmanualspecs
        'If Not oSpec.LoadByPrimaryKey(bsChem.Current.ChemicalID) Then
        '    'there is no current GHS Manual Spec record for the current Chemical ID
        '    vEditType = "ADD"
        'Else
        '    vEditType = "EDIT"
        'End If

        'Dim frm As New frmEditGHSManualSpecs
        'frm.vEditType = vEditType
        'frm.vChemID = bsChem.Current.ChemicalID
        'frm.ShowDialog()
    End Sub

    Private Sub rbtnProductList_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnProductList.ItemClick
        If Not changesSaved() Then
            Exit Sub
        End If
        Dim frm As New frmChemicalProductLinks
        frm.vChemID = bsChem.Current.chemicalID
        If vEditType = "VIEW" Then
            frm.vEditType = "VIEW"
        End If
        frm.ShowDialog()
    End Sub

    Private Sub rbtnChangeChemicalStatus_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnChangeChemicalStatus.ItemClick
        If bsChem Is Nothing Then
            Exit Sub
        End If

        If IsDBNull(eChemStatus.EditValue) Or eChemStatus.EditValue Is Nothing Then
            Exit Sub
        End If

        Dim vStatusCode As String = eChemStatus.EditValue
        Select Case vStatusCode
            Case "ACTIVE"
                If MsgBox("Are you sure you want to mark the Chemical Status as INACTIVE?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.No Then
                    Exit Sub
                End If
                updateChemicalStatus(bsChem.Current.ChemicalID, "INACTIVE")
            Case "INACTIVE"
                If MsgBox("Are you sure you want to mark the Chemical Status as ACTIVE?", MsgBoxStyle.YesNo, "Confirm Status Change") = MsgBoxResult.No Then
                    Exit Sub
                End If
                updateChemicalStatus(bsChem.Current.ChemicalID, "ACTIVE")
        End Select
        editObject(vID)
    End Sub

    Private Sub updateChemicalStatus(vChemID As Integer, vChemStatus As String)
        Select Case vChemStatus
            Case "ACTIVE"
                Dim oChem As New Chemical
                If oChem.LoadByPrimaryKey(vChemID) Then
                    oChem.Chemicalstatus = "ACTIVE"
                    oChem.Save()
                End If
            Case "INACTIVE"
                Dim oChem As New Chemical
                If oChem.LoadByPrimaryKey(vChemID) Then
                    oChem.Chemicalstatus = "INACTIVE"
                    oChem.Save()
                    'get all Products linked to this chemical
                    Dim oProductList As New ProductCollection
                    oProductList.Query.Where(oProductList.Query.Chemicalid.Equal(vChemID))
                    If oProductList.Query.Load Then
                        If MsgBox("All linked Products to Chemical " + vChemID.ToString + " will be marked INACTIVE. Do you want to continue?", MsgBoxStyle.YesNo, "INACTIVATE Products") = MsgBoxResult.No Then
                            Exit Sub
                        End If
                        For Each oProd As Product In oProductList
                            updateProductStatus(oProd.Productid, "INACTIVE")
                        Next
                    End If
                End If
        End Select
        editObject(vChemID)
    End Sub

    Private Sub rbtnViewPrintSDS_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnViewPrintSDS.ItemClick
        viewPrintSDSDocumentByChemical(oChem.Chemicalid)
    End Sub

    Private Sub rbtnGHSLabelSpecs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnGHSLabelSpecs.ItemClick
        'At this point the current Chemical Label Type is "GHS - MANUAL" and the specs can be added/edited
        Dim vEditType As String = Nothing

        Dim oSpec As New Ghsmanualspecs
        If Not oSpec.LoadByPrimaryKey(bsChem.Current.ChemicalID) Then
            'there is no current GHS Manual Spec record for the current Chemical ID
            vEditType = "ADD"
        Else
            vEditType = "EDIT"
        End If

        Dim frm As New frmEditGHSManualSpecs
        frm.vEditType = vEditType
        frm.vChemID = bsChem.Current.ChemicalID
        frm.ShowDialog()
    End Sub


End Class