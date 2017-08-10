'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/8/2014 9:20:53 PM
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
	MustInherit Public Class esListPricingmethodCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListPricingmethodCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListPricingmethodQuery)
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
            Me.InitQuery(CType(query, esListPricingmethodQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListPricingmethod) As ListPricingmethod
			Return CType(MyBase.DetachEntity(entity), ListPricingmethod)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListPricingmethod) As ListPricingmethod
			Return CType(MyBase.AttachEntity(entity), ListPricingmethod)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListPricingmethodCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListPricingmethod
            Get
                Return TryCast(MyBase.Item(index), ListPricingmethod)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListPricingmethod)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListPricingmethod	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListPricingmethodQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal id As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal id As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(id)
			Else
				Return LoadByPrimaryKeyStoredProcedure(id)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal id As System.Int32) As Boolean
		
			Dim query As esListPricingmethodQuery = Me.GetDynamicQuery()
			query.Where(query.Id.Equal(id))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal id As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("Id", id)
			
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
												
						Case "Id"
							Me.str.Id = CType(value, string)
												
						Case "PricingMethod"
							Me.str.PricingMethod = CType(value, string)
												
						Case "SortSequence"
							Me.str.SortSequence = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Id"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Id = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SortSequence"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SortSequence = CType(value, Nullable(Of System.Int32))
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
		' Maps to LIST_PRICINGMETHOD.Id
		' </summary>
		Public Overridable Property Id As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListPricingmethodMetadata.ColumnNames.Id)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListPricingmethodMetadata.ColumnNames.Id, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_PRICINGMETHOD.PricingMethod
		' </summary>
		Public Overridable Property PricingMethod As System.String
			Get
				Return MyBase.GetSystemString(ListPricingmethodMetadata.ColumnNames.PricingMethod)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListPricingmethodMetadata.ColumnNames.PricingMethod, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_PRICINGMETHOD.SortSequence
		' </summary>
		Public Overridable Property SortSequence As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListPricingmethodMetadata.ColumnNames.SortSequence)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListPricingmethodMetadata.ColumnNames.SortSequence, value)
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
		
			Public Sub New(ByVal entity As esListPricingmethod)
				Me.entity = entity
			End Sub				
		
	
			Public Property Id As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Id
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Id = Nothing
					Else
						entity.Id = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PricingMethod As System.String 
				Get
					Dim data_ As System.String = entity.PricingMethod
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PricingMethod = Nothing
					Else
						entity.PricingMethod = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SortSequence As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SortSequence
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SortSequence = Nothing
					Else
						entity.SortSequence = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListPricingmethod
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListPricingmethodQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListPricingmethod can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListPricingmethod 
		Inherits esListPricingmethod
		
	
		
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
	MustInherit Public Class esListPricingmethodQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListPricingmethodMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Id As esQueryItem
			Get
				Return New esQueryItem(Me, ListPricingmethodMetadata.ColumnNames.Id, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PricingMethod As esQueryItem
			Get
				Return New esQueryItem(Me, ListPricingmethodMetadata.ColumnNames.PricingMethod, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SortSequence As esQueryItem
			Get
				Return New esQueryItem(Me, ListPricingmethodMetadata.ColumnNames.SortSequence, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListPricingmethodCollection")> _
	Partial Public Class ListPricingmethodCollection
		Inherits esListPricingmethodCollection
		Implements IEnumerable(Of ListPricingmethod)
		
        Public Shared Widening Operator CType(ByVal coll As ListPricingmethodCollection) As List(Of ListPricingmethod)
            Dim list As List(Of ListPricingmethod) = New List(Of ListPricingmethod)
            Dim emp As ListPricingmethod

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListPricingmethodMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListPricingmethodQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListPricingmethod(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListPricingmethod()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListPricingmethodQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListPricingmethodQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListPricingmethodQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListPricingmethod 
			Return CType(MyBase.AddNewEntity(), ListPricingmethod)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal id As System.Int32) As ListPricingmethod
			Return CType(MyBase.FindByPrimaryKey(id), ListPricingmethod)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListPricingmethod) Implements IEnumerable(Of ListPricingmethod).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListPricingmethod)(Me)
        End Function
		
		Private _query As ListPricingmethodQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_PRICINGMETHOD' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListPricingmethod ({Id.Value})")> _
	<Serializable> _
	Partial Public Class ListPricingmethod 
		Inherits esListPricingmethod

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListPricingmethodMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListPricingmethodQuery

			If Me._query Is Nothing Then
				Me._query = New ListPricingmethodQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListPricingmethodQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListPricingmethodQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListPricingmethodQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListPricingmethodQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListPricingmethodQuery
		inherits esListPricingmethodQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListPricingmethodQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListPricingmethodMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListPricingmethodMetadata.ColumnNames.Id, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListPricingmethodMetadata.PropertyNames.Id
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListPricingmethodMetadata.ColumnNames.PricingMethod, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListPricingmethodMetadata.PropertyNames.PricingMethod
			c.CharacterMaxLength = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListPricingmethodMetadata.ColumnNames.SortSequence, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListPricingmethodMetadata.PropertyNames.SortSequence
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListPricingmethodMetadata
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
			 Public Const Id As String = "Id"
			 Public Const PricingMethod As String = "PricingMethod"
			 Public Const SortSequence As String = "SortSequence"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Id As String = "Id"
			 Public Const PricingMethod As String = "PricingMethod"
			 Public Const SortSequence As String = "SortSequence"
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
            SyncLock GetType(ListPricingmethodMetadata)
			
				If ListPricingmethodMetadata.mapDelegates Is Nothing Then
					ListPricingmethodMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListPricingmethodMetadata._meta Is Nothing Then
                    ListPricingmethodMetadata._meta = New ListPricingmethodMetadata()
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
				

				meta.AddTypeMap("Id", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PricingMethod", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SortSequence", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "LIST_PRICINGMETHOD"
				meta.Destination = "LIST_PRICINGMETHOD"
				
				meta.spInsert = "proc_LIST_PRICINGMETHODInsert"
				meta.spUpdate = "proc_LIST_PRICINGMETHODUpdate"
				meta.spDelete = "proc_LIST_PRICINGMETHODDelete"
				meta.spLoadAll = "proc_LIST_PRICINGMETHODLoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_PRICINGMETHODLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListPricingmethodMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
