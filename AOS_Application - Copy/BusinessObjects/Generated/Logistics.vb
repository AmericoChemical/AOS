'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:57 PM
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
	MustInherit Public Class esLogisticsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LogisticsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLogisticsQuery)
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
            Me.InitQuery(CType(query, esLogisticsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Logistics) As Logistics
			Return CType(MyBase.DetachEntity(entity), Logistics)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Logistics) As Logistics
			Return CType(MyBase.AttachEntity(entity), Logistics)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LogisticsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Logistics
            Get
                Return TryCast(MyBase.Item(index), Logistics)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Logistics)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLogistics	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLogisticsQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal logisticsid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(logisticsid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(logisticsid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal logisticsid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(logisticsid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(logisticsid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal logisticsid As System.Int32) As Boolean
		
			Dim query As esLogisticsQuery = Me.GetDynamicQuery()
			query.Where(query.Logisticsid.Equal(logisticsid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal logisticsid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LOGISTICSID", logisticsid)
			
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
												
						Case "Logisticsid"
							Me.str.Logisticsid = CType(value, string)
												
						Case "Logisticsname"
							Me.str.Logisticsname = CType(value, string)
												
						Case "Logisticsaddr1"
							Me.str.Logisticsaddr1 = CType(value, string)
												
						Case "Logisticsaddr2"
							Me.str.Logisticsaddr2 = CType(value, string)
												
						Case "Logisticscity"
							Me.str.Logisticscity = CType(value, string)
												
						Case "Logisticsstate"
							Me.str.Logisticsstate = CType(value, string)
												
						Case "Logisticszip"
							Me.str.Logisticszip = CType(value, string)
												
						Case "Logisticsphone"
							Me.str.Logisticsphone = CType(value, string)
												
						Case "Logisticsfax"
							Me.str.Logisticsfax = CType(value, string)
												
						Case "Logisticscontact"
							Me.str.Logisticscontact = CType(value, string)
												
						Case "Logisticsermail"
							Me.str.Logisticsermail = CType(value, string)
												
						Case "Logisticsweburl"
							Me.str.Logisticsweburl = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createtime"
							Me.str.Createtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Logisticsid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Logisticsid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isactive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isactive = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Createtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to LOGISTICS.LOGISTICSID
		' </summary>
		Public Overridable Property Logisticsid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LogisticsMetadata.ColumnNames.Logisticsid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LogisticsMetadata.ColumnNames.Logisticsid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSADDR1
		' </summary>
		Public Overridable Property Logisticsaddr1 As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticsaddr1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticsaddr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSADDR2
		' </summary>
		Public Overridable Property Logisticsaddr2 As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticsaddr2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticsaddr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSCITY
		' </summary>
		Public Overridable Property Logisticscity As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticscity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticscity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSSTATE
		' </summary>
		Public Overridable Property Logisticsstate As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticsstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticsstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSZIP
		' </summary>
		Public Overridable Property Logisticszip As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticszip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticszip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSPHONE
		' </summary>
		Public Overridable Property Logisticsphone As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticsphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticsphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSFAX
		' </summary>
		Public Overridable Property Logisticsfax As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticsfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticsfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSCONTACT
		' </summary>
		Public Overridable Property Logisticscontact As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticscontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticscontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSERMAIL
		' </summary>
		Public Overridable Property Logisticsermail As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticsermail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticsermail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.LOGISTICSWEBURL
		' </summary>
		Public Overridable Property Logisticsweburl As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Logisticsweburl)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Logisticsweburl, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(LogisticsMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(LogisticsMetadata.ColumnNames.Isactive, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.CREATETIME
		' </summary>
		Public Overridable Property Createtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LogisticsMetadata.ColumnNames.Createtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LogisticsMetadata.ColumnNames.Createtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(LogisticsMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LogisticsMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOGISTICS.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LogisticsMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LogisticsMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esLogistics)
				Me.entity = entity
			End Sub				
		
	
			Public Property Logisticsid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Logisticsid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsid = Nothing
					Else
						entity.Logisticsid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsname As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsname = Nothing
					Else
						entity.Logisticsname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsaddr1 As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsaddr1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsaddr1 = Nothing
					Else
						entity.Logisticsaddr1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsaddr2 As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsaddr2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsaddr2 = Nothing
					Else
						entity.Logisticsaddr2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticscity As System.String 
				Get
					Dim data_ As System.String = entity.Logisticscity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticscity = Nothing
					Else
						entity.Logisticscity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsstate As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsstate = Nothing
					Else
						entity.Logisticsstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticszip As System.String 
				Get
					Dim data_ As System.String = entity.Logisticszip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticszip = Nothing
					Else
						entity.Logisticszip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsphone As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsphone = Nothing
					Else
						entity.Logisticsphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsfax As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsfax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsfax = Nothing
					Else
						entity.Logisticsfax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticscontact As System.String 
				Get
					Dim data_ As System.String = entity.Logisticscontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticscontact = Nothing
					Else
						entity.Logisticscontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsermail As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsermail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsermail = Nothing
					Else
						entity.Logisticsermail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsweburl As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsweburl
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsweburl = Nothing
					Else
						entity.Logisticsweburl = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isactive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isactive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isactive = Nothing
					Else
						entity.Isactive = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdby As System.String 
				Get
					Dim data_ As System.String = entity.Createdby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdby = Nothing
					Else
						entity.Createdby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createtime = Nothing
					Else
						entity.Createtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifyby As System.String 
				Get
					Dim data_ As System.String = entity.Modifyby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifyby = Nothing
					Else
						entity.Modifyby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifytime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifytime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifytime = Nothing
					Else
						entity.Modifytime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLogistics
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLogisticsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLogistics can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Logistics 
		Inherits esLogistics
		
	
		
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
	MustInherit Public Class esLogisticsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LogisticsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Logisticsid As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticsid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr1 As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticsaddr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr2 As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticsaddr2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscity As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticscity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsstate As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticsstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticszip As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticszip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsphone As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticsphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsfax As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticsfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscontact As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticscontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsermail As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticsermail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsweburl As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Logisticsweburl, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createtime As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Createtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, LogisticsMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LogisticsCollection")> _
	Partial Public Class LogisticsCollection
		Inherits esLogisticsCollection
		Implements IEnumerable(Of Logistics)
		
        Public Shared Widening Operator CType(ByVal coll As LogisticsCollection) As List(Of Logistics)
            Dim list As List(Of Logistics) = New List(Of Logistics)
            Dim emp As Logistics

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LogisticsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LogisticsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Logistics(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Logistics()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LogisticsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LogisticsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LogisticsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Logistics 
			Return CType(MyBase.AddNewEntity(), Logistics)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal logisticsid As System.Int32) As Logistics
			Return CType(MyBase.FindByPrimaryKey(logisticsid), Logistics)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Logistics) Implements IEnumerable(Of Logistics).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Logistics)(Me)
        End Function
		
		Private _query As LogisticsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LOGISTICS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Logistics ({Logisticsid.Value})")> _
	<Serializable> _
	Partial Public Class Logistics 
		Inherits esLogistics

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LogisticsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLogisticsQuery

			If Me._query Is Nothing Then
				Me._query = New LogisticsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LogisticsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LogisticsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LogisticsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LogisticsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LogisticsQuery
		inherits esLogisticsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LogisticsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LogisticsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticsid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticsid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticsname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticsaddr1, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticsaddr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticsaddr2, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticsaddr2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticscity, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticscity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticsstate, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticsstate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticszip, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticszip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticsphone, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticsphone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticsfax, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticsfax
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticscontact, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticscontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticsermail, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticsermail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Logisticsweburl, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Logisticsweburl
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Isactive, 12, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Isactive
			c.HasDefault = True
			c.Default = "((1))"
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Createdby, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Createtime, 14, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Createtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Modifyby, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LogisticsMetadata.ColumnNames.Modifytime, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LogisticsMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LogisticsMetadata
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
			 Public Const Logisticsid As String = "LOGISTICSID"
			 Public Const Logisticsname As String = "LOGISTICSNAME"
			 Public Const Logisticsaddr1 As String = "LOGISTICSADDR1"
			 Public Const Logisticsaddr2 As String = "LOGISTICSADDR2"
			 Public Const Logisticscity As String = "LOGISTICSCITY"
			 Public Const Logisticsstate As String = "LOGISTICSSTATE"
			 Public Const Logisticszip As String = "LOGISTICSZIP"
			 Public Const Logisticsphone As String = "LOGISTICSPHONE"
			 Public Const Logisticsfax As String = "LOGISTICSFAX"
			 Public Const Logisticscontact As String = "LOGISTICSCONTACT"
			 Public Const Logisticsermail As String = "LOGISTICSERMAIL"
			 Public Const Logisticsweburl As String = "LOGISTICSWEBURL"
			 Public Const Isactive As String = "ISACTIVE"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createtime As String = "CREATETIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Logisticsid As String = "Logisticsid"
			 Public Const Logisticsname As String = "Logisticsname"
			 Public Const Logisticsaddr1 As String = "Logisticsaddr1"
			 Public Const Logisticsaddr2 As String = "Logisticsaddr2"
			 Public Const Logisticscity As String = "Logisticscity"
			 Public Const Logisticsstate As String = "Logisticsstate"
			 Public Const Logisticszip As String = "Logisticszip"
			 Public Const Logisticsphone As String = "Logisticsphone"
			 Public Const Logisticsfax As String = "Logisticsfax"
			 Public Const Logisticscontact As String = "Logisticscontact"
			 Public Const Logisticsermail As String = "Logisticsermail"
			 Public Const Logisticsweburl As String = "Logisticsweburl"
			 Public Const Isactive As String = "Isactive"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createtime As String = "Createtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
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
            SyncLock GetType(LogisticsMetadata)
			
				If LogisticsMetadata.mapDelegates Is Nothing Then
					LogisticsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LogisticsMetadata._meta Is Nothing Then
                    LogisticsMetadata._meta = New LogisticsMetadata()
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
				

				meta.AddTypeMap("Logisticsid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Logisticsname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsaddr1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsaddr2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticscity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticszip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticscontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsermail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsweburl", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "LOGISTICS"
				meta.Destination = "LOGISTICS"
				
				meta.spInsert = "proc_LOGISTICSInsert"
				meta.spUpdate = "proc_LOGISTICSUpdate"
				meta.spDelete = "proc_LOGISTICSDelete"
				meta.spLoadAll = "proc_LOGISTICSLoadAll"
				meta.spLoadByPrimaryKey = "proc_LOGISTICSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LogisticsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
