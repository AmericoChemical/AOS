'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/14/2014 7:40:19 PM
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
	MustInherit Public Class esListFulfillmenttypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListFulfillmenttypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListFulfillmenttypeQuery)
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
            Me.InitQuery(CType(query, esListFulfillmenttypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListFulfillmenttype) As ListFulfillmenttype
			Return CType(MyBase.DetachEntity(entity), ListFulfillmenttype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListFulfillmenttype) As ListFulfillmenttype
			Return CType(MyBase.AttachEntity(entity), ListFulfillmenttype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListFulfillmenttypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListFulfillmenttype
            Get
                Return TryCast(MyBase.Item(index), ListFulfillmenttype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListFulfillmenttype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListFulfillmenttype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListFulfillmenttypeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal fulfillmenttypeid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fulfillmenttypeid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fulfillmenttypeid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal fulfillmenttypeid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(fulfillmenttypeid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(fulfillmenttypeid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal fulfillmenttypeid As System.Int32) As Boolean
		
			Dim query As esListFulfillmenttypeQuery = Me.GetDynamicQuery()
			query.Where(query.Fulfillmenttypeid.Equal(fulfillmenttypeid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal fulfillmenttypeid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FULFILLMENTTYPEID", fulfillmenttypeid)
			
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
												
						Case "Fulfillmenttypeid"
							Me.str.Fulfillmenttypeid = CType(value, string)
												
						Case "Fulfillmenttype"
							Me.str.Fulfillmenttype = CType(value, string)
												
						Case "Description"
							Me.str.Description = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Fulfillmenttypeid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fulfillmenttypeid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to LIST_FULFILLMENTTYPE.FULFILLMENTTYPEID
		' </summary>
		Public Overridable Property Fulfillmenttypeid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListFulfillmenttypeMetadata.ColumnNames.Fulfillmenttypeid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListFulfillmenttypeMetadata.ColumnNames.Fulfillmenttypeid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_FULFILLMENTTYPE.FULFILLMENTTYPE
		' </summary>
		Public Overridable Property Fulfillmenttype As System.String
			Get
				Return MyBase.GetSystemString(ListFulfillmenttypeMetadata.ColumnNames.Fulfillmenttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListFulfillmenttypeMetadata.ColumnNames.Fulfillmenttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_FULFILLMENTTYPE.DESCRIPTION
		' </summary>
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(ListFulfillmenttypeMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListFulfillmenttypeMetadata.ColumnNames.Description, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_FULFILLMENTTYPE.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ListFulfillmenttypeMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListFulfillmenttypeMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_FULFILLMENTTYPE.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ListFulfillmenttypeMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ListFulfillmenttypeMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_FULFILLMENTTYPE.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ListFulfillmenttypeMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListFulfillmenttypeMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_FULFILLMENTTYPE.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ListFulfillmenttypeMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ListFulfillmenttypeMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esListFulfillmenttype)
				Me.entity = entity
			End Sub				
		
	
			Public Property Fulfillmenttypeid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fulfillmenttypeid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fulfillmenttypeid = Nothing
					Else
						entity.Fulfillmenttypeid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fulfillmenttype As System.String 
				Get
					Dim data_ As System.String = entity.Fulfillmenttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fulfillmenttype = Nothing
					Else
						entity.Fulfillmenttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Description As System.String 
				Get
					Dim data_ As System.String = entity.Description
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Description = Nothing
					Else
						entity.Description = Convert.ToString(Value)
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
		  

			Private entity As esListFulfillmenttype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListFulfillmenttypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListFulfillmenttype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListFulfillmenttype 
		Inherits esListFulfillmenttype
		
	
		
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
	MustInherit Public Class esListFulfillmenttypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListFulfillmenttypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Fulfillmenttypeid As esQueryItem
			Get
				Return New esQueryItem(Me, ListFulfillmenttypeMetadata.ColumnNames.Fulfillmenttypeid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fulfillmenttype As esQueryItem
			Get
				Return New esQueryItem(Me, ListFulfillmenttypeMetadata.ColumnNames.Fulfillmenttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, ListFulfillmenttypeMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ListFulfillmenttypeMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ListFulfillmenttypeMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ListFulfillmenttypeMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ListFulfillmenttypeMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListFulfillmenttypeCollection")> _
	Partial Public Class ListFulfillmenttypeCollection
		Inherits esListFulfillmenttypeCollection
		Implements IEnumerable(Of ListFulfillmenttype)
		
        Public Shared Widening Operator CType(ByVal coll As ListFulfillmenttypeCollection) As List(Of ListFulfillmenttype)
            Dim list As List(Of ListFulfillmenttype) = New List(Of ListFulfillmenttype)
            Dim emp As ListFulfillmenttype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListFulfillmenttypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListFulfillmenttypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListFulfillmenttype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListFulfillmenttype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListFulfillmenttypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListFulfillmenttypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListFulfillmenttypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListFulfillmenttype 
			Return CType(MyBase.AddNewEntity(), ListFulfillmenttype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal fulfillmenttypeid As System.Int32) As ListFulfillmenttype
			Return CType(MyBase.FindByPrimaryKey(fulfillmenttypeid), ListFulfillmenttype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListFulfillmenttype) Implements IEnumerable(Of ListFulfillmenttype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListFulfillmenttype)(Me)
        End Function
		
		Private _query As ListFulfillmenttypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_FULFILLMENTTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListFulfillmenttype ({Fulfillmenttypeid.Value})")> _
	<Serializable> _
	Partial Public Class ListFulfillmenttype 
		Inherits esListFulfillmenttype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListFulfillmenttypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListFulfillmenttypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListFulfillmenttypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListFulfillmenttypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListFulfillmenttypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListFulfillmenttypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListFulfillmenttypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListFulfillmenttypeQuery
		inherits esListFulfillmenttypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListFulfillmenttypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListFulfillmenttypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListFulfillmenttypeMetadata.ColumnNames.Fulfillmenttypeid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListFulfillmenttypeMetadata.PropertyNames.Fulfillmenttypeid
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListFulfillmenttypeMetadata.ColumnNames.Fulfillmenttype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListFulfillmenttypeMetadata.PropertyNames.Fulfillmenttype
			c.CharacterMaxLength = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListFulfillmenttypeMetadata.ColumnNames.Description, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListFulfillmenttypeMetadata.PropertyNames.Description
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ListFulfillmenttypeMetadata.ColumnNames.Createdby, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListFulfillmenttypeMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ListFulfillmenttypeMetadata.ColumnNames.Createdtime, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ListFulfillmenttypeMetadata.PropertyNames.Createdtime
			_columns.Add(c)
				
			c = New esColumnMetadata(ListFulfillmenttypeMetadata.ColumnNames.Modifyby, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListFulfillmenttypeMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ListFulfillmenttypeMetadata.ColumnNames.Modifytime, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ListFulfillmenttypeMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListFulfillmenttypeMetadata
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
			 Public Const Fulfillmenttypeid As String = "FULFILLMENTTYPEID"
			 Public Const Fulfillmenttype As String = "FULFILLMENTTYPE"
			 Public Const Description As String = "DESCRIPTION"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Fulfillmenttypeid As String = "Fulfillmenttypeid"
			 Public Const Fulfillmenttype As String = "Fulfillmenttype"
			 Public Const Description As String = "Description"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
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
            SyncLock GetType(ListFulfillmenttypeMetadata)
			
				If ListFulfillmenttypeMetadata.mapDelegates Is Nothing Then
					ListFulfillmenttypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListFulfillmenttypeMetadata._meta Is Nothing Then
                    ListFulfillmenttypeMetadata._meta = New ListFulfillmenttypeMetadata()
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
				

				meta.AddTypeMap("Fulfillmenttypeid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fulfillmenttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Description", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "LIST_FULFILLMENTTYPE"
				meta.Destination = "LIST_FULFILLMENTTYPE"
				
				meta.spInsert = "proc_LIST_FULFILLMENTTYPEInsert"
				meta.spUpdate = "proc_LIST_FULFILLMENTTYPEUpdate"
				meta.spDelete = "proc_LIST_FULFILLMENTTYPEDelete"
				meta.spLoadAll = "proc_LIST_FULFILLMENTTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_FULFILLMENTTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListFulfillmenttypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
