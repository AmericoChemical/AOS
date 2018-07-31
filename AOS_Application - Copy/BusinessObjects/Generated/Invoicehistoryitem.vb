'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/27/2017 8:11:11 PM
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
	MustInherit Public Class esInvoicehistoryitemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "InvoicehistoryitemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esInvoicehistoryitemQuery)
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
            Me.InitQuery(CType(query, esInvoicehistoryitemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Invoicehistoryitem) As Invoicehistoryitem
			Return CType(MyBase.DetachEntity(entity), Invoicehistoryitem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Invoicehistoryitem) As Invoicehistoryitem
			Return CType(MyBase.AttachEntity(entity), Invoicehistoryitem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As InvoicehistoryitemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Invoicehistoryitem
            Get
                Return TryCast(MyBase.Item(index), Invoicehistoryitem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Invoicehistoryitem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esInvoicehistoryitem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esInvoicehistoryitemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal invoicehistoryid As System.Int32, ByVal invoiceitemnumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoicehistoryid, invoiceitemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoicehistoryid, invoiceitemnumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal invoicehistoryid As System.Int32, ByVal invoiceitemnumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoicehistoryid, invoiceitemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoicehistoryid, invoiceitemnumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal invoicehistoryid As System.Int32, ByVal invoiceitemnumber As System.Int32) As Boolean
		
			Dim query As esInvoicehistoryitemQuery = Me.GetDynamicQuery()
			query.Where(query.Invoicehistoryid.Equal(invoicehistoryid), query.Invoiceitemnumber.Equal(invoiceitemnumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal invoicehistoryid As System.Int32, ByVal invoiceitemnumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("INVOICEHISTORYID", invoicehistoryid)
						parms.Add("INVOICEITEMNUMBER", invoiceitemnumber)
			
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
												
						Case "Invoiceitemnumber"
							Me.str.Invoiceitemnumber = CType(value, string)
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Shipmentdetailid"
							Me.str.Shipmentdetailid = CType(value, string)
												
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
												
						Case "Taxable"
							Me.str.Taxable = CType(value, string)
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
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
												
						Case "Extstandardcost"
							Me.str.Extstandardcost = CType(value, string)
												
						Case "Extactualcost"
							Me.str.Extactualcost = CType(value, string)
												
						Case "Extsalesprice"
							Me.str.Extsalesprice = CType(value, string)
												
						Case "Custitemid"
							Me.str.Custitemid = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invoicehistoryid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicehistoryid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoiceitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoiceitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Shipmentdetailid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipmentdetailid = CType(value, Nullable(Of System.Int32))
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
						
						Case "Taxable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Taxable = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
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
						
						Case "Extstandardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extstandardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extactualcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extactualcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extsalesprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extsalesprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
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
		' Maps to INVOICEHISTORYITEM.INVOICEHISTORYID
		' </summary>
		Public Overridable Property Invoicehistoryid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Invoicehistoryid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Invoicehistoryid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.INVOICEITEMNUMBER
		' </summary>
		Public Overridable Property Invoiceitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Invoiceitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Invoiceitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.SHIPMENTDETAILID
		' </summary>
		Public Overridable Property Shipmentdetailid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Shipmentdetailid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Shipmentdetailid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.QUANTITY
		' </summary>
		Public Overridable Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Quantity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Quantity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.ITEMPRICE
		' </summary>
		Public Overridable Property Itemprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Itemprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Itemprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.EXTPRICE
		' </summary>
		Public Overridable Property Extprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.EXTCOST
		' </summary>
		Public Overridable Property Extcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.GROSSPROFIT
		' </summary>
		Public Overridable Property Grossprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Grossprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Grossprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.TAXABLE
		' </summary>
		Public Overridable Property Taxable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(InvoicehistoryitemMetadata.ColumnNames.Taxable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(InvoicehistoryitemMetadata.ColumnNames.Taxable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.PRICEUNITS
		' </summary>
		Public Overridable Property Priceunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Priceunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Priceunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.PRICEUOM
		' </summary>
		Public Overridable Property Priceuom As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Priceuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Priceuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.UNITPRICE
		' </summary>
		Public Overridable Property Unitprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Unitprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Unitprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.STANDARDCOSTUNITS
		' </summary>
		Public Overridable Property Standardcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Standardcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Standardcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.STANDARDCOSTUOM
		' </summary>
		Public Overridable Property Standardcostuom As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Standardcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Standardcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.STANDARDUNITCOST
		' </summary>
		Public Overridable Property Standardunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Standardunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Standardunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.ACTUALCOSTUNITS
		' </summary>
		Public Overridable Property Actualcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Actualcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Actualcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.ACTUALCOSTUOM
		' </summary>
		Public Overridable Property Actualcostuom As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Actualcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Actualcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.ACTUALUNITCOST
		' </summary>
		Public Overridable Property Actualunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Actualunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Actualunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.EXTSTANDARDCOST
		' </summary>
		Public Overridable Property Extstandardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extstandardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extstandardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.EXTACTUALCOST
		' </summary>
		Public Overridable Property Extactualcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extactualcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extactualcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.EXTSALESPRICE
		' </summary>
		Public Overridable Property Extsalesprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extsalesprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvoicehistoryitemMetadata.ColumnNames.Extsalesprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.CUSTITEMID
		' </summary>
		Public Overridable Property Custitemid As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Custitemid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Custitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryitemMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYITEM.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryitemMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryitemMetadata.ColumnNames.Itemtype, value)
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
		
			Public Sub New(ByVal entity As esInvoicehistoryitem)
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
		  	
			Public Property Invoiceitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoiceitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoiceitemnumber = Nothing
					Else
						entity.Invoiceitemnumber = Convert.ToInt32(Value)
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
		  	
			Public Property Shipmentdetailid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Shipmentdetailid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentdetailid = Nothing
					Else
						entity.Shipmentdetailid = Convert.ToInt32(Value)
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
		  	
			Public Property Extstandardcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extstandardcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extstandardcost = Nothing
					Else
						entity.Extstandardcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Extactualcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extactualcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extactualcost = Nothing
					Else
						entity.Extactualcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Extsalesprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extsalesprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extsalesprice = Nothing
					Else
						entity.Extsalesprice = Convert.ToDecimal(Value)
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
		  

			Private entity As esInvoicehistoryitem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esInvoicehistoryitemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esInvoicehistoryitem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Invoicehistoryitem 
		Inherits esInvoicehistoryitem
		
	
		
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
	MustInherit Public Class esInvoicehistoryitemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvoicehistoryitemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invoicehistoryid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Invoicehistoryid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoiceitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Invoiceitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdetailid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Shipmentdetailid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Quantity As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Quantity, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemprice As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Itemprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extprice As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Extprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extcost As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Extcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Grossprofit As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Grossprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Taxable As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Taxable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priceunits As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Priceunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Priceuom As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Priceuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitprice As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Unitprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Standardcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Standardcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Standardunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Standardunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Actualcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Actualcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Actualunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Actualunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extstandardcost As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Extstandardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extactualcost As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Extactualcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extsalesprice As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Extsalesprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Custitemid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Custitemid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryitemMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("InvoicehistoryitemCollection")> _
	Partial Public Class InvoicehistoryitemCollection
		Inherits esInvoicehistoryitemCollection
		Implements IEnumerable(Of Invoicehistoryitem)
		
        Public Shared Widening Operator CType(ByVal coll As InvoicehistoryitemCollection) As List(Of Invoicehistoryitem)
            Dim list As List(Of Invoicehistoryitem) = New List(Of Invoicehistoryitem)
            Dim emp As Invoicehistoryitem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvoicehistoryitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New InvoicehistoryitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Invoicehistoryitem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Invoicehistoryitem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As InvoicehistoryitemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New InvoicehistoryitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvoicehistoryitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Invoicehistoryitem 
			Return CType(MyBase.AddNewEntity(), Invoicehistoryitem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal invoicehistoryid As System.Int32, ByVal invoiceitemnumber As System.Int32) As Invoicehistoryitem
			Return CType(MyBase.FindByPrimaryKey(invoicehistoryid, invoiceitemnumber), Invoicehistoryitem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Invoicehistoryitem) Implements IEnumerable(Of Invoicehistoryitem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Invoicehistoryitem)(Me)
        End Function
		
		Private _query As InvoicehistoryitemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'INVOICEHISTORYITEM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Invoicehistoryitem ({Invoicehistoryid.Value},{Invoiceitemnumber.Value})")> _
	<Serializable> _
	Partial Public Class Invoicehistoryitem 
		Inherits esInvoicehistoryitem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return InvoicehistoryitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esInvoicehistoryitemQuery

			If Me._query Is Nothing Then
				Me._query = New InvoicehistoryitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As InvoicehistoryitemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New InvoicehistoryitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvoicehistoryitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As InvoicehistoryitemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class InvoicehistoryitemQuery
		inherits esInvoicehistoryitemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "InvoicehistoryitemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class InvoicehistoryitemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Invoicehistoryid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Invoicehistoryid
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Invoiceitemnumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Invoiceitemnumber
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Invoicenumber, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Shipmentdetailid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Shipmentdetailid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Invitemnumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Productid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Productdesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Quantity, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Quantity
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Container, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Units, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Uom, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Itemprice, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Itemprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Extprice, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Extprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Unitcost, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Extcost, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Extcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Grossprofit, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Grossprofit
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Taxable, 16, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Taxable
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Workorderitemnumber, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Unitorcontainer, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Priceunits, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Priceunits
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Priceuom, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Priceuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Unitprice, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Unitprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Standardcostunits, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Standardcostunits
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Standardcostuom, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Standardcostuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Standardunitcost, 24, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Standardunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Actualcostunits, 25, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Actualcostunits
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Actualcostuom, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Actualcostuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Actualunitcost, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Actualunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Extstandardcost, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Extstandardcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Extactualcost, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Extactualcost
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Extsalesprice, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Extsalesprice
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Custitemid, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Custitemid
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Itemid, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Itemdescription, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryitemMetadata.ColumnNames.Itemtype, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryitemMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As InvoicehistoryitemMetadata
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
			 Public Const Invoiceitemnumber As String = "INVOICEITEMNUMBER"
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Shipmentdetailid As String = "SHIPMENTDETAILID"
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
			 Public Const Taxable As String = "TAXABLE"
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Priceunits As String = "PRICEUNITS"
			 Public Const Priceuom As String = "PRICEUOM"
			 Public Const Unitprice As String = "UNITPRICE"
			 Public Const Standardcostunits As String = "STANDARDCOSTUNITS"
			 Public Const Standardcostuom As String = "STANDARDCOSTUOM"
			 Public Const Standardunitcost As String = "STANDARDUNITCOST"
			 Public Const Actualcostunits As String = "ACTUALCOSTUNITS"
			 Public Const Actualcostuom As String = "ACTUALCOSTUOM"
			 Public Const Actualunitcost As String = "ACTUALUNITCOST"
			 Public Const Extstandardcost As String = "EXTSTANDARDCOST"
			 Public Const Extactualcost As String = "EXTACTUALCOST"
			 Public Const Extsalesprice As String = "EXTSALESPRICE"
			 Public Const Custitemid As String = "CUSTITEMID"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Itemtype As String = "ITEMTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invoicehistoryid As String = "Invoicehistoryid"
			 Public Const Invoiceitemnumber As String = "Invoiceitemnumber"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Shipmentdetailid As String = "Shipmentdetailid"
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
			 Public Const Taxable As String = "Taxable"
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Priceunits As String = "Priceunits"
			 Public Const Priceuom As String = "Priceuom"
			 Public Const Unitprice As String = "Unitprice"
			 Public Const Standardcostunits As String = "Standardcostunits"
			 Public Const Standardcostuom As String = "Standardcostuom"
			 Public Const Standardunitcost As String = "Standardunitcost"
			 Public Const Actualcostunits As String = "Actualcostunits"
			 Public Const Actualcostuom As String = "Actualcostuom"
			 Public Const Actualunitcost As String = "Actualunitcost"
			 Public Const Extstandardcost As String = "Extstandardcost"
			 Public Const Extactualcost As String = "Extactualcost"
			 Public Const Extsalesprice As String = "Extsalesprice"
			 Public Const Custitemid As String = "Custitemid"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Itemtype As String = "Itemtype"
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
            SyncLock GetType(InvoicehistoryitemMetadata)
			
				If InvoicehistoryitemMetadata.mapDelegates Is Nothing Then
					InvoicehistoryitemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If InvoicehistoryitemMetadata._meta Is Nothing Then
                    InvoicehistoryitemMetadata._meta = New InvoicehistoryitemMetadata()
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
				meta.AddTypeMap("Invoiceitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipmentdetailid", new esTypeMap("int", "System.Int32"))
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
				meta.AddTypeMap("Taxable", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priceunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Priceuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Standardunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Actualcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Actualcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Actualunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Extstandardcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Extactualcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Extsalesprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Custitemid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "INVOICEHISTORYITEM"
				meta.Destination = "INVOICEHISTORYITEM"
				
				meta.spInsert = "proc_INVOICEHISTORYITEMInsert"
				meta.spUpdate = "proc_INVOICEHISTORYITEMUpdate"
				meta.spDelete = "proc_INVOICEHISTORYITEMDelete"
				meta.spLoadAll = "proc_INVOICEHISTORYITEMLoadAll"
				meta.spLoadByPrimaryKey = "proc_INVOICEHISTORYITEMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As InvoicehistoryitemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
