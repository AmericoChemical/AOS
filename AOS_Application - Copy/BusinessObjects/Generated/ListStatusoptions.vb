'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/3/2018 7:15:23 AM
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
	MustInherit Public Class esListStatusoptionsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListStatusoptionsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListStatusoptionsQuery)
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
            Me.InitQuery(CType(query, esListStatusoptionsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListStatusoptions) As ListStatusoptions
			Return CType(MyBase.DetachEntity(entity), ListStatusoptions)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListStatusoptions) As ListStatusoptions
			Return CType(MyBase.AttachEntity(entity), ListStatusoptions)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListStatusoptionsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListStatusoptions
            Get
                Return TryCast(MyBase.Item(index), ListStatusoptions)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListStatusoptions)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListStatusoptions	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListStatusoptionsQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal status As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(status)
			Else
				Return LoadByPrimaryKeyStoredProcedure(status)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal status As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(status)
			Else
				Return LoadByPrimaryKeyStoredProcedure(status)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal status As System.String) As Boolean
		
			Dim query As esListStatusoptionsQuery = Me.GetDynamicQuery()
			query.Where(query.Status.Equal(status))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal status As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("STATUS", status)
			
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
												
						Case "Status"
							Me.str.Status = CType(value, string)
					
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
		' Maps to LIST_STATUSOPTIONS.STATUS
		' </summary>
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(ListStatusoptionsMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListStatusoptionsMetadata.ColumnNames.Status, value)
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
		
			Public Sub New(ByVal entity As esListStatusoptions)
				Me.entity = entity
			End Sub				
		
	
			Public Property Status As System.String 
				Get
					Dim data_ As System.String = entity.Status
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Status = Nothing
					Else
						entity.Status = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListStatusoptions
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListStatusoptionsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListStatusoptions can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListStatusoptions 
		Inherits esListStatusoptions
		
	
		
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
	MustInherit Public Class esListStatusoptionsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListStatusoptionsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, ListStatusoptionsMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListStatusoptionsCollection")> _
	Partial Public Class ListStatusoptionsCollection
		Inherits esListStatusoptionsCollection
		Implements IEnumerable(Of ListStatusoptions)
		
        Public Shared Widening Operator CType(ByVal coll As ListStatusoptionsCollection) As List(Of ListStatusoptions)
            Dim list As List(Of ListStatusoptions) = New List(Of ListStatusoptions)
            Dim emp As ListStatusoptions

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListStatusoptionsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListStatusoptionsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListStatusoptions(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListStatusoptions()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListStatusoptionsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListStatusoptionsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListStatusoptionsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListStatusoptions 
			Return CType(MyBase.AddNewEntity(), ListStatusoptions)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal status As System.String) As ListStatusoptions
			Return CType(MyBase.FindByPrimaryKey(status), ListStatusoptions)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListStatusoptions) Implements IEnumerable(Of ListStatusoptions).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListStatusoptions)(Me)
        End Function
		
		Private _query As ListStatusoptionsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_STATUSOPTIONS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListStatusoptions ({Status})")> _
	<Serializable> _
	Partial Public Class ListStatusoptions 
		Inherits esListStatusoptions

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListStatusoptionsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListStatusoptionsQuery

			If Me._query Is Nothing Then
				Me._query = New ListStatusoptionsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListStatusoptionsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListStatusoptionsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListStatusoptionsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListStatusoptionsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListStatusoptionsQuery
		inherits esListStatusoptionsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListStatusoptionsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListStatusoptionsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListStatusoptionsMetadata.ColumnNames.Status, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListStatusoptionsMetadata.PropertyNames.Status
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListStatusoptionsMetadata
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
			 Public Const Status As String = "STATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Status As String = "Status"
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
            SyncLock GetType(ListStatusoptionsMetadata)
			
				If ListStatusoptionsMetadata.mapDelegates Is Nothing Then
					ListStatusoptionsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListStatusoptionsMetadata._meta Is Nothing Then
                    ListStatusoptionsMetadata._meta = New ListStatusoptionsMetadata()
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
				

				meta.AddTypeMap("Status", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_STATUSOPTIONS"
				meta.Destination = "LIST_STATUSOPTIONS"
				
				meta.spInsert = "proc_LIST_STATUSOPTIONSInsert"
				meta.spUpdate = "proc_LIST_STATUSOPTIONSUpdate"
				meta.spDelete = "proc_LIST_STATUSOPTIONSDelete"
				meta.spLoadAll = "proc_LIST_STATUSOPTIONSLoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_STATUSOPTIONSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListStatusoptionsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
