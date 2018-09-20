
Imports AOS.BusinessObjects
Imports System.Windows.Forms
Imports System.IO

Public Class frmFreightChargesHistory
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub

    Public vLoadID As Integer   'ShipmentNumber passed from calling form for edit and review of shipment
    Dim oLoadInfo As ViewLoadInfo
    Dim oFreightChargeHistory As ViewLoadInfoCollection

    'Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    Timer1.Stop()
    'End Sub

    Private Sub getLoadInfo()

        oLoadInfo = New ViewLoadInfo
        oLoadInfo.Query.Where(oLoadInfo.Query.LoadID.Equal(vLoadID))
        If Not (oLoadInfo.Query.Load()) Then
            MsgBox("Could not retrieve selected Load from the database", MsgBoxStyle.Critical, "Error")
            Me.Close()
        End If
        bsLoadInfo.DataSource = oLoadInfo
        txtVariance.Text = 10
        txtTotalWeight.Text = oLoadInfo.TotalGrossWeight
        If (oLoadInfo.TotalSkids.HasValue) Then
            txtSkids.Text = oLoadInfo.TotalSkids.Value.ToString()
        Else
            txtSkids.Text = ""
        End If
        If (oLoadInfo.FreezeProtectFlag.HasValue) Then
            chkFreezeProtect.Checked = oLoadInfo.FreezeProtectFlag
        Else
            chkFreezeProtect.Checked = False
        End If


    End Sub


    Private Sub getFreightChargeHistory()
        Dim VarianceValue As Decimal
        oFreightChargeHistory = New ViewLoadInfoCollection
        oFreightChargeHistory.Query.Where(oFreightChargeHistory.Query.LoadID.NotEqual(oLoadInfo.LoadID))
        oFreightChargeHistory.Query.Where(oFreightChargeHistory.Query.CustID.Equal(oLoadInfo.CustID))
        oFreightChargeHistory.Query.Where(oFreightChargeHistory.Query.DestID.Equal(oLoadInfo.DestID))
        If (txtSkids.Text <> "") Then
            oFreightChargeHistory.Query.Where(oFreightChargeHistory.Query.TotalSkids.Equal(txtSkids.Text))
        End If

        If (txtTotalWeight.Text <> "") Then
            If txtVariance.Text <> "" Then
                VarianceValue = txtTotalWeight.Text * (txtVariance.Text) / 100
            End If
            Dim startRange As Decimal = txtTotalWeight.Text - VarianceValue
            Dim endRange As Decimal = txtTotalWeight.Text + VarianceValue

            oFreightChargeHistory.Query.Where(oFreightChargeHistory.Query.TotalGrossWeight.Between(startRange, endRange))
        End If
        If (chkFreezeProtect.Checked) Then
            oFreightChargeHistory.Query.Where(oFreightChargeHistory.Query.FreezeProtectFlag.Equal(chkFreezeProtect.Checked))
        End If

        oFreightChargeHistory.Query.Load()
        Try
            bsLoadChargeHistory.DataSource = oFreightChargeHistory
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnCancel_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnClose.ItemClick
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmFreightChargesHistory_Load(sender As Object, e As EventArgs) Handles Me.Load
        getLoadInfo()
        getFreightChargeHistory()

    End Sub
    Private Function GetFreightHistoryChargeReport() As rptFreightChargeHistory
        Dim matchingLoadsIds As New List(Of Integer)
        For Each i As Integer In grvFreightChargesHistory.GetSelectedRows()
            Dim row As ViewLoadInfo = grvFreightChargesHistory.GetRow(i)
            matchingLoadsIds.Add(row.LoadID)
        Next
        Dim rtpFreightChargesHistory As New rptFreightChargeHistory(vLoadID, matchingLoadsIds)
        Return rtpFreightChargesHistory
    End Function

    Private Sub rbtEmailFreightChargesHistory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtEmailFreightChargesHistory.ItemClick
        Dim mem As New MemoryStream
        Dim rtpFreightChargesHistory As rptFreightChargeHistory = GetFreightHistoryChargeReport()
        rtpFreightChargesHistory.ExportToHtml(mem)
        mem.Position = 0
        Dim sr As New StreamReader(mem)
        Dim emailBody = sr.ReadToEnd()
        sr.Dispose()


        Dim oMySettings As New My.MySettings
        Dim oEmailparameters As Emailparameters = oMySettings.getEmailParameters("FreightHistoryCharges")

        Dim historyEmail As New Email
        historyEmail.Subject = String.Format("Freight For Load#:{0}, Cust:{1}", oLoadInfo.LoadID, oLoadInfo.Custname)
        historyEmail.MailBody = emailBody
        If (oEmailparameters Is Nothing) Then
            historyEmail.From = "custserv@americochemical.com"
            '            historyEmail.To = "vsharma@americochemical.com"
            'historyEmail.To = "JDeFlorio@Americochemical.com"
            'historyEmail.CC = "CBerry@Americochemical.com"
        Else
            historyEmail.From = oEmailparameters.EmailFrom
            historyEmail.To = oEmailparameters.EmailTo
            historyEmail.CC = oEmailparameters.EmailCC
        End If
        Dim ofrmEmail As New frmEmail
        ofrmEmail.vEmail = historyEmail
        If (ofrmEmail.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        'Dim oMySettings As New My.MySettings
        'Dim oSysparameters As Sysparameters = oMySettings.getSystemParameters()
        'If oSysparameters Is Nothing = False Then
        '    historyEmail.SendEmail(oSysparameters.WOEmailSender,
        '            String.Format("{0};{1}",
        '                          "vsharma@americochemical.com",
        '                          oSysparameters.Additionaldefaultsendtoaddress),
        '            oSysparameters.Companyemailserver,
        '            "Freight Charges History For Load#" & vLoadID,
        '            emailBody)
        'End If



    End Sub

    Private Sub rbtnLoadFreightCharges_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnLoadFreightCharges.ItemClick
        getFreightChargeHistory()

    End Sub

    Private Sub rbtnPrint_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles rbtnPrint.ItemClick
        Dim rtpFreightChargesHistory As rptFreightChargeHistory = GetFreightHistoryChargeReport()
        rtpFreightChargesHistory.ShowPreview()

    End Sub


    'Private Sub btnPrintBOL_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrintBOL.ItemClick
    '    printBOL()
    'End Sub

    'Private Sub printBOL()
    '    bsLoadInfo.EndEdit()
    '    oLoad.EndEdit()
    '    oLoad.Save()
    '    Dim rpt As New rptBillOfLading2(vLoadID)
    '    rpt.ShowPreview()
    'End Sub


End Class