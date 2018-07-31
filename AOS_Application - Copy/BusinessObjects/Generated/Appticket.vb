'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/22/2016 1:21:36 PM
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
	MustInherit Public Class esAppticketCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "AppticketCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAppticketQuery)
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
            Me.InitQuery(CType(query, esAppticketQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Appticket) As Appticket
			Return CType(MyBase.DetachEntity(entity), Appticket)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Appticket) As Appticket
			Return CType(MyBase.AttachEntity(entity), Appticket)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As AppticketCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Appticket
            Get
                Return TryCast(MyBase.Item(index), Appticket)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Appticket)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAppticket	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAppticketQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal ticketid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(ticketid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(ticketid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal ticketid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(ticketid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(ticketid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal ticketid As System.Int32) As Boolean
		
			Dim query As esAppticketQuery = Me.GetDynamicQuery()
			query.Where(query.Ticketid.Equal(ticketid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal ticketid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("TICKETID", ticketid)
			
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
												
						Case "Ticketid"
							Me.str.Ticketid = CType(value, string)
												
						Case "Shortdesc"
							Me.str.Shortdesc = CType(value, string)
												
						Case "Fulldesc"
							Me.str.Fulldesc = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifiedby"
							Me.str.Modifiedby = CType(value, string)
												
						Case "Modifiedtime"
							Me.str.Modifiedtime = CType(value, string)
												
						Case "Category"
							Me.str.Category = CType(value, string)
												
						Case "Priority"
							Me.str.Priority = CType(value, string)
												
						Case "Estcompletion"
							Me.str.Estcompletion = CType(value, string)
												
						Case "Actcompletion"
							Me.str.Actcompletion = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Ticketid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Ticketid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifiedtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifiedtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Priority"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Priority = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Estcompletion"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Estcompletion = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Actcompletion"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Actcompletion = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Userdoc"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Byte()" Then
								Me.Userdoc = CType(value, System.Byte())
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
		' Maps to APPTICKET.TICKETID
		' </summary>
		Public Overridable Property Ticketid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppticketMetadata.ColumnNames.Ticketid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppticketMetadata.ColumnNames.Ticketid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.SHORTDESC
		' </summary>
		Public Overridable Property Shortdesc As System.String
			Get
				Return MyBase.GetSystemString(AppticketMetadata.ColumnNames.Shortdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppticketMetadata.ColumnNames.Shortdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.FULLDESC
		' </summary>
		Public Overridable Property Fulldesc As System.String
			Get
				Return MyBase.GetSystemString(AppticketMetadata.ColumnNames.Fulldesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppticketMetadata.ColumnNames.Fulldesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(AppticketMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppticketMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppticketMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppticketMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.MODIFIEDBY
		' </summary>
		Public Overridable Property Modifiedby As System.String
			Get
				Return MyBase.GetSystemString(AppticketMetadata.ColumnNames.Modifiedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppticketMetadata.ColumnNames.Modifiedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.MODIFIEDTIME
		' </summary>
		Public Overridable Property Modifiedtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppticketMetadata.ColumnNames.Modifiedtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppticketMetadata.ColumnNames.Modifiedtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.CATEGORY
		' </summary>
		Public Overridable Property Category As System.String
			Get
				Return MyBase.GetSystemString(AppticketMetadata.ColumnNames.Category)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppticketMetadata.ColumnNames.Category, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.PRIORITY
		' </summary>
		Public Overridable Property Priority As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppticketMetadata.ColumnNames.Priority)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppticketMetadata.ColumnNames.Priority, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.ESTCOMPLETION
		' </summary>
		Public Overridable Property Estcompletion As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppticketMetadata.ColumnNames.Estcompletion)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppticketMetadata.ColumnNames.Estcompletion, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.ACTCOMPLETION
		' </summary>
		Public Overridable Property Actcompletion As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppticketMetadata.ColumnNames.Actcompletion)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppticketMetadata.ColumnNames.Actcompletion, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPTICKET.USERDOC
		' </summary>
		Public Overridable Property Userdoc As System.Byte()
			Get
				Return MyBase.GetSystemByteArray(AppticketMetadata.ColumnNames.Userdoc)
			End Get
			
			Set(ByVal value As System.Byte())
				MyBase.SetSystemByteArray(AppticketMetadata.ColumnNames.Userdoc, value)
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
		
			Public Sub New(ByVal entity As esAppticket)
				Me.entity = entity
			End Sub				
		
	
			Public Property Ticketid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Ticketid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ticketid = Nothing
					Else
						entity.Ticketid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shortdesc As System.String 
				Get
					Dim data_ As System.String = entity.Shortdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shortdesc = Nothing
					Else
						entity.Shortdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fulldesc As System.String 
				Get
					Dim data_ As System.String = entity.Fulldesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fulldesc = Nothing
					Else
						entity.Fulldesc = Convert.ToString(Value)
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
		  	
			Public Property Createdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdtime = Nothing
					Else
						entity.Createdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifiedby As System.String 
				Get
					Dim data_ As System.String = entity.Modifiedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifiedby = Nothing
					Else
						entity.Modifiedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifiedtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifiedtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifiedtime = Nothing
					Else
						entity.Modifiedtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Category As System.String 
				Get
					Dim data_ As System.String = entity.Category
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Category = Nothing
					Else
						entity.Category = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priority As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Priority
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priority = Nothing
					Else
						entity.Priority = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Estcompletion As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Estcompletion
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Estcompletion = Nothing
					Else
						entity.Estcompletion = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Actcompletion As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Actcompletion
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Actcompletion = Nothing
					Else
						entity.Actcompletion = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esAppticket
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAppticketQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAppticket can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Appticket 
		Inherits esAppticket
		
	
		
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
	MustInherit Public Class esAppticketQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppticketMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Ticketid As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Ticketid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shortdesc As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Shortdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fulldesc As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Fulldesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedby As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Modifiedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedtime As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Modifiedtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Category As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Category, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priority As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Priority, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Estcompletion As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Estcompletion, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Actcompletion As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Actcompletion, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Userdoc As esQueryItem
			Get
				Return New esQueryItem(Me, AppticketMetadata.ColumnNames.Userdoc, esSystemType.ByteArray)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("AppticketCollection")> _
	Partial Public Class AppticketCollection
		Inherits esAppticketCollection
		Implements IEnumerable(Of Appticket)
		
        Public Shared Widening Operator CType(ByVal coll As AppticketCollection) As List(Of Appticket)
            Dim list As List(Of Appticket) = New List(Of Appticket)
            Dim emp As Appticket

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppticketMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New AppticketQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Appticket(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Appticket()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As AppticketQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New AppticketQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppticketQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Appticket 
			Return CType(MyBase.AddNewEntity(), Appticket)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal ticketid As System.Int32) As Appticket
			Return CType(MyBase.FindByPrimaryKey(ticketid), Appticket)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Appticket) Implements IEnumerable(Of Appticket).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Appticket)(Me)
        End Function
		
		Private _query As AppticketQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APPTICKET' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Appticket ({Ticketid.Value})")> _
	<Serializable> _
	Partial Public Class Appticket 
		Inherits esAppticket

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return AppticketMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAppticketQuery

			If Me._query Is Nothing Then
				Me._query = New AppticketQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As AppticketQuery
			Get

				If Me._query Is Nothing then
					Me._query = New AppticketQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppticketQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As AppticketQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class AppticketQuery
		inherits esAppticketQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "AppticketQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class AppticketMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Ticketid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppticketMetadata.PropertyNames.Ticketid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Shortdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppticketMetadata.PropertyNames.Shortdesc
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Fulldesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppticketMetadata.PropertyNames.Fulldesc
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Createdby, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppticketMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Createdtime, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppticketMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Modifiedby, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppticketMetadata.PropertyNames.Modifiedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Modifiedtime, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppticketMetadata.PropertyNames.Modifiedtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Category, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppticketMetadata.PropertyNames.Category
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Priority, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppticketMetadata.PropertyNames.Priority
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Estcompletion, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppticketMetadata.PropertyNames.Estcompletion
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Actcompletion, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppticketMetadata.PropertyNames.Actcompletion
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppticketMetadata.ColumnNames.Userdoc, 11, GetType(System.Byte()), esSystemType.ByteArray)	
			c.PropertyName = AppticketMetadata.PropertyNames.Userdoc
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As AppticketMetadata
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
			 Public Const Ticketid As String = "TICKETID"
			 Public Const Shortdesc As String = "SHORTDESC"
			 Public Const Fulldesc As String = "FULLDESC"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifiedby As String = "MODIFIEDBY"
			 Public Const Modifiedtime As String = "MODIFIEDTIME"
			 Public Const Category As String = "CATEGORY"
			 Public Const Priority As String = "PRIORITY"
			 Public Const Estcompletion As String = "ESTCOMPLETION"
			 Public Const Actcompletion As String = "ACTCOMPLETION"
			 Public Const Userdoc As String = "USERDOC"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Ticketid As String = "Ticketid"
			 Public Const Shortdesc As String = "Shortdesc"
			 Public Const Fulldesc As String = "Fulldesc"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifiedby As String = "Modifiedby"
			 Public Const Modifiedtime As String = "Modifiedtime"
			 Public Const Category As String = "Category"
			 Public Const Priority As String = "Priority"
			 Public Const Estcompletion As String = "Estcompletion"
			 Public Const Actcompletion As String = "Actcompletion"
			 Public Const Userdoc As String = "Userdoc"
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
            SyncLock GetType(AppticketMetadata)
			
				If AppticketMetadata.mapDelegates Is Nothing Then
					AppticketMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If AppticketMetadata._meta Is Nothing Then
                    AppticketMetadata._meta = New AppticketMetadata()
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
				

				meta.AddTypeMap("Ticketid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shortdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fulldesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifiedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifiedtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Category", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priority", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Estcompletion", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Actcompletion", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Userdoc", new esTypeMap("varbinary", "System.Byte()"))			
				
				
				 
				meta.Source = "APPTICKET"
				meta.Destination = "APPTICKET"
				
				meta.spInsert = "proc_APPTICKETInsert"
				meta.spUpdate = "proc_APPTICKETUpdate"
				meta.spDelete = "proc_APPTICKETDelete"
				meta.spLoadAll = "proc_APPTICKETLoadAll"
				meta.spLoadByPrimaryKey = "proc_APPTICKETLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As AppticketMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
