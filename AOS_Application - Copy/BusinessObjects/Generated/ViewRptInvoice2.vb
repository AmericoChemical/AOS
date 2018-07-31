'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/23/2015 1:50:28 PM
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
	MustInherit Public Class esViewRptInvoice2Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptInvoice2Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptInvoice2Query)
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
            Me.InitQuery(CType(query, esViewRptInvoice2Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptInvoice2) As ViewRptInvoice2
			Return CType(MyBase.DetachEntity(entity), ViewRptInvoice2)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptInvoice2) As ViewRptInvoice2
			Return CType(MyBase.AttachEntity(entity), ViewRptInvoice2)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptInvoice2Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptInvoice2
            Get
                Return TryCast(MyBase.Item(index), ViewRptInvoice2)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptInvoice2)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptInvoice2	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptInvoice2Query
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
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Invoiceqty"
							Me.str.Invoiceqty = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Itemprice"
							Me.str.Itemprice = CType(value, string)
												
						Case "Extpricetotal"
							Me.str.Extpricetotal = CType(value, string)
												
						Case "Taxable"
							Me.str.Taxable = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "Itemsort"
							Me.str.Itemsort = CType(value, string)
												
						Case "Priceunits"
							Me.str.Priceunits = CType(value, string)
												
						Case "Priceuom"
							Me.str.Priceuom = CType(value, string)
												
						Case "Unitprice"
							Me.str.Unitprice = CType(value, string)
												
						Case "Custitemid"
							Me.str.Custitemid = CType(value, string)
												
						Case "Accountingnotes"
							Me.str.Accountingnotes = CType(value, string)
					
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
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoiceqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Invoiceqty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Itemprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extpricetotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extpricetotal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Taxable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Taxable = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Itemsort"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemsort = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Priceunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Priceunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitprice = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewRptInvoice2.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.INVOICEDATE
		' </summary>
		Public Overridable Property Invoicedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptInvoice2Metadata.ColumnNames.Invoicedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptInvoice2Metadata.ColumnNames.Invoicedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptInvoice2Metadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptInvoice2Metadata.ColumnNames.Shipmentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.BILLADDRESS1
		' </summary>
		Public Overridable Property Billaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.BILLADDRESS2
		' </summary>
		Public Overridable Property Billaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.BILLCITY
		' </summary>
		Public Overridable Property Billcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.BILLSTATEPROV
		' </summary>
		Public Overridable Property Billstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.BILLPOSTALCODE
		' </summary>
		Public Overridable Property Billpostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billpostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billpostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.BILLCOUNTRY
		' </summary>
		Public Overridable Property Billcountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.BILLPHONE
		' </summary>
		Public Overridable Property Billphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.BILLFAX
		' </summary>
		Public Overridable Property Billfax As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.BILLCONTACT
		' </summary>
		Public Overridable Property Billcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Billcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPADDRESS1
		' </summary>
		Public Overridable Property Shipaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPADDRESS2
		' </summary>
		Public Overridable Property Shipaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPCITY
		' </summary>
		Public Overridable Property Shipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPSTATEPROV
		' </summary>
		Public Overridable Property Shipstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPPOSTALCODE
		' </summary>
		Public Overridable Property Shippostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shippostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shippostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPCOUNTRY
		' </summary>
		Public Overridable Property Shipcountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPCONTACT
		' </summary>
		Public Overridable Property Shipcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Shipcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.ORDERTERMS
		' </summary>
		Public Overridable Property Orderterms As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Orderterms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Orderterms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptInvoice2Metadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptInvoice2Metadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SHIPPEDDATE
		' </summary>
		Public Overridable Property Shippeddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptInvoice2Metadata.ColumnNames.Shippeddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptInvoice2Metadata.ColumnNames.Shippeddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.SALESTAX
		' </summary>
		Public Overridable Property Salestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Salestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Salestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.TOTAL
		' </summary>
		Public Overridable Property Total As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Total)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Total, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.INVOICESTATUS
		' </summary>
		Public Overridable Property Invoicestatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Invoicestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Invoicestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.INVNUMVIEW
		' </summary>
		Public Overridable Property Invnumview As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Invnumview)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Invnumview, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.INVOICEQTY
		' </summary>
		Public Overridable Property Invoiceqty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Invoiceqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Invoiceqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.ITEMPRICE
		' </summary>
		Public Overridable Property Itemprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Itemprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Itemprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.EXTPRICETOTAL
		' </summary>
		Public Overridable Property Extpricetotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Extpricetotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Extpricetotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.TAXABLE
		' </summary>
		Public Overridable Property Taxable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptInvoice2Metadata.ColumnNames.Taxable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptInvoice2Metadata.ColumnNames.Taxable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.ITEMSORT
		' </summary>
		Public Overridable Property Itemsort As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Itemsort)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInvoice2Metadata.ColumnNames.Itemsort, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.PRICEUNITS
		' </summary>
		Public Overridable Property Priceunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Priceunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Priceunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.PRICEUOM
		' </summary>
		Public Overridable Property Priceuom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Priceuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Priceuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.UNITPRICE
		' </summary>
		Public Overridable Property Unitprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Unitprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoice2Metadata.ColumnNames.Unitprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.CUSTITEMID
		' </summary>
		Public Overridable Property Custitemid As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Custitemid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Custitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoice2.ACCOUNTINGNOTES
		' </summary>
		Public Overridable Property Accountingnotes As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoice2Metadata.ColumnNames.Accountingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoice2Metadata.ColumnNames.Accountingnotes, value)
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
		
			Public Sub New(ByVal entity As esViewRptInvoice2)
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
		  	
			Public Property Invoiceqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Invoiceqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoiceqty = Nothing
					Else
						entity.Invoiceqty = Convert.ToDecimal(Value)
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
		  	
			Public Property Extpricetotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extpricetotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extpricetotal = Nothing
					Else
						entity.Extpricetotal = Convert.ToDecimal(Value)
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
		  	
			Public Property Itemid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Itemid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemid = Nothing
					Else
						entity.Itemid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemdescription As System.String 
				Get
					Dim data_ As System.String = entity.Itemdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemdescription = Nothing
					Else
						entity.Itemdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemtype As System.String 
				Get
					Dim data_ As System.String = entity.Itemtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemtype = Nothing
					Else
						entity.Itemtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemsort As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Itemsort
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemsort = Nothing
					Else
						entity.Itemsort = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Custitemid As System.String 
				Get
					Dim data_ As System.String = entity.Custitemid
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custitemid = Nothing
					Else
						entity.Custitemid = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Accountingnotes As System.String 
				Get
					Dim data_ As System.String = entity.Accountingnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Accountingnotes = Nothing
					Else
						entity.Accountingnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptInvoice2
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptInvoice2Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptInvoice2 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptInvoice2Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptInvoice2Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Invoicedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Billaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Billaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Billaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Billcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Billstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billpostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Billpostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billcountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Billcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Billphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billfax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Billfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Billcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shipaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shipaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shipstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shippostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shippostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shipcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shipcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderterms As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Orderterms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Shippeddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Shippeddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Salestax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Salestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Total As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Total, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicestatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Invoicestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invnumview As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Invnumview, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invoiceqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Invoiceqty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Itemprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extpricetotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Extpricetotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Taxable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Taxable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemsort As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Itemsort, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Priceunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Priceunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Priceuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Priceuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Unitprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Custitemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Custitemid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Accountingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoice2Metadata.ColumnNames.Accountingnotes, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptInvoice2Collection")> _
	Partial Public Class ViewRptInvoice2Collection
		Inherits esViewRptInvoice2Collection
		Implements IEnumerable(Of ViewRptInvoice2)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptInvoice2Collection) As List(Of ViewRptInvoice2)
            Dim list As List(Of ViewRptInvoice2) = New List(Of ViewRptInvoice2)
            Dim emp As ViewRptInvoice2

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptInvoice2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptInvoice2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptInvoice2(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptInvoice2()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptInvoice2Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptInvoice2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptInvoice2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptInvoice2 
			Return CType(MyBase.AddNewEntity(), ViewRptInvoice2)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptInvoice2) Implements IEnumerable(Of ViewRptInvoice2).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptInvoice2)(Me)
        End Function
		
		Private _query As ViewRptInvoice2Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptInvoice2' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptInvoice2 ()")> _
	<Serializable> _
	Partial Public Class ViewRptInvoice2 
		Inherits esViewRptInvoice2

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptInvoice2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptInvoice2Query

			If Me._query Is Nothing Then
				Me._query = New ViewRptInvoice2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptInvoice2Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptInvoice2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptInvoice2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptInvoice2Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptInvoice2Query
		inherits esViewRptInvoice2Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptInvoice2Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptInvoice2Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Invoicenumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Invoicedate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Invoicedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shipmentnumber, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shipmentdate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Custid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Billaddress1, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Billaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Billaddress2, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Billaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Billcity, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Billcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Billstateprov, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Billstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Billpostalcode, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Billpostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Billcountry, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Billcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Billphone, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Billphone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Billfax, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Billfax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Billcontact, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Billcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shipaddress1, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shipaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shipaddress2, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shipaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shipcity, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shipstateprov, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shippostalcode, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shippostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shipcountry, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shipcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shipcontact, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shipcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Freightcarrier, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Fob, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Customerpo, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Orderterms, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Orderterms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Deliverydate, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Shippeddate, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Shippeddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Subtotal, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Subtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Salestax, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Salestax
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Total, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Total
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Invoicestatus, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Invoicestatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Invnumview, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Invnumview
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Productid, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Productdesc, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Invoiceqty, 34, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Invoiceqty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Unitorcontainer, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Container, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Uom, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Itemprice, 38, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Itemprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Extpricetotal, 39, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Extpricetotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Taxable, 40, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Taxable
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Custname, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Itemid, 42, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Itemdescription, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Itemtype, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Itemsort, 45, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Itemsort
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Priceunits, 46, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Priceunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Priceuom, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Priceuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Unitprice, 48, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Unitprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Custitemid, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Custitemid
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoice2Metadata.ColumnNames.Accountingnotes, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoice2Metadata.PropertyNames.Accountingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptInvoice2Metadata
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
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Invoiceqty As String = "INVOICEQTY"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Container As String = "CONTAINER"
			 Public Const Uom As String = "UOM"
			 Public Const Itemprice As String = "ITEMPRICE"
			 Public Const Extpricetotal As String = "EXTPRICETOTAL"
			 Public Const Taxable As String = "TAXABLE"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const Itemsort As String = "ITEMSORT"
			 Public Const Priceunits As String = "PRICEUNITS"
			 Public Const Priceuom As String = "PRICEUOM"
			 Public Const Unitprice As String = "UNITPRICE"
			 Public Const Custitemid As String = "CUSTITEMID"
			 Public Const Accountingnotes As String = "ACCOUNTINGNOTES"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
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
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Invoiceqty As String = "Invoiceqty"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Container As String = "Container"
			 Public Const Uom As String = "Uom"
			 Public Const Itemprice As String = "Itemprice"
			 Public Const Extpricetotal As String = "Extpricetotal"
			 Public Const Taxable As String = "Taxable"
			 Public Const Custname As String = "Custname"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const Itemsort As String = "Itemsort"
			 Public Const Priceunits As String = "Priceunits"
			 Public Const Priceuom As String = "Priceuom"
			 Public Const Unitprice As String = "Unitprice"
			 Public Const Custitemid As String = "Custitemid"
			 Public Const Accountingnotes As String = "Accountingnotes"
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
            SyncLock GetType(ViewRptInvoice2Metadata)
			
				If ViewRptInvoice2Metadata.mapDelegates Is Nothing Then
					ViewRptInvoice2Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptInvoice2Metadata._meta Is Nothing Then
                    ViewRptInvoice2Metadata._meta = New ViewRptInvoice2Metadata()
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
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invoiceqty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Extpricetotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Taxable", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemsort", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Priceunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Priceuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Custitemid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Accountingnotes", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptInvoice2"
				meta.Destination = "viewRptInvoice2"
				
				meta.spInsert = "proc_viewRptInvoice2Insert"
				meta.spUpdate = "proc_viewRptInvoice2Update"
				meta.spDelete = "proc_viewRptInvoice2Delete"
				meta.spLoadAll = "proc_viewRptInvoice2LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptInvoice2LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptInvoice2Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
