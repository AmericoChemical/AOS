Imports AOS.BusinessObjects

Public Class frmEditParameters
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)

    'here is where you dimension your object variables for the form
    Dim oItem As Sysparameters
    Dim vPreviousCompanyEmailDomain As String
    Dim vPreviousCompanyEmailServer As String

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        editObject(vID)
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        oItem = New Sysparameters
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
        vPreviousCompanyEmailDomain = oItem.CompanyEmailDomain
        vPreviousCompanyEmailServer = oItem.CompanyEmailServer
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsItem.EndEdit()
            oItem.EndEdit()
            oItem.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsItem.CancelEdit()
            oItem.CancelEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error cancelling changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Sub btnSave_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If ValidateControls() Then
            If changesSaved() Then
                Me.DialogResult = Windows.Forms.DialogResult.Yes
            End If
        End If
    End Sub

    Private Function ValidateControls() As Boolean
        If String.IsNullOrEmpty(CompanyEmailDomainTextEdit.Text) And Not (String.IsNullOrEmpty(vPreviousCompanyEmailDomain)) Then
            MsgBox("Company Email Domain cannot be empty", MsgBoxStyle.Critical, "Error")
            CompanyEmailDomainTextEdit.Focus()
            Return False
        End If
        If String.IsNullOrEmpty(CompanyEmailServerTextEdit.Text) And Not (String.IsNullOrEmpty(vPreviousCompanyEmailServer)) Then
            MsgBox("Company Email Server cannot be empty", MsgBoxStyle.Critical, "Error")
            CompanyEmailServerTextEdit.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub
     
End Class