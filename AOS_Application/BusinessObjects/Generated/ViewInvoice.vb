'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/4/2016 3:01:17 PM
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
	MustInherit Public Class esViewInvoiceCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewInvoiceCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewInvoiceQuery)
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
            Me.InitQuery(CType(query, esViewInvoiceQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewInvoice) As ViewInvoice
			Return CType(MyBase.DetachEntity(entity), ViewInvoice)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewInvoice) As ViewInvoice
			Return CType(MyBase.AttachEntity(entity), ViewInvoice)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewInvoiceCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewInvoice
            Get
                Return TryCast(MyBase.Item(index), ViewInvoice)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewInvoice)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewInvoice	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewInvoiceQuery
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
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Invoicedate"
							Me.str.Invoicedate = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Shipcity"
							Me.str.Shipcity = CType(value, string)
												
						Case "Shipstateprov"
							Me.str.Shipstateprov = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
												
						Case "Subtotal"
							Me.str.Subtotal = CType(value, string)
												
						Case "Salestax"
							Me.str.Salestax = CType(value, string)
												
						Case "Total"
							Me.str.Total = CType(value, string)
												
						Case "Invoicestatus"
							Me.str.Invoicestatus = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Invoicedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Subtotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Subtotal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Salestax"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Salestax = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Total"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Total = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewInvoice.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvoiceMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvoiceMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.INVOICEDATE
		' </summary>
		Public Overridable Property Invoicedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvoiceMetadata.ColumnNames.Invoicedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvoiceMetadata.ColumnNames.Invoicedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvoiceMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvoiceMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.SHIPCITY
		' </summary>
		Public Overridable Property Shipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewInvoiceMetadata.ColumnNames.Shipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvoiceMetadata.ColumnNames.Shipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.SHIPSTATEPROV
		' </summary>
		Public Overridable Property Shipstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewInvoiceMetadata.ColumnNames.Shipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvoiceMetadata.ColumnNames.Shipstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewInvoiceMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvoiceMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvoiceMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvoiceMetadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInvoiceMetadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInvoiceMetadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.SALESTAX
		' </summary>
		Public Overridable Property Salestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInvoiceMetadata.ColumnNames.Salestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInvoiceMetadata.ColumnNames.Salestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.TOTAL
		' </summary>
		Public Overridable Property Total As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInvoiceMetadata.ColumnNames.Total)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInvoiceMetadata.ColumnNames.Total, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.INVOICESTATUS
		' </summary>
		Public Overridable Property Invoicestatus As System.String
			Get
				Return MyBase.GetSystemString(ViewInvoiceMetadata.ColumnNames.Invoicestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvoiceMetadata.ColumnNames.Invoicestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ViewInvoiceMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvoiceMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvoiceMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvoiceMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvoice.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewInvoiceMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvoiceMetadata.ColumnNames.Custname, value)
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
		
			Public Sub New(ByVal entity As esViewInvoice)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Shipcity As System.String 
				Get
					Dim data_ As System.String = entity.Shipcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipcity = Nothing
					Else
						entity.Shipcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Shipstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipstateprov = Nothing
					Else
						entity.Shipstateprov = Convert.ToString(Value)
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
		  	
			Public Property Deliverydate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Deliverydate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Deliverydate = Nothing
					Else
						entity.Deliverydate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Subtotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Subtotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Subtotal = Nothing
					Else
						entity.Subtotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salestax As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Salestax
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salestax = Nothing
					Else
						entity.Salestax = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Total As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Total
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Total = Nothing
					Else
						entity.Total = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invoicestatus As System.String 
				Get
					Dim data_ As System.String = entity.Invoicestatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicestatus = Nothing
					Else
						entity.Invoicestatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifyby As System.String 
				Get
					Dim data_ As System.String = entity.Modifyby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifyby = Nothing
					Else
						entity.Modifyby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifytime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifytime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifytime = Nothing
					Else
						entity.Modifytime = Convert.ToDateTime(Value)
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
		  

			Private entity As esViewInvoice
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewInvoiceQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewInvoice can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewInvoiceQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvoiceMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Invoicedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Shipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Shipstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Salestax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Salestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Total As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Total, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicestatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Invoicestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvoiceMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewInvoiceCollection")> _
	Partial Public Class ViewInvoiceCollection
		Inherits esViewInvoiceCollection
		Implements IEnumerable(Of ViewInvoice)
		
        Public Shared Widening Operator CType(ByVal coll As ViewInvoiceCollection) As List(Of ViewInvoice)
            Dim list As List(Of ViewInvoice) = New List(Of ViewInvoice)
            Dim emp As ViewInvoice

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvoiceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewInvoiceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewInvoice(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewInvoice()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewInvoiceQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewInvoiceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvoiceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewInvoice 
			Return CType(MyBase.AddNewEntity(), ViewInvoice)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewInvoice) Implements IEnumerable(Of ViewInvoice).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewInvoice)(Me)
        End Function
		
		Private _query As ViewInvoiceQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewInvoice' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewInvoice ()")> _
	<Serializable> _
	Partial Public Class ViewInvoice 
		Inherits esViewInvoice

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewInvoiceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewInvoiceQuery

			If Me._query Is Nothing Then
				Me._query = New ViewInvoiceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewInvoiceQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewInvoiceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvoiceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewInvoiceQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewInvoiceQuery
		inherits esViewInvoiceQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewInvoiceQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewInvoiceMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Invoicenumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Invoicedate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Invoicedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Custid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Shipcity, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Shipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Shipstateprov, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Shipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Customerpo, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Deliverydate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Subtotal, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Subtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Salestax, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Salestax
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Total, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Total
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Invoicestatus, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Invoicestatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Modifyby, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Modifytime, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvoiceMetadata.ColumnNames.Custname, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvoiceMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewInvoiceMetadata
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
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Invoicedate As String = "INVOICEDATE"
			 Public Const Custid As String = "CUSTID"
			 Public Const Shipcity As String = "SHIPCITY"
			 Public Const Shipstateprov As String = "SHIPSTATEPROV"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Deliverydate As String = "DELIVERYDATE"
			 Public Const Subtotal As String = "SUBTOTAL"
			 Public Const Salestax As String = "SALESTAX"
			 Public Const Total As String = "TOTAL"
			 Public Const Invoicestatus As String = "INVOICESTATUS"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Custname As String = "CUSTNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Invoicedate As String = "Invoicedate"
			 Public Const Custid As String = "Custid"
			 Public Const Shipcity As String = "Shipcity"
			 Public Const Shipstateprov As String = "Shipstateprov"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Deliverydate As String = "Deliverydate"
			 Public Const Subtotal As String = "Subtotal"
			 Public Const Salestax As String = "Salestax"
			 Public Const Total As String = "Total"
			 Public Const Invoicestatus As String = "Invoicestatus"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Custname As String = "Custname"
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
            SyncLock GetType(ViewInvoiceMetadata)
			
				If ViewInvoiceMetadata.mapDelegates Is Nothing Then
					ViewInvoiceMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewInvoiceMetadata._meta Is Nothing Then
                    ViewInvoiceMetadata._meta = New ViewInvoiceMetadata()
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
				

				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Subtotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Salestax", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Total", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Invoicestatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewInvoice"
				meta.Destination = "viewInvoice"
				
				meta.spInsert = "proc_viewInvoiceInsert"
				meta.spUpdate = "proc_viewInvoiceUpdate"
				meta.spDelete = "proc_viewInvoiceDelete"
				meta.spLoadAll = "proc_viewInvoiceLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewInvoiceLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewInvoiceMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
