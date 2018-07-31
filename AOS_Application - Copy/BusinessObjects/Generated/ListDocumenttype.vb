'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/2/2015 9:14:30 AM
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
	MustInherit Public Class esListDocumenttypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListDocumenttypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListDocumenttypeQuery)
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
            Me.InitQuery(CType(query, esListDocumenttypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListDocumenttype) As ListDocumenttype
			Return CType(MyBase.DetachEntity(entity), ListDocumenttype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListDocumenttype) As ListDocumenttype
			Return CType(MyBase.AttachEntity(entity), ListDocumenttype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListDocumenttypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListDocumenttype
            Get
                Return TryCast(MyBase.Item(index), ListDocumenttype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListDocumenttype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListDocumenttype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListDocumenttypeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal documenttype As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(documenttype)
			Else
				Return LoadByPrimaryKeyStoredProcedure(documenttype)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal documenttype As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(documenttype)
			Else
				Return LoadByPrimaryKeyStoredProcedure(documenttype)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal documenttype As System.String) As Boolean
		
			Dim query As esListDocumenttypeQuery = Me.GetDynamicQuery()
			query.Where(query.Documenttype.Equal(documenttype))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal documenttype As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("DOCUMENTTYPE", documenttype)
			
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
												
						Case "Documenttype"
							Me.str.Documenttype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
					
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
		' Maps to LIST_DOCUMENTTYPE.DOCUMENTTYPE
		' </summary>
		Public Overridable Property Documenttype As System.String
			Get
				Return MyBase.GetSystemString(ListDocumenttypeMetadata.ColumnNames.Documenttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListDocumenttypeMetadata.ColumnNames.Documenttype, value)
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
		
			Public Sub New(ByVal entity As esListDocumenttype)
				Me.entity = entity
			End Sub				
		
	
			Public Property Documenttype As System.String 
				Get
					Dim data_ As System.String = entity.Documenttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Documenttype = Nothing
					Else
						entity.Documenttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListDocumenttype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListDocumenttypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListDocumenttype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListDocumenttype 
		Inherits esListDocumenttype
		
	
		
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
	MustInherit Public Class esListDocumenttypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListDocumenttypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Documenttype As esQueryItem
			Get
				Return New esQueryItem(Me, ListDocumenttypeMetadata.ColumnNames.Documenttype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListDocumenttypeCollection")> _
	Partial Public Class ListDocumenttypeCollection
		Inherits esListDocumenttypeCollection
		Implements IEnumerable(Of ListDocumenttype)
		
        Public Shared Widening Operator CType(ByVal coll As ListDocumenttypeCollection) As List(Of ListDocumenttype)
            Dim list As List(Of ListDocumenttype) = New List(Of ListDocumenttype)
            Dim emp As ListDocumenttype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListDocumenttypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListDocumenttypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListDocumenttype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListDocumenttype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListDocumenttypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListDocumenttypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListDocumenttypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListDocumenttype 
			Return CType(MyBase.AddNewEntity(), ListDocumenttype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal documenttype As System.String) As ListDocumenttype
			Return CType(MyBase.FindByPrimaryKey(documenttype), ListDocumenttype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListDocumenttype) Implements IEnumerable(Of ListDocumenttype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListDocumenttype)(Me)
        End Function
		
		Private _query As ListDocumenttypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_DOCUMENTTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListDocumenttype ({Documenttype})")> _
	<Serializable> _
	Partial Public Class ListDocumenttype 
		Inherits esListDocumenttype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListDocumenttypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListDocumenttypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListDocumenttypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListDocumenttypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListDocumenttypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListDocumenttypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListDocumenttypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListDocumenttypeQuery
		inherits esListDocumenttypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListDocumenttypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListDocumenttypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListDocumenttypeMetadata.ColumnNames.Documenttype, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListDocumenttypeMetadata.PropertyNames.Documenttype
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListDocumenttypeMetadata
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
			 Public Const Documenttype As String = "DOCUMENTTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Documenttype As String = "Documenttype"
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
            SyncLock GetType(ListDocumenttypeMetadata)
			
				If ListDocumenttypeMetadata.mapDelegates Is Nothing Then
					ListDocumenttypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListDocumenttypeMetadata._meta Is Nothing Then
                    ListDocumenttypeMetadata._meta = New ListDocumenttypeMetadata()
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
				

				meta.AddTypeMap("Documenttype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_DOCUMENTTYPE"
				meta.Destination = "LIST_DOCUMENTTYPE"
				
				meta.spInsert = "proc_LIST_DOCUMENTTYPEInsert"
				meta.spUpdate = "proc_LIST_DOCUMENTTYPEUpdate"
				meta.spDelete = "proc_LIST_DOCUMENTTYPEDelete"
				meta.spLoadAll = "proc_LIST_DOCUMENTTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_DOCUMENTTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListDocumenttypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
