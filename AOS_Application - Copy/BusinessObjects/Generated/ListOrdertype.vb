'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/15/2014 10:44:06 AM
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
	MustInherit Public Class esListOrdertypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListOrdertypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListOrdertypeQuery)
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
            Me.InitQuery(CType(query, esListOrdertypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListOrdertype) As ListOrdertype
			Return CType(MyBase.DetachEntity(entity), ListOrdertype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListOrdertype) As ListOrdertype
			Return CType(MyBase.AttachEntity(entity), ListOrdertype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListOrdertypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListOrdertype
            Get
                Return TryCast(MyBase.Item(index), ListOrdertype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListOrdertype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListOrdertype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListOrdertypeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal ordertype As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(ordertype)
			Else
				Return LoadByPrimaryKeyStoredProcedure(ordertype)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal ordertype As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(ordertype)
			Else
				Return LoadByPrimaryKeyStoredProcedure(ordertype)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal ordertype As System.String) As Boolean
		
			Dim query As esListOrdertypeQuery = Me.GetDynamicQuery()
			query.Where(query.Ordertype.Equal(ordertype))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal ordertype As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("ORDERTYPE", ordertype)
			
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
												
						Case "Ordertype"
							Me.str.Ordertype = CType(value, string)
												
						Case "Sortsequence"
							Me.str.Sortsequence = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Sortsequence"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sortsequence = CType(value, Nullable(Of System.Int32))
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
		' Maps to LIST_ORDERTYPE.ORDERTYPE
		' </summary>
		Public Overridable Property Ordertype As System.String
			Get
				Return MyBase.GetSystemString(ListOrdertypeMetadata.ColumnNames.Ordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListOrdertypeMetadata.ColumnNames.Ordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_ORDERTYPE.SORTSEQUENCE
		' </summary>
		Public Overridable Property Sortsequence As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListOrdertypeMetadata.ColumnNames.Sortsequence)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListOrdertypeMetadata.ColumnNames.Sortsequence, value)
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
		
			Public Sub New(ByVal entity As esListOrdertype)
				Me.entity = entity
			End Sub				
		
	
			Public Property Ordertype As System.String 
				Get
					Dim data_ As System.String = entity.Ordertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ordertype = Nothing
					Else
						entity.Ordertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sortsequence As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sortsequence
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sortsequence = Nothing
					Else
						entity.Sortsequence = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListOrdertype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListOrdertypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListOrdertype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListOrdertype 
		Inherits esListOrdertype
		
	
		
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
	MustInherit Public Class esListOrdertypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListOrdertypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Ordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ListOrdertypeMetadata.ColumnNames.Ordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sortsequence As esQueryItem
			Get
				Return New esQueryItem(Me, ListOrdertypeMetadata.ColumnNames.Sortsequence, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListOrdertypeCollection")> _
	Partial Public Class ListOrdertypeCollection
		Inherits esListOrdertypeCollection
		Implements IEnumerable(Of ListOrdertype)
		
        Public Shared Widening Operator CType(ByVal coll As ListOrdertypeCollection) As List(Of ListOrdertype)
            Dim list As List(Of ListOrdertype) = New List(Of ListOrdertype)
            Dim emp As ListOrdertype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListOrdertypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListOrdertypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListOrdertype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListOrdertype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListOrdertypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListOrdertypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListOrdertypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListOrdertype 
			Return CType(MyBase.AddNewEntity(), ListOrdertype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal ordertype As System.String) As ListOrdertype
			Return CType(MyBase.FindByPrimaryKey(ordertype), ListOrdertype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListOrdertype) Implements IEnumerable(Of ListOrdertype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListOrdertype)(Me)
        End Function
		
		Private _query As ListOrdertypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_ORDERTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListOrdertype ({Ordertype})")> _
	<Serializable> _
	Partial Public Class ListOrdertype 
		Inherits esListOrdertype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListOrdertypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListOrdertypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListOrdertypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListOrdertypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListOrdertypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListOrdertypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListOrdertypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListOrdertypeQuery
		inherits esListOrdertypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListOrdertypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListOrdertypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListOrdertypeMetadata.ColumnNames.Ordertype, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListOrdertypeMetadata.PropertyNames.Ordertype
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ListOrdertypeMetadata.ColumnNames.Sortsequence, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListOrdertypeMetadata.PropertyNames.Sortsequence
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListOrdertypeMetadata
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
			 Public Const Ordertype As String = "ORDERTYPE"
			 Public Const Sortsequence As String = "SORTSEQUENCE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Ordertype As String = "Ordertype"
			 Public Const Sortsequence As String = "Sortsequence"
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
            SyncLock GetType(ListOrdertypeMetadata)
			
				If ListOrdertypeMetadata.mapDelegates Is Nothing Then
					ListOrdertypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListOrdertypeMetadata._meta Is Nothing Then
                    ListOrdertypeMetadata._meta = New ListOrdertypeMetadata()
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
				

				meta.AddTypeMap("Ordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sortsequence", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "LIST_ORDERTYPE"
				meta.Destination = "LIST_ORDERTYPE"
				
				meta.spInsert = "proc_LIST_ORDERTYPEInsert"
				meta.spUpdate = "proc_LIST_ORDERTYPEUpdate"
				meta.spDelete = "proc_LIST_ORDERTYPEDelete"
				meta.spLoadAll = "proc_LIST_ORDERTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_ORDERTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListOrdertypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
