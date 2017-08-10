Imports AOS.BusinessObjects

Public Class frmAddEditPOMiscItem
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (InvoiceItemNumber) (passed in by calling form for edit mode)
    Public vPONumber As Integer     'Invoice Number foreign key
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Miscellaneous Charge"

    'here is where you dimension your object variables for the form
    Dim oItem As Poitem

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
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
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oItem = New Poitem
        oItem.AddNew()
        'assign foreign key values here
        oItem.Ponumber = vPONumber
        oItem.Qtycanceled = 0
        oItem.Qtyordered = 1
        oItem.Qtyreceived = 0
        oItem.Qtyreleased = 1
        oItem.Save()
        Me.bsItem.DataSource = oItem
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Poitem
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsItem.EndEdit()
            oItem.Qtyordered = 1
            oItem.Uom = "MISC"
            oItem.Units = 1
            oItem.Container = ""
            setItemTotals()
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
            If vEditType = "ADD" Then
                oItem.MarkAsDeleted()
                oItem.Save()
            End If
        Catch ex As Exception
          End Try
        Return True
    End Function

    Private Sub setItemTotals()
        oItem.EndEdit()     'save user's last edits
        oItem.BeginEdit()
        oItem.Extcost = CDbl(oItem.Qtyordered) * CDbl(oItem.Unitcost)
        oItem.EndEdit()
        oItem.Save()
    End Sub

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