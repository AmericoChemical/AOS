Imports AOS.BusinessObjects

Public Class frmEmailPlan
    Inherits DevExpress.XtraEditors.XtraForm

    Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
    End Sub
    Public oWorkOrderEmailPlan As Workorderemailplan
    Public vWorkOrderNumber As Integer
    Public vCustomerName As String
    Dim oWOEmail As New Email
    Public vSenderId As String
    Public vReceiverId As String
    Public oSysparameters As Sysparameters

    Private Sub frmEmailSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addEmailPlan()
    End Sub
    Private Sub addEmailPlan()
        Dim oWorkOrder As New Workorder()
        If oWorkOrder.LoadByPrimaryKey(vWorkOrderNumber) = False Then
            MsgBox("Invalid Work Order Number", MsgBoxStyle.OkOnly, "Email Plan - Error")
            Me.DialogResult = Windows.Forms.DialogResult.No
            Exit Sub
        End If
        oWorkOrderEmailPlan = New Workorderemailplan
        oWorkOrderEmailPlan.AddNew()
        SenderTextEdit.EditValue = vSenderId
        oWorkOrderEmailPlan.Toemailid = vReceiverId
        oWorkOrderEmailPlan.Subjecttext = String.Format("{0} - DELV: {1} - WO#: {2}", _
                                                        vCustomerName, _
                                                        formatDate(oWorkOrder.Deliverydate), _
                                                        vWorkOrderNumber)
        oWorkOrderEmailPlan.Bodytext = getEmailBodyText()
        oWorkOrderEmailPlan.Createdby = vCurrentUserLogin
        oWorkOrderEmailPlan.Createdtime = Now
        oWorkOrderEmailPlan.Save()
        Me.bsWorkOrderEmailPlan.DataSource = oWorkOrderEmailPlan
    End Sub

    Private Function getEmailBodyText()
        Dim vWriterForEmailBody As New System.IO.StringWriter
        Dim vBodyStatement As String = Nothing
        Dim vTblEmailBodyStatement As System.Web.UI.HtmlControls.HtmlTable = workOrderPlanSummary(vWorkOrderNumber)

        If vTblEmailBodyStatement Is Nothing = False Then
            Dim oHTMLWriter As New System.Web.UI.Html32TextWriter(vWriterForEmailBody)
            vTblEmailBodyStatement.RenderControl(oHTMLWriter)
            vBodyStatement = Convert.ToString(vWriterForEmailBody)
        End If
        Return vBodyStatement
    End Function

    Private Sub btnSend_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSend.ItemClick
        bsWorkOrderEmailPlan.EndEdit()
        If ValidateControls() Then
            oWorkOrderEmailPlan.Bodytext = BodyStatementRichEditControl.HtmlText
            oWorkOrderEmailPlan.Save()
            oWOEmail.SendEmail(oSysparameters.WOEmailSender, _
                               String.Format("{0};{1}", _
                                             oWorkOrderEmailPlan.Toemailid, _
                                             oSysparameters.Additionaldefaultsendtoaddress), _
                               oSysparameters.Companyemailserver, _
                               oWorkOrderEmailPlan.Subjecttext, _
                               oWorkOrderEmailPlan.Bodytext)
            MsgBox("Email successfully sent.", MsgBoxStyle.OkOnly, "Success")
            Me.DialogResult = Windows.Forms.DialogResult.Yes
        End If
    End Sub
    Private Sub btnCancel_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnCancel.ItemClick
        bsWorkOrderEmailPlan.CancelEdit()
        oWorkOrderEmailPlan.MarkAsDeleted()
        oWorkOrderEmailPlan.Save()
        Me.DialogResult = Windows.Forms.DialogResult.No
    End Sub
    Private Function ValidateControls() As Boolean
        If bsWorkOrderEmailPlan.Current.Toemailid Is Nothing _
            OrElse IsDBNull(bsWorkOrderEmailPlan.Current.Toemailid) = True _
            OrElse bsWorkOrderEmailPlan.Current.Toemailid = "" Then
            MsgBox("Please enter To Email ID.", MsgBoxStyle.Critical, "Error")
            Return False
        Else
            If oWOEmail.IsValidEmailAddress(bsWorkOrderEmailPlan.Current.Toemailid) = False Then
                MsgBox("Please enter valid To Email ID(s).", MsgBoxStyle.Critical, "Error")
                Return False
            End If
        End If
        If bsWorkOrderEmailPlan.Current.Subjecttext Is Nothing _
            OrElse IsDBNull(bsWorkOrderEmailPlan.Current.Subjecttext) = True _
            OrElse bsWorkOrderEmailPlan.Current.Subjecttext = "" Then
            MsgBox("Please enter Subject.", MsgBoxStyle.Critical, "Error")
            SubjectTextEdit.Focus()
            Return False
        End If
        Return True
    End Function
End Class