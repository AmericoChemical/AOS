'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.1.0209.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/11/2012 12:51:37 PM
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
 
Namespace BusinessObjects


	<Serializable> _
	MustInherit Public Class esListUnitofmeasureCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListUnitofmeasureCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListUnitofmeasureQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntityCollection).Connection
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
            Me.InitQuery(CType(query, esListUnitofmeasureQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListUnitofmeasure) As ListUnitofmeasure
			Return CType(MyBase.DetachEntity(entity), ListUnitofmeasure)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListUnitofmeasure) As ListUnitofmeasure
			Return CType(MyBase.AttachEntity(entity), ListUnitofmeasure)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListUnitofmeasureCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListUnitofmeasure
            Get
                Return TryCast(MyBase.Item(index), ListUnitofmeasure)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListUnitofmeasure)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListUnitofmeasure	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListUnitofmeasureQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal uom As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(uom)
			Else
				Return LoadByPrimaryKeyStoredProcedure(uom)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal uom As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(uom)
			Else
				Return LoadByPrimaryKeyStoredProcedure(uom)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal uom As System.String) As Boolean
		
			Dim query As esListUnitofmeasureQuery = Me.GetDynamicQuery()
			query.Where(query.Uom.Equal(uom))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal uom As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("UOM", uom)
			
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
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "UOMType"
							Me.str.UOMType = CType(value, string)
					
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
		' Maps to LIST_UNITOFMEASURE.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ListUnitofmeasureMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListUnitofmeasureMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_UNITOFMEASURE.UOMType
		' </summary>
		Public Overridable Property UOMType As System.String
			Get
				Return MyBase.GetSystemString(ListUnitofmeasureMetadata.ColumnNames.UOMType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListUnitofmeasureMetadata.ColumnNames.UOMType, value)
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
		
			Public Sub New(ByVal entity As esListUnitofmeasure)
				Me.entity = entity
			End Sub				
		
	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UOMType As System.String 
				Get
					Dim data_ As System.String = entity.UOMType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UOMType = Nothing
					Else
						entity.UOMType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListUnitofmeasure
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListUnitofmeasureQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListUnitofmeasure can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListUnitofmeasure 
		Inherits esListUnitofmeasure
		
	
		
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
	MustInherit Public Class esListUnitofmeasureQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListUnitofmeasureMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ListUnitofmeasureMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UOMType As esQueryItem
			Get
				Return New esQueryItem(Me, ListUnitofmeasureMetadata.ColumnNames.UOMType, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListUnitofmeasureCollection")> _
	Partial Public Class ListUnitofmeasureCollection
		Inherits esListUnitofmeasureCollection
		Implements IEnumerable(Of ListUnitofmeasure)
		
        Public Shared Widening Operator CType(ByVal coll As ListUnitofmeasureCollection) As List(Of ListUnitofmeasure)
            Dim list As List(Of ListUnitofmeasure) = New List(Of ListUnitofmeasure)
            Dim emp As ListUnitofmeasure

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListUnitofmeasureMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListUnitofmeasureQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListUnitofmeasure(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListUnitofmeasure()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListUnitofmeasureQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListUnitofmeasureQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListUnitofmeasureQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListUnitofmeasure 
			Return CType(MyBase.AddNewEntity(), ListUnitofmeasure)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal uom As System.String) As ListUnitofmeasure
			Return CType(MyBase.FindByPrimaryKey(uom), ListUnitofmeasure)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListUnitofmeasure) Implements IEnumerable(Of ListUnitofmeasure).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListUnitofmeasure)(Me)
        End Function
		
		Private _query As ListUnitofmeasureQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_UNITOFMEASURE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListUnitofmeasure ({Uom})")> _
	<Serializable> _
	Partial Public Class ListUnitofmeasure 
		Inherits esListUnitofmeasure

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListUnitofmeasureMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListUnitofmeasureQuery

			If Me._query Is Nothing Then
				Me._query = New ListUnitofmeasureQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListUnitofmeasureQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListUnitofmeasureQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListUnitofmeasureQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListUnitofmeasureQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListUnitofmeasureQuery
		inherits esListUnitofmeasureQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
				

	End Class




	<Serializable> _
	Partial Public Class ListUnitofmeasureMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListUnitofmeasureMetadata.ColumnNames.Uom, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListUnitofmeasureMetadata.PropertyNames.Uom
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(ListUnitofmeasureMetadata.ColumnNames.UOMType, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListUnitofmeasureMetadata.PropertyNames.UOMType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c) 
				
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListUnitofmeasureMetadata
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
			 Public Const Uom As String = "UOM"
			 Public Const UOMType As String = "UOMType"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Uom As String = "Uom"
			 Public Const UOMType As String = "UOMType"
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
            SyncLock GetType(ListUnitofmeasureMetadata)
			
				If ListUnitofmeasureMetadata.mapDelegates Is Nothing Then
					ListUnitofmeasureMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListUnitofmeasureMetadata._meta Is Nothing Then
                    ListUnitofmeasureMetadata._meta = New ListUnitofmeasureMetadata()
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
				

				meta.AddTypeMap("UOM", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("UOMType", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_UNITOFMEASURE"
				meta.Destination = "LIST_UNITOFMEASURE"
				
				meta.spInsert = "proc_LIST_UNITOFMEASUREInsert"
				meta.spUpdate = "proc_LIST_UNITOFMEASUREUpdate"
				meta.spDelete = "proc_LIST_UNITOFMEASUREDelete"
				meta.spLoadAll = "proc_LIST_UNITOFMEASURELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_UNITOFMEASURELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListUnitofmeasureMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
