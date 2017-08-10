Imports AOS.BusinessObjects

Public Class frmAddEditRelabelInstruction
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vRelabelInstructionNumber As Integer      'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vSequence As Integer

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Relabel Instruction"

    'here is where you dimension your object variables for the form
    Dim oRelabelInstruction As Relabelinstruction

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Insert " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vRelabelInstructionNumber)
        End If
    End Sub

    Private Sub addNewObject()

        If vSequence > 0 Then
            'we are inserting a new Template Relabel Instruction into the Sequence
            'we need to push all other subsequent instructions up one level in the overall sequence
            updateRelabelInstructionSequence(vSequence)
        End If

        'Now insert the new instruction into the list at the newly "vacated" sequence spot
        oRelabelInstruction = New Relabelinstruction
        If vSequence > 0 Then
            oRelabelInstruction.Sequence = vSequence
        Else
            oRelabelInstruction.Sequence = getRelabelInstructionMaxSequence()
        End If
        oRelabelInstruction.Save()

        Me.bsRelabelInstruction.DataSource = oRelabelInstruction
    End Sub

    Private Sub editObject(ByVal vProductRelabelInstructionNumber As Integer)
        If vRelabelInstructionNumber = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oRelabelInstruction = New Relabelinstruction
        oRelabelInstruction.LoadByPrimaryKey(vRelabelInstructionNumber)
        Me.bsRelabelInstruction.DataSource = oRelabelInstruction
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsRelabelInstruction.EndEdit()
            oRelabelInstruction.EndEdit()

            'If checkRelabelInstructionSequenceExists(oRelabelInstruction.Sequence,
            '                     oRelabelInstruction.Relabelinstructionnumber) Then

            '    'If selected sequence is greater than the current sequence then need to increate the sequence by 1
            '    'This is alternate way, instead of getting the target sequence and reducing the requence of that record
            '    Dim oOldRelabelInstruction As New Relabelinstruction
            '    If oOldRelabelInstruction.LoadByPrimaryKey(oRelabelInstruction.Relabelinstructionnumber) = False Then
            '        Return False
            '    End If
            '    If oOldRelabelInstruction.Sequence < oRelabelInstruction.Sequence Then
            '        oRelabelInstruction.Sequence = oRelabelInstruction.Sequence + 1
            '    End If

            '    updateRelabelInstructionSequence(oRelabelInstruction.Sequence)
            'End If

            oRelabelInstruction.Save()

            'Reorder all the sequence numbers for template instructions with same or higher sequence number to new entry
            'updateRelabelInstructionSequence(vSequence)
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsRelabelInstruction.CancelEdit()
            oRelabelInstruction.CancelEdit()
            If vEditType = "ADD" Then
                oRelabelInstruction.MarkAsDeleted()
                oRelabelInstruction.Save()
            End If
            updateRelabelInstructionSequence()
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