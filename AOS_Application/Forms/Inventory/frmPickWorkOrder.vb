Imports AOS.BusinessObjects
Imports AOS.dsWorkOrderInvItemsTableAdapters

Public Class frmPickWorkOrder
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)


    'here is where you dimension your object variables for the form
    Dim oWO As Workorder
    Dim oItem As Invitem
    Dim oCustomers As CustomerCollection
    Dim oProducts As ProductCollection
    Dim daAllocated As dsWorkOrderInvItemsTableAdapters.WORKORDERINVITEMTableAdapter
    Dim daPicked As dsWorkOrderInvItemsTableAdapters.WORKORDERINVITEMTableAdapter

    Private vErrorSoundFileName As String
    Private vSuccessSoundFileName As String

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadData()
    End Sub

    Private Sub loadData()

        vErrorSoundFileName = Application.StartupPath & "\errorsound.wav"

        getWorkOrder(vID)
        getProducts()
        getCustomers()
        getItems(vID)
        eInvItemNum.Focus()

    End Sub

    Private Sub getWorkOrder(ByVal vID As Integer)
        oWO = New Workorder
        oWO.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oWO.LoadByPrimaryKey(vID)
        If oWO Is Nothing Then
            MsgBox("Work Order not found", MsgBoxStyle.Critical, "Error - No Workorder")
            Me.DialogResult = Windows.Forms.DialogResult.Abort
        End If
        bsWorkOrder.DataSource = oWO
    End Sub

    Private Sub getProducts()
        oProducts = New ProductCollection
        oProducts.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oProducts.LoadAll()
        oProducts.Sort = "ProductDesc"
        bsProducts.DataSource = oProducts
    End Sub

    Private Sub getCustomers()
        oCustomers = New CustomerCollection
        oCustomers.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        oCustomers.LoadAll()
        oCustomers.Sort = "CustName"
        bsCustomers.DataSource = oCustomers
    End Sub

    Private Sub getItems(ByVal vID As Integer)

        'get allocated items for work order
        Dim daAllocated As New dsWorkOrderInvItemsTableAdapters.WORKORDERINVITEMTableAdapter
        Dim dtAllocated As New dsWorkOrderInvItems.WORKORDERINVITEMDataTable
        Try
            daAllocated.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            daAllocated.Fill(dtAllocated, vID, "ALLOCATED")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        bsAllocated.DataSource = dtAllocated
        grAllocated.DataSource = bsAllocated

        'get picked items for work order
        Dim daPicked As New dsWorkOrderInvItemsTableAdapters.WORKORDERINVITEMTableAdapter
        Dim dtPicked As New dsWorkOrderInvItems.WORKORDERINVITEMDataTable
        Try
            daPicked.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
            daPicked.Fill(dtPicked, vID, "PICKED")
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        bsPicked.DataSource = dtPicked
        grPicked.DataSource = bsPicked
    End Sub

    Private Function changesSaved() As Boolean
        Try
            oWO.EndEdit()
            oWO.Save()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Private Function changesCancelled() As Boolean
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub

    Private Sub eInvItemNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles eInvItemNum.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            Dim vNum As Integer
            Try
                vNum = CInt(eInvItemNum.Text)
            Catch ex As Exception
                Beep()
                MsgBox("You must enter an integer value", MsgBoxStyle.Critical, "Error - invalid Item Number")
                eInvItemNum.Text = ""
                eInvItemNum.Focus()
                Exit Sub
            End Try

            updateItems(vNum)

        End If

    End Sub

    Private Sub updateItems(ByVal vItem As Integer)

        Dim I As Integer = 0
        Dim x As Integer
        oItem = New Invitem
        oItem.es.Connection.ConnectionString = sqlcnn.ConnectionString & ";password=" & My.Settings.SQLDatabaseUserPassword
        x = oItem.LoadByPrimaryKey(vItem)
        If x <> -1 Then     'item not found
            'For I = 1 To 500   ' Loop 100 times.
            '    Beep()   ' Sound a tone.
            'Next I
            playMediaFile(vErrorSoundFileName)
            eInvItemNum.Text = ""
            eInvItemNum.Focus()
            Exit Sub
        End If

        If oItem.Allocateddocument <> CStr(vID) Or oItem.Itemstatus <> "ALLOCATED" Then
            'For I = 1 To 500   ' Loop 100 times.
            '    Beep()   ' Sound a tone.
            'Next I
            playMediaFile(vErrorSoundFileName)
            eInvItemNum.Text = ""
            eInvItemNum.Focus()
            Exit Sub
        End If

        'at this point, the item is valid and is on the work order - now update it
        oItem.Itemstatus = "PICKED"
        oItem.Save()

        eInvItemNum.Text = ""
        eInvItemNum.Focus()

        getItems(vID)

    End Sub

End Class