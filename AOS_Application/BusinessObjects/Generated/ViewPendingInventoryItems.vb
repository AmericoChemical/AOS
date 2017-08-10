'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/18/2016 2:24:46 PM
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
	MustInherit Public Class esViewPendingInventoryItemsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewPendingInventoryItemsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewPendingInventoryItemsQuery)
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
            Me.InitQuery(CType(query, esViewPendingInventoryItemsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewPendingInventoryItems) As ViewPendingInventoryItems
			Return CType(MyBase.DetachEntity(entity), ViewPendingInventoryItems)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewPendingInventoryItems) As ViewPendingInventoryItems
			Return CType(MyBase.AttachEntity(entity), ViewPendingInventoryItems)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewPendingInventoryItemsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewPendingInventoryItems
            Get
                Return TryCast(MyBase.Item(index), ViewPendingInventoryItems)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewPendingInventoryItems)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewPendingInventoryItems	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewPendingInventoryItemsQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		
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
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Purchasenumber"
							Me.str.Purchasenumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchasenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchasenumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewPendingInventoryItems.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPendingInventoryItemsMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPendingInventoryItemsMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPendingInventoryItems.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPendingInventoryItemsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPendingInventoryItemsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPendingInventoryItems.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewPendingInventoryItemsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPendingInventoryItemsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPendingInventoryItems.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewPendingInventoryItemsMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPendingInventoryItemsMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPendingInventoryItems.PURCHASENUMBER
		' </summary>
		Public Overridable Property Purchasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPendingInventoryItemsMetadata.ColumnNames.Purchasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPendingInventoryItemsMetadata.ColumnNames.Purchasenumber, value)
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
		
			Public Sub New(ByVal entity As esViewPendingInventoryItems)
				Me.entity = entity
			End Sub				
		
	
			Public Property Invitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnumber = Nothing
					Else
						entity.Invitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productid = Nothing
					Else
						entity.Productid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productdesc As System.String 
				Get
					Dim data_ As System.String = entity.Productdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productdesc = Nothing
					Else
						entity.Productdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Itemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemstatus = Nothing
					Else
						entity.Itemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchasenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Purchasenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasenumber = Nothing
					Else
						entity.Purchasenumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewPendingInventoryItems
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewPendingInventoryItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewPendingInventoryItems can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewPendingInventoryItemsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPendingInventoryItemsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPendingInventoryItemsMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPendingInventoryItemsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPendingInventoryItemsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPendingInventoryItemsMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPendingInventoryItemsMetadata.ColumnNames.Purchasenumber, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewPendingInventoryItemsCollection")> _
	Partial Public Class ViewPendingInventoryItemsCollection
		Inherits esViewPendingInventoryItemsCollection
		Implements IEnumerable(Of ViewPendingInventoryItems)
		
        Public Shared Widening Operator CType(ByVal coll As ViewPendingInventoryItemsCollection) As List(Of ViewPendingInventoryItems)
            Dim list As List(Of ViewPendingInventoryItems) = New List(Of ViewPendingInventoryItems)
            Dim emp As ViewPendingInventoryItems

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPendingInventoryItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewPendingInventoryItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewPendingInventoryItems(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewPendingInventoryItems()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewPendingInventoryItemsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewPendingInventoryItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPendingInventoryItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewPendingInventoryItems 
			Return CType(MyBase.AddNewEntity(), ViewPendingInventoryItems)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewPendingInventoryItems) Implements IEnumerable(Of ViewPendingInventoryItems).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewPendingInventoryItems)(Me)
        End Function
		
		Private _query As ViewPendingInventoryItemsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewPendingInventoryItems' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewPendingInventoryItems ()")> _
	<Serializable> _
	Partial Public Class ViewPendingInventoryItems 
		Inherits esViewPendingInventoryItems

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewPendingInventoryItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewPendingInventoryItemsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewPendingInventoryItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewPendingInventoryItemsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewPendingInventoryItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPendingInventoryItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewPendingInventoryItemsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewPendingInventoryItemsQuery
		inherits esViewPendingInventoryItemsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewPendingInventoryItemsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewPendingInventoryItemsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewPendingInventoryItemsMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPendingInventoryItemsMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPendingInventoryItemsMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPendingInventoryItemsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPendingInventoryItemsMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPendingInventoryItemsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPendingInventoryItemsMetadata.ColumnNames.Itemstatus, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPendingInventoryItemsMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPendingInventoryItemsMetadata.ColumnNames.Purchasenumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPendingInventoryItemsMetadata.PropertyNames.Purchasenumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewPendingInventoryItemsMetadata
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
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Purchasenumber As String = "PURCHASENUMBER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Purchasenumber As String = "Purchasenumber"
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
            SyncLock GetType(ViewPendingInventoryItemsMetadata)
			
				If ViewPendingInventoryItemsMetadata.mapDelegates Is Nothing Then
					ViewPendingInventoryItemsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewPendingInventoryItemsMetadata._meta Is Nothing Then
                    ViewPendingInventoryItemsMetadata._meta = New ViewPendingInventoryItemsMetadata()
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
				

				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchasenumber", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewPendingInventoryItems"
				meta.Destination = "viewPendingInventoryItems"
				
				meta.spInsert = "proc_viewPendingInventoryItemsInsert"
				meta.spUpdate = "proc_viewPendingInventoryItemsUpdate"
				meta.spDelete = "proc_viewPendingInventoryItemsDelete"
				meta.spLoadAll = "proc_viewPendingInventoryItemsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewPendingInventoryItemsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewPendingInventoryItemsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
