Imports AOS.BusinessObjects

Public Class frmEditGHSManualSpecs

    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vChemID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "GHS Manual Label Specifications for Selected Chemical"

    'here is where you dimension your object variables for the form
    Dim oGHSSpecs As Ghsmanualspecs
    Dim oChem As Chemical
    Dim oPicts As ListGhspictogramsCollection
    Dim oDangerWords As esListChemicaldangerwordsCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadReferenceData()
        loadData()
    End Sub

    Private Sub loadReferenceData()

        oPicts = New ListGhspictogramsCollection
        oPicts.LoadAll()
        oPicts.Sort = "PictogramID"
        bsPictograms1.DataSource = oPicts
        bsPictograms2.DataSource = oPicts
        bsPictograms3.DataSource = oPicts
        bsPictograms4.DataSource = oPicts
        bsPictograms5.DataSource = oPicts

        oDangerWords = New ListChemicaldangerwordsCollection
        oDangerWords.LoadAll()
        bsGHSDangerWords.DataSource = oDangerWords

    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vChemID)
        End If
    End Sub

    Private Sub addNewObject()
        oGHSSpecs = New Ghsmanualspecs
        oGHSSpecs.Chemicalid = vChemID
        oGHSSpecs.Save()
        editObject(vChemID)
    End Sub

    Private Sub editObject(ByVal vBOMID As Integer)
        If vChemID <= 0 Then
            Me.Close()
            Exit Sub
        End If

        oGHSSpecs = New Ghsmanualspecs
        oGHSSpecs.LoadByPrimaryKey(vChemID)
        bsGHSSpecs.DataSource = oGHSSpecs

        oChem = New Chemical
        oChem.LoadByPrimaryKey(vChemID)
        eChemicalName.EditValue = oChem.Chemicalname

    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsGHSSpecs.EndEdit()
            oGHSSpecs.EndEdit()
            oGHSSpecs.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsGHSSpecs.CancelEdit()
            oGHSSpecs.CancelEdit()
            If vEditType = "ADD" Then
                oGHSSpecs.MarkAsDeleted()
                oGHSSpecs.Save()
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

   
End Class