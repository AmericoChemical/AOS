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
	MustInherit Public Class esViewCustomerInvoicedItemsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCustomerInvoicedItemsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCustomerInvoicedItemsQuery)
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
            Me.InitQuery(CType(query, esViewCustomerInvoicedItemsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCustomerInvoicedItems) As ViewCustomerInvoicedItems
			Return CType(MyBase.DetachEntity(entity), ViewCustomerInvoicedItems)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCustomerInvoicedItems) As ViewCustomerInvoicedItems
			Return CType(MyBase.AttachEntity(entity), ViewCustomerInvoicedItems)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCustomerInvoicedItemsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCustomerInvoicedItems
            Get
                Return TryCast(MyBase.Item(index), ViewCustomerInvoicedItems)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCustomerInvoicedItems)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCustomerInvoicedItems	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCustomerInvoicedItemsQuery
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
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Invoicedate"
							Me.str.Invoicedate = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Quantity"
							Me.str.Quantity = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Itemprice"
							Me.str.Itemprice = CType(value, string)
												
						Case "Extprice"
							Me.str.Extprice = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Extcost"
							Me.str.Extcost = CType(value, string)
												
						Case "Grossprofit"
							Me.str.Grossprofit = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Invoicedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Quantity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Quantity = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Itemprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Itemprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Grossprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Grossprofit = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewCustomerInvoicedItems.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.INVOICEDATE
		' </summary>
		Public Overridable Property Invoicedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCustomerInvoicedItemsMetadata.ColumnNames.Invoicedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCustomerInvoicedItemsMetadata.ColumnNames.Invoicedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.QUANTITY
		' </summary>
		Public Overridable Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Quantity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Quantity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerInvoicedItemsMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.ITEMPRICE
		' </summary>
		Public Overridable Property Itemprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Itemprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Itemprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.EXTPRICE
		' </summary>
		Public Overridable Property Extprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Extprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Extprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.EXTCOST
		' </summary>
		Public Overridable Property Extcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Extcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Extcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.GROSSPROFIT
		' </summary>
		Public Overridable Property Grossprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Grossprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerInvoicedItemsMetadata.ColumnNames.Grossprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerInvoicedItems.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerInvoicedItemsMetadata.ColumnNames.Unitorcontainer, value)
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
		
			Public Sub New(ByVal entity As esViewCustomerInvoicedItems)
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
		  	
			Public Property Invoicenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoicenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicenumber = Nothing
					Else
						entity.Invoicenumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invoicedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Invoicedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicedate = Nothing
					Else
						entity.Invoicedate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Customerpo As System.String 
				Get
					Dim data_ As System.String = entity.Customerpo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerpo = Nothing
					Else
						entity.Customerpo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Quantity As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Quantity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Quantity = Nothing
					Else
						entity.Quantity = Convert.ToDecimal(Value)
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
					Dim data_ As Nullable(Of System.Int32) = entity.Units
					
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
						entity.Units = Convert.ToInt32(Value)
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
		  	
			Public Property Itemprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Itemprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemprice = Nothing
					Else
						entity.Itemprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Extprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extprice = Nothing
					Else
						entity.Extprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitcost = Nothing
					Else
						entity.Unitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Extcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extcost = Nothing
					Else
						entity.Extcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Grossprofit As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Grossprofit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Grossprofit = Nothing
					Else
						entity.Grossprofit = Convert.ToDecimal(Value)
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
		  

			Private entity As esViewCustomerInvoicedItems
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCustomerInvoicedItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCustomerInvoicedItems can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCustomerInvoicedItemsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerInvoicedItemsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Invoicedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Quantity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Quantity, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Itemprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Extprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Extcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Grossprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Grossprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerInvoicedItemsMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCustomerInvoicedItemsCollection")> _
	Partial Public Class ViewCustomerInvoicedItemsCollection
		Inherits esViewCustomerInvoicedItemsCollection
		Implements IEnumerable(Of ViewCustomerInvoicedItems)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCustomerInvoicedItemsCollection) As List(Of ViewCustomerInvoicedItems)
            Dim list As List(Of ViewCustomerInvoicedItems) = New List(Of ViewCustomerInvoicedItems)
            Dim emp As ViewCustomerInvoicedItems

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerInvoicedItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerInvoicedItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCustomerInvoicedItems(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCustomerInvoicedItems()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCustomerInvoicedItemsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCustomerInvoicedItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerInvoicedItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCustomerInvoicedItems 
			Return CType(MyBase.AddNewEntity(), ViewCustomerInvoicedItems)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCustomerInvoicedItems) Implements IEnumerable(Of ViewCustomerInvoicedItems).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCustomerInvoicedItems)(Me)
        End Function
		
		Private _query As ViewCustomerInvoicedItemsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCustomerInvoicedItems' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCustomerInvoicedItems ()")> _
	<Serializable> _
	Partial Public Class ViewCustomerInvoicedItems 
		Inherits esViewCustomerInvoicedItems

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCustomerInvoicedItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCustomerInvoicedItemsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerInvoicedItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCustomerInvoicedItemsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCustomerInvoicedItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerInvoicedItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCustomerInvoicedItemsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCustomerInvoicedItemsQuery
		inherits esViewCustomerInvoicedItemsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCustomerInvoicedItemsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCustomerInvoicedItemsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Custid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Custname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Invoicenumber, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Invoicedate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Invoicedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Customerpo, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Invitemnumber, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Productid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Productdesc, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Quantity, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Quantity
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Container, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Units, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Uom, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Itemprice, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Itemprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Extprice, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Extprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Unitcost, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Extcost, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Extcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Grossprofit, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Grossprofit
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerInvoicedItemsMetadata.ColumnNames.Unitorcontainer, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerInvoicedItemsMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCustomerInvoicedItemsMetadata
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
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Invoicedate As String = "INVOICEDATE"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Quantity As String = "QUANTITY"
			 Public Const Container As String = "CONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Itemprice As String = "ITEMPRICE"
			 Public Const Extprice As String = "EXTPRICE"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Extcost As String = "EXTCOST"
			 Public Const Grossprofit As String = "GROSSPROFIT"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Invoicedate As String = "Invoicedate"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Quantity As String = "Quantity"
			 Public Const Container As String = "Container"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Itemprice As String = "Itemprice"
			 Public Const Extprice As String = "Extprice"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Extcost As String = "Extcost"
			 Public Const Grossprofit As String = "Grossprofit"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
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
            SyncLock GetType(ViewCustomerInvoicedItemsMetadata)
			
				If ViewCustomerInvoicedItemsMetadata.mapDelegates Is Nothing Then
					ViewCustomerInvoicedItemsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCustomerInvoicedItemsMetadata._meta Is Nothing Then
                    ViewCustomerInvoicedItemsMetadata._meta = New ViewCustomerInvoicedItemsMetadata()
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
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Quantity", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Extprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Extcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Grossprofit", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCustomerInvoicedItems"
				meta.Destination = "viewCustomerInvoicedItems"
				
				meta.spInsert = "proc_viewCustomerInvoicedItemsInsert"
				meta.spUpdate = "proc_viewCustomerInvoicedItemsUpdate"
				meta.spDelete = "proc_viewCustomerInvoicedItemsDelete"
				meta.spLoadAll = "proc_viewCustomerInvoicedItemsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCustomerInvoicedItemsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCustomerInvoicedItemsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
