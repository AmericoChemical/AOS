Imports AOS.BusinessObjects
Imports System.Text 

Module AuditLogProcessing

    Public Const cAUDITRULEIDPRICING As Integer = 1
    Public Const cAUDITRULEIDPRODUCTCOSTING As Integer = 2
    Public Const cSYSPARAMETERSRECORDID As Integer = 1
    Enum Status
        OPEN
        INPROGRESS
        CLOSED
    End Enum

    Enum AuditLogType
        [WARNING]
        [ERROR]
        [INFO]
    End Enum

    Enum CalledFrom
        PRODUCT
        PRICELIST
        PRODUCTCOST
    End Enum

    Public Sub SaveAuditLogInformation(Category, Description, Type, MasterRecordID, AuditLogAuditReason, CustomerName)
        ChangeSave(Category, Description, Type, MasterRecordID, AuditLogAuditReason, CustomerName)
    End Sub

    Public Sub SaveAuditLogInformation(Category, Description, Type, MasterRecordID, CustomerName)
        ChangeSave(Category, Description, Type, MasterRecordID, CustomerName, String.Empty)
    End Sub

    Public Sub SaveAuditLogInformation(Category, Description, Type, MasterRecordID)
        ChangeSave(Category, Description, Type, MasterRecordID, String.Empty, String.Empty)
    End Sub

    Public Sub SaveAuditLogInformation(Category, Description, MasterRecordID)
        ChangeSave(Category, Description, AuditLogType.ERROR, MasterRecordID, String.Empty, String.Empty)
    End Sub

    Public Sub SaveAuditLogInformation(Description, MasterRecordID)
        ChangeSave(String.Empty, Description, AuditLogType.ERROR, MasterRecordID, String.Empty, String.Empty)
    End Sub

    Public Sub CalculatePriceAndUnits(updatedTextbox As DevExpress.XtraEditors.TextEdit, VolumeunitsSpinEdit As DevExpress.XtraEditors.TextEdit, VolumeTextStandardCost As DevExpress.XtraEditors.TextEdit, WeightunitsTextEdit As DevExpress.XtraEditors.TextEdit, WeightTextStandardCost As DevExpress.XtraEditors.TextEdit, bs As BindingSource, vCalledFrom As CalledFrom)
        ' Variable Declaration
        Dim units As Decimal
        Dim stdCost As Decimal
        Dim otherUnits As Decimal
        Dim otherStdCost As Decimal

        ' Initialization
        units = 0
        If IsNumeric(VolumeunitsSpinEdit.Text) Then
            units = VolumeunitsSpinEdit.Text
        End If

        stdCost = 0
        If (IsNumeric(VolumeTextStandardCost.Text)) Then
            stdCost = VolumeTextStandardCost.Text
        End If

        otherUnits = 0
        If (IsNumeric(WeightunitsTextEdit.Text)) Then
            otherUnits = WeightunitsTextEdit.Text
        End If

        otherStdCost = 0
        If (IsNumeric(WeightTextStandardCost.Text)) Then
            otherStdCost = WeightTextStandardCost.Text
        End If

        If (units <> 0 And otherUnits <> 0 And otherStdCost <> 0 And updatedTextbox.Name <> VolumeTextStandardCost.Name) Then
            stdCost = (otherUnits * otherStdCost) / units
        ElseIf (otherUnits <> 0 And units <> 0 And stdCost <> 0 And updatedTextbox.Name <> WeightTextStandardCost.Name) Then
            otherStdCost = (units * stdCost) / otherUnits
        ElseIf (units = 0) Then
            stdCost = 0
        ElseIf (otherUnits = 0) Then
            otherStdCost = 0
        End If

        'vCalledFrom will return the form name, where it is called from. Since field names were different for Price and Product screen.
        Select Case vCalledFrom
            Case CalledFrom.PRICELIST
                bs.Current.weightPrice = otherStdCost
                bs.Current.volumePrice = stdCost

            Case CalledFrom.PRODUCT
                bs.Current.weightStandardCost = otherStdCost
                bs.Current.volumeStandardCost = stdCost

            Case CalledFrom.PRODUCTCOST
                bs.Current.weightStandardCost = otherStdCost
                bs.Current.volumeStandardCost = stdCost
        End Select

        bs.ResetBindings(False)
    End Sub

    Public Function AuditCheckPriceForLowPrice(ByRef obj As DevExpress.XtraEditors.TextEdit, ByVal vType As PricingMethod, VolumeunitsSpinEdit As DevExpress.XtraEditors.TextEdit, VolumeTextStandardCost As DevExpress.XtraEditors.TextEdit, WeightunitsTextEdit As DevExpress.XtraEditors.TextEdit, WeightTextStandardCost As DevExpress.XtraEditors.TextEdit, bs As BindingSource, vAuditRuleID As Integer, ByRef vFlag As Boolean, vCalledFrom As CalledFrom, Optional oProduct As Product = Nothing) As Boolean

        CalculatePriceAndUnits(obj, VolumeunitsSpinEdit, VolumeTextStandardCost, WeightunitsTextEdit, WeightTextStandardCost, bs, vCalledFrom)

        If vCalledFrom = 2 Then
            Return True
        End If

        If RaiseAuditEvent(vAuditRuleID, bs, vType, vFlag, oProduct) Then
            obj.Focus()
            Return True
        End If
        Return False
    End Function
     
    Public Function RaiseAuditEvent(AuditRuleID As Integer, bs As BindingSource, Type As PricingMethod, ByRef vFlag As Boolean, Optional oProduct As Product = Nothing) As Boolean
        Dim oCustomerList As New ViewCustomerNameByPriceListCollection
        Dim oAuditRule As Auditrule
        Dim vCustomer As New StringBuilder()
        Dim vRowCount As Integer = 0
        Dim vLowPriceCustomerName As String
        Dim vMsg As String
        Dim vMessageType As MsgBoxStyle
        Dim vMessageButtonType As MsgBoxStyle
        Dim vAuditLogAuditReason As String
        Dim vFlagSaved As Boolean
        Dim vFlagShowAuditLog As Boolean

        oAuditRule = New Auditrule
        oAuditRule.Query.Where(oAuditRule.Query.Auditruleid.Equal(AuditRuleID))
        If oAuditRule.Query.Load() Then
            vMessageType = DirectCast([Enum].Parse(GetType(MsgBoxStyle), oAuditRule.Messagetype), MsgBoxStyle)
            vMessageButtonType = DirectCast([Enum].Parse(GetType(MsgBoxStyle), oAuditRule.Messagebuttontype), MsgBoxStyle)
        End If

        Select Case AuditRuleID
            Case cAUDITRULEIDPRICING
                If Val(bs.Current.volumeUnits) = 0 Or _
                  Val(bs.Current.weightUnits) = 0 Or _
                  Val(bs.Current.volumeStandardCost) = 0 Or _
                  Val(bs.Current.weightStandardCost) = 0 Or _
                  String.IsNullOrEmpty(bs.Current.volumeUOM) Or _
                  String.IsNullOrEmpty(bs.Current.weightUOM) Then
                    Return False
                End If
                If Type = PricingMethod.VOLUME Then
                    oCustomerList.Query.Where(oCustomerList.Query.Volumeprice.LessThan(bs.Current.volumeStandardCost), oCustomerList.Query.Productid.Equal(bs.Current.productID), oCustomerList.Query.Volumeuom.Equal(bs.Current.volumeUOM))
                ElseIf Type = PricingMethod.WEIGHT Then
                    oCustomerList.Query.Where(oCustomerList.Query.Weightprice.LessThan(bs.Current.weightStandardCost), oCustomerList.Query.Productid.Equal(bs.Current.productID), oCustomerList.Query.Weightuom.Equal(bs.Current.weightUOM))
                End If

                If oCustomerList.Query.Load() Then
                    For Each oCustomer As ViewCustomerNameByPriceList In oCustomerList
                        vRowCount += 1
                        vCustomer.Append(oCustomer.Custname).Append(IIf(vRowCount = oCustomerList.Count, String.Empty, Chr(13)))
                    Next
                End If
                vLowPriceCustomerName = vCustomer.ToString()

                vMsg = String.Format(oAuditRule.Messagedesc, vLowPriceCustomerName.Replace(Chr(13), ", "))
                If Not String.IsNullOrEmpty(vLowPriceCustomerName) And Not vFlag Then
                    If MsgBox(vMsg, vMessageType + vMessageButtonType, oAuditRule.Messagetitle) = vbYes Then
                        Using frm As New frmAuditReason()
                            frm.ShowDialog()
                            vAuditLogAuditReason = frm.vAuditReason
                            vFlagSaved = frm.vFlagSaved
                        End Using
                        If vFlagSaved Then
                            SaveAuditLogInformation(oAuditRule.Auditcategoryid, vMsg, AuditLogType.WARNING, bs.Current.Productid, vAuditLogAuditReason, vLowPriceCustomerName)
                            vFlag = True
                            Return False
                        End If
                    End If
                    vFlag = False
                    Return True
                End If

            Case cAUDITRULEIDPRODUCTCOSTING

                If Not String.IsNullOrEmpty(bs.Current.volumePrice) Then
                    If oProduct.Volumestandardcost > bs.Current.volumePrice And oProduct.Volumeuom = bs.Current.volumeUOM Then
                        vFlagShowAuditLog = True
                    End If
                End If

                If Not String.IsNullOrEmpty(bs.Current.weightPrice) Then
                    If oProduct.Weightstandardcost > bs.Current.weightPrice And oProduct.Weightuom = bs.Current.weightUOM Then
                        vFlagShowAuditLog = True
                    End If
                End If

                If vFlagShowAuditLog And Not vFlag Then
                    If MsgBox(oAuditRule.Messagedesc, vMessageType + vMessageButtonType, oAuditRule.Messagetitle) = vbYes Then
                        Using frm As New frmAuditReason()
                            frm.ShowDialog()
                            vAuditLogAuditReason = frm.vAuditReason
                            vFlagSaved = frm.vFlagSaved
                        End Using
                        If vFlagSaved Then
                            SaveAuditLogInformation(oAuditRule.Auditcategoryid, oAuditRule.Messagedesc, AuditLogType.WARNING, bs.Current.pricelistID, vAuditLogAuditReason)
                            vFlag = True
                            Return False
                        End If
                    End If
                    vFlag = False
                    Return True
                End If

        End Select
    End Function

    Private Sub ChangeSave(Category As Integer, Description As String, Type As AuditLogType, MasterRecordID As Integer, AuditLogAuditReason As String, CustomerName As String)
        Dim vCustomer As String
        Dim oAuditlog As Auditlog
        Dim vAuditLogIDs As New StringBuilder

        For Each vCustomer In CustomerName.Split(Chr(13))

            oAuditlog = New Auditlog
            oAuditlog.Auditcategoryid = Category
            oAuditlog.Description = Description
            oAuditlog.Type = Type.ToString()
            oAuditlog.Status = Status.OPEN.ToString()
            oAuditlog.Masterrecordid = MasterRecordID
            oAuditlog.Occurrenceby = vCurrentUserLogin
            oAuditlog.Occurrence = System.DateTime.Now
            oAuditlog.Auditreason = AuditLogAuditReason
            oAuditlog.Save()
            vAuditLogIDs.Append(oAuditlog.Auditlogid).Append(",")
        Next
        GenerateAuditMail(vAuditLogIDs)
    End Sub

    Private Sub GenerateAuditMail(vAuditLogIDs As StringBuilder)

        Dim oAuditlog As Auditlog
        Dim oAuditCategory As New Auditcategory
        Dim vMailBody As New StringBuilder()
        Dim vEmail As New Email()

        Dim oAuditLogEmailRecipientList As New ViewAuditLogEmailRecipientsCollection
        Dim oSysparameters As New Sysparameters
        Dim vEmailRecipients As New StringBuilder()
        Dim vAuditLogID As String

        For Each vAuditLogID In vAuditLogIDs.ToString().Split(",")
            If Not String.IsNullOrEmpty(vAuditLogID) Then
                vEmailRecipients = New StringBuilder()
                vEmail = New Email()
                vMailBody = New StringBuilder()

                oSysparameters.Query.Where(oSysparameters.Query.RecordID.Equal(cSYSPARAMETERSRECORDID))
                oSysparameters.Query.Load()

                oAuditlog = New Auditlog
                oAuditlog.Query.Where(oAuditlog.Query.Auditlogid.Equal(vAuditLogID))
                If oAuditlog.Query.Load() Then
                    oAuditLogEmailRecipientList.Query.Where(oAuditLogEmailRecipientList.Query.Auditcategoryid.Equal(oAuditlog.Auditcategoryid))
                    If oAuditLogEmailRecipientList.Query.Load() Then
                        For Each oAuditLogEmailRecipient As ViewAuditLogEmailRecipients In oAuditLogEmailRecipientList
                            vEmailRecipients.Append(oAuditLogEmailRecipient.Userlogin).Append("@").Append(oSysparameters.CompanyEmailDomain).Append(";")
                        Next
                    End If
                    oAuditCategory.Query.Where(oAuditCategory.Query.Auditcategoryid.Equal(oAuditlog.Auditcategoryid))
                    oAuditCategory.Query.Load()

                    vEmail.From = String.Format("admin@{0}", oSysparameters.CompanyEmailDomain)

                    vMailBody.AppendLine("An AOS Audit Event has occurred. Details are below;")
                    vMailBody.AppendLine(String.Empty)
                    vMailBody.Append("Audit Log ID: ").AppendLine(oAuditlog.Auditlogid)
                    vMailBody.Append("Category: ").AppendLine(oAuditCategory.Auditcategory)
                    vMailBody.Append("Master Record ID: ").AppendLine(oAuditlog.Masterrecordid)
                    vMailBody.Append("Message Description: ").AppendLine(oAuditlog.Description)
                    vMailBody.Append("Audit Reason: ").AppendLine(oAuditlog.Auditreason)
                    vMailBody.Append("Occurrence Date: ").AppendLine(oAuditlog.Occurrence)
                    vMailBody.Append("Occurrence By: ").AppendLine(oAuditlog.Occurrenceby)
                    vMailBody.Append("Status: ").AppendLine(oAuditlog.Status)
                    vMailBody.Append("Type: ").AppendLine(oAuditlog.Type)

                    vEmail.Subject = String.Format("YOUR ATTENTION NEEDED - Audit Category: {0}", oAuditCategory.Auditcategory)
                    vEmail.To = vEmailRecipients.ToString()
                    vEmail.MailBody = vMailBody.ToString()
                    vEmail.IsHTML = False

                    Email.SendMail(vEmail, oSysparameters.CompanyEmailServer)
                End If
            End If
        Next
    End Sub

End Module

