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
	MustInherit Public Class esViewCustomerPriceListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCustomerPriceListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCustomerPriceListQuery)
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
            Me.InitQuery(CType(query, esViewCustomerPriceListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCustomerPriceList) As ViewCustomerPriceList
			Return CType(MyBase.DetachEntity(entity), ViewCustomerPriceList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCustomerPriceList) As ViewCustomerPriceList
			Return CType(MyBase.AttachEntity(entity), ViewCustomerPriceList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCustomerPriceListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCustomerPriceList
            Get
                Return TryCast(MyBase.Item(index), ViewCustomerPriceList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCustomerPriceList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCustomerPriceList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCustomerPriceListQuery
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
												
						Case "Custshipcity"
							Me.str.Custshipcity = CType(value, string)
												
						Case "Custshipstateprov"
							Me.str.Custshipstateprov = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Unitprice"
							Me.str.Unitprice = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Effectivedate"
							Me.str.Effectivedate = CType(value, string)
												
						Case "Taxable"
							Me.str.Taxable = CType(value, string)
												
						Case "Containerprice"
							Me.str.Containerprice = CType(value, string)
												
						Case "Customerproductcode"
							Me.str.Customerproductcode = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Units = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Effectivedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Effectivedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Taxable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Taxable = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Containerprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Containerprice = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewCustomerPriceList.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerPriceListMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerPriceListMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.CUSTSHIPCITY
		' </summary>
		Public Overridable Property Custshipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Custshipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Custshipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.CUSTSHIPSTATEPROV
		' </summary>
		Public Overridable Property Custshipstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Custshipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Custshipstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerPriceListMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerPriceListMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerPriceListMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerPriceListMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.UNITPRICE
		' </summary>
		Public Overridable Property Unitprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerPriceListMetadata.ColumnNames.Unitprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerPriceListMetadata.ColumnNames.Unitprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.EFFECTIVEDATE
		' </summary>
		Public Overridable Property Effectivedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCustomerPriceListMetadata.ColumnNames.Effectivedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCustomerPriceListMetadata.ColumnNames.Effectivedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.TAXABLE
		' </summary>
		Public Overridable Property Taxable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCustomerPriceListMetadata.ColumnNames.Taxable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewCustomerPriceListMetadata.ColumnNames.Taxable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.CONTAINERPRICE
		' </summary>
		Public Overridable Property Containerprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerPriceListMetadata.ColumnNames.Containerprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerPriceListMetadata.ColumnNames.Containerprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPriceList.CUSTOMERPRODUCTCODE
		' </summary>
		Public Overridable Property Customerproductcode As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Customerproductcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPriceListMetadata.ColumnNames.Customerproductcode, value)
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
		
			Public Sub New(ByVal entity As esViewCustomerPriceList)
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
		  	
			Public Property Custshipcity As System.String 
				Get
					Dim data_ As System.String = entity.Custshipcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipcity = Nothing
					Else
						entity.Custshipcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshipstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Custshipstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipstateprov = Nothing
					Else
						entity.Custshipstateprov = Convert.ToString(Value)
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
		  	
			Public Property Unitorcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Unitorcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitorcontainer = Nothing
					Else
						entity.Unitorcontainer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Effectivedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Effectivedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Effectivedate = Nothing
					Else
						entity.Effectivedate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Taxable As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Taxable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Taxable = Nothing
					Else
						entity.Taxable = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Containerprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Containerprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Containerprice = Nothing
					Else
						entity.Containerprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Customerproductcode As System.String 
				Get
					Dim data_ As System.String = entity.Customerproductcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerproductcode = Nothing
					Else
						entity.Customerproductcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCustomerPriceList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCustomerPriceListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCustomerPriceList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCustomerPriceListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerPriceListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Custshipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Custshipstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Units, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Unitprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Effectivedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Effectivedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Taxable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Taxable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Containerprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Containerprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Customerproductcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPriceListMetadata.ColumnNames.Customerproductcode, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCustomerPriceListCollection")> _
	Partial Public Class ViewCustomerPriceListCollection
		Inherits esViewCustomerPriceListCollection
		Implements IEnumerable(Of ViewCustomerPriceList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCustomerPriceListCollection) As List(Of ViewCustomerPriceList)
            Dim list As List(Of ViewCustomerPriceList) = New List(Of ViewCustomerPriceList)
            Dim emp As ViewCustomerPriceList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerPriceListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerPriceListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCustomerPriceList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCustomerPriceList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCustomerPriceListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCustomerPriceListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerPriceListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCustomerPriceList 
			Return CType(MyBase.AddNewEntity(), ViewCustomerPriceList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCustomerPriceList) Implements IEnumerable(Of ViewCustomerPriceList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCustomerPriceList)(Me)
        End Function
		
		Private _query As ViewCustomerPriceListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCustomerPriceList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCustomerPriceList ()")> _
	<Serializable> _
	Partial Public Class ViewCustomerPriceList 
		Inherits esViewCustomerPriceList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCustomerPriceListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCustomerPriceListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerPriceListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCustomerPriceListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCustomerPriceListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerPriceListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCustomerPriceListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCustomerPriceListQuery
		inherits esViewCustomerPriceListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCustomerPriceListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCustomerPriceListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Custid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Custname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Custshipcity, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Custshipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Custshipstateprov, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Custshipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Productid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Productdesc, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Container, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Units, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Units
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Unitprice, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Unitprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Uom, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Unitorcontainer, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Effectivedate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Effectivedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Taxable, 12, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Taxable
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Containerprice, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Containerprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPriceListMetadata.ColumnNames.Customerproductcode, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPriceListMetadata.PropertyNames.Customerproductcode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCustomerPriceListMetadata
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
			 Public Const Custshipcity As String = "CUSTSHIPCITY"
			 Public Const Custshipstateprov As String = "CUSTSHIPSTATEPROV"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Unitprice As String = "UNITPRICE"
			 Public Const Uom As String = "UOM"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Effectivedate As String = "EFFECTIVEDATE"
			 Public Const Taxable As String = "TAXABLE"
			 Public Const Containerprice As String = "CONTAINERPRICE"
			 Public Const Customerproductcode As String = "CUSTOMERPRODUCTCODE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Custshipcity As String = "Custshipcity"
			 Public Const Custshipstateprov As String = "Custshipstateprov"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Units As String = "Units"
			 Public Const Unitprice As String = "Unitprice"
			 Public Const Uom As String = "Uom"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Effectivedate As String = "Effectivedate"
			 Public Const Taxable As String = "Taxable"
			 Public Const Containerprice As String = "Containerprice"
			 Public Const Customerproductcode As String = "Customerproductcode"
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
            SyncLock GetType(ViewCustomerPriceListMetadata)
			
				If ViewCustomerPriceListMetadata.mapDelegates Is Nothing Then
					ViewCustomerPriceListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCustomerPriceListMetadata._meta Is Nothing Then
                    ViewCustomerPriceListMetadata._meta = New ViewCustomerPriceListMetadata()
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
				meta.AddTypeMap("Custshipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Effectivedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Taxable", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Containerprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Customerproductcode", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCustomerPriceList"
				meta.Destination = "viewCustomerPriceList"
				
				meta.spInsert = "proc_viewCustomerPriceListInsert"
				meta.spUpdate = "proc_viewCustomerPriceListUpdate"
				meta.spDelete = "proc_viewCustomerPriceListDelete"
				meta.spLoadAll = "proc_viewCustomerPriceListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCustomerPriceListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCustomerPriceListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
