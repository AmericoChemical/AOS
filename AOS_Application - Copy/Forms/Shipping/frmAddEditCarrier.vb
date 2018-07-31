Imports AOS.BusinessObjects

Public Class frmAddEditCarrier
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vID As Integer
    Public vEditType As String

    'here is where you set the name of the object (i.e. Client, Contact, etc.)
    Friend vObjectName As String = "Freight Carrier"

    'here is where you dimension your object variables for the form
    Dim oItem As Carrier

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
        oItem = New Carrier
        oItem.AddNew()
        oItem.Createdby = vCurrentUserLogin
        oItem.Createdtime = Now
        oItem.Modifyby = vCurrentUserLogin
        oItem.Modifytime = Now
        oItem.EndEdit()
        oItem.Save()
        vID = oItem.CarrierID
        Me.bsItem.DataSource = oItem
        updateTimeLabels()
    End Sub

    Private Sub editObject(ByVal vID As Integer)
        If IsDBNull(vID) Then
            MsgBox("There is no Carrier Record selected", MsgBoxStyle.Critical, "Edit Failed")
            Exit Sub
        End If
        oItem = New Carrier
        oItem.LoadByPrimaryKey(vID)
        Me.bsItem.DataSource = oItem
        updateTimeLabels()
    End Sub

    Private Sub updateTimeLabels()
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
            'If oItemList.Container Is Nothing Then
            '    MsgBox("You must enter a Container name", MsgBoxStyle.Critical, "Error - No Container Name")
            '    Me.eContainer.Focus()
            '    Return False
            'End If
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

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        If changesSaved() Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If changesCancelled() Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End If
    End Sub


End Class