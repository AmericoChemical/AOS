Public Class frmChangeInventoryItemStatus

    Public vItemNum As Integer
    Dim oItem As Invitem
    Dim oProduct As Product
    Dim oStatusList As ListInvitemstatusCollection

    Private Sub frmChangeInventoryItemStatus_Load(sender As Object, e As EventArgs) Handles Me.Load
        getItemData(vItemNum)
        getStatusList()
    End Sub

    Private Sub getItemData(vItemNum As Integer)
        oItem = New Invitem
        oItem.LoadByPrimaryKey(vItemNum)
        bsItem.DataSource = oItem
        oProduct = New Product
        oProduct.LoadByPrimaryKey(oItem.Productid)
        bsProduct.Datasource = oProduct
    End Sub

    Private Sub getStatusList()
        oStatusList = New ListInvitemstatusCollection
        If oItem.Itemstatus = "RCVDHOLD" Then
            oStatusList.Query.Where(oStatusList.Query.LookupDesc.In("TESTING", "QUARANTINED", "VENDOR", "WASTE"))
            oStatusList.Query.Load()
        Else
            oStatusList.LoadAll()
        End If
        bsStatusList.DataSource = oStatusList
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not validateData() Then
            Exit Sub
        End If
        If Not saveItemChanges() Then
            Exit Sub
        End If
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Function validateData() As Boolean

        If IsDBNull(eStatus.EditValue) Or eStatus.EditValue Is Nothing Then
            MsgBox("You must select a new Item Status to make this status change", MsgBoxStyle.Critical, "Error")
            Return False
        End If

        Select Case eStatus.EditValue
            Case "SHIPPED"
                If eDoc.EditValue = "" Then
                    MsgBox("You must enter a Shipping Document number to make this status change", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
                If IsDBNull(eDate.EditValue) Or eDate.EditValue Is Nothing Then
                    MsgBox("You must enter a Shipped Date number to make this status change", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
            Case "ALLOCATED"
                If eDoc.EditValue = "" Then
                    MsgBox("You must enter a Work Order number to make this status change", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
                If IsDBNull(eDate.EditValue) Or eDate.EditValue Is Nothing Then
                    MsgBox("You must enter an Allocated Date number to make this status change", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
            Case "RETURNED"
                If eDoc.EditValue = "" Then
                    MsgBox("You must enter an RMA number to make this status change", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
                If IsDBNull(eDate.EditValue) Or eDate.EditValue Is Nothing Then
                    MsgBox("You must enter a Returned Date number to make this status change", MsgBoxStyle.Critical, "Error")
                    Return False
                End If
            Case Else

        End Select

        If eReason.Text = "" Then
            MsgBox("You must enter a reason for the status change", MsgBoxStyle.Critical, "Invalid Data")
            Return False
        End If

        Return True

    End Function

    Private Function saveItemChanges() As Boolean

        Dim vStatus As String
        Dim vDoc As String
        Dim vDate As Date
        Dim vReason As String

        Try
            If eDoc.EditValue = "" Then
                vDoc = ""
            Else
                vDoc = eDoc.EditValue
            End If
            If IsDBNull(eDate.EditValue) Or eDate.EditValue Is Nothing Then
                vDate = Nothing
            Else
                vDate = eDate.EditValue
            End If
            vStatus = eStatus.EditValue
            vReason = eReason.EditValue
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        
        'Save changes to Inventory Item record
        Dim oRec As New Invitem
        If Not oRec.LoadByPrimaryKey(vItemNum) Then
            MsgBox("There was an error in updating the status of the selected Inventory Item", MsgBoxStyle.Critical, "ERROR")
            Return False
        End If

        Dim vPriorStatus As String = oRec.Itemstatus
        Try
            oRec.Itemstatus = vStatus
            Select Case vStatus
                Case "SHIPPED"
                    oRec.Shipmentnumber = vDoc
                    oRec.Shippeddate = vDate
                Case "ALLOCATED"
                    oRec.Allocateddocument = vDoc
                    oRec.Allocateddate = vDate
                    oRec.Allocatedtype = "WORKORDER"
                Case "RCVDHOLD"
                    addRcvdHoldRecord(oRec.Invitemnumber, "STATUS CHG", vReason, vPriorStatus, True)
            End Select
            oRec.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        'Save entry to InvPhys table
        Dim oEntry As New Invphys
        Try
            oEntry.Txwho = vCurrentUserLogin
            oEntry.Txtime = Now
            oEntry.Txreason = vReason
            oEntry.Txtype = "CHANGE STATUS"
            oEntry.Invitemnumber = vItemNum
            oEntry.Itemstatus = vStatus
            oEntry.Save()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return True

    End Function

    Private Sub eStatus_EditValueChanged(sender As Object, e As EventArgs) Handles eStatus.EditValueChanged
        Select Case eStatus.EditValue
            Case "SHIPPED"
                lblDoc.Text = "Shipment #:"
                lblDate.Text = "Shipped Date:"
            Case "ALLOCATED"
                lblDoc.Text = "Workorder #:"
                lblDate.Text = "Allocated Date:"
            Case "RETURNED"
                lblDoc.Text = "RMA #:"
                lblDate.Text = "Returned Date:"
            Case Else
                lblDoc.Text = "Document #:"
                lblDate.Text = "Event Date:"
        End Select
    End Sub
End Class