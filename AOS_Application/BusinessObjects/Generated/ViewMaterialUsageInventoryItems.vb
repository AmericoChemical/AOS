'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/27/2015 8:09:54 AM
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
	MustInherit Public Class esViewMaterialUsageInventoryItemsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewMaterialUsageInventoryItemsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewMaterialUsageInventoryItemsQuery)
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
            Me.InitQuery(CType(query, esViewMaterialUsageInventoryItemsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewMaterialUsageInventoryItems) As ViewMaterialUsageInventoryItems
			Return CType(MyBase.DetachEntity(entity), ViewMaterialUsageInventoryItems)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewMaterialUsageInventoryItems) As ViewMaterialUsageInventoryItems
			Return CType(MyBase.AttachEntity(entity), ViewMaterialUsageInventoryItems)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewMaterialUsageInventoryItemsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewMaterialUsageInventoryItems
            Get
                Return TryCast(MyBase.Item(index), ViewMaterialUsageInventoryItems)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewMaterialUsageInventoryItems)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewMaterialUsageInventoryItems	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewMaterialUsageInventoryItemsQuery
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
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Unitsremaining"
							Me.str.Unitsremaining = CType(value, string)
												
						Case "Proditemnum"
							Me.str.Proditemnum = CType(value, string)
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Iscomplete"
							Me.str.Iscomplete = CType(value, string)
					
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
						
						Case "Unitsremaining"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Unitsremaining = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Proditemnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Proditemnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qty = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Iscomplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Iscomplete = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewMaterialUsageInventoryItems.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.UNITSREMAINING
		' </summary>
		Public Overridable Property Unitsremaining As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Unitsremaining)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Unitsremaining, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.PRODITEMNUM
		' </summary>
		Public Overridable Property Proditemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Proditemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Proditemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageInventoryItems.ISCOMPLETE
		' </summary>
		Public Overridable Property Iscomplete As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Iscomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Iscomplete, value)
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
		
			Public Sub New(ByVal entity As esViewMaterialUsageInventoryItems)
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
		  	
			Public Property Unitsremaining As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Unitsremaining
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsremaining = Nothing
					Else
						entity.Unitsremaining = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Proditemnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Proditemnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Proditemnum = Nothing
					Else
						entity.Proditemnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodordernum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Prodordernum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodordernum = Nothing
					Else
						entity.Prodordernum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Materialid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Materialid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialid = Nothing
					Else
						entity.Materialid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnum = Nothing
					Else
						entity.Apisnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Qty
					
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
						entity.Qty = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Iscomplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Iscomplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Iscomplete = Nothing
					Else
						entity.Iscomplete = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewMaterialUsageInventoryItems
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewMaterialUsageInventoryItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewMaterialUsageInventoryItems can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewMaterialUsageInventoryItemsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialUsageInventoryItemsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsremaining As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Unitsremaining, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Proditemnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Proditemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Qty, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Iscomplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Iscomplete, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewMaterialUsageInventoryItemsCollection")> _
	Partial Public Class ViewMaterialUsageInventoryItemsCollection
		Inherits esViewMaterialUsageInventoryItemsCollection
		Implements IEnumerable(Of ViewMaterialUsageInventoryItems)
		
        Public Shared Widening Operator CType(ByVal coll As ViewMaterialUsageInventoryItemsCollection) As List(Of ViewMaterialUsageInventoryItems)
            Dim list As List(Of ViewMaterialUsageInventoryItems) = New List(Of ViewMaterialUsageInventoryItems)
            Dim emp As ViewMaterialUsageInventoryItems

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialUsageInventoryItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialUsageInventoryItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewMaterialUsageInventoryItems(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewMaterialUsageInventoryItems()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewMaterialUsageInventoryItemsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewMaterialUsageInventoryItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialUsageInventoryItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewMaterialUsageInventoryItems 
			Return CType(MyBase.AddNewEntity(), ViewMaterialUsageInventoryItems)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewMaterialUsageInventoryItems) Implements IEnumerable(Of ViewMaterialUsageInventoryItems).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewMaterialUsageInventoryItems)(Me)
        End Function
		
		Private _query As ViewMaterialUsageInventoryItemsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewMaterialUsageInventoryItems' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewMaterialUsageInventoryItems ()")> _
	<Serializable> _
	Partial Public Class ViewMaterialUsageInventoryItems 
		Inherits esViewMaterialUsageInventoryItems

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewMaterialUsageInventoryItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewMaterialUsageInventoryItemsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialUsageInventoryItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewMaterialUsageInventoryItemsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewMaterialUsageInventoryItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialUsageInventoryItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewMaterialUsageInventoryItemsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewMaterialUsageInventoryItemsQuery
		inherits esViewMaterialUsageInventoryItemsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewMaterialUsageInventoryItemsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewMaterialUsageInventoryItemsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Unitsremaining, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Unitsremaining
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Proditemnum, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Proditemnum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Prodordernum, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Materialid, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Apisnum, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Uom, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Qty, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Qty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageInventoryItemsMetadata.ColumnNames.Iscomplete, 11, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewMaterialUsageInventoryItemsMetadata.PropertyNames.Iscomplete
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewMaterialUsageInventoryItemsMetadata
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
			 Public Const Container As String = "CONTAINER"
			 Public Const Unitsremaining As String = "UNITSREMAINING"
			 Public Const Proditemnum As String = "PRODITEMNUM"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Uom As String = "UOM"
			 Public Const Qty As String = "QTY"
			 Public Const Iscomplete As String = "ISCOMPLETE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Unitsremaining As String = "Unitsremaining"
			 Public Const Proditemnum As String = "Proditemnum"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Materialid As String = "Materialid"
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Uom As String = "Uom"
			 Public Const Qty As String = "Qty"
			 Public Const Iscomplete As String = "Iscomplete"
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
            SyncLock GetType(ViewMaterialUsageInventoryItemsMetadata)
			
				If ViewMaterialUsageInventoryItemsMetadata.mapDelegates Is Nothing Then
					ViewMaterialUsageInventoryItemsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewMaterialUsageInventoryItemsMetadata._meta Is Nothing Then
                    ViewMaterialUsageInventoryItemsMetadata._meta = New ViewMaterialUsageInventoryItemsMetadata()
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
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitsremaining", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Proditemnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Iscomplete", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "viewMaterialUsageInventoryItems"
				meta.Destination = "viewMaterialUsageInventoryItems"
				
				meta.spInsert = "proc_viewMaterialUsageInventoryItemsInsert"
				meta.spUpdate = "proc_viewMaterialUsageInventoryItemsUpdate"
				meta.spDelete = "proc_viewMaterialUsageInventoryItemsDelete"
				meta.spLoadAll = "proc_viewMaterialUsageInventoryItemsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewMaterialUsageInventoryItemsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewMaterialUsageInventoryItemsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
