Imports AOS.BusinessObjects
Imports System.Text

Public Class frmAddEditAlternateComponents
    Inherits DevExpress.XtraEditors.XtraForm


    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)   
    Public vRecID As Integer
    Public vComponent As Component
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Component Alternate"

    'here is where you dimension your object variables for the form
    Dim oComponentCollection As New ComponentCollection
    Dim oAltComponent As New Altcomponent
    Dim oComponent As New Component

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'setRibbonOptions(vCurrentUserSecurityLevel)
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
        If vID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oComponentCollection = New ComponentCollection
        oComponentCollection.Query.Where(oComponentCollection.Query.Componentid.NotEqual(vID))
        oComponentCollection.Query.Load()
        bsComponents.DataSource = oComponentCollection
    End Sub

    Private Sub loadData()
        AmericoDescTextEdit.Properties.ReadOnly = True

        If vEditType = "ADD" Then
            addNewObject(vID)
        Else
            editObject(vID)
        End If
        getAmericoDesc()
    End Sub

    Private Sub getAmericoDesc()
        AmericoDescTextEdit.Text = vComponent.Componentdesc
    End Sub

    Private Sub addNewObject(vID)
        oAltComponent.AddNew()
        oAltComponent.Componentid = vID
        oAltComponent.EndEdit()
        oAltComponent.Save()
        Me.bsAltComponent.DataSource = oAltComponent
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is no Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If

        oAltComponent.LoadByPrimaryKey(vRecID)
        Me.bsAltComponent.DataSource = oAltComponent
    End Sub

    Private Function changesSaved() As Boolean
        bsAltComponent.EndEdit()
        oAltComponent.EndEdit()
        oAltComponent.Save()
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        bsAltComponent.CancelEdit()
        Try
            If vEditType = "ADD" Then
                oAltComponent.MarkAsDeleted()
                oAltComponent.Save()
            End If
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.ItemClick
       
        If ValidateControls() Then
            If changesSaved() Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Function ValidateControls() As Boolean
        If String.IsNullOrEmpty(Me.AltComponentLookUpEdit.Text) Then
            MsgBox("Component Alternate is required, please select an alternate from the dropdown.", MsgBoxStyle.Critical, "Validate Component Alternate - Error")
            AltComponentLookUpEdit.Focus()
            Return False
        End If

        Dim oAltComponentList As New AltcomponentCollection

        ' Add comments
        If vEditType = "ADD" Then
            oAltComponentList.Query.Where(oAltComponentList.Query.Altcomponentid.Equal(AltComponentLookUpEdit.EditValue), oAltComponentList.Query.Componentid.Equal(vID))
        Else
            oAltComponentList.Query.Where(oAltComponentList.Query.Altcomponentid.Equal(AltComponentLookUpEdit.EditValue), oAltComponentList.Query.Componentid.Equal(vID), oAltComponentList.Query.Recid.NotEqual(vRecID))
        End If

        oAltComponentList.Query.Load()

        If (oAltComponentList.Count > 0) Then
            MsgBox("Component Alternate already exists for this component. Please select a different alternates", MsgBoxStyle.Critical, "Validate Component Alternate - Error")
            Return False
        End If

        Return True
    End Function

End Class