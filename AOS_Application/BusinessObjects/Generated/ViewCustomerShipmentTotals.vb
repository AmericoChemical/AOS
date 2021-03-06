'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/15/2017 1:53:39 PM
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
	MustInherit Public Class esViewCustomerShipmentTotalsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCustomerShipmentTotalsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCustomerShipmentTotalsQuery)
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
            Me.InitQuery(CType(query, esViewCustomerShipmentTotalsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCustomerShipmentTotals) As ViewCustomerShipmentTotals
			Return CType(MyBase.DetachEntity(entity), ViewCustomerShipmentTotals)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCustomerShipmentTotals) As ViewCustomerShipmentTotals
			Return CType(MyBase.AttachEntity(entity), ViewCustomerShipmentTotals)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCustomerShipmentTotalsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCustomerShipmentTotals
            Get
                Return TryCast(MyBase.Item(index), ViewCustomerShipmentTotals)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCustomerShipmentTotals)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCustomerShipmentTotals	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCustomerShipmentTotalsQuery
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
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Ordertype"
							Me.str.Ordertype = CType(value, string)
												
						Case "ActualShipmentDate"
							Me.str.ActualShipmentDate = CType(value, string)
												
						Case "PlannedDeliveryDate"
							Me.str.PlannedDeliveryDate = CType(value, string)
												
						Case "LoadType"
							Me.str.LoadType = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ActualShipmentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ActualShipmentDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "PlannedDeliveryDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDeliveryDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Units = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCustomerShipmentTotals.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerShipmentTotalsMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerShipmentTotalsMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerShipmentTotalsMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerShipmentTotalsMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.ORDERTYPE
		' </summary>
		Public Overridable Property Ordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Ordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Ordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.ActualShipmentDate
		' </summary>
		Public Overridable Property ActualShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCustomerShipmentTotalsMetadata.ColumnNames.ActualShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCustomerShipmentTotalsMetadata.ColumnNames.ActualShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.PlannedDeliveryDate
		' </summary>
		Public Overridable Property PlannedDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCustomerShipmentTotalsMetadata.ColumnNames.PlannedDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCustomerShipmentTotalsMetadata.ColumnNames.PlannedDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerShipmentTotalsMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerShipmentTotalsMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerShipmentTotalsMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerShipmentTotalsMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerShipmentTotalsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerShipmentTotalsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerShipmentTotals.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerShipmentTotalsMetadata.ColumnNames.Productdesc, value)
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
		
			Public Sub New(ByVal entity As esViewCustomerShipmentTotals)
				Me.entity = entity
			End Sub				
		
	
			Public Property Custid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Custid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custid = Nothing
					Else
						entity.Custid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custname As System.String 
				Get
					Dim data_ As System.String = entity.Custname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custname = Nothing
					Else
						entity.Custname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Ordertype As System.String 
				Get
					Dim data_ As System.String = entity.Ordertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ordertype = Nothing
					Else
						entity.Ordertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualShipmentDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ActualShipmentDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualShipmentDate = Nothing
					Else
						entity.ActualShipmentDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlannedDeliveryDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PlannedDeliveryDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlannedDeliveryDate = Nothing
					Else
						entity.PlannedDeliveryDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadType As System.String 
				Get
					Dim data_ As System.String = entity.LoadType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadType = Nothing
					Else
						entity.LoadType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qty
					
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
						entity.Qty = Convert.ToInt32(Value)
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
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Units
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Units = Nothing
					Else
						entity.Units = Convert.ToDecimal(Value)
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
		  

			Private entity As esViewCustomerShipmentTotals
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCustomerShipmentTotalsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCustomerShipmentTotals can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCustomerShipmentTotalsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerShipmentTotalsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Ordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Ordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.ActualShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.PlannedDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Qty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Units, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerShipmentTotalsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCustomerShipmentTotalsCollection")> _
	Partial Public Class ViewCustomerShipmentTotalsCollection
		Inherits esViewCustomerShipmentTotalsCollection
		Implements IEnumerable(Of ViewCustomerShipmentTotals)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCustomerShipmentTotalsCollection) As List(Of ViewCustomerShipmentTotals)
            Dim list As List(Of ViewCustomerShipmentTotals) = New List(Of ViewCustomerShipmentTotals)
            Dim emp As ViewCustomerShipmentTotals

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerShipmentTotalsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerShipmentTotalsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCustomerShipmentTotals(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCustomerShipmentTotals()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCustomerShipmentTotalsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCustomerShipmentTotalsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerShipmentTotalsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCustomerShipmentTotals 
			Return CType(MyBase.AddNewEntity(), ViewCustomerShipmentTotals)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCustomerShipmentTotals) Implements IEnumerable(Of ViewCustomerShipmentTotals).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCustomerShipmentTotals)(Me)
        End Function
		
		Private _query As ViewCustomerShipmentTotalsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCustomerShipmentTotals' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCustomerShipmentTotals ()")> _
	<Serializable> _
	Partial Public Class ViewCustomerShipmentTotals 
		Inherits esViewCustomerShipmentTotals

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCustomerShipmentTotalsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCustomerShipmentTotalsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerShipmentTotalsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCustomerShipmentTotalsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCustomerShipmentTotalsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerShipmentTotalsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCustomerShipmentTotalsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCustomerShipmentTotalsQuery
		inherits esViewCustomerShipmentTotalsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCustomerShipmentTotalsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCustomerShipmentTotalsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Custid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Custname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Workordernumber, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Ordertype, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Ordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.ActualShipmentDate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.ActualShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.PlannedDeliveryDate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.PlannedDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.LoadType, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Qty, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Qty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Container, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Units, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Units
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Uom, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Productid, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerShipmentTotalsMetadata.ColumnNames.Productdesc, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerShipmentTotalsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCustomerShipmentTotalsMetadata
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
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Ordertype As String = "ORDERTYPE"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const LoadType As String = "LoadType"
			 Public Const Qty As String = "QTY"
			 Public Const Container As String = "CONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Ordertype As String = "Ordertype"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const LoadType As String = "LoadType"
			 Public Const Qty As String = "Qty"
			 Public Const Container As String = "Container"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
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
            SyncLock GetType(ViewCustomerShipmentTotalsMetadata)
			
				If ViewCustomerShipmentTotalsMetadata.mapDelegates Is Nothing Then
					ViewCustomerShipmentTotalsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCustomerShipmentTotalsMetadata._meta Is Nothing Then
                    ViewCustomerShipmentTotalsMetadata._meta = New ViewCustomerShipmentTotalsMetadata()
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
				

				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Ordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ActualShipmentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("PlannedDeliveryDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LoadType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCustomerShipmentTotals"
				meta.Destination = "viewCustomerShipmentTotals"
				
				meta.spInsert = "proc_viewCustomerShipmentTotalsInsert"
				meta.spUpdate = "proc_viewCustomerShipmentTotalsUpdate"
				meta.spDelete = "proc_viewCustomerShipmentTotalsDelete"
				meta.spLoadAll = "proc_viewCustomerShipmentTotalsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCustomerShipmentTotalsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCustomerShipmentTotalsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
