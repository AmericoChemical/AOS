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
	MustInherit Public Class esViewCustomerPaymentInfoCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCustomerPaymentInfoCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCustomerPaymentInfoQuery)
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
            Me.InitQuery(CType(query, esViewCustomerPaymentInfoQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCustomerPaymentInfo) As ViewCustomerPaymentInfo
			Return CType(MyBase.DetachEntity(entity), ViewCustomerPaymentInfo)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCustomerPaymentInfo) As ViewCustomerPaymentInfo
			Return CType(MyBase.AttachEntity(entity), ViewCustomerPaymentInfo)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCustomerPaymentInfoCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCustomerPaymentInfo
            Get
                Return TryCast(MyBase.Item(index), ViewCustomerPaymentInfo)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCustomerPaymentInfo)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCustomerPaymentInfo	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCustomerPaymentInfoQuery
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
												
						Case "Customerpmtid"
							Me.str.Customerpmtid = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Paymentdate"
							Me.str.Paymentdate = CType(value, string)
												
						Case "Paymentamount"
							Me.str.Paymentamount = CType(value, string)
												
						Case "Remittanceadvice"
							Me.str.Remittanceadvice = CType(value, string)
												
						Case "Balance"
							Me.str.Balance = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Invoicepmtamount"
							Me.str.Invoicepmtamount = CType(value, string)
												
						Case "Invoicedate"
							Me.str.Invoicedate = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Subtotal"
							Me.str.Subtotal = CType(value, string)
												
						Case "Salestax"
							Me.str.Salestax = CType(value, string)
												
						Case "Total"
							Me.str.Total = CType(value, string)
												
						Case "Invnumview"
							Me.str.Invnumview = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Customerpmtid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Customerpmtid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Paymentdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Paymentdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Paymentamount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Paymentamount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Balance"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Balance = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicepmtamount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Invoicepmtamount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Invoicedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Invoicedate = CType(value, Nullable(Of System.DateTime))
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
						
						Case "Invnumview"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invnumview = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCustomerPaymentInfo.CUSTOMERPMTID
		' </summary>
		Public Overridable Property Customerpmtid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerPaymentInfoMetadata.ColumnNames.Customerpmtid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerPaymentInfoMetadata.ColumnNames.Customerpmtid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerPaymentInfoMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerPaymentInfoMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.PAYMENTDATE
		' </summary>
		Public Overridable Property Paymentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCustomerPaymentInfoMetadata.ColumnNames.Paymentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCustomerPaymentInfoMetadata.ColumnNames.Paymentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.PAYMENTAMOUNT
		' </summary>
		Public Overridable Property Paymentamount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Paymentamount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Paymentamount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.REMITTANCEADVICE
		' </summary>
		Public Overridable Property Remittanceadvice As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPaymentInfoMetadata.ColumnNames.Remittanceadvice)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPaymentInfoMetadata.ColumnNames.Remittanceadvice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.BALANCE
		' </summary>
		Public Overridable Property Balance As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Balance)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Balance, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPaymentInfoMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPaymentInfoMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.INVOICEPMTAMOUNT
		' </summary>
		Public Overridable Property Invoicepmtamount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicepmtamount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicepmtamount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.INVOICEDATE
		' </summary>
		Public Overridable Property Invoicedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerPaymentInfoMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerPaymentInfoMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.SALESTAX
		' </summary>
		Public Overridable Property Salestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Salestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Salestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.TOTAL
		' </summary>
		Public Overridable Property Total As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Total)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerPaymentInfoMetadata.ColumnNames.Total, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerPaymentInfo.INVNUMVIEW
		' </summary>
		Public Overridable Property Invnumview As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerPaymentInfoMetadata.ColumnNames.Invnumview)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerPaymentInfoMetadata.ColumnNames.Invnumview, value)
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
		
			Public Sub New(ByVal entity As esViewCustomerPaymentInfo)
				Me.entity = entity
			End Sub				
		
	
			Public Property Customerpmtid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Customerpmtid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerpmtid = Nothing
					Else
						entity.Customerpmtid = Convert.ToInt32(Value)
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
		  	
			Public Property Paymentdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Paymentdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Paymentdate = Nothing
					Else
						entity.Paymentdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Paymentamount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Paymentamount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Paymentamount = Nothing
					Else
						entity.Paymentamount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Remittanceadvice As System.String 
				Get
					Dim data_ As System.String = entity.Remittanceadvice
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Remittanceadvice = Nothing
					Else
						entity.Remittanceadvice = Convert.ToString(Value)
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
		  	
			Public Property Invoicepmtamount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Invoicepmtamount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicepmtamount = Nothing
					Else
						entity.Invoicepmtamount = Convert.ToDecimal(Value)
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
		  	
			Public Property Invnumview As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invnumview
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invnumview = Nothing
					Else
						entity.Invnumview = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCustomerPaymentInfo
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCustomerPaymentInfoQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCustomerPaymentInfo can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCustomerPaymentInfoQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerPaymentInfoMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Customerpmtid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Customerpmtid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Paymentdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Paymentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Paymentamount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Paymentamount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Remittanceadvice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Remittanceadvice, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Balance As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Balance, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicepmtamount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicepmtamount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Salestax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Salestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Total As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Total, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invnumview As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerPaymentInfoMetadata.ColumnNames.Invnumview, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCustomerPaymentInfoCollection")> _
	Partial Public Class ViewCustomerPaymentInfoCollection
		Inherits esViewCustomerPaymentInfoCollection
		Implements IEnumerable(Of ViewCustomerPaymentInfo)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCustomerPaymentInfoCollection) As List(Of ViewCustomerPaymentInfo)
            Dim list As List(Of ViewCustomerPaymentInfo) = New List(Of ViewCustomerPaymentInfo)
            Dim emp As ViewCustomerPaymentInfo

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerPaymentInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerPaymentInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCustomerPaymentInfo(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCustomerPaymentInfo()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCustomerPaymentInfoQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCustomerPaymentInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerPaymentInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCustomerPaymentInfo 
			Return CType(MyBase.AddNewEntity(), ViewCustomerPaymentInfo)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCustomerPaymentInfo) Implements IEnumerable(Of ViewCustomerPaymentInfo).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCustomerPaymentInfo)(Me)
        End Function
		
		Private _query As ViewCustomerPaymentInfoQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCustomerPaymentInfo' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCustomerPaymentInfo ()")> _
	<Serializable> _
	Partial Public Class ViewCustomerPaymentInfo 
		Inherits esViewCustomerPaymentInfo

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCustomerPaymentInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCustomerPaymentInfoQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerPaymentInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCustomerPaymentInfoQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCustomerPaymentInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerPaymentInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCustomerPaymentInfoQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCustomerPaymentInfoQuery
		inherits esViewCustomerPaymentInfoQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCustomerPaymentInfoQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCustomerPaymentInfoMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Customerpmtid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Customerpmtid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Custid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Paymentdate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Paymentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Paymentamount, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Paymentamount
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Remittanceadvice, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Remittanceadvice
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Balance, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Balance
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Custname, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicenumber, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicepmtamount, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Invoicepmtamount
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Invoicedate, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Invoicedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Customerpo, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Subtotal, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Subtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Salestax, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Salestax
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Total, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Total
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerPaymentInfoMetadata.ColumnNames.Invnumview, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerPaymentInfoMetadata.PropertyNames.Invnumview
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCustomerPaymentInfoMetadata
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
			 Public Const Customerpmtid As String = "CUSTOMERPMTID"
			 Public Const Custid As String = "CUSTID"
			 Public Const Paymentdate As String = "PAYMENTDATE"
			 Public Const Paymentamount As String = "PAYMENTAMOUNT"
			 Public Const Remittanceadvice As String = "REMITTANCEADVICE"
			 Public Const Balance As String = "BALANCE"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Invoicepmtamount As String = "INVOICEPMTAMOUNT"
			 Public Const Invoicedate As String = "INVOICEDATE"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Subtotal As String = "SUBTOTAL"
			 Public Const Salestax As String = "SALESTAX"
			 Public Const Total As String = "TOTAL"
			 Public Const Invnumview As String = "INVNUMVIEW"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Customerpmtid As String = "Customerpmtid"
			 Public Const Custid As String = "Custid"
			 Public Const Paymentdate As String = "Paymentdate"
			 Public Const Paymentamount As String = "Paymentamount"
			 Public Const Remittanceadvice As String = "Remittanceadvice"
			 Public Const Balance As String = "Balance"
			 Public Const Custname As String = "Custname"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Invoicepmtamount As String = "Invoicepmtamount"
			 Public Const Invoicedate As String = "Invoicedate"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Subtotal As String = "Subtotal"
			 Public Const Salestax As String = "Salestax"
			 Public Const Total As String = "Total"
			 Public Const Invnumview As String = "Invnumview"
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
            SyncLock GetType(ViewCustomerPaymentInfoMetadata)
			
				If ViewCustomerPaymentInfoMetadata.mapDelegates Is Nothing Then
					ViewCustomerPaymentInfoMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCustomerPaymentInfoMetadata._meta Is Nothing Then
                    ViewCustomerPaymentInfoMetadata._meta = New ViewCustomerPaymentInfoMetadata()
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
				

				meta.AddTypeMap("Customerpmtid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Paymentdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Paymentamount", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Remittanceadvice", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Balance", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicepmtamount", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Invoicedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Subtotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Salestax", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Total", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Invnumview", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCustomerPaymentInfo"
				meta.Destination = "viewCustomerPaymentInfo"
				
				meta.spInsert = "proc_viewCustomerPaymentInfoInsert"
				meta.spUpdate = "proc_viewCustomerPaymentInfoUpdate"
				meta.spDelete = "proc_viewCustomerPaymentInfoDelete"
				meta.spLoadAll = "proc_viewCustomerPaymentInfoLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCustomerPaymentInfoLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCustomerPaymentInfoMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
