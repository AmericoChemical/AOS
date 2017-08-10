Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class Email
    Private _From As String
    Private _To As String
    Private _CC As String
    Private _Subject As String
    Private _MailBody As String
    Private _FileName As String
    Private _FromName As String
    Private _FolderName As String
    Private _SendStatus As Boolean
    Private _StatusMessage As String
    Private _CalledFrom As String
    Private _IsHTML As Boolean

    Public Property From() As String
        Get
            Return _From
        End Get
        Set(value As String)
            _From = value
        End Set
    End Property

    Public Property [To]() As String
        Get
            Return _To
        End Get
        Set(value As String)
            _To = value
        End Set
    End Property

    Public Property CC() As String
        Get
            Return _CC
        End Get
        Set(value As String)
            _CC = value
        End Set
    End Property

    Public Property Subject() As String
        Get
            Return _Subject
        End Get
        Set(value As String)
            _Subject = value
        End Set
    End Property

    Public Property MailBody() As String
        Get
            Return _MailBody
        End Get
        Set(value As String)
            _MailBody = value
        End Set
    End Property

    Public Property FileName() As String
        Get
            Return _FileName
        End Get
        Set(value As String)
            _FileName = value
        End Set
    End Property

    Public Property FromName() As String
        Get
            Return _FromName
        End Get
        Set(value As String)
            _FromName = value
        End Set
    End Property

    Public Property FolderName() As String
        Get
            Return _FolderName
        End Get
        Set(value As String)
            _FolderName = value
        End Set
    End Property

    Public Property SendStatus() As Boolean
        Get
            Return _SendStatus
        End Get
        Set(value As Boolean)
            _SendStatus = value
        End Set
    End Property

    Public Property StatusMessage() As String
        Get
            Return _StatusMessage
        End Get
        Set(value As String)
            _StatusMessage = value
        End Set
    End Property

    Public Property CalledFrom() As String
        Get
            Return _CalledFrom
        End Get
        Set(value As String)
            _CalledFrom = value
        End Set
    End Property

    Public Property IsHTML() As String
        Get
            Return _IsHTML
        End Get
        Set(value As String)
            _IsHTML = value
        End Set
    End Property

    Public Shared Sub SendMail(email As Email, vHost As String)
        Dim emailClient As New EmailService.EmailServiceClient

        Try
            emailClient.SendMail(email.From, email.To, email.Subject, email.MailBody, email.IsHTML, vHost)
        Catch ex As Exception
            MsgBox(String.Format("Email could not be sent at this time, please try again later. Detailed Message {0}", ex.Message))
        End Try
    End Sub

    'Public Shared Sub SendMail(email As Email, vHost As String)

    '    email.StatusMessage = "Success"

    '    'Create smtpclient object
    '    Dim vClient As New SmtpClient()
    '    Dim vMessage As New MailMessage()
    '    Try
    '        'Create smtpclient object
    '        vClient = New SmtpClient(vHost)

    '        'Set the From Address
    '        If email.FromName <> "" AndAlso email.FromName IsNot Nothing Then
    '            vMessage.From = New MailAddress(email.From, email.FromName)
    '        Else
    '            vMessage.From = New MailAddress(email.From)
    '        End If

    '        For Each ToID As String In email.To.Split(";"c)
    '            'Set the To Address
    '            If Not String.IsNullOrEmpty(ToID) Then
    '                vMessage.To.Add(New MailAddress(ToID.Trim()))
    '            End If
    '        Next

    '        If email.CC IsNot Nothing AndAlso email.CC <> "" Then
    '            For Each CCID As String In email.CC.Split(";"c)
    '                'Set the carbon copy Address 
    '                vMessage.CC.Add(New MailAddress(CCID.Trim()))
    '            Next
    '        End If

    '        vMessage.IsBodyHtml = email.IsHTML
    '        'Assign the Subject
    '        vMessage.Subject = email.Subject
    '        vMessage.Body = email.MailBody

    '        'Send the mail
    '        If vMessage.To.Count > 0 Then
    '            vClient.Send(vMessage)
    '            email.SendStatus = True
    '        Else
    '            email.SendStatus = False
    '            email.StatusMessage = "Failed"
    '        End If
    '    Catch e As Exception
    '        email.SendStatus = False
    '        email.StatusMessage = e.Message
    '    Finally
    '        vMessage.Dispose()
    '        vClient.Dispose()
    '    End Try
    'End Sub

    ''' <summary>
    ''' Send email with the provided details
    ''' </summary>
    ''' <param name="vBody"></param>
    ''' <param name="vFromEmail"></param>
    ''' <param name="vToEmail"></param>
    ''' <param name="vCompanyEmailServer"></param>
    ''' <param name="vSubject"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function SendEmail(vFromEmail As String, vToEmail As String, vCompanyEmailServer As String, vSubject As String, vBody As String) As Boolean
        Dim oPlanEmail As New Email
        With oPlanEmail
            .To = vToEmail
            .From = vFromEmail
            .IsHTML = True
            .MailBody = vBody
            .Subject = vSubject
        End With
        Email.SendMail(oPlanEmail, vCompanyEmailServer)
    End Function

    ''' <summary>
    ''' checking this mail id is valid or not.
    ''' </summary>
    ''' <param name="vEmailIDs"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function IsValidEmailAddress(vEmailIDs) As Boolean
        Dim vEmailExpression As String = "^[a-zA-Z0-9.-][\w\.-]*[a-zA-Z0-9.-_)]@[a-zA-Z0-9.-][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim vEmailID As String
        For Each vEmailID In vEmailIDs.Split(";")
            If vEmailID <> Nothing Then
                Dim vEmailMatch As Match = Regex.Match(vEmailID, vEmailExpression, RegexOptions.IgnoreCase)
                If Not vEmailMatch.Success Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

End Class
