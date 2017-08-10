'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/11/2014 6:10:21 PM
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
	MustInherit Public Class esFulfillmenttypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "FulfillmenttypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esFulfillmenttypeQuery)
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
            Me.InitQuery(CType(query, esFulfillmenttypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Fulfillmenttype) As Fulfillmenttype
			Return CType(MyBase.DetachEntity(entity), Fulfillmenttype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Fulfillmenttype) As Fulfillmenttype
			Return CType(MyBase.AttachEntity(entity), Fulfillmenttype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As FulfillmenttypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Fulfillmenttype
            Get
                Return TryCast(MyBase.Item(index), Fulfillmenttype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Fulfillmenttype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esFulfillmenttype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esFulfillmenttypeQuery
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
		
			Dim query As esFulfillmenttypeQuery = Me.GetDynamicQuery()
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
		' Maps to FULFILLMENTTYPE.FULFILLMENTTYPEID
		' </summary>
		Public Overridable Property Fulfillmenttypeid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FulfillmenttypeMetadata.ColumnNames.Fulfillmenttypeid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FulfillmenttypeMetadata.ColumnNames.Fulfillmenttypeid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FULFILLMENTTYPE.FULFILLMENTTYPE
		' </summary>
		Public Overridable Property Fulfillmenttype As System.String
			Get
				Return MyBase.GetSystemString(FulfillmenttypeMetadata.ColumnNames.Fulfillmenttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FulfillmenttypeMetadata.ColumnNames.Fulfillmenttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FULFILLMENTTYPE.DESCRIPTION
		' </summary>
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(FulfillmenttypeMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FulfillmenttypeMetadata.ColumnNames.Description, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FULFILLMENTTYPE.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(FulfillmenttypeMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FulfillmenttypeMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FULFILLMENTTYPE.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(FulfillmenttypeMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(FulfillmenttypeMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FULFILLMENTTYPE.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(FulfillmenttypeMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FulfillmenttypeMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FULFILLMENTTYPE.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(FulfillmenttypeMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(FulfillmenttypeMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esFulfillmenttype)
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
		  

			Private entity As esFulfillmenttype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esFulfillmenttypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esFulfillmenttype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Fulfillmenttype 
		Inherits esFulfillmenttype
		
	
		
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
	MustInherit Public Class esFulfillmenttypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FulfillmenttypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Fulfillmenttypeid As esQueryItem
			Get
				Return New esQueryItem(Me, FulfillmenttypeMetadata.ColumnNames.Fulfillmenttypeid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fulfillmenttype As esQueryItem
			Get
				Return New esQueryItem(Me, FulfillmenttypeMetadata.ColumnNames.Fulfillmenttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, FulfillmenttypeMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, FulfillmenttypeMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, FulfillmenttypeMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, FulfillmenttypeMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, FulfillmenttypeMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("FulfillmenttypeCollection")> _
	Partial Public Class FulfillmenttypeCollection
		Inherits esFulfillmenttypeCollection
		Implements IEnumerable(Of Fulfillmenttype)
		
        Public Shared Widening Operator CType(ByVal coll As FulfillmenttypeCollection) As List(Of Fulfillmenttype)
            Dim list As List(Of Fulfillmenttype) = New List(Of Fulfillmenttype)
            Dim emp As Fulfillmenttype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FulfillmenttypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New FulfillmenttypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Fulfillmenttype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Fulfillmenttype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As FulfillmenttypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New FulfillmenttypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FulfillmenttypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Fulfillmenttype 
			Return CType(MyBase.AddNewEntity(), Fulfillmenttype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal fulfillmenttypeid As System.Int32) As Fulfillmenttype
			Return CType(MyBase.FindByPrimaryKey(fulfillmenttypeid), Fulfillmenttype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Fulfillmenttype) Implements IEnumerable(Of Fulfillmenttype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Fulfillmenttype)(Me)
        End Function
		
		Private _query As FulfillmenttypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'FULFILLMENTTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Fulfillmenttype ({Fulfillmenttypeid.Value})")> _
	<Serializable> _
	Partial Public Class Fulfillmenttype 
		Inherits esFulfillmenttype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return FulfillmenttypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esFulfillmenttypeQuery

			If Me._query Is Nothing Then
				Me._query = New FulfillmenttypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As FulfillmenttypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New FulfillmenttypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FulfillmenttypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As FulfillmenttypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class FulfillmenttypeQuery
		inherits esFulfillmenttypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "FulfillmenttypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class FulfillmenttypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(FulfillmenttypeMetadata.ColumnNames.Fulfillmenttypeid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FulfillmenttypeMetadata.PropertyNames.Fulfillmenttypeid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(FulfillmenttypeMetadata.ColumnNames.Fulfillmenttype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = FulfillmenttypeMetadata.PropertyNames.Fulfillmenttype
			c.CharacterMaxLength = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(FulfillmenttypeMetadata.ColumnNames.Description, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = FulfillmenttypeMetadata.PropertyNames.Description
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(FulfillmenttypeMetadata.ColumnNames.Createdby, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = FulfillmenttypeMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(FulfillmenttypeMetadata.ColumnNames.Createdtime, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = FulfillmenttypeMetadata.PropertyNames.Createdtime
			_columns.Add(c)
				
			c = New esColumnMetadata(FulfillmenttypeMetadata.ColumnNames.Modifyby, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = FulfillmenttypeMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(FulfillmenttypeMetadata.ColumnNames.Modifytime, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = FulfillmenttypeMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As FulfillmenttypeMetadata
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
            SyncLock GetType(FulfillmenttypeMetadata)
			
				If FulfillmenttypeMetadata.mapDelegates Is Nothing Then
					FulfillmenttypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If FulfillmenttypeMetadata._meta Is Nothing Then
                    FulfillmenttypeMetadata._meta = New FulfillmenttypeMetadata()
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
				
				
				 
				meta.Source = "FULFILLMENTTYPE"
				meta.Destination = "FULFILLMENTTYPE"
				
				meta.spInsert = "proc_FULFILLMENTTYPEInsert"
				meta.spUpdate = "proc_FULFILLMENTTYPEUpdate"
				meta.spDelete = "proc_FULFILLMENTTYPEDelete"
				meta.spLoadAll = "proc_FULFILLMENTTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_FULFILLMENTTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As FulfillmenttypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
