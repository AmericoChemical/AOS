'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/9/2014 4:21:59 PM
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
	MustInherit Public Class esViewOrdersReadyForInvoiceCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewOrdersReadyForInvoiceCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewOrdersReadyForInvoiceQuery)
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
            Me.InitQuery(CType(query, esViewOrdersReadyForInvoiceQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewOrdersReadyForInvoice) As ViewOrdersReadyForInvoice
			Return CType(MyBase.DetachEntity(entity), ViewOrdersReadyForInvoice)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewOrdersReadyForInvoice) As ViewOrdersReadyForInvoice
			Return CType(MyBase.AttachEntity(entity), ViewOrdersReadyForInvoice)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewOrdersReadyForInvoiceCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewOrdersReadyForInvoice
            Get
                Return TryCast(MyBase.Item(index), ViewOrdersReadyForInvoice)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewOrdersReadyForInvoice)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewOrdersReadyForInvoice	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewOrdersReadyForInvoiceQuery
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
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Orderstatus"
							Me.str.Orderstatus = CType(value, string)
												
						Case "Workorderdate"
							Me.str.Workorderdate = CType(value, string)
												
						Case "Billingtype"
							Me.str.Billingtype = CType(value, string)
												
						Case "Transporttype"
							Me.str.Transporttype = CType(value, string)
												
						Case "Ordertype"
							Me.str.Ordertype = CType(value, string)
												
						Case "LoadStatus"
							Me.str.LoadStatus = CType(value, string)
												
						Case "LoadType"
							Me.str.LoadType = CType(value, string)
												
						Case "PlannedDeliveryDate"
							Me.str.PlannedDeliveryDate = CType(value, string)
												
						Case "ActualShipmentDate"
							Me.str.ActualShipmentDate = CType(value, string)
												
						Case "CarrierProNumber"
							Me.str.CarrierProNumber = CType(value, string)
												
						Case "AddToInvoice"
							Me.str.AddToInvoice = CType(value, string)
												
						Case "BillCustomer"
							Me.str.BillCustomer = CType(value, string)
												
						Case "BilledAmount"
							Me.str.BilledAmount = CType(value, string)
												
						Case "BillingDate"
							Me.str.BillingDate = CType(value, string)
												
						Case "InvoiceNumber"
							Me.str.InvoiceNumber = CType(value, string)
												
						Case "Status"
							Me.str.Status = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Workorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "PlannedDeliveryDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDeliveryDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ActualShipmentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ActualShipmentDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "AddToInvoice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.AddToInvoice = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "BillCustomer"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.BillCustomer = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "BilledAmount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BilledAmount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "BillingDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BillingDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "InvoiceNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InvoiceNumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewOrdersReadyForInvoice.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.ORDERSTATUS
		' </summary>
		Public Overridable Property Orderstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Orderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Orderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.BILLINGTYPE
		' </summary>
		Public Overridable Property Billingtype As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Billingtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Billingtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.TRANSPORTTYPE
		' </summary>
		Public Overridable Property Transporttype As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Transporttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Transporttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.ORDERTYPE
		' </summary>
		Public Overridable Property Ordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Ordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Ordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.LoadStatus
		' </summary>
		Public Overridable Property LoadStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.PlannedDeliveryDate
		' </summary>
		Public Overridable Property PlannedDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewOrdersReadyForInvoiceMetadata.ColumnNames.PlannedDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewOrdersReadyForInvoiceMetadata.ColumnNames.PlannedDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.ActualShipmentDate
		' </summary>
		Public Overridable Property ActualShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewOrdersReadyForInvoiceMetadata.ColumnNames.ActualShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewOrdersReadyForInvoiceMetadata.ColumnNames.ActualShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.CarrierProNumber
		' </summary>
		Public Overridable Property CarrierProNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.CarrierProNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.CarrierProNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.AddToInvoice
		' </summary>
		Public Overridable Property AddToInvoice As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewOrdersReadyForInvoiceMetadata.ColumnNames.AddToInvoice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewOrdersReadyForInvoiceMetadata.ColumnNames.AddToInvoice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.BillCustomer
		' </summary>
		Public Overridable Property BillCustomer As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewOrdersReadyForInvoiceMetadata.ColumnNames.BillCustomer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewOrdersReadyForInvoiceMetadata.ColumnNames.BillCustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.BilledAmount
		' </summary>
		Public Overridable Property BilledAmount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewOrdersReadyForInvoiceMetadata.ColumnNames.BilledAmount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewOrdersReadyForInvoiceMetadata.ColumnNames.BilledAmount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.BillingDate
		' </summary>
		Public Overridable Property BillingDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewOrdersReadyForInvoiceMetadata.ColumnNames.BillingDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewOrdersReadyForInvoiceMetadata.ColumnNames.BillingDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.InvoiceNumber
		' </summary>
		Public Overridable Property InvoiceNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewOrdersReadyForInvoiceMetadata.ColumnNames.InvoiceNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewOrdersReadyForInvoiceMetadata.ColumnNames.InvoiceNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.Status
		' </summary>
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Status, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewOrdersReadyForInvoice.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadID, value)
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
		
			Public Sub New(ByVal entity As esViewOrdersReadyForInvoice)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Orderstatus As System.String 
				Get
					Dim data_ As System.String = entity.Orderstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Orderstatus = Nothing
					Else
						entity.Orderstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Workorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Workorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderdate = Nothing
					Else
						entity.Workorderdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billingtype As System.String 
				Get
					Dim data_ As System.String = entity.Billingtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billingtype = Nothing
					Else
						entity.Billingtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Transporttype As System.String 
				Get
					Dim data_ As System.String = entity.Transporttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Transporttype = Nothing
					Else
						entity.Transporttype = Convert.ToString(Value)
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
		  	
			Public Property LoadStatus As System.String 
				Get
					Dim data_ As System.String = entity.LoadStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadStatus = Nothing
					Else
						entity.LoadStatus = Convert.ToString(Value)
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
		  	
			Public Property CarrierProNumber As System.String 
				Get
					Dim data_ As System.String = entity.CarrierProNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierProNumber = Nothing
					Else
						entity.CarrierProNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AddToInvoice As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.AddToInvoice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AddToInvoice = Nothing
					Else
						entity.AddToInvoice = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property BillCustomer As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.BillCustomer
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BillCustomer = Nothing
					Else
						entity.BillCustomer = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property BilledAmount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BilledAmount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BilledAmount = Nothing
					Else
						entity.BilledAmount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BillingDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.BillingDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BillingDate = Nothing
					Else
						entity.BillingDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property InvoiceNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InvoiceNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InvoiceNumber = Nothing
					Else
						entity.InvoiceNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Status As System.String 
				Get
					Dim data_ As System.String = entity.Status
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Status = Nothing
					Else
						entity.Status = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadID = Nothing
					Else
						entity.LoadID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewOrdersReadyForInvoice
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewOrdersReadyForInvoiceQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewOrdersReadyForInvoice can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewOrdersReadyForInvoiceQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewOrdersReadyForInvoiceMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Orderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Billingtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Billingtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Transporttype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Transporttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Ordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.PlannedDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.ActualShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierProNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.CarrierProNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AddToInvoice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.AddToInvoice, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property BillCustomer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.BillCustomer, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property BilledAmount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.BilledAmount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BillingDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.BillingDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property InvoiceNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.InvoiceNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewOrdersReadyForInvoiceCollection")> _
	Partial Public Class ViewOrdersReadyForInvoiceCollection
		Inherits esViewOrdersReadyForInvoiceCollection
		Implements IEnumerable(Of ViewOrdersReadyForInvoice)
		
        Public Shared Widening Operator CType(ByVal coll As ViewOrdersReadyForInvoiceCollection) As List(Of ViewOrdersReadyForInvoice)
            Dim list As List(Of ViewOrdersReadyForInvoice) = New List(Of ViewOrdersReadyForInvoice)
            Dim emp As ViewOrdersReadyForInvoice

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewOrdersReadyForInvoiceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewOrdersReadyForInvoiceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewOrdersReadyForInvoice(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewOrdersReadyForInvoice()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewOrdersReadyForInvoiceQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewOrdersReadyForInvoiceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewOrdersReadyForInvoiceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewOrdersReadyForInvoice 
			Return CType(MyBase.AddNewEntity(), ViewOrdersReadyForInvoice)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewOrdersReadyForInvoice) Implements IEnumerable(Of ViewOrdersReadyForInvoice).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewOrdersReadyForInvoice)(Me)
        End Function
		
		Private _query As ViewOrdersReadyForInvoiceQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewOrdersReadyForInvoice' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewOrdersReadyForInvoice ()")> _
	<Serializable> _
	Partial Public Class ViewOrdersReadyForInvoice 
		Inherits esViewOrdersReadyForInvoice

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewOrdersReadyForInvoiceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewOrdersReadyForInvoiceQuery

			If Me._query Is Nothing Then
				Me._query = New ViewOrdersReadyForInvoiceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewOrdersReadyForInvoiceQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewOrdersReadyForInvoiceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewOrdersReadyForInvoiceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewOrdersReadyForInvoiceQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewOrdersReadyForInvoiceQuery
		inherits esViewOrdersReadyForInvoiceQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewOrdersReadyForInvoiceQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewOrdersReadyForInvoiceMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Custid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Custname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Customerpo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Orderstatus, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Orderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Workorderdate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Billingtype, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Billingtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Transporttype, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Transporttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Ordertype, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Ordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadStatus, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.LoadStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadType, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.PlannedDeliveryDate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.PlannedDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.ActualShipmentDate, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.ActualShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.CarrierProNumber, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.CarrierProNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.AddToInvoice, 14, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.AddToInvoice
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.BillCustomer, 15, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.BillCustomer
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.BilledAmount, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.BilledAmount
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.BillingDate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.BillingDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.InvoiceNumber, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.InvoiceNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.Status, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.Status
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewOrdersReadyForInvoiceMetadata.ColumnNames.LoadID, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewOrdersReadyForInvoiceMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewOrdersReadyForInvoiceMetadata
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
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Orderstatus As String = "ORDERSTATUS"
			 Public Const Workorderdate As String = "WORKORDERDATE"
			 Public Const Billingtype As String = "BILLINGTYPE"
			 Public Const Transporttype As String = "TRANSPORTTYPE"
			 Public Const Ordertype As String = "ORDERTYPE"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const CarrierProNumber As String = "CarrierProNumber"
			 Public Const AddToInvoice As String = "AddToInvoice"
			 Public Const BillCustomer As String = "BillCustomer"
			 Public Const BilledAmount As String = "BilledAmount"
			 Public Const BillingDate As String = "BillingDate"
			 Public Const InvoiceNumber As String = "InvoiceNumber"
			 Public Const Status As String = "Status"
			 Public Const LoadID As String = "LoadID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Orderstatus As String = "Orderstatus"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Billingtype As String = "Billingtype"
			 Public Const Transporttype As String = "Transporttype"
			 Public Const Ordertype As String = "Ordertype"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const CarrierProNumber As String = "CarrierProNumber"
			 Public Const AddToInvoice As String = "AddToInvoice"
			 Public Const BillCustomer As String = "BillCustomer"
			 Public Const BilledAmount As String = "BilledAmount"
			 Public Const BillingDate As String = "BillingDate"
			 Public Const InvoiceNumber As String = "InvoiceNumber"
			 Public Const Status As String = "Status"
			 Public Const LoadID As String = "LoadID"
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
            SyncLock GetType(ViewOrdersReadyForInvoiceMetadata)
			
				If ViewOrdersReadyForInvoiceMetadata.mapDelegates Is Nothing Then
					ViewOrdersReadyForInvoiceMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewOrdersReadyForInvoiceMetadata._meta Is Nothing Then
                    ViewOrdersReadyForInvoiceMetadata._meta = New ViewOrdersReadyForInvoiceMetadata()
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
				

				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orderstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Billingtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Transporttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PlannedDeliveryDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ActualShipmentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CarrierProNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AddToInvoice", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("BillCustomer", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("BilledAmount", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("BillingDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("InvoiceNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Status", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewOrdersReadyForInvoice"
				meta.Destination = "viewOrdersReadyForInvoice"
				
				meta.spInsert = "proc_viewOrdersReadyForInvoiceInsert"
				meta.spUpdate = "proc_viewOrdersReadyForInvoiceUpdate"
				meta.spDelete = "proc_viewOrdersReadyForInvoiceDelete"
				meta.spLoadAll = "proc_viewOrdersReadyForInvoiceLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewOrdersReadyForInvoiceLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewOrdersReadyForInvoiceMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
