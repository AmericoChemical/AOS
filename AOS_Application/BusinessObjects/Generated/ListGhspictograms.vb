'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/6/2015 1:21:15 PM
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
	MustInherit Public Class esListGhspictogramsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListGhspictogramsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListGhspictogramsQuery)
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
            Me.InitQuery(CType(query, esListGhspictogramsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListGhspictograms) As ListGhspictograms
			Return CType(MyBase.DetachEntity(entity), ListGhspictograms)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListGhspictograms) As ListGhspictograms
			Return CType(MyBase.AttachEntity(entity), ListGhspictograms)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListGhspictogramsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListGhspictograms
            Get
                Return TryCast(MyBase.Item(index), ListGhspictograms)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListGhspictograms)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListGhspictograms	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListGhspictogramsQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal pictogramid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(pictogramid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(pictogramid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal pictogramid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(pictogramid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(pictogramid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal pictogramid As System.Int32) As Boolean
		
			Dim query As esListGhspictogramsQuery = Me.GetDynamicQuery()
			query.Where(query.Pictogramid.Equal(pictogramid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal pictogramid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PICTOGRAMID", pictogramid)
			
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
												
						Case "Pictogramid"
							Me.str.Pictogramid = CType(value, string)
												
						Case "Pictogramname"
							Me.str.Pictogramname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Pictogramid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pictogramid = CType(value, Nullable(Of System.Int32))
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
		' Maps to LIST_GHSPICTOGRAMS.PICTOGRAMID
		' </summary>
		Public Overridable Property Pictogramid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListGhspictogramsMetadata.ColumnNames.Pictogramid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListGhspictogramsMetadata.ColumnNames.Pictogramid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_GHSPICTOGRAMS.PICTOGRAMNAME
		' </summary>
		Public Overridable Property Pictogramname As System.String
			Get
				Return MyBase.GetSystemString(ListGhspictogramsMetadata.ColumnNames.Pictogramname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListGhspictogramsMetadata.ColumnNames.Pictogramname, value)
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
		
			Public Sub New(ByVal entity As esListGhspictograms)
				Me.entity = entity
			End Sub				
		
	
			Public Property Pictogramid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pictogramid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pictogramid = Nothing
					Else
						entity.Pictogramid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pictogramname As System.String 
				Get
					Dim data_ As System.String = entity.Pictogramname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pictogramname = Nothing
					Else
						entity.Pictogramname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListGhspictograms
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListGhspictogramsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListGhspictograms can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListGhspictograms 
		Inherits esListGhspictograms
		
	
		
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
	MustInherit Public Class esListGhspictogramsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListGhspictogramsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Pictogramid As esQueryItem
			Get
				Return New esQueryItem(Me, ListGhspictogramsMetadata.ColumnNames.Pictogramid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pictogramname As esQueryItem
			Get
				Return New esQueryItem(Me, ListGhspictogramsMetadata.ColumnNames.Pictogramname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListGhspictogramsCollection")> _
	Partial Public Class ListGhspictogramsCollection
		Inherits esListGhspictogramsCollection
		Implements IEnumerable(Of ListGhspictograms)
		
        Public Shared Widening Operator CType(ByVal coll As ListGhspictogramsCollection) As List(Of ListGhspictograms)
            Dim list As List(Of ListGhspictograms) = New List(Of ListGhspictograms)
            Dim emp As ListGhspictograms

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListGhspictogramsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListGhspictogramsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListGhspictograms(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListGhspictograms()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListGhspictogramsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListGhspictogramsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListGhspictogramsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListGhspictograms 
			Return CType(MyBase.AddNewEntity(), ListGhspictograms)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal pictogramid As System.Int32) As ListGhspictograms
			Return CType(MyBase.FindByPrimaryKey(pictogramid), ListGhspictograms)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListGhspictograms) Implements IEnumerable(Of ListGhspictograms).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListGhspictograms)(Me)
        End Function
		
		Private _query As ListGhspictogramsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_GHSPICTOGRAMS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListGhspictograms ({Pictogramid.Value})")> _
	<Serializable> _
	Partial Public Class ListGhspictograms 
		Inherits esListGhspictograms

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListGhspictogramsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListGhspictogramsQuery

			If Me._query Is Nothing Then
				Me._query = New ListGhspictogramsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListGhspictogramsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListGhspictogramsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListGhspictogramsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListGhspictogramsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListGhspictogramsQuery
		inherits esListGhspictogramsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListGhspictogramsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListGhspictogramsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListGhspictogramsMetadata.ColumnNames.Pictogramid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListGhspictogramsMetadata.PropertyNames.Pictogramid
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListGhspictogramsMetadata.ColumnNames.Pictogramname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListGhspictogramsMetadata.PropertyNames.Pictogramname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListGhspictogramsMetadata
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
			 Public Const Pictogramid As String = "PICTOGRAMID"
			 Public Const Pictogramname As String = "PICTOGRAMNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Pictogramid As String = "Pictogramid"
			 Public Const Pictogramname As String = "Pictogramname"
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
            SyncLock GetType(ListGhspictogramsMetadata)
			
				If ListGhspictogramsMetadata.mapDelegates Is Nothing Then
					ListGhspictogramsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListGhspictogramsMetadata._meta Is Nothing Then
                    ListGhspictogramsMetadata._meta = New ListGhspictogramsMetadata()
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
				

				meta.AddTypeMap("Pictogramid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Pictogramname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_GHSPICTOGRAMS"
				meta.Destination = "LIST_GHSPICTOGRAMS"
				
				meta.spInsert = "proc_LIST_GHSPICTOGRAMSInsert"
				meta.spUpdate = "proc_LIST_GHSPICTOGRAMSUpdate"
				meta.spDelete = "proc_LIST_GHSPICTOGRAMSDelete"
				meta.spLoadAll = "proc_LIST_GHSPICTOGRAMSLoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_GHSPICTOGRAMSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListGhspictogramsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
