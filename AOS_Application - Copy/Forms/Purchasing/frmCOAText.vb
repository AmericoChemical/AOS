Imports AOS.BusinessObjects

Public Class frmCOAText
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'here is where you dimension your object variables for the form
    Dim oSysparameters As Sysparameters

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        LoadData()
    End Sub

    Private Sub LoadData()
        'used to load the product cbo object
        oSysparameters = New Sysparameters
        oSysparameters.LoadByPrimaryKey(1)
        bsSysParameters.DataSource = oSysparameters
    End Sub

    Private Function changesSaved() As Boolean
        Try
            oSysparameters.COAText = txtCOAText.Text
            oSysparameters.EndEdit()
            oSysparameters.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            oSysparameters.CancelEdit()
        Catch ex As Exception
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