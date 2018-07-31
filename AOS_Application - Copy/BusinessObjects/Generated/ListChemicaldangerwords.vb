'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/6/2015 1:27:29 PM
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
	MustInherit Public Class esListChemicaldangerwordsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListChemicaldangerwordsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListChemicaldangerwordsQuery)
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
            Me.InitQuery(CType(query, esListChemicaldangerwordsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListChemicaldangerwords) As ListChemicaldangerwords
			Return CType(MyBase.DetachEntity(entity), ListChemicaldangerwords)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListChemicaldangerwords) As ListChemicaldangerwords
			Return CType(MyBase.AttachEntity(entity), ListChemicaldangerwords)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListChemicaldangerwordsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListChemicaldangerwords
            Get
                Return TryCast(MyBase.Item(index), ListChemicaldangerwords)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListChemicaldangerwords)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListChemicaldangerwords	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListChemicaldangerwordsQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal dangerword As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(dangerword)
			Else
				Return LoadByPrimaryKeyStoredProcedure(dangerword)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal dangerword As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(dangerword)
			Else
				Return LoadByPrimaryKeyStoredProcedure(dangerword)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal dangerword As System.String) As Boolean
		
			Dim query As esListChemicaldangerwordsQuery = Me.GetDynamicQuery()
			query.Where(query.Dangerword.Equal(dangerword))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal dangerword As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("DANGERWORD", dangerword)
			
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
												
						Case "Dangerword"
							Me.str.Dangerword = CType(value, string)
					
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
		' Maps to LIST_CHEMICALDANGERWORDS.DANGERWORD
		' </summary>
		Public Overridable Property Dangerword As System.String
			Get
				Return MyBase.GetSystemString(ListChemicaldangerwordsMetadata.ColumnNames.Dangerword)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListChemicaldangerwordsMetadata.ColumnNames.Dangerword, value)
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
		
			Public Sub New(ByVal entity As esListChemicaldangerwords)
				Me.entity = entity
			End Sub				
		
	
			Public Property Dangerword As System.String 
				Get
					Dim data_ As System.String = entity.Dangerword
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dangerword = Nothing
					Else
						entity.Dangerword = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListChemicaldangerwords
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListChemicaldangerwordsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListChemicaldangerwords can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListChemicaldangerwords 
		Inherits esListChemicaldangerwords
		
	
		
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
	MustInherit Public Class esListChemicaldangerwordsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListChemicaldangerwordsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Dangerword As esQueryItem
			Get
				Return New esQueryItem(Me, ListChemicaldangerwordsMetadata.ColumnNames.Dangerword, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListChemicaldangerwordsCollection")> _
	Partial Public Class ListChemicaldangerwordsCollection
		Inherits esListChemicaldangerwordsCollection
		Implements IEnumerable(Of ListChemicaldangerwords)
		
        Public Shared Widening Operator CType(ByVal coll As ListChemicaldangerwordsCollection) As List(Of ListChemicaldangerwords)
            Dim list As List(Of ListChemicaldangerwords) = New List(Of ListChemicaldangerwords)
            Dim emp As ListChemicaldangerwords

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListChemicaldangerwordsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListChemicaldangerwordsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListChemicaldangerwords(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListChemicaldangerwords()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListChemicaldangerwordsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListChemicaldangerwordsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListChemicaldangerwordsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListChemicaldangerwords 
			Return CType(MyBase.AddNewEntity(), ListChemicaldangerwords)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal dangerword As System.String) As ListChemicaldangerwords
			Return CType(MyBase.FindByPrimaryKey(dangerword), ListChemicaldangerwords)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListChemicaldangerwords) Implements IEnumerable(Of ListChemicaldangerwords).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListChemicaldangerwords)(Me)
        End Function
		
		Private _query As ListChemicaldangerwordsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_CHEMICALDANGERWORDS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListChemicaldangerwords ({Dangerword})")> _
	<Serializable> _
	Partial Public Class ListChemicaldangerwords 
		Inherits esListChemicaldangerwords

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListChemicaldangerwordsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListChemicaldangerwordsQuery

			If Me._query Is Nothing Then
				Me._query = New ListChemicaldangerwordsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListChemicaldangerwordsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListChemicaldangerwordsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListChemicaldangerwordsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListChemicaldangerwordsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListChemicaldangerwordsQuery
		inherits esListChemicaldangerwordsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListChemicaldangerwordsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListChemicaldangerwordsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListChemicaldangerwordsMetadata.ColumnNames.Dangerword, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListChemicaldangerwordsMetadata.PropertyNames.Dangerword
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListChemicaldangerwordsMetadata
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
			 Public Const Dangerword As String = "DANGERWORD"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Dangerword As String = "Dangerword"
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
            SyncLock GetType(ListChemicaldangerwordsMetadata)
			
				If ListChemicaldangerwordsMetadata.mapDelegates Is Nothing Then
					ListChemicaldangerwordsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListChemicaldangerwordsMetadata._meta Is Nothing Then
                    ListChemicaldangerwordsMetadata._meta = New ListChemicaldangerwordsMetadata()
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
				

				meta.AddTypeMap("Dangerword", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_CHEMICALDANGERWORDS"
				meta.Destination = "LIST_CHEMICALDANGERWORDS"
				
				meta.spInsert = "proc_LIST_CHEMICALDANGERWORDSInsert"
				meta.spUpdate = "proc_LIST_CHEMICALDANGERWORDSUpdate"
				meta.spDelete = "proc_LIST_CHEMICALDANGERWORDSDelete"
				meta.spLoadAll = "proc_LIST_CHEMICALDANGERWORDSLoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_CHEMICALDANGERWORDSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListChemicaldangerwordsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
