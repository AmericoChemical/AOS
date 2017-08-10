'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/9/2014 7:14:20 PM
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
	MustInherit Public Class esViewWorkOrderItemPricingCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrderItemPricingCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderItemPricingQuery)
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
            Me.InitQuery(CType(query, esViewWorkOrderItemPricingQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrderItemPricing) As ViewWorkOrderItemPricing
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrderItemPricing)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrderItemPricing) As ViewWorkOrderItemPricing
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrderItemPricing)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrderItemPricingCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrderItemPricing
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrderItemPricing)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrderItemPricing)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrderItemPricing	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrderItemPricingQuery
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
												
						Case "Priceunits"
							Me.str.Priceunits = CType(value, string)
												
						Case "Priceuom"
							Me.str.Priceuom = CType(value, string)
												
						Case "Unitprice"
							Me.str.Unitprice = CType(value, string)
												
						Case "Standardcostunits"
							Me.str.Standardcostunits = CType(value, string)
												
						Case "Standardcostuom"
							Me.str.Standardcostuom = CType(value, string)
												
						Case "Standardunitcost"
							Me.str.Standardunitcost = CType(value, string)
												
						Case "Actualcostunits"
							Me.str.Actualcostunits = CType(value, string)
												
						Case "Actualcostuom"
							Me.str.Actualcostuom = CType(value, string)
												
						Case "Actualunitcost"
							Me.str.Actualunitcost = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Priceunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Priceunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Standardcostunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Standardcostunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Standardunitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Standardunitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Actualcostunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Actualcostunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Actualunitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Actualunitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to ViewWorkOrderItemPricing.PRICEUNITS
		' </summary>
		Public Overridable Property Priceunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Priceunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Priceunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.PRICEUOM
		' </summary>
		Public Overridable Property Priceuom As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemPricingMetadata.ColumnNames.Priceuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemPricingMetadata.ColumnNames.Priceuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.UNITPRICE
		' </summary>
		Public Overridable Property Unitprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Unitprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Unitprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.STANDARDCOSTUNITS
		' </summary>
		Public Overridable Property Standardcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Standardcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Standardcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.STANDARDCOSTUOM
		' </summary>
		Public Overridable Property Standardcostuom As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemPricingMetadata.ColumnNames.Standardcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemPricingMetadata.ColumnNames.Standardcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.STANDARDUNITCOST
		' </summary>
		Public Overridable Property Standardunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Standardunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Standardunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.ACTUALCOSTUNITS
		' </summary>
		Public Overridable Property Actualcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Actualcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Actualcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.ACTUALCOSTUOM
		' </summary>
		Public Overridable Property Actualcostuom As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemPricingMetadata.ColumnNames.Actualcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemPricingMetadata.ColumnNames.Actualcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.ACTUALUNITCOST
		' </summary>
		Public Overridable Property Actualunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Actualunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemPricingMetadata.ColumnNames.Actualunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemPricingMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemPricingMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ViewWorkOrderItemPricing.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemPricingMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemPricingMetadata.ColumnNames.Workorderitemnumber, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrderItemPricing)
				Me.entity = entity
			End Sub				
		
	
			Public Property Priceunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Priceunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priceunits = Nothing
					Else
						entity.Priceunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priceuom As System.String 
				Get
					Dim data_ As System.String = entity.Priceuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priceuom = Nothing
					Else
						entity.Priceuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitprice = Nothing
					Else
						entity.Unitprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Standardcostunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Standardcostunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Standardcostunits = Nothing
					Else
						entity.Standardcostunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Standardcostuom As System.String 
				Get
					Dim data_ As System.String = entity.Standardcostuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Standardcostuom = Nothing
					Else
						entity.Standardcostuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Standardunitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Standardunitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Standardunitcost = Nothing
					Else
						entity.Standardunitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Actualcostunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Actualcostunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Actualcostunits = Nothing
					Else
						entity.Actualcostunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Actualcostuom As System.String 
				Get
					Dim data_ As System.String = entity.Actualcostuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Actualcostuom = Nothing
					Else
						entity.Actualcostuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Actualunitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Actualunitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Actualunitcost = Nothing
					Else
						entity.Actualunitcost = Convert.ToDecimal(Value)
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
		  	
			Public Property Workorderitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workorderitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderitemnumber = Nothing
					Else
						entity.Workorderitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWorkOrderItemPricing
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderItemPricingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrderItemPricing can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrderItemPricingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderItemPricingMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Priceunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Priceunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Priceuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Priceuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Unitprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Standardcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Standardcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Standardunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Standardunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Actualcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Actualcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Actualunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Actualunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemPricingMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrderItemPricingCollection")> _
	Partial Public Class ViewWorkOrderItemPricingCollection
		Inherits esViewWorkOrderItemPricingCollection
		Implements IEnumerable(Of ViewWorkOrderItemPricing)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrderItemPricingCollection) As List(Of ViewWorkOrderItemPricing)
            Dim list As List(Of ViewWorkOrderItemPricing) = New List(Of ViewWorkOrderItemPricing)
            Dim emp As ViewWorkOrderItemPricing

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderItemPricingMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderItemPricingQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrderItemPricing(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrderItemPricing()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrderItemPricingQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrderItemPricingQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderItemPricingQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrderItemPricing 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrderItemPricing)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrderItemPricing) Implements IEnumerable(Of ViewWorkOrderItemPricing).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrderItemPricing)(Me)
        End Function
		
		Private _query As ViewWorkOrderItemPricingQuery

	End Class
	


	' <summary>
	' Encapsulates the 'ViewWorkOrderItemPricing' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrderItemPricing ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderItemPricing 
		Inherits esViewWorkOrderItemPricing

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrderItemPricingMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrderItemPricingQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderItemPricingQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrderItemPricingQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrderItemPricingQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderItemPricingQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrderItemPricingQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderItemPricingQuery
		inherits esViewWorkOrderItemPricingQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrderItemPricingQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrderItemPricingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Priceunits, 0, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Priceunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Priceuom, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Priceuom
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Unitprice, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Unitprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Standardcostunits, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Standardcostunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Standardcostuom, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Standardcostuom
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Standardunitcost, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Standardunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Actualcostunits, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Actualcostunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Actualcostuom, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Actualcostuom
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Actualunitcost, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Actualunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Productid, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemPricingMetadata.ColumnNames.Workorderitemnumber, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemPricingMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrderItemPricingMetadata
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
			 Public Const Priceunits As String = "PRICEUNITS"
			 Public Const Priceuom As String = "PRICEUOM"
			 Public Const Unitprice As String = "UNITPRICE"
			 Public Const Standardcostunits As String = "STANDARDCOSTUNITS"
			 Public Const Standardcostuom As String = "STANDARDCOSTUOM"
			 Public Const Standardunitcost As String = "STANDARDUNITCOST"
			 Public Const Actualcostunits As String = "ACTUALCOSTUNITS"
			 Public Const Actualcostuom As String = "ACTUALCOSTUOM"
			 Public Const Actualunitcost As String = "ACTUALUNITCOST"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Priceunits As String = "Priceunits"
			 Public Const Priceuom As String = "Priceuom"
			 Public Const Unitprice As String = "Unitprice"
			 Public Const Standardcostunits As String = "Standardcostunits"
			 Public Const Standardcostuom As String = "Standardcostuom"
			 Public Const Standardunitcost As String = "Standardunitcost"
			 Public Const Actualcostunits As String = "Actualcostunits"
			 Public Const Actualcostuom As String = "Actualcostuom"
			 Public Const Actualunitcost As String = "Actualunitcost"
			 Public Const Productid As String = "Productid"
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
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
            SyncLock GetType(ViewWorkOrderItemPricingMetadata)
			
				If ViewWorkOrderItemPricingMetadata.mapDelegates Is Nothing Then
					ViewWorkOrderItemPricingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrderItemPricingMetadata._meta Is Nothing Then
                    ViewWorkOrderItemPricingMetadata._meta = New ViewWorkOrderItemPricingMetadata()
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
				

				meta.AddTypeMap("Priceunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Priceuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Standardunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Actualcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Actualcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Actualunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "ViewWorkOrderItemPricing"
				meta.Destination = "ViewWorkOrderItemPricing"
				
				meta.spInsert = "proc_ViewWorkOrderItemPricingInsert"
				meta.spUpdate = "proc_ViewWorkOrderItemPricingUpdate"
				meta.spDelete = "proc_ViewWorkOrderItemPricingDelete"
				meta.spLoadAll = "proc_ViewWorkOrderItemPricingLoadAll"
				meta.spLoadByPrimaryKey = "proc_ViewWorkOrderItemPricingLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrderItemPricingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
