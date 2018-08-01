Imports AOS.BusinessObjects

Public Class frmEmail
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    Public vEmail As Email
    Dim oMySettings As New My.MySettings
    Dim oSysparameters As Sysparameters = oMySettings.getSystemParameters()


    Private Sub frmEmailSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmail()
    End Sub
    Private Sub LoadEmail()
        SenderTextEdit.EditValue = vEmail.From
        ReceiverTextEdit.EditValue = vEmail.To
        ccTextEdit.EditValue = vEmail.CC
        SubjectTextEdit.EditValue = vEmail.Subject
        BodyStatementRichEditControl.HtmlText = vEmail.MailBody
    End Sub

    Private Sub btnSend_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSend.ItemClick
        vEmail.From = SenderTextEdit.EditValue
        vEmail.To = ReceiverTextEdit.EditValue
        vEmail.CC = ccTextEdit.EditValue
        vEmail.Subject = SubjectTextEdit.EditValue
        vEmail.MailBody = BodyStatementRichEditControl.HtmlText
        If (Not String.IsNullOrEmpty(vEmail.CC)) Then
            vEmail.To = String.Format("{0};{1}", vEmail.To, vEmail.CC)
        End If
        If ValidateControls() Then
            vEmail.MailBody = BodyStatementRichEditControl.HtmlText
            vEmail.SendEmail(oSysparameters.WOEmailSender,
                               String.Format("{0};{1}",
                                             vEmail.To,
                                             oSysparameters.Additionaldefaultsendtoaddress),
                               oSysparameters.Companyemailserver,
                               vEmail.Subject,
                               vEmail.MailBody)
            MsgBox("Email successfully sent.", MsgBoxStyle.OkOnly, "Success")
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub
    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Function ValidateControls() As Boolean
        If String.IsNullOrEmpty(ReceiverTextEdit.EditValue) Then
            MsgBox("Please enter To Email ID.", MsgBoxStyle.Critical, "Error")
            Return False
        Else
            If vEmail.IsValidEmailAddress(ReceiverTextEdit.EditValue) = False Then
                MsgBox("Please enter valid To Email ID(s).", MsgBoxStyle.Critical, "Error")
                ReceiverTextEdit.Focus()
                Return False
            End If
        End If
        If String.IsNullOrEmpty(SubjectTextEdit.EditValue) Then
            MsgBox("Please enter Subject.", MsgBoxStyle.Critical, "Error")
            SubjectTextEdit.Focus()
            Return False
        End If
        Return True
    End Function
End Class