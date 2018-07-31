'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:08 PM
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
	MustInherit Public Class esViewCurrentInventoryStatsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCurrentInventoryStatsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCurrentInventoryStatsQuery)
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
            Me.InitQuery(CType(query, esViewCurrentInventoryStatsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCurrentInventoryStats) As ViewCurrentInventoryStats
			Return CType(MyBase.DetachEntity(entity), ViewCurrentInventoryStats)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCurrentInventoryStats) As ViewCurrentInventoryStats
			Return CType(MyBase.AttachEntity(entity), ViewCurrentInventoryStats)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCurrentInventoryStatsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCurrentInventoryStats
            Get
                Return TryCast(MyBase.Item(index), ViewCurrentInventoryStats)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCurrentInventoryStats)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCurrentInventoryStats	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCurrentInventoryStatsQuery
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
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Inventorygrouping"
							Me.str.Inventorygrouping = CType(value, string)
												
						Case "Available"
							Me.str.Available = CType(value, string)
												
						Case "Allocated"
							Me.str.Allocated = CType(value, string)
												
						Case "Testing"
							Me.str.Testing = CType(value, string)
												
						Case "Production"
							Me.str.Production = CType(value, string)
												
						Case "OnOrder"
							Me.str.OnOrder = CType(value, string)
												
						Case "Requested"
							Me.str.Requested = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Inventorygrouping"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventorygrouping = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Available"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Available = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Allocated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Allocated = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Testing"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Testing = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Production"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Production = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "OnOrder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OnOrder = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Requested"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Requested = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCurrentInventoryStats.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCurrentInventoryStats.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCurrentInventoryStatsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCurrentInventoryStatsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCurrentInventoryStats.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCurrentInventoryStatsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCurrentInventoryStatsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCurrentInventoryStats.INVENTORYGROUPING
		' </summary>
		Public Overridable Property Inventorygrouping As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Inventorygrouping)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Inventorygrouping, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCurrentInventoryStats.Available
		' </summary>
		Public Overridable Property Available As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Available)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Available, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCurrentInventoryStats.Allocated
		' </summary>
		Public Overridable Property Allocated As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Allocated)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Allocated, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCurrentInventoryStats.Testing
		' </summary>
		Public Overridable Property Testing As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Testing)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Testing, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCurrentInventoryStats.Production
		' </summary>
		Public Overridable Property Production As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Production)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Production, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCurrentInventoryStats.OnOrder
		' </summary>
		Public Overridable Property OnOrder As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCurrentInventoryStatsMetadata.ColumnNames.OnOrder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCurrentInventoryStatsMetadata.ColumnNames.OnOrder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCurrentInventoryStats.Requested
		' </summary>
		Public Overridable Property Requested As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Requested)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCurrentInventoryStatsMetadata.ColumnNames.Requested, value)
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
		
			Public Sub New(ByVal entity As esViewCurrentInventoryStats)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Container As System.String 
				Get
					Dim data_ As System.String = entity.Container
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Container = Nothing
					Else
						entity.Container = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventorygrouping As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Inventorygrouping
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventorygrouping = Nothing
					Else
						entity.Inventorygrouping = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Available As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Available
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Available = Nothing
					Else
						entity.Available = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Allocated As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Allocated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Allocated = Nothing
					Else
						entity.Allocated = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Testing As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Testing
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Testing = Nothing
					Else
						entity.Testing = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Production As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Production
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Production = Nothing
					Else
						entity.Production = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property OnOrder As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OnOrder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OnOrder = Nothing
					Else
						entity.OnOrder = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Requested As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Requested
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Requested = Nothing
					Else
						entity.Requested = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCurrentInventoryStats
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCurrentInventoryStatsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCurrentInventoryStats can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCurrentInventoryStatsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCurrentInventoryStatsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventorygrouping As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.Inventorygrouping, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Available As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.Available, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Allocated As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.Allocated, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Testing As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.Testing, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Production As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.Production, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OnOrder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.OnOrder, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Requested As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCurrentInventoryStatsMetadata.ColumnNames.Requested, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCurrentInventoryStatsCollection")> _
	Partial Public Class ViewCurrentInventoryStatsCollection
		Inherits esViewCurrentInventoryStatsCollection
		Implements IEnumerable(Of ViewCurrentInventoryStats)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCurrentInventoryStatsCollection) As List(Of ViewCurrentInventoryStats)
            Dim list As List(Of ViewCurrentInventoryStats) = New List(Of ViewCurrentInventoryStats)
            Dim emp As ViewCurrentInventoryStats

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCurrentInventoryStatsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCurrentInventoryStatsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCurrentInventoryStats(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCurrentInventoryStats()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCurrentInventoryStatsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCurrentInventoryStatsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCurrentInventoryStatsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCurrentInventoryStats 
			Return CType(MyBase.AddNewEntity(), ViewCurrentInventoryStats)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCurrentInventoryStats) Implements IEnumerable(Of ViewCurrentInventoryStats).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCurrentInventoryStats)(Me)
        End Function
		
		Private _query As ViewCurrentInventoryStatsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCurrentInventoryStats' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCurrentInventoryStats ()")> _
	<Serializable> _
	Partial Public Class ViewCurrentInventoryStats 
		Inherits esViewCurrentInventoryStats

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCurrentInventoryStatsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCurrentInventoryStatsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCurrentInventoryStatsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCurrentInventoryStatsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCurrentInventoryStatsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCurrentInventoryStatsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCurrentInventoryStatsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCurrentInventoryStatsQuery
		inherits esViewCurrentInventoryStatsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCurrentInventoryStatsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCurrentInventoryStatsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.Inventorygrouping, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.Inventorygrouping
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.Available, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.Available
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.Allocated, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.Allocated
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.Testing, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.Testing
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.Production, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.Production
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.OnOrder, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.OnOrder
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCurrentInventoryStatsMetadata.ColumnNames.Requested, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCurrentInventoryStatsMetadata.PropertyNames.Requested
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCurrentInventoryStatsMetadata
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
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Inventorygrouping As String = "INVENTORYGROUPING"
			 Public Const Available As String = "Available"
			 Public Const Allocated As String = "Allocated"
			 Public Const Testing As String = "Testing"
			 Public Const Production As String = "Production"
			 Public Const OnOrder As String = "OnOrder"
			 Public Const Requested As String = "Requested"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Inventorygrouping As String = "Inventorygrouping"
			 Public Const Available As String = "Available"
			 Public Const Allocated As String = "Allocated"
			 Public Const Testing As String = "Testing"
			 Public Const Production As String = "Production"
			 Public Const OnOrder As String = "OnOrder"
			 Public Const Requested As String = "Requested"
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
            SyncLock GetType(ViewCurrentInventoryStatsMetadata)
			
				If ViewCurrentInventoryStatsMetadata.mapDelegates Is Nothing Then
					ViewCurrentInventoryStatsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCurrentInventoryStatsMetadata._meta Is Nothing Then
                    ViewCurrentInventoryStatsMetadata._meta = New ViewCurrentInventoryStatsMetadata()
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
				

				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventorygrouping", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Available", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Allocated", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Testing", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Production", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("OnOrder", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Requested", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCurrentInventoryStats"
				meta.Destination = "viewCurrentInventoryStats"
				
				meta.spInsert = "proc_viewCurrentInventoryStatsInsert"
				meta.spUpdate = "proc_viewCurrentInventoryStatsUpdate"
				meta.spDelete = "proc_viewCurrentInventoryStatsDelete"
				meta.spLoadAll = "proc_viewCurrentInventoryStatsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCurrentInventoryStatsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCurrentInventoryStatsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
