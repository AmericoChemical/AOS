'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/6/2015 7:59:55 AM
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
	MustInherit Public Class esListLabeltypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListLabeltypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListLabeltypeQuery)
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
            Me.InitQuery(CType(query, esListLabeltypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListLabeltype) As ListLabeltype
			Return CType(MyBase.DetachEntity(entity), ListLabeltype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListLabeltype) As ListLabeltype
			Return CType(MyBase.AttachEntity(entity), ListLabeltype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListLabeltypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListLabeltype
            Get
                Return TryCast(MyBase.Item(index), ListLabeltype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListLabeltype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListLabeltype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListLabeltypeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal labeltype As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(labeltype)
			Else
				Return LoadByPrimaryKeyStoredProcedure(labeltype)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal labeltype As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(labeltype)
			Else
				Return LoadByPrimaryKeyStoredProcedure(labeltype)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal labeltype As System.String) As Boolean
		
			Dim query As esListLabeltypeQuery = Me.GetDynamicQuery()
			query.Where(query.Labeltype.Equal(labeltype))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal labeltype As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LABELTYPE", labeltype)
			
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
												
						Case "Labeltype"
							Me.str.Labeltype = CType(value, string)
					
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
		' Maps to LIST_LABELTYPE.LABELTYPE
		' </summary>
		Public Overridable Property Labeltype As System.String
			Get
				Return MyBase.GetSystemString(ListLabeltypeMetadata.ColumnNames.Labeltype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListLabeltypeMetadata.ColumnNames.Labeltype, value)
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
		
			Public Sub New(ByVal entity As esListLabeltype)
				Me.entity = entity
			End Sub				
		
	
			Public Property Labeltype As System.String 
				Get
					Dim data_ As System.String = entity.Labeltype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Labeltype = Nothing
					Else
						entity.Labeltype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListLabeltype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListLabeltypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListLabeltype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListLabeltype 
		Inherits esListLabeltype
		
	
		
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
	MustInherit Public Class esListLabeltypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListLabeltypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Labeltype As esQueryItem
			Get
				Return New esQueryItem(Me, ListLabeltypeMetadata.ColumnNames.Labeltype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListLabeltypeCollection")> _
	Partial Public Class ListLabeltypeCollection
		Inherits esListLabeltypeCollection
		Implements IEnumerable(Of ListLabeltype)
		
        Public Shared Widening Operator CType(ByVal coll As ListLabeltypeCollection) As List(Of ListLabeltype)
            Dim list As List(Of ListLabeltype) = New List(Of ListLabeltype)
            Dim emp As ListLabeltype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListLabeltypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListLabeltypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListLabeltype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListLabeltype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListLabeltypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListLabeltypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListLabeltypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListLabeltype 
			Return CType(MyBase.AddNewEntity(), ListLabeltype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal labeltype As System.String) As ListLabeltype
			Return CType(MyBase.FindByPrimaryKey(labeltype), ListLabeltype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListLabeltype) Implements IEnumerable(Of ListLabeltype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListLabeltype)(Me)
        End Function
		
		Private _query As ListLabeltypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_LABELTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListLabeltype ({Labeltype})")> _
	<Serializable> _
	Partial Public Class ListLabeltype 
		Inherits esListLabeltype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListLabeltypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListLabeltypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListLabeltypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListLabeltypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListLabeltypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListLabeltypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListLabeltypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListLabeltypeQuery
		inherits esListLabeltypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListLabeltypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListLabeltypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListLabeltypeMetadata.ColumnNames.Labeltype, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListLabeltypeMetadata.PropertyNames.Labeltype
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListLabeltypeMetadata
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
			 Public Const Labeltype As String = "LABELTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Labeltype As String = "Labeltype"
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
            SyncLock GetType(ListLabeltypeMetadata)
			
				If ListLabeltypeMetadata.mapDelegates Is Nothing Then
					ListLabeltypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListLabeltypeMetadata._meta Is Nothing Then
                    ListLabeltypeMetadata._meta = New ListLabeltypeMetadata()
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
				

				meta.AddTypeMap("Labeltype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_LABELTYPE"
				meta.Destination = "LIST_LABELTYPE"
				
				meta.spInsert = "proc_LIST_LABELTYPEInsert"
				meta.spUpdate = "proc_LIST_LABELTYPEUpdate"
				meta.spDelete = "proc_LIST_LABELTYPEDelete"
				meta.spLoadAll = "proc_LIST_LABELTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_LABELTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListLabeltypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
