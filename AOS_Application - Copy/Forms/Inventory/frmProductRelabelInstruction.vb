Imports AOS.BusinessObjects

Public Class frmProductRelabelInstruction
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vFulfillmentPlanID As Integer       'object primary key (passed in by calling form for edit mode)
 
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()
        bsProductRelabelInstruction.DataSource = getProductRelabelInstructions(vFulfillmentPlanID)
        bsRelabelTemplateInstructions.DataSource = getRelabelInstructions()
    End Sub

    Private Sub btnClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnInsertRelabelInstr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInsertRelabelInstr.ItemClick
        Dim vSequence As Integer = 0

        If bsProductRelabelInstruction.Count > 0 Then
            vSequence = bsProductRelabelInstruction.Current.Sequence
        End If

        Dim frm As New frmAddEditProductRelabelInstruction
        frm.vEditType = "ADD"
        frm.vFulfillmentPlanID = vFulfillmentPlanID
        frm.ShowDialog()

        loadData()

    End Sub

    Private Sub btnEditRelabelInstr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditRelabelInstr.ItemClick
        If bsProductRelabelInstruction.Count <= 0 Then
            Exit Sub
        End If

        Dim frm As New frmAddEditProductRelabelInstruction
        frm.vEditType = "EDIT"
        frm.vFulfillmentPlanID = vFulfillmentPlanID
        frm.vProductRelabelInstructionNumber = bsProductRelabelInstruction.Current.ProductRelabelInstructionNumber
        frm.ShowDialog()
        loadData()
    End Sub

    Private Sub btnDeleteRelabelInstr_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDeleteRelabelInstr.ItemClick
        If bsProductRelabelInstruction.Count <= 0 Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to delete the selected Product Relabel Instruction.", MsgBoxStyle.YesNo, "Confirm Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        deleteProductRelabelInstructionAndResetSeq(bsProductRelabelInstruction.Current.Productrelabelinstructionnumber)
        loadData()
    End Sub

    'Private Sub editRelabelInstruction(vProductRelabelinstructionnumber As Integer, Optional vEditMode As Boolean = True)
    '    colRelabelinstruction.OptionsColumn.AllowEdit = vEditMode

    '    Dim rowHandle As Integer = grvProductRelabelInstruction.LocateByValue("Productrelabelinstructionnumber", _
    '                                                                   vProductRelabelinstructionnumber)
    '    If (rowHandle <> DevExpress.XtraGrid.GridControl.InvalidRowHandle) Then
    '        If vEditMode = True Then
    '            grvProductRelabelInstruction.FocusedRowHandle = rowHandle
    '            grvProductRelabelInstruction.FocusedColumn = colRelabelinstruction
    '            grvProductRelabelInstruction.ShowEditor()
    '        End If
    '        grvProductRelabelInstruction.OptionsBehavior.Editable = vEditMode
    '    End If
    'End Sub

    'Private Sub saveInstructions(Optional vRowHandle As Integer = -1)
    '    If grvProductRelabelInstruction.OptionsBehavior.Editable Then
    '        bsProductRelabelInstruction.EndEdit()
    '        Dim vProductRelabelinstructionnumber As Integer
    '        Dim vRelabelInstruction As String
    '        If vRowHandle >= 0 Then
    '            vProductRelabelinstructionnumber = grvProductRelabelInstruction.GetRowCellValue(vRowHandle, _
    '                                                                              colRelabelinstructionnumber)
    '            vRelabelInstruction = grvProductRelabelInstruction.GetRowCellValue(vRowHandle, _
    '                                                                              colRelabelinstruction)
    '        Else
    '            vProductRelabelinstructionnumber = bsProductRelabelInstruction.Current.Productrelabelinstructionnumber
    '            vRelabelInstruction = bsProductRelabelInstruction.Current.Relabelinstruction
    '        End If
    '        editRelabelInstruction(vProductRelabelinstructionnumber, _
    '                               False)
    '        updateProductRelabelInstruction(vProductRelabelinstructionnumber, _
    '                                        vRelabelInstruction)
    '    End If
    'End Sub

    'Private Sub grvProductRelabelInstruction_FocusedColumnChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles grvProductRelabelInstruction.FocusedColumnChanged
    '    saveInstructions()
    'End Sub

    'Private Sub grvProductRelabelInstruction_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvProductRelabelInstruction.FocusedRowChanged
    '    saveInstructions(e.PrevFocusedRowHandle)
    'End Sub

    Private Sub rbtnMoveUp_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMoveUp.ItemClick
        If bsProductRelabelInstruction.Count <= 0 Then
            Exit Sub
        End If
        If bsProductRelabelInstruction.Position = 0 Then
            Exit Sub
        End If
        If bsProductRelabelInstruction.Current.Sequence = 1 Then
            Exit Sub
        End If
        Dim vIndex As Integer = grvProductRelabelInstruction.FocusedRowHandle
        updateProductRelabelInstructionSequence(bsProductRelabelInstruction.Current.Sequence, -1, bsProductRelabelInstruction.Current.FulFillmentPlanID)
        loadData()
        grvProductRelabelInstruction.FocusedRowHandle = vIndex - 1
    End Sub

    Private Sub rbtnMoveDown_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnMoveDown.ItemClick
        If bsProductRelabelInstruction.Count <= 0 Then
            Exit Sub
        End If
        If bsProductRelabelInstruction.Current.Sequence = bsProductRelabelInstruction.Count Then
            Exit Sub
        End If
        Dim vIndex As Integer = grvProductRelabelInstruction.FocusedRowHandle
        updateProductRelabelInstructionSequence(bsProductRelabelInstruction.Current.Sequence, 1, bsProductRelabelInstruction.Current.FulFillmentPlanID)
        loadData()
        grvProductRelabelInstruction.FocusedRowHandle = vIndex + 1

    End Sub
    Private Sub updateProductRelabelInstructionSequence(vCurrSeq As Integer, vIncrement As Integer, vPlanID As Integer)

        Dim oCurr As New Productrelabelinstruction
        oCurr.Query.Where(oCurr.Query.Sequence.Equal(vCurrSeq), oCurr.Query.Fulfillmentplanid.Equal(vPlanID))
        If Not oCurr.Query.Load Then
            Exit Sub
        End If

        Dim oNext As New Productrelabelinstruction
        oNext.Query.Where(oNext.Query.Sequence.Equal(vCurrSeq + vIncrement), oCurr.Query.Fulfillmentplanid.Equal(vPlanID))
        If Not oNext.Query.Load Then
            Exit Sub
        End If

        oCurr.Sequence = vCurrSeq + vIncrement
        oNext.Sequence = vCurrSeq

        oCurr.Save()
        oNext.Save()
    End Sub
End Class