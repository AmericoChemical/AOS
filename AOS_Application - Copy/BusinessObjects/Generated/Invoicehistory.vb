'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/27/2017 8:11:09 PM
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
	MustInherit Public Class esInvoicehistoryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "InvoicehistoryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esInvoicehistoryQuery)
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
            Me.InitQuery(CType(query, esInvoicehistoryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Invoicehistory) As Invoicehistory
			Return CType(MyBase.DetachEntity(entity), Invoicehistory)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Invoicehistory) As Invoicehistory
			Return CType(MyBase.AttachEntity(entity), Invoicehistory)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As InvoicehistoryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Invoicehistory
            Get
                Return TryCast(MyBase.Item(index), Invoicehistory)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Invoicehistory)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esInvoicehistory	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esInvoicehistoryQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal invoicehistoryid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoicehistoryid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoicehistoryid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal invoicehistoryid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoicehistoryid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoicehistoryid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal invoicehistoryid As System.Int32) As Boolean
		
			Dim query As esInvoicehistoryQuery = Me.GetDynamicQuery()
			query.Where(query.Invoicehistoryid.Equal(invoicehistoryid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal invoicehistoryid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("INVOICEHISTORYID", invoicehistoryid)
			
			Return Me.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
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
												
						Case "Invoicehistoryid"
							Me.str.Invoicehistoryid = CType(value, string)
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Invoicedate"
							Me.str.Invoicedate = CType(value, string)
												
						Case "Shipmentnumber"
							Me.str.Shipmentnumber = CType(value, string)
												
						Case "Shipmentdate"
							Me.str.Shipmentdate = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Billaddress1"
							Me.str.Billaddress1 = CType(value, string)
												
						Case "Billaddress2"
							Me.str.Billaddress2 = CType(value, string)
												
						Case "Billcity"
							Me.str.Billcity = CType(value, string)
												
						Case "Billstateprov"
							Me.str.Billstateprov = CType(value, string)
												
						Case "Billpostalcode"
							Me.str.Billpostalcode = CType(value, string)
												
						Case "Billcountry"
							Me.str.Billcountry = CType(value, string)
												
						Case "Billphone"
							Me.str.Billphone = CType(value, string)
												
						Case "Billfax"
							Me.str.Billfax = CType(value, string)
												
						Case "Billcontact"
							Me.str.Billcontact = CType(value, string)
												
						Case "Shipaddress1"
							Me.str.Shipaddress1 = CType(value, string)
												
						Case "Shipaddress2"
							Me.str.Shipaddress2 = CType(value, string)
												
						Case "Shipcity"
							Me.str.Shipcity = CType(value, string)
												
						Case "Shipstateprov"
							Me.str.Shipstateprov = CType(value, string)
												
						Case "Shippostalcode"
							Me.str.Shippostalcode = CType(value, string)
												
						Case "Shipcountry"
							Me.str.Shipcountry = CType(value, string)
												
						Case "Shipcontact"
							Me.str.Shipcontact = CType(value, string)
												
						Case "Freightcarrier"
							Me.str.Freightcarrier = CType(value, string)
												
						Case "Fob"
							Me.str.Fob = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Orderterms"
							Me.str.Orderterms = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
												
						Case "Shippeddate"
							Me.str.Shippeddate = CType(value, string)
												
						Case "Subtotal"
							Me.str.Subtotal = CType(value, string)
												
						Case "Salestax"
							Me.str.Salestax = CType(value, string)
												
						Case "Total"
							Me.str.Total = CType(value, string)
												
						Case "Invoicestatus"
							Me.str.Invoicestatus = CType(value, string)
												
						Case "Invnumview"
							Me.str.Invnumview = CType(value, string)
												
						Case "Logisticsid"
							Me.str.Logisticsid = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invoicehistoryid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicehistoryid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Invoicedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Shipmentnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipmentnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Shipmentdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Shipmentdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Shippeddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Shippeddate = CType(value, Nullable(Of System.DateTime))
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
						
						Case "Logisticsid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Logisticsid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to INVOICEHISTORY.INVOICEHISTORYID
		' </summary>
		Public Overridable Property Invoicehistoryid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryMetadata.ColumnNames.Invoicehistoryid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryMetadata.ColumnNames.Invoicehistoryid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.INVOICEDATE
		' </summary>
		Public Overridable Property Invoicedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Invoicedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Invoicedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryMetadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryMetadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Shipmentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.BILLADDRESS1
		' </summary>
		Public Overridable Property Billaddress1 As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Billaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Billaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.BILLADDRESS2
		' </summary>
		Public Overridable Property Billaddress2 As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Billaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Billaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.BILLCITY
		' </summary>
		Public Overridable Property Billcity As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Billcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Billcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.BILLSTATEPROV
		' </summary>
		Public Overridable Property Billstateprov As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Billstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Billstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.BILLPOSTALCODE
		' </summary>
		Public Overridable Property Billpostalcode As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Billpostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Billpostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.BILLCOUNTRY
		' </summary>
		Public Overridable Property Billcountry As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Billcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Billcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.BILLPHONE
		' </summary>
		Public Overridable Property Billphone As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Billphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Billphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.BILLFAX
		' </summary>
		Public Overridable Property Billfax As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Billfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Billfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.BILLCONTACT
		' </summary>
		Public Overridable Property Billcontact As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Billcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Billcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPADDRESS1
		' </summary>
		Public Overridable Property Shipaddress1 As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Shipaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Shipaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPADDRESS2
		' </summary>
		Public Overridable Property Shipaddress2 As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Shipaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Shipaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPCITY
		' </summary>
		Public Overridable Property Shipcity As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Shipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Shipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPSTATEPROV
		' </summary>
		Public Overridable Property Shipstateprov As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Shipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Shipstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPPOSTALCODE
		' </summary>
		Public Overridable Property Shippostalcode As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Shippostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Shippostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPCOUNTRY
		' </summary>
		Public Overridable Property Shipcountry As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Shipcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Shipcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPCONTACT
		' </summary>
		Public Overridable Property Shipcontact As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Shipcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Shipcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.ORDERTERMS
		' </summary>
		Public Overridable Property Orderterms As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Orderterms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Orderterms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SHIPPEDDATE
		' </summary>
		Public Overridable Property Shippeddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Shippeddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Shippeddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryMetadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryMetadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.SALESTAX
		' </summary>
		Public Overridable Property Salestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryMetadata.ColumnNames.Salestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryMetadata.ColumnNames.Salestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.TOTAL
		' </summary>
		Public Overridable Property Total As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryMetadata.ColumnNames.Total)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryMetadata.ColumnNames.Total, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.INVOICESTATUS
		' </summary>
		Public Overridable Property Invoicestatus As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Invoicestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Invoicestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.INVNUMVIEW
		' </summary>
		Public Overridable Property Invnumview As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryMetadata.ColumnNames.Invnumview)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryMetadata.ColumnNames.Invnumview, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.LOGISTICSID
		' </summary>
		Public Overridable Property Logisticsid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryMetadata.ColumnNames.Logisticsid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryMetadata.ColumnNames.Logisticsid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORY.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(InvoicehistoryMetadata.ColumnNames.Createdtime, value)
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
		
			Public Sub New(ByVal entity As esInvoicehistory)
				Me.entity = entity
			End Sub				
		
	
			Public Property Invoicehistoryid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoicehistoryid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicehistoryid = Nothing
					Else
						entity.Invoicehistoryid = Convert.ToInt32(Value)
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
		  	
			Public Property Shipmentnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Shipmentnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentnumber = Nothing
					Else
						entity.Shipmentnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipmentdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Shipmentdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentdate = Nothing
					Else
						entity.Shipmentdate = Convert.ToDateTime(Value)
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
		  	
			Public Property Billaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Billaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billaddress1 = Nothing
					Else
						entity.Billaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Billaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billaddress2 = Nothing
					Else
						entity.Billaddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billcity As System.String 
				Get
					Dim data_ As System.String = entity.Billcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billcity = Nothing
					Else
						entity.Billcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Billstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billstateprov = Nothing
					Else
						entity.Billstateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billpostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Billpostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billpostalcode = Nothing
					Else
						entity.Billpostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billcountry As System.String 
				Get
					Dim data_ As System.String = entity.Billcountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billcountry = Nothing
					Else
						entity.Billcountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billphone As System.String 
				Get
					Dim data_ As System.String = entity.Billphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billphone = Nothing
					Else
						entity.Billphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billfax As System.String 
				Get
					Dim data_ As System.String = entity.Billfax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billfax = Nothing
					Else
						entity.Billfax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billcontact As System.String 
				Get
					Dim data_ As System.String = entity.Billcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billcontact = Nothing
					Else
						entity.Billcontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Shipaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipaddress1 = Nothing
					Else
						entity.Shipaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Shipaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipaddress2 = Nothing
					Else
						entity.Shipaddress2 = Convert.ToString(Value)
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
		  	
			Public Property Shippostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Shippostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shippostalcode = Nothing
					Else
						entity.Shippostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipcountry As System.String 
				Get
					Dim data_ As System.String = entity.Shipcountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipcountry = Nothing
					Else
						entity.Shipcountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipcontact As System.String 
				Get
					Dim data_ As System.String = entity.Shipcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipcontact = Nothing
					Else
						entity.Shipcontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freightcarrier As System.String 
				Get
					Dim data_ As System.String = entity.Freightcarrier
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freightcarrier = Nothing
					Else
						entity.Freightcarrier = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fob As System.String 
				Get
					Dim data_ As System.String = entity.Fob
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fob = Nothing
					Else
						entity.Fob = Convert.ToString(Value)
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
		  	
			Public Property Orderterms As System.String 
				Get
					Dim data_ As System.String = entity.Orderterms
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Orderterms = Nothing
					Else
						entity.Orderterms = Convert.ToString(Value)
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
		  	
			Public Property Shippeddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Shippeddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shippeddate = Nothing
					Else
						entity.Shippeddate = Convert.ToDateTime(Value)
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
		  	
			Public Property Logisticsid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Logisticsid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsid = Nothing
					Else
						entity.Logisticsid = Convert.ToInt32(Value)
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
		  	
			Public Property Createdby As System.String 
				Get
					Dim data_ As System.String = entity.Createdby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdby = Nothing
					Else
						entity.Createdby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdtime = Nothing
					Else
						entity.Createdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esInvoicehistory
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esInvoicehistoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esInvoicehistory can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Invoicehistory 
		Inherits esInvoicehistory
		
	
		
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
        Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
        
            Dim props As New List(Of esPropertyDescriptor)
			

            Return props
			
        End Function	
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostOneSave.
		''' </summary>
		Protected Overrides Sub ApplyPostOneSaveKeys()
		
		End Sub
	End Class
	


	<Serializable> _
	MustInherit Public Class esInvoicehistoryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvoicehistoryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invoicehistoryid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Invoicehistoryid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicedate As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Invoicedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Billaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Billaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Billaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billcity As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Billcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Billstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billpostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Billpostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billcountry As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Billcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billphone As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Billphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billfax As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Billfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billcontact As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Billcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shipaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shipaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcity As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shipstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shippostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shippostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcountry As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shipcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcontact As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shipcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderterms As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Orderterms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Shippeddate As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Shippeddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Salestax As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Salestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Total As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Total, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicestatus As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Invoicestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invnumview As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Invnumview, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Logisticsid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("InvoicehistoryCollection")> _
	Partial Public Class InvoicehistoryCollection
		Inherits esInvoicehistoryCollection
		Implements IEnumerable(Of Invoicehistory)
		
        Public Shared Widening Operator CType(ByVal coll As InvoicehistoryCollection) As List(Of Invoicehistory)
            Dim list As List(Of Invoicehistory) = New List(Of Invoicehistory)
            Dim emp As Invoicehistory

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvoicehistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New InvoicehistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Invoicehistory(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Invoicehistory()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As InvoicehistoryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New InvoicehistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvoicehistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Invoicehistory 
			Return CType(MyBase.AddNewEntity(), Invoicehistory)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal invoicehistoryid As System.Int32) As Invoicehistory
			Return CType(MyBase.FindByPrimaryKey(invoicehistoryid), Invoicehistory)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Invoicehistory) Implements IEnumerable(Of Invoicehistory).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Invoicehistory)(Me)
        End Function
		
		Private _query As InvoicehistoryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'INVOICEHISTORY' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Invoicehistory ({Invoicehistoryid.Value})")> _
	<Serializable> _
	Partial Public Class Invoicehistory 
		Inherits esInvoicehistory

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return InvoicehistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esInvoicehistoryQuery

			If Me._query Is Nothing Then
				Me._query = New InvoicehistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As InvoicehistoryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New InvoicehistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvoicehistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As InvoicehistoryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class InvoicehistoryQuery
		inherits esInvoicehistoryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "InvoicehistoryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class InvoicehistoryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Invoicehistoryid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Invoicehistoryid
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Invoicenumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Invoicedate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Invoicedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shipmentnumber, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shipmentdate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Custid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Billaddress1, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Billaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Billaddress2, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Billaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Billcity, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Billcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Billstateprov, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Billstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Billpostalcode, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Billpostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Billcountry, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Billcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Billphone, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Billphone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Billfax, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Billfax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Billcontact, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Billcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shipaddress1, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shipaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shipaddress2, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shipaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shipcity, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shipstateprov, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shippostalcode, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shippostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shipcountry, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shipcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shipcontact, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shipcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Freightcarrier, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Fob, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Customerpo, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Orderterms, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Orderterms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Deliverydate, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Shippeddate, 27, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Shippeddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Subtotal, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Subtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Salestax, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Salestax
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Total, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Total
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Invoicestatus, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Invoicestatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Invnumview, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Invnumview
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Logisticsid, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Logisticsid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Modifyby, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Modifytime, 35, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Createdby, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryMetadata.ColumnNames.Createdtime, 37, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = InvoicehistoryMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As InvoicehistoryMetadata
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
			 Public Const Invoicehistoryid As String = "INVOICEHISTORYID"
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Invoicedate As String = "INVOICEDATE"
			 Public Const Shipmentnumber As String = "SHIPMENTNUMBER"
			 Public Const Shipmentdate As String = "SHIPMENTDATE"
			 Public Const Custid As String = "CUSTID"
			 Public Const Billaddress1 As String = "BILLADDRESS1"
			 Public Const Billaddress2 As String = "BILLADDRESS2"
			 Public Const Billcity As String = "BILLCITY"
			 Public Const Billstateprov As String = "BILLSTATEPROV"
			 Public Const Billpostalcode As String = "BILLPOSTALCODE"
			 Public Const Billcountry As String = "BILLCOUNTRY"
			 Public Const Billphone As String = "BILLPHONE"
			 Public Const Billfax As String = "BILLFAX"
			 Public Const Billcontact As String = "BILLCONTACT"
			 Public Const Shipaddress1 As String = "SHIPADDRESS1"
			 Public Const Shipaddress2 As String = "SHIPADDRESS2"
			 Public Const Shipcity As String = "SHIPCITY"
			 Public Const Shipstateprov As String = "SHIPSTATEPROV"
			 Public Const Shippostalcode As String = "SHIPPOSTALCODE"
			 Public Const Shipcountry As String = "SHIPCOUNTRY"
			 Public Const Shipcontact As String = "SHIPCONTACT"
			 Public Const Freightcarrier As String = "FREIGHTCARRIER"
			 Public Const Fob As String = "FOB"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Orderterms As String = "ORDERTERMS"
			 Public Const Deliverydate As String = "DELIVERYDATE"
			 Public Const Shippeddate As String = "SHIPPEDDATE"
			 Public Const Subtotal As String = "SUBTOTAL"
			 Public Const Salestax As String = "SALESTAX"
			 Public Const Total As String = "TOTAL"
			 Public Const Invoicestatus As String = "INVOICESTATUS"
			 Public Const Invnumview As String = "INVNUMVIEW"
			 Public Const Logisticsid As String = "LOGISTICSID"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invoicehistoryid As String = "Invoicehistoryid"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Invoicedate As String = "Invoicedate"
			 Public Const Shipmentnumber As String = "Shipmentnumber"
			 Public Const Shipmentdate As String = "Shipmentdate"
			 Public Const Custid As String = "Custid"
			 Public Const Billaddress1 As String = "Billaddress1"
			 Public Const Billaddress2 As String = "Billaddress2"
			 Public Const Billcity As String = "Billcity"
			 Public Const Billstateprov As String = "Billstateprov"
			 Public Const Billpostalcode As String = "Billpostalcode"
			 Public Const Billcountry As String = "Billcountry"
			 Public Const Billphone As String = "Billphone"
			 Public Const Billfax As String = "Billfax"
			 Public Const Billcontact As String = "Billcontact"
			 Public Const Shipaddress1 As String = "Shipaddress1"
			 Public Const Shipaddress2 As String = "Shipaddress2"
			 Public Const Shipcity As String = "Shipcity"
			 Public Const Shipstateprov As String = "Shipstateprov"
			 Public Const Shippostalcode As String = "Shippostalcode"
			 Public Const Shipcountry As String = "Shipcountry"
			 Public Const Shipcontact As String = "Shipcontact"
			 Public Const Freightcarrier As String = "Freightcarrier"
			 Public Const Fob As String = "Fob"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Orderterms As String = "Orderterms"
			 Public Const Deliverydate As String = "Deliverydate"
			 Public Const Shippeddate As String = "Shippeddate"
			 Public Const Subtotal As String = "Subtotal"
			 Public Const Salestax As String = "Salestax"
			 Public Const Total As String = "Total"
			 Public Const Invoicestatus As String = "Invoicestatus"
			 Public Const Invnumview As String = "Invnumview"
			 Public Const Logisticsid As String = "Logisticsid"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
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
            SyncLock GetType(InvoicehistoryMetadata)
			
				If InvoicehistoryMetadata.mapDelegates Is Nothing Then
					InvoicehistoryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If InvoicehistoryMetadata._meta Is Nothing Then
                    InvoicehistoryMetadata._meta = New InvoicehistoryMetadata()
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
				

				meta.AddTypeMap("Invoicehistoryid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Shipmentnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipmentdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Billaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billpostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billcountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shippostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Freightcarrier", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orderterms", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Shippeddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Subtotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Salestax", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Total", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Invoicestatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invnumview", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Logisticsid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "INVOICEHISTORY"
				meta.Destination = "INVOICEHISTORY"
				
				meta.spInsert = "proc_INVOICEHISTORYInsert"
				meta.spUpdate = "proc_INVOICEHISTORYUpdate"
				meta.spDelete = "proc_INVOICEHISTORYDelete"
				meta.spLoadAll = "proc_INVOICEHISTORYLoadAll"
				meta.spLoadByPrimaryKey = "proc_INVOICEHISTORYLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As InvoicehistoryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
