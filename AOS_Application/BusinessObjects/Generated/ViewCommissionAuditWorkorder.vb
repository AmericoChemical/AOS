'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/14/2016 12:29:59 PM
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
	MustInherit Public Class esViewCommissionAuditWorkorderCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCommissionAuditWorkorderCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCommissionAuditWorkorderQuery)
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
            Me.InitQuery(CType(query, esViewCommissionAuditWorkorderQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCommissionAuditWorkorder) As ViewCommissionAuditWorkorder
			Return CType(MyBase.DetachEntity(entity), ViewCommissionAuditWorkorder)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCommissionAuditWorkorder) As ViewCommissionAuditWorkorder
			Return CType(MyBase.AttachEntity(entity), ViewCommissionAuditWorkorder)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCommissionAuditWorkorderCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCommissionAuditWorkorder
            Get
                Return TryCast(MyBase.Item(index), ViewCommissionAuditWorkorder)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCommissionAuditWorkorder)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCommissionAuditWorkorder	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCommissionAuditWorkorderQuery
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
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Billable"
							Me.str.Billable = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Itemprice"
							Me.str.Itemprice = CType(value, string)
												
						Case "Itemprofit"
							Me.str.Itemprofit = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Extprice"
							Me.str.Extprice = CType(value, string)
												
						Case "Extcost"
							Me.str.Extcost = CType(value, string)
												
						Case "Extprofit"
							Me.str.Extprofit = CType(value, string)
												
						Case "Workorderitemstatus"
							Me.str.Workorderitemstatus = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Shipmentitemnumber"
							Me.str.Shipmentitemnumber = CType(value, string)
												
						Case "Invoiceitemnumber"
							Me.str.Invoiceitemnumber = CType(value, string)
												
						Case "Totalvolume"
							Me.str.Totalvolume = CType(value, string)
												
						Case "Volumeuom"
							Me.str.Volumeuom = CType(value, string)
												
						Case "Totalweight"
							Me.str.Totalweight = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
												
						Case "Modifiedtime"
							Me.str.Modifiedtime = CType(value, string)
												
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
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Modifiedby"
							Me.str.Modifiedby = CType(value, string)
					
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
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Billable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Billable = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Itemprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Itemprofit = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Extprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extprofit = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Shipmentitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipmentitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoiceitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoiceitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Totalvolume"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Totalvolume = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Totalweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Totalweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Modifiedtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifiedtime = CType(value, Nullable(Of System.DateTime))
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
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCommissionAuditWorkorder.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.BILLABLE
		' </summary>
		Public Overridable Property Billable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewCommissionAuditWorkorderMetadata.ColumnNames.Billable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewCommissionAuditWorkorderMetadata.ColumnNames.Billable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.ITEMPRICE
		' </summary>
		Public Overridable Property Itemprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.ITEMPROFIT
		' </summary>
		Public Overridable Property Itemprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.EXTPRICE
		' </summary>
		Public Overridable Property Extprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Extprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Extprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.EXTCOST
		' </summary>
		Public Overridable Property Extcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Extcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Extcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.EXTPROFIT
		' </summary>
		Public Overridable Property Extprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Extprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Extprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.WORKORDERITEMSTATUS
		' </summary>
		Public Overridable Property Workorderitemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Workorderitemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Workorderitemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.SHIPMENTITEMNUMBER
		' </summary>
		Public Overridable Property Shipmentitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Shipmentitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Shipmentitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.INVOICEITEMNUMBER
		' </summary>
		Public Overridable Property Invoiceitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Invoiceitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Invoiceitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.TOTALVOLUME
		' </summary>
		Public Overridable Property Totalvolume As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Totalvolume)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Totalvolume, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.VOLUMEUOM
		' </summary>
		Public Overridable Property Volumeuom As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Volumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Volumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.TOTALWEIGHT
		' </summary>
		Public Overridable Property Totalweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Totalweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Totalweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.MODIFIEDTIME
		' </summary>
		Public Overridable Property Modifiedtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCommissionAuditWorkorderMetadata.ColumnNames.Modifiedtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCommissionAuditWorkorderMetadata.ColumnNames.Modifiedtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.PRICEUNITS
		' </summary>
		Public Overridable Property Priceunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Priceunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Priceunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.PRICEUOM
		' </summary>
		Public Overridable Property Priceuom As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Priceuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Priceuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.UNITPRICE
		' </summary>
		Public Overridable Property Unitprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.STANDARDCOSTUNITS
		' </summary>
		Public Overridable Property Standardcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.STANDARDCOSTUOM
		' </summary>
		Public Overridable Property Standardcostuom As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.STANDARDUNITCOST
		' </summary>
		Public Overridable Property Standardunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.ACTUALCOSTUNITS
		' </summary>
		Public Overridable Property Actualcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.ACTUALCOSTUOM
		' </summary>
		Public Overridable Property Actualcostuom As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.ACTUALUNITCOST
		' </summary>
		Public Overridable Property Actualunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditWorkorderMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditWorkorder.MODIFIEDBY
		' </summary>
		Public Overridable Property Modifiedby As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Modifiedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditWorkorderMetadata.ColumnNames.Modifiedby, value)
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
		
			Public Sub New(ByVal entity As esViewCommissionAuditWorkorder)
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
		  	
			Public Property Billable As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Billable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billable = Nothing
					Else
						entity.Billable = Convert.ToBoolean(Value)
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
		  	
			Public Property Itemprofit As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Itemprofit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemprofit = Nothing
					Else
						entity.Itemprofit = Convert.ToDecimal(Value)
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
		  	
			Public Property Extprofit As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extprofit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extprofit = Nothing
					Else
						entity.Extprofit = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Workorderitemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Workorderitemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderitemstatus = Nothing
					Else
						entity.Workorderitemstatus = Convert.ToString(Value)
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
		  	
			Public Property Shipmentitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Shipmentitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentitemnumber = Nothing
					Else
						entity.Shipmentitemnumber = Convert.ToInt32(Value)
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
		  	
			Public Property Totalvolume As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Totalvolume
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalvolume = Nothing
					Else
						entity.Totalvolume = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeuom As System.String 
				Get
					Dim data_ As System.String = entity.Volumeuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeuom = Nothing
					Else
						entity.Volumeuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Totalweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Totalweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalweight = Nothing
					Else
						entity.Totalweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightuom As System.String 
				Get
					Dim data_ As System.String = entity.Weightuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightuom = Nothing
					Else
						entity.Weightuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifiedtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifiedtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifiedtime = Nothing
					Else
						entity.Modifiedtime = Convert.ToDateTime(Value)
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
		  	
			Public Property Modifiedby As System.String 
				Get
					Dim data_ As System.String = entity.Modifiedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifiedby = Nothing
					Else
						entity.Modifiedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCommissionAuditWorkorder
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCommissionAuditWorkorderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCommissionAuditWorkorder can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCommissionAuditWorkorderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionAuditWorkorderMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Billable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Billable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Itemprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Itemprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Extprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Extprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Extcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Extprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Workorderitemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Shipmentitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoiceitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Invoiceitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Totalvolume As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Totalvolume, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Volumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Totalweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Totalweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Modifiedtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Priceunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Priceunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Priceuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Priceuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Standardunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Actualunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditWorkorderMetadata.ColumnNames.Modifiedby, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCommissionAuditWorkorderCollection")> _
	Partial Public Class ViewCommissionAuditWorkorderCollection
		Inherits esViewCommissionAuditWorkorderCollection
		Implements IEnumerable(Of ViewCommissionAuditWorkorder)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCommissionAuditWorkorderCollection) As List(Of ViewCommissionAuditWorkorder)
            Dim list As List(Of ViewCommissionAuditWorkorder) = New List(Of ViewCommissionAuditWorkorder)
            Dim emp As ViewCommissionAuditWorkorder

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionAuditWorkorderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionAuditWorkorderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCommissionAuditWorkorder(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCommissionAuditWorkorder()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCommissionAuditWorkorderQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCommissionAuditWorkorderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionAuditWorkorderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCommissionAuditWorkorder 
			Return CType(MyBase.AddNewEntity(), ViewCommissionAuditWorkorder)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCommissionAuditWorkorder) Implements IEnumerable(Of ViewCommissionAuditWorkorder).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCommissionAuditWorkorder)(Me)
        End Function
		
		Private _query As ViewCommissionAuditWorkorderQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCommissionAuditWorkorder' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCommissionAuditWorkorder ()")> _
	<Serializable> _
	Partial Public Class ViewCommissionAuditWorkorder 
		Inherits esViewCommissionAuditWorkorder

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCommissionAuditWorkorderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCommissionAuditWorkorderQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionAuditWorkorderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCommissionAuditWorkorderQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCommissionAuditWorkorderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionAuditWorkorderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCommissionAuditWorkorderQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCommissionAuditWorkorderQuery
		inherits esViewCommissionAuditWorkorderQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCommissionAuditWorkorderQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCommissionAuditWorkorderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Workorderitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Workordernumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemtype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemdescription, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Productid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Productdesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Container, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Qty, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Billable, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Billable
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitcost, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemprice, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Itemprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Itemprofit, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Itemprofit
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitorcontainer, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Units, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Uom, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Extprice, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Extprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Extcost, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Extcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Extprofit, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Extprofit
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Workorderitemstatus, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Workorderitemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Customerpo, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Shipmentitemnumber, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Shipmentitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Invoiceitemnumber, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Invoiceitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Totalvolume, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Totalvolume
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Volumeuom, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Volumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Totalweight, 25, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Totalweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Weightuom, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Modifiedtime, 27, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Modifiedtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Priceunits, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Priceunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Priceuom, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Priceuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Unitprice, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Unitprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardcostunits, 31, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Standardcostunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardcostuom, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Standardcostuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Standardunitcost, 33, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Standardunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualcostunits, 34, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Actualcostunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualcostuom, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Actualcostuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Actualunitcost, 36, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Actualunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Invoicenumber, 37, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditWorkorderMetadata.ColumnNames.Modifiedby, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditWorkorderMetadata.PropertyNames.Modifiedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCommissionAuditWorkorderMetadata
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
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Qty As String = "QTY"
			 Public Const Billable As String = "BILLABLE"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Itemprice As String = "ITEMPRICE"
			 Public Const Itemprofit As String = "ITEMPROFIT"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Extprice As String = "EXTPRICE"
			 Public Const Extcost As String = "EXTCOST"
			 Public Const Extprofit As String = "EXTPROFIT"
			 Public Const Workorderitemstatus As String = "WORKORDERITEMSTATUS"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Shipmentitemnumber As String = "SHIPMENTITEMNUMBER"
			 Public Const Invoiceitemnumber As String = "INVOICEITEMNUMBER"
			 Public Const Totalvolume As String = "TOTALVOLUME"
			 Public Const Volumeuom As String = "VOLUMEUOM"
			 Public Const Totalweight As String = "TOTALWEIGHT"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const Modifiedtime As String = "MODIFIEDTIME"
			 Public Const Priceunits As String = "PRICEUNITS"
			 Public Const Priceuom As String = "PRICEUOM"
			 Public Const Unitprice As String = "UNITPRICE"
			 Public Const Standardcostunits As String = "STANDARDCOSTUNITS"
			 Public Const Standardcostuom As String = "STANDARDCOSTUOM"
			 Public Const Standardunitcost As String = "STANDARDUNITCOST"
			 Public Const Actualcostunits As String = "ACTUALCOSTUNITS"
			 Public Const Actualcostuom As String = "ACTUALCOSTUOM"
			 Public Const Actualunitcost As String = "ACTUALUNITCOST"
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Modifiedby As String = "MODIFIEDBY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Qty As String = "Qty"
			 Public Const Billable As String = "Billable"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Itemprice As String = "Itemprice"
			 Public Const Itemprofit As String = "Itemprofit"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Extprice As String = "Extprice"
			 Public Const Extcost As String = "Extcost"
			 Public Const Extprofit As String = "Extprofit"
			 Public Const Workorderitemstatus As String = "Workorderitemstatus"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Shipmentitemnumber As String = "Shipmentitemnumber"
			 Public Const Invoiceitemnumber As String = "Invoiceitemnumber"
			 Public Const Totalvolume As String = "Totalvolume"
			 Public Const Volumeuom As String = "Volumeuom"
			 Public Const Totalweight As String = "Totalweight"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const Modifiedtime As String = "Modifiedtime"
			 Public Const Priceunits As String = "Priceunits"
			 Public Const Priceuom As String = "Priceuom"
			 Public Const Unitprice As String = "Unitprice"
			 Public Const Standardcostunits As String = "Standardcostunits"
			 Public Const Standardcostuom As String = "Standardcostuom"
			 Public Const Standardunitcost As String = "Standardunitcost"
			 Public Const Actualcostunits As String = "Actualcostunits"
			 Public Const Actualcostuom As String = "Actualcostuom"
			 Public Const Actualunitcost As String = "Actualunitcost"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Modifiedby As String = "Modifiedby"
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
            SyncLock GetType(ViewCommissionAuditWorkorderMetadata)
			
				If ViewCommissionAuditWorkorderMetadata.mapDelegates Is Nothing Then
					ViewCommissionAuditWorkorderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCommissionAuditWorkorderMetadata._meta Is Nothing Then
                    ViewCommissionAuditWorkorderMetadata._meta = New ViewCommissionAuditWorkorderMetadata()
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
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Billable", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Unitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Itemprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Itemprofit", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Extprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Extcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Extprofit", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Workorderitemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipmentitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoiceitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Totalvolume", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Volumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Totalweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifiedtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Priceunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Priceuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Standardunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Actualcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Actualcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Actualunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Modifiedby", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCommissionAuditWorkorder"
				meta.Destination = "viewCommissionAuditWorkorder"
				
				meta.spInsert = "proc_viewCommissionAuditWorkorderInsert"
				meta.spUpdate = "proc_viewCommissionAuditWorkorderUpdate"
				meta.spDelete = "proc_viewCommissionAuditWorkorderDelete"
				meta.spLoadAll = "proc_viewCommissionAuditWorkorderLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCommissionAuditWorkorderLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCommissionAuditWorkorderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
