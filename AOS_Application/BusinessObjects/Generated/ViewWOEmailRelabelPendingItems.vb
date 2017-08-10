'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/8/2016 8:46:47 AM
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
	MustInherit Public Class esViewWOEmailRelabelPendingItemsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWOEmailRelabelPendingItemsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWOEmailRelabelPendingItemsQuery)
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
            Me.InitQuery(CType(query, esViewWOEmailRelabelPendingItemsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWOEmailRelabelPendingItems) As ViewWOEmailRelabelPendingItems
			Return CType(MyBase.DetachEntity(entity), ViewWOEmailRelabelPendingItems)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWOEmailRelabelPendingItems) As ViewWOEmailRelabelPendingItems
			Return CType(MyBase.AttachEntity(entity), ViewWOEmailRelabelPendingItems)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWOEmailRelabelPendingItemsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWOEmailRelabelPendingItems
            Get
                Return TryCast(MyBase.Item(index), ViewWOEmailRelabelPendingItems)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWOEmailRelabelPendingItems)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWOEmailRelabelPendingItems	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWOEmailRelabelPendingItemsQuery
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
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Rlblproductid"
							Me.str.Rlblproductid = CType(value, string)
												
						Case "Relabelordernumber"
							Me.str.Relabelordernumber = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Expectedindate"
							Me.str.Expectedindate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rlblproductid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rlblproductid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Relabelordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Expectedindate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expectedindate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewWOEmailRelabelPendingItems.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailRelabelPendingItems.RLBLPRODUCTID
		' </summary>
		Public Overridable Property Rlblproductid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Rlblproductid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Rlblproductid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailRelabelPendingItems.RELABELORDERNUMBER
		' </summary>
		Public Overridable Property Relabelordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Relabelordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Relabelordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailRelabelPendingItems.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailRelabelPendingItems.EXPECTEDINDATE
		' </summary>
		Public Overridable Property Expectedindate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Expectedindate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Expectedindate, value)
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
		
			Public Sub New(ByVal entity As esViewWOEmailRelabelPendingItems)
				Me.entity = entity
			End Sub				
		
	
			Public Property Workordernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workordernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordernumber = Nothing
					Else
						entity.Workordernumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblproductid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rlblproductid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblproductid = Nothing
					Else
						entity.Rlblproductid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelordernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Relabelordernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelordernumber = Nothing
					Else
						entity.Relabelordernumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qty = Nothing
					Else
						entity.Qty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expectedindate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expectedindate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expectedindate = Nothing
					Else
						entity.Expectedindate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWOEmailRelabelPendingItems
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWOEmailRelabelPendingItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWOEmailRelabelPendingItems can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWOEmailRelabelPendingItemsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWOEmailRelabelPendingItemsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblproductid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Rlblproductid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Relabelordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedindate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Expectedindate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWOEmailRelabelPendingItemsCollection")> _
	Partial Public Class ViewWOEmailRelabelPendingItemsCollection
		Inherits esViewWOEmailRelabelPendingItemsCollection
		Implements IEnumerable(Of ViewWOEmailRelabelPendingItems)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWOEmailRelabelPendingItemsCollection) As List(Of ViewWOEmailRelabelPendingItems)
            Dim list As List(Of ViewWOEmailRelabelPendingItems) = New List(Of ViewWOEmailRelabelPendingItems)
            Dim emp As ViewWOEmailRelabelPendingItems

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWOEmailRelabelPendingItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWOEmailRelabelPendingItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWOEmailRelabelPendingItems(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWOEmailRelabelPendingItems()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWOEmailRelabelPendingItemsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWOEmailRelabelPendingItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWOEmailRelabelPendingItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWOEmailRelabelPendingItems 
			Return CType(MyBase.AddNewEntity(), ViewWOEmailRelabelPendingItems)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWOEmailRelabelPendingItems) Implements IEnumerable(Of ViewWOEmailRelabelPendingItems).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWOEmailRelabelPendingItems)(Me)
        End Function
		
		Private _query As ViewWOEmailRelabelPendingItemsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWOEmailRelabelPendingItems' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWOEmailRelabelPendingItems ()")> _
	<Serializable> _
	Partial Public Class ViewWOEmailRelabelPendingItems 
		Inherits esViewWOEmailRelabelPendingItems

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWOEmailRelabelPendingItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWOEmailRelabelPendingItemsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWOEmailRelabelPendingItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWOEmailRelabelPendingItemsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWOEmailRelabelPendingItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWOEmailRelabelPendingItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWOEmailRelabelPendingItemsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWOEmailRelabelPendingItemsQuery
		inherits esViewWOEmailRelabelPendingItemsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWOEmailRelabelPendingItemsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWOEmailRelabelPendingItemsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailRelabelPendingItemsMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Rlblproductid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailRelabelPendingItemsMetadata.PropertyNames.Rlblproductid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Relabelordernumber, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailRelabelPendingItemsMetadata.PropertyNames.Relabelordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Qty, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWOEmailRelabelPendingItemsMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailRelabelPendingItemsMetadata.ColumnNames.Expectedindate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWOEmailRelabelPendingItemsMetadata.PropertyNames.Expectedindate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWOEmailRelabelPendingItemsMetadata
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
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Rlblproductid As String = "RLBLPRODUCTID"
			 Public Const Relabelordernumber As String = "RELABELORDERNUMBER"
			 Public Const Qty As String = "QTY"
			 Public Const Expectedindate As String = "EXPECTEDINDATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Rlblproductid As String = "Rlblproductid"
			 Public Const Relabelordernumber As String = "Relabelordernumber"
			 Public Const Qty As String = "Qty"
			 Public Const Expectedindate As String = "Expectedindate"
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
            SyncLock GetType(ViewWOEmailRelabelPendingItemsMetadata)
			
				If ViewWOEmailRelabelPendingItemsMetadata.mapDelegates Is Nothing Then
					ViewWOEmailRelabelPendingItemsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWOEmailRelabelPendingItemsMetadata._meta Is Nothing Then
                    ViewWOEmailRelabelPendingItemsMetadata._meta = New ViewWOEmailRelabelPendingItemsMetadata()
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
				

				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rlblproductid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Expectedindate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewWOEmailRelabelPendingItems"
				meta.Destination = "viewWOEmailRelabelPendingItems"
				
				meta.spInsert = "proc_viewWOEmailRelabelPendingItemsInsert"
				meta.spUpdate = "proc_viewWOEmailRelabelPendingItemsUpdate"
				meta.spDelete = "proc_viewWOEmailRelabelPendingItemsDelete"
				meta.spLoadAll = "proc_viewWOEmailRelabelPendingItemsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWOEmailRelabelPendingItemsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWOEmailRelabelPendingItemsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
