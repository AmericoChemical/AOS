'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:09 PM
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
	MustInherit Public Class esViewProdItemDataCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewProdItemDataCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewProdItemDataQuery)
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
            Me.InitQuery(CType(query, esViewProdItemDataQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewProdItemData) As ViewProdItemData
			Return CType(MyBase.DetachEntity(entity), ViewProdItemData)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewProdItemData) As ViewProdItemData
			Return CType(MyBase.AttachEntity(entity), ViewProdItemData)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewProdItemDataCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewProdItemData
            Get
                Return TryCast(MyBase.Item(index), ViewProdItemData)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewProdItemData)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewProdItemData	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewProdItemDataQuery
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
												
						Case "Materialdesc"
							Me.str.Materialdesc = CType(value, string)
												
						Case "Inventory"
							Me.str.Inventory = CType(value, string)
												
						Case "Inprocess"
							Me.str.Inprocess = CType(value, string)
												
						Case "Available"
							Me.str.Available = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
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
						
						Case "Inventory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Inventory = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Inprocess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Inprocess = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Available"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Available = CType(value, Nullable(Of System.Double))
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
		' Maps to viewProdItemData.PRODITEMNUM
		' </summary>
		Public Overridable Property Proditemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProdItemDataMetadata.ColumnNames.Proditemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProdItemDataMetadata.ColumnNames.Proditemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProdItemDataMetadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProdItemDataMetadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProdItemDataMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProdItemDataMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProdItemDataMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProdItemDataMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewProdItemDataMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProdItemDataMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewProdItemDataMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewProdItemDataMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.ISCOMPLETE
		' </summary>
		Public Overridable Property Iscomplete As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProdItemDataMetadata.ColumnNames.Iscomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProdItemDataMetadata.ColumnNames.Iscomplete, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProdItemDataMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProdItemDataMetadata.ColumnNames.Materialdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.INVENTORY
		' </summary>
		Public Overridable Property Inventory As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewProdItemDataMetadata.ColumnNames.Inventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewProdItemDataMetadata.ColumnNames.Inventory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.INPROCESS
		' </summary>
		Public Overridable Property Inprocess As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewProdItemDataMetadata.ColumnNames.Inprocess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewProdItemDataMetadata.ColumnNames.Inprocess, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdItemData.AVAILABLE
		' </summary>
		Public Overridable Property Available As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewProdItemDataMetadata.ColumnNames.Available)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewProdItemDataMetadata.ColumnNames.Available, value)
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
		
			Public Sub New(ByVal entity As esViewProdItemData)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Materialdesc As System.String 
				Get
					Dim data_ As System.String = entity.Materialdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialdesc = Nothing
					Else
						entity.Materialdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventory As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Inventory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventory = Nothing
					Else
						entity.Inventory = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inprocess As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Inprocess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inprocess = Nothing
					Else
						entity.Inprocess = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Available As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Available
					
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
						entity.Available = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewProdItemData
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewProdItemDataQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewProdItemData can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewProdItemDataQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProdItemDataMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Proditemnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Proditemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Qty, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Iscomplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Iscomplete, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Inventory, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Inprocess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Inprocess, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Available As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdItemDataMetadata.ColumnNames.Available, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewProdItemDataCollection")> _
	Partial Public Class ViewProdItemDataCollection
		Inherits esViewProdItemDataCollection
		Implements IEnumerable(Of ViewProdItemData)
		
        Public Shared Widening Operator CType(ByVal coll As ViewProdItemDataCollection) As List(Of ViewProdItemData)
            Dim list As List(Of ViewProdItemData) = New List(Of ViewProdItemData)
            Dim emp As ViewProdItemData

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProdItemDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewProdItemDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewProdItemData(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewProdItemData()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewProdItemDataQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewProdItemDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProdItemDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewProdItemData 
			Return CType(MyBase.AddNewEntity(), ViewProdItemData)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewProdItemData) Implements IEnumerable(Of ViewProdItemData).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewProdItemData)(Me)
        End Function
		
		Private _query As ViewProdItemDataQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewProdItemData' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewProdItemData ()")> _
	<Serializable> _
	Partial Public Class ViewProdItemData 
		Inherits esViewProdItemData

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewProdItemDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewProdItemDataQuery

			If Me._query Is Nothing Then
				Me._query = New ViewProdItemDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewProdItemDataQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewProdItemDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProdItemDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewProdItemDataQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewProdItemDataQuery
		inherits esViewProdItemDataQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewProdItemDataQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewProdItemDataMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Proditemnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Proditemnum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Prodordernum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Materialid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Apisnum, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Uom, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Qty, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Qty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Iscomplete, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Iscomplete
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Materialdesc, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Inventory, 8, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Inventory
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Inprocess, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Inprocess
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdItemDataMetadata.ColumnNames.Available, 10, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewProdItemDataMetadata.PropertyNames.Available
			c.NumericPrecision = 15
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewProdItemDataMetadata
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
			 Public Const Proditemnum As String = "PRODITEMNUM"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Uom As String = "UOM"
			 Public Const Qty As String = "QTY"
			 Public Const Iscomplete As String = "ISCOMPLETE"
			 Public Const Materialdesc As String = "MATERIALDESC"
			 Public Const Inventory As String = "INVENTORY"
			 Public Const Inprocess As String = "INPROCESS"
			 Public Const Available As String = "AVAILABLE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Proditemnum As String = "Proditemnum"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Materialid As String = "Materialid"
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Uom As String = "Uom"
			 Public Const Qty As String = "Qty"
			 Public Const Iscomplete As String = "Iscomplete"
			 Public Const Materialdesc As String = "Materialdesc"
			 Public Const Inventory As String = "Inventory"
			 Public Const Inprocess As String = "Inprocess"
			 Public Const Available As String = "Available"
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
            SyncLock GetType(ViewProdItemDataMetadata)
			
				If ViewProdItemDataMetadata.mapDelegates Is Nothing Then
					ViewProdItemDataMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewProdItemDataMetadata._meta Is Nothing Then
                    ViewProdItemDataMetadata._meta = New ViewProdItemDataMetadata()
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
				

				meta.AddTypeMap("Proditemnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Iscomplete", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Materialdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventory", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Inprocess", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Available", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "viewProdItemData"
				meta.Destination = "viewProdItemData"
				
				meta.spInsert = "proc_viewProdItemDataInsert"
				meta.spUpdate = "proc_viewProdItemDataUpdate"
				meta.spDelete = "proc_viewProdItemDataDelete"
				meta.spLoadAll = "proc_viewProdItemDataLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewProdItemDataLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewProdItemDataMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
