Public Class frmLoadProcessing 
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    Public vLoadID As Integer
    Private oLoadInfo As ViewLoadInfo
    Private oQuotes As ViewLoadQuotesByLoadIDCollection
    Private oLoadItems As ViewLoadItemsDisplayCollection

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        getLoadData(vLoadID)
    End Sub

    Private Sub getLoadData(vID As Integer)

        oLoadInfo = New ViewLoadInfo
        oLoadInfo.Query.Where(oLoadInfo.Query.LoadID.Equal(vID))
        oLoadInfo.Query.Load()
        bsLoadInfo.DataSource = oLoadInfo

        oLoadItems = New ViewLoadItemsDisplayCollection
        oLoadItems.Query.Where(oLoadItems.Query.LoadID.Equal(vID))
        oLoadItems.Query.Load()
        bsLoadItems.DataSource = oLoadItems

        oQuotes = New ViewLoadQuotesByLoadIDCollection
        oQuotes.Query.Where(oQuotes.Query.LoadID.Equal(vID))
        oQuotes.Query.Load()
        bsLoadQuotes.DataSource = oQuotes

        setQuoteButtons()

        If oLoadInfo.LoadType = "DIRECT" Then
            btnSelectVendor.Visible = True
        Else
            btnSelectVendor.Visible = False
        End If

    End Sub

    Private Sub setQuoteButtons()
        If bsLoadQuotes.Count <= 0 Then
            rbtnEditQuote.Enabled = False
            rbtnDeleteQuote.Enabled = False
        Else
            rbtnEditQuote.Enabled = True
            rbtnDeleteQuote.Enabled = True
        End If
    End Sub

    Private Sub updateLoadData()
        Dim oLoad As New Load
        If oLoad.LoadByPrimaryKey(bsLoadInfo.Current.LoadID) Then
            oLoad.ModifiedBy = vCurrentUserLogin
            oLoad.ModifiedTime = Now
            oLoad.Save()
        End If
    End Sub

    Private Sub rbtnBack_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnBack.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Yes
    End Sub

    Private Sub rbtnAddQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnAddQuote.ItemClick
        Dim frm As New frmAddEditLoadQuote
        frm.vLoadID = vLoadID
        frm.vEditType = "ADD"
        frm.ShowDialog()
        updateLoadData()
        getLoadData(vLoadID)
    End Sub

    Private Sub rbtnEditQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditQuote.ItemClick
        If bsLoadQuotes.Count <= 0 Then
            Exit Sub
        End If
        Dim frm As New frmAddEditLoadQuote
        frm.vID = bsLoadQuotes.Current.LoadQuoteID
        frm.vLoadID = vLoadID
        frm.vEditType = "EDIT"
        frm.ShowDialog()
        updateLoadData()
        getLoadData(vLoadID)
    End Sub

    Private Sub rbtnDeleteQuote_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteQuote.ItemClick
        If bsLoadQuotes.Count <= 0 Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to delete the selected Load Quote?", MsgBoxStyle.YesNo, "Confirm Quote Deletion") = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim oQu As New Loadquote
        If oQu.LoadByPrimaryKey(bsLoadQuotes.Current.LoadQuoteID) Then
            oQu.MarkAsDeleted()
            oQu.Save()
        End If
        updateLoadData()
        getLoadData(vLoadID)
    End Sub

    Private Sub rbtnEditCharges_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditCharges.ItemClick
        Dim oChrgs As New LoadchargeCollection
        oChrgs.Query.Where(oChrgs.Query.LoadID.Equal(vLoadID))
        oChrgs.Query.Load()
        Select Case oChrgs.Count
            Case 0
                Dim frm As New frmAddEditLoadCharge
                frm.vEditType = "ADD"
                frm.vLoadID = vLoadID
                frm.ShowDialog()
            Case 1
                Dim frm As New frmAddEditLoadCharge
                frm.vEditType = "EDIT"
                frm.vID = oChrgs(0).LoadChargeID
                frm.ShowDialog()
            Case Is > 1
                'need to show more than one record for user to select from
            Case Else
                Exit Sub
        End Select
        getLoadData(vLoadID)
    End Sub

    Private Sub rbtnEditBillings_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnEditBillings.ItemClick
        Dim oBills As New LoadbillingCollection
        oBills.Query.Where(oBills.Query.Loadid.Equal(vLoadID))
        oBills.Query.Load()
        Select Case oBills.Count
            Case 0
                Dim frm As New frmAddEditLoadBilling
                frm.vEditType = "ADD"
                frm.vLoadID = vLoadID
                frm.vCustID = oLoadInfo.CustID
                frm.ShowDialog()
            Case 1
                Dim frm As New frmAddEditLoadBilling
                frm.vEditType = "EDIT"
                frm.vID = oBills(0).Loadbillingid
                frm.ShowDialog()
            Case Is > 1
                'need to show more than one record for user to select from
            Case Else
                Exit Sub
        End Select
        getLoadData(vLoadID)
    End Sub

    Private Sub rbtnSchedule_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnSchedule.ItemClick

        Dim vQ As Integer

        If bsLoadQuotes.Count > 0 Then
            If MsgBox("Do you want to schedule this load using the selected Carrier Quote record?", MsgBoxStyle.YesNo, "Confirm - Use Selected Quote") = MsgBoxResult.Yes Then
                vQ = bsLoadQuotes.Current.LoadQuoteID
            Else
                vQ = 0
            End If
        End If

        Dim frm As New frmScheduleLoad
        frm.vQuoteID = vQ
        frm.vLoadID = vLoadID
        frm.ShowDialog()
        getLoadData(vLoadID)
    End Sub

    Private Sub rbtnPrintLoadInfo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrintLoadInfo.ItemClick

        Dim rpt As New rptLoadDataSheet(bsLoadInfo.Current.LoadID)
        rpt.ShowPreviewDialog()

    End Sub

    Private Sub rbtnDeleteLoadBillingRecs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnDeleteLoadBillingRecs.ItemClick

        Dim str As String = "Are you sure you want to delete all Billing records related to this Load?"
        If MsgBox(str, MsgBoxStyle.YesNo, "Confirm Deletion Request") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim oBillings As New LoadbillingCollection
        oBillings.Query.Where(oBillings.Query.Loadid.Equal(vLoadID))
        If oBillings.Query.Load Then
            Try
                For Each oBilling As Loadbilling In oBillings
                    If oBilling.InvoiceNumber > 0 Then
                    Else
                        oBilling.MarkAsDeleted()
                    End If
                Next
                oBillings.Save()
                MsgBox("All Billing records not linked to an invoice have been successfully deleted.")
            Catch ex As Exception
                MsgBox("Error in deleting Billing records", MsgBoxStyle.Critical, ex.Message)
            End Try
        End If
        getLoadData(vLoadID)
    End Sub

    Private Sub btnSelectVendor_Click(sender As Object, e As EventArgs) Handles btnSelectVendor.Click
        Dim frm As New frmVendorList
        frm.ShowDialog()
        If frm.vID > 0 Then
            updateLoadOrigin("VENDOR", frm.vID)
        End If
        getLoadData(vLoadID)
    End Sub

    Private Sub updateLoadOrigin(OriginType As String, vID As Integer)
        Select Case OriginType
            Case "VENDOR"
                Dim oVendor As New Vendor
                oVendor.LoadByPrimaryKey(vID)
                Dim oLoad As New Load
                oLoad.LoadByPrimaryKey(vLoadID)
                oLoad.OriginType = "VENDOR"
                oLoad.OriginID = vID
                oLoad.OriginName = oVendor.Vendorname
                oLoad.OriginAddress1 = oVendor.Vendoraddress1
                oLoad.OriginAddress2 = oVendor.Vendoraddress2
                oLoad.OriginCity = oVendor.Vendorcity
                oLoad.OriginContact = oVendor.Vendorcity
                oLoad.OriginCountry = "UNITED STATES"
                oLoad.OriginState = oVendor.Vendorstate
                oLoad.OriginPhone = oVendor.Vendorstate
                oLoad.OriginZip = oVendor.Vendorzip
                oLoad.Save()
        End Select
    End Sub


End Class