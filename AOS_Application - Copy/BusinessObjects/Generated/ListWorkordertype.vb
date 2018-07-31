'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:56 PM
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
	MustInherit Public Class esListWorkordertypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListWorkordertypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListWorkordertypeQuery)
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
            Me.InitQuery(CType(query, esListWorkordertypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListWorkordertype) As ListWorkordertype
			Return CType(MyBase.DetachEntity(entity), ListWorkordertype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListWorkordertype) As ListWorkordertype
			Return CType(MyBase.AttachEntity(entity), ListWorkordertype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListWorkordertypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListWorkordertype
            Get
                Return TryCast(MyBase.Item(index), ListWorkordertype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListWorkordertype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListWorkordertype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListWorkordertypeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal listkey As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(listkey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(listkey)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal listkey As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(listkey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(listkey)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal listkey As System.Int32) As Boolean
		
			Dim query As esListWorkordertypeQuery = Me.GetDynamicQuery()
			query.Where(query.Listkey.Equal(listkey))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal listkey As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LISTKEY", listkey)
			
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
												
						Case "Listkey"
							Me.str.Listkey = CType(value, string)
												
						Case "Workordertype"
							Me.str.Workordertype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Listkey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Listkey = CType(value, Nullable(Of System.Int32))
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
		' Maps to LIST_WORKORDERTYPE.LISTKEY
		' </summary>
		Public Overridable Property Listkey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListWorkordertypeMetadata.ColumnNames.Listkey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListWorkordertypeMetadata.ColumnNames.Listkey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_WORKORDERTYPE.WORKORDERTYPE
		' </summary>
		Public Overridable Property Workordertype As System.String
			Get
				Return MyBase.GetSystemString(ListWorkordertypeMetadata.ColumnNames.Workordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListWorkordertypeMetadata.ColumnNames.Workordertype, value)
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
		
			Public Sub New(ByVal entity As esListWorkordertype)
				Me.entity = entity
			End Sub				
		
	
			Public Property Listkey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Listkey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Listkey = Nothing
					Else
						entity.Listkey = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Workordertype As System.String 
				Get
					Dim data_ As System.String = entity.Workordertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordertype = Nothing
					Else
						entity.Workordertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListWorkordertype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListWorkordertypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListWorkordertype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListWorkordertype 
		Inherits esListWorkordertype
		
	
		
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
	MustInherit Public Class esListWorkordertypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListWorkordertypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Listkey As esQueryItem
			Get
				Return New esQueryItem(Me, ListWorkordertypeMetadata.ColumnNames.Listkey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ListWorkordertypeMetadata.ColumnNames.Workordertype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListWorkordertypeCollection")> _
	Partial Public Class ListWorkordertypeCollection
		Inherits esListWorkordertypeCollection
		Implements IEnumerable(Of ListWorkordertype)
		
        Public Shared Widening Operator CType(ByVal coll As ListWorkordertypeCollection) As List(Of ListWorkordertype)
            Dim list As List(Of ListWorkordertype) = New List(Of ListWorkordertype)
            Dim emp As ListWorkordertype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListWorkordertypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListWorkordertypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListWorkordertype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListWorkordertype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListWorkordertypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListWorkordertypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListWorkordertypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListWorkordertype 
			Return CType(MyBase.AddNewEntity(), ListWorkordertype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal listkey As System.Int32) As ListWorkordertype
			Return CType(MyBase.FindByPrimaryKey(listkey), ListWorkordertype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListWorkordertype) Implements IEnumerable(Of ListWorkordertype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListWorkordertype)(Me)
        End Function
		
		Private _query As ListWorkordertypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_WORKORDERTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListWorkordertype ({Listkey.Value})")> _
	<Serializable> _
	Partial Public Class ListWorkordertype 
		Inherits esListWorkordertype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListWorkordertypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListWorkordertypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListWorkordertypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListWorkordertypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListWorkordertypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListWorkordertypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListWorkordertypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListWorkordertypeQuery
		inherits esListWorkordertypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListWorkordertypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListWorkordertypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListWorkordertypeMetadata.ColumnNames.Listkey, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListWorkordertypeMetadata.PropertyNames.Listkey
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListWorkordertypeMetadata.ColumnNames.Workordertype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListWorkordertypeMetadata.PropertyNames.Workordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListWorkordertypeMetadata
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
			 Public Const Listkey As String = "LISTKEY"
			 Public Const Workordertype As String = "WORKORDERTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Listkey As String = "Listkey"
			 Public Const Workordertype As String = "Workordertype"
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
            SyncLock GetType(ListWorkordertypeMetadata)
			
				If ListWorkordertypeMetadata.mapDelegates Is Nothing Then
					ListWorkordertypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListWorkordertypeMetadata._meta Is Nothing Then
                    ListWorkordertypeMetadata._meta = New ListWorkordertypeMetadata()
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
				

				meta.AddTypeMap("Listkey", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workordertype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_WORKORDERTYPE"
				meta.Destination = "LIST_WORKORDERTYPE"
				
				meta.spInsert = "proc_LIST_WORKORDERTYPEInsert"
				meta.spUpdate = "proc_LIST_WORKORDERTYPEUpdate"
				meta.spDelete = "proc_LIST_WORKORDERTYPEDelete"
				meta.spLoadAll = "proc_LIST_WORKORDERTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_WORKORDERTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListWorkordertypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
