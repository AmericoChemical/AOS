'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/9/2015 10:02:11 AM
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
	MustInherit Public Class esListPriceliststatusCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListPriceliststatusCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListPriceliststatusQuery)
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
            Me.InitQuery(CType(query, esListPriceliststatusQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListPriceliststatus) As ListPriceliststatus
			Return CType(MyBase.DetachEntity(entity), ListPriceliststatus)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListPriceliststatus) As ListPriceliststatus
			Return CType(MyBase.AttachEntity(entity), ListPriceliststatus)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListPriceliststatusCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListPriceliststatus
            Get
                Return TryCast(MyBase.Item(index), ListPriceliststatus)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListPriceliststatus)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListPriceliststatus	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListPriceliststatusQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal priceliststatus As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(priceliststatus)
			Else
				Return LoadByPrimaryKeyStoredProcedure(priceliststatus)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal priceliststatus As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(priceliststatus)
			Else
				Return LoadByPrimaryKeyStoredProcedure(priceliststatus)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal priceliststatus As System.String) As Boolean
		
			Dim query As esListPriceliststatusQuery = Me.GetDynamicQuery()
			query.Where(query.Priceliststatus.Equal(priceliststatus))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal priceliststatus As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PRICELISTSTATUS", priceliststatus)
			
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
												
						Case "Priceliststatus"
							Me.str.Priceliststatus = CType(value, string)
					
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
		' Maps to LIST_PRICELISTSTATUS.PRICELISTSTATUS
		' </summary>
		Public Overridable Property Priceliststatus As System.String
			Get
				Return MyBase.GetSystemString(ListPriceliststatusMetadata.ColumnNames.Priceliststatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListPriceliststatusMetadata.ColumnNames.Priceliststatus, value)
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
		
			Public Sub New(ByVal entity As esListPriceliststatus)
				Me.entity = entity
			End Sub				
		
	
			Public Property Priceliststatus As System.String 
				Get
					Dim data_ As System.String = entity.Priceliststatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priceliststatus = Nothing
					Else
						entity.Priceliststatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListPriceliststatus
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListPriceliststatusQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListPriceliststatus can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListPriceliststatus 
		Inherits esListPriceliststatus
		
	
		
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
	MustInherit Public Class esListPriceliststatusQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListPriceliststatusMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Priceliststatus As esQueryItem
			Get
				Return New esQueryItem(Me, ListPriceliststatusMetadata.ColumnNames.Priceliststatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListPriceliststatusCollection")> _
	Partial Public Class ListPriceliststatusCollection
		Inherits esListPriceliststatusCollection
		Implements IEnumerable(Of ListPriceliststatus)
		
        Public Shared Widening Operator CType(ByVal coll As ListPriceliststatusCollection) As List(Of ListPriceliststatus)
            Dim list As List(Of ListPriceliststatus) = New List(Of ListPriceliststatus)
            Dim emp As ListPriceliststatus

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListPriceliststatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListPriceliststatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListPriceliststatus(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListPriceliststatus()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListPriceliststatusQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListPriceliststatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListPriceliststatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListPriceliststatus 
			Return CType(MyBase.AddNewEntity(), ListPriceliststatus)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal priceliststatus As System.String) As ListPriceliststatus
			Return CType(MyBase.FindByPrimaryKey(priceliststatus), ListPriceliststatus)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListPriceliststatus) Implements IEnumerable(Of ListPriceliststatus).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListPriceliststatus)(Me)
        End Function
		
		Private _query As ListPriceliststatusQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_PRICELISTSTATUS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListPriceliststatus ({Priceliststatus})")> _
	<Serializable> _
	Partial Public Class ListPriceliststatus 
		Inherits esListPriceliststatus

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListPriceliststatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListPriceliststatusQuery

			If Me._query Is Nothing Then
				Me._query = New ListPriceliststatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListPriceliststatusQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListPriceliststatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListPriceliststatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListPriceliststatusQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListPriceliststatusQuery
		inherits esListPriceliststatusQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListPriceliststatusQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListPriceliststatusMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListPriceliststatusMetadata.ColumnNames.Priceliststatus, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListPriceliststatusMetadata.PropertyNames.Priceliststatus
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListPriceliststatusMetadata
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
			 Public Const Priceliststatus As String = "PRICELISTSTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Priceliststatus As String = "Priceliststatus"
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
            SyncLock GetType(ListPriceliststatusMetadata)
			
				If ListPriceliststatusMetadata.mapDelegates Is Nothing Then
					ListPriceliststatusMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListPriceliststatusMetadata._meta Is Nothing Then
                    ListPriceliststatusMetadata._meta = New ListPriceliststatusMetadata()
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
				

				meta.AddTypeMap("Priceliststatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_PRICELISTSTATUS"
				meta.Destination = "LIST_PRICELISTSTATUS"
				
				meta.spInsert = "proc_LIST_PRICELISTSTATUSInsert"
				meta.spUpdate = "proc_LIST_PRICELISTSTATUSUpdate"
				meta.spDelete = "proc_LIST_PRICELISTSTATUSDelete"
				meta.spLoadAll = "proc_LIST_PRICELISTSTATUSLoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_PRICELISTSTATUSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListPriceliststatusMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
