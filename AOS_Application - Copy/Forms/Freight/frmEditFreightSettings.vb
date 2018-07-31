Imports AOS.BusinessObjects

Public Class frmEditFreightSettings
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'here is where you dimension your object variables for the form
    Dim oParms As Sysparameters

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        oParms = New Sysparameters
        oParms.Query.Where(oParms.Query.RecordID.Equal(1))
        If Not oParms.Query.Load() Then
            MsgBox("Could not load system parameters", MsgBoxStyle.Critical, "Error - Data Retrieval")
            Me.Close()
        End If
        bsParms.DataSource = oParms

        If oParms.FreezeWarning = 0 Then
            eFreeze.Checked = False
            eFreeze.CheckState = CheckState.Unchecked
        ElseIf oParms.FreezeWarning = 1 Then
            eFreeze.Checked = True
            eFreeze.CheckState = CheckState.Checked
        End If

    End Sub

    Private Sub btnCancel_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        oParms.CancelEdit()
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSave_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSave.ItemClick
        If saveChanges() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Function saveChanges() As Boolean
        Try
            bsParms.EndEdit()
            oParms.EndEdit()

            Dim oParm As New Sysparameters
            oParm.LoadByPrimaryKey(1)
            If eFreeze.CheckState = CheckState.Checked Then
                oParm.FreezeWarning = 1
            Else
                oParm.FreezeWarning = 0
            End If
            oParm.MaxLoadWeight = eMaxWgt.EditValue
            oParm.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True
    End Function

End Class