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
	MustInherit Public Class esListItemtypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListItemtypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListItemtypeQuery)
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
            Me.InitQuery(CType(query, esListItemtypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListItemtype) As ListItemtype
			Return CType(MyBase.DetachEntity(entity), ListItemtype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListItemtype) As ListItemtype
			Return CType(MyBase.AttachEntity(entity), ListItemtype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListItemtypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListItemtype
            Get
                Return TryCast(MyBase.Item(index), ListItemtype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListItemtype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListItemtype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListItemtypeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal recID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal recID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal recID As System.Int32) As Boolean
		
			Dim query As esListItemtypeQuery = Me.GetDynamicQuery()
			query.Where(query.RecID.Equal(recID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal recID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RecID", recID)
			
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
												
						Case "RecID"
							Me.str.RecID = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RecID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecID = CType(value, Nullable(Of System.Int32))
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
		' Maps to LIST_ITEMTYPE.RecID
		' </summary>
		Public Overridable Property RecID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListItemtypeMetadata.ColumnNames.RecID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListItemtypeMetadata.ColumnNames.RecID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_ITEMTYPE.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ListItemtypeMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListItemtypeMetadata.ColumnNames.Itemtype, value)
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
		
			Public Sub New(ByVal entity As esListItemtype)
				Me.entity = entity
			End Sub				
		
	
			Public Property RecID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecID = Nothing
					Else
						entity.RecID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemtype As System.String 
				Get
					Dim data_ As System.String = entity.Itemtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemtype = Nothing
					Else
						entity.Itemtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListItemtype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListItemtypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListItemtype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListItemtype 
		Inherits esListItemtype
		
	
		
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
	MustInherit Public Class esListItemtypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListItemtypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property RecID As esQueryItem
			Get
				Return New esQueryItem(Me, ListItemtypeMetadata.ColumnNames.RecID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ListItemtypeMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListItemtypeCollection")> _
	Partial Public Class ListItemtypeCollection
		Inherits esListItemtypeCollection
		Implements IEnumerable(Of ListItemtype)
		
        Public Shared Widening Operator CType(ByVal coll As ListItemtypeCollection) As List(Of ListItemtype)
            Dim list As List(Of ListItemtype) = New List(Of ListItemtype)
            Dim emp As ListItemtype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListItemtypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListItemtypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListItemtype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListItemtype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListItemtypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListItemtypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListItemtypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListItemtype 
			Return CType(MyBase.AddNewEntity(), ListItemtype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal recID As System.Int32) As ListItemtype
			Return CType(MyBase.FindByPrimaryKey(recID), ListItemtype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListItemtype) Implements IEnumerable(Of ListItemtype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListItemtype)(Me)
        End Function
		
		Private _query As ListItemtypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_ITEMTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListItemtype ({RecID.Value})")> _
	<Serializable> _
	Partial Public Class ListItemtype 
		Inherits esListItemtype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListItemtypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListItemtypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListItemtypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListItemtypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListItemtypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListItemtypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListItemtypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListItemtypeQuery
		inherits esListItemtypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListItemtypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListItemtypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListItemtypeMetadata.ColumnNames.RecID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListItemtypeMetadata.PropertyNames.RecID
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListItemtypeMetadata.ColumnNames.Itemtype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListItemtypeMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListItemtypeMetadata
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
			 Public Const RecID As String = "RecID"
			 Public Const Itemtype As String = "ITEMTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const RecID As String = "RecID"
			 Public Const Itemtype As String = "Itemtype"
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
            SyncLock GetType(ListItemtypeMetadata)
			
				If ListItemtypeMetadata.mapDelegates Is Nothing Then
					ListItemtypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListItemtypeMetadata._meta Is Nothing Then
                    ListItemtypeMetadata._meta = New ListItemtypeMetadata()
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
				

				meta.AddTypeMap("RecID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_ITEMTYPE"
				meta.Destination = "LIST_ITEMTYPE"
				
				meta.spInsert = "proc_LIST_ITEMTYPEInsert"
				meta.spUpdate = "proc_LIST_ITEMTYPEUpdate"
				meta.spDelete = "proc_LIST_ITEMTYPEDelete"
				meta.spLoadAll = "proc_LIST_ITEMTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_ITEMTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListItemtypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
