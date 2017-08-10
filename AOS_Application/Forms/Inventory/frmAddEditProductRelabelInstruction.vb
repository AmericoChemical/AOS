Imports AOS.BusinessObjects

Public Class frmAddEditProductRelabelInstruction
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vProductRelabelInstructionNumber As Integer       'object primary key (passed in by calling form for edit mode)
    Public vFulfillmentPlanID As Integer
    Public vEditType As String  'operating mode (passed in by calling form)
    Public vSequence As Integer

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Product Relabel Instruction"

    'here is where you dimension your object variables for the form
    Dim oProductRelabelInstruction As Productrelabelinstruction

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
            editObject(vProductRelabelInstructionNumber)
        End If
    End Sub

    Private Sub addNewObject()
        oProductRelabelInstruction = New Productrelabelinstruction
        oProductRelabelInstruction.Fulfillmentplanid = vFulfillmentPlanID
        oProductRelabelInstruction.Sequence = getProductRelabelInstructionMaxSequence(vFulfillmentPlanID) + 1
        oProductRelabelInstruction.Createdby = vCurrentUserLogin
        oProductRelabelInstruction.Createdtime = Now
        oProductRelabelInstruction.Save()
        Me.bsProductRelabelInstruction.DataSource = oProductRelabelInstruction
        getProductData()
    End Sub

    Private Sub editObject(ByVal vProductRelabelInstructionNumber As Integer)
        If vProductRelabelInstructionNumber = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oProductRelabelInstruction = New Productrelabelinstruction
        oProductRelabelInstruction.LoadByPrimaryKey(vProductRelabelInstructionNumber)
        Me.bsProductRelabelInstruction.DataSource = oProductRelabelInstruction
        getProductData()
    End Sub

    Private Sub getProductData()

        Dim oPlan As New Productfulfillmentplan
        oPlan.LoadByPrimaryKey(oProductRelabelInstruction.Fulfillmentplanid)

        Dim rProd As New Product
        rProd.LoadByPrimaryKey(oPlan.Associatedproductid)

        Dim fProd As New Product
        fProd.LoadByPrimaryKey(oPlan.Productid)

        eRlblProductID.EditValue = rProd.Productid
        eRlblProductDesc.EditValue = rProd.Productdesc
        eFinalProductID.EditValue = fProd.Productid
        eFinalProductDesc.EditValue = fProd.Productdesc

    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsProductRelabelInstruction.EndEdit()
            oProductRelabelInstruction.EndEdit()
            'If checkProductRelabelInsSequenceExists(oProductRelabelInstruction.Fulfillmentplanid, _
            '                     oProductRelabelInstruction.Sequence, _
            '                     oProductRelabelInstruction.Productrelabelinstructionnumber) Then
            '    'If selected sequence is greater than the current sequence then need to increate the sequence by 1
            '    'This is alternate way, instead of getting the target sequence and reducing the requence of that record
            '    Dim oOldProductRelabelInstruction As New Productrelabelinstruction
            '    If oOldProductRelabelInstruction.LoadByPrimaryKey(oProductRelabelInstruction.Productrelabelinstructionnumber) = False Then
            '        Return False
            '    End If

            '    If oOldProductRelabelInstruction.Sequence < oProductRelabelInstruction.Sequence Then
            '        oProductRelabelInstruction.Sequence = oProductRelabelInstruction.Sequence + 1
            '    End If

            '    updateProductRelabelInstructionSequence(oProductRelabelInstruction.Fulfillmentplanid, _
            '                                            oProductRelabelInstruction.Sequence)
            'End If
            oProductRelabelInstruction.Modifyby = vCurrentUserLogin
            oProductRelabelInstruction.Modifytime = Now
            oProductRelabelInstruction.Save()

            updateProductRelabelInstructionSequence(oProductRelabelInstruction.Fulfillmentplanid)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error saving changes", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Try
            bsProductRelabelInstruction.CancelEdit()
            oProductRelabelInstruction.CancelEdit()
            If vEditType = "ADD" Then
                'If vSequence > 0 Then
                '    updateRelabelInstructionSequence()
                'End If
                oProductRelabelInstruction.MarkAsDeleted()
                oProductRelabelInstruction.Save()
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