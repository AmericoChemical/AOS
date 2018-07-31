'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:55 PM
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
	MustInherit Public Class esApisnoteCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ApisnoteCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esApisnoteQuery)
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
            Me.InitQuery(CType(query, esApisnoteQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Apisnote) As Apisnote
			Return CType(MyBase.DetachEntity(entity), Apisnote)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Apisnote) As Apisnote
			Return CType(MyBase.AttachEntity(entity), Apisnote)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ApisnoteCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Apisnote
            Get
                Return TryCast(MyBase.Item(index), Apisnote)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Apisnote)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esApisnote	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esApisnoteQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal apisnoteid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apisnoteid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apisnoteid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal apisnoteid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apisnoteid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apisnoteid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal apisnoteid As System.Int32) As Boolean
		
			Dim query As esApisnoteQuery = Me.GetDynamicQuery()
			query.Where(query.Apisnoteid.Equal(apisnoteid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal apisnoteid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APISNOTEID", apisnoteid)
			
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
												
						Case "Apisnoteid"
							Me.str.Apisnoteid = CType(value, string)
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Sequence"
							Me.str.Sequence = CType(value, string)
												
						Case "Apisnote"
							Me.str.Apisnote = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Apisnoteid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnoteid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sequence"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sequence = CType(value, Nullable(Of System.Int32))
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
		' Maps to APISNOTE.APISNOTEID
		' </summary>
		Public Overridable Property Apisnoteid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisnoteMetadata.ColumnNames.Apisnoteid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisnoteMetadata.ColumnNames.Apisnoteid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISNOTE.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisnoteMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisnoteMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISNOTE.SEQUENCE
		' </summary>
		Public Overridable Property Sequence As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisnoteMetadata.ColumnNames.Sequence)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisnoteMetadata.ColumnNames.Sequence, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISNOTE.APISNOTE
		' </summary>
		Public Overridable Property Apisnote As System.String
			Get
				Return MyBase.GetSystemString(ApisnoteMetadata.ColumnNames.Apisnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisnoteMetadata.ColumnNames.Apisnote, value)
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
		
			Public Sub New(ByVal entity As esApisnote)
				Me.entity = entity
			End Sub				
		
	
			Public Property Apisnoteid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnoteid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnoteid = Nothing
					Else
						entity.Apisnoteid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnum = Nothing
					Else
						entity.Apisnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sequence As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sequence
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sequence = Nothing
					Else
						entity.Sequence = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisnote As System.String 
				Get
					Dim data_ As System.String = entity.Apisnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnote = Nothing
					Else
						entity.Apisnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esApisnote
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esApisnoteQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esApisnote can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Apisnote 
		Inherits esApisnote
		
	
		
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
	MustInherit Public Class esApisnoteQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApisnoteMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apisnoteid As esQueryItem
			Get
				Return New esQueryItem(Me, ApisnoteMetadata.ColumnNames.Apisnoteid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ApisnoteMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sequence As esQueryItem
			Get
				Return New esQueryItem(Me, ApisnoteMetadata.ColumnNames.Sequence, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnote As esQueryItem
			Get
				Return New esQueryItem(Me, ApisnoteMetadata.ColumnNames.Apisnote, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ApisnoteCollection")> _
	Partial Public Class ApisnoteCollection
		Inherits esApisnoteCollection
		Implements IEnumerable(Of Apisnote)
		
        Public Shared Widening Operator CType(ByVal coll As ApisnoteCollection) As List(Of Apisnote)
            Dim list As List(Of Apisnote) = New List(Of Apisnote)
            Dim emp As Apisnote

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApisnoteMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ApisnoteQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Apisnote(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Apisnote()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ApisnoteQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ApisnoteQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApisnoteQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Apisnote 
			Return CType(MyBase.AddNewEntity(), Apisnote)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal apisnoteid As System.Int32) As Apisnote
			Return CType(MyBase.FindByPrimaryKey(apisnoteid), Apisnote)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Apisnote) Implements IEnumerable(Of Apisnote).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Apisnote)(Me)
        End Function
		
		Private _query As ApisnoteQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APISNOTE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Apisnote ({Apisnoteid.Value})")> _
	<Serializable> _
	Partial Public Class Apisnote 
		Inherits esApisnote

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ApisnoteMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esApisnoteQuery

			If Me._query Is Nothing Then
				Me._query = New ApisnoteQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ApisnoteQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ApisnoteQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApisnoteQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ApisnoteQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ApisnoteQuery
		inherits esApisnoteQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ApisnoteQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ApisnoteMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ApisnoteMetadata.ColumnNames.Apisnoteid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisnoteMetadata.PropertyNames.Apisnoteid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisnoteMetadata.ColumnNames.Apisnum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisnoteMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisnoteMetadata.ColumnNames.Sequence, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisnoteMetadata.PropertyNames.Sequence
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisnoteMetadata.ColumnNames.Apisnote, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisnoteMetadata.PropertyNames.Apisnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ApisnoteMetadata
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
			 Public Const Apisnoteid As String = "APISNOTEID"
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Sequence As String = "SEQUENCE"
			 Public Const Apisnote As String = "APISNOTE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Apisnoteid As String = "Apisnoteid"
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Sequence As String = "Sequence"
			 Public Const Apisnote As String = "Apisnote"
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
            SyncLock GetType(ApisnoteMetadata)
			
				If ApisnoteMetadata.mapDelegates Is Nothing Then
					ApisnoteMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ApisnoteMetadata._meta Is Nothing Then
                    ApisnoteMetadata._meta = New ApisnoteMetadata()
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
				

				meta.AddTypeMap("Apisnoteid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sequence", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnote", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "APISNOTE"
				meta.Destination = "APISNOTE"
				
				meta.spInsert = "proc_APISNOTEInsert"
				meta.spUpdate = "proc_APISNOTEUpdate"
				meta.spDelete = "proc_APISNOTEDelete"
				meta.spLoadAll = "proc_APISNOTELoadAll"
				meta.spLoadByPrimaryKey = "proc_APISNOTELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ApisnoteMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
