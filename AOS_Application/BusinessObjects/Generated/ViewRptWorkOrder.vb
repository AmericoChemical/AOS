'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/21/2017 8:08:10 AM
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
	MustInherit Public Class esViewRptWorkOrderCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptWorkOrderCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptWorkOrderQuery)
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
            Me.InitQuery(CType(query, esViewRptWorkOrderQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptWorkOrder) As ViewRptWorkOrder
			Return CType(MyBase.DetachEntity(entity), ViewRptWorkOrder)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptWorkOrder) As ViewRptWorkOrder
			Return CType(MyBase.AttachEntity(entity), ViewRptWorkOrder)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptWorkOrderCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptWorkOrder
            Get
                Return TryCast(MyBase.Item(index), ViewRptWorkOrder)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptWorkOrder)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptWorkOrder	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptWorkOrderQuery
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
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Itemcomments"
							Me.str.Itemcomments = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
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
												
						Case "Fob"
							Me.str.Fob = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Orderterms"
							Me.str.Orderterms = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
												
						Case "Plannedshipdate"
							Me.str.Plannedshipdate = CType(value, string)
												
						Case "Howreceived"
							Me.str.Howreceived = CType(value, string)
												
						Case "Orderstatus"
							Me.str.Orderstatus = CType(value, string)
												
						Case "Ordernotes"
							Me.str.Ordernotes = CType(value, string)
												
						Case "Workorderdate"
							Me.str.Workorderdate = CType(value, string)
												
						Case "Preparedby"
							Me.str.Preparedby = CType(value, string)
												
						Case "Suppliercompany"
							Me.str.Suppliercompany = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Stdgallons"
							Me.str.Stdgallons = CType(value, string)
												
						Case "Stdweight"
							Me.str.Stdweight = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Grossweight"
							Me.str.Grossweight = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Prodfulfillmentnotes"
							Me.str.Prodfulfillmentnotes = CType(value, string)
												
						Case "Transporttype"
							Me.str.Transporttype = CType(value, string)
												
						Case "Ordertype"
							Me.str.Ordertype = CType(value, string)
												
						Case "Freezeprotect"
							Me.str.Freezeprotect = CType(value, string)
												
						Case "Custitemid"
							Me.str.Custitemid = CType(value, string)
												
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
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcedocument"
							Me.str.Sourcedocument = CType(value, string)
												
						Case "Freightcarrier"
							Me.str.Freightcarrier = CType(value, string)
												
						Case "Orsoonerflag"
							Me.str.Orsoonerflag = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "ISourceDocument"
							Me.str.ISourceDocument = CType(value, string)
												
						Case "ISourceType"
							Me.str.ISourceType = CType(value, string)
												
						Case "Warehouselocation"
							Me.str.Warehouselocation = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Logisticsname"
							Me.str.Logisticsname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Plannedshipdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Plannedshipdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Workorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Workorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Stdgallons"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdgallons = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Stdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdweight = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Grossweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Grossweight = CType(value, Nullable(Of System.Decimal))
							End If
						
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
						
						Case "Sourcedocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Orsoonerflag"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Orsoonerflag = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "ISourceDocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ISourceDocument = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRptWorkOrder.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ITEMCOMMENTS
		' </summary>
		Public Overridable Property Itemcomments As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Itemcomments)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Itemcomments, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SHIPADDRESS1
		' </summary>
		Public Overridable Property Shipaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SHIPADDRESS2
		' </summary>
		Public Overridable Property Shipaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SHIPCITY
		' </summary>
		Public Overridable Property Shipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SHIPSTATEPROV
		' </summary>
		Public Overridable Property Shipstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SHIPPOSTALCODE
		' </summary>
		Public Overridable Property Shippostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shippostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shippostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SHIPCOUNTRY
		' </summary>
		Public Overridable Property Shipcountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SHIPCONTACT
		' </summary>
		Public Overridable Property Shipcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Shipcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ORDERTERMS
		' </summary>
		Public Overridable Property Orderterms As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Orderterms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Orderterms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptWorkOrderMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptWorkOrderMetadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptWorkOrderMetadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptWorkOrderMetadata.ColumnNames.Plannedshipdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.HOWRECEIVED
		' </summary>
		Public Overridable Property Howreceived As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Howreceived)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Howreceived, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ORDERSTATUS
		' </summary>
		Public Overridable Property Orderstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Orderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Orderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ORDERNOTES
		' </summary>
		Public Overridable Property Ordernotes As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Ordernotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Ordernotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptWorkOrderMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptWorkOrderMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.PREPAREDBY
		' </summary>
		Public Overridable Property Preparedby As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Preparedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Preparedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SUPPLIERCOMPANY
		' </summary>
		Public Overridable Property Suppliercompany As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Suppliercompany)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Suppliercompany, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.STDGALLONS
		' </summary>
		Public Overridable Property Stdgallons As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Stdgallons)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Stdgallons, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.GROSSWEIGHT
		' </summary>
		Public Overridable Property Grossweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Grossweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Grossweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.PRODFULFILLMENTNOTES
		' </summary>
		Public Overridable Property Prodfulfillmentnotes As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Prodfulfillmentnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Prodfulfillmentnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.TRANSPORTTYPE
		' </summary>
		Public Overridable Property Transporttype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Transporttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Transporttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ORDERTYPE
		' </summary>
		Public Overridable Property Ordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Ordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Ordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.FREEZEPROTECT
		' </summary>
		Public Overridable Property Freezeprotect As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Freezeprotect)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Freezeprotect, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.CUSTITEMID
		' </summary>
		Public Overridable Property Custitemid As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Custitemid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Custitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.PRICEUNITS
		' </summary>
		Public Overridable Property Priceunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Priceunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Priceunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.PRICEUOM
		' </summary>
		Public Overridable Property Priceuom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Priceuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Priceuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.UNITPRICE
		' </summary>
		Public Overridable Property Unitprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Unitprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Unitprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.STANDARDCOSTUNITS
		' </summary>
		Public Overridable Property Standardcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Standardcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Standardcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.STANDARDCOSTUOM
		' </summary>
		Public Overridable Property Standardcostuom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Standardcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Standardcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.STANDARDUNITCOST
		' </summary>
		Public Overridable Property Standardunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Standardunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Standardunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ACTUALCOSTUNITS
		' </summary>
		Public Overridable Property Actualcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Actualcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Actualcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ACTUALCOSTUOM
		' </summary>
		Public Overridable Property Actualcostuom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Actualcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Actualcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ACTUALUNITCOST
		' </summary>
		Public Overridable Property Actualunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Actualunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderMetadata.ColumnNames.Actualunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.SOURCEDOCUMENT
		' </summary>
		Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Sourcedocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.Sourcedocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ORSOONERFLAG
		' </summary>
		Public Overridable Property Orsoonerflag As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptWorkOrderMetadata.ColumnNames.Orsoonerflag)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptWorkOrderMetadata.ColumnNames.Orsoonerflag, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ISourceDocument
		' </summary>
		Public Overridable Property ISourceDocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.ISourceDocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderMetadata.ColumnNames.ISourceDocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ISourceType
		' </summary>
		Public Overridable Property ISourceType As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.ISourceType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.ISourceType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.WAREHOUSELOCATION
		' </summary>
		Public Overridable Property Warehouselocation As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Warehouselocation)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Warehouselocation, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrder.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderMetadata.ColumnNames.Logisticsname, value)
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
		
			Public Sub New(ByVal entity As esViewRptWorkOrder)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qty
					
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
						entity.Qty = Convert.ToDecimal(Value)
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
		  	
			Public Property Itemcomments As System.String 
				Get
					Dim data_ As System.String = entity.Itemcomments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemcomments = Nothing
					Else
						entity.Itemcomments = Convert.ToString(Value)
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
		  	
			Public Property Plannedshipdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Plannedshipdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Plannedshipdate = Nothing
					Else
						entity.Plannedshipdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Howreceived As System.String 
				Get
					Dim data_ As System.String = entity.Howreceived
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Howreceived = Nothing
					Else
						entity.Howreceived = Convert.ToString(Value)
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
		  	
			Public Property Ordernotes As System.String 
				Get
					Dim data_ As System.String = entity.Ordernotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ordernotes = Nothing
					Else
						entity.Ordernotes = Convert.ToString(Value)
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
		  	
			Public Property Preparedby As System.String 
				Get
					Dim data_ As System.String = entity.Preparedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Preparedby = Nothing
					Else
						entity.Preparedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Suppliercompany As System.String 
				Get
					Dim data_ As System.String = entity.Suppliercompany
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Suppliercompany = Nothing
					Else
						entity.Suppliercompany = Convert.ToString(Value)
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
		  	
			Public Property Stdgallons As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdgallons
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdgallons = Nothing
					Else
						entity.Stdgallons = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdweight = Nothing
					Else
						entity.Stdweight = Convert.ToDecimal(Value)
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
		  	
			Public Property Grossweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Grossweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Grossweight = Nothing
					Else
						entity.Grossweight = Convert.ToDecimal(Value)
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
		  	
			Public Property Prodfulfillmentnotes As System.String 
				Get
					Dim data_ As System.String = entity.Prodfulfillmentnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodfulfillmentnotes = Nothing
					Else
						entity.Prodfulfillmentnotes = Convert.ToString(Value)
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
		  	
			Public Property Freezeprotect As System.String 
				Get
					Dim data_ As System.String = entity.Freezeprotect
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freezeprotect = Nothing
					Else
						entity.Freezeprotect = Convert.ToString(Value)
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
		  	
			Public Property Sourcetype As System.String 
				Get
					Dim data_ As System.String = entity.Sourcetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcetype = Nothing
					Else
						entity.Sourcetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcedocument As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourcedocument
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcedocument = Nothing
					Else
						entity.Sourcedocument = Convert.ToInt32(Value)
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
		  	
			Public Property Orsoonerflag As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Orsoonerflag
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Orsoonerflag = Nothing
					Else
						entity.Orsoonerflag = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lotnumber As System.String 
				Get
					Dim data_ As System.String = entity.Lotnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lotnumber = Nothing
					Else
						entity.Lotnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ISourceDocument As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ISourceDocument
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ISourceDocument = Nothing
					Else
						entity.ISourceDocument = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ISourceType As System.String 
				Get
					Dim data_ As System.String = entity.ISourceType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ISourceType = Nothing
					Else
						entity.ISourceType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehouselocation As System.String 
				Get
					Dim data_ As System.String = entity.Warehouselocation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehouselocation = Nothing
					Else
						entity.Warehouselocation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Itemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemstatus = Nothing
					Else
						entity.Itemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsname As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsname = Nothing
					Else
						entity.Logisticsname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptWorkOrder
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptWorkOrderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptWorkOrder can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptWorkOrderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptWorkOrderMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemcomments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Itemcomments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Shipaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Shipaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Shipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Shipstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shippostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Shippostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Shipcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Shipcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderterms As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Orderterms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Howreceived As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Howreceived, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Orderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ordernotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Ordernotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Preparedby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Preparedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Suppliercompany As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Suppliercompany, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdgallons As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Stdgallons, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Stdweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Grossweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Grossweight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Prodfulfillmentnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Prodfulfillmentnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Transporttype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Transporttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Ordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freezeprotect As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Freezeprotect, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custitemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Custitemid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priceunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Priceunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Priceuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Priceuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Unitprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Standardcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Standardcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Standardunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Standardunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Actualcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Actualcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Actualunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Actualunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Sourcedocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orsoonerflag As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Orsoonerflag, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ISourceDocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.ISourceDocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ISourceType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.ISourceType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehouselocation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Warehouselocation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderMetadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptWorkOrderCollection")> _
	Partial Public Class ViewRptWorkOrderCollection
		Inherits esViewRptWorkOrderCollection
		Implements IEnumerable(Of ViewRptWorkOrder)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptWorkOrderCollection) As List(Of ViewRptWorkOrder)
            Dim list As List(Of ViewRptWorkOrder) = New List(Of ViewRptWorkOrder)
            Dim emp As ViewRptWorkOrder

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptWorkOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptWorkOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptWorkOrder(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptWorkOrder()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptWorkOrderQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptWorkOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptWorkOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptWorkOrder 
			Return CType(MyBase.AddNewEntity(), ViewRptWorkOrder)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptWorkOrder) Implements IEnumerable(Of ViewRptWorkOrder).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptWorkOrder)(Me)
        End Function
		
		Private _query As ViewRptWorkOrderQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptWorkOrder' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptWorkOrder ()")> _
	<Serializable> _
	Partial Public Class ViewRptWorkOrder 
		Inherits esViewRptWorkOrder

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptWorkOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptWorkOrderQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptWorkOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptWorkOrderQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptWorkOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptWorkOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptWorkOrderQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptWorkOrderQuery
		inherits esViewRptWorkOrderQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptWorkOrderQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptWorkOrderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Workorderitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Workordernumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Qty, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Invitemnumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Itemcomments, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Itemcomments
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Custid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Custname, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Shipaddress1, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Shipaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Shipaddress2, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Shipaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Shipcity, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Shipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Shipstateprov, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Shipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Shippostalcode, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Shippostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Shipcountry, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Shipcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Shipcontact, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Shipcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Fob, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Customerpo, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Orderterms, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Orderterms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Deliverydate, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Plannedshipdate, 19, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Howreceived, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Howreceived
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Orderstatus, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Orderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Ordernotes, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Ordernotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Workorderdate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Preparedby, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Preparedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Suppliercompany, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Suppliercompany
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Productdesc, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Stdgallons, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Stdgallons
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Stdweight, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Stdweight
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Container, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Grossweight, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Grossweight
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Createdby, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Prodfulfillmentnotes, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Prodfulfillmentnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Transporttype, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Transporttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Ordertype, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Ordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Freezeprotect, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Freezeprotect
			c.CharacterMaxLength = 14
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Custitemid, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Custitemid
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Priceunits, 37, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Priceunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Priceuom, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Priceuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Unitprice, 39, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Unitprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Standardcostunits, 40, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Standardcostunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Standardcostuom, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Standardcostuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Standardunitcost, 42, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Standardunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Actualcostunits, 43, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Actualcostunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Actualcostuom, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Actualcostuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Actualunitcost, 45, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Actualunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Sourcetype, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Sourcedocument, 47, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Sourcedocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Freightcarrier, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Orsoonerflag, 49, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Orsoonerflag
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Lotnumber, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.ISourceDocument, 51, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.ISourceDocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.ISourceType, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.ISourceType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Warehouselocation, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Warehouselocation
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Itemstatus, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderMetadata.ColumnNames.Logisticsname, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderMetadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptWorkOrderMetadata
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
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Qty As String = "QTY"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Itemcomments As String = "ITEMCOMMENTS"
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Shipaddress1 As String = "SHIPADDRESS1"
			 Public Const Shipaddress2 As String = "SHIPADDRESS2"
			 Public Const Shipcity As String = "SHIPCITY"
			 Public Const Shipstateprov As String = "SHIPSTATEPROV"
			 Public Const Shippostalcode As String = "SHIPPOSTALCODE"
			 Public Const Shipcountry As String = "SHIPCOUNTRY"
			 Public Const Shipcontact As String = "SHIPCONTACT"
			 Public Const Fob As String = "FOB"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Orderterms As String = "ORDERTERMS"
			 Public Const Deliverydate As String = "DELIVERYDATE"
			 Public Const Plannedshipdate As String = "PLANNEDSHIPDATE"
			 Public Const Howreceived As String = "HOWRECEIVED"
			 Public Const Orderstatus As String = "ORDERSTATUS"
			 Public Const Ordernotes As String = "ORDERNOTES"
			 Public Const Workorderdate As String = "WORKORDERDATE"
			 Public Const Preparedby As String = "PREPAREDBY"
			 Public Const Suppliercompany As String = "SUPPLIERCOMPANY"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Stdgallons As String = "STDGALLONS"
			 Public Const Stdweight As String = "STDWEIGHT"
			 Public Const Container As String = "CONTAINER"
			 Public Const Grossweight As String = "GROSSWEIGHT"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Prodfulfillmentnotes As String = "PRODFULFILLMENTNOTES"
			 Public Const Transporttype As String = "TRANSPORTTYPE"
			 Public Const Ordertype As String = "ORDERTYPE"
			 Public Const Freezeprotect As String = "FREEZEPROTECT"
			 Public Const Custitemid As String = "CUSTITEMID"
			 Public Const Priceunits As String = "PRICEUNITS"
			 Public Const Priceuom As String = "PRICEUOM"
			 Public Const Unitprice As String = "UNITPRICE"
			 Public Const Standardcostunits As String = "STANDARDCOSTUNITS"
			 Public Const Standardcostuom As String = "STANDARDCOSTUOM"
			 Public Const Standardunitcost As String = "STANDARDUNITCOST"
			 Public Const Actualcostunits As String = "ACTUALCOSTUNITS"
			 Public Const Actualcostuom As String = "ACTUALCOSTUOM"
			 Public Const Actualunitcost As String = "ACTUALUNITCOST"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcedocument As String = "SOURCEDOCUMENT"
			 Public Const Freightcarrier As String = "FREIGHTCARRIER"
			 Public Const Orsoonerflag As String = "ORSOONERFLAG"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const ISourceDocument As String = "ISourceDocument"
			 Public Const ISourceType As String = "ISourceType"
			 Public Const Warehouselocation As String = "WAREHOUSELOCATION"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Logisticsname As String = "LOGISTICSNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Productid As String = "Productid"
			 Public Const Qty As String = "Qty"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Itemcomments As String = "Itemcomments"
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Shipaddress1 As String = "Shipaddress1"
			 Public Const Shipaddress2 As String = "Shipaddress2"
			 Public Const Shipcity As String = "Shipcity"
			 Public Const Shipstateprov As String = "Shipstateprov"
			 Public Const Shippostalcode As String = "Shippostalcode"
			 Public Const Shipcountry As String = "Shipcountry"
			 Public Const Shipcontact As String = "Shipcontact"
			 Public Const Fob As String = "Fob"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Orderterms As String = "Orderterms"
			 Public Const Deliverydate As String = "Deliverydate"
			 Public Const Plannedshipdate As String = "Plannedshipdate"
			 Public Const Howreceived As String = "Howreceived"
			 Public Const Orderstatus As String = "Orderstatus"
			 Public Const Ordernotes As String = "Ordernotes"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Preparedby As String = "Preparedby"
			 Public Const Suppliercompany As String = "Suppliercompany"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Stdgallons As String = "Stdgallons"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Container As String = "Container"
			 Public Const Grossweight As String = "Grossweight"
			 Public Const Createdby As String = "Createdby"
			 Public Const Prodfulfillmentnotes As String = "Prodfulfillmentnotes"
			 Public Const Transporttype As String = "Transporttype"
			 Public Const Ordertype As String = "Ordertype"
			 Public Const Freezeprotect As String = "Freezeprotect"
			 Public Const Custitemid As String = "Custitemid"
			 Public Const Priceunits As String = "Priceunits"
			 Public Const Priceuom As String = "Priceuom"
			 Public Const Unitprice As String = "Unitprice"
			 Public Const Standardcostunits As String = "Standardcostunits"
			 Public Const Standardcostuom As String = "Standardcostuom"
			 Public Const Standardunitcost As String = "Standardunitcost"
			 Public Const Actualcostunits As String = "Actualcostunits"
			 Public Const Actualcostuom As String = "Actualcostuom"
			 Public Const Actualunitcost As String = "Actualunitcost"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcedocument As String = "Sourcedocument"
			 Public Const Freightcarrier As String = "Freightcarrier"
			 Public Const Orsoonerflag As String = "Orsoonerflag"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const ISourceDocument As String = "ISourceDocument"
			 Public Const ISourceType As String = "ISourceType"
			 Public Const Warehouselocation As String = "Warehouselocation"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Logisticsname As String = "Logisticsname"
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
            SyncLock GetType(ViewRptWorkOrderMetadata)
			
				If ViewRptWorkOrderMetadata.mapDelegates Is Nothing Then
					ViewRptWorkOrderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptWorkOrderMetadata._meta Is Nothing Then
                    ViewRptWorkOrderMetadata._meta = New ViewRptWorkOrderMetadata()
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
				

				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemcomments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shippostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orderterms", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Plannedshipdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Howreceived", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orderstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ordernotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Preparedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Suppliercompany", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdgallons", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Stdweight", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Grossweight", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Prodfulfillmentnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Transporttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Freezeprotect", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custitemid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priceunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Priceuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Standardunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Actualcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Actualcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Actualunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Freightcarrier", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orsoonerflag", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ISourceDocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ISourceType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehouselocation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptWorkOrder"
				meta.Destination = "viewRptWorkOrder"
				
				meta.spInsert = "proc_viewRptWorkOrderInsert"
				meta.spUpdate = "proc_viewRptWorkOrderUpdate"
				meta.spDelete = "proc_viewRptWorkOrderDelete"
				meta.spLoadAll = "proc_viewRptWorkOrderLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptWorkOrderLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptWorkOrderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
