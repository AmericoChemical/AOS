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
	MustInherit Public Class esBomKeytableCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "BomKeytableCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esBomKeytableQuery)
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
            Me.InitQuery(CType(query, esBomKeytableQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As BomKeytable) As BomKeytable
			Return CType(MyBase.DetachEntity(entity), BomKeytable)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As BomKeytable) As BomKeytable
			Return CType(MyBase.AttachEntity(entity), BomKeytable)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As BomKeytableCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As BomKeytable
            Get
                Return TryCast(MyBase.Item(index), BomKeytable)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(BomKeytable)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esBomKeytable	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esBomKeytableQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey() As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic() As Boolean
		
			Dim query As esBomKeytableQuery = Me.GetDynamicQuery()
			query.Where()
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure() As Boolean
		
			Dim parms As esParameters = New esParameters()

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
												
						Case "Id"
							Me.str.Id = CType(value, string)
												
						Case "Name"
							Me.str.Name = CType(value, string)
												
						Case "ColName"
							Me.str.ColName = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
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
		' Maps to BOM_KEYTABLE.ID
		' </summary>
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BomKeytableMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(BomKeytableMetadata.ColumnNames.Id, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BOM_KEYTABLE.NAME
		' </summary>
		Public Overridable Property Name As System.String
			Get
				Return MyBase.GetSystemString(BomKeytableMetadata.ColumnNames.Name)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BomKeytableMetadata.ColumnNames.Name, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BOM_KEYTABLE.COL_NAME
		' </summary>
		Public Overridable Property ColName As System.String
			Get
				Return MyBase.GetSystemString(BomKeytableMetadata.ColumnNames.ColName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BomKeytableMetadata.ColumnNames.ColName, value)
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
		
			Public Sub New(ByVal entity As esBomKeytable)
				Me.entity = entity
			End Sub				
		
	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Id
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Id = Nothing
					Else
						entity.Id = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Name As System.String 
				Get
					Dim data_ As System.String = entity.Name
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Name = Nothing
					Else
						entity.Name = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ColName As System.String 
				Get
					Dim data_ As System.String = entity.ColName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ColName = Nothing
					Else
						entity.ColName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBomKeytable
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esBomKeytableQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esBomKeytable can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class BomKeytable 
		Inherits esBomKeytable
		
	
		
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
	MustInherit Public Class esBomKeytableQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BomKeytableMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, BomKeytableMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Name As esQueryItem
			Get
				Return New esQueryItem(Me, BomKeytableMetadata.ColumnNames.Name, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ColName As esQueryItem
			Get
				Return New esQueryItem(Me, BomKeytableMetadata.ColumnNames.ColName, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("BomKeytableCollection")> _
	Partial Public Class BomKeytableCollection
		Inherits esBomKeytableCollection
		Implements IEnumerable(Of BomKeytable)
		
        Public Shared Widening Operator CType(ByVal coll As BomKeytableCollection) As List(Of BomKeytable)
            Dim list As List(Of BomKeytable) = New List(Of BomKeytable)
            Dim emp As BomKeytable

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BomKeytableMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New BomKeytableQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New BomKeytable(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New BomKeytable()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As BomKeytableQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New BomKeytableQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As BomKeytableQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As BomKeytable 
			Return CType(MyBase.AddNewEntity(), BomKeytable)
		End Function

		Public Overloads Function FindByPrimaryKey() As BomKeytable
			Return CType(MyBase.FindByPrimaryKey(), BomKeytable)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of BomKeytable) Implements IEnumerable(Of BomKeytable).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of BomKeytable)(Me)
        End Function
		
		Private _query As BomKeytableQuery

	End Class
	


	' <summary>
	' Encapsulates the 'BOM_KEYTABLE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("BomKeytable ()")> _
	<Serializable> _
	Partial Public Class BomKeytable 
		Inherits esBomKeytable

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return BomKeytableMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esBomKeytableQuery

			If Me._query Is Nothing Then
				Me._query = New BomKeytableQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As BomKeytableQuery
			Get

				If Me._query Is Nothing then
					Me._query = New BomKeytableQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As BomKeytableQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As BomKeytableQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class BomKeytableQuery
		inherits esBomKeytableQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "BomKeytableQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class BomKeytableMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BomKeytableMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BomKeytableMetadata.PropertyNames.Id
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(BomKeytableMetadata.ColumnNames.Name, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = BomKeytableMetadata.PropertyNames.Name
			c.CharacterMaxLength = 32
			_columns.Add(c)
				
			c = New esColumnMetadata(BomKeytableMetadata.ColumnNames.ColName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BomKeytableMetadata.PropertyNames.ColName
			c.CharacterMaxLength = 32
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As BomKeytableMetadata
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
			 Public Const Id As String = "ID"
			 Public Const Name As String = "NAME"
			 Public Const ColName As String = "COL_NAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const Name As String = "Name"
			 Public Const ColName As String = "ColName"
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
            SyncLock GetType(BomKeytableMetadata)
			
				If BomKeytableMetadata.mapDelegates Is Nothing Then
					BomKeytableMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If BomKeytableMetadata._meta Is Nothing Then
                    BomKeytableMetadata._meta = New BomKeytableMetadata()
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
				

				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Name", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("ColName", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "BOM_KEYTABLE"
				meta.Destination = "BOM_KEYTABLE"
				
				meta.spInsert = "proc_BOM_KEYTABLEInsert"
				meta.spUpdate = "proc_BOM_KEYTABLEUpdate"
				meta.spDelete = "proc_BOM_KEYTABLEDelete"
				meta.spLoadAll = "proc_BOM_KEYTABLELoadAll"
				meta.spLoadByPrimaryKey = "proc_BOM_KEYTABLELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As BomKeytableMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
