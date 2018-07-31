Imports AOS.BusinessObjects

Public Class frmAddEditCustomer
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer       'object primary key (passed in by calling form for edit mode)
    Public vEditType As String  'operating mode (passed in by calling form)

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = ""

    'here is where you dimension your object variables for the form
    Dim oItem As Customer
    Dim oCarriers As CarrierCollection
    Dim oBulkCarriers As CarrierCollection
    Dim oLogistics As LogisticsCollection
    Dim oSales As SalespersonCollection
    Dim oFOB As ListFobCollection

    Private Sub frmAddEdit_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vEditType = "ADD" Then
            Me.Text = "Adding New " & vObjectName
        Else
            Me.Text = "Editing " & vObjectName & " Information"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        loadLookupLists()
        loadData()
    End Sub

    Private Sub loadLookupLists()

        oCarriers = New CarrierCollection
        oCarriers.LoadAll()
        oCarriers.Sort = "CARRIERNAME"
        bsCarriers.DataSource = oCarriers

        oBulkCarriers = New CarrierCollection
        oBulkCarriers.LoadAll()
        oBulkCarriers.Sort = "CARRIERNAME"
        bsBulkCarriers.DataSource = oBulkCarriers

        oSales = New SalespersonCollection
        oSales.LoadAll()
        bsSalespersons.DataSource = oSales
        bsSalespersons2.DataSource = oSales

        oLogistics = New LogisticsCollection
        oLogistics.LoadAll()
        oLogistics.Sort = "LOGISTICSNAME"
        bsLogistics.DataSource = oLogistics

        oFOB = New ListFobCollection
        oFOB.LoadAll()
        bsFOB.DataSource = oFOB

    End Sub

    Private Sub loadData()
        If vEditType = "ADD" Then
            addNewObject()
        Else
            editObject(vID)
        End If
    End Sub

    Private Sub addNewObject()
        oItem = New Customer
        oItem.AddNew()
        'assign foreign key values here
        oItem.Createdby = vCurrentUserLogin
        oItem.Createdtime = Now
        oItem.Modifyby = vCurrentUserLogin
        oItem.Modifytime = Now
        oItem.Save()
        vID = oItem.Custid
        Me.bsItem.DataSource = oItem
        updateDataHistory()
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If vID = Nothing Then
            MsgBox("There is not Record ID selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Customer
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
        updateDataHistory()
    End Sub

    Private Sub updateDataHistory()
        If IsDBNull(oItem.Createdby) Or oItem.Createdby = Nothing Then
            lblCreated.Text = ""
        Else
            lblCreated.Text = "Created on " & IIf(IsDBNull(oItem.Createdtime), "", FormatDateTime(oItem.Createdtime, DateFormat.GeneralDate)) & IIf(IsDBNull(oItem.Createdby), "", " by " & oItem.Createdby)
        End If
        If IsDBNull(oItem.Modifyby) Or oItem.Modifyby = Nothing Then
            lblModified.Text = ""
        Else
            lblModified.Text = "Last Modified on " & IIf(IsDBNull(oItem.Modifytime), "", FormatDateTime(oItem.Modifytime, DateFormat.GeneralDate)) & IIf(IsDBNull(oItem.Modifyby), "", " by " & oItem.Modifyby)
        End If
    End Sub

    Private Function changesSaved() As Boolean
        Try
            bsItem.EndEdit()
            oItem.EndEdit()
            oItem.Modifyby = vCurrentUserLogin
            oItem.Modifytime = Now
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