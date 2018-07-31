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
	MustInherit Public Class esListAppearanceCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListAppearanceCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListAppearanceQuery)
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
            Me.InitQuery(CType(query, esListAppearanceQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListAppearance) As ListAppearance
			Return CType(MyBase.DetachEntity(entity), ListAppearance)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListAppearance) As ListAppearance
			Return CType(MyBase.AttachEntity(entity), ListAppearance)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListAppearanceCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListAppearance
            Get
                Return TryCast(MyBase.Item(index), ListAppearance)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListAppearance)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListAppearance	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListAppearanceQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal reciid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(reciid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(reciid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal reciid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(reciid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(reciid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal reciid As System.Int32) As Boolean
		
			Dim query As esListAppearanceQuery = Me.GetDynamicQuery()
			query.Where(query.Reciid.Equal(reciid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal reciid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RECIID", reciid)
			
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
												
						Case "Reciid"
							Me.str.Reciid = CType(value, string)
												
						Case "Appearance"
							Me.str.Appearance = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Reciid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Reciid = CType(value, Nullable(Of System.Int32))
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
		' Maps to LIST_APPEARANCE.RECIID
		' </summary>
		Public Overridable Property Reciid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListAppearanceMetadata.ColumnNames.Reciid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListAppearanceMetadata.ColumnNames.Reciid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_APPEARANCE.APPEARANCE
		' </summary>
		Public Overridable Property Appearance As System.String
			Get
				Return MyBase.GetSystemString(ListAppearanceMetadata.ColumnNames.Appearance)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListAppearanceMetadata.ColumnNames.Appearance, value)
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
		
			Public Sub New(ByVal entity As esListAppearance)
				Me.entity = entity
			End Sub				
		
	
			Public Property Reciid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Reciid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reciid = Nothing
					Else
						entity.Reciid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Appearance As System.String 
				Get
					Dim data_ As System.String = entity.Appearance
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appearance = Nothing
					Else
						entity.Appearance = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListAppearance
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListAppearanceQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListAppearance can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListAppearance 
		Inherits esListAppearance
		
	
		
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
	MustInherit Public Class esListAppearanceQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListAppearanceMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Reciid As esQueryItem
			Get
				Return New esQueryItem(Me, ListAppearanceMetadata.ColumnNames.Reciid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Appearance As esQueryItem
			Get
				Return New esQueryItem(Me, ListAppearanceMetadata.ColumnNames.Appearance, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListAppearanceCollection")> _
	Partial Public Class ListAppearanceCollection
		Inherits esListAppearanceCollection
		Implements IEnumerable(Of ListAppearance)
		
        Public Shared Widening Operator CType(ByVal coll As ListAppearanceCollection) As List(Of ListAppearance)
            Dim list As List(Of ListAppearance) = New List(Of ListAppearance)
            Dim emp As ListAppearance

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListAppearanceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListAppearanceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListAppearance(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListAppearance()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListAppearanceQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListAppearanceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListAppearanceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListAppearance 
			Return CType(MyBase.AddNewEntity(), ListAppearance)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal reciid As System.Int32) As ListAppearance
			Return CType(MyBase.FindByPrimaryKey(reciid), ListAppearance)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListAppearance) Implements IEnumerable(Of ListAppearance).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListAppearance)(Me)
        End Function
		
		Private _query As ListAppearanceQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_APPEARANCE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListAppearance ({Reciid.Value})")> _
	<Serializable> _
	Partial Public Class ListAppearance 
		Inherits esListAppearance

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListAppearanceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListAppearanceQuery

			If Me._query Is Nothing Then
				Me._query = New ListAppearanceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListAppearanceQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListAppearanceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListAppearanceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListAppearanceQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListAppearanceQuery
		inherits esListAppearanceQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListAppearanceQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListAppearanceMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListAppearanceMetadata.ColumnNames.Reciid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListAppearanceMetadata.PropertyNames.Reciid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListAppearanceMetadata.ColumnNames.Appearance, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListAppearanceMetadata.PropertyNames.Appearance
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListAppearanceMetadata
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
			 Public Const Reciid As String = "RECIID"
			 Public Const Appearance As String = "APPEARANCE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Reciid As String = "Reciid"
			 Public Const Appearance As String = "Appearance"
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
            SyncLock GetType(ListAppearanceMetadata)
			
				If ListAppearanceMetadata.mapDelegates Is Nothing Then
					ListAppearanceMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListAppearanceMetadata._meta Is Nothing Then
                    ListAppearanceMetadata._meta = New ListAppearanceMetadata()
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
				

				meta.AddTypeMap("Reciid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Appearance", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_APPEARANCE"
				meta.Destination = "LIST_APPEARANCE"
				
				meta.spInsert = "proc_LIST_APPEARANCEInsert"
				meta.spUpdate = "proc_LIST_APPEARANCEUpdate"
				meta.spDelete = "proc_LIST_APPEARANCEDelete"
				meta.spLoadAll = "proc_LIST_APPEARANCELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_APPEARANCELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListAppearanceMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
