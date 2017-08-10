'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:07 PM
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
	MustInherit Public Class esInventoryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "InventoryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esInventoryQuery)
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
            Me.InitQuery(CType(query, esInventoryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Inventory) As Inventory
			Return CType(MyBase.DetachEntity(entity), Inventory)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Inventory) As Inventory
			Return CType(MyBase.AttachEntity(entity), Inventory)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As InventoryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Inventory
            Get
                Return TryCast(MyBase.Item(index), Inventory)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Inventory)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esInventory	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esInventoryQuery
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
												
						Case "Qtyavailable"
							Me.str.Qtyavailable = CType(value, string)
												
						Case "Qtyallocated"
							Me.str.Qtyallocated = CType(value, string)
												
						Case "Qtyonorder"
							Me.str.Qtyonorder = CType(value, string)
												
						Case "Qtyminimum"
							Me.str.Qtyminimum = CType(value, string)
												
						Case "Balance"
							Me.str.Balance = CType(value, string)
												
						Case "Qtyreorder"
							Me.str.Qtyreorder = CType(value, string)
												
						Case "Preferredvendorid"
							Me.str.Preferredvendorid = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyavailable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyavailable = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyallocated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyallocated = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyonorder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyonorder = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtyminimum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyminimum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Balance"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Balance = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtyreorder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtyreorder = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Preferredvendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Preferredvendorid = CType(value, Nullable(Of System.Int32))
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
		' Maps to INVENTORY.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InventoryMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InventoryMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(InventoryMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InventoryMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(InventoryMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InventoryMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.QTYAVAILABLE
		' </summary>
		Public Overridable Property Qtyavailable As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InventoryMetadata.ColumnNames.Qtyavailable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InventoryMetadata.ColumnNames.Qtyavailable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.QTYALLOCATED
		' </summary>
		Public Overridable Property Qtyallocated As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InventoryMetadata.ColumnNames.Qtyallocated)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InventoryMetadata.ColumnNames.Qtyallocated, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.QTYONORDER
		' </summary>
		Public Overridable Property Qtyonorder As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InventoryMetadata.ColumnNames.Qtyonorder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InventoryMetadata.ColumnNames.Qtyonorder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.QTYMINIMUM
		' </summary>
		Public Overridable Property Qtyminimum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InventoryMetadata.ColumnNames.Qtyminimum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InventoryMetadata.ColumnNames.Qtyminimum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.BALANCE
		' </summary>
		Public Overridable Property Balance As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InventoryMetadata.ColumnNames.Balance)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InventoryMetadata.ColumnNames.Balance, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.QTYREORDER
		' </summary>
		Public Overridable Property Qtyreorder As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InventoryMetadata.ColumnNames.Qtyreorder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InventoryMetadata.ColumnNames.Qtyreorder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.PREFERREDVENDORID
		' </summary>
		Public Overridable Property Preferredvendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InventoryMetadata.ColumnNames.Preferredvendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InventoryMetadata.ColumnNames.Preferredvendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVENTORY.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(InventoryMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InventoryMetadata.ColumnNames.Vendorname, value)
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
		
			Public Sub New(ByVal entity As esInventory)
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
		  	
			Public Property Qtyavailable As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyavailable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyavailable = Nothing
					Else
						entity.Qtyavailable = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyallocated As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyallocated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyallocated = Nothing
					Else
						entity.Qtyallocated = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyonorder As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyonorder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyonorder = Nothing
					Else
						entity.Qtyonorder = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyminimum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyminimum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyminimum = Nothing
					Else
						entity.Qtyminimum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Balance As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Balance
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Balance = Nothing
					Else
						entity.Balance = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyreorder As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtyreorder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyreorder = Nothing
					Else
						entity.Qtyreorder = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Preferredvendorid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Preferredvendorid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Preferredvendorid = Nothing
					Else
						entity.Preferredvendorid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorname As System.String 
				Get
					Dim data_ As System.String = entity.Vendorname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorname = Nothing
					Else
						entity.Vendorname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esInventory
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esInventoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esInventory can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esInventoryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InventoryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyavailable As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Qtyavailable, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyallocated As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Qtyallocated, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyonorder As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Qtyonorder, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyminimum As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Qtyminimum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Balance As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Balance, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyreorder As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Qtyreorder, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Preferredvendorid As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Preferredvendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, InventoryMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("InventoryCollection")> _
	Partial Public Class InventoryCollection
		Inherits esInventoryCollection
		Implements IEnumerable(Of Inventory)
		
        Public Shared Widening Operator CType(ByVal coll As InventoryCollection) As List(Of Inventory)
            Dim list As List(Of Inventory) = New List(Of Inventory)
            Dim emp As Inventory

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InventoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New InventoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Inventory(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Inventory()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As InventoryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New InventoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InventoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Inventory 
			Return CType(MyBase.AddNewEntity(), Inventory)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Inventory) Implements IEnumerable(Of Inventory).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Inventory)(Me)
        End Function
		
		Private _query As InventoryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'INVENTORY' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Inventory ()")> _
	<Serializable> _
	Partial Public Class Inventory 
		Inherits esInventory

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return InventoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esInventoryQuery

			If Me._query Is Nothing Then
				Me._query = New InventoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As InventoryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New InventoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InventoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As InventoryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class InventoryQuery
		inherits esInventoryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "InventoryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class InventoryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InventoryMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = InventoryMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = InventoryMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Qtyavailable, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InventoryMetadata.PropertyNames.Qtyavailable
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Qtyallocated, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InventoryMetadata.PropertyNames.Qtyallocated
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Qtyonorder, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InventoryMetadata.PropertyNames.Qtyonorder
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Qtyminimum, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InventoryMetadata.PropertyNames.Qtyminimum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Balance, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InventoryMetadata.PropertyNames.Balance
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Qtyreorder, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InventoryMetadata.PropertyNames.Qtyreorder
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Preferredvendorid, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InventoryMetadata.PropertyNames.Preferredvendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InventoryMetadata.ColumnNames.Vendorname, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = InventoryMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As InventoryMetadata
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
			 Public Const Qtyavailable As String = "QTYAVAILABLE"
			 Public Const Qtyallocated As String = "QTYALLOCATED"
			 Public Const Qtyonorder As String = "QTYONORDER"
			 Public Const Qtyminimum As String = "QTYMINIMUM"
			 Public Const Balance As String = "BALANCE"
			 Public Const Qtyreorder As String = "QTYREORDER"
			 Public Const Preferredvendorid As String = "PREFERREDVENDORID"
			 Public Const Vendorname As String = "VENDORNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Qtyavailable As String = "Qtyavailable"
			 Public Const Qtyallocated As String = "Qtyallocated"
			 Public Const Qtyonorder As String = "Qtyonorder"
			 Public Const Qtyminimum As String = "Qtyminimum"
			 Public Const Balance As String = "Balance"
			 Public Const Qtyreorder As String = "Qtyreorder"
			 Public Const Preferredvendorid As String = "Preferredvendorid"
			 Public Const Vendorname As String = "Vendorname"
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
            SyncLock GetType(InventoryMetadata)
			
				If InventoryMetadata.mapDelegates Is Nothing Then
					InventoryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If InventoryMetadata._meta Is Nothing Then
                    InventoryMetadata._meta = New InventoryMetadata()
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
				meta.AddTypeMap("Qtyavailable", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyallocated", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyonorder", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Qtyminimum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Balance", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Qtyreorder", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Preferredvendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "INVENTORY"
				meta.Destination = "INVENTORY"
				
				meta.spInsert = "proc_INVENTORYInsert"
				meta.spUpdate = "proc_INVENTORYUpdate"
				meta.spDelete = "proc_INVENTORYDelete"
				meta.spLoadAll = "proc_INVENTORYLoadAll"
				meta.spLoadByPrimaryKey = "proc_INVENTORYLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As InventoryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
