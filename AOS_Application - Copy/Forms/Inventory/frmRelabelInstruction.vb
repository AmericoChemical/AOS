Imports AOS.BusinessObjects

Public Class frmRelabelInstruction
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        bsRelabelInstructions.DataSource = getRelabelInstructions()
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        'On closing need to save the data in the grid editor
        grvRelabelInstruction.FocusedColumn = colSequence
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnInsertRelabelInstr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInsertRelabelInstr.ItemClick
        Dim vSequence As Integer = 0
        If bsRelabelInstructions.Count > 0 Then
            vSequence = bsRelabelInstructions.Current.Sequence
        End If

        Dim frm As New frmAddEditRelabelInstruction
        frm.vEditType = "ADD"
        frm.vSequence = vSequence
        frm.ShowDialog()

        loadData()

        ''On closing need to save the data in the grid editor
        'grvRelabelInstruction.FocusedColumn = colSequence

        'Dim oRelabelInstruction As Relabelinstruction = insertRelabelInstruction(vSequence)
        'loadData()
        'editRelabelInstruction(oRelabelInstruction.Relabelinstructionnumber)
    End Sub

    Private Sub btnEditRelabelInstr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditRelabelInstr.ItemClick
        If bsRelabelInstructions.Count <= 0 Then
            Exit Sub
        End If

        'On closing need to save the data in the grid editor
        grvRelabelInstruction.FocusedColumn = colSequence

        Using frm As New frmAddEditRelabelInstruction() With
           {
              .vEditType = "EDIT",
              .vRelabelInstructionNumber = bsRelabelInstructions.Current.Relabelinstructionnumber
           }
            frm.ShowDialog()
        End Using
        loadData()
    End Sub

    Private Sub btnDeleteRelabelInstr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteRelabelInstr.ItemClick
        If bsRelabelInstructions.Count <= 0 Then
            Exit Sub
        End If
        'On closing need to save the data in the grid editor
        grvRelabelInstruction.FocusedColumn = colSequence

        If MsgBox("Are you sure you want to delete the selected Relabel Instruction.", MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        deleteRelabelInstructionAndResetSeq(bsRelabelInstructions.Current.Relabelinstructionnumber)
        loadData()
    End Sub

    'Private Sub editRelabelInstruction(vRelabelinstructionnumber As Integer, Optional vEditMode As Boolean = True)
    '    colRelabelinstruction.OptionsColumn.AllowEdit = vEditMode

    '    Dim rowHandle As Integer = grvRelabelInstruction.LocateByValue("Relabelinstructionnumber", _
    '                                                                   vRelabelinstructionnumber)
    '    If (rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle) Then
    '        If vEditMode = True Then
    '            grvRelabelInstruction.FocusedRowHandle = rowHandle
    '            grvRelabelInstruction.FocusedColumn = colRelabelinstruction
    '            grvRelabelInstruction.ShowEditor()
    '        End If
    '        grvRelabelInstruction.OptionsBehavior.Editable = vEditMode
    '    End If
    'End Sub

    'Private Sub saveInstructions(Optional vRowHandle As Integer = -1)
    '    If grvRelabelInstruction.OptionsBehavior.Editable Then
    '        bsRelabelInstructions.EndEdit()
    '        Dim vRelabelinstructionnumber As Integer
    '        Dim vRelabelInstruction As String
    '        If vRowHandle >= 0 Then
    '            vRelabelinstructionnumber = grvRelabelInstruction.GetRowCellValue(vRowHandle, _
    '                                                                              colRelabelinstructionnumber)
    '            vRelabelInstruction = grvRelabelInstruction.GetRowCellValue(vRowHandle, _
    '                                                                              colRelabelinstruction)
    '        Else
    '            vRelabelinstructionnumber = bsRelabelInstructions.Current.Relabelinstructionnumber
    '            vRelabelInstruction = bsRelabelInstructions.Current.Relabelinstruction
    '        End If
    '        editRelabelInstruction(vRelabelinstructionnumber, _
    '                               False)
    '        updateRelabelInstruction(vRelabelinstructionnumber, _
    '                                 vRelabelInstruction)
    '    End If
    'End Sub

    'Private Sub grvRelabelInstruction_FocusedColumnChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles grvRelabelInstruction.FocusedColumnChanged
    '    saveInstructions()
    'End Sub

    'Private Sub grvRelabelInstruction_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvRelabelInstruction.FocusedRowChanged
    '    saveInstructions(e.PrevFocusedRowHandle)
    'End Sub

    Private Sub rbtnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMoveUp.ItemClick
        If bsRelabelInstructions.Count <= 0 Then
            Exit Sub
        End If
        If bsRelabelInstructions.Current.Sequence = 1 Then
            Exit Sub
        End If
        Dim vIndex As Integer = grvRelabelInstruction.FocusedRowHandle
        updateTemplateRelabelInstructionSequence(bsRelabelInstructions.Current.Sequence, -1)
        loadData()
        grvRelabelInstruction.FocusedRowHandle = vIndex - 1
    End Sub

    Private Sub rbtnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMoveDown.ItemClick
        If bsRelabelInstructions.Count <= 0 Then
            Exit Sub
        End If
        If bsRelabelInstructions.Current.Sequence = bsRelabelInstructions.Count Then
            Exit Sub
        End If
        Dim vIndex As Integer = grvRelabelInstruction.FocusedRowHandle
        updateTemplateRelabelInstructionSequence(bsRelabelInstructions.Current.Sequence, 1)
        loadData()
        grvRelabelInstruction.FocusedRowHandle = vIndex + 1

    End Sub

    Private Sub updateTemplateRelabelInstructionSequence(vCurrSeq As Integer, vIncrement As Integer)

        Dim oCurr As New Relabelinstruction
        oCurr.Query.Where(oCurr.Query.Sequence.Equal(vCurrSeq))
        If Not oCurr.Query.Load Then
            Exit Sub
        End If

        Dim oNext As New Relabelinstruction
        oNext.Query.Where(oNext.Query.Sequence.Equal(vCurrSeq + vIncrement))
        If Not oNext.Query.Load Then
            Exit Sub
        End If

        oCurr.Sequence = vCurrSeq + vIncrement
        oNext.Sequence = vCurrSeq

        oCurr.Save()
        oNext.Save()
    End Sub
End Class