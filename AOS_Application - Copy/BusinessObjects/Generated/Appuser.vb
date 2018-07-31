'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/28/2014 2:39:14 PM
'===============================================================================

Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports System.ComponentModel
Imports System.Xml.Serialization


Imports EntitySpaces.Interfaces
Imports EntitySpaces.Core
Imports EntitySpaces.DynamicQuery

 
Namespace BusinessObjects


	<Serializable> _
	MustInherit Public Class esAppuserCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "AppuserCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAppuserQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntityCollection).Connection
		End Sub

        Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
            Me.PopulateCollection(table)

            If Me.RowCount > 0 Then
                Return True
            Else
                Return False
            End If
        End Function
		
        Protected Overrides Sub HookupQuery(ByVal query As esDynamicQuery)
            Me.InitQuery(CType(query, esAppuserQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Appuser) As Appuser
			Return CType(MyBase.DetachEntity(entity), Appuser)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Appuser) As Appuser
			Return CType(MyBase.AttachEntity(entity), Appuser)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As AppuserCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Appuser
            Get
                Return TryCast(MyBase.Item(index), Appuser)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Appuser)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAppuser	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAppuserQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal appuserid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appuserid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appuserid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal appuserid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appuserid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appuserid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal appuserid As System.Int32) As Boolean
		
			Dim query As esAppuserQuery = Me.GetDynamicQuery()
			query.Where(query.Appuserid.Equal(appuserid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal appuserid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APPUSERID", appuserid)
			
			Return Me.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
#End Region
			
		
#Region "Properties"

		Public Overrides Sub SetProperties(values as IDictionary)

		Dim propertyName As String
			For Each propertyName In values.Keys
				Me.SetProperty(propertyName, values(propertyName))
			Next

		End Sub

		Public Overrides Sub SetProperty(name as string, value as object)

			If Me.Row Is Nothing Then
				Me.AddNew()
			End IF
			
			Dim col As esColumnMetadata = Me.Meta.Columns.FindByPropertyName(name)
			If Not col Is Nothing Then

				If value Is Nothing OrElse value.GetType().ToString() = "System.String" Then

					' Use the strongly typed property
					Select Case name
												
						Case "Appuserid"
							Me.str.Appuserid = CType(value, string)
												
						Case "Userlogin"
							Me.str.Userlogin = CType(value, string)
												
						Case "Userfullname"
							Me.str.Userfullname = CType(value, string)
												
						Case "Userpassword"
							Me.str.Userpassword = CType(value, string)
												
						Case "Usersecuritylevel"
							Me.str.Usersecuritylevel = CType(value, string)
												
						Case "Requestscannerpassword"
							Me.str.Requestscannerpassword = CType(value, string)
												
						Case "Preventscanneraccess"
							Me.str.Preventscanneraccess = CType(value, string)
												
						Case "Scannersessiontimeout"
							Me.str.Scannersessiontimeout = CType(value, string)
												
						Case "Sessionid"
							Me.str.Sessionid = CType(value, string)
												
						Case "Logindatetime"
							Me.str.Logindatetime = CType(value, string)
												
						Case "Dateadded"
							Me.str.Dateadded = CType(value, string)
												
						Case "Dateupdated"
							Me.str.Dateupdated = CType(value, string)
												
						Case "Updatedby"
							Me.str.Updatedby = CType(value, string)
												
						Case "Securitytimer"
							Me.str.Securitytimer = CType(value, string)
												
						Case "Userstatus"
							Me.str.Userstatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Appuserid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Appuserid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Usersecuritylevel"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Usersecuritylevel = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Requestscannerpassword"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Requestscannerpassword = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Preventscanneraccess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Preventscanneraccess = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Scannersessiontimeout"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Scannersessiontimeout = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Logindatetime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Logindatetime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Dateadded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateadded = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Dateupdated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateupdated = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Securitytimer"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Securitytimer = CType(value, Nullable(Of System.Int32))
							End If
						
					
						Case Else
						
					End Select
				End If

			Else If Me.Row.Table.Columns.Contains(name) Then
				Me.Row(name) = value
			Else
				throw New Exception("SetProperty Error: '" + name + "' not found")
			End If	

		End Sub
		
			
		' <summary>
		' Maps to APPUSER.APPUSERID
		' </summary>
		Public Overridable Property Appuserid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppuserMetadata.ColumnNames.Appuserid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppuserMetadata.ColumnNames.Appuserid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.USERLOGIN
		' </summary>
		Public Overridable Property Userlogin As System.String
			Get
				Return MyBase.GetSystemString(AppuserMetadata.ColumnNames.Userlogin)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppuserMetadata.ColumnNames.Userlogin, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.USERFULLNAME
		' </summary>
		Public Overridable Property Userfullname As System.String
			Get
				Return MyBase.GetSystemString(AppuserMetadata.ColumnNames.Userfullname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppuserMetadata.ColumnNames.Userfullname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.USERPASSWORD
		' </summary>
		Public Overridable Property Userpassword As System.String
			Get
				Return MyBase.GetSystemString(AppuserMetadata.ColumnNames.Userpassword)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppuserMetadata.ColumnNames.Userpassword, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.USERSECURITYLEVEL
		' </summary>
		Public Overridable Property Usersecuritylevel As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppuserMetadata.ColumnNames.Usersecuritylevel)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppuserMetadata.ColumnNames.Usersecuritylevel, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.REQUESTSCANNERPASSWORD
		' </summary>
		Public Overridable Property Requestscannerpassword As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(AppuserMetadata.ColumnNames.Requestscannerpassword)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(AppuserMetadata.ColumnNames.Requestscannerpassword, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.PREVENTSCANNERACCESS
		' </summary>
		Public Overridable Property Preventscanneraccess As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(AppuserMetadata.ColumnNames.Preventscanneraccess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(AppuserMetadata.ColumnNames.Preventscanneraccess, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.SCANNERSESSIONTIMEOUT
		' </summary>
		Public Overridable Property Scannersessiontimeout As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppuserMetadata.ColumnNames.Scannersessiontimeout)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppuserMetadata.ColumnNames.Scannersessiontimeout, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.SESSIONID
		' </summary>
		Public Overridable Property Sessionid As System.String
			Get
				Return MyBase.GetSystemString(AppuserMetadata.ColumnNames.Sessionid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppuserMetadata.ColumnNames.Sessionid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.LOGINDATETIME
		' </summary>
		Public Overridable Property Logindatetime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppuserMetadata.ColumnNames.Logindatetime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppuserMetadata.ColumnNames.Logindatetime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.DATEADDED
		' </summary>
		Public Overridable Property Dateadded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppuserMetadata.ColumnNames.Dateadded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppuserMetadata.ColumnNames.Dateadded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.DATEUPDATED
		' </summary>
		Public Overridable Property Dateupdated As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppuserMetadata.ColumnNames.Dateupdated)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppuserMetadata.ColumnNames.Dateupdated, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.UPDATEDBY
		' </summary>
		Public Overridable Property Updatedby As System.String
			Get
				Return MyBase.GetSystemString(AppuserMetadata.ColumnNames.Updatedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppuserMetadata.ColumnNames.Updatedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.SECURITYTIMER
		' </summary>
		Public Overridable Property Securitytimer As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppuserMetadata.ColumnNames.Securitytimer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppuserMetadata.ColumnNames.Securitytimer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSER.USERSTATUS
		' </summary>
		Public Overridable Property Userstatus As System.String
			Get
				Return MyBase.GetSystemString(AppuserMetadata.ColumnNames.Userstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppuserMetadata.ColumnNames.Userstatus, value)
			End Set
		End Property		
		
#End Region	

#Region "String Properties"


		<BrowsableAttribute( false )> _
		Public ReadOnly Property str As esStrings
			Get
				If _esstrings Is Nothing Then
					_esstrings = New esStrings(Me)
				End If
				Return _esstrings
			End Get
		End Property


		<Serializable> _
		NotInheritable Public Class esStrings
		
			Public Sub New(ByVal entity As esAppuser)
				Me.entity = entity
			End Sub				
		
	
			Public Property Appuserid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Appuserid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appuserid = Nothing
					Else
						entity.Appuserid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Userlogin As System.String 
				Get
					Dim data_ As System.String = entity.Userlogin
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Userlogin = Nothing
					Else
						entity.Userlogin = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Userfullname As System.String 
				Get
					Dim data_ As System.String = entity.Userfullname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Userfullname = Nothing
					Else
						entity.Userfullname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Userpassword As System.String 
				Get
					Dim data_ As System.String = entity.Userpassword
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Userpassword = Nothing
					Else
						entity.Userpassword = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Usersecuritylevel As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Usersecuritylevel
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Usersecuritylevel = Nothing
					Else
						entity.Usersecuritylevel = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Requestscannerpassword As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Requestscannerpassword
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Requestscannerpassword = Nothing
					Else
						entity.Requestscannerpassword = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Preventscanneraccess As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Preventscanneraccess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Preventscanneraccess = Nothing
					Else
						entity.Preventscanneraccess = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Scannersessiontimeout As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Scannersessiontimeout
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Scannersessiontimeout = Nothing
					Else
						entity.Scannersessiontimeout = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sessionid As System.String 
				Get
					Dim data_ As System.String = entity.Sessionid
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sessionid = Nothing
					Else
						entity.Sessionid = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logindatetime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Logindatetime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logindatetime = Nothing
					Else
						entity.Logindatetime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dateadded As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateadded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateadded = Nothing
					Else
						entity.Dateadded = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dateupdated As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateupdated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateupdated = Nothing
					Else
						entity.Dateupdated = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Updatedby As System.String 
				Get
					Dim data_ As System.String = entity.Updatedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Updatedby = Nothing
					Else
						entity.Updatedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Securitytimer As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Securitytimer
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Securitytimer = Nothing
					Else
						entity.Securitytimer = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Userstatus As System.String 
				Get
					Dim data_ As System.String = entity.Userstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Userstatus = Nothing
					Else
						entity.Userstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esAppuser
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAppuserQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAppuser can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Appuser 
		Inherits esAppuser
		
	
		
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
        Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
        
            Dim props As New List(Of esPropertyDescriptor)
			

            Return props
			
        End Function	
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostOneSave.
		''' </summary>
		Protected Overrides Sub ApplyPostOneSaveKeys()
		
		End Sub
	End Class
	


	<Serializable> _
	MustInherit Public Class esAppuserQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppuserMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Appuserid As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Appuserid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Userlogin As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Userlogin, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Userfullname As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Userfullname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Userpassword As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Userpassword, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Usersecuritylevel As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Usersecuritylevel, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Requestscannerpassword As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Requestscannerpassword, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Preventscanneraccess As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Preventscanneraccess, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Scannersessiontimeout As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Scannersessiontimeout, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sessionid As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Sessionid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logindatetime As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Logindatetime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateadded As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Dateadded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateupdated As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Dateupdated, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Updatedby As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Updatedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Securitytimer As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Securitytimer, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Userstatus As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserMetadata.ColumnNames.Userstatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("AppuserCollection")> _
	Partial Public Class AppuserCollection
		Inherits esAppuserCollection
		Implements IEnumerable(Of Appuser)
		
        Public Shared Widening Operator CType(ByVal coll As AppuserCollection) As List(Of Appuser)
            Dim list As List(Of Appuser) = New List(Of Appuser)
            Dim emp As Appuser

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppuserMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New AppuserQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Appuser(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Appuser()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As AppuserQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New AppuserQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppuserQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Appuser 
			Return CType(MyBase.AddNewEntity(), Appuser)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal appuserid As System.Int32) As Appuser
			Return CType(MyBase.FindByPrimaryKey(appuserid), Appuser)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Appuser) Implements IEnumerable(Of Appuser).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Appuser)(Me)
        End Function
		
		Private _query As AppuserQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APPUSER' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Appuser ({Appuserid.Value})")> _
	<Serializable> _
	Partial Public Class Appuser 
		Inherits esAppuser

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return AppuserMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAppuserQuery

			If Me._query Is Nothing Then
				Me._query = New AppuserQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As AppuserQuery
			Get

				If Me._query Is Nothing then
					Me._query = New AppuserQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppuserQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As AppuserQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class AppuserQuery
		inherits esAppuserQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "AppuserQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class AppuserMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Appuserid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppuserMetadata.PropertyNames.Appuserid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Userlogin, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppuserMetadata.PropertyNames.Userlogin
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Userfullname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppuserMetadata.PropertyNames.Userfullname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Userpassword, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppuserMetadata.PropertyNames.Userpassword
			c.CharacterMaxLength = 14
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Usersecuritylevel, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppuserMetadata.PropertyNames.Usersecuritylevel
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((2))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Requestscannerpassword, 5, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = AppuserMetadata.PropertyNames.Requestscannerpassword
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Preventscanneraccess, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = AppuserMetadata.PropertyNames.Preventscanneraccess
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Scannersessiontimeout, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppuserMetadata.PropertyNames.Scannersessiontimeout
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((28000))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Sessionid, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppuserMetadata.PropertyNames.Sessionid
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Logindatetime, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppuserMetadata.PropertyNames.Logindatetime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Dateadded, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppuserMetadata.PropertyNames.Dateadded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Dateupdated, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppuserMetadata.PropertyNames.Dateupdated
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Updatedby, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppuserMetadata.PropertyNames.Updatedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Securitytimer, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppuserMetadata.PropertyNames.Securitytimer
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((5000))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserMetadata.ColumnNames.Userstatus, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppuserMetadata.PropertyNames.Userstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As AppuserMetadata
            Return _meta
		End Function
		
        Public ReadOnly Property DataID() As System.Guid Implements IMetadata.DataID
            Get
                Return MyBase._dataID
            End Get
        End Property

        Public ReadOnly Property MultiProviderMode() As Boolean Implements IMetadata.MultiProviderMode
            Get
                Return false
            End Get
        End Property

        Public ReadOnly Property Columns() As esColumnMetadataCollection Implements IMetadata.Columns
            Get
                Return MyBase._columns
            End Get
        End Property		

		
#Region "ColumnNames"
		Public Class ColumnNames
			 Public Const Appuserid As String = "APPUSERID"
			 Public Const Userlogin As String = "USERLOGIN"
			 Public Const Userfullname As String = "USERFULLNAME"
			 Public Const Userpassword As String = "USERPASSWORD"
			 Public Const Usersecuritylevel As String = "USERSECURITYLEVEL"
			 Public Const Requestscannerpassword As String = "REQUESTSCANNERPASSWORD"
			 Public Const Preventscanneraccess As String = "PREVENTSCANNERACCESS"
			 Public Const Scannersessiontimeout As String = "SCANNERSESSIONTIMEOUT"
			 Public Const Sessionid As String = "SESSIONID"
			 Public Const Logindatetime As String = "LOGINDATETIME"
			 Public Const Dateadded As String = "DATEADDED"
			 Public Const Dateupdated As String = "DATEUPDATED"
			 Public Const Updatedby As String = "UPDATEDBY"
			 Public Const Securitytimer As String = "SECURITYTIMER"
			 Public Const Userstatus As String = "USERSTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Appuserid As String = "Appuserid"
			 Public Const Userlogin As String = "Userlogin"
			 Public Const Userfullname As String = "Userfullname"
			 Public Const Userpassword As String = "Userpassword"
			 Public Const Usersecuritylevel As String = "Usersecuritylevel"
			 Public Const Requestscannerpassword As String = "Requestscannerpassword"
			 Public Const Preventscanneraccess As String = "Preventscanneraccess"
			 Public Const Scannersessiontimeout As String = "Scannersessiontimeout"
			 Public Const Sessionid As String = "Sessionid"
			 Public Const Logindatetime As String = "Logindatetime"
			 Public Const Dateadded As String = "Dateadded"
			 Public Const Dateupdated As String = "Dateupdated"
			 Public Const Updatedby As String = "Updatedby"
			 Public Const Securitytimer As String = "Securitytimer"
			 Public Const Userstatus As String = "Userstatus"
		End Class
#End Region	

        Public Function GetProviderMetadata(ByVal mapName As String) As esProviderSpecificMetadata _
            Implements IMetadata.GetProviderMetadata

            Dim mapMethod As MapToMeta = mapDelegates(mapName)

            If (Not mapMethod = Nothing) Then
                Return mapMethod(mapName)
            Else
                Return Nothing
            End If

        End Function	
		
#Region "MAP esDefault"

        Private Shared Function RegisterDelegateesDefault() As Integer
		
            ' This is only executed once per the life of the application
            SyncLock GetType(AppuserMetadata)
			
				If AppuserMetadata.mapDelegates Is Nothing Then
					AppuserMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If AppuserMetadata._meta Is Nothing Then
                    AppuserMetadata._meta = New AppuserMetadata()
                End If

                Dim mapMethod As New MapToMeta(AddressOf _meta.esDefault)
                mapDelegates.Add("esDefault", mapMethod)
                mapMethod("esDefault")
                Return 0

            End SyncLock			
			
        End Function

        Private Function esDefault(ByVal mapName As String) As esProviderSpecificMetadata

            If (Not _providerMetadataMaps.ContainsKey(mapName)) Then
			
				Dim meta As esProviderSpecificMetadata = New esProviderSpecificMetadata()
				

				meta.AddTypeMap("Appuserid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Userlogin", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Userfullname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Userpassword", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Usersecuritylevel", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Requestscannerpassword", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Preventscanneraccess", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Scannersessiontimeout", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sessionid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logindatetime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Dateadded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Dateupdated", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Updatedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Securitytimer", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Userstatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "APPUSER"
				meta.Destination = "APPUSER"
				
				meta.spInsert = "proc_APPUSERInsert"
				meta.spUpdate = "proc_APPUSERUpdate"
				meta.spDelete = "proc_APPUSERDelete"
				meta.spLoadAll = "proc_APPUSERLoadAll"
				meta.spLoadByPrimaryKey = "proc_APPUSERLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As AppuserMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
