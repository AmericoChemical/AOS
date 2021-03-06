﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace EmailService
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="EmailService.IEmailService")>  _
    Public Interface IEmailService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEmailService/SendMail", ReplyAction:="http://tempuri.org/IEmailService/SendMailResponse")>  _
        Function SendMail(ByVal emailFrom As String, ByVal emailTo As String, ByVal emailSubject As String, ByVal emailBody As String, ByVal isHTML As Boolean, ByVal vHost As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEmailService/SendMail", ReplyAction:="http://tempuri.org/IEmailService/SendMailResponse")>  _
        Function SendMailAsync(ByVal emailFrom As String, ByVal emailTo As String, ByVal emailSubject As String, ByVal emailBody As String, ByVal isHTML As Boolean, ByVal vHost As String) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEmailService/TestMethod", ReplyAction:="http://tempuri.org/IEmailService/TestMethodResponse")>  _
        Function TestMethod(ByVal a As Integer, ByVal b As Integer) As Integer
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IEmailService/TestMethod", ReplyAction:="http://tempuri.org/IEmailService/TestMethodResponse")>  _
        Function TestMethodAsync(ByVal a As Integer, ByVal b As Integer) As System.Threading.Tasks.Task(Of Integer)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IEmailServiceChannel
        Inherits EmailService.IEmailService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class EmailServiceClient
        Inherits System.ServiceModel.ClientBase(Of EmailService.IEmailService)
        Implements EmailService.IEmailService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function SendMail(ByVal emailFrom As String, ByVal emailTo As String, ByVal emailSubject As String, ByVal emailBody As String, ByVal isHTML As Boolean, ByVal vHost As String) As Boolean Implements EmailService.IEmailService.SendMail
            Return MyBase.Channel.SendMail(emailFrom, emailTo, emailSubject, emailBody, isHTML, vHost)
        End Function
        
        Public Function SendMailAsync(ByVal emailFrom As String, ByVal emailTo As String, ByVal emailSubject As String, ByVal emailBody As String, ByVal isHTML As Boolean, ByVal vHost As String) As System.Threading.Tasks.Task(Of Boolean) Implements EmailService.IEmailService.SendMailAsync
            Return MyBase.Channel.SendMailAsync(emailFrom, emailTo, emailSubject, emailBody, isHTML, vHost)
        End Function
        
        Public Function TestMethod(ByVal a As Integer, ByVal b As Integer) As Integer Implements EmailService.IEmailService.TestMethod
            Return MyBase.Channel.TestMethod(a, b)
        End Function
        
        Public Function TestMethodAsync(ByVal a As Integer, ByVal b As Integer) As System.Threading.Tasks.Task(Of Integer) Implements EmailService.IEmailService.TestMethodAsync
            Return MyBase.Channel.TestMethodAsync(a, b)
        End Function
    End Class
End Namespace
